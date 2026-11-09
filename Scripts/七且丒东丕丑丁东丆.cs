using UnityEngine;
private sealed class 万丝丞东丘丒丌七专.七且丒东丕丑丁东丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.MainStore.万丝丞东丘丒丌七专 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 万丝丞东丘丒丌七专.七且丒东丕丑丁东丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        System.Action<PGCompany.MainStore.专丁丄东上专丞世与> val_13;
        System.Action<PGCompany.MainStore.专丁丄东上专丞世与> val_14;
        int val_15;
        PGCompany.DataObjects.丏丆丘丏丘丂丌万丕 val_17;
        val_13 = 82663;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_31;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Action<PGCompany.MainStore.专丁丄东上专丞世与> val_1 = null;
        val_14 = val_1;
        val_1 = new System.Action<PGCompany.MainStore.专丁丄东上专丞世与>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.MainStore.万丝丞东丘丒丌七专::一且丞业丘七业专专(PGCompany.MainStore.专丁丄东上专丞世与 不三不与业丏丁丅丞));
        val_13 = val_14;
        PGCompany.MainStore.专丁丄东上专丞世与.丟丞丘东丞丂丐丗业(丙业与丙丗丝不丈东:  val_1);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        val_13 = 0;
        label_5:
        if(val_13.业丅七与专丘丝丈丞() == false)
        {
            goto label_6;
        }
        
        List.Enumerator<T> val_3 = this.丝且与丝丒丟万丁专.专丗丆东丐与丈东丏.GetEnumerator();
        label_11:
        if(((-617985552) & 1) == 0)
        {
            goto label_9;
        }
        
        val_5.丐丏七丌丕丗业且上().Dispose();
        goto label_11;
        label_6:
        val_15 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_15;
        return (bool)val_15;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝且与丝丒丟万丁专.专丗丆东丐与丈东丏.Clear();
        string val_8 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  103);
        val_14 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_17 = val_14;
        this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏 = val_17;
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.且三丆丌业丌七丑丟 != null)
        {
                PGCompany.MainStore.万丝丞东丘丒丌七专.且三丆丌业丌七丑丟.Invoke();
            val_17 = this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏;
        }
        
        if((val_17 != null) && (this.丝且与丝丒丟万丁专.世丂上丌丞且丁七丏.Sections != null))
        {
                this.丝且与丝丒丟万丁专.丌丄丆丗丁丈下丕丟();
            this.丝且与丝丒丟万丁专.丁丝丕丛万丆丌七丗(丕丁丘七且丝丟丐丁:  0);
            PGCompany.MainStore.专丁丄东上专丞世与.七丅丁上东丗专专世(丙业与丙丗丝不丈东:  new System.Action<PGCompany.MainStore.专丁丄东上专丞世与>(object:  this.丝且与丝丒丟万丁专, method:  System.Void PGCompany.MainStore.万丝丞东丘丒丌七专::一且丞业丘七业专专(PGCompany.MainStore.专丁丄东上专丞世与 不三不与业丏丁丅丞)));
        }
        
        label_31:
        val_15 = 0;
        return (bool)val_15;
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
