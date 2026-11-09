using UnityEngine;

namespace Rilisoft
{
    internal class FlyingPetEngine : PetEngine
    {
        // Fields
        private const float _unwaikableTeleportTime = 1;
        private UnityEngine.Coroutine _checkIsMoving;
        private Rilisoft.TargetPositionMonitor _posMonVal;
        private float _unwaikableElapsedTime;
        protected UnityEngine.Collider CollisionCollider;
        protected bool IgnoreWalls;
        
        // Properties
        internal override UnityEngine.Vector3 MovePosition { get; }
        protected override System.Nullable<UnityEngine.Vector3> MoveToTargetPosition { get; }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> MoveToOwnerState { get; }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> MoveToTargetState { get; }
        private Rilisoft.TargetPositionMonitor TargetPosMon { get; }
        
        // Methods
        internal override UnityEngine.Vector3 get_MovePosition()
        {
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this.万东丂七东丁与业东().专三丟丂丅万上一丛(), y:  0);
            Player_move_c val_4 = this.万东丂七东丁与业东();
            if(val_4 == null)
            {
                goto label_4;
            }
            
            if(val_3 == false)
            {
                goto label_5;
            }
            
            label_7:
            if(val_4.专三丟丂丅万上一丛() != null)
            {
                    return 0.position;
            }
            
            return 0.position;
            label_4:
            if(val_3 == true)
            {
                goto label_7;
            }
            
            label_5:
            if(val_4.transform != null)
            {
                    return 0.position;
            }
            
            return 0.position;
        }
        protected override System.Nullable<UnityEngine.Vector3> get_MoveToTargetPosition()
        {
            var val_6;
            UnityEngine.Object val_7;
            val_6 = this;
            val_7 = 0;
            if(static_value_082C4000 == val_7)
            {
                    return 0;
            }
            
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.Vector3 val_4 = this.position;
            float val_5 = val_3.y + 1.5f;
            val_7 = public System.Void System.Nullable<UnityEngine.Vector3>::.ctor(UnityEngine.Vector3 value);
            return 0;
        }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> get_MoveToOwnerState()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new FlyingPetEngine.PetMoveToOwnerState(context:  this);
        }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> get_MoveToTargetState()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new FlyingPetEngine.PetMoveToTargetState(context:  this);
        }
        private Rilisoft.TargetPositionMonitor get_TargetPosMon()
        {
            Rilisoft.TargetPositionMonitor val_5;
            if(this._posMonVal == 0)
            {
                    this._posMonVal = this.gameObject.AddComponent<Rilisoft.TargetPositionMonitor>();
                return val_5;
            }
            
            val_5 = this._posMonVal;
            return val_5;
        }
        public override void StopEngine()
        {
            this.StopEngine();
            this.CollisionCollider.gameObject.SetActive(value:  false);
        }
        protected override void InitSM()
        {
            this.InitSM();
            this.CollisionCollider.gameObject.SetActive(value:  this.丘丒丝七丁下丂与丁());
        }
        protected override void Update()
        {
            bool val_3 = this.IgnoreWalls;
            val_3 = val_3 ^ 1;
            mem[1152921543317539696] = val_3;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CollisionCollider.gameObject, 丏业丟一东丂东丘丛:  (this.IgnoreWalls == false) ? 1 : 0);
            this.Update();
        }
        protected void Move()
        {
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_45;
            Rilisoft.TargetPositionMonitor val_1 = this.TargetPosMon;
            UnityEngine.Vector3 val_2 = val_1.GetCurrentPoint();
            val_39 = val_2.x;
            val_40 = val_2.y;
            val_41 = val_2.z;
            UnityEngine.Vector3 val_3 = val_1.position;
            val_42 = val_3.y;
            val_43 = val_3.z;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_42, z = val_43}, b:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41})) < 0)
            {
                    if(this.TargetPosMon.HasNextPoint() != false)
            {
                    UnityEngine.Vector3 val_8 = this.TargetPosMon.GetNextPoint();
            }
            else
            {
                    UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            }
            
                val_39 = val_9.x;
                val_40 = val_9.y;
                val_41 = val_9.z;
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, rhs:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z})) == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_12 = this.transform;
            UnityEngine.Vector3 val_13 = val_12.position;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, upwards:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            val_41 = val_16.w;
            UnityEngine.Quaternion val_18 = this.transform.rotation;
            float val_19 = UnityEngine.Time.deltaTime;
            val_19 = val_19 * 10f;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w}, b:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_41}, t:  val_19);
            val_12.rotation = new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w};
            UnityEngine.Vector3 val_21 = val_12.position;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            float val_23 = 丘丐丘万丌丟丞下丝.丙东不丗丗丟万丂一();
            if(this.CurrentState.丁丟丏一丕业丞丏丂() == 3)
            {
                    float val_27 = this.丙丕丞且丕不丘丙丑().SpeedModif;
                float val_39 = val_27;
                val_39 = val_23 * val_39;
                float val_29 = this.丙丕丞且丕不丘丙丑().SpeedModif;
                val_41 = val_29;
                val_29 = val_27 * val_41;
                val_29 = val_23 * val_29;
                val_45 = UnityEngine.Mathf.Clamp(value:  val_29, min:  0f, max:  val_39);
            }
            else
            {
                    float val_32 = this.丙丕丞且丕不丘丙丑().SpeedModif;
                val_32 = val_23 * val_32;
                val_45 = val_23 * val_32;
            }
            
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  val_45 * 0.015f);
            UnityEngine.Transform val_36 = this.gameObject.transform;
            UnityEngine.Vector3 val_37 = val_36.position;
            val_42 = val_37.y;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_42, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
            val_43 = val_38.x;
            val_40 = val_38.z;
            val_36.position = new UnityEngine.Vector3() {x = val_43, y = val_38.y, z = val_40};
            this.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  0);
        }
        private System.Collections.IEnumerator CheckIsMoving()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new FlyingPetEngine.<CheckIsMoving>d__20();
        }
        private void CheckIsMovingStart()
        {
            if(this._checkIsMoving != null)
            {
                    this.StopCoroutine(routine:  this._checkIsMoving);
                this._checkIsMoving = 0;
            }
            
            this._checkIsMoving = this.StartCoroutine(routine:  this.CheckIsMoving());
        }
        private void CheckIsMovingStop()
        {
            if(this._checkIsMoving == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this._checkIsMoving);
            this._checkIsMoving = 0;
        }
        public override void SetCollidersEnabled(bool enabled)
        {
            enabled = enabled;
            this.SetCollidersEnabled(丝三丄专丗丞丄丄丌:  enabled);
            if(this.CollisionCollider.enabled ^ enabled == false)
            {
                    return;
            }
            
            this.CollisionCollider.enabled = enabled;
        }
        public FlyingPetEngine()
        {
        
        }
    
    }

}
