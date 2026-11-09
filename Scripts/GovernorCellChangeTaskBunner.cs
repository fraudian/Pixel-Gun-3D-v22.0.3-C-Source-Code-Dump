using UnityEngine;
public class GovernorCellChangeTaskBunner : SimpleBunner
{
    // Fields
    private UnityEngine.GameObject state_changeTaskPaid;
    private UnityEngine.GameObject state_changeTaskVideo;
    private UnityEngine.GameObject state_changeTaskLocked;
    private PGCompany.InventoryItemView changeTaskPrice;
    private PGCompany.TimerUI changeTaskTimer;
    private 丛丗丅丆万不丕七丏 三下丌且与丘丆丏且;
    private GovernorCellChangeTaskBunner.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(丛丗丅丆万不丕七丏 三下丌且与丘丆丏且)
    {
        this.三下丌且与丘丆丏且 = 三下丌且与丘丆丏且;
        this.UpdateView();
    }
    public void UpdateView()
    {
        this.且上丘丄丘业丐丅业 = this.不业丌三丅丟丌下丌();
        this.不东丈丕不丝一东丙();
        if(this.且上丘丄丘业丐丅业 == 3)
        {
            goto label_0;
        }
        
        if(this.且上丘丄丘业丐丅业 == 2)
        {
            goto label_1;
        }
        
        if(this.且上丘丄丘业丐丅业 != 1)
        {
                return;
        }
        
        this.丗丞丞丞丌丕丌专丒();
        return;
        label_0:
        this.丟万丛丕世丂丈丆东();
        return;
        label_1:
        this.七七丒丈丆三万东丄();
    }
    private GovernorCellChangeTaskBunner.丙丙世七丆丝七丗丐 不业丌三丅丟丌下丌()
    {
        var val_6;
        var val_7;
        val_6 = this;
        if(this.三下丌且与丘丆丏且 == null)
        {
            goto label_1;
        }
        
        val_6 = PGCompany.ClanGovernorController.丑七不且上丗丁一世();
        if(val_6.丝丑丗丄七一丏专丆() == false)
        {
            goto label_5;
        }
        
        val_7 = 2;
        return (丙丙世七丆丝七丗丐)((val_6.丏丄丛丞不丙丏丐丄() & true) != 0) ? 3 : (0 + 1);
        label_1:
        val_7 = 0;
        return (丙丙世七丆丝七丗丐)((val_6.丏丄丛丞不丙丏丐丄() & true) != 0) ? 3 : (0 + 1);
        label_5:
        val_6 = PGCompany.ClanGovernorController.丑七不且上丗丁一世();
        return (丙丙世七丆丝七丗丐)((val_6.丏丄丛丞不丙丏丐丄() & true) != 0) ? 3 : (0 + 1);
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_changeTaskPaid, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_changeTaskVideo, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_changeTaskLocked, 丏业丟一东丂东丘丛:  false);
    }
    private void 丗丞丞丞丌丕丌专丒()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_changeTaskPaid, 丏业丟一东丂东丘丛:  true);
        this.changeTaskPrice.Setup(丈丄不七三万丄丁不:  PGCompany.ClanGovernorController.丑七不且上丗丁一世().业上丕且丞丅丂丛丌());
    }
    private void 七七丒丈丆三万东丄()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_changeTaskVideo, 丏业丟一东丂东丘丛:  true);
    }
    private void 丟万丛丕世丂丈丆东()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_changeTaskLocked, 丏业丟一东丂东丘丛:  true);
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟()) >= 1)
        {
                this.changeTaskTimer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  this.三下丌且与丘丆丏且.一丂七丕丁下下丗丕(), 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  public System.Void GovernorCellChangeTaskBunner::UpdateView()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            return;
        }
        
        this.changeTaskTimer.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  "Locked");
    }
    public void U_ChangeTask()
    {
        UnityEngine.Debug.LogError(message:  "U_ChangeTask");
        bool val_3 = PGCompany.ClanGovernorController.丑七不且上丗丁一世().不丞三万三丛丝业丒(业丌丆业丘丟丆丁丛:  this.三下丌且与丘丆丏且.业东丅东丌上丗丑不());
        goto typeof(GovernorCellChangeTaskBunner).__il2cppRuntimeField_198;
    }
    public GovernorCellChangeTaskBunner()
    {
    
    }

}
