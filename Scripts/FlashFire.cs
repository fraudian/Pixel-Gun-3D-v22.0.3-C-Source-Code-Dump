using UnityEngine;
public class FlashFire : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject gunFlashObj;
    public float timeFireAction;
    private float 且丏东下丁丄丞万丆;
    public WeaponSounds ws;
    
    // Methods
    private void Start()
    {
        FlashFire val_30;
        var val_31;
        var val_32;
        var val_33;
        bool val_34;
        var val_35;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_50;
        var val_51;
        val_30 = this;
        if(this.gunFlashObj != 0)
        {
            goto label_109;
        }
        
        if((this.gameObject.name.Equals(value:  "GunFlash")) != false)
        {
                val_32 = 1;
            this.gunFlashObj = this.gameObject;
        }
        else
        {
                val_32 = 0;
        }
        
        System.Collections.IEnumerator val_7 = this.transform.GetEnumerator();
        val_33 = 1152921504621703168;
        val_34 = 0;
        val_35 = 0;
        label_77:
        var val_34 = 0;
        val_34 = val_34 + 1;
        if(val_7.MoveNext() == false)
        {
            goto label_78;
        }
        
        var val_35 = 0;
        val_35 = val_35 + 1;
        val_38 = val_7.Current;
        if(val_38 != null)
        {
                val_38 = 0;
        }
        
        if((val_32 & 1) != 0)
        {
            goto label_78;
        }
        
        if((val_38.gameObject.name.Equals(value:  "BulletSpawnPoint")) == false)
        {
            goto label_27;
        }
        
        System.Collections.IEnumerator val_17 = val_38.GetEnumerator();
        goto label_49;
        label_27:
        val_39 = 0;
        if(val_38 != 0)
        {
            goto label_73;
        }
        
        goto label_31;
        label_49:
        var val_36 = 0;
        val_36 = val_36 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_38;
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        object val_21 = val_17.Current;
        val_40 = 1152921504686346240;
        val_41 = val_33;
        val_42 = val_35;
        val_43 = 1;
        val_33 = val_41;
        if((0.gameObject.name.Equals(value:  "GunFlash")) == false)
        {
            goto label_49;
        }
        
        val_35 = val_42 + 1;
        val_39 = 1;
        this.gunFlashObj = 0.gameObject;
        mem2[0] = 246;
        goto label_52;
        label_38:
        val_35 = val_35 + 1;
        val_39 = 0;
        mem2[0] = 246;
        label_52:
        if(val_17 != null)
        {
                var val_38 = 0;
            val_38 = val_38 + 1;
            val_17.Dispose();
        }
        
        if((val_35 == 1) || ((-54038576 + ((val_35 + 1)) << 2) != 246))
        {
            goto label_68;
        }
        
        if((val_35 & 2147483648) != 0)
        {
            goto label_69;
        }
        
        val_35 = val_35 - 1;
        if(( & 1) == 0)
        {
            goto label_77;
        }
        
        goto label_78;
        label_68:
        val_34 = 0;
        if(val_38 != 0)
        {
            goto label_73;
        }
        
        label_31:
        label_73:
        if((val_38.gameObject.name.Equals(value:  "GunFlash")) == true)
        {
            goto label_76;
        }
        
        label_69:
        if( == 0)
        {
            goto label_77;
        }
        
        goto label_78;
        label_76:
        this.gunFlashObj = val_38.gameObject;
        label_78:
        val_50 = -54038576;
        val_31 = 0;
        val_51 = val_35 + 1;
        mem2[0] = 284;
        if(val_7 != null)
        {
                var val_39 = 0;
            val_39 = val_39 + 1;
            val_7.Dispose();
        }
        
        if(val_51 == 1)
        {
            goto label_103;
        }
        
        val_30 = val_30;
        if(( == null) || ((val_50 + (((val_35 + 1) + 1)) << 2) == 284))
        {
            goto label_109;
        }
        
        label_108:
        label_109:
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  this.gunFlashObj, 丙丗七丕且与丞丘丁:  false);
        return;
        label_103:
        if( != null)
        {
            goto label_108;
        }
        
        goto label_109;
    }
    private void Update()
    {
        if(this.且丏东下丁丄丞万丆 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.且丏东下丁丄丞万丆 - val_1;
        this.且丏东下丁丄丞万丆 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  this.gunFlashObj, 丙丗七丕且与丞丘丁:  false);
    }
    public void StartGunFlash()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  this.gunFlashObj, 丙丗七丕且与丞丘丁:  true);
        this.且丏东下丁丄丞万丆 = this.timeFireAction;
    }
    public void StopGunFlash(bool 丈且丕东下下丄一七 = False)
    {
        if(this.gameObject.activeInHierarchy != true)
        {
                if(丈且丕东下下丄一七 == false)
        {
                return;
        }
        
        }
        
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  this.gunFlashObj, 丙丗七丕且与丞丘丁:  false);
        this.且丏东下丁丄丞万丆 = 0f;
    }
    public void StartGunFlashDelayed(float 丕丕世且下一与丝与)
    {
        this.Invoke(methodName:  "StartGunFlash", time:  丕丕世且下一与丝与);
    }
    internal void 丙七丏七丐丐丄丁一(Player_move_c 丛丁东东丑丟丞丁丟)
    {
        WeaponSounds val_5 = this.ws;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = this.ws;
        if(this.ws.railgun == false)
        {
                return;
        }
        
        val_5 = this.gunFlashObj;
        if(val_5 == 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.且三丆丌丁世丘三丝(丛丁东东丑丟丞丁丟:  丛丁东东丑丟丞丁丟));
    }
    internal System.Collections.IEnumerator 且三丆丌丁世丘三丝(Player_move_c 丛丁东东丑丟丞丁丟)
    {
        FlashFire.丒三丗丏丏丆业丑丐 val_1 = new FlashFire.丒三丗丏丏丆业丑丐();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丛丁东东丑丟丞丁丟 = 丛丁东东丑丟丞丁丟;
        return (System.Collections.IEnumerator)val_1;
    }
    public FlashFire()
    {
        this.timeFireAction = 0.2f;
    }

}
