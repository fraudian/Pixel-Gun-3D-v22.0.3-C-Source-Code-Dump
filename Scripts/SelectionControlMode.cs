using UnityEngine;
internal sealed class SelectionControlMode : PGBehaviour
{
    // Fields
    private UIGrid switchersGrid;
    private UIControlLayoutStyleSwitcher simpleSwitcher;
    private UIControlLayoutStyleSwitcher advancedSwitcher;
    private UnityEngine.GameObject onlyAdvancedHeader;
    private UnityEngine.GameObject onlyAdvancedDescription;
    private UnityEngine.GameObject onlyAdvancedResumeButton;
    private UnityEngine.GameObject onlyAdvancedModeInfo;
    private UnityEngine.GameObject simpleAndAdvancedHeader;
    private UnityEngine.GameObject simpleAndAdvancedDescription;
    private UnityEngine.GameObject simpleAndAdvancedSelectButton;
    private UITweener alphaTween;
    private UnityEngine.GameObject shootIconAdvanced;
    private UnityEngine.GameObject hintAdvanced;
    private UnityEngine.GameObject advancedCheckBox;
    private UnityEngine.GameObject advancedExtraLabel;
    public static SelectionControlMode Instance;
    
    // Properties
    public static bool 世丑丗上丘丟丐丂丕 { get; }
    
    // Methods
    public static bool get_IsShowing()
    {
        if(SelectionControlMode.Instance == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_2 = SelectionControlMode.Instance.gameObject;
        if(val_2 != null)
        {
                return val_2.activeSelf;
        }
        
        return val_2.activeSelf;
    }
    private void Awake()
    {
        SelectionControlMode.Instance = this;
    }
    public void SelectBtn()
    {
        this.gameObject.SetActive(value:  false);
        SettingsTabControls.丆丕丝丒不丙且丐丗.丒丒丌丙丒丏不丏世();
    }
    public void ResetGrid()
    {
        this.switchersGrid.enabled = false;
        this.switchersGrid.enabled = true;
    }
    public void SetSimple()
    {
        this.simpleSwitcher.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  true);
        this.advancedSwitcher.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  false);
    }
    public void SetAdvanced()
    {
        this.simpleSwitcher.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  false);
        this.advancedSwitcher.丄丑七丘丁且丞丙专(丙业与丙丗丝不丈东:  true);
    }
    public void SetOnlyAdvancedStyle()
    {
        this.onlyAdvancedHeader.SetActive(value:  true);
        this.onlyAdvancedDescription.SetActive(value:  true);
        this.onlyAdvancedResumeButton.SetActive(value:  true);
        this.onlyAdvancedModeInfo.SetActive(value:  false);
        this.simpleAndAdvancedHeader.SetActive(value:  false);
        this.simpleAndAdvancedDescription.SetActive(value:  false);
        this.simpleAndAdvancedSelectButton.SetActive(value:  false);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  1.6f, y:  1.6f);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.shootIconAdvanced.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.hintAdvanced.SetActive(value:  false);
        this.advancedCheckBox.SetActive(value:  false);
        this.advancedExtraLabel.SetActive(value:  true);
        this.SetSimpleActive(三丟东丕丄丄下下丑:  false);
        this.SetAdvancedActive(三丟东丕丄丄下下丑:  true);
        this.SetAdvanced();
        this.ResetGrid();
    }
    public void SetSimpleAndAdvancedStyle()
    {
        this.onlyAdvancedHeader.SetActive(value:  false);
        this.onlyAdvancedDescription.SetActive(value:  false);
        this.onlyAdvancedResumeButton.SetActive(value:  false);
        this.onlyAdvancedModeInfo.SetActive(value:  true);
        this.simpleAndAdvancedHeader.SetActive(value:  true);
        this.simpleAndAdvancedDescription.SetActive(value:  true);
        this.simpleAndAdvancedSelectButton.SetActive(value:  true);
        this.alphaTween.PlayForward();
        this.advancedCheckBox.SetActive(value:  true);
        this.advancedExtraLabel.SetActive(value:  false);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.8f, y:  0.8f);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
        this.shootIconAdvanced.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.hintAdvanced.SetActive(value:  true);
        this.SetSimpleActive(三丟东丕丄丄下下丑:  true);
        this.SetAdvancedActive(三丟东丕丄丄下下丑:  true);
        this.SetSimple();
        this.ResetGrid();
    }
    public void SetSimpleActive(bool 三丟东丕丄丄下下丑)
    {
        this.simpleSwitcher.gameObject.SetActive(value:  三丟东丕丄丄下下丑);
    }
    public void SetAdvancedActive(bool 三丟东丕丄丄下下丑)
    {
        this.advancedSwitcher.gameObject.SetActive(value:  三丟东丕丄丄下下丑);
    }
    public SelectionControlMode()
    {
    
    }

}
