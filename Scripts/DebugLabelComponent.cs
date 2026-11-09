using UnityEngine;
internal sealed class DebugLabelComponent : MonoBehaviour
{
    // Fields
    internal UILabel label;
    internal UIDragScrollView dragScollView;
    private System.Action 七丐丅专且专七三丆;
    
    // Methods
    internal DebugLabelComponent 丈且东丑丂且万丒丅(string 丕丗丘丑丛与丑业丒, UIScrollView 丁世丛业丟下丕三丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        UIDragScrollView val_4;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) != false)
        {
                this.label.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
        }
        
        val_4 = this.dragScollView;
        if(val_4 == 0)
        {
                return (DebugLabelComponent)this;
        }
        
        if(丁世丛业丟下丕三丟 == 0)
        {
                return (DebugLabelComponent)this;
        }
        
        val_4 = this.dragScollView;
        this.dragScollView.scrollView = 丁世丛业丟下丕三丟;
        return (DebugLabelComponent)this;
    }
    public DebugLabelComponent()
    {
    
    }

}
