using UnityEngine;
private sealed class CharacterInterfaceV2.丁七七丂上三丂丐丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丒丘丏上丙丟丑丕丈;
    private CharacterInterfaceV2.丒丑三丗业与东丌丐 丄丌丂东丘丗一万且;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.丁七七丂上三丂丐丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_11;
        int val_12;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_11;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.丒丑三丗业与东丌丐();
        this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  ((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.丒丘丏上丙丟丑丕丈)) != true) ? "RoyaleHatsVisual/" : "Hats/"(((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.丒丘丏上丙丟丑丕丈)) != true) ? "RoyaleHatsVisual/" : "Hats/") + this.丒丘丏上丙丟丑丕丈);
        val_12 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.丒丑三丗业与东丌丐::丞丙丌丙一丕丒丒业()));
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_11 = this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟;
        UnityEngine.Object val_8 = val_11.asset;
        if(val_8 == null)
        {
            goto label_9;
        }
        
        val_11 = (null == null) ? (val_8) : 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_13;
        }
        
        label_14:
        label_13:
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  3), b:  this.丒丘丏上丙丟丑丕丈)) != true)
        {
                val_11 = this.丒丘丏上丙丟丑丕丈;
            this.丝且与丝丒丟万丁专.丏专丛且丗丐丂丒丕(丑且不丕与专丄业丙:  val_11, 丒丘丏上丙丟丑丕丈:  val_11);
        }
        
        label_11:
        val_12 = 0;
        return (bool)val_12;
        label_9:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_13;
        }
        
        goto label_14;
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
