using UnityEngine;
public class RoadConnector : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform[] connections;
    public static System.Collections.Generic.List<RoadConnector> connectors;
    public static UnityEngine.Mesh mesh;
    public int currentConnection;
    public int currentRoad;
    public UnityEngine.MeshFilter mf;
    private float 丟丈丌丐丁东丐专万;
    
    // Methods
    private void OnDrawGizmos()
    {
        var val_15;
        UnityEngine.Transform val_16;
        var val_17;
        UnityEngine.Transform[] val_18;
        var val_19;
        var val_24;
        val_15 = null;
        val_15 = null;
        if((UnityEngine.Object.op_Implicit(exists:  RoadConnector.mesh)) != true)
        {
                UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "RoadConnectorMesh");
            if(val_2 != null)
        {
                val_16 = 1152921504834002944;
            var val_3 = (null == null) ? (val_2) : 0;
        }
        
            val_17 = null;
            val_17 = null;
            RoadConnector.mesh = 0.GetComponent<UnityEngine.MeshFilter>().sharedMesh;
        }
        
        float val_15 = this.丟丈丌丐丁东丐专万;
        if(val_15 > 0f)
        {
                val_15 = val_15 + (-0.016f);
            this.丟丈丌丐丁东丐专万 = val_15;
        }
        
        val_18 = this.connections;
        if(val_18 == null)
        {
                return;
        }
        
        val_19 = 0;
        goto label_14;
        label_31:
        if((val_19 == this.currentConnection) && (this.丟丈丌丐丁东丐专万 > 0f))
        {
                UnityEngine.Color val_6 = UnityEngine.Color.yellow;
        }
        else
        {
                UnityEngine.Color val_7 = UnityEngine.Color.white;
        }
        
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
        UnityEngine.Quaternion val_8 = this.connections[0].rotation;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  -90f, y:  180f, z:  0f);
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, rhs:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
        val_24 = null;
        val_24 = null;
        val_16 = this.connections[0];
        UnityEngine.Vector3 val_11 = val_16.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        UnityEngine.Gizmos.DrawMesh(mesh:  RoadConnector.mesh, position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, scale:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.z, z = ???});
        val_18 = this.connections;
        val_19 = 1;
        label_14:
        if(val_19 < this.connections.Length)
        {
            goto label_31;
        }
    
    }
    public static RoadConnector ClosestConnection(UnityEngine.Vector3 下七与丆丅丙丌丕业)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_14 = null;
        val_14 = null;
        if(RoadConnector.connectors == null)
        {
            goto label_3;
        }
        
        val_15 = 0;
        val_16 = 0;
        val_13 = 0;
        goto label_4;
        label_29:
        val_17 = null;
        val_17 = null;
        RoadConnector val_1 = RoadConnector.connectors.Item[0];
        if(val_1.connections == null)
        {
            goto label_9;
        }
        
        val_18 = 0;
        goto label_10;
        label_25:
        val_19 = null;
        val_19 = null;
        RoadConnector val_2 = RoadConnector.connectors.Item[0];
        UnityEngine.Vector3 val_3 = val_2.connections[0].position;
        float val_4 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 下七与丆丅丙丌丕业.x, y = 下七与丆丅丙丌丕业.y, z = 下七与丆丅丙丌丕业.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        var val_5 = (val_4 < 0) ? (val_4) : 2f;
        int val_6 = (val_4 < 0) ? (val_18) : (val_16);
        int val_7 = (val_4 < 0) ? (val_15) : (val_13);
        val_18 = 1;
        label_10:
        val_20 = null;
        val_20 = null;
        RoadConnector val_8 = RoadConnector.connectors.Item[0];
        if(val_18 < val_8.connections.Length)
        {
            goto label_25;
        }
        
        label_9:
        val_14 = null;
        val_15 = 1;
        label_4:
        val_14 = null;
        if(val_15 < RoadConnector.connectors.Count)
        {
            goto label_29;
        }
        
        val_21 = 0;
        if(val_6 == 1)
        {
                return (RoadConnector)val_21;
        }
        
        if(val_7 == 1)
        {
                return (RoadConnector)val_21;
        }
        
        val_22 = null;
        val_22 = null;
        RoadConnector val_10 = RoadConnector.connectors.Item[val_7];
        val_10.currentConnection = val_6;
        RoadConnector val_11 = RoadConnector.connectors.Item[val_7];
        val_11.丟丈丌丐丁东丐专万 = 0.5f;
        RoadConnector val_12 = RoadConnector.connectors.Item[val_7];
        return (RoadConnector)val_21;
        label_3:
        val_21 = 0;
        return (RoadConnector)val_21;
    }
    private void 三丞与一丒丏一丈丗()
    {
        this.丟丈丌丐丁东丐专万 = 0.5f;
    }
    private void OnEnable()
    {
        RoadConnector val_12;
        var val_13;
        var val_14;
        val_12 = this;
        val_13 = null;
        val_13 = null;
        RoadConnector.connectors.Add(item:  this);
        if((UnityEngine.Object.op_Implicit(exists:  this.mf)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3[] val_3 = this.mf.mesh.vertices;
        System.Collections.Generic.List<UnityEngine.Vector2> val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        val_14 = 0;
        goto label_9;
        label_17:
        UnityEngine.Vector3 val_6 = this.mf.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f});
        val_6.x = val_6.x + 800f;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.z + 800f);
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, d:  1600f);
        val_4.Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
        val_14 = 1;
        label_9:
        if(val_14 < val_3.Length)
        {
            goto label_17;
        }
        
        val_12 = this.mf.sharedMesh;
        val_12.uv = val_4.ToArray();
    }
    private void OnDisable()
    {
        null = null;
        bool val_1 = RoadConnector.connectors.Remove(item:  this);
    }
    public void Connect(Waipoint 丛业丌丕与丛下丞丞, bool 不且东三三丐世下丝)
    {
        float val_9;
        float val_10;
        float val_11;
        UnityEngine.Vector3 val_2 = this.connections[this.currentConnection].position;
        丛业丌丕与丛下丞丞.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = this.connections[this.currentConnection].forward;
        val_9 = val_4.x;
        val_10 = val_4.y;
        val_11 = val_4.z;
        if(不且东三三丐世下丝 != true)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11}, d:  -1f);
            val_9 = val_5.x;
            val_10 = val_5.y;
            val_11 = val_5.z;
        }
        
        丛业丌丕与丛下丞丞.transform.forward = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11};
    }
    public RoadConnector()
    {
    
    }
    private static RoadConnector()
    {
        RoadConnector.connectors = new System.Collections.Generic.List<RoadConnector>();
    }

}
