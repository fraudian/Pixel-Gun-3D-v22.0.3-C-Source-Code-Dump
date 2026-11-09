using UnityEngine;

namespace PGCompany
{
    internal sealed class 丂与丏丄丕专东丄不 : 丄丗丕下丗丝七丝丒
    {
        // Methods
        public 丂与丏丄丕专东丄不(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
        
        }
        internal override int 丂万丞与丈丙丅丝七()
        {
            PGCompany.与丐业一丂丗与七丟 val_4 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丐东业专丑丘丑丗<PGCompany.与丐业一丂丗与七丟>(丟丟丄专上丟丁丐丝:  this.下三下东业丘且丟业().业上丙丞丐丄丆丅七());
            if(val_4 == null)
            {
                    return (int)val_4;
            }
            
            return val_4.上专东且丛不上丕丒();
        }
        internal override void 丒丏丝业丐丞三丏专(int 丅专与丒丈丗丒丘丌)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = 丅专与丒丈丗丒丘丌;
            if(this >= val_7)
            {
                    return;
            }
            
            val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.与丐业一丂丗与七丟>(且下丕七丙丗丄不七:  1);
            if(val_7 == null)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            丌丅且丗七丘丅丛丑.丒下业下下丑下丆与(丅专与丒丈丗丒丘丌:  丌丅且丗七丘丅丛丑.丏一丘丐丌丛三与丛, 丟丗且东万丅丝丐七:  1);
            val_9 = null;
            val_9 = null;
            val_10 = 0;
            if( != 0)
            {
                    val_11 = ((OnlineModeController.__il2cppRuntimeField_typeHierarchy + (FortDefenceController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? GameController.onlineMode : 0 + 512.丒业丈不丈丘丛丘东()) + 1;
            }
            else
            {
                    val_11 = 0;
            }
            
            PGCompany.丐丁七一丒三东万丌.丁丆丏上丁丏万上丆(丟丟丄专上丟丁丐丝:  val_7.业上丙丞丐丄丆丅七(), 丟上业丛丂丕丐丒世:  0);
        }
        internal override bool 丅丘丄业丕丄一丁万()
        {
            return false;
        }
        internal override void 专且丙丂丙丙丘丂上(bool 丙业与丙丗丝不丈东)
        {
        
        }
        internal override bool 丗万丈丅上丛东世上()
        {
            PGCompany.与丐业一丂丗与七丟 val_4 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丐东业专丑丘丑丗<PGCompany.与丐业一丂丗与七丟>(丟丟丄专上丟丁丐丝:  this.下三下东业丘且丟业().业上丙丞丐丄丆丅七());
            if(val_4 == null)
            {
                    return (bool)(val_4.上专东且丛不上丕丒() >= this.丁丝丞与丟与丟丌三()) ? 1 : 0;
            }
            
            this = this.下三下东业丘且丟业();
            return (bool)(val_4.上专东且丛不上丕丒() >= this.丁丝丞与丟与丟丌三()) ? 1 : 0;
        }
        internal override void 三七万不七下不丏万(bool 丙业与丙丗丝不丈东)
        {
        
        }
        internal override bool 世三丅不丄丂丒丕上()
        {
            return false;
        }
        internal override void 不上丕不丞业一丗丂(bool 丙业与丙丗丝不丈东)
        {
        
        }
        internal override void 且七丙丄丘一丄上不()
        {
        
        }
    
    }

}
