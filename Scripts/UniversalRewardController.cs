using UnityEngine;
internal sealed class UniversalRewardController : PGBehaviour
{
    // Methods
    internal static bool 业丗丝万专万丞丟上()
    {
        if((UniversalRewardBanner.<不丟东上丂丘一不万>k__BackingField) != false)
        {
                return false;
        }
        
        PGCompany.丂丞万丒下万丒业丌 val_1 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丏丝丐丗丅丌专上下();
        }
        
        return val_1.丏丝丐丗丅丌专上下();
    }
    internal static void 与三丆丏丌三丈七丂(丈下专丂丑不丑丗丁 且丒丛与丞世丙丕丌, UniversalRewardController.丑丒专丄三三业丏丏 丌世丕丗不丘世丞专 = 1, UniversalRewardController.丑三不丕丘丞不丏下 一七丁不丝丈丕丑丒)
    {
        丑三不丕丘丞不丏下 val_12 = 一七丁不丝丈丕丑丒;
        与丏下丒与丙丟丝一 val_2 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().万专东丁东三丌与丏(且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
        if((val_2 != null) && (val_2.丆丌丙丛丄丂丘丟丟 != null))
        {
                if(val_2.丆丌丙丛丄丂丘丟丟.Count >= 1)
        {
                val_2.一七丁不丝丈丕丑丒 = val_12;
            UniversalRewardController.与三丆丏丌三丈七丂(丁东丛丅业七丏丌丑:  val_2, 丌世丕丗不丘世丞专:  丌世丕丗不丘世丞专);
        }
        
        }
        
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().与丌丕下丟且七丙丙(且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
        if(val_5 != null)
        {
                if(val_5.Count >= 1)
        {
                val_12 = PGCompany.LootBoxSystem.七丈三丂且丗丈世一.丑七不且上丗丁一世();
            val_12.与丈与万丆东丑丑东(业七丄丄丘上丌不上:  且丒丛与丞世丙丕丌, 丏丒丅不世与丐丅丘:  val_5);
        }
        
        }
        
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_9 = PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().丆三丘丛丒丛三丏东(且丒丛与丞世丙丕丌:  且丒丛与丞世丙丕丌);
        if(val_9 == null)
        {
                return;
        }
        
        if(val_9.Count < 1)
        {
                return;
        }
        
        Rilisoft.世与丛一丕丄丗丈丅.丑七不且上丗丁一世().丏丁专丑丌丑一丂丞(业七丄丄丘上丌不上:  且丒丛与丞世丙丕丌, 丞丈丁与丏丌丌丆丂:  val_9);
    }
    private static void 与三丆丏丌三丈七丂(UniversalRewardController.与丏下丒与丙丟丝一 丁东丛丅业七丏丌丑, UniversalRewardController.丑丒专丄三三业丏丏 丌世丕丗不丘世丞专 = 1)
    {
        丁东丛丅业七丏丌丑.丌世丕丗不丘世丞专 = 丌世丕丗不丘世丞专;
        ModalBannerHolder val_1 = ModalBannerHolder.丑七不且上丗丁一世();
        val_1.universalRewardHolder.ShowBanner(丌丅丕一丛丛丄一万:  81, 下丒丕丕世三七丕丄:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = 丁东丛丅业七丏丌丑, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    public UniversalRewardController()
    {
    
    }

}
