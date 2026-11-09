using UnityEngine;
private sealed class CharacterInterfaceV2.三上上且丐一丂丝丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丒丘丏上丙丟丑丕丈;
    private CharacterInterfaceV2.不丌三三丏三世不丙 丄丌丂东丘丗一万且;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    public UnityEngine.Texture 三丆业丘丑万丘世下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.三上上且丐一丂丝丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Texture val_10;
        System.Func<System.Boolean> val_11;
        int val_12;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.不丌三三丏三世不丙();
        this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.东一丐丕丗万上丘与(), 丌丗丏丏丛东专丁且:  this.丒丘丏上丙丟丑丕丈));
        System.Func<System.Boolean> val_5 = null;
        val_11 = val_5;
        val_5 = new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.不丌三三丏三世不丙::丈三丈万万且万丅丐());
        val_12 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_5);
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_10 = this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟;
        UnityEngine.Object val_7 = val_10.asset;
        if(val_7 == null)
        {
            goto label_11;
        }
        
        val_10 = (null == null) ? (val_7) : 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  6), b:  this.丒丘丏上丙丟丑丕丈)) != true)
        {
                val_10 = this.三丆业丘丑万丘世下;
            this.丝且与丝丒丟万丁专.一丗丒七丆丈丒丙上(丑且不丕与专丄业丙:  val_10, 丒丘丏上丙丟丑丕丈:  this.丒丘丏上丙丟丑丕丈, 三丆业丘丑万丘世下:  val_10);
        }
        
        label_13:
        val_12 = 0;
        return (bool)val_12;
        label_11:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_15;
        }
        
        goto label_16;
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
