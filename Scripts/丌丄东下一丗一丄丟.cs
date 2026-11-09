using UnityEngine;
private sealed class TurretController_HologramProjector.丌丄东下一丗一丄丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TurretController_HologramProjector 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TurretController_HologramProjector.丌丄东下一丗一丄丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterInterfaceV2 val_15;
        TurretController_HologramProjector val_16;
        int val_17;
        val_15 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        val_16 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(137129984 != 0)
        {
                WeaponSounds val_2 = 丙不丅丕三丂业东丕();
            if(val_2 != 0)
        {
                if((System.String.op_Equality(a:  val_2.丙不丅丕三丂业东丕().三与丛丑且丐丈业丌(), b:  "Turret")) == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        val_17 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_17;
        label_12:
        string val_8 = this.丙不丅丕三丂业东丕().三与丛丑且丐丈业丌();
        this.丝且与丝丒丟万丁专.characterInterface.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_8);
        val_15 = val_8.丙不丅丕三丂业东丕();
        val_17 = val_15;
        if(val_17.丏世上东一丌丙世七() == 0)
        {
                return (bool)val_17;
        }
        
        val_15 = this.丝且与丝丒丟万丁专.characterInterface;
        val_16 = val_16.丙不丅丕三丂业东丕().丏世上东一丌丙世七();
        val_15.且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  val_16));
        label_1:
        val_17 = 0;
        return (bool)val_17;
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
