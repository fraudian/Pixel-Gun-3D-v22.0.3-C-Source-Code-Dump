using UnityEngine;
internal sealed class GMEModificatorWidgetNumber : GMEModificatorWidget
{
    // Fields
    private UILabel value;
    
    // Methods
    private void Update()
    {
        if(this.value.supportEncoding != false)
        {
                return;
        }
        
        this.value.supportEncoding = true;
    }
    protected override void 丁丅丏丈七下丁丝丞()
    {
        int val_6;
        if(==0)
        {
                return;
        }
        
        this.value.supportEncoding = true;
        ModificatorType val_1 = 不业丙丒丂丞下丆丙();
        if(val_1 <= 2)
        {
            goto label_3;
        }
        
        if((val_1 == 11) || (val_1 == 10))
        {
            goto label_5;
        }
        
        label_8:
        val_6 = 0;
        goto label_6;
        label_3:
        if(val_1 == 1)
        {
            goto label_7;
        }
        
        if(val_1 != 2)
        {
            goto label_8;
        }
        
        label_5:
        float val_2 = 丛丅下丆丗丏三丁丕<System.Single>(丒丑丂丐丕丒丕东与:  "float");
        goto label_9;
        label_7:
        label_9:
        float val_6 = 100f;
        val_6 = (GravitySetter.世丕丅丕七万丕丘丛(丂丂丑世丟世丂丂丛:  丛丅下丆丗丏三丁丕<System.Single>(丒丑丂丐丕丒丕东与:  "float"))) * val_6;
        val_6 = UnityEngine.Mathf.RoundToInt(f:  val_6);
        label_6:
        this.丄丄与丌丁三不丅三(丗与丘不且万丟丙丑:  val_6);
    }
    protected override void 丝丂不不世丈丏丟不()
    {
        int val_3;
        if(true <= 2)
        {
            goto label_1;
        }
        
        if((true == 11) || (true == 10))
        {
            goto label_9;
        }
        
        label_6:
        val_3 = 0;
        goto label_4;
        label_1:
        if(true == 1)
        {
            goto label_5;
        }
        
        if(true != 2)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        float val_3 = 100f;
        val_3 = (GravitySetter.世丕丅丕七万丕丘丛(丂丂丑世丟世丂丂丛:  1f)) * val_3;
        label_9:
        val_3 = UnityEngine.Mathf.RoundToInt(f:  val_3);
        label_4:
        this.丄丄与丌丁三不丅三(丗与丘不且万丟丙丑:  val_3);
    }
    private void 丄丄与丌丁三不丅三(int 丗与丘不且万丟丙丑)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.value, 丕丗丘丑丛与丑业丒:  丗与丘不且万丟丙丑 + " %"(" %"));
    }
    public GMEModificatorWidgetNumber()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
