using UnityEngine;

namespace PGCompany
{
    internal static class 丒与丕世下丁丟业与
    {
        // Fields
        private static System.Collections.Generic.Dictionary<PGCompany.丐丙七丘丙丟丘一专, System.Type> 世丂上丌丞且丁七丏;
        
        // Methods
        internal static PGCompany.上丐丗上七丏丕万丟 下丙丗丟丂下丏不丟(PGCompany.丐万丟丈丂丕丞东业 七丛上丛丌丟丙丑丑)
        {
            var val_5;
            PGCompany.丐丙七丘丙丟丘一专 val_6;
            var val_7;
            var val_8;
            val_5 = null;
            val_5 = null;
            val_6 = 七丛上丛丌丟丙丑丑.丒三丝一上丙专丗丒;
            if((PGCompany.丒与丕世下丁丟业与.世丂上丌丞且丁七丏.ContainsKey(key:  val_6)) == false)
            {
                goto label_5;
            }
            
            val_7 = null;
            val_7 = null;
            val_6 = 七丛上丛丌丟丙丑丑.丒三丝一上丙专丗丒;
            if((System.Activator.CreateInstance(type:  PGCompany.丒与丕世下丁丟业与.世丂上丌丞且丁七丏.Item[val_6])) == null)
            {
                goto label_11;
            }
            
            mem2[0] = 七丛上丛丌丟丙丑丑;
            return (PGCompany.上丐丗上七丏丕万丟)val_8;
            label_5:
            if(七丛上丛丌丟丙丑丑.丒三丝一上丙专丗丒 != 0)
            {
                    丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "Need implement ItemExecutableHandlerAbstract for {0}", arg0:  七丛上丛丌丟丙丑丑.丒三丝一上丙专丗丒));
            }
            
            val_8 = 0;
            return (PGCompany.上丐丗上七丏丕万丟)val_8;
            label_11:
        }
        private static 丒与丕世下丁丟业与()
        {
            System.Collections.Generic.Dictionary<PGCompany.丐丙七丘丙丟丘一专, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.丐丙七丘丙丟丘一专, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.丒与丕世下丁丟业与.世丂上丌丞且丁七丏 = val_1;
        }
    
    }

}
