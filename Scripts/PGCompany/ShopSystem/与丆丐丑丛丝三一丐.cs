using UnityEngine;

namespace PGCompany.ShopSystem
{
    internal static class 与丆丐丑丛丝三一丐
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<string, System.Type> 丏丞七丏丐丛丏上且;
        
        // Methods
        internal static PGCompany.ShopSystem.世丟丐丘丟丘丟丌丕<PGCompany.ShopSystem.万丗丈丌丙丞下丘丌> 丗业丕丕丙下丆一丝(string 丛丐且下丂丏丁专丌)
        {
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = 丛丐且下丂丏丁专丌;
            val_8 = null;
            val_8 = null;
            if((PGCompany.ShopSystem.与丆丐丑丛丝三一丐.丏丞七丏丐丛丏上且.ContainsKey(key:  val_7)) != false)
            {
                    val_9 = null;
                val_9 = null;
                if((System.Activator.CreateInstance(type:  PGCompany.ShopSystem.与丆丐丑丛丝三一丐.丏丞七丏丐丛丏上且.Item[val_7], nonPublic:  true)) == null)
            {
                    return (PGCompany.ShopSystem.世丟丐丘丟丘丟丌丕<PGCompany.ShopSystem.万丗丈丌丙丞下丘丌>)val_10;
            }
            
            }
            else
            {
                    val_11 = null;
                val_11 = null;
                val_7 = "unknown shop type for shop: \'"("unknown shop type for shop: \'") + val_7 + "\'";
            }
            
            val_10 = 0;
            return (PGCompany.ShopSystem.世丟丐丘丟丘丟丌丕<PGCompany.ShopSystem.万丗丈丌丙丞下丘丌>)val_10;
        }
        private static 与丆丐丑丛丝三一丐()
        {
            System.Collections.Generic.Dictionary<System.String, System.Type> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Type>();
            val_1.Add(key:  "ShopCompetition", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  "ShopArmory", value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.ShopSystem.与丆丐丑丛丝三一丐.丏丞七丏丐丛丏上且 = val_1;
        }
    
    }

}
