using UnityEngine;
public class CheckpointController : MonoBehaviour
{
    // Fields
    internal static CheckpointController 丄丘七三上丕世丞业;
    public PlayerCheckpoint startCheckpoint;
    private PlayerCheckpoint 丆且且世丛丗三丁丌;
    public PlayerCheckpoint savedCheckpoint;
    private System.Collections.Generic.List<PlayerCheckpoint> 专且丆丘上丏丌且且;
    private int 丄七丆丗东不丅丆丌;
    private float 丄丒世丝丘世丌丗丁;
    private Rilisoft.丒且丐三丁丅丕一业 下丝丏三三丛丛丑业;
    public float reachedDistance;
    private int 专丅专丈丘丌七上一;
    private bool 丗丒不东丁丌丞丒丂;
    public bool runFinishedOnce;
    internal float 万与下丐丏丝三三丟;
    public int bestLapTimeMili;
    public int lapRecordTimeMili;
    private bool 丐丌丅丝丆丗与丝丝;
    private bool 丝丛一与丞丛万万丑;
    private bool 东丒丕丈丌丁与丈丝;
    private bool 丅万万三丘丆丌一与;
    private int 丁世丝东专专业丈丕;
    
    // Properties
    public float 丝上七万上丄专丟丘 { get; set; }
    public int 下丑世丄七丁业丆丕 { get; }
    public bool 东丒丛丅丅丘丂专丕 { get; set; }
    public int 丂万下不业丐丑不不 { get; }
    public bool 丙丛丌丐丘丑丘丂丑 { get; }
    
    // Methods
    public float get_distancePassed()
    {
        if(this.下丝丏三三丛丛丑业 != null)
        {
                return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
        }
        
        return this.下丝丏三三丛丛丑业.丝丙丐且丟丅三丛七();
    }
    public void set_distancePassed(float 丙业与丙丗丝不丈东)
    {
        this.下丝丏三三丛丛丑业.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    public int get_saveCheckpointPrice()
    {
        return (int)this.专丅专丈丘丌七上一;
    }
    public bool get_CanSaveCheckpoint()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = this;
        if(this.丗丒不东丁丌丞丒丂 != false)
        {
                if(下丟世丏三东万丘丏.下不丙丌丙丞丞万上() != false)
        {
                val_3 = 1;
            return (bool)val_3;
        }
        
            val_2 = 1152921505171275776;
            val_4 = null;
            val_4 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return GameConnect.上丏丈七丘丁与丅丏();
        }
        
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    private void 专丘不丈丟丗丘丟丕(bool 丙业与丙丗丝不丈东)
    {
        this.丗丒不东丁丌丞丒丂 = 丙业与丙丗丝不丈东;
    }
    public int get_lapTimeMili()
    {
        var val_4;
        var val_5;
        float val_6;
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_6;
        }
        
        val_4 = null;
        val_4 = null;
        if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == false)
        {
            goto label_6;
        }
        
        float val_4 = this.万与下丐丏丝三三丟;
        val_5 = null;
        val_4 = (float)丛丑且业丗世丈丙丌.丏丙下丘业业七专东() - val_4;
        goto label_12;
        label_6:
        val_6 = this.万与下丐丏丝三三丟;
        val_5 = null;
        label_12:
        float val_5 = 100f;
        val_5 = val_6 * val_5;
        return UnityEngine.Mathf.FloorToInt(f:  val_5);
    }
    public bool get_finishedLap()
    {
        return (bool)this.东丒丕丈丌丁与丈丝;
    }
    private void Awake()
    {
        CheckpointController.丄丘七三上丕世丞业 = this;
        this.丁世丝东专专业丈丕 = 丛丑且业丗世丈丙丌.丑下三丞东丟丞与丁();
        float val_12 = 0f;
        label_16:
        label_10:
        if(mem[this.startCheckpoint] == 0)
        {
            goto label_5;
        }
        
        if(mem[this.startCheckpoint] != 0)
        {
                mem2[0] = val_12;
        }
        else
        {
                mem2[0] = val_12;
        }
        
        if((mem[this.startCheckpoint] + 32) == 0)
        {
            goto label_10;
        }
        
        UnityEngine.Vector3 val_5 = mem[this.startCheckpoint] + 32.transform.position;
        UnityEngine.Vector3 val_7 = mem[this.startCheckpoint].transform.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_12 = val_12 + val_8.x;
        goto label_16;
        label_5:
        this.lapRecordTimeMili = Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
    }
    public void ResetCheckpoint()
    {
        goto label_1;
        label_5:
        X21.Item[0].SetCheckpointSaved(不丛丙三丂一丅丂丆:  false, 三万丙三丅业丂不下:  false);
        0 = 1;
        label_1:
        if(0 < this.专且丆丘上丏丌且且.Count)
        {
            goto label_5;
        }
        
        this.专且丆丘上丏丌且且.Clear();
        this.专丅专丈丘丌七上一 = 1;
        this.丆且且世丛丗三丁丌 = this.startCheckpoint;
        this.savedCheckpoint = 0;
        this.reachedDistance = this.startCheckpoint.丌七丒世丄上丞丞丁;
    }
    public int GetFreeCheckpointsCount()
    {
        var val_5;
        int val_6;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_5 = null;
            val_5 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                val_6 = this.丁世丝东专专业丈丕;
            return (int)val_6;
        }
        
        }
        
        bool val_5 = this.丅万万三丘丆丌一与;
        val_5 = val_5 ^ 1;
        val_6 = (Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  36)) + val_5;
        return (int)val_6;
    }
    public void TrySaveOnCheckpoint()
    {
        var val_20;
        var val_21;
        var val_22;
        if(this.CanSaveCheckpoint == false)
        {
                return;
        }
        
        bool val_19 = this.丆且且世丛丗三丁丌.savedInCheckpoint;
        val_19 = val_19 + 3;
        var val_20 = ~val_19;
        val_20 = val_20 & 3;
        if(val_20 != 0)
        {
                return;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_20 = null;
            val_20 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                int val_21 = this.丁世丝东专专业丈丕;
            val_21 = val_21 - 1;
            this.丁世丝东专专业丈丕 = val_21;
            this.丄丝七丕丙丝上专丞(丅专与丒丈丗丒丘丌:  this.丆且且世丛丗三丁丌);
            return;
        }
        
        }
        
        if(this.丅万万三丘丆丌一与 == false)
        {
            goto label_10;
        }
        
        if()
        {
            goto label_14;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  36, 丙业与丙丗丝不丈东:  (Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  36)) - 1);
        this.丄丝七丕丙丝上专丞(丅专与丒丈丗丒丘丌:  this.丆且且世丛丗三丁丌);
        Rilisoft.一丟专且三万丞丁丂.丑丐丟丗丂专丆丄不(丙业与丙丗丝不丈东:  "Ads");
        return;
        label_10:
        this.丅万万三丘丆丌一与 = true;
        this.丄丝七丕丙丝上专丞(丅专与丒丈丗丒丘丌:  this.丆且且世丛丗三丁丌);
        Rilisoft.一丟专且三万丞丁丂.丑丐丟丗丂专丆丄不(丙业与丙丗丝不丈东:  "Free");
        return;
        label_14:
        val_21 = null;
        val_21 = null;
        丈丞丕丘丕丗与上一 val_8 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  this.专丅专丈丘丌七上一, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
        {
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_8.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_29;
        }
        
        }
        
        val_22 = null;
        val_22 = null;
        上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  InGameGUI.丙丞专丌丁丞与不丐.gameObject, 丒世丘丘上丆丝东丞:  val_8, 七丒上且丝业业下七:  new System.Action(object:  this, method:  System.Void CheckpointController::丗三上丕一万东丁上()), 丝丏丗丄丗与丐丌三:  new System.Action(object:  JoystickController.丗三丄与丂丟丌专东, method:  public System.Void UIJoystick::Reset()), 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  97);
        return;
        label_29:
        UnityEngine.Debug.LogError(message:  "CheckpointController (not enough currency) -> GoToMainStore");
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_8.东与三丌丅三丒丏业(), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    private void 丄丝七丕丙丝上专丞(PlayerCheckpoint 丅专与丒丈丗丒丘丌)
    {
        PlayerCheckpoint val_5 = 丅专与丒丈丗丒丘丌;
        val_5 = 丅专与丒丈丗丒丘丌;
        goto label_8;
        label_11:
        SetCheckpointSaved(不丛丙三丂一丅丂丆:  true, 三万丙三丅业丂不下:  丅专与丒丈丗丒丘丌.Equals(other:  137109504));
        this.专且丆丘上丏丌且且.Add(item:  137109504);
        val_5 = 0;
        if(mem[137109528] != 0)
        {
                val_5 = mem[137109528];
        }
        
        label_8:
        if(val_5 != 0)
        {
            goto label_11;
        }
        
        this.savedCheckpoint = 丅专与丒丈丗丒丘丌;
        this.丗丒不东丁丌丞丒丂 = false;
    }
    public void RegisterInCheckpoint(PlayerCheckpoint 丅专与丒丈丗丒丘丌, bool 丄东丕一丟下丂上丂)
    {
        bool val_3 = 丄东丕一丟下丂上丂;
        if(val_3 == false)
        {
            goto label_1;
        }
        
        this.丄不业丝丅下丅与丂(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌);
        if(丅专与丒丈丗丒丘丌.isSavingCheckpoint == false)
        {
            goto label_3;
        }
        
        val_3 = 丅专与丒丈丗丒丘丌.savedInCheckpoint ^ 1;
        if(this != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        this.丗丒不东丁丌丞丒丂 = val_3;
        if(丅专与丒丈丗丒丘丌.next != 0)
        {
                return;
        }
        
        this.FinishRun();
        return;
        label_1:
        this.丗丒不东丁丌丞丒丂 = false;
        return;
        label_3:
        if(this != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    private void 丄不业丝丅下丅与丂(PlayerCheckpoint 丅专与丒丈丗丒丘丌)
    {
        this.丆且且世丛丗三丁丌 = 丅专与丒丈丗丒丘丌;
        if(丅专与丒丈丗丒丘丌.next != 0)
        {
                return;
        }
        
        this.丐世万专丈丁世丏丈(丌七丒世丄上丞丞丁:  丅专与丒丈丗丒丘丌.丌七丒世丄上丞丞丁);
    }
    public void StartRun()
    {
        if(this.丝丛一与丞丛万万丑 != false)
        {
                return;
        }
        
        this.丝丛一与丞丛万万丑 = true;
        this.东丒丕丈丌丁与丈丝 = false;
        this.万与下丐丏丝三三丟 = 0f;
        this.ResetCheckpoint();
    }
    public void StartNewLap()
    {
        var val_1;
        this.runFinishedOnce = true;
        if(this.丝丛一与丞丛万万丑 != true)
        {
                this.丝丛一与丞丛万万丑 = true;
            this.东丒丕丈丌丁与丈丝 = false;
            this.万与下丐丏丝三三丟 = 0f;
            this.ResetCheckpoint();
        }
        
        val_1 = null;
        val_1 = null;
        丕丛专丆丝丛丆丌丐();
    }
    public void FinishRun()
    {
        var val_12;
        int val_13;
        var val_14;
        var val_15;
        Rilisoft.七丕丟丏三丈一丄世 val_16;
        var val_17;
        if(this.丝丛一与丞丛万万丑 == false)
        {
                return;
        }
        
        this.丝丛一与丞丛万万丑 = true;
        this.东丒丕丈丌丁与丈丝 = true;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_12 = null;
            val_12 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) == true)
        {
                return;
        }
        
        }
        
        val_13 = this.lapTimeMili;
        if(this.bestLapTimeMili != 0)
        {
                val_13 = UnityEngine.Mathf.Min(a:  this.bestLapTimeMili, b:  val_13);
        }
        
        this.bestLapTimeMili = val_13;
        val_14 = null;
        val_14 = null;
        丆专世丒七丒东丕世(丙业与丙丗丝不丈东:  this.bestLapTimeMili);
        专丅世与下丕且且丕(专丞上七七且丝七丗:  0);
        val_15 = null;
        val_15 = null;
        GameController.mode.与丄下丑丈丗三丂丘(丙业与丙丗丝不丈东:  丑丛丆三丆丄七丐万());
        val_16 = GameConnect.丑丌丛丈丅丅与不业();
        int val_8 = Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  val_16);
        if(val_8 != 0)
        {
                if(val_8 <= this.bestLapTimeMili)
        {
            goto label_28;
        }
        
        }
        
        Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().专三七丞丂三丏丄东(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 万且丒下丕丝专丟上:  this.bestLapTimeMili);
        val_17 = null;
        val_17 = null;
        val_16 = this.bestLapTimeMili;
        FriendsController.丄丞丁丈与业上丞丟.SendScoreInMiniGames(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 业丌七业业七丞与丄:  val_16);
        this.丐丌丅丝丆丗与丝丝 = true;
        this.lapRecordTimeMili = this.bestLapTimeMili;
        goto label_37;
        label_28:
        this.丐丌丅丝丆丗与丝丝 = false;
        this.lapRecordTimeMili = val_8;
        label_37:
        Rilisoft.丞丛七上丕专丏丌丈.丐丒丝丒专不东丕丑();
        this.ShowLapFinishedInterface();
        Rilisoft.一丟专且三万丞丁丂.丁丂与且丈不丒三世(丂三丟丂丈丐丆丗丟:  this.万与下丐丏丝三三丟);
        if(this.runFinishedOnce == false)
        {
                return;
        }
        
        Rilisoft.一丟专且三万丞丁丂.与上丅上丞与丌七丒(丙业与丙丗丝不丈东:  "Completed");
    }
    public void EndRun()
    {
        this.东丒丕丈丌丁与丈丝 = false;
    }
    public void ShowLapFinishedInterface()
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                if(InGameGUIPart_DeathEscape.__il2cppRuntimeField_byval_arg.activeSelf != false)
        {
                return;
        }
        
        }
        
        ShowLapFinishedInterface(丟丘丂丂丘丆丕专丘:  this.lapTimeMili, 丈丙且丅丙七丞丞不:  this.bestLapTimeMili, 丑丘且丐与且丈丄上:  this.lapRecordTimeMili, 丘下且万业丐丗丕且:  (this.丐丌丅丝丆丗与丝丝 == true) ? 1 : 0);
    }
    private void 丐世万专丈丁世丏丈(float 丌七丒世丄上丞丞丁)
    {
        var val_8;
        var val_9;
        var val_10;
        WeaponManager val_11;
        this.distancePassed = UnityEngine.Mathf.Max(a:  丌七丒世丄上丞丞丁, b:  this.distancePassed);
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_16;
        }
        
        val_11 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_11 == null)
        {
            goto label_17;
        }
        
        label_16:
        东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Max(a:  丝丈丅一丆丗丝丝丘(), b:  (int)this.distancePassed));
        return;
        label_17:
    }
    private void Update()
    {
        var val_20;
        PlayerCheckpoint val_21;
        float val_22;
        float val_23;
        var val_24;
        float val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        if(this.丝丛一与丞丛万万丑 == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return;
        }
        
        val_21 = this.丆且且世丛丗三丁丌;
        if(val_21 == 0)
        {
                return;
        }
        
        val_21 = this.丆且且世丛丗三丁丌.next;
        if(val_21 == 0)
        {
                return;
        }
        
        val_22 = this.万与下丐丏丝三三丟;
        val_23 = val_22 + UnityEngine.Time.deltaTime;
        this.万与下丐丏丝三三丟 = val_23;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_24 = null;
            val_24 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                val_25 = (float)丛丑且业丗世丈丙丌.丏丙下丘业业七专东();
            val_23 = val_25 - this.万与下丐丏丝三三丟;
            if(val_23 <= 0f)
        {
                Rilisoft.LevelCompleteScript.一世丕丝丞丌七且丌(丙业与丙丗丝不丈东:  2);
            val_26 = null;
            val_26 = null;
            LevelCompleteLoader.七丐丅专且专七三丆 = 0;
            LevelCompleteLoader.专万丟三世业丙丈且 = "LevelComplete";
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "LevelToCompleteProm");
        }
        
        }
        
        }
        
        val_27 = null;
        val_27 = null;
        val_21 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_21 == 0)
        {
                return;
        }
        
        val_28 = null;
        val_28 = null;
        val_21 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_21 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(val_21 == 0)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        if(this.丄七丆丗东不丅丆丌 < 丝丈丅一丆丗丝丝丘())
        {
                float val_12 = UnityEngine.Time.time;
            if(this.丄丒世丝丘世丌丗丁 < 0)
        {
                val_25 = 1f;
            val_23 = UnityEngine.Time.time + val_25;
            this.丄丒世丝丘世丌丗丁 = val_23;
            val_30 = null;
            val_30 = null;
            this.丄七丆丗东不丅丆丌 = 丝丈丅一丆丗丝丝丘();
            丆丂东丏与不与不丟();
        }
        
        }
        
        val_21 = this.丆且且世丛丗三丁丌.next.transform;
        UnityEngine.Vector3 val_16 = val_21.position;
        UnityEngine.Vector3 val_18 = transform.position;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        val_22 = val_19.x;
        float val_20 = this.丆且且世丛丗三丁丌.next.丌七丒世丄上丞丞丁;
        val_20 = val_20 - val_22;
        this.reachedDistance = val_20;
        this.丐世万专丈丁世丏丈(丌七丒世丄上丞丞丁:  val_20);
    }
    public CheckpointController()
    {
        this.专且丆丘上丏丌且且 = new System.Collections.Generic.List<PlayerCheckpoint>(capacity:  10);
        this.下丝丏三三丛丛丑业 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  0f);
        this.专丅专丈丘丌七上一 = 1;
        this.丁世丝东专专业丈丕 = 3;
    }
    private void 丗三上丕一万东丁上()
    {
        Rilisoft.一丟专且三万丞丁丂.丌万专丘丄丌丏丑丅(丞一丁业丄一一业且:  "checkpoint", 丟不丏丕上丝世丌丛:  true);
        this.丄丝七丕丙丝上专丞(丅专与丒丈丗丒丘丌:  this.丆且且世丛丗三丁丌);
        Rilisoft.一丟专且三万丞丁丂.丑丐丟丗丂专丆丄不(丙业与丙丗丝不丈东:  "Bought");
    }

}
