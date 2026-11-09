using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class ScorePageToken
    {
        // Fields
        private string mId;
        private object mInternalObject;
        private GooglePlayGames.BasicApi.LeaderboardCollection mCollection;
        private GooglePlayGames.BasicApi.LeaderboardTimeSpan mTimespan;
        private GooglePlayGames.BasicApi.ScorePageDirection mDirection;
        
        // Properties
        public GooglePlayGames.BasicApi.LeaderboardCollection Collection { get; }
        public GooglePlayGames.BasicApi.LeaderboardTimeSpan TimeSpan { get; }
        public GooglePlayGames.BasicApi.ScorePageDirection Direction { get; }
        public string LeaderboardId { get; }
        internal object InternalObject { get; }
        
        // Methods
        internal ScorePageToken(object internalObject, string id, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan, GooglePlayGames.BasicApi.ScorePageDirection direction)
        {
            val_1 = new System.Object();
            this.mId = val_1;
            this.mInternalObject = internalObject;
            this.mCollection = collection;
            this.mTimespan = timespan;
            this.mDirection = direction;
        }
        public GooglePlayGames.BasicApi.LeaderboardCollection get_Collection()
        {
            return (GooglePlayGames.BasicApi.LeaderboardCollection)this.mCollection;
        }
        public GooglePlayGames.BasicApi.LeaderboardTimeSpan get_TimeSpan()
        {
            return (GooglePlayGames.BasicApi.LeaderboardTimeSpan)this.mTimespan;
        }
        public GooglePlayGames.BasicApi.ScorePageDirection get_Direction()
        {
            return (GooglePlayGames.BasicApi.ScorePageDirection)this.mDirection;
        }
        public string get_LeaderboardId()
        {
            return (string)this.mId;
        }
        internal object get_InternalObject()
        {
            return (object)this.mInternalObject;
        }
    
    }

}
