using UnityEngine;
private sealed class Player_move_c.丂业丒上与丙丒且丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    public float 丂丁丗一不丌丁丐丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丂业丒上与丙丒且丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        FirstPersonControlSharp val_12;
        int val_13;
        float val_14;
        var val_15;
        var val_16;
        int val_17;
        var val_18;
        val_11 = this;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl;
        if(val_12.丘东一丟丝丙丄丏与() == false)
        {
            goto label_19;
        }
        
        val_13 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = this.丂丁丗一不丌丁丐丌;
        val_11 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        val_15 = null;
        val_15 = null;
        val_12 = PlayerCoreSettingsStorager.recoildAndScopeSettings;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl;
        if(val_12.丘东一丟丝丙丄丏与() == false)
        {
            goto label_19;
        }
        
        label_15:
        val_13 = 0;
        this.丝且与丝丒丟万丁专.丏丝丂专丈丝丆丄丅 = 0;
        return (bool)val_13;
        label_3:
        val_13 = 0;
        return (bool)val_13;
        label_19:
        val_12 = 1152921505320529920;
        val_14 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟().丘丁世业丒丙上丈丗();
        val_16 = null;
        val_16 = null;
        float val_8 = this.丂丁丗一不丌丁丐丌 * PlayerCoreSettingsStorager.recoildAndScopeSettings.丞丗丘丟三下下丕丙;
        BaseCamera val_9 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        if(val_14 == this.丂丁丗一不丌丁丐丌)
        {
                val_17 = 3;
            this.丒上七丌业七丟与丐 = 0;
        }
        else
        {
                val_18 = null;
            val_18 = null;
            val_14 = mem[PlayerCoreSettingsStorager.recoildAndScopeSettings + 28];
            val_14 = PlayerCoreSettingsStorager.recoildAndScopeSettings.不业丑世丕丑丙丁丟;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_14);
            val_17 = 2;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_17;
        val_13 = 1;
        return (bool)val_13;
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
