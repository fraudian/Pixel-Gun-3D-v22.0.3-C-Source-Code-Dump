using UnityEngine;

namespace PGCompany
{
    internal class ModuleContextCluesNotEnoughtEnergy : ModuleContextCluesBase
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            丆丟七丌丞东丆丕丌.丐丅万万丕专丒丑丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this, method:  System.Void PGCompany.ModuleContextCluesNotEnoughtEnergy::世丂丁不丕丈不丟三(PGCompany.丗丟丅七东丄丙丟上 丑专丆丟丟丐丆一丕, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, string 丞一丁业丄一一业且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            丆丟七丌丞东丆丕丌.且一专世丑专丌丂业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丗丟丅七东丄丙丟上, PGCompany.丏丂一丗丙世丏丐三, System.String>(object:  this, method:  System.Void PGCompany.ModuleContextCluesNotEnoughtEnergy::世丂丁不丕丈不丟三(PGCompany.丗丟丅七东丄丙丟上 丑专丆丟丟丐丆一丕, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, string 丞一丁业丄一一业且)));
        }
        internal override string 丄丑丈丏上丝丆丂丐()
        {
            return "ModuleCon_textClues_NotEno_ughtEne_rgy";
        }
        private void 世丂丁不丕丈不丟三(PGCompany.丗丟丅七东丄丙丟上 丑专丆丟丟丐丆一丕, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, string 丞一丁业丄一一业且)
        {
            var val_21;
            var val_22;
            var val_23;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_25;
            var val_27;
            System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_29;
            var val_30;
            var val_31;
            val_21 = 丑专丆丟丟丐丆一丕;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = val_21.丏丝丄丄丗丟丙不丆();
            if(val_21.丆丟且丗丒不丄七丌().Count >= )
            {
                    return;
            }
            
            三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丞一丁业丄一一业且);
            if(val_4 == null)
            {
                    return;
            }
            
            val_22 = null;
            val_22 = null;
            val_23 = null;
            val_23 = null;
            val_25 = ModuleContextCluesNotEnoughtEnergy.<>c.<>9__3_0;
            if(val_25 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean> val_5 = null;
                val_25 = val_5;
                val_5 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Boolean>(object:  ModuleContextCluesNotEnoughtEnergy.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModuleContextCluesNotEnoughtEnergy.<>c::丗丗丄世下一万丅下(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                ModuleContextCluesNotEnoughtEnergy.<>c.<>9__3_0 = val_25;
            }
            
            val_27 = null;
            val_27 = null;
            val_29 = ModuleContextCluesNotEnoughtEnergy.<>c.<>9__3_1;
            if(val_29 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>> val_7 = null;
                val_29 = val_7;
                val_7 = new System.Func<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.Collections.Generic.IEnumerable<System.String>>(object:  ModuleContextCluesNotEnoughtEnergy.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.IEnumerable<System.String> ModuleContextCluesNotEnoughtEnergy.<>c::下丕上丙丙上丆丌东(System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞> 丈丏万丄丒业丅丒一));
                ModuleContextCluesNotEnoughtEnergy.<>c.<>9__3_1 = val_29;
            }
            
            if(val_4.与丕丒世七丁万丂丛() != false)
            {
                    val_30 = (~(System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.SelectMany<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<FilterMaps, 丅一丈与丄三丝丝丞>>(source:  WeaponManager.且专专丁丌丗丛且丙, predicate:  val_5), selector:  val_7)).Contains(item:  val_4.与不丞丑七丘丁丂丛()))) & 1;
            }
            else
            {
                    val_30 = 0;
            }
            
            val_21 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
            丕丑丙丑丙东丌丘丕 val_15 = val_21.专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_4.业东丅东丌上丗丑不());
            if(val_15 != null)
            {
                    val_31 = (val_15.丈一下下丞世三丑丄() >> 31) ^ 1;
            }
            else
            {
                    val_31 = 0;
            }
            
            val_31 = val_31 & val_30;
            if(val_31 == 0)
            {
                    return;
            }
            
            val_21 = BalanceController.丌丛丄丙丘丈与下专(丞丌东丟且丒丐丑丂:  val_15, 丐丏上业丈丂与万丞:  false);
            if(val_21 == null)
            {
                    return;
            }
            
            if(val_15.丈一下下丞世三丑丄() >= val_21.丈一下下丞世三丑丄())
            {
                    return;
            }
            
            this.下与丞三丅丛丄七丕();
        }
        public ModuleContextCluesNotEnoughtEnergy()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
