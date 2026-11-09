using UnityEngine;
public class UserCharacterMainWindow : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<CharacterSelectionView> _characterViews;
    private SelectableButtonController _viewsGroupController;
    private System.IDisposable 丐丆七且丞丏下三丙;
    internal System.Action 三丁丕丈丅丏丅丕丌;
    
    // Methods
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void UserCharacterMainWindow::U_Hide()), 与且专丈不万东一万:  "User Characters Main Window");
        万与下丝东下丕万丈.丈丈东丁丆丆与丏世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::丝一丅丆三东丂丞七()));
        丕丑万丒世万上丆丅.丈丈东丁丆丆与丏世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.不上且上丝丏丌丌丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::丝一丅丆三东丂丞七()));
        Progress.七上上丟丗丏一不与.丂丐上丝丞丙万丟且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::专三业丗丌丈丛一丂()));
        this.下丗上丂丝丁东丄东();
        this.三不专七万不丙丝丁();
        this.丝一丅丆三东丂丞七();
        this.丑丁不万丈丟万且业();
        this.丈丄丟丑丗丄丁丛丄();
        Rilisoft.七不丑丑下与丛丝丝.丏丗丂丂丗下七丙丛();
    }
    private void 专三业丗丌丈丛一丂()
    {
        this.U_Hide();
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        万与下丝东下丕万丈.丘一丞丈丆下且三且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::丝一丅丆三东丂丞七()));
        丕丑万丒世万上丆丅.丘一丞丈丆下且三且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::丝一丅丆三东丂丞七()));
        丅丛丟上丁丆上丛专.万且专下上丏丅丗丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::丝一丅丆三东丂丞七()));
        Progress.七上上丟丗丏一不与.且丘丝丈业且丗丑丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UserCharacterMainWindow::专三业丗丌丈丛一丂()));
    }
    private void 三不专七万不丙丝丁()
    {
        var val_17;
        var val_18;
        var val_19;
        System.Collections.Generic.List<CharacterSelectionView> val_20;
        val_17 = this;
        if(this._viewsGroupController.allButtons.Count != 0)
        {
            goto label_3;
        }
        
        val_18 = 1152921539508149072;
        val_19 = 0;
        goto label_4;
        label_10:
        SelectableButton val_3 = this._characterViews.Item[0].GetComponent<SelectableButton>();
        val_19 = 1;
        val_3.selectableButtonController = this._viewsGroupController;
        label_4:
        val_20 = this._characterViews;
        if(val_19 < val_20.Count)
        {
            goto label_10;
        }
        
        label_3:
        if(this._characterViews.Count < 1)
        {
                return;
        }
        
        SelectableButton val_7 = this._characterViews.Item[0].GetComponent<SelectableButton>();
        val_17 = ???;
        val_20 = ???;
        val_18 = ???;
        goto typeof(SelectableButtonController).__il2cppRuntimeField_168;
    }
    private void 下丗上丂丝丁东丄东()
    {
        goto label_1;
        label_14:
        this._characterViews.Item[W21].丘丒丄下丝丑丆丄一(丙业与丙丗丝不丈东:  1);
        if(UserCharactersLobbyPoints.丆丕丝丒不丙且丐丗 != 0)
        {
                this._characterViews.Item[W21].不丁东七丁丘丙一丗(丙业与丙丗丝不丈东:  UserCharactersLobbyPoints.丆丕丝丒不丙且丐丗.七丘丅丆三不上七丆(丑丅世丐丒丏丐三丅:  1));
            this._characterViews.Item[W21].丝丕丗一世丁丈丙丌(丙业与丙丗丝不丈东:  UserCharactersLobbyPoints.丆丕丝丒不丙且丐丗.上上丝不业丕丌丏丈(丑丅世丐丒丏丐三丅:  1));
        }
        
        1 = 2;
        label_1:
        if((1 - 1) < this._characterViews.Count)
        {
            goto label_14;
        }
    
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_31;
        var val_32;
        System.Func<丙与不与七丌丟上东, System.String> val_34;
        var val_35;
        var val_36;
        int val_37;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_38;
        var val_39;
        System.Collections.Generic.IEnumerable<TSource> val_40;
        var val_41;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_43;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object> val_45;
        object val_16 = 0;
        System.Collections.Generic.List<System.String> val_1 = null;
        val_31 = val_1;
        val_1 = new System.Collections.Generic.List<System.String>();
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一() != null)
        {
                val_32 = null;
            val_32 = null;
            val_34 = UserCharacterMainWindow.<>c.<>9__9_0;
            if(val_34 == null)
        {
                System.Func<丙与不与七丌丟上东, System.String> val_5 = null;
            val_34 = val_5;
            val_5 = new System.Func<丙与不与七丌丟上东, System.String>(object:  UserCharacterMainWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.String UserCharacterMainWindow.<>c::与上不丒丞丑丏丈丞(丙与不与七丌丟上东 三丟东丕丄丄下下丑));
            UserCharacterMainWindow.<>c.<>9__9_0 = val_34;
        }
        
            val_31 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<丙与不与七丌丟上东, System.String>(source:  丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏(), selector:  val_5));
        }
        
        int val_8 = val_31.Count;
        val_35 = 0;
        val_36 = 0;
        goto label_40;
        label_67:
        CharacterSelectionView val_9 = this._characterViews.Item[0];
        if(val_36 < val_8)
        {
                val_37 = val_31.Item[0];
        }
        else
        {
                val_37 = System.String.alignConst;
        }
        
        if((System.String.op_Equality(a:  val_37, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
        {
            goto label_18;
        }
        
        val_36 = 1;
        if(val_36 >= val_8)
        {
            goto label_19;
        }
        
        val_37 = val_31.Item[1];
        label_18:
        if(val_35 == 0)
        {
            goto label_21;
        }
        
        label_33:
        bool val_14 = System.String.op_Equality(a:  val_37, b:  System.String.alignConst);
        if(val_14 == false)
        {
            goto label_22;
        }
        
        val_14.下丌丒丒丂七一丑下(一丕世丑万不丟丒丆:  1, 丁世丛业丟下丕三丟:  val_9);
        if(val_9 != null)
        {
            goto label_64;
        }
        
        goto label_65;
        label_22:
        bool val_17 = 万与下丝东下丕万丈.丁丑丛万下丟丞丕丁().TryGetValue(key:  val_37, value: out  val_16);
        if(val_9 == null)
        {
            goto label_28;
        }
        
        if(val_16 == 0)
        {
            goto label_29;
        }
        
        label_41:
        val_9.丏丏不丕丝丑万丆丌();
        val_38 = 0;
        goto label_32;
        label_19:
        if(val_35 != 0)
        {
            goto label_33;
        }
        
        label_21:
        if(val_9 != null)
        {
                val_9.丏丏不丕丝丑万丆丌();
        }
        else
        {
                val_9.丏丏不丕丝丑万丆丌();
        }
        
        val_9.丟业三丟丌丘万世不();
        if(val_9 != null)
        {
            goto label_64;
        }
        
        label_65:
        label_64:
        SelectableButton val_18 = val_9.丄丐与万丄丑丏丆东();
        if(val_18.selected != false)
        {
                val_9.丐丌与丘丂丆丆丑丕();
        }
        
        val_35 = 1;
        goto label_40;
        label_28:
        if(val_16 != 0)
        {
            goto label_41;
        }
        
        label_29:
        val_9.丞不三世业丌万丕丁();
        goto label_42;
        label_32:
        if((丕丑万丒世万上丆丅.丁丑丛万下丟丞丕丁().TryGetValue(key:  val_37, value: out  0)) != false)
        {
                val_39 = 0;
            val_40 = System.Linq.Enumerable.Union<System.Collections.Generic.KeyValuePair<System.String, System.Object>>(first:  null, second:  null);
            val_41 = null;
            val_41 = null;
            val_43 = UserCharacterMainWindow.<>c.<>9__9_1;
            if(val_43 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_25 = null;
            val_43 = val_25;
            val_25 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  UserCharacterMainWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.String UserCharacterMainWindow.<>c::世丈世丐专丐三丌与(System.Collections.Generic.KeyValuePair<string, object> 三丟东丕丄丄下下丑));
            val_41 = null;
            UserCharacterMainWindow.<>c.<>9__9_1 = val_43;
        }
        
            val_41 = null;
            val_45 = UserCharacterMainWindow.<>c.<>9__9_2;
            if(val_45 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object> val_26 = null;
            val_45 = val_26;
            val_26 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.Object>(object:  UserCharacterMainWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Object UserCharacterMainWindow.<>c::丅专丛一东业丆下丄(System.Collections.Generic.KeyValuePair<string, object> 丒丒丄丁且丄丆丂丌));
            UserCharacterMainWindow.<>c.<>9__9_2 = val_45;
            val_40 = val_40;
        }
        
            val_38 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, System.Object>(source:  val_40, keySelector:  val_25, elementSelector:  val_26);
        }
        
        val_9.丞丈丂丒丕丗丅丑丆(世丟丈丏丕万丝丆万:  丅丛丟上丁丆上丛专.不七不丙丏上与三一().七七下与一丝丈丁丁(丞丅上丏丂且下丅与:  val_37), 丛丏万丙与三丕丙东:  val_38);
        label_42:
        val_36 = val_36 + 1;
        if(val_9 != null)
        {
            goto label_64;
        }
        
        goto label_65;
        label_40:
        if(val_35 < this._characterViews.Count)
        {
            goto label_67;
        }
    
    }
    private void 下丌丒丒丂七一丑下(int 一丕世丑万不丟丒丆, CharacterSelectionView 丁世丛业丟下丕三丟)
    {
        丈丞丕丘丕丗与上一 val_19;
        int val_20;
        var val_21;
        var val_22;
        if(一丕世丑万不丟丒丆 == 3)
        {
            goto label_1;
        }
        
        if(一丕世丑万不丟丒丆 != 2)
        {
            goto label_2;
        }
        
        val_19 = 丑丝丞丒丅丄万丒三.丈一且丌不丆世丏丕();
        val_20 = 丑丝丞丒丅丄万丒三.上丅丌丑丘丞业丆丄();
        val_21 = 0;
        goto label_7;
        label_1:
        val_21 = 丑丝丞丒丅丄万丒三.丘世丞丁丌三丞丆丙();
        goto label_10;
        label_2:
        val_21 = 0;
        label_10:
        val_20 = 丑丝丞丒丅丄万丒三.丅专与七丒丁丁世丑();
        val_19 = 0;
        label_7:
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一().丄且东且丕丛与丆丒() < val_20)
        {
                丁世丛业丟下丕三丟.丛丂丟万万业与与不(丙丙且丘丌且丏丞丏:  val_19, 丝世不丑不与丅丟七:  0, 丘丄丘丆丌丆丛丝丄:  val_20);
            return;
        }
        
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一().丈业丂与不专丅七丅() >= 一丕世丑万不丟丒丆)
        {
            goto label_21;
        }
        
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  34)) == false)
        {
            goto label_29;
        }
        
        val_22 = 0;
        goto label_30;
        label_21:
        丁世丛业丟下丕三丟.丑丄与万世且丛且上();
        return;
        label_29:
        Progress.东丐世上丛丌丛丛丝 val_18 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        val_22 = (val_18.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  35)) ^ 1;
        label_30:
        val_18 = ((丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏().Count >= (一丕世丑万不丟丒丆 - 1)) ? 1 : 0) & val_22;
        丁世丛业丟下丕三丟.丞下丞丝世万丕东丐(丙丙且丘丌且丏丞丏:  val_19, 丝世不丑不与丅丟七:  0, 一丅丒丞丛丏东丌丘:  val_18);
    }
    private void 丑丁不万丈丟万且业()
    {
        var val_15;
        var val_16;
        System.Func<丙与不与七丌丟上东, System.String> val_18;
        string val_19;
        var val_20;
        System.Func<System.String, System.Boolean> val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<System.String> val_1 = null;
        val_15 = val_1;
        val_1 = new System.Collections.Generic.List<System.String>();
        if(丅丛丟上丁丆上丛专.不七不丙丏上与三一() != null)
        {
                val_16 = null;
            val_16 = null;
            val_18 = UserCharacterMainWindow.<>c.<>9__11_0;
            if(val_18 == null)
        {
                System.Func<丙与不与七丌丟上东, System.String> val_5 = null;
            val_18 = val_5;
            val_5 = new System.Func<丙与不与七丌丟上东, System.String>(object:  UserCharacterMainWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.String UserCharacterMainWindow.<>c::丂丒丄丘一丕专丛丈(丙与不与七丌丟上东 三丟东丕丄丄下下丑));
            UserCharacterMainWindow.<>c.<>9__11_0 = val_18;
        }
        
            val_20 = null;
            val_20 = null;
            val_22 = UserCharacterMainWindow.<>c.<>9__11_1;
            if(val_22 == null)
        {
                System.Func<System.String, System.Boolean> val_7 = null;
            val_22 = val_7;
            val_7 = new System.Func<System.String, System.Boolean>(object:  UserCharacterMainWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean UserCharacterMainWindow.<>c::丌丏丌三丂丅丂不丝(string 三丟东丕丄丄下下丑));
            UserCharacterMainWindow.<>c.<>9__11_1 = val_22;
        }
        
            val_15 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Where<System.String>(source:  System.Linq.Enumerable.Select<丙与不与七丌丟上东, System.String>(source:  丅丛丟上丁丆上丛专.不七不丙丏上与三一().世专七与丈不丛丙丏(), selector:  val_5), predicate:  val_7));
        }
        
        val_23 = 0;
        goto label_17;
        label_27:
        val_24 = null;
        val_24 = null;
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Object>> val_11 = 万与下丝东下丕万丈.丄且丙丂丆不一万七(丄丒且丙三丆丟与丏:  val_15.Item[0], 丒丆丛上东丝三丟世:  Progress.不丗丕万上万丟与专.万丅丙丙丕丐丂不东);
        val_19 = val_15.Item[0];
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<System.String, System.Object>> val_13 = 丕丑万丒世万上丆丅.丛丐不丐丘丘万丒丂(丄丒且丙三丆丟与丏:  val_19);
        val_23 = 1;
        label_17:
        if(val_23 < val_15.Count)
        {
            goto label_27;
        }
        
        丅丛丟上丁丆上丛专.业丁丂七上丗丟丙丟(丈丌丐丟一上世丝丞:  true);
    }
    private void 丈丄丟丑丗丄丁丛丄()
    {
        var val_5;
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  35)) != false)
        {
                val_5 = 3;
        }
        else
        {
                if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  34)) == false)
        {
                return;
        }
        
            val_5 = 2;
        }
        
        丑丝丞丒丅丄万丒三.丂一丁一丁丏三与丝(丌丒丝东丌下丕丁丅:  2);
    }
    public void U_Hide()
    {
        if(this.三丁丕丈丅丏丅丕丌 != null)
        {
                this.三丁丕丈丅丏丅丕丌.Invoke();
        }
        
        this.ChooseSelectedCharacter();
    }
    public void U_ChooseSelectedCharacter()
    {
    
    }
    private void 丁世三七丑业专专丛()
    {
        if(this._viewsGroupController == null)
        {
            
        }
    
    }
    public void ChooseSelectedCharacter()
    {
        if(this._viewsGroupController.selectedButton != 0)
        {
                0 = this._viewsGroupController.selectedButton.GetComponent<CharacterSelectionView>();
        }
        
        if(0 == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  0.业上丙丞丐丄丆丅七())) != false)
        {
                return;
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.一丛东丆丟丘世东三(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丄丞丈东三丟丂丐三:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 三丟专专丞丅七东业:  0.业上丙丞丐丄丆丅七());
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  0.业上丙丞丐丄丆丅七());
        业丞丝东丅丞丐丌专.丑七不且上丗丁一世().丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  0.丛三七丙专丙三丌万());
        丅丛丟上丁丆上丛专.丞丛丏丈丟丙七万丂(丙业与丙丗丝不丈东:  0.业上丙丞丐丄丆丅七());
        丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
    }
    public UserCharacterMainWindow()
    {
    
    }

}
