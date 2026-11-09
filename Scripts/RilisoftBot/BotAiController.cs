using UnityEngine;

namespace RilisoftBot
{
    public class BotAiController : MonoBehaviour
    {
        // Fields
        private RilisoftBot.BaseBot 丗丛一丁丌与丟东丙;
        private RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丗下丘世三七一专丕;
        private bool 丈三世丕丛丄丙丏业;
        private bool 丝下丌丞丆丒不丒丂;
        private PhotonView 丅丏三七丁丑丞丄丏;
        private RilisoftBot.BotAiController.丄丞丙丄丁东丈下万 丛丐丌丆下丙丌万丏;
        internal int 不七三下业丁专与下;
        internal int 丞不且丌丆丆万业丘;
        private static System.Action<RilisoftBot.BotAiController> 丗丛丄丏丅丆三上丑;
        private UnityEngine.Vector3 丐丅丑丂丞专丙东丁;
        private float 丕丒万丞丑丌七三下;
        private float 不丗丝且上丟丘丌丘;
        private float 下丑丅丈三下丄丞丌;
        private float 丝丞丛与丞三丄丄丕;
        private float 丏丕丏世丏三上丞七;
        internal PatrolModifierController 丌万丁七丈业丈丗东;
        internal ChasingAreaModifierController 东万三丈万丗专业专;
        internal MoveMobToTarget 丞丟丌七东丕丁与东;
        internal CurrentAiState 丆丞业丅三丞专丝丒;
        internal AlternativeMobAttackController 世万不丘丗专上丞业;
        internal MobChooseNewTarget 且丑不三上世丈丁丆;
        internal IgnorIDamageable 丝丘丗丘业丝丈下丞;
        internal DelayAttackBotComponent 丞丆丛丕丗东丙丅丑;
        private float deltaTimeForHealthPatrol;
        public float healthRegen;
        private float 丝丙一丝丈丂不丙一;
        private float speedReturToPatrolPoint;
        private bool 丛丘丌丝丟且丕丐丂;
        private bool 丛不专东丁专不且丈;
        private UnityEngine.Vector3 一世丏丄丆丑上专一;
        private float 与丄上丂丝且丆一丞;
        private bool 一一丒丆世丘丐丘丆;
        private UnityEngine.WaitForSeconds 丏丈丏丅上丌万一世;
        public float minLenghtMove;
        private bool 下三丗丒专丐丘丐丆;
        private float 世万丑丆丕三丝丆一;
        private UnityEngine.Vector3 三丌上七丙丌丅一丘;
        private UnityEngine.AI.NavMeshAgent 上丙丁丕丑丌丂下丅;
        public bool isStationary;
        public bool isTeleportationMove;
        internal static bool 丞丐丑上丙一七丝且;
        private UnityEngine.Transform 与丝丁丑丁丌丞丞东;
        private float 且丌丌丏丕丄丁一丘;
        private bool 丐且丈世下不且七丘;
        private UnityEngine.BoxCollider 丞下世丟丕三一丟上;
        private UnityEngine.Transform onlyPossibleTarget;
        private float 三丛丌丂一三丗上丛;
        private bool 一万三一丘丘丒万丟;
        public float timeToNextTeleport;
        public float[] DeltaTeleportAttackDistance;
        public UnityEngine.GameObject effectTeleport;
        public float angleByPlayerLook;
        public UnityEngine.AudioClip teleportStart;
        public UnityEngine.AudioClip teleportEnd;
        private const int 丈东东丟专一丞下丙 = 5;
        private float 上上丆丝丘丏丅不丟;
        private UnityEngine.GameObject 专丂东不下一且丆不;
        private const float 丞丐丞与上不丑丁三 = 0.2;
        private float _distanceForStopMoving;
        private bool 丐丞丑七丅丏世东东;
        private const float 业丕丅丏下三丐丗业 = 3;
        private const float 丈丂丒丑丂丘丆丅丂 = 1;
        public bool isDetectPlayer;
        private bool 丟一丕丄丄世丏丌三;
        private float 丗不丘专丑丄丌丟丄;
        private float 丌上世丝三专业下丗;
        public bool checkCampaignBase;
        private bool 丂丅与丕丁丛东丌丗;
        private UnityEngine.Transform 专专丏下丐丂丂丅东;
        
        // Properties
        internal PhotonView 万上世上丑丘丑且丄 { get; }
        internal RilisoftBot.BaseBot 东不上丁丕世丂业专 { get; }
        internal bool 世上丞不万丒专世丛 { get; }
        private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
        internal UnityEngine.AI.NavMeshAgent 业下丒丗丙与世三与 { get; }
        public bool 丈世丏世丏丌且丌丏 { get; set; }
        public UnityEngine.Transform 上丝丁东下万七且与 { get; set; }
        internal bool 三且丝丒丙七丆上七 { get; }
        private bool 丈下丘丕丝丟丘丐丏 { get; set; }
        
        // Methods
        internal PhotonView 丛丘丟业下丐专丕丑()
        {
            if(this == 0)
            {
                    return 0;
            }
            
            if(this.丅丏三七丁丑丞丄丏 == 0)
            {
                    this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
                return 0;
            }
            
            0 = this.丅丏三七丁丑丞丄丏;
            return 0;
        }
        internal RilisoftBot.BaseBot 七与世丄丞丒一七三()
        {
            if(this == 0)
            {
                    return 0;
            }
            
            if(this.丗丛一丁丌与丟东丙 == 0)
            {
                    this.丗丛一丁丌与丟东丙 = this.GetComponentInChildren<RilisoftBot.BaseBot>();
                return 0;
            }
            
            0 = this.丗丛一丁丌与丟东丙;
            return 0;
        }
        internal static void 丞上丗一丅与丛且丅(System.Action<RilisoftBot.BotAiController> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  RilisoftBot.BotAiController.丈丂丒丑丂丘丆丅丂, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丞丁丆丘丌丝丏三丅(System.Action<RilisoftBot.BotAiController> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  RilisoftBot.BotAiController.丈丂丒丑丂丘丆丅丂, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        private void Awake()
        {
        
        }
        private void Start()
        {
            RilisoftBot.BotAiController val_32;
            T val_33;
            bool val_34;
            var val_35;
            val_32 = this;
            this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
            if((GameConnect.丙丘不世专且万丄丐() != true) && (GameConnect.且丞丁东丝丗上丈业() != true))
            {
                    if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_15;
            }
            
            }
            
            }
            
            val_33 = 1152921504848912384;
            if(this.丅丏三七丁丑丞丄丏 != 0)
            {
                    val_34 = UnityEngine.Object.op_Equality(x:  PolygonController.一下一万丄丅丘且丑, y:  0);
            }
            else
            {
                    label_15:
                val_34 = false;
            }
            
            this.丝下丌丞丆丒不丒丂 = val_34;
            this.丗下丘世三七一专丕 = 6;
            this.丗丛一丁丌与丟东丙 = this.GetComponentInChildren<RilisoftBot.BaseBot>();
            this.丛丐丌丆下丙丌万丏 = this.东且丅七丌三丕丌丕();
            this._distanceForStopMoving = this.丗丛一丁丌与丟东丙.attackDistance;
            this.上丙丁丕丑丌丂下丅 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
            this.丞下世丟丕三一丟上 = this.GetComponentInChildren<UnityEngine.BoxCollider>();
            UnityEngine.SceneManagement.Scene val_12 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Equality(a:  val_12.m_Handle.name, b:  "FortFieldBuild")) == false)
            {
                goto label_20;
            }
            
            this.上丙丁丕丑丌丂下丅.enabled = false;
            val_35 = 0;
            goto label_22;
            label_26:
            val_33 = this.GetComponentsInChildren<UnityEngine.Collider>()[0];
            val_33.enabled = false;
            val_35 = 1;
            label_22:
            if(val_35 < val_15.Length)
            {
                goto label_26;
            }
            
            if(RilisoftBot.BotAiController.丈丂丒丑丂丘丆丅丂 != 0)
            {
                    RilisoftBot.BotAiController.丈丂丒丑丂丘丆丅丂.Invoke(obj:  this);
            }
            
            this.enabled = false;
            return;
            label_20:
            this.与七丗且丑丛专万专();
            if(this.丛丐丌丆下丙丌万丏 == 0)
            {
                    this.且丌丌丏丕丄丁一丘 = this.丑丈丐丟丄丕丞丆丑();
            }
            
            this.上上丆丝丘丏丅不丟 = this.timeToNextTeleport;
            this.七下丁七丗丘丙丏丂();
            UnityEngine.Vector3 val_18 = this.丌丟丄业且三丛丕丄().position;
            val_33 = this.上丙丁丕丑丌丂下丅;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  val_33.baseOffset, a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            bool val_23 = this.上丙丁丕丑丌丂下丅.Warp(newPosition:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            if(RilisoftBot.BotAiController.丈丂丒丑丂丘丆丅丂 != 0)
            {
                    RilisoftBot.BotAiController.丈丂丒丑丂丘丆丅丂.Invoke(obj:  this);
            }
            
            this.丗丛一丁丌与丟东丙.RegisterBot();
            UnityEngine.Vector3 val_25 = this.丌丟丄业且三丛丕丄().position;
            this.丐丅丑丂丞专丙东丁 = val_25;
            mem[1152921540973200528] = val_25.y;
            mem[1152921540973200532] = val_25.z;
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    UnityEngine.Coroutine val_28 = this.StartCoroutine(routine:  this.不丟专丙丕专丝丘万());
            }
            
            DelayAttackBotComponent val_29 = this.GetComponent<DelayAttackBotComponent>();
            this.丞丆丛丕丗东丙丅丑 = val_29;
            if(val_29 == 0)
            {
                    return;
            }
            
            val_32 = this.丞丆丛丕丗东丙丅丑;
        }
        private System.Collections.IEnumerator 不丟专丙丕专丝丘万()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BotAiController.丒业东不丙丝世丟七(丗丏丅丕丆世丁专丟:  0);
        }
        private void 与丞丕丝上三不丞与()
        {
            UnityEngine.AI.NavMeshAgent val_43;
            float val_44;
            float val_45;
            float val_47;
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            var val_52;
            PatrolModifierController val_53;
            var val_54;
            var val_55;
            val_43 = this;
            this.专丙且七丝丏丞丌下();
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
            if(this.丌万丁七丈业丈丗东 == 0)
            {
                    float val_6 = val_2.x + (UnityEngine.Random.Range(min:  -this.minLenghtMove, max:  this.minLenghtMove));
                val_2.z = val_2.z + (UnityEngine.Random.Range(min:  -this.minLenghtMove, max:  this.minLenghtMove));
                this.三丌上七丙丌丅一丘 = 0;
                mem[1152921540973789236] = 0;
            }
            else
            {
                    this.三丌上七丙丌丅一丘 = val_2;
                mem[1152921540973789232] = val_2.y;
                mem[1152921540973789236] = val_2.z;
            }
            
            UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().position;
            val_45 = val_9.y;
            float val_10 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_45, z = val_9.z}, b:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = V12.16B, z = V11.16B});
            if(this.丗丛一丁丌与丟东丙.isAutomaticAnimationEnable != false)
            {
                    val_47 = this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
                float val_11 = this.丗丛一丁丌与丟东丙.丗业丐世丄万七丅丐(不丏丒且丟业丑丙业:  val_47);
            }
            else
            {
                    val_45 = this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
                val_47 = this.丗丛一丁丌与丟东丙.notAttackingSpeed * val_45;
            }
            
            val_47 = val_10 / val_47;
            val_47 = UnityEngine.Time.time + val_47;
            this.世万丑丆丕三丝丆一 = val_47;
            if(GameConnect.丅丟下专不丁一丈七() == false)
            {
                goto label_15;
            }
            
            UnityEngine.AI.NavMeshPath val_13 = new UnityEngine.AI.NavMeshPath();
            UnityEngine.Vector3 val_15 = this.丌丟丄业且三丛丕丄().position;
            val_48 = val_15.x;
            val_49 = val_15.y;
            val_50 = val_15.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.down;
            val_44 = val_16.y;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_44, z = val_16.z}, d:  this.上丙丁丕丑丌丂下丅.baseOffset);
            val_51 = val_49;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_48, y = val_51, z = val_50}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            if((UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, targetPosition:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_18.y, z = val_18.z}, areaMask:  0, path:  val_13)) == false)
            {
                goto label_20;
            }
            
            bool val_21 = this.上丙丁丕丑丌丂下丅.SetPath(path:  val_13);
            val_52 = 1;
            goto label_24;
            label_15:
            val_48 = this.三丌上七丙丌丅一丘;
            val_51 = val_10;
            val_52 = this.上丙丁丕丑丌丂下丅.SetDestination(target:  new UnityEngine.Vector3() {x = val_48, y = val_51, z = val_9.y});
            goto label_24;
            label_20:
            val_52 = 0;
            label_24:
            val_53 = this.丌万丁七丈业丈丗东;
            if(val_53 == 0)
            {
                goto label_53;
            }
            
            val_53 = this.丌万丁七丈业丈丗东;
            if((val_53 & 1) == 0)
            {
                goto label_53;
            }
            
            val_54 = 5;
            goto label_36;
            label_54:
            val_48 = val_19.x;
            val_49 = val_19.y;
            val_50 = val_19.z;
            this.三丌上七丙丌丅一丘 = val_19;
            mem[1152921540973789232] = val_49;
            mem[1152921540973789236] = val_50;
            val_51 = val_49;
            val_52 = this.上丙丁丕丑丌丂下丅.SetDestination(target:  new UnityEngine.Vector3() {x = val_48, y = val_51, z = val_50});
            UnityEngine.AI.NavMeshPath val_25 = new UnityEngine.AI.NavMeshPath();
            UnityEngine.Vector3 val_27 = this.丌丟丄业且三丛丕丄().position;
            if((UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, targetPosition:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_18.y, z = val_18.z}, areaMask:  0, path:  val_25)) != false)
            {
                    bool val_29 = this.上丙丁丕丑丌丂下丅.SetPath(path:  val_25);
            }
            
            val_54 = 4;
            goto label_36;
            label_47:
            if(this.上丙丁丕丑丌丂下丅 != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_36:
            val_53 = this.上丙丁丕丑丌丂下丅.path.corners;
            if(val_31.Length == 0)
            {
                goto label_42;
            }
            
            val_53 = this.丌万丁七丈业丈丗东;
            val_55 = 0;
            if(this.上丙丁丕丑丌丂下丅.path.corners == null)
            {
                goto label_47;
            }
            
            label_38:
            int val_43 = val_35.Length;
            val_43 = val_43 - 1;
            if(val_43 >= val_33.Length)
            {
                    val_55 = 0;
            }
            
            val_43 = this.上丙丁丕丑丌丂下丅.path.corners + ((long)val_43 * 12);
            val_51 = ((long)(int)((val_35.Length - 1)) * 12) + val_33 + 32 + 4;
            if(5 < 1)
            {
                goto label_53;
            }
            
            if((val_53 & 1) == 0)
            {
                goto label_54;
            }
            
            goto label_53;
            label_42:
            if(5 > 0)
            {
                goto label_54;
            }
            
            label_53:
            if((val_52 & 1) == 0)
            {
                goto label_55;
            }
            
            UnityEngine.Vector3 val_37 = this.丌丟丄业且三丛丕丄().position;
            val_50 = val_37.y;
            this.丗丛一丁丌与丟东丙.OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_50, z = val_48});
            if(this.丌万丁七丈业丈丗东 == 0)
            {
                goto label_60;
            }
            
            val_53 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_40 = val_53.position;
            val_50 = val_40.z;
            if((this.丌万丁七丈业丈丗东 & 1) == 0)
            {
                goto label_63;
            }
            
            label_60:
            val_43 = this.上丙丁丕丑丌丂下丅;
            if(this.丗丛一丁丌与丟东丙.isAutomaticAnimationEnable == false)
            {
                goto label_65;
            }
            
            val_48 = this.丗丛一丁丌与丟东丙.丗业丐世丄万七丅丐(不丏丒且丟业丑丙业:  this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上);
            if(val_43 != null)
            {
                goto label_67;
            }
            
            goto label_67;
            label_55:
            this.世万丑丆丕三丝丆一 = 0f;
            return;
            label_65:
            float val_42 = this.丗丛一丁丌与丟东丙.notAttackingSpeed * this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
            if(val_43 != null)
            {
                goto label_67;
            }
            
            goto label_67;
            label_63:
            val_48 = this.speedReturToPatrolPoint;
            label_67:
            this.上丙丁丕丑丌丂下丅.speed = val_48;
        }
        private RilisoftBot.BotAiController.丄丞丙丄丁东丈下万 东且丅七丌三丕丌丕()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            UnityEngine.Object val_15;
            if(this.丗丛一丁丌与丟东丙 == 0)
            {
                    val_11 = 4;
                return (丄丞丙丄丁东丈下万)val_11;
            }
            
            val_12 = 0;
            if( != 0)
            {
                goto label_10;
            }
            
            val_13 = 0;
            if( == 0)
            {
                goto label_18;
            }
            
            label_10:
            val_11 = 0;
            return (丄丞丙丄丁东丈下万)val_11;
            label_18:
            val_14 = 0;
            if( != 0)
            {
                    return (丄丞丙丄丁东丈下万)val_11;
            }
            
            if(this.丗丛一丁丌与丟东丙 != null)
            {
                    var val_8 = (null == null) ? this.丗丛一丁丌与丟东丙 : 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            var val_10 = (val_15 == 0) ? (1 + 1) : 1;
            return (丄丞丙丄丁东丈下万)val_11;
        }
        internal void 丕丒一丕下业下且丈(RilisoftBot.BaseBot 丗不丛七丏丄业三丁)
        {
            this.丗丛一丁丌与丟东丙 = 丗不丛七丏丄业三丁;
            this.丛丐丌丆下丙丌万丏 = this.东且丅七丌三丕丌丕();
        }
        private void 且丄世世丘与丂丁世()
        {
            if(this.下三丗丒专丐丘丐丆 != false)
            {
                    this.丗下丘世三七一专丕 = 0;
                return;
            }
            
            if((this.丗丛一丁丌与丟东丙.<丄上丐丝东丘丅丙丈>k__BackingField) != true)
            {
                    if(this.currentTarget != 0)
            {
                    丑丅专丈丏七丐丝业 val_3 = this.丐一丞不丏七专一且();
                this.丗下丘世三七一专丕 = val_3;
                if(val_3 != 1)
            {
                    return;
            }
            
                if(this.东万三丈万丗专业专 == 0)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_6 = this.currentTarget.position;
                if((this.东万三丈万丗专业专 & 1) != 0)
            {
                    return;
            }
            
                this.丗下丘世三七一专丕 = 0;
                this.IsCanMove = true;
                this.丟一丕丄丄世丏丌三 = false;
                return;
            }
            
            }
            
            this.丗下丘世三七一专丕 = 6;
        }
        private bool 丕业丟丌丗丟一丙丟()
        {
            RilisoftBot.BaseBot val_10;
            PhotonView val_11;
            var val_12;
            val_10 = this;
            if(this.丝下丌丞丆丒不丒丂 == false)
            {
                goto label_23;
            }
            
            val_11 = 1152921505167814656;
            if((ZombiManager.丟丗丄业丘丗业丗七 == 0) && (GameConnect.且丞丁东丝丗上丈业() != true))
            {
                    if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_30;
            }
            
            }
            
            }
            
            if(ZombiManager.丟丗丄业丘丗业丗七 != 0)
            {
                    if(ZombiManager.丟丗丄业丘丗业丗七.startGame == false)
            {
                goto label_18;
            }
            
            }
            
            val_11 = this.丅丏三七丁丑丞丄丏;
            bool val_7 = val_11.isMine;
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_22;
            }
            
            if(val_7 == true)
            {
                goto label_23;
            }
            
            bool val_8 = 0.丅丟丙丘丌丂上一丅();
            goto label_30;
            label_22:
            if(val_7 == false)
            {
                goto label_30;
            }
            
            label_23:
            val_12 = 0;
            return (bool)val_12;
            label_18:
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
            {
                    val_10 = this.丗丛一丁丌与丟东丙;
                val_10.DestroyByNetworkType();
            }
            
            label_30:
            val_12 = 1;
            return (bool)val_12;
        }
        internal bool 丆东三丕世丟丝丐丄()
        {
            return (bool)this.丛丘丌丝丟且丕丐丂;
        }
        internal void 丕业丞不丒不丗丛世(bool 世丁万下丗专世万丅)
        {
            var val_1 = (this.丛不专东丁专不且丈 == true) ? 1 : 0;
            val_1 = val_1 ^ 世丁万下丗专世万丅;
            if(val_1 == false)
            {
                    return;
            }
            
            this.丛不专东丁专不且丈 = 世丁万下丗专世万丅;
            if(this.七与世丄丞丒一七三() == 0)
            {
                    return;
            }
            
            this.七与世丄丞丒一七三().丕业丞不丒不丗丛世(世丁万下丗专世万丅:  世丁万下丗专世万丅);
        }
        internal void 丁业下丞万且丒丂下(bool 世丁万下丗专世万丅)
        {
            UnityEngine.Object val_13;
            var val_14;
            var val_1 = (this.丛丘丌丝丟且丕丐丂 == true) ? 1 : 0;
            val_1 = val_1 ^ 世丁万下丗专世万丅;
            if(val_1 == false)
            {
                    return;
            }
            
            this.丛丘丌丝丟且丕丐丂 = 世丁万下丗专世万丅;
            if(this.丛丘丟业下丐专丕丑() != 0)
            {
                    PhotonView val_5 = this.丛丘丟业下丐专丕丑();
                val_5.synchronization = (世丁万下丗专世万丅 != true) ? 2 : 0;
            }
            
            val_13 = this.丅不丂下丐专丙丗丗();
            if(val_13 == 0)
            {
                    return;
            }
            
            UnityEngine.AI.NavMeshAgent val_9 = this.丅不丂下丐专丙丗丗();
            if((this.丛丘丟业下丐专丕丑().isMine == false) || (世丁万下丗专世万丅 == false))
            {
                goto label_11;
            }
            
            val_14 = 1;
            if(val_9 != null)
            {
                goto label_15;
            }
            
            goto label_13;
            label_11:
            bool val_12 = 0.丅丟丙丘丌丂上一丅();
            val_14 = 0;
            if(val_9 != null)
            {
                goto label_15;
            }
            
            label_13:
            label_15:
            val_9.enabled = false;
        }
        private void Update()
        {
            string val_56;
            var val_98;
            var val_99;
            float val_100;
            RilisoftBot.BaseBot val_101;
            bool val_102;
            float val_103;
            float val_104;
            float val_105;
            var val_106;
            var val_107;
            var val_108;
            Player_move_c val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            if(this.丛丘丌丝丟且丕丐丂 == false)
            {
                goto label_1;
            }
            
            val_98 = null;
            val_98 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                goto label_42;
            }
            
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_7;
            }
            
            if(this.丅丏三七丁丑丞丄丏.isMine != true)
            {
                    bool val_3 = 0.丅丟丙丘丌丂上一丅();
                if(this.currentTarget != 0)
            {
                    this.与丝丁丑丁丌丞丞东 = 0;
            }
            
            }
            
            if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                goto label_15;
            }
            
            val_99 = 1;
            goto label_16;
            label_1:
            if(this.东万三丈万丗专业专 == 0)
            {
                    return;
            }
            
            val_100 = this.丝丙一丝丈丂不丙一;
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_100 + val_8;
            this.丝丙一丝丈丂不丙一 = val_8;
            if(val_8 < this.deltaTimeForHealthPatrol)
            {
                    return;
            }
            
            val_101 = this.丗丛一丁丌与丟东丙;
            if(this.丗丛一丁丌与丟东丙 != null)
            {
                goto label_21;
            }
            
            val_101 = this.丗丛一丁丌与丟东丙;
            if(val_101 == null)
            {
                goto label_156;
            }
            
            label_21:
            if(this.丗丛一丁丌与丟东丙.health >= 0)
            {
                    return;
            }
            
            val_100 = this.healthRegen;
            this.丝丙一丝丈丂不丙一 = 0f;
            this.丗丛一丁丌与丟东丙.丞万丟万上且丟业丘(世丙丟上丘上七万万:  val_100, 丘丞丛万世丈丅丂丆:  false);
            return;
            label_7:
            val_102 = 1152921505107111936;
            if(this.上丙丁丕丑丌丂下丅.enabled ^ 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
            {
                goto label_42;
            }
            
            val_102 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
            this.上丙丁丕丑丌丂下丅.enabled = val_102;
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_42;
            }
            
            }
            
            this.IsCanMove = true;
            goto label_42;
            label_15:
            bool val_16 = 0.丅丟丙丘丌丂上一丅();
            val_99 = 0;
            label_16:
            val_102 = this.上丙丁丕丑丌丂下丅;
            if(val_99 ^ val_102.enabled != false)
            {
                    val_102 = this.上丙丁丕丑丌丂下丅;
                val_102.enabled = false;
            }
            
            label_42:
            if(this.丕业丟丌丗丟一丙丟() == true)
            {
                    return;
            }
            
            if(this.且丑不三上世丈丁丆 == 0)
            {
                    this.且丘丈东丟万丁丟丙();
            }
            
            this.且丄世世丘与丂丁世();
            if(this.丆丞业丅三丞专丝丒 != 0)
            {
                    this.丗下丘世三七一专丕 = this.丆丞业丅三丞专丝丒;
            }
            
            this.三丟丁一万七下且万();
            if((((this.丌万丁七丈业丈丗东 != 0) && (this.丗下丘世三七一专丕 != this.丗下丘世三七一专丕)) && (this.丗下丘世三七一专丕 == 0)) && (this.丌万丁七丈业丈丗东 != null))
            {
                    if(null == null)
            {
                goto label_59;
            }
            
            }
            
            label_174:
            if(this.一一丒丆世丘丐丘丆 == false)
            {
                goto label_60;
            }
            
            label_66:
            if(this.丗丛一丁丌与丟东丙.丑一业丟上丐丕丗下 == false)
            {
                goto label_62;
            }
            
            this.丗丛一丁丌与丟东丙.丌丝世丟丗且丙专丄 = 3;
            goto label_197;
            label_60:
            if((this.丗丛一丁丌与丟东丙.<丄上丐丝东丘丅丙丈>k__BackingField) == false)
            {
                goto label_65;
            }
            
            if(this.一一丒丆世丘丐丘丆 == true)
            {
                goto label_66;
            }
            
            goto label_197;
            label_62:
            label_197:
            if((this.丗丛一丁丌与丟东丙.<丄上丐丝东丘丅丙丈>k__BackingField) != false)
            {
                    if(GameConnect.万七丄丛丈丟专一丑() != false)
            {
                    UnityEngine.Vector3 val_26 = this.丌丟丄业且三丛丕丄().position;
                UnityEngine.Vector3 val_28 = this.丌丟丄业且三丛丕丄().position;
                UnityEngine.Vector3 val_30 = this.丌丟丄业且三丛丕丄().up;
                val_103 = val_30.x;
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, b:  new UnityEngine.Vector3() {x = val_103, y = val_30.y, z = val_30.z});
                val_104 = val_31.z;
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_104}, t:  UnityEngine.Time.deltaTime + UnityEngine.Time.deltaTime);
                val_105 = val_34.z;
                this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_105};
            }
            
                if((this.丗丛一丁丌与丟东丙.<东世丐丘丏丂丑专三>k__BackingField) != false)
            {
                    this.丗丛一丁丌与丟东丙.SetPositionForFallState();
            }
            
                if(this.丈三世丕丛丄丙丏业 != true)
            {
                    this.上丙丁丕丑丌丂下丅.enabled = false;
                this.丈三世丕丛丄丙丏业 = true;
            }
            
            }
            
            if(GameConnect.且丞丁东丝丗上丈业() == true)
            {
                goto label_86;
            }
            
            val_106 = 0;
            goto label_87;
            label_105:
            val_107 = null;
            val_107 = null;
            SingularityHole val_36 = Initializer.丂丈丗与丕三不丑七.Item[0];
            UnityEngine.Vector3 val_38 = val_36.transform.position;
            val_105 = val_38.z;
            UnityEngine.Vector3 val_40 = this.丌丟丄业且三丛丕丄().position;
            val_104 = val_40.y;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_105}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_104, z = val_40.z});
            float val_42 = val_36.GetForce(丌七丒世丄上丞丞丁:  val_41.x);
            if(val_42 != 0f)
            {
                    UnityEngine.Transform val_43 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_44 = val_43.position;
                val_103 = val_44.z;
                UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_103}, d:  val_42);
                val_104 = val_45.y;
                UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_104, z = val_45.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
                val_105 = val_48.z;
                val_43.position = new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_105};
            }
            
            val_106 = 1;
            label_87:
            val_108 = null;
            val_108 = null;
            if(val_106 < Initializer.丂丈丗与丕三不丑七.Count)
            {
                goto label_105;
            }
            
            label_86:
            val_100 = 5.76f;
            val_109 = 0;
            goto label_106;
            label_149:
            val_110 = null;
            val_110 = null;
            if((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  14)) != false)
            {
                    val_111 = null;
                val_111 = null;
                Player_move_c val_52 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                if((this.丗丛一丁丌与丟东丙.IsEnemyTo(专丞上七七且丝七丗:  val_109)) != false)
            {
                    val_112 = null;
                val_112 = null;
                丂丑丂七丞丞丅丂东 val_55 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].与七丑丐专丈丅丄丈(丏不丂丆且三丞丆丏:  14);
                if(((System.String.IsNullOrEmpty(value:  val_56)) != true) && (丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_56] != null))
            {
                    val_113 = null;
                val_113 = null;
                Player_move_c val_60 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_61 = val_60.myPlayerTransform.position;
                val_105 = val_61.y;
                UnityEngine.Vector3 val_63 = this.transform.position;
                val_104 = val_63.x;
                val_103 = val_63.z;
                UnityEngine.Vector3 val_64 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_61.x, y = val_105, z = val_61.z}, b:  new UnityEngine.Vector3() {x = val_104, y = val_63.y, z = val_103});
                if((val_64.x < 0) && (val_64.x > val_100))
            {
                    val_114 = null;
                val_114 = null;
                Player_move_c val_65 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_66 = val_65.myPlayerTransform.position;
                UnityEngine.Vector3 val_68 = this.transform.position;
                UnityEngine.Vector3 val_69 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_66.x, y = val_66.y, z = val_66.z}, b:  new UnityEngine.Vector3() {x = val_68.x, y = val_68.y, z = val_68.z});
                UnityEngine.Transform val_70 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_71 = val_70.position;
                val_104 = val_71.x;
                val_103 = val_71.z;
                UnityEngine.Vector3 val_72 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_69.x, y = val_69.y, z = val_69.z}, d:  10f);
                UnityEngine.Vector3 val_74 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_75 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_104, y = val_71.y, z = val_103}, b:  new UnityEngine.Vector3() {x = val_74.x, y = val_74.y, z = val_74.z});
                val_105 = val_75.y;
                val_70.position = new UnityEngine.Vector3() {x = val_75.x, y = val_105, z = val_75.z};
            }
            
            }
            
            }
            
            }
            
            val_109 = 1;
            label_106:
            val_115 = null;
            val_115 = null;
            val_102 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
            if(val_109 < val_102.Count)
            {
                goto label_149;
            }
            
            return;
            label_65:
            if(this.丗下丘世三七一专丕 > 5)
            {
                goto label_197;
            }
            
            var val_98 = 106027048 + (this.丗下丘世三七一专丕) << 2;
            val_98 = val_98 + 106027048;
            goto (106027048 + (this.丗下丘世三七一专丕) << 2 + 106027048);
            label_59:
            if((this.且丑不三上世丈丁丆 == null) || (null != null))
            {
                goto label_174;
            }
            
            this.且丑不三上世丈丁丆.丑七七与丏丟丛业七(一丅万丒上万七下世:  this.丌万丁七丈业丈丗东.丑丗丗业丈丙丑丂丝());
            goto label_174;
            label_156:
        }
        internal void 丘丝丌丌丟丄丁丒七(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
        {
            if(专丞上七七且丝七丗 == null)
            {
                    return;
            }
            
            if(this.丛丘丟业下丐专丕丑() == 0)
            {
                    return;
            }
            
            this.丛丘丟业下丐专丕丑().TransferOwnership(不丝业丏业丝业且七:  专丞上七七且丝七丗);
        }
        internal void 丝丄丏上与丟世东七(bool 丙业与丙丗丝不丈东)
        {
            this.一一丒丆世丘丐丘丆 = 丙业与丙丗丝不丈东;
        }
        internal bool 丅丂丟丁三丐丕三丈()
        {
            if(this.不丗丝且上丟丘丌丘 > 0f)
            {
                    return false;
            }
            
            if(this.丝丞丛与丞三丄丄丕 <= 0f)
            {
                    return (bool)(this.下丑丅丈三下丄丞丌 <= 0f) ? 1 : 0;
            }
            
            return false;
        }
        internal void 业丐与丐丒丈七七丄()
        {
            this.不丗丝且上丟丘丌丘 = 0f;
            this.下丑丅丈三下丄丞丌 = 0f;
            this.丝丞丛与丞三丄丄丕 = 0f;
        }
        private void 三丟丁一万七下且万()
        {
            float val_22;
            var val_23;
            var val_24;
            float val_25;
            UnityEngine.AI.NavMeshAgent val_26;
            var val_27;
            if(this.丈三世丕丛丄丙丏业 == true)
            {
                    return;
            }
            
            if((this.丗丛一丁丌与丟东丙.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
            if(this.currentTarget == 0)
            {
                    return;
            }
            
            if(this.丗下丘世三七一专丕 != 2)
            {
                goto label_23;
            }
            
            val_22 = this.丗丛一丁丌与丟东丙.delayForStartShooting;
            if(val_22 > 0f)
            {
                    val_22 = this.不丗丝且上丟丘丌丘;
                if(val_22 <= 0f)
            {
                    val_22 = this.丝丞丛与丞三丄丄丕;
                if(val_22 <= 0f)
            {
                    val_22 = this.下丑丅丈三下丄丞丌;
                if(val_22 <= 0f)
            {
                    if(this.丞丆丛丕丗东丙丅丑 != 0)
            {
                    if(this.丞丆丛丕丗东丙丅丑.CanPrepareForAttack == false)
            {
                goto label_17;
            }
            
            }
            
                this.不丗丝且上丟丘丌丘 = this.丗丛一丁丌与丟东丙.delayForStartShooting;
            }
            
            }
            
            }
            
            }
            
            label_17:
            if(this.丞丆丛丕丗东丙丅丑 != 0)
            {
                    if(this.丞丆丛丕丗东丙丅丑.CanPrepareForAttack != false)
            {
                    val_23 = this.currentTarget;
            }
            
            }
            
            label_23:
            if(this.不丗丝且上丟丘丌丘 > 0f)
            {
                    val_22 = this.不丗丝且上丟丘丌丘 - UnityEngine.Time.deltaTime;
                this.不丗丝且上丟丘丌丘 = val_22;
                if(val_22 > 0f)
            {
                    this.丗下丘世三七一专丕 = 5;
                if(this.丗丛一丁丌与丟东丙 != null)
            {
                goto label_29;
            }
            
            }
            else
            {
                    this.不丗丝且上丟丘丌丘 = 0f;
                this.丝丞丛与丞三丄丄丕 = this.丗丛一丁丌与丟东丙.delayForContinuousShooting;
            }
            
            }
            
            label_29:
            if(this.丝丞丛与丞三丄丄丕 <= 0f)
            {
                goto label_55;
            }
            
            float val_9 = UnityEngine.Time.deltaTime;
            val_9 = this.丝丞丛与丞三丄丄丕 - val_9;
            this.丝丞丛与丞三丄丄丕 = val_9;
            val_22 = this.丗丛一丁丌与丟东丙.timeForShootMinigun;
            if(val_22 <= 0f)
            {
                goto label_34;
            }
            
            val_22 = this.丏丕丏世丏三上丞七 - UnityEngine.Time.deltaTime;
            this.丏丕丏世丏三上丞七 = val_22;
            if(val_22 > 0f)
            {
                goto label_34;
            }
            
            if(this.丗丛一丁丌与丟东丙 == null)
            {
                goto label_47;
            }
            
            val_23 = 1152921505353756672;
            if(this.currentTarget != 0)
            {
                    if(this.丗丛一丁丌与丟东丙 != null)
            {
                    val_24 = null;
                val_24 = null;
                var val_15 = (((RilisoftBot.BaseBot.__il2cppRuntimeField_typeHierarchy + (RilisoftBot.BaseShootingBot.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_24) ? this.丗丛一丁丌与丟东丙 : 0;
            }
            
                0.丟丑丙七丁三丞丕丁(丞下万上三丘上与专:  this.currentTarget.gameObject);
            }
            
            if(this.丗丛一丁丌与丟东丙 == null)
            {
                goto label_47;
            }
            
            this.丏丕丏世丏三上丞七 = this.丗丛一丁丌与丟东丙.timeForShootMinigun;
            label_34:
            this.丗下丘世三七一专丕 = 2;
            if(this.丝丞丛与丞三丄丄丕 <= 0f)
            {
                goto label_49;
            }
            
            if(this.丗丛一丁丌与丟东丙.minigun == 0)
            {
                goto label_55;
            }
            
            this.丗丛一丁丌与丟东丙.minigun.丐丁不丅丁丝丑业丏();
            goto label_55;
            label_49:
            this.下丑丅丈三下丄丞丌 = this.丗丛一丁丌与丟东丙.delayAfterContinuousShooting;
            this.丝丞丛与丞三丄丄丕 = 0f;
            label_55:
            val_25 = this.下丑丅丈三下丄丞丌;
            if(val_25 <= 0f)
            {
                    return;
            }
            
            float val_17 = UnityEngine.Time.deltaTime;
            val_17 = val_25 - val_17;
            this.下丑丅丈三下丄丞丌 = val_17;
            if(this.丗下丘世三七一专丕 == 2)
            {
                    this.丗下丘世三七一专丕 = 3;
                if(this.丛丐丌丆下丙丌万丏 != 3)
            {
                    UnityEngine.Vector3 val_19 = this.currentTarget.position;
                val_25 = val_19.z;
                UnityEngine.Vector3 val_21 = this.丌丟丄业且三丛丕丄().position;
                this.丗丛一丁丌与丟东丙.OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_19.x, y = val_21.y, z = val_25});
            }
            
                val_26 = this.上丙丁丕丑丌丂下丅;
                val_27 = 1;
            }
            else
            {
                    val_26 = this.上丙丁丕丑丌丂下丅;
                val_27 = 0;
            }
            
            val_26.isStopped = false;
            return;
            label_47:
        }
        private void 专丙且七丝丏丞丌下()
        {
            var val_4;
            if(this.上丙丁丕丑丌丂下丅.path == null)
            {
                    return;
            }
            
            if(this.上丙丁丕丑丌丂下丅.isOnOffMeshLink == true)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                    return;
            }
            
            }
            
            this.上丙丁丕丑丌丂下丅.ResetPath();
        }
        private UnityEngine.Transform 丌丟丄业且三丛丕丄()
        {
            UnityEngine.Transform val_3;
            if(this.专专丏下丐丂丂丅东 == 0)
            {
                    this.专专丏下丐丂丂丅东 = this.transform;
                return val_3;
            }
            
            val_3 = this.专专丏下丐丂丂丅东;
            return val_3;
        }
        internal UnityEngine.AI.NavMeshAgent 丅不丂下丐专丙丗丗()
        {
            if(this == 0)
            {
                    return 0;
            }
            
            if(this.上丙丁丕丑丌丂下丅 == 0)
            {
                    this.上丙丁丕丑丌丂下丅 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
                return 0;
            }
            
            0 = this.上丙丁丕丑丌丂下丅;
            return 0;
        }
        public bool get_IsCanMove()
        {
            return (bool)this.下三丗丒专丐丘丐丆;
        }
        public void set_IsCanMove(bool 丙业与丙丗丝不丈东)
        {
            var val_1 = (this.下三丗丒专丐丘丐丆 == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            this.下三丗丒专丐丘丐丆 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            this.世万丑丆丕三丝丆一 = -1f;
            this.丗丛一丁丌与丟东丙.PlayAnimZombieWalkByMode();
        }
        private void 与七丗且丑丛专万专()
        {
            this.世万丑丆丕三丝丆一 = -1f;
            if(this.丝下丌丞丆丒不丒丂 != false)
            {
                    if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                goto label_2;
            }
            
            }
            
            this.IsCanMove = (this.isStationary == false) ? 1 : 0;
            return;
            label_2:
            this.丗丛一丁丌与丟东丙.PlayAnimZombieWalkByMode();
            if(this.下三丗丒专丐丘丐丆 == false)
            {
                    return;
            }
            
            this.下三丗丒专丐丘丐丆 = false;
        }
        private void 丄丝丙万下丙丐丅且()
        {
            UnityEngine.AI.NavMeshAgent val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            var val_53;
            PatrolModifierController val_54;
            var val_55;
            var val_56;
            val_44 = this;
            if(this.下三丗丒专丐丘丐丆 == false)
            {
                    return;
            }
            
            val_45 = this.世万丑丆丕三丝丆一;
            if(val_45 > UnityEngine.Time.time)
            {
                    return;
            }
            
            this.专丙且七丝丏丞丌下();
            UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
            if(this.丌万丁七丈业丈丗东 == 0)
            {
                    float val_7 = val_3.x + (UnityEngine.Random.Range(min:  -this.minLenghtMove, max:  this.minLenghtMove));
                val_3.z = val_3.z + (UnityEngine.Random.Range(min:  -this.minLenghtMove, max:  this.minLenghtMove));
                this.三丌上七丙丌丅一丘 = 0;
                mem[1152921540977724852] = 0;
            }
            else
            {
                    this.三丌上七丙丌丅一丘 = val_3;
                mem[1152921540977724848] = val_3.y;
                mem[1152921540977724852] = val_3.z;
            }
            
            UnityEngine.Vector3 val_10 = this.丌丟丄业且三丛丕丄().position;
            val_47 = val_10.y;
            float val_11 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_47, z = val_10.z}, b:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = V12.16B, z = V11.16B});
            if(this.丗丛一丁丌与丟东丙.isAutomaticAnimationEnable != false)
            {
                    val_49 = this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
                float val_12 = this.丗丛一丁丌与丟东丙.丗业丐世丄万七丅丐(不丏丒且丟业丑丙业:  val_49);
            }
            else
            {
                    val_47 = this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
                val_49 = this.丗丛一丁丌与丟东丙.notAttackingSpeed * val_47;
            }
            
            val_49 = val_11 / val_49;
            val_49 = UnityEngine.Time.time + val_49;
            this.世万丑丆丕三丝丆一 = val_49;
            if(GameConnect.丅丟下专不丁一丈七() != false)
            {
                    UnityEngine.AI.NavMeshPath val_14 = new UnityEngine.AI.NavMeshPath();
                UnityEngine.Vector3 val_16 = this.丌丟丄业且三丛丕丄().position;
                val_45 = val_16.x;
                val_50 = val_16.y;
                val_51 = val_16.z;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.down;
                val_46 = val_17.y;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_46, z = val_17.z}, d:  this.上丙丁丕丑丌丂下丅.baseOffset);
                val_52 = val_50;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_45, y = val_52, z = val_51}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
                val_53 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, targetPosition:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_19.y, z = val_19.z}, areaMask:  0, path:  val_14);
                bool val_22 = this.上丙丁丕丑丌丂下丅.SetPath(path:  val_14);
            }
            else
            {
                    val_45 = this.三丌上七丙丌丅一丘;
                val_52 = val_11;
                val_53 = this.上丙丁丕丑丌丂下丅.SetDestination(target:  new UnityEngine.Vector3() {x = val_45, y = val_52, z = val_10.y});
            }
            
            val_54 = this.丌万丁七丈业丈丗东;
            if(val_54 == 0)
            {
                goto label_53;
            }
            
            val_54 = this.丌万丁七丈业丈丗东;
            if((val_54 & 1) == 0)
            {
                goto label_53;
            }
            
            val_55 = 5;
            goto label_36;
            label_54:
            val_45 = val_45;
            val_50 = val_52;
            val_51 = val_10.y;
            this.三丌上七丙丌丅一丘 = val_45;
            mem[1152921540977724848] = val_50;
            mem[1152921540977724852] = val_51;
            val_52 = val_50;
            val_53 = this.上丙丁丕丑丌丂下丅.SetDestination(target:  new UnityEngine.Vector3() {x = val_45, y = val_52, z = val_51});
            UnityEngine.AI.NavMeshPath val_26 = new UnityEngine.AI.NavMeshPath();
            UnityEngine.Vector3 val_28 = this.丌丟丄业且三丛丕丄().position;
            if((UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, targetPosition:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = V12.16B, z = V11.16B}, areaMask:  0, path:  val_26)) != false)
            {
                    bool val_30 = this.上丙丁丕丑丌丂下丅.SetPath(path:  val_26);
            }
            
            val_55 = 4;
            goto label_36;
            label_47:
            if(this.上丙丁丕丑丌丂下丅 != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_36:
            val_54 = this.上丙丁丕丑丌丂下丅.path.corners;
            if(val_32.Length == 0)
            {
                goto label_42;
            }
            
            val_54 = this.丌万丁七丈业丈丗东;
            val_56 = 0;
            if(this.上丙丁丕丑丌丂下丅.path.corners == null)
            {
                goto label_47;
            }
            
            label_38:
            int val_44 = val_36.Length;
            val_44 = val_44 - 1;
            if(val_44 >= val_34.Length)
            {
                    val_56 = 0;
            }
            
            val_44 = this.上丙丁丕丑丌丂下丅.path.corners + ((long)val_44 * 12);
            val_52 = ((long)(int)((val_36.Length - 1)) * 12) + val_34 + 32 + 4;
            if(5 < 1)
            {
                goto label_53;
            }
            
            if((val_54 & 1) == 0)
            {
                goto label_54;
            }
            
            goto label_53;
            label_42:
            if(5 > 0)
            {
                goto label_54;
            }
            
            label_53:
            if(val_53 == false)
            {
                goto label_55;
            }
            
            UnityEngine.Vector3 val_38 = this.丌丟丄业且三丛丕丄().position;
            val_51 = val_38.y;
            this.丗丛一丁丌与丟东丙.OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = this.三丌上七丙丌丅一丘, y = val_51, z = val_45});
            if(this.丌万丁七丈业丈丗东 == 0)
            {
                goto label_60;
            }
            
            val_54 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_41 = val_54.position;
            val_51 = val_41.z;
            if((this.丌万丁七丈业丈丗东 & 1) == 0)
            {
                goto label_63;
            }
            
            label_60:
            val_44 = this.上丙丁丕丑丌丂下丅;
            if(this.丗丛一丁丌与丟东丙.isAutomaticAnimationEnable == false)
            {
                goto label_65;
            }
            
            val_45 = this.丗丛一丁丌与丟东丙.丗业丐世丄万七丅丐(不丏丒且丟业丑丙业:  this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上);
            if(val_44 != null)
            {
                goto label_67;
            }
            
            goto label_67;
            label_55:
            this.世万丑丆丕三丝丆一 = 0f;
            return;
            label_65:
            float val_43 = this.丗丛一丁丌与丟东丙.notAttackingSpeed * this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
            if(val_44 != null)
            {
                goto label_67;
            }
            
            goto label_67;
            label_63:
            val_45 = this.speedReturToPatrolPoint;
            label_67:
            this.上丙丁丕丑丌丂下丅.speed = val_45;
        }
        private void 三丈丅七丕丂丟七丄(UnityEngine.Transform 丙业与丙丗丝不丈东)
        {
            this.与丝丁丑丁丌丞丞东 = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.Transform get_currentTarget()
        {
            return (UnityEngine.Transform)(this.onlyPossibleTarget == 0) ? this.onlyPossibleTarget : this.与丝丁丑丁丌丞丞东;
        }
        private float 丑丈丐丟丄丕丞丆丑()
        {
            var val_2;
            if(this.丛丐丌丆下丙丌万丏 != 0)
            {
                    return 0f;
            }
            
            if(this.丗丛一丁丌与丟东丙 == null)
            {
                    return 0.CheckTimeToTakeDamage();
            }
            
            val_2 = null;
            val_2 = null;
            var val_1 = (((RilisoftBot.BaseBot.__il2cppRuntimeField_typeHierarchy + (RilisoftBot.MeleeBot.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_2) ? this.丗丛一丁丌与丟东丙 : 0;
            return 0.CheckTimeToTakeDamage();
        }
        internal bool 丐丄丞万丞东东世丟()
        {
            return (bool)this.一万三一丘丘丒万丟;
        }
        private void 丌丐万丕不丝丐丆丄()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.三丛丌丂一三丗上丛 - val_1;
            this.三丛丌丂一三丗上丛 = val_1;
            if(val_1 > 0f)
            {
                    return;
            }
            
            this.三丛丌丂一三丗上丛 = 1f;
            this.一万三一丘丘丒万丟 = this.丁不丐丐丄丙万丗丆();
        }
        private string 丕丁一丄丐上丅丁世(out UnityEngine.Vector3 丂一不丏世丈三且丘)
        {
            UnityEngine.Object val_31;
            var val_32;
            var val_33;
            var val_34;
            UnityEngine.Transform val_1 = this.currentTarget;
            if((val_1.丄丏下世东东业东丕(丞下万上三丘上与专:  val_1)) <= 6)
            {
                    var val_31 = 106027072 + (val_2) << 2;
                val_31 = val_31 + 106027072;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
                丂一不丏世丈三且丘.x = val_11.x;
                丂一不丏世丈三且丘.y = val_11.y;
                丂一不丏世丈三且丘.z = val_11.z;
                val_31 = 1152921505066536960;
                if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    val_32 = 0;
                if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                    return (string)val_33;
            }
            
            }
            
                val_31 = this.currentTarget;
                if(val_31 != 0)
            {
                    val_34 = this.currentTarget;
                UnityEngine.Vector3 val_28 = transform.position;
                丂一不丏世丈三且丘.x = val_28.x;
                丂一不丏世丈三且丘.y = val_28.y;
                丂一不丏世丈三且丘.z = val_28.z;
            }
            
                val_33 = "Turret";
                return (string)val_33;
            }
        
        }
        internal bool 丁不丐丐丄丙万丗丆()
        {
            RilisoftBot.BaseBot val_17;
            float val_18;
            RilisoftBot.BaseBot val_19;
            float val_20;
            float val_21;
            var val_22;
            val_17 = this;
            val_18 = V1.16B;
            val_19 = this.丗丛一丁丌与丟东丙;
            if((System.String.IsNullOrEmpty(value:  this.丕丁一丄丐上丅丁世(丂一不丏世丈三且丘: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}))) != true)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = val_18, z = V2.16B});
                val_20 = val_3.x;
                val_21 = val_3.z;
                if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = 0f, y = val_18, z = V2.16B}, direction:  new UnityEngine.Vector3() {x = val_20, y = val_3.y, z = val_21}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  0f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞())) != false)
            {
                    val_19 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0f);
                丅丙上七上一丐不下 val_8 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  this.currentTarget);
                if((val_19 != null) && (val_19 == val_8))
            {
                    val_22 = 1;
                return (bool)val_22;
            }
            
                val_19 = this.丗丛一丁丌与丟东丙;
                UnityEngine.Vector3 val_9 = val_19.GetBodyPoint();
                val_17 = this.丗丛一丁丌与丟东丙;
                val_21 = 0f;
                UnityEngine.Vector3 val_10 = val_17.GetBodyPoint();
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_21}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_18 = val_11.y;
                val_20 = val_11.z;
                if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, direction:  new UnityEngine.Vector3() {x = val_11.x, y = val_18, z = val_20}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  0f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞())) != false)
            {
                    丅丙上七上一丐不下 val_14 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0f);
                val_22 = ((val_14 != 0) ? 1 : 0) & ((val_14 == val_8) ? 1 : 0);
                return (bool)val_22;
            }
            
            }
            
            }
            
            val_22 = 0;
            return (bool)val_22;
        }
        private void 专丂丛业下与丆丂丟()
        {
            UnityEngine.AI.NavMeshAgent val_8;
            float val_9;
            if(this.丐丞丑七丅丏世东东 != false)
            {
                    this.丐丞丑七丅丏世东东 = false;
            }
            
            this.上丙丁丕丑丌丂下丅.isStopped = false;
            if((this.丗丛一丁丌与丟东丙.isFlyingSpeedLimit == false) || (this.上丙丁丕丑丌丂下丅.isOnOffMeshLink == false))
            {
                goto label_5;
            }
            
            val_8 = this.上丙丁丕丑丌丂下丅;
            val_9 = this.丗丛一丁丌与丟东丙.maxFlyingSpeed;
            if(val_8 != null)
            {
                goto label_16;
            }
            
            goto label_17;
            label_5:
            val_8 = this.上丙丁丕丑丌丂下丅;
            if(this.丗丛一丁丌与丟东丙.isAutomaticAnimationEnable == false)
            {
                goto label_10;
            }
            
            val_9 = this.丗丛一丁丌与丟东丙.丞与与丕丄丘丞丛丑(不丏丒且丟业丑丙业:  this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上);
            if(val_8 != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            val_8.speed = val_9;
            UnityEngine.Vector3 val_4 = this.currentTarget.position;
            bool val_5 = this.上丙丁丕丑丌丂下丅.SetDestination(target:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            if(this.丛丐丌丆下丙丌万丏 == 0)
            {
                    this.且丌丌丏丕丄丁一丘 = this.丑丈丐丟丄丕丞丆丑();
            }
            
            this.丗丛一丁丌与丟东丙.PlayAnimZombieWalkByMode();
            return;
            label_10:
            float val_7 = this.丗丛一丁丌与丟东丙.attackingSpeed * this.丗丛一丁丌与丟东丙.丈丁丆丈丁丁丆丄上;
            if(val_8 != null)
            {
                goto label_16;
            }
            
            goto label_17;
        }
        private RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丐一丞不丏七专一且()
        {
            var val_18;
            var val_19;
            if((this.丗丛一丁丌与丟东丙.<丄上丐丝东丘丅丙丈>k__BackingField) != true)
            {
                    if(this.currentTarget != 0)
            {
                goto label_5;
            }
            
            }
            
            return 6;
            label_5:
            if(this.isTeleportationMove == false)
            {
                goto label_6;
            }
            
            if(this.上上丆丝丘丏丅不丟 <= 0f)
            {
                goto label_7;
            }
            
            float val_3 = UnityEngine.Time.deltaTime;
            val_3 = this.上上丆丝丘丏丅不丟 - val_3;
            this.上上丆丝丘丏丅不丟 = val_3;
            label_6:
            if(this.丛丐丌丆下丙丌万丏 != 3)
            {
                goto label_15;
            }
            
            if(this.丗丛一丁丌与丟东丙 == null)
            {
                goto label_9;
            }
            
            val_18 = null;
            val_18 = null;
            var val_4 = (((RilisoftBot.BaseBot.__il2cppRuntimeField_typeHierarchy + (RilisoftBot.KamikadzeBot.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_18) ? this.丗丛一丁丌与丟东丙 : 0;
            goto label_13;
            label_7:
            this.上上丆丝丘丏丅不丟 = this.timeToNextTeleport;
            return 6;
            label_9:
            val_19 = 0;
            label_13:
            if(val_19.业专丗丆三丐丕业丑() != false)
            {
                    return 6;
            }
            
            label_15:
            UnityEngine.Vector3 val_7 = this.currentTarget.position;
            UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            float val_13 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            if((this.丗丛一丁丌与丟东丙 & 1) != 0)
            {
                    丄丞丙丄丁东丈下万 val_18 = this.丛丐丌丆下丙丌万丏;
                val_18 = val_18 - 1;
                if(val_18 > 1)
            {
                    return 6;
            }
            
                this.丌丐万丕不丝丐丆丄();
                bool val_14 = this.一万三一丘丘丒万丟 + 15;
                var val_16 = (this.isStationary == false) ? ((this.isStationary == true) ? 3 : (0 + 1)) : 2;
                return 6;
            }
            
            var val_17 = (this.isStationary == true) ? 3 : (0 + 1);
            return 6;
        }
        private void 七下丁七丗丘丙丏丂()
        {
            if(this.isTeleportationMove == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.effectTeleport);
            this.专丂东不下一且丆不 = val_1;
            UnityEngine.Transform val_2 = val_1.transform;
            val_2.parent = this.transform;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            val_2.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            val_2.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            this.专丂东不下一且丆不.SetActive(value:  false);
        }
        private System.Collections.IEnumerator 丐专丒上七丒丆丁丁(float 丆丐七丅丆丗丛上与)
        {
            BotAiController.业世丂丟丞丈丗丁丐 val_1 = new BotAiController.业世丂丟丞丈丗丁丐(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丙上丌不丆上丏丝七()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BotAiController.丝丆丏丑丌世万丞丄(丗丏丅丕丆世丁专丟:  0);
        }
        private UnityEngine.Vector3 丟丂丟丁丈专丅万世()
        {
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            var val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            var val_38;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            float val_5 = UnityEngine.Random.value;
            if((val_5 < 0f) || (val_5 >= 0))
            {
                goto label_10;
            }
            
            label_33:
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  0f, y:  this.angleByPlayerLook, z:  0f);
            val_22 = val_6.z;
            val_23 = val_6.w;
            UnityEngine.Vector3 val_8 = this.currentTarget.position;
            val_24 = val_8.x;
            val_25 = val_8.y;
            val_26 = val_8.z;
            val_27 = this.currentTarget;
            UnityEngine.Vector3 val_10 = val_27.forward;
            val_31 = null;
            val_32 = val_10.x;
            val_33 = val_10.y;
            val_34 = val_10.z;
            goto label_30;
            label_10:
            if((val_5 < 0.4f) || (val_5 >= 0))
            {
                goto label_18;
            }
            
            val_35 = 0f;
            val_36 = 0f;
            val_37 = this.angleByPlayerLook;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(x:  val_35, y:  val_37, z:  val_36);
            val_22 = val_11.z;
            val_23 = val_11.w;
            UnityEngine.Vector3 val_13 = this.currentTarget.forward;
            val_32 = val_13.x;
            val_33 = val_13.y;
            val_38 = val_13.z;
            goto label_22;
            label_18:
            if((val_5 < 0.5f) || (val_5 >= 0))
            {
                goto label_33;
            }
            
            UnityEngine.Vector3 val_15 = this.currentTarget.forward;
            val_32 = val_15.x;
            val_33 = val_15.y;
            val_38 = val_15.z;
            val_37 = -this.angleByPlayerLook;
            val_35 = 0f;
            val_36 = 0f;
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(x:  val_35, y:  val_37, z:  val_36);
            val_22 = val_16.z;
            val_23 = val_16.w;
            label_22:
            val_27 = this.currentTarget;
            val_34 = -val_38;
            UnityEngine.Vector3 val_18 = val_27.position;
            val_31 = null;
            val_24 = val_18.x;
            val_25 = val_18.y;
            val_26 = val_18.z;
            label_30:
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34}, d:  UnityEngine.Random.Range(min:  this.丗丛一丁丌与丟东丙.attackDistance + this.DeltaTeleportAttackDistance[0], max:  this.丗丛一丁丌与丟东丙.attackDistance + this.DeltaTeleportAttackDistance[1]));
            UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_22, w = val_23}, point:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        }
        private bool 下丙丐丂下丄丌丂丘()
        {
            var val_2;
            float val_3;
            if(this.isTeleportationMove == false)
            {
                goto label_0;
            }
            
            if(this.上上丆丝丘丏丅不丟 <= 0f)
            {
                goto label_1;
            }
            
            val_2 = 0;
            val_3 = this.上上丆丝丘丏丅不丟 - UnityEngine.Time.deltaTime;
            goto label_2;
            label_0:
            val_2 = 0;
            return (bool)val_2;
            label_1:
            val_3 = this.timeToNextTeleport;
            val_2 = 1;
            label_2:
            this.上上丆丝丘丏丅不丟 = val_3;
            return (bool)val_2;
        }
        public void SetTargetToMove(UnityEngine.Transform 丞下万上三丘上与专)
        {
            string val_17;
            var val_18;
            var val_19;
            if(this.isDetectPlayer == false)
            {
                    return;
            }
            
            if(PolygonController.一下一万丄丅丘且丑 != 0)
            {
                    val_17 = PolygonController.一下一万丄丅丘且丑;
                if((PolygonController.一下一万丄丅丘且丑 + 24) != 0)
            {
                    return;
            }
            
            }
            
            if(this.currentTarget == 丞下万上三丘上与专)
            {
                goto label_14;
            }
            
            this.专丙且七丝丏丞丌下();
            bool val_4 = UnityEngine.Object.op_Inequality(x:  丞下万上三丘上与专, y:  0);
            if(this.丗丛一丁丌与丟东丙 == null)
            {
                goto label_12;
            }
            
            if(val_4 == false)
            {
                goto label_13;
            }
            
            label_15:
            this.丗丛一丁丌与丟东丙.PlayAnimZombieWalkByMode();
            goto label_14;
            label_12:
            if(val_4 == true)
            {
                goto label_15;
            }
            
            label_13:
            this.丗丛一丁丌与丟东丙.PlayAnimationWalk();
            label_14:
            this.与丝丁丑丁丌丞丞东 = 丞下万上三丘上与专;
            if(this.东万三丈万丗专业专 != 0)
            {
                goto label_18;
            }
            
            if(丞下万上三丘上与专 != 0)
            {
                goto label_21;
            }
            
            var val_7 = (this.isStationary != true) ? 1 : 0;
            goto label_22;
            label_18:
            val_17 = this.currentTarget;
            if(val_17 == 0)
            {
                    return;
            }
            
            if(丞下万上三丘上与专 != 0)
            {
                goto label_28;
            }
            
            label_35:
            var val_11 = (this.isStationary != true) ? 1 : 0;
            goto label_29;
            label_21:
            val_18 = 0;
            label_22:
            this.IsCanMove = false;
            return;
            label_28:
            if(this.东万三丈万丗专业专 == 0)
            {
                goto label_32;
            }
            
            UnityEngine.Vector3 val_14 = this.currentTarget.position;
            if((this.东万三丈万丗专业专 & 1) == 0)
            {
                goto label_35;
            }
            
            label_32:
            val_19 = 0;
            label_29:
            this.IsCanMove = false;
            val_17 = this.currentTarget;
            UnityEngine.Vector3 val_16 = val_17.position;
            if((this.东万三丈万丗专业专 & 1) != 0)
            {
                    return;
            }
            
            this.丟一丕丄丄世丏丌三 = false;
        }
        private void 丐不三七丞丑与丟丗()
        {
            RilisoftBot.BaseBot val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            var val_28;
            var val_29;
            if(this.丞丆丛丕丗东丙丅丑 != 0)
            {
                    if(this.丞丆丛丕丗东丙丅丑.CanStartAttack == false)
            {
                    return;
            }
            
            }
            
            if(this.丐丞丑七丅丏世东东 != false)
            {
                    this.丐丞丑七丅丏世东东 = false;
            }
            
            this.专丙且七丝丏丞丌下();
            if(this.丛丐丌丆下丙丌万丏 == 3)
            {
                    val_23 = this.丗丛一丁丌与丟东丙;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = this.currentTarget.position;
                val_24 = val_4.z;
                UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
                val_23 = this;
                val_25 = val_6.y;
                this.丗丛一丁丌与丟东丙.OrientToTarget(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_4.x, y = val_25, z = val_24});
            }
            
            null.PlayAnimZombieAttackOrStopByMode();
            if(this.丛丐丌丆下丙丌万丏 == 0)
            {
                    UnityEngine.Vector3 val_8 = this.transform.position;
                val_24 = val_8.x;
                val_25 = val_8.z;
                UnityEngine.Vector3 val_10 = this.currentTarget.position;
                val_26 = val_24;
                if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_26, y = val_8.y, z = val_25}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) > this._distanceForStopMoving)
            {
                    UnityEngine.Vector3 val_13 = this.currentTarget.position;
                val_24 = val_13.x;
                val_25 = val_13.z;
                val_26 = val_24;
                bool val_14 = this.上丙丁丕丑丌丂下丅.SetDestination(target:  new UnityEngine.Vector3() {x = val_26, y = val_13.y, z = val_25});
            }
            else
            {
                    this.上丙丁丕丑丌丂下丅.isStopped = true;
            }
            
                if(this.丞丆丛丕丗东丙丅丑 == 0)
            {
                    val_24 = this.且丌丌丏丕丄丁一丘;
                float val_16 = UnityEngine.Time.deltaTime;
                val_16 = val_24 - val_16;
                this.且丌丌丏丕丄丁一丘 = val_16;
                if(val_16 <= 0f)
            {
                    this.丗丛一丁丌与丟东丙.MakeDamage(丞下万上三丘上与专:  this.currentTarget, 丟丒丅东丙丛丏丏与:  this.丗丛一丁丌与丟东丙.damagePerHit);
                this.且丌丌丏丕丄丁一丘 = this.丑丈丐丟丄丕丞丆丑();
            }
            
            }
            
            }
            
            val_27 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  null)) == false)
            {
                    return;
            }
            
            val_28 = null;
            val_28 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  213, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
                return;
            }
            
            if(null != null)
            {
                    val_29 = null;
                val_29 = null;
                var val_22 = (((mem[this.丗丛一丁丌与丟东丙] + 200 + (RilisoftBot.KamikadzeBot.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_29) ? (null) : 0;
            }
            
            0.一东专丅业丂丐上与();
        }
        private bool 丆丈丝且上丂丅专专()
        {
            return (bool)this.丐丞丑七丅丏世东东;
        }
        private void 丕丕丏丁丐丞丒丕丂(bool 丙业与丙丗丝不丈东)
        {
            var val_1 = (this.丐丞丑七丅丏世东东 == true) ? 1 : 0;
            val_1 = val_1 ^ 丙业与丙丗丝不丈东;
            if(val_1 == false)
            {
                    return;
            }
            
            this.丐丞丑七丅丏世东东 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            this.丗丛一丁丌与丟东丙.PlayAnimationIdle();
        }
        private RilisoftBot.BotAiController.且业且丙上三与东丕 丄丏下世东东业东丕(UnityEngine.Transform 丞下万上三丘上与专)
        {
            var val_7;
            if((丞下万上三丘上与专.CompareTag(tag:  "Player")) != false)
            {
                    val_7 = 0;
                return (且业且丙上三与东丕)((丞下万上三丘上与专.CompareTag(tag:  "DamageableObject")) != true) ? 6 : 3;
            }
            
            if((丞下万上三丘上与专.CompareTag(tag:  "Turret")) != false)
            {
                    val_7 = 1;
                return (且业且丙上三与东丕)((丞下万上三丘上与专.CompareTag(tag:  "DamageableObject")) != true) ? 6 : 3;
            }
            
            if((丞下万上三丘上与专.CompareTag(tag:  "Enemy")) != false)
            {
                    val_7 = 2;
                return (且业且丙上三与东丕)((丞下万上三丘上与专.CompareTag(tag:  "DamageableObject")) != true) ? 6 : 3;
            }
            
            if((丞下万上三丘上与专.CompareTag(tag:  "Pet")) == false)
            {
                    return (且业且丙上三与东丕)((丞下万上三丘上与专.CompareTag(tag:  "DamageableObject")) != true) ? 6 : 3;
            }
            
            val_7 = 4;
            return (且业且丙上三与东丕)((丞下万上三丘上与专.CompareTag(tag:  "DamageableObject")) != true) ? 6 : 3;
        }
        private void 且丘丈东丟万丁丟丙()
        {
            if(this.isDetectPlayer == false)
            {
                    return;
            }
            
            if(this.丝下丌丞丆丒不丒丂 != false)
            {
                    float val_1 = UnityEngine.Time.deltaTime;
                val_1 = this.丗不丘专丑丄丌丟丄 - val_1;
                this.丗不丘专丑丄丌丟丄 = val_1;
                if(val_1 > 0f)
            {
                    return;
            }
            
                this.丗不丘专丑丄丌丟丄 = 3f;
                this.丁世世丕上专丕一上();
                return;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.丌上世丝三专业下丗 - val_2;
            this.丌上世丝三专业下丗 = val_2;
            if(val_2 > 0f)
            {
                    return;
            }
            
            this.丕丅东丅丂丟丘丅丒();
        }
        private bool 不丛丘下世三丂上丘()
        {
            var val_3;
            if(this.丂丅与丕丁丛东丌丗 != false)
            {
                    if((this.专丙专丙丞丑丅丕丘(丞下万上三丘上与专:  this.currentTarget)) != false)
            {
                    this.SetTargetToMove(丞下万上三丘上与专:  0);
                this.丂丅与丕丁丛东丌丗 = false;
            }
            
                val_3 = 1;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        private void 丁世世丕上专丕一上()
        {
            UnityEngine.Transform val_11;
            UnityEngine.Object val_12;
            bool val_2 = false;
            if(this.不丛丘下世三丂上丘() == true)
            {
                    return;
            }
            
            val_11 = this.onlyPossibleTarget;
            val_12 = this.丕丟丘丟丂丗丘三丆(丙业且三丂业丟丟丏: out  val_2);
            if(val_11 != 0)
            {
                    val_12 = this.onlyPossibleTarget.gameObject;
            }
            
            if(val_12 != 0)
            {
                    if(val_2 != 0)
            {
                    float val_7 = this.丗丐三丟丏一与七丒(丁一且丂世丏丒七且:  val_12);
            }
            else
            {
                    float val_8 = this.丞业丘丈丒丘七下丁(且丌下丈专不丕三七:  val_12);
            }
            
                if(val_8 != (-1f))
            {
                    val_11 = this.丗丛一丁丌与丟东丙;
                if(this.丗丛一丁丌与丟东丙.detectRadius >= val_8)
            {
                    if((this.专丙专丙丞丑丅丕丘(丞下万上三丘上与专:  val_12.transform)) == false)
            {
                goto label_16;
            }
            
            }
            
            }
            
            }
            
            label_16:
            this.SetTargetToMove(丞下万上三丘上与专:  0);
        }
        private void 丕丅东丅丂丟丘丅丒()
        {
            var val_7;
            var val_26;
            var val_57;
            var val_58;
            var val_59;
            WeaponManager val_60;
            var val_61;
            ScenarioController val_62;
            var val_63;
            float val_64;
            float val_65;
            float val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            System.Collections.Generic.List<UnityEngine.GameObject> val_72;
            var val_73;
            UnityEngine.GameObject val_74;
            var val_75;
            var val_76;
            UnityEngine.GameObject val_77;
            var val_78;
            var val_79;
            var val_80;
            UnityEngine.Transform val_81;
            if(this.不丛丘下世三丂上丘() == true)
            {
                    return;
            }
            
            if(this.丟一丕丄丄世丏丌三 != false)
            {
                    if((this.专丙专丙丞丑丅丕丘(丞下万上三丘上与专:  this.currentTarget)) == false)
            {
                    return;
            }
            
                this.SetTargetToMove(丞下万上三丘上与专:  0);
                this.丟一丕丄丄世丏丌三 = false;
                return;
            }
            
            val_57 = 1152921504848912384;
            if((CampaignBaseController.丄丘七三上丕世丞业 == 0) || (this.checkCampaignBase == false))
            {
                goto label_8;
            }
            
            List.Enumerator<T> val_5 = GetEnumerator();
            val_58 = 0;
            var val_57 = 0;
            label_38:
            if((2015120176 & 1) == 0)
            {
                goto label_11;
            }
            
            List.Enumerator<T> val_9 = val_7.丐丏七丌丕丗业且上().GetEnumerator();
            label_24:
            label_22:
            if((2015120144 & 1) == 0)
            {
                goto label_14;
            }
            
            string val_10 = val_7.丐丏七丌丕丗业且上();
            UnityEngine.Vector3 val_12 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_14 = val_10.transform.position;
            float val_15 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            if(((1E+08f) <= val_15) || (this.丗丛一丁丌与丟东丙.detectRadius < val_15))
            {
                goto label_22;
            }
            
            UnityEngine.GameObject val_16 = val_10.gameObject;
            goto label_24;
            label_14:
            val_57 = val_57 + 1;
            mem2[0] = 190;
            val_59 = val_58;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_57 == 1) || ((1152921540981705392 + ((0 + 1)) << 2) != 190))
            {
                goto label_35;
            }
            
            var val_58 = 0;
            val_58 = val_58 ^ (val_57 >> 31);
            val_57 = val_57 + val_58;
            goto label_38;
            label_35:
            if( == 0)
            {
                goto label_38;
            }
            
            goto label_38;
            label_8:
            val_60 = 0;
            val_61 = 0;
            label_180:
            val_62 = ScenarioController.丄丘七三上丕世丞业;
            if(val_62 == 0)
            {
                goto label_84;
            }
            
            val_62 = this.东万三丈万丗专业专;
            if(val_62 == 0)
            {
                goto label_84;
            }
            
            val_62 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            if(val_62 == 0)
            {
                goto label_84;
            }
            
            val_62 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            if(val_21.上丞丟丏万丝且丆下 == null)
            {
                goto label_84;
            }
            
            ScenarioZoneSettings val_22 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            val_62 = val_22.上丞丟丏万丝且丆下;
            if(val_22.上丞丟丏万丝且丆下.typeSpawn != 5)
            {
                goto label_84;
            }
            
            ScenarioZoneSettings val_23 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            val_62 = val_23.丗丂丄丕丞丁下东丌;
            List.Enumerator<T> val_24 = val_62.GetEnumerator();
            label_67:
            if((2015120112 & 1) == 0)
            {
                goto label_59;
            }
            
            val_62 = val_26.丐丏七丌丕丗业且上();
            val_63 = val_62.transform;
            UnityEngine.Vector3 val_29 = val_63.position;
            val_64 = val_29.x;
            val_65 = val_29.z;
            val_66 = val_64;
            if(((this.东万三丈万丗专业专 & 1) == 0) || ((val_62.CurrentCapturePoint <= 0f) || (null != null)))
            {
                goto label_67;
            }
            
            this.丟一丕丄丄世丏丌三 = true;
            val_57 = 1152921504848912384;
            this.SetTargetToMove(丞下万上三丘上与专:  val_62.transform);
            val_67 = 0 + 1;
            mem2[0] = 936;
            goto label_70;
            label_11:
            val_57 = val_57 + 1;
            mem2[0] = 215;
            goto label_69;
            label_59:
            val_67 = 0 + 1;
            mem2[0] = 446;
            val_57 = 1152921504848912384;
            label_70:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_67 == 1)
            {
                goto label_79;
            }
            
            if((1152921540981705392 + ((0 + 1)) << 2) == 936)
            {
                    return;
            }
            
            if( == 0)
            {
                goto label_84;
            }
            
            if((1152921540981705392 + ((0 + 1)) << 2) != 446)
            {
                goto label_82;
            }
            
            goto label_84;
            label_79:
            if( == 0)
            {
                goto label_84;
            }
            
            label_82:
            label_84:
            if(GameConnect.七丂万专且丏丘一丙() != true)
            {
                    if(GameConnect.丅丟下专不丁一丈七() == false)
            {
                goto label_90;
            }
            
            }
            
            val_68 = null;
            val_68 = null;
            val_60 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_60 == 0)
            {
                    return;
            }
            
            val_69 = null;
            val_69 = null;
            val_60 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_60 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_60 == 0)
            {
                    return;
            }
            
            val_70 = null;
            val_70 = null;
            val_60 = 与丆一业七与不不丄();
            if(val_60 == 0)
            {
                    return;
            }
            
            label_90:
            val_71 = null;
            val_71 = null;
            val_72 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕;
            if(val_72 == null)
            {
                goto label_115;
            }
            
            val_72 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕;
            if(val_72 == null)
            {
                    val_72 = 0;
            }
            
            if(val_72.Count == 0)
            {
                goto label_115;
            }
            
            val_73 = null;
            val_73 = null;
            val_74 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.Item[0];
            goto label_119;
            label_115:
            val_74 = 0;
            label_119:
            val_64 = this.丞业丘丈丒丘七下丁(且丌下丈专不丕三七:  val_74);
            if(val_64 == (-1f))
            {
                    val_75 = 0;
            }
            else
            {
                    val_66 = this.丗丛一丁丌与丟东丙.detectRadius;
                var val_41 = (val_66 >= val_64) ? 1 : 0;
            }
            
            val_76 = null;
            val_76 = null;
            val_77 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
            val_77 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
            float val_42 = this.丗丐三丟丏一与七丒(丁一且丂世丏丒七且:  val_77);
            if(val_42 == (-1f))
            {
                    val_78 = 0;
            }
            else
            {
                    val_66 = this.丗丛一丁丌与丟东丙.detectRadius;
                var val_43 = (val_66 >= val_42) ? 1 : 0;
            }
            
            val_79 = null;
            val_79 = null;
            val_62 = 0;
            if(与丆一业七与不不丄() != 0)
            {
                    val_80 = null;
                val_80 = null;
                val_62 = 与丆一业七与不不丄().gameObject;
            }
            
            val_65 = this.丞业丘丈丒丘七下丁(且丌下丈专不丕三七:  val_62);
            if(val_65 == (-1f))
            {
                    val_63 = 0;
            }
            
            if((val_43 & val_41) == 0)
            {
                goto label_144;
            }
            
            if(val_42 < 0)
            {
                goto label_151;
            }
            
            label_166:
            val_77 = val_74;
            if(val_74 != 0)
            {
                goto label_168;
            }
            
            goto label_169;
            label_144:
            if((val_43 & (UnityEngine.Object.op_Inequality(x:  0, y:  0))) == false)
            {
                goto label_150;
            }
            
            if(val_42 < 0)
            {
                goto label_151;
            }
            
            label_165:
            val_77 = 0;
            if(0 != 0)
            {
                goto label_168;
            }
            
            goto label_169;
            label_150:
            if(val_43 == 0)
            {
                goto label_154;
            }
            
            label_151:
            if(null != 0)
            {
                goto label_168;
            }
            
            label_169:
            label_168:
            val_81 = transform;
            label_170:
            val_60 = this.onlyPossibleTarget;
            if(val_60 != 0)
            {
                    val_81 = this.onlyPossibleTarget;
            }
            
            if(val_81 == 0)
            {
                    return;
            }
            
            this.丟一丕丄丄世丏丌三 = true;
            this.SetTargetToMove(丞下万上三丘上与专:  val_81);
            return;
            label_154:
            if(0 == 0)
            {
                goto label_164;
            }
            
            goto label_165;
            label_164:
            if(val_41 != 0)
            {
                goto label_166;
            }
            
            if(((this.丗丛一丁丌与丟东丙.detectRadius >= val_65) ? 1 : 0) == 0)
            {
                goto label_170;
            }
            
            if(val_62 != null)
            {
                goto label_168;
            }
            
            goto label_169;
            label_69:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_57 == 1) || ((1152921540981705392 + ((0 + 1)) << 2) != 215))
            {
                goto label_176;
            }
            
            var val_59 = 0;
            val_59 = val_59 ^ (val_57 >> 31);
            val_57 = val_57 + val_59;
            goto label_180;
            label_176:
            if( == 0)
            {
                goto label_180;
            }
            
            goto label_180;
        }
        private float 丗丐三丟丏一与七丒(UnityEngine.GameObject 丁一且丂世丏丒七且)
        {
            if(丁一且丂世丏丒七且 == 0)
            {
                    return -1f;
            }
            
            UnityEngine.Transform val_2 = 丁一且丂世丏丒七且.transform;
            if((val_2.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_2, 专丐丛丆与专世丆丂:  0)) != false)
            {
                    return -1f;
            }
            
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_6 = val_2.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        }
        private float 丞业丘丈丒丘七下丁(UnityEngine.GameObject 且丌下丈专不丕三七)
        {
            if(且丌下丈专不丕三七 == 0)
            {
                    return -1f;
            }
            
            UnityEngine.Transform val_2 = 且丌下丈专不丕三七.transform;
            bool val_3 = val_2.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_2, 专丐丛丆与专世丆丂:  1);
            if(val_3 != false)
            {
                    bool val_4 = val_3.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_2, 专丐丛丆与专世丆丂:  4);
                if(val_4 != false)
            {
                    if((val_4.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_2, 专丐丛丆与专世丆丂:  5)) == true)
            {
                    return -1f;
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_7 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_8 = val_2.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        private UnityEngine.GameObject 丕丟丘丟丂丗丘三丆(out bool 丙业且三丂业丟丟丏)
        {
            var val_11;
            System.Collections.Generic.List<UnityEngine.GameObject> val_50;
            var val_51;
            float val_52;
            float val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            float val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            丙业且三丂业丟丟丏 = false;
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_42;
            }
            
            val_50 = 1152921504848912384;
            if(((ScenarioController.丄丘七三上丕世丞业 == 0) || (this.东万三丈万丗专业专 == 0)) || (ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世() == 0))
            {
                goto label_42;
            }
            
            ScenarioZoneSettings val_6 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            if(val_6.上丞丟丏万丝且丆下 == null)
            {
                goto label_42;
            }
            
            ScenarioZoneSettings val_7 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            if(val_7.上丞丟丏万丝且丆下.typeSpawn != 5)
            {
                goto label_42;
            }
            
            ScenarioZoneSettings val_8 = ScenarioController.丄丘七三上丕世丞业.一丁丐丒与东丟丅世();
            List.Enumerator<T> val_9 = val_8.丗丂丄丕丞丁下东丌.GetEnumerator();
            val_51 = 1152921540056568528;
            label_32:
            if((2015751008 & 1) == 0)
            {
                goto label_24;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            val_50 = val_12.transform;
            UnityEngine.Vector3 val_14 = val_50.position;
            val_52 = val_14.x;
            val_53 = val_14.z;
            if(((this.东万三丈万丗专业专 & 1) == 0) || ((val_12.CurrentCapturePoint <= 0f) || (null != null)))
            {
                goto label_32;
            }
            
            丙业且三丂业丟丟丏 = false;
            val_54 = val_12.gameObject;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (UnityEngine.GameObject)val_54;
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_42:
            val_51 = 1152921505189965824;
            val_55 = null;
            val_55 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count < 1)
            {
                goto label_46;
            }
            
            val_56 = 0;
            val_54 = 0;
            goto label_47;
            label_69:
            val_57 = null;
            val_57 = null;
            Player_move_c val_18 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if((val_18.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_18)) != true)
            {
                    UnityEngine.Vector3 val_21 = this.丌丟丄业且三丛丕丄().position;
                val_58 = null;
                val_53 = val_21.z;
                val_58 = null;
                Player_move_c val_22 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_23 = val_22.myPlayerTransform.position;
                val_59 = val_23.y;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_53}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_59, z = val_23.z});
                val_52 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                if(val_52 < 0)
            {
                    val_60 = null;
                val_60 = null;
                Player_move_c val_26 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                val_54 = val_26.mySkinName.gameObject;
                丙业且三丂业丟丟丏 = true;
            }
            
            }
            
            val_56 = 1;
            label_47:
            val_61 = null;
            val_61 = null;
            if(val_56 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
            {
                goto label_69;
            }
            
            val_62 = 0;
            goto label_70;
            label_87:
            val_63 = null;
            val_63 = null;
            UnityEngine.Transform val_30 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.Item[0].transform;
            if((val_30.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_30, 专丐丛丆与专世丆丂:  1)) != true)
            {
                    UnityEngine.Vector3 val_33 = this.丌丟丄业且三丛丕丄().position;
                val_53 = val_33.z;
                UnityEngine.Vector3 val_34 = val_30.position;
                val_59 = val_34.y;
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_53}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_59, z = val_34.z});
                val_52 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
                if(val_52 < 0)
            {
                    val_64 = null;
                val_64 = null;
                val_54 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.Item[0];
                丙业且三丂业丟丟丏 = false;
            }
            
            }
            
            val_62 = 1;
            label_70:
            val_65 = null;
            val_65 = null;
            if(val_62 < 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.Count)
            {
                goto label_87;
            }
            
            val_66 = 0;
            goto label_88;
            label_105:
            val_67 = null;
            val_67 = null;
            UnityEngine.Transform val_40 = 丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一.Item[0].transform;
            if((val_40.业丗丒丈丕下丄不一(丞下万上三丘上与专:  val_40, 专丐丛丆与专世丆丂:  4)) != true)
            {
                    UnityEngine.Vector3 val_43 = this.丌丟丄业且三丛丕丄().position;
                val_53 = val_43.z;
                UnityEngine.Vector3 val_44 = val_40.position;
                val_59 = val_44.y;
                UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_53}, b:  new UnityEngine.Vector3() {x = val_44.x, y = val_59, z = val_44.z});
                val_52 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
                if(val_52 < 0)
            {
                    val_68 = null;
                val_68 = null;
                val_54 = 丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一.Item[0];
                丙业且三丂业丟丟丏 = false;
            }
            
            }
            
            val_66 = 1;
            label_88:
            val_69 = null;
            val_69 = null;
            val_50 = 丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一;
            if(val_66 < val_50.Count)
            {
                goto label_105;
            }
            
            return (UnityEngine.GameObject)val_54;
            label_46:
            val_54 = 0;
            return (UnityEngine.GameObject)val_54;
        }
        private bool 一下上与万万丄一丛()
        {
            return this.专丙专丙丞丑丅丕丘(丞下万上三丘上与专:  this.currentTarget);
        }
        private bool 专丙专丙丞丑丅丕丘(UnityEngine.Transform 丞下万上三丘上与专)
        {
            var val_14;
            if(丞下万上三丘上与专 == 0)
            {
                goto label_20;
            }
            
            if(this.丂丅与丕丁丛东丌丗 == false)
            {
                goto label_4;
            }
            
            bool val_3 = UnityEngine.Object.op_Equality(x:  丞下万上三丘上与专.gameObject, y:  0);
            if(val_3 == true)
            {
                goto label_20;
            }
            
            label_4:
            且业且丙上三与东丕 val_4 = val_3.丄丏下世东东业东丕(丞下万上三丘上与专:  丞下万上三丘上与专);
            if(val_4 == 4)
            {
                goto label_9;
            }
            
            if(val_4 == 1)
            {
                goto label_10;
            }
            
            if(val_4 != 0)
            {
                goto label_22;
            }
            
            if((val_4.业丗丒丈丕下丄不一(丞下万上三丘上与专:  丞下万上三丘上与专, 专丐丛丆与专世丆丂:  0)) == true)
            {
                goto label_20;
            }
            
            if(this.丂丅与丕丁丛东丌丗 == true)
            {
                goto label_22;
            }
            
            UnityEngine.Vector3 val_7 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_9 = 丞下万上三丘上与专.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            float val_14 = this.丗丛一丁丌与丟东丙.detectRadius;
            val_14 = val_14 * val_14;
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) > val_14)
            {
                goto label_20;
            }
            
            goto label_22;
            label_9:
            if((val_4.业丗丒丈丕下丄不一(丞下万上三丘上与专:  丞下万上三丘上与专, 专丐丛丆与专世丆丂:  4)) == false)
            {
                goto label_22;
            }
            
            label_20:
            val_14 = 1;
            return (bool)val_14;
            label_10:
            val_14 = 1;
            if((val_4.业丗丒丈丕下丄不一(丞下万上三丘上与专:  丞下万上三丘上与专, 专丐丛丆与专世丆丂:  1)) == true)
            {
                    return (bool)val_14;
            }
            
            label_22:
            val_14 = 0;
            return (bool)val_14;
        }
        private bool 业丗丒丈丕下丄不一(UnityEngine.Transform 丞下万上三丘上与专, RilisoftBot.BotAiController.且业且丙上三与东丕 专丐丛丆与专世丆丂)
        {
            UnityEngine.Object val_11;
            var val_12;
            val_11 = 丞下万上三丘上与专;
            if(专丐丛丆与专世丆丂 <= 5)
            {
                    var val_11 = 106027100 + (专丐丛丆与专世丆丂) << 2;
                val_11 = val_11 + 106027100;
            }
            else
            {
                    val_12 = 0;
                return (bool)val_12;
            }
        
        }
        private bool 业丗丒丈丕下丄不一(Player_move_c 丞下万上三丘上与专)
        {
            if((丞下万上三丘上与专 != 0) && (丞下万上三丘上与专.万万一与丝业七专下 != false))
            {
                    if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                    return false;
            }
            
            }
            
            return false;
        }
        public void SetTargetForced(UnityEngine.Transform 丞下万上三丘上与专)
        {
            this.SetTargetToMove(丞下万上三丘上与专:  丞下万上三丘上与专);
            this.丂丅与丕丁丛东丌丗 = true;
        }
        public BotAiController()
        {
            int val_3;
            this.丞不且丌丆丆万业丘 = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.丕丒万丞丑丌七三下 = 0.01f;
            this.丛丘丌丝丟且丕丐丂 = true;
            this.丛不专东丁专不且丈 = true;
            this.minLenghtMove = 9f;
            this.丐丅丑丂丞专丙东丁 = val_1;
            mem[1152921540983276544] = val_1.y;
            mem[1152921540983276548] = val_1.z;
            this.timeToNextTeleport = 2f;
            float[] val_2 = new float[2];
            val_3 = val_2.Length;
            if(val_3 == 0)
            {
                    val_3 = val_2.Length;
            }
            
            val_2[0] = 1f;
            val_2[1] = 2f;
            this.DeltaTeleportAttackDistance = val_2;
            this.angleByPlayerLook = 30f;
            this._distanceForStopMoving = 1.7f;
            this.isDetectPlayer = true;
            this.丗不丘专丑丄丌丟丄 = 0f;
            this.丌上世丝三专业下丗 = 1f;
            this.checkCampaignBase = true;
        }
    
    }

}
