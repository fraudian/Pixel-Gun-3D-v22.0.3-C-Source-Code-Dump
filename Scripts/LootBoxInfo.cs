using UnityEngine;
internal sealed class LootBoxInfo : PGBehaviour
{
    // Fields
    private ItemLootBoxView lootBoxView;
    private LootBoxRewardsView lootBoxRewardsView;
    private System.Action 丒且丐专丅一世上七;
    
    // Methods
    internal void 丐丂与丑丈下不不下(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丒且丐专丅一世上七, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒且丐专丅一世上七 != 1152921537707862728);
    
    }
    internal void 丒丅与丙七东丅丅丙(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丒且丐专丅一世上七, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丒且丐专丅一世上七 != 1152921537707999304);
    
    }
    public void Setup(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        if(丈丄不七三万丄丁不.不业丙丒丂丞下丆丙() != 1460)
        {
                return;
        }
        
        this.Setup(丞丘丞丏业且丛丏丘:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.一三丛丅丌丒丙丆一>(丈丄不七三万丄丁不:  丈丄不七三万丄丁不));
    }
    public void Setup(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
    {
        if((丞丘丞丏业且丛丏丘 != null) && (丞丘丞丏业且丛丏丘.不业丙丒丂丞下丆丙() == 1460))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lootBoxView, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lootBoxRewardsView, 丏业丟一东丂东丘丛:  true);
            PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_3 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  丞丘丞丏业且丛丏丘.丑丐丙丄丅世世丑丒(), 与不丕丆丈不丙丟丛:  0);
            this = ???;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9 + 72, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9 + 80, 丏业丟一东丂东丘丛:  false);
        }
    
    }
    public void U_Hide()
    {
        if(this.丒且丐专丅一世上七 == null)
        {
                return;
        }
        
        this.丒且丐专丅一世上七.Invoke();
    }
    public LootBoxInfo()
    {
    
    }

}
