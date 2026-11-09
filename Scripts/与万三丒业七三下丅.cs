using UnityEngine;
private sealed class ClanStoreBuffsController.与万三丒业七三下丅 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.三东丏不丗世丅丌丄 不且丐一丆丛丙丙丒;
    public PGCompany.ClanStoreBuffsController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanStoreBuffsController.与万三丒业七三下丅(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        System.Action<PGCompany.三东丏不丗世丅丌丄> val_16;
        var val_17;
        int val_18;
        var val_19;
        val_16 = 0;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
                return (bool)val_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
        if(((-2136889392) & 1) != 0)
        {
                val_17 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丌丐下丌丘下丝丞业>(丈丄不七三万丄丁不:  this.不且丐一丆丛丙丙丒, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_17 == null)
        {
                return (bool)val_16;
        }
        
            val_18 = val_17.业东丅东丌上丗丑不();
            if((this.丝且与丝丒丟万丁专.丂丑丙不万与丁丗丑.ContainsKey(key:  val_18)) != false)
        {
                val_18 = val_17.业东丅东丌上丗丑不();
            PGCompany.ClanStoreBuffSetting val_7 = this.丝且与丝丒丟万丁专.丂丑丙不万与丁丗丑.Item[val_18];
            if(((-2136889512) & 1) != 0)
        {
                val_18 = val_17.丕不丐专丒专下下丗();
            PGCompany.ClanStoreBuffSetting val_11 = this.丝且与丝丒丟万丁专.丂丑丙不万与丁丗丑.Item[val_17.业东丅东丌上丗丑不()];
            val_17 = val_12;
            this.丝且与丝丒丟万丁专.且丅丕东下丁丐且三(丞世不丒下上上丝丑:  val_17.业东丅东丌上丗丑不(), 专丌万丑三丙丕丙丝:  val_18, 丆丂七丈丝丅丟丕丌:  val_17.Count - 1);
            val_19 = null;
            val_19 = null;
            val_16 = PGCompany.ClanStoreBuffsController.丞丅丂丁丟东丟丝七;
            if(val_16 == null)
        {
                return (bool)val_16;
        }
        
            val_16.Invoke(obj:  this.不且丐一丆丛丙丙丒);
        }
        
        }
        
            val_16 = 0;
            return (bool)val_16;
        }
        
        val_16 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
