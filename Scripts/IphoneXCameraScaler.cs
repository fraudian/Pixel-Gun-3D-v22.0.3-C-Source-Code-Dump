using UnityEngine;
public class IphoneXCameraScaler : MonoBehaviour
{
    // Fields
    internal static bool 丞丂丙丘上丗丆专且;
    private static int 丘丞七丑丑专与丐丌;
    private static int 丘不七上七不丏丝丏;
    private static int 与一世丆丈上丌与丙;
    private static int 丕丐丒业不且丟丒丑;
    private static int 专丁丝丙丑丅丗丈丁;
    private static float 丑丈丟丟上下丑丒世;
    private static float 上七不丐丄丒专丝丐;
    internal static float 七丝丛不万东一与丅;
    internal static float 不丅七丘丈不丌丝丏;
    internal static float 且下丒丘丙丒丈丏万;
    
    // Methods
    internal static void 丅业丄丞丞丛不东七(UnityEngine.Camera 丛且丏丟丂下丐丅丄)
    {
        null = null;
        if(IphoneXCameraScaler.丞丂丙丘上丗丆专且 == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丛且丏丟丂下丐丅丄.GetComponent<IPX>())) != false)
        {
                return;
        }
        
        IPX val_5 = 丛且丏丟丂下丐丅丄.gameObject.AddComponent<IPX>();
        IphoneXCameraScaler.丏下丛业丄世丘丗一(丈丄下丙专丅丑不丝:  丛且丏丟丂下丐丅丄);
        IphoneXCameraScaler.丅丟与三且丌丐万丙(与业丞东丙丕且丏丈:  丛且丏丟丂下丐丅丄);
    }
    internal static void 丏下丛业丄世丘丗一(UnityEngine.Camera 丈丄下丙专丅丑不丝)
    {
        if((丈丄下丙专丅丑不丝.clearFlags != 1) && (丈丄下丙专丅丑不丝.clearFlags != 2))
        {
                if(丈丄下丙专丅丑不丝.clearFlags != 4)
        {
                if(丈丄下丙专丅丑不丝.clearFlags != 2)
        {
                return;
        }
        
        }
        
        }
        
        丈丄下丙专丅丑不丝.clearFlags = 2;
        UnityEngine.Color val_5 = UnityEngine.Color.black;
        丈丄下丙专丅丑不丝.backgroundColor = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
    }
    private void Awake()
    {
        var val_4 = null;
        IphoneXCameraScaler.丞丂丙丘上丗丆专且 = 东丗上丁下业一丂丂.丐业丂丞且不东丕丗();
        int val_4 = IphoneXCameraScaler.专丁丝丙丑丅丗丈丁;
        val_4 = IphoneXCameraScaler.丘不七上七不丏丝丏 - val_4;
        float val_5 = (float)val_4;
        val_5 = val_5 / (float)IphoneXCameraScaler.丘不七上七不丏丝丏;
        IphoneXCameraScaler.上七不丐丄丒专丝丐 = val_5;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    internal static void 丅丟与三且丌丐万丙(UnityEngine.Camera 与业丞东丙丕且丏丈)
    {
        var val_7;
        if((UnityEngine.Object.op_Implicit(exists:  与业丞东丙丕且丏丈)) == false)
        {
                return;
        }
        
        UnityEngine.Rect val_2 = 与业丞东丙丕且丏丈.rect;
        val_7 = null;
        val_7 = null;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  IphoneXCameraScaler.丑丈丟丟上下丑丒世, y:  IphoneXCameraScaler.上七不丐丄丒专丝丐);
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.Scale(a:  new UnityEngine.Vector2() {x = val_2.m_XMin, y = val_2.m_YMin}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        UnityEngine.Rect val_5 = 与业丞东丙丕且丏丈.rect;
        UnityEngine.Rect val_6 = 与业丞东丙丕且丏丈.rect;
        float val_7 = IphoneXCameraScaler.上七不丐丄丒专丝丐;
        val_7 = val_6.m_YMin * val_7;
        val_7 = val_5.m_YMin - val_7;
        val_7 = val_4.x + val_7;
        与业丞东丙丕且丏丈.rect = new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height};
    }
    private void OnEnable()
    {
        CameraCallback val_4;
        if(((System.Delegate.Combine(a:  UnityEngine.Camera.onPreRender, b:  new Camera.CameraCallback(object:  0, method:  static System.Void IphoneXCameraScaler::丅业丄丞丞丛不东七(UnityEngine.Camera 丛且丏丟丂下丐丅丄)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        UnityEngine.Camera.onPreRender = val_4;
    }
    private void OnDestroy()
    {
        CameraCallback val_4;
        if(((System.Delegate.Remove(source:  UnityEngine.Camera.onPreRender, value:  new Camera.CameraCallback(object:  0, method:  static System.Void IphoneXCameraScaler::丅业丄丞丞丛不东七(UnityEngine.Camera 丛且丏丟丂下丐丅丄)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        UnityEngine.Camera.onPreRender = val_4;
    }
    private void OnDisable()
    {
        CameraCallback val_4;
        if(((System.Delegate.Remove(source:  UnityEngine.Camera.onPreRender, value:  new Camera.CameraCallback(object:  0, method:  static System.Void IphoneXCameraScaler::丅业丄丞丞丛不东七(UnityEngine.Camera 丛且丏丟丂下丐丅丄)))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        UnityEngine.Camera.onPreRender = val_4;
    }
    public IphoneXCameraScaler()
    {
    
    }
    private static IphoneXCameraScaler()
    {
        IphoneXCameraScaler.丞丂丙丘上丗丆专且 = false;
        IphoneXCameraScaler.丘丞七丑丑专与丐丌 = 812;
        IphoneXCameraScaler.丘不七上七不丏丝丏 = 375;
        IphoneXCameraScaler.与一世丆丈上丌与丙 = 0;
        IphoneXCameraScaler.丕丐丒业不且丟丒丑 = 0;
        IphoneXCameraScaler.专丁丝丙丑丅丗丈丁 = 21;
        IphoneXCameraScaler.丑丈丟丟上下丑丒世 = 1f;
        IphoneXCameraScaler.上七不丐丄丒专丝丐 = 1f;
        IphoneXCameraScaler.七丝丛不万东一与丅 = 0.9415f;
        IphoneXCameraScaler.不丅七丘丈不丌丝丏 = 0.88f;
        IphoneXCameraScaler.且下丒丘丙丒丈丏万 = 0.944f;
    }

}
