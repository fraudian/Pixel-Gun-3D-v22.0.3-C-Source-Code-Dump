using UnityEngine;
private sealed class CharacterInterfaceV2.丙丄七丂七业丒下丐 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private CharacterInterfaceV2.不一上丗丄七东丞丝 丄丌丂东丘丗一万且;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    public string 丒丘丏上丙丟丑丕丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.丙丄七丂七业丒下丐(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_8;
        int val_9;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_9;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.不一上丗丄七东丞丝();
        .东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  "Boots/BootPrefab");
        val_9 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.不一上丗丄七东丞丝::专丗丐丐丙一且万丏()));
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.ResourceRequest val_8 = this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟;
        UnityEngine.Object val_5 = val_8.asset;
        if(val_5 == null)
        {
            goto label_7;
        }
        
        val_8 = (null == null) ? (val_5) : 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  5), b:  this.丒丘丏上丙丟丑丕丈)) != true)
        {
                val_8 = this.丒丘丏上丙丟丑丕丈;
            this.丝且与丝丒丟万丁专.世且丕丟丟万上丟世(丑且不丕与专丄业丙:  val_8, 丒丘丏上丙丟丑丕丈:  val_8);
        }
        
        label_9:
        val_9 = 0;
        return (bool)val_9;
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
