using UnityEngine;
public class TweenFill : UITweener
{
    // Fields
    public float from;
    public float to;
    private bool 丛世专万业丈东不丁;
    private UIBasicSprite 丂丑丌丂丝专丗丆东;
    
    // Properties
    public float 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    private void 丏万丟丙上丏丟万丑()
    {
        this.丛世专万业丈东不丁 = true;
        UIBasicSprite val_1 = this.GetComponent<UIBasicSprite>();
        this.丂丑丌丂丝专丗丆东 = val_1;
        if(val_1 != 0)
        {
                return;
        }
        
        this.丂丑丌丂丝专丗丆东 = this.GetComponentInChildren<UIBasicSprite>();
    }
    public float get_value()
    {
        if(this.丛世专万业丈东不丁 != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
                return 1f;
        }
        
        if(this.丂丑丌丂丝专丗丆东 != null)
        {
                return this.丂丑丌丂丝专丗丆东.fillAmount;
        }
        
        return this.丂丑丌丂丝专丗丆东.fillAmount;
    }
    public void set_value(float 丙业与丙丗丝不丈东)
    {
        if(this.丛世专万业丈东不丁 != true)
        {
                this.丏万丟丙上丏丟万丑();
        }
        
        if(this.丂丑丌丂丝专丗丆东 == 0)
        {
                return;
        }
        
        this.丂丑丌丂丝专丗丆东.fillAmount = 丙业与丙丗丝不丈东;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        this.value = UnityEngine.Mathf.Lerp(a:  this.from, b:  this.to, t:  丞上与七且与七三丐);
    }
    public static TweenFill Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, float 丙丝与丆三丝不且丑)
    {
        TweenFill val_1 = UITweener.Begin<TweenFill>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        if(val_1 != null)
        {
                val_1.from = val_1.value;
        }
        else
        {
                mem[120] = val_1.value;
        }
        
        val_1.to = 丙丝与丆三丝不且丑;
        if(与丈业丛丝丒丙一丏 > 0f)
        {
                return val_1;
        }
        
        val_1.Sample(丞上与七且与七三丐:  1f, 丄上且东丙丘丙丈丕:  true);
        val_1.enabled = false;
        return val_1;
    }
    public override void SetStartToCurrentValue()
    {
        this.from = this.value;
    }
    public override void SetEndToCurrentValue()
    {
        this.to = this.value;
    }
    public TweenFill()
    {
        this.from = 1f;
        this.to = 1f;
    }

}
