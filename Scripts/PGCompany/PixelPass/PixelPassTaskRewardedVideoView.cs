using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class PixelPassTaskRewardedVideoView : PGBehaviour
    {
        // Fields
        private Rilisoft.ReusableRewardedVideo 七业下三七一丕丟与;
        
        // Properties
        internal Rilisoft.ReusableRewardedVideo 且下丄丞且且丁丒七 { get; }
        
        // Methods
        internal Rilisoft.ReusableRewardedVideo 丒专丗丘丈丟不七丄()
        {
            if(this.七业下三七一丕丟与 != null)
            {
                    return val_1;
            }
            
            Rilisoft.ReusableRewardedVideo val_1 = this.丅专丕世丄三丂世东();
            this.七业下三七一丕丟与 = val_1;
            return val_1;
        }
        private Rilisoft.ReusableRewardedVideo 丅专丕世丄三丂世东()
        {
            UnityEngine.Object val_7;
            var val_8;
            val_7 = UnityEngine.Resources.Load<Rilisoft.ReusableRewardedVideo>(path:  "SpeedUpItemRewardedVideo");
            val_8 = 0;
            if(val_7 == 0)
            {
                    return (Rilisoft.ReusableRewardedVideo)val_8;
            }
            
            val_7 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<Rilisoft.ReusableRewardedVideo>(丑且不丕与专丄业丙:  val_7, 丈东丘丏与丌东东下:  this.丌丟丄业且三丛丕丄(), 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_8 = 0;
            if(val_7 == 0)
            {
                    return (Rilisoft.ReusableRewardedVideo)val_8;
            }
            
            bool val_6 = val_7.丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  "pixelPass");
            val_8 = val_7;
            return (Rilisoft.ReusableRewardedVideo)val_8;
        }
        internal bool 且业下丅东与与丘丛(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业, System.DateTime 丅丏丅丂丝一丆丙丅, System.Action<PGCompany.PixelPass.一万丄一丌丆业丐丅> 业丏丈世世世丞丒世)
        {
            System.EventHandler val_10;
            System.EventHandler val_11;
            System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_12;
            PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏 val_1 = new PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
                .万不且且丛丆东丒业 = 万不且且丛丆东丒业;
            }
            else
            {
                    mem[16] = this;
                mem[40] = 业丏丈世世世丞丒世;
                mem[48] = 万不且且丛丆东丒业;
            }
            
            .三世且丐一丐丁丆丏 = 0;
            System.EventHandler val_2 = null;
            val_10 = val_2;
            val_2 = new System.EventHandler(object:  val_1, method:  System.Void PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏::专上丒丅丂丞丄下丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            .三世且丐一丐丁丆丏 = val_10;
            if(this.七业下三七一丕丟与 == null)
            {
                    this.七业下三七一丕丟与 = this.丅专丕世丄三丂世东();
                val_10 = (PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏)[1152921560415831920].三世且丐一丐丁丆丏;
            }
            
            0.add_EnterWatching(丙业与丙丗丝不丈东:  val_10);
            .丛丕丟丆丐万丘东丙 = 0;
            System.EventHandler val_4 = null;
            val_11 = val_4;
            val_4 = new System.EventHandler(object:  val_1, method:  System.Void PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏::且且专丑世丂专且丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            .丛丕丟丆丐万丘东丙 = val_11;
            if(this.七业下三七一丕丟与 == null)
            {
                    this.七业下三七一丕丟与 = this.丅专丕世丄三丂世东();
                val_11 = (PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏)[1152921560415831920].丛丕丟丆丐万丘东丙;
            }
            
            0.add_ExitWatching(丙业与丙丗丝不丈东:  val_11);
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
            if(this.七业下三七一丕丟与 == null)
            {
                    this.七业下三七一丕丟与 = this.丅专丕世丄三丂世东();
            }
            
            0.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime() {dateData = 丅丏丅丂丝一丆丙丅.dateData}, 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
            .丛丁丅丂不丂丐丝丏 = 0;
            System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_8 = null;
            val_12 = val_8;
            val_8 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏::丝专丟丐三丈丘丑七(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
            .丛丁丅丂不丂丐丝丏 = val_12;
            if(this.七业下三七一丕丟与 == null)
            {
                    this.七业下三七一丕丟与 = this.丅专丕世丄三丂世东();
                val_12 = (PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏)[1152921560415831920].丛丁丅丂不丂丐丝丏;
            }
            
            0.add_EnterIdle(丙业与丙丗丝不丈东:  val_12);
            return true;
        }
        public PixelPassTaskRewardedVideoView()
        {
        
        }
    
    }

}
