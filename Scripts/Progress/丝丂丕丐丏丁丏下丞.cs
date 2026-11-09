using UnityEngine;

namespace Progress
{
    internal abstract class 丝丂丕丐丏丁丏下丞 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal string 专丙丏下丂业丘东丕;
        private System.Collections.Generic.HashSet<string> 且丞不世丒丈丒丝丏;
        
        // Methods
        internal bool 丟不下下且业丛丄丏(string 下上丐丆丝丟丝丒不)
        {
            if(this.且丞不世丒丈丒丝丏 != null)
            {
                    return this.且丞不世丒丈丒丝丏.Contains(item:  下上丐丆丝丟丝丒不);
            }
            
            return this.且丞不世丒丈丒丝丏.Contains(item:  下上丐丆丝丟丝丒不);
        }
        internal System.Collections.Generic.List<string> 专丏丕下上与与丟不()
        {
            return System.Linq.Enumerable.ToList<System.String>(source:  this.且丞不世丒丈丒丝丏);
        }
        internal void 丒三丐丄东丟丁丅丏(string 下下丏一丙不丘丌丞)
        {
            bool val_1 = this.且丞不世丒丈丒丝丏.Add(item:  下下丏一丙不丘丌丞);
        }
        internal void 万万丌丄且三世上万(string 下下丏一丙不丘丌丞)
        {
            bool val_1 = this.且丞不世丒丈丒丝丏.Remove(item:  下下丏一丙不丘丌丞);
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            if(this == null)
            {
                    return (string)(null == null) ? (this) : 0;
            }
            
            return (string)(null == null) ? (this) : 0;
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            new 丝丂丕丐丏丁丏下丞.丒丑万一丁丕东一丗() = new System.Object();
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.String>(source:  this.且丞不世丒丈丒丝丏);
            val_2.Sort();
            .不东丙三世丘东丈丕 = "";
            System.Action<System.String> val_3 = new System.Action<System.String>(object:  new 丝丂丕丐丏丁丏下丞.丒丑万一丁丕东一丗(), method:  System.Void 丝丂丕丐丏丁丏下丞.丒丑万一丁丕东一丗::丛上上与丕丗丞丗业(string 三丟东丕丄丄下下丑));
            val_2.ForEach(action:  null);
            return (string).不东丙三世丘东丈丕;
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            object val_4;
            System.Collections.Generic.HashSet<System.String> val_10;
            object val_11;
            string val_12;
            var val_13;
            val_11 = this;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            val_10 = this.且丞不世丒丈丒丝丏;
            val_10.Clear();
            List.Enumerator<T> val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            label_9:
            if(((-1997653184) & 1) == 0)
            {
                goto label_5;
            }
            
            val_12 = val_4.丐丏七丌丕丗业且上();
            if((val_12 != null) && (null != null))
            {
                    val_12 = 0;
            }
            
            bool val_7 = this.且丞不世丒丈丒丝丏.Add(item:  val_12);
            goto label_9;
            label_5:
            val_13 = 0;
            val_11 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == false)
            {
                    return;
            }
            
                if(81 != 81)
            {
                    return;
            }
            
                return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            return System.Linq.Enumerable.ToArray<System.String>(source:  this.且丞不世丒丈丒丝丏);
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
            this.且丞不世丒丈丒丝丏 = new System.Collections.Generic.HashSet<System.String>(collection:  this);
        }
        internal virtual string[] 一丆丞丆上丘万丐不()
        {
            string[] val_1 = new string[1];
            val_1[0] = "";
            return (System.String[])val_1;
        }
        protected 丝丂丕丐丏丁丏下丞()
        {
            this.专丙丏下丂业丘东丕 = "&";
            this.且丞不世丒丈丒丝丏 = new System.Collections.Generic.HashSet<System.String>();
            this = new System.Object();
            goto typeof(Progress.丝丂丕丐丏丁丏下丞).__il2cppRuntimeField_238;
        }
    
    }

}
