using UnityEngine;
private sealed class WeaponHealingReloadEffect.丘万丄丈丞丈丛丐丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponHealingReloadEffect 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponHealingReloadEffect.丘万丄丈丞丈丛丐丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_35;
        int val_36;
        float val_37;
        var val_38;
        var val_39;
        var val_43;
        var val_46;
        var val_47;
        val_35 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_36 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_36;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(S8 <= 0f)
        {
            goto label_4;
        }
        
        Player_move_c val_1 = 下丏丆下丙与丘上丁();
        val_36 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  S8 * val_1.不不丂丗丁丛丟丛丑);
        this.丗丏丅丕丆世丁专丟 = val_36;
        return (bool)val_36;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        label_4:
        val_38 = 0;
        goto label_9;
        label_8:
        val_38 = 1;
        label_9:
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                this.下丏丆下丙与丘上丁().丏丗丐七丑丏丛七上(丒丘丏上丙丟丑丕丈:  this);
        }
        
        if(val_6.丁丑丅丏丒不七上丁 == false)
        {
            goto label_15;
        }
        
        val_35 = this.下丏丆下丙与丘上丁().下丏丆下丙与丘上丁();
        if(val_35.丟丌下三七丁与丟丑() == false)
        {
            goto label_95;
        }
        
        label_15:
        Player_move_c val_9 = val_35.下丏丆下丙与丘上丁();
        if(val_9 == 0)
        {
                val_36 = 0;
            return (bool)val_36;
        }
        
        val_37 = this.丝且与丝丒丟万丁专.healtValue;
        val_35 = val_9.丂七一业下丈业丕丒;
        float val_11 = val_35.maxHealth;
        val_11 = (val_37 / 100f) * val_11;
        bool val_13 = val_9.丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  val_11, 丑东与丅丐丅丂丞业:  1);
        if(this.丝且与丝丒丟万丁专.healTeammate == false)
        {
            goto label_95;
        }
        
        float val_39 = val_35.丕丙丟丙丟丈丙丝东();
        val_37 = val_35.丕丙丟丙丟丈丙丝东();
        val_39 = (this.丝且与丝丒丟万丁专.healTeammateRadius * this.丝且与丝丒丟万丁专.healTeammateRadius) * val_39;
        丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_17 = null;
        val_39 = 0;
        val_17 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  val_9, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  true, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true);
        float val_18 = val_39 * val_37;
        val_35 = val_17.世且一丄且上丄不一();
        label_69:
        var val_40 = 0;
        val_40 = val_40 + 1;
        val_39 = 0;
        if(val_35.MoveNext() == false)
        {
            goto label_35;
        }
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_39 = 0;
        T val_23 = val_35.Current;
        UnityEngine.Vector3 val_24 = val_23.position;
        UnityEngine.Transform val_25 = val_9.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_26 = val_25.position;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        if(val_27.x >= 0)
        {
            goto label_69;
        }
        
        丅丙上七上一丐不下 val_29 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_23.transform);
        if(val_29 == null)
        {
            goto label_69;
        }
        
        Player_move_c val_30 = val_25.下丏丆下丙与丘上丁();
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_39 = 4;
        val_43 = public System.Boolean 丅丙上七上一丐不下::IsEnemyTo(Player_move_c 专丞上七七且丝七丗);
        if((val_29.IsEnemyTo(专丞上七七且丝七丗:  val_30)) == true)
        {
            goto label_69;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_43 = 2;
        var val_44 = 0;
        val_44 = val_44 + 1;
        val_43 = 8;
        float val_37 = this.丝且与丝丒丟万丁专.healTeammateValue / 100f;
        val_37 = val_37 * val_29.maxHealth;
        val_29.AddHealthFromWeaponOnline(上上丗丁丏丙丄丏七:  val_37, 丝三丛且丘不丌丙下:  val_30.三与丛丑且丐丈业丌());
        goto label_69;
        label_35:
        val_46 = 0;
        val_47 = 0;
        if(val_35 == null)
        {
            
        }
        else
        {
                var val_45 = 0;
            val_45 = val_45 + 1;
            val_35.Dispose();
        }
        
        label_95:
        val_36 = 0;
        this.丝且与丝丒丟万丁专.三世丛丛与下上三丁 = 0;
        return (bool)val_36;
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
