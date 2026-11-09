using UnityEngine;

namespace PGCompany
{
    internal static class 七丌一丆七丙业万丟
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<PGCompany.丑丘丂丝丐上丆丆世, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        internal static PGCompany.丑业七一丏丈丟丒三 下丙丗丟丂下丏不丟(PGCompany.丑丘丂丝丐上丆丆世 丁丅丈丌丟世丗丗丟, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_4;
            System.Collections.Generic.Dictionary<PGCompany.丑丘丂丝丐上丆丆世, System.Type> val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = PGCompany.七丌一丆七丙业万丟.世丂上丌丞且丁七丏;
            if((val_5.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) == false)
            {
                goto label_4;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = PGCompany.七丌一丆七丙业万丟.世丂上丌丞且丁七丏;
            if((System.Activator.CreateInstance(type:  val_5.Item[丁丅丈丌丟世丗丗丟])) == null)
            {
                goto label_10;
            }
            
            mem2[0] = 且丘丏丁丑与丙与丁;
            return (PGCompany.丑业七一丏丈丟丒三)val_7;
            label_4:
            val_7 = 0;
            return (PGCompany.丑业七一丏丈丟丒三)val_7;
            label_10:
        }
        private static 七丌一丆七丙业万丟()
        {
            System.Collections.Generic.Dictionary<PGCompany.丑丘丂丝丐上丆丆世, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丑丘丂丝丐上丆丆世, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.七丌一丆七丙业万丟.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}
