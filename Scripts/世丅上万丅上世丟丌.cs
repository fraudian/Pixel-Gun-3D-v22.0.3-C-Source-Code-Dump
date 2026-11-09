using UnityEngine;
private sealed class Switcher.世丅上万丅上世丟丌 : IEnumerable<float>, IEnumerable, IEnumerator<float>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private float 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public Switcher 丝且与丝丒丟万丁专;
    private Rilisoft.丅丞丈丅东丆与世丈 与业丕业业业丌丟丐;
    
    // Properties
    private float System.Collections.Generic.IEnumerator<System.Single>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Switcher.世丅上万丅上世丟丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
    }
    private bool MoveNext()
    {
        int val_13;
        int val_14;
        var val_15;
        var val_17;
        var val_18;
        var val_19;
        System.Predicate<三丈丟与丏丘丈丐万> val_21;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_62;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_13 = 0;
        mem2[0] = false;
        与丒丕丁下世东丅丌 = false;
        mem[1] = 0;
        return (bool)val_13;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        bool val_2 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        mem[1152921540460514360] = 0;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = 0;
        this.丝且与丝丒丟万丁专.业东丛丂丏下丗丘且.丅东万丄丑且丞丏七(丗丛丆丐下丈与万业:  0.9f, 丟丈与丟丞三上丛丕:  0.95f);
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == true)
        {
            goto label_11;
        }
        
        label_5:
        val_14 = 1152921505326600192;
        val_15 = null;
        val_15 = null;
        float val_12 = 1000f;
        val_12 = (float)Switcher.丌不丙丞丙丌丗七上.ElapsedMilliseconds / val_12;
        if(val_12 < 0)
        {
            goto label_15;
        }
        
        Switcher.丌不丙丞丙丌丗七上.Stop();
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  0);
        val_17 = null;
        val_17 = null;
        与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 = false;
        val_18 = null;
        val_18 = null;
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_6 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        val_19 = null;
        val_19 = null;
        val_21 = Switcher.<>c.<>9__67_0;
        if(val_21 == null)
        {
            goto label_28;
        }
        
        if(val_6 != null)
        {
            goto label_35;
        }
        
        goto label_30;
        label_15:
        val_13 = 1;
        this.丗丏丅丕丆世丁专丟 = val_13;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        return (bool)val_13;
        label_28:
        val_21 = null;
        val_21 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  Switcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Switcher.<>c::世七丈丁丟丘丝与丏(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        Switcher.<>c.<>9__67_0 = val_21;
        if(val_6 != null)
        {
            goto label_35;
        }
        
        label_30:
        label_35:
        val_14 = val_6.FindIndex(match:  null);
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  val_14);
        label_11:
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) < 2)
        {
                丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  下丟世丏三东万丘丏.不丂丆丏丒三丝丆丄(), 丘丘不丏且丂丐丘丝:  true);
        }
        else
        {
                丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
        }
        
        val_13 = 1;
        this.丗丏丅丕丆世丁专丟 = 2;
        this.丒上七丌业七丟与丐 = this.丝且与丝丒丟万丁专.丈丄丂下丒专丌丛丄;
        return (bool)val_13;
        label_62:
        val_13 = 0;
        return (bool)val_13;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
    }
    private float System.Collections.Generic.IEnumerator<System.Single>.get_Current()
    {
        return (float)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private System.Collections.Generic.IEnumerator<float> System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator()
    {
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
                if(this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.Generic.IEnumerator<System.Single>)this;
        }
        
        }
        
        .丗丏丅丕丆世丁专丟 = 0;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        this = new Switcher.世丅上万丅上世丟丌();
        return (System.Collections.Generic.IEnumerator<System.Single>)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Single>.GetEnumerator();
    }

}
