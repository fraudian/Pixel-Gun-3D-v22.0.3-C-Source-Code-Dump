using UnityEngine;
public sealed class LoadConnectScene : MonoBehaviour
{
    // Fields
    internal static string 丞丗专丝丙专丂上丗;
    internal static UnityEngine.Texture 上三丕下一丅丘上丝;
    internal static UnityEngine.Texture 丞丆专丛丅丁一七上;
    internal static float 七丌丄丑专且丐丙丂;
    public UnityEngine.Texture loadingNote;
    private static readonly float 丅东与丞丁下专上丙;
    private UnityEngine.Texture 丐丞三丛丒丏丝丄丞;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    internal static LoadConnectScene 丆丕丝丒不丙且丐丗;
    
    // Methods
    private void Awake()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Awake prom scene");
        val_6 = null;
        val_6 = null;
        this.丐丞三丛丒丏丝丄丞 = LoadConnectScene.上三丕下一丅丘上丝;
        if(LoadConnectScene.上三丕下一丅丘上丝 == 0)
        {
                val_7 = 1;
            this.丐丞三丛丒丏丝丄丞 = ConnectScene.丗丅专与丁丙且且丐();
        }
        else
        {
                val_7 = 0;
        }
        
        this.三三丆下东丏丌丅上 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
        val_8 = null;
        val_8 = null;
        val_5.丞丗专丝丙专丂上丗 = LoadConnectScene.丞丗专丝丙专丂上丗;
        if(this.三三丆下东丏丌丅上 == null)
        {
            goto label_17;
        }
        
        if(val_7 == 0)
        {
            goto label_18;
        }
        
        label_20:
        this.三三丆下东丏丌丅上.SetQuitTexture(与万丆丛丒万丝丙丑:  this.丐丞三丛丒丏丝丄丞);
        goto label_19;
        label_17:
        if(val_7 != 0)
        {
            goto label_20;
        }
        
        label_18:
        this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  this.丐丞三丛丒丏丝丄丞);
        label_19:
        this.三三丆下东丏丌丅上.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  false, 丐且丘丑与万丞丑丅:  0);
        val_9 = null;
        val_9 = null;
        NotificationController.丄丘七三上丕世丞业.SaveTimeValues();
    }
    private void Start()
    {
        var val_1;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start prom scene");
        val_1 = null;
        val_1 = null;
        LoadConnectScene.丆丕丝丒不丙且丐丗 = this;
        if(LoadConnectScene.七丌丄丑专且丐丙丂 != (-1f))
        {
                this.Invoke(methodName:  "_loadConnectScene", time:  LoadConnectScene.七丌丄丑专且丐丙丂);
            val_1 = null;
        }
        
        val_1 = null;
        LoadConnectScene.七丌丄丑专且丐丙丂 = LoadConnectScene.丅东与丞丁下专上丙;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "end Start prom scene");
    }
    private void Update()
    {
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
    }
    private void _loadConnectScene()
    {
        var val_3 = null;
        UnityEngine.AsyncOperation val_2 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  LoadConnectScene.丞丗专丝丙专丂上丗, 丂丛丑东不丅丈一东:  0);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "LoadSceneAsync");
    }
    private void OnDestroy()
    {
        var val_1;
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Destroy PromScene");
        val_1 = null;
        val_1 = null;
        LoadConnectScene.丆丕丝丒不丙且丐丗 = 0;
        this.丐丞三丛丒丏丝丄丞 = 0;
    }
    public LoadConnectScene()
    {
    
    }
    private static LoadConnectScene()
    {
        LoadConnectScene.丞丗专丝丙专丂上丗 = "";
        LoadConnectScene.上三丕下一丅丘上丝 = 0;
        LoadConnectScene.丞丆专丛丅丁一七上 = 0;
        LoadConnectScene.七丌丄丑专且丐丙丂 = LoadConnectScene.丅东与丞丁下专上丙;
        LoadConnectScene.丅东与丞丁下专上丙 = 0.1f;
    }

}
