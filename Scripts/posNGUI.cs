using UnityEngine;
public class posNGUI : MonoBehaviour
{
    // Fields
    private static UIRoot 丙丗丒专专且丆丕东;
    internal static float 丕下丑三上丐专上丈;
    internal static float 丌丙丑业丂丌丆万世;
    internal static float 丛丗丟丂三业丝丅丆;
    
    // Methods
    private void Awake()
    {
        posNGUI.丙丗丒专专且丆丕东 = this.GetComponent<UIRoot>();
        float val_10 = 768f;
        val_10 = (float)UnityEngine.Screen.height * val_10;
        val_10 = val_10 / (float)UnityEngine.Screen.width;
        posNGUI.丌丙丑业丂丌丆万世 = (float)UnityEngine.Mathf.Min(a:  86, b:  UnityEngine.Mathf.RoundToInt(f:  val_10));
        int val_11 = posNGUI.丌丙丑业丂丌丆万世;
        val_11 = 2f / val_11;
        posNGUI.丕下丑三上丐专上丈 = val_11;
        UnityEngine.Vector3 val_7 = posNGUI.丙丗丒专专且丆丕东.transform.position;
        posNGUI.丛丗丟丂三业丝丅丆 = val_7.y;
        posNGUI.丙丗丒专专且丆丕东.gameObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static UnityEngine.Vector3 东上丌丙丘专七丕丒(UnityEngine.Vector3 丗丗七七丘丌丟业丛)
    {
        float val_3 = 丗丗七七丘丌丟业丛.x;
        float val_2 = -384f;
        val_2 = val_3 + val_2;
        val_3 = val_2 * posNGUI.丕下丑三上丐专上丈;
        float val_1 = posNGUI.丒世丁万丏丅丌不丛(丅丘丏丆丟丗与丅不:  丗丗七七丘丌丟业丛.y);
        丗丗七七丘丌丟业丛.z = 丗丗七七丘丌丟业丛.z * posNGUI.丕下丑三上丐专上丈;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static float 丆丗丞丗上一业丄专(float 丐丗丌丞丂世丙丏丅)
    {
        float val_1 = -384f;
        val_1 = 丐丗丌丞丂世丙丏丅 + val_1;
        val_1 = val_1 * posNGUI.丕下丑三上丐专上丈;
        return (float)val_1;
    }
    internal static float 丒世丁万丏丅丌不丛(float 丅丘丏丆丟丗与丅不)
    {
        float val_1 = posNGUI.丌丙丑业丂丌丆万世;
        val_1 = val_1 * 0.5f;
        val_1 = val_1 - 丅丘丏丆丟丗与丅不;
        val_1 = posNGUI.丕下丑三上丐专上丈 * val_1;
        val_1 = posNGUI.丛丗丟丂三业丝丅丆 + val_1;
        return (float)val_1;
    }
    internal static UnityEngine.Vector3 业一丁丛丟世丘丆东(UnityEngine.Vector3 且丈七丈三丙丙且丐)
    {
        float val_1 = posNGUI.丕下丑三上丐专上丈;
        且丈七丈三丙丙且丐.x = 且丈七丈三丙丙且丐.x * val_1;
        且丈七丈三丙丙且丐.y = 且丈七丈三丙丙且丐.y * val_1;
        val_1 = 且丈七丈三丙丙且丐.z * val_1;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static float 与丁且丆上丟三丝丌(float 丟丌丌丑丘丁丌丆丂)
    {
        float val_1 = posNGUI.丕下丑三上丐专上丈;
        val_1 = val_1 * 丟丌丌丑丘丁丌丆丂;
        return (float)val_1;
    }
    internal static float 上一丌世下丛丆东七(float 上世不三丆丑世丙且)
    {
        float val_1 = posNGUI.丕下丑三上丐专上丈;
        val_1 = val_1 * 上世不三丆丑世丙且;
        return (float)val_1;
    }
    internal static UnityEngine.Vector3 三丅丅一专丑丒丂丗(float 丛业丞丑专一专下业)
    {
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal static void 丘下丈业专下不丏不(UnityEngine.GameObject 业世业丏且七丈丄丒)
    {
        float val_2 = 2f;
        val_2 = posNGUI.丌丙丑业丂丌丆万世 + val_2;
        业世业丏且七丈丄丒.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public posNGUI()
    {
    
    }

}
