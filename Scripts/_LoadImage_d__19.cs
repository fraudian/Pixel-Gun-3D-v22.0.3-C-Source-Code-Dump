using UnityEngine;
private sealed class PlayGamesUserProfile.<LoadImage>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GooglePlayGames.PlayGamesUserProfile <>4__this;
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayGamesUserProfile.<LoadImage>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_11;
        int val_12;
        UnityEngine.Networking.UnityWebRequest val_13;
        val_11 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.<>4__this.mAvatarUrl)) == false)
        {
            goto label_4;
        }
        
        UnityEngine.Debug.Log(message:  "No URL found.");
        this.<>4__this.mImage = UnityEngine.Texture2D.blackTexture;
        val_12 = 0;
        this.<>4__this.mImageLoading = false;
        return (bool)val_12;
        label_1:
        val_13 = this.<www>5__2;
        this.<>1__state = 0;
        goto label_8;
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_4:
        UnityEngine.Networking.UnityWebRequest val_3 = UnityEngine.Networking.UnityWebRequestTexture.GetTexture(uri:  this.<>4__this.mAvatarUrl);
        val_13 = val_11;
        this.<www>5__2 = val_3;
        UnityEngine.Networking.UnityWebRequestAsyncOperation val_4 = val_3.SendWebRequest();
        label_8:
        if((this.<www>5__2.isDone) == false)
        {
            goto label_12;
        }
        
        if((this.<www>5__2.error) == null)
        {
            goto label_14;
        }
        
        this.<>4__this.mImage = UnityEngine.Texture2D.blackTexture;
        val_11 = "Error downloading image: "("Error downloading image: ") + this.<www>5__2.error(this.<www>5__2.error);
        UnityEngine.Debug.Log(message:  val_11);
        goto label_19;
        label_12:
        val_12 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_12;
        return (bool)val_12;
        label_14:
        val_11 = UnityEngine.Networking.DownloadHandlerTexture.GetContent(www:  this.<www>5__2);
        this.<>4__this.mImage = val_11;
        label_19:
        val_12 = 0;
        this.<>4__this.mImageLoading = false;
        this.<www>5__2 = 0;
        return (bool)val_12;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
