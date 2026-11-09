using UnityEngine;
public class IMDragAndDrop : UIDragDropItem
{
    // Fields
    internal UIWidget _widget;
    private UISprite _sprite;
    private UnityEngine.Vector2 丙与七世丑丐七丗七;
    private UnityEngine.Vector2 世丙丝一丛三丞世丑;
    public UnityEngine.Vector2 scale;
    private float 丟不丑丑丁丒丞丛下;
    public bool axisX;
    public bool axisY;
    public bool positionMouseToLocal;
    private bool 丈丆三且丑丙东丞丈;
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        this.丌七丏且不丘丗东丅();
    }
    internal void 丌七丏且不丘丗东丅()
    {
        UISprite val_23;
        var val_24;
        var val_25;
        float val_27;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        var val_34;
        var val_35;
        if(this._sprite == 0)
        {
                val_23 = this.GetComponent<UISprite>();
            this._sprite = val_23;
        }
        else
        {
                val_23 = this._sprite;
        }
        
        if(null == null)
        {
                val_24 = 0;
        }
        
        if(val_23 != 0)
        {
                val_27 = (float)this._sprite.height;
            val_29 = val_27 * 0.5f;
            val_30 = (float)this._sprite.width;
            val_31 = (???) + ((float)this._sprite.width * (-0.5f));
            val_32 = S9 + val_29;
            val_33 = (float)this._sprite.height;
            val_25 = V10.16B;
        }
        else
        {
                val_30 = this.scale;
            if(null <= 2)
        {
                val_34 = 0;
        }
        
            UnityEngine.Vector2 val_18 = this.scale;
            if(null == null)
        {
                val_35 = 0;
        }
        
            val_18 = val_18 * (-0.5f);
            val_27 = S13 * 0.5f;
            val_31 = S8 + val_18;
            val_32 = S12 + val_27;
        }
        
        float val_19 = 0.5f;
        val_19 = S0 * val_19;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  S10 + (val_30 * val_19), y:  val_32);
        this.丙与七世丑丐七丗七 = val_12.x;
        mem[1152921537627421316] = val_12.y;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_31, y:  S13 - val_19);
        this.世丙丝一丛三丞世丑 = val_13.x;
        mem[1152921537627421324] = val_13.y;
        UnityEngine.Vector3 val_16 = this.transform.localPosition;
        UnityEngine.Vector3 val_17 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    protected override void 丕七业丘丑丅丑且丝(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        var val_20;
        float val_24;
        float val_25;
        float val_26;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if(this.positionMouseToLocal != false)
        {
                val_20 = null;
            val_20 = null;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UICamera.currentTouch.下业丕七东丌丝下且, y = UICamera.currentTouch + 20 + 4});
            UnityEngine.Vector3 val_6 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.gameObject.layer).ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Matrix4x4 val_8 = this._widget.transform.worldToLocalMatrix;
            val_24 = val_6.x;
            val_25 = val_6.y;
            val_26 = val_6.z;
        }
        else
        {
                UnityEngine.Vector3 val_14 = this.transform.localPosition;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
            val_24 = val_14.x;
            val_25 = val_14.y;
            val_26 = val_14.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        }
        
        UnityEngine.Vector3 val_17 = this.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    private UnityEngine.Vector3 丏上丛丑丘丗与东丂(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_7;
        var val_8;
        var val_10;
        val_7 = this;
        val_8 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.x, min:  this.丙与七世丑丐七丗七, max:  this.世丙丝一丛三丞世丑);
        val_10 = UnityEngine.Mathf.Clamp(value:  业丒丝丗与丐丛丟丏.y, min:  this.丙与七世丑丐七丗七, max:  this.世丙丝一丛三丞世丑);
        if(this.axisX != true)
        {
                UnityEngine.Vector3 val_4 = this.transform.localPosition;
            val_8 = val_4.x;
        }
        
        if(this.axisY != true)
        {
                val_7 = this.transform;
            UnityEngine.Vector3 val_6 = val_7.localPosition;
            val_10 = val_6.y;
        }
        
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
    public IMDragAndDrop()
    {
        this.丟不丑丑丁丒丞丛下 = 768f;
        this.axisX = true;
        this.axisY = true;
        this.丈丆三且丑丙东丞丈 = true;
    }

}
