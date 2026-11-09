using UnityEngine;

namespace Rilisoft
{
    internal sealed class TrainingEnemy : MonoBehaviour, 丅丙上七上一丐不下, 万丝丅丗且丒丝丌丟
    {
        // Fields
        public UnityEngine.Collider _bodyCollider;
        internal 万丝丅丗且丒丝丌丟 丙万丅下丂业东丄丒;
        private UnityEngine.Animation 业与丘丞丂专丘丗世;
        private UnityEngine.AudioSource 不丆丏丄丐且丗丆丟;
        private Rilisoft.TrainingEnemy.丙丟与丐三丐万万丆 丗下丘世三七一专丕;
        private UnityEngine.Collider 丟专丙丅东丂丛丗东;
        public UnityEngine.GameObject DamageZone;
        public int baseHitPoints;
        public UnityEngine.AudioClip dieAudioClip;
        public float heightFlyOutHitEffect;
        public int hitPoints;
        public UnityEngine.Texture hitTexture;
        private UnityEngine.SkinnedMeshRenderer 丗东专丄丙丟下丏专;
        private UnityEngine.Texture 三丌专世丑丒丙丁世;
        public UnityEngine.AudioClip wakeUpAudioClip;
        private UnityEngine.Transform 专专丏下丐丂丂丅东;
        private int <专业丞不丟专专丐与>k__BackingField;
        
        // Properties
        public UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
        public UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
        public UnityEngine.Collider 丝且不七丂世丗下七 { get; }
        public UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
        public bool 丈丐丁不丙东世七丕 { get; }
        public UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
        private UnityEngine.Collider 与丆丂丕东丄丗万与 { get; }
        public int 丗且丗丞丝丄世上一 { get; set; }
        public float 丟丆丆丝东世一丒丐 { get; }
        public bool 丁丙世丕丐丕丞丈丂 { get; }
        private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
        
        // Methods
        public UnityEngine.Collider get_aimCollider()
        {
            return this.一三专丆丆丏丒下丂();
        }
        public UnityEngine.Collider get_bodyAimCollider()
        {
            return this.一三专丆丆丏丒下丂();
        }
        public UnityEngine.Collider get_headAimCollider()
        {
            return this.一三专丆丆丏丒下丂();
        }
        public UnityEngine.Transform get_targetTransform()
        {
            return this.丌丟丄业且三丛丕丄();
        }
        public bool get_isTargetDead()
        {
            var val_3;
            if(this == 0)
            {
                    val_3 = 1;
                return (bool)(val_3 == 2) ? 1 : 0;
            }
            
            丙丟与丐三丐万万丆 val_3 = this.丗下丘世三七一专丕;
            val_3 = val_3 | 2;
            return (bool)(val_3 == 2) ? 1 : 0;
        }
        public UnityEngine.Vector3 get_currentTargetVelocity()
        {
            return UnityEngine.Vector3.zero;
        }
        private UnityEngine.Collider 一三专丆丆丏丒下丂()
        {
            if(this.丟专丙丅东丂丛丗东 != 0)
            {
                    return (UnityEngine.Collider)this.丟专丙丅东丂丛丗东;
            }
            
            UnityEngine.GameObject val_4 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  this.gameObject, 丒丘丏上丙丟丑丕丈:  "HeadCollider"));
            if(val_4 == 0)
            {
                    return (UnityEngine.Collider)this.丟专丙丅东丂丛丗东;
            }
            
            this.丟专丙丅东丂丛丗东 = val_4.GetComponent<UnityEngine.Collider>();
            return (UnityEngine.Collider)this.丟专丙丅东丂丛丗东;
        }
        public void WakeUp(float 丘丁三丅丆与丆业业 = 0)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丕丐丞丟与丙丌丛上(丘丁三丅丆与丆业业:  丘丁三丅丆与丆业业));
        }
        public void ApplyDamage(float 丞丈专下丈专业三丞, bool 丈不下东丅丛丆丝丐)
        {
            if(this.丗下丘世三七一专丕 != 1)
            {
                    return;
            }
            
            if(丈不下东丅丛丆丝丐 != false)
            {
                    this.StartCoroutine(routine:  this.丆丆丞且丕丟丈专下()).丙业世丐丟丏丂丐一();
            }
            else
            {
                    this.下丅丝丏专东丕万一();
            }
            
            int val_10 = this.hitPoints;
            val_10 = val_10 - 1;
            this.hitPoints = val_10;
            if(this.业与丘丞丂专丘丗世 != 0)
            {
                    bool val_4 = this.业与丘丞丂专丘丗世.Play(animation:  "Dummy_Damage", mode:  0);
            }
            
            if(this.hitPoints > 0)
            {
                    return;
            }
            
            this.丗下丘世三七一专丕 = 2;
            丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
            丘丛丞且一丅丁丏丐.丏丄丄东丒世专丌丁(不丂丅丁且丆东东丂:  this.丌丟丄业且三丛丕丄());
            if(this.DamageZone != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.DamageZone);
                this.DamageZone = 0;
            }
            
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.东丒丟且丈三东东丟());
        }
        private void Awake()
        {
            this.baseHitPoints = this.hitPoints;
            if(this.DamageZone == 0)
            {
                    return;
            }
            
            this.DamageZone.SetActive(value:  false);
        }
        private void Start()
        {
            UnityEngine.Material val_11;
            this.不丆丏丄丐且丗丆丟 = this.GetComponent<UnityEngine.AudioSource>();
            UnityEngine.Animation val_2 = this.GetComponent<UnityEngine.Animation>();
            this.业与丘丞丂专丘丗世 = val_2;
            val_11 = 1152921504848912384;
            if(val_2 != 0)
            {
                    bool val_4 = this.业与丘丞丂专丘丗世.Play(animation:  "Dummy_Idle", mode:  0);
            }
            
            UnityEngine.SkinnedMeshRenderer val_5 = this.GetComponentInChildren<UnityEngine.SkinnedMeshRenderer>();
            this.丗东专丄丙丟下丏专 = val_5;
            if((UnityEngine.Object.op_Implicit(exists:  val_5)) == false)
            {
                    return;
            }
            
            UnityEngine.Material val_8 = null;
            val_11 = val_8;
            val_8 = new UnityEngine.Material(source:  this.丗东专丄丙丟下丏专.sharedMaterial);
            this.丗东专丄丙丟下丏专.sharedMaterial = val_8;
            this.三丌专世丑丒丙丁世 = this.丗东专丄丙丟下丏专.sharedMaterial.mainTexture;
        }
        private System.Collections.IEnumerator 丆丆丞且丕丟丈专下()
        {
            object val_1 = 75164;
            val_1 = new System.Object();
            if(val_1 != 0)
            {
                    return (System.Collections.IEnumerator)val_1;
            }
            
            return (System.Collections.IEnumerator)val_1;
        }
        public void SetTexture(UnityEngine.Texture 一丛丈业丏业丁下丛)
        {
            if(this.丗东专丄丙丟下丏专 == 0)
            {
                    return;
            }
            
            this.丗东专丄丙丟下丏专.sharedMaterial.mainTexture = 一丛丈业丏业丁下丛;
        }
        private System.Collections.IEnumerator 丕丐丞丟与丙丌丛上(float 丘丁三丅丆与丆业业 = 0)
        {
            TrainingEnemy.上三丙业三且丝丈丄 val_1 = new TrainingEnemy.上三丙业三且丝丈丄();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丘丁三丅丆与丆业业 = 丘丁三丅丆与丆业业;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 东丒丟且丈三东东丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new TrainingEnemy.丕丂丟丂东丟丒丅丆();
        }
        private void 下丅丝丏专东丕万一()
        {
            null = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
            {
                    return;
            }
            
            HitParticle val_1 = GetCurrentParticle(丁丈丄不且专丘与世:  false);
            if(val_1 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Quaternion val_6 = this.丌丟丄业且三丛丕丄().rotation;
            UnityEngine.Vector3 val_8 = this.丌丟丄业且三丛丕丄().position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.heightFlyOutHitEffect);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_1.StartShowParticle(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, 丁丈丄不且专丘与世:  false, 丙且一丛且东丛丗丟:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = ???});
        }
        private void 丙业世丐丟丏丂丐一()
        {
        
        }
        public int get_moduleResistShownFrame()
        {
            return (int)this.<专业丞不丟专专丐与>k__BackingField;
        }
        public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
        {
            this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float get_maxHealth()
        {
            return 3f;
        }
        public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
        {
            this.ApplyDamage(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 丈不下东丅丛丆丝丐:  ((丐丟丘世丁三丕专专 == 2) ? 1 : 0) | ((丐丟丘世丁三丕专专 == 21) ? 1 : 0));
        }
        public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
        {
            return true;
        }
        public bool IsDead()
        {
            丙丟与丐三丐万万丆 val_2 = this.丗下丘世三七一专丕;
            val_2 = val_2 | 2;
            return (bool)(val_2 == 2) ? 1 : 0;
        }
        public bool get_isLivingTarget()
        {
            return false;
        }
        public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
        {
        
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
        public TrainingEnemy()
        {
            this.heightFlyOutHitEffect = 1.75f;
            this.hitPoints = 3;
        }
        private UnityEngine.Transform IDamageable.get_transform()
        {
            return this.transform;
        }
    
    }

}
