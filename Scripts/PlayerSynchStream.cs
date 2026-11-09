using UnityEngine;
internal sealed class PlayerSynchStream : VTableHolder
{
    // Fields
    internal int 丂丈万丂上丒专不丂;
    internal float 世专丞丄丙丌丞丂丙;
    internal bool 东下一丛丒丝丅丕丁;
    internal Player_move_c playerMovec;
    internal bool 丁世丅丁丂上且丘东;
    private double 丘专丗上东七丟三不;
    private bool 丆丆丂一丅丐丐丁丝;
    public FirstPersonControlSharp personController;
    private PlayerSynchStream.丝丙丒丌东下丕丘丘[] 东专业丑与丐丆丐丟;
    internal SkinName skinName;
    internal bool 专丞世丒丞丞不丝东;
    internal bool 丕不丛丕丛丘丙丑丂;
    internal bool 业丂万丏丒丛丒万且;
    internal bool 丘丟丄丗丞丝丘东七;
    private bool 丅一世丞丌丟丂下丞;
    private bool 丌且下丕下下丌万丞;
    internal bool 一七不三丌专三丆一;
    internal PlayerBotController 业丌东七七丒世丞万;
    private UnityEngine.Transform 丛丄与丌丛万业丝丞;
    private bool 丅世丄与下丞丘业丁;
    private double 丝丈丂丙三丐丏丐业;
    private UnityEngine.Vector3 且东三丅丕下丄丒丒;
    private bool 一且三上上业丒丘丐;
    private double 世且丑丏业丅丄丐与;
    private float 专下丘与三丐丏专丝;
    private double 丞丟上丕丈下东丆丄;
    private int 下丐丑丛与丈丏丅七;
    private double 丌专万世与丕万丈丅;
    private UnityEngine.Transform 下三专不丘业丂丌丛;
    private UnityEngine.Vector3 丕丂丐世丌丗丙丙丅;
    private float 丆专丄丄东上丁丏丑;
    private float 与丄丟东丆东丑丞专;
    internal static readonly float 专丛丟丗与万万丆丄;
    
    // Properties
    private bool 下不丂丑丏三丆丗下 { get; }
    
    // Methods
    private bool 上且东专专丆丄丁丒()
    {
        if(this.丂丈万丂上丒专不丂 <= 0)
        {
                return (bool)(this.世专丞丄丙丌丞丂丙 > UnityEngine.Time.realtimeSinceStartup) ? 1 : 0;
        }
        
        return true;
    }
    private void Awake()
    {
        var val_3;
        丝丙丒丌东下丕丘丘[] val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        this.丛丄与丌丛万业丝丞 = this.transform;
        val_4 = new 丝丙丒丌东下丕丘丘[5];
        val_5 = 0;
        this.东专业丑与丐丆丐丟 = val_4;
        goto label_4;
        label_8:
        mem[88] = 0;
        val_4 = this.东专业丑与丐丆丐丟;
        val_5 = 1;
        label_4:
        if(val_5 < this.东专业丑与丐丆丐丟.Length)
        {
            goto label_8;
        }
        
        return;
        label_3:
        this.enabled = false;
    }
    internal PlayerSynchStream()
    {
        this.丘专丗上东七丟三不 = -1;
        this.丆丆丂一丅丐丐丁丝 = true;
        this.业丂万丏丒丛丒万且 = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.且东三丅丕下丄丒丒 = val_1;
        mem[1152921535943406796] = val_1.y;
        mem[1152921535943406800] = val_1.z;
        this.一且三上上业丒丘丐 = true;
        this.专下丘与三丐丏专丝 = 100f;
        this.丞丟上丕丈下东丆丄 = -2.2250738585072E-308;
        this.丌专万世与丕万丈丅 = -2.2250738585072E-308;
        Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
        val_2.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void PlayerSynchStream::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
    }
    private void Start()
    {
        var val_7;
        PlayerBotController val_2 = PlayerBotController.不世丂丏丒万世东丂(丁世丛业丟下丕三丟:  this.photonView);
        this.业丌东七七丒世丞万 = val_2;
        this.一七不三丌专三丆一 = UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
        val_7 = null;
        val_7 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        if(this.一七不三丌专三丆一 == true)
        {
                return;
        }
        
        this.丌且下丕下下丌万丞 = true;
    }
    internal void 丞上丞与丁三一丙丗()
    {
        this.丁世丅丁丂上且丘东 = true;
    }
    internal void 三丕丌丟丛东一丁丏(UnityEngine.Vector3 丙丆丗业丌丏业丒丝)
    {
        this.丅世丄与下丞丘业丁 = true;
        this.丝丈丂丙三丐丏丐业 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.且东三丅丕下丄丒丒 = 丙丆丗业丌丏业丒丝;
        mem[1152921535943775564] = 丙丆丗业丌丏业丒丝.y;
        mem[1152921535943775568] = 丙丆丗业丌丏业丒丝.z;
    }
    internal void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        PlayerBotMovement val_135;
        float val_137;
        float val_138;
        float val_139;
        var val_141;
        var val_143;
        var val_144;
        byte val_145;
        var val_146;
        var val_147;
        object val_148;
        object val_149;
        var val_150;
        string val_151;
        float val_152;
        var val_153;
        float val_154;
        var val_155;
        object val_156;
        var val_157;
        double val_158;
        float val_159;
        float val_160;
        float val_161;
        var val_162;
        UnityEngine.Transform val_163;
        byte val_164;
        var val_165;
        var val_166;
        var val_167;
        bool val_168;
        object val_169;
        var val_170;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_137 = val_2.x;
        val_138 = val_2.y;
        val_139 = val_2.z;
        if((东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false) && (this.一七不三丌专三丆一 != false))
        {
                val_135 = this.业丌东七七丒世丞万.movement;
            val_135.下丅上一丕丁三丆丟(东业丄丅丅且世七丄:  东业丄丅丅且世七丄);
        }
        
        if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
        {
                if(this.一七不三丌专三丆一 == false)
        {
            goto label_10;
        }
        
        }
        
        label_266:
        if(东业丄丅丅且世七丄 != null)
        {
            goto label_271;
        }
        
        label_272:
        label_271:
        if(东业丄丅丅且世七丄.丟东七不丕丞七丆丑() == false)
        {
                return;
        }
        
        object val_6 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_7 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_8 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_9 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_10 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        object val_11 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        bool val_13 = System.Convert.ToBoolean(value:  0);
        this.丅一世丞丌丟丂下丞 = val_13;
        this.playerMovec.万丝一万丐且丌业丛 = val_13;
        bool val_14 = System.Convert.ToBoolean(value:  0);
        this.playerMovec.东丌丟丄丒丙丗丙专(丙业与丙丗丝不丈东:  System.Convert.ToBoolean(value:  0));
        this.丕不丛丕丛丘丙丑丂 = System.Convert.ToBoolean(value:  0);
        bool val_19 = System.Convert.ToBoolean(value:  0);
        if(val_19 != false)
        {
                object val_20 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        }
        else
        {
                val_141 = 0;
        }
        
        this.业丂万丏丒丛丒万且 = System.Convert.ToBoolean(value:  0);
        this.丘丟丄丗丞丝丘东七 = System.Convert.ToBoolean(value:  0);
        if((System.Convert.ToBoolean(value:  0)) != false)
        {
                object val_26 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_43;
        }
        
        }
        
        object val_29 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        if(this.playerMovec != 0)
        {
                if(this.playerMovec.丟三丏丅世一丟丟上 != 0)
        {
                this.playerMovec.丟三丏丅世一丟丟上.东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  21884928);
        }
        
        }
        
        label_43:
        if(东业丄丅丅且世七丄 == null)
        {
            goto label_46;
        }
        
        val_144 = 东业丄丅丅且世七丄;
        val_145 = 东业丄丅丅且世七丄.专丗丒东丂万丂万丟;
        goto label_47;
        label_10:
        val_146 = 1152921504848912384;
        if(this.personController != 0)
        {
                val_135 = this.personController;
            if(this.personController.且丆丅丏丌丗丛丄丌 == true)
        {
                return;
        }
        
        }
        
        if(this.playerMovec.万丝一万丐且丌业丛 == false)
        {
            goto label_54;
        }
        
        val_147 = 1;
        goto label_95;
        label_46:
        val_144 = 40;
        val_145 = 104;
        label_47:
        if(东业丄丅丅且世七丄.丂丁丏一丙丛业且丌() <= 104)
        {
            goto label_56;
        }
        
        object val_34 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        val_146 = System.Convert.ToBoolean(value:  0);
        val_148 = 1152921504628731904;
        val_143 = null;
        if(this.playerMovec.丙不丅丕三丂业东丕() == 0)
        {
            goto label_68;
        }
        
        val_143 = null;
        if(this.playerMovec.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东() == 0)
        {
            goto label_68;
        }
        
        if((System.Convert.ToBoolean(value:  1152921504628731904 & 2)) == false)
        {
            goto label_69;
        }
        
        val_149 = null;
        if((this.playerMovec.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().IsPlaying(name:  "Walk")) == true)
        {
            goto label_73;
        }
        
        val_143 = "Idle";
        if((this.playerMovec.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().IsPlaying(name:  "Idle")) == false)
        {
            goto label_116;
        }
        
        label_73:
        val_150 = this.playerMovec.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈();
        val_151 = "Charge";
        goto label_81;
        label_56:
        val_148 = 1152921504628731904;
        val_146 = 0;
        label_68:
        val_149 = null;
        label_116:
        val_152 = 1.152922E+18f;
        if(东业丄丅丅且世七丄 != null)
        {
                val_153 = 104;
        }
        else
        {
                val_153 = 104;
        }
        
        float val_51 = (1.152922E+18f) / 10f;
        val_154 = val_152 / 10f;
        var val_53 = (东业丄丅丅且世七丄.丂丁丏一丙丛业且丌() <= 104) ? 1 : 0;
        val_53 = val_19 | val_53;
        if(val_53 != false)
        {
                val_135 = val_14;
            val_155 = 1;
        }
        else
        {
                val_135 = val_14;
            object val_54 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            object val_55 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            this.专丘丐丐世专丆丗上(丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = val_2.y, z = val_2.z}, 丝一丌与世下一丈丞:  val_51, 丘丑业一东丞丘丟七:  val_154, 丄丆万一丙丂丕不丐:  1.28822976017949E-231, 丆丄七丙丅丈上丞一:  21884928, 丈丙丟上丁丗丕丐七:  val_135, 业七丄丌丏丁丑不下:  false, 七丛丌丞丐丆丐专丛:  0, 丌丘丐丟丆且三丄丙:  new UnityEngine.Vector3() {x = val_148, y = val_139}, 丈不丁万且丐丂丐下:  this.业丂万丏丒丛丒万且, 不东一丏丟丕丆一一:  this.丘丟丄丗丞丝丘东七, 业丟且丐丏丒丁丟丞:  true);
            val_155 = 2;
        }
        
        val_156 = null;
        this.专丘丐丐世专丆丗上(丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = 3.782474E-38f, z = 3.782474E-38f}, 丝一丌与世下一丈丞:  val_51, 丘丑业一东丞丘丟七:  val_154, 丄丆万一丙丂丕不丐:  1.28822976017949E-231, 丆丄七丙丅丈上丞一:  21884928, 丈丙丟上丁丗丕丐七:  val_135, 业七丄丌丏丁丑不下:  val_19, 七丛丌丞丐丆丐专丛:  0, 丌丘丐丟丆且三丄丙:  new UnityEngine.Vector3() {x = val_148, y = val_139}, 丈不丁万且丐丂丐下:  this.业丂万丏丒丛丒万且, 不东一丏丟丕丆一一:  this.丘丟丄丗丞丝丘东七, 业丟且丐丏丒丁丟丞:  false);
        if(this.丆丆丂一丅丐丐丁丝 == false)
        {
            goto label_88;
        }
        
        this.丆丆丂一丅丐丐丁丝 = false;
        goto label_89;
        label_88:
        if((val_146 & 1) != 0)
        {
            goto label_103;
        }
        
        if(this.一且三上上业丒丘丐 == false)
        {
            goto label_91;
        }
        
        val_157 = this;
        val_158 = null - this.世且丑丏业丅丄丐与;
        val_135 = 1152921535944533576;
        mem[1152921535944533576] = val_158;
        goto label_92;
        label_54:
        if(this.playerMovec.丘七业丒丐世丂丅丒() <= 0f)
        {
            goto label_94;
        }
        
        val_147 = 0;
        goto label_95;
        label_91:
        val_135 = this;
        val_158 = this.丘专丗上东七丟三不;
        val_157 = 1152921535944533672;
        label_92:
        val_158 = null - val_158;
        val_156 = 2;
        this.世且丑丏业丅丄丐与 = val_158;
        if(val_158 > val_156)
        {
                this.丁丂丘丒丙丗丂丈与(丏丙东丂一丄丌丐丟:  0, 下丝丐东丏丟丈丅丄:  1f);
            this.丘专丗上东七丟三不 = this.东专业丑与丐丆丐丟[7];
        }
        
        if(this.丆专丄丄东上丁丏丑 <= 0f)
        {
                val_135 = this.东专业丑与丐丆丐丟;
            var val_60 = val_135 + (val_155 * 88);
            val_154 = mem[(val_155 * 88) + this.东专业丑与丐丆丐丟 + 88];
            val_154 = (val_155 * 88) + this.东专业丑与丐丆丐丟 + 88;
            if(((float)this.丆丙丝且丒三一万丕(东上丞丝丞不世丌丏:  val_154 - this.丘专丗上东七丟三不)) > 0f)
        {
                this.丆专丄丄东上丁丏丑 = (float)this.丆丙丝且丒三一万丕(东上丞丝丞不世丌丏:  val_154 - this.丘专丗上东七丟三不);
            double val_63 = this.丆丙丝且丒三一万丕(东上丞丝丞不世丌丏:  0);
        }
        
        }
        
        label_103:
        this.一且三上上业丒丘丐 = val_146 & 1;
        label_89:
        if(((this.丘专丗上东七丟三不 >= 0) && (this.丅一世丞丌丟丂下丞 != true)) && (this.丕不丛丕丛丘丙丑丂 != true))
        {
                UnityEngine.Vector3 val_65 = this.丛丄与丌丛万业丝丞.position;
            if(val_65.y >= 0)
        {
                return;
        }
        
        }
        
        this.丘专丗上东七丟三不 = null;
        this.丁丂丘丒丙丗丂丈与(丏丙东丂一丄丌丐丟:  0, 下丝丐东丏丟丈丅丄:  1f);
        return;
        label_69:
        if((this.playerMovec.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈().IsPlaying(name:  "Charge")) == false)
        {
            goto label_116;
        }
        
        val_150 = this.playerMovec.丙不丅丕三丂业东丕().丌丙丆下专丝丑且丈();
        val_151 = "Idle";
        label_81:
        bool val_71 = val_150.Play(animation:  val_151);
        goto label_116;
        label_94:
        label_95:
        if(this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗 != false)
        {
                PlatformController[] val_74 = PlatformsList.丄丘七三上丕世丞业.platforms + ((this.playerMovec.mySkinName.firstPersonControl.下丈丞丝与上下丝丙) << 3);
            UnityEngine.Vector3 val_76 = this.丛丄与丌丛万业丝丞.position;
            val_159 = val_76.x;
            val_160 = val_76.y;
            val_161 = val_76.z;
            UnityEngine.Vector3 val_77 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (this.playerMovec.mySkinName.firstPersonControl.下丈丞丝与上下丝丙) << 3) + 32].transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_159, y = val_160, z = val_161});
        }
        else
        {
                UnityEngine.Vector3 val_78 = this.丛丄与丌丛万业丝丞.position;
            val_159 = val_78.x;
            val_160 = val_78.y;
            val_161 = val_78.z;
            UnityEngine.Vector3 val_79 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_159, y = val_160, z = val_161}, b:  new UnityEngine.Vector3() {x = this.playerMovec.丈丄丑东业丌七东丄, y = V12.16B, z = val_138});
        }
        
        val_162 = null;
        val_162 = null;
        if(((GameController.mode.IsControllerBattleRoyalType == false) || (this.playerMovec.与丏下丝万上三丛不() == false)) || (this.playerMovec.东三上专丅东业丛丐() == 0))
        {
            goto label_145;
        }
        
        val_163 = this.playerMovec.东三上专丅东业丛丐().transform;
        if(val_163 != null)
        {
            goto label_154;
        }
        
        goto label_154;
        label_145:
        val_163 = this.丛丄与丌丛万业丝丞;
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_154;
        }
        
        UnityEngine.Quaternion val_85 = val_163.localRotation;
        goto label_155;
        label_154:
        UnityEngine.Quaternion val_86 = val_163.rotation;
        label_155:
        UnityEngine.Quaternion val_88 = this.playerMovec.myTransform.localRotation;
        float val_139 = this.playerMovec.mySkinName.firstPersonControl.万丗丈丗三不丌不丆;
        if(this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗 != false)
        {
                val_164 = this.playerMovec.mySkinName.firstPersonControl.下丈丞丝与上下丝丙;
        }
        else
        {
                val_164 = 0;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_185;
        }
        
        }
        
        if(this.playerMovec.mySkinName.firstPersonControl.丑丞丒丟丞丟丆丁一 != false)
        {
                UnityEngine.Quaternion val_95 = this.playerMovec.mySkinName.FPSplayerObject.transform.parent.localRotation;
            val_165 = val_95.x;
            val_166 = 1;
        }
        else
        {
                label_185:
            val_166 = 0;
        }
        
        int val_138 = System.Convert.ToInt32(value:  (this.playerMovec.丐下丘丟丁丆丟丆丈() <= 0f) ? 1 : 0);
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
            goto label_196;
        }
        
        val_167 = null;
        val_167 = null;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
            goto label_200;
        }
        
        label_196:
        label_275:
        if(this.丕不丛丕丛丘丙丑丂 != false)
        {
                val_168 = 1;
        }
        else
        {
                val_168 = this.playerMovec.一专丑丗丝七丗丑丕();
        }
        
        val_138 = val_138 | ((System.Convert.ToInt32(value:  ((this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true) ? 1 : 0) & 1)) << 1);
        int val_106 = val_138 | ((System.Convert.ToInt32(value:  this.playerMovec.丏下丙丞丕丕丏丕丞())) << 2);
        if(this.丘丟丄丗丞丝丘东七 != false)
        {
                this.丘丟丄丗丞丝丘东七 = false;
        }
        
        this.丕不丛丕丛丘丙丑丂 = false;
        val_106 = val_106 | ((System.Convert.ToInt32(value:  val_168)) << 3);
        val_139 = val_88.x - val_139;
        val_106 = val_106 | ((System.Convert.ToInt32(value:  this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗)) << 4);
        val_139 = val_139 - this.playerMovec.mySkinName.playerAnimation.丗丞万不上丁丘丄丑;
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_79);
        val_106 = val_106 | ((System.Convert.ToInt32(value:  false)) << 5);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  (int)val_86.y * 10f);
        val_106 = val_106 | ((System.Convert.ToInt32(value:  this.业丂万丏丒丛丒万且)) << 6);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  (int)val_139 * 10f);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.skinName.playerAnimation.丄丙丂丝丄丌丗丂丅());
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_106 | ((System.Convert.ToInt32(value:  this.丘丟丄丗丞丝丘东七)) << 7));
        if(this.playerMovec.mySkinName.firstPersonControl.上丘丂丌丑东上且丗 != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  0);
        }
        
        if(val_166 != 0)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_2);
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_231;
        }
        
        }
        
        if((this.playerMovec != 0) && (this.playerMovec.丟三丏丅世一丟丟上 != 0))
        {
                val_169 = this.playerMovec.丟三丏丅世一丟丟上;
            int val_118 = val_169.丝丈丅一丆丗丝丝丘();
        }
        else
        {
                val_169 = 0;
        }
        
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_169);
        label_231:
        if((this.playerMovec.丙不丅丕三丂业东丕() != 0) && (this.playerMovec.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东() != 0))
        {
                val_170 = this.playerMovec.丙不丅丕三丂业东丕().丄丞丑丙丟丟一丏东().丑丛丛丌丝丘东七业();
        }
        else
        {
                val_170 = 0;
        }
        
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  (System.Convert.ToInt32(value:  (丅丒丗丑丒丙丛不丆.丑上丞丒丞丁七丌七() < 10) ? 1 : 0)) | ((System.Convert.ToInt32(value:  false)) << 1));
        if(this.丅世丄与下丞丘业丁 != false)
        {
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丝丈丂丙三丐丏丐业);
            东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.且东三丅丕下丄丒丒);
        }
        
        this.丅世丄与下丞丘业丁 = false;
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_266;
        }
        
        丅丑丞上丛丆东丟丂.三丅丐业丙丕丙业丕(丑与丆丝丕东丛丄丝:  "Stream " + this.GetType(), 丗丟上上丒丐丗丞丙:  东业丄丅丅且世七丄.东与上丗与丏下丂丘());
        if(东业丄丅丅且世七丄 != null)
        {
            goto label_271;
        }
        
        goto label_272;
        label_200:
        bool val_136 = 丘丐丘万丌丟丞下丝.不丐且丞世业不丆丝();
        goto label_275;
    }
    private double 丆丙丝且丒三一万丕(double 东上丞丝丞不世丌丏)
    {
        double val_1 = this.丞丟上丕丈下东丆丄;
        if(val_1 > 东上丞丝丞不世丌丏)
        {
                this.丞丟上丕丈下东丆丄 = 东上丞丝丞不世丌丏;
            this.丌专万世与丕万丈丅 = -2.2250738585072E-308;
            this.下丐丑丛与丈丏丅七 = 0;
            val_1 = 东上丞丝丞不世丌丏;
            return val_1;
        }
        
        int val_1 = this.下丐丑丛与丈丏丅七;
        if((this.专下丘与三丐丏专丝 <= (float)val_1) && (this.丌专万世与丕万丈丅 < 0))
        {
                this.丞丟上丕丈下东丆丄 = this.丌专万世与丕万丈丅;
            this.丌专万世与丕万丈丅 = -2.2250738585072E-308;
            this.下丐丑丛与丈丏丅七 = 0;
            val_1 = this.丌专万世与丕万丈丅;
            return val_1;
        }
        
        if(this.丌专万世与丕万丈丅 > 东上丞丝丞不世丌丏)
        {
                this.丌专万世与丕万丈丅 = 东上丞丝丞不世丌丏;
        }
        
        val_1 = val_1 + 1;
        this.下丐丑丛与丈丏丅七 = val_1;
        return val_1;
    }
    private void LateUpdate()
    {
        if(this.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        if(this.丅一世丞丌丟丂下丞 != true)
        {
                if(this.下三专不丘业丂丌丛 != 0)
        {
                UnityEngine.Vector3 val_2 = this.下三专不丘业丂丌丛.TransformPoint(position:  new UnityEngine.Vector3() {x = this.丕丂丐世丌丗丙丙丅, y = V9.16B, z = V10.16B});
            this.丛丄与丌丛万业丝丞.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
            if(this.丅一世丞丌丟丂下丞 != true)
        {
                if(this.丁世丅丁丂上且丘东 == false)
        {
                return;
        }
        
        }
        
        }
        
        this.下三专不丘业丂丌丛 = 0;
        UnityEngine.Vector3 val_4 = this.transform.position;
        if(val_4.y <= (-8000f))
        {
                return;
        }
        
        this = this.transform;
        this.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        UnityEngine.Transform val_24;
        var val_25;
        var val_26;
        UnityEngine.Transform val_27;
        var val_28;
        Player_move_c val_29;
        UnityEngine.Transform val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        double val_37;
        float val_38;
        float val_39;
        var val_40;
        float val_41;
        val_24 = this;
        if(this.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        if(this.playerMovec.丙丌丅丆丅世世七丛 != true)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_7;
        }
        
        }
        
        if(this.playerMovec.丞丕丗丟丗丛丐与三 != true)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_13;
        }
        
        }
        
        if((GameConnect.丙丌丒丈东七丒上丌() == false) || (this.playerMovec.丟三丏丅世一丟丟上.丑丈上东丗丐丆世上() == true))
        {
            goto label_30;
        }
        
        val_25 = null;
        val_25 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_30;
        }
        
        val_26 = null;
        val_26 = null;
        if(丑丈上东丗丐丆世上() == false)
        {
            goto label_30;
        }
        
        label_13:
        val_27 = this.丛丄与丌丛万业丝丞;
        if(val_27 != null)
        {
            goto label_35;
        }
        
        goto label_32;
        label_30:
        if(this.丅一世丞丌丟丂下丞 != true)
        {
                if(this.丁世丅丁丂上且丘东 == false)
        {
            goto label_34;
        }
        
        }
        
        val_27 = this.丛丄与丌丛万业丝丞;
        this.下三专不丘业丂丌丛 = 0;
        if(val_27 != null)
        {
            goto label_35;
        }
        
        label_32:
        label_35:
        UnityEngine.Vector3 val_5 = val_27.position;
        if(val_5.y <= (-8000f))
        {
                return;
        }
        
        val_24 = this.丛丄与丌丛万业丝丞;
        label_64:
        val_24.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_7:
        val_28 = null;
        val_28 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_51;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(this.playerMovec.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == false)
        {
            goto label_51;
        }
        
        }
        
        if(this.playerMovec.丁三三丒丌与丄丑丁 == false)
        {
            goto label_51;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_54;
        }
        
        val_29 = this.playerMovec;
        if(this.playerMovec != null)
        {
            goto label_55;
        }
        
        val_29 = this.playerMovec;
        if(val_29 == null)
        {
            goto label_56;
        }
        
        label_55:
        val_30 = this.丛丄与丌丛万业丝丞;
        val_31 = 0f;
        val_32 = 0f;
        val_33 = 0f;
        if(val_30 != null)
        {
            goto label_94;
        }
        
        goto label_58;
        label_51:
        UnityEngine.Vector3 val_9 = this.丛丄与丌丛万业丝丞.position;
        if(val_9.y <= (-8000f))
        {
                return;
        }
        
        UnityEngine.Vector3 val_10 = this.丛丄与丌丛万业丝丞.position;
        UnityEngine.Vector3 val_11 = this.丛丄与丌丛万业丝丞.position;
        if(this.丛丄与丌丛万业丝丞 != null)
        {
            goto label_64;
        }
        
        goto label_64;
        label_34:
        if(this.丘专丗上东七丟三不 <= 0f)
        {
                return;
        }
        
        val_34 = this.丆专丄丄东上丁丏丑;
        val_35 = 0f;
        if(val_34 > 0f)
        {
                val_35 = UnityEngine.Time.deltaTime * 0.2f;
            val_34 = this.丆专丄丄东上丁丏丑 - val_35;
            this.丆专丄丄东上丁丏丑 = val_34;
            if(val_34 < 0)
        {
                val_35 = val_35 - val_34;
        }
        
        }
        
        val_37 = (double)val_35;
        val_38 = this.丘专丗上东七丟三不 + (double)UnityEngine.Time.deltaTime;
        val_39 = val_38 + val_37;
        label_72:
        if(0 >= this.东专业丑与丐丆丐丟.Length)
        {
            goto label_69;
        }
        
        var val_14 = this.东专业丑与丐丆丐丟 + (0 * 88);
        val_38 = mem[(0 * 88) + this.东专业丑与丐丆丐丟 + 88];
        val_38 = (0 * 88) + this.东专业丑与丐丆丐丟 + 88;
        var val_15 = 0 + 1;
        if(val_38 > val_39)
        {
            goto label_72;
        }
        
        label_69:
        int val_16 = 0 - 1;
        if((val_16 & 2147483648) != 0)
        {
            goto label_73;
        }
        
        this.与丄丟东丆东丑丞专 = 0f;
        int val_29 = this.东专业丑与丐丆丐丟.Length;
        val_29 = val_29 - 1;
        if(val_16 >= val_29)
        {
                var val_30 = -4294967296;
            val_30 = val_30 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_18 = this.东专业丑与丐丆丐丟 + ((val_30 >> 32) * 88);
            if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 88) + this.东专业丑与丐丆丐丟 + 118) == 0)
        {
                float val_19 = UnityEngine.Time.deltaTime;
            val_37 = 0.3f;
            val_19 = val_19 * val_37;
            val_38 = (double)val_19;
            val_39 = val_39 + val_38;
        }
        
        }
        
        var val_20 = this.东专业丑与丐丆丐丟 + ((long)val_16 * 88);
        if((((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 96) == 0)
        {
            goto label_81;
        }
        
        if(this.东专业丑与丐丆丐丟 != null)
        {
            goto label_106;
        }
        
        label_107:
        label_106:
        var val_21 = this.东专业丑与丐丆丐丟 + ((long)val_16 * 88);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丕丂丐世丌丗丙丙丅, y = this.丘专丗上东七丟三不, z = V10.16B}, b:  new UnityEngine.Vector3() {x = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 32, y = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4, z = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 40});
        val_40 = null;
        val_40 = null;
        if(val_22.x >= 0)
        {
            goto label_88;
        }
        
        var val_23 = this.东专业丑与丐丆丐丟 + ((long)val_16 * 88);
        float val_31 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 88;
        val_31 = val_31 - this.丘专丗上东七丟三不;
        val_31 = (val_39 - this.丘专丗上东七丟三不) / val_31;
        goto label_91;
        label_73:
        val_41 = this.与丄丟东丆东丑丞专 + UnityEngine.Time.deltaTime;
        this.与丄丟东丆东丑丞专 = val_41;
        this.丆专丄丄东上丁丏丑 = 0f;
        goto label_92;
        label_54:
        val_30 = this.丛丄与丌丛万业丝丞;
        val_31 = this.playerMovec.丄丈丐世丄丁与三不;
        if(val_30 != null)
        {
            goto label_94;
        }
        
        label_58:
        label_94:
        val_30.position = new UnityEngine.Vector3() {x = val_31, y = V9.16B, z = V10.16B};
        this.丛丄与丌丛万业丝丞.rotation = new UnityEngine.Quaternion() {x = this.playerMovec.业丞丛丌丘丝丗三丙, y = V9.16B, z = V10.16B, w = V11.16B};
        return;
        label_88:
        var val_26 = this.东专业丑与丐丆丐丟 + ((long)val_16 * 88);
        val_39 = mem[((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 88];
        val_39 = ((long)(int)((0 - 1)) * 88) + this.东专业丑与丐丆丐丟 + 88;
        label_91:
        this.丁丂丘丒丙丗丂丈与(丏丙东丂一丄丌丐丟:  val_16, 下丝丐东丏丟丈丅丄:  1f);
        val_41 = this.与丄丟东丆东丑丞专;
        this.丘专丗上东七丟三不 = val_39;
        label_92:
        一三专丈世丑丆丑丐 val_27 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_41 <= val_27.丌丕丁上七一丕不丕)
        {
                return;
        }
        
        this.丏丑不丕丅丒丑不丟();
        return;
        label_81:
        UnityEngine.Vector3 val_28 = this.丛丄与丌丛万业丝丞.position;
        if(this.东专业丑与丐丆丐丟 != null)
        {
            goto label_106;
        }
        
        goto label_107;
        label_56:
    }
    private void 丏丑不丕丅丒丑不丟()
    {
        InGameGUI val_5;
        BadNetworkBlinkingController val_6;
        val_5 = this;
        一三专丈世丑丆丑丐 val_1 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_1.丟丁丌丆丌丏丈与东 == false)
        {
                return;
        }
        
        int val_2 = 丅丒丗丑丒丙丛不丆.丒丘丞东丝东七一丛();
        一三专丈世丑丆丑丐 val_3 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_3.丙丙丌丐丅丗丟丌世 >= 0)
        {
            goto label_10;
        }
        
        val_5 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 544];
        val_6 = InGameGUI.丙丞专丌丁丞与不丐.badConnectionIcon;
        if(null != 0)
        {
            goto label_18;
        }
        
        goto label_16;
        label_10:
        val_6 = this.playerMovec.badConnectionIcon;
        if(val_6 != null)
        {
            goto label_18;
        }
        
        label_16:
        label_18:
        val_6.世丅丟专丄丘万丒丟();
    }
    private void 丁丂丘丒丙丗丂丈与(int 丏丙东丂一丄丌丐丟, float 下丝丐东丏丟丈丅丄)
    {
        float val_53;
        var val_54;
        float val_55;
        float val_56;
        var val_57;
        var val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_65;
        float val_66;
        float val_67;
        var val_68;
        var val_69;
        float val_70;
        var val_72;
        float val_73;
        float val_74;
        var val_75;
        float val_76;
        float val_77;
        float val_78;
        float val_79;
        var val_80;
        var val_81;
        var val_82;
        var val_1 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 96) == 0)
        {
            goto label_3;
        }
        
        var val_2 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        PlatformController[] val_3 = PlatformsList.丄丘七三上丕世丞业.platforms + ((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3);
        if(this.下三专不丘业丂丌丛 == (mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48))
        {
            goto label_12;
        }
        
        this.下三专不丘业丂丌丛 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48;
        UnityEngine.Vector3 val_5 = this.丛丄与丌丛万业丝丞.position;
        UnityEngine.Vector3 val_6 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 97) << 3) + 32] + 48.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_53 = val_6.z;
        val_54 = this;
        mem[1152921535947669040] = val_53;
        val_55 = val_6.x;
        val_56 = val_6.y;
        val_57 = 1152921535947669040;
        val_58 = 1152921535947669040;
        mem[1152921535947669032] = val_55;
        mem[1152921535947669036] = val_56;
        goto label_15;
        label_3:
        this.下三专不丘业丂丌丛 = 0;
        if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_26;
        }
        
        UnityEngine.Vector3 val_7 = this.丛丄与丌丛万业丝丞.position;
        val_53 = val_7.z;
        var val_8 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_59 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 32];
        val_59 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 32;
        val_60 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 40];
        val_60 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 40;
        val_61 = val_59;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_53}, b:  new UnityEngine.Vector3() {x = val_61, y = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4, z = val_60}, t:  下丝丐东丏丟丈丅丄);
        val_55 = val_9.y;
        val_65 = val_9.x;
        val_66 = val_55;
        val_67 = val_9.z;
        this.丛丄与丌丛万业丝丞.position = new UnityEngine.Vector3() {x = val_65, y = val_66, z = val_67};
        goto label_26;
        label_12:
        val_57 = this;
        val_55 = this.丕丂丐世丌丗丙丙丅;
        val_58 = 1152921535947669032;
        val_54 = 1152921535947669032;
        val_56 = mem[1152921535947669036];
        val_53 = mem[1152921535947669040];
        label_15:
        var val_10 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_59 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 32];
        val_59 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 32;
        val_60 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 40];
        val_60 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 40;
        val_65 = val_55;
        val_66 = val_56;
        val_67 = val_53;
        val_61 = val_59;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_65, y = val_66, z = val_67}, b:  new UnityEngine.Vector3() {x = val_61, y = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 32 + 4, z = val_60}, t:  下丝丐东丏丟丈丅丄);
        this.丕丂丐世丌丗丙丙丅 = val_11.x;
        mem[1152921535947669036] = val_11.y;
        mem[1152921535947669040] = val_11.z;
        label_26:
        val_68 = null;
        val_68 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
        {
                if(this.东下一丛丒丝丅丕丁 == false)
        {
            goto label_34;
        }
        
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
            goto label_37;
        }
        
        val_69 = null;
        val_69 = null;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
            goto label_44;
        }
        
        label_37:
        var val_13 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_44;
        }
        
        UnityEngine.Quaternion val_14 = this.丛丄与丌丛万业丝丞.localRotation;
        val_60 = val_14.w;
        var val_15 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_70 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_70 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_59 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_59 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_60}, b:  new UnityEngine.Quaternion() {x = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_70, z = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_59}, t:  下丝丐东丏丟丈丅丄);
        val_55 = val_16.y;
        val_53 = val_16.w;
        if(this.丛丄与丌丛万业丝丞 != null)
        {
            goto label_145;
        }
        
        label_146:
        label_145:
        val_65 = val_16.x;
        val_66 = val_55;
        val_67 = val_16.z;
        val_61 = val_53;
        this.丛丄与丌丛万业丝丞.localRotation = new UnityEngine.Quaternion() {x = val_65, y = val_66, z = val_67, w = val_61};
        goto label_159;
        label_44:
        val_72 = null;
        val_72 = null;
        if(GameController.mode.IsControllerBattleRoyalType != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_159;
        }
        
        }
        
        UnityEngine.Quaternion val_17 = this.丛丄与丌丛万业丝丞.rotation;
        val_60 = val_17.w;
        var val_18 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_70 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4];
        val_70 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 44 + 4;
        val_59 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4];
        val_59 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 52 + 4;
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_60}, b:  new UnityEngine.Quaternion() {x = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 44, y = val_70, z = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 52, w = val_59}, t:  下丝丐东丏丟丈丅丄);
        val_55 = val_19.y;
        val_53 = val_19.w;
        if(this.丛丄与丌丛万业丝丞 != null)
        {
            goto label_162;
        }
        
        label_163:
        label_162:
        val_65 = val_19.x;
        val_66 = val_55;
        val_67 = val_19.z;
        val_61 = val_53;
        this.丛丄与丌丛万业丝丞.rotation = new UnityEngine.Quaternion() {x = val_65, y = val_66, z = val_67, w = val_61};
        label_159:
        if(this.东下一丛丒丝丅丕丁 == false)
        {
            goto label_67;
        }
        
        if(this.skinName.playerAnimation == 0)
        {
            goto label_70;
        }
        
        UnityEngine.Quaternion val_22 = this.playerMovec.myTransform.localRotation;
        var val_23 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_73 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_73 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_70 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4];
        val_70 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        val_59 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4];
        val_59 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4;
        UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, b:  new UnityEngine.Quaternion() {x = val_73, y = val_70, z = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68, w = val_59}, t:  下丝丐东丏丟丈丅丄);
        val_74 = val_24.y;
        val_60 = val_24.w;
        val_75 = 1;
        val_76 = val_24.x;
        val_77 = val_74;
        val_78 = val_24.z;
        val_79 = val_60;
        goto label_79;
        label_67:
        if(this.skinName.playerAnimation == 0)
        {
            goto label_82;
        }
        
        var val_26 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_73 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60];
        val_73 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60;
        val_74 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68];
        val_74 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68;
        val_76 = val_73;
        val_77 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        val_78 = val_74;
        val_79 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4;
        val_75 = 0;
        label_79:
        this.skinName.playerAnimation.下丞且东三三丂丒下(丘丒丒丙丆不丝丂丂:  new UnityEngine.Quaternion() {x = val_76, y = val_77, z = val_78, w = val_79}, 丞丆业与丄丟丂三丈:  false);
        goto label_87;
        label_70:
        UnityEngine.Transform val_27 = this.playerMovec.myTransform;
        UnityEngine.Quaternion val_29 = this.playerMovec.myTransform.localRotation;
        val_60 = val_29.w;
        var val_30 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        val_70 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4];
        val_70 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60 + 4;
        val_59 = mem[((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4];
        val_59 = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68 + 4;
        UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_60}, b:  new UnityEngine.Quaternion() {x = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 60, y = val_70, z = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 68, w = val_59}, t:  下丝丐东丏丟丈丅丄);
        val_73 = val_31.x;
        val_74 = val_31.z;
        if(val_27 != null)
        {
            goto label_150;
        }
        
        label_151:
        label_150:
        val_76 = val_73;
        val_77 = val_31.y;
        val_78 = val_74;
        val_79 = val_31.w;
        val_27.localRotation = new UnityEngine.Quaternion() {x = val_76, y = val_77, z = val_78, w = val_79};
        label_87:
        var val_32 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        this.skinName.playerAnimation.丌七丗东三丏东丅丕(丙业与丙丗丝不丈东:  ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 76);
        var val_33 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        this.skinName.playerAnimation.一丙世丐且东与丁丘(丙业与丙丗丝不丈东:  ((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 116) != 0) ? 1 : 0);
        var val_35 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        var val_36 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        this.skinName.playerAnimation.丌万下世丟丅丁七丐(丂丛不丐丏丂丕丙丞:  ((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 96) != 0) ? 1 : 0, 丘丒丌下丕专且七专:  ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 97);
        var val_38 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 117) != 0)
        {
                var val_39 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
            mem2[0] = 0;
            this.skinName.playerAnimation.丌业丈丏东上丕丟世();
        }
        
        val_80 = null;
        val_80 = null;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
                return;
        }
        
        UnityEngine.Quaternion val_44 = this.skinName.FPSplayerObject.transform.parent.localRotation;
        var val_45 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        UnityEngine.Quaternion val_46 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_44.x, y = val_44.y, z = val_44.z, w = val_44.w}, b:  new UnityEngine.Quaternion() {x = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 100, y = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 100 + 4, z = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 108, w = ((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 108 + 4}, t:  下丝丐东丏丟丈丅丄);
        this.skinName.FPSplayerObject.transform.parent.localRotation = new UnityEngine.Quaternion() {x = val_46.x, y = val_46.y, z = val_46.z, w = val_46.w};
        return;
        label_34:
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
            goto label_135;
        }
        
        val_81 = null;
        val_81 = null;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
            goto label_142;
        }
        
        label_135:
        var val_48 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if((((long)(int)(丏丙东丂一丄丌丐丟) * 88) + this.东专业丑与丐丆丐丟 + 80) == 0)
        {
            goto label_142;
        }
        
        var val_49 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if(this.丛丄与丌丛万业丝丞 != null)
        {
            goto label_145;
        }
        
        goto label_146;
        label_82:
        var val_51 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if(this.playerMovec.myTransform != null)
        {
            goto label_150;
        }
        
        goto label_151;
        label_142:
        val_82 = null;
        val_82 = null;
        if(GameController.mode.IsControllerBattleRoyalType != false)
        {
                if(this.playerMovec.mySkinName.firstPersonControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_159;
        }
        
        }
        
        var val_52 = this.东专业丑与丐丆丐丟 + ((long)丏丙东丂一丄丌丐丟 * 88);
        if(this.丛丄与丌丛万业丝丞 != null)
        {
            goto label_162;
        }
        
        goto label_163;
    }
    private void 专丘丐丐世专丆丗上(UnityEngine.Vector3 丑丏与上不丐丘丕丐, float 丝一丌与世下一丈丞, float 丘丑业一东丞丘丟七, double 丄丆万一丙丂丕不丐, int 丆丄七丙丅丈上丞一, bool 丈丙丟上丁丗丕丐七, bool 业七丄丌丏丁丑不下, byte 七丛丌丞丐丆丐专丛, UnityEngine.Vector3 丌丘丐丟丆且三丄丙, bool 丈不丁万且丐丂丐下, bool 不东一丏丟丕丆一一, bool 业丟且丐丏丒丁丟丞 = False)
    {
        float val_13;
        丝丙丒丌东下丕丘丘 val_15;
        丝丙丒丌东下丕丘丘[] val_16;
        丝丙丒丌东下丕丘丘[] val_17;
        丝丙丒丌东下丕丘丘 val_19;
        var val_20;
        val_15 = 丄丆万一丙丂丕不丐;
        val_16 = this;
        val_17 = this.东专业丑与丐丆丐丟;
        if(this.东专业丑与丐丆丐丟 == null)
        {
                val_17 = this.东专业丑与丐丆丐丟;
        }
        
        int val_15 = this.东专业丑与丐丆丐丟.Length;
        var val_1 = (val_17 == null) ? 1 : 0;
        int val_2 = val_15 - 1;
        if(val_2 >= 1)
        {
                val_15 = val_15 - 2;
            var val_16 = (long)val_2;
            var val_3 = X11 + 32;
            int val_4 = val_15 + 32;
            do
        {
            val_2 = val_2 - 1;
            val_17 = this.东专业丑与丐丆丐丟;
            val_16 = val_16 - 1;
            val_3 = val_3 - 88;
            val_4 = val_4 - 88;
            var val_5 = (val_17 == null) ? 1 : 0;
        }
        while(val_2 > 0);
        
        }
        
        val_17[0] = 丑丏与上不丐丘丕丐.x;
        val_17[0] = 丑丏与上不丐丘丕丐.y;
        val_17[1] = 丑丏与上不丐丘丕丐.z;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  丝一丌与世下一丈丞, z:  0f);
        this.东专业丑与丐丆丐丟[1] = val_6.x;
        this.东专业丑与丐丆丐丟[2] = val_6.y;
        this.东专业丑与丐丆丐丟[2] = val_6.z;
        this.东专业丑与丐丆丐丟[3] = val_6.w;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(x:  丘丑业一东丞丘丟七, y:  0f, z:  0f);
        val_19 = val_7.y;
        this.东专业丑与丐丆丐丟[3] = val_7.x;
        this.东专业丑与丐丆丐丟[4] = val_19;
        this.东专业丑与丐丆丐丟[4] = val_7.z;
        this.东专业丑与丐丆丐丟[5] = val_7.w;
        this.东专业丑与丐丆丐丟[7] = val_15;
        this.东专业丑与丐丆丐丟[5] = 丆丄七丙丅丈上丞一;
        bool val_8 = 丈丙丟上丁丗丕丐七;
        this.东专业丑与丐丆丐丟[6] = val_8;
        this.东专业丑与丐丆丐丟[8] = 业七丄丌丏丁丑不下;
        this.东专业丑与丐丆丐丟[8] = 七丛丌丞丐丆丐专丛;
        this.东专业丑与丐丆丐丟[10] = 丈不丁万且丐丂丐下;
        this.东专业丑与丐丆丐丟[10] = 不东一丏丟丕丆一一;
        this.东专业丑与丐丆丐丟[10] = 业丟且丐丏丒丁丟丞;
        this.专丞世丒丞丞不丝东 = val_8;
        val_20 = null;
        val_20 = null;
        if(GameController.mode.IsControllerBattleRoyalType == false)
        {
                return;
        }
        
        val_16 = this.东专业丑与丐丆丐丟;
        UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 丌丘丐丟丆且三丄丙.x, y = val_13, z = 丌丘丐丟丆且三丄丙.y});
        val_15 = val_14.x;
        val_19 = val_14.z;
        val_16[8] = val_15;
        val_16[9] = val_14.y;
        val_16[9] = val_19;
        val_16[10] = val_14.w;
    }
    private static PlayerSynchStream()
    {
        PlayerSynchStream.专丛丟丗与万万丆丄 = 900f;
    }

}
