using UnityEngine;

namespace PGCompany
{
    internal sealed class TierBundleLobbyBanner : PGBehaviour
    {
        // Fields
        private UILabel _timerLabel;
        private UIWidget _oneItemContainer;
        private UIWidget _twoItemsContainer;
        private PGCompany.丒丌业一丕丘丐世专 丂丅七与丘丞丟万丕;
        private string 七万丏丄东业下丑下;
        private UnityEngine.Coroutine 丈三下七东丆丈三丙;
        
        // Methods
        internal bool 丏丆业三万丝丂丘世(Rilisoft.BonusData 一丐丗丁丞丆丅丟丄)
        {
            var val_14;
            if((一丐丗丁丞丆丅丟丄 == null) || (一丐丗丁丞丆丅丟丄.Offer == null))
            {
                goto label_9;
            }
            
            Rilisoft.Offers.丑与不丞丕丟世世丗 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
            if(val_2 == null)
            {
                goto label_6;
            }
            
            PGCompany.丒丌业一丕丘丐世专 val_4 = val_2.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  一丐丗丁丞丆丅丟丄.Offer.丏不丁丛丕丒丏丆丂());
            if(this != null)
            {
                goto label_25;
            }
            
            label_26:
            label_25:
            this.丂丅七与丘丞丟万丕 = val_4;
            if(val_4 != null)
            {
                    if((System.String.op_Inequality(a:  val_4.丙三丝一丝专丌丁丛(), b:  this.七万丏丄东业下丑下)) != false)
            {
                    this.七万丏丄东业下丑下 = this.丂丅七与丘丞丟万丕.丙三丝一丝专丌丁丛();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._timerLabel, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this.丂丅七与丘丞丟万丕.下丒丗丄丌丘不丑丘() - PixelTime.丝丗专上三不丄丑丑(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
                if(this.丈三下七东丆丈三丙 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丈三下七东丆丈三丙);
            }
            
                this.丈三下七东丆丈三丙 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.下丏丈世专丝丐上丒());
            }
            
                val_14 = 1;
                return (bool)val_14;
            }
            
            label_9:
            val_14 = 0;
            return (bool)val_14;
            label_6:
            if(this != null)
            {
                goto label_25;
            }
            
            goto label_26;
        }
        public void U_ShowBanner()
        {
            Rilisoft.Offers.丑与不丞丕丟世世丗 val_2 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
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
            
            if(this.丂丅七与丘丞丟万丕 == null)
            {
                    return;
            }
            
            TierBundleBanner.ShowBanner(七丄丆丘丒与丐丘丅:  val_3, 丛丗七丅下丞丗且丐:  this.丂丅七与丘丞丟万丕);
        }
        private void Start()
        {
        
        }
        private void OnDestroy()
        {
            if(this.丈三下七东丆丈三丙 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丈三下七东丆丈三丙);
            this.丈三下七东丆丈三丙 = 0;
        }
        private System.Collections.IEnumerator 下丏丈世专丝丐上丒()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new TierBundleLobbyBanner.丂世丅世丅一丄丐丝();
        }
        public TierBundleLobbyBanner()
        {
        
        }
    
    }

}
