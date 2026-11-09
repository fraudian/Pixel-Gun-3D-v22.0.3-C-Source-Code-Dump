using UnityEngine;

namespace PGCompany
{
    internal static class 丅业且万与丛业丏世
    {
        // Methods
        internal static string 专下丘丅且丒丌丗丟(PGCompany.丆一一丂世七丏且丝 丌丏与丐东丘东丕不, int 东一七丟与丗三丐不)
        {
            return (string)System.String.Format(format:  "{0}_{1}", arg0:  丌丏与丐东丘东丕不, arg1:  东一七丟与丗三丐不);
        }
        internal static System.ValueTuple<PGCompany.丆一一丂世七丏且丝, int> 丌七下丝丘丅丄世丝(string 丙下不丏丅丅专丂丗)
        {
            var val_6;
            var val_7;
            char[] val_1 = new char[1];
            val_1[0] = '_';
            System.String[] val_2 = 丙下不丏丅丅专丂丗.Split(separator:  val_1);
            if(val_2.Length > 1)
            {
                    System.Nullable<T> val_3 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<PGCompany.丆一一丂世七丏且丝>(下业七不丑丂丏丟东:  val_2[0], 丏丅丗丌丌丞丌专丘:  0);
                System.ValueTuple<System.Int32, System.Boolean> val_4 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_2[1]);
                val_6 = val_4.Item2;
                val_7 = ;
            }
            else
            {
                    val_7 = 0;
                val_6 = 0;
            }
            
            DiscreteVector2 val_5 = new DiscreteVector2(三丟东丕丄丄下下丑:  0, 丒丒丄丁且丄丆丂丌:  0);
            return (System.ValueTuple<PGCompany.丆一一丂世七丏且丝, System.Int32>)val_5._x;
        }
    
    }

}
