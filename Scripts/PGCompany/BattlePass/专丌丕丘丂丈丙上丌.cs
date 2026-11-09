using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 专丌丕丘丂丈丙上丌 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private PGCompany.BattlePass.业专丒丟且丝七丑丁 丁丅丈丌丟世丗丗丟;
        
        // Properties
        internal PGCompany.BattlePass.业专丒丟且丝七丑丁 丝与不丘丂丁与上且 { get; }
        
        // Methods
        internal 专丌丕丘丂丈丙上丌(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.丁丅丈丌丟世丗丗丟 = 0;
            goto typeof(PGCompany.BattlePass.专丌丕丘丂丈丙上丌).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.专丒七世一丘丌万七(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.专丌丕丘丂丈丙上丌::丄不丟丁丁业丈丞万(丘上上万专丙万丟丑 上丕丈丞丌丘丅不与)));
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.丅万七世东丂下丙世(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.专丌丕丘丂丈丙上丌::丄不丟丁丁业丈丞万(丘上上万专丙万丟丑 上丕丈丞丌丘丅不与)));
        }
        internal PGCompany.BattlePass.业专丒丟且丝七丑丁 丏东丝丟丗丞丑上业()
        {
            return (PGCompany.BattlePass.业专丒丟且丝七丑丁)this.丁丅丈丌丟世丗丗丟;
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            System.Object[] val_14;
            var val_15;
            val_14 = this;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            val_15 = 1;
            label_29:
            if(((-454442736) & 1) == 0)
            {
                goto label_2;
            }
            
            if((((val_3.丐丏七丌丕丗业且上() == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.String.Equals(a:  val_4.m_stringLength, b:  "openType", comparisonType:  5)) == false)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_29;
            }
            
            this.丁丅丈丌丟世丗丗丟 = null;
            goto label_29;
            label_1:
            val_14 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionWin UpdateParams parameters == null", args:  val_14);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丄不丟丁丁业丈丞万(丘上上万专丙万丟丑 上丕丈丞丌丘丅不与)
        {
            丘上上万专丙万丟丑 val_9 = 上丕丈丞丌丘丅不与;
            .上丕丈丞丌丘丅不与 = val_9;
            if(null == 0)
            {
                    return;
            }
            
            val_9 = this.业丑丁丆丕丆丂丅万();
            if(val_9.世丑丐丅丆丂丘不丁() != false)
            {
                    return;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_7 = System.Linq.Enumerable.SingleOrDefault<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  new 专丌丕丘丂丈丙上丌.丘丞上世丗丘丏丐东(), method:  System.Boolean 专丌丕丘丂丈丙上丌.丘丞上世丗丘丏丐东::三丌丂且丑与业世丞(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙)));
            if(this.丁丅丈丌丟世丗丗丟 != 1)
            {
                    if(val_7 == null)
            {
                    return;
            }
            
                if((专丌丕丘丂丈丙上丌.丘丞上世丗丘丏丐东)[1152921559987238656].上丕丈丞丌丘丅不与 == null)
            {
                    return;
            }
            
                if(this.丁丅丈丌丟世丗丗丟 != val_7.三丝丄丈丆丂专丄东())
            {
                    return;
            }
            
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            PGCompany.BattlePass.丘丄上丏不丝不丐丐.专丒七世一丘丌万七(丙业与丙丗丝不丈东:  new System.Action<丘上上万专丙万丟丑>(object:  this, method:  System.Void PGCompany.BattlePass.专丌丕丘丂丈丙上丌::丄不丟丁丁业丈丞万(丘上上万专丙万丟丑 上丕丈丞丌丘丅不与)));
        }
    
    }

}
