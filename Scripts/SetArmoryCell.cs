using UnityEngine;
internal sealed class SetArmoryCell : BaseArmoryCellWithEquips
{
    // Fields
    private SetArmoryCellContainer[] numOfItemsVariantContainers;
    private UISprite miniIcon;
    private UILabel header;
    public UnityEngine.GameObject equipped;
    private 丛且专丞丗丆丙丒万 <且丗丌上一丝丒丆丏>k__BackingField;
    
    // Properties
    private 丛且专丞丗丆丙丒万 丅专下万丕丑丆丅丝 { get; set; }
    
    // Methods
    public void HandleFirstItemClicked()
    {
    
    }
    public void HandleSecondItemClicked()
    {
    
    }
    public void HandleThirdItemClicked()
    {
    
    }
    public void HandleFourtItemClicked()
    {
    
    }
    private void 丐万丝丙丑七丞丆丏(int 丞世不丒下上上丝丑)
    {
    
    }
    private void 丁丒丆丈下上世不丂(System.Collections.Generic.KeyValuePair<CategoryNames, string> 一专丝七丛世丒丞与)
    {
    
    }
    public override void Setup(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丑丙丈三丞一丙丕丅, bool 丆丗一丛丌一与丅且, bool 丁三丌七丝丞丐专丐)
    {
        string val_20;
        UnityEngine.Object val_21;
        string val_22;
        var val_23;
        val_20 = this;
        丑丙丈三丞一丙丕丅 = 丑丙丈三丞一丙丕丅;
        丆丗一丛丌一与丅且 = 丆丗一丛丌一与丅且;
        丁三丌七丝丞丐专丐 = 丁三丌七丝丞丐专丐;
        丛且专丞丗丆丙丒万 val_11 = 0;
        this.Setup(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丑丙丈三丞一丙丕丅:  丑丙丈三丞一丙丕丅, 丆丗一丛丌一与丅且:  丆丗一丛丌一与丅且, 与上七丈丁三丂世丟:  丁三丌七丝丞丐专丐);
        val_21 = 0;
        if(this.miniIcon != val_21)
        {
                val_21 = 丙丞丟丑丗丅专丈一.丝世丝丌丝丝万丌七(丐世下不一丁丟丅专:  this.ItemId);
            this.miniIcon.spriteName = val_21;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.ItemId)) == false)
        {
            goto label_9;
        }
        
        label_21:
        object[] val_6 = new object[1];
        string val_7 = this.ItemId;
        val_20 = "Setup: cannot get craftSet, ItemId = {0}";
        val_6[0] = (val_7 == null) ? "null" : (val_7);
        UnityEngine.Debug.LogErrorFormat(format:  val_20, args:  val_6);
        return;
        label_9:
        if((val_11 == 0) || ((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().TryGetValue(key:  this.ItemId, value: out  val_11)) == false))
        {
            goto label_21;
        }
        
        this.<且丗丌上一丝丒丆丏>k__BackingField = val_11;
        int val_13 = 0.Count;
        val_23 = 0;
        var val_15 = (((this.<且丗丌上一丝丒丆丏>k__BackingField.上七不丅丈丁不丛丝) != 0) ? (val_13 + 1) : (val_13)) - 1;
        goto label_24;
        label_43:
        if(this.numOfItemsVariantContainers[0] != 0)
        {
                this.numOfItemsVariantContainers[0].ResetContainer();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.numOfItemsVariantContainers[0].gameObject, 丏业丟一东丂东丘丛:  (val_15 == val_23) ? 1 : 0);
            if(val_15 == val_23)
        {
                this.numOfItemsVariantContainers[0].丈且东丑丂且万丒丅(丂万丏专丒下丈丂丟:  val_11);
        }
        
        }
        
        val_23 = 1;
        label_24:
        if(val_23 < this.numOfItemsVariantContainers.Length)
        {
            goto label_43;
        }
        
        val_22 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.<且丗丌上一丝丒丆丏>k__BackingField.丑丗丁丞丒丂与丙丈);
        this.header.text = val_22;
        this.丞丆上丞东三不丅丘();
    }
    protected override void 丞业与下丛万丁下丙()
    {
    
    }
    private void OnEnable()
    {
        this.丁世丒专丟丙与丛丅();
    }
    private void OnDisable()
    {
        this.上丄一丐丗丛东丈丌();
    }
    internal override void 丐且专丙三丕丞专丅(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        this.丞丆上丞东三不丅丘();
    }
    protected override void 丂丗上专丘丌丙丛丏(string 丈丄丁丂丞丑下下丄, CategoryNames 上丌丛不业与世丑丏, string 与丑与丒丟丗万丙丁)
    {
        this.丞丆上丞东三不丅丘();
    }
    protected override void 丌丌且东丒丈丐丌丌(CategoryNames 上丌丛不业与世丑丏, string 与丑与丒丟丗万丙丁)
    {
        this.丞丆上丞东三不丅丘();
    }
    protected override void 且专下万东丄不万且(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)
    {
        this.丞丆上丞东三不丅丘();
    }
    protected override void 世且丞丞丁丅丟世丞(string 万且万且丑丗且丌丆)
    {
        this.丞丆上丞东三不丅丘();
    }
    private void 丞丆上丞东三不丅丘()
    {
        string val_19;
        SetArmoryCellContainer[] val_20;
        var val_21;
        var val_22;
        val_19 = this;
        丛且专丞丗丆丙丒万 val_8 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.ItemId)) == false)
        {
            goto label_3;
        }
        
        label_15:
        object[] val_3 = new object[1];
        string val_4 = this.ItemId;
        val_19 = "UpdateEquippeds cannot get craftSet, ItemId = {0}";
        val_3[0] = (val_4 == null) ? "null" : (val_4);
        UnityEngine.Debug.LogErrorFormat(format:  val_19, args:  val_3);
        return;
        label_3:
        if((val_8 == 0) || ((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().TryGetValue(key:  this.ItemId, value: out  val_8)) == false))
        {
            goto label_15;
        }
        
        val_21 = 0;
        System.Collections.Generic.Dictionary<CategoryNames, System.String> val_10 = 丙丞丟丑丗丅专丈一.与世丛丁丒丅丙丒丈(丕专七丙丂丅丕与丘:  0);
        丙丞丟丑丗丅专丈一.东与丆丕丘七丘丑丘(丂万丏专丒下丈丂丟:  val_8, 东且丁丆丛丁丏丘且:  val_10);
        if(val_21 != 0)
        {
                val_21 = mem[15762873573703752].Count + 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipped, 丏业丟一东丂东丘丛:  (val_10.Count == (val_21 + 0.Count)) ? 1 : 0);
        val_22 = 0;
        goto label_27;
        label_42:
        if(this.numOfItemsVariantContainers[0] != 0)
        {
                if(this.numOfItemsVariantContainers[0].gameObject.activeSelf != false)
        {
                this.numOfItemsVariantContainers[0].丞丆上丞东三不丅丘(丂万丏专丒下丈丂丟:  val_8);
        }
        
        }
        
        val_22 = 1;
        label_27:
        val_20 = this.numOfItemsVariantContainers;
        if(val_22 < this.numOfItemsVariantContainers.Length)
        {
            goto label_42;
        }
        
        丙丞丟丑丗丅专丈一.丌丌下丐万七丈且专(万丝且丘不丑丝下丑:  val_10);
    }
    private 丛且专丞丗丆丙丒万 三专丈丄丘丌万丈丞()
    {
        return (丛且专丞丗丆丙丒万)this.<且丗丌上一丝丒丆丏>k__BackingField;
    }
    private void 丒七不丑丟丁七且丛(丛且专丞丗丆丙丒万 丙业与丙丗丝不丈东)
    {
        this.<且丗丌上一丝丒丆丏>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public override void HandleToggleClicked(UIToggle 丒世丅业丝东下与丗)
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        this.HandleToggleClicked(丒世丅业丝东下与丗:  丒世丅业丝东下与丗);
    }
    public SetArmoryCell()
    {
    
    }

}
