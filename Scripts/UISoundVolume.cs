using UnityEngine;
public class UISoundVolume : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UISlider val_1 = this.GetComponent<UISlider>();
        float val_2 = 不丌丂丁丄一与丆丙.上丘丗丒一丟上且丗();
        if(val_1 != null)
        {
                val_1.value = val_2;
            EventDelegate val_4 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_1, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UISoundVolume::万东丁业丒七丗丝丘()));
            return;
        }
        
        0.value = val_2;
    }
    private void 万东丁业丒七丗丝丘()
    {
        不丌丂丁丄一与丆丙.丛丕丕且丞上丆丏丁(丙业与丙丗丝不丈东:  UIProgressBar.current.value);
    }
    public UISoundVolume()
    {
    
    }

}
