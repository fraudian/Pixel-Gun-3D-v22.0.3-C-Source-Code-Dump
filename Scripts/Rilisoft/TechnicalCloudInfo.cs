using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class TechnicalCloudInfo
    {
        // Fields
        internal const string TECHNICAL_CLOUD_INFO_STORAGER_KEY = "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY";
        private float _inGameSeconds;
        private int _sessionDayCount;
        private int _totalInapps;
        private System.Collections.Generic.List<string> m_playerIds;
        
        // Properties
        public System.Collections.Generic.List<string> PlayerIds { get; set; }
        public int TotalInapps { get; set; }
        public int SessionDayCount { get; set; }
        public float InGameSeconds { get; set; }
        
        // Methods
        public System.Collections.Generic.List<string> get_PlayerIds()
        {
            return (System.Collections.Generic.List<System.String>)this.m_playerIds;
        }
        public void set_PlayerIds(System.Collections.Generic.List<string> 丙业与丙丗丝不丈东)
        {
            this.m_playerIds = 丙业与丙丗丝不丈东;
        }
        public int get_TotalInapps()
        {
            return (int)this._totalInapps;
        }
        public void set_TotalInapps(int 丙业与丙丗丝不丈东)
        {
            this._totalInapps = 丙业与丙丗丝不丈东;
        }
        public int get_SessionDayCount()
        {
            return (int)this._sessionDayCount;
        }
        public void set_SessionDayCount(int 丙业与丙丗丝不丈东)
        {
            this._sessionDayCount = 丙业与丙丗丝不丈东;
        }
        public float get_InGameSeconds()
        {
            return (float)this._inGameSeconds;
        }
        public void set_InGameSeconds(float 丙业与丙丗丝不丈东)
        {
            this._inGameSeconds = 丙业与丙丗丝不丈东;
        }
        public TechnicalCloudInfo()
        {
            this.m_playerIds = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
