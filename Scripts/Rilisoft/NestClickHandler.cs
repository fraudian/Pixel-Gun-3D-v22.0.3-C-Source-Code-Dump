using UnityEngine;

namespace Rilisoft
{
    public class NestClickHandler : MonoBehaviour
    {
        // Methods
        private void OnClick()
        {
            UnityEngine.Object val_12;
            if(Rilisoft.Nest.丆丈一丌丒丅丌丌丝() == false)
            {
                    return;
            }
            
            val_12 = Rilisoft.Nest.丑七不且上丗丁一世();
            if(val_12 == 0)
            {
                    return;
            }
            
            val_12 = Rilisoft.Nest.丑七不且上丗丁一世();
            if(val_12.TryGetEgg() == 0)
            {
                    return;
            }
            
            PGCompany.丌不丞丐世丞三丘丌 val_6 = null;
            val_12 = val_6;
            val_6 = new PGCompany.丌不丞丐世丞三丘丌();
            if(val_12 != null)
            {
                    .Type = 1;
            }
            else
            {
                    mem[16] = 1;
            }
            
            .ShopCategory = 30000;
            if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_6)) == null)
            {
                    return;
            }
            
            val_12 = ???;
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        public NestClickHandler()
        {
        
        }
    
    }

}
