using UnityEngine;
public class UIMapIcon : UIMapIconBase
{
    // Fields
    public UISprite sprite;
    public UISprite border;
    private UnityEngine.Color 业丒丗丄丏丏万丗丁;
    private TweenColor 丟丌丄丞万专丟三万;
    public int typeIcon;
    private TweenScale 丈三丆上丛三丞丁丛;
    
    // Methods
    protected override void Start()
    {
        if(X20.fadeOutAfterDelay == 0f)
        {
                this.sprite.alpha = 1f;
        }
        
        this.Start();
        if(null == null)
        {
                return;
        }
        
        this.sprite.color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
    }
    protected virtual void OnTooltip(bool 丛与丙丒丒下丌丟且)
    {
        if((System.String.IsNullOrEmpty(value:  X21 + 32)) != false)
        {
                return;
        }
        
        if(丛与丙丒丒下丌丟且 != false)
        {
                UICustomTooltip.Show(丟专上丏专下丞丄丄:  0);
            return;
        }
        
        UICustomTooltip.Hide();
    }
    protected virtual void OnHover(bool 丟丆丕且丆丈丂丌丘)
    {
        UnityEngine.GameObject val_5;
        UnityEngine.GameObject val_6;
        val_5 = this;
        if(丟丆丕且丆丈丂丌丘 != false)
        {
                if(true != 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_1 = this.sprite.cachedGameObject;
        }
        else
        {
                if(true != 0)
        {
                return;
        }
        
            val_5 = this.sprite.cachedGameObject;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            val_6 = val_5;
        }
        
        TweenScale val_4 = TweenScale.Begin(丝三丁东丈丒世丅业:  val_6, 与丈业丛丝丒丙一丏:  0.3f, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    public override void Select()
    {
        this.Select();
        if(this.border == 0)
        {
                return;
        }
        
        this.border.enabled = true;
    }
    public override void OnEnable()
    {
        this.OnEnable();
        if(137121792 == 0)
        {
                return;
        }
        
        if(mem[137121850] == false)
        {
                return;
        }
        
        this.sprite.color = new UnityEngine.Color() {r = mem[137121852], g = mem[137121856], b = static_value_082C5044, a = static_value_082C5048};
    }
    public override void UnSelect()
    {
        this.UnSelect();
        if(this.border == 0)
        {
                return;
        }
        
        this.border.enabled = false;
    }
    private void OnClick()
    {
        goto typeof(UIMapIcon).__il2cppRuntimeField_188;
    }
    private void OnSelect(bool 丞丈丌且东丆丅丗万)
    {
        if(丞丈丌且东丆丅丗万 != false)
        {
                this = ???;
        }
        else
        {
                if((UnityEngine.Input.GetKey(key:  48)) == true)
        {
                return;
        }
        
            if((val_7 + 24.forceSelection) != false)
        {
                return;
        }
        
            this.业丆不东业丌丛丏世();
        }
    
    }
    private void OnKey(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(下上丐丆丝丟丝丒不 != 27)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        this.OnSelect(丞丈丌且东丆丅丗万:  false);
    }
    protected override void 丗丘专丁下丗一一丕()
    {
        float val_13;
        float val_14;
        if(true != 0)
        {
                return;
        }
        
        if((fadeOutAfterDelay > 0f) && (true == 0))
        {
                mem[1152921535448048412] = 1;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丂丑不丅丛丘上丕丂());
        }
        
        TweenAlpha val_5 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this.sprite.cachedGameObject, 与丈业丛丝丒丙一丏:  0.3f, 与专丌丅丙上丌一丄:  1f);
        if(val_5 != null)
        {
                val_5.from = 0f;
        }
        else
        {
                mem[120] = 0;
        }
        
        mem2[0] = 0;
        if(val_5.loopAnimation != true)
        {
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_13 = val_8.x;
            val_14 = val_8.z;
            this.sprite.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_13, y = val_8.y, z = val_14};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            TweenScale val_11 = TweenScale.Begin(丝三丁东丈丒世丅业:  this.sprite.cachedGameObject, 与丈业丛丝丒丙一丏:  0.5f, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            mem2[0] = 4;
        }
        
        if(4 != 0)
        {
                val_13 = mem[X21 + 60];
            val_13 = X21 + 60;
            val_14 = mem[X21 + 68];
            val_14 = X21 + 68;
            this.sprite.color = new UnityEngine.Color() {r = val_13, g = X21 + 60 + 4, b = val_14, a = X21 + 68 + 4};
        }
        
        mem[1152921535448048370] = 1;
    }
    protected override void 且丁丛丏业业万丄丁()
    {
        if(loopAnimation == false)
        {
                return;
        }
        
        mem[1152921535448230024] = 1;
        if(this.丈三丆上丛三丞丁丛 != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        this.丈三丆上丛三丞丁丛 = TweenScale.Begin(丝三丁东丈丒世丅业:  this.sprite.cachedGameObject, 与丈业丛丝丒丙一丏:  1f, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  1.5f);
        val_5.from = val_7;
        mem2[0] = val_7.y;
        mem2[0] = val_7.z;
        mem2[0] = 2;
        this = this.丈三丆上丛三丞丁丛;
        mem2[0] = 0;
    }
    protected override void 丒丈丅专七丞丑丏丌()
    {
        TweenAlpha val_2 = TweenAlpha.Begin(丝三丁东丈丒世丅业:  this.sprite.cachedGameObject, 与丈业丛丝丒丙一丏:  1f, 与专丌丅丙上丌一丄:  0f);
        mem2[0] = 0;
        mem[1152921535448378908] = 0;
    }
    public void Reset()
    {
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        UnityEngine.Object val_37;
        var val_39;
        int val_40;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        UISpriteData val_4 = NJGMap.instance.GetSprite(丁丅丈丌丟世丗丗丟:  X22 + 40);
        this.sprite.name = "Icon_" + val_4.name;
        this.typeIcon = "Icon_";
        UISpriteData val_7 = NJGMap.instance.GetSprite(丁丅丈丌丟世丗丗丟:  X22 + 40 + 40);
        this.sprite.spriteName = val_7.name;
        int val_8 = val_7.name.depth;
        this.sprite.depth = val_8 + 1;
        UnityEngine.Color val_10 = val_8.color;
        this.sprite.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
        UnityEngine.Vector2 val_11 = this.sprite.localSize;
        val_32 = val_11.x;
        bool val_12 = this.sprite.isAnchoredHorizontally;
        val_33 = val_11.x;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_33, y = val_11.y, z = val_10.b});
        val_34 = val_13.x;
        val_35 = val_32;
        val_36 = val_11.y;
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_35, y = val_36}, rhs:  new UnityEngine.Vector2() {x = val_34, y = val_13.y})) == false)
        {
            goto label_21;
        }
        
        val_37 = 0;
        if((this.sprite == val_37) || (val_8 == 0))
        {
            goto label_34;
        }
        
        bool val_16 = this.sprite.isAnchoredHorizontally;
        val_39 = null;
        val_33 = val_34;
        val_39 = null;
        val_35 = val_35;
        val_36 = val_36;
        val_34 = val_33;
        val_37 = 0;
        size = new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_34};
        if((val_8 == 0) || (val_8 != null))
        {
            goto label_34;
        }
        
        bool val_18 = this.sprite.isAnchoredHorizontally;
        val_33 = val_34;
        val_34 = val_33;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_34});
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_39;
        }
        
        }
        
        label_39:
        val_35 = val_19.x;
        val_36 = val_19.y;
        val_37 = 0;
        (val_8 == null) ? (val_8) : 0.size = new UnityEngine.Vector2() {x = val_35, y = val_36};
        label_34:
        this.sprite.width = (int)val_35;
        val_32 = val_36;
        this.sprite.height = (int)val_32;
        label_21:
        val_40 = mem[val_8 + 40];
        val_40 = val_8 + 40;
        if((NJGMap.instance.GetSpriteBorder(丁丅丈丌丟世丗丗丟:  val_40)) == null)
        {
                return;
        }
        
        val_40 = this.border;
        if(val_40 == 0)
        {
                return;
        }
        
        this.border.spriteName = val_22.name;
        int val_24 = this.border.depth;
        this.border.depth = val_24 + 1;
        UnityEngine.Color val_26 = val_24.color;
        this.border.color = new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a};
        UnityEngine.Vector2 val_27 = this.border.localSize;
        val_32 = val_27.x;
        bool val_28 = this.border.canBeAnchored;
        val_33 = val_27.x;
        UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_33, y = val_27.y, z = val_26.b});
        if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_32, y = val_27.y}, rhs:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y})) == false)
        {
                return;
        }
        
        this.border.width = (int)val_32;
        bool val_31 = this.border.canBeAnchored;
        this.border.height = (int)val_27.y;
    }
    public UIMapIcon()
    {
        this.typeIcon = 0;
    }

}
