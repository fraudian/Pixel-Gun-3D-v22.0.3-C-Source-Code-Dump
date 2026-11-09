using UnityEngine;
private sealed class 丕与七丐丞丕丑业世.丛东丟丅丙丗世丗不
{
    // Fields
    public string 丞一丁业丄一一业且;
    public System.Func<Rilisoft.OfferItem, bool> 丙丕丗万丑丗丈丟专;
    
    // Methods
    public 丕与七丐丞丕丑业世.丛东丟丅丙丗世丗不()
    {
    
    }
    internal bool 世与丝万丟丗专丒丆(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)
    {
        System.Func<Rilisoft.OfferItem, System.Boolean> val_4;
        var val_5;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = 丄三丅七丆丛与与上.丏与丅专三丙与丘丒();
        if(val_1 != null)
        {
                val_4 = this.丙丕丗万丑丗丈丟专;
            if(val_4 == null)
        {
                System.Func<Rilisoft.OfferItem, System.Boolean> val_2 = null;
            val_4 = val_2;
            val_2 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  this, method:  System.Boolean 丕与七丐丞丕丑业世.丛东丟丅丙丗世丗不::东丕丕丂丅丆丛丗三(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            this.丙丕丗万丑丗丈丟专 = val_4;
        }
        
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_1, predicate:  val_2)) != false)
        {
                val_5 = 1;
            return (bool)val_5;
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal bool 东丕丕丂丅丆丛丗三(Rilisoft.OfferItem 七丞丙丒三丕且丌丟)
    {
        if(七丞丙丒三丕且丌丟 == null)
        {
                return false;
        }
        
        return System.String.op_Equality(a:  七丞丙丒三丕且丌丟.Id, b:  this.丞一丁业丄一一业且);
    }

}
