using UnityEngine;
public class LeaguesGUIController : MonoBehaviour
{
    // Fields
    private static readonly System.Collections.Generic.Dictionary<RatingSystem.RatingLeague, string> 丘丏不丄专丘且丂丛;
    private UICenterOnChild _centerOnChild;
    private System.Collections.Generic.List<ProfileCup> _cups;
    private LeagueItemsView _itemsView;
    private UILabel _lblLeagueName;
    private UILabel _lblLeagueNameOutline;
    private UILabel _progressTextLabel;
    private ProfileCup 丑丗一丏丆七丅丕丑;
    
    // Methods
    internal static string 丈丒丞丁下且与丛且(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        var val_4;
        int val_5;
        string val_1 = 0;
        val_4 = null;
        val_4 = null;
        bool val_2 = LeaguesGUIController.丘丏不丄专丘且丂丛.TryGetValue(key:  丙丑七万丆万丆且丌, value: out  val_1);
        val_5 = val_1;
        if(val_5 != 0)
        {
                return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5 = System.String.alignConst);
        }
        
        return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5);
    }
    internal static string 丒世丛专下丌丆丑丂(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        var val_4;
        int val_5;
        string val_1 = 0;
        val_4 = null;
        val_4 = null;
        bool val_2 = LeaguesGUIController.丘丏不丄专丘且丂丛.TryGetValue(key:  丙丑七万丆万丆且丌, value: out  val_1);
        val_5 = val_1;
        if(val_5 != 0)
        {
                return (string)丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_5 = System.String.alignConst);
        }
        
        return (string)丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_5);
    }
    internal static string 丅且万专丁丘不三丑(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        UnityEngine.Color val_1 = LeaguesGUIController.与丅七丒丗丞丙且丑(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌);
        UnityEngine.Color32 val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        string[] val_3 = new string[5];
        val_3[0] = "[";
        val_3[1] = 丞东丑专丛丆丄丝世.世东三丏业万丟丆一(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color32() {r = val_2.r & 4294967295, g = val_2.r & 4294967295, b = val_2.r & 4294967295, a = val_2.r & 4294967295});
        val_3[2] = "]";
        val_3[3] = LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌);
        val_3[4] = "[-]";
        return +val_3;
    }
    internal static UnityEngine.Color 与丅七丒丗丞丙且丑(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        UnityEngine.Color val_3 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "CompetitionLeague/League_{0}_TextColor_01", arg0:  丙丑七万丆万丆且丌 + 1));
        return new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
    }
    private void OnEnable()
    {
        this._cups = System.Linq.Enumerable.ToList<ProfileCup>(source:  this.GetComponentsInChildren<ProfileCup>(includeInactive:  true));
        this._itemsView = this.GetComponentInChildren<LeagueItemsView>(includeInactive:  true);
        this.丁下丏丙一丗下丈七();
    }
    private void 丁下丏丙一丗下丈七()
    {
        var val_5;
        System.Func<ProfileCup, System.Boolean> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = LeaguesGUIController.<>c.<>9__13_0;
        if(val_7 == null)
        {
                System.Func<ProfileCup, System.Boolean> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<ProfileCup, System.Boolean>(object:  LeaguesGUIController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LeaguesGUIController.<>c::丕丑丈丁下世东丘且(ProfileCup 丁丂专业丁丅丅丈丙));
            LeaguesGUIController.<>c.<>9__13_0 = val_7;
        }
        
        this.丑丗一丏丆七丅丕丑 = System.Linq.Enumerable.FirstOrDefault<ProfileCup>(source:  this._cups, predicate:  val_1);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丝丝丗丙丌丈丄世丐());
    }
    private System.Collections.IEnumerator 丝丝丗丙丌丈丄世丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LeaguesGUIController.丗丆丙丕丞世丕世丘();
    }
    public void CupCentered(ProfileCup 丆上上三不丅丄丛丞)
    {
        this.丑丗一丏丆七丅丕丑 = 丆上上三不丅丄丛丞;
        this.七世丑丞丙丐丞上丆(丙丑七万丆万丆且丌:  丆上上三不丅丄丛丞.League);
        this._itemsView.Repaint(丙丑七万丆万丆且丌:  丆上上三不丅丄丛丞.League);
    }
    private void 七世丑丞丙丐丞上丆(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        var val_14;
        UILabel val_15;
        string val_16;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._lblLeagueName, 丕丗丘丑丛与丑业丒:  LeaguesGUIController.丈丒丞丁下且与丛且(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌));
        UnityEngine.Color val_2 = LeaguesGUIController.与丅七丒丗丞丙且丑(丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._lblLeagueName, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        this._progressTextLabel.gameObject.SetActive(value:  true);
        val_14 = RatingSystem.与一丅丝不丈业与丙();
        if(val_14.与丌丛七七与东下丏() <= 丙丑七万丆万丆且丌)
        {
            goto label_10;
        }
        
        val_15 = this._progressTextLabel;
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5324");
        goto label_14;
        label_10:
        val_14 = RatingSystem.与一丅丝不丈业与丙();
        if(val_14.与丌丛七七与东下丏() >= 丙丑七万丆万丆且丌)
        {
            goto label_18;
        }
        
        val_15 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5323");
        val_16 = val_15;
        label_14:
        this._progressTextLabel.text = val_16;
        return;
        label_18:
        this._progressTextLabel.text = System.String.Format(format:  "{0} {1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6286"), arg1:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
    }
    public LeaguesGUIController()
    {
    
    }
    private static LeaguesGUIController()
    {
        System.Collections.Generic.Dictionary<RatingLeague, System.String> val_2 = new System.Collections.Generic.Dictionary<RatingLeague, System.String>(capacity:  6, comparer:  RatingSystem.万丐丑且一不丂丗七.丑七不且上丗丁一世());
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  "Key_11674");
        }
        else
        {
                val_2.Add(key:  0, value:  "Key_11674");
        }
        
        val_2.Add(key:  1, value:  "Key_11675");
        if(val_2 != null)
        {
                val_2.Add(key:  2, value:  "Key_11676");
        }
        else
        {
                val_2.Add(key:  2, value:  "Key_11676");
        }
        
        val_2.Add(key:  3, value:  "Key_11677");
        if(val_2 != null)
        {
                val_2.Add(key:  4, value:  "Key_11678");
        }
        else
        {
                val_2.Add(key:  4, value:  "Key_11678");
        }
        
        val_2.Add(key:  5, value:  "Key_11679");
        if(val_2 != null)
        {
                val_2.Add(key:  6, value:  "Key_11680");
        }
        else
        {
                val_2.Add(key:  6, value:  "Key_11680");
        }
        
        val_2.Add(key:  7, value:  "Key_11681");
        LeaguesGUIController.丘丏不丄专丘且丂丛 = val_2;
    }

}
