using UnityEngine;

namespace MTAssets.SkinnedMeshCombiner
{
    public static class 不下不丏三上万万丗
    {
        // Methods
        public static UnityEngine.Mesh 丙丏丁丆丈丗丝丘丏(UnityEngine.Mesh 不与丌丏不丘不丛丁, int 东专丅丄丐丐丗丟丅)
        {
            UnityEngine.Mesh val_11;
            UnityEngine.Mesh val_12;
            val_11 = 不与丌丏不丘不丛丁;
            if((东专丅丄丐丐丗丟丅 & 2147483648) == 0)
            {
                    val_12 = 0;
                if(val_11.subMeshCount <= 东专丅丄丐丐丗丟丅)
            {
                    return (UnityEngine.Mesh)val_12;
            }
            
                不下不丏三上万万丗.专丄丅不丒丗丌丘丑 val_4 = null;
                val_11 = val_4;
                val_4 = new 不下不丏三上万万丗.专丄丅不丒丗丌丘丑();
                System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_5 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
                int[] val_6 = new int[0];
                if(val_2.Length >= 1)
            {
                    do
            {
                int val_12 = val_11.GetTriangles(submesh:  东专丅丄丐丐丗丟丅)[0];
                if((val_5.TryGetValue(key:  val_12, value: out  0)) != true)
            {
                    int val_9 = val_4.业丏丗丐丂业东丂丗(丏丌下七丁丑东丑丗:  new 不下不丏三上万万丗.专丄丅不丒丗丌丘丑(不与丌丏不丘不丛丁:  val_11), 丌丑丐丞丞丅专与丒:  val_12);
                val_5.Add(key:  val_12, value:  val_9);
            }
            
                val_6[0] = val_9;
            }
            while((0 + 1) < val_2.Length);
            
            }
            
                UnityEngine.Mesh val_11 = null;
                val_12 = val_11;
                val_11 = new UnityEngine.Mesh();
                val_4.世万丗专下丘丐业丐(丟丂万业上丄三丘丆:  val_11);
                val_11.triangles = val_6;
                return (UnityEngine.Mesh)val_12;
            }
            
            val_12 = 0;
            return (UnityEngine.Mesh)val_12;
        }
    
    }

}
