using UnityEngine;

namespace Prime31
{
    public class EtceteraAndroidManager : AbstractManager
    {
        // Fields
        private static System.Action<string> alertButtonClickedEvent;
        private static System.Action alertCancelledEvent;
        private static System.Action<string> promptFinishedWithTextEvent;
        private static System.Action promptCancelledEvent;
        private static System.Action<string, string> twoFieldPromptFinishedWithTextEvent;
        private static System.Action twoFieldPromptCancelledEvent;
        private static System.Action webViewCancelledEvent;
        private static System.Action albumChooserCancelledEvent;
        private static System.Action<string> albumChooserSucceededEvent;
        private static System.Action photoChooserCancelledEvent;
        private static System.Action<string> photoChooserSucceededEvent;
        private static System.Action<string> videoRecordingSucceededEvent;
        private static System.Action videoRecordingCancelledEvent;
        private static System.Action ttsInitializedEvent;
        private static System.Action ttsFailedToInitializeEvent;
        private static System.Action askForReviewWillOpenMarketEvent;
        private static System.Action askForReviewRemindMeLaterEvent;
        private static System.Action askForReviewDontAskAgainEvent;
        private static System.Action<string> inlineWebViewJSCallbackEvent;
        private static System.Action<string> notificationReceivedEvent;
        private static System.Action<System.Collections.Generic.List<Prime31.EtceteraAndroid.Contact>> contactsLoadedEvent;
        private static System.Action<Prime31.EtceteraAndroidManager.PermissionsResult> onRequestPermissionsResultEvent;
        
        // Methods
        public static void add_alertButtonClickedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.alertButtonClickedEvent, b:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        public static void remove_alertButtonClickedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.alertButtonClickedEvent, value:  value);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        public static void add_alertCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.alertCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.alertCancelledEvent != 1152921505022611464);
        
        }
        public static void remove_alertCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.alertCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.alertCancelledEvent != 1152921505022611464);
        
        }
        public static void add_promptFinishedWithTextEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.promptFinishedWithTextEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.promptFinishedWithTextEvent != 1152921505022611472);
        
        }
        public static void remove_promptFinishedWithTextEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.promptFinishedWithTextEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.promptFinishedWithTextEvent != 1152921505022611472);
        
        }
        public static void add_promptCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.promptCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.promptCancelledEvent != 1152921505022611480);
        
        }
        public static void remove_promptCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.promptCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.promptCancelledEvent != 1152921505022611480);
        
        }
        public static void add_twoFieldPromptFinishedWithTextEvent(System.Action<string, string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.twoFieldPromptFinishedWithTextEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.twoFieldPromptFinishedWithTextEvent != 1152921505022611488);
        
        }
        public static void remove_twoFieldPromptFinishedWithTextEvent(System.Action<string, string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.twoFieldPromptFinishedWithTextEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.twoFieldPromptFinishedWithTextEvent != 1152921505022611488);
        
        }
        public static void add_twoFieldPromptCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.twoFieldPromptCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.twoFieldPromptCancelledEvent != 1152921505022611496);
        
        }
        public static void remove_twoFieldPromptCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.twoFieldPromptCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.twoFieldPromptCancelledEvent != 1152921505022611496);
        
        }
        public static void add_webViewCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.webViewCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.webViewCancelledEvent != 1152921505022611504);
        
        }
        public static void remove_webViewCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.webViewCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.webViewCancelledEvent != 1152921505022611504);
        
        }
        public static void add_albumChooserCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.albumChooserCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.albumChooserCancelledEvent != 1152921505022611512);
        
        }
        public static void remove_albumChooserCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.albumChooserCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.albumChooserCancelledEvent != 1152921505022611512);
        
        }
        public static void add_albumChooserSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.albumChooserSucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.albumChooserSucceededEvent != 1152921505022611520);
        
        }
        public static void remove_albumChooserSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.albumChooserSucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.albumChooserSucceededEvent != 1152921505022611520);
        
        }
        public static void add_photoChooserCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.photoChooserCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.photoChooserCancelledEvent != 1152921505022611528);
        
        }
        public static void remove_photoChooserCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.photoChooserCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.photoChooserCancelledEvent != 1152921505022611528);
        
        }
        public static void add_photoChooserSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.photoChooserSucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.photoChooserSucceededEvent != 1152921505022611536);
        
        }
        public static void remove_photoChooserSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.photoChooserSucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.photoChooserSucceededEvent != 1152921505022611536);
        
        }
        public static void add_videoRecordingSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.videoRecordingSucceededEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.videoRecordingSucceededEvent != 1152921505022611544);
        
        }
        public static void remove_videoRecordingSucceededEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.videoRecordingSucceededEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.videoRecordingSucceededEvent != 1152921505022611544);
        
        }
        public static void add_videoRecordingCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.videoRecordingCancelledEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.videoRecordingCancelledEvent != 1152921505022611552);
        
        }
        public static void remove_videoRecordingCancelledEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.videoRecordingCancelledEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.videoRecordingCancelledEvent != 1152921505022611552);
        
        }
        public static void add_ttsInitializedEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.ttsInitializedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.ttsInitializedEvent != 1152921505022611560);
        
        }
        public static void remove_ttsInitializedEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 33719;
            if(((116 & 2) != 0) && (1667327849 == 0))
            {
                    val_3 = null;
            }
            
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.ttsInitializedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.ttsInitializedEvent != 1152921505022611560);
        
        }
        public static void add_ttsFailedToInitializeEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.ttsFailedToInitializeEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.ttsFailedToInitializeEvent != 1152921505022611568);
        
        }
        public static void remove_ttsFailedToInitializeEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.ttsFailedToInitializeEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.ttsFailedToInitializeEvent != 1152921505022611568);
        
        }
        public static void add_askForReviewWillOpenMarketEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.askForReviewWillOpenMarketEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.askForReviewWillOpenMarketEvent != 1152921505022611576);
        
        }
        public static void remove_askForReviewWillOpenMarketEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.askForReviewWillOpenMarketEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.askForReviewWillOpenMarketEvent != 1152921505022611576);
        
        }
        public static void add_askForReviewRemindMeLaterEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.askForReviewRemindMeLaterEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.askForReviewRemindMeLaterEvent != 1152921505022611584);
        
        }
        public static void remove_askForReviewRemindMeLaterEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.askForReviewRemindMeLaterEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.askForReviewRemindMeLaterEvent != 1152921505022611584);
        
        }
        public static void add_askForReviewDontAskAgainEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.askForReviewDontAskAgainEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.askForReviewDontAskAgainEvent != 1152921505022611592);
        
        }
        public static void remove_askForReviewDontAskAgainEvent(System.Action value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.askForReviewDontAskAgainEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.askForReviewDontAskAgainEvent != 1152921505022611592);
        
        }
        public static void add_inlineWebViewJSCallbackEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.inlineWebViewJSCallbackEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.inlineWebViewJSCallbackEvent != 1152921505022611600);
        
        }
        public static void remove_inlineWebViewJSCallbackEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.inlineWebViewJSCallbackEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.inlineWebViewJSCallbackEvent != 1152921505022611600);
        
        }
        public static void add_notificationReceivedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.notificationReceivedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.notificationReceivedEvent != 1152921505022611608);
        
        }
        public static void remove_notificationReceivedEvent(System.Action<string> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.notificationReceivedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.notificationReceivedEvent != 1152921505022611608);
        
        }
        public static void add_contactsLoadedEvent(System.Action<System.Collections.Generic.List<Prime31.EtceteraAndroid.Contact>> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.contactsLoadedEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.contactsLoadedEvent != 1152921505022611616);
        
        }
        public static void remove_contactsLoadedEvent(System.Action<System.Collections.Generic.List<Prime31.EtceteraAndroid.Contact>> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.contactsLoadedEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.contactsLoadedEvent != 1152921505022611616);
        
        }
        public static void add_onRequestPermissionsResultEvent(System.Action<Prime31.EtceteraAndroidManager.PermissionsResult> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Prime31.EtceteraAndroidManager.onRequestPermissionsResultEvent, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.onRequestPermissionsResultEvent != 1152921505022611624);
        
        }
        public static void remove_onRequestPermissionsResultEvent(System.Action<Prime31.EtceteraAndroidManager.PermissionsResult> value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Prime31.EtceteraAndroidManager.onRequestPermissionsResultEvent, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Prime31.EtceteraAndroidManager.onRequestPermissionsResultEvent != 1152921505022611624);
        
        }
        private static EtceteraAndroidManager()
        {
            Prime31.AbstractManager.initialize(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public void alertButtonClicked(string positiveButton)
        {
            var val_1;
            System.Action<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.alertButtonClickedEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.alertButtonClickedEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  positiveButton);
        }
        public void alertCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.alertCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.alertCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void promptFinishedWithText(string text)
        {
            var val_3;
            System.Action<System.String> val_4;
            var val_5;
            System.Action<System.String, System.String> val_6;
            int val_7;
            string[] val_1 = new string[1];
            val_1[0] = "|||";
            System.String[] val_2 = text.Split(separator:  val_1, options:  0);
            if(val_2.Length == 1)
            {
                    val_3 = null;
                val_3 = null;
                val_4 = Prime31.EtceteraAndroidManager.promptFinishedWithTextEvent;
                if(val_4 != null)
            {
                    val_4 = Prime31.EtceteraAndroidManager.promptFinishedWithTextEvent;
                val_4.Invoke(obj:  val_2[0]);
            }
            
            }
            
            if(val_2.Length != 2)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_6 = Prime31.EtceteraAndroidManager.twoFieldPromptFinishedWithTextEvent;
            if(val_6 == null)
            {
                    return;
            }
            
            val_6 = Prime31.EtceteraAndroidManager.twoFieldPromptFinishedWithTextEvent;
            val_7 = val_2.Length;
            if(val_7 == 0)
            {
                    val_7 = val_2.Length;
            }
            
            val_6.Invoke(arg1:  val_2[0], arg2:  val_2[1]);
        }
        public void promptCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.promptCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.promptCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void twoFieldPromptCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.twoFieldPromptCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.twoFieldPromptCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void webViewCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.webViewCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.webViewCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void albumChooserCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.albumChooserCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.albumChooserCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void albumChooserSucceeded(string path)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            if(Prime31.EtceteraAndroidManager.albumChooserSucceededEvent == null)
            {
                    return;
            }
            
            val_3 = null;
            if((System.IO.File.Exists(path:  path)) != false)
            {
                    val_4 = null;
                Prime31.EtceteraAndroidManager.albumChooserSucceededEvent.Invoke(obj:  path);
                return;
            }
            
            val_5 = null;
            if(Prime31.EtceteraAndroidManager.albumChooserCancelledEvent == null)
            {
                    return;
            }
            
            0.Invoke();
        }
        public void photoChooserCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.photoChooserCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.photoChooserCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void photoChooserSucceeded(string path)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            if(Prime31.EtceteraAndroidManager.photoChooserSucceededEvent == null)
            {
                    return;
            }
            
            val_3 = null;
            if((System.IO.File.Exists(path:  path)) != false)
            {
                    val_4 = null;
                Prime31.EtceteraAndroidManager.photoChooserSucceededEvent.Invoke(obj:  path);
                return;
            }
            
            val_5 = null;
            if(Prime31.EtceteraAndroidManager.photoChooserCancelledEvent == null)
            {
                    return;
            }
            
            0.Invoke();
        }
        public void videoRecordingSucceeded(string path)
        {
            var val_1;
            System.Action<System.String> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.videoRecordingSucceededEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.videoRecordingSucceededEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  path);
        }
        public void videoRecordingCancelled(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.videoRecordingCancelledEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.videoRecordingCancelledEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void ttsInitialized(string result)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            if((System.String.op_Equality(a:  result, b:  "1")) == false)
            {
                goto label_1;
            }
            
            val_3 = null;
            if(Prime31.EtceteraAndroidManager.ttsInitializedEvent == null)
            {
                    return;
            }
            
            if(Prime31.EtceteraAndroidManager.ttsInitializedEvent != null)
            {
                goto label_14;
            }
            
            goto label_8;
            label_1:
            val_4 = null;
            if(Prime31.EtceteraAndroidManager.ttsFailedToInitializeEvent == null)
            {
                    return;
            }
            
            if(Prime31.EtceteraAndroidManager.ttsFailedToInitializeEvent != null)
            {
                goto label_14;
            }
            
            label_8:
            label_14:
            0.Invoke();
        }
        public void ttsUtteranceCompleted(string utteranceId)
        {
            UnityEngine.Debug.Log(message:  "utterance completed: "("utterance completed: ") + utteranceId);
        }
        public void askForReviewWillOpenMarket(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.askForReviewWillOpenMarketEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.askForReviewWillOpenMarketEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void askForReviewRemindMeLater(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.askForReviewRemindMeLaterEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.askForReviewRemindMeLaterEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void askForReviewDontAskAgain(string empty)
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = Prime31.EtceteraAndroidManager.askForReviewDontAskAgainEvent;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = Prime31.EtceteraAndroidManager.askForReviewDontAskAgainEvent;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke();
        }
        public void inlineWebViewJSCallback(string message)
        {
            null = null;
            Prime31.ActionExtensions.fire<System.String>(handler:  Prime31.EtceteraAndroidManager.inlineWebViewJSCallbackEvent, param:  message);
        }
        public void notificationReceived(string extraData)
        {
            null = null;
            Prime31.ActionExtensions.fire<System.String>(handler:  Prime31.EtceteraAndroidManager.notificationReceivedEvent, param:  extraData);
        }
        private void contactsLoaded(string json)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Prime31.EtceteraAndroidManager.contactsLoadedEvent == null)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroidManager.contactsLoadedEvent.Invoke(obj:  Prime31.Json.decode<System.Collections.Generic.List<Contact>>(json:  json, rootElement:  0));
        }
        private void onRequestPermissionsResult(string json)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Prime31.EtceteraAndroidManager.onRequestPermissionsResultEvent == null)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroidManager.onRequestPermissionsResultEvent.Invoke(obj:  Prime31.Json.decode<PermissionsResult>(json:  json, rootElement:  0));
        }
        public EtceteraAndroidManager()
        {
        
        }
    
    }

}
