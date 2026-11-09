using UnityEngine;
private sealed class 丑不丅丘七与不丑三.丗丙丕且一丑丝丈七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Infrastructure.丑不丅丘七与不丑三 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丑不丅丘七与不丑三.丗丙丕且一丑丝丈七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(Infrastructure.丑不丅丘七与不丑三.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[InAppReviewFacade.RequestThenLaunchFlowCoroutine]");
        }
        
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丆丞丈万与世丝丛丅();
        val_4 = 1;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.DateTime val_3 = System.DateTime.UtcNow;
        Infrastructure.丑不丅丘七与不丑三.专丘七丁上不丈丕不(丑丙万一丏丅丁专丏:  new System.DateTime() {dateData = val_3.dateData});
        label_2:
        val_4 = 0;
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
