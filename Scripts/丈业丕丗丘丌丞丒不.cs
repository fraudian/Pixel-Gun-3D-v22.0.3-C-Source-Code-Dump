using UnityEngine;
private sealed class Player_move_c.丈业丕丗丘丌丞丒不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public float 丙丒七丄上与丏丙丙;
    private WeaponSounds 丅丄丛丈万丈世丙东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丈业丕丗丘丌丞丒不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Player_move_c val_6;
        WeaponSounds val_7;
        int val_8;
        val_6 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_7 = this;
        this.丅丄丛丈万丈世丙东 = val_6.丅且不三丅丂上丈丅();
        goto label_4;
        label_1:
        val_7 = this.丅丄丛丈万丈世丙东;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_7 == val_6.丅且不三丅丂上丈丅())
        {
                val_6.下丂丏万下丆丈丐丕();
        }
        
        label_8:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        val_7 = this;
        this.丅丄丛丈万丈世丙东 = 0.丅且不三丅丂上丈丅();
        label_4:
        this.丝且与丝丒丟万丁专.丏丌丙世丗一不上丙 = true;
        if(val_4.bulletExplode != false)
        {
                val_6.丆丑丐不丝上七上丝(丌丝下丄业一丄不三:  this.丅丄丛丈万丈世丙东);
        }
        
        UnityEngine.WaitForSeconds val_5 = null;
        val_6 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  this.丙丒七丄上与丏丙丙);
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_8;
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
