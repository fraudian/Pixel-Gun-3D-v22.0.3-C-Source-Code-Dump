using UnityEngine;

namespace Rilisoft
{
    internal class GridOfferPackDrawer : BaseOfferPackDrawer, 丄与且丈丘丄三丗丐
    {
        // Fields
        internal static System.Collections.Generic.Dictionary<string, string> 东丟丈丙丄业丗丟丗;
        private UnityEngine.Transform _backgroundsContainer;
        private UILabel _D_packId;
        private System.Collections.Generic.List<Rilisoft.OfferItem> _itemsToShow;
        private Rilisoft.ButtonEventsHandler _lobbyPackViewButton;
        private PositionHolder _positionHolder;
        private Rilisoft.ItemViewer 丂不丆丆丞东丌丌且;
        
        // Properties
        public override int 下丄丈不与世丐业专 { get; }
        
        // Methods
        public override int get_Id()
        {
            return 1;
        }
        public override bool Show(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗, Rilisoft.BonusData 丛丝丙丄七一丁丅三)
        {
            var val_2;
            if((this.Show(不专一业下丞丝丑丗:  不专一业下丞丝丑丗, 丛丝丙丄七一丁丅三:  丛丝丙丄七一丁丅三)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._lobbyPackViewButton, 丏业丟一东丂东丘丛:  false);
                this.丝万丑丞丌丄丙七东();
            }
            else
            {
                    val_2 = 0;
                return (bool)val_2;
            }
            
            this.丘丘丙丒丛丈丟丕丛();
            this.东不丞丂万下三与丕();
            val_2 = 1;
            return (bool)val_2;
        }
        private void 丌丂丆不不专万丙丅(Rilisoft.BaseOfferItemCellView 丌丝万上丅丒一丈丘)
        {
            丕丈丏丑丌丂且万不 val_26;
            string val_27;
            if(丌丝万上丅丒一丈丘 == 0)
            {
                    return;
            }
            
            if(丌丝万上丅丒一丈丘.Item == null)
            {
                    return;
            }
            
            ItemViewer.丕丈丏丑丌丂且万不 val_3 = null;
            val_26 = val_3;
            val_3 = new ItemViewer.丕丈丏丑丌丂且万不();
            if(丌丝万上丅丒一丈丘.Item.Record != null)
            {
                    System.Nullable<ItemRarity> val_7 = 丌丝万上丅丒一丈丘.Item.Rarity;
                .丅万丗上三不丙丆丒 = WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  val_7.HasValue);
            }
            
            if(丌丝万上丅丒一丈丘.Item.Type == 70)
            {
                    val_27 = 丌丝万上丅丒一丈丘.Item.Id;
                if((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且七东专世丝丒丟一(丞一丁业丄一一业且:  val_27, 专丏世丑与丐丝丝七:  true, 丗与丟上上丑专世丗:  new System.Nullable<OfferModule>() {HasValue = false})) != false)
            {
                    val_27 = 丌丝万上丅丒一丈丘.Item.Type;
                int val_20 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  val_27, 丞一丁业丄一一业且:  丌丝万上丅丒一丈丘.Item.Id);
                if(val_20 >= 1)
            {
                    val_27 = ExperienceController.丞丞丘业东丙丏七丌();
                .万丄丅丛下丐丒丞上 = BalanceController.与丗万世丅下丈万丁(丞世不丒下上上丝丑:  val_20, 丈丘丝一丗下丈丐不:  val_27, 丐丏上业丈丂与万丞:  true);
            }
            
            }
            
            }
            
            this.丂不丆丆丞东丌丌且 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丏且丕丄丁丟丆丏丁:  丌丝万上丅丒一丈丘.Item, 丗丟上上丒丐丗丞丙:  val_3, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        }
        public override void Hide(System.Action 不丐世丞丏且丛丐业)
        {
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.丂不丆丆丞东丌丌且, y:  0);
            this.Hide(不丐世丞丏且丛丐业:  不丐世丞丏且丛丐业);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.丂不丆丆丞东丌丌且 == 0)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Rilisoft.ItemViewer).__il2cppRuntimeField_178;
        }
        private void 丘丘丙丒丛丈丟丕丛()
        {
            string val_17;
            System.Collections.Generic.Dictionary<System.String, System.String> val_18;
            var val_19;
            int val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            UnityEngine.GameObject val_25;
            if(true == 0)
            {
                goto label_1;
            }
            
            bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  1073741824);
            if(val_1 == false)
            {
                goto label_4;
            }
            
            label_1:
            if(val_1 == false)
            {
                    return;
            }
            
            val_17 = val_1.业上丙丞丐丄丆丅七();
            if(val_17 != null)
            {
                goto label_7;
            }
            
            return;
            label_4:
            val_17 = mem[504464731990392880];
            if(val_17 == 0)
            {
                    return;
            }
            
            label_7:
            val_18 = 1152921504624312320;
            val_19 = null;
            val_20 = System.String.alignConst;
            val_19 = null;
            val_21 = null;
            if((Rilisoft.GridOfferPackDrawer.东丟丈丙丄业丗丟丗.ContainsKey(key:  val_17)) != false)
            {
                    val_22 = null;
                val_20 = Rilisoft.GridOfferPackDrawer.东丟丈丙丄业丗丟丗.Item[val_17];
            }
            else
            {
                    val_23 = null;
                val_18 = Rilisoft.GridOfferPackDrawer.东丟丈丙丄业丗丟丗;
                val_18.Add(key:  val_17, value:  System.String.alignConst);
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_20)) != false)
            {
                    val_20 = this._backgroundsContainer.GetChild(index:  UnityEngine.Random.Range(min:  0, max:  this._backgroundsContainer.childCount)).name;
            }
            
            val_24 = null;
            val_24 = null;
            Rilisoft.GridOfferPackDrawer.东丟丈丙丄业丗丟丗.set_Item(key:  val_17, value:  val_20);
            Rilisoft.OfferPackWindow.七丁丈丟丘丞丗七丑(丙业与丙丗丝不丈东:  val_20);
            val_17 = 0;
            goto label_33;
            label_41:
            UnityEngine.Transform val_10 = this._backgroundsContainer.GetChild(index:  0);
            if(val_10 != null)
            {
                    val_25 = val_10.gameObject;
            }
            else
            {
                    val_25 = 0.gameObject;
            }
            
            string val_17 = val_20;
            val_18 = System.String.op_Equality(a:  val_10.gameObject.name, b:  val_17);
            val_17 = val_18;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  val_17);
            val_17 = 1;
            label_33:
            if(val_17 < this._backgroundsContainer.childCount)
            {
                goto label_41;
            }
        
        }
        private void 丝万丑丞丌丄丙七东()
        {
            var val_7;
            if(true == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._D_packId.gameObject, 丏业丟一东丂东丘丛:  false);
            this._positionHolder.SetState(丏业丟一东丂东丘丛:  System.Math.Max(val1:  0, val2:  X21.Count - 1));
            List.Enumerator<T> val_5 = this._positionHolder.GetEnumerator();
            label_19:
            label_17:
            if((26990336 & 1) == 0)
            {
                goto label_10;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if((this._positionHolder.obj[0].GetComponent<Rilisoft.BaseOfferItemCellView>()) == 0)
            {
                goto label_17;
            }
            
            System.Action<Rilisoft.BaseOfferItemCellView> val_11 = new System.Action<Rilisoft.BaseOfferItemCellView>(object:  this, method:  System.Void Rilisoft.GridOfferPackDrawer::丌丂丆不不专万丙丅(Rilisoft.BaseOfferItemCellView 丌丝万上丅丒一丈丘));
            var val_12 = 0 + 1;
            goto label_19;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        }
        private void 七丕丞丆三世丆丙万()
        {
            var val_9;
            if(true == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_1 = this._D_packId.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
            if(val_1.Count != 0)
            {
                    val_9 = System.Math.Min(val1:  val_1.Count, val2:  12);
                this._positionHolder.SetState(丏业丟一东丂东丘丛:  val_9 - 1);
                if(val_9 >= 1)
            {
                    var val_10 = 0;
                do
            {
                val_9 = this._positionHolder.obj[val_10].GetComponent<Rilisoft.BaseOfferItemCellView>();
                Rilisoft.OfferItem val_7 = X22.Item[0];
                System.Action<Rilisoft.BaseOfferItemCellView> val_8 = new System.Action<Rilisoft.BaseOfferItemCellView>(object:  this, method:  System.Void Rilisoft.GridOfferPackDrawer::丌丂丆不不专万丙丅(Rilisoft.BaseOfferItemCellView 丌丝万上丅丒一丈丘));
                val_10 = val_10 + 1;
            }
            while(val_9 != val_10);
            
            }
            
                this.丌丕丈下丆与专丞世();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "offer pack not contains any item");
        }
        private void 丌丕丈下丆与专丞世()
        {
            var val_8;
            var val_9;
            if(this._lobbyPackViewButton == 0)
            {
                    return;
            }
            
            if(this._lobbyPackViewButton.丑且一丐东三不丈丝() != 120)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            if(GiftBannerWindow.丘丆且七丑丘且专丟 == true)
            {
                    return;
            }
            
            if(Initializer.丑七不且上丗丁一世() != 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if(Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂 != 0)
            {
                    return;
            }
            
            this._lobbyPackViewButton.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.GridOfferPackDrawer::不丙东下丒丝上丒丐()));
            this._lobbyPackViewButton.OnClickEvent.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.GridOfferPackDrawer::不丙东下丒丝上丒丐()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._lobbyPackViewButton, 丏业丟一东丂东丘丛:  true);
        }
        private void 不丙东下丒丝上丒丐()
        {
            if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
            {
                    ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            }
            
            BankController.丑七不且上丗丁一世().丏丈丁丌丈丅丙且丒(不专一业下丞丝丑丗:  this);
        }
        protected override void 丟且丆丙丆丁丆一万()
        {
            var val_7;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_9;
            if(true == 0)
            {
                    return;
            }
            
            if(41613 == 0)
            {
                    return;
            }
            
            if(41613.Count < 2)
            {
                    return;
            }
            
            Sort(comparison:  new System.Comparison<Rilisoft.OfferItem>(object:  this, method:  System.Int32 Rilisoft.GridOfferPackDrawer::七丄一专丑丟丙一丂(Rilisoft.OfferItem 与丕丁三万专世不丅, Rilisoft.OfferItem 丏丛与丅丛丌万专丌)));
            val_7 = null;
            val_7 = null;
            val_9 = GridOfferPackDrawer.<>c.<>9__18_0;
            if(val_9 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_3 = null;
                val_9 = val_3;
                val_3 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  GridOfferPackDrawer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GridOfferPackDrawer.<>c::丆丟不丘丆丆丆丗丝(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                GridOfferPackDrawer.<>c.<>9__18_0 = val_9;
            }
            
            Rilisoft.OfferItem val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  137125888, predicate:  val_3);
            if(val_4 == null)
            {
                    return;
            }
            
            if((val_3.IndexOf(item:  val_4)) == 0)
            {
                    return;
            }
            
            bool val_6 = val_3.Remove(item:  val_4);
            this.Insert(index:  0, item:  val_4);
        }
        protected int 七丄一专丑丟丙一丂(Rilisoft.OfferItem 与丕丁三万专世不丅, Rilisoft.OfferItem 丏丛与丅丛丌万专丌)
        {
            var val_11;
            var val_12;
            if(与丕丁三万专世不丅 == null)
            {
                goto label_1;
            }
            
            if(丏丛与丅丛丌万专丌 == null)
            {
                goto label_2;
            }
            
            if(与丕丁三万专世不丅.Type != 丏丛与丅丛丌万专丌.Type)
            {
                goto label_3;
            }
            
            int val_3 = 与丕丁三万专世不丅.Count;
            int val_4 = 丏丛与丅丛丌万专丌.Count;
            val_11 = 0;
            return (int)((Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  与丕丁三万专世不丅.Type)) <= (Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  丏丛与丅丛丌万专丌.Type))) ? (-val_11) : (val_11);
            label_1:
            var val_5 = (丏丛与丅丛丌万专丌 != 0) ? 1 : 0;
            return (int)((Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  与丕丁三万专世不丅.Type)) <= (Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  丏丛与丅丛丌万专丌.Type))) ? (-val_11) : (val_11);
            label_2:
            val_12 = 0;
            return (int)((Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  与丕丁三万专世不丅.Type)) <= (Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  丏丛与丅丛丌万专丌.Type))) ? (-val_11) : (val_11);
            label_3:
            val_11 = 1;
            return (int)((Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  与丕丁三万专世不丅.Type)) <= (Rilisoft.下丐丒一丝丈丝三丞.丈丗三上不丏三万丛(丁丅丈丌丟世丗丗丟:  丏丛与丅丛丌万专丌.Type))) ? (-val_11) : (val_11);
        }
        public GridOfferPackDrawer()
        {
        
        }
        private static GridOfferPackDrawer()
        {
            Rilisoft.GridOfferPackDrawer.东丟丈丙丄业丗丟丗 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
