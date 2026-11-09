using UnityEngine;
internal sealed class PixelPassTaskCellViewElite : PixelPassTaskCellViewBase
{
    // Fields
    private SimpleProgressBarWithAnimation _progressBar;
    
    // Methods
    internal override void 丝一丅丆三东丂丞七()
    {
        var val_6;
        System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_8;
        val_6 = null;
        val_6 = null;
        val_8 = PixelPassTaskCellViewElite.<>c.<>9__1_0;
        if(val_8 == null)
        {
                System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_2 = null;
            val_8 = val_2;
            val_2 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  PixelPassTaskCellViewElite.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTaskCellViewElite.<>c::东丞丟丙不丕不丑丁(PGCompany.PixelPass.一万丄一丌丆业丐丅 三丟东丕丄丄下下丑));
            PixelPassTaskCellViewElite.<>c.<>9__1_0 = val_8;
        }
        
        this._progressBar.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  0, 丑丒丒丅七丞东丟丕:  System.Linq.Enumerable.Count<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  X21.与丑丛下且专七万丄(), predicate:  val_2), 七丝东丛东丝且丆不:  val_2.与丑丛下且专七万丄().Count, 丈世万丙丟东与丕丞:  false);
        this.丝一丅丆三东丂丞七();
    }
    public PixelPassTaskCellViewElite()
    {
        val_1 = new PGBehaviour();
    }

}
