using UnityEngine;
private sealed class TaskUIImposterModeEmergencyButton.丆丗且下丈七丛丌丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TaskUIImposterModeEmergencyButton 丝且与丝丒丟万丁专;
    private double 丏丐丌丏丗丈丂丈丞;
    private string 不丁业三丘且不丁与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TaskUIImposterModeEmergencyButton.丆丗且下丈七丛丌丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_8;
        var val_9;
        double val_10;
        string val_11;
        var val_12;
        object val_13;
        var val_14;
        int val_15;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_9 = null;
        val_9 = null;
        if(GameController.mode != null)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        label_6:
        var val_1 = (null == null) ? GameController.mode : 0;
        val_10 = val_8;
        this.丏丐丌丏丗丈丂丈丞 = mode == null ? GameController.mode : 0 + 592;
        this.不丁业三丘且不丁与 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10192");
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_10 = this.丏丐丌丏丗丈丂丈丞;
        label_9:
        float val_9 = ImposterVoteController.丘丅业丗丌丒万丒丙();
        double val_8 = (double)val_9;
        val_8 = val_10 + val_8;
        val_9 = val_8 - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(val_9 >= 0)
        {
            goto label_14;
        }
        
        val_11 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10190");
        this.不丁业三丘且不丁与 = val_11;
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_11 = this.不丁业三丘且不丁与;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 480];
        val_13 = typeof(Player_move_c).__il2cppRuntimeField_628 + 480;
        val_14 = null;
        val_14 = null;
        this.丝且与丝丒丟万丁专.statusLabel.text = System.String.Format(format:  val_11, arg0:  val_13, arg1:  PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丂专丁丝丂丒东七上);
        val_8 = this.丝且与丝丒丟万丁专.canBePressed;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.cannotBePressed, 丏业丟一东丂东丘丛:  false);
        label_2:
        val_15 = 0;
        return (bool)val_15;
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.canBePressed, 丏业丟一东丂东丘丛:  false);
        val_15 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.cannotBePressed, 丏业丟一东丂东丘丛:  true);
        val_13 = this.丝且与丝丒丟万丁专.statusLabel;
        val_13.text = System.String.Format(format:  this.不丁业三丘且不丁与, arg0:  (int)val_9);
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_15;
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
