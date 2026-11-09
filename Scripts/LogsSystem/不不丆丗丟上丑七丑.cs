using UnityEngine;

namespace LogsSystem
{
    public class 不不丆丗丟上丑七丑
    {
        // Fields
        private readonly System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且> 三不丕下业下专不东;
        
        // Methods
        public 不不丆丗丟上丑七丑(System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且> 下丏丙且业三丑与业)
        {
            var val_4 = this;
            this.三不丕下业下专不东 = new System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且>();
            if(下丏丙且业三丑与业 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = 下丏丙且业三丑与业.GetEnumerator();
            label_4:
            if(((-1749156376) & 1) == 0)
            {
                goto label_2;
            }
            
            this.三不丕下业下专不东.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public 不不丆丗丟上丑七丑(LogsSystem.丝一丈丈丕东下上且 丞与丒世丏下丁三丂)
        {
            System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且> val_1 = new System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且>();
            this.三不丕下业下专不东 = val_1;
            if(丞与丒世丏下丁三丂 == null)
            {
                    return;
            }
            
            val_1.Add(item:  丞与丒世丏下丁三丂);
        }
        public 不不丆丗丟上丑七丑(LogsSystem.丝一丈丈丕东下上且[] 下丏丙且业三丑与业)
        {
            System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且> val_2;
            System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且>();
            this.三不丕下业下专不东 = val_2;
            if(下丏丙且业三丑与业 == null)
            {
                    return;
            }
            
            if(下丏丙且业三丑与业.Length < 1)
            {
                    return;
            }
            
            do
            {
                val_2 = 下丏丙且业三丑与业[0];
                this.三不丕下业下专不东.Add(item:  val_2);
            }
            while((0 + 1) < 下丏丙且业三丑与业.Length);
        
        }
        public System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且> 一不丂丕东丑世丑一()
        {
            return (System.Collections.Generic.List<LogsSystem.丝一丈丈丕东下上且>)this.三不丕下业下专不东;
        }
        public bool 丑丕丈丈不不且丑且()
        {
            if(this.三不丕下业下专不东 == null)
            {
                    return (bool)(this.三不丕下业下专不东.Count > 0) ? 1 : 0;
            }
            
            return (bool)(this.三不丕下业下专不东.Count > 0) ? 1 : 0;
        }
    
    }

}
