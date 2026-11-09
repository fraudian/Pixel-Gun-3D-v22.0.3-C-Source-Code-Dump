using UnityEngine;
internal sealed class PixelPassLevelView : PGBehaviour
{
    // Fields
    private PixelPassRewardsLineView rewardsLineView;
    private UnityEngine.GameObject button;
    private PixelPassCellFirstView firstView;
    private PixelPassCellRegularView regularView;
    private PixelPassCellLastView lastView;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfReached;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPremium;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfFree;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfNotPremium;
    private UnityEngine.GameObject notificationGO;
    private TagSystem.CompoundTagBehaviour compoundTagBehaviour;
    private PGCompany.PixelPass.丆丟丈丕下下丘丅丗 上七丘万世丂万丙丗;
    
    // Properties
    internal PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丕业且丅丁丙不专丄 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丆丟丈丕下下丘丅丗 业下业专七与丒业万()
    {
        return (PGCompany.PixelPass.丆丟丈丕下下丘丅丗)this.上七丘万世丂万丙丗;
    }
    private void OnEnable()
    {
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.万丘丑丙丈丛与丝丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassLevelView::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
    }
    private void OnDisable()
    {
        PGCompany.PixelPass.丙丙丕万东丘下丅丌.丆万丛万丙七世万业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.PixelPass.七丒七与丆下丕丏丅>(object:  this, method:  System.Void PixelPassLevelView::丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丅丌丆丁世一丙丑丐)
    {
        this.上七丘万世丂万丙丗 = 丅丌丆丁世一丙丑丐;
        if(this.compoundTagBehaviour != null)
        {
                this.compoundTagBehaviour.与上丒丆丟与丘与丑();
            if(this.compoundTagBehaviour != null)
        {
                this.compoundTagBehaviour.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  PGCompany.PixelPass.丁且七丅丞丐丌丌世.丞丈世丆七丄七丌丕(丈丁丆三丅上丂丘丟:  丅丌丆丁世一丙丑丐.丈一下下丞世三丑丄()));
        }
        
        }
        
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_16;
        var val_17;
        PixelPassCellFirstView val_18;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.firstView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.regularView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lastView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.notificationGO, 丏业丟一东丂东丘丛:  (~PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三()) & 1);
        if(this.上七丘万世丂万丙丗 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.button, 丏业丟一东丂东丘丛:  this.丂一丁丐世丗丆丝丘());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfFree, 丏业丟一东丂东丘丛:  this.上七丘万世丂万丙丗.专丁丞万东丄万丄丄());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfReached, 丏业丟一东丂东丘丛:  (~this.上七丘万世丂万丙丗.丕且七丂专丆专丘丞()) & 1);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPremium, 丏业丟一东丂东丘丛:  this.上七丘万世丂万丙丗.丘丗不丂世丘三三丙().三丐丌丏专世丆丞丗());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfNotPremium, 丏业丟一东丂东丘丛:  (~this.上七丘万世丂万丙丗.丘丗不丂世丘三三丙().三丐丌丏专世丆丞丗()) & 1);
        PGCompany.PixelPass.下且丘丞丆丞丁丄丝 val_15 = this.上七丘万世丂万丙丗.不业丙丒丂丞下丆丙();
        if(val_15 == 3)
        {
            goto label_13;
        }
        
        if(val_15 == 2)
        {
            goto label_14;
        }
        
        if(val_15 != 1)
        {
                return;
        }
        
        val_16 = this.上七丘万世丂万丙丗;
        val_17 = null;
        val_18 = this.firstView;
        goto label_24;
        label_13:
        val_16 = this.上七丘万世丂万丙丗;
        val_17 = null;
        val_18 = this.lastView;
        goto label_24;
        label_14:
        val_16 = this.上七丘万世丂万丙丗;
        val_17 = null;
        val_18 = this.regularView;
        label_24:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18, 丏业丟一东丂东丘丛:  true);
    }
    private bool 丂一丁丐世丗丆丝丘()
    {
        if(this.上七丘万世丂万丙丗 != null)
        {
                return this.上七丘万世丂万丙丗.不一丅丂上丁丈三下();
        }
        
        return this.上七丘万世丂万丙丗.不一丅丂上丁丈三下();
    }
    private void 丄且不丏不万世丝万(PGCompany.PixelPass.七丒七与丆下丕丏丅 不丕一下丒不世与且)
    {
        this.丝一丅丆三东丂丞七();
    }
    public void U_OnLevelPressed()
    {
        if(this.上七丘万世丂万丙丗 == null)
        {
                return;
        }
        
        if(this.上七丘万世丂万丙丗.不一丅丂上丁丈三下() == false)
        {
                return;
        }
        
        this.上七丘万世丂万丙丗.三丛丁丆东世丁丏三();
        this.丝一丅丆三东丂丞七();
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  13, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
    }
    public void U_BuyLevels()
    {
        if(this.rewardsLineView == null)
        {
                return;
        }
        
        this.rewardsLineView.上业与丈丞丈专丑丄(丐丑世东丈丑三业丘:  this.上七丘万世丂万丙丗.丈一下下丞世三丑丄() - this.上七丘万世丂万丙丗.丘丗不丂世丘三三丙().丞丞丘业东丙丏七丌());
    }
    public void U_BuyPremiumPressed()
    {
        PixelPassView.丝业丆丁业三丈丟东.ShowBuyPremium();
    }
    public PixelPassLevelView()
    {
    
    }

}
