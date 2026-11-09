using UnityEngine;
internal sealed class ThirdCameraPivod : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform cameraPivotDefault;
    public UnityEngine.Transform cameraPivot;
    public UnityEngine.Transform cameraVisualPivot;
    public UnityEngine.LayerMask collisionLayer;
    private float 丅丄业丆东丂丝丝丙;
    public float approximation;
    private FirstPersonControlSharp firstPeson;
    private float 世丑与丒丗上丝业丌;
    private float 与丅三七丏七三丛且;
    private float 丐丁与丏丘丁丙丒丞;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    private bool 丁丑专丄丁丛丄丆东;
    
    // Methods
    private void Start()
    {
        this.万一丂丐丄丁上与丟 = this.transform;
        UnityEngine.Vector3 val_2 = this.cameraVisualPivot.position;
        UnityEngine.Vector3 val_3 = this.cameraPivotDefault.position;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.丅丄业丆东丂丝丝丙 = val_4.x;
    }
    private void Update()
    {
        if(this.firstPeson.丌且下丕下下丌万丞 != true)
        {
                if(this.firstPeson.丄丕丗丗七上丕丒万() == false)
        {
                return;
        }
        
        }
        
        this.七专一不专专东丆专();
    }
    private void LateUpdate()
    {
        this.丆三丁丑丐丑丙一与();
    }
    private void 七专一不专专东丆专()
    {
        FirstPersonControlSharp val_19;
        float val_20;
        var val_21;
        var val_22;
        UnityEngine.Transform val_23;
        float val_27;
        var val_28;
        val_19 = this;
        val_20 = 0;
        val_21 = null;
        val_21 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_13;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = this.cameraPivot;
        if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_16;
        }
        
        val_19 = this.firstPeson;
        if(this.firstPeson.camPivotGliderMiniGame != null)
        {
            goto label_36;
        }
        
        label_37:
        label_36:
        UnityEngine.Vector3 val_3 = 0.position;
        goto label_19;
        label_13:
        UnityEngine.Vector3 val_4 = this.cameraVisualPivot.position;
        UnityEngine.Vector3 val_5 = this.cameraPivotDefault.position;
        if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, end:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.collisionLayer}))) == false)
        {
            goto label_22;
        }
        
        val_27 = val_20.targetValue + (-0.4f);
        if(val_27 >= 0)
        {
            goto label_24;
        }
        
        val_27 = 0f;
        goto label_24;
        label_22:
        val_27 = this.丅丄业丆东丂丝丝丙 + (-0.4f);
        label_24:
        val_23 = this.cameraPivot;
        UnityEngine.Vector3 val_9 = this.cameraVisualPivot.position;
        UnityEngine.Vector3 val_10 = this.cameraPivotDefault.position;
        UnityEngine.Vector3 val_11 = this.cameraVisualPivot.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_27);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.丅丄业丆东丂丝丝丙);
        val_20 = val_9.x;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        label_19:
        val_23.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        return;
        label_16:
        val_28 = null;
        val_28 = null;
        if(Player_move_c.__il2cppRuntimeField_typeHierarchyDepth.transform != null)
        {
            goto label_36;
        }
        
        goto label_37;
    }
    private void 丆三丁丑丐丑丙一与()
    {
        UnityEngine.Vector3 val_1 = this.万一丂丐丄丁上与丟.localPosition;
        float val_8 = val_1.y;
        float val_7 = -1f;
        float val_3 = UnityEngine.Time.deltaTime;
        val_7 = this.丐丁与丏丘丁丙丒丞 * ((this.firstPeson.丐丂丕丂丑三丑丒一 == true) ? (val_7) : 1f);
        val_3 = val_3 * val_7;
        val_8 = val_8 + val_3;
        float val_4 = UnityEngine.Mathf.Clamp(value:  val_8, min:  this.与丅三七丏七三丛且, max:  this.世丑与丒丗上丝业丌);
        UnityEngine.Vector3 val_5 = this.万一丂丐丄丁上与丟.localPosition;
        UnityEngine.Vector3 val_6 = this.万一丂丐丄丁上与丟.localPosition;
        this.万一丂丐丄丁上与丟.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ThirdCameraPivod()
    {
        this.approximation = 1f;
        this.世丑与丒丗上丝业丌 = 1.1f;
        this.与丅三七丏七三丛且 = 0.1f;
        this.丐丁与丏丘丁丙丒丞 = 4f;
    }

}
