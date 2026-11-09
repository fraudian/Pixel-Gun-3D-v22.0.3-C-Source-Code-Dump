using UnityEngine;

namespace Progress
{
    internal abstract class 丑丌三七不丅万且一 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private static System.Action 丌丗万与丗丞三丝丞;
        private System.Collections.Generic.HashSet<int> 丑与丘丏与丛丄专丙;
        internal string 专丙丏下丂业丘东丕;
        
        // Methods
        internal static void 七上丑丝七丒业丈业(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Progress.丑丌三七不丅万且一.丌丗万与丗丞三丝丞, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 与且东与丏下三业丞(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Progress.丑丌三七不丅万且一.丌丗万与丗丞三丝丞, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal bool 丟不下下且业丛丄丏(int 下上丐丆丝丟丝丒不)
        {
            if(this.丑与丘丏与丛丄专丙 != null)
            {
                    return this.丑与丘丏与丛丄专丙.Contains(item:  下上丐丆丝丟丝丒不);
            }
            
            return this.丑与丘丏与丛丄专丙.Contains(item:  下上丐丆丝丟丝丒不);
        }
        internal virtual bool 丟不下下且业丛丄丏(string 下上丐丆丝丟丝丒不)
        {
            return false;
        }
        internal System.Collections.Generic.List<int> 专丏丕下上与与丟不()
        {
            return System.Linq.Enumerable.ToList<System.Int32>(source:  this.丑与丘丏与丛丄专丙);
        }
        internal void 丒三丐丄东丟丁丅丏(int 下下丏一丙不丘丌丞)
        {
            bool val_1 = this.丑与丘丏与丛丄专丙.Add(item:  下下丏一丙不丘丌丞);
            if(Progress.丑丌三七不丅万且一.丌丗万与丗丞三丝丞 == null)
            {
                    return;
            }
            
            Progress.丑丌三七不丅万且一.丌丗万与丗丞三丝丞.Invoke();
        }
        internal void 万万丌丄且三世上万(int 下下丏一丙不丘丌丞)
        {
            bool val_1 = this.丑与丘丏与丛丄专丙.Remove(item:  下下丏一丙不丘丌丞);
            if(Progress.丑丌三七不丅万且一.丌丗万与丗丞三丝丞 == null)
            {
                    return;
            }
            
            Progress.丑丌三七不丅万且一.丌丗万与丗丞三丝丞.Invoke();
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            var val_4;
            System.Func<System.Int32, System.String> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = 丑丌三七不丅万且一.<>c.<>9__10_0;
            if(val_6 != null)
            {
                    return System.String.Join(separator:  this.专丙丏下丂业丘东丕, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  this.丑与丘丏与丛丄专丙, selector:  System.Func<System.Int32, System.String> val_1 = null)));
            }
            
            val_6 = val_1;
            val_1 = new System.Func<System.Int32, System.String>(object:  丑丌三七不丅万且一.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丑丌三七不丅万且一.<>c::一丒丘东丟丟东且东(int 三丟东丕丄丄下下丑));
            丑丌三七不丅万且一.<>c.<>9__10_0 = val_6;
            return System.String.Join(separator:  this.专丙丏下丂业丘东丕, value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  this.丑与丘丏与丛丄专丙, selector:  val_1)));
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.丑与丘丏与丛丄专丙);
            val_2.Sort();
            .不东丙三世丘东丈丕 = "";
            val_2.ForEach(action:  new System.Action<System.Int32>(object:  new 丑丌三七不丅万且一.丗丛丘丑丐不丌丑丙(), method:  System.Void 丑丌三七不丅万且一.丗丛丘丑丐不丌丑丙::丛上上与丕丗丞丗业(int 三丟东丕丄丄下下丑)));
            return (string)(丑丌三七不丅万且一.丗丛丘丑丐不丌丑丙)[1152921541265904192].不东丙三世丘东丈丕;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            object val_4;
            System.Collections.Generic.HashSet<System.Int32> val_10;
            object val_11;
            var val_12;
            val_11 = this;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            val_10 = this.丑与丘丏与丛丄专丙;
            val_10.Clear();
            List.Enumerator<T> val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            label_9:
            if(((-1995539424) & 1) == 0)
            {
                goto label_5;
            }
            
            bool val_7 = this.丑与丘丏与丛丄专丙.Add(item:  System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上()));
            goto label_9;
            label_5:
            val_12 = 0;
            val_11 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(81 != 81)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            return System.Linq.Enumerable.ToArray<System.Int32>(source:  this.丑与丘丏与丛丄专丙);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            this.丑与丘丏与丛丄专丙 = new System.Collections.Generic.HashSet<System.Int32>(collection:  this);
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丑与丘丏与丛丄专丙.Clear();
        }
        internal virtual System.Collections.Generic.List<int> 一丆丞丆上丘万丐不()
        {
            return 0;
        }
        protected 丑丌三七不丅万且一()
        {
            this.丑与丘丏与丛丄专丙 = new System.Collections.Generic.HashSet<System.Int32>();
            this.专丙丏下丂业丘东丕 = "&";
        }
    
    }

}
