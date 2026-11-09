using UnityEngine;
public class ShopCategoryButton : MonoBehaviour
{
    // Fields
    private static System.Action<ShopCategoryButton> 一东下世丑丝东丛丘;
    public UIBasicSprite icon;
    public UnityEngine.GameObject emptyIcon;
    public UnityEngine.Transform modelPoint;
    private UnityEngine.GameObject normalSprite;
    
    // Methods
    internal static void 丐丝丟上丕丛一丝三(System.Action<ShopCategoryButton> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ShopCategoryButton.一东下世丑丝东丛丘, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丅丄三不三世丆丕丆(System.Action<ShopCategoryButton> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ShopCategoryButton.一东下世丑丝东丛丘, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.normalSprite, 丏业丟一东丂东丘丛:  true);
    }
    public UnityEngine.Texture GetTexture()
    {
        if(this.icon == 0)
        {
                return 0;
        }
        
        if(this.icon == null)
        {
            
        }
    
    }
    public void EnableNormalSprite(UIToggle 丒世丅业丝东下与丗)
    {
        if(this.normalSprite == 0)
        {
                return;
        }
        
        this.normalSprite.gameObject.SetActive(value:  (~丒世丅业丝东下与丗.value) & 1);
    }
    private void 东三上世专一业丟丘()
    {
        UnityEngine.MonoBehaviour val_15;
        var val_18;
        EventDelegate val_19;
        val_15 = this;
        System.Collections.IEnumerator val_2 = this.transform.GetEnumerator();
        goto label_11;
        label_19:
        var val_17 = 0;
        val_17 = val_17 + 1;
        object val_4 = val_2.Current;
        if((System.String.op_Equality(a:  0.name, b:  "Normal")) == false)
        {
            goto label_11;
        }
        
        goto label_12;
        label_11:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_19;
        }
        
        val_18 = 0;
        val_19 = 0;
        goto label_22;
        label_12:
        val_18 = 0;
        val_19 = 0;
        this.normalSprite = 0.gameObject;
        label_22:
        if(val_2 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_2.Dispose();
        }
        
        if( == 1)
        {
            goto label_36;
        }
        
        if((null == null) || (88 == 88))
        {
            goto label_46;
        }
        
        label_45:
        label_46:
        if((this.GetComponent<UIToggle>()) == 0)
        {
                return;
        }
        
        val_13.onChange = new System.Collections.Generic.List<EventDelegate>();
        EventDelegate val_16 = null;
        val_19 = val_16;
        val_16 = new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "EnableNormalSprite");
        val_15 = val_13.onChange;
        val_15.Add(item:  val_16);
        return;
        label_36:
        if(null != null)
        {
            goto label_45;
        }
        
        goto label_46;
    }
    public void SetIcon(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        var val_15;
        UIBasicSprite val_16;
        UIBasicSprite val_17;
        if(this.icon == 0)
        {
                return;
        }
        
        System.Type val_3 = this.icon.GetType();
        if(与万丆丛丒万丝丙丑 == 0)
        {
            goto label_7;
        }
        
        if((System.Type.op_Inequality(left:  val_3, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_23;
        }
        
        if((与万丆丛丒万丝丙丑.name.Contains(value:  "icon1_big")) != true)
        {
                if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/Android_Alpha/{0}_Alpha", arg0:  与万丆丛丒万丝丙丑.name))) == 0)
        {
            goto label_23;
        }
        
        }
        
        val_15 = 1;
        val_16 = this.icon;
        goto label_20;
        label_7:
        if((System.Type.op_Inequality(left:  val_3, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_23;
        }
        
        val_16 = this.icon;
        val_15 = 0;
        label_20:
        val_17 = 丞东丑专丛丆丄丝世.上且丂一丌丛丝丕丝(与丄丈丘丟丕丏丐丁:  val_16, 丁丒丘丈上上丙丗三:  false);
        this.icon = val_17;
        if(val_17 != null)
        {
            goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        }
        
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
        label_23:
        val_17 = this.icon;
        if(val_17 == null)
        {
            
        }
    
    }
    private void Start()
    {
        UIBasicSprite val_10;
        if(this.icon == 0)
        {
                return;
        }
        
        val_10 = this.icon;
        if(this.icon == 0)
        {
            goto label_7;
        }
        
        val_10 = this.icon;
        if((val_10.name.Contains(value:  "icon1_big")) == false)
        {
            goto label_11;
        }
        
        label_7:
        label_19:
        this.icon = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  val_10);
        return;
        label_11:
        if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/Android_Alpha/{0}_Alpha", arg0:  val_10.name))) == 0)
        {
                return;
        }
        
        goto label_19;
    }
    public void OnClick()
    {
        if(ShopCategoryButton.一东下世丑丝东丛丘 == null)
        {
                return;
        }
        
        ShopCategoryButton.一东下世丑丝东丛丘.Invoke(obj:  this);
    }
    public ShopCategoryButton()
    {
    
    }

}
