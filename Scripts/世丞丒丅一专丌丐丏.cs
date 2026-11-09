using UnityEngine;
private sealed class PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏
{
    // Fields
    public PGCompany.PixelPass.PixelPassTaskRewardedVideoView 丝且与丝丒丟万丁专;
    public System.EventHandler 三世且丐一丐丁丆丏;
    public System.EventHandler 丛丕丟丆丐万丘东丙;
    public System.Action<PGCompany.PixelPass.一万丄一丌丆业丐丅> 业丏丈世世世丞丒世;
    public PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业;
    public System.EventHandler<Rilisoft.与丞专七丙专下丅且> 丛丁丅丂不丂丐丝丏;
    
    // Methods
    public PixelPassTaskRewardedVideoView.世丞丒丅一专丌丐丏()
    {
    
    }
    internal void 专上丒丅丂丞丄下丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        System.EventHandler val_3;
        var val_4;
        var val_5;
        if(this.丝且与丝丒丟万丁专.七业下三七一丕丟与 != null)
        {
                val_3 = this.三世且丐一丐丁丆丏;
        }
        else
        {
                this.丝且与丝丒丟万丁专.七业下三七一丕丟与 = this.丝且与丝丒丟万丁专.丅专丕世丄三丂世东();
            val_3 = this.三世且丐一丐丁丆丏;
        }
        
        0.remove_EnterWatching(丙业与丙丗丝不丈东:  val_3);
        val_4 = null;
        val_4 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丄丏下七丁专丂世();
    }
    internal void 且且专丑世丂专且丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        System.EventHandler val_3;
        var val_4;
        var val_5;
        if(this.丝且与丝丒丟万丁专.七业下三七一丕丟与 != null)
        {
                val_3 = this.丛丕丟丆丐万丘东丙;
        }
        else
        {
                this.丝且与丝丒丟万丁专.七业下三七一丕丟与 = this.丝且与丝丒丟万丁专.丅专丕世丄三丂世东();
            val_3 = this.丛丕丟丆丐万丘东丙;
        }
        
        0.remove_ExitWatching(丙业与丙丗丝不丈东:  val_3);
        val_4 = null;
        val_4 = null;
        if(MenuBackgroundMusic.丌丂一丛下丒丞丛东 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.三且世三丂七丐一丟();
    }
    internal void 丝专丟丐三丈丘丑七(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
    {
        System.EventHandler<Rilisoft.与丞专七丙专下丅且> val_4;
        ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  false);
        if((丗丛不丁丑专专丂且.丅丄不上丌三丘东丄() != false) && (this.业丏丈世世世丞丒世 != null))
        {
                this.业丏丈世世世丞丒世.Invoke(obj:  this.万不且且丛丆东丒业);
        }
        
        if(this.丝且与丝丒丟万丁专.七业下三七一丕丟与 != null)
        {
                val_4 = this.丛丁丅丂不丂丐丝丏;
        }
        else
        {
                this.丝且与丝丒丟万丁专.七业下三七一丕丟与 = this.丝且与丝丒丟万丁专.丅专丕世丄三丂世东();
            val_4 = this.丛丁丅丂不丂丐丝丏;
        }
        
        0.remove_EnterIdle(丙业与丙丗丝不丈东:  val_4);
    }

}
