using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 下与不丂丁丗丙专丑 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private int 丙丐一丕丗万丁下一;
        
        // Properties
        internal override int 丁丘丗丐万丑丗丈丛 { get; }
        internal override int 丗丅世丘丌丈丛丝丌 { get; }
        
        // Methods
        internal 下与不丂丁丗丙专丑(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.丙丐一丕丗万丁下一 = 1;
            goto typeof(PGCompany.BattlePass.下与不丂丁丗丙专丑).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            RatingSystem.丘世一丂丝世丏丆一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.下与不丂丁丗丙专丑::丑三一丛丈专丈专丛()));
            Rilisoft.丐丌丝七下丈丒丅丗.丛丑丌丅东上丘丌与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.下与不丂丁丗丙专丑::丑三一丛丈专丈专丛()));
        }
        internal override int 丐丑七丐一丝七上七()
        {
            return (int)this.丙丐一丕丗万丁下一;
        }
        internal override int 丛三丙上丞丐三丘丛()
        {
            int val_13;
            int val_14;
            val_13 = this;
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == false)
            {
                goto label_2;
            }
            
            val_13 = ???;
            goto typeof(PGCompany.BattlePass.下与不丂丁丗丙专丑).__il2cppRuntimeField_168;
            label_2:
            if((val_13 + 16) != 0)
            {
                    if(RatingSystem.与一丅丝不丈业与丙() != 0)
            {
                goto label_8;
            }
            
            }
            
            val_14 = 0;
            return (int)UnityEngine.Mathf.Min(a:  val_14 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅(), b:  val_13 = val_13);
            label_8:
            return (int)UnityEngine.Mathf.Min(a:  val_14, b:  val_13);
        }
        private void 丑三一丛丈专丈专丛()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            this.下三丐丄不丄万丗东();
            if(RatingSystem.与一丅丝不丈业与丙() == 0)
            {
                    return;
            }
            
            if(RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅() < this.丙丐一丕丗万丁下一)
            {
                    return;
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            System.Object[] val_15;
            var val_16;
            val_15 = this;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            val_16 = 1;
            label_27:
            if(((-420655344) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(((((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.String.Equals(a:  val_4.m_stringLength, b:  "wave_num", comparisonType:  5)) == false)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.Int32.TryParse(s:  val_4, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) == false))
            {
                goto label_27;
            }
            
            this.丙丐一丕丗万丁下一 = 0;
            goto label_27;
            label_1:
            val_15 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionTrophies UpdateParams parameters == null", args:  val_15);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丐丌丝七下丈丒丅丗.丅丗丟丟丘丆专一东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.下与不丂丁丗丙专丑::丑三一丛丈专丈专丛()));
            RatingSystem.不上丗东丞不丌丐世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.下与不丂丁丗丙专丑::丑三一丛丈专丈专丛()));
        }
        internal override void 丘丂丕丈且丆与丄丕()
        {
            this.丑三一丛丈专丈专丛();
        }
    
    }

}
