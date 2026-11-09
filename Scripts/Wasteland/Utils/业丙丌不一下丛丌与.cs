using UnityEngine;

namespace Wasteland.Utils
{
    public class 业丙丌不一下丛丌与
    {
        // Fields
        private static UnityEngine.Vector3[] 丁且丞东丐丌万丘三;
        
        // Methods
        public static UnityEngine.Rect 丒丗丐丗丅丕丕丕下(UnityEngine.Collider 且丙与丏下丅丐世丑, UnityEngine.Camera 与业丞东丙丕且丏丈)
        {
            float val_2;
            float val_3;
            UnityEngine.Bounds val_1 = 且丙与丏下丅丐世丑.bounds;
            UnityEngine.Rect val_4 = Wasteland.Utils.业丙丌不一下丛丌与.丒丗丐丗丅丕丕丕下(业东丛丂丏下丗丘且:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}, m_Extents = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_3}}, 与业丞东丙丕且丏丈:  与业丞东丙丕且丏丈, 丕丁丂七丙下下专下:  0f);
            return new UnityEngine.Rect() {m_XMin = val_4.m_XMin, m_YMin = val_4.m_YMin, m_Width = val_4.m_Width, m_Height = val_4.m_Height};
        }
        public static UnityEngine.Rect 丒丗丐丗丅丕丕丕下(UnityEngine.Bounds 业东丛丂丏下丗丘且, UnityEngine.Camera 与业丞东丙丕且丏丈, float 丕丁丂七丙下下专下 = 0)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  丕丁丂七丙下下专下);
            UnityEngine.Rect val_3 = Wasteland.Utils.业丙丌不一下丛丌与.丒丗丐丗丅丕丕丕下(业东丛丂丏下丗丘且:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 业东丛丂丏下丗丘且.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = 业东丛丂丏下丗丘且.m_Extents.y}}, 与业丞东丙丕且丏丈:  与业丞东丙丕且丏丈, 丕丁丂七丙下下专下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height};
        }
        public static UnityEngine.Rect 丒丗丐丗丅丕丕丕下(UnityEngine.Bounds 业东丛丂丏下丗丘且, UnityEngine.Camera 与业丞东丙丕且丏丈, UnityEngine.Vector3 丕丁丂七丙下下专下)
        {
            float val_5;
            float val_6;
            float val_7;
            var val_8;
            float val_9;
            float val_10;
            val_5 = 丕丁丂七丙下下专下.x;
            UnityEngine.Vector3[] val_1 = Wasteland.Utils.业丙丌不一下丛丌与.丁与丒丈丐丌不世丝(业东丛丂丏下丗丘且:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 业东丛丂丏下丗丘且.m_Center.x}, m_Extents = new UnityEngine.Vector3() {y = 业东丛丂丏下丗丘且.m_Extents.y}});
            val_6 = 3.402823E+38f;
            val_7 = -3.402823E+38f;
            val_8 = 0;
            val_9 = val_7;
            val_10 = val_6;
            goto label_3;
            label_13:
            val_5 = 8.96831E-44f;
            UnityEngine.Vector3 val_2 = 与业丞东丙丕且丏丈.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_5, y = 0f, z = 4.656534E-34f});
            if(val_2.x < 0)
            {
                    val_6 = val_2.x;
            }
            else
            {
                    if(val_2.x > val_7)
            {
                    val_7 = val_2.x;
            }
            
            }
            
            if(val_2.y < 0)
            {
                    val_10 = val_2.y;
            }
            else
            {
                    if(val_2.y > val_9)
            {
                    val_9 = val_2.y;
            }
            
            }
            
            val_8 = 1;
            label_3:
            if(val_8 < val_1.Length)
            {
                goto label_13;
            }
            
            float val_3 = val_7 - val_6;
            float val_4 = val_9 - val_10;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        public static UnityEngine.Vector3[] 丁与丒丈丐丌不世丝(UnityEngine.Bounds 业东丛丂丏下丗丘且)
        {
            null = null;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_20 = V0.16B;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_24 = V1.16B;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_28 = V2.16B;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_2C = V0.16B;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_30 = V1.16B;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_34 = V2.16B;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_38 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_3C = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_40 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_44 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_48 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_4C = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_50 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_54 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_58 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_5C = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_60 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_64 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_68 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_6C = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_70 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_74 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_78 = 0;
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三.__unknownFiledOffset_7C = 0;
            return (UnityEngine.Vector3[])Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三;
        }
        public static UnityEngine.Rect 业丏丁不丑丐丂丁下(UnityEngine.Camera 与业丞东丙丕且丏丈, UnityEngine.Vector3 丁业下丘丅丒东丄丛, float 东丗且丅丂东专丆丗, float 丌上丅下七丟与丆下)
        {
            UnityEngine.Vector3 val_1 = 与业丞东丙丕且丏丈.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 丁业下丘丅丒东丄丛.x, y = 丁业下丘丅丒东丄丛.y, z = 丁业下丘丅丒东丄丛.z});
            float val_2 = 0.5f;
            东丗且丅丂东专丆丗 = 东丗且丅丂东专丆丗 * val_2;
            val_2 = 丌上丅下七丟与丆下 * val_2;
            val_1.x = val_1.x - 东丗且丅丂东专丆丗;
            val_1.y = val_1.y - val_2;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        public 业丙丌不一下丛丌与()
        {
        
        }
        private static 业丙丌不一下丛丌与()
        {
            Wasteland.Utils.业丙丌不一下丛丌与.丁且丞东丐丌万丘三 = new UnityEngine.Vector3[8];
        }
    
    }

}
