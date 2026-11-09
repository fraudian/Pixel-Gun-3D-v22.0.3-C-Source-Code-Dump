using UnityEngine;
internal class PixelPassCellBaseView : PGBehaviour
{
    // Fields
    private int width;
    private System.Collections.Generic.List<UIWidget> widthRessivers;
    protected ItemRewardListView rewardListView;
    protected PGCompany.PixelPass.丆丟丈丕下下丘丅丗 上七丘万世丂万丙丗;
    
    // Properties
    internal PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丕业且丅丁丙不专丄 { get; }
    
    // Methods
    internal PGCompany.PixelPass.丆丟丈丕下下丘丅丗 业下业专七与丒业万()
    {
        return (PGCompany.PixelPass.丆丟丈丕下下丘丅丗)this.上七丘万世丂万丙丗;
    }
    internal virtual void 丈且东丑丂且万丒丅(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丅丌丆丁世一丙丑丐)
    {
        var val_5;
        var val_22 = this;
        this.上七丘万世丂万丙丗 = 丅丌丆丁世一丙丑丐;
        System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_1 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        List.Enumerator<T> val_3 = this.上七丘万世丂万丙丗.丈丏丁东上与东丙丕().GetEnumerator();
        label_28:
        if(((-408776528) & 1) == 0)
        {
            goto label_3;
        }
        
        new TagSystem.三与下丘七丘丌丏丄() = new TagSystem.三与下丘七丘丌丏丄();
        if((this.上七丘万世丂万丙丗 & 1) == 0)
        {
            goto label_5;
        }
        
        bool val_8 = new TagSystem.三与下丘七丘丌丏丄().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "Collected");
        goto label_25;
        label_5:
        if(this.上七丘万世丂万丙丗.丕且七丂专丆专丘丞() != false)
        {
                if(this.上七丘万世丂万丙丗.专丁丞万东丄万丄丄() == false)
        {
            goto label_11;
        }
        
        }
        
        if(this.上七丘万世丂万丙丗.丕且七丂专丆专丘丞() == false)
        {
            goto label_13;
        }
        
        bool val_12 = new TagSystem.三与下丘七丘丌丏丄().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "Locked");
        goto label_25;
        label_13:
        if(this.上七丘万世丂万丙丗.不一丅丂上丁丈三下() == false)
        {
            goto label_17;
        }
        
        bool val_14 = new TagSystem.三与下丘七丘丌丏丄().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "CanCollect");
        goto label_25;
        label_11:
        bool val_15 = new TagSystem.三与下丘七丘丌丏丄().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "PremiumLocked");
        goto label_25;
        label_17:
        if(this.上七丘万世丂万丙丗.丕且七丂专丆专丘丞() != true)
        {
                if(this.上七丘万世丂万丙丗.丗七与丛丁丏与丒七() != false)
        {
                bool val_18 = new TagSystem.三与下丘七丘丌丏丄().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "NeedPremiumToCollect");
        }
        
        }
        
        label_25:
        new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_5.丐丏七丌丕丗业且上(), 丆万一不丌且东丐丐:  new TagSystem.三与下丘七丘丌丏丄());
        val_1.Add(item:  new PGCompany.丄与丘丑业专丞七丅());
        goto label_28;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.rewardListView.丈且东丑丂且万丒丅(丑丟上一三业万万丏:  val_1);
        List.Enumerator<T> val_20 = this.widthRessivers.GetEnumerator();
        label_53:
        if(((-408776552) & 1) == 0)
        {
            goto label_50;
        }
        
        string val_21 = 0.丐丏七丌丕丗业且上();
        val_21.width = this.width;
        val_21.ResetAndUpdateAnchors();
        goto label_53;
        label_50:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public PixelPassCellBaseView()
    {
        this.width = 200;
    }

}
