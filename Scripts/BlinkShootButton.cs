using UnityEngine;
internal sealed class BlinkShootButton : MonoBehaviour
{
    // Fields
    internal static bool 丑丒三丅丄与丕三丟;
    internal static bool 丆丆业丈丗丆丞丁丐;
    public float maxTimerBlink;
    public UnityEngine.Color blinkColor;
    public UnityEngine.Color unBlinkColor;
    public UISprite[] blinkObjs;
    private bool 丄一丁上东专丘丌丌;
    private float 丝丐丞丄东专丕丒且;
    
    // Methods
    private void Start()
    {
        null = null;
        BlinkShootButton.丆丆业丈丗丆丞丁丐 = false;
        BlinkShootButton.丑丒三丅丄与丕三丟 = false;
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
        if(((this.丄一丁上东专丘丌丌 == true) ? 1 : 0) != ((BlinkShootButton.丆丆业丈丗丆丞丁丐 == true) ? 1 : 0))
        {
                this.丝丐丞丄东专丕丒且 = this.maxTimerBlink;
        }
        
        val_12 = null;
        if(BlinkShootButton.丆丆业丈丗丆丞丁丐 == false)
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
        bool val_12 = BlinkShootButton.丑丒三丅丄与丕三丟;
        val_15 = 0;
        val_16 = 1152921525504836676;
        val_12 = val_12 ^ 1;
        val_17 = this.unBlinkColor;
        val_18 = 1152921525504836692;
        BlinkShootButton.丑丒三丅丄与丕三丟 = val_12;
        val_19 = 1152921525504836696;
        goto label_10;
        label_17:
        val_20 = null;
        val_20 = null;
        val_13 = mem[BlinkShootButton.丑丒三丅丄与丕三丟 == true ? val_16 : val_18];
        val_13 = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? (val_16) : (val_18);
        val_21 = mem[BlinkShootButton.丑丒三丅丄与丕三丟 == true ? 1152921525504836680 : val_19];
        val_21 = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504836680 : (val_19);
        this.blinkObjs[0].color = new UnityEngine.Color() {r = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? this.blinkColor : (val_17), g = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504836672 : 1152921525504836688, b = val_13, a = val_21};
        val_15 = 1;
        label_10:
        if(val_15 < this.blinkObjs.Length)
        {
            goto label_17;
        }
        
        label_7:
        val_22 = null;
        val_22 = null;
        if(BlinkShootButton.丆丆业丈丗丆丞丁丐 == true)
        {
            goto label_23;
        }
        
        val_22 = null;
        if(BlinkShootButton.__il2cppRuntimeField_static_fields == false)
        {
            goto label_23;
        }
        
        BlinkShootButton.丑丒三丅丄与丕三丟 = false;
        val_24 = 0;
        val_16 = 1152921525504836676;
        val_17 = this.unBlinkColor;
        val_18 = 1152921525504836692;
        val_19 = 1152921525504836696;
        goto label_26;
        label_33:
        val_25 = null;
        val_25 = null;
        val_13 = mem[BlinkShootButton.丑丒三丅丄与丕三丟 == true ? val_16 : val_18];
        val_13 = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? (val_16) : (val_18);
        val_21 = mem[BlinkShootButton.丑丒三丅丄与丕三丟 == true ? 1152921525504836680 : val_19];
        val_21 = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504836680 : (val_19);
        this.blinkObjs[0].color = new UnityEngine.Color() {r = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? this.blinkColor : (val_17), g = (BlinkShootButton.丑丒三丅丄与丕三丟 == true) ? 1152921525504836672 : 1152921525504836688, b = val_13, a = val_21};
        val_24 = 1;
        label_26:
        if(val_24 < this.blinkObjs.Length)
        {
            goto label_33;
        }
        
        val_22 = null;
        label_23:
        val_22 = null;
        this.丄一丁上东专丘丌丌 = BlinkShootButton.丆丆业丈丗丆丞丁丐;
    }
    public BlinkShootButton()
    {
        this.maxTimerBlink = 0.5f;
        this.blinkColor = 0;
        mem[1152921525505104320] = 0;
        mem[1152921525505104328] = 0;
        this.unBlinkColor = 0;
        mem[1152921525505104336] = 0;
        mem[1152921525505104344] = 0;
    }
    private static BlinkShootButton()
    {
    
    }

}
