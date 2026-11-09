using UnityEngine;
internal class PlayerBotMovement : VTableHolder
{
    // Fields
    private PlayerBotController playerBotController;
    internal FirstPersonControlSharp 丐丆丁东丄丁丅丁丅;
    internal PlayerSynchStream 丁业世丈丟丈丘下丘;
    private 下丌丙丘丈丌世万专 下下业丟丝丝一丏丁;
    private 下丌丙丘丈丌世万专 丁丈丛世丒丆丕七上;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private UnityEngine.Vector3 一下丙丟丞丕一丞世;
    private float jumpNeededDeltaHeight;
    private float jumpPossibleDeltaHeight;
    private int jumpWhenPossibleChance;
    private float jumpNeededAngle;
    private float jumpSpeed;
    private float jumpCheckDistance;
    private bool 业丄业三三与丒七丗;
    private float 丈丂丈丛三丛与下七;
    private float 一业七丝丁东丙丛丅;
    private float 世三丂丟丞下丗不丄;
    private bool 且丂不丑世不丟丞丅;
    internal static float 三丏丅丐丏与下世丗;
    private PlayerBotEntity 丘丂丟不东七且三一;
    private bool 丁业丟丒三专丟丂丌;
    private float 世丈七丞且业丕丌上;
    private bool 丙不丘三丞七丏业丘;
    private PlayerBotPath currentPath;
    private bool pathsTestingEnabled;
    private PlayerBotMovement.丛丗且丛与丞丙丟七 repeatType;
    private float pointReachedDistance;
    private bool 一一世丌丆丞专专下;
    private int 丘世丄世东不下丁与;
    private float 丅丅三与三七与丐上;
    private PlayerBotPathWayPoint 一丈丛丁丕丘专丁一;
    private static System.Collections.Generic.List<PlayerBotPath> 且丆丅丆丆丏三丛丛;
    
    // Properties
    private bool 丈丅丝丞丌丄三一上 { get; }
    internal UnityEngine.Vector3 丁上专万丕万丛且丞 { get; set; }
    
    // Methods
    internal PlayerBotMovement()
    {
        this.下下业丟丝丝一丏丁 = new 下丌丙丘丈丌世万专(丁七丘丄丝丆丌世丛:  true, 上不丌丐丛三东丟丝:  0);
        this.丁丈丛世丒丆丕七上 = new 下丌丙丘丈丌世万专(丁七丘丄丝丆丌世丛:  false, 上不丌丐丛三东丟丝:  0);
        this.jumpNeededDeltaHeight = 0.55f;
        this.jumpPossibleDeltaHeight = 5.510186E-41f;
        this.jumpWhenPossibleChance = 30;
        this.jumpNeededAngle = 55f;
        this.jumpSpeed = 0f;
        this.jumpCheckDistance = 1.5f;
        this.世丈七丞且业丕丌上 = -3.402823E+38f;
        this.repeatType = 1;
        this.pointReachedDistance = 1f;
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.丑业丆三上东丆七丒 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PlayerBotMovement::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_5 = this.与丑丌丌丌丁丌不丕();
        val_5.丐丕丁丞丑丙丅丐丈 = new System.Action<System.Object[]>(object:  this, method:  System.Void PlayerBotMovement::丐丕丁丞丑丙丅丐丈(object[] 业丐世丛丐一丌业不));
    }
    internal void 且丑丏丙丘丐丐不丂(FirstPersonControlSharp 丐丆丁东丄丁丅丁丅)
    {
        this.丐丆丁东丄丁丅丁丅 = 丐丆丁东丄丁丅丁丅;
    }
    internal void 万丁上专与且丈一不(PlayerSynchStream 丁业世丈丟丈丘下丘)
    {
        this.丁业世丈丟丈丘下丘 = 丁业世丈丟丈丘下丘;
    }
    private void Awake()
    {
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        UnityEngine.Vector3 val_3 = this.transform.position;
        this.一下丙丟丞丕一丞世 = val_3;
        mem[1152921538680596108] = val_3.y;
        mem[1152921538680596112] = val_3.z;
        this.currentPath = PlayerBotPathsManager.与一丅丝不丈业与丙().transform.GetComponentInChildren<PlayerBotPath>();
        if((UnityEngine.Object.op_Implicit(exists:  this.GetComponent<PlayerBotEntity>())) != false)
        {
                this.丘丂丟不东七且三一 = this.GetComponent<PlayerBotEntity>();
        }
        
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.一与丐丝且丆丁丄不());
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.不一丛丛业丝丐七一());
    }
    private void Update()
    {
        PlayerBotPathsManager val_1 = PlayerBotPathsManager.与一丅丝不丈业与丙();
        if(val_1.isNewWayPointsSystem != false)
        {
                this.丕世丈丆与丞丛丆下();
        }
        else
        {
                this.且丐丆七万万丐丄业();
        }
        
        if(this.丄丈丑丐丆丞丘与丗.isMine != false)
        {
                this.丂七三与上一丕丂万();
        }
        
        bool val_3 = UnityEngine.Input.GetKey(key:  122);
    }
    private void FixedUpdate()
    {
        this.丞世业丁一不丅不丕();
    }
    private System.Collections.IEnumerator 一与丐丝且丆丁丄不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerBotMovement.丞丆业不丞且丘上丁();
    }
    private System.Collections.IEnumerator 不一丛丛业丝丐七一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerBotMovement.且丙丘丁一丈业丂一();
    }
    private void 下丄丅丞且丄丈丑丐(UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅)
    {
        var val_4;
        var val_21;
        var val_22;
        UnityEngine.AI.OffMeshLinkData val_1 = 七丘东丞世丆丕丙丅.currentOffMeshLinkData;
        UnityEngine.Vector3 val_5 = val_4.velocity;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  七丘东丞世丆丕丙丅.baseOffset);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        if(七丘东丞世丆丕丙丅 != null)
        {
                val_21 = 七丘东丞世丆丕丙丅.transform;
            val_22 = 七丘东丞世丆丕丙丅;
        }
        else
        {
                val_21 = 0.transform;
            val_22 = 0;
        }
        
        UnityEngine.Vector3 val_13 = val_22.transform.position;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, target:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, maxDistanceDelta:  七丘东丞世丆丕丙丅.speed * UnityEngine.Time.deltaTime);
        val_21.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Vector3 val_19 = val_22.transform.position;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == false)
        {
                return;
        }
        
        七丘东丞世丆丕丙丅.CompleteOffMeshLink();
    }
    private System.Collections.IEnumerator 丙丁世丂丑丒业七三(UnityEngine.AI.NavMeshAgent 七丘东丞世丆丕丙丅)
    {
        PlayerBotMovement.丕与东万丌业东丄七 val_1 = new PlayerBotMovement.丕与东万丌业东丄七();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .七丘东丞世丆丕丙丅 = 七丘东丞世丆丕丙丅;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 且丐丆七万万丐丄业()
    {
        float val_57;
        float val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_62;
        float val_63;
        float val_64;
        float val_65;
        float val_66;
        float val_67;
        float val_68;
        float val_69;
        val_57 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Physics.gravity;
        val_58 = val_1.y;
        if(GameConnect.一业上七丟业且业丙() != false)
        {
                if(RedLightController.Instance != 0)
        {
                val_57 = mem[RedLightController.Instance + 144];
            val_57 = RedLightController.Instance.jumpCoef;
            val_58 = val_58 / val_57;
        }
        
        }
        
        PlayerBot.NavMeshAgentController val_4 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        UnityEngine.Vector3 val_6 = this.transform.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
        val_59 = val_7.y;
        val_60 = val_7.z;
        PlayerBot.NavMeshAgentController val_8 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_59, z = val_60}, d:  val_8.agent.baseOffset);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_57, y = val_1.y, z = val_1.z}, d:  this.jumpCheckDistance);
        val_61 = val_11.y;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_61, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_62 = val_13.y;
        UnityEngine.Vector3 val_15 = this.transform.position;
        val_63 = 0.001f;
        val_64 = val_15.y - val_15.x;
        val_65 = 0f;
        if((val_64 > val_63) && (this.且丂不丑世不丟丞丅 != true))
        {
                UnityEngine.Vector3 val_17 = this.transform.position;
            val_63 = val_17.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_63}, b:  new UnityEngine.Vector3() {x = this.一下丙丟丞丕一丞世, y = val_60, z = val_59});
            val_64 = val_64;
            val_18.x = val_64 / val_18.x;
            val_61 = 57.29578f;
            val_62 = val_62;
            val_58 = val_58;
            val_65 = val_18.x * val_61;
        }
        
        if(this.业丄业三三与丒七丗 == true)
        {
            goto label_90;
        }
        
        if((val_65 >= 0) || (val_65 <= this.jumpNeededAngle))
        {
            goto label_28;
        }
        
        UnityEngine.Vector3 val_20 = this.transform.position;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = this.一下丙丟丞丕一丞世, y = val_59, z = val_64});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  2f);
        UnityEngine.Color val_23 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = this.一下丙丟丞丕一丞世, y = this.一下丙丟丞丕一丞世, z = this.一下丙丟丞丕一丞世}, dir:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, color:  new UnityEngine.Color() {r = val_23.r, g = val_23.b, b = 3f, a = this.一下丙丟丞丕一丞世}, duration:  this.一下丙丟丞丕一丞世);
        this.业丄业三三与丒七丗 = true;
        label_82:
        float val_26 = UnityEngine.Mathf.Clamp(value:  -(val_58 * UnityEngine.Time.deltaTime), min:  0f, max:  this.jumpSpeed);
        val_26 = this.jumpSpeed - val_26;
        this.丈丂丈丛三丛与下七 = val_26;
        UnityEngine.Vector3 val_28 = this.transform.position;
        this.一业七丝丁东丙丛丅 = val_28.y;
        this.世三丂丟丞下丗不丄 = val_28.y;
        if((((this.playerBotController != 0) && (this.playerBotController.player != 0)) && (this.playerBotController.player.丕丁丘丆万丄世专丛 != 0)) && (this.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName != 0))
        {
                if(this.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName.playerAnimation != 0)
        {
                this.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName.playerAnimation.丌业丈丏东上丕丟世();
        }
        
        }
        
        UnityEngine.Vector3 val_35 = this.transform.position;
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.up;
        val_60 = val_36.z;
        UnityEngine.Color val_37 = UnityEngine.Color.green;
        val_62 = val_37.b;
        val_61 = val_35.y;
        val_65 = val_35.x;
        val_63 = val_35.z;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_65, y = val_61, z = val_63}, dir:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_60}, color:  new UnityEngine.Color() {r = val_37.r, g = val_62, b = 3f, a = val_35.y}, duration:  val_58);
        val_58 = val_58;
        val_64 = val_64;
        goto label_83;
        label_28:
        val_65 = val_1.y;
        val_61 = -0.001f;
        if(val_65 <= val_61)
        {
            goto label_83;
        }
        
        val_61 = 0.1f;
        if(val_65 <= val_61)
        {
            goto label_83;
        }
        
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, d:  1f);
        val_60 = val_39.z;
        UnityEngine.Color val_40 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_13.x, y = val_62, z = val_13.z}, dir:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_60}, color:  new UnityEngine.Color() {r = val_40.r, g = val_40.b, b = 0.01f, a = val_39.y}, duration:  val_58);
        val_65 = val_13.x;
        val_61 = val_62;
        val_63 = val_13.z;
        bool val_41 = UnityEngine.AI.NavMesh.SamplePosition(sourcePosition:  new UnityEngine.Vector3() {x = val_65, y = val_61, z = val_63}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f}, maxDistance:  1f, areaMask:  0);
        val_58 = val_58;
        val_64 = val_64;
        if((val_65 != val_13.x) || (val_63 != val_13.z))
        {
            goto label_83;
        }
        
        val_63 = this.jumpNeededDeltaHeight;
        val_65 = val_61 - val_62;
        if(val_65 <= val_63)
        {
            goto label_81;
        }
        
        label_84:
        this.业丄业三三与丒七丗 = true;
        goto label_82;
        label_81:
        val_61 = this.jumpPossibleDeltaHeight;
        if(val_65 > val_61)
        {
                if(this.上不且丆丌丗且下东() == true)
        {
            goto label_84;
        }
        
        }
        
        label_83:
        if(this.业丄业三三与丒七丗 == true)
        {
            goto label_90;
        }
        
        UnityEngine.Vector3 val_44 = this.transform.position;
        val_67 = val_44.y;
        val_62 = UnityEngine.Time.deltaTime;
        val_63 = System.Math.Abs(val_58) * val_62;
        val_61 = val_13.z - val_67;
        val_68 = val_63 * UnityEngine.Time.deltaTime;
        if(val_61 <= val_68)
        {
            goto label_89;
        }
        
        this.业丄业三三与丒七丗 = true;
        this.丈丂丈丛三丛与下七 = 0f;
        this.一业七丝丁东丙丛丅 = UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished;
        this.世三丂丟丞下丗不丄 = UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished;
        goto label_90;
        label_89:
        if(this.业丄业三三与丒七丗 == false)
        {
            goto label_94;
        }
        
        label_90:
        val_67 = this.丈丂丈丛三丛与下七;
        float val_47 = UnityEngine.Time.deltaTime;
        val_66 = this.丈丂丈丛三丛与下七;
        val_47 = val_67 * val_47;
        val_47 = this.一业七丝丁东丙丛丅 + val_47;
        this.一业七丝丁东丙丛丅 = val_47;
        float val_48 = UnityEngine.Time.deltaTime;
        val_48 = val_58 * val_48;
        val_69 = val_66 + val_48;
        this.丈丂丈丛三丛与下七 = val_69;
        if(val_69 < 0)
        {
                val_67 = this.一业七丝丁东丙丛丅;
            UnityEngine.Vector3 val_50 = this.transform.position;
            if(val_67 <= val_50.y)
        {
                this.业丄业三三与丒七丗 = false;
        }
        
        }
        
        label_94:
        UnityEngine.Vector3 val_52 = this.transform.position;
        this.一下丙丟丞丕一丞世 = val_52;
        mem[1152921538681679116] = val_52.y;
        mem[1152921538681679120] = val_52.z;
        this.且丂不丑世不丟丞丅 = (val_64 < 0) ? 1 : 0;
    }
    private void 丕世丈丆与丞丛丆下()
    {
        float val_6;
        if(this.业丄业三三与丒七丗 == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丈丂丈丛三丛与下七 * val_1;
        val_1 = this.一业七丝丁东丙丛丅 + val_1;
        this.一业七丝丁东丙丛丅 = val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Physics.gravity;
        val_6 = val_2.y;
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = val_6 * val_3;
        val_3 = this.丈丂丈丛三丛与下七 + val_3;
        this.丈丂丈丛三丛与下七 = val_3;
        if(val_3 >= 0)
        {
                return;
        }
        
        val_6 = this.一业七丝丁东丙丛丅;
        UnityEngine.Vector3 val_5 = this.transform.position;
        if(val_6 > val_5.y)
        {
                return;
        }
        
        this.业丄业三三与丒七丗 = false;
    }
    internal void 丕丗丁丄专丏三东不()
    {
        if(this.业丄业三三与丒七丗 == true)
        {
                return;
        }
        
        this.业丄业三三与丒七丗 = true;
        this.丈丂丈丛三丛与下七 = this.jumpSpeed;
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.一业七丝丁东丙丛丅 = val_2.y;
        this.世三丂丟丞下丗不丄 = val_2.y;
        this.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName.playerAnimation.丌业丈丏东上丕丟世();
        this = this.transform;
        UnityEngine.Vector3 val_4 = this.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        UnityEngine.Color val_6 = UnityEngine.Color.green;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, dir:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, color:  new UnityEngine.Color() {r = val_6.r, g = val_6.b, b = 3f, a = val_4.y}, duration:  ???);
    }
    private bool 上不且丆丌丗且下东()
    {
        bool val_5;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 - this.世丈七丞且业丕丌上;
        if(val_1 < 0)
        {
                val_5 = this.丙不丘三丞七丏业丘;
            this.丙不丘三丞七丏业丘 = ((UnityEngine.Random.Range(min:  1, max:  100)) <= this.jumpWhenPossibleChance) ? 1 : 0;
            this.世丈七丞且业丕丌上 = UnityEngine.Time.time;
            return val_5;
        }
        
        val_5 = this.丙不丘三丞七丏业丘;
        return val_5;
    }
    internal void 丂七三与上一丕丂万()
    {
        if(this.丁业世丈丟丈丘下丘 == 0)
        {
                return;
        }
        
        this.下下业丟丝丝一丏丁.丆上七丟丑万不七世();
        this.下丅上一丕丁三丆丟(东业丄丅丅且世七丄:  this.下下业丟丝丝一丏丁);
        this.丁丈丛世丒丆丕七上.业七丏上业丏上丐丆(上不丌丐丛三东丟丝:  this.下下业丟丝丝一丏丁.东与上丗与丏下丂丘(), 下业丕七东丌丝下且:  0);
        this = this.丁丈丛世丒丆丕七上;
        this.丁业世丈丟丈丘下丘.OnPhotonSerializeView(东业丄丅丅且世七丄:  this, 东一丁世丑丞业丄丐:  new 业丘丘丘丁丂丕万东());
    }
    internal UnityEngine.Vector3 丘丄丈上与丕三丅丑()
    {
        UnityEngine.Quaternion val_1 = this.playerBotController.player.eyesTransform.localRotation;
        UnityEngine.Quaternion val_3 = this.transform.rotation;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal void 丈丌丝丐丆不且万不(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  0f, y:  丙业与丙丗丝不丈东.y, z:  0f);
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  丙业与丙丗丝不丈东.x, y:  0f, z:  0f);
        this.playerBotController.player.eyesTransform.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    internal void 下丅上一丕丁三丆丟(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        float val_24;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_4 = this.transform.position;
        val_24 = val_4.y;
        if(this.业丄业三三与丒七丗 != false)
        {
                val_24 = this.一业七丝丁东丙丛丅;
        }
        
        UnityEngine.Vector3 val_5 = this.丘丄丈上与丕三丅丑();
        UnityEngine.Vector3 val_6 = this.丘丄丈上与丕三丅丑();
        int val_24 = System.Convert.ToInt32(value:  false);
        int val_25 = System.Convert.ToInt32(value:  false);
        int val_17 = (System.Convert.ToInt32(value:  (this.playerBotController.player.万丝一万丐且丌业丛 == true) ? 1 : 0)) | (val_24 << 1);
        val_17 = val_17 | ((System.Convert.ToInt32(value:  this.playerBotController.player.丕丘丂业一专丗丝丙)) << 2);
        val_24 = val_17 | ((System.Convert.ToInt32(value:  false)) << 3);
        val_24 = val_24 | ((System.Convert.ToInt32(value:  false)) << 4);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_4);
        val_25 = val_24 | (val_25 << 5);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  (int)val_5.y * 10f);
        val_25 = val_25 | ((System.Convert.ToInt32(value:  true)) << 6);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  (int)val_6.x * 10f);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  0);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_25 | ((System.Convert.ToInt32(value:  false)) << 7));
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  System.Convert.ToInt32(value:  (丅丒丗丑丒丙丛不丆.丑上丞丒丞丁七丌七() < 10) ? 1 : 0));
    }
    private void 丌丑丄丂业丟丟丕丂(PlayerBotPath 世丝七丆丙丘丛丕丁)
    {
        float val_8;
        float val_9;
        float val_10;
        var val_12;
        this.currentPath = 世丝七丆丙丘丛丕丁;
        this.丘世丄世东不下丁与 = 0;
        if(this.playerBotController != 0)
        {
                if(this.playerBotController.player != 0)
        {
                bool val_3 = UnityEngine.Object.op_Inequality(x:  this.playerBotController.player.丕丁丘丆万丄世专丛, y:  0);
        }
        
        }
        
        PlayerBot.NavMeshAgentController val_4 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        val_12 = null;
        val_12 = null;
        val_4.agent.speed = this.丘丂丟不东七且三一.业丐丞万东上下丒丘.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
        PlayerBot.NavMeshAgentController val_6 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        PlayerBotPathPoint val_7 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        bool val_11 = val_6.agent.SetDestination(target:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10});
    }
    private PlayerBotPath 业丞丆业一世上万丆(PlayerBotPathWayPoint 业丛下丟专丒东专丘, PlayerBotPathWayPoint 一丈丛丁丕丘专丁一)
    {
        var val_3;
        var val_10;
        System.Collections.Generic.List<PlayerBotPath> val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        int val_18;
        System.Collections.Generic.List<PlayerBotPath> val_19;
        List.Enumerator<T> val_1 = 业丛下丟专丒东专丘.startedPaths.GetEnumerator();
        val_10 = 0;
        goto label_7;
        label_19:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(X23 != 一丈丛丁丕丘专丁一)
        {
                val_12 = null;
            val_12 = null;
            val_13 = null;
            if(val_10 == PlayerBotMovement.且丆丅丆丆丏三丛丛.Count)
        {
                val_14 = null;
            val_11 = PlayerBotMovement.且丆丅丆丆丏三丛丛;
            val_11.Add(item:  val_4);
        }
        else
        {
                val_15 = null;
            val_11 = PlayerBotMovement.且丆丅丆丆丏三丛丛;
            val_11.set_Item(index:  0, value:  val_4);
        }
        
            val_10 = 1;
        }
        
        label_7:
        if(((-283161904) & 1) != 0)
        {
            goto label_19;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_10 >= 1)
        {
                val_16 = null;
            val_16 = null;
            val_17 = 0;
            val_18 = val_10;
            val_19 = PlayerBotMovement.且丆丅丆丆丏三丛丛;
            return (PlayerBotPath)val_19.Item[UnityEngine.Random.Range(min:  0, max:  val_18 = 业丛下丟专丒东专丘.startedPaths.Count)];
        }
        
        if(业丛下丟专丒东专丘 == null)
        {
            goto label_34;
        }
        
        val_19 = 业丛下丟专丒东专丘.startedPaths;
        if(业丛下丟专丒东专丘.startedPaths != null)
        {
            goto label_37;
        }
        
        label_38:
        label_37:
        val_17 = 0;
        return (PlayerBotPath)val_19.Item[UnityEngine.Random.Range(min:  0, max:  val_18)];
        label_34:
        if(业丛下丟专丒东专丘.startedPaths != null)
        {
            goto label_37;
        }
        
        goto label_38;
    }
    private void 丞世业丁一不丅不丕()
    {
        var val_13;
        float val_24;
        float val_25;
        float val_26;
        float val_30;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_41;
        float val_44;
        UnityEngine.AI.NavMeshAgent val_74;
        bool val_75;
        float val_76;
        var val_77;
        float val_79;
        float val_80;
        float val_81;
        PlayerBotPath val_82;
        var val_83;
        val_74 = this;
        PlayerBotPathsManager val_1 = PlayerBotPathsManager.与一丅丝不丈业与丙();
        val_75 = val_1.isNewWayPointsSystem;
        PlayerBot.NavMeshAgentController val_2 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        if(val_75 != false)
        {
                if(val_2.agent.autoBraking == false)
        {
                return;
        }
        
            PlayerBot.NavMeshAgentController val_4 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
            val_74 = val_4.agent;
            val_74.autoBraking = false;
            return;
        }
        
        if(this.pathsTestingEnabled == false)
        {
            goto label_15;
        }
        
        if(val_2.agent != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        val_2.agent.autoBraking = (this.丘世丄世东不下丁与 < 1) ? 1 : 0;
        if(this.pathsTestingEnabled == false)
        {
            goto label_17;
        }
        
        val_75 = 1152921504848912384;
        if(this.currentPath != 0)
        {
            goto label_20;
        }
        
        label_17:
        this.一一世丌丆丞专专下 = false;
        this.一丈丛丁丕丘专丁一 = 0;
        return;
        label_15:
        if(val_2.agent != null)
        {
            goto label_21;
        }
        
        goto label_22;
        label_20:
        this.playerBotController.丌丕下东七丗丛丞下.useTestBehavior = true;
        if(this.一一世丌丆丞专专下 != true)
        {
                if(this.currentPath != 0)
        {
                this.丌丑丄丂业丟丟丕丂(世丝七丆丙丘丛丕丁:  this.currentPath);
            this.一一世丌丆丞专专下 = true;
        }
        
        }
        
        if(this.currentPath == 0)
        {
                return;
        }
        
        val_76 = 1f;
        if((this.playerBotController != 0) && (this.playerBotController.player != 0))
        {
                if(this.playerBotController.player.丕丁丘丆万丄世专丛 != 0)
        {
                val_76 = this.playerBotController.player.丕丁丘丆万丄世专丛.三上丅丈丄不丌万丙;
        }
        
        }
        
        val_77 = 1152921504833470464;
        goto label_86;
        label_115:
        PlayerBotPathPoint val_12 = Item[this.playerBotController.player.丕丁丘丆万丄世专丛];
        if(val_13 != false)
        {
                this.业丄业三三与丒七丗 = true;
            this.丈丂丈丛三丛与下七 = this.jumpSpeed;
            UnityEngine.Vector3 val_15 = this.transform.position;
            this.一业七丝丁东丙丛丅 = val_15.y;
            this.世三丂丟丞下丗不丄 = val_15.y;
            this.playerBotController.player.丕丁丘丆万丄世专丛.mySkinName.playerAnimation.丌业丈丏东上丕丟世();
            UnityEngine.Vector3 val_17 = this.transform.position;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
            UnityEngine.Color val_19 = UnityEngine.Color.green;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, dir:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, color:  new UnityEngine.Color() {r = val_19.r, g = val_19.b, b = 3f}, duration:  null);
        }
        
        int val_20 = this.丘世丄世东不下丁与 + 1;
        this.丘世丄世东不下丁与 = val_20;
        if(val_20 >= this.currentPath.points.Count)
        {
            goto label_62;
        }
        
        PlayerBot.NavMeshAgentController val_22 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        PlayerBotPathPoint val_23 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        val_79 = val_24;
        val_80 = val_25;
        val_81 = val_26;
        bool val_27 = val_22.agent.SetDestination(target:  new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_81});
        if(this.丘世丄世东不下丁与 < 1)
        {
            goto label_86;
        }
        
        PlayerBot.NavMeshAgentController val_28 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        PlayerBotPathPoint val_29 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        val_77 = val_77;
        val_28.agent.speed = this.丘丂丟不东七且三一.业丐丞万东上下丒丘.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  val_30);
        UnityEngine.Vector3 val_32 = this.丘丄丈上与丕三丅丑();
        UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        PlayerBotPathPoint val_34 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        val_80 = val_33.y;
        val_81 = val_33.z;
        PlayerBotPathPoint val_40 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        PlayerBotPathPoint val_43 = this.currentPath.points.Item[this.丘世丄世东不下丁与 - 1];
        float val_74 = val_44;
        val_74 = val_41 - val_74;
        val_79 = (UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_33.x, y = val_80, z = val_81, w = val_33.w}, b:  new UnityEngine.Quaternion() {x = val_35, y = val_36, z = val_37, w = val_38})) / val_74;
        this.丅丅三与三七与丐上 = val_79;
        goto label_86;
        label_62:
        if(this.repeatType != 2)
        {
            goto label_87;
        }
        
        val_82 = this.currentPath;
        if(this.currentPath != null)
        {
            goto label_88;
        }
        
        val_82 = this.currentPath;
        if(val_82 == null)
        {
            goto label_89;
        }
        
        label_88:
        this.丌丑丄丂业丟丟丕丂(世丝七丆丙丘丛丕丁:  this.业丞丆业一世上万丆(业丛下丟专丒东专丘:  this.currentPath.finishWayPoint, 一丈丛丁丕丘专丁一:  this.currentPath.startWayPoint));
        PlayerBot.NavMeshAgentController val_46 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        val_83 = null;
        val_83 = null;
        val_46.agent.speed = this.丘丂丟不东七且三一.业丐丞万东上下丒丘.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
        PlayerBot.NavMeshAgentController val_48 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        PlayerBotPathPoint val_49 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        val_79 = val_24;
        val_80 = val_25;
        val_81 = val_26;
        bool val_50 = val_48.agent.SetDestination(target:  new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_81});
        label_86:
        UnityEngine.Vector3 val_52 = this.transform.position;
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.down;
        PlayerBot.NavMeshAgentController val_54 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, d:  val_54.agent.baseOffset);
        UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
        PlayerBotPathPoint val_58 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, b:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26});
        float val_75 = this.pointReachedDistance;
        val_75 = val_75 * val_75;
        if(val_59.x < 0)
        {
            goto label_115;
        }
        
        PlayerBotPathPoint val_60 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        UnityEngine.Vector3 val_61 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z}, d:  3f);
        UnityEngine.Color val_63 = UnityEngine.Color.magenta;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, dir:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, color:  new UnityEngine.Color() {r = val_63.r, g = val_63.b, b = 0.001f}, duration:  null);
        PlayerBot.NavMeshAgentController val_64 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        PlayerBot.NavMeshAgentController val_65 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        UnityEngine.Vector3 val_66 = val_65.agent.desiredVelocity;
        UnityEngine.Vector3 val_67 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z}, d:  val_76);
        val_64.agent.velocity = new UnityEngine.Vector3() {x = val_67.x, y = val_67.y, z = val_67.z};
        UnityEngine.Vector3 val_68 = this.丘丄丈上与丕三丅丑();
        UnityEngine.Quaternion val_69 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z});
        PlayerBotPathPoint val_70 = this.currentPath.points.Item[this.丘世丄世东不下丁与];
        float val_71 = UnityEngine.Time.deltaTime;
        val_71 = this.丅丅三与三七与丐上 * val_71;
        UnityEngine.Quaternion val_72 = UnityEngine.Quaternion.RotateTowards(from:  new UnityEngine.Quaternion() {x = val_69.x, y = val_69.y, z = val_69.z, w = val_69.w}, to:  new UnityEngine.Quaternion() {x = val_35, y = val_36, z = val_37, w = val_38}, maxDegreesDelta:  val_71);
        this.丈丌丝丐丆不且万不(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z});
        return;
        label_87:
        this.一一世丌丆丞专专下 = false;
        this.pathsTestingEnabled = (this.repeatType != 0) ? 1 : 0;
        return;
        label_89:
    }
    internal void 丌且上东下上丐丅世()
    {
        var val_11;
        if(this.playerBotController == 0)
        {
                return;
        }
        
        if(this.playerBotController.丌丕下东七丗丛丞下 == 0)
        {
                return;
        }
        
        if(this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅() == 0)
        {
                return;
        }
        
        PlayerBot.NavMeshAgentController val_5 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        if(val_5.agent == 0)
        {
                return;
        }
        
        if(this.playerBotController.player == 0)
        {
                return;
        }
        
        if(this.playerBotController.player.丕丁丘丆万丄世专丛 == 0)
        {
                return;
        }
        
        PlayerBot.NavMeshAgentController val_9 = this.playerBotController.丌丕下东七丗丛丞下.丌且丞丕万丂丆七丅();
        val_11 = null;
        val_11 = null;
        val_9.agent.speed = this.丘丂丟不东七且三一.业丐丞万东上下丒丘.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
    }
    private void OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        this.playerBotController.丌丕下东七丗丛丞下.丈丐且万业丗与万与();
    }
    private void 丐丕丁丞丑丙丅丐丈(object[] 业丐世丛丐一丌业不)
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        this.playerBotController.丌丕下东七丗丛丞下.丈丐且万业丗与万与();
    }
    private static PlayerBotMovement()
    {
        PlayerBotMovement.三丏丅丐丏与下世丗 = 6.5f;
        PlayerBotMovement.且丆丅丆丆丏三丛丛 = new System.Collections.Generic.List<PlayerBotPath>(capacity:  100);
    }

}
