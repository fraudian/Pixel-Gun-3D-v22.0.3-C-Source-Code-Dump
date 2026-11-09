using UnityEngine;
private sealed class TaskUIImposterModeScan.丈丌丁丗下丅丗丐丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TaskUIImposterModeScan 丝且与丝丒丟万丁专;
    private float 丈一丅丏丆丞丐丞丛;
    private int 丙丞丅与丘七丟丒丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TaskUIImposterModeScan.丈丌丁丗下丅丗丐丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_18;
        TaskUIImposterModeScan.丈丌丁丗下丅丗丐丑 val_19;
        var val_20;
        System.Random val_22;
        var val_23;
        System.Collections.Generic.List<UILabel> val_24;
        float val_25;
        int val_26;
        val_19 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_20 = null;
        val_20 = null;
        if((TaskUIImposterModeScan.<>c.<>9__18_0) == null)
        {
            goto label_6;
        }
        
        label_41:
        this.丝且与丝丒丟万丁专.scanLabels.ForEach(action:  TaskUIImposterModeScan.<>c.<>9__18_0);
        System.Random val_2 = null;
        val_22 = val_2;
        val_2 = new System.Random(Seed:  this.丝且与丝丒丟万丁专.scanLabels.丐丕不丅三专万丕丗());
        val_23 = 0;
        goto label_9;
        label_16:
        ScanData val_4 = this.丝且与丝丒丟万丁专.labelsValues.Item[0];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  X23.Item[0], 丕丗丘丑丛与丑业丒:  丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<System.String>(丑东与丅丐丅丂丞业:  val_4.values, 丂丆且一丛丙丑七丒:  val_2));
        val_23 = 1;
        label_9:
        val_24 = this.丝且与丝丒丟万丁专.scanLabels;
        if(val_23 < this.丝且与丝丒丟万丁专.scanLabels.Count)
        {
            goto label_16;
        }
        
        val_19 = val_19;
        float val_18 = (float)val_24.Count;
        val_18 = 1f / val_18;
        mem[1152921537596196344] = val_18;
        mem[1152921537596196348] = 0;
        this.丝且与丝丒丟万丁专.丐丅丁东丏且丑不丌();
        goto label_17;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_18;
        }
        
        label_17:
        val_18 = this.丝且与丝丒丟万丁专;
        val_25 = this.丝且与丝丒丟万丁专.丄不丅东丑丝三丌丞;
        if(val_25 < 0)
        {
            goto label_19;
        }
        
        this.丝且与丝丒丟万丁专.世丕丐丂丕丅一丅七();
        mem2[0] = 1;
        label_43:
        val_18 = this.丝且与丝丒丟万丁专.completeMessage;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  true);
        this.丝且与丝丒丟万丁专.万丏丛东下丝下丟丕();
        label_2:
        val_26 = 0;
        return (bool)val_26;
        label_19:
        float val_8 = UnityEngine.Time.unscaledDeltaTime;
        val_24 = this.丝且与丝丒丟万丁专;
        val_25 = val_25 + val_8;
        mem2[0] = val_25;
        label_44:
        val_8 = val_25 / (this.丝且与丝丒丟万丁专 + 160 + -68);
        this.丝且与丝丒丟万丁专.progressBar.fillAmount = val_8;
        float val_22 = this.丝且与丝丒丟万丁专 + 160 + -68;
        int val_20 = this.丙丞丅与丘七丟丒丘;
        float val_19 = this.丈一丅丏丆丞丐丞丛;
        val_19 = val_19 * (float)val_20;
        if((this.丝且与丝丒丟万丁专 + 112.fillAmount) > val_19)
        {
                val_20 = val_20 + 1;
            this.丙丞丅与丘七丟丒丘 = val_20;
            if(val_20 >= 1)
        {
                val_18 = 1152921524394923120;
            var val_21 = 0;
            do
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.scanLabels.Item[0], 丏业丟一东丂东丘丛:  true);
            val_21 = val_21 + 1;
        }
        while(val_21 < this.丙丞丅与丘七丟丒丘);
        
        }
        
        }
        
        val_22 = val_22 - (this.丝且与丝丒丟万丁专 + 160);
        val_25 = val_22 + 1f;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.timerLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10149")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10149")) + " " + 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)val_25, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)val_25, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
        val_22 = mem[this.丝且与丝丒丟万丁专 + 112];
        val_22 = this.丝且与丝丒丟万丁专 + 112;
        float val_14 = val_22.fillAmount;
        val_14 = val_14 * 100f;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专.percentLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}%", arg0:  (int)val_14));
        val_26 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_6:
        TaskUIImposterModeScan.<>c.<>9__18_0 = new System.Action<UILabel>(object:  TaskUIImposterModeScan.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeScan.<>c::丞丝丂七东丕丘丄丗(UILabel 三丟东丕丄丄下下丑));
        if(this.丝且与丝丒丟万丁专.scanLabels != null)
        {
            goto label_41;
        }
        
        goto label_41;
        label_18:
        if((2.241526E-38f) < 0)
        {
            goto label_42;
        }
        
        0.世丕丐丂丕丅一丅七();
        mem[88] = 1;
        goto label_43;
        label_42:
        float val_17 = UnityEngine.Time.unscaledDeltaTime;
        val_17 = (2.241526E-38f) + val_17;
        mem[160] = val_17;
        goto label_44;
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
