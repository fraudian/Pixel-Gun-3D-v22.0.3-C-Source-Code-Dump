using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanLootBoxRewardUI : StorePromotionRewardUIAbstract
    {
        // Fields
        private UILabel _titleLabel;
        private UITable _itemTable;
        private PGCompany.InventoryItemView _itemView;
        private float animateRewardDelay;
        private PositionHolder positionHolder;
        private UnityEngine.GameObject _bgSuperchest;
        private UnityEngine.GameObject button_collect;
        private UnityEngine.Transform chestObjectHolder;
        private UnityEngine.Transform rewardAnimationStartPoint;
        private UnityEngine.GameObject tapToCloseLabel;
        private UnityEngine.GameObject window_processReward;
        private ClanLootBoxMultiRewardContainer window_multiRewardResult;
        private ClanLootBoxCraftWeaponWindow window_CraftableWeapon;
        private float multiOpenSpeedScale;
        private ModuleChestAnimationController 上丟下丂丙丛丕丌且;
        private System.Collections.Generic.List<PGCompany.InventoryItemView> 丞上丈丁丙丙丟东万;
        private int 丁东丆丌丂丘丐一丂;
        private PGCompany.七东万三万丒丏一丁 丂丂东且丐丗丗不一;
        private UnityEngine.Coroutine 丞丆丏万丝世丐丈丌;
        private bool 一东丁丅三丙丅丐丒;
        internal static bool 七丂丑七丑世丂不丒;
        private Rilisoft.丝丑丂丛万丐丈丘且 丏丏丝专下丟丅丁丅;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> 专东丐丂七专与丕丗;
        private System.IDisposable 东三世丝丒三一丈丛;
        private System.Collections.Generic.List<PGCompany.InventoryItemView> 丟丟且丄丑丝丑丒丅;
        private UnityEngine.AudioClip 丏丌丐丅丝七业专丁;
        
        // Properties
        private UnityEngine.AudioClip 丙万丐丌七三丐丘丞 { get; }
        private UnityEngine.AudioClip 丌丌丐不丒丕世丛一 { get; }
        
        // Methods
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemView, 丏业丟一东丂东丘丛:  false);
            this.丁东丆丌丂丘丐一丂 = this._itemTable.columns;
        }
        private void OnEnable()
        {
            null = null;
            PGCompany.ClanLootBoxRewardUI.七丂丑七丑世丂不丒 = true;
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.ClanLootBoxRewardUI).__il2cppRuntimeField_1B0);
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  System.String.Format(format:  "ClanLootBoxRewardUI_{0}", arg0:  this.gameObject.name));
        }
        private void OnDisable()
        {
            var val_2;
            if(this.丞丆丏万丝世丐丈丌 != null)
            {
                    this.StopCoroutine(routine:  this.丞丆丏万丝世丐丈丌);
            }
            
            val_2 = null;
            val_2 = null;
            PGCompany.ClanLootBoxRewardUI.七丂丑七丑世丂不丒 = false;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        public override void U_Hide()
        {
            if(this.一东丁丅三丙丅丐丒 != false)
            {
                    return;
            }
            
            if(this.window_multiRewardResult.丅与丌专丟一丝业三().activeSelf != false)
            {
                    if(this.window_multiRewardResult.丑不万丁丟丏丂业与 == false)
            {
                goto label_6;
            }
            
            }
            
            if(this.window_CraftableWeapon.丅与丌专丟一丝业三().activeSelf != false)
            {
                    if(this.window_CraftableWeapon.丑不万丁丟丏丂业与 == false)
            {
                goto label_11;
            }
            
            }
            
            if(this.丏丏丝专下丟丅丁丅 == 1)
            {
                    if(this.window_CraftableWeapon.丅与丌专丟一丝业三().activeSelf != true)
            {
                    if(this.window_CraftableWeapon.丑不万丁丟丏丂业与 == false)
            {
                goto label_17;
            }
            
            }
            
            }
            
            label_21:
            this.U_Hide();
            return;
            label_6:
            this.window_multiRewardResult.专丈丟丛丛一专丈丞();
            return;
            label_11:
            this.window_CraftableWeapon.专丈丟丛丛一专丈丞();
            return;
            label_17:
            System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄> val_8 = this.丝丝东丒东丈下一丕(上业丟世三与七七三:  this.丈丏丁东上与东丙丕());
            if(val_8.Count < 1)
            {
                goto label_21;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.window_processReward, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.window_multiRewardResult, 丏业丟一东丂东丘丛:  false);
            this.window_CraftableWeapon.丌万丗与七丄丕不丁(上业丟世三与七七三:  val_8, 丁且丙丞丁丌丆丛丐:  new System.Action(object:  this, method:  typeof(PGCompany.ClanLootBoxRewardUI).__il2cppRuntimeField_1B0));
        }
        private void OnDestroy()
        {
            if(this.丞丆丏万丝世丐丈丌 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丞丆丏万丝世丐丈丌);
        }
        private void 丁丈与与万丂上丟丝()
        {
            if(this.丞丆丏万丝世丐丈丌 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丞丆丏万丝世丐丈丌);
        }
        internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三, object 一丐丗丁丞丆丅丟丄)
        {
            var val_11;
            var val_12;
            PGCompany.七东万三万丒丏一丁 val_13;
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  1);
            this.丏丏丝专下丟丅丁丅 = val_1;
            mem[1152921554106334952] = val_1.上万三丆专丏丒丗业;
            if(一丐丗丁丞丆丅丟丄 != null)
            {
                    if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "multiCount")) != false)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["multiCount"]));
                this.丏丏丝专下丟丅丁丅 = val_5;
                mem[1152921554106334952] = val_5.上万三丆专丏丒丗业;
            }
            
                val_11 = "chestsInfo";
                if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "chestsInfo")) != false)
            {
                    object val_7 = 一丐丗丁丞丆丅丟丄.Item["chestsInfo"];
                val_12 = 0;
                this.专东丐丂七专与丕丗 = ;
            }
            
            }
            
            this.丒丂丏丄丆丐丌丂丞();
            PGCompany.丗丟丄丈东丝丕丄世 val_9 = 且丘丏丁丑与丙与丁.三丘丆丅丝丙一丑与();
            if(val_9 != null)
            {
                    var val_10 = (null == null) ? (val_9) : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            this.丂丂东且丐丗丗不一 = val_13;
            this.丞丆丏万丝世丐丈丌 = 0;
            this.一东丁丅三丙丅丐丒 = false;
            if(this.丏丏丝专下丟丅丁丅 == 1)
            {
                    this.专东丐丂七专与丕丗 = 0;
            }
            
            this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁, 上业丟世三与七七三:  上业丟世三与七七三, 一丐丗丁丞丆丅丟丄:  0);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.七东万三万丒丏一丁 丒丁且东世一丝业丆, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            this.丒丂丏丄丆丐丌丂丞();
            this.丂丂东且丐丗丗不一 = 丒丁且东世一丝业丆;
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  1);
            this.丏丏丝专下丟丅丁丅 = val_1;
            mem[1152921554106479720] = val_1.上万三丆专丏丒丗业;
            this.丞丆丏万丝世丐丈丌 = 0;
            this.一东丁丅三丙丅丐丒 = false;
            this.上与丟丗一上丛丌专(上业丟世三与七七三:  上业丟世三与七七三);
            goto typeof(PGCompany.ClanLootBoxRewardUI).__il2cppRuntimeField_198;
        }
        private void 丒丂丏丄丆丐丌丂丞()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.window_processReward, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.window_multiRewardResult.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.window_CraftableWeapon, 丏业丟一东丂东丘丛:  false);
        }
        private void 业三东丏与丘丞丆专()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.window_processReward, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.window_multiRewardResult.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
        }
        private System.Collections.IEnumerator 不不与丆一三世丗丄()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanLootBoxRewardUI.不丈丂丈丂三丁丆丌(丗丏丅丕丆世丁专丟:  0);
        }
        internal System.Collections.Generic.Dictionary<string, PGCompany.三东丏不丗世丅丌丄> 丝丝东丒东丈下一丕(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            var val_5;
            System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄>();
            System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.Dictionary<System.String, PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_3 = 上业丟世三与七七三.GetEnumerator();
            label_22:
            if(((-2039416320) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if((val_2.ContainsKey(key:  val_6.业上丙丞丐丄丆丅七())) != false)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_10 = val_2.Item[val_6.业上丙丞丐丄丆丅七()];
                val_10.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_6.丂丁丏一丙丛业且丌() + val_10.丂丁丏一丙丛业且丌());
            }
            else
            {
                    val_2.Add(key:  val_6.业上丙丞丐丄丆丅七(), value:  val_6);
            }
            
            if(((this.丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_2.Item[val_6.业上丙丞丐丄丆丅七()])) == false) || ((val_1.ContainsKey(key:  val_6.业上丙丞丐丄丆丅七())) == true))
            {
                goto label_22;
            }
            
            val_1.Add(key:  val_6.业上丙丞丐丄丆丅七(), value:  val_6);
            goto label_22;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            return val_1;
        }
        private bool 丞丒丒三丞且丏东丄(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            var val_15;
            if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1070)
            {
                goto label_7;
            }
            
            Rilisoft.OfferItem val_3 = new Rilisoft.OfferItem(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
            if(val_3.ItemParams == null)
            {
                goto label_7;
            }
            
            bool val_6 = 丆丐三丅丆丗东丑世.丞丒丒三丞且丏东丄(丞丅上丏丂且下丅与:  val_3.Id);
            if(val_6 == false)
            {
                goto label_7;
            }
            
            if((val_6.七丈丁丂丐丕下丄丕(丏且丕丄丁丟丆丏丁:  val_3)) == false)
            {
                goto label_14;
            }
            
            val_15 = val_3.IsExists ^ 1;
            return (bool)val_15 & 1;
            label_7:
            if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() == 1300)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_11 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丛丈丏丅丂一不丒业(上七下丘一下三世丏:  丈丄不七三万丄丁不);
                if(val_11 != null)
            {
                    PGCompany.丄丂丌丞丁丙七丆三 val_12 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世();
                if(val_12 != null)
            {
                    return val_12.三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_11.业东丅东丌上丗丑不());
            }
            
                return val_12.三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_11.业东丅东丌上丗丑不());
            }
            
            }
            
            label_14:
            val_15 = 0;
            return (bool)val_15 & 1;
        }
        private bool 七丈丁丂丐丕下丄丕(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁)
        {
            var val_13;
            三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛());
            if(val_3 != null)
            {
                    val_13 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_3.三与丛丑且丐丈业丌());
                return (bool)((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛())) >= val_13) ? 1 : 0;
            }
            
            val_13 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛());
            return (bool)((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  丏且丕丄丁丟丆丏丁.Record.与不丞丑七丘丁丂丛())) >= val_13) ? 1 : 0;
        }
        protected override void 丝一丅丆三东丂丞七()
        {
            var val_51;
            var val_52;
            int val_54;
            var val_55;
            var val_56;
            var val_57;
            UnityEngine.GameObject val_58;
            System.Action val_59;
            this.丟丟且丄丑丝丑丒丅.Clear();
            if((this.丏丏丝专下丟丅丁丅 != 1) && (this.丞丆丏万丝世丐丈丌 == null))
            {
                    if(this.一东丁丅三丙丅丐丒 == false)
            {
                goto label_4;
            }
            
            }
            
            val_51 = 0;
            if(((this.丏丏丝专下丟丅丁丅 == 1) && (this.丞丆丏万丝世丐丈丌 == null)) && (this.一东丁丅三丙丅丐丒 != true))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.window_multiRewardResult, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.window_CraftableWeapon, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_collect, 丏业丟一东丂东丘丛:  true);
                val_51 = 1;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToCloseLabel, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this.丂丂东且丐丗丗不一 != null)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  this.丂丂东且丐丗丗不一.七业丑不七丐业丟丂());
            }
            
            val_52 = null;
            val_52 = null;
            if((ClanLootBoxRewardUI.<>c.<>9__39_0) == null)
            {
                goto label_15;
            }
            
            label_66:
            this.丞上丈丁丙丙丟东万.ForEach(action:  ClanLootBoxRewardUI.<>c.<>9__39_0);
            val_54 = this.丈丏丁东上与东丙丕().Count;
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.InventoryItemView>(专下丐丒丈万丗丟丝:  this.丞上丈丁丙丙丟东万, 专丑业丁丗丏丌不丛:  this._itemView.gameObject, 丈东丘丏与丌东东下:  this._itemTable.transform, 与业丄丂丂丆下上丞:  val_54, 丏东下下一丗专下丏:  0);
            this.positionHolder.state = this.丈丏丁东上与东丙丕().Count - 1;
            this.positionHolder.LoadState();
            val_55 = 0;
            goto label_25;
            label_52:
            this.丞上丈丁丙丙丟东万.Item[0].transform.SetParent(p:  this.positionHolder.obj[0].transform);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.丞上丈丁丙丙丟东万.Item[0].transform.GetChild(index:  0), 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丞上丈丁丙丙丟东万.Item[0].transform);
            this.丞上丈丁丙丙丟东万.Item[0].Setup(丈丄不七三万丄丁不:  this.丈丏丁东上与东丙丕().Item[0]);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丞上丈丁丙丙丟东万.Item[0], 丏业丟一东丂东丘丛:  true);
            ClanLootBoxInfoItemUI val_23 = this.丞上丈丁丙丙丟东万.Item[0].gameObject.GetComponent<ClanLootBoxInfoItemUI>();
            if(val_23 != null)
            {
                    (val_23 == 0) ? 0 : (val_23).丈且东丑丂且万丒丅();
            }
            
            val_54 = this.丞上丈丁丙丙丟东万.Item[0];
            this.丟丟且丄丑丝丑丒丅.Add(item:  val_54);
            val_55 = 1;
            label_25:
            if(val_55 < this.丈丏丁东上与东丙丕().Count)
            {
                goto label_52;
            }
            
            if(this.上丟下丂丙丛丕丌且 != 0)
            {
                    this.上丟下丂丙丛丕丌且.gameObject.SetActive(value:  false);
                UnityEngine.Object.Destroy(obj:  this.上丟下丂丙丛丕丌且.gameObject);
            }
            
            if(this.丂丂东且丐丗丗不一 == null)
            {
                goto label_61;
            }
            
            bool val_32 = this.丂丂东且丐丗丗不一.世一下丕丟不不丌丈();
            val_56 = 0;
            goto label_62;
            label_15:
            ClanLootBoxRewardUI.<>c.<>9__39_0 = new System.Action<PGCompany.InventoryItemView>(object:  ClanLootBoxRewardUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanLootBoxRewardUI.<>c::丏丆东丁丒丞七且丛(PGCompany.InventoryItemView 三丟东丕丄丄下下丑));
            if(this.丞上丈丁丙丙丟东万 != null)
            {
                goto label_66;
            }
            
            goto label_66;
            label_61:
            val_56 = 0;
            label_62:
            if(((-2038536276) & 1) != 0)
            {
                    val_57 = 1;
                val_58 = this._bgSuperchest;
            }
            else
            {
                    val_58 = this._bgSuperchest;
                val_57 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_58, 丏业丟一东丂东丘丛:  false);
            PGCompany.ClanLootBoxData val_34 = this.丂丂东且丐丗丗不一.丁专丗万三上丟三丆();
            string val_35 = "ClanLootBoxes/ClanLootBox_"("ClanLootBoxes/ClanLootBox_") + val_34.Id;
            val_59 = val_35;
            ModuleChestAnimationController val_36 = UnityEngine.Resources.Load<ModuleChestAnimationController>(path:  val_35);
            if(val_36 == 0)
            {
                goto label_77;
            }
            
            ModuleChestAnimationController val_38 = UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_36, parent:  this.chestObjectHolder);
            this.上丟下丂丙丛丕丌且 = val_38;
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_38.transform);
            bool val_40 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
            if(val_40 != false)
            {
                    UnityEngine.AudioSource val_42 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_40.上丈不一丟丞世丆丘());
            }
            
            if(this.上丟下丂丙丛丕丌且 == null)
            {
                goto label_88;
            }
            
            if(this.一东丁丅三丙丅丐丒 == false)
            {
                goto label_89;
            }
            
            label_95:
            if(this.上丟下丂丙丛丕丌且 != null)
            {
                goto label_96;
            }
            
            label_97:
            label_96:
            this.上丟下丂丙丛丕丌且.下丌上且世丅业丂一(下下丏一丙不丘丌丞:  this.上丟下丂丙丛丕丌且.一丒专丝丛丟上三丅() / this.multiOpenSpeedScale);
            System.Action val_45 = null;
            val_59 = val_45;
            val_45 = new System.Action(object:  this, method:  System.Void PGCompany.ClanLootBoxRewardUI::丘丆丑丁丌丘且丌不());
            this.上丟下丂丙丛丕丌且.丌万丗与七丄丕不丁(丑丙丙丕与丂丐丘一:  val_45);
            return;
            label_77:
            UnityEngine.Debug.LogError(message:  "No asset found for module cest: \'"("No asset found for module cest: \'") + val_59 + "\'");
            UnityEngine.Coroutine val_48 = this.StartCoroutine(routine:  this.丝三丘上丂丑丞丗丈());
            return;
            label_88:
            if(this.一东丁丅三丙丅丐丒 == true)
            {
                goto label_95;
            }
            
            label_89:
            if(this.上丟下丂丙丛丕丌且 != null)
            {
                goto label_96;
            }
            
            goto label_97;
            label_4:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button_collect, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToCloseLabel, 丏业丟一东丂东丘丛:  false);
            this.丞丆丏万丝世丐丈丌 = this.StartCoroutine(routine:  this.不不与丆一三世丗丄());
        }
        private void 丁丞丗丟万不丄下专()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丝三丘上丂丑丞丗丈());
        }
        private System.Collections.IEnumerator 丝三丘上丂丑丞丗丈()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanLootBoxRewardUI.丏与丙东丝下一丑丛(丗丏丅丕丆世丁专丟:  0);
        }
        private UnityEngine.AudioClip 上丈不一丟丞世丆丘()
        {
            return UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "OpenModChest");
        }
        private UnityEngine.AudioClip 丈丕丂丅万丝七一丙()
        {
            UnityEngine.AudioClip val_3;
            if(this.丏丌丐丅丝七业专丁 == 0)
            {
                    this.丏丌丐丅丝七业专丁 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "ModFallSound");
                return val_3;
            }
            
            val_3 = this.丏丌丐丅丝七业专丁;
            return val_3;
        }
        public ClanLootBoxRewardUI()
        {
            this.animateRewardDelay = 0.5f;
            this.multiOpenSpeedScale = 1.45f;
            this.丞上丈丁丙丙丟东万 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
            this.专东丐丂七专与丕丗 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Int32>>();
            this.丟丟且丄丑丝丑丒丅 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
        }
        private static ClanLootBoxRewardUI()
        {
        
        }
        private void 丘丆丑丁丌丘且丌不()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丝三丘上丂丑丞丗丈());
        }
    
    }

}
