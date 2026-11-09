using UnityEngine;
private sealed class InGameTerrain.业丒东三丗丄七下丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.Vector2 丞丟丆一丄七与丝丒;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    private PGCompany.TerrainSystem.Scripts.InGameTerrain.丛丝与丅万丙丄丆丗 丄丌丂东丘丗一万且;
    private int 丝丐与丒丞一丅丑世;
    private int 丙丑三丙专专丁丄东;
    private int 丟丗丒丟丝丘丞丝丏;
    private int 下万丁丗上丐丗七丁;
    private int 且专专丒丘丄一业且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.业丒东三丗丄七下丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_38;
        int val_39;
        int val_40;
        var val_41;
        UnityEngine.Material val_42;
        TerrainData val_43;
        float val_44;
        TerrainData val_45;
        val_38 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_38;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_39 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_39 = this.丞丟丆一丄七与丝丒 * val_39;
        this.丝丐与丒丞一丅丑世 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_39), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        float val_40 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_40 = this.丞丟丆一丄七与丝丒 * val_40;
        val_39 = this;
        this.丟丗丒丟丝丘丞丝丏 = 0;
        mem[1152921559484083036] = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_40), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        goto label_94;
        label_1:
        val_40 = 0;
        goto label_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_7 = this.丄丌丂东丘丗一万且.万不且且丛丆东丒业.Result;
        val_41 = 0;
        goto label_16;
        label_21:
        if(5 == this.下万丁丗上丐丗七丁)
        {
                64.enabled = false;
        }
        
        val_41 = 1;
        label_16:
        if(val_41 < this.丝且与丝丒丟万丁专.midMeshes.Length)
        {
            goto label_21;
        }
        
        int val_8 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 32.enabled = true;
        int val_9 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        int val_10 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_30;
        }
        
        if(((this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 64) == 0)
        {
            goto label_31;
        }
        
        label_33:
        val_42 = this.丝且与丝丒丟万丁专.terrainData.previewTerrainMaterialLow;
        goto label_32;
        label_30:
        if(((this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 64) != 0)
        {
            goto label_33;
        }
        
        label_31:
        label_32:
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 32.sharedMaterial = 1152921508815298768;
        int val_11 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专.lowMeshes[this.下万丁丗上丐丗七丁].transform.position;
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 56.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        int val_14 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        mem2[0] = this.下万丁丗上丐丗七丁;
        int val_15 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.lowMeshes[this.下万丁丗上丐丗七丁].enabled = false;
        int val_16 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 48.vertices = val_7.Item2;
        int val_18 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 48.uv = val_7.Item3;
        val_43 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_43 == null)
        {
            goto label_59;
        }
        
        val_44 = this.丝且与丝丒丟万丁专.terrainData.size;
        goto label_60;
        label_59:
        val_44 = this.丝且与丝丒丟万丁专.terrainData.size;
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_61;
        }
        
        val_43 = this.丝且与丝丒丟万丁专.terrainData;
        label_60:
        label_76:
        float val_43 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_43 = val_44 / val_43;
        int val_20 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 48.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
        int val_22 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 48.SetIndices(indices:  val_7.Item1, topology:  0, submesh:  0);
        int val_24 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 48.RecalculateNormals();
        val_39 = this.丟丗丒丟丝丘丞丝丏;
        this.丄丌丂东丘丗一万且 = 0;
        goto label_88;
        label_61:
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_87;
        }
        
        goto label_76;
        label_94:
        if(0 >= this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏.Length)
        {
            goto label_78;
        }
        
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[this.丟丗丒丟丝丘丞丝丏] = this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[this.丟丗丒丟丝丘丞丝丏][32].丙东专丂世丈丏丁丂() + this.丝丐与丒丞一丅丑世;
        .万丘丞丈丛丟丐丛丐 = this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[this.丟丗丒丟丝丘丞丝丏];
        .丒丌丝与与丟丘丄业 = this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东];
        int val_27 = this.丝且与丝丒丟万丁专.丙丆丑业专万丟丐一(三丟东丕丄丄下下丑:  (InGameTerrain.丕丘丅三丛丘专世一)[1152921559484876832].万丘丞丈丛丟丐丛丐, 丒丒丄丁且丄丆丂丌:  this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东], 与丘东下丈东丛丂万:  this.丝且与丝丒丟万丁专.terrainData.grid);
        this.下万丁丗上丐丗七丁 = val_27;
        if((val_27 & 2147483648) != 0)
        {
            goto label_88;
        }
        
        val_45 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_86;
        }
        
        val_45 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_45 == null)
        {
            goto label_87;
        }
        
        label_86:
        int val_45 = this.丝且与丝丒丟万丁专.terrainData.grid;
        val_45 = val_45 * this.丝且与丝丒丟万丁专.terrainData.grid;
        if(val_27 >= val_45)
        {
            goto label_88;
        }
        
        if((this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[(this.下万丁丗上丐丗七丁) << 2]) != (this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东[(this.下万丁丗上丐丗七丁) << 2]))
        {
            goto label_93;
        }
        
        label_88:
        this.丟丗丒丟丝丘丞丝丏 = this.丟丗丒丟丝丘丞丝丏 + 1;
        goto label_94;
        label_78:
        val_40 = 2;
        label_109:
        val_38 = 1;
        this.丒上七丌业七丟与丐 = 0;
        label_12:
        this.丗丏丅丕丆世丁专丟 = val_40;
        return (bool)val_38;
        label_93:
        this.丄丌丂东丘丗一万且 = new InGameTerrain.丛丝与丅万丙丄丆丗();
        int val_31 = this.丝且与丝丒丟万丁专.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.丝且与丝丒丟万丁专.hiMeshes);
        this.且专专丒丘丄一业且 = val_31;
        var val_32 = this.丝且与丝丒丟万丁专.hiMeshes + ((long)val_31 * 40);
        if((this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[(((long)(int)(val_31) * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 68) << 2]) != 2)
        {
                int val_33 = this.丝且与丝丒丟万丁专.hiMeshes + (this.且专专丒丘丄一业且 * 40);
            this.丝且与丝丒丟万丁专.lowMeshes[(this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.hiMeshes + 68].enabled = true;
        }
        
        this.丄丌丂东丘丗一万且.万不且且丛丆东丒业 = System.Threading.Tasks.Task.Factory.StartNew<System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>>(function:  new System.Func<System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>>(object:  new InGameTerrain.丕丘丅三丛丘专世一(), method:  System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> InGameTerrain.丕丘丅三丛丘专世一::专一且东丌上七丏丐()));
        UnityEngine.WaitWhile val_38 = new UnityEngine.WaitWhile(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean InGameTerrain.丛丝与丅万丙丄丆丗::万丐丌丕丞专丟业丘()));
        goto label_109;
        label_87:
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
