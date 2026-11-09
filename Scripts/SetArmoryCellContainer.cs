using UnityEngine;
internal sealed class SetArmoryCellContainer : MonoBehaviour
{
    // Fields
    private UIBasicSprite itemIcon1;
    private UIBasicSprite itemIcon2;
    private UIBasicSprite itemIcon3;
    private UIBasicSprite itemIcon4;
    public UnityEngine.GameObject checkmark1;
    public UnityEngine.GameObject checkmark2;
    public UnityEngine.GameObject checkmark3;
    public UnityEngine.GameObject checkmark4;
    public UnityEngine.GameObject craftedBg1;
    public UnityEngine.GameObject craftedBg2;
    public UnityEngine.GameObject craftedBg3;
    public UnityEngine.GameObject craftedBg4;
    
    // Properties
    private UIBasicSprite 丛丒与丂丕丆与与业 { get; }
    private UIBasicSprite 丟不丒七丁东上丆万 { get; }
    private UIBasicSprite 不丄丕三丄与东丞下 { get; }
    private UIBasicSprite 丂业丕丕东专丏丞丅 { get; }
    
    // Methods
    private UIBasicSprite 万丟丆丄丘且丕丑丈()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemIcon1);
        this.itemIcon1 = val_1;
        return val_1;
    }
    private UIBasicSprite 丌丟一与业下丑丂不()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemIcon2);
        this.itemIcon2 = val_1;
        return val_1;
    }
    private UIBasicSprite 专丂业丑丗丞丘且世()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemIcon3);
        this.itemIcon3 = val_1;
        return val_1;
    }
    private UIBasicSprite 世丄丞丅丂丐丟丕上()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemIcon4);
        this.itemIcon4 = val_1;
        return val_1;
    }
    internal void 丈且东丑丂且万丒丅(丛且专丞丗丆丙丒万 丂万丏专丒下丈丂丟)
    {
        UnityEngine.GameObject val_46;
        var val_47;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames> val_49;
        CategoryNames val_50;
        var val_51;
        string val_52;
        System.Collections.Generic.IEnumerable<TSource> val_53;
        UnityEngine.GameObject val_54;
        var val_55;
        UnityEngine.GameObject val_56;
        var val_57;
        UnityEngine.GameObject val_58;
        val_46 = this;
        val_47 = null;
        val_47 = null;
        val_49 = SetArmoryCellContainer.<>c.<>9__20_0;
        if(val_49 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames> val_1 = null;
            val_49 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames>(object:  SetArmoryCellContainer.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames SetArmoryCellContainer.<>c::丂丛七丟丝东东万丗(System.Collections.Generic.KeyValuePair<CategoryNames, string> 丈丏万丄丒业丅丒一));
            SetArmoryCellContainer.<>c.<>9__20_0 = val_49;
        }
        
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames>(source:  丂万丏专丒下丈丂丟.丝丈不丗丐不丙丟丁, keySelector:  val_1));
        System.Collections.Generic.Dictionary<CategoryNames, System.String> val_4 = 丙丞丟丑丗丅专丈一.丂丙丟丅七七丗丄与(丂万丏专丒下丈丂丟:  丂万丏专丒下丈丂丟);
        if(丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 != null)
        {
                val_50 = 131072;
            val_50 = 2;
            val_51 = 1;
            val_52 = 丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝.下丄丈不与世丐业专;
        }
        else
        {
                System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_5 = val_3.Item[0];
            System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_6 = val_3.Item[0];
            val_51 = 1;
            val_52 = ;
            val_50 = val_6.Value.丙东专丂世丈丏丁丂();
        }
        
        if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_6.Value, 七丆丒与丗丌丄且丂:  val_50, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) != 0)
        {
                UIBasicSprite val_10 = this.万丟丆丄丘且丕丑丈();
        }
        
        if(丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 != null)
        {
                val_53 = 丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁;
            bool val_12 = System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  val_53, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, System.Boolean>(object:  val_4, method:  public static System.Boolean System.Linq.Enumerable::Contains<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.KeyValuePair<CategoryNames, System.String> value)));
        }
        else
        {
                System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_13 = val_3.Item[0];
            val_53 = val_4;
            string val_46 = val_13.Value;
        }
        
        val_46 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_53, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_46});
        int val_15 = (丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 == 0) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.craftedBg1, 丏业丟一东丂东丘丛:  val_46);
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_16 = val_3.Item[val_15];
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_17 = val_3.Item[val_15];
        if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_17.Value, 七丆丒与丗丌丄且丂:  val_17.Value.丙东专丂世丈丏丁丂(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) != 0)
        {
                UIBasicSprite val_21 = this.丌丟一与业下丑丂不();
        }
        
        val_54 = this.craftedBg2;
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_22 = val_3.Item[val_15];
        string val_47 = val_22.Value;
        val_47 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_4, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_47});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_54, 丏业丟一东丂东丘丛:  val_47);
        int val_24 = (丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 == 0) ? (1 + 1) : 1;
        if(val_3.Count <= val_24)
        {
            goto label_39;
        }
        
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_26 = val_3.Item[val_24];
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_27 = val_3.Item[val_24];
        if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_27.Value, 七丆丒与丗丌丄且丂:  val_27.Value.丙东专丂世丈丏丁丂(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) != 0)
        {
                UIBasicSprite val_31 = this.专丂业丑丗丞丘且世();
        }
        
        val_54 = this.craftedBg3;
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_32 = val_3.Item[val_24];
        val_55 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_4, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_32.Value});
        val_56 = val_54;
        goto label_51;
        label_39:
        if(this.craftedBg3 == 0)
        {
            goto label_54;
        }
        
        val_56 = this.craftedBg3;
        val_55 = 0;
        label_51:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_56, 丏业丟一东丂东丘丛:  false);
        label_54:
        int val_35 = (丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 == 0) ? (2 + 1) : 2;
        if(val_3.Count > val_35)
        {
                System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_37 = val_3.Item[val_35];
            System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_38 = val_3.Item[val_35];
            val_54 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_38.Value, 七丆丒与丗丌丄且丂:  val_38.Value.丙东专丂世丈丏丁丂(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            if(val_54 != 0)
        {
                UIBasicSprite val_42 = this.世丄丞丅丂丐丟丕上();
        }
        
            val_46 = this.craftedBg4;
            System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_43 = val_3.Item[val_35];
            val_57 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_4, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_43.Value});
            val_58 = val_46;
        }
        else
        {
                if(this.craftedBg4 == 0)
        {
                return;
        }
        
            val_46 = this.craftedBg4;
            val_58 = val_46;
            val_57 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_58, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丞丆上丞东三不丅丘(丛且专丞丗丆丙丒万 丂万丏专丒下丈丂丟)
    {
        var val_23;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames> val_25;
        bool val_26;
        var val_27;
        UnityEngine.GameObject val_28;
        var val_29;
        UnityEngine.GameObject val_30;
        System.Collections.Generic.Dictionary<CategoryNames, System.String> val_1 = 丙丞丟丑丗丅专丈一.与世丛丁丒丅丙丒丈(丕专七丙丂丅丕与丘:  0);
        丙丞丟丑丗丅专丈一.东与丆丕丘七丘丑丘(丂万丏专丒下丈丂丟:  丂万丏专丒下丈丂丟, 东且丁丆丛丁丏丘且:  val_1);
        val_23 = null;
        val_23 = null;
        val_25 = SetArmoryCellContainer.<>c.<>9__21_0;
        if(val_25 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames> val_2 = null;
            val_25 = val_2;
            val_2 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames>(object:  SetArmoryCellContainer.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames SetArmoryCellContainer.<>c::东且丌丛世不丈丞丈(System.Collections.Generic.KeyValuePair<CategoryNames, string> 丈丏万丄丒业丅丒一));
            SetArmoryCellContainer.<>c.<>9__21_0 = val_25;
        }
        
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>, CategoryNames>(source:  丂万丏专丒下丈丂丟.丝丈不丗丐不丙丟丁, keySelector:  val_2));
        if(丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 != null)
        {
                val_26 = (System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(source:  System.Linq.Enumerable.Except<System.Collections.Generic.KeyValuePair<CategoryNames, System.String>>(first:  丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁, second:  val_1))) ^ 1;
        }
        else
        {
                System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_7 = val_4.Item[0];
            string val_22 = val_7.Value;
            val_26 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_1, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_22});
        }
        
        val_22 = val_26;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.checkmark1, 丏业丟一东丂东丘丛:  val_22);
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_10 = val_4.Item[(丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 == 0) ? 1 : 0];
        string val_23 = val_10.Value;
        val_23 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_1, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_23});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.checkmark2, 丏业丟一东丂东丘丛:  val_23);
        int val_12 = (丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 == 0) ? (1 + 1) : 1;
        if(val_4.Count <= val_12)
        {
            goto label_19;
        }
        
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_14 = val_4.Item[val_12];
        val_27 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_1, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_14.Value});
        val_28 = this.checkmark3;
        goto label_23;
        label_19:
        if(this.checkmark3 == 0)
        {
            goto label_26;
        }
        
        val_28 = this.checkmark3;
        val_27 = 0;
        label_23:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_28, 丏业丟一东丂东丘丛:  false);
        label_26:
        int val_17 = (丂万丏专丒下丈丂丟.上七不丅丈丁不丛丝 == 0) ? (2 + 1) : 2;
        if(val_4.Count <= val_17)
        {
            goto label_30;
        }
        
        System.Collections.Generic.KeyValuePair<CategoryNames, System.String> val_19 = val_4.Item[val_17];
        val_29 = System.Linq.Enumerable.Contains<System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>>(source:  val_1, value:  new System.Collections.Generic.KeyValuePair<System.Int32Enum, System.Object>() {Value = val_19.Value});
        val_30 = this.checkmark4;
        goto label_34;
        label_30:
        if(this.checkmark4 == 0)
        {
            goto label_37;
        }
        
        val_30 = this.checkmark4;
        val_29 = 0;
        label_34:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30, 丏业丟一东丂东丘丛:  false);
        label_37:
        丙丞丟丑丗丅专丈一.丌丌下丐万七丈且专(万丝且丘不丑丝下丑:  val_1);
    }
    public void ResetContainer()
    {
        if(this.万丟丆丄丘且丕丑丈() != 0)
        {
                UIBasicSprite val_3 = this.万丟丆丄丘且丕丑丈();
        }
        
        if(this.丌丟一与业下丑丂不() != 0)
        {
                UIBasicSprite val_6 = this.丌丟一与业下丑丂不();
        }
        
        if(this.专丂业丑丗丞丘且世() != 0)
        {
                UIBasicSprite val_9 = this.专丂业丑丗丞丘且世();
        }
        
        if(this.世丄丞丅丂丐丟丕上() == 0)
        {
                return;
        }
        
        UIBasicSprite val_12 = this.世丄丞丅丂丐丟丕上();
        this = ???;
        goto typeof(UIBasicSprite).__il2cppRuntimeField_2E8;
    }
    public SetArmoryCellContainer()
    {
    
    }

}
