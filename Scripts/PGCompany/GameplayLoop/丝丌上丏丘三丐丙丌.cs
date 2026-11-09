using UnityEngine;

namespace PGCompany.GameplayLoop
{
    internal class 丝丌上丏丘三丐丙丌 : 业丒丅丂丗丁业上且
    {
        // Fields
        private bool 上与丂专丏上世丂下;
        private int 丝丒一丁丐丛三丙丗;
        private System.Collections.Generic.List<string> 上专丌专丆丒丘一专;
        
        // Methods
        public 丝丌上丏丘三丐丙丌()
        {
            this.丝丒一丁丐丛三丙丗 = 0;
            this.上专丌专丆丒丘一专 = new System.Collections.Generic.List<System.String>();
            mem[1152921560180343008] = 3;
            this.丂且丗万丁下丞万丁();
            Rilisoft.三一丈七且丄与丝东.丙业万专世丐丘丁三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.丝丌上丏丘三丐丙丌::丂且丗万丁下丞万丁()));
            ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.丝丌上丏丘三丐丙丌::与丘丐丅丛丌丝丘丕()));
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameplayLoop.丝丌上丏丘三丐丙丌::与丘丐丅丛丌丝丘丕()));
        }
        internal override bool 丑丏丙丑且丞丈丝业(bool 丘丄一丘丁丞丘丆且)
        {
            int val_11;
            var val_12;
            if(丘丄一丘丁丞丘丆且 == false)
            {
                goto label_1;
            }
            
            val_11 = this;
            if(UnityEngine.Time.frameCount != this.丝丒一丁丐丛三丙丗)
            {
                goto label_2;
            }
            
            var val_2 = (this.上与丂专丏上世丂下 == true) ? 1 : 0;
            return val_8;
            label_1:
            val_11 = this.丝丒一丁丐丛三丙丗;
            label_2:
            mem2[0] = UnityEngine.Time.frameCount;
            if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
            {
                goto label_6;
            }
            
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  200)) == false)
            {
                goto label_10;
            }
            
            val_12 = 1;
            goto label_11;
            label_6:
            val_12 = 0;
            this.上与丂专丏上世丂下 = false;
            return val_8;
            label_10:
            val_12 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            bool val_8 = val_12.丅专丞丝专丐与丂一(且下丕七丙丗丄不七:  44);
            label_11:
            this.上与丂专丏上世丂下 = val_8;
            return val_8;
        }
        private void 丂且丗万丁下丞万丁()
        {
            System.Collections.Generic.IEnumerable<TSource> val_30;
            System.Collections.Generic.IEnumerable<TSource> val_31;
            var val_32;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>> val_34;
            var val_35;
            System.Func<Rilisoft.GameEventItemContainerData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData>> val_37;
            var val_38;
            System.Func<Rilisoft.GameEventItemData, System.String> val_40;
            var val_41;
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>> val_43;
            var val_44;
            System.Func<Rilisoft.GameEventItemContainerData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData>> val_46;
            var val_47;
            System.Func<Rilisoft.GameEventItemData, System.String> val_49;
            var val_50;
            System.Func<System.String, System.Boolean> val_52;
            var val_53;
            System.Func<System.String, System.String> val_55;
            this.上专丌专丆丒丘一专 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_2 = null;
            val_30 = val_2;
            val_2 = new System.Collections.Generic.List<System.String>();
            System.Collections.Generic.List<System.String> val_3 = null;
            val_31 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            Rilisoft.丛且世丐丆上七业丁 val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  200);
            if(val_5 != null)
            {
                    val_32 = null;
                val_32 = null;
                val_34 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_0;
                if(val_34 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>> val_7 = null;
                val_34 = val_7;
                val_7 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData> 丝丌上丏丘三丐丙丌.<>c::丏丝丅专丑丄东丗丙(Rilisoft.上专业三丟丁丞专下 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_0 = val_34;
            }
            
                val_35 = null;
                val_35 = null;
                val_37 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_1;
                if(val_37 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainerData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData>> val_9 = null;
                val_37 = val_9;
                val_9 = new System.Func<Rilisoft.GameEventItemContainerData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData>>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData> 丝丌上丏丘三丐丙丌.<>c::丈万下丐丄丐专丅三(Rilisoft.GameEventItemContainerData 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_1 = val_37;
            }
            
                val_38 = null;
                val_38 = null;
                val_40 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_2;
                if(val_40 == null)
            {
                    System.Func<Rilisoft.GameEventItemData, System.String> val_11 = null;
                val_40 = val_11;
                val_11 = new System.Func<Rilisoft.GameEventItemData, System.String>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丝丌上丏丘三丐丙丌.<>c::丄三丕丒丛丘上专丈(Rilisoft.GameEventItemData 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_2 = val_40;
            }
            
                val_30 = System.Linq.Enumerable.Select<Rilisoft.GameEventItemData, System.String>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.GameEventItemContainerData, Rilisoft.GameEventItemData>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.上专业三丟丁丞专下, Rilisoft.GameEventItemContainerData>(source:  val_5.专丌丙上东丙专丅丏(), selector:  val_7), selector:  val_9), selector:  val_11);
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_14 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丂三丞下专一下丛万(且下丕七丙丗丄不七:  44);
            if(val_14 != null)
            {
                    val_41 = null;
                val_41 = null;
                val_43 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_3;
                if(val_43 == null)
            {
                    System.Func<Rilisoft.上专业三丟丁丞专下, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>> val_16 = null;
                val_43 = val_16;
                val_16 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData>>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemContainerData> 丝丌上丏丘三丐丙丌.<>c::且七专丐下丞丕丞丘(Rilisoft.上专业三丟丁丞专下 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_3 = val_43;
            }
            
                val_44 = null;
                val_44 = null;
                val_46 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_4;
                if(val_46 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainerData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData>> val_18 = null;
                val_46 = val_18;
                val_18 = new System.Func<Rilisoft.GameEventItemContainerData, System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData>>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<Rilisoft.GameEventItemData> 丝丌上丏丘三丐丙丌.<>c::且丂丛丏丐万三丐丟(Rilisoft.GameEventItemContainerData 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_4 = val_46;
            }
            
                val_47 = null;
                val_47 = null;
                val_49 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_5;
                if(val_49 == null)
            {
                    System.Func<Rilisoft.GameEventItemData, System.String> val_20 = null;
                val_49 = val_20;
                val_20 = new System.Func<Rilisoft.GameEventItemData, System.String>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丝丌上丏丘三丐丙丌.<>c::不丛下丝丑丙上上丒(Rilisoft.GameEventItemData 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_5 = val_49;
            }
            
                val_31 = System.Linq.Enumerable.Select<Rilisoft.GameEventItemData, System.String>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.GameEventItemContainerData, Rilisoft.GameEventItemData>(source:  System.Linq.Enumerable.SelectMany<Rilisoft.上专业三丟丁丞专下, Rilisoft.GameEventItemContainerData>(source:  val_14.专丌丙上东丙专丅丏(), selector:  val_16), selector:  val_18), selector:  val_20);
            }
            
            System.Collections.Generic.List<TSource> val_24 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Distinct<System.String>(source:  System.Linq.Enumerable.Union<System.String>(first:  val_31, second:  val_30)));
            this.上专丌专丆丒丘一专 = val_24;
            val_50 = null;
            val_50 = null;
            val_52 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_6;
            if(val_52 == null)
            {
                    System.Func<System.String, System.Boolean> val_25 = null;
                val_52 = val_25;
                val_25 = new System.Func<System.String, System.Boolean>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丝丌上丏丘三丐丙丌.<>c::丐世与下上丞业丅万(string 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_6 = val_52;
            }
            
            val_53 = null;
            val_53 = null;
            val_55 = 丝丌上丏丘三丐丙丌.<>c.<>9__4_7;
            if(val_55 == null)
            {
                    System.Func<System.String, System.String> val_27 = null;
                val_55 = val_27;
                val_27 = new System.Func<System.String, System.String>(object:  丝丌上丏丘三丐丙丌.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丝丌上丏丘三丐丙丌.<>c::不丙万丌丞丂七丙丞(string 三丟东丕丄丄下下丑));
                丝丌上丏丘三丐丙丌.<>c.<>9__4_7 = val_55;
            }
            
            this.上专丌专丆丒丘一专.AddRange(collection:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  val_24, predicate:  val_25), selector:  val_27)));
        }
        private void 与丘丐丅丛丌丝丘丕()
        {
            if(this.上专丌专丆丒丘一专 != null)
            {
                    if(this.上专丌专丆丒丘一专.Count != 0)
            {
                    return;
            }
            
            }
            
            this.丂且丗万丁下丞万丁();
        }
        internal override bool 万丑万上丕丆不丒七(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且)
        {
            var val_18;
            bool val_19;
            var val_20;
            string val_21;
            val_18 = 丘丄一丘丁丞丘丆且;
            bool val_1 = val_18;
            if(((this & 1) == 0) || ((this.且下丑丂丂丌丘丛丘(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七)) == false))
            {
                goto label_2;
            }
            
            三丅丁丗丗丝丂万且 val_3 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七);
            if((val_3 == null) || ((this.上专丌专丆丒丘一专.Contains(item:  val_3.三与丛丑且丐丈业丌())) == false))
            {
                goto label_7;
            }
            
            val_19 = 1;
            goto label_8;
            label_2:
            val_20 = 0;
            return (bool)(val_19 == true) ? 1 : 0;
            label_7:
            val_19 = this.上专丌专丆丒丘一专.Contains(item:  下丅丙一丂丗丅丝七);
            label_8:
            val_18 = 0;
            goto label_11;
            label_29:
            val_21 = this.上专丌专丆丒丘一专.Item[0];
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_21)) != false)
            {
                    string val_10 = this.上专丌专丆丒丘一专.Item[0];
                if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_10)) != false)
            {
                    val_21 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞();
                丛且专丞丗丆丙丒万 val_13 = val_21.Item[val_10];
                if(val_13.上七不丅丈丁不丛丝 != null)
            {
                    if((val_13.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsValue(value:  下丅丙一丂丗丅丝七)) == true)
            {
                    return (bool)(val_19 == true) ? 1 : 0;
            }
            
            }
            
            }
            
            }
            
            val_18 = 1;
            label_11:
            if(val_18 < this.上专丌专丆丒丘一专.Count)
            {
                goto label_29;
            }
            
            return (bool)(val_19 == true) ? 1 : 0;
        }
        internal override string 丒丅三丕丙丏丌丕不()
        {
            Rilisoft.三一丈七且丄与丝东 val_7 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if((val_7.丂三丞下专一下丛万(且下丕七丙丗丄不七:  200)) == null)
            {
                    val_7 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
                Rilisoft.丛且世丐丆上七业丁 val_4 = val_7.丂三丞下专一下丛万(且下丕七丙丗丄不七:  44);
                if(val_4 == null)
            {
                    return (string)val_4.业上丙丞丐丄丆丅七();
            }
            
            }
            
            return (string)val_4.业上丙丞丐丄丆丅七();
        }
        internal override System.TimeSpan 丅世不下丑且丏丙一(string 丞一丁业丄一一业且)
        {
            var val_9;
            var val_11;
            val_9 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if((val_9.丂三丞下专一下丛万(且下丕七丙丗丄不七:  200)) == null)
            {
                    val_9 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
                Rilisoft.丛且世丐丆上七业丁 val_4 = val_9.丂三丞下专一下丛万(且下丕七丙丗丄不七:  44);
                if(val_4 == null)
            {
                goto label_13;
            }
            
            }
            
            System.Nullable<System.TimeSpan> val_5 = val_4.丙世丑丅丒丑业与不();
            label_13:
            if(( & 1) != 0)
            {
                    val_11;
                return (System.TimeSpan)val_6._ticks;
            }
            
            System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  0);
            return (System.TimeSpan)val_6._ticks;
        }
    
    }

}
