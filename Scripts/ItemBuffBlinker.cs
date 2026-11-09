using UnityEngine;
internal sealed class ItemBuffBlinker : PGBehaviour
{
    // Fields
    private ItemListUI itemListUI;
    
    // Methods
    private void OnEnable()
    {
        PGCompany.ClanWarUIRewardsAnimator.万丏丑丞万丟丒丗一(丙业与丙丗丝不丈东:  new System.Action<上七丑业丙丒丙东丏>(object:  this, method:  System.Void ItemBuffBlinker::丛三丞丏一丈丁丝三(上七丑业丙丒丙东丏 三丅丘上丞一丙丑业)));
        PGCompany.ClanWarRewardsUI.不丂东丑丏上丘丏东(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(object:  this, method:  System.Void ItemBuffBlinker::万丅丏一丑东丂丏且(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)));
    }
    private void OnDisable()
    {
        PGCompany.ClanWarUIRewardsAnimator.专不丁丌丘丁丒丟万(丙业与丙丗丝不丈东:  new System.Action<上七丑业丙丒丙东丏>(object:  this, method:  System.Void ItemBuffBlinker::丛三丞丏一丈丁丝三(上七丑业丙丒丙东丏 三丅丘上丞一丙丑业)));
        PGCompany.ClanWarRewardsUI.丆丟丏丂世丞一丌丘(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>(object:  this, method:  System.Void ItemBuffBlinker::万丅丏一丑东丂丏且(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)));
    }
    internal void 丛三丞丏一丈丁丝三(上七丑业丙丒丙东丏 三丅丘上丞一丙丑业)
    {
        PGCompany.三东丏不丗世丅丌丄 val_3;
        if(三丅丘上丞一丙丑业 == 1)
        {
                PGCompany.三东丏不丗世丅丌丄 val_1 = null;
            val_3 = val_1;
            val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  40, 丞丅上丏丂且下丅与:  "clan_silver_buff");
        }
        else
        {
                val_3 = 0;
        }
        
        bool val_2 = this.世丅丟专丄丘万丒丟(丈丄不七三万丄丁不:  val_3);
    }
    internal void 万丅丏一丑东丂丏且(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        this.世丅丟专丄丘万丒丟(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
    }
    internal void 世丅丟专丄丘万丒丟(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
    {
        var val_4 = this;
        List.Enumerator<T> val_1 = 丈丄不七三万丄丁不.GetEnumerator();
        label_3:
        if((2121639256 & 1) == 0)
        {
            goto label_2;
        }
        
        bool val_3 = this.世丅丟专丄丘万丒丟(丈丄不七三万丄丁不:  0.丐丏七丌丕丗业且上());
        goto label_3;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal bool 世丅丟专丄丘万丒丟(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
    {
        var val_4;
        PGCompany.InventoryItemView val_1 = this.itemListUI.丐丞丂三丝丝上丌丈(丈丄不七三万丄丁不:  丈丄不七三万丄丁不);
        if(val_1 != 0)
        {
                PGTweener val_3 = val_1.GetComponent<PGTweener>();
            if(val_3 != null)
        {
                val_3.丗万丞丒东万丂丛三();
        }
        
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public ItemBuffBlinker()
    {
    
    }

}
