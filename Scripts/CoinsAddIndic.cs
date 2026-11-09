using UnityEngine;
public class CoinsAddIndic : MonoBehaviour
{
    // Fields
    public UnityEngine.Color normalColor;
    public UnityEngine.Color normalX3Color;
    public UnityEngine.Color blinkCoinsColor;
    public UnityEngine.Color blinkGemsColor;
    public bool stopBlinkingOnEnable;
    public bool isGems;
    public bool isPixelBucks;
    public bool isX3;
    private UISprite 丘丑且三丙丐一丗丄;
    private bool 丞与下世丈丈丆丑丒;
    public bool remembeState;
    private int 丘与丏丁一丂七世丅;
    
    // Properties
    private UISprite 丝丙业丁丟万丑丌专 { get; }
    private UnityEngine.Color 丝三东三丆不业丞业 { get; }
    
    // Methods
    private UISprite 专丘万丅丞丅万一丈()
    {
        UISprite val_3;
        if(this.丘丑且三丙丐一丗丄 == 0)
        {
                this.丘丑且三丙丐一丗丄 = this.GetComponent<UISprite>();
            return val_3;
        }
        
        val_3 = this.丘丑且三丙丐一丗丄;
        return val_3;
    }
    private void Start()
    {
        if(this.remembeState == false)
        {
                return;
        }
        
        mem[1152921525754879680] = this;
        mem[1152921525754879688] = System.Void CoinsAddIndic::且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525754879664] = System.Void CoinsAddIndic::且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
        mem[1152921525754883776] = this;
        mem[1152921525754883784] = System.Void CoinsAddIndic::且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525754883760] = System.Void CoinsAddIndic::且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.下丗丑且专丝丈丁三(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
    }
    private void OnEnable()
    {
        UnityEngine.Color val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        string val_13;
        var val_14;
        mem[1152921525755027520] = this;
        mem[1152921525755027528] = System.Void CoinsAddIndic::下三不一丗不业丝且(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525755027504] = System.Void CoinsAddIndic::下三不一丗不业丝且(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.下丗丑且专丝丈丁三(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
        PreviewOfferPackController.与丐丁丕丒丁上丄丏(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<Rilisoft.OfferItem>>(object:  this, method:  System.Void CoinsAddIndic::下三不一丗不业丝且(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)));
        if(this.专丘万丅丞丅万一丈() != 0)
        {
                if(this.isX3 != false)
        {
                val_7 = this.normalX3Color;
            val_8 = 1152921525754995532;
            val_9 = 1152921525754995536;
            val_10 = 1152921525754995540;
        }
        else
        {
                val_7 = this.normalColor;
            val_8 = 1152921525754995516;
            val_9 = 1152921525754995520;
            val_10 = 1152921525754995524;
        }
        
            this.专丘万丅丞丅万一丈().color = new UnityEngine.Color() {r = this.normalColor.r, g = 5.477487E-23f, b = 5.477487E-23f, a = 5.477487E-23f};
        }
        
        if(this.丘与丏丁一丂七世丅 >= 1)
        {
                this.丞与下世丈丈丆丑丒 = false;
            val_11 = null;
            if(this.丘与丏丁一丂七世丅 == 1)
        {
                val_12 = null;
            val_13 = 1152921505171281160;
        }
        else
        {
                val_14 = null;
            val_13 = 1152921505171281152;
        }
        
            this.下三不一丗不业丝且(丏丂不专上丘丂不丅:  val_13, 丌丒丝东丌下丕丁丅:  0);
            this.丘与丏丁一丂七世丅 = 0;
        }
        
        if(this.丞与下世丈丈丆丑丒 == false)
        {
            goto label_14;
        }
        
        if(this.stopBlinkingOnEnable == true)
        {
            goto label_15;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丅与丅丝丈世丑丐丗());
        return;
        label_14:
        if(this.stopBlinkingOnEnable == false)
        {
                return;
        }
        
        label_15:
        this.丞与下世丈丈丆丑丒 = false;
    }
    private void OnDisable()
    {
        mem[1152921525755172288] = this;
        mem[1152921525755172296] = System.Void CoinsAddIndic::下三不一丗不业丝且(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525755172272] = System.Void CoinsAddIndic::下三不一丗不业丝且(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
        PreviewOfferPackController.丂丙丏丏七不世丈丅(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<Rilisoft.OfferItem>>(object:  this, method:  System.Void CoinsAddIndic::下三不一丗不业丝且(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)));
    }
    private void OnDestroy()
    {
        if(this.remembeState == false)
        {
                return;
        }
        
        mem[1152921525755296576] = this;
        mem[1152921525755296584] = System.Void CoinsAddIndic::且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        mem[1152921525755296560] = System.Void CoinsAddIndic::且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅);
        CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与());
    }
    private void 下三不一丗不业丝且(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)
    {
        var val_3;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = this;
        List.Enumerator<T> val_1 = 丞丑丘丂不不丝丈丞.GetEnumerator();
        label_13:
        if(((-326290336) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        val_12 = null;
        val_12 = null;
        val_13 = 0;
        if((System.String.op_Equality(a:  val_4.Id, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == true)
        {
            goto label_6;
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = 0;
        if((System.String.op_Equality(a:  val_4.Id, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_13;
        }
        
        label_6:
        int val_10 = val_4.Count;
        this.下三不一丗不业丝且(丏丂不专上丘丂不丅:  val_4.Id, 丌丒丝东丌下丕丁丅:  0);
        goto label_13;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 下三不一丗不业丝且(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  "BattlePassCurrency")) == true)
        {
                return;
        }
        
        bool val_9 = this.丞与下世丈丈丆丑丒;
        val_9 = val_9 + 3;
        var val_10 = ~val_9;
        val_10 = val_10 & 3;
        if(val_10 != 0)
        {
                return;
        }
        
        if(this.isGems == false)
        {
            goto label_3;
        }
        
        val_10 = 0;
        label_14:
        val_11 = null;
        val_11 = null;
        val_12 = System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        label_15:
        val_13 = mem[this.isPixelBucks];
        val_13 = this.isPixelBucks;
        if(val_13 == true)
        {
            goto label_6;
        }
        
        goto label_7;
        label_3:
        if(this.isPixelBucks != true)
        {
            goto label_8;
        }
        
        val_12 = 0;
        val_10 = 0;
        label_6:
        val_14 = null;
        val_14 = null;
        val_13 = System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  丐丏七丈且丌丄三丏.丆丝丙丛万三丐丂世);
        label_7:
        val_13 = (val_12 | val_10) | val_13;
        if(val_13 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丅与丅丝丈世丑丐丗());
        return;
        label_8:
        val_15 = null;
        val_15 = null;
        bool val_8 = System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        if(this.isGems == true)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    private UnityEngine.Color 丐业丅丒丅丁丞且丝()
    {
        UnityEngine.Color val_1;
        var val_2;
        var val_3;
        var val_4;
        if(this.isGems != false)
        {
                val_1 = this.blinkGemsColor;
            val_2 = 1152921525755674348;
            val_3 = 1152921525755674352;
            val_4 = 1152921525755674356;
            return new UnityEngine.Color() {r = this.blinkCoinsColor.r, g = 5.477487E-23f, b = 5.477487E-23f, a = 5.477487E-23f};
        }
        
        val_1 = this.blinkCoinsColor;
        val_2 = 1152921525755674332;
        val_3 = 1152921525755674336;
        val_4 = 1152921525755674340;
        return new UnityEngine.Color() {r = this.blinkCoinsColor.r, g = 5.477487E-23f, b = 5.477487E-23f, a = 5.477487E-23f};
    }
    private UnityEngine.Color 且不业七丄丂世且一()
    {
        UnityEngine.Color val_1;
        var val_2;
        var val_3;
        var val_4;
        if(this.isX3 != false)
        {
                val_1 = this.normalX3Color;
            val_2 = 1152921525755786316;
            val_3 = 1152921525755786320;
            val_4 = 1152921525755786324;
            return new UnityEngine.Color() {r = this.normalColor.r, g = 5.477487E-23f, b = 5.477487E-23f, a = 5.477487E-23f};
        }
        
        val_1 = this.normalColor;
        val_2 = 1152921525755786300;
        val_3 = 1152921525755786304;
        val_4 = 1152921525755786308;
        return new UnityEngine.Color() {r = this.normalColor.r, g = 5.477487E-23f, b = 5.477487E-23f, a = 5.477487E-23f};
    }
    private System.Collections.IEnumerator 丅与丅丝丈世丑丐丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CoinsAddIndic.上丛丁专丝丏丄不丄();
    }
    private void 且丅丘丗专丒东丑丑(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
    {
        GiftBannerWindow val_9;
        var val_10;
        var val_11;
        var val_12;
        int val_13;
        val_9 = 1152921505171275776;
        val_10 = null;
        val_10 = null;
        bool val_1 = System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        var val_2 = (this.isGems == true) ? 1 : 0;
        val_2 = val_1 ^ val_2;
        if(val_2 == true)
        {
                return;
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                val_9 = BankController.丑七不且上丗丁一世();
            if(val_9.上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        val_11 = null;
        val_11 = null;
        val_9 = GiftBannerWindow.丄丘七三上丕世丞业;
        if(val_9 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_9 = GiftBannerWindow.丄丘七三上丕世丞业;
        if(val_9.IsShow == false)
        {
                return;
        }
        
        if(val_1 != false)
        {
                if(this.isGems == false)
        {
                return;
        }
        
            val_13 = 1;
        }
        else
        {
                if(this.isGems == true)
        {
                return;
        }
        
            val_13 = 2;
        }
        
        this.丘与丏丁一丂七世丅 = val_13;
    }
    public CoinsAddIndic()
    {
        this.normalColor = 0;
        mem[1152921525756155068] = 0;
        mem[1152921525756155076] = 0;
        this.normalX3Color = 0;
        mem[1152921525756155084] = 0;
        mem[1152921525756155092] = 0;
        this.blinkCoinsColor = 0;
        mem[1152921525756155100] = 0;
        mem[1152921525756155108] = 0;
        this.blinkGemsColor = 0;
        mem[1152921525756155116] = 0;
        mem[1152921525756155124] = 0;
    }

}
