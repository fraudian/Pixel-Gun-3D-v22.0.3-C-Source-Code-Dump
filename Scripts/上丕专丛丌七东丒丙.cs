using UnityEngine;
private sealed class 东丂七丁上世丈丁丏.上丕专丛丌七东丒丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 专专三丒丛丁且七丛;
    public string 七丙不丅丛丘丗万与;
    public System.Action 业丒丒专丞丒丘丌丗;
    private bool 丝与丕万丂东丂丈万;
    private UnityEngine.WWW 丐丅丛专业业七丏世;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 东丂七丁上世丈丁丏.上丕专丛丌七东丒丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_20;
        string val_21;
        string val_22;
        string val_23;
        UnityEngine.WWW val_24;
        bool val_25;
        int val_26;
        var val_27;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = 1152921505593425920;
        val_21 = this;
        if((PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄().ContainsKey(key:  this.专专三丒丛丁且七丛)) == false)
        {
            goto label_6;
        }
        
        string val_4 = PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄().Item[this.专专三丒丛丁且七丛];
        val_22 = this;
        if((System.String.op_Equality(a:  val_4, b:  this.七丙不丅丛丘丗万与)) == false)
        {
            goto label_10;
        }
        
        val_23 = 1;
        goto label_14;
        label_1:
        val_23 = this;
        val_24 = this.丐丅丛专业业七丏世;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_24 != null)
        {
            goto label_13;
        }
        
        val_24 = 0;
        goto label_13;
        label_6:
        val_23 = 0;
        val_22 = this.七丙不丅丛丘丗万与;
        goto label_14;
        label_10:
        PGCompany.东丂七丁上世丈丁丏.专且丁丟丐丝丌丈上(七丙不丅丛丘丗万与:  val_4);
        bool val_7 = PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄().Remove(key:  this.专专三丒丛丁且七丛);
        PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上.丂且不业丂专丛丆东();
        val_23 = 0;
        label_14:
        if((val_23 | (丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.七丙不丅丛丘丗万与))) == true)
        {
            goto label_21;
        }
        
        val_25 = this;
        this.丝与丕万丂东丂丈万 = false;
        UnityEngine.WWW val_10 = Rilisoft.与丄丁丄丙丞下下丙.三专世丝丝丈丂东与(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与, 丝丌丝不丟丞丑丑丗:  true);
        this.丐丅丛专业业七丏世 = val_10;
        if(val_10 == null)
        {
            goto label_22;
        }
        
        val_23 = 1152921555337875696;
        label_13:
        if(val_10.isDone == false)
        {
            goto label_23;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_23.error)) == false)
        {
            goto label_25;
        }
        
        System.Byte[] val_14 = this.丐丅丛专业业七丏世.bytes;
        if((val_14 == null) || (val_14.Length == 0))
        {
            goto label_28;
        }
        
        PGCompany.东丂七丁上世丈丁丏.丘丛丘世一丟世丝丅(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与, 一丐丗丁丞丆丅丟丄:  val_14);
        val_23 = this.七丙不丅丛丘丗万与;
        PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄().Add(key:  this.专专三丒丛丁且七丛, value:  val_23);
        goto label_32;
        label_23:
        val_26 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_25:
        val_25 = this.丝与丕万丂东丂丈万;
        label_22:
        mem2[0] = 1;
        goto label_34;
        label_28:
        this.丝与丕万丂东丂丈万 = true;
        label_32:
        val_27 = null;
        val_27 = null;
        PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上.丂且不业丂专丛丆东();
        if(this.丝与丕万丂东丂丈万 == false)
        {
            goto label_38;
        }
        
        label_34:
        val_20 = 1152921505593425920;
        PGCompany.东丂七丁上世丈丁丏.专且丁丟丐丝丌丈上(七丙不丅丛丘丗万与:  this.七丙不丅丛丘丗万与);
        val_21 = this;
        val_23 = PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄();
        if((val_23.ContainsKey(key:  this.专专三丒丛丁且七丛)) == false)
        {
            goto label_46;
        }
        
        val_23 = PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄();
        bool val_19 = val_23.Remove(key:  this.专专三丒丛丁且七丛);
        goto label_46;
        label_38:
        val_21 = this.专专三丒丛丁且七丛;
        label_46:
        this.丐丅丛专业业七丏世 = 0;
        label_21:
        PGCompany.东丂七丁上世丈丁丏.不专丕与丁上丑丕丕(丂丐丄丁丆与丈丂上:  mem[this.专专三丒丛丁且七丛]);
        val_26 = this.业丒丒专丞丒丘丌丗;
        if(val_26 == null)
        {
                return (bool)val_26;
        }
        
        val_26.Invoke();
        label_2:
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
