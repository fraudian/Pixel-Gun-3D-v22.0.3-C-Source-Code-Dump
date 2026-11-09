using UnityEngine;
public class LightMapUvSaver : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<LightMapUvSaver.MeshRenderWithName> meshRenderersToSave;
    private System.Collections.Generic.List<UnityEngine.MeshRenderer> 一且三丏丘丟且丘丐;
    public UnityEngine.Texture2D[] oldLightmaps;
    
    // Methods
    private void 三丟丕丑丙丂三丞不()
    {
        var val_6;
        if(this.meshRenderersToSave.Count >= 1)
        {
                this.meshRenderersToSave.Clear();
        }
        
        if(this.一且三丏丘丟且丘丐.Count >= 1)
        {
                this.一且三丏丘丟且丘丐.Clear();
        }
        
        this.一且三丏丘丟且丘丐.AddRange(collection:  UnityEngine.Object.FindObjectsOfType<UnityEngine.MeshRenderer>());
        List.Enumerator<T> val_4 = this.一且三丏丘丟且丘丐.GetEnumerator();
        label_41:
        if(((-711062160) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        UnityEngine.Vector4 val_8 = val_7.lightmapScaleOffset;
        val_6 = 0;
        if((UnityEngine.Vector4.op_Inequality(lhs:  new UnityEngine.Vector4() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, rhs:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f})) == false)
        {
            goto label_41;
        }
        
        if(val_7.transform.parent == 0)
        {
            goto label_20;
        }
        
        new LightMapUvSaver.MeshRenderWithName() = new LightMapUvSaver.MeshRenderWithName();
        .parentName = val_7.transform.parent.gameObject.name;
        .siblingIndex = val_7.transform.GetSiblingIndex();
        .name = val_7.gameObject.name;
        UnityEngine.Vector4 val_22 = val_7.lightmapScaleOffset;
        .uvTiling = val_22;
        mem[1152921538255645232] = val_22.y;
        mem[1152921538255645236] = val_22.z;
        mem[1152921538255645240] = val_22.w;
        .lmIndex = val_7.lightmapIndex;
        this.meshRenderersToSave.Add(item:  new LightMapUvSaver.MeshRenderWithName());
        goto label_41;
        label_20:
        new LightMapUvSaver.MeshRenderWithName() = new LightMapUvSaver.MeshRenderWithName();
        .siblingIndex = val_7.transform.GetSiblingIndex();
        .name = val_7.gameObject.name;
        UnityEngine.Vector4 val_29 = val_7.lightmapScaleOffset;
        .uvTiling = val_29;
        mem[1152921538255678000] = val_29.y;
        mem[1152921538255678004] = val_29.z;
        mem[1152921538255678008] = val_29.w;
        this.meshRenderersToSave.Add(item:  new LightMapUvSaver.MeshRenderWithName());
        goto label_41;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丐丞丛丗与世丛上丐()
    {
        var val_6;
        UnityEngine.LightmapData val_7;
        System.Collections.Generic.List<MeshRenderWithName> val_8;
        string val_9;
        var val_10;
        UnityEngine.LightmapData[] val_1 = new UnityEngine.LightmapData[0];
        val_6 = 0;
        goto label_2;
        label_14:
        UnityEngine.LightmapData val_2 = null;
        val_7 = val_2;
        val_2 = new UnityEngine.LightmapData();
        if(val_1 == null)
        {
            goto label_3;
        }
        
        if(val_7 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_7 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_1[0] = val_7;
        if(val_6 >= val_1.Length)
        {
                val_7 = mem[val_1[0x0] + 32];
            val_7 = val_1[0x0] + 32;
        }
        
        val_7.lightmapColor = this.oldLightmaps[0];
        val_6 = 1;
        label_2:
        if(val_6 < this.oldLightmaps.Length)
        {
            goto label_14;
        }
        
        UnityEngine.LightmapSettings.lightmaps = val_1;
        UnityEngine.LightmapSettings.lightmapsMode = 0;
        val_8 = this.meshRenderersToSave;
        List.Enumerator<T> val_3 = val_8.GetEnumerator();
        label_21:
        if(((-710683880) & 1) == 0)
        {
            goto label_16;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
            
        }
        else
        {
                val_9 = 28563616;
            val_10 = 135970152;
        }
        
        UnityEngine.MeshRenderer val_5 = this.丆上万不丟丙丙丈丑(丒丘丏上丙丟丑丕丈:  val_9, 东丅丑丞丆七不丟丛:  135970152, 下丒不丂丑且三与三:  null);
        val_5.lightmapScaleOffset = new UnityEngine.Vector4() {x = V8.16B, y = V9.16B, z = V10.16B, w = V11.16B};
        val_5.lightmapIndex = val_4.m_stringLength;
        goto label_21;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private UnityEngine.MeshRenderer 丆上万不丟丙丙丈丑(string 丒丘丏上丙丟丑丕丈, int 东丅丑丞丆七不丟丛, string 下丒不丂丑且三与三)
    {
        string val_19;
        var val_20;
        var val_21;
        val_19 = 下丒不丂丑且三与三;
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<UnityEngine.MeshRenderer>();
        System.Collections.Generic.List<UnityEngine.MeshRenderer> val_2 = new System.Collections.Generic.List<UnityEngine.MeshRenderer>();
        if((System.String.op_Equality(a:  val_19, b:  "")) == false)
        {
            goto label_3;
        }
        
        val_20 = 0;
        goto label_4;
        label_14:
        val_19 = val_1[0];
        if((System.String.op_Equality(a:  val_19.gameObject.name, b:  丒丘丏上丙丟丑丕丈)) != false)
        {
                if(val_19.transform.GetSiblingIndex() == 东丅丑丞丆七不丟丛)
        {
                val_2.Add(item:  val_19);
        }
        
        }
        
        val_20 = 1;
        label_4:
        if(val_20 < val_1.Length)
        {
            goto label_14;
        }
        
        goto label_15;
        label_3:
        val_21 = 0;
        goto label_16;
        label_31:
        T val_19 = val_1[0];
        val_20 = val_19.gameObject;
        if((System.String.op_Equality(a:  val_20.name, b:  丒丘丏上丙丟丑丕丈)) != false)
        {
                val_20 = val_19.transform;
            if(val_20.GetSiblingIndex() == 东丅丑丞丆七不丟丛)
        {
                val_20 = val_19.transform.parent.gameObject;
            if((System.String.op_Equality(a:  val_20.name, b:  val_19)) != false)
        {
                val_2.Add(item:  val_19);
        }
        
        }
        
        }
        
        val_21 = 1;
        label_16:
        if(val_21 < val_1.Length)
        {
            goto label_31;
        }
        
        label_15:
        if(val_2 != null)
        {
                return val_2.Item[0];
        }
        
        return val_2.Item[0];
    }
    public LightMapUvSaver()
    {
        this.一且三丏丘丟且丘丐 = new System.Collections.Generic.List<UnityEngine.MeshRenderer>();
    }

}
