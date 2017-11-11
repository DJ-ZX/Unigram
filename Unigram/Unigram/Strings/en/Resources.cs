//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by ResW File Code Generator (http://bit.ly/reswcodegen)
// 	ResW File Code Generator was written by Christian Resma Helle
// 	and is under GNU General Public License version 2 (GPLv2)
// 
// 	This code contains a helper class exposing property representations
// 	of the string resources defined in the specified .ResW file
// 
// 	Generated: 11/11/2017 18:59:34
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
namespace Unigram.Strings
{
    using Windows.ApplicationModel.Resources;
    
    
    public sealed partial class Resources
    {
        
        private static ResourceLoader resourceLoader;
        
        static Resources()
        {
            string executingAssemblyName;
            executingAssemblyName = Windows.UI.Xaml.Application.Current.GetType().AssemblyQualifiedName;
            string[] executingAssemblySplit;
            executingAssemblySplit = executingAssemblyName.Split(',');
            executingAssemblyName = executingAssemblySplit[1];
            string currentAssemblyName;
            currentAssemblyName = typeof(Resources).AssemblyQualifiedName;
            string[] currentAssemblySplit;
            currentAssemblySplit = currentAssemblyName.Split(',');
            currentAssemblyName = currentAssemblySplit[1];
            if (executingAssemblyName.Equals(currentAssemblyName))
            {
                resourceLoader = ResourceLoader.GetForCurrentView("Resources");
            }
            else
            {
                resourceLoader = ResourceLoader.GetForCurrentView(currentAssemblyName + "/Resources");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} are typing"
        /// </summary>
        public static string AreTyping
        {
            get
            {
                return resourceLoader.GetString("AreTyping");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is playing a game"
        /// </summary>
        public static string IsPlayingGame
        {
            get
            {
                return resourceLoader.GetString("IsPlayingGame");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is recording a voice message"
        /// </summary>
        public static string IsRecordingAudio
        {
            get
            {
                return resourceLoader.GetString("IsRecordingAudio");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is recording a video"
        /// </summary>
        public static string IsRecordingVideo
        {
            get
            {
                return resourceLoader.GetString("IsRecordingVideo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is sending a audio"
        /// </summary>
        public static string IsSendingAudio
        {
            get
            {
                return resourceLoader.GetString("IsSendingAudio");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is sending a file"
        /// </summary>
        public static string IsSendingFile
        {
            get
            {
                return resourceLoader.GetString("IsSendingFile");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is sending a photo"
        /// </summary>
        public static string IsSendingPhoto
        {
            get
            {
                return resourceLoader.GetString("IsSendingPhoto");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is sending a video"
        /// </summary>
        public static string IsSendingVideo
        {
            get
            {
                return resourceLoader.GetString("IsSendingVideo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is typing"
        /// </summary>
        public static string IsTyping
        {
            get
            {
                return resourceLoader.GetString("IsTyping");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Playing a game"
        /// </summary>
        public static string PlayingGame
        {
            get
            {
                return resourceLoader.GetString("PlayingGame");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Recording a video"
        /// </summary>
        public static string RecordingVideo
        {
            get
            {
                return resourceLoader.GetString("RecordingVideo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Recording a voice message"
        /// </summary>
        public static string RecordingVoiceMessage
        {
            get
            {
                return resourceLoader.GetString("RecordingVoiceMessage");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Sending an audio"
        /// </summary>
        public static string SendingAudio
        {
            get
            {
                return resourceLoader.GetString("SendingAudio");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Sending a file"
        /// </summary>
        public static string SendingFile
        {
            get
            {
                return resourceLoader.GetString("SendingFile");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Sending a photo"
        /// </summary>
        public static string SendingPhoto
        {
            get
            {
                return resourceLoader.GetString("SendingPhoto");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Sending a video"
        /// </summary>
        public static string SendingVideo
        {
            get
            {
                return resourceLoader.GetString("SendingVideo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Typing"
        /// </summary>
        public static string Typing
        {
            get
            {
                return resourceLoader.GetString("Typing");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} minute"
        /// </summary>
        public static string CallMinutes_1
        {
            get
            {
                return resourceLoader.GetString("CallMinutes_1");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} minutes"
        /// </summary>
        public static string CallMinutes_2
        {
            get
            {
                return resourceLoader.GetString("CallMinutes_2");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} minutes"
        /// </summary>
        public static string CallMinutes_3_10
        {
            get
            {
                return resourceLoader.GetString("CallMinutes_3_10");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} minutes"
        /// </summary>
        public static string CallMinutes_any
        {
            get
            {
                return resourceLoader.GetString("CallMinutes_any");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} second"
        /// </summary>
        public static string CallSeconds_1
        {
            get
            {
                return resourceLoader.GetString("CallSeconds_1");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} seconds"
        /// </summary>
        public static string CallSeconds_2
        {
            get
            {
                return resourceLoader.GetString("CallSeconds_2");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} seconds"
        /// </summary>
        public static string CallSeconds_3_10
        {
            get
            {
                return resourceLoader.GetString("CallSeconds_3_10");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} seconds"
        /// </summary>
        public static string CallSeconds_any
        {
            get
            {
                return resourceLoader.GetString("CallSeconds_any");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} min"
        /// </summary>
        public static string CallShortMinutes_1
        {
            get
            {
                return resourceLoader.GetString("CallShortMinutes_1");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} min"
        /// </summary>
        public static string CallShortMinutes_2
        {
            get
            {
                return resourceLoader.GetString("CallShortMinutes_2");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} min"
        /// </summary>
        public static string CallShortMinutes_3_10
        {
            get
            {
                return resourceLoader.GetString("CallShortMinutes_3_10");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} min"
        /// </summary>
        public static string CallShortMinutes_any
        {
            get
            {
                return resourceLoader.GetString("CallShortMinutes_any");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} sec"
        /// </summary>
        public static string CallShortSeconds_1
        {
            get
            {
                return resourceLoader.GetString("CallShortSeconds_1");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} sec"
        /// </summary>
        public static string CallShortSeconds_2
        {
            get
            {
                return resourceLoader.GetString("CallShortSeconds_2");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} sec"
        /// </summary>
        public static string CallShortSeconds_3_10
        {
            get
            {
                return resourceLoader.GetString("CallShortSeconds_3_10");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} sec"
        /// </summary>
        public static string CallShortSeconds_any
        {
            get
            {
                return resourceLoader.GetString("CallShortSeconds_any");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Cancelled Call"
        /// </summary>
        public static string CallCanceled
        {
            get
            {
                return resourceLoader.GetString("CallCanceled");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Incoming Call"
        /// </summary>
        public static string CallIncoming
        {
            get
            {
                return resourceLoader.GetString("CallIncoming");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Missed Call"
        /// </summary>
        public static string CallMissed
        {
            get
            {
                return resourceLoader.GetString("CallMissed");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Outgoing Call"
        /// </summary>
        public static string CallOutgoing
        {
            get
            {
                return resourceLoader.GetString("CallOutgoing");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} ({1})"
        /// </summary>
        public static string CallTimeFormat
        {
            get
            {
                return resourceLoader.GetString("CallTimeFormat");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Cancelled"
        /// </summary>
        public static string CallCanceledShort
        {
            get
            {
                return resourceLoader.GetString("CallCanceledShort");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Incoming"
        /// </summary>
        public static string CallIncomingShort
        {
            get
            {
                return resourceLoader.GetString("CallIncomingShort");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Missed"
        /// </summary>
        public static string CallMissedShort
        {
            get
            {
                return resourceLoader.GetString("CallMissedShort");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Outgoing"
        /// </summary>
        public static string CallOutgoingShort
        {
            get
            {
                return resourceLoader.GetString("CallOutgoingShort");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Recording a video message"
        /// </summary>
        public static string RecordingVideoMessage
        {
            get
            {
                return resourceLoader.GetString("RecordingVideoMessage");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Sending a video message"
        /// </summary>
        public static string SendingVideoMessage
        {
            get
            {
                return resourceLoader.GetString("SendingVideoMessage");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is recording a video message"
        /// </summary>
        public static string IsRecordingVideoMessage
        {
            get
            {
                return resourceLoader.GetString("IsRecordingVideoMessage");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "{0} is sending a video message"
        /// </summary>
        public static string IsSendingVideoMessage
        {
            get
            {
                return resourceLoader.GetString("IsSendingVideoMessage");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Forever"
        /// </summary>
        public static string UserRestrictionsUntilForever
        {
            get
            {
                return resourceLoader.GetString("UserRestrictionsUntilForever");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Cancel"
        /// </summary>
        public static string Cancel
        {
            get
            {
                return resourceLoader.GetString("Cancel");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "The app will be closed. Relaunch it to login again."
        /// </summary>
        public static string TGLogoutSucceededDialogText
        {
            get
            {
                return resourceLoader.GetString("TGLogoutSucceededDialogText");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Are you sure you want to logout?"
        /// </summary>
        public static string TGLogoutText
        {
            get
            {
                return resourceLoader.GetString("TGLogoutText");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Please note that Telegram Support is done by volunteers. We try to respond as quickly as possible, but it may take a while. Please take a look at the Telegram FAQ: it has important troubleshooting tips and answers to most questions."
        /// </summary>
        public static string TGSupportDisclaimerDetails
        {
            get
            {
                return resourceLoader.GetString("TGSupportDisclaimerDetails");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "FAQ"
        /// </summary>
        public static string TGSupportDisclaimerPrimaryText
        {
            get
            {
                return resourceLoader.GetString("TGSupportDisclaimerPrimaryText");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "No"
        /// </summary>
        public static string No
        {
            get
            {
                return resourceLoader.GetString("No");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Are you sure?"
        /// </summary>
        public static string UnblockUserConfirmationDialogText
        {
            get
            {
                return resourceLoader.GetString("UnblockUserConfirmationDialogText");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Unblock?"
        /// </summary>
        public static string UnblockUserConfirmationDialogTitle
        {
            get
            {
                return resourceLoader.GetString("UnblockUserConfirmationDialogTitle");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Yes"
        /// </summary>
        public static string Yes
        {
            get
            {
                return resourceLoader.GetString("Yes");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "When using mobile data"
        /// </summary>
        public static string WhenOnMobileData
        {
            get
            {
                return resourceLoader.GetString("WhenOnMobileData");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "When connected to Wi-Fi"
        /// </summary>
        public static string WhenOnWiFi
        {
            get
            {
                return resourceLoader.GetString("WhenOnWiFi");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "When roaming"
        /// </summary>
        public static string WhenRoaming
        {
            get
            {
                return resourceLoader.GetString("WhenRoaming");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Proxy Settings"
        /// </summary>
        public static string ProxySettingsShareTitle
        {
            get
            {
                return resourceLoader.GetString("ProxySettingsShareTitle");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Audio messages"
        /// </summary>
        public static string AutoDownload_Audio
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_Audio");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Files"
        /// </summary>
        public static string AutoDownload_Document
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_Document");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "GIFs"
        /// </summary>
        public static string AutoDownload_GIF
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_GIF");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Music"
        /// </summary>
        public static string AutoDownload_Music
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_Music");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "No media"
        /// </summary>
        public static string AutoDownload_None
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_None");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Photos"
        /// </summary>
        public static string AutoDownload_Photo
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_Photo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Video messages"
        /// </summary>
        public static string AutoDownload_Round
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_Round");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Videos"
        /// </summary>
        public static string AutoDownload_Video
        {
            get
            {
                return resourceLoader.GetString("AutoDownload_Video");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "More info"
        /// </summary>
        public static string MoreInfo
        {
            get
            {
                return resourceLoader.GetString("MoreInfo");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "OK"
        /// </summary>
        public static string OK
        {
            get
            {
                return resourceLoader.GetString("OK");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Reset all notifications?"
        /// </summary>
        public static string ResetNotificationsDialogBody
        {
            get
            {
                return resourceLoader.GetString("ResetNotificationsDialogBody");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Confirm"
        /// </summary>
        public static string ResetNotificationsDialogTitle
        {
            get
            {
                return resourceLoader.GetString("ResetNotificationsDialogTitle");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Edit permissions"
        /// </summary>
        public static string ParticipantEdit
        {
            get
            {
                return resourceLoader.GetString("ParticipantEdit");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Promote"
        /// </summary>
        public static string ParticipantPromote
        {
            get
            {
                return resourceLoader.GetString("ParticipantPromote");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Restrict"
        /// </summary>
        public static string ParticipantRestrict
        {
            get
            {
                return resourceLoader.GetString("ParticipantRestrict");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Clear history"
        /// </summary>
        public static string DialogClearHistory
        {
            get
            {
                return resourceLoader.GetString("DialogClearHistory");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete conversation"
        /// </summary>
        public static string DialogDelete
        {
            get
            {
                return resourceLoader.GetString("DialogDelete");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete and exit"
        /// </summary>
        public static string DialogDeleteAndExit
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteAndExit");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete and stop"
        /// </summary>
        public static string DialogDeleteAndStop
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteAndStop");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete channel"
        /// </summary>
        public static string DialogDeleteChannel
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteChannel");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Delete group"
        /// </summary>
        public static string DialogDeleteGroup
        {
            get
            {
                return resourceLoader.GetString("DialogDeleteGroup");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Leave channel"
        /// </summary>
        public static string DialogLeaveChannel
        {
            get
            {
                return resourceLoader.GetString("DialogLeaveChannel");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Leave group"
        /// </summary>
        public static string DialogLeaveGroup
        {
            get
            {
                return resourceLoader.GetString("DialogLeaveGroup");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Disable notifications"
        /// </summary>
        public static string DialogNotificationsDisable
        {
            get
            {
                return resourceLoader.GetString("DialogNotificationsDisable");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Enable notifications"
        /// </summary>
        public static string DialogNotificationsEnable
        {
            get
            {
                return resourceLoader.GetString("DialogNotificationsEnable");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Pin to top"
        /// </summary>
        public static string DialogPin
        {
            get
            {
                return resourceLoader.GetString("DialogPin");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Unpin from top"
        /// </summary>
        public static string DialogUnpin
        {
            get
            {
                return resourceLoader.GetString("DialogUnpin");
            }
        }
    }
}
