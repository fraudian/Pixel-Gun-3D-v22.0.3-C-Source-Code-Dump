using UnityEngine;

namespace PGCompany.GameModeEvents
{
    [Serializable]
    internal class GMERewardConditionProgress : ISerializationCallbackReceiver
    {
        // Fields
        private int _points;
        private int _points1;
        private int _сompleteResult;
        private int _completeUtcTime;
        private int _maxResetCount;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pointsContainer;
        private Rilisoft.丝丑丂丛万丐丈丘且 _points1Container;
        private Rilisoft.丝丑丂丛万丐丈丘且 _completeResultContainer;
        private Rilisoft.丝丑丂丛万丐丈丘且 _completeUtcTimeContainer;
        private Rilisoft.丝丑丂丛万丐丈丘且 _maxResetCountContainer;
        
        // Properties
        public int Points { get; set; }
        public int Points1 { get; set; }
        public int CompleteUtcTime { get; set; }
        public int MaxResetCount { get; set; }
        internal int CompleteResult { get; set; }
        
        // Methods
        public int get_Points()
        {
        
        }
        public void set_Points(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._pointsContainer = 0;
            mem[1152921559717514016] = 0;
        }
        public int get_Points1()
        {
        
        }
        public void set_Points1(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._points1Container = 0;
            mem[1152921559717738032] = 0;
        }
        public int get_CompleteUtcTime()
        {
        
        }
        public void set_CompleteUtcTime(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._completeUtcTimeContainer = 0;
            mem[1152921559717962064] = 0;
        }
        public int get_MaxResetCount()
        {
        
        }
        public void set_MaxResetCount(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._maxResetCountContainer = 0;
            mem[1152921559718186080] = 0;
        }
        internal int get_CompleteResult()
        {
        
        }
        internal void set_CompleteResult(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._completeResultContainer = 0;
            mem[1152921559718410048] = 0;
        }
        public void OnAfterDeserialize()
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._pointsContainer = 0;
            mem[1152921559718522016] = 0;
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._points1Container = 0;
            mem[1152921559718522032] = 0;
            int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._completeResultContainer = 0;
            mem[1152921559718522048] = 0;
            int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._completeUtcTimeContainer = 0;
            mem[1152921559718522064] = 0;
            int val_5 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._maxResetCountContainer = 0;
            mem[1152921559718522080] = 0;
        }
        public void OnBeforeSerialize()
        {
            this._points = this._pointsContainer;
            this._points1 = this._points1Container;
            this._сompleteResult = this._completeResultContainer;
            this._completeUtcTime = this._completeUtcTimeContainer;
            this._maxResetCount = this._maxResetCountContainer;
        }
        internal void 且丅丗丂丗丌与且丝(PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._pointsContainer = 0;
            mem[1152921559718750112] = 0;
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._points1Container = 0;
            mem[1152921559718750128] = 0;
            int val_3 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._completeResultContainer = 0;
            mem[1152921559718750144] = 0;
            int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._completeUtcTimeContainer = 0;
            mem[1152921559718750160] = 0;
            int val_5 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._maxResetCountContainer = 0;
            mem[1152921559718750176] = 0;
        }
        internal bool 不丞丁丘不丗丞丗不(PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
        {
            var val_2;
            if((((this._pointsContainer == 上丕丈丞丌丘丅不与._pointsContainer) && (this._points1Container == 上丕丈丞丌丘丅不与._points1Container)) && (this._completeResultContainer == 上丕丈丞丌丘丅不与._completeResultContainer)) && (this._completeUtcTimeContainer == 上丕丈丞丌丘丅不与._completeUtcTimeContainer))
            {
                    var val_1 = (this._maxResetCountContainer == 上丕丈丞丌丘丅不与._maxResetCountContainer) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public GMERewardConditionProgress()
        {
        
        }
    
    }

}
