using UnityEngine;
[Serializable]
public class TerrainData : ScriptableObject
{
    // Fields
    public UnityEngine.Texture2D heightMap;
    public UnityEngine.Texture2D splatMap;
    public UnityEngine.Texture2D minitex;
    public int minitexWidth;
    public int grid;
    public float MaxHeight;
    public int maxMeshResolution;
    public float MeshOptimizationThreshold;
    public bool optimize;
    public float size;
    public string meshesDir;
    public string collidersDir;
    public string materialsDir;
    public UnityEngine.Material commonTerrainMaterial;
    public UnityEngine.Material[] materials;
    public UnityEngine.Mesh[] meshes;
    public UnityEngine.Mesh[] colliders;
    public UnityEngine.Material previewTerrainMaterialLow;
    public UnityEngine.Material previewTerrainMaterialMid;
    public float playerHeightUpdateThreshold;
    public byte[] heights;
    
    // Methods
    private void OnEnable()
    {
        this.minitexWidth = this.minitex.width;
        this.丘不丐万丙丒丈丘七();
    }
    private void 丘不丐万丙丒丈丘七()
    {
        int val_1 = this.minitexWidth * this.minitexWidth;
        byte[] val_2 = new byte[0];
        this.heights = val_2;
        if(this.minitexWidth < 1)
        {
                return;
        }
        
        var val_10 = 0;
        do
        {
            int val_8 = this.minitexWidth;
            var val_9 = val_10;
            do
        {
            val_8 = val_8 - 1;
            val_9 = val_9 + this.minitexWidth;
            this.heights[0] = UnityEngine.Mathf.RoundToInt(f:  (val_2.上丛东丌丝丄丁业丕(丘丐与世丘丆丛丈丁:  this.minitex).GetPixels()[0]) * 255f);
        }
        while(val_8 != 0);
        
            val_10 = val_10 + 1;
        }
        while(val_10 != this.minitexWidth);
    
    }
    private UnityEngine.Texture2D 上丛东丌丝丄丁业丕(UnityEngine.Texture2D 丘丐与世丘丆丛丈丁)
    {
        UnityEngine.RenderTexture val_3 = UnityEngine.RenderTexture.GetTemporary(width:  丘丐与世丘丆丛丈丁.width, height:  丘丐与世丘丆丛丈丁.height, depthBuffer:  0, format:  7, readWrite:  1);
        UnityEngine.Graphics.Blit(source:  丘丐与世丘丆丛丈丁, dest:  val_3);
        UnityEngine.RenderTexture.active = val_3;
        UnityEngine.Texture2D val_7 = new UnityEngine.Texture2D(width:  丘丐与世丘丆丛丈丁.width, height:  丘丐与世丘丆丛丈丁.height);
        val_7.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        val_7.Apply();
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_3);
        return val_7;
    }
    public TerrainData()
    {
        this.maxMeshResolution = 40;
        this.size = 500f;
    }

}
