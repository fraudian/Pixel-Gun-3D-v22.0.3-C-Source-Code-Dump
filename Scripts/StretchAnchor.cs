using UnityEngine;
internal class StretchAnchor : MonoBehaviour
{
    // Fields
    internal UIRect.丘一丄与上世丑七丅 ExecuteMode;
    internal UnityEngine.GameObject _leftAnchor;
    internal UnityEngine.GameObject _rightAnchor;
    private UIWidget 丐丂丏世丄丐丝丐万;
    private float 丆七丞丈上丌丟专丟;
    public UnityEngine.Vector3 pos1;
    public UnityEngine.Vector3 pos2;
    public float distance;
    
    // Methods
    private void Start()
    {
        if(this.ExecuteMode != 2)
        {
                return;
        }
        
        this.丟下丅丙七丁丞万与();
        this.丕丕业七丙七丅丈丄();
    }
    private void OnEnable()
    {
        this.丟下丅丙七丁丞万与();
        if(this.ExecuteMode != 0)
        {
                return;
        }
        
        this.丕丕业七丙七丅丈丄();
    }
    private void LateUpdate()
    {
        if(this.ExecuteMode != 1)
        {
                return;
        }
        
        this.丕丕业七丙七丅丈丄();
    }
    private void 丟下丅丙七丁丞万与()
    {
        float val_7;
        this.丐丂丏世丄丐丝丐万 = this.GetComponent<UIWidget>();
        UnityEngine.GameObject val_3 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject);
        if(val_3 != 0)
        {
                UnityEngine.Vector3 val_6 = val_3.transform.localScale;
            val_7 = 1f / val_6.x;
            this.丆七丞丈上丌丟专丟 = val_7;
        }
        else
        {
                val_7 = 1f;
        }
        
        this.丆七丞丈上丌丟专丟 = val_7;
    }
    private void 丕丕业七丙七丅丈丄()
    {
        var val_40;
        float val_41;
        float val_42;
        float val_43;
        if(this._leftAnchor == 0)
        {
                return;
        }
        
        if(this._rightAnchor == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_5 = this._leftAnchor.transform.position;
        val_40 = this._rightAnchor.transform;
        UnityEngine.Vector3 val_7 = val_40.position;
        val_41 = val_7.y;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_41, z = val_7.z}, t:  0.5f);
        this.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_10 = this._rightAnchor.transform.position;
        UnityEngine.Vector3 val_12 = this.transform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_15 = this._rightAnchor.transform.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_15.y * 57.29578f);
        val_42 = val_17.x;
        val_43 = val_17.z;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_42, y = val_17.y, z = val_43, w = val_17.w};
        if(this.丐丂丏世丄丐丝丐万 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_21 = 不丌丂丁丄一与丆丙.丅丟东不三丘七丑丙(丝三丁东丈丒世丅业:  this.gameObject);
        UnityEngine.Matrix4x4 val_23 = val_21.transform.worldToLocalMatrix;
        val_40 = this._rightAnchor.transform;
        UnityEngine.Vector3 val_29 = val_40.localPosition;
        this.pos1 = val_29;
        mem[1152921539441047200] = val_29.y;
        mem[1152921539441047204] = val_29.z;
        UnityEngine.Matrix4x4 val_31 = val_21.transform.worldToLocalMatrix;
        UnityEngine.Vector3 val_37 = this._leftAnchor.transform.localPosition;
        val_43 = val_37.z;
        this.pos2 = val_37;
        mem[1152921539441047212] = val_37.y;
        mem[1152921539441047216] = val_43;
        val_42 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.pos1, y = val_17.w, z = val_41}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_43});
        this.distance = val_42;
        this.丐丂丏世丄丐丝丐万.width = (int)val_42;
    }
    public StretchAnchor()
    {
        this.ExecuteMode = 1;
    }

}
