using UnityEngine;
internal sealed class PanelAnchor : PGBehaviour
{
    // Fields
    private UIPanel 丗丒丟下丕丆丗丆丈;
    private UIPanel _anchor;
    
    // Properties
    public UIPanel 丆丐且丛丒三丗三世 { get; }
    
    // Methods
    public UIPanel get_Panel()
    {
        UIPanel val_3;
        if(this.丗丒丟下丕丆丗丆丈 == 0)
        {
                this.丗丒丟下丕丆丗丆丈 = this.GetComponent<UIPanel>();
            return val_3;
        }
        
        val_3 = this.丗丒丟下丕丆丗丆丈;
        return val_3;
    }
    public void Apply()
    {
        if(this._anchor == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.Panel.transform.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.Panel.clipOffset = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        UnityEngine.Vector4 val_9 = this._anchor.clipRange;
        this.Panel.clipRange = new UnityEngine.Vector4() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        this.Panel.transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        this.Panel.clipOffset = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
    }
    public PanelAnchor()
    {
    
    }

}
