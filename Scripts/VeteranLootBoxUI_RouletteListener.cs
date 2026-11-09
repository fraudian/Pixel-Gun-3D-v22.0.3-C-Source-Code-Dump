using UnityEngine;
internal sealed class VeteranLootBoxUI_RouletteListener : LootBoxUI_RouletteListener
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> mainGui;
    private UnityEngine.GameObject openButton;
    private UnityEngine.GameObject backButton;
    private UnityEngine.GameObject _progressRoadContainer;
    private UnityEngine.GameObject State_CanOpen;
    private UnityEngine.GameObject State_CantOpen;
    private UnityEngine.GameObject State_Unavailable;
    private VeteranLootBoxUI_RouletteListener.且世丈业丘丆不上丄 丁三世不世专丏丐丘;
    
    // Methods
    protected override void 丈丗且丂业丁下丒丆()
    {
        this.丈丗且丂业丁下丒丆();
        this.丙丂丞丝丙丂业万丄();
    }
    protected override void 丁丟业丕丝丑丌丟专()
    {
        this.丁丟业丕丝丑丌丟专();
        this.丙丂丞丝丙丂业万丄();
    }
    private void 丙丂丞丝丙丂业万丄()
    {
        且世丈业丘丆不上丄 val_5;
        this.不东丈丕不丝一东丙();
        且世丈业丘丆不上丄 val_1 = this.三丟丛一丑丂丈东一();
        this.丁三世不世专丏丐丘 = val_1;
        if(val_1 == 3)
        {
            goto label_0;
        }
        
        if(val_1 == 2)
        {
            goto label_1;
        }
        
        if(val_1 != 1)
        {
            goto label_2;
        }
        
        this.下丆业七下丗专丆丄();
        goto label_4;
        label_0:
        this.丑东丘丅丕一丛业丝();
        goto label_4;
        label_1:
        this.且丐丏丁丌业丈丒一();
        label_4:
        val_5 = this.丁三世不世专丏丐丘;
        label_2:
        if(val_5 == 0)
        {
                return;
        }
        
        if(val_5 == 3)
        {
                return;
        }
        
        if(PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().下丆一丄丅丙与丟丙() != false)
        {
                return;
        }
        
        this.U_ShowHintPanel();
        PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().业丏丅丟丟丕丑下三();
    }
    private VeteranLootBoxUI_RouletteListener.且世丈业丘丆不上丄 三丟丛一丑丂丈东一()
    {
        var val_6;
        if(PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丄丛丒业丙万丅丏丌() != false)
        {
                var val_5 = ((PGCompany.VeteranChest.丐丂丄丗业业丘下丕.丑七不且上丗丁一世().丐下专丑丕一丁丛东() & true) != 0) ? (1 + 1) : 1;
            return (且世丈业丘丆不上丄)val_6;
        }
        
        val_6 = 3;
        return (且世丈业丘丆不上丄)val_6;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.mainGui, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.State_CanOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.State_CantOpen, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.State_Unavailable, 丏业丟一东丂东丘丛:  false);
    }
    private void 下丆业七下丗专丆丄()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.State_CanOpen, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.mainGui, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressRoadContainer, 丏业丟一东丂东丘丛:  false);
        this.一万丕丑世丆七丟世();
    }
    private void 且丐丏丁丌业丈丒一()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.State_CantOpen, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.mainGui, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backButton, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Object val_2 = 0;
        val_2 = UnityEngine.Object.op_Equality(x:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟, y:  val_2);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressRoadContainer, 丏业丟一东丂东丘丛:  val_2);
    }
    private void 丑东丘丅丕一丛业丝()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.State_Unavailable, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.mainGui, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.openButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.backButton, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Object val_2 = 0;
        val_2 = UnityEngine.Object.op_Equality(x:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟, y:  val_2);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressRoadContainer, 丏业丟一东丂东丘丛:  val_2);
    }
    public VeteranLootBoxUI_RouletteListener()
    {
    
    }

}
