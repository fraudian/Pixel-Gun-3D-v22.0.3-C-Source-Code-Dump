using UnityEngine;
private sealed class ActivateGOByRadius.一与业不丟万丞丞专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ActivateGOByRadius 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ActivateGOByRadius.一与业不丟万丞丞专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_6;
        int val_7;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.丑不丅丁丘丛丑一七();
        goto label_5;
        label_2:
        val_7 = 0;
        return (bool)val_7;
        label_4:
        val_6 = 0.丑不丅丁丘丛丑一七();
        label_5:
        var val_4 = (this.丝且与丝丒丟万丁专.业丅东一丅三不丞丟 == true) ? 1 : 0;
        val_4 = val_6 ^ val_4;
        if(val_4 != false)
        {
                bool val_5 = val_6;
            this.丝且与丝丒丟万丁专.业丅东一丅三不丞丟 = val_5;
            this.丝且与丝丒丟万丁专.丗一三丌三与丆上与(世丁万下丗专世万丅:  val_5);
        }
        
        label_7:
        val_7 = 1;
        this.丗丏丅丕丆世丁专丟 = val_7;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_7;
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
