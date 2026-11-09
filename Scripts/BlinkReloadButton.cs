using UnityEngine;
internal sealed class BlinkReloadButton : MonoBehaviour
{
    // Fields
    internal static bool 下丄与一丁业丒业东;
    private bool 丕万丞东不专丛丏丕;
    private float 丝丐丞丄东专丕丒且;
    public float maxTimerBlink;
    public UnityEngine.Color blinkColor;
    public UnityEngine.Color unBlinkColor;
    internal static bool 丑丒三丅丄与丕三丟;
    public UISprite[] blinkObjs;
    public bool isBlinkTemp;
    
    // Methods
    private void Start()
    {
        null = null;
        BlinkReloadButton.下丄与一丁业丒业东 = false;
        BlinkReloadButton.丑丒三丅丄与丕三丟 = false;
    }
    private void Update()
    {
        var val_12;
        float val_13;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.Color val_17;
        var val_18;
        var val_19;
        var val_20;
        float val_21;
        var val_22;
        var val_24;
        var val_25;
        val_12 = null;
        val_12 = null;
        this.isBlinkTemp = BlinkReloadButton.下丄与一丁业丒业东;
        if(((this.丕万丞东不专丛丏丕 == true) ? 1 : 0) != ((BlinkReloadButton.下丄与一丁业丒业东 == true) ? 1 : 0))
        {
                this.丝丐丞丄东专丕丒且 = this.maxTimerBlink;
        }
        
        val_12 = null;
        if(BlinkReloadButton.下丄与一丁业丒业东 == false)
        {
            goto label_7;
        }
        
        val_13 = this.丝丐丞丄东专丕丒且;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_13 - val_3;
        this.丝丐丞丄东专丕丒且 = val_3;
        if(val_3 >= 0)
        {
            goto label_7;
        }
        
        this.丝丐丞丄东专丕丒且 = this.maxTimerBlink;
        val_14 = null;
        val_14 = null;
        bool val_12 = BlinkReloadButton.丑丒三丅丄与丕三丟;
        val_15 = 0;
        val_16 = 1152921525504077388;
        val_12 = val_12 ^ 1;
        val_17 = this.unBlinkColor;
        val_18 = 1152921525504077404;
        BlinkReloadButton.丑丒三丅丄与丕三丟 = val_12;
        val_19 = 1152921525504077408;
        goto label_10;
        label_17:
        val_20 = null;
        val_20 = null;
        val_13 = mem[BlinkReloadButton.丑丒三丅丄与丕三丟 == true ? val_16 : val_18];
        val_13 = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? (val_16) : (val_18);
        val_21 = mem[BlinkReloadButton.丑丒三丅丄与丕三丟 == true ? 1152921525504077392 : val_19];
        val_21 = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504077392 : (val_19);
        this.blinkObjs[0].color = new UnityEngine.Color() {r = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? this.blinkColor : (val_17), g = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504077384 : 1152921525504077400, b = val_13, a = val_21};
        val_15 = 1;
        label_10:
        if(val_15 < this.blinkObjs.Length)
        {
            goto label_17;
        }
        
        label_7:
        val_22 = null;
        val_22 = null;
        if(BlinkReloadButton.下丄与一丁业丒业东 == true)
        {
            goto label_23;
        }
        
        val_22 = null;
        if(BlinkReloadButton.丑丒三丅丄与丕三丟 == false)
        {
            goto label_23;
        }
        
        BlinkReloadButton.丑丒三丅丄与丕三丟 = false;
        val_24 = 0;
        val_16 = 1152921525504077388;
        val_17 = this.unBlinkColor;
        val_18 = 1152921525504077404;
        val_19 = 1152921525504077408;
        goto label_26;
        label_33:
        val_25 = null;
        val_25 = null;
        val_13 = mem[BlinkReloadButton.丑丒三丅丄与丕三丟 == true ? val_16 : val_18];
        val_13 = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? (val_16) : (val_18);
        val_21 = mem[BlinkReloadButton.丑丒三丅丄与丕三丟 == true ? 1152921525504077392 : val_19];
        val_21 = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504077392 : (val_19);
        this.blinkObjs[0].color = new UnityEngine.Color() {r = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? this.blinkColor : (val_17), g = (BlinkReloadButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504077384 : 1152921525504077400, b = val_13, a = val_21};
        val_24 = 1;
        label_26:
        if(val_24 < this.blinkObjs.Length)
        {
            goto label_33;
        }
        
        val_22 = null;
        label_23:
        val_22 = null;
        this.丕万丞东不专丛丏丕 = BlinkReloadButton.下丄与一丁业丒业东;
    }
    public BlinkReloadButton()
    {
        this.maxTimerBlink = 0.5f;
        this.blinkColor = 0;
        mem[1152921525504345032] = 0;
        mem[1152921525504345040] = 0;
        this.unBlinkColor = 0;
        mem[1152921525504345048] = 0;
        mem[1152921525504345056] = 0;
    }
    private static BlinkReloadButton()
    {
    
    }

}
