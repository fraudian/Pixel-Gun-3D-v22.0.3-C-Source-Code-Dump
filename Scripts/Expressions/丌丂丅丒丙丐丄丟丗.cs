using UnityEngine;

namespace Expressions
{
    internal static class 丌丂丅丒丙丐丄丟丗
    {
        // Fields
        private static System.Text.RegularExpressions.Regex 万丛丝下一丞且下且;
        
        // Methods
        internal static bool 专东丝丄丒丐丈丑丅(Expressions.丄丌与丗丙七丐丗业 丛丅且丕丗一丈上东)
        {
            return (bool)((丛丅且丕丗一丈上东 | 1) == 3) ? 1 : 0;
        }
        internal static Expressions.丗下万万丛丙七丒丂 丕丙专丌上丕丅丛丝(Expressions.丄丌与丗丙七丐丗业 丛丅且丕丗一丈上东)
        {
            return (Expressions.丗下万万丛丙七丒丂)(丛丅且丕丗一丈上东 != 2) ? (1 + 1) : 1;
        }
        internal static System.Text.RegularExpressions.Regex 且丁丌上丕一与丕丟()
        {
            System.Text.RegularExpressions.Regex val_2;
            System.Text.RegularExpressions.Regex val_3 = Expressions.丌丂丅丒丙丐丄丟丗.万丛丝下一丞且下且;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            System.Text.RegularExpressions.Regex val_1 = null;
            val_2 = val_1;
            val_1 = new System.Text.RegularExpressions.Regex(pattern:  "(\\s?AND\\s)|(\\s?OR\\s)|(\\s?(\\sOR|\\sAND)$|(^OR$)|(^AND$))", options:  1);
            Expressions.丌丂丅丒丙丐丄丟丗.万丛丝下一丞且下且 = val_2;
            val_3 = Expressions.丌丂丅丒丙丐丄丟丗.万丛丝下一丞且下且;
            return val_3;
        }
    
    }

}
