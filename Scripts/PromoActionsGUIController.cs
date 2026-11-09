using UnityEngine;
public class PromoActionsGUIController : MonoBehaviour
{
    // Fields
    internal const int 万丄丈业丐东丝专专 = 5;
    internal const int 丛万下丁丕丕丕丐丅 = 2;
    internal const int 丕丝万不专丗且丂丘 = 3;
    internal const string 丙下丙丒丄丐丙丐丛 = "StickersPromoActionsPanelKey";
    public UIWrapContent wrapContent;
    public UILabel noOffersLabel;
    public UILabel checkInternetLabel;
    public UnityEngine.GameObject fonPromoPanel;
    private bool 上丄丕丑丟丅万一东;
    private bool 与专下丏丙专东丈一;
    private int 丟丑一丌丁丌专丏丅;
    private static System.Collections.Generic.List<string> 东丟丆丘丒且丄世丌;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PromoActionsGUIController.丗丒业丆丁丝丒丄丈();
    }
    private void OnEnable()
    {
        if(this.与专下丏丙专东丈一 != true)
        {
                if(this.上丄丕丑丟丅万一东 == true)
        {
            goto label_1;
        }
        
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丁东业丅与丏丞专丟());
        label_1:
        this.与专下丏丙专东丈一 = false;
    }
    private void 丏业且丅丁丅丟不世()
    {
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丁东业丅与丏丞专丟());
    }
    private System.Collections.IEnumerator 丁东业丅与丏丞专丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PromoActionsGUIController.丐万丈丟丌业七一丟();
    }
    private void OnDestroy()
    {
        丅且东丙业丏丛东丛.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PromoActionsGUIController::丏业且丅丁丅丟不世()));
        StickersController.七丝丈丗业丑丈丒东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void PromoActionsGUIController::MarkUpdateOnEnable()));
    }
    private void Update()
    {
        var val_18;
        var val_21;
        var val_22;
        int val_26;
        val_18 = this.wrapContent.transform;
        if(val_18.childCount < 1)
        {
                return;
        }
        
        UIPanel val_4 = val_18.parent.GetComponent<UIPanel>();
        if(val_18.childCount > 3)
        {
            goto label_41;
        }
        
        System.Collections.IEnumerator val_6 = val_18.GetEnumerator();
        label_23:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_14;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        object val_10 = val_6.Current;
        UnityEngine.Vector3 val_13 = 0.localPosition;
        goto label_23;
        label_14:
        val_21 = 0;
        val_22 = 0;
        if(val_6 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_6.Dispose();
        }
        
        int val_15 = val_18.childCount;
        if(val_4 != 0)
        {
                val_18 = val_4.GetComponent<UIScrollView>();
        }
        
        label_41:
        val_26 = this.丟丑一丌丁丌专丏丅;
        int val_18 = val_26 * 1717986919;
        val_18 = val_18 >> 34;
        val_18 = val_18 + (val_18 >> 63);
        val_18 = val_26 - (val_18 * 10);
        if(val_18 == 0)
        {
                val_4.Refresh();
            val_26 = this.丟丑一丌丁丌专丏丅;
        }
        
        val_26 = val_26 + 1;
        this.丟丑一丌丁丌专丏丅 = val_26;
    }
    public void MarkUpdateOnEnable()
    {
        this.与专下丏丙专东丈一 = true;
        bool val_2 = this.gameObject.activeInHierarchy;
        if(val_2 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  val_2.丌业东万丌不丂丐丙());
    }
    private void 丄丁丙丕丑上三丕丏()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丌业东万丌不丂丐丙());
    }
    private static void 丁下专丁丝丗专与业(ref System.Collections.Generic.List<string> 东且丁丆丛丁丏丘且)
    {
        var val_19;
        var val_24;
        var val_25;
        var val_26;
        System.Func<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>> val_28;
        var val_29;
        System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.Boolean> val_31;
        var val_32;
        System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String> val_34;
        var val_35;
        System.Func<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>> val_37;
        var val_38;
        System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.Boolean> val_40;
        var val_41;
        System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String> val_43;
        var val_44;
        val_24 = 1152921535991861696;
        val_25 = null;
        val_25 = null;
        if(PromoActionsGUIController.东丟丆丘丒且丄世丌 == null)
        {
                val_26 = null;
            val_26 = null;
            val_28 = PromoActionsGUIController.<>c.<>9__19_0;
            if(val_28 == null)
        {
                System.Func<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>> val_2 = null;
            val_28 = val_2;
            val_2 = new System.Func<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且> PromoActionsGUIController.<>c::丁丝丟丑丅上三丟丝(string 与丘东下丈东丛丂万));
            PromoActionsGUIController.<>c.<>9__19_0 = val_28;
        }
        
            val_29 = null;
            val_29 = null;
            val_31 = PromoActionsGUIController.<>c.<>9__19_1;
            if(val_31 == null)
        {
                System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.Boolean> val_4 = null;
            val_31 = val_4;
            val_4 = new System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.Boolean>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PromoActionsGUIController.<>c::专丒世世上丙丒专丕(世丏丘丅丝万丆东业<string, 三丅丁丗丗丝丂万且> 丟业丙东三丂丈丘业));
            PromoActionsGUIController.<>c.<>9__19_1 = val_31;
        }
        
            val_32 = null;
            val_32 = null;
            val_34 = PromoActionsGUIController.<>c.<>9__19_2;
            if(val_34 == null)
        {
                System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String> val_6 = null;
            val_34 = val_6;
            val_6 = new System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String PromoActionsGUIController.<>c::丒丛丗丆七丁丟七三(世丏丘丅丝万丆东业<string, 三丅丁丗丗丝丂万且> 丟业丙东三丂丈丘业));
            PromoActionsGUIController.<>c.<>9__19_2 = val_34;
        }
        
            val_35 = null;
            val_35 = null;
            val_37 = PromoActionsGUIController.<>c.<>9__19_3;
            if(val_37 == null)
        {
                System.Func<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>> val_9 = null;
            val_37 = val_9;
            val_9 = new System.Func<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且> PromoActionsGUIController.<>c::下丄不业东丐丄丈一(string 与丘东下丈东丛丂万));
            PromoActionsGUIController.<>c.<>9__19_3 = val_37;
        }
        
            val_38 = null;
            val_38 = null;
            val_40 = PromoActionsGUIController.<>c.<>9__19_4;
            if(val_40 == null)
        {
                System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.Boolean> val_11 = null;
            val_40 = val_11;
            val_11 = new System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.Boolean>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PromoActionsGUIController.<>c::丁丙丝丛丘上不丘丏(世丏丘丅丝万丆东业<string, 三丅丁丗丗丝丂万且> 丟业丙东三丂丈丘业));
            PromoActionsGUIController.<>c.<>9__19_4 = val_40;
        }
        
            val_41 = null;
            val_41 = null;
            val_43 = PromoActionsGUIController.<>c.<>9__19_5;
            if(val_43 == null)
        {
                System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String> val_13 = null;
            val_43 = val_13;
            val_13 = new System.Func<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.String PromoActionsGUIController.<>c::丏丝且东世不丛专丕(世丏丘丅丝万丆东业<string, 三丅丁丗丗丝丂万且> 丟业丙东三丂丈丘业));
            PromoActionsGUIController.<>c.<>9__19_5 = val_43;
        }
        
            val_44 = null;
            val_44 = null;
            PromoActionsGUIController.东丟丆丘丒且丄世丌 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Concat<System.String>(first:  System.Linq.Enumerable.Select<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String>(source:  System.Linq.Enumerable.Where<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>>(source:  System.Linq.Enumerable.Select<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>>(source:  WeaponManager.丏不丆丌丅丕丐丝丟(), selector:  val_2), predicate:  val_4), selector:  val_6), second:  System.Linq.Enumerable.Select<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>, System.String>(source:  System.Linq.Enumerable.Where<世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>>(source:  System.Linq.Enumerable.Select<System.String, 世丏丘丅丝万丆东业<System.String, 三丅丁丗丗丝丂万且>>(source:  WeaponManager.丐上业丐丏丐万世丑(), selector:  val_9), predicate:  val_11), selector:  val_13)));
            val_25 = null;
        }
        
        val_25 = null;
        List.Enumerator<T> val_17 = PromoActionsGUIController.东丟丆丘丒且丄世丌.GetEnumerator();
        label_45:
        if((1320199520 & 1) == 0)
        {
            goto label_43;
        }
        
        东且丁丆丛丁丏丘且.Add(item:  val_19.丐丏七丌丕丗业且上());
        goto label_45;
        label_43:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        HashSet.Enumerator<T> val_22 = WeaponManager.丞上一丘丆三下丐丑().GetEnumerator();
        label_55:
        if((1320199496 & 1) == 0)
        {
            goto label_53;
        }
        
        东且丁丆丛丁丏丘且.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_55;
        label_53:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static System.Collections.Generic.List<string> 不世业丞丌丅丐丞七(System.Collections.Generic.IEnumerable<string> 丗丄下丈丑七丗丞专, bool 丑且丅世下万世一丒 = False)
    {
        var val_15;
        var val_19;
        var val_48;
        var val_50;
        var val_51;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_60;
        var val_61;
        var val_62;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        var val_50 = 0;
        val_50 = val_50 + 1;
        System.Collections.Generic.IEnumerator<T> val_4 = 丗丄下丈丑七丗丞专.GetEnumerator();
        val_50 = 0;
        val_51 = 0;
        var val_54 = 0;
        label_105:
        var val_51 = 0;
        val_51 = val_51 + 1;
        if(val_4.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_52 = 0;
        val_52 = val_52 + 1;
        T val_9 = val_4.Current;
        if((七丌丞万七万丁丐丙.丗且且丁万丛丗与一().Contains(item:  val_9)) == false)
        {
            goto label_20;
        }
        
        val_1.Add(item:  val_9);
        goto label_105;
        label_20:
        Dictionary.Enumerator<TKey, TValue> val_12 = 七丌丞万七万丁丐丙.且不业七三丏与丐丙().GetEnumerator();
        val_54 = 0;
        label_77:
        if((1320445632 & 1) == 0)
        {
            goto label_26;
        }
        
        ConfiguredValueTaskAwaiter val_16 = val_15.GetAwaiter();
        List.Enumerator<T> val_17 = val_16._value._obj.GetEnumerator();
        label_30:
        if((1320445584 & 1) == 0)
        {
            goto label_28;
        }
        
        string val_20 = val_19.丐丏七丌丕丗业且上();
        if((val_20.Contains(item:  val_9)) == false)
        {
            goto label_30;
        }
        
        val_55 = null;
        val_48 = 1320445456;
        val_55 = null;
        if((TempItemsController.上且丗丌东丟丂世丒.ContainsKey(key:  val_9)) == false)
        {
            goto label_34;
        }
        
        val_56 = val_54 + 1;
        mem2[0] = 329;
        goto label_35;
        label_28:
        val_56 = val_54 + 1;
        mem2[0] = 329;
        goto label_36;
        label_34:
        int val_23 = val_20.IndexOf(item:  val_9);
        int val_27 = 七丌丞万七万丁丐丙.丅上业丛丛丈丒丝丐(与丘东下丈东丛丂万:  val_9);
        int val_28 = ExpController.万上一丝丆且七丅丅();
        bool val_33 = (七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  val_16._value._obj.丙东专丂世丈丏丁丂()).Contains(item:  val_9)) ^ 1;
        var val_34 = (val_23 == 0) ? 1 : 0;
        val_34 = val_34 & val_33;
        if((val_34 == true) && (val_27 <= val_28))
        {
                val_57 = 1;
        }
        else
        {
                val_33 = ((val_23 > 0) ? 1 : 0) & val_33;
            if(val_33 == true)
        {
                var val_41 = (val_27 <= val_28) ? 1 : 0;
            val_41 = val_41 | 丑且丅世下万世一丒 ^ 1;
            val_41 = val_41 & (七丌丞万七万丁丐丙.与不专丅三丈丄丈上(七丆丒与丗丌丄且丂:  val_16._value._obj.丙东专丂世丈丏丁丂()).Contains(item:  val_20.Item[val_23 - 1]));
            val_57 = val_41;
        }
        else
        {
                val_57 = 0;
        }
        
        }
        
        val_48 = val_48;
        val_56 = val_54 + 1;
        mem2[0] = 329;
        label_35:
        label_36:
        val_58 = val_51;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_56 == 1) || ((val_48 + ((0 + 1)) << 2) != 329))
        {
            goto label_74;
        }
        
        var val_53 = 0;
        val_53 = val_53 ^ (val_56 >> 31);
        val_56 = val_56 + val_53;
        goto label_77;
        label_74:
        if( == 0)
        {
            goto label_77;
        }
        
        goto label_77;
        label_26:
        val_54 = val_54 + 1;
        mem2[0] = 357;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_56 != 1) && ((val_48 + ((0 + 1)) << 2) == 357))
        {
                var val_55 = 0;
            val_55 = val_55 ^ (val_56 >> 31);
            val_56 = val_56 + val_55;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        if((((val_57 != (((七丌丞万七万丁丐丙.丝丆丌丘丄丛与丆不(七丆丒与丗丌丄且丂:  val_16._value._obj.丙东专丂世丈丏丁丂(), 丝丒丞丙丐一一丅三:  val_9)) <= RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()) ? 1 : 0)) ? 1 : 0) & 1) == 0)
        {
                val_60 = null;
            val_60 = null;
            if((SkinsController.丛上不下丐丐丞丒专.ContainsKey(key:  val_9)) != true)
        {
                if(( | (val_9.Equals(value:  "CustomSkinID"))) == false)
        {
            goto label_98;
        }
        
        }
        
            val_61 = null;
            val_61 = null;
            if((TempItemsController.上且丗丌东丟丂世丒.ContainsKey(key:  val_9)) != true)
        {
                val_1.Add(item:  val_9);
        }
        
        }
        
        label_98:
        val_62 = null;
        val_62 = null;
        if((TempItemsController.上且丗丌东丟丂世丒.ContainsKey(key:  val_9)) == false)
        {
            goto label_105;
        }
        
        val_1.Add(item:  val_9);
        goto label_105;
        label_13:
        val_54 = val_54 + 1;
        mem2[0] = 461;
        if(val_4 == null)
        {
            
        }
        else
        {
                var val_56 = 0;
            val_56 = val_56 + 1;
            val_4.Dispose();
        }
        
        if(val_56 != 1)
        {
                if( == 0)
        {
                return val_1;
        }
        
            if((val_48 + ((0 + 1)) << 2) == 461)
        {
                return val_1;
        }
        
            return val_1;
        }
        
        if( != 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    private System.Collections.IEnumerator 丌业东万丌不丂丐丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new PromoActionsGUIController.丗上上专七业一一上();
    }
    internal static System.Collections.Generic.List<三丅丁丗丗丝丂万且> 丗东丏丒万丝万万丘(int 丈丘丝一丗下丈丐不)
    {
        int val_22;
        var val_23;
        var val_24;
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_26;
        var val_27;
        System.Func<三丅丁丗丗丝丂万且, System.Int32> val_29;
        var val_30;
        System.Func<System.Linq.IGrouping<System.Int32, 三丅丁丗丗丝丂万且>, System.Boolean> val_32;
        var val_33;
        System.Func<System.Linq.IGrouping<System.Int32, 三丅丁丗丗丝丂万且>, System.Linq.IOrderedEnumerable<三丅丁丗丗丝丂万且>> val_35;
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_36;
        var val_40;
        val_22 = 丈丘丝一丗下丈丐不;
        PromoActionsGUIController.上三且上丁业与与丑 val_1 = new PromoActionsGUIController.上三且上丁业与与丑();
        if(val_1 != null)
        {
                val_23 = val_1;
            .丈丘丝一丗下丈丐不 = val_22;
        }
        else
        {
                val_23 = 16;
            mem[16] = val_22;
            val_22 = mem[16];
        }
        
        if((val_22 < 1) || (val_23 >= 66))
        {
            goto label_5;
        }
        
        new PromoActionsGUIController.丑丛丑万与丆丝丞丐() = new System.Object();
        .东丟且丗且三专丙丁 = val_1;
        System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
        .上丒丕丗世丈一丅下 = null;
        PromoActionsGUIController.丁下专丁丝丗专与业(东且丁丆丛丁丏丘且: ref  .上丒丕丗世丈一丅下);
        System.Func<三丅丁丗丗丝丂万且, System.Boolean> val_5 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  new PromoActionsGUIController.丑丛丑万与丆丝丞丐(), method:  System.Boolean PromoActionsGUIController.丑丛丑万与丆丝丞丐::业且丑不丆丅三丐七(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
        val_24 = null;
        val_24 = null;
        val_26 = PromoActionsGUIController.<>c.<>9__23_1;
        if(val_26 == null)
        {
                val_26 = null;
            val_26 = new System.Func<三丅丁丗丗丝丂万且, System.Boolean>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PromoActionsGUIController.<>c::三一丅丝不丛丟丏丌(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业));
            PromoActionsGUIController.<>c.<>9__23_1 = val_26;
        }
        
        val_27 = null;
        val_27 = null;
        val_29 = PromoActionsGUIController.<>c.<>9__23_2;
        if(val_29 == null)
        {
                val_29 = null;
            val_29 = new System.Func<三丅丁丗丗丝丂万且, System.Int32>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 PromoActionsGUIController.<>c::丕丅专丝丆七丏丌丁(三丅丁丗丗丝丂万且 东七上世万下丗丄丛));
            PromoActionsGUIController.<>c.<>9__23_2 = val_29;
        }
        
        val_30 = null;
        val_30 = null;
        val_32 = PromoActionsGUIController.<>c.<>9__23_3;
        if(val_32 == null)
        {
                val_32 = null;
            val_32 = new System.Func<System.Linq.IGrouping<System.Int32, 三丅丁丗丗丝丂万且>, System.Boolean>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PromoActionsGUIController.<>c::一世丌丙世丑丆七与(System.Linq.IGrouping<int, 三丅丁丗丗丝丂万且> 不一丅丛一丈且丕丆));
            PromoActionsGUIController.<>c.<>9__23_3 = val_32;
        }
        
        val_33 = null;
        val_33 = null;
        val_35 = PromoActionsGUIController.<>c.<>9__23_4;
        if(val_35 == null)
        {
                val_35 = null;
            val_35 = new System.Func<System.Linq.IGrouping<System.Int32, 三丅丁丗丗丝丂万且>, System.Linq.IOrderedEnumerable<三丅丁丗丗丝丂万且>>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Linq.IOrderedEnumerable<三丅丁丗丗丝丂万且> PromoActionsGUIController.<>c::上与上不丂丞丏丑世(System.Linq.IGrouping<int, 三丅丁丗丗丝丂万且> 不一丅丛一丈且丕丆));
            PromoActionsGUIController.<>c.<>9__23_4 = val_35;
        }
        
        val_36 = null;
        val_36 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        var val_25 = 0;
        val_25 = val_25 + 1;
        System.Collections.Generic.IEnumerator<T> val_17 = System.Linq.Enumerable.Select<System.Linq.IGrouping<System.Int32, 三丅丁丗丗丝丂万且>, System.Linq.IOrderedEnumerable<三丅丁丗丗丝丂万且>>(source:  System.Linq.Enumerable.Where<System.Linq.IGrouping<System.Int32, 三丅丁丗丗丝丂万且>>(source:  System.Linq.Enumerable.GroupBy<三丅丁丗丗丝丂万且, System.Int32>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  System.Linq.Enumerable.Where<三丅丁丗丗丝丂万且>(source:  丏丄丑上丛不丈且万.丛丐专不世丂丝与三(), predicate:  null), predicate:  null), keySelector:  null), predicate:  null), selector:  null).GetEnumerator();
        label_48:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_41;
        }
        
        var val_27 = 0;
        val_27 = val_27 + 1;
        null.AddRange(collection:  val_17.Current);
        goto label_48;
        label_41:
        val_40 = 0;
        val_23 = 0;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_17.Dispose();
        }
        
        if( != 1)
        {
                if( == false)
        {
                return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)val_36;
        }
        
            if(290 != 290)
        {
                return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)val_36;
        }
        
            return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)val_36;
        }
        
        if( == false)
        {
                return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)val_36;
        }
        
        return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)val_36;
        label_5:
        System.Collections.Generic.List<三丅丁丗丗丝丂万且> val_24 = null;
        val_36 = val_24;
        val_24 = new System.Collections.Generic.List<三丅丁丗丗丝丂万且>();
        return (System.Collections.Generic.List<三丅丁丗丗丝丂万且>)val_36;
    }
    internal static System.Collections.Generic.List<丕丈丏丝丗下丟丅丂> 丈三一不丂丆业专七(int 业万上丆丐丞且丒七)
    {
        int val_20;
        System.Int32[] val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        System.Func<丕丈丏丝丗下丟丅丂, GadgetCategory> val_27;
        var val_28;
        System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, System.Boolean> val_30;
        var val_31;
        System.Func<System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂>, 丕丈丏丝丗下丟丅丂> val_33;
        var val_34;
        val_20 = 业万上丆丐丞且丒七;
        PromoActionsGUIController.丛东丟丅丙丗世丗不 val_1 = new PromoActionsGUIController.丛东丟丅丙丗世丗不();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        val_21 = val_1;
        .业万上丆丐丞且丒七 = val_20;
        if((val_20 & 2147483648) != 0)
        {
            goto label_7;
        }
        
        label_34:
        if(val_1 == null)
        {
                val_20 = .业万上丆丐丞且丒七;
        }
        
        val_22 = null;
        val_22 = null;
        val_21 = ExpController.LevelsForTiers;
        if(val_20 >= ExpController.LevelsForTiers.Length)
        {
            goto label_7;
        }
        
        new PromoActionsGUIController.丆丐丁且丝业丟世丒() = new System.Object();
        val_23 = null;
        val_23 = null;
        val_24 = null;
        val_24 = null;
        decimal val_3 = System.Convert.ToDecimal(value:  BalanceController.丒丏丐丁业且七丄万);
        decimal val_4 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_20, mid = System.Decimal.Powers10.__il2cppRuntimeField_20}, d2:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
        .业三丘专业丞丆万丏 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        System.Func<丕丈丏丝丗下丟丅丂, System.Boolean> val_8 = new System.Func<丕丈丏丝丗下丟丅丂, System.Boolean>(object:  val_1, method:  System.Boolean PromoActionsGUIController.丛东丟丅丙丗世丗不::丑丝万不七丘丒下业(丕丈丏丝丗下丟丅丂 丑丝丆一三业丄且丈));
        val_25 = null;
        val_25 = null;
        val_27 = PromoActionsGUIController.<>c.<>9__24_1;
        if(val_27 == null)
        {
                val_27 = null;
            val_27 = new System.Func<丕丈丏丝丗下丟丅丂, GadgetCategory>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  GadgetCategory PromoActionsGUIController.<>c::丅世丈下丟东丞七万(丕丈丏丝丗下丟丅丂 丑丝丆一三业丄且丈));
            PromoActionsGUIController.<>c.<>9__24_1 = val_27;
        }
        
        val_28 = null;
        val_28 = null;
        val_30 = PromoActionsGUIController.<>c.<>9__24_2;
        if(val_30 == null)
        {
                val_30 = null;
            val_30 = new System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, System.Boolean>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PromoActionsGUIController.<>c::丟且专丂丝上下下丌(System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂> 不一丅丛一丈且丕丆));
            PromoActionsGUIController.<>c.<>9__24_2 = val_30;
        }
        
        val_21 = null;
        val_21 = new System.Func<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂>>(object:  new PromoActionsGUIController.丆丐丁且丝业丟世丒(), method:  System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂> PromoActionsGUIController.丆丐丁且丝业丟世丒::丝丐不东丅丁万丘业(System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂> 不一丅丛一丈且丕丆));
        val_31 = null;
        val_31 = null;
        val_33 = PromoActionsGUIController.<>c.<>9__24_4;
        if(val_33 == null)
        {
                val_33 = null;
            val_33 = new System.Func<System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂>, 丕丈丏丝丗下丟丅丂>(object:  PromoActionsGUIController.<>c.__il2cppRuntimeField_static_fields, method:  丕丈丏丝丗下丟丅丂 PromoActionsGUIController.<>c::与丄丙丘丄丈丅丁上(System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂> 不一丅丛一丈且丕丆));
            PromoActionsGUIController.<>c.<>9__24_4 = val_33;
        }
        
        val_34 = System.Linq.Enumerable.ToList<丕丈丏丝丗下丟丅丂>(source:  System.Linq.Enumerable.Select<System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂>, 丕丈丏丝丗下丟丅丂>(source:  System.Linq.Enumerable.Select<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>, System.Linq.IOrderedEnumerable<丕丈丏丝丗下丟丅丂>>(source:  System.Linq.Enumerable.Where<System.Linq.IGrouping<GadgetCategory, 丕丈丏丝丗下丟丅丂>>(source:  System.Linq.Enumerable.GroupBy<丕丈丏丝丗下丟丅丂, GadgetCategory>(source:  System.Linq.Enumerable.Where<丕丈丏丝丗下丟丅丂>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Values, predicate:  null), keySelector:  null), predicate:  null), selector:  null), selector:  null));
        return (System.Collections.Generic.List<丕丈丏丝丗下丟丅丂>)val_34;
        label_1:
        val_21 = 16;
        mem[16] = val_20;
        if((mem[16] & 2147483648) == 0)
        {
            goto label_34;
        }
        
        label_7:
        System.Collections.Generic.List<丕丈丏丝丗下丟丅丂> val_19 = null;
        val_34 = val_19;
        val_19 = new System.Collections.Generic.List<丕丈丏丝丗下丟丅丂>();
        return (System.Collections.Generic.List<丕丈丏丝丗下丟丅丂>)val_34;
    }
    public PromoActionsGUIController()
    {
    
    }
    private static PromoActionsGUIController()
    {
    
    }

}
