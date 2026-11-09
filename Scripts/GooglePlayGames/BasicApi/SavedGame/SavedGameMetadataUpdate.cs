using UnityEngine;

namespace GooglePlayGames.BasicApi.SavedGame
{
    public struct SavedGameMetadataUpdate
    {
        // Fields
        private readonly bool mDescriptionUpdated;
        private readonly string mNewDescription;
        private readonly bool mCoverImageUpdated;
        private readonly byte[] mNewPngCoverImage;
        private readonly System.Nullable<System.TimeSpan> mNewPlayedTime;
        
        // Properties
        public bool IsDescriptionUpdated { get; }
        public string UpdatedDescription { get; }
        public bool IsCoverImageUpdated { get; }
        public byte[] UpdatedPngCoverImage { get; }
        public bool IsPlayedTimeUpdated { get; }
        public System.Nullable<System.TimeSpan> UpdatedPlayedTime { get; }
        
        // Methods
        private SavedGameMetadataUpdate(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder builder)
        {
            this.mCoverImageUpdated = (builder.mDescriptionUpdated == true) ? 1 : 0;
            this.mNewPngCoverImage = builder.mNewDescription;
            mem[1152921541881429976] = builder.mNewPngCoverImage;
            mem[1152921541881429984] = builder.mNewPlayedTime.HasValue;
            this.mNewPlayedTime = (builder.mCoverImageUpdated == true) ? 1 : 0;
            mem[1152921541881429992] = mem[1152921541881461976];
        }
        public bool get_IsDescriptionUpdated()
        {
            return (bool)this.mCoverImageUpdated;
        }
        public string get_UpdatedDescription()
        {
            return (string)this.mNewPngCoverImage;
        }
        public bool get_IsCoverImageUpdated()
        {
            return (bool)this.mNewPlayedTime;
        }
        public byte[] get_UpdatedPngCoverImage()
        {
            return (System.Byte[])this;
        }
        public bool get_IsPlayedTimeUpdated()
        {
        
        }
        public System.Nullable<System.TimeSpan> get_UpdatedPlayedTime()
        {
            return (System.Nullable<System.TimeSpan>)X8;
        }
    
    }

}
