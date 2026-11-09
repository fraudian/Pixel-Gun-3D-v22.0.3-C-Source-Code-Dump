using UnityEngine;
private sealed class MinigameScoreTable.七丄丐三万丟七丈丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MinigameScoreTable 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MinigameScoreTable.七丄丐三万丟七丈丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        var val_13;
        System.Collections.Generic.List<MinigameScoreTableItem> val_14;
        var val_15;
        NetworkStartTable val_16;
        var val_17;
        var val_18;
        int val_19;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = null;
        val_12 = null;
        if(this.丝且与丝丒丟万丁专.丑丞丐丕东丘丙业丗 == Count)
        {
            goto label_7;
        }
        
        val_13 = 0;
        goto label_8;
        label_23:
        val_14 = this.丝且与丝丒丟万丁专.listRecords;
        if(val_13 < Count)
        {
                val_15 = null;
            val_15 = null;
            val_14 = Item[0];
            val_16 = val_14;
        }
        else
        {
                val_16 = 0;
        }
        
        val_14.Item[0].世丏丟世丈丒丏业丑(不且上一上丐三万丛:  val_16);
        val_13 = 1;
        label_8:
        val_17 = null;
        if(val_13 < this.丝且与丝丒丟万丁专.listRecords.Count)
        {
            goto label_23;
        }
        
        val_17 = null;
        this.丝且与丝丒丟万丁专.丑丞丐丕东丘丙业丗 = Count;
        label_7:
        val_18 = 0;
        goto label_28;
        label_41:
        MinigameScoreTableItem val_7 = this.丝且与丝丒丟万丁专.listRecords.Item[0];
        if(val_7.丘丄丆不丛丗上三上 == false)
        {
            goto label_34;
        }
        
        this.丝且与丝丒丟万丁专.listRecords.Item[0].丂丆丄丛丂三丘业一();
        if(val_18 == 0)
        {
            goto label_34;
        }
        
        MinigameScoreTableItem val_9 = this.丝且与丝丒丟万丁专.listRecords.Item[-1];
        val_14 = this.丝且与丝丒丟万丁专.listRecords.Item[0];
        if((val_9.<下业丛丑丅丛与丙丂>k__BackingField) < (val_10.<下业丛丑丅丛与丙丂>k__BackingField))
        {
            goto label_39;
        }
        
        label_34:
        val_18 = 1;
        label_28:
        if(val_18 < this.丝且与丝丒丟万丁专.listRecords.Count)
        {
            goto label_41;
        }
        
        goto label_42;
        label_1:
        val_19 = 0;
        return (bool)val_19;
        label_39:
        this.丝且与丝丒丟万丁专.丄丄与丗专七丐丒东(丟丅丕万万丛丗丞丆:  -1, 丐丒丗与丝丑丛七丝:  0);
        label_42:
        val_19 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
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
