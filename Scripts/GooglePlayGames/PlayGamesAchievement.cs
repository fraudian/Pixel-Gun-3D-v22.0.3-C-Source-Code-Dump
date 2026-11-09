using UnityEngine;

namespace GooglePlayGames
{
    internal class PlayGamesAchievement : IAchievement, IAchievementDescription
    {
        // Fields
        private readonly GooglePlayGames.ReportProgress mProgressCallback;
        private string mId;
        private bool mIsIncremental;
        private int mCurrentSteps;
        private int mTotalSteps;
        private double mPercentComplete;
        private bool mCompleted;
        private bool mHidden;
        private System.DateTime mLastModifiedTime;
        private string mTitle;
        private string mRevealedImageUrl;
        private string mUnlockedImageUrl;
        private UnityEngine.Networking.UnityWebRequest mImageFetcher;
        private UnityEngine.Texture2D mImage;
        private string mDescription;
        private ulong mPoints;
        
        // Properties
        public string id { get; set; }
        public bool isIncremental { get; }
        public int currentSteps { get; }
        public int totalSteps { get; }
        public double percentCompleted { get; set; }
        public bool completed { get; }
        public bool hidden { get; }
        public System.DateTime lastReportedDate { get; }
        public string title { get; }
        public UnityEngine.Texture2D image { get; }
        public string achievedDescription { get; }
        public string unachievedDescription { get; }
        public int points { get; }
        
        // Methods
        internal PlayGamesAchievement()
        {
            mem[1152921541723623648] = GooglePlayGames.PlayGamesPlatform.Instance;
            mem[1152921541723623656] = typeof(GooglePlayGames.PlayGamesPlatform).__il2cppRuntimeField_180;
            mem[1152921541723623632] = typeof(GooglePlayGames.PlayGamesPlatform).__il2cppRuntimeField_180;
        }
        internal PlayGamesAchievement(GooglePlayGames.ReportProgress progressCallback)
        {
            this.mId = System.String.alignConst;
            this.mLastModifiedTime = 0;
            this.mTitle = System.String.alignConst;
            this.mRevealedImageUrl = System.String.alignConst;
            this.mUnlockedImageUrl = System.String.alignConst;
            this.mDescription = System.String.alignConst;
            this.mProgressCallback = progressCallback;
        }
        internal PlayGamesAchievement(GooglePlayGames.BasicApi.Achievement ach)
        {
            var val_4;
            var val_5;
            double val_6;
            if(ach == null)
            {
                goto label_0;
            }
            
            val_4 = ach;
            this.mId = ach.mId;
            this.mIsIncremental = ach.mIsIncremental;
            this.mCurrentSteps = ach.mCurrentSteps;
            this.mTotalSteps = ach.mTotalSteps;
            if(ach.mIsIncremental == false)
            {
                goto label_1;
            }
            
            label_5:
            val_5 = mem[ach + 32];
            val_5 = ach + 32;
            if(val_5 < 1)
            {
                goto label_2;
            }
            
            if(ach == null)
            {
                goto label_3;
            }
            
            val_4 = mem[ach + 28];
            val_4 = ach + 28;
            goto label_4;
            label_0:
            this.mId = 11993091;
            this.mIsIncremental = false;
            val_4 = 28;
            this.mCurrentSteps = 0;
            this.mTotalSteps = 64;
            if(160 != 0)
            {
                goto label_5;
            }
            
            label_1:
            var val_1 = (ach.mIsUnlocked == true) ? 100 : 0;
            goto label_7;
            label_2:
            val_6 = 0;
            goto label_7;
            label_3:
            val_4 = mem[ach + 28];
            val_4 = ach + 28;
            val_5 = mem[ach + 32];
            val_5 = ach + 32;
            label_4:
            double val_4 = (double)val_4;
            val_4 = val_4 / (double)val_5;
            val_6 = val_4 * 100;
            label_7:
            this.mPercentComplete = val_6;
            if(ach != null)
            {
                    this.mCompleted = ach.mIsUnlocked;
                bool val_5 = ach.mIsRevealed;
                val_5 = val_5 ^ 1;
                this.mHidden = val_5;
                System.DateTime val_2 = ach.LastModifiedTime;
                this.mLastModifiedTime = val_2;
                this.mTitle = ach.mName;
                this.mDescription = ach.mDescription;
                this.mPoints = ach.mPoints;
                this.mRevealedImageUrl = ach.mRevealedImageUrl;
            }
            else
            {
                    this.mCompleted = true;
                bool val_6 = ach.mIsRevealed;
                val_6 = val_6 ^ 1;
                this.mHidden = val_6;
                System.DateTime val_3 = 0.LastModifiedTime;
                this.mLastModifiedTime = val_3;
                this.mTitle = 0;
                this.mDescription = 135970152;
                this.mPoints = 21474836481;
                this.mRevealedImageUrl = 0;
            }
            
            this.mUnlockedImageUrl = ach.mUnlockedImageUrl;
        }
        public void ReportProgress(System.Action<bool> callback)
        {
            this.mProgressCallback.Invoke(id:  this.mId, progress:  this.mPercentComplete, callback:  callback);
        }
        private UnityEngine.Texture2D LoadImage()
        {
            UnityEngine.Texture2D val_9;
            var val_10;
            UnityEngine.Texture2D val_11;
            if(this.mHidden != false)
            {
                    val_9 = 0;
                return val_8;
            }
            
            string val_1 = (this.mCompleted == true) ? this.mUnlockedImageUrl : this.mRevealedImageUrl;
            val_9 = 0;
            if((System.String.IsNullOrEmpty(value:  val_1)) == true)
            {
                    return val_8;
            }
            
            if(this.mImageFetcher != null)
            {
                    if((System.String.op_Inequality(a:  this.mImageFetcher.url, b:  val_1)) == false)
            {
                goto label_5;
            }
            
            }
            
            val_10 = this;
            val_11 = 0;
            this.mImage = 0;
            this.mImageFetcher = UnityEngine.Networking.UnityWebRequestTexture.GetTexture(uri:  val_1);
            goto label_6;
            label_5:
            val_10 = this;
            val_11 = this.mImage;
            label_6:
            if(val_11 != 0)
            {
                    val_9 = this.mImage;
                return val_8;
            }
            
            val_9 = 0;
            if(this.mImageFetcher.isDone == false)
            {
                    return val_8;
            }
            
            UnityEngine.Texture2D val_8 = UnityEngine.Networking.DownloadHandlerTexture.GetContent(www:  this.mImageFetcher);
            this.mImage = val_8;
            return val_8;
        }
        public string get_id()
        {
            return (string)this.mId;
        }
        public void set_id(string value)
        {
            this.mId = value;
        }
        public bool get_isIncremental()
        {
            return (bool)this.mIsIncremental;
        }
        public int get_currentSteps()
        {
            return (int)this.mCurrentSteps;
        }
        public int get_totalSteps()
        {
            return (int)this.mTotalSteps;
        }
        public double get_percentCompleted()
        {
            return (double)this.mPercentComplete;
        }
        public void set_percentCompleted(double value)
        {
            this.mPercentComplete = value;
        }
        public bool get_completed()
        {
            return (bool)this.mCompleted;
        }
        public bool get_hidden()
        {
            return (bool)this.mHidden;
        }
        public System.DateTime get_lastReportedDate()
        {
            return (System.DateTime)this.mLastModifiedTime;
        }
        public string get_title()
        {
            return (string)this.mTitle;
        }
        public UnityEngine.Texture2D get_image()
        {
            return this.LoadImage();
        }
        public string get_achievedDescription()
        {
            return (string)this.mDescription;
        }
        public string get_unachievedDescription()
        {
            return (string)this.mDescription;
        }
        public int get_points()
        {
            return (int)this.mPoints;
        }
    
    }

}
