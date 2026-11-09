using UnityEngine;
public class FpsDragUi : UIDragDropItem
{
    // Fields
    private const string 丘丂丗三专丐丑丑丏 = "FPS_PANEL_POSITION_KEY";
    private UnityEngine.Transform _uiRoot;
    private UIPanel _uiPanel;
    private UnityEngine.Transform _target;
    private UISprite _sprite;
    public bool isDetectOnEnable;
    private UnityEngine.Vector2 丙与七世丑丐七丗七;
    private UnityEngine.Vector2 世丙丝一丛三丞世丑;
    private float 丟不丑丑丁丒丞丛下;
    private bool 与专丙丞丄丐丈丐三;
    private UnityEngine.Vector3 丈丄丛一丈业不丟下;
    
    // Properties
    public UnityEngine.Vector3 专丙丈七丁丆业东丗 { get; set; }
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        if(this._sprite == 0)
        {
                this._sprite = this.GetComponent<UISprite>();
        }
        
        UnityEngine.Vector3 val_3 = this.SavedPosition;
        this._target.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        float val_21 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        float val_24 = 0.5f;
        val_21 = (((float)-UnityEngine.Screen.width) * val_24) / val_21;
        float val_22 = (float)UnityEngine.Screen.width;
        val_22 = val_22 * val_24;
        float val_23 = (float)this._sprite.height;
        val_23 = val_23 * val_24;
        val_24 = val_23 + (-384f);
        float val_25 = (float)this._sprite.height;
        val_25 = val_25 * (-0.5f);
        UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_21 + ((float)this._sprite.width * val_24), y:  val_24);
        this.丙与七世丑丐七丗七 = val_19.x;
        mem[1152921537249177608] = val_19.y;
        UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  (val_22 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专()) - ((float)this._sprite.width * val_24), y:  val_25 + 384f);
        this.世丙丝一丛三丞世丑 = val_20.x;
        mem[1152921537249177616] = val_20.y;
    }
    public UnityEngine.Vector3 get_SavedPosition()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "FPS_PANEL_POSITION_KEY")) != true)
        {
                float val_10 = 352f;
            float val_9 = 0.5f;
            float val_8 = (float)-UnityEngine.Screen.width;
            val_8 = val_8 * val_9;
            val_9 = (float)this._sprite.width * val_9;
            val_8 = val_8 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_10 = val_8 + val_10;
            val_9 = val_10 + val_9;
            this = 0.丛丞丟丘东丕上东丙(丗丒丞丒不丏上丏丄:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "FPS_PANEL_POSITION_KEY", 下下丏一丙不丘丌丞:  this);
        }
        
        string val_6 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "FPS_PANEL_POSITION_KEY");
        UnityEngine.Vector3 val_7 = val_6.丂丑且丗丙丅不丅东(丙业与丙丗丝不丈东:  val_6);
        return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public void set_SavedPosition(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "FPS_PANEL_POSITION_KEY", 下下丏一丙不丘丌丞:  this.丛丞丟丘东丕上东丙(丗丒丞丒不丏上丏丄:  new UnityEngine.Vector3() {x = 丙业与丙丗丝不丈东.x, y = 丙业与丙丗丝不丈东.y, z = 丙业与丙丗丝不丈东.z}));
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
        if(((System.Single.TryParse(s:  val_3[0], result: out  float val_4 = -1.773558E-23f)) != false) && ((System.Single.TryParse(s:  val_3[1], result: out  float val_6 = -1.773557E-23f)) != false))
        {
                if((System.Single.TryParse(s:  val_3[2], result: out  float val_8 = -1.773556E-23f)) != false)
        {
                return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    protected override void 丕七业丘丑丅丑且丝(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        UnityEngine.Vector3 val_1 = this._target.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this._target.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.与专丙丞丄丐丈丐三 = true;
    }
    private UnityEngine.Vector3 丏上丛丑丘丗与东丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_1 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.x, min:  this.丙与七世丑丐七丗七, max:  this.世丙丝一丛三丞世丑);
        float val_2 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.y, min:  this.丙与七世丑丐七丗七, max:  this.世丙丝一丛三丞世丑);
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void OnDestroy()
    {
        UnityEngine.Vector3 val_1 = this._target.localPosition;
        this._target.SavedPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    private void 丂丟丑万丆业专一丕()
    {
        if(true == 0)
        {
                return;
        }
        
        this.StopDragging(丝三丁东丈丒世丅业:  UICamera.hoveredObject);
    }
    private void OnEnable()
    {
        this.OnEnable();
        if(this.isDetectOnEnable == false)
        {
                return;
        }
        
        this.与专丙丞丄丐丈丐三 = false;
        UnityEngine.Vector3 val_1 = this._target.localPosition;
        this.丈丄丛一丈业不丟下 = val_1;
        mem[1152921537250443920] = val_1.y;
        mem[1152921537250443924] = val_1.z;
        UnityEngine.Vector3 val_2 = this._target.localPosition;
        UnityEngine.Vector3 val_3 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this._target.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    private void OnDisable()
    {
        this.OnDisable();
        if(this.isDetectOnEnable == false)
        {
                return;
        }
        
        if(this.与专丙丞丄丐丈丐三 != false)
        {
                return;
        }
        
        this._target.localPosition = new UnityEngine.Vector3() {x = this.丈丄丛一丈业不丟下, y = V9.16B, z = V10.16B};
    }
    public FpsDragUi()
    {
        this.丟不丑丑丁丒丞丛下 = 768f;
    }

}
