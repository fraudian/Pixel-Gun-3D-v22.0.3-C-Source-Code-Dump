using UnityEngine;
internal sealed class GameModeUnlocks : MonoBehaviour
{
    // Fields
    private static System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, string> 专万丅丐丂丗三东不;
    private const string 七丝丟丙不丅丁丁不 = "mgsl";
    private UnityEngine.GameObject firstUnlockAnimationTrigger;
    private UnityEngine.GameObject lockedSprite;
    private UISprite 三丛世一丁世丞丒丝;
    private Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌;
    private int 丏业丟一东丂东丘丛;
    private bool 丝与丆丞东丘丈东丘;
    
    // Methods
    internal void 上丛丌丆丑上七世三(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
    {
        if(this.丝与丆丞东丘丈东丘 == true)
        {
                return;
        }
        
        this.上且丗一丏丏万丅丌 = 上且丗一丏丏万丅丌;
        this.丌丏下丟丑丌丒一丅();
        this.丝与丆丞东丘丈东丘 = true;
    }
    internal void 丅东丌业丁丞丕丒丆()
    {
        if(this.丏业丟一东丂东丘丛 > 1)
        {
                return;
        }
        
        this.丛上丟丘丞三丟丅丘(丙业与丙丗丝不丈东:  2);
        if(this.firstUnlockAnimationTrigger != null)
        {
                this.firstUnlockAnimationTrigger.SetActive(value:  false);
        }
        
        if(this.上且丗一丏丏万丅丌 != 24)
        {
                return;
        }
        
        this.世下一三丌丝丈七丟();
    }
    internal void 丂丆上丙丌丘万东丝()
    {
        if(this.上且丗一丏丏万丅丌 != 24)
        {
                return;
        }
        
        this.丛上丟丘丞三丟丅丘(丙业与丙丗丝不丈东:  2);
        if(this.firstUnlockAnimationTrigger != null)
        {
                this.firstUnlockAnimationTrigger.SetActive(value:  false);
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "mgsl" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下下丏一丙不丘丌丞:  ExperienceController.丂丂下丑且下丌丝东(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 世下一三丌丝丈七丟()
    {
        int val_9;
        var val_10;
        GameModeUnlocks.丗丛丘丑丐不丌丑丙 val_1 = new GameModeUnlocks.丗丛丘丑丐不丌丑丙();
        val_9 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "mgsl" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        if(val_1 != null)
        {
                .丂丗丞丝专丙业专世 = val_9;
        }
        else
        {
                mem[16] = val_9;
            val_9 = mem[16];
        }
        
        if(val_9 >= ExperienceController.丂丂下丑且下丌丝东())
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = GameConnect.丘丗世专不丅与丗丒;
        TSource[] val_8 = System.Linq.Enumerable.ToArray<Rilisoft.七丕丟丏三丈一丄世>(source:  System.Linq.Enumerable.Where<Rilisoft.七丕丟丏三丈一丄世>(source:  val_9, predicate:  new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Boolean>(object:  val_1, method:  System.Boolean GameModeUnlocks.丗丛丘丑丐不丌丑丙::东丟一世一丕丐丆丏(Rilisoft.七丕丟丏三丈一丄世 丛丝丗万丐业丒丂丞))));
        if(val_8.Length == 0)
        {
                return;
        }
        
        this.丛上丟丘丞三丟丅丘(丙业与丙丗丝不丈东:  3);
    }
    internal bool 丅丈上丕丂与丏丝丛(ConnectScene 丆世业世上丄丈下下)
    {
        var val_9;
        int val_10;
        var val_11;
        var val_12;
        val_9 = 丆世业世上丄丈下下.UnlockGameModes;
        if((val_9.Contains(item:  this.上且丗一丏丏万丅丌)) == false)
        {
            goto label_9;
        }
        
        val_10 = this.丏业丟一东丂东丘丛;
        if(val_10 > 1)
        {
            goto label_4;
        }
        
        val_9 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        if((val_9.业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this.上且丗一丏丏万丅丌)) != true)
        {
                this.丛上丟丘丞三丟丅丘(丙业与丙丗丝不丈东:  2);
            if(this.上且丗一丏丏万丅丌 == 24)
        {
                this.世下一三丌丝丈七丟();
        }
        
        }
        
        label_9:
        val_10 = this.丏业丟一东丂东丘丛;
        label_4:
        if(val_10 != 2)
        {
                if(val_10 != 0)
        {
                return false;
        }
        
            if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this.上且丗一丏丏万丅丌)) == false)
        {
                return false;
        }
        
            val_9 = 1152921505052479488;
            val_11 = static_value_081DACA8;
            val_11 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return false;
        }
        
            val_12 = static_value_081DACA8;
            val_12 = static_value_081DACA8;
            System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_8 = static_value_081DACA8 + 184 + 16.UnlockGameModes;
            if(val_8 != null)
        {
                return val_8.Contains(item:  this.上且丗一丏丏万丅丌);
        }
        
            return val_8.Contains(item:  this.上且丗一丏丏万丅丌);
        }
        
        if(this.上且丗一丏丏万丅丌 == 24)
        {
                this.世下一三丌丝丈七丟();
        }
        
        return false;
    }
    private void 丞丗丏丈丐丅丝丒业()
    {
    
    }
    internal float 丐丏丌丟丆且丒丙一()
    {
        if(this.丏业丟一东丂东丘丛 != 0)
        {
                return 0.55f;
        }
        
        if(this.firstUnlockAnimationTrigger != null)
        {
                this.firstUnlockAnimationTrigger.SetActive(value:  true);
        }
        
        this.丛上丟丘丞三丟丅丘(丙业与丙丗丝不丈东:  1);
        return 0.55f;
    }
    private void 丛上丟丘丞三丟丅丘(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.七丕丟丏三丈一丄世 val_5;
        var val_6;
        var val_7;
        val_5 = this.上且丗一丏丏万丅丌;
        if(val_5 == 100)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = this.上且丗一丏丏万丅丌;
        if((GameModeUnlocks.七丝丟丙不丅丁丁不.ContainsKey(key:  val_5)) == false)
        {
                return;
        }
        
        this.丏业丟一东丂东丘丛 = 丙业与丙丗丝不丈东;
        val_7 = null;
        val_7 = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  GameModeUnlocks.七丝丟丙不丅丁丁不.Item[this.上且丗一丏丏万丅丌] + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下下丏一丙不丘丌丞:  this.丏业丟一东丂东丘丛, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 丌丏下丟丑丌丒一丅()
    {
        Rilisoft.七丕丟丏三丈一丄世 val_7;
        var val_8;
        string val_9;
        var val_10;
        val_7 = this.上且丗一丏丏万丅丌;
        if(val_7 == 100)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = this.上且丗一丏丏万丅丌;
        val_9 = GameModeUnlocks.七丝丟丙不丅丁丁不;
        if((val_9.ContainsKey(key:  val_7)) == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = this.上且丗一丏丏万丅丌;
        int val_5 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  GameModeUnlocks.七丝丟丙不丅丁丁不.Item[val_9] + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        int val_6 = val_5 & (~(val_5 >> 31));
        if(this.丏业丟一东丂东丘丛 >= val_6)
        {
                return;
        }
        
        this.丏业丟一东丂东丘丛 = val_6;
    }
    private void Awake()
    {
        if(this.lockedSprite == 0)
        {
                return;
        }
        
        this.三丛世一丁世丞丒丝 = this.lockedSprite.GetComponent<UISprite>();
    }
    public GameModeUnlocks()
    {
        this.上且丗一丏丏万丅丌 = 100;
    }
    private static GameModeUnlocks()
    {
        System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.String> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.String>();
        if(val_1 != null)
        {
                val_1.Add(key:  0, value:  "undmh");
        }
        else
        {
                val_1.Add(key:  0, value:  "undmh");
        }
        
        val_1.Add(key:  20, value:  "unbr");
        if(val_1 != null)
        {
                val_1.Add(key:  4, value:  "uncpt");
        }
        else
        {
                val_1.Add(key:  4, value:  "uncpt");
        }
        
        val_1.Add(key:  8, value:  "undl");
        if(val_1 != null)
        {
                val_1.Add(key:  22, value:  "undng");
        }
        else
        {
                val_1.Add(key:  22, value:  "undng");
        }
        
        val_1.Add(key:  31, value:  "unfp");
        if(val_1 != null)
        {
                val_1.Add(key:  24, value:  "unmgs");
        }
        else
        {
                val_1.Add(key:  24, value:  "unmgs");
        }
        
        val_1.Add(key:  17, value:  "unsg");
        if(val_1 != null)
        {
                val_1.Add(key:  16, value:  "untd");
        }
        else
        {
                val_1.Add(key:  16, value:  "untd");
        }
        
        val_1.Add(key:  32, value:  "unar");
        if(val_1 != null)
        {
                val_1.Add(key:  33, value:  "unhp");
        }
        else
        {
                val_1.Add(key:  33, value:  "unhp");
        }
        
        val_1.Add(key:  34, value:  "unrot");
        val_1.Add(key:  35, value:  "uncom");
        GameModeUnlocks.七丝丟丙不丅丁丁不 = val_1;
    }

}
