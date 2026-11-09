using UnityEngine;

namespace Rilisoft
{
    public class 丕丏专丛下七七丄东 : 丈上丛丕业丂丕丝世
    {
        // Methods
        public 丕丏专丛下七七丄东(Rilisoft.丆专且丆世丟丄与丂 丌万且丕丕业上丈丞)
        {
        
        }
        public override System.Collections.IEnumerator 三业丒丑丂三丕上丛(bool 丟东丈丗丏丛世万一, bool 且丏下一下上丟与丐)
        {
            丕丏专丛下七七丄东.丝且上丄丂丌丌丘丁 val_1 = new 丕丏专丛下七七丄东.丝且上丄丂丌丌丘丁();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丟东丈丗丏丛世万一 = 丟东丈丗丏丛世万一;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 丟东丈丗丏丛世万一;
            }
            
            .且丏下一下上丟与丐 = 且丏下一下上丟与丐;
            return (System.Collections.IEnumerator)val_1;
        }
        internal static Rilisoft.LobbyItemPlayerInfoSerializedObject 下一丛丞丘丛丗丅业(Rilisoft.LobbyItemPlayerInfoSerializedObject 丈丂丕下丏丈丞丗业, Rilisoft.LobbyItemPlayerInfoSerializedObject 丂丌丌丛丆丆丙丌丈)
        {
            var val_9;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.String> val_11;
            var val_12;
            System.Func<System.Linq.IGrouping<System.String, Rilisoft.LobbyItemPlayerInfo>, Rilisoft.LobbyItemPlayerInfo> val_14;
            val_9 = null;
            val_9 = null;
            val_11 = 丕丏专丛下七七丄东.<>c.<>9__2_0;
            if(val_11 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.String> val_2 = null;
                val_11 = val_2;
                val_2 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::上丞东丌三丝且丘丒(Rilisoft.LobbyItemPlayerInfo 下丅丙一丂丗丅丝七));
                丕丏专丛下七七丄东.<>c.<>9__2_0 = val_11;
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = 丕丏专丛下七七丄东.<>c.<>9__2_1;
            if(val_14 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, Rilisoft.LobbyItemPlayerInfo>, Rilisoft.LobbyItemPlayerInfo> val_4 = null;
                val_14 = val_4;
                val_4 = new System.Func<System.Linq.IGrouping<System.String, Rilisoft.LobbyItemPlayerInfo>, Rilisoft.LobbyItemPlayerInfo>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.LobbyItemPlayerInfo 丕丏专丛下七七丄东.<>c::丈与一专丈丗丌丕丏(System.Linq.IGrouping<string, Rilisoft.LobbyItemPlayerInfo> 不一丅丛一丈且丕丆));
                丕丏专丛下七七丄东.<>c.<>9__2_1 = val_14;
            }
            
            .Infos = System.Linq.Enumerable.ToList<Rilisoft.LobbyItemPlayerInfo>(source:  System.Linq.Enumerable.Select<System.Linq.IGrouping<System.String, Rilisoft.LobbyItemPlayerInfo>, Rilisoft.LobbyItemPlayerInfo>(source:  System.Linq.Enumerable.GroupBy<Rilisoft.LobbyItemPlayerInfo, System.String>(source:  System.Linq.Enumerable.Concat<Rilisoft.LobbyItemPlayerInfo>(first:  丈丂丕下丏丈丞丗业.Infos, second:  丂丌丌丛丆丆丙丌丈.Infos), keySelector:  val_2), selector:  val_4));
            return (Rilisoft.LobbyItemPlayerInfoSerializedObject)new Rilisoft.LobbyItemPlayerInfoSerializedObject();
        }
        private bool 且上世丅世上丄丄丁(Rilisoft.LobbyItemPlayerInfoSerializedObject 且丕万丞丏世丄上丗, Rilisoft.LobbyItemPlayerInfoSerializedObject 丂丆东上丂丏丟下专)
        {
            System.Collections.Generic.IEnumerable<TSource> val_26;
            var val_27;
            System.Collections.Generic.IEnumerable<TSource> val_28;
            var val_29;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.String> val_31;
            var val_32;
            System.Func<System.String, System.String> val_34;
            var val_35;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.String> val_37;
            var val_38;
            System.Func<System.String, System.String> val_40;
            var val_41;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_43;
            var val_44;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo>> val_46;
            var val_47;
            System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.String> val_49;
            var val_50;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_52;
            var val_53;
            System.Func<Rilisoft.LobbyItemPlayerInfo, System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo>> val_55;
            var val_56;
            var val_58;
            val_26 = 丂丆东上丂丏丟下专;
            val_27 = 1152921542441411904;
            val_28 = 且丕万丞丏世丄上丗.Infos.Count;
            if(val_28 == 丂丆东上丂丏丟下专.Infos.Count)
            {
                    val_29 = null;
                val_29 = null;
                val_31 = 丕丏专丛下七七丄东.<>c.<>9__3_0;
                if(val_31 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.String> val_3 = null;
                val_31 = val_3;
                val_3 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::专与丒世丁且与三丏(Rilisoft.LobbyItemPlayerInfo 下丅丙一丂丗丅丝七));
                丕丏专丛下七七丄东.<>c.<>9__3_0 = val_31;
            }
            
                val_32 = null;
                val_32 = null;
                val_34 = 丕丏专丛下七七丄东.<>c.<>9__3_1;
                if(val_34 == null)
            {
                    System.Func<System.String, System.String> val_5 = null;
                val_34 = val_5;
                val_5 = new System.Func<System.String, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::下业上丄三丟丐丏万(string 丞丅上丏丂且下丅与));
                丕丏专丛下七七丄东.<>c.<>9__3_1 = val_34;
            }
            
                val_35 = null;
                val_28 = System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.LobbyItemPlayerInfo, System.String>(source:  且丕万丞丏世丄上丗.Infos, selector:  val_3), keySelector:  val_5);
                val_35 = null;
                val_37 = 丕丏专丛下七七丄东.<>c.<>9__3_2;
                if(val_37 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.String> val_7 = null;
                val_37 = val_7;
                val_7 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::且丟业三上不丙一丛(Rilisoft.LobbyItemPlayerInfo 下丅丙一丂丗丅丝七));
                丕丏专丛下七七丄东.<>c.<>9__3_2 = val_37;
            }
            
                val_38 = null;
                val_38 = null;
                val_40 = 丕丏专丛下七七丄东.<>c.<>9__3_3;
                if(val_40 == null)
            {
                    System.Func<System.String, System.String> val_9 = null;
                val_40 = val_9;
                val_9 = new System.Func<System.String, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::丏丞三丕丂不东丈专(string 丞丅上丏丂且下丅与));
                丕丏专丛下七七丄东.<>c.<>9__3_3 = val_40;
            }
            
                val_27 = 1152921537295482560;
                if((System.Linq.Enumerable.SequenceEqual<System.String>(first:  val_28, second:  System.Linq.Enumerable.OrderBy<System.String, System.String>(source:  System.Linq.Enumerable.Select<Rilisoft.LobbyItemPlayerInfo, System.String>(source:  丂丆东上丂丏丟下专.Infos, selector:  val_7), keySelector:  val_9))) != false)
            {
                    val_41 = null;
                val_41 = null;
                val_43 = 丕丏专丛下七七丄东.<>c.<>9__3_4;
                if(val_43 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_12 = null;
                val_43 = val_12;
                val_12 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丕丏专丛下七七丄东.<>c::丞丙丁七丘丁下丈丕(Rilisoft.LobbyItemPlayerInfo 七丞丙丒三丕且丌丟));
                丕丏专丛下七七丄东.<>c.<>9__3_4 = val_43;
            }
            
                val_44 = null;
                val_44 = null;
                val_46 = 丕丏专丛下七七丄东.<>c.<>9__3_5;
                if(val_46 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo>> val_14 = null;
                val_46 = val_14;
                val_14 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo>>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo> 丕丏专丛下七七丄东.<>c::业丙丞丝下世三丘不(Rilisoft.LobbyItemPlayerInfo 下丅丙一丂丗丅丝七));
                丕丏专丛下七七丄东.<>c.<>9__3_5 = val_46;
            }
            
                val_47 = null;
                val_47 = null;
                val_49 = 丕丏专丛下七七丄东.<>c.<>9__3_6;
                if(val_49 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.String> val_16 = null;
                val_49 = val_16;
                val_16 = new System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::下丒丘丈不下丌专东(Rilisoft.LobbyItemPlayerLockerInfo 一丁七丑丑下七丈七));
                丕丏专丛下七七丄东.<>c.<>9__3_6 = val_49;
            }
            
                val_50 = null;
                val_26 = System.Linq.Enumerable.Select<Rilisoft.LobbyItemPlayerLockerInfo, System.String>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.LobbyItemPlayerInfo, Rilisoft.LobbyItemPlayerLockerInfo>(source:  System.Linq.Enumerable.Where<Rilisoft.LobbyItemPlayerInfo>(source:  且丕万丞丏世丄上丗.Infos, predicate:  val_12), selector:  val_14), selector:  val_16);
                val_50 = null;
                val_52 = 丕丏专丛下七七丄东.<>c.<>9__3_7;
                if(val_52 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean> val_18 = null;
                val_52 = val_18;
                val_18 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Boolean>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丕丏专丛下七七丄东.<>c::丌七东丌东丛且丈丑(Rilisoft.LobbyItemPlayerInfo 七丞丙丒三丕且丌丟));
                丕丏专丛下七七丄东.<>c.<>9__3_7 = val_52;
            }
            
                val_53 = null;
                val_53 = null;
                val_55 = 丕丏专丛下七七丄东.<>c.<>9__3_8;
                if(val_55 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerInfo, System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo>> val_20 = null;
                val_55 = val_20;
                val_20 = new System.Func<Rilisoft.LobbyItemPlayerInfo, System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo>>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.LobbyItemPlayerLockerInfo> 丕丏专丛下七七丄东.<>c::三下丁且丌丘丐丘七(Rilisoft.LobbyItemPlayerInfo 下丅丙一丂丗丅丝七));
                丕丏专丛下七七丄东.<>c.<>9__3_8 = val_55;
            }
            
                val_56 = null;
                val_56 = null;
                val_28 = 丕丏专丛下七七丄东.<>c.<>9__3_9;
                if(val_28 == null)
            {
                    System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.String> val_22 = null;
                val_28 = val_22;
                val_22 = new System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.String>(object:  丕丏专丛下七七丄东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丕丏专丛下七七丄东.<>c::丘丕业丒且丏丐丗专(Rilisoft.LobbyItemPlayerLockerInfo 一丁七丑丑下七丈七));
                丕丏专丛下七七丄东.<>c.<>9__3_9 = val_28;
            }
            
                val_58 = (System.Linq.Enumerable.SequenceEqual<System.String>(first:  val_26, second:  System.Linq.Enumerable.Select<Rilisoft.LobbyItemPlayerLockerInfo, System.String>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.LobbyItemPlayerInfo, Rilisoft.LobbyItemPlayerLockerInfo>(source:  System.Linq.Enumerable.Where<Rilisoft.LobbyItemPlayerInfo>(source:  丂丆东上丂丏丟下专.Infos, predicate:  val_18), selector:  val_20), selector:  val_22))) ^ 1;
                return (bool)val_58 & 1;
            }
            
            }
            
            val_58 = 1;
            return (bool)val_58 & 1;
        }
    
    }

}
