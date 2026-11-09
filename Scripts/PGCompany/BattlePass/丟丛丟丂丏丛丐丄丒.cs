using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丟丛丟丂丏丛丐丄丒 : 丆一丆丟丅丁丗丛丆
    {
        // Properties
        internal override int 丗丅世丘丌丈丛丝丌 { get; }
        
        // Methods
        internal 丟丛丟丂丏丛丐丄丒(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
        
        }
        internal override void 丘丑丒丄丌下丝丙丑(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            this.丘丑丒丄丌下丝丙丑(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
            if(丗丛不丁丑专专丂且 != null)
            {
                    if(丗丛不丁丑专专丂且.丒丟且一丟不业丕丆() != true)
            {
                    mem[1152921559995327680] = 0;
            }
            
                if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() == 20)
            {
                    return;
            }
            
                this = 1152921559995327680;
            }
            else
            {
                    mem[1152921559995327680] = 0;
            }
            
            mem[1152921559995327680] = 0;
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
        internal override void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
        {
            var val_7;
            if(W8 == 0)
            {
                    return;
            }
            
            丘上上万专丙万丟丑 val_1 = this.业丑丁丆丕丆丂丅万();
            if(val_1.世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if((丗丛不丁丑专专丂且 == null) || (丗丛不丁丑专专丂且.丒丟且一丟不业丕丆() == false))
            {
                goto label_7;
            }
            
            if(val_1 != 1)
            {
                    if(val_1 < 丗丛不丁丑专专丂且.丙东专丂世丈丏丁丂())
            {
                goto label_7;
            }
            
            }
            
            if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() != 20)
            {
                goto label_7;
            }
            
            if(W8 == 0)
            {
                goto label_8;
            }
            
            var val_6 = W8 + 1;
            mem[1152921559995604928] = val_6;
            if(val_6 >= 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_7:
            mem[1152921559995604928] = 0;
            return;
            label_8:
            val_7 = 1;
            label_9:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            label_10:
            this.丐三上丏丈丕且且丞();
        }
    
    }

}
