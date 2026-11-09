using UnityEngine;
public class MergeMeshes : MonoBehaviour
{
    // Fields
    public UnityEngine.Material material;
    public MergeMeshes.不丌丛东丕丕丟丅丁 afterMerging;
    private string 丌世不丅专万丏丄丁;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UnityEngine.Mesh 七丈丛东丗丄丟万丅;
    private UnityEngine.MeshFilter 专丈丐上丈丅丌专丙;
    private UnityEngine.MeshRenderer 丂丟业丗上一万丘丒;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丟不丄丂一丆且丆丟;
    private System.Collections.Generic.List<UnityEngine.Renderer> 丛丛丁丛丙丐东且不;
    private bool 业丁丏一专丅专丄丁;
    
    // Methods
    private void Start()
    {
        if(this.业丁丏一专丅专丄丁 != false)
        {
                this.Merge(丌丄丗七丝丘与丆与:  true);
        }
        
        this.enabled = false;
    }
    private void Update()
    {
        if(this.业丁丏一专丅专丄丁 != false)
        {
                this.Merge(丌丄丗七丝丘与丆与:  true);
        }
        
        this.enabled = false;
    }
    public void Merge(bool 丌丄丗七丝丘与丆与)
    {
        object val_11;
        UnityEngine.MeshFilter val_79;
        var val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        var val_86;
        T[] val_87;
        UnityEngine.Vector3[] val_88;
        UnityEngine.Vector2[] val_89;
        var val_90;
        MergeMeshes val_91;
        T[] val_92;
        System.Int32[] val_93;
        UnityEngine.Vector4[] val_94;
        UnityEngine.Vector2[] val_95;
        var val_96;
        UnityEngine.GameObject val_97;
        var val_99;
        var val_100;
        var val_101;
        var val_102;
        var val_104;
        float val_105;
        var val_106;
        var val_107;
        var val_108;
        UnityEngine.Renderer val_109;
        UnityEngine.MeshRenderer val_110;
        val_79 = 丌丄丗七丝丘与丆与;
        if(val_79 == false)
        {
            goto label_1;
        }
        
        this.业丁丏一专丅专丄丁 = false;
        this.丌世不丅专万丏丄丁 = this.name;
        this.专丈丐上丈丅丌专丙 = this.GetComponent<UnityEngine.MeshFilter>();
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.Clear();
        T[] val_4 = this.GetComponentsInChildren<UnityEngine.MeshFilter>();
        if(val_4.Length == 0)
        {
                return;
        }
        
        val_79 = this.专丈丐上丈丅丌专丙;
        if(val_79 != 0)
        {
                if(val_4.Length == 1)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Transform val_7 = val_6.transform;
        UnityEngine.Matrix4x4 val_8 = val_7.worldToLocalMatrix;
        if(val_4.Length < 1)
        {
            goto label_53;
        }
        
        val_81 = 0;
        val_82 = 0;
        val_83 = 0;
        val_84 = 0;
        val_85 = 0;
        goto label_52;
        label_48:
        if((val_7 & 1) != 0)
        {
            goto label_12;
        }
        
        label_49:
        UnityEngine.Mesh val_13 = val_4.sharedMesh;
        if(mem[1152921540481208136] == 0)
        {
                mem[1152921540481208136] = val_4.GetComponent<UnityEngine.Renderer>().sharedMaterial;
        }
        
        if(val_13 != null)
        {
                val_86 = val_13.vertexCount;
        }
        else
        {
                val_86 = 0.vertexCount;
        }
        
        System.Int32[] val_19 = val_13.triangles;
        if(val_13.normals != null)
        {
                UnityEngine.Vector3[] val_21 = val_13.normals;
            val_83 = val_83 + val_21.Length;
        }
        
        if(val_13.tangents != null)
        {
                UnityEngine.Vector4[] val_23 = val_13.tangents;
            int val_85 = 0;
            val_85 = val_85 + val_23.Length;
        }
        
        if(val_13.colors != null)
        {
                UnityEngine.Color[] val_25 = val_13.colors;
            int val_86 = 0;
            val_86 = val_86 + val_25.Length;
        }
        
        if(val_13.uv != null)
        {
                UnityEngine.Vector2[] val_27 = val_13.uv;
            val_84 = val_84 + val_27.Length;
        }
        
        val_81 = val_86 + val_81;
        val_82 = val_82 + val_19.Length;
        val_87 = val_4;
        if(val_13.uv2 == null)
        {
            goto label_41;
        }
        
        UnityEngine.Vector2[] val_29 = val_13.uv2;
        val_85 = val_85 + val_29.Length;
        goto label_41;
        label_52:
        T val_87 = val_4[0];
        if(val_87 == this.专丈丐上丈丅丌专丙)
        {
            goto label_45;
        }
        
        if(val_87 == 0)
        {
            goto label_48;
        }
        
        if(val_87.gameObject.isStatic == false)
        {
            goto label_49;
        }
        
        label_12:
        UnityEngine.Debug.LogError(message:  "MergeMeshes can\'t merge objects marked as static", context:  val_87.gameObject);
        label_45:
        val_87 = val_4;
        label_41:
        if((0 + 1) < (val_4 + 24))
        {
            goto label_52;
        }
        
        if(val_81 == 0)
        {
            goto label_53;
        }
        
        UnityEngine.Vector3[] val_35 = new UnityEngine.Vector3[0];
        val_88 = val_35;
        int[] val_36 = new int[0];
        if(val_84 != val_81)
        {
            goto label_54;
        }
        
        val_89 = new UnityEngine.Vector2[0];
        goto label_55;
        label_1:
        this.业丁丏一专丅专丄丁 = true;
        label_195:
        this.enabled = true;
        return;
        label_53:
        UnityEngine.Debug.LogWarning(message:  "Unable to find any non-static objects to merge", context:  this);
        return;
        label_54:
        val_89 = 0;
        label_55:
        val_90 = 1152921504848912384;
        if(val_85 == val_81)
        {
                UnityEngine.Vector2[] val_38 = new UnityEngine.Vector2[0];
        }
        
        val_91 = this;
        if(val_83 == val_81)
        {
                UnityEngine.Vector3[] val_39 = new UnityEngine.Vector3[0];
        }
        
        val_92 = val_4;
        val_93 = val_36;
        if(val_85 == val_81)
        {
                val_94 = new UnityEngine.Vector4[0];
        }
        else
        {
                val_94 = 0;
        }
        
        if(val_86 == val_81)
        {
                UnityEngine.Color[] val_41 = new UnityEngine.Color[0];
        }
        
        val_95 = val_89;
        val_96 = 0;
        goto label_67;
        label_160:
        T[] val_42 = val_92 + 0;
        if((((val_4 + 0) + 32) == this.专丈丐上丈丅丌专丙) || (((val_4 + 0) + 32.gameObject.isStatic) == true))
        {
            goto label_101;
        }
        
        UnityEngine.Mesh val_46 = (val_4 + 0) + 32.sharedMesh;
        if(val_46.vertexCount == 0)
        {
            goto label_77;
        }
        
        UnityEngine.Matrix4x4 val_49 = (val_4 + 0) + 32.transform.localToWorldMatrix;
        UnityEngine.Renderer val_50 = (val_4 + 0) + 32.GetComponent<UnityEngine.Renderer>();
        if(mem[1152921540481208144] == 1)
        {
            goto label_84;
        }
        
        val_50.enabled = false;
        mem[1152921540481208200].Add(item:  val_50);
        if(mem[1152921540481208144] != 2)
        {
            goto label_84;
        }
        
        val_97 = (val_4 + 0) + 32.gameObject;
        UnityEngine.Transform val_52 = val_97.transform;
        goto label_87;
        label_95:
        UnityEngine.Transform val_53 = val_92.parent;
        label_87:
        if(val_53 == this.丐一丗丛丕世丘东丁)
        {
            goto label_90;
        }
        
        if((val_53.GetComponent<UnityEngine.Rigidbody>()) == 0)
        {
            goto label_95;
        }
        
        val_97 = val_53.gameObject;
        label_90:
        val_88 = val_88;
        mem[1152921540481208192].Add(item:  val_97);
        东丄丟丏丅与丏丟七.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_97, 丏业丟一东丂东丘丛:  false);
        val_92 = val_4;
        label_84:
        if(0 == 0)
        {
            goto label_98;
        }
        
        UnityEngine.Vector3[] val_59 = val_46.normals;
        goto label_100;
        label_77:
        val_95 = val_95;
        val_100 = val_96;
        goto label_101;
        label_98:
        val_99 = 0;
        label_100:
        if(val_94 == 0)
        {
            goto label_102;
        }
        
        UnityEngine.Vector4[] val_60 = val_46.tangents;
        if(val_95 == 0)
        {
            goto label_104;
        }
        
        label_107:
        UnityEngine.Vector2[] val_61 = val_46.uv;
        goto label_106;
        label_102:
        if(val_95 != 0)
        {
            goto label_107;
        }
        
        label_104:
        label_106:
        if(0 != 0)
        {
                UnityEngine.Vector2[] val_62 = val_46.uv2;
        }
        
        if(0 == 0)
        {
            goto label_111;
        }
        
        if(val_46 != null)
        {
            goto label_149;
        }
        
        label_150:
        label_149:
        val_95 = val_95;
        if(val_58.Length < 1)
        {
            goto label_115;
        }
        
        val_101 = val_58.Length & 4294967295;
        val_102 = 0;
        val_104 = val_46.colors + 44;
        goto label_116;
        label_140:
        var val_88 = 44;
        val_102 = 1;
        val_88 = val_88 + 16;
        val_101 = mem[val_58 + 24];
        val_101 = val_58 + 24;
        val_104 = val_104 + 16;
        label_116:
        var val_89 = 12;
        val_89 = val_88 + (((long)0 + val_102) * val_89);
        mem2[0] = 1152921505780729120;
        mem2[0] = 1152921505780729120;
        mem2[0] = 1152921505780729120;
        if(0 != 0)
        {
                val_106 = val_99;
            if(val_106 == 0)
        {
                val_106 = val_99;
        }
        
            val_105 = 0f;
            var val_90 = 12;
            val_90 = 0 + (((long)0 + val_102) * val_90);
            mem2[0] = 0f;
            mem2[0] = val_105;
            mem2[0] = 5.142877E-39f;
        }
        
        if(0 != 0)
        {
                var val_67 = 0 + (((long)(int)((0 + val_102))) << 4);
            mem2[0] = ((val_63 + 44) + 16) + -12;
            mem2[0] = ((val_63 + 44) + 16) + -12 + 4;
            mem2[0] = ((val_63 + 44) + 16) + -4;
            mem2[0] = ((val_63 + 44) + 16) + -4 + 4;
            val_93 = val_36;
            val_94 = val_94;
            val_95 = val_95;
            val_88 = val_88;
        }
        
        if(val_95 != 0)
        {
                var val_68 = val_95 + (((long)(int)((0 + val_102))) << 3);
            mem2[0] = 135970152;
            mem2[0] = 0;
            val_88 = val_88;
        }
        
        if(0 != 0)
        {
                var val_69 = 0 + (((long)(int)((0 + val_102))) << 3);
            mem2[0] = 135970152;
            mem2[0] = 0;
            val_88 = val_88;
            val_94 = val_94;
        }
        
        if(val_94 != 0)
        {
                var val_70 = val_94 + (((long)(int)((0 + val_102))) << 4);
            mem2[0] = 0f;
            mem2[0] = 0f;
            mem2[0] = 0;
            mem2[0] = val_88;
            val_93 = val_36;
        }
        
        if((val_101 - 1) != val_102)
        {
            goto label_140;
        }
        
        int val_91 = 0;
        val_91 = this;
        val_92 = val_4;
        val_91 = val_91 + val_58.Length;
        label_115:
        val_100 = val_96;
        if((val_64 + 24) < 1)
        {
            goto label_142;
        }
        
        val_107 = (val_64 + 24) & 4294967295;
        val_108 = 0;
        System.Int32[] val_71 = val_46.triangles + 32;
        goto label_143;
        label_147:
        val_108 = 1;
        val_107 = mem[val_64 + 24];
        val_107 = val_64 + 24;
        label_143:
        var val_73 = 0 + val_108;
        System.Int32[] val_75 = val_93 + (((long)(int)((0 + val_108))) << 2);
        mem2[0] = ((val_64 + 32) + 4) + 0;
        if((val_107 - 1) != val_108)
        {
            goto label_147;
        }
        
        var val_92 = 0;
        val_92 = val_92 + (val_64 + 24);
        val_90 = 1152921504848912384;
        val_92 = val_4;
        val_95 = val_95;
        val_88 = val_88;
        val_94 = val_94;
        val_100 = val_96;
        goto label_148;
        label_111:
        if(val_46 != null)
        {
            goto label_149;
        }
        
        goto label_150;
        label_142:
        val_90 = 1152921504848912384;
        label_148:
        if(mem[1152921540481208144] == 1)
        {
            goto label_151;
        }
        
        if(mem[1152921540481208144] != 3)
        {
            goto label_152;
        }
        
        val_109 = (val_4 + 0) + 32.gameObject;
        goto label_156;
        label_151:
        val_109 = val_50;
        label_156:
        UnityEngine.Object.Destroy(obj:  val_109);
        label_152:
        label_101:
        val_96 = val_100 + 1;
        label_67:
        if(val_96 < (val_4 + 24))
        {
            goto label_160;
        }
        
        if(mem[1152921540481208144] == 3)
        {
                mem[1152921540481208192].Clear();
        }
        
        if(mem[1152921540481731704] == 0)
        {
            goto label_164;
        }
        
        if(mem[1152921540481208168] != 0)
        {
            goto label_167;
        }
        
        UnityEngine.Mesh val_78 = new UnityEngine.Mesh();
        mem[1152921540481208168] = val_78;
        val_78.hideFlags = 52;
        goto label_169;
        label_164:
        this.Release();
        goto label_195;
        label_167:
        val_78.Clear();
        label_169:
        val_78.name = this.丌世不丅专万丏丄丁;
        val_78.vertices = val_35;
        val_78.normals = 0;
        val_78.tangents = val_94;
        val_78.colors = 0;
        val_78.uv = val_95;
        val_78.uv2 = 0;
        val_78.triangles = val_36;
        val_78.RecalculateBounds();
        if(this.专丈丐上丈丅丌专丙 == 0)
        {
                UnityEngine.MeshFilter val_80 = val_6.AddComponent<UnityEngine.MeshFilter>();
            this.专丈丐上丈丅丌专丙 = val_80;
            val_80.mesh = val_78;
        }
        
        if(mem[1152921540481208184] == 0)
        {
                val_110 = val_6.AddComponent<UnityEngine.MeshRenderer>();
            mem[1152921540481208184] = val_110;
        }
        else
        {
                val_110 = mem[1152921540481208184];
        }
        
        val_110.sharedMaterial = mem[1152921540481208136];
        mem[1152921540481208184].enabled = true;
        object val_93 = mem[1152921540481735800];
        val_93 = val_93 * 1431655766;
        val_93 = val_93 >> 32;
        val_93 = val_93 + (val_93 >> 63);
        val_11 = val_93;
        val_6.name = System.String.Format(format:  "{0} ({1} tri)", arg0:  this.丌世不丅专万丏丄丁, arg1:  val_11);
        goto label_195;
    }
    public void Clear()
    {
        var val_8;
        var val_9;
        int val_1 = this.丟不丄丂一丆且丆丟.Count;
        if(val_1 >= 1)
        {
                val_8 = 1152921524288826496;
            do
        {
            UnityEngine.GameObject val_2 = this.丟不丄丂一丆且丆丟.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_2)) != false)
        {
                东丄丟丏丅与丏丟七.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
        }
        
            val_9 = 0 + 1;
        }
        while(val_1 != val_9);
        
        }
        
        int val_4 = this.丛丛丁丛丙丐东且不.Count;
        if(val_4 >= 1)
        {
                val_8 = 1152921539201192624;
            do
        {
            UnityEngine.Renderer val_5 = this.丛丛丁丛丙丐东且不.Item[0];
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) != false)
        {
                val_5.enabled = true;
        }
        
            val_9 = 0 + 1;
        }
        while(val_4 != val_9);
        
        }
        
        this.丟不丄丂一丆且丆丟.Clear();
        this.丛丛丁丛丙丐东且不.Clear();
        if(this.丂丟业丗上一万丘丒 == 0)
        {
                return;
        }
        
        this.丂丟业丗上一万丘丒.enabled = false;
    }
    public void Release()
    {
        this.Clear();
        东丄丟丏丅与丏丟七.Destroy(万且万且丑丗且丌丆:  this.丂丟业丗上一万丘丒);
        东丄丟丏丅与丏丟七.Destroy(万且万且丑丗且丌丆:  this.专丈丐上丈丅丌专丙);
        东丄丟丏丅与丏丟七.Destroy(万且万且丑丗且丌丆:  this.七丈丛东丗丄丟万丅);
        this.专丈丐上丈丅丌专丙 = 0;
        this.丂丟业丗上一万丘丒 = 0;
        this.七丈丛东丗丄丟万丅 = 0;
    }
    public MergeMeshes()
    {
        this.丟不丄丂一丆且丆丟 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.丛丛丁丛丙丐东且不 = new System.Collections.Generic.List<UnityEngine.Renderer>();
        this.业丁丏一专丅专丄丁 = true;
    }

}
