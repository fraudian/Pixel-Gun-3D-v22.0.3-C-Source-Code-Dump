using UnityEngine;
private sealed class CharacterInterfaceV2.丒丄丆丘上上丆丌丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丒丘丏上丙丟丑丕丈;
    private CharacterInterfaceV2.丂与丟丛丑丁丒丏三 丄丌丂东丘丗一万且;
    public CharacterInterfaceV2 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterInterfaceV2.丒丄丆丘上上丆丌丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_10;
        int val_11;
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
        this.丄丌丂东丘丗一万且 = new CharacterInterfaceV2.丂与丟丛丑丁丒丏三();
        this.丄丌丂东丘丗一万且.东丞丒丙世丏三下丟 = UnityEngine.Resources.LoadAsync(path:  Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丘丕丂万丝丁丌丞业(世丐丗专丅三丝丑丆:  this.丒丘丏上丙丟丑丕丈));
        val_11 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean CharacterInterfaceV2.丂与丟丛丑丁丒丏三::专万丅丆丑丒丈丂丁()));
        this.丗丏丅丕丆世丁专丟 = val_11;
        return (bool)val_11;
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
        if((System.String.op_Inequality(a:  this.丝且与丝丒丟万丁专.上上丆丕丑丘丌丛万(丏丅三丑专丌世丂丏:  13), b:  this.丒丘丏上丙丟丑丕丈)) != true)
        {
                val_10 = this.丒丘丏上丙丟丑丕丈;
            this.丝且与丝丒丟万丁专.丕专与丏丕丐丝上丆(丁丆丂丏丟丗七丒丘:  val_10, 世丐丗专丅三丝丑丆:  val_10);
        }
        
        label_10:
        val_11 = 0;
        return (bool)val_11;
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
