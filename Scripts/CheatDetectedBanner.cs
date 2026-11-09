using UnityEngine;
public class CheatDetectedBanner : MonoBehaviour
{
    // Fields
    internal const string 且丒东丘丝丗丑三且 = "HackDetected";
    public UITexture txFon;
    public UIButton exitButton;
    private static string 丗丒下丆丂丁丆丆丟;
    private bool 下丕丈丆丝丆丌丂与;
    private bool 丝不下下三丂丟丈丈;
    
    // Methods
    internal static void 丌丟七丅且丅丏丕丘()
    {
        丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Cheat");
    }
    private static void 丞丄丄丝下七丏丈丟()
    {
        var val_7 = null;
        CheatDetectedBanner.丗丒下丆丂丁丆丆丟 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        UnityEngine.PlayerPrefs.DeleteAll();
        UnityEngine.PlayerPrefs.Save();
        bool val_2 = UnityEngine.Application.isEditor;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "HackDetected", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        专丈专业丆且且业下.丗丈一三不万且丟丕(丙业与丙丗丝不丈东:  CheatDetectedBanner.丗丒下丆丂丁丆丆丟);
        UnityEngine.PlayerPrefs.Save();
        UnityEngine.Coroutine val_6 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丂丗丞丞且万丛万不(丟东丈丗丏丛世万一:  true, 且丏下一下上丟与丐:  false));
    }
    private void Awake()
    {
        this.三丌丞东丆丑丒与且();
        UnityEngine.Texture val_1 = ConnectScene.丗丅专与丁丙且且丐();
        this.exitButton.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CheatDetectedBanner::一东丂业丄丒万丝丈())));
    }
    private void Update()
    {
        if(this.下丕丈丆丝丆丌丂与 != false)
        {
                if(this.丝不下下三丂丟丈丈 == true)
        {
                return;
        }
        
            this.丝不下下三丂丟丈丈 = true;
            CheatDetectedBanner.丞丄丄丝下七丏丈丟();
            return;
        }
        
        this.下丕丈丆丝丆丌丂与 = true;
    }
    private void 三丌丞东丆丑丒与且()
    {
        var val_8;
        UnityEngine.Object val_9;
        val_8 = 0;
        goto label_3;
        label_15:
        val_9 = UnityEngine.Object.FindObjectsOfType<UnityEngine.MonoBehaviour>()[0].transform.root;
        if((val_9.Equals(other:  this.transform.root)) != true)
        {
                val_9 = val_1[0x0] + 32.gameObject;
            UnityEngine.Object.Destroy(obj:  val_9);
        }
        
        val_8 = 1;
        label_3:
        if(val_8 < val_1.Length)
        {
            goto label_15;
        }
    
    }
    private void 一东丂业丄丒万丝丈()
    {
        PGCompany.七丞丝丏业丞丂丆上.一丐丛专下丞七丌万();
    }
    public CheatDetectedBanner()
    {
    
    }
    private static CheatDetectedBanner()
    {
        CheatDetectedBanner.丗丒下丆丂丁丆丆丟 = "";
    }

}
