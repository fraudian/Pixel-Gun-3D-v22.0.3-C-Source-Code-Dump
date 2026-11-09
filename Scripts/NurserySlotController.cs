using UnityEngine;
public class NurserySlotController : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<ShopCategoryButton> buttons;
    private int 丁丐丄丅丈丗不万丞;
    private PGCompany.且丟一七万东丁三上<string> 东丛七丟丑业万丄丄;
    private System.Collections.Generic.List<UILabel> petName;
    private static NurserySlotController <丞丟丅专丐一丌丐且>k__BackingField;
    
    // Properties
    internal static NurserySlotController 丌丛丟丁丏丌且丛且 { get; set; }
    
    // Methods
    internal static NurserySlotController 且丕丈丙丛不业丂丗()
    {
        return (NurserySlotController)NurserySlotController.<丞丟丅专丐一丌丐且>k__BackingField;
    }
    private static void 丂上丐丂丆丁丒三丐(NurserySlotController 丙业与丙丗丝不丈东)
    {
        NurserySlotController.<丞丟丅专丐一丌丐且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public int GetLastChosenSlot()
    {
        return (int)this.丁丐丄丅丈丗不万丞;
    }
    private void Awake()
    {
        NurserySlotController.<丞丟丅专丐一丌丐且>k__BackingField = this;
    }
    private void OnEnable()
    {
        System.Collections.Generic.List<ShopCategoryButton> val_13;
        var val_14;
        this.UpdateSlots();
        if(this.buttons == null)
        {
                return;
        }
        
        if(this.buttons.Count < 1)
        {
                return;
        }
        
        var val_13 = 0;
        label_14:
        val_13 = this.buttons;
        if(val_13 >= val_13.Count)
        {
            goto label_4;
        }
        
        if((this.东丛七丟丑业万丄丄 != null) && ((this.东丛七丟丑业万丄丄.ContainsKey(下上丐丆丝丟丝丒不:  0)) != false))
        {
                val_13 = (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.东丛七丟丑业万丄丄.Item[0]))) & 1;
        }
        else
        {
                val_13 = 0;
        }
        
        this.buttons.Item[0].GetComponent<UIToggle>().Set(丏业丟一东丂东丘丛:  false);
        val_13 = val_13 + 1;
        if(val_13 == 0)
        {
            goto label_14;
        }
        
        label_4:
        if(this.东丛七丟丑业万丄丄 != null)
        {
                if(this.东丛七丟丑业万丄丄.Count != 0)
        {
                return;
        }
        
        }
        
        val_14 = 0;
        goto label_17;
        label_22:
        this.buttons.Item[0].GetComponent<UIToggle>().Set(丏业丟一东丂东丘丛:  (val_14 == 0) ? 1 : 0);
        val_14 = 1;
        label_17:
        val_13 = this.buttons;
        if(val_14 < val_13.Count)
        {
            goto label_22;
        }
    
    }
    public void UpdateSlots()
    {
        PGCompany.且丟一七万东丁三上<System.String> val_5 = this.东丛七丟丑业万丄丄;
        if(val_5 == null)
        {
                PGCompany.且丟一七万东丁三上<System.String> val_1 = null;
            val_5 = val_1;
            val_1 = new PGCompany.且丟一七万东丁三上<System.String>();
            this.东丛七丟丑业万丄丄 = val_5;
        }
        
        val_1.Clear();
        if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance) == 0)
        {
                return;
        }
        
        var val_5 = 0;
        do
        {
            val_5 = val_5 + 1;
        }
        while(val_5 < this.buttons.Count);
    
    }
    public void UpdateIcon(int 与丄不丌一世东丁丙, string 丞丅上丏丂且下丅与)
    {
    
    }
    public void EquipPet()
    {
    
    }
    private void 且丗丆不三不不丅丗()
    {
    
    }
    private void 世丝且万丈丝丁丁丕(int 与丄不丌一世东丁丙)
    {
        if(this.东丛七丟丑业万丄丄 == null)
        {
                return;
        }
        
        NurseryGuiController val_2 = NurseryGuiController.且丕丈丙丛不业丂丗();
        NurseryGuiController.且丕丈丙丛不业丂丗().不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_2.且丛丌丌七丈丝丒丈.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  168), 丕丝丟下丗丛一丕业:  false);
    }
    public void UnequipPet()
    {
        this.世丝且万丈丝丁丁丕(与丄不丌一世东丁丙:  0);
    }
    public void OnPetsSlotClick(int 与丄不丌一世东丁丙)
    {
    
    }
    public NurserySlotController()
    {
    
    }

}
