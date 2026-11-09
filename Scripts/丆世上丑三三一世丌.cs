using UnityEngine;
private sealed class Player_move_c.丆世上丑三三一世丌 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Player_move_c 丝且与丝丒丟万丁专;
    private WeaponSounds 丌丝下丄业一丄不三;
    public WeaponSounds 丝一下丁专丗东丅丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丆世上丑三三一世丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WeaponSounds val_39;
        Player_move_c val_40;
        int val_41;
        WeaponSounds val_42;
        var val_43;
        WeaponSounds val_46;
        float val_47;
        WeaponSounds val_48;
        float val_49;
        float val_50;
        WeaponSounds val_51;
        var val_52;
        WeaponSounds val_53;
        var val_55;
        val_40 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_41 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_41;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丌丝下丄业一丄不三.isDoubleShot == false)
        {
            goto label_4;
        }
        
        val_40.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  this.丝且与丝丒丟万丁专.丕丕不且丝下东丟七, 丁丂世丑丟一丕丆一:  false);
        val_42 = this.丌丝下丄业一丄不三;
        if(val_40 != null)
        {
            goto label_19;
        }
        
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_39 = this.丌丝下丄业一丄不三;
        if(val_39 == 0)
        {
            goto label_10;
        }
        
        bool val_2 = this.丌丝下丄业一丄不三.丕丆万丝上丕下丙业();
        string val_5 = this.丌丝下丄业一丄不三.gameObject.name.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst);
        if(val_40 == null)
        {
            goto label_15;
        }
        
        if(val_2 == false)
        {
            goto label_16;
        }
        
        label_20:
        val_40.丏丗丐七丑丏丛七上(丒丘丏上丙丟丑丕丈:  val_5);
        goto label_17;
        label_4:
        if(val_40 == null)
        {
            goto label_18;
        }
        
        val_40.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        val_42 = this.丌丝下丄业一丄不三;
        goto label_19;
        label_15:
        if(val_2 == true)
        {
            goto label_20;
        }
        
        label_16:
        val_40.且七丛丗下丟丕万业(丒丘丏上丙丟丑丕丈:  val_5);
        label_17:
        丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_6 = null;
        val_43 = val_6;
        val_6 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑();
        if(this.丌丝下丄业一丄不三.healer != false)
        {
                丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_7 = null;
            val_43 = val_7;
            val_7 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  val_40, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  true, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true);
        }
        
        val_39 = val_7.世且一丄且上丄不一();
        label_86:
        var val_41 = 0;
        val_41 = val_41 + 1;
        if(val_39.MoveNext() == false)
        {
            goto label_29;
        }
        
        var val_42 = 0;
        val_42 = val_42 + 1;
        T val_12 = val_39.Current;
        丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_12);
        UnityEngine.Vector3 val_14 = val_12.position;
        UnityEngine.Vector3 val_16 = this.丝且与丝丒丟万丁专.丒一丄丗丞丗丄丐丂.transform.position;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        val_46 = this.丌丝下丄业一丄不三;
        if(val_46 != null)
        {
                val_47 = this.丌丝下丄业一丄不三.sectorsAOERadiusSectorsAoE;
        }
        else
        {
                val_47 = this.丌丝下丄业一丄不三.sectorsAOERadiusSectorsAoE;
            if(this.丌丝下丄业一丄不三 != null)
        {
                val_46 = this.丌丝下丄业一丄不三;
        }
        else
        {
                val_46 = 0;
        }
        
        }
        
        float val_43 = 6.768272E-43f;
        val_43 = val_47 * val_43;
        if(val_17.x > val_43)
        {
            goto label_86;
        }
        
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_19 = this.丝且与丝丒丟万丁专.myPlayerTransform.forward;
        UnityEngine.Vector3 val_20 = this.丝且与丝丒丟万丁专.myPlayerTransform.forward;
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_19.x, y:  val_20.z);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
        float val_24 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, to:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        val_48 = this.丌丝下丄业一丄不三;
        if(this.丌丝下丄业一丄不三 == null)
        {
                val_48 = this.丌丝下丄业一丄不三;
        }
        
        val_49 = this.丌丝下丄业一丄不三.sectorsAOEAngleFront;
        if(val_24 < 0)
        {
                val_50 = this.丌丝下丄业一丄不三.sectorsAOEDamageMultiplierFront;
        }
        else
        {
                val_51 = val_48;
            if(val_48 == null)
        {
                val_51 = this.丌丝下丄业一丄不三;
        }
        
            val_49 = 180f - this.丌丝下丄业一丄不三.sectorsAOEAngleBack;
            if(val_24 > val_49)
        {
                val_50 = this.丌丝下丄业一丄不三.sectorsAOEDamageMultiplierBack;
        }
        else
        {
                val_50 = this.丌丝下丄业一丄不三.sectorsAOEDamageMultiplierSide;
        }
        
        }
        
        if((this.丌丝下丄业一丄不三.healer == false) || (val_13 == null))
        {
            goto label_69;
        }
        
        val_52 = null;
        val_52 = null;
        if((丘丛丞且一丅丁丏丐.丗丏丌一一业且业丘(丛丌丕丐世丑丂七丂:  val_12, 上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) == false)
        {
            goto label_75;
        }
        
        label_69:
        UnityEngine.Vector3 val_28 = val_40.transform.position;
        bool val_30 = val_40.下丏一丏与三丝丙不(丌丝下丄业一丄不三:  this.丌丝下丄业一丄不三, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, 丞下万上三丘上与专:  val_12.gameObject, 世丕与丙丄丙不丄丝:  false, 专世丂丆专业丌丈丈:  val_17.x, 丌东世丞世丆丄丑三:  val_50, 丏丟丘丈丁丌丗丗丕:  false, 丌丙与上且丁丝丌且:  0, 丄世上丘丄丌丞三专:  false);
        goto label_86;
        label_75:
        val_53 = this.丌丝下丄业一丄不三;
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_53 = 8;
        float val_37 = (val_40.丏七下丛世丁东丄业(丞下万上三丘上与专:  val_12.transform, 丌丝下丄业一丄不三:  val_53, 专世丂丆专业丌丈丈:  val_17.x, 世丕与丙丄丙不丄丝:  false, 丙丏与且丘东丆丁丑: out  false, 三丁丄丄丐丕丞丆丗:  0f)) * val_40.丝上丐万七上丈丞丐();
        val_37 = val_37 * this.丌丝下丄业一丄不三.TeammateHealMultiplier;
        val_13.AddHealthFromWeaponOnline(上上丗丁丏丙丄丏七:  val_37, 丝三丛且丘不丌丙下:  this.丌丝下丄业一丄不三.Tag);
        goto label_86;
        label_18:
        val_40.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        val_42 = this.丌丝下丄业一丄不三;
        label_7:
        label_19:
        UnityEngine.WaitForSeconds val_39 = null;
        val_39 = val_39;
        val_39 = new UnityEngine.WaitForSeconds(seconds:  val_40.丁丌一丗一世七不丅(丛丟三丘丛且业丈丏:  val_42));
        val_41 = 1;
        this.丒上七丌业七丟与丐 = val_39;
        this.丗丏丅丕丆世丁专丟 = val_41;
        return (bool)val_41;
        label_29:
        val_40 = 0;
        val_55 = 0;
        if(val_39 == null)
        {
            
        }
        else
        {
                var val_45 = 0;
            val_45 = val_45 + 1;
            val_39.Dispose();
        }
        
        val_41 = 0;
        if( != 1)
        {
                return (bool)val_41;
        }
        
        if( == false)
        {
                return (bool)val_41;
        }
        
        label_10:
        val_41 = 0;
        return (bool)val_41;
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
                Player_move_c.丆世上丑三三一世丌 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丆世上丑三三一世丌();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丌丝下丄业一丄不三 = this.丝一下丁专丗东丅丒;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
