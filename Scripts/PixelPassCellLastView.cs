using UnityEngine;
internal sealed class PixelPassCellLastView : PixelPassCellBaseView
{
    // Fields
    private SimpleProgressBarWithAnimation _brogressBar;
    private UnityEngine.GameObject reached;
    
    // Methods
    internal override void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丅丌丆丁世一丙丑丐)
    {
        this.丈且东丑丂且万丒丅(丅丌丆丁世一丙丑丐:  丅丌丆丁世一丙丑丐);
        if(this._brogressBar != null)
        {
                int val_1 = X21.丂丂下丑且下丌丝东();
            this._brogressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  val_1, 七丝东丛东丝且丆不:  X22.丗丏丆丂专东丆三丑(), 丈世万丙丟东与丕丞:  false);
        }
        
        this.reached.SetActive(value:  (val_1.丂丂下丑且下丌丝东() >= val_1.丗丏丆丂专东丆三丑()) ? 1 : 0);
    }
    public PixelPassCellLastView()
    {
        mem[1152921538558483416] = 200;
        val_1 = new PGBehaviour();
    }

}
