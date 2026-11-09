using UnityEngine;

namespace Progress
{
    internal sealed class 业上丅丂丝丌丟下三 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private System.Collections.Generic.HashSet<int> 丒丆下世丅东丑丅丙;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        internal System.Collections.Generic.IEnumerable<int> 下丐丐丁与丂下世七 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            return "Mail Box Reward";
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            if(this.GetType() == null)
            {
                
            }
        
        }
        internal System.Collections.Generic.IEnumerable<int> 丈丏丁东上与东丙丕()
        {
            return (System.Collections.Generic.IEnumerable<System.Int32>)this.丒丆下世丅东丑丅丙;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 42;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            var val_9;
            System.Func<System.Int32, System.Int32> val_11;
            var val_14;
            var val_16;
            var val_17;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_9 = null;
            val_9 = null;
            val_11 = 业上丅丂丝丌丟下三.<>c.<>9__8_0;
            if(val_11 == null)
            {
                    System.Func<System.Int32, System.Int32> val_2 = null;
                val_11 = val_2;
                val_2 = new System.Func<System.Int32, System.Int32>(object:  业上丅丂丝丌丟下三.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 业上丅丂丝丌丟下三.<>c::丂丘丏丂丁丌丗业丌(int 三丟东丕丄丄下下丑));
                业上丅丂丝丌丟下三.<>c.<>9__8_0 = val_11;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.OrderBy<System.Int32, System.Int32>(source:  this.丒丆下世丅东丑丅丙, keySelector:  val_2).GetEnumerator();
            label_23:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            if(val_5.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Text.StringBuilder val_10 = val_1.Append(value:  val_5.Current);
            goto label_23;
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
            var val_4;
            var val_9 = this;
            this.丒丆下世丅东丑丅丙.Clear();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            label_10:
            if(((-1965229216) & 1) == 0)
            {
                goto label_6;
            }
            
            bool val_7 = this.丒丆下世丅东丑丅丙.Add(item:  System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上()));
            goto label_10;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            return (object)new System.Collections.Generic.List<System.Int32>(collection:  this.丒丆下世丅东丑丅丙);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丒丆下世丅东丑丅丙.Clear();
        }
        internal void 丝丟丈三东专丄丛丐(int 三丐三丞丘丕不丒专)
        {
            bool val_1 = this.丒丆下世丅东丑丅丙.Add(item:  三丐三丞丘丕不丒专);
        }
        internal void 丑丅不东丏丐不专丙(int 三丐三丞丘丕不丒专)
        {
            bool val_1 = this.丒丆下世丅东丑丅丙.Remove(item:  三丐三丞丘丕不丒专);
        }
        internal bool 不丅丁丄丙专不丟丂(int 三丐三丞丘丕不丒专)
        {
            if(this.丒丆下世丅东丑丅丙 != null)
            {
                    return this.丒丆下世丅东丑丅丙.Contains(item:  三丐三丞丘丕不丒专);
            }
            
            return this.丒丆下世丅东丑丅丙.Contains(item:  三丐三丞丘丕不丒专);
        }
        public 业上丅丂丝丌丟下三()
        {
            this.丒丆下世丅东丑丅丙 = new System.Collections.Generic.HashSet<System.Int32>();
            this = new System.Object();
            goto typeof(Progress.业上丅丂丝丌丟下三).__il2cppRuntimeField_238;
        }
    
    }

}
