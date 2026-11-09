using UnityEngine;
public class SuperIncubatorWindowController : GeneralBannerWindow
{
    // Fields
    public UnityEngine.GameObject offerPriceBackground;
    public UnityEngine.GameObject saleContainer;
    public System.Collections.Generic.List<UILabel> saleLabels;
    public System.Collections.Generic.List<UILabel> priceLabels;
    private System.Action <三丏万丏丕丄丁丞丈>k__BackingField;
    private float 丐丅七东不丄丆丞专;
    
    // Properties
    public System.Action 丑丑业万万东丅丑丟 { get; set; }
    
    // Methods
    public System.Action get_BuyAction()
    {
        return (System.Action)this.<三丏万丏丕丄丁丞丈>k__BackingField;
    }
    public void set_BuyAction(System.Action 丙业与丙丗丝不丈东)
    {
        this.<三丏万丏丕丄丁丞丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public virtual void HandleBuyButton()
    {
        if((this.<三丏万丏丕丄丁丞丈>k__BackingField) == null)
        {
                return;
        }
        
        this.<三丏万丏丕丄丁丞丈>k__BackingField.Invoke();
    }
    private void 丗丛七一丙丑丙万丑()
    {
        SuperIncubatorWindowController.丌万一一业丝丁丈丝 val_1 = new SuperIncubatorWindowController.丌万一一业丝丁丈丝();
        .丒世丘丘上丆丝东丞 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  48, 丞一丁业丄一一业且:  "Eggs.SuperIncubatorId", 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
        this.priceLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void SuperIncubatorWindowController.丌万一一业丝丁丈丝::三丏丘业万丞丟丒世(UILabel 七丐丞丑丑丕世丙七)));
        int val_5 = 上丑三丁丄丛丁万丑.丅专万丅丟丈丏专丅(丕丁下丌不万丅丞丛:  "Eggs.SuperIncubatorId", 与业与丗专丂丆与业: out  false);
        .三丒万万丗世三丆丄 = val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offerPriceBackground, 丏业丟一东丂东丘丛:  (val_5 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.saleContainer, 丏业丟一东丂东丘丛:  ((SuperIncubatorWindowController.丌万一一业丝丁丈丝)[1152921540445557840].三丒万万丗世三丆丄 > 0) ? 1 : 0);
        this.saleLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void SuperIncubatorWindowController.丌万一一业丝丁丈丝::丌下丘且三丕三与丗(UILabel 七丐丞丑丑丕世丙七)));
        this.丐丅七东不丄丆丞专 = UnityEngine.Time.realtimeSinceStartup;
    }
    private void Awake()
    {
        this.丗丛七一丙丑丙万丑();
    }
    private void Start()
    {
        this.丆下丟七专丁丕丕万();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        val_1 = val_1 + (-0.5f);
        if(val_1 < this.丐丅七东不丄丆丞专)
        {
                return;
        }
        
        this.丗丛七一丙丑丙万丑();
    }
    private void OnDestroy()
    {
        this.丁丝与丞与丝三业丆();
    }
    public SuperIncubatorWindowController()
    {
        this.丐丅七东不丄丆丞专 = -3.402823E+38f;
    }

}
