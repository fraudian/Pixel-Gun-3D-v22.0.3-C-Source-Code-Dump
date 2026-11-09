using UnityEngine;
public class ShopItemsRowContainer : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector2 cellSize;
    public int maxCellsCount;
    public int wrapIndex;
    public CategoryNames itemsCategory;
    private System.Collections.Generic.List<BaseArmoryCell> 丘丅下下丌上万丂且;
    
    // Properties
    public int 丘七下丑丌丝不万世 { get; }
    public System.Collections.Generic.List<BaseArmoryCell> 丑丝一上业丑丟不丁 { get; }
    
    // Methods
    public int get_CellsInContainerCount()
    {
        if(this.丘丅下下丌上万丂且 != null)
        {
                return this.丘丅下下丌上万丂且.Count;
        }
        
        return this.丘丅下下丌上万丂且.Count;
    }
    public System.Collections.Generic.List<BaseArmoryCell> get_AttachedCells()
    {
        return (System.Collections.Generic.List<BaseArmoryCell>)this.丘丅下下丌上万丂且;
    }
    private void OnEnable()
    {
        goto label_1;
        label_5:
        BaseArmoryCell val_1 = this.丘丅下下丌上万丂且.Item[0];
        0 = 1;
        label_1:
        if(0 < this.丘丅下下丌上万丂且.Count)
        {
            goto label_5;
        }
    
    }
    public void InitializeCellWithShopItem(丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 七丆丒与丗丌丄且丂, int 业丌丆业丘丟丆丁丛, UnityEngine.MonoBehaviour 丈东丘丏与丌东东下)
    {
        UnityEngine.Object val_82;
        CategoryNames val_83;
        UnityEngine.GameObject val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        ArmoryCell val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_93;
        UIToggle val_94;
        var val_95;
        var val_96;
        var val_97;
        val_82 = 丈东丘丏与丌东东下;
        val_83 = 七丆丒与丗丌丄且丂;
        .丑丝丏丂且不下一东 = 丑丝丏丂且不下一东;
        BaseArmoryCell val_2 = this.丘丅下下丌上万丂且.Item[业丌丆业丘丟丆丁丛];
        val_84 = val_2;
        if((val_82 == null) || (null == null))
        {
            goto label_4;
        }
        
        val_85 = 0;
        goto label_6;
        label_4:
        val_85 = 0;
        goto label_7;
        label_6:
        val_82 = 0;
        label_7:
        val_86 = null;
        val_87 = 0;
        if((ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东 == null)
        {
            goto label_10;
        }
        
        if(val_87 == 0)
        {
            goto label_11;
        }
        
        val_86 = null;
        var val_4 = (((BaseArmoryCell.__il2cppRuntimeField_typeHierarchy + (ArmoryCell.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_86) ? (val_84) : 0;
        val_88 = mem[(BaseArmoryCell.__il2cppRuntimeField_typeHierarchy + (ArmoryCell.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_86 ? val_2 : 0 + 536];
        val_88 = (BaseArmoryCell.__il2cppRuntimeField_typeHierarchy + (ArmoryCell.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == val_86 ? val_2 : 0 + 536;
        goto label_15;
        label_10:
        if(val_84 == null)
        {
            goto label_18;
        }
        
        val_89 = val_84;
        val_89 = 0;
        this.七且丆丐七下丂丈丆(丌丝万上丅丒一丈丘:  val_89, 七丆丒与丗丌丄且丂:  val_83);
        goto label_21;
        label_11:
        val_88 = 0;
        label_15:
        if(((上丑三丁丄丛丁万丑.丞丏丕丒丞下业丏丑(丁丂专业丁丅丅丈丙:  val_83)) != false) && ((ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东 != null))
        {
                var val_10 = ((ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.丒万丕七专不丏丞丌() == 2) ? 1 : 0;
        }
        else
        {
                val_90 = 0;
        }
        
        if((上丑三丁丄丛丁万丑.业丐业三三专丁世业(七丆丒与丗丌丄且丂:  val_83)) == false)
        {
            goto label_29;
        }
        
        label_120:
        val_91 = 1;
        label_139:
        if(val_83 == 250000)
        {
                val_91 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().丁丐丅丈丑业丒三上(丞丅上丏丂且下丅与:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七());
        }
        
        bool val_15 = val_91;
        val_83 = 1152921504848912384;
        if((val_82 == 0) || (380 == 0))
        {
            goto label_38;
        }
        
        if(val_2.toggle.value == false)
        {
            goto label_40;
        }
        
        val_83 = (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七();
        if((380.业上丙丞丐丄丆丅七().Equals(value:  val_83)) == false)
        {
            goto label_60;
        }
        
        label_40:
        if(val_2.toggle.value == true)
        {
            goto label_67;
        }
        
        val_92 = 380;
        if(val_92 != 0)
        {
            goto label_64;
        }
        
        goto label_48;
        label_38:
        if(( == 0) || (CurrentItem == null))
        {
            goto label_67;
        }
        
        if(val_2.toggle.value == false)
        {
            goto label_55;
        }
        
        val_82 = CurrentItem.业上丙丞丐丄丆丅七();
        val_83 = (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七();
        if((val_82.Equals(value:  val_83)) == false)
        {
            goto label_60;
        }
        
        label_55:
        val_82 = val_2.toggle;
        if(val_82.value == true)
        {
            goto label_67;
        }
        
        val_92 = CurrentItem;
        if(val_92 != null)
        {
            goto label_64;
        }
        
        label_48:
        label_64:
        val_82 = (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七();
        if((val_92.业上丙丞丐丄丆丅七().Equals(value:  val_82)) == false)
        {
            goto label_67;
        }
        
        val_93 = 1;
        val_94 = val_2.toggle;
        goto label_70;
        label_29:
        val_95 = null;
        val_95 = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) != false)
        {
                if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) == null)
        {
            goto label_120;
        }
        
        }
        
        if((丛且丗丌丏下七下丈.世上万一丌一上丐上(丞一丁业丄一一业且:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) != false)
        {
                if((丛且丗丌丏下七下丈.丞丈丐丈丂丕丐丌丂(丞一丁业丄一一业且:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_120;
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.丆丘东且世丂且丗丌(丁丂专业丁丅丅丈丙:  val_83)) != false)
        {
                if((System.Linq.Enumerable.Any<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  new ShopItemsRowContainer.下丌丛三下专丘丐丕(), method:  System.Boolean ShopItemsRowContainer.下丌丛三下专丘丐丕::丘丛丞丝与丆丅丘丄(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑)))) != false)
        {
                if((七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  val_83).Contains(item:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_120;
        }
        
        }
        
        }
        
        val_96 = null;
        val_96 = null;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) != false)
        {
                if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) == null)
        {
            goto label_120;
        }
        
        }
        
        val_97 = null;
        val_97 = null;
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) != false)
        {
                if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) == null)
        {
            goto label_120;
        }
        
        }
        
        if((上丑三丁丄丛丁万丑.上丟丁丒丏上且丄丕(七丆丒与丗丌丄且丂:  val_83)) == false)
        {
            goto label_139;
        }
        
        var val_64 = ((丁下万丟且丟丛下业.万丟与与丆丟丗丏丗(丞一丁业丄一一业且:  (ShopItemsRowContainer.下丌丛三下专丘丐丕)[1152921539767678432].丑丝丏丂且不下一东.业上丙丞丐丄丆丅七())) == 1) ? 1 : 0;
        goto label_139;
        label_18:
        val_2.七且丆丐七下丂丈丆(丌丝万上丅丒一丈丘:  0, 七丆丒与丗丌丄且丂:  val_83);
        label_21:
        val_84 = val_84.gameObject;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_84, 丏业丟一东丂东丘丛:  true);
        return;
        label_60:
        val_94 = val_2.toggle;
        val_93 = 0;
        label_70:
        丞东丑专丛丆丄丝世.万丟业不丘丛丟丄丐(丒世丅业丝东下与丗:  val_94, 丏业丟一东丂东丘丛:  false);
        label_67:
        if(val_84.gameObject.activeInHierarchy == false)
        {
            goto label_134;
        }
        
        val_84.StopAllCoroutines();
        if(val_88 == 0)
        {
                return;
        }
        
        label_138:
        val_84 = ???;
        val_82 = ???;
        val_83 = ???;
        val_91 = ???;
        val_88 = ???;
        goto typeof(BaseArmoryCell).__il2cppRuntimeField_188;
        label_134:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_84.gameObject, 丏业丟一东丂东丘丛:  true);
        if(val_88 != 0)
        {
            goto label_138;
        }
    
    }
    public void AttachCell(BaseArmoryCell 丆丌丏丞丄丈万丒丁, CategoryNames 七丆丒与丗丌丄且丂)
    {
        BaseArmoryCell val_4 = 丆丌丏丞丄丈万丒丁;
        if(val_4 == 0)
        {
                return;
        }
        
        this.丘丅下下丌上万丂且.Add(item:  val_4 = 丆丌丏丞丄丈万丒丁);
        val_4 = val_4.transform;
        val_4.SetParent(parent:  this.transform, worldPositionStays:  false);
        this.itemsCategory = 七丆丒与丗丌丄且丂;
    }
    public void RepositionCells()
    {
        this.丞丁下丟丆且下上丕();
    }
    public void ClearContainer()
    {
        List.Enumerator<T> val_1 = this.丘丅下下丌上万丂且.GetEnumerator();
        label_6:
        if((801706536 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  0.丐丏七丌丕丗业且上().gameObject);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丘丅下下丌上万丂且.Clear();
    }
    private void 七且丆丐七下丂丈丆(ArmoryCell 丌丝万上丅丒一丈丘, CategoryNames 七丆丒与丗丌丄且丂)
    {
        if(丌丝万上丅丒一丈丘 != null)
        {
                丌丝万上丅丒一丈丘.MakeCellEmpty();
        }
        else
        {
                0.MakeCellEmpty();
        }
        
        丌丝万上丅丒一丈丘.SetupEmptyCellCategory(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
    }
    private void 丞丁下丟丆且下上丕()
    {
        int val_1 = this.丘丅下下丌上万丂且.Count;
        int val_5 = this.maxCellsCount;
        if(val_1 < val_5)
        {
                return;
        }
        
        val_5 = val_5 - 1;
        if(val_1 < val_5)
        {
                return;
        }
        
        UnityEngine.Vector2 val_6 = this.cellSize;
        val_6 = val_6 * (float)val_5;
        var val_8 = 0;
        do
        {
            UnityEngine.Vector2 val_7 = this.cellSize;
            val_7 = val_7 * 0f;
            val_7 = val_7 - (val_6 * 0.5f);
            this.丘丅下下丌上万丂且.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_8 = val_8 + 1;
        }
        while(val_8 < this.maxCellsCount);
    
    }
    public ShopItemsRowContainer()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.cellSize = val_1;
        mem[1152921539768710652] = val_1.y;
        this.丘丅下下丌上万丂且 = new System.Collections.Generic.List<BaseArmoryCell>();
    }

}
