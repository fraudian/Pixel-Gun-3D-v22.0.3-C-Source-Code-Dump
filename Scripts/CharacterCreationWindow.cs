using UnityEngine;
internal sealed class CharacterCreationWindow : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject container_privacy_others;
    private UnityEngine.GameObject container_privacy_europe;
    private AskNameManager askNameManager;
    private StoreCharacterHelper _character;
    private ItemSelectorView itemSelectorView;
    private UIInputRilisoft uiInput;
    private UILabel hintLabel;
    private UnityEngine.Color hintColor_tap;
    private UnityEngine.Color hintColor_ok;
    private UnityEngine.Color hintColor_notOk;
    private UnityEngine.GameObject doneButton_Active;
    private UnityEngine.GameObject doneButton_Inactive;
    private UIGrid grid;
    private ScrollViewHelper scrollHelper;
    private WidgetLayout layoutHelper;
    private MiniPoolMonoBehaviour layoutPool;
    private System.Collections.Generic.List<UIWidget> 丑丞丏专专一丒丐丄;
    private System.IDisposable 专丏业专不丂一丂丛;
    private UnityEngine.Color 不丂丝丘丅三且与丒;
    private bool 丛一上丗世丅丂丑丈;
    
    // Methods
    public void U_ShowTermsOfUse()
    {
        null = null;
        UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.丙且丛丄丈丗上丙丄);
    }
    public void U_ShowPrivatePolicy()
    {
        null = null;
        UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.不丝东丑丐与丂丙丆);
    }
    protected void OnEnable()
    {
        丆上上不丄东万下三 val_19;
        丂一世丝丝丞七下上 val_20;
        UnityEngine.Debug.Log(message:  "[CharacterCreationWindow] OnEnable.    NameAlreadySet = "("[CharacterCreationWindow] OnEnable.    NameAlreadySet = ") + AskNameManager.下丅丏七丒且不丕且().ToString());
        UnityEngine.Color val_5 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
        this.不丂丝丘丅三且与丒 = val_5;
        mem[1152921536473611716] = val_5.g;
        mem[1152921536473611720] = val_5.b;
        mem[1152921536473611724] = val_5.a;
        this.丛一上丗世丅丂丑丈 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
        this.丅七丐不丒丛丞三丌(丙业与丙丗丝不丈东:  true);
        this.itemSelectorView.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterCreationWindow::丘下丟丁上丏丛且且()));
        val_19 = System.Delegate.Combine(a:  this.uiInput.onFocus, b:  new UIInputRilisoft.丆上上不丄东万下三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CharacterCreationWindow::丆上上不丄东万下三()));
        if(this.uiInput == null)
        {
            goto label_7;
        }
        
        if(val_19 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_19 == null)
        {
            goto label_11;
        }
        
        label_8:
        if(null != null)
        {
                val_19 = 0;
        }
        
        label_11:
        this.uiInput.onFocus = val_19;
        val_20 = System.Delegate.Combine(a:  this.uiInput.onFocusLost, b:  new UIInputRilisoft.丂一世丝丝丞七下上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CharacterCreationWindow::丂一世丝丝丞七下上()));
        if(this.uiInput == null)
        {
            goto label_13;
        }
        
        if(val_20 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_20 == null)
        {
            goto label_17;
        }
        
        label_14:
        if(null != null)
        {
                val_20 = 0;
        }
        
        label_17:
        this.uiInput.onFocusLost = val_20;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._character, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Coroutine val_15 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  public System.Void CharacterCreationWindow::Setup()), 业丗七丕万万不丈丗:  1);
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "CharacterCreationWindow");
    }
    protected void OnDisable()
    {
        丆上上不丄东万下三 val_8;
        丂一世丝丝丞七下上 val_9;
        this.丅七丐不丒丛丞三丌(丙业与丙丗丝不丈东:  false);
        this.itemSelectorView.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterCreationWindow::丘下丟丁上丏丛且且()));
        val_8 = System.Delegate.Remove(source:  this.uiInput.onFocus, value:  new UIInputRilisoft.丆上上不丄东万下三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CharacterCreationWindow::丆上上不丄东万下三()));
        if(this.uiInput == null)
        {
            goto label_3;
        }
        
        if(val_8 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_8 == null)
        {
            goto label_7;
        }
        
        label_4:
        if(null != null)
        {
                val_8 = 0;
        }
        
        label_7:
        this.uiInput.onFocus = val_8;
        val_9 = System.Delegate.Remove(source:  this.uiInput.onFocusLost, value:  new UIInputRilisoft.丂一世丝丝丞七下上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CharacterCreationWindow::丂一世丝丝丞七下上()));
        if(this.uiInput == null)
        {
            goto label_9;
        }
        
        if(val_9 != null)
        {
            goto label_10;
        }
        
        goto label_13;
        label_9:
        if(val_9 == null)
        {
            goto label_13;
        }
        
        label_10:
        if(null != null)
        {
                val_9 = 0;
        }
        
        label_13:
        this.uiInput.onFocusLost = val_9;
        this.itemSelectorView.丞七丐三丑东且丈下();
        if(this.专丏业专不丂一丂丛 == null)
        {
                return;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        this.专丏业专不丂一丂丛.Dispose();
    }
    public void Setup()
    {
        var val_11;
        var val_18;
        bool val_19;
        PGCompany.三东丏不丗世丅丌丄 val_20;
        ItemSelectorView val_21;
        CharacterCreationWindow.丌丐丝丐下上三丛丌 val_1 = new CharacterCreationWindow.丌丐丝丐下上三丛丌();
        .丝且与丝丒丟万丁专 = this;
        val_18 = null;
        val_18 = null;
        string val_2 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐丕万七万丏一丅丟);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) != false)
        {
                val_19 = 0;
        }
        else
        {
                val_19 = System.String.op_Inequality(a:  val_2, b:  "EU");
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.container_privacy_europe, 丏业丟一东丂东丘丛:  (val_19 == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.container_privacy_others, 丏业丟一东丂东丘丛:  val_19);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._character, 丏业丟一东丂东丘丛:  true);
        this._character.万与七丕七丁丞下丆 = false;
        this.itemSelectorView.丞七丐三丑东且丈下();
        this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_8 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        List.Enumerator<T> val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  65, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}).GetEnumerator();
        label_20:
        if((1802469696 & 1) == 0)
        {
            goto label_17;
        }
        
        val_8.Add(item:  val_11.丐丏七丌丕丗业且上().丑丐丙丄丅世世丑丒());
        goto label_20;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.三东丏不丗世丅丌丄 val_14 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.三东丏不丗世丅丌丄>(丑东与丅丐丅丂丞业:  val_8);
        if(val_1 != null)
        {
                val_20 = val_1;
            .丂丒丘丅专丗丂世丛 = val_14;
            val_21 = this.itemSelectorView;
        }
        else
        {
                val_20 = 24;
            mem[24] = val_14;
            val_21 = this.itemSelectorView;
        }
        
        val_21.丈且东丑丂且万丒丅(丑七不与丛丆一丂丞:  val_8, 丛丗七丅下丞丗且丐:  val_20);
        this.万丗丞丂丒世丁丟丟(下丅丙一丂丗丅丝七:  mem[24]);
        UnityEngine.Coroutine val_16 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void CharacterCreationWindow.丌丐丝丐下上三丛丌::丆一且世上丗上一丗()), 业丗七丕万万不丈丗:  1);
        this.丆丙丆且丞丞丘丞一();
        this.丅三上丒七下丟专世();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.hintLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0331"));
        this.hintLabel.color = new UnityEngine.Color() {r = this.hintColor_tap, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    private void 丆丙丆且丞丞丘丞一()
    {
        string val_4;
        string val_1 = ProfileController.丆三丂丂丆上丆丕专();
        val_4 = val_1;
        if((val_1.七东东三专丈一丁且(丒丘丏上丙丟丑丕丈:  val_4)) != true)
        {
                val_4 = ProfileController.专不业业下东丆不世();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.uiInput, 丕丗丘丑丛与丑业丒:  val_4);
        this.uiInput.value = val_4;
    }
    private void 丑丟三丟丑丑丐丒丐()
    {
        var val_3;
        var val_9;
        int val_10;
        List.Enumerator<T> val_1 = this.丑丞丏专专一丒丐丄.GetEnumerator();
        val_9 = 1152921526158939600;
        label_4:
        if((1802870880 & 1) == 0)
        {
            goto label_2;
        }
        
        this.layoutPool.Return(万且万且丑丗且丌丆:  val_3.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.layoutHelper.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        val_10 = this.grid.maxPerLine;
        float val_9 = (float)this.itemSelectorView.丘丑丘丕丁丌丏万不().Count;
        val_9 = val_9 / (float)val_10;
        int val_10 = UnityEngine.Mathf.CeilToInt(f:  val_9);
        if(val_10 >= 1)
        {
                val_9 = 1152921526158971344;
            do
        {
            val_10 = this.layoutPool.Get<UIWidget>();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
            val_10.height = (int)this.grid.cellHeight;
            if(val_10 != null)
        {
                val_10.width = (int)this.grid.cellWidth;
        }
        else
        {
                val_10.width = (int)this.grid.cellWidth;
        }
        
            val_10.ResetAndUpdateAnchors();
            this.layoutHelper.AddElement(世丌丌丙丞丟下东丞:  val_10);
            this.丑丞丏专专一丒丐丄.Add(item:  val_10);
            val_10 = val_10 - 1;
        }
        while(val_10 != 0);
        
        }
        
        this.layoutHelper.Reposition();
    }
    private void 万丗丞丂丒世丁丟丟(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)
    {
        System.Collections.Generic.IEnumerable<TSource> val_12;
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        this.丑丟三丟丑丑丐丒丐();
        val_12 = this.itemSelectorView.丘丑丘丕丁丌丏万不();
        ItemSelectableButton val_4 = System.Linq.Enumerable.FirstOrDefault<ItemSelectableButton>(source:  val_12, predicate:  new System.Func<ItemSelectableButton, System.Boolean>(object:  new CharacterCreationWindow.丄丆丌丌丕丈丆丆业(), method:  System.Boolean CharacterCreationWindow.丄丆丌丌丕丈丆丆业::专丒丐丝七下三上丆(ItemSelectableButton 三丟东丕丄丄下下丑)));
        if(val_4 == 0)
        {
                return;
        }
        
        float val_12 = (float)this.itemSelectorView.丘丑丘丕丁丌丏万不().IndexOf(item:  val_4);
        val_12 = val_12 / (float)this.grid.maxPerLine;
        int val_8 = UnityEngine.Mathf.FloorToInt(f:  val_12);
        val_12 = this.丑丞丏专专一丒丐丄;
        if(val_12.Count <= val_8)
        {
                return;
        }
        
        this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  this.丑丞丏专专一丒丐丄.Item[val_8].transform, 丌与丟丁万丝丞丄丏:  false);
    }
    internal void 丘下丟丁上丏丛且且()
    {
        var val_4;
        this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  this.itemSelectorView.丕丟丐丈丐丄丌三丐());
        丛且丗丌丏下七下丈.丂丈不丟丈丑下世丆(丆不丅丂七丕丄万丁:  "EMPTY_ROYALE_AVATAR", 与且专丏丅世丐丐丑:  false);
        val_4 = null;
        val_4 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丅东东万丘丝丅三世(丞丅上丏丂且下丅与:  this.itemSelectorView.丕丟丐丈丐丄丌三丐().业上丙丞丐丄丆丅七());
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丌丒丆一丏三专丕(丗丘丂丟丟业万业东:  true);
    }
    private void 丂一世丝丝丞七下上()
    {
        string val_1 = this.uiInput.text;
        if((val_1.七东东三专丈一丁且(丒丘丏上丙丟丑丕丈:  val_1)) != true)
        {
                this.丆丙丆且丞丞丘丞一();
        }
        
        this.丅三上丒七下丟专世();
    }
    private void 丆上上不丄东万下三()
    {
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void CharacterCreationWindow::丟丆丌丆业一丛丒万()), 业丗七丕万万不丈丗:  1);
    }
    private void 丅三上丒七下丟专世()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.doneButton_Active, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.doneButton_Inactive, 丏业丟一东丂东丘丛:  false);
        string val_1 = this.uiInput.text;
        if((val_1.七东东三专丈一丁且(丒丘丏上丙丟丑丕丈:  val_1)) == false)
        {
            goto label_5;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.hintLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10654"));
        if(this.hintLabel != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        this.hintLabel.color = new UnityEngine.Color() {r = this.hintColor_ok, g = V9.16B, b = V10.16B, a = V11.16B};
        return;
        label_5:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.hintLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10377"));
        if(this.hintLabel != null)
        {
            goto label_15;
        }
        
        goto label_16;
    }
    private bool 七东东三专丈一丁且(string 丒丘丏上丙丟丑丕丈)
    {
        if((System.String.IsNullOrEmpty(value:  丒丘丏上丙丟丑丕丈)) != false)
        {
                return false;
        }
        
        if(NickNameValidator.instance != null)
        {
                return NickNameValidator.instance.ValidateNickNameNoAnalytics(丕丗丘丑丛与丑业丒:  丒丘丏上丙丟丑丕丈);
        }
        
        return NickNameValidator.instance.ValidateNickNameNoAnalytics(丕丗丘丑丛与丑业丒:  丒丘丏上丙丟丑丕丈);
    }
    internal void 丅七丐不丒丛丞三丌(bool 丙业与丙丗丝不丈东)
    {
        bool val_2;
        if(丙业与丙丗丝不丈东 != false)
        {
                UnityEngine.Color val_1 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            val_2 = 0;
        }
        else
        {
                PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.不丂丝丘丅三且与丒});
            val_2 = this.丛一上丗世丅丂丑丈;
        }
        
        PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  val_2);
    }
    public void U_OnChange()
    {
        this.丅三上丒七下丟专世();
    }
    public void U_OkButtonPressed()
    {
        if(this.askNameManager != null)
        {
                this.askNameManager.SaveChooseNameOutside(丒丘丏上丙丟丑丕丈:  this.uiInput.text);
        }
        
        Rilisoft.世一丞三丈丂丄丌丆.上且丁丛丙丞丌一丄();
        NickNameValidationBanner.丄丝丂且丅丒七业丂();
    }
    public CharacterCreationWindow()
    {
        this.丑丞丏专专一丒丐丄 = new System.Collections.Generic.List<UIWidget>();
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.不丂丝丘丅三且与丒 = val_2;
        mem[1152921536475991140] = val_2.g;
        mem[1152921536475991144] = val_2.b;
        mem[1152921536475991148] = val_2.a;
    }
    private void 丟丆丌丆业一丛丒万()
    {
        if(this == 0)
        {
                return;
        }
        
        this.丅三上丒七下丟专世();
    }

}
