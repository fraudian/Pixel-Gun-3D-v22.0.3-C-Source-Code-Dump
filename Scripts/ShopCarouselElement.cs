using UnityEngine;
public class ShopCarouselElement : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject priceAndDiscountContainer;
    public UnityEngine.GameObject gem;
    public UnityEngine.GameObject coin;
    public System.Collections.Generic.List<UILabel> priceLabels;
    public System.Collections.Generic.List<UILabel> discountLabels;
    public UISprite frameDiscountAndPrice;
    public UnityEngine.GameObject locked;
    public UnityEngine.Transform arrow;
    public UILabel topSeller;
    public UILabel quantity;
    public UILabel newnew;
    public bool showTS;
    public bool showNew;
    public bool showQuantity;
    public string prefabPath;
    public UnityEngine.Vector3 baseScale;
    public UnityEngine.Vector3 ourPosition;
    public string itemID;
    public string readableName;
    public UnityEngine.Transform model;
    private float 丑丘丅丂丟一丌丅丅;
    public UnityEngine.Vector3 arrnoInitialPos;
    private string <丘丕七且丂业万丞丘>k__BackingField;
    private CategoryNames <丄上丞不三与一丅丒>k__BackingField;
    
    // Properties
    private string 丛丑丞丕丐丄丄丁丄 { get; set; }
    private CategoryNames 七丌丌丏丗东丕且丅 { get; set; }
    
    // Methods
    public void SetupInfo(string 且不丏丝丝丟丂上世, CategoryNames 七丆丒与丗丌丄且丂)
    {
        this.<丘丕七且丂业万丞丘>k__BackingField = 且不丏丝丝丟丂上世;
        this.<丄上丞不三与一丅丒>k__BackingField = 七丆丒与丗丌丄且丂;
        this.丐丟专丈且丏不丛业();
    }
    private void OnEnable()
    {
        this.丐丟专丈且丏不丛业();
        this.Invoke(methodName:  "RecalculatePriceAndDiscount", time:  UnityEngine.Time.unscaledDeltaTime);
    }
    private void 丆丙且与丐万与丝丕(bool 三丒万万丗世三丆丄)
    {
        UISprite val_5;
        if(三丒万万丗世三丆丄 != false)
        {
                this.priceLabels.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_5 = this.frameDiscountAndPrice;
            val_5.width = 135;
            return;
        }
        
        this.frameDiscountAndPrice.width = 80;
        val_5 = this.priceLabels.Item[0].transform;
        val_5.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 丐丟专丈且丏不丛业()
    {
        if((this.<丘丕七且丂业万丞丘>k__BackingField) == null)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.下丞与丟万丏与丆东(且不丏丝丝丟丂上世:  this.<丘丕七且丂业万丞丘>k__BackingField, 七丆丒与丗丌丄且丂:  this.<丄上丞不三与一丅丒>k__BackingField));
    }
    private System.Collections.IEnumerator 下丞与丟万丏与丆东(string 且不丏丝丝丟丂上世, CategoryNames 七丆丒与丗丌丄且丂)
    {
        ShopCarouselElement.不不业丐七且业且丑 val_1 = new ShopCarouselElement.不不业丐七且业且丑();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .且不丏丝丝丟丂上世 = 且不丏丝丝丟丂上世;
        }
        else
        {
                mem[32] = this;
            mem[40] = 且不丏丝丝丟丂上世;
        }
        
        .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丆丝专丗世丅上丞且(string 且不丏丝丝丟丂上世, CategoryNames 七丆丒与丗丌丄且丂)
    {
    
    }
    public void SetQuantity()
    {
        string val_8;
        int val_9;
        val_8 = this;
        if((this.itemID != null) && ((下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  this.itemID).Equals(value:  下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑)) != false))
        {
                val_8 = this.itemID;
            val_9 = "/"("/") + 下专世丏丈丞三丗不.丘丌丙不丄上世丌万(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  val_8))(下专世丏丈丞三丗不.丘丌丙不丄上世丌万(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  val_8)));
        }
        else
        {
                val_9 = System.String.alignConst;
        }
        
        this.quantity.text = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  this.itemID)(下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  this.itemID)) + val_9;
    }
    private void Awake()
    {
        this.arrnoInitialPos = 0;
        mem[1152921539759315404] = 0;
    }
    private void Start()
    {
        PotionsController.丏丕丗丛丆且丞东丌(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ShopCarouselElement::世丄丅丆业下丂且上(string 万且万且丑丗且丌丆)));
    }
    private void 世丄丅丆业下丂且上(string 万且万且丑丗且丌丆)
    {
        object val_9;
        string val_10;
        int val_11;
        val_10 = 万且万且丑丗且丌丆;
        if(val_10 == null)
        {
                return;
        }
        
        if(this.itemID == null)
        {
                return;
        }
        
        if((this.itemID.Equals(value:  val_10)) == false)
        {
                return;
        }
        
        val_10 = this.quantity;
        int val_2 = 下专世丏丈丞三丗不.丏丕丅丆丆丌业万不(丞丅上丏丂且下丅与:  this.itemID);
        val_9 = val_2;
        if((this.itemID != null) && ((下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  this.itemID).Equals(value:  下专世丏丈丞三丗不.丞丒与丝丈丈丛业丑)) != false))
        {
                val_11 = "/"("/") + 下专世丏丈丞三丗不.丘丌丙不丄上世丌万(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  this.itemID))(下专世丏丈丞三丗不.丘丌丙不丄上世丌万(丞丅上丏丂且下丅与:  下专世丏丈丞三丗不.丐业不丗丞丘丌丘世(丞丅上丏丂且下丅与:  this.itemID)));
        }
        else
        {
                val_11 = System.String.alignConst;
        }
        
        val_10.text = val_2 + val_11;
    }
    public void SetPos(float 丅丐下东不丅专下丆, float 丛上丙丄丄七丈且丅)
    {
        float val_15;
        var val_16;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        val_15 = 丅丐下东不丅专下丆;
        val_16 = this;
        if(this.model != 0)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.baseScale, y = V9.16B, z = V10.16B}, d:  val_15);
            val_20 = val_2.y;
            this.model.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_20, z = val_2.z};
            val_21 = 0f;
            val_22 = 0f;
            val_23 = 0f;
            this.model.localPosition = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
        }
        
        if(this.arrow != 0)
        {
                if(val_15 > 0f)
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_15);
        }
        else
        {
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        }
        
            val_20 = val_6.y;
            float val_16 = val_20;
            this.arrow.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_16, z = val_6.z};
            UnityEngine.Vector3 val_15 = this.arrnoInitialPos;
            val_15 = val_15 * val_15;
            val_15 = val_15 * 0.7f;
            val_16 = val_16 * val_15;
            val_21 = 0f;
            val_22 = 0f;
            val_23 = 0f;
            this.arrow.localPosition = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
        }
        
        if(this.locked != 0)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  val_15);
            val_20 = val_9.y;
            this.locked.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_20, z = val_9.z};
            val_21 = 0f;
            val_22 = 0f;
            val_23 = 0f;
            this.locked.transform.localPosition = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
        }
        
        if(this.frameDiscountAndPrice == 0)
        {
                return;
        }
        
        val_16 = this.frameDiscountAndPrice.transform;
        if(val_15 > 0f)
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        }
        
        val_15 = val_14.x;
        val_20 = val_14.z;
        val_16.localScale = new UnityEngine.Vector3() {x = val_15, y = val_14.y, z = val_20};
    }
    private void OnDestroy()
    {
        PotionsController.丗七丘且三丒业丐且(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void ShopCarouselElement::世丄丅丆业下丂且上(string 万且万且丑丗且丌丆)));
    }
    private string 且三丁丆丕万丕丕丕()
    {
        return (string)this.<丘丕七且丂业万丞丘>k__BackingField;
    }
    private void 丂丕丅一丗万丞不下(string 丙业与丙丗丝不丈东)
    {
        this.<丘丕七且丂业万丞丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private CategoryNames 丒万丕七专不丏丞丌()
    {
        return (CategoryNames)this.<丄上丞不三与一丅丒>k__BackingField;
    }
    private void 与丘丑丒丅丕丞七丈(CategoryNames 丙业与丙丗丝不丈东)
    {
        this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public ShopCarouselElement()
    {
    
    }

}
