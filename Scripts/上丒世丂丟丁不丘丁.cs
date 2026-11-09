using UnityEngine;
private sealed class 丈丝丑与丈七东丐丆.上丒世丂丟丁不丘丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丈丝丑与丈七东丐丆 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丈丝丑与丈七东丐丆.上丒世丂丟丁不丘丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.丈丝丑与丈七东丐丆 val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this.丝且与丝丒丟万丁专;
            if(RatingSystem.与一丅丝不丈业与丙() == 0)
        {
                val_5 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_5;
            return (bool)val_5;
        }
        
            val_4.世丕丆丒丕丝下业丘();
            RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  val_4, method:  System.Void Rilisoft.丈丝丑与丈七东丐丆::世丕丆丒丕丝下业丘()));
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
