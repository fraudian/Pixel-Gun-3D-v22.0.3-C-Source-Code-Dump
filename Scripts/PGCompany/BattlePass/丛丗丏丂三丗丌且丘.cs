using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丛丗丏丂三丗丌且丘 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private int 且丐丑丕丘不万丁丂;
        private string 丏丂不专上丘丂不丅;
        private bool 丝丌专丞丆丁丞丌丂;
        
        // Methods
        internal 丛丗丏丂三丗丌且丘(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.且丐丑丕丘不万丁丂 = 0;
            this.丏丂不专上丘丂不丅 = System.String.alignConst;
            goto typeof(PGCompany.BattlePass.丛丗丏丂三丗丌且丘).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Progress.丑丅专一业丙丝丄丁.丆丄世东东丝丝一世(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.BattlePass.丛丗丏丂三丗丌且丘::且丄不丄不丕业三丘(string 且东丟丈丈丗丈丞上)));
        }
        internal override void 丘丂丕丈且丆与丄丕()
        {
            this.且丐丑丕丘不万丁丂 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌();
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            System.Object[] val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            val_24 = this;
            int val_9 = 0;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            label_62:
            if(((-450662480) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_62;
            }
            
            val_25 = null;
            val_25 = null;
            if((((System.String.Equals(a:  val_4.m_stringLength, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, comparisonType:  5)) != false) && ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) != true)) && (0 >= 1))
            {
                    if(((System.Int32.TryParse(s:  val_4.m_stringLength, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_9)) ^ 1) != true)
            {
                    val_26 = null;
                val_26 = null;
                this.丏丂不专上丘丂不丅 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            }
            
            }
            
            val_27 = null;
            val_27 = null;
            if((System.String.Equals(a:  val_4.m_stringLength, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, comparisonType:  5)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == false)
            {
                goto label_24;
            }
            
            }
            
            label_39:
            if(((System.String.Equals(a:  val_4.m_stringLength, b:  "ToSpend", comparisonType:  5)) == false) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == true))
            {
                goto label_62;
            }
            
            this.丝丌专丞丆丁丞丌丂 = true;
            goto label_62;
            label_24:
            if(((0 < 1) || (((System.Int32.TryParse(s:  val_4.m_stringLength, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  val_9)) ^ 1) == true)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丏丂不专上丘丂不丅)) == false))
            {
                goto label_39;
            }
            
            val_28 = null;
            val_28 = null;
            this.丏丂不专上丘丂不丅 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            goto label_39;
            label_1:
            val_24 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionCurrency UpdateParams parameters == null", args:  val_24);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 且丄不丄不丕业三丘(string 且东丟丈丈丗丈丞上)
        {
            var val_13;
            string val_14;
            int val_15;
            val_13 = null;
            val_13 = null;
            val_14 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            if((且东丟丈丈丗丈丞上.Equals(value:  val_14)) == false)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.且丄丅上不与丟丗丒 == 0)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            int val_5 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌();
            val_15 = this.且丐丑丕丘不万丁丂;
            if(val_15 == 1)
            {
                    val_15 = val_5;
                this.且丐丑丕丘不万丁丂 = val_5;
            }
            
            int val_7 = (this.丝丌专丞丆丁丞丌丂 == true) ? (val_15) : (val_5);
            val_14 = val_7 - ((this.丝丌专丞丆丁丞丌丂 == true) ? (val_5) : (val_15));
            if(val_14 >= 1)
            {
                    val_7 = this.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟() + val_14;
                if(val_7 > )
            {
                    val_14 =  - this.业丑丁丆丕丆丂丅万().且专丂丐丟一不丌丟();
            }
            
                this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  val_14, 丂丟丄一丕丈丛丈东:  true);
            }
            
            this.且丐丑丕丘不万丁丂 = val_5;
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Progress.丑丅专一业丙丝丄丁.丒一世与三东世不丒(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.BattlePass.丛丗丏丂三丗丌且丘::且丄不丄不丕业三丘(string 且东丟丈丈丗丈丞上)));
        }
    
    }

}
