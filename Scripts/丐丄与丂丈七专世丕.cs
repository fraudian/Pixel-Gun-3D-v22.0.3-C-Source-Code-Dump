using UnityEngine;
private sealed class CharacterInterfaceV2.丐丄与丂丈七专世丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丒丘丏上丙丟丑丕丈;
    private CharacterInterfaceV2.丏丂一丗丐丅丈业丄 丄丌丂东丘丗一万且;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.丐丄与丂丈七专世丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_9;
        int val_10;
        val_9 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_9;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.丏丂一丗丐丅丈业丄();
        this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  "VehicleBattleRoyale/Vehicle_Shop/"("VehicleBattleRoyale/Vehicle_Shop/") + this.丒丘丏上丙丟丑丕丈);
        val_10 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.丏丂一丗丐丅丈业丄::丂丑丘业丑丝万丌丅()));
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_9 = this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟;
        UnityEngine.Object val_6 = val_9.asset;
        if(val_6 == null)
        {
            goto label_7;
        }
        
        val_9 = (null == null) ? (val_6) : 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  10), b:  this.丒丘丏上丙丟丑丕丈)) != true)
        {
                val_9 = this.丒丘丏上丙丟丑丕丈;
            this.丝且与丝丒丟万丁专.丞丛丘丒丒丞三下上(丑且不丕与专丄业丙:  val_9, 丒丘丏上丙丟丑丕丈:  val_9);
        }
        
        label_9:
        val_10 = 0;
        return (bool)val_10;
        label_7:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_11;
        }
        
        goto label_12;
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
