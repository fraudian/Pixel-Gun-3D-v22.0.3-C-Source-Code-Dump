using UnityEngine;
private sealed class FortAttackController.丅与东万丕下七丞丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FortAttackController 丝且与丝丒丟万丁专;
    private bool 世下万丌东东丝不丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortAttackController.丅与东万丕下七丞丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_19;
        int val_20;
        float val_21;
        float val_22;
        int val_23;
        float val_24;
        float val_25;
        float val_26;
        int val_27;
        int val_28;
        var val_29;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 3)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
            goto label_7;
        }
        
        val_20 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.世下万丌东东丝不丁 = true;
        label_4:
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
            goto label_11;
        }
        
        label_3:
        val_20 = 0;
        return (bool)val_20;
        label_7:
        val_19 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  FortDefenceLinkController.丄丘七三上丕世丞业.key_Start_Game), arg0:  this.丝且与丝丒丟万丁专.丞上丘丐丑不业世丏);
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        val_21 = val_6.b;
        且丕万丑下业丙丂丗().Show(丕丗丘丑丛与丑业丒:  val_19, 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_21, a = val_6.a});
        val_22 = this.丝且与丝丒丟万丁专._waveSettings.timeToStartGame;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_22);
        val_23 = 2;
        goto label_21;
        label_11:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_24 = this.丝且与丝丒丟万丁专.业丗丄不丕不丁丗与;
            val_25 = this.丝且与丝丒丟万丁专.业丗丄不丕不丁丗与;
            val_26 = UnityEngine.Time.deltaTime;
        }
        else
        {
                val_25 = 544;
            val_24 = 8.631999E-43f;
            val_26 = UnityEngine.Time.deltaTime;
        }
        
        val_22 = val_24 - val_26;
        mem[544] = val_22;
        if(this.世下万丌东东丝不丁 != true)
        {
                if(this.丝且与丝丒丟万丁专 == null)
        {
                val_22 = mem[544];
        }
        
            if(val_22 < 0)
        {
                val_19 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  FortDefenceLinkController.丄丘七三上丕世丞业.key_Start_Next_Wave), arg0:  this.丝且与丝丒丟万丁专.三下专与丌且丌与专);
            UnityEngine.Color val_13 = UnityEngine.Color.white;
            val_22 = val_13.r;
            val_21 = val_13.b;
            且丕万丑下业丙丂丗().Show(丕丗丘丑丛与丑业丒:  val_19, 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_22, g = val_13.g, b = val_21, a = val_13.a});
            this.世下万丌东东丝不丁 = true;
        }
        
        }
        
        if(mem[544] <= 0f)
        {
                if(this.丝且与丝丒丟万丁专 != null)
        {
                val_27 = this.丝且与丝丒丟万丁专.业丌专丁上丁丛世丗;
            val_28 = this.丝且与丝丒丟万丁专.业丌专丁上丁丛世丗;
        }
        else
        {
                val_28 = 548;
            val_27 = 0;
        }
        
            val_19 = this.丝且与丝丒丟万丁专._waveSettings;
            int val_19 = this.丝且与丝丒丟万丁专._waveSettings.countWave;
            val_19 = val_19 - 1;
            if(0 < val_19)
        {
                this.世下万丌东东丝不丁 = false;
            mem[548] = 1;
            UnityEngine.Color val_17 = UnityEngine.Color.white;
            val_22 = val_17.r;
            val_21 = val_17.b;
            且丕万丑下业丙丂丗().Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  FortDefenceLinkController.丄丘七三上丕世丞业.key_Start_Wave), arg0:  2), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_22, g = val_17.g, b = val_21, a = val_17.a});
            val_19 = mem[548];
            mem[544] = this.丝且与丝丒丟万丁专._waveSettings.listTimeWave.Item[1];
            val_29 = null;
            val_29 = null;
            if(FortAttackController.丘丅一七丞丞丐丒丘 != null)
        {
                FortAttackController.丘丅一七丞丞丐丒丘.Invoke(obj:  1);
        }
        
        }
        
        }
        
        val_23 = 3;
        this.丒上七丌业七丟与丐 = 0;
        label_21:
        this.丗丏丅丕丆世丁专丟 = val_23;
        val_20 = 1;
        return (bool)val_20;
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
