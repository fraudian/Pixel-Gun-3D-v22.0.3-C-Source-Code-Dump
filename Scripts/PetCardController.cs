using UnityEngine;
public class PetCardController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject bgCommon;
    private UnityEngine.GameObject bgEpic;
    private UnityEngine.GameObject bgLegendary;
    private UnityEngine.GameObject bgMythical;
    private UnityEngine.GameObject bgRare;
    private UnityEngine.GameObject bgUnCommon;
    private UILabel countLabel;
    private UILabel levelLabel;
    private UIBasicSprite sprite;
    private int <丙丆上丑丒丑丘与丆>k__BackingField;
    private System.Action<PetCardController> 丌不丂丌丁丛丆丟与;
    
    // Properties
    public int 丒丟世丆丟丞丌东下 { get; set; }
    
    // Methods
    public int get_SettedCount()
    {
        return (int)this.<丙丆上丑丒丑丘与丆>k__BackingField;
    }
    private void 与下丟丛一一丛丞丘(int 丙业与丙丗丝不丈东)
    {
        this.<丙丆上丑丒丑丘与丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void add_OnClicked(System.Action<PetCardController> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921538475613720);
    
    }
    public void remove_OnClicked(System.Action<PetCardController> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921538475750296);
    
    }
    public void SetupPetCard(string 世丐丗专丅三丝丑丆, int 丌丒丝东丌下丕丁丅)
    {
    
    }
    public void U_ShowInfo()
    {
    
    }
    public PetCardController()
    {
    
    }

}
