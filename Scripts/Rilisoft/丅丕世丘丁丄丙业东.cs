using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丅丕世丘丁丄丙业东 : 丙丐丐丙丈业丒不丁
    {
        // Methods
        protected override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 下丟不上丏丝丞丒丟(AGSGameDataMap 丟丝上三丙丁丁世丁)
        {
            var val_8;
            System.Func<AGSSyncableStringElement, System.String> val_10;
            AGSSyncableStringSet val_1 = 丟丝上三丙丁丁世丁.GetStringSet(name:  "purchases");
            val_8 = null;
            val_8 = null;
            val_10 = 丅丕世丘丁丄丙业东.<>c.<>9__0_0;
            if(val_10 == null)
            {
                    val_10 = null;
                val_10 = new System.Func<AGSSyncableStringElement, System.String>(object:  丅丕世丘丁丄丙业东.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丅丕世丘丁丄丙业东.<>c::且世丅丘万东丐世丁(AGSSyncableStringElement 丏丛与丅丛丌万专丌));
                丅丕世丘丁丄丙业东.<>c.<>9__0_0 = val_10;
            }
            
            this.丄丈上一丙且万丅丞(丙业与丙丗丝不丈东:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<AGSSyncableStringElement, System.String>(source:  val_1.GetValues(), selector:  null))));
            this.丞专世丗丛不丘丗丘(丙业与丙丗丝不丈东:  true);
            if(val_1 == null)
            {
                    return System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_1.Dispose();
            return System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
        }
        protected override void 且且且丝丆一丄丗一(AGSGameDataMap 丟丝上三丙丁丁世丁, string 一丐丗丁丞丆丅丟丄)
        {
            var val_5;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            string val_8 = 一丐丗丁丞丆丅丟丄;
            val_10 = 丟丝上三丙丁丁世丁;
            if(val_8 == null)
            {
                    return;
            }
            
            object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_8);
            if(val_1 == null)
            {
                    return;
            }
            
            val_8 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
            val_10 = val_10.GetStringSet(name:  "purchases");
            List.Enumerator<T> val_3 = val_8.GetEnumerator();
            label_11:
            if(((-765968672) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if((val_6 == null) || (null != null))
            {
                goto label_11;
            }
            
            val_10.Add(val:  val_6);
            goto label_11;
            label_7:
            val_11 = 0;
            val_12 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_16;
            }
            
            val_9 = 0;
            if(val_10 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_16:
            if( != 0)
            {
                    val_12 = 0;
            }
            
            val_9 = 0;
            if(val_10 != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_20:
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_10.Dispose();
            label_23:
            if( != 1)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public 丅丕世丘丁丄丙业东()
        {
        
        }
    
    }

}
