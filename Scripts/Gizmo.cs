using UnityEngine;
public class Gizmo : MonoBehaviour
{
    // Fields
    public static UnityEngine.Mesh mesh;
    public static UnityEngine.Quaternion rot;
    public static bool init;
    
    // Methods
    private void OnDrawGizmos()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_14 = null;
        val_14 = null;
        if(Gizmo.init != true)
        {
                UnityEngine.Quaternion val_2 = this.transform.rotation;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  -90f, y:  0f, z:  0f);
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, rhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            val_15 = null;
            val_15 = null;
            Gizmo.rot = val_4.x;
            Gizmo.mesh.__il2cppRuntimeField_C = val_4.y;
            Gizmo.mesh.__il2cppRuntimeField_10 = val_4.z;
            Gizmo.mesh.__il2cppRuntimeField_14 = val_4.w;
            Gizmo.init = true;
            if((UnityEngine.Object.op_Implicit(exists:  Gizmo.mesh)) != true)
        {
                UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  "RoadWaipointHelperMesh");
            if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        
            val_16 = null;
            val_16 = null;
            Gizmo.mesh = 0.GetComponent<UnityEngine.MeshFilter>().sharedMesh;
        }
        
        }
        
        UnityEngine.Color val_10 = UnityEngine.Color.blue;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
        val_17 = null;
        val_17 = null;
        UnityEngine.Vector3 val_12 = this.transform.position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        UnityEngine.Gizmos.DrawMesh(mesh:  Gizmo.mesh, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, rotation:  new UnityEngine.Quaternion() {x = Gizmo.rot, y = Gizmo.mesh.__il2cppRuntimeField_C, z = Gizmo.mesh.__il2cppRuntimeField_10, w = Gizmo.mesh.__il2cppRuntimeField_14}, scale:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.z, z = ???});
    }
    public Gizmo()
    {
    
    }
    private static Gizmo()
    {
    
    }

}
