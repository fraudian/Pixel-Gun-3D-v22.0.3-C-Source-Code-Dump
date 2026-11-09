using UnityEngine;
private sealed class InGameTerrain.七上且七丏丟丂一丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.TerrainSystem.Scripts.InGameTerrain 丝且与丝丒丟万丁专;
    public UnityEngine.Vector2 丞丟丆一丄七与丝丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameTerrain.七上且七丏丟丂一丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Vector2Int[] val_23;
        InGameTerrain.七上且七丏丟丂一丘 val_24;
        var val_25;
        var val_26;
        var val_27;
        MeshInstance[] val_28;
        var val_29;
        var val_30;
        var val_31;
        TerrainData val_32;
        var val_33;
        var val_34;
        TerrainData val_35;
        int val_36;
        val_24 = this;
        val_25 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_25;
        }
        
        val_26 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_8:
        val_26 = 1;
        this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[0] = 0;
        label_3:
        if(val_26 < this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上.Length)
        {
            goto label_8;
        }
        
        val_27 = 0;
        val_28 = this.丝且与丝丒丟万丁专.hiMeshes;
        goto label_9;
        label_13:
        val_27 = 1;
        mem[65] = 1;
        label_9:
        if(val_27 < (mem[this.丝且与丝丒丟万丁专.hiMeshes] + 24))
        {
            goto label_13;
        }
        
        val_29 = 0;
        goto label_14;
        label_18:
        val_29 = 1;
        mem[65] = 1;
        label_14:
        if(val_29 < (mem[this.丝且与丝丒丟万丁专.midMeshes] + 24))
        {
            goto label_18;
        }
        
        float val_23 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_23 = this.丞丟丆一丄七与丝丒 * val_23;
        int val_3 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_23), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        float val_24 = (float)this.丝且与丝丒丟万丁专.terrainData.grid;
        val_24 = this.丞丟丆一丄七与丝丒 * val_24;
        int val_6 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  val_24), min:  0, max:  this.丝且与丝丒丟万丁专.terrainData.grid - 1);
        val_30 = 0;
        goto label_25;
        label_61:
        this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0] = this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂() + val_3;
        if((this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0] & 2147483648) != 0)
        {
            goto label_56;
        }
        
        if((this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂() + val_3) >= this.丝且与丝丒丟万丁专.terrainData.grid)
        {
            goto label_56;
        }
        
        if((this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0][32][val_6] & 2147483648) != 0)
        {
            goto label_56;
        }
        
        if(this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0][32][val_6] >= this.丝且与丝丒丟万丁专.terrainData.grid)
        {
            goto label_56;
        }
        
        int val_27 = this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0][32].丙东专丂世丈丏丁丂();
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
                val_31 = 0;
        }
        
        val_27 = (val_27 + val_3) + (this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0][32][val_6]);
        if((val_27 & 2147483648) != 0)
        {
            goto label_56;
        }
        
        val_32 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_46;
        }
        
        val_31 = 0;
        val_32 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_32 == null)
        {
            goto label_84;
        }
        
        label_46:
        int val_28 = this.丝且与丝丒丟万丁专.terrainData.grid;
        val_28 = val_28 * this.丝且与丝丒丟万丁专.terrainData.grid;
        if(val_27 < val_28)
        {
                if(this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上 == null)
        {
                val_31 = 0;
        }
        
            this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[((long)(int)((this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_10 + val_3))) << 2] = 2;
            if(this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上 == null)
        {
                val_31 = 0;
        }
        
            if(this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东 == null)
        {
                val_31 = 0;
        }
        
            if((this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[((long)(int)((this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_10 + val_3))) << 2]) == (this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东[((long)(int)((this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏[0x0][0x20][val_6]) + (val_10 + val_3))) << 2]))
        {
                int val_13 = val_31.丁一万上丛专丗丘丑(丆丌丕七丘丛世世丒: ref  val_28, 丏万丝丕不丏丐丝丞:  val_27);
            if(val_13 != 1)
        {
                var val_14 = mem[this.丝且与丝丒丟万丁专.hiMeshes] + ((long)val_13 * 40);
            mem2[0] = 0;
        }
        
        }
        
        }
        
        label_56:
        val_30 = 1;
        label_25:
        if(val_30 < this.丝且与丝丒丟万丁专.丟丅丐与丈丐丅丈丏.Length)
        {
            goto label_61;
        }
        
        val_33 = 0;
        goto label_62;
        label_98:
        val_28 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆;
        val_28[0] = val_28[0][32].丙东专丂世丈丏丁丂() + val_3;
        if((val_28[0] & 2147483648) != 0)
        {
            goto label_93;
        }
        
        val_28 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0][32].丙东专丂世丈丏丁丂();
        if((val_28 + val_3) >= this.丝且与丝丒丟万丁专.terrainData.grid)
        {
            goto label_93;
        }
        
        if((this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0][32][val_6] & 2147483648) != 0)
        {
            goto label_93;
        }
        
        val_28 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0][32];
        if(val_28[val_6] >= this.丝且与丝丒丟万丁专.terrainData.grid)
        {
            goto label_93;
        }
        
        if(this.丝且与丝丒丟万丁专.terrainData == null)
        {
                val_34 = 0;
        }
        
        val_28 = (this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0][32].丙东专丂世丈丏丁丂() + val_3) + (this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0][32][val_6]);
        if((val_28 & 2147483648) != 0)
        {
            goto label_93;
        }
        
        val_35 = this.丝且与丝丒丟万丁专.terrainData;
        if(this.丝且与丝丒丟万丁专.terrainData != null)
        {
            goto label_83;
        }
        
        val_34 = 0;
        val_35 = this.丝且与丝丒丟万丁专.terrainData;
        if(val_35 == null)
        {
            goto label_84;
        }
        
        label_83:
        int val_32 = this.丝且与丝丒丟万丁专.terrainData.grid;
        val_32 = val_32 * this.丝且与丝丒丟万丁专.terrainData.grid;
        if(val_28 < val_32)
        {
                if(this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上 == null)
        {
                val_34 = 0;
        }
        
            this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[((long)(int)((this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_18 + val_3))) << 2] = 1;
            if(this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上 == null)
        {
                val_34 = 0;
        }
        
            if(this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东 == null)
        {
                val_34 = 0;
        }
        
            if((this.丝且与丝丒丟万丁专.且专上丗丗丙丄上上[((long)(int)((this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_18 + val_3))) << 2]) == (this.丝且与丝丒丟万丁专.丆下丅丘丟丈丒丞东[((long)(int)((this.丝且与丝丒丟万丁专.terrainData.grid * this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆[0x0][0x20][val_6]) + (val_18 + val_3))) << 2]))
        {
                val_28 = val_34.丁一万上丛专丗丘丑(丆丌丕七丘丛世世丒: ref  this.丝且与丝丒丟万丁专.midMeshes, 丏万丝丕不丏丐丝丞:  val_28);
            if(val_28 != 1)
        {
                var val_22 = mem[this.丝且与丝丒丟万丁专.midMeshes] + ((long)val_28 * 40);
            mem2[0] = 0;
        }
        
        }
        
        }
        
        label_93:
        val_33 = 1;
        label_62:
        val_23 = this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆;
        if(val_33 < this.丝且与丝丒丟万丁专.丗丈丗七且世丙七丆.Length)
        {
            goto label_98;
        }
        
        val_24 = val_24;
        val_36 = 1;
        val_25 = 1;
        mem[1152921559477573832] = 0;
        goto label_99;
        label_1:
        val_36 = 0;
        label_99:
        this.丗丏丅丕丆世丁专丟 = val_36;
        return (bool)val_25;
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
