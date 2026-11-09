using UnityEngine;
private sealed class 丑不丅丘七与不丑三.丙丅世与丁专丗丕专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Infrastructure.丑不丅丘七与不丑三 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丑不丅丘七与不丑三.丙丅世与丁专丗丕专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        bool val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = Infrastructure.丑不丅丘七与不丑三.下上上业一且丑东丟();
        if(Infrastructure.丑不丅丘七与不丑三.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[InAppReviewFacade.RequestThenLaunchFlowIfNeededCoroutine] needToRequest: "("[InAppReviewFacade.RequestThenLaunchFlowIfNeededCoroutine] needToRequest: ") + val_9.ToString());
            val_9 = val_9;
        }
        
        var val_7 = ~((int)(val_9 >> 0) & 1);
        val_7 = val_7 & 7;
        if(val_7 != 0)
        {
            goto label_6;
        }
        
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丆丞丈万与世丝丛丅();
        val_8 = 1;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.DateTime val_6 = System.DateTime.UtcNow;
        Infrastructure.丑不丅丘七与不丑三.专丘七丁上不丈丕不(丑丙万一丏丅丁专丏:  new System.DateTime() {dateData = val_6.dateData});
        label_6:
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
