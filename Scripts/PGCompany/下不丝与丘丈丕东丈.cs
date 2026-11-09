using UnityEngine;

namespace PGCompany
{
    internal class 下不丝与丘丈丕东丈 : 丂丏丑丈丕三丙丛丑
    {
        // Properties
        protected override bool 丙丅丛不丄七丟业丌 { get; }
        
        // Methods
        internal override void 丈且东丑丂且万丒丅()
        {
            PGCompany.世丆下不与丈丗丂丒.丐丏三上且丒丂与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.下不丝与丘丈丕东丈::丒丂万世上不七东与()));
            PGCompany.世丐下丕专东丘丏且.丁七丙丈丑万丕丆与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void PGCompany.下不丝与丘丈丕东丈::万丘万专下丙丁一丟(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 不丁丌丐业丑丟且不)));
        }
        internal override void 丏丟业下与丝丕丈丘()
        {
            PGCompany.世丆下不与丈丗丂丒.三七丅万万丗丂业丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.下不丝与丘丈丕东丈::丒丂万世上不七东与()));
            PGCompany.世丐下丕专东丘丏且.丐上丑丌七下丏丘丞(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  this, method:  System.Void PGCompany.下不丝与丘丈丕东丈::万丘万专下丙丁一丟(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 不丁丌丐业丑丟且不)));
        }
        private void 丒丂万世上不七东与()
        {
            this.且上上丌丅丟丆丕丒();
        }
        private void 万丘万专下丙丁一丟(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业, bool 不丁丌丐业丑丟且不)
        {
            if(万不且且丛丆东丒业.不业丙丒丂丞下丆丙() != 1)
            {
                    return;
            }
            
            this.且上上丌丅丟丆丕丒();
        }
        protected override void 丅丘丙丒丆丄三丝丌()
        {
            var val_18;
            var val_19;
            val_18 = this;
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            val_19 = 1152921540455771936;
            if((Rilisoft.Singleton<PGCompany.TaskBookController>.Instance) == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.String> val_4 = PGCompany.世丆下不与丈丗丂丒.丅丑丟丙万万世七丂(下上丐丆丝丟丝丒不:  68);
            val_19 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  Rilisoft.Singleton<PGCompany.TaskBookController>.Instance.不丆丘不丑业下丗与().Values);
            List.Enumerator<T> val_9 = val_19.GetEnumerator();
            label_14:
            if(((-646020248) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_10 = 0.丐丏七丌丕丗业且上();
            if((PGCompany.世丆下不与丈丗丂丒.丅丑丟丙万万世七丂(下上丐丆丝丟丝丒不:  67).Contains(item:  val_10.丅丙丛丑丌丆丌丕丒())) == false)
            {
                goto label_10;
            }
            
            if(val_10.不一丅丂上丁丈三下() == false)
            {
                goto label_14;
            }
            
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丂丁丏一丙丛业且丌() + 1);
            goto label_14;
            label_10:
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丂丁丏一丙丛业且丌() + 1);
            goto label_14;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        protected override bool 丆丏丗业丝丘上不东()
        {
            var val_6;
            var val_7;
            val_6 = this;
            if(this.丆丏丗业丝丘上不东() != false)
            {
                    if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.taskbook")) != false)
            {
                    val_6 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
                val_7 = (val_6.丂世三丅一万东三三(不七丆万丁一丞七下:  164)) ^ 1;
                return (bool)val_7 & 1;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7 & 1;
        }
        public 下不丝与丘丈丕东丈()
        {
        
        }
    
    }

}
