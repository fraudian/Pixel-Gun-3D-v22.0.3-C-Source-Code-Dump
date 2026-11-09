using UnityEngine;

namespace Rilisoft
{
    internal class GroundPetEngine : PetEngine
    {
        // Fields
        private UnityEngine.AI.NavMeshAgent Nma;
        public UnityEngine.AI.NavMeshPath Path;
        
        // Properties
        internal override UnityEngine.Vector3 MovePosition { get; }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> MoveToOwnerState { get; }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> MoveToTargetState { get; }
        internal override bool CanMoveToPlayer { get; }
        private bool CanTeleportToTarget { get; }
        
        // Methods
        internal override UnityEngine.Vector3 get_MovePosition()
        {
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this.万东丂七东丁与业东().丛丕丂上不一世丏万(), y:  0);
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
            if(val_4.丛丕丂上不一世丏万() != null)
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
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> get_MoveToOwnerState()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new GroundPetEngine.PetMoveToOwnerState(context:  this);
        }
        protected override Rilisoft.StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业> get_MoveToTargetState()
        {
            return (StateMachine.丘丄下丗丐七一丝业<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>)new GroundPetEngine.PetMoveToTargetState(context:  this);
        }
        internal override bool get_CanMoveToPlayer()
        {
            var val_21;
            float val_22;
            float val_23;
            float val_24;
            var val_25;
            float val_26;
            var val_27;
            val_21 = this;
            if(this.Path == null)
            {
                    UnityEngine.AI.NavMeshPath val_1 = new UnityEngine.AI.NavMeshPath();
                this.Path = val_1;
            }
            
            UnityEngine.Vector3 val_2 = val_1.position;
            val_22 = val_2.x;
            val_23 = val_2.z;
            Player_move_c val_3 = this.万东丂七东丁与业东();
            UnityEngine.Vector3 val_4 = val_3.myPlayerTransform.position;
            val_24 = val_4.y;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_22, y = val_2.y, z = val_23}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_24, z = val_4.z})) == true)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_6 = val_3.myPlayerTransform.position;
            val_22 = val_6.x;
            val_23 = val_6.z;
            Player_move_c val_7 = this.万东丂七东丁与业东();
            UnityEngine.Vector3 val_8 = val_7.myPlayerTransform.position;
            bool val_9 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_22, y = val_6.y, z = val_23}, targetPosition:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, areaMask:  0, path:  this.Path);
            UnityEngine.Vector3[] val_10 = this.Path.corners;
            if(val_10.Length < 1)
            {
                goto label_13;
            }
            
            val_25 = 0;
            val_26 = 0f;
            goto label_14;
            label_25:
            UnityEngine.Vector3[] val_11 = this.Path.corners;
            val_23 = 8.96831E-44f;
            val_22 = 4.656534E-34f;
            var val_14 = (W24 - 1) + 1;
            var val_15 = this.Path.corners + ((long)(long)(int)(W24) * 12);
            val_24 = mem[((long)(int)(W24) * 12) + val_13 + 40];
            val_24 = ((long)(int)(W24) * 12) + val_13 + 40;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_23, y = 0f, z = val_22}, b:  new UnityEngine.Vector3() {x = ((long)(int)(W24) * 12) + val_13 + 32, y = ((long)(int)(W24) * 12) + val_13 + 32 + 4, z = val_24});
            val_26 = val_26 + (UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}));
            val_25 = 1;
            label_14:
            UnityEngine.Vector3[] val_19 = this.Path.corners;
            if((val_25 + 1) < val_19.Length)
            {
                goto label_25;
            }
            
            val_21 = this.丙丕丞且丕不丘丙丑();
            float val_22 = val_20.MaxToOwnerDistance;
            val_22 = val_22 + val_22;
            var val_21 = (val_26 <= val_22) ? 1 : 0;
            return (bool)val_27;
            label_13:
            val_27 = 0;
            return (bool)val_27;
        }
        private bool get_CanTeleportToTarget()
        {
            UnityEngine.GameObject val_26;
            var val_27;
            float val_28;
            float val_29;
            float val_30;
            var val_31;
            val_26 = 1152921504848912384;
            if(137125888 == 0)
            {
                    return false;
            }
            
            val_27 = null;
            val_27 = null;
            bool val_26 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
            val_26 = val_26 + 7;
            var val_27 = ~val_26;
            val_27 = val_27 & 7;
            if(val_27 != 0)
            {
                    return false;
            }
            
            UnityEngine.Vector3 val_2 = position;
            val_28 = val_2.x;
            val_29 = val_2.z;
            UnityEngine.Vector3 val_3 = position;
            val_30 = val_3.y;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_28, y = val_2.y, z = val_29}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_30, z = val_3.z})) == true)
            {
                    return false;
            }
            
            UnityEngine.Vector3 val_5 = position;
            val_29 = val_5.z;
            UnityEngine.Vector3 val_6 = position;
            val_30 = val_6.y;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_29}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_30, z = val_6.z});
            val_28 = val_7.x;
            if(val_28 > val_8.ToTargetTeleportDistance)
            {
                    return false;
            }
            
            if(this.丙丕丞且丕不丘丙丑().root != 0)
            {
                    val_31 = null;
                val_31 = null;
                val_26 = root.gameObject;
                if((丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Contains(item:  val_26)) != false)
            {
                    return false;
            }
            
            }
            
            if(this.Path == null)
            {
                    UnityEngine.AI.NavMeshPath val_14 = new UnityEngine.AI.NavMeshPath();
                this.Path = val_14;
            }
            
            UnityEngine.Vector3 val_15 = val_14.position;
            UnityEngine.Vector3 val_16 = val_14.position;
            bool val_17 = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, targetPosition:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, areaMask:  0, path:  this.Path);
            UnityEngine.Vector3[] val_18 = this.Path.corners;
            if(val_18.Length < 1)
            {
                    return false;
            }
            
            int val_28 = val_20.Length;
            val_28 = val_28 - 1;
            var val_29 = 12;
            val_29 = this.Path.corners + ((long)val_28 * val_29);
            UnityEngine.Vector3 val_22 = this.Path.corners.transform.position;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((val_20.Length - 1)) * 12) + val_19 + 32, y = ((long)(int)((val_20.Length - 1)) * 12) + val_19 + 32 + 4, z = ((long)(int)((val_20.Length - 1)) * 12) + val_19 + 40}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            PetInfo val_24 = this.丙丕丞且丕不丘丙丑();
            var val_25 = (val_23.x > val_24.AttackDistance) ? 1 : 0;
            return false;
        }
        protected override void WarpToOwner()
        {
            bool val_1 = this.Nma.Warp(newPosition:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        }
        protected override void Awake()
        {
            this.Awake();
            this.Nma = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
            if((this.gameObject.GetComponent<AgentLinkMover>()) != 0)
            {
                    return;
            }
            
            AgentLinkMover val_6 = this.gameObject.AddComponent<AgentLinkMover>();
        }
        public override void StopEngine()
        {
            this.StopEngine();
            this.Nma.enabled = false;
        }
        public GroundPetEngine()
        {
        
        }
    
    }

}
