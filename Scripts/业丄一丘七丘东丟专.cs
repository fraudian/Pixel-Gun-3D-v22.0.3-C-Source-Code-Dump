using UnityEngine;
internal class 丂上丙丐丞业丌丕丗.业丄一丘七丘东丟专 : 业且丗丐丛丆丈丙丈
{
    // Methods
    public bool 东一三一万且丕世不(PGCompany.三东丏不丗世丅丌丄 丗丟上上丒丐丗丞丙)
    {
        PGCompany.三东丏不丗世丅丌丄 val_12;
        var val_13;
        val_12 = 丗丟上上丒丐丗丞丙;
        if(val_12 == null)
        {
            goto label_11;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_12, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
        {
            goto label_3;
        }
        
        三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  val_12.业东丅东丌上丗丑不());
        if(val_4 == null)
        {
            goto label_11;
        }
        
        val_12 = val_12.丂丁丏一丙丛业且丌();
        if((val_12 + (Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_4.与不丞丑七丘丁丂丛()))) <= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_4.三与丛丑且丐丈业丌())))
        {
            goto label_11;
        }
        
        label_3:
        val_13 = 1;
        return (bool)val_13;
        label_11:
        val_13 = 0;
        return (bool)val_13;
    }
    public 丂上丙丐丞业丌丕丗.业丄一丘七丘东丟专()
    {
    
    }

}
