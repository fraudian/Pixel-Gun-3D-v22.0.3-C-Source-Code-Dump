using UnityEngine;

namespace SimpleJSON
{
    public class 丁丕下丗丝业丕丙丅 : 且丐上一丝业不专上, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SimpleJSON.且丐上一丝业不专上> 下专丐业丑丞丈丛丙;
        
        // Properties
        public override SimpleJSON.且丐上一丝业不专上 不下下丞三一丘丗丐 { get; set; }
        public override SimpleJSON.且丐上一丝业不专上 不下下丞三一丘丗丐 { get; set; }
        public override int 丒专下与丑丁丆丟业 { get; }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.且丐上一丝业不专上> 且丟丒三丗丛丟丙一 { get; }
        
        // Methods
        public override SimpleJSON.且丐上一丝业不专上 丂丑丞丝且万丐万丟(string 丐丐丐丛不三丕且丏)
        {
            if((this.下专丐业丑丞丈丛丙.ContainsKey(key:  丐丐丐丛不三丕且丏)) != false)
            {
                    if(this.下专丐业丑丞丈丛丙 != null)
            {
                    return this.下专丐业丑丞丈丛丙.Item[丐丐丐丛不三丕且丏];
            }
            
                return this.下专丐业丑丞丈丛丙.Item[丐丐丐丛不三丕且丏];
            }
            
            .一万万丒丝不丙丄东 = this;
            .丗丈丆丒三三丄下专 = 丐丐丐丛不三丕且丏;
            return (SimpleJSON.且丐上一丝业不专上)new SimpleJSON.不丄丌丂下丄丂且不();
        }
        public override void 丘丕丈下东一丑上丗(string 丐丐丐丛不三丕且丏, SimpleJSON.且丐上一丝业不专上 丙业与丙丗丝不丈东)
        {
            bool val_1 = this.下专丐业丑丞丈丛丙.ContainsKey(key:  丐丐丐丛不三丕且丏);
            if(this.下专丐业丑丞丈丛丙 == null)
            {
                goto label_2;
            }
            
            if(val_1 == false)
            {
                goto label_3;
            }
            
            label_4:
            this.下专丐业丑丞丈丛丙.set_Item(key:  丐丐丐丛不三丕且丏, value:  丙业与丙丗丝不丈东);
            return;
            label_2:
            if(val_1 == true)
            {
                goto label_4;
            }
            
            label_3:
            this.下专丐业丑丞丈丛丙.Add(key:  丐丐丐丛不三丕且丏, value:  丙业与丙丗丝不丈东);
        }
        public override SimpleJSON.且丐上一丝业不专上 丂丑丞丝且万丐万丟(int 丌丑丐丞丞丅专与丒)
        {
            var val_3;
            if((丌丑丐丞丞丅专与丒 & 2147483648) == 0)
            {
                    if(this.下专丐业丑丞丈丛丙.Count > 丌丑丐丞丞丅专与丒)
            {
                    System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>>(source:  this.下专丐业丑丞丈丛丙, index:  丌丑丐丞丞丅专与丒);
                val_3;
                return (SimpleJSON.且丐上一丝业不专上)val_3;
            }
            
            }
            
            val_3 = 0;
            return (SimpleJSON.且丐上一丝业不专上)val_3;
        }
        public override void 丘丕丈下东一丑上丗(int 丌丑丐丞丞丅专与丒, SimpleJSON.且丐上一丝业不专上 丙业与丙丗丝不丈东)
        {
            int val_4 = 丌丑丐丞丞丅专与丒;
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.下专丐业丑丞丈丛丙.Count <= val_4)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>>(source:  this.下专丐业丑丞丈丛丙, index:  val_4 = 丌丑丐丞丞丅专与丒);
            val_4 = this.下专丐业丑丞丈丛丙;
            val_4.set_Item(key:  val_2.Value.丐丏七丌丕丗业且上(), value:  丙业与丙丗丝不丈东);
        }
        public override int 丂丁丏一丙丛业且丌()
        {
            if(this.下专丐业丑丞丈丛丙 != null)
            {
                    return this.下专丐业丑丞丈丛丙.Count;
            }
            
            return this.下专丐业丑丞丈丛丙.Count;
        }
        public override void 业丏丗丐丂业东丂丗(string 丐丐丐丛不三丕且丏, SimpleJSON.且丐上一丝业不专上 与万一不上丘丗东丞)
        {
            string val_4;
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.且丐上一丝业不专上> val_5;
            val_4 = 丐丐丐丛不三丕且丏;
            val_5 = this.下专丐业丑丞丈丛丙;
            if((System.String.IsNullOrEmpty(value:  val_4)) == false)
            {
                goto label_1;
            }
            
            System.Guid val_2 = System.Guid.NewGuid();
            val_4 = ;
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_1:
            bool val_3 = val_5.ContainsKey(key:  val_4);
            val_5 = this.下专丐业丑丞丈丛丙;
            if(val_5 == null)
            {
                goto label_7;
            }
            
            if(val_3 == false)
            {
                goto label_8;
            }
            
            label_10:
            val_5.set_Item(key:  val_4, value:  与万一不上丘丗东丞);
            return;
            label_7:
            if(val_3 == true)
            {
                goto label_10;
            }
            
            label_8:
            val_5.Add(key:  val_4, value:  与万一不上丘丗东丞);
        }
        public override SimpleJSON.且丐上一丝业不专上 Remove(string 丐丐丐丛不三丕且丏)
        {
            var val_4;
            if((this.下专丐业丑丞丈丛丙.ContainsKey(key:  丐丐丐丛不三丕且丏)) != false)
            {
                    val_4 = this.下专丐业丑丞丈丛丙.Item[丐丐丐丛不三丕且丏];
                bool val_3 = this.下专丐业丑丞丈丛丙.Remove(key:  丐丐丐丛不三丕且丏);
                return (SimpleJSON.且丐上一丝业不专上)val_4;
            }
            
            val_4 = 0;
            return (SimpleJSON.且丐上一丝业不专上)val_4;
        }
        public override SimpleJSON.且丐上一丝业不专上 Remove(int 丌丑丐丞丞丅专与丒)
        {
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.且丐上一丝业不专上> val_5;
            var val_6;
            val_5 = this;
            if((丌丑丐丞丞丅专与丒 & 2147483648) == 0)
            {
                    if(this.下专丐业丑丞丈丛丙.Count > 丌丑丐丞丞丅专与丒)
            {
                    System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>>(source:  this.下专丐业丑丞丈丛丙, index:  丌丑丐丞丞丅专与丒);
                val_5 = this.下专丐业丑丞丈丛丙;
                bool val_4 = val_5.Remove(key:  val_2.Value.丐丏七丌丕丗业且上());
                val_6;
                return (SimpleJSON.且丐上一丝业不专上)val_6;
            }
            
            }
            
            val_6 = 0;
            return (SimpleJSON.且丐上一丝业不专上)val_6;
        }
        public override SimpleJSON.且丐上一丝业不专上 Remove(SimpleJSON.且丐上一丝业不专上 与一丕三世上丆不专)
        {
            .与一丕三世上丆不专 = 与一丕三世上丆不专;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>, System.Boolean>(object:  new 丁丕下丗丝业丕丙丅.丒丛丁与丅东丒不七(), method:  System.Boolean 丁丕下丗丝业丕丙丅.丒丛丁与丅东丒不七::丐丗一丂丙丒丆丁东(System.Collections.Generic.KeyValuePair<string, SimpleJSON.且丐上一丝业不专上> 丟三下万一丄七一丗));
            System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.且丐上一丝业不专上>>(source:  this.下专丐业丑丞丈丛丙, predicate:  null));
            bool val_6 = this.下专丐业丑丞丈丛丙.Remove(key:  val_4.Value.丐丏七丌丕丗业且上());
            return (SimpleJSON.且丐上一丝业不专上)(丁丕下丗丝业丕丙丅.丒丛丁与丅东丒不七)[1152921541560981344].与一丕三世上丆不专;
        }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.且丐上一丝业不专上> 与业不丐专丞丒丆东()
        {
            .丗丏丅丕丆世丁专丟 = -2;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.且丐上一丝业不专上>)new 丁丕下丗丝业丕丙丅.三丟三世下丞世丘丝();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丁丕下丗丝业丕丙丅.且下上丞丈万丞丛丆();
        }
        public override string ToString()
        {
            var val_4;
            string val_13;
            string val_14;
            string val_15;
            val_13 = "{";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.下专丐业丑丞丈丛丙.GetEnumerator();
            label_23:
            val_14 = val_13;
            if(((-1700201568) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(Length < 3)
            {
                    val_15 = val_13;
            }
            else
            {
                    val_15 = val_13 + ", ";
            }
            
            string[] val_8 = new string[5];
            val_8[0] = val_15;
            val_8[1] = "\"";
            val_8[2] = SimpleJSON.且丐上一丝业不专上.丐且丈下丟丁下专丕(一丈丒专丕业丒业上:  val_5._value._obj.丐丏七丌丕丗业且上());
            val_8[3] = "\":";
            val_8[4] = ;
            string val_11 = +val_8;
            goto label_23;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_13 + "}";
        }
        public override string 一丁与丙世与东丆丆(string 三丁丞且丌万丛丝专)
        {
            var val_4;
            string val_15;
            string val_16;
            string val_17;
            string val_18;
            string val_20;
            val_15 = 三丁丞且丌万丛丝专;
            val_16 = "{ ";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.下专丐业丑丞丈丛丙.GetEnumerator();
            val_17 = "\n";
            label_22:
            if(((-1700019680) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
            if(Length >= 4)
            {
                    val_18 = val_16 + ", ";
            }
            
            string[] val_9 = new string[5];
            val_9[0] = val_18 + "\n" + val_15 + "   ";
            val_9[1] = "\"";
            val_9[2] = SimpleJSON.且丐上一丝业不专上.丐且丈下丟丁下专丕(一丈丒专丕业丒业上:  val_5._value._obj.丐丏七丌丕丗业且上());
            val_9[3] = "\" : ";
            string val_12 = val_15 + "   ";
            val_9[4] = ;
            string val_13 = +val_9;
            goto label_22;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_20 + val_17 + val_15 + "}";
        }
        public override void 丙业不丝丗丌丗世下(System.IO.BinaryWriter 丕丅丕丘万专丟丆丞)
        {
            int val_1 = this.下专丐业丑丞丈丛丙.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.下专丐业丑丞丈丛丙.Keys.GetEnumerator();
            label_8:
            if(((-1699832840) & 1) == 0)
            {
                goto label_5;
            }
            
            if(this.下专丐业丑丞丈丛丙.Item[0.丐丏七丌丕丗业且上()] != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public 丁丕下丗丝业丕丙丅()
        {
            this.下专丐业丑丞丈丛丙 = new System.Collections.Generic.Dictionary<System.String, SimpleJSON.且丐上一丝业不专上>();
            this = new System.Object();
        }
    
    }

}
