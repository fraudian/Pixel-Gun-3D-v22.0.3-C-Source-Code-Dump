using UnityEngine;
public class StickersPackItem : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject btnAvaliablePack;
    public UnityEngine.GameObject btnForBuyPack;
    private BuySmileBannerController 三丝丄丕上丒不丂下;
    public UILabel priceLabel;
    public 丞丗丈且丗下丆且世 typePack;
    
    // Properties
    internal Progress.不专丂万丐丄七上丗 上丟丙业且不丆丒下 { get; }
    
    // Methods
    internal Progress.不专丂万丐丄七上丗 三丈丈丒世丈专七一()
    {
        return (Progress.不专丂万丐丄七上丗)((this.typePack - 1) < 3) ? this.typePack : 0;
    }
    private void Start()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.priceLabel)) != false)
        {
                this.priceLabel.text = StickersController.且丘万丑七三丙不七(丄上下与丌丅七丈世:  this.typePack).丟丂丞不专丆万丒世().ToString();
        }
        
        this.三丝丄丕上丒不丂下 = this.GetComponentInParent<BuySmileBannerController>();
    }
    private void OnEnable()
    {
        this.CheckStateBtn();
    }
    public void CheckStateBtn()
    {
        UnityEngine.GameObject val_6;
        var val_7;
        if((StickersController.三下丄上丁丛与万与(丄上下与丌丅七丈世:  this.typePack)) != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.btnForBuyPack)) != false)
        {
                this.btnForBuyPack.SetActive(value:  false);
        }
        
            if((UnityEngine.Object.op_Implicit(exists:  this.btnAvaliablePack)) == false)
        {
                return;
        }
        
            val_6 = this.btnAvaliablePack;
            val_7 = 1;
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.btnForBuyPack)) != false)
        {
                this.btnForBuyPack.SetActive(value:  true);
        }
        
            if((UnityEngine.Object.op_Implicit(exists:  this.btnAvaliablePack)) == false)
        {
                return;
        }
        
            val_6 = this.btnAvaliablePack;
            val_7 = 0;
        }
        
        val_6.SetActive(value:  false);
    }
    public void TryBuyPack()
    {
        if(this.三丝丄丕上丒不丂下 == 0)
        {
                return;
        }
        
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.三丝丄丕上丒不丂下.且东丕丏业丌丗上丑(丅七丘上上丁丄丁丅:  this);
    }
    public void OnBuy()
    {
        this.CheckStateBtn();
        StickersController.丐上丕丞一七丒丐一();
    }
    public StickersPackItem()
    {
    
    }

}
