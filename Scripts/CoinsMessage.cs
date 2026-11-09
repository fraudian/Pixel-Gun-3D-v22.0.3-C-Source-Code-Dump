using UnityEngine;
public sealed class CoinsMessage : MonoBehaviour
{
    // Fields
    private float 七三丗丙丏丘丘丅上;
    private int 世专丛丘丑三丆丑丕;
    private int 丗世丁丘丟且且与丟;
    public int depth;
    public UnityEngine.GUIStyle labelStyle;
    public string message;
    public UnityEngine.Texture plashka;
    public UnityEngine.Rect rect;
    public bool singleMessage;
    private double 与丕丌丒丗丄丘丙东;
    public UnityEngine.Texture texture;
    public UnityEngine.Texture youveGotCoin;
    public UnityEngine.Texture passNextLevels;
    private static CoinsMessage.一丞专丂丏丟丑七与 业万丅上与丆不丞专;
    
    // Methods
    internal static void 下丗丑且专丝丈丁三(CoinsMessage.一丞专丂丏丟丑七与 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  CoinsMessage.业万丅上与丆不丞专, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丐上丈丆专不不丑丟(CoinsMessage.一丞专丂丏丟丑七与 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  CoinsMessage.业万丅上与丆不丞专, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丄丝世丒一下丙丗不(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅 = 2)
    {
        if(CoinsMessage.业万丅上与丆不丞专 == null)
        {
                return;
        }
        
        CoinsMessage.业万丅上与丆不丞专.Invoke(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
    }
    private void Start()
    {
        string val_8;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        this.丗世丁丘丟且且与丟 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丅与丙丗丘业丞下(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丅与丙丗丘业丞下(), 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        if(this.丗世丁丘丟且且与丟 >= 2)
        {
                val_8 = "got_prize";
        }
        else
        {
                val_8 = "got_coin";
        }
        
        this.plashka = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "CoinsIndicationSystem", 丌丗丏丏丛东专丁且:  val_8));
        this.与丕丌丒丗丄丘丙东 = (double)UnityEngine.Time.realtimeSinceStartup;
    }
    private void Remove()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public CoinsMessage()
    {
        this.七三丗丙丏丘丘丅上 = 2f;
        this.depth = -2;
        this.message = "Purchases restored";
        UnityEngine.Rect val_1 = Rilisoft.与丄丁丄丙丞下下丙.七丏与一丏三丝丈丏();
        this.rect = val_1;
        mem[1152921536945938724] = val_1.m_YMin;
        mem[1152921536945938728] = val_1.m_Width;
        mem[1152921536945938732] = val_1.m_Height;
    }

}
