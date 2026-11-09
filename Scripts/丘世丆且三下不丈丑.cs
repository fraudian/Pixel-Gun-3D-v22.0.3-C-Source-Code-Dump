using UnityEngine;
private sealed class FortCraftSceneLoader.丘世丆且三下不丈丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.FortCraftSceneLoader 丝且与丝丒丟万丁专;
    private UnityEngine.AsyncOperation 上专丞丁丂业与丂丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortCraftSceneLoader.丘世丆且三下不丈丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        UnityEngine.AsyncOperation val_5;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丒丛丁丑丞丗丐且世();
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_1:
        val_5 = this.上专丞丁丂业与丂丌;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 != null)
        {
            goto label_8;
        }
        
        goto label_7;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  "Fort");
        this.上专丞丁丂业与丂丌 = val_5;
        if(val_5 != null)
        {
            goto label_8;
        }
        
        label_7:
        label_8:
        if(val_5.isDone == false)
        {
            goto label_9;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        this.丝且与丝丒丟万丁专.东专丄与丑世东丏且 = 0;
        goto label_11;
        label_9:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_4 = 1;
        return (bool)val_4;
        label_10:
        mem[48] = 0;
        label_11:
        this.丝且与丝丒丟万丁专.丌与丁丏丌三丅专丗();
        label_3:
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
