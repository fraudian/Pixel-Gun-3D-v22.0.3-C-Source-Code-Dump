using UnityEngine;

namespace Rilisoft
{
    public class 丅丂丛丒不专丈业丘<T> : 丅丟丒丟丑丈丒三丆
    {
        // Fields
        private T 七丘一世丛丞三与丟;
        public UnityEngine.Events.UnityAction 丑世下不一不世且三;
        
        // Properties
        public virtual T 万下丞三丘世下丘专 { get; set; }
        
        // Methods
        public 丅丂丛丒不专丈业丘<T>(string 丟东丟丑丕丄丂丟丙)
        {
            if(this != null)
            {
                    return;
            }
        
        }
        public virtual T 丅专丑丑上东专与丅()
        {
            string val_6;
            DataSystem.丈且丈上不下且丝丒 val_7;
            if(83328 != 0)
            {
                    return (object)val_7;
            }
            
            val_6 = this.世三丞丅丑丌丈丈一();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
            {
                    val_7 = 0;
                mem[1152921542367582616] = 0;
                return (object)val_7;
            }
            
            val_6 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            string val_4 = this.世三丞丅丑丌丈丈一();
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = val_6;
            mem[1152921542367582616] = val_7;
            return (object)val_7;
        }
        public virtual void 不世一东丄丙丛丛上(T 丙业与丙丗丝不丈东)
        {
            int val_4;
            mem[1152921542367715112] = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_1;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_8;
            label_1:
            val_4 = System.String.alignConst;
            goto label_9;
            label_8:
            val_4 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丙业与丙丗丝不丈东);
            if(this == null)
            {
                goto label_10;
            }
            
            label_9:
            mem[1152921542367715088] = val_4;
            goto label_11;
            label_10:
            mem[1152921542367715088] = val_4;
            label_11:
            this.丂上丆且丘三不丟业(丙业与丙丗丝不丈东:  val_4);
        }
        public void 丂且不业丂专丛丆东()
        {
            int val_4;
            if(this == null)
            {
                goto label_2;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_9;
            label_2:
            val_4 = System.String.alignConst;
            if(this != null)
            {
                goto label_10;
            }
            
            label_12:
            mem[1152921542367843504] = val_4;
            goto label_11;
            label_9:
            val_4 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
            if(this == null)
            {
                goto label_12;
            }
            
            label_10:
            mem[1152921542367843504] = val_4;
            label_11:
            this.丂上丆且丘三不丟业(丙业与丙丗丝不丈东:  val_4);
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
    
    }

}
