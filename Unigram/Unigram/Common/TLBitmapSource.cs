﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;
using Telegram.Api.Services.FileManager;
using Telegram.Api.TL;
using Unigram.Common;
using Unigram.Converters;
using Unigram.Core.Dependency;
using Unigram.Native.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Unigram.Common
{
    public static class LazyBitmapImage
    {
        public static async void SetSource(this BitmapSource bitmap, Uri uri)
        {
            var file = await StorageFile.GetFileFromApplicationUriAsync(uri);
            using (var stream = await file.OpenReadAsync())
            {
                try
                {
                    await bitmap.SetSourceAsync(stream);
                }
                catch
                {
                    Debug.Write("AGGRESSIVE");
                }
            }
        }

        public static async void SetSource(this BitmapSource bitmap, byte[] data)
        {
            using (var stream = new InMemoryRandomAccessStream())
            {
                using (var writer = new DataWriter(stream.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes(data);
                    await writer.StoreAsync();
                }

                try
                {
                    await bitmap.SetSourceAsync(stream);
                }
                catch
                {
                    Debug.Write("AGGRESSIVE");
                }
            }
        }
    }

    public class TLBitmapContext
    {
        private Dictionary<object, WeakReference<TLBitmapSource>> _context = new Dictionary<object, WeakReference<TLBitmapSource>>();

        public BitmapImage this[TLPhoto photo]
        {
            get
            {
                TLBitmapSource target;
                WeakReference<TLBitmapSource> reference;
                if (_context.TryGetValue(photo, out reference) && reference.TryGetTarget(out target))
                {
                    return target.Image;
                }

                target = new TLBitmapSource(photo);
                _context[photo] = new WeakReference<TLBitmapSource>(target);
                return target.Image;
            }
        }

        public BitmapImage this[TLDocument document]
        {
            get
            {
                TLBitmapSource target;
                WeakReference<TLBitmapSource> reference;
                if (_context.TryGetValue(document, out reference) && reference.TryGetTarget(out target))
                {
                    return target.Image;
                }

                target = new TLBitmapSource(document);
                _context[document] = new WeakReference<TLBitmapSource>(target);
                return target.Image;
            }
        }

        public BitmapImage this[TLUser user]
        {
            get
            {
                if (user.Photo == null)
                {
                    user.Photo = new TLUserProfilePhotoEmpty();
                }

                TLBitmapSource target;
                WeakReference<TLBitmapSource> reference;
                if (_context.TryGetValue(user.Photo, out reference) && reference.TryGetTarget(out target))
                {
                    return target.Image;
                }

                target = new TLBitmapSource(user);
                _context[user.Photo] = new WeakReference<TLBitmapSource>(target);
                return target.Image;
            }
        }

        public BitmapImage this[TLChat chat]
        {
            get
            {
                TLBitmapSource target;
                WeakReference<TLBitmapSource> reference;
                if (_context.TryGetValue(chat.Photo, out reference) && reference.TryGetTarget(out target))
                {
                    return target.Image;
                }

                target = new TLBitmapSource(chat);
                _context[chat.Photo] = new WeakReference<TLBitmapSource>(target);
                return target.Image;
            }
        }

        public BitmapImage this[TLChannel channel]
        {
            get
            {
                TLBitmapSource target;
                WeakReference<TLBitmapSource> reference;
                if (_context.TryGetValue(channel.Photo, out reference) && reference.TryGetTarget(out target))
                {
                    return target.Image;
                }

                target = new TLBitmapSource(channel);
                _context[channel.Photo] = new WeakReference<TLBitmapSource>(target);
                return target.Image;
            }
        }

        public void Clear()
        {
            _context.Clear();
        }
    }

    public class TLBitmapSource
    {
        public const int PHASE_PLACEHOLDER = 0;
        public const int PHASE_THUMBNAIL = 1;
        public const int PHASE_FULL = 2;

        public int Phase { get; private set; }

        public BitmapImage Image { get; private set; } = new BitmapImage();

        public TLBitmapSource() { }

        public TLBitmapSource(TLUser user)
        {
            var userProfilePhoto = user.Photo as TLUserProfilePhoto;
            if (userProfilePhoto != null)
            {
                if (TrySetSource(userProfilePhoto.PhotoSmall as TLFileLocation, PHASE_FULL) == false)
                {
                    SetProfilePlaceholder(user, "u" + user.Id, user.Id, user.FullName);
                    SetSource(userProfilePhoto.PhotoSmall as TLFileLocation, 0, PHASE_FULL);
                }
            }
            else
            {
                SetProfilePlaceholder(user, "u" + user.Id, user.Id, user.FullName);
            }
        }

        public TLBitmapSource(TLChatBase chatBase)
        {
            TLChatPhotoBase chatPhotoBase = null;

            var channel = chatBase as TLChannel;
            if (channel != null)
            {
                chatPhotoBase = channel.Photo;
            }

            var chat = chatBase as TLChat;
            if (chat != null)
            {
                chatPhotoBase = chat.Photo;
            }

            var chatPhoto = chatPhotoBase as TLChatPhoto;
            if (chatPhoto != null)
            {
                if (TrySetSource(chatPhoto.PhotoSmall as TLFileLocation, PHASE_FULL) == false)
                {
                    SetProfilePlaceholder(chatBase, "c" + chatBase.Id, chatBase.Id, chatBase.FullName);
                    SetSource(chatPhoto.PhotoSmall as TLFileLocation, 0, PHASE_FULL);
                }
            }
            else
            {
                SetProfilePlaceholder(chatBase, "c" + chatBase.Id, chatBase.Id, chatBase.FullName);
            }
        }

        public TLBitmapSource(TLPhotoBase photoBase)
        {
            var photo = photoBase as TLPhoto;
            if (photo != null)
            {
                if (TrySetSource(photo.Full, PHASE_FULL) == false)
                {
                    SetSource(photo.Thumb, PHASE_THUMBNAIL);
                    SetSource(photo.Full, PHASE_FULL);
                }
            }
        }

        public TLBitmapSource(TLDocument document)
        {
            SetSource(document.Thumb, PHASE_THUMBNAIL);
        }

        public async void SetProfilePlaceholder(object value, string group, int id, string name)
        {
            if (PHASE_PLACEHOLDER >= Phase)
            {
                Phase = PHASE_PLACEHOLDER;

                var file = await ApplicationData.Current.LocalFolder.CreateFileAsync("temp\\placeholders\\" + group + "_placeholder.png", CreationCollisionOption.OpenIfExists);
                using (var stream = await file.OpenAsync(FileAccessMode.ReadWrite))
                {
                    if (stream.Size == 0)
                    {
                        PlaceholderImageSource.Draw(BindConvert.Current.PlaceholderColors[id % 6], InitialNameStringConverter.Convert(value), stream);
                        stream.Seek(0);
                    }

                    Image.SetSource(stream);
                }
            }
        }

        public bool TrySetSource(TLPhotoSizeBase photoSizeBase, int phase)
        {
            var photoSize = photoSizeBase as TLPhotoSize;
            if (photoSize != null)
            {
                return TrySetSource(photoSize.Location as TLFileLocation, phase);
            }

            var photoCachedSize = photoSizeBase as TLPhotoCachedSize;
            if (photoCachedSize != null)
            {
                if (phase >= Phase)
                {
                    Phase = phase;
                    Image.SetSource(photoCachedSize.Bytes);
                    return true;
                }
            }

            return false;
        }

        public void SetSource(TLPhotoSizeBase photoSizeBase, int phase)
        {
            var photoSize = photoSizeBase as TLPhotoSize;
            if (photoSize != null)
            {
                SetSource(photoSize.Location as TLFileLocation, photoSize.Size, phase);
            }

            var photoCachedSize = photoSizeBase as TLPhotoCachedSize;
            if (photoCachedSize != null)
            {
                if (phase >= Phase)
                {
                    Phase = phase;
                    Image.SetSource(photoCachedSize.Bytes);
                }
            }
        }

        public bool TrySetSource(TLFileLocation location, int phase)
        {
            if (phase >= Phase && location != null)
            {
                var fileName = string.Format("{0}_{1}_{2}.jpg", location.VolumeId, location.LocalId, location.Secret);
                if (File.Exists(FileUtils.GetTempFileName(fileName)))
                {
                    Phase = phase;

                    Image.SetSource(FileUtils.GetTempFileUri(fileName));
                    return true;
                }
            }

            return false;
        }

        public void SetSource(TLFileLocation location, int fileSize, int phase)
        {
            if (phase >= Phase && location != null)
            {
                Phase = phase;

                var fileName = string.Format("{0}_{1}_{2}.jpg", location.VolumeId, location.LocalId, location.Secret);
                if (File.Exists(FileUtils.GetTempFileName(fileName)))
                {
                    Image.SetSource(FileUtils.GetTempFileUri(fileName));
                }
                else
                {
                    Execute.BeginOnThreadPool(async () =>
                    {
                        var manager = UnigramContainer.Instance.ResolveType<IDownloadFileManager>();
                        await manager.DownloadFileAsync(location, fileSize);

                        Execute.BeginOnUIThread(() =>
                        {
                            Image.SetSource(FileUtils.GetTempFileUri(fileName));
                        });
                    });
                }
            }
        }
    }
}