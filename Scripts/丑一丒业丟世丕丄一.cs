using UnityEngine;
private sealed class PopUpWeaponWindow.丑一丒业丟世丕丄一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PopUpWeaponWindow 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PopUpWeaponWindow.丑一丒业丟世丕丄一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_6;
        int val_7;
        System.Collections.Generic.List<世丂丈世且万世丞上> val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_6 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        val_7 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_1:
        val_6 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_6 != null)
        {
                val_6.专不丄一丂丏丄丙丏();
        }
        else
        {
                0.专不丄一丂丏丄丙丏();
        }
        
        System.Collections.Generic.List<世丂丈世且万世丞上> val_7 = this.丝且与丝丒丟万丁专.currentWeaponBonuses;
        val_7 = val_7.Count - 1;
        if((val_7 & 2147483648) == 0)
        {
                do
        {
            val_8 = this.丝且与丝丒丟万丁专.currentWeaponBonuses.Item[val_7];
            var val_8 = 0;
            val_8 = val_8 + 1;
            if(val_8.AlreadyHaveThisWeapon() != false)
        {
                val_8 = this.丝且与丝丒丟万丁专.currentWeaponBonuses;
            世丂丈世且万世丞上 val_6 = val_8.Item[val_7];
            val_6.三下丗万丆专丄且东(丗丌丅丒世专丕一丑:  val_6);
        }
        
            val_7 = val_7 - 1;
        }
        while((val_7 & 2147483648) == 0);
        
        }
        
        label_7:
        val_7 = 0;
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
