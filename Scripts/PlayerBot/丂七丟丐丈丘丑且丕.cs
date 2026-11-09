using UnityEngine;

namespace PlayerBot
{
    internal class 丂七丟丐丈丘丑且丕 : 丁丘丄丞丂丏丑丙丝
    {
        // Fields
        private float 丅丞七专丕丄七丙丝;
        private float 三丗一丘丘丒丄丗丆;
        private float 丗丑一丝一丒丝丄丆;
        private Rilisoft.专与丏丞三与不不丆 丙丗世丗下下上与丟;
        private PlayerBotPath 丗且丝丘丗丞七世丆;
        private float 丛丑丑丐业丄丙丌不;
        private bool 一一世丌丆丞专专下;
        private int 丘世丄世东不下丁与;
        private float 丅丅三与三七与丐上;
        private static System.Collections.Generic.List<PlayerBotPath> 且丆丅丆丆丏三丛丛;
        private bool 丅东丈丁专丘且专丁;
        private PlayerBotPathWayPoint 一丈丛丁丕丘专丁一;
        private PlayerBotPathWayPoint 三且丛丄专丛三与丑;
        private bool 丗丂丂丞上丙丄丏丘;
        
        // Methods
        internal override void 丌一七丌丄丌七上丞(PlayerBot.AIBotController 丒专丈丛下丒一丒丛)
        {
            this.丌一七丌丄丌七上丞(丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
            if(丒专丈丛下丒一丒丛 != null)
            {
                    this.丅丞七专丕丄七丙丝 = 丒专丈丛下丒一丒丛.maxMoveDistance;
                this.三丗一丘丘丒丄丗丆 = 丒专丈丛下丒一丒丛.moveSpeed;
                return;
            }
            
            this.丅丞七专丕丄七丙丝 = 0f;
            this.三丗一丘丘丒丄丗丆 = 3.048523E-34f;
        }
        private void 万与丝专丄业丁丈丗()
        {
            Rilisoft.专与丏丞三与不不丆 val_14;
            var val_15;
            val_14 = this.丙丗世丗下下上与丟;
            if((丟不丛丟丝丒且丞上(丙一丐丕丗一丗丄丘: out  val_14)) == false)
            {
                    return;
            }
            
            上且下一丁丑丑丟丟 val_3 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            val_14 = mem[this.丙丗世丗下下上与丟 + 124];
            val_14 = this.丙丗世丗下下上与丟 + 124;
            if((val_3.专东丄东丕下东丐一(丑万世丂专丈丌业且:  val_14)) == false)
            {
                    return;
            }
            
            if((this.丑七万专丌业丙丙丌(丘丄丌丌丆丙丅丛丆:  this.丙丗世丗下下上与丟, 业丒丝丗与丐丛丟丏: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) == false)
            {
                    return;
            }
            
            mem[1152921540795826792] = 0;
            mem[1152921540795826800] = 0f;
            if((val_3 != 0) && (val_3 != 0))
            {
                    if(val_3 != 0)
            {
                    bool val_9 = UnityEngine.Object.op_Inequality(x:  val_3, y:  0);
            }
            
            }
            
            val_15 = null;
            val_15 = null;
            val_3.丕丐丞业不一丒万丕.speed = 丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
            UnityEngine.Vector3 val_12 = val_3.丕丐丞业不一丒万丕.position;
            float val_13 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V12.16B, z = V11.16B});
            mem[1152921540795826824] = 0;
            this.丗且丝丘丗丞七世丆 = 0;
            val_13 = val_13 / this.三丗一丘丘丒丄丗丆;
            val_13 = UnityEngine.Time.time + val_13;
            this.丗丑一丝一丒丝丄丆 = val_13;
        }
        internal override void 丑丁业不丏丆丞丞一()
        {
            if(this.丗丑一丝一丒丝丄丆 <= UnityEngine.Time.time)
            {
                    this.万与丝专丄业丁丈丗();
            }
            
            if(this.丗丑一丝一丒丝丄丆 > UnityEngine.Time.time)
            {
                    return;
            }
            
            PlayerBotPathsManager val_3 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_3.wayPoints.Count == 0)
            {
                goto label_25;
            }
            
            if(PlayerBotPathsManager.与一丅丝不丈业与丙().丈业三一东丄下上丆() != false)
            {
                    if(val_5.wayPoints.isMine != false)
            {
                    this.七且丗丈丙不上丏丐();
                return;
            }
            
            }
            
            if((this.丗且丝丘丗丞七世丆 != 0) || (this.丗且丝丘丗丞七世丆.points.isMine == false))
            {
                goto label_22;
            }
            
            PlayerBotPath val_11 = this.业丞丆业一世上万丆(业丛下丟专丒东专丘:  this.丘丆丟丝与三丌业丅(), 一丈丛丁丕丘专丁一:  0);
            this.丗且丝丘丗丞七世丆 = val_11;
            if(val_11 != 0)
            {
                    this.丌丑丄丂业丟丟丕丂(世丝七丆丙丘丛丕丁:  this.丗且丝丘丗丞七世丆);
                return;
            }
            
            label_25:
            mem[1152921540795989000] = 0;
            this.丂丗上丆上丟上丈丑();
            return;
            label_22:
            this.与三丟丄丌世丅业丘();
        }
        private float 丆不丞丕三三丁丏业(UnityEngine.AI.NavMeshAgent 丟丅三丝丄丈万丒三)
        {
            float val_20;
            var val_21;
            if(丟丅三丝丄丈万丒三.pathPending == true)
            {
                    return val_22;
            }
            
            val_20 = -1f;
            if(丟丅三丝丄丈万丒三.pathStatus == 2)
            {
                    return val_22;
            }
            
            UnityEngine.Vector3[] val_4 = 丟丅三丝丄丈万丒三.path.corners;
            if(val_4.Length == 0)
            {
                    return val_22;
            }
            
            UnityEngine.Vector3[] val_6 = 丟丅三丝丄丈万丒三.path.corners;
            if(val_6.Length < 3)
            {
                    if(丟丅三丝丄丈万丒三 != null)
            {
                    return 丟丅三丝丄丈万丒三.remainingDistance;
            }
            
                return 丟丅三丝丄丈万丒三.remainingDistance;
            }
            
            val_21 = 0;
            goto label_15;
            label_36:
            UnityEngine.AI.NavMeshPath val_7 = 丟丅三丝丄丈万丒三.path;
            UnityEngine.Vector3[] val_8 = val_7.corners;
            var val_9 = W28 - 1;
            val_9 = val_9 + 1;
            var val_11 = val_7.corners + ((long)(long)(int)(W28) * 12);
            val_9 = val_9 - 1;
            var val_14 = val_7.corners + (0 * 12);
            var val_16 = val_9 + 1;
            var val_17 = val_7.corners + ((long)(long)(int)(W28) * 12);
            UnityEngine.Color val_18 = UnityEngine.Color.green;
            val_20 = val_18.r;
            float val_22 = 0f;
            val_22 = val_22 + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f}, b:  new UnityEngine.Vector3() {x = ((long)(int)(W28) * 12) + val_10 + 32, y = ((long)(int)(W28) * 12) + val_10 + 32 + 4, z = ((long)(int)(W28) * 12) + val_10 + 40}));
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = (0 * 12) + val_13 + 32, y = (0 * 12) + val_13 + 36, z = (0 * 12) + val_13 + 40}, end:  new UnityEngine.Vector3() {x = ((long)(int)(W28) * 12) + val_15 + 32, y = ((long)(int)(W28) * 12) + val_15 + 32 + 4, z = ((long)(int)(W28) * 12) + val_15 + 40}, color:  new UnityEngine.Color() {r = val_20, g = val_18.b, b = 2f}, duration:  (0 * 12) + val_13 + 36);
            val_21 = 1;
            label_15:
            UnityEngine.Vector3[] val_21 = 丟丅三丝丄丈万丒三.path.corners;
            if((val_21 + 1) < val_21.Length)
            {
                goto label_36;
            }
            
            return val_22;
        }
        private float 丄下丙丑丟丅东东丌(UnityEngine.AI.NavMeshPath 丕丁且丑业丄丁丗丕)
        {
            var val_20;
            UnityEngine.Vector3 val_21;
            UnityEngine.Vector3 val_22;
            float val_24;
            float val_25;
            var val_26;
            val_20 = 丕丁且丑业丄丁丗丕;
            UnityEngine.Vector3[] val_1 = val_20.corners;
            if(val_1.Length >= 3)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3[] val_2 = val_20.corners;
            if(val_2.Length != 2)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3[] val_3 = val_20.corners;
            UnityEngine.Vector3[] val_4 = val_20.corners;
            float val_5 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3[0], y = val_3[0], z = val_3[1]}, b:  new UnityEngine.Vector3() {x = val_4[1], y = val_4[2], z = val_4[2]});
            UnityEngine.Vector3[] val_6 = val_20.corners;
            val_20 = val_20.corners;
            val_21 = val_20[1];
            val_22 = val_20[2];
            UnityEngine.Color val_8 = UnityEngine.Color.green;
            val_24 = val_8.b;
            val_25 = val_8.a;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_6[0], y = val_6[0], z = val_6[1]}, end:  new UnityEngine.Vector3() {x = val_21, y = val_20[2], z = val_22}, color:  new UnityEngine.Color() {r = val_8.r, g = val_24, b = 10f}, duration:  null);
            return 0f;
            label_3:
            val_26 = 0;
            goto label_24;
            label_43:
            UnityEngine.Vector3[] val_9 = val_20.corners;
            var val_10 = W27 - 1;
            val_10 = val_10 + 1;
            var val_12 = val_20.corners + ((long)(long)(int)(W27) * 12);
            val_10 = val_10 - 1;
            var val_15 = val_20.corners + (0 * 12);
            val_21 = mem[(0 * 12) + val_14 + 40];
            val_21 = (0 * 12) + val_14 + 40;
            var val_17 = val_10 + 1;
            var val_18 = val_20.corners + ((long)(long)(int)(W27) * 12);
            val_22 = mem[((long)(int)(W27) * 12) + val_16 + 32 + 4];
            val_22 = ((long)(int)(W27) * 12) + val_16 + 32 + 4;
            UnityEngine.Color val_19 = UnityEngine.Color.green;
            val_24 = val_19.r;
            val_25 = val_19.b;
            float val_32 = 0f;
            val_32 = val_32 + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f}, b:  new UnityEngine.Vector3() {x = ((long)(int)(W27) * 12) + val_11 + 32, y = ((long)(int)(W27) * 12) + val_11 + 32 + 4, z = ((long)(int)(W27) * 12) + val_11 + 40}));
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = (0 * 12) + val_14 + 32, y = (0 * 12) + val_14 + 36, z = val_21}, end:  new UnityEngine.Vector3() {x = ((long)(int)(W27) * 12) + val_16 + 32, y = val_22, z = ((long)(int)(W27) * 12) + val_16 + 40}, color:  new UnityEngine.Color() {r = val_24, g = val_25, b = 10f}, duration:  (0 * 12) + val_14 + 36);
            val_26 = 1;
            label_24:
            UnityEngine.Vector3[] val_21 = val_20.corners;
            if((val_26 + 1) < val_21.Length)
            {
                goto label_43;
            }
            
            return 0f;
            label_6:
            UnityEngine.Debug.Log(message:  "== GetDistanceFromPath: - error, distance is zero");
            return 0f;
        }
        private PlayerBotPathWayPoint 丏下七丝世丟丏丏丐(PlayerBotPathWayPoint 丛丅丁丛丌与丐下与, PlayerBotPathWayPoint 一丈丛丁丕丘专丁一)
        {
            var val_18;
            int val_19;
            var val_20;
            var val_21;
            System.Collections.Generic.List<PlayerBotPathWayPoint> val_1 = new System.Collections.Generic.List<PlayerBotPathWayPoint>(collection:  丛丅丁丛丌与丐下与.reachableWayPoints);
            if(一丈丛丁丕丘专丁一 != null)
            {
                    if(val_1.Count >= 2)
            {
                    bool val_3 = val_1.Remove(item:  一丈丛丁丕丘专丁一);
            }
            
            }
            
            System.Collections.Generic.List<System.ValueTuple<System.Int32, System.Int32, System.Int32>> val_4 = new System.Collections.Generic.List<System.ValueTuple<System.Int32, System.Int32, System.Int32>>();
            val_18 = 0;
            val_19 = 0;
            goto label_6;
            label_13:
            PlayerBotPathWayPoint val_5 = val_1.Item[0];
            int val_6 = val_5.weight + val_19;
            val_4.Add(item:  new System.ValueTuple<System.Int32, System.Int32, System.Int32>());
            PlayerBotPathWayPoint val_7 = val_1.Item[0];
            val_18 = 1;
            val_19 = val_7.weight + val_19;
            label_6:
            if(val_18 < val_1.Count)
            {
                goto label_13;
            }
            
            int val_9 = UnityEngine.Random.Range(min:  0, max:  val_19);
            val_20 = 0;
            goto label_14;
            label_24:
            if(((val_9 & 2147483648) != 0) || (val_20 != 0))
            {
                goto label_16;
            }
            
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_10 = val_4.Item[0];
            if(val_9 <= 0)
            {
                goto label_18;
            }
            
            label_16:
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_11 = val_4.Item[0];
            if(val_9 <= (val_11.Item3 >> 32))
            {
                goto label_20;
            }
            
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_13 = val_4.Item[0];
            if(val_9 <= val_20)
            {
                goto label_22;
            }
            
            label_20:
            val_20 = 1;
            label_14:
            if(val_20 < val_4.Count)
            {
                goto label_24;
            }
            
            label_30:
            val_21 = UnityEngine.Random.Range(min:  0, max:  val_1.Count);
            if(val_1 != null)
            {
                    return (PlayerBotPathWayPoint)val_1.Item[0];
            }
            
            return (PlayerBotPathWayPoint)val_1.Item[0];
            label_18:
            val_21 = 0;
            if(val_1 != null)
            {
                    return (PlayerBotPathWayPoint)val_1.Item[0];
            }
            
            return (PlayerBotPathWayPoint)val_1.Item[0];
            label_22:
            if(val_20 == 1)
            {
                goto label_30;
            }
            
            if(val_1 != null)
            {
                    return (PlayerBotPathWayPoint)val_1.Item[0];
            }
            
            return (PlayerBotPathWayPoint)val_1.Item[0];
        }
        private PlayerBotPathWayPoint 丘丆丟丝与三丌业丅()
        {
            var val_24;
            System.Func<PlayerBotPathWayPoint, System.Boolean> val_26;
            var val_27;
            int val_28;
            var val_29;
            var val_30;
            PlayerBotPathsManager val_1 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            val_24 = null;
            val_24 = null;
            val_26 = 丂七丟丐丈丘丑且丕.<>c.<>9__20_0;
            if(val_26 == null)
            {
                    System.Func<PlayerBotPathWayPoint, System.Boolean> val_2 = null;
                val_26 = val_2;
                val_2 = new System.Func<PlayerBotPathWayPoint, System.Boolean>(object:  丂七丟丐丈丘丑且丕.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丂七丟丐丈丘丑且丕.<>c::业丅上丞且丙丛七丟(PlayerBotPathWayPoint 三丟东丕丄丄下下丑));
                丂七丟丐丈丘丑且丕.<>c.<>9__20_0 = val_26;
            }
            
            if((System.Linq.Enumerable.Any<PlayerBotPathWayPoint>(source:  val_1.wayPoints, predicate:  val_2)) != false)
            {
                    UnityEngine.Vector3 val_4 = this.position;
                return this.丄丄丗丑丕万丁丝东(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丐丘不丙丘上丗丙丁:  true);
            }
            
            System.Collections.Generic.List<System.ValueTuple<System.Int32, System.Int32, System.Int32>> val_5 = new System.Collections.Generic.List<System.ValueTuple<System.Int32, System.Int32, System.Int32>>();
            val_27 = 0;
            val_28 = 0;
            goto label_11;
            label_25:
            PlayerBotPathsManager val_6 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_7 = val_6.wayPoints.Item[0];
            int val_8 = val_7.weight + val_28;
            val_5.Add(item:  new System.ValueTuple<System.Int32, System.Int32, System.Int32>());
            PlayerBotPathsManager val_9 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_10 = val_9.wayPoints.Item[0];
            val_27 = 1;
            val_28 = val_10.weight + val_28;
            label_11:
            PlayerBotPathsManager val_11 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_27 < val_11.wayPoints.Count)
            {
                goto label_25;
            }
            
            int val_13 = UnityEngine.Random.Range(min:  0, max:  val_28);
            val_29 = 0;
            goto label_26;
            label_36:
            if(((val_13 & 2147483648) != 0) || (val_29 != 0))
            {
                goto label_28;
            }
            
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_14 = val_5.Item[0];
            if(val_13 <= 0)
            {
                goto label_30;
            }
            
            label_28:
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_15 = val_5.Item[0];
            if(val_13 <= (val_15.Item3 >> 32))
            {
                goto label_32;
            }
            
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_17 = val_5.Item[0];
            if(val_13 <= val_29)
            {
                goto label_34;
            }
            
            label_32:
            val_29 = 1;
            label_26:
            if(val_29 < val_5.Count)
            {
                goto label_36;
            }
            
            label_43:
            PlayerBotPathsManager val_19 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            val_30 = UnityEngine.Random.Range(min:  0, max:  val_19.wayPoints.Count);
            goto label_42;
            label_30:
            val_30 = 0;
            goto label_42;
            label_34:
            if(val_29 == 1)
            {
                goto label_43;
            }
            
            label_42:
            PlayerBotPathsManager val_22 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            return (PlayerBotPathWayPoint)val_22.wayPoints.Item[0];
        }
        private PlayerBotPathWayPoint 丄丄丗丑丕万丁丝东(UnityEngine.Vector3 下业丕七东丌丝下且, bool 丐丘不丙丘上丗丙丁 = False)
        {
            var val_27;
            UnityEngine.Object val_28;
            val_27 = 0;
            val_28 = 0;
            goto label_1;
            label_67:
            PlayerBotPathsManager val_1 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            UnityEngine.Vector3 val_4 = val_1.wayPoints.Item[0].transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
            if(val_28 == 0)
            {
                    PlayerBotPathsManager val_7 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                val_28 = val_7.wayPoints.Item[0];
            }
            
            if(丐丘不丙丘上丗丙丁 == false)
            {
                goto label_17;
            }
            
            PlayerBotPathsManager val_9 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_10 = val_9.wayPoints.Item[0];
            if(val_10.startedPaths.Count <= 0)
            {
                goto label_24;
            }
            
            if(val_5.x <= val_5.x)
            {
                goto label_25;
            }
            
            goto label_58;
            label_17:
            PlayerBotPathsManager val_12 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_13 = val_12.wayPoints.Item[0];
            if(val_13.startedPaths.Count <= 0)
            {
                goto label_33;
            }
            
            if(val_5.x <= val_5.x)
            {
                goto label_49;
            }
            
            goto label_58;
            label_24:
            PlayerBotPathsManager val_15 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_16 = val_15.wayPoints.Item[0];
            if((val_5.x > val_5.x) || (val_16.reachableWayPoints.Count < 1))
            {
                goto label_58;
            }
            
            label_25:
            PlayerBotPathsManager val_18 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_19 = val_18.wayPoints.Item[0];
            if(val_19.isDefence == true)
            {
                goto label_49;
            }
            
            goto label_58;
            label_33:
            PlayerBotPathsManager val_20 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_21 = val_20.wayPoints.Item[0];
            if((val_5.x > val_5.x) || (val_21.reachableWayPoints.Count < 1))
            {
                goto label_58;
            }
            
            label_49:
            PlayerBotPathsManager val_23 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            val_28 = val_23.wayPoints.Item[0];
            label_58:
            val_27 = 1;
            label_1:
            PlayerBotPathsManager val_25 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_27 < val_25.wayPoints.Count)
            {
                goto label_67;
            }
            
            return (PlayerBotPathWayPoint)val_28;
        }
        private PlayerBotPathWayPoint 丑与丐一东世七万丄(UnityEngine.Vector3 下业丕七东丌丝下且)
        {
            var val_18;
            UnityEngine.Object val_19;
            float val_20;
            UnityEngine.AI.NavMeshPath val_1 = new UnityEngine.AI.NavMeshPath();
            val_18 = 0;
            val_19 = 0;
            goto label_1;
            label_36:
            PlayerBotPathsManager val_2 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_3 = val_2.wayPoints.Item[0];
            UnityEngine.Vector3 val_4 = val_3.丛丄与丌丛万业丝丞.position;
            val_20 = val_4.y;
            bool val_5 = X23 + 24.CalculatePath(targetPosition:  new UnityEngine.Vector3() {x = val_4.x, y = val_20, z = val_4.z}, path:  val_1);
            if(val_1.status == 0)
            {
                    PlayerBotPathsManager val_7 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                PlayerBotPathWayPoint val_8 = val_7.wayPoints.Item[0];
                UnityEngine.Vector3 val_9 = val_8.丛丄与丌丛万业丝丞.position;
                val_20 = val_9.y;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_20, z = val_9.z}, b:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
                if(val_19 == 0)
            {
                    PlayerBotPathsManager val_12 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                val_19 = val_12.wayPoints.Item[0];
            }
            
                if(val_10.x <= val_10.x)
            {
                    PlayerBotPathsManager val_14 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                val_19 = val_14.wayPoints.Item[0];
            }
            
            }
            
            val_18 = 1;
            label_1:
            PlayerBotPathsManager val_16 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_18 < val_16.wayPoints.Count)
            {
                goto label_36;
            }
            
            return (PlayerBotPathWayPoint)val_19;
        }
        private void 丌丑丄丂业丟丟丕丂(PlayerBotPath 世丝七丆丙丘丛丕丁)
        {
            var val_13;
            var val_14;
            PlayerBotPath val_27;
            var val_28;
            var val_29;
            PlayerBotPath val_30;
            var val_31;
            var val_32;
            var val_33;
            val_27 = 世丝七丆丙丘丛丕丁;
            this.丗且丝丘丗丞七世丆 = val_27;
            if(世丝七丆丙丘丛丕丁.points == null)
            {
                    string val_2 = val_27.transform.name;
                UnityEngine.Debug.LogError(message:  val_2);
            }
            
            this.丘世丄世东不下丁与 = 0;
            if((val_2 != 0) && (static_value_082C7040 != 0))
            {
                    if((static_value_082C7040 + 48) != 0)
            {
                    bool val_6 = UnityEngine.Object.op_Inequality(x:  static_value_082C7040 + 64 + 48 + 96, y:  0);
            }
            
            }
            
            val_28 = 1152921505325268992;
            val_29 = null;
            val_29 = null;
            static_value_082C7040 + 64 + 48 + 64 + 48 + 48 + 24.speed = X22 + 72 + 104.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
            if(this.丗且丝丘丗丞七世丆 != 0)
            {
                goto label_38;
            }
            
            UnityEngine.Vector3 val_9 = this.丗且丝丘丗丞七世丆.position;
            val_30 = this.业丞丆业一世上万丆(业丛下丟专丒东专丘:  this.丗且丝丘丗丞七世丆.丄丄丗丑丕万丁丝东(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丐丘不丙丘上丗丙丁:  false), 一丈丛丁丕丘专丁一:  0);
            this.丗且丝丘丗丞七世丆 = val_30;
            if(val_30 != null)
            {
                goto label_42;
            }
            
            goto label_41;
            label_38:
            val_30 = this.丗且丝丘丗丞七世丆;
            if(val_30 != null)
            {
                goto label_42;
            }
            
            label_41:
            label_42:
            PlayerBotPathPoint val_12 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            mem[1152921540798897944] = val_13;
            mem[1152921540798897952] = val_14;
            val_31 = mem[X22 + 72 + 64 + 24];
            val_31 = X22 + 72 + 64 + 24;
            if(val_31.isMine == false)
            {
                    return;
            }
            
            val_28 = 0;
            val_31 = 0;
            val_32 = 0;
            goto label_48;
            label_69:
            val_33 = 0;
            goto label_49;
            label_64:
            PlayerBotPathsManager val_16 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_17 = val_16.wayPoints.Item[0];
            bool val_19 = UnityEngine.Object.op_Equality(x:  val_17.startedPaths.Item[0], y:  val_27);
            val_33 = 1;
            label_49:
            PlayerBotPathsManager val_22 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_23 = val_22.wayPoints.Item[0];
            if(val_33 < val_23.startedPaths.Count)
            {
                goto label_64;
            }
            
            val_28 = 1;
            label_48:
            PlayerBotPathsManager val_25 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_28 < val_25.wayPoints.Count)
            {
                goto label_69;
            }
            
            val_27 = mem[mem[1152921540798897968] + 64];
            val_27 = mem[1152921540798897968] + 64;
            val_27.丏上丟丕丒丟丄且丄(丛业丌丕与丛下丞丞:  (val_19 != true) ? (val_28) : (val_32), 丛丄业丕且丗下一万:  (val_19 != true) ? (val_33) : (val_31));
        }
        internal void 丑丘丆丘丑万丕丝丂(int 东不丁丗丘万丅丟丞, int 七世丁专丟丌丁下丗)
        {
            PlayerBotPathsManager val_1 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_1.wayPoints.Count <= 东不丁丗丘万丅丟丞)
            {
                    return;
            }
            
            PlayerBotPathsManager val_3 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_4 = val_3.wayPoints.Item[东不丁丗丘万丅丟丞];
            if(val_4.startedPaths.Count <= 七世丁专丟丌丁下丗)
            {
                    return;
            }
            
            PlayerBotPathsManager val_6 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_7 = val_6.wayPoints.Item[东不丁丗丘万丅丟丞];
            this.丌丑丄丂业丟丟丕丂(世丝七丆丙丘丛丕丁:  val_7.startedPaths.Item[七世丁专丟丌丁下丗]);
        }
        private PlayerBotPath 业丞丆业一世上万丆(PlayerBotPathWayPoint 业丛下丟专丒东专丘, PlayerBotPathWayPoint 一丈丛丁丕丘专丁一)
        {
            var val_43;
            float val_44;
            float val_45;
            var val_46;
            var val_47;
            System.Func<PlayerBotPathWayPoint, System.Boolean> val_49;
            var val_50;
            var val_51;
            var val_52;
            int val_53;
            var val_54;
            var val_55;
            int val_56;
            var val_57;
            val_43 = 业丛下丟专丒东专丘;
            if(业丛下丟专丒东专丘.startedPaths.Count != 0)
            {
                goto label_3;
            }
            
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  一丈丛丁丕丘专丁一);
            if(val_2 == false)
            {
                goto label_6;
            }
            
            if(一丈丛丁丕丘专丁一.transform != null)
            {
                goto label_75;
            }
            
            label_76:
            label_75:
            UnityEngine.Vector3 val_4 = 0.position;
            val_44 = val_4.x;
            val_45 = val_4.z;
            val_43 = this.丄丄丗丑丕万丁丝东(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_44, y = val_4.y, z = val_45}, 丐丘不丙丘上丗丙丁:  false);
            if(val_43 == null)
            {
                goto label_79;
            }
            
            label_3:
            val_46 = 0;
            label_79:
            if(val_5.startedPaths.Count < 1)
            {
                goto label_12;
            }
            
            PlayerBotPathsManager val_7 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            val_47 = null;
            val_47 = null;
            val_49 = 丂七丟丐丈丘丑且丕.<>c.<>9__25_0;
            if(val_49 == null)
            {
                    System.Func<PlayerBotPathWayPoint, System.Boolean> val_8 = null;
                val_49 = val_8;
                val_8 = new System.Func<PlayerBotPathWayPoint, System.Boolean>(object:  丂七丟丐丈丘丑且丕.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丂七丟丐丈丘丑且丕.<>c::丁万丞丌丐丗丝下丘(PlayerBotPathWayPoint 三丟东丕丄丄下下丑));
                丂七丟丐丈丘丑且丕.<>c.<>9__25_0 = val_49;
            }
            
            if((System.Linq.Enumerable.Any<PlayerBotPathWayPoint>(source:  val_7.wayPoints, predicate:  val_8)) == false)
            {
                goto label_21;
            }
            
            System.Collections.Generic.List<PlayerBotPath> val_10 = new System.Collections.Generic.List<PlayerBotPath>();
            val_50 = 1152921538683398256;
            val_46 = 1152921504838316032;
            val_51 = 0;
            goto label_22;
            label_38:
            PlayerBotPath val_11 = val_5.startedPaths.Item[0];
            UnityEngine.Transform val_12 = val_11.finishWayPoint.transform;
            UnityEngine.Vector3 val_13 = val_12.position;
            val_45 = val_13.z;
            UnityEngine.Vector3 val_14 = val_12.position;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_45}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_44 = val_15.x;
            PlayerBotPath val_16 = val_5.startedPaths.Item[0];
            if(val_16.finishWayPoint.isDefence == true)
            {
                goto label_33;
            }
            
            if(val_44 < 0)
            {
                    val_10.Add(item:  val_5.startedPaths.Item[0]);
            }
            
            val_51 = 1;
            label_22:
            if(val_51 < val_5.startedPaths.Count)
            {
                goto label_38;
            }
            
            val_52 = public PlayerBotPath System.Collections.Generic.List<PlayerBotPath>::get_Item(int index);
            val_53 = UnityEngine.Random.Range(min:  0, max:  val_10.Count);
            goto label_85;
            label_12:
            val_54 = 0;
            goto label_42;
            label_21:
            System.Collections.Generic.List<System.ValueTuple<System.Int32, System.Int32, System.Int32>> val_21 = new System.Collections.Generic.List<System.ValueTuple<System.Int32, System.Int32, System.Int32>>();
            val_55 = 0;
            val_56 = 0;
            goto label_43;
            label_62:
            PlayerBotPath val_22 = val_5.startedPaths.Item[0];
            if(val_22.finishWayPoint != 0)
            {
                    PlayerBotPath val_24 = val_5.startedPaths.Item[0];
                if(val_24.finishWayPoint != 一丈丛丁丕丘专丁一)
            {
                    PlayerBotPath val_26 = val_5.startedPaths.Item[0];
                int val_27 = val_26.finishWayPoint.weight + val_56;
                val_21.Add(item:  new System.ValueTuple<System.Int32, System.Int32, System.Int32>());
                PlayerBotPath val_28 = val_5.startedPaths.Item[0];
                val_56 = val_28.finishWayPoint.weight + val_56;
            }
            
            }
            
            val_55 = 1;
            label_43:
            if(val_55 < val_5.startedPaths.Count)
            {
                goto label_62;
            }
            
            int val_30 = UnityEngine.Random.Range(min:  0, max:  val_56);
            val_50 = 1152921540797757248;
            val_46 = 1152921540797758272;
            val_57 = 0;
            goto label_63;
            label_73:
            if(((val_30 & 2147483648) != 0) || (val_57 != 0))
            {
                goto label_65;
            }
            
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_31 = val_21.Item[0];
            if(val_30 <= 0)
            {
                goto label_67;
            }
            
            label_65:
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_32 = val_21.Item[0];
            if(val_30 <= (val_32.Item3 >> 32))
            {
                goto label_69;
            }
            
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_34 = val_21.Item[0];
            if(val_30 <= val_57)
            {
                goto label_71;
            }
            
            label_69:
            val_57 = 1;
            label_63:
            if(val_57 < val_21.Count)
            {
                goto label_73;
            }
            
            val_51 = 0;
            goto label_74;
            label_6:
            if(val_2 == true)
            {
                goto label_75;
            }
            
            goto label_76;
            label_33:
            val_52 = public PlayerBotPath System.Collections.Generic.List<PlayerBotPath>::get_Item(int index);
            val_53 = val_51;
            goto label_85;
            label_67:
            label_71:
            System.ValueTuple<System.Int32, System.Int32, System.Int32> val_36 = val_21.Item[0];
            val_51 = val_36.Item3;
            label_74:
            if(val_21.Count >= 1)
            {
                    val_52 = public PlayerBotPath System.Collections.Generic.List<PlayerBotPath>::get_Item(int index);
                val_53 = val_51;
            }
            else
            {
                    val_52 = public PlayerBotPath System.Collections.Generic.List<PlayerBotPath>::get_Item(int index);
                val_53 = UnityEngine.Random.Range(min:  0, max:  val_5.startedPaths.Count);
            }
            
            label_85:
            val_54 = val_5.startedPaths.Item[val_53];
            label_42:
            mem[1152921540799450680] = UnityEngine.Object.op_Inequality(x:  一丈丛丁丕丘专丁一, y:  0);
            return (PlayerBotPath)val_54;
        }
        private void 与三丟丄丌世丅业丘()
        {
            var val_8;
            float val_12;
            float val_13;
            float val_15;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_28;
            float val_31;
            float val_42;
            System.Collections.Generic.List<PlayerBotPathPoint> val_53;
            float val_54;
            var val_55;
            float val_56;
            float val_57;
            var val_58;
            static_value_082C7030 + 24.autoBraking = (this.丘世丄世东不下丁与 < 1) ? 1 : 0;
            val_53 = 1152921504848912384;
            if(this.丗且丝丘丗丞七世丆 == 0)
            {
                    mem[1152921540799882168] = 0;
                return;
            }
            
            val_54 = 1f;
            if((this.丗且丝丘丗丞七世丆 != 0) && (this.丗且丝丘丗丞七世丆 != 0))
            {
                    if(this.丗且丝丘丗丞七世丆 != 0)
            {
                    bool val_6 = UnityEngine.Object.op_Inequality(x:  this.丗且丝丘丗丞七世丆, y:  0);
            }
            
            }
            
            val_55 = 1;
            goto label_65;
            label_90:
            PlayerBotPathPoint val_7 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            if(val_8 != false)
            {
                    this.丗且丝丘丗丞七世丆.points.丕丗丁丄专丏三东不();
            }
            
            int val_9 = this.丘世丄世东不下丁与 + 1;
            this.丘世丄世东不下丁与 = val_9;
            if(val_9 >= this.丗且丝丘丗丞七世丆.points.Count)
            {
                goto label_39;
            }
            
            PlayerBotPathPoint val_11 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            mem[1152921540799882136] = val_12;
            mem[1152921540799882144] = val_13;
            if(this.丘世丄世东不下丁与 < 1)
            {
                goto label_65;
            }
            
            mem[1152921540799882168] = val_55;
            PlayerBotPathPoint val_14 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            val_56 = 6.5f;
            if((System.Single.IsInfinity(f:  val_15)) != true)
            {
                    PlayerBotPathPoint val_17 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
                val_56 = val_15;
            }
            
            val_55 = 1;
            this.丗且丝丘丗丞七世丆.points.speed = this.丘世丄世东不下丁与 + 72 + 104.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  val_56);
            UnityEngine.Vector3 val_19 = this.丗且丝丘丗丞七世丆.points.丘丄丈上与丕三丅丑();
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            PlayerBotPathPoint val_21 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            PlayerBotPathPoint val_27 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            PlayerBotPathPoint val_30 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与 - 1];
            float val_53 = val_31;
            val_53 = val_28 - val_53;
            val_57 = (UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, b:  new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_24, w = val_25})) / val_53;
            this.丅丅三与三七与丐上 = val_57;
            goto label_65;
            label_39:
            if(this.丗且丝丘丗丞七世丆.points.isMine == false)
            {
                goto label_70;
            }
            
            this.丌丑丄丂业丟丟丕丂(世丝七丆丙丘丛丕丁:  this.业丞丆业一世上万丆(业丛下丟专丒东专丘:  this.丗且丝丘丗丞七世丆.finishWayPoint, 一丈丛丁丕丘专丁一:  this.丗且丝丘丗丞七世丆.startWayPoint));
            val_58 = null;
            val_58 = null;
            val_57 = this.丗且丝丘丗丞七世丆.丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  FirstPersonControlSharp.三丏丅丐丏与下世丗);
            this.丗且丝丘丗丞七世丆.finishWayPoint.reachableWayPoints.speed = val_57;
            PlayerBotPathPoint val_35 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            mem[1152921540799882136] = val_12;
            mem[1152921540799882144] = val_13;
            label_65:
            UnityEngine.Vector3 val_36 = this.丗且丝丘丗丞七世丆.points.position;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  this.丗且丝丘丗丞七世丆.points.baseOffset);
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
            PlayerBotPathPoint val_41 = this.丗且丝丘丗丞七世丆.points.Item[this.丘世丄世东不下丁与];
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, b:  new UnityEngine.Vector3() {x = val_12, y = val_42, z = val_13});
            float val_54 = this.丛丑丑丐业丄丙丌不;
            val_54 = val_54 * val_54;
            if(val_43.x < 0)
            {
                goto label_90;
            }
            
            goto label_91;
            label_70:
            this.丘世丄世东不下丁与 = this.丗且丝丘丗丞七世丆.points.Count - 1;
            label_91:
            UnityEngine.Vector3 val_46 = this.丗且丝丘丗丞七世丆.points.desiredVelocity;
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_46.x, y = val_46.y, z = val_46.z}, d:  val_54);
            this.丗且丝丘丗丞七世丆.points.velocity = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
            UnityEngine.Vector3 val_48 = this.丗且丝丘丗丞七世丆.points.丘丄丈上与丕三丅丑();
            UnityEngine.Quaternion val_49 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_48.z});
            val_53 = this.丗且丝丘丗丞七世丆.points;
            PlayerBotPathPoint val_50 = val_53.Item[this.丘世丄世东不下丁与];
            float val_51 = UnityEngine.Time.deltaTime;
            val_51 = this.丅丅三与三七与丐上 * val_51;
            UnityEngine.Quaternion val_52 = UnityEngine.Quaternion.RotateTowards(from:  new UnityEngine.Quaternion() {x = val_49.x, y = val_49.y, z = val_49.z, w = val_49.w}, to:  new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_24, w = val_25}, maxDegreesDelta:  val_51);
            this.丗且丝丘丗丞七世丆.points.丈丌丝丐丆不且万不(丙业与丙丗丝不丈东:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
        }
        internal bool 丑七万专丌业丙丙丌(Rilisoft.专与丏丞三与不不丆 丘丄丌丌丆丙丅丛丆, out UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            var val_18;
            var val_30;
            UnityEngine.AI.NavMeshPath val_1 = new UnityEngine.AI.NavMeshPath();
            val_18 = 0;
            val_30 = null;
            val_30 = null;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            业丒丝丗与丐丛丟丏.x = val_15.x;
            业丒丝丗与丐丛丟丏.y = val_15.y;
            业丒丝丗与丐丛丟丏.z = val_15.z;
            return false;
        }
        private void 丂丗上丆上丟上丈丑()
        {
            float val_11 = this.丗丑一丝一丒丝丄丆;
            if(val_11 > UnityEngine.Time.time)
            {
                    return;
            }
            
            this.专丙且七丝丏丞丌下(业下丌下三丕丙丌下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Vector3 val_5 = position;
            float val_7 = val_2.x + (UnityEngine.Random.Range(min:  -this.丅丞七专丕丄七丙丝, max:  this.丅丞七专丕丄七丙丝));
            val_5.z = val_5.z + (UnityEngine.Random.Range(min:  -this.丅丞七专丕丄七丙丝, max:  this.丅丞七专丕丄七丙丝));
            mem[1152921540800568888] = 0;
            mem[1152921540800568896] = 0;
            val_11 = UnityEngine.Time.time;
            UnityEngine.Vector3 val_9 = position;
            float val_10 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V12.16B, z = val_5.z});
            val_10 = val_10 / this.三丗一丘丘丒丄丗丆;
            val_10 = val_11 + val_10;
            this.丗丑一丝一丒丝丄丆 = val_10;
        }
        private void 七且丗丈丙不上丏丐()
        {
            PlayerBotPathWayPoint val_31;
            if(this.三且丛丄专丛三与丑 != 0)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_2 = this.三且丛丄专丛三与丑.position;
            this.一丈丛丁丕丘专丁一 = 0;
            this.三且丛丄专丛三与丑 = this.丑与丐一东世七万丄(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            this.三且丛丄专丛三与丑.radius.acceleration = 16f;
            label_43:
            this.丗丂丂丞上丙丄丏丘 = true;
            goto label_7;
            label_3:
            bool val_4 = UnityEngine.Object.op_Inequality(x:  this.三且丛丄专丛三与丑, y:  0);
            if(val_4 == false)
            {
                goto label_42;
            }
            
            if(this.丅东丈丁专丘且专丁 == false)
            {
                goto label_11;
            }
            
            label_37:
            this.丗丂丂丞上丙丄丏丘 = true;
            this.一丈丛丁丕丘专丁一 = this.三且丛丄专丛三与丑;
            this.三且丛丄专丛三与丑 = val_4.丏下七丝世丟丏丏丐(丛丅丁丛丌与丐下与:  this.三且丛丄专丛三与丑, 一丈丛丁丕丘专丁一:  this.一丈丛丁丕丘专丁一);
            label_7:
            mem[1152921540800762841] = 0;
            label_42:
            UnityEngine.Vector3 val_6 = this.三且丛丄专丛三与丑.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.三且丛丄专丛三与丑.reachableWayPoints.baseOffset);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = this.三且丛丄专丛三与丑.丛丄与丌丛万业丝丞.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_31 = this.三且丛丄专丛三与丑;
            if(this.三且丛丄专丛三与丑 != null)
            {
                goto label_20;
            }
            
            val_31 = this.三且丛丄专丛三与丑;
            if(val_31 == null)
            {
                goto label_21;
            }
            
            label_20:
            float val_31 = this.三且丛丄专丛三与丑.radius;
            val_31 = val_31 * this.三且丛丄专丛三与丑.radius;
            this.丅东丈丁专丘且专丁 = (val_12.x < 0) ? 1 : 0;
            return;
            label_11:
            if(this.丗丂丂丞上丙丄丏丘 != false)
            {
                    UnityEngine.AI.NavMeshPath val_14 = new UnityEngine.AI.NavMeshPath();
                UnityEngine.Vector3 val_15 = this.三且丛丄专丛三与丑.randomPoint(上七不丈下下丛丘与:  V8.16B);
                bool val_16 = CalculatePath(targetPosition:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, path:  val_14);
                if(val_14.status != 1)
            {
                    if(val_14.status != 2)
            {
                goto label_29;
            }
            
            }
            
                mem[1152921540800762844] = UnityEngine.Random.Range(min:  -1f, max:  1f);
                return;
            }
            
            if(this.丗丑一丝一丒丝丄丆 > UnityEngine.Time.time)
            {
                goto label_42;
            }
            
            UnityEngine.Vector3 val_21 = this.三且丛丄专丛三与丑.randomPoint(上七不丈下下丛丘与:  V11.16B);
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.丗丑一丝一丒丝丄丆, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z})) == false)
            {
                goto label_42;
            }
            
            float val_32 = this.丗丑一丝一丒丝丄丆;
            val_32 = val_32 + 25f;
            if(UnityEngine.Time.time <= val_32)
            {
                goto label_36;
            }
            
            goto label_37;
            label_29:
            float val_33 = UnityEngine.Time.time;
            float val_25 = this.丄下丙丑丟丅东东丌(丕丁且丑业丄丁丗丕:  val_14);
            val_25 = val_25 / this.三丗一丘丘丒丄丗丆;
            val_33 = val_33 + val_25;
            if((System.Single.IsPositiveInfinity(f:  val_33)) == true)
            {
                    return;
            }
            
            this.专丙且七丝丏丞丌下(业下丌下三丕丙丌下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_27 = this.三且丛丄专丛三与丑.randomPoint(上七不丈下下丛丘与:  val_15.y);
            mem[1152921540800762808] = val_27.x;
            mem[1152921540800762812] = val_27.y;
            mem[1152921540800762816] = val_27.z;
            this.丗丑一丝一丒丝丄丆 = val_33;
            this.丗丂丂丞上丙丄丏丘 = false;
            mem[1152921540800762841] = 1;
            goto label_42;
            label_36:
            UnityEngine.Vector3 val_28 = this.三且丛丄专丛三与丑.randomPoint(上七不丈下下丛丘与:  this.丗丑一丝一丒丝丄丆);
            if((this.丙丛三三与丁丄一万(业下丌下三丕丙丌下:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z})) == false)
            {
                goto label_42;
            }
            
            mem[1152921540800762844] = UnityEngine.Random.Range(min:  -1f, max:  1f);
            goto label_43;
            label_21:
        }
        internal override void 三万上七丛丁业丑与()
        {
            static_value_082C7030 + 24.autoBraking = true;
            if(((static_value_082C7030 + 24) != 0) && ((static_value_082C7030 + 24 + 64) != 0))
            {
                    if((static_value_082C7030 + 24 + 64 + 64 + 48) != 0)
            {
                    bool val_4 = UnityEngine.Object.op_Inequality(x:  static_value_082C7030 + 24 + 64 + 64 + 48 + 64 + 48 + 96, y:  0);
            }
            
            }
            
            static_value_082C7030 + 24 + 64 + 64 + 48 + 64 + 48 + 96 + 64 + 48 + 48 + 24.speed = 丁丈丑丈专丒丅丏丞(下丐世三丌丘丁东丟:  this.三丗一丘丘丒丄丗丆);
            this.丗且丝丘丗丞七世丆 = 0;
            mem[1152921540800956760] = 0;
        }
        public 丂七丟丐丈丘丑且丕()
        {
            this.丅丞七专丕丄七丙丝 = 10f;
            this.三丗一丘丘丒丄丗丆 = 6.5f;
            this.丛丑丑丐业丄丙丌不 = 1f;
            val_1 = new System.Object();
        }
        private static 丂七丟丐丈丘丑且丕()
        {
            PlayerBot.丂七丟丐丈丘丑且丕.且丆丅丆丆丏三丛丛 = new System.Collections.Generic.List<PlayerBotPath>(capacity:  100);
        }
    
    }

}
