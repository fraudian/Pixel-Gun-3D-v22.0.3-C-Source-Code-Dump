using UnityEngine;
private sealed class WeaponReloadDamageEffect.且上丙世丅世丕丆丒 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public WeaponReloadDamageEffect 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponReloadDamageEffect.且上丙世丅世丕丆丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WeaponReloadDamageEffect val_50;
        int val_51;
        float val_52;
        var val_53;
        var val_54;
        float val_55;
        var val_56;
        var val_57;
        float val_59;
        UnityEngine.Collider val_60;
        var val_61;
        float val_63;
        float val_64;
        float val_65;
        var val_66;
        var val_69;
        var val_72;
        var val_73;
        val_50 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_51 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_51;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(S8 <= 0f)
        {
            goto label_4;
        }
        
        Player_move_c val_1 = val_50.下丏丆下丙与丘上丁();
        UnityEngine.WaitForSeconds val_3 = null;
        val_50 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  S8 * val_1.不不丂丗丁丛丟丛丑);
        val_51 = 1;
        this.丒上七丌业七丟与丐 = val_50;
        this.丗丏丅丕丆世丁专丟 = val_51;
        return (bool)val_51;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_50 == null)
        {
            goto label_8;
        }
        
        label_4:
        val_53 = 0;
        goto label_9;
        label_8:
        val_53 = 1;
        label_9:
        if(0 != 0)
        {
                if((System.String.op_Inequality(a:  0, b:  System.String.alignConst)) != false)
        {
                val_54 = this.下丏丆下丙与丘上丁();
            val_54.丏丗丐七丑丏丛七上(丒丘丏上丙丟丑丕丈:  this);
        }
        
        }
        
        if(val_6.丁丑丅丏丒不七上丁 != false)
        {
                if(this.下丏丆下丙与丘上丁().下丏丆下丙与丘上丁().丟丌下三七丁与丟丑() == false)
        {
            goto label_148;
        }
        
        }
        
        if((GameConnect.丙丘不世专且万丄丐() != false) && (TimeGameController.丄丞丁丈与业上丞丟 != 0))
        {
                if(((TimeGameController.丄丞丁丈与业上丞丟 != 0) && (ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory != 1)) && (ZombiManager.丟丗丄业丘丗业丗七.timeGame != (4.94065645841247E-324)))
        {
                if((ZombiManager.丟丗丄业丘丗业丗七.timeGame - 1) != ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory)
        {
            goto label_35;
        }
        
        }
        
        }
        
        val_55 = this.丝且与丝丒丟万丁专.damageRadius;
        float val_54 = ZombiManager.丟丗丄业丘丗业丗七.timeGame.丕丙丟丙丟丈丙丝东();
        val_52 = ZombiManager.丟丗丄业丘丗业丗七.timeGame.丕丙丟丙丟丈丙丝东();
        val_54 = (val_55 * val_55) * val_54;
        float val_17 = val_54 * val_52;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_18 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
        val_56 = 1152921504691191808;
        val_57 = 0;
        goto label_91;
        label_103:
        var val_55 = 0;
        val_55 = val_55 + 1;
        T val_20 = val_18.Current;
        UnityEngine.Vector3 val_21 = val_20.position;
        val_55 = val_21.z;
        UnityEngine.Transform val_23 = ZombiManager.丟丗丄业丘丗业丗七.下丏丆下丙与丘上丁().transform;
        UnityEngine.Vector3 val_24 = val_23.position;
        val_59 = val_24.y;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_55}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_59, z = val_24.z});
        val_52 = val_25.x;
        if(val_52 >= 0)
        {
            goto label_91;
        }
        
        val_60 = 0;
        float val_26 = 万世专丘且万世七丒.丝丛丈丟丅一上世丞(丌丝下丄业一丄不三:  val_23, 丞下万上三丘上与专:  val_20);
        float val_56 = this.丝且与丝丒丟万丁专.damageMultiplier;
        val_26 = val_26 * val_56;
        val_56 = (val_23.丌丆丈丈丌不丈丄丗() != true) ? (val_26 * 0.1f) : (val_26);
        if(val_23 == null)
        {
            goto label_56;
        }
        
        goto label_57;
        label_56:
        if(null == 0)
        {
            goto label_58;
        }
        
        val_61 = val_56;
        label_57:
        label_90:
        float val_30 = 丕丙丟丙丟丈丙丝东();
        float val_31 = val_24.x * 1152921504691191808.__il2cppRuntimeField_16C;
        val_31 = val_31 * 丕丙丟丙丟丈丙丝东();
        val_30 = val_31 * val_30;
        val_63 = val_56 * 0.7f;
        val_30 = val_52 / val_30;
        val_64 = 1f;
        val_30 = val_64 - val_30;
        val_65 = (val_56 - val_63) * val_30;
        val_52 = val_63 + val_65;
        if(this.丝且与丝丒丟万丁专.isPoison != false)
        {
                this.丝且与丝丒丟万丁专.poisonSettings.weaponName = 三与丛丑且丐丈业丌();
            val_66 = null;
            val_66 = null;
            UnityEngine.Vector3 val_36 = val_50.transform.position;
            val_55 = val_36.y;
            val_60 = 0;
            val_65 = val_36.x;
            val_63 = val_55;
            val_64 = val_36.z;
            丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_20.gameObject, 专不丑且不丏东丟丅:  val_60, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_65, y = val_63, z = val_64}, 丒下世丝丂万丑丏下:  val_52, 丌丒万丂丈不且丈丄:  this.丝且与丝丒丟万丁专.poisonSettings);
        }
        
        丅丙上七上一丐不下 val_38 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_20.transform);
        val_56 = val_56;
        if(val_38 == null)
        {
            goto label_91;
        }
        
        Player_move_c val_39 = 下丏丆下丙与丘上丁();
        var val_57 = 0;
        val_57 = val_57 + 1;
        val_60 = 4;
        goto label_77;
        label_58:
        if(val_23 == null)
        {
            goto label_90;
        }
        
        goto label_90;
        label_77:
        if((val_38.IsEnemyTo(专丞上七七且丝七丗:  val_39)) != false)
        {
                UnityEngine.Transform val_43 = val_50.transform;
            UnityEngine.Vector3 val_44 = val_43.position;
            val_55 = val_44.y;
            val_39.下丏丆下丙与丘上丁().丁丈世丗下丟丒一丏(丂丈丙且丈丗三丆丕:  val_38, 丞丈专下丈专业三丞:  val_52, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_44.x, y = val_55, z = val_44.z}, 丝三丛且丘不丌丙下:  val_43.三与丛丑且丐丈业丌(), 东丏业丞丞业下丄世:  this.丝且与丝丒丟万丁专.typeDead, 丐丟丘世丁三丕专专:  24);
            val_56 = val_56;
            var val_58 = 0;
            val_58 = val_58 + 1;
            if(val_38.isLivingTarget != false)
        {
                if((0 & 1) != 0)
        {
                val_69 = 1;
        }
        else
        {
                var val_59 = 0;
            val_59 = val_59 + 1;
            val_69 = val_38.IsDead();
        }
        
            var val_50 = (val_69 == true) ? 1 : 0;
            val_57 = 1;
        }
        
        }
        
        label_91:
        var val_60 = 0;
        val_60 = val_60 + 1;
        if(val_18.MoveNext() == true)
        {
            goto label_103;
        }
        
        val_72 = 0;
        val_54 = 0;
        if(val_18 != null)
        {
            goto label_104;
        }
        
        goto label_141;
        label_35:
        val_51 = 0;
        return (bool)val_51;
        label_104:
        double val_63 = ZombiManager.丟丗丄业丘丗业丗七.timeGame;
        if((ZombiManager.丟丗丄业丘丗业丗七.timeGame + 286) == 0)
        {
            goto label_145;
        }
        
        var val_61 = ZombiManager.丟丗丄业丘丗业丗七.timeGame + 176;
        var val_62 = 0;
        val_61 = val_61 + 8;
        label_144:
        if(((ZombiManager.丟丗丄业丘丗业丗七.timeGame + 176 + 8) + -8) == null)
        {
            goto label_143;
        }
        
        val_62 = val_62 + 1;
        val_61 = val_61 + 16;
        if(val_62 < (ZombiManager.丟丗丄业丘丗业丗七.timeGame + 286))
        {
            goto label_144;
        }
        
        goto label_145;
        label_143:
        val_63 = val_63 + (((ZombiManager.丟丗丄业丘丗业丗七.timeGame + 176 + 8)) << 4);
        val_73 = val_63 + 296;
        label_145:
        ZombiManager.丟丗丄业丘丗业丗七.timeGame.Dispose();
        label_141:
        if((W28 & 1) != 0)
        {
                丛丐丒上丒丘丆丕与(万丐七下丂丂丛世丞:  0 & 1, 且世与七东丕丈丗丁:  true, 世丕与丙丄丙不丄丝:  false);
        }
        
        label_148:
        val_51 = 0;
        this.丝且与丝丒丟万丁专.三世丛丛与下上三丁 = 0;
        return (bool)val_51;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Object>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new WeaponReloadDamageEffect.且上丙世丅世丕丆丒();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
