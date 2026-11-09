using UnityEngine;
private sealed class 丑不丅丘七与不丑三.一丑一一丗丄世丙丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Infrastructure.丑不丅丘七与不丑三 丝且与丝丒丟万丁专;
    private Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> 丄一丝丌且上丌一东;
    private Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> 丌丕东丁丈丏一丈且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丑不丅丘七与不丑三.一丑一一丗丄世丙丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_19;
        Infrastructure.丑不丅丘七与不丑三 val_20;
        int val_21;
        string val_22;
        string val_24;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        val_20 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_21 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_21;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> val_1 = this.丝且与丝丒丟万丁专.丙世不丌丕丙七丌一.RequestReviewFlow();
        this.丄一丝丌且上丌一东 = val_1;
        this.丒上七丌业七丟与丐 = val_1;
        val_21 = 1;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = 1152921540888733440;
        if(this.丌丕东丁丈丏一丈且.Error == 0)
        {
            goto label_8;
        }
        
        val_22 = this.丌丕东丁丈丏一丈且.Error.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_24 = "[InAppReviewFacade.RequestThenLaunchFlowCoroutine] launchFlowOperation.Error: ";
        goto label_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丄一丝丌且上丌一东.Error == 0)
        {
            goto label_14;
        }
        
        val_22 = this.丄一丝丌且上丌一东.Error.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_24 = "[InAppReviewFacade.RequestThenLaunchFlowCoroutine] requestFlowOperation.Error: ";
        label_12:
        val_19 = val_24 + val_22;
        UnityEngine.Debug.LogError(message:  val_19);
        label_24:
        val_21 = 0;
        return (bool)val_21;
        label_8:
        if(Infrastructure.丑不丅丘七与不丑三.世丈且业丆丑丏丐一() == false)
        {
            goto label_24;
        }
        
        UnityEngine.Debug.Log(message:  "[InAppReviewFacade.RequestThenLaunchFlowCoroutine] launchFlowOperation.IsSuccessful: "("[InAppReviewFacade.RequestThenLaunchFlowCoroutine] launchFlowOperation.IsSuccessful: ") + this.丌丕东丁丈丏一丈且 & 1.ToString()(this.丌丕东丁丈丏一丈且 & 1.ToString()));
        goto label_24;
        label_14:
        if(Infrastructure.丑不丅丘七与不丑三.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[InAppReviewFacade.RequestThenLaunchFlowCoroutine] requestFlowOperation.IsSuccessful: "("[InAppReviewFacade.RequestThenLaunchFlowCoroutine] requestFlowOperation.IsSuccessful: ") + this.丄一丝丌且上丌一东 & 1.ToString()(this.丄一丝丌且上丌一东 & 1.ToString()));
        }
        
        Google.Play.Common.PlayAsyncOperation<Google.Play.Common.VoidResult, Google.Play.Review.ReviewErrorCode> val_18 = this.丝且与丝丒丟万丁专.丙世不丌丕丙七丌一.LaunchReviewFlow(reviewInfo:  this.丄一丝丌且上丌一东.GetResult());
        this.丌丕东丁丈丏一丈且 = val_18;
        this.丒上七丌业七丟与丐 = val_18;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_21;
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
