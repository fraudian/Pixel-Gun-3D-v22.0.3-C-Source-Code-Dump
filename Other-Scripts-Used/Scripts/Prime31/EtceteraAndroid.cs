using UnityEngine;

namespace Prime31
{
    public class EtceteraAndroid
    {
        // Fields
        private static UnityEngine.AndroidJavaObject _plugin;
        
        // Methods
        private static EtceteraAndroid()
        {
            var val_11;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            UnityEngine.AndroidJavaClass val_2 = null;
            val_11 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  "com.prime31.EtceteraPlugin");
            Prime31.EtceteraAndroid._plugin = val_2.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "instance", args:  System.Array.Empty<System.Object>());
            if(val_11 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_2.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_11 = ???;
        }
        public static UnityEngine.Texture2D textureFromFileAtPath(string filePath)
        {
            var val_8;
            var val_9;
            UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  1, height:  1);
            bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  System.IO.File.ReadAllBytes(path:  filePath));
            val_2.Apply();
            val_8 = 4;
            object[] val_4 = new object[4];
            if(("texture size: ") == null)
            {
                    val_8 = 0;
            }
            
            if(val_4.Length == 0)
            {
                    val_8 = 0;
            }
            
            val_4[0] = "texture size: ";
            int val_5 = val_2.width;
            if((val_5 != 0) && (val_5 == 0))
            {
                    val_9 = 0;
            }
            
            if(val_4.Length <= 1)
            {
                    val_9 = 0;
            }
            
            val_4[1] = val_5;
            if("x" == null)
            {
                    val_9 = 0;
            }
            
            if(val_4.Length <= 2)
            {
                    val_9 = 0;
            }
            
            val_4[2] = "x";
            val_4[3] = val_2.height;
            UnityEngine.Debug.Log(message:  +val_4);
            return val_2;
        }
        public static void setSystemUiVisibilityToLowProfile(bool useLowProfile)
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            val_4 = useLowProfile;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Prime31.EtceteraAndroid._plugin;
            object[] val_3 = new object[1];
            val_3[0] = val_4;
            val_4.Call(methodName:  "setSystemUiVisibilityToLowProfile", args:  val_3);
        }
        public static void playMovie(string pathOrUrl, uint bgColor, bool showControls, Prime31.EtceteraAndroid.ScalingMode scalingMode, bool closeOnTouch)
        {
            UnityEngine.AndroidJavaObject val_5;
            bool val_6;
            bool val_7;
            object val_8;
            var val_9;
            val_6 = closeOnTouch;
            val_7 = showControls;
            val_8 = pathOrUrl;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_5 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[5];
            val_2[0] = val_8;
            val_8 = 1152921504622075904;
            val_2[1] = bgColor;
            val_2[2] = val_7;
            val_7 = val_6;
            val_2[3] = scalingMode;
            val_6 = val_7;
            val_2[4] = val_6;
            val_5.Call(methodName:  "playMovie", args:  val_2);
        }
        public static void setAlertDialogTheme(int theme)
        {
            UnityEngine.AndroidJavaObject val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[1];
            val_2[0] = theme;
            val_3.Call(methodName:  "setAlertDialogTheme", args:  val_2);
        }
        public static void showToast(string text, bool useShortDuration)
        {
            UnityEngine.AndroidJavaObject val_4;
            object val_5;
            var val_6;
            val_5 = text;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_4 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[2];
            val_2[0] = val_5;
            val_5 = useShortDuration;
            val_2[1] = val_5;
            val_4.Call(methodName:  "showToast", args:  val_2);
        }
        public static void showAlert(string title, string message, string positiveButton)
        {
            Prime31.EtceteraAndroid.showAlert(title:  title, message:  message, positiveButton:  positiveButton, negativeButton:  System.String.alignConst);
        }
        public static void showAlert(string title, string message, string positiveButton, string negativeButton)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[4];
            val_2[0] = title;
            val_2[1] = message;
            val_2[2] = positiveButton;
            val_2[3] = negativeButton;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showAlert", args:  val_2);
        }
        public static void showAlertPrompt(string title, string message, string promptHint, string promptText, string positiveButton, string negativeButton)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[6];
            val_2[0] = title;
            val_2[1] = message;
            val_2[2] = promptHint;
            val_2[3] = promptText;
            val_2[4] = positiveButton;
            val_2[5] = negativeButton;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showAlertPrompt", args:  val_2);
        }
        public static void showAlertPromptWithTwoFields(string title, string message, string promptHintOne, string promptTextOne, string promptHintTwo, string promptTextTwo, string positiveButton, string negativeButton)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[8];
            val_2[0] = title;
            val_2[1] = message;
            val_2[2] = promptHintOne;
            val_2[3] = promptTextOne;
            val_2[4] = promptHintTwo;
            val_2[5] = promptTextTwo;
            val_2[6] = positiveButton;
            val_2[7] = negativeButton;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showAlertPromptWithTwoFields", args:  val_2);
        }
        public static void showProgressDialog(string title, string message)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            val_2[0] = title;
            val_2[1] = message;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showProgressDialog", args:  val_2);
        }
        public static void hideProgressDialog()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "hideProgressDialog", args:  System.Array.Empty<System.Object>());
        }
        public static void showWebView(string url)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = url;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showWebView", args:  val_2);
        }
        public static void showCustomWebView(string url, bool disableTitle, bool disableBackButton)
        {
            UnityEngine.AndroidJavaObject val_5;
            bool val_6;
            bool val_7;
            var val_8;
            val_6 = disableBackButton;
            val_7 = disableTitle;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_5 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[3];
            val_2[0] = url;
            val_7 = val_6;
            val_2[1] = val_7;
            val_6 = val_7;
            val_2[2] = val_6;
            val_5.Call(methodName:  "showCustomWebView", args:  val_2);
        }
        public static void showEmailComposer(string toAddress, string subject, string text, bool isHTML)
        {
            isHTML = isHTML;
            Prime31.EtceteraAndroid.showEmailComposer(toAddress:  toAddress, subject:  subject, text:  text, isHTML:  isHTML, attachmentFilePath:  System.String.alignConst);
        }
        public static void showEmailComposer(string toAddress, string subject, string text, bool isHTML, string attachmentFilePath)
        {
            bool val_4;
            var val_5;
            val_4 = isHTML;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            object[] val_2 = new object[5];
            val_2[0] = toAddress;
            val_4 = val_4;
            val_2[1] = subject;
            val_2[2] = text;
            val_2[3] = val_4;
            val_2[4] = attachmentFilePath;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showEmailComposer", args:  val_2);
        }
        public static bool isSMSComposerAvailable()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            if(Prime31.EtceteraAndroid._plugin != null)
            {
                    return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "isSMSComposerAvailable", args:  System.Array.Empty<System.Object>());
            }
            
            return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "isSMSComposerAvailable", args:  System.Array.Empty<System.Object>());
        }
        public static void showSMSComposer(string body)
        {
            Prime31.EtceteraAndroid.showSMSComposer(body:  body, recipients:  0);
        }
        public static void showSMSComposer(string body, string[] recipients)
        {
            int val_4;
            var val_5;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_4 = System.String.alignConst;
            if((recipients != null) && (recipients.Length != 0))
            {
                    val_4 = "smsto:";
                if(recipients.Length >= 1)
            {
                    do
            {
                val_4 = val_4 + recipients[0] + ";";
            }
            while((0 + 1) < recipients.Length);
            
            }
            
            }
            
            val_5 = null;
            val_5 = null;
            object[] val_4 = new object[2];
            val_4[0] = val_4;
            val_4[1] = body;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "showSMSComposer", args:  val_4);
        }
        public static void shareImageWithNativeShareIntent(string pathToImage, string chooserText)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            val_2[0] = pathToImage;
            val_2[1] = chooserText;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "shareImageWithNativeShareIntent", args:  val_2);
        }
        public static void shareWithNativeShareIntent(string text, string subject, string chooserText, string pathToImage)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[4];
            val_2[0] = text;
            val_2[1] = subject;
            val_2[2] = chooserText;
            val_2[3] = pathToImage;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "shareWithNativeShareIntent", args:  val_2);
        }
        public static void promptToTakePhoto(string name)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = name;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "promptToTakePhoto", args:  val_2);
        }
        public static void promptForPictureFromAlbum(string name)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = name;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "promptForPictureFromAlbum", args:  val_2);
        }
        public static void promptToTakeVideo(string name)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = name;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "promptToTakeVideo", args:  val_2);
        }
        public static bool saveImageToGallery(string pathToPhoto, string title)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            val_2[0] = pathToPhoto;
            val_2[1] = title;
            if(Prime31.EtceteraAndroid._plugin != null)
            {
                    return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "saveImageToGallery", args:  val_2);
            }
            
            return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "saveImageToGallery", args:  val_2);
        }
        public static void scaleImageAtPath(string pathToImage, float scale)
        {
            UnityEngine.AndroidJavaObject val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[2];
            val_2[0] = pathToImage;
            val_2[1] = scale;
            val_3.Call(methodName:  "scaleImageAtPath", args:  val_2);
        }
        public static UnityEngine.Vector2 getImageSizeAtPath(string pathToImage)
        {
            object val_10;
            var val_11;
            val_10 = pathToImage;
            if(UnityEngine.Application.platform == 11)
            {
                    val_11 = null;
                val_11 = null;
                object[] val_2 = new object[1];
                val_2[0] = val_10;
                char[] val_4 = new char[1];
                val_4[0] = ',';
                val_10 = Prime31.EtceteraAndroid._plugin.Call<System.String>(methodName:  "getImageSizeAtPath", args:  val_2).Split(separator:  val_4);
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  (float)System.Int32.Parse(s:  val_10[0]), y:  (float)System.Int32.Parse(s:  val_10[1]));
                return new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            }
            
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        public static void enableImmersiveMode(bool shouldEnable)
        {
            UnityEngine.AndroidJavaObject val_4;
            var val_5;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[1];
            val_2[0] = shouldEnable;
            val_4.Call(methodName:  "enableImmersiveMode", args:  val_2);
        }
        public static void loadContacts(int startingIndex, int totalToRetrieve)
        {
            UnityEngine.AndroidJavaObject val_3;
            int val_4;
            var val_5;
            val_4 = totalToRetrieve;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[2];
            val_2[0] = startingIndex;
            val_4 = val_4;
            val_2[1] = val_4;
            val_3.Call(methodName:  "loadContacts", args:  val_2);
        }
        public static void initTTS()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "initTTS", args:  System.Array.Empty<System.Object>());
        }
        public static void teardownTTS()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "teardownTTS", args:  System.Array.Empty<System.Object>());
        }
        public static void speak(string text)
        {
            Prime31.EtceteraAndroid.speak(text:  text, queueMode:  1);
        }
        public static void speak(string text, Prime31.TTSQueueMode queueMode)
        {
            UnityEngine.AndroidJavaObject val_3;
            Prime31.TTSQueueMode val_4;
            var val_5;
            val_4 = queueMode;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[2];
            val_2[0] = text;
            val_4 = val_4;
            val_2[1] = val_4;
            val_3.Call(methodName:  "speak", args:  val_2);
        }
        public static void stop()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "stop", args:  System.Array.Empty<System.Object>());
        }
        public static void playSilence(long durationInMs, Prime31.TTSQueueMode queueMode)
        {
            UnityEngine.AndroidJavaObject val_3;
            Prime31.TTSQueueMode val_4;
            var val_5;
            val_4 = queueMode;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[2];
            val_2[0] = durationInMs;
            val_4 = val_4;
            val_2[1] = val_4;
            val_3.Call(methodName:  "playSilence", args:  val_2);
        }
        public static void setPitch(float pitch)
        {
            UnityEngine.AndroidJavaObject val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[1];
            val_2[0] = pitch;
            val_3.Call(methodName:  "setPitch", args:  val_2);
        }
        public static void setSpeechRate(float rate)
        {
            UnityEngine.AndroidJavaObject val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[1];
            val_2[0] = rate;
            val_3.Call(methodName:  "setSpeechRate", args:  val_2);
        }
        public static void askForReviewSetButtonTitles(string remindMeLaterTitle, string dontAskAgainTitle, string rateItTitle)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[3];
            val_2[0] = remindMeLaterTitle;
            val_2[1] = dontAskAgainTitle;
            val_2[2] = rateItTitle;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "askForReviewSetButtonTitles", args:  val_2);
        }
        public static void askForReview(int launchesUntilPrompt, int hoursUntilFirstPrompt, int hoursBetweenPrompts, string title, string message, bool isAmazonAppStore = False)
        {
            UnityEngine.AndroidJavaObject val_3;
            int val_4;
            int val_5;
            var val_6;
            var val_7;
            val_3 = isAmazonAppStore;
            val_4 = hoursBetweenPrompts;
            val_5 = launchesUntilPrompt;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            if(val_3 != false)
            {
                    val_6 = null;
                val_6 = null;
                Prime31.EtceteraAndroid._plugin.Set<System.Boolean>(fieldName:  "isAmazonAppStore", val:  true);
            }
            
            val_7 = null;
            val_7 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[5];
            val_5 = val_5;
            val_2[0] = val_5;
            val_2[1] = hoursUntilFirstPrompt;
            val_4 = val_4;
            val_2[2] = val_4;
            val_2[3] = title;
            val_2[4] = message;
            val_3.Call(methodName:  "askForReview", args:  val_2);
        }
        public static void askForReviewNow(string title, string message, bool isAmazonAppStore = False)
        {
            var val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            if(isAmazonAppStore != false)
            {
                    val_3 = null;
                val_3 = null;
                Prime31.EtceteraAndroid._plugin.Set<System.Boolean>(fieldName:  "isAmazonAppStore", val:  true);
            }
            
            val_4 = null;
            val_4 = null;
            object[] val_2 = new object[2];
            val_2[0] = title;
            val_2[1] = message;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "askForReviewNow", args:  val_2);
        }
        public static void resetAskForReview()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "resetAskForReview", args:  System.Array.Empty<System.Object>());
        }
        public static void openReviewPageInPlayStore(bool isAmazonAppStore = False)
        {
            var val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            if(isAmazonAppStore != false)
            {
                    val_3 = null;
                val_3 = null;
                Prime31.EtceteraAndroid._plugin.Set<System.Boolean>(fieldName:  "isAmazonAppStore", val:  true);
            }
            
            val_4 = null;
            val_4 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "openReviewPageInPlayStore", args:  System.Array.Empty<System.Object>());
        }
        public static void inlineWebViewShow(string url, int x, int y, int width, int height)
        {
            UnityEngine.AndroidJavaObject val_3;
            int val_4;
            int val_5;
            var val_6;
            val_4 = height;
            val_5 = y;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[5];
            val_2[0] = url;
            val_2[1] = x;
            val_5 = val_5;
            val_2[2] = val_5;
            val_2[3] = width;
            val_4 = val_4;
            val_2[4] = val_4;
            val_3.Call(methodName:  "inlineWebViewShow", args:  val_2);
        }
        public static void inlineWebViewClose()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "inlineWebViewClose", args:  System.Array.Empty<System.Object>());
        }
        public static void inlineWebViewSetUrl(string url)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = url;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "inlineWebViewSetUrl", args:  val_2);
        }
        public static void inlineWebViewSetFrame(int x, int y, int width, int height)
        {
            UnityEngine.AndroidJavaObject val_3;
            int val_4;
            int val_5;
            var val_6;
            val_4 = height;
            val_5 = y;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[4];
            val_2[0] = x;
            val_5 = val_5;
            val_2[1] = val_5;
            val_2[2] = width;
            val_4 = val_4;
            val_2[3] = val_4;
            val_3.Call(methodName:  "inlineWebViewSetFrame", args:  val_2);
        }
        public static int scheduleNotification(long secondsFromNow, string title, string subtitle, string tickerText, string extraData, int requestCode = -1)
        {
            Prime31.AndroidNotificationConfiguration val_1 = new Prime31.AndroidNotificationConfiguration(secondsFromNow:  secondsFromNow, title:  title, subtitle:  subtitle, tickerText:  tickerText);
            if(val_1 != null)
            {
                    .extraData = extraData;
            }
            else
            {
                    mem[48] = extraData;
            }
            
            .requestCode = requestCode;
            return Prime31.EtceteraAndroid.scheduleNotification(config:  val_1);
        }
        public static int scheduleNotification(long secondsFromNow, string title, string subtitle, string tickerText, string extraData, string smallIcon, string largeIcon, int requestCode = -1)
        {
            Prime31.AndroidNotificationConfiguration val_1 = new Prime31.AndroidNotificationConfiguration(secondsFromNow:  secondsFromNow, title:  title, subtitle:  subtitle, tickerText:  tickerText);
            if(val_1 != null)
            {
                    .extraData = extraData;
                .smallIcon = smallIcon;
                .largeIcon = largeIcon;
            }
            else
            {
                    mem[48] = extraData;
                mem[56] = smallIcon;
                mem[64] = largeIcon;
            }
            
            .requestCode = requestCode;
            return Prime31.EtceteraAndroid.scheduleNotification(config:  val_1);
        }
        public static int scheduleNotification(Prime31.AndroidNotificationConfiguration config)
        {
            var val_5;
            if(UnityEngine.Application.platform != 11)
            {
                    return 0;
            }
            
            if(config.requestCode == 1)
            {
                    config.requestCode = UnityEngine.Random.Range(min:  0, max:  2147483647);
            }
            
            val_5 = null;
            val_5 = null;
            object[] val_3 = new object[1];
            val_3[0] = Prime31.Json.encode(obj:  config);
            if(Prime31.EtceteraAndroid._plugin != null)
            {
                    return Prime31.EtceteraAndroid._plugin.Call<System.Int32>(methodName:  "scheduleNotification", args:  val_3);
            }
            
            return Prime31.EtceteraAndroid._plugin.Call<System.Int32>(methodName:  "scheduleNotification", args:  val_3);
        }
        public static void cancelNotification(int notificationId)
        {
            UnityEngine.AndroidJavaObject val_3;
            var val_4;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[1];
            val_2[0] = notificationId;
            val_3.Call(methodName:  "cancelNotification", args:  val_2);
        }
        public static void cancelAllNotifications()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "cancelAllNotifications", args:  System.Array.Empty<System.Object>());
        }
        public static void checkForNotifications()
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            Prime31.EtceteraAndroid._plugin.Call(methodName:  "checkForNotifications", args:  System.Array.Empty<System.Object>());
        }
        public static void requestPermissions(string[] permissions, int requestCode = 575757)
        {
            UnityEngine.AndroidJavaObject val_3;
            int val_4;
            var val_5;
            val_4 = requestCode;
            if(UnityEngine.Application.platform != 11)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_3 = Prime31.EtceteraAndroid._plugin;
            object[] val_2 = new object[2];
            val_2[0] = permissions;
            val_4 = val_4;
            val_2[1] = val_4;
            val_3.Call(methodName:  "requestPermissions", args:  val_2);
        }
        public static bool shouldShowRequestPermissionRationale(string permission)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = permission;
            if(Prime31.EtceteraAndroid._plugin != null)
            {
                    return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "shouldShowRequestPermissionRationale", args:  val_2);
            }
            
            return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "shouldShowRequestPermissionRationale", args:  val_2);
        }
        public static bool checkSelfPermission(string permission)
        {
            var val_3;
            if(UnityEngine.Application.platform != 11)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = permission;
            if(Prime31.EtceteraAndroid._plugin != null)
            {
                    return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "checkSelfPermission", args:  val_2);
            }
            
            return Prime31.EtceteraAndroid._plugin.Call<System.Boolean>(methodName:  "checkSelfPermission", args:  val_2);
        }
        public EtceteraAndroid()
        {
        
        }
    
    }

}
