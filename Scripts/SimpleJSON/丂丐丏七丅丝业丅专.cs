using UnityEngine;

namespace SimpleJSON
{
    public class 丂丐丏七丅丝业丅专 : 且丐上一丝业不专上, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<SimpleJSON.且丐上一丝业不专上> 丏丕丗丒丒丛一丕丟;
        
        // Properties
        public override SimpleJSON.且丐上一丝业不专上 不下下丞三一丘丗丐 { get; set; }
        public override SimpleJSON.且丐上一丝业不专上 不下下丞三一丘丗丐 { get; set; }
        public override int 丒专下与丑丁丆丟业 { get; }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.且丐上一丝业不专上> 且丟丒三丗丛丟丙一 { get; }
        
        // Methods
        public override SimpleJSON.且丐上一丝业不专上 丂丑丞丝且万丐万丟(int 丌丑丐丞丞丅专与丒)
        {
            var val_4;
            if((丌丑丐丞丞丅专与丒 & 2147483648) == 0)
            {
                    if(this.丏丕丗丒丒丛一丕丟.Count > 丌丑丐丞丞丅专与丒)
            {
                    val_4 = this.丏丕丗丒丒丛一丕丟.Item[丌丑丐丞丞丅专与丒];
                return (SimpleJSON.且丐上一丝业不专上)val_4;
            }
            
            }
            
            SimpleJSON.不丄丌丂下丄丂且不 val_3 = null;
            val_4 = val_3;
            val_3 = new SimpleJSON.不丄丌丂下丄丂且不();
            .一万万丒丝不丙丄东 = this;
            .丗丈丆丒三三丄下专 = 0;
            return (SimpleJSON.且丐上一丝业不专上)val_4;
        }
        public override void 丘丕丈下东一丑上丗(int 丌丑丐丞丞丅专与丒, SimpleJSON.且丐上一丝业不专上 丙业与丙丗丝不丈东)
        {
            if((丌丑丐丞丞丅专与丒 & 2147483648) == 0)
            {
                    if(this.丏丕丗丒丒丛一丕丟.Count > 丌丑丐丞丞丅专与丒)
            {
                    this.丏丕丗丒丒丛一丕丟.set_Item(index:  丌丑丐丞丞丅专与丒, value:  丙业与丙丗丝不丈东);
                return;
            }
            
            }
            
            this.丏丕丗丒丒丛一丕丟.Add(item:  丙业与丙丗丝不丈东);
        }
        public override SimpleJSON.且丐上一丝业不专上 丂丑丞丝且万丐万丟(string 丐丐丐丛不三丕且丏)
        {
            .一万万丒丝不丙丄东 = this;
            .丗丈丆丒三三丄下专 = 0;
            return (SimpleJSON.且丐上一丝业不专上)new SimpleJSON.不丄丌丂下丄丂且不();
        }
        public override void 丘丕丈下东一丑上丗(string 丐丐丐丛不三丕且丏, SimpleJSON.且丐上一丝业不专上 丙业与丙丗丝不丈东)
        {
            this.丏丕丗丒丒丛一丕丟.Add(item:  丙业与丙丗丝不丈东);
        }
        public override int 丂丁丏一丙丛业且丌()
        {
            if(this.丏丕丗丒丒丛一丕丟 != null)
            {
                    return this.丏丕丗丒丒丛一丕丟.Count;
            }
            
            return this.丏丕丗丒丒丛一丕丟.Count;
        }
        public override void 业丏丗丐丂业东丂丗(string 丐丐丐丛不三丕且丏, SimpleJSON.且丐上一丝业不专上 与万一不上丘丗东丞)
        {
            this.丏丕丗丒丒丛一丕丟.Add(item:  与万一不上丘丗东丞);
        }
        public override SimpleJSON.且丐上一丝业不专上 Remove(int 丌丑丐丞丞丅专与丒)
        {
            var val_3;
            if((丌丑丐丞丞丅专与丒 & 2147483648) == 0)
            {
                    if(this.丏丕丗丒丒丛一丕丟.Count > 丌丑丐丞丞丅专与丒)
            {
                    val_3 = this.丏丕丗丒丒丛一丕丟.Item[丌丑丐丞丞丅专与丒];
                this.丏丕丗丒丒丛一丕丟.RemoveAt(index:  丌丑丐丞丞丅专与丒);
                return (SimpleJSON.且丐上一丝业不专上)val_3;
            }
            
            }
            
            val_3 = 0;
            return (SimpleJSON.且丐上一丝业不专上)val_3;
        }
        public override SimpleJSON.且丐上一丝业不专上 Remove(SimpleJSON.且丐上一丝业不专上 与一丕三世上丆不专)
        {
            bool val_1 = this.丏丕丗丒丒丛一丕丟.Remove(item:  与一丕三世上丆不专);
            return (SimpleJSON.且丐上一丝业不专上)与一丕三世上丆不专;
        }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.且丐上一丝业不专上> 与业不丐专丞丒丆东()
        {
            .丗丏丅丕丆世丁专丟 = -2;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.且丐上一丝业不专上>)new 丂丐丏七丅丝业丅专.丒一丑丞一丆丒丐东();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丂丐丏七丅丝业丅专.七丅万丒丌业不丌世();
        }
        public override string ToString()
        {
            string val_7;
            string val_8;
            string val_9;
            val_7 = "[ ";
            List.Enumerator<T> val_1 = this.丏丕丗丒丒丛一丕丟.GetEnumerator();
            label_8:
            if(((-1704292056) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            val_8 = 0;
            if(Length >= 3)
            {
                goto label_4;
            }
            
            val_9 = val_7;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_8 = ", ";
            val_9 = val_7 + val_8;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            string val_5 = val_9 + val_2;
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_7 + " ]";
        }
        public override string 一丁与丙世与东丆丆(string 三丁丞且丌万丛丝专)
        {
            System.Collections.Generic.List<SimpleJSON.且丐上一丝业不专上> val_9;
            string val_10;
            string val_11;
            val_9 = this.丏丕丗丒丒丛一丕丟;
            val_10 = "[ ";
            List.Enumerator<T> val_1 = val_9.GetEnumerator();
            label_6:
            if(((-1704126840) & 1) == 0)
            {
                goto label_2;
            }
            
            if(Length >= 4)
            {
                    val_11 = val_10 + ", ";
            }
            
            string val_6 = 三丁丞且丌万丛丝专 + "   ";
            string val_7 = val_11 + "\n" + 三丁丞且丌万丛丝专 + "   "(val_11 + "\n" + 三丁丞且丌万丛丝专 + "   ") + 0.丐丏七丌丕丗业且上();
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_10 + "\n" + 三丁丞且丌万丛丝专 + "]";
        }
        public override void 丙业不丝丗丌丗世下(System.IO.BinaryWriter 丕丅丕丘万专丟丆丞)
        {
            var val_4;
            int val_1 = this.丏丕丗丒丒丛一丕丟.Count;
            val_4 = 0;
            goto label_3;
            label_7:
            SimpleJSON.且丐上一丝业不专上 val_2 = this.丏丕丗丒丒丛一丕丟.Item[0];
            val_4 = 1;
            label_3:
            if(val_4 < this.丏丕丗丒丒丛一丕丟.Count)
            {
                goto label_7;
            }
        
        }
        public 丂丐丏七丅丝业丅专()
        {
            this.丏丕丗丒丒丛一丕丟 = new System.Collections.Generic.List<SimpleJSON.且丐上一丝业不专上>();
            this = new System.Object();
        }
    
    }

}
