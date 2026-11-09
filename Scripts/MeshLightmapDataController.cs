using UnityEngine;
public class MeshLightmapDataController : MonoBehaviour
{
    // Fields
    private static System.Collections.Generic.List<MeshLightmapDataController> 丟丑丐丗丕丟丒丈丒;
    private static System.Collections.Generic.Dictionary<int, int> 七丘丝世丛丄不丒业;
    public int groupIndex;
    public UnityEngine.Vector4 m_lightmapScaleOffset;
    private UnityEngine.MeshRenderer 七丄丘丙丝丂丘丞丘;
    public UnityEngine.Texture2D lightmap;
    
    // Methods
    private void Start()
    {
        this.七丄丘丙丝丂丘丞丘 = this.GetComponent<UnityEngine.MeshRenderer>();
        this.丘上丐世丆丑且丞丒();
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_4;
        var val_5;
        int val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        if((MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Contains(item:  this)) == true)
        {
            goto label_9;
        }
        
        val_5 = null;
        val_5 = null;
        MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Add(item:  this);
        val_6 = this.groupIndex;
        if((MeshLightmapDataController.七丘丝世丛丄不丒业.ContainsKey(key:  val_6)) == true)
        {
            goto label_9;
        }
        
        val_7 = null;
        val_7 = null;
        val_6 = MeshLightmapDataController.七丘丝世丛丄不丒业;
        if(UnityEngine.LightmapSettings.lightmaps == null)
        {
            goto label_12;
        }
        
        label_16:
        val_6.Add(key:  this.groupIndex, value:  val_3.Length);
        this.丗丅丙丏丈上丝下丝();
        label_9:
        this.丝一丞丝七丙丙丂与();
        this.七丄丘丙丝丂丘丞丘.lightmapScaleOffset = new UnityEngine.Vector4() {x = this.m_lightmapScaleOffset, y = V9.16B, z = V10.16B, w = V11.16B};
        return;
        label_12:
        if(val_6 != null)
        {
            goto label_16;
        }
        
        goto label_16;
    }
    private void 丗丅丙丏丈上丝下丝()
    {
        UnityEngine.LightmapData[] val_1 = UnityEngine.LightmapSettings.lightmaps;
        int val_2 = val_1.Length + 1;
        UnityEngine.LightmapData[] val_3 = new UnityEngine.LightmapData[0];
        UnityEngine.LightmapSettings.lightmaps.CopyTo(array:  val_3, index:  0);
        UnityEngine.LightmapData val_5 = new UnityEngine.LightmapData();
        val_5.lightmapColor = this.lightmap;
        if(UnityEngine.LightmapSettings.lightmaps == null)
        {
            goto label_4;
        }
        
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_8:
        if(val_5 != null)
        {
            goto label_6;
        }
        
        goto label_10;
        label_4:
        if(val_3 != null)
        {
            goto label_8;
        }
        
        label_5:
        if(val_5 == null)
        {
            goto label_10;
        }
        
        label_6:
        label_10:
        val_3[val_6.Length] = val_5;
        UnityEngine.LightmapSettings.lightmaps = val_3;
        UnityEngine.LightmapSettings.lightmapsMode = 0;
    }
    private void 丝一丞丝七丙丙丂与()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 0;
        goto label_1;
        label_12:
        val_5 = null;
        val_5 = null;
        MeshLightmapDataController val_1 = MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Item[0];
        val_1.七丄丘丙丝丂丘丞丘.lightmapIndex = MeshLightmapDataController.七丘丝世丛丄不丒业.Item[val_1.groupIndex];
        val_4 = 1;
        label_1:
        val_6 = null;
        val_6 = null;
        if(val_4 < MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Count)
        {
            goto label_12;
        }
    
    }
    public void SaveLmUvScale()
    {
        UnityEngine.MeshRenderer val_1 = this.GetComponent<UnityEngine.MeshRenderer>();
        this.七丄丘丙丝丂丘丞丘 = val_1;
        UnityEngine.Vector4 val_2 = val_1.lightmapScaleOffset;
        this.m_lightmapScaleOffset = val_2;
        mem[1152921530934767312] = val_2.y;
        mem[1152921530934767316] = val_2.z;
        mem[1152921530934767320] = val_2.w;
        this.lightmap = UnityEngine.LightmapSettings.lightmaps[0].lightmapColor;
    }
    private void OnDestroy()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = null;
        val_5 = null;
        bool val_1 = MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Remove(item:  this);
        var val_5 = 0;
        label_12:
        val_6 = null;
        val_6 = null;
        val_7 = null;
        if(val_5 >= MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Count)
        {
            goto label_7;
        }
        
        val_8 = null;
        MeshLightmapDataController val_3 = MeshLightmapDataController.丟丑丐丗丕丟丒丈丒.Item[0];
        val_5 = val_5 + 1;
        if(val_3.groupIndex != this.groupIndex)
        {
            goto label_12;
        }
        
        return;
        label_7:
        val_9 = null;
        bool val_4 = MeshLightmapDataController.七丘丝世丛丄不丒业.Remove(key:  this.groupIndex);
    }
    public MeshLightmapDataController()
    {
    
    }
    private static MeshLightmapDataController()
    {
        MeshLightmapDataController.丟丑丐丗丕丟丒丈丒 = new System.Collections.Generic.List<MeshLightmapDataController>();
        MeshLightmapDataController.七丘丝世丛丄不丒业 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
    }

}
