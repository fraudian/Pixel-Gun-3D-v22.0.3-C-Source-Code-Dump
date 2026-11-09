using UnityEngine;
private sealed class Player_move_c.丄丑三不丞一丗丅下 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private string 与丟丅七丞且且丛丕;
    public string 万七下丅一丙丆专丙;
    public Player_move_c 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丄丑三不丞一丗丅下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_21;
        string val_22;
        int val_23;
        string val_24;
        var val_25;
        RoyaleAvatar val_26;
        var val_27;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_65;
        }
        
        val_21 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.op_Inequality(a:  this.与丟丅七丞且且丛丕, b:  System.String.alignConst)) == false)
        {
            goto label_3;
        }
        
        val_22 = this.与丟丅七丞且且丛丕;
        if((System.String.op_Inequality(a:  val_22, b:  this.丝且与丝丒丟万丁专.七丟丐不丛专一丏丕)) == true)
        {
            goto label_5;
        }
        
        val_22 = this.丝且与丝丒丟万丁专.丑丂丛万专不不丅丗;
        if(val_22 != 0)
        {
            goto label_8;
        }
        
        label_5:
        UnityEngine.ResourceRequest val_5 = UnityEngine.Resources.LoadAsync(path:  "RoyaleAvatars/"("RoyaleAvatars/") + this.与丟丅七丞且且丛丕);
        this.丅丒丑丄丞丑下丈丕 = val_5;
        this.丒上七丌业七丟与丐 = val_5;
        val_23 = 1;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                if(this.丅丒丑丄丞丑下丈丕.asset != 0)
        {
            goto label_15;
        }
        
        }
        
        object[] val_9 = new object[1];
        val_22 = this.与丟丅七丞且且丛丕;
        val_9[0] = val_22;
        UnityEngine.Debug.LogWarningFormat(format:  "Can\'t load RoyalAvatar: {0}", args:  val_9);
        goto label_22;
        label_15:
        if(this.丅丒丑丄丞丑下丈丕.asset != null)
        {
                if(null == null)
        {
            goto label_25;
        }
        
        }
        
        object[] val_11 = new object[1];
        val_22 = this.与丟丅七丞且且丛丕;
        val_11[0] = val_22;
        label_52:
        UnityEngine.Debug.LogErrorFormat(format:  "Wrong RoyalAvatar asset {0}! Must be a GameObject!", args:  val_11);
        label_22:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.七丟丐不丛专一丏丕 = System.String.alignConst;
        }
        else
        {
                mem[72] = System.String.alignConst;
        }
        
        val_23 = 0;
        this.丝且与丝丒丟万丁专.丑丐业丌丕一丏下丛 = 0;
        return (bool)val_23;
        label_8:
        val_24 = this.与丟丅七丞且且丛丕;
        goto label_35;
        label_25:
        val_25 = this.丅丒丑丄丞丑下丈丕.asset;
        if(val_25 == null)
        {
            goto label_37;
        }
        
        if(null == null)
        {
            goto label_40;
        }
        
        val_25 = 0;
        goto label_40;
        label_37:
        label_40:
        val_26 = val_25.GetComponent<RoyaleAvatar>();
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丑丂丛万专不不丅丗 = val_26;
        }
        else
        {
                mem[80] = val_26;
            val_26 = mem[80];
        }
        
        if(val_26 != 0)
        {
            goto label_45;
        }
        
        new object[1][0] = this.与丟丅七丞且且丛丕;
        goto label_52;
        label_45:
        val_21 = this.与丟丅七丞且且丛丕;
        this.丅丒丑丄丞丑下丈丕 = 0;
        label_3:
        val_24 = mem[this.与丟丅七丞且且丛丕];
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_53;
        }
        
        label_35:
        val_27 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.七丟丐不丛专一丏丕 = val_24;
        this.丝且与丝丒丟万丁专.SetRoyaleAvatarToPlayerBody();
        val_22 = 0;
        goto label_54;
        label_53:
        val_27 = 72;
        mem[72] = val_24;
        0.SetRoyaleAvatarToPlayerBody();
        val_22 = 1;
        label_54:
        if((System.String.op_Equality(a:  mem[72], b:  System.String.alignConst)) != false)
        {
                this.丝且与丝丒丟万丁专.丑丂丛万专不不丅丗 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丑丐业丌丕一丏下丛 = 0;
        if((GameConnect.丄丏丒丏上东业丒一() != false) && (this.丝且与丝丒丟万丁专.丟三丏丅世一丟丟上 != 0))
        {
                if(this.丝且与丝丒丟万丁专.丟三丏丅世一丟丟上.且世专不丄丏七下万() != false)
        {
                this.丝且与丝丒丟万丁专.丛丁上丂东丛丂业世(丙业与丙丗丝不丈东:  true);
        }
        
        }
        
        label_65:
        val_23 = 0;
        return (bool)val_23;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.丄丑三不丞一丗丅下 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丄丑三不丞一丗丅下();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .与丟丅七丞且且丛丕 = this.万七下丅一丙丆专丙;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
