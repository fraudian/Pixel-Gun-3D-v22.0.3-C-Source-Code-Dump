using UnityEngine;
public class ShadowCaster : PGBehaviour
{
    // Fields
    private UnityEngine.LayerMask _ground;
    private UnityEngine.Material _shadow;
    private UnityEngine.Transform _shadowObj;
    private float maxDistance;
    private UnityEngine.Transform 丛丞世丐丆丌东丂丁;
    private UnityEngine.Vector3 丞且丅三三东不丄且;
    
    // Methods
    private void Start()
    {
        this.丛丞世丐丆丌东丂丁 = this.丌丟丄业且三丛丕丄().parent;
        UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().localPosition;
        this.丞且丅三三东不丄且 = val_4;
        mem[1152921539756947332] = val_4.y;
        mem[1152921539756947336] = val_4.z;
        this._shadow = UnityEngine.Object.Instantiate<System.Object>(original:  this._shadow);
        this._shadowObj.GetComponent<UnityEngine.Renderer>().sharedMaterial = this._shadow;
        this.transform.parent = 0;
    }
    private void LateUpdate()
    {
        if(this.丛丞世丐丆丌东丂丁 != 0)
        {
                if((this.丛丞世丐丆丌东丂丁.Equals(other:  0)) == false)
        {
            goto label_5;
        }
        
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_5:
        UnityEngine.Vector3 val_5 = this.丛丞世丐丆丌东丂丁.position;
        this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Vector3 val_7 = this.transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, direction:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  this.maxDistance, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this._ground}))) != false)
        {
                UnityEngine.Vector3 val_12 = this.transform.position;
            float val_19 = val_12.x;
            float val_18 = this.maxDistance;
            val_18 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_19, y = val_12.y, z = val_12.z})) / val_18;
            val_19 = 1f - val_18;
            this._shadow.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.05f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this._shadowObj.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            this._shadowObj.forward = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            return;
        }
        
        this._shadow.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
    }
    public ShadowCaster()
    {
        this.maxDistance = 2f;
    }

}
