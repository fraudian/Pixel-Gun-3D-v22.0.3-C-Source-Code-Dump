using UnityEngine;
public class Waipoint : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform helper;
    public static UnityEngine.Mesh mesh;
    private bool 七东丐丟世丕丏丞且;
    private int 专七丟七一丒丒丂三;
    private int 丆三丟丑世三东丑丐;
    private UnityEngine.Quaternion 丁丁与丄丞丈丏丌世;
    private UnityEngine.Vector3 丒且且与东丂丐专丕;
    private bool 丙不专下丟与世业万;
    public bool updateRoad;
    
    // Properties
    private RoadPart 丏且丆丝不丝丒丂丛 { get; }
    
    // Methods
    private RoadPart 丏与上丝一丕一丟万()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.GetComponentInParent<RoadPart>();
        }
        
        return val_1.GetComponentInParent<RoadPart>();
    }
    private void Start()
    {
        UnityEngine.Mesh val_6 = Waipoint.mesh;
        if((UnityEngine.Object.op_Implicit(exists:  val_6 = Waipoint.mesh)) == true)
        {
                return;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "RoadWaipointMesh");
        if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        
        val_6 = 0.GetComponent<UnityEngine.MeshFilter>();
        Waipoint.mesh = val_6.sharedMesh;
    }
    private void OnDrawGizmos()
    {
        if((UnityEngine.Object.op_Implicit(exists:  Waipoint.mesh)) != true)
        {
                UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "RoadWaipointMesh");
            if(val_2 != null)
        {
                var val_3 = (null == null) ? (val_2) : 0;
        }
        
            Waipoint.mesh = 0.GetComponent<UnityEngine.MeshFilter>().sharedMesh;
        }
        
        UnityEngine.Color val_6 = UnityEngine.Color.red;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        UnityEngine.Quaternion val_8 = this.transform.rotation;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  -90f, y:  180f, z:  0f);
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, rhs:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
        UnityEngine.Vector3 val_12 = this.transform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        UnityEngine.Gizmos.DrawMesh(mesh:  Waipoint.mesh, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, scale:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.z, z = ???});
        UnityEngine.Color val_14 = UnityEngine.Color.green;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a};
        UnityEngine.Vector3 val_16 = this.transform.position;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  5f);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Vector3 val_20 = this.helper.position;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  5f);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, to:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
    }
    private void 丈业丅与丙丝世丌丁()
    {
        if(this.丆三丟丑世三东丑丐 != 0)
        {
                RoadPart val_1 = this.丏与上丝一丕一丟万();
            if(this.丆三丟丑世三东丑丐 != (val_1.waipoints.Count - 1))
        {
                return;
        }
        
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        RoadConnector val_6 = RoadConnector.ClosestConnection(下七与丆丅丙丌丕业:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
        {
                return;
        }
        
        val_6.Connect(丛业丌丕与丛下丞丞:  this, 不且东三三丐世下丝:  (this.丆三丟丑世三东丑丐 == 0) ? 1 : 0);
    }
    private void Update()
    {
        this.世丝与三丈东七丒一();
        this.丁丐不丑丗丐上与丄();
        if(this.丙不专下丟与世业万 != false)
        {
                this.丈业丅与丙丝世丌丁();
        }
        
        if(this.updateRoad == false)
        {
                return;
        }
        
        this.updateRoad = false;
        this.东丝七业丄丑丒世七();
    }
    private void 丁丐不丑丗丐上与丄()
    {
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        UnityEngine.Vector3 val_18;
        float val_20;
        float val_21;
        float val_22;
        UnityEngine.Quaternion val_2 = this.transform.rotation;
        val_13 = val_2.y;
        val_14 = val_2.x;
        val_15 = val_13;
        val_16 = val_2.z;
        if((UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = val_14, y = val_15, z = val_16, w = val_2.w}, rhs:  new UnityEngine.Quaternion() {x = this.丁丁与丄丞丈丏丌世, y = V12.16B, z = V13.16B, w = V11.16B})) == false)
        {
            goto label_7;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        val_17 = val_4.x;
        val_14 = this.丒且且与东丂丐专丕;
        val_15 = val_2.x;
        val_16 = val_13;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, rhs:  new UnityEngine.Vector3() {x = val_17, y = val_4.y, z = val_4.z})) == false)
        {
            goto label_7;
        }
        
        val_18 = this.丒且且与东丂丐专丕;
        val_20 = val_18;
        val_21 = val_13;
        val_22 = this.丒且且与东丂丐专丕;
        this.helper.position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        goto label_9;
        label_7:
        val_18 = this.丒且且与东丂丐专丕;
        UnityEngine.Vector3 val_6 = this.helper.position;
        val_12 = val_6.y;
        val_20 = val_18;
        val_21 = val_13;
        val_22 = val_2.z;
        val_17 = val_6.x;
        this.丙不专下丟与世业万 = UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22}, rhs:  new UnityEngine.Vector3() {x = val_17, y = val_12, z = val_6.z});
        UnityEngine.Vector3 val_9 = this.helper.position;
        this.丒且且与东丂丐专丕 = val_9;
        mem[1152921526375691568] = val_9.y;
        mem[1152921526375691572] = val_9.z;
        label_9:
        UnityEngine.Quaternion val_11 = this.transform.rotation;
        this.丁丁与丄丞丈丏丌世 = val_11;
        mem[1152921526375691552] = val_11.y;
        mem[1152921526375691556] = val_11.z;
        mem[1152921526375691560] = val_11.w;
    }
    private void 世丝与三丈东七丒一()
    {
        if(this.丆三丟丑世三东丑丐 != this.transform.GetSiblingIndex())
        {
                this.丄丅丄不丞丘丙专上();
            this.丏与上丝一丕一丟万().Create();
        }
        
        this.丆三丟丑世三东丑丐 = this.transform.GetSiblingIndex();
    }
    private void 丄丅丄不丞丘丙专上()
    {
        var val_4 = 0;
        goto label_2;
        label_9:
        RoadPart val_3 = this.丏与上丝一丕一丟万();
        val_3.waipoints.set_Item(index:  0, value:  this.丏与上丝一丕一丟万().GetComponentsInChildren<Waipoint>()[0]);
        mem2[0] = val_4;
        val_2[0x0] + 32.CheckRp();
        val_4 = 1;
        label_2:
        if(val_4 < val_2.Length)
        {
            goto label_9;
        }
    
    }
    public void SetSibling(int 丞丅上丏丂且下丅与)
    {
        this.丆三丟丑世三东丑丐 = 丞丅上丏丂且下丅与;
        this.CheckRp();
    }
    private void OnEnable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.helper)) != false)
        {
                UnityEngine.Vector3 val_2 = this.helper.position;
            this.丒且且与东丂丐专丕 = val_2;
            mem[1152921526376297264] = val_2.y;
            mem[1152921526376297268] = val_2.z;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.丏与上丝一丕一丟万())) == false)
        {
                return;
        }
        
        this.CheckRp();
    }
    private void OnDestroy()
    {
        Waipoint val_9 = this;
        if(this.丏与上丝一丕一丟万() == 0)
        {
                return;
        }
        
        RoadPart val_3 = this.丏与上丝一丕一丟万();
        bool val_4 = val_3.waipoints.Remove(item:  this);
        RoadPart val_5 = this.丏与上丝一丕一丟万();
        List.Enumerator<T> val_6 = val_5.waipoints.GetEnumerator();
        label_11:
        if((294759752 & 1) == 0)
        {
            goto label_8;
        }
        
        0.丐丏七丌丕丗业且上().CheckRp();
        this.丏与上丝一丕一丟万().Create();
        goto label_11;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 东丝七业丄丑丒世七()
    {
        this.丏与上丝一丕一丟万().Create();
    }
    public void CheckRp()
    {
        int val_19;
        System.Collections.Generic.List<Waipoint> val_20;
        var val_21;
        System.Collections.Generic.List<Waipoint> val_22;
        string val_23;
        this.七东丐丟世丕丏丞且 = false;
        RoadPart val_1 = this.丏与上丝一丕一丟万();
        if(val_1.waipoints == null)
        {
            goto label_2;
        }
        
        val_19 = 0;
        goto label_3;
        label_11:
        RoadPart val_2 = this.丏与上丝一丕一丟万();
        if(this == val_2.waipoints.Item[0])
        {
            goto label_8;
        }
        
        val_19 = 1;
        label_3:
        RoadPart val_5 = this.丏与上丝一丕一丟万();
        val_20 = val_5.waipoints;
        if(val_19 < val_20.Count)
        {
            goto label_11;
        }
        
        if(this.七东丐丟世丕丏丞且 == true)
        {
                return;
        }
        
        RoadPart val_7 = this.丏与上丝一丕一丟万();
        val_7.waipoints.Add(item:  this);
        RoadPart val_8 = this.丏与上丝一丕一丟万();
        val_21 = this;
        this.专七丟七一丒丒丂三 = val_8.waipoints.Count;
        goto label_17;
        label_2:
        this.七东丐丟世丕丏丞且 = true;
        RoadPart val_10 = this.丏与上丝一丕一丟万();
        System.Collections.Generic.List<Waipoint> val_11 = null;
        val_22 = val_11;
        val_11 = new System.Collections.Generic.List<Waipoint>();
        val_10.waipoints = val_22;
        RoadPart val_12 = this.丏与上丝一丕一丟万();
        val_12.waipoints.Add(item:  this);
        val_21 = this;
        this.专七丟七一丒丒丂三 = 0;
        label_17:
        this.gameObject.name = "Waipoint_" + this.专七丟七一丒丒丂三.ToString();
        return;
        label_8:
        this.专七丟七一丒丒丂三 = val_19;
        val_23 = "Waipoint_" + this.专七丟七一丒丒丂三.ToString();
        this.gameObject.name = val_23;
        this.七东丐丟世丕丏丞且 = true;
    }
    public Waipoint()
    {
    
    }

}
