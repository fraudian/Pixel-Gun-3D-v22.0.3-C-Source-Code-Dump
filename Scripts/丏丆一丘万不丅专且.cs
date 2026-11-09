using UnityEngine;
private sealed class HelicopterController.丏丆一丘万不丅专且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public HelicopterController 丝且与丝丒丟万丁专;
    public float 与丞丗丟七下丐丛且;
    public int 丞丗且下世丐业丌丙;
    public int 不万上丕丅丏丆丄丝;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HelicopterController.丏丆一丘万不丅专且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        HelicopterView val_17;
        int val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_81;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_17 = this.丝且与丝丒丟万丁专.view;
        if((val_17 != 0) && (this.与丞丗丟七下丐丛且 > 0.1f))
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.view, 丏业丟一东丂东丘丛:  true);
            val_17 = this.丝且与丝丒丟万丁专.view;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丝且与丝丒丟万丁专.freeAudioSource.enabled = true;
            this.丝且与丝丒丟万丁专.freeAudioSource.clip = this.丝且与丝丒丟万丁专.fire;
            val_17 = this.丝且与丝丒丟万丁专.freeAudioSource;
            val_17.loop = true;
            this.丝且与丝丒丟万丁专.freeAudioSource.Play();
        }
        
        }
        
        val_18 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.与丞丗丟七下丐丛且);
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        bool val_4 = UnityEngine.Object.op_Inequality(x:  this.丝且与丝丒丟万丁专.view, y:  0);
        this.丝且与丝丒丟万丁专.freeAudioSource.enabled = false;
        this.丝且与丝丒丟万丁专.gravelSource.enabled = false;
        mem2[0] = 0;
        val_19 = null;
        val_19 = null;
        List.Enumerator<T> val_5 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_38:
        if((419646144 & 1) == 0)
        {
            goto label_30;
        }
        
        if(((X22 + 504) == 0) || ((X22 + 504 + 504.viewID) != this.丞丗且下世丐业丌丙))
        {
            goto label_38;
        }
        
        val_20 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_7.丐丏七丌丕丗业且上());
        goto label_41;
        label_30:
        val_20 = 0;
        label_41:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_21 = null;
        val_21 = null;
        val_17 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_17 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_17 != 0)
        {
                val_22 = null;
            val_22 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_628 != 0)
        {
                val_23 = null;
            val_23 = null;
            val_17 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 504];
            val_17 = typeof(Player_move_c).__il2cppRuntimeField_628 + 504;
            if(val_17 != 0)
        {
                val_24 = null;
            val_24 = null;
            val_17 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 504];
            val_17 = typeof(Player_move_c).__il2cppRuntimeField_628 + 504;
            if(val_17.viewID == this.丞丗且下世丐业丌丙)
        {
                val_25 = null;
            val_25 = null;
            val_17 = WeaponManager.丟丗丄业丘丗业丗七;
            this.丝且与丝丒丟万丁专.丏丐丕且丝七世丝丗(业七丑丁且丐丝上三:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不万上丕丅丏丆丄丝:  this.不万上丕丅丏丆丄丝);
        }
        
        }
        
        }
        
        }
        
        label_81:
        val_18 = 0;
        return (bool)val_18;
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
