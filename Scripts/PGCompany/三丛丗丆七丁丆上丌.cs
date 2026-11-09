using UnityEngine;

namespace PGCompany
{
    internal static class 三丛丗丆七丁丆上丌
    {
        // Fields
        internal static char 丛丑世丐丐且丅与东;
        private static int 丝东与丝丘世丏丒与;
        
        // Methods
        internal static string 丘丐丕世下丟丁丛三(PGCompany.丝丗丁丞丒且丙丑丙 丁丅丈丌丟世丗丗丟, int 丞丅上丏丂且下丅与)
        {
            null = null;
            return (string)System.String.Format(format:  "{0}{1}{2}", arg0:  丁丅丈丌丟世丗丗丟, arg1:  PGCompany.三丛丗丆七丁丆上丌.丛丑世丐丐且丅与东, arg2:  丞丅上丏丂且下丅与);
        }
        internal static void 东丝上丒三丁丅上下(string 丙下不丏丅丅专丂丗, out PGCompany.丝丗丁丞丒且丙丑丙 丁丅丈丌丟世丗丗丟, out int 丞丅上丏丂且下丅与)
        {
            int val_3 = 0;
            丁丅丈丌丟世丗丗丟 = 0;
            丞丅上丏丂且下丅与 = 0;
            char[] val_1 = new char[1];
            val_1[0] = '_';
            System.String[] val_2 = 丙下不丏丅丅专丂丗.Split(separator:  val_1);
            if(val_2.Length != 2)
            {
                    return;
            }
            
            if((System.Int32.TryParse(s:  val_2[0], result: out  val_3)) != false)
            {
                    丁丅丈丌丟世丗丗丟 = val_3;
            }
            
            bool val_6 = System.Int32.TryParse(s:  val_2[1], result: out  1152921555969126864);
        }
        internal static int 东一丂丛丞与丁丙业(PGCompany.丅丘丒丒丒丌丅三丏 世七七丟丑丁丂与丞, int 三丐丘万上下上丛七)
        {
            世七七丟丑丁丂与丞 = 三丐丘万上下上丛七 + (世七七丟丑丁丂与丞 * 100);
            return (int)世七七丟丑丁丂与丞;
        }
        internal static void 丏七三丄丙不丗且丐(int 万丏丗丗丅丄丌业一, out PGCompany.丅丘丒丒丒丌丅三丏 世七七丟丑丁丂与丞, out int 三丐丘万上下上丛七)
        {
            float val_2 = 100f;
            val_2 = (float)万丏丗丗丅丄丌业一 / val_2;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_2);
            int val_3 = 99;
            val_3 = 万丏丗丗丅丄丌业一 + (val_1 * val_3);
            世七七丟丑丁丂与丞 = val_1;
            三丐丘万上下上丛七 = val_3;
        }
        internal static PGCompany.专丟专世丅丂丁且专 丑丞与丝世下丆丛丏(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_11;
            PGCompany.丆一丁丏三万丑东不 val_12;
            var val_13;
            PGCompany.丛丗三丐一丙丐丆与 val_1 = new PGCompany.丛丗三丐一丙丐丆与();
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return (PGCompany.专丟专世丅丂丁且专)val_1;
            }
            
            if(val_1 != null)
            {
                    .Price = 且丘丏丁丑与丙与丁;
                .Type = 且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙();
                val_11 = 0;
                val_12 = 且丘丏丁丑与丙与丁.丟丄丐丙万丛丂丆三();
            }
            else
            {
                    mem[40] = 且丘丏丁丑与丙与丁;
                val_11 = 0;
                mem[16] = 且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙();
                val_12 = 且丘丏丁丑与丙与丁.丟丄丐丙万丛丂丆三();
            }
            
            .PurchaseType = val_12;
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return (PGCompany.专丟专世丅丂丁且专)val_1;
            }
            
            val_13 = 且丘丏丁丑与丙与丁.Count;
            .ItemParams = new PGCompany.三东丏不丗世丅丌丄[0];
            val_12 = 0;
            goto label_6;
            label_16:
            val_13 = val_12;
            PGCompany.三东丏不丗世丅丌丄 val_9 = 且丘丏丁丑与丙与丁.Item[0].与下不与丐丈丁丈万();
            if((PGCompany.丛丗三丐一丙丐丆与)[1152921555969622304].ItemParams == null)
            {
                goto label_9;
            }
            
            if(val_9 != null)
            {
                goto label_10;
            }
            
            goto label_13;
            label_9:
            if(val_9 == null)
            {
                goto label_13;
            }
            
            label_10:
            if(val_9 == null)
            {
                    val_13 = 0;
            }
            
            label_13:
            if(val_12 >= (PGCompany.丛丗三丐一丙丐丆与)[1152921555969622304].ItemParams.Length)
            {
                    val_13 = 0;
            }
            
            val_12 = 1;
            (PGCompany.丛丗三丐一丙丐丆与)[1152921555969622304].ItemParams[0] = val_9;
            label_6:
            if(val_12 < 且丘丏丁丑与丙与丁.Count)
            {
                goto label_16;
            }
            
            return (PGCompany.专丟专世丅丂丁且专)val_1;
        }
        internal static int 丌丏专且丁丂丟世东()
        {
            null = null;
            int val_1 = PGCompany.三丛丗丆七丁丆上丌.丝东与丝丘世丏丒与;
            val_1 = val_1 + 1;
            PGCompany.三丛丗丆七丁丆上丌.丝东与丝丘世丏丒与 = val_1;
            return (int)PGCompany.三丛丗丆七丁丆上丌.丝东与丝丘世丏丒与;
        }
        internal static bool 丐丅东与丟东东丌丐(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_7;
            var val_8;
            val_7 = 且丘丏丁丑与丙与丁;
            if(val_7 == null)
            {
                goto label_5;
            }
            
            if(val_7.上丟丄与丁三丌丘专() >= 1)
            {
                    if(PixelTime.丙丅丅业丟丁世丁丗() < (val_7.上丟丄与丁三丌丘专() << ))
            {
                goto label_5;
            }
            
            }
            
            if(val_7.下丒丗丄丌丘不丑丘() < 1)
            {
                goto label_9;
            }
            
            val_7 = val_7.下丒丗丄丌丘不丑丘();
            if(PixelTime.丙丅丅业丟丁世丁丗() <= (val_7 << ))
            {
                goto label_9;
            }
            
            label_5:
            val_8 = 0;
            return (bool)val_8;
            label_9:
            val_8 = 1;
            return (bool)val_8;
        }
        internal static bool 专业丈且丆专万不丁(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄, string 丂业丕业丂丅丙一丛, out int 丞世不丒下上上丝丑)
        {
            丞世不丒下上上丝丑 = 0;
            if(一丗与一专丙丙丅丄 == null)
            {
                    return false;
            }
            
            var val_1 = (((PGCompany.专丟专世丅丂丁且专.__il2cppRuntimeField_typeHierarchy + (PGCompany.丙一丟与且丞丏丈一.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (一丗与一专丙丙丅丄) : 0;
            return false;
        }
        internal static PGCompany.丙一丟与且丞丏丈一 丘丌万一下丁丌丌丞(int 丞世不丒下上上丝丑, string 丂业丕业丂丅丙一丛)
        {
            return (PGCompany.丙一丟与且丞丏丈一)new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  丂业丕业丂丅丙一丛, arg1:  丞世不丒下上上丝丑));
        }
        internal static PGCompany.丆一丁丏三万丑东不 丘三丞业一丞与丛业(PGCompany.丆一丁丏三万丑东不 万丐丝一万专上且丝)
        {
            if((万丐丝一万专上且丝 - 1) <= 5)
            {
                    var val_2 = 106040476 + ((万丐丝一万专上且丝 - 1)) << 2;
                val_2 = val_2 + 106040476;
            }
            else
            {
                    if(万丐丝一万专上且丝 != 24)
            {
                    if(万丐丝一万专上且丝 == 25)
            {
                    return (PGCompany.丆一丁丏三万丑东不)3;
            }
            
                return (PGCompany.丆一丁丏三万丑东不)万丐丝一万专上且丝;
            }
            
                3 = 6;
                return (PGCompany.丆一丁丏三万丑东不)3;
            }
        
        }
        private static 三丛丗丆七丁丆上丌()
        {
            PGCompany.三丛丗丆七丁丆上丌.丛丑世丐丐且丅与东 = '_';
            PGCompany.三丛丗丆七丁丆上丌.丝东与丝丘世丏丒与 = 0;
        }
    
    }

}
