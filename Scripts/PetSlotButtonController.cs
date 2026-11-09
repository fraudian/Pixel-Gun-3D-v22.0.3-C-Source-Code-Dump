using UnityEngine;
public class PetSlotButtonController : MonoBehaviour
{
    // Fields
    private Rilisoft.ButtonHandler btnClot;
    private NurserySlotController controller;
    private UILabel petNameLabel;
    private int slotNumber;
    
    // Methods
    public void SetPetName(string 上丒业丗专丐七东东)
    {
        if(this.petNameLabel == 0)
        {
                return;
        }
        
        this.petNameLabel.text = 上丒业丗专丐七东东;
    }
    private void OnEnable()
    {
        this.btnClot.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void PetSlotButtonController::OnSlotClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.btnClot.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void PetSlotButtonController::OnSlotClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public void OnSlotClick(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.controller == 0)
        {
                return;
        }
        
        if(this.btnClot == 0)
        {
                return;
        }
        
        this.controller.OnPetsSlotClick(与丄不丌一世东丁丙:  this.slotNumber);
    }
    public PetSlotButtonController()
    {
    
    }

}
