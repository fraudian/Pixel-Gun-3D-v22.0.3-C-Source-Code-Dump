using UnityEngine;
private sealed class CharacterInterfaceV2.丑丒丁不丌丑不丐丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    public string 丒丘丏上丙丟丑丕丈;
    private CharacterInterfaceV2.丏且丄东上丗丂世丅 丄丌丂东丘丗一万且;
    private UnityEngine.GameObject 丛丕丅丌东上丙万丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.丑丒丁不丌丑不丐丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_22;
        var val_23;
        var val_24;
        System.Func<System.Boolean> val_25;
        int val_26;
        UnityEngine.GameObject val_27;
        var val_28;
        val_22 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_23;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.丏且丄东上丗丂世丅();
        val_23 = null;
        val_23 = null;
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  1), b:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与).三与丛丑且丐丈业丌())) != false)
        {
                val_24 = null;
            val_24 = null;
            this.丝且与丝丒丟万丁专.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        }
        
        this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  "Trails_Shop/"("Trails_Shop/") + this.丒丘丏上丙丟丑丕丈);
        System.Func<System.Boolean> val_8 = null;
        val_25 = val_8;
        val_8 = new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.丏且丄东上丗丂世丅::丁丑东七丕丙七丅丒());
        val_26 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_8);
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        goto label_17;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_25 = this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟;
        UnityEngine.Object val_10 = val_25.asset;
        if(val_10 != null)
        {
                var val_11 = (null == null) ? (val_10) : 0;
        }
        else
        {
                val_27 = 0;
        }
        
        this.丛丕丅丌东上丙万丁 = val_27;
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  11), b:  this.丒丘丏上丙丟丑丕丈)) == true)
        {
            goto label_23;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_24;
        }
        
        label_17:
        label_24:
        val_25 = this.丝且与丝丒丟万丁专.丝丑万专丕丕丒七一();
        if(val_25 == 0)
        {
            goto label_27;
        }
        
        val_25 = this.丝且与丝丒丟万丁专.丝丑万专丕丕丒七一().GetComponent<WeaponSounds>().三与丛丑且丐丈业丌();
        val_28 = null;
        val_28 = null;
        if((System.String.op_Inequality(a:  val_25, b:  丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与).三与丛丑且丐丈业丌())) == false)
        {
            goto label_36;
        }
        
        label_27:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_26 = 1;
        return (bool)val_26;
        label_36:
        val_25 = this.丛丕丅丌东上丙万丁;
        val_22 = this.丒丘丏上丙丟丑丕丈;
        this.丝且与丝丒丟万丁专.与丄丌一专与丁丛一(丑且不丕与专丄业丙:  val_25, 丒丘丏上丙丟丑丕丈:  val_22);
        label_23:
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
