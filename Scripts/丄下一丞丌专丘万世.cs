using UnityEngine;
private sealed class ClanStartGui_v2.丄下一丞丌专丘万世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ClanStartGui_v2 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanStartGui_v2.丄下一丞丌专丘万世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ClanStartGui_v2 val_5;
        int val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        System.Action<UnityEngine.GameObject> val_14;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_6 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  15f);
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = 1152921505152585728;
        val_5 = this.丝且与丝丒丟万丁专;
        val_8 = null;
        val_8 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 == false)
        {
            goto label_6;
        }
        
        val_9 = null;
        if(this.丝且与丝丒丟万丁专.七业下专一丕丞丐东.Count == 0)
        {
            goto label_9;
        }
        
        label_6:
        val_8 = null;
        if(ClansWindowGUI.丆丂丐丈丈三丛丂世 == false)
        {
            goto label_16;
        }
        
        val_6 = this.丝且与丝丒丟万丁专.七业下专一丕丞丐东;
        if(val_6.Count == 0)
        {
                return (bool)val_6;
        }
        
        val_5.三丛丗一且丐丕三丅();
        goto label_16;
        label_9:
        val_10 = null;
        ClansWindowGUI.丆丂丐丈丈三丛丂世 = false;
        val_11 = null;
        val_11 = null;
        ClansController.丑丏丛不丂丄上且丈 = false;
        val_5 = this.丝且与丝丒丟万丁专.disabledUnHardUI;
        val_12 = null;
        val_12 = null;
        val_14 = ClanStartGui_v2.<>c.<>9__50_0;
        if(val_14 == null)
        {
                System.Action<UnityEngine.GameObject> val_4 = null;
            val_14 = val_4;
            val_4 = new System.Action<UnityEngine.GameObject>(object:  ClanStartGui_v2.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStartGui_v2.<>c::丞丛与丄万丈一丆丙(UnityEngine.GameObject 七丞丙丒三丕且丌丟));
            ClanStartGui_v2.<>c.<>9__50_0 = val_14;
        }
        
        val_5.ForEach(action:  val_4);
        label_16:
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
