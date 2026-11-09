using UnityEngine;
private sealed class 七丏丛丐三丐专丌东.不丞丛丑万丗丏丄丟
{
    // Fields
    public PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘;
    public System.Predicate<PGCompany.三东丏不丗世丅丌丄> 丗三丝不且丏丒丟且;
    
    // Methods
    public 七丏丛丐三丐专丌东.不丞丛丑万丗丏丄丟()
    {
    
    }
    internal bool 丒丕丄丞丅丘丑万世(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = 丌丝万上丅丒一丈丘.丈丏丁东上与东丙丕();
        if(this.丗三丝不且丏丒丟且 != null)
        {
                if(val_1 == null)
        {
                return val_1.Exists(match:  this.丗三丝不且丏丒丟且);
        }
        
            return val_1.Exists(match:  this.丗三丝不且丏丒丟且);
        }
        
        this.丗三丝不且丏丒丟且 = new System.Predicate<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Boolean 七丏丛丐三丐专丌东.不丞丛丑万丗丏丄丟::丈丂丒丄丙万丞与丒(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七));
        if(val_1 != null)
        {
                return val_1.Exists(match:  this.丗三丝不且丏丒丟且);
        }
        
        return val_1.Exists(match:  this.丗三丝不且丏丒丟且);
    }
    internal bool 丈丂丒丄丙万丞与丒(PGCompany.三东丏不丗世丅丌丄 下丅丙一丂丗丅丝七)
    {
        var val_4;
        var val_5;
        val_4 = this;
        if(下丅丙一丂丗丅丝七 != null)
        {
                val_4 = 下丅丙一丂丗丅丝七.业东丅东丌上丗丑不();
            var val_3 = (val_4 == this.丞丘丞丏业且丛丏丘.业东丅东丌上丗丑不()) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }

}
