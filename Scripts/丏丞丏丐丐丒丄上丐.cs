using UnityEngine;
private sealed class 丞丝丌丄世上丈万丐.丏丞丏丐丐丒丄上丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丞丝丌丄世上丈万丐 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丞丝丌丄世上丈万丐.丏丞丏丐丐丒丄上丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.丞丝丌丄世上丈万丐 val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this.丝且与丝丒丟万丁专;
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance) == 0)
        {
                val_5 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_5;
            return (bool)val_5;
        }
        
            val_4.丙上丟丏且丐丌不丒();
            Rilisoft.PetsManager.丂丅丌一万丞丕不东(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  val_4, method:  System.Void Rilisoft.丞丝丌丄世上丈万丐::丝丐丞丘且上丒上丂(string 世丐丗专丅三丝丑丆)));
        }
        
        val_5 = 0;
        return (bool)val_5;
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
