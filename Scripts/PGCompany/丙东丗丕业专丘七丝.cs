using UnityEngine;

namespace PGCompany
{
    internal static class 丙东丗丕业专丘七丝
    {
        // Fields
        private static System.Collections.Generic.Dictionary<PGCompany.丝且七万丄一丏丌丙, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        internal static PGCompany.丅丏且丒业丏与且丆 下丙丗丟丂下丏不丟(PGCompany.丝且七万丄一丏丌丙 丁丅丈丌丟世丗丗丟, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_4;
            System.Collections.Generic.Dictionary<PGCompany.丝且七万丄一丏丌丙, System.Type> val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = PGCompany.丙东丗丕业专丘七丝.世丂上丌丞且丁七丏;
            if((val_5.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) == false)
            {
                goto label_4;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = PGCompany.丙东丗丕业专丘七丝.世丂上丌丞且丁七丏;
            if((System.Activator.CreateInstance(type:  val_5.Item[丁丅丈丌丟世丗丗丟])) == null)
            {
                goto label_10;
            }
            
            mem2[0] = 且丘丏丁丑与丙与丁;
            return (PGCompany.丅丏且丒业丏与且丆)val_7;
            label_4:
            val_7 = 0;
            return (PGCompany.丅丏且丒业丏与且丆)val_7;
            label_10:
        }
        private static 丙东丗丕业专丘七丝()
        {
            System.Collections.Generic.Dictionary<PGCompany.丝且七万丄一丏丌丙, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丝且七万丄一丏丌丙, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丙东丗丕业专丘七丝.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}
