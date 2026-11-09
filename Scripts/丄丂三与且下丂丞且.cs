using UnityEngine;
private sealed class WeaponAoeUltimateAbility.丄丂三与且下丂丞且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponAoeUltimateAbility 丝且与丝丒丟万丁专;
    public WeaponSounds 丌丝下丄业一丄不三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponAoeUltimateAbility.丄丂三与且下丂丞且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_43;
        int val_44;
        float val_45;
        var val_46;
        var val_47;
        int val_48;
        float val_51;
        float val_52;
        float val_53;
        float val_54;
        float val_55;
        float val_56;
        var val_57;
        float val_58;
        var val_59;
        val_43 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_44 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_44;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_45 = this.丝且与丝丒丟万丁专.startDelay;
        if(val_45 <= 0f)
        {
            goto label_4;
        }
        
        val_44 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_45);
        this.丗丏丅丕丆世丁专丟 = val_44;
        return (bool)val_44;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        label_4:
        this.丝且与丝丒丟万丁专.丌丕专且丐丟上丛丂();
        val_46 = 0;
        val_47 = this.丝且与丝丒丟万丁专;
        goto label_7;
        label_6:
        0.丌丕专且丐丟上丛丂();
        val_47 = 0;
        val_46 = 1;
        label_7:
        if(65536 != 0)
        {
                65536.SetActive(value:  false);
        }
        
        if(((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.onGroundEffectName)) != true) && (this.丝且与丝丒丟万丁专.isEnemyGroundEffectOnUltimate != true))
        {
                this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().且七丛丗下丟丕万业(丒丘丏上丙丟丑丕丈:  this.丝且与丝丒丟万丁专.onGroundEffectName);
        }
        
        Player_move_c val_5 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        if(val_5.丁丑丅丏丒不七上丁 == false)
        {
            goto label_20;
        }
        
        val_48 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁();
        if(val_48.丟丌下三七丁与丟丑() == false)
        {
            goto label_39;
        }
        
        label_20:
        if(((GameConnect.丙丘不世专且万丄丐() == false) || (TimeGameController.丄丞丁丈与业上丞丟 == 0)) || (((this.丌丝下丄业一丄不三 == 0) || (ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory == 1)) || (this.丌丝下丄业一丄不三.categoryNabor == 1)))
        {
            goto label_36;
        }
        
        val_48 = this.丌丝下丄业一丄不三.categoryNabor;
        if((val_48 - 1) != ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory)
        {
            goto label_39;
        }
        
        label_36:
        float val_13 = this.丝且与丝丒丟万丁专.damageRadius * this.丝且与丝丒丟万丁专.damageRadius;
        val_45 = 0.7f;
        val_48 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
        label_96:
        var val_44 = 0;
        val_44 = val_44 + 1;
        if(val_48.MoveNext() == false)
        {
            goto label_46;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        T val_18 = val_48.Current;
        UnityEngine.Vector3 val_19 = val_18.position;
        UnityEngine.Vector3 val_22 = this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().transform.position;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        float val_46 = val_23.x;
        if(val_46 >= 0)
        {
            goto label_96;
        }
        
        float val_24 = 万世专丘且万世七丒.丝丛丈丟丅一上世丞(丌丝下丄业一丄不三:  this.丌丝下丄业一丄不三, 丞下万上三丘上与专:  val_18);
        if(val_46 == 0)
        {
            goto label_61;
        }
        
        val_51 = 4.656534E-34f;
        val_52 = this.丝且与丝丒丟万丁专.damageRadius;
        val_53 = this.丝且与丝丒丟万丁专.damageRadius;
        if(val_46 != 0)
        {
            goto label_62;
        }
        
        goto label_64;
        label_61:
        val_53 = this.丝且与丝丒丟万丁专.damageRadius;
        val_51 = 4.656534E-34f;
        val_52 = val_53;
        if(val_46 == 0)
        {
            goto label_64;
        }
        
        label_62:
        label_64:
        val_24 = val_24 * val_51;
        float val_25 = val_52 * val_53;
        val_54 = val_24 * val_45;
        val_25 = val_46 / val_25;
        val_24 = val_24 - val_54;
        val_55 = 1f - val_25;
        val_56 = val_24 * val_55;
        val_46 = val_54 + val_56;
        if(this.丝且与丝丒丟万丁专.isPoison != false)
        {
                this.丝且与丝丒丟万丁专.poisonSettings.weaponName = this.丌丝下丄业一丄不三.三与丛丑且丐丈业丌();
            val_57 = null;
            val_57 = null;
            UnityEngine.Vector3 val_29 = this.丝且与丝丒丟万丁专.transform.position;
            val_56 = val_29.x;
            val_55 = val_29.y;
            val_54 = val_29.z;
            丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_18.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_56, y = val_55, z = val_54}, 丒下世丝丂万丑丏下:  val_46, 丌丒万丂丈不且丈丄:  this.丝且与丝丒丟万丁专.poisonSettings);
        }
        
        val_58 = val_46 * 丘丐丘万丌丟丞下丝.三一丑丂丞丈丞丝丆();
        if(this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁() != 0)
        {
                val_58 = val_58 * this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().charDmgCoef;
        }
        
        UnityEngine.Vector3 val_38 = this.丝且与丝丒丟万丁专.transform.position;
        this.丌丝下丄业一丄不三.下丏丆下丙与丘上丁().丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  val_18.gameObject, 丞丈专下丈专业三丞:  val_58, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, 丝三丛且丘不丌丙下:  this.丌丝下丄业一丄不三.三与丛丑且丐丈业丌(), 东丏业丞丞业下丄世:  this.丝且与丝丒丟万丁专.typeDead, 丐丟丘世丁三丕专专:  24);
        if((this.丝且与丝丒丟万丁专.isEnemyGroundEffectOnUltimate == false) || ((丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_18)) == null))
        {
            goto label_96;
        }
        
        val_18.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  val_18 + 952.owner, 丂丛丆万丁丆下三丘:  this.丌丝下丄业一丄不三.三与丛丑且丐丈业丌(), 三丛丄一东丑丁且业:  29, 丘万丟丕与专丁三丘:  0f, 丆丅丅丂下丏丏丞丂:  0);
        val_18.丂下丕三丒丅丆丅丆(丏不丂丆且三丞丆丏:  29, 丂三丟丂丈丐丆丗丟:  10f);
        goto label_96;
        label_46:
        val_59 = 0;
        val_43 = 0;
        if(val_48 == null)
        {
            
        }
        else
        {
                var val_47 = 0;
            val_47 = val_47 + 1;
            val_48.Dispose();
        }
        
        val_44 = 0;
        if( != 1)
        {
                return (bool)val_44;
        }
        
        if( == false)
        {
                return (bool)val_44;
        }
        
        label_39:
        val_44 = 0;
        return (bool)val_44;
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
