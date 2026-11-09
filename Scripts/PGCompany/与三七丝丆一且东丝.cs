using UnityEngine;

namespace PGCompany
{
    internal static class 与三七丝丆一且东丝
    {
        // Methods
        public static System.Collections.IEnumerator 一丏丕丅丐丑且丏丐(float 丂三丟丂丈丐丆丗丟, float 丕丕世且下一与丝与, System.Action<float> 丄丙丞丁世上丄与与, System.Action 丄丆丙业世丏与丞丛, System.Action 丝丝万丄丏丝世三丏)
        {
            与三七丝丆一且东丝.丌七丕丒与上丕下万 val_1 = new 与三七丝丆一且东丝.丌七丕丒与上丕下万();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
                .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
                .丄丙丞丁世上丄与与 = 丄丙丞丁世上丄与与;
                .丄丆丙业世丏与丞丛 = 丄丆丙业世丏与丞丛;
            }
            else
            {
                    mem[48] = 丂三丟丂丈丐丆丗丟;
                mem[32] = 丕丕世且下一与丝与;
                mem[56] = 丄丙丞丁世上丄与与;
                mem[64] = 丄丆丙业世丏与丞丛;
            }
            
            .丝丝万丄丏丝世三丏 = 丝丝万丄丏丝世三丏;
            return (System.Collections.IEnumerator)val_1;
        }
        public static float 丈世丙丅万丁下丌丒(float 丆丛丑世下一丐且丕, float 丌丗丏丏丛东专丁且, float 丙丒七丄上与丏丙丙)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  丙丒七丄上与丏丙丙);
            float val_2 = val_1 * val_1;
            val_1 = val_2 - val_1;
            val_1 = val_1 + val_1;
            float val_3 = 1f;
            val_1 = val_1 + val_3;
            val_3 = val_2 / val_1;
            return UnityEngine.Mathf.Lerp(a:  丆丛丑世下一丐且丕, b:  丌丗丏丏丛东专丁且, t:  val_3);
        }
        public static UnityEngine.Color 丈世丙丅万丁下丌丒(UnityEngine.Color 丆丛丑世下一丐且丕, UnityEngine.Color 丌丗丏丏丛东专丁且, float 丙丒七丄上与丏丙丙)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  丙丒七丄上与丏丙丙);
            float val_2 = val_1 * val_1;
            val_1 = val_2 - val_1;
            val_1 = val_1 + val_1;
            val_1 = val_1 + 1f;
            val_1 = val_2 / val_1;
            return UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 丆丛丑世下一丐且丕.r, g = 丆丛丑世下一丐且丕.g, b = 丆丛丑世下一丐且丕.b, a = 丆丛丑世下一丐且丕.a}, b:  new UnityEngine.Color() {r = 丌丗丏丏丛东专丁且.r, g = 丌丗丏丏丛东专丁且.g, b = 丌丗丏丏丛东专丁且.b, a = 丌丗丏丏丛东专丁且.a}, t:  val_1);
        }
    
    }

}
