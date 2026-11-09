using UnityEngine;
private sealed class VehicleController.丛丐世业且丘丙丝丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丞丗且下世丐业丌丙;
    public VehicleController 丝且与丝丒丟万丁专;
    public float 与丞丗丟七下丐丛且;
    public int 不万上丕丅丏丆丄丝;
    private bool 丝丐与丆丑丅不丛丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VehicleController.丛丐世业且丘丙丝丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        bool val_23;
        var val_24;
        VehicleView val_25;
        int val_26;
        var val_27;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_82;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = 1152921505286238208;
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_23;
        }
        
        val_20 = null;
        val_20 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_628 == 0)
        {
            goto label_23;
        }
        
        val_21 = null;
        val_21 = null;
        if((typeof(Player_move_c).__il2cppRuntimeField_628 + 504) == 0)
        {
            goto label_23;
        }
        
        val_22 = null;
        val_22 = null;
        var val_5 = ((typeof(Player_move_c).__il2cppRuntimeField_628 + 504.viewID) == this.丞丗且下世丐业丌丙) ? 1 : 0;
        goto label_30;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = 1152921504848912384;
        bool val_6 = UnityEngine.Object.op_Inequality(x:  this.丝且与丝丒丟万丁专.currentView, y:  0);
        this.丝且与丝丒丟万丁专.freeAudioSource.enabled = false;
        this.丝且与丝丒丟万丁专.gravelSource.enabled = false;
        mem2[0] = 0;
        val_24 = null;
        val_24 = null;
        List.Enumerator<T> val_7 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_49:
        if((1709640832 & 1) == 0)
        {
            goto label_41;
        }
        
        if(((X22 + 504) == 0) || ((X22 + 504 + 504.viewID) != this.丞丗且下世丐业丌丙))
        {
            goto label_49;
        }
        
        val_25 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_9.丐丏七丌丕丗业且上());
        goto label_52;
        label_23:
        val_23 = false;
        label_30:
        this.丝丐与丆丑丅不丛丌 = val_23;
        val_25 = this.丝且与丝丒丟万丁专.currentView;
        if((val_25 != 0) && (this.与丞丗丟七下丐丛且 > 0.1f))
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.currentView, 丏业丟一东丂东丘丛:  true);
            val_25 = this.丝且与丝丒丟万丁专.currentView;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丝且与丝丒丟万丁专.freeAudioSource.enabled = true;
            this.丝且与丝丒丟万丁专.freeAudioSource.clip = this.丝且与丝丒丟万丁专.fire;
            val_25 = this.丝且与丝丒丟万丁专.freeAudioSource;
            val_25.loop = true;
            this.丝且与丝丒丟万丁专.freeAudioSource.Play();
        }
        
        }
        
        val_26 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.与丞丗丟七下丐丛且);
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_41:
        val_25 = 0;
        label_52:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝且与丝丒丟万丁专.丄世万丘上七丛三万();
        if(this.丝丐与丆丑丅不丛丌 != false)
        {
                val_27 = null;
            val_27 = null;
            val_25 = WeaponManager.丟丗丄业丘丗业丗七;
            this.丝且与丝丒丟万丁专.丏丐丕且丝七世丝丗(业七丑丁且丐丝上三:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不万上丕丅丏丆丄丝:  this.不万上丕丅丏丆丄丝);
        }
        
        label_82:
        val_26 = 0;
        return (bool)val_26;
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
