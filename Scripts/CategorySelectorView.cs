using UnityEngine;
internal sealed class CategorySelectorView : SelectableButtonController
{
    // Fields
    private MiniPoolMonoBehaviour buttonsPool;
    private System.Collections.Generic.List<CategorySelectableButton> 下丏专丒丑一丘东丁;
    private System.Collections.Generic.List<CategoryNames> 上专上七下丆丅下丈;
    
    // Properties
    internal System.Collections.Generic.List<CategoryNames> 七丏且丌丐丙上丒一 { get; }
    internal System.Nullable<CategoryNames> 专丛丞丛万且与丆丒 { get; }
    
    // Methods
    internal System.Collections.Generic.List<CategoryNames> 丒丐七丂下万一丐不()
    {
        System.Collections.Generic.List<CategoryNames> val_2 = this.上专上七下丆丅下丈;
        if(val_2 != null)
        {
                return (System.Collections.Generic.List<CategoryNames>)val_2;
        }
        
        System.Collections.Generic.List<CategoryNames> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<CategoryNames>();
        return (System.Collections.Generic.List<CategoryNames>)val_2;
    }
    internal System.Nullable<CategoryNames> 上丝丞丞丌且丝丛丟()
    {
        var val_4;
        var val_5;
        var val_8;
        val_4 = this;
        if(static_value_082C8000 != 0)
        {
                if(this != null)
        {
                val_5 = null;
        }
        
            val_5 = null;
            var val_3 = (((CategorySelectorView.__il2cppRuntimeField_typeHierarchy + CategorySelectableButton.__il2cppRuntimeField_typeHierarchyDepth) + -8) == val_5) ? (val_4) : 0;
            val_8 = 0;
            return (System.Nullable<CategoryNames>)val_8;
        }
        
        val_8 = 0;
        return (System.Nullable<CategoryNames>)val_8;
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<CategoryNames> 丑七不与丛丆一丂丞, CategoryNames 丛丗七丅下丞丗且丐)
    {
        CategoryNames val_3;
        CategoryNames val_7;
        System.Collections.Generic.List<CategoryNames> val_8;
        val_7 = 丛丗七丅下丞丗且丐;
        val_8 = 丑七不与丛丆一丂丞;
        this.上专上七下丆丅下丈 = val_8;
        this.业丞丗丈东专丂不丛();
        List.Enumerator<T> val_1 = this.GetEnumerator();
        label_8:
        if(((-1971729504) & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_3.丐丏七丌丕丗业且上() == null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 业丞丗丈东专丂不丛()
    {
        var val_3;
        var val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buttonsPool.example, 丏业丟一东丂东丘丛:  false);
        this.丞七丐三丑东且丈下();
        List.Enumerator<T> val_1 = this.上专上七下丆丅下丈.GetEnumerator();
        label_13:
        if(((-1971566320) & 1) == 0)
        {
            goto label_5;
        }
        
        int val_4 = val_3.丙东专丂世丈丏丁丂();
        CategorySelectableButton val_5 = this.buttonsPool.Get<CategorySelectableButton>();
        val_5.transform.SetAsLastSibling();
        this.下丏专丒丑一丘东丁.Add(item:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        goto label_13;
        label_5:
        val_7 = public System.Void List.Enumerator<CategoryNames>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_3 != 0)
        {
                val_7 = 0;
            val_3.Reposition();
        }
        
        if(val_3 == 0)
        {
                return;
        }
    
    }
    internal void 丞七丐三丑东且丈下()
    {
        List.Enumerator<T> val_1 = this.下丏专丒丑一丘东丁.GetEnumerator();
        label_4:
        if(((-1971404104) & 1) == 0)
        {
            goto label_2;
        }
        
        this.buttonsPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.下丏专丒丑一丘东丁.Clear();
        if(this.下丏专丒丑一丘东丁 != null)
        {
                this.下丏专丒丑一丘东丁.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        this.下丏专丒丑一丘东丁.Clear();
        mem[1152921536995193400] = 0;
    }
    public CategorySelectorView()
    {
        this.下丏专丒丑一丘东丁 = new System.Collections.Generic.List<CategorySelectableButton>();
        this.上专上七下丆丅下丈 = new System.Collections.Generic.List<CategoryNames>();
    }

}
