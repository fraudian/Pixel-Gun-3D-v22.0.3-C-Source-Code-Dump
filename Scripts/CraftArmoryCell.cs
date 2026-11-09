using UnityEngine;
public class CraftArmoryCell : BaseArmoryCell
{
    // Fields
    public UnityEngine.GameObject craftedIndicator;
    public UITexture boltsIcon;
    public UITexture tapeIcon;
    public UITexture uniqueDetailIcon;
    public System.Collections.Generic.List<UILabel> boltsCount;
    public System.Collections.Generic.List<UILabel> tapeCount;
    public System.Collections.Generic.List<UILabel> uniqueDetailCount;
    private Rilisoft.丆丙丑不丌丆丆七上 <一丘一丐丝丘且丞丅>k__BackingField;
    
    // Properties
    private Rilisoft.丆丙丑不丌丆丆七上 一七且丗不丑丝且三 { get; set; }
    
    // Methods
    public void HandleMainItemClicked()
    {
        if(X20.value != false)
        {
                this.OnClick();
            return;
        }
        
        this.Set(丏业丟一东丂东丘丛:  true);
    }
    public void HandleFirstItemClicked()
    {
        string val_2 = System.String.Format(format:  "parts_{0}", arg0:  this.ItemId);
    }
    public void HandleSecondItemClicked()
    {
    
    }
    public void HandleThirdItemClicked()
    {
    
    }
    private void 丁丒丆丈下上世不丂(string 丁且丑东不丆丆丑东)
    {
    
    }
    public override void Setup(丙且上东下丏丏丟下 下丅丙一丂丗丅丝七, bool 丑丙丈三丞一丙丕丅, bool 丆丗一丛丌一与丅且, bool 丁三丌七丝丞丐专丐)
    {
        this.Setup(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丑丙丈三丞一丙丕丅:  丑丙丈三丞一丙丕丅, 丆丗一丛丌一与丅且:  丆丗一丛丌一与丅且, 与上七丈丁三丂世丟:  丁三丌七丝丞丐专丐);
        this.丞业与下丛万丁下丙();
    }
    public override void UnloadIcons()
    {
        this.UnloadIcons();
        if(this.uniqueDetailIcon == null)
        {
            
        }
    
    }
    protected override void OnClick()
    {
    
    }
    private Rilisoft.丆丙丑不丌丆丆七上 世丈丁业丛上丘丗丐()
    {
        return (Rilisoft.丆丙丑不丌丆丆七上)this.<一丘一丐丝丘且丞丅>k__BackingField;
    }
    private void 与丟与丂丞丒下七丐(Rilisoft.丆丙丑不丌丆丆七上 丙业与丙丗丝不丈东)
    {
        this.<一丘一丐丝丘且丞丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public CraftArmoryCell()
    {
    
    }

}
