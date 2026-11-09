using UnityEngine;

namespace RilisoftBot
{
    internal class BaseBot : VTableHolder, 丅丙上七上一丐不下, 丙七丟丞丝丅丛丝丝, 万丝丅丗且丒丝丌丟, 东丁丆一业丈万丆丐
    {
        // Fields
        private bool 下世万业丗世且业丌;
        internal 万丝丅丗且丒丝丌丟 丙万丅下丂业东丄丒;
        internal RilisoftBot.BotHpIndicator 丆丆丂丑丁世上丟上;
        private BotChangeDamageMaterial[] 丒东丕丙且上不一丆;
        private RilisoftBot.丅丅世丙丄丛丌丞丂 丟七丐丏且丁丂丘世;
        private bool 上丞丞丏丂丅专丝丆;
        private bool 丑一业丟上丐丕丗下;
        private PhotonView 丅丏三七丁丑丞丄丏;
        private bool 七丅丅世丆丆丗丟丐;
        private float 与丄丌丕一丅与万上;
        private float 丁丙丝七与丂一丈业;
        private float 丂不丟万专丄万丈一;
        private float 不三万三与一丙世三;
        private AdvancedEffects 三丑丂丘业丌东世丅;
        protected UnityEngine.Animation 且丈丘三丆一丟丌丐;
        internal bool 丞上丈丕丑万丕万一;
        protected RilisoftBot.BaseBot.丟丒下丙不丙上不丟 丛丏丄业丒与丂世丑;
        public float attackDistance;
        public float attackingSpeed;
        public float[] attackingSpeedRandomRange;
        protected UnityEngine.AudioSource 丞下上且一上丙不丏;
        public float delayForStartShooting;
        public float delayForContinuousShooting;
        public float delayAfterContinuousShooting;
        public float timeForShootMinigun;
        internal static float 丞丝丒丝世丈丟丞丗;
        internal static float 丐丗三丞丒丞上丟丆;
        internal static float 东丝丌丗丘东丁丐与;
        public MinigunController minigun;
        private RilisoftBot.七一丙世丏下丐丕世 _mobModuleType;
        internal RilisoftBot.BotAiController 下不丌万丙且一万东;
        public float damagePerHit;
        public float worldIndicationOffset;
        internal MobAudioComponent mobAudioComponent;
        public UnityEngine.AudioClip damageSound;
        private UnityEngine.WaitForSeconds 丅丂丌丙丞丌上且丈;
        public UnityEngine.AudioClip deathSound;
        public float detectRadius;
        public UnityEngine.Texture flashDeadthTexture;
        protected UnityEngine.SphereCollider 三丝丌丙丂世丈一丟;
        public float health;
        public float heightFlyOutHitEffect;
        public UnityEngine.GameObject attackEffect;
        public int indexMobPrefabForCoop;
        protected bool 一丟万七丒丒不与业;
        protected UnityEngine.BoxCollider 丏七东七丝丁丄丐一;
        public string nameBot;
        public float notAttackingSpeed;
        public UnityEngine.AudioClip runStepSound;
        public int scorePerKill;
        public UnityEngine.AudioClip stepSound;
        public UnityEngine.AudioClip attackSound;
        public UnityEngine.AudioClip takeDamageSound;
        public UnityEngine.AudioClip voiceMobSoud;
        public float timePlayerSountAttackSound;
        public int lifestealPercent;
        public bool becomeInvisible;
        public float invisibleCooldown;
        public float invisibleTime;
        private float 万下且丕丌世丒丞丑;
        private float 七丌丕万丅三不丛且;
        public UnityEngine.GameObject invisibleParticle;
        public UnityEngine.GameObject bodyObject;
        private bool <丄上丐丝东丘丅丙丈>k__BackingField;
        private bool <东世丐丘丏丂丑专三>k__BackingField;
        private bool <丟世不丌上丑丑下丙>k__BackingField;
        private float <丞丂丁丏上丞丞丟业>k__BackingField;
        private UnityEngine.SkinnedMeshRenderer _meshBot;
        private UnityEngine.Vector3 专丘丞七丌世丄七丘;
        private UnityEngine.Vector3 <丂丝世丐且丄丒三丘>k__BackingField;
        internal bool 一丕丐专一东丞下上;
        private RilisoftBot.丁且上万且丝丟且丏 _mobRole;
        internal bool 世丗万丞世丂丂丕丝;
        internal bool 七丄丆丛丌世丁且专;
        private static System.Action<RilisoftBot.BaseBot> 丘丘丌丐且世丈丁丛;
        private bool 三丝东丄东不不丅丞;
        private bool 三七丂丐丙丅丆三不;
        private float 丈丞丏丕业丕丛丗丕;
        private System.Collections.Generic.List<IMobeSettings> _listMobSettings;
        private IMobeSettings 丆丝丝丞不丙专丝东;
        public float additionalTimeDeath;
        private System.Action<RilisoftBot.BaseBot> 世丗三东东三东七上;
        private static System.Action<RilisoftBot.BaseBot> 丑丕丙丗丘丆不世丟;
        private bool 丟丄丒丒业丂东丟丈;
        private bool 三丘丞丛丑丄与丌一;
        public bool isAutomaticAnimationEnable;
        public float speedAnimationWalk;
        public float speedAnimationRun;
        public float speedAnimationAttack;
        public bool isFlyingSpeedLimit;
        public float maxFlyingSpeed;
        public UnityEngine.GameObject[] guards;
        internal const string 且七丛丒与下丟丗丝 = "BossGuard";
        public UnityEngine.GameObject[] spawnMobs;
        public float mobSpawnCooldown;
        private UnityEngine.Transform 专专丏下丐丂丂丅东;
        private bool 不业丄丘丗三丄丝丄;
        private System.Action<丅丙上七上一丐不下> 丐丝上七丘下上万七;
        private const int 丛丅丐丞一丑专专且 = 5;
        private const float 不业丒丙上下丙七丑 = 2;
        private int <专业丞不丟专专丐与>k__BackingField;
        private float <东丟丒东丗七万世且>k__BackingField;
        private UnityEngine.Coroutine 丒丕丟丁丐不丕丑业;
        private bool 丒业丂丗下丛丞专下;
        private System.Action<RilisoftBot.BaseBot, float, bool, Player_move_c.世不丟丂上丟与丌下> 丂丅丝丁丞丛万丈且;
        private System.Action 丆东与与丑丐丅与丈;
        private System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, float> 上万丙丆东不丅不丞;
        private bool 一东丌丙丒丛丆丄丐;
        private System.Action<RilisoftBot.BaseBot, float> 丝丄丆丙七丂丞上丙;
        private DisableWithDelay _particleObject;
        private float delayForDisableObject;
        private float 丈丁丆丈丁丁丆丄上;
        private System.Collections.Generic.List<RilisoftBot.万丗丛丘七丘万丏丈> 丌丒丆丛丟三丆专丕;
        private const int 且业七丒丞丈丟丛不 = 5;
        private UnityEngine.Vector3 丑丕七不万丝丛世三;
        private UnityEngine.Quaternion 丘丒丐一东一丙丆一;
        private float 丅业丛丌且丛丌世七;
        private float 七丗丁丕下七一丒万;
        protected RilisoftBot.BaseBot.丟丞丟丑与丈且丕且 丌丝世丟丗且丙专丄;
        
        // Properties
        public UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
        public UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
        public UnityEngine.Collider 丝且不七丂世丗下七 { get; }
        public UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
        public bool 丈丐丁不丙东世七丕 { get; }
        public UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
        protected UnityEngine.Animation 下丗不丞丄业与世下 { get; }
        internal RilisoftBot.七一丙世丏下丐丕世 七一丙世丏下丐丕世 { get; set; }
        internal bool 丁丞与不丌丁丞东东 { get; }
        internal bool 丂三丁三业丗丆丘专 { get; }
        public bool 丐丏丗丏东世丏丞丝 { get; set; }
        public bool 专丗丑三丛丝丏丗不 { get; set; }
        public bool 下丁丕丞丂丟一丝万 { get; set; }
        public float 丙丞丈丅丏世丛丈丛 { get; set; }
        internal float 丘丄丅上丘丛丑专不 { set; }
        internal UnityEngine.Vector3 业丘丆丟下一丛丅丒 { get; set; }
        internal RilisoftBot.丁且上万且丝丟且丏 丕丂东东丌与丅丏丟 { get; }
        internal UnityEngine.Vector3 丅丟丙且丐三丑丒不 { get; }
        public string 三三丐下专且三下三 { get; set; }
        public bool 丙丘一东世丑丌不业 { get; }
        public UnityEngine.AudioClip 丐丏丑东丒业丒与丂 { get; set; }
        public UnityEngine.AudioClip 丏一丝丄丅丂丂七业 { get; set; }
        public UnityEngine.AudioClip 万且专丁丞丁世丄丐 { get; set; }
        public UnityEngine.AudioClip 丙丙丂丑丕丒丝丗世 { get; set; }
        public float 世不上丂丁丟丒三东 { get; set; }
        public float 丆丈丌丙下丁丈丐丄 { get; set; }
        public float 且三丘且丗下三丆丐 { get; set; }
        public float 丙丏丞丁世丕下丄丑 { get; set; }
        public float 一丞丘丌专丌丆丕与 { get; set; }
        public float 且丝丕丏丈万丂业三 { get; set; }
        public int 丒丛且丒丟且上丛丒 { get; set; }
        public float[] 丐专丝世丟丑丐与丘 { get; set; }
        public bool 丕丘下丛丛世丕三上 { get; set; }
        public float 丅丄一东三丟一丅世 { get; set; }
        public float 丑丞东丙专且丐丌丄 { get; set; }
        public float 丄丂丐丏三丐丙丙丝 { get; set; }
        internal UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
        public int 丗且丗丞丝丄世上一 { get; set; }
        public float 丟丆丆丝东世一丒丐 { get; set; }
        public bool 丁丙世丕丐丕丞丈丂 { get; }
        internal bool 且七丈丄丑与丄一丘 { get; }
        
        // Methods
        public UnityEngine.Collider get_aimCollider()
        {
            return (UnityEngine.Collider)this.丏七东七丝丁丄丐一;
        }
        public UnityEngine.Collider get_bodyAimCollider()
        {
            return (UnityEngine.Collider)this.丏七东七丝丁丄丐一;
        }
        public UnityEngine.Collider get_headAimCollider()
        {
            return (UnityEngine.Collider)this.三丝丌丙丂世丈一丟;
        }
        public UnityEngine.Transform get_targetTransform()
        {
            return this.丌丟丄业且三丛丕丄();
        }
        public bool get_isTargetDead()
        {
            if(this.下世万业丗世且业丌 == false)
            {
                    return (bool)((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true) ? 1 : 0;
            }
            
            return true;
        }
        public UnityEngine.Vector3 get_currentTargetVelocity()
        {
            return new UnityEngine.Vector3() {x = this.<丂丝世丐且丄丒三丘>k__BackingField};
        }
        protected UnityEngine.Animation 丁丗丐丘丝不且与丞()
        {
            UnityEngine.Animation val_3;
            if(this.且丈丘三丆一丟丌丐 == 0)
            {
                    this.且丈丘三丆一丟丌丐 = this.GetComponentInChildren<UnityEngine.Animation>();
                return val_3;
            }
            
            val_3 = this.且丈丘三丆一丟丌丐;
            return val_3;
        }
        internal RilisoftBot.七一丙世丏下丐丕世 丙丕丁丅丁与丗丑丘()
        {
            RilisoftBot.七一丙世丏下丐丕世 val_2;
            if(GameConnect.且丞丁东丝丗上丈业() == true)
            {
                goto label_3;
            }
            
            RilisoftBot.丁且上万且丝丟且丏 val_2 = this._mobRole;
            val_2 = val_2 & 4294967294;
            if(val_2 != 2)
            {
                goto label_4;
            }
            
            label_3:
            val_2 = this._mobModuleType;
            return (RilisoftBot.七一丙世丏下丐丕世)val_2;
            label_4:
            val_2 = 0;
            return (RilisoftBot.七一丙世丏下丐丕世)val_2;
        }
        internal void 丝东丄东丄丙丘丝丗(RilisoftBot.七一丙世丏下丐丕世 丙业与丙丗丝不丈东)
        {
            this._mobModuleType = 丙业与丙丗丝不丈东;
        }
        internal bool 不世与丄上丏丁专七()
        {
            var val_2 = 0;
            return (bool);
        }
        internal bool 下丟丈万业丙丝丙丙()
        {
            var val_2 = 0;
            return (bool);
        }
        private void 丗丆丒丅不下丝丈丝(bool 丙业与丙丗丝不丈东)
        {
            this.<丄上丐丝东丘丅丙丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsDeath()
        {
            return (bool)this.<丄上丐丝东丘丅丙丈>k__BackingField;
        }
        private void 业丌丕与七且丑丅丅(bool 丙业与丙丗丝不丈东)
        {
            this.<东世丐丘丏丂丑专三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsFalling()
        {
            return (bool)this.<东世丐丘丏丂丑专三>k__BackingField;
        }
        private void 丘一丞上丟丝丟专丅(bool 丙业与丙丗丝不丈东)
        {
            this.<丟世不丌上丑丑下丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_needDestroyByMasterClient()
        {
            return (bool)this.<丟世不丌上丑丑下丙>k__BackingField;
        }
        public float get_baseHealth()
        {
            return (float)this.<丞丂丁丏上丞丞丟业>k__BackingField;
        }
        private void 东丘万丘丑丈丒三丌(float 丙业与丙丗丝不丈东)
        {
            this.<丞丂丁丏上丞丞丟业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丂丆东丕丐丄丗丒业(float 丙业与丙丗丝不丈东)
        {
            this.<丞丂丁丏上丞丞丟业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal UnityEngine.Vector3 丞世专丒上专且东东()
        {
            return new UnityEngine.Vector3() {x = this.<丂丝世丐且丄丒三丘>k__BackingField};
        }
        private void 三丙丐不丄三丂上丘(UnityEngine.Vector3 丙业与丙丗丝不丈东)
        {
            this.<丂丝世丐且丄丒三丘>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921540932516152] = 丙业与丙丗丝不丈东.y;
            mem[1152921540932516156] = 丙业与丙丗丝不丈东.z;
        }
        internal RilisoftBot.丁且上万且丝丟且丏 与丛上丙丟丘三世丁()
        {
            return (RilisoftBot.丁且上万且丝丟且丏)this._mobRole;
        }
        internal UnityEngine.Vector3 万丈且与七下上不专()
        {
            UnityEngine.BoxCollider val_10;
            float val_11;
            float val_12;
            float val_13;
            if(this.丏七东七丝丁丄丐一 != 0)
            {
                    UnityEngine.Vector3 val_3 = this.丏七东七丝丁丄丐一.transform.position;
                val_10 = this.丏七东七丝丁丄丐一;
                val_11 = val_3.x;
                val_12 = val_3.y;
                val_13 = val_3.z;
                UnityEngine.Vector3 val_4 = val_10.center;
                return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            }
            
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    UnityEngine.Vector3 val_7 = this.三丝丌丙丂世丈一丟.transform.position;
                val_10 = this.三丝丌丙丂世丈一丟;
                val_11 = val_7.x;
                val_12 = val_7.y;
                val_13 = val_7.z;
                UnityEngine.Vector3 val_8 = val_10.center;
                return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            }
            
            UnityEngine.Transform val_9 = this.transform;
            if(val_9 != null)
            {
                    return val_9.position;
            }
            
            return val_9.position;
        }
        protected virtual void Awake()
        {
            var val_11;
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    DungeonsController.丈专丑专丙丌丞丑三(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void RilisoftBot.BaseBot::业七丘一丞丑丕丅丅(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
                DungeonsController.业丘不丂世丑且万丂(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void RilisoftBot.BaseBot::丝且丘七丟专丄丙丙(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
            }
            
            this.三丑丂丘业丌东世丅 = this.gameObject.AddComponent<AdvancedEffects>();
            this.丟七丐丏且丁丂丘世 = this.GetComponent<RilisoftBot.丅丅世丙丄丛丌丞丂>();
            this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
            this.一丟万七丒丒不与业 = false;
            this.丅丂丌丙丞丌上且丈 = new UnityEngine.WaitForSeconds(seconds:  this.damageSound.length);
            val_11 = null;
            val_11 = null;
            bool val_10 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞.Add(item:  this);
        }
        protected virtual void Update()
        {
            float val_12;
            var val_13;
            var val_14;
            if(this.下不丌万丙且一万东.丛丘丌丝丟且丕丐丂 == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
            val_12 = val_2.x;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.专丘丞七丌世丄七丘, y = V11.16B, z = V10.16B});
            this.<丂丝世丐且丄丒三丘>k__BackingField = val_3;
            mem[1152921540933173048] = val_3.y;
            mem[1152921540933173052] = val_3.z;
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            this.专丘丞七丌世丄七丘 = val_5;
            mem[1152921540933173036] = val_5.y;
            mem[1152921540933173040] = val_5.z;
            this.UpdateDebuffState();
            this.丐丒下东世丗丑丘丒();
            val_13 = null;
            val_13 = null;
            if((((ZombieCreator.丞丈丟丒丂丞丏不丑 != 0) && (this.一丟万七丒丒不与业 != false)) && (this.spawnMobs != null)) && (this.spawnMobs.Length != 0))
            {
                    if(this.与丄丌丕一丅与万上 > 0f)
            {
                    val_12 = this.与丄丌丕一丅与万上 - UnityEngine.Time.deltaTime;
                this.与丄丌丕一丅与万上 = val_12;
            }
            else
            {
                    val_14 = null;
                val_14 = null;
                ZombieCreator.丞丈丟丒丂丞丏不丑.丏丗一丁万丗丟丐业(下丒丌万上与丙丑专:  this);
                this.与丄丌丕一丅与万上 = this.mobSpawnCooldown;
            }
            
            }
            
            if(this.becomeInvisible == false)
            {
                goto label_26;
            }
            
            if(this.七丅丅世丆丆丗丟丐 == false)
            {
                goto label_21;
            }
            
            if(this.丁丙丝七与丂一丈业 <= 0f)
            {
                goto label_22;
            }
            
            val_12 = this.丁丙丝七与丂一丈业 - UnityEngine.Time.deltaTime;
            this.丁丙丝七与丂一丈业 = val_12;
            goto label_26;
            label_21:
            if(this.丂不丟万专丄万丈一 <= 0f)
            {
                goto label_24;
            }
            
            val_12 = this.丂不丟万专丄万丈一 - UnityEngine.Time.deltaTime;
            this.丂不丟万专丄万丈一 = val_12;
            goto label_26;
            label_22:
            this.丅丟万下三丝丆丏丐(且且与丛七丗上丛三:  false);
            this.丂不丟万专丄万丈一 = this.invisibleCooldown;
            goto label_26;
            label_24:
            this.丅丟万下三丝丆丏丐(且且与丛七丗上丛三:  true);
            this.丁丙丝七与丂一丈业 = this.invisibleTime;
            label_26:
            if(this.不三万三与一丙世三 <= 0f)
            {
                    return;
            }
            
            float val_10 = UnityEngine.Time.deltaTime;
            val_10 = this.不三万三与一丙世三 - val_10;
            this.不三万三与一丙世三 = val_10;
            if(val_10 > 0f)
            {
                    return;
            }
            
            this.不三万三与一丙世三 = 0f;
            if(this.attackEffect == 0)
            {
                    return;
            }
            
            this.attackEffect.SetActive(value:  false);
        }
        private void 丅丟万下三丝丆丏丐(bool 且且与丛七丗上丛三)
        {
            var val_1 = (this.七丅丅世丆丆丗丟丐 == true) ? 1 : 0;
            val_1 = val_1 ^ 且且与丛七丗上丛三;
            if(val_1 == false)
            {
                    return;
            }
            
            this.七丅丅世丆丆丗丟丐 = 且且与丛七丗上丛三;
            且且与丛七丗上丛三 = (~且且与丛七丗上丛三) & 1;
            this.bodyObject.SetActive(value:  且且与丛七丗上丛三);
            this.invisibleParticle.SetActive(value:  且且与丛七丗上丛三);
        }
        internal static void 专上丟三业专且丆丅(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  RilisoftBot.BaseBot.丘丘丌丐且世丈丁丛, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(RilisoftBot.BaseBot.丘丘丌丐且世丈丁丛 != 1152921505352962064);
        
        }
        internal static void 且丒且丌丞丝且丛丘(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  RilisoftBot.BaseBot.丘丘丌丐且世丈丁丛, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(RilisoftBot.BaseBot.丘丘丌丐且世丈丁丛 != 1152921505352962064);
        
        }
        protected virtual void 上丛丌丆丑上七世三()
        {
            var val_16;
            System.Action<RilisoftBot.BaseBot> val_17;
            bool val_18;
            val_16 = null;
            val_16 = null;
            val_17 = RilisoftBot.BaseBot.丘丘丌丐且世丈丁丛;
            if(val_17 != null)
            {
                    val_17 = RilisoftBot.BaseBot.丘丘丌丐且世丈丁丛;
                if(val_17 == null)
            {
                    val_17 = 0;
            }
            
                val_17.Invoke(obj:  this);
            }
            
            this.丛丏丄业丒与丂世丑 = new BaseBot.丟丒下丙不丙上不丟();
            this.东丁丗丞业万丘与丂();
            PhotonView val_2 = this.GetComponent<PhotonView>();
            this.丅丏三七丁丑丞丄丏 = val_2;
            if(val_2 != 0)
            {
                    if((GameConnect.丙丘不世专且万丄丐() != true) && (GameConnect.且丞丁东丝丗上丈业() != true))
            {
                    if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_21;
            }
            
            }
            
            }
            
                val_18 = UnityEngine.Object.op_Equality(x:  PolygonController.一下一万丄丅丘且丑, y:  0);
            }
            else
            {
                    label_21:
                val_18 = false;
            }
            
            this.丑一业丟上丐丕丗下 = val_18;
            UnityEngine.Animation val_9 = this.GetComponentInChildren<UnityEngine.Animation>();
            this.且丈丘三丆一丟丌丐 = val_9;
            val_9.Stop();
            this.下不丌万丙且一万东 = this.GetComponentInParent<RilisoftBot.BotAiController>();
            this.丏七东七丝丁丄丐一 = this.GetComponentInChildren<UnityEngine.BoxCollider>();
            this.三丝丌丙丂世丈一丟 = this.GetComponentInChildren<UnityEngine.SphereCollider>();
            System.DateTime val_13 = System.DateTime.Now;
            long val_14 = val_13.dateData.Ticks;
            val_14 = val_14 & 65535;
            UnityEngine.Random.seed = val_14;
            this.丝丙万丘丅万丛丟一();
            this.丞与丗丐丈丄丌丅丁();
            this.<丟世不丌上丑丑下丙>k__BackingField = false;
            this.<丞丂丁丏上丞丞丟业>k__BackingField = this.health;
            this.丂不丟万专丄万丈一 = this.invisibleCooldown;
        }
        internal virtual void 下丌业业丐丘丐丘三()
        {
            if(this.minigun == 0)
            {
                    return;
            }
            
            this.minigun.enabled = true;
        }
        internal virtual void 不与丞下业丑丒丙万()
        {
            if(this.minigun != 0)
            {
                    this.minigun.enabled = false;
            }
            
            if(this.attackEffect == 0)
            {
                    return;
            }
            
            this.attackEffect.SetActive(value:  false);
        }
        private void 业七丘一丞丑丕丅丅(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
        {
            if(专丞上七七且丝七丗 == null)
            {
                    return;
            }
            
            if(this.丑一业丟上丐丕丗下 == false)
            {
                    return;
            }
            
            if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                    return;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = this.health;
            this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  61, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
        }
        private void Start()
        {
            UnityEngine.Animation val_22;
            string val_23;
            var val_24;
            var val_25;
            val_22 = this;
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) != false)
            {
                    val_23 = this.丛丏丄业丒与丂世丑.丈丒丟上七丝且业丅;
                if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[val_23])) == false)
            {
                    return;
            }
            
                val_22 = this.且丈丘三丆一丟丌丐;
                val_22.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丈丒丟上七丝且业丅);
                return;
            }
            
            if(this.丑一业丟上丐丕丗下 != false)
            {
                    if(this.丅丏三七丁丑丞丄丏.isMine != false)
            {
                    object[] val_7 = new object[1];
                val_23 = val_7;
                val_23[0] = this.health;
                this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  61, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_7);
            }
            
            }
            
            UnityEngine.Vector3 val_9 = this.丌丟丄业且三丛丕丄().position;
            this.专丘丞七丌世丄七丘 = val_9;
            mem[1152921540934435692] = val_9.y;
            mem[1152921540934435696] = val_9.z;
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    DungeonsController.丒与丒丄丏东万上丛(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void RilisoftBot.BaseBot::丝且丘七丟专丄丙丙(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
            }
            
            if(this.丑一业丟上丐丕丗下 != true)
            {
                    val_23 = 1152921505292148736;
                val_24 = null;
                val_24 = null;
                if(ZombieCreator.丞丈丟丒丂丞丏不丑 != 0)
            {
                    val_25 = null;
                val_25 = null;
                if(ZombieCreator.丞丈丟丒丂丞丏不丑 != null)
            {
                    val_23 = ZombieCreator.丞丈丟丒丂丞丏不丑.且世三丘丕丞丏万万();
            }
            else
            {
                    val_23 = 0.且世三丘丕丞丏万万();
            }
            
                ZombieCreator.丞丈丟丒丂丞丏不丑.专东丒世且丞丝下丞(丙业与丙丗丝不丈东:  val_23 + 1);
            }
            
            }
            
            this.丒东丕丙且上不一丆 = this.GetComponentsInChildren<BotChangeDamageMaterial>(includeInactive:  true);
            this.七丘丟丕丛东丘七不();
            this.RegisterBot();
            if(this.丟七丐丏且丁丂丘世 == null)
            {
                goto label_32;
            }
            
            label_40:
            label_41:
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_36;
            label_32:
            RilisoftBot.PortalEnemyEffectsManager val_18 = this.gameObject.GetComponent<RilisoftBot.PortalEnemyEffectsManager>();
            this.丟七丐丏且丁丂丘世 = val_18;
            if(val_18 != null)
            {
                goto label_38;
            }
            
            RilisoftBot.PortalEnemyEffectsManager val_20 = this.gameObject.AddComponent<RilisoftBot.PortalEnemyEffectsManager>();
            this.丟七丐丏且丁丂丘世 = val_20;
            if(val_20 != null)
            {
                goto label_40;
            }
            
            goto label_41;
            label_36:
            this.丟七丐丏且丁丂丘世.ShowSpawnEffect();
            label_38:
            this.PlayVoiceSound();
        }
        public void RegisterBot()
        {
            if(this.三丝东丄东不不丅丞 != false)
            {
                    if(((this.三七丂丐丙丅丆三不 == true) ? 1 : 0) == ((this.世丗万丞世丂丂丕丝 == true) ? 1 : 0))
            {
                    return;
            }
            
            }
            
            this.三丝东丄东不不丅丞 = true;
            if((丘丛丞且一丅丁丏丐.丁丕丛丘丈丌与丙七(丞下万上三丘上与专:  this.丌丟丄业且三丛丕丄())) != false)
            {
                    丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  (this.三七丂丐丙丅丆三不 == true) ? 2 : 5);
            }
            
            this.三七丂丐丙丅丆三不 = this.世丗万丞世丂丂丕丝;
            if((丘丛丞且一丅丁丏丐.丁丕丛丘丈丌与丙七(丞下万上三丘上与专:  this.丌丟丄业且三丛丕丄())) != true)
            {
                    丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  (this.世丗万丞世丂丂丕丝 == true) ? 2 : 5);
            }
            
            丘丛丞且一丅丁丏丐.丙丅丅丆丂一上业丐(不丂丅丁且丆东东丂:  this.丌丟丄业且三丛丕丄(), 丞下万上三丘上与专:  this);
        }
        public void SetXRayShader(bool 丛丅丘一丏丙且丌上)
        {
            if(this.丒东丕丙且上不一丆 == null)
            {
                    return;
            }
            
            if(this.丒东丕丙且上不一丆.Length < 1)
            {
                    return;
            }
            
            do
            {
                this.丒东丕丙且上不一丆[0].SetXRayShader(丛丅丘一丏丙且丌上:  丛丅丘一丏丙且丌上);
            }
            while((0 + 1) < this.丒东丕丙且上不一丆.Length);
        
        }
        public virtual void DelayShootAfterEvent(float 丆丐七丅丆丗丛上与)
        {
        
        }
        private UnityEngine.Texture 万一丏丗一丐下丁丅()
        {
            if(val_1.Length == 0)
            {
                    return 0;
            }
            
            var val_4 = -4294967296;
            val_4 = val_4 + ((val_1.Length) << 32);
            UnityEngine.Material val_3 = this.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  true)[val_4 >> 32].material;
            if(val_3 != null)
            {
                    return val_3.mainTexture;
            }
            
            return val_3.mainTexture;
        }
        private void 东丁丗丞业万丘与丂()
        {
            UnityEngine.Object val_9;
            var val_10;
            val_9 = this;
            val_10 = null;
            val_10 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if(GameConnect.丙丘不世专且万丄丐() == true)
            {
                    return;
            }
            
            if(GameConnect.且丞丁东丝丗上丈业() == true)
            {
                    return;
            }
            
            if(GameConnect.丅丟下专不丁一丈七() == true)
            {
                    return;
            }
            
            if(GameConnect.七丂万专且丏丘一丙() == true)
            {
                    return;
            }
            
            UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Inequality(a:  val_5.m_Handle.name, b:  "FortFieldBuild")) == false)
            {
                    return;
            }
            
            val_9 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  val_9);
        }
        public void OrientToTarget(UnityEngine.Vector3 丙丌丛丘丗与一专丁)
        {
            this.丌丟丄业且三丛丕丄().LookAt(worldPosition:  new UnityEngine.Vector3() {x = 丙丌丛丘丗与一专丁.x, y = 丙丌丛丘丗与一专丁.y, z = 丙丌丛丘丗与一专丁.z});
        }
        public void PlayAnimationIdle()
        {
            this.且丈丘三丆一丟丌丐.Stop();
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) != false)
            {
                    return;
            }
            
            if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丈丒丟上七丝且业丅])) != false)
            {
                    this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丈丒丟上七丝且业丅);
            }
            
            this.StopStepsAudio();
        }
        public void PlayAnimationWalk()
        {
            string val_3;
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) != false)
            {
                    return;
            }
            
            this.且丈丘三丆一丟丌丐.Stop();
            bool val_2 = UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.业业丙下丕业东业丑]);
            if(this.丛丏丄业丒与丂世丑 == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                goto label_5;
            }
            
            label_8:
            val_3 = this.丛丏丄业丒与丂世丑.业业丙下丕业东业丑;
            if(this.且丈丘三丆一丟丌丐 != null)
            {
                goto label_9;
            }
            
            goto label_7;
            label_4:
            if(val_2 == true)
            {
                goto label_8;
            }
            
            label_5:
            val_3 = this.丛丏丄业丒与丂世丑.丄丄丛万丁丐丐与丏;
            if(this.且丈丘三丆一丟丌丐 != null)
            {
                goto label_9;
            }
            
            label_7:
            label_9:
            this.且丈丘三丆一丟丌丐.CrossFade(animation:  val_3);
            this.PlayWalkStepSound();
        }
        private void 丞丛且丂与丒丛业丟()
        {
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) != false)
            {
                    return;
            }
            
            if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丄丄丛万丁丐丐与丏])) != false)
            {
                    this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丄丄丛万丁丐丐与丏);
            }
            
            this.PlayRunStepSound();
        }
        internal void 业下丄丆上七且且丑()
        {
            this.mobAudioComponent.业下丄丆上七且且丑();
        }
        private void 业下丄丆上七且且丑(bool 丞专丙万丕不丗丈丛)
        {
            float val_5;
            if(this.mobAudioComponent != 0)
            {
                    return;
            }
            
            if((丞专丙万丕不丗丈丛 != false) && (this.timePlayerSountAttackSound == 0f))
            {
                    this.丈丞丏丕业丕丛丗丕 = 0f;
            }
            
            if(this.丈丞丏丕业丕丛丗丕 > 0f)
            {
                    val_5 = this.丈丞丏丕业丕丛丗丕 - UnityEngine.Time.deltaTime;
            }
            else
            {
                    this.TryPlayAudioClip(丆与丈丏丟七丁东丛:  this.attackSound);
                val_5 = this.timePlayerSountAttackSound;
            }
            
            this.丈丞丏丕业丕丛丗丕 = this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄].length;
        }
        private void 丄丄七丗丁丗丂业丙()
        {
            if(this.attackEffect == 0)
            {
                    return;
            }
            
            this.attackEffect.gameObject.SetActive(value:  true);
            this.不三万三与一丙世三 = 0.3f;
        }
        protected virtual void 丞丟丗丕丒下丞丟丑()
        {
            if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄])) == false)
            {
                goto label_3;
            }
            
            if(this.attackSound != 0)
            {
                    string val_7 = this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄;
                val_7 = (~(this.且丈丘三丆一丟丌丐.IsPlaying(name:  val_7))) & 1;
                this.业下丄丆上七且且丑(丞专丙万丕不丗丈丛:  val_7);
            }
            
            this.丄丄七丗丁丗丂业丙();
            if(this.且丈丘三丆一丟丌丐 != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.丙丝丞一丏专丘丐丄);
            goto label_14;
            label_3:
            if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丌丄丏下七丁专丂世])) == false)
            {
                goto label_14;
            }
            
            if(this.且丈丘三丆一丟丌丐 != null)
            {
                goto label_16;
            }
            
            goto label_17;
            label_14:
            this.StopStepsAudio();
        }
        protected virtual void 丗丈且丁上丗丗业上()
        {
            if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.专丅丟丏丂丅东丑万])) != false)
            {
                    this.且丈丘三丆一丟丌丐.CrossFade(animation:  this.丛丏丄业丒与丂世丑.专丅丟丏丂丅东丑万);
            }
            
            this.StopStepsAudio();
        }
        private void 丝丙万丘丅万丛丟一()
        {
            float val_3 = this.attackingSpeed;
            float val_3 = this.attackingSpeedRandomRange[0];
            if(this.isAutomaticAnimationEnable != false)
            {
                    val_3 = val_3 - val_3;
                val_3 = val_3 / this.attackingSpeed;
                float val_4 = this.attackingSpeedRandomRange[1];
                float val_5 = this.attackingSpeed;
                val_4 = this.attackingSpeed + val_4;
                val_5 = val_4 / val_5;
                this.speedAnimationRun = UnityEngine.Random.Range(min:  val_3, max:  val_5);
                return;
            }
            
            float val_2 = UnityEngine.Random.Range(min:  -val_3, max:  this.attackingSpeedRandomRange[1]);
            val_2 = val_3 + val_2;
            this.attackingSpeed = val_2;
        }
        private void 且丅丕丟下三东七业()
        {
            var val_5;
            if(this.一丟万七丒丒不与业 == true)
            {
                    return;
            }
            
            if(this.丄丘丞丟七丂丆万且() == true)
            {
                    return;
            }
            
            ZombieCreator.东上不丝丌丗丂下丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RilisoftBot.BaseBot::丟丏三丞丂丏上三且()));
            if(ZombieCreator.丞丈丟丒丂丞丏不丑 == 0)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if(ZombieCreator.丞丈丟丒丂丞丏不丑.丌万与丝丒世丅三丆() == false)
            {
                    return;
            }
            
            this.丟丏三丞丂丏上三且();
        }
        internal void 丞与丗丐丈丄丌丅丁()
        {
            float val_40;
            string val_41;
            var val_42;
            RilisoftBot.BotAiController val_43;
            float val_44;
            float val_45;
            var val_46;
            RilisoftBot.BotAiController val_47;
            float val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            float val_40 = (this.isAutomaticAnimationEnable == false) ? this.notAttackingSpeed : this.speedAnimationWalk;
            float val_41 = (this.isAutomaticAnimationEnable == false) ? this.attackingSpeed : this.speedAnimationRun;
            if(this.丑一业丟上丐丕丗下 == false)
            {
                goto label_1;
            }
            
            label_98:
            val_40 = this.health;
            float val_3 = DungeonsController.且丗与丈丆丘丙丑丞();
            val_3 = val_40 * val_3;
            this.health = val_3;
            float val_4 = DungeonsController.上丂丂丂且丟丝业丘();
            val_4 = this.damagePerHit * val_4;
            this.damagePerHit = val_4;
            val_41 = 1152921505352957952;
            val_42 = null;
            val_42 = null;
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_8;
            }
            
            float val_6 = DungeonsController.丟丌专与丈丛丑三丅();
            val_6 = this.health * val_6;
            this.health = val_6;
            float val_7 = DungeonsController.七业与不上丏丌丈丌();
            val_43 = this.下不丌万丙且一万东;
            val_7 = this.damagePerHit * val_7;
            this.damagePerHit = val_7;
            if(val_43 == null)
            {
                goto label_11;
            }
            
            val_44 = this.下不丌万丙且一万东.healthRegen;
            val_45 = DungeonsController.且丗与丈丆丘丙丑丞();
            goto label_12;
            label_1:
            if((PolygonController.一下一万丄丅丘且丑 == 0) || ((PolygonController.一下一万丄丅丘且丑 + 24) == 0))
            {
                goto label_17;
            }
            
            float val_10 = PolygonController.一下一万丄丅丘且丑.丄七丐业丕丏丅丘丞();
            val_10 = this.health * val_10;
            this.health = val_10;
            goto label_98;
            label_17:
            if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if(GameConnect.万七丄丛丈丟专一丑() == false)
            {
                goto label_25;
            }
            
            }
            
            if(GameConnect.丌专丌万一下丕专上() == false)
            {
                goto label_98;
            }
            
            val_46 = null;
            val_46 = null;
            if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 == 2)
            {
                goto label_32;
            }
            
            if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 == 1)
            {
                goto label_33;
            }
            
            if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 != 0)
            {
                goto label_34;
            }
            
            float val_42 = this.health;
            val_40 = val_40 * 0.75f;
            val_41 = val_41 * 0.75f;
            val_42 = val_42 * 0.7f;
            this.health = val_42;
            goto label_98;
            label_11:
            val_43 = 164;
            val_44 = 0f;
            float val_14 = DungeonsController.且丗与丈丆丘丙丑丞();
            val_45 = val_14;
            label_12:
            val_14 = val_45 * val_44;
            mem[164] = val_14;
            val_47 = this.下不丌万丙且一万东;
            if(val_47 != null)
            {
                    val_48 = this.下不丌万丙且一万东.healthRegen;
                val_40 = DungeonsController.丟丌专与丈丛丑三丅();
            }
            else
            {
                    val_47 = 164;
                val_48 = mem[164];
                float val_16 = DungeonsController.丟丌专与丈丛丑三丅();
                val_40 = val_16;
            }
            
            val_16 = val_40 * val_48;
            mem[164] = val_16;
            label_8:
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_76;
            }
            
            }
            
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆() == null))
            {
                goto label_76;
            }
            
            val_49 = null;
            val_49 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丂且丏丅丞丏丞一丗)) == false)
            {
                goto label_57;
            }
            
            val_40 = this.health;
            世丁与丕丗丟丒丆上 val_25 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            if(val_25 == null)
            {
                goto label_60;
            }
            
            val_50 = val_25.丑丗三丛丛丆丟丌丆();
            if(val_50 == null)
            {
                goto label_65;
            }
            
            val_51 = null;
            val_51 = null;
            val_50 = val_50.Item[GameConnect.丂且丏丅丞丏丞一丗];
            if(val_25 != null)
            {
                    if(this != null)
            {
                goto label_65;
            }
            
            }
            
            val_52 = 0;
            goto label_66;
            label_25:
            val_41 = val_41 * 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
            float val_29 = 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
            val_29 = this.health * val_29;
            this.health = val_29;
            val_40 = val_40 * 与丂丏丛丞丞丒丟丄.丒下一丂下丁丘丞丁();
            goto label_98;
            label_60:
            val_50 = 0;
            label_65:
            val_52 = this;
            label_66:
            float val_43 = 13073.37f;
            val_43 = val_40 * val_43;
            this.health = val_43;
            label_57:
            val_53 = null;
            val_53 = null;
            val_41 = GameConnect.丛专丌丅丁万丅丙丒;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_41)) == false)
            {
                goto label_76;
            }
            
            val_40 = this.damagePerHit;
            世丁与丕丗丟丒丆上 val_34 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            if(val_34 == null)
            {
                goto label_79;
            }
            
            val_41 = val_34.丑丗三丛丛丆丟丌丆();
            if(val_41 == null)
            {
                goto label_84;
            }
            
            val_54 = null;
            val_54 = null;
            val_41 = val_41.Item[GameConnect.丛专丌丅丁万丅丙丒];
            if(val_34 != null)
            {
                    if(this != null)
            {
                goto label_84;
            }
            
            }
            
            val_55 = 0;
            goto label_85;
            label_79:
            val_41 = 0;
            label_84:
            val_55 = this;
            label_85:
            float val_44 = 13073.37f;
            val_44 = val_40 * val_44;
            this.damagePerHit = val_44;
            label_76:
            float val_37 = val_41 * RilisoftBot.BaseBot.丐丗三丞丒丞上丟丆;
            this.<东丟丒东丗七万世且>k__BackingField = this.health;
            if(this.isAutomaticAnimationEnable != false)
            {
                    mem2[0] = val_40;
                mem2[0] = val_37;
            }
            else
            {
                    mem2[0] = val_40;
                mem2[0] = val_37;
            }
            
            if(GameConnect.丌专丌万一下丕专上() != true)
            {
                    if((GameConnect.万七丄丛丈丟专一丑() != true) && (this.丑一业丟上丐丕丗下 != true))
            {
                    this.且丅丕丟下三东七业();
            }
            
            }
            
            this.丐七丌丆丂丝不下丟();
            return;
            label_32:
            float val_45 = 0.9f;
            val_40 = val_40 * val_45;
            val_41 = val_41 * val_45;
            val_45 = this.health * val_45;
            this.health = val_45;
            goto label_98;
            label_33:
            float val_46 = this.health;
            val_40 = val_40 * 0.85f;
            val_41 = val_41 * 0.85f;
            val_46 = val_46 * 0.8f;
            this.health = val_46;
            goto label_98;
            label_34:
            if(ZombieCreator.丞丈丟丒丂丞丏不丑.丘丂丄丗丙丅丈丏下 < 7)
            {
                goto label_98;
            }
            
            val_40 = val_40 * 1.25f;
            val_41 = val_41 * 1.25f;
            goto label_98;
        }
        private void 丐七丌丆丂丝不下丟()
        {
            var val_3;
            var val_10;
            string val_11;
            val_10 = this;
            List.Enumerator<T> val_1 = this._listMobSettings.GetEnumerator();
            val_11 = 1152921540937613072;
            label_10:
            if((1971063280 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4 != 0)
            {
                goto label_5;
            }
            
            UnityEngine.Debug.LogError(message:  "Mob Settings is Null " + this.name);
            goto label_10;
            label_5:
            if((val_4 & 1) == 0)
            {
                goto label_10;
            }
            
            val_11 = this.name;
            string val_9 = 丞东丑专丛丆丄丝世.丄丘一丐上丕丌一丏(下业七不丑丂丏丟东:  val_11);
            this.丆丝丝丞不丙专丝东 = val_4;
            this.丞丏不丂万丂且上丙(下丑上不东丌丄丞万:  val_4);
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 且丙丅丗丗丐且丟丛(float 且万丕丏且丛丂丛丐)
        {
            List.Enumerator<T> val_1 = this._listMobSettings.GetEnumerator();
            label_10:
            if((1971216456 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_5;
            }
            
            val_2.丘丛丞东丞丝丄丕丕(丏丑东丕丑丌丒丄且:  且万丕丏且丛丂丛丐);
            goto label_10;
            label_5:
            UnityEngine.Debug.LogError(message:  "Почистите _listMobSettings один из элементов массива null у моба " + this.name);
            goto label_10;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丞丏不丂万丂且上丙(IMobeSettings 下丑上不东丌丄丞万)
        {
            var val_17;
            var val_18;
            float val_19;
            var val_20;
            var val_21;
            var val_22;
            val_18 = this;
            val_19 = 下丑上不东丌丄丞万.health;
            if(val_19 == 0f)
            {
                goto label_2;
            }
            
            float val_1 = DungeonsController.且丗与丈丆丘丙丑丞();
            val_1 = val_19 * val_1;
            this.health = val_1;
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_24;
            }
            
            }
            
            if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
            {
                goto label_24;
            }
            
            val_17 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            if(val_17.丑丗三丛丛丆丟丌丆() == null)
            {
                goto label_24;
            }
            
            val_20 = null;
            val_17 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
            val_20 = null;
            if((val_17.ContainsKey(key:  GameConnect.丂且丏丅丞丏丞一丗)) == false)
            {
                goto label_24;
            }
            
            val_19 = this.health;
            世丁与丕丗丟丒丆上 val_10 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            if(val_10 == null)
            {
                goto label_27;
            }
            
            val_21 = val_10.丑丗三丛丛丆丟丌丆();
            if(val_21 == null)
            {
                goto label_32;
            }
            
            val_22 = null;
            val_22 = null;
            val_21 = val_21.Item[GameConnect.丂且丏丅丞丏丞一丗];
            if(val_10 != null)
            {
                    if(this != null)
            {
                goto label_32;
            }
            
            }
            
            val_17 = 0;
            goto label_33;
            label_27:
            val_21 = 0;
            label_32:
            val_17 = val_18;
            label_33:
            float val_17 = 13073.37f;
            val_17 = val_19 * val_17;
            this.health = val_17;
            label_24:
            this.<东丟丒东丗七万世且>k__BackingField = this.health;
            this.<丞丂丁丏上丞丞丟业>k__BackingField = this.health;
            label_2:
            if(下丑上不东丌丄丞万.agroZone != 0f)
            {
                    this.detectRadius = 下丑上不东丌丄丞万.agroZone;
            }
            
            if(下丑上不东丌丄丞万.speedWalk != 0f)
            {
                    this.notAttackingSpeed = 下丑上不东丌丄丞万.speedWalk;
            }
            
            if(下丑上不东丌丄丞万.speedChasing != 0f)
            {
                    this.attackingSpeed = 下丑上不东丌丄丞万.speedChasing;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 下丑上不东丌丄丞万.scale, y = val_19, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) != false)
            {
                    val_17 = this.丌丟丄业且三丛丕丄();
                val_17.localScale = new UnityEngine.Vector3() {x = 下丑上不东丌丄丞万.scale, y = V9.16B, z = 下丑上不东丌丄丞万.scale};
            }
            
            if(下丑上不东丌丄丞万.splash == 0f)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            var val_16 = (((RilisoftBot.BaseBot.__il2cppRuntimeField_typeHierarchy + (RilisoftBot.ShootingBot.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_18) : 0;
            mem2[0] = 下丑上不东丌丄丞万.splash;
        }
        internal void 丕业丞不丒不丗丛世(bool 世丁万下丗专世万丅)
        {
            UnityEngine.AnimationCullingType val_10;
            if((this.丁丗丐丘丝不且与丞() == 0) || (this.下不丌万丙且一万东.世万不丘丗专上丞业 == 0))
            {
                goto label_10;
            }
            
            UnityEngine.Animation val_4 = this.丁丗丐丘丝不且与丞();
            if(val_4 == null)
            {
                goto label_11;
            }
            
            if(世丁万下丗专世万丅 == false)
            {
                goto label_12;
            }
            
            label_14:
            val_10 = 0;
            goto label_13;
            label_11:
            if(世丁万下丗专世万丅 == true)
            {
                goto label_14;
            }
            
            label_12:
            val_10 = 1;
            label_13:
            val_4.cullingType = val_10;
            label_10:
            if(this._meshBot != 0)
            {
                    this._meshBot.gameObject.SetActive(value:  世丁万下丗专世万丅);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Боту " + this.name + "Не подкинут меш в meshBot");
        }
        private void 丟丏三丞丂丏上三且()
        {
            if(this.isAutomaticAnimationEnable != false)
            {
                    this.speedAnimationRun = UnityEngine.Mathf.Max(a:  this.speedAnimationRun, b:  1.5f);
            }
            else
            {
                    this.attackingSpeed = UnityEngine.Mathf.Max(a:  this.attackingSpeed, b:  3f);
            }
            
            this.detectRadius = 150f;
        }
        public float GetSquareAttackDistance()
        {
            float val_1 = this.attackDistance;
            val_1 = val_1 * val_1;
            return (float)val_1;
        }
        public float GetSquareDetectRadius()
        {
            float val_1 = this.detectRadius;
            val_1 = val_1 * val_1;
            return (float)val_1;
        }
        public void SetPositionForFallState()
        {
            UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_8 = this.丌丟丄业且三丛丕丄().position;
            float val_10 = -7f;
            val_10 = UnityEngine.Time.deltaTime * val_10;
            float val_9 = val_5.y + val_10;
            this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void PrepareDeath(bool isOwnerDamage = True)
        {
            RilisoftBot.BotAiController val_5;
            var val_6;
            int val_7;
            if(this.丑一业丟上丐丕丗下 != true)
            {
                    ZombieCreator.丟丙丅业丞丂上且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RilisoftBot.BaseBot::丟丏三丞丂丏上三且()));
            }
            
            this.下不丌万丙且一万东.isDetectPlayer = false;
            val_5 = this.下不丌万丙且一万东;
            if(this.下不丌万丙且一万东.下三丗丒专丐丘丐丆 != false)
            {
                    this.下不丌万丙且一万东.下三丗丒专丐丘丐丆 = false;
            }
            
            this.becomeInvisible = false;
            this.丅丟万下三丝丆丏丐(且且与丛七丗上丛三:  false);
            this.<丄上丐丝东丘丅丙丈>k__BackingField = true;
            if(isOwnerDamage != false)
            {
                    val_6 = null;
                val_6 = null;
                if(GameController.mode != null)
            {
                    val_7 = this.scorePerKill;
                val_5 = GameController.mode.丞丏丕丑丞丑丏丏丄();
            }
            else
            {
                    val_7 = this.scorePerKill;
                val_5 = 0.丞丏丕丑丞丑丏丏丄();
            }
            
                GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  val_5 + val_7);
            }
            
            this.丁丆丟丛丒丑丅丈三();
            this.丈上丐世一丅丘丏不();
        }
        protected virtual void 丑万万丞丘且与下丛()
        {
            float val_18;
            if(this.additionalTimeDeath > 0f)
            {
                    UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘与丁一丂丛不丏丛(丕丕世且下一与丝与:  this.additionalTimeDeath));
                return;
            }
            
            float val_3 = this.deathSound.length;
            val_18 = val_3;
            this.TryPlayDeathSound(丕丕世且下一与丝与:  val_3);
            this.且丈丘三丆一丟丌丐.Stop();
            if((UnityEngine.TrackedReference.op_Implicit(exists:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁])) != false)
            {
                    bool val_6 = this.且丈丘三丆一丟丌丐.Play(animation:  this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁);
                val_18 = UnityEngine.Mathf.Max(a:  val_18, b:  this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁].length);
                float val_11 = this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.万业上万丝丛不丅丁].length;
                val_11 = val_11 * 1.25f;
                UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.丕下丑丅下七七且丌(丕丕世且下一与丝与:  val_11));
            }
            else
            {
                    this.<东世丐丘丏丂丑专三>k__BackingField = true;
            }
            
            UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.七下下丗丕且万与丅(丕丕世且下一与丝与:  val_18));
            this.丏七东七丝丁丄丐一.enabled = false;
            if(this.三丝丌丙丂世丈一丟 == 0)
            {
                    return;
            }
            
            this.三丝丌丙丂世丈一丟.enabled = false;
        }
        private System.Collections.IEnumerator 丘与丁一丂丛不丏丛(float 丕丕世且下一与丝与)
        {
            BaseBot.业丆下不丐丕万丕丁 val_1 = new BaseBot.业丆下不丐丕万丕丁();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丕下丑丅下七七且丌(float 丕丕世且下一与丝与)
        {
            BaseBot.三上一丁下不丙万丑 val_1 = new BaseBot.三上一丁下不丙万丑();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        protected System.Collections.IEnumerator 七下下丗丕且万与丅(float 丕丕世且下一与丝与)
        {
            BaseBot.丄世丐丞一不丁专丌 val_1 = new BaseBot.丄世丐丞一不丁专丌();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        protected System.Collections.IEnumerator 丙与丄丗丟上下丑丐(float 丕丕世且下一与丝与)
        {
            BaseBot.世丙一丈丐丞丁与万 val_1 = new BaseBot.世丙一丈丐丞丁与万();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丝且丘七丟专丄丙丙(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
        {
            if(this.health > 0f)
            {
                    if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == false)
            {
                    return;
            }
            
            }
            
            if(this.下不丌万丙且一万东 != 0)
            {
                    if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null)
            {
                    this.下不丌万丙且一万东.丘丝丌丌丟丄丁丒七(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
            }
            
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丙与丄丗丟上下丑丐(丕丕世且下一与丝与:  0.5f));
        }
        private void 不专丒七丄七业丆一()
        {
            var val_3;
            丅丙上七上一丐不下 val_15;
            var val_16;
            var val_17;
            float val_18;
            val_15 = this;
            if(this.万下且丕丌世丒丞丑 <= 0f)
            {
                    return;
            }
            
            val_16 = null;
            val_16 = null;
            List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
            label_18:
            if((1973338560 & 1) == 0)
            {
                goto label_5;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_8 = val_4.transform.position;
            if(this.万下且丕丌世丒丞丑 <= (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})))
            {
                goto label_18;
            }
            
            if(this.丐丝上七丘下上万七 != null)
            {
                    this.丐丝上七丘下上万七.Invoke(obj:  0);
            }
            
            if(val_4 != null)
            {
                    val_18 = this.七丌丕万丅三不丛且;
            }
            else
            {
                    val_17 = 0;
                val_18 = this.七丌丕万丅三不丛且;
            }
            
            UnityEngine.Vector3 val_12 = this.万丈且与七下上不专();
            val_17.ApplyDamage(丞丈专下丈专业三丞:  val_18 * (val_4.丝世不丑丒丏丄丑专(丂上不世业丒三世丕:  this.丙丕丁丅丁与丗丑丘())), 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 丐丟丘世丁三丕专专:  16, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
            goto label_18;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丁丆丟丛丒丑丅丈三()
        {
            UnityEngine.GameObject[] val_8;
            var val_9;
            var val_10;
            val_8 = this.guards;
            if(this.guards.Length == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_8 = ZombieCreator.丞丈丟丒丂丞丏不丑;
            if(val_8 == 0)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_8;
            label_23:
            UnityEngine.GameObject val_8 = val_8.丏丒丏丂丞七丘丂丙()[0];
            if(val_8.gameObject != 0)
            {
                    if((val_6.<丄上丐丝东丘丅丙丈>k__BackingField) != true)
            {
                    RilisoftBot.BaseBot.丌丌且丏丟上丈丌世(万且万且丑丗且丌丆:  val_8.transform).业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  -2.147484E+09f, 一丗丈丛万丄世一丘:  0, 业一丘不万丂七上丝:  false, 丅业下不东丗丄与三:  0, 丝丅且丁万下业七万:  true);
            }
            
            }
            
            val_10 = 1;
            label_8:
            UnityEngine.GameObject[] val_7 = val_8.丏丒丏丂丞七丘丂丙();
            if(val_10 < val_7.Length)
            {
                goto label_23;
            }
        
        }
        private void 丈上丐世一丅丘丏不()
        {
            UnityEngine.GameObject[] val_8;
            var val_9;
            var val_10;
            val_8 = this.spawnMobs;
            if(this.spawnMobs.Length == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_8 = ZombieCreator.丞丈丟丒丂丞丏不丑;
            if(val_8 == 0)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_8;
            label_23:
            UnityEngine.GameObject val_8 = val_8.丒丏专丙世下丁三专()[0];
            if(val_8.gameObject != 0)
            {
                    if((val_6.<丄上丐丝东丘丅丙丈>k__BackingField) != true)
            {
                    RilisoftBot.BaseBot.丌丌且丏丟上丈丌世(万且万且丑丗且丌丆:  val_8.transform).业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  -2.147484E+09f, 一丗丈丛万丄世一丘:  0, 业一丘不万丂七上丝:  false, 丅业下不东丗丄与三:  0, 丝丅且丁万下业七万:  true);
            }
            
            }
            
            val_10 = 1;
            label_8:
            UnityEngine.GameObject[] val_7 = val_8.丒丏专丙世下丁三专();
            if(val_10 < val_7.Length)
            {
                goto label_23;
            }
        
        }
        internal virtual void 一七万丞丟三万丒丘()
        {
            if(this.minigun == 0)
            {
                    return;
            }
            
            this.minigun.丐丁不丅丁丝丑业丏();
        }
        protected virtual void 丞丐丅丆丕丕一丏丌()
        {
        
        }
        internal void 七东丘与丁丌三丛丐(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.世丗三东东三东七上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.世丗三东东三东七上 != this.世丗三东东三东七上);
        
        }
        internal void 万丗七丕专且丆丏丅(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.世丗三东东三东七上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.世丗三东东三东七上 != this.世丗三东东三东七上);
        
        }
        internal static void 丏下丁丒丟丝丂丄丐(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  RilisoftBot.BaseBot.丑丕丙丗丘丆不世丟, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(RilisoftBot.BaseBot.丑丕丙丗丘丆不世丟 != 1152921505352962072);
        
        }
        internal static void 丞七且上丌万下一丞(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  RilisoftBot.BaseBot.丑丕丙丗丘丆不世丟, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(RilisoftBot.BaseBot.丑丕丙丗丘丆不世丟 != 1152921505352962072);
        
        }
        private void OnDestroy()
        {
            var val_11;
            System.Action<RilisoftBot.BaseBot> val_12;
            this.下世万业丗世且业丌 = true;
            if(this.丒丕丟丁丐不丕丑业 != null)
            {
                    CoroutineRunner.Instance.StopCoroutine(routine:  this.丒丕丟丁丐不丕丑业);
            }
            
            if(this.丑一业丟上丐丕丗下 != true)
            {
                    ZombieCreator.丟丙丅业丞丂上且丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void RilisoftBot.BaseBot::丟丏三丞丂丏上三且()));
            }
            
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    DungeonsController.丄三丕东七下丒丒三(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void RilisoftBot.BaseBot::丝且丘七丟专丄丙丙(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
                DungeonsController.丈三丄丑东专丈丗丞(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void RilisoftBot.BaseBot::业七丘一丞丑丕丅丅(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
                DungeonsController.一丁丆丑丒丏万三丈(丙业与丙丗丝不丈东:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void RilisoftBot.BaseBot::丝且丘七丟专丄丙丙(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)));
            }
            
            if(this.世丗三东东三东七上 != null)
            {
                    this.世丗三东东三东七上.Invoke(obj:  this);
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = RilisoftBot.BaseBot.丑丕丙丗丘丆不世丟;
            if(val_12 != null)
            {
                    val_12 = RilisoftBot.BaseBot.丑丕丙丗丘丆不世丟;
                if(val_12 == null)
            {
                    val_12 = 0;
            }
            
                val_12.Invoke(obj:  this);
            }
            
            丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  (this.世丗万丞世丂丂丕丝 == true) ? 2 : 5);
            丘丛丞且一丅丁丏丐.丏丄丄东丒世专丌丁(不丂丅丁且丆东东丂:  this.丌丟丄业且三丛丕丄());
            bool val_10 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞.Remove(item:  this);
        }
        internal static RilisoftBot.BaseBot 丌丌且丏丟上丈丌世(UnityEngine.Transform 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 != null)
            {
                    return 万且万且丑丗且丌丆.GetComponent<RilisoftBot.BaseBot>();
            }
            
            return 万且万且丑丗且丌丆.GetComponent<RilisoftBot.BaseBot>();
        }
        public virtual bool CheckEnemyInAttackZone(float 七业三下专与丛丆丙)
        {
            return false;
        }
        public virtual UnityEngine.Vector3 GetHeadPoint()
        {
            UnityEngine.SphereCollider val_6;
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    val_6 = this.三丝丌丙丂世丈一丟;
                UnityEngine.Vector3 val_4 = val_6.center;
            }
            else
            {
                    val_6 = this.丏七东七丝丁丄丐一;
                UnityEngine.Vector3 val_5 = val_6.size;
                val_5.y = val_5.y * 0.75f;
            }
            
            val_5.y = val_2.y + val_5.y;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_5.y, z = val_2.z};
        }
        public UnityEngine.Vector3 GetBodyPoint()
        {
            UnityEngine.BoxCollider val_7;
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
            if(this.丏七东七丝丁丄丐一 != 0)
            {
                    val_7 = this.丏七东七丝丁丄丐一;
                UnityEngine.Vector3 val_4 = val_7.center;
            }
            else
            {
                    val_7 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_6 = val_7.position;
                val_6.y = val_6.y * 0.5f;
            }
            
            val_6.y = val_2.y + val_6.y;
            return new UnityEngine.Vector3() {x = val_2.x, y = val_6.y, z = val_2.z};
        }
        public virtual float GetMaxAttackDistance()
        {
            return 0f;
        }
        internal static void 与不丆且三丅上丆世(string 丄丙下丝丛丒七丂丘)
        {
        
        }
        public void TryPlayAudioClip(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
        {
            UnityEngine.AudioSource val_4;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            val_4 = this.丞下上且一上丙不丏;
            if(val_4 == 0)
            {
                    return;
            }
            
            if(丆与丈丏丟七丁东丛 == 0)
            {
                    return;
            }
            
            this.丞下上且一上丙不丏.PlayOneShot(clip:  丆与丈丏丟七丁东丛);
        }
        public void PlayVoiceSound()
        {
            if(this.mobAudioComponent != 0)
            {
                    this.mobAudioComponent.PlayVoiceSound();
                return;
            }
            
            this.TryPlayAudioClip(丆与丈丏丟七丁东丛:  this.voiceMobSoud);
        }
        public void PlayWalkStepSound()
        {
            if(this.mobAudioComponent != 0)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            if(this.stepSound == 0)
            {
                    return;
            }
            
            if(this.丞下上且一上丙不丏.clip == this.stepSound)
            {
                    return;
            }
            
            this.丞下上且一上丙不丏.loop = true;
            this.丞下上且一上丙不丏.clip = this.stepSound;
            this.丞下上且一上丙不丏.Play();
        }
        public void PlayRunStepSound()
        {
            if(this.mobAudioComponent != 0)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            if(this.runStepSound == 0)
            {
                    return;
            }
            
            if(this.丞下上且一上丙不丏.clip == this.runStepSound)
            {
                    return;
            }
            
            this.丞下上且一上丙不丏.loop = true;
            this.丞下上且一上丙不丏.clip = this.runStepSound;
            this.丞下上且一上丙不丏.Play();
        }
        public void StopStepsAudio()
        {
            UnityEngine.Object val_7;
            if(this.mobAudioComponent != 0)
            {
                    return;
            }
            
            if(this.stepSound == 0)
            {
                    return;
            }
            
            val_7 = this.丞下上且一上丙不丏.clip;
            if(val_7 != this.stepSound)
            {
                    val_7 = this.丞下上且一上丙不丏.clip;
                if(val_7 != this.runStepSound)
            {
                    return;
            }
            
            }
            
            this.丞下上且一上丙不丏.Pause();
            this.丞下上且一上丙不丏.clip = 0;
        }
        public void TryPlayDeathSound(float 丕丕世且下一与丝与)
        {
            if(this.mobAudioComponent != 0)
            {
                    this.mobAudioComponent.下丄丗丂丄丑丂丌丅();
                return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            if(this.丞下上且一上丙不丏 == 0)
            {
                    return;
            }
            
            if((this.万丏丝不三丘丄丅丞(丑丄一丝世业专丛不:  丕丕世且下一与丝与)) == false)
            {
                    return;
            }
            
            this.丞下上且一上丙不丏.PlayOneShot(clip:  this.deathSound);
        }
        public void TryPlayDamageSound(float 丕丕世且下一与丝与)
        {
            if(this.mobAudioComponent != 0)
            {
                    this.mobAudioComponent.丝三丁丏丑丆丙万上();
                return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            if(this.丞下上且一上丙不丏 == 0)
            {
                    return;
            }
            
            if(this.丟丄丒丒业丂东丟丈 != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.不万世丁丟且丞丝不(丑丄一丝世业专丛不:  丕丕世且下一与丝与));
            this.丞下上且一上丙不丏.PlayOneShot(clip:  this.damageSound);
        }
        internal void 丄一丟丄万丐东不七()
        {
            this.<丄上丐丝东丘丅丙丈>k__BackingField = true;
        }
        private System.Collections.IEnumerator 不万世丁丟且丞丝不(float 丑丄一丝世业专丛不)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BaseBot.丕万丝丁丏丝丟丒上();
        }
        private System.Collections.IEnumerator 丁万业丛丒三业七三(float 丑丄一丝世业专丛不)
        {
            BaseBot.七三一上一丅丒七专 val_1 = new BaseBot.七三一上一丅丒七专();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丑丄一丝世业专丛不 = 丑丄一丝世业专丛不;
            return (System.Collections.IEnumerator)val_1;
        }
        private bool 万丏丝不三丘丄丅丞(float 丑丄一丝世业专丛不)
        {
            var val_3;
            if(this.三丘丞丛丑丄与丌一 != false)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丁万业丛丒三业七三(丑丄一丝世业专丛不:  丑丄一丝世业专丛不));
            val_3 = 1;
            return (bool)val_3;
        }
        public string get_p_nameBot()
        {
            return (string)this.nameBot;
        }
        public void set_p_nameBot(string 丙业与丙丗丝不丈东)
        {
            this.nameBot = 丙业与丙丗丝不丈东;
        }
        public bool get_p_isMobChampion()
        {
            return (bool)this.一丟万七丒丒不与业;
        }
        public UnityEngine.AudioClip get_p_damageSound()
        {
            return (UnityEngine.AudioClip)this.damageSound;
        }
        public void set_p_damageSound(UnityEngine.AudioClip 丙业与丙丗丝不丈东)
        {
            this.damageSound = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.AudioClip get_p_voiceMobSoud()
        {
            return (UnityEngine.AudioClip)this.voiceMobSoud;
        }
        public void set_p_voiceMobSoud(UnityEngine.AudioClip 丙业与丙丗丝不丈东)
        {
            this.voiceMobSoud = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.AudioClip get_p_takeDamageSound()
        {
            return (UnityEngine.AudioClip)this.takeDamageSound;
        }
        public void set_p_takeDamageSound(UnityEngine.AudioClip 丙业与丙丗丝不丈东)
        {
            this.takeDamageSound = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.AudioClip get_p_deathSound()
        {
            return (UnityEngine.AudioClip)this.deathSound;
        }
        public void set_p_deathSound(UnityEngine.AudioClip 丙业与丙丗丝不丈东)
        {
            this.deathSound = 丙业与丙丗丝不丈东;
        }
        public float get_p_notAttackingSpeed()
        {
            return (float)this.notAttackingSpeed;
        }
        public void set_p_notAttackingSpeed(float 丙业与丙丗丝不丈东)
        {
            this.notAttackingSpeed = 丙业与丙丗丝不丈东;
        }
        public float get_p_attackingSpeed()
        {
            return (float)this.attackingSpeed;
        }
        public void set_p_attackingSpeed(float 丙业与丙丗丝不丈东)
        {
            this.attackingSpeed = 丙业与丙丗丝不丈东;
        }
        public float get_p_health()
        {
            return (float)this.health;
        }
        public void set_p_health(float 丙业与丙丗丝不丈东)
        {
            this.health = 丙业与丙丗丝不丈东;
        }
        public float get_p_attackDistance()
        {
            return (float)this.attackDistance;
        }
        public void set_p_attackDistance(float 丙业与丙丗丝不丈东)
        {
            this.attackDistance = 丙业与丙丗丝不丈东;
        }
        public float get_p_detectRadius()
        {
            return (float)this.detectRadius;
        }
        public void set_p_detectRadius(float 丙业与丙丗丝不丈东)
        {
            this.detectRadius = 丙业与丙丗丝不丈东;
        }
        public float get_p_damagePerHit()
        {
            return (float)this.damagePerHit;
        }
        public void set_p_damagePerHit(float 丙业与丙丗丝不丈东)
        {
            this.damagePerHit = 丙业与丙丗丝不丈东;
        }
        public int get_p_scorePerKill()
        {
            return (int)this.scorePerKill;
        }
        public void set_p_scorePerKill(int 丙业与丙丗丝不丈东)
        {
            this.scorePerKill = 丙业与丙丗丝不丈东;
        }
        public float[] get_p_attackingSpeedRandomRange()
        {
            return (System.Single[])this.attackingSpeedRandomRange;
        }
        public void set_p_attackingSpeedRandomRange(float[] 丙业与丙丗丝不丈东)
        {
            this.attackingSpeedRandomRange = 丙业与丙丗丝不丈东;
        }
        public bool get_p_isAutomaticAnimationEnable()
        {
            return (bool)this.isAutomaticAnimationEnable;
        }
        public void set_p_isAutomaticAnimationEnable(bool 丙业与丙丗丝不丈东)
        {
            this.isAutomaticAnimationEnable = 丙业与丙丗丝不丈东;
        }
        public float get_p_speedAnimationWalk()
        {
            return (float)this.speedAnimationWalk;
        }
        public void set_p_speedAnimationWalk(float 丙业与丙丗丝不丈东)
        {
            this.speedAnimationWalk = 丙业与丙丗丝不丈东;
        }
        public float get_p_speedAnimationRun()
        {
            return (float)this.speedAnimationRun;
        }
        public void set_p_speedAnimationRun(float 丙业与丙丗丝不丈东)
        {
            this.speedAnimationRun = 丙业与丙丗丝不丈东;
        }
        public float get_p_speedAnimationAttack()
        {
            return (float)this.speedAnimationAttack;
        }
        public void set_p_speedAnimationAttack(float 丙业与丙丗丝不丈东)
        {
            this.speedAnimationAttack = 丙业与丙丗丝不丈东;
        }
        private float 丗业丐世丄万七丅丐(float 不丏丒且丟业丑丙业)
        {
            float val_2 = 不丏丒且丟业丑丙业;
            val_2 = this.speedAnimationWalk * val_2;
            this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.业业丙下丕业东业丑].speed = val_2;
            float val_3 = this.attackingSpeed;
            val_3 = val_2 * val_3;
            return (float)val_3;
        }
        private float 丞与与丕丄丘丞丛丑(float 不丏丒且丟业丑丙业)
        {
            float val_2 = 不丏丒且丟业丑丙业;
            val_2 = this.speedAnimationRun * val_2;
            this.且丈丘三丆一丟丌丐.Item[this.丛丏丄业丒与丂世丑.丄丄丛万丁丐丐与丏].speed = val_2;
            float val_3 = this.notAttackingSpeed;
            val_3 = val_2 * val_3;
            return (float)val_3;
        }
        public float GetWalkSpeed()
        {
            if(this.isAutomaticAnimationEnable != false)
            {
                    return this.丗业丐世丄万七丅丐(不丏丒且丟业丑丙业:  this.丈丁丆丈丁丁丆丄上);
            }
            
            float val_1 = this.notAttackingSpeed;
            val_1 = val_1 * this.丈丁丆丈丁丁丆丄上;
            return (float)val_1;
        }
        public float GetAttackSpeedByCompleteLevel()
        {
            if(this.isAutomaticAnimationEnable != false)
            {
                    return this.丞与与丕丄丘丞丛丑(不丏丒且丟业丑丙业:  this.丈丁丆丈丁丁丆丄上);
            }
            
            float val_1 = this.attackingSpeed;
            val_1 = val_1 * this.丈丁丆丈丁丁丆丄上;
            return (float)val_1;
        }
        internal static UnityEngine.Vector3 不丂丏七丗不专丗丕(UnityEngine.Vector3 丐世丂丁一丞不丒万)
        {
            float val_1 = UnityEngine.Random.Range(min:  0.5f, max:  1f);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丐世丂丁一丞不丒万.x, y = 丐世丂丁一丞不丒万.y, z = 丐世丂丁一丞不丒万.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        private bool 丄丘丞丟七丂丆万且()
        {
            string val_2 = this.gameObject.name;
            if(val_2 != null)
            {
                    return val_2.Contains(value:  "BossGuard");
            }
            
            return val_2.Contains(value:  "BossGuard");
        }
        public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
        {
        
        }
        internal UnityEngine.Transform 丌丟丄业且三丛丕丄()
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
        internal RilisoftBot.BaseBot.丟丒下丙不丙上不丟 万丙丞东丆上下丞丌()
        {
            return (丟丒下丙不丙上不丟)this.丛丏丄业丒与丂世丑;
        }
        protected void 丟丘一丄一东且丐丗(bool 丞七丛与丝下一一丆, bool 丌丒丕丄丑丌世不丐 = False)
        {
            BotChangeDamageMaterial[] val_3;
            var val_4;
            RilisoftBot.七一丙世丏下丐丕世 val_5;
            val_3 = this.丒东丕丙且上不一丆;
            if(val_3 == null)
            {
                    return;
            }
            
            if(this.丒东丕丙且上不一丆.Length == 0)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_2;
            label_10:
            val_5 = 0;
            BotChangeDamageMaterial val_3 = this.丒东丕丙且上不一丆[val_5];
            if(丞七丛与丝下一一丆 != false)
            {
                    val_5 = this.丙丕丁丅丁与丗丑丘();
                val_3.ShowDamageEffect(万东丏丌不七东丘万:  丌丒丕丄丑丌世不丐, 丗与丟上上丑专世丗:  val_5);
            }
            else
            {
                    val_3.ResetMainMaterial();
            }
            
            val_3 = this.丒东丕丙且上不一丆;
            val_4 = 1;
            label_2:
            if(val_4 < this.丒东丕丙且上不一丆.Length)
            {
                goto label_10;
            }
        
        }
        private System.Collections.IEnumerator 上与丙丒丂丞丒丄丌(bool 万东丏丌不七东丘万)
        {
            BaseBot.丕丟丒丂东丂丑不丗 val_1 = new BaseBot.丕丟丒丂东丂丑不丗();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .万东丏丌不七东丘万 = 万东丏丌不七东丘万;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丝丗丐丌丁丌丒三万()
        {
            var val_15;
            string val_16;
            var val_17;
            float val_21;
            float val_22;
            float val_23;
            var val_24;
            var val_26;
            if(this.一丟万七丒丒不与业 == false)
            {
                    return;
            }
            
            bool val_15 = this.不业丄丘丗三丄丝丄;
            val_15 = val_15 + 3;
            var val_16 = ~val_15;
            val_16 = val_16 & 3;
            if(val_16 != 0)
            {
                    return;
            }
            
            val_15 = null;
            val_15 = null;
            val_16 = UnityEngine.Application.loadedLevelName;
            if((下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.ContainsKey(key:  val_16)) == false)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_21 = val_7.x;
            val_22 = val_7.y;
            val_23 = val_7.z;
            if((System.String.op_Equality(a:  UnityEngine.Application.loadedLevelName, b:  "Sky_islands")) != false)
            {
                    UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_21 = val_10.x;
                val_22 = val_10.y;
                val_23 = val_10.z;
            }
            
            val_24 = null;
            val_24 = null;
            val_16 = mem[ZombieCreator.丞丈丟丒丂丞丏不丑 + 184];
            val_16 = ZombieCreator.丞丈丟丒丂丞丏不丑.weaponBonus;
            if(val_16 != 0)
            {
                    UnityEngine.GameObject val_12 = BonusCreator.三丟七丑世世不与上(丂丈丗丄不丅丅丙丒:  val_16, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
            }
            
            GotToNextLevel val_14 = BonusCreator.下不三上与丂丅三世(丆与丕丕丂下丟一丈:  下与业丆下三丅丅丝.一丝丑丗不丘丝与丐.Item[UnityEngine.Application.loadedLevelName], 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}).AddComponent<GotToNextLevel>();
            val_26 = null;
            val_26 = null;
            ZombieCreator.丞丈丟丒丂丞丏不丑.weaponBonus = 0;
            this.不业丄丘丗三丄丝丄 = true;
        }
        public void add_OnDamageTarget(System.Action<丅丙上七上一丐不下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丐丝上七丘下上万七, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丝上七丘下上万七 != this.丐丝上七丘下上万七);
        
        }
        public void remove_OnDamageTarget(System.Action<丅丙上七上一丐不下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丐丝上七丘下上万七, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丝上七丘下上万七 != this.丐丝上七丘下上万七);
        
        }
        public void MakeDamage(UnityEngine.Transform 丞下万上三丘上与专, float 丟丒丅东丙丛丏丏与)
        {
            float val_20;
            UnityEngine.Transform val_21;
            var val_22;
            var val_23;
            var val_24;
            val_20 = 丟丒丅东丙丛丏丏与;
            val_21 = 丞下万上三丘上与专;
            丅丙上七上一丐不下 val_1 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_21);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            label_48:
            val_22 = 0;
            if(this.下不丌万丙且一万东.丝丘丗丘业丝丈下丞 != 0)
            {
                    val_21 = this.下不丌万丙且一万东.丝丘丗丘业丝丈下丞;
                if(val_1 == null)
            {
                    val_22 = 0;
            }
            
                if(val_3.Length == 0)
            {
                    val_22 = 0;
            }
            
                new object[1][0] = val_1;
                if((val_21 & 1) == 0)
            {
                    return;
            }
            
            }
            
            val_23 = 0;
            if(this.丆丝丝丞不丙专丝东 != 0)
            {
                    if(val_1 == null)
            {
                    val_23 = 0;
            }
            
                if(val_5.Length == 0)
            {
                    val_23 = 0;
            }
            
                new object[1][0] = val_1;
                if(丟丒丅东丙丛丏丏与 != 0f)
            {
                    val_20 = 丟丒丅东丙丛丏丏与;
            }
            
            }
            
            this.不专丒七丄七业丆一();
            if((val_1 != 0) && (this.丆丝丝丞不丙专丝东 != 0))
            {
                    if(this.不世与丄上丏丁专七() != false)
            {
                    if(this.丆丝丝丞不丙专丝东.业丘丏丏七丑专东下() == true)
            {
                    return;
            }
            
            }
            
                if(this.下丟丈万业丙丝丙丙() != false)
            {
                    if(this.丆丝丝丞不丙专丝东.丁万不七丝不丈世丝() == true)
            {
                    return;
            }
            
            }
            
                val_24 = null;
                val_24 = null;
                var val_13 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_24) ? (val_1) : 0;
                val_20 = val_20 * ((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) + -8 == val_24 ? val_1 : 0 + 24 + 3552.丝世不丑丒丏丄丑专(丂上不世业丒三世丕:  this.丙丕丁丅丁与丗丑丘()));
            }
            
            if(this.丐丝上七丘下上万七 != null)
            {
                    this.丐丝上七丘下上万七.Invoke(obj:  val_1);
            }
            
            UnityEngine.Vector3 val_16 = this.万丈且与七下上不专();
            val_21 = "";
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_44;
            label_3:
            HitBox val_17 = 丘丛丞且一丅丁丏丐.业下专丂丌丄七丆丞(上丛丂三上与丂丕丑:  val_21);
            if(val_17 == null)
            {
                    return;
            }
            
            if(val_17.业丒丁与世丘丕专丝() != null)
            {
                goto label_48;
            }
            
            return;
            label_44:
            val_1.ApplyDamage(丞丈专下丈专业三丞:  val_20, 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, 丐丟丘世丁三丕专专:  16, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  val_21, 丒丈丐丐丗丐专丈丏:  0);
            if(val_20 <= 0f)
            {
                    return;
            }
        
        }
        public void MakeDamage(UnityEngine.Transform 丞下万上三丘上与专)
        {
            this.MakeDamage(丞下万上三丘上与专:  丞下万上三丘上与专, 丟丒丅东丙丛丏丏与:  this.damagePerHit);
        }
        private void 丙业世丐丟丏丂丐一(bool 丅丘丛丒丒丑丟三丛)
        {
            null = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
            {
                    return;
            }
            
            if((this.<专业丞不丟专专丐与>k__BackingField) == UnityEngine.Time.frameCount)
            {
                    return;
            }
            
            bool val_2 = UnityEngine.Object.op_Equality(x:  this.三丝丌丙丂世丈一丟, y:  0);
        }
        private void 上下七与丆且专下世()
        {
            UnityEngine.Object val_16;
            var val_17;
            UnityEngine.SphereCollider val_18;
            float val_19;
            float val_20;
            float val_24;
            val_16 = 1152921505171808256;
            val_17 = null;
            val_17 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
            {
                    return;
            }
            
            val_18 = 1152921504848912384;
            val_16 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
            if(val_16 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            val_19 = val_5.y;
            UnityEngine.Quaternion val_7 = this.丌丟丄业且三丛丕丄().rotation;
            val_20 = val_7.w;
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    val_20 = val_5.x;
                val_19 = val_5.z;
                val_18 = this.三丝丌丙丂世丈一丟;
                UnityEngine.Vector3 val_9 = val_18.center;
                UnityEngine.Vector3 val_10 = this.三丝丌丙丂世丈一丟.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_24 = val_10.x;
                if(val_16 != null)
            {
                goto label_18;
            }
            
            }
            else
            {
                    val_18 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_12 = val_18.position;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.heightFlyOutHitEffect);
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                val_24 = val_15.x;
            }
            
            label_18:
            val_16.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_5.x, y = val_19, z = val_5.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_20}, 丁丈丄不且专丘与世:  false, 丙且一丛且东丛丗丟:  new UnityEngine.Vector3() {x = val_24, y = val_15.z});
        }
        public void ShowResistEffect()
        {
            var val_21;
            UnityEngine.SphereCollider val_22;
            float val_23;
            float val_24;
            float val_28;
            val_21 = this;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    if(Initializer.丑七不且上丗丁一世() != 0)
            {
                    Initializer val_4 = Initializer.丑七不且上丗丁一世();
                UnityEngine.AudioSource val_5 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_4.resistSound);
            }
            
            }
            
            HitParticle val_6 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
            val_22 = 1152921504848912384;
            if(val_6 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_10 = this.丌丟丄业且三丛丕丄().position;
            val_23 = val_10.y;
            UnityEngine.Quaternion val_12 = this.丌丟丄业且三丛丕丄().rotation;
            val_24 = val_12.w;
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    val_24 = val_10.x;
                val_23 = val_10.z;
                val_22 = this.三丝丌丙丂世丈一丟;
                val_21 = this.三丝丌丙丂世丈一丟.transform;
                UnityEngine.Vector3 val_14 = val_22.center;
                UnityEngine.Vector3 val_15 = val_21.TransformPoint(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                val_28 = val_15.x;
                if(val_6 != null)
            {
                goto label_28;
            }
            
            }
            else
            {
                    val_22 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_17 = val_22.position;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  this.heightFlyOutHitEffect);
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
                val_28 = val_20.x;
            }
            
            label_28:
            val_6.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_10.x, y = val_23, z = val_10.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_24}, 丁丈丄不且专丘与世:  false, 丙且一丛且东丛丗丟:  new UnityEngine.Vector3() {x = val_28, y = val_20.z});
        }
        private void 丕丛丆一与丗丆不丁()
        {
            int val_17;
            var val_18;
            UnityEngine.SphereCollider val_19;
            float val_20;
            float val_21;
            float val_25;
            val_17 = 1152921505171808256;
            val_18 = null;
            val_18 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
            {
                    return;
            }
            
            val_17 = this.<专业丞不丟专专丐与>k__BackingField;
            if(val_17 == UnityEngine.Time.frameCount)
            {
                    return;
            }
            
            val_19 = 1152921504848912384;
            val_17 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
            if(val_17 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
            val_20 = val_6.y;
            UnityEngine.Quaternion val_8 = this.丌丟丄业且三丛丕丄().rotation;
            val_21 = val_8.w;
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    val_21 = val_6.x;
                val_20 = val_6.z;
                val_19 = this.三丝丌丙丂世丈一丟;
                UnityEngine.Vector3 val_10 = val_19.center;
                UnityEngine.Vector3 val_11 = this.三丝丌丙丂世丈一丟.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_25 = val_11.x;
                if(val_17 != null)
            {
                goto label_19;
            }
            
            }
            else
            {
                    val_19 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_13 = val_19.position;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.heightFlyOutHitEffect);
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_25 = val_16.x;
            }
            
            label_19:
            val_17.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_6.x, y = val_20, z = val_6.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_21}, 丁丈丄不且专丘与世:  false, 丙且一丛且东丛丗丟:  new UnityEngine.Vector3() {x = val_25, y = val_16.z});
        }
        private void 下一上丛丄丒丙不世()
        {
            UnityEngine.Object val_16;
            var val_17;
            UnityEngine.SphereCollider val_18;
            float val_19;
            float val_20;
            float val_24;
            val_16 = 1152921505171808256;
            val_17 = null;
            val_17 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
            {
                    return;
            }
            
            val_18 = 1152921504848912384;
            val_16 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
            if(val_16 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().position;
            val_19 = val_5.y;
            UnityEngine.Quaternion val_7 = this.丌丟丄业且三丛丕丄().rotation;
            val_20 = val_7.w;
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    val_20 = val_5.x;
                val_19 = val_5.z;
                val_18 = this.三丝丌丙丂世丈一丟;
                UnityEngine.Vector3 val_9 = val_18.center;
                UnityEngine.Vector3 val_10 = this.三丝丌丙丂世丈一丟.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_24 = val_10.x;
                if(val_16 != null)
            {
                goto label_18;
            }
            
            }
            else
            {
                    val_18 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_12 = val_18.position;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.heightFlyOutHitEffect);
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
                val_24 = val_15.x;
            }
            
            label_18:
            val_16.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_5.x, y = val_19, z = val_5.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_20}, 丁丈丄不且专丘与世:  false, 丙且一丛且东丛丗丟:  new UnityEngine.Vector3() {x = val_24, y = val_15.z});
        }
        private void 下丅丝丏专东丕万一()
        {
            int val_17;
            var val_18;
            UnityEngine.SphereCollider val_19;
            float val_20;
            float val_21;
            float val_25;
            val_17 = 1152921505171808256;
            val_18 = null;
            val_18 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
            {
                    return;
            }
            
            val_17 = this.<专业丞不丟专专丐与>k__BackingField;
            if(val_17 == UnityEngine.Time.frameCount)
            {
                    return;
            }
            
            val_19 = 1152921504848912384;
            val_17 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
            if(val_17 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = this.丌丟丄业且三丛丕丄().position;
            val_20 = val_6.y;
            UnityEngine.Quaternion val_8 = this.丌丟丄业且三丛丕丄().rotation;
            val_21 = val_8.w;
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    val_21 = val_6.x;
                val_20 = val_6.z;
                val_19 = this.三丝丌丙丂世丈一丟;
                UnityEngine.Vector3 val_10 = val_19.center;
                UnityEngine.Vector3 val_11 = this.三丝丌丙丂世丈一丟.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_25 = val_11.x;
                if(val_17 != null)
            {
                goto label_19;
            }
            
            }
            else
            {
                    val_19 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_13 = val_19.position;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.heightFlyOutHitEffect);
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_25 = val_16.x;
            }
            
            label_19:
            val_17.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_6.x, y = val_20, z = val_6.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_21}, 丁丈丄不且专丘与世:  false, 丙且一丛且东丛丗丟:  new UnityEngine.Vector3() {x = val_25, y = val_16.z});
        }
        public int get_moduleResistShownFrame()
        {
            return (int)this.<专业丞不丟专专丐与>k__BackingField;
        }
        public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
        {
            this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float GetGamePlayForBaseGamePlay(int 业丆丈丟世一业一丙, int 业万上丆丐丞且丒七)
        {
            return (float)(float)业丆丈丟世一业一丙;
        }
        public float get_maxHealth()
        {
            return (float)this.<东丟丒东丗七万世且>k__BackingField;
        }
        public void set_maxHealth(float 丙业与丙丗丝不丈东)
        {
            this.<东丟丒东丗七万世且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
        {
            string val_13;
            世不丟丂上丟与丌下 val_14;
            float val_15;
            var val_16;
            var val_17;
            var val_19;
            UnityEngine.Object val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_13 = 丝三丛且丘不丌丙下;
            val_14 = 丐丟丘世丁三丕专专;
            val_15 = 丞丈专下丈专业三丞;
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    if(this.丞上丈丕丑万丕万一 == false)
            {
                    return;
            }
            
            }
            
            val_16 = null;
            val_16 = null;
            val_15 = 丘丐丘万丌丟丞下丝.丁丝丙丝丁万丞丆专() * val_15;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                goto label_9;
            }
            
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
            if(丛世一丟丞丁业丘丒 == null)
            {
                goto label_11;
            }
            
            val_17 = 0;
            goto label_13;
            label_9:
            if(丛世一丟丞丁业丘丒 == null)
            {
                goto label_14;
            }
            
            val_19 = null;
            val_19 = null;
            goto label_18;
            label_14:
            val_22 = 0;
            goto label_19;
            label_18:
            val_22 = transform;
            label_19:
            this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  -val_15, 一丗丈丛万丄世一丘:  丛世一丟丞丁业丘丒, 丝三丛且丘不丌丙下:  val_13, 业一丘不万丂七上丝:  UnityEngine.Object.op_Implicit(exists:  val_22), 丅业下不东丗丄与三:  val_14);
            return;
            label_11:
            val_23 = 0;
            goto label_22;
            label_13:
            label_22:
            this.丙丛世丞万上世专丌(丞丈专下丈专业三丞:  -val_15, 丝三丛且丘不丌丙下:  val_13, 业一丘不万丂七上丝:  ( != 0) ? 1 : 0, 丅业下不东丗丄与三:  val_14, 丛世一丟丞丁业丘丒:  丛世一丟丞丁业丘丒);
            val_13 = 1152921505286238208;
            val_24 = null;
            val_24 = null;
            val_14 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_14 == 0)
            {
                    return;
            }
            
            val_25 = null;
            val_25 = null;
            val_14 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
            val_14 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
            if(val_14 == 0)
            {
                    return;
            }
            
            val_26 = null;
            val_26 = null;
            val_14 = GameController.mode;
            if(val_14 == 0)
            {
                    return;
            }
            
            val_27 = null;
            val_27 = null;
            val_28 = null;
            val_28 = null;
            东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  GameController.mode.丞丏丕丑丞丑丏丏丄());
            丆丂东丏与不与不丟();
        }
        public void HardKillMob()
        {
            this.丒丕丟丁丐不丕丑业 = CoroutineRunner.Instance.StartCoroutine(routine:  this.TryDestroy());
        }
        public System.Collections.IEnumerator TryDestroy()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BaseBot.丛丏东丁丆丕专丙丝();
        }
        public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
        {
            var val_3;
            if(GameConnect.丅丟下专不丁一丈七() != false)
            {
                    var val_2 = (this.世丗万丞世丂丂丕丝 == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public bool IsDead()
        {
            return (bool)this.<丄上丐丝东丘丅丙丈>k__BackingField;
        }
        public bool get_isLivingTarget()
        {
            return true;
        }
        internal void 业丂丛丟上且丂东丂(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 一丗丈丛万丄世一丘, string 丝三丛且丘不丌丙下, bool 业一丘不万丂七上丝 = True, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0)
        {
            bool val_16;
            var val_17;
            int val_18;
            CategoryNames val_19;
            var val_20;
            bool val_21;
            val_16 = 业一丘不万丂七上丝;
            this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 一丗丈丛万丄世一丘:  一丗丈丛万丄世一丘, 业一丘不万丂七上丝:  val_16, 丅业下不东丗丄与三:  丅业下不东丗丄与三, 丝丅且丁万下业七万:  true);
            if(this.丒业丂丗下丛丞专下 != false)
            {
                    if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
                UnityEngine.Debug.LogWarning(message:  "Bot is receiving damage after death.");
                return;
            }
            
            if(this.health != 0f)
            {
                    return;
            }
            
            if(val_16 == false)
            {
                    return;
            }
            
            this.丒业丂丗下丛丞专下 = true;
            val_16 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_16.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    if(NetworkStartTable.与一专丒东丏丘专丕() == true)
            {
                    return;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  丝三丛且丘不丌丙下)) != false)
            {
                    return;
            }
            
            val_18 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  丝三丛且丘不丌丙下.Replace(oldValue:  "(Clone)", newValue:  System.String.alignConst));
            if(val_18 != null)
            {
                    val_19 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_18.与不丞丑七丘丁丂丛());
                val_18 = val_18.业东丅东丌上丗丑不();
            }
            else
            {
                    val_19 = 0;
            }
            
            val_20 = null;
            val_20 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    val_21 = 0;
            }
            else
            {
                    val_21 = GameConnect.上丏丈七丘丁与丅丏();
            }
            
            Rilisoft.丞丛七上丕专丏丌丈.丅业丄丝丌且万丕一(丌丂丕丘丌丟万丌七:  val_19, 不三世丒丟一丘专丛:  val_21, 丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), 丆专且丕专丗与一丏:  val_18, 丕丂东东丌与丅丏丟:  this._mobRole);
        }
        internal void 丑且丑世丑世东专上(System.Action<RilisoftBot.BaseBot, float, bool, Player_move_c.世不丟丂上丟与丌下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丂丅丝丁丞丛万丈且, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂丅丝丁丞丛万丈且 != this.丂丅丝丁丞丛万丈且);
        
        }
        internal void 丁丙丌与丑丘丄丝丘(System.Action<RilisoftBot.BaseBot, float, bool, Player_move_c.世不丟丂上丟与丌下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丂丅丝丁丞丛万丈且, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂丅丝丁丞丛万丈且 != this.丂丅丝丁丞丛万丈且);
        
        }
        internal void 丞丘七丗丁丄不丏丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丆东与与丑丐丅与丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆东与与丑丐丅与丈 != this.丆东与与丑丐丅与丈);
        
        }
        internal void 七世下丗专下东丁世(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丆东与与丑丐丅与丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆东与与丑丐丅与丈 != this.丆东与与丑丐丅与丈);
        
        }
        internal void 丈万丕丟丞丂丑不丈(System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.上万丙丆东不丅不丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上万丙丆东不丅不丞 != this.上万丙丆东不丅不丞);
        
        }
        internal void 东丂不专三丙丐一丁(System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.上万丙丆东不丅不丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上万丙丆东不丅不丞 != this.上万丙丆东不丅不丞);
        
        }
        internal void 业丂丛丟上且丂东丂(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 一丗丈丛万丄世一丘, bool 业一丘不万丂七上丝 = True, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0, bool 丝丅且丁万下业七万 = True)
        {
            float val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            DungeonsController val_75;
            var val_76;
            var val_77;
            var val_78;
            DungeonsController val_79;
            丅世一丈七丆业丝丘 val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_101;
            var val_102;
            FortDefenceLinkController val_103;
            float val_104;
            FortDefenceLinkController val_105;
            var val_106;
            var val_107;
            var val_108;
            if(this == 0)
            {
                    return;
            }
            
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
            if(this.七丅丅世丆丆丗丟丐 != false)
            {
                    return;
            }
            
            if((丞丈专下丈专业三丞 < 0) && (this.上丞丞丏丂丅专丝丆 != true))
            {
                    UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.上与丙丒丂丞丒丄丌(万东丏丌不七东丘万:  (丅业下不东丗丄与三 == 12) ? 1 : 0));
            }
            
            if(GameConnect.万七丄丛丈丟专一丑() == false)
            {
                goto label_10;
            }
            
            label_151:
            float val_68 = this.health;
            val_68 = val_68 + 丞丈专下丈专业三丞;
            this.health = val_68;
            if((丝丅且丁万下业七万 != false) && (this.丂丅丝丁丞丛万丈且 != null))
            {
                    this.丂丅丝丁丞丛万丈且.Invoke(arg1:  this, arg2:  丞丈专下丈专业三丞, arg3:  业一丘不万丂七上丝, arg4:  丅业下不东丗丄与三);
            }
            
            if(this.丆东与与丑丐丅与丈 != null)
            {
                    this.丆东与与丑丐丅与丈.Invoke();
            }
            
            if(this.上万丙丆东不丅不丞 != null)
            {
                    this.上万丙丆东不丅不丞.Invoke(arg1:  this, arg2:  一丗丈丛万丄世一丘, arg3:  丞丈专下丈专业三丞);
            }
            
            val_68 = this.health;
            if(val_68 >= 0)
            {
                goto label_17;
            }
            
            this.health = 0f;
            goto label_18;
            label_10:
            if((丅业下不东丗丄与三 - 12) > 9)
            {
                goto label_19;
            }
            
            var val_69 = 106026984 + ((丅业下不东丗丄与三 - 12)) << 2;
            val_69 = val_69 + 106026984;
            goto (106026984 + ((丅业下不东丗丄与三 - 12)) << 2 + 106026984);
            label_17:
            if(val_68 != 0f)
            {
                goto label_21;
            }
            
            label_18:
            this.PrepareDeath(isOwnerDamage:  业一丘不万丂七上丝);
            if(业一丘不万丂七上丝 == false)
            {
                goto label_22;
            }
            
            val_69 = null;
            val_69 = null;
            if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (GameConnect.丙丘不世专且万丄丐() != false))
            {
                    if(NetworkStartTable.与一专丒东丏丘专丕() != true)
            {
                    val_70 = null;
                val_70 = null;
                丁一业专丈三丄丘专.与一丅丝不丈业与丙().丙丂丌与且丂专下丌(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  typeof(SceneInfo).__il2cppRuntimeField_38);
            }
            
            }
            
            this.丝丗丐丌丁丌丒三万();
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_43;
            }
            
            val_71 = null;
            val_71 = null;
            一丆一专丆丛专丘丌();
            val_72 = null;
            val_72 = null;
            if(BonusController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_62;
            }
            
            val_73 = null;
            val_73 = null;
            if(DungeonsController.丄丘七三上丕世丞业 == 0)
            {
                goto label_62;
            }
            
            UnityEngine.Vector3 val_19 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  0.2f);
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_24 = this.丌丟丄业且三丛丕丄().up;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  10f)) == false)
            {
                goto label_62;
            }
            
            val_74 = null;
            val_74 = null;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  0.5f);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 10f, y = 0f, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            val_75 = DungeonsController.丄丘七三上丕世丞业;
            if(DungeonsController.丄丘七三上丕世丞业 != null)
            {
                goto label_69;
            }
            
            val_75 = DungeonsController.丄丘七三上丕世丞业;
            if(val_75 == null)
            {
                goto label_199;
            }
            
            label_69:
            BonusController.丄丞丁丈与业上丞丟.业丘下丄业三丞七一(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, 丗与丘不且万丟丙丑:  DungeonsController.专丗丐丒丝且丄七丝(), 丞且丁七丑丆丒丗丒:  DungeonsController.丄丘七三上丕世丞业.丛万三丟丅丈业丕丘, 丘七丛丂专丅丛业丑:  DungeonsController.丄丘七三上丕世丞业.lifeTimeBonuse);
            label_62:
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_190;
            }
            
            val_76 = null;
            val_76 = null;
            if(DungeonsController.丄丘七三上丕世丞业 == 0)
            {
                goto label_190;
            }
            
            val_77 = null;
            if(this.一丕丐专一东丞下上 == false)
            {
                goto label_80;
            }
            
            val_78 = null;
            val_79 = DungeonsController.丄丘七三上丕世丞业;
            val_80 = 119;
            goto label_84;
            label_22:
            if(this.一东丌丙丒丛丆丄丐 == false)
            {
                goto label_215;
            }
            
            val_81 = null;
            val_81 = null;
            if(GameController.mode != null)
            {
                    val_82 = null;
            }
            
            val_82 = null;
            var val_33 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_82) ? GameController.mode : 0;
            (GameModeController.__il2cppRuntimeField_typeHierarchy + (FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_82 ? GameController.mode : 0 + 520.一丗丈丟丝万丛世且();
            goto label_215;
            label_43:
            if(GameConnect.丅丟下专不丁一丈七() == false)
            {
                goto label_190;
            }
            
            val_83 = null;
            val_83 = null;
            一丆一专丆丛专丘丌();
            if(this._mobRole > 5)
            {
                goto label_169;
            }
            
            var val_70 = 106027024 + (this._mobRole) << 2;
            val_70 = val_70 + 106027024;
            goto (106027024 + (this._mobRole) << 2 + 106027024);
            label_21:
            if(业一丘不万丂七上丝 == true)
            {
                goto label_190;
            }
            
            goto label_215;
            label_19:
            if(丅业下不东丗丄与三 != 2)
            {
                goto label_109;
            }
            
            if(GameConnect.丅丟下专不丁一丈七() == false)
            {
                goto label_151;
            }
            
            val_87 = null;
            val_87 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                goto label_151;
            }
            
            val_88 = null;
            val_88 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
            {
                goto label_151;
            }
            
            val_89 = null;
            val_89 = null;
            this.丙业世丐丟丏丂丐一(丅丘丛丒丒丑丟三丛:  false);
            goto label_151;
            label_109:
            if(GameConnect.丅丟下专不丁一丈七() == false)
            {
                goto label_151;
            }
            
            val_90 = null;
            val_90 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                goto label_151;
            }
            
            val_91 = null;
            val_91 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
            {
                goto label_151;
            }
            
            val_92 = null;
            val_92 = null;
            this.下丅丝丏专东丕万一();
            goto label_151;
            label_80:
            val_93 = null;
            val_79 = DungeonsController.丄丘七三上丕世丞业;
            val_80 = 120;
            label_84:
            val_79.丌丁丏丅且丗下丕丐(丌丗万且世丞丏与下:  val_80);
            goto label_190;
            label_169:
            val_101 = null;
            val_101 = null;
            if(BonusController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_190;
            }
            
            UnityEngine.Vector3 val_45 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, d:  0.2f);
            UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
            UnityEngine.Vector3 val_50 = this.丌丟丄业且三丛丕丄().up;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_50.x, y = val_50.y, z = val_50.z});
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  10f)) == false)
            {
                goto label_190;
            }
            
            val_102 = null;
            val_102 = null;
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, d:  0.5f);
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 10f, y = 0f, z = val_51.z}, b:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
            val_103 = FortDefenceLinkController.丄丘七三上丕世丞业;
            if(val_103 == null)
            {
                goto label_195;
            }
            
            val_104 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 + 276];
            val_104 = FortDefenceLinkController.丄丘七三上丕世丞业.percentSpawnBonuse;
            val_105 = val_103;
            goto label_198;
            label_195:
            val_104 = mem[FortDefenceLinkController.丄丘七三上丕世丞业 + 276];
            val_104 = FortDefenceLinkController.丄丘七三上丕世丞业.percentSpawnBonuse;
            val_105 = FortDefenceLinkController.丄丘七三上丕世丞业;
            if(val_105 == null)
            {
                goto label_197;
            }
            
            val_103 = val_105;
            goto label_198;
            label_197:
            val_103 = FortDefenceLinkController.丄丘七三上丕世丞业;
            if(val_103 == null)
            {
                goto label_199;
            }
            
            label_198:
            BonusController.丄丞丁丈与业上丞丟.业丘下丄业三丞七一(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, 丗与丘不且万丟丙丑:  val_104, 丞且丁七丑丆丒丗丒:  FortDefenceLinkController.丄丘七三上丕世丞业.丛万三丟丅丈业丕丘, 丘七丛丂专丅丛业丑:  FortDefenceLinkController.丄丘七三上丕世丞业.lifeTimeBonuse);
            label_190:
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    val_106 = null;
                val_106 = null;
                DungeonsController.丄丘七三上丕世丞业.丑东丂与与丌丙丟丄(丗丂丁丂丗丄七丏下:  UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Max(a:  0f, b:  this.health), b:  -丞丈专下丈专业三丞));
            }
            else
            {
                    val_107 = null;
                val_107 = null;
                if(GameController.mode != null)
            {
                    val_108 = GameController.mode.丞丏丕丑丞丑丏丏丄();
            }
            else
            {
                    val_108 = 0.丞丏丕丑丞丑丏丏丄();
            }
            
                GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  val_108 + 5);
            }
            
            if((GameConnect.丅丟下专不丁一丈七() != false) && (this._mobRole == 3))
            {
                    this.一东丌丙丒丛丆丄丐 = true;
            }
            
            label_215:
            if(this.damageSound == 0)
            {
                goto label_218;
            }
            
            this.TryPlayDamageSound(丕丕世且下一与丝与:  this.damageSound.length);
            if(一丗丈丛万丄世一丘 != null)
            {
                goto label_220;
            }
            
            return;
            label_218:
            UnityEngine.Debug.LogError(message:  "не подкинут у damageSound " + this.name);
            if(一丗丈丛万丄世一丘 == null)
            {
                    return;
            }
            
            label_220:
            if(this.health <= 0f)
            {
                    return;
            }
            
            if(this.下不丌万丙且一万东.且丑不三上世丈丁丆 != 0)
            {
                    return;
            }
            
            var val_71 = 0;
            val_71 = val_71 + 1;
            this.下不丌万丙且一万东.SetTargetToMove(丞下万上三丘上与专:  一丗丈丛万丄世一丘.transform);
            this.下不丌万丙且一万东.丂丅与丕丁丛东丌丗 = true;
            return;
            label_199:
        }
        internal void 万丁丈丄丆丄不丄万(System.Action<RilisoftBot.BaseBot, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝丄丆丙七丂丞上丙, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丄丆丙七丂丞上丙 != this.丝丄丆丙七丂丞上丙);
        
        }
        internal void 丁丂丝丗丕丂丗三且(System.Action<RilisoftBot.BaseBot, float> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝丄丆丙七丂丞上丙, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丄丆丙七丂丞上丙 != this.丝丄丆丙七丂丞上丙);
        
        }
        internal void 丂丟丙丂丕专丂七下(float 上上丗丁丏丙丄丏七, bool 一丁世三丈专且七东 = True)
        {
            RilisoftBot.BaseBot val_5;
            float val_6;
            val_5 = this;
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
            val_6 = this.health;
            if(val_6 <= 0f)
            {
                    return;
            }
            
            if((this.丝丄丆丙七丂丞上丙 != null) && (一丁世三丈专且七东 != false))
            {
                    this.丝丄丆丙七丂丞上丙.Invoke(arg1:  this, arg2:  上上丗丁丏丙丄丏七);
                val_6 = this.health;
            }
            
            this.health = UnityEngine.Mathf.Min(a:  val_6 + 上上丗丁丏丙丄丏七, b:  this.<东丟丒东丗七万世且>k__BackingField);
            if(this.丆东与与丑丐丅与丈 != null)
            {
                    this.丆东与与丑丐丅与丈.Invoke();
            }
            
            if(this.丑一业丟上丐丕丗下 == false)
            {
                    return;
            }
            
            if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                    return;
            }
            
            object[] val_4 = new object[1];
            val_5 = this.health;
            val_4[0] = val_5;
            this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  61, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_4);
        }
        internal void 丞万丟万上且丟业丘(float 世丙丟上丘上七万万, bool 丘丞丛万世丈丅丂丆 = False)
        {
            bool val_4;
            RilisoftBot.BaseBot val_5;
            val_4 = 丘丞丛万世丈丅丂丆;
            float val_4 = 世丙丟上丘上七万万;
            val_5 = this;
            if(val_4 <= 0f)
            {
                    return;
            }
            
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
            if(this.丝丄丆丙七丂丞上丙 != null)
            {
                    this.丝丄丆丙七丂丞上丙.Invoke(arg1:  this, arg2:  val_4);
            }
            
            if(this.丆东与与丑丐丅与丈 != null)
            {
                    this.丆东与与丑丐丅与丈.Invoke();
            }
            
            if(this.丑一业丟上丐丕丗下 == false)
            {
                    return;
            }
            
            if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                    return;
            }
            
            val_5 = this.丅丏三七丁丑丞丄丏;
            val_4 = this.health + val_4;
            object[] val_2 = new object[2];
            val_2[0] = val_4;
            val_4 = val_4;
            val_2[1] = val_4;
            val_5.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  204, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_2);
        }
        private void 业丁丕丑上丆丂丝丕()
        {
            if(this._particleObject == 0)
            {
                    return;
            }
            
            this._particleObject.gameObject.SetActive(value:  true);
            this._particleObject.下三与丙丒一丞丐丒(丕丕世且下一与丝与:  this.delayForDisableObject);
        }
        private RilisoftBot.万丗丛丘七丘万丏丈 世丝业丗七与丆丐丈(RilisoftBot.七丝丅丑丝丆丛丆丄 丁丅丈丌丟世丗丗丟)
        {
            System.Collections.Generic.List<RilisoftBot.万丗丛丘七丘万丏丈> val_5;
            var val_6;
            var val_7;
            val_5 = 丁丅丈丌丟世丗丗丟;
            val_6 = 0;
            goto label_1;
            label_6:
            if(this.丌丒丆丛丟三丆专丕.Item[0].万丂七丈丂丟丙丈丈() == val_5)
            {
                goto label_4;
            }
            
            val_6 = 1;
            label_1:
            if(val_6 < this.丌丒丆丛丟三丆专丕.Count)
            {
                goto label_6;
            }
            
            val_7 = 0;
            return (RilisoftBot.万丗丛丘七丘万丏丈)val_5.Item[0];
            label_4:
            val_5 = this.丌丒丆丛丟三丆专丕;
            return (RilisoftBot.万丗丛丘七丘万丏丈)val_5.Item[0];
        }
        private void 丝万业丙丌不丝丕丄(RilisoftBot.万丗丛丘七丘万丏丈 丐丒不丆丂专丐下丏)
        {
            if(丐丒不丆丂专丐下丏.万丂七丈丂丟丙丈丈() != 0)
            {
                    return;
            }
            
            this.丈丁丆丈丁丁丆丄上 = 丐丒不丆丂专丐下丏.下丈丞三一业丙且丕();
        }
        private void 丕丏丌不丏丐丄丛丂(RilisoftBot.万丗丛丘七丘万丏丈 丐丒不丆丂专丐下丏)
        {
            if(丐丒不丆丂专丐下丏.万丂七丈丂丟丙丈丈() != 0)
            {
                    return;
            }
            
            this.丈丁丆丈丁丁丆丄上 = 1f;
        }
        public void ApplyDebuffByMode(RilisoftBot.七丝丅丑丝丆丛丆丄 丁丅丈丌丟世丗丗丟, float 丘七丛丂专丅丛业丑, object 业与丑丑丁丝丏丗世)
        {
            if(this.丑一业丟上丐丕丗下 != false)
            {
                    this.ApplyDebufForMultiplayer(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丘七丛丂专丅丛业丑:  丘七丛丂专丅丛业丑, 业与丑丑丁丝丏丗世:  业与丑丑丁丝丏丗世);
                return;
            }
            
            this.ApplyDebuff(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丘七丛丂专丅丛业丑:  丘七丛丂专丅丛业丑, 业与丑丑丁丝丏丗世:  业与丑丑丁丝丏丗世);
        }
        private void 丟丑与上世丗专丝万(RilisoftBot.万丗丛丘七丘万丏丈 且丘丛不丑世丅丘丘, float 丈不东万丛下与与丌, object 与万丞与丞丅丞丅丗)
        {
            if(且丘丛不丑世丅丘丘.万丂七丈丂丟丙丈丈() != 0)
            {
                    return;
            }
            
            且丘丛不丑世丅丘丘.丏丂丐一丁且专三业(丈不东万丛下与与丌:  丈不东万丛下与与丌, 与万丞与丞丅丞丅丗:  与万丞与丞丅丞丅丗);
            this.丝万业丙丌不丝丕丄(丐丒不丆丂专丐下丏:  且丘丛不丑世丅丘丘);
        }
        public void ApplyDebuff(RilisoftBot.七丝丅丑丝丆丛丆丄 丁丅丈丌丟世丗丗丟, float 丘七丛丂专丅丛业丑, object 业与丑丑丁丝丏丗世)
        {
            RilisoftBot.万丗丛丘七丘万丏丈 val_1 = this.世丝业丗七与丆丐丈(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟);
            if(val_1 != null)
            {
                    this.丟丑与上世丗专丝万(且丘丛不丑世丅丘丘:  val_1, 丈不东万丛下与与丌:  丘七丛丂专丅丛业丑, 与万丞与丞丅丞丅丗:  业与丑丑丁丝丏丗世);
                return;
            }
            
            RilisoftBot.万丗丛丘七丘万丏丈 val_2 = new RilisoftBot.万丗丛丘七丘万丏丈(丗一丏上丛丑丗丏丁:  丁丅丈丌丟世丗丗丟, 与业丈丟丏且丄丐业:  丘七丛丂专丅丛业丑, 业不专丏丞专且东上:  业与丑丑丁丝丏丗世);
            val_2.丝丌丏丒丆丙丁世下(丙业与丙丗丝不丈东:  new 万丗丛丘七丘万丏丈.丝丏业东丝丏丅一业(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void RilisoftBot.BaseBot::丝万业丙丌不丝丕丄(RilisoftBot.万丗丛丘七丘万丏丈 丐丒不丆丂专丐下丏)));
            val_2.丒丛七世下万丒丅世(丙业与丙丗丝不丈东:  new 万丗丛丘七丘万丏丈.丞东丞丒丕丅专丌丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void RilisoftBot.BaseBot::丕丏丌不丏丐丄丛丂(RilisoftBot.万丗丛丘七丘万丏丈 丐丒不丆丂专丐下丏)));
            this.丌丒丆丛丟三丆专丕.Add(item:  val_2);
        }
        public void UpdateDebuffState()
        {
            var val_14;
            RilisoftBot.万丗丛丘七丘万丏丈 val_15;
            if(this.丌丒丆丛丟三丆专丕.Count == 0)
            {
                    return;
            }
            
            val_14 = 0;
            goto label_3;
            label_20:
            bool val_3 = this.丌丒丆丛丟三丆专丕.Item[0].丆世丄丑丛东上丁丒();
            RilisoftBot.万丗丛丘七丘万丏丈 val_4 = this.丌丒丆丛丟三丆专丕.Item[0];
            if(val_4 == null)
            {
                goto label_7;
            }
            
            if(val_3 == false)
            {
                goto label_8;
            }
            
            label_17:
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = val_4.与丈上丈与丆七上丞() - val_6;
            val_4.丙下丑丂丝丆万丝丑(丙业与丙丗丝不丈东:  val_6);
            if(this.丌丒丆丛丟三丆专丕.Item[0].与丈上丈与丆七上丞() > 0f)
            {
                goto label_18;
            }
            
            this.丌丒丆丛丟三丆专丕.Item[0].丌丄丏下七丁专丂世();
            if(this.丌丒丆丛丟三丆专丕 == null)
            {
                goto label_15;
            }
            
            val_15 = this.丌丒丆丛丟三丆专丕.Item[0];
            goto label_16;
            label_7:
            if(val_3 == true)
            {
                goto label_17;
            }
            
            label_8:
            val_4.丄丄丛万丁丐丐与丏();
            goto label_18;
            label_15:
            val_15 = 0.Item[0];
            label_16:
            bool val_12 = this.丌丒丆丛丟三丆专丕.Remove(item:  val_15);
            label_18:
            val_14 = 1;
            label_3:
            if(val_14 < this.丌丒丆丛丟三丆专丕.Count)
            {
                goto label_20;
            }
        
        }
        internal bool 丅丟丙丘丌丂上一丅()
        {
            bool val_1 = GameConnect.且丞丁东丝丗上丈业();
            return false;
        }
        internal BaseBot()
        {
            int val_6;
            this.丞上丈丕丑万丕万一 = true;
            this.attackDistance = 0f;
            this.attackingSpeed = 1f;
            float[] val_1 = new float[2];
            val_6 = val_1.Length;
            if(val_6 == 0)
            {
                    val_6 = val_1.Length;
            }
            
            val_1[0] = -0.5f;
            val_1[1] = 0.5f;
            this.detectRadius = 17f;
            this.scorePerKill = 50;
            this.damagePerHit = 1f;
            this.worldIndicationOffset = 0.5f;
            this.attackingSpeedRandomRange = val_1;
            this.health = 0f;
            this.heightFlyOutHitEffect = 1.75f;
            this.notAttackingSpeed = 1f;
            mem2[0] = 1084227584;
            this.世丗万丞世丂丂丕丝 = true;
            this._listMobSettings = new System.Collections.Generic.List<IMobeSettings>();
            mem2[0] = 1f;
            this.speedAnimationAttack = 1f;
            this.mobSpawnCooldown = 5f;
            this.delayForDisableObject = 1f;
            this.丈丁丆丈丁丁丆丄上 = 1f;
            this.丌丒丆丛丟三丆专丕 = new System.Collections.Generic.List<RilisoftBot.万丗丛丘七丘万丏丈>();
            this.七丗丁丕下七一丒万 = 1.5f;
            this.丌丝世丟丗且丙专丄 = 3;
            Rilisoft.且三与世丁丏丂丌下 val_4 = this.与丑丌丌丌丁丌不丕();
            val_4.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void RilisoftBot.BaseBot::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
        }
        private void 七丘丟丕丛东丘七不()
        {
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
            this.丑丕七不万丝丛世三 = val_2;
            mem[1152921540956495220] = val_2.y;
            mem[1152921540956495224] = val_2.z;
            UnityEngine.Quaternion val_4 = this.丌丟丄业且三丛丕丄().rotation;
            this.丘丒丐一东一丙丆一 = val_4;
            mem[1152921540956495232] = val_4.y;
            mem[1152921540956495236] = val_4.z;
            mem[1152921540956495240] = val_4.w;
        }
        private void 世丈丞丛与丙世丙丕()
        {
            var val_10;
            var val_11;
            var val_12;
            if(this.丏七东七丝丁丄丐一 != 0)
            {
                    this.丏七东七丝丁丄丐一.gameObject.SetActive(value:  false);
            }
            
            if(this.三丝丌丙丂世丈一丟 != 0)
            {
                    this.三丝丌丙丂世丈一丟.gameObject.SetActive(value:  false);
            }
            
            val_10 = 0;
            goto label_25;
            label_29:
            val_11 = 0;
            val_12 = 0;
            val_5[0x0] + 32 = (UnityEngine.Object.op_Inequality(x:  null, y:  0)) | (UnityEngine.Object.op_Inequality(x:  null, y:  0));
            if((val_5[0x0] + 32) != true)
            {
                    val_5[0x0] + 32.enabled = false;
            }
            
            val_10 = 1;
            label_25:
            if(val_10 < val_5.Length)
            {
                goto label_29;
            }
        
        }
        public void DestroyByNetworkType()
        {
            var val_10;
            if(this.丑一业丟上丐丕丗下 == false)
            {
                goto label_1;
            }
            
            if(GameConnect.且丞丁东丝丗上丈业() == false)
            {
                goto label_4;
            }
            
            if(this.丅丏三七丁丑丞丄丏.isMine == false)
            {
                goto label_6;
            }
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = this.gameObject;
            val_10 = static_value_081D9CF0;
            goto label_10;
            label_1:
            UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
            label_4:
            if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
            {
                goto label_15;
            }
            
            val_10 = static_value_081D9CF0;
            label_10:
            丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
            return;
            label_15:
            this.<丟世不丌上丑丑下丙>k__BackingField = true;
            label_6:
            this.世丈丞丛与丙世丙丕();
        }
        internal void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
        {
            下丌丙丘丈丌世万专 val_12 = 东业丄丅丅且世七丄;
            if(this.丑一业丟上丐丕丗下 == false)
            {
                    return;
            }
            
            if(val_12.丕专丏万下不丞丐丛() != false)
            {
                    UnityEngine.Vector3 val_3 = this.丌丟丄业且三丛丕丄().position;
                val_12.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_3);
                UnityEngine.Quaternion val_5 = this.丌丟丄业且三丛丕丄().rotation;
                val_12.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_5);
                if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
                val_12 = val_12.东与上丗与丏下丂丘();
                丅丑丞上丛丆东丟丂.三丅丐业丙丕丙业丕(丑与丆丝丕东丛丄丝:  "Stream " + this.GetType(), 丗丟上上丒丐丗丞丙:  val_12);
                return;
            }
            
            this.丅业丛丌且丛丌世七 = 0f;
            object val_10 = val_12.与万三丘与专丛丄七();
            this.丑丕七不万丝丛世三 = new UnityEngine.Vector3();
            mem[1152921540957091272] = ???;
            object val_11 = val_12.与万三丘与专丛丄七();
            this.丘丒丐一东一丙丆一 = new UnityEngine.Quaternion();
            mem[1152921540957091280] = ???;
            mem[1152921540957091288] = ???;
        }
        private void 丐丒下东世丗丑丘丒()
        {
            var val_25;
            float val_26;
            float val_27;
            if(this.丞下上且一上丙不丏 != 0)
            {
                    var val_4 = (UnityEngine.Time.timeScale == 0f) ? 1 : 0;
                val_4 = this.丞下上且一上丙不丏.enabled ^ val_4;
                if(val_4 != true)
            {
                    if(this.丞下上且一上丙不丏 != null)
            {
                    val_25 = this.丞下上且一上丙不丏.enabled;
            }
            else
            {
                    val_25 = 0.enabled;
            }
            
                this.丞下上且一上丙不丏.enabled = (~val_25) & 1;
                if(this.丞下上且一上丙不丏.enabled != false)
            {
                    this.丞下上且一上丙不丏.Play();
            }
            
            }
            
            }
            
            if(this.丑一业丟上丐丕丗下 == false)
            {
                    return;
            }
            
            val_26 = 0f;
            if(this.丅丏三七丁丑丞丄丏.isMine != true)
            {
                    val_27 = this.丅业丛丌且丛丌世七;
                val_26 = val_27 + UnityEngine.Time.deltaTime;
            }
            
            this.丅业丛丌且丛丌世七 = val_26;
            if((this.<丟世不丌上丑丑下丙>k__BackingField) != false)
            {
                    if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
            {
                    丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
            }
            
            }
            
            if((this.丅丏三七丁丑丞丄丏.isMine != true) && ((this.<丟世不丌上丑丑下丙>k__BackingField) != true))
            {
                    UnityEngine.Vector3 val_16 = this.丌丟丄业且三丛丕丄().position;
                float val_17 = UnityEngine.Time.deltaTime;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = this.丑丕七不万丝丛世三, y = V11.16B, z = V12.16B}, t:  val_17 * 5f);
                this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
                UnityEngine.Quaternion val_22 = this.丌丟丄业且三丛丕丄().rotation;
                float val_25 = 5f;
                val_25 = UnityEngine.Time.deltaTime * val_25;
                UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, b:  new UnityEngine.Quaternion() {x = this.丘丒丐一东一丙丆一, y = V12.16B, z = val_16.z, w = val_17}, t:  val_25);
                val_27 = val_24.x;
                this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_27, y = val_24.y, z = val_24.z, w = val_24.w};
            }
            
            if(this.丌丝世丟丗且丙专丄 != 1)
            {
                    return;
            }
            
            this.不三万三与一丙世三 = 0.3f;
        }
        public void FireByRPC(UnityEngine.Vector3 丂丁丟世丗东丙丐丐, UnityEngine.Vector3 丅七丟上专一丈万丙)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(丂丁丟世丗东丙丐丐 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(丂丁丟世丗东丙丐丐 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = 丂丁丟世丗东丙丐丐;
            val_1[1] = 丅七丟上专一丈万丙;
            this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  92, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        }
        public virtual bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_7;
            var val_8;
            int val_9;
            var val_10;
            int val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if((this.<丄上丐丝东丘丅丙丈>k__BackingField) != false)
            {
                    return true;
            }
            
            byte val_1 = 丞世不丒下上上丝丑 & 255;
            if(val_1 > 44)
            {
                goto label_2;
            }
            
            if(val_1 > 24)
            {
                goto label_3;
            }
            
            byte val_2 = 丞世不丒下上上丝丑 & 255;
            if(val_2 == 11)
            {
                goto label_4;
            }
            
            if(val_2 != 24)
            {
                    return true;
            }
            
            if(专丒丌丆下丐丞丟丞 == null)
            {
                goto label_6;
            }
            
            val_7 = 专丒丌丆下丐丞丟丞;
            val_8 = 专丒丌丆下丐丞丟丞.Length;
            if(专丒丌丆下丐丞丟丞.Length != 0)
            {
                goto label_42;
            }
            
            goto label_8;
            label_2:
            if(val_1 > 191)
            {
                goto label_9;
            }
            
            byte val_3 = 丞世不丒下上上丝丑 & 255;
            if(val_3 == 61)
            {
                goto label_10;
            }
            
            if(val_3 != 191)
            {
                    return true;
            }
            
            this.丌丝世丟丗且丙专丄 = 2;
            return true;
            label_3:
            byte val_4 = 丞世不丒下上上丝丑 & 255;
            if(val_4 == 43)
            {
                goto label_13;
            }
            
            if(val_4 != 44)
            {
                    return true;
            }
            
            this.丞丛且丂与丒丛业丟();
            this.丌丝世丟丗且丙专丄 = 0;
            return true;
            label_9:
            byte val_5 = 丞世不丒下上上丝丑 & 255;
            if(val_5 == 204)
            {
                goto label_16;
            }
            
            if(val_5 == 205)
            {
                goto label_17;
            }
            
            if(val_5 != 213)
            {
                    return true;
            }
            
            if(this == 0)
            {
                    return true;
            }
            
            this.一东专丅业丂丐上与();
            return true;
            label_4:
            val_9 = 专丒丌丆下丐丞丟丞.Length;
            if(val_9 == 0)
            {
                    val_9 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_7 = 专丒丌丆下丐丞丟丞[0];
            if(val_9 <= 1)
            {
                    val_9 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_8 = 专丒丌丆下丐丞丟丞[1];
            object val_9 = 专丒丌丆下丐丞丟丞[2];
            this.且丐不丆丈丛丝丛丗(丗一丏上丛丑丗丏丁:  21884928, 丘七丛丂专丅丛业丑:  3.782474E-38f, 丈丛丂一丝丘丁丌丝:  3.782474E-38f);
            return true;
            label_10:
            object val_10 = 专丒丌丆下丐丞丟丞[0];
            this.丝丁三丏三一且丟且(丙专丅丂世丂世丅丆:  3.782474E-38f);
            return true;
            label_13:
            this.丌丝世丟丗且丙专丄 = 1;
            return true;
            label_16:
            if(专丒丌丆下丐丞丟丞 == null)
            {
                goto label_35;
            }
            
            val_10 = 专丒丌丆下丐丞丟丞;
            val_11 = 专丒丌丆下丐丞丟丞.Length;
            if(val_11 >= 2)
            {
                goto label_36;
            }
            
            label_49:
            if(val_11 == 0)
            {
                    return true;
            }
            
            if(专丒丌丆下丐丞丟丞 == null)
            {
                    val_12 = mem[专丒丌丆下丐丞丟丞 + 24];
                val_12 = 专丒丌丆下丐丞丟丞 + 24;
            }
            
            object val_11 = 专丒丌丆下丐丞丟丞[0];
            val_13 = 0;
            goto label_40;
            label_17:
            this.HardKillMob();
            return true;
            label_6:
            val_7 = 24;
            val_8 = 28563616;
            if(28563616 != 0)
            {
                goto label_42;
            }
            
            label_8:
            label_42:
            object val_12 = 专丒丌丆下丐丞丟丞[0];
            object val_13 = 专丒丌丆下丐丞丟丞[1];
            if(val_8 == 3)
            {
                    object val_14 = 专丒丌丆下丐丞丟丞[2];
                val_15 = 1152921504628731904;
            }
            else
            {
                    val_14 = 0;
            }
            
            this.万不丄下丂三丕丒不(丞丈专下丈专业三丞:  3.782474E-38f, 丗东丏与上丆丌不且:  21884928, 丂东丄丏丕丕丅上一:  0);
            return true;
            label_35:
            val_10 = 24;
            val_16 = 28563616;
            if(28563616 < 2)
            {
                goto label_49;
            }
            
            label_36:
            object val_15 = 专丒丌丆下丐丞丟丞[0];
            object val_16 = 专丒丌丆下丐丞丟丞[1];
            label_40:
            this.世一丘丗丛专丐丌一(丙专丅丂世丂世丅丆:  3.782474E-38f, 丘丞丛万世丈丅丂丆:  false);
            return true;
        }
        internal void 丝丁三丏三一且丟且(float 丙专丅丂世丂世丅丆)
        {
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
                if(this.health <= 0f)
            {
                    return;
            }
            
            }
            
            this.health = 丙专丅丂世丂世丅丆;
            if((this.<东丟丒东丗七万世且>k__BackingField) >= 0)
            {
                    return;
            }
            
            this.<丞丂丁丏上丞丞丟业>k__BackingField = 丙专丅丂世丂世丅丆;
            this.<东丟丒东丗七万世且>k__BackingField = 丙专丅丂世丂世丅丆;
        }
        internal void 世一丘丗丛专丐丌一(float 丙专丅丂世丂世丅丆, bool 丘丞丛万世丈丅丂丆 = False)
        {
            if(GameConnect.且丞丁东丝丗上丈业() != false)
            {
                    if((this.<丄上丐丝东丘丅丙丈>k__BackingField) == true)
            {
                    return;
            }
            
                if(this.health <= 0f)
            {
                    return;
            }
            
            }
            
            this.health = ((this.<东丟丒东丗七万世且>k__BackingField) < 0) ? this.<东丟丒东丗七万世且>k__BackingField : 丙专丅丂世丂世丅丆;
            if(丘丞丛万世丈丅丂丆 != false)
            {
                    this.业丁丕丑上丆丂丝丕();
            }
            
            if(this.丝丄丆丙七丂丞上丙 != null)
            {
                    this.丝丄丆丙七丂丞上丙.Invoke(arg1:  this, arg2:  this.health);
            }
            
            if(this.丆东与与丑丐丅与丈 == null)
            {
                    return;
            }
            
            this.丆东与与丑丐丅与丈.Invoke();
        }
        internal void 丞丘世丙丂丂专业专()
        {
            this.丞丛且丂与丒丛业丟();
            this.丌丝世丟丗且丙专丄 = 0;
        }
        internal void 且专丐丅业丄上丟丈()
        {
            this.丌丝世丟丗且丙专丄 = 1;
        }
        internal void 丝丄丒下丁不丕丘丐()
        {
            this.丌丝世丟丗且丙专丄 = 2;
        }
        internal void 万不丄下丂三丕丒不(float 丞丈专下丈专业三丞, int 丗东丏与上丆丌不且, int 丂东丄丏丕丕丅上一 = -1)
        {
            var val_4;
            丅丙上七上一丐不下 val_5;
            if(丂东丄丏丕丕丅上一 == 1)
            {
                goto label_1;
            }
            
            val_4 = null;
            val_4 = null;
            List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
            label_8:
            if((1991908680 & 1) == 0)
            {
                goto label_5;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(X23.viewID != 丂东丄丏丕丕丅上一)
            {
                goto label_8;
            }
            
            goto label_9;
            label_5:
            val_5 = 0;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_14;
            label_1:
            val_5 = 0;
            label_14:
            this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 一丗丈丛万丄世一丘:  val_5, 业一丘不万丂七上丝:  false, 丅业下不东丗丄与三:  丗东丏与上丆丌不且, 丝丅且丁万下业七万:  true);
        }
        internal void 丙丛世丞万上世专丌(float 丞丈专下丈专业三丞, string 丝三丛且丘不丌丙下, bool 业一丘不万丂七上丝, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒)
        {
            PhotonView val_7;
            var val_8;
            this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 一丗丈丛万丄世一丘:  丛世一丟丞丁业丘丒, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下, 业一丘不万丂七上丝:  业一丘不万丂七上丝, 丅业下不东丗丄与三:  丅业下不东丗丄与三);
            val_7 = this.丅丏三七丁丑丞丄丏;
            val_8 = null;
            object[] val_2 = new object[2];
            val_2[0] = 丞丈专下丈专业三丞;
            val_2[1] = 丅业下不东丗丄与三;
            七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
        }
        internal void 且丐不丆丈丛丝丛丗(int 丗一丏上丛丑丗丏丁, float 丘七丛丂专丅丛业丑, float 丈丛丂一丝丘丁丌丝)
        {
            this.ApplyDebuff(丁丅丈丌丟世丗丗丟:  丗一丏上丛丑丗丏丁, 丘七丛丂专丅丛业丑:  丘七丛丂专丅丛业丑, 业与丑丑丁丝丏丗世:  丈丛丂一丝丘丁丌丝);
        }
        public void ApplyDebufForMultiplayer(RilisoftBot.七丝丅丑丝丆丛丆丄 丁丅丈丌丟世丗丗丟, float 丘七丛丂专丅丛业丑, object 业与丑丑丁丝丏丗世)
        {
            System.Object[] val_3;
            RilisoftBot.七丝丅丑丝丆丛丆丄 val_4 = 丁丅丈丌丟世丗丗丟;
            this.ApplyDebuff(丁丅丈丌丟世丗丗丟:  val_4 = 丁丅丈丌丟世丗丗丟, 丘七丛丂专丅丛业丑:  丘七丛丂专丅丛业丑, 业与丑丑丁丝丏丗世:  业与丑丑丁丝丏丗世);
            if(val_4 != 0)
            {
                    return;
            }
            
            val_4 = this.丅丏三七丁丑丞丄丏;
            object[] val_2 = new object[3];
            val_3 = val_2;
            val_3[0] = 0;
            val_3[1] = 丘七丛丂专丅丛业丑;
            val_3[2] = null;
            val_4.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  11, 万丌万丅专丞业丈万:  val_4.owner, 丗丟上上丒丐丗丞丙:  val_2);
        }
        public void PlayAnimZombieWalkByMode()
        {
            if(this.丑一业丟上丐丕丗下 != false)
            {
                    if(this.丌丝世丟丗且丙专丄 != 0)
            {
                    this.丞丛且丂与丒丛业丟();
                this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  44, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            }
            
                this.丌丝世丟丗且丙专丄 = 0;
                return;
            }
            
            this.丞丛且丂与丒丛业丟();
        }
        public void PlayAnimZombieAttackOrStopByMode()
        {
            if(this.丑一业丟上丐丕丗下 != false)
            {
                    if(this.丌丝世丟丗且丙专丄 != 1)
            {
                    this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  43, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            }
            
                this.丌丝世丟丗且丙专丄 = 1;
            }
        
        }
        public void PlayAnimZombiePreparationForShootingByMode()
        {
            if(this.丑一业丟上丐丕丗下 != false)
            {
                    if(this.丌丝世丟丗且丙专丄 != 2)
            {
                    this.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  191, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            }
            
                this.丌丝世丟丗且丙专丄 = 2;
            }
        
        }
        public void StopAnimate()
        {
            if(this.丑一业丟上丐丕丗下 != false)
            {
                    this.丌丝世丟丗且丙专丄 = 3;
            }
        
        }
        private static BaseBot()
        {
            RilisoftBot.BaseBot.且业七丒丞丈丟丛不 = 1090938470;
            RilisoftBot.BaseBot.丐丗三丞丒丞上丟丆 = 1f;
            RilisoftBot.BaseBot.东丝丌丗丘东丁丐与 = 5.9f;
        }
        private UnityEngine.Transform IDamageable.get_transform()
        {
            return this.transform;
        }
    
    }

}
