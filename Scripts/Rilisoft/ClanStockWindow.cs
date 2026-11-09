using UnityEngine;

namespace Rilisoft
{
    public class ClanStockWindow : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
    {
        // Fields
        private System.Collections.Generic.List<ClanItem> _allItems;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private System.Collections.Generic.List<ClanItem> _existsItems;
        private System.Collections.Generic.List<ClanItem> _notExistsItems;
        private bool 丝与丆丞东丘丈东丘;
        private static Rilisoft.ClanStockWindow <不丁丄七丛不丆丁丕>k__BackingField;
        private System.Action 丄丑上丕丂丈丘丙七;
        private UITable _table;
        private UIScrollView _scroll;
        private UIWidget _headerFirst;
        private UIWidget _headerSecond;
        private UIGrid _gridFirst;
        private UIGrid _gridSecond;
        private System.Collections.Generic.List<Rilisoft.ClanStockWindow.RarityColor> _rarityColors;
        private UIButton btnFort;
        
        // Properties
        internal static Rilisoft.ClanStockWindow 丆丕丝丒不丙且丐丗 { get; set; }
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        internal static Rilisoft.ClanStockWindow 丑七不且上丗丁一世()
        {
            return (Rilisoft.ClanStockWindow)Rilisoft.ClanStockWindow.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.ClanStockWindow 丙业与丙丗丝不丈东)
        {
            Rilisoft.ClanStockWindow.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void ShowWindow()
        {
        
        }
        public void HideWindow()
        {
            this.Hide();
        }
        public void add_OnClose(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丑上丕丂丈丘丙七 != 1152921542418130352);
        
        }
        public void remove_OnClose(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丑上丕丂丈丘丙七 != 1152921542418266928);
        
        }
        internal static UnityEngine.Color 专且丈七丈丛丆东丈(ItemRarity 丈下丑丆上丏丗丈专)
        {
            System.Func<TSource, System.Boolean> val_5;
            .丈下丑丆上丏丗丈专 = 丈下丑丆上丏丗丈专;
            if((Rilisoft.ClanStockWindow.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return UnityEngine.Color.white;
            }
            
            System.Func<RarityColor, System.Boolean> val_3 = null;
            val_5 = val_3;
            val_3 = new System.Func<RarityColor, System.Boolean>(object:  new ClanStockWindow.丞丆丌万丛不且七丐(), method:  System.Boolean ClanStockWindow.丞丆丌万丛不且七丐::丟丛世世丝丛丈丟上(Rilisoft.ClanStockWindow.RarityColor 七丞丙丒三丕且丌丟));
            if((System.Linq.Enumerable.FirstOrDefault<RarityColor>(source:  Rilisoft.ClanStockWindow.<不丁丄七丛不丆丁丕>k__BackingField._rarityColors, predicate:  val_3)) == null)
            {
                    return UnityEngine.Color.white;
            }
            
            return new UnityEngine.Color() {r = val_4.Color};
        }
        private void Awake()
        {
            Rilisoft.ClanStockWindow.<不丁丄七丛不丆丁丕>k__BackingField = this;
            Rilisoft.ButtonHandler val_1 = this.btnFort.GetComponent<Rilisoft.ButtonHandler>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void Rilisoft.ClanStockWindow::HandleOnFortClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void OnEnable()
        {
            丛上丐丁丞三专专万 val_11;
            ClansController.上专丙下世丘七丛七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanStockWindow::丙丝专丙丅与丈一丗()));
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClanStockWindow::Hide()), 与且专丈不万东一万:  0);
            if(this.丝与丆丞东丘丈东丘 != false)
            {
                    this.丝一丅丆三东丂丞七();
                return;
            }
            
            val_11 = System.Delegate.Combine(a:  val_6.onGeometryUpdated, b:  new UIPanel.丛上丐丁丞三专专万(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.ClanStockWindow::上丛丌丆丑上七世三()));
            if((this._scroll.GetComponent<UIPanel>()) == null)
            {
                goto label_14;
            }
            
            if(val_11 != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(val_11 == null)
            {
                goto label_18;
            }
            
            label_15:
            if(null != null)
            {
                    val_11 = 0;
            }
            
            label_18:
            val_6.onGeometryUpdated = val_11;
        }
        private void OnDisable()
        {
            ClansController.丐专丕丌丒丌丕七丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanStockWindow::丙丝专丙丅与丈一丗()));
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        public void Show()
        {
            this.gameObject.SetActive(value:  true);
        }
        private void 上丛丌丆丑上七世三()
        {
            丛上丐丁丞三专专万 val_5;
            UIPanel val_1 = this._scroll.GetComponent<UIPanel>();
            val_5 = System.Delegate.Remove(source:  val_1.onGeometryUpdated, value:  new UIPanel.丛上丐丁丞三专专万(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.ClanStockWindow::上丛丌丆丑上七世三()));
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_5 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_5 == null)
            {
                goto label_7;
            }
            
            label_4:
            if(null != null)
            {
                    val_5 = 0;
            }
            
            label_7:
            val_1.onGeometryUpdated = val_5;
            if(val_1 != null)
            {
                    val_1.UpdateAnchors();
                this.丝一丅丆三东丂丞七();
                val_1.SetDirty();
            }
            else
            {
                    0.UpdateAnchors();
                this.丝一丅丆三东丂丞七();
                val_1.SetDirty();
            }
            
            val_1.Refresh();
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
            if(this.丄丑上丕丂丈丘丙七 == null)
            {
                    return;
            }
            
            this.丄丑上丕丂丈丘丙七.Invoke();
        }
        private void 丙丝专丙丅与丈一丗()
        {
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            System.Collections.Generic.List<ClanItem> val_13;
            ClanStockWindow.丛东丟丅丙丗世丗不 val_1 = new ClanStockWindow.丛东丟丅丙丗世丗不();
            .丝且与丝丒丟万丁专 = this;
            if(this._allItems == null)
            {
                    return;
            }
            
            this._allItems = ClansController.专下不丂丄丞丒万丕(丁丅丈丌丟世丗丗丟:  new System.Nullable<ClanItemType>() {HasValue = false});
            this._existsItems = ClansController.丅丙丕世不丈丝丆与(丁丅丈丌丟世丗丗丟:  new System.Nullable<ClanItemType>() {HasValue = false});
            System.Collections.Generic.Dictionary<丗丞丏丙七丑丕且丐, System.String> val_4 = Rilisoft.FortsManager.丈丕丗丕丆丛丄丆丘();
            .丝且丁丙丙东丁专专 = val_4;
            if(val_4 != null)
            {
                    this._existsItems.AddRange(collection:  this._allItems.FindAll(match:  new System.Predicate<ClanItem>(object:  val_1, method:  System.Boolean ClanStockWindow.丛东丟丅丙丗世丗不::丑专业与不上不七专(ClanItem 丙丒七丄上与丏丙丙))));
            }
            
            val_13 = this._allItems;
            if(this._existsItems.Count >= 1)
            {
                    val_13 = System.Linq.Enumerable.ToList<ClanItem>(source:  System.Linq.Enumerable.Where<ClanItem>(source:  val_13, predicate:  new System.Func<ClanItem, System.Boolean>(object:  val_1, method:  System.Boolean ClanStockWindow.丛东丟丅丙丗世丗不::七丅丐丏丝七丄丏丛(ClanItem 七丞丙丒三丕且丌丟))));
            }
            
            this._notExistsItems = val_13;
            this._existsItems.Sort(comparison:  new System.Comparison<ClanItem>(object:  0, method:  static System.Int32 Rilisoft.ClanStockWindow::丛下万与丝丝一丈丂(ClanItem 与丕丁三万专世不丅, ClanItem 丏丛与丅丛丌万专丌)));
            this._notExistsItems.Sort(comparison:  new System.Comparison<ClanItem>(object:  0, method:  static System.Int32 Rilisoft.ClanStockWindow::丛下万与丝丝一丈丂(ClanItem 与丕丁三万专世不丅, ClanItem 丏丛与丅丛丌万专丌)));
            this.业丞与不丏七丑丘丘();
        }
        private void 业丞与不丏七丑丘丘()
        {
            var val_18;
            丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this._scroll);
            UnityEngine.Transform val_2 = this._scroll.panel.transform;
            if(val_2 != null)
            {
                    UnityEngine.Vector3 val_3 = val_2.localPosition;
                val_18 = val_3.y;
            }
            else
            {
                    UnityEngine.Vector3 val_4 = 0.localPosition;
                val_18 = val_4.y;
            }
            
            UnityEngine.Vector3 val_5 = val_2.localPosition;
            val_2.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_8 = this._scroll.panel.clipOffset;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0f, y:  val_8.y);
            this._scroll.panel.clipOffset = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            UnityEngine.GameObject val_11 = this._headerFirst.gameObject;
            if(this._existsItems.Count >= 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
                this._headerFirst.width = (int)this._scroll.panel.width;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gridFirst.gameObject, 丏业丟一东丂东丘丛:  true);
                this.上丌丌东万不三丝丄(丝三不丑丏丘丒丂丗:  this._gridFirst, 三丏丑不业丏不丂丈:  this._existsItems);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gridFirst.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            this._headerSecond.width = (int)this._scroll.panel.width;
            this.上丌丌东万不三丝丄(丝三不丑丏丘丒丂丗:  this._gridSecond, 三丏丑不业丏不丂丈:  this._notExistsItems);
            this._table.repositionNow = true;
            this._scroll.ResetPosition();
            this._scroll.Restrict();
        }
        private void 专万丏丏东与丌下且(UIGrid 丝三不丑丏丘丒丂丗, System.Collections.Generic.List<ClanItem> 丑七不与丛丆一丂丞)
        {
            var val_7;
            var val_8;
            UnityEngine.Transform val_1 = 丝三不丑丏丘丒丂丗.transform;
            val_7 = 0;
            goto label_2;
            label_8:
            ClanItemView val_3 = val_1.GetChild(index:  0).GetComponent<ClanItemView>();
            if(val_3 != null)
            {
                    val_8 = val_3.Item;
            }
            else
            {
                    val_8 = val_3.Item;
            }
            
            val_7 = 1;
            label_2:
            if(val_7 < val_1.childCount)
            {
                goto label_8;
            }
        
        }
        private static int 丛下万与丝丝一丈丂(ClanItem 与丕丁三万专世不丅, ClanItem 丏丛与丅丛丌万专丌)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            if(与丕丁三万专世不丅 == null)
            {
                goto label_0;
            }
            
            if(丏丛与丅丛丌万专丌 == null)
            {
                goto label_1;
            }
            
            if(与丕丁三万专世不丅.Type != 丏丛与丅丛丌万专丌.Type)
            {
                goto label_2;
            }
            
            if(丏丛与丅丛丌万专丌.IsDefault ^ 与丕丁三万专世不丅.IsDefault == false)
            {
                goto label_3;
            }
            
            var val_7 = ((与丕丁三万专世不丅.IsDefault & true) != 0) ? (-0) : 0;
            return (int)(val_22 <= val_23.SortOrder) ? (-val_21) : (val_21);
            label_0:
            var val_8 = (丏丛与丅丛丌万专丌 != 0) ? (-0) : 0;
            return (int)(val_22 <= val_23.SortOrder) ? (-val_21) : (val_21);
            label_1:
            val_20 = 0;
            return (int)(val_22 <= val_23.SortOrder) ? (-val_21) : (val_21);
            label_2:
            ClanItemType val_9 = 丏丛与丅丛丌万专丌.Type;
            ClanItemType val_10 = 与丕丁三万专世不丅.Type;
            val_21 = 1;
            return (int)(val_22 <= val_23.SortOrder) ? (-val_21) : (val_21);
            label_3:
            if(丏丛与丅丛丌万专丌.Rarity != 与丕丁三万专世不丅.Rarity)
            {
                goto label_8;
            }
            
            if(与丕丁三万专世不丅.SortOrder != 丏丛与丅丛丌万专丌.SortOrder)
            {
                goto label_9;
            }
            
            val_20 = 0;
            return (int)(val_22 <= val_23.SortOrder) ? (-val_21) : (val_21);
            label_8:
            val_22 = 丏丛与丅丛丌万专丌.Rarity;
            ItemRarity val_16 = 与丕丁三万专世不丅.Rarity;
            goto label_11;
            label_9:
            val_22 = 丏丛与丅丛丌万专丌.SortOrder;
            val_23 = 与丕丁三万专世不丅;
            label_11:
            val_21 = 0;
            return (int)(val_22 <= val_23.SortOrder) ? (-val_21) : (val_21);
        }
        private void 上丌丌东万不三丝丄(UIGrid 丝三不丑丏丘丒丂丗, System.Collections.Generic.List<ClanItem> 三丏丑不业丏不丂丈)
        {
            var val_39;
            object val_56;
            float val_57;
            var val_58;
            UnityEngine.GameObject val_59;
            var val_60;
            val_56 = this;
            UnityEngine.Transform val_1 = 丝三不丑丏丘丒丂丗.transform;
            if(val_1.childCount == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = val_1.GetChild(index:  0);
            if(val_3 != null)
            {
                    val_3.name = "0000";
            }
            else
            {
                    0.name = "0000";
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3.gameObject, 丏业丟一东丂东丘丛:  false);
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<ClanItem>(source:  三丏丑不业丏不丂丈);
            val_57 = this._scroll.panel.width / 丝三不丑丏丘丒丂丗.cellWidth;
            int val_55 = UnityEngine.Mathf.FloorToInt(f:  val_57);
            int val_9 = val_5.Count;
            int val_10 = val_9 / val_55;
            val_10 = val_9 - (val_10 * val_55);
            val_55 = (val_10 > 0) ? (val_55 - val_10) : 0;
            if(val_55 >= 1)
            {
                    do
            {
                val_5.Add(item:  0);
                val_55 = val_55 - 1;
            }
            while(val_55 != 0);
            
            }
            
            if(val_1.childCount >= val_5.Count)
            {
                goto label_20;
            }
            
            goto label_21;
            label_34:
            if(val_1 != null)
            {
                    val_58 = val_1.childCount;
            }
            else
            {
                    val_58 = 0.childCount;
            }
            
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            val_57 = val_22.x;
            UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_1.GetChild(index:  val_58 - 1), parent:  丝三不丑丏丘丒丂丗.gameObject.transform).transform.localScale = new UnityEngine.Vector3() {x = val_57, y = val_22.y, z = val_22.z};
            label_21:
            val_59 = val_1.childCount;
            if(val_59 < val_5.Count)
            {
                goto label_34;
            }
            
            goto label_38;
            label_20:
            val_59 = val_1.childCount;
            if(val_59 <= val_5.Count)
            {
                goto label_38;
            }
            
            goto label_39;
            label_49:
            if(val_1.childCount <= 1)
            {
                goto label_41;
            }
            
            if(val_1 != null)
            {
                    val_60 = val_1.childCount;
            }
            else
            {
                    val_60 = 0.childCount;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_1.GetChild(index:  val_60 - 1).gameObject);
            label_39:
            if(val_1.childCount > val_5.Count)
            {
                goto label_49;
            }
            
            label_41:
            val_59 = val_1.GetChild(index:  0).gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_59, 丏业丟一东丂东丘丛:  false);
            label_38:
            List.Enumerator<T> val_37 = val_5.GetEnumerator();
            goto label_55;
            label_69:
            string val_40 = val_39.丐丏七丌丕丗业且上();
            UnityEngine.Transform val_41 = val_1.GetChild(index:  0);
            val_41.name = 0.ToString(format:  "0000");
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_41.gameObject, 丏业丟一东丂东丘丛:  true);
            val_59 = val_41.GetComponent<ClanItemView>();
            if(val_59 != 0)
            {
                    System.Action<ClanItemView> val_46 = new System.Action<ClanItemView>(object:  this, method:  System.Void Rilisoft.ClanStockWindow::丞丒东丅丝专七丐万(ClanItemView 丁世丛业丟下丕三丟));
                val_59.remove_OnClicked(丙业与丙丗丝不丈东:  null);
                System.Action<ClanItemView> val_47 = new System.Action<ClanItemView>(object:  this, method:  System.Void Rilisoft.ClanStockWindow::丞丒东丅丝专七丐万(ClanItemView 丁世丛业丟下丕三丟));
                val_59.add_OnClicked(丙业与丙丗丝不丈东:  null);
                System.Func<ClanItem, System.String> val_48 = new System.Func<ClanItem, System.String>(object:  this, method:  System.String Rilisoft.ClanStockWindow::业三不丄一丂丒丟下(ClanItem 下丅丙一丂丗丅丝七));
                if(val_59 != null)
            {
                    val_44.CountFormatter = null;
            }
            else
            {
                    mem[72] = null;
            }
            
            }
            
            var val_56 = 0;
            val_56 = val_56 + 1;
            label_55:
            if(((-840949888) & 1) != 0)
            {
                goto label_69;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_56 = this._scroll.panel;
            float val_57 = val_56.width;
            val_57 = val_57 / 丝三不丑丏丘丒丂丗.cellWidth;
            int val_51 = UnityEngine.Mathf.FloorToInt(f:  val_57);
            丝三不丑丏丘丒丂丗.maxPerLine = val_51;
            float val_58 = (float)val_51;
            val_58 = (val_57 - val_58) / val_58;
            val_57 = val_58 + 1f;
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z}, d:  val_57);
            val_1.localScale = new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z};
        }
        private void 丞丒东丅丝专七丐万(ClanItemView 丁世丛业丟下丕三丟)
        {
            ClanItemView val_7 = 丁世丛业丟下丕三丟;
            if(val_7 == 0)
            {
                    return;
            }
            
            if(val_7.Item == null)
            {
                    return;
            }
            
            val_7 = val_7.Item.Id;
            Rilisoft.ItemViewer val_6 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewClanStorage", 丆丏七丟不丒与七专:  this.transform, 丕丁下丌不万丅丞丛:  val_7, 丅三丟世下丞丝丙万:  1, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        private string 业三不丄一丂丒丟下(ClanItem 下丅丙一丂丗丅丝七)
        {
            int val_8;
            int val_9;
            val_8 = 下丅丙一丂丗丅丝七;
            if(val_8 == null)
            {
                goto label_1;
            }
            
            int val_3 = ClansController.且三七丐丛七世丞丆(丞一丁业丄一一业且:  val_8.Id, 下丗丁丒丘东丂不丑:  val_8.Type);
            if(val_3 <= 0)
            {
                goto label_4;
            }
            
            val_8 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_8.Id);
            string val_7 = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.Min(a:  val_3, b:  val_8), arg1:  val_8);
            return (string)val_9;
            label_1:
            val_9 = 0;
            return (string)val_9;
            label_4:
            val_9 = System.String.alignConst;
            return (string)val_9;
        }
        public void U_HideRequest()
        {
            this.Hide();
        }
        public void HandleOnFortClicked(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_6;
            System.Action val_8;
            var val_9;
            var val_10;
            val_6 = null;
            val_6 = null;
            val_8 = ClanStockWindow.<>c.<>9__32_0;
            if(val_8 == null)
            {
                    System.Action val_1 = null;
                val_8 = val_1;
                val_1 = new System.Action(object:  ClanStockWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStockWindow.<>c::丆丝丘专丌不丄丐丄());
                ClanStockWindow.<>c.<>9__32_0 = val_8;
            }
            
            val_9 = null;
            val_9 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.HideInterface();
            val_10 = null;
            val_10 = null;
            Rilisoft.Singleton<Rilisoft.FortCraftSceneLoader>.Instance.ToCraftScene(丞丌丐丞丞丘丏专下:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟(), 丆三丑万丂丌世丆丆:  false, 丟不丒万丝与丂上丘:  val_1, 丈东丘丏与丌东东下:  MainMenuController.丄丞丁丈与业上丞丟.gameObject);
        }
        public ClanStockWindow()
        {
        
        }
    
    }

}
