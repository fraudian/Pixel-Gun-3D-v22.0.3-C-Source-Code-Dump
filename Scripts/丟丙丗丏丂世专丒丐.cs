using UnityEngine;
private sealed class Player_move_c.丟丙丗丏丂世专丒丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private UnityEngine.Animation 丒丆丐业丕上世不丏;
    private int 丑丅专丗丙丏丕万丆;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丟丙丗丏丂世专丒丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_16;
        int val_17;
        int val_18;
        string val_19;
        int val_20;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丒丆丐业丕上世不丏 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗().丌丙丆下专丝丑且丈();
        WeaponSounds val_4 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        val_16 = val_4.meleePunchesCount;
        val_17 = 1;
        val_18 = 0;
        this.丑丅专丗丙丏丕万丆 = UnityEngine.Mathf.Max(a:  1, b:  val_16);
        this.丟丗丒丟丝丘丞丝丏 = 0;
        goto label_10;
        label_1:
        val_17 = this.丑丅专丗丙丏丕万丆;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = this.丟丗丒丟丝丘丞丝丏 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_18;
        label_10:
        if(val_18 >= val_17)
        {
            goto label_11;
        }
        
        this.丒丆丐业丕上世不丏.Stop();
        WeaponSounds val_7 = this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
        if(val_7.isDoubleShot == false)
        {
            goto label_16;
        }
        
        int val_8 = this.丝且与丝丒丟万丁专.丑丄东丂上丁七丛三();
        bool val_10 = this.丒丆丐业丕上世不丏.Play(animation:  "Shoot" + val_8);
        val_16 = this.丒丆丐业丕上世不丏;
        val_19 = "Shoot" + val_8;
        goto label_20;
        label_11:
        val_20 = 0;
        return (bool)val_20;
        label_16:
        val_16 = "Shoot";
        bool val_12 = this.丒丆丐业丕上世不丏.Play(animation:  "Shoot");
        val_19 = "Shoot";
        label_20:
        val_20 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丒丆丐业丕上世不丏.Item[val_19].length);
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
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
