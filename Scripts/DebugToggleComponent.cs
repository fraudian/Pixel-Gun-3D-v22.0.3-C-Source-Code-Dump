using UnityEngine;
internal sealed class DebugToggleComponent : MonoBehaviour
{
    // Fields
    internal UILabel label;
    internal UISprite backgroundSprite;
    internal UnityEngine.GameObject checkObject;
    internal Rilisoft.ButtonHandler buttonHandler;
    internal UIButton buttonForColors;
    internal UIDragScrollView dragScollView;
    private System.Action 七丐丅专且专七三丆;
    private 且东三东丑七专东不 丈东丘丏与丌东东下;
    
    // Methods
    internal DebugToggleComponent 丈且东丑丂且万丒丅(string 专丝丟丒丐丈三丒世, string 丗丂不丂丕丛丆且丕, System.Action 丂丕且丈丁丈上丙丒, System.Action 业东丏世丘丕丞东丞, 且东三东丑七专东不 丈东丘丏与丌东东下, UIScrollView 丁世丛业丟下丕三丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄, UnityEngine.Color 丗丅丙丏丝一七东丗)
    {
        float val_24;
        float val_25;
        且东三东丑七专东不 val_26;
        var val_27;
        var val_28;
        UILabel val_29;
        var val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        val_24 = 丗丅丙丏丝一七东丗.a;
        val_25 = 丗丅丙丏丝一七东丗.g;
        DebugToggleComponent.业东下丕世丗丏万丏 val_1 = new DebugToggleComponent.业东下丕世丗丏万丏();
        if(val_1 != null)
        {
                .丁世丛业丟下丕三丟 = 丁世丛业丟下丕三丟;
            val_26 = 1152921537076295104;
            val_27 = 1152921537076295104;
            val_28 = 1152921537076295104;
            mem[1152921537076295056] = 丈东丘丏与丌东东下;
            mem[1152921537076295064] = this;
            mem[1152921537076295072] = 专丝丟丒丐丈三丒世;
            mem[1152921537076295080] = 丗丂不丂丕丛丆且丕;
            mem[1152921537076295088] = 丂丕且丈丁丈上丙丒;
            mem[1152921537076295096] = 业东丏世丘丕丞东丞;
        }
        else
        {
                mem[16] = 丈东丘丏与丌东东下;
            mem[24] = this;
            val_27 = 32;
            mem[32] = 专丝丟丒丐丈三丒世;
            val_28 = 40;
            mem[40] = 丗丂不丂丕丛丆且丕;
            mem[48] = 丂丕且丈丁丈上丙丒;
            mem[56] = 业东丏世丘丕丞东丞;
            mem[64] = 丁世丛业丟下丕三丟;
            val_26 = 16;
        }
        
        .丑丞丈丗丄丙丟万丄 = 丑丞丈丗丄丙丟万丄;
        mem[1152921537076295116] = 丑丞丈丗丄丙丟万丄.g;
        mem[1152921537076295120] = 丑丞丈丗丄丙丟万丄.b;
        mem[1152921537076295124] = 丑丞丈丗丄丙丟万丄.a;
        .丗丅丙丏丝一七东丗 = 丗丅丙丏丝一七东丗;
        mem[1152921537076295132] = val_25;
        mem[1152921537076295136] = 丗丅丙丏丝一七东丗.b;
        mem[1152921537076295140] = val_24;
        if(val_1 != null)
        {
                val_29 = this.label;
            this.丈东丘丏与丌东东下 = val_26;
        }
        else
        {
                val_29 = this.label;
            this.丈东丘丏与丌东东下 = mem[16];
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_29, 丕丗丘丑丛与丑业丒:  ((丈东丘丏与丌东东下 + 56) != 0) ? 40 : (val_27));
        val_30 = val_26;
        if((丈东丘丏与丌东东下 + 56) != 0)
        {
            goto label_12;
        }
        
        val_31 = mem[丑丞丈丗丄丙丟万丄];
        val_31 = .丑丞丈丗丄丙丟万丄;
        val_32 = mem[丑丞丈丗丄丙丟万丄.g];
        val_32 = mem[1152921537076295116];
        val_33 = mem[丑丞丈丗丄丙丟万丄.b];
        val_33 = mem[1152921537076295120];
        val_34 = mem[丑丞丈丗丄丙丟万丄.a];
        val_34 = mem[1152921537076295124];
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_31, g = val_32, b = val_33, a = val_34}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) == true)
        {
            goto label_14;
        }
        
        label_12:
        if((丈东丘丏与丌东东下 + 56) == 0)
        {
            goto label_19;
        }
        
        val_31 = .丗丅丙丏丝一七东丗;
        val_32 = mem[1152921537076295132];
        val_33 = mem[1152921537076295136];
        val_34 = mem[1152921537076295140];
        if((UnityEngine.Color.op_Inequality(lhs:  new UnityEngine.Color() {r = val_31, g = val_32, b = val_33, a = val_34}, rhs:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f})) == false)
        {
            goto label_19;
        }
        
        label_14:
        val_25 = mem[丈东丘丏与丌东东下 + 56 != 0x0 ? 1152921537076295136 : 丑丞丈丗丄丙丟万丄.b];
        val_25 = ((丈东丘丏与丌东东下 + 56) != 0) ? -1890290208 : (mem[1152921537076295120]);
        val_24 = mem[丈东丘丏与丌东东下 + 56 != 0x0 ? 1152921537076295128 : 丑丞丈丗丄丙丟万丄];
        val_24 = ((丈东丘丏与丌东东下 + 56) != 0) ? -1890290216 : (.丑丞丈丗丄丙丟万丄);
        val_31 = val_24;
        val_32 = ((丈东丘丏与丌东东下 + 56) != 0) ? -1890290212 : (mem[1152921537076295116]);
        val_33 = val_25;
        val_34 = ((丈东丘丏与丌东东下 + 56) != 0) ? -1890290204 : (mem[1152921537076295124]);
        this.backgroundSprite.color = new UnityEngine.Color() {r = val_31, g = val_32, b = val_33, a = val_34};
        val_30 = val_26;
        label_19:
        if(this.buttonForColors != 0)
        {
                UnityEngine.Color val_10 = this.backgroundSprite.color;
            this.buttonForColors.defaultColor = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
            UnityEngine.Color val_11 = this.backgroundSprite.color;
            mem2[0] = val_11.r;
            mem2[0] = val_11.g;
            mem2[0] = val_11.b;
            mem2[0] = val_11.a;
            UnityEngine.Color val_12 = this.backgroundSprite.color;
            val_24 = val_12.r;
            UnityEngine.Color val_13 = this.backgroundSprite.color;
            UnityEngine.Color val_14 = this.backgroundSprite.color;
            val_25 = val_14.b;
            UnityEngine.Color val_15 = this.backgroundSprite.color;
            float val_24 = -0.3f;
            float val_16 = val_24 + val_24;
            float val_17 = val_13.g + val_24;
            val_24 = val_25 + val_24;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_30 = val_26;
        }
        
        if(this.dragScollView != 0)
        {
                if(mem[64] != 0)
        {
                this.dragScollView.scrollView = mem[64];
            val_30 = val_26;
        }
        
        }
        
        if(this.buttonHandler != 0)
        {
                System.Action val_21 = ((丈东丘丏与丌东东下 + 56) != 0) ? 56 : 48;
            this.七丐丅专且专七三丆 = val_21;
            if(val_21 != 0)
        {
                this.buttonHandler.ClearEvents();
            this.buttonHandler.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_1, method:  System.Void DebugToggleComponent.业东下丕世丗丏万丏::丆一且世上丗上一丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_30 = val_26;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.checkObject, 丏业丟一东丂东丘丛:  ((丈东丘丏与丌东东下 + 56) != 0) ? 1 : 0);
        return (DebugToggleComponent)this;
    }
    public DebugToggleComponent()
    {
    
    }

}
