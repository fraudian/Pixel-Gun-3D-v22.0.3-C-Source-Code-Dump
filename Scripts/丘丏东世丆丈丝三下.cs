using UnityEngine;
private sealed class GiftController.丘丏东世丆丈丝三下 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftController.丘丏东世丆丈丝三下(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_5;
        UnityEngine.WaitForSeconds val_6;
        int val_7;
        var val_8;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.三丛与七下专丅丕东 = val_5;
        goto label_4;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
        {
            goto label_5;
        }
        
        goto label_6;
        label_10:
        this.丝且与丝丒丟万丁专.一丈七丟七七三丂专(丌下业东与下丅丞七:  this.丝且与丝丒丟万丁专.七丄世丈东一且丞丒.Dequeue());
        label_6:
        val_5 = this.丝且与丝丒丟万丁专.七丄世丈东一且丞丒;
        if(val_5.Count > 0)
        {
            goto label_10;
        }
        
        val_6 = this.三丛与七下专丅丕东;
        val_7 = 2;
        goto label_11;
        label_5:
        val_6 = 0;
        val_7 = 1;
        label_11:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_8;
        label_3:
        val_8 = 0;
        return (bool)val_8;
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
