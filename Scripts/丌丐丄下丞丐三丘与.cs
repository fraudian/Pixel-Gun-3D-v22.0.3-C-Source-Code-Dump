using UnityEngine;
private sealed class MonsterDeadCondition.丌丐丄下丞丐三丘与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MonsterDeadCondition 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MonsterDeadCondition.丌丐丄下丞丐三丘与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        MonsterHunterModeController val_4;
        var val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        val_4 = MonsterHunterModeController.丆丕丝丒不丙且丐丗;
        if(val_4 == 0)
        {
            goto label_11;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = MonsterHunterModeController.丆丕丝丒不丙且丐丗;
        if(MonsterHunterModeController.丆丕丝丒不丙且丐丗.丟一丙丟不专三丕且 != true)
        {
                if(val_4.丅丕万业丄丏不丄丂() == false)
        {
            goto label_11;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丛万丙丏丝丗丛丄丐();
        label_1:
        val_6 = 0;
        return (bool)val_6;
        label_11:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
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
