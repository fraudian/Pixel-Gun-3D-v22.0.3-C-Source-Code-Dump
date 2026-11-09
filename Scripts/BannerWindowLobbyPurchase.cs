using UnityEngine;
public class BannerWindowLobbyPurchase : BannerWindowWithBack
{
    // Fields
    private PGCompany.UI.七万丁丞丄丛业一丌 丕丒丕七上东丌世丌;
    
    // Properties
    protected bool 业与丟七与丞丛丒万 { get; }
    
    // Methods
    protected bool 且丑丛丘下丟丑丛丐()
    {
        if(this.丕丒丕七上东丌世丌 == null)
        {
                return (bool)this.丕丒丕七上东丌世丌;
        }
        
        return this.丕丒丕七上东丌世丌.且丑丛丘下丟丑丛丐();
    }
    public override void Show()
    {
        PGCompany.UI.七万丁丞丄丛业一丌 val_3;
        this.Show();
        val_3 = this.丕丒丕七上东丌世丌;
        if(val_3 == null)
        {
                PGCompany.UI.七万丁丞丄丛业一丌 val_2 = null;
            val_3 = val_2;
            val_2 = new PGCompany.UI.七万丁丞丄丛业一丌(七万上丐一丈丏丏专:  this.transform);
            this.丕丒丕七上东丌世丌 = val_3;
        }
        
        val_2.丒上丁丄丛上丅丁且();
    }
    public override void Hide()
    {
        if(this.丕丒丕七上东丌世丌 != null)
        {
                this.丕丒丕七上东丌世丌.Dispose();
            this.丕丒丕七上东丌世丌 = 0;
        }
        
        this.Hide();
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        PGCompany.丌与丛丕业丈不丐世.丅丂且三丂丟丒业丕(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void BannerWindowLobbyPurchase::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
    }
    protected override void OnDisable()
    {
        PGCompany.丌与丛丕业丈不丐世.丟丗丄丟东丆丈与丑(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void BannerWindowLobbyPurchase::丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)));
        this.OnDisable();
    }
    private void 丞丑业丅丕丅丄丛丒(InappRememberedBonus 万且万且丑丗且丌丆)
    {
        goto typeof(BannerWindowLobbyPurchase).__il2cppRuntimeField_218;
    }
    public BannerWindowLobbyPurchase()
    {
        val_1 = new PGBehaviour();
    }

}
