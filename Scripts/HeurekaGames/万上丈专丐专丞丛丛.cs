using UnityEngine;

namespace HeurekaGames
{
    public static class 万上丈专丐专丞丛丛
    {
        // Methods
        public static UnityEngine.Vector2 丂丄东丐丕下丆丐丂(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  业下丌下三丕丙丌下.x, y:  业下丌下三丕丙丌下.z);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public static UnityEngine.Vector2[] 丂丄东丐丕下丆丐丂(UnityEngine.Vector3[] 业下丌下三丕丙丌下)
        {
            int val_3;
            UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[0];
            val_3 = 业下丌下三丕丙丌下.Length;
            if(val_3 < 1)
            {
                    return val_1;
            }
            
            do
            {
                if(0 >= val_3)
            {
                    val_3 = 业下丌下三丕丙丌下.Length;
            }
            
                var val_2 = 业下丌下三丕丙丌下 + (0 * 12);
                var val_3 = 业下丌下三丕丙丌下 + (0 * 12);
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  (0 * 12) + 业下丌下三丕丙丌下 + 32, y:  (0 * 12) + 业下丌下三丕丙丌下 + 40);
                val_1[0] = val_4.x;
                val_1[0] = val_4.y;
            }
            while((0 + 1) < 业下丌下三丕丙丌下.Length);
            
            return val_1;
        }
        public static float 丙丟万丛丗丘下丄丈(float 丙业与丙丗丝不丈东, float 东万丛丐丌丗丏丒丒, float 专三丄丕一丄下丒丅, float 丆丄丕七丆七三一丞, float 专丘与三丑丌不丐与)
        {
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东 - 东万丛丐丌丗丏丒丒;
            东万丛丐丌丗丏丒丒 = 专三丄丕一丄下丒丅 - 东万丛丐丌丗丏丒丒;
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东 / 东万丛丐丌丗丏丒丒;
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东 * (专丘与三丑丌不丐与 - 丆丄丕七丆七三一丞);
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东 + 丆丄丕七丆七三一丞;
            return (float)丙业与丙丗丝不丈东;
        }
        public static string 且丗专丗三丆不丟一(string 丄丙上丁丌丑丅丑丁)
        {
            string val_1 = System.Text.RegularExpressions.Regex.Replace(input:  丄丙上丁丌丑丅丑丁, pattern:  "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", replacement:  "$1 ");
            if(val_1 != null)
            {
                    return val_1.Trim();
            }
            
            return val_1.Trim();
        }
        public static void 七丝丛丘业丒丒丅东<T>(UnityEngine.GameObject 下丐三丆丝与不丗丕, bool 上丌丗丆丙丑与丂丑)
        {
            bool val_6;
            var val_7;
            val_6 = 上丌丗丆丙丑与丂丑;
            bool val_1 = val_6;
            val_7 = 0;
            goto label_15;
            label_29:
            System.Reflection.PropertyInfo val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 8}).GetProperty(name:  "enabled");
            if(((System.Reflection.PropertyInfo.op_Inequality(left:  0, right:  val_3)) != false) && ((val_3 & 1) != 0))
            {
                
            }
            else
            {
                    System.Console.WriteLine(value:  "BLABLA");
                UnityEngine.Debug.Log(message:  "Property does not exist, or cannot write");
            }
            
            val_7 = 1;
            label_15:
            if(val_7 < (__RuntimeMethodHiddenParam + 48))
            {
                goto label_29;
            }
        
        }
        public static void 与东且丅丝不丕三丌<T>(System.Collections.Generic.List<T> 丛一专业丗万业丆上)
        {
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public static bool 与丁世万七丆丝丝七<T>(System.Enum 丁丅丈丌丟世丗丗丟, T 丙业与丙丗丝不丈东)
        {
            return (bool)((1152921504628731904 & mem[丁丅丈丌丟世丗丗丟]) == null) ? 1 : 0;
        }
        public static bool 丙万且丒万丘上东万<T>(System.Enum 丁丅丈丌丟世丗丗丟, T 丙业与丙丗丝不丈东)
        {
            return (bool)(mem[丁丅丈丌丟世丗丗丟] == null) ? 1 : 0;
        }
        public static T 业丏丗丐丂业东丂丗<T>(System.Enum 丁丅丈丌丟世丗丗丟, T 丙业与丙丗丝不丈东)
        {
            var val_3;
            object val_1 = 1152921504628731904 | mem[丁丅丈丌丟世丗丗丟];
            if(val_1 != 0)
            {
                    val_3 = val_1;
                if(val_1 != 0)
            {
                    return (object)val_3;
            }
            
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        public static T Remove<T>(System.Enum 丁丅丈丌丟世丗丗丟, T 丙业与丙丗丝不丈东)
        {
            var val_3;
            object val_1 = mem[丁丅丈丌丟世丗丗丟] & (~1152921504628731904);
            if(val_1 != 0)
            {
                    val_3 = val_1;
                if(val_1 != 0)
            {
                    return (object)val_3;
            }
            
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        public static UnityEngine.Color 丂不丅丐丗不丏丑三(UnityEngine.Color 丑丞丈丗丄丙丟万丄, float 与专丌丅丙上丌一丄)
        {
            return new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 与专丌丅丙上丌一丄};
        }
    
    }

}
