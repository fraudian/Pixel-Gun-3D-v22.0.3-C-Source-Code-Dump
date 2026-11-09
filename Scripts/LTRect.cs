using UnityEngine;
[Serializable]
public class LTRect
{
    // Fields
    public UnityEngine.Rect _rect;
    public float alpha;
    public float rotation;
    public UnityEngine.Vector2 pivot;
    public UnityEngine.Vector2 margin;
    public UnityEngine.Rect relativeRect;
    public bool rotateEnabled;
    public bool rotateFinished;
    public bool alphaEnabled;
    public string labelStr;
    public 万丁且丒丂七丐不三.丘三万且丁七丁丟丞 type;
    public UnityEngine.GUIStyle style;
    public bool useColor;
    public UnityEngine.Color color;
    public bool fontScaleToFit;
    public bool useSimpleScale;
    public bool sizeByHeight;
    public UnityEngine.Texture texture;
    private int _id;
    public int counter;
    public static bool colorTouched;
    
    // Properties
    public bool hasInitiliazed { get; }
    public int id { get; }
    public float x { get; set; }
    public float y { get; set; }
    public float width { get; set; }
    public float height { get; set; }
    public UnityEngine.Rect rect { get; set; }
    
    // Methods
    public LTRect()
    {
        this.alpha = 1f;
        this.relativeRect = 0;
        mem[1152921535398260652] = 0;
        mem[1152921535398260660] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921535398260704] = val_1.g;
        mem[1152921535398260708] = val_1.b;
        mem[1152921535398260712] = val_1.a;
        this._id = 0;
        this.丞专丙万丕不丗丈丛();
        this.alphaEnabled = true;
        this.rotateEnabled = true;
        this._rect = 0;
        mem[1152921535398260612] = 0;
        mem[1152921535398260620] = 0;
    }
    public LTRect(UnityEngine.Rect 丝丆丏丕丕丕丗丛业)
    {
        this.alpha = 1f;
        this.relativeRect = 0;
        mem[1152921535398372652] = 0;
        mem[1152921535398372660] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921535398372704] = val_1.g;
        mem[1152921535398372708] = val_1.b;
        mem[1152921535398372712] = val_1.a;
        this._id = 0;
        this._rect = 丝丆丏丕丕丕丗丛业;
        mem[1152921535398372612] = 丝丆丏丕丕丕丗丛业.m_YMin;
        mem[1152921535398372616] = 丝丆丏丕丕丕丗丛业.m_Width;
        mem[1152921535398372620] = 丝丆丏丕丕丕丗丛业.m_Height;
        this.丞专丙万丕不丗丈丛();
    }
    public LTRect(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 业与三万七丝不万东, float 丟丌丐丘丆丙丑丑一)
    {
        this.alpha = 1f;
        this.relativeRect = 0;
        mem[1152921535398484652] = 0;
        mem[1152921535398484660] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921535398484704] = val_1.g;
        mem[1152921535398484708] = val_1.b;
        mem[1152921535398484712] = val_1.a;
        this._id = 0;
        this.alpha = 1f;
        this.rotation = 0f;
        this.alphaEnabled = false;
        this._rect = 0;
        mem[1152921535398484612] = 0;
        mem[1152921535398484620] = 0;
        this.rotateEnabled = false;
    }
    public LTRect(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 业与三万七丝不万东, float 丟丌丐丘丆丙丑丑一, float 与专丌丅丙上丌一丄)
    {
        this.alpha = 1f;
        this.relativeRect = 0;
        mem[1152921535398596652] = 0;
        mem[1152921535398596660] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921535398596704] = val_1.g;
        mem[1152921535398596708] = val_1.b;
        mem[1152921535398596712] = val_1.a;
        this._id = 0;
        this.alpha = 与专丌丅丙上丌一丄;
        this.rotation = 0f;
        this.alphaEnabled = false;
        this._rect = 0;
        mem[1152921535398596612] = 0;
        mem[1152921535398596620] = 0;
        this.rotateEnabled = false;
    }
    public LTRect(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 业与三万七丝不万东, float 丟丌丐丘丆丙丑丑一, float 与专丌丅丙上丌一丄, float 七丅丗丆丒丌丑丝不)
    {
        this.alpha = 1f;
        this.relativeRect = 0;
        mem[1152921535398708652] = 0;
        mem[1152921535398708660] = 0;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921535398708704] = val_1.g;
        mem[1152921535398708708] = val_1.b;
        mem[1152921535398708712] = val_1.a;
        this._id = 0;
        this.alpha = 与专丌丅丙上丌一丄;
        this.rotation = 七丅丗丆丒丌丑丝不;
        this.alphaEnabled = false;
        this._rect = 0;
        mem[1152921535398708612] = 0;
        mem[1152921535398708620] = 0;
        this.rotateEnabled = false;
        if(七丅丗丆丒丌丑丝不 == 0f)
        {
                return;
        }
        
        this.rotateEnabled = true;
        this.与丛丏丝业万三丏丕();
    }
    public bool get_hasInitiliazed()
    {
        return (bool)(this._id != 1) ? 1 : 0;
    }
    public int get_id()
    {
        return (int)this._id | (this.counter << 16);
    }
    public void 丐世下不一丁丟丅专(int 丞丅上丏丂且下丅与, int 丘丛丆七与丒世下丛)
    {
        this._id = 丞丅上丏丂且下丅与;
        this.counter = 丘丛丆七与丒世下丛;
    }
    public void 丞专丙万丕不丗丈丛()
    {
        this.alphaEnabled = false;
        this.rotateEnabled = false;
        this.alpha = 1f;
        this.rotation = 0f;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.margin = val_1;
        mem[1152921535399156644] = val_1.y;
        this.sizeByHeight = false;
        this.useColor = false;
    }
    public void 与丛丏丝业万三丏丕()
    {
        var val_4;
        var val_10;
        var val_16;
        float val_29;
        UnityEngine.Matrix4x4 val_1 = UnityEngine.GUI.matrix;
        UnityEngine.Matrix4x4 val_7 = UnityEngine.GUI.matrix;
        float val_12 = val_10.Item[1, 1];
        UnityEngine.Matrix4x4 val_13 = UnityEngine.GUI.matrix;
        float val_18 = val_16.Item[2, 2];
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.zero;
        if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this.pivot, y = val_4.Item[0, 0]}, rhs:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y})) == false)
        {
                return;
        }
        
        float val_21 = this._rect.x;
        val_29 = val_21;
        UnityEngine.Matrix4x4 val_22 = UnityEngine.GUI.matrix;
        float val_23 = val_4.Item[0, 3];
        UnityEngine.Matrix4x4 val_24 = UnityEngine.GUI.matrix;
        float val_28 = 0.5f;
        float val_26 = val_21 * val_28;
        val_28 = val_23 * val_28;
        val_26 = val_29 + val_26;
        val_28 = val_23 + val_28;
        val_26 = 0f * val_26;
        val_28 = 0f * val_28;
        val_26 = val_26 + val_23;
        val_28 = val_28 + val_10.Item[1, 3];
        UnityEngine.Vector2 val_27;
        val_16 = 0;
        val_27 = new UnityEngine.Vector2(x:  val_26, y:  val_28);
        this.pivot = val_27.x;
        mem[1152921535399289356] = val_27.y;
    }
    public float get_x()
    {
        return this._rect.x;
    }
    public void set_x(float 丙业与丙丗丝不丈东)
    {
        this._rect.x = 丙业与丙丗丝不丈东;
    }
    public float get_y()
    {
    
    }
    public void set_y(float 丙业与丙丗丝不丈东)
    {
    
    }
    public float get_width()
    {
    
    }
    public void set_width(float 丙业与丙丗丝不丈东)
    {
    
    }
    public float get_height()
    {
    
    }
    public void set_height(float 丙业与丙丗丝不丈东)
    {
    
    }
    public UnityEngine.Rect get_rect()
    {
        float val_8;
        float val_13;
        float val_14;
        float val_15;
        int val_16;
        if(LTRect.colorTouched != false)
        {
                LTRect.colorTouched = false;
            UnityEngine.Color val_1 = UnityEngine.GUI.color;
            val_8 = val_1.r;
            UnityEngine.Color val_2 = UnityEngine.GUI.color;
            UnityEngine.Color val_3 = UnityEngine.GUI.color;
            val_13 = 0f;
            val_14 = 0f;
            val_15 = 0f;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_13, g = val_14, b = 0f, a = val_15};
        }
        
        if(this.rotateEnabled != false)
        {
                if(this.rotateFinished != false)
        {
                this.rotateEnabled = false;
            this.rotateFinished = false;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this.pivot = val_4;
            mem[1152921535400322172] = val_4.y;
        }
        else
        {
                val_13 = this.rotation;
            val_14 = this.pivot;
            UnityEngine.GUIUtility.RotateAroundPivot(angle:  val_13, pivotPoint:  new UnityEngine.Vector2() {x = val_14, y = 0f});
        }
        
        }
        
        if(this.alphaEnabled != false)
        {
                UnityEngine.Color val_5 = UnityEngine.GUI.color;
            val_8 = val_5.r;
            UnityEngine.Color val_6 = UnityEngine.GUI.color;
            UnityEngine.Color val_7 = UnityEngine.GUI.color;
            val_13 = 0f;
            val_14 = 0f;
            val_15 = 0f;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_13, g = val_14, b = 0f, a = val_15};
            LTRect.colorTouched = true;
        }
        
        if(this.fontScaleToFit == false)
        {
                return new UnityEngine.Rect() {m_XMin = this._rect, m_YMin = val_14, m_Width = 0f, m_Height = val_15};
        }
        
        val_8 = val_13;
        if(this.useSimpleScale != false)
        {
                val_13 = val_8 * val_13;
            val_16 = (int)val_13;
        }
        else
        {
                val_16 = 0;
        }
        
        this.style.fontSize = val_16;
        return new UnityEngine.Rect() {m_XMin = this._rect, m_YMin = val_14, m_Width = 0f, m_Height = val_15};
    }
    public void set_rect(UnityEngine.Rect 丙业与丙丗丝不丈东)
    {
        this._rect = 丙业与丙丗丝不丈东;
        mem[1152921535400438244] = 丙业与丙丗丝不丈东.m_YMin;
        mem[1152921535400438248] = 丙业与丙丗丝不丈东.m_Width;
        mem[1152921535400438252] = 丙业与丙丗丝不丈东.m_Height;
    }
    public LTRect 万世丕丙丑丘丄丟丛(UnityEngine.GUIStyle 丏东丆丆丛丄丕丈丞)
    {
        this.style = 丏东丆丆丛丄丕丈丞;
        return (LTRect)this;
    }
    public LTRect 专三专与丄丌丂丕万(bool 丂世丆丄三丁业丞丅)
    {
        this.fontScaleToFit = 丂世丆丄三丁业丞丅;
        return (LTRect)this;
    }
    public LTRect 丒丂丗丗丁三丑丄丙(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.color = 丑丞丈丗丄丙丟万丄;
        mem[1152921535400782528] = 丑丞丈丗丄丙丟万丄.g;
        mem[1152921535400782532] = 丑丞丈丗丄丙丟万丄.b;
        mem[1152921535400782536] = 丑丞丈丗丄丙丟万丄.a;
        this.useColor = true;
        return (LTRect)this;
    }
    public LTRect 丌丟东丈专丛丆专与(float 与专丌丅丙上丌一丄)
    {
        this.alpha = 与专丌丅丙上丌一丄;
        return (LTRect)this;
    }
    public LTRect 丏万一丄丛不丒丆且(string 下业七不丑丂丏丟东)
    {
        this.labelStr = 下业七不丑丂丏丟东;
        return (LTRect)this;
    }
    public LTRect 丈一丛丗丛业丒丅下(bool 丘丘万丕世三不丈不, UnityEngine.Rect 业万丞丗丙丝丈一七)
    {
        this.relativeRect = 业万丞丗丙丝丈一七;
        mem[1152921535401126668] = 业万丞丗丙丝丈一七.m_YMin;
        this.useSimpleScale = 丘丘万丕世三不丈不;
        mem[1152921535401126672] = 业万丞丗丙丝丈一七.m_Width;
        mem[1152921535401126676] = 业万丞丗丙丝丈一七.m_Height;
        return (LTRect)this;
    }
    public LTRect 丈一丛丗丛业丒丅下(bool 丘丘万丕世三不丈不)
    {
        this.useSimpleScale = 丘丘万丕世三不丈不;
        int val_2 = UnityEngine.Screen.width;
        int val_3 = UnityEngine.Screen.height;
        this.relativeRect = 0;
        mem[1152921535401238668] = 0;
        mem[1152921535401238676] = 0;
        return (LTRect)this;
    }
    public LTRect 丝丆东丗上丄丅专丐(bool 七丝丘丕丁上丁丏下)
    {
        this.sizeByHeight = 七丝丘丕丁上丁丏下;
        return (LTRect)this;
    }
    public override string ToString()
    {
        object[] val_1 = new object[4];
        float val_2 = this._rect.x;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = val_2;
        val_1[2] = val_2;
        val_1[3] = val_2;
        return (string)System.String.Format(format:  "x:{0} y:{1} width:{2} height:{3}", args:  val_1);
    }

}
