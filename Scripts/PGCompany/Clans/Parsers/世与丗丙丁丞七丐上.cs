using UnityEngine;

namespace PGCompany.Clans.Parsers
{
    public abstract class 世与丗丙丁丞七丐上 : 丆丄丁一丌丁丄丙丝
    {
        // Methods
        protected abstract 丞丂丘丒丟丞丑下丄 一丅丆丘丁丅丕丁丗(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄); // 0
        public 丞丂丘丒丟丞丑下丄 与丛丆专东丐一且丅(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            this.丌丟万丛丙上丁丆丘(且丟丅丄丒丑丂丁世:  this);
            return (丞丂丘丒丟丞丑下丄)this;
        }
        private void 丌丟万丛丙上丁丆丘(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            if(且丟丅丄丒丑丂丁世 == null)
            {
                    return;
            }
            
            if(且丟丅丄丒丑丂丁世.丐丂丄丏下七与一丌().Count == 且丟丅丄丒丑丂丁世.丄丑丙万丌丂一丄丙)
            {
                    且丟丅丄丒丑丂丁世.上丟下丌丞业丞专丄().Clear();
                且丟丅丄丒丑丂丁世.上丞东丌丐世与业丕().Clear();
            }
            
            PGCompany.Clans.Parsers.世与丗丙丁丞七丐上.三万丙丆丗万业三一(且丟丅丄丒丑丂丁世:  且丟丅丄丒丑丂丁世);
            PGCompany.Clans.Parsers.世与丗丙丁丞七丐上.万丄与业七专东世丑(且丟丅丄丒丑丂丁世:  且丟丅丄丒丑丂丁世);
        }
        protected 丞丂丘丒丟丞丑下丄 业一丐一丙丌万丙丟(System.Collections.Generic.Dictionary<string, object> 万丟万丟万丂丑丝世)
        {
            var val_39;
            string val_40;
            var val_41;
            string val_42;
            string val_1 = 0;
            int val_4 = 0;
            string val_6 = 0;
            string val_8 = 0;
            int val_14 = 0;
            int val_17 = 0;
            string val_21 = 0;
            string val_19 = 0;
            string val_25 = 0;
            string val_23 = 0;
            int val_31 = 0;
            string val_29 = 0;
            bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_1);
            val_39 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return (丞丂丘丒丟丞丑下丄)val_39;
            }
            
            bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "type", 丙业与丙丗丝不丈东: out  val_4);
            bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "name", 丙业与丙丗丝不丈东: out  val_6);
            bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "creator_id", 丙业与丙丗丝不丈东: out  val_8);
            bool val_11 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "sieges_won", 丙业与丙丗丝不丈东: out  0);
            bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Boolean>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "siege_party", 丙业与丙丗丝不丈东: out  false);
            bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "shields", 丙业与丙丗丝不丈东: out  val_14);
            bool val_16 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "division", 丙业与丙丗丝不丈东: out  val_14);
            bool val_18 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "members_cnt", 丙业与丙丗丝不丈东: out  val_17);
            bool val_20 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "slogan", 丙业与丙丗丝不丈东: out  val_19);
            bool val_22 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "logo", 丙业与丙丗丝不丈东: out  val_21);
            bool val_24 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "logo_hash", 丙业与丙丗丝不丈东: out  val_23);
            bool val_26 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "leader_message", 丙业与丙丗丝不丈东: out  val_25);
            bool val_28 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "clan_war_wins", 丙业与丙丗丝不丈东: out  0);
            bool val_30 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "continent", 丙业与丙丗丝不丈东: out  val_29);
            bool val_32 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "min_rank", 丙业与丙丗丝不丈东: out  val_31);
            bool val_33 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丟万丟万丂丑丝世, 下上丐丆丝丟丝丒不:  "pr", 丙业与丙丗丝不丈东: out  val_31);
            丞丂丘丒丟丞丑下丄 val_34 = null;
            val_39 = val_34;
            val_34 = new 丞丂丘丒丟丞丑下丄(丞丅上丏丂且下丅与:  val_1, 丒丘丏上丙丟丑丕丈:  val_6, 丌万丌丅丐丗丘专丒:  val_8, 丁丅丈丌丟世丗丗丟:  val_4);
            if(val_39 != null)
            {
                    val_34.丛丏丛丄丗丆万丙丌(丙业与丙丗丝不丈东:  0);
                val_34.丗丑且丙上丂丅三上(丙业与丙丗丝不丈东:  val_19);
                val_34.丗世丟丟丄与七业丞(丙业与丙丗丝不丈东:  0);
                val_34.丑丌丞丞与丆丂不丘(丙业与丙丗丝不丈东:  false);
                val_34.丁丐七丘且丗丘业七(丙业与丙丗丝不丈东:  0);
                val_34.丟上上丆丝业不丂下(丙业与丙丗丝不丈东:  val_25);
                val_34.丅丈丄且丕丝业七丒(丙业与丙丗丝不丈东:  0);
                val_40 = val_29;
            }
            else
            {
                    val_34.丛丏丛丄丗丆万丙丌(丙业与丙丗丝不丈东:  0);
                val_34.丗丑且丙上丂丅三上(丙业与丙丗丝不丈东:  val_19);
                val_34.丗世丟丟丄与七业丞(丙业与丙丗丝不丈东:  0);
                val_34.丑丌丞丞与丆丂不丘(丙业与丙丗丝不丈东:  false);
                val_34.丁丐七丘且丗丘业七(丙业与丙丗丝不丈东:  0);
                val_34.丟上上丆丝业不丂下(丙业与丙丗丝不丈东:  val_25);
                val_34.丅丈丄且丕丝业七丒(丙业与丙丗丝不丈东:  0);
                val_40 = val_29;
            }
            
            val_34.丏丙丅与世丁丟丏三(丙业与丙丗丝不丈东:  val_40);
            int val_35 = (0 != 0) ? 0 : (0 + 1);
            if(val_39 != null)
            {
                    val_34.专丙丌丙丁三丕三丅(丙业与丙丗丝不丈东:  val_35);
                val_34.且丅丘东业丑丗三业(丙业与丙丗丝不丈东:  (0 != 0) ? 1 : 0);
                .不一一丙丘专丟丌丌 = 0;
                val_41 = 0;
            }
            else
            {
                    val_34.专丙丌丙丁三丕三丅(丙业与丙丗丝不丈东:  val_35);
                val_34.且丅丘东业丑丗三业(丙业与丙丗丝不丈东:  (0 != 0) ? 1 : 0);
                mem[440] = val_17;
                val_41 = 0;
            }
            
            val_34.丁丄丅丐丙丏丄丆丌(丙业与丙丗丝不丈东:  0);
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_21)) == false)
            {
                    return (丞丂丘丒丟丞丑下丄)val_39;
            }
            
            if(val_39 != null)
            {
                    val_34.丑丛丟丗专丈丄专丞(丙业与丙丗丝不丈东:  val_21);
                val_42 = val_23;
            }
            else
            {
                    val_34.丑丛丟丗专丈丄专丞(丙业与丙丗丝不丈东:  val_21);
                val_42 = val_23;
            }
            
            val_34.丏三上丗丘万丟丝三(丙业与丙丗丝不丈东:  val_42);
            return (丞丂丘丒丟丞丑下丄)val_39;
        }
        protected 丞丂丘丒丟丞丑下丄 丌丕丐丟万一不丙东(System.Collections.Generic.IEnumerable<object> 丐丏丘丄七一丆东万, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            string val_42;
            var val_43;
            var val_44;
            int val_12 = 0;
            string val_10 = 0;
            int val_18 = 0;
            int val_15 = 0;
            var val_42 = 0;
            val_42 = val_42 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = 丐丏丘丄七一丆东万.GetEnumerator();
            label_62:
            var val_43 = 0;
            val_43 = val_43 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_44 = 0;
            val_44 = val_44 + 1;
            T val_6 = val_2.Current;
            if(val_6 == 0)
            {
                goto label_62;
            }
            
            object val_7 = val_6.Item["id"];
            if(val_7 != null)
            {
                    var val_8 = (null == null) ? (val_7) : 0;
            }
            else
            {
                    val_42 = 0;
            }
            
            new 七丈丗不丞丈丝丙七() = new 七丈丗不丞丈丝丙七();
            new 七丈丗不丞丈丝丙七().下东丄丄丟丞东丁丅(丙业与丙丗丝不丈东:  val_42);
            bool val_11 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "nick", 丙业与丙丗丝不丈东: out  val_10);
            bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "role", 丙业与丙丗丝不丈东: out  val_12);
            bool val_14 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "details", 丙业与丙丗丝不丈东: out  val_12);
            bool val_16 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "war_score", 丙业与丙丗丝不丈东: out  val_15);
            bool val_17 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "rank", 丙业与丙丗丝不丈东: out  val_15);
            bool val_19 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "clan_rank", 丙业与丙丗丝不丈东: out  val_18);
            bool val_20 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "gems_up", 丙业与丙丗丝不丈东: out  val_18);
            bool val_22 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "join_time", 丙业与丙丗丝不丈东: out  0);
            new 七丈丗不丞丈丝丙七().丌丏上丏东且丄丑丌(丙业与丙丗丝不丈东:  val_10);
            new 七丈丗不丞丈丝丙七().七专上丙七丆丛七丒(丙业与丙丗丝不丈东:  ((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  0)) != true) ? 0 : (!0));
            string val_45 = new 七丈丗不丞丈丝丙七().业丐丐三丕一丗丛丁();
            val_45 = 且丟丅丄丒丑丂丁世.丛丛上丕丁丁七一不(丄丒且丙三丆丟与丏:  val_45);
            new 七丈丗不丞丈丝丙七().丝丟丝三丛专丕世丗(丙业与丙丗丝不丈东:  val_45);
            new 七丈丗不丞丈丝丙七().专丙丑丁丗丘丛丗丕(丙业与丙丗丝不丈东:  0);
            new 七丈丗不丞丈丝丙七().业七丕下丌七丌下且(丙业与丙丗丝不丈东:  0);
            new 七丈丗不丞丈丝丙七().世丈丁丂丞丙丞丑丝(丙业与丙丗丝不丈东:  0);
            new 七丈丗不丞丈丝丙七().三三丟丞丁丟丆下丗(丙业与丙丗丝不丈东:  0);
            new 七丈丗不丞丈丝丙七().丁丄丕丁丈业丙丁一(丙业与丙丗丝不丈东:  0);
            new 七丈丗不丞丈丝丙七().七丕丞丟丗丟三丆万(丙业与丙丗丝不丈东:  0);
            if((System.String.op_Equality(a:  new 七丈丗不丞丈丝丙七().业丐丐三丕一丗丛丁(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    new 七丈丗不丞丈丝丙七().丌丏上丏东且丄丑丌(丙业与丙丗丝不丈东:  ProfileController.丆三丂丂丆上丆丕专());
                new 七丈丗不丞丈丝丙七().世丈丁丂丞丙丞丑丝(丙业与丙丗丝不丈东:  ExperienceController.丞丞丘业东丙丏七丌());
                new 七丈丗不丞丈丝丙七().丁丄丕丁丈业丙丁一(丙业与丙丗丝不丈东:  丌丅且丗七丘丅丛丑.不一丈一丗丂丁东与());
            }
            
            if((且丟丅丄丒丑丂丁世.丛丛上丕丁丁七一不(丄丒且丙三丆丟与丏:  new 七丈丗不丞丈丝丙七().业丐丐三丕一丗丛丁())) != false)
            {
                    且丟丅丄丒丑丂丁世.与不丟丁丂丆丑丆丁(丙业与丙丗丝不丈东:  new 七丈丗不丞丈丝丙七().东丙上东业丆不丟丘());
            }
            
            且丟丅丄丒丑丂丁世.丙世不世三丁东专丏(丛上丅丑东丞丄不丁:  new 七丈丗不丞丈丝丙七());
            且丟丅丄丒丑丂丁世.丙丆丞东丆丏丞一不().Add(item:  new 七丈丗不丞丈丝丙七());
            丂与专万与丐丌丏不.丑七不且上丗丁一世().丆东丗与东丑丘且三(丄丒且丙三丆丟与丏:  new 七丈丗不丞丈丝丙七().业丐丐三丕一丗丛丁(), 不丆业丏上丐与丌业:  new 七丈丗不丞丈丝丙七().东丙上东业丆不丟丘());
            goto label_62;
            label_11:
            val_43 = 0;
            val_44 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_46 = 0;
                val_46 = val_46 + 1;
                val_2.Dispose();
            }
            
            if( != 1)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            if( == false)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 万丅东丏丘丐丑丟与(System.Collections.Generic.IEnumerable<object> 丑与丁丄丏丕丗丛丒, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            var val_14;
            var val_15;
            string val_9 = 0;
            string val_7 = 0;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = 丑与丁丄丏丕丗丛丒.GetEnumerator();
            label_26:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            T val_6 = val_2.Current;
            if(val_6 == 0)
            {
                goto label_26;
            }
            
            bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_7);
            bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_6, 下上丐丆丝丟丝丒不:  "message", 丙业与丙丗丝不丈东: out  val_9);
            if((val_7 == 0) || (val_9 == 0))
            {
                goto label_26;
            }
            
            new 丅下丙一东丄丕丛下() = new 丅下丙一东丄丕丛下(下丛丄丅丝丄丏丛丑:  val_7, 丄丙下丝丛丒七丂丘:  val_9);
            且丟丅丄丒丑丂丁世.上丟下丌丞业丞专丄().Add(item:  new 丅下丙一东丄丕丛下());
            goto label_26;
            label_11:
            val_14 = 0;
            val_15 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_2.Dispose();
            }
            
            if( != 1)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            if( == false)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 七丞万丆丐丘丁一丒(System.Collections.Generic.IEnumerable<object> 丛三丆世不丞丈业丟, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_10 = 0;
            val_10 = val_10 + 1;
            System.Collections.Generic.IEnumerator<T> val_2 = 丛三丆世不丞丈业丟.GetEnumerator();
            label_21:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            T val_6 = val_2.Current;
            if(val_6 != 0)
            {
                    var val_8 = (val_6 == null) ? (val_6) : 0;
            }
            else
            {
                    val_10 = 0;
            }
            
            且丟丅丄丒丑丂丁世.上丞东丌丐世与业丕().Add(item:  val_10);
            goto label_21;
            label_11:
            val_11 = 0;
            val_12 = 0;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_2.Dispose();
            }
            
            if( != 1)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            if( == false)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 世丅下下东万丕丛不(System.Collections.Generic.Dictionary<string, object> 丅丛丌不丗丏丞丝丌, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            下一丐东一丗且丒丐.丑七不且上丗丁一世().丙下丗丐专丂万丑不(丑丈万一下丗丘丄丘:  丅丛丌不丗丏丞丝丌);
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 丁不丏与丈丐丐丛下(System.Collections.Generic.List<object> 丄丐不丏丁丘不丒丈, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            且丟丅丄丒丑丂丁世.丐丌与丏丂东业业上().七丛世丁丄丏七丗丁(丆世丑丌与且且且丗:  丄丐不丏丁丘不丒丈);
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 丝上丏丟丌丒一七丘(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            且丟丅丄丒丑丂丁世.丌丂专不丁七一丙丗().Clear();
            且丟丅丄丒丑丂丁世.丌丂专不丁七一丙丗().AddRange(collection:  世丛丝上丒丈丑东丟.业丌上丄丞东且丕丆(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄));
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 丏丗丂丂丆业丗业世(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            int val_4;
            var val_12;
            var val_13;
            且丟丅丄丒丑丂丁世.丟与且丙七丙丞下丏().Clear();
            List.Enumerator<T> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_15:
            if(((-577243792) & 1) == 0)
            {
                goto label_4;
            }
            
            int val_6 = System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上());
            if((丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞世不丒下上上丝丑:  val_6)) == null)
            {
                goto label_9;
            }
            
            new FortFieldItemInfo() = new FortFieldItemInfo(丒丘丏上丙丟丑丕丈:  val_7.name, 七丐丌上上万丘三丆:  val_7.subcategory);
            且丟丅丄丒丑丂丁世.丟与且丙七丙丞下丏().Add(item:  new FortFieldItemInfo());
            goto label_15;
            label_9:
            val_4 = val_6;
            UnityEngine.Debug.LogError(message:  "No PlaceableItemSettings with index: "("No PlaceableItemSettings with index: ") + val_4);
            goto label_15;
            label_4:
            val_12 = 0;
            val_13 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
                if(121 != 121)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
                return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            if( == 0)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 下丁丏三与万丏且丝(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            var val_4;
            丞丂丘丒丟丞丑下丄 val_13;
            int val_6 = 0;
            且丟丅丄丒丑丂丁世.丒丗不丙业丟丄丏丂().Clear();
            List.Enumerator<T> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_18:
            if(((-577040656) & 1) == 0)
            {
                goto label_4;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5 == null)
            {
                goto label_18;
            }
            
            bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_5, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  val_6);
            bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_5, 下上丐丆丝丟丝丒不:  "in", 丙业与丙丗丝不丈东: out  val_6);
            if((丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞世不丒下上上丝丑:  0)) == null)
            {
                goto label_12;
            }
            
            new ClanTankEquipInfo() = new ClanTankEquipInfo(下丁丒丕丅丄丂丛丅:  0, 与下丕三丒东上丗上:  val_9.name);
            且丟丅丄丒丑丂丁世.丒丗不丙业丟丄丏丂().Add(item:  new ClanTankEquipInfo());
            goto label_18;
            label_12:
            val_4 = 0;
            UnityEngine.Debug.LogError(message:  "No PlaceableItemSettings with index: "("No PlaceableItemSettings with index: ") + 0);
            goto label_18;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_13 = 且丟丅丄丒丑丂丁世;
            return (丞丂丘丒丟丞丑下丄);
        }
        protected 丞丂丘丒丟丞丑下丄 业丞丞丂丄丕七丐丞(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            var val_12;
            int val_9 = 0;
            bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "tank_level", 丙业与丙丗丝不丈东: out  0);
            bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "tank_points", 丙业与丙丗丝不丈东: out  0);
            bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "tank_energy", 丙业与丙丗丝不丈东: out  0);
            bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "field_level", 丙业与丙丗丝不丈东: out  0);
            bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "field_points", 丙业与丙丗丝不丈东: out  val_9);
            bool val_11 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "field_energy", 丙业与丙丗丝不丈东: out  val_9);
            if(且丟丅丄丒丑丂丁世 != null)
            {
                    且丟丅丄丒丑丂丁世.丛丙丄万三丙丂下丑(丙业与丙丗丝不丈东:  0);
                且丟丅丄丒丑丂丁世.东丌下七丝丛一丕丞(丙业与丙丗丝不丈东:  0);
                且丟丅丄丒丑丂丁世.丏丁丘专丑万丗丕丅(丙业与丙丗丝不丈东:  0);
                val_12 = 0;
            }
            else
            {
                    0.丛丙丄万三丙丂下丑(丙业与丙丗丝不丈东:  0);
                0.东丌下七丝丛一丕丞(丙业与丙丗丝不丈东:  0);
                0.丏丁丘专丑万丗丕丅(丙业与丙丗丝不丈东:  0);
                val_12 = 0;
            }
            
            且丟丅丄丒丑丂丁世.万且丕丒且下丌丛丘(丙业与丙丗丝不丈东:  0);
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 丗丅丙丐丐丙丁丙下(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            var val_6;
            var val_15;
            System.Collections.Generic.List<System.Object> val_1 = 0;
            int val_8 = 0;
            if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "items", 丙业与丙丗丝不丈东: out  val_1)) == false)
            {
                    return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, 与丑下丕丙丛丅一丈> val_3 = new System.Collections.Generic.Dictionary<System.Int32, 与丑下丕丙丛丅一丈>();
            val_15 = val_1;
            List.Enumerator<T> val_4 = val_15.GetEnumerator();
            label_14:
            if(((-576737040) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(val_7 == null)
            {
                goto label_14;
            }
            
            bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_7, 下上丐丆丝丟丝丒不:  "item_index", 丙业与丙丗丝不丈东: out  val_8);
            bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_7, 下上丐丆丝丟丝丒不:  "from_level", 丙业与丙丗丝不丈东: out  val_8);
            bool val_12 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_7, 下上丐丆丝丟丝丒不:  "finish_at", 丙业与丙丗丝不丈东: out  0);
            new 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈() = new 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈();
            new 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈().丞专丂丈丄丒丂丒丘(丙业与丙丗丝不丈东:  0);
            new 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈().丏东丅不丂丟上丝丆(丙业与丙丗丝不丈东:  0);
            val_3.set_Item(key:  0, value:  new 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈());
            goto label_14;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丂丘丗丗与且丌丁丙.一丘丟专业丙丅丗丒(丑七不与丛丆一丂丞:  val_3);
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 丞丂丘丒丟丞丑下丄 丑七丈万丗丞丐丂丑(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            var val_4;
            且丟丅丄丒丑丂丁世.东万丕丗丅万丄丘丙().世业丒万丘丆专丘丐();
            List.Enumerator<T> val_2 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_10:
            if(((-576579952) & 1) == 0)
            {
                goto label_4;
            }
            
            PGCompany.丕专丝与丐上丂东世 val_6 = PGCompany.七丄三丝丐业丄丅丝.丗万业丆丁专丑丘丑(丝三上丙丂丒业丘丘:  val_4.丐丏七丌丕丗业且上());
            if(val_6 == null)
            {
                goto label_10;
            }
            
            且丟丅丄丒丑丂丁世.东万丕丗丅万丄丘丙().丁东丗下上与且丌业(上丝丕丘丄一丏不丙:  val_6);
            goto label_10;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        internal static void 东丙专丆丄上上丄与(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            PGCompany.Clans.Parsers.世与丗丙丁丞七丐上.三万丙丆丗万业三一(且丟丅丄丒丑丂丁世:  且丟丅丄丒丑丂丁世);
            PGCompany.Clans.Parsers.世与丗丙丁丞七丐上.万丄与业七专东世丑(且丟丅丄丒丑丂丁世:  且丟丅丄丒丑丂丁世);
        }
        private static void 三万丙丆丗万业三一(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            goto label_1;
            label_12:
            ClanTankEquipInfo val_2 = 且丟丅丄丒丑丂丁世.丒丗不丙业丟丄丏丂().Item[0];
            PlaceableItemSettings val_3 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  val_2.itemSettingsId);
            if(val_3 != null)
            {
                    val_2.ServerLevel = 且丟丅丄丒丑丂丁世.丐丌与丏丂东业业上().一丞万丂丐专丛丟上(丟丘丙不丑一丁丙丗:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_3.Index));
            }
            
            0 = 1;
            label_1:
            if(0 < 且丟丅丄丒丑丂丁世.丒丗不丙业丟丄丏丂().Count)
            {
                goto label_12;
            }
        
        }
        private static void 万丄与业七专东世丑(丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            goto label_1;
            label_11:
            PlaceableItemSettings val_3 = 且丟丅丄丒丑丂丁世.丌丂专不丁七一丙丗().Item[0].ItemSettings;
            if(val_3 != null)
            {
                    val_2.ServerLevel = 且丟丅丄丒丑丂丁世.丐丌与丏丂东业业上().一丞万丂丐专丛丟上(丟丘丙不丑一丁丙丗:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_3.Index));
            }
            
            0 = 1;
            label_1:
            if(0 < 且丟丅丄丒丑丂丁世.丌丂专不丁七一丙丗().Count)
            {
                goto label_11;
            }
        
        }
        protected 丞丂丘丒丟丞丑下丄 丂丗业丌丞上万丙业(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄, 丞丂丘丒丟丞丑下丄 且丟丅丄丒丑丂丁世)
        {
            var val_4;
            且丟丅丄丒丑丂丁世.且业丞一上丕丅三丌.Clear();
            val_4 = 0;
            goto label_3;
            label_9:
            且丟丅丄丒丑丂丁世.且业丞一上丕丅三丌.Add(item:  System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item[0]));
            val_4 = 1;
            label_3:
            if(val_4 < 一丐丗丁丞丆丅丟丄.Count)
            {
                goto label_9;
            }
            
            return (丞丂丘丒丟丞丑下丄)且丟丅丄丒丑丂丁世;
        }
        protected 世与丗丙丁丞七丐上()
        {
        
        }
    
    }

}
