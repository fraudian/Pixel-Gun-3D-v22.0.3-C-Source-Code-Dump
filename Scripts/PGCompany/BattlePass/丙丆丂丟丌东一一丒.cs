using UnityEngine;

namespace PGCompany.BattlePass
{
    internal sealed class 丙丆丂丟丌东一一丒 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private bool 丝丌专丞丆丁丞丌丂;
        
        // Methods
        internal 丙丆丂丟丌东一一丒(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            goto typeof(PGCompany.BattlePass.丙丆丂丟丌东一一丒).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Progress.下丁下丂七丆丙七一.丈且丆下丘下丗丈上(丙业与丙丗丝不丈东:  new System.Action<丒上丟与三业与不东>(object:  this, method:  System.Void PGCompany.BattlePass.丙丆丂丟丌东一一丒::丞万丑世丒丟上丑专(Progress.下丁下丂七丆丙七一.丒上丟与三业与不东 专丒丌丆下丐丞丟丞)));
            Progress.下丁下丂七丆丙七一.丈七丞七下与丄三且(丙业与丙丗丝不丈东:  new System.Action<丒上丟与三业与不东>(object:  this, method:  System.Void PGCompany.BattlePass.丙丆丂丟丌东一一丒::丑丆丌东丅丗专丏三(Progress.下丁下丂七丆丙七一.丒上丟与三业与不东 专丒丌丆下丐丞丟丞)));
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            System.Object[] val_12;
            var val_13;
            val_12 = this;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            val_13 = 1;
            label_22:
            if(((-449907888) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.String.Equals(a:  val_4.m_stringLength, b:  "ToSpend", comparisonType:  5)) == false)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == true))
            {
                goto label_22;
            }
            
            this.丝丌专丞丆丁丞丌丂 = true;
            goto label_22;
            label_1:
            val_12 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionCurrency UpdateParams parameters == null", args:  val_12);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丞万丑世丒丟上丑专(Progress.下丁下丂七丆丙七一.丒上丟与三业与不东 专丒丌丆下丐丞丟丞)
        {
            string val_4;
            if(this.丝丌专丞丆丁丞丌丂 != false)
            {
                    return;
            }
            
            if(专丒丌丆下丐丞丟丞 != null)
            {
                    val_4 = 专丒丌丆下丐丞丟丞.东与三丌丅三丒丏业();
            }
            else
            {
                    val_4 = 0.东与三丌丅三丒丏业();
            }
            
            this.丅且业专丆七丑丐丏(丏丂不专上丘丂不丅:  val_4, 丙业与丙丗丝不丈东:  专丒丌丆下丐丞丟丞.丂丁丏一丙丛业且丌());
        }
        private void 丑丆丌东丅丗专丏三(Progress.下丁下丂七丆丙七一.丒上丟与三业与不东 专丒丌丆下丐丞丟丞)
        {
            string val_4;
            if(this.丝丌专丞丆丁丞丌丂 == false)
            {
                    return;
            }
            
            if(专丒丌丆下丐丞丟丞 != null)
            {
                    val_4 = 专丒丌丆下丐丞丟丞.东与三丌丅三丒丏业();
            }
            else
            {
                    val_4 = 0.东与三丌丅三丒丏业();
            }
            
            this.丅且业专丆七丑丐丏(丏丂不专上丘丂不丅:  val_4, 丙业与丙丗丝不丈东:  专丒丌丆下丐丞丟丞.丂丁丏一丙丛业且丌());
        }
        private void 丅且业专丆七丑丐丏(string 丏丂不专上丘丂不丅, int 丙业与丙丗丝不丈东)
        {
            int val_9;
            var val_10;
            val_9 = 丙业与丙丗丝不丈东;
            val_10 = 丏丂不专上丘丂不丅;
            if((val_10.Equals(value:  "EventCurrency")) == false)
            {
                    return;
            }
            
            val_10 = this.业丑丁丆丕丆丂丅万();
            if(val_10.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if(val_9 >= 1)
            {
                    val_10 = this.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟();
                if((val_10 + val_9) > )
            {
                    val_10 = this.业丑丁丆丕丆丂丅万();
                val_9 =  - val_10.且专丂丐丟一不丌丟();
            }
            
                this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  val_9, 丂丟丄一丕丈丛丈东:  true);
            }
            
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Progress.下丁下丂七丆丙七一.一丁七业丘丙丑丑丟(丙业与丙丗丝不丈东:  new System.Action<丒上丟与三业与不东>(object:  this, method:  System.Void PGCompany.BattlePass.丙丆丂丟丌东一一丒::丞万丑世丒丟上丑专(Progress.下丁下丂七丆丙七一.丒上丟与三业与不东 专丒丌丆下丐丞丟丞)));
            Progress.下丁下丂七丆丙七一.三丟七丏世专丏业丛(丙业与丙丗丝不丈东:  new System.Action<丒上丟与三业与不东>(object:  this, method:  System.Void PGCompany.BattlePass.丙丆丂丟丌东一一丒::丑丆丌东丅丗专丏三(Progress.下丁下丂七丆丙七一.丒上丟与三业与不东 专丒丌丆下丐丞丟丞)));
        }
    
    }

}
