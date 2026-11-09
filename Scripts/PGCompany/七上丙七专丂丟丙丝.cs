using UnityEngine;

namespace PGCompany
{
    internal class 七上丙七专丂丟丙丝 : 丏丒三上丗丌丄丛丄
    {
        // Properties
        protected override string 万丟丛且丑七世丁丞 { get; }
        
        // Methods
        protected override string 与丏不上丙七丐且丞()
        {
            return "feature.threechests";
        }
        internal override void 下丏且一三丐一丐不()
        {
            var val_8;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世() == null)
            {
                    return;
            }
            
            val_8 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_8.丏世丞丕丂丒七上业() == null)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler.丞丙丗丁丙丏七专丑(丟丟丄专上丟丁丐丝:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().业上丙丞丐丄丆丅七(), 业万与下且万丕丈丑:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, 丈丈不丒丗与丝不丗:  false);
        }
        public 七上丙七专丂丟丙丝()
        {
        
        }
    
    }

}
