using UnityEngine;
private sealed class 丕与七丐丞丕丑业世.丒业丛丟专丛丒与东
{
    // Fields
    public string 丞一丁业丄一一业且;
    public System.Func<Rilisoft.OfferItem, bool> 上丌丘丑一且丆且丏;
    
    // Methods
    public 丕与七丐丞丕丑业世.丒业丛丟专丛丒与东()
    {
    
    }
    internal bool 丅丟专三丑丘丁七一(Rilisoft.OfferItem 丗丛丂且丕丆上世丛)
    {
        var val_7;
        if(丗丛丂且丕丆上世丛 == null)
        {
            goto label_0;
        }
        
        if((System.String.op_Equality(a:  丗丛丂且丕丆上世丛.Id, b:  this.丞一丁业丄一一业且)) == false)
        {
            goto label_1;
        }
        
        val_7 = 1;
        return (bool)val_7;
        label_0:
        val_7 = 0;
        return (bool)val_7;
        label_1:
        PGCompany.丗丟丄丈东丝丕丄世 val_5 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丐丆丅丝丂丄下业业(丄丗一三丟丘丞丐丌:  丗丛丂且丕丆上世丛.Id);
        if(val_5 == null)
        {
                return System.String.op_Equality(a:  val_5.业上丙丞丐丄丆丅七(), b:  this.丞一丁业丄一一业且);
        }
        
        return System.String.op_Equality(a:  val_5.业上丙丞丐丄丆丅七(), b:  this.丞一丁业丄一一业且);
    }

}
