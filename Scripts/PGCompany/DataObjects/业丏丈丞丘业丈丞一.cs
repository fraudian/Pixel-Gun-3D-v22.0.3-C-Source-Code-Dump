using UnityEngine;

namespace PGCompany.DataObjects
{
    internal class 业丏丈丞丘业丈丞一
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丑东东七世丗不且一;
        internal System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业> Data;
        internal System.Collections.Generic.List<PGCompany.DataObjects.丈专丕下丂丏三专且> GatchaItems;
        internal PGCompany.DataObjects.世上丛丄丛专东丏丟 Settings;
        internal System.Collections.Generic.Dictionary<int, GiftCategoryType> GatchaSequence;
        internal PGCompany.DataObjects.七七丙丗丏丑专业丝 Schedule;
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> 七丆业丁东下与丕与;
        
        // Properties
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 三丘下三不且丌丛与 { get; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>> 丟丆世丕专丞业丑丌()
        {
            var val_5;
            var val_12;
            System.Func<System.Int32, PGCompany.三东丏不丗世丅丌丄> val_14;
            if(this.丑东东七世丗不且一 != null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>)this.丑东东七世丗不且一;
            }
            
            this.丑东东七世丗不且一 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this.七丆业丁东下与丕与.GetEnumerator();
            label_10:
            if((119765376 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            val_12 = null;
            val_12 = null;
            val_14 = 业丏丈丞丘业丈丞一.<>c.<>9__8_0;
            if(val_14 == null)
            {
                    val_14 = null;
                val_14 = new System.Func<System.Int32, PGCompany.三东丏不丗世丅丌丄>(object:  业丏丈丞丘业丈丞一.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.三东丏不丗世丅丌丄 业丏丈丞丘业丈丞一.<>c::丂业丘丐丈丏世七丕(int 三丟东丕丄丄下下丑));
                业丏丈丞丘业丈丞一.<>c.<>9__8_0 = val_14;
            }
            
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_10 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>(collection:  System.Linq.Enumerable.Select<System.Int32, PGCompany.三东丏不丗世丅丌丄>(source:  val_6._value._obj, selector:  null));
            this.丑东东七世丗不且一.set_Item(key:  val_6._value._obj.丐丏七丌丕丗业且上(), value:  null);
            goto label_10;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>>)this.丑东东七世丗不且一;
        }
        public 业丏丈丞丘业丈丞一()
        {
            this.Data = new System.Collections.Generic.List<PGCompany.DataObjects.七下上丁万东丑世业>();
            this.GatchaItems = new System.Collections.Generic.List<PGCompany.DataObjects.丈专丕下丂丏三专且>();
            this.Settings = new PGCompany.DataObjects.世上丛丄丛专东丏丟();
            this.GatchaSequence = new System.Collections.Generic.Dictionary<System.Int32, GiftCategoryType>();
            this.Schedule = new PGCompany.DataObjects.七七丙丗丏丑专业丝();
            this.七丆业丁东下与丕与 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.Int32>>();
        }
    
    }

}
