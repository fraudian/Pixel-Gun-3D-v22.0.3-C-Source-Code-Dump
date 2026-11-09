using UnityEngine;
private sealed class ImposterModeController.丆三上上丂一且东丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ImposterModeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImposterModeController.丆三上上丂一且东丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        var val_8;
        var val_9;
        val_6 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        val_8 = null;
        val_8 = null;
        bool val_2 = 丟东丘丏上世且上丕();
        if(null == 0)
        {
            goto label_11;
        }
        
        if(val_2 == false)
        {
            goto label_12;
        }
        
        goto label_14;
        label_11:
        if(val_2 == true)
        {
            goto label_14;
        }
        
        label_12:
        label_14:
        InGameGUIPart_Imposter.__il2cppRuntimeField_nestedTypes.Play();
        if(this.丝且与丝丒丟万丁专.丑丆丏下丛世上丄丛 == false)
        {
            goto label_18;
        }
        
        label_1:
        val_7 = 0;
        return (bool)val_7;
        label_18:
        val_9 = null;
        val_9 = null;
        object val_5 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆().Item[GameConnect.丒东下丈且丕丌丞七];
        丘业丏丒上业丒世丈.一三七丟丈丝丂丝万(丕万丐东与一丈万与:  21884928);
        this.丝且与丝丒丟万丁专.丑丆丏下丛世上丄丛 = true;
        return (bool)val_7;
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
