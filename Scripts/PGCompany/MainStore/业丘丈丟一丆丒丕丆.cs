using UnityEngine;

namespace PGCompany.MainStore
{
    internal sealed class 业丘丈丟一丆丒丕丆 : 丌丈丕丑丛丕世丒世
    {
        // Fields
        private readonly System.Type 丈丂与丐不且丑一下;
        
        // Methods
        public string 丙业不丝丗丌丗世下(object 万且万且丑丗且丌丆)
        {
            var val_6;
            object val_13;
            var val_14;
            var val_15;
            val_13 = 万且万且丑丗且丌丆;
            val_14 = 0;
            return (string)val_14;
            label_12:
            if(((-594489568) & 1) == 0)
            {
                goto label_10;
            }
            
            Add(item:  PGCompany.丂丑业与上丄丂且下.丙业不丝丗丌丗世下(一丗与一专丙丙丅丄:  val_6.丐丏七丌丕丗业且上()));
            goto label_12;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = 0;
            val_14 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  null);
            PGCompany.东丑丒丗一丞下丙丙<T> val_12 = PGCompany.东丑丒丗一丞下丙丙<System.String>.万世丅七一专丕丞不();
            return (string)val_14;
        }
        public T 丂东专丙丒丏且丛丁<T>(string 丞丕丒专一下丙业上)
        {
            var val_5;
            var val_6;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = 0;
            if((System.Type.op_Inequality(left:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), right:  this.丈丂与丐不且丑一下)) == true)
            {
                    return (object)val_6;
            }
            
            object val_3 = this.丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  丞丕丒专一下丙业上, 丁丅丈丌丟世丗丗丟:  this.丈丂与丐不且丑一下);
            val_5 = mem[__RuntimeMethodHiddenParam + 48 + 8];
            val_5 = __RuntimeMethodHiddenParam + 48 + 8;
            if(val_3 != null)
            {
                    val_6 = val_3;
                if(val_6 != null)
            {
                    return (object)val_6;
            }
            
            }
            
            val_6 = 0;
            return (object)val_6;
        }
        public object 丂东专丙丒丏且丛丁(string 丞丕丒专一下丙业上, System.Type 丁丅丈丌丟世丗丗丟)
        {
            System.Type val_10;
            var val_11;
            PGCompany.专丟专世丅丂丁且专 val_8 = 0;
            val_10 = this.丈丂与丐不且丑一下;
            val_11 = 0;
            if((System.Type.op_Inequality(left:  丁丅丈丌丟世丗丗丟, right:  val_10)) == true)
            {
                    return (object)val_11;
            }
            
            DataSystem.丈且丈上不下且丝丒 val_2 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            val_10 = public System.Collections.Generic.List<System.String> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<System.String>>(string 丞丕丒专一下丙业上);
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2 == null)
            {
                goto label_11;
            }
            
            System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> val_4 = null;
            val_11 = val_4;
            val_4 = new System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>();
            List.Enumerator<T> val_5 = val_2.GetEnumerator();
            val_10 = 1152921519126358176;
            label_14:
            if(((-594171320) & 1) == 0)
            {
                goto label_12;
            }
            
            bool val_9 = PGCompany.丂丑业与上丄丂且下.丂东专丙丒丏且丛丁(丞丕丒专一下丙业上:  0.丐丏七丌丕丗业且上(), 丗不丁丐下世上丙专: out  0, 一丗与一专丙丙丅丄: out  val_8);
            val_4.Add(item:  val_8);
            goto label_14;
            label_11:
            val_11 = 0;
            return (object)val_11;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_11;
        }
        public 业丘丈丟一丆丒丕丆()
        {
            this.丈丂与丐不且丑一下 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
