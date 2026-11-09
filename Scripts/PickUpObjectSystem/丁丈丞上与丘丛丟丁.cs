using UnityEngine;

namespace PickUpObjectSystem
{
    internal sealed class 丁丈丞上与丘丛丟丁
    {
        // Fields
        private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>> 三与东七世与丈与且;
        private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Collections.Generic.List<System.Type>>> 丞下万万下丛业丗丕;
        private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, string>> 丕丐丕丟世丒丙丕上;
        private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>> 丒丞东东丂万世丆丁;
        
        // Methods
        internal static PickUpObjectSystem.PickUpObject 七世丙丂东东丌专丕(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, PickUpObjectSystem.丈东丐世丌丏丞丂世 丂一丘丞丗下丝丁丞, string 丞丅上丏丂且下丅与, object[] 丗专丆万丏万丂丂丆)
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_18 = null;
            val_18 = null;
            object val_3 = System.Activator.CreateInstance(type:  PickUpObjectSystem.丁丈丞上与丘丛丟丁.丒丞东东丂万世丆丁.Item[上且丗一丏丏万丅丌].Item[丂一丘丞丗下丝丁丞]);
            string val_5 = PickUpObjectSystem.丁丈丞上与丘丛丟丁.丕丐丕丟世丒丙丕上.Item[上且丗一丏丏万丅丌].Item[丂一丘丞丗下丝丁丞];
            if(val_3 != null)
            {
                    val_19 = null;
                val_19 = null;
                var val_6 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PickUpObjectSystem.丕丈一七丗且丐丟丐.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_19) ? (val_3) : 0;
            }
            else
            {
                    val_20 = 0;
            }
            
            PickUpObjectSystem.PickUpObject val_7 = val_20.AddComponent<PickUpObjectSystem.PickUpObject>();
            if(val_7 != null)
            {
                    val_7.丙丌丂丄丌丄业丏丑 = 丂一丘丞丗下丝丁丞;
            }
            else
            {
                    mem[80] = 丂一丘丞丗下丝丁丞;
            }
            
            UnityEngine.Component val_11 = val_7.gameObject.AddComponent(componentType:  PickUpObjectSystem.丁丈丞上与丘丛丟丁.三与东七世与丈与且.Item[上且丗一丏丏万丅丌].Item[丂一丘丞丗下丝丁丞]);
            val_7.七东丅丄业丒丅丁丕 = 0;
            val_21 = PickUpObjectSystem.丁丈丞上与丘丛丟丁.丞下万万下丛业丗丕.Item[上且丗一丏丏万丅丌].Item[丂一丘丞丗下丝丁丞];
            List.Enumerator<T> val_14 = val_21.GetEnumerator();
            label_29:
            if((1894428120 & 1) == 0)
            {
                goto label_24;
            }
            
            object val_16 = System.Activator.CreateInstance(type:  0.丐丏七丌丕丗业且上());
            val_22 = 0;
            val_7.丄不世丘丟不丄业丌.Add(item:  null);
            goto label_29;
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_7;
        }
        public 丁丈丞上与丘丛丟丁()
        {
        
        }
        private static 丁丈丞上与丘丛丟丁()
        {
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>>();
            System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type> val_2 = new System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>();
            val_2.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_2.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  20, value:  val_2);
            PickUpObjectSystem.丁丈丞上与丘丛丟丁.三与东七世与丈与且 = val_1;
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Collections.Generic.List<System.Type>>> val_5 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Collections.Generic.List<System.Type>>>();
            System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Collections.Generic.List<System.Type>> val_6 = new System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Collections.Generic.List<System.Type>>();
            System.Collections.Generic.List<System.Type> val_7 = new System.Collections.Generic.List<System.Type>();
            val_7.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_7.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_6.Add(key:  1, value:  val_7);
            System.Collections.Generic.List<System.Type> val_10 = new System.Collections.Generic.List<System.Type>();
            val_10.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_10.Add(item:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_6.Add(key:  2, value:  val_10);
            val_5.Add(key:  20, value:  val_6);
            PickUpObjectSystem.丁丈丞上与丘丛丟丁.丞下万万下丛业丗丕 = val_5;
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.String>> val_13 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.String>>();
            System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.String> val_14 = new System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.String>();
            if(val_14 != null)
            {
                    val_14.Add(key:  1, value:  "GadgetBRPrefab/");
            }
            else
            {
                    val_14.Add(key:  1, value:  "GadgetBRPrefab/");
            }
            
            val_14.Add(key:  2, value:  "GadgetBRPrefab/");
            val_13.Add(key:  20, value:  val_14);
            PickUpObjectSystem.丁丈丞上与丘丛丟丁.丕丐丕丟世丒丙丕上 = val_13;
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>> val_15 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>>();
            System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type> val_16 = new System.Collections.Generic.Dictionary<PickUpObjectSystem.丈东丐世丌丏丞丂世, System.Type>();
            val_16.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_16.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_15.Add(key:  20, value:  val_16);
            PickUpObjectSystem.丁丈丞上与丘丛丟丁.丒丞东东丂万世丆丁 = val_15;
        }
    
    }

}
