using UnityEngine;
internal class AlmanachWeaponInfoUI : InventoryItemInfo
{
    // Fields
    private UnityEngine.GameObject holder;
    private UILabel number;
    private UILabel rarity;
    private UILabel category;
    private UILabel weaponStory;
    private UILabel weaponDevStory;
    private GameObjectRotatorUI gameObjectRotatorUI;
    private UnityEngine.GameObject skinsButton;
    private WeaponSkinsShopUI weaponSkinsShopUI;
    private PropertiesLayout propertiesLayout;
    private UnityEngine.GameObject itemViewerButton;
    private UnityEngine.GameObject previewPoint;
    private UnityEngine.GameObject 与丑丙丛与丟丂丅丌;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPurchased;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotPurchased;
    private PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与;
    private System.IDisposable 七丝丕丅与且丘业万;
    public UnityEngine.Transform slider;
    public UnityEngine.Transform sliderArrow;
    public bool sliderUp;
    public float sliderLerpFactor;
    public UnityEngine.Vector3 sliderUpPos;
    public UnityEngine.Vector3 sliderDownPos;
    public UnityEngine.GameObject slideUpButton;
    public UnityEngine.GameObject slideDownButton;
    private UnityEngine.GameObject alternativeBuyUI;
    private CurrencyUI alternativePriceUI;
    private UnityEngine.GameObject alternativeBuyButtonEnabled;
    private UnityEngine.GameObject alternativeBuyButtonDisabled;
    private UnityEngine.GameObject GoToArsenal;
    private UnityEngine.GameObject GoToGameEventChests;
    private UnityEngine.GameObject GoToGameEventRoulettes;
    private UnityEngine.GameObject GoToBattlePass;
    private UnityEngine.GameObject GoToCampaign;
    private UnityEngine.GameObject GoToGatcha;
    private UnityEngine.GameObject GoToClans;
    private UnityEngine.GameObject GoToTempItems;
    private PGCompany.丘丁丕丈丘且业三丄 一业丁业上世丐丏三;
    
    // Methods
    public void Show(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
    {
        object val_33;
        System.Collections.Generic.List<T> val_35;
        string val_36;
        string val_37;
        System.Collections.Generic.List<UnityEngine.GameObject> val_38;
        var val_39;
        val_33 = this;
        if(this.七丝丕丅与且丘业万 != null)
        {
                var val_32 = 0;
            val_32 = val_32 + 1;
            this.七丝丕丅与且丘业万.Dispose();
        }
        
        val_35 = Rilisoft.BackSystem.丑七不且上丗丁一世();
        this.一业一丕丅下业世与 = 一业一丕丅下业世与;
        this.七丝丕丅与且丘业万 = val_35.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void AlmanachWeaponInfoUI::丗世三专东丟丙七丅()), 与且专丈不万东一万:  "AlmanachMainUI_Info");
        if(一业一丕丅下业世与 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  val_35, 丏业丟一东丂东丘丛:  true);
        this.下丘丈三不万东丟丄();
        this.丗丆世丒不下与丅一();
        this.丞丟专丏万丑丅东丐();
        this.丛丄且万丅丝丝丐与();
        this.世下下丛七丏丅东一();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.number, 丕丗丘丑丛与丑业丒:  "#" + 一业一丕丅下业世与.丏万东丐丛不丛不世());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rarity, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  一业一丕丅下业世与.丐上下三丑丈丑丄丟()));
        UnityEngine.Color val_10 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  一业一丕丅下业世与.丐上下三丑丈丑丄丟());
        this.rarity.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.category, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.世丞丞上世丗丒丏丈(丟丆丏且专不丕上专:  一业一丕丅下业世与.丐上下三丑丈丑丄丟().丒万丕七专不丏丞丌()));
        string val_16 = 一业一丕丅下业世与.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌() + "_story";
        string val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_16);
        val_36 = val_17;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_17)) != true)
        {
                if((System.String.op_Equality(a:  val_36, b:  val_16)) == false)
        {
            goto label_24;
        }
        
        }
        
        val_36 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7573");
        label_24:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.weaponStory, 丕丗丘丑丛与丑业丒:  val_36);
        string val_23 = 一业一丕丅下业世与.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌() + "_dev";
        string val_24 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_23);
        val_37 = val_24;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_24)) != true)
        {
                if((System.String.op_Equality(a:  val_37, b:  val_23)) == false)
        {
            goto label_33;
        }
        
        }
        
        val_37 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7574");
        label_33:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.weaponDevStory, 丕丗丘丑丛与丑业丒:  val_37);
        val_35 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if((val_35.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  一业一丕丅下业世与.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPurchased, 丏业丟一东丂东丘丛:  true);
            val_38 = this.enableIfNotPurchased;
            val_39 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPurchased, 丏业丟一东丂东丘丛:  false);
            val_38 = this.enableIfNotPurchased;
            val_39 = 1;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_38, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemViewerButton, 丏业丟一东丂东丘丛:  false);
        if(DeveloperConsoleController.丙丒丛一丞下三且一() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.itemViewerButton, 丏业丟一东丂东丘丛:  true);
        }
        
        val_33 = this.holder;
        val_33.SetActive(value:  true);
    }
    public void UpdateView()
    {
        if(this.holder.activeSelf == false)
        {
                return;
        }
        
        this.Show(一业一丕丅下业世与:  this.一业一丕丅下业世与);
    }
    private void 丗世三专东丟丙七丅()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        this.Hide();
    }
    public void Hide()
    {
        var val_10;
        UnityEngine.Camera val_11;
        var val_12;
        if(this.七丝丕丅与且丘业万 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            this.七丝丕丅与且丘业万.Dispose();
        }
        
        this.且丁丑丌上且丁上丅();
        this.holder.SetActive(value:  false);
        if(this.与丑丙丛与丟丂丅丌 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.与丑丙丛与丟丂丅丌);
        }
        
        this.sliderUp = false;
        this.slider.localPosition = new UnityEngine.Vector3() {x = this.sliderDownPos, y = V9.16B, z = V10.16B};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        this.sliderArrow.up = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        val_10 = null;
        val_10 = null;
        val_11 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
        if(val_11 != 0)
        {
                return;
        }
        
        val_11 = MainMenuHeroCamera.丑七不且上丗丁一世();
        if(val_11 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_11 = MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三();
        val_12 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = val_11;
    }
    private void 下丘丈三不万东丟丄()
    {
        if(this.与丑丙丛与丟丂丅丌 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.与丑丙丛与丟丂丅丌);
        }
        
        UnityEngine.GameObject val_4 = this.一业一丕丅下业世与.丑丑丛丛丙丙七丏丆(且丅丟丛丛万丝下上:  this.gameObject.layer);
        this.与丑丙丛与丟丂丅丌 = val_4;
        if(val_4 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_6 = this.与丑丙丛与丟丂丅丌.transform;
        val_6.SetParent(p:  this.previewPoint.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_6);
        this.gameObjectRotatorUI.ResetRotation();
    }
    private void 丗丆世丒不下与丅一()
    {
        var val_5;
        UnityEngine.GameObject val_6;
        if((丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌()).Count) >= 1)
        {
                val_5 = 1;
            val_6 = this.skinsButton;
        }
        else
        {
                val_6 = this.skinsButton;
            val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
    }
    public void U_ToggleShowSkins()
    {
        if(this.weaponSkinsShopUI.gameObject.activeSelf != false)
        {
                this.且丁丑丌上且丁上丅();
            return;
        }
        
        if((丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌()).Count) < 1)
        {
                return;
        }
        
        this.丄丁丌丌上丏东万丝();
    }
    private void 丄丁丌丌上丏东万丝()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  137117696, 丏业丟一东丂东丘丛:  false);
        this.weaponSkinsShopUI.丌丑世三丑丁丗丞万(下丅丙一丂丗丅丝七:  this.一业一丕丅下业世与);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.weaponSkinsShopUI, 丏业丟一东丂东丘丛:  true);
        this.丛丄且万丅丝丝丐与();
    }
    private void 且丁丑丌上且丁上丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  137117696, 丏业丟一东丂东丘丛:  true);
        this.weaponSkinsShopUI.SetDefault();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.weaponSkinsShopUI, 丏业丟一东丂东丘丛:  false);
        this.丛丄且万丅丝丝丐与();
    }
    private void 丞丟专丏万丑丅东丐()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        this.propertiesLayout.世业丒万丘丆专丘丐();
        int val_3 = this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄().Count;
        if(val_3 == 3)
        {
            goto label_5;
        }
        
        if(val_3 != 2)
        {
            goto label_6;
        }
        
        val_19 = this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄();
        val_20 = 1152921524342372736;
        val_21 = 1;
        val_22 = public 丈不三丛七丑丈丑丆 System.Collections.Generic.List<丈不三丛七丑丈丑丆>::get_Item(int index);
        goto label_10;
        label_5:
        val_20 = 1152921524342372736;
        this.丙东万丟与丝丒丟丛(丏不丂丆且三丞丆丏:  this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄().Item[1]);
        val_19 = this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄();
        val_22 = public 丈不三丛七丑丈丑丆 System.Collections.Generic.List<丈不三丛七丑丈丑丆>::get_Item(int index);
        val_21 = 2;
        label_10:
        this.丙东万丟与丝丒丟丛(丏不丂丆且三丞丆丏:  val_19.Item[2]);
        this.丙东万丟与丝丒丟丛(丏不丂丆且三丞丆丏:  this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄().Item[0]);
        return;
        label_6:
        List.Enumerator<T> val_17 = this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄().GetEnumerator();
        label_24:
        if(((-1739232232) & 1) == 0)
        {
            goto label_23;
        }
        
        this.丙东万丟与丝丒丟丛(丏不丂丆且三丞丆丏:  0.丙东专丂世丈丏丁丂());
        goto label_24;
        label_23:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丙东万丟与丝丒丟丛(WeaponSounds.丈不三丛七丑丈丑丆 丏不丂丆且三丞丆丏)
    {
        string val_6;
        string val_10;
        int val_12;
        var val_13;
        if(丏不丂丆且三丞丆丏 == 11)
        {
                val_12 = this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().且三丁业下业七丅丘().ToString() + "X ";
        }
        else
        {
                val_12 = System.String.alignConst;
        }
        
        val_13 = null;
        val_13 = null;
        System.ValueTuple<System.String, System.String, System.String> val_5 = WeaponSounds.三丘丒万丛丞与一不.Item[丏不丂丆且三丞丆丏];
        System.ValueTuple<System.String, System.String, System.String> val_9 = WeaponSounds.三丘丒万丛丞与一不.Item[丏不丂丆且三丞丆丏];
        PropertyUI val_11 = this.propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  val_10, 丟丒丏丛三丟丑丗丝:  val_12 + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6)), 丌丒丝东丌下丕丁丅:  "", 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    public void PolygonButtonPressed()
    {
        if(PolygonController.一下一万丄丅丘且丑 == 0)
        {
                return;
        }
        
        PolygonController.一下一万丄丅丘且丑.下一万万业东丕七东(丌丝下丄业一丄不三:  this.一业一丕丅下业世与, 丅丕丑丗丄万丑丞丝:  true, 丘丂丒丟丝丆丕丛丝:  false);
    }
    public void ItemViewerButtonPressed()
    {
        if(DeveloperConsoleController.丙丒丛一丞下三且一() == false)
        {
                return;
        }
        
        if(this.一业一丕丅下业世与 == null)
        {
                return;
        }
        
        Rilisoft.ItemViewer val_4 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.holder.transform, 丕丁下丌不万丅丞丛:  this.一业一丕丅下业世与.业上丙丞丐丄丆丅七(), 丅三丟世下丞丝丙万:  1, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  false, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        if(val_4 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.与丑丙丛与丟丂丅丌, 丏业丟一东丂东丘丛:  false);
        val_4.add_OnHide(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AlmanachWeaponInfoUI::丙丘下业业世丙丂三()));
    }
    public void ToggleSlider()
    {
        bool val_1 = this.sliderUp;
        val_1 = val_1 ^ 1;
        this.sliderUp = val_1;
    }
    private void Update()
    {
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        UnityEngine.Transform val_16;
        UnityEngine.Vector3 val_1 = this.slider.localPosition;
        if(this.sliderUp != false)
        {
                val_12 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.sliderUpPos, y = V12.16B, z = V13.16B}, t:  val_12 * this.sliderLerpFactor);
            val_13 = val_4.x;
            val_14 = val_4.y;
            val_15 = val_4.z;
            this.slider.localPosition = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
            val_16 = this.sliderArrow;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
        }
        else
        {
                val_12 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.sliderDownPos, y = V12.16B, z = V13.16B}, t:  val_12 * this.sliderLerpFactor);
            val_13 = val_8.x;
            val_14 = val_8.y;
            val_15 = val_8.z;
            this.slider.localPosition = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
            val_16 = this.sliderArrow;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
        }
        
        val_16.up = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.slideUpButton, 丏业丟一东丂东丘丛:  (this.sliderUp == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.slideDownButton, 丏业丟一东丂东丘丛:  this.sliderUp);
    }
    private void 丛丄且万丅丝丝丐与()
    {
        UnityEngine.GameObject val_10;
        var val_11;
        this.alternativeBuyUI.SetActive(value:  false);
        if(this.一业一丕丅下业世与 == null)
        {
                return;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  this.一业一丕丅下业世与.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
        {
                return;
        }
        
        丈丞丕丘丕丗与上一 val_4 = 上且丁万与丌下丐上.丁上丄丐丞丐专丘丛(一业一丕丅下业世与:  this.一业一丕丅下业世与);
        if(val_4 == null)
        {
                return;
        }
        
        if(val_4.丟丂丞不专丆万丒世() < 1)
        {
                return;
        }
        
        this.alternativeBuyUI.SetActive(value:  true);
        this.alternativePriceUI.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  val_4);
        if((BankController.丈专丐万丑专丒丗丂(万丐丏丐丒万不丟三:  val_4)) != false)
        {
                if(this.weaponSkinsShopUI.gameObject.activeSelf == false)
        {
            goto label_17;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.alternativeBuyButtonEnabled, 丏业丟一东丂东丘丛:  false);
        val_10 = this.alternativeBuyButtonDisabled;
        val_11 = 1;
        goto label_20;
        label_17:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.alternativeBuyButtonEnabled, 丏业丟一东丂东丘丛:  true);
        val_10 = this.alternativeBuyButtonDisabled;
        val_11 = 0;
        label_20:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  false);
    }
    public void AlternativeBuyButtonPressed()
    {
        if((上且丁万与丌下丐上.三丈下丑业一丗丑且(一业一丕丅下业世与:  this.一业一丕丅下业世与)) == false)
        {
                return;
        }
        
        this.Show(一业一丕丅下业世与:  this.一业一丕丅下业世与);
    }
    private void 世下下丛七丏丅东一()
    {
        UnityEngine.GameObject val_7 = this;
        this.一业丁业上世丐丏三 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToArsenal, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToGameEventChests, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToGameEventRoulettes, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToBattlePass, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToCampaign, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToGatcha, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToClans, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.GoToTempItems, 丏业丟一东丂东丘丛:  false);
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  this.一业一丕丅下业世与.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
        {
                return;
        }
        
        PGCompany.上丕丈丞一丟丟丛丂 val_4 = PGCompany.丌东丛不丅三下业上.丌不丂丙丂丝丌丅丈(一业一丕丅下业世与:  this.一业一丕丅下业世与);
        if(val_4 == 0)
        {
                return;
        }
        
        PGCompany.丘丁丕丈丘且业三丄 val_5 = PGCompany.丕丝下丁七东丄三丑.丘丅与万三丙世丆丈(世丌七与丄丟丅丁东:  val_4);
        this.一业丁业上世丐丏三 = val_5;
        if((val_5 - 1) > 9)
        {
                return;
        }
        
        var val_7 = 106027380 + ((val_5 - 1)) << 2;
        val_7 = val_7 + 106027380;
        goto (106027380 + ((val_5 - 1)) << 2 + 106027380);
    }
    private void 世丕一丅丌不丄丑丌()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        if(AlmanachMainUI.instance == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        AlmanachMainUI.丈七丝丑丑七且丏丗 = this.一业一丕丅下业世与.业东丅东丌上丗丑不();
        AlmanachMainUI.丑丒万丐丞丒丈专丞 = true;
        val_8 = ???;
        goto typeof(AlmanachMainUI).__il2cppRuntimeField_1C8;
    }
    public void U_Move()
    {
        this.丕万丝丙丘丁丌丟丛();
        this.且丁丑丌上且丁上丅();
    }
    private void 丕万丝丙丘丁丌丟丛()
    {
        PGCompany.丌不丞丐世丞三丘丌 val_21;
        CategoryNames val_22;
        var val_23;
        var val_24;
        PGCompany.丌不丞丐世丞三丘丌 val_1 = null;
        val_21 = val_1;
        val_1 = new PGCompany.丌不丞丐世丞三丘丌();
        .Type = this.一业丁业上世丐丏三;
        .ItemId = this.一业一丕丅下业世与.业上丙丞丐丄丆丅七();
        .ItemCategory = this.一业一丕丅下业世与;
        val_22 = 65536;
        val_22 = 1;
        val_23 = 1152921504616751104;
        val_24 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  176, 丙丑丄与丅丐一不东:  false);
        if((val_24.Exists(match:  new System.Predicate<丙且上东下丏丏丟下>(object:  this, method:  System.Boolean AlmanachWeaponInfoUI::三丘丕专丈丐丌丂丞(丙且上东下丏丏丟下 三丟东丕丄丄下下丑)))) != true)
        {
                val_22 = 131072;
            val_22 = 2;
            val_24 = 上丑三丁丄丛丁万丑.丅业丂业丝丅丛世三(七丆丒与丗丌丄且丂:  88, 丙丑丄与丅丐一不东:  false);
            if((val_24.Exists(match:  new System.Predicate<丙且上东下丏丏丟下>(object:  this, method:  System.Boolean AlmanachWeaponInfoUI::丆不七与丄万上丘丒(丙且上东下丏丏丟下 三丟东丕丄丄下下丑)))) != true)
        {
                val_22 = (PGCompany.丌不丞丐世丞三丘丌)[1152921524344327552].ItemCategory;
        }
        
        }
        
        .ShopCategory = val_22;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_1)) == null)
        {
                return;
        }
        
        val_21 = ???;
        val_24 = ???;
        val_22 = ???;
        val_23 = ???;
        goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
    }
    public AlmanachWeaponInfoUI()
    {
        this.sliderLerpFactor = 10f;
    }
    private void 丙丘下业业世丙丂三()
    {
        if(this.与丑丙丛与丟丂丅丌 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.与丑丙丛与丟丂丅丌, 丏业丟一东丂东丘丛:  true);
    }
    private bool 三丘丕专丈丐丌丂丞(丙且上东下丏丏丟下 三丟东丕丄丄下下丑)
    {
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.业上丙丞丐丄丆丅七(), b:  this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛());
    }
    private bool 丆不七与丄万上丘丒(丙且上东下丏丏丟下 三丟东丕丄丄下下丑)
    {
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.业上丙丞丐丄丆丅七(), b:  this.一业一丕丅下业世与.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛());
    }

}
