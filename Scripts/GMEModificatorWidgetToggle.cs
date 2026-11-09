using UnityEngine;
internal sealed class GMEModificatorWidgetToggle : GMEModificatorWidget
{
    // Fields
    protected UnityEngine.GameObject toggleYesIcon;
    protected UnityEngine.GameObject toggleNoIcon;
    
    // Methods
    private void 业专丂丒丏上丈不不(bool 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        this.toggleYesIcon.SetActive(value:  三丟东丕丄丄下下丑);
        this.toggleNoIcon.SetActive(value:  (~三丟东丕丄丄下下丑) & 1);
    }
    protected override void 丝丂不不世丈丏丟不()
    {
        if((W8 - 3) > 19)
        {
                return;
        }
        
        var val_2 = 106016016 + ((W8 - 3)) << 2;
        val_2 = val_2 + 106016016;
        goto (106016016 + ((W8 - 3)) << 2 + 106016016);
    }
    protected override void 丁丅丏丈七下丁丝丞()
    {
        if(==0)
        {
                return;
        }
        
        if((不业丙丒丂丞下丆丙() - 3) > 19)
        {
                return;
        }
        
        var val_10 = 106016096 + ((val_1 - 3)) << 2;
        val_10 = val_10 + 106016096;
        goto (106016096 + ((val_1 - 3)) << 2 + 106016096);
    }
    public GMEModificatorWidgetToggle()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
