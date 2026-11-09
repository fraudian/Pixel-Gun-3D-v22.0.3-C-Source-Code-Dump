using UnityEngine;
public class FpsManager : MonoBehaviour
{
    // Fields
    private float 专丏丞业丟丛丞丈不;
    private float 丛七三丂丏丗东上丟;
    private float 丂丛丐丐东丟丁上下;
    private float 丘且丑与丅一丟丁业;
    private float 丑东丑上丘世丏丕丗;
    private int 丐丙丄丟丕丘且丘不;
    private float 丑丈丌与丙万丝专与;
    private int 上东世丑下与三三丏;
    private float 丘一丑丒丘业丄丂丗;
    private int 与丙丅丈丑丆上丌丁;
    private float 与丑丛丑丑丙万七丒;
    private int 七万七业丘丄不丘丑;
    private float 丝丝下丆丗丌丌丈丑;
    private float 丁丏丅丏下丛丕丒东;
    private int 丛下专与丝上下世丝;
    private float 丞不丈丄丁一丌世与;
    private float 丞丌丘丌万丛下丟万;
    private float 专东上丏丂上一丞上;
    private float 世丈丑丝丞丒丌丞丘;
    private System.Diagnostics.Stopwatch 七三丗丙丏丘丘丅上;
    internal static System.Diagnostics.Stopwatch 东丐丆世丂丅与世丂;
    internal static string 三丒丘三丞丈丕丘不;
    internal static float 业丞世丅且七丝丐与;
    internal static float 丌丙与丙丛丟业丁丟;
    internal static bool 丈丙丈丌丒丕丞丁七;
    internal static bool 专上七丝丝丅丙上丝;
    private bool 且丙丘专下世上丛丐;
    public UnityEngine.GameObject fullCounter;
    public UnityEngine.GameObject middleCounter;
    public UILabel currentFpsLabel;
    public UILabel avgFpsLabel;
    public UILabel avgMinFpsLabel;
    public UILabel dropCountFpsLabel;
    public UILabel timeLabel;
    public UILabel cpuLabel;
    public UILabel memoryLabel;
    public UILabel memoryMaxLabel;
    public UILabel currentFpsLabel2;
    public UILabel avgFpsLabel2;
    public UILabel avgMinFpsLabel2;
    public UILabel dropCountFpsLabel2;
    public UILabel timeLabel2;
    public UILabel cpuLabel2;
    public UILabel memoryLabel2;
    public UILabel timeToLobbyLabel;
    public UILabel timeToSceneLabel;
    public UIToggle isolatedProtocol;
    public UIToggle fps60Toggle;
    internal static bool 丂丅世七一丙世下丅;
    private static FpsManager 丄丘七三上丕世丞业;
    private UnityEngine.Coroutine 丄万丁七世丝丆万与;
    private bool 丗丏丒丞丗七丕与丘;
    
    // Properties
    internal bool 与丒专丅专业东万丒 { get; set; }
    internal static bool 东与上丗万丗世三业 { get; set; }
    internal static bool 七业丄丅下丂丈丌丐 { get; set; }
    internal static bool 丑与上下不丝不丕丐 { get; }
    
    // Methods
    internal bool 一丈三专东丗丅丘丙()
    {
        return (bool)this.且丙丘专下世上丛丐;
    }
    internal void 丘丕东业三三丕丙丒(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this.且丙丘专下世上丛丐 = val_1;
        this.fullCounter.SetActive(value:  val_1);
        this.middleCounter.SetActive(value:  (this.且丙丘专下世上丛丐 == false) ? 1 : 0);
    }
    internal static bool 丌丂一丌丘丘丏且丌()
    {
        return 丌丝世丞世丛丆丅丟.丙不下丝与丏世世三(下上丐丆丝丟丝丒不:  "fpshud", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    internal static void 丛丈东丐丆丏丛丅丟(bool 丙业与丙丗丝不丈东)
    {
        丌丝世丞世丛丆丅丟.万丈丛丞丕业丙东丄(下上丐丆丝丟丝丒不:  "fpshud", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        FpsManager.丟东丝七与不丛丞丒();
    }
    internal static bool 上丘一丈下下丕丅丕()
    {
        null = null;
        return (bool)FpsManager.丂丅世七一丙世下丅;
    }
    internal static void 东下丝世丛丙上丏七(bool 丙业与丙丗丝不丈东)
    {
        var val_3 = null;
        var val_1 = (FpsManager.丂丅世七一丙世下丅 == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        FpsManager.丂丅世七一丙世下丅 = 丙业与丙丗丝不丈东;
        FpsManager.丟东丝七与不丛丞丒();
    }
    internal static bool 且七丛丈丘丕丗丈丏()
    {
        var val_2 = null;
        if(FpsManager.上丘一丈下下丕丅丕() == false)
        {
                return FpsManager.丌丂一丌丘丘丏且丌();
        }
        
        return true;
    }
    internal static void 丟东丝七与不丛丞丒()
    {
        var val_11;
        var val_12;
        var val_13;
        FpsManager val_14;
        var val_15;
        var val_16;
        val_11 = null;
        val_12 = null;
        if(FpsManager.且七丛丈丘丕丗丈丏() == false)
        {
            goto label_3;
        }
        
        val_13 = null;
        val_14 = FpsManager.丄丘七三上丕世丞业;
        if(val_14 != 0)
        {
                return;
        }
        
        UnityEngine.Object val_4 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "HUDFPS"));
        if(val_4 == null)
        {
            goto label_11;
        }
        
        var val_5 = (null == null) ? (val_4) : 0;
        goto label_13;
        label_3:
        val_15 = null;
        val_14 = FpsManager.丄丘七三上丕世丞业;
        if(val_14 == 0)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_14 = FpsManager.丄丘七三上丕世丞业.gameObject;
        UnityEngine.Object.Destroy(obj:  val_14);
        FpsManager.丄丘七三上丕世丞业 = 0;
        return;
        label_11:
        label_13:
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  -10000f);
        0.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public void Awake()
    {
        null = null;
        FpsManager.丄丘七三上丕世丞业 = this;
        丟丌丁且且世丈丈丟.丄丝一下丅业世万丄(丙业与丙丗丝不丈东:  true);
        this.fps60Toggle.value = 丟丌丁且且世丈丈丟.丆丛丏丛丟丁丁万三();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.Updater());
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        this.七三丗丙丏丘丘丅上.Start();
        this.丘丕东业三三丕丙丒(丙业与丙丗丝不丈东:  false);
        PGCompany.万业不世丗且且丞与.上丛丌丆丑上七世三();
    }
    public void Update()
    {
        float val_7;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = UnityEngine.Time.timeScale / val_2;
        this.专丏丞业丟丛丞丈不 = val_2;
        if((val_2 > 0f) && (val_2 < 0))
        {
                int val_7 = this.丛下专与丝上下世丝;
            val_2 = val_2 + this.丞不丈丄丁一丌世与;
            val_7 = val_7 + 1;
            this.丞不丈丄丁一丌世与 = val_2;
            this.丛下专与丝上下世丝 = val_7;
            float val_4 = this.丁丏丅丏下丛丕丒东 + UnityEngine.Time.deltaTime;
            this.丁丏丅丏下丛丕丒东 = val_4;
            float val_8 = (float)this.丛下专与丝上下世丝;
            val_8 = this.丞不丈丄丁一丌世与 / val_8;
            mem[1152921537252254008] = val_8;
            if((val_4 >= 0.18f) && (val_8 < 0))
        {
                int val_9 = this.七万七业丘丄不丘丑;
            val_9 = val_9 + 1;
            this.七万七业丘丄不丘丑 = val_9;
        }
        
            this.丁丏丅丏下丛丕丒东 = 0f;
            this.丛下专与丝上下世丝 = 0;
            this.丞不丈丄丁一丌世与 = 0f;
            mem[1152921537252254008] = 0;
        }
        
        float val_10 = this.丑丈丌与丙万丝专与;
        int val_11 = this.上东世丑下与三三丏;
        val_10 = val_10 + this.专丏丞业丟丛丞丈不;
        val_11 = val_11 + 1;
        this.丑丈丌与丙万丝专与 = val_10;
        this.上东世丑下与三三丏 = val_11;
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.丘一丑丒丘业丄丂丗 + val_5;
        this.丘一丑丒丘业丄丂丗 = val_5;
        if(val_5 < 1f)
        {
                val_7 = this.丂丛丐丐东丟丁上下;
        }
        else
        {
                float val_13 = this.丂丛丐丐东丟丁上下;
            int val_12 = this.丐丙丄丟丕丘且丘不;
            this.丘一丑丒丘业丄丂丗 = 0f;
            val_12 = val_12 + 1;
            val_13 = this.丑东丑上丘世丏丕丗 + val_13;
            float val_14 = (float)val_12;
            this.丑东丑上丘世丏丕丗 = val_13;
            val_14 = val_13 / val_14;
            val_7 = 1234f;
            this.丐丙丄丟丕丘且丘不 = val_12;
            mem[1152921537252253956] = val_14;
            this.丂丛丐丐东丟丁上下 = 1234f;
        }
        
        if(this.专丏丞业丟丛丞丈不 < 0)
        {
                this.丂丛丐丐东丟丁上下 = this.专丏丞业丟丛丞丈不;
        }
        
        float val_15 = (float)this.上东世丑下与三三丏;
        val_15 = this.丑丈丌与丙万丝专与 / val_15;
        this.丛七三丂丏丗东上丟 = val_15;
        val_15 = val_15 * 0.5f;
        this.丝丝下丆丗丌丌丈丑 = val_15;
        float val_16 = 1000f;
        val_16 = (float)this.七三丗丙丏丘丘丅上.ElapsedMilliseconds / val_16;
        this.专东上丏丂上一丞上 = val_16;
    }
    public System.Collections.IEnumerator Updater()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FpsManager.丟世世专丕且丞丂丛();
    }
    private void 丗丕万丅丞丆丐丆丌()
    {
        var val_42;
        string val_44;
        var val_45;
        string val_46;
        float val_1 = PGCompany.万业不世丗且且丞与.丘丑丐丌丅丙丅丟东();
        val_1 = val_1 * 100f;
        this.与丙丅丈丑丆上丌丁 = (int)val_1;
        this.timeLabel.text = System.String.Format(format:  "Время от сброса: {0}:{1}", arg0:  this.世丈丑丝丞丒丌丞丘, arg1:  ToString(format:  "0" + UnityEngine.Mathf.Clamp(value:  0, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  0, min:  0, max:  10))));
        this.currentFpsLabel.text = System.String.Format(format:  "FPS: {0}", arg0:  this.专丏丞业丟丛丞丈不.ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        this.avgFpsLabel.text = System.String.Format(format:  "Avg: {0}", arg0:  this.丛七三丂丏丗东上丟.ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        this.avgMinFpsLabel.text = System.String.Format(format:  "Min Avg: {0}", arg0:  this.丘且丑与丅一丟丁业.ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        this.dropCountFpsLabel.text = this.七万七业丘丄不丘丑.ToString(format:  "Drops: 0");
        this.cpuLabel.text = System.String.Format(format:  "CPU: {0}", arg0:  this.与丙丅丈丑丆上丌丁.ToString());
        this.memoryLabel.text = System.String.Format(format:  "Mem: {0}", arg0:  PGCompany.下东丄专丑万丕丈丕.三丂万丒丞业专业下(丝丆丁丞丛三丁丑丙:  PGCompany.万业不世丗且且丞与.且丟丟东丛七且丐七()));
        this.timeLabel2.text = this.timeLabel.text;
        this.currentFpsLabel2.text = this.currentFpsLabel.text;
        this.avgFpsLabel2.text = this.avgFpsLabel.text;
        this.avgMinFpsLabel2.text = this.avgMinFpsLabel.text;
        this.dropCountFpsLabel2.text = this.dropCountFpsLabel.text;
        this.cpuLabel2.text = System.String.Format(format:  "CPU: {0}", arg0:  this.与丙丅丈丑丆上丌丁.ToString());
        this.memoryLabel2.text = System.String.Format(format:  "Mem: {0}", arg0:  PGCompany.下东丄专丑万丕丈丕.三丂万丒丞业专业下(丝丆丁丞丛三丁丑丙:  PGCompany.万业不世丗且且丞与.且丟丟东丛七且丐七()));
        val_42 = null;
        val_42 = null;
        if(FpsManager.业丞世丅且七丝丐与 <= 0f)
        {
            goto label_28;
        }
        
        val_44 = System.String.Format(format:  "{0}: {1}", arg0:  FpsManager.三丒丘三丞丈丕丘不, arg1:  ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        if(this.timeToSceneLabel != null)
        {
            goto label_35;
        }
        
        goto label_34;
        label_28:
        val_44 = "Боевой сцены: ---";
        if(this.timeToSceneLabel != null)
        {
            goto label_35;
        }
        
        label_34:
        label_35:
        this.timeToSceneLabel.text = val_44;
        val_45 = null;
        val_45 = null;
        if(FpsManager.丌丙与丙丛丟业丁丟 <= 0f)
        {
            goto label_38;
        }
        
        val_46 = System.String.Format(format:  "Лобби: {0}", arg0:  ToString(format:  "f" + UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10)(UnityEngine.Mathf.Clamp(value:  1, min:  0, max:  10))));
        if(this.timeToLobbyLabel != null)
        {
            goto label_45;
        }
        
        goto label_44;
        label_38:
        val_46 = "Лобби: ---";
        if(this.timeToLobbyLabel != null)
        {
            goto label_45;
        }
        
        label_44:
        label_45:
        this.timeToLobbyLabel.text = val_46;
        if(this.专东上丏丂上一丞上 < 59f)
        {
                return;
        }
        
        float val_42 = this.世丈丑丝丞丒丌丞丘;
        this.专东上丏丂上一丞上 = 0f;
        val_42 = val_42 + 1f;
        this.世丈丑丝丞丒丌丞丘 = val_42;
        this.七三丗丙丏丘丘丅上.Restart();
    }
    public void OnClickHandler()
    {
        if(this.丗丏丒丞丗七丕与丘 != false)
        {
                this.StopCoroutine(routine:  this.丄万丁七世丝丆万与);
            this.丗丏丒丞丗七丕与丘 = false;
            this.丘丕东业三三丕丙丒(丙业与丙丗丝不丈东:  (this.且丙丘专下世上丛丐 == false) ? 1 : 0);
            return;
        }
        
        this.丗丏丒丞丗七丕与丘 = true;
        this.丄万丁七世丝丆万与 = this.StartCoroutine(routine:  this.丁丐东丏丄丅丑丂丐());
    }
    internal System.Collections.IEnumerator 丁丐东丏丄丅丑丂丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FpsManager.上丟丄专丝丏世不业();
    }
    internal static void Reset(float 丕丕世且下一与丝与)
    {
        var val_5;
        var val_6;
        System.Collections.IEnumerator val_7;
        val_5 = null;
        val_5 = null;
        if(FpsManager.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if(FpsManager.丄丘七三上丕世丞业 != null)
        {
                val_7 = FpsManager.丄丘七三上丕世丞业.丑三丛丆丌业丙且专(丕丕世且下一与丝与:  丕丕世且下一与丝与);
        }
        else
        {
                val_7 = this.丑三丛丆丌业丙且专(丕丕世且下一与丝与:  丕丕世且下一与丝与);
        }
        
        UnityEngine.Coroutine val_4 = FpsManager.丄丘七三上丕世丞业.StartCoroutine(routine:  val_7);
    }
    private System.Collections.IEnumerator 丑三丛丆丌业丙且专(float 丕丕世且下一与丝与)
    {
        FpsManager.丐业丕丝且七丙丗丘 val_1 = new FpsManager.丐业丕丝且七丙丗丘();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 三丒丟丏丈丗丆三丞()
    {
        this.专丏丞业丟丛丞丈不 = 0f;
        this.丛七三丂丏丗东上丟 = 0f;
        this.世丈丑丝丞丒丌丞丘 = 0f;
        this.上东世丑下与三三丏 = 0;
        this.丘一丑丒丘业丄丂丗 = 0f;
        this.丐丙丄丟丕丘且丘不 = 0;
        this.丑丈丌与丙万丝专与 = 0f;
        this.丂丛丐丐东丟丁上下 = 1234f;
        this.丘且丑与丅一丟丁业 = 0f;
        this.丑东丑上丘世丏丕丗 = 0f;
        this.丞不丈丄丁一丌世与 = 0f;
        this.丞丌丘丌万丛下丟万 = 0f;
        this.丁丏丅丏下丛丕丒东 = 0f;
        this.丛下专与丝上下世丝 = 0;
        this.七万七业丘丄不丘丑 = 0;
        this.丝丝下丆丗丌丌丈丑 = 0f;
        this.七三丗丙丏丘丘丅上.Restart();
    }
    internal static void 丞丝下丄丆且丌丈丐()
    {
        null = null;
        FpsManager.东丐丆世丂丅与世丂.Start();
    }
    internal static void 丆丛丗上丄下丁丟下()
    {
        null = null;
        FpsManager.东丐丆世丂丅与世丂.Stop();
    }
    internal static void 丒丗一丟丌下七丗丒()
    {
        var val_2 = null;
        if(FpsManager.丈丙丈丌丒丕丞丁七 == false)
        {
                return;
        }
        
        float val_2 = 1000f;
        val_2 = (float)FpsManager.__il2cppRuntimeField_static_fields.ElapsedMilliseconds / val_2;
        FpsManager.丌丙与丙丛丟业丁丟 = val_2;
        FpsManager.丈丙丈丌丒丕丞丁七 = false;
        FpsManager.东丐丆世丂丅与世丂.Reset();
        FpsManager.丟东丝七与不丛丞丒();
    }
    internal static void 丂业一东丞丞丈世东()
    {
        var val_10;
        FpsManager val_11;
        var val_12;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_10 = null;
        val_10 = null;
        FpsManager.三丒丘三丞丈丕丘不 = val_1.m_Handle.name;
        float val_10 = 1000f;
        val_10 = (float)FpsManager.东丐丆世丂丅与世丂.ElapsedMilliseconds / val_10;
        FpsManager.业丞世丅且七丝丐与 = val_10;
        FpsManager.东丐丆世丂丅与世丂.Reset();
        val_11 = FpsManager.丄丘七三上丕世丞业;
        if(val_11 == 0)
        {
                return;
        }
        
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = mem[FpsManager.丄丘七三上丕世丞业 + 272];
        val_11 = FpsManager.丄丘七三上丕世丞业.isolatedProtocol;
        if(value == false)
        {
                return;
        }
        
        BattleRoyaleController val_7 = BattleRoyaleController.丑七不且上丗丁一世();
        val_7.startTimer = 3f;
        BattleRoyaleController val_8 = BattleRoyaleController.丑七不且上丗丁一世();
        val_8.minCountPlayer = 1;
        val_11 = BattleRoyaleController.丑七不且上丗丁一世();
        val_9.丆世丞丞东世丅丗丁 = 1;
    }
    public void HandleIsolatedProtocol(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗 == 0)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丐丈丝丝丈丐丂丙丈(丙业与丙丗丝不丈东:  丒世丅业丝东下与丗.value);
        丟丌丁且且世丈丈丟.与业丑一丗丒三丙与(丙业与丙丗丝不丈东:  "FPSCheck");
    }
    public void Handle3060(UIToggle 丒世丅业丝东下与丗)
    {
        if(丒世丅业丝东下与丗 == 0)
        {
                return;
        }
        
        丟丌丁且且世丈丈丟.丄丝一下丅业世万丄(丙业与丙丗丝不丈东:  丒世丅业丝东下与丗.value);
    }
    public void LMin()
    {
        this.丒丟丙丅一丂丕下丑(丘丈不不下丙万丌专:  1);
    }
    public void LMiddle()
    {
        this.丒丟丙丅一丂丕下丑(丘丈不不下丙万丌专:  6);
    }
    public void LMax()
    {
        this.丒丟丙丅一丂丕下丑(丘丈不不下丙万丌专:  65);
    }
    private void 丒丟丙丅一丂丕下丑(int 丘丈不不下丙万丌专)
    {
        var val_6;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  52);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈专三世丗丝七世丈(丝三业丛丘且不丝丆:  5, 世丁丙世丄一万丆三:  76, 与丌丛丈丕丁丅丄丗:  0);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业一丅业三丒业七业(丝三业丛丘且不丝丆:  丘丈不不下丙万丌专);
        val_6 = null;
        val_6 = null;
        ExperienceController.sharedController.Refresh();
        PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丛丏且丑丈世世丘丂();
        TrainingController.三世丈且一三且丕丌();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void LobMin()
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  52);
        Dictionary.Enumerator<TKey, TValue> val_4 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.不丁万专不业不丗与().GetEnumerator();
        label_8:
        if(((-1711629288) & 1) == 0)
        {
            goto label_6;
        }
        
        ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
        Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丂丘与与丂下丞丛(与丄不丌一世东丁丙:  val_5._value._obj.丙东专丂世丈丏丁丂());
        goto label_8;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void LobMax()
    {
        var val_5;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  52);
        System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
        if(val_2 != null)
        {
                val_2.Add(item:  "base_castle_3");
        }
        else
        {
                val_2.Add(item:  "base_castle_3");
        }
        
        val_2.Add(item:  "wall_castle_3");
        if(val_2 != null)
        {
                val_2.Add(item:  "gate_castle_3");
        }
        else
        {
                val_2.Add(item:  "gate_castle_3");
        }
        
        val_2.Add(item:  "kennel_fly_premium_1");
        if(val_2 != null)
        {
                val_2.Add(item:  "terrain_space_1");
        }
        else
        {
                val_2.Add(item:  "terrain_space_1");
        }
        
        val_2.Add(item:  "road_military_1");
        if(val_2 != null)
        {
                val_2.Add(item:  "decor_small_heaven_2");
        }
        else
        {
                val_2.Add(item:  "decor_small_heaven_2");
        }
        
        val_2.Add(item:  "decor_big_heaven_1");
        if(val_2 != null)
        {
                val_2.Add(item:  "background_1_military_1");
        }
        else
        {
                val_2.Add(item:  "background_1_military_1");
        }
        
        val_2.Add(item:  "background_2_castle_1");
        if(val_2 != null)
        {
                val_2.Add(item:  "device_1_1");
        }
        else
        {
                val_2.Add(item:  "device_1_1");
        }
        
        val_2.Add(item:  "skybox_6");
        List.Enumerator<T> val_3 = val_2.GetEnumerator();
        label_22:
        if(((-1711445360) & 1) == 0)
        {
            goto label_17;
        }
        
        new FpsManager.丅一丑三一一丅丑丌() = new System.Object();
        .与丘丙丞丑一丆丐丁 = val_5.丐丏七丌丕丗业且上();
        System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_10 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  new FpsManager.丅一丑三一一丅丑丌(), method:  System.Boolean FpsManager.丅一丑三一一丅丑丌::业上丛丁专上丑丗丕(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
        Rilisoft.丏丘七丞丄丙丌丞丁 val_11 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  null);
        bool val_13 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丂丗丕三丏丙丕丈一(下丅丙一丂丗丅丝七:  val_11, 一丕万业丗丑丒丈与:  true, 丒且万丏世上丟丏万:  true, 万丐丏丐丒万不丟三:  0, 丘专丑丕且且丄专丁:  true);
        System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_15 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_11, 与且专丏丅世丐丐丑:  false, 丞一上万一丞丙七下:  new System.Nullable<System.Int64>() {HasValue = false}, 丘丛与不专丅丑丒丛:  false, 丘专丑丕且且丄专丁:  true);
        goto label_22;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void InvMax()
    {
        var val_45;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_47;
        var val_51;
        var val_52;
        var val_54;
        Progress.下丁下丂七丆丙七一 val_1 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_1.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  52);
        val_1.丒丟丙丅一丂丕下丑(丘丈不不下丙万丌专:  65);
        val_45 = null;
        val_45 = null;
        val_47 = FpsManager.<>c.<>9__85_0;
        if(val_47 == null)
        {
                System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_3 = null;
            val_47 = val_3;
            val_3 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  FpsManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FpsManager.<>c::一丛丝不下丕丅上丙(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
            FpsManager.<>c.<>9__85_0 = val_47;
        }
        
        var val_48 = 0;
        val_48 = val_48 + 1;
        System.Collections.Generic.IEnumerator<T> val_6 = System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三(), predicate:  val_3).GetEnumerator();
        label_76:
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_21;
        }
        
        var val_50 = 0;
        val_50 = val_50 + 1;
        T val_10 = val_6.Current;
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_10.业东丅东丌上丗丑不())) == null)
        {
                WeaponManager.丂丗丂丞且丄业与丄(丝丂丁丌丆三丆专且:  val_10, 世丙与专七丟丒丆世:  7, 丝丗不东丙不三丄专:  false, 一三世且与专丕丆丂:  false, 丄下丁东丘业丆丝上:  0, 世丁丙世丄一万丆三:  "FA");
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗(), 下下丏一丙不丘丌丞:  "Weapon1146#Weapon1120#Weapon982#Weapon1057#Weapon983#Weapon1173");
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丆丈且丟世与丌丞七(), 下下丏一丙不丘丌丞:  WeaponManager.业丞业丕丈丟丂丄丏());
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.一丑丛丒丆丞不专且, 下下丏一丙不丘丌丞:  WeaponManager.丒丟丕丒不丞丆丈丝());
        丅一丈与丄三丝丝丞 val_22 = WeaponManager.且专专丁丌丗丛且丙.Item[1];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_22.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  WeaponManager.不七丁丂丏丆丏丁丈());
        丅一丈与丄三丝丝丞 val_25 = WeaponManager.且专专丁丌丗丛且丙.Item[2];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_25.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  WeaponManager.与下丝丙丏丅万一七());
        丅一丈与丄三丝丝丞 val_28 = WeaponManager.且专专丁丌丗丛且丙.Item[4];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_28.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  WeaponManager.丆丒丆且丕丄丞三丒());
        丅一丈与丄三丝丝丞 val_31 = WeaponManager.且专专丁丌丗丛且丙.Item[100];
        丅一丈与丄三丝丝丞 val_32 = WeaponManager.且专专丁丌丗丛且丙.Item[100];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_31.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  val_32.万丏丁丟丝丛业不丕.Invoke());
        丅一丈与丄三丝丝丞 val_35 = WeaponManager.且专专丁丌丗丛且丙.Item[101];
        丅一丈与丄三丝丝丞 val_36 = WeaponManager.且专专丁丌丗丛且丙.Item[101];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_35.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  val_36.万丏丁丟丝丛业不丕.Invoke());
        丅一丈与丄三丝丝丞 val_39 = WeaponManager.且专专丁丌丗丛且丙.Item[102];
        丅一丈与丄三丝丝丞 val_40 = WeaponManager.且专专丁丌丗丛且丙.Item[102];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_39.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  val_40.万丏丁丟丝丛业不丕.Invoke());
        丅一丈与丄三丝丝丞 val_43 = WeaponManager.且专专丁丌丗丛且丙.Item[111];
        丅一丈与丄三丝丝丞 val_44 = WeaponManager.且专专丁丌丗丛且丙.Item[111];
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  val_43.丟丌东且上业丝丂丞, 下下丏一丙不丘丌丞:  val_44.万丏丁丟丝丛业不丕.Invoke());
        goto label_76;
        label_21:
        val_51 = 0;
        val_52 = 0;
        if(val_6 == null)
        {
            
        }
        else
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_6.Dispose();
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        val_54 = null;
        val_54 = null;
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  true, 专丆丌丛东一不丑丙:  0);
    }
    public void InvMin()
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丈且世万丕丑丞上下(丂丂丁一世丛丘专三:  2, 下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丗且三业丄丐世丐丗(), 下下丏一丙不丘丌丞:  WeaponManager.丑丄丁三丑且且丂丐());
        WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  true, 专丆丌丛东一不丑丙:  0);
    }
    public FpsManager()
    {
        this.丂丛丐丐东丟丁上下 = 1234f;
        this.七三丗丙丏丘丘丅上 = new System.Diagnostics.Stopwatch();
    }
    private static FpsManager()
    {
        FpsManager.东丐丆世丂丅与世丂 = new System.Diagnostics.Stopwatch();
        FpsManager.业丞世丅且七丝丐与 = -1f;
        FpsManager.丌丙与丙丛丟业丁丟 = -1f;
        FpsManager.丈丙丈丌丒丕丞丁七 = true;
        FpsManager.专上七丝丝丅丙上丝 = true;
        FpsManager.丄丘七三上丕世丞业 = 0;
    }

}
