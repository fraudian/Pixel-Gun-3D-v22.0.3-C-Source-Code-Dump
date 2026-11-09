using UnityEngine;
public static class 万丗丅且丄丑世专与
{
    // Methods
    public static float 下下丑丆下世东丏三(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丞上与七且与七三丐)
    {
        float val_1 = 1f;
        val_1 = val_1 - 丞上与七且与七三丐;
        丈丗与丞一上且上上 = val_1 * 丈丗与丞一上且上上;
        专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下 * 丞上与七且与七三丐;
        丈丗与丞一上且上上 = 专丂丕丗丗东世丞下 + 丈丗与丞一上且上上;
        return (float)丈丗与丞一上且上上;
    }
    public static int 丆丄世丁丁丕丛丞丛(int 下下丏一丙不丘丌丞, int 七丝东丛东丝且丆不)
    {
        if((下下丏一丙不丘丌丞 & 2147483648) != 0)
        {
                return 0;
        }
        
        return (int)(下下丏一丙不丘丌丞 >= 七丝东丛东丝且丆不) ? (七丝东丛东丝且丆不 - 1) : 下下丏一丙不丘丌丞;
    }
    public static int 与丗丝丒丈丄不与且(int 下下丏一丙不丘丌丞, int 七丝东丛东丝且丆不)
    {
        if(七丝东丛东丝且丆不 < 1)
        {
                return 0;
        }
        
        do
        {
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 七丝东丛东丝且丆不;
        }
        while((((-七丝东丛东丝且丆不) + 下下丏一丙不丘丌丞) & 2147483648) != 0);
        
        do
        {
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 - 七丝东丛东丝且丆不;
        }
        while(下下丏一丙不丘丌丞 >= 七丝东丛东丝且丆不);
        
        return (int)下下丏一丙不丘丌丞;
    }
    public static float 且三且不与东丟七丐(float 一不丅与丟丌丏丟东)
    {
        if(一不丅与丟丌丏丟东 > 180f)
        {
                do
        {
            一不丅与丟丌丏丟东 = 一不丅与丟丌丏丟东 + (-360f);
        }
        while(一不丅与丟丌丏丟东 > 180f);
        
        }
        
        if(一不丅与丟丌丏丟东 >= 0)
        {
                return 一不丅与丟丌丏丟东;
        }
        
        do
        {
            一不丅与丟丌丏丟东 = 一不丅与丟丌丏丟东 + 360f;
        }
        while(一不丅与丟丌丏丟东 < 0);
        
        return 一不丅与丟丌丏丟东;
    }
    public static float 与业丑专丂三丒丙七(float 下下丏一丙不丘丌丞)
    {
        float val_2 = (float)UnityEngine.Mathf.FloorToInt(f:  下下丏一丙不丘丌丞);
        val_2 = 下下丏一丙不丘丌丞 - val_2;
        return (float)val_2;
    }
    public static int 且丙丆世丏与万丝丞(char 丕上丙丝丅丛丐丏丑)
    {
        char val_1 = 丕上丙丝丅丛丐丏丑 & 65535;
        val_1 = val_1 - 48;
        if(val_1 > '6')
        {
                return 15;
        }
        
        var val_2 = 106022224;
        val_2 = (106022224 + (((丕上丙丝丅丛丐丏丑 & 65535) - 48)) << 2) + val_2;
        goto (106022224 + (((丕上丙丝丅丛丐丏丑 & 65535) - 48)) << 2 + 106022224);
    }
    public static char 世丝丁丞万一七上丆(int 丙丐一丕丗万丁下一)
    {
        if(丙丐一丕丗万丁下一 > 15)
        {
                return 70;
        }
        
        if(丙丐一丕丗万丁下一 <= 9)
        {
                丙丐一丕丗万丁下一 = 丙丐一丕丗万丁下一 + 48;
            return (char)丙丐一丕丗万丁下一;
        }
        
        丙丐一丕丗万丁下一 = 丙丐一丕丗万丁下一 + 55;
        return (char)丙丐一丕丗万丁下一;
    }
    public static string 丑丕丑且三丛丁丟丒(int 丙丐一丕丗万丁下一)
    {
        return (string)丙丐一丕丗万丁下一 & 255.ToString(format:  "X2");
    }
    public static string 且丐三七七一丝丆丙(int 丙丐一丕丗万丁下一)
    {
        return (string)丙丐一丕丗万丁下一 & 16777215.ToString(format:  "X6");
    }
    public static string 丞且丛丙下丂上丆下(int 丙丐一丕丗万丁下一)
    {
        return (string)丙丐一丕丗万丁下一.ToString(format:  "X8");
    }
    public static int 丕与丑万万七丄专世(UnityEngine.Color 丁丂专业丁丅丅丈丙)
    {
        丁丂专业丁丅丅丈丙.r = 丁丂专业丁丅丅丈丙.r * 255f;
        int val_7 = UnityEngine.Mathf.RoundToInt(f:  丁丂专业丁丅丅丈丙.a * 255f);
        int val_8 = (UnityEngine.Mathf.RoundToInt(f:  丁丂专业丁丅丅丈丙.g * 255f)) << 16;
        val_8 = val_8 | ((UnityEngine.Mathf.RoundToInt(f:  丁丂专业丁丅丅丈丙.r)) << 24);
        val_8 = val_8 | ((UnityEngine.Mathf.RoundToInt(f:  丁丂专业丁丅丅丈丙.b * 255f)) << 8);
        val_7 = val_8 | val_7;
        return (int)val_7;
    }
    public static UnityEngine.Color 丈不丐万下丟上丝不(int 下下丏一丙不丘丌丞)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        float val_4 = (float)下下丏一丙不丘丌丞 >> 24;
        float val_7 = 0.003921569f;
        float val_5 = (float)(uint)(下下丏一丙不丘丌丞 >> 16) & 255;
        float val_6 = (float)(uint)(下下丏一丙不丘丌丞 >> 8) & 255;
        val_4 = val_4 * val_7;
        val_5 = val_5 * val_7;
        val_6 = val_6 * val_7;
        val_7 = ((float)下下丏一丙不丘丌丞 & 255) * val_7;
        return new UnityEngine.Color() {r = val_4, g = val_5, b = val_6, a = val_7};
    }
    public static string 丒下丝且一东丌丈丂(int 下下丏一丙不丘丌丞, int 业丟专丈专七下丕丑)
    {
        var val_6;
        string val_7;
        string val_8;
        var val_9;
        val_6 = 业丟专丈专七下丕丑;
        val_7 = "";
        if(val_6 < 1)
        {
                return (string)val_9;
        }
        
        do
        {
            if(val_6 <= 24)
        {
                int val_1 = 1 << val_6;
            val_1 = val_1 & 16843008;
            if(val_1 != 0)
        {
                val_8 = val_7 + " ";
        }
        
        }
        
            int val_3 = val_6 - 1;
            val_3 = val_3 & 31;
            val_3 = 1 << val_3;
            val_6 = val_6 - 1;
            val_9 = val_8 + (val_3 != 下下丏一丙不丘丌丞) ? (48 + 1) : 48((val_3 != 下下丏一丙不丘丌丞) ? (48 + 1) : 48);
        }
        while(val_3 > 下下丏一丙不丘丌丞);
        
        return (string)val_9;
    }
    public static UnityEngine.Color 丕丂丒一丒不丒东丘(uint 下下丏一丙不丘丌丞)
    {
        return 万丗丅且丄丑世专与.丈不丐万下丟上丝不(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞);
    }
    public static UnityEngine.Rect 不丟丌丙丞业丏万丂(UnityEngine.Rect 丝丆丏丕丕丕丗丛业, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一)
    {
        float val_2;
        float val_3;
        float val_4;
        if(业与三万七丝不万东 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = val_2, m_Width = val_3, m_Height = val_4};
        }
        
        if(丟丌丐丘丆丙丑丑一 == 0)
        {
                return new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = val_2, m_Width = val_3, m_Height = val_4};
        }
        
        float val_1 = 丝丆丏丕丕丕丗丛业.m_XMin.System.IConvertible.ToSingle(provider:  0);
        val_1 = val_1 / (float)业与三万七丝不万东;
        val_1 = val_1 / (float)业与三万七丝不万东;
        val_1 = val_1 / (float)丟丌丐丘丆丙丑丑一;
        val_1 = 1f - val_1;
        val_1 = val_1 / (float)丟丌丐丘丆丙丑丑一;
        val_1 = 1f - val_1;
        return new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = val_2, m_Width = val_3, m_Height = val_4};
    }
    public static UnityEngine.Rect 与且万东一丕且丄丆(UnityEngine.Rect 丝丆丏丕丕丕丗丛业, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一, bool 丟东丝专丒丒且不且)
    {
        float val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_1 = 丝丆丏丕丕丕丗丛业.m_XMin.System.IConvertible.ToSingle(provider:  0);
        if(丟东丝专丒丒且不且 != false)
        {
                val_1 = val_1 * (float)业与三万七丝不万东;
            float val_9 = (float)UnityEngine.Mathf.RoundToInt(f:  val_1);
            val_9 = val_9 * (float)业与三万七丝不万东;
            float val_10 = (float)UnityEngine.Mathf.RoundToInt(f:  val_9);
            val_9 = 1f;
            val_10 = val_9 - val_10;
            val_10 = val_10 * (float)丟丌丐丘丆丙丑丑一;
            float val_11 = (float)UnityEngine.Mathf.RoundToInt(f:  val_10);
            val_11 = val_9 - val_11;
            val_11 = val_11 * (float)丟丌丐丘丆丙丑丑一;
            int val_5 = UnityEngine.Mathf.RoundToInt(f:  val_11);
        }
        else
        {
                val_1 = val_1 * (float)业与三万七丝不万东;
            val_1 = val_1 * (float)业与三万七丝不万东;
            val_9 = 1f;
            val_1 = val_9 - val_1;
            val_1 = val_1 * (float)丟丌丐丘丆丙丑丑一;
            val_1 = val_9 - val_1;
            val_1 = val_1 * (float)丟丌丐丘丆丙丑丑一;
        }
        
        return new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = val_6, m_Width = val_7, m_Height = val_8};
    }
    public static UnityEngine.Rect 丛丁丝丙丑丆丗丑业(UnityEngine.Rect 丝丆丏丕丕丕丗丛业)
    {
        int val_5 = UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Mathf.RoundToInt(f:  丝丆丏丕丕丕丗丛业.m_XMin.System.IConvertible.ToSingle(provider:  0)))));
        return new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = 丝丆丏丕丕丕丗丛业.m_YMin, m_Width = 丝丆丏丕丕丕丗丛业.m_Width, m_Height = 丝丆丏丕丕丕丗丛业.m_Height};
    }
    public static UnityEngine.Rect 丛丁丝丙丑丆丗丑业(UnityEngine.Rect 丝丆丏丕丕丕丗丛业, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一)
    {
        UnityEngine.Rect val_1 = 万丗丅且丄丑世专与.与且万东一丕且丄丆(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = 丝丆丏丕丕丕丗丛业.m_XMin, m_YMin = 丝丆丏丕丕丕丗丛业.m_YMin, m_Width = 丝丆丏丕丕丕丗丛业.m_Width, m_Height = 丝丆丏丕丕丕丗丛业.m_Height}, 业与三万七丝不万东:  业与三万七丝不万东, 丟丌丐丘丆丙丑丑一:  丟丌丐丘丆丙丑丑一, 丟东丝专丒丒且不且:  true);
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Mathf.RoundToInt(f:  (float)UnityEngine.Mathf.RoundToInt(f:  val_1.m_XMin.System.IConvertible.ToSingle(provider:  0)))));
        UnityEngine.Rect val_7 = 万丗丅且丄丑世专与.不丟丌丙丞业丏万丂(丝丆丏丕丕丕丗丛业:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, 业与三万七丝不万东:  业与三万七丝不万东, 丟丌丐丘丆丙丑丑一:  丟丌丐丘丆丙丑丑一);
        return new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height};
    }
    public static UnityEngine.Vector2 且丒丝不且与业与且(UnityEngine.Vector2 上丑丗丞业丛丟丂丄, UnityEngine.Vector2 业丒世丙七丁丝上三, UnityEngine.Vector2 专丐丑且丌丒丛丝丕, UnityEngine.Vector2 丈万专不世且丅不丑)
    {
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        val_10 = 丈万专不世且丅不丑.y;
        val_11 = 丈万专不世且丅不丑.x;
        val_12 = 专丐丑且丌丒丛丝丕.y;
        val_13 = 专丐丑且丌丒丛丝丕.x;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        float val_2 = 业丒世丙七丁丝上三.x - 上丑丗丞业丛丟丂丄.x;
        float val_3 = val_11 - val_13;
        float val_4 = 业丒世丙七丁丝上三.y - 上丑丗丞业丛丟丂丄.y;
        float val_5 = val_10 - val_12;
        if(val_2 > val_3)
        {
                val_2 = val_2 - val_3;
            val_13 = val_13 - val_2;
            val_11 = val_11 + val_2;
        }
        
        if(val_4 > val_5)
        {
                val_4 = val_4 - val_5;
            val_12 = val_12 - val_4;
            val_10 = val_10 + val_4;
        }
        
        float val_6 = val_13 - 上丑丗丞业丛丟丂丄.x;
        val_6 = val_1.x + val_6;
        float val_7 = 业丒世丙七丁丝上三.x - val_11;
        val_1.x = (上丑丗丞业丛丟丂丄.x < 0) ? (val_6) : val_1.x;
        float val_8 = val_12 - 上丑丗丞业丛丟丂丄.y;
        val_7 = val_1.x - val_7;
        val_8 = val_1.y + val_8;
        val_1.x = (业丒世丙七丁丝上三.x > val_11) ? (val_7) : (val_1.x);
        float val_9 = 业丒世丙七丁丝上三.y - val_10;
        val_1.y = (上丑丗丞业丛丟丂丄.y < 0) ? (val_8) : val_1.y;
        val_9 = val_1.y - val_9;
        val_1.y = (业丒世丙七丁丝上三.y > val_10) ? (val_9) : (val_1.y);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    public static UnityEngine.Bounds 与丙丛丞丈业世丒丁(UnityEngine.Transform 丄上七丟不丗丕下丟, bool 一丐丂丘专丅丟丞七 = True)
    {
        var val_18;
        var val_19;
        float val_20;
        float val_21;
        float val_22;
        UnityEngine.Bounds val_0;
        if(丄上七丟不丗丕下丟 != 0)
        {
                if(((丄上七丟不丗丕下丟.gameObject.GetComponent<UIWidget>()) != 0) || (一丐丂丘专丅丟丞七 == true))
        {
            goto label_9;
        }
        
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        label_46:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        return val_0;
        label_9:
        UIWidget[] val_7 = new UIWidget[0];
        if(一丐丂丘专丅丟丞七 == false)
        {
            goto label_12;
        }
        
        val_18 = 丄上七丟不丗丕下丟.GetComponentsInChildren<UIWidget>();
        if(val_18 == null)
        {
            goto label_14;
        }
        
        val_19 = 0;
        goto label_22;
        label_12:
        val_18 = new UIWidget[1];
        val_19 = 0;
        val_18[0] = 丄上七丟不丗丕下丟.gameObject.GetComponent<UIWidget>();
        goto label_22;
        label_14:
        val_19 = 1;
        label_22:
        if(val_8.Length != 0)
        {
                val_20 = -3.402823E+38f;
            val_21 = val_20;
            val_22 = val_20;
            if(val_8.Length > 0)
        {
                var val_19 = 0;
            do
        {
            T val_17 = val_18[val_19];
            if(val_17.enabled != false)
        {
                var val_18 = 0;
            T val_14 = val_17 + 40;
            do
        {
            val_20 = mem[(val_8[0x0][0] + 40)];
            val_20 = val_14;
            val_22 = 0f;
            val_21 = 0f;
            val_18 = val_18 + 1;
            val_14 = val_14 + 12;
        }
        while(val_18 != 4);
        
        }
        
            val_19 = val_19 + 1;
        }
        while(val_19 != (val_8.Length & 4294967295));
        
        }
        
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            return val_0;
        }
        
        UnityEngine.Vector3 val_16 = 丄上七丟不丗丕下丟.position;
        goto label_46;
    }
    public static UnityEngine.Bounds 丌不上业三丞丕且丁(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        return 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  丄上七丟不丗丕下丟, 三丏丑不业丏不丂丈:  丄上七丟不丗丕下丟, 三世与丌丈丈丅丒三:  false, 丄丗丘丈丗丌丕丒世:  true);
    }
    public static UnityEngine.Bounds 丌不上业三丞丕且丁(UnityEngine.Transform 丄上七丟不丗丕下丟, bool 三世与丌丈丈丅丒三)
    {
        return 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  丄上七丟不丗丕下丟, 三丏丑不业丏不丂丈:  丄上七丟不丗丕下丟, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三, 丄丗丘丈丗丌丕丒世:  true);
    }
    public static UnityEngine.Bounds 丌不上业三丞丕且丁(UnityEngine.Transform 一世丛下丘东世专丈, UnityEngine.Transform 三丏丑不业丏不丂丈)
    {
        return 万丗丅且丄丑世专与.丌不上业三丞丕且丁(一世丛下丘东世专丈:  一世丛下丘东世专丈, 三丏丑不业丏不丂丈:  三丏丑不业丏不丂丈, 三世与丌丈丈丅丒三:  false, 丄丗丘丈丗丌丕丒世:  true);
    }
    public static UnityEngine.Bounds 丌不上业三丞丕且丁(UnityEngine.Transform 一世丛下丘东世专丈, UnityEngine.Transform 三丏丑不业丏不丂丈, bool 三世与丌丈丈丅丒三, bool 丄丗丘丈丗丌丕丒世 = True)
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        float val_15;
        float val_16;
        var val_17;
        UnityEngine.Bounds val_0;
        val_15 = 0;
        if((三丏丑不业丏不丂丈 != 0) && (一世丛下丘东世专丈 != 0))
        {
                bool val_10 = false;
            UnityEngine.Matrix4x4 val_3 = 一世丛下丘东世专丈.worldToLocalMatrix;
            val_15 = -3.402823E+38f;
            万丗丅且丄丑世专与.丌不上业三丞丕且丁(三丏丑不业丏不丂丈:  三丏丑不业丏不丂丈, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三, 东一不丏丗万不且丆:  true, 丐业丟丐万丘丁丙丘: ref  new UnityEngine.Matrix4x4() {m00 = val_7, m10 = val_7, m20 = val_7, m30 = val_7, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_5, m12 = val_5, m22 = val_5, m32 = val_5, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4}, 且且三丒丛丌三丒丛: ref  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丌与且丁丏且世丒业: ref  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 且丄丝且业丄丘丂丑: ref  val_10, 丄丗丘丈丗丌丕丒世:  丄丗丘丈丗丌丕丒世);
            if(val_10 != 0)
        {
                val_16 = 0f;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            val_17 = 0;
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            return val_0;
        }
        
        }
        
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        val_16 = val_12.x;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        return val_0;
    }
    private static void 丌不上业三丞丕且丁(UnityEngine.Transform 三丏丑不业丏不丂丈, bool 三世与丌丈丈丅丒三, bool 东一不丏丗万不且丆, ref UnityEngine.Matrix4x4 丐业丟丐万丘丁丙丘, ref UnityEngine.Vector3 且且三丒丛丌三丒丛, ref UnityEngine.Vector3 丌与且丁丏且世丒业, ref bool 且丄丝且业丄丘丂丑, bool 丄丗丘丈丗丌丕丒世)
    {
        UnityEngine.Object val_17;
        if(三丏丑不业丏不丂丈 == 0)
        {
                return;
        }
        
        if(三世与丌丈丈丅丒三 != true)
        {
                if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  三丏丑不业丏不丂丈.gameObject)) == false)
        {
                return;
        }
        
        }
        
        if(东一不丏丗万不且丆 != false)
        {
                val_17 = 0;
        }
        else
        {
                val_17 = 三丏丑不业丏不丂丈.GetComponent<UIPanel>();
        }
        
        if(val_17 != 0)
        {
                if(val_17.enabled == false)
        {
                return;
        }
        
        }
        
        if((val_17 != 0) && (val_17.clipping != 0))
        {
                var val_17 = 0;
            UIPanel val_9 = val_17 + 40;
            do
        {
            if(null > 丌与且丁丏且世丒业.x)
        {
                丌与且丁丏且世丒业.x = null;
        }
        
            if(null > 丌与且丁丏且世丒业.y)
        {
                丌与且丁丏且世丒业.y = null;
        }
        
            if(null > 丌与且丁丏且世丒业.z)
        {
                丌与且丁丏且世丒业.z = null;
        }
        
            if(null < 0)
        {
                且且三丒丛丌三丒丛.x = null;
        }
        
            if(null < 0)
        {
                且且三丒丛丌三丒丛.y = null;
        }
        
            if(null < 0)
        {
                且且三丒丛丌三丒丛.z = null;
        }
        
            val_17 = val_17 + 1;
            val_9 = val_9 + 12;
            且丄丝且业丄丘丂丑 = true;
        }
        while(val_17 != 4);
        
            return;
        }
        
        UIWidget val_10 = 三丏丑不业丏不丂丈.GetComponent<UIWidget>();
        if((val_10 != 0) && (val_10.enabled != false))
        {
                var val_18 = 0;
            UIWidget val_13 = val_10 + 40;
            do
        {
            if(null > 丌与且丁丏且世丒业.x)
        {
                丌与且丁丏且世丒业.x = null;
        }
        
            if(null > 丌与且丁丏且世丒业.y)
        {
                丌与且丁丏且世丒业.y = null;
        }
        
            if(null > 丌与且丁丏且世丒业.z)
        {
                丌与且丁丏且世丒业.z = null;
        }
        
            if(null < 0)
        {
                且且三丒丛丌三丒丛.x = null;
        }
        
            if(null < 0)
        {
                且且三丒丛丌三丒丛.y = null;
        }
        
            if(null < 0)
        {
                且且三丒丛丌三丒丛.z = null;
        }
        
            val_18 = val_18 + 1;
            val_13 = val_13 + 12;
            且丄丝且业丄丘丂丑 = true;
        }
        while(val_18 != 4);
        
            if(丄丗丘丈丗丌丕丒世 == false)
        {
                return;
        }
        
        }
        
        int val_14 = 三丏丑不业丏不丂丈.childCount;
        if(val_14 < 1)
        {
                return;
        }
        
        var val_19 = 0;
        do
        {
            UnityEngine.Transform val_15 = 三丏丑不业丏不丂丈.GetChild(index:  0);
            bool val_16 = 三世与丌丈丈丅丒三;
            val_19 = val_19 + 1;
        }
        while(val_14 != val_19);
    
    }
    public static UnityEngine.Vector3 丆上专万丌万世丕丙(ref UnityEngine.Vector3 丏丄业丆业丅且丏丗, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        float val_6 = 丛上丟丌丄丗丁世与;
        float val_5 = -0.001f;
        val_5 = val_6 * val_5;
        val_6 = val_5 + 1f;
        float val_7 = 1000f;
        val_7 = 丑丗丘与丈不七东丛 * val_7;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_7);
        float val_8 = -1f;
        val_8 = val_6 + val_8;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y, z = 丏丄业丆业丅且丏丗.z}, d:  val_8 / val_6);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y, z = 丏丄业丆业丅且丏丗.z}, d:  val_6);
        丏丄业丆业丅且丏丗.x = val_4.x;
        丏丄业丆业丅且丏丗.y = val_4.y;
        丏丄业丆业丅且丏丗.z = val_4.z;
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  0.06f);
    }
    public static UnityEngine.Vector2 丆上专万丌万世丕丙(ref UnityEngine.Vector2 丏丄业丆业丅且丏丗, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        float val_6 = 丛上丟丌丄丗丁世与;
        float val_5 = -0.001f;
        val_5 = val_6 * val_5;
        val_6 = val_5 + 1f;
        float val_7 = 1000f;
        val_7 = 丑丗丘与丈不七东丛 * val_7;
        int val_1 = UnityEngine.Mathf.RoundToInt(f:  val_7);
        float val_8 = -1f;
        val_8 = val_6 + val_8;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y}, d:  val_8 / val_6);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 丏丄业丆业丅且丏丗.x, y = 丏丄业丆业丅且丏丗.y}, d:  val_6);
        丏丄业丆业丅且丏丗.x = val_4.x;
        丏丄业丆业丅且丏丗.y = val_4.y;
        return UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  0.06f);
    }
    public static float 七下丙不业一丑丞业(float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        float val_3;
        var val_4;
        var val_5;
        val_3 = 丛上丟丌丄丗丁世与;
        float val_3 = 1000f;
        val_3 = 丑丗丘与丈不七东丛 * val_3;
        val_4 = UnityEngine.Mathf.RoundToInt(f:  val_3);
        if(val_4 >= 1)
        {
                val_3 = val_3 * 0.001f;
            do
        {
            val_4 = val_4 - 1;
            val_5 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_3);
        }
        while(val_4 != 0);
        
            return (float)val_5;
        }
        
        val_5 = 0f;
        return (float)val_5;
    }
    public static float 七下丙不业一丑丞业(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        float val_3;
        float val_4;
        var val_5;
        val_3 = 丛上丟丌丄丗丁世与;
        val_4 = 丈丗与丞一上且上上;
        float val_3 = 1000f;
        val_3 = 丑丗丘与丈不七东丛 * val_3;
        val_5 = UnityEngine.Mathf.RoundToInt(f:  val_3);
        if(val_5 < 1)
        {
                return (float)val_4;
        }
        
        val_3 = val_3 * 0.001f;
        do
        {
            val_5 = val_5 - 1;
            val_4 = UnityEngine.Mathf.Lerp(a:  val_4, b:  专丂丕丗丗东世丞下, t:  val_3);
        }
        while(val_5 != 0);
        
        return (float)val_4;
    }
    public static UnityEngine.Vector2 七下丙不业一丑丞业(UnityEngine.Vector2 丈丗与丞一上且上上, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        return UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y}, b:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y}, t:  万丗丅且丄丑世专与.七下丙不业一丑丞业(丛上丟丌丄丗丁世与:  丛上丟丌丄丗丁世与, 丑丗丘与丈不七东丛:  丑丗丘与丈不七东丛));
    }
    public static UnityEngine.Vector3 七下丙不业一丑丞业(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, b:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, t:  万丗丅且丄丑世专与.七下丙不业一丑丞业(丛上丟丌丄丗丁世与:  丛上丟丌丄丗丁世与, 丑丗丘与丈不七东丛:  丑丗丘与丈不七东丛));
    }
    public static UnityEngine.Quaternion 七下丙不业一丑丞业(UnityEngine.Quaternion 丈丗与丞一上且上上, UnityEngine.Quaternion 专丂丕丗丗东世丞下, float 丛上丟丌丄丗丁世与, float 丑丗丘与丈不七东丛)
    {
        return UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z, w = 丈丗与丞一上且上上.w}, b:  new UnityEngine.Quaternion() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z, w = 专丂丕丗丗东世丞下.w}, t:  万丗丅且丄丑世专与.七下丙不业一丑丞业(丛上丟丌丄丗丁世与:  丛上丟丌丄丗丁世与, 丑丗丘与丈不七东丛:  丑丗丘与丈不七东丛));
    }
    public static float 丐一丕丄丏丐丄丈丏(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 不丝丙丌七丄上东丛)
    {
        float val_2 = 专丂丕丗丗东世丞下 - 丈丗与丞一上且上上;
        if(val_2 > 180f)
        {
                do
        {
            val_2 = val_2 + (-360f);
        }
        while(val_2 > 180f);
        
        }
        
        if(val_2 < 0)
        {
                do
        {
            val_2 = val_2 + 360f;
        }
        while(val_2 < 0);
        
        }
        
        if(System.Math.Abs(val_2) > 不丝丙丌七丄上东丛)
        {
                float val_1 = UnityEngine.Mathf.Sign(f:  val_2);
            val_2 = val_1 * 不丝丙丌七丄上东丛;
        }
        
        val_1 = val_2 + 丈丗与丞一上且上上;
        return (float)val_1;
    }
    private static float 世上丁不丕一世丘一(UnityEngine.Vector2 丅专与丒丈丗丒丘丌, UnityEngine.Vector2 丆丛丑世下一丐且丕, UnityEngine.Vector2 丌丗丏丏丛东专丁且)
    {
        float val_10;
        float val_11;
        float val_12;
        float val_15;
        val_10 = 丆丛丑世下一丐且丕.y;
        val_11 = 丆丛丑世下一丐且丕.x;
        val_12 = 丅专与丒丈丗丒丘丌.y;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y}, b:  new UnityEngine.Vector2() {x = val_11, y = val_10});
        val_15 = val_1.x.sqrMagnitude;
        if(val_15 == 0f)
        {
            
        }
        else
        {
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 丅专与丒丈丗丒丘丌.x, y = val_12}, b:  new UnityEngine.Vector2() {x = val_11, y = val_10});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y}, b:  new UnityEngine.Vector2() {x = val_11, y = val_10});
            val_15 = (UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, rhs:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y})) / val_15;
            if(val_15 < 0)
        {
            
        }
        else
        {
                if(val_15 > 1f)
        {
                val_11 = 丌丗丏丏丛东专丁且.x;
            val_10 = 丌丗丏丏丛东专丁且.y;
        }
        else
        {
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y}, b:  new UnityEngine.Vector2() {x = val_11, y = val_10});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(d:  val_15, a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_11, y = val_10}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            val_11 = val_8.x;
            val_10 = val_8.y;
        }
        
        }
        
            val_12 = val_12;
        }
        
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 丅专与丒丈丗丒丘丌.x, y = val_12}, b:  new UnityEngine.Vector2() {x = val_11, y = val_10});
        return (float)val_9.x;
    }
    public static float 丛不丟丞丄丛丈不上(UnityEngine.Vector2[] 上丘丒丏丏与丝丌丐, UnityEngine.Vector2 丌丙丁丙丄丏丁世丂)
    {
        float val_13;
        var val_14;
        var val_15;
        var val_17;
        val_13 = 丌丙丁丙丄丏丁世丂.y;
        val_14 = 0;
        val_15 = -4;
        do
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 上丘丒丏丏与丝丌丐[0], y = 上丘丒丏丏与丝丌丐[0]});
            var val_2 = 4 & (~0);
            val_2 = val_2 + 3;
            val_2 = val_2 - 4;
            var val_19 = 4;
            val_2 = val_2 & 4294967292;
            val_19 = val_19 - val_2;
            var val_3 = (val_19 > 4) ? (val_19) : (val_15);
            val_3 = 4 + val_3;
            val_2 = val_3 + val_2;
            val_2 = val_2 + 4;
            val_2 = val_2 & 4294967292;
            val_2 = (4 + val_2) - val_2;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 上丘丒丏丏与丝丌丐[(long)val_2], y = 上丘丒丏丏与丝丌丐[(long)val_2]});
            if(((val_1.y > val_13) ? 1 : 0) != ((val_5.y > val_13) ? 1 : 0))
        {
                val_5.x = val_5.x - val_1.x;
            val_5.x = (val_13 - val_1.y) * val_5.x;
            val_5.y = val_5.y - val_1.y;
            val_5.x = val_5.x / val_5.y;
            val_5.x = val_1.x + val_5.x;
            if(丌丙丁丙丄丏丁世丂.x < 0)
        {
                val_14 = val_14 ^ 1;
        }
        
        }
        
        }
        while((0 + 1) != 5);
        
        val_17 = 0f;
        if((val_14 & 1) != 0)
        {
                return (float)(val_15 < 0) ? (val_15) : -1f;
        }
        
        do
        {
            val_15 = (0 + 1) & 3;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 7938.641f, y = 7938.641f});
            val_14 = 0 + 1;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 上丘丒丏丏与丝丌丐[val_15], y = 上丘丒丏丏与丝丌丐[val_15]});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_13 = val_13;
            float val_15 = 万丗丅且丄丑世专与.世上丁不丕一世丘一(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector2() {x = 丌丙丁丙丄丏丁世丂.x, y = val_13}, 丆丛丑世下一丐且丕:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        }
        while(val_14 != 4);
        
        return (float)(val_15 < 0) ? (val_15) : -1f;
    }
    public static float 丛不丟丞丄丛丈不上(UnityEngine.Vector3[] 一丈丘丏丞丂上专丆, UnityEngine.Vector2 丌丙丁丙丄丏丁世丂, UnityEngine.Camera 业丆丆东丂与万丅不)
    {
        UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[4];
        var val_4 = 0;
        do
        {
            UnityEngine.Vector3 val_2 = 业丆丆东丂与万丅不.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 7936.641f, y = 7936.641f, z = 7936.641f});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_4 = val_4 + 1;
            mem2[0] = val_3.x;
            mem2[0] = val_3.y;
        }
        while(val_4 != 4);
        
        return 万丗丅且丄丑世专与.丛不丟丞丄丛丈不上(上丘丒丏丏与丝丌丐:  val_1, 丌丙丁丙丄丏丁世丂:  new UnityEngine.Vector2() {x = 丌丙丁丙丄丏丁世丂.x, y = 丌丙丁丙丄丏丁世丂.y});
    }
    public static UnityEngine.Vector2 丄丐与世一丕与下丂(UIWidget.七丐与七丌不丂丞且 业业上丂丒丄上丗丏)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        七丐与七丌不丂丞且 val_2 = 业业上丂丒丄上丗丏 - 1;
        if(业业上丂丒丄上丗丏 > 5)
        {
                return new UnityEngine.Vector2() {x = 106022976 + ((业业上丂丒丄上丗丏 - 1)) << 2, y = 106023008 + (业业上丂丒丄上丗丏) << 2};
        }
        
        return new UnityEngine.Vector2() {x = 106022976 + ((业业上丂丒丄上丗丏 - 1)) << 2, y = 106023008 + (业业上丂丒丄上丗丏) << 2};
    }
    public static UIWidget.七丐与七丌不丂丞且 业上丟丟三丄丌丘丝(UnityEngine.Vector2 丛上丙丄丄七丈且丅)
    {
        if(丛上丙丄丄七丈且丅.x == 0f)
        {
                if(丛上丙丄丄七丈且丅.y != 0f)
        {
                return (七丐与七丌不丂丞且)(丛上丙丄丄七丈且丅.y == 1f) ? 0 : 3;
        }
        
            return 6;
        }
        
        if(丛上丙丄丄七丈且丅.x == 1f)
        {
                if(丛上丙丄丄七丈且丅.y != 0f)
        {
                return (七丐与七丌不丂丞且)(丛上丙丄丄七丈且丅.y == 1f) ? 2 : 5;
        }
        
            return 8;
        }
        
        if(丛上丙丄丄七丈且丅.y != 0f)
        {
                return (七丐与七丌不丂丞且)(丛上丙丄丄七丈且丅.y != 1f) ? 4 : (0 + 1);
        }
        
        return 7;
    }
    public static void 三丈丟丄不不三丟不(UIRect 与丘东下丈东丛丂万, float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌)
    {
        万丗丅且丄丑世专与.丕万丅与上不丂七七(丝丆丏丕丕丕丗丛业:  与丘东下丈东丛丂万, 三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑, 丒丒丄丁且丄丆丂丌:  丒丒丄丁且丄丆丂丌);
    }
    public static void 丕万丅与上不丂七七(UIRect 丝丆丏丕丕丕丗丛业, float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌)
    {
        AnchorPoint val_15;
        int val_16;
        var val_17;
        AnchorPoint val_18;
        int val_19;
        AnchorPoint val_20;
        int val_21;
        UnityEngine.Transform val_22;
        int val_23;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑 + 0.5f;
        int val_1 = UnityEngine.Mathf.FloorToInt(f:  三丟东丕丄丄下下丑);
        int val_3 = UnityEngine.Mathf.FloorToInt(f:  丒丒丄丁且丄丆丂丌 + 0.5f);
        UnityEngine.Transform val_4 = 丝丆丏丕丕丕丗丛业.cachedTransform;
        UnityEngine.Vector3 val_5 = val_4.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_4.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        if((UnityEngine.Object.op_Implicit(exists:  丝丆丏丕丕丕丗丛业.leftAnchor.target)) == false)
        {
            goto label_12;
        }
        
        val_15 = 丝丆丏丕丕丕丗丛业.leftAnchor;
        if(val_15 == null)
        {
            goto label_13;
        }
        
        val_16 = 丝丆丏丕丕丕丗丛业.leftAnchor.absolute;
        goto label_14;
        label_12:
        val_17 = 0;
        goto label_15;
        label_13:
        val_15 = 28;
        val_16 = 0;
        label_14:
        val_17 = 1;
        mem[28] = val_16 + val_1;
        label_15:
        if((UnityEngine.Object.op_Implicit(exists:  丝丆丏丕丕丕丗丛业.rightAnchor.target)) != false)
        {
                val_18 = 丝丆丏丕丕丕丗丛业.rightAnchor;
            val_17 = val_17 + 1;
            if(val_18 != null)
        {
                val_19 = 丝丆丏丕丕丕丗丛业.rightAnchor.absolute;
        }
        else
        {
                val_18 = 28;
            val_19 = mem[28];
        }
        
            mem[28] = val_19 + val_1;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丝丆丏丕丕丕丗丛业.bottomAnchor.target)) != false)
        {
                val_20 = 丝丆丏丕丕丕丗丛业.bottomAnchor;
            val_17 = val_17 + 1;
            if(val_20 != null)
        {
                val_21 = 丝丆丏丕丕丕丗丛业.bottomAnchor.absolute;
        }
        else
        {
                val_20 = 28;
            val_21 = mem[28];
        }
        
            mem[28] = val_21 + val_3;
        }
        
        val_22 = 丝丆丏丕丕丕丗丛业.topAnchor.target;
        if((UnityEngine.Object.op_Implicit(exists:  val_22)) == false)
        {
            goto label_31;
        }
        
        val_22 = 丝丆丏丕丕丕丗丛业.topAnchor;
        if(val_22 == null)
        {
            goto label_32;
        }
        
        val_23 = 丝丆丏丕丕丕丗丛业.topAnchor.absolute;
        goto label_33;
        label_31:
        if(val_17 != 0)
        {
            goto label_34;
        }
        
        return;
        label_32:
        val_22 = 28;
        val_23 = mem[28];
        label_33:
        mem[28] = val_23 + val_3;
        label_34:
        丝丆丏丕丕丕丗丛业.UpdateAnchors();
    }
    public static void 丈丂丄一丂世丘且一(UIWidget 与丘东下丈东丛丂万, UIWidget.七丐与七丌不丂丞且 不丌丕不七丗丞万万, float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, int 上专上丛丈丆丗丒丟, int 丐丆丏丂上丒丗丌丁)
    {
        万丗丅且丄丑世专与.丈丂丄一丂世丘且一(与丘东下丈东丛丂万:  与丘东下丈东丛丂万, 不丌丕不七丗丞万万:  不丌丕不七丗丞万万, 三丟东丕丄丄下下丑:  三丟东丕丄丄下下丑, 丒丒丄丁且丄丆丂丌:  丒丒丄丁且丄丆丂丌, 上专上丛丈丆丗丒丟:  2, 丐丆丏丂上丒丗丌丁:  2, 七丏丄丄丆与丁丂丈:  100000, 丄七丗丌丂一丞丆下:  100000);
    }
    public static void 丈丂丄一丂世丘且一(UIWidget 与丘东下丈东丛丂万, UIWidget.七丐与七丌不丂丞且 不丌丕不七丗丞万万, float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, int 上专上丛丈丆丗丒丟, int 丐丆丏丂上丒丗丌丁, int 七丏丄丄丆与丁丂丈, int 丄七丗丌丂一丞丆下)
    {
        float val_12;
        int val_13;
        int val_14;
        UIWidget val_15;
        int val_16;
        int val_17;
        val_12 = 丒丒丄丁且丄丆丂丌;
        if(不丌丕不七丗丞万万 != 4)
        {
            goto label_1;
        }
        
        float val_12 = (float)与丘东下丈东丛丂万.width;
        val_12 = 三丟东丕丄丄下下丑 - val_12;
        int val_2 = UnityEngine.Mathf.RoundToInt(f:  val_12);
        float val_13 = (float)与丘东下丈东丛丂万.height;
        val_13 = val_12 - val_13;
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_13);
        if((val_4 | val_2) < 2)
        {
                return;
        }
        
        int val_6 = val_2 >> 1;
        int val_7 = val_4 >> 1;
        val_13 = 65536;
        val_13 = 1;
        val_14 = 65536;
        val_14 = 1;
        val_15 = 与丘东下丈东丛丂万;
        val_16 = 上专上丛丈丆丗丒丟;
        val_17 = 丐丆丏丂上丒丗丌丁;
        goto label_7;
        label_1:
        UnityEngine.Quaternion val_9 = 与丘东下丈东丛丂万.cachedTransform.localRotation;
        val_12 = val_9.x;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_12, y = val_9.y, z = val_9.z, w = val_9.w});
        UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(不丌丕不七丗丞万万 > 8)
        {
                return;
        }
        
        var val_14 = 106022444 + (不丌丕不七丗丞万万) << 2;
        val_14 = val_14 + 106022444;
        goto (106022444 + (不丌丕不七丗丞万万) << 2 + 106022444);
        label_7:
        万丗丅且丄丑世专与.下下业丈专丘丛丆丙(与丘东下丈东丛丂万:  null, 丈丂丕下丏丈丞丗业:  0f, 专丙丗业世丐与丝丙:  val_11.y, 丂丌丌丛丆丆丙丌丈:  val_11.x, 世丂丘万丛万丞丞丌:  0f, 上专上丛丈丆丗丒丟:  null, 丐丆丏丂上丒丗丌丁:  null, 七丏丄丄丆与丁丂丈:  null, 丄七丗丌丂一丞丆下:  null);
    }
    public static void 下下业丈专丘丛丆丙(UIWidget 与丘东下丈东丛丂万, float 丈丂丕下丏丈丞丗业, float 专丙丗业世丐与丝丙, float 丂丌丌丛丆丆丙丌丈, float 世丂丘万丛万丞丞丌)
    {
        万丗丅且丄丑世专与.下下业丈专丘丛丆丙(与丘东下丈东丛丂万:  与丘东下丈东丛丂万, 丈丂丕下丏丈丞丗业:  丈丂丕下丏丈丞丗业, 专丙丗业世丐与丝丙:  专丙丗业世丐与丝丙, 丂丌丌丛丆丆丙丌丈:  丂丌丌丛丆丆丙丌丈, 世丂丘万丛万丞丞丌:  世丂丘万丛万丞丞丌, 上专上丛丈丆丗丒丟:  2, 丐丆丏丂上丒丗丌丁:  2, 七丏丄丄丆与丁丂丈:  100000, 丄七丗丌丂一丞丆下:  100000);
    }
    public static void 下下业丈专丘丛丆丙(UIWidget 与丘东下丈东丛丂万, float 丈丂丕下丏丈丞丗业, float 专丙丗业世丐与丝丙, float 丂丌丌丛丆丆丙丌丈, float 世丂丘万丛万丞丞丌, int 上专上丛丈丆丗丒丟, int 丐丆丏丂上丒丗丌丁)
    {
        万丗丅且丄丑世专与.下下业丈专丘丛丆丙(与丘东下丈东丛丂万:  与丘东下丈东丛丂万, 丈丂丕下丏丈丞丗业:  丈丂丕下丏丈丞丗业, 专丙丗业世丐与丝丙:  专丙丗业世丐与丝丙, 丂丌丌丛丆丆丙丌丈:  丂丌丌丛丆丆丙丌丈, 世丂丘万丛万丞丞丌:  世丂丘万丛万丞丞丌, 上专上丛丈丆丗丒丟:  上专上丛丈丆丗丒丟, 丐丆丏丂上丒丗丌丁:  丐丆丏丂上丒丗丌丁, 七丏丄丄丆与丁丂丈:  100000, 丄七丗丌丂一丞丆下:  100000);
    }
    public static void 下下业丈专丘丛丆丙(UIWidget 与丘东下丈东丛丂万, float 丈丂丕下丏丈丞丗业, float 专丙丗业世丐与丝丙, float 丂丌丌丛丆丆丙丌丈, float 世丂丘万丛万丞丞丌, int 上专上丛丈丆丗丒丟, int 丐丆丏丂上丒丗丌丁, int 七丏丄丄丆与丁丂丈, int 丄七丗丌丂一丞丆下)
    {
        int val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        float val_72;
        float val_73;
        float val_74;
        float val_75;
        float val_76;
        var val_78;
        float val_79;
        float val_80;
        var val_81;
        var val_82;
        UnityEngine.Object val_83;
        float val_84;
        float val_85;
        int val_64 = 七丏丄丄丆与丁丂丈;
        val_67 = 与丘东下丈东丛丂万;
        if(val_67 != null)
        {
                UnityEngine.Vector2 val_1 = val_67.pivotOffset;
        }
        else
        {
                UnityEngine.Vector2 val_2 = 0.pivotOffset;
        }
        
        UnityEngine.Transform val_3 = val_67.cachedTransform;
        UnityEngine.Quaternion val_4 = val_3.localRotation;
        val_68 = UnityEngine.Mathf.FloorToInt(f:  丈丂丕下丏丈丞丗业 + 0.5f);
        val_69 = UnityEngine.Mathf.FloorToInt(f:  专丙丗业世丐与丝丙 + 0.5f);
        val_70 = UnityEngine.Mathf.FloorToInt(f:  丂丌丌丛丆丆丙丌丈 + 0.5f);
        val_71 = UnityEngine.Mathf.FloorToInt(f:  世丂丘万丛万丞丞丌 + 0.5f);
        if(val_2.x == 0.5f)
        {
                if(val_68 != 0)
        {
                if(val_70 != 0)
        {
            goto label_9;
        }
        
        }
        
            val_68 = val_68 & 4294967294;
            val_70 = val_70 & 4294967294;
        }
        
        label_9:
        if(val_2.y == 0.5f)
        {
                if(val_69 != 0)
        {
                if(val_71 != 0)
        {
            goto label_12;
        }
        
        }
        
            val_69 = val_69 & 4294967294;
            val_71 = val_71 & 4294967294;
        }
        
        label_12:
        UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_14 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_17 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_19 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_72 = val_4.z;
        UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_72, w = val_4.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        val_73 = val_21.x;
        val_74 = 1f;
        val_75 = val_21.y;
        if(val_2.y != val_74)
        {
            goto label_18;
        }
        
        val_76 = val_2.x;
        if(val_76 != 0f)
        {
            goto label_18;
        }
        
        val_75 = val_13.y;
        val_73 = val_13.x;
        goto label_40;
        label_18:
        if(val_2.y != 0f)
        {
            goto label_21;
        }
        
        val_76 = val_2.x;
        if(val_76 != val_74)
        {
            goto label_21;
        }
        
        val_75 = val_16.y;
        val_73 = val_16.x;
        goto label_40;
        label_21:
        if(val_2.y != 0f)
        {
            goto label_24;
        }
        
        val_76 = val_2.x;
        if(val_76 != 0f)
        {
            goto label_24;
        }
        
        val_75 = val_15.y;
        val_73 = val_15.x;
        goto label_40;
        label_24:
        if(val_2.y != val_74)
        {
            goto label_27;
        }
        
        val_76 = val_2.x;
        if(val_76 != val_74)
        {
            goto label_27;
        }
        
        val_75 = val_14.y;
        val_73 = val_14.x;
        goto label_40;
        label_27:
        if((val_2.y == 0.5f) && (val_2.x == 0f))
        {
                float val_56 = val_19.y;
            float val_22 = val_19.x + val_20.x;
            val_22 = val_22 * 0.5f;
            val_56 = val_56 + val_20.y;
            val_76 = val_56 * 0.5f;
            val_72 = val_17.x;
            val_73 = val_72 + val_22;
            val_74 = val_17.y;
            val_75 = val_74 + val_76;
        }
        else
        {
                if((val_2.y == 0.5f) && (val_2.x == val_74))
        {
                float val_57 = val_19.y;
            float val_23 = val_19.x + val_20.x;
            val_23 = val_23 * 0.5f;
            val_57 = val_57 + val_20.y;
            val_76 = val_57 * 0.5f;
            val_72 = val_18.x;
            val_73 = val_72 + val_23;
            val_74 = val_18.y;
            val_75 = val_74 + val_76;
        }
        else
        {
                val_76 = val_2.x;
            val_72 = 0.5f;
            if(val_76 == val_72)
        {
                if(val_2.y == val_74)
        {
                float val_58 = val_17.x;
            val_58 = val_58 + val_18.x;
            float val_59 = val_17.y;
            val_59 = val_59 + val_18.y;
            val_72 = 0.5f;
            val_58 = val_58 * val_72;
            val_73 = val_58 + val_19.x;
            val_74 = val_19.y;
            val_76 = val_59 * val_72;
            val_75 = val_76 + val_74;
        }
        else
        {
                if(val_2.y == 0f)
        {
                float val_60 = val_17.x;
            val_60 = val_60 + val_18.x;
            float val_61 = val_17.y;
            val_61 = val_61 + val_18.y;
            val_72 = 0.5f;
            val_74 = val_60 * val_72;
            val_76 = val_61 * val_72;
            val_73 = val_74 + val_20.x;
            val_75 = val_76 + val_20.y;
        }
        else
        {
                val_74 = 0.5f;
            if(val_2.y == val_74)
        {
                float val_62 = val_17.x;
            val_62 = val_62 + val_18.x;
            float val_63 = val_19.y;
            val_62 = val_62 + val_19.x;
            val_74 = val_62 + val_20.x;
            val_63 = val_63 + val_20.y;
            val_63 = val_17.y + val_63;
            val_76 = val_18.y + val_63;
            val_72 = 0.5f;
            val_73 = val_74 * val_72;
            val_75 = val_76 * val_72;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_40:
        int val_24 = UnityEngine.Mathf.Max(a:  上专上丛丈丆丗丒丟, b:  val_67);
        int val_25 = UnityEngine.Mathf.Max(a:  丐丆丏丂上丒丗丌丁, b:  val_67);
        int val_28 = (val_70 - val_68) + val_67.width;
        val_71 = val_71 - val_69;
        val_71 = val_71 + val_67.height;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
        var val_32 = (val_28 < val_24) ? (val_24) : ((val_28 > val_64) ? (val_64) : (val_28));
        val_79 = val_30.x;
        val_80 = val_30.y;
        val_64 = val_32 - val_28;
        if(val_28 == val_24)
        {
                val_78 = val_28;
        }
        else
        {
                if(val_68 != 0)
        {
                val_72 = val_2.x;
            val_79 = val_79 - (UnityEngine.Mathf.Lerp(a:  (float)val_64, b:  0f, t:  val_72));
        }
        else
        {
                val_72 = val_2.x;
            val_79 = val_79 + (UnityEngine.Mathf.Lerp(a:  0f, b:  (float)val_64, t:  val_72));
        }
        
        }
        
        int val_36 = (val_71 < val_25) ? (val_25) : ((val_71 > 丄七丗丌丂一丞丆下) ? 丄七丗丌丂一丞丆下 : (val_71));
        int val_37 = val_36 - val_71;
        if(val_71 == val_25)
        {
                val_82 = 1152921504838369280;
            val_81 = val_71;
        }
        else
        {
                if(val_69 != 0)
        {
                val_82 = 1152921504838369280;
            val_72 = val_2.y;
            val_80 = val_80 - (UnityEngine.Mathf.Lerp(a:  (float)val_37, b:  0f, t:  val_72));
        }
        else
        {
                val_82 = 1152921504838369280;
            val_72 = val_2.y;
            val_80 = val_80 + (UnityEngine.Mathf.Lerp(a:  0f, b:  (float)val_37, t:  val_72));
        }
        
        }
        
        int val_42 = (val_2.x == 0.5f) ? (val_32 & 4294967294) : (val_32);
        val_36 = (val_2.y == 0.5f) ? (val_36 & 4294967294) : (val_36);
        UnityEngine.Vector3 val_43 = val_3.localPosition;
        UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z}, b:  new UnityEngine.Vector3() {x = val_73, y = val_75, z = val_21.z});
        UnityEngine.Vector3 val_45 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, point:  new UnityEngine.Vector3() {x = val_79, y = val_80, z = val_30.z});
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, b:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z});
        float val_65 = val_46.x;
        val_84 = val_46.y;
        val_85 = val_46.z;
        val_3.localPosition = new UnityEngine.Vector3() {x = val_65, y = val_84, z = val_85};
        val_67.SetDimensions(与丘东下丈东丛丂万:  val_42, 一丗世三专三万丞丞:  val_36);
        if(val_67.isAnchored == false)
        {
                return;
        }
        
        UnityEngine.Transform val_48 = val_3.parent;
        val_82 = 1152921504848912384;
        val_65 = val_65 - (val_2.x * (float)val_42);
        if((UnityEngine.Object.op_Implicit(exists:  val_25 + 16)) != false)
        {
                val_25 + 16.业专丈丑业且丘一万(丈东丘丏与丌东东下:  val_48, 丈丑丑且业下丒丁丞:  val_65);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  val_25 + 16 + 16)) != false)
        {
                val_25 + 16 + 16.业专丈丑业且丘一万(丈东丘丏与丌东东下:  val_48, 丈丑丑且业下丒丁丞:  val_65 + (float)val_42);
        }
        
        val_85 = val_2.y * (float)val_36;
        val_84 = val_84 - val_85;
        if((UnityEngine.Object.op_Implicit(exists:  val_25 + 16 + 16 + 16)) != false)
        {
                val_25 + 16 + 16 + 16.丘世万丕专世东下丐(丈东丘丏与丌东东下:  val_48, 丈丑丑且业下丒丁丞:  val_84);
        }
        
        val_83 = mem[val_25 + 16 + 16 + 16 + 16];
        val_83 = val_25 + 16 + 16 + 16 + 16;
        if((UnityEngine.Object.op_Implicit(exists:  val_83)) == false)
        {
                return;
        }
        
        val_67.丘世万丕专世东下丐(丈东丘丏与丌东东下:  val_48, 丈丑丑且业下丒丁丞:  val_84 + (float)val_36);
    }
    public static int 与且丄丝丑丆世丑专(float 丟丌丐丘丆丙丑丑一)
    {
        float val_6 = UnityEngine.Screen.dpi;
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(val_6 != 0f)
        {
            goto label_4;
        }
        
        if(val_2 != 11)
        {
                if(val_2 != 8)
        {
            goto label_3;
        }
        
        }
        
        val_6 = 160f;
        goto label_4;
        label_3:
        val_6 = 96f;
        label_4:
        float val_6 = 96f;
        val_6 = val_6 / val_6;
        val_6 = val_6 * 丟丌丐丘丆丙丑丑一;
        int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_6);
        int val_4 = val_3 & 1;
        val_4 = val_4 + 7;
        return (int)((val_4 & 7) != 0) ? (val_3 + 1) : (val_3);
    }
    public static UnityEngine.Vector2 且业下丒下丆专丄丂(UnityEngine.Vector2 下业丕七东丌丝下且, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        object val_10;
        float val_11;
        float val_12;
        val_10 = 一世丛下丘东世专丈;
        val_11 = 下业丕七东丌丝下且.y;
        val_12 = 下业丕七东丌丝下且.x;
        int val_2 = val_10.gameObject.layer;
        UnityEngine.Camera val_3 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  val_2);
        if(val_3 == 0)
        {
                val_10 = "No camera found for layer " + val_2;
            UnityEngine.Debug.LogWarning(message:  val_10);
            return new UnityEngine.Vector2() {x = val_12, y = val_11};
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12, y = val_11});
        UnityEngine.Vector3 val_7 = val_3.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = val_10.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_12 = val_9.x;
        val_11 = val_9.y;
        return new UnityEngine.Vector2() {x = val_12, y = val_11};
    }
    public static UnityEngine.Vector2 且丛丁丅丅上丁丏丒(UnityEngine.Vector2 下业丕七东丌丝下且, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        object val_14;
        float val_15;
        float val_16;
        float val_20;
        float val_21;
        float val_22;
        val_14 = 一世丛下丘东世专丈;
        val_15 = 下业丕七东丌丝下且.y;
        val_16 = 下业丕七东丌丝下且.x;
        int val_2 = val_14.gameObject.layer;
        if(val_14.parent != 0)
        {
                val_14 = val_14.parent;
        }
        
        UnityEngine.Camera val_6 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  val_2);
        if(val_6 == 0)
        {
                val_14 = "No camera found for layer " + val_2;
            UnityEngine.Debug.LogWarning(message:  val_14);
            return new UnityEngine.Vector2() {x = val_16, y = val_15};
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_16, y = val_15});
        UnityEngine.Vector3 val_10 = val_6.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_20 = val_10.x;
        val_21 = val_10.y;
        val_22 = val_10.z;
        if(val_14 != 0)
        {
                UnityEngine.Vector3 val_12 = val_14.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22});
            val_20 = val_12.x;
            val_21 = val_12.y;
            val_22 = val_12.z;
        }
        
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22});
        val_16 = val_13.x;
        val_15 = val_13.y;
        return new UnityEngine.Vector2() {x = val_16, y = val_15};
    }
    public static UnityEngine.Vector3 且丟丗丕丁三与与丒(UnityEngine.Vector3 丈七东丐世丒丅丗丌, UnityEngine.Camera 丑丑丘丄丅万丁丏不, UnityEngine.Camera 丆丗与丌丞丏丙丗丂, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        UnityEngine.Object val_7;
        float val_11;
        float val_12;
        float val_13;
        val_7 = 一世丛下丘东世专丈;
        UnityEngine.Vector3 val_1 = 丑丑丘丄丅万丁丏不.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z});
        UnityEngine.Vector3 val_2 = 丆丗与丌丞丏丙丗丂.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_11 = val_2.x;
        val_12 = val_2.y;
        val_13 = val_2.z;
        if(val_7 == 0)
        {
                return new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13};
        }
        
        val_7 = val_7.parent;
        if(val_7 == 0)
        {
                return new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13};
        }
        
        UnityEngine.Vector3 val_6 = val_7.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13});
        val_11 = val_6.x;
        val_12 = val_6.y;
        val_13 = val_6.z;
        return new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13};
    }
    public static void 丙一且丕丟万丅一业(UnityEngine.Transform 丄上七丟不丗丕下丟, UnityEngine.Vector3 丈七东丐世丒丅丗丌, UnityEngine.Camera 丑丑丘丄丅万丁丏不, UnityEngine.Camera 七上与丌不丏三丌丙)
    {
        float val_9;
        float val_10;
        float val_11;
        UnityEngine.Vector3 val_1 = 丑丑丘丄丅万丁丏不.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z});
        UnityEngine.Vector3 val_2 = 七上与丌不丏三丌丙.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        val_9 = val_2.x;
        val_10 = val_2.y;
        val_11 = val_2.z;
        UnityEngine.Transform val_3 = 丄上七丟不丗丕下丟.parent;
        if(val_3 != 0)
        {
                UnityEngine.Vector3 val_5 = val_3.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11});
            val_9 = val_5.x;
            val_10 = val_5.y;
            val_11 = val_5.z;
        }
        
        丄上七丟不丗丕下丟.localPosition = new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_11};
    }
    public static void 丙一且丕丟万丅一业(UnityEngine.Transform 丄上七丟不丗丕下丟, UnityEngine.Vector3 丈七东丐世丒丅丗丌, UnityEngine.Camera 丑丑丘丄丅万丁丏不)
    {
        UnityEngine.Camera val_3 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  丄上七丟不丗丕下丟.gameObject.layer);
        if(val_3 == 0)
        {
                return;
        }
        
        万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  丄上七丟不丗丕下丟, 丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = 丈七东丐世丒丅丗丌.x, y = 丈七东丐世丒丅丗丌.y, z = 丈七东丐世丒丅丗丌.z}, 丑丑丘丄丅万丁丏不:  丑丑丘丄丅万丁丏不, 七上与丌不丏三丌丙:  val_3);
    }
    public static void 丙一且丕丟万丅一业(UnityEngine.Transform 丄上七丟不丗丕下丟, UnityEngine.Transform 丞下万上三丘上与专)
    {
        UnityEngine.Camera val_3 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  丄上七丟不丗丕下丟.gameObject.layer);
        UnityEngine.Camera val_6 = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  丞下万上三丘上与专.gameObject.layer);
        if(val_3 == 0)
        {
                return;
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_9 = 丞下万上三丘上与专.position;
        万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  丄上七丟不丗丕下丟, 丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丑丑丘丄丅万丁丏不:  val_6, 七上与丌不丏三丌丙:  val_3);
    }

}
