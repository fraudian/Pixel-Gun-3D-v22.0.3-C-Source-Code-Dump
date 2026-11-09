using UnityEngine;
public sealed class RentScreenController : PropertyInfoScreenController
{
    // Fields
    public UnityEngine.GameObject viewButtonPanel;
    public UnityEngine.GameObject rentButtonsPanel;
    public UIButton viewButton;
    public UnityEngine.GameObject window;
    public UILabel[] header;
    public UILabel[] rentFor;
    public UILabel[] prices;
    public UILabel[] pricesCoins;
    public UIButton[] buttons;
    public UITexture itemImage;
    public System.Action onEnterCoinsShopAdditionalAction;
    public System.Action onExitCoinsShopAdditionalAction;
    public System.Action<string> customEquipWearAction;
    private string 丝三业丌丟丁丗丕丞;
    private CategoryNames 七丆丒与丗丌丄且丂;
    
    // Properties
    set; }
    public string 专丕丏丑丈丈专业丆 { set; }
    public string 七三七业丑下丞丕万 { set; }
    
    // Methods
    public void set_Header(string 丙业与丙丗丝不丈东)
    {
        goto label_1;
        label_9:
        UILabel val_2 = this.header[0];
        if((丙业与丙丗丝不丈东 != null) && (val_2 != 0))
        {
                val_2.text = 丙业与丙丗丝不丈东;
        }
        
        0 = 1;
        label_1:
        if(0 < this.header.Length)
        {
            goto label_9;
        }
    
    }
    public void set_RentFor(string 丙业与丙丗丝不丈东)
    {
        UILabel val_4;
        goto label_1;
        label_12:
        val_4 = this.rentFor[0];
        if(((丙业与丙丗丝不丈东 != null) && (val_4 != 0)) && (this.丝三业丌丟丁丗丕丞 != null))
        {
                val_4.text = System.String.Format(format:  丙业与丙丗丝不丈东, arg0:  丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  this.丝三业丌丟丁丗丕丞));
        }
        
        0 = 1;
        label_1:
        if(0 < this.rentFor.Length)
        {
            goto label_12;
        }
    
    }
    public void set_ItemTag(string 丙业与丙丗丝不丈东)
    {
    
    }
    public override void Hide()
    {
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void HandleRentButton(UIButton 丌丗丏丏丛东专丁且)
    {
    
    }
    public void HandleViewButton()
    {
    
    }
    private void Awake()
    {
        this.rentButtonsPanel.SetActive(value:  false);
        this.viewButtonPanel.SetActive(value:  true);
    }
    internal static void 丞丈丄上丘丁丛且七(int 丙上丌丈丑丈七丝专)
    {
        ExpController val_1 = ExpController.丑七不且上丗丁一世();
        if(val_1 == 0)
        {
                return;
        }
        
        if(val_1.丄下丆丗丞丕丁丟丙() == 0)
        {
                return;
        }
        
        val_1.丄下丆丗丞丕丁丟丙().depth = (float)丙上丌丈丑丈七丝专;
    }
    private void Start()
    {
        RentScreenController.丞丈丄上丘丁丛且七(丙上丌丈丑丈七丝专:  89);
    }
    private void OnDestroy()
    {
        RentScreenController.丞丈丄上丘丁丛且七(丙上丌丈丑丈七丝专:  99);
    }
    public RentScreenController()
    {
    
    }

}
