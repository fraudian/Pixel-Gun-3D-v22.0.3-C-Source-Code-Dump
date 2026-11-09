using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPChallangeDO : ISerializationCallbackReceiver
    {
        // Fields
        internal const string ID_KEY = "id";
        internal const string DAY_KEY = "day";
        internal const string DESCRIPTION_KEY = "desc";
        internal const string START_KEY = "startUtc";
        internal const string POINTS_KEY = "points";
        internal const string BATTLEPASS_KEY = "battlePass";
        internal const string OPEN_TYPE = "openType";
        internal const string TYPE_KEY = "type";
        internal const string REWARDS_KEY = "rewards";
        internal const string PARAMS_KEY = "params";
        internal const string PROGRESSION_KEY = "progression";
        internal const string AD_KEY = "ad";
        internal const string FOR_GAME_MODES_KEY = "fgm";
        private int _day;
        public PGCompany.BattlePass.BPChallengeType ConditionType;
        public System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> ForGameModes;
        public int Id;
        public string Description;
        public int BattlePassSeasonId;
        public bool IsAdEnabled;
        public PGCompany.BattlePass.业专丒丟且丝七丑丁 OpenType;
        private System.Collections.Generic.Dictionary<string, string> _dictParams;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> _listParams;
        public PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄 PayingType;
        private int PointsToComplete;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pointsContainer;
        public PGCompany.BattlePass.丅丛丌丗丁丅东丂丕 Progression;
        public System.Collections.Generic.List<Rilisoft.OfferItem> Rewards;
        private Rilisoft.丝丑丂丛万丐丈丘且 _dayContainer;
        
        // Properties
        public System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> Params { get; set; }
        internal Rilisoft.丝丑丂丛万丐丈丘且 PointsToCompleteContainer { get; set; }
        internal int Day { get; set; }
        
        // Methods
        public System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> get_Params()
        {
            if(this._listParams != null)
            {
                    return (System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter>)this._listParams;
            }
            
            this._listParams = new System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this._dictParams.GetEnumerator();
            label_6:
            if(((-498639992) & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            new PGCompany.BattlePass.BPChallengeParameter() = new System.Object();
            .Name = val_3._value._obj.丐丏七丌丕丗业且上();
            .Value = val_3._value._obj;
            this._listParams.Add(item:  new PGCompany.BattlePass.BPChallengeParameter());
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter>)this._listParams;
        }
        public void set_Params(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丙业与丙丗丝不丈东)
        {
            this._listParams = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.丝丑丂丛万丐丈丘且 get_PointsToCompleteContainer()
        {
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this._pointsContainer, 丑丒丄下丁丐专丄丞 = this._pointsContainer};
        }
        internal void set_PointsToCompleteContainer(Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东)
        {
            this._pointsContainer = 丙业与丙丗丝不丈东;
            mem[1152921559943166928] = 丙业与丙丗丝不丈东.上万三丆专丏丒丗业;
        }
        internal int get_Day()
        {
        
        }
        internal void set_Day(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._dayContainer = 0;
            mem[1152921559943390960] = 0;
        }
        public void OnAfterDeserialize()
        {
            this._pointsContainer = 0;
            mem[1152921559943502928] = 0;
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._dayContainer = 0;
            mem[1152921559943502960] = 0;
        }
        public void OnBeforeSerialize()
        {
            this.PointsToComplete = ;
            this._day = this._dayContainer;
        }
        internal static PGCompany.BattlePass.BPChallangeDO 且丘万丙丝丈丆专与(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒, int 丒业一丄丕丅丆专丈, System.DateTime 丕且不丛且丞专上不)
        {
            double val_70;
            ulong val_71;
            int val_72;
            int val_73;
            string val_74;
            string val_75;
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> val_76;
            var val_77;
            var val_78;
            var val_79;
            System.Func<System.String, Rilisoft.OfferItem> val_81;
            var val_82;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_84;
            string val_85;
            var val_86;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, PGCompany.BattlePass.BPChallengeParameter> val_88;
            int val_89;
            var val_90;
            var val_91;
            System.Func<PGCompany.BattlePass.BPChallengeParameter, System.Boolean> val_93;
            PGCompany.BattlePass.BPChallangeDO val_94;
            object val_95;
            val_71 = 丕且不丛且丞专上不.dateData;
            val_72 = 丒业一丄丕丅丆专丈;
            if(丏丂万业丙专丏丒丒 != null)
            {
                    int val_3 = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["id"], provider:  System.Globalization.CultureInfo.InvariantCulture);
                val_73 = System.String.alignConst;
                if((丏丂万业丙专丏丒丒.ContainsKey(key:  "desc")) != true)
            {
                    val_73 = System.Convert.ToString(value:  丏丂万业丙专丏丒丒.Item["desc"], provider:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
                if((丏丂万业丙专丏丒丒.ContainsKey(key:  "day")) != false)
            {
                    bool val_11 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  丏丂万业丙专丏丒丒.Item["day"], 丙业与丙丗丝不丈东: out  0);
            }
            else
            {
                    if((丏丂万业丙专丏丒丒.ContainsKey(key:  "startUtc")) != false)
            {
                    object val_13 = 丏丂万业丙专丏丒丒.Item["startUtc"];
                if(val_13 != null)
            {
                    var val_15 = (null == null) ? (val_13) : 0;
            }
            else
            {
                    val_74 = 0;
            }
            
                System.DateTime val_16 = System.DateTime.Parse(s:  val_74, provider:  System.Globalization.CultureInfo.InvariantCulture);
                System.TimeSpan val_17 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_16.dateData}, d2:  new System.DateTime() {dateData = val_71});
            }
            
            }
            
                System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_19 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
                if((丏丂万业丙专丏丒丒.ContainsKey(key:  "fgm")) != false)
            {
                    object val_21 = 丏丂万业丙专丏丒丒.Item["fgm"];
            }
            
                int val_24 = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["battlePass"], provider:  System.Globalization.CultureInfo.InvariantCulture);
                object val_25 = 丏丂万业丙专丏丒丒.Item["openType"];
                if(val_25 != null)
            {
                    var val_26 = (null == null) ? (val_25) : 0;
            }
            else
            {
                    val_75 = 0;
            }
            
                val_76 = 1152921504619360256;
                val_77 = null;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_75, ignoreCase:  true));
                if(丏丂万业丙专丏丒丒.Item["rewards"] != null)
            {
                    val_78 = 0;
            }
            
                val_71 = 1152921505673777152;
                val_79 = null;
                val_79 = null;
                val_81 = BPChallangeDO.<>c.<>9__40_0;
                if(val_81 == null)
            {
                    val_81 = null;
                val_81 = new System.Func<System.String, Rilisoft.OfferItem>(object:  BPChallangeDO.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem BPChallangeDO.<>c::上丛一丝丆丕世丈丛(string 三丟东丕丄丄下下丑));
                BPChallangeDO.<>c.<>9__40_0 = val_81;
            }
            
                val_82 = null;
                val_82 = null;
                val_84 = BPChallangeDO.<>c.<>9__40_1;
                if(val_84 == null)
            {
                    val_84 = null;
                val_84 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BPChallangeDO.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPChallangeDO.<>c::丙世丝七丄丅丐丟丟(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
                BPChallangeDO.<>c.<>9__40_1 = val_84;
            }
            
                object val_37 = 丏丂万业丙专丏丒丒.Item["type"];
                if(val_37 != null)
            {
                    var val_38 = (null == null) ? (val_37) : 0;
            }
            else
            {
                    val_85 = 0;
            }
            
                val_72 = 1152921505676386304;
                val_77 = null;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_85, ignoreCase:  true));
                int val_43 = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["points"], provider:  System.Globalization.CultureInfo.InvariantCulture);
                object val_44 = 丏丂万业丙专丏丒丒.Item["params"];
                val_86 = null;
                val_86 = null;
                val_88 = BPChallangeDO.<>c.<>9__40_2;
                val_89 = null;
                val_90 = 0;
                if(val_88 != null)
            {
                    val_90 = 0;
            }
            else
            {
                    val_88 = null;
                val_89 = 1152921559943828032;
                val_88 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, PGCompany.BattlePass.BPChallengeParameter>(object:  BPChallangeDO.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.BPChallengeParameter BPChallangeDO.<>c::丙丐丕丆丒丂丆东丐(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
                BPChallangeDO.<>c.<>9__40_2 = val_88;
            }
            
                val_91 = null;
                val_91 = null;
                val_93 = BPChallangeDO.<>c.<>9__40_3;
                if(val_93 == null)
            {
                    val_93 = null;
                val_89 = 1152921559943839296;
                val_93 = new System.Func<PGCompany.BattlePass.BPChallengeParameter, System.Boolean>(object:  BPChallangeDO.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPChallangeDO.<>c::万丁东丘丙下丞专丅(PGCompany.BattlePass.BPChallengeParameter 三丟东丕丄丄下下丑));
                BPChallangeDO.<>c.<>9__40_3 = val_93;
            }
            
                val_76 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPChallengeParameter>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPChallengeParameter>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.Object>, PGCompany.BattlePass.BPChallengeParameter>(source:  null, selector:  val_88), predicate:  null));
                int val_54 = System.Convert.ToInt32(value:  丏丂万业丙专丏丒丒.Item["progression"], provider:  System.Globalization.CultureInfo.InvariantCulture);
                if(((1152921504628731904 - 22) <= 2) && (val_54 != 0))
            {
                    object[] val_56 = new object[1];
                val_56[0] = null;
                UnityEngine.Debug.LogErrorFormat(format:  "progression is true for  {0} type of challenge", args:  val_56);
            }
            
                val_94 = new PGCompany.BattlePass.BPChallangeDO();
                val_94 = new PGCompany.BattlePass.BPChallangeDO();
                if(val_94 != null)
            {
                    .Id = val_3;
                val_70 = (int)val_17._ticks.TotalDays;
            }
            else
            {
                    val_89 = val_3;
                mem[32] = val_89;
                val_70 = (int)val_17._ticks.TotalDays;
            }
            
                int val_60 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
                val_95 = 0;
                ._dayContainer = 0;
                mem[1152921559944108896] = val_95;
                if(val_94 != null)
            {
                    .Description = val_73;
                .BattlePassSeasonId = val_72;
                .PayingType = val_24;
                .ConditionType = null;
                .OpenType = null;
            }
            else
            {
                    mem[40] = val_73;
                mem[48] = val_72;
                mem[80] = val_24;
                val_95 = null;
                mem[56] = val_95;
                .ConditionType = null;
            }
            
                .Rewards = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<System.String, Rilisoft.OfferItem>(source:  System.Linq.Enumerable.OfType<System.String>(source:  null), selector:  null), predicate:  null));
                int val_61 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                ._listParams = val_76;
                .Progression = val_54;
                .IsAdEnabled = System.Convert.ToBoolean(value:  丏丂万业丙专丏丒丒.Item["ad"]);
                ._pointsContainer = 0;
                mem[1152921559944108864] = 0;
                .ForGameModes = null;
                return (PGCompany.BattlePass.BPChallangeDO)val_94;
            }
            
            val_94 = 0;
            return (PGCompany.BattlePass.BPChallangeDO)val_94;
        }
        public BPChallangeDO()
        {
            this._dictParams = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
