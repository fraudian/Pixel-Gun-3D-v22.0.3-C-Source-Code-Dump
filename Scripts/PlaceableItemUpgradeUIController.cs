using UnityEngine;
internal sealed class PlaceableItemUpgradeUIController : PGBehaviour
{
    // Fields
    private PlaceableItemUpgradeUI tankUpgradeUI;
    private PlaceableItemUpgradeUI fortUpgradeUI;
    private WidgetLayout widgetLayout;
    
    // Methods
    private void OnEnable()
    {
        丂丘丗丗与且丌丁丙.七丈七万丂丒丐丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemUpgradeUIController::东丒不七丝万丌丄三()));
        this.东丒不七丝万丌丄三();
    }
    private void OnDisable()
    {
        丂丘丗丗与且丌丁丙.丐丟丂丁下丐丑丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlaceableItemUpgradeUIController::东丒不七丝万丌丄三()));
    }
    private void 东丒不七丝万丌丄三()
    {
        var val_4;
        var val_8;
        var val_9;
        var val_10;
        val_8 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tankUpgradeUI, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.fortUpgradeUI, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_2 = 丂丘丗丗与且丌丁丙.丐一上与丕下万丟丕().GetEnumerator();
        label_17:
        if(((-2068419264) & 1) == 0)
        {
            goto label_6;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        val_9 = null;
        val_9 = null;
        if((System.String.op_Equality(a:  val_5.m_stringLength, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) != false)
        {
                this.tankUpgradeUI.Setup(业世丟丐丘丐专与不:  val_5);
        }
        
        val_10 = null;
        val_10 = null;
        if((System.String.op_Equality(a:  val_5.m_stringLength, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != false)
        {
                this.fortUpgradeUI.Setup(业世丟丐丘丐专与不:  val_5);
        }
        
        this.widgetLayout.Reposition();
        goto label_17;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public PlaceableItemUpgradeUIController()
    {
    
    }

}
