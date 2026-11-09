using UnityEngine;

namespace PGCompany.GameplayLoop
{
    internal sealed class 丟三丐丒丏一上丙丐
    {
        // Fields
        private static PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 丝业丆丁业三丈丟东;
        private System.Collections.Generic.Dictionary<int, PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 世丕东丑丟丏业业丐;
        
        // Properties
        internal static PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 丑七不且上丗丁一世()
        {
            PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 val_2;
            PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 val_3 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丝业丆丁业三丈丟东;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.GameplayLoop.丟三丐丒丏一上丙丐();
            PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丝业丆丁业三丈丟东 = val_2;
            val_3 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丝业丆丁业三丈丟东;
            return val_3;
        }
        internal 丟三丐丒丏一上丙丐()
        {
            this.世丕东丑丟丏业业丐 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.GameplayLoop.业丒丅丂丗丁业上且>();
            this.业丌丑丒七东且丈三(丁丅丈丌丟世丗丗丟:  4, 东且丒丌且丈丞丗与:  new PGCompany.GameplayLoop.七丏丛丐三丐专丌东());
            mem[1152921560177689008] = 1;
            this.业丌丑丒七东且丈三(丁丅丈丌丟世丗丗丟:  1, 东且丒丌且丈丞丗与:  new PGCompany.GameplayLoop.丝丛丗丄丝丅丘丌东());
            this.业丌丑丒七东且丈三(丁丅丈丌丟世丗丗丟:  3, 东且丒丌且丈丞丗与:  new PGCompany.GameplayLoop.丝丌上丏丘三丐丙丌());
            mem[1152921560177697200] = 0;
            this.业丌丑丒七东且丈三(丁丅丈丌丟世丗丗丟:  0, 东且丒丌且丈丞丗与:  new PGCompany.GameplayLoop.丕与七丐丞丕丑业世());
            this.业丌丑丒七东且丈三(丁丅丈丌丟世丗丗丟:  2, 东且丒丌且丈丞丗与:  new PGCompany.GameplayLoop.丏丟丘丐丏丞三七丕());
            this.业丌丑丒七东且丈三(丁丅丈丌丟世丗丗丟:  5, 东且丒丌且丈丞丗与:  new PGCompany.GameplayLoop.丕丌东与丘业丈丏丆());
        }
        internal PGCompany.GameplayLoop.业丒丅丂丗丁业上且 丏丈丞丅丒与丄业东(PGCompany.GameplayLoop.GameplayLoopType 丁丅丈丌丟世丗丗丟)
        {
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_5;
            var val_6;
            val_5 = this;
            if((this.世丕东丑丟丏业业丐.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) != false)
            {
                    val_5 = this.世丕东丑丟丏业业丐;
                PGCompany.GameplayLoop.业丒丅丂丗丁业上且 val_2 = val_5.Item[丁丅丈丌丟世丗丗丟];
                return (PGCompany.GameplayLoop.业丒丅丂丗丁业上且)val_6;
            }
            
            val_6 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return (PGCompany.GameplayLoop.业丒丅丂丗丁业上且)val_6;
            }
            
            object[] val_4 = new object[1];
            val_5 = val_4;
            val_5[0] = 丁丅丈丌丟世丗丗丟;
            UnityEngine.Debug.LogErrorFormat(format:  "Loop {0} you want to get does not exists. Return value is null.", args:  val_4);
            val_6 = 0;
            return (PGCompany.GameplayLoop.业丒丅丂丗丁业上且)val_6;
        }
        private void 业丌丑丒七东且丈三(PGCompany.GameplayLoop.GameplayLoopType 丁丅丈丌丟世丗丗丟, PGCompany.GameplayLoop.业丒丅丂丗丁业上且 东且丒丌且丈丞丗与)
        {
            this.世丕东丑丟丏业业丐.set_Item(key:  丁丅丈丌丟世丗丗丟, value:  东且丒丌且丈丞丗与);
        }
        internal System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 七丏专丆丐丘专丕丝(string 下丅丙一丂丗丅丝七)
        {
            System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_1 = new System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.世丕东丑丟丏业业丐.GetEnumerator();
            label_6:
            if(((-263323976) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(( & 1) == 0)
            {
                goto label_6;
            }
            
            bool val_4 = val_1.Add(item:  val_3._value._obj);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> 丐丕业丙丗业丏丛且(string 下丅丙一丂丗丅丝七)
        {
            System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_1 = new System.Collections.Generic.HashSet<PGCompany.GameplayLoop.业丒丅丂丗丁业上且>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.世丕东丑丟丏业业丐.GetEnumerator();
            label_6:
            if(((-263187400) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(( & 1) == 0)
            {
                goto label_6;
            }
            
            bool val_4 = val_1.Add(item:  val_3._value._obj);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal bool 丅世丘业丙丞丆丕丞(string 下丅丙一丂丗丅丝七)
        {
            var val_4;
            var val_5;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下丅丙一丂丗丅丝七)) == true)
            {
                goto label_3;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.世丕东丑丟丏业业丐.GetEnumerator();
            val_4 = 1152921560178080848;
            label_7:
            if(((-263054904) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(( & 1) == 0)
            {
                goto label_7;
            }
            
            val_5 = 1;
            goto label_8;
            label_5:
            val_5 = 0;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_5;
            label_3:
            val_5 = 0;
            return (bool)val_5;
        }
        internal bool 丝丈专丝丂丄万丟与(string 下丅丙一丂丗丅丝七, PGCompany.GameplayLoop.GameplayLoopType 丙上丟丕丒丆丝丟一 = -1, bool 丘丄一丘丁丞丘丆且 = False)
        {
            var val_6;
            var val_7;
            var val_8;
            val_7 = 丘丄一丘丁丞丘丆且;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下丅丙一丂丗丅丝七)) == true)
            {
                goto label_3;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.世丕东丑丟丏业业丐.GetEnumerator();
            val_6 = 1152921560178080848;
            val_7 = val_7;
            label_8:
            if(((-262921416) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(val_3._value._obj.丙东专丂世丈丏丁丂() == 丙上丟丕丒丆丝丟一)
            {
                goto label_8;
            }
            
            if(( & 1) == 0)
            {
                goto label_8;
            }
            
            val_8 = 1;
            goto label_9;
            label_5:
            val_8 = 0;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_8;
            label_3:
            val_8 = 0;
            return (bool)val_8;
        }
        internal bool 丆与与七丛丁七业丛(PGCompany.GameplayLoop.GameplayLoopType 丁丅丈丌丟世丗丗丟, string 下丅丙一丂丗丅丝七)
        {
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_4;
            var val_5;
            val_4 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下丅丙一丂丗丅丝七)) == true)
            {
                goto label_3;
            }
            
            val_4 = this.世丕东丑丟丏业业丐;
            Dictionary.Enumerator<TKey, TValue> val_2 = val_4.GetEnumerator();
            label_9:
            if(((-262784824) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(( & 1) == 0)
            {
                goto label_9;
            }
            
            val_4;
            if(0 != 丁丅丈丌丟世丗丗丟)
            {
                goto label_9;
            }
            
            val_5 = 1;
            goto label_10;
            label_5:
            val_5 = 0;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_5;
            label_3:
            val_5 = 0;
            return (bool)val_5;
        }
        internal bool 丐丌丈丞上七一与丗(PGCompany.GameplayLoop.GameplayLoopType 丁丅丈丌丟世丗丗丟, string 下丅丙一丂丗丅丝七)
        {
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.GameplayLoop.业丒丅丂丗丁业上且> val_4;
            var val_5;
            val_4 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下丅丙一丂丗丅丝七)) == true)
            {
                goto label_3;
            }
            
            val_4 = this.世丕东丑丟丏业业丐;
            Dictionary.Enumerator<TKey, TValue> val_2 = val_4.GetEnumerator();
            label_9:
            if(((-262648248) & 1) == 0)
            {
                goto label_5;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            if(( & 1) == 0)
            {
                goto label_9;
            }
            
            val_4;
            if(0 != 丁丅丈丌丟世丗丗丟)
            {
                goto label_9;
            }
            
            val_5 = 1;
            goto label_10;
            label_5:
            val_5 = 0;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_5;
            label_3:
            val_5 = 0;
            return (bool)val_5;
        }
        internal void 下丐丟专丗丅丘不丕(System.Collections.Generic.ICollection<string> 且丙丕丒丕丅世一丏, System.Nullable<PGCompany.GameplayLoop.GameplayLoopType> 丁丅丈丌丟世丗丗丟)
        {
            PGCompany.GameplayLoop.丟三丐丒丏一上丙丐 val_3 = this;
            丟三丐丒丏一上丙丐.世东丒与丞七不不东 val_1 = new 丟三丐丒丏一上丙丐.世东丒与丞七不不东();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = val_3;
            }
            else
            {
                    mem[16] = val_3;
            }
            
            .且丙丕丒丕丅世一丏 = 且丙丕丒丕丅世一丏;
            if(((-262502392) & 1) != 0)
            {
                    this.下丐丟专丗丅丘不丕(且丙丕丒丕丅世一丏:  (丟三丐丒丏一上丙丐.世东丒与丞七不不东)[1152921560178967568].且丙丕丒丕丅世一丏, 丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟.HasValue);
                return;
            }
            
            System.Action<PGCompany.GameplayLoop.GameplayLoopType> val_2 = null;
            val_3 = val_2;
            val_2 = new System.Action<PGCompany.GameplayLoop.GameplayLoopType>(object:  val_1, method:  System.Void 丟三丐丒丏一上丙丐.世东丒与丞七不不东::丙下丅丝下丂丄丆东(PGCompany.GameplayLoop.GameplayLoopType 丙丒七丄上与丏丙丙));
            丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<PGCompany.GameplayLoop.GameplayLoopType>(七丐丅专且专七三丆:  val_2);
        }
        private void 下丐丟专丗丅丘不丕(System.Collections.Generic.ICollection<string> 且丙丕丒丕丅世一丏, PGCompany.GameplayLoop.GameplayLoopType 丁丅丈丌丟世丗丗丟)
        {
            var val_5;
            var val_10;
            var val_11;
            var val_12;
            var val_14;
            val_10 = 且丙丕丒丕丅世一丏;
            val_11 = this;
            if(丁丅丈丌丟世丗丗丟 == 1)
            {
                    return;
            }
            
            if((this.世丕东丑丟丏业业丐.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) == false)
            {
                    return;
            }
            
            val_12 = public PGCompany.GameplayLoop.业丒丅丂丗丁业上且 System.Collections.Generic.Dictionary<System.Int32, PGCompany.GameplayLoop.业丒丅丂丗丁业上且>::get_Item(System.Int32 key);
            PGCompany.GameplayLoop.业丒丅丂丗丁业上且 val_2 = this.世丕东丑丟丏业业丐.Item[丁丅丈丌丟世丗丗丟];
            HashSet.Enumerator<T> val_3 = val_2.<万丞丛丙不上丂三丕>k__BackingField.GetEnumerator();
            val_11 = 1152921531056473744;
            label_19:
            if(((-262345360) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = 4;
            val_14 = public System.Boolean System.Collections.Generic.ICollection<T>::Contains(T item);
            if((val_10.Contains(item:  null)) == true)
            {
                goto label_19;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_14 = 2;
            val_10.Add(item:  null);
            goto label_19;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
    
    }

}
