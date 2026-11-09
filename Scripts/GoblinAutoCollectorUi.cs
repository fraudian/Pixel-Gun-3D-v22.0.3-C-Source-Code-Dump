using UnityEngine;
internal sealed class GoblinAutoCollectorUi : StorePromotionExtendUIAbstract
{
    // Fields
    private static System.Action<GoblinAutoCollectorUi.与且三与丌不丁丂七> 丛丄业丘不丆丄三丞;
    private static System.Action 丂丂一丂丏一世丝东;
    private UIPanel _holderPanel;
    private UILabel _labelTitle;
    private UILabel _labelTime;
    private UILabel _labelDiscription;
    private UnityEngine.GameObject _infoContainer;
    private UnityEngine.GameObject _collectContainer;
    private UnityEngine.GameObject _purchaseContainer;
    private UnityEngine.GameObject _buffSilverContaier;
    private PGCompany.TimerUI _timerUi;
    private UILabel _silverLabel;
    private UILabel _valorLabel;
    private UILabel _rankLabel;
    private UILabel _totalAmountLabel;
    private GoblinAutoCollectorUi.与且三与丌不丁丂七 丟专丒丘丂丏专丄一;
    private System.Func<int, string> 丆不丝丂下与丙丆丌;
    
    // Properties
    public System.Func<int, string> 丅丌丞万丅丗且丒与 { get; }
    
    // Methods
    internal static void 丈丗丐丗丛丝丕丙一(System.Action<GoblinAutoCollectorUi.与且三与丌不丁丂七> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  GoblinAutoCollectorUi.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
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
    internal static void 丟不丛世下东且丗丈(System.Action<GoblinAutoCollectorUi.与且三与丌不丁丂七> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  GoblinAutoCollectorUi.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
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
    internal static void 且丝一丌丈丅三丛丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  GoblinAutoCollectorUi.丂丂一丂丏一世丝东, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GoblinAutoCollectorUi.丂丂一丂丏一世丝东 != 1152921505154879496);
    
    }
    internal static void 丟不丌丁丆丝丟东丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  GoblinAutoCollectorUi.丂丂一丂丏一世丝东, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(GoblinAutoCollectorUi.丂丂一丂丏一世丝东 != 1152921505154879496);
    
    }
    public System.Func<int, string> get_TimeFormatter()
    {
        System.Func<System.Int32, System.String> val_2;
        var val_3;
        val_2 = this.丆不丝丂下与丙丆丌;
        if(val_2 != null)
        {
                return (System.Func<System.Int32, System.String>)val_2;
        }
        
        val_3 = null;
        val_3 = null;
        val_2 = GoblinAutoCollectorUi.<>c.<>9__23_0;
        if(val_2 == null)
        {
                System.Func<System.Int32, System.String> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Func<System.Int32, System.String>(object:  GoblinAutoCollectorUi.<>c.__il2cppRuntimeField_static_fields, method:  System.String GoblinAutoCollectorUi.<>c::丛丄与丐丙丌丙上且(int 三丟东丕丄丄下下丑));
            GoblinAutoCollectorUi.<>c.<>9__23_0 = val_2;
        }
        
        this.丆不丝丂下与丙丆丌 = val_2;
        return (System.Func<System.Int32, System.String>)val_2;
    }
    private void Awake()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._labelTitle, 丕丗丘丑丛与丑业丒:  一丅三东丑丗丅丗丝.丂东丛丆丈丝丏丄丌());
    }
    internal void 丞三业东丐丛丛丈丄()
    {
        this._holderPanel.depth = 244;
    }
    protected override void OnDisable()
    {
        if(this == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.Dispose();
    }
    internal void 丈且东丑丂且万丒丅(GoblinAutoCollectorUi.与且三与丌不丁丂七 丙且丄丑丂万丅丘丗)
    {
        object val_38;
        UnityEngine.GameObject val_39;
        var val_40;
        val_38 = this;
        this.丟专丒丘丂丏专丄一 = 丙且丄丑丂万丅丘丗;
        val_39 = this.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_39, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._infoContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._collectContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchaseContainer, 丏业丟一东丂东丘丛:  false);
        if(丙且丄丑丂万丅丘丗 == 3)
        {
            goto label_3;
        }
        
        if(丙且丄丑丂万丅丘丗 == 2)
        {
            goto label_4;
        }
        
        if(丙且丄丑丂万丅丘丗 != 1)
        {
            goto label_5;
        }
        
        mem[1152921536743238560] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  typeof(GoblinAutoCollectorUi).__il2cppRuntimeField_1B0), 与且专丈不万东一万:  "GoblinAutoCollectorUi" + this.gameObject.name);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._infoContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUi, 丏业丟一东丂东丘丛:  true);
        this._timerUi.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._labelDiscription, 丕丗丘丑丛与丑业丒:  一丅三东丑丗丅丗丝.丛业且一丛丘丅丑不());
        return;
        label_3:
        mem[1152921536743238560] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "GoblinAutoCollectorUi" + this.gameObject.name);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._purchaseContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUi, 丏业丟一东丂东丘丛:  false);
        val_39 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8943");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._totalAmountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_39, arg0:  一丅三东丑丗丅丗丝.丄丆且丐丛丛丅丏丂(), arg1:  一丅三东丑丗丅丗丝.丈丐不丛与丁世丕丏()));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._labelTime, 丕丗丘丑丛与丑业丒:  this.丘与专上丞且丅丝与());
        return;
        label_4:
        mem[1152921536743238560] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  typeof(GoblinAutoCollectorUi).__il2cppRuntimeField_1B0), 与且专丈不万东一万:  "GoblinAutoCollectorUi" + this.gameObject.name);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._collectContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buffSilverContaier, 丏业丟一东丂东丘丛:  (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerUi, 丏业丟一东丂东丘丛:  true);
        this._timerUi.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        PGCompany.三东丏不丗世丅丌丄 val_29 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79);
        val_29.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  一丅三东丑丗丅丗丝.业专丙一丄三丒上丛());
        val_39 = 1152921504622075904;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._silverLabel, 丕丗丘丑丛与丑业丒:  PGCompany.万丞丘与丕丞下万丌.丐丝不七与丑且丟丝(丈丄不七三万丄丁不:  val_29).丂丁丏一丙丛业且丌());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._valorLabel, 丕丗丘丑丛与丑业丒:  一丅三东丑丗丅丗丝.丂一丈丕丟丆世东上());
        val_40 = null;
        val_40 = null;
        val_38 = this._rankLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_38, 丕丗丘丑丛与丑业丒:  一丅三东丑丗丅丗丝.丌与丒丑业世七七丏() * (丌丅且丗七丘丅丛丑.业丏丐下专东万世丂(丅专与丒丈丗丒丘丌:  丌丅且丗七丘丅丛丑.下万丈且丈上三丟七)));
        一丅三东丑丗丅丗丝.丑丏上丙丝丑丒丅业();
        if(GoblinAutoCollectorUi.丂丂一丂丏一世丝东 == null)
        {
                return;
        }
        
        GoblinAutoCollectorUi.丂丂一丂丏一世丝东.Invoke();
        return;
        label_5:
        object[] val_37 = new object[1];
        val_38 = val_37;
        val_38[0] = 丙且丄丑丂万丅丘丗;
        UnityEngine.Debug.LogErrorFormat(format:  " ------  {0}", args:  val_37);
    }
    private string 丘与专上丞且丅丝与()
    {
        PGCompany.ClanStoreBuffSetting val_3 = PGCompany.ClanStoreBuffsController.丑七不且上丗丁一世().业丆丐丘丞上丅丕丛(丞世不丒下上上丝丑:  一丅三东丑丗丅丗丝.丝丂七东丛丕世与丐());
        return (string)System.String.Format(format:  "{0} + {1}", arg0:  this.TimeFormatter.Invoke(arg:  2071995896), arg1:  this.TimeFormatter.Invoke(arg:  2071995928));
    }
    public void BigButtonHide()
    {
        if(this.丟专丒丘丂丏专丄一 != 3)
        {
            goto typeof(GoblinAutoCollectorUi).__il2cppRuntimeField_1A8;
        }
    
    }
    public override void Hide()
    {
        this.Hide();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if(GoblinAutoCollectorUi.丛丄业丘不丆丄三丞 == null)
        {
                return;
        }
        
        GoblinAutoCollectorUi.丛丄业丘不丆丄三丞.Invoke(obj:  this.丟专丒丘丂丏专丄一);
    }
    public GoblinAutoCollectorUi()
    {
    
    }

}
