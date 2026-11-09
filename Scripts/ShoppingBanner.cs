using UnityEngine;
public class ShoppingBanner : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject availablePanel;
    public UnityEngine.GameObject boughtePanel;
    public UnityEngine.GameObject notavailablePanel;
    public UILabel descriptionLabel;
    public UILabel priceLabel;
    private UIBasicSprite transportIcon;
    public UILabel boughteLabel;
    public UILabel notavailableLabel;
    internal UnityEngine.Events.UnityAction 丆丒世丈丙丐丝三不;
    private UnityEngine.Transform 上丛丂三上与丂丕丑;
    private UnityEngine.Vector3 一丙丘下下丂丅丛业;
    private UnityEngine.Vector3 与丆一丒丘下丑丈丁;
    
    // Properties
    private UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    internal bool 下三业丐不丆东三丄 { get; }
    
    // Methods
    private UIBasicSprite 丑一丆丑且丟上业丛()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.transportIcon);
        this.transportIcon = val_1;
        return val_1;
    }
    internal bool 丒丗丐下丘丄丗东与()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    private void Awake()
    {
        this.上丛丂三上与丂丕丑 = this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.一丙丘下下丂丅丛业 = val_2;
        mem[1152921537243806012] = val_2.y;
        mem[1152921537243806016] = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  78f);
        this.与丆一丒丘下丑丈丁 = val_4;
        mem[1152921537243806024] = val_4.y;
        mem[1152921537243806028] = val_4.z;
    }
    public void PriceButtonClick()
    {
        if(this.丆丒世丈丙丐丝三不 == null)
        {
                return;
        }
        
        this.丆丒世丈丙丐丝三不.Invoke();
    }
    internal void 丄丂丙东业丆业不三(ShoppingAreaBase 丙丟三丅一丂丂下世)
    {
        string val_10;
        this.世一丛丞世丁专丘丐(丏业丟一东丂东丘丛:  丙丟三丅一丂丂下世.丝专丗丂丅丒七丞东());
        if(丙丟三丅一丂丂下世 == null)
        {
                return;
        }
        
        var val_2 = (((ShoppingAreaBase.__il2cppRuntimeField_typeHierarchy + (TransportShoppingArea.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丙丟三丅一丂丂下世 : 0;
        val_10 = val_2.下丛且丁上丗丅世丝();
        if(丙丟三丅一丂丂下世.丝专丗丂丅丒七丞东() == 1)
        {
                if((System.String.IsNullOrEmpty(value:  val_10)) != true)
        {
                this.descriptionLabel.text = val_10;
        }
        
            this.priceLabel.text = val_2 + 96.ToString();
            this.不与丆丝丂丙丝三丘(七不丏丗丘丘东万七:  (ShoppingAreaBase.__il2cppRuntimeField_typeHierarchy + (TransportShoppingArea.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 丙丟三丅一丂丂下世 : 0 + 72);
        }
        
        if(丙丟三丅一丂丂下世.丝专丗丂丅丒七丞东() != 2)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_10)) == true)
        {
                return;
        }
        
        this = this.boughteLabel;
        this.text = val_10;
    }
    internal void 丆世与丑丆丅丐万且()
    {
        this.世一丛丞世丁专丘丐(丏业丟一东丂东丘丛:  0);
    }
    private void 世一丛丞世丁专丘丐(丟丞世万丈丒丒上丟 丏业丟一东丂东丘丛)
    {
        this.gameObject.SetActive(value:  (丏业丟一东丂东丘丛 != 0) ? 1 : 0);
        this.availablePanel.SetActive(value:  (丏业丟一东丂东丘丛 == 1) ? 1 : 0);
        this.boughtePanel.SetActive(value:  (丏业丟一东丂东丘丛 == 2) ? 1 : 0);
        this.notavailablePanel.SetActive(value:  (丏业丟一东丂东丘丛 == 3) ? 1 : 0);
    }
    internal void 不与丆丝丂丙丝三丘(string 七不丏丗丘丘东万七)
    {
        UnityEngine.Texture val_1 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  七不丏丗丘丘东万七, 七丆丒与丗丌丄且丂:  80, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(this.丑一丆丑且丟上业丛() == null)
        {
            
        }
    
    }
    private void LateUpdate()
    {
        UnityEngine.Vector3 val_15;
        float val_16;
        float val_17;
        InGameGUIPart_Freeplay val_18;
        InGameGUIPart_Freeplay val_19;
        val_15 = this.一丙丘下下丂丅丛业;
        val_18 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_18 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(null != 0)
        {
                bool val_2 = typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.下丄业丆丟丌丘丆丂();
            val_18 = 0;
        }
        
        if(((-1721963892) & 1) != 0)
        {
                if(GetValueOrDefault() != false)
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  78f);
            val_15 = val_5.x;
            val_16 = val_5.y;
            val_17 = val_5.z;
        }
        
        }
        
        val_19 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_19 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(null != 0)
        {
                bool val_7 = typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_178.丒丗丐下丘丄丗东与();
            val_19 = 0;
        }
        
        if(((-1721963892) & 1) != 0)
        {
                if(GetValueOrDefault() != false)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  125f);
            val_15 = val_10.x;
            val_16 = val_10.y;
            val_17 = val_10.z;
        }
        
        }
        
        UnityEngine.Vector3 val_11 = this.上丛丂三上与丂丕丑.localPosition;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, t:  UnityEngine.Time.deltaTime * 5f);
        this.上丛丂三上与丂丕丑.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }
    public ShoppingBanner()
    {
    
    }

}
