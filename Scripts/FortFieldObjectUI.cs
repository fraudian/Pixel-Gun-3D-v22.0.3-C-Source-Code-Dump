using UnityEngine;
internal class FortFieldObjectUI : BindedUI
{
    // Fields
    private UiEvents uiEvents;
    private UiEvents _cancelDetector;
    private SquareFieldSelectableCell 万七丐丅丐世业业丆;
    private UnityEngine.GameObject addButton;
    private UnityEngine.GameObject replaceButton;
    private UnityEngine.GameObject removeButton;
    private UnityEngine.GameObject cancelButton;
    private UILabel energyLabel;
    private FortFieldTurretInfoUI temporaryTurretInfo;
    private bool 业丞丁下且丌世丂丕;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.丅万专丐一下丞一丕(丏业丟一东丂东丘丛:  false);
        if(this.uiEvents != 0)
        {
                this.uiEvents.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void FortFieldObjectUI::丁丛丝丆不丟业丞丛(UnityEngine.Vector2 丞且丅三三东不丄且)));
            this.uiEvents.add_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void FortFieldObjectUI::丁丛丝丆不丟业丞丛(UnityEngine.Vector2 丞且丅三三东不丄且)));
            this._cancelDetector.add_onDoubleClick(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldObjectUI::万丟七丅与与丂丗丗()));
            PGCompany.ClanStoreMainUI.万专丆且七丈业丅丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldObjectUI::丆世与丑丆丅丐万且()));
            PGCompany.ClanStoreMainUI.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldObjectUI::下与丞三丅丛丄七丕()));
        }
        
        SquareFieldSelectableCell val_9 = ClanFieldBuildController.丑七不且上丗丁一世().丑东业且专丗丕丙丕().GetComponent<SquareFieldSelectableCell>();
        this.万七丐丅丐世业业丆 = val_9;
        UnityEngine.Vector3 val_11 = localPosition;
        val_9.丗丕下丘丁且丒丈丝(专丏丕丌世一专丒且:  FortFieldSetupUtility.丄丘七三上丕世丞业.丌丟丄业且三丛丕丄(), 丟丙丝业丑丁与丟丒:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        if(FortFieldSetupUtility.丄丘七三上丕世丞业 != null)
        {
                this.丅万专丐一下丞一丕(丏业丟一东丂东丘丛:  true);
        }
        
        this.energyLabel.text = "+"("+") + ClanFieldBuildController.丑七不且上丗丁一世().世丗丄丄丛丕业丕丅(与不丕丆丈不丙丟丛:  this.万七丐丅丐世业业丆).ToString()(ClanFieldBuildController.丑七不且上丗丁一世().世丗丄丄丛丕业丕丅(与不丕丆丈不丙丟丛:  this.万七丐丅丐世业业丆).ToString());
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.万七丐丅丐世业业丆.不世丏丛一三且下丛();
        this.万七丐丅丐世业业丆.丏丛丁世丑丏丕与与();
        this.uiEvents.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void FortFieldObjectUI::丁丛丝丆不丟业丞丛(UnityEngine.Vector2 丞且丅三三东不丄且)));
        System.Action val_2 = 1152921536494851024;
        val_2 = new System.Action(object:  this, method:  System.Void FortFieldObjectUI::万丟七丅与与丂丗丗());
        this._cancelDetector.remove_onDoubleClick(丙业与丙丗丝不丈东:  val_2);
    }
    private void Update()
    {
        var val_6;
        UnityEngine.GameObject val_7;
        var val_8;
        UnityEngine.GameObject val_9;
        bool val_10;
        val_6 = this;
        if(this.业丞丁下且丌世丂丕 != false)
        {
                return;
        }
        
        if(this.万七丐丅丐世业业丆 != 0)
        {
                bool val_2 = this.万七丐丅丐世业业丆.世万丆三一丌且丟一();
            bool val_3 = this.万七丐丅丐世业业丆.世万丆三一丌且丟一();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.replaceButton, 丏业丟一东丂东丘丛:  false);
            val_7 = this.addButton;
            val_8 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  null, 丏业丟一东丂东丘丛:  true);
        }
        
        val_9 = this.removeButton;
        val_10 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  null, 丏业丟一东丂东丘丛:  null);
    }
    protected override void OnDestroy()
    {
        this.OnDestroy();
        this.uiEvents.remove_onDrag(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void FortFieldObjectUI::丁丛丝丆不丟业丞丛(UnityEngine.Vector2 丞且丅三三东不丄且)));
        PGCompany.ClanStoreMainUI.丟丑丟丑丂丄丕丆丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldObjectUI::丆世与丑丆丅丐万且()));
        PGCompany.ClanStoreMainUI.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldObjectUI::下与丞三丅丛丄七丕()));
    }
    private void 丁丛丝丆不丟业丞丛(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(ClanFieldBuildController.丑七不且上丗丁一世().东丈万与丄丟丞三丆() == 0)
        {
                return;
        }
        
        if(ClanFieldBuildController.丑七不且上丗丁一世().东丈万与丄丟丞三丆().丛丅且三丟丛丝上下() == 0)
        {
                if(ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒().SelectedObject != 0)
        {
                ClanFieldBuildController.丑七不且上丗丁一世().东丈万与丄丟丞三丆().与丏不上丆丅一丆丐(丙业与丙丗丝不丈东:  ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒().SelectedObject.GetComponent<SquareFieldCell>());
        }
        
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().东丈万与丄丟丞三丆().业世业丛丗下七丂专(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    internal void 丝一丅丆三东丂丞七()
    {
        if((ClanFieldBuildController.丑七不且上丗丁一世() != 0) && (ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒() != 0))
        {
                UnityEngine.GameObject val_8 = ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒().SelectedObject;
            mem[1152921536495652824] = val_8;
            if(val_8 != 0)
        {
                this.gameObject.SetActive(value:  true);
            return;
        }
        
        }
        
        this.丙与丐东丘业丐丗丆();
    }
    internal void 丙与丐东丘业丐丗丆()
    {
        mem[1152921536495797592] = 0;
        this.gameObject.SetActive(value:  false);
    }
    private void 万丟七丅与与丂丗丗()
    {
        this.U_Cancel();
    }
    public void U_ApplyPosition()
    {
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().三三丝丆丁下一与一();
    }
    public void U_DeleteObject()
    {
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().丏丁不丒东丟丌丐与();
    }
    public void U_Cancel()
    {
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().CancelSelectedItem();
    }
    public void U_ReplaceObject()
    {
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().ReplaceBySelectedItem();
    }
    private void 丅万专丐一下丞一丕(bool 丏业丟一东丂东丘丛)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.temporaryTurretInfo.gameObject, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        if(丏业丟一东丂东丘丛 == false)
        {
                return;
        }
        
        this.temporaryTurretInfo.shadowingTransform = FortFieldSetupUtility.丄丘七三上丕世丞业.placeForTurretInfo;
        this.temporaryTurretInfo.丄丅一万丐七三丘世(七丆丟丗世丟且丒丆:  this.万七丐丅丐世业业丆.Power, 东丝丅专丝丈一丘下:  Base_BuildingUI_Controller.instance);
        this.temporaryTurretInfo.丗世七丕东且业业万(丈下丑丆上丏丗丈专:  this.万七丐丅丐世业业丆.ItemRarity);
    }
    private void 丆世与丑丆丅丐万且()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.addButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.replaceButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.removeButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cancelButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.temporaryTurretInfo, 丏业丟一东丂东丘丛:  false);
        this.业丞丁下且丌世丂丕 = true;
    }
    private void 下与丞三丅丛丄七丕()
    {
        if(this.万七丐丅丐世业业丆 != 0)
        {
                this.丅万专丐一下丞一丕(丏业丟一东丂东丘丛:  true);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cancelButton, 丏业丟一东丂东丘丛:  true);
        this.业丞丁下且丌世丂丕 = false;
    }
    public FortFieldObjectUI()
    {
    
    }

}
