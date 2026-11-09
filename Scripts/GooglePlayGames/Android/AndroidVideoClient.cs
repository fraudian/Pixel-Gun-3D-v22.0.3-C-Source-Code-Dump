using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidVideoClient : IVideoClient
    {
        // Fields
        private UnityEngine.AndroidJavaObject mVideosClient;
        private bool mIsCaptureSupported;
        private GooglePlayGames.Android.AndroidVideoClient.OnCaptureOverlayStateListenerProxy mOnCaptureOverlayStateListenerProxy;
        
        // Methods
        public AndroidVideoClient(bool isCaptureSupported, UnityEngine.AndroidJavaObject account)
        {
            var val_15;
            var val_16;
            val_1 = new System.Object();
            this.mIsCaptureSupported = isCaptureSupported;
            UnityEngine.AndroidJavaClass val_3 = null;
            val_15 = val_3;
            val_3 = new UnityEngine.AndroidJavaClass(className:  "com.google.android.gms.games.Games");
            object[] val_4 = new object[2];
            val_4[0] = GooglePlayGames.Android.AndroidHelperFragment.GetActivity();
            val_4[1] = val_1;
            val_16 = 0;
            this.mVideosClient = val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getVideosClient", args:  val_4);
            if(val_15 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_3.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(val_16 == 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_16 = ???;
        }
        public void GetCaptureCapabilities(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback)
        {
            var val_16;
            System.Action<T1, T2> val_17;
            UnityEngine.AndroidJavaObject val_18;
            var val_19;
            AndroidVideoClient.<>c__DisplayClass4_0 val_1 = new AndroidVideoClient.<>c__DisplayClass4_0();
            if(val_1 != null)
            {
                    val_16 = val_1;
                .callback = callback;
                val_17 = GooglePlayGames.Android.AndroidVideoClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities>(toConvert:  callback);
            }
            else
            {
                    val_16 = 16;
                mem[16] = callback;
                val_17 = GooglePlayGames.Android.AndroidVideoClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities>(toConvert:  mem[16]);
            }
            
            mem[16] = val_17;
            val_18 = this.mVideosClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "getCaptureCapabilities", args:  System.Array.Empty<System.Object>());
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidVideoClient.<>c__DisplayClass4_0::<GetCaptureCapabilities>b__0(UnityEngine.AndroidJavaObject videoCapabilities));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_18, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidVideoClient.<>c__DisplayClass4_0::<GetCaptureCapabilities>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_18, callback:  null);
            val_19 = 0;
            if(val_18 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_18.Dispose();
            }
            
            if(val_19 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_18 = ???;
            val_19 = ???;
        }
        public void ShowCaptureOverlay()
        {
            GooglePlayGames.Android.AndroidHelperFragment.ShowCaptureOverlayUI();
        }
        public void GetCaptureState(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback)
        {
            var val_16;
            System.Action<T1, T2> val_17;
            UnityEngine.AndroidJavaObject val_18;
            var val_19;
            AndroidVideoClient.<>c__DisplayClass6_0 val_1 = new AndroidVideoClient.<>c__DisplayClass6_0();
            if(val_1 != null)
            {
                    val_16 = val_1;
                .callback = callback;
                val_17 = GooglePlayGames.Android.AndroidVideoClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState>(toConvert:  callback);
            }
            else
            {
                    val_16 = 16;
                mem[16] = callback;
                val_17 = GooglePlayGames.Android.AndroidVideoClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState>(toConvert:  mem[16]);
            }
            
            mem[16] = val_17;
            val_18 = this.mVideosClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "getCaptureState", args:  System.Array.Empty<System.Object>());
            System.Action<UnityEngine.AndroidJavaObject> val_6 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidVideoClient.<>c__DisplayClass6_0::<GetCaptureState>b__0(UnityEngine.AndroidJavaObject captureState));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<UnityEngine.AndroidJavaObject>(task:  val_18, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_7 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidVideoClient.<>c__DisplayClass6_0::<GetCaptureState>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_18, callback:  null);
            val_19 = 0;
            if(val_18 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_18.Dispose();
            }
            
            if(val_19 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_18 = ???;
            val_19 = ???;
        }
        public void IsCaptureAvailable(GooglePlayGames.BasicApi.VideoCaptureMode captureMode, System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback)
        {
            var val_11;
            System.Action<T1, T2> val_12;
            AndroidVideoClient.<>c__DisplayClass7_0 val_1 = new AndroidVideoClient.<>c__DisplayClass7_0();
            if(val_1 != null)
            {
                    val_11 = val_1;
                .callback = callback;
                val_12 = GooglePlayGames.Android.AndroidVideoClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Boolean>(toConvert:  callback);
            }
            else
            {
                    val_11 = 16;
                mem[16] = callback;
                val_12 = GooglePlayGames.Android.AndroidVideoClient.ToOnGameThread<GooglePlayGames.BasicApi.ResponseStatus, System.Boolean>(toConvert:  mem[16]);
            }
            
            mem[16] = val_12;
            object[] val_4 = new object[1];
            val_4[0] = (captureMode == 0) ? 0 : ((captureMode == 1) ? (-0) : 0);
            UnityEngine.AndroidJavaObject val_7 = this.mVideosClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "isCaptureAvailable", args:  val_4);
            System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  val_1, method:  System.Void AndroidVideoClient.<>c__DisplayClass7_0::<IsCaptureAvailable>b__0(bool isCaptureAvailable));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnSuccessListener<System.Boolean>(task:  val_7, callback:  null);
            System.Action<UnityEngine.AndroidJavaObject> val_9 = new System.Action<UnityEngine.AndroidJavaObject>(object:  val_1, method:  System.Void AndroidVideoClient.<>c__DisplayClass7_0::<IsCaptureAvailable>b__1(UnityEngine.AndroidJavaObject exception));
            GooglePlayGames.Android.AndroidTaskUtils.AddOnFailureListener(task:  val_7, callback:  null);
            if(val_7 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_7.Dispose();
            }
            
            if(0 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public bool IsCaptureSupported()
        {
            return (bool)this.mIsCaptureSupported;
        }
        public void RegisterCaptureOverlayStateChangedListener(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener)
        {
            if(this.mOnCaptureOverlayStateListenerProxy != null)
            {
                    this.UnregisterCaptureOverlayStateChangedListener();
            }
            
            this.mOnCaptureOverlayStateListenerProxy = new AndroidVideoClient.OnCaptureOverlayStateListenerProxy(listener:  listener);
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_2;
            }
            
            if(this.mOnCaptureOverlayStateListenerProxy != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(this.mOnCaptureOverlayStateListenerProxy == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_2[0] = this.mOnCaptureOverlayStateListenerProxy;
            UnityEngine.AndroidJavaObject val_3 = this.mVideosClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "registerOnCaptureOverlayStateChangedListener", args:  val_2);
            if(val_3 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3.Dispose();
        }
        public void UnregisterCaptureOverlayStateChangedListener()
        {
            if(this.mOnCaptureOverlayStateListenerProxy == null)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = this.mOnCaptureOverlayStateListenerProxy;
            UnityEngine.AndroidJavaObject val_2 = this.mVideosClient.Call<UnityEngine.AndroidJavaObject>(methodName:  "unregisterOnCaptureOverlayStateChangedListener", args:  val_1);
            if(val_2 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_2.Dispose();
            }
            
            this.mOnCaptureOverlayStateListenerProxy = 0;
        }
        private static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert)
        {
            mem2[0] = toConvert;
            if(((__RuntimeMethodHiddenParam + 48 + 24 + 294) & 1) != 0)
            {
                    return (System.Action<T1, T2>)__RuntimeMethodHiddenParam + 48 + 24;
            }
            
            return (System.Action<T1, T2>)__RuntimeMethodHiddenParam + 48 + 24;
        }
        private static GooglePlayGames.BasicApi.VideoQualityLevel FromVideoQualityLevel(int captureQualityJava)
        {
            return (GooglePlayGames.BasicApi.VideoQualityLevel)(captureQualityJava < 4) ? captureQualityJava : (!0);
        }
        private static GooglePlayGames.BasicApi.VideoCaptureMode FromVideoCaptureMode(int captureMode)
        {
            if(captureMode == 0)
            {
                    return (GooglePlayGames.BasicApi.VideoCaptureMode)(captureMode == 1) ? (-0) : 0;
            }
            
            return (GooglePlayGames.BasicApi.VideoCaptureMode)(captureMode == 1) ? (-0) : 0;
        }
        private static int ToVideoCaptureMode(GooglePlayGames.BasicApi.VideoCaptureMode captureMode)
        {
            if(captureMode == 0)
            {
                    return (int)(captureMode == 1) ? (-0) : 0;
            }
            
            return (int)(captureMode == 1) ? (-0) : 0;
        }
        private static GooglePlayGames.BasicApi.Video.VideoCaptureState CreateVideoCaptureState(UnityEngine.AndroidJavaObject videoCaptureState)
        {
            int val_4 = videoCaptureState.Call<System.Int32>(methodName:  "getCaptureMode", args:  System.Array.Empty<System.Object>());
            int val_8 = videoCaptureState.Call<System.Int32>(methodName:  "getCaptureQuality", args:  System.Array.Empty<System.Object>());
            .mCaptureMode = (val_4 == 0) ? 0 : ((val_4 == 1) ? (-0) : 0);
            .mQualityLevel = (val_8 < 4) ? (val_8) : (!0);
            .mIsCapturing = videoCaptureState.Call<System.Boolean>(methodName:  "isCapturing", args:  System.Array.Empty<System.Object>());
            .mIsOverlayVisible = videoCaptureState.Call<System.Boolean>(methodName:  "isOverlayVisible", args:  System.Array.Empty<System.Object>());
            .mIsPaused = videoCaptureState.Call<System.Boolean>(methodName:  "isPaused", args:  System.Array.Empty<System.Object>());
            return (GooglePlayGames.BasicApi.Video.VideoCaptureState)new GooglePlayGames.BasicApi.Video.VideoCaptureState();
        }
        private static GooglePlayGames.BasicApi.Video.VideoCapabilities CreateVideoCapabilities(UnityEngine.AndroidJavaObject videoCapabilities)
        {
            .mIsCameraSupported = videoCapabilities.Call<System.Boolean>(methodName:  "isCameraSupported", args:  System.Array.Empty<System.Object>());
            .mIsMicSupported = videoCapabilities.Call<System.Boolean>(methodName:  "isMicSupported", args:  System.Array.Empty<System.Object>());
            .mIsWriteStorageSupported = videoCapabilities.Call<System.Boolean>(methodName:  "isWriteStorageSupported", args:  System.Array.Empty<System.Object>());
            .mCaptureModesSupported = videoCapabilities.Call<System.Boolean[]>(methodName:  "getSupportedCaptureModes", args:  System.Array.Empty<System.Object>());
            .mQualityLevelsSupported = videoCapabilities.Call<System.Boolean[]>(methodName:  "getSupportedQualityLevels", args:  System.Array.Empty<System.Object>());
            return (GooglePlayGames.BasicApi.Video.VideoCapabilities)new GooglePlayGames.BasicApi.Video.VideoCapabilities();
        }
    
    }

}
