using UnityEngine;

namespace PGCompany.Ads.AdvertisingChestWindowMachinery
{
    internal sealed class 丄丄一丐东丐丝丗七
    {
        // Fields
        private Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> 专丁丞万丂一丙三丗;
        private readonly PGCompany.Ads.AdvertisingChestWindowView <丝丟丆丐业丘丏丝上>k__BackingField;
        
        // Properties
        internal PGCompany.Ads.AdvertisingChestWindowView 丅上丗丌丄丏丅丆三 { get; }
        
        // Methods
        internal 丄丄一丐东丐丝丗七(PGCompany.Ads.AdvertisingChestWindowView 丁世丛业丟下丕三丟)
        {
            var val_4;
            if(丁世丛业丟下丕三丟 == null)
            {
                goto label_1;
            }
            
            if(丁世丛业丟下丕三丟 == 0)
            {
                goto label_4;
            }
            
            this.<丝丟丆丐业丘丏丝上>k__BackingField = 丁世丛业丟下丕三丟;
            return;
            label_1:
            System.ArgumentNullException val_2 = null;
            val_4 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "view");
            goto label_5;
            label_4:
            System.ObjectDisposedException val_3 = null;
            val_4 = val_3;
            val_3 = new System.ObjectDisposedException(objectName:  "view");
            label_5:
        }
        internal PGCompany.Ads.AdvertisingChestWindowView 丄世下丟三与丛世丅()
        {
            return (PGCompany.Ads.AdvertisingChestWindowView)this.<丝丟丆丐业丘丏丝上>k__BackingField;
        }
        internal bool 七东且丄丏丌东东丌(out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 丏业丟一东丂东丘丛)
        {
            Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_2;
            var val_3;
            val_2 = this.专丁丞万丂一丙三丗;
            if(val_2 != null)
            {
                    PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 val_1 = val_2.CurrentState;
                val_3 = 1;
            }
            else
            {
                    val_3 = 0;
            }
            
            丏业丟一东丂东丘丛 = val_2;
            return (bool)val_3;
        }
        internal bool 丝丑丞万丝一丙不丏(Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> 丅丟丛丙下丙丄丒丁)
        {
            if(this.专丁丞万丂一丙三丗 != null)
            {
                    return false;
            }
            
            this.专丁丞万丂一丙三丗 = 丅丟丛丙下丙丄丒丁;
            return true;
        }
        internal void 专丌丅不丑丛丘丑丝(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛)
        {
            if(this.专丁丞万丂一丙三丗 == null)
            {
                    return;
            }
            
            if((this.专丁丞万丂一丙三丗.TryProcessEvent(ev:  丙不不丒丁丄丄与丛)) != false)
            {
                    return;
            }
            
            CoroutineRunner.Instance.七丘且世丙丅七丘与(丈不不丁丆世丑专上:  this.丅一丑东丁丛东与丝(丙不不丒丁丄丄与丛:  丙不不丒丁丄丄与丛));
        }
        internal void 且丏丅丟世下一与一(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛)
        {
            CoroutineRunner.Instance.七丘且世丙丅七丘与(丈不不丁丆世丑专上:  this.丅一丑东丁丛东与丝(丙不不丒丁丄丄与丛:  丙不不丒丁丄丄与丛));
        }
        private System.Collections.IEnumerator 丅一丑东丁丛东与丝(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛)
        {
            丄丄一丐东丐丝丗七.丑丏专丂丗丕上丄丘 val_1 = new 丄丄一丐东丐丝丗七.丑丏专丂丗丕上丄丘();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丙不不丒丁丄丄与丛 = 丙不不丒丁丄丄与丛;
            return (System.Collections.IEnumerator)val_1;
        }
    
    }

}
