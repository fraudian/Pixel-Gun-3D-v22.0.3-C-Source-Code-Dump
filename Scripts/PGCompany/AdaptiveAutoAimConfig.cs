using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal sealed class AdaptiveAutoAimConfig
    {
        // Fields
        internal System.Collections.Generic.List<PGCompany.AdaptiveAutoAimConfig.丒丘丘七丛丌三三丛> Properties;
        private System.Nullable<Rilisoft.丝丑丂丛万丐丈丘且> _maxPayStepTime;
        
        // Properties
        internal int MaxPayStepTime { get; }
        
        // Methods
        internal int get_MaxPayStepTime()
        {
            var val_6;
            System.Func<丒丘丘七丛丌三三丛, System.Int32> val_8;
            if(this._maxPayStepTime.HasValue == true)
            {
                    return 25671456;
            }
            
            val_6 = null;
            val_6 = null;
            val_8 = AdaptiveAutoAimConfig.<>c.<>9__3_0;
            if(val_8 == null)
            {
                    System.Func<丒丘丘七丛丌三三丛, System.Int32> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Func<丒丘丘七丛丌三三丛, System.Int32>(object:  AdaptiveAutoAimConfig.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 AdaptiveAutoAimConfig.<>c::世丕丛且丗下丐丕与(PGCompany.AdaptiveAutoAimConfig.丒丘丘七丛丌三三丛 七丏丄丅丌业与且丙));
                AdaptiveAutoAimConfig.<>c.<>9__3_0 = val_8;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  System.Linq.Enumerable.Max<丒丘丘七丛丌三三丛>(source:  this.Properties, selector:  val_2));
            mem2[0] = 0;
            mem2[0] = 0;
            return 25671456;
        }
        public AdaptiveAutoAimConfig()
        {
            this.Properties = new System.Collections.Generic.List<丒丘丘七丛丌三三丛>();
        }
    
    }

}
