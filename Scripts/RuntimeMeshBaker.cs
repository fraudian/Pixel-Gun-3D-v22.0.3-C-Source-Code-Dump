using UnityEngine;
public class RuntimeMeshBaker : MonoBehaviour
{
    // Fields
    public UnityEngine.MeshRenderer[] renderers;
    private UnityEngine.MeshRenderer 丘丏三专七三丙七一;
    private UnityEngine.MeshFilter 下七丂七丘丙业丝专;
    private System.Collections.Generic.List<UnityEngine.Mesh> 丅万丏三丕丅丘丕上;
    private UnityEngine.Mesh 丁丛下丕下不一三丕;
    private System.Collections.Generic.List<UnityEngine.CombineInstance> 不丑丁且丟东丑丌丟;
    private int 业上与丝丆丝世丂丑;
    private int 丛丒丄七丕专丈丆不;
    
    // Methods
    private void Awake()
    {
        this.丅万丏三丕丅丘丕上 = new System.Collections.Generic.List<UnityEngine.Mesh>();
        this.丘丏三专七三丙七一 = this.gameObject.AddComponent<UnityEngine.MeshRenderer>();
        this.下七丂七丘丙业丝专 = this.gameObject.AddComponent<UnityEngine.MeshFilter>();
        UnityEngine.Mesh val_6 = new UnityEngine.Mesh();
        this.丁丛下丕下不一三丕 = val_6;
        val_6.name = "Baked_Mesh_Data";
        this.不丑丁且丟东丑丌丟 = new System.Collections.Generic.List<UnityEngine.CombineInstance>();
    }
    private void 丝丂七丑不东业东丛()
    {
        var val_11;
        float val_12;
        float val_13;
        var val_14;
        var val_15;
        val_11 = 0;
        goto label_1;
        label_25:
        UnityEngine.Mesh val_2 = this.renderers[0].GetComponent<UnityEngine.MeshFilter>().sharedMesh;
        if(val_2.subMeshCount != 1)
        {
            goto label_7;
        }
        
        UnityEngine.Vector4 val_4 = this.renderers[0].lightmapScaleOffset;
        val_12 = val_4.x;
        val_13 = val_4.z;
        this.丌万三东上三丄丞三(三丌东下丄丙丙丙丌:  val_2, 丁丝万且业丒三业丗:  new UnityEngine.Vector4() {x = val_12, y = val_4.y, z = val_13, w = val_4.w}, 丄丑不丈丞万丛丘丅:  this.renderers[0].transform);
        goto label_14;
        label_7:
        val_14 = 0;
        goto label_15;
        label_23:
        UnityEngine.Vector4 val_7 = this.renderers[0].lightmapScaleOffset;
        val_12 = val_7.x;
        val_13 = val_7.z;
        this.丌万三东上三丄丞三(三丌东下丄丙丙丙丌:  RuntimeMeshBaker.专丗丞丒丂不不且丂(丄七丞丂丅丂与一丞:  val_2, 不一丕丆丅上丙丞万:  0), 丁丝万且业丒三业丗:  new UnityEngine.Vector4() {x = val_12, y = val_7.y, z = val_13, w = val_7.w}, 丄丑不丈丞万丛丘丅:  this.renderers[0].transform);
        val_14 = 1;
        label_15:
        if(val_14 < val_2.subMeshCount)
        {
            goto label_23;
        }
        
        label_14:
        val_11 = 1;
        label_1:
        if(val_11 < this.renderers.Length)
        {
            goto label_25;
        }
        
        this.一丆丑业丑丗丗业丑();
        val_15 = 0;
        goto label_26;
        label_32:
        this.renderers[0].gameObject.SetActive(value:  false);
        val_15 = 1;
        label_26:
        if(val_15 < this.renderers.Length)
        {
            goto label_32;
        }
    
    }
    private void 丌万三东上三丄丞三(UnityEngine.Mesh 三丌东下丄丙丙丙丌, UnityEngine.Vector4 丁丝万且业丒三业丗, UnityEngine.Transform 丄丑不丈丞万丛丘丅)
    {
        var val_30;
        System.Int32[] val_31;
        UnityEngine.MeshTopology val_32;
        var val_33;
        UnityEngine.Color val_34;
        var val_36;
        this.丅万丏三丕丅丘丕上.Add(item:  new UnityEngine.Mesh());
        UnityEngine.Mesh val_2 = this.丅万丏三丕丅丘丕上.Item[this.业上与丝丆丝世丂丑];
        val_2.vertices = 三丌东下丄丙丙丙丌.vertices;
        int val_4 = 三丌东下丄丙丙丙丌.vertexCount;
        val_2.colors = new UnityEngine.Color[0];
        val_30 = 0;
        goto label_7;
        label_14:
        if(三丌东下丄丙丙丙丌 != null)
        {
                val_31 = 三丌东下丄丙丙丙丌.GetIndices(submesh:  0);
        }
        else
        {
                val_31 = 0.GetIndices(submesh:  0);
        }
        
        val_32 = 三丌东下丄丙丙丙丌.GetTopology(submesh:  0);
        val_2.SetIndices(indices:  val_31, topology:  val_32, submesh:  0);
        val_2.SetTriangles(triangles:  三丌东下丄丙丙丙丌.GetTriangles(submesh:  0), submesh:  0);
        val_30 = 1;
        label_7:
        if(val_30 < val_2.subMeshCount)
        {
            goto label_14;
        }
        
        if(val_2 != null)
        {
                val_2.normals = 0;
        }
        else
        {
                val_2.normals = 0;
        }
        
        val_2.tangents = 0;
        val_2.uv = 三丌东下丄丙丙丙丌.uv;
        val_2.uv2 = 三丌东下丄丙丙丙丌.uv2;
        val_33 = 0;
        goto label_21;
        label_27:
        float val_30 = (float)this.丛丒丄七丕专丈丆不;
        val_30 = val_30 * 0.015625f;
        val_32 = 0;
        val_34 = 0;
        val_33 = 1;
        val_2.colors[0] = 0;
        val_2.colors[0] = val_32;
        val_2.colors[0] = 0;
        val_2.colors[0] = val_34;
        label_21:
        UnityEngine.Color[] val_14 = val_2.colors;
        if(val_33 < val_14.Length)
        {
            goto label_27;
        }
        
        if((System.String.op_Equality(a:  丄丑不丈丞万丛丘丅.gameObject.name, b:  "What")) != false)
        {
                UnityEngine.Debug.Log(message:  丁丝万且业丒三业丗);
        }
        
        UnityEngine.Vector2[] val_18 = val_2.uv2;
        UnityEngine.Vector2[] val_19 = new UnityEngine.Vector2[0];
        val_36 = 0;
        goto label_35;
        label_46:
        val_32 = 0;
        UnityEngine.Vector2 val_32 = val_2.uv2[val_32];
        float val_22 = 丁丝万且业丒三业丗.x * val_19.uv2[val_32];
        val_22 = 丁丝万且业丒三业丗.z + val_22;
        val_32 = 丁丝万且业丒三业丗.y * val_32;
        val_32 = 丁丝万且业丒三业丗.w + val_32;
        UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_22, y:  val_32);
        val_34 = val_23.x;
        val_36 = 1;
        val_19[val_32] = val_34;
        val_19[val_32] = val_23.y;
        label_35:
        UnityEngine.Vector2[] val_24 = val_2.uv2;
        if(val_36 < val_24.Length)
        {
            goto label_46;
        }
        
        val_2.uv2 = val_19;
        UnityEngine.Matrix4x4 val_25 = 丄丑不丈丞万丛丘丅.localToWorldMatrix;
        this.不丑丁且丟东丑丌丟.Add(item:  new UnityEngine.CombineInstance() {m_MeshInstanceID = val_23.x, m_SubMeshIndex = val_23.y, m_Transform = new UnityEngine.Matrix4x4() {m00 = 丁丝万且业丒三业丗.z, m10 = 丁丝万且业丒三业丗.w}, m_LightmapScaleOffset = new UnityEngine.Vector4(), m_RealtimeLightmapScaleOffset = new UnityEngine.Vector4()});
        int val_33 = this.业上与丝丆丝世丂丑;
        int val_34 = this.丛丒丄七丕专丈丆不;
        val_33 = val_33 + 1;
        val_34 = val_34 + 1;
        this.业上与丝丆丝世丂丑 = val_33;
        this.丛丒丄七丕专丈丆不 = val_34;
    }
    internal static UnityEngine.Mesh 专丗丞丒丂不不且丂(UnityEngine.Mesh 丄七丞丂丅丂与一丞, int 不一丕丆丅上丙丞万)
    {
        float val_21;
        float val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<T> val_25;
        var val_26;
        UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
        val_2.AddRange(collection:  丄七丞丂丅丂与一丞.GetTriangles(submesh:  不一丕丆丅上丙丞万));
        System.Collections.Generic.List<UnityEngine.Vector3> val_4 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.List<UnityEngine.Vector2> val_5 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Collections.Generic.List<UnityEngine.Vector2> val_6 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_7 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        val_23 = 1152921525750875424;
        val_24 = 0;
        goto label_3;
        label_21:
        if((val_2.Contains(item:  0)) != false)
        {
                var val_23 = 12;
            val_23 = 丄七丞丂丅丂与一丞.vertices + (0 * val_23);
            val_4.Add(item:  new UnityEngine.Vector3() {x = (0 * 12) + val_9 + 32, y = (0 * 12) + val_9 + 32 + 4, z = (0 * 12) + val_9 + 40});
            val_25 = val_5;
            if(val_25 == 0)
        {
                val_25 = val_5;
        }
        
            val_5.Add(item:  new UnityEngine.Vector2() {x = 丄七丞丂丅丂与一丞.uv[0], y = 丄七丞丂丅丂与一丞.uv[0]});
            val_6.Add(item:  new UnityEngine.Vector2() {x = 丄七丞丂丅丂与一丞.uv2[0], y = 丄七丞丂丅丂与一丞.uv2[0]});
            val_7.Add(key:  0, value:  0);
        }
        
        val_24 = 1;
        label_3:
        UnityEngine.Vector3[] val_12 = 丄七丞丂丅丂与一丞.vertices;
        if(val_24 < val_12.Length)
        {
            goto label_21;
        }
        
        int val_13 = val_2.Count;
        int[] val_14 = new int[0];
        val_26 = 0;
        goto label_22;
        label_27:
        val_23 = 0;
        val_26 = 1;
        val_14[0] = val_7.Item[val_2.Item[0]];
        label_22:
        if(val_26 < val_14.Length)
        {
            goto label_27;
        }
        
        val_1.vertices = val_4.ToArray();
        val_1.uv = val_5.ToArray();
        T[] val_19 = val_6.ToArray();
        if(val_1 != 0)
        {
                val_1.uv2 = val_19;
        }
        else
        {
                val_1.uv2 = val_19;
        }
        
        val_1.triangles = val_14;
        UnityEngine.Bounds val_20 = 丄七丞丂丅丂与一丞.bounds;
        val_1.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_22, y = val_22, z = val_22}, m_Extents = new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_21}};
        return val_1;
    }
    private void 一丆丑业丑丗丗业丑()
    {
        this.丁丛下丕下不一三丕.CombineMeshes(combine:  this.不丑丁且丟东丑丌丟.ToArray(), mergeSubMeshes:  true, useMatrices:  true);
        this.下七丂七丘丙业丝专.sharedMesh = this.丁丛下丕下不一三丕;
        this.丘丏三专七三丙七一.lightmapIndex = 0;
        this.丘丏三专七三丙七一.lightmapScaleOffset = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        this.丘丏三专七三丙七一.sharedMaterial = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Mobile/Diffuse"));
    }
    private void Start()
    {
        this.丝丂七丑不东业东丛();
    }
    public RuntimeMeshBaker()
    {
    
    }

}
