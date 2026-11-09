using UnityEngine;
internal sealed class NovicePromotionLobbyBanner : PGBehaviour
{
    // Fields
    private UILabel timer;
    private System.Collections.Generic.List<UnityEngine.GameObject> promotionByNumber;
    private PGCompany.丒丌业一丕丘丐世专 丂丒丏丒丏一丏丂世;
    
    // Methods
    internal bool 丏丆业三万丝丂丘世(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
    {
        var val_13;
        UnityEngine.GameObject val_14;
        System.Collections.Generic.List<UnityEngine.GameObject> val_15;
        val_13 = 一丐丗丁丞丆丅丟丄;
        val_14 = this;
        val_15 = this.promotionByNumber;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  false);
        if(val_13 == null)
        {
                return (bool)val_13;
        }
        
        if(一丐丗丁丞丆丅丟丄.Offer == null)
        {
            goto label_20;
        }
        
        this.丂丒丏丒丏一丏丂世 = 0;
        val_15 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_15 == null)
        {
            goto label_8;
        }
        
        PGCompany.丒丌业一丕丘丐世专 val_4 = val_15.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  一丐丗丁丞丆丅丟丄.Offer.丏不丁丛丕丒丏丆丂());
        this.丂丒丏丒丏一丏丂世 = val_4;
        if(val_4 != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.timer, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_4.下丒丗丄丌丘不丑丘() - PixelTime.丝丗专上三不丄丑丑(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            val_15 = this.promotionByNumber;
            int val_13 = this.丂丒丏丒丏一丏丂世.丞丂上世丌丒世下七().丏不丁丛丕丒丏丆丂();
            val_13 = val_13 - 1;
            if(val_15.Count > val_13)
        {
                val_14 = this.promotionByNumber.Item[val_13];
            val_13 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  true);
            return (bool)val_13;
        }
        
        }
        
        label_20:
        val_13 = 0;
        return (bool)val_13;
        label_8:
        val_13 = 0;
        this.丂丒丏丒丏一丏丂世 = 0;
        return (bool)val_13;
    }
    public void U_ShowBanner()
    {
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_2 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<PGCompany.丒丌业一丕丘丐世专> val_3 = val_2.丗不丞一且丟丈丈丗();
        if(val_3 == null)
        {
                return;
        }
        
        if(val_3.Count == 0)
        {
                return;
        }
        
        if(this.丂丒丏丒丏一丏丂世 == null)
        {
                return;
        }
        
        NovicePromotionSelectorBanner.ShowBanner(七丄丆丘丒与丐丘丅:  val_3, 丛丗七丅下丞丗且丐:  this.丂丒丏丒丏一丏丂世);
    }
    public NovicePromotionLobbyBanner()
    {
        this.promotionByNumber = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
