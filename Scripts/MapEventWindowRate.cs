using UnityEngine;
public class MapEventWindowRate : MonoBehaviour
{
    // Fields
    internal static string 丆上东丈业丁下丄丂;
    internal static System.Collections.Generic.Dictionary<int, int> 一丘三一一东丂且丟;
    public UnityEngine.Animator animator;
    public UISprite rateBar;
    public UILabel dislikePercentLabel;
    public UILabel likePercentLabel;
    public UILabel dislikeCountLabel;
    public UILabel likeCountLabel;
    public UnityEngine.GameObject likeGlow;
    public UnityEngine.GameObject dislikeGlow;
    public UIButton likeBtn;
    public UIButton dislikeBtn;
    private bool 世丝丘万业七与丝三;
    private PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅;
    
    // Methods
    internal static void 丐东世丆丞丌丘三丕()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = null;
        val_9 = null;
        val_10 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  MapEventWindowRate.丆上东丈业丁下丄丂));
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        MapEventWindowRate.一丘三一一东丂且丟 = val_3;
        if(val_10 == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_4 = val_10.GetEnumerator();
        label_14:
        if((523636664 & 1) == 0)
        {
            goto label_8;
        }
        
        ConfiguredValueTaskAwaiter val_5 = 0.GetAwaiter();
        val_11 = null;
        val_11 = null;
        val_3.Add(key:  System.Int32.Parse(s:  val_5._value._obj.丐丏七丌丕丗业且上()), value:  System.Convert.ToInt32(value:  val_5._value._obj));
        goto label_14;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static int 丙丘丛丟丈丁丒业丄(int 丑丐丗三丒世丏东丅)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(MapEventWindowRate.一丘三一一东丂且丟 == null)
        {
                MapEventWindowRate.丐东世丆丞丌丘三丕();
            val_2 = null;
        }
        
        val_2 = null;
        if((MapEventWindowRate.一丘三一一东丂且丟.ContainsKey(key:  丑丐丗三丒世丏东丅)) == false)
        {
                return 0;
        }
        
        val_3 = null;
        val_3 = null;
        if(MapEventWindowRate.一丘三一一东丂且丟 != null)
        {
                return MapEventWindowRate.一丘三一一东丂且丟.Item[丑丐丗三丒世丏东丅];
        }
        
        return MapEventWindowRate.一丘三一一东丂且丟.Item[丑丐丗三丒世丏东丅];
    }
    internal static void 丁三丑业专丈一丛丆(int 丑丐丗三丒世丏东丅, int 丙业与丙丗丝不丈东)
    {
        var val_4;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_13 = null;
        val_13 = null;
        if(MapEventWindowRate.一丘三一一东丂且丟 == null)
        {
                MapEventWindowRate.丐东世丆丞丌丘三丕();
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        val_14 = null;
        val_14 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = MapEventWindowRate.一丘三一一东丂且丟.GetEnumerator();
        label_13:
        if((523897536 & 1) == 0)
        {
            goto label_9;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if((PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  val_5.丙东专丂世丈丏丁丂())) == null)
        {
            goto label_13;
        }
        
        val_1.Add(key:  val_5.丙东专丂世丈丏丁丂(), value:  523897528);
        goto label_13;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_15 = 1152921505082458112;
        if(val_1 != null)
        {
            goto label_14;
        }
        
        goto label_24;
        label_14:
        if((val_1.ContainsKey(key:  丑丐丗三丒世丏东丅)) == false)
        {
            goto label_25;
        }
        
        label_27:
        val_1.set_Item(key:  丑丐丗三丒世丏东丅, value:  丙业与丙丗丝不丈东);
        goto label_26;
        label_24:
        if((val_1.ContainsKey(key:  丑丐丗三丒世丏东丅)) == true)
        {
            goto label_27;
        }
        
        label_25:
        val_1.Add(key:  丑丐丗三丒世丏东丅, value:  丙业与丙丗丝不丈东);
        label_26:
        val_16 = null;
        MapEventWindowRate.一丘三一一东丂且丟 = val_1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  MapEventWindowRate.丆上东丈业丁下丄丂, 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
    }
    internal void 丏丑丕丏丈丏丝丆丒(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
    {
        UnityEngine.GameObject val_22;
        UIButton val_24;
        this.丐且丘丑与万丞丑丅 = 丐且丘丑与万丞丑丅;
        三业丌且丄丐丐一专 val_3 = Rilisoft.七丐丛专丞东一不世.丑七不且上丗丁一世().丟一下万丂丟丒一一(丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        float val_22 = 5f;
        val_22 = (float)val_3.丈丐世下丞与丂专丏 / val_22;
        float val_23 = 1f;
        float val_5 = UnityEngine.Mathf.Clamp01(value:  ((float)val_3.丈丐世下丞与丂专丏 == 0f) ? (val_23) : (val_22));
        val_23 = val_23 - val_5;
        val_5 = val_23 * (float)val_3.丌丒丝东丌下丕丁丅;
        this.likeCountLabel.text = UnityEngine.Mathf.RoundToInt(f:  val_5 * (float)val_3.丌丒丝东丌下丕丁丅).ToString();
        this.dislikeCountLabel.text = UnityEngine.Mathf.RoundToInt(f:  val_5).ToString();
        this.rateBar.fillAmount = val_23;
        float val_24 = 100f;
        val_24 = val_5 * val_24;
        int val_11 = UnityEngine.Mathf.RoundToInt(f:  val_24);
        this.likePercentLabel.text = System.String.Format(format:  "{0}%", arg0:  val_11);
        this.dislikePercentLabel.text = System.String.Format(format:  "{0}%", arg0:  100 - val_11);
        int val_16 = MapEventWindowRate.丙丘丛丟丈丁丒业丄(丑丐丗三丒世丏东丅:  丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七());
        int val_17 = val_16 - 1;
        this.世丝丘万业七与丝三 = (val_17 < 2) ? 1 : 0;
        this.animator.SetBool(name:  "isRated", value:  (val_17 < 2) ? 1 : 0);
        val_22 = this.likeGlow;
        if(val_22 == null)
        {
            goto label_16;
        }
        
        if(this.世丝丘万业七与丝三 == false)
        {
            goto label_17;
        }
        
        label_22:
        val_22.SetActive(value:  (val_16 == 1) ? 1 : 0);
        val_22 = this.dislikeGlow;
        val_22.SetActive(value:  (val_16 == 2) ? 1 : 0);
        val_24 = this.dislikeBtn;
        if(val_24 != null)
        {
                return;
        }
        
        return;
        label_16:
        if(this.世丝丘万业七与丝三 == true)
        {
            goto label_22;
        }
        
        label_17:
        val_22.SetActive(value:  false);
        this.dislikeGlow.SetActive(value:  false);
        val_24 = this.dislikeBtn;
    }
    public void HandleSetLike()
    {
        this.七丆丟上业丝丒业丝(与丒专丙丒丂丑丏丆:  true);
    }
    public void HandleSetDislike()
    {
        this.七丆丟上业丝丒业丝(与丒专丙丒丂丑丏丆:  false);
    }
    internal void 七丆丟上业丝丒业丝(bool 与丒专丙丒丂丑丏丆)
    {
        if(this.世丝丘万业七与丝三 != false)
        {
                return;
        }
        
        this.世丝丘万业七与丝三 = true;
        this.animator.SetBool(name:  "isRated", value:  true);
        MapEventWindowRate.丁三丑业专丈一丛丆(丑丐丗三丒世丏东丅:  this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七(), 丙业与丙丗丝不丈东:  ((与丒专丙丒丂丑丏丆 & true) != 0) ? (1 + 1) : 1);
        int val_3 = this.丐且丘丑与万丞丑丅.业上丙丞丐丄丆丅七();
        val_3.且丈丑丌七东丞三丘(丛丗与上且丛不丐丒:  val_3, 丙业与丙丗丝不丈东:  (与丒专丙丒丂丑丏丆 != true) ? 5 : 3);
        this.likeGlow.SetActive(value:  与丒专丙丒丂丑丏丆);
        this.dislikeGlow.SetActive(value:  (~与丒专丙丒丂丑丏丆) & 1);
        if(this.dislikeBtn == null)
        {
            
        }
    
    }
    internal void 且丈丑丌七东丞三丘(int 丛丗与上且丛不丐丒, int 丙业与丙丗丝不丈东)
    {
        var val_6;
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丛丗与上且丛不丐丒 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丛丗与上且丛不丐丒 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 丛丗与上且丛不丐丒;
        val_1[1] = 丙业与丙丗丝不丈东;
        UnityEngine.Debug.LogFormat(format:  "Sending rating {0}: {1}", args:  val_1);
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_2.Add(key:  "mode", value:  丛丗与上且丛不丐丒 + 1000);
        val_2.Add(key:  "rating", value:  丙业与丙丗丝不丈东);
        val_6 = null;
        val_6 = null;
        int val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.且一且丒丞与丒业丕, 一丐丗丁丞丆丅丟丄:  val_2);
    }
    public MapEventWindowRate()
    {
    
    }
    private static MapEventWindowRate()
    {
        MapEventWindowRate.丆上东丈业丁下丄丂 = "EventLikesKey";
    }

}
