using UnityEngine;
internal sealed class SkinName : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal const string 丒下丑丏三丝丟丗丐 = "Hats/";
    internal const string 丌世丑丐一一丞七业 = "RoyaleHatsVisual/";
    internal const string 丅上丛七七且一东不 = "Armor_sniper";
    public Rilisoft.AreaVisitMonitor areaVisitMonitor;
    public UnityEngine.GameObject armorPoint;
    public UnityEngine.Transform[] armsBonesForRoyalAvatar;
    public UnityEngine.GameObject armsRoot;
    public UnityEngine.GameObject bodyLayer;
    public UnityEngine.GameObject capesPoint;
    public UnityEngine.CharacterController character;
    public UnityEngine.AudioClip crouchAudio;
    public UnityEngine.AudioClip flyClip;
    public UnityEngine.AudioClip flyDineClip;
    public UnityEngine.GameObject FPSplayerObject;
    public UnityEngine.GameObject hatsPoint;
    public UnityEngine.GameObject hatWear;
    public UnityEngine.GameObject maskWear;
    public UnityEngine.GameObject headObj;
    public PlayerSynchStream interpolateScript;
    public bool isMine;
    public UnityEngine.AudioClip jumpAudio;
    public UnityEngine.AudioClip jumpDownAudio;
    public UnityEngine.AudioClip cableCarAttachAudio;
    public UnityEngine.AudioClip cableCarSlidingAudio;
    public UnityEngine.AudioClip cableCarDetachAudio;
    public UnityEngine.AudioClip[] jumpSpeedrunAudio;
    public UnityEngine.GameObject LeftBootPoint;
    public UnityEngine.GameObject maskPoint;
    public UnityEngine.Transform onGroundEffectsPoint;
    public PlayerAnimationWrapper playerAnimation;
    public UnityEngine.GameObject playerGameObject;
    public Player_move_c playerMoveC;
    public UnityEngine.GameObject RightBootPoint;
    public UnityEngine.Transform[] trailPoints;
    public UnityEngine.AudioClip walkAudio;
    public UnityEngine.AudioClip walkMechBear;
    internal UnityEngine.AudioSource 东且下上丒上七东丞;
    internal WeaponManager 丐下丁三且丗上丈东;
    internal UnityEngine.Vector3 丅丁丏丅丄丌专丟丕;
    internal int 丄与丟丞丌丆丐丟万;
    internal string 东业丌丆丆丕丘丒万;
    internal string 丟东丞丂丗丘七丗丛;
    internal ArmorRefs 丈丈丒且丕丕东丙丞;
    internal string 丗丝丅丅丂七东丞专;
    internal string 丌专专万丟业与丂东;
    internal UnityEngine.Texture 丞丌且不三丝丈丝丐;
    internal string 丟丕业丒丝专丁丗丗;
    internal string 丑三东下丁七业丕丝;
    internal string 丄丏丒丁丈丂七丅丑;
    internal string 丁丅上丟丑三且且丆;
    internal string 与丁丝七丕业业丄且;
    internal string 丈丐专业不丆丕丙一;
    internal string 丁万业丒丝丗丂专且;
    internal bool 东丌下一一丅与丌丟;
    internal bool 三不丂七世丄业丐丗;
    internal bool 丈东不三一丅丑丏丘;
    internal bool 丒丙丒丟丈丅丛一三;
    internal bool 丌丞丐丕丁且丁丐丅;
    internal bool 三丙丌丏下丝上丟丙;
    internal bool 业丘丏丐丐丅丕一丟;
    internal bool 万丆丏与丕东下丈丐;
    internal bool 世丐七东上万丌丌丛;
    internal bool 三丒丘丏七七丙业丌;
    internal bool 丛丒丟丝万与下丈世;
    public FirstPersonControlSharp firstPersonControl;
    internal UnityEngine.Animation 不丙丏三丟丛丒与丅;
    internal bool 一不丅丑与丑丘世七;
    internal bool 丁东三丞丏丑丆业下;
    internal bool 丝丙七丒且丂丝与丏;
    internal bool 丒丘三丁丄丘丅丂三;
    internal bool 丁丑丅丏丒不七上丁;
    internal bool 丗且丝世丕三业上丁;
    internal string 不与丏上丐七丄专且;
    internal bool 且丟三丘丒丈丝丆丝;
    internal bool 丐世丑丘丞下丏丑丘;
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    internal PixelView 丘丘丘丏丌丁丐丆丗;
    internal bool 丏上东丁丛七丑丛丌;
    internal string 丝丘丅与丌丗丅丈下;
    internal bool 三上丒三专丆丌与下;
    internal ThirdPersonAnimationWrapper 丛丞七丏丑业丂丕丟;
    internal bool 丑三丈丈不丏丙且且;
    internal bool 专世下丟丟与丅万上;
    internal bool 丅丛东丂丄东专丄丟;
    internal bool 丛不世丑不丅与丁丒;
    internal bool 且丌丄丒一丑丌丐一;
    internal bool 丙丛丌三七丌丛丌丙;
    internal SkinName.丙七丄东丙专丒七不 丛七业丝丈三丁丝丐;
    internal bool 世下丗丅丗丆万丝上;
    internal int 七三不三万丟与万丞;
    internal bool 一七不三丌专三丆一;
    internal PlayerBotController 业丌东七七丒世丞万;
    private bool 与丌丝丄丑丄下业丁;
    private bool 业丄且丆丁且丈丕丅;
    private bool 丁与丕三丈丝世上丂;
    private bool 丁丆专丛丐丙丑丛七;
    private bool 丛东丄丟不丑丘且三;
    private bool 业丘丐丅业七业丆且;
    private bool 一丈不丟丑万丅丈丑;
    private bool 丝丟下丗业丞东丈下;
    private bool 丅丏不七上七万一专;
    private UnityEngine.Transform jumpDustPoint;
    private float 丘丟丄丐丒且专世丟;
    private bool 丙专丒丆丑七丞上且;
    private bool 下丌丑业丕丕丘丆七;
    internal bool 丒东丒丑七且丌丗专;
    internal bool 丏丁丕丅万丝丌丏且;
    internal bool 丏丝丁下丗丗丕与丕;
    internal bool 七丈丑丘丂七丘上万;
    internal bool 世丟丘丞丌丁丙丕丕;
    internal bool 丕七丟三丗三丐业丁;
    internal bool 丛丑上一丗丒丘丗丈;
    internal bool 丒丕丄丆专丂丛丙万;
    private System.Collections.Generic.List<PlayerEffectSettings> 丏丒丛业下业七且丅;
    private UnityEngine.Coroutine 丝丅丈丆东丞专丘三;
    private UnityEngine.Coroutine 丟丗丛丝不世下东丅;
    private UnityEngine.Coroutine 丙三与丏七一丘专丒;
    private UnityEngine.Coroutine 丒丒丂丂丛丌丐丈专;
    private UnityEngine.Coroutine 丁丈丌丏万七七丟丁;
    private const string 七丝丑丐丌丕丁专专 = "aquarium";
    
    // Properties
    internal UnityEngine.AudioClip 不丑丅丆丄三丂丏东 { get; }
    internal bool 丗丗丄东丑丘丕世业 { get; }
    
    // Methods
    internal SkinName()
    {
        this.东业丌丆丆丕丘丒万 = System.String.alignConst;
        this.丏丒丛业下业七且丅 = new System.Collections.Generic.List<PlayerEffectSettings>();
        Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
        val_2.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void SkinName::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    internal UnityEngine.AudioClip 业丂丕丄丕下丗丒丘()
    {
        PlayerMechBody val_3;
        UnityEngine.AudioClip val_4;
        var val_5;
        val_3 = this;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_4 = this.walkMechBear;
        }
        else
        {
                val_5 = 0;
            if(this.playerMoveC.丑丝丂丗丝丛与不七 == 0)
        {
                return (UnityEngine.AudioClip)val_5;
        }
        
            val_3 = this.playerMoveC.丑丝丂丗丝丛与不七;
            val_4 = this.playerMoveC.丑丝丂丗丝丛与不七.stepSound;
        }
        
        val_5 = mem[this.playerMoveC.丑丝丂丗丝丛与不七.stepSound];
        return (UnityEngine.AudioClip)val_5;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_27;
        var val_28;
        var val_29;
        var val_30;
        bool val_31;
        var val_32;
        var val_33;
        var val_34;
        System.Byte[] val_35;
        int val_36;
        int val_37;
        int val_38;
        System.String[] val_39;
        System.Int32[] val_40;
        System.Single[] val_41;
        System.Single[] val_42;
        val_27 = 丞世不丒下上上丝丑;
        byte val_1 = val_27 & 255;
        if(val_1 > 78)
        {
            goto label_1;
        }
        
        if(val_1 > 73)
        {
            goto label_2;
        }
        
        byte val_2 = val_27 & 255;
        val_28 = 0;
        if(val_2 > 61)
        {
            goto label_3;
        }
        
        if(val_2 == 59)
        {
            goto label_4;
        }
        
        if(val_2 != 60)
        {
                return (bool)val_28;
        }
        
        this.上丒丈世丗丆丗丛下(丞一丁业丄一一业且:  专丒丌丆下丐丞丟丞[0], 七丅丅世丆丆丗丟丐:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
        goto label_97;
        label_1:
        if(val_1 > 162)
        {
            goto label_10;
        }
        
        byte val_4 = val_27 & 255;
        if(val_4 == 91)
        {
            goto label_11;
        }
        
        if(val_4 != 162)
        {
            goto label_30;
        }
        
        if(专丒丌丆下丐丞丟丞.Length != 2)
        {
            goto label_14;
        }
        
        val_27 = 专丒丌丆下丐丞丟丞[0];
        if(((val_27 == null) || (null != null)) || ((专丒丌丆下丐丞丟丞[1] == null) || (null != null)))
        {
            goto label_97;
        }
        
        val_27 = System.Convert.ToBoolean(value:  val_27);
        this.丏上东丁丛七丑丛丌 = val_27;
        this.三上丒三专丆丌与下 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[1]);
        goto label_97;
        label_2:
        byte val_9 = val_27 & 255;
        if(val_9 == 74)
        {
            goto label_23;
        }
        
        if(val_9 != 78)
        {
            goto label_30;
        }
        
        this.不一丙东七下不丕丑(丞一丁业丄一一业且:  专丒丌丆下丐丞丟丞[0], 七丅丅世丆丆丗丟丐:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
        goto label_97;
        label_10:
        byte val_11 = val_27 & 255;
        if(val_11 == 167)
        {
            goto label_29;
        }
        
        if(val_11 != 189)
        {
            goto label_30;
        }
        
        this.丛七业丝丈三丁丝丐 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        goto label_97;
        label_30:
        val_28 = 0;
        return (bool)val_28;
        label_3:
        if(val_2 == 62)
        {
            goto label_37;
        }
        
        if(val_2 != 73)
        {
                return (bool)val_28;
        }
        
        val_27 = 专丒丌丆下丐丞丟丞[0];
        if(专丒丌丆下丐丞丟丞.Length <= 1)
        {
                val_29 = 0;
        }
        
        if(专丒丌丆下丐丞丟丞.Length <= 2)
        {
                val_30 = 0;
        }
        
        this.丟丕业丒丝专丁丗丗 = val_27;
        this.丑三东下丁七业丕丝 = 专丒丌丆下丐丞丟丞[1];
        this.丄丏丒丁丈丂七丅丑 = 专丒丌丆下丐丞丟丞[2];
        goto label_97;
        label_11:
        val_27 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[0]);
        val_31 = System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[2]);
        this.丆丙上世丟丐与三丑(丑下万丂丞不七丄三:  val_27, 丅丒丆三丌七丟七与:  System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[1]), 丂丈业东丛且丈一下:  val_31, 丒丒丏业专丌丑丟丆:  System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[3]));
        goto label_97;
        label_23:
        this.丘丄丏世丒上东丘丒(丞一丁业丄一一业且:  专丒丌丆下丐丞丟丞[0], 七丅丅世丆丆丗丟丐:  (this.世丟丘丞丌丁丙丕丕 == false) ? 1 : 0);
        goto label_97;
        label_29:
        val_27 = 专丒丌丆下丐丞丟丞[0];
        if(专丒丌丆下丐丞丟丞.Length <= 1)
        {
                val_32 = 0;
        }
        
        this.一丄七丝万与丆丞丒(丑专丂业丑不且丕丞:  val_27, 丕且与丅丕东七丂七:  专丒丌丆下丐丞丟丞[1]);
        goto label_97;
        label_4:
        val_27 = 专丒丌丆下丐丞丟丞[0];
        if(专丒丌丆下丐丞丟丞.Length <= 1)
        {
                val_33 = 0;
        }
        
        this.丒丒一上专丄不世丆(丆丛丙与下丟丕东上:  val_27, 上不专东上丐丁丁三:  专丒丌丆下丐丞丟丞[1], 丘一万丌丙丑丝丅丁:  System.Convert.ToBoolean(value:  专丒丌丆下丐丞丟丞[2]));
        goto label_97;
        label_37:
        val_34 = null;
        val_27 = 专丒丌丆下丐丞丟丞[0];
        if(专丒丌丆下丐丞丟丞.Length == 0)
        {
                val_34 = 0;
        }
        
        object val_46 = 专丒丌丆下丐丞丟丞[0];
        if(val_27 == null)
        {
            goto label_77;
        }
        
        if(val_46 == null)
        {
            goto label_78;
        }
        
        val_27 = null;
        val_35 = val_46;
        if(val_35 != null)
        {
            goto label_79;
        }
        
        label_78:
        val_35 = 0;
        label_79:
        this.丞丙丞专丐一三丁一(丒丏丁丛业丞世丅业:  val_35);
        goto label_97;
        label_14:
        if(专丒丌丆下丐丞丟丞.Length < 4)
        {
            goto label_97;
        }
        
        val_36 = 专丒丌丆下丐丞丟丞.Length;
        val_27 = new System.Int32[][0];
        if(val_36 == 5)
        {
                object val_47 = 专丒丌丆下丐丞丟丞[4];
            if(val_47 != null)
        {
                val_27 = val_47;
            if(val_27 == null)
        {
                val_27 = 0;
        }
        
            val_37 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        }
        
        if(val_37 == 0)
        {
                val_38 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_48 = 专丒丌丆下丐丞丟丞[0];
        if(val_38 <= 1)
        {
                val_38 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_49 = 专丒丌丆下丐丞丟丞[1];
        if(val_38 <= 2)
        {
                val_38 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_31 = 专丒丌丆下丐丞丟丞[2];
        object val_50 = 专丒丌丆下丐丞丟丞[3];
        if(val_48 == null)
        {
            goto label_89;
        }
        
        val_39 = val_48;
        if(val_39 != null)
        {
            goto label_90;
        }
        
        label_89:
        val_39 = 0;
        label_90:
        if(val_49 == null)
        {
            goto label_91;
        }
        
        val_40 = val_49;
        if(val_40 != null)
        {
            goto label_92;
        }
        
        label_91:
        val_40 = 0;
        label_92:
        if(val_31 == null)
        {
            goto label_93;
        }
        
        val_41 = val_31;
        if(val_41 != null)
        {
            goto label_94;
        }
        
        label_93:
        val_41 = 0;
        label_94:
        if(val_50 == null)
        {
            goto label_95;
        }
        
        val_31 = null;
        val_42 = val_50;
        if(val_42 != null)
        {
            goto label_96;
        }
        
        label_95:
        val_42 = 0;
        label_96:
        this.丒丑丘上业丒丏丑专(丕七七丄万丄丘丂丑:  val_39, 丏世丅丘专丕丛世上:  val_40, 丁万世世丒丈世丙丛:  val_41, 下丄丙丄一丒一业世:  val_42, 专丞丁世丈下且丁丑:  val_27);
        goto label_97;
        label_77:
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  val_46, 丟三丟三丅专丂丄丂:  0, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
        label_97:
        val_28 = 1;
        return (bool)val_28;
    }
    internal System.Collections.IEnumerator 且不且不丆与丄不丅()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SkinName.丁丌丒丕且丛丗丙一(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丗丟丗丗丅丑七丗丝()
    {
        this.firstPersonControl.enabled = false;
    }
    private void 万丈一一下七且丕丗()
    {
        float val_4;
        string val_5;
        string val_12;
        float val_13;
        string val_29;
        float val_30;
        var val_32;
        this.丏丒丛业下业七且丅.Clear();
        this.playerMoveC.不丌丁丁与上丘丌丈().业业丏丂丄丄丞万东();
        List.Enumerator<T> val_3 = 丅丄丕不丏丛三丑一.丏专丄专丙丑丈丗丕().GetEnumerator();
        val_32 = 1152921519126359200;
        label_15:
        if((855858016 & 1) == 0)
        {
            goto label_7;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if((System.String.IsNullOrEmpty(value:  val_6)) == true)
        {
            goto label_15;
        }
        
        PlayerEffectConfig val_8 = PlayerEffectConfig.Instance;
        if((val_8.dictionaryPlayerEffects.ContainsKey(key:  val_6)) == false)
        {
            goto label_15;
        }
        
        PlayerEffectConfig val_10 = PlayerEffectConfig.Instance;
        PlayerEffectSettings val_11 = val_10.dictionaryPlayerEffects.Item[val_6];
        this.丏丒丛业下业七且丅.Add(item:  new PlayerEffectSettings() {idEffect = val_12, playerEffects = val_12, factor = val_13, additionalFactor = val_13, arrayId = val_13});
        goto label_15;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_14 = 丆丟七丌丞东丆丕丌.丄丁丁丌丞丘且丝三(丁丂专业丁丅丅丈丙:  7);
        if((System.String.op_Inequality(a:  val_14, b:  与丂丏丛丞丞丒丟丄.丏丆七丒且丏丆丒丙())) == false)
        {
            goto label_56;
        }
        
        List.Enumerator<T> val_20 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.且万丅丙丛丌丞与丈>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_14).下丆丂丌上丑一三丆().GetEnumerator();
        val_32 = 1152921539822331248;
        label_44:
        if((855857984 & 1) == 0)
        {
            goto label_34;
        }
        
        string val_21 = val_5.丐丏七丌丕丗业且上();
        PlayerEffectConfig val_22 = PlayerEffectConfig.Instance;
        if(((val_22.dictionaryPlayerEffects.ContainsKey(key:  val_21.业上丙丞丐丄丆丅七())) == false) || (不世丌丒丑东丝一丝.丑丘不丑不丝丞世丝() == true))
        {
            goto label_44;
        }
        
        PlayerEffectConfig val_26 = PlayerEffectConfig.Instance;
        PlayerEffectSettings val_28 = val_26.dictionaryPlayerEffects.Item[val_21.业上丙丞丐丄丆丅七()];
        val_5 = val_29;
        val_4 = val_30;
        this.丏丒丛业下业七且丅.Add(item:  new PlayerEffectSettings() {idEffect = val_5, playerEffects = val_5, factor = val_4, additionalFactor = val_4, arrayId = val_4});
        goto label_44;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_56:
        this.playerMoveC.不丌丁丁与上丘丌丈().万不下丒丛一丒万丘(丒下丅下丁丕丝且丆:  this.丏丒丛业下业七且丅);
        this.playerMoveC.丈万三丈丄下上上丅();
    }
    internal void 世丒丁世丑七丕万七()
    {
        var val_71;
        var val_72;
        bool val_73;
        var val_74;
        var val_75;
        bool val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        var val_82;
        bool val_83;
        var val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        var val_90;
        bool val_91;
        var val_92;
        var val_93;
        val_71 = null;
        val_71 = null;
        if(PlayerEffectContainer.丗上与丈丕丁且七世 != false)
        {
                this.万丈一一下七且丕丗();
            return;
        }
        
        bool val_65 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "cyber_santa_set");
        var val_2 = (val_65 != true) ? 8 : 0;
        bool val_3 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "syber_set");
        this.丈东不三一丅丑丏丘 = val_3;
        val_72 = null;
        var val_5 = val_2 | 512;
        val_2 = (val_3 != true) ? (val_5) : (val_2);
        val_72 = null;
        this.丒丙丒丟丈丅丛一三 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丐丒丐专丑丙丏业丆);
        this.丌丞丐丕丁且丁丐丅 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丂丕世一丞东且丙七);
        this.三丙丌丏下丝上丟丙 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.专上丛一且不丌丈与);
        this.业丘丏丐丐丅丕一丟 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丄世丁丑与不东业丆);
        this.万丆丏与丕东下丈丐 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丌业不不丞丛且丐业);
        if((((val_65 != true) && (this.丈东不三一丅丑丏丘 != true)) && (this.丒丙丒丟丈丅丛一三 != true)) && (this.丌丞丐丕丁且丁丐丅 != true))
        {
                if(this.三丙丌丏下丝上丟丙 == false)
        {
            goto label_93;
        }
        
        }
        
        label_93:
        if(1 != this.丏上东丁丛七丑丛丌)
        {
                this.丏上东丁丛七丑丛丌 = (1 != 0) ? 1 : 0;
            this.丅丁丈丐丝万与东丌(专丞上七七且丝七丗:  0);
        }
        
        bool val_17 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "exoskeletons");
        var val_18 = val_2 | 16;
        val_65 = (val_17 != true) ? (val_18) : (val_2);
        var val_19 = (this.三不丂七世丄业丐丗 == true) ? 1 : 0;
        val_19 = val_17 ^ val_19;
        if(val_19 != false)
        {
                this.三不丂七世丄业丐丗 = val_17;
        }
        
        bool val_21 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "exoskeletons_set2");
        val_18 = val_65 | 64;
        val_65 = (val_21 != true) ? (val_18) : (val_65);
        var val_22 = (this.东丌下一一丅与丌丟 == true) ? 1 : 0;
        val_22 = val_21 ^ val_22;
        if(val_22 != false)
        {
                this.东丌下一一丅与丌丟 = val_21;
        }
        
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "sniper_set")) != false)
        {
                val_73 = 1;
        }
        else
        {
                val_74 = null;
            val_74 = null;
            val_73 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.专不世丆不丟且丘丛);
        }
        
        val_5 = val_65 | 128;
        val_65 = (val_73 == true) ? (val_5) : (val_65);
        if(val_73 != this.三上丒三专丆丌与下)
        {
                this.三上丒三专丆丌与下 = val_73;
            this.丅丁丈丐丝万与东丌(专丞上七七且丝七丗:  0);
        }
        
        bool val_26 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "HALLOWEEN_2018_SET");
        val_65 = (val_26 != true) ? (val_65 | 32) : (val_65);
        var val_28 = (this.一不丅丑与丑丘世七 == true) ? 1 : 0;
        val_28 = val_26 ^ val_28;
        if(val_28 != false)
        {
                this.一不丅丑与丑丘世七 = val_26;
        }
        
        bool val_30 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "time_traveler_set");
        this.丑三丈丈不丏丙且且 = val_30;
        val_5 = val_65 | 256;
        val_65 = (val_30 != true) ? (val_5) : (val_65);
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "BTroulette")) == true)
        {
            goto label_36;
        }
        
        val_75 = null;
        val_75 = null;
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丙丟丗丕丌丏丌东东)) == false)
        {
            goto label_39;
        }
        
        label_36:
        val_76 = 1;
        goto label_40;
        label_39:
        val_77 = null;
        val_77 = null;
        val_76 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丐丏东丂丞丝丂丐丂);
        label_40:
        this.专世下丟丟与丅万上 = val_76;
        val_5 = val_65 | 1024;
        val_65 = (val_76 == true) ? (val_5) : (val_65);
        val_65 = val_65 | (丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "pilgrim_set"));
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "blogger_set")) == true)
        {
            goto label_47;
        }
        
        val_78 = null;
        val_78 = null;
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丘丗丑专丕丑万丌三)) == false)
        {
            goto label_50;
        }
        
        label_47:
        val_79 = 1;
        goto label_51;
        label_50:
        val_80 = null;
        val_80 = null;
        val_79 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.专不世丆不丟且丘丛);
        label_51:
        val_5 = val_65 | 2;
        val_65 = (val_79 == false) ? (val_65) : (val_5);
        val_5 = val_65 | 4;
        val_65 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "western_set")) != true) ? (val_5) : (val_65);
        val_5 = val_65 | 2048;
        val_65 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "alien_santa_set")) != true) ? (val_5) : (val_65);
        val_5 = val_65 | 4096;
        val_65 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "Super_Soldier_Set")) != true) ? (val_5) : (val_65);
        val_5 = val_65 | 8192;
        val_65 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "OrientalSet")) != true) ? (val_5) : (val_65);
        bool val_44 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "big_b_set");
        this.世丐七东上万丌丌丛 = val_44;
        val_5 = val_65;
        val_65 = (val_44 != true) ? (val_5) : (val_65);
        bool val_46 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  "portallium_set");
        this.三丒丘丏七七丙业丌 = val_46;
        val_81 = null;
        val_5 = val_65;
        val_65 = (val_46 != true) ? (val_5) : (val_65);
        val_81 = null;
        bool val_48 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丕丌丏丕丝且丂东丙);
        this.丛丒丟丝万与下丈世 = val_48;
        val_82 = null;
        val_5 = val_65;
        val_65 = (val_48 != true) ? (val_5) : (val_65);
        val_82 = null;
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丒丆丒上世与业丈与)) != false)
        {
                val_83 = 1;
        }
        else
        {
                val_84 = null;
            val_84 = null;
            val_83 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丄丏下丘丕一万丐丆);
        }
        
        this.丅丛东丂丄东专丄丟 = val_83;
        val_85 = null;
        val_5 = val_65;
        val_65 = (val_83 == true) ? (val_5) : (val_65);
        val_85 = null;
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丆上丗丂丟丕丑丈丐)) != false)
        {
                val_86 = val_65;
        }
        else
        {
                val_87 = null;
            val_87 = null;
            val_65 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丏丕七下丈丗不万丈)) != true) ? (val_65) : (val_65);
        }
        
        val_88 = null;
        val_88 = null;
        val_89 = null;
        val_5 = val_65;
        val_65 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丂东丈丗丟且一丛丌)) != true) ? (val_5) : (val_65);
        val_89 = null;
        丙七丄东丙专丒七不 val_58 = ((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丌丘丒丞丝三丙丐丙)) != true) ? (val_65) : (val_65);
        if(val_58 != this.丛七业丝丈三丁丝丐)
        {
                this.丛七业丝丈三丁丝丐 = val_58;
            this.丘不东丙丘一丈丑业(专丞上七七且丝七丗:  0);
        }
        
        val_90 = null;
        val_90 = null;
        if((丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.与下丄一丌丏一丘与)) != false)
        {
                val_91 = 1;
        }
        else
        {
                val_92 = null;
            val_92 = null;
            val_91 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丌业不不丞丛且丐业);
        }
        
        this.丛不世丑不丅与丁丒 = val_91;
        val_93 = null;
        val_93 = null;
        this.且丌丄丒一丑丌丐一 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.不丑丈丅丑专丞丑丞);
        this.丙丛丌三七丌丛丌丙 = 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丄丘东丝丘丅丛丈丏);
    }
    internal UnityEngine.Coroutine 万丙不东一世丁丏东(float 丂三丟丂丈丐丆丗丟)
    {
        if(this.playerMoveC == 0)
        {
                return 0;
        }
        
        return this.StartCoroutine(routine:  this.playerMoveC.万丙不东一世丁丏东(丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟));
    }
    internal void 丌专丏丂丝丕世丅丟()
    {
        if(this.firstPersonControl.丂丕丁且世丗丕丛专() == true)
        {
                return;
        }
        
        if(this.jumpDustPoint == 0)
        {
                return;
        }
        
        if(this.firstPersonControl.丅丁丝丞丄丏三丌三 == true)
        {
                return;
        }
        
        HitParticle val_3 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        float val_11 = 15f;
        val_11 = this.firstPersonControl.丈丝丟丌丈丄一上丆 / val_11;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  UnityEngine.Mathf.Clamp(value:  val_11, min:  0.5f, max:  1f));
        val_3.myParticleSystem.transform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Vector3 val_9 = this.jumpDustPoint.position;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        val_3.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, 丁丈丄不且专丘与世:  false);
    }
    internal bool 丟丘丞业丝且丙丏丗(int 丁丛东丛丆专业丏不)
    {
        if(丁丛东丛丆专业丏不 > 13)
        {
                return (bool)((丁丛东丛丆专业丏不 | 1) == 15) ? 1 : 0;
        }
        
        var val_3 = 1;
        val_3 = val_3 << 丁丛东丛丆专业丏不;
        val_3 = val_3 & 12402;
        if(val_3 == 0)
        {
                return (bool)((丁丛东丛丆专业丏不 | 1) == 15) ? 1 : 0;
        }
        
        return true;
    }
    private void OnEnable()
    {
        PGCompany.GamepadCoreController.add_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void SkinName::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    private void OnDisable()
    {
        PGCompany.GamepadCoreController.remove_OnInput(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丆七丗丂世丞丗丙三, System.Object>(object:  this, method:  public System.Void SkinName::InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)));
    }
    public void InvokeGamepadAction(PGCompany.丆七丗丂世丞丗丙三 七丐丅专且专七三丆, object 丙业与丙丗丝不丈东)
    {
        var val_2;
        if(丙业与丙丗丝不丈东 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        if(七丐丅专且专七三丆 != 3)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 3.782474E-38f, y = V8.16B}, d:  PGCompany.GamepadCoreController.专丛丈上丛且丟丌丞);
        this.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, 万业丒丞丅一丂丈业:  true);
    }
    internal void 丗丂东丌丙一丕业丙(UnityEngine.Vector2 丞且丅三三东不丄且, bool 万业丒丞丅一丂丈业 = False)
    {
        if(this.firstPersonControl == 0)
        {
                return;
        }
        
        this.firstPersonControl.丗丂东丌丙一丕业丙(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y}, 万业丒丞丅一丂丈业:  万业丒丞丅一丂丈业);
    }
    internal void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丄丈丑丐丆丞丘与丗)) == false)
        {
                return;
        }
        
        if(this.isMine == false)
        {
                return;
        }
        
        this.专丁丗下业丏且丟世(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.丘丄丏世丒上东丘丒(专丞上七七且丝七丗:  专丞上七七且丝七丗, 丙一丙丙丑丕丘万专:  "");
        this.丑丞丟丁东丂三与丁(专丞上七七且丝七丗:  专丞上七七且丝七丗, 万下上丏丙丈丄业丆:  "");
        this.上丒丈世丗丆丗丛下(专丞上七七且丝七丗:  专丞上七七且丝七丗, 业万丙丟丁丁下丌丅:  "");
        this.上丛与丅丏丌上丁丞(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.不一丙东七下不丕丑(专丞上七七且丝七丗:  专丞上七七且丝七丗, 万丑丗七丁丂丗世专:  "");
        this.丌下丅七丅丟丏且丄(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.丄丏万世丑三丌丅专(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.丅丁丈丐丝万与东丌(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.playerMoveC.不丌丁丁与上丘丌丈().下丈丛与上业丙下丒(专丞上七七且丝七丗:  专丞上七七且丝七丗);
        this.丘不东丙丘一丈丑业(专丞上七七且丝七丗:  专丞上七七且丝七丗);
    }
    internal void 上丛与丅丏丌上丁丞(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        string val_18;
        与丅丕丈丘东丝世丟 val_19;
        string val_20;
        System.Object[] val_21;
        var val_22;
        var val_23;
        var val_24;
        int val_25;
        val_19 = 专丞上七七且丝七丗;
        if(this.下丌丑业丕丕丘丆七 == true)
        {
                return;
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == true)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == true)
        {
                return;
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
                return;
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
                return;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == true)
        {
                return;
        }
        
        val_18 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
        PGCompany.丙丕丑丑丆丂丗丗丟 val_7 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_18);
        val_20 = val_18;
        if(val_7 != null)
        {
                val_20 = val_7.业上丙丞丐丄丆丅七();
        }
        
        this.丟东丞丂丗丘七丗丛 = val_20;
        this.丁万业丒丝丗丂专且 = val_18;
        val_21 = 1152921505171275776;
        val_22 = null;
        val_22 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 != 0)
        {
                if(null != 0)
        {
            goto label_32;
        }
        
        }
        else
        {
                val_21 = 0;
        }
        
        label_32:
        if(三丐下丁丒丆丘下丄.丟不丞丒丘丁丁丙丁() == false)
        {
            goto label_36;
        }
        
        val_24 = null;
        val_24 = null;
        val_25 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_25 == 0)
        {
            goto label_36;
        }
        
        val_25 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_25 != 1)
        {
            goto label_66;
        }
        
        if((丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0)) == false)
        {
            goto label_43;
        }
        
        label_36:
        label_66:
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        object[] val_14 = new object[3];
        val_21 = val_14;
        val_21[0] = val_20;
        val_21[1] = val_18;
        if(val_19 != null)
        {
                val_18 = true;
            val_21[2] = val_18;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  59, 万丌万丅专丞业丈万:  val_19, 丗丟上上丒丐丗丞丙:  val_14);
            return;
        }
        
        val_19 = true;
        val_21[2] = val_19;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  59, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_14);
        return;
        label_43:
        Rilisoft.七丕丟丏三丈一丄世 val_18 = GameConnect.丑丌丛丈丅丅与不业();
        val_18 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  val_18);
        goto label_66;
    }
    internal void 上丒丈世丗丆丗丛下(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, string 业万丙丟丁丁下丌丅 = "")
    {
        string val_6;
        与丅丕丈丘东丝世丟 val_7;
        val_6 = 业万丙丟丁丁下丌丅;
        val_7 = 专丞上七七且丝七丗;
        if(this.下丌丑业丕丕丘丆七 != false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
        {
                val_6 = 七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐();
        }
        
        if(val_7 != null)
        {
                object[] val_3 = new object[1];
            val_3[0] = val_6;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  60, 万丌万丅专丞业丈万:  val_7, 丗丟上上丒丐丗丞丙:  val_3);
            return;
        }
        
        if(this.isMine != false)
        {
                val_7 = this.丄丈丑丐丆丞丘与丗;
            object[] val_4 = new object[1];
            val_4[0] = val_6;
            val_7.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  60, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
        }
        
        this.上丒丈世丗丆丗丛下(丞一丁业丄一一业且:  val_6, 七丅丅世丆丆丗丟丐:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
    }
    internal void 丑丞丟丁东丂三与丁(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, string 万下上丏丙丈丄业丆 = "")
    {
        string val_13;
        var val_14;
        val_13 = 万下上丏丙丈丄业丆;
        if(this.下丌丑业丕丕丘丆七 == true)
        {
                return;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_13)) != false)
        {
                val_13 = 七丌丞万七万丁丐丙.一万丌东丄世上丕丟();
        }
        
        if((val_13.Equals(value:  "cape_Custom")) == false)
        {
            goto label_11;
        }
        
        if((val_13.Equals(value:  "cape_Custom")) == false)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = UnityEngine.ImageConversion.EncodeToPNG(tex:  SkinsController.丌七丞东丟丌世且不);
        if(SkinsController.丌七丞东丟丌世且不.width != 12)
        {
                return;
        }
        
        if(SkinsController.丌七丞东丟丌世且不.height != 16)
        {
                return;
        }
        
        if(专丞上七七且丝七丗 != null)
        {
            goto label_19;
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                object[] val_9 = new object[1];
            val_9[0] = val_13;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  62, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_9);
        }
        
        this.丞丙丞专丐一三丁一(丒丏丁丛业丞世丅业:  val_13);
        return;
        label_11:
        if(专丞上七七且丝七丗 == null)
        {
            goto label_26;
        }
        
        label_19:
        object[] val_10 = new object[1];
        val_10[0] = val_13;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  62, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_10);
        return;
        label_26:
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                object[] val_11 = new object[1];
            val_11[0] = val_13;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  62, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_11);
        }
        
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  val_13, 丟三丟三丅专丂丄丂:  0, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    internal bool 丅丌丑丈丁丟一丗丑()
    {
        null = null;
        return 丙丞丟丑丗丅专丈一.丗丛一丒专一万丂一(丐世下不一丁丟丅专:  丙丞丟丑丗丅专丈一.丏丗且丘三七上东丂);
    }
    internal void 丈丅丛丄丟丙丈丅东(bool 丂万一丒丏丕丕世丑)
    {
        this.一丈不丟丑万丅丈丑 = 丂万一丒丏丕丕世丑;
        this.丕丘七丂丒丁东一与();
    }
    internal void 业丕丐丆万丞上丁与(bool 丛东丄世专丕丏东一)
    {
        this.业丘丐丅业七业丆且 = 丛东丄世专丕丏东一;
        this.丕丘七丂丒丁东一与();
    }
    internal void 丄丏万世丑三丌丅专(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        string val_10;
        int val_11;
        string val_12;
        PhotonView val_13;
        var val_14;
        val_10 = System.String.alignConst;
        if((东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  212, value: out  0)) != false)
        {
                val_10 = val_2.业上丙丞丐丄丆丅七();
        }
        
        val_11 = System.String.alignConst;
        val_12 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅();
        if((val_12.TryGetValue(key:  200, value: out  0)) != false)
        {
                val_11 = val_6.业上丙丞丐丄丆丅七();
        }
        
        this.丟丕业丒丝专丁丗丗 = System.String.alignConst;
        this.丑三东下丁七业丕丝 = val_10;
        this.丄丏丒丁丈丂七丅丑 = val_11;
        val_13 = 1152921505171275776;
        val_14 = null;
        val_14 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_13 = this.丄丈丑丐丆丞丘与丗;
        object[] val_9 = new object[3];
        val_9[0] = this.丟丕业丒丝专丁丗丗;
        val_12 = this.丑三东下丁七业丕丝;
        val_9[1] = val_12;
        val_9[2] = this.丄丏丒丁丈丂七丅丑;
        if(val_13 == null)
        {
            goto label_27;
        }
        
        if(专丞上七七且丝七丗 == null)
        {
            goto label_28;
        }
        
        label_30:
        val_13.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  73, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_9);
        return;
        label_27:
        if(专丞上七七且丝七丗 != null)
        {
            goto label_30;
        }
        
        label_28:
        val_13.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  73, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_9);
    }
    internal void 丘丄丏世丒上东丘丒(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, string 丙一丙丙丑丕丘万专 = "")
    {
        string val_10;
        var val_11;
        val_10 = 丙一丙丙丑丕丘万专;
        if(this.下丌丑业丕丕丘丆七 != false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_10)) != false)
        {
                val_10 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
        }
        
        if(val_10 != null)
        {
                if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_14;
        }
        
        }
        
            if((七丌丞万七万丁丐丙.业丆且专世丐万丈丝(丄丒下万丁丗丁丝与:  val_10)) != true)
        {
                val_10 = 与丂丏丛丞丞丒丟丄.丄丄丏丛且丛丙且丑();
        }
        
        }
        
        label_14:
        val_11 = null;
        val_11 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(专丞上七七且丝七丗 != null)
        {
                object[] val_7 = new object[2];
            val_7[0] = val_10;
            val_7[1] = null;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  74, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_7);
            return;
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                object[] val_8 = new object[2];
            val_8[0] = val_10;
            val_8[1] = null;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  74, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_8);
        }
        
        this.丘丄丏世丒上东丘丒(丞一丁业丄一一业且:  val_10, 七丅丅世丆丆丗丟丐:  (this.世丟丘丞丌丁丙丕丕 == false) ? 1 : 0);
    }
    internal void 不一丙东七下不丕丑(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, string 万丑丗七丁丂丗世专 = "")
    {
        string val_6;
        与丅丕丈丘东丝世丟 val_7;
        var val_8;
        val_6 = 万丑丗七丁丂丗世专;
        val_7 = 专丞上七七且丝七丗;
        if(this.下丌丑业丕丕丘丆七 != false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
        {
                val_6 = 七丌丞万七万丁丐丙.上三丐丛东丐丏丗丝();
        }
        
        val_8 = null;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(val_7 != null)
        {
                object[] val_3 = new object[1];
            val_3[0] = val_6;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  78, 万丌万丅专丞业丈万:  val_7, 丗丟上上丒丐丗丞丙:  val_3);
            return;
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                val_7 = this.丄丈丑丐丆丞丘与丗;
            object[] val_4 = new object[1];
            val_4[0] = val_6;
            val_7.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  78, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_4);
        }
        
        this.不一丙东七下不丕丑(丞一丁业丄一一业且:  val_6, 七丅丅世丆丆丗丟丐:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
    }
    internal void 丌下丅七丅丟丏且丄(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_10;
        string val_11;
        if(this.playerMoveC.丅下万丏丘东丄丌万 != false)
        {
                string val_1 = this.playerMoveC.且三丄上丗丅丗丈一.丁丑丗丁丞且业丌丑();
        }
        else
        {
                string val_3 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.东丏丌丕丑丝下丙丏();
        }
        
        this.丈丐专业不丆丕丙一 = val_3;
        if((System.String.IsNullOrEmpty(value:  val_3)) != false)
        {
            
        }
        else
        {
                PetInfo val_6 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.丈丐专业不丆丕丙一);
            val_11 = val_6.AlternativeId;
        }
        
        if(((W9 & 2) != 0) && (val_6.Rarity == 0))
        {
                val_10 = null;
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        object[] val_7 = new object[2];
        val_7[0] = this.丈丐专业不丆丕丙一 + "_up0";
        val_7[1] = mem[val_6.AlternativeId] + "_up0";
        if(this.丄丈丑丐丆丞丘与丗 == null)
        {
            goto label_24;
        }
        
        if(专丞上七七且丝七丗 == null)
        {
            goto label_25;
        }
        
        label_26:
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  167, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_7);
        return;
        label_24:
        if(专丞上七七且丝七丗 != null)
        {
            goto label_26;
        }
        
        label_25:
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  167, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_7);
    }
    internal void 专丁丗下业丏且丟世(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        bool val_15;
        PhotonView val_16;
        bool val_17;
        bool val_18;
        bool val_19;
        System.Object[] val_20;
        val_16 = this;
        if(this.下丌丑业丕丕丘丆七 == true)
        {
                return;
        }
        
        if(三丐下丁丒丆丘下丄.丟万三丁丙丅东三三() == false)
        {
            goto label_2;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_5;
        }
        
        val_15 = (~this.playerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万()) & 1;
        goto label_9;
        label_2:
        val_15 = 0;
        goto label_9;
        label_5:
        val_15 = true;
        label_9:
        if(三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅() == false)
        {
            goto label_10;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_13;
        }
        
        val_17 = (~this.playerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万()) & 1;
        goto label_17;
        label_10:
        val_17 = 0;
        goto label_17;
        label_13:
        val_17 = true;
        label_17:
        if(三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏() == false)
        {
            goto label_18;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_21;
        }
        
        val_18 = (~this.playerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万()) & 1;
        goto label_25;
        label_18:
        val_18 = 0;
        goto label_25;
        label_21:
        val_18 = true;
        label_25:
        if(三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七() == false)
        {
            goto label_26;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_29;
        }
        
        val_19 = (~this.playerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万()) & 1;
        if(专丞上七七且丝七丗 != null)
        {
            goto label_50;
        }
        
        goto label_34;
        label_26:
        val_19 = false;
        if(专丞上七七且丝七丗 == null)
        {
            goto label_34;
        }
        
        label_50:
        val_16 = this.丄丈丑丐丆丞丘与丗;
        object[] val_13 = new object[4];
        val_20 = val_13;
        val_20[0] = val_15;
        val_20[1] = val_17;
        val_20[2] = val_18;
        val_15 = val_19;
        val_20[3] = val_15;
        val_16.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  91, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_13);
        return;
        label_29:
        val_19 = true;
        if(专丞上七七且丝七丗 != null)
        {
            goto label_50;
        }
        
        label_34:
        if(((val_15 == this.世丟丘丞丌丁丙丕丕) && (val_17 == this.丕七丟三丗三丐业丁)) && (val_18 == this.丛丑上一丗丒丘丗丈))
        {
                if(val_19 == this.丒丕丄丆专丂丛丙万)
        {
                return;
        }
        
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                object[] val_14 = new object[4];
            val_20 = val_14;
            val_20[0] = val_15;
            val_20[1] = val_17;
            val_20[2] = val_18;
            val_20[3] = val_19;
            this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  91, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_14);
        }
        
        this.丆丙上世丟丐与三丑(丑下万丂丞不七丄三:  true, 丅丒丆三丌七丟七与:  true, 丂丈业东丛且丈一下:  true, 丒丒丏业专丌丑丟丆:  true);
    }
    private void Awake()
    {
        var val_16;
        PhotonView val_1 = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        this.丄丈丑丐丆丞丘与丗 = val_1;
        PlayerBotController val_2 = PlayerBotController.不世丂丏丒万世东丂(丁世丛业丟下丕三丟:  val_1);
        this.业丌东七七丒世丞万 = val_2;
        this.一七不三丌专三丆一 = UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
        this.不丙丏三丟丛丒与丅 = this.FPSplayerObject.GetComponent<UnityEngine.Animation>();
        val_16 = null;
        val_16 = null;
        bool val_16 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        val_16 = val_16 ^ 1;
        this.丒丘三丁丄丘丅丂三 = val_16;
        this.firstPersonControl = this.GetComponent<FirstPersonControlSharp>();
        this.东且下上丒上七东丞 = this.GetComponent<UnityEngine.AudioSource>();
        if((GameConnect.世丐丄三三上丅七三() != true) && (GameConnect.与丈丘丈上丌丝丝丛() != true))
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_17;
        }
        
        }
        
        }
        
        label_28:
        this.下丌丑业丕丕丘丆七 = true;
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() == false)
        {
                return;
        }
        
        }
        
        this.丒丅东七专丌丂丛丒();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.FPSplayerObject, 丏业丟一东丂东丘丛:  false);
        return;
        label_17:
        bool val_15 = GameConnect.一业上七丟业且业丙();
        goto label_28;
    }
    private void 丒丅东七专丌丂丛丒()
    {
        UnityEngine.GameObject val_11;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Player/FPS_Player_runner");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_11 = 0;
        }
        
        ThirdPersonAnimationWrapper val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_11, parent:  this.transform).GetComponent<ThirdPersonAnimationWrapper>();
        this.丛丞七丏丑业丂丕丟 = val_5;
        UnityEngine.Vector3 val_8 = this.playerMoveC.fpsPlayerBody.transform.localPosition;
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        this.丛丞七丏丑业丂丕丟.transform.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        this.丛丞七丏丑业丂丕丟.visObj.lerpScript = this.interpolateScript;
    }
    private bool 丅丟万专丂丏丒上丏(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.GameObject val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = 丝三丁东丈丒世丅业;
        val_4 = null;
        val_4 = null;
        if((丘丛丞且一丅丁丏丐.丗世丗丌丁丕东七丂.ContainsKey(key:  val_3)) != false)
        {
                val_5 = null;
            val_5 = null;
            DeadCollider val_2 = 丞东丑专丛丆丄丝世.丂丏丞丘丗丒丕且丐<UnityEngine.GameObject, DeadCollider>(丏丂万业丙专丏丒丒:  丘丛丞且一丅丁丏丐.丗世丗丌丁丕东七丂, 下上丐丆丝丟丝丒不:  val_3);
            if(val_2 != null)
        {
                val_3 = (((DeadCollider.__il2cppRuntimeField_typeHierarchy + (HelicopterRotorDeadCollider.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
        }
        
            val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private void OnControllerColliderHit(UnityEngine.ControllerColliderHit 丆丛丂丝丄世且丛丕)
    {
        var val_56;
        UnityEngine.Vector3 val_57;
        float val_58;
        float val_59;
        float val_60;
        float val_61;
        Player_move_c val_62;
        int val_63;
        丏专丐且丘丌丛不丁 val_64;
        float val_65;
        float val_66;
        float val_67;
        float val_68;
        float val_69;
        float val_70;
        FirstPersonControlSharp val_71;
        this.丐世丑丘丞下丏丑丘 = false;
        if((丆丛丂丝丄世且丛丕.gameObject.CompareTag(tag:  "Conveyor")) == false)
        {
            goto label_5;
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
            goto label_5;
        }
        
        }
        
        if(this.且丟三丘丒丈丝丆丝 != true)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.丅丁丏丅丄丌专丟丕 = val_3;
            mem[1152921539826701652] = val_3.y;
            mem[1152921539826701656] = val_3.z;
        }
        
        this.且丟三丘丒丈丝丆丝 = true;
        val_56 = 丆丛丂丝丄世且丛丕.transform.GetComponent<Conveyor>();
        if(val_5.accelerateSpeed == false)
        {
            goto label_12;
        }
        
        val_57 = this.丅丁丏丅丄丌专丟丕;
        UnityEngine.Vector3 val_7 = 丆丛丂丝丄世且丛丕.transform.forward;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_5.maxspeed);
        val_59 = val_57;
        val_60 = V9.16B;
        val_61 = V10.16B;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_59, y = val_60, z = val_61}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, t:  val_5.acceleration);
        goto label_17;
        label_5:
        this.且丟三丘丒丈丝丆丝 = false;
        val_56 = 丆丛丂丝丄世且丛丕.gameObject;
        if((val_56.CompareTag(tag:  "Rink")) != false)
        {
                if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
            goto label_22;
        }
        
        }
        
            this.丐世丑丘丞下丏丑丘 = true;
            return;
        }
        
        label_22:
        if(this.与丌丝丄丑丄下业丁 == false)
        {
            goto label_24;
        }
        
        label_64:
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_12 = 丆丛丂丝丄世且丛丕.gameObject;
        if((val_12.丅丟万专丂丏丒上丏(丝三丁东丈丒世丅业:  val_12)) == false)
        {
                return;
        }
        
        val_62 = this.playerMoveC;
        if(this.playerMoveC.万丝一万丐且丌业丛 == true)
        {
                return;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                val_63 = SpeedrunTrackController.丛专与丅下丌丆世丒;
            val_63.ApplyDeathColliderShield();
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                FirstPersonControlSharp.上三丈世丟业一丘丘(丐不丁专业丌七东丕:  0.5f, 丘丞丌丙上万丒上丁:  0.5f);
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                val_62 = this.playerMoveC;
            if(val_62.丏下丙丞丕丕丏丕丞() == true)
        {
                return;
        }
        
        }
        
        this.丗且丝世丕三业上丁 = false;
        if((丆丛丂丝丄世且丛丕.gameObject.GetComponent<DeadColliderParam>()) == 0)
        {
            goto label_49;
        }
        
        val_64 = val_19.typeDead;
        if(this.playerMoveC != null)
        {
            goto label_110;
        }
        
        goto label_52;
        label_12:
        UnityEngine.Vector3 val_22 = 丆丛丂丝丄世且丛丕.transform.forward;
        val_58 = val_5.maxspeed;
        val_57 = val_22.x;
        val_59 = val_57;
        val_60 = val_22.y;
        val_61 = val_22.z;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_59, y = val_60, z = val_61}, d:  val_58);
        label_17:
        this.丅丁丏丅丄丌专丟丕 = val_23;
        mem[1152921539826701652] = val_23.y;
        mem[1152921539826701656] = val_23.z;
        return;
        label_24:
        if((丆丛丂丝丄世且丛丕.gameObject.CompareTag(tag:  "Trampoline")) != true)
        {
                if((丆丛丂丝丄世且丛丕.gameObject.CompareTag(tag:  "ConveyorTrampoline")) == false)
        {
            goto label_64;
        }
        
        }
        
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
            goto label_64;
        }
        
        }
        
        bool val_28 = this.firstPersonControl.丈业丆丌万丛丌丌丄();
        val_65 = 45f;
        val_66 = 110f;
        val_67 = 1f;
        var val_29 = (val_28 != true) ? (val_66) : (val_65);
        float val_30 = (val_28 != true) ? 3f : (val_67);
        if((丆丛丂丝丄世且丛丕.gameObject.CompareTag(tag:  "Trampoline")) != false)
        {
                TrampolineParameters val_34 = 丆丛丂丝丄世且丛丕.gameObject.GetComponent<TrampolineParameters>();
            if(this.playerMoveC.东丑丌丄丝世丞丘三 != true)
        {
                if(val_34 != 0)
        {
                val_68 = val_34.force;
        }
        
            float val_56 = PlayerCoreSettingsStorager.dynamicSettings.丘丏丌丏三丕不丞三();
            val_69 = val_30;
            if(this.firstPersonControl.丈业丆丌万丛丌丌丄() != false)
        {
                val_69 = val_30;
            if(val_34 != 0)
        {
                val_69 = val_34.decaySpeed;
        }
        
        }
        
            val_56 = val_68 * val_56;
            UnityEngine.Vector3 val_42 = 丆丛丂丝丄世且丛丕.transform.up;
            val_70 = val_42.y;
            val_65 = val_42.x;
            val_66 = val_70;
            val_67 = val_42.z;
            this.playerMoveC.丙世丞丈丁丝丙丌丞().AddImpact(且丒丗万七丑丁丏丏:  6, 丅与丐与丝丆专一专:  new UnityEngine.Vector3() {x = val_65, y = val_66, z = val_67}, 七丆丟丗世丟且丒丆:  val_56, 专世万丙丐丐七丐丁:  val_69, 三丏下七丄东丆丂丗:  0.2f, 丌丝下丄业一丄不三:  0, 业七与丙丄丘与丒且:  0);
            this.firstPersonControl.七三丟七丑专下万丗(丝且与丘七丆专且丂:  false);
        }
        
        }
        
        val_71 = 丆丛丂丝丄世且丛丕.gameObject;
        if((val_71.CompareTag(tag:  "ConveyorTrampoline")) != false)
        {
                UnityEngine.Vector3 val_47 = 丆丛丂丝丄世且丛丕.transform.forward;
            val_69 = val_47.y;
            val_70 = val_47.x;
            this.playerMoveC.丙世丞丈丁丝丙丌丞().AddImpact(且丒丗万七丑丁丏丏:  6, 丅与丐与丝丆专一专:  new UnityEngine.Vector3() {x = val_47.x, y = val_69, z = val_47.z}, 七丆丟丗世丟且丒丆:  val_70 * 1.4f, 专世万丙丐丐七丐丁:  val_30, 三丏下七丄东丆丂丗:  0.2f, 丌丝下丄业一丄不三:  0, 业七与丙丄丘与丒且:  0);
            UnityEngine.Vector3 val_49 = UnityEngine.Vector3.zero;
            val_71 = this.firstPersonControl;
            this.丅丁丏丅丄丌专丟丕 = val_49;
            mem[1152921539826701652] = val_49.y;
            mem[1152921539826701656] = val_49.z;
            val_71.七三丟七丑专下万丗(丝且与丘七丆专且丂:  false);
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_52 = 丆丛丂丝丄世且丛丕.gameObject.GetComponent<UnityEngine.AudioSource>();
            if(val_52 != 0)
        {
                val_52.Play();
        }
        
        }
        
        UnityEngine.Coroutine val_55 = this.StartCoroutine(routine:  this.且不且不丆与丄不丅());
        return;
        label_49:
        val_64 = 0;
        if(this.playerMoveC != null)
        {
            goto label_110;
        }
        
        label_52:
        label_110:
        this.playerMoveC.丏丘丂丝丝丙丕丂不(东丏业丞丞业下丄世:  val_64);
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        string val_31;
        UnityEngine.GameObject val_32;
        var val_33;
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
                return;
        }
        
        }
        
        WeaponSounds val_1 = this.playerMoveC.丙不丅丕三丂业东丕();
        if(val_1.isDash != false)
        {
                val_31 = this.playerMoveC.丙世丞丈丁丝丙丌丞();
            if(val_31.世丘丝丕丌与丟丟业() == 3)
        {
                return;
        }
        
        }
        
        val_31 = 丆丛丂丝丄世且丛丕.gameObject.name;
        if((val_31.Equals(value:  "DamageCollider")) != false)
        {
                丆丛丂丝丄世且丛丕.gameObject.GetComponent<DamageCollider>().RegisterPlayer();
        }
        
        HealingCollider val_10 = 丆丛丂丝丄世且丛丕.gameObject.GetComponent<HealingCollider>();
        if(val_10 != 0)
        {
                val_10.RegisterPlayer();
        }
        
        if((val_31.Equals(value:  "FallCollider")) != false)
        {
                this.playerMoveC.不上丒万丙且与丆丗();
        }
        
        if(((丆丛丂丝丄世且丛丕.CompareTag(tag:  "Ladder")) != false) && (this.playerMoveC.东丑丌丄丝世丞丘三 != true))
        {
                val_32 = 丆丛丂丝丄世且丛丕.gameObject;
            this.playerMoveC.丕丛丗丝专下丑丐丘(丏丛丆丙专丘上丄东:  val_32);
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_52;
        }
        
        }
        
        }
        
        UnityEngine.GameObject val_18 = 丆丛丂丝丄世且丛丕.gameObject;
        if(((val_18.丅丟万专丂丏丒上丏(丝三丁东丈丒世丅业:  val_18)) == false) || (this.playerMoveC.万丝一万丐且丌业丛 == true))
        {
            goto label_52;
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                SpeedrunTrackController.丛专与丅下丌丆世丒.ApplyDeathColliderShield();
        }
        
        if(GameConnect.丛专丌且丕不专丈下() != false)
        {
                if(this.playerMoveC.丏下丙丞丕丕丏丕丞() == true)
        {
            goto label_52;
        }
        
        }
        
        this.丗且丝世丕三业上丁 = false;
        if((丆丛丂丝丄世且丛丕.gameObject.GetComponent<DeadColliderParam>()) == 0)
        {
            goto label_57;
        }
        
        val_32 = val_24.typeDead;
        if(this.playerMoveC != null)
        {
            goto label_61;
        }
        
        goto label_60;
        label_57:
        val_32 = 0;
        if(this.playerMoveC != null)
        {
            goto label_61;
        }
        
        label_60:
        label_61:
        this.playerMoveC.丏丘丂丝丝丙丕丂不(东丏业丞丞业下丄世:  val_32);
        label_52:
        if((GameConnect.丁丁丗丐东丄丞一丛() != false) && ((System.String.op_Equality(a:  val_31, b:  "PenaltyCollider")) != false))
        {
                val_31 = this.playerMoveC;
            if(this.playerMoveC.万丝一万丐且丌业丛 != true)
        {
                val_33 = null;
            val_33 = null;
            val_31 = GliderTrackController.丄丘七三上丕世丞业;
            val_31.OnPenaltyColliderHit();
        }
        
        }
        
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_29 = 丆丛丂丝丄世且丛丕.gameObject;
        if((val_29.丅丟万专丂丏丒上丏(丝三丁东丈丒世丅业:  val_29)) == false)
        {
                return;
        }
        
        this.playerMoveC.丏丘丂丝丝丙丕丂不(东丏业丞丞业下丄世:  0);
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        UnityEngine.Object val_13;
        if(this.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
                return;
        }
        
        }
        
        DamageCollider val_2 = 丆丛丂丝丄世且丛丕.gameObject.GetComponent<DamageCollider>();
        if(val_2 != 0)
        {
                val_2.UnregisterPlayer();
        }
        
        val_13 = 丆丛丂丝丄世且丛丕.gameObject.GetComponent<HealingCollider>();
        if(val_13 != 0)
        {
                val_13.UnregisterPlayer();
        }
        
        if((丆丛丂丝丄世且丛丕.CompareTag(tag:  "Ladder")) == false)
        {
                return;
        }
        
        val_13 = this.playerMoveC.东三上专丅东业丛丐();
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = this.playerMoveC.东三上专丅东业丛丐();
        if(val_13 != 丆丛丂丝丄世且丛丕.gameObject)
        {
                return;
        }
        
        this.playerMoveC.丕丛丗丝专下丑丐丘(丏丛丆丙专丘上丄东:  0);
    }
    private void 一丄七丝万与丆丞丒(string 丑专丂业丑不且丕丞, string 丕且与丅丕东七丂七)
    {
        string val_15;
        string val_16;
        var val_17;
        var val_18;
        val_15 = 丕且与丅丕东七丂七;
        val_16 = 丑专丂业丑不且丕丞;
        if((val_16.Contains(value:  "_up")) != false)
        {
                if(val_16 != null)
        {
                val_17 = val_16.Length;
        }
        else
        {
                val_17 = 0.Length;
        }
        
            val_16 = val_16.Substring(startIndex:  0, length:  val_17 - 4);
        }
        
        if((val_15.Contains(value:  "_up")) != false)
        {
                if(val_15 != null)
        {
                val_18 = val_15.Length;
        }
        else
        {
                val_18 = 0.Length;
        }
        
            val_15 = val_15.Substring(startIndex:  0, length:  val_18 - 4);
        }
        
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_16)) != null)
        {
            goto label_10;
        }
        
        val_16 = val_15;
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_15)) == null)
        {
            goto label_12;
        }
        
        label_10:
        if(this != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        this.丈丐专业不丆丕丙一 = val_16;
        return;
        label_12:
        if(this != null)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    private void 丅丁丈丐丝万与东丌(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        与丅丕丈丘东丝世丟 val_2;
        PhotonView val_3;
        var val_4;
        object val_5;
        val_2 = 专丞上七七且丝七丗;
        val_3 = 1152921505171275776;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_3 = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[2];
        if(val_2 != null)
        {
                val_5 = this.丏上东丁丛七丑丛丌;
            val_1[0] = val_5;
            val_1[1] = this.三上丒三专丆丌与下;
            val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  162, 万丌万丅专丞业丈万:  val_2, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        val_5 = 1152921504617656320;
        val_1[0] = this.丏上东丁丛七丑丛丌;
        val_2 = this.三上丒三专丆丌与下;
        val_1[1] = val_2;
        val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  162, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丕丌丏丞丐丕上丗丕(与丅丕丈丘东丝世丟 专丞上七七且丝七丗, string[] 丕七七丄万丄丘丂丑, int[] 丏世丅丘专丕丛世上, float[] 丁万世世丒丈世丙丛, float[] 下丄丙丄一丒一业世, int[][] 专丞丁世丈下且丁丑)
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        object[] val_1 = new object[5];
        val_1[0] = 丕七七丄万丄丘丂丑;
        val_1[1] = 丏世丅丘专丕丛世上;
        val_1[2] = 丁万世世丒丈世丙丛;
        val_1[3] = 下丄丙丄一丒一业世;
        val_1[4] = 专丞丁世丈下且丁丑;
        if(this.丄丈丑丐丆丞丘与丗 == null)
        {
            goto label_21;
        }
        
        if(专丞上七七且丝七丗 == null)
        {
            goto label_22;
        }
        
        label_23:
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  162, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
        return;
        label_21:
        if(专丞上七七且丝七丗 != null)
        {
            goto label_23;
        }
        
        label_22:
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  162, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丒丑丘上业丒丏丑专(string[] 丕七七丄万丄丘丂丑, int[] 丏世丅丘专丕丛世上, float[] 丁万世世丒丈世丙丛, float[] 下丄丙丄一丒一业世, int[][] 专丞丁世丈下且丁丑)
    {
        Player_move_c val_5 = this.playerMoveC;
        if(val_5 != 0)
        {
                val_5 = this.playerMoveC.不丌丁丁与上丘丌丈();
            if(val_5 != 0)
        {
                this.playerMoveC.不丌丁丁与上丘丌丈().丑万丕与丅丏丄万上(丕七七丄万丄丘丂丑:  丕七七丄万丄丘丂丑, 丏世丅丘专丕丛世上:  丏世丅丘专丕丛世上, 丁万世世丒丈世丙丛:  丁万世世丒丈世丙丛, 下丄丙丄一丒一业世:  下丄丙丄一丒一业世, 专丞丁世丈下且丁丑:  专丞丁世丈下且丁丑);
            return;
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  "Что то пошло не так, игрок или его контейнер эффектов не создался");
    }
    private void 丘不东丙丘一丈丑业(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        与丅丕丈丘东丝世丟 val_2;
        PhotonView val_3;
        var val_4;
        val_2 = 专丞上七七且丝七丗;
        val_3 = 1152921505171275776;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(this.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_3 = this.丄丈丑丐丆丞丘与丗;
        object[] val_1 = new object[1];
        if(val_2 != null)
        {
                val_1[0] = this.丛七业丝丈三丁丝丐;
            val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  189, 万丌万丅专丞业丈万:  val_2, 丗丟上上丒丐丗丞丙:  val_1);
            return;
        }
        
        val_2 = this.丛七业丝丈三丁丝丐;
        val_1[0] = val_2;
        val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  189, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private System.Collections.IEnumerator 专丂丙丗专丘丟丝丌(bool 且且与丛七丗上丛三)
    {
        SkinName.不丝丆万七丞丕业丏 val_1 = new SkinName.不丝丆万七丞丕业丏(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .且且与丛七丗上丛三 = 且且与丛七丗上丛三;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丒丒一上专丄不世丆(string 丆丛丙与下丟丕东上, string 上不专东上丐丁丁三, bool 丘一万丌丙丑丝丅丁)
    {
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        int val_35;
        var val_36;
        val_31 = 丘一万丌丙丑丝丅丁;
        val_32 = null;
        val_32 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.专七丗丅业丟丂七上 == 0)
        {
            goto label_6;
        }
        
        if(val_31 == false)
        {
            goto label_8;
        }
        
        goto label_52;
        label_6:
        val_33 = 0;
        if(val_31 == true)
        {
            goto label_52;
        }
        
        label_8:
        val_31 = 1152921505037303808;
        val_34 = null;
        val_34 = null;
        val_35 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_35 == 0)
        {
            goto label_52;
        }
        
        val_35 = BalanceController.丁丟丛丞专丈丆东万;
        if(val_35 != 1)
        {
            goto label_56;
        }
        
        val_31 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙();
        if((val_31.一专丁丁丁丁丗下丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0)) == false)
        {
            goto label_20;
        }
        
        label_52:
        label_56:
        if(this.丝丅丈丆东丞专丘三 != null)
        {
                this.StopCoroutine(routine:  this.丝丅丈丆东丞专丘三);
            this.丝丅丈丆东丞专丘三 = 0;
        }
        
        if(this.armorPoint.transform.childCount < 1)
        {
            goto label_24;
        }
        
        val_36 = 0;
        goto label_25;
        label_33:
        UnityEngine.Object.Destroy(obj:  this.armorPoint.transform.GetChild(index:  0).gameObject);
        val_36 = 1;
        label_25:
        val_31 = this.armorPoint.transform;
        if(val_36 < val_31.childCount)
        {
            goto label_33;
        }
        
        label_24:
        this.丟东丞丂丗丘七丗丛 = 丆丛丙与下丟丕东上;
        this.丁万业丒丝丗丂专且 = 上不专东上丐丁丁三;
        this.七丈丑丘丂七丘上万 = 1 ^ 1;
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.SetRoyaleAvatarToPlayerBody();
        }
        
        this.一丈不丟丑万丅丈丑 = System.String.op_Equality(a:  this.丟东丞丂丗丘七丗丛, b:  "exoskeleton_pilot_avatar_armor");
        this.丕丘七丂丒丁东一与();
        this.丙专丒丆丑七丞上且 = System.String.op_Equality(a:  this.丟东丞丂丗丘七丗丛, b:  "cyber_santa_armor");
        this.丝丟下丗业丞东丈下 = System.String.op_Equality(a:  this.丟东丞丂丗丘七丗丛, b:  "Armor_Halloween");
        this.丅丏不七上七万一专 = System.String.op_Equality(a:  this.丟东丞丂丗丘七丗丛, b:  "pilgrim_armor");
        if(1 != 0)
        {
                return;
        }
        
        this.丝丅丈丆东丞专丘三 = this.StartCoroutine(routine:  this.专丂丙丗专丘丟丝丌(且且与丛七丗上丛三:  false));
        return;
        label_20:
        if((GameConnect.丄丏丒丏上东业丒一() != false) && (this.playerMoveC != 0))
        {
                if(this.playerMoveC.丟三丏丅世一丟丟上 != 0)
        {
                if(this.playerMoveC.丟三丏丅世一丟丟上.且世专不丄丏七下万() == true)
        {
            goto label_52;
        }
        
        }
        
        }
        
        bool val_31 = 丐丟丙不丗万三丈丆.与一丅丝不丈业与丙().丝专丙与丈丒丟丁丘(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        goto label_56;
    }
    private void 上丒丈世丗丆丗丛下(string 丞一丁业丄一一业且, bool 七丅丅世丆丆丗丟丐)
    {
        string val_21;
        var val_22;
        val_21 = 丞一丁业丄一一业且;
        if((System.String.op_Equality(a:  this.丗丝丅丅丂七东丞专, b:  val_21)) != false)
        {
                var val_2 = (this.丏丝丁下丗丗丕与丕 == true) ? 1 : 0;
            val_2 = val_2 ^ 七丅丅世丆丆丗丟丐;
            if(val_2 == true)
        {
                return;
        }
        
        }
        
        if(this.丟丗丛丝不世下东丅 != null)
        {
                this.StopCoroutine(routine:  this.丟丗丛丝不世下东丅);
            this.丟丗丛丝不世下东丅 = 0;
        }
        
        UnityEngine.Transform val_3 = this.LeftBootPoint.transform;
        if(val_3.childCount < 1)
        {
            goto label_6;
        }
        
        val_22 = 0;
        goto label_7;
        label_13:
        UnityEngine.Object.Destroy(obj:  val_3.GetChild(index:  0).gameObject);
        val_22 = 1;
        label_7:
        if(val_22 < val_3.childCount)
        {
            goto label_13;
        }
        
        label_6:
        UnityEngine.Transform val_8 = this.RightBootPoint.transform;
        if(val_8.childCount < 1)
        {
            goto label_16;
        }
        
        val_22 = 0;
        goto label_17;
        label_23:
        UnityEngine.Object.Destroy(obj:  val_8.GetChild(index:  0).gameObject);
        val_22 = 1;
        label_17:
        if(val_22 < val_8.childCount)
        {
            goto label_23;
        }
        
        label_16:
        bool val_21 = ~七丅丅世丆丆丗丟丐;
        val_21 = val_21 & 1;
        this.丗丝丅丅丂七东丞专 = val_21;
        this.丏丝丁下丗丗丕与丕 = val_21;
        this.上下且丈与丅丑丙丄();
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.SetRoyaleAvatarToPlayerBody();
        }
        
        val_21 = this.丗丝丅丅丂七东丞专;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_21)) != false)
        {
                return;
        }
        
        if((this.丗丝丅丅丂七东丞专.Equals(value:  与丂丏丛丞丞丒丟丄.丏丟且丛业不丙七丟())) == true)
        {
                return;
        }
        
        if(七丅丅世丆丆丗丟丐 == true)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丟丗丛丝不世下东丅 = this.StartCoroutine(routine:  this.丅丑丛丘丄丏丗世丏(七丅丅世丆丆丗丟丐:  false));
    }
    private System.Collections.IEnumerator 丅丑丛丘丄丏丗世丏(bool 七丅丅世丆丆丗丟丐)
    {
        SkinName.丈丆丛丐丟丅且三丁 val_1 = new SkinName.丈丆丛丐丟丅且三丁(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七丅丅世丆丆丗丟丐 = 七丅丅世丆丆丗丟丐;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丅丅与上丛丙丝丝丞(string 业丐丐丈丐丕丏丛丒)
    {
        this.上丒丈世丗丆丗丛下(丞一丁业丄一一业且:  业丐丐丈丐丕丏丛丒, 七丅丅世丆丆丗丟丐:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
    }
    private System.Collections.IEnumerator 丏丙丈丐东丄不东世(string 丈丐丕业下丟业丛一, UnityEngine.Texture 下万东丕丏丟丟丝丗)
    {
        SkinName.专丏丁丟丞下七丟丂 val_1 = new SkinName.专丏丁丟丞下七丟丂(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丈丐丕业下丟业丛一 = 丈丐丕业下丟业丛一;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丈丐丕业下丟业丛一;
        }
        
        .下万东丕丏丟丟丝丗 = 下万东丕丏丟丟丝丗;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丞丙丞专丐一三丁一(byte[] 丒丏丁丛业丞世丅业)
    {
        UnityEngine.FilterMode val_6;
        UnityEngine.Texture val_7;
        UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  12, height:  16, textureFormat:  5, mipChain:  false);
        bool val_2 = UnityEngine.ImageConversion.LoadImage(tex:  val_1, data:  丒丏丁丛业丞世丅业, markNonReadable:  true);
        if(val_1 != null)
        {
                val_6 = 0;
            val_1.filterMode = val_6;
            val_7 = val_1;
        }
        else
        {
                val_6 = 0;
            0.filterMode = val_6;
            val_7 = 0;
        }
        
        if(val_1.width != 12)
        {
                return;
        }
        
        if(val_1.height != 16)
        {
                return;
        }
        
        this.丞丌且不三丝丈丝丐 = val_7;
        this.丌专专万丟业与丂东 = "cape_Custom";
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  "cape_Custom", 丟三丟三丅专丂丄丂:  val_7, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    private bool 丅专与且丙三东专丆()
    {
        if(this.playerMoveC != null)
        {
                return this.playerMoveC.丅专与且丙三东专丆();
        }
        
        return this.playerMoveC.丅专与且丙三东专丆();
    }
    private void 丝丁丕七且丕不七丌(string 下业七不丑丂丏丟东)
    {
        UnityEngine.FilterMode val_7;
        UnityEngine.Texture val_8;
        UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  12, height:  16, textureFormat:  5, mipChain:  false);
        bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  System.Convert.FromBase64String(s:  下业七不丑丂丏丟东), markNonReadable:  true);
        if(val_2 != null)
        {
                val_7 = 0;
            val_2.filterMode = val_7;
            val_8 = val_2;
        }
        else
        {
                val_7 = 0;
            0.filterMode = val_7;
            val_8 = 0;
        }
        
        if(val_2.width != 12)
        {
                return;
        }
        
        if(val_2.height != 16)
        {
                return;
        }
        
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  "cape_Custom", 丟三丟三丅专丂丄丂:  val_8, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    private void 丆世不丙与丞万三丘(string 丈丐丕业下丟业丛一, UnityEngine.Texture 丟三丟三丅专丂丄丂, bool 七丅丅世丆丆丗丟丐)
    {
        var val_15;
        var val_16 = 9;
        if(this.丙三与丏七一丘专丒 != null)
        {
                this.StopCoroutine(routine:  this.丙三与丏七一丘专丒);
            this.丙三与丏七一丘专丒 = 0;
        }
        
        UnityEngine.Transform val_3 = this.capesPoint.transform;
        if(val_3.childCount < 1)
        {
            goto label_5;
        }
        
        val_15 = 0;
        goto label_6;
        label_12:
        UnityEngine.Object.Destroy(obj:  val_3.GetChild(index:  0).gameObject);
        val_15 = 1;
        label_6:
        if(val_15 < val_3.childCount)
        {
            goto label_12;
        }
        
        label_5:
        this.丌专专万丟业与丂东 = 丈丐丕业下丟业丛一;
        this.丞丌且不三丝丈丝丐 = 丟三丟三丅专丂丄丂;
        this.上下且丈与丅丑丙丄();
        if((((this.丅专与且丙三东专丆() != true) ? 9 : 0) & 15) != 0)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  丈丐丕业下丟业丛一, b:  丆丟七丌丞东丆丕丌.丈丑东丆丛万丙丅业(丁丂专业丁丅丅丈丙:  9))) == true)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丙三与丏七一丘专丒 = this.StartCoroutine(routine:  this.丏丙丈丐东丄不东世(丈丐丕业下丟业丛一:  丈丐丕业下丟业丛一, 下万东丕丏丟丟丝丗:  丟三丟三丅专丂丄丂));
    }
    private void 不丏丛丕丙不上东万(string 丏丛三丙丐丞丗与丝)
    {
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  丏丛三丙丐丞丗与丝, 丟三丟三丅专丂丄丂:  0, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    private void 丙丁七丑上七东丈丟(bool 丁丘丗丘丆且且丏丗, bool 丄专丛万东万与丘业)
    {
        this.丏上东丁丛七丑丛丌 = 丁丘丗丘丆且且丏丗;
        this.三上丒三专丆丌与下 = 丄专丛万东万与丘业;
    }
    private void 丙上丈丝丌万下丁丑(int 丌业丌与丏一不万七)
    {
        this.丛七业丝丈三丁丝丐 = 丌业丌与丏一不万七;
    }
    private void 专业丁丁丞丒七丕且(string 丐万丑丆丘东丈丌丐, string 丆丙丗业丟丁丗丟丄, string 丐丛丙丛丟业丂专丗)
    {
        this.丟丕业丒丝专丁丗丗 = 丐万丑丆丘东丈丌丐;
        this.丑三东下丁七业丕丝 = 丆丙丗业丟丁丗丟丄;
        this.丄丏丒丁丈丂七丅丑 = 丐丛丙丛丟业丂专丗;
    }
    private void 丘丄丏世丒上东丘丒(string 丞一丁业丄一一业且, bool 七丅丅世丆丆丗丟丐)
    {
        string val_14;
        var val_15;
        val_14 = 丞一丁业丄一一业且;
        if((System.String.op_Equality(a:  this.丁丅上丟丑三且且丆, b:  val_14)) != false)
        {
                var val_2 = (this.丒东丒丑七且丌丗专 == true) ? 1 : 0;
            val_2 = val_2 ^ 七丅丅世丆丆丗丟丐;
            if(val_2 == true)
        {
                return;
        }
        
        }
        
        if(this.丒丒丂丂丛丌丐丈专 != null)
        {
                this.StopCoroutine(routine:  this.丒丒丂丂丛丌丐丈专);
            this.丒丒丂丂丛丌丐丈专 = 0;
        }
        
        UnityEngine.Transform val_3 = this.hatsPoint.transform;
        if(val_3.childCount < 1)
        {
            goto label_6;
        }
        
        val_15 = 0;
        goto label_7;
        label_13:
        UnityEngine.Object.Destroy(obj:  val_3.GetChild(index:  0).gameObject);
        val_15 = 1;
        label_7:
        if(val_15 < val_3.childCount)
        {
            goto label_13;
        }
        
        label_6:
        if(this.hatWear != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.hatWear);
        }
        
        bool val_14 = ~七丅丅世丆丆丗丟丐;
        val_14 = val_14 & 1;
        this.hatWear = 0;
        this.丁丅上丟丑三且且丆 = val_14;
        this.丒东丒丑七且丌丗专 = val_14;
        val_14 = this.playerMoveC;
        if(val_14 != 0)
        {
                val_14 = this.playerMoveC;
            val_14.SetRoyaleAvatarToPlayerBody();
        }
        
        this.上下且丈与丅丑丙丄();
        if(七丅丅世丆丆丗丟丐 == true)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丒丒丂丂丛丌丐丈专 = this.StartCoroutine(routine:  this.丐丒丕东丅且丁万丞());
    }
    private System.Collections.IEnumerator 丐丒丕东丅且丁万丞()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SkinName.七业丘丞与三东丈万(丗丏丅丕丆世丁专丟:  0);
    }
    private void 世丝丝一丒东丅专丐(string 丄丕丞丈丈下丛丞丕)
    {
        this.丘丄丏世丒上东丘丒(丞一丁业丄一一业且:  丄丕丞丈丈下丛丞丕, 七丅丅世丆丆丗丟丐:  (this.世丟丘丞丌丁丙丕丕 == false) ? 1 : 0);
    }
    internal void 丙上丐丟丆丆丏万三()
    {
        bool val_6;
        if(this.丝丛丁一不丂与丌且() != false)
        {
                var val_2 = (this.丏丁丕丅万丝丌丏且 == false) ? 1 : 0;
        }
        else
        {
                val_6 = 1;
        }
        
        if(this.丒丝丁丌丒丕不三与() != false)
        {
                val_6 = val_6 & ((this.丒东丒丑七且丌丗专 == false) ? 1 : 0);
        }
        
        this.playerMoveC.丂七丒与丄丏丟业丂(丙业与丙丗丝不丈东:  val_6, 丑丅世丏与丁丝丒丏:  this.playerMoveC.playerHeadRenderer.bones);
    }
    private bool 丒丝丁丌丒丕不三与()
    {
        return UnityEngine.Object.op_Inequality(x:  this.hatWear, y:  0);
    }
    private bool 丝丛丁一不丂与丌且()
    {
        return UnityEngine.Object.op_Inequality(x:  this.maskWear, y:  0);
    }
    private void 不一丙东七下不丕丑(string 丞一丁业丄一一业且, bool 七丅丅世丆丆丗丟丐)
    {
        string val_17;
        Player_move_c val_18;
        var val_19;
        val_17 = 丞一丁业丄一一业且;
        val_18 = this.playerMoveC;
        if(((System.String.op_Equality(a:  this.与丁丝七丕业业丄且, b:  this.playerMoveC.东丗丄与专业且不丟)) != false) && ((System.String.op_Inequality(a:  val_17, b:  this.playerMoveC.东丗丄与专业且不丟)) != false))
        {
                if((System.String.op_Inequality(a:  val_17, b:  this.playerMoveC.上丂业下丄丘世丕丙)) != false)
        {
                this.playerMoveC.一丗不丏丑丟丑与丞(上丂业下丄丘世丕丙:  val_17);
            return;
        }
        
        }
        
        if((System.String.op_Equality(a:  this.与丁丝七丕业业丄且, b:  val_17)) != false)
        {
                var val_5 = (this.丏丁丕丅万丝丌丏且 == true) ? 1 : 0;
            val_5 = val_5 ^ 七丅丅世丆丆丗丟丐;
            if(val_5 == true)
        {
                return;
        }
        
        }
        
        if(this.丁丈丌丏万七七丟丁 != null)
        {
                this.StopCoroutine(routine:  this.丁丈丌丏万七七丟丁);
            this.丁丈丌丏万七七丟丁 = 0;
        }
        
        UnityEngine.Transform val_6 = this.maskPoint.transform;
        if(val_6.childCount < 1)
        {
            goto label_13;
        }
        
        val_19 = 0;
        goto label_14;
        label_20:
        UnityEngine.Object.Destroy(obj:  val_6.GetChild(index:  0).gameObject);
        val_19 = 1;
        label_14:
        if(val_19 < val_6.childCount)
        {
            goto label_20;
        }
        
        label_13:
        val_18 = 1152921504848912384;
        if(this.maskWear != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.maskWear);
        }
        
        bool val_17 = ~七丅丅世丆丆丗丟丐;
        val_17 = val_17 & 1;
        this.maskWear = 0;
        this.与丁丝七丕业业丄且 = val_17;
        this.丏丁丕丅万丝丌丏且 = val_17;
        val_17 = this.playerMoveC;
        if(val_17 != 0)
        {
                val_17 = this.playerMoveC;
            val_17.SetRoyaleAvatarToPlayerBody();
        }
        
        this.上下且丈与丅丑丙丄();
        if(七丅丅世丆丆丗丟丐 == true)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丁丈丌丏万七七丟丁 = this.StartCoroutine(routine:  this.业且专与丙丄丘丝丈(七丅丅世丆丆丗丟丐:  false));
    }
    private System.Collections.IEnumerator 业且专与丙丄丘丝丈(bool 七丅丅世丆丆丗丟丐)
    {
        SkinName.专丑丗业且丂丅丑七 val_1 = new SkinName.专丑丗业且丂丅丑七(丗丏丅丕丆世丁专丟:  0);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七丅丅世丆丆丗丟丐 = 七丅丅世丆丆丗丟丐;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 丑一丐业丆丝上万不(string 万丒丆丈上丏丞丘一)
    {
        this.不一丙东七下不丕丑(丞一丁业丄一一业且:  万丒丆丈上丏丞丘一, 七丅丅世丆丆丗丟丐:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
    }
    private void 丆丙上世丟丐与三丑(bool 丑下万丂丞不七丄三, bool 丅丒丆三丌七丟七与, bool 丂丈业东丛且丈一下, bool 丒丒丏业专丌丑丟丆)
    {
        this.世丟丘丞丌丁丙丕丕 = 丑下万丂丞不七丄三;
        this.丒丕丄丆专丂丛丙万 = 丒丒丏业专丌丑丟丆;
        this.丕七丟三丗三丐业丁 = 丅丒丆三丌七丟七与;
        this.丛丑上一丗丒丘丗丈 = 丂丈业东丛且丈一下;
        this.丘丄丏世丒上东丘丒(丞一丁业丄一一业且:  this.丁丅上丟丑三且且丆, 七丅丅世丆丆丗丟丐:  (~丑下万丂丞不七丄三) & 1);
        this.不一丙东七下不丕丑(丞一丁业丄一一业且:  this.与丁丝七丕业业丄且, 七丅丅世丆丆丗丟丐:  (this.丕七丟三丗三丐业丁 == false) ? 1 : 0);
        this.上丒丈世丗丆丗丛下(丞一丁业丄一一业且:  this.丗丝丅丅丂七东丞专, 七丅丅世丆丆丗丟丐:  (this.丛丑上一丗丒丘丗丈 == false) ? 1 : 0);
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  this.丌专专万丟业与丂东, 丟三丟三丅专丂丄丂:  this.丞丌且不三丝丈丝丐, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    internal void 丗丄丒丆丟且丆丂丙()
    {
        this.丆世不丙与丞万三丘(丈丐丕业下丟业丛一:  this.丌专专万丟业与丂东, 丟三丟三丅专丂丄丂:  this.丞丌且不三丝丈丝丐, 七丅丅世丆丆丗丟丐:  (this.丒丕丄丆专丂丛丙万 == false) ? 1 : 0);
    }
    private void Start()
    {
        var val_14;
        var val_15;
        bool val_16;
        var val_17;
        var val_19;
        PhotonView val_1 = this.GetComponent<PhotonView>();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start Start SkinName " + val_1.ownerId);
        val_14 = null;
        val_14 = null;
        this.丐下丁三且丗上丈东 = WeaponManager.丟丗丄业丘丗业丗七;
        this.character = this.transform.GetComponent<UnityEngine.CharacterController>();
        val_15 = null;
        val_15 = null;
        this.丁丑丅丏丒不七上丁 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        this.丘丘丘丏丌丁丐丆丗 = this.GetComponent<PixelView>();
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                if(this.丄丈丑丐丆丞丘与丗.isMine != false)
        {
                bool val_14 = this.一七不三丌专三丆一;
            val_14 = val_14 ^ 1;
            val_16 = val_14 & 255;
        }
        else
        {
                val_16 = false;
        }
        
            this.isMine = val_16;
        }
        
        if(((UnityEngine.Object.op_Implicit(exists:  this.丄丈丑丐丆丞丘与丗)) != false) && (this.isMine != false))
        {
                PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        }
        
        val_17 = null;
        val_17 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if((与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) || (this.isMine == false))
        {
            goto label_25;
        }
        
        }
        
        this.gameObject.layer = 11;
        this.bodyLayer.layer = 11;
        this.headObj.layer = 11;
        label_25:
        if(this.isMine != false)
        {
                this.专丁丗下业丏且丟世(专丞上七七且丝七丗:  0);
            this.丑丞丟丁东丂三与丁(专丞上七七且丝七丗:  0, 万下上丏丙丈丄业丆:  "");
            this.丘丄丏世丒上东丘丒(专丞上七七且丝七丗:  0, 丙一丙丙丑丕丘万专:  "");
            this.上丒丈世丗丆丗丛下(专丞上七七且丝七丗:  0, 业万丙丟丁丁下丌丅:  "");
            this.上丛与丅丏丌上丁丞(专丞上七七且丝七丗:  0);
            this.不一丙东七下不丕丑(专丞上七七且丝七丗:  0, 万丑丗七丁丂丗世专:  "");
            this.丌下丅七丅丟丏且丄(专丞上七七且丝七丗:  0);
            this.丄丏万世丑三丌丅专(专丞上七七且丝七丗:  0);
        }
        
        val_19 = null;
        val_19 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
            goto label_33;
        }
        
        }
        
        this.世丒丁世丑七丕万七();
        label_33:
        if(this.areaVisitMonitor != 0)
        {
                this.areaVisitMonitor.gameObject.SetActive(value:  (this.isMine == true) ? 1 : 0);
        }
        
        PhotonView val_12 = this.GetComponent<PhotonView>();
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "End Start SkinName " + val_12.ownerId);
    }
    private void Update()
    {
        this.丕丘七丂丒丁东一与();
        if(this.playerMoveC == 0)
        {
                return;
        }
        
        this.playerMoveC.丏丏丒丙丐三世万丆();
    }
    private void LateUpdate()
    {
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return;
        }
        
        if(this.playerMoveC.丟三丏丅世一丟丟上.丑丈上东丗丐丆世上() != false)
        {
                return;
        }
        
        this.playerMoveC.丑丂丛丐丟丈下丕丌(世丂丞下丅且丕上丝:  UnityEngine.Mathf.Clamp(value:  0.3f, min:  0.2f, max:  1f));
    }
    private void 丕丘七丂丒丁东一与()
    {
        var val_19;
        var val_20;
        UnityEngine.GameObject val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        .丕专丄丄丞丑七万丟 = this.丌丏东丄丛世丘三与();
        System.Func<UnityEngine.GameObject, UnityEngine.Material[]> val_4 = new System.Func<UnityEngine.GameObject, UnityEngine.Material[]>(object:  new SkinName.丆一专丕丌且东丒世(), method:  UnityEngine.Material[] SkinName.丆一专丕丌且东丒世::丁世上丈不专世上丆(UnityEngine.GameObject 万且万且丑丗且丌丆));
        val_19 = val_4.Invoke(arg:  this.capesPoint);
        UnityEngine.Material[] val_6 = val_4.Invoke(arg:  this.LeftBootPoint);
        val_20 = val_4.Invoke(arg:  this.RightBootPoint);
        UnityEngine.Material[] val_8 = val_4.Invoke(arg:  this.hatsPoint);
        UnityEngine.Material[] val_9 = val_4.Invoke(arg:  this.maskPoint);
        val_21 = this.armorPoint;
        if((SkinName.丆一专丕丌且东丒世)[1152921539833972080].丕专丄丄丞丑七万丟 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  (~this.firstPersonControl.丂丕丁且世丗丕丛专()) & 1);
            val_21 = this.firstPersonControl;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.capesPoint, 丏业丟一东丂东丘丛:  (~val_21.丂丕丁且世丗丕丛专()) & 1);
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.capesPoint, 丏业丟一东丂东丘丛:  true);
        }
        
        if((val_19 != null) && (val_5.Length >= 1))
        {
                val_21 = "_Color";
            do
        {
            UnityEngine.Material val_24 = val_19[0];
            if(val_24 != null)
        {
                val_23 = 0f;
            val_22 = 0f;
            val_25 = 0f;
            val_24 = 0f;
            (val_24 == 0) ? 0 : (val_24).SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_23, g = val_22, b = val_25, a = val_24});
        }
        
        }
        while((0 + 1) < val_5.Length);
        
        }
        
        if((val_6 != null) && (val_6.Length >= 1))
        {
                do
        {
            val_21 = 0;
            UnityEngine.Material val_25 = val_6[val_21];
            if(val_25 != null)
        {
                val_23 = 0f;
            val_22 = 0f;
            val_25 = 0f;
            val_24 = 0f;
            (val_25 == 0) ? 0 : (val_25).SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_23, g = val_22, b = val_25, a = val_24});
        }
        
        }
        while((val_21 + 1) < val_6.Length);
        
        }
        
        if((val_20 != null) && (val_7.Length >= 1))
        {
                val_19 = "_Color";
            do
        {
            UnityEngine.Material val_26 = val_20[0];
            if(val_26 != null)
        {
                val_23 = 0f;
            val_22 = 0f;
            val_25 = 0f;
            val_24 = 0f;
            (val_26 == 0) ? 0 : (val_26).SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_23, g = val_22, b = val_25, a = val_24});
        }
        
        }
        while((0 + 1) < val_7.Length);
        
        }
        
        if((val_8 != null) && (val_8.Length >= 1))
        {
                do
        {
            val_19 = 0;
            UnityEngine.Material val_27 = val_8[val_19];
            if(val_27 != null)
        {
                val_23 = 0f;
            val_22 = 0f;
            val_25 = 0f;
            val_24 = 0f;
            (val_27 == 0) ? 0 : (val_27).SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_23, g = val_22, b = val_25, a = val_24});
        }
        
        }
        while((val_19 + 1) < val_8.Length);
        
        }
        
        if(val_9 == null)
        {
                return;
        }
        
        if(val_9.Length < 1)
        {
                return;
        }
        
        val_20 = "_Color";
        do
        {
            UnityEngine.Material val_28 = val_9[0];
            if(val_28 != null)
        {
                val_23 = 0f;
            val_25 = 0f;
            (val_28 == 0) ? 0 : (val_28).SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = val_23, g = 0f, b = val_25, a = 0f});
        }
        
        }
        while((0 + 1) < val_9.Length);
    
    }
    private bool 丌丏东丄丛世丘三与()
    {
        Player_move_c val_3;
        var val_4;
        var val_5;
        val_3 = this;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.isMine == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.firstPersonControl.丂丕丁且世丗丕丛专() != false)
        {
                val_5 = 1;
            return (bool)val_5;
        }
        
        val_3 = this.playerMoveC;
        var val_2 = (this.playerMoveC.万万一与丝业七专下 == true) ? 1 : 0;
        return (bool)val_5;
        label_4:
        val_5 = 0;
        return (bool)val_5;
    }
    private void 上下且丈与丅丑丙丄()
    {
        if(this.playerMoveC != 0)
        {
                this.playerMoveC.丒丝丛丗丁三丅一与(丌专专万丟业与丂东:  this.丌专专万丟业与丂东, 与丁丝七丕业业丄且:  this.与丁丝七丕业业丄且, 丁丅上丟丑三且且丆:  this.丁丅上丟丑三且且丆);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "playerMoveC.UpdateEffectsForCurrentWeapon playerMoveC == null");
    }
    public bool IsSetEquipped(SkinName.丙七丄东丙专丒七不 丂万丏专丒下丈丂丟)
    {
        var val_2;
        if(this.playerMoveC.丅下万丏丘东丄丌万 == false)
        {
                return (bool)(this.丛七业丝丈三丁丝丐 != 丂万丏专丒下丈丂丟) ? 1 : 0;
        }
        
        val_2 = 0;
        return (bool)(this.丛七业丝丈三丁丝丐 != 丂万丏专丒下丈丂丟) ? 1 : 0;
    }

}
