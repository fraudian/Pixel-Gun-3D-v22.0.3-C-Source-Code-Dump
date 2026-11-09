using UnityEngine;
private sealed class 丒丆丅丂丂丄丕且东.专丏一下丝丞丝丞丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丒丆丅丂丂丄丕且东 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丒丆丅丂丂丄丕且东.专丏一下丝丞丝丞丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_7 = 0.一丈不三丄丛世七丘();
            if(val_7 == 0)
        {
                this.丝且与丝丒丟万丁专.不与丂下万一丑下与 = 0;
        }
        
            if(this.丝且与丝丒丟万丁专.不与丂下万一丑下与 == 0)
        {
                val_7 = 0.一丈不三丄丛世七丘();
            bool val_4 = UnityEngine.Object.op_Inequality(x:  val_7, y:  0);
            if(val_4 != false)
        {
                val_7 = val_4.一丈不三丄丛世七丘();
            this.丝且与丝丒丟万丁专.不与丂下万一丑下与 = val_7.GetHashCode();
        }
        
        }
        
            val_8 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_8;
            return (bool)val_8;
        }
        
        val_8 = 0;
        return (bool)val_8;
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
