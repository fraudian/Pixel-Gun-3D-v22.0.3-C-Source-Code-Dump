using UnityEngine;
public class InGameGUIPart_Speedrun : InGameGUIPartContainer
{
    // Fields
    private UnityEngine.GameObject shieldBuy;
    private UIButton shieldBuyButton;
    private UILabel shieldBuyPrice;
    private UnityEngine.GameObject safeZone;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.不不丙世丟一丛丆丗 = this;
    }
    private void Start()
    {
        this.shieldBuyButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  SpeedrunTrackController.丛专与丅下丌丆世丒, 丛丌丙世专世东丕下:  public System.Void SpeedrunTrackController::TryBuyShield())));
    }
    private void Update()
    {
        UILabel val_12;
        int val_13;
        val_12 = this;
        if(SpeedrunTrackController.丛专与丅下丌丆世丒 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.safeZone, 丏业丟一东丂东丘丛:  SpeedrunTrackController.丛专与丅下丌丆世丒.showSafeZone);
        val_13 = SpeedrunTrackController.丛专与丅下丌丆世丒;
        if(this.shieldBuy.activeSelf ^ val_13.canBuyShield == false)
        {
                return;
        }
        
        if(SpeedrunTrackController.丛专与丅下丌丆世丒.canBuyShield == false)
        {
            goto label_11;
        }
        
        val_13 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
        if(this.shieldBuy != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_11:
        val_13 = 0;
        if(this.shieldBuy != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        this.shieldBuy.SetActive(value:  false);
        if(SpeedrunTrackController.丛专与丅下丌丆世丒.canBuyShield == false)
        {
                return;
        }
        
        val_12 = this.shieldBuyPrice;
        val_12.text = 1.ToString();
    }
    public InGameGUIPart_Speedrun()
    {
    
    }

}
