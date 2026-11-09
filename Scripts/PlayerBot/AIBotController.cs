using UnityEngine;

namespace PlayerBot
{
    internal class AIBotController : MonoBehaviour
    {
        // Fields
        internal bool useTestBehavior;
        private UnityEngine.Vector3 不东一业东丌丟丐丄;
        private PlayerBot.东不与丕丁丟东丙且 _initialBehavior;
        private PlayerBot.NavMeshAgentController _agentController;
        private PlayerBot.AIBotTargetDetector _targetDetector;
        public PlayerBotController playerBotController;
        public PlayerBotEntity myPlayerBotEntity;
        private PlayerBot.东不与丕丁丟东丙且 currentBehaviorType;
        private PlayerBot.丁丘丄丞丂丏丑丙丝 丒七丕丛万东丘丞丛;
        private UnityEngine.Coroutine 丅与三丝与丘与丏丏;
        private UnityEngine.Coroutine 不丗丕丝丐七上丙丟;
        private UnityEngine.Coroutine 丛万与丛丗丗专丙专;
        internal bool 万丁丕丄丈丆丕不东;
        private bool 丂丘丟丘一七上万丞;
        private int 万三丁丌丐与丙专三;
        public float meleeSqrRange;
        public float cycleTime;
        public float shootcCycleTiime;
        public float rotationSpeedMin;
        public float rotationSpeedMax;
        private bool 与丈业且丞东不丅丛;
        private bool 丒丅丏丁丆丆丟丑丁;
        private float 世丑不丞丒丅丅丏丌;
        private float 丅丏丁丁丒与专丞丛;
        private float 丟三上丐丑丒世丏丏;
        public float timerForChangeWeaponFromMelee;
        private float 丛上东丟七丙丗三丈;
        private float 丙与丕丄丒上丑丆丅;
        private UnityEngine.Vector3 且业丛丛丛丝专且东;
        private float 丕丞丑丕一不下丞丙;
        private float 丛丙东丕丙丙丐丞丙;
        public float maxMoveDistance;
        public float moveSpeed;
        public float dodgingTime;
        public float dodgingSpeed;
        private float 丝丁丁丁丟丒且丆下;
        private float 专丅丈业丛丕业丌万;
        private float 与丁丛东丅不不丄丂;
        private float 丂业丛丌不丏七丑七;
        private float 世丛与上丏东万且丘;
        private UnityEngine.Vector3 七丌与东丅丛丌丄丅;
        private float 三丁丄丄丐丕丞丆丗;
        private float 丕丏东万丅上丐丏丟;
        private float 丂丗丟业下丟丝下与;
        private float 且丝上上丐丟丞东丐;
        public float tepmFixPrediction;
        private float 丞下丞不万丂丝丁丏;
        private float 丁丆丙丝一丗专一业;
        private float 丞丆丆丘世丁丌丘丗;
        private int 丝丑七专万业与丞丝;
        
        // Properties
        internal bool 丒丗丄丄不丐丑丘丞 { get; }
        public PlayerBot.东不与丕丁丟东丙且 丞丟丙丒不丈不上丟 { get; }
        public PlayerBot.丁丘丄丞丂丏丑丙丝 丑一丑与下丈丒专七 { get; }
        internal bool 丌且下丕下下丌万丞 { get; }
        private bool 丏丌七上丛丒七丂丂 { get; }
        private bool 丟丕丒丟丐丁丆丙丝 { get; }
        internal bool 丆丝丂业七业万与丅 { get; }
        internal UnityEngine.Vector3 七专丑丘丂丞丛一丟 { get; }
        internal PlayerBot.且丏丕丝丄上业上丒 不丘且丘专与丐丄丂 { get; }
        internal PlayerBot.NavMeshAgentController 丗万丝丟丙专世丗丒 { get; }
        internal PlayerBotMovement 丘丌丈丒丟丒丑三且 { get; }
        internal int 一丌丄丞丕丐丗丒不 { get; set; }
        public float 业上下丘万丈世世下 { get; }
        public float 丐丑丁万丞丞丐丌丐 { get; }
        private float 丅丟七东丑与三丏丝 { get; }
        private float 万专丟业且丁丛一专 { get; }
        private float 与丄丆丆不丏上丏丅 { get; }
        
        // Methods
        internal bool 丗丆丙不丑丆不丘丘()
        {
            return false;
        }
        public void CancelTarget()
        {
            this._targetDetector.CancelTarget();
        }
        public PlayerBot.东不与丕丁丟东丙且 get_CurrentBehaviorType()
        {
            return (PlayerBot.东不与丕丁丟东丙且)this.currentBehaviorType;
        }
        public PlayerBot.丁丘丄丞丂丏丑丙丝 get_CurrentBehavior()
        {
            return (PlayerBot.丁丘丄丞丂丏丑丙丝)this.丒七丕丛万东丘丞丛;
        }
        internal bool 丟丌下三七丁与丟丑()
        {
            if(this.playerBotController.丄丈丑丐丆丞丘与丗 != null)
            {
                    return this.playerBotController.丄丈丑丐丆丞丘与丗.isMine;
            }
            
            return this.playerBotController.丄丈丑丐丆丞丘与丗.isMine;
        }
        private bool 业业丏与丄丛丐丗丂()
        {
            PlayerBotEntity val_3;
            var val_4;
            val_3 = this;
            if(this.playerBotController.丄丈丑丐丆丞丘与丗.isMine != false)
            {
                    val_3 = this.playerBotController.player;
                var val_2 = (this.playerBotController.player.万丝一万丐且丌业丛 == false) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private bool 世丙丕与东一丗万丟()
        {
            上且下一丁丑丑丟丟 val_1 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂丝一丁上业与丄(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
            }
            
            return val_1.丟丂丝一丁上业与丄(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
        }
        internal bool 上丛世丟丐上丌东东()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(this.playerBotController.player.丆东丛业丟丛丌丆丌() != 0)
            {
                    val_5 = this.playerBotController.player.丆东丛业丟丛丌丆丌();
                var val_4 = (val_3.isMelee == true) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        internal UnityEngine.Vector3 丄三与丞专丄不丑丛()
        {
            UnityEngine.Vector3 val_3;
            var val_4;
            var val_5;
            if(this.useTestBehavior != false)
            {
                    val_3 = this.不东一业东丌丟丐丄;
                val_4 = 1152921540781516560;
                val_5 = 1152921540781516564;
                return new UnityEngine.Vector3() {x = this.丒七丕丛万东丘丞丛.七专丑丘丂丞丛一丟.x, y = 1.787903E-12f, z = 1.787903E-12f};
            }
            
            val_3 = this.丒七丕丛万东丘丞丛.七专丑丘丂丞丛一丟;
            val_4 = this.丒七丕丛万东丘丞丛 + 28;
            val_5 = this.丒七丕丛万东丘丞丛 + 32;
            return new UnityEngine.Vector3() {x = this.丒七丕丛万东丘丞丛.七专丑丘丂丞丛一丟.x, y = 1.787903E-12f, z = 1.787903E-12f};
        }
        internal PlayerBot.且丏丕丝丄上业上丒 丏丒丁且丌下万丄丆()
        {
            if(this._targetDetector != null)
            {
                    return (PlayerBot.且丏丕丝丄上业上丒)this._targetDetector.与丝丁丑丁丌丞丞东;
            }
            
            return (PlayerBot.且丏丕丝丄上业上丒)this._targetDetector.与丝丁丑丁丌丞丞东;
        }
        internal PlayerBot.NavMeshAgentController 丌且丞丕万丂丆七丅()
        {
            return (PlayerBot.NavMeshAgentController)this._agentController;
        }
        internal PlayerBotMovement 丘丞丒丙丏丂下丌不()
        {
            if(this.playerBotController != null)
            {
                    return (PlayerBotMovement)this.playerBotController.movement;
            }
            
            return (PlayerBotMovement)this.playerBotController.movement;
        }
        internal int 丄丛丄丟不世丙东丟()
        {
            return (int)this.万三丁丌丐与丙专三;
        }
        internal void 三世丘丝丟不丝世上(int 丙业与丙丗丝不丈东)
        {
            this.万三丁丌丐与丙专三 = 丙业与丙丗丝不丈东;
            this.丛上东丟七丙丗三丈 = 0f;
        }
        public float get_MinRandomValueForAim()
        {
            上且下一丁丑丑丟丟 val_1 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.与丛不丂丛丈不丑七(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
            }
            
            return val_1.与丛不丂丛丈不丑七(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
        }
        public float get_maxRandomValueForAim()
        {
            上且下一丁丑丑丟丟 val_1 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一丑不一丘丘丅丛丐(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
            }
            
            return val_1.一丑不一丘丘丅丛丐(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
        }
        private float 丘丞世丘丂世七丌东()
        {
            上且下一丁丑丑丟丟 val_1 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一丁万丑丞业丆丁与(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
            }
            
            return val_1.一丁万丑丞业丆丁与(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
        }
        private float 丈丟一不丁丟七万丙()
        {
            上且下一丁丑丑丟丟 val_1 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丄丘丝且不且与一(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
            }
            
            return val_1.丟丄丘丝且不且与一(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
        }
        private float 丂不丘不万东丗世丌()
        {
            float val_7;
            float val_10;
            val_7 = this;
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.世丑不丞丒丅丅丏丌;
            if(val_1 >= 0)
            {
                goto label_0;
            }
            
            if(this.currentBehaviorType != 3)
            {
                goto label_1;
            }
            
            float val_3 = this.丈丟一不丁丟七万丙();
            val_10 = this.丘丞世丘丂世七丌东();
            goto label_2;
            label_0:
            val_7 = this.丅丏丁丁丒与专丞丛;
            return (float)this.丅丏丁丁丒与专丞丛;
            label_1:
            val_10 = this.rotationSpeedMin;
            label_2:
            this.丅丏丁丁丒与专丞丛 = UnityEngine.Random.Range(min:  val_10, max:  this.rotationSpeedMax);
            this.丟三上丐丑丒世丏丏 = (float)UnityEngine.Random.Range(min:  1, max:  5);
            this.世丑不丞丒丅丅丏丌 = UnityEngine.Time.time;
            return (float)this.丅丏丁丁丒与专丞丛;
        }
        private void Awake()
        {
            this.playerBotController.player.丏丆三丌丁丈丄万东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlayerBot.AIBotController::下一东三丛丕世下丞()));
            this.myPlayerBotEntity = this.GetComponent<PlayerBotEntity>();
        }
        private void Update()
        {
            PlayerBot.且丏丕丝丄上业上丒 val_20;
            bool val_21;
            float val_23;
            float val_24;
            float val_27;
            if(this.与丈业且丞东不丅丛 == false)
            {
                goto label_54;
            }
            
            val_20 = this._targetDetector.与丝丁丑丁丌丞丞东;
            if(val_20 != null)
            {
                    val_20 = 0;
            }
            
            if(val_20 == 0)
            {
                goto label_54;
            }
            
            val_21 = 1152921505345130496;
            var val_23 = 0;
            val_23 = val_23 + 1;
            if((this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetIsDead == true) || (this.丒丅丏丁丆丆丟丑丁 == true))
            {
                goto label_54;
            }
            
            if(this.上丛世丟丐上丌东东() != false)
            {
                    if(this.playerBotController.player.丕丁丘丆万丄世专丛.丆不业专丑三万丞丂 == false)
            {
                goto label_23;
            }
            
            }
            
            if(this.playerBotController.player.丕丁丘丆万丄世专丛.丆不业专丑三万丞丂 == false)
            {
                goto label_45;
            }
            
            UnityEngine.Vector3 val_8 = this.transform.position;
            val_23 = val_8.x;
            val_24 = val_8.z;
            var val_24 = 0;
            val_24 = val_24 + 1;
            goto label_34;
            label_23:
            UnityEngine.Vector3 val_10 = this.transform.position;
            val_24 = val_10.z;
            var val_25 = 0;
            val_25 = val_25 + 1;
            goto label_41;
            label_34:
            UnityEngine.Vector3 val_13 = this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetTransform.position;
            val_27 = val_13.y;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = val_8.y, z = val_24}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_27, z = val_13.z});
            if(val_14.x <= 3f)
            {
                goto label_45;
            }
            
            goto label_54;
            label_41:
            UnityEngine.Vector3 val_17 = this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetTransform.position;
            val_27 = val_17.y;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_24}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_27, z = val_17.z});
            val_23 = val_18.x;
            float val_20 = this.playerBotController.player.三专丗七丂丈不与下();
            val_20 = this.playerBotController.player.三专丗七丂丈不与下() * val_20;
            if(val_23 > val_20)
            {
                goto label_54;
            }
            
            label_45:
            int val_26 = this.万三丁丌丐与丙专三;
            val_21 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世().丈专丙且丐丐丝丅丟(丑万世丂专丈丌业且:  val_26);
            val_26 = val_21;
            this.playerBotController.player.丟丑丙七丁三丞丕丁(丙丌丏且丞丏丛丛丗:  val_26);
            label_54:
            this.丂丛不上三丅且世丘();
        }
        private void LateUpdate()
        {
            PlayerBotMovement val_41;
            var val_42;
            float val_44;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            val_41 = this;
            if(this.丂丘丟丘一七上万丞 == false)
            {
                    return;
            }
            
            if(this.useTestBehavior == true)
            {
                    return;
            }
            
            if(this.currentBehaviorType == 1)
            {
                    bool val_42 = this.丒七丕丛万东丘丞丛.丂世丑丝丞丏丆丟丅;
                val_42 = val_42 + 3;
                var val_43 = ~val_42;
                val_43 = val_43 & 3;
                if(val_43 != 0)
            {
                    return;
            }
            
            }
            
            val_42 = 0;
            if( != 0)
            {
                    var val_44 = 0;
                val_44 = val_44 + 1;
                if(this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetIsDead != true)
            {
                    if(this.useTestBehavior == false)
            {
                goto label_20;
            }
            
            }
            
            }
            
            if(this.playerBotController == null)
            {
                goto label_22;
            }
            
            if(this.丒七丕丛万东丘丞丛.一丙上丗七丈丘世丐 == false)
            {
                goto label_23;
            }
            
            label_38:
            UnityEngine.Vector3 val_5 = this.playerBotController.丌丕下东七丗丛丞下._agentController.agent.velocity;
            val_44 = 5f;
            this.与丁丛东丅不不丄丂 = val_5.x;
            if(val_5.x <= val_44)
            {
                    return;
            }
            
            float val_6 = UnityEngine.Time.time;
            if(this.丂业丛丌不丏七丑七 < 0)
            {
                    this.专丅丈业丛丕业丌万 = UnityEngine.Random.Range(min:  0.5f, max:  3f);
                float val_8 = UnityEngine.Time.time;
                this.丝丁丁丁丟丒且丆下 = 0f;
                val_8 = val_8 + this.专丅丈业丛丕业丌万;
                this.丂业丛丌不丏七丑七 = val_8;
                val_44 = -1f;
                float val_11 = ((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? (val_44) : 1f;
                val_11 = (UnityEngine.Random.Range(min:  10f, max:  50f)) * val_11;
                this.世丛与上丏东万且丘 = val_11;
            }
            
            float val_12 = UnityEngine.Time.deltaTime;
            val_12 = this.丝丁丁丁丟丒且丆下 + val_12;
            this.丝丁丁丁丟丒且丆下 = val_12;
            UnityEngine.Vector3 val_13 = this.playerBotController.丌丕下东七丗丛丞下._agentController.agent.velocity;
            UnityEngine.Vector3 val_14 = val_13.x.业丝丛万丗世丆与丅(丄世专下丟丏丟丕东:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, 世七七下丐丌专丞丂:  this.世丛与上丏东万且丘);
            this.七丌与东丅丛丌丄丅 = val_14;
            mem[1152921540783412172] = val_14.y;
            mem[1152921540783412176] = val_14.z;
            UnityEngine.Vector3 val_15 = this.playerBotController.movement.丘丄丈上与丕三丅丑();
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = this.七丌与东丅丛丌丄丅, y = val_16.y, z = val_16.z});
            float val_45 = this.丝丁丁丁丟丒且丆下;
            val_49 = val_16.z;
            val_45 = val_45 / this.专丅丈业丛丕业丌万;
            val_50 = val_16.x;
            val_51 = val_16.y;
            val_52 = val_16.w;
            goto label_37;
            label_22:
            if(this.丒七丕丛万东丘丞丛.一丙上丗七丈丘世丐 == true)
            {
                goto label_38;
            }
            
            label_23:
            UnityEngine.Vector3 val_18 = this.playerBotController.movement.丘丄丈上与丕三丅丑();
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_20 = this.丄三与丞专丄不丑丛();
            UnityEngine.Vector3 val_22 = this.playerBotController.movement.transform.position;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            float val_26 = this.丂不丘不万东丗世丌();
            val_26 = UnityEngine.Time.deltaTime * val_26;
            val_51 = val_19.y;
            val_50 = val_19.x;
            val_49 = val_19.z;
            val_52 = val_19.w;
            label_37:
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_50, y = val_51, z = val_49, w = val_52}, b:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w}, t:  val_26);
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            val_41 = this.playerBotController.movement;
            UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  0f, y:  val_28.y);
            label_63:
            UnityEngine.Vector3 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
            val_41.丈丌丝丐丆不且万不(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            return;
            label_20:
            UnityEngine.Vector3 val_31 = this.playerBotController.movement.丘丄丈上与丕三丅丑();
            UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            UnityEngine.Vector3 val_33 = this.丆且万丙丐丄丌丟丞();
            UnityEngine.Vector3 val_35 = this.playerBotController.movement.transform.position;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            UnityEngine.Quaternion val_37 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z});
            float val_39 = this.丂不丘不万东丗世丌();
            val_39 = UnityEngine.Time.deltaTime * val_39;
            UnityEngine.Quaternion val_40 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w}, b:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w}, t:  val_39);
            UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
            if(this.playerBotController != null)
            {
                goto label_63;
            }
            
            goto label_63;
        }
        private UnityEngine.Vector3 业丝丛万丗世丆与丅(UnityEngine.Vector3 丄世专下丟丏丟丕东, float 世七七下丐丌专丞丂)
        {
            float val_4 = 世七七下丐丌专丞丂;
            float val_3 = 3.141593f;
            float val_5 = 180f;
            val_3 = val_4 * val_3;
            val_4 = val_3 / val_5;
            float val_6 = val_4;
            val_5 = 丄世专下丟丏丟丕东.x * val_4;
            丄世专下丟丏丟丕东.z = 丄世专下丟丏丟丕东.z * val_6;
            世七七下丐丌专丞丂 = 丄世专下丟丏丟丕东.x * val_6;
            val_6 = val_5 - 丄世专下丟丏丟丕东.z;
            float val_2 = (丄世专下丟丏丟丕东.z * val_4) + 世七七下丐丌专丞丂;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void OnDestroy()
        {
            this.playerBotController.player.丛下业丅丟东丁上七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PlayerBot.AIBotController::下一东三丛丕世下丞()));
            if(this.丅与三丝与丘与丏丏 != null)
            {
                    this.StopCoroutine(routine:  this.丅与三丝与丘与丏丏);
                this.丅与三丝与丘与丏丏 = 0;
            }
            
            if(this.不丗丕丝丐七上丙丟 != null)
            {
                    this.StopCoroutine(routine:  this.不丗丕丝丐七上丙丟);
                this.不丗丕丝丐七上丙丟 = 0;
            }
            
            if(this.丛万与丛丗丗专丙专 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丛万与丛丗丗专丙专);
            this.丛万与丛丗丗专丙专 = 0;
        }
        internal void 丏丂且一不世丙丑下()
        {
            if(this.丂丘丟丘一七上万丞 == true)
            {
                    return;
            }
            
            this.丛丙东丕丙丙丐丞丙 = UnityEngine.Random.Range(min:  0.1f, max:  3f);
            this.丘业三丌丐丂丈丗丒(丌专丝丘丒丒丟丄上:  this._initialBehavior);
            this._agentController.上丛丌丆丑上七世三(下丐三丆丝与不丗丕:  this.gameObject);
            this.丅与三丝与丘与丏丏 = this.StartCoroutine(routine:  this.丑丁业不丏丆丞丞一());
            this.不丗丕丝丐七上丙丟 = this.StartCoroutine(routine:  this.丌专丞三丙丐丅世丛());
            this.丛万与丛丗丗专丙专 = this.StartCoroutine(routine:  this.与上丄专丝丒七丟丒());
            this.丂丘丟丘一七上万丞 = true;
        }
        internal void 丌丑丏丒丆丐丈丘丌(PlayerBot.且丏丕丝丄上业上丒 丘丝丒不丁一万丕丝)
        {
            if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().七丘丁丅丞万丟丟东(丑丗丘七丘丞丁业丕:  (this._targetDetector.与丝丁丑丁丌丞丞东 != 0) ? 1 : 0, 丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三)) == false)
            {
                    return;
            }
            
            this._targetDetector.丏丒专丟业上下丁万(丞下万上三丘上与专:  丘丝丒不丁一万丕丝);
        }
        private void 下一东三丛丕世下丞()
        {
            if((this._targetDetector.与丝丁丑丁丌丞丞东 != null) && (this.playerBotController.player.丒万不三丟与丐丈上() != false))
            {
                    if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().七一丘万下丙丄丘丅(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三)) != false)
            {
                    this.playerBotController.player.万丒一万丌丆丏丈不();
                return;
            }
            
            }
            
            if(this.playerBotController.player.equippedWeapons.Count < 2)
            {
                    return;
            }
            
            if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().七专丏七丁丌丟丏丑(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三)) == false)
            {
                    return;
            }
            
            this.playerBotController.player.丙上丆丁世丛万丕丂();
        }
        internal bool 与丛且丟丌丂丅万三()
        {
            if(this._targetDetector != null)
            {
                    return this._targetDetector.与丛且丟丌丂丅万三();
            }
            
            return this._targetDetector.与丛且丟丌丂丅万三();
        }
        internal UnityEngine.Vector3 丟下丄不业业丅上丏()
        {
            if(this._targetDetector != null)
            {
                    return this._targetDetector.业东丆丝上世丅下丗();
            }
            
            return this._targetDetector.业东丆丝上世丅下丗();
        }
        internal bool 丟不丛丟丝丒且丞上(out Rilisoft.专与丏丞三与不不丆 丙一丐丕丗一丗丄丘)
        {
            Rilisoft.专与丏丞三与不不丆 val_5;
            丙一丐丕丗一丗丄丘 = 1;
            if((this.playerBotController.丗丈东丕不丘三丞业.isScenarioBot == true) || (this.playerBotController.player.丕丁丘丆万丄世专丛 == 0))
            {
                goto label_8;
            }
            
            float val_3 = this.playerBotController.player.丕丁丘丆万丄世专丛.专一丟丏且丆丕丝七();
            if(this.playerBotController.player.丕丁丘丆万丄世专丛.丘七业丒丐世丂丅丒() < 0)
            {
                    val_5 = 1;
                丙一丐丕丗一丗丄丘 = val_5;
                return (bool)val_5;
            }
            
            var val_4 = (this.playerBotController.player.丕丁丘丆万丄世专丛.丅三业丆丄丝丝丕东 < 0) ? (this.playerBotController.player.丕丁丘丆万丄世专丛.丅三业丆丄丝丝丕东 + 1) : this.playerBotController.player.丕丁丘丆万丄世专丛.丅三业丆丄丝丝丕东;
            val_4 = val_4 >> 1;
            if(this.playerBotController.player.丕丁丘丆万丄世专丛.三丕丘下业丑丞下丘 <= (float)val_4)
            {
                goto label_23;
            }
            
            label_8:
            val_5 = 0;
            return (bool)val_5;
            label_23:
            丙一丐丕丗一丗丄丘 = 2;
            return (bool)val_5;
        }
        private float 丂丈一丙一丅世万丈()
        {
            var val_2;
            if(this.丛上东丟七丙丗三丈 != 0f)
            {
                    return val_2;
            }
            
            val_2 = null;
            val_2 = null;
            float val_2 = FirstPersonControlSharp.三丏丅丐丏与下世丗;
            val_2 = val_2 + val_2;
            val_2 = this.maxRandomValueForAim / val_2;
            this.丛上东丟七丙丗三丈 = val_2;
            return val_2;
        }
        private float 丅三不丌三丅丙丙上(float 丌七丒世丄上丞丞丁)
        {
            if(this.playerBotController.player.丆东丛业丟丛丌丆丌() != 0)
            {
                    if((this.playerBotController.player.丐丌丘丑丄丂万丟丑().丌上丗丕不七世丅丁() != null) && (val_1.bazooka != false))
            {
                    float val_7 = this.playerBotController.player.丐丌丘丑丄丂万丟丑().丌上丗丕不七世丅丁().丗与且丞丂丁世丕丘();
                val_7 = 丌七丒世丄上丞丞丁 / val_7;
                1f = val_7 + 1f;
            }
            
            }
            
            float val_8 = this.tepmFixPrediction;
            val_8 = 1f * val_8;
            return (float)val_8;
        }
        private UnityEngine.Vector3 丆且万丙丐丄丌丟丞()
        {
            float val_32;
            float val_33;
            var val_34;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_32 = this.playerBotController.player.东万丝丞丄丐丕丌万() + this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetCurrentSpeed;
            val_33 = 2f;
            if(val_32 <= val_33)
            {
                goto label_9;
            }
            
            val_33 = this.丙与丕丄丒上丑丆丅;
            if(val_33 != val_32)
            {
                goto label_10;
            }
            
            label_9:
            val_34 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if((val_34.丄丌不丘丟业丐丕丟(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三)) == false)
            {
                    return new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
            }
            
            label_10:
            this.丙与丕丄丒上丑丆丅 = val_32;
            float val_37 = UnityEngine.Mathf.Clamp(value:  val_32, min:  this.MinRandomValueForAim, max:  15f);
            float val_8 = this.丂丈一丙一丅世万丈();
            val_32 = val_37 * val_8;
            val_37 = -(val_37 * val_8);
            float val_9 = UnityEngine.Random.Range(min:  val_37, max:  val_32);
            float val_10 = UnityEngine.Random.Range(min:  val_37, max:  val_32);
            float val_11 = UnityEngine.Random.Range(min:  val_37, max:  val_32);
            UnityEngine.Vector3 val_13 = this.transform.position;
            var val_38 = 0;
            val_38 = val_38 + 1;
            UnityEngine.Vector3 val_15 = this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetAimCenter;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            var val_39 = 0;
            val_39 = val_39 + 1;
            UnityEngine.Vector3 val_18 = this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetVelocity;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            this.三丁丄丄丐丕丞丆丗 = val_19.x;
            val_19.x = val_19.x - this.且丝上上丐丟丞东丐;
            val_19.x = val_19.x / this.丂丗丟业下丟丝下与;
            float val_20 = UnityEngine.Mathf.Clamp01(value:  val_19.x);
            this.丕丏东万丅上丐丏丟 = val_20;
            float val_40 = 0.5f;
            val_40 = val_32 * val_40;
            val_40 = val_40 * val_40;
            if(val_20 > val_40)
            {
                    val_34 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
                this.丒丅丏丁丆丆丟丑丁 = val_34.下丅世丘丈丛上丈下(丑万世丂专丈丌业且:  this.万三丁丌丐与丙专三);
            }
            
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.丕丏东万丅上丐丏丟);
            var val_41 = 0;
            val_41 = val_41 + 1;
            UnityEngine.Vector3 val_26 = this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetAimCenter;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_32 = val_27.x;
            var val_42 = 0;
            val_42 = val_42 + 1;
            UnityEngine.Vector3 val_29 = this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetVelocity;
            var val_43 = 0;
            val_43 = val_43 + 1;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, d:  this._targetDetector.与丝丁丑丁丌丞丞东.BotTargetCurrentSpeed);
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, d:  this.丅三不丌三丅丙丙上(丌七丒世丄上丞丞丁:  this.三丁丄丄丐丕丞丆丗));
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            this.且业丛丛丛丝专且东 = val_35;
            mem[1152921540785360868] = val_35.y;
            mem[1152921540785360872] = val_35.z;
            return new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z};
        }
        internal void 与三丙丆丘万不丁丑()
        {
            this.丕丞丑丕一不下丞丙 = UnityEngine.Random.Range(min:  0.5f, max:  1f);
            this._agentController.与丞丕丝上三不丞与();
        }
        internal void 丘业三丌丐丂丈丗丒(PlayerBot.东不与丕丁丟东丙且 丌专丝丘丒丒丟丄上)
        {
            PlayerBot.丁丘丄丞丂丏丑丙丝 val_4;
            if(this.currentBehaviorType == 丌专丝丘丒丒丟丄上)
            {
                    return;
            }
            
            if(丌专丝丘丒丒丟丄上 <= 3)
            {
                    var val_4 = 106039024 + (丌专丝丘丒丒丟丄上) << 2;
                val_4 = val_4 + 106039024;
            }
            else
            {
                    val_4 = this.丒七丕丛万东丘丞丛;
                this.currentBehaviorType = 丌专丝丘丒丒丟丄上;
                if(this.丟丌下三七丁与丟丑() == false)
            {
                    return;
            }
            
                this.playerBotController.丒丛丒丅丈丛东丝一();
            }
        
        }
        private System.Collections.IEnumerator 丑丁业不丏丆丞丞一()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AIBotController.丘丈丈与专丁丐丑丕();
        }
        private System.Collections.IEnumerator 丌专丞三丙丐丅世丛()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AIBotController.丛且专专且丒丅下丟();
        }
        private PlayerBot.东不与丕丁丟东丙且 丒丟丕丘一丁丝丂且()
        {
            PlayerBot.AIBotTargetDetector val_3;
            var val_4;
            val_3 = this;
            if(this._targetDetector.与丝丁丑丁丌丞丞东 != null)
            {
                    val_4 = 3;
                return (PlayerBot.东不与丕丁丟东丙且)(val_3.与丛且丟丌丂丅万三() != true) ? (1 + 1) : 1;
            }
            
            val_3 = this._targetDetector;
            return (PlayerBot.东不与丕丁丟东丙且)(val_3.与丛且丟丌丂丅万三() != true) ? (1 + 1) : 1;
        }
        private PlayerBot.东不与丕丁丟东丙且 业丆丒且丒丏丞丒不()
        {
            PlayerBot.AIBotTargetDetector val_6;
            var val_7;
            val_6 = this;
            if(this._targetDetector.与丝丁丑丁丌丞丞东 != null)
            {
                    val_7 = 3;
                return (PlayerBot.东不与丕丁丟东丙且)val_7;
            }
            
            if(this._targetDetector.与丛且丟丌丂丅万三() == false)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_2 = this._targetDetector.业东丆丝上世丅下丗();
            UnityEngine.Vector3 val_4 = this.playerBotController.player.丕丁丘丆万丄世专丛.myTransform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            if(System.Math.Abs(val_5.x) > (1.401298E-45f))
            {
                goto label_15;
            }
            
            label_5:
            val_6 = this._targetDetector;
            val_6.丏世丕丗丄丛丈丆专();
            val_7 = 1;
            return (PlayerBot.东不与丕丁丟东丙且)val_7;
            label_15:
            val_7 = 2;
            return (PlayerBot.东不与丕丁丟东丙且)val_7;
        }
        private PlayerBot.东不与丕丁丟东丙且 与丟丝丏丏且与丏丂()
        {
            PlayerBot.AIBotTargetDetector val_3;
            var val_4;
            val_3 = this;
            if(this._targetDetector.与丝丁丑丁丌丞丞东 != null)
            {
                    val_4 = 3;
                return (PlayerBot.东不与丕丁丟东丙且)(val_3.与丛且丟丌丂丅万三() != true) ? (1 + 1) : 1;
            }
            
            val_3 = this._targetDetector;
            return (PlayerBot.东不与丕丁丟东丙且)(val_3.与丛且丟丌丂丅万三() != true) ? (1 + 1) : 1;
        }
        private System.Collections.IEnumerator 与上丄专丝丒七丟丒()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AIBotController.丁业丂丌丈丞丏丑丅();
        }
        internal void 丈丐且万业丗与万与()
        {
            this.丛与万丂丅丂丏丄丄();
        }
        private void 丛与万丂丅丂丏丄丄()
        {
            if(this.playerBotController.player.丕丁丘丆万丄世专丛 == 0)
            {
                    return;
            }
            
            if(this.playerBotController.player.万丝一万丐且丌业丛 == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.playerBotController.player.丕丁丘丆万丄世专丛.myPlayerTransform.position;
            if(val_2.y <= (-5000f))
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.playerBotController.player.丕丁丘丆万丄世专丛.myPlayerTransform.position;
            this._agentController.丞三七丑业丄丞丙且(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Quaternion val_5 = this.playerBotController.player.丕丁丘丆万丄世专丛.myPlayerTransform.rotation;
            this._agentController.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        private void 丂丛不上三丅且世丘()
        {
            string val_41;
            var val_62;
            var val_63;
            float val_64;
            float val_65;
            float val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            if(GameConnect.且丞丁东丝丗上丈业() == true)
            {
                goto label_3;
            }
            
            val_62 = 0;
            goto label_4;
            label_22:
            val_63 = null;
            val_63 = null;
            SingularityHole val_2 = Initializer.丂丈丗与丕三不丑七.Item[0];
            UnityEngine.Vector3 val_4 = val_2.transform.position;
            val_64 = val_4.z;
            UnityEngine.Vector3 val_6 = this.transform.position;
            val_65 = val_6.y;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_64}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_65, z = val_6.z});
            float val_8 = val_2.GetForce(丌七丒世丄上丞丞丁:  val_7.x);
            if(val_8 != 0f)
            {
                    UnityEngine.Transform val_9 = this.transform;
                UnityEngine.Vector3 val_10 = val_9.position;
                val_66 = val_10.z;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_66}, d:  val_8);
                val_65 = val_11.y;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_65, z = val_11.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                val_64 = val_14.z;
                val_9.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_64};
            }
            
            val_62 = 1;
            label_4:
            val_67 = null;
            val_67 = null;
            if(val_62 < Initializer.丂丈丗与丕三不丑七.Count)
            {
                goto label_22;
            }
            
            label_3:
            val_68 = 0;
            goto label_23;
            label_95:
            val_69 = null;
            val_69 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0] == this.playerBotController.player.丕丁丘丆万丄世专丛)
            {
                    val_70 = null;
                val_70 = null;
                if((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丅万丝丘三业世丆丞(丏不丂丆且三丞丆丏:  9)) != false)
            {
                    val_71 = null;
                val_71 = null;
                Player_move_c val_20 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_21 = val_20.myPlayerTransform.position;
                Player_move_c val_22 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_23 = val_22.myPlayerTransform.forward;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  1.2f);
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                UnityEngine.Vector3 val_27 = this.transform.position;
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
                UnityEngine.Transform val_29 = this.transform;
                UnityEngine.Vector3 val_30 = val_29.position;
                val_66 = val_30.y;
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  5f);
                UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_66, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
                val_64 = val_34.x;
                val_65 = val_34.z;
                val_29.position = new UnityEngine.Vector3() {x = val_64, y = val_34.y, z = val_65};
            }
            
            }
            
            val_72 = null;
            val_72 = null;
            if((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  14)) != false)
            {
                    val_73 = null;
                val_73 = null;
                if((this.playerBotController.player.丕丁丘丆万丄世专丛.丂七一业下丈业丕丒.IsEnemyTo(专丞上七七且丝七丗:  丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0])) != false)
            {
                    val_74 = null;
                val_74 = null;
                丂丑丂七丞丞丅丂东 val_40 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].与七丑丐专丈丅丄丈(丏不丂丆且三丞丆丏:  14);
                if(((System.String.IsNullOrEmpty(value:  val_41)) != true) && (丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_41] != null))
            {
                    val_75 = null;
                val_75 = null;
                Player_move_c val_45 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_46 = val_45.myPlayerTransform.position;
                val_65 = val_46.y;
                UnityEngine.Vector3 val_48 = this.transform.position;
                val_66 = val_48.x;
                val_64 = val_48.z;
                UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_65, z = val_46.z}, b:  new UnityEngine.Vector3() {x = val_66, y = val_48.y, z = val_64});
                if((val_49.x < 0) && (val_49.x > 5.76f))
            {
                    val_76 = null;
                val_76 = null;
                Player_move_c val_50 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
                UnityEngine.Vector3 val_51 = val_50.myPlayerTransform.position;
                UnityEngine.Vector3 val_53 = this.transform.position;
                UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, b:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z});
                UnityEngine.Transform val_55 = this.transform;
                UnityEngine.Vector3 val_56 = val_55.position;
                val_66 = val_56.y;
                UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, d:  10f);
                UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_56.x, y = val_66, z = val_56.z}, b:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
                val_64 = val_60.x;
                val_65 = val_60.z;
                val_55.position = new UnityEngine.Vector3() {x = val_64, y = val_60.y, z = val_65};
            }
            
            }
            
            }
            
            }
            
            val_68 = 1;
            label_23:
            val_77 = null;
            val_77 = null;
            if(val_68 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
            {
                goto label_95;
            }
        
        }
        internal void 丕丂丆且下丐丂丈专(float 丁丆丙丝一丗专一业, float 丞丆丆丘世丁丌丘丗)
        {
            this.丁丆丙丝一丗专一业 = 丁丆丙丝一丗专一业;
            this.丞丆丆丘世丁丌丘丗 = 丞丆丆丘世丁丌丘丗;
        }
        internal void 丗丑丒下丗业丏不不(int 不丏东三丕东且丒世)
        {
            this.万三丁丌丐与丙专三 = 不丏东三丕东且丒世;
            this.丛上东丟七丙丗三丈 = 0f;
        }
        internal void 且万丄与丌万丈丛丝(float 丗丘丆丄丝与东下上)
        {
            int val_1;
            if((this.丁丆丙丝一丗专一业 > 丗丘丆丄丝与东下上) && (this.万三丁丌丐与丙专三 < this.丝丑七专万业与丞丝))
            {
                    val_1 = this.万三丁丌丐与丙专三 + 1;
            }
            else
            {
                    if(this.丞丆丆丘世丁丌丘丗 >= 0)
            {
                    return;
            }
            
                val_1 = this.万三丁丌丐与丙专三 - 1;
                if(this.丞丆丆丘世丁丌丘丗 < 丗丘丆丄丝与东下上)
            {
                    return;
            }
            
            }
            
            this.万三丁丌丐与丙专三 = val_1;
            this.丛上东丟七丙丗三丈 = 0f;
        }
        public AIBotController()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.万三丁丌丐与丙专三 = 1;
            this.不东一业东丌丟丐丄 = val_1;
            mem[1152921540787782064] = val_1.y;
            this.rotationSpeedMax = 8f;
            mem[1152921540787782068] = val_1.z;
            this.meleeSqrRange = ;
            this.cycleTime = ;
            this.shootcCycleTiime = 0.05f;
            this.rotationSpeedMin = 4f;
            this.世丑不丞丒丅丅丏丌 = ;
            this.丅丏丁丁丒与专丞丛 = ;
            this.丟三上丐丑丒世丏丏 = 4f;
            this.timerForChangeWeaponFromMelee = 3f;
            this.丙与丕丄丒上丑丆丅 = -1f;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.且业丛丛丛丝专且东 = val_2;
            mem[1152921540787782212] = val_2.y;
            mem[1152921540787782216] = val_2.z;
            this.maxMoveDistance = ;
            this.moveSpeed = ;
            this.dodgingTime = 0.7f;
            this.dodgingSpeed = 5f;
            this.丕丏东万丅上丐丏丟 = ;
            this.丂丗丟业下丟丝下与 = ;
            this.且丝上上丐丟丞东丐 = 3f;
            this.tepmFixPrediction = 1.7f;
            mem2[0] = 1055286886;
            this.丝丑七专万业与丞丝 = 3;
        }
    
    }

}
