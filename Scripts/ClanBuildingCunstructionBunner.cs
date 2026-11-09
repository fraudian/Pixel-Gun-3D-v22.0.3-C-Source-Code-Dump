using UnityEngine;
internal sealed class ClanBuildingCunstructionBunner : SimpleBunner
{
    // Fields
    private PGCompany.InventoryItemView buildingItemView;
    private WidgetLayout investorsLayout;
    private ClanBuildingInvestorView investorViewExample;
    private ClanBuildingInvestorView investorViewTop;
    private ClanBuildingInvestmentView investmentView;
    private ClanBuildingGraphicView buildingGraphicView;
    private System.Collections.Generic.List<ClanBuildingInvestorView> 不丝七丅不丆丆万丕;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        this.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
        this.buildingItemView.Setup(与且专丈不万东一万:  上丟专三丙丅丆丛且);
        this.investmentView.丛不丈不丙丟不三上 = this.丛不丈不丙丟不三上;
        this.investmentView.丒丕三丌丒丑世丙丄 = 0;
        this.investmentView.UpdateView();
        this.buildingGraphicView.丛不丈不丙丟不三上 = this.丛不丈不丙丟不三上;
        this.buildingGraphicView.UpdateView();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.investmentView.专丞专丑万且三丒丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanBuildingCunstructionBunner::UpdateView()));
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingCunstructionBunner::不丞丙丟且丄东丌丛(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丑丒丝丒七丐与下丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingCunstructionBunner::不丞丙丟且丄东丌丛(int 丛丑丅丞丝丈丘丆三)));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.investmentView.丙丁丂不业丆丒东业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void ClanBuildingCunstructionBunner::UpdateView()));
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingCunstructionBunner::不丞丙丟且丄东丌丛(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丛丘丁世丄丑且丐丁(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingCunstructionBunner::不丞丙丟且丄东丌丛(int 丛丑丅丞丝丈丘丆三)));
    }
    public override void Show()
    {
        this.Show();
        this.UpdateView();
    }
    public void UpdateView()
    {
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  this.丛不丈不丙丟不三上.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                return;
        }
        
        this.investmentView.UpdateView();
        this.UpdateInrestorsView();
    }
    public void UpdateInrestorsView()
    {
        System.Collections.Generic.List<ClanBuildingInvestorView> val_12;
        var val_13;
        System.Func<丐丌丕丙专丑东丕丒, System.Int32> val_15;
        var val_16;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.investorViewTop, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.investorViewExample, 丏业丟一东丂东丘丛:  false);
        this.investorsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
        this.不丝七丅不丆丆万丕.Clear();
        val_12 = 1152921505146834944;
        val_13 = null;
        val_13 = null;
        val_15 = ClanBuildingCunstructionBunner.<>c.<>9__13_0;
        if(val_15 == null)
        {
                System.Func<丐丌丕丙专丑东丕丒, System.Int32> val_4 = null;
            val_15 = val_4;
            val_4 = new System.Func<丐丌丕丙专丑东丕丒, System.Int32>(object:  ClanBuildingCunstructionBunner.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanBuildingCunstructionBunner.<>c::东丗丌东世丝丞丟业(PGCompany.丕专丝与丐上丂东世.丐丌丕丙专丑东丕丒 三丟东丕丄丄下下丑));
            ClanBuildingCunstructionBunner.<>c.<>9__13_0 = val_15;
        }
        
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<丐丌丕丙专丑东丕丒>(source:  System.Linq.Enumerable.OrderByDescending<丐丌丕丙专丑东丕丒, System.Int32>(source:  PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().一三丝下丁丁东丑丛(丘丗丈东下业丟丟丑:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不()), keySelector:  val_4));
        val_16 = 0;
        goto label_24;
        label_28:
        if(val_16 == 0)
        {
            goto label_13;
        }
        
        if(this.investorsLayout != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        ClanBuildingInvestorView val_8 = UnityEngine.Object.Instantiate<ClanBuildingInvestorView>(original:  this.investorViewExample, parent:  this.investorsLayout.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_8.transform);
        val_8.Setup(丘丑丁业丝丝与下不:  val_6.Item[0]);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
        this.investorsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_8);
        val_12 = this.不丝七丅不丆丆万丕;
        val_12.Add(item:  val_8);
        val_16 = 1;
        goto label_24;
        label_13:
        if(this.investorsLayout != null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_24:
        if(val_16 < val_6.Count)
        {
            goto label_28;
        }
        
        this.investorsLayout.Reposition();
    }
    private void 不丞丙丟且丄东丌丛(int 丛丑丅丞丝丈丘丆三)
    {
        if(this.丛不丈不丙丟不三上 == null)
        {
                return;
        }
        
        if(this.丛不丈不丙丟不三上.业东丅东丌上丗丑不() != 丛丑丅丞丝丈丘丆三)
        {
                return;
        }
        
        this.UpdateView();
    }
    public ClanBuildingCunstructionBunner()
    {
        this.不丝七丅不丆丆万丕 = new System.Collections.Generic.List<ClanBuildingInvestorView>();
    }

}
