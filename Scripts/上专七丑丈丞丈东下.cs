using UnityEngine;
private sealed class NetworkStartTableNGUIController.上专七丑丈丞丈东下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    private float 丒丙丏七丑丑三丐丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.上专七丑丈丞丈东下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        int val_6;
        UISprite val_7;
        float val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_5;
        }
        
        val_4 = this;
        this.丒丙丏七丑丑三丐丞 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丙丏丏丛丁与丘三丝 != 0)
        {
            goto label_4;
        }
        
        goto label_5;
        label_1:
        val_4 = this.丒丙丏七丑丑三丐丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_5 = mem[this.丒丙丏七丑丑三丐丞];
        val_5 = val_4;
        if(val_5 < 0)
        {
            goto label_6;
        }
        
        label_5:
        val_6 = 0;
        return (bool)val_6;
        label_6:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_7 = this.丝且与丝丒丟万丁专.nextBar;
            val_8 = this.丝且与丝丒丟万丁专.丒丒且丅丁丑丕丙丁;
        }
        else
        {
                val_7 = 0;
            val_8 = 9.725011E-43f;
            val_5 = mem[this.丒丙丏七丑丑三丐丞];
            val_5 = val_4;
        }
        
        val_7.fillAmount = UnityEngine.Mathf.Lerp(a:  val_8, b:  this.丝且与丝丒丟万丁专.丗丙丁东上三丘丛丆, t:  UnityEngine.Mathf.Min(a:  val_5, b:  1f));
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丒丙丏七丑丑三丐丞 + val_3;
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丒丙丏七丑丑三丐丞 = val_3;
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
