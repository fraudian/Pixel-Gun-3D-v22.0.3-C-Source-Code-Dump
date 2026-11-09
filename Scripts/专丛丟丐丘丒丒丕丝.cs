using UnityEngine;
private sealed class AIBotTargetDetector.专丛丟丐丘丒丒丕丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBot.AIBotTargetDetector 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AIBotTargetDetector.专丛丟丐丘丒丒丕丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 > 1)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        PlayerBot.且丏丕丝丄上业上丒 val_1 = this.丝且与丝丒丟万丁专.丈与丅世世丌世丗丒();
        if(val_1 == null)
        {
            goto label_6;
        }
        
        val_1 = (((PlayerBot.且丏丕丝丄上业上丒.__il2cppRuntimeField_typeHierarchy + (UnityEngine.MonoBehaviour.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
        goto label_7;
        label_1:
        val_4 = 0;
        return (bool)val_4;
        label_6:
        val_3 = 0;
        label_7:
        if(val_3 != 0)
        {
                this.丝且与丝丒丟万丁专.丏丒专丟业上下丁万(丅东丐七七世丛七丟:  false);
        }
        
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
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
