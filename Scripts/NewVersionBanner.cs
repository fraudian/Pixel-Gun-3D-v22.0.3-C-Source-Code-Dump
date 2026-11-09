using UnityEngine;
public class NewVersionBanner : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> scrollArrows;
    private UILabel _labelVersion;
    private UIWrapContent _wrap;
    private NewVersionBannerScrollItemView _defaultChangeView;
    private UnityEngine.GameObject _resetBtn;
    internal static bool 丘丌丌丙万世丌与丆;
    internal static bool 丑丏丆一丅七业世丙;
    private bool 丌不丁丐丄丆丏丌丕;
    private bool 东东一三丟丌丕业丕;
    private int 不与丆专不丐丝丛东;
    private System.IDisposable 丐丆七且丞丏下三丙;
    private static bool <丈丝下不丒与丑丙不>k__BackingField;
    private static bool <且丆丅丑丁万丁且丌>k__BackingField;
    private static System.Action 丝丆丈下上丄丟世丛;
    
    // Properties
    internal static bool 且丒东丂丐丘上东丑 { get; set; }
    internal static bool 世丑丗上丘丟丐丂丕 { get; set; }
    internal static bool 丌专丈七不世不专三 { get; }
    
    // Methods
    internal static bool 丛丑东丆丗丘丂丌上()
    {
        null = null;
        return (bool)NewVersionBanner.<丈丝下不丒与丑丙不>k__BackingField;
    }
    internal static void 专丘丕一丏一三丆东(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        NewVersionBanner.<丈丝下不丒与丑丙不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 七三丂丕丕世丙上不()
    {
        null = null;
        return (bool)NewVersionBanner.<且丆丅丑丁万丁且丌>k__BackingField;
    }
    private static void 丅丄丅万丂丗丘丕丘(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        NewVersionBanner.<且丆丅丑丁万丁且丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 世东丙三丗丐丌专丛()
    {
        long val_16;
        if((System.DateTime.TryParse(s:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐丂丂丏丄一丒丅丁(), 丞丌丑丛上丕丙丕下:  ""), result: out  new System.DateTime())) == false)
        {
            goto label_7;
        }
        
        System.DateTime val_4 = System.DateTime.UtcNow;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_4.dateData}, d2:  new System.DateTime());
        val_16 = val_5._ticks;
        System.TimeSpan val_6 = System.TimeSpan.FromHours(value:  12);
        if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_16}, t2:  new System.TimeSpan() {_ticks = val_6._ticks})) == false)
        {
            goto label_12;
        }
        
        NewVersionBanner.丟丘不丕七丙丂业丞();
        return true;
        label_7:
        val_16 = 与丂丏丛丞丞丒丟丄.丐丂丂丏丄一丒丅丁();
        System.DateTime val_9 = 专七专下且专三一且.丐世丈专与东丏丛丑();
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_16, 下下丏一丙不丘丌丞:  val_9.dateData);
        return true;
        label_12:
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘())) != false)
        {
                var val_14 = ((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) > 0) ? 1 : 0;
            return true;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘(), 下下丏一丙不丘丌丞:  3, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        return true;
    }
    internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丅专与丒丈丗丒丘丌, System.Action 丆丑丞丅不丕丐丙丂)
    {
        var val_11;
        var val_12;
        var val_13;
        val_12 = null;
        if(NewVersionBanner.七三丂丕丕世丙上不() == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "banners/NewVersion"), parent:  丅专与丒丈丗丒丘丌);
        int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_3, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "IndicatorLoading"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        val_3.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        val_11 = val_3.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        val_11.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        int val_10 = 不丌丂丁丄一与丆丙.丘丞东且丐丞下丛丁(丝三丁东丈丒世丅业:  val_3, 丙丘丏上丗丗丐丕丞:  100);
        val_13 = null;
        val_13 = null;
        NewVersionBanner.丝丆丈下上丄丟世丛 = 丆丑丞丅不丕丐丙丂;
        NewVersionBanner.丅丄丅万丂丗丘丕丘(丙业与丙丗丝不丈东:  true);
    }
    protected void OnEnable()
    {
        var val_59;
        int val_60;
        var val_61;
        var val_62;
        UnityEngine.Transform val_63;
        NewVersionBanner.上三且上丁业与与丑 val_64;
        System.Action<T> val_65;
        NewVersionBanner.上三且上丁业与与丑 val_1 = new NewVersionBanner.上三且上丁业与与丑();
        this._labelVersion.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3638"), arg0:  UpdatesChecker.丝业丙丈东丐七丂丒());
        System.Collections.Generic.List<VersionChange> val_5 = UpdatesChecker.丞世丁丕丌东丈丗丆();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<VersionChange>(丑东与丅丐丅丂丞业:  val_5)) != false)
        {
                val_59 = 1;
        }
        else
        {
                if(val_5.Count == 2)
        {
                val_59 = 4;
        }
        else
        {
                val_59 = val_5;
        }
        
        }
        
        this.不与丆专不丐丝丛东 = val_59.Count;
        val_60 = this.不与丆专不丐丝丛东;
        if(this._wrap.gameObject.transform.childCount <= val_60)
        {
            goto label_17;
        }
        
        goto label_18;
        label_28:
        UnityEngine.Object.Destroy(obj:  this._wrap.gameObject.transform.GetChild(index:  val_60).gameObject);
        val_60 = val_60 + 1;
        label_18:
        val_61 = 0;
        if(val_60 < this._wrap.gameObject.transform.childCount)
        {
            goto label_28;
        }
        
        goto label_37;
        label_17:
        val_61 = 0;
        if(this._wrap.gameObject.transform.childCount < this.不与丆专不丐丝丛东)
        {
                val_61 = 0;
            int val_59 = this._wrap.gameObject.transform.childCount;
            if(val_59 < this.不与丆专不丐丝丛东)
        {
                val_62 = 1152921504622075904;
            do
        {
            NewVersionBannerScrollItemView val_25 = UnityEngine.Object.Instantiate<NewVersionBannerScrollItemView>(original:  this._defaultChangeView);
            string val_27 = System.String.Format(format:  "{0} {1}", arg0:  val_25.name, arg1:  val_59);
            if(val_25 != null)
        {
                val_25.name = val_27;
        }
        else
        {
                val_25.name = val_27;
        }
        
            val_63 = this._wrap.transform;
            val_25.transform.SetParent(p:  val_63);
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.one;
            val_25.transform.localScale = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.zero;
            val_61 = 0;
            val_25.transform.localPosition = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
            val_59 = val_59 + 1;
        }
        while(val_59 < this.不与丆专不丐丝丛东);
        
        }
        
        }
        
        label_37:
        this.丌世七万丘万世丐不();
        val_64 = val_1;
        UIScrollView val_35 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UIScrollView>(丝三丁东丈丒世丅业:  this._wrap.gameObject);
        if(val_64 != 0)
        {
                mem[1152921531059819552] = val_35;
        }
        else
        {
                val_64 = 16;
            mem[16] = val_35;
        }
        
        val_64.enabled = (this._wrap.gameObject.transform.childCount > 1) ? 1 : 0;
        System.Action<UnityEngine.GameObject> val_40 = null;
        val_65 = val_40;
        val_40 = new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void NewVersionBanner.上三且上丁业与与丑::丈丆丙丕丆丝三丌与(UnityEngine.GameObject 丄三丅七丆丛与与上));
        this.scrollArrows.ForEach(action:  val_40);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁<VersionChange>(丑东与丅丐丅丂丞业:  val_5)) != false)
        {
                this._wrap.gameObject.transform.GetChild(index:  0).GetComponent<NewVersionBannerScrollItemView>().ResetToDafault();
        }
        else
        {
                val_63 = 1152921531059547344;
            if(this.不与丆专不丐丝丛东 >= 1)
        {
                val_62 = 1152921531059720400;
            var val_60 = 0;
            int val_47 = val_5.Count - 1;
            do
        {
            int val_49 = (val_47 < val_5.Count) ? (val_47) : 0;
            val_65 = this._wrap.gameObject.transform.GetChild(index:  0).GetComponent<NewVersionBannerScrollItemView>();
            val_65.SetChange(七与万丕丄万丞且三:  val_5.Item[val_49]);
            val_60 = val_60 + 1;
            val_49 = val_49 + 1;
        }
        while(val_60 < this.不与丆专不丐丝丛东);
        
        }
        
        }
        
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_61 = 0;
            val_61 = val_61 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void NewVersionBanner::NewVersionBannerExitClick()), 与且专丈不万东一万:  "New Version Banner");
    }
    private void 丌世七万丘万世丐不()
    {
        UIPanel val_2 = this.gameObject.GetComponent<UIPanel>();
        this.丌不丁丐丄丆丏丌丕 = true;
        this.东东一三丟丌丕业丕 = true;
    }
    private void 东与三下丏丞三丐万()
    {
        var val_13;
        var val_14;
        var val_13 = 0;
        val_13 = val_13 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this._wrap.gameObject).GetEnumerator();
        goto label_7;
        label_22:
        var val_14 = 0;
        val_14 = val_14 + 1;
        int val_15 = this._wrap.itemSize;
        val_15 = val_15 * 0;
        val_4.Current.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_7:
        var val_16 = 0;
        val_16 = val_16 + 1;
        if(val_4.MoveNext() == true)
        {
            goto label_22;
        }
        
        val_13 = 0;
        val_14 = 0;
        if(val_4 == null)
        {
            
        }
        else
        {
                var val_17 = 0;
            val_17 = val_17 + 1;
            val_4.Dispose();
        }
        
        丞东丑专丛丆丄丝世.丒丑东世丛不上丈丛(七万上丐一丈丏丏专:  this._wrap.gameObject, 丌丝三丌丗丄丌丈且:  false, 与丐丌万丁丒不业丕:  true, 丈与丗且丐专一一丌:  true);
        if(this._wrap != null)
        {
                return;
        }
    
    }
    private void Update()
    {
        if((this.东东一三丟丌丕业丕 != true) && (this.丌不丁丐丄丆丏丌丕 != false))
        {
                this._wrap.GetComponent<UICenterOnChild>().CenterOnInstant(丞下万上三丘上与专:  this._wrap.gameObject.transform.GetChild(index:  (this.不与丆专不丐丝丛东 > 1) ? 1 : 0).transform);
            this.丌不丁丐丄丆丏丌丕 = false;
            UIPanel val_8 = this.gameObject.GetComponent<UIPanel>();
        }
        
        this.东东一三丟丌丕业丕 = false;
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnDestroy()
    {
        NewVersionBanner.丅丄丅万丂丗丘丕丘(丙业与丙丗丝不丈东:  false);
    }
    private void 丆世与丑丆丅丐万且()
    {
        var val_2 = null;
        if(NewVersionBanner.丑丏丆一丅七业世丙 != false)
        {
                NewVersionBanner.丄七丄世丙七一丕业();
            val_2 = null;
        }
        
        val_2 = null;
        NewVersionBanner.丑丏丆一丅七业世丙 = false;
        NewVersionBanner.丘丌丌丙万世丌与丆 = false;
        NewVersionBanner.丅丄丅万丂丗丘丕丘(丙业与丙丗丝不丈东:  false);
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public void NewVersionBannerApplyClick()
    {
        var val_4;
        var val_5;
        System.Action val_6;
        UnityEngine.Application.OpenURL(url:  丄丛丏丄不一丆丐丑.丅丙业上丄不丘丝三());
        ButtonClickSound.丁业上丏不丕三丗不();
        val_4 = null;
        NewVersionBanner.丟丘不丕七丙丂业丞();
        if(NewVersionBanner.丛丑东丆丗丘丂丌上() == true)
        {
                return;
        }
        
        if(VersionBlocker.丟不丌三丙万业丘七() == true)
        {
                return;
        }
        
        this.丆世与丑丆丅丐万且();
        val_5 = null;
        val_5 = null;
        val_6 = NewVersionBanner.丝丆丈下上丄丟世丛;
        if(val_6 == null)
        {
                return;
        }
        
        val_6 = NewVersionBanner.丝丆丈下上丄丟世丛;
        if(val_6 == null)
        {
                val_6 = 0;
        }
        
        val_6.Invoke();
        NewVersionBanner.丝丆丈下上丄丟世丛 = 0;
    }
    public void NewVersionBannerExitClick()
    {
        var val_3;
        var val_4;
        System.Action val_5;
        val_3 = null;
        if(NewVersionBanner.丛丑东丆丗丘丂丌上() == true)
        {
                return;
        }
        
        if(VersionBlocker.丟不丌三丙万业丘七() == true)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        this.丆世与丑丆丅丐万且();
        val_4 = null;
        val_4 = null;
        val_5 = NewVersionBanner.丝丆丈下上丄丟世丛;
        if(val_5 == null)
        {
                return;
        }
        
        val_5 = NewVersionBanner.丝丆丈下上丄丟世丛;
        if(val_5 == null)
        {
                val_5 = 0;
        }
        
        val_5.Invoke();
        NewVersionBanner.丝丆丈下上丄丟世丛 = 0;
    }
    public void NewVersionBannerResetClick()
    {
    
    }
    private void 上丁专丙七丄东丒与(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
    }
    private static void 丄七丄世丙七一丕业()
    {
        var val_9;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘())) != false)
        {
                val_9 = (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘(), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) - 1;
        }
        else
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘(), 下下丏一丙不丘丌丞:  3, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            val_9 = 2;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘(), 下下丏一丙不丘丌丞:  2, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        System.DateTime val_8 = System.DateTime.UtcNow;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐丂丂丏丄一丒丅丁(), 下下丏一丙不丘丌丞:  val_8.dateData);
    }
    private static void 丟丘不丕七丙丂业丞()
    {
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.不七丟丑丅三三上丘(), 下下丏一丙不丘丌丞:  3, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        System.DateTime val_3 = System.DateTime.UtcNow;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐丂丂丏丄一丒丅丁(), 下下丏一丙不丘丌丞:  val_3.dateData);
    }
    public NewVersionBanner()
    {
        this.东东一三丟丌丕业丕 = true;
    }
    private static NewVersionBanner()
    {
        NewVersionBanner.丘丌丌丙万世丌与丆 = true;
        NewVersionBanner.丑丏丆一丅七业世丙 = false;
    }

}
