using UnityEngine;

namespace PGCompany.GameModeEvents
{
    internal abstract class 丝一七万丗不丄丒上 : IDisposable
    {
        // Fields
        private System.Action 丈丙不丒上丙与不丒;
        private static System.Action<PGCompany.GameModeEvents.丝一七万丗不丄丒上> 丐七丙万丅丙丛丕下;
        protected bool 丛专丄丕世丒丈世世;
        protected System.Collections.Generic.List<string> 丑丗下且且丈丞丌丝;
        protected PGCompany.GameModeEvents.GMERewardConditionProgress 丈丄丂下丒专丌丛丄;
        private Rilisoft.丝丑丂丛万丐丈丘且 <且不丒丟丗下下丝七>k__BackingField;
        protected bool 丘丄丆不丛丗上三上;
        private int <上丒世丘丗下丌七不>k__BackingField;
        private string <专下丝丛丛专丐丕丅>k__BackingField;
        internal bool 丙丆丂丄丑且丛与丏;
        
        // Properties
        internal abstract string 丒三丝一上丙专丗丒 { get; }
        internal int 专丈丆丁丟丛丑丄丄 { get; }
        internal Rilisoft.丝丑丂丛万丐丈丘且 丒丅下丕丈丝丁业丂 { get; set; }
        internal int 丌丛丒丏上业丟丞不 { get; set; }
        internal string 不丌七丆丏丂丐万丂 { get; set; }
        
        // Methods
        internal void 丙业丄丞丝丅与丙七(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丈丙不丒上丙与不丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈丙不丒上丙与不丒 != 1152921559710970144);
        
        }
        internal void 丌丂丌丑丐丙丒不三(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丈丙不丒上丙与不丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈丙不丒上丙与不丒 != 1152921559711106720);
        
        }
        internal static void 丗丐丆七丒丟丛专丒(System.Action<PGCompany.GameModeEvents.丝一七万丗不丄丒上> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.GameModeEvents.丝一七万丗不丄丒上.丐七丙万丅丙丛丕下, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丙一与不丆业东丗七(System.Action<PGCompany.GameModeEvents.丝一七万丗不丄丒上> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.GameModeEvents.丝一七万丗不丄丒上.丐七丙万丅丙丛丕下, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal abstract string 不业丙丒丂丞下丆丙(); // 0
        internal PGCompany.GameModeEvents.GMERewardConditionProgress 丄且丙丂丆不一万七(bool 丂丘丈丈专万丈丈丆 = True, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丑丟丙丄不丟丄丗丕)
        {
            this.一丟丕丛丕七丏且丝(丂丘丈丈专万丈丈丆:  丂丘丈丈专万丈丈丆, 丑丟丙丄不丟丄丗丕:  丑丟丙丄不丟丄丗丕);
            return (PGCompany.GameModeEvents.GMERewardConditionProgress)this.丈丄丂下丒专丌丛丄;
        }
        internal int 丑丑丏丁丗丏丘七一()
        {
            if(this.丈丄丂下丒专丌丛丄 != null)
            {
                    return this.丈丄丂下丒专丌丛丄.CompleteResult;
            }
            
            return this.丈丄丂下丒专丌丛丄.CompleteResult;
        }
        internal Rilisoft.丝丑丂丛万丐丈丘且 丑业丞丙丏丌丐且丌()
        {
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this.<且不丒丟丗下下丝七>k__BackingField, 丑丒丄下丁丐专丄丞 = this.<且不丒丟丗下下丝七>k__BackingField};
        }
        internal void 丅丐下丌丅丛且丁丛(Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东)
        {
            this.<且不丒丟丗下下丝七>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921559711848392] = 丙业与丙丗丝不丈东.上万三丆专丏丒丗业;
        }
        internal int 丅东丄丛上丁丐万丏()
        {
            return (int)this.<上丒世丘丗下丌七不>k__BackingField;
        }
        private void 丐与丗上丈丏上丕上(int 丙业与丙丗丝不丈东)
        {
            this.<上丒世丘丗下丌七不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 丅丙丛丑丌丆丌丕丒()
        {
            return (string)this.<专下丝丛丛专丐丕丅>k__BackingField;
        }
        private void 丝丂丈上丏丟丆丞丒(string 丙业与丙丗丝不丈东)
        {
            this.<专下丝丛丛专丐丕丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丝一七万丗不丄丒上(int 丟丟丄专上丟丁丐丝, System.Collections.Generic.List<string> 丗丟上上丒丐丗丞丙, PGCompany.GameModeEvents.GMERewardConditionProgress 上丕丈丞丌丘丅不与)
        {
            this.丘丄丆不丛丗上三上 = true;
            val_1 = new System.Object();
            this.<上丒世丘丗下丌七不>k__BackingField = 丟丟丄专上丟丁丐丝;
            this.丑丗下且且丈丞丌丝 = val_1;
            this.丈丄丂下丒专丌丛丄 = 上丕丈丞丌丘丅不与;
            this.<专下丝丛丛专丐丕丅>k__BackingField = System.String.Format(format:  "{0}_{1}", arg0:  丟丟丄专上丟丁丐丝, arg1:  this);
        }
        private void 一丟丕丛丕七丏且丝(bool 丂丘丈丈专万丈丈丆, PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丑丟丙丄不丟丄丗丕)
        {
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_17;
            int val_18;
            val_17 = 丑丟丙丄不丟丄丗丕;
            val_18 = this;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            System.DateTimeOffset val_2 = System.DateTimeOffset.Now;
            if(this.丈丄丂下丒专丌丛丄.CompleteUtcTime <= 0)
            {
                    this.丈丄丂下丒专丌丛丄.CompleteUtcTime = (long)FriendsController.丝丗专上三不丄丑丑() + (int)val_2.m_dateTime.dateData.TotalSeconds;
            }
            
            System.DateTime val_8 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  this.丈丄丂下丒专丌丛丄.CompleteUtcTime);
            System.DateTime val_10 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  (long)FriendsController.丝丗专上三不丄丑丑() + (int)val_2.m_dateTime.dateData.TotalSeconds);
            if(val_10.dateData.DayOfYear == val_8.dateData.DayOfYear)
            {
                    return;
            }
            
            if((val_17 != null) && (丂丘丈丈专万丈丈丆 != false))
            {
                    if(PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世() != null)
            {
                    bool val_14 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丅上丗丂丕丟丟与丝(丐且丘丑与万丞丑丅:  val_17);
            }
            
            }
            
            this.丈丄丂下丒专丌丛丄.CompleteResult = 0;
            this.丈丄丂下丒专丌丛丄.Points = 0;
            this.丈丄丂下丒专丌丛丄.Points1 = 0;
            val_17 = this.丈丄丂下丒专丌丛丄;
            val_17.CompleteUtcTime = (long)FriendsController.丝丗专上三不丄丑丑() + (int)val_2.m_dateTime.dateData.TotalSeconds;
            this.丘丄丆不丛丗上三上 = true;
            this.丙丆丂丄丑且丛与丏 = true;
            this.丂且不业丂专丛丆东(丂丘丈丈专万丈丈丆:  丂丘丈丈专万丈丈丆, 丂丂丟丘丆东丟丄丒:  true);
            if(丂丘丈丈专万丈丈丆 == false)
            {
                    return;
            }
            
            val_18 = this.<上丒世丘丗下丌七不>k__BackingField;
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丂丙丒一丙业丕下专(丟丟丄专上丟丁丐丝:  val_18);
        }
        internal void 一七丅七丌丟丕上东()
        {
            if(this.丈丙不丒上丙与不丒 != null)
            {
                    this.丈丙不丒上丙与不丒.Invoke();
            }
            
            if(PGCompany.GameModeEvents.丝一七万丗不丄丒上.丐七丙万丅丙丛丕下 == null)
            {
                    return;
            }
            
            PGCompany.GameModeEvents.丝一七万丗不丄丒上.丐七丙万丅丙丛丕下.Invoke(obj:  this);
        }
        internal void 丂且不业丂专丛丆东(bool 丂丘丈丈专万丈丈丆, bool 丂丂丟丘丆东丟丄丒 = True)
        {
            if(丂丘丈丈专万丈丈丆 != false)
            {
                    PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().三世业三丑上丐丁不(丐丕丂丐丟不丅万丏:  this.<上丒世丘丗下丌七不>k__BackingField.ToString(), 丘丙且丕世丕丆丁丅:  this.丈丄丂下丒专丌丛丄);
            }
            
            if(丂丂丟丘丆东丟丄丒 == false)
            {
                    return;
            }
            
            this.一七丅七丌丟丕上东();
        }
        public virtual void Dispose()
        {
            this.丛专丄丕世丒丈世世 = true;
        }
        public virtual void 丈且东丑丂且万丒丅()
        {
        
        }
        public abstract string 丙丄上丆丝丂丘专丒(); // 0
        public abstract string 与丏丞丟丆七丈丐上(); // 0
        public abstract string 丂丌丐丕丝不且丏丅(); // 0
        public abstract int 丘且丘下丁丑丗且丒(); // 0
        public abstract bool 万且丏丂下丘丄不丑(); // 0
    
    }

}
