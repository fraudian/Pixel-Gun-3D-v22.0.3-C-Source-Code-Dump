using UnityEngine;
public class DeathEscapeUI : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject container;
    public UILabel timeLabel;
    public UILabel bestTimeLabel;
    public UILabel recordTimeLabel;
    public UnityEngine.GameObject bestTime;
    public UnityEngine.GameObject recordTime;
    public UIButton saveCheckpointButton;
    public UILabel labelFreeSave;
    public UILabel labelSavePrice;
    private bool 丘且丄丌业三专三丒;
    private static readonly System.Text.StringBuilder 丞丁世丙世丕丗丑丘;
    private static System.Collections.Generic.KeyValuePair<int, string> 与丕丌丄东下世丂且;
    
    // Methods
    private void Awake()
    {
        var val_5;
        this.saveCheckpointButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void DeathEscapeUI::不丁业丛业丟丅东东())));
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == false)
        {
                return;
        }
        
        this.bestTime.SetActive(value:  false);
        this.recordTime.SetActive(value:  false);
    }
    private void OnEnable()
    {
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void DeathEscapeUI::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void DeathEscapeUI::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
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
        
        if(七丐丅专且专七三丆 != 25)
        {
                return;
        }
        
        if(null != 1)
        {
                return;
        }
        
        丙业与丙丗丝不丈东.不丁业丛业丟丅东东();
    }
    private void 不丁业丛业丟丅东东()
    {
        CheckpointController.丄丘七三上丕世丞业.TrySaveOnCheckpoint();
    }
    private void Update()
    {
        var val_45;
        var val_46;
        var val_47;
        string val_48;
        var val_49;
        var val_50;
        if(PauseGUIController.丑七不且上丗丁一世() != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.container, 丏业丟一东丂东丘丛:  (~PauseGUIController.丑七不且上丗丁一世().IsPaused) & 1);
        }
        
        if(CheckpointController.丄丘七三上丕世丞业.CanSaveCheckpoint != false)
        {
                val_45 = null;
            val_45 = null;
            val_46 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayer, y:  0);
        }
        else
        {
                val_46 = 0;
        }
        
        if(val_46 == this.saveCheckpointButton.gameObject.activeSelf)
        {
                if(this.丘且丄丌业三专三丒 == true)
        {
            goto label_49;
        }
        
        }
        
        this.丘且丄丌业三专三丒 = true;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_47 = null;
            val_47 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                if(CheckpointController.丄丘七三上丕世丞业.GetFreeCheckpointsCount() <= 0)
        {
            goto label_26;
        }
        
        }
        
        }
        
        this.saveCheckpointButton.gameObject.SetActive(value:  CheckpointController.丄丘七三上丕世丞业.CanSaveCheckpoint);
        if(CheckpointController.丄丘七三上丕世丞业.CanSaveCheckpoint != false)
        {
                int val_18 = CheckpointController.丄丘七三上丕世丞业.GetFreeCheckpointsCount();
            this.labelFreeSave.gameObject.SetActive(value:  (val_18 > 0) ? 1 : 0);
            this.labelSavePrice.gameObject.SetActive(value:  (val_18 < 1) ? 1 : 0);
            if(val_18 >= 1)
        {
                val_48 = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3175"), arg1:  val_18);
        }
        else
        {
                val_48 = CheckpointController.丄丘七三上丕世丞业.saveCheckpointPrice.ToString();
        }
        
            this.labelSavePrice.text = val_48;
            if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_49 = null;
            val_49 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                this.labelFreeSave.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5005")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5005")) + " ", arg0:  CheckpointController.丄丘七三上丕世丞业.GetFreeCheckpointsCount().ToString());
        }
        
        }
        
        }
        
        label_49:
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_50 = null;
            val_50 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                if(CheckpointController.丄丘七三上丕世丞业.lapTimeMili > 3000)
        {
                UnityEngine.Color val_37 = UnityEngine.Color.white;
        }
        else
        {
                UnityEngine.Color val_38 = UnityEngine.Color.red;
        }
        
            this.timeLabel.color = new UnityEngine.Color() {r = val_38.r, g = val_38.g, b = val_38.b, a = val_38.a};
        }
        
        }
        
        this.timeLabel.text = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  CheckpointController.丄丘七三上丕世丞业.lapTimeMili);
        this.bestTimeLabel.text = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  CheckpointController.丄丘七三上丕世丞业.bestLapTimeMili);
        this.recordTimeLabel.text = DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  CheckpointController.丄丘七三上丕世丞业.lapRecordTimeMili);
        return;
        label_26:
        this.saveCheckpointButton.gameObject.SetActive(value:  false);
    }
    internal static string 丅世丏丐丘丁丌丂丕(float 丞丘丑丗丑专且丕丘)
    {
        float val_2 = 100f;
        val_2 = 丞丘丑丗丑专且丕丘 * val_2;
        return DeathEscapeUI.丅世丏丐丘丁丌丂丕(上丗丂且丑上丛与七:  UnityEngine.Mathf.FloorToInt(f:  val_2));
    }
    internal static string 丅世丏丐丘丁丌丂丕(int 上丗丂且丑上丛与七)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = null;
        val_15 = null;
        if(丙东专丂世丈丏丁丂() == 上丗丂且丑上丛与七)
        {
                val_16 = null;
        }
        else
        {
                val_17 = null;
            val_17 = null;
            int val_5 = 上丗丂且丑上丛与七 - (((X10 >> 37) + (X10 >> 63)) * 100);
            int val_6 = X27 >> 63;
            DeathEscapeUI.丞丁世丙世丕丗丑丘.Length = 0;
            val_18 = null;
            val_18 = null;
            val_6 = (X27 >> 37) + val_6;
            System.Text.StringBuilder val_14 = DeathEscapeUI.丞丁世丙世丕丗丑丘.Append(value:  0).Append(value:  (0 < 1000) ? ":0" : ":").Append(value:  val_6).Append(value:  (val_5 < 10) ? ":0" : ":").Append(value:  val_5);
            DeathEscapeUI.丞丁世丙世丕丗丑丘.Length = 0;
            val_16 = null;
            DeathEscapeUI.与丕丌丄东下世丂且 = 0;
            DeathEscapeUI.丞丁世丙世丕丗丑丘.__il2cppRuntimeField_10 = 0;
        }
        
        val_16 = null;
        return (string)1152921505056903176;
    }
    public DeathEscapeUI()
    {
    
    }
    private static DeathEscapeUI()
    {
        DeathEscapeUI.丞丁世丙世丕丗丑丘 = new System.Text.StringBuilder();
        DeathEscapeUI.与丕丌丄东下世丂且 = 0;
        DeathEscapeUI.丞丁世丙世丕丗丑丘.__il2cppRuntimeField_10 = 0;
    }

}
