using UnityEngine;

namespace PGCompany
{
    internal sealed class 丁丙七丅专与三丝丙
    {
        // Fields
        private PGCompany.七丂专七业丏丟丗丕 丁丘丄丕下专东七不;
        
        // Methods
        internal 丁丙七丅专与三丝丙(PGCompany.七丂专七业丏丟丗丕 一丐丗丁丞丆丅丟丄)
        {
            this.丁丘丄丕下专东七不 = 一丐丗丁丞丆丅丟丄;
        }
        internal PGCompany.丂专丞丟丂与丄万丌 与丄丆丁丘东丝下七(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不, int 业万上丆丐丞且丒七)
        {
            var val_11;
            Rilisoft.七丕丟丏三丈一丄世 val_12;
            var val_13;
            val_12 = 上且丗一丏丏万丅丌;
            if(((this.丁丘丄丕下专东七不 != null) && (this.丁丘丄丕下专东七不.Common != null)) && ((this.丁丘丄丕下专东七不.Common.ContainsKey(key:  val_12)) != false))
            {
                    val_11 = this.丁丘丄丕下专东七不.Common.Item[val_12];
                if((val_11.ContainsKey(key:  丞丁丑丏丄丏七丂不)) != false)
            {
                    val_11 = this.丁丘丄丕下专东七不.Common.Item[val_12].Item[丞丁丑丏丄丏七丂不];
                if((val_11.ContainsKey(key:  业万上丆丐丞且丒七)) != false)
            {
                    val_12 = this.丁丘丄丕下专东七不.Common.Item[val_12];
                PGCompany.丂专丞丟丂与丄万丌 val_10 = null;
                val_13 = val_10;
                val_10 = new PGCompany.丂专丞丟丂与丄万丌(与不丕丆丈不丙丟丛:  val_12.Item[丞丁丑丏丄丏七丂不].Item[业万上丆丐丞且丒七]);
                return (PGCompany.丂专丞丟丂与丄万丌)val_13;
            }
            
            }
            
            }
            
            val_13 = 0;
            return (PGCompany.丂专丞丟丂与丄万丌)val_13;
        }
    
    }

}
