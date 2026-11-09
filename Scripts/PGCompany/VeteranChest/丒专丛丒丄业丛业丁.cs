using UnityEngine;

namespace PGCompany.VeteranChest
{
    internal static class 丒专丛丒丄业丛业丁
    {
        // Properties
        internal static bool 丕世丁丈丞丙上专丄 { get; }
        
        // Methods
        internal static void 东不丙三与丟丈东丘(Rilisoft.BankBannersHolder 七万上丐一丈丏丏专, bool 七丘丑丂且万丄丒丟 = False)
        {
            var val_4;
            Rilisoft.BankBannersHolder val_5 = 七万上丐一丈丏丏专;
            PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 val_1 = PGCompany.VeteranChest.丒专丛丒丄业丛业丁.七丙世世且七丞丒上();
            if(val_1 != null)
            {
                    LootBoxBanner.ShowLootBoxUI(七丁丑丗丐专丌丝丗:  val_1, 丘丒丅三丞丞丛丛丌:  val_5 = 七万上丐一丈丏丏专);
                if(七丘丑丂且万丄丒丟 == false)
            {
                    return;
            }
            
                val_5 = val_5.GetComponentsInChildren<VeteranLootBoxUI>();
                if(val_5 == null)
            {
                    return;
            }
            
                if(val_2.Length < 1)
            {
                    return;
            }
            
                val_4 = 1152921504848912384;
                do
            {
                T val_5 = val_5[0];
                if(val_5 != 0)
            {
                    val_5.万丛丆与业丐丁丕丟();
            }
            
            }
            while((0 + 1) < val_2.Length);
            
                return;
            }
            
            VeteranChestBanner.东不丙三与丟丈东丘(七万上丐一丈丏丏专:  val_5);
        }
        internal static PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 七丙世世且七丞丒上()
        {
            System.Collections.Generic.IEnumerable<TSource> val_8;
            object val_9;
            val_8 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丐丕丅丘万丞七丐上();
            if((val_8 == null) || ((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_8)) == false))
            {
                goto label_3;
            }
            
            val_8 = val_8.Item[0];
            if((val_8 == null) || (val_8.丕丐一丙专丛丒丑万() == false))
            {
                goto label_5;
            }
            
            if(val_8.不业丙丒丂丞下丆丙() != 1460)
            {
                    return 0;
            }
            
            PGCompany.LootBoxSystem.世七丈丆丐丕专业丗 val_7 = new PGCompany.LootBoxSystem.世七丈丆丐丕专业丗();
            if(val_7 == null)
            {
                goto label_7;
            }
            
            .丁丞丌与丘丝丕丈丂 = 351;
            .七专丁丕世丏丁丘丛 = 36;
            goto label_8;
            label_3:
            val_9 = "cant open veteran chest, chest setting is null or empty";
            goto label_11;
            label_5:
            val_9 = "cant open veteran chest, invalid chest itemParams";
            label_11:
            UnityEngine.Debug.LogError(message:  val_9);
            return 0;
            label_7:
            mem[16] = 351;
            .丌丟丐丞三丘三丏丈 = 93;
            mem[24] = 36;
            label_8:
            .丈下专丂丑不丑丗丁 = 11;
            return PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  val_8, 与不丕丆丈不丙丟丛:  val_7);
        }
        internal static bool 丛丌不丂丕丑下业一(int 丐丄下丒丏丆丄丟丈)
        {
            int val_6;
            string val_7;
            val_6 = 丐丄下丒丏丆丄丟丈;
            if((PGCompany.LootBoxSystem.七丈三丂且丗丈世一.丑七不且上丗丁一世().专上业丝丁丑世三丝(丆专且丕专丗与一丏:  val_6)) == null)
            {
                    return (bool)((val_6.IndexOf(value:  "veteran_", comparisonType:  4)) == 0) ? 1 : 0;
            }
            
            val_7 = val_2.PrefabUI;
            if(val_7 == null)
            {
                    return (bool)((val_6.IndexOf(value:  "veteran_", comparisonType:  4)) == 0) ? 1 : 0;
            }
            
            val_6 = val_7.ToLower();
            return (bool)((val_6.IndexOf(value:  "veteran_", comparisonType:  4)) == 0) ? 1 : 0;
        }
        internal static bool 丕三三丐一一丟丘丂()
        {
            if(VeteranChestBanner.丕三三丐一一丟丘丂() == false)
            {
                    return VeteranLootBoxUI.丕三三丐一一丟丘丂();
            }
            
            return true;
        }
    
    }

}
