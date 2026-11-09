using UnityEngine;
internal sealed class PreviewOfferPackController : PGBehaviour
{
    // Fields
    private static System.Action<System.Collections.Generic.List<Rilisoft.OfferItem>> 丞丟丒丈丆下丄一丞;
    private static System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丄与专上万且丕丏三;
    private PGCompany.InventoryItemView _inventoryItemView;
    private UILabel _purchaseLabel;
    private bool 丘万丌东丁万丕业业;
    private bool 丑与七不七丟丂与东;
    private bool 上一丗东丅丂上丂世;
    private bool 上丆丞丄丄丛丘丝三;
    private System.Action 丛丄业丘不丆丄三丞;
    private Rilisoft.业丙丘丆东丈丕丂丄 上世丗三丝三七万丛;
    private PGCompany.东丑丆丗丏丐丟下丄 与丐不业丑丗丌业下;
    private System.IDisposable 东三世丝丒三一丈丛;
    
    // Methods
    internal static void 与丐丁丕丒丁上丄丏(System.Action<System.Collections.Generic.List<Rilisoft.OfferItem>> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PreviewOfferPackController.丞丟丒丈丆下丄一丞, b:  丙业与丙丗丝不丈东);
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
    internal static void 丂丙丏丏七不世丈丅(System.Action<System.Collections.Generic.List<Rilisoft.OfferItem>> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PreviewOfferPackController.丞丟丒丈丆下丄一丞, value:  丙业与丙丗丝不丈东);
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
    internal static void 丏与上丘丌与三与世(System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PreviewOfferPackController.丄与专上万且丕丏三, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PreviewOfferPackController.丄与专上万且丕丏三 != 1152921505238585352);
    
    }
    internal static void 丙丞下上且一下丒丝(System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PreviewOfferPackController.丄与专上万且丕丏三, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PreviewOfferPackController.丄与专上万且丕丏三 != 1152921505238585352);
    
    }
    internal void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丄业丘不丆丄三丞 != 1152921538503022960);
    
    }
    internal void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丄业丘不丆丄三丞 != 1152921538503159536);
    
    }
    private void OnEnable()
    {
        this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PreviewOfferPackController::U_Hide()), 与且专丈不万东一万:  "PreviewOfferPackController_" + this.gameObject.name);
    }
    private void OnDisable()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.东三世丝丒三一丈丛.Dispose();
    }
    internal void 业东丑丅丆三丕丏一(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
    {
        UILabel val_25;
        string val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_25 = this;
        val_26 = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
        if((System.String.op_Inequality(a:  val_26, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        this.与丐不业丑丗丌业下 = 丐丆丝业丙丈下世丁;
        this.gameObject.SetActive(value:  true);
        this.丘万丌东丁万丕业业 = true;
        this.丑与七不七丟丂与东 = MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled;
        MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = true;
        val_27 = null;
        val_27 = null;
        this.上丆丞丄丄丛丘丝三 = activeSelf;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.ActiveObject, 丏业丟一东丂东丘丛:  false);
        val_28 = null;
        val_28 = null;
        this.上一丗东丅丂上丂世 = gameObject.activeSelf;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  true);
        this._inventoryItemView.Setup(丈丄不七三万丄丁不:  丐丆丝业丙丈下世丁);
        val_26 = 丐丆丝业丙丈下世丁.丁世丈丛丘七七专专(上丙且丙丏万丄上业:  丐丆丝业丙丈下世丁);
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_29 = null;
            val_29 = null;
            if((丐丆丝业丙丈下世丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  且丙丙丈丙丄丌丌不.丁世丟丄丑不且一下)) != false)
        {
                val_30 = null;
            val_30 = null;
            if((val_26.Contains(item:  且丙丙丈丙丄丌丌不.七丈上世丄丐丛下七)) != true)
        {
                val_31 = null;
            val_31 = null;
            val_26.Add(item:  且丙丙丈丙丄丌丌不.七丈上世丄丐丛下七);
        }
        
        }
        
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.与丅丒丝七丛丑丅丞(与丝东万丙丞丝丟七:  val_26, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  true);
        }
        
        val_25 = this._purchaseLabel;
        val_32 = null;
        val_32 = null;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_25, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  且丙丙丈丙丄丌丌不.丁丌与七丙丄丞业丗), arg0:  val_26.Count));
    }
    internal void 业东丑丅丆三丕丏一(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗)
    {
        UILabel val_31;
        string val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        val_31 = this;
        val_32 = 东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗();
        if((System.String.op_Inequality(a:  val_32, b:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        this.上世丗三丝三七万丛 = 不专一业下丞丝丑丗;
        this.gameObject.SetActive(value:  true);
        this.丘万丌东丁万丕业业 = true;
        this.丑与七不七丟丂与东 = MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled;
        MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = true;
        val_33 = null;
        val_33 = null;
        this.上一丗东丅丂上丂世 = gameObject.activeSelf;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  true);
        val_34 = null;
        val_34 = null;
        this.上丆丞丄丄丛丘丝三 = activeSelf;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.ActiveObject, 丏业丟一东丂东丘丛:  false);
        PGCompany.三东丏不丗世丅丌丄 val_19 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  不专一业下丞丝丑丗.丟丂丞不专丆万丒世().东与三丌丅三丒丏业());
        val_19.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  不专一业下丞丝丑丗.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世());
        this._inventoryItemView.Setup(丈丄不七三万丄丁不:  val_19);
        Rilisoft.七丈业与与不七丈丟 val_22 = 不专一业下丞丝丑丗.丁专丗万三上丟三丆();
        val_32 = this.丁世丈丛丘七七专专(丞丑丘丂不不丝丈丞:  val_22.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业);
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                Rilisoft.七丈业与与不七丈丟 val_25 = 不专一业下丞丝丑丗.丁专丗万三上丟三丆();
            val_35 = null;
            val_35 = null;
            if((val_25.丒上一丁丆丛东专丙.下丄丈不与世丐业专.Equals(value:  且丙丙丈丙丄丌丌不.丁世丟丄丑不且一下)) != false)
        {
                val_36 = null;
            val_36 = null;
            if((val_32.Contains(item:  且丙丙丈丙丄丌丌不.七丈上世丄丐丛下七)) != true)
        {
                val_37 = null;
            val_37 = null;
            val_32.Add(item:  且丙丙丈丙丄丌丌不.七丈上世丄丐丛下七);
        }
        
        }
        
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.与丅丒丝七丛丑丅丞(与丝东万丙丞丝丟七:  val_32, 丒丞丐丘且不且丟东:  false, 丆且丌丟丅一丙东丁:  true);
        }
        
        val_31 = this._purchaseLabel;
        val_38 = null;
        val_38 = null;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_31, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  且丙丙丈丙丄丌丌不.丁丌与七丙丄丞业丗), arg0:  val_32.Count));
    }
    private System.Collections.Generic.List<string> 丁世丈丛丘七七专专(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上丙且丙丏万丄上业)
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_2 = 上丙且丙丏万丄上业.GetEnumerator();
        label_6:
        if(((-462434440) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if((val_3 == null) || (val_3.不业丙丒丂丞下丆丙() != 85))
        {
            goto label_6;
        }
        
        val_1.Add(item:  val_3.业上丙丞丐丄丆丅七());
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private System.Collections.Generic.List<string> 丁世丈丛丘七七专专(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_2 = 丞丑丘丂不不丝丈丞.GetEnumerator();
        label_6:
        if(((-462281480) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if((val_3 == null) || (val_3.Type != 85))
        {
            goto label_6;
        }
        
        val_1.Add(item:  val_3.Id);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    public void U_Hide()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.七丘一丝丈一丛专丅(丞丑丏七丏丐专万专:  false);
    }
    internal void 七丘一丝丈一丛专丅(bool 丞丑丏七丏丐专万专)
    {
        UnityEngine.Object val_26;
        Rilisoft.LobbyCraftController val_27;
        var val_28;
        var val_29;
        bool val_30;
        UnityEngine.Object val_31;
        val_27 = this;
        if(this.丘万丌东丁万丕业业 == false)
        {
                return;
        }
        
        this.gameObject.SetActive(value:  false);
        this.丘万丌东丁万丕业业 = false;
        MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = (this.丑与七不七丟丂与东 == true) ? 1 : 0;
        val_28 = null;
        val_28 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  gameObject, 丏业丟一东丂东丘丛:  (this.上一丗东丅丂上丂世 == true) ? 1 : 0);
        val_29 = null;
        val_29 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  ShopNGUIController.丏丙丅丕一丑丕丑丑.ActiveObject, 丏业丟一东丂东丘丛:  this.上丆丞丄丄丛丘丝三);
        if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
        {
                if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != null)
        {
                val_30 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂();
        }
        else
        {
                val_30 = 0.上丙丆不丂丂丄一丂();
        }
        
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丆且且下东不世上丕(与丝东万丙丞丝丟七:  0, 丗不且三丈丞专丄丛:  val_30, 丒丞丐丘且不且丟东:  true);
        }
        
        bool val_12 = 丞丑丏七丏丐专万专 ^ 1;
        BankController.丑七不且上丗丁一世().上丌万丛东丒丝丞丁(丑三三下一丝丞丐世:  val_12);
        val_26 = MainStoreView.丑七不且上丗丁一世();
        val_31 = 0;
        if(val_26 != val_31)
        {
                val_26 = MainStoreView.丑七不且上丗丁一世();
            val_31 = val_12;
            val_26.上丌万丛东丒丝丞丁(丑三三下一丝丞丐世:  val_31);
        }
        
        if(丞丑丏七丏丐专万专 != false)
        {
                if(this.上世丗三丝三七万丛 != null)
        {
                val_31 = 0;
            if((((this.上世丗三丝三七万丛.丁专丗万三上丟三丆() != null) && (val_17.丒上一丁丆丛东专丙 != null)) && (val_17.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业 != null)) && (PreviewOfferPackController.丞丟丒丈丆下丄一丞 != null))
        {
                Rilisoft.七丈业与与不七丈丟 val_18 = this.上世丗三丝三七万丛.丁专丗万三上丟三丆();
            val_26 = val_18.丒上一丁丆丛东专丙;
            val_31 = val_18.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业;
            PreviewOfferPackController.丞丟丒丈丆下丄一丞.Invoke(obj:  val_31);
        }
        
        }
        
            if(((this.与丐不业丑丗丌业下 != null) && (this.与丐不业丑丗丌业下 != null)) && (PreviewOfferPackController.丄与专上万且丕丏三 != null))
        {
                val_26 = this.与丐不业丑丗丌业下;
            PreviewOfferPackController.丄与专上万且丕丏三.Invoke(obj:  val_26);
        }
        
        }
        
        if(this.丛丄业丘不丆丄三丞 != null)
        {
                this.丛丄业丘不丆丄三丞.Invoke();
        }
        
        this.上世丗三丝三七万丛 = 0;
        this.与丐不业丑丗丌业下 = 0;
        val_27 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗;
        if(val_27 == 0)
        {
                return;
        }
        
        val_27 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(val_27 == 0)
        {
                return;
        }
        
        Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丙专且一丗一丘丂世(丙业与丙丗丝不丈东:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业(), 丅丁三世丝三丞专世:  false, 丝一专专丏丝丘丒东:  true);
    }
    public void U_Buy()
    {
        this.丞丏丛业丄万专丈丛();
        this.丆与丆世丞丗丗不丈();
    }
    internal void 丞丏丛业丄万专丈丛()
    {
        var val_12;
        if(this.上世丗三丝三七万丛 == null)
        {
                return;
        }
        
        丈丞丕丘丕丗与上一 val_1 = this.上世丗三丝三七万丛.丟丂丞不专丆万丒世();
        if((System.String.op_Equality(a:  val_1.东与三丌丅三丒丏业(), b:  "Real")) == true)
        {
            goto label_3;
        }
        
        val_12 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  val_1.东与三丌丅三丒丏业());
        if(val_12 < val_1.丟丂丞不专丆万丒世())
        {
            goto label_9;
        }
        
        label_3:
        val_12 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        val_12.丈专且专丗不一专丘(丙业丞丑七丗下丟丌:  this.上世丗三丝三七万丛, 且丗丅上丄丕且下上:  "offers");
        label_9:
        UnityEngine.Coroutine val_11 = CoroutineRunner.Instance.StartCoroutine(routine:  this.三丟丐业业一丕下万());
    }
    internal void 丆与丆世丞丗丗不丈()
    {
        if(this.与丐不业丑丗丌业下 == null)
        {
                return;
        }
        
        bool val_1 = this.与丐不业丑丗丌业下.且丏三丞丝丟丘丅丕();
        if(this.与丐不业丑丗丌业下 == null)
        {
            goto label_2;
        }
        
        if(val_1 == false)
        {
            goto label_3;
        }
        
        label_7:
        this.与丐不业丑丗丌业下.丈丙且一万丟丕万下();
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  this.三丟丐业业一丕下万());
        return;
        label_2:
        if(val_1 == true)
        {
            goto label_7;
        }
        
        label_3:
        if((((this.与丐不业丑丗丌业下 == null) || (this.与丐不业丑丗丌业下.业东丅东丌上丗丑不() == 17015)) || (this.与丐不业丑丗丌业下.业东丅东丌上丗丑不() == 10015)) || (this.与丐不业丑丗丌业下.业东丅东丌上丗丑不() == 11015))
        {
            goto label_17;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  this.与丐不业丑丗丌业下, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_20;
        }
        
        label_17:
        this.与丐不业丑丗丌业下.丏丝丘七丕与世丅丆();
        this = this.三丟丐业业一丕下万();
        UnityEngine.Coroutine val_12 = CoroutineRunner.Instance.StartCoroutine(routine:  this);
        return;
        label_20:
        UnityEngine.Debug.LogError(message:  "Cant purchase promotion!");
    }
    private System.Collections.IEnumerator 三丟丐业业一丕下万()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PreviewOfferPackController.不丕且丑专与丙专丂(丗丏丅丕丆世丁专丟:  0);
    }
    public PreviewOfferPackController()
    {
    
    }

}
