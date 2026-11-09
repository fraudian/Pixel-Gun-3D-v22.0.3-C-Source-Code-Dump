using UnityEngine;

namespace PGCompany
{
    internal class 世专且丆与丛万丆丈 : 下东丌丝三丑一丑万
    {
        // Methods
        internal override void 上丑丒三丐一丈三丛(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丞东丂丝东丒丝丅东)
        {
            object[] val_1 = new object[1];
            string val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丞东丂丝东丒丝丅东);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            UnityEngine.Debug.LogErrorFormat(format:  "ActionBeforeTransaction items: {0}", args:  val_1);
        }
        internal override void 丐丝丏三丛丕三丙丂(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丛丐与丌丑专丑七丄)
        {
            object[] val_1 = new object[1];
            string val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丛丐与丌丑专丑七丄);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            UnityEngine.Debug.LogErrorFormat(format:  "ActionAfterTransaction items: {0}", args:  val_1);
        }
        public 世专且丆与丛万丆丈()
        {
        
        }
    
    }

}
