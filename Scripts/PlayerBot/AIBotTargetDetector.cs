using UnityEngine;

namespace PlayerBot
{
    internal class AIBotTargetDetector : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform eyeTransform;
        private PlayerBot.AIBotController controller;
        private PlayerBot.且丏丕丝丄上业上丒 与丝丁丑丁丌丞丞东;
        internal bool 一不业丌丘上丌丘业;
        private System.Collections.Generic.List<UnityEngine.Vector3> 丑丞丄三东三且世丟;
        private UnityEngine.Vector3 丂七上七万丈丁丅丅;
        private float 丕丘业七丌与丅丞三;
        private bool 三与丄三丑丌丄丑与;
        public float timeBetweenTargetChecksIfEngaging;
        public float timeBetweenTargetChecksIfNotEngaging;
        public float timeBetweenLOSChecks;
        public float effectiveFov;
        public float maxDistToNoticeTarget;
        public float forwardDistToTarget;
        public float sideDistToTarget;
        public float aroundDistToTarget;
        public float forwardFov;
        public float sideFov;
        public float aroundFov;
        public float distanceToLoseAwarness;
        
        // Properties
        internal PlayerBot.且丏丕丝丄上业上丒 万丙与一上世丞丂丆 { get; }
        internal PlayerBot.且丏丕丝丄上业上丒 上丝丁东下万七且与 { get; set; }
        private UnityEngine.Vector3 且丝丗不丆丕丘丌丛 { get; set; }
        
        // Methods
        internal PlayerBot.且丏丕丝丄上业上丒 丈与丅世世丌世丗丒()
        {
            if(this.controller.playerBotController.player != null)
            {
                    return (PlayerBot.且丏丕丝丄上业上丒)this.controller.playerBotController.player.丕丁丘丆万丄世专丛;
            }
            
            return (PlayerBot.且丏丕丝丄上业上丒)this.controller.playerBotController.player.丕丁丘丆万丄世专丛;
        }
        internal PlayerBot.且丏丕丝丄上业上丒 三丌世丒三下丆丐下()
        {
            return (PlayerBot.且丏丕丝丄上业上丒)this.与丝丁丑丁丌丞丞东;
        }
        internal void 三丈丅七丕丂丟七丄(PlayerBot.且丏丕丝丄上业上丒 丙业与丙丗丝不丈东)
        {
            var val_5 = 0;
            if((丙业与丙丗丝不丈东 == null) && ( != 0))
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                if(this.与丝丁丑丁丌丞丞东.BotTargetIsDead != false)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                this.丂七上七万丈丁丅丅 = val_5;
                mem[1152921540790874532] = val_5.y;
                mem[1152921540790874536] = val_5.z;
            }
            
            }
            
            this.与丝丁丑丁丌丞丞东 = 丙业与丙丗丝不丈东;
        }
        private UnityEngine.Vector3 业东丆丝上世丅下丗()
        {
            var val_8 = 0;
            if( == 0)
            {
                    return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_9.y, z = val_9.z};
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(this.与丝丁丑丁丌丞丞东.BotTargetIsDead == false)
            {
                    return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_9.y, z = val_9.z};
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            UnityEngine.Vector3 val_7 = this.与丝丁丑丁丌丞丞东.BotTargetTransform.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = V11.16B, z = V10.16B})) >= 0)
            {
                    return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_9.y, z = val_9.z};
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.丂七上七万丈丁丅丅 = val_9;
            mem[1152921540791011156] = val_9.y;
            mem[1152921540791011160] = val_9.z;
            return new UnityEngine.Vector3() {x = this.丂七上七万丈丁丅丅, y = val_9.y, z = val_9.z};
        }
        private void 万一丗万且不丏丁万(UnityEngine.Vector3 丙业与丙丗丝不丈东)
        {
            this.丂七上七万丈丁丅丅 = 丙业与丙丗丝不丈东;
            mem[1152921540791139572] = 丙业与丙丗丝不丈东.y;
            mem[1152921540791139576] = 丙业与丙丗丝不丈东.z;
        }
        private void Awake()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丕丗万丟丅东丅丄丑());
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丈上业丐丂专上业丂());
        }
        internal bool 与丛且丟丌丂丅万三()
        {
            UnityEngine.Vector3 val_1 = this.业东丆丝上世丅下丗();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            return UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        internal UnityEngine.Vector3 丟下丄不业业丅上丏()
        {
            return this.业东丆丝上世丅下丗();
        }
        internal void 丏世丕丗丄丛丈丆专()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.丂七上七万丈丁丅丅 = val_1;
            mem[1152921540791620340] = val_1.y;
            mem[1152921540791620344] = val_1.z;
        }
        private UnityEngine.Ray 三业业世与万丑下东(UnityEngine.Vector3 丙丌丛丘丗与一专丁)
        {
            UnityEngine.Ray val_0;
            UnityEngine.Vector3 val_1 = this.eyeTransform.position;
            UnityEngine.Vector3 val_2 = this.eyeTransform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丙丌丛丘丗与一专丁.x, y = 丙丌丛丘丗与一专丁.y, z = 丙丌丛丘丗与一专丁.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_0.m_Origin.z = 0f;
            val_0.m_Direction.x = 0f;
            val_0.m_Direction.y = 0f;
            val_0.m_Direction.z = 0f;
            val_0.m_Origin.x = 0f;
            val_0.m_Origin.y = 0f;
            return val_0;
        }
        private System.Collections.IEnumerator 丈上业丐丂专上业丂()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AIBotTargetDetector.专丛丟丐丘丒丒丕丝();
        }
        private System.Collections.IEnumerator 丕丗万丟丅东丅丄丑()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AIBotTargetDetector.丁丛丑丒丕不丟七丑();
        }
        internal void 丏丒专丟业上下丁万(bool 丅东丐七七世丛七丟)
        {
            var val_53;
            System.Collections.Generic.List<System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single>> val_54;
            var val_57;
            var val_58;
            var val_60;
            var val_62;
            var val_63;
            Player_move_c val_64;
            var val_65;
            var val_67;
            var val_69;
            var val_71;
            var val_75;
            var val_76;
            var val_78;
            var val_79;
            System.Collections.Generic.List<T> val_80;
            var val_81;
            System.Collections.Generic.List<PlayerBot.且丏丕丝丄上业上丒> val_82;
            System.Collections.Generic.List<T> val_83;
            val_53 = 0;
            if( == 0)
            {
                goto label_18;
            }
            
            val_54 = 1152921505345130496;
            var val_64 = 0;
            val_64 = val_64 + 1;
            if(this.与丝丁丑丁丌丞丞东.BotTargetIsDead == false)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.丂七上七万丈丁丅丅 = val_5;
            mem[1152921540792226020] = val_5.y;
            mem[1152921540792226024] = val_5.z;
            goto label_18;
            label_14:
            if((this.丑丙且下丏丙东且丏(丞下万上三丘上与专:  this.与丝丁丑丁丌丞丞东)) == false)
            {
                goto label_18;
            }
            
            var val_65 = 0;
            val_65 = val_65 + 1;
            goto label_23;
            label_18:
            this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  0);
            System.Collections.Generic.List<System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single>> val_7 = new System.Collections.Generic.List<System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single>>();
            System.Collections.Generic.List<System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single>> val_8 = null;
            val_54 = val_8;
            val_8 = new System.Collections.Generic.List<System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single>>();
            val_57 = 0;
            goto label_138;
            label_147:
            val_58 = null;
            val_58 = null;
            var val_66 = 0;
            val_66 = val_66 + 1;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetMeaning == 0)
            {
                goto label_33;
            }
            
            val_60 = null;
            val_60 = null;
            var val_67 = 0;
            val_67 = val_67 + 1;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetMeaning != 1)
            {
                goto label_42;
            }
            
            label_33:
            val_62 = null;
            val_62 = null;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0] == this.丈与丅世世丌世丗丒())
            {
                goto label_133;
            }
            
            val_63 = null;
            val_63 = null;
            PlayerBot.且丏丕丝丄上业上丒 val_17 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0];
            if(val_17 != null)
            {
                    if(null == null)
            {
                goto label_51;
            }
            
            }
            
            label_51:
            var val_18 = (null == null) ? (val_17) : 0;
            PlayerBot.且丏丕丝丄上业上丒 val_19 = this.丈与丅世世丌世丗丒();
            if((typeof(PlayerBot.且丏丕丝丄上业上丒) == null ? val_17 : 0 + 1536) == 0)
            {
                goto label_52;
            }
            
            if(val_19 == null)
            {
                goto label_53;
            }
            
            label_55:
            var val_20 = (null == null) ? (val_19) : 0;
            goto label_54;
            label_52:
            if(val_19 != null)
            {
                goto label_55;
            }
            
            label_53:
            val_64 = 0;
            label_54:
            if((typeof(PlayerBot.且丏丕丝丄上业上丒) == null ? val_17 : 0 + 1536.IsEnemyTo(专丞上七七且丝七丗:  val_64)) == false)
            {
                goto label_133;
            }
            
            val_65 = null;
            val_65 = null;
            var val_68 = 0;
            val_68 = val_68 + 1;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetIsDead == true)
            {
                goto label_133;
            }
            
            label_42:
            val_67 = null;
            val_67 = null;
            var val_69 = 0;
            val_69 = val_69 + 1;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetMeaning != 2)
            {
                goto label_74;
            }
            
            val_69 = null;
            val_69 = null;
            var val_70 = 0;
            val_70 = val_70 + 1;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetIsDead == true)
            {
                goto label_133;
            }
            
            label_74:
            val_71 = null;
            val_71 = null;
            var val_71 = 0;
            val_71 = val_71 + 1;
            UnityEngine.Vector3 val_34 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetTransform.position;
            var val_72 = 0;
            val_72 = val_72 + 1;
            UnityEngine.Vector3 val_38 = this.丈与丅世世丌世丗丒().BotTargetTransform.position;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            UnityEngine.Vector3 val_40 = this.eyeTransform.forward;
            var val_73 = 0;
            val_73 = val_73 + 1;
            UnityEngine.Vector3 val_44 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetTransform.position;
            UnityEngine.Vector3 val_45 = this.eyeTransform.position;
            UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
            float val_47 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, to:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z});
            if(val_39.x < 0)
            {
                    if(val_47 < 0)
            {
                goto label_113;
            }
            
            }
            
            if(val_39.x < 0)
            {
                    if(val_47 < 0)
            {
                goto label_113;
            }
            
            }
            
            if((val_39.x >= 0) || (val_47 >= 0))
            {
                goto label_133;
            }
            
            label_113:
            val_75 = null;
            val_75 = null;
            if((this.丑丙且下丏丙东且丏(丞下万上三丘上与专:  丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0])) == false)
            {
                goto label_133;
            }
            
            val_76 = null;
            val_76 = null;
            var val_74 = 0;
            val_74 = val_74 + 1;
            if(丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0].BotTargetMeaning == 0)
            {
                goto label_128;
            }
            
            val_78 = null;
            val_78 = null;
            PlayerBot.且丏丕丝丄上业上丒 val_53 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0];
            val_8.Add(item:  new System.ValueTuple<System.Object, System.Single>() {Item2 = val_39.x});
            goto label_133;
            label_128:
            PlayerBotsManager val_54 = PlayerBotsManager.与一丅丝不丈业与丙();
            if(val_54.ignorePlayer == false)
            {
                goto label_137;
            }
            
            label_133:
            val_57 = 1;
            goto label_138;
            label_137:
            val_79 = null;
            val_79 = null;
            PlayerBot.且丏丕丝丄上业上丒 val_55 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Item[0];
            val_80 = val_7;
            if(val_80 == 0)
            {
                    val_80 = val_7;
            }
            
            val_7.Add(item:  new System.ValueTuple<System.Object, System.Single>() {Item2 = val_39.x});
            goto label_133;
            label_138:
            val_81 = null;
            val_81 = null;
            val_82 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与;
            if(val_57 < val_82.Count)
            {
                goto label_147;
            }
            
            if((1 & 1) == 0)
            {
                goto label_148;
            }
            
            if((1 & 1) == 0)
            {
                goto label_159;
            }
            
            if((GameConnect.七丂万专且丏丘一丙() == true) || (val_8.Count == 0))
            {
                goto label_154;
            }
            
            val_82 = this.controller.万三丁丌丐与丙专三;
            if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().七丘丌三丙丝丂丆三(丑万世丂专丈丌业且:  val_82)) == false)
            {
                goto label_159;
            }
            
            label_154:
            val_83 = val_7;
            goto label_160;
            label_148:
            this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  0);
            return;
            label_159:
            val_83 = val_54;
            label_160:
            this.丅上丐丆上丏东业丂(丁丘丈万与不且东业:  val_8);
            return;
            label_23:
            UnityEngine.Vector3 val_63 = this.与丝丁丑丁丌丞丞东.BotTargetTransform.position;
            this.丂七上七万丈丁丅丅 = val_63;
            mem[1152921540792226020] = val_63.y;
            mem[1152921540792226024] = val_63.z;
        }
        private void 丅上丐丆上丏东业丂(System.Collections.Generic.List<System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, float>> 丁丘丈万与不且东业)
        {
            var val_9;
            float val_10;
            float val_11;
            var val_12;
            PlayerBot.且丏丕丝丄上业上丒 val_13;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_9 = val_1.x;
            val_10 = val_1.y;
            val_11 = val_1.z;
            val_12 = 0;
            val_13 = 0;
            goto label_3;
            label_16:
            System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single> val_2 = 丁丘丈万与不且东业.Item[0];
            if(10000f > 0f)
            {
                    System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single> val_3 = 丁丘丈万与不且东业.Item[0];
                System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single> val_4 = 丁丘丈万与不且东业.Item[0];
                val_13 = 丁丘丈万与不且东业;
                System.ValueTuple<PlayerBot.且丏丕丝丄上业上丒, System.Single> val_5 = 丁丘丈万与不且东业.Item[0];
                var val_10 = 0;
                val_10 = val_10 + 1;
                UnityEngine.Vector3 val_8 = 丁丘丈万与不且东业.BotTargetTransform.position;
                val_9 = val_8.x;
                val_10 = val_8.y;
                val_11 = val_8.z;
            }
            
            val_12 = 1;
            label_3:
            if(val_12 < 丁丘丈万与不且东业.Count)
            {
                goto label_16;
            }
            
            this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  val_13);
            this.丂七上七万丈丁丅丅 = val_8;
            mem[1152921540792486692] = val_10;
            mem[1152921540792486696] = val_11;
        }
        private void 丐三丂与丞专丆丕下(System.Collections.Generic.List<PlayerBot.且丏丕丝丄上业上丒> 丁丘丈万与不且东业)
        {
            int val_2 = UnityEngine.Random.Range(min:  0, max:  丁丘丈万与不且东业.Count);
            if(丁丘丈万与不且东业 != null)
            {
                    this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  丁丘丈万与不且东业.Item[val_2]);
            }
            else
            {
                    this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  丁丘丈万与不且东业.Item[val_2]);
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            UnityEngine.Vector3 val_8 = 丁丘丈万与不且东业.Item[val_2].BotTargetTransform.position;
            this.丂七上七万丈丁丅丅 = val_8;
            mem[1152921540792623300] = val_8.y;
            mem[1152921540792623304] = val_8.z;
        }
        internal void 丏丒专丟业上下丁万(PlayerBot.且丏丕丝丄上业上丒 丞下万上三丘上与专)
        {
            var val_7 = 0;
            if( == 0)
            {
                    return;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(丞下万上三丘上与专.BotTargetIsDead == true)
            {
                    return;
            }
            
            if((this.丑丙且下丏丙东且丏(丞下万上三丘上与专:  丞下万上三丘上与专)) == false)
            {
                    return;
            }
            
            this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  丞下万上三丘上与专);
            var val_10 = 0;
            val_10 = val_10 + 1;
            UnityEngine.Vector3 val_8 = 丞下万上三丘上与专.BotTargetTransform.position;
            this.丂七上七万丈丁丅丅 = val_8;
            mem[1152921540792759924] = val_8.y;
            mem[1152921540792759928] = val_8.z;
        }
        private void Update()
        {
            var val_4 = 0;
            if( == 0)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            if(this.与丝丁丑丁丌丞丞东.BotTargetIsDead == false)
            {
                    return;
            }
            
            this.CancelTarget();
        }
        public void CancelTarget()
        {
            this.三丈丅七丕丂丟七丄(丙业与丙丗丝不丈东:  0);
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.controller._agentController.agent.destination = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.丂七上七万丈丁丅丅 = val_3;
            mem[1152921540793024948] = val_3.y;
            mem[1152921540793024952] = val_3.z;
        }
        private bool 丑丙且下丏丙东且丏(PlayerBot.且丏丕丝丄上业上丒 丞下万上三丘上与专)
        {
            float val_5;
            float val_6;
            var val_11 = 0;
            val_11 = val_11 + 1;
            UnityEngine.Vector3 val_3 = 丞下万上三丘上与专.BotTargetTransform.position;
            UnityEngine.Ray val_4 = this.三业业世与万丑下东(丙丌丛丘丗与一专丁:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            if((this.controller.playerBotController.player.七与丆一丏下丏七不(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, 丂七丑世丏丐丅不丌: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丏上万丅丏一不不丕:  this.maxDistToNoticeTarget, 丄丏且业丏丟且丂丁:  Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞())) == false)
            {
                    return false;
            }
            
            丅丙上七上一丐不下 val_9 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
            if(val_9 != null)
            {
                    if(null == 丞下万上三丘上与专)
            {
                    return false;
            }
            
                if(val_9 == 丞下万上三丘上与专)
            {
                    return false;
            }
            
            }
            
            return false;
        }
        public AIBotTargetDetector()
        {
            this.丑丞丄三东三且世丟 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.丂七上七万丈丁丅丅 = val_2;
            mem[1152921540793322644] = val_2.y;
            mem[1152921540793322648] = val_2.z;
            this.丕丘业七丌与丅丞三 = 5f;
            this.timeBetweenTargetChecksIfEngaging = ;
            this.timeBetweenTargetChecksIfNotEngaging = ;
            this.timeBetweenLOSChecks = 0.5f;
            this.effectiveFov = 70f;
            this.maxDistToNoticeTarget = ;
            this.forwardDistToTarget = ;
            this.sideDistToTarget = 625f;
            this.aroundDistToTarget = 4f;
            this.forwardFov = ;
            this.sideFov = ;
            this.aroundFov = 360f;
            this.distanceToLoseAwarness = 20f;
        }
    
    }

}
