using UnityEngine;
private sealed class UniversalMiniBannerListUI.丄丅三丛丘业一丏上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UniversalMiniBannerListUI 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UniversalMiniBannerListUI.丄丅三丛丘业一丏上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if(this.丝且与丝丒丟万丁专.丑丌丟东丙万丞且丘.Count >= 1)
        {
                float val_2 = UnityEngine.Time.unscaledDeltaTime;
            val_2 = this.丝且与丝丒丟万丁专.丈东丈且不东丞专丒 - val_2;
            this.丝且与丝丒丟万丁专.丈东丈且不东丞专丒 = val_2;
            if(val_2 <= 0f)
        {
                this.丝且与丝丒丟万丁专.丏丈上丏丝下且丁七();
        }
        
        }
        
            val_3 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_3;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
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
