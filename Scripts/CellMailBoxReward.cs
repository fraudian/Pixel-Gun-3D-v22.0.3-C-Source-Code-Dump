using UnityEngine;
internal class CellMailBoxReward : PGBehaviour
{
    // Fields
    private Rilisoft.OfferItem <丝业三丑三上丆专不>k__BackingField;
    private UITextureMasked Texture;
    private UITextureMasked TextureCurrency;
    private UILabel currencyText;
    private UnityEngine.GameObject collectedBanner;
    private ArmoryInfoScreenController 下丏丗且丅丟丄丂与;
    private UnityEngine.GameObject previewHolder;
    private UnityEngine.Transform scrollStartPoint;
    private UnityEngine.Transform scrollEndPoint;
    private float detectedDistance;
    private float detectedDistanceDownScroll;
    private UIWidget myWidget;
    
    // Properties
    private Rilisoft.OfferItem 不下下丞三一丘丗丐 { get; set; }
    internal Rilisoft.OfferItem 与丑丝与业丐丟丏丁 { get; }
    
    // Methods
    private Rilisoft.OfferItem 丂丑丞丝且万丐万丟()
    {
        return (Rilisoft.OfferItem)this.<丝业三丑三上丆专不>k__BackingField;
    }
    private void 丘丕丈下东一丑上丗(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
    {
        this.<丝业三丑三上丆专不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.OfferItem 业丒丂丗丘三三不丈()
    {
        return (Rilisoft.OfferItem)this.<丝业三丑三上丆专不>k__BackingField;
    }
    internal void 丅丐丈丗丂丘丁丂丁(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁, bool 上且丁上七丁上丄一)
    {
        var val_17;
        UITextureMasked val_18;
        this.<丝业三丑三上丆专不>k__BackingField = 丏且丕丄丁丟丆丏丁;
        if(丏且丕丄丁丟丆丏丁 == null)
        {
            goto label_1;
        }
        
        if(丏且丕丄丁丟丆丏丁.Type != 1170)
        {
            goto label_2;
        }
        
        label_9:
        if(丏且丕丄丁丟丆丏丁.MiddleTexture != 0)
        {
            goto label_5;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Texture, 丏业丟一东丂东丘丛:  false);
        this.世丅丘丌丗业丑丗且();
        goto label_22;
        label_1:
        if(0.Type == 1170)
        {
            goto label_9;
        }
        
        label_2:
        if(丏且丕丄丁丟丆丏丁.Type != 1010)
        {
                if(丏且丕丄丁丟丆丏丁.Type != 1000)
        {
            goto label_12;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.currencyText, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currencyText, 丕丗丘丑丛与丑业丒:  丏且丕丄丁丟丆丏丁.PriceOfThisItem.丟丂丞不专丆万丒世());
        if(丏且丕丄丁丟丆丏丁 == null)
        {
            goto label_17;
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.TextureCurrency, 与万丆丛丒万丝丙丑:  丏且丕丄丁丟丆丏丁.MiddleTexture);
        goto label_18;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Texture, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.Texture, 与万丆丛丒万丝丙丑:  丏且丕丄丁丟丆丏丁.MiddleTexture);
        goto label_22;
        label_17:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.TextureCurrency, 与万丆丛丒万丝丙丑:  0.MiddleTexture);
        label_18:
        if(丏且丕丄丁丟丆丏丁.Type == 1000)
        {
                this.TextureCurrency.width = 145;
            this.TextureCurrency.height = 145;
        }
        
        val_17 = 1;
        val_18 = this.TextureCurrency;
        goto label_28;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Texture, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.Texture, 与万丆丛丒万丝丙丑:  丏且丕丄丁丟丆丏丁.MiddleTexture);
        val_18 = this.Texture;
        val_17 = 1;
        label_28:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  true);
        label_22:
        this.丙丄东丆专三丛丙丅(丙专丗丂丄丐丟七专:  上且丁上七丁上丄一 | (~(MailBoxMessagesController.不一丅丂上丁丈三下(丏且丕丄丁丟丆丏丁:  丏且丕丄丁丟丆丏丁))));
    }
    public void PreviewReward()
    {
        object val_45;
        var val_46;
        PGCompany.丟丝世万东万丆丟上 val_47;
        string val_48;
        string val_49;
        丙且上东下丏丏丟下 val_50;
        var val_51;
        var val_52;
        System.Action<UIPanel> val_54;
        val_45 = this;
        if((this.<丝业三丑三上丆专不>k__BackingField) == null)
        {
                return;
        }
        
        if((this.<丝业三丑三上丆专不>k__BackingField.Type) != 1010)
        {
                if((this.<丝业三丑三上丆专不>k__BackingField.Type) != 1000)
        {
            goto label_4;
        }
        
        }
        
        label_15:
        val_46 = null;
        val_46 = null;
        val_45 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.transform, 丏且丕丄丁丟丆丏丁:  this.<丝业三丑三上丆专不>k__BackingField, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false).transform;
        val_45.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_4:
        if((this.<丝业三丑三上丆专不>k__BackingField.Type) != 10)
        {
                if((this.<丝业三丑三上丆专不>k__BackingField.Type) != 70)
        {
            goto label_15;
        }
        
        }
        
        ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  true);
        if((this.<丝业三丑三上丆专不>k__BackingField.Type) != 1170)
        {
            goto label_17;
        }
        
        val_47 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.<丝业三丑三上丆专不>k__BackingField.Id);
        if(val_47 != null)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        val_47 = 0;
        label_21:
        三丅丁丗丗丝丂万且 val_14 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_47.上专丗丏丛丁专丑丄().WeaponIndex);
        if(val_14 == null)
        {
            goto label_25;
        }
        
        val_48 = val_14.与不丞丑七丘丁丂丛();
        goto label_26;
        label_17:
        三丅丁丗丗丝丂万且 val_17 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<丝业三丑三上丆专不>k__BackingField.Id);
        if(val_17 == null)
        {
            goto label_30;
        }
        
        val_49 = val_17.与不丞丑七丘丁丂丛();
        goto label_31;
        label_25:
        val_48 = 0.与不丞丑七丘丁丂丛();
        label_26:
        丙且上东下丏丏丟下 val_22 = null;
        val_50 = val_22;
        val_22 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_48, 七丆丒与丗丌丄且丂:  val_14.万上丄下业丛丌不丈() - 1);
        if(val_50 != null)
        {
            goto label_32;
        }
        
        return;
        label_30:
        val_49 = 0.与不丞丑七丘丁丂丛();
        label_31:
        丙且上东下丏丏丟下 val_26 = null;
        val_50 = val_26;
        val_26 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_49, 七丆丒与丗丌丄且丂:  val_17.万上丄下业丛丌不丈() - 1);
        val_47 = 0;
        if(val_50 == null)
        {
                return;
        }
        
        label_32:
        UnityEngine.Object val_28 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForEvent"));
        if(val_28 != null)
        {
                var val_29 = (null == null) ? (val_28) : 0;
        }
        
        ArmoryInfoScreenController val_30 = 0.GetComponent<ArmoryInfoScreenController>();
        this.下丏丗且丅丟丄丂与 = val_30;
        val_51 = null;
        val_51 = null;
        val_30.transform.parent = PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丌丟丄业且三丛丕丄();
        this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.transform.parent.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        val_52 = null;
        val_52 = null;
        val_54 = CellMailBoxReward.<>c.<>9__18_0;
        if(val_54 == null)
        {
                System.Action<UIPanel> val_41 = null;
            val_54 = val_41;
            val_41 = new System.Action<UIPanel>(object:  CellMailBoxReward.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CellMailBoxReward.<>c::下丝世丑丞与丏丞三(UIPanel 七丏丄丅丌业与且丙));
            CellMailBoxReward.<>c.<>9__18_0 = val_54;
        }
        
        UIPanel val_42 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIPanel>(丄三丅七丆丛与与上:  this.下丏丗且丅丟丄丂与.gameObject.GetComponent<UIPanel>(), 七丐丅专且专七三丆:  val_41);
        this.下丏丗且丅丟丄丂与.丙业丁丅丗万丞丙且 = true;
        this.下丏丗且丅丟丄丂与.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_26, 丁业丗丈丂七丟东与:  true, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
        if(val_47 != 0)
        {
                this.下丏丗且丅丟丄丂与.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  val_47);
        }
        
        this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.下丏丗且丅丟丄丂与.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void CellMailBoxReward::HidePreview()));
    }
    private void 世丅丘丌丗业丑丗且()
    {
        PGCompany.丟丝世万东万丆丟上 val_22;
        string val_23;
        .丝且与丝丒丟万丁专 = this;
        val_22 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  this.<丝业三丑三上丆专不>k__BackingField.Id);
        if(val_22 != null)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        val_22 = 0;
        label_5:
        三丅丁丗丗丝丂万且 val_7 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_22.上专丗丏丛丁专丑丄().WeaponIndex);
        if(val_7 != null)
        {
                val_23 = val_7.与不丞丑七丘丁丂丛();
        }
        else
        {
                val_23 = 0.与不丞丑七丘丁丂丛();
        }
        
        丙且上东下丏丏丟下 val_12 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_23, 七丆丒与丗丌丄且丂:  val_7.万上丄下业丛丌不丈() - 1);
        UnityEngine.GameObject val_14 = WeaponManager.丄丟上一上丐丄与丆(三不三丟专丘东东丂:  val_12.业上丙丞丐丄丆丅七());
        .丛丟三丘丛且业丈丏 = val_14.GetComponent<WeaponSounds>();
        丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_14, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  new CellMailBoxReward.业丂七丏丟丕丌丂世(), 丛丌丙世专世东丕下:  System.Void CellMailBoxReward.业丂七丏丟丕丌丂世::且丝下且东且专上下(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  val_12.丒万丕七专不丏丞丌(), 丐丑七万丌丂专与丌:  (CellMailBoxReward.业丂七丏丟丕丌丂世)[1152921525594675312].丛丟三丘丛且业丈丏);
        this.previewHolder.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.previewHolder.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        WeaponSkinChanger val_20 = this.previewHolder.GetComponentInChildren<WeaponSkinChanger>();
        if(val_20 != 0)
        {
                val_20.上丈一万东三东世东(三丕上下丗丘丌专丒:  val_22, 丄丕且丆与业下业下:  0);
        }
        
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.previewHolder, 不东丛三丂丌丑专丆:  10, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.previewHolder, 丏业丟一东丂东丘丛:  true);
    }
    public void HidePreview()
    {
        if(this.下丏丗且丅丟丄丂与 == 0)
        {
                return;
        }
        
        if(this.下丏丗且丅丟丄丂与.gameObject == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.下丏丗且丅丟丄丂与.gameObject);
        this.下丏丗且丅丟丄丂与 = 0;
    }
    internal void 丙丄东丆专三丛丙丅(bool 丙专丗丂丄丐丟七专)
    {
        丙专丗丂丄丐丟七专 = 丙专丗丂丄丐丟七专;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.collectedBanner, 丏业丟一东丂东丘丛:  丙专丗丂丄丐丟七专);
    }
    private void LateUpdate()
    {
        UIWidget val_23;
        var val_24;
        var val_25;
        float val_26;
        val_23 = this;
        if(this.scrollStartPoint == 0)
        {
                return;
        }
        
        if(this.scrollEndPoint == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().position;
        UnityEngine.Vector3 val_5 = this.scrollStartPoint.position;
        val_24 = this.丌丟丄业且三丛丕丄();
        if(val_4.y <= val_5.y)
        {
            goto label_9;
        }
        
        val_25 = null;
        goto label_12;
        label_9:
        UnityEngine.Vector3 val_7 = val_24.position;
        UnityEngine.Vector3 val_8 = this.scrollEndPoint.position;
        if(val_7.y >= 0)
        {
            goto label_15;
        }
        
        val_24 = this.丌丟丄业且三丛丕丄();
        val_25 = null;
        label_12:
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        label_30:
        val_24.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        val_23 = this.myWidget;
        return;
        label_15:
        UnityEngine.Vector3 val_11 = this.scrollStartPoint.position;
        UnityEngine.Vector3 val_13 = this.丌丟丄业且三丛丕丄().position;
        float val_22 = val_13.y;
        val_22 = val_11.y - val_22;
        UnityEngine.Vector3 val_15 = this.丌丟丄业且三丛丕丄().position;
        float val_23 = val_15.y;
        UnityEngine.Vector3 val_16 = this.scrollEndPoint.position;
        val_26 = val_23 - val_16.y;
        val_23 = (val_26 > val_22) ? (val_22) : (val_26);
        if(val_26 > val_22)
        {
                if(val_23 > this.detectedDistance)
        {
            goto label_25;
        }
        
        }
        
        if(val_26 > val_22)
        {
            goto label_27;
        }
        
        val_26 = this.detectedDistanceDownScroll;
        if(val_23 <= val_26)
        {
            goto label_27;
        }
        
        label_25:
        UnityEngine.Transform val_17 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
        goto label_30;
        label_27:
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        val_23 = val_23 * 6f;
        float val_20 = UnityEngine.Mathf.Min(a:  val_23, b:  1f);
        this.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
    }
    public CellMailBoxReward()
    {
    
    }

}
