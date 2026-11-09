using UnityEngine;

namespace Rilisoft
{
    public sealed class 丗丈丒丏丁东一不三
    {
        // Fields
        private readonly bool 丞丁上三丝丝丅不丌;
        private readonly System.Collections.Generic.IList<Rilisoft.丝且一上一万与丘丈> 丛一丞丆丏丒世且丘;
        private readonly System.Func<System.Collections.Generic.IList<Rilisoft.丝且一上一万与丘丈>> 且丘丒丞丛丟丆三丞;
        
        // Properties
        public Rilisoft.丝且一上一万与丘丈 且下且丅丗丒且万丝 { get; }
        public bool 且丐丆与丛专丙业丑 { get; }
        
        // Methods
        internal 丗丈丒丏丁东一不三(System.Collections.Generic.IEnumerable<Rilisoft.丝且一上一万与丘丈> 丅丞丁丟七专丗丂丝, System.Func<System.Collections.Generic.IList<Rilisoft.丝且一上一万与丘丈>> 丞丆丗七三丁万丞且, bool 丈业丒业丕丟万世且 = False)
        {
            if(丅丞丁丟七专丗丂丝 != null)
            {
                    this.丞丁上三丝丝丅不丌 = 丈业丒业丕丟万世且;
                this.丛一丞丆丏丒世且丘 = System.Linq.Enumerable.ToList<Rilisoft.丝且一上一万与丘丈>(source:  丅丞丁丟七专丗丂丝);
                this.且丘丒丞丛丟丆三丞 = 丞丆丗七三丁万丞且;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "quests");
        }
        public Rilisoft.丝且一上一万与丘丈 丙丂丘丁丒丕丙万业()
        {
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.丝且一上一万与丘丈>(source:  this.丛一丞丆丏丒世且丘);
        }
        public bool 丕专且不且丌丟丌丒()
        {
            var val_11;
            int val_13;
            var val_15;
            var val_17;
            var val_18;
            if(this.且丘丒丞丛丟丆三丞 == null)
            {
                goto label_14;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_11 = 0;
            if(this.丛一丞丆丏丒世且丘.Count == 0)
            {
                    return (bool)(this.丞丁上三丝丝丅不丌 == true) ? 1 : 0;
            }
            
            val_13 = 1152921504691298304;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_11 = 0;
            val_15 = public T System.Collections.Generic.IList<T>::get_Item(int index);
            if(this.丛一丞丆丏丒世且丘.Item[0].与丆丅丒丙丘丘丝丁() == true)
            {
                goto label_14;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_15 = 0;
            val_13 = val_7 + 360 + 8;
            val_17 = null;
            val_17 = null;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = this.丛一丞丆丏丒世且丘.Item[0], hi = this.丛一丞丆丏丒世且丘.Item[0], lo = val_13, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_20>>32&0x0})) == false)
            {
                goto label_23;
            }
            
            label_14:
            val_18 = 0;
            return (bool)(this.丞丁上三丝丝丅不丌 == true) ? 1 : 0;
            label_23:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if(this.丛一丞丆丏丒世且丘.Count <= 1)
            {
                    if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return (bool)(this.丞丁上三丝丝丅不丌 == true) ? 1 : 0;
            }
            
                object[] val_12 = new object[1];
                var val_20 = 0;
                val_20 = val_20 + 1;
            }
            else
            {
                    val_18 = 1;
                return (bool)(this.丞丁上三丝丝丅不丌 == true) ? 1 : 0;
            }
            
            val_13 = this.丛一丞丆丏丒世且丘.Count;
            val_12[0] = val_13;
            UnityEngine.Debug.LogFormat(format:  "_quests.Count < 2: {0}", args:  val_12);
            return (bool)(this.丞丁上三丝丝丅不丌 == true) ? 1 : 0;
        }
        public void 丐丆丙丕丂三丄专业()
        {
            var val_18;
            System.Collections.Generic.IList<Rilisoft.丝且一上一万与丘丈> val_19;
            var val_20;
            var val_21;
            val_18 = this;
            if(this.丕专且不且丌丟丌丒() == false)
            {
                    return;
            }
            
            System.Collections.Generic.IList<Rilisoft.丝且一上一万与丘丈> val_2 = this.且丘丒丞丛丟丆三丞.Invoke();
            val_19 = this.丛一丞丆丏丒世且丘;
            val_20 = 1152921504690978816;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_21 = 3;
            val_19.Clear();
            if(val_2 == null)
            {
                    return;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_21 = 0;
            System.Collections.Generic.IEnumerator<T> val_5 = val_2.GetEnumerator();
            label_29:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_21 = 0;
            if(val_5.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_21 = 0;
            T val_9 = val_5.Current;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_21 = 2;
            this.丛一丞丆丏丒世且丘.Add(item:  ???);
            goto label_29;
            label_18:
            val_19 = 0;
            val_18 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_5.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_18 = ???;
            val_19 = ???;
            val_20 = ???;
        }
    
    }

}
