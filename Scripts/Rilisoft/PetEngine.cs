using UnityEngine;

namespace Rilisoft
{
    internal class PetEngine : StateMachine<Rilisoft.丛七下丌丑不一丄业>, 丅丙上七上一丐不下, 东丁丆一业丈万丆丐, 万丝丅丗且丒丝丌丟
    {
        // Fields
        internal 万丝丅丗且丒丝丌丟 丙万丅下丂业东丄丒;
        private UnityEngine.GameObject 丘丐丅丕丛七三丙丕;
        internal bool isPetStone;
        private Rilisoft.丒且丐三丁丅丕一业 丁丌三丁一丈丄丙丈;
        internal string 丝上世丒丗丞丐丘丕;
        protected PetInfo _info;
        public UnityEngine.Transform _lookPoint;
        public Rilisoft.PetEffectHandler EffectShow;
        public Rilisoft.PetEffectHandler EffectHide;
        private ObjectsActivatorManager attackEffects;
        protected float PlayProfileAnimationAfterSecs;
        protected float ToRunSpeedPercent;
        protected bool 丝且且丁上丝丒丞业;
        internal UnityEngine.AI.NavMeshAgent 丟丅三丝丄丈万丒三;
        public System.Collections.Generic.List<Rilisoft.PetAnimation> Animations;
        public UnityEngine.AudioClip ClipWalk;
        public UnityEngine.AudioClip ClipAttack;
        public UnityEngine.AudioClip ClipReceiveDamage;
        public UnityEngine.AudioClip ClipDeath;
        public UnityEngine.AudioClip ClipTap;
        private Player_move_c _owner;
        protected UnityEngine.Transform 丘与丈丘丒丂丁丛丟;
        protected Player_move_c 且丘丗三丌不万上丝;
        protected TargetScanner 业丌丙丕丘上丝丟丅;
        public UnityEngine.Collider BodyCollider;
        public UnityEngine.Collider HeadCollider;
        internal UnityEngine.Transform 七丈丁万丛万业丈与;
        protected Rilisoft.NetworkPetEngineSynch 丕东丘丐业丏业万业;
        private UnityEngine.GameObject _model;
        private UnityEngine.Animation _animator;
        private Rilisoft.AnimationHandler _animationHandler;
        private Rilisoft.PetHighlightComponent _highlightComponentComponentValue;
        private bool <下丗丗丗丂丌丌丄丟>k__BackingField;
        private bool _isMine;
        public PhotonView photonView;
        private AdvancedEffects 三丑丂丘业丌东世丅;
        private float 与丑丗不丏丛三丛丄;
        private float _immortalStartTime;
        private Rilisoft.PetHealingComponent 东丁丙丅与专丌三世;
        internal bool 丆东三与专丆一东丕;
        private int <专业丞不丟专专丐与>k__BackingField;
        private Rilisoft.PetAnimation _currAnimation;
        private bool NOT_SCALE_ANIMS;
        private bool 丑丛七丄东丝丝丂三;
        private float _stayTime;
        private bool <三业且丈丌丝丐专专>k__BackingField;
        protected System.Nullable<UnityEngine.Vector3> 丒丂七不世丟业丌丆;
        private float _acceleration;
        private float _speed;
        private const float 丈丘丈不丕三丙三丝 = 0.1;
        private float 丟丂丈不七不七且丟;
        private float 丑丁世丟与三下专丒;
        private UnityEngine.Vector3 专丘丞七丌世丄七丘;
        private UnityEngine.Vector3 <丂丝世丐且丄丒三丘>k__BackingField;
        private bool 丌三七丙七丑万且丈;
        private float 专丆下丈丌一丝上一;
        private System.Threading.CancellationTokenSource 世丟丘丘专丘下一丕;
        private bool <专丙丙东丛丌业七世>k__BackingField;
        private bool 不丏丈丆丏丐下上丒;
        private UnityEngine.AudioSource 丝丆下丒丗丅丗不七;
        private UnityEngine.AudioSource 丈与万不丙丐丙丏七;
        
        // Properties
        public UnityEngine.Collider 业丞丌万丏上与丝与 { get; }
        public UnityEngine.Collider 与丂丅丛世丞丑且丟 { get; }
        public UnityEngine.Collider 丝且不七丂世丗下七 { get; }
        public UnityEngine.Transform 丄三丟丗东丟丝下丝 { get; }
        public bool 丈丐丁不丙东世七丕 { get; }
        public UnityEngine.Vector3 上丌与丂丝丕丙上且 { get; }
        internal float 万丄丅不丈丈丕业丘 { get; set; }
        internal Player_move_c 上丈丑丟丙丕万丑三 { get; set; }
        internal PetInfo 丁丏专且丙下丒丕不 { get; }
        internal UnityEngine.GameObject 丙丝且丛丘世丅东丒 { get; }
        internal UnityEngine.Animation 世丁丑丂丞丝丈丙丌 { get; }
        internal Rilisoft.AnimationHandler 丘丆下丝丂丒丛一三 { get; }
        private Rilisoft.PetHighlightComponent 丏业不丟一丘与丌丙 { get; }
        internal bool 一丄东专专丛丏丞丘 { get; set; }
        internal bool 七万不丈丐业丏三丕 { get; }
        protected virtual System.Nullable<UnityEngine.Vector3> 专且世丗丑且不丘专 { get; }
        internal virtual UnityEngine.Vector3 万东丘丌一丕丌丛丂 { get; }
        internal virtual bool 专丞三丈丐丝下丞丘 { get; }
        internal bool 世丆不丁丌丁丞世业 { get; set; }
        internal float 三丞丁三丂丏丟丌丌 { get; }
        internal float 丂上丟不丕上丞丝三 { get; }
        internal bool 丏世丑专业丗丆业东 { get; set; }
        public int 丗且丗丞丝丄世上一 { get; set; }
        public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
        public float 丟丆丆丝东世一丒丐 { get; }
        public bool 丁丙世丕丐丕丞丈丂 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 下丝丒东丟丂一七世 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 世丙与东业丗丆一不 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丅丗丂下业丌专且三 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丐万世丙且万一丘万 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丘与丆不丝丒不丕专 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丟世万世丏万世丟丏 { get; }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丛万丞丛丘下不丝丈 { get; }
        internal float 业丛丗万丅且丆与丏 { get; set; }
        internal bool 且丅丑不丏与专且丈 { get; set; }
        internal float 且丆丟丗业丛丗丑丑 { get; set; }
        internal bool 丈丛丂丘丝丑下专不 { get; }
        internal float 丛丑且七丕丅业丒丂 { get; set; }
        internal float 不丑业丑丟丄丐丒丁 { get; }
        internal float 丄万丂且与与丂丌丞 { get; }
        internal UnityEngine.Vector3 业丘丆丟下一丛丅丒 { get; set; }
        protected bool 丛丞丘丏七丅且丘七 { get; }
        private float 七丄且丞三丂上东上 { get; }
        internal bool 丁不丒且丝丌三不丗 { get; set; }
        internal bool 丐东丘七丁丐专三丘 { get; }
        internal UnityEngine.AudioSource 下业一不丐丁丁世与 { get; }
        internal UnityEngine.AudioSource 丈丗丝上丐丆三上一 { get; }
        
        // Methods
        public UnityEngine.Collider get_aimCollider()
        {
            return (UnityEngine.Collider)this.BodyCollider;
        }
        public UnityEngine.Collider get_bodyAimCollider()
        {
            return (UnityEngine.Collider)this.BodyCollider;
        }
        public UnityEngine.Collider get_headAimCollider()
        {
            return (UnityEngine.Collider)this.HeadCollider;
        }
        public UnityEngine.Transform get_targetTransform()
        {
            return this.transform;
        }
        public bool get_isTargetDead()
        {
            return true;
        }
        public UnityEngine.Vector3 get_currentTargetVelocity()
        {
            return new UnityEngine.Vector3() {x = this.<丂丝世丐且丄丒三丘>k__BackingField};
        }
        internal float 万丞丆丌世丝丞丆上()
        {
            if(this.丁丌三丁一丈丄丙丈 != null)
            {
                    return this.丁丌三丁一丈丄丙丈.丝丙丐且丟丅三丛七();
            }
            
            return this.丁丌三丁一丈丄丙丈.丝丙丐且丟丅三丛七();
        }
        internal void 丗丕三下丈丅东丟上(float 丙业与丙丗丝不丈东)
        {
            this.丁丌三丁一丈丄丙丈.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            var val_1 = (丙业与丙丗丝不丈东 > 0f) ? 1 : 0;
            goto typeof(Rilisoft.PetEngine).__il2cppRuntimeField_388;
        }
        internal Player_move_c 万东丂七东丁与业东()
        {
            return (Player_move_c)this._owner;
        }
        private void 丆丝业七与丕丑一丟(Player_move_c 丙业与丙丗丝不丈东)
        {
            this._owner = 丙业与丙丗丝不丈东;
        }
        internal PetInfo 丙丕丞且丕不丘丙丑()
        {
            return (PetInfo)this._info;
        }
        internal UnityEngine.GameObject 下七丏不丒丗业丛专()
        {
            if(this._model != 0)
            {
                    return (UnityEngine.GameObject)this._model;
            }
            
            UnityEngine.GameObject val_3 = 丞东丑专丛丆丄丝世.七一与世与业丐且且(丝三丁东丈丒世丅业:  this.gameObject, 丒丘丏上丙丟丑丕丈:  "Body", 丟丝七七一丁丏丏丙:  true);
            this._model = val_3;
            if(val_3 != 0)
            {
                    return (UnityEngine.GameObject)this._model;
            }
            
            object[] val_5 = new object[1];
            val_5[0] = this.gameObject.name;
            UnityEngine.Debug.LogErrorFormat(format:  "[PETS] model object not found for pet \'{0}\'. Please rename root model object to \'Body\'", args:  val_5);
            return (UnityEngine.GameObject)this._model;
        }
        internal UnityEngine.Animation 与丒万一世与万七专()
        {
            UnityEngine.Animation val_4;
            if(this._animator == 0)
            {
                    this._animator = this.下七丏不丒丗业丛专().GetComponent<UnityEngine.Animation>();
                return val_4;
            }
            
            val_4 = this._animator;
            return val_4;
        }
        internal Rilisoft.AnimationHandler 丄丐东三东丂与业与()
        {
            Rilisoft.AnimationHandler val_4;
            if(this._animationHandler == 0)
            {
                    this._animationHandler = this.下七丏不丒丗业丛专().GetComponent<Rilisoft.AnimationHandler>();
                return val_4;
            }
            
            val_4 = this._animationHandler;
            return val_4;
        }
        private Rilisoft.PetHighlightComponent 三丄丝丅丅万丑三丝()
        {
            Rilisoft.PetHighlightComponent val_4;
            if(this._highlightComponentComponentValue == 0)
            {
                    this._highlightComponentComponentValue = this.gameObject.GetComponent<Rilisoft.PetHighlightComponent>();
                return val_4;
            }
            
            val_4 = this._highlightComponentComponentValue;
            return val_4;
        }
        internal bool 丛丐丕丙丟丞丁丛上()
        {
            return (bool)this.<下丗丗丗丂丌丌丄丟>k__BackingField;
        }
        private void 业丑专世丟丑不丌丌(bool 丙业与丙丗丝不丈东)
        {
            this.<下丗丗丗丂丌丌丄丟>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 丐丂丌丗丆丛东丘丁()
        {
            return (bool)(this.万丞丆丌世丝丞丆上() > 0f) ? 1 : 0;
        }
        protected virtual System.Nullable<UnityEngine.Vector3> get_MoveToTargetPosition()
        {
            UnityEngine.Transform val_3;
            UnityEngine.Object val_4;
            val_3 = this;
            val_4 = 0;
            if(this.丘与丈丘丒丂丁丛丟 == val_4)
            {
                    return 0;
            }
            
            val_3 = this.丘与丈丘丒丂丁丛丟;
            UnityEngine.Vector3 val_2 = val_3.position;
            val_4 = public System.Void System.Nullable<UnityEngine.Vector3>::.ctor(UnityEngine.Vector3 value);
            return 0;
        }
        internal Rilisoft.PetAnimation 丕东丌丄丁丛丌丑丕(Rilisoft.丘且一万丏丕丝丘丁 丁丅丈丌丟世丗丗丟)
        {
            var val_3;
            int val_1 = this.Animations.Count;
            if(val_1 != 0)
            {
                    var val_3 = 0;
                do
            {
                val_3 = this.Animations.Item[0];
                if(val_2.Type == 丁丅丈丌丟世丗丗丟)
            {
                    return (Rilisoft.PetAnimation)val_3;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_1 != val_3);
            
            }
            
            val_3 = 0;
            return (Rilisoft.PetAnimation)val_3;
        }
        internal string 丕丘下东一丆丏且专(Rilisoft.丘且一万丏丕丝丘丁 丁丅丈丌丟世丗丗丟)
        {
            string val_2;
            if((this.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟)) == null)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_2 = val_1.AnimationName;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        internal float 丙丒丏三丆业丗东丟(Rilisoft.丘且一万丏丕丝丘丁 丌七丞丌丑丆丈万不)
        {
            if((this.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  丌七丞丌丑丆丈万不)) == null)
            {
                    return 0f;
            }
            
            return this.丙丒丏三丆业丗东丟(七不丐下丟专业万丅:  val_1.AnimationName);
        }
        internal float 丙丒丏三丆业丗东丟(string 七不丐下丟专业万丅)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Collections.IEnumerator val_2 = this.与丒万一世与万七专().GetEnumerator();
            label_17:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = val_2.Current;
            if(val_15 != null)
            {
                    if(null == null)
            {
                goto label_14;
            }
            
            }
            
            val_15 = 0;
            val_16 = 1;
            goto label_15;
            label_14:
            val_16 = 0;
            label_15:
            if((System.String.op_Equality(a:  val_15.clip.name, b:  七不丐下丟专业万丅)) == false)
            {
                goto label_17;
            }
            
            val_17 = 0;
            val_18 = 0;
            val_19 = val_15.clip.length * val_15.speed;
            goto label_22;
            label_7:
            val_17 = 0;
            val_18 = 0;
            val_19 = 0f;
            label_22:
            if(val_2 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_2.Dispose();
            }
            
            if( == 1)
            {
                goto label_39;
            }
            
            if(93 == 99)
            {
                    return (float)val_19;
            }
            
            val_19 = 0f;
            if( == false)
            {
                    return (float)val_19;
            }
            
            if(93 != 93)
            {
                goto label_42;
            }
            
            return (float)val_19;
            label_39:
            if( == false)
            {
                goto label_44;
            }
            
            label_42:
            label_44:
            val_19 = 0f;
            return (float)val_19;
        }
        internal virtual UnityEngine.Vector3 get_MovePosition()
        {
            return UnityEngine.Vector3.zero;
        }
        internal virtual bool get_CanMoveToPlayer()
        {
            return true;
        }
        internal bool 丘丒丝七丁下丂与丁()
        {
            return (bool)this._isMine;
        }
        internal void 丂七三丐一万丈业丒(bool 丙业与丙丗丝不丈东)
        {
            this._isMine = 丙业与丙丗丝不丈东;
        }
        internal float 世且丈且丘丗且丞丄()
        {
            float val_2 = 丘丐丘万丌丟丞下丝.丛丆世丞不丟一丌丂();
            val_2 = this._info.RespawnTime * val_2;
            return (float)val_2;
        }
        internal float 丏丛万丆丝丌丏丟下()
        {
            if(this.与丑丗不丏丛三丛丄 < 0)
            {
                    return (float)val_2;
            }
            
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            val_2 = (this.与丑丗不丏丛三丛丄 + this.世且丈且丘丗且丞丄()) - val_2;
            return (float)val_2;
        }
        internal bool 一不丑一丑一丛丘丙()
        {
            return (bool)(this._immortalStartTime > 0f) ? 1 : 0;
        }
        internal void 丂丌不丝丂下丙专东(bool 丙业与丙丗丝不丈东)
        {
            this._immortalStartTime = UnityEngine.Time.realtimeSinceStartup;
        }
        internal void 丟三世丘丅丌丟三与(Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, int 丞丗且下世丐业丌丙)
        {
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            if(丐丟丘世丁三丕专专 == 16)
            {
                    return;
            }
            
            val_27 = null;
            val_27 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if(this.且丘丗三丌不万上丝 != 0)
            {
                    return;
            }
            
            if(this.万丞丆丌世丝丞丆上() <= 0f)
            {
                    return;
            }
            
            if(this._owner == 0)
            {
                    return;
            }
            
            val_28 = 1152921535723762144;
            if(this.CurrentState.丁丟丏一丕业丞丏丂() == 0)
            {
                    return;
            }
            
            if(this.CurrentState.丁丟丏一丕业丞丏丂() == 7)
            {
                    return;
            }
            
            if(this.CurrentState.丁丟丏一丕业丞丏丂() == 5)
            {
                    return;
            }
            
            if(this.CurrentState.丁丟丏一丕业丞丏丂() == 6)
            {
                    return;
            }
            
            val_28 = 1152921525490623376;
            val_29 = 0;
            goto label_20;
            label_44:
            val_30 = null;
            val_30 = null;
            Player_move_c val_12 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_12.mySkinName.丘丘丘丏丌丁丐丆丗 == 0)
            {
                goto label_35;
            }
            
            val_31 = null;
            val_31 = null;
            Player_move_c val_14 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_14.mySkinName.丘丘丘丏丌丁丐丆丗.viewID != 丞丗且下世丐业丌丙)
            {
                goto label_35;
            }
            
            val_32 = null;
            val_32 = null;
            Player_move_c val_16 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            if(val_16.万万一与丝业七专下 == false)
            {
                goto label_40;
            }
            
            label_35:
            val_29 = 1;
            label_20:
            val_33 = null;
            val_33 = null;
            if(val_29 < 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
            {
                goto label_44;
            }
            
            return;
            label_40:
            if((val_29 & 2147483648) != 0)
            {
                    return;
            }
            
            val_34 = null;
            val_34 = null;
            if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0] == this._owner)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_21 = this._owner.transform.position;
            val_35 = null;
            val_35 = null;
            UnityEngine.Vector3 val_24 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].transform.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z})) > this._info.OffenderDetectRange)
            {
                    return;
            }
            
            val_36 = null;
            val_36 = null;
            this.且丘丗三丌不万上丝 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
        }
        public int get_moduleResistShownFrame()
        {
            return (int)this.<专业丞不丟专专丐与>k__BackingField;
        }
        public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
        {
            this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.Transform get_transform()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.transform;
            }
            
            return val_1.transform;
        }
        public float get_maxHealth()
        {
            if(this._info != null)
            {
                    return this._info.HP;
            }
            
            return this._info.HP;
        }
        public float GetGamePlayForBaseGamePlay(int 业丆丈丟世一业一丙, int 业万上丆丐丞且丒七)
        {
            return (float)(float)业丆丈丟世一业一丙;
        }
        public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
        {
            object val_17;
            Player_move_c val_18;
            var val_19;
            var val_20;
            val_17 = 专丞上七七且丝七丗;
            val_18 = this._owner;
            if(val_18 == 0)
            {
                goto label_41;
            }
            
            val_18 = 1152921505171275776;
            val_19 = null;
            val_19 = null;
            if((((((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) || (GameConnect.且丞丁东丝丗上丈业() == true)) || (GameConnect.丅丟下专不丁一丈七() == true)) || (GameConnect.七丂万专且丏丘一丙() == true)) || (GameConnect.七丂万专且丏丘一丙() == true)) || (GameConnect.丙丘不世专且万丄丐() == true))
            {
                goto label_45;
            }
            
            val_18 = this._owner;
            if((val_18.Equals(other:  val_17)) == false)
            {
                goto label_23;
            }
            
            label_45:
            val_20 = 0;
            return (bool)val_20;
            label_23:
            if(GameConnect.丆丁上丟丛业丄丅丝() == false)
            {
                goto label_27;
            }
            
            val_18 = this._owner.丘丑丅三丆丑丌且丝();
            if(val_18 == val_17.丘丑丅三丆丑丌且丝())
            {
                goto label_45;
            }
            
            label_27:
            if(GameConnect.丄丏丒丏上东业丒一() == false)
            {
                goto label_41;
            }
            
            val_18 = this._owner.丟三丏丅世一丟丟上;
            if(val_18 == 0)
            {
                goto label_41;
            }
            
            val_18 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
            if(val_18 == 0)
            {
                goto label_41;
            }
            
            val_17 = this._owner.丟三丏丅世一丟丟上.且世专不丄丏七下万();
            if(val_17 ^ 专丞上七七且丝七丗.丟三丏丅世一丟丟上.且世专不丄丏七下万() == false)
            {
                goto label_45;
            }
            
            label_41:
            val_20 = 1;
            return (bool)val_20;
        }
        public virtual void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
        {
            System.Object[] val_5;
            int val_6;
            var val_7;
            val_6 = 丒丈丐丐丗丐专丈丏;
            float val_6 = 丞丈专下丈专业三丞;
            if(this.万丞丆丌世丝丞丆上() <= 0f)
            {
                    return;
            }
            
            if(GameConnect.东且三丆丑世世丘丟() == true)
            {
                    return;
            }
            
            if(this._immortalStartTime > 0f)
            {
                    return;
            }
            
            val_5 = 1152921505171275776;
            float val_5 = 0.5f;
            val_5 = val_6 * val_5;
            val_7 = null;
            val_6 = ((this._owner.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  7)) != true) ? (val_5) : (val_6);
            val_7 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
                object[] val_4 = new object[2];
                val_5 = val_4;
                val_5[0] = val_6;
                val_6 = val_6;
                val_5[1] = val_6;
                this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  10, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
                return;
            }
            
            this.丘上业丗业下万与丝(丞丈专下丈专业三丞:  val_6, 丞丗且下世丐业丌丙:  0);
        }
        public bool IsDead()
        {
            return (bool)(this.万丞丆丌世丝丞丆上() <= 0f) ? 1 : 0;
        }
        public bool get_isLivingTarget()
        {
            return true;
        }
        public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
        {
            null = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
            {
                    object[] val_1 = new object[2];
                val_1[0] = 上上丗丁丏丙丄丏七;
                val_1[1] = 丝三丛且丘不丌丙下;
                this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  206, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
                return;
            }
            
            this.一丒丝丅丂丒丕丕丕(七万丑三丐丏七丏丅:  上上丗丁丏丙丄丏七, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下);
        }
        internal void 一丒丝丅丂丒丕丕丕(float 七万丑三丐丏七丏丅, string 丝三丛且丘不丌丙下)
        {
            if(this.万丞丆丌世丝丞丆上() <= 0f)
            {
                    return;
            }
            
            this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  UnityEngine.Mathf.Clamp(value:  this.万丞丆丌世丝丞丆上() + 七万丑三丐丏七丏丅, min:  0f, max:  this.maxHealth));
        }
        internal void 丘上业丗业下万与丝(float 丞丈专下丈专业三丞, int 丞丗且下世丐业丌丙 = 0)
        {
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            var val_12;
            float val_2 = UnityEngine.Mathf.Clamp(value:  丞丈专下丈专业三丞, min:  0f, max:  3.402823E+38f);
            val_2 = this.万丞丆丌世丝丞丆上() - val_2;
            this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  val_2);
            val_9 = this.三丄丝丅丅万丑三丝();
            if(val_9 != 0)
            {
                    val_9 = this.三丄丝丅丅万丑三丝();
                val_9.丏丝丄不丝丆三丏丟();
            }
            
            val_10 = null;
            val_10 = null;
            if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (this._isMine != false)) && ((丞丗且下世丐业丌丙 >= 1) && (this.万丞丆丌世丝丞丆上() <= 0f)))
            {
                    val_11 = null;
                val_11 = null;
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
            {
                    val_9 = this.photonView;
                object[] val_7 = new object[1];
                val_7[0] = 丞丗且下世丐业丌丙;
                val_9.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  34, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_7);
            }
            
            }
            
            val_12 = null;
            val_12 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if(this._isMine == true)
            {
                    return;
            }
            
            if(this.万丞丆丌世丝丞丆上() > 0f)
            {
                    return;
            }
            
            if(this.不丏丈丆丏丐下上丒 == true)
            {
                    return;
            }
            
            this.丛丐丟丞丑丛与上上();
        }
        public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
        {
            object val_2;
            int val_3;
            var val_4;
            var val_5;
            int val_6;
            val_2 = 丞世不丒下上上丝丑;
            byte val_1 = val_2 & 255;
            if(val_1 > 94)
            {
                goto label_1;
            }
            
            if(val_1 == 10)
            {
                goto label_2;
            }
            
            if(val_1 == 34)
            {
                goto label_3;
            }
            
            if(val_1 != 94)
            {
                goto label_8;
            }
            
            this.丆丕丒东丗丒丄万且();
            goto label_24;
            label_1:
            if(val_1 == 119)
            {
                goto label_6;
            }
            
            if(val_1 == 121)
            {
                goto label_7;
            }
            
            if(val_1 != 206)
            {
                goto label_8;
            }
            
            val_3 = 专丒丌丆下丐丞丟丞.Length;
            if(val_3 == 0)
            {
                    val_4 = 0;
                val_3 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            val_2 = 专丒丌丆下丐丞丟丞[0];
            if(val_3 <= 1)
            {
                    val_4 = 0;
            }
            
            object val_2 = 专丒丌丆下丐丞丟丞[1];
            this.一丒丝丅丂丒丕丕丕(七万丑三丐丏七丏丅:  3.782474E-38f, 丝三丛且丘不丌丙下:  null);
            goto label_24;
            label_8:
            val_5 = 0;
            return (bool)val_5;
            label_2:
            val_6 = 专丒丌丆下丐丞丟丞.Length;
            if(val_6 == 0)
            {
                    val_6 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            val_2 = 专丒丌丆下丐丞丟丞[0];
            object val_3 = 专丒丌丆下丐丞丟丞[1];
            this.丘上业丗业下万与丝(丞丈专下丈专业三丞:  3.782474E-38f, 丞丗且下世丐业丌丙:  21884928);
            goto label_24;
            label_3:
            object val_4 = 专丒丌丆下丐丞丟丞[0];
            this.三业业东丑丙丝不世(丞丗且下世丐业丌丙:  21884928);
            goto label_24;
            label_6:
            object val_5 = 专丒丌丆下丐丞丟丞[0];
            this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  3.782474E-38f);
            goto label_24;
            label_7:
            this.丝上世丒丗丞丐丘丕 = 专丒丌丆下丐丞丟丞[0];
            label_24:
            val_5 = 1;
            return (bool)val_5;
        }
        private void 业与丏丏丕丗且与七(float 丞丈专下丈专业三丞, int 丞丗且下世丐业丌丙)
        {
            this.丘上业丗业下万与丝(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 丞丗且下世丐业丌丙:  丞丗且下世丐业丌丙);
        }
        private void 三业业东丑丙丝不世(int 丞丗且下世丐业丌丙)
        {
            var val_5;
            Player_move_c val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_6 == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_690.viewID != 丞丗且下世丐业丌丙)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            WeaponSounds val_4 = this._owner.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
            丈且丁丐丆丞丁上万(丟不丏上丏且丁下丈:  this._owner.丟三丏丅世一丟丟上.丄下丝业七丅与且丐, 丆万一不丌且东丐丐:  val_4.Tag);
        }
        protected bool 丕丐丙丄丏丏下丂一(Rilisoft.丘且一万丏丕丝丘丁 丌七丞丌丑丆丈万不)
        {
            return (bool)((丌七丞丌丑丆丈万不 | 4) == 5) ? 1 : 0;
        }
        internal virtual void 丞三三丑丞丂丐丝世(Rilisoft.丘且一万丏丕丝丘丁 丌七丞丌丑丆丈万不)
        {
            Rilisoft.丘且一万丏丕丝丘丁 val_8;
            Rilisoft.PetAnimation val_9;
            var val_10;
            val_8 = 丌七丞丌丑丆丈万不;
            if(this._currAnimation != null)
            {
                    if((System.String.IsNullOrEmpty(value:  this._currAnimation.AnimationName)) != true)
            {
                    this.与丒万一世与万七专().Item[this._currAnimation.AnimationName].speed = 1f;
                this._currAnimation = 0;
            }
            
            }
            
            val_9 = this.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  val_8);
            if(val_9 == null)
            {
                goto label_6;
            }
            
            label_18:
            this.与丒万一世与万七专().CrossFade(animation:  val_4.AnimationName);
            this._currAnimation = val_9;
            if(val_4.Type == 3)
            {
                    this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.ClipDeath);
            }
            
            if(this._isMine == false)
            {
                    return;
            }
            
            this.丁丑丌世丟丏丛丘丟();
            if(this._isMine == false)
            {
                    return;
            }
            
            val_9 = 1152921505171275776;
            val_10 = null;
            val_10 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if((val_8 | 4) == 5)
            {
                    return;
            }
            
            this.丕东丘丐业丏业万业.currentAnimation = val_8;
            return;
            label_6:
            if(val_8 != 5)
            {
                    return;
            }
            
            val_8 = 1;
            val_9 = this.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  1);
            if(val_9 != null)
            {
                goto label_18;
            }
        
        }
        internal void 丁丑丌世丟丏丛丘丟()
        {
            if(this.NOT_SCALE_ANIMS != false)
            {
                    return;
            }
            
            if(this._currAnimation == null)
            {
                    return;
            }
            
            Rilisoft.丘且一万丏丕丝丘丁 val_4 = this._currAnimation.Type;
            val_4 = val_4 | 4;
            if(val_4 != 5)
            {
                    return;
            }
            
            this.与丒万一世与万七专().Item[this._currAnimation.AnimationName].speed = this._speed * this._currAnimation.SpeedModificator;
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丆与丛世业丆下不丌()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new PetEngine.与七东丘丞丙上丅丝(与且专丈不万东一万:  this);
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丗上丆丙丕丛上丂三()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new PetEngine.丁丁丗丞丒丕不丑丐(与且专丈不万东一万:  this);
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丑万世世不丑世下一()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new PetEngine.丈丘且丈上丏下与不(与且专丈不万东一万:  this);
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丄三丑丟一与丏丒与()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new PetEngine.丒丑丌丞丈丑丟下丁(与且专丈不万东一万:  this);
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> 丕丐业丛丐丙丏丘丟()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new PetEngine.丁丛丟丄丝丌丈丕下(与且专丈不万东一万:  this);
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> get_MoveToOwnerState()
        {
            return 0;
        }
        protected virtual Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> get_MoveToTargetState()
        {
            return 0;
        }
        protected virtual void Awake()
        {
            var val_15;
            this.三丑丂丘业丌东世丅 = this.gameObject.AddComponent<AdvancedEffects>();
            val_2.syncInLocal = true;
            val_15 = null;
            val_15 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                goto label_5;
            }
            
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                goto label_13;
            }
            
            PhotonView val_3 = this.GetComponent<PhotonView>();
            if(val_3 == 0)
            {
                goto label_13;
            }
            
            this.photonView = val_3;
            if(val_3.isMine == false)
            {
                goto label_13;
            }
            
            label_5:
            this._isMine = true;
            label_13:
            this.丕东丘丐业丏业万业 = this.GetComponent<Rilisoft.NetworkPetEngineSynch>();
            this.七丈丁万丛万业丈与 = this.transform;
            this.业丌丙丕丘上丝丟丅 = this.GetComponent<TargetScanner>();
            val_8.LookPoint = this._lookPoint;
            this.BodyCollider = this.gameObject.GetComponent<UnityEngine.Collider>();
            this.HeadCollider = Unity.Linq.丅丆万丟丐丏丏下丄.上丅丝与丌下丛丁丑(丈丆上丅丘世专丑丕:  this.gameObject, 丒丘丏上丙丟丑丕丈:  "HeadCollider").GetComponent<UnityEngine.Collider>();
            this.丟丅三丝丄丈万丒三 = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
        internal void 世与东丗世三丞丞不(string 丞丅上丏丂且下丅与)
        {
            TargetScanner val_9;
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  丞丅上丏丂且下丅与)) == null)
            {
                    if(this.丑丛七丄东丝丝丂三 == false)
            {
                goto label_3;
            }
            
            }
            
            val_9 = this.业丌丙丕丘上丝丟丅;
            this._info = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  丞丅上丏丂且下丅与);
            this.业丌丙丕丘上丝丟丅.DetectRadius = val_4.TargetDetectRange;
            if(this._isMine == false)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this._info.HealDelaySecs <= 0f)
            {
                    return;
            }
            
            this.东丁丙丅与专丌三世 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.PetHealingComponent>(丝三丁东丈丒世丅业:  this.gameObject);
            return;
            label_3:
            val_9 = 1152921504848912384;
            if(this.东丁丙丅与专丌三世 == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.东丁丙丅与专丌三世);
        }
        private void Start()
        {
            var val_22;
            var val_23;
            丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  3);
            丘丛丞且一丅丁丏丐.丙丅丅丆丂一上业丐(不丂丅丁且丆东东丂:  this.transform, 丞下万上三丘上与专:  this);
            UnityEngine.Vector3 val_4 = this.transform.position;
            this.专丘丞七丌世丄七丘 = val_4;
            mem[1152921543332659144] = val_4.y;
            mem[1152921543332659148] = val_4.z;
            this.丟丞丝丝东丆七且且();
            if((this._owner != 0) && (this._owner.丅下万丏丘东丄丌万 != false))
            {
                    this.丑丛七丄东丝丝丂三 = true;
            }
            
            this.Enabled = this._isMine;
            if(this._isMine == false)
            {
                goto label_9;
            }
            
            if(this.丑丛七丄东丝丝丂三 != true)
            {
                    七下下业三丞专丈丛 val_7 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this._info.Id);
                this.东与丂丏丐丞三丘丁(业万丈且丘丆丝丏丙:  val_7.专丕与丒丗丁丘专丟);
            }
            
            this.世与东丗世三丞丞不(丞丅上丏丂且下丅与:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject));
            if(this.丑丛七丄东丝丝丂三 != false)
            {
                    this.东与丂丏丐丞三丘丁(业万丈且丘丆丝丏丙:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._info.Lkey));
            }
            
            if(this._info == null)
            {
                goto label_20;
            }
            
            this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  this._info.HP);
            val_22 = null;
            val_22 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                goto label_24;
            }
            
            this.专丆丐万上与丏丐丕();
            goto label_24;
            label_9:
            label_24:
            val_23 = null;
            val_23 = null;
            if(((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)) && (this._isMine != false))
            {
                    PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
            }
            
            this._immortalStartTime = UnityEngine.Time.realtimeSinceStartup;
            if(this.EffectShow != 0)
            {
                    this.EffectShow.gameObject.transform.SetParent(p:  0);
            }
            
            if(this.EffectHide == 0)
            {
                    return;
            }
            
            this.EffectHide.gameObject.transform.SetParent(p:  0);
            return;
            label_20:
            object[] val_19 = new object[1];
            val_19[0] = this.gameObject.name;
            UnityEngine.Debug.LogErrorFormat(format:  "[PETS] info for pet \'{0}\' not found", args:  val_19);
        }
        internal PetEngine()
        {
            this.丁丌三丁一丈丄丙丈 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  1f);
            this.PlayProfileAnimationAfterSecs = 3f;
            this.ToRunSpeedPercent = 5.510186E-41f;
            this.丝且且丁上丝丒丞业 = true;
            System.Collections.Generic.List<Rilisoft.PetAnimation> val_2 = new System.Collections.Generic.List<Rilisoft.PetAnimation>();
            Rilisoft.PetAnimation val_3 = null;
            .SpeedModificator = 1f;
            val_3 = new Rilisoft.PetAnimation();
            if(val_3 != null)
            {
                    .Type = 0;
            }
            else
            {
                    mem[32] = 0;
            }
            
            .AnimationName = "Idle";
            val_2.Add(item:  val_3);
            Rilisoft.PetAnimation val_4 = null;
            .SpeedModificator = 1f;
            val_4 = new Rilisoft.PetAnimation();
            if(val_4 != null)
            {
                    .Type = 1;
            }
            else
            {
                    mem[32] = 1;
            }
            
            .AnimationName = "Walk";
            val_2.Add(item:  val_4);
            Rilisoft.PetAnimation val_5 = null;
            .SpeedModificator = 1f;
            val_5 = new Rilisoft.PetAnimation();
            if(val_5 != null)
            {
                    .Type = 2;
            }
            else
            {
                    mem[32] = 2;
            }
            
            .AnimationName = "Attack";
            val_2.Add(item:  val_5);
            Rilisoft.PetAnimation val_6 = null;
            .SpeedModificator = 1f;
            val_6 = new Rilisoft.PetAnimation();
            if(val_6 != null)
            {
                    .Type = 3;
            }
            else
            {
                    mem[32] = 3;
            }
            
            .AnimationName = "Dead";
            val_2.Add(item:  val_6);
            Rilisoft.PetAnimation val_7 = null;
            .SpeedModificator = 1f;
            val_7 = new Rilisoft.PetAnimation();
            if(val_7 != null)
            {
                    .Type = 4;
            }
            else
            {
                    mem[32] = 4;
            }
            
            .AnimationName = "Profile";
            val_2.Add(item:  val_7);
            Rilisoft.PetAnimation val_8 = null;
            .SpeedModificator = 1f;
            val_8 = new Rilisoft.PetAnimation();
            if(val_8 != null)
            {
                    .Type = 1;
            }
            else
            {
                    mem[32] = 1;
            }
            
            .AnimationName = "Run";
            val_2.Add(item:  val_8);
            this.Animations = val_2;
            this.专丆下丈丌一丝上一 = -1f;
            Rilisoft.且三与世丁丏丂丌下 val_9 = this.与丑丌丌丌丁丌不丕();
            val_9.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void Rilisoft.PetEngine::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        }
        private void OnEnable()
        {
            this.丄丐东三东丂与业与().SubscribeTo(丌丁一下丙业丙丗不:  this.丕丘下东一丆丏且专(丁丅丈丌丟世丗丗丟:  2), 丒丁丐下上丒丂三丛:  2, 专丞丄丄且三丏万丐:  false, 业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.PetEngine::下业丙世丛丏丄且丞()));
        }
        private void 下业丙世丛丏丄且丞()
        {
            this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.ClipAttack);
        }
        private void OnDisable()
        {
            this.丄丐东三东丂与业与().Unsubscribe(丌丁一下丙业丙丗不:  this.丕丘下东一丆丏且专(丁丅丈丌丟世丗丗丟:  2), 丒丁丐下上丒丂三丛:  2, 业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.PetEngine::下业丙世丛丏丄且丞()));
        }
        protected virtual void InitSM()
        {
            this.丏丛不下一丝专丕丙();
            Rilisoft.StateMachine<T> val_1 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            Rilisoft.StateMachine<T> val_2 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            Rilisoft.StateMachine<T> val_3 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            Rilisoft.StateMachine<T> val_4 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            Rilisoft.StateMachine<T> val_5 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            Rilisoft.StateMachine<T> val_6 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            Rilisoft.StateMachine<T> val_7 = this.万丂丝丁东丑丕丌丌(丏业丟一东丂东丘丛:  this);
            if(this.Enabled == false)
            {
                    return;
            }
            
            this.To(丘丏世丈业丛丞丘丒:  1);
        }
        public virtual void StopEngine()
        {
            this.业丌丙丕丘上丝丟丅.enabled = false;
        }
        internal bool 丆丙丘业一丛专世丙()
        {
            Player_move_c val_4;
            var val_5;
            val_4 = this;
            UnityEngine.Vector3 val_2 = this._owner.transform.position;
            if(val_2.y >= 0)
            {
                    val_4 = this._owner;
                var val_3 = (this._owner.万丝一万丐且丌业丛 == false) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        internal float 上七七七丛丏丏丛丟()
        {
            return (float)this._stayTime;
        }
        private void 业与丄且丌业丄专丏(float 丙业与丙丗丝不丈东)
        {
            this._stayTime = 丙业与丙丗丝不丈东;
        }
        internal bool 丘东丂不丕丝一丞丂()
        {
            return (bool)this.<三业且丈丌丝丐专专>k__BackingField;
        }
        private void 东东丛丁丏丈丁丗丅(bool 丙业与丙丗丝不丈东)
        {
            this.<三业且丈丌丝丐专专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal float 丅一与丗万丄丗丘丒()
        {
            return (float)this._acceleration;
        }
        private void 丈丑丈丕丝上丁丕与(float 丙业与丙丗丝不丈东)
        {
            this._acceleration = 丙业与丙丗丝不丈东;
        }
        internal bool 丅业东丘丟丞世丙丘()
        {
            return (bool)(this._acceleration > 0.01f) ? 1 : 0;
        }
        internal float 丂且专丕丄丗丒丝业()
        {
            return (float)this._speed;
        }
        private void 不丅丝丟三丐东下丝(float 丙业与丙丗丝不丈东)
        {
            this._speed = 丙业与丙丗丝不丈东;
        }
        internal float 丑丏且丁丐业下丑丕()
        {
            UnityEngine.Vector3 val_1 = this.七丈丁万丛万业丈与.position;
            UnityEngine.Vector3 val_3 = this._owner.transform.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        }
        internal float 丅七一丐丞七丄丒丟()
        {
            UnityEngine.Vector3 val_1 = this.七丈丁万丛万业丈与.position;
            UnityEngine.Vector3 val_2 = this.丘与丈丘丒丂丁丛丟.position;
            return UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public virtual float CalculateSpeedMultyplierByDistance()
        {
            float val_11;
            float val_12;
            float val_13;
            if(this.CurrentState.丁丟丏一丕业丞丏丂() != 2)
            {
                goto label_2;
            }
            
            val_11 = this._info.MaxToOwnerDistance * 0.3f;
            if(this.丑丏且丁丐业下丑丕() < 0)
            {
                goto label_4;
            }
            
            float val_4 = this.丑丏且丁丐业下丑丕();
            val_12 = 0.05f;
            goto label_5;
            label_2:
            val_13 = 1f;
            if(this.CurrentState.丁丟丏一丕业丞丏丂() != 3)
            {
                    return val_13;
            }
            
            val_11 = this._info.AttackStopDistance;
            if(this.丅七一丐丞七丄丒丟() < 0)
            {
                    return val_13;
            }
            
            float val_8 = this.丅七一丐丞七丄丒丟();
            val_12 = 0.1f;
            label_5:
            val_8 = val_8 * val_12;
            val_13 = val_8 + 1f;
            return val_13;
            label_4:
            val_13 = 1f;
            return val_13;
        }
        internal UnityEngine.Vector3 丞世专丒上专且东东()
        {
            return new UnityEngine.Vector3() {x = this.<丂丝世丐且丄丒三丘>k__BackingField};
        }
        private void 三丙丐不丄三丂上丘(UnityEngine.Vector3 丙业与丙丗丝不丈东)
        {
            this.<丂丝世丐且丄丒三丘>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921543335449604] = 丙业与丙丗丝不丈东.y;
            mem[1152921543335449608] = 丙业与丙丗丝不丈东.z;
        }
        protected virtual void Update()
        {
            UnityEngine.Vector3 val_53;
            float val_54;
            float val_55;
            UnityEngine.Transform val_56;
            var val_57;
            float val_58;
            var val_59;
            UnityEngine.GameObject val_60;
            Rilisoft.丛七下丌丑不一丄业 val_61;
            string val_62;
            UnityEngine.Vector3 val_2 = this.transform.position;
            val_53 = this.专丘丞七丌世丄七丘;
            val_55 = val_2.x;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_55, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_53, y = V11.16B, z = V10.16B});
            this.<丂丝世丐且丄丒三丘>k__BackingField = val_3;
            mem[1152921543335782804] = val_3.y;
            mem[1152921543335782808] = val_3.z;
            UnityEngine.Vector3 val_5 = this.transform.position;
            this.专丘丞七丌世丄七丘 = val_5;
            mem[1152921543335782792] = val_5.y;
            mem[1152921543335782796] = val_5.z;
            if((this.丒丂七不世丟业丌丆 & 1) == 0)
            {
                goto label_5;
            }
            
            val_54 = val_5.z;
            UnityEngine.Vector3 val_6 = this.七丈丁万丛万业丈与.position;
            val_53 = val_6.y;
            val_56 = this.七丈丁万丛万业丈与;
            float val_55 = this.丑丁世丟与三下专丒;
            float val_54 = System.Math.Abs(UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_54}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_53, z = val_6.z}));
            val_55 = this.丟丂丈不七不七且丟;
            val_55 = val_54 + val_55;
            this._acceleration = val_54;
            this.丑丁世丟与三下专丒 = val_55;
            float val_8 = UnityEngine.Time.deltaTime;
            val_8 = val_55 + val_8;
            this.丟丂丈不七不七且丟 = val_8;
            if(val_8 < 0.1f)
            {
                goto label_12;
            }
            
            this.丑丁世丟与三下专丒 = 0f;
            this.丟丂丈不七不七且丟 = 0f;
            val_8 = this.丑丁世丟与三下专丒 / val_8;
            this._speed = val_8;
            goto label_12;
            label_5:
            val_56 = this.七丈丁万丛万业丈与;
            label_12:
            val_57 = mem[this.七丈丁万丛万业丈与];
            UnityEngine.Vector3 val_9 = val_57.position;
            mem2[0] = 0;
            mem[1152921543335782764] = 0;
            val_58 = 0f;
            if(this._acceleration <= 0.01f)
            {
                    val_55 = this._stayTime;
                val_58 = val_55 + UnityEngine.Time.deltaTime;
                this._stayTime = val_58;
            }
            
            this._stayTime = val_58;
            this.<三业且丈丌丝丐专专>k__BackingField = (val_58 >= this.PlayProfileAnimationAfterSecs) ? 1 : 0;
            if(this._owner == 0)
            {
                goto label_97;
            }
            
            if(((this._owner.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  7)) == false) || (this.万丞丆丌世丝丞丆上() <= 0f))
            {
                goto label_20;
            }
            
            if(this.丘丐丅丕丛七三丙丕 == 0)
            {
                goto label_23;
            }
            
            val_59 = 1;
            val_60 = this.丘丐丅丕丛七三丙丕;
            goto label_26;
            label_20:
            if(this.丘丐丅丕丛七三丙丕 == 0)
            {
                goto label_97;
            }
            
            val_60 = this.丘丐丅丕丛七三丙丕;
            val_59 = 0;
            label_26:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_60, 丏业丟一东丂东丘丛:  false);
            label_97:
            if(this._isMine == false)
            {
                    return;
            }
            
            if(this._owner == 0)
            {
                    return;
            }
            
            if(this._owner.万丝一万丐且丌业丛 == false)
            {
                goto label_37;
            }
            
            this.丘与丈丘丒丂丁丛丟 = 0;
            this.且丘丗三丌不万上丝 = 0;
            this._immortalStartTime = UnityEngine.Time.realtimeSinceStartup;
            val_57 = 1152921535723748832;
            if(this.CurrentState != null)
            {
                    val_61 = public Rilisoft.丛七下丌丑不一丄业 StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>::丁丟丏一丕业丞丏丂();
                if(this.CurrentState.丁丟丏一丕业丞丏丂() == 7)
            {
                    return;
            }
            
                val_61 = public Rilisoft.丛七下丌丑不一丄业 StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>::丁丟丏一丕业丞丏丂();
                if(this.CurrentState.丁丟丏一丕业丞丏丂() == 6)
            {
                    return;
            }
            
            }
            
            if(this._isMine == false)
            {
                goto label_67;
            }
            
            if(this._info.petExplode != true)
            {
                    if(this._info.petDisablerExplode == false)
            {
                goto label_67;
            }
            
            }
            
            if(this.丆东三与专丆一东丕 == true)
            {
                goto label_67;
            }
            
            this.丆东三与专丆一东丕 = true;
            this.三上世七七上丞不丛();
            goto label_67;
            label_37:
            if(this.丆丙丘业一丛专世丙() == false)
            {
                goto label_50;
            }
            
            if(this._isMine == false)
            {
                goto label_75;
            }
            
            if(this.丑丛七丄东丝丝丂三 == false)
            {
                goto label_52;
            }
            
            if((System.String.op_Inequality(a:  this.丝上世丒丗丞丐丘丕, b:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._info.Lkey))) == false)
            {
                goto label_75;
            }
            
            val_62 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._info.Lkey);
            goto label_60;
            label_23:
            if(this.丌三七丙七丑万且丈 == true)
            {
                goto label_97;
            }
            
            var val_56 = 0;
            val_56 = val_56 + 1;
            goto label_66;
            label_50:
            val_57 = 1152921535723748832;
            if(this.CurrentState != null)
            {
                    val_61 = public Rilisoft.丛七下丌丑不一丄业 StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>::丁丟丏一丕业丞丏丂();
                if(this.CurrentState.丁丟丏一丕业丞丏丂() == 7)
            {
                    return;
            }
            
                val_61 = public Rilisoft.丛七下丌丑不一丄业 StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>::丁丟丏一丕业丞丏丂();
                if(this.CurrentState.丁丟丏一丕业丞丏丂() == 6)
            {
                    return;
            }
            
            }
            
            label_67:
            val_61 = 7;
            this.To(丘丏世丈业丛丞丘丒:  val_61);
            return;
            label_52:
            七下下业三丞专丈丛 val_35 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this._info.Id);
            if((System.String.op_Inequality(a:  this.丝上世丒丗丞丐丘丕, b:  val_35.专丕与丒丗丁丘专丟)) == false)
            {
                goto label_75;
            }
            
            七下下业三丞专丈丛 val_38 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this._info.Id);
            val_62 = val_38.专丕与丒丗丁丘专丟;
            label_60:
            this.东与丂丏丐丞三丘丁(业万丈且丘丆丝丏丙:  val_62);
            label_75:
            if((this._owner != 0) && (this._isMine != false))
            {
                    if((this.Enabled != false) && (this._owner.万丝一万丐且丌业丛 != true))
            {
                    this.丆东三与专丆一东丕 = false;
                this.SetTarget();
            }
            
            }
            
            if(this.CurrentState != null)
            {
                    if((((this.CurrentState.丁丟丏一丕业丞丏丂() == 4) || (this.CurrentState.丁丟丏一丕业丞丏丂() == 5)) || (this.CurrentState.丁丟丏一丕业丞丏丂() == 6)) || (this.CurrentState.丁丟丏一丕业丞丏丂() == 7))
            {
                goto label_94;
            }
            
            }
            
            Rilisoft.丘且一万丏丕丝丘丁 val_50 = this.一丈七万丕丏丑丛丘();
            label_94:
            if(this._immortalStartTime <= 0f)
            {
                    return;
            }
            
            this.丞丘丏丏丂一丞业七();
            return;
            label_66:
            UnityEngine.Coroutine val_53 = this.StartCoroutine(routine:  this.丝与丙丏世丞丌丂丙().GetEnumerator());
            goto label_97;
        }
        private void SetTarget()
        {
            var val_15;
            this.丘与丈丘丒丂丁丛丟 = 0;
            if(this.且丘丗三丌不万上丝 == 0)
            {
                goto label_30;
            }
            
            if(this.且丘丗三丌不万上丝.万丝一万丐且丌业丛 == true)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_2 = this.七丈丁万丛万业丈与.position;
            UnityEngine.Vector3 val_4 = this._owner.transform.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) <= this._info.MaxToOwnerDistance)
            {
                goto label_12;
            }
            
            label_5:
            this.且丘丗三丌不万上丝 = 0;
            label_30:
            if(this.丘与丈丘丒丂丁丛丟 != 0)
            {
                    return;
            }
            
            val_15 = 0;
            this.丘与丈丘丒丂丁丛丟 = this.业丌丙丕丘上丝丟丅.丘与丈丘丒丂丁丛丟.transform;
            return;
            label_12:
            if(this.且丘丗三丌不万上丝.gameObject.transform == 0)
            {
                goto label_30;
            }
            
            this.丘与丈丘丒丂丁丛丟 = this.且丘丗三丌不万上丝.gameObject.transform.root;
            goto label_30;
        }
        private System.Collections.IEnumerable 丝与丙丏世丞丌丂丙()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerable)new PetEngine.丛丛丌丏丑丕东丂世(丗丏丅丕丆世丁专丟:  -2);
        }
        internal void 丞丘丏丏丂一丞业七()
        {
            if(this._owner == 0)
            {
                    return;
            }
            
            this.三丄丝丅丅万丑三丝().三万专丕丟专丗丝丁(丂三丟丂丈丐丆丗丟:  (float)this._owner.丗丒丟丝丛业丌业丏);
            float val_5 = (float)this._owner.丗丒丟丝丛业丌业丏;
            val_5 = this._immortalStartTime + val_5;
            if(val_5 > UnityEngine.Time.realtimeSinceStartup)
            {
                    return;
            }
            
            this._immortalStartTime = 0f;
            this.三丄丝丅丅万丑三丝().且专万丐丗三世丅丂();
        }
        public virtual void SetCollidersEnabled(bool 丝三丄专丗丞丄丄丌)
        {
            if(this.BodyCollider.enabled ^ 丝三丄专丗丞丄丄丌 != false)
            {
                    this.BodyCollider.enabled = 丝三丄专丗丞丄丄丌;
            }
            
            if(this.HeadCollider.enabled ^ 丝三丄专丗丞丄丄丌 == false)
            {
                    return;
            }
            
            this.HeadCollider.enabled = 丝三丄专丗丞丄丄丌;
        }
        internal Rilisoft.丘且一万丏丕丝丘丁 一丈七万丕丏丑丛丘()
        {
            var val_4;
            UnityEngine.AudioClip val_5;
            if(this._acceleration <= 0.01f)
            {
                goto label_1;
            }
            
            float val_2 = UnityEngine.Mathf.Clamp(value:  this.ToRunSpeedPercent, min:  0f, max:  1f);
            val_2 = this._info.SpeedModif * val_2;
            if(this._speed >= 0)
            {
                goto label_5;
            }
            
            val_4 = 1;
            goto label_7;
            label_1:
            val_4 = (this.<三业且丈丌丝丐专专>k__BackingField) << 2;
            goto label_7;
            label_5:
            val_4 = 5;
            label_7:
            var val_3 = 5 | 4;
            val_3 = val_3 & 7;
            if(val_3 == 5)
            {
                    val_5 = this.ClipWalk;
            }
            else
            {
                    val_5 = 0;
            }
            
            this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_5);
            return 5;
        }
        internal void Destroy()
        {
            var val_3;
            this.Enabled = false;
            if(this._isMine == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public void OnDestroy()
        {
            丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  3);
            丘丛丞且一丅丁丏丐.丏丄丄东丒世专丌丁(不丂丅丁且丆东东丂:  this.transform);
            PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
            if(this.EffectShow != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.EffectShow.gameObject);
            }
            
            if(this.EffectHide == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.EffectHide.gameObject);
        }
        internal void 丗丑丝丕上丙世丆下()
        {
            var val_14;
            UnityEngine.Transform val_15;
            float val_16;
            float val_17;
            var val_18;
            var val_19;
            val_14 = this;
            if(this.EffectShow == 0)
            {
                    return;
            }
            
            val_15 = this.七丈丁万丛万业丈与;
            UnityEngine.Vector3 val_4 = val_15.position;
            val_16 = val_4.x;
            val_17 = val_4.z;
            this.EffectShow.gameObject.transform.position = new UnityEngine.Vector3() {x = val_16, y = val_4.y, z = val_17};
            this.EffectShow.三且世三丂七丐一丟();
            if(this.isPetStone == false)
            {
                    return;
            }
            
            val_15 = 1152921505286238208;
            val_18 = null;
            val_18 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            UnityEngine.Vector3 val_7 = transform.position;
            UnityEngine.Vector3 val_9 = this.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_14 = this.transform;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = val_11.y, z = 0f});
            val_16 = val_13.x;
            val_17 = val_13.z;
            val_14.rotation = new UnityEngine.Quaternion() {x = val_16, y = val_13.y, z = val_17, w = val_13.w};
        }
        internal void 丌七业一丞丈丅万三()
        {
            if(this.EffectHide == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this.七丈丁万丛万业丈与.position;
            this.EffectHide.gameObject.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this.EffectHide.三且世三丂七丐一丟();
        }
        private void 丟丞丝丝东丆七且且()
        {
            var val_2;
            var val_4;
            val_2 = null;
            val_2 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
            {
                    if(this._isMine == false)
            {
                goto label_4;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            label_14:
            this._owner = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            return;
            label_4:
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
            Player_move_c val_1 = 丘丛丞且一丅丁丏丐.丅丞万万三丛且专丁(丞丅上丏丂且下丅与:  this.photonView.ownerId);
            goto label_14;
        }
        protected bool 东丞业丘丅业丏三丏()
        {
            if(this._owner.mySkinName.firstPersonControl.世丟丈丏丕万丝丆万 != null)
            {
                    return this._owner.mySkinName.firstPersonControl.世丟丈丏丕万丝丆万.isGrounded;
            }
            
            return this._owner.mySkinName.firstPersonControl.世丟丈丏丕万丝丆万.isGrounded;
        }
        protected bool 上丗不丘上丘丕丟丞(UnityEngine.Vector3 丏丆丑丗七丄丙丝与, UnityEngine.Vector3 丒丈丙丐丏丕丆万丗, float 下丈丌三且三丝丄与)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丏丆丑丗七丄丙丝与.x, y = 丏丆丑丗七丄丙丝与.y, z = 丏丆丑丗七丄丙丝与.z}, b:  new UnityEngine.Vector3() {x = 丒丈丙丐丏丕丆万丗.x, y = 丒丈丙丐丏丕丆万丗.y, z = 丒丈丙丐丏丕丆万丗.z});
            return (bool)(val_1.x <= (下丈丌三且三丝丄与 * 下丈丌三且三丝丄与)) ? 1 : 0;
        }
        protected bool 七七业丒丟丝丘不丞(UnityEngine.GameObject 丞下万上三丘上与专, float 业丆丏丙不丑七上丙 = 200)
        {
            UnityEngine.Transform val_21;
            var val_22;
            var val_23;
            var val_27;
            if(this.丝且且丁上丝丒丞业 == false)
            {
                goto label_16;
            }
            
            if(丞下万上三丘上与专 == 0)
            {
                goto label_54;
            }
            
            UnityEngine.Vector3 val_3 = 丘丛丞且一丅丁丏丐.丗丏丆丁与丏万丙丆(丞下万上三丘上与专:  丞下万上三丘上与专.transform);
            val_21 = this._lookPoint;
            UnityEngine.Vector3 val_4 = val_21.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = this._lookPoint.position;
            string val_23 = "Pets";
            val_23 = (UnityEngine.LayerMask.NameToLayer(layerName:  val_23)) & 31;
            val_23 = 1 << val_23;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  业丆丏丙不丑七上丙, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业() & (~val_23))) == false)
            {
                goto label_54;
            }
            
            UnityEngine.GameObject val_12 = 0.transform.gameObject;
            if((val_12 & 1) != 0)
            {
                goto label_16;
            }
            
            val_21 = val_12.layer;
            if(val_21 != (UnityEngine.LayerMask.NameToLayer(layerName:  "MyPlayer")))
            {
                goto label_17;
            }
            
            label_16:
            val_23 = 1;
            return (bool)val_23;
            label_17:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_22 = 0;
            System.Collections.Generic.IEnumerator<T> val_17 = Unity.Linq.丅丆万丟丐丏丏下丄.东丕丟丏丐业丅东丐(丈丆上丅丘世专丑丕:  val_12).GetEnumerator();
            label_36:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_22 = 0;
            if(val_17.MoveNext() == false)
            {
                goto label_29;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_22 = 0;
            if((val_17.Current & 1) == 0)
            {
                goto label_36;
            }
            
            val_27 = 0;
            val_21 = 0;
            val_23 = 1;
            if(val_17 != null)
            {
                goto label_39;
            }
            
            goto label_44;
            label_29:
            val_27 = 0;
            val_21 = 0;
            val_23 = 0;
            if(val_17 != null)
            {
                goto label_39;
            }
            
            goto label_44;
            label_39:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_17.Dispose();
            label_44:
            if( == 1)
            {
                goto label_49;
            }
            
            if(207 == 211)
            {
                    return (bool)val_23;
            }
            
            val_23 = 0;
            if( == false)
            {
                    return (bool)val_23;
            }
            
            if(207 != 207)
            {
                goto label_52;
            }
            
            return (bool)val_23;
            label_49:
            if( == false)
            {
                goto label_54;
            }
            
            label_52:
            label_54:
            val_23 = 0;
            return (bool)val_23;
        }
        private float 丈丆丝丑丙丈丒丑丏()
        {
            if(this.专丆下丈丌一丝上一 >= 0)
            {
                    return val_1;
            }
            
            float val_1 = this._info.Attack;
            this.专丆下丈丌一丝上一 = val_1;
            return val_1;
        }
        protected void 丂上丘三万丛丗世且()
        {
            var val_17;
            UnityEngine.Transform val_18;
            var val_21;
            var val_22;
            var val_23;
            if(this._info.radiusDamage == false)
            {
                goto label_2;
            }
            
            val_17 = null;
            val_17 = null;
            System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
            val_18 = this.丘与丈丘丒丂丁丛丟;
            label_42:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            T val_6 = val_2.Current;
            if(((val_6 == 0) || (val_6 == mem[this.丘与丈丘丒丂丁丛丟])) || (val_6 == this.transform))
            {
                goto label_42;
            }
            
            val_21 = null;
            val_21 = null;
            if(val_6 == transform)
            {
                goto label_42;
            }
            
            UnityEngine.Vector3 val_13 = val_6.position;
            UnityEngine.Vector3 val_15 = this.transform.position;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            if(val_16.x > (this._info.AttackDistance * this._info.AttackDistance))
            {
                goto label_42;
            }
            
            this.丈不下丐丆丄丄丑丁(上业丒丕丒三万与丁:  val_6);
            goto label_42;
            label_2:
            val_18 = this.丘与丈丘丒丂丁丛丟;
            goto label_70;
            label_12:
            val_22 = 0;
            val_23 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                val_2.Dispose();
            }
            
            label_70:
            this.丈不下丐丆丄丄丑丁(上业丒丕丒三万与丁:  mem[this.丘与丈丘丒丂丁丛丟]);
        }
        protected void 丈不下丐丆丄丄丑丁(UnityEngine.Transform 上业丒丕丒三万与丁)
        {
            UnityEngine.Object val_29;
            Rilisoft.PetEngine val_30;
            string val_32;
            PetInfo val_33;
            Rilisoft.丏丏专丙世丝万丅且 val_34;
            float val_35;
            PetInfo val_36;
            PetInfo val_37;
            float val_38;
            var val_39;
            val_29 = 上业丒丕丒三万与丁;
            val_30 = this;
            .丝且与丝丒丟万丁专 = val_30;
            if(val_29 == 0)
            {
                    return;
            }
            
            丅丙上七上一丐不下 val_3 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_29);
            .丂丈丙且丈丗三丆丕 = val_3;
            if(val_3 == null)
            {
                    return;
            }
            
            .丗丞丛下丁东丐七专 = this.丈丆丝丑丙丈丒丑丏();
            if(this._info.poisonEnabled == false)
            {
                goto label_9;
            }
            
            val_32 = this._info.Id + "_up0";
            UnityEngine.Vector3 val_9 = this.transform.position;
            val_33 = this._info;
            if(val_33 == null)
            {
                goto label_14;
            }
            
            val_34 = this._info.poisonType;
            goto label_15;
            label_14:
            val_34 = this._info.poisonType;
            if(this._info == null)
            {
                goto label_16;
            }
            
            val_33 = this._info;
            label_15:
            label_83:
            label_84:
            val_35 = val_9.x;
            this._owner.丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_29.root.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_35, y = val_9.y, z = val_9.z}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
            label_9:
            if((this._info.petDisablerExplode == false) || ((PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丂丈丙且丈丗三丆丕 == null))
            {
                goto label_22;
            }
            
            val_36 = this._info;
            if(this._info != null)
            {
                goto label_23;
            }
            
            val_36 = this._info;
            if(val_36 == null)
            {
                goto label_31;
            }
            
            label_23:
            val_32 = this._info.Id;
            val_35 = this._info.disablerDuration;
            this._info.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  val_32, 三丛丄一东丑丁且业:  3, 丘万丟丕与专丁三丘:  val_35, 丆丅丅丂下丏丏丞丂:  0);
            label_22:
            if(this._info.slowdownTargets == false)
            {
                goto label_27;
            }
            
            val_32 = this._info;
            val_37 = val_32;
            if(val_32 != null)
            {
                goto label_30;
            }
            
            val_37 = this._info;
            if(val_37 == null)
            {
                goto label_31;
            }
            
            label_30:
            val_35 = this._info.slowdownTime;
            this._owner.与东丁业丁与且丌丕(丞下万上三丘上与专:  val_29.root.gameObject, 七丏上不丒万丐东丄:  val_35, 三上丅丈丄不丌万丙:  this._info.slowdownCoef);
            label_27:
            .丝七丏东专七与丌丒 = false;
            if(this._info.UsePartialDamage == true)
            {
                goto label_40;
            }
            
            if(this._info.criticalHitChance < 1)
            {
                goto label_36;
            }
            
            bool val_13 = (this._info.criticalHitChance >= (UnityEngine.Random.Range(min:  0, max:  100))) ? 1 : 0;
            .丝七丏东专七与丌丒 = val_13;
            if(val_13 != 0)
            {
                goto label_38;
            }
            
            goto label_40;
            label_36:
            if((PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丝七丏东专七与丌丒 == false)
            {
                goto label_40;
            }
            
            label_38:
            val_35 = (PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丗丞丛下丁东丐七专 * this._info.criticalHitCoef;
            .丗丞丛下丁东丐七专 = val_35;
            label_40:
            val_38 = (PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丗丞丛下丁东丐七专;
            if((this._owner.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  7)) != false)
            {
                    val_38 = val_38 + val_38;
                .丗丞丛下丁东丐七专 = val_38;
            }
            
            float val_15 = 丘丐丘万丌丟丞下丝.丄丗丒丅丏不丟万丅();
            val_15 = val_38 * val_15;
            .丗丞丛下丁东丐七专 = val_15;
            val_39 = null;
            val_39 = null;
            if(PlayerEffectContainer.丗上与丈丕丁且七世 == false)
            {
                goto label_48;
            }
            
            label_64:
            if((PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丂丈丙且丈丗三丆丕 == null)
            {
                goto label_58;
            }
            
            PlayerEffectContainer val_16 = 不丌丁丁与上丘丌丈();
            if((val_16.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  17)) == false)
            {
                goto label_58;
            }
            
            val_38 = (PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丗丞丛下丁东丐七专;
            float val_19 = val_16.不丌丁丁与上丘丌丈().丛万丟丕丗丒七不丄(丂丑丑与与丘丁与丙:  17);
            val_19 = val_38 * val_19;
            .丗丞丛下丁东丐七专 = val_19;
            goto label_58;
            label_48:
            if((PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丂丈丙且丈丗三丆丕 == null)
            {
                goto label_58;
            }
            
            if((IsSetEquipped(丂万丏专丒下丈丂丟:  1)) == false)
            {
                goto label_64;
            }
            
            float val_29 = (PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丗丞丛下丁东丐七专;
            val_29 = val_29 * 0.5f;
            .丗丞丛下丁东丐七专 = val_29;
            goto label_64;
            label_58:
            System.Action val_21 = null;
            val_29 = val_21;
            val_21 = new System.Action(object:  new PetEngine.一丟丌专丌丂丆不丂(), method:  System.Void PetEngine.一丟丌专丌丂丆不丂::丅丐丄世七丌上一丑());
            if(this._info.UsePartialDamage != false)
            {
                    if(this._info.DamagePartsCount >= 2)
            {
                goto label_68;
            }
            
            }
            
            val_21.Invoke();
            goto label_70;
            label_68:
            val_38 = (PetEngine.一丟丌专丌丂丆不丂)[1152921543338672576].丗丞丛下丁东丐七专;
            float val_30 = (float)this._info.DamagePartsCount;
            val_30 = val_38 / val_30;
            .丗丞丛下丁东丐七专 = val_30;
            if(this.世丟丘丘专丘下一丕 != null)
            {
                    this.世丟丘丘专丘下一丕.Cancel();
            }
            
            System.Threading.CancellationTokenSource val_22 = new System.Threading.CancellationTokenSource();
            this.世丟丘丘专丘下一丕 = val_22;
            System.Threading.CancellationToken val_23 = val_22.Token;
            var val_31 = 0;
            val_31 = val_31 + 1;
            UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  this.丘七一东丌三丑丂万(丘与丆下丆丛丈丘一:  val_21, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_23.m_source}).GetEnumerator());
            label_70:
            if(this.attackEffects == 0)
            {
                    return;
            }
            
            val_30 = this.attackEffects;
            val_30.丏丁一下丅世七丄丅();
            return;
            label_16:
            if(this._info != null)
            {
                goto label_83;
            }
            
            if(this._info != null)
            {
                goto label_84;
            }
            
            label_31:
        }
        protected System.Collections.IEnumerable 丘七一东丌三丑丂万(System.Action 丘与丆下丆丛丈丘一, System.Threading.CancellationToken 不丒三业下丑不丞业)
        {
            PetEngine.丞丛丈七不七丞专丝 val_1 = new PetEngine.丞丛丈七不七丞专丝(丗丏丅丕丆世丁专丟:  -2);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .且丕丈与丈丟丁丐且 = 丘与丆下丆丛丈丘一;
            }
            else
            {
                    mem[40] = this;
                mem[56] = 丘与丆下丆丛丈丘一;
            }
            
            .丙且丏业丕丞与丛丘 = 不丒三业下丑不丞业;
            return (System.Collections.IEnumerable)val_1;
        }
        protected void 三上世七七上丞不丛()
        {
            this.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this._info.explosionDelay, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void Rilisoft.PetEngine::丑丌下丏丑与丆东万()));
        }
        private void 丄丕业丌东专一丒丟()
        {
            var val_2 = null;
            if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
            {
                    this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  94, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
            }
            
            this.丆丕丒东丗丒丄万且();
        }
        private void 丆丕丒东丗丒丄万且()
        {
            UnityEngine.Object val_20;
            string val_21;
            float val_22;
            float val_23;
            RayAndExplosionsStackController val_24;
            var val_25;
            var val_26;
            System.Action<UnityEngine.Transform> val_28;
            var val_29;
            System.Action<UnityEngine.Transform> val_31;
            val_20 = this;
            if(this._info.petExplode != false)
            {
                    if((System.String.IsNullOrEmpty(value:  this._info.explosionPrefabName)) != false)
            {
                    val_21 = "Explosion1";
            }
            else
            {
                    val_21 = this._info.explosionPrefabName;
            }
            
                UnityEngine.Vector3 val_2 = this.七丈丁万丛万业丈与.position;
                val_22 = val_2.x;
                val_23 = val_2.z;
                val_24 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟;
                UnityEngine.GameObject val_4 = val_24.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  mem[this._info.explosionPrefabName]));
                if(val_4 != 0)
            {
                    val_4.transform.position = new UnityEngine.Vector3() {x = val_22, y = val_2.y, z = val_23};
            }
            
                val_25 = null;
                val_25 = null;
            }
            
            if(this._info.petDisablerExplode == false)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  this._info.explosionPrefabName)) == true)
            {
                    return;
            }
            
            val_24 = "OnGroundWeaponEffects/"("OnGroundWeaponEffects/") + this._info.explosionPrefabName + "_OnGroundEffect";
            UnityEngine.GameObject val_9 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  val_24);
            if(val_9 == 0)
            {
                    return;
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = PetEngine.<>c.<>9__201_0;
            if(val_28 == null)
            {
                    System.Action<UnityEngine.Transform> val_11 = null;
                val_28 = val_11;
                val_11 = new System.Action<UnityEngine.Transform>(object:  PetEngine.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PetEngine.<>c::丈丑与丈丂且丘东且(UnityEngine.Transform 丙丒七丄上与丏丙丙));
                PetEngine.<>c.<>9__201_0 = val_28;
            }
            
            Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  val_9, 丌专业且丛丏丞丝且:  val_11);
            val_24 = val_9.transform;
            val_24.parent = this.七丈丁万丛万业丈与;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            val_9.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(x:  90f, y:  0f, z:  0f);
            val_22 = val_16.x;
            val_23 = val_16.z;
            val_9.transform.localRotation = new UnityEngine.Quaternion() {x = val_22, y = val_16.y, z = val_23, w = val_16.w};
            val_29 = null;
            val_29 = null;
            val_31 = PetEngine.<>c.<>9__201_1;
            if(val_31 == null)
            {
                    System.Action<UnityEngine.Transform> val_17 = null;
                val_31 = val_17;
                val_17 = new System.Action<UnityEngine.Transform>(object:  PetEngine.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PetEngine.<>c::三丙下丐丈丏丘丟一(UnityEngine.Transform 丙丒七丄上与丏丙丙));
                PetEngine.<>c.<>9__201_1 = val_31;
            }
            
            Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  val_9, 丌专业且丛丏丞丝且:  val_17);
            val_20 = val_9.GetComponent<UnityEngine.ParticleSystem>();
            if(val_20 == 0)
            {
                    return;
            }
            
            val_20.Play();
        }
        protected virtual void WarpToOwner()
        {
            this.七丈丁万丛万业丈与.position = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
        }
        public virtual void HideModel()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.下七丏不丒丗业丛专(), 丏业丟一东丂东丘丛:  false);
            if(this.下七丏不丒丗业丛专().activeInHierarchy == false)
            {
                    return;
            }
            
            this.丗丑丝丕上丙世丆下();
            this.下七丏不丒丗业丛专().SetActive(value:  false);
        }
        public virtual void ShowModel()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.下七丏不丒丗业丛专(), 丏业丟一东丂东丘丛:  true);
        }
        internal bool 业丒上丟丆上丙一丒()
        {
            return (bool)this.<专丙丙东丛丌业七世>k__BackingField;
        }
        internal void 丞丑丏不七丞业东丕(bool 丙业与丙丗丝不丈东)
        {
            this.<专丙丙东丛丌业七世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 且丒不丕上丄丆上丐()
        {
            return (bool)this.不丏丈丆丏丐下上丒;
        }
        private void 丛丐丟丞丑丛与上上()
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            UnityEngine.Coroutine val_5 = CoroutineRunner.Instance.StartCoroutine(routine:  this.不丌且专丆业东专丝().GetEnumerator());
        }
        private System.Collections.IEnumerable 不丌且专丆业东专丝()
        {
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerable)new PetEngine.丛丏且世三丟丞丁且(丗丏丅丕丆世丁专丟:  -2);
        }
        internal void 丝世下丆业丘上丆上(float 丙不三七上丑丗丑丏, System.Action 丌专业且丛丏丞丝且)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.万丏七丞七不上三丝(丙不三七上丑丗丑丏:  丙不三七上丑丗丑丏, 丌专业且丛丏丞丝且:  丌专业且丛丏丞丝且).GetEnumerator());
        }
        private System.Collections.IEnumerable 万丏七丞七不上三丝(float 丙不三七上丑丗丑丏, System.Action 丌专业且丛丏丞丝且)
        {
            PetEngine.与专丙丙丟与丁下丛 val_1 = new PetEngine.与专丙丙丟与丁下丛(丗丏丅丕丆世丁专丟:  -2);
            if(val_1 != null)
            {
                    .七专丙丆丑丄丅世下 = 丙不三七上丑丗丑丏;
            }
            else
            {
                    mem[40] = 丙不三七上丑丗丑丏;
            }
            
            .下丌丘且丞丑世丏丙 = 丌专业且丛丏丞丝且;
            return (System.Collections.IEnumerable)val_1;
        }
        internal float 丅丝丐丗专丗丝不丈(float 丞丅丑世丑丅丘万三)
        {
            float val_2 = 丞丅丑世丑丅丘万三;
            val_2 = this.万丞丆丌世丝丞丆上() + val_2;
            this.一丑丞丂上丝丕上上(丝三业丛丘且不丝丆:  val_2);
            return val_2;
        }
        protected void 一丑丞丂上丝丕上上(float 丝三业丛丘且不丝丆)
        {
            var val_6;
            float val_4 = UnityEngine.Mathf.Clamp(value:  this.万丞丆丌世丝丞丆上() + 丝三业丛丘且不丝丆, min:  0f, max:  this._info.HP);
            if(val_4 == this.万丞丆丌世丝丞丆上())
            {
                    return;
            }
            
            this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  val_4);
            val_6 = null;
            val_6 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if(this._isMine == false)
            {
                    return;
            }
            
            this.专丆丐万上与丏丐丕();
        }
        protected void 专丆丐万上与丏丐丕()
        {
            PhotonView val_3;
            var val_4;
            val_3 = 1152921505171275776;
            val_4 = null;
            val_4 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
            val_3 = this.photonView;
            object[] val_1 = new object[1];
            val_1[0] = this.万丞丆丌世丝丞丆上();
            val_3.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
        }
        private void 丕七万三丝七丄东丕(float 丝三不七丑丏一业丑)
        {
            this.丗丕三下丈丅东丟上(丙业与丙丗丝不丈东:  丝三不七丑丏一业丑);
        }
        protected void 东与丂丏丐丞三丘丁(string 业万丈且丘丆丝丏丙)
        {
            var val_2;
            this.丝上世丒丗丞丐丘丕 = 业万丈且丘丆丝丏丙;
            val_2 = null;
            val_2 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = this.丝上世丒丗丞丐丘丕;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  121, 丞下万上三丘上与专:  4, 丗丟上上丒丐丗丞丙:  val_1);
        }
        private void 世下下万丏一丂丂丗(string 业万丈且丘丆丝丏丙)
        {
            this.丝上世丒丗丞丐丘丕 = 业万丈且丘丆丝丏丙;
        }
        protected void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
        {
            if(this._isMine == false)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = this.万丞丆丌世丝丞丆上();
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_1);
        }
        internal UnityEngine.AudioSource 丕专一一三七丕丏丅()
        {
            if(this.丝丆下丒丗丅丗不七 != null)
            {
                    return val_2;
            }
            
            UnityEngine.AudioSource val_2 = 丞东丑专丛丆丄丝世.丙业业丈丌下丗专与<UnityEngine.AudioSource>(丝三丁东丈丒世丅业:  this.gameObject, 丒丘丏上丙丟丑丕丈:  "Source1", 丟丝七七一丁丏丏丙:  true);
            this.丝丆下丒丗丅丗不七 = val_2;
            return val_2;
        }
        internal UnityEngine.AudioSource 丁丂不上丗且丗丟丘()
        {
            if(this.丈与万不丙丐丙丏七 != null)
            {
                    return val_2;
            }
            
            UnityEngine.AudioSource val_2 = 丞东丑专丛丆丄丝世.丙业业丈丌下丗专与<UnityEngine.AudioSource>(丝三丁东丈丒世丅业:  this.gameObject, 丒丘丏上丙丟丑丕丈:  "Source2", 丟丝七七一丁丏丏丙:  true);
            this.丈与万不丙丐丙丏七 = val_2;
            return val_2;
        }
        internal void 丛不上丛一丆丛丅下(UnityEngine.AudioClip 丏世一不与丗丏三不)
        {
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            bool val_16;
            val_14 = 丏世一不与丗丏三不;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            if(val_14 != this.ClipAttack)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.ClipReceiveDamage)) == false)
            {
                goto label_9;
            }
            
            }
            
            UnityEngine.AudioSource val_4 = this.丁丂不上丗且丗丟丘();
            goto label_10;
            label_9:
            label_10:
            val_13 = this.丕专一一三七丕丏丅();
            if(val_13 == 0)
            {
                    return;
            }
            
            bool val_7 = UnityEngine.Object.op_Equality(x:  val_14, y:  0);
            if(val_13 == null)
            {
                goto label_16;
            }
            
            if(val_7 == false)
            {
                goto label_17;
            }
            
            label_19:
            val_16 = 0;
            goto label_18;
            label_16:
            if(val_7 == true)
            {
                goto label_19;
            }
            
            label_17:
            bool val_9 = UnityEngine.Object.op_Equality(x:  val_14, y:  val_13.clip);
            if(val_13 == null)
            {
                goto label_22;
            }
            
            if(val_9 == false)
            {
                goto label_23;
            }
            
            label_29:
            if(val_13.isPlaying != false)
            {
                    if(val_14 != this.ClipAttack)
            {
                    return;
            }
            
            }
            
            val_13.Play();
            return;
            label_22:
            if(val_9 == true)
            {
                goto label_29;
            }
            
            label_23:
            val_13.clip = val_14;
            val_13.Play();
            val_14 = UnityEngine.Object.op_Equality(x:  val_14, y:  this.ClipWalk);
            val_16 = val_14;
            label_18:
            val_13.loop = val_16;
        }
        private void 丑丌下丏丑与丆东万()
        {
            PetInfo val_35;
            float val_36;
            var val_37;
            var val_38;
            var val_41;
            var val_43;
            System.Collections.Generic.List<Player_move_c> val_44;
            PetInfo val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            PetInfo val_52;
            var val_53;
            if(this._info.petExplode == false)
            {
                goto label_68;
            }
            
            val_35 = this._info;
            if(val_35 == null)
            {
                goto label_3;
            }
            
            val_36 = this._info.explosionRadius;
            goto label_4;
            label_3:
            val_36 = this._info.explosionRadius;
            if(this._info == null)
            {
                goto label_5;
            }
            
            val_35 = this._info;
            label_4:
            float val_2 = val_36 * this._info.explosionRadius;
            label_42:
            bool val_3 = this._owner.丌丝世不丄丌丌不七(丏不丂丆且三丞丆丏:  7);
            float val_4 = 丘丐丘万丌丟丞下丝.丄丗丒丅丏不丟万丅();
            System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_5 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  this._owner, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
            val_37 = 1152921504691191808;
            val_38 = 1152921505189965824;
            label_40:
            var val_37 = 0;
            val_37 = val_37 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            T val_9 = val_5.Current;
            UnityEngine.Vector3 val_10 = val_9.position;
            UnityEngine.Vector3 val_11 = this.七丈丁万丛万业丈与.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            if(val_12.x >= 0)
            {
                goto label_40;
            }
            
            丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_9);
            if(val_13 == null)
            {
                goto label_40;
            }
            
            UnityEngine.Vector3 val_17 = this.transform.position;
            val_41 = null;
            val_41 = null;
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_13.ApplyDamage(丞丈专下丈专业三丞:  this.丈丆丝丑丙丈丒丑丏(), 丛世一丟丞丁业丘丒:  this, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, 丐丟丘世丁三丕专专:  15, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  this._info.Id + "_up0", 丒丈丐丐丗丐专丈丏:  GetComponent<PixelView>().viewID);
            goto label_40;
            label_5:
            float val_21 = val_36 * this._info.explosionRadius;
            if(this._info != null)
            {
                goto label_42;
            }
            
            goto label_42;
            label_15:
            val_43 = 0;
            val_44 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                val_5.Dispose();
            }
            
            label_68:
            if(this._info.petDisablerExplode == false)
            {
                goto label_70;
            }
            
            if(GameConnect.丙丘不世专且万丄丐() == true)
            {
                    return;
            }
            
            val_46 = this._info;
            if(this._info != null)
            {
                goto label_74;
            }
            
            val_46 = this._info;
            if(val_46 == null)
            {
                goto label_104;
            }
            
            label_74:
            val_37 = 1152921525487174064;
            val_38 = 1152921504838316032;
            val_47 = 0;
            float val_24 = this._info.explosionRadius * this._info.explosionRadius;
            goto label_76;
            label_109:
            val_48 = null;
            val_48 = null;
            if((丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].Equals(other:  this._owner)) == true)
            {
                goto label_99;
            }
            
            if(GameConnect.丆丁上丟丛业丄丅丝() == false)
            {
                goto label_84;
            }
            
            val_49 = null;
            val_49 = null;
            if(this._owner.丘丑丅三丆丑丌且丝() == 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丘丑丅三丆丑丌且丝())
            {
                goto label_99;
            }
            
            label_84:
            val_50 = null;
            val_50 = null;
            Player_move_c val_31 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0];
            UnityEngine.Vector3 val_32 = val_31.myPlayerTransform.position;
            val_36 = val_32.x;
            UnityEngine.Vector3 val_33 = this.七丈丁万丛万业丈与.position;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_36, y = val_32.y, z = val_32.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            if(val_34.x >= 0)
            {
                goto label_99;
            }
            
            val_51 = null;
            val_51 = null;
            val_52 = this._info;
            if(this._info != null)
            {
                goto label_103;
            }
            
            val_52 = this._info;
            if(val_52 == null)
            {
                goto label_104;
            }
            
            label_103:
            val_36 = this._info.disablerDuration;
            丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  this._info.Id, 三丛丄一东丑丁且业:  3, 丘万丟丕与专丁三丘:  val_36, 丆丅丅丂下丏丏丞丂:  0);
            label_99:
            val_47 = 1;
            label_76:
            val_53 = null;
            val_53 = null;
            val_44 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
            if(val_47 < val_44.Count)
            {
                goto label_109;
            }
            
            label_70:
            this.丄丕业丌东专一丒丟();
            return;
            label_104:
            X10Manager.<>c..cctor();
        }
    
    }

}
