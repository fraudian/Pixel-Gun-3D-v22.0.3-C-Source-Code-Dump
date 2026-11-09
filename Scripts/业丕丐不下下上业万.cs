using UnityEngine;
private sealed class 丌丟专丒丟丂万东丄.业丕丐不下下上业万
{
    // Fields
    public string 丞丅上丏丂且下丅与;
    
    // Methods
    public 丌丟专丒丟丂万东丄.业丕丐不下下上业万()
    {
    
    }
    internal bool 丝与丑丝丐丐丈丐丄(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上)
    {
        var val_8;
        System.Func<Rilisoft.OfferItem, System.String> val_10;
        var val_11;
        System.Func<System.String, System.String, System.String> val_13;
        Progress.OfferProgress val_1 = 丄三丅七丆丛与与上.业丑丁丆丕丆丂丅万();
        if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_1.PreparedItems)) == false)
        {
                return false;
        }
        
        Progress.OfferProgress val_3 = 丄三丅七丆丛与与上.业丑丁丆丕丆丂丅万();
        val_8 = null;
        val_8 = null;
        val_10 = 丌丟专丒丟丂万东丄.<>c.<>9__40_8;
        if(val_10 == null)
        {
                System.Func<Rilisoft.OfferItem, System.String> val_4 = null;
            val_10 = val_4;
            val_4 = new System.Func<Rilisoft.OfferItem, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::丗丞下三丄万丐丕丞(Rilisoft.OfferItem 丛丅丐丒丈不丅丐丄));
            丌丟专丒丟丂万东丄.<>c.<>9__40_8 = val_10;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = 丌丟专丒丟丂万东丄.<>c.<>9__40_9;
        if(val_13 != null)
        {
                return System.String.op_Equality(a:  System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_3.PreparedItems, selector:  val_4), func:  System.Func<System.String, System.String, System.String> val_6 = null), b:  this.丞丅上丏丂且下丅与);
        }
        
        val_13 = val_6;
        val_6 = new System.Func<System.String, System.String, System.String>(object:  丌丟专丒丟丂万东丄.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丌丟专丒丟丂万东丄.<>c::丌丆一丕丏业丐丟上(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
        丌丟专丒丟丂万东丄.<>c.<>9__40_9 = val_13;
        return System.String.op_Equality(a:  System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.OfferItem, System.String>(source:  val_3.PreparedItems, selector:  val_4), func:  val_6), b:  this.丞丅上丏丂且下丅与);
    }

}
