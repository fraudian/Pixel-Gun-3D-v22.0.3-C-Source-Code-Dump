using UnityEngine;
private sealed class 丛且世丐丆上七业丁.专万不七丆丄不丕丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丛且世丐丆上七业丁 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丕一丁丑业丌上丂丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丛且世丐丆上七业丁.专万不七丆丄不丕丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSecondsRealtime val_5;
        int val_6;
        var val_7;
        if((this.丗丏丅丕丆世丁专丟 == 2) || (this.丗丏丅丕丆世丁专丟 == 1))
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丕一丁丑业丌上丂丕 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if((this.丝且与丝丒丟万丁专.专丛丄东丝丕丌一东 == false) || (AuthSceneController.一不丆丏与丐丏丈丄() == false))
        {
            goto label_8;
        }
        
        List.Enumerator<T> val_2 = this.丝且与丝丒丟万丁专.<丙丌丅丝丘与三丗丑>k__BackingField.GetEnumerator();
        label_12:
        if(((-368504856) & 1) == 0)
        {
            goto label_10;
        }
        
        0.丐丏七丌丕丗业且上().丕丕业七丙七丅丈丄();
        goto label_12;
        label_8:
        val_5 = 0;
        val_6 = 2;
        goto label_13;
        label_3:
        val_7 = 0;
        return (bool)val_7;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_5 = this.丕一丁丑业丌上丂丕;
        if(val_5 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_4 = null;
            val_5 = val_4;
            val_4 = new UnityEngine.WaitForSecondsRealtime(time:  0.5f);
            this.丕一丁丑业丌上丂丕 = val_5;
        }
        
        val_6 = 1;
        label_13:
        val_7 = 1;
        this.丒上七丌业七丟与丐 = val_5;
        this.丗丏丅丕丆世丁专丟 = val_6;
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
