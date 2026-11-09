using UnityEngine;
internal sealed class LevelArt : MonoBehaviour
{
    // Fields
    private const int 与与丄上一丞丐丞下 = 4;
    internal static readonly bool 三丂丂丘下丕丌下三;
    public UnityEngine.GUIStyle startButton;
    internal static bool 丗业丞丐丙三丆丘丟;
    public UnityEngine.GUIStyle labelsStyle;
    public float widthBackLabel;
    public float heightBackLabel;
    private float 丒丝丙丈丒丆七七专;
    private int 万七丟丟丅丞业下丗;
    private bool 七丛丙丏丗丏丁东丌;
    public float _delayShowComics;
    private bool 不与丗丟丄东专丈下;
    private int 丏万丝下丘东丘与丏;
    private UnityEngine.Texture 万世不丐业上一东丅;
    private System.Collections.Generic.List<UnityEngine.Texture> 丈下下丒东丏一丘七;
    private bool 三上丞丛世丈专万丕;
    private string 丅丌东一上万业且丒;
    private bool 三丅丈丅与丐三专丂;
    
    // Methods
    private void Start()
    {
        var val_21;
        var val_22;
        var val_23;
        string val_24;
        var val_25;
        Rilisoft.丝丑丂丛万丐丈丘且 val_26;
        var val_27;
        var val_28;
        this.三丅丈丅与丐三专丂 = System.String.op_Inequality(a:  丟丏下丂七三下丗丕.丗七丏三万丛丙丟业(), b:  "English");
        this.labelsStyle.font = 丟丏下丂七三下丗丕.三万丁丂万丆丅下丟(专万与丁丈丐丑丛且:  "Key_04B_03");
        float val_21 = 20f;
        val_21 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_21;
        this.labelsStyle.fontSize = UnityEngine.Mathf.RoundToInt(f:  val_21);
        if((UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.labelsStyle.丁丒丂丅与专丌丑丕(丙丐一丕丗万丁下一:  5))) != 0)
        {
                int val_22 = this.丏万丝下丘东丘与丏;
            val_22 = val_22 << 1;
            this.丏万丝下丘东丘与丏 = val_22;
        }
        
        UnityEngine.Coroutine val_10 = this.StartCoroutine(methodName:  "ShowArts");
        val_21 = null;
        val_21 = null;
        this.万世不丐业上一东丅 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Arts_background_" + 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与);
        val_22 = null;
        val_22 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 == false)
        {
            goto label_16;
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_24)) == null)
        {
            goto label_42;
        }
        
        val_25 = null;
        val_25 = null;
        val_24 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        不丛专丁世三专三丒 val_16 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().与丏丌七丙万专丈东(丛一丝丛丏专一业且:  val_24);
        val_26 = val_16.丁丑丕且世丛丁东万;
        goto label_29;
        label_16:
        val_27 = null;
        val_27 = null;
        val_24 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  val_24, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) == null)
        {
            goto label_42;
        }
        
        val_28 = null;
        val_28 = null;
        val_24 = 丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与;
        丐丘丛三丙专业丕丄 val_20 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  val_24, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万);
        val_26 = val_20.丁丑丕且世丛丁东万;
        label_29:
        if(val_26 == 1)
        {
                this.七丛丙丏丗丏丁东丌 = false;
        }
        
        label_42:
        bool val_23 = this.七丛丙丏丗丏丁东丌;
        val_23 = val_23 ^ 1;
        this.三上丞丛世丈专万丕 = val_23;
    }
    private void 丙专丒与丌不丁丙丝()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = null;
        val_4 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_6 = null;
            val_6 = null;
            val_5.一东丄丞与丂且丑丅(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与);
        }
        else
        {
                val_5 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_7 = null;
            val_7 = null;
            val_5.一东丄丞与丂且丑丅(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万);
        }
        
        val_8 = null;
        val_8 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "ChooseLevel");
            return;
        }
        
        MainMenuController.丅与丁丌丝丒七不与();
    }
    private string 丁丒丂丅与专丌丑丕(int 丙丐一丕丗万丁下一)
    {
        var val_4;
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        if(LevelArt.丗业丞丐丙三丆丘丟 != false)
        {
                val_6 = null;
            return (string)丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Arts", 丌丗丏丏丛东专丁且:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  val_7 = 1152921505169682440, 丌丗丏丏丛东专丁且:  丙丐一丕丗万丁下一.ToString()));
        }
        
        val_8 = null;
        return (string)丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Arts", 丌丗丏丏丛东专丁且:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  val_7, 丌丗丏丏丛东专丁且:  丙丐一丕丗万丁下一.ToString()));
    }
    private System.Collections.IEnumerator ShowArts()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LevelArt.下丄不世且专丛丗丞();
    }
    internal static string 丒且且丘丒丝丌专丙(string 丕丗丘丑丛与丑业丒)
    {
        var val_11;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        val_11 = 0;
        goto label_1;
        label_12:
        System.Text.StringBuilder val_3 = val_1.Append(value:  丕丗丘丑丛与丑业丒.Chars[0]);
        if((丕丗丘丑丛与丑业丒.Chars[0] & 65535) == '
        ')
        {
                System.Text.StringBuilder val_6 = val_1.Append(value:  '
        ');
        }
        
        if(0 >= 30)
        {
                if((丕丗丘丑丛与丑业丒.Chars[0] & 65535) == ' ')
        {
                System.Text.StringBuilder val_9 = val_1.Append(value:  "\n\n");
            var val_11 = 0;
        }
        
        }
        
        val_11 = 1;
        val_11 = val_11 + 1;
        label_1:
        if(val_11 < 丕丗丘丑丛与丑业丒.Length)
        {
            goto label_12;
        }
        
        if(val_1 == null)
        {
            
        }
    
    }
    public LevelArt()
    {
        this.widthBackLabel = 770f;
        this.heightBackLabel = 100f;
        this.七丛丙丏丗丏丁东丌 = true;
        this._delayShowComics = 3f;
        this.丏万丝下丘东丘与丏 = 4;
        this.丈下下丒东丏一丘七 = new System.Collections.Generic.List<UnityEngine.Texture>();
    }
    private static LevelArt()
    {
        LevelArt.三丂丂丘下丕丌下三 = true;
        LevelArt.丗业丞丐丙三丆丘丟 = false;
    }

}
