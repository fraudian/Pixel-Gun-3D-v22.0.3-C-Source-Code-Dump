using UnityEngine;
internal sealed class LevelCompleteLoader : MonoBehaviour
{
    // Fields
    internal static System.Action 七丐丅专且专七三丆;
    internal static string 专万丟三世业丙丈且;
    private UnityEngine.Texture 专三丛世丐与丁且丌;
    public UICamera myUICam;
    private UnityEngine.Texture 专万三一与一下丞三;
    
    // Methods
    private void Start()
    {
        var val_25;
        string val_26;
        var val_27;
        var val_28;
        var val_30;
        float val_31;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        val_25 = null;
        val_25 = null;
        if((LevelCompleteLoader.专万丟三世业丙丈且.Equals(value:  "LevelComplete")) == false)
        {
            goto label_6;
        }
        
        val_26 = "LevelLoadings" + (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : ""((东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "") + "/LevelComplete_back"("/LevelComplete_back");
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_14;
        }
        
        }
        
        val_26 = "GameOver_Coliseum";
        label_14:
        if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_17;
        }
        
        val_27 = null;
        val_27 = null;
        if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() == false)
        {
            goto label_22;
        }
        
        val_28 = "/Hi";
        goto label_23;
        label_6:
        UnityEngine.Texture val_9 = ConnectScene.丗丅专与丁丙且且丐();
        goto label_26;
        label_22:
        label_23:
        val_26 = 丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.专专丐业丗丆丕专丆 + System.String.__il2cppRuntimeField_static_fields, 丌丗丏丏丛东专丁且:  "Loading_Speedrun");
        label_17:
        label_26:
        this.专三丛世丐与丁且丌 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_26);
        UITexture val_14 = new UnityEngine.GameObject().AddComponent<UITexture>();
        val_30 = null;
        val_30 = null;
        if((LevelCompleteLoader.专万丟三世业丙丈且.Equals(value:  "LevelComplete")) != false)
        {
                val_31 = 1790f;
        }
        else
        {
                val_31 = 1790f;
        }
        
        val_14.SetRect(三丟东丕丄丄下下丑:  0f, 丒丒丄丁且丄丆丂丌:  0f, 业与三万七丝不万东:  val_31, 丟丌丐丘丆丙丑丑一:  780f);
        val_14.transform.SetParent(parent:  this.myUICam.transform, worldPositionStays:  false);
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        val_14.transform.localScale = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
        UnityEngine.Transform val_20 = val_14.transform;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
        val_20.localPosition = new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z};
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  val_20.且丘丕丛丄丝万丌东());
        丕七丌下与丙丅丆丅.丗丛丅丕丘且丅丈丟();
        if(UnityEngine.Application.platform == 8)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.Save();
    }
    private System.Collections.IEnumerator 且丘丕丛丄丝万丌东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new LevelCompleteLoader.丘一一丄一丝丝上上();
    }
    public LevelCompleteLoader()
    {
    
    }
    private static LevelCompleteLoader()
    {
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        LevelCompleteLoader.专万丟三世业丙丈且 = "";
    }

}
