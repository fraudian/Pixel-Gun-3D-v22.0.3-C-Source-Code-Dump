using UnityEngine;
internal class DungeonCheckPointUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject _registerCheckpoint;
    private UnityEngine.GameObject _unregisterCheckpoint;
    private DungeonSpawnPoint 不丈万东上一丒业三;
    private bool 上专丂丕丙丒丒丛东;
    private bool 业丕下三万丒七丁一;
    
    // Methods
    private void Awake()
    {
        DungeonSpawnPoint.add_OnEnterTrogger(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, DungeonSpawnPoint>(object:  this, method:  System.Void DungeonCheckPointUI::丑丈东一丑三丌上丌(bool 丙业与丙丗丝不丈东, DungeonSpawnPoint 万万三丂丕丏丈东丄)));
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void DungeonCheckPointUI::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDestroy()
    {
        DungeonSpawnPoint.remove_OnEnterTrogger(丙业与丙丗丝不丈东:  new System.Action<System.Boolean, DungeonSpawnPoint>(object:  this, method:  System.Void DungeonCheckPointUI::丑丈东一丑三丌上丌(bool 丙业与丙丗丝不丈东, DungeonSpawnPoint 万万三丂丕丏丈东丄)));
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void DungeonCheckPointUI::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        if(七丐丅专且专七三丆 != 26)
        {
                return;
        }
        
        if(null != 1)
        {
                return;
        }
        
        if(this.上专丂丕丙丒丒丛东 == false)
        {
                return;
        }
        
        if(this.业丕下三万丒七丁一 != false)
        {
                this.UnregisterPoint();
            return;
        }
        
        this.RegisterPoint();
    }
    private void 丑丈东一丑三丌上丌(bool 丙业与丙丗丝不丈东, DungeonSpawnPoint 万万三丂丕丏丈东丄)
    {
        UnityEngine.Object val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_11 = 丙业与丙丗丝不丈东;
        this.不丈万东上一丒业三 = 万万三丂丕丏丈东丄;
        if(val_11 == false)
        {
            goto label_1;
        }
        
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_19;
        }
        
        val_13 = null;
        val_13 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_19;
        }
        
        val_14 = null;
        val_14 = null;
        val_11 = 上万一丒丙丕且丈丘();
        if(val_11 != this.不丈万东上一丒业三)
        {
            goto label_19;
        }
        
        this._registerCheckpoint.SetActive(value:  false);
        this.上专丂丕丙丒丒丛东 = true;
        val_15 = 1;
        goto label_22;
        label_1:
        this.上专丂丕丙丒丒丛东 = false;
        this._registerCheckpoint.SetActive(value:  false);
        this._unregisterCheckpoint.SetActive(value:  false);
        return;
        label_19:
        val_16 = null;
        val_16 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_42;
        }
        
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_42;
        }
        
        val_18 = null;
        val_18 = null;
        val_11 = 上万一丒丙丕且丈丘();
        if(val_11 == this.不丈万东上一丒业三)
        {
            goto label_42;
        }
        
        val_11 = true;
        this._registerCheckpoint.SetActive(value:  true);
        this.上专丂丕丙丒丒丛东 = val_11;
        val_15 = 0;
        label_22:
        this._unregisterCheckpoint.SetActive(value:  false);
        label_42:
        this.业丕下三万丒七丁一 = this._unregisterCheckpoint.activeSelf;
    }
    public void RegisterPoint()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = 1152921505286238208;
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_6 = null;
            val_6 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                if(this.不丈万东上一丒业三 != 0)
        {
                val_7 = null;
            val_7 = null;
            东丄丑丂丅丁万业丏(丘丏丌丞丆一丈万丑:  this.不丈万东上一丒业三);
            val_4 = 1152921505207164928;
            val_8 = null;
            val_8 = null;
            丟丌丁且且世丈丈丟.丑世丐丂与一丐丛世 = this.不丈万东上一丒业三.nameZone;
        }
        
        }
        
        }
        
        this.丑丈东一丑三丌上丌(丙业与丙丗丝不丈东:  true, 万万三丂丕丏丈东丄:  this.不丈万东上一丒业三);
    }
    public void UnregisterPoint()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_4 = null;
            val_4 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_5 = null;
            val_5 = null;
            东丄丑丂丅丁万业丏(丘丏丌丞丆一丈万丑:  0);
            val_6 = null;
            val_6 = null;
            丟丌丁且且世丈丈丟.丑世丐丂与一丐丛世 = "";
        }
        
        }
        
        this.丑丈东一丑三丌上丌(丙业与丙丗丝不丈东:  true, 万万三丂丕丏丈东丄:  this.不丈万东上一丒业三);
    }
    public DungeonCheckPointUI()
    {
    
    }

}
