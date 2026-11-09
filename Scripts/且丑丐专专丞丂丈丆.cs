using UnityEngine;
private sealed class Player_move_c.且丑丐专专丞丂丈丆 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private WeaponSounds 万丝丗丌与业业丂丈;
    public WeaponSounds 丕丌且下丟与丏丅业;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.且丑丐专专丞丂丈丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_42;
        Player_move_c val_43;
        int val_44;
        WeaponSounds val_45;
        WeaponSounds val_46;
        float val_47;
        var val_48;
        float val_49;
        float val_50;
        float val_53;
        float val_54;
        float val_55;
        float val_58;
        var val_59;
        var val_60;
        var val_61;
        WeaponSounds val_62;
        float val_64;
        val_42 = this;
        val_43 = this.丝且与丝丒丟万丁专;
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
        if(this.万丝丗丌与业业丂丈.isDoubleShot == false)
        {
            goto label_4;
        }
        
        val_43.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  this.丝且与丝丒丟万丁专.丕丕不且丝下东丟七, 丁丂世丑丟一丕丆一:  false);
        val_45 = this.万丝丗丌与业业丂丈;
        if(val_43 != null)
        {
            goto label_19;
        }
        
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.万丝丗丌与业业丂丈 == 0)
        {
            goto label_10;
        }
        
        bool val_2 = this.万丝丗丌与业业丂丈.丕丆万丝上丕下丙业();
        string val_5 = this.万丝丗丌与业业丂丈.gameObject.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        if(val_43 == null)
        {
            goto label_15;
        }
        
        if(val_2 == false)
        {
            goto label_16;
        }
        
        label_20:
        val_43.丏丗丐七丑丏丛七上(丒丘丏上丙丟丑丕丈:  val_5);
        goto label_17;
        label_4:
        if(val_43 == null)
        {
            goto label_18;
        }
        
        val_43.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        val_45 = this.万丝丗丌与业业丂丈;
        goto label_19;
        label_15:
        if(val_2 == true)
        {
            goto label_20;
        }
        
        label_16:
        val_43.且七丛丗下丟丕万业(丒丘丏上丙丟丑丕丈:  val_5);
        label_17:
        val_46 = this.万丝丗丌与业业丂丈;
        if(val_46 == null)
        {
            goto label_21;
        }
        
        val_47 = this.万丝丗丌与业业丂丈.radiusRoundMelee;
        goto label_22;
        label_21:
        val_47 = this.万丝丗丌与业业丂丈.radiusRoundMelee;
        if(this.万丝丗丌与业业丂丈 == null)
        {
            goto label_23;
        }
        
        val_46 = this.万丝丗丌与业业丂丈;
        label_22:
        label_85:
        float val_44 = val_46.丕丙丟丙丟丈丙丝东();
        丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_8 = null;
        val_48 = val_8;
        val_8 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑();
        val_47 = val_47 * this.万丝丗丌与业业丂丈.radiusRoundMelee;
        if(this.万丝丗丌与业业丂丈.healer != false)
        {
                丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_9 = null;
            val_48 = val_9;
            val_9 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  val_43, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  true, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true);
        }
        
        val_44 = val_47 * val_44;
        val_49 = val_44 * this.万丝丗丌与业业丂丈.丕丙丟丙丟丈丙丝东();
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_10 = val_9.世且一丄且上丄不一();
        val_50 = 1f;
        label_82:
        var val_45 = 0;
        val_45 = val_45 + 1;
        if(val_10.MoveNext() == false)
        {
            goto label_33;
        }
        
        var val_46 = 0;
        val_46 = val_46 + 1;
        T val_14 = val_10.Current;
        丅丙上七上一丐不下 val_15 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_14);
        UnityEngine.Vector3 val_16 = val_14.position;
        UnityEngine.Vector3 val_18 = this.丝且与丝丒丟万丁专.丒一丄丗丞丗丄丐丂.transform.position;
        val_53 = val_16.x;
        val_54 = val_16.y;
        val_55 = val_16.z;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_53, y = val_54, z = val_55}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        val_58 = val_19.x;
        if(this.万丝丗丌与业业丂丈.useAngleForRoundMelee != false)
        {
                UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_21 = this.丝且与丝丒丟万丁专.myPlayerTransform.forward;
            UnityEngine.Vector3 val_22 = this.丝且与丝丒丟万丁专.myPlayerTransform.forward;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_21.x, y:  val_22.z);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
            val_54 = val_24.y;
            val_55 = val_24.z;
            val_53 = this.万丝丗丌与业业丂丈.meleeAngle;
            val_50 = val_50;
            val_59 = val_49;
            val_58 = val_58;
            var val_27 = ((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_24.x, y = val_54, z = val_55}, to:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z})) < 0) ? 1 : 0;
        }
        else
        {
                val_60 = 1;
        }
        
        if((val_58 >= 0) || ((val_60 & 1) == 0))
        {
            goto label_82;
        }
        
        if((this.万丝丗丌与业业丂丈.healer == false) || (val_15 == null))
        {
            goto label_65;
        }
        
        val_61 = null;
        val_61 = null;
        if((丘丛丞且一丅丁丏丐.丗丏丌一一业且业丘(丛丌丕丐世丑丂七丂:  val_14, 上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_71;
        }
        
        label_65:
        UnityEngine.Vector3 val_31 = val_43.transform.position;
        bool val_33 = val_43.下丏一丏与三丝丙不(丌丝下丄业一丄不三:  this.万丝丗丌与业业丂丈, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, 丞下万上三丘上与专:  val_14.gameObject, 世丕与丙丄丙不丄丝:  false, 专世丂丆专业丌丈丈:  val_58, 丌东世丞世丆丄丑三:  val_50, 丏丟丘丈丁丌丗丗丕:  false, 丌丙与上且丁丝丌且:  0, 丄世上丘丄丌丞三专:  false);
        goto label_82;
        label_71:
        val_62 = this.万丝丗丌与业业丂丈;
        var val_47 = 0;
        val_47 = val_47 + 1;
        val_62 = 8;
        float val_40 = (val_43.丏七下丛世丁东丄业(丞下万上三丘上与专:  val_14.transform, 丌丝下丄业一丄不三:  val_62, 专世丂丆专业丌丈丈:  val_58, 世丕与丙丄丙不丄丝:  false, 丙丏与且丘东丆丁丑: out  false, 三丁丄丄丐丕丞丆丗:  0f)) * val_43.丝上丐万七上丈丞丐();
        val_40 = val_40 * this.万丝丗丌与业业丂丈.TeammateHealMultiplier;
        val_15.AddHealthFromWeaponOnline(上上丗丁丏丙丄丏七:  val_40, 丝三丛且丘不丌丙下:  this.万丝丗丌与业业丂丈.Tag);
        goto label_82;
        label_18:
        val_43.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        val_45 = this.万丝丗丌与业业丂丈;
        label_7:
        label_19:
        val_64 = val_43.丁丌一丗一世七不丅(丛丟三丘丛且业丈丏:  val_45);
        val_44 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_64);
        this.丗丏丅丕丆世丁专丟 = val_44;
        return (bool)val_44;
        label_23:
        if(this.万丝丗丌与业业丂丈 != null)
        {
            goto label_85;
        }
        
        goto label_85;
        label_33:
        val_43 = 0;
        val_42 = 0;
        if(val_10 == null)
        {
            
        }
        else
        {
                var val_48 = 0;
            val_48 = val_48 + 1;
            val_10.Dispose();
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
        
        label_10:
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.且丑丐专专丞丂丈丆 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.且丑丐专专丞丂丈丆();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .万丝丗丌与业业丂丈 = this.丕丌且下丟与丏丅业;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
