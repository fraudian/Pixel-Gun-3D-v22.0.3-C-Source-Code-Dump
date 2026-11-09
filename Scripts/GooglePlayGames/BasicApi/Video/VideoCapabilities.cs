using UnityEngine;

namespace GooglePlayGames.BasicApi.Video
{
    public class VideoCapabilities
    {
        // Fields
        private bool mIsCameraSupported;
        private bool mIsMicSupported;
        private bool mIsWriteStorageSupported;
        private bool[] mCaptureModesSupported;
        private bool[] mQualityLevelsSupported;
        
        // Properties
        public bool IsCameraSupported { get; }
        public bool IsMicSupported { get; }
        public bool IsWriteStorageSupported { get; }
        
        // Methods
        internal VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported)
        {
            this.mIsCameraSupported = isCameraSupported;
            this.mIsMicSupported = isMicSupported;
            this.mIsWriteStorageSupported = isWriteStorageSupported;
            this.mCaptureModesSupported = captureModesSupported;
            this.mQualityLevelsSupported = qualityLevelsSupported;
        }
        public bool get_IsCameraSupported()
        {
            return (bool)this.mIsCameraSupported;
        }
        public bool get_IsMicSupported()
        {
            return (bool)this.mIsMicSupported;
        }
        public bool get_IsWriteStorageSupported()
        {
            return (bool)this.mIsWriteStorageSupported;
        }
        public bool SupportsCaptureMode(GooglePlayGames.BasicApi.VideoCaptureMode captureMode)
        {
            var val_2;
            var val_3;
            val_2 = captureMode;
            if(val_2 != 1)
            {
                    val_2 = (long)val_2;
                var val_1 = (this.mCaptureModesSupported[val_2] == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            GooglePlayGames.OurUtils.Logger.w(msg:  "SupportsCaptureMode called with an unknown captureMode.");
            val_3 = 0;
            return (bool)val_3;
        }
        public bool SupportsQualityLevel(GooglePlayGames.BasicApi.VideoQualityLevel qualityLevel)
        {
            var val_2;
            var val_3;
            val_2 = qualityLevel;
            if(val_2 != 1)
            {
                    val_2 = (long)val_2;
                var val_1 = (this.mQualityLevelsSupported[val_2] == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            GooglePlayGames.OurUtils.Logger.w(msg:  "SupportsCaptureMode called with an unknown qualityLevel.");
            val_3 = 0;
            return (bool)val_3;
        }
        public override string ToString()
        {
            var val_11;
            System.Func<System.Boolean, System.String> val_13;
            var val_14;
            System.Func<System.Boolean, System.String> val_16;
            object[] val_1 = new object[5];
            val_1[0] = this.mIsCameraSupported;
            val_1[1] = this.mIsMicSupported;
            val_1[2] = this.mIsWriteStorageSupported;
            val_11 = null;
            val_11 = null;
            val_13 = VideoCapabilities.<>c.<>9__14_0;
            if(val_13 == null)
            {
                    System.Func<System.Boolean, System.String> val_2 = null;
                val_13 = val_2;
                val_2 = new System.Func<System.Boolean, System.String>(object:  VideoCapabilities.<>c.__il2cppRuntimeField_static_fields, method:  System.String VideoCapabilities.<>c::<ToString>b__14_0(bool p));
                VideoCapabilities.<>c.<>9__14_0 = val_13;
            }
            
            val_1[3] = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Boolean, System.String>(source:  this.mCaptureModesSupported, selector:  val_2)));
            val_14 = null;
            val_14 = null;
            val_16 = VideoCapabilities.<>c.<>9__14_1;
            if(val_16 == null)
            {
                    System.Func<System.Boolean, System.String> val_6 = null;
                val_16 = val_6;
                val_6 = new System.Func<System.Boolean, System.String>(object:  VideoCapabilities.<>c.__il2cppRuntimeField_static_fields, method:  System.String VideoCapabilities.<>c::<ToString>b__14_1(bool p));
                VideoCapabilities.<>c.<>9__14_1 = val_16;
            }
            
            val_1[4] = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Boolean, System.String>(source:  this.mQualityLevelsSupported, selector:  val_6)));
            return (string)System.String.Format(format:  "[VideoCapabilities: mIsCameraSupported={0}, mIsMicSupported={1}, mIsWriteStorageSupported={2}, mCaptureModesSupported={3}, mQualityLevelsSupported={4}]", args:  val_1);
        }
    
    }

}
