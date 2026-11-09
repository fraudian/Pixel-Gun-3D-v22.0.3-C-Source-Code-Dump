using UnityEngine;
private sealed class ShopNGUIController.丒丈三丄丑东丈且七
{
    // Fields
    public Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专;
    public PGCompany.丕下丆丑万世业丈丟 世丕丘丈丙世业东丕;
    public System.DateTime 东丆丒东不丕丑万丂;
    public PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙;
    public PGCompany.Ads.丂丐与不丘不下丂上 丛下丛下丑丞与世下;
    
    // Methods
    public ShopNGUIController.丒丈三丄丑东丈且七()
    {
    
    }
    internal void 丅业丘丄上丝丅一三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_3;
        if(ShopNGUIController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ShopNguiC.HandleSpeedupEggAds+OnAdWatchedSuccessfully]");
        }
        
        if(this.下丒丗丛丙丆丄丈专 != null)
        {
                this.下丒丗丛丙丆丄丈专.remove_AdWatchedSuccessfully(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ShopNGUIController.丒丈三丄丑东丈且七::丅业丘丄上丝丅一三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        val_3 = null;
        val_3 = null;
        this.世丕丘丈丙世业东丕.丒专丏丈万丈丒丒丁(丏专且丟丗丘丂丌丘:  Rilisoft.EggsManager.下一丌业丘丄丙丟丟);
        PGCompany.丞丁丌不丌不丄丆丟.下七丂不丄丅丁丐丟(东丆丒东不丕丑万丂:  new System.DateTime() {dateData = this.东丆丒东不丕丑万丂}, 三万万丒丏丒不丐丙:  this.三万万丒丏丒不丐丙, 丝丘与且七丏万丅且:  Rilisoft.EggsManager.下一丌业丘丄丙丟丟);
    }
    internal void 丂下专丈丙丅与丌丑(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
    {
        if(ShopNGUIController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[ShopNguiC.HandleSpeedupEggAds+OnEnterIdle]");
        }
        
        if(this.下丒丗丛丙丆丄丈专 != null)
        {
                this.下丒丗丛丙丆丄丈专.remove_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  this, method:  System.Void ShopNGUIController.丒丈三丄丑东丈且七::丂下专丈丙丅与丌丑(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
        }
        
        this.丛下丛下丑丞与世下.Dispose();
        if(this.下丒丗丛丙丆丄丈专 == 0)
        {
                return;
        }
        
        if(this.下丒丗丛丙丆丄丈专.gameObject == 0)
        {
                return;
        }
        
        Unity.Linq.丅丆万丟丐丏丏下丄.Destroy(丞丕丌不丈丐丅丙丂:  this.下丒丗丛丙丆丄丈专.gameObject, 与丁丁一丕丝东丄丂:  false);
    }

}
