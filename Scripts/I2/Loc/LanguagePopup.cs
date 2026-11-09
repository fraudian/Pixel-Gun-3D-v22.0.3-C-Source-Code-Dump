using UnityEngine;

namespace I2.Loc
{
    public class LanguagePopup : MonoBehaviour
    {
        // Fields
        public I2.Loc.LanguageSource Source;
        
        // Methods
        private void Start()
        {
            System.Collections.Generic.List<System.String> val_2 = 0.GetLanguages();
            if((this.GetComponent<UIPopupList>()) != null)
            {
                    val_1.items = val_2;
            }
            else
            {
                    mem[80] = val_2;
            }
            
            EventDelegate val_4 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_1.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  public System.Void I2.Loc.LanguagePopup::OnValueChange()));
            string val_5 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
            goto typeof(UIPopupList).__il2cppRuntimeField_178;
        }
        public void OnValueChange()
        {
            null = null;
            丟丏下丂七三下丗丕.下且丘丒丗丑不丕丌(丙业与丙丗丝不丈东:  UIPopupList.专三丆三与下丕丆不);
        }
        public LanguagePopup()
        {
        
        }
    
    }

}
