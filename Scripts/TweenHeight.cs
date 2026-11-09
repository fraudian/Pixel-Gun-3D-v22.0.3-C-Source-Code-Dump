using UnityEngine;
public class TweenHeight : UITweener
{
    // Fields
    public int from;
    public int to;
    public bool updateTable;
    private UIWidget 丆不下丄丄且丞一丈;
    private UITable 丏七丏丆丘东丝且专;
    
    // Properties
    public UIWidget 丕丑丄上不业丏专丝 { get; }
    public int 丟丌丐丘丆丙丑丑一 { get; set; }
    public int 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    public UIWidget get_cachedWidget()
    {
        UIWidget val_3;
        if(this.丆不下丄丄且丞一丈 == 0)
        {
                this.丆不下丄丄且丞一丈 = this.GetComponent<UIWidget>();
            return val_3;
        }
        
        val_3 = this.丆不下丄丄且丞一丈;
        return val_3;
    }
    public int get_height()
    {
        return this.value;
    }
    public void set_height(int 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public int get_value()
    {
        UIWidget val_1 = this.cachedWidget;
        if(val_1 != null)
        {
                return val_1.height;
        }
        
        return val_1.height;
    }
    public void set_value(int 丙业与丙丗丝不丈东)
    {
        this.cachedWidget.height = 丙业与丙丗丝不丈东;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_7 = 1f;
        float val_8 = (float)this.from;
        val_7 = val_7 - 丞上与七且与七三丐;
        val_8 = val_7 * val_8;
        val_8 = val_8 + ((float)this.to * 丞上与七且与七三丐);
        this.value = UnityEngine.Mathf.RoundToInt(f:  val_8);
        if(this.updateTable == false)
        {
                return;
        }
        
        if(this.丏七丏丆丘东丝且专 == 0)
        {
                UITable val_5 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UITable>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            this.丏七丏丆丘东丝且专 = val_5;
            if(val_5 == 0)
        {
                this.updateTable = false;
            return;
        }
        
        }
        
        this.丏七丏丆丘东丝且专.repositionNow = true;
    }
    public static TweenHeight Begin(UIWidget 世丌丌丙丞丟下东丞, float 与丈业丛丝丒丙一丏, int 丟丌丐丘丆丙丑丑一)
    {
        TweenHeight val_2 = UITweener.Begin<TweenHeight>(丝三丁东丈丒世丅业:  世丌丌丙丞丟下东丞.gameObject, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        int val_3 = 世丌丌丙丞丟下东丞.height;
        if(val_2 != null)
        {
                val_2.from = val_3;
        }
        else
        {
                mem[120] = val_3;
        }
        
        val_2.to = 丟丌丐丘丆丙丑丑一;
        if(与丈业丛丝丒丙一丏 > 0f)
        {
                return val_2;
        }
        
        val_2.Sample(丞上与七且与七三丐:  1f, 丄上且东丙丘丙丈丕:  true);
        val_2.enabled = false;
        return val_2;
    }
    public override void SetStartToCurrentValue()
    {
        this.from = this.value;
    }
    public override void SetEndToCurrentValue()
    {
        this.to = this.value;
    }
    private void 丐一业丌东七丐丅丗()
    {
        this.value = this.from;
    }
    private void 一一丌丄三丐世丌不()
    {
        this.value = this.to;
    }
    public TweenHeight()
    {
        this.from = 100;
        this.to = 100;
    }

}
