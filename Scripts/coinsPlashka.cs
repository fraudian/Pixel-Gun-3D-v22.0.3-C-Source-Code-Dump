using UnityEngine;
public sealed class coinsPlashka : MonoBehaviour
{
    // Fields
    internal static coinsPlashka 专丆专上丗万世丒七;
    internal static bool 三丛丙丈丙下丏丌一;
    private UnityEngine.Font 与丕丁三万专世不丅;
    private bool 丙与丟世丐七业三七;
    private bool 一丕丑业不丁丕丞丞;
    private float 丈丕且丈东不丟丆丆;
    private float 业丁丞丐丂丐丟下丕;
    public UnityEngine.Rect rectButCoins;
    public UnityEngine.Rect rectLabelCoins;
    private int 丗丞丅丙丅上丏丌业;
    
    // Properties
    internal static UnityEngine.Rect 丅丂丌丑上丕丒丕万 { get; }
    
    // Methods
    internal static UnityEngine.Rect 一万丅一丕丞丗丏与()
    {
        null = null;
        coinsPlashka.专丆专上丗万世丒七.rectLabelCoins
        float val_1 = coinsPlashka.专丆专上丗万世丒七.rectLabelCoins.x;
        coinsPlashka.专丆专上丗万世丒七.rectButCoins
        coinsPlashka.专丆专上丗万世丒七.rectButCoins
        coinsPlashka.专丆专上丗万世丒七.rectButCoins
        float val_3 = 0.x;
        float val_4 = (float)UnityEngine.Screen.width;
        val_4 = val_4 - val_3;
        val_3 = val_4 - val_3;
        0.x = val_3;
        return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
    }
    private void Awake()
    {
        var val_10 = null;
        coinsPlashka.专丆专上丗万世丒七 = this.gameObject.GetComponent<coinsPlashka>();
        coinsPlashka.专东丁丕下东上丗丟();
        this.丗丞丅丙丅上丏丌业 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌();
        this.业丁丞丐丂丐丟下丕 = UnityEngine.Time.realtimeSinceStartup;
        this.一丕丑业不丁丕丞丞 = UnityEngine.PlayerPrefs.HasKey(key:  "Achieved500");
        this.丙与丟世丐七业三七 = UnityEngine.PlayerPrefs.HasKey(key:  "Achieved1000");
    }
    internal static void 东丐上下一东丌丐专()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(coinsPlashka.专丆专上丗万世丒七 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        coinsPlashka.专丆专上丗万世丒七.enabled = true;
    }
    internal static void 专东丁丕下东上丗丟()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(coinsPlashka.专丆专上丗万世丒七 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        coinsPlashka.专丆专上丗万世丒七.enabled = false;
    }
    private void Update()
    {
        int val_8;
        var val_9;
        System.Action<System.Boolean> val_11;
        var val_12;
        var val_8 = 0;
        val_8 = val_8 + 1;
        if(UnityEngine.Social.localUser.authenticated == false)
        {
                return;
        }
        
        int val_4 = UnityEngine.Time.frameCount;
        var val_9 = 0;
        val_9 = val_9 + val_4;
        val_9 = (val_9 >> 5) + (val_9 >> 31);
        val_9 = val_4 - (val_9 * 60);
        if(val_9 != 23)
        {
                return;
        }
        
        val_8 = this.丗丞丅丙丅上丏丌业;
        if(val_8 < 500)
        {
                return;
        }
        
        if(this.一丕丑业不丁丕丞丞 != true)
        {
                val_9 = null;
            val_9 = null;
            val_11 = coinsPlashka.<>c.<>9__15_0;
            if(val_11 == null)
        {
                System.Action<System.Boolean> val_6 = null;
            val_11 = val_6;
            val_6 = new System.Action<System.Boolean>(object:  coinsPlashka.<>c.__il2cppRuntimeField_static_fields, method:  System.Void coinsPlashka.<>c::七丅丈下丕丏丄丞万(bool 丐万丗丒下七丟丁三));
            coinsPlashka.<>c.<>9__15_0 = val_11;
        }
        
            UnityEngine.Social.ReportProgress(achievementID:  "CgkIr8rGkPIJEAIQBA", progress:  100, callback:  val_6);
            UnityEngine.PlayerPrefs.SetInt(key:  "Achieved500", value:  1);
            val_8 = this.丗丞丅丙丅上丏丌业;
            this.一丕丑业不丁丕丞丞 = true;
        }
        
        if(val_8 < 1000)
        {
                return;
        }
        
        if(this.丙与丟世丐七业三七 == true)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = coinsPlashka.<>c.<>9__15_1;
        if(val_11 == null)
        {
                System.Action<System.Boolean> val_7 = null;
            val_11 = val_7;
            val_7 = new System.Action<System.Boolean>(object:  coinsPlashka.<>c.__il2cppRuntimeField_static_fields, method:  System.Void coinsPlashka.<>c::丌丙丅一与丑丌丞丕(bool 丐万丗丒下七丟丁三));
            coinsPlashka.<>c.<>9__15_1 = val_11;
        }
        
        UnityEngine.Social.ReportProgress(achievementID:  "CgkIr8rGkPIJEAIQBQ", progress:  100, callback:  val_7);
        UnityEngine.PlayerPrefs.SetInt(key:  "Achieved1000", value:  1);
        this.丙与丟世丐七业三七 = true;
    }
    public coinsPlashka()
    {
        float val_2 = 768f;
        val_2 = (float)UnityEngine.Screen.height / val_2;
        this.丈丕且丈东不丟丆丆 = val_2;
    }
    private static coinsPlashka()
    {
    
    }

}
