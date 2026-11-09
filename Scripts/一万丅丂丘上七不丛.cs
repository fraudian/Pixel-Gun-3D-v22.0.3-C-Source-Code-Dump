using UnityEngine;
private sealed class InGameTerrain.一万丅丂丘上七不丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.Vector2 丞丟丆一丄七与丝丒;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    private PGCompany.TerrainSystem.Scripts.InGameTerrain.三世丒丟世不世与下 丄丌丂东丘丗一万且;
    private int 丝丐与丒丞一丅丑世;
    private int 丙丑三丙专专丁丄东;
    private int 丟丗丒丟丝丘丞丝丏;
    private int 下万丁丗上丐丗七丁;
    private int 且专专丒丘丄一业且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.一万丅丂丘上七不丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_36;
        int val_37;
        int val_38;
        var val_39;
        UnityEngine.Material val_40;
        TerrainData val_41;
        float val_42;
        TerrainData val_43;
        val_36 = 0;
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
                return (bool)val_36;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_37 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_37 = this.丞丟丆一丄七与丝丒 * val_37;
        this.丝丐与丒丞一丅丑世 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_37), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        float val_38 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_38 = this.丞丟丆一丄七与丝丒 * val_38;
        val_37 = this;
        this.丟丗丒丟丝丘丞丝丏 = 0;
        mem[1152921559487471196] = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_38), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        goto label_91;
        label_1:
        val_38 = 0;
        goto label_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> val_7 = this.丄丌丂东丘丗一万且.万不且且丛丆东丒业.Result;
        val_39 = 0;
        goto label_16;
        label_21:
        if(5 == this.下万丁丗上丐丗七丁)
        {
                64.enabled = false;
        }
        
        val_39 = 1;
        label_16:
        if(val_39 < this.丝且与丝丒丟万丁专.hiMeshes.Length)
        {
            goto label_21;
        }
        
        int val_8 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 32.enabled = true;
        int val_9 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        int val_10 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_30;
        }
        
        if(((this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 64) == 0)
        {
            goto label_31;
        }
        
        label_33:
        val_40 = this.丝且与丝丒丟万丁专.terrainData.previewTerrainMaterialMid;
        goto label_32;
        label_30:
        if(((this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 64) != 0)
        {
            goto label_33;
        }
        
        label_31:
        label_32:
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 32.sharedMaterial = 1152921508815298768;
        int val_11 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        UnityEngine.Vector3 val_13 = this.丝且与丝丒丟万丁专.lowMeshes[this.下万丁丗上丐丗七丁].transform.position;
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 56.position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        int val_14 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        mem2[0] = this.下万丁丗上丐丗七丁;
        int val_15 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        mem2[0] = 0;
        this.丝且与丝丒丟万丁专.lowMeshes[this.下万丁丗上丐丗七丁].enabled = false;
        int val_16 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 48.vertices = val_7.Item2;
        int val_18 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 48.uv = val_7.Item3;
        val_41 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_41 == null)
        {
            goto label_59;
        }
        
        val_42 = this.丝且与丝丒丟万丁专.terrainData.size;
        goto label_60;
        label_59:
        val_42 = this.丝且与丝丒丟万丁专.terrainData.size;
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_61;
        }
        
        val_41 = this.丝且与丝丒丟万丁专.terrainData;
        label_60:
        label_73:
        float val_41 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_41 = val_42 / val_41;
        int val_20 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  2f);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 48.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Extents = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}};
        int val_22 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
        (this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 48.SetIndices(indices:  val_7.Item1, topology:  0, submesh:  0);
        val_37 = this.丟丗丒丟丝丘丞丝丏;
        this.丄丌丂东丘丗一万且 = 0;
        goto label_85;
        label_61:
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
            goto label_84;
        }
        
        goto label_73;
        label_91:
        if(0 >= this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆.Length)
        {
            goto label_75;
        }
        
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏] = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32].丙东专丂世丈丏丁丂() + this.丝丐与丒丞一丅丑世;
        .万丘丞丈丛丟丐丛丐 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏];
        .丒丌丝与与丟丘丄业 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东];
        this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东] = (InGameTerrain.三丂丝丆丆丈丅丟且)[1152921559488228128].万丘丞丈丛丟丐丛丐 + (this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东]);
        this.下万丁丗上丐丗七丁 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东];
        if((this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东] & 2147483648) != 0)
        {
            goto label_85;
        }
        
        val_43 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_83;
        }
        
        val_43 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_43 == null)
        {
            goto label_84;
        }
        
        label_83:
        int val_42 = this.丝且与丝丒丟万丁专.terrainData.grid;
        val_42 = val_42 * this.丝且与丝丒丟万丁专.terrainData.grid;
        if(this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[this.丟丗丒丟丝丘丞丝丏][32][this.丙丑三丙专专丁丄东] >= val_42)
        {
            goto label_85;
        }
        
        if((this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[(this.下万丁丗上丐丗七丁) << 2]) != (this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东[(this.下万丁丗上丐丗七丁) << 2]))
        {
            goto label_90;
        }
        
        label_85:
        this.丟丗丒丟丝丘丞丝丏 = this.丟丗丒丟丝丘丞丝丏 + 1;
        goto label_91;
        label_75:
        val_38 = 2;
        label_106:
        val_36 = 1;
        this.丒上七丌业七丟与丐 = 0;
        label_12:
        this.丗丏丅丕丆世丁专丟 = val_38;
        return (bool)val_36;
        label_90:
        InGameTerrain.三世丒丟世不世与下 val_27 = new InGameTerrain.三世丒丟世不世与下();
        this.丄丌丂东丘丗一万且 = val_27;
        int val_29 = val_27.一丗丗丌万东丏丗丄(丆丌丕七丘丛世世丒: ref  this.丝且与丝丒丟万丁专.midMeshes);
        this.且专专丒丘丄一业且 = val_29;
        var val_30 = this.丝且与丝丒丟万丁专.midMeshes + ((long)val_29 * 40);
        if((this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[(((long)(int)(val_29) * 40) + this.丝且与丝丒丟万丁专.midMeshes + 68) << 2]) == 0)
        {
                int val_31 = this.丝且与丝丒丟万丁专.midMeshes + (this.且专专丒丘丄一业且 * 40);
            this.丝且与丝丒丟万丁专.lowMeshes[(this.且专专丒丘丄一业且 * 40) + this.丝且与丝丒丟万丁专.midMeshes + 68].enabled = true;
        }
        
        this.丄丌丂东丘丗一万且.万不且且丛丆东丒业 = System.Threading.Tasks.Task.Factory.StartNew<System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>>(function:  new System.Func<System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]>>(object:  new InGameTerrain.三丂丝丆丆丈丅丟且(), method:  System.Tuple<System.Int32[], UnityEngine.Vector3[], UnityEngine.Vector2[]> InGameTerrain.三丂丝丆丆丈丅丟且::丞下丕丛三万下丘业()));
        UnityEngine.WaitWhile val_36 = new UnityEngine.WaitWhile(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean InGameTerrain.三世丒丟世不世与下::与世下下三业丗下丙()));
        goto label_106;
        label_84:
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
