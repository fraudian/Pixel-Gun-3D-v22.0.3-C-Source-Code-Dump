using UnityEngine;
private sealed class FriendsController.与一丗业丆东丌丆丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FriendsController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FriendsController.与一丗业丆东丌丆丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_5 = 1152921505252638720;
            if(ReviewController.一丌丄一不丏与丙丗() != false)
        {
                val_5 = ReviewController.不丕丏丝丝与上七上();
            this.丝且与丝丒丟万丁专.SendReviewForPlayerWithID(丈丐世下丞与丂专丏:  val_5, 丄丝丁专丄丑丟三丆:  ReviewController.世丗上万三业与一丄());
            val_6 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  600f);
            this.丗丏丅丕丆世丁专丟 = val_6;
            return (bool)val_6;
        }
        
        }
        
        val_6 = 0;
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
