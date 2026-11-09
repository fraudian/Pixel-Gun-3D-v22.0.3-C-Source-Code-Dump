using UnityEngine;
public class UICamera.丞上且下专丞东专世
{
    // Fields
    public UnityEngine.KeyCode 下上丐丆丝丟丝丒不;
    public UnityEngine.Vector2 下业丕七东丌丝下且;
    public UnityEngine.Vector2 丙与下丄专丟丞丄丒;
    public UnityEngine.Vector2 丞且丅三三东不丄且;
    public UnityEngine.Vector2 东丞不不丙丁丄下且;
    public UnityEngine.Camera 丗丗世丂丌丆东下丄;
    public UnityEngine.GameObject 丙丕丛丒丁丐丒丕丕;
    public UnityEngine.GameObject 上丞丕专丈业丁世专;
    public UnityEngine.GameObject 万东丂丒且丅丛丑丕;
    public UnityEngine.GameObject 丆丝东丞下丁丛丝与;
    public bool 丌丏丐丘丁丒丄丅丝;
    public float 丏丅下世上丈下丈丛;
    public float 业三丂丌丅丘且不世;
    public UICamera.丏丝丅七一丗丙且丈 丌下丐上丛丘丗万丅;
    public bool 丂丅丙丏丂七不丝丅;
    public bool 丅七丞业丁丐三丑丒;
    public bool 丞丁丈丛世一丑丄丄;
    public bool 丁丛丗丘丒丕世七丄;
    public int 七丄丟丙世东丁下丒;
    public float 丐丒不丅下丒丑丒丟;
    public float 丗与丟丘七丈丒丆丑;
    
    // Properties
    public float 丑丗丘与丈不七东丛 { get; }
    public bool 丆不不东丒丑丗丅丙 { get; }
    
    // Methods
    public float 业丅三丙丒专一丏丑()
    {
        float val_1 = RealTime.time;
        val_1 = val_1 - this.丏丅下世上丈下丈丛;
        return (float)val_1;
    }
    public bool 丒三且一丂丁一专上()
    {
        var val_4;
        if(this.上丞丕专丈业丁世专 == 0)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        if(this.上丞丕专丈业丁世专 == UICamera.fallThrough)
        {
                return false;
        }
        
        return UnityEngine.Object.op_Inequality(x:  不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  this.上丞丕专丈业丁世专, 丕丗丆丕丈丑东丆丈:  0), y:  0);
    }
    public UICamera.丞上且下专丞东专世()
    {
        this.丌下丐上丛丘丗万丅 = 1;
        this.丂丅丙丏丂七不丝丅 = 1;
    }

}
