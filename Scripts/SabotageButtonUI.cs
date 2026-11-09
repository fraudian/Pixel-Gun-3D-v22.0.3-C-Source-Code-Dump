using UnityEngine;
public sealed class SabotageButtonUI : PGBehaviour
{
    // Fields
    private UIWidget buttonWidget;
    private UILabel timeLockLabel;
    private UIButton readySabotageButton;
    private UnityEngine.GameObject cooldownStateObject;
    private UISprite fillCooldown;
    private float 丑丐丘与三丕上万与;
    private float 丞丁上丞三丄丁丟丈;
    private bool 七上下七丑三七万丈;
    private bool 万丒丆丙丛不丄万上;
    private bool 七丑丞丝世上三且丂;
    private bool 东丂丆丂上与丌专万;
    private UnityEngine.Vector3 丑丑丘三丅三丗丅丏;
    private UnityEngine.Vector4 一且丙丈丕丏丂三丐;
    
    // Properties
    private UnityEngine.Vector4 世下丁丁丑丑业丂丞 { get; }
    
    // Methods
    private UnityEngine.Vector4 不丙丛万业丂下且丙()
    {
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.Vector4 val_15;
        var val_16;
        var val_17;
        var val_18;
        if(this.东丂丆丂上与丌专万 == false)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.buttonWidget.transform.position;
        val_11 = val_2.x;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_11, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = this.丑丑丘三丅三丗丅丏, y = V11.16B, z = V10.16B})) == false)
        {
            goto label_6;
        }
        
        label_1:
        if(null == null)
        {
                val_12 = 0;
        }
        
        if(null == null)
        {
                val_13 = 0;
        }
        
        if(null <= 2)
        {
                val_14 = 0;
        }
        
        val_15 = this;
        this.一且丙丈丕丏丂三丐 = 0;
        this.东丂丆丂上与丌专万 = true;
        val_16 = 1152921537612324284;
        val_17 = 1152921537612324288;
        val_18 = 1152921537612324292;
        UnityEngine.Vector3 val_5 = this.buttonWidget.transform.position;
        this.丑丑丘三丅三丗丅丏 = val_5;
        mem[1152921537612324272] = val_5.y;
        mem[1152921537612324276] = val_5.z;
        return new UnityEngine.Vector4() {x = this.一且丙丈丕丏丂三丐.x, y = 8.053589E-18f, z = 8.053589E-18f, w = 8.053589E-18f};
        label_6:
        val_15 = this.一且丙丈丕丏丂三丐;
        val_16 = 1152921537612324284;
        val_17 = 1152921537612324288;
        val_18 = 1152921537612324292;
        return new UnityEngine.Vector4() {x = this.一且丙丈丕丏丂三丐.x, y = 8.053589E-18f, z = 8.053589E-18f, w = 8.053589E-18f};
    }
    private void Start()
    {
        UISprite val_4 = this.fillCooldown;
        this.万丒丆丙丛不丄万上 = UnityEngine.Object.op_Inequality(x:  this.timeLockLabel, y:  0);
        val_4 = UnityEngine.Object.op_Inequality(x:  val_4, y:  0);
        this.七丑丞丝世上三且丂 = val_4;
    }
    internal void 丗业丏丏丆丄丗丗且(EventDelegate 一下下万专丒丞丅丈)
    {
        this.readySabotageButton.onClick.Clear();
        this.readySabotageButton.onClick.Add(item:  一下下万专丒丞丅丈);
    }
    internal void 丁丛丄丞丌丂丄且一(float 丂三丟丂丈丐丆丗丟)
    {
        this.丑丐丘与三丕上万与 = UnityEngine.Time.timeSinceLevelLoad;
        if(this.七上下七丑三七万丈 != false)
        {
                if(this.丞丁上丞三丄丁丟丈 >= 0)
        {
            goto label_2;
        }
        
        }
        
        this.丞丁上丞三丄丁丟丈 = 丂三丟丂丈丐丆丗丟;
        label_2:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timeLockLabel, 丏业丟一东丂东丘丛:  true);
        this.七上下七丑三七万丈 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.readySabotageButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cooldownStateObject, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丒丝丅丟丛丆与丒丟()
    {
        this.丑丐丘与三丕上万与 = -1f;
        this.丞丁上丞三丄丁丟丈 = -1f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timeLockLabel, 丏业丟一东丂东丘丛:  false);
        this.七上下七丑三七万丈 = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.readySabotageButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cooldownStateObject, 丏业丟一东丂东丘丛:  false);
    }
    private void Update()
    {
        if(this.七上下七丑三七万丈 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.timeSinceLevelLoad;
        float val_2 = val_1 - this.丑丐丘与三丕上万与;
        if(val_2 < 0)
        {
                if(this.万丒丆丙丛不丄万上 != false)
        {
                val_1 = this.丞丁上丞三丄丁丟丈 - val_2;
            this.timeLockLabel.text = (int)val_1.ToString();
        }
        
            if(this.七丑丞丝世上三且丂 == false)
        {
                return;
        }
        
            float val_4 = val_2 / this.丞丁上丞三丄丁丟丈;
            val_4 = 1f - val_4;
            this.fillCooldown.fillAmount = val_4;
            return;
        }
        
        this.丒丝丅丟丛丆与丒丟();
    }
    internal bool 一丁且上丛丛丐下丛(UnityEngine.Vector3 一丁丂东丏丙上丟且)
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return false;
        }
        
        if(this.buttonWidget == 0)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_4 = this.不丙丛万业丂下且丙();
        if(一丁丂东丏丙上丟且.x < val_4.x)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_5 = this.不丙丛万业丂下且丙();
        if(一丁丂东丏丙上丟且.y < val_5.y)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_6 = this.不丙丛万业丂下且丙();
        if(一丁丂东丏丙上丟且.x > val_6.z)
        {
                return false;
        }
        
        UnityEngine.Vector4 val_7 = this.不丙丛万业丂下且丙();
        var val_8 = (一丁丂东丏丙上丟且.y <= val_7.w) ? 1 : 0;
        return false;
    }
    public SabotageButtonUI()
    {
        this.丑丐丘与三丕上万与 = -1f;
        this.丞丁上丞三丄丁丟丈 = -1f;
    }

}
