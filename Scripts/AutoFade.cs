using UnityEngine;
public class AutoFade : MonoBehaviour
{
    // Fields
    private static AutoFade 不丒丛不不丅与丞七;
    public UnityEngine.Coroutine fadeCoroutine;
    private bool 且世一丄丒丕专丛不;
    private float 万丘丌丕丟丌下与丒;
    private bool 不专丁七丄三世七丄;
    private string 下丂丕丘且丛东与丒;
    private UnityEngine.Material 下丑丄东万业丌世丘;
    
    // Properties
    private static AutoFade 丆丕丝丒不丙且丐丗 { get; }
    internal static bool 丐丗丂不丑丗丐不丒 { get; }
    
    // Methods
    private static AutoFade 丑七不且上丗丁一世()
    {
        var val_4;
        AutoFade val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = AutoFade.不丒丛不不丅与丞七;
        if(val_5 == 0)
        {
                val_6 = null;
            val_5 = new UnityEngine.GameObject(name:  "AutoFade").AddComponent<AutoFade>();
            val_6 = null;
            AutoFade.不丒丛不不丅与丞七 = val_5;
        }
        
        val_7 = null;
        val_7 = null;
        return (AutoFade)AutoFade.不丒丛不不丅与丞七;
    }
    internal static bool 七丈丐丄专世丛丙万()
    {
        if(AutoFade.丑七不且上丗丁一世() != null)
        {
                return (bool)val_1.不专丁七丄三世七丄;
        }
        
        return (bool)val_1.不专丁七丄三世七丄;
    }
    private void Awake()
    {
        var val_3;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        val_3 = null;
        val_3 = null;
        AutoFade.不丒丛不不丅与丞七 = this;
        this.下丑丄东万业丌世丘 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Mobile/Particles/Alpha Blended"));
    }
    private void 七丞不一丏丅且丑丟(UnityEngine.Color 一七专业丞丛世且丌, float 丗且丑丗且不三万一)
    {
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        BankController val_2 = BankController.丑七不且上丗丁一世();
        if(val_2.uiRoot.gameObject.activeInHierarchy != false)
        {
                return;
        }
        
        if((this.下丑丄东万业丌世丘.SetPass(pass:  0)) != false)
        {
                UnityEngine.GL.PushMatrix();
            UnityEngine.GL.LoadOrtho();
            UnityEngine.GL.Begin(mode:  7);
            UnityEngine.GL.Color(c:  new UnityEngine.Color() {r = 一七专业丞丛世且丌.r, g = 一七专业丞丛世且丌.g, b = 一七专业丞丛世且丌.b, a = 丗且丑丗且不三万一});
            UnityEngine.GL.Vertex3(x:  0f, y:  0f, z:  -1f);
            UnityEngine.GL.Vertex3(x:  0f, y:  1f, z:  -1f);
            UnityEngine.GL.Vertex3(x:  1f, y:  1f, z:  -1f);
            UnityEngine.GL.Vertex3(x:  1f, y:  0f, z:  -1f);
            UnityEngine.GL.End();
            UnityEngine.GL.PopMatrix();
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Couldnot set pass for material.");
    }
    private System.Collections.IEnumerator 丂丄丈且丑丒丑一与(float 世三丏丑丙丅丌且下, float 丅世丗丛万下下专丕, UnityEngine.Color 一七专业丞丛世且丌, bool 万与丈与丐世丏专丂)
    {
        AutoFade.丝丅丈且丒世世丄世 val_1 = new AutoFade.丝丅丈且丒世世丄世();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .世三丏丑丙丅丌且下 = 世三丏丑丙丅丌且下;
            .丅世丗丛万下下专丕 = 丅世丗丛万下下专丕;
        }
        else
        {
                mem[40] = this;
            mem[32] = 世三丏丑丙丅丌且下;
            mem[64] = 丅世丗丛万下下专丕;
        }
        
        .一七专业丞丛世且丌 = 一七专业丞丛世且丌;
        mem[1152921536281375796] = 一七专业丞丛世且丌.g;
        mem[1152921536281375800] = 一七专业丞丛世且丌.b;
        mem[1152921536281375804] = 一七专业丞丛世且丌.a;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丘上丌丏丕丁上下丂(float 世三丏丑丙丅丌且下, float 丅世丗丛万下下专丕, UnityEngine.Color 一七专业丞丛世且丌, bool 丆专丌丅丆世丗丕丈 = False)
    {
        this.不专丁七丄三世七丄 = true;
        this.fadeCoroutine = this.StartCoroutine(routine:  this.丂丄丈且丑丒丑一与(世三丏丑丙丅丌且下:  世三丏丑丙丅丌且下, 丅世丗丛万下下专丕:  丅世丗丛万下下专丕, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = 一七专业丞丛世且丌.r, g = 一七专业丞丛世且丌.g, b = 一七专业丞丛世且丌.b, a = 一七专业丞丛世且丌.a}, 万与丈与丐世丏专丂:  false));
    }
    internal static void 上丅丏丑东丅丐一丈(string 丒丙业业丌丅丒丅丝, float 世三丏丑丙丅丌且下, float 丅世丗丛万下下专丕, UnityEngine.Color 一七专业丞丛世且丌)
    {
        string val_7;
        var val_8;
        val_7 = 丒丙业业丌丅丒丅丝;
        val_8 = null;
        if(AutoFade.七丈丐丄专世丛丙万() == true)
        {
                return;
        }
        
        AutoFade val_2 = AutoFade.丑七不且上丗丁一世();
        val_2.且世一丄丒丕专丛不 = true;
        AutoFade val_3 = AutoFade.丑七不且上丗丁一世();
        val_3.下丂丕丘且丛东与丒 = val_7;
        val_7 = AutoFade.丑七不且上丗丁一世();
        val_4.不专丁七丄三世七丄 = true;
        val_4.fadeCoroutine = val_7.StartCoroutine(routine:  val_7.丂丄丈且丑丒丑一与(世三丏丑丙丅丌且下:  世三丏丑丙丅丌且下, 丅世丗丛万下下专丕:  丅世丗丛万下下专丕, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = 一七专业丞丛世且丌.r, g = 一七专业丞丛世且丌.g, b = 一七专业丞丛世且丌.b, a = 一七专业丞丛世且丌.a}, 万与丈与丐世丏专丂:  false));
    }
    internal static void 三丒下丝东七且七丈(float 世三丏丑丙丅丌且下, float 业三一丆丒与丘且业, float 丅世丗丛万下下专丕, UnityEngine.Color 一七专业丞丛世且丌)
    {
        var val_9 = null;
        if(AutoFade.七丈丐丄专世丛丙万() != false)
        {
                AutoFade val_3 = AutoFade.丑七不且上丗丁一世();
            AutoFade.丑七不且上丗丁一世().StopCoroutine(routine:  val_3.fadeCoroutine);
        }
        
        AutoFade val_4 = AutoFade.丑七不且上丗丁一世();
        val_4.且世一丄丒丕专丛不 = false;
        AutoFade val_5 = AutoFade.丑七不且上丗丁一世();
        val_5.万丘丌丕丟丌下与丒 = 业三一丆丒与丘且业;
        AutoFade val_6 = AutoFade.丑七不且上丗丁一世();
        val_6.不专丁七丄三世七丄 = true;
        val_6.fadeCoroutine = val_6.StartCoroutine(routine:  val_6.丂丄丈且丑丒丑一与(世三丏丑丙丅丌且下:  世三丏丑丙丅丌且下, 丅世丗丛万下下专丕:  丅世丗丛万下下专丕, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = 一七专业丞丛世且丌.r, g = 一七专业丞丛世且丌.g, b = 一七专业丞丛世且丌.b, a = 一七专业丞丛世且丌.a}, 万与丈与丐世丏专丂:  false));
    }
    public AutoFade()
    {
        this.且世一丄丒丕专丛不 = true;
        this.下丂丕丘且丛东与丒 = "";
    }
    private static AutoFade()
    {
    
    }

}
