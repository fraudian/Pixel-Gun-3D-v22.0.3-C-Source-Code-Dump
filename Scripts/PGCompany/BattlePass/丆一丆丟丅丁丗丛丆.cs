using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丆一丆丟丅丁丗丛丆 : 丏七丁丌世丟丁丅丙
    {
        // Fields
        internal int 专世专丟丝丌与丘上;
        private bool 丆七丄丆专丌丗丑丒;
        private bool 上丄上丛丄丏一世丕;
        
        // Properties
        internal override int 丗丅世丘丌丈丛丝丌 { get; }
        
        // Methods
        internal 丆一丆丟丅丁丗丛丆(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.专世专丟丝丌与丘上 = 0;
            goto typeof(PGCompany.BattlePass.丆一丆丟丅丁丗丛丆).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丝丅丐丘世丘丛下下(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.丆一丆丟丅丁丗丛丆::丝丘三丅不七丄丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.丈丗丝丂丝丑上三丌();
        }
        private void 丝丘三丅不七丄丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.上丄上丛丄丏一世丕 = true;
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            label_29:
            if(((-447537744) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_29;
            }
            
            if((System.String.Equals(a:  val_4.m_stringLength, b:  "no_damage", comparisonType:  5)) != false)
            {
                    this.丆七丄丆专丌丗丑丒 = true;
            }
            
            if((((System.String.Equals(a:  val_4.m_stringLength, b:  "wave_num", comparisonType:  5)) == false) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.Int32.TryParse(s:  val_4, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) == false))
            {
                goto label_29;
            }
            
            this.专世专丟丝丌与丘上 = 0;
            goto label_29;
            label_1:
            this = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionWin UpdateParams parameters == null", args:  this);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override int 丛三丙上丞丐三丘丛()
        {
            丘上上万专丙万丟丑 val_1 = this.业丑丁丆丕丆丂丅万();
            if(val_1 != null)
            {
                    if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() != false)
            {
                    return this.丐丑七丐一丝七上七();
            }
            
            }
            
            if(W8 != 0)
            {
                    return (int)val_1;
            }
            
            丘上上万专丙万丟丑 val_4 = this.业丑丁丆丕丆丂丅万();
            if(val_4 != null)
            {
                    return val_4.且专丂丐丟一不丌丟();
            }
            
            return val_4.且专丂丐丟一不丌丟();
        }
        internal override void 丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丘丑丒丄丌下丝丙丑(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
            if(丗丛不丁丑专专丂且 != null)
            {
                    if(丗丛不丁丑专专丂且.丒上世上丒丒且丗三() != true)
            {
                    if(丗丛不丁丑专专丂且.丒丟且一丟不业丕丆() == false)
            {
                goto label_2;
            }
            
            }
            
            }
            
            mem[1152921559994218688] = 0;
            label_2:
            if(this.丘丛丆丕且丂业世丌() != 1)
            {
                    if(丗丛不丁丑专专丂且 != null)
            {
                    if(this.丘丛丆丕且丂业世丌() == 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
            {
                goto label_5;
            }
            
            }
            
                mem[1152921559994218688] = 0;
            }
            
            label_5:
            this.上丄上丛丄丏一世丕 = false;
        }
        internal override void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            var val_11;
            if(this.丈丐丞丐上丑且丕万() == false)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if(丗丛不丁丑专专丂且.东丐三一业与丘丂丕() == false)
            {
                goto label_13;
            }
            
            if(this.丆七丄丆专丌丗丑丒 != false)
            {
                    bool val_11 = this.上丄上丛丄丏一世丕;
                if(val_11 == true)
            {
                    return;
            }
            
            }
            
            if(((丗丛不丁丑专专丂且 == null) || (丗丛不丁丑专专丂且.丒上世上丒丒且丗三() == true)) || (丗丛不丁丑专专丂且.丒丟且一丟不业丕丆() == true))
            {
                goto label_13;
            }
            
            if(this.专世专丟丝丌与丘上 != 1)
            {
                    if(this.专世专丟丝丌与丘上 < 丗丛不丁丑专专丂且.丙东专丂世丈丏丁丂())
            {
                goto label_13;
            }
            
            }
            
            if(this.丘丛丆丕且丂业世丌() != 1)
            {
                    if(this.丘丛丆丕且丂业世丌() != 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
            {
                goto label_13;
            }
            
            }
            
            if(val_11 == false)
            {
                goto label_14;
            }
            
            val_11 = val_11 + 1;
            mem[1152921559994375744] = val_11;
            if(val_11 >= 0)
            {
                goto label_15;
            }
            
            goto label_16;
            label_13:
            mem[1152921559994375744] = 0;
            return;
            label_14:
            val_11 = 1;
            label_15:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_16:
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().专与丐丁丂丕丑丛丂(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.丆一丆丟丅丁丗丛丆::丝丘三丅不七丄丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.丞上丝丗七丁七丑丘();
        }
    
    }

}
