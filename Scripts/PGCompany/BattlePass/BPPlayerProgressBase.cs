using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPPlayerProgressBase : ISerializationCallbackReceiver
    {
        // Fields
        private int _level;
        private Rilisoft.丝丑丂丛万丐丈丘且 _levelContainer;
        public int Exp;
        public PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState PaymentState;
        private int _lastDayRewardedExp;
        private Rilisoft.丝丑丂丛万丐丈丘且 _lastDayRewardedExpContainer;
        
        // Properties
        internal Rilisoft.丝丑丂丛万丐丈丘且 Level { get; set; }
        internal Rilisoft.丝丑丂丛万丐丈丘且 LastDayRewardedExp { get; set; }
        
        // Methods
        internal Rilisoft.丝丑丂丛万丐丈丘且 get_Level()
        {
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this._levelContainer, 丑丒丄下丁丐专丄丞 = this._levelContainer};
        }
        internal void set_Level(Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东)
        {
            this._levelContainer = 丙业与丙丗丝不丈东;
            mem[1152921559954924608] = 丙业与丙丗丝不丈东.上万三丆专丏丒丗业;
        }
        internal Rilisoft.丝丑丂丛万丐丈丘且 get_LastDayRewardedExp()
        {
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this._lastDayRewardedExpContainer, 丑丒丄下丁丐专丄丞 = this._lastDayRewardedExpContainer};
        }
        internal void set_LastDayRewardedExp(Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东)
        {
            this._lastDayRewardedExpContainer = 丙业与丙丗丝不丈东;
            mem[1152921559955148640] = 丙业与丙丗丝不丈东.上万三丆专丏丒丗业;
        }
        public virtual void OnAfterDeserialize()
        {
            this._levelContainer = 0;
            mem[1152921559955260608] = 0;
            this._lastDayRewardedExpContainer = 0;
            mem[1152921559955260640] = 0;
        }
        public virtual void OnBeforeSerialize()
        {
            this._level = this._levelContainer;
            this._lastDayRewardedExp = this._lastDayRewardedExpContainer;
        }
        internal static PGCompany.BattlePass.BPPlayerProgressBase 丝丅丌丁丒丟三丏上(PGCompany.BattlePass.BPPlayerProgressBase 丝丙世万丒东下七丏, PGCompany.BattlePass.BPPlayerProgressBase 丌丝世三下一丟丌丘)
        {
            上丕丁专三丗丝万丆.PlayerPaymentState val_11;
            var val_12;
            专丙东上不丟丘东丝.丌专世丟丂东下东丕 val_14;
            int val_15;
            val_11 = 丌丝世三下一丟丌丘;
            if((val_11 == null) || (丝丙世万丒东下七丏 == null))
            {
                goto label_2;
            }
            
            PGCompany.BattlePass.BPPlayerProgressBase val_1 = null;
            val_12 = val_1;
            val_1 = new PGCompany.BattlePass.BPPlayerProgressBase();
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  UnityEngine.Mathf.Max(a:  -485887664, b:  -485887664));
            ._lastDayRewardedExpContainer = val_3;
            mem[1152921559955586496] = val_3.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  UnityEngine.Mathf.Max(a:  -485887664, b:  -485887664));
            val_14 = val_5.上万三丆专丏丒丗业;
            ._levelContainer = val_5;
            mem[1152921559955586464] = val_14;
            if( != )
            {
                goto label_8;
            }
            
            val_14 = 丌丝世三下一丟丌丘.Exp;
            val_15 = 丝丙世万丒东下七丏.Exp;
            int val_6 = UnityEngine.Mathf.Max(a:  val_15, b:  val_14);
            goto label_17;
            label_2:
            UnityEngine.Debug.LogErrorFormat(format:  "BPPlayerProgressBase Merge cloudProgress == null || localProgress == null", args:  System.Array.Empty<System.Object>());
            if(((丝丙世万丒东下七丏 != 0) ? 丝丙世万丒东下七丏 : (val_11)) != 0)
            {
                    return (PGCompany.BattlePass.BPPlayerProgressBase)val_12;
            }
            
            PGCompany.BattlePass.BPPlayerProgressBase val_9 = null;
            val_12 = val_9;
            val_9 = new PGCompany.BattlePass.BPPlayerProgressBase();
            return (PGCompany.BattlePass.BPPlayerProgressBase)val_12;
            label_8:
            if( > )
            {
                    val_15 = 丝丙世万丒东下七丏.Exp;
            }
            else
            {
                    val_15 = 丌丝世三下一丟丌丘.Exp;
            }
            
            label_17:
            .Exp = val_15;
            val_11 = 丌丝世三下一丟丌丘.PaymentState;
            .PaymentState = UnityEngine.Mathf.Max(a:  丝丙世万丒东下七丏.PaymentState, b:  val_11);
            return (PGCompany.BattlePass.BPPlayerProgressBase)val_12;
        }
        public BPPlayerProgressBase()
        {
        
        }
    
    }

}
