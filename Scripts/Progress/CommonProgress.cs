using UnityEngine;

namespace Progress
{
    [Serializable]
    internal class CommonProgress : ICloneable
    {
        // Fields
        internal System.Collections.Generic.List<CategoryNames> LastBougthWeaponCategories;
        
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(Progress.CommonProgress 七丏丄丅丌业与且丙)
        {
            var val_6;
            System.Func<CategoryNames, System.Int32> val_8;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(七丏丄丅丌业与且丙.LastBougthWeaponCategories == null)
            {
                goto label_2;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = CommonProgress.<>c.<>9__1_0;
            if(val_8 == null)
            {
                    System.Func<CategoryNames, System.Int32> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Func<CategoryNames, System.Int32>(object:  CommonProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CommonProgress.<>c::东丄丅丄且东丘下丛(CategoryNames 七丞丙丒三丕且丌丟));
                CommonProgress.<>c.<>9__1_0 = val_8;
            }
            
            if(val_1 != null)
            {
                goto label_9;
            }
            
            label_10:
            label_9:
            val_1.set_Item(key:  "wc", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<CategoryNames, System.Int32>(source:  七丏丄丅丌业与且丙.LastBougthWeaponCategories, selector:  val_2)));
            return val_1;
            label_2:
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            if(val_1 != null)
            {
                goto label_9;
            }
            
            goto label_10;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丝丟丛丘一一且上三(Progress.CommonProgress 丛三七丟丗与专丙丂, Progress.CommonProgress 三丂丑丁丞丞丅东三)
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<CategoryNames> val_11;
            var val_12;
            System.Func<CategoryNames, System.Int32> val_14;
            object val_15;
            string val_16;
            var val_17;
            Progress.CommonProgress val_18;
            val_9 = 三丂丑丁丞丞丅东三;
            if((val_9 | 丛三七丟丗与专丙丂) == null)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = null;
                val_10 = val_2;
                val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_10;
            }
            
            if(丛三七丟丗与专丙丂 == null)
            {
                goto label_3;
            }
            
            if(val_9 == null)
            {
                goto label_4;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_10 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_11 = 三丂丑丁丞丞丅东三.LastBougthWeaponCategories;
            if(val_11 == null)
            {
                goto label_5;
            }
            
            if(丛三七丟丗与专丙丂.LastBougthWeaponCategories != null)
            {
                    if((System.Linq.Enumerable.SequenceEqual<CategoryNames>(first:  val_11, second:  丛三七丟丗与专丙丂.LastBougthWeaponCategories)) == true)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_10;
            }
            
                val_11 = 三丂丑丁丞丞丅东三.LastBougthWeaponCategories;
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = CommonProgress.<>c.<>9__2_0;
            val_9 = "wc";
            if(val_14 == null)
            {
                    System.Func<CategoryNames, System.Int32> val_5 = null;
                val_14 = val_5;
                val_5 = new System.Func<CategoryNames, System.Int32>(object:  CommonProgress.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CommonProgress.<>c::丕丏丛丅丗丟丌丞丟(CategoryNames 七丞丙丒三丕且丌丟));
                CommonProgress.<>c.<>9__2_0 = val_14;
            }
            
            val_15 = System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<CategoryNames, System.Int32>(source:  val_11, selector:  val_5));
            val_16 = val_9;
            val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            goto label_14;
            label_3:
            val_18 = val_9;
            return Progress.CommonProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_18 = 丛三七丟丗与专丙丂);
            label_4:
            return Progress.CommonProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_18);
            label_5:
            System.Collections.Generic.List<System.Int32> val_8 = null;
            val_15 = val_8;
            val_8 = new System.Collections.Generic.List<System.Int32>();
            val_16 = "wc";
            val_17 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            label_14:
            val_3.Add(key:  val_16, value:  val_8);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_10;
        }
        public object Clone()
        {
            Progress.CommonProgress val_1 = new Progress.CommonProgress();
            if(this.LastBougthWeaponCategories == null)
            {
                goto label_1;
            }
            
            if(val_1 != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            .LastBougthWeaponCategories = System.Linq.Enumerable.ToList<CategoryNames>(source:  this.LastBougthWeaponCategories);
            return (object)val_1;
            label_1:
            System.Collections.Generic.List<CategoryNames> val_3 = new System.Collections.Generic.List<CategoryNames>();
            if(val_1 != null)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public CommonProgress()
        {
            this.LastBougthWeaponCategories = new System.Collections.Generic.List<CategoryNames>();
        }
    
    }

}
