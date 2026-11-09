using UnityEngine;
public class RoadPart : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<RoadMeshPoint> roadPoints;
    public UnityEngine.Color roadColor;
    public System.Collections.Generic.List<Waipoint> waipoints;
    public UnityEngine.LayerMask mask;
    public float width;
    public UnityEngine.Material mat;
    public UnityEngine.Material h_mat;
    private System.Collections.Generic.List<int> 且东丟丐丈丅丆专三;
    private System.Collections.Generic.List<int> 与丁万与上世世世与;
    private System.Collections.Generic.List<UnityEngine.Vector3> 丐业丕东丈丑丐丝丞;
    private System.Collections.Generic.List<UnityEngine.Vector3> 七丛丛丁业七丝丌丄;
    private System.Collections.Generic.List<UnityEngine.Vector2> 丌丌丁专与东丌丗且;
    private UnityEngine.Mesh 丄丂丞丅丞丂丗且且;
    private UnityEngine.MeshFilter 一丂上丟丆上业丕上;
    private UnityEngine.MeshRenderer 七丄丘丙丝丂丘丞丘;
    private UnityEngine.MeshCollider 专丘丈丗丒丅丑丏丘;
    
    // Properties
    private UnityEngine.MeshCollider 丆与专专丕丝丝丛丗 { get; }
    private UnityEngine.MeshFilter 下七三丝下丑丄万下 { get; }
    private UnityEngine.MeshRenderer 丄不三丌丆与丈丕丏 { get; }
    
    // Methods
    private UnityEngine.MeshCollider 丒丙丟世丏丞下丛丈()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.专丘丈丗丒丅丑丏丘)) == true)
        {
                return (UnityEngine.MeshCollider)this.专丘丈丗丒丅丑丏丘;
        }
        
        UnityEngine.MeshCollider val_2 = this.GetComponent<UnityEngine.MeshCollider>();
        this.专丘丈丗丒丅丑丏丘 = val_2;
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == true)
        {
                return (UnityEngine.MeshCollider)this.专丘丈丗丒丅丑丏丘;
        }
        
        this.专丘丈丗丒丅丑丏丘 = this.gameObject.AddComponent<UnityEngine.MeshCollider>();
        return (UnityEngine.MeshCollider)this.专丘丈丗丒丅丑丏丘;
    }
    private UnityEngine.MeshFilter 丄丈东丝丏丌丁七丝()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.一丂上丟丆上业丕上)) == true)
        {
                return (UnityEngine.MeshFilter)this.一丂上丟丆上业丕上;
        }
        
        UnityEngine.MeshFilter val_2 = this.GetComponent<UnityEngine.MeshFilter>();
        this.一丂上丟丆上业丕上 = val_2;
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == true)
        {
                return (UnityEngine.MeshFilter)this.一丂上丟丆上业丕上;
        }
        
        this.一丂上丟丆上业丕上 = this.gameObject.AddComponent<UnityEngine.MeshFilter>();
        return (UnityEngine.MeshFilter)this.一丂上丟丆上业丕上;
    }
    private UnityEngine.MeshRenderer 丐下丄丑与丝丄丒万()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.七丄丘丙丝丂丘丞丘)) == true)
        {
                return (UnityEngine.MeshRenderer)this.七丄丘丙丝丂丘丞丘;
        }
        
        UnityEngine.MeshRenderer val_2 = this.GetComponent<UnityEngine.MeshRenderer>();
        this.七丄丘丙丝丂丘丞丘 = val_2;
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == true)
        {
                return (UnityEngine.MeshRenderer)this.七丄丘丙丝丂丘丞丘;
        }
        
        this.七丄丘丙丝丂丘丞丘 = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
        return (UnityEngine.MeshRenderer)this.七丄丘丙丝丂丘丞丘;
    }
    public void Create()
    {
        this.CreatePoints();
        this.丁丝七且丆丄万且七();
        this.丗丞丑丗丈丄丒世丐();
        this.专丗丞丒丂不不且丂();
        this.东七丄东丆三丐丗丗();
        this.丝东丄丅丕丒业丐七();
    }
    public void CreatePoints()
    {
        var val_9;
        Waipoint val_10;
        this.丝东丄丅丕丒业丐七();
        val_9 = 0;
        goto label_1;
        label_9:
        if(2 < (this.waipoints.Count - 1))
        {
                val_10 = this.waipoints.Item[2];
        }
        else
        {
                val_10 = 0;
        }
        
        this.丆丙上专三且丈丒丄(丄且一丄丏丆丐丗与:  this.waipoints.Item[0], 丈丝世且万世丈丌万:  this.waipoints.Item[1], 且三丂上丞与丌三一:  (val_9 == 0) ? 1 : 0, 丗丕下东丅丏丕上丏:  val_10, 不丕丝下丐丐丄丟丙:  8);
        val_9 = 1;
        label_1:
        if(val_9 < (this.waipoints.Count - 1))
        {
            goto label_9;
        }
    
    }
    private void 丐丁丐丂业丙业与丂()
    {
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "Waipont_" + this.waipoints.Count.ToString());
        Waipoint val_5 = val_4.AddComponent<Waipoint>();
        val_5.transform.parent = this.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.GameObject val_10 = new UnityEngine.GameObject(name:  "Helper");
        if(val_10 != null)
        {
                Gizmo val_11 = val_10.AddComponent<Gizmo>();
        }
        else
        {
                Gizmo val_12 = val_10.AddComponent<Gizmo>();
        }
        
        val_10.transform.parent = val_4.transform;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.forward;
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        val_5.helper = val_10.transform;
        this.waipoints.Add(item:  val_5);
    }
    private void 丁丂万丐丌不且丒专(UnityEngine.Vector3 下业丕七东丌丝下且, bool 一七三东业三万万七 = False)
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_13;
        float val_14;
        val_13 = this;
        UnityEngine.Vector3 val_2 = this.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
        val_14 = val_2.x;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  100f);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, direction:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  200f, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.mask}))) != false)
        {
            
        }
        else
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
        }
        
        this.七丛丛丁业七丝丌丄.Add(item:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if(一七三东业三万万七 == false)
        {
                return;
        }
        
        float val_13 = 800f;
        val_13 = this.丌丌丁专与东丌丗且;
        val_13 = val_2.z + val_13;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_14 + val_13, y:  val_13);
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, d:  1600f);
        val_14 = val_12.x;
        val_13.Add(item:  new UnityEngine.Vector2() {x = val_14, y = val_12.y});
    }
    private void 丁丝七且丆丄万且七()
    {
        var val_15;
        float val_16;
        System.Collections.Generic.List<System.Int32> val_17;
        float val_18;
        float val_19;
        var val_20;
        System.Collections.Generic.List<UnityEngine.Vector2> val_21;
        float val_22;
        this.七丛丛丁业七丝丌丄 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.丐业丕东丈丑丐丝丞 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.且东丟丐丈丅丆专三 = new System.Collections.Generic.List<System.Int32>();
        this.丌丌丁专与东丌丗且 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        val_15 = 0;
        val_16 = 0f;
        goto label_1;
        label_35:
        this.roadPoints.Item[0].GetPoints();
        val_17 = 0;
        goto label_4;
        label_12:
        val_18 = 8.96831E-44f;
        val_19 = 4.656534E-34f;
        this.丐业丕东丈丑丐丝丞.Add(item:  new UnityEngine.Vector3() {x = val_18, y = 0f, z = val_19});
        var val_6 = val_5.vertices + (0 * 12);
        this.丁丂万丐丌不且丒专(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = (0 * 12) + val_5.vertices + 32, y = (0 * 12) + val_5.vertices + 32 + 4, z = (0 * 12) + val_5.vertices + 40}, 一七三东业三万万七:  false);
        val_17 = 1;
        label_4:
        if(val_17 < val_5.vertices.Length)
        {
            goto label_12;
        }
        
        if(val_15 != 0)
        {
                val_18 = val_5.vertices[0];
            val_19 = val_5.vertices[0];
            RoadMeshPoint val_7 = this.roadPoints.Item[-1];
            val_20 = 1152921516216384640;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18, y = val_5.vertices[0], z = val_19}, b:  new UnityEngine.Vector3() {x = val_7.vertices[0], y = val_7.vertices[0], z = val_7.vertices[0]});
            val_16 = val_16 + (UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}));
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0f, y:  val_16);
            this.丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            val_21 = this.丌丌丁专与东丌丗且;
            val_22 = val_16;
        }
        else
        {
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0f, y:  0f);
            val_20 = 1152921516216384640;
            this.丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_21 = this.丌丌丁专与东丌丗且;
            UnityEngine.Vector2 val_12;
            val_22 = 0f;
        }
        
        val_12 = new UnityEngine.Vector2(x:  1f, y:  val_22);
        val_21.Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
        if(val_15 < (this.roadPoints.Count - 1))
        {
                this.且东丟丐丈丅丆专三.Add(item:  0);
            this.且东丟丐丈丅丆专三.Add(item:  0 | 1);
            int val_16 = 0 + 3;
            this.且东丟丐丈丅丆专三.Add(item:  val_16);
            this.且东丟丐丈丅丆专三.Add(item:  0);
            val_17 = this.且东丟丐丈丅丆专三;
            val_17.Add(item:  val_16);
            this.且东丟丐丈丅丆专三.Add(item:  0 + 2);
        }
        
        val_15 = 1;
        label_1:
        if(val_15 < this.roadPoints.Count)
        {
            goto label_35;
        }
    
    }
    private void 丗丞丑丗丈丄丒世丐()
    {
        System.Collections.Generic.List<System.Int32> val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        int val_24;
        System.Collections.Generic.List<System.Int32> val_1 = null;
        val_19 = val_1;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        this.与丁万与上世世世与 = val_19;
        int val_2 = this.丐业丕东丈丑丐丝丞.Count;
        val_20 = 1152921526365632176;
        val_21 = 0;
        val_22 = 12;
        goto label_2;
        label_24:
        this.roadPoints.Item[0].GetPoints();
        val_23 = 0;
        goto label_5;
        label_12:
        this.丐业丕东丈丑丐丝丞.Add(item:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f});
        this.丁丂万丐丌不且丒专(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f}, 一七三东业三万万七:  true);
        val_24 = this.transform;
        UnityEngine.Vector3 val_7 = val_24.TransformPoint(position:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f});
        val_23 = 1;
        label_5:
        val_19 = val_5.hillVertices;
        if(val_23 < val_5.hillVertices.Length)
        {
            goto label_12;
        }
        
        if(val_21 >= (this.roadPoints.Count - 1))
        {
            goto label_14;
        }
        
        val_19 = 1 + val_2;
        do
        {
            label_22:
        }
        while(0 == 2);
        
        int val_13 = (val_2 + 0) + 0;
        this.与丁万与上世世世与.Add(item:  val_13);
        this.与丁万与上世世世与.Add(item:  val_19 + 0);
        val_24 = ((val_2 + 7) + 0) + 0;
        this.与丁万与上世世世与.Add(item:  val_24);
        this.与丁万与上世世世与.Add(item:  val_13);
        this.与丁万与上世世世与.Add(item:  val_24);
        this.与丁万与上世世世与.Add(item:  ((val_2 + 6) + 0) + 0);
        if((0 + 1) != 5)
        {
            goto label_22;
        }
        
        label_14:
        val_20 = 1152921526365632176;
        val_21 = val_21 + 1;
        val_22 = 12;
        label_2:
        if(val_21 < this.roadPoints.Count)
        {
            goto label_24;
        }
    
    }
    private void 专丗丞丒丂不不且丂()
    {
        UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
        this.丄丂丞丅丞丂丗且且 = val_1;
        val_1.name = "ROAD";
        this.丄丂丞丅丞丂丗且且.subMeshCount = 2;
        this.丄丂丞丅丞丂丗且且.vertices = this.丐业丕东丈丑丐丝丞.ToArray();
        this.丄丂丞丅丞丂丗且且.SetTriangles(triangles:  this.且东丟丐丈丅丆专三.ToArray(), submesh:  0);
        this.丄丂丞丅丞丂丗且且.SetTriangles(triangles:  this.与丁万与上世世世与.ToArray(), submesh:  1);
        this.丄丂丞丅丞丂丗且且.uv = this.丌丌丁专与东丌丗且.ToArray();
        this.丄丂丞丅丞丂丗且且.normals = this.七丛丛丁业七丝丌丄.ToArray();
        this.丄丂丞丅丞丂丗且且.RecalculateBounds();
    }
    private void 东七丄东丆三丐丗丗()
    {
        UnityEngine.Material[] val_1 = new UnityEngine.Material[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.mat != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.mat == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.mat;
        val_1[1] = this.h_mat;
        this.丐下丄丑与丝丄丒万().sharedMaterials = val_1;
        this.丄丈东丝丏丌丁七丝().sharedMesh = this.丄丂丞丅丞丂丗且且;
        this.丒丙丟世丏丞下丛丈().sharedMesh = this.丄丂丞丅丞丂丗且且;
    }
    private void OnDrawGizmos()
    {
        int val_29;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = this.roadColor};
        if(this.waipoints == null)
        {
                return;
        }
        
        if(this.waipoints.Count == 0)
        {
                return;
        }
        
        val_29 = 0;
        goto label_3;
        label_25:
        UnityEngine.Vector3 val_4 = this.waipoints.Item[0].transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  5f);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        Waipoint val_8 = this.waipoints.Item[0];
        UnityEngine.Vector3 val_9 = val_8.helper.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  5f);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        int val_29 = 1;
        UnityEngine.Vector3 val_15 = this.waipoints.Item[1].transform.position;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  5f);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        this.世丐丆上三下丌七丌(丄且一丄丏丆丐丗与:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丞丂丏丐丞且三丝不:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 丈丝世且万世丈丌万:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.z, z = ???}, 不丕丝下丐丐丄丟丙:  8);
        val_29 = val_29 - 1;
        UnityEngine.Vector3 val_21 = this.waipoints.Item[val_29].transform.position;
        Waipoint val_22 = this.waipoints.Item[val_29];
        UnityEngine.Vector3 val_23 = val_22.helper.position;
        val_29 = val_29 + 1;
        UnityEngine.Vector3 val_26 = this.waipoints.Item[val_29].transform.position;
        this.世丐丆上三下丌七丌(丄且一丄丏丆丐丗与:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, 丞丂丏丐丞且三丝不:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, 丈丝世且万世丈丌万:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.z, z = ???}, 不丕丝下丐丐丄丟丙:  8);
        label_3:
        if(val_29 < (this.waipoints.Count - 1))
        {
            goto label_25;
        }
    
    }
    private void 世丐丆上三下丌七丌(UnityEngine.Vector3 丄且一丄丏丆丐丗与, UnityEngine.Vector3 丞丂丏丐丞且三丝不, UnityEngine.Vector3 丈丝世且万世丈丌万, int 不丕丝下丐丐丄丟丙 = 8)
    {
        if(不丕丝下丐丐丄丟丙 < 1)
        {
                return;
        }
        
        var val_6 = 0;
        float val_4 = 1f;
        val_4 = val_4 / (float)不丕丝下丐丐丄丟丙;
        do
        {
            float val_5 = 0f;
            val_5 = val_4 * val_5;
            UnityEngine.Vector3 val_2 = this.丈丒上三丄一丅丕且(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = 丄且一丄丏丆丐丗与.x, y = 丄且一丄丏丆丐丗与.y, z = 丄且一丄丏丆丐丗与.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = 丞丂丏丐丞且三丝不.x, y = 丞丂丏丐丞且三丝不.y, z = 丞丂丏丐丞且三丝不.z}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = 丈丝世且万世丈丌万.x, y = 丈丝世且万世丈丌万.y, z = val_5}, 丙丒七丄上与丏丙丙:  null);
            val_6 = val_6 + 1;
            float val_7 = (float)val_6;
            val_7 = val_4 * val_7;
            UnityEngine.Vector3 val_3 = this.丈丒上三丄一丅丕且(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = 丄且一丄丏丆丐丗与.x, y = 丄且一丄丏丆丐丗与.y, z = 丄且一丄丏丆丐丗与.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = 丞丂丏丐丞且三丝不.x, y = 丞丂丏丐丞且三丝不.y, z = 丞丂丏丐丞且三丝不.z}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = 丈丝世且万世丈丌万.x, y = 丈丝世且万世丈丌万.y, z = val_7}, 丙丒七丄上与丏丙丙:  null);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, to:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        while(不丕丝下丐丐丄丟丙 != val_6);
    
    }
    private void 丆丙上专三且丈丒丄(Waipoint 丄且一丄丏丆丐丗与, Waipoint 丈丝世且万世丈丌万, bool 且三丂上丞与丌三一, Waipoint 丗丕下东丅丏丕上丏, int 不丕丝下丐丐丄丟丙 = 8)
    {
        var val_30;
        UnityEngine.Transform val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        val_31 = 丈丝世且万世丈丌万;
        val_32 = 1f;
        if(且三丂上丞与丌三一 != false)
        {
                UnityEngine.Vector3 val_2 = 丄且一丄丏丆丐丗与.transform.position;
            UnityEngine.Vector3 val_4 = 丄且一丄丏丆丐丗与.transform.forward;
            val_33 = val_2.y;
            val_34 = val_2.z;
            this.下丐丟丅上丟与丆不(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_2.x, y = val_33, z = val_34}, 丘上丒且下丐三丌三:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        
        val_35 = val_32 / (float)不丕丝下丐丐丄丟丙;
        if(不丕丝下丐丐丄丟丙 >= 2)
        {
                do
        {
            UnityEngine.Vector3 val_6 = 丄且一丄丏丆丐丗与.transform.position;
            float val_29 = 1f;
            UnityEngine.Vector3 val_7 = 丄且一丄丏丆丐丗与.helper.position;
            val_29 = val_35 * val_29;
            UnityEngine.Transform val_8 = val_31.transform;
            UnityEngine.Vector3 val_9 = val_8.position;
            UnityEngine.Vector3 val_10 = val_8.丈丒上三丄一丅丕且(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.z, z = val_29}, 丙丒七丄上与丏丙丙:  null);
            UnityEngine.Vector3 val_12 = 丄且一丄丏丆丐丗与.transform.position;
            UnityEngine.Vector3 val_13 = 丄且一丄丏丆丐丗与.helper.position;
            val_36 = val_13.x;
            val_29 = val_35 + val_29;
            UnityEngine.Transform val_14 = val_31.transform;
            UnityEngine.Vector3 val_15 = val_14.position;
            UnityEngine.Vector3 val_16 = val_14.丈丒上三丄一丅丕且(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = val_36, y = val_13.y, z = val_13.z}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.z, z = val_29}, 丙丒七丄上与丏丙丙:  null);
            val_32 = val_16.z;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_32}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_35 = val_10.x;
            val_33 = val_10.y;
            val_34 = val_10.z;
            this.下丐丟丅上丟与丆不(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_35, y = val_33, z = val_34}, 丘上丒且下丐三丌三:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_30 = 1 + 1;
        }
        while(不丕丝下丐丐丄丟丙 != val_30);
        
        }
        
        bool val_18 = UnityEngine.Object.op_Equality(x:  丗丕下东丅丏丕上丏, y:  0);
        UnityEngine.Vector3 val_20 = val_31.transform.position;
        UnityEngine.Transform val_21 = val_31.transform;
        if(val_21 == null)
        {
            goto label_25;
        }
        
        if(val_18 == false)
        {
            goto label_26;
        }
        
        label_28:
        UnityEngine.Vector3 val_22 = val_21.forward;
        goto label_27;
        label_25:
        if(val_18 == true)
        {
            goto label_28;
        }
        
        label_26:
        UnityEngine.Vector3 val_23 = val_21.position;
        val_31 = 丈丝世且万世丈丌万.helper;
        UnityEngine.Vector3 val_24 = val_31.position;
        val_36 = val_24.x;
        UnityEngine.Transform val_25 = 丗丕下东丅丏丕上丏.transform;
        UnityEngine.Vector3 val_26 = val_25.position;
        UnityEngine.Vector3 val_27 = val_25.丈丒上三丄一丅丕且(丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = val_36, y = val_24.y, z = val_24.z}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.z, z = val_35}, 丙丒七丄上与丏丙丙:  null);
        val_32 = val_27.y;
        val_35 = val_27.x;
        val_33 = val_32;
        val_34 = val_27.z;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35, y = val_33, z = val_34}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        label_27:
        this.下丐丟丅上丟与丆不(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, 丘上丒且下丐三丌三:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
    }
    private void 下丐丟丅上丟与丆不(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 丘上丒且下丐三丌三)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        if(val_1 != null)
        {
                val_1.hideFlags = 61;
        }
        else
        {
                0.hideFlags = 61;
        }
        
        val_1.transform.parent = this.transform;
        val_1.transform.position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        val_1.transform.forward = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        val_6.width = this.width;
        this.roadPoints.Add(item:  val_1.AddComponent<RoadMeshPoint>());
    }
    private void 丝东丄丅丕丒业丐七()
    {
        System.Collections.Generic.List<RoadMeshPoint> val_6;
        var val_7;
        val_6 = this.roadPoints;
        if(val_6 == null)
        {
                return;
        }
        
        val_7 = 0;
        goto label_2;
        label_12:
        if((UnityEngine.Object.op_Implicit(exists:  val_6.Item[0])) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.roadPoints.Item[0].gameObject);
        }
        
        val_6 = this.roadPoints;
        val_7 = 1;
        label_2:
        if(val_7 < val_6.Count)
        {
            goto label_12;
        }
        
        this.roadPoints.Clear();
    }
    private UnityEngine.Vector3 丈丒上三丄一丅丕且(UnityEngine.Vector3 丆丛丑世下一丐且丕, UnityEngine.Vector3 丌丗丏丏丛东专丁且, UnityEngine.Vector3 丁丂专业丁丅丅丈丙, float 丙丒七丄上与丏丙丙)
    {
        float val_1;
        float val_2 = 1f - 丁丂专业丁丅丅丈丙.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丆丛丑世下一丐且丕.x, y = 丆丛丑世下一丐且丕.y, z = 丆丛丑世下一丐且丕.z}, d:  val_2 * val_2);
        float val_5 = 丁丂专业丁丅丅丈丙.z + 丁丂专业丁丅丅丈丙.z;
        val_5 = val_5 * val_2;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  val_5, a:  new UnityEngine.Vector3() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y, z = 丌丗丏丏丛东专丁且.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  丁丂专业丁丅丅丈丙.z * 丁丂专业丁丅丅丈丙.z, a:  new UnityEngine.Vector3() {x = 丁丂专业丁丅丅丈丙.x, y = val_1, z = 丁丂专业丁丅丅丈丙.y});
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
    }
    public RoadPart()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.roadColor = val_1;
        mem[1152921526368283652] = val_1.g;
        mem[1152921526368283656] = val_1.b;
        mem[1152921526368283660] = val_1.a;
        this.width = 12f;
    }

}
