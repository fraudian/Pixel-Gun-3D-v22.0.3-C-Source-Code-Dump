using UnityEngine;

namespace Rilisoft
{
    public class GameEventMostExpensiveItemsView : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑, 七丌且丛万与丞世丁<Rilisoft.丛且世丐丆上七业丁, Rilisoft.与专丒丞丐一丒丂东>
    {
        // Fields
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private Rilisoft.与专丒丞丐一丒丂东 <丝七不世七下世东丄>k__BackingField;
        private System.Action<Rilisoft.GameEventItemData> 丄丏丕丗丅丄东丙上;
        private UIGrid _grid;
        private UIScrollView _scroll;
        private UILabel _remainingRewardsLabel;
        
        // Properties
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        public Rilisoft.与专丒丞丐一丒丂东 丌且丝丘丌丕东丒与 { get; set; }
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.与专丒丞丐一丒丂东 get_Parameter()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丝七不世七下世东丄>k__BackingField;
        }
        public void set_Parameter(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丝七不世七下世东丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.<丝七不世七下世东丄>k__BackingField = 丆且丁丒丒丆丁三丆;
            this._remainingRewardsLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4948"), arg0:  丆且丁丒丒丆丁三丆.Count, arg1:  丆且丁丒丒丆丁三丆.Count);
            this.东丘丙且丐丛丏丝业();
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
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        public void HideWindow()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void add_OnItemClicked(System.Action<Rilisoft.GameEventItemData> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丏丕丗丅丄东丙上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丏丕丗丅丄东丙上 != 1152921542768853896);
        
        }
        public void remove_OnItemClicked(System.Action<Rilisoft.GameEventItemData> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丏丕丗丅丄东丙上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丏丕丗丅丄东丙上 != 1152921542768990472);
        
        }
        private void 东丘丙且丐丛丏丝业()
        {
            var val_25;
            UIGrid val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            UIScrollView val_31;
            System.Collections.Generic.List<Rilisoft.GameEventItem> val_1 = this.业丐丕不下万丙三丘();
            val_25 = 1152921542706720640;
            val_26 = this._grid;
            if(val_1.Count <= 0)
            {
                goto label_3;
            }
            
            UnityEngine.Transform val_3 = val_26.transform;
            val_27 = 1152921505284374528;
            goto label_4;
            label_11:
            UnityEngine.GameObject val_6 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_3.GetChild(index:  0).gameObject, 丈东丘丏与丌东东下:  val_3, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            label_4:
            if(val_3.childCount < val_1.Count)
            {
                goto label_11;
            }
            
            int val_10 = val_1.Count;
            val_28 = val_10;
            goto label_13;
            label_18:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_10.GetChild(丞世不丒下上上丝丑:  0).gameObject);
            val_28 = val_28 + 1;
            label_13:
            if(val_28 < val_3.childCount)
            {
                goto label_18;
            }
            
            UnityEngine.GameObject val_13 = this._grid.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
            val_29 = 1152921504848912384;
            val_30 = 0;
            goto label_21;
            label_34:
            GameEventItemGui val_15 = val_13.GetChild(丞世不丒下上上丝丑:  0).GetComponent<GameEventItemGui>();
            if(val_15 == 0)
            {
                goto label_26;
            }
            
            Rilisoft.GameEventItem val_17 = val_1.Item[0];
            val_15.name = 0.ToString(format:  "#0000");
            val_29 = val_29;
            if(val_15 == null)
            {
                goto label_30;
            }
            
            val_31 = val_27;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15.gameObject, 丏业丟一东丂东丘丛:  true);
            val_15.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<GameEventItemGui>(object:  this, method:  System.Void Rilisoft.GameEventMostExpensiveItemsView::丒丂丙丂一丞丟且万(GameEventItemGui 丌丝万上丅丒一丈丘)));
            val_15.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<GameEventItemGui>(object:  this, method:  System.Void Rilisoft.GameEventMostExpensiveItemsView::丒丂丙丂一丞丟且万(GameEventItemGui 丌丝万上丅丒一丈丘)));
            val_25 = 1152921542706720640;
            val_27 = val_31;
            label_26:
            val_30 = 0 + 1;
            label_21:
            val_26 = this._grid;
            if(val_30 < val_1.Count)
            {
                goto label_34;
            }
            
            this._grid.repositionNow = true;
            if(this._scroll == 0)
            {
                    return;
            }
            
            val_31 = this._scroll;
            val_31.ResetPosition();
            return;
            label_3:
            val_31 = val_26.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  false);
            return;
            label_30:
        }
        private void 丒丂丙丂一丞丟且万(GameEventItemGui 丌丝万上丅丒一丈丘)
        {
            if(丌丝万上丅丒一丈丘 == 0)
            {
                    return;
            }
            
            if(this.丄丏丕丗丅丄东丙上 == null)
            {
                    return;
            }
            
            this.丄丏丕丗丅丄东丙上.Invoke(obj:  丌丝万上丅丒一丈丘.Data);
        }
        private System.Collections.Generic.List<Rilisoft.GameEventItem> 业丐丕不下万丙三丘()
        {
            var val_7;
            System.Func<Rilisoft.GameEventItemContainer, Rilisoft.GameEventItem> val_9;
            var val_11;
            System.Func<Rilisoft.GameEventItem, System.Int32> val_13;
            var val_14;
            if((this.<丝七不世七下世东丄>k__BackingField) != null)
            {
                    val_7 = null;
                val_7 = null;
                val_9 = GameEventMostExpensiveItemsView.<>c.<>9__18_0;
                if(val_9 == null)
            {
                    System.Func<Rilisoft.GameEventItemContainer, Rilisoft.GameEventItem> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Func<Rilisoft.GameEventItemContainer, Rilisoft.GameEventItem>(object:  GameEventMostExpensiveItemsView.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.GameEventItem GameEventMostExpensiveItemsView.<>c::丂不丕丄丝丁丞上丞(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙));
                GameEventMostExpensiveItemsView.<>c.<>9__18_0 = val_9;
            }
            
                val_11 = null;
                val_11 = null;
                val_13 = GameEventMostExpensiveItemsView.<>c.<>9__18_1;
                if(val_13 == null)
            {
                    System.Func<Rilisoft.GameEventItem, System.Int32> val_3 = null;
                val_13 = val_3;
                val_3 = new System.Func<Rilisoft.GameEventItem, System.Int32>(object:  GameEventMostExpensiveItemsView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GameEventMostExpensiveItemsView.<>c::丅丐丒万丅丟丟与丒(Rilisoft.GameEventItem 七丞丙丒三丕且丌丟));
                GameEventMostExpensiveItemsView.<>c.<>9__18_1 = val_13;
            }
            
                val_14 = System.Linq.Enumerable.ToList<Rilisoft.GameEventItem>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.GameEventItem, System.Int32>(source:  System.Linq.Enumerable.Select<Rilisoft.GameEventItemContainer, Rilisoft.GameEventItem>(source:  this.<丝七不世七下世东丄>k__BackingField, selector:  val_1), keySelector:  val_3));
                return (System.Collections.Generic.List<Rilisoft.GameEventItem>)val_14;
            }
            
            System.Collections.Generic.List<Rilisoft.GameEventItem> val_6 = null;
            val_14 = val_6;
            val_6 = new System.Collections.Generic.List<Rilisoft.GameEventItem>();
            return (System.Collections.Generic.List<Rilisoft.GameEventItem>)val_14;
        }
        public GameEventMostExpensiveItemsView()
        {
        
        }
    
    }

}
