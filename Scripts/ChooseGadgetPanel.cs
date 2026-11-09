using UnityEngine;
public class ChooseGadgetPanel : MonoBehaviour
{
    // Fields
    private const float 下丟丌业丕丛与丕丞 = 3;
    private const float 丂丗丌丄丈东专丐丛 = 15;
    private const string 三世世东丘上东丄与 = "ChooseGadgetPanel.GADGET_PANEL_HINTS_SHOWN_KEY";
    private GadgetButton 丌三不丘专业上不丘;
    private System.Collections.Generic.List<丙一丘丆三丌万丂丅> 丙三专一丛丕丄丐丝;
    private int 下与丘丞丁丅丄下丂;
    public UnityEngine.GameObject hoverBackground1;
    public UnityEngine.GameObject hoverBackground2;
    public UnityEngine.GameObject hoverBackground3;
    private bool 且专上丛丌丈专丕丅;
    private float 丁丑业丆丛丞丄丕下;
    private bool 一东丅丌世世丏丟七;
    private ChooseGadgetPanel.万下丒丞丛万三专丈 东业专丏东丌世丒世;
    public System.Collections.Generic.List<UnityEngine.Transform> objectsNoFilpXScale;
    public UnityEngine.GameObject swipeToOpenHint;
    public UnityEngine.GameObject chooseGadgetHint;
    private static System.Action 丞丝丗丐丕丌上业丒;
    
    // Properties
    public GadgetButton 丂丁业三三丐下丁上 { get; }
    
    // Methods
    public GadgetButton get_gadgetButtonScript()
    {
        GadgetButton val_3;
        if(this.丌三不丘专业上不丘 == 0)
        {
                this.丌三不丘专业上不丘 = this.GetComponent<GadgetButton>();
            return val_3;
        }
        
        val_3 = this.丌三不丘专业上不丘;
        return val_3;
    }
    internal static void 一丟且世丈丏一与丄(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ChooseGadgetPanel.丞丝丗丐丕丌上业丒, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 七丘万丂丕与专丝且(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ChooseGadgetPanel.丞丝丗丐丕丌上业丒, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void Awake()
    {
        var val_7;
        ChooseGadgetPanel.丟丛丆丄丅不丞三丒();
        val_7 = null;
        val_7 = null;
        if(null == 0)
        {
                东丟丟万下丛丆丛丟.丘丞丏丈丝丟不丅丞();
        }
        
        this.东丞丝且丐丄业丄丏();
        丆丟七丌丞东丆丕丌.丆专丙丛与丗东下不(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, GadgetCategory, FilterMaps>(object:  this, method:  System.Void ChooseGadgetPanel::与业丑下上丆丟与三(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不, GadgetCategory 丌丙专丟丆丘上一丒, FilterMaps 专丆丌丛东一不丑丙)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.swipeToOpenHint, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetHint, 丏业丟一东丂东丘丛:  false);
        int val_2 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "ChooseGadgetPanel.GADGET_PANEL_HINTS_SHOWN_KEY", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        this.一东丅丌世世丏丟七 = (val_2 == 1) ? 1 : 0;
        if(val_2 == 1)
        {
                return;
        }
        
        if(东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Count <= 1)
        {
                return;
        }
        
        this.东业专丏东丌世丒世 = 1;
        this.丁丑业丆丛丞丄丕下 = UnityEngine.Time.time;
    }
    private void Update()
    {
        float val_62;
        var val_63;
        UnityEngine.GameObject val_64;
        var val_65;
        System.Collections.Generic.List<丙一丘丆三丌万丂丅> val_66;
        var val_67;
        var val_68;
        var val_69;
        if(this.东业专丏东丌世丒世 == 2)
        {
            goto label_1;
        }
        
        if(this.东业专丏东丌世丒世 != 1)
        {
            goto label_7;
        }
        
        val_62 = UnityEngine.Time.time + (-3f);
        if(val_62 < this.丁丑业丆丛丞丄丕下)
        {
            goto label_7;
        }
        
        this.东业专丏东丌世丒世 = 2;
        this.一东丅丌世世丏丟七 = true;
        val_63 = 1;
        val_64 = this.swipeToOpenHint;
        goto label_6;
        label_1:
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + (-15f);
        val_62 = val_2 + (-3f);
        if(val_62 < this.丁丑业丆丛丞丄丕下)
        {
            goto label_7;
        }
        
        this.东业专丏东丌世丒世 = 4;
        val_64 = this.swipeToOpenHint;
        val_63 = 0;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_64, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetHint, 丏业丟一东丂东丘丛:  false);
        label_7:
        if(this.丙三专一丛丕丄丐丝 != null)
        {
                val_65 = 1152921536478208976;
            if(this.丙三专一丛丕丄丐丝.Count >= 1)
        {
                GadgetButton val_4 = this.gadgetButtonScript;
            丙一丘丆三丌万丂丅 val_6 = this.丙三专一丛丕丄丐丝.Item[0];
            val_4.duration.fillAmount = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_6.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()].且丑丂丐不七丌丌丂();
            GadgetButton val_10 = this.gadgetButtonScript;
            丙一丘丆三丌万丂丅 val_12 = this.丙三专一丛丕丄丐丝.Item[0];
            val_62 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_12.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()].世丙丈丁丘七七丌丝();
            val_10.cooldown.fillAmount = val_62;
            丙一丘丆三丌万丂丅 val_17 = this.丙三专一丛丕丄丐丝.Item[0];
            不丘丄丝丗丒丙一丌 val_19 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_17.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()];
            if(this.下与丘丞丁丅丄下丂 != 1)
        {
                丙一丘丆三丌万丂丅 val_20 = this.丙三专一丛丕丄丐丝.Item[0];
            if(this.下与丘丞丁丅丄下丂 != val_20.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌())
        {
                this.且专上丛丌丈专丕丅 = val_19 & 1;
        }
        
        }
        
            if(((val_19 & 1) != 0) && (this.且专上丛丌丈专丕丅 != true))
        {
                this.且专上丛丌丈专丕丅 = true;
            GadgetButton val_23 = this.gadgetButtonScript;
            UITweener val_24 = val_23.cooldownEnds.GetComponent<UITweener>();
            val_24.ResetToBeginning();
            val_24.PlayForward();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                GadgetButton val_26 = this.gadgetButtonScript;
            val_26.cooldownEnds.GetComponent<UnityEngine.AudioSource>().Play();
        }
        
        }
        
            val_66 = this.丙三专一丛丕丄丐丝;
            this.且专上丛丌丈专丕丅 = val_19 & 1;
            丙一丘丆三丌万丂丅 val_29 = val_66.Item[0];
            this.下与丘丞丁丅丄下丂 = val_29.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌();
        }
        
            if(this.丙三专一丛丕丄丐丝.Count >= 2)
        {
                GadgetButton val_32 = this.gadgetButtonScript;
            丙一丘丆三丌万丂丅 val_34 = this.丙三专一丛丕丄丐丝.Item[1];
            val_32.duration1.fillAmount = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_34.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()].且丑丂丐不七丌丌丂();
            GadgetButton val_38 = this.gadgetButtonScript;
            丙一丘丆三丌万丂丅 val_40 = this.丙三专一丛丕丄丐丝.Item[1];
            val_66 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_40.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()];
            val_62 = val_66.世丙丈丁丘七七丌丝();
            val_38.cooldown1.fillAmount = val_62;
        }
        
            if(this.丙三专一丛丕丄丐丝.Count >= 3)
        {
                GadgetButton val_45 = this.gadgetButtonScript;
            val_65 = 1152921536478226384;
            丙一丘丆三丌万丂丅 val_47 = this.丙三专一丛丕丄丐丝.Item[2];
            val_45.duration2.fillAmount = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_47.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()].且丑丂丐不七丌丌丂();
            GadgetButton val_51 = this.gadgetButtonScript;
            丙一丘丆三丌万丂丅 val_53 = this.丙三专一丛丕丄丐丝.Item[2];
            val_66 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().Item[val_53.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌()];
            val_51.cooldown2.fillAmount = val_66.世丙丈丁丘七七丌丝();
        }
        
        }
        
        GadgetButton val_57 = this.gadgetButtonScript;
        if(this.CanExtend() == false)
        {
            goto label_96;
        }
        
        val_66 = 1152921505286238208;
        val_67 = null;
        val_67 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_96;
        }
        
        val_68 = null;
        val_68 = null;
        val_69 = 万丐丘与丙丂丕下丒();
        goto label_101;
        label_96:
        val_69 = 0;
        label_101:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_57.yazichok, 丏业丟一东丂东丘丛:  false);
    }
    private void 与业丑下上丆丟与三(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不, GadgetCategory 丌丙专丟丆丘上一丒, FilterMaps 专丆丌丛东一不丑丙)
    {
        this.东丞丝且丐丄业丄丏();
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 == false)
        {
                return;
        }
        
        ChooseGadgetPanel.一七且丗世上上丏丞();
        this.与不丕且东专丝丒丕();
    }
    private void OnDisable()
    {
        if(ChooseGadgetPanel.丞丝丗丐丕丌上业丒 == null)
        {
                return;
        }
        
        ChooseGadgetPanel.丞丝丗丐丕丌上业丒.Invoke();
    }
    private void OnDestroy()
    {
        ChooseGadgetPanel.一七且丗世上上丏丞();
        丆丟七丌丞东丆丕丌.丂丌业一专业丑丛丛(丙业与丙丗丝不丈东:  new System.Action<System.String, System.String, GadgetCategory, FilterMaps>(object:  this, method:  System.Void ChooseGadgetPanel::与业丑下上丆丟与三(string 丛丆东与丑丞丅丝专, string 不丁丌丐业丑丟且不, GadgetCategory 丌丙专丟丆丘上一丒, FilterMaps 专丆丌丛东一不丑丙)));
        this.与不丕且东专丝丒丕();
    }
    private void 与不丕且东专丝丒丕()
    {
        if(this.一东丅丌世世丏丟七 == false)
        {
                return;
        }
        
        this = 1152921505266909184;
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "ChooseGadgetPanel.GADGET_PANEL_HINTS_SHOWN_KEY", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) != 0)
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "ChooseGadgetPanel.GADGET_PANEL_HINTS_SHOWN_KEY", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void Show()
    {
        万下丒丞丛万三专丈 val_2 = this.东业专丏东丌世丒世;
        val_2 = val_2 - 1;
        if(val_2 <= 1)
        {
                this.东业专丏东丌世丒世 = 3;
            this.一东丅丌世世丏丟七 = true;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.swipeToOpenHint, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetHint, 丏业丟一东丂东丘丛:  true);
        }
        
        this.gadgetButtonScript.OpenGadgetPanel(丁与万丂丝丒丐万丄:  true);
    }
    public void Hide()
    {
        if(this.东业专丏东丌世丒世 == 3)
        {
                this.东业专丏东丌世丒世 = 4;
            this.一东丅丌世世丏丟七 = true;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.swipeToOpenHint, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.chooseGadgetHint, 丏业丟一东丂东丘丛:  false);
        }
        
        this.gadgetButtonScript.OpenGadgetPanel(丁与万丂丝丒丐万丄:  false);
    }
    public void ChooseDefault()
    {
    
    }
    public void ChooseFirst()
    {
        if(this.丙三专一丛丕丄丐丝.Count < 2)
        {
                return;
        }
        
        丙一丘丆三丌万丂丅 val_2 = this.丙三专一丛丕丄丐丝.Item[1];
        丁下万丟且丟丛下业.丛丁七业东上世丅丛(丙业与丙丗丝不丈东:  val_2.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌());
        this.东丞丝且丐丄业丄丏();
    }
    public void ChooseSecond()
    {
        if(this.丙三专一丛丕丄丐丝.Count < 3)
        {
                return;
        }
        
        丙一丘丆三丌万丂丅 val_2 = this.丙三专一丛丕丄丐丝.Item[2];
        丁下万丟且丟丛下业.丛丁七业东上世丅丛(丙业与丙丗丝不丈东:  val_2.丁丏专且丙下丒丕不.丒万丕七专不丏丞丌());
        this.东丞丝且丐丄业丄丏();
    }
    public bool CanExtend()
    {
        return (bool)(this.丙三专一丛丕丄丐丝.Count > 1) ? 1 : 0;
    }
    private void 东丞丝且丐丄业丄丏()
    {
        ChooseGadgetPanel val_35;
        var val_39;
        var val_40;
        var val_42;
        System.Comparison<丙一丘丆三丌万丂丅> val_44;
        val_35 = this;
        int val_1 = this.丙三专一丛丕丄丐丝.Count;
        this.丙三专一丛丕丄丐丝.CopyTo(array:  new 丙一丘丆三丌万丂丅[0]);
        this.丙三专一丛丕丄丐丝.Clear();
        var val_38 = 0;
        val_38 = val_38 + 1;
        System.Collections.Generic.IEnumerator<T> val_7 = System.Linq.Enumerable.OfType<GadgetCategory>(source:  System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))).GetEnumerator();
        label_35:
        var val_39 = 0;
        val_39 = val_39 + 1;
        if(val_7.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_40 = 0;
        val_40 = val_40 + 1;
        T val_11 = val_7.Current;
        不丘丄丝丗丒丙一丌 val_13 = 0;
        bool val_14 = 东丟丟万下丛丆丛丟.不丐丝七上丄丕丐丅().TryGetValue(key:  val_11, value: out  val_13);
        if(val_13 == 0)
        {
            goto label_35;
        }
        
        new 丙一丘丆三丌万丂丅() = new 丙一丘丆三丌万丂丅();
        .丌丟三丅上丅上丗丞 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_13.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  val_11, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        .丁丏专且丙下丒丕不 = val_13;
        this.丙三专一丛丕丄丐丝.Add(item:  new 丙一丘丆三丌万丂丅());
        goto label_35;
        label_18:
        val_39 = 0;
        val_40 = 0;
        if(val_7 == null)
        {
            
        }
        else
        {
                var val_41 = 0;
            val_41 = val_41 + 1;
            val_7.Dispose();
        }
        
        val_42 = null;
        val_42 = null;
        val_44 = ChooseGadgetPanel.<>c.<>9__34_0;
        if(val_44 == null)
        {
            goto label_59;
        }
        
        label_88:
        this.丙三专一丛丕丄丐丝.Sort(comparison:  val_44);
        if(this.丙三专一丛丕丄丐丝.Count < 1)
        {
                return;
        }
        
        UIBasicSprite val_21 = this.gadgetButtonScript.GadgetIcon;
        丙一丘丆三丌万丂丅 val_22 = this.丙三专一丛丕丄丐丝.Item[0];
        val_44 = val_22.丌丟三丅上丅上丗丞;
        if(this.丙三专一丛丕丄丐丝.Count < 2)
        {
                return;
        }
        
        UIBasicSprite val_25 = this.gadgetButtonScript.GadgetIcon1;
        丙一丘丆三丌万丂丅 val_26 = this.丙三专一丛丕丄丐丝.Item[1];
        if(this.丙三专一丛丕丄丐丝.Count >= 3)
        {
                UIBasicSprite val_29 = this.gadgetButtonScript.GadgetIcon2;
            丙一丘丆三丌万丂丅 val_30 = this.丙三专一丛丕丄丐丝.Item[2];
        }
        
        GadgetButton val_31 = this.gadgetButtonScript;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31.thirdAvailableGadgetCell, 丏业丟一东丂东丘丛:  (this.丙三专一丛丕丄丐丝.Count > 2) ? 1 : 0);
        GadgetButton val_34 = this.gadgetButtonScript;
        val_44 = this.丙三专一丛丕丄丐丝;
        val_35 = val_34.thirdAvailableGadgetFrame;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_35, 丏业丟一东丂东丘丛:  (val_44.Count > 2) ? 1 : 0);
        return;
        label_59:
        ChooseGadgetPanel.<>c.<>9__34_0 = new System.Comparison<丙一丘丆三丌万丂丅>(object:  ChooseGadgetPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ChooseGadgetPanel.<>c::上丘世下丗丏丈丄下(丙一丘丆三丌万丂丅 丆丆东万一与业七下, 丙一丘丆三丌万丂丅 丂丝丙丟三上丐丐三));
        if(this.丙三专一丛丕丄丐丝 != null)
        {
            goto label_88;
        }
        
        goto label_88;
    }
    private static void 一七且丗世上上丏丞()
    {
        var val_5;
        if(GameConnect.一与东丝万上三丆丏() == true)
        {
                return;
        }
        
        val_5 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "GadgetsInfo.DefaultGadgetKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        if(val_5 == 丁下万丟且丟丛下业.下丁丗丁丅下丆丂丌())
        {
                return;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "GadgetsInfo.DefaultGadgetKey", 下下丏一丙不丘丌丞:  丁下万丟且丟丛下业.下丁丗丁丅下丆丂丌(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private static void 丟丛丆丄丅不丞三丒()
    {
        int val_1 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "GadgetsInfo.DefaultGadgetKey", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        丁下万丟且丟丛下业.丛丁七业东上世丅丛(丙业与丙丗丝不丈东:  (val_1 == 0) ? 12500 : (val_1));
    }
    public ChooseGadgetPanel()
    {
        this.丙三专一丛丕丄丐丝 = new System.Collections.Generic.List<丙一丘丆三丌万丂丅>();
        this.下与丘丞丁丅丄下丂 = 0;
        this.且专上丛丌丈专丕丅 = true;
    }

}
