using UnityEngine;
private sealed class FreeplayModeVehicleController.专丆一丈东东丄下业 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public FreeplayModeVehicleController 丝且与丝丒丟万丁专;
    public TransportControllerBase 丝丘下丄丈丗丈丄丘;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FreeplayModeVehicleController.专丆一丈东东丄下业(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        InGameGUI val_12;
        TransportControllerBase val_13;
        string val_14;
        InGameGUIPart_Freeplay val_15;
        var val_16;
        System.Func<System.Boolean> val_18;
        val_12 = this;
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
            goto label_28;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三 == 0)
        {
            goto label_7;
        }
        
        val_13 = val_12;
        if(this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三 == this.丝丘下丄丈丗丈丄丘)
        {
            goto label_11;
        }
        
        this.丝且与丝丒丟万丁专.专丆丕丝丝丛世丄上();
        goto label_11;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12768"), arg0:  丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三.不丞丒下丕丙东东且));
        goto label_18;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        丘三丘丁专丆业丄业(丝丘下丄丈丗丈丄丘:  this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三);
        val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10418");
        if(this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三 != 1)
        {
            goto label_25;
        }
        
        label_18:
        val_12 = InGameGUI.丙丞专丌丁丞与不丐;
        val_15 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_15 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(null == 0)
        {
                return (bool)val_15;
        }
        
        上与丙丄丛七三下丐(丕丗丘丑丛与丑业丒:  val_14);
        goto label_28;
        label_7:
        val_13 = this.丝丘下丄丈丗丈丄丘;
        label_11:
        val_14 = this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三;
        if(val_14 != mem[this.丝丘下丄丈丗丈丄丘])
        {
            goto label_31;
        }
        
        label_28:
        val_15 = 0;
        return (bool)val_15;
        label_25:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  this.丝且与丝丒丟万丁专, method:  System.Boolean FreeplayModeVehicleController::一下不丅业丙丏下丁()));
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_15;
        label_31:
        this.丝且与丝丒丟万丁专.丑丙不丗丝万丌丒三 = mem[this.丝丘下丄丈丗丈丄丘];
        this.丝且与丝丒丟万丁专.丘世下丄丐丏专与三(不下业丞丌世专且丈:  mem[this.丝丘下丄丈丗丈丄丘], 专丝与业专万丘一不:  true);
        val_16 = null;
        val_16 = null;
        val_18 = FreeplayModeVehicleController.<>c.<>9__23_0;
        if(val_18 == null)
        {
                System.Func<System.Boolean> val_10 = null;
            val_18 = val_10;
            val_10 = new System.Func<System.Boolean>(object:  FreeplayModeVehicleController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreeplayModeVehicleController.<>c::丘丟业丙丕七丅丑丝());
            FreeplayModeVehicleController.<>c.<>9__23_0 = val_18;
        }
        
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  val_10);
        this.丗丏丅丕丆世丁专丟 = 1;
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
