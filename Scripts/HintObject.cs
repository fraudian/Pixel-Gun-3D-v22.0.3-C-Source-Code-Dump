using UnityEngine;
internal class HintObject : PGBehaviour
{
    // Fields
    public UILabel label;
    public UnityEngine.Transform arrow;
    private HintController.HintItem 丐不一三世丞丛丐丌;
    private UIWidget.七丐与七丌不丂丞且 丕丘东丄丆下丞丈丕;
    private bool 丌东丁丈七一业专万;
    private bool 丟丗业一与下丞东丏;
    private float 万一万丄丞丆上丈且;
    
    // Properties
    internal HintController.HintItem 丝丝丏世丄丝丘下万 { get; }
    
    // Methods
    internal HintController.HintItem 丈丑丑东万丒一丁丐()
    {
        return (HintItem)this.丐不一三世丞丛丐丌;
    }
    private void Awake()
    {
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void HintObject::丞丛一丙丂世丈丅丗()));
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void HintObject::丞丛一丙丂世丈丅丗()));
    }
    private void 丞丛一丙丂世丈丅丗()
    {
        if(this.丐不一三世丞丛丐丌 == null)
        {
                return;
        }
        
        this.专丅丁万世七丒丑丕(丙不丈东丒下三丛丁:  this.丐不一三世丞丛丐丌);
    }
    internal void 专丅丁万世七丒丑丕(HintController.HintItem 丙不丈东丒下三丛丁)
    {
        float val_20;
        float val_21;
        float val_22;
        var val_27;
        float val_31;
        float val_32;
        float val_33;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(丙不丈东丒下三丛丁.showLabelByCode == false)
        {
            goto label_2;
        }
        
        if(val_1 != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        val_1.SetActive(value:  (0 != 0) ? 1 : 0);
        this.transform.parent = 丙不丈东丒下三丛丁.target.transform;
        val_20 = 丙不丈东丒下三丛丁.relativeHintPosition;
        val_21 = V9.16B;
        val_22 = V10.16B;
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        this.label.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丙不丈东丒下三丛丁.hintText);
        if(丙不丈东丒下三丛丁.manualRotateArrow == false)
        {
            goto label_10;
        }
        
        val_20 = 丙不丈东丒下三丛丁.manualArrowRotation;
        val_21 = 丙不丈东丒下三丛丁.relativeHintPosition;
        val_22 = V9.16B;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22});
        goto label_13;
        label_2:
        val_27 = null;
        val_27 = null;
        bool val_20 = HintController.不丆世丛专丐丑上不;
        val_20 = val_20 ^ 1;
        bool val_8 = val_20 & 255;
        if(val_1 != null)
        {
            goto label_16;
        }
        
        goto label_17;
        label_10:
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        label_13:
        this.arrow.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
        if(丙不丈东丒下三丛丁.manualLabelPivot == false)
        {
            goto label_21;
        }
        
        if(this.丌东丁丈七一业专万 != true)
        {
                this.丕丘东丄丆下丞丈丕 = this.label.pivot;
            this.丌东丁丈七一业专万 = true;
        }
        
        if(this.label != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        this.label.pivot = 丙不丈东丒下三丛丁.labelPivot;
        label_39:
        this.label.transform.localPosition = new UnityEngine.Vector3() {x = 丙不丈东丒下三丛丁.relativeLabelPosition, y = val_9.y, z = val_9.z};
        UnityEngine.Vector3 val_13 = this.label.transform.localPosition;
        if(val_13.x > 0f)
        {
                val_31 = 0f;
            val_32 = 0f;
            val_33 = 0f;
        }
        else
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            val_31 = val_14.x;
            val_32 = val_14.y;
            val_33 = val_14.z;
        }
        
        this.arrow.localScale = new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_33};
        this.丐不一三世丞丛丐丌 = 丙不丈东丒下三丛丁;
        this.万一万丄丞丆上丈且 = UnityEngine.Time.time;
        if(丙不丈东丒下三丛丁.scaleTween == false)
        {
            goto label_35;
        }
        
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  0.3f);
        goto label_38;
        label_21:
        if(this.丌东丁丈七一业专万 == false)
        {
            goto label_39;
        }
        
        if(this.label != null)
        {
            goto label_40;
        }
        
        goto label_41;
        label_35:
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        label_38:
        this.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
    }
    public void Hide()
    {
        HintItem val_3;
        string val_4;
        val_3 = this.丐不一三世丞丛丐丌;
        if((val_3 == null) || (this.丐不一三世丞丛丐丌.indicateTarget == false))
        {
            goto label_12;
        }
        
        if((this.丐不一三世丞丛丐丌.targetSprites == null) || (this.丐不一三世丞丛丐丌.targetSprites.Length == 0))
        {
            goto label_3;
        }
        
        val_4 = 0;
        goto label_4;
        label_11:
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.丐不一三世丞丛丐丌.targetSprites[0].color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        val_3 = this.丐不一三世丞丛丐丌;
        val_4 = 1;
        label_4:
        if(val_4 < this.丐不一三世丞丛丐丌.targetSprites.Length)
        {
            goto label_11;
        }
        
        goto label_12;
        label_3:
        val_4 = this.丐不一三世丞丛丐丌.defaultSpriteName;
        this.丐不一三世丞丛丐丌.targetSprite.spriteName = val_4;
        label_12:
        this.丐不一三世丞丛丐丌 = 0;
        this.gameObject.SetActive(value:  false);
    }
    private void Update()
    {
        var val_14;
        float val_15;
        float val_16;
        float val_17;
        string val_18;
        float val_23;
        HintItem val_24;
        UISprite val_25;
        val_14 = this;
        if(this.丐不一三世丞丛丐丌.indicateTarget == false)
        {
            goto label_19;
        }
        
        val_15 = this.万一万丄丞丆上丈且;
        float val_1 = UnityEngine.Time.time;
        if(val_15 >= 0)
        {
            goto label_19;
        }
        
        bool val_16 = this.丟丗业一与下丞东丏;
        val_16 = 0.5f;
        val_17 = UnityEngine.Time.time + val_16;
        val_16 = val_16 ^ 1;
        this.万一万丄丞丆上丈且 = val_17;
        this.丟丗业一与下丞东丏 = val_16;
        if((this.丐不一三世丞丛丐丌.targetSprites == null) || (this.丐不一三世丞丛丐丌.targetSprites.Length == 0))
        {
            goto label_8;
        }
        
        val_18 = 0;
        goto label_9;
        label_18:
        if(this.丟丗业一与下丞东丏 != false)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.green;
        }
        else
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
        
        val_15 = val_4.r;
        val_23 = val_4.b;
        val_17 = val_15;
        val_16 = val_4.g;
        this.丐不一三世丞丛丐丌.targetSprites[0].color = new UnityEngine.Color() {r = val_17, g = val_16, b = val_23, a = val_4.a};
        val_18 = 1;
        label_9:
        if(val_18 < this.丐不一三世丞丛丐丌.targetSprites.Length)
        {
            goto label_18;
        }
        
        goto label_19;
        label_8:
        val_24 = this.丐不一三世丞丛丐丌;
        if(val_24 != null)
        {
                val_25 = this.丐不一三世丞丛丐丌.targetSprite;
            var val_5 = (this.丟丗业一与下丞东丏 == true) ? 1 : 0;
        }
        else
        {
                val_25 = this.丐不一三世丞丛丐丌.targetSprite;
            if(this.丐不一三世丞丛丐丌 != null)
        {
                val_24 = this.丐不一三世丞丛丐丌;
        }
        else
        {
                val_24 = 0;
        }
        
        }
        
        val_18 = mem[val_6 != 0x0 ? (val_24 + 152) : (val_24 + 168)];
        val_18 = (((this.丟丗业一与下丞东丏 == true) ? 1 : 0) != 0) ? (val_24 + 152) : (val_24 + 168);
        val_25.spriteName = val_18;
        label_19:
        if(this.丐不一三世丞丛丐丌.scaleTween == false)
        {
                return;
        }
        
        val_14 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_12 = val_14.localScale;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  UnityEngine.Time.unscaledDeltaTime * 3f);
        val_15 = val_15.x;
        val_23 = val_15.z;
        this.丌丟丄业且三丛丕丄().localScale = new UnityEngine.Vector3() {x = val_15, y = val_15.y, z = val_23};
    }
    public HintObject()
    {
    
    }

}
