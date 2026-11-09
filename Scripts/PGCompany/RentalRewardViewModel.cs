using UnityEngine;

namespace PGCompany
{
    internal sealed class RentalRewardViewModel : MonoBehaviour
    {
        // Fields
        private UITextureMasked _icon;
        private UILabel _weaponLabel;
        private 三丅丁丗丗丝丂万且 世丏丞丕专业丅丙丛;
        
        // Properties
        internal UITextureMasked 丛丙丂丝不丏上东不 { get; }
        internal UILabel 世世丙丟丛三丗丌丝 { get; }
        internal 三丅丁丗丗丝丂万且 丄三丅丑三一丅丄专 { get; }
        
        // Methods
        internal UITextureMasked 丑一丆丑且丟上业丛()
        {
            return (UITextureMasked)this._icon;
        }
        internal UILabel 丙丟与丘丄丒丙下丒()
        {
            return (UILabel)this._weaponLabel;
        }
        internal 三丅丁丗丗丝丂万且 七丛丐七丆丆一丅七()
        {
            return (三丅丁丗丗丝丂万且)this.世丏丞丕专业丅丙丛;
        }
        internal void 且丙七丄丝丄丅一丑(三丅丁丗丗丝丂万且 丑业丅东丆七丂丐丌)
        {
            if(丑业丅东丆七丂丐丌 != null)
            {
                    this.业丄丂丙丁丞不丟丄(丑业丅东丆七丂丐丌:  丑业丅东丆七丂丐丌);
                return;
            }
            
            this.世丏丞丕专业丅丙丛 = 0;
            this._weaponLabel.text = System.String.alignConst;
        }
        private void 业丄丂丙丁丞不丟丄(三丅丁丗丗丝丂万且 丑业丅东丆七丂丐丌)
        {
            string val_7;
            this.世丏丞丕专业丅丙丛 = 丑业丅东丆七丂丐丌;
            if(丑业丅东丆七丂丐丌 != null)
            {
                    val_7 = 丑业丅东丆七丂丐丌.与不丞丑七丘丁丂丛();
            }
            else
            {
                    val_7 = 0.与不丞丑七丘丁丂丛();
            }
            
            UnityEngine.Texture val_4 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_7, 七丆丒与丗丌丄且丂:  丑业丅东丆七丂丐丌.丒万丕七专不丏丞丌(), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            this._weaponLabel.text = 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  丑业丅东丆七丂丐丌.与不丞丑七丘丁丂丛());
        }
        public RentalRewardViewModel()
        {
        
        }
    
    }

}
