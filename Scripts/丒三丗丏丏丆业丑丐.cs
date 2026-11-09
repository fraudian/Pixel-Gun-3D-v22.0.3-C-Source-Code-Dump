using UnityEngine;
private sealed class FlashFire.丒三丗丏丏丆业丑丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FlashFire 丝且与丝丒丟万丁专;
    public Player_move_c 丛丁东东丑丟丞丁丟;
    private UnityEngine.Ray 丘与世丟丏丘与丟丗;
    private bool 丞丆丐三与丒丅丅丒;
    private int 丑三丑丞丌不一丞丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FlashFire.丒三丗丏丏丆业丑丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_13;
        string val_18;
        var val_19;
        UnityEngine.Ray val_20;
        WeaponSounds val_21;
        int val_22;
        float val_23;
        float val_24;
        float val_26;
        int val_27;
        val_18 = this;
        val_19 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_20;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专.gunFlashObj.transform.parent.position;
        UnityEngine.Vector3 val_7 = this.丝且与丝丒丟万丁专.gunFlashObj.transform.parent.parent.forward;
        val_19 = val_3.x;
        val_20 = this.丘与世丟丏丘与丟丗;
        mem[1152921526029043568] = 0;
        this.丞丆丐三与丒丅丅丒 = false;
        this.丑三丑丞丌不一丞丒 = 0;
        this.丘与世丟丏丘与丟丗 = 0;
        val_21 = this.丝且与丝丒丟万丁专.ws;
        if(this.丝且与丝丒丟万丁专.ws.countReflectionRay != 1)
        {
            goto label_12;
        }
        
        val_22 = 0;
        val_23 = val_3.z;
        val_24 = val_3.y;
        val_18 = this.丝且与丝丒丟万丁专.ws.railName;
        UnityEngine.GameObject val_8 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = val_3.y, z = val_23}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = 0f, y = val_24, z = val_3.z}, 丛丄万三丂东丙丑东:  val_18, 不丅丛专丘丅专丘丕:  150f);
        goto label_20;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        int val_9 = this.丑三丑丞丌不一丞丒 + 1;
        this.丑三丑丞丌不一丞丒 = val_9;
        if(this.丞丆丐三与丒丅丅丒 == false)
        {
            goto label_20;
        }
        
        val_21 = this.丝且与丝丒丟万丁专.ws;
        if(val_9 >= this.丝且与丝丒丟万丁专.ws.countReflectionRay)
        {
            goto label_20;
        }
        
        val_20 = this.丘与世丟丏丘与丟丗;
        label_12:
        丗丝丄丞丐与不丕丗 val_11 = this.丛丁东东丑丟丞丁丟.丝丙丄与七丂不七丄(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = this.丘与世丟丏丘与丟丗.m_Origin, y = this.丘与世丟丏丘与丟丗.m_Origin, z = this.丘与世丟丏丘与丟丗.m_Origin}, m_Direction = new UnityEngine.Vector3() {x = this.丘与世丟丏丘与丟丗.m_Origin, y = mem[this.丘与世丟丏丘与丟丗 + 16], z = mem[this.丘与世丟丏丘与丟丗 + 16]}}, 丆丒不丗丅丂丅丞丅:  false, 不丅丛专丘丅专丘丕:  this.丝且与丝丒丟万丁专.ws.丕丟丕业丑三下专丑(), 一丛上丗丑丐丄丟与:  false);
        val_26 = 0f;
        val_23 = V2.16B;
        if((0 == 0) && (this.丑三丑丞丌不一丞丒 == 0))
        {
                float val_14 = this.丝且与丝丒丟万丁专.ws.丕丟丕业丑三下专丑();
            val_26 = val_14;
        }
        
        val_24 = val_14;
        val_21 = this.丝且与丝丒丟万丁专.ws.railName;
        UnityEngine.GameObject val_15 = WeaponManager.上不丝专丏丝丙丅丆(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_24, y = 0f, z = V2.16B}, 丗丟东丗丕世丛丌丗:  new UnityEngine.Vector3() {x = val_13, y = 0f, z = val_23}, 丛丄万三丂东丙丑东:  val_21, 不丅丛专丘丅专丘丕:  val_26);
        if(0 != 0)
        {
                mem2[0] = val_13;
            mem2[0] = 0;
            this.丞丆丐三与丒丅丅丒 = true;
        }
        
        val_22 = this.丑三丑丞丌不一丞丒;
        UnityEngine.WaitForSeconds val_16 = null;
        float val_17 = 0.05f;
        val_17 = (float)val_22 * val_17;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  val_17);
        val_27 = 1;
        this.丒上七丌业七丟与丐 = val_16;
        this.丗丏丅丕丆世丁专丟 = val_27;
        return (bool)val_27;
        label_20:
        val_27 = 0;
        return (bool)val_27;
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
