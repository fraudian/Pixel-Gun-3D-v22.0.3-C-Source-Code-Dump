using UnityEngine;
public class TweenOrthoSize : UITweener
{
    // Fields
    public float from;
    public float to;
    private UnityEngine.Camera 丟丕东万丐丁丁专一;
    
    // Properties
    public UnityEngine.Camera 丘丐下不丐下丘丞丗 { get; }
    public float 丄丕不丒丑丒东丏业 { get; set; }
    public float 丙业与丙丗丝不丈东 { get; set; }
    
    // Methods
    public UnityEngine.Camera get_cachedCamera()
    {
        UnityEngine.Camera val_3;
        if(this.丟丕东万丐丁丁专一 == 0)
        {
                this.丟丕东万丐丁丁专一 = this.GetComponent<UnityEngine.Camera>();
            return val_3;
        }
        
        val_3 = this.丟丕东万丐丁丁专一;
        return val_3;
    }
    public float get_orthoSize()
    {
        return this.value;
    }
    public void set_orthoSize(float 丙业与丙丗丝不丈东)
    {
        this.value = 丙业与丙丗丝不丈东;
    }
    public float get_value()
    {
        UnityEngine.Camera val_1 = this.cachedCamera;
        if(val_1 != null)
        {
                return val_1.orthographicSize;
        }
        
        return val_1.orthographicSize;
    }
    public void set_value(float 丙业与丙丗丝不丈东)
    {
        this.cachedCamera.orthographicSize = 丙业与丙丗丝不丈东;
    }
    protected override void 丑丈丆万丅上丞丗丐(float 丞上与七且与七三丐, bool 丄上且东丙丘丙丈丕)
    {
        float val_2 = this.from;
        float val_1 = 1f;
        val_1 = val_1 - 丞上与七且与七三丐;
        val_2 = val_1 * val_2;
        丞上与七且与七三丐 = this.to * 丞上与七且与七三丐;
        丞上与七且与七三丐 = val_2 + 丞上与七且与七三丐;
        this.value = 丞上与七且与七三丐;
    }
    public static TweenOrthoSize Begin(UnityEngine.GameObject 丝三丁东丈丒世丅业, float 与丈业丛丝丒丙一丏, float 专丂丕丗丗东世丞下)
    {
        TweenOrthoSize val_1 = UITweener.Begin<TweenOrthoSize>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 与丈业丛丝丒丙一丏:  与丈业丛丝丒丙一丏);
        if(val_1 != null)
        {
                val_1.from = val_1.value;
        }
        else
        {
                mem[120] = val_1.value;
        }
        
        val_1.to = 专丂丕丗丗东世丞下;
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
    public TweenOrthoSize()
    {
        this.from = 1f;
        this.to = 1f;
    }

}
