using UnityEngine;

namespace Rilisoft.TimeManagment
{
    public class 丁丕万世丘丁丁专且 : 丝丞丒丆三业丈丏丟
    {
        // Fields
        private long 丘丙七七东世丐丄不;
        protected long 丞专专一上丒丁一三;
        private bool 丌一丙且丝专上上业;
        private bool 且业丘丝丗丘丐丒丐;
        
        // Properties
        protected string 丘丂丗三专丐丑丑丏 { get; }
        
        // Methods
        public 丁丕万世丘丁丁专且(string 丞丅上丏丂且下丅与, float 与丈业丛丝丒丙一丏, float 丟七丒丟一上丏世丄 = 1)
        {
            System.Nullable<System.Int64> val_1 = this.丅丘七世上丘且丗不();
            if(( & 1) != 0)
            {
                    this.丘上丐世丆丑且丞丒();
                return;
            }
            
            CoroutineRunner.丈与丅丆丘丟丆丆丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.TimeManagment.丁丕万世丘丁丁专且::世丝且丏丒丈三丟丄()));
            this.丌一丙且丝专上上业 = true;
        }
        protected string 丌东一丕丈上专业不()
        {
            return System.String.Format(format:  "timer_{0}", arg0:  null);
        }
        private void 世丝且丏丒丈三丟丄()
        {
            if(this.丌一丙且丝专上上业 == false)
            {
                    return;
            }
            
            System.Nullable<System.Int64> val_1 = this.丅丘七世上丘且丗不();
            if(( & 1) == 0)
            {
                    return;
            }
            
            CoroutineRunner.东丁丗三丌丆丝丘丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.TimeManagment.丁丕万世丘丁丁专且::世丝且丏丒丈三丟丄()));
            this.丌一丙且丝专上上业 = false;
            this.丘上丐世丆丑且丞丒();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            var val_7;
            var val_8;
            int val_1 = this.丑上丒丗七丕丑上三();
            if(val_1 >= 1)
            {
                    this.丞专专一上丒丁一三 = (long)val_1;
                System.Nullable<System.Int64> val_2 = this.丅丘七世上丘且丗不();
                val_7 = public System.Int64 System.Nullable<System.Int64>::get_Value();
                val_8 = S1 - (S0 * ((float) - (val_1 << )));
            }
            else
            {
                    System.Nullable<System.Int64> val_5 = this.丅丘七世上丘且丗不();
                this.丞专专一上丒丁一三 = ;
            }
            
            mem[1152921543690062984] = ???;
            System.Nullable<System.Int64> val_6 = this.丅丘七世上丘且丗不();
            this.丘丙七七东世丐丄不 = ;
            if(this.且业丘丝丗丘丐丒丐 == false)
            {
                    return;
            }
            
            this.且业丘丝丗丘丐丒丐 = false;
        }
        public override void 三丑丛丄万丟丄丞丁()
        {
            if(this.丌一丙且丝专上上业 != false)
            {
                    this.且业丘丝丗丘丐丒丐 = true;
                return;
            }
            
            this.三丑丛丄万丟丄丞丁();
        }
        public override void 丌丄丏下七丁专丂世()
        {
            if(this.丌一丙且丝专上上业 != false)
            {
                    this.且业丘丝丗丘丐丒丐 = false;
                return;
            }
            
            this.丌丄丏下七丁专丂世();
        }
        public override void 且七丙丄丘一丄上不()
        {
            this.且七丙丄丘一丄上不();
            mem[1152921543690398984] = this.丌丛丟丙丘丝丂一不();
            System.Nullable<System.Int64> val_2 = this.丅丘七世上丘且丗不();
            this.丞专专一上丒丁一三 = ;
        }
        protected override void 丛丙世丞丌丄业丙丅()
        {
            int val_9;
            if(S8 > 0f)
            {
                    System.Nullable<System.Int64> val_1 = this.丅丘七世上丘且丗不();
                val_9 = public System.Int64 System.Nullable<System.Int64>::get_Value();
                float val_2 = S0 * (2.730283E+10f);
                val_2 = S8 - val_2;
                mem[1152921543690510984] = val_2;
            }
            else
            {
                    float val_3 = this.丌丛丟丙丘丝丂一不();
                val_3 = System.Math.Abs(S8) / val_3;
                mem[1152921543690510984] = this.丌丛丟丙丘丝丂一不();
                System.Nullable<System.Int64> val_7 = this.丅丘七世上丘且丗不();
                val_9 = public System.Int64 System.Nullable<System.Int64>::get_Value();
                this.丞专专一上丒丁一三 = ;
                if(as. 
                
              
             
            
             
              != 0)
            {
                    val_9 = UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.FloorToInt(f:  val_3), b:  1);
                Invoke(obj:  val_9);
            }
            
            }
            
            System.Nullable<System.Int64> val_8 = this.丅丘七世上丘且丗不();
            mem[1152921543690510976] = ;
        }
        protected virtual void 丈且与下丌不丅丒丐()
        {
            System.Nullable<System.Int64> val_1 = this.丅丘七世上丘且丗不();
            if((429066448 & 1) == 0)
            {
                    return;
            }
            
            this = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            this.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  51, 丙业与丙丗丝不丈东:  this.丞专专一上丒丁一三);
        }
        protected int 丑上丒丗七丕丑上三()
        {
            object val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  51);
            if(val_2 == null)
            {
                    return (int)val_2;
            }
            
            return System.Convert.ToInt32(value:  val_2);
        }
    
    }

}
