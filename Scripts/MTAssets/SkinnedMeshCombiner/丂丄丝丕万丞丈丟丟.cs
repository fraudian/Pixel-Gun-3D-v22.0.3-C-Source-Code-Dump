using UnityEngine;

namespace MTAssets.SkinnedMeshCombiner
{
    public class 丂丄丝丕万丞丈丟丟
    {
        // Fields
        private static UnityEngine.Color[] 世丙三丏上一丂丆业;
        private static UnityEngine.Color[] 一丑丄三七丗丕丏东;
        private static int 与丘东下丈东丛丂万;
        private static float 丗丙丘丏不丒丝丕丂;
        private static float 丑丑东与不丆世丆丂;
        private static int 七丙一丂丐丕三上丒;
        private static int 丒丈丌丄丞丝三不七;
        private static System.Threading.Mutex 丟上七丛丄丑丁三业;
        
        // Methods
        public static void 丞丁万七上丐丌世业(UnityEngine.Texture2D 丟三丟三丅专丂丄丂, int 丙一丐丗专丙丆丒且, int 七下丙丏丌专丁丙不)
        {
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丙一三丘丂丆上丕丆(丟三丟三丅专丂丄丂:  丟三丟三丅专丂丄丂, 丙一丐丗专丙丆丒且:  丙一丐丗专丙丆丒且, 七下丙丏丌专丁丙不:  七下丙丏丌专丁丙不, 七丝不与丕丆丕丈丟:  false);
        }
        public static void 业三丑上七上下三专(UnityEngine.Texture2D 丟三丟三丅专丂丄丂, int 丙一丐丗专丙丆丒且, int 七下丙丏丌专丁丙不)
        {
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丙一三丘丂丆上丕丆(丟三丟三丅专丂丄丂:  丟三丟三丅专丂丄丂, 丙一丐丗专丙丆丒且:  丙一丐丗专丙丆丒且, 七下丙丏丌专丁丙不:  七下丙丏丌专丁丙不, 七丝不与丕丆丕丈丟:  true);
        }
        private static void 丙一三丘丂丆上丕丆(UnityEngine.Texture2D 丟三丟三丅专丂丄丂, int 丙一丐丗专丙丆丒且, int 七下丙丏丌专丁丙不, bool 七丝不与丕丆丕丈丟)
        {
            int val_23;
            int val_24;
            int val_25;
            UnityEngine.Texture2D val_26;
            var val_27;
            var val_28;
            float val_29;
            object val_30;
            object val_31;
            IntPtr val_32;
            val_24 = 七下丙丏丌专丁丙不;
            val_25 = 丙一丐丗专丙丆丒且;
            val_26 = 丟三丟三丅专丂丄丂;
            val_27 = 1152921505375375360;
            int val_2 = val_24 * val_25;
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 = val_26.GetPixels();
            UnityEngine.Color[] val_3 = new UnityEngine.Color[0];
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 = val_3;
            int val_4 = val_26.width;
            if(七丝不与丕丆丕丈丟 != false)
            {
                    float val_22 = (float)val_25;
                val_22 = val_22 / ((float)val_4 - 1);
                val_22 = 1f / val_22;
                MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 = val_22;
                val_28 = public System.Int32 UnityEngine.Texture::get_height();
                float val_23 = (float)val_24;
                val_23 = val_23 / ((float)val_26.height - 1);
                val_29 = 1f / val_23;
            }
            else
            {
                    float val_24 = (float)val_4;
                val_24 = val_24 / (float)val_25;
                MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 = val_24;
                val_28 = public System.Int32 UnityEngine.Texture::get_height();
                val_29 = (float)val_26.height / (float)val_24;
            }
            
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丑丑东与不丆世丆丂 = val_29;
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 = val_26.width;
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 = val_25;
            val_30 = UnityEngine.Mathf.Min(a:  UnityEngine.SystemInfo.processorCount, b:  val_24);
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丒丈丌丄丞丝三不七 = 0;
            if(MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丟上七丛丄丑丁三业 == null)
            {
                    MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丟上七丛丄丑丁三业 = new System.Threading.Mutex(initiallyOwned:  false);
            }
            
            if(val_30 >= 2)
            {
                goto label_8;
            }
            
            丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌 val_13 = null;
            val_30 = val_13;
            val_13 = new 丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌();
            .丄且一丄丏丆丐丗与 = 0;
            .丈丝世且万世丈丌万 = val_24;
            if(七丝不与丕丆丕丈丟 == false)
            {
                goto label_9;
            }
            
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.三一下万丄且不丏且(万且万且丑丗且丌丆:  val_13);
            if(val_26 != null)
            {
                goto label_24;
            }
            
            goto label_19;
            label_8:
            int val_14 = val_30 - 1;
            val_31 = new 丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌();
            if(val_14 < 1)
            {
                goto label_12;
            }
            
            int val_26 = 0;
            int val_15 = val_24 / val_30;
            var val_25 = val_14;
            do
            {
                val_31 = new System.Object();
                .丄且一丄丏丆丐丗与 = val_26;
                .丈丝世且万世丈丌万 = val_15 + val_26;
                if(七丝不与丕丆丕丈丟 != false)
            {
                    val_32 = 1152921541503355648;
            }
            else
            {
                    val_32 = 1152921541503356672;
            }
            
                new System.Threading.ParameterizedThreadStart() = new System.Threading.ParameterizedThreadStart(object:  0, method:  val_32);
                new System.Threading.Thread(start:  new System.Threading.ParameterizedThreadStart()).Start(parameter:  new 丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌());
                val_31 = new 丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌();
                val_25 = val_25 - 1;
                val_26 = val_26 + val_15;
            }
            while(val_25 != 0);
            
            val_25 = val_25;
            val_26 = val_26;
            val_27 = 1152921505375375360;
            val_24 = val_24;
            val_23 = val_15 * val_14;
            goto label_17;
            label_9:
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丙东丞七丑东三丅专(万且万且丑丗且丌丆:  val_13);
            if(val_26 != null)
            {
                goto label_24;
            }
            
            goto label_19;
            label_12:
            val_23 = 0;
            label_17:
            val_31 = new System.Object();
            .丄且一丄丏丆丐丗与 = val_23;
            .丈丝世且万世丈丌万 = val_24;
            if(七丝不与丕丆丕丈丟 == false)
            {
                goto label_20;
            }
            
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.三一下万丄且不丏且(万且万且丑丗且丌丆:  new 丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌());
            goto label_22;
            label_20:
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丙东丞七丑东三丅专(万且万且丑丗且丌丆:  new 丂丄丝丕万丞丈丟丟.与丄与东丏丕且丆丌());
            goto label_22;
            label_23:
            System.Threading.Thread.Sleep(millisecondsTimeout:  1);
            label_22:
            if(MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丒丈丌丄丞丝三不七 < val_30)
            {
                goto label_23;
            }
            
            if(val_26 != null)
            {
                goto label_24;
            }
            
            label_19:
            label_24:
            bool val_21 = val_26.Resize(width:  val_25, height:  val_24);
            if(val_26 != null)
            {
                    val_26.SetPixels(colors:  val_3);
            }
            else
            {
                    0.SetPixels(colors:  val_3);
            }
            
            val_26.Apply();
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 = 0;
            MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 = 0;
        }
        public static void 三一下万丄且不丏且(object 万且万且丑丗且丌丆)
        {
            object val_23;
            var val_24;
            var val_25;
            float val_27;
            val_23 = 万且万且丑丗且丌丆;
            if(val_23 != null)
            {
                    val_24 = null;
                val_25 = null;
                do
            {
                val_27 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丑丑东与不丆世丆丂;
                val_25 = null;
                if(MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 >= 1)
            {
                    var val_26 = 0;
                float val_23 = (float)???;
                val_23 = val_27 * val_23;
                do
            {
                val_25 = null;
                float val_6 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * 0f;
                float val_24 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂;
                int val_7 = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28;
                if(val_7 >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_8 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + (((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28))) << 4);
                val_24 = val_24 * 0f;
                float val_10 = val_24 - (float)W28;
                if(((long)val_7 + 1) >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_11 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + (((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28)) + 1))) << 4);
                UnityEngine.Color val_12 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丁七丈三丗丁万万丂(丅丌丝丏丘专丒丘丅:  new UnityEngine.Color() {r = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28))) << 4) + 32, g = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28))) << 4) + 32 + 4, b = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28))) << 4) + 40, a = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28))) << 4) + 40 + 4}, 丘业东丕万丂丌一丙:  new UnityEngine.Color() {r = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28)) + 1))) << 4) + 32, g = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28)) + 1))) << 4) + 32 + 4, b = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28)) + 1))) << 4) + 40, a = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * W12) + W28)) + 1))) << 4) + 40 + 4}, 丙业与丙丗丝不丈东:  val_10);
                int val_13 = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28;
                if(val_13 >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_14 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + (((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28))) << 4);
                var val_15 = (long)val_13 + 1;
                val_23 = (long)val_15;
                if(val_15 >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_16 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + (((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28)) + 1))) << 4);
                UnityEngine.Color val_17 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丁七丈三丗丁万万丂(丅丌丝丏丘专丒丘丅:  new UnityEngine.Color() {r = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28))) << 4) + 32, g = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28))) << 4) + 32 + 4, b = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28))) << 4) + 40, a = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28))) << 4) + 40 + 4}, 丘业东丕万丂丌一丙:  new UnityEngine.Color() {r = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28)) + 1))) << 4) + 32, g = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28)) + 1))) << 4) + 32 + 4, b = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28)) + 1))) << 4) + 40, a = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (W12 + 1)) + W28)) + 1))) << 4) + 40 + 4}, 丙业与丙丗丝不丈东:  val_10);
                float val_25 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丑丑东与不丆世丆丂;
                val_25 = val_25 * val_23;
                val_25 = val_25 - (float)W12;
                UnityEngine.Color val_18 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丁七丈三丗丁万万丂(丅丌丝丏丘专丒丘丅:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a}, 丘业东丕万丂丌一丙:  new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.a}, 丙业与丙丗丝不丈东:  val_25);
                val_27 = val_18.r;
                if(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * (???)) + val_26) >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东.Length)
            {
                    val_24 = 0;
            }
            
                UnityEngine.Color[] val_20 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + (((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * ???) + 0))) << 4);
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * ???) + 0))) << 4).__unknownFiledOffset_20 = val_27;
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * ???) + 0))) << 4).__unknownFiledOffset_24 = val_18.g;
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * ???) + 0))) << 4).__unknownFiledOffset_28 = val_18.b;
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * ???) + 0))) << 4).__unknownFiledOffset_2C = val_18.a;
                val_26 = val_26 + 1;
            }
            while(val_26 < MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒);
            
            }
            
                var val_27 = ???;
                val_27 = val_27 + 1;
            }
            while(val_27 < (万且万且丑丗且丌丆 + 20));
            
                bool val_21 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丟上七丛丄丑丁三业.WaitOne();
                int val_28 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丒丈丌丄丞丝三不七;
                val_28 = val_28 + 1;
                MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丒丈丌丄丞丝三不七 = val_28;
                MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丟上七丛丄丑丁三业.ReleaseMutex();
                return;
            }
        
        }
        public static void 丙东丞七丑东三丅专(object 万且万且丑丗且丌丆)
        {
            var val_9;
            var val_10;
            if(万且万且丑丗且丌丆 != null)
            {
                    val_9 = null;
                do
            {
                if(MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 >= 1)
            {
                    float val_8 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丑丑东与不丆世丆丂;
                int val_9 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万;
                var val_11 = 0;
                val_8 = val_8 * (float)W21;
                val_9 = val_9 * (int)val_8;
                do
            {
                float val_10 = 0f;
                val_10 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * val_10;
                val_10 = val_10 + (float)val_9;
                if((int)val_10 >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业.Length)
            {
                    val_9 = 0;
            }
            
                UnityEngine.Color[] val_3 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + (((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * 0f) + (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丑丑东与不丆世丆丂 * W21))))) << 4);
                if(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * W21) + val_11) >= MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东.Length)
            {
                    val_9 = 0;
            }
            
                UnityEngine.Color[] val_5 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + (((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * W21) + 0))) << 4);
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * W21) + 0))) << 4).__unknownFiledOffset_20 = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * 0f) + (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (MTAssets.SkinnedMeshCom + 32;
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * W21) + 0))) << 4).__unknownFiledOffset_24 = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * 0f) + (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (MTAssets.SkinnedMeshCom + 32 + 4;
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * W21) + 0))) << 4).__unknownFiledOffset_28 = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * 0f) + (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (MTAssets.SkinnedMeshCom + 40;
                (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.一丑丄三七丗丕丏东 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒 * W21) + 0))) << 4).__unknownFiledOffset_2C = (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.世丙三丏上一丂丆业 + ((long)(int)(((MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丗丙丘丏不丒丝丕丂 * 0f) + (MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.与丘东下丈东丛丂万 * (MTAssets.SkinnedMeshCom + 40 + 4;
                val_11 = val_11 + 1;
            }
            while(val_11 < MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.七丙一丂丐丕三上丒);
            
            }
            
                val_10 = W21 + 1;
            }
            while(val_10 < (万且万且丑丗且丌丆 + 20));
            
                bool val_6 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丟上七丛丄丑丁三业.WaitOne();
                int val_12 = MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丒丈丌丄丞丝三不七;
                val_12 = val_12 + 1;
                MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丒丈丌丄丞丝三不七 = val_12;
                MTAssets.SkinnedMeshCombiner.丂丄丝丕万丞丈丟丟.丟上七丛丄丑丁三业.ReleaseMutex();
                return;
            }
        
        }
        private static UnityEngine.Color 丁七丈三丗丁万万丂(UnityEngine.Color 丅丌丝丏丘专丒丘丅, UnityEngine.Color 丘业东丕万丂丌一丙, float 丙业与丙丗丝不丈东)
        {
            丘业东丕万丂丌一丙.r = 丘业东丕万丂丌一丙.r - 丅丌丝丏丘专丒丘丅.r;
            丘业东丕万丂丌一丙.g = 丘业东丕万丂丌一丙.g - 丅丌丝丏丘专丒丘丅.g;
            丘业东丕万丂丌一丙.b = 丘业东丕万丂丌一丙.b - 丅丌丝丏丘专丒丘丅.b;
            丘业东丕万丂丌一丙.a = 丘业东丕万丂丌一丙.a - 丅丌丝丏丘专丒丘丅.a;
            丘业东丕万丂丌一丙.r = 丘业东丕万丂丌一丙.r * 丙业与丙丗丝不丈东;
            丘业东丕万丂丌一丙.g = 丘业东丕万丂丌一丙.g * 丙业与丙丗丝不丈东;
            丘业东丕万丂丌一丙.b = 丘业东丕万丂丌一丙.b * 丙业与丙丗丝不丈东;
            丘业东丕万丂丌一丙.a = 丘业东丕万丂丌一丙.a * 丙业与丙丗丝不丈东;
            丅丌丝丏丘专丒丘丅.r = 丅丌丝丏丘专丒丘丅.r + 丘业东丕万丂丌一丙.r;
            丅丌丝丏丘专丒丘丅.g = 丅丌丝丏丘专丒丘丅.g + 丘业东丕万丂丌一丙.g;
            丅丌丝丏丘专丒丘丅.b = 丅丌丝丏丘专丒丘丅.b + 丘业东丕万丂丌一丙.b;
            丅丌丝丏丘专丒丘丅.a = 丅丌丝丏丘专丒丘丅.a + 丘业东丕万丂丌一丙.a;
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public 丂丄丝丕万丞丈丟丟()
        {
        
        }
    
    }

}
