using UnityEngine;

namespace PGCompany
{
    internal static class 丒七丗丏丌丘万丘专
    {
        // Fields
        private static System.Collections.Generic.Dictionary<PGCompany.丘丁丕丈丘且业三丄, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        internal static PGCompany.丕万丅丗丏三丙丈丁 下丙丗丟丂下丏不丟(PGCompany.丌不丞丐世丞三丘丌 与不丕丆丈不丙丟丛)
        {
            var val_4;
            PGCompany.丘丁丕丈丘且业三丄 val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            val_5 = 与不丕丆丈不丙丟丛.Type;
            if((PGCompany.丒七丗丏丌丘万丘专.世丂上丌丞且丁七丏.ContainsKey(key:  val_5)) == false)
            {
                goto label_5;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = 与不丕丆丈不丙丟丛.Type;
            if((System.Activator.CreateInstance(type:  PGCompany.丒七丗丏丌丘万丘专.世丂上丌丞且丁七丏.Item[val_5])) == null)
            {
                goto label_11;
            }
            
            mem2[0] = 与不丕丆丈不丙丟丛;
            return (PGCompany.丕万丅丗丏三丙丈丁)val_7;
            label_5:
            val_7 = 0;
            return (PGCompany.丕万丅丗丏三丙丈丁)val_7;
            label_11:
        }
        private static 丒七丗丏丌丘万丘专()
        {
            System.Collections.Generic.Dictionary<PGCompany.丘丁丕丈丘且业三丄, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丘丁丕丈丘且业三丄, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  5, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  6, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  7, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  8, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  9, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  10, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  11, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  12, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  13, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  14, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  15, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  16, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  17, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  18, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  19, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  20, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  21, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  22, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  23, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丒七丗丏丌丘万丘专.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}
