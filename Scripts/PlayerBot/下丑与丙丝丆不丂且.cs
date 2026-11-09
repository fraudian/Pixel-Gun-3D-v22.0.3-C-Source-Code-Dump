using UnityEngine;

namespace PlayerBot
{
    internal class 下丑与丙丝丆不丂且 : 丁丘丄丞丂丏丑丙丝
    {
        // Fields
        private UnityEngine.Vector3 丟丞丁丅丝丆万丌丆;
        private float 丌一丈丑丁且丞丝三;
        private float 一万丑丘丏下丁丑三;
        private bool 丒七丈丒七与万东一;
        private float 上不且丅丛丈与丑一;
        private float 与三丛丛丈东万丝业;
        
        // Methods
        internal override void 丌一七丌丄丌七上丞(PlayerBot.AIBotController 丒专丈丛下丒一丒丛)
        {
            this.丌一七丌丄丌七上丞(丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
            if(丒专丈丛下丒一丒丛 != null)
            {
                    this.上不且丅丛丈与丑一 = 丒专丈丛下丒一丒丛.dodgingTime;
            }
            else
            {
                    this.上不且丅丛丈与丑一 = 0f;
            }
            
            this.与三丛丛丈东万丝业 = 丒专丈丛下丒一丒丛.dodgingSpeed;
            this.丌一丈丑丁且丞丝三 = ;
            this.一万丑丘丏下丁丑三 = ;
        }
        internal override void 丑丁业不丏丆丞丞一()
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            bool val_1 = static_value_082C7040 + 24.isMine;
            if(X21 == 0)
            {
                goto label_5;
            }
            
            if(val_1 == false)
            {
                goto label_6;
            }
            
            label_16:
            if((X21 + 56 + 40) == 0)
            {
                goto label_30;
            }
            
            var val_28 = X21 + 56 + 56 + 40;
            val_24 = 1152921505345130496;
            if((X21 + 56 + 56 + 40 + 286) == 0)
            {
                goto label_15;
            }
            
            var val_26 = X21 + 56 + 56 + 40 + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_14:
            if(((X21 + 56 + 56 + 40 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (X21 + 56 + 56 + 40 + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_5:
            if(val_1 == true)
            {
                goto label_16;
            }
            
            label_6:
            if((X21 + 64 + 40) == 0)
            {
                goto label_30;
            }
            
            val_26 = X21 + 64 + 40 + 64 + 40.transform;
            if(val_26 != null)
            {
                goto label_38;
            }
            
            goto label_25;
            label_13:
            val_28 = val_28 + (((X21 + 56 + 56 + 40 + 176 + 8)) << 4);
            val_25 = val_28 + 296;
            label_15:
            if(((X21 + 56 + 56 + 40.BotTargetIsDead) == true) || ((X21 + 56 + 56 + 40 + 64 + 24.isMine) == false))
            {
                goto label_30;
            }
            
            var val_32 = X21 + 56 + 56 + 40 + 64 + 24 + 56 + 40;
            if((X21 + 56 + 56 + 40 + 64 + 24 + 56 + 40 + 286) == 0)
            {
                goto label_37;
            }
            
            var val_29 = X21 + 56 + 56 + 40 + 64 + 24 + 56 + 40 + 176;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_36:
            if(((X21 + 56 + 56 + 40 + 64 + 24 + 56 + 40 + 176 + 8) + -8) == null)
            {
                goto label_35;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (X21 + 56 + 56 + 40 + 64 + 24 + 56 + 40 + 286))
            {
                goto label_36;
            }
            
            goto label_37;
            label_30:
            if((X21 + 56) != 0)
            {
                goto label_38;
            }
            
            label_25:
            label_38:
            UnityEngine.Vector3 val_6 = X21 + 56.position;
            label_87:
            mem[1152921540802755480] = val_6.x;
            mem[1152921540802755484] = val_6.y;
            mem[1152921540802755488] = val_6.z;
            return;
            label_35:
            var val_31 = val_29;
            val_31 = val_31 + 2;
            val_32 = val_32 + val_31;
            val_27 = val_32 + 296;
            label_37:
            UnityEngine.Transform val_7 = X21 + 56 + 56 + 40 + 64 + 24 + 56 + 40.BotTargetTransform;
            UnityEngine.Vector3 val_8 = val_7.position;
            if((this.三丌与丁丞丘不丗七(丅丌丛东上丘丒丐下:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) == false)
            {
                goto label_40;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            if(val_7.BotTargetIsDead == false)
            {
                goto label_48;
            }
            
            label_40:
            if(val_7.上丛世丟丐上丌东东() == false)
            {
                goto label_50;
            }
            
            if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().三丒丟丑三万丗专丛(丑万世丂专丈丌业且:  1152921505345130496.__il2cppRuntimeField_7C)) == false)
            {
                    return;
            }
            
            if(this.丅一三丞丞且丅丗丅() == false)
            {
                    return;
            }
            
            if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().下丝东丆丒丆一且丌(丑万世丂专丈丌业且:  1152921505345130496.__il2cppRuntimeField_7C + 124)) == true)
            {
                goto label_61;
            }
            
            goto label_73;
            label_50:
            if((上且下一丁丑丑丟丟.丑七不且上丗丁一世().与上不丈丑丒丐上丛(丑万世丂专丈丌业且:  1152921505345130496.__il2cppRuntimeField_7C)) == false)
            {
                    return;
            }
            
            if(this.丅一三丞丞且丅丗丅() == false)
            {
                    return;
            }
            
            上且下一丁丑丑丟丟 val_21 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if((val_21.与丂三业丂上丐且丑(丑万世丂专丈丌业且:  1152921505345130496.__il2cppRuntimeField_7C + 124)) == false)
            {
                goto label_73;
            }
            
            label_61:
            val_21.丕丗丁丄专丏三东不();
            label_73:
            mem2[0] = 1;
            return;
            label_48:
            this.丟丞丁丅丝丆万丌丆 = val_8;
            mem[1152921540802755524] = val_8.y;
            mem[1152921540802755528] = val_8.z;
            var val_34 = 0;
            val_34 = val_34 + 1;
            UnityEngine.Vector3 val_25 = this.丑东丕丁丝丅且丏丗(业丟七丕东上丁丘丑:  val_7.BotTargetTransform);
            goto label_87;
        }
        private bool 三丌与丁丞丘不丗七(UnityEngine.Vector3 丅丌丛东上丘丒丐下)
        {
            var val_8;
            float val_9;
            var val_10;
            val_8 = this;
            UnityEngine.Vector3 val_2 = X21.position;
            val_9 = val_2.x;
            if(上丛世丟丐上丌东东() == false)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 丅丌丛东上丘丒丐下.x, y = 丅丌丛东上丘丒丐下.y, z = 丅丌丛东上丘丒丐下.z});
            if(val_3.x >= 6f)
            {
                goto label_10;
            }
            
            goto label_18;
            label_3:
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = 丅丌丛东上丘丒丐下.x, y = 丅丌丛东上丘丒丐下.y, z = 丅丌丛东上丘丒丐下.z});
            if(val_4.x <= 4f)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.丟丞丁丅丝丆万丌丆, y = val_2.y, z = val_9}, b:  new UnityEngine.Vector3() {x = 丅丌丛东上丘丒丐下.x, y = 丅丌丛东上丘丒丐下.y, z = 丅丌丛东上丘丒丐下.z});
            if(val_5.x <= 25f)
            {
                goto label_18;
            }
            
            val_8 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            if((val_8.三丅丈丆丐丏丑丙丏(丑万世丂专丈丌业且:  val_1 + 124)) == false)
            {
                goto label_18;
            }
            
            label_10:
            val_10 = 1;
            return (bool)val_10;
            label_18:
            val_10 = 0;
            return (bool)val_10;
        }
        private UnityEngine.Vector3 丑东丕丁丝丅且丏丗(UnityEngine.Transform 业丟七丕东上丁丘丑)
        {
            float val_70;
            float val_71;
            var val_72;
            float val_76;
            float val_77;
            float val_78;
            float val_79;
            float val_80;
            float val_81;
            float val_82;
            var val_83;
            UnityEngine.Object val_84;
            System.Collections.Generic.List<PlayerBotPath> val_85;
            if(上丛世丟丐上丌东东() == false)
            {
                goto label_2;
            }
            
            UnityEngine.Vector3 val_2 = 业丟七丕东上丁丘丑.position;
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.Vector3 val_4 = 业丟七丕东上丁丘丑.position;
            val_70 = val_4.x;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_70, y = val_4.y, z = val_4.z});
            val_71 = val_5.y;
            val_72 = mem[this.丟丞丁丅丝丆万丌丆 + 48];
            label_99:
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_71, z = val_5.z}, d:  val_72.三专丗七丂丈不与下() * 0.8f);
            val_76 = val_2.x;
            val_77 = val_2.y;
            val_78 = val_2.z;
            goto label_11;
            label_2:
            UnityEngine.Vector3 val_9 = position;
            UnityEngine.Vector3 val_10 = 业丟七丕东上丁丘丑.position;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = 业丟七丕东上丁丘丑.position;
            UnityEngine.Vector3 val_13 = position;
            val_70 = val_13.x;
            UnityEngine.Vector3 val_14 = 业丟七丕东上丁丘丑.position;
            if(val_11.x <= 25f)
            {
                goto label_19;
            }
            
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_70, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_71 = val_15.y;
            val_72 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_71, z = val_15.z}, d:  val_72.丘丟丁不下丛不丅丑(丑万世丂专丈丌业且:  业丟七丕东上丁丘丑));
            val_77 = val_12.y;
            val_76 = val_12.x;
            val_78 = val_12.z;
            label_11:
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_76, y = val_77, z = val_78}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            label_19:
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_70, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            上且下一丁丑丑丟丟 val_21 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世();
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, d:  val_21.丘丟丁不下丛不丅丑(丑万世丂专丈丌业且:  X22 + 124));
            val_79 = val_12.y;
            val_80 = val_12.x;
            val_81 = val_12.z;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_80, y = val_79, z = val_81}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            val_82 = val_24.y;
            UnityEngine.Vector3 val_25 = val_21.position;
            if((UnityEngine.AI.NavMesh.Raycast(sourcePosition:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, targetPosition:  new UnityEngine.Vector3() {x = val_24.x, y = val_82, z = val_24.z}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f}, areaMask:  0)) == true)
            {
                    return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            }
            
            val_83 = 0;
            val_84 = 0;
            goto label_34;
            label_64:
            PlayerBotPathsManager val_27 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            UnityEngine.Transform val_29 = val_27.wayPoints.Item[0].transform;
            UnityEngine.Vector3 val_30 = val_29.position;
            val_82 = val_30.y;
            UnityEngine.Vector3 val_31 = val_29.position;
            val_80 = val_30.x;
            val_79 = val_82;
            val_81 = val_30.z;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_80, y = val_79, z = val_81}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            PlayerBotPathsManager val_33 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            PlayerBotPathWayPoint val_34 = val_33.wayPoints.Item[0];
            if(val_34.startedPaths != null)
            {
                    PlayerBotPathsManager val_35 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                PlayerBotPathWayPoint val_36 = val_35.wayPoints.Item[0];
                if((val_32.x < 0) && (val_36.startedPaths.Count >= 1))
            {
                    PlayerBotPathsManager val_38 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                val_84 = val_38.wayPoints.Item[0];
            }
            
            }
            
            val_83 = 1;
            label_34:
            PlayerBotPathsManager val_40 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_83 < val_40.wayPoints.Count)
            {
                goto label_64;
            }
            
            PlayerBotPathsManager val_42 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_42.wayPoints == null)
            {
                goto label_73;
            }
            
            PlayerBotPathsManager val_43 = PlayerBotPathsManager.与一丅丝不丈业与丙();
            if(val_43.wayPoints.Count <= 0)
            {
                goto label_73;
            }
            
            if(val_84 == 0)
            {
                    PlayerBotPathsManager val_46 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                PlayerBotPathsManager val_47 = PlayerBotPathsManager.与一丅丝不丈业与丙();
                val_84 = val_46.wayPoints.Item[UnityEngine.Random.Range(min:  0, max:  val_47.wayPoints.Count)];
            }
            
            if(PlayerBotPathsManager.与一丅丝不丈业与丙().丈业三一东丄下上丆() == false)
            {
                goto label_87;
            }
            
            UnityEngine.Vector3 val_53 = val_50.丛丄与丌丛万业丝丞.position;
            return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            label_73:
            UnityEngine.Vector3 val_54 = 业丟七丕东上丁丘丑.position;
            UnityEngine.Vector3 val_55 = val_84.position;
            UnityEngine.Vector3 val_56 = 业丟七丕东上丁丘丑.position;
            UnityEngine.Vector3 val_57 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, b:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z});
            float val_59 = 上且下一丁丑丑丟丟.丑七不且上丗丁一世().丘丟丁不下丛不丅丑(丑万世丂专丈丌业且:  业丟七丕东上丁丘丑);
            goto label_99;
            label_87:
            val_85 = val_50.startedPaths;
            if(val_84 == null)
            {
                    val_85 = val_50.startedPaths;
            }
            
            PlayerBotPath val_62 = val_50.startedPaths.Item[UnityEngine.Random.Range(min:  0, max:  val_85.Count)];
            PlayerBotPathPoint val_65 = val_62.points.Item[UnityEngine.Random.Range(min:  0, max:  val_62.points.Count)];
            return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        }
        private System.Collections.IEnumerator 世丐丅且一丐丐丒丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 下丑与丙丝丆不丂且.丛丕七丒不不丅专丁();
        }
        private bool 丅一三丞丞且丅丗丅()
        {
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            bool val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            var val_38;
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Vector3 val_3 = right;
            if(UnityEngine.Random.value < 0)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.与三丛丛丈东万丝业);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.上不且丅丛丈与丑一);
                val_28 = val_1.x;
                val_29 = val_1.y;
                val_30 = val_1.z;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                val_31 = val_6.x;
                val_32 = val_6.z;
                val_33 = 1;
            }
            else
            {
                    UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.与三丛丛丈东万丝业);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.上不且丅丛丈与丑一);
                val_28 = val_1.x;
                val_29 = val_1.y;
                val_30 = val_1.z;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_31 = val_10.x;
                val_32 = val_10.z;
                val_33 = false;
            }
            
            UnityEngine.Vector3 val_11 = 0.position;
            this.丒七丈丒七与万东一 = val_33;
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_31, y = val_11.y, z = val_32}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            int val_19 = Rilisoft.与丄丁丄丙丞下下丙.与万与一不丌丈业丞();
            UnityEngine.Vector3 val_21 = val_19.position;
            if((static_value_082C7040 + 48.七与丆一丏下丏七不(不万专丐世丒丆丆下:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, 丂七丑世丏丐丅不丌: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, 丏上万丅丏一不不丕:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}), 丄丏且业丏丟且丂丁:  val_19)) != false)
            {
                    UnityEngine.Vector3 val_22 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                val_34 = val_23.x;
                val_35 = val_23.z;
                UnityEngine.Color val_24 = UnityEngine.Color.red;
                val_36 = val_24.g;
                val_37 = val_24.a;
                UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_34, y = val_23.y, z = val_35}, end:  new UnityEngine.Vector3() {x = val_31, y = val_11.y, z = val_32}, color:  new UnityEngine.Color() {r = val_24.r, g = val_24.b});
                val_38 = 0;
                return (bool)val_38;
            }
            
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            val_37 = val_26.x;
            val_34 = val_26.z;
            UnityEngine.Color val_27 = UnityEngine.Color.green;
            val_36 = val_27.g;
            val_35 = val_27.a;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, end:  new UnityEngine.Vector3() {x = val_37, y = val_26.y, z = val_34}, color:  new UnityEngine.Color() {r = val_27.r, g = val_27.b, a = val_26.x});
            val_38 = 1;
            mem[1152921540803551704] = val_31;
            mem[1152921540803551708] = val_11.y;
            mem[1152921540803551712] = val_32;
            return (bool)val_38;
        }
        internal override void 三万上七丛丁业丑与()
        {
            if(X20 == 0)
            {
                
            }
        
        }
        public 下丑与丙丝丆不丂且()
        {
            this.上不且丅丛丈与丑一 = 0.7f;
            this.与三丛丛丈东万丝业 = 5f;
            val_1 = new System.Object();
        }
    
    }

}
