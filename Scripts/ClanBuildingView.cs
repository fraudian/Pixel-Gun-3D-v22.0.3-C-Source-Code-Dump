using UnityEngine;
internal sealed class ClanBuildingView : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView buildingItemView;
    private WidgetLayoutConstrained widgetLayoutConstrained;
    private ClanBuildingInfoBunner buildingInfoBunner;
    private ClanBuildingCunstructionBunner cunstructionBunner;
    private UILabel notBuilt_Label;
    private UILabel building_Label;
    private UISprite building_Bar;
    private UILabel built_Label;
    private UISprite built_Bar;
    private UILabel needUpgrade_Label;
    private UILabel buildingLocked_Label;
    private UnityEngine.GameObject getPartsButton;
    private ClanBuildingEnterButton enterButton;
    private UnityEngine.GameObject startBuildButton;
    private UnityEngine.GameObject speedUpBuildButton;
    private ClanBuildingGraphicView buildingGraphicView;
    private UnityEngine.GameObject state_notBuilt;
    private UnityEngine.GameObject state_building;
    private UnityEngine.GameObject state_built;
    private UnityEngine.GameObject state_needUpgrade;
    private UnityEngine.GameObject state_buildingLocked;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    private ClanBuildingView.丙丙世七丆丝七丗丐 丝丘丆世丞上丆丙丑;
    private ClanBuildingView.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    
    // Methods
    private void OnEnable()
    {
        this.UpdateView();
        PGCompany.丒丂丘丐万三且丌丐.丆世一丒丕上丈东一(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingView::丈丈业丝丄七丏与一(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingView::丈丈业丝丄七丏与一(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丑丒丝丒七丐与下丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingView::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
    }
    private void OnDisable()
    {
        PGCompany.丒丂丘丐万三且丌丐.丅丒丘上丞不下丐丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingView::丈丈业丝丄七丏与一(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingView::丈丈业丝丄七丏与一(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丛丘丁世丄丑且丐丁(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingView::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        this.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
        this.buildingGraphicView.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
        this.buildingGraphicView.UpdateView();
        this.UpdateView();
    }
    public void UpdateView()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        if(this.丛不丈不丙丟不三上 == null)
        {
                return;
        }
        
        this.buildingItemView.Setup(与且专丈不万东一万:  this.丛不丈不丙丟不三上);
        this.丝丘丆世丞上丆丙丑 = this.且上丘丄丘业丐丅业;
        this.且上丘丄丘业丐丅业 = this.不业丌三丅丟丌下丌();
        this.不东丈丕不丝一东丙();
        丙丙世七丆丝七丗丐 val_9 = this.且上丘丄丘业丐丅业;
        val_9 = val_9 - 1;
        if(val_9 <= 4)
        {
                var val_10 = 106021248 + ((this.且上丘丄丘业丐丅业 - 1)) << 2;
            val_10 = val_10 + 106021248;
        }
        else
        {
                ??? + 80.Reposition();
        }
    
    }
    private ClanBuildingView.丙丙世七丆丝七丗丐 不业丌三丅丟丌下丌()
    {
        object val_16;
        var val_17;
        val_16 = this;
        if(this.丛不丈不丙丟不三上 == null)
        {
            goto label_1;
        }
        
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  this.丛不丈不丙丟不三上.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_4;
        }
        
        val_17 = 3;
        goto label_10;
        label_1:
        val_17 = 0;
        return (丙丙世七丆丝七丗丐)(val_16.丁丟丈丌丑丅丞世丏() != true) ? (((PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丄丄丞丗丝万业丒上().Exists(match:  new System.Predicate<PGCompany.丏丌丝丕丐七丈且丒>(object:  this, method:  System.Boolean ClanBuildingView::丑上与丏丝丙丞丆丒(PGCompany.丏丌丝丕丐七丈且丒 丌丗丏丏丛东专丁且)))) != true) ? 5 : (0 + 1)) : 4;
        label_4:
        if((PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丆世丂丅一且丑丝丅(丆专且丕专丗与一丏:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不())) != false)
        {
                val_17 = 2;
        }
        
        label_10:
        if(this.丛不丈不丙丟不三上.丙丅丗丏丆丆世世丙() == false)
        {
                return (丙丙世七丆丝七丗丐)(val_16.丁丟丈丌丑丅丞世丏() != true) ? (((PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丄丄丞丗丝万业丒上().Exists(match:  new System.Predicate<PGCompany.丏丌丝丕丐七丈且丒>(object:  this, method:  System.Boolean ClanBuildingView::丑上与丏丝丙丞丆丒(PGCompany.丏丌丝丕丐七丈且丒 丌丗丏丏丛东专丁且)))) != true) ? 5 : (0 + 1)) : 4;
        }
        
        val_16 = this.丛不丈不丙丟不三上;
        return (丙丙世七丆丝七丗丐)(val_16.丁丟丈丌丑丅丞世丏() != true) ? (((PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丄丄丞丗丝万业丒上().Exists(match:  new System.Predicate<PGCompany.丏丌丝丕丐七丈且丒>(object:  this, method:  System.Boolean ClanBuildingView::丑上与丏丝丙丞丆丒(PGCompany.丏丌丝丕丐七丈且丒 丌丗丏丏丛东专丁且)))) != true) ? 5 : (0 + 1)) : 4;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_notBuilt, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_building, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_built, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_needUpgrade, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_buildingLocked, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enterButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.getPartsButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startBuildButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.speedUpBuildButton, 丏业丟一东丂东丘丛:  false);
    }
    private void 丟丟丙世丝七丑丅丈()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_notBuilt, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.notBuilt_Label, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9029"));
        if(PGCompany.丂丘丞丂丏七丁丄不.丏丕不丛丐三上丙丑() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startBuildButton, 丏业丟一东丂东丘丛:  true);
    }
    private void 与丏丕一丄一不丄东()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_building, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.building_Label, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9031"));
        float val_4 = (float)this.丛不丈不丙丟不三上.且丆丟业丞丕丑上且();
        val_4 = val_4 / (float)this.丛不丈不丙丟不三上.丏丈丁专专丘丒丂丂();
        this.building_Bar.fillAmount = val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.speedUpBuildButton, 丏业丟一东丂东丘丛:  true);
    }
    private void 丒丂丐专专一丛丝丆()
    {
        UILabel val_12;
        var val_13;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_built, 丏业丟一东丂东丘丛:  true);
        if(this.丛不丈不丙丟不三上.丙丅丗丏丆丆世世丙() != false)
        {
                float val_12 = (float)this.丛不丈不丙丟不三上.且丆丟业丞丕丑上且();
            val_12 = val_12 / (float)this.丛不丈不丙丟不三上.丏丈丁专专丘丒丂丂();
            this.built_Bar.fillAmount = val_12;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.built_Label, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9033"), arg0:  this.丛不丈不丙丟不三上.丁丕丁三丁丗不三丟() + 1));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.built_Bar.transform.parent, 丏业丟一东丂东丘丛:  true);
            val_12 = this.built_Label;
            val_13 = 1;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.built_Bar.transform.parent, 丏业丟一东丂东丘丛:  false);
            val_12 = this.built_Label;
            val_13 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_12, 丏业丟一东丂东丘丛:  false);
        this.enterButton.丛不丈不丙丟不三上 = this.丛不丈不丙丟不三上;
        this.enterButton.丝一丅丆三东丂丞七();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enterButton, 丏业丟一东丂东丘丛:  true);
    }
    private void 丝丙丌世世丝丟丄丟()
    {
        string val_25;
        string val_26;
        object val_27;
        string val_28;
        object val_29;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_needUpgrade, 丏业丟一东丂东丘丛:  true);
        PGCompany.世东三上七丂丌下丑 val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        PGCompany.三东丏不丗世丅丌丄 val_10 = this.丛不丈不丙丟不三上.丑丐丙丄丅世世丑丒();
        if(this.丛不丈不丙丟不三上.丁丙丑万丒丒世不丕().丘不丈丟不丅上丄业() <= ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丂丙业与丆东丐()) + 1))
        {
            goto label_10;
        }
        
        if((val_9.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_10, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_12;
        }
        
        val_25 = "Key_9117";
        goto label_15;
        label_10:
        if((val_9.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_10, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_17;
        }
        
        val_26 = "Key_9117";
        goto label_20;
        label_12:
        val_25 = "Key_9144";
        label_15:
        val_27 = this.丛不丈不丙丟不三上.丁丙丑万丒丒世不丕().丕丆丆世万丆丁丕丘();
        val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_25);
        val_29 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8449");
        goto label_25;
        label_17:
        val_26 = "Key_9144";
        label_20:
        int val_18 = this.丛不丈不丙丟不三上.丁丙丑万丒丒世不丕().丕丆丆世万丆丁丕丘();
        val_27 = val_18;
        val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_26);
        val_29 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8448");
        label_25:
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  this.丛不丈不丙丟不三上.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                this.enterButton.丛不丈不丙丟不三上 = this.丛不丈不丙丟不三上;
            this.enterButton.丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.enterButton, 丏业丟一东丂东丘丛:  true);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.getPartsButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.needUpgrade_Label, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_28, arg0:  val_29, arg1:  val_18));
    }
    private void 丐丌丒丞丒丞不业专()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_buildingLocked, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.buildingLocked_Label, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9037"));
    }
    private void 丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)
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
    private void 丈丈业丝丄七丏与一(int 丛丑丅丞丝丈丘丆三)
    {
        this.UpdateView();
    }
    public void U_ShowBuildingInfoBunner()
    {
        this.buildingInfoBunner.丈且东丑丂且万丒丅(上丟专三丙丅丆丛且:  this.丛不丈不丙丟不三上);
        if(this.buildingInfoBunner == null)
        {
            
        }
    
    }
    public void U_GetPartsButtonPressed()
    {
        PGCompany.ClanStoreMainUI.丆丙丗三东专丐不上(丞丘丞丏业且丛丏丘:  this.丛不丈不丙丟不三上);
    }
    public void U_StartBuildButtonPressed()
    {
        PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().专且丛三三不丐丅丑(丆专且丕专丗与一丏:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不());
        this.UpdateView();
    }
    public void U_SpeedUpBuildButtonPressed()
    {
        this.cunstructionBunner.丈且东丑丂且万丒丅(上丟专三丙丅丆丛且:  this.丛不丈不丙丟不三上);
        if(this.cunstructionBunner == null)
        {
            
        }
    
    }
    public ClanBuildingView()
    {
    
    }
    private bool 丑上与丏丝丙丞丆丒(PGCompany.丏丌丝丕丐七丈且丒 丌丗丏丏丛东专丁且)
    {
        return (bool)(丌丗丏丏丛东专丁且.业东丅东丌上丗丑不() != this.丛不丈不丙丟不三上.业东丅东丌上丗丑不()) ? 1 : 0;
    }

}
