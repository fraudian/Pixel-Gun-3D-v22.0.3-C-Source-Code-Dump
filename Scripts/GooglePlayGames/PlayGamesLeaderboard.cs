using UnityEngine;

namespace GooglePlayGames
{
    public class PlayGamesLeaderboard : ILeaderboard
    {
        // Fields
        private string mId;
        private UnityEngine.SocialPlatforms.UserScope mUserScope;
        private UnityEngine.SocialPlatforms.Range mRange;
        private UnityEngine.SocialPlatforms.TimeScope mTimeScope;
        private string[] mFilteredUserIds;
        private bool mLoading;
        private UnityEngine.SocialPlatforms.IScore mLocalUserScore;
        private uint mMaxRange;
        private System.Collections.Generic.List<GooglePlayGames.PlayGamesScore> mScoreList;
        private string mTitle;
        
        // Properties
        public bool loading { get; set; }
        public string id { get; set; }
        public UnityEngine.SocialPlatforms.UserScope userScope { get; set; }
        public UnityEngine.SocialPlatforms.Range range { get; set; }
        public UnityEngine.SocialPlatforms.TimeScope timeScope { get; set; }
        public UnityEngine.SocialPlatforms.IScore localUserScore { get; }
        public uint maxRange { get; }
        public UnityEngine.SocialPlatforms.IScore[] scores { get; }
        public string title { get; }
        public int ScoreCount { get; }
        
        // Methods
        public PlayGamesLeaderboard(string id)
        {
            this.mScoreList = new System.Collections.Generic.List<GooglePlayGames.PlayGamesScore>();
            this.mId = id;
        }
        public void SetUserFilter(string[] userIDs)
        {
            this.mFilteredUserIds = userIDs;
        }
        public void LoadScores(System.Action<bool> callback)
        {
            GooglePlayGames.PlayGamesPlatform.Instance.LoadScores(board:  this, callback:  callback);
        }
        public bool get_loading()
        {
            return (bool)this.mLoading;
        }
        internal void set_loading(bool value)
        {
            this.mLoading = value;
        }
        public string get_id()
        {
            return (string)this.mId;
        }
        public void set_id(string value)
        {
            this.mId = value;
        }
        public UnityEngine.SocialPlatforms.UserScope get_userScope()
        {
            return (UnityEngine.SocialPlatforms.UserScope)this.mUserScope;
        }
        public void set_userScope(UnityEngine.SocialPlatforms.UserScope value)
        {
            this.mUserScope = value;
        }
        public UnityEngine.SocialPlatforms.Range get_range()
        {
            return new UnityEngine.SocialPlatforms.Range() {from = this.mRange, count = this.mRange};
        }
        public void set_range(UnityEngine.SocialPlatforms.Range value)
        {
            this.mRange = value;
        }
        public UnityEngine.SocialPlatforms.TimeScope get_timeScope()
        {
            return (UnityEngine.SocialPlatforms.TimeScope)this.mTimeScope;
        }
        public void set_timeScope(UnityEngine.SocialPlatforms.TimeScope value)
        {
            this.mTimeScope = value;
        }
        public UnityEngine.SocialPlatforms.IScore get_localUserScore()
        {
            return (UnityEngine.SocialPlatforms.IScore)this.mLocalUserScore;
        }
        public uint get_maxRange()
        {
            return (uint)this.mMaxRange;
        }
        public UnityEngine.SocialPlatforms.IScore[] get_scores()
        {
            int val_1 = this.mScoreList.Count;
            GooglePlayGames.PlayGamesScore[] val_2 = new GooglePlayGames.PlayGamesScore[0];
            this.mScoreList.CopyTo(array:  val_2);
            return (UnityEngine.SocialPlatforms.IScore[])val_2;
        }
        public string get_title()
        {
            return (string)this.mTitle;
        }
        internal bool SetFromData(GooglePlayGames.BasicApi.LeaderboardScoreData data)
        {
            bool val_11;
            UnityEngine.SocialPlatforms.IScore val_12;
            var val_13;
            UnityEngine.SocialPlatforms.IScore val_14;
            GooglePlayGames.BasicApi.ResponseStatus val_10 = data.mStatus;
            val_10 = val_10 - 1;
            if(val_10 > 1)
            {
                goto label_2;
            }
            
            UnityEngine.Debug.Log(message:  "Setting leaderboard from: "("Setting leaderboard from: ") + data);
            this.mMaxRange = data.mApproxCount;
            this.mTitle = data.mTitle;
            val_12 = data.mPlayerScore;
            if(val_12 != null)
            {
                    val_12 = 0;
            }
            
            this.mLocalUserScore = val_12;
            val_13 = 0;
            goto label_8;
            label_14:
            val_14 = data.Scores[0];
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            int val_6 = this.AddScore(score:  val_14);
            val_13 = 1;
            label_8:
            if(val_13 < val_4.Length)
            {
                goto label_14;
            }
            
            UnityEngine.SocialPlatforms.IScore[] val_7 = data.Scores;
            if(val_7.Length == 0)
            {
                goto label_17;
            }
            
            val_11 = this.HasAllScores();
            if(this != null)
            {
                goto label_20;
            }
            
            label_21:
            label_20:
            this.mLoading = val_11;
            label_2:
            GooglePlayGames.BasicApi.ResponseStatus val_11 = data.mStatus;
            val_11 = val_11 - 1;
            return (bool)(val_11 < 2) ? 1 : 0;
            label_17:
            if(this != null)
            {
                goto label_20;
            }
            
            goto label_21;
        }
        internal void SetMaxRange(ulong val)
        {
            this.mMaxRange = val;
        }
        internal void SetTitle(string value)
        {
            this.mTitle = value;
        }
        internal void SetLocalUserScore(GooglePlayGames.PlayGamesScore score)
        {
            this.mLocalUserScore = score;
        }
        internal int AddScore(GooglePlayGames.PlayGamesScore score)
        {
            string val_2;
            if((this.mFilteredUserIds == null) || (this.mFilteredUserIds.Length == 0))
            {
                goto label_3;
            }
            
            var val_2 = 0;
            label_7:
            if(val_2 >= this.mFilteredUserIds.Length)
            {
                goto label_3;
            }
            
            val_2 = this.mFilteredUserIds[0];
            val_2 = val_2 + 1;
            if((val_2.Equals(value:  score.mPlayerId)) == false)
            {
                goto label_7;
            }
            
            if(this.mScoreList != null)
            {
                    return 0.Count;
            }
            
            return 0.Count;
            label_3:
            val_2 = this.mScoreList;
            val_2.Add(item:  score);
            if(this.mScoreList != null)
            {
                    return 0.Count;
            }
            
            return 0.Count;
        }
        public int get_ScoreCount()
        {
            if(this.mScoreList != null)
            {
                    return this.mScoreList.Count;
            }
            
            return this.mScoreList.Count;
        }
        internal bool HasAllScores()
        {
            var val_4;
            if(this.mScoreList.Count < true)
            {
                    var val_3 = ((long)this.mScoreList.Count >= this.mMaxRange) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 1;
            return (bool)val_4;
        }
    
    }

}
