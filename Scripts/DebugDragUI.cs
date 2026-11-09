using UnityEngine;
public class DebugDragUI : UIDragDropItem
{
    // Fields
    private const string 丆丝不丁丒丞丕丅丂 = "D_ebugW_indowPos_";
    private UnityEngine.Transform _uiRoot;
    private UIPanel _uiPanel;
    private UnityEngine.Transform _target;
    private UISprite _sprite;
    private DebugWindow 一世丐万不丈丁东丁;
    private UnityEngine.Vector2 丙与七世丑丐七丗七;
    private UnityEngine.Vector2 世丙丝一丛三丞世丑;
    private UnityEngine.Vector2 丅丗丘专一丅丛丐丙;
    private UnityEngine.Vector2 世丄不丐丘丗丝丅丞;
    private float 丟不丑丑丁丒丞丛下;
    private UnityEngine.Vector3 专专一丗丈丘东且万;
    private bool 丈丆三且丑丙东丞丈;
    
    // Properties
    internal string 丘丂丗三专丐丑丑丏 { get; }
    public UnityEngine.Vector3 专丙丈七丁丆业东丗 { get; set; }
    
    // Methods
    internal string 丌东一丕丈上专业不()
    {
        return "D_ebugW_indowPos_" + 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.一世丐万不丈丁东丁)(丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.一世丐万不丈丁东丁));
    }
    public UnityEngine.Vector3 get_SavedPosition()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  this.丌东一丕丈上专业不())) != true)
        {
                string val_3 = this.丌东一丕丈上专业不();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_3, 下下丏一丙不丘丌丞:  val_3.丛丞丟丘东丕上东丙(丗丒丞丒不丏上丏丄:  new UnityEngine.Vector3() {x = this.专专一丗丈丘东且万}));
        }
        
        string val_6 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this.丌东一丕丈上专业不());
        return val_6.丂丑且丗丙丅不丅东(丙业与丙丗丝不丈东:  val_6);
    }
    public void set_SavedPosition(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.丌东一丕丈上专业不(), 下下丏一丙不丘丌丞:  this.丛丞丟丘东丕上东丙(丗丒丞丒不丏上丏丄:  new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z}));
    }
    private string 丛丞丟丘东丕上东丙(UnityEngine.Vector3 丗丒丞丒不丏上丏丄)
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丗丒丞丒不丏上丏丄.x != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丗丒丞丒不丏上丏丄.x == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 丗丒丞丒不丏上丏丄.x;
        val_1[1] = "&";
        val_1[2] = 丗丒丞丒不丏上丏丄.y;
        val_1[3] = "&";
        val_1[4] = 丗丒丞丒不丏上丏丄.z;
        return (string)+val_1;
    }
    private UnityEngine.Vector3 丂丑且丗丙丅不丅东(string 丙业与丙丗丝不丈东)
    {
        var val_11;
        char[] val_1 = new char[1];
        val_11 = "&";
        if(("&") == null)
        {
                val_11 = "&";
        }
        
        val_1[0] = Chars[0];
        System.String[] val_3 = 丙业与丙丗丝不丈东.Split(separator:  val_1);
        if(((System.Single.TryParse(s:  val_3[0], result: out  float val_4 = -8.9701E-30f)) != false) && ((System.Single.TryParse(s:  val_3[1], result: out  float val_6 = -8.970097E-30f)) != false))
        {
                if((System.Single.TryParse(s:  val_3[2], result: out  float val_8 = -8.970088E-30f)) != false)
        {
                return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    protected override void Awake()
    {
        float val_61;
        float val_62;
        float val_63;
        float val_64;
        float val_65;
        float val_66;
        float val_67;
        float val_68;
        float val_69;
        float val_70;
        float val_71;
        float val_72;
        float val_73;
        float val_74;
        float val_75;
        float val_76;
        float val_77;
        float val_78;
        this.Awake();
        if(this._sprite == 0)
        {
                this._sprite = this.GetComponent<UISprite>();
        }
        
        if(this.一世丐万不丈丁东丁 == 0)
        {
                this.一世丐万不丈丁东丁 = this._uiPanel.GetComponent<DebugWindow>();
            val_4.世东丐丁七丞七上丐 = this;
        }
        
        if(this._uiRoot == 0)
        {
                this._uiRoot = this._uiPanel.transform.parent;
        }
        
        UnityEngine.Vector3 val_8 = this._uiRoot.position;
        UnityEngine.Vector3 val_10 = this._uiRoot.position;
        UnityEngine.Vector3 val_12 = this._uiRoot.position;
        UnityEngine.Vector3 val_14 = this._uiRoot.position;
        UnityEngine.Vector3 val_16 = this._uiRoot.position;
        UnityEngine.Vector3 val_18 = this._uiRoot.position;
        UnityEngine.Vector3 val_20 = this._uiRoot.position;
        val_61 = (float)this._sprite.width;
        val_62 = S13 - val_10.x;
        val_63 = val_10.x - val_12.y;
        val_64 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        val_65 = S10 - val_8.x;
        val_66 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        val_67 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        val_68 = (float)this._sprite.width;
        val_69 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        val_70 = (float)this._sprite.height;
        val_71 = this.丟不丑丑丁丒丞丛下 - val_14.y;
        val_72 = (float)this._sprite.height;
        val_73 = (float)this.一世丐万不丈丁东丁.widget.width;
        val_74 = (float)this.一世丐万不丈丁东丁.widget.width;
        val_75 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        val_76 = this.丟不丑丑丁丒丞丛下 - val_16.x;
        val_77 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        val_78 = this.丟不丑丑丁丒丞丛下 - val_18.x;
        float val_22 = this.丟不丑丑丁丒丞丛下 * 0.5f;
        if(this._uiRoot == null)
        {
                val_76 = val_76;
            val_75 = val_75;
            val_72 = val_72;
            val_78 = val_78;
            val_67 = val_67;
            val_70 = val_70;
            val_63 = val_63;
            val_69 = val_69;
            val_68 = val_68;
            val_62 = val_62;
            val_66 = val_66;
            val_61 = val_61;
            val_65 = val_65;
            val_64 = val_64;
            val_74 = val_74;
            val_71 = val_71;
            val_77 = val_77;
            val_73 = val_73;
        }
        
        float val_35 = val_74 * 0.5f;
        val_22 = val_22 * (this.丟不丑丑丁丒丞丛下 - val_20.y);
        UnityEngine.Vector3 val_37 = this._uiRoot.position;
        float val_49 = val_64 * val_65;
        val_35 = (val_77 * val_78) - val_35;
        val_49 = val_49 + (val_61 * 0.5f);
        float val_50 = val_66 * val_62;
        val_50 = val_50 - (val_68 * 0.5f);
        float val_51 = val_67 * val_71;
        val_51 = val_51 - (val_72 * 0.5f);
        float val_52 = val_75 * val_76;
        val_52 = val_52 + (val_73 * 0.5f);
        float val_53 = this.丟不丑丑丁丒丞丛下;
        float val_54 = this.丟不丑丑丁丒丞丛下;
        val_53 = val_53 * 0.5f;
        val_54 = val_54 - val_37.y;
        val_53 = val_53 * val_54;
        UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  val_49, y:  (val_69 * val_63) + (val_70 * 0.5f));
        this.丙与七世丑丐七丗七 = val_43.x;
        mem[1152921537074632892] = val_43.y;
        UnityEngine.Vector2 val_44 = new UnityEngine.Vector2(x:  val_50, y:  val_51);
        this.世丙丝一丛三丞世丑 = val_44.x;
        mem[1152921537074632900] = val_44.y;
        UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_52, y:  val_22 + ((float)this.一世丐万不丈丁东丁.widget.height * 0.5f));
        this.丅丗丘专一丅丛丐丙 = val_45.x;
        mem[1152921537074632908] = val_45.y;
        UnityEngine.Vector2 val_46 = new UnityEngine.Vector2(x:  val_35, y:  val_53 - ((float)this.一世丐万不丈丁东丁.widget.height * 0.5f));
        this.世丄不丐丘丗丝丅丞 = val_46.x;
        mem[1152921537074632916] = val_46.y;
        UnityEngine.Vector3 val_47 = this._target.localPosition;
        UnityEngine.Vector3 val_48 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
        this._target.localPosition = new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z};
    }
    internal void 七丒下丂丝且丕丌东()
    {
        UnityEngine.Vector3 val_1 = this._target.localPosition;
        UnityEngine.Vector3 val_2 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        this._target.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    protected override void 丕七业丘丑丅丑且丝(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        UnityEngine.Vector3 val_1 = this._target.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this._target.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    private UnityEngine.Vector3 丏上丛丑丘丗与东丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector2 val_3;
        if(this.一世丐万不丈丁东丁.丗下丟万不丁且与丆 != false)
        {
                val_3 = this.丅丗丘专一丅丛丐丙;
        }
        else
        {
                val_3 = this.丙与七世丑丐七丗七;
        }
        
        float val_1 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.x, min:  val_3, max:  this.世丙丝一丛三丞世丑);
        float val_2 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.y, min:  val_3, max:  this.世丙丝一丛三丞世丑);
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void OnApplicationFocus(bool 丄丈丁下丛世丙丗上)
    {
        this.丈丆三且丑丙东丞丈 = 丄丈丁下丛世丙丗上;
    }
    private void Update()
    {
        if(this.丈丆三且丑丙东丞丈 != false)
        {
                return;
        }
        
        if(this.丈丆三且丑丙东丞丈 == false)
        {
                return;
        }
        
        this.StopDragging(丝三丁东丈丒世丅业:  UICamera.hoveredObject);
    }
    private void 丂丟丑万丆业专一丕()
    {
        if(true == 0)
        {
                return;
        }
        
        this.StopDragging(丝三丁东丈丒世丅业:  UICamera.hoveredObject);
    }
    private void OnDestroy()
    {
        UnityEngine.Vector3 val_1 = this._target.localPosition;
        this.SavedPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public DebugDragUI()
    {
        this.丟不丑丑丁丒丞丛下 = 768f;
        this.丈丆三且丑丙东丞丈 = true;
        this.专专一丗丈丘东且万 = 0;
        mem[1152921537075741924] = 0;
    }

}
