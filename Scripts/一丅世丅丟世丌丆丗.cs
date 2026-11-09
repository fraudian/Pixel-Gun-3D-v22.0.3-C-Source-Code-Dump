using UnityEngine;
private sealed class ShopNGUIController.一丅世丅丟世丌丆丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShopNGUIController.一丅世丅丟世丌丆丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 3)
        {
                return;
        }
        
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_10;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        if(this.丅丒丑丄丞丑下丈丕.isDone != false)
        {
                if(this.丅丒丑丄丞丑下丈丕.asset != 0)
        {
            goto label_8;
        }
        
        }
        
        UnityEngine.Debug.LogErrorFormat(format:  "Can\'t load ShopNGUI", args:  System.Array.Empty<System.Object>());
        this.一世丕丕业且且丅丌();
        goto label_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = -3;
        UnityEngine.ResourceRequest val_5 = UnityEngine.Resources.LoadAsync<UnityEngine.GameObject>(path:  "ShopNGUI");
        this.丒上七丌业七丟与丐 = val_5;
        this.丅丒丑丄丞丑下丈丕 = val_5;
        val_10 = 1;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_8:
        if((UnityEngine.Object.Instantiate(original:  this.丅丒丑丄丞丑下丈丕.asset)) == 0)
        {
                UnityEngine.Debug.LogErrorFormat(format:  " ShopNGUI instance == null!", args:  System.Array.Empty<System.Object>());
        }
        
        this.丅丒丑丄丞丑下丈丕 = 0;
        this.一世丕丕业且且丅丌();
        label_11:
        val_10 = 0;
        return (bool)val_10;
    }
    private void 一世丕丕业且且丅丌()
    {
        var val_1;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_1 = null;
        val_1 = null;
        ShopNGUIController.上专丕丐东丙丛丘上 = 0;
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
