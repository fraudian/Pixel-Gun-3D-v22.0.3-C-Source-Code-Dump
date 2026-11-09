using UnityEngine;

namespace PGCompany
{
    internal static class 东不丂三不东丂丙丁
    {
        // Fields
        private static System.Collections.Generic.Dictionary<PGCompany.东丕丐一与丏东丘下, System.Type> 下世丂丞业丄丝丕丑;
        
        // Methods
        internal static PGCompany.丞丘丟丝丗丒三丛丁 三丐丛丅万不丆丅不(PGCompany.丗业丑专丂丑丟丝丅 上世丏丁世丟世丆业)
        {
            var val_9;
            PGCompany.东丕丐一与丏东丘下 val_10;
            var val_11;
            var val_12;
            val_9 = null;
            val_9 = null;
            val_10 = 上世丏丁世丟世丆业.不业丙丒丂丞下丆丙();
            if((PGCompany.东不丂三不东丂丙丁.下世丂丞业丄丝丕丑.ContainsKey(key:  val_10)) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = 上世丏丁世丟世丆业.不业丙丒丂丞下丆丙();
                val_12 = System.Activator.CreateInstance(type:  PGCompany.东不丂三不东丂丙丁.下世丂丞业丄丝丕丑.Item[val_10]);
                val_12 = 0;
                val_12.与丟与丂丞丒下七丐(丙业与丙丗丝不丈东:  上世丏丁世丟世丆业);
                return (PGCompany.丞丘丟丝丗丒三丛丁)val_12;
            }
            
            val_12 = 0;
            if(上世丏丁世丟世丆业.不业丙丒丂丞下丆丙() != 0)
            {
                    return (PGCompany.丞丘丟丝丗丒三丛丁)val_12;
            }
            
            丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  System.String.Format(format:  "Need implement ClanGovernorTaskRewardHandler for {0}", arg0:  上世丏丁世丟世丆业.不业丙丒丂丞下丆丙()));
            val_12 = 0;
            return (PGCompany.丞丘丟丝丗丒三丛丁)val_12;
        }
        private static 东不丂三不东丂丙丁()
        {
            System.Collections.Generic.Dictionary<PGCompany.东丕丐一与丏东丘下, System.Type> val_1 = new System.Collections.Generic.Dictionary<PGCompany.东丕丐一与丏东丘下, System.Type>();
            val_1.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_1.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            PGCompany.东不丂三不东丂丙丁.下世丂丞业丄丝丕丑 = val_1;
        }
    
    }

}
