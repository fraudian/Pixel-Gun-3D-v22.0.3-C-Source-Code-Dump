using UnityEngine;
private sealed class WeaponReloadDisableGadgetsEffect.丙丌丘丌丘七丐丂丙 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public WeaponReloadDisableGadgetsEffect 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponReloadDisableGadgetsEffect.丙丌丘丌丘七丐丂丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_24;
        int val_25;
        var val_26;
        var val_29;
        var val_30;
        var val_31;
        val_24 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_25 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_25;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(S8 <= 0f)
        {
            goto label_4;
        }
        
        Player_move_c val_1 = 下丏丆下丙与丘上丁();
        val_25 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  S8 * val_1.不不丂丗丁丛丟丛丑);
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        label_4:
        val_26 = 0;
        goto label_9;
        label_8:
        val_26 = 1;
        label_9:
        if((System.String.IsNullOrEmpty(value:  0)) != true)
        {
                this.下丏丆下丙与丘上丁().丏丗丐七丑丏丛七上(丒丘丏上丙丟丑丕丈:  this);
        }
        
        if(val_6.丁丑丅丏丒不七上丁 == false)
        {
            goto label_15;
        }
        
        val_24 = this.下丏丆下丙与丘上丁().下丏丆下丙与丘上丁();
        if(val_24.丟丌下三七丁与丟丑() == false)
        {
            goto label_18;
        }
        
        label_15:
        val_24 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
        label_53:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(val_24.MoveNext() == false)
        {
            goto label_25;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        UnityEngine.Transform val_28 = val_24.Current;
        UnityEngine.Vector3 val_15 = val_28.position;
        UnityEngine.Transform val_17 = X21.下丏丆下丙与丘上丁().transform;
        UnityEngine.Vector3 val_18 = val_17.position;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        if(val_19.x >= 0)
        {
            goto label_53;
        }
        
        丅丙上七上一丐不下 val_20 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_28);
        val_29 = 0;
        if(( == 0) || ((IsEnemyTo(专丞上七七且丝七丗:  val_17.下丏丆下丙与丘上丁())) == false))
        {
            goto label_53;
        }
        
        (丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_20 : 0 + 24.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  val_22.丑丅三丗丌丞三丘丂, 三丛丄一东丑丁且业:  3, 丘万丟丕与专丁三丘:  this.丝且与丝丒丟万丁专.gadgetDisableTime * this.丝且与丝丒丟万丁专.丆丝业且丌丕丕一一, 丆丅丅丂下丏丏丞丂:  0);
        goto label_53;
        label_25:
        val_30 = 0;
        val_31 = 0;
        if(val_24 == null)
        {
            
        }
        else
        {
                var val_29 = 0;
            val_29 = val_29 + 1;
            val_24.Dispose();
        }
        
        val_25 = 0;
        if( != 1)
        {
                return (bool)val_25;
        }
        
        if( == false)
        {
                return (bool)val_25;
        }
        
        label_18:
        val_25 = 0;
        return (bool)val_25;
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
        this = new WeaponReloadDisableGadgetsEffect.丙丌丘丌丘七丐丂丙();
        return (System.Collections.Generic.IEnumerator<System.Object>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
