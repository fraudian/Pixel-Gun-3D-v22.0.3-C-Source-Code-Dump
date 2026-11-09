using UnityEngine;
public class LeagueItemsView : MonoBehaviour
{
    // Fields
    private UIGrid 世一三业丈下丙且丟;
    private UILabel _headerText;
    private LeagueItemStot[] 丑丕万丙东丘丄下下;
    
    // Methods
    private void Awake()
    {
        this.世一三业丈下丙且丟 = this.GetComponent<UIGrid>();
        this.丑丕万丙东丘丄下下 = this.GetComponentsInChildren<LeagueItemStot>(includeInactive:  true);
    }
    public void Repaint(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        RatingLeague val_8;
        UnityEngine.Texture val_35;
        var val_36;
        var val_37;
        var val_38;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem> val_40;
        var val_41;
        .丙丑七万丆万丆且丌 = 丙丑七万丆万丆且丌;
        val_35 = 1152921505290498048;
        val_36 = 七丌丞万七万丁丐丙.下丏万丘丁一丆丗不();
        if((val_36.ContainsKey(key:  (LeagueItemsView.世丞丒丅一专丌丐丏)[1152921538730792640].丙丑七万丆万丆且丌)) == false)
        {
            goto label_5;
        }
        
        List.Enumerator<T> val_6 = 七丌丞万七万丁丐丙.下丏万丘丁一丆丗不().Item[(LeagueItemsView.世丞丒丅一专丌丐丏)[1152921538730792640].丙丑七万丆万丆且丌].GetEnumerator();
        val_37 = 0;
        goto label_10;
        label_18:
        string val_9 = val_8.丐丏七丌丕丗业且上();
        UnityEngine.Texture val_10 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_9, 七丆丒与丗丌丄且丂:  6, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        val_35 = val_10;
        System.Collections.Generic.List<丒丌上丈专丟丘丕丅> val_11 = val_10.丒丏东东丌专东世东(丞一丁业丄一一业且:  val_9);
        this.丑丕万丙东丘丄下下[0].Set(与万丆丛丒万丝丙丑:  val_35, 世丈丟丈万上丈丟丟:  val_11.Contains(item:  0), 东丟丑万丐丏三七万:  val_11.Contains(item:  2));
        val_37 = 1;
        label_10:
        if(((-235840928) & 1) != 0)
        {
            goto label_18;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_29;
        label_5:
        val_37 = 0;
        label_29:
        if((((val_3 + 295) & 2) != 0) && ((val_3 + 216) == 0))
        {
                val_36 = null;
        }
        
        val_38 = null;
        val_38 = null;
        val_40 = LeagueItemsView.<>c.<>9__4_1;
        if(val_40 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem> val_18 = null;
            val_40 = val_18;
            val_18 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem>(object:  LeagueItemsView.<>c.__il2cppRuntimeField_static_fields, method:  SkinItem LeagueItemsView.<>c::丝丆丙东七一丏丟上(System.Collections.Generic.KeyValuePair<string, SkinItem> 丈丏万丄丒业丅丒一));
            LeagueItemsView.<>c.<>9__4_1 = val_40;
        }
        
        List.Enumerator<T> val_21 = System.Linq.Enumerable.ToList<SkinItem>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, SkinItem>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, SkinItem>>(source:  SkinsController.丄丞丁丈与业上丞丟.丛万丘丐丛与丏丗且, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, SkinItem>, System.Boolean>(object:  new LeagueItemsView.世丞丒丅一专丌丐丏(), method:  System.Boolean LeagueItemsView.世丞丒丅一专丌丐丏::且丏丝且东丅丁与丟(System.Collections.Generic.KeyValuePair<string, SkinItem> 丈丏万丄丒业丅丒一))), selector:  val_18)).GetEnumerator();
        goto label_39;
        label_50:
        RatingLeague val_36 = (LeagueItemsView.世丞丒丅一专丌丐丏)[1152921538730792640].丙丑七万丆万丆且丌;
        val_36 = val_36 + 1;
        val_8 = val_36;
        val_35 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "LeagueSkinsProfileImages/league{0}_skin_profile", arg0:  val_8));
        this.丑丕万丙东丘丄下下[0].Set(与万丆丛丒万丝丙丑:  val_35, 世丈丟丈万上丈丟丟:  (RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏() >= (LeagueItemsView.世丞丒丅一专丌丐丏)[1152921538730792640].丙丑七万丆万丆且丌) ? 1 : 0, 东丟丑万丐丏三七万:  SkinsController.七丞丌丁丂丌丏丟丘(专丑丐丅世丒不七丈:  val_8.丐丏七丌丕丗业且上().name, 丘七丟且丒七万丁下: out  false));
        val_37 = 1;
        label_39:
        if(((-235840960) & 1) != 0)
        {
            goto label_50;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_41 = val_37;
        goto label_65;
        label_70:
        this.丑丕万丙东丘丄下下[1].Hide();
        val_41 = 2;
        label_65:
        if(val_41 < this.丑丕万丙东丘丄下下.Length)
        {
            goto label_70;
        }
        
        this._headerText.gameObject.SetActive(value:  (val_37 > 0) ? 1 : 0);
        if(this.世一三业丈下丙且丟 != null)
        {
                return;
        }
    
    }
    private System.Collections.Generic.List<七丌丞万七万丁丐丙.丒丌上丈专丟丘丕丅> 丒丏东东丌专东世东(string 丞一丁业丄一一业且)
    {
        .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
        .万丏丏丞一丈上不丑 = new System.Collections.Generic.List<丒丌上丈专丟丘丕丅>();
        .丑七不与丛丆一丂丞 = 七丌丞万七万丁丐丙.不丏万丈专东丑丅丞();
        丞东丑专丛丆丄丝世.丏丁下且七下上丑丝<丒丌上丈专丟丘丕丅>(七丐丅专且专七三丆:  new System.Action<丒丌上丈专丟丘丕丅>(object:  new LeagueItemsView.丞丂万丅不丒丘丟丗(), method:  System.Void LeagueItemsView.丞丂万丅不丒丘丟丗::三不七丙七不丙一与(七丌丞万七万丁丐丙.丒丌上丈专丟丘丕丅 下下丏一丙不丘丌丞)));
        return (System.Collections.Generic.List<丒丌上丈专丟丘丕丅>)(LeagueItemsView.丞丂万丅不丒丘丟丗)[1152921538731207744].万丏丏丞一丈上不丑;
    }
    public LeagueItemsView()
    {
    
    }

}
