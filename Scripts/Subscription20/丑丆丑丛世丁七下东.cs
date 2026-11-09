using UnityEngine;

namespace Subscription20
{
    internal static class 丑丆丑丛世丁七下东
    {
        // Methods
        internal static PGCompany.丙一丟与且丞丏丈一 下丛丌丐丗丒且且业(int 丞世不丒下上上丝丑, Subscription20.丒丗业丑丛东上下一 丐丛且丟世丕丂丞丟)
        {
            return (PGCompany.丙一丟与且丞丏丈一)new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  System.String.Format(format:  "subscription20-{0}_{1}", arg0:  丞世不丒下上上丝丑, arg1:  丐丛且丟世丕丂丞丟));
        }
        internal static int 与上丞业丁丗丒业世(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            PGCompany.专丟专世丅丂丁且专 val_4 = 一丗与一专丙丙丅丄;
            if(val_4 == null)
            {
                    return (int)Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_4 = 0);
            }
            
            return (int)Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_4);
        }
        internal static int 与上丞业丁丗丒业世(PGCompany.丙一丟与且丞丏丈一 一丗与一专丙丙丅丄)
        {
            string val_7;
            object val_8;
            char[] val_3 = new char[1];
            val_3[0] = '_';
            val_7 = 一丗与一专丙丙丅丄.七万丅丆且丁世丏丈().Replace(oldValue:  "subscription20-", newValue:  "").Split(separator:  val_3);
            if(val_4.Length >= 1)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_5 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_7[0]);
                if(((ulong)(val_5.Item2 >> 32) & 255) != 0)
            {
                    val_7 = val_7[0];
                val_8 = val_7;
                System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8);
                return (int)val_8;
            }
            
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        internal static Subscription20.丒丗业丑丛东上下一 丈丛丘丗丌东丞丌丒(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            PGCompany.专丟专世丅丂丁且专 val_4 = 一丗与一专丙丙丅丄;
            if(val_4 == null)
            {
                    return (Subscription20.丒丗业丑丛东上下一)Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  val_4 = 0);
            }
            
            return (Subscription20.丒丗业丑丛东上下一)Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  val_4);
        }
        internal static Subscription20.丒丗业丑丛东上下一 丈丛丘丗丌东丞丌丒(PGCompany.丙一丟与且丞丏丈一 一丗与一专丙丙丅丄)
        {
            string val_7;
            object val_8;
            char[] val_3 = new char[1];
            val_3[0] = '_';
            val_7 = 一丗与一专丙丙丅丄.七万丅丆且丁世丏丈().Replace(oldValue:  "subscription20-", newValue:  "").Split(separator:  val_3);
            if(val_4.Length >= 2)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_5 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_7[1]);
                if(((ulong)(val_5.Item2 >> 32) & 255) != 0)
            {
                    val_7 = val_7[1];
                val_8 = val_7;
                System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8);
                return (Subscription20.丒丗业丑丛东上下一)val_8;
            }
            
            }
            
            val_8 = 0;
            return (Subscription20.丒丗业丑丛东上下一)val_8;
        }
        internal static bool 与丛不三丒丁丟丆丑()
        {
            Subscription20.丘丛不东丒丆丁丑丁 val_3 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑());
            if(val_3 == null)
            {
                    return (bool)((val_3.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗())) == 2) ? 1 : 0;
            }
            
            return (bool)((val_3.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗())) == 2) ? 1 : 0;
        }
    
    }

}
