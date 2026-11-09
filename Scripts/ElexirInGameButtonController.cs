using UnityEngine;
public class ElexirInGameButtonController : MonoBehaviour
{
    // Fields
    public bool isActivePotion;
    public UIButton myButton;
    public UILabel myLabelTime;
    public UILabel myLabelCount;
    public int price;
    public UnityEngine.GameObject plusSprite;
    public UnityEngine.GameObject myPotion;
    public UnityEngine.GameObject priceLabel;
    public UnityEngine.GameObject lockSprite;
    private bool 丛与丈丘不下丛不丁;
    public string idForPriceInDaterRegim;
    
    // Methods
    private void Awake()
    {
        this.丛且丏丆丆丐专三丁();
    }
    private void 丛且丏丆丆丐专三丁()
    {
        string val_22;
        UnityEngine.GameObject val_23;
        string val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_22 = this.idForPriceInDaterRegim;
            val_23 = this.myPotion;
        }
        else
        {
                val_23 = this;
            val_22 = this.myPotion.name;
        }
        
        string val_3 = null.name;
        val_24 = 1152921505316536320;
        val_25 = null;
        val_25 = null;
        if((System.Linq.Enumerable.Contains<System.String>(source:  下专世丏丈丞三丗不.东丆万专丈下一丑专, value:  val_22)) != false)
        {
                val_22 = 下专世丏丈丞三丗不.丕三七丈丈丆七万丆(丞丅上丏丂且下丅与:  val_22, 七丞丙丒三丕且丌丟:  下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  val_22));
        }
        
        this.丛与丈丘不下丛不丁 = Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "Knife");
        if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(this.丛与丈丘不下丛不丁 == false)
        {
            goto label_16;
        }
        
        }
        
        this.lockSprite.SetActive(value:  true);
        label_16:
        val_26 = 丏丄丑上丛不丈且万.丅专一丘专丁丂丞与(下上丐丆丝丟丝丒不:  val_22);
        if(val_3 != null)
        {
                val_27 = null;
            val_27 = null;
            if((val_3.Equals(value:  下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑)) != false)
        {
                val_28 = null;
            val_28 = null;
            val_24 = val_26.东与三丌丅三丒丏业();
            丈丞丕丘丕丗与上一 val_17 = null;
            val_26 = val_17;
            val_17 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  (下专世丏丈丞三丗不.丞丆丁丛下丅万不丞(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑)) * val_26.丟丂丞不专丆万丒世(), 丏丂不专上丘丂不丅:  val_24);
        }
        
        }
        
        this.priceLabel.GetComponent<UILabel>().text = val_17.丟丂丞不专丆万丒世().ToString();
        PotionsController.七与世丆且上丈丒三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ElexirInGameButtonController::丆不丁丒业丅与业丅(string 万且万且丑丗且丌丆)));
    }
    private void Start()
    {
        this.OnEnable();
    }
    private void 丆不丁丒业丅与业丅(string 万且万且丑丗且丌丆)
    {
        string val_12;
        string val_13;
        val_12 = 万且万且丑丗且丌丆;
        if((val_12.Equals(value:  this.myPotion.name)) == false)
        {
                return;
        }
        
        this.myLabelTime.text = System.String.alignConst;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_12 = 下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  this.idForPriceInDaterRegim);
        }
        
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                val_13 = val_12;
            int val_6 = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  val_13);
        }
        else
        {
                val_13 = val_12;
        }
        
        this.myLabelTime.enabled = false;
        this.isActivePotion = false;
        this.myLabelTime.gameObject.SetActive(value:  this.gameObject.activeSelf);
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_13, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
        {
                this.丘丛一丙丗七丞丕且();
            return;
        }
        
        this.丏万丘丑且丙丞万丟();
    }
    private void 丏万丘丑且丙丞万丟()
    {
        this.priceLabel.SetActive(value:  true);
        this.myLabelCount.gameObject.SetActive(value:  false);
        this.plusSprite.SetActive(value:  true);
        this.myLabelTime.enabled = false;
    }
    private void 丘丛一丙丗七丞丕且()
    {
        this.myLabelCount.gameObject.SetActive(value:  true);
        this.plusSprite.SetActive(value:  false);
        this.priceLabel.SetActive(value:  false);
        if(this.isActivePotion != false)
        {
                return;
        }
        
        this.myLabelTime.enabled = false;
    }
    private void OnDestroy()
    {
        PotionsController.丛世丂丒一一上且丌(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ElexirInGameButtonController::丆不丁丒业丅与业丅(string 万且万且丑丗且丌丆)));
    }
    private void OnEnable()
    {
        string val_8;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                int val_3 = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  this.idForPriceInDaterRegim));
        }
        else
        {
                val_8 = this.myPotion.name;
            int val_5 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_8, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        
        this.myLabelCount.text = val_5.ToString();
        this.myLabelTime.gameObject.SetActive(value:  true);
        if(val_5 != 0)
        {
                this.丘丛一丙丗七丞丕且();
            return;
        }
        
        if(this.isActivePotion == true)
        {
                return;
        }
        
        this.丏万丘丑且丙丞万丟();
    }
    private void OnDisable()
    {
        if(this.isActivePotion != false)
        {
                return;
        }
        
        this.myLabelTime.gameObject.SetActive(value:  false);
    }
    public ElexirInGameButtonController()
    {
        this.price = 10;
    }

}
