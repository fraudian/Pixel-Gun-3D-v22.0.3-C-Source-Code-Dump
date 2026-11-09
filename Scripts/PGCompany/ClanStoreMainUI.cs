using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanStoreMainUI : BannerWindow, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private static PGCompany.ClanStoreMainUI <不丁丄七丛不丆丁丕>k__BackingField;
        internal static readonly System.Collections.Generic.List<BankView.BankViewTab> 丑丝专丐与与业丏丗;
        internal UnityEngine.Transform MainContainer;
        private PGCompany.StoreListPromotionView _storeListPromotionView;
        private PGCompany.StoreListItemView _storeListItemView;
        private PGCompany.ClanStoreTabButton _clanStoreTabButtonExample;
        private UIGrid _tabsGris;
        private SelectableButtonController _selectableButtonController;
        private UnityEngine.GameObject _refreshContainer;
        private PGCompany.ItemCurrencyUI _refreshPromotionsCurrency;
        private PGCompany.TimerUI _timerToRefresh;
        private UILabel _divisionLabel;
        private UISprite _divisionSprite;
        private UnityEngine.GameObject _notifBtnsContainer;
        private UnityEngine.GameObject _giftsBottomObject;
        private UnityEngine.GameObject _fortNotifBtnsContainer;
        private UILabel _fortNotifCountLabel;
        private UnityEngine.GameObject _tankNotifBtnsContainer;
        private UILabel _tankNotifCountLabel;
        private UnityEngine.GameObject _moduleNotifBtnsContainer;
        private UILabel _moduleNotifCountLabel;
        private UIToggle _toggleShowArmor;
        private ItemsHistoryView _reawardHistoryView;
        private UnityEngine.GameObject _rewardHistoryButtonGo;
        private UnityEngine.GameObject _purchaseSuccessfullBox;
        private UnityEngine.Coroutine 丙丆丄世专丕丘上万;
        private static System.Action 业丙丘丈七不下下丐;
        private static System.Action 丛丄业丘不丆丄三丞;
        private static System.Action 丌上且丟丈丄丝丆专;
        private SelectableButton 丟丛不不一不丞丞不;
        private System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, UnityEngine.MonoBehaviour> 上丅丛业上丛丛世与;
        private System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, SelectableButton> 专万丕丟业丙丞三丐;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private static PGCompany.ClanStoreTab 丌东丗丁不丐丌下丙;
        private static PGCompany.东丑丆丗丏丐丟下丄 上一与丕丕世业专世;
        private static PGCompany.丟丁且丝丁三丏丙且 丙丛丟丛与专丑丝丈;
        private static PGCompany.丗丟丄丈东丝丕丄世 丐与上丒丘丝丁丘丑;
        private static float 丝且上一丈七上丒丆;
        private static float 丒丝丂丄丞专丝丟丙;
        private static UnityEngine.Rect 丘下丆丅与下丑丑三;
        private System.Collections.Generic.List<PGCompany.万丛下丐与丅与丅专> 丙丐丑三世丞丄丂万;
        private System.Collections.Generic.List<PGCompany.万丛下丐与丅与丅专> 且丂丅七三丈丙丈丏;
        private int 丆丐世丅七一丑七且;
        private UnityEngine.GameObject 丏丗丈与丌七丟下与;
        private PGCompany.ClanStoreTab 业丛与业丆三三丝丕;
        private bool 一丛东丆七一下丈丑;
        private UnityEngine.Coroutine 丑东丝丙丛七东与一;
        private UnityEngine.GameObject 丅丙与下丈丗丆丞丅;
        
        // Properties
        internal static PGCompany.ClanStoreMainUI 丆丕丝丒不丙且丐丗 { get; set; }
        internal PGCompany.StoreListItemView 丑世丝七丄丅丌丐专 { get; }
        internal static bool 下丐丙专丕丙丗万丕 { get; }
        internal PGCompany.ClanStoreTab 丑丒丈专丑世丆丛三 { get; }
        private UnityEngine.GameObject 上丙丝丆专东七丄丈 { get; }
        
        // Methods
        internal static PGCompany.ClanStoreMainUI 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.ClanStoreMainUI)PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.ClanStoreMainUI 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.StoreListItemView 丛且专丑业丆东东丝()
        {
            return (PGCompany.StoreListItemView)this._storeListItemView;
        }
        internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanStoreMainUI.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreMainUI.业丙丘丈七不下下丐 != 1152921505577189392);
        
        }
        internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanStoreMainUI.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreMainUI.业丙丘丈七不下下丐 != 1152921505577189392);
        
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanStoreMainUI.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreMainUI.丛丄业丘不丆丄三丞 != 1152921505577189400);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanStoreMainUI.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreMainUI.丛丄业丘不丆丄三丞 != 1152921505577189400);
        
        }
        internal static void 丈丆丒三丈丗世丞丆(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanStoreMainUI.丌上且丟丈丄丝丆专, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreMainUI.丌上且丟丈丄丝丆专 != 1152921505577189408);
        
        }
        internal static void 丟丛丂丄丞业万一丘(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanStoreMainUI.丌上且丟丈丄丝丆专, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanStoreMainUI.丌上且丟丈丄丝丆专 != 1152921505577189408);
        
        }
        internal static bool 丛世丛与丌不丈丐丐()
        {
            if(PGCompany.ClanStoreMainUI.丑七不且上丗丁一世() == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_4 = PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().gameObject;
            if(val_4 != null)
            {
                    return val_4.activeInHierarchy;
            }
            
            return val_4.activeInHierarchy;
        }
        internal PGCompany.ClanStoreTab 下丆丅丕丒上世业丘()
        {
            return (PGCompany.ClanStoreTab)this.业丛与业丆三三丝丕;
        }
        internal static void 丆丙丗三东专丐不上(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丞丘丞丏业且丛丏丘:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不()));
        }
        internal static void 丆丙丗三东专丐不上(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
        {
            PGCompany.ClanStoreTab val_16;
            PGCompany.东丑丆丗丏丐丟下丄 val_17;
            System.Collections.Generic.List<System.Tuple<PGCompany.东丑丆丗丏丐丟下丄, PGCompany.ClanStoreTab>> val_4 = 0;
            if((PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().世世丌丛丝三与且且(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  丞丘丞丏业且丛丏丘.业东丅东丌上丗丑不()), 丕丙丏一业世丘不丈:  0, 丞丞且且一丘丒丟万: out  val_4)) == false)
            {
                goto label_5;
            }
            
            System.Tuple<PGCompany.东丑丆丗丏丐丟下丄, PGCompany.ClanStoreTab> val_6 = System.Linq.Enumerable.First<System.Tuple<PGCompany.东丑丆丗丏丐丟下丄, PGCompany.ClanStoreTab>>(source:  val_4);
            if(val_6 == null)
            {
                goto label_6;
            }
            
            val_16 = val_6.Item2;
            goto label_7;
            label_5:
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "No promo found...");
            val_17 = PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().丝丁不七丒三丑业丑();
            val_16 = 1;
            goto label_11;
            label_6:
            val_16 = 0.Item2;
            label_7:
            val_17 = val_6.Item1;
            object[] val_12 = new object[4];
            val_12[0] = "Found promo! ID: ";
            val_12[1] = val_17.七丈丒丒下下且万与();
            val_12[2] = " Tab: ";
            val_12[3] = val_16;
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  +val_12);
            label_11:
            PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丐丅丒专丛丏上与业:  val_16, 且丘丏丁丑与丙与丁:  val_17, 丅丘丌且丈丘丄丗丄:  0, 丞丘丞丏业且丛丏丘:  丞丘丞丏业且丛丏丘);
            float val_15 = UnityEngine.Time.realtimeSinceStartup;
            val_15 = val_15 + 1000000f;
            PGCompany.ClanStoreMainUI.丝且上一丈七上丒丆 = val_15;
        }
        private void Update()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(StoreKitEventListener.三丘丈不丝丕丞东丌() != false)
            {
                    val_11 = 1;
            }
            else
            {
                    val_12 = null;
                val_12 = null;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.下一丕丆丘丒丕丛丈(), 丏业丟一东丂东丘丛:  (StoreKitEventListener.丌丗丆丟丈丆丝丝丄 == true) ? 1 : 0);
            val_13 = null;
            val_13 = null;
            RilisoftRotator.丒丌丄丛丟丏丒世丄(世丟丈丏丕万丝丆万:  this._storeListItemView.丟丑万与丒与不下丛().transform, 丄七丛丝丏丈丒丝业:  RilisoftRotator.丙丂专一丄丞丛业上(), 丕丏丘七丗丘万丟丛:  new UnityEngine.Rect() {m_XMin = PGCompany.ClanStoreMainUI.丘下丆丅与下丑丑三, m_YMin = PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_54, m_Width = PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_58, m_Height = PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_5C}, 丑丗丘丞丗丌三丈丆: ref  1152921505577189448, 三丕丂且一丝丈三一: ref  1152921505577189452, 丝丛业丑专业一丁上:  0);
            val_14 = null;
            val_14 = null;
            if((UnityEngine.Time.realtimeSinceStartup - PGCompany.ClanStoreMainUI.丝且上一丈七上丒丆) > ShopNGUIController.上丈丂丁三丂业丛丝)
            {
                    this.丂万丑东七业丁业丁();
            }
            
            if(this.一丛东丆七一下丈丑 == false)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            if(PGCompany.ClanLootBoxRewardUI.七丂丑七丑世丂不丒 == true)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            if(PGCompany.ClanLootBoxInfoUI.七丂丑七丑世丂不丒 != false)
            {
                    return;
            }
            
            this.一丛东丆七一下丈丑 = false;
            丌丅且丗七丘丅丛丑.丏丂专丄七且不丌丛();
        }
        private void 丂万丑东七业丁业丁()
        {
            var val_15;
            var val_16;
            val_15 = null;
            val_15 = null;
            float val_15 = 1000000f;
            val_15 = UnityEngine.Time.realtimeSinceStartup + val_15;
            PGCompany.ClanStoreMainUI.丝且上一丈七上丒丆 = val_15;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  0f);
            Holoville.HOTween.TweenParms val_11 = new Holoville.HOTween.TweenParms().Prop(p_propName:  "localPosition", p_endVal:  0).Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w})).Prop(p_propName:  "localScale", p_endVal:  0).UpdateType(p_updateType:  3).Ease(p_easeType:  0);
            val_16 = null;
            val_16 = null;
            if((ClanStoreMainUI.<>c.<>9__64_0) == null)
            {
                goto label_14;
            }
            
            label_21:
            Holoville.HOTween.Tweener val_13 = Holoville.HOTween.HOTween.To(p_target:  this._storeListItemView.丟丑万与丒与不下丛().transform, p_duration:  0.5f, p_parms:  val_11.OnComplete(p_function:  ClanStoreMainUI.<>c.<>9__64_0));
            return;
            label_14:
            ClanStoreMainUI.<>c.<>9__64_0 = new TweenDelegate.TweenCallback(object:  ClanStoreMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStoreMainUI.<>c::下与且三且上万丟下());
            if(val_11 != null)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        internal static void 丆丙丗三东专丐不上(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业 = 0, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄, PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
        {
            null = null;
            PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙 = 丐丅丒专丛丏上与业;
            PGCompany.ClanStoreMainUI.上一与丕丕世业专世 = 且丘丏丁丑与丙与丁;
            PGCompany.ClanStoreMainUI.丙丛丟丛与专丑丝丈 = 丅丘丌且丈丘丄丗丄;
            PGCompany.ClanStoreMainUI.丐与上丒丘丝丁丘丑 = 丞丘丞丏业且丛丏丘;
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  43, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        protected override void Awake()
        {
            PGCompany.ClanStoreMainUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
            this._storeListItemView.丏世丑业丟世上丏丟 = this;
            this.上丅丛业上丛丛世与.set_Item(key:  1, value:  this._storeListPromotionView);
            this.上丅丛业上丛丛世与.set_Item(key:  2, value:  this._storeListPromotionView);
            this.上丅丛业上丛丛世与.set_Item(key:  3, value:  this._storeListItemView);
            this.上丅丛业上丛丛世与.set_Item(key:  4, value:  this._storeListItemView);
            this.上丅丛业上丛丛世与.set_Item(key:  5, value:  this._storeListItemView);
            this.上丅丛业上丛丛世与.set_Item(key:  6, value:  this._storeListPromotionView);
            this.一丐下丏丅丂丟三丒();
            int val_4 = UnityEngine.Screen.width;
            float val_7 = (float)UnityEngine.Screen.height;
            float val_8 = (float)UnityEngine.Screen.width;
            val_7 = val_7 * 0.1f;
            float val_9 = (float)UnityEngine.Screen.height;
            val_8 = val_8 + (与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (-450f));
            val_9 = val_9 * 0.8f;
            PGCompany.ClanStoreMainUI.丘下丆丅与下丑丑三 = 0;
            PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_54 = 0;
            PGCompany.ClanStoreMainUI.<不丁丄七丛不丆丁丕>k__BackingField.__il2cppRuntimeField_5C = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchaseSuccessfullBox, 丏业丟一东丂东丘丛:  false);
            万专丙丌丌丐上丟三.不下丑丆丐且丆下与();
        }
        private void 七丑丌丘丌丁下丂丞()
        {
            var val_4;
            if(this.业丛与业丆三三丝丕 == 1)
            {
                    var val_3 = ((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丕丑丏下世丞丁丟东()) > 0) ? 1 : 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardHistoryButtonGo, 丏业丟一东丂东丘丛:  false);
        }
        private void 一丐下丏丅丂丟三丒()
        {
            var val_4;
            var val_11;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanStoreTabButtonExample, 丏业丟一东丂东丘丛:  false);
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.上丅丛业上丛丛世与.Keys.GetEnumerator();
            label_21:
            if(((-2020499664) & 1) == 0)
            {
                goto label_5;
            }
            
            int val_5 = val_4.丙东专丂世丈丏丁丂();
            PGCompany.ClanStoreTabButton val_9 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._clanStoreTabButtonExample.gameObject, 丈东丘丏与丌东东下:  this._tabsGris.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}).GetComponent<PGCompany.ClanStoreTabButton>();
            if(val_9 == 0)
            {
                goto label_21;
            }
            
            val_9.丈且东丑丂且万丒丅(丐丅丒专丛丏上与业:  val_5);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9, 丏业丟一东丂东丘丛:  true);
            this._selectableButtonController.allButtons.Add(item:  val_9.SelectableButton);
            this.专万丕丟业丙丞三丐.Add(key:  val_5, value:  val_9.SelectableButton);
            goto label_21;
            label_5:
            val_11 = public System.Void Dictionary.KeyCollection.Enumerator<PGCompany.ClanStoreTab, UnityEngine.MonoBehaviour>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this._tabsGris != null)
            {
                    return;
            }
        
        }
        private void 丞丂业丗与丟且丐丑()
        {
            PGCompany.ClanStoreTabButton val_1 = this._selectableButtonController.selectedButton.GetComponent<PGCompany.ClanStoreTabButton>();
            this.业丛与业丆三三丝丕 = val_1.<丂世丟丌三三业下世>k__BackingField;
            this.七丑丌丘丌丁下丂丞();
            this.丐万丄丄丙三上七东();
        }
        private void 七丙丏七丘丟上丅丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            if(this.业丛与业丆三三丝丕 != 2)
            {
                    return;
            }
            
            this.丐万丄丄丙三上七东();
        }
        private void 丐万丄丄丙三上七东()
        {
            object val_19;
            var val_52;
            var val_53;
            IntPtr val_54;
            var val_55;
            var val_56;
            PGCompany.ClanStoreTab val_57;
            var val_58;
            System.Action<UnityEngine.MonoBehaviour> val_60;
            PGCompany.三东丏不丗世丅丌丄 val_61;
            var val_62;
            var val_63;
            val_52 = 1152921504615686144;
            System.Action<丗丞丏丙七丑丕且丐> val_1 = null;
            val_54 = 1152921554126394704;
            val_1 = new System.Action<丗丞丏丙七丑丕且丐>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::且丌东七丒不专丗七(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业));
            val_55 = 1152921505576812544;
            PGCompany.丄且丗且下上七世丂.与丐丅东丛丕不丆丄(丙业与丙丗丝不丈东:  val_1);
            val_56 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._refreshContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notifBtnsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._giftsBottomObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._toggleShowArmor, 丏业丟一东丂东丘丛:  false);
            val_57 = this.业丛与业丆三三丝丕;
            if((this.上丅丛业上丛丛世与.ContainsKey(key:  val_57)) == false)
            {
                    return;
            }
            
            val_58 = null;
            val_58 = null;
            val_60 = ClanStoreMainUI.<>c.<>9__71_0;
            if(val_60 == null)
            {
                    System.Action<UnityEngine.MonoBehaviour> val_4 = null;
                val_60 = val_4;
                val_4 = new System.Action<UnityEngine.MonoBehaviour>(object:  ClanStoreMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStoreMainUI.<>c::丗丏世丗丂丆丝与丂(UnityEngine.MonoBehaviour 三丟东丕丄丄下下丑));
                ClanStoreMainUI.<>c.<>9__71_0 = val_60;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.MonoBehaviour>(丌丛丏业世丄丞三丌:  this.上丅丛业上丛丛世与.Values, 七丐丅专且专七三丆:  val_4);
            val_57 = this.上丅丛业上丛丛世与.Item[this.业丛与业丆三三丝丕];
            val_61 = 0;
            if( == 0)
            {
                goto label_65;
            }
            
            System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> val_9 = PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().丗不丞一且丟丈丈丗(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕);
            下与丞三丅丛丄七丕(七丄丆丘丒与丐丘丅:  val_9);
            val_61 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丘丂丙万丈丗丒三丐(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕);
            this._refreshContainer.SetActive(value:  (val_61 != 0) ? 1 : 0);
            if(val_61 != null)
            {
                    this._refreshPromotionsCurrency.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_61, 丗丂丞丛丒丒丟万丗:  false);
                if(FriendsController.丝丗专上三不丄丑丑() >= 1)
            {
                    val_61 = this._timerToRefresh;
                val_61.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().东上丒三丛不下东七(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丐万丄丄丙三上七东()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            }
            
            }
            
            val_54 = 1152921554126394704;
            val_56 = 1152921505284374528;
            if(this.业丛与业丆三三丝丕 != 1)
            {
                goto label_65;
            }
            
            List.Enumerator<T> val_17 = val_9.GetEnumerator();
            goto label_51;
            label_52:
            string val_20 = val_19.丐丏七丌丕丗业且上();
            if((val_20 != null) && (val_20 != null))
            {
                    val_61 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_20);
                if((val_61 != null) && (val_20.不业丙丒丂丞下丆丙() == 1))
            {
                    val_54 = 1152921554126394704;
                if((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丝丞东业丌丐与不丕(丏专丒丅丙七三专丐:  val_61.业东丅东丌上丗丑不())) != false)
            {
                    val_54 = 1152921554126394704;
                if((Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  val_61.业东丅东丌上丗丑不())) != true)
            {
                    val_61 = val_61.业东丅东丌上丗丑不();
                System.TimeSpan val_31 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丝三丅下丂丘下丐专(丏专丒丅丙七三专丐:  val_61);
                double val_32 = val_31._ticks.TotalSeconds;
                if((val_32 + 1) < 0)
            {
                    int val_51 = (int)val_32;
                val_51 = val_51 + 1;
            }
            
            }
            
            }
            
            }
            
            }
            
            label_51:
            if(((-2019854432) & 1) != 0)
            {
                goto label_52;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_52 = 1152921504615686144;
            val_56 = 1152921505284374528;
            if(val_51 != 2147483647)
            {
                    if(this.丑东丝丙丛七东与一 != null)
            {
                    this.StopCoroutine(routine:  this.丑东丝丙丛七东与一);
            }
            
                UnityEngine.Coroutine val_35 = this.StartCoroutine(routine:  this.丙丒丌丗不丙专丝世(丑丕三丐下东三东业:  val_51));
            }
            
            label_65:
            if(val_57 != null)
            {
                    val_57 = 0;
            }
            
            if( != 0)
            {
                    val_61 = mem[(UnityEngine.MonoBehaviour.__il2cppRuntimeField_typeHierarchy + (PGCompany.StoreListItemView.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_5 : 0 + 248];
                val_61 = (UnityEngine.MonoBehaviour.__il2cppRuntimeField_typeHierarchy + (PGCompany.StoreListItemView.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_5 : 0 + 248;
                val_19 = 4;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                if((this.业丛与业丆三三丝丕.Equals(obj:  val_19)) != false)
            {
                    val_54 = val_54;
                val_62 = (~PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丞丙丙专丅丆三不与()) & 1;
            }
            else
            {
                    val_62 = 0;
                val_54 = val_54;
            }
            
                val_53 = 131346432;
                val_55 = 1152921505576812544;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_61, 丏业丟一东丂东丘丛:  false);
                丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().万丞万丘丈下东上丘(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕));
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  null, 丏业丟一东丂东丘丛:  true);
                val_56 = ;
                val_52 = 1152921504615686144;
            }
            
            val_63 = mem[this.业丛与业丆三三丝丕];
            val_63 = this.业丛与业丆三三丝丕;
            if(val_63 == 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notifBtnsContainer, 丏业丟一东丂东丘丛:  true);
                val_61 = 1152921554126558544;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._fortNotifBtnsContainer, 丏业丟一东丂东丘丛:  (this.丙丐丑三世丞丄丂万.Count > 0) ? 1 : 0);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tankNotifBtnsContainer, 丏业丟一东丂东丘丛:  (this.且丂丅七三丈丙丈丏.Count > 0) ? 1 : 0);
                val_57 = this._moduleNotifBtnsContainer;
                val_57.SetActive(value:  (this.丆丐世丅七一丑七且 > 0) ? 1 : 0);
                val_63 = mem[this.业丛与业丆三三丝丕];
                val_63 = this.业丛与业丆三三丝丕;
            }
            
            if(val_63 == 6)
            {
                    val_57 = this._giftsBottomObject;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_57, 丏业丟一东丂东丘丛:  true);
                val_63 = mem[this.业丛与业丆三三丝丕];
                val_63 = this.业丛与业丆三三丝丕;
            }
            
            if(val_63 == 5)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._toggleShowArmor, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  this._toggleShowArmor, 丏业丟一东丂东丘丛:  三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁());
            }
            
            PGCompany.丄且丗且下上七世丂.丅不与丛丅丕丛专丄(丙业与丙丗丝不丈东:  new System.Action<丗丞丏丙七丑丕且丐>(object:  this, method:  val_54));
            this.丂万丑东七业丁业丁();
        }
        private System.Collections.IEnumerator 丙丒丌丗不丙专丝世(int 丑丕三丐下东三东业)
        {
            ClanStoreMainUI.万丄世三丘丟专丛丆 val_1 = new ClanStoreMainUI.万丄世三丘丟专丛丆();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丑丕三丐下东三东业 = 丑丕三丐下东三东业;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 一且丒丌一丒丛丗三()
        {
            UnityEngine.GameObject val_10;
            int val_11;
            val_10 = this;
            System.Collections.Generic.List<System.String> val_5 = 0;
            System.Collections.Generic.Dictionary<CategoryNames, System.Collections.Generic.List<System.String>> val_3 = 0;
            if((PGCompany.七不丐丐丒丆世丒丏.丑七不且上丗丁一世().一丈丅丞丙丁丁丂不().TryGetValue(key:  8, value: out  val_3)) == false)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
            
            if((val_3.TryGetValue(key:  96, value: out  val_5)) == false)
            {
                    return;
            }
            
            if(val_5 == 0)
            {
                goto label_8;
            }
            
            val_11 = val_5.Count;
            if(this != null)
            {
                goto label_14;
            }
            
            label_15:
            label_14:
            this.丆丐世丅七一丑七且 = val_11;
            if(val_11 >= 1)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._moduleNotifCountLabel, 丕丗丘丑丛与丑业丒:  this.丆丐世丅七一丑七且.ToString());
                val_11 = mem[this.丆丐世丅七一丑七且];
                val_11 = this.丆丐世丅七一丑七且;
            }
            
            val_10 = this._moduleNotifBtnsContainer;
            val_10.SetActive(value:  (val_11 > 0) ? 1 : 0);
            return;
            label_8:
            if(this != null)
            {
                goto label_14;
            }
            
            goto label_15;
        }
        protected override void OnEnable()
        {
            var val_24;
            this.OnEnable();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanStoreMainUI::U_Back()), 与且专丈不万东一万:  "ClanStoreMainUI");
            if(this.丟丛不不一不丞丞不 == 0)
            {
                    this._selectableButtonController.下丁万万丅丆东不不();
            }
            
            this._selectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丞丂业丗与丟且丐丑()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::上且丆丛业且丞丟业()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().丞丝三丑丘专丝丙丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::上且丆丛业且丞丟业()));
            PGCompany.丄且丗且下上七世丂.与丐丅东丛丕不丆丄(丙业与丙丗丝不丈东:  new System.Action<PGCompany.ClanStoreTab>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::且丌东七丒不专丗七(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)));
            PGCompany.丄且丗且下上七世丂.丅不与丛丅丕丛专丄(丙业与丙丗丝不丈东:  new System.Action<PGCompany.ClanStoreTab>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::且丌东七丒不专丗七(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)));
            PGCompany.ClanStoreBuffsController.丛丟丌东三丆丆与丕(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丙丏七丘丟上丅丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
            PGCompany.ClanLootBoxController.丟丐东丆丐丄世丛丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丑丌丘丌丁下丂丞()));
            PGCompany.ClanLootBoxController.丁与丄东一万不丄丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丑丌丘丌丁下丂丞()));
            this.七丑丌丘丌丁下丂丞();
            ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丈丛三业丝世世丑丆()));
            val_24 = null;
            val_24 = null;
            if(PGCompany.ClanStoreMainUI.业丙丘丈七不下下丐 != null)
            {
                    PGCompany.ClanStoreMainUI.业丙丘丈七不下下丐.Invoke();
            }
            
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 万且万且丑丗且丌丆)));
            PGCompany.ItemExpiryController.丐丐丞丒下丙丟丂万(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 万且万且丑丗且丌丆)));
            丌丅且丗七丘丅丛丑.丌业三专丞丆万丏丁(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
            PGCompany.东丑丆丗丏丐丟下丄.丘下丟一丌上业丘万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丏丝丘七丕与世丅丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一丏七丐丏丐丞丏丙, object 一丐丗丁丞丆丅丟丄)));
        }
        private void 丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)
        {
            PGCompany.Banners.ClanRankPromoteWindow.与丏不丂专丕丁世丐(与上丟丏业专业与专:  new 上丑下丆丄下丝东世() {丒丗丝七丛丟专丄丂 = 万且万且丑丗且丌丆.丒丗丝七丛丟专丄丂, 且丅七丏业丛丙丟下 = 万且万且丑丗且丌丆.且丅七丏业丛丙丟下, 世丛丘丙世丝丟一丂 = 万且万且丑丗且丌丆.世丛丘丙世丝丟一丂, 丟专丙丐专世丁与一 = 万且万且丑丗且丌丆.丟专丙丐专世丁与一});
            if(万且万且丑丗且丌丆.世丛丘丙世丝丟一丂 <= 万且万且丑丗且丌丆.丒丗丝七丛丟专丄丂)
            {
                    return;
            }
            
            this.一丛东丆七一下丈丑 = true;
        }
        private void 丏丝丘七丕与世丅丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一丏七丐丏丐丞丏丙, object 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            if((this.业丛与业丆三三丝丕.Equals(obj:  2)) == false)
            {
                    return;
            }
            
            this.丛丒丄与丙下丙东丞();
        }
        private void 丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 万且万且丑丗且丌丆)
        {
            this.丐万丄丄丙三上七东();
        }
        private void 世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 1155)
            {
                    if(丅一丘丙上东丏丅不.一且丟丁上丑业丕且.不业丙丒丂丞下丆丙() != 1150)
            {
                    return;
            }
            
            }
            
            this.一且丒丌一丒丛丗三();
        }
        private void 世丆东丙丆下丟丌七(PGCompany.三东丏不丗世丅丌丄 丛丆东与丑丞丅丝专, PGCompany.三东丏不丗世丅丌丄 不丁丌丐业丑丟且不)
        {
            if((PGCompany.万丞丘与丕丞下万丌.丏丟下丐丝丙三且东(丁丅丈丌丟世丗丗丟:  不丁丌丐业丑丟且不.不业丙丒丂丞下丆丙())) == false)
            {
                    return;
            }
            
            this.一且丒丌一丒丛丗三();
        }
        private void 且丌东七丒不专丗七(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(this.业丛与业丆三三丝丕 != 丐丅丒专丛丏上与业)
            {
                    return;
            }
            
            this.丐万丄丄丙三上七东();
        }
        internal void 丆丂东丄万三不丏丅(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄, PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘, bool 丑丒万丐丞丒丈专丞 = False)
        {
            PGCompany.东丑丆丗丏丐丟下丄 val_12;
            System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, UnityEngine.MonoBehaviour> val_13;
            UnityEngine.Object val_14;
            var val_15;
            val_12 = 且丘丏丁丑与丙与丁;
            val_13 = this;
            if((this.专万丕丟业丙丞三丐.ContainsKey(key:  丐丅丒专丛丏上与业)) == false)
            {
                    return;
            }
            
            SelectableButton val_2 = this.专万丕丟业丙丞三丐.Item[丐丅丒专丛丏上与业];
            if((this.上丅丛业上丛丛世与.ContainsKey(key:  丐丅丒专丛丏上与业)) == false)
            {
                    return;
            }
            
            if(val_12 == null)
            {
                goto label_7;
            }
            
            val_14 = this.上丅丛业上丛丛世与.Item[丐丅丒专丛丏上与业];
            if(val_14 == null)
            {
                goto label_9;
            }
            
            val_15 = 0;
            val_14 = 0;
            if(丑丒万丐丞丒丈专丞 == true)
            {
                goto label_19;
            }
            
            goto label_33;
            label_7:
            this.丞丂业丗与丟且丐丑();
            if(丅丘丌且丈丘丄丗丄 == null)
            {
                    return;
            }
            
            val_13 = this.上丅丛业上丛丛世与;
            if(val_13.Item[丐丅丒专丛丏上与业] == null)
            {
                    return;
            }
            
            return;
            label_9:
            val_15 = 0;
            if(丑丒万丐丞丒丈专丞 == true)
            {
                goto label_19;
            }
            
            goto label_33;
            label_19:
            UnityEngine.Debug.LogError(message:  "Show chest info");
            if(val_14 != 0)
            {
                    val_12 = 丛下丈丙万丈万丅且(丐丆丝业丙丈下世丁:  val_12, 一丐丗丁丞丆丅丟丄:  0);
                if((((val_12 != null) && (丞丘丞丏业且丛丏丘 != null)) && (val_12 != 0)) && (null == null))
            {
                    bool val_11 = (null == null) ? (val_12) : 0.丞丝丅丞丒丌与丑丅(下丅丙一丂丗丅丝七:  丞丘丞丏业且丛丏丘);
            }
            
            }
            
            label_33:
            this.丞丂业丗与丟且丐丑();
        }
        internal void 丆丞专专丌下丛七且(UnityEngine.GameObject 丈丁丅丈丌三丕七丗)
        {
            UnityEngine.GameObject val_11;
            if(this.丏丗丈与丌七丟下与 != 0)
            {
                    val_11 = this.丏丗丈与丌七丟下与;
                if(val_11.activeSelf == true)
            {
                    return;
            }
            
            }
            
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丈丁丅丈丌三丕七丗, parent:  this.transform.GetChild(index:  0));
            this.丏丗丈与丌七丟下与 = val_5;
            val_11 = UnityEngine.LayerMask.NameToLayer(layerName:  "Banners");
            int val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_5, 不东丛三丂丌丑专丆:  val_11, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UnityEngine.Transform val_8 = this.丏丗丈与丌七丟下与.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_8.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_8.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丏丗丈与丌七丟下与, 丏业丟一东丂东丘丛:  true);
        }
        protected override void OnDisable()
        {
            SelectableButtonController val_14;
            var val_15;
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::世丆东丙丆下丟丌七(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
            PGCompany.丄且丗且下上七世丂.与丐丅东丛丕不丆丄(丙业与丙丗丝不丈东:  new System.Action<PGCompany.ClanStoreTab>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::且丌东七丒不专丗七(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)));
            PGCompany.ClanLootBoxController.丟丐东丆丐丄世丛丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丑丌丘丌丁下丂丞()));
            this._selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丞丂业丗与丟且丐丑()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::上且丆丛业且丞丟业()));
            PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 万且万且丑丗且丌丆)));
            PGCompany.ClanStoreBuffsController.且三丌丛丛丘丞丏丕(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丙丏七丘丟上丅丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
            this.OnDisable();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            val_14 = this._selectableButtonController;
            if(val_14 != null)
            {
                    this.丟丛不不一不丞丞不 = this._selectableButtonController.selectedButton;
            }
            else
            {
                    val_14 = this._selectableButtonController;
                this.丟丛不不一不丞丞不 = this._selectableButtonController.selectedButton;
            }
            
            val_14.丞与万丕丈丒丌丆世();
            ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丈丛三业丝世世丑丆()));
            PGCompany.东丑丆丗丏丐丟下丄.三七一不丆丒不三丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>, System.Object>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丏丝丘七丕与世丅丆(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一丏七丐丏丐丞丏丙, object 一丐丗丁丞丆丅丟丄)));
            this.一丛东丆七一下丈丑 = false;
            val_15 = null;
            val_15 = null;
            if(PGCompany.ClanStoreMainUI.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.ClanStoreMainUI.丛丄业丘不丆丄三丞.Invoke();
        }
        public override void Show()
        {
            var val_3;
            PGCompany.ClanStoreTab val_6;
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            this.Show();
            this.SetDivisionName();
            val_3 = null;
            val_3 = null;
            if(PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙 == 0)
            {
                    val_3 = null;
                PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙 = 1;
            }
            
            val_3 = null;
            val_6 = PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙;
            if(val_6 != 0)
            {
                    val_6 = PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙;
                this.丆丂东丄万三不丏丅(丐丅丒专丛丏上与业:  val_6, 且丘丏丁丑与丙与丁:  PGCompany.ClanStoreMainUI.上一与丕丕世业专世, 丅丘丌且丈丘丄丗丄:  PGCompany.ClanStoreMainUI.丙丛丟丛与专丑丝丈, 丞丘丞丏业且丛丏丘:  PGCompany.ClanStoreMainUI.丐与上丒丘丝丁丘丑, 丑丒万丐丞丒丈专丞:  (PGCompany.ClanStoreMainUI.丐与上丒丘丝丁丘丑 != 0) ? 1 : 0);
                val_3 = null;
            }
            
            val_3 = null;
            PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙 = 0;
            PGCompany.ClanStoreMainUI.上一与丕丕世业专世 = 0;
            PGCompany.ClanStoreMainUI.丙丛丟丛与专丑丝丈 = 0;
            PGCompany.ClanStoreMainUI.丐与上丒丘丝丁丘丑 = 0;
        }
        public override void HideSelf()
        {
            this.HideSelf();
        }
        public void SetDivisionName()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._divisionLabel, 丕丗丘丑丛与丑业丒:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛()));
            if(this._divisionSprite == 0)
            {
                    return;
            }
            
            this = this._divisionSprite;
            丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this, 万丑丞一丝丌丐丒丘:  System.String.Format(format:  "cup{0}_small", arg0:  (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丑与丏丈丕七丙丂()) + 1.ToString()));
        }
        private void 丛丒丄与丙下丙东丞()
        {
            if(this.丙丆丄世专丕丘上万 != null)
            {
                    CoroutineRunner.Instance.StopCoroutine(routine:  this.丙丆丄世专丕丘上万);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchaseSuccessfullBox, 丏业丟一东丂东丘丛:  true);
            this.丙丆丄世专丕丘上万 = CoroutineRunner.不七丏丝丒一下丄万(丂三丟丂丈丐丆丗丟:  2f, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::下丅丞且上业丄丁丐()));
        }
        public void U_OpenHistoryRewards()
        {
            if(this._reawardHistoryView == 0)
            {
                    return;
            }
            
            this._reawardHistoryView.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.七丈与丄丘丁世丟丆(), 丐丙丈且专丘东七丆:  Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丕丑丏下世丞丁丟东(), 七万不丆丄丙丁且下:  Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丘七丙丅丄丆丅七一());
        }
        public void U_Back()
        {
            this.丑丘万下世丄丁丏丈();
        }
        private void 丑丘万下世丄丁丏丈()
        {
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
        }
        public void U_GoToShop()
        {
            this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  "ClanSilver");
        }
        private void 万丞丌七丈丄丙东万(string 丏丂不专上丘丂不丅)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗);
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛;
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丏丂不专上丘丂不丅, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛);
        }
        private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_6;
            var val_7;
            BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛;
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛);
            丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_5 != null)
            {
                    return;
            }
            
            val_5.丈丛三业丝世世丑丆();
        }
        public void U_RefreshPromotion()
        {
            this.世丛丕东世丅丆丟丈();
        }
        public void U_GoToFortCraft()
        {
            ClanTankBuildController val_10;
            var val_11;
            var val_12;
            if(UnityEngine.SceneManagement.SceneManager.sceneCount < 1)
            {
                goto label_1;
            }
            
            var val_10 = 0;
            label_14:
            UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
            val_10 = val_2.m_Handle.name;
            if((val_10.Equals(value:  "FortFieldBuild", comparisonType:  5)) == true)
            {
                goto label_3;
            }
            
            UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
            val_10 = val_5.m_Handle.name;
            if((val_10.Equals(value:  "ClanTankBuild", comparisonType:  5)) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = ClanTankBuildController.丄丘七三上丕世丞业;
                if(val_10 != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_10 = ClanTankBuildController.丄丘七三上丕世丞业;
                val_10.丂且不业丂专丛丆东();
            }
            
            }
            
            val_10 = val_10 + 1;
            if(val_10 < UnityEngine.SceneManagement.SceneManager.sceneCount)
            {
                goto label_14;
            }
            
            label_1:
            Rilisoft.ClansLobbyGui.丘不丌丈下专丘东七();
            return;
            label_3:
            this.丑丘万下世丄丁丏丈();
        }
        public void U_GoToTankCraft()
        {
            UnityEngine.Object val_16;
            if(UnityEngine.SceneManagement.SceneManager.sceneCount < 1)
            {
                goto label_1;
            }
            
            var val_16 = 0;
            label_24:
            UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
            val_16 = val_2.m_Handle.name;
            if((val_16.Equals(value:  "ClanTankBuild", comparisonType:  5)) == true)
            {
                goto label_3;
            }
            
            UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
            val_16 = val_5.m_Handle.name;
            if((val_16.Equals(value:  "FortFieldBuild", comparisonType:  5)) != false)
            {
                    val_16 = ClanFieldBuildController.丑七不且上丗丁一世();
                if(val_16 != 0)
            {
                    if(ClanFieldBuildController.丑七不且上丗丁一世().丑东业且专丗丕丙丕() != 0)
            {
                    ClanFieldBuildController.丑七不且上丗丁一世().CancelSelectedItem();
            }
            
                FortFieldDecorationItemsController.丏丐丘不丗丙丗与丂.七丞丒专万且丟丞丅();
                val_16 = ClanFieldBuildController.丑七不且上丗丁一世();
                val_16.丕与世万不丒丌三丂();
            }
            
            }
            
            val_16 = val_16 + 1;
            if(val_16 < UnityEngine.SceneManagement.SceneManager.sceneCount)
            {
                goto label_24;
            }
            
            label_1:
            Rilisoft.ClansLobbyGui.东丗丁丂专七丑丞丈();
            return;
            label_3:
            this.丑丘万下世丄丁丏丈();
        }
        public void U_GoToModules()
        {
            var val_11;
            PGCompany.丌不丞丐世丞三丘丌 val_12;
            var val_13;
            this.一且丒丌一丒丛丗三();
            if(UnityEngine.SceneManagement.SceneManager.sceneCount >= 1)
            {
                    val_11 = 0;
                var val_11 = 0;
                do
            {
                UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
                if((val_2.m_Handle.name.Equals(value:  "FortFieldBuild", comparisonType:  5)) != false)
            {
                    val_11 = 1;
            }
            
                UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
                if((val_5.m_Handle.name.Equals(value:  "ClanTankBuild", comparisonType:  5)) != false)
            {
                    val_11 = 1;
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < UnityEngine.SceneManagement.SceneManager.sceneCount);
            
                if((val_11 & 1) != 0)
            {
                    val_12 = 1152921505080860672;
                val_13 = null;
                val_13 = null;
                MainMenuController.下且丄丝丘丝丈上丒 = false;
                MainMenuController.与丝与丄三丅下丒七 = 220000;
                return;
            }
            
            }
            
            PGCompany.丌不丞丐世丞三丘丌 val_9 = null;
            val_12 = val_9;
            val_9 = new PGCompany.丌不丞丐世丞三丘丌();
            if(val_12 != null)
            {
                    .Type = 1;
            }
            else
            {
                    mem[16] = 1;
            }
            
            .ShopCategory = 220000;
            if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_9)) == null)
            {
                    return;
            }
        
        }
        private void 世丛丕东世丅丆丟丈()
        {
            PGCompany.三东丏不丗世丅丌丄 val_10 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丘丂丙万丈丗丒三丐(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕);
            if(val_10 == null)
            {
                    return;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_10 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丘丂丙万丈丗丒三丐(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
            {
                    val_10 = this.业丛与业丆三三丝丕;
                PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().万丌三下丆万丑丌东(丛三丁业丅与丟丛上:  PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世().丗不丞一且丟丈丈丗(丐丅丒专丛丏上与业:  this.业丛与业丆三三丝丕), 丐丅丒专丛丏上与业:  val_10);
                this.丐万丄丄丙三上七东();
                return;
            }
            
            this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  val_10.业上丙丞丐丄丆丅七());
        }
        private void OnDestroy()
        {
            PGCompany.ClanStoreMainUI.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
            丌丅且丗七丘丅丛丑.丈不丄且丐丛与丕丆(丙业与丙丗丝不丈东:  new System.Action<上丑下丆丄下丝东世>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丟丆丘丕丄丕丄三丙(丌丅且丗七丘丅丛丑.上丑下丆丄下丝东世 万且万且丑丗且丌丆)));
            PGCompany.丄且丗且下上七世丂.与丐丅东丛丕不丆丄(丙业与丙丗丝不丈东:  new System.Action<PGCompany.ClanStoreTab>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::且丌东七丒不专丗七(PGCompany.ClanStoreTab 丐丅丒专丛丏上与业)));
            PGCompany.ClanLootBoxController.丟丐东丆丐丄世丛丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丑丌丘丌丁下丂丞()));
            this._selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::丞丂业丗与丟且丐丑()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::上且丆丛业且丞丟业()));
            PGCompany.ClanStoreBuffsController.且三丌丛丛丘丞丏丕(丙业与丙丗丝不丈东:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.ClanStoreMainUI::七丙丏七丘丟上丅丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)));
        }
        public void TurnOn()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return false;
        }
        public bool IsEnabledLobbyCamera()
        {
            return false;
        }
        public float GetDelayTurnOff()
        {
            return 0f;
        }
        private void 上且丆丛业且丞丟业()
        {
            与丂丅三丂且不不与.丑七不且上丗丁一世().三丐七丕丘与丂丑丈();
        }
        private UnityEngine.GameObject 下一丕丆丘丒丕丛丈()
        {
            if(this.丅丙与下丈丗丆丞丅 != 0)
            {
                    return (UnityEngine.GameObject)this.丅丙与下丈丗丆丞丅;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "PurchaseProgressIndicatorClanStore"));
            this.丅丙与下丈丗丆丞丅 = val_3;
            UnityEngine.Transform val_4 = val_3.transform;
            val_4.parent = this.transform;
            val_4.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_4.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_4.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丅丙与下丈丗丆丞丅, 不东丛三丂丌丑专丆:  this.gameObject.layer);
            return (UnityEngine.GameObject)this.丅丙与下丈丗丆丞丅;
        }
        private void 丈丛三业丝世世丑丆()
        {
            null = null;
            MainMenuController.丞丟丂三丝丆丌丌丗 = true;
            丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
        }
        public void U_SetArmorVisible(UIToggle toggle)
        {
            if(toggle == 0)
            {
                    return;
            }
            
            三丐下丁丒丆丘下丄.丏下专丛且丌丌丅三(丙业与丙丗丝不丈东:  toggle.value);
            ShopNGUIController.丙丗丐丁丆不丈上丈(世丟丈丏丕万丝丆万:  this._storeListItemView.丟丑万与丒与不下丛().丟丑万与丒与不下丛(), 下丈丝丁丟下世丐丒:  false);
        }
        public ClanStoreMainUI()
        {
            this.上丅丛业上丛丛世与 = new System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, UnityEngine.MonoBehaviour>();
            this.专万丕丟业丙丞三丐 = new System.Collections.Generic.Dictionary<PGCompany.ClanStoreTab, SelectableButton>();
            this.丙丐丑三世丞丄丂万 = new System.Collections.Generic.List<PGCompany.万丛下丐与丅与丅专>();
            this.且丂丅七三丈丙丈丏 = new System.Collections.Generic.List<PGCompany.万丛下丐与丅与丅专>();
        }
        private static ClanStoreMainUI()
        {
            System.Collections.Generic.List<BankViewTab> val_1 = new System.Collections.Generic.List<BankViewTab>();
            if(val_1 != null)
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  2);
            }
            else
            {
                    val_1.Add(item:  1);
                val_1.Add(item:  2);
            }
            
            val_1.Add(item:  8);
            PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗 = val_1;
            PGCompany.ClanStoreMainUI.丌东丗丁不丐丌下丙 = 0;
            PGCompany.ClanStoreMainUI.上一与丕丕世业专世 = 0;
            PGCompany.ClanStoreMainUI.丙丛丟丛与专丑丝丈 = 0;
            PGCompany.ClanStoreMainUI.丐与上丒丘丝丁丘丑 = 0;
        }
        private void 下丅丞且上业丄丁丐()
        {
            this.丙丆丄世专丕丘上万 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchaseSuccessfullBox, 丏业丟一东丂东丘丛:  false);
        }
    
    }

}
