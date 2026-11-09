using UnityEngine;
public class LoadingInAfterGame : MonoBehaviour
{
    // Fields
    internal static UnityEngine.Texture 丏三丙三且丁丄丙丈;
    internal static LoadingInAfterGame 丄丘七三上丕世丞业;
    internal static bool 世丁与丙丈世丏下丌;
    private LoadingNGUIController 三三丆下东丏丌丅上;
    
    // Properties
    private bool 业丄丅丟丅丄丆三且 { get; }
    
    // Methods
    private bool 一丞丂丟专万丏丅专()
    {
        var val_4;
        bool val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(LoadingInAfterGame.丏三丙三且丁丄丙丈 == 0)
        {
                val_5 = 0;
        }
        else
        {
                val_6 = null;
            val_6 = null;
            val_5 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
            if(val_5 != false)
        {
                bool val_2 = GameConnect.世丐丄三三上丅七三();
            val_5 = val_2 ^ 1;
        }
        
        }
        
        val_2 = val_5;
        return (bool)val_2;
    }
    private void Awake()
    {
        LoadingInAfterGame val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = this;
        val_10 = null;
        val_10 = null;
        LoadingInAfterGame.丄丘七三上丕世丞业 = val_9;
        if(一丞丂丟专万丏丅专() != false)
        {
                this.三三丆下东丏丌丅上 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "LoadingGUI")).GetComponent<LoadingNGUIController>();
            UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_4.丞丗专丝丙专丂上丗 = val_5.m_Handle.name;
            val_11 = null;
            val_11 = null;
            this.三三丆下东丏丌丅上.SetLoadingTexture(与万丆丛丒万丝丙丑:  LoadingInAfterGame.丏三丙三且丁丄丙丈);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.三三丆下东丏丌丅上.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            val_9 = this.三三丆下东丏丌丅上;
            val_9.丘上丐世丆丑且丞丒(丝丌丄丙专三丑丒丝:  true, 丐且丘丑与万丞丑丅:  0);
            LoadingInAfterGame.世丁与丙丈世丏下丌 = true;
            return;
        }
        
        val_12 = null;
        val_12 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = 0;
    }
    internal void 世世世丂丆丆丙丐丟()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        if(this.三三丆下东丏丌丅上 != 0)
        {
                0.IsShowingTip = false;
            UnityEngine.Object.Destroy(obj:  this.三三丆下东丏丌丅上.gameObject);
            this.三三丆下东丏丌丅上 = 0;
            val_4 = null;
            val_4 = null;
            LoadingNGUIController.丙丅东上世万丐丏丞 = false;
            UnityEngine.AsyncOperation val_3 = UnityEngine.Resources.UnloadUnusedAssets();
            val_5 = null;
            val_5 = null;
            if(FpsManager.专上七丝丝丅丙上丝 != false)
        {
                FpsManager.丂业一东丞丞丈世东();
        }
        
        }
        
        this.enabled = false;
        val_6 = null;
        val_6 = null;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = 0;
        val_7 = null;
        val_7 = null;
        与丂丏丛丞丞丒丟丄.丝丂丌丅丛丘与丌丏 = false;
        LoadingInAfterGame.世丁与丙丈世丏下丌 = false;
    }
    private void OnDestroy()
    {
        if(LoadingInAfterGame.世丁与丙丈世丏下丌 == false)
        {
                return;
        }
        
        null = null;
        LoadingInAfterGame.世丁与丙丈世丏下丌 = false;
        LoadingInAfterGame.丏三丙三且丁丄丙丈 = 0;
    }
    public LoadingInAfterGame()
    {
    
    }
    private static LoadingInAfterGame()
    {
    
    }

}
