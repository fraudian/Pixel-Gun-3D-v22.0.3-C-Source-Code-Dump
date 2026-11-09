using UnityEngine;
public class AlmanachWeaponSetCell : EndlessScrollCellDynamic
{
    // Fields
    internal AlmanachWeaponSet 丕与丝万丑丏丑东与;
    private UnityEngine.GameObject holder;
    private MiniPoolMonoBehaviour miniPool;
    private float spacing;
    private PGCompany.AlmanachWeaponSetCellMini girdCellExample;
    private UIGrid weaponsGrid;
    private UIWidget weaponsWidget;
    private UIWidget contentContainer;
    private System.Collections.Generic.List<UILabel> title;
    private UnityEngine.GameObject selectedGO;
    private OfferItemView rewardUi;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfRewardCollected;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfRewardNotCollected;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfSetNotComplete;
    private AlmanachMainUI almanachMainUI;
    private System.Collections.Generic.List<PGCompany.AlmanachWeaponSetCellMini> 下丗与丘丅丝业丁下;
    private UnityEngine.GameObject devCollectSetButton;
    
    // Properties
    internal OfferItemView 不与丈丝不七专一丅 { get; }
    
    // Methods
    internal OfferItemView 且三丄丐丄丑业丑丒()
    {
        return (OfferItemView)this.rewardUi;
    }
    public override void OnSelectStateUpdate()
    {
        this.OnSelectStateUpdate();
        this.东专丑七与丟丁上丗();
    }
    internal void 丈且东丑丂且万丒丅(AlmanachWeaponSet 丕与丝万丑丏丑东与)
    {
        this.丕与丝万丑丏丑东与 = 丕与丝万丑丏丑东与;
        mem[1152921524345376928] = "";
        this.holder.SetActive(value:  false);
        if(丕与丝万丑丏丑东与 != null)
        {
                mem[1152921524345376928] = 丕与丝万丑丏丑东与.id;
            this.holder.enabled = true;
            this.丏丏丁不业丛丑丝丕(三丟丈丒丐丐三一丌:  丕与丝万丑丏丑东与.weapons);
            this.gameObject.SetActive(value:  true);
            this.holder.SetActive(value:  true);
            上且丁万与丌下丐上.丑丄丘万万丄丑丁业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丟丝东丈丐丙三下丛>(object:  this, method:  System.Void AlmanachWeaponSetCell::丒丘丂一丁丈丘上且(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)));
            上且丁万与丌下丐上.丈与丞丒丂丟丗一丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丟丝东丈丐丙三下丛>(object:  this, method:  System.Void AlmanachWeaponSetCell::丒丘丂一丁丈丘上且(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)));
            this.东专丑七与丟丁上丗();
            return;
        }
        
        this.enabled = false;
    }
    private void 东专丑七与丟丁上丗()
    {
        OfferItemView val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.List<UnityEngine.GameObject> val_18;
        val_13 = this;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfRewardCollected, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfRewardNotCollected, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfSetNotComplete, 丏业丟一东丂东丘丛:  false);
        if(this.丕与丝万丑丏丑东与 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.title, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} ({1}/{2})", arg0:  this.丕与丝万丑丏丑东与.Name, arg1:  this.丕与丝万丑丏丑东与.PurchasedCount, arg2:  this.丕与丝万丑丏丑东与.weapons.Count));
        val_14 = this.Selected;
        if(this.selectedGO == null)
        {
            goto label_9;
        }
        
        if(val_14 == false)
        {
            goto label_10;
        }
        
        label_12:
        val_15 = 1;
        goto label_11;
        label_9:
        if(val_14 == true)
        {
            goto label_12;
        }
        
        label_10:
        val_15 = 0;
        label_11:
        this.selectedGO.SetActive(value:  false);
        this.devCollectSetButton.SetActive(value:  false);
        if(this.丕与丝万丑丏丑东与.IsCompleted == false)
        {
            goto label_15;
        }
        
        bool val_7 = 上且丁万与丌下丐上.丟万下专丟上业丁下(丕与丝万丑丏丑东与:  this.丕与丝万丑丏丑东与);
        val_16 = val_13;
        val_14 = this.rewardUi.gameObject;
        if(val_14 == null)
        {
            goto label_19;
        }
        
        if(val_7 == false)
        {
            goto label_20;
        }
        
        label_32:
        val_14.SetActive(value:  false);
        val_17 = null;
        val_18 = this.enableIfRewardCollected;
        goto label_34;
        label_15:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfSetNotComplete, 丏业丟一东丂东丘丛:  true);
        val_16 = val_13;
        this.rewardUi.gameObject.SetActive(value:  true);
        if(DeveloperConsoleController.丙丒丛一丞下三且一() == false)
        {
            goto label_31;
        }
        
        this.devCollectSetButton.SetActive(value:  true);
        goto label_31;
        label_19:
        if(val_7 == true)
        {
            goto label_32;
        }
        
        label_20:
        val_14.SetActive(value:  true);
        val_17 = null;
        val_18 = this.enableIfRewardNotCollected;
        label_34:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  true);
        label_31:
        if(this.rewardUi.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        val_13 = this.rewardUi;
        val_13.Setup(与且专丈不万东一万:  this.丕与丝万丑丏丑东与.reward);
    }
    private void 丒丘丂一丁丈丘上且(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
    {
        if(this == 0)
        {
                return;
        }
        
        if(一业一丕丅下业世与 == null)
        {
                return;
        }
        
        if(this.丕与丝万丑丏丑东与 == null)
        {
                return;
        }
        
        if((this.丕与丝万丑丏丑东与.weapons.Contains(item:  一业一丕丅下业世与)) == false)
        {
                return;
        }
        
        this.丈且东丑丂且万丒丅(丕与丝万丑丏丑东与:  this.丕与丝万丑丏丑东与);
    }
    private PGCompany.AlmanachWeaponSetCellMini 丘丂世丏丛不丌丅三()
    {
        if(this.miniPool != 0)
        {
                PGCompany.AlmanachWeaponSetCellMini val_2 = this.miniPool.Get<PGCompany.AlmanachWeaponSetCellMini>();
        }
        else
        {
                PGCompany.AlmanachWeaponSetCellMini val_3 = UnityEngine.Object.Instantiate<PGCompany.AlmanachWeaponSetCellMini>(original:  this.girdCellExample);
        }
        
        val_3.transform.SetParent(p:  this.weaponsGrid.transform);
        return val_3;
    }
    private void 丛七丕丘丒上且上丛()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.下丗与丘丅丝业丁下.GetEnumerator();
        label_11:
        if(((-1735485536) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(this.miniPool == 0)
        {
            goto label_5;
        }
        
        this.miniPool.Return(万且万且丑丗且丌丆:  val_4);
        goto label_11;
        label_5:
        UnityEngine.Object.Destroy(obj:  val_4.gameObject);
        goto label_11;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.下丗与丘丅丝业丁下.Clear();
    }
    private void 丏丏丁不业丛丑丝丕(System.Collections.Generic.List<PGCompany.丟丝东丈丐丙三下丛> 三丟丈丒丐丐三一丌)
    {
        var val_11;
        var val_22;
        float val_23;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.girdCellExample, 丏业丟一东丂东丘丛:  false);
        this.丛七丕丘丒上且上丛();
        WeaponSetsScrollSettings val_1 = this.almanachMainUI.GetWeaponSetsUISettings();
        this.contentContainer.ResetAndUpdateAnchors();
        float val_22 = -2f;
        float val_23 = (float)this.contentContainer.width;
        val_22 = this.spacing * val_22;
        val_23 = val_23 + val_22;
        this.weaponsWidget.width = (int)val_23;
        this.weaponsWidget.height = this.contentContainer.height;
        this.weaponsWidget.ResetAndUpdateAnchors();
        float val_5 = (float)this.weaponsWidget.width / (float)val_1.cellsInRow;
        this.weaponsGrid.cellWidth = val_5;
        this.weaponsGrid.cellHeight = val_5;
        this.weaponsGrid.maxPerLine = val_1.cellsInRow;
        int val_6 = 三丟丈丒丐丐三一丌.Count;
        float val_24 = (float)val_6;
        val_24 = val_24 / (float)this.weaponsGrid.maxPerLine;
        float val_25 = this.weaponsGrid.cellHeight;
        val_25 = val_25 * ((float)UnityEngine.Mathf.CeilToInt(f:  val_24));
        val_25 = val_25 + (float)val_1.hightFixer;
        val_6.height = UnityEngine.Mathf.CeilToInt(f:  val_25);
        this.UpdateRects();
        List.Enumerator<T> val_9 = 三丟丈丒丐丐三一丌.GetEnumerator();
        label_34:
        if(((-1735233312) & 1) == 0)
        {
            goto label_22;
        }
        
        PGCompany.AlmanachWeaponSetCellMini val_13 = this.丘丂世丏丛不丌丅三();
        this.下丗与丘丅丝业丁下.Add(item:  val_13);
        UnityEngine.Transform val_14 = val_13.transform;
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_14);
        val_13.mainWidget.height = (int)val_5 - this.spacing;
        val_13.mainWidget.width = val_13.mainWidget.height;
        val_13.丈且东丑丂且万丒丅(一业一丕丅下业世与:  val_11.丐丏七丌丕丗业且上());
        val_14.SetAsLastSibling();
        val_13.gameObject.SetActive(value:  false);
        val_13.gameObject.SetActive(value:  true);
        goto label_34;
        label_22:
        val_22 = public System.Void List.Enumerator<PGCompany.丟丝东丈丐丙三下丛>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Transform val_19 = this.weaponsGrid.transform;
        if(val_19 != null)
        {
                val_23 = V10.16B;
            val_19.position = new UnityEngine.Vector3() {x = val_23, y = this.spacing, z = V9.16B};
        }
        else
        {
                val_23 = V10.16B;
            0.position = new UnityEngine.Vector3() {x = val_23, y = this.spacing, z = V9.16B};
        }
        
        UnityEngine.Vector3 val_20 = val_19.localPosition;
        float val_27 = this.spacing;
        float val_26 = 0.5f;
        val_26 = val_5 * val_26;
        val_27 = val_26 + val_27;
        val_19.localPosition = new UnityEngine.Vector3() {x = val_20.x + val_27, y = 0f, z = 0f};
        this.weaponsGrid.repositionNow = true;
    }
    public void RewardButtonPressed()
    {
        if((上且丁万与丌下丐上.丙丛丘上万丆丝丄七(丕与丝万丑丏丑东与:  this.丕与丝万丑丏丑东与)) == false)
        {
                return;
        }
        
        this.东专丑七与丟丁上丗();
    }
    public void DEVCollectSet()
    {
    
    }
    public AlmanachWeaponSetCell()
    {
        this.spacing = 5f;
        this.下丗与丘丅丝业丁下 = new System.Collections.Generic.List<PGCompany.AlmanachWeaponSetCellMini>();
    }

}
