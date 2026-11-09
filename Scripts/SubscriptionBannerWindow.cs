using UnityEngine;
public class SubscriptionBannerWindow : BannerWindow
{
    // Fields
    public UILabel priceShort;
    public UILabel description;
    public UILabel[] priceOnButton;
    public UnityEngine.GameObject[] subscribeNowOnButton;
    public UnityEngine.GameObject priceContainer;
    public UILabel[] subscriptionName;
    public UILabel[] dailyReward;
    
    // Methods
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 三丅丙一专业世丝丏()
    {
        this.HideSelf();
    }
    private void 不丟丂七下且万丅丟(string 万且万且丑丗且丌丆)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丅不丛业上丆丂七丒(string 丛丆东与丑丞丅丝专, bool 不丁丌丐业丑丟且不)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丑丒丅丄三丄丞万七()
    {
    
    }
    private void OnDisable()
    {
    
    }
    private void 丝一丅丆三东丂丞七()
    {
        UILabel val_13;
        UILabel val_14;
        var val_15;
        var val_16;
        var val_17;
        val_13 = this;
        if(this.priceShort == 0)
        {
                return;
        }
        
        this.priceShort.text = "4.99$";
        Rilisoft.业丙丘丆东丈丕丂丄 val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丐上丙世丂丅丝不丈(丁丅丈丌丟世丗丗丟:  110);
        val_14 = 1152921505507483648;
        if(val_3 != null)
        {
                val_15 = null;
        }
        
        if(val_3 != null)
        {
                val_15 = null;
        }
        
        val_16 = 0;
        goto label_17;
        label_23:
        val_14 = this.subscriptionName[0];
        val_14.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8018");
        val_16 = 1;
        label_17:
        if(val_16 < this.subscriptionName.Length)
        {
            goto label_23;
        }
        
        val_17 = 0;
        goto label_24;
        label_30:
        val_13 = this.dailyReward[0];
        val_14 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8019"), arg0:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  丕丏丂一与万丟专丙(丁丅丈丌丟世丗丗丟:  2).Count));
        val_13.text = val_14;
        val_17 = 1;
        label_24:
        if(val_17 < this.dailyReward.Length)
        {
            goto label_30;
        }
    
    }
    public void U_Hide()
    {
        this.HideSelf();
    }
    public void U_PrivacyPolicy()
    {
        SettingsController.丄丈丄丗丈七万丙万();
    }
    public void U_TermsOfUse()
    {
        SettingsController.一丝丈一丂七且丘世();
    }
    public void U_Restore()
    {
        SettingsController.丄丕万丁丗丆丒丅不();
        this.HideSelf();
    }
    public void U_Buy()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        bool val_1 = coinsShop.专丆专上丗万世丒七.东业丒丒丈丏丈与丁(丅丞丂丟丟且丅丆丅:  StoreKitEventListener.丒丁丐丙丐丈丕专世 + 32);
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        this.HideSelf();
    }
    public SubscriptionBannerWindow()
    {
    
    }

}
