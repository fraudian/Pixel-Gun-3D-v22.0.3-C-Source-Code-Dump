using UnityEngine;
internal sealed class GMEModificatorWidgetGuns : GMEModificatorWidget
{
    // Fields
    private UnityEngine.GameObject[] gunTogglers;
    
    // Methods
    protected override void 丁丅丏丈七下丁丝丞()
    {
        var val_5;
        var val_6;
        if(==0)
        {
                return;
        }
        
        if(不业丙丒丂丞下丆丙() != 7)
        {
                return;
        }
        
        System.Collections.Generic.List<CategoryNames> val_2 = 丛丅下丆丗丏三丁丕<System.Collections.Generic.List<CategoryNames>>(丒丑丂丐丕丒丕东与:  "custom");
        val_5 = 0;
        goto label_3;
        label_7:
        this.gunTogglers[0].SetActive(value:  false);
        val_5 = 1;
        label_3:
        if(val_5 < this.gunTogglers.Length)
        {
            goto label_7;
        }
        
        val_6 = 0;
        goto label_8;
        label_14:
        this.gunTogglers[(long)val_2.Item[0]].SetActive(value:  true);
        val_6 = 1;
        label_8:
        if(val_6 < val_2.Count)
        {
            goto label_14;
        }
    
    }
    protected override void 丝丂不不世丈丏丟不()
    {
        var val_1;
        if(W8 != 7)
        {
                return;
        }
        
        val_1 = 0;
        goto label_1;
        label_5:
        this.gunTogglers[0].SetActive(value:  true);
        val_1 = 1;
        label_1:
        if(val_1 < this.gunTogglers.Length)
        {
            goto label_5;
        }
    
    }
    public GMEModificatorWidgetGuns()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
