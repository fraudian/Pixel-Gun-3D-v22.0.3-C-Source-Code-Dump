using UnityEngine;

namespace I2.Loc
{
    public class SetLanguage : MonoBehaviour
    {
        // Fields
        public string _Language;
        
        // Methods
        private void OnClick()
        {
            this.ApplyLanguage();
        }
        public void ApplyLanguage()
        {
            if((I2.Loc.丗丈下丕丟丟丙七丞.丙丌七七丟丂且下丁(不世丏东丄丟世与不:  this._Language, 丒一上业三丛丐专丘:  false)) == false)
            {
                    return;
            }
            
            I2.Loc.丗丈下丕丟丟丙七丞.下且丘丒丗丑不丕丌(丙业与丙丗丝不丈东:  this._Language);
        }
        public SetLanguage()
        {
        
        }
    
    }

}
