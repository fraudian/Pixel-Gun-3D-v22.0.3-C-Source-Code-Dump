using UnityEngine;
private sealed class TrainingController.丑丏丐丘丅世丛丟丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TrainingController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TrainingController.丑丏丐丘丅世丛丟丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(TrainingController.丁丑七与丙丐丘丌下() < 6)
        {
            goto label_6;
        }
        
        this.丝且与丝丒丟万丁专.craneAndRobot.Play(stateName:  "move");
        label_1:
        val_3 = 0;
        return (bool)val_3;
        label_6:
        this.丝且与丝丒丟万丁专.craneAndRobot.Play(stateName:  "idle");
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1.5f);
        this.丗丏丅丕丆世丁专丟 = val_3;
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
