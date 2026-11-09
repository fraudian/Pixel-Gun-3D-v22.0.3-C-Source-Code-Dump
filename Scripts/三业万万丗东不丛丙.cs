using UnityEngine;
private sealed class InGameTerrain.三业万万丗东不丛丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    private float 丈世丐丑丄世丕上七;
    private int 三丂且七丘丐丟丘丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.三业万万丗东不丛丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_21;
        int val_22;
        TerrainData val_23;
        TerrainData val_24;
        var val_25;
        int val_26;
        var val_27;
        TerrainData val_28;
        float val_29;
        TerrainData val_30;
        val_21 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_22 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_22;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_4;
        }
        
        val_23 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_23 == null)
        {
            goto label_51;
        }
        
        label_4:
        float val_19 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_19 = this.丝且与丝丒丟万丁专.terrainData.size / val_19;
        this.丈世丐丑丄世丕上七 = val_19;
        val_24 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_6;
        }
        
        val_24 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_24 == null)
        {
            goto label_51;
        }
        
        label_6:
        int val_1 = this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.terrainData.grid;
        val_25 = val_21;
        val_26 = 0;
        this.丝且与丝丒丟万丁专.lowMeshes = new UnityEngine.MeshRenderer[0];
        this.三丂且七丘丐丟丘丅 = 0;
        goto label_10;
        label_1:
        val_25 = val_21;
        val_26 = this.三丂且七丘丐丟丘丅 + 1;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丂且七丘丐丟丘丅 = val_26;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            
        }
        
        label_10:
        if(val_26 >= this.丝且与丝丒丟万丁专.terrainData.grid)
        {
            goto label_12;
        }
        
        val_26 = 0;
        goto label_50;
        label_54:
        UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  System.String.Format(format:  "LowMesh_{0}_{1}", arg0:  this.三丂且七丘丐丟丘丅, arg1:  val_26));
        val_4.transform.parent = this.丝且与丝丒丟万丁专.transform;
        float val_20 = 0f;
        float val_21 = (float)this.三丂且七丘丐丟丘丅;
        val_20 = this.丈世丐丑丄世丕上七 * val_20;
        val_21 = this.丈世丐丑丄世丕上七 * val_21;
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_27 = val_4.AddComponent<UnityEngine.MeshFilter>();
        UnityEngine.Mesh val_9 = new UnityEngine.Mesh();
        System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_10 = this.丝且与丝丒丟万丁专.丕丆丗丏丒东丝丄丒(万丘丞丈丛丟丐丛丐:  0, 丒丌丝与与丟丘丄业:  this.三丂且七丘丐丟丘丅, 丁与丞丞万丄丐丝一:  4, 丛七丄世上丘丅七丝:  this.丝且与丝丒丟万丁专.terrainData, 不一丅丟丐一丐东丘:  this.丝且与丝丒丟万丁专.丂丅万上丝不丈三三, 丘丕丝上下丄丈丏丒:  this.丝且与丝丒丟万丁专.万丝一丈不下丛丗专);
        val_9.vertices = val_10.Item2;
        val_9.uv = val_10.Item3;
        val_28 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_28 == null)
        {
            goto label_24;
        }
        
        val_29 = this.丝且与丝丒丟万丁专.terrainData.size;
        goto label_25;
        label_24:
        val_29 = this.丝且与丝丒丟万丁专.terrainData.size;
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_26;
        }
        
        val_28 = this.丝且与丝丒丟万丁专.terrainData;
        val_21 = val_21;
        val_25 = 1152921559480697676;
        val_27 = val_27;
        label_25:
        label_52:
        float val_22 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_22 = val_29 / val_22;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
        val_9.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
        val_9.SetIndices(indices:  val_10.Item1, topology:  0, submesh:  0);
        val_27.sharedMesh = val_9;
        UnityEngine.MeshRenderer val_15 = val_4.AddComponent<UnityEngine.MeshRenderer>();
        val_15.sharedMaterial = this.丝且与丝丒丟万丁专.terrainData.previewTerrainMaterialLow;
        if(this.丝且与丝丒丟万丁专.lowMeshes == null)
        {
            goto label_37;
        }
        
        if(val_15 != null)
        {
            goto label_38;
        }
        
        goto label_41;
        label_37:
        if(val_15 == null)
        {
            goto label_41;
        }
        
        label_38:
        label_41:
        this.丝且与丝丒丟万丁专.lowMeshes[(long)this.丝且与丝丒丟万丁专.丙丆丑业专万丟丐一(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  this.三丂且七丘丐丟丘丅, 与丘东下丈东丛丂万:  this.丝且与丝丒丟万丁专.terrainData.grid)] = val_15;
        val_30 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_44;
        }
        
        val_30 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_30 == null)
        {
            goto label_51;
        }
        
        label_44:
        val_4.AddComponent<UnityEngine.MeshCollider>().sharedMesh = this.丝且与丝丒丟万丁专.terrainData.colliders[(long)this.丝且与丝丒丟万丁专.丙丆丑业专万丟丐一(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  this.三丂且七丘丐丟丘丅, 与丘东下丈东丛丂万:  this.丝且与丝丒丟万丁专.terrainData.grid)];
        val_4.hideFlags = 8;
        val_26 = val_26 + 1;
        goto label_50;
        label_26:
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_50:
        if(val_26 < this.丝且与丝丒丟万丁专.terrainData.grid)
        {
            goto label_54;
        }
        
        val_22 = 1;
        this.丗丏丅丕丆世丁专丟 = val_22;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丕丄不与丒上丟下三;
        return (bool)val_22;
        label_12:
        val_22 = 0;
        this.丝且与丝丒丟万丁专.丐丗专丙丄不丑丑丆 = true;
        return (bool)val_22;
        label_51:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
