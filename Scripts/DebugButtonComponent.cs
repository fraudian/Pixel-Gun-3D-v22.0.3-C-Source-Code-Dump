using UnityEngine;
internal sealed class DebugButtonComponent : MonoBehaviour
{
    // Fields
    internal UILabel label;
    internal UISprite backgroundSprite;
    internal Rilisoft.ButtonHandler buttonHandler;
    internal UIDragScrollView dragScollView;
    internal UIButton buttonForColors;
    private System.Action 七丐丅专且专七三丆;
    
    // Methods
    internal DebugButtonComponent 丈且东丑丂且万丒丅(string 丕丗丘丑丛与丑业丒, System.Action 丄丐且丂上丒丑专丂, UIScrollView 丁世丛业丟下丕三丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        float val_15;
        float val_16;
        UILabel val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        Rilisoft.ButtonHandler val_22;
        val_15 = 丑丞丈丗丄丙丟万丄.a;
        val_16 = 丑丞丈丗丄丙丟万丄.g;
        val_17 = this.label;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_17, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        val_18 = 丑丞丈丗丄丙丟万丄.r;
        val_19 = val_16;
        val_20 = 丑丞丈丗丄丙丟万丄.b;
        val_21 = val_15;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) != false)
        {
                val_18 = 丑丞丈丗丄丙丟万丄.r;
            val_19 = val_16;
            val_20 = 丑丞丈丗丄丙丟万丄.b;
            val_21 = val_15;
            this.backgroundSprite.color = new UnityEngine.Color() {r = val_18, g = val_19, b = val_20, a = val_21};
        }
        
        if(this.buttonForColors != 0)
        {
                UnityEngine.Color val_3 = this.backgroundSprite.color;
            this.buttonForColors.defaultColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            UnityEngine.Color val_4 = this.backgroundSprite.color;
            mem2[0] = val_4.r;
            mem2[0] = val_4.g;
            mem2[0] = val_4.b;
            mem2[0] = val_4.a;
            val_17 = this.buttonForColors;
            UnityEngine.Color val_5 = this.backgroundSprite.color;
            val_15 = val_5.r;
            UnityEngine.Color val_6 = this.backgroundSprite.color;
            UnityEngine.Color val_7 = this.backgroundSprite.color;
            val_16 = val_7.b;
            UnityEngine.Color val_8 = this.backgroundSprite.color;
            float val_15 = -0.3f;
            float val_9 = val_15 + val_15;
            float val_10 = val_6.g + val_15;
            val_15 = val_16 + val_15;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        
        if(this.dragScollView != 0)
        {
                if(丁世丛业丟下丕三丟 != 0)
        {
                this.dragScollView.scrollView = 丁世丛业丟下丕三丟;
        }
        
        }
        
        val_22 = this.buttonHandler;
        if(val_22 == 0)
        {
                return (DebugButtonComponent)this;
        }
        
        this.七丐丅专且专七三丆 = 丄丐且丂上丒丑专丂;
        if(丄丐且丂上丒丑专丂 == null)
        {
                return (DebugButtonComponent)this;
        }
        
        this.buttonHandler.ClearEvents();
        System.EventHandler val_14 = null;
        val_22 = val_14;
        val_14 = new System.EventHandler(object:  this, method:  System.Void DebugButtonComponent::丁丅丗丟丌万东丟丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        this.buttonHandler.add_Clicked(丙业与丙丗丝不丈东:  val_14);
        return (DebugButtonComponent)this;
    }
    public DebugButtonComponent()
    {
    
    }
    private void 丁丅丗丟丌万东丟丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.七丐丅专且专七三丆 == null)
        {
                return;
        }
        
        this.七丐丅专且专七三丆.Invoke();
    }

}
