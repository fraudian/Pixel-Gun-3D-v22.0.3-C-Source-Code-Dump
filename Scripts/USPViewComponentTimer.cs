using UnityEngine;
internal sealed class USPViewComponentTimer : SPViewComponentBase
{
    // Fields
    private PGCompany.TimerUI timerUI;
    private UnityEngine.GameObject timerHolder;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        this.丝丂丕东专世丅丝丁();
    }
    private void 丝丂丕东专世丅丝丁()
    {
        PGCompany.TimerUI val_9;
        System.Action val_10;
        int val_11;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timerHolder, 丏业丟一东丂东丘丛:  false);
        int val_9 = this.timerHolder.上丟丄与丁三丌丘专();
        val_9 = val_9 - PixelTime.丝丗专上三不丄丑丑();
        if((val_9 < 1) || (X21.上丟丄与丁三丌丘专() < 1))
        {
            goto label_8;
        }
        
        this.timerUI.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  "Key_10624");
        val_9 = this.timerUI;
        if(val_9 == null)
        {
            goto label_18;
        }
        
        System.Action val_4 = null;
        val_10 = val_4;
        val_4 = new System.Action(object:  this, method:  System.Void USPViewComponentTimer::业一上且丅丐世丁且());
        val_11 = val_9;
        goto label_11;
        label_8:
        int val_10 = val_9.下丒丗丄丌丘不丑丘();
        val_10 = (long)val_10 - PixelTime.丙三丝下丛丈丌丟下();
        if(val_10 < 1)
        {
                return;
        }
        
        this.timerUI.丏丗丐丝丞丆一丙与(下上丐丆丝丟丝丒不:  丅东万与丁一丐与三());
        val_9 = this.timerUI;
        if(val_9 == null)
        {
            goto label_18;
        }
        
        System.Action val_8 = null;
        val_10 = val_8;
        val_8 = new System.Action(object:  this, method:  System.Void USPViewComponentTimer::丝丂丕东专世丅丝丁());
        val_11 = val_10;
        label_11:
        val_9.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_11, 三丘丄丕丂丏东不丛:  val_8, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        label_18:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.timerHolder, 丏业丟一东丂东丘丛:  true);
    }
    public USPViewComponentTimer()
    {
    
    }
    private void 业一上且丅丐世丁且()
    {
        var val_2 = this;
        if(true == 0)
        {
                return;
        }
        
        var val_1 = (((mem[1103844756749] + (PGCompany.MainStore.下丐丒丙丂丁丗丘丘.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? true : 0;
    }

}
