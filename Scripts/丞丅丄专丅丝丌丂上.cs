using UnityEngine;
private sealed class CharacterInterfaceV2.丞丅丄专丅丝丌丂上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丒丘丏上丙丟丑丕丈;
    private CharacterInterfaceV2.丟丗丁丞万丒下丘三 丄丌丂东丘丗一万且;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.丞丅丄专丅丝丌丂上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_10;
        string val_11;
        int val_12;
        val_10 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.丟丗丁丞万丒下丘三();
        val_11 = this.丒丘丏上丙丟丑丕丈;
        if((System.String.op_Equality(a:  this.丒丘丏上丙丟丑丕丈, b:  "ShopStubForClanGadgetLockedByDivision")) != true)
        {
                val_11 = "GadgetsContent/gadget_shop_preview/"("GadgetsContent/gadget_shop_preview/") + val_11;
        }
        
        this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  val_11);
        val_12 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.丟丗丁丞万丒下丘三::东丙不七丒丝丛丗且()));
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_10 = this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟;
        UnityEngine.Object val_7 = val_10.asset;
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_10 = (null == null) ? (val_7) : 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  9), b:  this.丒丘丏上丙丟丑丕丈)) != true)
        {
                val_10 = this.丒丘丏上丙丟丑丕丈;
            this.丝且与丝丒丟万丁专.三三万专丅与丘三丏(丑且不丕与专丄业丙:  val_10, 丒丘丏上丙丟丑丕丈:  val_10);
        }
        
        label_10:
        val_12 = 0;
        return (bool)val_12;
        label_8:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_12;
        }
        
        goto label_13;
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
