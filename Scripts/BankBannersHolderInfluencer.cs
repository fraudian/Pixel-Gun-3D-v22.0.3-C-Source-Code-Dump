using UnityEngine;
internal sealed class BankBannersHolderInfluencer : PGBehaviour
{
    // Fields
    public Rilisoft.BankBannersHolder bannersHolder;
    public System.Collections.Generic.List<string> doNotDisableSelfWithBanners;
    
    // Methods
    public bool CanDisableSelf()
    {
        var val_9;
        if(this.bannersHolder != 0)
        {
                if(this.bannersHolder.CurrentBanner != 0)
        {
            goto label_7;
        }
        
        }
        
        val_9 = 1;
        return (bool)val_9;
        label_7:
        List.Enumerator<T> val_4 = this.doNotDisableSelfWithBanners.GetEnumerator();
        if((109739896 & 1) != 0)
        {
                bool val_8 = this.bannersHolder.CurrentBanner.name.StartsWith(value:  0.丐丏七丌丕丗业且上());
            val_9 = 0;
        }
        else
        {
                val_9 = 1;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_9;
    }
    public BankBannersHolderInfluencer()
    {
    
    }

}
