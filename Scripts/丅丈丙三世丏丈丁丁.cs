using UnityEngine;
private sealed class TryGuns_2_0_Controller.丅丈丙三世丏丈丁丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.TryGuns_2_0_Controller 丝且与丝丒丟万丁专;
    public bool 丝七下丗丝丗丑三且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TryGuns_2_0_Controller.丅丈丙三世丏丈丁丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.TryGuns_2_0_Controller val_5;
        var val_6;
        var val_7;
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = this.丝且与丝丒丟万丁专;
        val_6 = null;
        if(Rilisoft.TryGuns_2_0_Controller.专丛丈丆丕丈丛丕与() == false)
        {
            goto label_4;
        }
        
        val_7 = null;
        val_7 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
            goto label_9;
        }
        
        label_4:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        val_8 = 0;
        return (bool)val_8;
        label_9:
        if(val_5 != null)
        {
                val_5.丌丌不下丆业丒丛丟(丝七下丗丝丗丑三且:  (this.丝七下丗丝丗丑三且 == true) ? 1 : 0);
        }
        else
        {
                0.丌丌不下丆业丒丛丟(丝七下丗丝丗丑三且:  (this.丝七下丗丝丗丑三且 == true) ? 1 : 0);
        }
        
        if(this.丝且与丝丒丟万丁专.下丙不丛丞丅且与丟 != true)
        {
                this.丝且与丝丒丟万丁专.下丙不丛丞丅且与丟 = true;
        }
        
        this.丝且与丝丒丟万丁专.丟世丛丛丐丕丙与丛 = 0;
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
