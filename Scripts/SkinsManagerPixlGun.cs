using UnityEngine;
internal sealed class SkinsManagerPixlGun : MonoBehaviour
{
    // Fields
    internal readonly System.Collections.Hashtable 专丗丕丐七丅下七丟;
    internal static SkinsManagerPixlGun 丟丗丄业丘丗业丗七;
    
    // Methods
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        object val_17;
        var val_18;
        int val_19;
        var val_20;
        var val_21;
        string val_22;
        var val_23;
        val_17 = this;
        val_18 = null;
        val_18 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_19 = 1152921505066536960;
            if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                if(GameConnect.丅业东业丞七上丞丑() == false)
        {
            goto label_12;
        }
        
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        val_19 = 1152921505066536960;
        if(GameConnect.丙丘不世专且万丄丐() == true)
        {
                return;
        }
        
        if(GameConnect.丅业东业丞七上丞丑() == true)
        {
                return;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_24;
        }
        
        string val_6 = 与丂丏丛丞丞丒丟丄.丘丂丄丂上丑丟丏丞();
        goto label_28;
        label_12:
        val_21 = "EnemySkins/COOP/";
        goto label_28;
        label_24:
        if(PGCompany.丁东丌世与丕东丆上.丕丆万一丅丄业世丌() != false)
        {
                int val_8 = 丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一();
            val_22 = val_8.ToString();
        }
        else
        {
                val_22 = "3";
        }
        
        label_28:
        val_19 = 0;
        goto label_35;
        label_47:
        UnityEngine.Object val_16 = UnityEngine.Resources.LoadAll(path:  "EnemySkins/Level"("EnemySkins/Level") + val_22)[val_8];
        if((val_16 != 0) && (val_16 != null))
        {
                val_23 = val_16.name;
            if((this.专丗丕丐七丅下七丟 & 1) == 0)
        {
                val_23 = val_16.name;
        }
        
        }
        
        val_19 = val_8 + 1;
        label_35:
        if(val_19 < val_11.Length)
        {
            goto label_47;
        }
    
    }
    private void Start()
    {
        SkinsManagerPixlGun.丟丗丄业丘丗业丗七 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void SkinsManagerPixlGun::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void SkinsManagerPixlGun::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDestroy()
    {
        SkinsManagerPixlGun.丟丗丄业丘丗业丗七 = 0;
    }
    public SkinsManagerPixlGun()
    {
        this.专丗丕丐七丅下七丟 = new System.Collections.Hashtable();
    }

}
