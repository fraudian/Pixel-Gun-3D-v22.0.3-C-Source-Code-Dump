using UnityEngine;

namespace PGCompany.DataObjects
{
    internal class 三丏世丟丟丙丟丙万
    {
        // Fields
        private System.Collections.Generic.Dictionary<int, PGCompany.DataObjects.三丏世丟丟丙丟丙万.上丈丕三丐丌丘丅丂> 丕与丕丙丙丆下三七;
        internal System.Collections.Generic.Dictionary<int, PGCompany.DataObjects.三丏世丟丟丙丟丙万.上丈丕三丐丌丘丅丂> WeaponsPrefabNumbersDictionary;
        internal System.Collections.Generic.HashSet<int> UnavailableWeapons;
        internal System.Collections.Generic.HashSet<int> ExcludedAlmanachWeapons;
        internal System.Collections.Generic.HashSet<int> ExcludedAlmanachWeaponsForAlternateBuy;
        
        // Properties
        internal System.Collections.Generic.Dictionary<int, PGCompany.DataObjects.三丏世丟丟丙丟丙万.上丈丕三丐丌丘丅丂> 丟丑丈丁下丆且一万 { get; }
        
        // Methods
        internal System.Collections.Generic.Dictionary<int, PGCompany.DataObjects.三丏世丟丟丙丟丙万.上丈丕三丐丌丘丅丂> 丏世丐丝世丌七丏与()
        {
            if(this.丕与丕丙丙丆下三七.Count == this.WeaponsPrefabNumbersDictionary.Count)
            {
                    return (System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>)this.丕与丕丙丙丆下三七;
            }
            
            this.上下丑丅丏一丐业一();
            return (System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>)this.丕与丕丙丙丆下三七;
        }
        private void 上下丑丅丏一丐业一()
        {
            this.丕与丕丙丙丆下三七.Clear();
            Dictionary.Enumerator<TKey, TValue> val_1 = this.WeaponsPrefabNumbersDictionary.GetEnumerator();
            label_5:
            if((119192456 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
            this.丕与丕丙丙丆下三七.set_Item(key:  (val_2._value._obj.丙东专丂世丈丏丁丂() * 1000) | 1, value:  val_2._value._obj);
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public 三丏世丟丟丙丟丙万()
        {
            this.丕与丕丙丙丆下三七 = new System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>();
            this.WeaponsPrefabNumbersDictionary = new System.Collections.Generic.Dictionary<System.Int32, 上丈丕三丐丌丘丅丂>();
            this.UnavailableWeapons = new System.Collections.Generic.HashSet<System.Int32>();
            this.ExcludedAlmanachWeapons = new System.Collections.Generic.HashSet<System.Int32>();
            this.ExcludedAlmanachWeaponsForAlternateBuy = new System.Collections.Generic.HashSet<System.Int32>();
        }
    
    }

}
