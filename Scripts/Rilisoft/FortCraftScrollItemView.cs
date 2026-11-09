using UnityEngine;

namespace Rilisoft
{
    public class FortCraftScrollItemView : MonoBehaviour, 丕丂丒丁丏东且一七
    {
        // Fields
        private Rilisoft.FortCraftController 业专万丏丘丙丝一丕;
        private bool 与丛上丌丆七丒丅东;
        private Rilisoft.东且东丒丐世丐丞丒 _item;
        private 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 _slot;
        private UIWidget 与东七丏丆世丟丁丌;
        private bool 丌与丕丞丁业东丌丘;
        private string localKey;
        private UILabel _labelName;
        private UIBasicSprite _texture;
        private Rilisoft.PriceView _btnCraft;
        private Rilisoft.PriceView _btnAskCraft;
        private Rilisoft.PriceView _btnSpeedUp;
        private Rilisoft.PriceView _btnPlace;
        private Rilisoft.PriceView _btnRemove;
        private Rilisoft.PriceView _btnBuy;
        private Rilisoft.PriceView _labelPrice;
        private FortCraftDetailsController _labelPartPrice;
        private UnityEngine.GameObject _indicatorSelected;
        private UnityEngine.GameObject _indicatorBought;
        private UnityEngine.GameObject _indicatorLocked;
        private UILabel _indicatorLockedLabel;
        private UILabel _labelPlaced;
        private UILabel _labelCrafting;
        private UILabel _labelCraftTimer;
        private UnityEngine.GameObject _objNew;
        private UnityEngine.GameObject _objBuffDescription;
        private Rilisoft.TextGroup _labelBuffDescription;
        private UILabel _craftTimeLabel;
        private UnityEngine.GameObject _lockerObject;
        private UISprite _lockerSprite;
        private UILabel _lockerPointsLabel;
        private bool <丝专丘不丌丟东丗丝>k__BackingField;
        private bool <不丁丝丈丙丄丂丐下>k__BackingField;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        private UIWidget 丕丟丟丝丝丞七且下 { get; }
        public Rilisoft.东且东丒丐世丐丞丒 东且东丒丐世丐丞丒 { get; }
        public 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丙丕丈一一丝丑七丈 { get; }
        public bool 丟七一丏丈丒丘丝世 { get; set; }
        public bool 且丗丈丈世丐丐万七 { get; set; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        private UIWidget 丁丏世七三丗与丏与()
        {
            UIWidget val_3;
            if(this.与东七丏丆世丟丁丌 == 0)
            {
                    this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
                return val_3;
            }
            
            val_3 = this.与东七丏丆世丟丁丌;
            return val_3;
        }
        private void OnEnable()
        {
            this._btnCraft.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::与丈丘不七三东丅万()));
            this._btnAskCraft.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::业丆业丈一丐丗丝丆()));
            this._btnSpeedUp.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丑丙丑且丐专丞东东()));
            this._btnPlace.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::一一丞丂丕一与一不()));
            this._btnRemove.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丅丐丟与丟业丘世丆()));
            this._btnBuy.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丒上上丘与三丘丁丁()));
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
            if(this.丌与丕丞丁业东丌丘 != false)
            {
                    this.丗丄万丏丟丘与丙丟();
                this.丌与丕丞丁业东丌丘 = false;
            }
            
            this.丌与丕丞丁业东丌丘 = false;
        }
        private void OnDisable()
        {
            this._btnCraft.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::与丈丘不七三东丅万()));
            this._btnAskCraft.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::业丆业丈一丐丗丝丆()));
            this._btnSpeedUp.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丑丙丑且丐专丞东东()));
            this._btnPlace.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::一一丞丂丕一与一不()));
            this._btnRemove.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丅丐丟与丟业丘世丆()));
            this._btnBuy.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丒上上丘与三丘丁丁()));
            this.StopCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new FortCraftScrollItemView.东世专丄丆丑丑丑丆();
        }
        private void OnClick()
        {
            var val_4;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    return;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.SelectItemOnScrollRequest(丂三七下丗且丌上一:  this._item, 与丄不丌一世东丁丙:  this._slot, 与七丁与丌丒丝专一:  true);
        }
        private void 业丆业丈一丐丗丝丆()
        {
            this._btnAskCraft.gameObject.SetActive(value:  false);
            PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丌丙丆丛丏一丛业丈().与丒丞且万丁丕丄专(丄丒且丙三丆丟与丏:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丏丌丟丂丌一七与(), 丞一丁业丄一一业且:  this._item.业上丙丞丐丄丆丅七(), 万万丛丒丑丁丙业丑:  专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  ProfileController.丆三丂丂丆上丆丕专()));
            this.UpdateView();
            this.UpdateView();
        }
        private void 与丈丘不七三东丅万()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    LoadingButton val_4 = this._btnCraft.GetComponent<LoadingButton>();
                if(val_4 == 0)
            {
                    return;
            }
            
                val_4.Pressed = false;
                return;
            }
            
            }
            
            PGCompany.Clans.Network.三与丞不下丆且丑世.丟专丐丄丒丘丈与万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丌上丕丈丛丝三且七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::不丅丕丆丐丕世丄丗()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.专业丛万丝丙东丒丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丈且丗丞丕世且丁丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::不丅丕丆丐丕世丄丗()));
            this.业专万丏丘丙丝一丕.CraftRequest(丁世丛业丟下丕三丟:  this);
        }
        private void 丑丙丑且丐专丞东东()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    LoadingButton val_4 = this._btnSpeedUp.GetComponent<LoadingButton>();
                if(val_4 == 0)
            {
                    return;
            }
            
                val_4.Pressed = false;
                return;
            }
            
            }
            
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丌上丕丈丛丝三且七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::不丅丕丆丐丕世丄丗()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.专业丛万丝丙东丒丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丈且丗丞丕世且丁丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            BankController.丅七丕下丏专上世丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::不丅丕丆丐丕世丄丗()));
            this.业专万丏丘丙丝一丕.SpeedUpRequest(丁世丛业丟下丕三丟:  this);
        }
        private void 一一丞丂丕一与一不()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    LoadingButton val_4 = this._btnPlace.GetComponent<LoadingButton>();
                if(val_4 == 0)
            {
                    return;
            }
            
                val_4.Pressed = false;
                return;
            }
            
            }
            
            PGCompany.Clans.Network.三与丞不下丆且丑世.下丞世丏丐上丑专丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丈且丗丞丕世且丁丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            this.业专万丏丘丙丝一丕.PlaceRequest(丁世丛业丟下丕三丟:  this);
        }
        private void 丅丐丟与丟业丘世丆()
        {
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    LoadingButton val_4 = this._btnRemove.GetComponent<LoadingButton>();
                if(val_4 == 0)
            {
                    return;
            }
            
                val_4.Pressed = false;
                return;
            }
            
            }
            
            PGCompany.Clans.Network.三与丞不下丆且丑世.下丞世丏丐上丑专丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丈且丗丞丕世且丁丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            this.业专万丏丘丙丝一丕.RemoveRequest(丁世丛业丟下丕三丟:  this);
        }
        private void 丒上上丘与三丘丁丁()
        {
            var val_23;
            UnityEngine.Object val_24;
            var val_25;
            var val_26;
            var val_27;
            val_23 = 1152921524473519280;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 != false)
            {
                    val_24 = this._btnBuy.GetComponent<LoadingButton>();
                if(val_24 == 0)
            {
                    return;
            }
            
                val_24.Pressed = false;
                return;
            }
            
            }
            
            int val_9 = this._item.丝丗丑万万丗不丙丁() + 1;
            val_9 = val_9 * this._item.三丐丟丒业丞东三丕();
            if(this._item.丗三三丐丁东丘丌一() >= val_9)
            {
                goto label_14;
            }
            
            val_23 = 1152921524404748272;
            if(((Rilisoft.Singleton<ClansController>.Instance) == 0) || ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
            {
                goto label_19;
            }
            
            .丝且与丝丒丟万丁专 = this;
            .丞丒业万东专上丒丛 = 0;
            System.Action<System.Boolean> val_17 = new System.Action<System.Boolean>(object:  new FortCraftScrollItemView.丒业丛丟专丛丒与东(), method:  System.Void FortCraftScrollItemView.丒业丛丟专丛丒与东::丂丁丑不丄东不丁专(bool 丏业丟一东丂东丘丛));
            .丞丒业万东专上丒丛 = val_17;
            Rilisoft.BuySpecialCurrenciesWindowBase.add_OnVisibleStateChanged(丙业与丙丗丝不丈东:  val_17);
            val_25 = null;
            val_25 = null;
            bool val_21 = Rilisoft.BuyCraftDetailsWindow.下与丞三丅丛丄七丕(一丟丄丞不丕丟丌丟:  Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.gameObject.transform, 丕丁下丌不万丅丞丛:  this._item.业上丙丞丐丄丆丅七(), 丕丌专世丌丂上丒丆:  BalanceController.丕丙丛且丏三上不丛(丆万一不丌且东丐丐:  this._item.业上丙丞丐丄丆丅七(), 万业丁七与丟丁东与:  false), 与丄不丌一世东丁丙:  0, 下丗丁丒丘东丂不丑:  1);
            return;
            label_14:
            this.UpdateView();
            return;
            label_19:
            val_26 = null;
            val_26 = null;
            val_24 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            if(val_24 == 0)
            {
                    return;
            }
            
            val_27 = null;
            val_27 = null;
            Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.U_BackButtonAction();
        }
        private void 不丅丕丆丐丕世丄丗()
        {
            this.丌与丕丞丁业东丌丘 = true;
        }
        private void 丆下丗丏三一不丒七()
        {
            if((this._btnCraft != 0) && (this._btnCraft.gameObject.activeInHierarchy != false))
            {
                    LoadingButton val_4 = this._btnCraft.GetComponent<LoadingButton>();
                if(val_4 != 0)
            {
                    val_4.Pressed = false;
            }
            
            }
            
            if((this._btnPlace != 0) && (this._btnPlace.gameObject.activeInHierarchy != false))
            {
                    LoadingButton val_9 = this._btnPlace.GetComponent<LoadingButton>();
                if(val_9 != 0)
            {
                    val_9.Pressed = false;
            }
            
            }
            
            if((this._btnRemove != 0) && (this._btnRemove.gameObject.activeInHierarchy != false))
            {
                    LoadingButton val_14 = this._btnRemove.GetComponent<LoadingButton>();
                if(val_14 != 0)
            {
                    val_14.Pressed = false;
            }
            
            }
            
            if((this._btnSpeedUp != 0) && (this._btnSpeedUp.gameObject.activeInHierarchy != false))
            {
                    LoadingButton val_19 = this._btnSpeedUp.GetComponent<LoadingButton>();
                if(val_19 != 0)
            {
                    val_19.Pressed = false;
            }
            
            }
            
            if(this._btnBuy == 0)
            {
                    return;
            }
            
            if(this._btnBuy.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this = this._btnBuy.GetComponent<LoadingButton>();
            if(this == 0)
            {
                    return;
            }
            
            this.Pressed = false;
        }
        private void 丗丄万丏丟丘与丙丟()
        {
            this.丆下丗丏三一不丒七();
            PGCompany.Clans.Network.三与丞不下丆且丑世.丟专丐丄丒丘丈与万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            PGCompany.Clans.Network.与丕丗丒丄东丌丂丄.丄三丐上丈且丄丘下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            Rilisoft.FortCraftController.丌上丕丈丛丝三且七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::丗丄万丏丟丘与丙丟()));
            BankController.业丅丐与丗三七一且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::不丅丕丆丐丕世丄丗()));
        }
        private void 一丅万三丛不七丝丞()
        {
        
        }
        public Rilisoft.东且东丒丐世丐丞丒 get_FortItem()
        {
            return (Rilisoft.东且东丒丐世丐丞丒)this._item;
        }
        public 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 get_Slot()
        {
            return (丗丞丏丙七丑丕且丐)this._slot;
        }
        public bool get_IsSelected()
        {
            return (bool)this.<丝专丘不丌丟东丗丝>k__BackingField;
        }
        public void set_IsSelected(bool 丙业与丙丗丝不丈东)
        {
            this.<丝专丘不丌丟东丗丝>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsCrafting()
        {
            return (bool)this.<不丁丝丈丙丄丂丐下>k__BackingField;
        }
        public void set_IsCrafting(bool 丙业与丙丗丝不丈东)
        {
            this.<不丁丝丈丙丄丂丐下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.FortCraftController 丒专丈丛下丒一丒丛, Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 不丝丄丒丌丐一一与)
        {
            if(this._item != null)
            {
                    this._item.丒且丆世专业丁三丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::世丈丂丛丞丞丘不万()));
            }
            
            this.业专万丏丘丙丝一丕 = 丒专丈丛下丒一丒丛;
            this._item = 下丅丙一丂丗丅丝七;
            this._slot = 不丝丄丒丌丐一一与;
            if(下丅丙一丂丗丅丝七 != null)
            {
                    下丅丙一丂丗丅丝七.丏上不丐丂丆丗三业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.FortCraftScrollItemView::世丈丂丛丞丞丘不万()));
            }
            
            this.gameObject.transform.SetParent(p:  七万上丐一丈丏丏专);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.gameObject.SetActive(value:  true);
        }
        private void 世丈丂丛丞丞丘不万()
        {
            this.UpdateView();
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
            this.gameObject.transform.SetParent(p:  this.业专万丏丘丙丝一丕.gameObject.transform);
            this.<丝专丘不丌丟东丗丝>k__BackingField = false;
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            if(东丗七丕丄不丐专丒 != false)
            {
                    return;
            }
            
            this.UpdateView();
        }
        public void UpdateView()
        {
            object val_201;
            丗丞丏丙七丑丕且丐 val_202;
            var val_203;
            var val_204;
            string val_205;
            var val_206;
            var val_207;
            var val_208;
            Rilisoft.PriceView val_209;
            var val_210;
            var val_211;
            UILabel val_212;
            var val_214;
            var val_215;
            var val_216;
            UnityEngine.GameObject val_217;
            var val_218;
            val_201 = this;
            if(this._item == null)
            {
                    return;
            }
            
            this.与丛上丌丆七丒丅东 = this._item.丘丘丒丝一业丐丛不();
            if(this._labelName != 0)
            {
                    this._labelName.text = this._item.丙丕丞且丕不丘丙丑().东丙上东业丆不丟丘();
            }
            
            if(this.丆下世世丟七专丞丒() != 0)
            {
                    if((System.String.op_Inequality(a:  this.丆下世世丟七专丞丒().name, b:  this._item.丆丗丒丌且专丒丘七())) == false)
            {
                goto label_15;
            }
            
            }
            
            UIBasicSprite val_12 = this.丆下世世丟七专丞丒();
            UnityEngine.Texture val_14 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this._item.丙三专万丛丟万丝丘());
            label_15:
            this.丆下丗丏三一不丒七();
            if(this._btnAskCraft != 0)
            {
                    this._btnAskCraft.gameObject.SetActive(value:  false);
            }
            
            if(this._btnBuy != 0)
            {
                    this._btnBuy.gameObject.SetActive(value:  false);
            }
            
            if(this._btnSpeedUp != 0)
            {
                    this._btnSpeedUp.gameObject.SetActive(value:  false);
            }
            
            if(this._btnPlace != 0)
            {
                    this._btnPlace.gameObject.SetActive(value:  false);
            }
            
            if(this._btnRemove != 0)
            {
                    this._btnRemove.gameObject.SetActive(value:  false);
            }
            
            if(this._indicatorBought != 0)
            {
                    this._indicatorBought.SetActive(value:  false);
            }
            
            if(this._indicatorLocked != 0)
            {
                    this._indicatorLocked.SetActive(value:  false);
            }
            
            if(this._labelPrice != 0)
            {
                    this._labelPrice.gameObject.SetActive(value:  false);
            }
            
            if(this._labelPartPrice != 0)
            {
                    this._labelPartPrice.gameObject.SetActive(value:  false);
            }
            
            if(this._labelPlaced != 0)
            {
                    this._labelPlaced.gameObject.SetActive(value:  false);
            }
            
            if(this._labelCraftTimer != 0)
            {
                    this._labelCraftTimer.gameObject.SetActive(value:  false);
            }
            
            if(this._craftTimeLabel != 0)
            {
                    this._craftTimeLabel.gameObject.SetActive(value:  false);
            }
            
            if(this._lockerObject != 0)
            {
                    this._lockerObject.SetActive(value:  false);
            }
            
            if(this._labelCrafting != 0)
            {
                    this._labelCrafting.gameObject.SetActive(value:  false);
            }
            
            if(this._labelPartPrice != 0)
            {
                    this._labelPartPrice.gameObject.SetActive(value:  true);
            }
            
            if(this._labelPartPrice != 0)
            {
                    this._labelPartPrice.SetPrice(下丅丙一丂丗丅丝七:  this._item);
            }
            
            if(this._objNew != 0)
            {
                    this._objNew.SetActive(value:  false);
            }
            
            if(this._indicatorSelected != 0)
            {
                    丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._indicatorSelected, 丏业丟一东丂东丘丛:  ((this.<丝专丘不丌丟东丗丝>k__BackingField) == true) ? 1 : 0);
            }
            
            if(this._btnCraft != 0)
            {
                    this._btnCraft.gameObject.SetActive(value:  false);
            }
            
            if(ExpController.丑七不且上丗丁一世() != 0)
            {
                    if(this._item.丙丕丞且丕不丘丙丑().丈一下下丞世三丑丄() > ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂())
            {
                    if(this._item.且丅一一三七专丑丏() == false)
            {
                goto label_120;
            }
            
            }
            
            }
            
            this._objNew.SetActive(value:  (this.与丛上丌丆七丒丅东 == true) ? 1 : 0);
            if(this._item.且丅一一三七专丑丏() == false)
            {
                goto label_132;
            }
            
            if(this._item.丑丆丑三且丛上且丟() == false)
            {
                goto label_134;
            }
            
            if((this._item.丑丆丑三且丛上且丟() == false) || ((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) == 0))
            {
                goto label_132;
            }
            
            val_202 = this._slot;
            Rilisoft.FortsManager val_61 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            if(val_202 != (val_61.<丛丄七丟丈丆丒丆丈>k__BackingField))
            {
                goto label_134;
            }
            
            label_132:
            if(this._item.丑丆丑三且丛上且丟() == false)
            {
                goto label_136;
            }
            
            val_203 = null;
            val_203 = null;
            if((Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != 1)
            {
                goto label_141;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._btnSpeedUp.gameObject, 丏业丟一东丂东丘丛:  true);
            this._btnSpeedUp.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  this._item.且丕三丙七且且东下(), 万丐丁三且下丞丈丌:  0);
            goto label_147;
            label_136:
            if(this._item.丏丕丂且上上下丏七() == false)
            {
                goto label_149;
            }
            
            val_204 = null;
            val_204 = null;
            val_205 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) != false)
            {
                    val_205 = this._item.丗三三丐丁东丘丌一();
                val_202 = this._item;
                if((Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_205)) == 1)
            {
                    int val_75 = val_202.丝丗丑万万丗不丙丁() + 1;
                val_75 = val_75 * this._item.三丐丟丒业丞东三丕();
                if(val_205 >= val_75)
            {
                    if((this._item.丁丞一不不丗丕丟丛().Contains(item:  1023)) == false)
            {
                goto label_162;
            }
            
            }
            
            }
            
            }
            
            if(this._btnAskCraft == 0)
            {
                goto label_182;
            }
            
            val_206 = null;
            val_206 = null;
            val_205 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().丁丏丌丟丂丌一七与();
            if((PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丌丙丆丛丏一丛业丈().与丛且与上业丅与业(丄丒且丙三丆丟与丏:  val_205)) == false)
            {
                goto label_182;
            }
            
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_355;
            }
            
            val_205 = this._item.三丐丟丒业丞东三丕();
            int val_87 = this._item.丝丗丑万万丗不丙丁() + 1;
            val_87 = val_87 * val_205;
            if(this._item.丗三三丐丁东丘丌一() >= val_87)
            {
                    val_207 = null;
                val_207 = null;
                if((System.String.op_Inequality(a:  Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().丁丏丌丟丂丌一七与(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    if((this._item.丁丞一不不丗丕丟丛().Contains(item:  1023)) == false)
            {
                goto label_185;
            }
            
            }
            
            }
            
            label_182:
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_355;
            }
            
            val_205 = this._item.三丐丟丒业丞东三丕();
            int val_97 = this._item.丝丗丑万万丗不丙丁() + 1;
            val_97 = val_97 * val_205;
            if((this._item.丗三三丐丁东丘丌一() >= val_97) || ((this._item.丁丞一不不丗丕丟丛().Contains(item:  1023)) == true))
            {
                goto label_355;
            }
            
            if(this._btnBuy != null)
            {
                goto label_392;
            }
            
            label_393:
            label_392:
            this._btnBuy.gameObject.SetActive(value:  true);
            goto label_196;
            label_134:
            if((this._item.丛三上业丑东丅丐世() == false) || ((System.Linq.Enumerable.Any<System.String>(source:  this._item.丄丁世万一上丌且万(), predicate:  new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.FortCraftScrollItemView::丑且一丛下丛丑世丁(string 三丟东丕丄丄下下丑)))) == false))
            {
                goto label_200;
            }
            
            val_208 = null;
            val_208 = null;
            val_205 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_208;
            }
            
            val_205 = this._item;
            if((((Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_205)) - 1) > 1) || (val_205.丙丄丝丕丏世丏丛丑() == true))
            {
                goto label_208;
            }
            
            val_209 = this._btnRemove;
            if(val_209 != null)
            {
                goto label_351;
            }
            
            goto label_352;
            label_200:
            val_202 = 1152921505448005632;
            val_210 = null;
            val_210 = null;
            val_205 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if(((this.<丝专丘不丌丟东丗丝>k__BackingField) == false) || (((Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_205)) - 1) > 1))
            {
                goto label_216;
            }
            
            if(this._item.丄丁世万一上丌且万() == null)
            {
                goto label_218;
            }
            
            val_205 = this._item.丄丁世万一上丌且万();
            if(this._item.丝丗丑万万丗不丙丁() > val_205.Count)
            {
                goto label_227;
            }
            
            label_218:
            if(this._item.丄丁世万一上丌且万() == null)
            {
                goto label_224;
            }
            
            label_343:
            if((Rilisoft.FortsManager.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  this._item)) == true)
            {
                goto label_227;
            }
            
            val_205 = this._item;
            if(this._item.丝丗丑万万丗不丙丁() >= val_205.丄且丞且且且世丂丅())
            {
                goto label_350;
            }
            
            int val_125 = this._item.丝丗丑万万丗不丙丁() + 1;
            val_125 = val_125 * this._item.三丐丟丒业丞东三丕();
            if((this._item.丗三三丐丁东丘丌一() < val_125) || (this._item.丑丆丑三且丛上且丟() == true))
            {
                goto label_311;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._btnCraft.gameObject, 丏业丟一东丂东丘丛:  true);
            val_205 = this._item.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            this._btnCraft.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_205, 万丐丁三且下丞丈丌:  0);
            goto label_347;
            label_141:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._labelCrafting.gameObject, 丏业丟一东丂东丘丛:  true);
            label_147:
            this._labelPartPrice.gameObject.SetActive(value:  false);
            val_211 = null;
            System.Nullable<System.Int64> val_132 = Rilisoft.FortsManager.丅丘七世上丘且丗不();
            val_205 = this._labelCraftTimer.gameObject;
            if(val_205 == null)
            {
                goto label_252;
            }
            
            if(( & 1) == 0)
            {
                goto label_253;
            }
            
            label_271:
            val_205.SetActive(value:  true);
            val_212 = this._labelCraftTimer;
            string val_135 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this._item.下丞丘丏丂丕丄丐丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            goto label_257;
            label_149:
            this._lockerObject.SetActive(value:  true);
            Rilisoft.丆一一东丞三丞东世 val_137 = this._item.不丑三丌丈丞丈一丆().Item[0];
            if(val_137 == null)
            {
                goto label_261;
            }
            
            val_214 = val_137.丆丕丑丈三丙丁丗丈();
            goto label_262;
            label_120:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._indicatorLocked, 丏业丟一东丂东丘丛:  true);
            val_212 = this._indicatorLockedLabel;
            label_257:
            val_205 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3297"), arg0:  this._item.丙丕丞且丕不丘丙丑().丈一下下丞世三丑丄());
            val_212.text = val_205;
            goto label_350;
            label_252:
            if(( & 1) != 0)
            {
                goto label_271;
            }
            
            label_253:
            val_205.SetActive(value:  false);
            LoadingButton val_143 = this._btnSpeedUp.GetComponent<LoadingButton>();
            if(val_143 == 0)
            {
                goto label_350;
            }
            
            val_143.Pressed = true;
            goto label_350;
            label_216:
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_283;
            }
            
            val_215 = null;
            val_215 = null;
            if((System.String.op_Inequality(a:  Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().丁丏丌丟丂丌一七与(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                goto label_283;
            }
            
            if(this._item.丄丁世万一上丌且万() == null)
            {
                goto label_285;
            }
            
            val_205 = this._item.丄丁世万一上丌且万();
            if(this._item.丝丗丑万万丗不丙丁() > val_205.Count)
            {
                goto label_294;
            }
            
            label_285:
            if(this._item.丄丁世万一上丌且万() == null)
            {
                goto label_291;
            }
            
            label_357:
            if((Rilisoft.FortsManager.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  this._item)) == true)
            {
                goto label_294;
            }
            
            val_205 = this._item;
            if(this._item.丝丗丑万万丗不丙丁() >= val_205.丄且丞且且且世丂丅())
            {
                goto label_350;
            }
            
            if(this._btnAskCraft == 0)
            {
                goto label_311;
            }
            
            int val_161 = this._item.丝丗丑万万丗不丙丁() + 1;
            val_161 = val_161 * this._item.三丐丟丒业丞东三丕();
            if(this._item.丗三三丐丁东丘丌一() < val_161)
            {
                goto label_311;
            }
            
            val_216 = null;
            val_216 = null;
            val_205 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗.业三丐丐三丒丙上万().丁丏丌丟丂丌一七与();
            if((PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丌丙丆丛丏一丛业丈().与丛且与上业丅与业(丄丒且丙三丆丟与丏:  val_205)) == false)
            {
                goto label_311;
            }
            
            val_209 = this._btnAskCraft;
            if(val_209 != null)
            {
                goto label_351;
            }
            
            goto label_352;
            label_283:
            if(this._item.丄丁世万一上丌且万() == null)
            {
                goto label_315;
            }
            
            val_205 = this._item.丄丁世万一上丌且万();
            if(this._item.丝丗丑万万丗不丙丁() > val_205.Count)
            {
                goto label_354;
            }
            
            label_315:
            if((Rilisoft.FortsManager.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  this._item)) == false)
            {
                goto label_322;
            }
            
            label_354:
            val_217 = this._indicatorBought;
            val_218 = null;
            goto label_325;
            label_261:
            val_214 = val_137.丆丕丑丈三丙丁丗丈();
            label_262:
            val_202 = val_137.丗万丆丟丙不与三丌();
            float val_201 = (float)val_214;
            val_201 = val_201 / (float)val_202;
            val_201 = 1f - val_201;
            this._lockerSprite.fillAmount = val_201;
            val_205 = this._lockerPointsLabel;
            val_205.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_137.丂丝丅丗丟一丑下与()), arg0:  val_137.东丑专丟丅丄业丆丁());
            goto label_355;
            label_208:
            UnityEngine.GameObject val_178 = this._labelPlaced.gameObject;
            goto label_334;
            label_162:
            this._btnCraft.gameObject.SetActive(value:  true);
            val_205 = this._item.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            this._btnCraft.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_205, 万丐丁三且下丞丈丌:  0);
            label_196:
            this._labelPartPrice.HidePrice();
            goto label_355;
            label_224:
            if(this._item.丝丗丑万万丗不丙丁() <= 0)
            {
                goto label_343;
            }
            
            label_227:
            val_209 = this._btnPlace;
            if(val_209 != null)
            {
                goto label_351;
            }
            
            label_352:
            label_351:
            val_217 = val_209.gameObject;
            val_218 = null;
            label_325:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_217, 丏业丟一东丂东丘丛:  true);
            goto label_347;
            label_322:
            if(this._item.丄丁世万一上丌且万() == null)
            {
                goto label_349;
            }
            
            label_355:
            this.三丆丏丈丌上丏与丝();
            goto label_350;
            label_311:
            if(this._btnBuy != null)
            {
                goto label_351;
            }
            
            goto label_352;
            label_349:
            if(this._item.丝丗丑万万丗不丙丁() >= 1)
            {
                goto label_354;
            }
            
            goto label_355;
            label_291:
            if(this._item.丝丗丑万万丗不丙丁() <= 0)
            {
                goto label_357;
            }
            
            label_294:
            label_334:
            this._indicatorBought.gameObject.SetActive(value:  true);
            label_347:
            this._labelPartPrice.HidePrice();
            label_350:
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_361;
            }
            
            string val_188 = this._item.世丛丐丕丗七一丞一();
            bool val_189 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_188);
            val_205 = this._objBuffDescription;
            if(val_205 == null)
            {
                goto label_365;
            }
            
            if(val_189 == false)
            {
                goto label_366;
            }
            
            goto label_367;
            label_361:
            val_201 = this._objBuffDescription;
            label_367:
            val_201.SetActive(value:  false);
            return;
            label_365:
            if(val_189 == true)
            {
                goto label_367;
            }
            
            label_366:
            val_205.SetActive(value:  true);
            val_205 = this._item.丙丕丞且丕不丘丙丑();
            if(val_205.丞一下丐丟丏下丅万() == null)
            {
                goto label_378;
            }
            
            val_205 = this._item.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万();
            if(val_205[0] == null)
            {
                goto label_378;
            }
            
            val_205 = this._item.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
            val_201 = this._labelBuffDescription;
            string val_198 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_188.Trim()), arg0:  val_195[0].Value);
            goto label_387;
            label_378:
            val_201 = this._labelBuffDescription;
            label_387:
            val_201.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_188.Trim());
            return;
            label_185:
            if(this._btnAskCraft != null)
            {
                goto label_392;
            }
            
            goto label_393;
        }
        private void 三丆丏丈丌上丏与丝()
        {
            UILabel val_15;
            int val_16;
            UnityEngine.GameObject val_17;
            string val_18;
            val_15 = this;
            val_16 = System.String.alignConst;
            val_17 = this._item.丅丞上丘丆下上丘丅();
            System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)val_17);
            if(val_2._ticks.Days < 1)
            {
                goto label_4;
            }
            
            val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2913");
            int val_5 = val_2._ticks.Days;
            goto label_11;
            label_4:
            if(val_2._ticks.Hours < 1)
            {
                goto label_8;
            }
            
            val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2917");
            int val_8 = val_2._ticks.Hours;
            goto label_11;
            label_8:
            if(val_2._ticks.Minutes < 1)
            {
                goto label_12;
            }
            
            val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2918");
            label_11:
            val_16 = System.String.Format(format:  val_18, arg0:  val_2._ticks.Minutes);
            label_12:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) == true)
            {
                    return;
            }
            
            val_17 = this._craftTimeLabel.gameObject;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  true);
            val_15 = this._craftTimeLabel;
            val_15.text = val_16;
        }
        public void Kill(bool 不丟一丄丁丆丅上丒)
        {
            this.gameObject.transform.SetParent(p:  this.业专万丏丘丙丝一丕.gameObject.transform);
            this.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public void Kill()
        {
            this.gameObject.transform.SetParent(p:  this.业专万丏丘丙丝一丕.gameObject.transform);
            this.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public FortCraftScrollItemView()
        {
            this.localKey = "Key_4023";
        }
        private bool 丑且一丛下丛丑世丁(string 三丟东丕丄丄下下丑)
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑, b:  this._slot.ToString());
        }
    
    }

}
