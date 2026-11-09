using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丛丝丈丑丙丒丆丁业 : 丆一丆丟丅丁丗丛丆
    {
        // Properties
        internal override int 丗丅世丘丌丈丛丝丌 { get; }
        
        // Methods
        internal 丛丝丈丑丙丒丆丁业(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
        
        }
        internal override void 丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丘丑丒丄丌下丝丙丑(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
            if(丗丛不丁丑专专丂且 != null)
            {
                    if(丗丛不丁丑专专丂且.丒上世上丒丒且丗三() != false)
            {
                    if(丗丛不丁丑专专丂且.丒丟且一丟不业丕丆() == false)
            {
                goto label_2;
            }
            
            }
            
            }
            
            mem[1152921559994781376] = 0;
            label_2:
            if(W21 == 1)
            {
                    return;
            }
            
            if(丗丛不丁丑专专丂且 != null)
            {
                    if(W21 == 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
            {
                    return;
            }
            
            }
            
            mem[1152921559994781376] = 0;
        }
        internal override void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            var val_9;
            if(W8 == 0)
            {
                    return;
            }
            
            丘上上万专丙万丟丑 val_1 = this.业丑丁丆丕丆丂丅万();
            if(val_1.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if((((丗丛不丁丑专专丂且.东丐三一业与丘丂丕() == false) || (丗丛不丁丑专专丂且 == null)) || (丗丛不丁丑专专丂且.丒上世上丒丒且丗三() == false)) || (丗丛不丁丑专专丂且.丒丟且一丟不业丕丆() == true))
            {
                goto label_11;
            }
            
            if(val_1 != 1)
            {
                    if(val_1 < 丗丛不丁丑专专丂且.丙东专丂世丈丏丁丂())
            {
                goto label_11;
            }
            
            }
            
            if(val_1 != 1)
            {
                    if(val_1 != 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
            {
                goto label_11;
            }
            
            }
            
            if(W8 == 0)
            {
                goto label_12;
            }
            
            var val_8 = W8 + 1;
            mem[1152921559994922048] = val_8;
            if(val_8 >= 0)
            {
                goto label_13;
            }
            
            goto label_14;
            label_11:
            mem[1152921559994922048] = 0;
            return;
            label_12:
            val_9 = 1;
            label_13:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_14:
            this.丐三上丏丈丕且且丞();
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
    
    }

}
