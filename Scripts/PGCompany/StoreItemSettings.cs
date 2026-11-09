using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class StoreItemSettings
    {
        // Fields
        internal PGCompany.三东丏不丗世丅丌丄 ItemParams;
        internal 一一万丒与专丙丁丛 Division;
        internal PGCompany.三东丏不丗世丅丌丄 PurchasePrice;
        internal int CountDetails;
        private System.Collections.Generic.Dictionary<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄> _upgradePrices;
        
        // Properties
        internal System.Collections.Generic.Dictionary<int, PGCompany.三东丏不丗世丅丌丄> UpgradePrices { get; set; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<int, PGCompany.三东丏不丗世丅丌丄> get_UpgradePrices()
        {
            var val_3;
            System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, System.Int32> val_5;
            System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄> val_7;
            val_3 = null;
            val_3 = null;
            val_5 = StoreItemSettings.<>c.<>9__6_0;
            if(val_5 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, System.Int32> val_1 = null;
                val_5 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, System.Int32>(object:  StoreItemSettings.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 StoreItemSettings.<>c::丑丝丄下丗丌丟丟七(System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄> 丐丏东世不丅丌且万));
                val_3 = null;
                StoreItemSettings.<>c.<>9__6_0 = val_5;
            }
            
            val_3 = null;
            val_7 = StoreItemSettings.<>c.<>9__6_1;
            if(val_7 != null)
            {
                    return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, System.Int32, PGCompany.三东丏不丗世丅丌丄>(source:  this._upgradePrices, keySelector:  val_1, elementSelector:  System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄> val_2 = null);
            }
            
            val_7 = val_2;
            val_2 = new System.Func<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄>(object:  StoreItemSettings.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.三东丏不丗世丅丌丄 StoreItemSettings.<>c::丙东与丗丏丈丌上丞(System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄> 丐丏东世不丅丌且万));
            StoreItemSettings.<>c.<>9__6_1 = val_7;
            return System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>, System.Int32, PGCompany.三东丏不丗世丅丌丄>(source:  this._upgradePrices, keySelector:  val_1, elementSelector:  val_2);
        }
        internal void set_UpgradePrices(System.Collections.Generic.Dictionary<int, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            var val_4;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, Rilisoft.丝丑丂丛万丐丈丘且> val_6;
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄> val_8;
            val_4 = null;
            val_4 = null;
            val_6 = StoreItemSettings.<>c.<>9__7_0;
            if(val_6 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, Rilisoft.丝丑丂丛万丐丈丘且> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, Rilisoft.丝丑丂丛万丐丈丘且>(object:  StoreItemSettings.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丝丑丂丛万丐丈丘且 StoreItemSettings.<>c::丅丘丑丑丌一丗丕丝(System.Collections.Generic.KeyValuePair<int, PGCompany.三东丏不丗世丅丌丄> 丐丏东世不丅丌且万));
                val_4 = null;
                StoreItemSettings.<>c.<>9__7_0 = val_6;
            }
            
            val_4 = null;
            val_8 = StoreItemSettings.<>c.<>9__7_1;
            if(val_8 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄> val_2 = null;
                val_8 = val_2;
                val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, PGCompany.三东丏不丗世丅丌丄>(object:  StoreItemSettings.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.三东丏不丗世丅丌丄 StoreItemSettings.<>c::丂丞丁上业丛丕七丑(System.Collections.Generic.KeyValuePair<int, PGCompany.三东丏不丗世丅丌丄> 丐丏东世不丅丌且万));
                StoreItemSettings.<>c.<>9__7_1 = val_8;
            }
            
            this._upgradePrices = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.Int32, PGCompany.三东丏不丗世丅丌丄>, Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>(source:  丙业与丙丗丝不丈东, keySelector:  val_1, elementSelector:  val_2);
        }
        public StoreItemSettings()
        {
            this.Division = 0;
            this._upgradePrices = new System.Collections.Generic.Dictionary<Rilisoft.丝丑丂丛万丐丈丘且, PGCompany.三东丏不丗世丅丌丄>();
        }
    
    }

}
