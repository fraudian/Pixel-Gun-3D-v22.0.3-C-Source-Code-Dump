using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesScore : IScore
    {
        // Fields
        private string mLbId;
        private long mValue;
        private ulong mRank;
        private string mPlayerId;
        private string mMetadata;
        private System.DateTime mDate;
        
        // Properties
        public string leaderboardID { get; set; }
        public long value { get; set; }
        public System.DateTime date { get; }
        public string formattedValue { get; }
        public string userID { get; }
        public int rank { get; }
        public string metaData { get; }
        
        // Methods
        internal PlayGamesScore(System.DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
        {
            this.mPlayerId = System.String.alignConst;
            this.mMetadata = System.String.alignConst;
            this.mDate = 0;
            this.mMetadata = metadata;
            this.mDate = date;
            this.mValue = value;
            this.mRank = rank;
            this.mPlayerId = playerId;
        }
        public void ReportScore(System.Action<bool> callback)
        {
            GooglePlayGames.PlayGamesPlatform.Instance.ReportScore(score:  this.mValue, board:  this.mLbId, metadata:  this.mMetadata, callback:  callback);
        }
        public string get_leaderboardID()
        {
            return (string)this.mLbId;
        }
        public void set_leaderboardID(string value)
        {
            this.mLbId = value;
        }
        public long get_value()
        {
            return (long)this.mValue;
        }
        public void set_value(long value)
        {
            this.mValue = value;
        }
        public System.DateTime get_date()
        {
            return (System.DateTime)this.mDate;
        }
        public string get_formattedValue()
        {
            return this.mValue.ToString();
        }
        public string get_userID()
        {
            return (string)this.mPlayerId;
        }
        public int get_rank()
        {
            return (int)this.mRank;
        }
        public string get_metaData()
        {
            return (string)this.mMetadata;
        }
    
    }

}
