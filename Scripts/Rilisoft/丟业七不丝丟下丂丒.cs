using UnityEngine;

namespace Rilisoft
{
    public sealed class 丟业七不丝丟下丂丒
    {
        // Fields
        internal const string 丛世丏东丌业丛七丝 = "af_initiated_checkout";
        internal const string 上丗丏丒万丏丑丄万 = "LevelUp";
        internal const string 东丏丌丒七丛且丂丂 = "Social";
        internal const string 与丟专丑丏一三上且 = "Virality";
        private static readonly System.Collections.Generic.Dictionary<CategoryNames, string> 丞丈丞与世丘万丅丝;
        
        // Methods
        internal static string 东业丌丂下丂丒七丙(CategoryNames 七丆丒与丗丌丄且丂)
        {
            var val_4;
            string val_1 = 0;
            val_4 = null;
            val_4 = null;
            return (string)((Rilisoft.丟业七不丝丟下丂丒.丞丈丞与世丘万丅丝.TryGetValue(key:  七丆丒与丗丌丄且丂, value: out  val_1)) != true) ? (val_1) : 0;
        }
        internal static System.Collections.Generic.IEnumerable<string> 丅丞丂丘丕丐下丒丒()
        {
            null = null;
            if(Rilisoft.丟业七不丝丟下丂丒.丞丈丞与世丘万丅丝 != null)
            {
                    return Rilisoft.丟业七不丝丟下丂丒.丞丈丞与世丘万丅丝.Values;
            }
            
            return Rilisoft.丟业七不丝丟下丂丒.丞丈丞与世丘万丅丝.Values;
        }
        public 丟业七不丝丟下丂丒()
        {
        
        }
        private static 丟业七不丝丟下丂丒()
        {
            System.Collections.Generic.Dictionary<CategoryNames, System.String> val_2 = new System.Collections.Generic.Dictionary<CategoryNames, System.String>(capacity:  21, comparer:  丑丏三丝专丐丞不上.丑七不且上丗丁一世());
            if(val_2 != null)
            {
                    val_2.Add(key:  0, value:  "Primary");
            }
            else
            {
                    val_2.Add(key:  0, value:  "Primary");
            }
            
            val_2.Add(key:  1, value:  "Back Up");
            if(val_2 != null)
            {
                    val_2.Add(key:  2, value:  "Melee");
            }
            else
            {
                    val_2.Add(key:  2, value:  "Melee");
            }
            
            val_2.Add(key:  3, value:  "Special");
            if(val_2 != null)
            {
                    val_2.Add(key:  4, value:  "Sniper");
            }
            else
            {
                    val_2.Add(key:  4, value:  "Sniper");
            }
            
            val_2.Add(key:  5, value:  "Premium");
            if(val_2 != null)
            {
                    val_2.Add(key:  8, value:  "Skins");
            }
            else
            {
                    val_2.Add(key:  8, value:  "Skins");
            }
            
            val_2.Add(key:  7, value:  "Armor");
            if(val_2 != null)
            {
                    val_2.Add(key:  10, value:  "Boots");
            }
            else
            {
                    val_2.Add(key:  10, value:  "Boots");
            }
            
            val_2.Add(key:  9, value:  "Capes");
            if(val_2 != null)
            {
                    val_2.Add(key:  6, value:  "Hats");
            }
            else
            {
                    val_2.Add(key:  6, value:  "Hats");
            }
            
            val_2.Add(key:  11, value:  "Gear");
            if(val_2 != null)
            {
                    val_2.Add(key:  12, value:  "Masks");
            }
            else
            {
                    val_2.Add(key:  12, value:  "Masks");
            }
            
            val_2.Add(key:  232, value:  "Skins Category Editor");
            if(val_2 != null)
            {
                    val_2.Add(key:  176, value:  "SkinsCategoryFamele");
            }
            else
            {
                    val_2.Add(key:  176, value:  "SkinsCategoryFamele");
            }
            
            val_2.Add(key:  76, value:  "SkinsCategoryMale");
            if(val_2 != null)
            {
                    val_2.Add(key:  120, value:  "SkinsCategoryPremium");
            }
            else
            {
                    val_2.Add(key:  120, value:  "SkinsCategoryPremium");
            }
            
            val_2.Add(key:  20, value:  "SkinsCategorySpecial");
            if(val_2 != null)
            {
                    val_2.Add(key:  52, value:  "League Hats");
            }
            else
            {
                    val_2.Add(key:  52, value:  "League Hats");
            }
            
            val_2.Add(key:  152, value:  "League Skins");
            if(val_2 != null)
            {
                    val_2.Add(key:  208, value:  "League Weapon Skins");
            }
            else
            {
                    val_2.Add(key:  208, value:  "League Weapon Skins");
            }
            
            val_2.Add(key:  212, value:  "Throwing Gadgets");
            if(val_2 != null)
            {
                    val_2.Add(key:  200, value:  "Tool Gadgets");
            }
            else
            {
                    val_2.Add(key:  200, value:  "Tool Gadgets");
            }
            
            val_2.Add(key:  188, value:  "Support Gadgets");
            if(val_2 != null)
            {
                    val_2.Add(key:  168, value:  "Pets");
            }
            else
            {
                    val_2.Add(key:  168, value:  "Pets");
            }
            
            val_2.Add(key:  48, value:  "Eggs");
            if(val_2 != null)
            {
                    val_2.Add(key:  184, value:  "Best Weapons");
            }
            else
            {
                    val_2.Add(key:  184, value:  "Best Weapons");
            }
            
            val_2.Add(key:  64, value:  "Best Wear");
            if(val_2 != null)
            {
                    val_2.Add(key:  200, value:  "Best Gadgets");
            }
            else
            {
                    val_2.Add(key:  200, value:  "Best Gadgets");
            }
            
            val_2.Add(key:  240, value:  "Avatar");
            Rilisoft.丟业七不丝丟下丂丒.丞丈丞与世丘万丅丝 = val_2;
        }
    
    }

}
