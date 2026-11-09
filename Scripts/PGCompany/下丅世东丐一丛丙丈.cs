using UnityEngine;

namespace PGCompany
{
    internal class 下丅世东丐一丛丙丈 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丒上丅丘丒丕丄一丒(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.世丛一丙丈丁世丒丐>(object:  this, method:  System.Void PGCompany.下丅世东丐一丛丙丈::丒一丆丌三丕专且丈(object 不丟丗丏丛丕不丁丌, Rilisoft.世丛一丙丈丁世丒丐 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丟丅世三丟丆东丌丟(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.世丛一丙丈丁世丒丐>(object:  this, method:  System.Void PGCompany.下丅世东丐一丛丙丈::丒一丆丌三丕专且丈(object 不丟丗丏丛丕不丁丌, Rilisoft.世丛一丙丈丁世丒丐 丗丛不丁丑专专丂且)));
        }
        internal override bool 专下丒丘丞下丟不下(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
        {
            return this.下丄丈万世丁丕丄丌(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
        }
        private void 丒一丆丌三丕专且丈(object 不丟丗丏丛丕不丁丌, Rilisoft.世丛一丙丈丁世丒丐 丗丛不丁丑专专丂且)
        {
            string val_13;
            if(IsClanWarChallange == false)
            {
                goto label_2;
            }
            
            val_13 = 丗丛不丁丑专专丂且.丂一丙丑丈万丟丝丕();
            丞丂丘丒丟丞丑下丄 val_4 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_4 == null)
            {
                goto label_5;
            }
            
            if(val_13 != null)
            {
                goto label_23;
            }
            
            label_24:
            label_23:
            if((val_13.Equals(value:  val_4.业丐丐三丕一丗丛丁(), comparisonType:  4)) == true)
            {
                    return;
            }
            
            label_2:
            if((public static ClansController Rilisoft.Singleton<ClansController>::get_Instance()) != 100)
            {
                    if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
                if(val_13 != 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
            {
                    return;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
                if((PGCompany.丞丂丄丐三业丝丆丂.丙丟丄丕丈丝一丛丘(丘与丙丟丙丙下七丙:  val_13, 丆丁丗一一丆丈丗丞:  丗丛不丁丑专专丂且.丕丆丞丂业东与上丅(), 丂丛丑东不丅丈一东:  丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())) == false)
            {
                    return;
            }
            
            }
            
            if((public static ClansController Rilisoft.Singleton<ClansController>::get_Instance()) != 9990000)
            {
                    if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
                if(val_13 != 丗丛不丁丑专专丂且.丘专上世与丟丝丟丛())
            {
                    return;
            }
            
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
            return;
            label_5:
            if(val_13 != null)
            {
                goto label_23;
            }
            
            goto label_24;
        }
        public 下丅世东丐一丛丙丈()
        {
        
        }
    
    }

}
