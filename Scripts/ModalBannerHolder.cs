using UnityEngine;
internal sealed class ModalBannerHolder : PGBehaviour
{
    // Fields
    private static ModalBannerHolder 丝业丆丁业三丈丟东;
    internal Rilisoft.BankBannersHolder mainStoreHolder;
    internal Rilisoft.BankBannersHolder universalRewardHolder;
    internal Rilisoft.BankBannersHolder lootBoxHolder;
    internal Rilisoft.BankBannersHolder EventChestsHolder;
    
    // Properties
    internal static ModalBannerHolder 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static ModalBannerHolder 丑七不且上丗丁一世()
    {
        ModalBannerHolder val_8;
        var val_9;
        var val_10;
        if(ModalBannerHolder.丝业丆丁业三丈丟东 == 0)
        {
                ModalBannerHolder.丝业丆丁业三丈丟东 = UnityEngine.Object.Instantiate<ModalBannerHolder>(original:  UnityEngine.Resources.Load<ModalBannerHolder>(path:  "ModalBannerHolder"));
            UnityEngine.Object.DontDestroyOnLoad(target:  ModalBannerHolder.丝业丆丁业三丈丟东.gameObject);
        }
        
        val_8 = ModalBannerHolder.丝业丆丁业三丈丟东;
        if(val_8 == 0)
        {
                return (ModalBannerHolder)ModalBannerHolder.丝业丆丁业三丈丟东;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = ModalBannerHolder.丝业丆丁业三丈丟东.transform;
        if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
        {
                val_10 = 0f;
        }
        else
        {
                val_10 = -5000f;
        }
        
        val_8.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return (ModalBannerHolder)ModalBannerHolder.丝业丆丁业三丈丟东;
    }
    internal void 丐业专丆万不世丈丑(bool 丙业与丙丗丝不丈东)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.mainStoreHolder.transform.parent, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    public ModalBannerHolder()
    {
    
    }

}
