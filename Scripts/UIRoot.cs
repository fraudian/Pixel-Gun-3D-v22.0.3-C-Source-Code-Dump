using UnityEngine;
public class UIRoot : MonoBehaviour
{
    // Fields
    public static System.Collections.Generic.List<UIRoot> list;
    public UIRoot.丟专丐专与东丈丟丒 scalingStyle;
    internal static System.Collections.Generic.Dictionary<UnityEngine.Transform, UIPanel> 丅丘丝不七丝丝三丘;
    internal static System.Collections.Generic.Dictionary<UnityEngine.Transform, UIWidget> 上万丞丂丕丂丕丐万;
    public int manualWidth;
    public int manualHeight;
    public int minimumHeight;
    public int maximumHeight;
    public bool fitWidth;
    public bool fitHeight;
    public bool adjustByDPI;
    public bool shrinkPortraitUI;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    
    // Properties
    public UIRoot.丌一丆丛丁且丝东且 丗丌一一丐丞上丕丒 { get; }
    public UIRoot.丟专丐专与东丈丟丒 丗丞七万丕丌不万丝 { get; }
    public int 丞丆丕丐一东丛丄丌 { get; }
    public float 丞丕丐丅丘丛丛万下 { get; }
    
    // Methods
    public UIRoot.丌一丆丛丁且丝东且 get_constraint()
    {
        if(this.fitWidth == false)
        {
                return (丌一丆丛丁且丝东且)(this.fitHeight == true) ? 3 : (0 + 1);
        }
        
        return (丌一丆丛丁且丝东且)(this.fitHeight == true) ? 0 : 2;
    }
    public UIRoot.丟专丐专与东丈丟丒 get_activeScaling()
    {
        return (丟专丐专与东丈丟丒)(this.scalingStyle != 2) ? this.scalingStyle : (0 + 1);
    }
    public int get_activeHeight()
    {
        int val_10;
        float val_11;
        float val_12;
        if(this.scalingStyle == 0)
        {
            goto label_1;
        }
        
        if(this.fitWidth == false)
        {
            goto label_2;
        }
        
        label_24:
        UnityEngine.Vector2 val_2 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        val_10 = this.manualHeight;
        val_11 = val_2.x / val_2.y;
        var val_3 = ((this.fitHeight == true) ? 0 : 2) & 3;
        float val_9 = (float)val_10;
        val_9 = (float)this.manualWidth / val_9;
        if(val_3 == 0)
        {
            goto label_5;
        }
        
        if(val_3 == 1)
        {
            goto label_6;
        }
        
        if(val_3 == 2)
        {
                return UnityEngine.Mathf.RoundToInt(f:  (float)this.manualWidth / val_11);
        }
        
        return val_10;
        label_1:
        UnityEngine.Vector2 val_4 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        val_12 = (float)this.minimumHeight;
        float val_5 = val_4.x / val_4.y;
        if(val_4.y < 0)
        {
            goto label_11;
        }
        
        val_12 = (float)this.maximumHeight;
        if(val_4.y <= val_12)
        {
            goto label_12;
        }
        
        label_11:
        val_4.x = val_5 * val_12;
        goto label_13;
        label_2:
        if(this.fitHeight == false)
        {
            goto label_24;
        }
        
        val_10 = this.manualHeight;
        return val_10;
        label_5:
        if(val_9 > val_11)
        {
                return UnityEngine.Mathf.RoundToInt(f:  (float)this.manualWidth / val_11);
        }
        
        return val_10;
        label_6:
        if(val_9 >= 0)
        {
                return val_10;
        }
        
        return UnityEngine.Mathf.RoundToInt(f:  (float)this.manualWidth / val_11);
        label_12:
        label_13:
        val_4.x = val_4.y / val_5;
        val_10 = 0;
        if(this.adjustByDPI == false)
        {
                return val_10;
        }
        
        return 万丗丅且丄丑世专与.与且丄丝丑丆世丑专(丟丌丐丘丆丙丑丑一:  (float)UnityEngine.Mathf.RoundToInt(f:  (this.shrinkPortraitUI > false) ? (val_4.x) : val_4.y));
    }
    public float get_pixelSizeAdjustment()
    {
        UnityEngine.Vector2 val_1 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        int val_2 = UnityEngine.Mathf.RoundToInt(f:  val_1.y);
        if(val_2 == 1)
        {
                return 1f;
        }
        
        return this.GetPixelSizeAdjustment(丟丌丐丘丆丙丑丑一:  val_2);
    }
    public static float GetPixelSizeAdjustment(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UIRoot val_1 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丕丗丆丕丈丑东丆丈:  0);
        if(val_1 == 0)
        {
                return 1f;
        }
        
        if(val_1 != null)
        {
                return val_1.pixelSizeAdjustment;
        }
        
        return val_1.pixelSizeAdjustment;
    }
    public float GetPixelSizeAdjustment(int 丟丌丐丘丆丙丑丑一)
    {
        float val_3;
        int val_4;
        int val_1 = UnityEngine.Mathf.Max(a:  2, b:  丟丌丐丘丆丙丑丑一);
        丟专丐专与东丈丟丒 val_3 = this.scalingStyle;
        val_3 = val_3 - 1;
        if(val_3 <= 1)
        {
                val_3 = (float)this.activeHeight;
        }
        else
        {
                val_4 = this.minimumHeight;
            if(val_1 >= val_4)
        {
                val_4 = this.maximumHeight;
            if(val_1 <= val_4)
        {
                return (float)val_3;
        }
        
        }
        
            val_3 = (float)val_4;
        }
        
        val_3 = val_3 / (float)val_1;
        return (float)val_3;
    }
    protected virtual void Awake()
    {
        this.丐一丗丛丕世丘东丁 = this.transform;
    }
    protected virtual void OnEnable()
    {
        null = null;
        UIRoot.list.Add(item:  this);
    }
    protected virtual void OnDisable()
    {
        null = null;
        bool val_1 = UIRoot.list.Remove(item:  this);
    }
    protected virtual void Start()
    {
        UIOrthoCamera val_1 = this.GetComponentInChildren<UIOrthoCamera>();
        if(val_1 != 0)
        {
                UnityEngine.Debug.LogWarning(message:  "UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.", context:  val_1);
            UnityEngine.Camera val_4 = val_1.gameObject.GetComponent<UnityEngine.Camera>();
            val_1.enabled = false;
            if(val_4 == 0)
        {
                return;
        }
        
            val_4.orthographicSize = 1f;
            return;
        }
        
        this.UpdateScale(丌一下万丌丝三万丘:  false);
    }
    private void Update()
    {
        this.UpdateScale(丌一下万丌丝三万丘:  true);
    }
    public void UpdateScale(bool 丌一下万丌丝三万丘 = True)
    {
        if(this.丐一丗丛丕世丘东丁 == 0)
        {
                return;
        }
        
        int val_2 = this.activeHeight;
        if(val_2 < 1)
        {
                return;
        }
        
        float val_6 = (float)val_2;
        val_6 = 2f / val_6;
        UnityEngine.Vector3 val_3 = this.丐一丗丛丕世丘东丁.localScale;
        val_3.x = val_3.x - val_6;
        if(System.Math.Abs(val_3.x) <= (1.401298E-45f))
        {
                if((System.Math.Abs(val_3.y - val_6)) <= (1.401298E-45f))
        {
                if((System.Math.Abs(val_3.z - val_6)) <= (1.401298E-45f))
        {
                return;
        }
        
        }
        
        }
        
        this.丐一丗丛丕世丘东丁.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if(丌一下万丌丝三万丘 == false)
        {
                return;
        }
        
        this.BroadcastMessage(methodName:  "UpdateAnchors");
    }
    public static void Broadcast(string 且丁三丙丄一世不七)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        int val_1 = UIRoot.list.Count;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_4 = 0;
        do
        {
            val_5 = null;
            val_5 = null;
            UIRoot val_2 = UIRoot.list.Item[0];
            if(val_2 != 0)
        {
                val_2.BroadcastMessage(methodName:  且丁三丙丄一世不七, options:  1);
        }
        
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
    
    }
    public static void Broadcast(string 且丁三丙丄一世不七, object 丂丐丄丁丆与丈丂上)
    {
        var val_4;
        var val_5;
        if(丂丐丄丁丆与丈丂上 != null)
        {
                val_4 = null;
            val_4 = null;
            int val_1 = UIRoot.list.Count;
            if(val_1 < 1)
        {
                return;
        }
        
            var val_4 = 0;
            do
        {
            val_5 = null;
            val_5 = null;
            UIRoot val_2 = UIRoot.list.Item[0];
            if(val_2 != 0)
        {
                val_2.BroadcastMessage(methodName:  且丁三丙丄一世不七, parameter:  丂丐丄丁丆与丈丂上, options:  1);
        }
        
            val_4 = val_4 + 1;
        }
        while(val_1 != val_4);
        
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "SendMessage is bugged when you try to pass \'null\' in the parameter field. It behaves as if no parameter was specified.");
    }
    public UIRoot()
    {
        this.fitHeight = true;
        this.manualWidth = ;
        this.manualHeight = ;
        this.minimumHeight = 6597069766976;
        this.maximumHeight = 1536;
    }
    private static UIRoot()
    {
        UIRoot.list = new System.Collections.Generic.List<UIRoot>();
        UIRoot.丅丘丝不七丝丝三丘 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, UIPanel>();
        UIRoot.上万丞丂丕丂丕丐万 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, UIWidget>();
    }

}
