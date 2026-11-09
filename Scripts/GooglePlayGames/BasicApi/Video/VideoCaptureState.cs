using UnityEngine;

namespace GooglePlayGames.BasicApi.Video
{
    public class VideoCaptureState
    {
        // Fields
        private bool mIsCapturing;
        private GooglePlayGames.BasicApi.VideoCaptureMode mCaptureMode;
        private GooglePlayGames.BasicApi.VideoQualityLevel mQualityLevel;
        private bool mIsOverlayVisible;
        private bool mIsPaused;
        
        // Properties
        public bool IsCapturing { get; }
        public GooglePlayGames.BasicApi.VideoCaptureMode CaptureMode { get; }
        public GooglePlayGames.BasicApi.VideoQualityLevel QualityLevel { get; }
        public bool IsOverlayVisible { get; }
        public bool IsPaused { get; }
        
        // Methods
        internal VideoCaptureState(bool isCapturing, GooglePlayGames.BasicApi.VideoCaptureMode captureMode, GooglePlayGames.BasicApi.VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused)
        {
            this.mCaptureMode = captureMode;
            this.mQualityLevel = qualityLevel;
            this.mIsCapturing = isCapturing;
            this.mIsOverlayVisible = isOverlayVisible;
            this.mIsPaused = isPaused;
        }
        public bool get_IsCapturing()
        {
            return (bool)this.mIsCapturing;
        }
        public GooglePlayGames.BasicApi.VideoCaptureMode get_CaptureMode()
        {
            return (GooglePlayGames.BasicApi.VideoCaptureMode)this.mCaptureMode;
        }
        public GooglePlayGames.BasicApi.VideoQualityLevel get_QualityLevel()
        {
            return (GooglePlayGames.BasicApi.VideoQualityLevel)this.mQualityLevel;
        }
        public bool get_IsOverlayVisible()
        {
            return (bool)this.mIsOverlayVisible;
        }
        public bool get_IsPaused()
        {
            return (bool)this.mIsPaused;
        }
        public override string ToString()
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.mIsCapturing == true)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.mIsCapturing == false)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.mIsCapturing;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_1[1] = this.mCaptureMode.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_1[2] = this.mQualityLevel.ToString();
            val_1[3] = this.mIsOverlayVisible;
            val_1[4] = this.mIsPaused;
            return (string)System.String.Format(format:  "[VideoCaptureState: mIsCapturing={0}, mCaptureMode={1}, mQualityLevel={2}, mIsOverlayVisible={3}, mIsPaused={4}]", args:  val_1);
        }
    
    }

}
