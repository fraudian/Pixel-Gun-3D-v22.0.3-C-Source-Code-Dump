using UnityEngine;
public class CameraFacingBilloard : PGBehaviour
{
    // Fields
    public bool Invert;
    private RilisoftBot.BotHpIndicator 东丄与丛丂丘丝三丝;
    private bool 一丟且世丛万丒世丁;
    private bool UseCustomCamera;
    private UnityEngine.Transform customCamera;
    public bool onlyYRotation;
    public static bool allowBacklighting;
    public bool BacklitBillboard;
    private UnityEngine.Color 丑丑丗丅专与世丈且;
    public UnityEngine.MeshRenderer billboardRender;
    public float backlitFadeSpeed;
    public bool hideByCamouflage;
    private bool 丅不丛世丗丒丈万业;
    private float 丏丅且丄丘丘丅且丙;
    private UnityEngine.Material 世丑丘丘丂专丅丆与;
    
    // Properties
    public float 不丂三且丄丈丞丐七 { get; set; }
    
    // Methods
    public float get_billboardAlpha()
    {
        return (float)this.丏丅且丄丘丘丅且丙;
    }
    public void set_billboardAlpha(float 丙业与丙丗丝不丈东)
    {
        this.丏丅且丄丘丘丅且丙 = UnityEngine.Mathf.Clamp01(value:  丙业与丙丗丝不丈东);
        if(与丂丏丛丞丞丒丟丄.丑不丛丏三丛丁上丈().世三丞丅丑丌丈丈一() == false)
        {
                return;
        }
        
        this.丏丅且丄丘丘丅且丙 = UnityEngine.Mathf.Min(a:  0.5f, b:  this.丏丅且丄丘丘丅且丙);
    }
    private void Awake()
    {
        RilisoftBot.BotHpIndicator val_1 = this.GetComponent<RilisoftBot.BotHpIndicator>();
        this.东丄与丛丂丘丝三丝 = val_1;
        this.一丟且世丛万丒世丁 = UnityEngine.Object.op_Inequality(x:  val_1, y:  0);
        if(((this.BacklitBillboard != false) && (this.billboardRender != 0)) && (this.billboardRender.sharedMaterial != 0))
        {
                if(this.丞业丒丂下丆丅丗丐() != false)
        {
                UnityEngine.Material val_8 = this.billboardRender.material;
            this.世丑丘丘丂专丅丆与 = val_8;
            this.billboardRender.sharedMaterial = val_8;
            UnityEngine.Color val_9 = this.世丑丘丘丂专丅丆与.GetColor(name:  "_TintColor");
            this.丑丑丗丅专与世丈且 = val_9;
            mem[1152921525572961008] = val_9.g;
            mem[1152921525572961012] = val_9.b;
            mem[1152921525572961016] = val_9.a;
        }
        
        }
        
        if(this.丞业丒丂下丆丅丗丐() == true)
        {
                return;
        }
        
        if(this.BacklitBillboard == false)
        {
                return;
        }
        
        this.billboardRender.gameObject.SetActive(value:  false);
        this.gameObject.SetActive(value:  false);
    }
    public void ForceBlockingBacklight(bool 三丟东丕丄丄下下丑)
    {
        this.丅不丛世丗丒丈万业 = 三丟东丕丄丄下下丑;
    }
    private void LateUpdate()
    {
        if(this.一丟且世丛万丒世丁 != false)
        {
                if(this.东丄与丛丂丘丝三丝.丝丕丘丅丁丕七丞丘() != true)
        {
                if(this.东丄与丛丂丘丝三丝.三丕万丕丈丄丄丗万 == false)
        {
                return;
        }
        
        }
        
        }
        
        this.上丛一丗丝万万七丆();
        this.丐业业丒丌丂丕上丒();
    }
    private bool 丞业丒丂下丆丅丗丐()
    {
        var val_9;
        var val_10;
        bool val_11;
        val_9 = null;
        val_9 = null;
        if(GameConnect.丈丝丂丐丟万丙丑丕 != null)
        {
                PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_1 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  25);
            if(val_1 != null)
        {
                if((val_1.丛丅下丆丗丏三丁丕<System.Boolean>(丒丑丂丐丕丒丕东与:  "bool")) == true)
        {
            goto label_20;
        }
        
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = CameraFacingBilloard.allowBacklighting;
        if(val_11 == false)
        {
                return (bool)val_11 & 1;
        }
        
        if((GameConnect.丙丌丒丈东七丒上丌() != true) && (GameConnect.万不丒丌丙万丗东不() != true))
        {
                if((GameConnect.丝丆世丕丂丄万东且() != true) && (this.丅不丛世丗丒丈万业 != true))
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_23;
        }
        
        }
        
        }
        
        label_20:
        val_11 = 0;
        return (bool)val_11 & 1;
        label_23:
        bool val_9 = GameConnect.一业上七丟业且业丙() ^ 1;
        return (bool)val_11 & 1;
    }
    internal void 丐业业丒丌丂丕上丒()
    {
        if(this.BacklitBillboard == false)
        {
                return;
        }
        
        if(this.丞业丒丂下丆丅丗丐() == false)
        {
                return;
        }
        
        if(this.hideByCamouflage != false)
        {
            
        }
        else
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_2 * this.backlitFadeSpeed;
            val_2 = this.丏丅且丄丘丘丅且丙 - val_2;
        }
        
        this.billboardAlpha = val_2;
        this.世丑丘丘丂专丅丆与.SetColor(name:  "_TintColor", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
    }
    internal void 上丛一丗丝万万七丆()
    {
        var val_16;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        float val_27;
        float val_28;
        var val_29;
        val_16 = this;
        if(this.UseCustomCamera == false)
        {
            goto label_1;
        }
        
        if(this.onlyYRotation == false)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_1 = this.customCamera.forward;
        val_20 = val_1.x;
        UnityEngine.Transform val_2 = this.丌丟丄业且三丛丕丄();
        val_21 = 0f;
        val_22 = val_20;
        val_23 = val_1.z;
        goto label_5;
        label_1:
        val_24 = 1152921505207164928;
        val_25 = null;
        val_25 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                return;
        }
        
        if(this.onlyYRotation == false)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
        val_26 = null;
        val_26 = null;
        UnityEngine.Vector3 val_7 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        val_27 = val_7.x;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_27, y = val_7.y, z = val_7.z});
        val_20 = val_8.x;
        val_28 = val_8.z;
        val_22 = val_20;
        val_21 = val_8.y;
        val_23 = val_28;
        label_5:
        this.丌丟丄业且三丛丕丄().forward = new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_23};
        goto label_20;
        label_2:
        if(this.customCamera != null)
        {
            goto label_31;
        }
        
        label_32:
        label_31:
        val_24 = this.customCamera.transform;
        UnityEngine.Quaternion val_12 = val_24.rotation;
        val_20 = val_12.x;
        val_28 = val_12.z;
        val_22 = val_20;
        val_21 = val_12.y;
        val_23 = val_28;
        val_27 = val_12.w;
        this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_22, y = val_21, z = val_23, w = val_27};
        label_20:
        if(this.Invert == false)
        {
                return;
        }
        
        val_16 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Quaternion val_14 = val_16.rotation;
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, rhs:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_20 = val_15.x;
        val_28 = val_15.z;
        val_16.rotation = new UnityEngine.Quaternion() {x = val_20, y = val_15.y, z = val_28, w = val_15.w};
        return;
        label_11:
        val_29 = null;
        val_29 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 != null)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    public CameraFacingBilloard()
    {
        this.backlitFadeSpeed = 0.5f;
    }
    private static CameraFacingBilloard()
    {
    
    }

}
