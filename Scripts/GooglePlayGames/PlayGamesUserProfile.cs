using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesUserProfile : IUserProfile
    {
        // Fields
        private string mDisplayName;
        private string mPlayerId;
        private string mAvatarUrl;
        private bool mImageLoading;
        private UnityEngine.Texture2D mImage;
        
        // Properties
        public string userName { get; }
        public string id { get; }
        public bool isFriend { get; }
        public UnityEngine.SocialPlatforms.UserState state { get; }
        public UnityEngine.Texture2D image { get; }
        public string AvatarURL { get; }
        
        // Methods
        internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
        {
            val_1 = new System.Object();
            this.mDisplayName = displayName;
            this.mPlayerId = val_1;
            this.mAvatarUrl = avatarUrl;
            this.mImageLoading = false;
        }
        protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
        {
            this.mDisplayName = displayName;
            this.mPlayerId = playerId;
            if((System.String.op_Inequality(a:  this.mAvatarUrl, b:  avatarUrl)) != false)
            {
                    this.mImage = 0;
                this.mAvatarUrl = avatarUrl;
            }
            
            this.mImageLoading = false;
        }
        public string get_userName()
        {
            return (string)this.mDisplayName;
        }
        public string get_id()
        {
            return (string)this.mPlayerId;
        }
        public bool get_isFriend()
        {
            return true;
        }
        public UnityEngine.SocialPlatforms.UserState get_state()
        {
            return 0;
        }
        public UnityEngine.Texture2D get_image()
        {
            if(this.mImageLoading == true)
            {
                    return (UnityEngine.Texture2D)this.mImage;
            }
            
            if(this.mImage != 0)
            {
                    return (UnityEngine.Texture2D)this.mImage;
            }
            
            if((System.String.IsNullOrEmpty(value:  this.mAvatarUrl)) == true)
            {
                    return (UnityEngine.Texture2D)this.mImage;
            }
            
            UnityEngine.Debug.Log(message:  "Starting to load image: "("Starting to load image: ") + this.mAvatarUrl);
            this.mImageLoading = true;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunCoroutine(action:  this.LoadImage());
            return (UnityEngine.Texture2D)this.mImage;
        }
        public string get_AvatarURL()
        {
            return (string)this.mAvatarUrl;
        }
        internal System.Collections.IEnumerator LoadImage()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new PlayGamesUserProfile.<LoadImage>d__19();
        }
        public override bool Equals(object obj)
        {
            var val_3;
            if(obj == null)
            {
                goto label_3;
            }
            
            if(this == obj)
            {
                goto label_2;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (GooglePlayGames.PlayGamesUserProfile.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
            label_3:
            val_3 = 0;
            return (bool)val_3;
            label_2:
            val_3 = 1;
            return (bool)val_3;
        }
        public override int GetHashCode()
        {
            string val_2 = this.mPlayerId;
            val_2 = val_2 ^ (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            return (int)val_2;
        }
        public override string ToString()
        {
            return System.String.Format(format:  "[Player: \'{0}\' (id {1})]", arg0:  this.mDisplayName, arg1:  this.mPlayerId);
        }
    
    }

}
