using UnityEngine;
private sealed class MenuBackgroundMusic.三世丟丒上世东丁万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 七不丐下丟专业万丅;
    public bool 七丆丟丗世丟且丒丆;
    public bool 丝下丘下丈一丞丄丄;
    private bool 丞三一三丄丌丛丗与;
    private UnityEngine.AudioClip 丞下丗业下丁丐丛丛;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MenuBackgroundMusic.三世丟丒上世东丁万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioSource val_19;
        var val_20;
        int val_21;
        string val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_31;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = null;
        val_20 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
        {
            goto label_6;
        }
        
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_51;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_9;
        label_6:
        val_22 = this.七不丐下丟专业万丅;
        bool val_7 = System.String.op_Equality(a:  MenuBackgroundMusic.丄一丙三丄专丛一丆().ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture), b:  val_22.ToLower(culture:  System.Globalization.CultureInfo.InvariantCulture));
        this.丞三一三丄丌丛丗与 = val_7;
        if(val_7 != false)
        {
                if(this.七丆丟丗世丟且丒丆 == false)
        {
            goto label_51;
        }
        
        }
        
        if(this.丝下丘下丈一丞丄丄 != false)
        {
                MenuBackgroundMusic.七专丐丞丏丌丐丝一(丙业与丙丗丝不丈东:  this.七不丐下丟专业万丅);
        }
        
        UnityEngine.AudioClip val_9 = MenuBackgroundMusic.且丕上丙东专万丝业(七不丐下丟专业万丅:  this.七不丐下丟专业万丅);
        this.丞下丗业下丁丐丛丛 = val_9;
        if(val_9 == 0)
        {
            goto label_51;
        }
        
        label_9:
        val_23 = null;
        val_23 = null;
        val_22 = 1152921504848912384;
        if(MenuBackgroundMusic.丙丛丗七七万上东丐 == 0)
        {
            goto label_30;
        }
        
        val_24 = null;
        val_24 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 != 0)
        {
            goto label_35;
        }
        
        label_30:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_21 = 1;
        return (bool)val_21;
        label_35:
        val_25 = null;
        if(MenuBackgroundMusic.七一丐丈丅丆丙与丗() == 0)
        {
            goto label_41;
        }
        
        val_26 = null;
        MenuBackgroundMusic.丙丛丗七七万上东丐.Stop();
        val_22 = MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘();
        val_22.clip = this.丞下丗业下丁丐丛丛;
        val_27 = null;
        if(this.丞三一三丄丌丛丗与 == false)
        {
            goto label_47;
        }
        
        val_28 = null;
        val_19 = MenuBackgroundMusic.丙丛丗七七万上东丐;
        val_19.Play();
        goto label_51;
        label_41:
        val_29 = null;
        UnityEngine.AudioSource val_16 = MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘();
        val_16.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  val_16);
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.与丒丏丛业丒丟丛丘().clip = this.丞下丗业下丁丐丛丛;
        goto label_57;
        label_47:
        val_31 = null;
        label_57:
        val_19 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
        val_19.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  val_19.与丒丏丛业丒丟丛丘());
        label_51:
        val_21 = 0;
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
