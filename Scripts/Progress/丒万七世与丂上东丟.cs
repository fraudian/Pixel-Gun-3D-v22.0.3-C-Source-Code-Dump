using UnityEngine;

namespace Progress
{
    internal class 丒万七世与丂上东丟 : 丙丕丈一一丝丑七丈
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, System.ValueTuple<ulong, ulong>> 丝丆丟丝丁丂丐且与;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            return "MapSecretsSlot";
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            return "MapSecretsSlot";
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 62;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            return Progress.丗东丞丆丆丝丒丌专.丒丟丟一万丅三丑丛(下下丏一丙不丘丌丞:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_5;
            var val_16;
            string val_17;
            int val_18;
            string val_19;
            val_16 = this;
            ulong val_11 = 0;
            ulong val_9 = 0;
            this.丝丆丟丝丁丂丐且与.Clear();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 一丐丗丁丞丆丅丟丄 : 0.GetEnumerator();
            label_17:
            if(((-1960259696) & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            if((val_6._value._obj == 0) || (val_6._value._obj != null))
            {
                goto label_17;
            }
            
            char[] val_7 = new char[1];
            val_7[0] = '.';
            System.String[] val_8 = val_6._value._obj.Split(separator:  val_7);
            val_17 = "0UL";
            val_18 = val_8.Length;
            if(val_18 != 0)
            {
                    if(val_18 == 0)
            {
                    val_18 = val_8.Length;
            }
            
                val_19 = val_8[0];
            }
            else
            {
                    val_19 = val_17;
            }
            
            if(val_18 >= 2)
            {
                    val_17 = val_8[1];
            }
            
            bool val_10 = System.UInt64.TryParse(s:  val_19, result: out  val_9);
            bool val_12 = System.UInt64.TryParse(s:  val_17, result: out  val_11);
            val_5 = 0;
            MoonSharp.Interpreter.TablePair val_14 = new MoonSharp.Interpreter.TablePair(key:  val_9, val:  val_11);
            this.丝丆丟丝丁丂丐且与.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  new System.ValueTuple<System.UInt64, System.UInt64>() {Item2 = val_14.key});
            goto label_17;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            object val_5;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.丝丆丟丝丁丂丐且与.GetEnumerator();
            label_4:
            if(((-1960035104) & 1) == 0)
            {
                goto label_2;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_3 = 0.RemoteEndpoint;
            val_1.set_Item(key:  val_5.丐丏七丌丕丗业且上(), value:  System.String.Format(format:  "{0}.{1}", arg0:  val_5, arg1:  public System.ValueTuple<System.UInt64, System.UInt64> System.Collections.Generic.KeyValuePair<System.String, System.ValueTuple<System.UInt64, System.UInt64>>::get_Value()));
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.丝丆丟丝丁丂丐且与.Clear();
        }
        internal bool 不丆专丅丗且丑不世(int 丅东与业丒一业万丅, string 七丆丂丂下丈且丟世, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            var val_5;
            string val_1 = (上且丗一丏丏万丅丌 == 20) ? "battle_royale" : "freeplay_city";
            if(val_1 == 0)
            {
                    return false;
            }
            
            if((this.丝丆丟丝丁丂丐且与.TryGetValue(key:  val_1, value: out  new System.ValueTuple<System.UInt64, System.UInt64>())) == false)
            {
                    return false;
            }
            
            if(丅东与业丒一业万丅 >= 128)
            {
                goto label_4;
            }
            
            if(丅东与业丒一业万丅 <= 63)
            {
                goto label_5;
            }
            
            val_5 = 0;
            goto label_6;
            label_4:
            UnityEngine.Debug.LogError(message:  "[MapSecretsSlot] Secret index must be in range [0, 127]");
            return false;
            label_5:
            val_5 = 0;
            label_6:
            int val_3 = 丅东与业丒一业万丅 & 63;
            val_3 = 1 << val_3;
            var val_4 = (0 != val_3) ? 1 : 0;
            return false;
        }
        internal void 专丒丅丝丑丁丒丛与(int 丅东与业丒一业万丅, string 七丆丂丂下丈且丟世, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            int val_5 = 丅东与业丒一业万丅;
            string val_1 = (上且丗一丏丏万丅丌 == 20) ? "battle_royale" : "freeplay_city";
            if(val_1 == 0)
            {
                    return;
            }
            
            if(val_5 < 128)
            {
                    bool val_2 = this.丝丆丟丝丁丂丐且与.TryGetValue(key:  val_1, value: out  new System.ValueTuple<System.UInt64, System.UInt64>());
                int val_5 = (val_5 > 63) ? -1959495768 : ();
                int val_4 = val_5 & 63;
                val_4 = 1 << val_4;
                val_5 = val_5 | val_4;
                mem2[0] = val_5;
                val_5 = 0;
                this.丝丆丟丝丁丂丐且与.set_Item(key:  val_1, value:  new System.ValueTuple<System.UInt64, System.UInt64>());
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "[SetSecretPickedUp] Secret index must be in range [0, 127]");
        }
        public 丒万七世与丂上东丟()
        {
            this.丝丆丟丝丁丂丐且与 = new System.Collections.Generic.Dictionary<System.String, System.ValueTuple<System.UInt64, System.UInt64>>();
        }
    
    }

}
