using UnityEngine;
private sealed class FortMobWavesController.丝丝万丈丈与三丗万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FortMobWavesController 丝且与丝丒丟万丁专;
    private int 丕丅丑东丅丗世万三;
    private int 丐东专丆丌七下丕丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortMobWavesController.丝丝万丈丈与三丗万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        FortMobWavesController val_13;
        var val_14;
        int val_15;
        int val_16;
        float val_17;
        float val_18;
        var val_19;
        var val_20;
        var val_21;
        val_13 = this.丝且与丝丒丟万丁专;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_13 == null)
        {
            goto label_4;
        }
        
        val_14 = val_13;
        this.丕丅丑东丅丗世万三 = this.丝且与丝丒丟万丁专.业丌专丁上丁丛世丗;
        goto label_5;
        label_1:
        val_15 = this.丐东专丆丌七下丕丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_9;
        label_3:
        val_16 = 0;
        return (bool)val_16;
        label_4:
        val_14 = 76;
        this.丕丅丑东丅丗世万三 = 0;
        label_5:
        if(0 != 1)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.white;
            val_17 = val_2.g;
            val_16 = 1;
            val_13.上丛丑世不丅丟下丄(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8014"), 丂三丟丂丈丐丆丗丟:  FortDefenceLinkController.丄丘七三上丕世丞业.timeForShowNextWaveLable, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_17, b = val_2.b, a = val_2.a}, 世与下丑丌一丕丞丒:  true);
            val_18 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 + 112];
            val_18 = FortDefenceLinkController.丄丘七三上丕世丞业.timeForShowNextWaveLable;
            UnityEngine.WaitForSeconds val_3 = null;
            val_13 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  val_18);
            this.丒上七丌业七丟与丐 = val_13;
            this.丗丏丅丕丆世丁专丟 = val_16;
            return (bool)val_16;
        }
        
        label_9:
        val_15 = this.丝且与丝丒丟万丁专.七三一丘与丘丕一不;
        this.丐东专丆丌七下丕丞 = val_15;
        label_6:
        if(val_15 > 0)
        {
                UnityEngine.Color val_5 = UnityEngine.Color.red;
            val_18 = val_5.r;
            val_17 = val_5.b;
            val_16 = 1;
            val_13.丑不与一丞丛丌上东(丕丗丘丑丛与丑业丒:  this.丐东专丆丌七下丕丞.ToString(), 丂三丟丂丈丐丆丗丟:  1f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_18, g = val_5.g, b = val_17, a = val_5.a}, 世与下丑丌一丕丞丒:  true);
            int val_13 = this.丐东专丆丌七下丕丞;
            val_13 = val_13 - 1;
            this.丐东专丆丌七下丕丞 = val_13;
            UnityEngine.WaitForSeconds val_6 = null;
            val_13 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.丒上七丌业七丟与丐 = val_13;
            this.丗丏丅丕丆世丁专丟 = 2;
            return (bool)val_16;
        }
        
        if(val_13 != null)
        {
                val_19 = val_13;
            val_13.不丄三丁七丗丕万丕(三丗丄丒下丕丛丅丈:  (this.丕丅丑东丅丗世万三 != this.丝且与丝丒丟万丁专.业丌专丁上丁丛世丗) ? this.丝且与丝丒丟万丁专.业丌专丁上丁丛世丗 : (this.丕丅丑东丅丗世万三 + 1), 丅丆上世丛丏丌专丆:  0);
            val_20 = mem[this.丝且与丝丒丟万丁专 + 76];
            val_20 = this.丝且与丝丒丟万丁专 + 76;
        }
        else
        {
                val_19 = 76;
            val_13.不丄三丁七丗丕万丕(三丗丄丒下丕丛丅丈:  (this.丕丅丑东丅丗世万三 == 0) ? (0 + 1) : 0, 丅丆上世丛丏丌专丆:  0);
            val_20 = 0;
        }
        
        if(0 == val_13.且丒丆业一丑丒丕一())
        {
                val_21 = "Key_8036";
        }
        else
        {
                FortDefenceLinkController.丄丘七三上丕世丞业.key_Start_Wave
        }
        
        string val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  mem[FortDefenceLinkController.丄丘七三上丕世丞业.key_Start_Wave]), arg0:  1);
        val_18 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 + 112];
        val_18 = FortDefenceLinkController.丄丘七三上丕世丞业.timeForShowNextWaveLable;
        UnityEngine.Color val_12 = UnityEngine.Color.white;
        val_17 = val_12.g;
        if(val_13 != null)
        {
                val_13.上丛丑世不丅丟下丄(丕丗丘丑丛与丑业丒:  val_11, 丂三丟丂丈丐丆丗丟:  val_18, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_12.r, g = val_17, b = val_12.b, a = val_12.a}, 世与下丑丌一丕丞丒:  true);
        }
        else
        {
                val_13.上丛丑世不丅丟下丄(丕丗丘丑丛与丑业丒:  val_11, 丂三丟丂丈丐丆丗丟:  val_18, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_12.r, g = val_17, b = val_12.b, a = val_12.a}, 世与下丑丌一丕丞丒:  true);
        }
        
        if(this.丝且与丝丒丟万丁专.丘丅一七丞丞丐丒丘 != null)
        {
                this.丝且与丝丒丟万丁专.丘丅一七丞丞丐丒丘.Invoke(obj:  0);
        }
        
        val_16 = 0;
        this.丝且与丝丒丟万丁专.一世丏丏与丐丈与丆 = 0;
        return (bool)val_16;
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
