using UnityEngine;
private sealed class MutationController.丛下丙丁丁一万专丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTable 丙丒七丄上与丏丙丙;
    public MutationController 丝且与丝丒丟万丁专;
    public string 丗七专丝一七丏与丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MutationController.丛下丙丁丁一万专丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if((System.String.op_Equality(a:  this.丙丒七丄上与丏丙丙.丈三世丞丕万丄七丂, b:  "-1")) != false)
        {
                val_3 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_3;
            return (bool)val_3;
        }
        
            val_2 = this.丗七专丝一七丏与丏;
            this.丝且与丝丒丟万丁专.丁丌丄业三丛丗下丁(丗七专丝一七丏与丏:  val_2, 三丒三丒一专丈万丑:  this.丙丒七丄上与丏丙丙.丈三世丞丕万丄七丂);
        }
        
        val_3 = 0;
        return (bool)val_3;
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
