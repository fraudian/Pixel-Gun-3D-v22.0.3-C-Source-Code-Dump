using UnityEngine;
private sealed class Player_move_c.专专丞一丆一丄与丒 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private string 丆丟万丈与三丑且丆;
    public string 丏下丆丗丝且下丌丏;
    public Player_move_c 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.专专丞一丆一丄与丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_17;
        int val_18;
        var val_19;
        object val_20;
        System.Object[] val_21;
        string val_22;
        UnityEngine.GameObject val_23;
        val_17 = this.丝且与丝丒丟万丁专;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_2 = UnityEngine.Resources.LoadAsync(path:  "LandingTrails/"("LandingTrails/") + this.丆丟万丈与三丑且丆);
        this.丅丒丑丄丞丑下丈丕 = val_2;
        this.丒上七丌业七丟与丐 = val_2;
        val_18 = 1;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_2:
        val_19 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                if(this.丅丒丑丄丞丑下丈丕.asset != 0)
        {
            goto label_26;
        }
        
        }
        
        object[] val_6 = new object[2];
        val_17 = val_6;
        val_17[0] = this.丆丟万丈与三丑且丆;
        val_20 = "air_trail";
        val_17[1] = val_20;
        UnityEngine.Debug.LogWarningFormat(format:  "Can\'t load LandingTrail: {0}. Replacing by: {1}", args:  val_6);
        UnityEngine.ResourceRequest val_7 = UnityEngine.Resources.LoadAsync(path:  "LandingTrails/air_trail");
        this.丅丒丑丄丞丑下丈丕 = val_7;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_18 = 1;
        return (bool)val_18;
        label_1:
        val_19 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                if(this.丅丒丑丄丞丑下丈丕.asset != 0)
        {
            goto label_26;
        }
        
        }
        
        val_21 = new object[1];
        val_20 = "air_trail";
        val_21[0] = val_20;
        val_22 = "Can\'t load LandingTrail: {0}!";
        goto label_33;
        label_3:
        val_18 = 0;
        return (bool)val_18;
        label_26:
        if(this.丅丒丑丄丞丑下丈丕.asset != null)
        {
                if(null == null)
        {
            goto label_37;
        }
        
        }
        
        object[] val_13 = new object[1];
        val_20 = this.丆丟万丈与三丑且丆;
        val_21 = val_13;
        val_21[0] = val_20;
        val_22 = "Wrong LandingTrail asset {0}! Must be a GameObject!";
        label_33:
        UnityEngine.Debug.LogErrorFormat(format:  val_22, args:  val_13);
        label_50:
        if(val_17 != null)
        {
            goto label_52;
        }
        
        label_53:
        label_52:
        val_18 = 0;
        this.丝且与丝丒丟万丁专.丛七丕丅东丟丘专丙 = 0;
        return (bool)val_18;
        label_37:
        val_23 = this.丅丒丑丄丞丑下丈丕.asset;
        if((val_23 != null) && (null != null))
        {
                val_23 = 0;
        }
        
        this.丝且与丝丒丟万丁专.万上东丑上丁世丐丘 = val_23;
        if(val_17.世丈丝丞专且七七下() == false)
        {
            goto label_50;
        }
        
        val_17.TrySetLandingTrails();
        if(val_17 != null)
        {
            goto label_52;
        }
        
        goto label_53;
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
                Player_move_c.专专丞一丆一丄与丒 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.专专丞一丆一丄与丒();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丆丟万丈与三丑且丆 = this.丏下丆丗丝且下丌丏;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
