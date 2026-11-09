using UnityEngine;
internal class USPViewComponentLootBox : SPViewComponentBase
{
    // Fields
    private ItemLootBoxView lootBoxView;
    private LootBoxRewardsView lootBoxRewardsView;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        var val_14;
        var val_15;
        System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_17;
        ItemLootBoxView val_18;
        var val_19;
        var val_20;
        val_14 = this;
        this.Setup(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁);
        val_15 = null;
        val_15 = null;
        val_17 = USPViewComponentLootBox.<>c.<>9__2_0;
        if(val_17 == null)
        {
                System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_1 = null;
            val_17 = val_1;
            val_1 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  USPViewComponentLootBox.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean USPViewComponentLootBox.<>c::七丅世不业且丒丗业(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
            USPViewComponentLootBox.<>c.<>9__2_0 = val_17;
        }
        
        val_18 = this.lootBoxView;
        val_19 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.一三丛丅丌丒丙丆一>(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  且丘丏丁丑与丙与丁, predicate:  val_1));
        val_20 = null;
        if(val_19 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lootBoxRewardsView, 丏业丟一东丂东丘丛:  true);
            PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_6 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  val_19.丑丐丙丄丅世世丑丒(), 与不丕丆丈不丙丟丛:  0);
            val_14 = ???;
            val_18 = ???;
            val_19 = ???;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_14 + 88, 丏业丟一东丂东丘丛:  false);
        }
    
    }
    public USPViewComponentLootBox()
    {
    
    }

}
