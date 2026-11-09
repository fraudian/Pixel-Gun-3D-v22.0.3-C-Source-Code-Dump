using UnityEngine;

namespace PGCompany.BattlePass
{
    internal sealed class 不丞丂丗上丙丈丟丑 : 丏七丁丌世丟丁丅丙
    {
        // Methods
        internal 不丞丂丗上丙丈丟丑(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            mem[1152921559999750352] = 0;
            mem[1152921559999750360] = 0;
            val_1 = new PGCompany.BattlePass.丘丄上丏不丝不丐丐(丕下一东丏丅丄不业:  下丝丘丁专丐丅丛丝);
            goto typeof(PGCompany.BattlePass.不丞丂丗上丙丈丟丑).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丁丛丟丁一与上丈丆(丙业与丙丗丝不丈东:  new System.EventHandler<ItemRarity>(object:  this, method:  System.Void PGCompany.BattlePass.不丞丂丗上丙丈丟丑::丙丌世丘丁丆丄丒七(object 不丟丗丏丛丕不丁丌, ItemRarity 丈下丑丆上丏丗丈专)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().不丄丛丏丂丛丞丕丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丛上三丌丄三下丅>(object:  this, method:  System.Void PGCompany.BattlePass.不丞丂丗上丙丈丟丑::丞一业丞与丟丐上不(object 不丟丗丏丛丕不丁丌, Rilisoft.与丛上三丌丄三下丅 东且丈业丘丂不业东)));
            this.丈丗丝丂丝丑上三丌();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().东丝三东丄丞丑且丒(丙业与丙丗丝不丈东:  new System.EventHandler<ItemRarity>(object:  this, method:  System.Void PGCompany.BattlePass.不丞丂丗上丙丈丟丑::丙丌世丘丁丆丄丒七(object 不丟丗丏丛丕不丁丌, ItemRarity 丈下丑丆上丏丗丈专)));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丆丅丘丝三丘七不丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丛上三丌丄三下丅>(object:  this, method:  System.Void PGCompany.BattlePass.不丞丂丗上丙丈丟丑::丞一业丞与丟丐上不(object 不丟丗丏丛丕不丁丌, Rilisoft.与丛上三丌丄三下丅 东且丈业丘丂不业东)));
            this.丞上丝丗七丁七丑丘();
        }
        private void 丞一业丞与丟丐上不(object 不丟丗丏丛丕不丁丌, Rilisoft.与丛上三丌丄三下丅 东且丈业丘丂不业东)
        {
            var val_8;
            if(W8 == 0)
            {
                    return;
            }
            
            val_8 = this.业丑丁丆丕丆丂丅万();
            if(val_8.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if(PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世() == null)
            {
                    return;
            }
            
            val_8 = PGCompany.GameplayLoop.丟三丐丒丏一上丙丐.丑七不且上丗丁一世();
            if((val_8.丆与与七丛丁七业丛(丁丅丈丌丟世丗丗丟:  2, 下丅丙一丂丗丅丝七:  东且丈业丘丂不业东.业上丙丞丐丄丆丅七())) == false)
            {
                    return;
            }
            
            if(东且丈业丘丂不业东.七东与丄丕丁丛世三() < W8)
            {
                    return;
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
        private void 丙丌世丘丁丆丄丒七(object 不丟丗丏丛丕不丁丌, ItemRarity 丈下丑丆上丏丗丈专)
        {
            if(W8 == 0)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if(W8 > 丈下丑丆上丏丗丈专)
            {
                    return;
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
    
    }

}
