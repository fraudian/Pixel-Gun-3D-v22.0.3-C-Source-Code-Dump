using UnityEngine;
public class CustomHungerBase : MonoBehaviour
{
    // Fields
    public bool isShowRanks;
    public UnityEngine.GameObject panelBase;
    public UIButton quitBtn;
    public UIButton resumeBtn;
    public UITexture backTexture;
    private string 丆丙丕下万丆一丆一;
    private bool 三丑丏世丂丆丕丈专;
    private bool 上丟丏世丁丂丄丟专;
    
    // Properties
    private bool 丄丝丘与万上丗丆丑 { set; }
    
    // Methods
    internal static void 下与丞三丅丛丄七丕(string 下业七不丑丂丏丟东)
    {
        CustomHungerBase.不丗丈丂丄丒世丗丟(下业七不丑丂丏丟东:  下业七不丑丂丏丟东);
    }
    internal static void 丆丏专丘丈丗万万上()
    {
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void CustomHungerBase::丆丏专丘丈丗万万上()));
        CustomHungerBase.与丞七七丘不丛丆丛();
    }
    internal static void 与丞七七丘不丛丆丛()
    {
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "chunger")) == false)
        {
                return;
        }
        
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "chunger", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 1)
        {
                return;
        }
        
        CustomHungerBase.不丗丈丂丄丒世丗丟(下业七不丑丂丏丟东:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "chunger_r"));
    }
    internal static void 不丗丈丂丄丒世丗丟(string 下业七不丑丂丏丟东)
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "chunger", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "chunger_r", 下下丏一丙不丘丌丞:  下业七不丑丂丏丟东);
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                丆丒东丁丝丙世丟丏.一丕丄丒丌丅丁业不(丁丂丕与丁丒丕丟丞:  下业七不丑丂丏丟东);
            return;
        }
        
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void CustomHungerBase::丆丏专丘丈丗万万上()));
    }
    internal static void 丙丁丁三丄七丘丗丈()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "chunger", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丕丞上丗与与东下且(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        this.丆丙丕下万丆一丆一 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        UnityEngine.PlayerPrefs.DeleteAll();
        UnityEngine.PlayerPrefs.Save();
        bool val_2 = UnityEngine.Application.isEditor;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "TableViewKey", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        专丈专业丆且且业下.丗丈一三不万且丟丕(丙业与丙丗丝不丈东:  this.丆丙丕下万丆一丆一);
        UnityEngine.PlayerPrefs.Save();
        CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丂丗丞丞且万丛万不(丟东丈丗丏丛世万一:  true, 且丏下一下上丟与丐:  false)).丑丁不万丈丟万且业();
    }
    private void Awake()
    {
        this.世业丒万丘丆专丘丐();
        UnityEngine.Texture val_1 = ConnectScene.丗丅专与丁丙且且丐();
        this.quitBtn.onClick.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void CustomHungerBase::丏与且下三丈丏不上())));
    }
    private void 世业丒万丘丆专丘丐()
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
    private void Update()
    {
        if(this.三丑丏世丂丆丕丈专 == false)
        {
            goto label_0;
        }
        
        if(this.上丟丏世丁丂丄丟专 == false)
        {
            goto label_1;
        }
        
        return;
        label_0:
        this.三丑丏世丂丆丕丈专 = true;
        return;
        label_1:
        this.上丟丏世丁丂丄丟专 = true;
        this.丕丞上丗与与东下且(丙业与丙丗丝不丈东:  true);
    }
    private void 丏与且下三丈丏不上()
    {
        PGCompany.七丞丝丏业丞丂丆上.一丐丛专下丞七丌万();
    }
    private void 丑丁不万丈丟万且业()
    {
        var val_4;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_1.Add(key:  "block_id", value:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "TableViewKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_4 = null;
        val_4 = null;
        Rilisoft.WebSocket.丘七丝且东丙丁丅专 val_3 = new Rilisoft.WebSocket.丘七丝且东丙丁丅专(丝丏业丅丈东业丝丒:  Rilisoft.WebSocket.业丛世业世不丄丐三.丞丆丂东丝且丘丄上, 一丐丗丁丞丆丅丟丄:  val_1);
        if(val_3 != null)
        {
                val_3.三丏丐丐丌丘丌丏世(丙业与丙丗丝不丈东:  true);
        }
        else
        {
                val_3.三丏丐丐丌丘丌丏世(丙业与丙丗丝不丈东:  true);
        }
        
        val_3.丈丂丑丒三一下丏七();
    }
    public CustomHungerBase()
    {
        this.丆丙丕下万丆一丆一 = "";
    }

}
