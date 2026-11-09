using UnityEngine;
private sealed class RespawnWindowController.万丂丗丌丟丝东丅东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public 专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄;
    public RespawnWindowController 丝且与丝丒丟万丁专;
    public UnityEngine.Vector3 世业三丘丒丙丅丈丌;
    public UnityEngine.Quaternion 三上七丛丅丒七丒丒;
    public float 丆丐七丅丆丗丛上与;
    public System.Threading.CancellationToken 不丒三业下丑不丞业;
    private SkinName 东与上一丅三不不丕;
    private float 业一东丘丑丙一万丝;
    private bool 东上丏下且不万丈丈;
    private bool 丗丁丄丌东丅丑七丐;
    private float 丛丌丗丐不丗世丘丕;
    private bool 三丑丐与且丆业丂三;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RespawnWindowController.万丂丗丌丟丝东丅东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_59;
        NetworkStartTable val_60;
        UnityEngine.Vector3 val_61;
        float val_62;
        float val_63;
        var val_64;
        var val_66;
        float val_67;
        var val_68;
        var val_69;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝丞丛七且一丅丐丄 != null)
        {
                if(this.丝丞丛七且一丅丐丄.丝万丘丂与丄不丑不 == false)
        {
            goto label_12;
        }
        
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_12;
        }
        
        val_59 = null;
        val_59 = null;
        val_60 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_60 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(与丆东世一丆丕丛丘() == false)
        {
            goto label_12;
        }
        
        0.专三丟三且下丅丂丄(丄丈且丂丕丐丅丐七:  true);
        return false;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_15;
        label_12:
        typeof(RPG_Camera).__il2cppRuntimeField_9C = 1065353216;
        0.丌一丏业丟不丒丟不(丝丞丛七且一丅丐丄:  this.丝丞丛七且一丅丐丄);
        if((GameConnect.丅丟下专不丁一丈七() != true) && (this.丝丞丛七且一丅丐丄 != null))
        {
                val_61 = this.世业三丘丒丙丅丈丌;
            val_62 = val_61;
            val_63 = V9.16B;
            CameraSceneController.丄丞丁丈与业上丞丟.丐万丑丑且不丝丑丝(世业三丘丒丙丅丈丌:  new UnityEngine.Vector3() {x = val_62, y = val_63, z = V10.16B}, 三上七丛丅丒七丒丒:  new UnityEngine.Quaternion() {x = this.三上七丛丅丒七丒丒, y = V12.16B, z = V13.16B, w = V14.16B}, 丝丘与世丛丕丒丒一:  this.丝丞丛七且一丅丐丄.业七丑丁且丐丝上三);
        }
        else
        {
                CameraSceneController.丄丞丁丈与业上丞丟.业丌丑万丄万丆丒万();
        }
        
        val_64 = null;
        val_64 = null;
        与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 = true;
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_33;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.window.业丐丕上丈不世丕不();
        goto label_36;
        label_33:
        this.丝且与丝丒丟万丁专.window.下与丞三丅丛丄七丕(丟丑丞世世世丅丂丒:  this.丝丞丛七且一丅丐丄);
        label_36:
        this.东与上一丅三不不丕 = 0;
        if(this.丝丞丛七且一丅丐丄.丐丂上丛丁丄万丗万 != 0)
        {
                this.东与上一丅三不不丕 = this.丝丞丛七且一丅丐丄.丐丂上丛丁丄万丗万.GetComponent<SkinName>();
        }
        
        if(GameConnect.丒丗丁丙丗丄丙不丐() != false)
        {
                if(PlantTheBombController.丆丕丝丒不丙且丐丗.isMyTeamBomberRole != false)
        {
                this.丆丐七丅丆丗丛上与 = PlantTheBombController.丆丕丝丒不丙且丐丗.myRespawnCooldown;
        }
        
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_53;
        }
        
        val_66 = null;
        val_66 = null;
        if(与丆东世一丆丕丛丘() == false)
        {
            goto label_58;
        }
        
        val_62 = 5f;
        goto label_59;
        label_53:
        val_67 = this.丆丐七丅丆丗丛上与;
        goto label_60;
        label_58:
        val_68 = null;
        val_68 = null;
        val_62 = (float)MutationController.丆丕丝丒不丙且丐丗.丞专丏丙丅丗丙七七;
        label_59:
        val_67 = val_62;
        this.丆丐七丅丆丗丛上与 = val_62;
        label_60:
        this.业一东丘丑丙一万丝 = val_67;
        this.东上丏下且不万丈丈 = false;
        this.丗丁丄丌东丅丑七丐 = false;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_66;
        }
        
        val_69 = null;
        val_69 = null;
        if(SiegeController.三三万丆下一丗万丛.inAttackTeam == false)
        {
            goto label_70;
        }
        
        label_66:
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_73;
        }
        
        一丌与且丘丐上且丞 val_19 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().丛下丑丅丒丙丒丅丞();
        goto label_75;
        label_73:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_78;
        }
        
        一丌与且丘丐上且丞 val_22 = 世丐丟三丑一万丌一.丑七不且上丗丁一世().万丟丒三丝丛丆丁丙();
        label_75:
        val_62 = val_22.丂丝丌丞丄万不丝丝;
        goto label_119;
        label_70:
        val_71 = null;
        val_71 = null;
        val_62 = (float)与丂丏丛丞丞丒丟丄.丑三丁丑丐东万丟丟;
        goto label_119;
        label_78:
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_87;
        }
        
        val_72 = null;
        val_72 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_91;
        }
        
        }
        
        label_91:
        var val_24 = (null == null) ? GameController.onlineMode : 0;
        val_62 = mem[onlineMode == null ? GameController.onlineMode : 0 + 536 + 104];
        val_62 = onlineMode == null ? GameController.onlineMode : 0 + 536 + 104;
        goto label_119;
        label_87:
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_96;
        }
        
        float val_26 = PlantTheBombController.丆丕丝丒不丙且丐丗.myRespawnCooldown;
        goto label_119;
        label_96:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_101;
        }
        
        val_73 = null;
        val_73 = null;
        val_62 = 0f;
        if(与丆东世一丆丕丛丘() == true)
        {
            goto label_119;
        }
        
        val_74 = null;
        val_74 = null;
        val_62 = (float)MutationController.丆丕丝丒不丙且丐丗.丝丐上丘丟且丗一不;
        goto label_119;
        label_101:
        val_61 = 与丂丏丛丞丞丒丟丄.丄丒丏三丞丄丈丂丗(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业());
        PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_31 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  13);
        if(val_31 != null)
        {
                if((val_31.丛丅下丆丗丏三丁丕<FilterMaps>(丒丑丂丐丕丒丕东与:  "custom")) == 100)
        {
                val_75 = null;
            val_75 = null;
            val_61 = (float)与丂丏丛丞丞丒丟丄.丅上丑丗丘且丘丛丝;
        }
        
        }
        
        val_62 = 0f;
        if(val_61 > 0f)
        {
                val_62 = val_61 + 0.95f;
        }
        
        label_119:
        this.丛丌丗丐不丗世丘丕 = val_62;
        if(GameConnect.与不丗丏万丙丞丌丑() != true)
        {
                一三专丈世丑丆丑丐 val_34 = PlayerCoreSettingsStorager.dynamicSettings;
            val_61 = val_34.丅一丂丕世丑丗七三;
            val_63 = 0f;
            val_62 = val_61;
            if((UnityEngine.Mathf.Approximately(a:  val_62, b:  val_63)) != true)
        {
                一三专丈世丑丆丑丐 val_36 = PlayerCoreSettingsStorager.dynamicSettings;
            this.丛丌丗丐不丗世丘丕 = val_36.丅一丂丕世丑丗七三;
        }
        
        }
        
        this.三丑丐与且丆业丂三 = false;
        label_15:
        val_60 = 1152921505171275776;
        val_76 = null;
        val_76 = null;
        if(与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 == false)
        {
                return false;
        }
        
        if((this.不丒三业下丑不丞业 & 1) != 0)
        {
                return false;
        }
        
        if(this.东上丏下且不万丈丈 != true)
        {
                if(this.丝丞丛七且一丅丐丄.丐丂上丛丁丄万丗万 != 0)
        {
                UnityEngine.Vector3 val_38 = this.丝丞丛七且一丅丐丄.丐丂上丛丁丄万丗万.position;
            val_62 = -5000f;
            if(val_38.y > val_62)
        {
                if(this.东与上一丅三不不丕 != 0)
        {
                if(this.东与上一丅三不不丕.playerMoveC.万丝一万丐且丌业丛 == false)
        {
            goto label_149;
        }
        
        }
        
        }
        
        }
        
            this.丗丁丄丌东丅丑七丐 = true;
        }
        
        label_149:
        if(((this.东上丏下且不万丈丈 == true) || (this.丗丁丄丌东丅丑七丐 == false)) || (this.东与上一丅三不不丕 == 0))
        {
            goto label_165;
        }
        
        if(this.东与上一丅三不不丕.一七不三丌专三丆一 == false)
        {
            goto label_156;
        }
        
        label_168:
        this.东上丏下且不万丈丈 = true;
        RespawnWindow val_41 = this.丝且与丝丒丟万丁专.window;
        val_41.characterDrag.SetActive(value:  true);
        RespawnWindow val_42 = this.丝且与丝丒丟万丁专.window;
        val_42.cameraDrag.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.window.东丕丞丂一上业丂丐(丝丞丛七且一丅丐丄:  this.丝丞丛七且一丅丐丄);
        goto label_165;
        label_156:
        if(this.东与上一丅三不不丕.playerMoveC.万丝一万丐且丌业丛 == false)
        {
            goto label_168;
        }
        
        label_165:
        float val_44 = UnityEngine.Time.deltaTime;
        val_44 = this.丛丌丗丐不丗世丘丕 - val_44;
        this.丛丌丗丐不丗世丘丕 = val_44;
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_171;
        }
        
        val_77 = null;
        val_77 = null;
        if(丘万丈丒下丕且东丁() == false)
        {
            goto label_176;
        }
        
        label_171:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_179;
        }
        
        val_78 = null;
        val_78 = null;
        if(与丆东世一丆丕丛丘() == false)
        {
            goto label_184;
        }
        
        label_179:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_209;
        }
        
        label_210:
        label_209:
        this.丝且与丝丒丟万丁专.window.丆不丁丒丗丆丛丐专(丛与丙丒丒下丌丟且:  false);
        RespawnWindow val_50 = this.丝且与丝丒丟万丁专.window;
        if(this.丛丌丗丐不丗世丘丕 <= 0f)
        {
            goto label_188;
        }
        
        val_50.SetRespawnButtonActive(东丅丞丁丗万且丁丗:  false, 丘丟东丙一专万业丟:  GameConnect.丟丆丏上丌一丝丟业());
        this.丝且与丝丒丟万丁专.window.SetCanRespawnTime(丒丑丏与丄丈丄丌丝:  this.丛丌丗丐不丗世丘丕);
        goto label_202;
        label_188:
        val_50.SetRespawnButtonActive(东丅丞丁丗万且丁丗:  true, 丘丟东丙一专万业丟:  false);
        float val_54 = UnityEngine.Time.deltaTime;
        val_54 = this.业一东丘丑丙一万丝 - val_54;
        this.业一东丘丑丙一万丝 = val_54;
        this.丝且与丝丒丟万丁专.window.SetCurrentTime(丒丑丏与丄丈丄丌丝:  this.业一东丘丑丙一万丝);
        0.丆丒丕不与丈丞丘下(丄丕丝与丞下专丑丏: ref  this.三丑丐与且丆业丂三);
        if(this.业一东丘丑丙一万丝 > 0f)
        {
            goto label_202;
        }
        
        this.丝且与丝丒丟万丁专.window.CloseRespawnWindow();
        goto label_202;
        label_176:
        this.丝且与丝丒丟万丁专.window.SetRespawnButtonActive(东丅丞丁丗万且丁丗:  false, 丘丟东丙一专万业丟:  false);
        label_202:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return false;
        label_184:
        val_79 = null;
        val_79 = null;
        MutationController.丆丕丝丒不丙且丐丗.不丅丏与与三丒一万(丑业丗丑丒丘丆丁一:  this.丛丌丗丐不丗世丘丕, 专不万世丗业三丘丁:  this.业一东丘丑丙一万丝);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_209;
        }
        
        goto label_210;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
