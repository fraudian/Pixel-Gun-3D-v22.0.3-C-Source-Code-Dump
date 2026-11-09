using UnityEngine;
internal sealed class DebugButtonDoubleComponent : MonoBehaviour
{
    // Fields
    internal UILabel labelOneButton;
    internal UILabel labelTwoButton;
    internal UILabel labelMiddle;
    internal UISprite buttonSpriteOne;
    internal UISprite buttonSpriteTwo;
    internal Rilisoft.ButtonHandler buttonHandlerOne;
    internal Rilisoft.ButtonHandler buttonHandlerTwo;
    internal UIButton buttonForColorsOne;
    internal UIButton buttonForColorsTwo;
    internal UIDragScrollView dragScollView;
    private System.Action 丟与丛丁丕丂丝与丌;
    private System.Action 丝不丛专丟丒丅丂丛;
    
    // Methods
    internal DebugButtonDoubleComponent 丈且东丑丂且万丒丅(string 专丝丟丒丐丈三丒世, string 丗丂不丂丕丛丆且丕, System.Action 丟丑丞业丙丆专东丐, System.Action 下丂丕丗丝丄世丄万, System.Action<UILabel> 不东世丐专丘丗丂下, UIScrollView 丁世丛业丟下丕三丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        float val_27;
        float val_28;
        System.Action val_29;
        string val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        Rilisoft.ButtonHandler val_35;
        val_27 = 丑丞丈丗丄丙丟万丄.a;
        val_28 = 丑丞丈丗丄丙丟万丄.g;
        val_29 = 下丂丕丗丝丄世丄万;
        val_30 = 专丝丟丒丐丈三丒世;
        DebugButtonDoubleComponent.丒丛丁与丅东丒不七 val_1 = new DebugButtonDoubleComponent.丒丛丁与丅东丒不七();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .不东世丐专丘丗丂下 = 不东世丐专丘丗丂下;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.labelOneButton, 丕丗丘丑丛与丑业丒:  val_30);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.labelTwoButton, 丕丗丘丑丛与丑业丒:  丗丂不丂丕丛丆且丕);
        val_31 = 丑丞丈丗丄丙丟万丄.r;
        val_32 = val_28;
        val_33 = 丑丞丈丗丄丙丟万丄.b;
        val_34 = val_27;
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_31, g = val_32, b = val_33, a = val_34}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) != false)
        {
                this.buttonSpriteOne.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = val_28, b = 丑丞丈丗丄丙丟万丄.b, a = val_27};
            val_31 = 丑丞丈丗丄丙丟万丄.r;
            val_32 = val_28;
            val_33 = 丑丞丈丗丄丙丟万丄.b;
            val_34 = val_27;
            this.buttonSpriteTwo.color = new UnityEngine.Color() {r = val_31, g = val_32, b = val_33, a = val_34};
        }
        
        if(this.buttonForColorsOne != 0)
        {
                UnityEngine.Color val_4 = this.buttonSpriteOne.color;
            val_34 = val_4.a;
            this.buttonForColorsOne.defaultColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_34};
            UnityEngine.Color val_5 = this.buttonSpriteOne.color;
            mem2[0] = val_5.r;
            mem2[0] = val_5.g;
            mem2[0] = val_5.b;
            mem2[0] = val_5.a;
            val_30 = this.buttonForColorsOne;
            UnityEngine.Color val_6 = this.buttonSpriteOne.color;
            val_27 = val_6.r;
            UnityEngine.Color val_7 = this.buttonSpriteOne.color;
            UnityEngine.Color val_8 = this.buttonSpriteOne.color;
            val_28 = val_8.b;
            UnityEngine.Color val_9 = this.buttonSpriteOne.color;
            val_31 = val_27 + (-0.3f);
            val_32 = val_7.g + (-0.3f);
            val_33 = val_28 + (-0.3f);
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        
        if(this.buttonForColorsTwo != 0)
        {
                UnityEngine.Color val_11 = this.buttonSpriteTwo.color;
            this.buttonForColorsTwo.defaultColor = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
            UnityEngine.Color val_12 = this.buttonSpriteTwo.color;
            mem2[0] = val_12.r;
            mem2[0] = val_12.g;
            mem2[0] = val_12.b;
            mem2[0] = val_12.a;
            val_30 = this.buttonForColorsTwo;
            UnityEngine.Color val_13 = this.buttonSpriteTwo.color;
            val_27 = val_13.r;
            UnityEngine.Color val_14 = this.buttonSpriteTwo.color;
            UnityEngine.Color val_15 = this.buttonSpriteTwo.color;
            val_28 = val_15.b;
            UnityEngine.Color val_16 = this.buttonSpriteTwo.color;
            float val_25 = -0.3f;
            float val_17 = val_27 + val_25;
            float val_18 = val_14.g + val_25;
            val_25 = val_28 + val_25;
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
        
        val_35 = this.buttonHandlerOne;
        if(val_35 != 0)
        {
                val_35 = this.buttonHandlerOne;
            val_35.ClearEvents();
            this.丟与丛丁丕丂丝与丌 = 丟丑丞业丙丆专东丐;
            if(丟丑丞业丙丆专东丐 != null)
        {
                System.EventHandler val_22 = null;
            val_35 = val_22;
            val_22 = new System.EventHandler(object:  val_1, method:  System.Void DebugButtonDoubleComponent.丒丛丁与丅东丒不七::丆一且世上丗上一丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.buttonHandlerOne.add_Clicked(丙业与丙丗丝不丈东:  val_22);
        }
        
        }
        
        if(this.buttonHandlerTwo != 0)
        {
                this.buttonHandlerTwo.ClearEvents();
            this.丝不丛专丟丒丅丂丛 = val_29;
            if(val_29 != null)
        {
                val_29 = this.buttonHandlerTwo;
            val_29.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void DebugButtonDoubleComponent.丒丛丁与丅东丒不七::一丄业丐丄丒下丏丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if((DebugButtonDoubleComponent.丒丛丁与丅东丒不七)[1152921537071957008].不东世丐专丘丗丂下 == null)
        {
                return (DebugButtonDoubleComponent)this;
        }
        
        (DebugButtonDoubleComponent.丒丛丁与丅东丒不七)[1152921537071957008].不东世丐专丘丗丂下.Invoke(obj:  this.labelMiddle);
        return (DebugButtonDoubleComponent)this;
    }
    public DebugButtonDoubleComponent()
    {
    
    }

}
