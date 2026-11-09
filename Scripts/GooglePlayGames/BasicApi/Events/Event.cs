using UnityEngine;

namespace GooglePlayGames.BasicApi.Events
{
    internal class Event : IEvent
    {
        // Fields
        private string mId;
        private string mName;
        private string mDescription;
        private string mImageUrl;
        private ulong mCurrentCount;
        private GooglePlayGames.BasicApi.Events.EventVisibility mVisibility;
        
        // Properties
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string ImageUrl { get; }
        public ulong CurrentCount { get; }
        public GooglePlayGames.BasicApi.Events.EventVisibility Visibility { get; }
        
        // Methods
        internal Event(string id, string name, string description, string imageUrl, ulong currentCount, GooglePlayGames.BasicApi.Events.EventVisibility visibility)
        {
            val_1 = new System.Object();
            this.mId = id;
            this.mName = val_1;
            this.mDescription = description;
            this.mImageUrl = imageUrl;
            this.mCurrentCount = currentCount;
            this.mVisibility = visibility;
        }
        public string get_Id()
        {
            return (string)this.mId;
        }
        public string get_Name()
        {
            return (string)this.mName;
        }
        public string get_Description()
        {
            return (string)this.mDescription;
        }
        public string get_ImageUrl()
        {
            return (string)this.mImageUrl;
        }
        public ulong get_CurrentCount()
        {
            return (ulong)this.mCurrentCount;
        }
        public GooglePlayGames.BasicApi.Events.EventVisibility get_Visibility()
        {
            return (GooglePlayGames.BasicApi.Events.EventVisibility)this.mVisibility;
        }
    
    }

}
