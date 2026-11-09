using UnityEngine;
private sealed class 丈丏一丟不丑东东丙.丁丏不万丙东万丅丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.丈丏一丟不丑东东丙 丝且与丝丒丟万丁专;
    private float 丄丑丘下丐专三不丌;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丈丏一丟不丑东东丙.丁丏不万丙东万丅丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        int val_13;
        var val_14;
        string val_16;
        float val_17;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_12 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_12;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            this.丄丑丘下丐专三不丌 = 0f;
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        val_13 = 1152921505171275776;
        val_14 = null;
        val_14 = null;
        if((与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 != false) && (与丂丏丛丞丞丒丟丄.世丂丁丟世丄丕丆丄 != false))
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.丄丑丘下丐专三不丌 + val_1;
            this.丄丑丘下丐专三不丌 = val_1;
        }
        else
        {
                if(this.丄丑丘下丐专三不丌 > 0f)
        {
                val_16 = this.丝且与丝丒丟万丁专.业丑丁丆丕丆丂丅万().专上丗万丕丌丈丟万(下上丐丆丝丟丝丒不:  "ftime");
            if(val_16 != null)
        {
                if(null != null)
        {
                val_16 = 0;
        }
        
            bool val_6 = 丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  val_16, 丙业与丙丗丝不丈东: out  float val_5 = -0.9900315f);
            val_17 = 0f;
        }
        else
        {
                val_17 = 0f;
        }
        
            val_17 = val_17 + this.丄丑丘下丐专三不丌;
            this.丝且与丝丒丟万丁专.业丑丁丆丕丆丂丅万().丂丏一业丑丄丝丐丄(下上丐丆丝丟丝丒不:  "ftime", 下下丏一丙不丘丌丞:  val_17.ToString());
            val_13 = (int)val_17 / 60f;
            if(this.丝且与丝丒丟万丁专.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟() != val_13)
        {
                this.丝且与丝丒丟万丁专.上不丕丌丄世丆丘丘(且下丆丕丝丄丑三三:  val_13);
        }
        
            this.丄丑丘下丐专三不丌 = 0f;
        }
        
        }
        
        val_12 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_12;
        return (bool)val_12;
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
