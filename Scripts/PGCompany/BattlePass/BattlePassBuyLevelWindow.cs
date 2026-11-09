using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassBuyLevelWindow : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丄丘业与丈丛丛丝世;
        private bool 丒丂丏且上丌下丙丙;
        private System.Collections.Generic.List<Rilisoft.OfferItem> 丙丗丈世丁万丅丟丏;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丑丘七丄万丐三下世;
        private PGCompany.BattlePass.BPReward 丟七丐丝东且丟七丘;
        private int 丝三三世丄丟丞上丅;
        private UnityEngine.Coroutine 上万万丘丅丕专丄丟;
        private static PGCompany.BattlePass.BattlePassBuyLevelWindow <不丁丄七丛不丆丁丕>k__BackingField;
        private static System.Action 丛丄业丘不丆丄三丞;
        private Rilisoft.CharacterHelper _characterHelper;
        private UILabel _levelLabel;
        private UIButton _minusBtn;
        private UIButton _plusBtn;
        private UILabel _priceLabel;
        private UILabel _buyButtonLabel;
        private WidgetLayout _widgetLayout;
        private UIScrollView _scroll;
        private Rilisoft.BetterWrapContent _wrap;
        private UnityEngine.GameObject _defaultBackground;
        
        // Properties
        internal static PGCompany.BattlePass.BattlePassBuyLevelWindow 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        internal static PGCompany.BattlePass.BattlePassBuyLevelWindow 丑七不且上丗丁一世()
        {
            return (PGCompany.BattlePass.BattlePassBuyLevelWindow)PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BattlePassBuyLevelWindow 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassBuyLevelWindow.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassBuyLevelWindow.丛丄业丘不丆丄三丞 != 1152921505679798280);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassBuyLevelWindow.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassBuyLevelWindow.丛丄业丘不丆丄三丞 != 1152921505679798280);
        
        }
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            UnityEngine.Transform val_11 = 丆丏七丟不丒与七专;
            if(val_11 == 0)
            {
                    return;
            }
            
            if((PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    return;
            }
            
            string val_3 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPBuyLevel");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_3)) == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_3);
            if(val_5 == 0)
            {
                    return;
            }
            
            int val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            val_11 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_5, 丈东丘丏与丌东东下:  val_11 = 丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField = val_11.GetComponent<PGCompany.BattlePass.BattlePassBuyLevelWindow>();
            if((PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_11);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        private void OnEnable()
        {
            var val_14;
            System.Action<PGCompany.BattlePass.BPCharacterPositionModyfier> val_16;
            if(this.丄丘业与丈丛丛丝世 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                this.丄丘业与丈丛丛丝世.Dispose();
            }
            
            this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassBuyLevelWindow::Hide()), 与且专丈不万东一万:  0);
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_6 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_6 == null)
            {
                    return;
            }
            
            if(val_6.丐丞上丒七丞丁丙丕() != false)
            {
                    return;
            }
            
            this.丝三三世丄丟丞上丅 = val_6.业丈丅丂且丁与丄丂() + 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._characterHelper, 丏业丟一东丂东丘丛:  true);
            this._characterHelper.CharacterVisible = true;
            BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            val_14 = null;
            val_14 = null;
            val_16 = BattlePassBuyLevelWindow.<>c.<>9__16_0;
            if(val_16 == null)
            {
                    System.Action<PGCompany.BattlePass.BPCharacterPositionModyfier> val_11 = null;
                val_16 = val_11;
                val_11 = new System.Action<PGCompany.BattlePass.BPCharacterPositionModyfier>(object:  BattlePassBuyLevelWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BattlePassBuyLevelWindow.<>c::三不七业三丗丘不丐(PGCompany.BattlePass.BPCharacterPositionModyfier 三丟东丕丄丄下下丑));
                BattlePassBuyLevelWindow.<>c.<>9__16_0 = val_16;
            }
            
            PGCompany.BattlePass.BPCharacterPositionModyfier val_12 = 丞东丑专丛丆丄丝世.丒丌且丒丁专丈业丒<PGCompany.BattlePass.BPCharacterPositionModyfier>(丞下万上三丘上与专:  this._characterHelper.GetComponent<PGCompany.BattlePass.BPCharacterPositionModyfier>(), 丌专业且丛丏丞丝且:  val_11);
            this.丝一丅丆三东丂丞七();
        }
        private void OnDisable()
        {
            BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            if(this.丄丘业与丈丛丛丝世 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        private void 丝一丅丆三东丂丞七()
        {
            bool val_36;
            int val_37;
            var val_38;
            System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_40;
            var val_41;
            System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_43;
            var val_44;
            System.Func<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem> val_46;
            var val_47;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_49;
            .丝且与丝丒丟万丁专 = this;
            val_36 = Rilisoft.Singleton<BattlePassController>.Instance;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_3 = val_36.丛东丛丕东丟丂丈丝();
            .丅丑丈丂三业丆三万 = val_3;
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_3.丐丞上丒七丞丁丙丕() == true)
            {
                    return;
            }
            
            this._levelLabel.text = this.丝三三世丄丟丞上丅.ToString();
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_36 = (BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万;
            val_36 = this.丝三三世丄丟丞上丅 - val_36.业丈丅丂且丁与丄丂();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._priceLabel, 丕丗丘丑丛与丑业丒:  (BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.业丌丟且丒丅世丕丝() * val_36.ToString());
            var val_12 = (this.丝三三世丄丟丞上丅 > ((BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.业丈丅丂且丁与丄丂() + 1)) ? 1 : 0;
            val_37 = this.丝三三世丄丟丞上丅;
            var val_14 = (val_37 < (BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.丄且东且丕丛与丆丒()) ? 1 : 0;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._buyButtonLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10087"), arg0:  this.丝三三世丄丟丞上丅));
            if(this._widgetLayout != null)
            {
                    this._widgetLayout.Reposition();
            }
            
            if((BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.专丟专一丒且丘与丌() == 0)
            {
                    PlayerPaymentState val_18 = (BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.专丟专一丒且丘与丌();
            }
            
            val_38 = null;
            val_38 = null;
            val_40 = BattlePassBuyLevelWindow.<>c.<>9__18_1;
            if(val_40 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, System.Int32> val_22 = null;
                val_40 = val_22;
                val_22 = new System.Func<PGCompany.BattlePass.BPReward, System.Int32>(object:  BattlePassBuyLevelWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassBuyLevelWindow.<>c::东丝且丄丟丏且丌丌(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
                BattlePassBuyLevelWindow.<>c.<>9__18_1 = val_40;
            }
            
            val_41 = null;
            val_41 = null;
            val_43 = BattlePassBuyLevelWindow.<>c.<>9__18_2;
            if(val_43 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, System.Boolean> val_24 = null;
                val_43 = val_24;
                val_24 = new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  BattlePassBuyLevelWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassBuyLevelWindow.<>c::丐世丄一七丟专丟三(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
                BattlePassBuyLevelWindow.<>c.<>9__18_2 = val_43;
            }
            
            System.Collections.Generic.List<TSource> val_26 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.BattlePass.BPReward, System.Int32>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  (BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.业下丈丕丙丁东世丙(上丌丆丁丟上下专丁:  new System.Nullable<PlayerPaymentState>() {HasValue = false}, 丈丘丝一丗下丈丐不:  new System.Nullable<System.Int32>() {HasValue = false}, 不丝丟与丟丈一三与:  false), predicate:  new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  new BattlePassBuyLevelWindow.与丟业一丈上丅上不(), method:  System.Boolean BattlePassBuyLevelWindow.与丟业一丈上丅上不::七丅丐丏丝七丄丏丛(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛))), keySelector:  val_22), predicate:  val_24));
            this.丑丘七丄万丐三下世 = val_26;
            this.丑丘七丄万丐三下世 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丒不丂一丑丘丄业丁(上业丟世三与七七三:  val_26);
            this.丙丗丈世丁万丅丟丏.Clear();
            val_44 = null;
            val_44 = null;
            val_46 = BattlePassBuyLevelWindow.<>c.<>9__18_3;
            if(val_46 == null)
            {
                    System.Func<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem> val_28 = null;
                val_46 = val_28;
                val_28 = new System.Func<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem>(object:  BattlePassBuyLevelWindow.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem BattlePassBuyLevelWindow.<>c::七世东丂丑丐丁丅丗(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛));
                BattlePassBuyLevelWindow.<>c.<>9__18_3 = val_46;
            }
            
            val_47 = null;
            val_47 = null;
            val_49 = BattlePassBuyLevelWindow.<>c.<>9__18_4;
            if(val_49 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_30 = null;
                val_49 = val_30;
                val_30 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BattlePassBuyLevelWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassBuyLevelWindow.<>c::丑丌丅丛丟不丘万丞(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                BattlePassBuyLevelWindow.<>c.<>9__18_4 = val_49;
            }
            
            Rilisoft.OfferItem val_31 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<PGCompany.BattlePass.BPReward, Rilisoft.OfferItem>(source:  this.丑丘七丄万丐三下世, selector:  val_28), predicate:  val_30);
            if(val_31 != null)
            {
                    this.丙丗丈世丁万丅丟丏.Add(item:  val_31);
                BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  this._characterHelper, 丒丟丕上丅丆丆丝东:  0, 丏七丟丐丏丞丄不丅:  false, 丝丆下丐东世上一且:  0, 上业丟世三与七七三:  this.丙丗丈世丁万丅丟丏, 丒丈七三丄丞丐丝丂:  0);
            }
            
            val_36 = (BattlePassBuyLevelWindow.与丟业一丈上丅上不)[1152921560030957568].丅丑丈丂三业丆三万.丗丄上丑丑丅丐丒丌();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultBackground, 丏业丟一东丂东丘丛:  val_36);
            if(this.上万万丘丅丕专丄丟 != null)
            {
                    this.StopCoroutine(routine:  this.上万万丘丅丕专丄丟);
            }
            
            this.上万万丘丅丕专丄丟 = this.StartCoroutine(routine:  this.且丈一三丒丙专与丒());
        }
        private System.Collections.IEnumerator 且丈一三丒丙专与丒()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassBuyLevelWindow.丅与丒三专丄不专丒();
        }
        private void 丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            PGCompany.BattlePass.BPReward val_8;
            if((this.丑丘七丄万丐三下世 == null) || (this.丑丘七丄万丐三下世.Count <= 丘丒丌下丕专且七专))
            {
                goto label_2;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BPReward val_2 = this.丑丘七丄万丐三下世.Item[丘丒丌下丕专且七专];
            PGCompany.BattlePass.BPRewardView val_3 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BPRewardView>();
            if(val_3 != 0)
            {
                goto label_9;
            }
            
            return;
            label_2:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  false);
            return;
            label_9:
            val_3.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyLevelWindow::丝丈丆世且三与丝东(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)));
            System.Action<PGCompany.BattlePass.BPRewardView> val_6 = new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassBuyLevelWindow::丝丈丆世且三与丝东(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘));
            if(val_3 != null)
            {
                    val_3.add_Clicked(丙业与丙丗丝不丈东:  val_6);
                val_3.Setup(与且专丈不万东一万:  val_2);
                val_8 = this.丟七丐丝东且丟七丘;
            }
            else
            {
                    val_3.add_Clicked(丙业与丙丗丝不丈东:  val_6);
                val_3.Setup(与且专丈不万东一万:  val_2);
                val_8 = this.丟七丐丝东且丟七丘;
            }
            
            val_3.IsSelected = (val_8 == val_2) ? 1 : 0;
        }
        private PGCompany.BattlePass.BPRewardView 三不丞丈丆丟丅丆丌(PGCompany.BattlePass.BPReward 丗七丟丈三不丕一三)
        {
            var val_7;
            UnityEngine.Object val_8;
            val_7 = 丗七丟丈三不丕一三;
            List.Enumerator<T> val_2 = this._wrap.GetAllCellsObjects().GetEnumerator();
            label_9:
            if(((-409873336) & 1) == 0)
            {
                goto label_3;
            }
            
            val_8 = 0.丐丏七丌丕丗业且上().GetComponent<PGCompany.BattlePass.BPRewardView>();
            if((val_8 == 0) || (val_8.Context != val_7))
            {
                goto label_9;
            }
            
            goto label_10;
            label_3:
            val_8 = 0;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (PGCompany.BattlePass.BPRewardView)val_8;
        }
        private void 丝丈丆世且三与丝东(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)
        {
            this.七丞万丅一丄丛丛丝(丌丝万上丅丒一丈丘:  丌丝万上丅丒一丈丘, 丘下丛丝业丂丛业丟:  true);
        }
        private void 七丞万丅一丄丛丛丝(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘, bool 丘下丛丝业丂丛业丟)
        {
            var val_6;
            UnityEngine.Object val_31;
            UnityEngine.Transform val_32;
            var val_33;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_34;
            val_31 = 丌丝万上丅丒一丈丘;
            val_32 = this;
            if(val_31 == 0)
            {
                    return;
            }
            
            if(val_31.Context == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_4 = this._wrap.GetAllCellsObjects().GetEnumerator();
            label_26:
            if(((-409538784) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(val_7 == 0)
            {
                goto label_26;
            }
            
            PGCompany.BattlePass.BPRewardView val_9 = val_7.GetComponent<PGCompany.BattlePass.BPRewardView>();
            if(val_9 == 0)
            {
                goto label_26;
            }
            
            if(val_9 == val_31)
            {
                    if(val_9.IsSelected != false)
            {
                    var val_14 = (this.丟七丐丝东且丟七丘 == val_31.Context) ? 1 : 0;
            }
            else
            {
                    val_33 = 0;
            }
            
                var val_15 = (val_33 != 0) ? 1 : 0;
            }
            
            UnityEngine.Object val_30 = val_31;
            val_30 = UnityEngine.Object.op_Equality(x:  val_9, y:  val_30);
            val_9.IsSelected = val_30;
            goto label_26;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.BattlePass.BPReward val_17 = val_31.Context;
            this.丟七丐丝东且丟七丘 = val_17;
            val_31 = val_17.Item;
            if(val_31 == null)
            {
                    return;
            }
            
            if((0 & 丘下丛丝业丂丛业丟) != false)
            {
                    val_32 = this.transform;
                val_31 = val_31.Count;
                Rilisoft.ItemViewer val_23 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  val_32, 丕丁下丌不万丅丞丛:  val_31.Id, 丅三丟世下丞丝丙万:  val_31, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
                return;
            }
            
            if(val_31.IsEquipment != false)
            {
                    System.Collections.Generic.List<Rilisoft.OfferItem> val_25 = null;
                val_34 = val_25;
                val_25 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
                val_25.Add(item:  val_31);
            }
            else
            {
                    val_34 = this.丙丗丈世丁万丅丟丏;
            }
            
            BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  this._characterHelper, 丒丟丕上丅丆丆丝东:  0, 丏七丟丐丏丞丄不丅:  false, 丝丆下丐东世上一且:  0, 上业丟世三与七七三:  val_34, 丒丈七三丄丞丐丝丂:  0);
            if(val_31.IsEquipment == true)
            {
                    return;
            }
            
            val_32 = this.gameObject.transform;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_29 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_29.Add(item:  val_31);
            BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  0, 丒丟丕上丅丆丆丝东:  0, 丏七丟丐丏丞丄不丅:  true, 丝丆下丐东世上一且:  val_32, 上业丟世三与七七三:  val_29, 丒丈七三丄丞丐丝丂:  0);
        }
        private void 丒丟丙丅一丂丕下丑(int 丈丘丝一丗下丈丐不)
        {
            int val_7 = Rilisoft.Singleton<BattlePassController>.Instance;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = val_7.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.丐丞上丒七丞丁丙丕() != false)
            {
                    return;
            }
            
            val_7 = val_2.业丈丅丂且丁与丄丂() + 1;
            this.丝三三世丄丟丞上丅 = UnityEngine.Mathf.Clamp(value:  丈丘丝一丗下丈丐不, min:  val_7, max:  val_2.丄且东且丕丛与丆丒());
            this.丝一丅丆三东丂丞七();
        }
        public void Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            if(PGCompany.BattlePass.BattlePassBuyLevelWindow.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassBuyLevelWindow.丛丄业丘不丆丄三丞.Invoke();
        }
        public void BuyCurrency()
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI.丑七不且上丗丁一世().ShowBuyCurrencyWindow();
                return;
            }
            
            if((PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField.ShowBuyCurrencyWindow();
        }
        public void U_Back()
        {
            this.Hide();
        }
        public void U_LevelPlus()
        {
            this.丒丟丙丅一丂丕下丑(丈丘丝一丗下丈丐不:  this.丝三三世丄丟丞上丅 + 1);
        }
        public void U_LevelMinus()
        {
            this.丒丟丙丅一丂丕下丑(丈丘丝一丗下丈丐不:  this.丝三三世丄丟丞上丅 - 1);
        }
        public void U_BuyLevel()
        {
            PGCompany.BattlePass.BPSeasonEnd val_16;
            int val_17;
            val_16 = this;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.丐丞上丒七丞丁丙丕() == true)
            {
                    return;
            }
            
            val_17 = this.丝三三世丄丟丞上丅 - val_2.业丈丅丂且丁与丄丂();
            if(val_17 < 1)
            {
                    return;
            }
            
            if(val_2.东与三丌丅三丒丏业() >= (val_2.业丌丟且丒丅世丕丝() * val_17))
            {
                goto label_5;
            }
            
            val_17 = 1152921504848912384;
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                goto label_10;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().ShowBuyCurrencyWindow();
            return;
            label_5:
            if((val_2.万丈三丌万丐丅丘丗(下上不丏专丄丆业世:  val_17)) == false)
            {
                    return;
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI.丑七不且上丗丁一世().ResetRememberedParametersState();
            }
            
            this.Hide();
            return;
            label_10:
            val_16 = PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField;
            if(val_16 == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField.ShowBuyCurrencyWindow();
        }
        public void U_BuyCurrency()
        {
            this.BuyCurrency();
        }
        public BattlePassBuyLevelWindow()
        {
            this.丒丂丏且上丌下丙丙 = true;
            this.丙丗丈世丁万丅丟丏 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.丑丘七丄万丐三下世 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
        }
        private int 丁与下丁丗业一丘世()
        {
            if(this.丑丘七丄万丐三下世 != null)
            {
                    return this.丑丘七丄万丐三下世.Count;
            }
            
            return this.丑丘七丄万丐三下世.Count;
        }
    
    }

}
