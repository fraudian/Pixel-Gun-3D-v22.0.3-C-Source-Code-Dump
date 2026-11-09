using UnityEngine;

namespace PGCompany
{
    internal class 万一丁且丘与丟丈丛 : 丄丗丕下丗丝七丝丒
    {
        // Methods
        internal 万一丁且丘与丟丈丛(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
        
        }
        internal override int 丂万丞与丈丙丅丝七()
        {
            var val_14;
            var val_15;
            var val_16;
            val_15 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(万不且且丛丆东丒业:  this.下三下东业丘且丟业());
            if(val_15 == null)
            {
                    return (int)val_14;
            }
            
            if(GameController.丑七不且上丗丁一世() != 0)
            {
                    GameController val_6 = GameController.丑七不且上丗丁一世();
                val_16 = val_6.丒七丐丂丗丞下与丟.七丘丅丆三不上七丆(丝丌不东丕丒与丒丅:  val_15.业上丙丞丐丄丆丅七());
            }
            else
            {
                    val_16 = 0;
            }
            
            val_15 = val_15.丏丞丌丁丄东丛下丑();
            丞丂丘丒丟丞丑下丄 val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_11 == null)
            {
                goto label_14;
            }
            
            if(val_15 != null)
            {
                goto label_16;
            }
            
            label_17:
            label_16:
            val_14 = (val_15.七丘丅丆三不上七丆(丄丒下业一不丈丝丘:  val_11.业丐丐三丕一丗丛丁())) + val_16;
            return (int)val_14;
            label_14:
            if(val_15 != null)
            {
                goto label_16;
            }
            
            goto label_17;
        }
        internal override void 丒丏丝业丐丞三丏专(int 丅专与丒丈丗丒丘丌)
        {
            int val_22;
            PGCompany.丒七丐丂丗丞下与丟 val_23;
            if(this >= 丅专与丒丈丗丒丘丌)
            {
                    return;
            }
            
            val_22 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            PGCompany.丁下丒丕丆下丂丆丌 val_3 = val_22.三丈下丗丐丝丅丑丑(万不且且丛丆东丒业:  this.下三下东业丘且丟业());
            if(val_3 == null)
            {
                    return;
            }
            
            val_22 = UnityEngine.Mathf.Max(a:  0, b:  丅专与丒丈丗丒丘丌 - this);
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
            {
                    Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.下丛丏丞与丂丕丑世(万不且且丛丆东丒业:  this.下三下东业丘且丟业(), 丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丞且丅三三东不丄且:  val_22);
            }
            
            if(GameController.丑七不且上丗丁一世() == 0)
            {
                    PGCompany.丒七丐丂丗丞下与丟 val_12 = null;
                val_23 = val_12;
                val_12 = new PGCompany.丒七丐丂丗丞下与丟();
                val_12.丌丌丄丂丟丐与丅且(丝丌不东丕丒与丒丅:  val_3.业上丙丞丐丄丆丅七(), 下丝丘丁专丐丅丛丝:  val_22).丈丂丑丒三一下丏七();
            }
            else
            {
                    GameController val_15 = GameController.丑七不且上丗丁一世();
                val_23 = val_15.丒七丐丂丗丞下与丟;
                PGCompany.丒七丐丂丗丞下与丟 val_17 = val_23.丌丌丄丂丟丐与丅且(丝丌不东丕丒与丒丅:  val_3.业上丙丞丐丄丆丅七(), 下丝丘丁专丐丅丛丝:  val_22);
            }
            
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0)
            {
                    return;
            }
            
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丝丕下世丒七世一(万不且且丛丆东丒业:  this.下三下东业丘且丟业(), 丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丞且丅三三东不丄且:  val_22);
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
            string val_8;
            PGCompany.丁下丒丕丆下丂丆丌 val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.三丈下丗丐丝丅丑丑(万不且且丛丆东丒业:  this.下三下东业丘且丟业());
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            丞丂丘丒丟丞丑下丄 val_6 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            val_8 = 0;
            if(val_6 == null)
            {
                    return System.String.op_Equality(a:  val_3.下丁丙一丄丈不不丁(), b:  val_8 = val_6.业丐丐三丕一丗丛丁());
            }
            
            return System.String.op_Equality(a:  val_3.下丁丙一丄丈不不丁(), b:  val_8);
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
