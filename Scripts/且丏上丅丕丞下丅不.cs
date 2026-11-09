using UnityEngine;
private sealed class SabotageImposterModeController.且丏上丅丕丞下丅不 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SabotageImposterModeController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SabotageImposterModeController.且丏上丅丕丞下丅不(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SabotageImposterModeController val_20;
        var val_21;
        InGameGUI val_22;
        int val_23;
        var val_24;
        var val_25;
        float val_26;
        var val_27;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_21 = 1152921505219145728;
        val_20 = this.丝且与丝丒丟万丁专;
        val_22 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_22 == 0)
        {
            goto label_4;
        }
        
        val_22 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 856];
        val_22 = InGameGUI.丙丞专丌丁丞与不丐.丙下丆与丁丘丙丕丙;
        if(val_22 != 0)
        {
            goto label_8;
        }
        
        label_4:
        val_23 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_23;
        label_8:
        val_24 = 0;
        goto label_10;
        label_24:
        SabotageTask val_3 = this.丝且与丝丒丟万丁专.sabotageTasks.Item[0];
        SabotageTask val_5 = this.丝且与丝丒丟万丁专.sabotageTasks.Item[0];
        val_5.localizationText = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3.localizationKey)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3.localizationKey)) + " {0}/{1}"(" {0}/{1}");
        SabotageTask val_7 = this.丝且与丝丒丟万丁专.sabotageTasks.Item[0];
        if(val_7.sabotageType == 3)
        {
                SabotageTask val_8 = this.丝且与丝丒丟万丁专.sabotageTasks.Item[0];
            val_8.roomIndex = 1;
        }
        
        val_24 = 1;
        label_10:
        if(val_24 < this.丝且与丝丒丟万丁专.sabotageTasks.Count)
        {
            goto label_24;
        }
        
        丗业丏丏丆丄丗丗且(一下下万专丒丞丅丈:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_20, 丛丌丙世专世东丕下:  System.Void SabotageImposterModeController::丏专世且不丘丞一丙())));
        EventDelegate val_13 = null;
        val_22 = val_13;
        val_13 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_20, 丛丌丙世专世东丕下:  System.Void SabotageImposterModeController::丏业丝上丅一东业一()));
        丗业丏丏丆丄丗丗且(一下下万专丒丞丅丈:  val_13);
        val_25 = 0;
        goto label_33;
        label_39:
        SabotageImposterModeController.丐丐七丈丅丐三且丆 val_14 = new SabotageImposterModeController.丐丐七丈丅丐三且丆();
        if(val_14 != null)
        {
                .丝且与丝丒丟万丁专 = val_20;
        }
        else
        {
                mem[24] = val_20;
        }
        
        int val_20 = 1;
        .丟丐世一丗三万丂丛 = val_20;
        val_20 = val_20 - 1;
        EventDelegate val_17 = null;
        val_22 = val_17;
        val_17 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  val_14, 丛丌丙世专世东丕下:  System.Void SabotageImposterModeController.丐丐七丈丅丐三且丆::不丐丘七丈万下一下()));
        Item[val_20].丗业丏丏丆丄丗丗且(一下下万专丒丞丅丈:  val_17);
        val_25 = val_20 + 1;
        label_33:
        if(val_25 < Count)
        {
            goto label_39;
        }
        
        if(val_20 != null)
        {
                val_26 = this.丝且与丝丒丟万丁专._startSabotageLockTime;
        }
        else
        {
                val_26 = 8.96831E-44f;
        }
        
        0.丂与上不丂丑一丐东(丂丅丄丈下与一丌丆:  val_26);
        val_21 = 1152921525882305648;
        val_27 = 0;
        goto label_42;
        label_46:
        val_22 = this.丝且与丝丒丟万丁专.不丞丆丐丛三丝丏与;
        val_22.Add(item:  0);
        val_27 = 1;
        label_42:
        if(val_27 < Count)
        {
            goto label_46;
        }
        
        label_1:
        val_23 = 0;
        return (bool)val_23;
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
