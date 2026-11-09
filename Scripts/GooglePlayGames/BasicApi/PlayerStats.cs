using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class PlayerStats
    {
        // Fields
        private static float UNSET_VALUE;
        private bool mValid;
        private int mNumberOfPurchases;
        private float mAvgSessionLength;
        private int mDaysSinceLastPlayed;
        private int mNumberOfSessions;
        private float mSessPercentile;
        private float mSpendPercentile;
        private float mSpendProbability;
        private float mChurnProbability;
        private float mHighSpenderProbability;
        private float mTotalSpendNext28Days;
        
        // Properties
        public bool Valid { get; }
        public int NumberOfPurchases { get; }
        public float AvgSessionLength { get; }
        public int DaysSinceLastPlayed { get; }
        public int NumberOfSessions { get; }
        public float SessPercentile { get; }
        public float SpendPercentile { get; }
        public float SpendProbability { get; }
        public float ChurnProbability { get; }
        public float HighSpenderProbability { get; }
        public float TotalSpendNext28Days { get; }
        
        // Methods
        public PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days)
        {
            this.mNumberOfPurchases = numberOfPurchases;
            this.mAvgSessionLength = avgSessionLength;
            this.mDaysSinceLastPlayed = daysSinceLastPlayed;
            this.mNumberOfSessions = numberOfSessions;
            this.mSessPercentile = sessPercentile;
            this.mSpendPercentile = spendPercentile;
            this.mSpendProbability = spendProbability;
            this.mChurnProbability = churnProbability;
            this.mValid = true;
            this.mHighSpenderProbability = highSpenderProbability;
            this.mTotalSpendNext28Days = totalSpendNext28Days;
        }
        public PlayerStats()
        {
            this.mValid = false;
        }
        public bool get_Valid()
        {
            return (bool)this.mValid;
        }
        public int get_NumberOfPurchases()
        {
            return (int)this.mNumberOfPurchases;
        }
        public float get_AvgSessionLength()
        {
            return (float)this.mAvgSessionLength;
        }
        public int get_DaysSinceLastPlayed()
        {
            return (int)this.mDaysSinceLastPlayed;
        }
        public int get_NumberOfSessions()
        {
            return (int)this.mNumberOfSessions;
        }
        public float get_SessPercentile()
        {
            return (float)this.mSessPercentile;
        }
        public float get_SpendPercentile()
        {
            return (float)this.mSpendPercentile;
        }
        public float get_SpendProbability()
        {
            return (float)this.mSpendProbability;
        }
        public float get_ChurnProbability()
        {
            return (float)this.mChurnProbability;
        }
        public float get_HighSpenderProbability()
        {
            return (float)this.mHighSpenderProbability;
        }
        public float get_TotalSpendNext28Days()
        {
            return (float)this.mTotalSpendNext28Days;
        }
        public bool HasNumberOfPurchases()
        {
            null = null;
            return (bool)(this.mNumberOfPurchases != (int)GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasAvgSessionLength()
        {
            null = null;
            return (bool)(this.mAvgSessionLength != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasDaysSinceLastPlayed()
        {
            null = null;
            return (bool)(this.mDaysSinceLastPlayed != (int)GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasNumberOfSessions()
        {
            null = null;
            return (bool)(this.mNumberOfSessions != (int)GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasSessPercentile()
        {
            null = null;
            return (bool)(this.mSessPercentile != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasSpendPercentile()
        {
            null = null;
            return (bool)(this.mSpendPercentile != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasChurnProbability()
        {
            null = null;
            return (bool)(this.mChurnProbability != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasHighSpenderProbability()
        {
            null = null;
            return (bool)(this.mHighSpenderProbability != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        public bool HasTotalSpendNext28Days()
        {
            null = null;
            return (bool)(this.mTotalSpendNext28Days != GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE) ? 1 : 0;
        }
        private static PlayerStats()
        {
            GooglePlayGames.BasicApi.PlayerStats.UNSET_VALUE = -1f;
        }
    
    }

}
