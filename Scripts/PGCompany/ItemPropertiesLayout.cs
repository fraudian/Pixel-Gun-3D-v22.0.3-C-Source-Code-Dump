using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemPropertiesLayout : PGBehaviour
    {
        // Fields
        private PropertiesLayout _propertiesLayout;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> 丌不七丗丌丏丄丐丞, System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> 丙丑丆上不丒上丕丛)
        {
            System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> val_1 = new System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂>();
            List.Enumerator<T> val_2 = 丌不七丗丌丏丄丐丞.GetEnumerator();
            label_6:
            if(((-593957768) & 1) == 0)
            {
                goto label_2;
            }
            
            new ItemPropertiesLayout.丝丂下丂丐丄丁丑丄() = new System.Object();
            .专丛不丙丞丗丒丏业 = 0.丙东专丂世丈丏丁丂();
            System.Func<PGCompany.丗丒下万与下丂万丂, System.Boolean> val_5 = new System.Func<PGCompany.丗丒下万与下丂万丂, System.Boolean>(object:  new ItemPropertiesLayout.丝丂下丂丐丄丁丑丄(), method:  System.Boolean ItemPropertiesLayout.丝丂下丂丐丄丁丑丄::丆一且世上丗上一丗(PGCompany.丗丒下万与下丂万丂 三丟东丕丄丄下下丑));
            PGCompany.丗丒下万与下丂万丂 val_6 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丗丒下万与下丂万丂>(source:  丙丑丆上不丒上丕丛 = 丙丑丆上不丒上丕丛, predicate:  null);
            if(val_6 == null)
            {
                goto label_6;
            }
            
            val_1.Add(item:  val_6);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丈且东丑丂且万丒丅(丙丑丆上不丒上丕丛:  val_1);
        }
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> 丙丑丆上不丒上丕丛)
        {
            var val_2;
            var val_3;
            var val_12 = this;
            this._propertiesLayout.世业丒万丘丆专丘丐();
            List.Enumerator<T> val_1 = 丙丑丆上不丒上丕丛.GetEnumerator();
            label_11:
            if(((-593780240) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4.丄业丄丞三丆丐业一() == 8)
            {
                    UnityEngine.Color val_6 = UnityEngine.Color.yellow;
                val_2 = 0;
                val_3 = 0;
            }
            
            val_2 = 0;
            val_3 = 0;
            PropertyUI val_11 = this._propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  val_4.万上丘丙丄下七下东(), 丟丒丏丛三丟丑丗丝:  val_4.丄七丒丝丝丏三丏下(), 丌丒丝东丌下丕丁丅:  val_4.世三丞丅丑丌丈丈一().ToString(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            goto label_11;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public ItemPropertiesLayout()
        {
        
        }
    
    }

}
