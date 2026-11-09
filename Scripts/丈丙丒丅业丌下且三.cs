using UnityEngine;
private sealed class RewardedLikeButton.丈丙丒丅业丌下且三 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RewardedLikeButton 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RewardedLikeButton.丈丙丒丅业丌下且三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_18;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this.丝且与丝丒丟万丁专, 丛丌丙世专世东丕下:  System.Void RewardedLikeButton::丟丏丕下丐丐丐丄丈()));
        this.丝且与丝丒丟万丁专.丟丏丕下丐丐丐丄丈();
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        val_5 = null;
        val_5 = null;
        if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
        {
                val_6 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_6;
            return (bool)val_6;
        }
        
        this.丝且与丝丒丟万丁专.业不不且丐且与不与();
        if(Facebook.Unity.FB.IsLoggedIn == true)
        {
            goto label_18;
        }
        
        label_8:
        if(Facebook.Unity.FB.IsLoggedIn == false)
        {
            goto label_21;
        }
        
        this.丝且与丝丒丟万丁专.业不不且丐且与不与();
        label_18:
        val_6 = 0;
        return (bool)val_6;
        label_21:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
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
