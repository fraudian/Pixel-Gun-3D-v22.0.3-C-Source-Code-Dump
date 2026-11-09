using UnityEngine;
private sealed class MinigameScoreTable.丑丗万丛丆丂丙不下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MinigameScoreTable 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MinigameScoreTable.丑丗万丛丆丂丙不下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_23;
        MinigameScoreTable.丑丗万丛丆丂丙不下 val_24;
        MinigameScoreTable val_25;
        var val_26;
        System.Collections.Generic.List<MinigameScoreTableItem> val_27;
        int val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        string val_33;
        NetworkStartTable val_34;
        var val_35;
        var val_36;
        var val_37;
        val_24 = this;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        val_25 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_26 = null;
        val_26 = null;
        if(this.丝且与丝丒丟万丁专.丑丞丐丕东丘丙业丗 != Count)
        {
            goto label_7;
        }
        
        val_27 = this.丝且与丝丒丟万丁专.listRecords;
        goto label_8;
        label_1:
        val_28 = 0;
        return (bool)val_28;
        label_7:
        val_29 = null;
        val_29 = null;
        val_30 = 0;
        val_31 = 0;
        val_27 = val_25 + 24;
        goto label_13;
        label_30:
        MinigameScoreTableItem val_2 = val_27.Item[0];
        if((val_2.<丞丁丙丏七丆与世丅>k__BackingField) == false)
        {
            goto label_19;
        }
        
        val_32 = 0;
        val_31 = 1;
        goto label_17;
        label_25:
        val_32 = 1;
        label_17:
        if(val_32 >= Count)
        {
            goto label_19;
        }
        
        NetworkStartTable val_4 = Item[1];
        MinigameScoreTableItem val_5 = val_27.Item[0];
        val_33 = val_5.业上上丏丄不上丅丈;
        if((val_4.丈三世丞丕万丄七丂.Equals(value:  val_33)) == false)
        {
            goto label_25;
        }
        
        if(null != 0)
        {
                val_34 = Item[1];
        }
        else
        {
                val_34 = Item[1];
        }
        
        bool val_9 = Remove(item:  val_34);
        label_19:
        val_30 = 1;
        label_13:
        if(val_30 < val_27.Count)
        {
            goto label_30;
        }
        
        val_35 = 0;
        goto label_31;
        label_40:
        val_33 = Count + val_31;
        MinigameScoreTableItem val_12 = val_27.Item[val_27];
        if(val_27 < val_33)
        {
                val_12.丁丒下且丗丈丑丛丂(不且上一上丐三万丛:  Item[0]);
        }
        else
        {
                val_12.与丛三丒专丄丈专下();
        }
        
        val_35 = 1;
        label_31:
        if((val_31 + val_35) < val_27.Count)
        {
            goto label_40;
        }
        
        val_36 = null;
        val_36 = null;
        val_24 = val_24;
        val_25 = val_25;
        mem2[0] = Count;
        label_8:
        val_23 = 1152921540225106832;
        val_37 = 0;
        goto label_45;
        label_58:
        MinigameScoreTableItem val_17 = val_27.Item[0];
        if(val_17.丘丄丆不丛丗上三上 != false)
        {
                MinigameScoreTableItem val_18 = val_27.Item[0];
            if((val_18.<丞丁丙丏七丆与世丅>k__BackingField) != true)
        {
                val_27.Item[0].万万丗下丁下丗业丟();
            if(val_37 != 0)
        {
                if((val_25.一一丏东丙丒丘丟丁(丟丅丕万万丛丗丞丆:  -1, 丐丒丗与丝丑丛七丝:  0)) == true)
        {
            goto label_55;
        }
        
        }
        
        }
        
        }
        
        val_37 = 1;
        label_45:
        if(val_37 < val_27.Count)
        {
            goto label_58;
        }
        
        label_60:
        val_28 = 1;
        mem[1152921540225993320] = 0;
        this.丗丏丅丕丆世丁专丟 = val_28;
        return (bool)val_28;
        label_55:
        val_25.业一丐丏七万一世三(丟丅丕万万丛丗丞丆:  -1, 丐丒丗与丝丑丛七丝:  0);
        goto label_60;
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
