using UnityEngine;
public class ClanMemberContextMenu : ContextMenuBase
{
    // Fields
    private UISprite _frame;
    private int _itemHeight;
    private int _itemSpace;
    private UITable _table;
    private UILabel _onlineInfoLabel;
    private UnityEngine.Transform 专丘专丏世丝丞丆七;
    public 七丈丗不丞丈丝丙七 Target;
    public ClansLobbyMemberView TargetView;
    
    // Methods
    public override void Show(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Vector3 丁业下丘丅丒东丄丛)
    {
        this.专丘专丏世丝丞丆七 = 丞下万上三丘上与专;
        this.丈丑丟下丛丙丌丙专(丞下万上三丘上与专:  丞下万上三丘上与专.gameObject);
        this.Show(丞下万上三丘上与专:  丞下万上三丘上与专, 丁业下丘丅丒东丄丛:  new UnityEngine.Vector3() {x = 丁业下丘丅丒东丄丛.x, y = 丁业下丘丅丒东丄丛.y, z = 丁业下丘丅丒东丄丛.z});
        this.万丆丘丒丅丟丞丂丛();
        this.丙世丐上丑东丁丞丈();
        if(this.TargetView == 0)
        {
                return;
        }
        
        this.TargetView.SetSelectionSprite(丗一不上东业专不业:  true);
        this.TargetView.ContextMenu = this;
    }
    public override void Close()
    {
        this.Close();
        if(this.TargetView == 0)
        {
                return;
        }
        
        this.TargetView.SetSelectionSprite(丗一不上东业专不业:  false);
        this = this.TargetView;
        this.TargetView.ContextMenu = 0;
    }
    private void 丈丑丟下丛丙丌丙专(UnityEngine.GameObject 丞下万上三丘上与专)
    {
        ClansLobbyMemberView val_1 = 丞下万上三丘上与专.GetComponent<ClansLobbyMemberView>();
        if(val_1 == 0)
        {
                return;
        }
        
        this.TargetView = val_1;
        this.Target = val_1.GetClanMember();
    }
    public void UpdateRoleChangingItems()
    {
        List.Enumerator<T> val_1 = GetEnumerator();
        label_12:
        if((455134040 & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() == null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丙世丐上丑东丁丞丈();
    }
    public void Refresh()
    {
        this.丈丑丟下丛丙丌丙专(丞下万上三丘上与专:  this.专丘专丏世丝丞丆七.gameObject);
        List.Enumerator<T> val_2 = this.专丘专丏世丝丞丆七.GetEnumerator();
        label_7:
        if((455262440 & 1) == 0)
        {
            goto label_3;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  true);
        if(val_3 != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丙世丐上丑东丁丞丈();
    }
    private void 丙世丐上丑东丁丞丈()
    {
        var val_9;
        System.Func<ContextMenuItemBase, System.Boolean> val_11;
        UnityEngine.GameObject val_1 = this._onlineInfoLabel.cachedGameObject;
        val_9 = null;
        val_9 = null;
        val_11 = ClanMemberContextMenu.<>c.<>9__13_0;
        if(val_11 == null)
        {
                System.Func<ContextMenuItemBase, System.Boolean> val_4 = null;
            val_11 = val_4;
            val_4 = new System.Func<ContextMenuItemBase, System.Boolean>(object:  ClanMemberContextMenu.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanMemberContextMenu.<>c::丟万丞与丏七丒一丌(ContextMenuItemBase 三丟东丕丄丄下下丑));
            ClanMemberContextMenu.<>c.<>9__13_0 = val_11;
        }
        
        this._frame.height = this._itemSpace + ((this._itemSpace + this._itemHeight) * ((System.Linq.Enumerable.Count<ContextMenuItemBase>(source:  val_1, predicate:  val_4)) + val_1.activeInHierarchy));
    }
    private void 万丆丘丒丅丟丞丂丛()
    {
        string val_28;
        var val_31;
        if((System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  this.Target.业丐丐三丕一丗丛丁())) != true)
        {
                if((PGCompany.Clans.世丝丒东且丙一丞一.丂丄丌与万业丝三世(丛七丑丈上丄丙丐且:  this.Target.业丐丐三丕一丗丛丁())) == false)
        {
            goto label_6;
        }
        
        }
        
        label_27:
        label_36:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._onlineInfoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10183"));
        return;
        label_6:
        System.Nullable<System.Int32> val_8 = PGCompany.Clans.世丝丒东且丙一丞一.丗不丘且世丞专丏丆(丛七丑丈上丄丙丐且:  this.Target.业丐丐三丕一丗丛丁());
        if((455625304 & 1) != 0)
        {
                long val_10 = PixelTime.丙丅丅业丟丁世丁丗() - 1152921539422210648;
        }
        
        if((455625288 & 1) == 0)
        {
            goto label_27;
        }
        
        System.TimeSpan val_11 = System.TimeSpan.FromSeconds(value:  1.15292150460685E+18);
        int val_13 = val_11._ticks.Days;
        if(val_11._ticks.Days >= 29)
        {
            goto label_20;
        }
        
        if(val_13 < 1)
        {
            goto label_21;
        }
        
        val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10482");
        int val_15 = val_11._ticks.Days;
        goto label_24;
        label_20:
        var val_28 = 0;
        val_28 = val_28 + val_13;
        int val_17 = (val_28 >> 4) + (val_28 >> 31);
        val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10481");
        val_31 = null;
        goto label_30;
        label_21:
        if(val_11._ticks.Hours < 1)
        {
            goto label_31;
        }
        
        val_28 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10484");
        label_24:
        val_31 = null;
        label_30:
        label_41:
        string val_24 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10182"), arg0:  System.String.Format(format:  val_28, arg0:  val_11._ticks.Hours));
        goto label_36;
        label_31:
        int val_26 = System.Math.Max(val1:  1, val2:  val_11._ticks.Minutes);
        string val_27 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10483");
        goto label_41;
    }
    private void Update()
    {
        this.万丆丘丒丅丟丞丂丛();
    }
    public ClanMemberContextMenu()
    {
    
    }

}
