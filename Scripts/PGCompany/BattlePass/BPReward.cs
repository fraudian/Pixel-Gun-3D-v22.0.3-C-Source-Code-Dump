using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPReward : ICloneable
    {
        // Fields
        private Rilisoft.OfferItem _firstItemToCurrency;
        private int _forLevel;
        private bool _isCool;
        private Rilisoft.OfferItem _item;
        private PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState _paymentState;
        private string _uniqueId;
        private string <PlaceId>k__BackingField;
        private string _levelAndIndex;
        private int <Index>k__BackingField;
        
        // Properties
        internal string PlaceId { get; set; }
        public PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState PaymentState { get; set; }
        public int ForLevel { get; set; }
        public bool IsCool { get; set; }
        public string UniqueId { get; set; }
        public string LevelAndIndex { get; }
        public int Index { get; set; }
        public Rilisoft.OfferItem Item { get; }
        public bool RewardDropped { get; }
        public bool RewardUnDropped { get; }
        
        // Methods
        internal string get_PlaceId()
        {
            return (string)this.<PlaceId>k__BackingField;
        }
        private void set_PlaceId(string 丙业与丙丗丝不丈东)
        {
            this.<PlaceId>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public BPReward()
        {
        
        }
        public BPReward(PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 上丌丆丁丟上下专丁, int 丏世丞丅丁丄丁万丑, Rilisoft.OfferItem 下丅丙一丂丗丅丝七, bool 专丞不万丄业下丞三)
        {
            val_1 = new System.Object();
            this._paymentState = 上丌丆丁丟上下专丁;
            this._forLevel = 丏世丞丅丁丄丁万丑;
            this._isCool = 专丞不万丄业下丞三;
            this._item = val_1;
            this._uniqueId = System.String.Format(format:  "{0}_{1}_{2}", arg0:  val_1.UniqueId, arg1:  this._forLevel, arg2:  this._paymentState);
        }
        public PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState get_PaymentState()
        {
            return (PlayerPaymentState)this._paymentState;
        }
        private void set_PaymentState(PGCompany.BattlePass.上丕丁专三丗丝万丆.PlayerPaymentState 丙业与丙丗丝不丈东)
        {
            this._paymentState = 丙业与丙丗丝不丈东;
        }
        public int get_ForLevel()
        {
            return (int)this._forLevel;
        }
        private void set_ForLevel(int 丙业与丙丗丝不丈东)
        {
            this._forLevel = 丙业与丙丗丝不丈东;
        }
        public bool get_IsCool()
        {
            return (bool)this._isCool;
        }
        private void set_IsCool(bool 丙业与丙丗丝不丈东)
        {
            this._isCool = 丙业与丙丗丝不丈东;
        }
        public string get_UniqueId()
        {
            return (string)this._uniqueId;
        }
        private void set_UniqueId(string 丙业与丙丗丝不丈东)
        {
            this._uniqueId = 丙业与丙丗丝不丈东;
        }
        public string get_LevelAndIndex()
        {
            string val_4;
            if((System.String.IsNullOrEmpty(value:  this._levelAndIndex)) == false)
            {
                goto label_1;
            }
            
            if((this.<Index>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            string val_2 = System.String.Format(format:  "{0}.{1}", arg0:  this._forLevel, arg1:  this.<Index>k__BackingField);
            goto label_3;
            label_1:
            val_4 = this._levelAndIndex;
            return val_3;
            label_2:
            string val_3 = this._forLevel.ToString();
            label_3:
            this._levelAndIndex = val_3;
            return val_3;
        }
        public int get_Index()
        {
            return (int)this.<Index>k__BackingField;
        }
        public void set_Index(int 丙业与丙丗丝不丈东)
        {
            this.<Index>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.OfferItem get_Item()
        {
            return (Rilisoft.OfferItem)this._item;
        }
        public bool get_RewardDropped()
        {
            if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().上业业万三世丙丗丑(丗七丟丈三不丕一三:  this)) == false)
            {
                    return Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  this._item);
            }
            
            if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丞丁七丞丕上世丙丛(丗七丟丈三不丕一三:  this)) == false)
            {
                    return true;
            }
            
            return Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  this._item);
        }
        public bool get_RewardUnDropped()
        {
            PGCompany.BattlePass.BPReward val_6;
            var val_7;
            val_6 = this;
            if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丞丁七丞丕上世丙丛(丗七丟丈三不丕一三:  this)) != false)
            {
                    val_6 = this._item;
                val_7 = (Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  val_6)) ^ 1;
                return (bool)val_7 & 1;
            }
            
            val_7 = 0;
            return (bool)val_7 & 1;
        }
        public object Clone()
        {
            bool val_5;
            Rilisoft.OfferItem val_6;
            PGCompany.BattlePass.BPReward val_1 = new PGCompany.BattlePass.BPReward();
            if(val_1 != null)
            {
                    ._paymentState = this._paymentState;
                ._uniqueId = this._uniqueId;
                ._forLevel = this._forLevel;
                ._paymentState = this._paymentState;
                ._forLevel = this._forLevel;
                val_5 = this._isCool;
            }
            else
            {
                    mem[40] = this._paymentState;
                mem[48] = this._uniqueId;
                mem[24] = this._forLevel;
                mem[40] = this._paymentState;
                mem[24] = this._forLevel;
                val_5 = this._isCool;
            }
            
            ._isCool = val_5;
            if(this._item == null)
            {
                    return (object)val_1;
            }
            
            if(this._item.Clone() != null)
            {
                    val_6 = 0;
            }
            
            ._item = val_6;
            return (object)val_1;
        }
        public void 世丗丗丕一上丑业丞(bool 丂丅丑七丌不丄上丞 = True)
        {
            PGCompany.BattlePass.BPReward.世丗丗丕一上丑业丞(丗七丟丈三不丕一三:  this, 丂丅丑七丌不丄上丞:  丂丅丑七丌不丄上丞);
        }
        internal static void 世丗丗丕一上丑业丞(PGCompany.BattlePass.BPReward 丗七丟丈三不丕一三, bool 丂丅丑七丌不丄上丞 = True)
        {
            PGCompany.三东丏不丗世丅丌丄 val_11;
            bool val_12 = 丂丅丑七丌不丄上丞;
            if(丗七丟丈三不丕一三 == null)
            {
                    return;
            }
            
            if(丗七丟丈三不丕一三._item == null)
            {
                    return;
            }
            
            val_11 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  丗七丟丈三不丕一三._item.Type, 丞丅上丏丂且下丅与:  丗七丟丈三不丕一三._item.Id, 丂丕丂丏专丂丄丕且:  丗七丟丈三不丕一三._item.Count);
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丈丄不七三万丄丁不:  val_11)) != false)
            {
                    val_12 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                PGCompany.丗丟丄丈东丝丕丄世 val_8 = val_12.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_11, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
                return;
            }
            
            val_11 = 丗七丟丈三不丕一三._item;
            if((Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  val_11)) == true)
            {
                    return;
            }
            
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  丗七丟丈三不丕一三._item, 丁且丟不七下丆丒丟:  true, 丂丅丑七丌不丄上丞:  val_12 = 丂丅丑七丌不丄上丞, 丗东丗万丘丄丆丏东:  true, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  35, 不丐丅丁丂七丐丘丛:  2, 丁七丐丁丙丄丙不东:  false);
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.BattlePass.BPReward.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0;
            }
            
            return false;
        }
    
    }

}
