using UnityEngine;
public class OfflineModeController : GameModeController
{
    // Methods
    public override void AfterInitialization()
    {
        this.AfterInitialization();
        this.丟丛专七不七丆三万();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        this.东丞丒丗专业且专丒();
        this.丟丛专七不七丆三万();
    }
    protected override void 丕丗东且一且且丘丂()
    {
        UnityEngine.GameObject val_11;
        var val_12;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  false);
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Player");
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        if(val_1 != null)
        {
                var val_4 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_11, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        val_5.丂丌丂丘丘上丘丌与(专丞上七七且丝七丗:  val_5);
        SkinName val_6 = val_5.GetComponent<SkinName>();
        val_12 = null;
        val_12 = null;
        丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 = val_6.firstPersonControl.playerCamera.camera;
        var val_12 = 0;
        val_12 = val_12 + 1;
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.丑与世丙与丗丛且丆(丕丕世且下一与丝与:  0.01f).GetEnumerator());
    }
    internal void 丂丌丂丘丘上丘丌与(UnityEngine.GameObject 专丞上七七且丝七丗)
    {
        float val_56;
        UnityEngine.Vector3 val_57;
        float val_58;
        float val_59;
        UnityEngine.Object val_60;
        var val_61;
        var val_62;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_5;
        }
        
        label_33:
        label_19:
        val_56 = 0f;
        label_109:
        if((PolygonController.一下一万丄丅丘且丑 == 0) || ((PolygonController.一下一万丄丅丘且丑 + 24) == 0))
        {
            goto label_10;
        }
        
        UnityEngine.Transform val_4 = PolygonController.一下一万丄丅丘且丑.下专丟世丏丏世世专();
        if(val_4 == null)
        {
            goto label_12;
        }
        
        UnityEngine.Vector3 val_5 = val_4.position;
        goto label_13;
        label_5:
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_16;
        }
        
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Arena_Underwater")) == false)
        {
            goto label_18;
        }
        
        goto label_19;
        label_16:
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_21;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_24;
        }
        
        if(((丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(丞世不丒下上上丝丑:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一())) == null) || (丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一() == 0))
        {
            goto label_30;
        }
        
        val_57 = val_13.上东丆丈业世七丈丁;
        goto label_31;
        label_18:
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Pizza")) == false)
        {
            goto label_33;
        }
        
        goto label_109;
        label_21:
        TrainingController val_17 = UnityEngine.Object.FindObjectOfType<TrainingController>();
        if(val_17 == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Vector3 val_19 = val_17.PlayerDesiredPosition;
        goto label_39;
        label_12:
        UnityEngine.Vector3 val_20 = 0.position;
        label_13:
        UnityEngine.Quaternion val_21 = val_4.rotation;
        val_56 = val_21.y;
        label_10:
        专丞上七七且丝七丗.transform.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_56, z:  0f);
        专丞上七七且丝七丗.transform.rotation = new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w};
        return;
        label_24:
        val_60 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PlayerRespawnPoint");
        if(val_60 != 0)
        {
            goto label_48;
        }
        
        UnityEngine.Debug.LogError(message:  "No respawn point for this mode!");
        goto label_109;
        label_37:
        UnityEngine.Vector3 val_27 = TrainingController.丘世与且万丟与丑一();
        label_39:
        if(val_17 == 0)
        {
            goto label_109;
        }
        
        float val_29 = val_17.三专丁不丝丄丒丅东();
        goto label_109;
        label_30:
        val_57 = 0f;
        val_58 = 0f;
        val_59 = 0f;
        label_31:
        int val_30 = 丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一();
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_61 = null;
            val_61 = null;
            if((((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false) && (CheckpointController.丄丘七三上丕世丞业 != 0)) && (CheckpointController.丄丘七三上丕世丞业.savedCheckpoint != 0))
        {
                if(PlayerCheckpoint.__il2cppRuntimeField_this_arg != 0)
        {
                val_62 = null;
            val_62 = null;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
            transform.localRotation = new UnityEngine.Quaternion() {x = val_38.x, y = val_38.y, z = val_38.z, w = val_38.w};
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_42 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            val_57 = val_42.x;
            val_58 = val_42.y;
            val_59 = val_42.z;
            丝丙与东丈不丙三丟().transform.rotation = new UnityEngine.Quaternion() {x = val_57, y = val_58, z = val_59, w = val_42.w};
            UnityEngine.Vector3 val_44 = PlayerCheckpoint.__il2cppRuntimeField_this_arg.transform.position;
            UnityEngine.Vector3 val_46 = PlayerCheckpoint.__il2cppRuntimeField_this_arg.transform.eulerAngles;
        }
        
        }
        
        }
        
        val_60 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PlayerRespawnPoint");
        if(val_60 == 0)
        {
            goto label_109;
        }
        
        label_48:
        UnityEngine.Vector3 val_50 = val_60.transform.position;
        UnityEngine.Quaternion val_52 = val_60.transform.rotation;
        goto label_109;
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
    }
    internal override void 丁三丅东三丅丄丘丙()
    {
        var val_28;
        var val_29;
        System.Action<System.Boolean> val_30;
        var val_31;
        var val_32;
        var val_34;
        var val_35;
        var val_36;
        var val_39;
        var val_40;
        string val_41;
        var val_42;
        var val_44;
        this.丁三丅东三丅丄丘丙();
        丟丌丁且且世丈丈丟.丅下丅丞与下丂丝且(丙业与丙丗丝不丈东:  this.丞丏丕丑丞丑丏丏丄());
        UnityEngine.Time.timeScale = 1f;
        UnityEngine.Time.timeScale = 1f;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_4;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_7;
        }
        
        Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丐丐三七丆丂丄三丘();
        if(this.丞丏丕丑丞丑丏丏丄() > (-1320199072))
        {
                val_28 = null;
            val_28 = null;
            丟丌丁且且世丈丈丟.丒且业丝丟下丅丛丛 = true;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丒不丒与丏与且丅(丞与丙丞丌业一万丄:  this.丞丏丕丑丞丑丏丏丄(), 丕丛丂万丂专丈一不:  1);
            val_29 = null;
            val_29 = null;
            FriendsController.丄丞丁丈与业上丞丟.SendScoreInMiniGames(丂丛丑东不丅丈一东:  12, 业丌七业业七丞与丄:  this.丞丏丕丑丞丑丏丏丄());
            业丂丏与世一丏业不.丑七不且上丗丁一世().三丐丌丟丄丁丞丏丕(丙业与丙丗丝不丈东:  this.丞丏丕丑丞丑丏丏丄());
            业丂丏与世一丏业不.丑七不且上丗丁一世().丑丁丏万丌丆丝丝与();
        }
        
        val_30 = "SendFirstResaltArena";
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "SendFirstResaltArena", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 1)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "SendFirstResaltArena", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            Rilisoft.一丟专且三万丞丁丂.丅丂丘与万丂丗不东(世下丐丌一丗一丞丌:  true, 一丘丆丟丞丄一丐丅:  false);
        }
        
        UnityEngine.Debug.Log(message:  "Player_move_c.QuitGame(): Trying to report survival score: "("Player_move_c.QuitGame(): Trying to report survival score: ") + this.丞丏丕丑丞丑丏丏丄());
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
        {
            goto label_35;
        }
        
        AGSLeaderboardsClient.SubmitScore(leaderboardId:  "best_survival_scores", score:  (long)this.丞丏丕丑丞丑丏丏丄(), userData:  0);
        goto label_70;
        label_4:
        val_31 = 1152921505078358016;
        val_32 = null;
        val_32 = null;
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        string val_19 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        val_34 = null;
        goto label_43;
        label_7:
        if(GameConnect.万七丄丛丈丟专一丑() == true)
        {
            goto label_70;
        }
        
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_49;
        }
        
        val_31 = 1152921505078358016;
        val_35 = null;
        if(Rilisoft.LevelCompleteScript.丌与三丆丕丈万丙丅() != 2)
        {
            goto label_52;
        }
        
        val_36 = null;
        goto label_55;
        label_35:
        if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
        {
            goto label_70;
        }
        
        var val_29 = 0;
        val_29 = val_29 + 1;
        goto label_63;
        label_49:
        val_39 = null;
        goto label_66;
        label_52:
        val_40 = null;
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        val_34 = null;
        val_41 = "ChooseLevel";
        goto label_69;
        label_63:
        if(UnityEngine.Social.localUser.authenticated != false)
        {
                val_42 = null;
            val_42 = null;
            val_30 = OfflineModeController.<>c.<>9__5_0;
            if(val_30 == null)
        {
                System.Action<System.Boolean> val_28 = null;
            val_30 = val_28;
            val_28 = new System.Action<System.Boolean>(object:  OfflineModeController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void OfflineModeController.<>c::丝丟丄丗丂七东丕一(bool 丐万丗丒下七丟丁三));
            OfflineModeController.<>c.<>9__5_0 = val_30;
        }
        
            UnityEngine.Social.ReportScore(score:  (long)this.丞丏丕丑丞丑丏丏丄(), board:  "CgkIr8rGkPIJEAIQCg", callback:  val_28);
        }
        
        label_70:
        val_39 = null;
        label_66:
        Rilisoft.LevelCompleteScript.一世丕丝丞丌七且丌(丙业与丙丗丝不丈东:  1);
        val_31 = 1152921505078358016;
        val_44 = null;
        val_44 = null;
        label_55:
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        val_41 = "LevelComplete";
        label_69:
        label_43:
        LevelCompleteLoader.专万丟三世业丙丈且 = val_41;
    }
    public OfflineModeController()
    {
    
    }

}
