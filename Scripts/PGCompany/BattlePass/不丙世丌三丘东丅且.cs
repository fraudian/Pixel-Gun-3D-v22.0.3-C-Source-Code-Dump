using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 不丙世丌三丘东丅且 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private string[] 丛东丅丛丅专丗一三;
        
        // Methods
        internal 不丙世丌三丘东丅且(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            string[] val_1 = new string[2];
            val_1[0] = "heart_of_volcano";
            val_1[1] = "ultimatum";
            this.丛东丅丛丅专丗一三 = val_1;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            WeaponManager.丂万丆与丕丈丒下丏(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且, 丕丑丙丑丙东丌丘丕, 丕丑丙丑丙东丌丘丕, System.Boolean>(object:  this, method:  System.Void PGCompany.BattlePass.不丙世丌三丘东丅且::丕东丁东丏丙丈丝上(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且, 丕丑丙丑丙东丌丘丕 上丙丟丙一丞业丅丅, 丕丑丙丑丙东丌丘丕 丂丗丈三丒世丆不丒, bool 不七不丆一万业丐丆)));
            Rilisoft.丗丄丙丁丌业丅丒丕.东丂丄丈丏万万七丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.不丙世丌三丘东丅且::丒专丘丂丒丕世三丂()));
        }
        private void 丕东丁东丏丙丈丝上(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且, 丕丑丙丑丙东丌丘丕 上丙丟丙一丞业丅丅, 丕丑丙丑丙东丌丘丕 丂丗丈三丒世丆不丒, bool 不七不丆一万业丐丆)
        {
            this.丒专丘丂丒丕世三丂();
        }
        private void 丒专丘丂丒丕世三丂()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Int32, 丕丑丙丑丙东丌丘丕> val_4 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丂丄丕世世专东丈丒();
            if(val_4 == null)
            {
                    return;
            }
            
            System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 丕丑丙丑丙东丌丘丕>, System.Boolean> val_5 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 丕丑丙丑丙东丌丘丕>, System.Boolean>(object:  this, method:  System.Boolean PGCompany.BattlePass.不丙世丌三丘东丅且::丅丘丄丑丒丌不丄三(System.Collections.Generic.KeyValuePair<int, 丕丑丙丑丙东丌丘丕> 丈丏万丄丒业丅丒一));
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.Int32, 丕丑丙丑丙东丌丘丕>>(source:  val_4, predicate:  null)) == false)
            {
                    return;
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丗丄丙丁丌业丅丒丕.七不丄不丝东丅业丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.不丙世丌三丘东丅且::丒专丘丂丒丕世三丂()));
            WeaponManager.丑丆丌业丕丝世与丟(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且, 丕丑丙丑丙东丌丘丕, 丕丑丙丑丙东丌丘丕, System.Boolean>(object:  this, method:  System.Void PGCompany.BattlePass.不丙世丌三丘东丅且::丕东丁东丏丙丈丝上(三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且, 丕丑丙丑丙东丌丘丕 上丙丟丙一丞业丅丅, 丕丑丙丑丙东丌丘丕 丂丗丈三丒世丆不丒, bool 不七不丆一万业丐丆)));
        }
        internal override void 丘丂丕丈且丆与丄丕()
        {
            this.丒专丘丂丒丕世三丂();
        }
        private bool 丅丘丄丑丒丌不丄三(System.Collections.Generic.KeyValuePair<int, 丕丑丙丑丙东丌丘丕> 丈丏万丄丒业丅丒一)
        {
            var val_8;
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  丈丏万丄丒业丅丒一.Value.丙东专丂世丈丏丁丂());
            if((val_2 != null) && ((System.Array.IndexOf<System.String>(array:  this.丛东丅丛丅专丗一三, value:  val_2.与不丞丑七丘丁丂丛())) == 1))
            {
                    if(丈丏万丄丒业丅丒一.Value.七东与丄丕丁丛世三() == 5)
            {
                    val_8 = val_2.东七与与不丅丙上上() ^ 1;
                return (bool)val_8 & 1;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8 & 1;
        }
    
    }

}
