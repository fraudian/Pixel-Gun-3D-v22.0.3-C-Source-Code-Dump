using UnityEngine;
internal sealed class GravitySetter : MonoBehaviour
{
    // Fields
    internal static readonly float 丟丄丑一丌丅丕且下;
    internal static readonly float 丒丕丙丆丌丂丝业一;
    internal static readonly float 丛万丄且丒丂丂世丛;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void GravitySetter::上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void GravitySetter::上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void 上丆丞不下业万七丑(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        string val_6;
        var val_7;
        var val_8;
        float val_9;
        var val_10;
        val_6 = 丏丈丗世丙万丆丐丅.m_Handle.name;
        val_7 = null;
        val_7 = null;
        val_8 = null;
        val_9 = GravitySetter.丟丄丑一丌丅丕且下;
        val_8 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_10 = null;
            val_10 = null;
            val_6 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_6);
            if(val_6 != 0)
        {
                val_9 = val_2.gravity;
        }
        
            PGCompany.GameModeEvents.下丑一丈与丝与丐丛 val_4 = GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  1);
            if(val_4 != null)
        {
                float val_5 = val_4.丛丅下丆丗丏三丁丕<System.Single>();
            if(val_5 > 0f)
        {
                val_9 = val_9 * val_5;
        }
        
        }
        
        }
        
        UnityEngine.Physics.gravity = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static void SetNormalGravity()
    {
        null = null;
        UnityEngine.Physics.gravity = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private float 与丆丟丁丕且丝丏丙(float 丛丛不专三丐业专丛)
    {
        var val_6;
        float val_4 = PlayerCoreSettingsStorager.dynamicSettings.丞丑丆业东世不丕世();
        float val_6 = val_4;
        val_6 = null;
        val_6 = null;
        val_6 = ((GameConnect.万不丒丌丙万丗东不() != true) ? 15f : 14f) * val_6;
        float val_7 = -2f;
        val_4 = val_6 * val_6;
        float val_5 = GravitySetter.丟丄丑一丌丅丕且下 * val_7;
        val_5 = val_4 / val_5;
        val_7 = val_5 * val_7;
        val_7 = val_7 * 丛丛不专三丐业专丛;
        val_4 = val_4 / val_7;
        val_4 = val_4 / GravitySetter.丟丄丑一丌丅丕且下;
        return (float)val_4;
    }
    private float 丕丈丌丘丒一且丛一(float 丂丂丑世丟世丂丂丛)
    {
        var val_7;
        float val_4 = PlayerCoreSettingsStorager.dynamicSettings.丞丑丆业东世不丕世();
        float val_7 = val_4;
        val_7 = null;
        val_7 = null;
        val_7 = ((GameConnect.万不丒丌丙万丗东不() != true) ? 15f : 14f) * val_7;
        float val_8 = -2f;
        val_4 = val_7 * val_7;
        float val_6 = GravitySetter.丟丄丑一丌丅丕且下 * val_8;
        val_6 = val_4 / val_6;
        val_4 = val_4 / (GravitySetter.丟丄丑一丌丅丕且下 * 丂丂丑世丟世丂丂丛);
        val_8 = val_6 * val_8;
        val_4 = val_4 / val_8;
        return (float)val_4;
    }
    internal static float 专丙下不不专丏丌丅(float 丛丛不专三丐业专丛)
    {
        if(丛丛不专三丐业专丛 < 0)
        {
                float val_1 = 1f - 丛丛不专三丐业专丛;
            return UnityEngine.Mathf.Lerp(a:  1f, b:  0.5f, t:  丛丛不专三丐业专丛 + (-1f));
        }
        
        if(丛丛不专三丐业专丛 <= 1f)
        {
                return 1f;
        }
        
        return UnityEngine.Mathf.Lerp(a:  1f, b:  0.5f, t:  丛丛不专三丐业专丛 + (-1f));
    }
    internal static float 世丕丅丕七万丕丘丛(float 丂丂丑世丟世丂丂丛)
    {
        float val_5;
        if(丂丂丑世丟世丂丂丛 < 0)
        {
                float val_5 = -0.5f;
            val_5 = 丂丂丑世丟世丂丂丛 + val_5;
            float val_1 = val_5 + val_5;
            val_5 = 2f;
            return (float)(float)System.Convert.ToDouble(value:  UnityEngine.Mathf.Lerp(a:  val_5 = 1f, b:  0f, t:  val_6 * 4f));
        }
        
        if(丂丂丑世丟世丂丂丛 <= 1f)
        {
                return (float)(float)System.Convert.ToDouble(value:  UnityEngine.Mathf.Lerp(a:  val_5, b:  0f, t:  val_6 * 4f));
        }
        
        float val_6 = -1f;
        val_6 = 丂丂丑世丟世丂丂丛 + val_6;
        return (float)(float)System.Convert.ToDouble(value:  UnityEngine.Mathf.Lerp(a:  val_5, b:  0f, t:  val_6 * 4f));
    }
    public GravitySetter()
    {
    
    }
    private static GravitySetter()
    {
        GravitySetter.丟丄丑一丌丅丕且下 = -9.81f;
        GravitySetter.丒丕丙丆丌丂丝业一 = -6.54f;
        GravitySetter.丛万丄且丒丂丂世丛 = -4.905f;
    }

}
