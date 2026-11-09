using UnityEngine;

namespace ProGrids
{
    public static class 丛丁三世丄丏七下丞
    {
        // Methods
        public static bool 丟不下下且业丛丄丏(UnityEngine.Transform[] 丁丑丒丛不丝三三丝, UnityEngine.Transform 丙丒七丄上与丏丙丙)
        {
            UnityEngine.Transform val_2;
            var val_3;
            var val_2 = 0;
            label_6:
            if(val_2 >= 丁丑丒丛不丝三三丝.Length)
            {
                goto label_2;
            }
            
            val_2 = 丁丑丒丛不丝三三丝[0];
            val_2 = val_2 + 1;
            if(val_2 != 丙丒七丄上与丏丙丙)
            {
                goto label_6;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_2:
            val_3 = 0;
            return (bool)val_3;
        }
        public static float 丑三下丗丆丐丆丌丞(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            业下丌下三丕丙丌下.x = (业下丌下三丕丙丌下.x + 业下丌下三丕丙丌下.x) + 业下丌下三丕丙丌下.x;
            return (float)业下丌下三丕丙丌下.x;
        }
        public static bool 丟东一丈下东业丌东(UnityEngine.Camera 业丆丆东丂与万丅不, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
        {
            var val_5;
            UnityEngine.Vector3 val_1 = 业丆丆东丂与万丅不.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z});
            if(((val_1.y >= 0f) && (val_1.x >= 0f)) && (val_1.x <= 1f))
            {
                    val_5 = ((val_1.y <= 1f) ? 1 : 0) & ((val_1.z >= 0f) ? 1 : 0);
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        internal static System.Collections.Generic.List<int> 丛世丙丂丕东专上丛(System.Collections.Generic.List<object> 专下丐丒丈万丗丟丝)
        {
            var val_4;
            var val_9;
            var val_10;
            val_9 = 专下丐丒丈万丗丟丝;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(val_9 == null)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_9;
            }
            
            List.Enumerator<T> val_2 = val_9.GetEnumerator();
            val_10 = 1152921516789140576;
            label_6:
            if(((-1836529856) & 1) == 0)
            {
                goto label_2;
            }
            
            val_1.Add(item:  System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上()));
            goto label_6;
            label_2:
            val_9 = val_1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<System.Int32>)val_9;
        }
        internal static System.Collections.Generic.List<int> 丛世丙丂丕东专上丛(System.Collections.Generic.List<string> 专下丐丒丈万丗丟丝)
        {
            var val_4;
            var val_9;
            var val_10;
            val_9 = 专下丐丒丈万丗丟丝;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(val_9 == null)
            {
                    return (System.Collections.Generic.List<System.Int32>)val_9;
            }
            
            List.Enumerator<T> val_2 = val_9.GetEnumerator();
            val_10 = 1152921519126358176;
            label_6:
            if(((-1836393280) & 1) == 0)
            {
                goto label_2;
            }
            
            val_1.Add(item:  System.Convert.ToInt32(value:  val_4.丐丏七丌丕丗业且上()));
            goto label_6;
            label_2:
            val_9 = val_1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<System.Int32>)val_9;
        }
    
    }

}
