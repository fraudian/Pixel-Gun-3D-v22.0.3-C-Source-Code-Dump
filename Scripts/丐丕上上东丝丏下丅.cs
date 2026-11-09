using UnityEngine;
private sealed class PlayerBotEntity.丐丕上上东丝丏下丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBotEntity 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerBotEntity.丐丕上上东丝丏下丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PlayerBotEntity val_7;
        int val_8;
        val_7 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        T[] val_1 = System.Array.Empty<System.Object>();
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_7.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  48, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_7 == null)
        {
            goto label_5;
        }
        
        if((this.丝且与丝丒丟万丁专.<丗丟上丙业丙上三丑>k__BackingField) != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        this.丝且与丝丒丟万丁专.<丗丟上丙业丙上三丑>k__BackingField.丅丕丟丙七下丘丏丁 = this.丝且与丝丒丟万丁专.<丗丟上丙业丙上三丑>k__BackingField.专丆丛世丂丗丞一与;
        val_8 = 0;
        this.丝且与丝丒丟万丁专.世丐丗丑丌东与丈丞 = 0;
        return (bool)val_8;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_3:
        0.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  48, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
        label_4:
        float val_5 = val_7.丆东丛业丟丛丌丆丌().丌丙丆下专丝丑且丈().Item["Reload"].length;
        UnityEngine.WaitForSeconds val_6 = null;
        val_5 = val_5 / this.丝且与丝丒丟万丁专.丕丁丘丆万丄世专丛.不不丂丗丁丛丟丛丑;
        val_7 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  val_5);
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_5:
        if(496 != 0)
        {
            goto label_16;
        }
        
        goto label_17;
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
