using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class PixelPassLoadingTipsController : Singleton<PGCompany.PixelPass.PixelPassLoadingTipsController>
    {
        // Fields
        private PGCompany.PixelPass.一万丄一丌丆业丐丅 丆丏三七丝丅丄丝丕;
        
        // Methods
        internal void 丂且专三丅丌东万专(LoadingTipsView 丞万一业万丕丏且丄, System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丞丗上不丂一丘且丙, bool 丛业丑丝丘丟七与丑 = False)
        {
            PGCompany.PixelPass.一万丄一丌丆业丐丅 val_2;
            if(丛业丑丝丘丟七与丑 == false)
            {
                goto label_1;
            }
            
            val_2 = this.丆丏三七丝丅丄丝丕;
            if(val_2 == null)
            {
                    return;
            }
            
            label_6:
            丞万一业万丕丏且丄.丒丁丂丛东下世丁丅(万不且且丛丆东丒业:  val_2);
            return;
            label_1:
            val_2 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.PixelPass.一万丄一丌丆业丐丅>(丑东与丅丐丅丂丞业:  丞丗上不丂一丘且丙);
            this.丆丏三七丝丅丄丝丕 = val_2;
            if(val_2 != null)
            {
                goto label_6;
            }
        
        }
        public PixelPassLoadingTipsController()
        {
        
        }
    
    }

}
