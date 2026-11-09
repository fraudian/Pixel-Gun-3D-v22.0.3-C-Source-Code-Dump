using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 丂丆丞一丁丗万上丌 : ICloneable
    {
        // Fields
        internal int LastSelectedBundleId;
        internal int SelectedAtLevel;
        internal int LastSelectedTime;
        internal System.Collections.Generic.List<int> SkippedBundles;
        
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(Rilisoft.Offers.丂丆丞一丁丗万上丌 七丏丄丅丌业与且丙)
        {
            var val_6;
            System.Func<System.Int32, System.Int32> val_8;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "b", value:  七丏丄丅丌业与且丙.LastSelectedBundleId);
            val_1.set_Item(key:  "sl", value:  七丏丄丅丌业与且丙.SelectedAtLevel);
            val_1.set_Item(key:  "st", value:  七丏丄丅丌业与且丙.LastSelectedTime);
            if(七丏丄丅丌业与且丙.SkippedBundles == null)
            {
                goto label_5;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = 丂丆丞一丁丗万上丌.<>c.<>9__4_0;
            if(val_8 == null)
            {
                    System.Func<System.Int32, System.Int32> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Func<System.Int32, System.Int32>(object:  丂丆丞一丁丗万上丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丂丆丞一丁丗万上丌.<>c::丗丂一丏丂万丘三世(int 七丞丙丒三丕且丌丟));
                丂丆丞一丁丗万上丌.<>c.<>9__4_0 = val_8;
            }
            
            if(val_1 != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            val_1.set_Item(key:  "sb", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.Int32, System.Int32>(source:  七丏丄丅丌业与且丙.SkippedBundles, selector:  val_2)));
            return val_1;
            label_5:
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            if(val_1 != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丝丟丛丘一一且上三(Rilisoft.Offers.丂丆丞一丁丗万上丌 丛三七丟丗与专丙丂, Rilisoft.Offers.丂丆丞一丁丗万上丌 三丂丑丁丞丞丅东三)
        {
            Rilisoft.Offers.丂丆丞一丁丗万上丌 val_9;
            var val_10;
            System.Collections.Generic.List<System.Int32> val_11;
            var val_12;
            System.Func<System.Int32, System.Int32> val_14;
            string val_15;
            object val_16;
            var val_17;
            Rilisoft.Offers.丂丆丞一丁丗万上丌 val_18;
            val_9 = 丛三七丟丗与专丙丂;
            if((三丂丑丁丞丞丅东三 | val_9) == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
                val_10 = val_2;
                val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_10;
            }
            
            if(val_9 == null)
            {
                goto label_3;
            }
            
            if(三丂丑丁丞丞丅东三 == null)
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_10 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(丛三七丟丗与专丙丂.LastSelectedBundleId != 三丂丑丁丞丞丅东三.LastSelectedBundleId)
            {
                    val_3.Add(key:  "b", value:  三丂丑丁丞丞丅东三.LastSelectedBundleId);
            }
            
            if(丛三七丟丗与专丙丂.SelectedAtLevel != 三丂丑丁丞丞丅东三.SelectedAtLevel)
            {
                    val_3.Add(key:  "sl", value:  三丂丑丁丞丞丅东三.SelectedAtLevel);
            }
            
            if(丛三七丟丗与专丙丂.LastSelectedTime != 三丂丑丁丞丞丅东三.LastSelectedTime)
            {
                    val_3.Add(key:  "st", value:  三丂丑丁丞丞丅东三.LastSelectedTime);
            }
            
            val_11 = 三丂丑丁丞丞丅东三.SkippedBundles;
            if(val_11 == null)
            {
                goto label_11;
            }
            
            if(丛三七丟丗与专丙丂.SkippedBundles != null)
            {
                    if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  val_11, second:  丛三七丟丗与专丙丂.SkippedBundles)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_10;
            }
            
                val_11 = 三丂丑丁丞丞丅东三.SkippedBundles;
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = 丂丆丞一丁丗万上丌.<>c.<>9__5_0;
            if(val_14 == null)
            {
                    System.Func<System.Int32, System.Int32> val_5 = null;
                val_14 = val_5;
                val_5 = new System.Func<System.Int32, System.Int32>(object:  丂丆丞一丁丗万上丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丂丆丞一丁丗万上丌.<>c::丕一丌丈世丕丟一丕(int 七丞丙丒三丕且丌丟));
                丂丆丞一丁丗万上丌.<>c.<>9__5_0 = val_14;
            }
            
            val_9 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<System.Int32, System.Int32>(source:  val_11, selector:  val_5));
            val_15 = "sb";
            val_16 = val_9;
            val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_20;
            label_3:
            val_18 = 三丂丑丁丞丞丅东三;
            return Rilisoft.Offers.丂丆丞一丁丗万上丌.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_18 = val_9);
            label_4:
            return Rilisoft.Offers.丂丆丞一丁丗万上丌.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_18);
            label_11:
            System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
            val_16 = val_8;
            val_15 = "sb";
            val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_20:
            val_3.Add(key:  val_15, value:  val_8);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_10;
        }
        public object Clone()
        {
            int val_3;
            System.Collections.Generic.List<System.Int32> val_4;
            Rilisoft.Offers.丂丆丞一丁丗万上丌 val_1 = new Rilisoft.Offers.丂丆丞一丁丗万上丌();
            if(val_1 != null)
            {
                    .LastSelectedBundleId = this.LastSelectedBundleId;
                .SelectedAtLevel = this.SelectedAtLevel;
                val_3 = this.LastSelectedTime;
            }
            else
            {
                    mem[16] = this.LastSelectedBundleId;
                .SelectedAtLevel = this.SelectedAtLevel;
                val_3 = this.LastSelectedTime;
            }
            
            .LastSelectedTime = val_3;
            val_4 = this.SkippedBundles;
            .SkippedBundles = System.Linq.Enumerable.ToList<System.Int32>(source:  val_4);
            return (object)val_1;
        }
        public 丂丆丞一丁丗万上丌()
        {
            this.SkippedBundles = new System.Collections.Generic.List<System.Int32>();
        }
    
    }

}
