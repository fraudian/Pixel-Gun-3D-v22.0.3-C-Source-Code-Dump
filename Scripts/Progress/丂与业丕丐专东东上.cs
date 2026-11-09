using UnityEngine;

namespace Progress
{
    internal sealed class 丂与业丕丐专东东上 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal readonly System.Collections.Generic.List<Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专> 丅下丌东万世丐世一;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            return "clan_finishing_upgrades_slot";
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            return "clan_finishing_upgrades_slot_key";
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 40;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            var val_9;
            System.Func<丒丌丝丆东上下下专, 丒丌丝丆东上下下专> val_11;
            var val_14;
            var val_16;
            var val_17;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_9 = null;
            val_9 = null;
            val_11 = 丂与业丕丐专东东上.<>c.<>9__7_0;
            if(val_11 == null)
            {
                    System.Func<丒丌丝丆东上下下专, 丒丌丝丆东上下下专> val_2 = null;
                val_11 = val_2;
                val_2 = new System.Func<丒丌丝丆东上下下专, 丒丌丝丆东上下下专>(object:  丂与业丕丐专东东上.<>c.__il2cppRuntimeField_static_fields, method:  丒丌丝丆东上下下专 丂与业丕丐专东东上.<>c::丁丘丞下丏丑七丝丆(Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 三丟东丕丄丄下下丑));
                丂与业丕丐专东东上.<>c.<>9__7_0 = val_11;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.OrderBy<丒丌丝丆东上下下专, 丒丌丝丆东上下下专>(source:  this.丅下丌东万世丐世一, keySelector:  val_2).GetEnumerator();
            label_24:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_5.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            T val_9 = val_5.Current;
            System.Text.StringBuilder val_10 = val_1.Append(value:  val_9 + 16);
            goto label_24;
            label_16:
            val_16 = 0;
            val_17 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_14 = public System.Void System.IDisposable::Dispose();
                val_5.Dispose();
            }
            
            if(( == 1) && ( != false))
            {
                    val_14 = 0;
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            this.丅下丌东万世丐世一.Clear();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
        
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            var val_3;
            System.Func<丒丌丝丆东上下下专, System.Collections.Generic.Dictionary<System.String, System.Object>> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = 丂与业丕丐专东东上.<>c.<>9__9_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<丒丌丝丆东上下下专, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.丅下丌东万世丐世一, selector:  System.Func<丒丌丝丆东上下下专, System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<丒丌丝丆东上下下专, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  丂与业丕丐专东东上.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> 丂与业丕丐专东东上.<>c::丘下丌丈丑丒丘下丞(Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 三丟东丕丄丄下下丑));
            丂与业丕丐专东东上.<>c.<>9__9_0 = val_5;
            return System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<丒丌丝丆东上下下专, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.丅下丌东万世丐世一, selector:  val_1));
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丅下丌东万世丐世一.Clear();
        }
        internal override void Load()
        {
            if(this != null)
            {
                    return;
            }
            
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "data == null", args:  this);
        }
        internal override void 丂且不业丂专丛丆东()
        {
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  this);
        }
        internal override string 丁丑一丁丗业丒丗不()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丅下丌东万世丐世一);
        }
        internal override object 丟丗丞丕七丝世丌丞(string 丙七且丄丝丌丒万丘)
        {
            DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_1, typeof(public System.Collections.Generic.List<丒丌丝丆东上下下专> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<丒丌丝丆东上下下专>>(string 丞丕丒专一下丙业上).__il2cppRuntimeField_18), slot: 0) + 8;
        }
        internal override string 业丝丛丒丄专丕万丒()
        {
            return 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  this, 丞丌丑丛上丕丙丕下:  "[]");
        }
        public 丂与业丕丐专东东上()
        {
            this.丅下丌东万世丐世一 = new System.Collections.Generic.List<丒丌丝丆东上下下专>();
        }
    
    }

}
