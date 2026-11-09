using UnityEngine;
private sealed class ReviewHUDWindow.且丆丒东世丏世丕丈 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ReviewHUDWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReviewHUDWindow.且丆丒东世丏世丕丈(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
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
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.OnCloseThanks();
        goto label_8;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.不一丒丒东业丈丞专 != false)
        {
                this.丝且与丝丒丟万丁专.不一丒丒东业丈丞专 = false;
            if(this.丝且与丝丒丟万丁专.objThanks != 0)
        {
                this.丝且与丝丒丟万丁专.万丞丞丟丟万丒丞世 = true;
            this.丝且与丝丒丟万丁专.objThanks.SetActive(value:  true);
        }
        
            this.丝且与丝丒丟万丁专.丝丂丕丏与专丐丙丅();
            InfoWindowController.丑七不且上丗丁一世().丞丙下丑丗丑丝业丁();
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  3f);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_5 = 1;
            return (bool)val_5;
        }
        
        label_8:
        val_5 = 0;
        return (bool)val_5;
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
