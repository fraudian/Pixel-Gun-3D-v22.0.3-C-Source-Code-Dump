using UnityEngine;

namespace PGCompany
{
    internal abstract class ModuleContextCluesBase : MonoBehaviour
    {
        // Fields
        private static System.Action 与业丑丅丁丌丛丑丒;
        protected PGCompany.ModuleContextCluesScreen _cluesScreen;
        private PGCompany.ModuleContextCluesController <丈丄丄七下专丞与丛>k__BackingField;
        
        // Properties
        internal PGCompany.ModuleContextCluesController 丁下不万专与丘七东 { get; set; }
        
        // Methods
        internal static void 一与与一世丑丒与丛(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ModuleContextCluesBase.与业丑丅丁丌丛丑丒, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丟丂万与万与丆丄丌(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ModuleContextCluesBase.与业丑丅丁丌丛丑丒, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal PGCompany.ModuleContextCluesController 七丛下丗丌丏丗丁丐()
        {
            return (PGCompany.ModuleContextCluesController)this.<丈丄丄七下专丞与丛>k__BackingField;
        }
        internal void 下丄丛丙丕丘世丗七(PGCompany.ModuleContextCluesController 丙业与丙丗丝不丈东)
        {
            this.<丈丄丄七下专丞与丛>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal abstract void 下丌业业丐丘丐丘三(); // 0
        internal abstract void 不与丞下业丑丒丙万(); // 0
        internal abstract string 丄丑丈丏上丝丆丂丐(); // 0
        protected void 下与丞三丅丛丄七丕()
        {
            string val_5 = this;
            if((丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false))) == true)
            {
                    return;
            }
            
            if((this.<丈丄丄七下专丞与丛>k__BackingField) != 0)
            {
                    if((this.<丈丄丄七下专丞与丛>k__BackingField.三专七与丟丐丝不丁()) == true)
            {
                    return;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._cluesScreen, 丏业丟一东丂东丘丛:  true);
            val_5 = val_5;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            if(PGCompany.ModuleContextCluesBase.与业丑丅丁丌丛丑丒 == null)
            {
                    return;
            }
            
            PGCompany.ModuleContextCluesBase.与业丑丅丁丌丛丑丒.Invoke();
        }
        protected ModuleContextCluesBase()
        {
        
        }
    
    }

}
