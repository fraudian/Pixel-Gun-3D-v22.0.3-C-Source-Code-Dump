using UnityEngine;
private sealed class LeftEnemiesIndication.丕丐丐丆万不且丙专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LeftEnemiesIndication 丝且与丝丒丟万丁专;
    private double 下业丄丅丒东丞不丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeftEnemiesIndication.丕丐丐丆万不且丙专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.下业丄丅丒东丞不丒 = 0.丁与丝丁不业一丁丄();
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(((UnityEngine.Mathf.Approximately(a:  (float)this.丝且与丝丒丟万丁专.丑一丅丂丑丑丈下丂(), b:  0f)) == true) || (this.下业丄丅丒东丞不丒 <= (double)(float)this.丝且与丝丒丟万丁专.丑一丅丂丑丑丈下丂()))
        {
            goto label_9;
        }
        
        this.丝且与丝丒丟万丁专.丙丏丘不且丕丟丗丂();
        label_2:
        val_5 = 0;
        return (bool)val_5;
        label_9:
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_5;
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
