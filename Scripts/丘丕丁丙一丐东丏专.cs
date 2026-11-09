using UnityEngine;
internal sealed class 丘丕丁丙一丐东丏专
{
    // Fields
    private System.Collections.Generic.Queue<丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒> 丏丆丐一丝丟丗不丞;
    
    // Properties
    internal int 丒专下与丑丁丆丟业 { get; }
    
    // Methods
    internal int 丂丁丏一丙丛业且丌()
    {
        if(this.丏丆丐一丝丟丗不丞 != null)
        {
                return this.丏丆丐一丝丟丗不丞.Count;
        }
        
        return this.丏丆丐一丝丟丗不丞.Count;
    }
    internal Player_move_c 业专不丟丑丒专丁丛(float 丝丙一丝丈丂不丙一, float 下丑丝丛丞丏丞丅上)
    {
        System.Collections.Generic.Queue<丁东丄万丅世世丅丒> val_14;
        var val_15;
        int val_16;
        int val_17;
        var val_18;
        int val_19;
        var val_20;
        val_14 = this.丏丆丐一丝丟丗不丞;
        if(val_14.Count < 1)
        {
            goto label_19;
        }
        
        System.Collections.Generic.List<Player_move_c> val_2 = null;
        val_14 = val_2;
        val_2 = new System.Collections.Generic.List<Player_move_c>();
        val_15 = this.丏丆丐一丝丟丗不丞.Peek();
        float val_14 = val_3.与丕丌丒丗丄丘丙东;
        val_14 = 丝丙一丝丈丂不丙一 - val_14;
        val_14 = val_14 / 下丑丝丛丞丏丞丅上;
        if(val_14 < 1f)
        {
            goto label_9;
        }
        
        goto label_6;
        label_14:
        丁东丄万丅世世丅丒 val_4 = this.丏丆丐一丝丟丗不丞.Peek();
        if(val_4.与丕丌丒丗丄丘丙东 > val_3.与丕丌丒丗丄丘丙东)
        {
            goto label_9;
        }
        
        丁东丄万丅世世丅丒 val_5 = this.丏丆丐一丝丟丗不丞.Dequeue();
        val_2.Add(item:  val_5.专丞上七七且丝七丗);
        label_6:
        if(this.丏丆丐一丝丟丗不丞.Count >= 1)
        {
            goto label_14;
        }
        
        label_9:
        if(val_14 == null)
        {
            goto label_15;
        }
        
        val_16 = val_2.Count;
        if(val_2.Count < 2)
        {
            goto label_16;
        }
        
        val_17 = UnityEngine.Random.Range(min:  0, max:  val_16);
        goto label_17;
        label_15:
        val_15 = 1152921525487174064;
        val_16 = val_2.Count;
        if(val_2.Count >= 2)
        {
            goto label_18;
        }
        
        label_16:
        if(val_16 == 1)
        {
                val_18 = 1152921525490623376;
            val_19 = 0;
            return (Player_move_c)val_2.Item[val_19];
        }
        
        label_19:
        val_20 = 0;
        return (Player_move_c)val_2.Item[val_19];
        label_18:
        val_17 = UnityEngine.Random.Range(min:  0, max:  val_16);
        label_17:
        val_18 = 1152921525490623376;
        val_19 = val_17;
        return (Player_move_c)val_2.Item[val_19];
    }
    internal void 上丙上丈三丐丞丛专(Player_move_c 专丞上七七且丝七丗, float 丂三丟丂丈丐丆丗丟)
    {
        丁东丄万丅世世丅丒[] val_1 = this.丛丏上上丟丞丆不丌(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if(val_1.Length != 0)
        {
                this.丒下丝下丒丟丞丆丞(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        }
        
        丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒 val_2 = new 丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒();
        if(val_2 != null)
        {
                .专丞上七七且丝七丗 = 专丞上七七且丝七丗;
        }
        else
        {
                mem[16] = 专丞上七七且丝七丗;
        }
        
        .与丕丌丒丗丄丘丙东 = 丂三丟丂丈丐丆丗丟;
        this.丏丆丐一丝丟丗不丞.Enqueue(item:  val_2);
    }
    internal void 丒下丝下丒丟丞丆丞(Player_move_c 专丞上七七且丝七丗)
    {
        丁东丄万丅世世丅丒[] val_6;
        丘丕丁丙一丐东丏专.丞丂万丅不丒丘丟丗 val_1 = new 丘丕丁丙一丐东丏专.丞丂万丅不丒丘丟丗();
        val_6 = this.丛丏上上丟丞丆不丌(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .专丆丏专丈丝一万丑 = val_6;
        if(val_6 != null)
        {
            goto label_4;
        }
        
        label_5:
        label_4:
        if(val_2.Length == 0)
        {
                return;
        }
        
        System.Collections.Generic.Queue<丁东丄万丅世世丅丒> val_5 = null;
        val_6 = val_5;
        val_5 = new System.Collections.Generic.Queue<丁东丄万丅世世丅丒>(collection:  System.Linq.Enumerable.Where<丁东丄万丅世世丅丒>(source:  this.丏丆丐一丝丟丗不丞, predicate:  new System.Func<丁东丄万丅世世丅丒, System.Boolean>(object:  val_1, method:  System.Boolean 丘丕丁丙一丐东丏专.丞丂万丅不丒丘丟丗::丙丐三东丝丂丁丌丗(丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒 一下丞七不丕丌丝丁))));
        this.丏丆丐一丝丟丗不丞 = val_6;
        return;
        label_1:
        mem[16] = val_6;
        if(mem[16] != 0)
        {
            goto label_4;
        }
        
        goto label_5;
    }
    internal bool 下一且丄不与丑东丅(Player_move_c 专丞上七七且丝七丗)
    {
        丁东丄万丅世世丅丒[] val_1 = this.丛丏上上丟丞丆不丌(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        return (bool)(val_1.Length != 0) ? 1 : 0;
    }
    internal float 不世丏东丅丁丆丟东(Player_move_c 专丞上七七且丝七丗)
    {
        .专丞上七七且丝七丗 = 专丞上七七且丝七丗;
        if((System.Linq.Enumerable.First<丁东丄万丅世世丅丒>(source:  System.Linq.Enumerable.Where<丁东丄万丅世世丅丒>(source:  this.丏丆丐一丝丟丗不丞, predicate:  new System.Func<丁东丄万丅世世丅丒, System.Boolean>(object:  new 丘丕丁丙一丐东丏专.丒丑万一丁丕东一丗(), method:  System.Boolean 丘丕丁丙一丐东丏专.丒丑万一丁丕东一丗::业丅万丆丂一丒与丂(丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒 一下丞七不丕丌丝丁))))) != null)
        {
                return (float)val_4.与丕丌丒丗丄丘丙东;
        }
        
        return (float)val_4.与丕丌丒丗丄丘丙东;
    }
    private 丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒[] 丛丏上上丟丞丆不丌(Player_move_c 专丞上七七且丝七丗)
    {
        .专丞上七七且丝七丗 = 专丞上七七且丝七丗;
        return System.Linq.Enumerable.ToArray<丁东丄万丅世世丅丒>(source:  System.Linq.Enumerable.Where<丁东丄万丅世世丅丒>(source:  this.丏丆丐一丝丟丗不丞, predicate:  new System.Func<丁东丄万丅世世丅丒, System.Boolean>(object:  new 丘丕丁丙一丐东丏专.业东下丕世丗丏万丏(), method:  System.Boolean 丘丕丁丙一丐东丏专.业东下丕世丗丏万丏::丛且东上上丑丄丕丞(丘丕丁丙一丐东丏专.丁东丄万丅世世丅丒 一下丞七不丕丌丝丁))));
    }
    internal int 丒一丅与与一丘不业()
    {
        var val_5;
        Queue.Enumerator<T> val_1 = this.丏丆丐一丝丟丗不丞.GetEnumerator();
        val_5 = 0;
        do
        {
            label_11:
            if(((-364044088) & 1) == 0)
        {
                return (int);
        }
        
        }
        while(0.丘丑丅三丆丑丌且丝() == 0);
        
        if(val_5 == 1)
        {
            goto label_6;
        }
        
        if(val_5 == 0.丘丑丅三丆丑丌且丝())
        {
            goto label_11;
        }
        
        goto label_9;
        label_6:
        int val_4 = 0.丘丑丅三丆丑丌且丝();
        goto label_11;
        label_9:
        val_5 = 0;
        return (int);
    }
    internal void 世业丒万丘丆专丘丐()
    {
        this.丏丆丐一丝丟丗不丞.Clear();
    }
    public 丘丕丁丙一丐东丏专()
    {
        this.丏丆丐一丝丟丗不丞 = new System.Collections.Generic.Queue<丁东丄万丅世世丅丒>();
    }

}
