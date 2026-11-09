using UnityEngine;
private sealed class Rocket.三丒丈丏丐丏丝丏上 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Rocket 丝且与丝丒丟万丁专;
    private UnityEngine.Collider 专不丑且不丏东丟丅;
    public UnityEngine.Collider 丛丕业三七世万丕与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Rocket.三丒丈丏丐丏丝丏上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_10;
        var val_11;
        int val_12;
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
            goto label_20;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_20;
        }
        
        val_10 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟();
        val_11 = 0;
        val_12 = 0;
        if(val_10 != 0)
        {
            goto label_12;
        }
        
        return (bool)val_12;
        label_1:
        val_12 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_11 = 0;
        }
        else
        {
                val_11 = 1;
        }
        
        label_12:
        val_10 = this.丝且与丝丒丟万丁专.丅丕丟七丌丘丆丌上;
        if(val_10 == 0)
        {
                val_12 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_12;
            return (bool)val_12;
        }
        
        if(this.丝且与丝丒丟万丁专.丌且下丕下下丌万丞 == false)
        {
            goto label_20;
        }
        
        val_10 = this.丝且与丝丒丟万丁专.上丗丞且且丏丑下丟();
        if(val_10 == 0)
        {
            goto label_20;
        }
        
        this.丝且与丝丒丟万丁专.丌丈丕丞与一丗七丄();
        if((this.丝且与丝丒丟万丁专.一丏七丁且与丛丑丏(专不丑且不丏东丟丅:  this.专不丑且不丏东丟丅)) == false)
        {
            goto label_21;
        }
        
        label_20:
        val_12 = 0;
        return (bool)val_12;
        label_21:
        this.丝且与丝丒丟万丁专.与丘丕丐三丈丑七且(专不丑且不丏东丟丅:  this.专不丑且不丏东丟丅);
        var val_11 = 0;
        val_11 = val_11 + 1;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丁专丕丕丟丝丐丆丐().GetEnumerator());
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_12;
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
                Rocket.三丒丈丏丐丏丝丏上 val_2 = null;
            val_4 = val_2;
            val_2 = new Rocket.三丒丈丏丐丏丝丏上();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .专不丑且不丏东丟丅 = this.丛丕业三七世万丕与;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
