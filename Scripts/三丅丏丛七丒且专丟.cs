using UnityEngine;
private sealed class DamageWeaponCollider.三丅丏丛七丒且专丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public DamageWeaponCollider 丝且与丝丒丟万丁专;
    public UnityEngine.Collider 丐且丟丂且专丄丕三;
    private UnityEngine.GameObject 上丐丁下丆丑且丗东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DamageWeaponCollider.三丅丏丛七丒且专丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_35;
        UnityEngine.GameObject val_36;
        var val_37;
        UnityEngine.GameObject val_38;
        var val_39;
        var val_40;
        var val_43;
        var val_44;
        var val_45;
        WeaponManager val_46;
        val_35 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.isOwner == false)
        {
                return false;
        }
        
        UnityEngine.Debug.LogError(message:  "Is owner hit coroutine completing on " + this.丝且与丝丒丟万丁专.gameObject.name);
        this.上丐丁下丆丑且丗东 = 0;
        if((丞东丑专丛丆丄丝世.业三下与万丑丗业专<FirstPersonControlSharp>(丝三丁东丈丒世丅业:  this.丐且丟丂且专丄丕三.gameObject)) == 0)
        {
            goto label_14;
        }
        
        val_36 = this.丐且丟丂且专丄丕三.gameObject;
        val_37 = static FirstPersonControlSharp 丞东丑专丛丆丄丝世::业三下与万丑丗业专<FirstPersonControlSharp>(UnityEngine.GameObject 丝三丁东丈丒世丅业);
        goto label_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_38 = this.上丐丁下丆丑且丗东;
        if(val_38 == 0)
        {
                return false;
        }
        
        val_38 = this.丝且与丝丒丟万丁专.tempDamagingOwners;
        if((val_38.Contains(item:  this.上丐丁下丆丑且丗东)) == false)
        {
                return false;
        }
        
        val_35 = this.上丐丁下丆丑且丗东;
        bool val_13 = this.丝且与丝丒丟万丁专.tempDamagingOwners.Remove(item:  val_35);
        return false;
        label_14:
        if((丞东丑专丛丆丄丝世.业三下与万丑丗业专<DevDummyController>(丝三丁东丈丒世丅业:  this.丐且丟丂且专丄丕三.gameObject)) == 0)
        {
            goto label_27;
        }
        
        val_36 = this.丐且丟丂且专丄丕三.gameObject;
        val_37 = static DevDummyController 丞东丑专丛丆丄丝世::业三下与万丑丗业专<DevDummyController>(UnityEngine.GameObject 丝三丁东丈丒世丅业);
        label_18:
        DevDummyController val_15 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<DevDummyController>(丝三丁东丈丒世丅业:  val_36);
        this.上丐丁下丆丑且丗东 = 0.gameObject;
        label_27:
        val_38 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  this.丐且丟丂且专丄丕三);
        val_39 = 0;
        if(this.上丐丁下丆丑且丗东 != 0)
        {
                val_39 = public System.Boolean System.Collections.Generic.List<UnityEngine.GameObject>::Contains(UnityEngine.GameObject item);
            if((this.丝且与丝丒丟万丁专.tempDamagingOwners.Contains(item:  this.上丐丁下丆丑且丗东)) != false)
        {
                return false;
        }
        
        }
        
        if(val_38 == null)
        {
            goto label_80;
        }
        
        val_40 = null;
        val_40 = null;
        var val_38 = 0;
        val_38 = val_38 + 1;
        val_39 = 4;
        if((val_38.IsEnemyTo(专丞上七七且丝七丗:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_80;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        val_43 = null;
        val_43 = null;
        if(val_38.transform.gameObject == WeaponManager.丟丗丄业丘丗业丗七.myPlayer)
        {
            goto label_80;
        }
        
        if(this.丝且与丝丒丟万丁专.isExplosion != false)
        {
                if(this.丝且与丝丒丟万丁专.isChargeOrbital == false)
        {
            goto label_80;
        }
        
        }
        
        if(this.上丐丁下丆丑且丗东 != 0)
        {
                this.丝且与丝丒丟万丁专.tempDamagingOwners.Add(item:  this.上丐丁下丆丑且丗东);
        }
        
        if(this.丝且与丝丒丟万丁专.isExplosion != false)
        {
                val_44 = 0;
        }
        
        val_45 = null;
        val_45 = null;
        val_46 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_68;
        }
        
        val_46 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_46 == null)
        {
            goto label_69;
        }
        
        label_68:
        UnityEngine.Vector3 val_31 = this.丝且与丝丒丟万丁专.transform.position;
        var val_40 = 0;
        val_40 = val_40 + 1;
        bool val_35 = 下丏一丏与三丝丙不(丌丝下丄业一丄不三:  丙不丅丕三丂业东丕(), 专不丑且不丏东丟丅:  this.丐且丟丂且专丄丕三, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, 丞下万上三丘上与专:  val_38.transform.gameObject, 世丕与丙丄丙不丄丝:  ((HitBox.丁丞与丗不丈丟下丏(且丙与丏下丅丐世丑:  this.丐且丟丂且专丄丕三)) == 2) ? 1 : 0, 专世丂丆专业丌丈丈:  0f, 丌东世丞世丆丄丑三:  1f, 丏丟丘丈丁丌丗丗丕:  false, 丌丙与上且丁丝丌且:  0, 丄世上丘丄丌丞三专:  false);
        if((丘丛丞且一丅丁丏丐.丂丅丐世上不丐丏丙(且丙与丏下丅丐世丑:  this.丐且丟丂且专丄丕三)) != null)
        {
                this.丝且与丝丒丟万丁专.东丂业不世丗东不丝.enabled = false;
        }
        
        label_80:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.不丆且不丆丗一丘不);
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
        label_69:
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
