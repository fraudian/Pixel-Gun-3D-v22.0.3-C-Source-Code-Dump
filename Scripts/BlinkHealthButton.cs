using UnityEngine;
public sealed class BlinkHealthButton : MonoBehaviour
{
    // Fields
    public BlinkHealthButton.不且七丂且丆东丈专 typeButton;
    internal static bool 下丄与一丁业丒业东;
    private bool 丕万丞东不专丛丏丕;
    public float timerBlink;
    public float maxTimerBlink;
    public UnityEngine.Color blinkColor;
    public UnityEngine.Color unBlinkColor;
    public bool isBlinkState;
    public UISprite[] blinkObjs;
    public bool isBlinkTemp;
    public UISprite shine;
    private Player_move_c 七丈且三三丑丗丁东;
    private UnityEngine.Color 且丝丑万丞专一丁丄;
    
    // Methods
    private void Start()
    {
        null = null;
        BlinkHealthButton.下丄与一丁业丒业东 = false;
        this.isBlinkState = false;
        this.且丝丑万丞专一丁丄 = 0;
        mem[1152921525502586772] = 0;
        mem[1152921525502586780] = 0;
    }
    private void Update()
    {
        var val_21;
        var val_22;
        Player_move_c val_23;
        不且七丂且丆东丈专 val_24;
        float val_25;
        var val_27;
        var val_28;
        UnityEngine.Color val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        UnityEngine.Color val_35;
        var val_36;
        var val_37;
        var val_38;
        if(this.七丈且三三丑丗丁东 != 0)
        {
            goto label_13;
        }
        
        val_21 = null;
        val_21 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_6;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        goto label_10;
        label_6:
        UnityEngine.GameObject val_2 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
        if(val_2 == 0)
        {
            goto label_13;
        }
        
        SkinName val_4 = val_2.GetComponent<SkinName>();
        val_23 = val_4.playerMoveC;
        label_10:
        this.七丈且三三丑丗丁东 = val_23;
        label_13:
        if(this.七丈且三三丑丗丁东 == 0)
        {
                return;
        }
        
        val_24 = this.typeButton;
        if(val_24 != 0)
        {
            goto label_19;
        }
        
        val_25 = this.七丈且三三丑丗丁东.丘七业丒丐世丂丅丒();
        float val_7 = this.七丈且三三丑丗丁东.与丙丕丛一丌丛丆丈.丈下丏丟丑丐丆三不();
        val_7 = val_25 + val_7;
        if(val_7 < 0)
        {
                if(this.七丈且三三丑丗丁东.东丗丒丝丐且丞丄丏 == false)
        {
            goto label_61;
        }
        
        }
        
        label_61:
        BlinkHealthButton.下丄与一丁业丒业东 = false;
        val_24 = this.typeButton;
        label_19:
        if(val_24 != 1)
        {
            goto label_28;
        }
        
        val_27 = null;
        val_27 = null;
        三丈丟与丏丘丈丐万 val_10 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if((val_10.下世万丆丛专丒丑丙() != 0) || (val_10.东东丄丅丐一丙一业() != 0))
        {
            goto label_42;
        }
        
        if(val_10.三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_10.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_42;
        }
        
        }
        
        if(this.七丈且三三丑丗丁东.东丗丒丝丐且丞丄丏 == false)
        {
            goto label_78;
        }
        
        label_42:
        label_78:
        BlinkHealthButton.下丄与一丁业丒业东 = false;
        label_28:
        val_28 = null;
        val_28 = null;
        this.isBlinkTemp = BlinkHealthButton.下丄与一丁业丒业东;
        if(((this.丕万丞东不专丛丏丕 == true) ? 1 : 0) != ((BlinkHealthButton.下丄与一丁业丒业东 == true) ? 1 : 0))
        {
                this.timerBlink = this.maxTimerBlink;
        }
        
        val_28 = null;
        if(BlinkHealthButton.下丄与一丁业丒业东 != false)
        {
                val_25 = this.timerBlink;
            float val_17 = UnityEngine.Time.deltaTime;
            val_17 = val_25 - val_17;
            this.timerBlink = val_17;
            if(val_17 < 0)
        {
                this.timerBlink = this.maxTimerBlink;
            this.isBlinkState = this.isBlinkState ^ 1;
            if(this.shine != 0)
        {
                if(this.isBlinkState != false)
        {
                val_29 = this.blinkColor;
            val_30 = 1152921525502781644;
            val_31 = 1152921525502781648;
            val_32 = 1152921525502781652;
        }
        else
        {
                val_29 = this.且丝丑万丞专一丁丄;
            val_30 = 1152921525502781716;
            val_31 = 1152921525502781720;
            val_32 = 1152921525502781724;
        }
        
            this.shine.color = new UnityEngine.Color() {r = this.且丝丑万丞专一丁丄.r, g = 2.26053E-23f, b = 2.26053E-23f, a = 2.26053E-23f};
        }
        
        }
        
        }
        
        val_33 = null;
        val_33 = null;
        if(BlinkHealthButton.下丄与一丁业丒业东 == false)
        {
            goto label_65;
        }
        
        label_75:
        val_34 = null;
        val_34 = null;
        this.丕万丞东不专丛丏丕 = BlinkHealthButton.下丄与一丁业丒业东;
        return;
        label_65:
        if(this.isBlinkState == false)
        {
            goto label_75;
        }
        
        this.isBlinkState = false;
        if(this.shine == 0)
        {
            goto label_75;
        }
        
        if(this.isBlinkState != false)
        {
                val_35 = this.blinkColor;
            val_36 = 1152921525502781644;
            val_37 = 1152921525502781648;
            val_38 = 1152921525502781652;
        }
        else
        {
                val_35 = this.且丝丑万丞专一丁丄;
            val_36 = 1152921525502781716;
            val_37 = 1152921525502781720;
            val_38 = 1152921525502781724;
        }
        
        this.shine.color = new UnityEngine.Color() {r = this.且丝丑万丞专一丁丄.r, g = 2.26053E-23f, b = 2.26053E-23f, a = 2.26053E-23f};
        goto label_75;
    }
    public BlinkHealthButton()
    {
        this.maxTimerBlink = 0.5f;
        this.blinkColor = 0;
        mem[1152921525502975564] = 0;
        mem[1152921525502975572] = 0;
        this.unBlinkColor = 0;
        mem[1152921525502975580] = 0;
        mem[1152921525502975588] = 0;
    }
    private static BlinkHealthButton()
    {
    
    }

}
