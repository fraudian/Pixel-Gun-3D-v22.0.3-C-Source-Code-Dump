using UnityEngine;
internal sealed class Vip20InfoBanner : BannerWindowWithBack, 丑且丆万丏丝丘丙丟
{
    // Fields
    private UILabel fightsCountLabel;
    private ItemListUI rewardsPerOneListUI;
    
    // Methods
    public override void Show()
    {
        ItemListUI val_6;
        PGCompany.三东丏不丗世丅丌丄 val_7;
        val_6 = this;
        this.Show();
        val_7 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  207);
        PGCompany.七下丐丂丙丑东专丂 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.七下丐丂丙丑东专丂>(丈丄不七三万丄丁不:  val_7, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        if(val_3 != null)
        {
                val_7 = System.Int32 PGCompany.丗丟丄丈东丝丕丄世::丂丁丏一丙丛业且丌();
            if(val_3.丂丁丏一丙丛业且丌() > 0)
        {
                val_6 = this.rewardsPerOneListUI;
            val_6.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  val_3.且业上丞丄丁专不丙());
            return;
        }
        
        }
        
        this.Hide();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return true;
    }
    public bool IsEnabledLobbyCamera()
    {
        return true;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public Vip20InfoBanner()
    {
    
    }

}
