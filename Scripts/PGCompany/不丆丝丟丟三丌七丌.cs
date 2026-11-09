using UnityEngine;

namespace PGCompany
{
    internal class 不丆丝丟丟三丌七丌 : 丏丒三上丗丌丄丛丄
    {
        // Properties
        protected override string 万丟丛且丑七世丁丞 { get; }
        
        // Methods
        protected override string 与丏不上丙七丐且丞()
        {
            return "feature.roulette";
        }
        internal override void 下丏且一三丐一丐不()
        {
            var val_11;
            string val_18;
            var val_19;
            var val_20;
            val_18 = this;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return;
            }
            
            val_19 = 1152921505459986432;
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世() == null)
            {
                    return;
            }
            
            val_20 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丘丒业东三丐与万丝();
            if(val_20 == null)
            {
                    val_20 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().不上丁丏且丙丞三丅();
                if(val_20 == null)
            {
                    return;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  null)) == true)
            {
                goto label_32;
            }
            
            val_19 = val_20.丄三丐丟丗丄丟上丞();
            List.Enumerator<T> val_9 = val_19.GetEnumerator();
            label_23:
            if(((-397314784) & 1) == 0)
            {
                goto label_18;
            }
            
            val_19 = val_11.丐丏七丌丕丗业且上();
            if((val_19 == null) || ((System.String.op_Equality(a:  val_19.丅三专且丈一丝丂丏(), b:  X26 + 24)) == false))
            {
                goto label_23;
            }
            
            Rilisoft.AbstractGameEventGui.丏世且丞世丂丈丗东 = val_19.业上丙丞丐丄丆丅七();
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_32:
            val_18 = val_20.业上丙丞丐丄丆丅七();
            Rilisoft.GameEventGuiHandler.丞丙丗丁丙丏七专丑(丟丟丄专上丟丁丐丝:  val_18, 业万与下且万丕丈丑:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, 丈丈不丒丗与丝不丗:  false);
        }
        public 不丆丝丟丟三丌七丌()
        {
        
        }
    
    }

}
