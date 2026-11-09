using UnityEngine;
private sealed class 万丝丞东丘丒丌七专.万丛丞丑丕丙丘且与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.MainStore.专丁丄东上专丞世与 不三不与业丏丁丅丞;
    public PGCompany.MainStore.万丝丞东丘丒丌七专 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 万丝丞东丘丒丌七专.万丛丞丑丕丙丘且与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专 val_7;
        PGCompany.MainStore.专丁丄东上专丞世与 val_8;
        System.Collections.Generic.Dictionary<PGCompany.MainStore.丞专且与丆万丒三下, System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>> val_9;
        int val_10;
        val_7 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        val_8 = this.不三不与业丏丁丅丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_8 == null)
        {
            goto label_3;
        }
        
        label_18:
        if((85153.世丕七丟万丈丙丒专(不三不与业丏丁丅丞:  val_8)) == false)
        {
            goto label_5;
        }
        
        PGCompany.七丑一上且三世丝三<K, V> val_3 = PGCompany.七丑一上且三世丝三<PGCompany.MainStore.丞专且与丆万丒三下, System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>>.万世丅七一专丕丞不();
        val_9 = 0;
        if((val_8.丏丁三三丞东丙不且(与东丛丙丆丁东不丑: ref  val_3)) != false)
        {
                val_8 = val_8.一丁丛下丏丅丟不三();
            val_9 = val_3;
            val_7.一丙专丄不丑万世与(不丝丐与丑一丈丌世:  val_8, 与东丛丙丆丁东不丑:  val_9);
        }
        
        PGCompany.七丑一上且三世丝三<K, V> val_6 = PGCompany.七丑一上且三世丝三<PGCompany.MainStore.丞专且与丆万丒三下, System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>>.万世丅七一专丕丞不();
        val_7 = val_3;
        label_3:
        val_10 = 0;
        return (bool)val_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_7 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_5:
        val_10 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
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
