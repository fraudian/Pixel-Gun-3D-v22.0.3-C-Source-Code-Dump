using UnityEngine;

namespace PGCompany
{
    public class LoopCustomUiSetter : MonoBehaviour
    {
        // Fields
        private string _prefabsPrefix;
        private string _lkeyTimer;
        private UnityEngine.GameObject 丘万丑下丘丁万丅丁;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(string 丞一丁业丄一一业且, CategoryNames 七丆丒与丗丌丄且丂, PGCompany.GameplayLoop.GameplayLoopType 上丒一丂丞丅丏丅丂, bool 一丏且丏东丌丈丄且, System.Action 专丐丛丑丞丕丌与丛)
        {
            System.Action val_36;
            bool val_37;
            CategoryNames val_38;
            string val_39;
            string val_40;
            object val_41;
            System.Object[] val_42;
            var val_43;
            object val_44;
            var val_45;
            object val_46;
            val_36 = 专丐丛丑丞丕丌与丛;
            val_37 = 一丏且丏东丌丈丄且;
            val_38 = 七丆丒与丗丌丄且丂;
            val_39 = this;
            if(上丒一丂丞丅丏丅丂 == 1)
            {
                goto label_1;
            }
            
            val_40 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世();
            PGCompany.GameplayLoop.业丒丅丂丗丁业上且 val_2 = val_40.丏丈丞丅丒与丄业东(丁丅丈丌丟世丗丗丟:  上丒一丂丞丅丏丅丂);
            if(val_2 == null)
            {
                goto label_3;
            }
            
            val_41 = val_2.丅丆丁世丏万与下丏();
            goto label_4;
            label_1:
            val_41 = "sale_basic";
            label_4:
            val_42 = 1152921504848912384;
            val_40 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}_{1}", arg0:  this._prefabsPrefix, arg1:  val_41).ToLowerInvariant();
            if(this.丘万丑下丘丁万丅丁 != 0)
            {
                    if((System.String.op_Inequality(a:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁), b:  val_40)) != false)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁);
                this.丘万丑下丘丁万丅丁 = 0;
            }
            
            }
            
            if(this.丘万丑下丘丁万丅丁 != 0)
            {
                goto label_50;
            }
            
            if(上丒一丂丞丅丏丅丂 == 1)
            {
                goto label_19;
            }
            
            System.Globalization.CultureInfo val_11 = System.Globalization.CultureInfo.InvariantCulture;
            if(上丒一丂丞丅丏丅丂 == 0)
            {
                goto label_22;
            }
            
            val_43 = 上丒一丂丞丅丏丅丂.ToString(provider:  val_11);
            goto label_23;
            label_3:
            object[] val_13 = new object[1];
            val_42 = val_13;
            val_42[0] = 上丒一丂丞丅丏丅丂;
            UnityEngine.Debug.LogErrorFormat(format:  "Setup get loop = null {0}", args:  val_13);
            return;
            label_19:
            val_44 = "sale";
            goto label_31;
            label_22:
            val_43 = 上丒一丂丞丅丏丅丂.ToString(provider:  val_11);
            label_23:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_44 = val_43.ToLowerInvariant();
            val_36 = val_36;
            val_38 = val_38;
            label_31:
            val_40 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "LoopContent/{0}_gui/{1}", arg0:  val_44, arg1:  val_40));
            if((val_40 != 0) || (1081360384 != 2))
            {
                goto label_36;
            }
            
            if(上丒一丂丞丅丏丅丂 == 1)
            {
                goto label_37;
            }
            
            System.Globalization.CultureInfo val_19 = System.Globalization.CultureInfo.InvariantCulture;
            if(null == 0)
            {
                goto label_40;
            }
            
            val_45 = null.ToString(provider:  val_19);
            goto label_41;
            label_37:
            val_46 = "sale";
            goto label_42;
            label_40:
            val_45 = null.ToString(provider:  val_19);
            label_41:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_46 = val_45.ToLowerInvariant();
            label_42:
            val_40 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "LoopContent/{0}_gui/{1}", arg0:  val_46, arg1:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}_{1}", arg0:  this._prefabsPrefix, arg1:  "default")));
            label_36:
            int val_28 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            UnityEngine.GameObject val_29 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_40, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            this.丘万丑下丘丁万丅丁 = val_29;
            val_37 = val_37;
            if(val_29 != 0)
            {
                    LoopGuiBase val_31 = this.丘万丑下丘丁万丅丁.AddComponent<LoopGuiBase>();
            }
            
            label_50:
            LoopGuiBase val_32 = this.丘万丑下丘丁万丅丁.GetComponent<LoopGuiBase>();
            if((System.String.op_Inequality(a:  val_32.丐丙世七丅丅丐下丙(), b:  丞一丁业丄一一业且)) == false)
            {
                    return;
            }
            
            val_40 = null;
            val_39 = this._lkeyTimer;
            val_32.丈且东丑丂且万丒丅(丞一丁业丄一一业且:  丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  val_38, 上丒一丂丞丅丏丅丂:  val_40, 丗丄专丐三丞与丏专:  val_39, 丑丗丕丈丒不丙专丐:  false, 一丏且丏东丌丈丄且:  val_37, 专丐丛丑丞丕丌与丛:  val_36);
        }
        public LoopCustomUiSetter()
        {
        
        }
    
    }

}
