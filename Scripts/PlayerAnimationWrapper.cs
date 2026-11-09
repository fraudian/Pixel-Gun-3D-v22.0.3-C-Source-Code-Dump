using UnityEngine;
internal sealed class PlayerAnimationWrapper : MonoBehaviour
{
    // Fields
    public UnityEngine.Animator animator;
    public float lastShootingTime;
    internal UnityEngine.Transform[] spineBones;
    private bool 丈不丁万且丐丂丐下;
    private float agressiveRotationCooldown;
    private float 丐丘上丛万丟丈丞丞;
    private PlayerAnimationWrapper.丂专丅一业东丘东丈 currentState;
    private UnityEngine.Quaternion 丆丝丝世专万丐且丛;
    private float freeRotationReturnSpeed;
    private UnityEngine.Transform headBone;
    private float 三丞丂丈世丂丅业丌;
    private float landingHeadMoveSpeed;
    private float 丑丗且丙丑丂丐东丌;
    private UnityEngine.Vector2 丘丝丘专业专丆丈且;
    private float 丙丂上丛丁丝丐丐丆;
    private float 不丁下丕丌丈不丕丁;
    private float 业且下业丞不东丌与;
    private bool 丆上丐丌七丄丞专丛;
    private UnityEngine.Vector3 丕丐丄三丑丗丛专万;
    private UnityEngine.Vector3 丒与丘专丞东丑丘丘;
    private float 三丐上丑一丗丛上一;
    private float 三丂不丐与丞丟丄丗;
    private float maxFreeRotation;
    private float maxHeadRotationDown;
    private float maxHeadRotationUp;
    private float maxLandingHeadMove;
    private UnityEngine.Coroutine 丛一丟下东与丐丗世;
    private PlayerMovementsSoundsController movementsSounds;
    private bool 且丌且万与三丙专丐;
    private float movingAnimationsLerpSpeed;
    private float 丄丏丏丌丏丐丁三丛;
    private float networkAnimationsLerpSpeed;
    private bool 上丘丂丌丑东上且丗;
    private float onRealeseJoystickAnimationsLerpSpeed;
    private int 丛丛丛下且丟一丞且;
    private int 专三万丈丅丌丄丏丘;
    private int 不丌丁丛丄东不丄丞;
    private int 丝丌专万丐丞丐下不;
    private int 丆与丄丈丑丑万一七;
    private int 丙三且下世丆丕且丟;
    private int 丏丂下三丒专丕业丈;
    private int 丈且丒丘丙丞丕丅上;
    private int 专丙丈丘不一丒丕七;
    private int 世丟丁丝丌丅且且丑;
    private FirstPersonControlSharp playerControl;
    private PlayerAnimationWrapper.丂专丅一业东丘东丈 专丟丈七丘丑丁世业;
    private bool 丛万不丑丙丏丐丕一;
    private UnityEngine.Transform rootBone;
    private float rotationAnimationsLerpSpeed;
    private float rotationMoveSpeedModifier;
    private float spineRotationDifK;
    private float 万丛丕丌丂且下万不;
    private 业丗丕丟三丝丘三丗 丟且丈一世且丆世东;
    private float torsoRotationMultiplier;
    private int 丙丅世不丟一丑丕丞;
    private int 下专下丙丝丁世丑丗;
    private int 且不丑专丐丂丝且丆;
    private int 丂丗丝丞东业与丅丛;
    private int 世丘丆与丁丈业丆丏;
    private UnityEngine.Transform weaponPoint;
    private UnityEngine.Transform weaponPointNotMine;
    private UnityEngine.Transform FPSPlayerGameObjectContainer;
    private UnityEngine.Transform FPSCamContainer;
    private UnityEngine.Transform FPSGameObjectPosContainer;
    private float 不专丛下丏专且丏丕;
    private float weaponWalkAnimationDuration;
    private float weaponLerpToIdleSpeed;
    private CurveAnimationEntry[] weaponWalkAnimationEntries;
    private float 东丕丗丘不一丗丅专;
    private UnityEngine.Vector3 丛不业丕丐上三丕丏;
    private UnityEngine.Vector3 下丏与世丌丛丝七万;
    private float weaponIdleAnimationMinMoving;
    private float weaponIdleAnimationMaxMoving;
    private float weaponIdleAnimationMinRotation;
    private float weaponIdleAnimationMaxRotation;
    private float weaponIdleAnimationRotateSpeed;
    private float weaponIdleAnimationMoveSpeed;
    private float 丕丆丒三丞东一七三;
    private float 下丐丏专丙丛下东丂;
    private float 东丗专下丅专丂丅世;
    private float 专丕不丝丏不丆丒七;
    private UnityEngine.Transform GameObjectContainer;
    private float weaponDirectionAnimationInertion;
    private float weaponDirectionAnimationLerpSpeed;
    private float weaponDirectionAnimatioMaxAngle;
    private UnityEngine.Vector2 丑七丛丌丁丅七丂丝;
    public float currentWeaponDirectionRotationZ;
    internal static readonly float 上丛丆丛丝丙专丙专;
    internal static readonly float 丁七丏丏且专丞不三;
    internal float 丗丞万不上丁丘丄丑;
    private UnityEngine.Vector3 <丂丝世丐且丄丒三丘>k__BackingField;
    private bool 丗丆且万丑三丂一丈;
    private int 且丗东丅上丕与上丑;
    private float <丙丐下且丟丕丞丂上>k__BackingField;
    public UnityEngine.RuntimeAnimatorController defaultAnimatorController;
    
    // Properties
    internal UnityEngine.Vector3 业丘丆丟下一丛丅丒 { get; set; }
    internal bool 丐丟丛与丒七一业丅 { get; }
    internal bool 丙丌业七且与丏丘丌 { get; set; }
    internal bool 七与丆丛丆丌且上丑 { get; }
    internal float 丆丌专丘下上丗丈专 { get; set; }
    internal float 丞丁丄丐与丛丟下不 { get; }
    internal PlayerAnimationWrapper.丂专丅一业东丘东丈 丙丟与丐三丐万万丆 { get; set; }
    private UnityEngine.Animation 丏三丑且丁丒世丄丆 { get; }
    
    // Methods
    internal UnityEngine.Vector3 丞世专丒上专且东东()
    {
        return new UnityEngine.Vector3() {x = this.<丂丝世丐且丄丒三丘>k__BackingField};
    }
    private void 三丙丐不丄三丂上丘(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.<丂丝世丐且丄丒三丘>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921535897415584] = 丙业与丙丗丝不丈东.y;
        mem[1152921535897415588] = 丙业与丙丗丝不丈东.z;
    }
    internal bool 下一丏丏丙与上与丂()
    {
        return (bool)this.丗丆且万丑三丂一丈;
    }
    internal void 一丙世丐且东与丁丘(bool 丙业与丙丗丝不丈东)
    {
        UnityEngine.Animator val_5 = this.animator;
        this.丈不丁万且丐丂丐下 = 丙业与丙丗丝不丈东;
        if(val_5.isInitialized == false)
        {
                return;
        }
        
        if(this.playerControl.丘丂三东丁且丙世七() != true)
        {
                val_5 = this.playerControl;
            if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        }
        
        val_5 = this.animator;
        val_5.SetBool(id:  this.丛丛丛下且丟一丞且, value:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        丂专丅一业东丘东丈 val_5 = this.currentState;
        val_5 = val_5 - 3;
        if(val_5 < 4)
        {
                return;
        }
        
        if(this.不专丛下丏专且丏丕 <= 0.3f)
        {
                return;
        }
        
        this.丌七丗东三丏东丅丕(丙业与丙丗丝不丈东:  3);
    }
    internal bool 丌丁丕七不三丒丒丗()
    {
        return (bool)this.丈不丁万且丐丂丐下;
    }
    internal bool 一七丟丘丕且一丁丘()
    {
        var val_4;
        if((this.playerControl == 0) || (this.playerControl._moveC == 0))
        {
            goto label_7;
        }
        
        if(this.playerControl._moveC.东丗丒丝丐且丞丄丏 == false)
        {
            goto label_10;
        }
        
        val_4 = 1;
        return (bool)val_4;
        label_7:
        val_4 = 0;
        return (bool)val_4;
        label_10:
        var val_3 = (this.playerControl._moveC.七丕丞丞丗专上丝丘 == true) ? 1 : 0;
        return (bool)val_4;
    }
    public void PlayGetHit()
    {
        UnityEngine.Animator val_2;
        int val_3;
        int val_1 = UnityEngine.Random.Range(min:  0, max:  3);
        this.且丗东丅上丕与上丑 = val_1;
        if(val_1 == 0)
        {
            goto label_0;
        }
        
        val_2 = this.animator;
        if(val_1 != 1)
        {
            goto label_1;
        }
        
        val_3 = this.且不丑专丐丂丝且丆;
        if(val_2 != null)
        {
            goto label_5;
        }
        
        goto label_6;
        label_0:
        val_2 = this.animator;
        val_3 = this.下专下丙丝丁世丑丗;
        if(val_2 != null)
        {
            goto label_5;
        }
        
        label_6:
        label_5:
        val_2.SetTrigger(id:  val_3);
        return;
        label_1:
        if(val_2 != null)
        {
            goto label_5;
        }
        
        goto label_6;
    }
    internal float 丕专丅东下丙丙丌万()
    {
        return (float)this.<丙丐下且丟丕丞丂上>k__BackingField;
    }
    private void 业丝丒丑丏不丏一丕(float 丙业与丙丗丝不丈东)
    {
        this.<丙丐下且丟丕丞丂上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal float 丌下丐丄下丏丞丅丐()
    {
        return UnityEngine.Mathf.Clamp(value:  this.丙丂上丛丁丝丐丐丆, min:  0f, max:  1f);
    }
    internal void 丌七丗东三丏东丅丕(PlayerAnimationWrapper.丂专丅一业东丘东丈 丙业与丙丗丝不丈东)
    {
        FirstPersonControlSharp val_9;
        丂专丅一业东丘东丈 val_10;
        UnityEngine.CapsuleCollider val_11;
        丂专丅一业东丘东丈 val_12;
        val_9 = this.playerControl;
        if(val_9 == 0)
        {
                return;
        }
        
        val_9 = this.playerControl._moveC;
        if(val_9 == 0)
        {
                return;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(this.playerControl.丝丝丐业不业与丐下 == false)
        {
            goto label_15;
        }
        
        }
        
        }
        
        label_63:
        if((丙业与丙丗丝不丈东 == 2) && (this.playerControl.丌且下丕下下丌万丞 != true))
        {
                val_9 = this.playerControl._moveC;
            if(this.playerControl._moveC.东丑丌丄丝世丞丘三 == false)
        {
                return;
        }
        
        }
        
        val_9 = this.playerControl;
        this.currentState = 丙业与丙丗丝不丈东;
        if(this.playerControl._moveC.丅丕丁丒丗东业且丁 != false)
        {
                丂专丅一业东丘东丈 val_9 = this.currentState;
            if(val_9 <= 7)
        {
                val_9 = 1 << val_9;
            val_9 = val_9 & 131;
            if(val_9 != 0)
        {
                this.currentState = 11;
        }
        
        }
        
        }
        
        if(this.animator.isInitialized != false)
        {
                if(this.playerControl.丘丂三东丁且丙世七() != true)
        {
                if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
            goto label_39;
        }
        
        }
        
            val_9 = this.专丙丈丘不一丒丕七;
            this.animator.SetInteger(id:  val_9, value:  this.currentState);
            val_10 = this.currentState;
            if(((this.专丟丈七丘丑丁世业 != 11) && (val_10 != this.专丟丈七丘丑丁世业)) && (val_10 == 2))
        {
                val_9 = this.丙丅世不丟一丑丕丞;
            this.animator.SetTrigger(id:  val_9);
            val_10 = this.currentState;
        }
        
            if((val_10 != 3) && (this.专丟丈七丘丑丁世业 == 3))
        {
                val_9 = this.丆与丄丈丑丑万一七;
            this.animator.SetFloat(id:  val_9, value:  0f);
        }
        
        }
        
        label_39:
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_75;
        }
        
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
            goto label_75;
        }
        
        if(this.currentState == 1)
        {
            goto label_49;
        }
        
        if(this.currentState == 11)
        {
            goto label_50;
        }
        
        if((this.currentState != 2) || (this.专丟丈七丘丑丁世业 == 2))
        {
            goto label_52;
        }
        
        label_72:
        this.playerControl._moveC.bodyCollayder.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_11 = this.playerControl._moveC.bodyCollayder;
        if(val_11 != null)
        {
            goto label_71;
        }
        
        goto label_71;
        label_15:
        val_9 = this.playerControl;
        if(丙业与丙丗丝不丈东 != 7)
        {
            goto label_63;
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        goto label_63;
        label_49:
        val_12 = this.专丟丈七丘丑丁世业;
        if(val_12 == 1)
        {
            goto label_64;
        }
        
        this.playerControl._moveC.bodyCollayder.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_11 = this.playerControl._moveC.bodyCollayder;
        goto label_71;
        label_50:
        if(this.专丟丈七丘丑丁世业 != 11)
        {
            goto label_72;
        }
        
        label_52:
        val_12 = this.专丟丈七丘丑丁世业;
        label_64:
        if((this.currentState == val_12) || (val_12 > 11))
        {
            goto label_75;
        }
        
        var val_10 = 1;
        val_10 = val_10 << val_12;
        val_10 = val_10 & 2054;
        if(val_10 == 0)
        {
            goto label_75;
        }
        
        this.playerControl._moveC.bodyCollayder.center = new UnityEngine.Vector3() {x = this.playerControl._moveC.丏一丏丁七丆丙不且, y = V9.16B, z = V10.16B};
        this.playerControl._moveC.bodyCollayder.radius = this.playerControl._moveC.一丄丗丕丐丝丙下丟;
        val_9 = this.playerControl._moveC;
        label_71:
        this.playerControl._moveC.bodyCollayder.height = this.playerControl._moveC.万七且七与世且丁东;
        label_75:
        this.专丟丈七丘丑丁世业 = this.currentState;
    }
    internal PlayerAnimationWrapper.丂专丅一业东丘东丈 丄丙丂丝丄丌丗丂丅()
    {
        return (丂专丅一业东丘东丈)this.currentState;
    }
    private UnityEngine.Animation 世丑专丆丆丑丅七不()
    {
        PlayerMechBody val_3;
        UnityEngine.Animation val_4;
        val_3 = this;
        bool val_1 = GameConnect.东且三丆丑世世丘丟();
        if(this.playerControl._moveC == null)
        {
            goto label_4;
        }
        
        if(val_1 == false)
        {
            goto label_5;
        }
        
        return this.playerControl._moveC.mechBearBodyAnimation;
        label_4:
        if(val_1 == true)
        {
                return this.playerControl._moveC.mechBearBodyAnimation;
        }
        
        label_5:
        val_4 = 0;
        if(this.playerControl._moveC.丑丝丂丗丝丛与不七 == 0)
        {
                return val_4;
        }
        
        val_3 = this.playerControl._moveC.丑丝丂丗丝丛与不七;
        val_4 = this.playerControl._moveC.丑丝丂丗丝丛与不七.bodyAnimation;
        return val_4;
    }
    internal PlayerAnimationWrapper.丂专丅一业东丘东丈 丞丆丛丐万丁丈万万()
    {
        FirstPersonControlSharp val_8;
        FirstPersonControlSharp val_9;
        var val_10;
        var val_11;
        FirstPersonControlSharp val_12;
        val_8 = this;
        val_9 = this.playerControl;
        if(val_9 == null)
        {
            goto label_1;
        }
        
        if(this.playerControl.丑丞丒丟丞丟丆丁一 == false)
        {
            goto label_2;
        }
        
        label_6:
        if(this.playerControl.丛丗丑丝丕丌七与丆 == false)
        {
            goto label_3;
        }
        
        label_24:
        val_10 = 4;
        return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        label_1:
        if(this.playerControl == null)
        {
            goto label_5;
        }
        
        val_9 = this.playerControl;
        if(this.playerControl.丑丞丒丟丞丟丆丁一 == true)
        {
            goto label_6;
        }
        
        label_2:
        if(this.playerControl._moveC.与丏下丝万上三丛不() == false)
        {
            goto label_8;
        }
        
        val_10 = 8;
        return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        label_3:
        val_8 = this.playerControl;
        return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        label_8:
        if(this.playerControl.世丟丈丏丕万丝丆万.isGrounded == true)
        {
            goto label_13;
        }
        
        val_11 = null;
        val_11 = null;
        if(与丂丏丛丞丞丒丟丄.三专一丒丛丘丗丝与 == true)
        {
            goto label_16;
        }
        
        label_13:
        if(this.playerControl.cableCarMoving == false)
        {
            goto label_18;
        }
        
        label_16:
        if(this.playerControl.cableCarMoving == false)
        {
            goto label_24;
        }
        
        this.playerControl.丞丗丄丂丆业丈丑业.playerMoveC.SetDefaultAnimatorController();
        goto label_24;
        label_18:
        val_12 = this.playerControl;
        if(val_12 == null)
        {
            goto label_25;
        }
        
        if(this.playerControl.下丅丂丘丏丟世且丐 == true)
        {
            goto label_26;
        }
        
        goto label_29;
        label_25:
        if(this.playerControl == null)
        {
            goto label_28;
        }
        
        val_12 = this.playerControl;
        if(this.playerControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_29;
        }
        
        label_26:
        var val_4 = ((this.playerControl.丌专丒丒丛丐丘上丄 & 1) != 0) ? (9 + 1) : 9;
        return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        label_28:
        val_12 = 0;
        label_29:
        if(val_12.下上且丏世丈丞丏东() != true)
        {
                if((this.playerControl.世丟丈丏丕万丝丆万.isGrounded != true) && (this.playerControl.与丌丆下丝下丘丏丗 > 0.5f))
        {
                if(this.currentState != 2)
        {
                return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        }
        
        }
        
        }
        
        if(this.playerControl.不丕与下丄丟丕丄丛() != false)
        {
                return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        }
        
        if(this.playerControl._moveC.丅丕丁丒丗东业且丁 != false)
        {
                return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        }
        
        if(this.playerControl._moveC.丌专丌丌一丒万丟丕 == true)
        {
                return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        }
        
        if(this.playerControl != null)
        {
                return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        }
        
        return (丂专丅一业东丘东丈)(this.playerControl.一三丌与丑丑丞丈丟 == true) ? (5 + 1) : 5;
        label_5:
    }
    internal float 七东丞业且不丌丝丈(PlayerAnimationWrapper.丂专丅一业东丘东丈 专丞丅业丆丐丕不七)
    {
        float val_11;
        FirstPersonControlSharp val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_22;
        val_11 = 0f;
        if(专丞丅业丆丐丕不七 <= 4)
        {
                var val_10 = 106038840 + (专丞丅业丆丐丕不七) << 2;
            val_10 = val_10 + 106038840;
        }
        else
        {
                val_17 = this.playerControl;
            if(this.playerControl.丌且下丕下下丌万丞 == false)
        {
                return (float)val_11;
        }
        
            val_18 = null;
            val_18 = null;
            val_17 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            if(val_17 == 0)
        {
                return (float)val_11;
        }
        
            val_19 = null;
            if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                val_20 = null;
            WeaponSounds val_4 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            val_17 = val_4.categoryNabor;
            float val_6 = 丘丐丘万丌丟丞下丝.丘三三丌丅丆丄丐丝(七上丟东丂业丑丁丆:  val_17 - 1);
        }
        else
        {
                val_22 = null;
            WeaponSounds val_7 = WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗();
            val_17 = val_7.categoryNabor;
        }
        
            val_11 =  * (丘丐丘万丌丟丞下丝.上一且丝丂上丆丞万(七上丟东丂业丑丁丆:  val_17 - 1));
            return (float)val_11;
        }
    
    }
    public void OnLanding()
    {
        if(this.丛一丟下东与丐丗世 != null)
        {
                return;
        }
        
        this.丛一丟下东与丐丗世 = this.StartCoroutine(routine:  this.万丗丂丟专三丕下丞());
    }
    internal void 下丞且东三三丂丒下(UnityEngine.Quaternion 丘丒丒丙丆不丝丂丂, bool 丞丆业与丄丟丂三丈 = False)
    {
        this.丆丝丝世专万丐且丛 = 丘丒丒丙丆不丝丂丂;
        mem[1152921535900061796] = 丘丒丒丙丆不丝丂丂.y;
        mem[1152921535900061800] = 丘丒丒丙丆不丝丂丂.z;
        mem[1152921535900061804] = 丘丒丒丙丆不丝丂丂.w;
        this.且丌且万与三丙专丐 = 丞丆业与丄丟丂三丈;
    }
    internal void 丌业丈丏东上丕丟世()
    {
        if(this.animator.isInitialized != false)
        {
                if(this.playerControl.丘丂三东丁且丙世七() != true)
        {
                if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
            goto label_7;
        }
        
        }
        
            if(this.一七丟丘丕且一丁丘() != false)
        {
                this.丙万丕丗业丂丌丆丂();
        }
        else
        {
                this.animator.SetTrigger(id:  this.世丘丆与丁丈业丆丏);
        }
        
        }
        
        label_7:
        this.movementsSounds.丕丗丁丄专丏三东不();
    }
    internal void 东丄丟上丗与丆丑世()
    {
        UnityEngine.Quaternion val_2 = this.playerControl.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.rotation;
        this.三丐上丑一丗丛上一 = val_2.y;
    }
    internal void 丌万下世丟丅丁七丐(bool 丂丛不丐丏丂丕丙丞, int 丘丒丌下丕专且七专)
    {
        if(PlatformsList.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        var val_2 = (this.上丘丂丌丑东上且丗 == true) ? 1 : 0;
        val_2 = val_2 ^ 丂丛不丐丏丂丕丙丞;
        if(val_2 != true)
        {
                if(this.世丟丁丝丌丅且且丑 == 丘丒丌下丕专且七专)
        {
            goto label_5;
        }
        
        }
        
        PlatformController[] val_3 = PlatformsList.丄丘七三上丕世丞业.platforms + (((long)(int)(丘丒丌下丕专且七专)) << 3);
        UnityEngine.Vector3 val_4 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + ((long)(int)(丘丒丌下丕专且七专)) << 3) + 32] + 48.position;
        this.丕丐丄三丑丗丛专万 = val_4;
        mem[1152921535900471592] = val_4.y;
        mem[1152921535900471596] = val_4.z;
        label_5:
        this.上丘丂丌丑东上且丗 = 丂丛不丐丏丂丕丙丞;
        this.世丟丁丝丌丅且且丑 = 丘丒丌下丕专且七专;
    }
    private void 丙万丕丗业丂丌丆丂()
    {
        this.世丑专丆丆丑丅七不().CrossFade(animation:  "Jump", fadeLength:  0.2f);
    }
    private void 丘丅下丗丆丟丝丒不(UnityEngine.Vector2 一下丙丆丗与丆丗丏)
    {
        string val_18;
        var val_2 = (this.currentState == 4) ? 1 : 0;
        var val_5 = ((val_2 | (~(this.playerControl._moveC.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  4)))) != true) ? (val_2) : ((this.currentState == 3) ? 1 : 0);
        if((this.currentState != 3) || ((val_5 & 1) != 0))
        {
            goto label_4;
        }
        
        label_38:
        val_18 = "Jump";
        goto label_5;
        label_4:
        if((一下丙丆丗与丆丗丏.x != 0f) || (一下丙丆丗与丆丗丏.y != 0f))
        {
            goto label_7;
        }
        
        val_18 = mem[val_5 != 0x0 ? "Jetpack_Idle" : "Idle"];
        val_18 = (val_5 != 0) ? "Jetpack_Idle" : "Idle";
        label_5:
        if(this.世丑专丆丆丑丅七不() == 0)
        {
                return;
        }
        
        if(this.世丑专丆丆丑丅七不().isPlaying != false)
        {
                if((this.世丑专丆丆丑丅七不().IsPlaying(name:  val_18)) == true)
        {
                return;
        }
        
            if((this.世丑专丆丆丑丅七不().IsPlaying(name:  "Reload")) == true)
        {
                return;
        }
        
            if((this.世丑专丆丆丑丅七不().IsPlaying(name:  "Shoot")) != false)
        {
                return;
        }
        
        }
        
        this.世丑专丆丆丑丅七不().CrossFade(animation:  val_18, fadeLength:  0.2f);
        return;
        label_7:
        if(val_5 == 0)
        {
            goto label_20;
        }
        
        if(System.Math.Abs(一下丙丆丗与丆丗丏.y) >= System.Math.Abs(一下丙丆丗与丆丗丏.x))
        {
            goto label_23;
        }
        
        if(一下丙丆丗与丆丗丏.x >= 0f)
        {
            goto label_38;
        }
        
        goto label_38;
        label_20:
        if(System.Math.Abs(一下丙丆丗与丆丗丏.y) >= System.Math.Abs(一下丙丆丗与丆丗丏.x))
        {
            goto label_28;
        }
        
        if(一下丙丆丗与丆丗丏.x >= 0f)
        {
            goto label_38;
        }
        
        goto label_38;
        label_23:
        if(一下丙丆丗与丆丗丏.y >= 0f)
        {
            goto label_38;
        }
        
        goto label_38;
        label_28:
        if(一下丙丆丗与丆丗丏.y >= 0f)
        {
            goto label_38;
        }
        
        goto label_38;
    }
    private void 丗世万丗上丆且不下(bool 丙不专下丟与世业万)
    {
        ScopeViewGameEventsController val_18;
        var val_19;
        Player_move_c val_20;
        var val_21;
        var val_22;
        float val_23;
        var val_24;
        float val_25;
        var val_26;
        业丗丕丟三丝丘三丗 val_27;
        var val_28;
        var val_29;
        val_18 = this;
        val_19 = null;
        val_19 = null;
        val_20 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_20 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.playerControl;
        if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        val_20 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.playerControl._moveC;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.playerControl._moveC.丟三丏丅世一丟丟上;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.playerControl._moveC.丟三丏丅世一丟丟上;
        if(this.playerControl._moveC.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true)
        {
                return;
        }
        
        float val_5 = UnityEngine.Time.realtimeSinceStartup;
        val_5 = val_5 - this.三丂不丐与丞丟丄丗;
        if(val_5 <= this.万丛丕丌丂且下万不)
        {
                return;
        }
        
        this.三丂不丐与丞丟丄丗 = UnityEngine.Time.realtimeSinceStartup;
        val_22 = null;
        val_22 = null;
        UnityEngine.Vector3 val_8 = transform.position;
        val_23 = val_8.z;
        UnityEngine.Vector3 val_10 = this.playerControl._moveC.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_23}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        val_24 = null;
        val_25 = val_11.x;
        val_24 = null;
        val_20 = ScopeViewGameEventsController.丄丘七三上丕世丞业.GetEventSettings(且下丕七丙丗丄不七:  2);
        float val_18 = val_12.maxTargetDistance;
        if((this.currentState == 0) && (丙不专下丟与世业万 != false))
        {
                val_26 = 1;
        }
        else
        {
                if(this.专丟丈七丘丑丁世业 == 3)
        {
                var val_13 = (this.currentState != 3) ? 1 : 0;
        }
        else
        {
                val_26 = 0;
        }
        
        }
        
        val_18 = val_18 * val_18;
        val_27 = this.丟且丈一世且丆世东;
        val_26 = val_26 & ((val_25 < 0) ? 1 : 0);
        if(val_26 != 0)
        {
                if(val_27 != null)
        {
                if(this.丟且丈一世且丆世东.下丌丘七专丂七三丆 == false)
        {
            goto label_49;
        }
        
        }
        
            val_28 = null;
            val_28 = null;
            val_20 = this.transform;
            UnityEngine.Color val_16 = UnityEngine.Color.white;
            val_25 = val_16.r;
            val_23 = val_16.b;
            this.丟且丈一世且丆世东 = ScopeViewGameEventsController.丄丘七三上丕世丞业.AddEvent(且下丕七丙丗丄不七:  2, 业不不丞专丗丟世丈:  val_20, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_25, g = val_16.g, b = val_23, a = val_16.a}, 丑丘丛丆丝上丂丙丗:  -1f, 丐丟丕丌与丞丅下万:  1f);
            return;
        }
        
        if(val_27 == null)
        {
                return;
        }
        
        if(this.丟且丈一世且丆世东.下丌丘七专丂七三丆 == true)
        {
                return;
        }
        
        val_29 = null;
        val_29 = null;
        val_27 = this.丟且丈一世且丆世东;
        val_18 = ScopeViewGameEventsController.丄丘七三上丕世丞业;
        val_18.DisableEvent(丅东专与不三丂丁丝:  val_27);
        return;
        label_49:
        val_27.下与丞三丅丛丄七丕();
    }
    public void ResetFreeRotation()
    {
        this.丑丗且丙丑丂丐东丌 = 0f;
    }
    public void ResetCurrentLadderDelta()
    {
        this.丐丘上丛万丟丈丞丞 = 0f;
    }
    public void SetLastOnLadder()
    {
        this.丆上丐丌七丄丞专丛 = true;
    }
    private void LateUpdate()
    {
        float val_252;
        int val_254;
        float val_255;
        float val_256;
        float val_257;
        float val_258;
        FirstPersonControlSharp val_259;
        float val_260;
        float val_264;
        float val_265;
        float val_266;
        float val_267;
        float val_268;
        var val_269;
        if(this.playerControl == 0)
        {
                return;
        }
        
        if(this.playerControl._moveC == 0)
        {
                return;
        }
        
        if(this.playerControl.丞丗丄丂丆业丈丑业 == 0)
        {
                return;
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 != true)
        {
                if(this.playerControl.东丌丏丗丁丟丘不丆() == false)
        {
                return;
        }
        
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 != true)
        {
                val_252 = 0f;
            if(this.丈不丁万且丐丂丐下 != true)
        {
                val_252 = this.不专丛下丏专且丏丕 + UnityEngine.Time.deltaTime;
        }
        
            this.不专丛下丏专且丏丕 = val_252;
        }
        
        if(this.playerControl.cableCarMoving == false)
        {
            goto label_20;
        }
        
        label_56:
        if(this.一七丟丘丕且一丁丘() != false)
        {
                if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_54;
        }
        
        }
        
        if(GameConnect.丛专丌且丕不专丈下() == true)
        {
            goto label_54;
        }
        
        bool val_10 = GameConnect.丆丕丒与丂七与下上();
        goto label_30;
        label_20:
        if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                if(this.playerControl.丘丂三东丁且丙世七() == false)
        {
            goto label_56;
        }
        
        }
        
        if(GameController.mode.IsControllerBattleRoyalType != false)
        {
                if(this.currentState == 8)
        {
            goto label_54;
        }
        
        }
        
        if(this.currentState == 2)
        {
            goto label_54;
        }
        
        if(this.currentState != 4)
        {
            goto label_41;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_47;
        }
        
        }
        
        if((this.playerControl.丑丞丒丟丞丟丆丁一 == true) || (this.playerControl.丛丗丑丝丕丌七与丆 == true))
        {
            goto label_54;
        }
        
        label_47:
        if(GameConnect.丁丁丗丐东丄丞一丛() == true)
        {
            goto label_54;
        }
        
        丂专丅一业东丘东丈 val_250 = this.currentState;
        label_41:
        val_250 = val_250 - 5;
        if(val_250 >= 7)
        {
            goto label_56;
        }
        
        val_250 = val_250 & 255;
        val_250 = 83 >> val_250;
        if((val_250 & 1) == 0)
        {
            goto label_56;
        }
        
        label_54:
        label_30:
        this.playerControl.下丝丁一不丑专丆丝(丑丒业丘丑东丕世丅:  true);
        if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
            goto label_94;
        }
        
        if(this.且丌且万与三丙专丐 == false)
        {
            goto label_61;
        }
        
        if(this.playerControl.playerGameObject.transform != null)
        {
            goto label_104;
        }
        
        goto label_64;
        label_61:
        if(this.playerControl.丘丂三东丁且丙世七() != false)
        {
                if(this.playerControl.万丘丏丐且丝一上丏() == false)
        {
            goto label_70;
        }
        
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_73;
        }
        
        }
        
        label_70:
        UnityEngine.Quaternion val_22 = this.playerControl.playerGameObject.transform.localRotation;
        UnityEngine.Quaternion val_28 = this.playerControl.playerGameObject.transform.localRotation;
        val_28.y = val_28.y + PlayerAnimationWrapper.丁七丏丏且专丞不三;
        label_556:
        UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.Euler(x:  UnityEngine.Mathf.MoveTowardsAngle(current:  val_22.x, target:  val_22.x + PlayerAnimationWrapper.上丛丆丛丝丙专丙专, maxDelta:  UnityEngine.Time.deltaTime * 180f), y:  UnityEngine.Mathf.MoveTowardsAngle(current:  val_28.y, target:  val_28.y, maxDelta:  UnityEngine.Time.deltaTime * 180f), z:  0f);
        this.playerControl.playerGameObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w};
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_94;
        }
        
        }
        
        UnityEngine.Quaternion val_36 = this.playerControl.playerGameObject.transform.localRotation;
        float val_251 = -360f;
        val_251 = val_36.x + val_251;
        val_36.x = (val_36.x > 180f) ? (val_251) : val_36.x;
        val_251 = val_36.x + 360f;
        UnityEngine.Transform val_39 = this.playerControl.playerGameObject.transform;
        UnityEngine.Quaternion val_40 = UnityEngine.Quaternion.Euler(x:  UnityEngine.Mathf.Clamp(value:  (val_36.x < 0) ? (val_251) : (val_36.x), min:  -55f, max:  55f), y:  0f, z:  0f);
        if(val_39 != null)
        {
            goto label_104;
        }
        
        label_64:
        label_104:
        val_39.localRotation = new UnityEngine.Quaternion() {x = val_40.x, y = val_40.y, z = val_40.z, w = val_40.w};
        label_94:
        if(this.playerControl._moveC.丗丞业丐丛三上丄丕() != false)
        {
                this.lastShootingTime = UnityEngine.Time.realtimeSinceStartup;
        }
        
        float val_43 = UnityEngine.Time.realtimeSinceStartup;
        UnityEngine.Quaternion val_45 = this.playerControl.丞丗丄丂丆业丈丑业.FPSplayerObject.transform.rotation;
        UnityEngine.Vector3 val_47 = this.playerControl.transform.position;
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z}, b:  new UnityEngine.Vector3() {x = this.丒与丘专丞东丑丘丘, y = V13.16B, z = PlayerAnimationWrapper.丁七丏丏且专丞不三});
        this.<丂丝世丐且丄丒三丘>k__BackingField = val_48;
        mem[1152921535902977280] = val_48.y;
        mem[1152921535902977284] = val_48.z;
        if(this.上丘丂丌丑东上且丗 != false)
        {
                PlatformController[] val_49 = PlatformsList.丄丘七三上丕世丞业.platforms + ((this.世丟丁丝丌丅且且丑) << 3);
            UnityEngine.Vector3 val_50 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (this.世丟丁丝丌丅且且丑) << 3) + 32] + 48.position;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z}, b:  new UnityEngine.Vector3() {x = this.丕丐丄三丑丗丛专万, y = this.丒与丘专丞东丑丘丘, z = val_43});
            UnityEngine.Vector3 val_52 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z}, b:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z});
            this.<丂丝世丐且丄丒三丘>k__BackingField = val_52;
            mem[1152921535902977280] = val_52.y;
            mem[1152921535902977284] = val_52.z;
        }
        
        if(this.currentState != 4)
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_130;
        }
        
        }
        
        }
        
        mem2[0] = 0;
        mem[1152921535902977284] = 0;
        label_130:
        val_254 = 1152921504850403328;
        float val_55 = val_43 - this.lastShootingTime;
        UnityEngine.Vector2 val_56 = UnityEngine.Vector2.zero;
        float val_253 = 360f;
        float val_252 = this.三丐上丑一丗丛上一;
        val_252 = val_45.y - val_252;
        float val_254 = this.丑丗且丙丑丂丐东丌;
        val_253 = val_252 + val_253;
        val_252 = (val_252 < 0) ? (val_253) : (val_252);
        val_253 = val_252 + (-360f);
        if(this.currentState == 8)
        {
                if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                if((this.playerControl.丘丂三东丁且丙世七() == false) || (this.playerControl.万丘丏丐且丝一上丏() == true))
        {
            goto label_152;
        }
        
        }
        
        }
        
        if(this.currentState != 11)
        {
            goto label_140;
        }
        
        label_152:
        val_254 = val_254 + ((val_252 > 270f) ? (val_253) : (val_252));
        goto label_153;
        label_140:
        if((((this.<丂丝世丐且丄丒三丘>k__BackingField) != 0f) || ((this.<丂丝世丐且丄丒三丘>k__BackingField) != 0f)) || ((this.<丂丝世丐且丄丒三丘>k__BackingField) != 0f))
        {
            goto label_149;
        }
        
        if(this.currentState == 0)
        {
            goto label_145;
        }
        
        if(val_55 <= this.agressiveRotationCooldown)
        {
            goto label_149;
        }
        
        if(this.currentState == 1)
        {
            goto label_147;
        }
        
        goto label_149;
        label_145:
        if(val_55 <= this.agressiveRotationCooldown)
        {
            goto label_149;
        }
        
        label_147:
        if(this.playerControl._moveC.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_152;
        }
        
        label_149:
        if(val_254 != 0f)
        {
                this.丛万不丑丙丏丐丕一 = true;
        }
        
        label_153:
        if(this.丛万不丑丙丏丐丕一 == false)
        {
            goto label_154;
        }
        
        label_180:
        if((this.丛万不丑丙丏丐丕一 == false) || ((System.Math.Abs(UnityEngine.Mathf.MoveTowards(current:  UnityEngine.Mathf.Clamp(value:  val_254, min:  -this.maxFreeRotation, max:  this.maxFreeRotation), target:  0f, maxDelta:  this.freeRotationReturnSpeed * UnityEngine.Time.deltaTime))) >= 0))
        {
            goto label_164;
        }
        
        this.丛万不丑丙丏丐丕一 = false;
        goto label_164;
        label_154:
        if(this.currentState != 8)
        {
                if(this.currentState != 11)
        {
            goto label_165;
        }
        
        }
        
        label_164:
        if((this.playerControl.下上且丏世丈丞丏东() == false) || (this.playerControl.丌且下丕下下丌万丞 == false))
        {
            goto label_173;
        }
        
        if(this.playerControl.丘丂三东丁且丙世七() != false)
        {
                if(this.playerControl.万丘丏丐且丝一上丏() == false)
        {
            goto label_173;
        }
        
        }
        
        if(this.丆上丐丌七丄丞专丛 == false)
        {
            goto label_174;
        }
        
        goto label_175;
        label_173:
        this.丐丘上丛万丟丈丞丞 = 0f;
        goto label_176;
        label_165:
        if(System.Math.Abs(val_254) <= this.maxFreeRotation)
        {
            goto label_180;
        }
        
        this.丛万不丑丙丏丐丕一 = true;
        goto label_180;
        label_174:
        UnityEngine.Quaternion val_69 = this.playerControl._moveC.东三上专丅东业丛丐().transform.rotation;
        float val_70 = val_69.y - val_45.y;
        this.丄丏丏丌丏丐丁三丛 = val_70;
        label_175:
        this.丐丘上丛万丟丈丞丞 = UnityEngine.Mathf.MoveTowardsAngle(current:  this.丐丘上丛万丟丈丞丞, target:  val_70, maxDelta:  UnityEngine.Time.deltaTime * val_253);
        label_176:
        if((val_254 == 0f) && (this.丑丗且丙丑丂丐东丌 == 0f))
        {
                if((this.playerControl.下上且丏世丈丞丏东() != true) && (this.currentState != 11))
        {
                if((this.丆上丐丌七丄丞专丛 == false) || (this.playerControl.丌且下丕下下丌万丞 == false))
        {
            goto label_194;
        }
        
        }
        
        }
        
        UnityEngine.Quaternion val_75 = this.rootBone.localRotation;
        UnityEngine.Quaternion val_76 = this.rootBone.localRotation;
        UnityEngine.Quaternion val_78 = UnityEngine.Quaternion.Euler(x:  val_75.x, y:  this.丐丘上丛万丟丈丞丞 - val_254, z:  val_76.z);
        this.rootBone.localRotation = new UnityEngine.Quaternion() {x = val_78.x, y = val_78.y, z = val_78.z, w = val_78.w};
        val_255 = 0f;
        if(this.currentState != 8)
        {
                var val_79 = (this.currentState == 11) ? 0f : (val_254);
            if((val_55 > this.agressiveRotationCooldown) && (this.currentState != 11))
        {
                val_255 = val_254;
            if(this.playerControl._moveC.丄丁丑丞丅一三丌丆 != true)
        {
                float val_257 = this.torsoRotationMultiplier;
            val_255 = val_254 * val_257;
        }
        
        }
        
        }
        
        if(this.spineBones == null)
        {
                if(this.spineBones == null)
        {
            goto label_208;
        }
        
        }
        
        int val_258 = this.spineBones.Length;
        val_257 = val_255 * this.spineRotationDifK;
        var val_81 = (this.spineBones.Length < 0) ? (this.spineBones.Length + 1) : this.spineBones.Length;
        val_81 = val_81 >> 1;
        val_258 = val_81 * val_258;
        val_258 = val_258 - 1;
        goto label_224;
        label_227:
        UnityEngine.Transform val_259 = this.spineBones[0];
        if(this.playerControl._moveC.playerBodyRenderer.isVisible != true)
        {
                if(this.playerControl.丌且下丕下下丌万丞 == false)
        {
            goto label_225;
        }
        
        }
        
        UnityEngine.Quaternion val_85 = val_259.localRotation;
        label_225:
        float val_260 = 0f;
        val_260 = (val_257 / (float)val_258) * val_260;
        val_260 = ((val_255 - val_257) / (float)this.spineBones.Length) + val_260;
        UnityEngine.Quaternion val_87 = val_259.localRotation;
        UnityEngine.Quaternion val_88 = val_259.localRotation;
        UnityEngine.Quaternion val_90 = UnityEngine.Quaternion.Euler(x:  ((0 == 0) ? (val_260) : (-val_260)) + val_85.x, y:  val_87.y, z:  val_88.z);
        val_259.localRotation = new UnityEngine.Quaternion() {x = val_90.x, y = val_90.y, z = val_90.z, w = val_90.w};
        label_224:
        if(0 < this.spineBones.Length)
        {
            goto label_227;
        }
        
        label_194:
        if(((this.<丂丝世丐且丄丒三丘>k__BackingField) != 0f) || ((this.<丂丝世丐且丄丒三丘>k__BackingField) != 0f))
        {
            goto label_232;
        }
        
        float val_261 = this.三丐上丑一丗丛上一;
        float val_262 = val_45.y;
        val_261 = val_261 - this.丑丗且丙丑丂丐东丌;
        val_262 = val_262 - val_254;
        float val_91 = val_262 - val_261;
        if(System.Math.Abs(val_91) <= 0.1f)
        {
            goto label_232;
        }
        
        float val_264 = val_253;
        float val_265 = -360f;
        val_264 = val_91 + val_264;
        float val_92 = (val_91 < 0) ? (val_264) : (val_91);
        val_265 = val_92 + val_265;
        val_91 = (val_92 > 270f) ? (val_265) : (val_92);
        if((val_55 > this.agressiveRotationCooldown) && (this.currentState == 0))
        {
                if(this.playerControl._moveC.丄丁丑丞丅一三丌丆 == false)
        {
            goto label_237;
        }
        
        }
        
        float val_266 = 45f;
        val_266 = val_91 / val_266;
        val_266 = val_266 + this.不丁下丕丌丈不丕丁;
        float val_93 = UnityEngine.Mathf.Clamp(value:  val_266, min:  -1f, max:  1f);
        float val_94 = UnityEngine.Time.deltaTime;
        val_94 = System.Math.Abs(val_91) / val_94;
        val_94 = val_94 * this.rotationMoveSpeedModifier;
        val_256 = UnityEngine.Mathf.Clamp(value:  val_94, min:  0f, max:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
        val_257 = 0f;
        goto label_558;
        label_232:
        if((this.currentState == 3) || (this.专丟丈七丘丑丁世业 != 3))
        {
            goto label_244;
        }
        
        val_256 = 0f;
        val_257 = 0f;
        goto label_558;
        label_244:
        if(UnityEngine.Time.deltaTime <= 0f)
        {
            goto label_246;
        }
        
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_252;
        }
        
        }
        
        float val_99 = UnityEngine.Time.deltaTime;
        val_99 = 0f / val_99;
        goto label_253;
        label_252:
        float val_100 = UnityEngine.Time.deltaTime;
        val_100 = 0f / val_100;
        float val_102 = UnityEngine.Mathf.Clamp(value:  val_100, min:  0f, max:  FirstPersonControlSharp.三丏丅丐丏与下世丗 * this.playerControl.万丟丗且专丁丟与丏);
        label_253:
        label_246:
        if(this.currentState == 8)
        {
                UnityEngine.Vector2 val_103 = new UnityEngine.Vector2(x:  0f, y:  0f);
            UnityEngine.Vector2 val_104 = val_103.x.normalized;
        }
        else
        {
                UnityEngine.Quaternion val_106 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_45.y + val_254);
            UnityEngine.Vector2 val_107 = new UnityEngine.Vector2(x:  this.<丂丝世丐且丄丒三丘>k__BackingField, y:  val_106.y);
            UnityEngine.Vector2 val_108 = val_107.x.normalized;
            UnityEngine.Vector3 val_109 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_108.x, y = val_108.y});
            UnityEngine.Vector3 val_110 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_106.x, y = val_106.y, z = val_106.z, w = val_106.w}, point:  new UnityEngine.Vector3() {x = val_109.x, y = val_109.y, z = val_109.z});
            UnityEngine.Vector2 val_111 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_110.x, y = val_110.y, z = val_110.z});
        }
        
        float val_112 = this.七东丞业且不丌丝丈(专丞丅业丆丐丕不七:  this.currentState);
        val_256 = 0f;
        if(val_112 <= 0f)
        {
            goto label_265;
        }
        
        val_258 = val_102 / val_112;
        if((val_258 >= 0) || (this.playerControl.丌且下丕下下丌万丞 == true))
        {
            goto label_268;
        }
        
        goto label_271;
        label_265:
        val_257 = 0f;
        goto label_558;
        label_268:
        if(this.playerControl == null)
        {
            goto label_273;
        }
        
        var val_113 = (this.playerControl.丌且下丕下下丌万丞 == true) ? 1f : 10000f;
        goto label_274;
        label_273:
        if(this.playerControl == null)
        {
            goto label_275;
        }
        
        label_274:
        label_557:
        val_256 = 0f;
        label_271:
        UnityEngine.Vector2 val_118 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_111.x, y = val_111.y}, d:  UnityEngine.Mathf.Clamp(value:  val_258 * ((this.playerControl.丌且下丕下下丌万丞 == true) ? 1f : 10000f), min:  (this.playerControl.丌且下丕下下丌万丞 == true) ? 0f : 0.3f, max:  this.playerControl.万丟丗且专丁丟与丏));
        if((((this.playerControl.丌且下丕下下丌万丞 != false) && (this.上丘丂丌丑东上且丗 != false)) && (this.playerControl.不丄丒七业丏丙丕三 < 0)) && (this.currentState <= 1))
        {
                if(this.playerControl._moveC.与丏下丝万上三丛不() != true)
        {
                val_256 = 0f;
            UnityEngine.Vector2 val_120 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_118.x, y = val_118.y}, d:  0f);
        }
        
        }
        
        label_558:
        float val_124 = UnityEngine.Mathf.MoveTowards(current:  this.不丁下丕丌丈不丕丁, target:  0f, maxDelta:  ((this.playerControl.丌且下丕下下丌万丞 == false) ? this.networkAnimationsLerpSpeed : this.rotationAnimationsLerpSpeed) * UnityEngine.Time.deltaTime);
        val_259 = this.playerControl;
        if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                val_259 = 1152921505077186560;
            if(((JoystickController.丗三丄与丂丟丌专东 != 0) && (JoystickController.丗三丄与丂丟丌专东.value == 0f)) && ((JoystickController.丗三丄与丂丟丌专东 + 196) == 0f))
        {
            
        }
        
        }
        
        UnityEngine.Vector2 val_128 = UnityEngine.Vector2.MoveTowards(current:  new UnityEngine.Vector2() {x = this.丘丝丘专业专丆丈且, y = this.不丁下丕丌丈不丕丁}, target:  new UnityEngine.Vector2() {x = val_120.x, y = val_120.y}, maxDistanceDelta:  this.movingAnimationsLerpSpeed * UnityEngine.Time.deltaTime);
        val_260 = val_128.y;
        this.丘丝丘专业专丆丈且 = val_128;
        mem[1152921535902976880] = val_260;
        this.丙丂上丛丁丝丐丐丆 = val_258;
        this.三丐上丑一丗丛上一 = val_45.y;
        UnityEngine.Vector3 val_130 = this.playerControl.transform.position;
        this.丒与丘专丞东丑丘丘 = val_130;
        mem[1152921535902976916] = val_130.y;
        mem[1152921535902976920] = val_130.z;
        this.丑丗且丙丑丂丐东丌 = val_254;
        this.不丁下丕丌丈不丕丁 = val_124;
        this.丆上丐丌七丄丞专丛 = this.playerControl.下上且丏世丈丞丏东();
        if(this.上丘丂丌丑东上且丗 != false)
        {
                val_254 = this.世丟丁丝丌丅且且丑;
            PlatformController[] val_133 = PlatformsList.丄丘七三上丕世丞业.platforms + ((this.世丟丁丝丌丅且且丑) << 3);
            UnityEngine.Vector3 val_134 = mem[(PlatformsList.丄丘七三上丕世丞业.platforms + (this.世丟丁丝丌丅且且丑) << 3) + 32] + 48.position;
            this.丕丐丄三丑丗丛专万 = val_134;
            mem[1152921535902976904] = val_134.y;
            mem[1152921535902976908] = val_134.z;
        }
        
        this.<丙丐下且丟丕丞丂上>k__BackingField = val_102;
        if(this.playerControl.丂丕丁且世丗丕丛专() != false)
        {
                if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
            goto label_349;
        }
        
        }
        
        if(this.一七丟丘丕且一丁丘() == false)
        {
            goto label_326;
        }
        
        this.丘丅下丗丆丟丝丒不(一下丙丆丗与丆丗丏:  new UnityEngine.Vector2() {x = val_128.x, y = val_260});
        goto label_349;
        label_326:
        val_259 = 1152921505066536960;
        if(GameConnect.丛专丌且丕不专丈下() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() == false)
        {
            goto label_338;
        }
        
        }
        
        if(this.playerControl.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟 == 0)
        {
            goto label_338;
        }
        
        this.playerControl.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟.isGrounded = (this.丈不丁万且丐丂丐下 == true) ? 1 : 0;
        float val_268 = val_102;
        val_268 = val_268 * ((GameConnect.丛专丌且丕不专丈下() != true) ? 0.45f : 1f);
        this.playerControl.丞丗丄丂丆业丈丑业.丛丞七丏丑业丂丕丟.VelocityMagnitude = val_268;
        goto label_349;
        label_338:
        if(this.animator.isInitialized == false)
        {
            goto label_349;
        }
        
        this.animator.SetFloat(id:  this.丆与丄丈丑丑万一七, value:  val_102);
        if(GameConnect.丁丁丗丐东丄丞一丛() != false)
        {
                this.animator.SetFloat(id:  this.专三万丈丅丌丄丏丘, value:  this.playerControl.一与东三世丘丞丙丐);
            val_259 = this.playerControl;
            if(this.animator != null)
        {
            goto label_358;
        }
        
        }
        else
        {
                this.animator.SetFloat(id:  this.专三万丈丅丌丄丏丘, value:  val_128.x);
        }
        
        label_358:
        this.animator.SetFloat(id:  this.不丌丁丛丄东不丄丞, value:  val_260);
        val_254 = this.丙三且下世丆丕且丟;
        this.animator.SetBool(id:  val_254, value:  false);
        this.animator.SetBool(id:  this.丏丂下三丒专丕业丈, value:  false);
        this.animator.SetFloat(id:  this.丝丌专万丐丞丐下不, value:  val_124);
        this.animator.SetFloat(id:  this.丈且丒丘丙丞丕丅上, value:  val_256);
        label_349:
        if((this.playerControl.丘丂三东丁且丙世七() != false) && (this.playerControl.丌且下丕下下丌万丞 != false))
        {
                this.playerControl.七丈且丘三万且丏上(下丞丅丗丌一丛丗丞:  val_260, 专丞丅业丆丐丕不七:  this.currentState);
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 == false)
        {
            goto label_371;
        }
        
        if(this.playerControl.丘丂三东丁且丙世七() == false)
        {
            goto label_441;
        }
        
        UnityEngine.Vector3 val_148 = this.playerControl.playerCamera.transform.position;
        UnityEngine.Vector3 val_150 = this.playerControl.playerCamera.transform.forward;
        UnityEngine.Vector3 val_151 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_150.x, y = val_150.y, z = val_150.z}, d:  1000f);
        UnityEngine.Vector3 val_152 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_148.x, y = val_148.y, z = val_148.z}, b:  new UnityEngine.Vector3() {x = val_151.x, y = val_151.y, z = val_151.z});
        UnityEngine.Vector3 val_153 = this.headBone.position;
        UnityEngine.Vector3 val_154 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_152.x, y = val_152.y, z = val_152.z}, b:  new UnityEngine.Vector3() {x = val_153.x, y = val_153.y, z = val_153.z});
        UnityEngine.Quaternion val_155 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_154.x, y = val_154.y, z = val_154.z});
        UnityEngine.Quaternion val_156 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  -90f);
        UnityEngine.Quaternion val_157 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_155.x, y = val_155.y, z = val_155.z, w = val_155.w}, rhs:  new UnityEngine.Quaternion() {x = val_156.x, y = val_156.y, z = val_156.z, w = val_156.w});
        this.headBone.rotation = new UnityEngine.Quaternion() {x = val_157.x, y = val_157.y, z = val_157.z, w = val_157.w};
        UnityEngine.Quaternion val_158 = this.headBone.localRotation;
        val_257 = 180f;
        float val_269 = -360f;
        val_269 = val_158.x + val_269;
        UnityEngine.Quaternion val_161 = this.headBone.localRotation;
        float val_270 = this.三丞丂丈世丂丅业丌;
        val_270 = val_161.y + val_270;
        float val_271 = -360f;
        val_271 = val_270 + val_271;
        UnityEngine.Quaternion val_164 = UnityEngine.Quaternion.Euler(x:  0f, y:  UnityEngine.Mathf.Clamp(value:  (val_270 > val_257) ? (val_271) : (val_270), min:  -this.maxHeadRotationUp, max:  this.maxHeadRotationDown), z:  0f);
        val_256 = val_164.w;
        UnityEngine.Quaternion val_165 = UnityEngine.Quaternion.Euler(x:  UnityEngine.Mathf.Clamp(value:  (val_158.x > val_257) ? (val_269) : val_158.x, min:  -80f, max:  80f), y:  0f, z:  0f);
        UnityEngine.Quaternion val_166 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_164.x, y = val_164.y, z = val_164.z, w = val_256}, rhs:  new UnityEngine.Quaternion() {x = val_165.x, y = val_165.y, z = val_165.z, w = val_165.w});
        this.headBone.localRotation = new UnityEngine.Quaternion() {x = val_166.x, y = val_166.y, z = val_166.z, w = val_166.w};
        goto label_441;
        label_371:
        if(this.currentState == 7)
        {
            goto label_412;
        }
        
        var val_272 = -4294967296;
        val_272 = val_272 + ((this.spineBones.Length) << 32);
        UnityEngine.Quaternion val_168 = this.spineBones[val_272 >> 32].rotation;
        UnityEngine.Quaternion val_169 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_168.x, y = val_168.y, z = val_168.z, w = val_168.w});
        UnityEngine.Quaternion val_170 = this.rootBone.rotation;
        UnityEngine.Quaternion val_171 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_169.x, y = val_169.y, z = val_169.z, w = val_169.w}, rhs:  new UnityEngine.Quaternion() {x = val_170.x, y = val_170.y, z = val_170.z, w = val_170.w});
        float val_173 = 270f - val_171.y;
        UnityEngine.Quaternion val_174 = this.playerControl.playerGameObject.transform.localRotation;
        float val_274 = val_174.x;
        val_173 = val_274 - val_173;
        if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_411;
        }
        
        }
        
        label_411:
        val_274 = val_173 + 12f;
        if(val_274 > 180f)
        {
                val_274 = val_274 + (-360f);
        }
        
        label_412:
        float val_276 = this.maxHeadRotationDown;
        val_257 = this.maxHeadRotationUp;
        float val_177 = UnityEngine.Mathf.Clamp(value:  val_274, min:  -val_257, max:  val_276);
        float val_275 = val_253;
        val_275 = val_177 + val_275;
        val_276 = (val_177 < 0) ? (val_275) : (val_177);
        float val_180 = UnityEngine.Mathf.MoveTowardsAngle(current:  this.业且下业丞不东丌与, target:  val_276, maxDelta:  UnityEngine.Time.deltaTime * 180f);
        this.业且下业丞不东丌与 = val_180;
        UnityEngine.Quaternion val_181 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_180, z:  0f);
        val_256 = val_181.w;
        UnityEngine.Quaternion val_182 = UnityEngine.Quaternion.Euler(x:  -val_254, y:  0f, z:  0f);
        UnityEngine.Quaternion val_183 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_181.x, y = val_181.y, z = val_181.z, w = val_256}, rhs:  new UnityEngine.Quaternion() {x = val_182.x, y = val_182.y, z = val_182.z, w = val_182.w});
        this.headBone.localRotation = new UnityEngine.Quaternion() {x = val_183.x, y = val_183.y, z = val_183.z, w = val_183.w};
        if(this.playerControl._moveC.七丕丞丞丗专上丝丘 != false)
        {
                UnityEngine.Transform val_184 = this.playerControl._moveC.bearHeadColliderPivot;
        }
        
        if((this.playerControl._moveC.东丗丒丝丐且丞丄丏 == false) || (this.playerControl._moveC.丑丝丂丗丝丛与不七 == 0))
        {
            goto label_432;
        }
        
        if(this.playerControl._moveC.丑丝丂丗丝丛与不七 != null)
        {
            goto label_436;
        }
        
        goto label_436;
        label_432:
        label_436:
        if(mem[this.playerControl._moveC.headColliderPivot] != 0)
        {
                UnityEngine.Vector3 val_188 = mem[this.playerControl._moveC.headColliderPivot].position;
            this.playerControl._moveC.headCollider.transform.position = new UnityEngine.Vector3() {x = val_188.x, y = val_188.y, z = val_188.z};
            UnityEngine.Quaternion val_190 = mem[this.playerControl._moveC.headColliderPivot].rotation;
            this.playerControl._moveC.headCollider.transform.rotation = new UnityEngine.Quaternion() {x = val_190.x, y = val_190.y, z = val_190.z, w = val_190.w};
        }
        
        label_441:
        val_265 = this.<丂丝世丐且丄丒三丘>k__BackingField;
        val_266 = val_260;
        this.playerControl.丗丙东专世万丌丝丛(业丘丆丟下一丛丅丒:  new UnityEngine.Vector3() {x = val_265, y = val_190.y, z = val_190.z}, 且丝丒丈丐东丛丝丞:  val_266, 专丞丅业丆丐丕不七:  this.currentState);
        if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                if(this.playerControl.丘丂三东丁且丙世七() == false)
        {
            goto label_477;
        }
        
        }
        
        if(this.weaponPoint == 0)
        {
            goto label_477;
        }
        
        var val_277 = -4294967296;
        val_277 = val_277 + ((this.spineBones.Length) << 32);
        UnityEngine.Transform val_278 = this.spineBones[val_277 >> 32];
        UnityEngine.Vector3 val_194 = val_278.position;
        val_264 = val_194.y;
        val_265 = val_194.x;
        val_267 = val_264;
        val_268 = val_194.z;
        this.weaponPoint.position = new UnityEngine.Vector3() {x = val_265, y = val_267, z = val_268};
        if(this.playerControl.丘丂三东丁且丙世七() != false)
        {
                if(this.playerControl.万丘丏丐且丝一上丏() == false)
        {
            goto label_469;
        }
        
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                UnityEngine.Quaternion val_197 = val_278.rotation;
            val_264 = val_197.y;
            val_260 = val_197.w;
            val_265 = val_197.x;
            val_267 = val_264;
            val_268 = val_197.z;
            val_266 = val_260;
            this.weaponPoint.rotation = new UnityEngine.Quaternion() {x = val_265, y = val_267, z = val_268, w = val_266};
        }
        
        label_469:
        if(this.playerControl.丘丂三东丁且丙世七() != false)
        {
                if(this.playerControl.万丘丏丐且丝一上丏() == false)
        {
            goto label_477;
        }
        
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                UnityEngine.Quaternion val_200 = this.weaponPoint.localRotation;
            UnityEngine.Quaternion val_201 = this.weaponPoint.localRotation;
            UnityEngine.Quaternion val_202 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_200.y, z:  val_201.z);
            UnityEngine.Quaternion val_203 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  90f);
            UnityEngine.Quaternion val_204 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_202.x, y = val_202.y, z = val_202.z, w = val_202.w}, rhs:  new UnityEngine.Quaternion() {x = val_203.x, y = val_203.y, z = val_203.z, w = val_203.w});
            val_264 = val_204.y;
            val_260 = val_204.w;
            val_265 = val_204.x;
            this.weaponPoint.localRotation = new UnityEngine.Quaternion() {x = val_265, y = val_264, z = val_204.z, w = val_260};
        }
        
        label_477:
        this.一世丐丐不丝一丄丆();
        if(this.playerControl.丘丂三东丁且丙世七() != true)
        {
                if(this.playerControl.丌且下丕下下丌万丞 == true)
        {
            goto label_565;
        }
        
        }
        
        if(this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞 == 0)
        {
            goto label_565;
        }
        
        if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_497;
        }
        
        }
        
        this.丞丐丑下丕上丅不三();
        label_497:
        if((this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.spineBones == null) || (this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.spineBones.Length != this.spineBones.Length))
        {
            goto label_507;
        }
        
        val_269 = 0;
        goto label_508;
        label_531:
        UnityEngine.Transform val_279 = this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.spineBones[0];
        if(this.spineBones[0] != 0)
        {
                if(val_279 != 0)
        {
                UnityEngine.Vector3 val_211 = this.spineBones[0].position;
            val_279.position = new UnityEngine.Vector3() {x = val_211.x, y = val_211.y, z = val_211.z};
            UnityEngine.Quaternion val_212 = this.spineBones[0].rotation;
            val_264 = val_212.y;
            val_260 = val_212.w;
            val_265 = val_212.x;
            val_279.rotation = new UnityEngine.Quaternion() {x = val_265, y = val_264, z = val_212.z, w = val_260};
        }
        
        }
        
        val_269 = 1;
        label_508:
        if(val_269 < this.spineBones.Length)
        {
            goto label_531;
        }
        
        label_507:
        List.Enumerator<T> val_213 = this.playerControl._moveC.东丄丑丈七丛丁丄丝.GetEnumerator();
        val_254 = 1152921535902856512;
        label_545:
        if((1231346496 & 1) == 0)
        {
            goto label_535;
        }
        
        string val_215 = val_107.x.丐丏七丌丕丗业且上();
        if(((this.playerControl.不丕与下丄丟丕丄丛() == true) || (this.playerControl._moveC.丘七业丒丐世丂丅丒() <= 0f)) || (val_215 == 0))
        {
            goto label_545;
        }
        
        val_215.业丐丌丅丒丆丟丟丄();
        goto label_545;
        label_535:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_565;
        label_73:
        UnityEngine.Transform val_219 = this.playerControl.playerGameObject.transform;
        UnityEngine.Quaternion val_221 = this.playerControl.playerGameObject.transform.localRotation;
        float val_224 = UnityEngine.Mathf.MoveTowardsAngle(current:  val_221.x, target:  val_221.x, maxDelta:  UnityEngine.Time.deltaTime * 180f);
        goto label_556;
        label_275:
        var val_225 = (this.playerControl.丌且下丕下下丌万丞 == true) ? 0f : 0.3f;
        if(this.playerControl != null)
        {
            goto label_557;
        }
        
        label_208:
        label_237:
        var val_226 = (val_258 < 0) ? 1 : 0;
        var val_227 = (val_258 > 0f) ? 1 : 0;
        goto label_558;
        label_565:
        this.丗丞万不上丁丘丄丑 = 0f;
        if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                if(this.playerControl.一丆世业上丄专下丟() != false)
        {
                this.丏丈丈一丌丐丒丟丕();
            this.丝丕丟万丄丄丛丆丗();
        }
        
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_580;
        }
        
        }
        
        if((this.playerControl.丌且下丕下下丌万丞 != false) && (this.FPSCamContainer != 0))
        {
                if(this.playerControl.丐丂丕丂丑三丑丒一 != false)
        {
                var val_232 = (this.playerControl.下丅丂丘丏丟世且丐 == true) ? 0f : 0.5f;
        }
        else
        {
                val_257 = 0f;
        }
        
            float val_233 = 0.4f - val_257;
            UnityEngine.Vector3 val_234 = this.FPSCamContainer.localPosition;
            UnityEngine.Vector3 val_237 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_234.x, y = val_234.y, z = val_234.z}, target:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, maxDistanceDelta:  UnityEngine.Time.deltaTime * 4f);
            this.FPSCamContainer.localPosition = new UnityEngine.Vector3() {x = val_237.x, y = val_237.y, z = val_237.z};
            float val_238 = 0f - val_257;
            UnityEngine.Vector3 val_239 = this.FPSGameObjectPosContainer.localPosition;
            val_260 = 0f;
            val_256 = val_239.z;
            UnityEngine.Vector3 val_242 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_239.x, y = val_239.y, z = val_256}, target:  new UnityEngine.Vector3() {x = 0f, y = val_260, z = 0f}, maxDistanceDelta:  UnityEngine.Time.deltaTime * 4f);
            val_264 = val_242.y;
            this.FPSGameObjectPosContainer.localPosition = new UnityEngine.Vector3() {x = val_242.x, y = val_264, z = val_242.z};
        }
        
        label_580:
        if(GameConnect.丝丆世丕丂丄万东且() != true)
        {
                if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_598;
        }
        
        }
        
        if(this.playerControl.丌且下丕下下丌万丞 != true)
        {
                this.丗世万丗上丆且不下(丙不专下丟与世业万:  (((double)0f > 0.01) ? 1 : 0) | ((val_124 != 0f) ? 1 : 0));
        }
        
        label_598:
        if(this.playerControl.丌且下丕下下丌万丞 == false)
        {
                return;
        }
        
        this.丗丆且万丑三丂一丈 = this.playerControl._moveC.且丂一丁丆丒与丁业();
    }
    private void 丞丐丑下丕上丅不三()
    {
        UnityEngine.Transform val_16;
        UnityEngine.Transform val_2 = this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.leftBone.parent;
        UnityEngine.Transform val_16 = this.playerControl.丞丗丄丂丆业丈丑业.armsBonesForRoyalAvatar[0];
        if(this.playerControl.不丕与下丄丟丕丄丛() != false)
        {
                if(val_2 != val_16)
        {
                this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.leftBone.parent = this.playerControl.丞丗丄丂丆业丈丑业.armsBonesForRoyalAvatar[0];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.leftBone.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.Euler(x:  90f, y:  0f, z:  0f);
            this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.leftBone.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        
            val_16 = this.playerControl.丞丗丄丂丆业丈丑业.armsBonesForRoyalAvatar[1];
            if(this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.rightBone.parent == val_16)
        {
                return;
        }
        
            this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.rightBone.parent = this.playerControl.丞丗丄丂丆业丈丑业.armsBonesForRoyalAvatar[1];
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.rightBone.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.rightBone.localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
            return;
        }
        
        if(val_2 == val_16.parent)
        {
                this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.leftBone.parent = this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.transform;
        }
        
        val_16 = this.playerControl.丞丗丄丂丆业丈丑业.armsBonesForRoyalAvatar[1].parent;
        if(this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.rightBone.parent != val_16)
        {
                return;
        }
        
        this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.rightBone.parent = this.playerControl.丞丗丄丂丆业丈丑业.丈丈丒且丕丕东丙丞.transform;
    }
    internal void 一世丐丐不丝一丄丆()
    {
        UnityEngine.Transform val_18;
        UnityEngine.Object val_19;
        if(this.playerControl == 0)
        {
                return;
        }
        
        if(this.playerControl._moveC == 0)
        {
                return;
        }
        
        val_18 = this.weaponPointNotMine;
        if((GameConnect.丛专丌且丕不专丈下() != true) && (GameConnect.丆丕丒与丂七与下上() != true))
        {
                if(this.playerControl.丌且下丕下下丌万丞 != false)
        {
                if(this.playerControl.丂丕丁且世丗丕丛专() == true)
        {
            goto label_21;
        }
        
        }
        
            if(this.一七丟丘丕且一丁丘() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(this.playerControl.丄丕丗丗七上丕丒万() == false)
        {
            goto label_27;
        }
        
        }
        
        }
        
        }
        
        label_21:
        if(this.FPSPlayerGameObjectContainer != 0)
        {
                val_18 = this.FPSPlayerGameObjectContainer;
        }
        else
        {
                val_18 = this.playerControl.transform;
        }
        
        label_27:
        val_19 = this.playerControl.playerGameObject.transform.parent;
        if(val_19 == val_18)
        {
                return;
        }
        
        this.playerControl.playerGameObject.transform.parent = val_18;
        val_19 = this.weaponPointNotMine;
        if(val_18 != val_19)
        {
                return;
        }
        
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        this.playerControl.playerGameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    private void 丏丈丈一丌丐丒丟丕()
    {
        float val_77;
        float val_78;
        float val_82;
        double val_84;
        var val_85;
        float val_86;
        float val_87;
        float val_88;
        丈且且丞与丄丄丏丗 val_90;
        float val_91;
        if((this.playerControl._moveC.丗丞业丐丛三上丄丕() == false) || (this.丗丆且万丑三丂一丈 == false))
        {
            goto label_4;
        }
        
        mem2[0] = 0;
        this.下丐丏专丙丛下东丂 = UnityEngine.Mathf.Lerp(a:  this.下丐丏专丙丛下东丂, b:  0f, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        val_77 = this.丕丆丒三丞东一七三;
        this.丕丆丒三丞东一七三 = UnityEngine.Mathf.Lerp(a:  this.丕丆丒三丞东一七三, b:  0f, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丛不业丕丐上三丕丏, y = this.丕丆丒三丞东一七三, z = this.weaponLerpToIdleSpeed}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        this.丛不业丕丐上三丕丏 = val_11;
        mem[1152921535906106648] = val_11.y;
        mem[1152921535906106652] = val_11.z;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        val_78 = val_12.y;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.下丏与世丌丛丝七万, y = this.weaponLerpToIdleSpeed, z = this.丛不业丕丐上三丕丏}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_78, z = val_12.z}, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        this.下丏与世丌丛丝七万 = val_15;
        mem[1152921535906106660] = val_15.y;
        mem[1152921535906106664] = val_15.z;
        goto label_83;
        label_4:
        val_82 = this.playerControl.与丌丆下丝下丘丏丗;
        if((val_82 > 0.2f) || (this.playerControl._moveC.丙不丅丕三丂业东丕() == 0))
        {
            goto label_26;
        }
        
        if((this.<丙丐下且丟丕丞丂上>k__BackingField) >= 0)
        {
                if(this.playerControl.下丅丂丘丏丟世且丐 == false)
        {
            goto label_19;
        }
        
        }
        
        this.东丕丗丘不一丗丅专 = 0f;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丛不业丕丐上三丕丏, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        this.丛不业丕丐上三丕丏 = val_21;
        mem[1152921535906106648] = val_21.y;
        mem[1152921535906106652] = val_21.z;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        val_78 = val_22.y;
        val_82 = this.下丏与世丌丛丝七万;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_82, y = V9.16B, z = this.丛不业丕丐上三丕丏}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_78, z = val_22.z}, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        this.下丏与世丌丛丝七万 = val_25;
        mem[1152921535906106660] = val_25.y;
        mem[1152921535906106664] = val_25.z;
        if(this.playerControl._moveC.丙不丅丕三丂业东丕() == 0)
        {
            goto label_26;
        }
        
        WeaponSounds val_28 = this.playerControl._moveC.丙不丅丕三丂业东丕();
        if(val_28.useLegacyIdleAnimation == false)
        {
            goto label_30;
        }
        
        label_26:
        mem2[0] = 0;
        this.下丐丏专丙丛下东丂 = UnityEngine.Mathf.Lerp(a:  this.下丐丏专丙丛下东丂, b:  0f, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        val_77 = this.丕丆丒三丞东一七三;
        label_61:
        this.丕丆丒三丞东一七三 = UnityEngine.Mathf.Lerp(a:  this.丕丆丒三丞东一七三, b:  0f, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        label_83:
        UnityEngine.Vector3 val_75 = this.丛不业丕丐上三丕丏;
        val_75 = val_75 + this.丕丆丒三丞东一七三;
        this.丗丞万不上丁丘丄丑 = val_75;
        this.playerControl._moveC.myWeaponTransform.Rotate(eulers:  new UnityEngine.Vector3() {x = this.丛不业丕丐上三丕丏, y = this.weaponLerpToIdleSpeed, z = this.weaponLerpToIdleSpeed});
        this.playerControl._moveC.myWeaponTransform.Rotate(xAngle:  val_77, yAngle:  0f, zAngle:  0f);
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = this.下丏与世丌丛丝七万, y = val_77, z = this.weaponLerpToIdleSpeed});
        this.playerControl._moveC.myWeaponTransform.localPosition = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
        return;
        label_19:
        WeaponSounds val_36 = this.playerControl._moveC.丙不丅丕三丂业东丕();
        if(val_36.useLegacyWalkAnimation == false)
        {
            goto label_47;
        }
        
        goto label_83;
        label_30:
        if(((double)System.Math.Abs(this.专丕不丝丏不丆丒七 - this.下丐丏专丙丛下东丂)) < 0)
        {
                float val_39 = UnityEngine.Random.Range(min:  this.weaponIdleAnimationMinMoving, max:  this.weaponIdleAnimationMaxMoving);
            val_39 = -((UnityEngine.Mathf.Sign(f:  this.下丐丏专丙丛下东丂)) * val_39);
            this.专丕不丝丏不丆丒七 = val_39;
        }
        
        val_84 = 0.01;
        if(((double)System.Math.Abs(this.东丗专下丅专丂丅世 - this.丕丆丒三丞东一七三)) < 0)
        {
                val_84 = -((UnityEngine.Mathf.Sign(f:  this.丕丆丒三丞东一七三)) * (UnityEngine.Random.Range(min:  this.weaponIdleAnimationMinRotation, max:  this.weaponIdleAnimationMaxRotation)));
            this.东丗专下丅专丂丅世 = val_84;
        }
        
        this.下丐丏专丙丛下东丂 = UnityEngine.Mathf.MoveTowards(current:  this.下丐丏专丙丛下东丂, target:  this.专丕不丝丏不丆丒七, maxDelta:  this.weaponIdleAnimationMoveSpeed * UnityEngine.Time.deltaTime);
        float val_48 = UnityEngine.Mathf.MoveTowards(current:  this.丕丆丒三丞东一七三, target:  this.东丗专下丅专丂丅世, maxDelta:  this.weaponIdleAnimationRotateSpeed * UnityEngine.Time.deltaTime);
        goto label_61;
        label_47:
        mem2[0] = 0;
        this.下丐丏专丙丛下东丂 = UnityEngine.Mathf.Lerp(a:  this.下丐丏专丙丛下东丂, b:  0f, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        this.丕丆丒三丞东一七三 = UnityEngine.Mathf.Lerp(a:  this.丕丆丒三丞东一七三, b:  0f, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
        float val_55 = UnityEngine.Time.deltaTime;
        val_55 = val_55 / this.weaponWalkAnimationDuration;
        val_55 = val_55 * ((this.<丙丐下且丟丕丞丂上>k__BackingField) / 6.5f);
        val_55 = this.东丕丗丘不一丗丅专 + val_55;
        this.东丕丗丘不一丗丅专 = val_55;
        val_85 = 0;
        goto label_64;
        label_82:
        CurveAnimationEntry val_78 = this.weaponWalkAnimationEntries[0];
        float val_79 = this.东丕丗丘不一丗丅专;
        if(val_78 != null)
        {
                val_86 = this.weaponWalkAnimationEntries[0x0][0].curveDelay;
            val_87 = val_86 * this.weaponWalkAnimationDuration;
            val_88 = val_78.curveTime;
        }
        else
        {
                val_86 = 6.606506E-38f;
            float val_80 = this.weaponWalkAnimationDuration;
            val_87 = val_86 * val_80;
            val_88 = 0.curveTime;
        }
        
        val_79 = val_79 - val_87;
        float val_59 = val_78.curveTime;
        val_80 = val_79 / val_88;
        float val_81 = (float)(int)val_80;
        val_88 = val_59 * val_81;
        val_90 = this.weaponWalkAnimationEntries[0x0][0].entryType;
        val_91 = val_79 - val_88;
        if(val_90 == 0)
        {
                if(val_59 < 0)
        {
                val_91 = val_78.curveTime - val_91;
        }
        
            float val_61 = this.weaponWalkAnimationEntries[0x0][0].curve.Evaluate(time:  val_91);
            var val_62 = (this.weaponWalkAnimationEntries[0x0][0].entryAxis == 0) ? (val_61) : 0f;
            val_81 = (this.weaponWalkAnimationEntries[0x0][0].entryAxis == 1) ? (val_61) : 0f;
            var val_63 = (this.weaponWalkAnimationEntries[0x0][0].entryAxis == 2) ? (val_61) : 0f;
            UnityEngine.Vector3 val_66 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丛不业丕丐上三丕丏, y = V11.16B, z = val_87}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
            this.丛不业丕丐上三丕丏 = val_66;
            mem[1152921535906106648] = val_66.y;
            mem[1152921535906106652] = val_66.z;
            val_90 = this.weaponWalkAnimationEntries[0x0][0].entryType;
        }
        
        if(val_90 == 1)
        {
                if(this.playerControl.一与东三世丘丞丙丐 < 0)
        {
                val_91 = val_78.curveTime - val_91;
        }
        
            float val_68 = this.weaponWalkAnimationEntries[0x0][0].curve.Evaluate(time:  val_91);
            var val_69 = (this.weaponWalkAnimationEntries[0x0][0].entryAxis == 0) ? (val_68) : 0f;
            var val_70 = (this.weaponWalkAnimationEntries[0x0][0].entryAxis == 1) ? (val_68) : 0f;
            var val_71 = (this.weaponWalkAnimationEntries[0x0][0].entryAxis == 2) ? (val_68) : 0f;
            UnityEngine.Vector3 val_74 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.下丏与世丌丛丝七万, y = val_87, z = this.丛不业丕丐上三丕丏}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, t:  this.weaponLerpToIdleSpeed * UnityEngine.Time.deltaTime);
            this.下丏与世丌丛丝七万 = val_74;
            mem[1152921535906106660] = val_74.y;
            mem[1152921535906106664] = val_74.z;
        }
        
        val_85 = 1;
        label_64:
        if(val_85 < this.weaponWalkAnimationEntries.Length)
        {
            goto label_82;
        }
        
        goto label_83;
    }
    private void 丝丕丟万丄丄丛丆丗()
    {
        var val_12;
        var val_13;
        UnityEngine.Vector2 val_14;
        var val_15;
        float val_17;
        UnityEngine.Vector2 val_18;
        if(this.playerControl._moveC.丙不丅丕三丂业东丕() == 0)
        {
            goto label_5;
        }
        
        WeaponSounds val_3 = this.playerControl._moveC.丙不丅丕三丂业东丕();
        if(val_3.disableDirectionAnimation == false)
        {
            goto label_9;
        }
        
        label_5:
        this.currentWeaponDirectionRotationZ = 0f;
        return;
        label_9:
        val_12 = null;
        val_12 = null;
        if(JoystickController.丗三丄与丂丟丌专东 != 0)
        {
                val_13 = null;
            val_13 = null;
            val_14 = mem[JoystickController.丗三丄与丂丟丌专东 + 192];
            val_14 = JoystickController.丗三丄与丂丟丌专东.value;
            if(val_14 == 0f)
        {
                val_14 = this.playerControl.一与东三世丘丞丙丐;
            if(val_14 == 0f)
        {
                val_15 = null;
            val_15 = null;
            val_14 = mem[JoystickController.丗三丄与丂丟丌专东 + 196];
            val_14 = JoystickController.丗三丄与丂丟丌专东 + 196;
            if(val_14 == 0f)
        {
                if(val_14 == 0f)
        {
            goto label_26;
        }
        
        }
        
        }
        
        }
        
            val_17 = this.丑七丛丌丁丅七丂丝;
            val_18 = UnityEngine.Mathf.Lerp(a:  val_17, b:  this.playerControl.一与东三世丘丞丙丐, t:  this.weaponDirectionAnimationInertion * UnityEngine.Time.deltaTime);
            this.丑七丛丌丁丅七丂丝 = val_18;
        }
        else
        {
                label_26:
            val_18 = 0f;
            this.丑七丛丌丁丅七丂丝 = 0;
        }
        
        float val_9 = val_18 - this.playerControl.一与东三世丘丞丙丐;
        float val_12 = 0.5f;
        val_9 = val_9 * val_12;
        val_12 = this.weaponDirectionAnimatioMaxAngle * val_9;
        this.currentWeaponDirectionRotationZ = UnityEngine.Mathf.Lerp(a:  this.currentWeaponDirectionRotationZ, b:  val_12, t:  this.weaponDirectionAnimationLerpSpeed * UnityEngine.Time.deltaTime);
    }
    private System.Collections.IEnumerator 万丗丂丟专三丕下丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerAnimationWrapper.丈丆丌丟丏上丛且丞();
    }
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.playerControl.transform.position;
        this.丒与丘专丞东丑丘丘 = val_2;
        mem[1152921535906745492] = val_2.y;
        mem[1152921535906745496] = val_2.z;
        if((this.playerControl != 0) && (this.playerControl.丌且下丕下下丌万丞 != false))
        {
                if(this.animator != 0)
        {
                this.animator.cullingMode = 0;
        }
        
        }
        
        if(this.animator == 0)
        {
                return;
        }
        
        this.defaultAnimatorController = this.animator.runtimeAnimatorController;
    }
    public PlayerAnimationWrapper()
    {
        this.丈不丁万且丐丂丐下 = true;
        this.agressiveRotationCooldown = 3f;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        this.丆丝丝世专万丐且丛 = val_1;
        mem[1152921535906895556] = val_1.y;
        mem[1152921535906895560] = val_1.z;
        mem[1152921535906895564] = val_1.w;
        this.freeRotationReturnSpeed = 240f;
        this.landingHeadMoveSpeed = 270f;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        this.丘丝丘专业专丆丈且 = val_2;
        mem[1152921535906895600] = val_2.y;
        this.movingAnimationsLerpSpeed = 4f;
        this.networkAnimationsLerpSpeed = 4f;
        this.onRealeseJoystickAnimationsLerpSpeed = 6f;
        this.maxFreeRotation = ;
        this.maxHeadRotationDown = ;
        this.maxHeadRotationUp = 45f;
        this.maxLandingHeadMove = 10f;
        this.丛丛丛下且丟一丞且 = UnityEngine.Animator.StringToHash(name:  "IsGrounded");
        this.专三万丈丅丌丄丏丘 = UnityEngine.Animator.StringToHash(name:  "MovingDirectionX");
        this.不丌丁丛丄东不丄丞 = UnityEngine.Animator.StringToHash(name:  "MovingDirectionY");
        this.丝丌专万丐丞丐下不 = UnityEngine.Animator.StringToHash(name:  "MovingRotationX");
        this.丆与丄丈丑丑万一七 = UnityEngine.Animator.StringToHash(name:  "MovingSpeed");
        this.丙三且下世丆丕且丟 = UnityEngine.Animator.StringToHash(name:  "RotateLeft");
        this.丏丂下三丒专丕业丈 = UnityEngine.Animator.StringToHash(name:  "RotateRight");
        this.丈且丒丘丙丞丕丅上 = UnityEngine.Animator.StringToHash(name:  "RotationSpeed");
        this.专丙丈丘不一丒丕七 = UnityEngine.Animator.StringToHash(name:  "State");
        this.torsoRotationMultiplier = 0.5f;
        this.rotationAnimationsLerpSpeed = ;
        this.rotationMoveSpeedModifier = ;
        this.spineRotationDifK = 0.5f;
        this.万丛丕丌丂且下万不 = 0.5f;
        this.丙丅世不丟一丑丕丞 = UnityEngine.Animator.StringToHash(name:  "Injured");
        this.下专下丙丝丁世丑丗 = UnityEngine.Animator.StringToHash(name:  "TakeDamage");
        this.且不丑专丐丂丝且丆 = UnityEngine.Animator.StringToHash(name:  "TakeDamage2");
        this.丂丗丝丞东业与丅丛 = UnityEngine.Animator.StringToHash(name:  "TakeDamage3");
        this.世丘丆与丁丈业丆丏 = UnityEngine.Animator.StringToHash(name:  "Jump");
        mem2[0] = 1056964608;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        this.丛不业丕丐上三丕丏 = val_17;
        mem[1152921535906895896] = val_17.y;
        mem[1152921535906895900] = val_17.z;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        this.下丏与世丌丛丝七万 = val_18;
        mem[1152921535906895908] = val_18.y;
        mem[1152921535906895912] = val_18.z;
        mem2[0] = ;
        mem2[0] = 1056964608;
        this.weaponDirectionAnimationInertion = 2f;
        this.weaponDirectionAnimationLerpSpeed = 10f;
        this.weaponDirectionAnimatioMaxAngle = 5f;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.zero;
        this.丑七丛丌丁丅七丂丝 = val_19;
        mem[1152921535906895984] = val_19.y;
        this.丗丆且万丑三丂一丈 = true;
    }
    private static PlayerAnimationWrapper()
    {
        PlayerAnimationWrapper.上丛丆丛丝丙专丙专 = 9f;
        PlayerAnimationWrapper.丁七丏丏且专丞不三 = 2f;
    }

}
