using UnityEngine;
public class MatchHistoryPlayerContextMenu : ContextMenuBase
{
    // Fields
    private UISprite _frame;
    private int _itemHeight;
    private int _itemSpace;
    private UITable _table;
    private UnityEngine.Transform 专丘专丏世丝丞丆七;
    public string Target;
    public PGCompany.MatchHistoryPlayerView TargetView;
    public UnityEngine.Transform pointerLeft;
    public UnityEngine.Transform pointerRight;
    
    // Methods
    public override void Show(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Vector3 丁业下丘丅丒东丄丛)
    {
        var val_7;
        System.Func<ContextMenuItemBase, System.Boolean> val_9;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.pointerLeft, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.pointerRight, 丏业丟一东丂东丘丛:  false);
        this.专丘专丏世丝丞丆七 = 丞下万上三丘上与专;
        this.丈丑丟下丛丙丌丙专(丞下万上三丘上与专:  丞下万上三丘上与专.gameObject);
        this.Show(丞下万上三丘上与专:  丞下万上三丘上与专, 丁业下丘丅丒东丄丛:  new UnityEngine.Vector3() {x = 丁业下丘丅丒东丄丛.x, y = 丁业下丘丅丒东丄丛.y, z = 丁业下丘丅丒东丄丛.z});
        val_7 = null;
        val_7 = null;
        val_9 = MatchHistoryPlayerContextMenu.<>c.<>9__9_0;
        if(val_9 == null)
        {
                System.Func<ContextMenuItemBase, System.Boolean> val_2 = null;
            val_9 = val_2;
            val_2 = new System.Func<ContextMenuItemBase, System.Boolean>(object:  MatchHistoryPlayerContextMenu.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryPlayerContextMenu.<>c::下丛丒东丟上丟且万(ContextMenuItemBase 三丟东丕丄丄下下丑));
            MatchHistoryPlayerContextMenu.<>c.<>9__9_0 = val_9;
        }
        
        this._frame.height = this._itemSpace + ((this._itemSpace + this._itemHeight) * (System.Linq.Enumerable.Count<ContextMenuItemBase>(source:  this.pointerLeft, predicate:  val_2)));
        if(this.TargetView == 0)
        {
                return;
        }
        
        this.TargetView.ContextMenu = this;
    }
    public override void Close()
    {
        this.Close();
        if(this.TargetView == 0)
        {
                return;
        }
        
        this = this.TargetView;
        this.TargetView.ContextMenu = 0;
    }
    private void 丈丑丟下丛丙丌丙专(UnityEngine.GameObject 丞下万上三丘上与专)
    {
        PGCompany.MatchHistoryPlayerView val_1 = 丞下万上三丘上与专.GetComponent<PGCompany.MatchHistoryPlayerView>();
        if(val_1 == 0)
        {
                return;
        }
        
        this.TargetView = val_1;
        this.Target = val_1.丒上上丑丏丕丒丘与.业上丙丞丐丄丆丅七();
    }
    public void UpdateRoleChangingItems()
    {
        var val_3;
        var val_12;
        var val_13;
        var val_14;
        System.Func<ContextMenuItemBase, System.Boolean> val_16;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_12 = 1152921505278517248;
        label_12:
        if((464011712 & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_3.丐丏七丌丕丗业且上() == null)
        {
            goto label_12;
        }
        
        goto label_12;
        label_2:
        val_13 = public System.Void List.Enumerator<ContextMenuItemBase>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_14 = null;
        val_14 = null;
        val_16 = MatchHistoryPlayerContextMenu.<>c.<>9__12_0;
        if(val_16 == null)
        {
                System.Func<ContextMenuItemBase, System.Boolean> val_8 = null;
            val_16 = val_8;
            val_8 = new System.Func<ContextMenuItemBase, System.Boolean>(object:  MatchHistoryPlayerContextMenu.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryPlayerContextMenu.<>c::丘丙且且东丝丞三丄(ContextMenuItemBase 三丟东丕丄丄下下丑));
            MatchHistoryPlayerContextMenu.<>c.<>9__12_0 = val_16;
        }
        
        this._frame.height = this._itemSpace + ((this._itemSpace + this._itemHeight) * (System.Linq.Enumerable.Count<ContextMenuItemBase>(source:  1152921539421701344, predicate:  val_8)));
    }
    public void Refresh()
    {
        var val_8;
        var val_9;
        var val_10;
        System.Func<ContextMenuItemBase, System.Boolean> val_12;
        this.丈丑丟下丛丙丌丙专(丞下万上三丘上与专:  this.专丘专丏世丝丞丆七.gameObject);
        List.Enumerator<T> val_2 = this.专丘专丏世丝丞丆七.GetEnumerator();
        val_8 = 1152921505284374528;
        label_7:
        if((464165720 & 1) == 0)
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
        val_9 = public System.Void List.Enumerator<ContextMenuItemBase>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_10 = null;
        val_10 = null;
        val_12 = MatchHistoryPlayerContextMenu.<>c.<>9__13_0;
        if(val_12 == null)
        {
                System.Func<ContextMenuItemBase, System.Boolean> val_4 = null;
            val_12 = val_4;
            val_4 = new System.Func<ContextMenuItemBase, System.Boolean>(object:  MatchHistoryPlayerContextMenu.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryPlayerContextMenu.<>c::丐且丑丕丆丛丈丂下(ContextMenuItemBase 三丟东丕丄丄下下丑));
            MatchHistoryPlayerContextMenu.<>c.<>9__13_0 = val_12;
        }
        
        this._frame.height = this._itemSpace + ((this._itemSpace + this._itemHeight) * (System.Linq.Enumerable.Count<ContextMenuItemBase>(source:  1152921539421700320, predicate:  val_4)));
    }
    public MatchHistoryPlayerContextMenu()
    {
    
    }

}
