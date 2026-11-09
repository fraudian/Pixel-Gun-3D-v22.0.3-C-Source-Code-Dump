using UnityEngine;
public class ArmorViewController : MonoBehaviour
{
    // Fields
    private PGCompany.ModuleArmorInfoScreen _moduleArmorInfoScreen;
    public UnityEngine.GameObject ModuleStatsContainer;
    public UnityEngine.GameObject StandartStatsContainer;
    public UnityEngine.GameObject ArmorContainer;
    public float StandartArmorContainerY;
    public float ModuleArmorContainerY;
    public UnityEngine.GameObject armorPanel;
    public UnityEngine.Transform currentArmorPosition;
    public UnityEngine.Transform nextArmorPosition;
    public UnityEngine.Transform onlyArmorPosition;
    public UnityEngine.Transform arrowPosition;
    private bool <丝且万东一下丙万丈>k__BackingField;
    public UnityEngine.GameObject arrowObject;
    private UnityEngine.GameObject elementsParent;
    public UILabel timeToUp;
    private float 与丙东丟专丑且丟丅;
    private UIButton 万丅丕丟下丏七丛丒;
    private int 且丙上三业业东东丂;
    private 丙且上东下丏丏丟下 <上丝丞丛丘丑丁丅丁>k__BackingField;
    private bool 不七专丆丄丞丆丄与;
    
    // Properties
    internal PGCompany.ModuleArmorInfoScreen 下丕丂丟丑上丌丏丂 { get; }
    public bool 三丘丒上丏业世丝不 { get; set; }
    internal 丙且上东下丏丏丟下 与丛专丁一不丟丒丐 { get; set; }
    public ShopCarouselElement[] 丄丈丂丙一丟丏丟丒 { get; }
    
    // Methods
    internal PGCompany.ModuleArmorInfoScreen 丟上业丙上与丅下丈()
    {
        return (PGCompany.ModuleArmorInfoScreen)this._moduleArmorInfoScreen;
    }
    public bool get_OneArmorShowing()
    {
        return (bool)this.<丝且万东一下丙万丈>k__BackingField;
    }
    private void 世丄七丟一丙一七七(bool 丙业与丙丗丝不丈东)
    {
        this.<丝且万东一下丙万丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal 丙且上东下丏丏丟下 东丂丈与丄丛万丞丑()
    {
        return (丙且上东下丏丏丟下)this.<上丝丞丛丘丑丁丅丁>k__BackingField;
    }
    private void 与世丙与丅丕丏丈丕(丙且上东下丏丏丟下 丙业与丙丗丝不丈东)
    {
        this.<上丝丞丛丘丑丁丅丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public ShopCarouselElement[] get_Elements()
    {
        UnityEngine.GameObject val_3;
        var val_4;
        val_3 = this;
        val_4 = 0;
        if(this.elementsParent == 0)
        {
                return (ShopCarouselElement[])val_3.GetComponentsInChildren<ShopCarouselElement>(includeInactive:  true);
        }
        
        val_3 = this.elementsParent;
        return (ShopCarouselElement[])val_3.GetComponentsInChildren<ShopCarouselElement>(includeInactive:  true);
    }
    private void OnDisable()
    {
        this.不七专丆丄丞丆丄与 = this._moduleArmorInfoScreen.isActiveAndEnabled;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleArmorInfoScreen, 丏业丟一东丂东丘丛:  false);
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleArmorInfoScreen, 丏业丟一东丂东丘丛:  (this.不七专丆丄丞丆丄与 == true) ? 1 : 0);
    }
    internal System.Collections.Generic.List<string> 丘丝丑七丞与业三丟()
    {
        System.Collections.Generic.IEnumerable<TSource> val_6;
        var val_7;
        var val_8;
        System.Func<ShopCarouselElement, System.String> val_10;
        val_6 = this;
        val_7 = 0;
        if(this.elementsParent == 0)
        {
                return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<ShopCarouselElement, System.String>(source:  val_6 = this.elementsParent.GetComponentsInChildren<ShopCarouselElement>(includeInactive:  false), selector:  System.Func<ShopCarouselElement, System.String> val_3 = null));
        }
        
        val_8 = null;
        val_8 = null;
        val_10 = ArmorViewController.<>c.<>9__32_0;
        if(val_10 != null)
        {
                return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<ShopCarouselElement, System.String>(source:  val_6, selector:  val_3));
        }
        
        val_10 = val_3;
        val_3 = new System.Func<ShopCarouselElement, System.String>(object:  ArmorViewController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ArmorViewController.<>c::世丌丈丛丛东与业业(ShopCarouselElement 三丟东丕丄丄下下丑));
        ArmorViewController.<>c.<>9__32_0 = val_10;
        return (System.Collections.Generic.List<System.String>)System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<ShopCarouselElement, System.String>(source:  val_6, selector:  val_3));
    }
    internal void 上丌丆与下与丗东丁()
    {
    
    }
    public void ShowCurrentArmor(丙且上东下丏丏丟下 丛丗东丙丏丅东三业)
    {
        丙且上东下丏丏丟下 val_11;
        var val_12;
        CategoryNames val_13;
        bool val_14;
        var val_15;
        var val_16;
        this.且丙上三业业东东丂 = 0;
        val_11 = public T[] UnityEngine.GameObject::GetComponentsInChildren<ShopCarouselElement>(bool includeInactive);
        T[] val_1 = this.elementsParent.GetComponentsInChildren<ShopCarouselElement>(includeInactive:  true);
        val_12 = 0;
        goto label_2;
        label_10:
        T val_11 = val_1[0];
        UnityEngine.Object.Destroy(obj:  val_11.gameObject);
        val_13 = val_11.transform;
        val_11 = 0;
        val_13.parent = 0;
        val_12 = 1;
        label_2:
        if(val_1 == null)
        {
                val_13 = 0;
        }
        
        if(val_12 < val_1.Length)
        {
            goto label_10;
        }
        
        System.Collections.Generic.List<System.String> val_4 = ArmorViewController.且丒下丝丌丏世丕丁(七丆丒与丗丌丄且丂:  val_13);
        if(丛丗东丙丏丅东三业 == null)
        {
            goto label_11;
        }
        
        label_21:
        if(val_4.Count == 0)
        {
                return;
        }
        
        if(val_4.Count != 2)
        {
            goto label_15;
        }
        
        this.丁丑丞七不丐丂丐东(丘丏丒丝专七专丑专:  val_4, 丛丗东丙丏丅东三业:  val_11);
        val_14 = 0;
        goto label_16;
        label_11:
        val_15 = null;
        val_15 = null;
        丙且上东下丏丏丟下 val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑();
        if(val_4 != null)
        {
            goto label_21;
        }
        
        goto label_21;
        label_15:
        if(val_4.Count != 1)
        {
            goto label_23;
        }
        
        this.与丗丞丞丘丑下下丝(丘丏丒丝专七专丑专:  val_4, 丛丗东丙丏丅东三业:  val_11);
        val_14 = true;
        label_16:
        this.<丝且万东一下丙万丈>k__BackingField = val_14;
        label_23:
        val_16 = null;
        val_16 = null;
        this.<上丝丞丛丘丑丁丅丁>k__BackingField = 丛丗东丙丏丅东三业;
        this.万丅丕丟下丏七丛丒 = null;
        T val_12 = this.elementsParent.GetComponentsInChildren<ShopCarouselElement>(includeInactive:  true)[0];
        丙且上东下丏丏丟下 val_10 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_9[0] + 152, 七丆丒与丗丌丄且丂:  7);
    }
    public void ChooseItem(丙且上东下丏丏丟下 丑丝丏丂且不下一东, System.Collections.Generic.List<string> 丄万丟丏且业丒上业)
    {
    
    }
    private void 丁丑丞七不丐丂丐东(System.Collections.Generic.List<string> 丘丏丒丝专七专丑专, 丙且上东下丏丏丟下 丛丗东丙丏丅东三业)
    {
        this.丛丑丞三东丂三世上(丙丄不丈专丕与万万:  丘丏丒丝专七专丑专.Item[0], 丈东丘丏与丌东东下:  this.currentArmorPosition);
        this.丛丑丞三东丂三世上(丙丄不丈专丕与万万:  丘丏丒丝专七专丑专.Item[1], 丈东丘丏与丌东东下:  this.nextArmorPosition);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrowObject, 丏业丟一东丂东丘丛:  true);
    }
    private void 与丗丞丞丘丑下下丝(System.Collections.Generic.List<string> 丘丏丒丝专七专丑专, 丙且上东下丏丏丟下 丛丗东丙丏丅东三业)
    {
        this.丛丑丞三东丂三世上(丙丄不丈专丕与万万:  丘丏丒丝专七专丑专.Item[0], 丈东丘丏与丌东东下:  this.onlyArmorPosition);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.arrowObject, 丏业丟一东丂东丘丛:  false);
    }
    private void 丛丑丞三东丂三世上(string 丙丄不丈专丕与万万, UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        var val_12;
        ArmorViewController.与丙丌丟一七下丏与 val_1 = new ArmorViewController.与丙丌丟一七下丏与();
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "ShopCarouselElement"));
        val_3.transform.parent = 丈东丘丏与丌东东下;
        val_3.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        int val_12 = this.且丙上三业业东东丂;
        val_12 = val_12 + 1;
        this.且丙上三业业东东丂 = val_12;
        string val_8 = val_12.ToString(format:  "D7");
        if(val_3 != null)
        {
                val_3.name = val_8;
        }
        else
        {
                0.name = val_8;
        }
        
        ShopCarouselElement val_9 = val_3.GetComponent<ShopCarouselElement>();
        if(val_1 != null)
        {
                val_12 = val_1;
            .丁丌丕专丙丂丕丆一 = val_9;
        }
        else
        {
                val_12 = 16;
            mem[16] = val_9;
        }
        
        mem2[0] = 丙丄不丈专丕与万万;
        if(val_1 == null)
        {
            goto label_16;
        }
        
        if(mem[16] != 0)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        mem[16].SetupInfo(且不丏丝丝丟丂上世:  val_9 + 152, 七丆丒与丗丌丄且丂:  7);
        new System.Action<UnityEngine.GameObject, CategoryNames>(object:  val_1, method:  System.Void ArmorViewController.与丙丌丟一七下丏与::专丒丅且丘丏丝专丛(UnityEngine.GameObject 专丕专丟专上丝且丛, CategoryNames 七丆丒与丗丌丄且丂)).Invoke(arg1:  丏丄丑上丛不丈且万.丝丛世与丌上三上不(丒丘丏上丙丟丑丕丈:  丙丄不丈专丕与万万, 七丆丒与丗丌丄且丂:  7), arg2:  7);
        return;
        label_16:
        if(mem[16] != 0)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    private static System.Collections.Generic.List<string> 且丒下丝丌丏世丕丁(CategoryNames 七丆丒与丗丌丄且丂)
    {
        return (System.Collections.Generic.List<System.String>)new System.Collections.Generic.List<System.String>();
    }
    public void ChangeArrowScale(float 丐丌一丈丒一丕丐丙)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  丐丌一丈丒一丕丐丙);
        this.arrowObject.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public ArmorViewController()
    {
        this.StandartArmorContainerY = -120f;
        this.ModuleArmorContainerY = -40f;
    }

}
