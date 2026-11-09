using UnityEngine;
private sealed class 丙专一丛丞丕七不丌.丒丂丈东丗丁丁上且
{
    // Fields
    public int 丙丂丏丛丌丏下丝不;
    public Rilisoft.Offers.丙专一丛丞丕七不丌.世世丝丏丙丞丙丏丁 东丟且丗且三专丙丁;
    
    // Methods
    public 丙专一丛丞丕七不丌.丒丂丈东丗丁丁上且()
    {
    
    }
    internal bool 丕下下丅丅丙丟丝丝(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟 val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        if(丆丐七世世且丏丐业.七丙丛与万且专三三() > this.丙丂丏丛丌丏下丝不)
        {
                return (bool)0 & 1;
        }
        
        val_26 = this.东丟且丗且三专丙丁.东东世专不万丁丌丈;
        if(丆丐七世世且丏丐业 != this.东丟且丗且三专丙丁.东东世专不万丁丌丈.且丐丟专丛丗丏上丙)
        {
                return (bool)0 & 1;
        }
        
        val_26 = 丆丐七世世且丏丐业.三与丛丑且丐丈业丌();
        if((WeaponManager.上丙上万七丆丐丆业().Contains(item:  val_26)) == true)
        {
                return (bool)0 & 1;
        }
        
        val_27 = null;
        val_27 = null;
        val_26 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  val_26)) == true)
        {
                return (bool)0 & 1;
        }
        
        if(丆丐七世世且丏丐业.东七与与不丅丙上上() == true)
        {
                return (bool)0 & 1;
        }
        
        val_26 = 丆丐七世世且丏丐业.三与丛丑且丐丈业丌();
        if((WeaponManager.丞上一丘丆三下丐丑().Contains(item:  val_26)) == true)
        {
                return (bool)0 & 1;
        }
        
        val_28 = null;
        val_28 = null;
        val_26 = 丆丐七世世且丏丐业.与不丞丑七丘丁丂丛();
        if((WeaponManager.丟丗丄业丘丗业丗七.丐丂丁丟丘世丝丁丐(丒丝丄丅丒丘丏丕与:  val_26)) == true)
        {
                return (bool)0 & 1;
        }
        
        val_26 = 丆丐七世世且丏丐业.业东丅东丌上丗丑不();
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_26)) != null)
        {
                return (bool)0 & 1;
        }
        
        val_29 = null;
        val_29 = null;
        if((System.String.op_Inequality(a:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), b:  WeaponManager.丙丟丂丗丛丟丑东丑)) != false)
        {
                if((System.Linq.Enumerable.Contains<System.Int32>(source:  Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丌丙丘专丁且一世一().Keys, value:  丆丐七世世且丏丐业.业东丅东丌上丗丑不())) == false)
        {
            goto label_35;
        }
        
        }
        
        return (bool)0 & 1;
        label_35:
        val_30 = null;
        val_30 = null;
        bool val_26 = (WeaponManager.丂丒丒丘上丁丘丕丐.Contains(item:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛())) ^ 1;
        return (bool)0 & 1;
    }

}
