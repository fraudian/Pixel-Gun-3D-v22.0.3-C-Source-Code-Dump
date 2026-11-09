using UnityEngine;
internal sealed class DebugButtonListComponent : MonoBehaviour
{
    // Fields
    internal UILabel label;
    internal UILabel arrowLabel;
    internal UISprite backgroundSprite;
    internal Rilisoft.ButtonHandler buttonHandler;
    internal UIDragScrollView dragScollView;
    internal UIButton buttonForColors;
    private System.Action<bool> 七丐丅专且专七三丆;
    internal bool 下下东且万业丞丅丒;
    private 丙丁丝三世丅七不丛 丈东丘丏与丌东东下;
    
    // Properties
    internal bool 丗下丟万不丁且与丆 { get; set; }
    
    // Methods
    internal bool 丑丝丝丏万不丝三世()
    {
        return (bool)this.下下东且万业丞丅丒;
    }
    internal void 业一丗丝丑业丂丛上(bool 丙业与丙丗丝不丈东)
    {
        this.下下东且万业丞丅丒 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.arrowLabel, 丕丗丘丑丛与丑业丒:  (丙业与丙丗丝不丈东 != true) ? "<" : ">");
    }
    internal DebugButtonListComponent 丈且东丑丂且万丒丅(string 丕丗丘丑丛与丑业丒, System.Action<bool> 丄丐且丂上丒丑专丂, 丙丁丝三世丅七不丛 丈东丘丏与丌东东下, UIScrollView 丁世丛业丟下丕三丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        float val_16;
        float val_17;
        丙丁丝三世丅七不丛 val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        UIDragScrollView val_23;
        Rilisoft.ButtonHandler val_24;
        val_16 = 丑丞丈丗丄丙丟万丄.a;
        val_17 = 丑丞丈丗丄丙丟万丄.g;
        DebugButtonListComponent.丒丛丁与丅东丒不七 val_1 = new DebugButtonListComponent.丒丛丁与丅东丒不七();
        if(val_1 != null)
        {
                val_18 = val_1;
            .丈东丘丏与丌东东下 = 丈东丘丏与丌东东下;
            mem[1152921537073131168] = this;
        }
        else
        {
                mem[16] = this;
            val_18 = 24;
            mem[24] = 丈东丘丏与丌东东下;
        }
        
        this.丈东丘丏与丌东东下 = val_18;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.label, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        val_19 = 丑丞丈丗丄丙丟万丄.r;
        val_20 = val_17;
        val_21 = 丑丞丈丗丄丙丟万丄.b;
        val_22 = val_16;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_19, g = val_20, b = val_21, a = val_22}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) != false)
        {
                val_19 = 丑丞丈丗丄丙丟万丄.r;
            val_20 = val_17;
            val_21 = 丑丞丈丗丄丙丟万丄.b;
            val_22 = val_16;
            this.backgroundSprite.color = new UnityEngine.Color() {r = val_19, g = val_20, b = val_21, a = val_22};
        }
        
        if(this.buttonForColors != 0)
        {
                UnityEngine.Color val_4 = this.backgroundSprite.color;
            this.buttonForColors.defaultColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            UnityEngine.Color val_5 = this.backgroundSprite.color;
            mem2[0] = val_5.r;
            mem2[0] = val_5.g;
            mem2[0] = val_5.b;
            mem2[0] = val_5.a;
            UnityEngine.Color val_6 = this.backgroundSprite.color;
            val_16 = val_6.r;
            UnityEngine.Color val_7 = this.backgroundSprite.color;
            UnityEngine.Color val_8 = this.backgroundSprite.color;
            val_17 = val_8.b;
            UnityEngine.Color val_9 = this.backgroundSprite.color;
            float val_16 = -0.3f;
            float val_10 = val_16 + val_16;
            float val_11 = val_7.g + val_16;
            val_16 = val_17 + val_16;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        
        val_23 = this.dragScollView;
        if(val_23 != 0)
        {
                if(丁世丛业丟下丕三丟 != 0)
        {
                val_23 = this.dragScollView;
            this.dragScollView.scrollView = 丁世丛业丟下丕三丟;
        }
        
        }
        
        this.业一丗丝丑业丂丛上(丙业与丙丗丝不丈东:  丈东丘丏与丌东东下 + 56);
        this.七丐丅专且专七三丆 = 丄丐且丂上丒丑专丂;
        val_24 = this.buttonHandler;
        if(val_24 == 0)
        {
                return (DebugButtonListComponent)this;
        }
        
        if(this.七丐丅专且专七三丆 == null)
        {
                return (DebugButtonListComponent)this;
        }
        
        this.buttonHandler.ClearEvents();
        val_24 = this.buttonHandler;
        val_24.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void DebugButtonListComponent.丒丛丁与丅东丒不七::丆一且世上丗上一丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        return (DebugButtonListComponent)this;
    }
    public DebugButtonListComponent()
    {
    
    }

}
