using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventGuiSets : AbstractGameEventGui
    {
        // Fields
        private Rilisoft.GameEventSetsViewBase _mainView;
        private UnityEngine.Transform _buyDetailsPlacePoint;
        private UnityEngine.Transform _viewsContainer;
        private UnityEngine.GameObject _buttonGoToEventHub;
        private System.Collections.Generic.List<Rilisoft.GameEventSetsViewBase> _contentViews;
        private Rilisoft.GameEventSetsViewBase <丌东丝万丏世七丗丌>k__BackingField;
        private static bool <丘三丁丝丒丏业丞丈>k__BackingField;
        private UnityEngine.Color 世下丕东七丆丆专三;
        
        // Properties
        private Rilisoft.GameEventSetsViewBase 丁丆下且一丞一上三 { get; set; }
        internal static bool 丒丕丂丌丁丂万东丏 { get; set; }
        
        // Methods
        private Rilisoft.GameEventSetsViewBase 不世丌丅丈世与且丗()
        {
            return (Rilisoft.GameEventSetsViewBase)this.<丌东丝万丏世七丗丌>k__BackingField;
        }
        private void 丗丐一丑不不丑丞东(Rilisoft.GameEventSetsViewBase 丙业与丙丗丝不丈东)
        {
            this.<丌东丝万丏世七丗丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 东东丒不下丆世业不()
        {
            return (bool)Rilisoft.GameEventGuiSets.<丘三丁丝丒丏业丞丈>k__BackingField;
        }
        private static void 七不万不丞丏下丒丛(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.GameEventGuiSets.<丘三丁丝丒丏业丞丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void HandlePropertiesPopupButton()
        {
            Rilisoft.丛且世丐丆上七业丁 val_1 = this.Context;
            if(val_1 != null)
            {
                    Rilisoft.上专业三丟丁丞专下 val_2 = val_1.且丌三丙丙与与丝世();
            }
            
            if(this._mainView == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            PropertiesArmoryItemContainer val_3 = this._mainView.丌丁业不丄丅且丏丘();
            if(val_3 == null)
            {
                    return;
            }
            
            PropertiesPopupController val_4 = val_3.丛且丒万丞丝丞丝丕();
            if(val_4 == null)
            {
                    return;
            }
            
            val_4.丈且东丑丂且万丒丅(丒东业不丐丑丕丄丆:  0);
        }
        public void HandleHidePropertiesPopupButton()
        {
            if(this._mainView == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            PropertiesArmoryItemContainer val_1 = this._mainView.丌丁业不丄丅且丏丘();
            if(val_1 == null)
            {
                    return;
            }
            
            PropertiesPopupController val_2 = val_1.丛且丒万丞丝丞丝丕();
            if(val_2 == null)
            {
                    return;
            }
            
            val_2.Hide();
        }
        public override void HideWindow()
        {
            Rilisoft.AbstractGameEventGui.丏世且丞世丂丈丗东 = 0;
            Rilisoft.GameEventGuiHandler.丆三丘丅且东万与丘();
        }
        public override void ShowWindow(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            Rilisoft.丛且世丐丆上七业丁 val_7 = 与且专丈不万东一万;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            if(val_7 == null)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(Rilisoft.GameEventGuiSets).__il2cppRuntimeField_248;
        }
        public override void SetContext(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            var val_10;
            Rilisoft.GameEventSetsViewBase val_24;
            UnityEngine.GameObject val_25;
            var val_26;
            var val_27;
            val_25 = this;
            this.SetContext(与且专丈不万东一万:  与且专丈不万东一万);
            if(this.Context == null)
            {
                    return;
            }
            
            if(this.Context != null)
            {
                    Rilisoft.GameEventType val_4 = this.Context.不业丙丒丂丞下丆丙();
            }
            
            System.Collections.Generic.List<Rilisoft.DroppedItemData> val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().业业丌不丄丏丈上一(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false});
            if(val_6 != null)
            {
                    val_6.丘且下丌丏下丈丘丄(丘上丏丟一一丝上丙:  val_6);
                Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().专且丈丒世丘丅丝下(且下丕七丙丗丄不七:  new System.Nullable<Rilisoft.GameEventType>() {HasValue = false}, 丑七不与丛丆一丂丞:  0);
            }
            
            List.Enumerator<T> val_8 = this._contentViews.GetEnumerator();
            label_14:
            if(((-509478224) & 1) == 0)
            {
                goto label_12;
            }
            
            if(val_10.丐丏七丌丕丗业且上() != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(Rilisoft.AbstractGameEventGui.丏世且丞世丂丈丗东 < 1)
            {
                goto label_19;
            }
            
            List.Enumerator<T> val_16 = System.Linq.Enumerable.ToList<Rilisoft.与专丒丞丐一丒丂东>(source:  System.Linq.Enumerable.Cast<Rilisoft.与专丒丞丐一丒丂东>(source:  this.Context.丄三丐丟丗丄丟上丞())).GetEnumerator();
            label_24:
            if(((-509478248) & 1) == 0)
            {
                goto label_22;
            }
            
            val_26 = 0.丐丏七丌丕丗业且上();
            if(val_26.业上丙丞丐丄丆丅七() != Rilisoft.AbstractGameEventGui.丏世且丞世丂丈丗东)
            {
                goto label_24;
            }
            
            goto label_25;
            label_22:
            val_26 = 0;
            label_25:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_29;
            label_19:
            val_26 = 0;
            label_29:
            val_24 = this._mainView;
            Rilisoft.丛且世丐丆上七业丁 val_19 = this.Context;
            val_25 = this._buttonGoToEventHub;
            if(PGCompany.EventHub.丗且丅丕丒丑丞一丙.业丐万东丕丗一丘与() != false)
            {
                    val_27 = PGCompany.EventHub.丗且丅丕丒丑丞一丙.丅专丞丝专丐与丂一();
            }
            else
            {
                    val_27 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  false);
        }
        internal override void BackRequest()
        {
            Rilisoft.AbstractGameEventGui.丏世且丞世丂丈丗东 = 0;
            Rilisoft.GameEventGuiHandler.丝东丐丝东三丈世丝();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
            this.世下丕东七丆丆专三 = val_1;
            mem[1152921542752406956] = val_1.g;
            mem[1152921542752406960] = val_1.b;
            mem[1152921542752406964] = val_1.a;
            this._mainView.remove_OnVisibilityChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丏上上丛丟七丁下>(object:  this, method:  System.Void Rilisoft.GameEventGuiSets::丑丞不丈丆上不丆丏(Rilisoft.且丏上上丛丟七丁下 丏业丟一东丂东丘丛)));
            this._mainView.add_OnVisibilityChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丏上上丛丟七丁下>(object:  this, method:  System.Void Rilisoft.GameEventGuiSets::丑丞不丈丆上不丆丏(Rilisoft.且丏上上丛丟七丁下 丏业丟一东丂东丘丛)));
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        }
        private void 世与且业业丁专与丕()
        {
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        }
        private void 丑丞不丈丆上不丆丏(Rilisoft.且丏上上丛丟七丁下 丏业丟一东丂东丘丛)
        {
            if(丏业丟一东丂东丘丛 != 0)
            {
                    return;
            }
            
            if((this.<丌东丝万丏世七丗丌>k__BackingField) != 0)
            {
                    if(((this.<丌东丝万丏世七丗丌>k__BackingField) & 1) != 0)
            {
                    return;
            }
            
            }
        
        }
        private void 三专丝丘丅下丌丛丞(Rilisoft.且丏上上丛丟七丁下 丏业丟一东丂东丘丛)
        {
            if(丏业丟一东丂东丘丛 != 0)
            {
                    return;
            }
            
            if((this.<丌东丝万丏世七丗丌>k__BackingField) != 0)
            {
                    if((this.<丌东丝万丏世七丗丌>k__BackingField) != null)
            {
                    if((this.<丌东丝万丏世七丗丌>k__BackingField.丒世业三丘丝不下丕()) != false)
            {
                    string val_3 = this.<丌东丝万丏世七丗丌>k__BackingField.丅三专且丈一丝丂丏();
            }
            
            }
            
                this.<丌东丝万丏世七丗丌>k__BackingField = 0;
            }
            
            if(this._mainView == null)
            {
                
            }
        
        }
        public void U_Spin()
        {
            goto typeof(Rilisoft.GameEventGuiSets).__il2cppRuntimeField_278;
        }
        public override void Spin(int 下丅三丈世丐丕丌丑)
        {
            int val_43;
            Rilisoft.GameEventGuiSets val_44;
            var val_45;
            int val_46;
            var val_47;
            System.Action val_49;
            var val_50;
            var val_51;
            val_43 = 下丅三丈世丐丕丌丑;
            val_44 = this;
            GameEventGuiSets.丒丂万丒丂一上丞一 val_1 = new GameEventGuiSets.丒丂万丒丂一上丞一();
            if(val_1 != null)
            {
                    val_45 = val_1;
                .下丅三丈世丐丕丌丑 = val_43;
                mem[1152921542753346312] = val_44;
            }
            else
            {
                    val_45 = 16;
                mem[16] = val_43;
                mem[24] = val_44;
            }
            
            mem[16] = 1;
            if(this.Context == null)
            {
                    return;
            }
            
            val_43 = this.Context;
            if(val_43.且丌三丙丙与与丝世() == null)
            {
                    return;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_6 = this.Context.且丌三丙丙与与丝世();
            if(val_1 == null)
            {
                goto label_8;
            }
            
            .丏专丒丙丟且丈万七 = val_6;
            if(val_6 != null)
            {
                goto label_46;
            }
            
            label_47:
            label_46:
            if((System.String.op_Equality(a:  val_6.东与三丌丅三丒丏业(), b:  "EventCurrency")) != false)
            {
                    val_46 = .丏专丒丙丟且丈万七.丟丂丞不专丆万丒世();
                丈丞丕丘丕丗与上一 val_13 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_46, 丏丂不专上丘丂不丅:  Rilisoft.丛且世丐丆上七业丁.丕万丑且上七世丛不(丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七()));
                mem[1152921542753346328] = val_13;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_15 = this.Context.且丌三丙丙与与丝世();
            .丁丅丈丌丟世丗丗丟 = 0;
            if(this.Context != null)
            {
                    Rilisoft.GameEventType val_18 = this.Context.不业丙丒丂丞下丆丙();
                .丁丅丈丌丟世丗丗丟 = 0;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  mem[24]);
            System.Action val_20 = null;
            val_43 = val_20;
            val_20 = new System.Action(object:  val_1, method:  System.Void GameEventGuiSets.丒丂万丒丂一上丞一::丝丗丛丟三丛丏丟丄());
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_13.东与三丌丅三丒丏业())) == false)
            {
                goto label_24;
            }
            
            val_46 = 1152921505210572800;
            if((BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七())) >= val_13.丟丂丞不专丆万丒世())
            {
                goto label_29;
            }
            
            this.ShowBuyCurrencyGui(丏丂不专上丘丂不丅:  "EventCurrency");
            goto label_53;
            label_24:
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
            {
                    if(val_13.丟丂丞不专丆万丒世() >= 1)
            {
                    if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_13.与丒上与丄丒丝三七(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
            {
                goto label_37;
            }
            
            }
            
            }
            
            val_47 = null;
            val_47 = null;
            val_49 = GameEventGuiSets.<>c.<>9__26_1;
            if(val_49 == null)
            {
                    System.Action val_34 = null;
                val_49 = val_34;
                val_34 = new System.Action(object:  GameEventGuiSets.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventGuiSets.<>c::丒丆专丞七丞丙不丌());
                GameEventGuiSets.<>c.<>9__26_1 = val_49;
            }
            
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  this.gameObject, 丒世丘丘上丆丝东丞:  val_13, 七丒上且丝业业下七:  val_20, 丝丏丗丄丗与丐丌三:  val_34, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  83);
            goto label_53;
            label_8:
            mem[40] = val_6;
            if(mem[40] != 0)
            {
                goto label_46;
            }
            
            goto label_47;
            label_29:
            bool val_38 = BankController.上且丅专丟丄且丅上(丌丒丝东丌下丕丁丅:  -val_13.丟丂丞不专丆万丒世(), 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0, 丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七());
            val_20.Invoke();
            goto label_53;
            label_37:
            val_50 = null;
            val_50 = null;
            val_51 = null;
            val_51 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.三丄东丅丁不丒丐丑;
            val_43 = val_13.东与三丌丅三丒丏业();
            PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_43, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.三丄东丅丁不丒丐丑, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
            label_53:
            val_44 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_44.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public void DropNextItem()
        {
            if(this.Context.且丌三丙丙与与丝世() == null)
            {
                    return;
            }
            
            if(this.Context.且丌三丙丙与与丝世() == null)
            {
                    return;
            }
        
        }
        internal void 丑丈且与丈上丑丂世(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七)
        {
            Rilisoft.GameEventItem val_14;
            Rilisoft.GameEventGuiSets val_15;
            val_14 = 下丅丙一丂丗丅丝七;
            val_15 = this;
            GameEventGuiSets.丐丐七丈丅丐三且丆 val_1 = new GameEventGuiSets.丐丐七丈丅丐三且丆();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .下丅丙一丂丗丅丝七 = val_14;
            .丝且与丝丒丟万丁专 = val_15;
            if(val_14 != null)
            {
                goto label_2;
            }
            
            return;
            label_1:
            mem[16] = val_14;
            mem[24] = val_15;
            val_14 = mem[16];
            if(val_14 == 0)
            {
                    return;
            }
            
            label_2:
            val_14 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  this.Context.丄三丐丟丗丄丟上丞(), predicate:  new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  val_1, method:  System.Boolean GameEventGuiSets.丐丐七丈丅丐三且丆::三不丈丂七上且丗丅(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)));
            if(val_14 == null)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_14, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  val_1, method:  System.Boolean GameEventGuiSets.丐丐七丈丅丐三且丆::上丂丑下丞丙丈七丑(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)))) == null)
            {
                    return;
            }
            
            int val_8 = val_14.丟丂丞不专丆万丒世();
            if(val_1 != null)
            {
                    .丏专丒丙丟且丈万七 = val_8;
            }
            else
            {
                    mem[40] = val_8;
            }
            
            .丁丅丈丌丟世丗丗丟 = 0;
            if(this.Context != null)
            {
                    Rilisoft.GameEventType val_11 = this.Context.不业丙丒丂丞下丆丙();
                .丁丅丈丌丟世丗丗丟 = 0;
            }
            
            val_15 = this.gameObject;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  val_15, 丒世丘丘上丆丝东丞:  val_14, 七丒上且丝业业下七:  new System.Action(object:  val_1, method:  System.Void GameEventGuiSets.丐丐七丈丅丐三且丆::与丅丝丂丗丝东世丌()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  84);
        }
        private void 丘且下丌丏下丈丘丄(System.Collections.Generic.List<Rilisoft.DroppedItemData> 丘上丏丟一一丝上丙)
        {
            object val_17;
            System.Object[] val_23;
            int val_24;
            int val_25;
            var val_26;
            int val_27;
            var val_29;
            val_23 = 丘上丏丟一一丝上丙;
            new GameEventGuiSets.世丘丛上丞丆丟丟丐() = new System.Object();
            if(val_23 == null)
            {
                    return;
            }
            
            if(val_23.Count == 0)
            {
                    return;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_4 = val_23.Item[0].丌丐东业专丑丘丑丗();
            if(val_4 == null)
            {
                goto label_4;
            }
            
            Rilisoft.DroppedItemData val_5 = val_23.Item[0];
            val_24 = val_5.ChestId;
            if(new GameEventGuiSets.世丘丛上丞丆丟丟丐() == null)
            {
                goto label_6;
            }
            
            val_25 = new GameEventGuiSets.世丘丛上丞丆丟丟丐();
            .丐东业丕丕丂丗丅丙 = val_24;
            goto label_7;
            label_4:
            UnityEngine.Debug.LogError(message:  "saved event is null");
            return;
            label_6:
            mem[16] = val_24;
            val_25 = 16;
            val_24 = mem[16];
            label_7:
            if(val_24 <= 0)
            {
                goto label_11;
            }
            
            System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean> val_7 = new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  new GameEventGuiSets.世丘丛上丞丆丟丟丐(), method:  System.Boolean GameEventGuiSets.世丘丛上丞丆丟丟丐::业业丘丂丕丞丑丝世(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙));
            Rilisoft.上专业三丟丁丞专下 val_8 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  val_4.丄三丐丟丗丄丟上丞(), predicate:  null);
            if(val_8 == null)
            {
                goto label_12;
            }
            
            object[] val_9 = new object[1];
            val_23 = val_9;
            val_23[0] = val_8.GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "incnown chest type: \'{0}\'", args:  val_9);
            return;
            label_11:
            UnityEngine.Debug.LogError(message:  "chest id not setted");
            return;
            label_12:
            object[] val_11 = new object[1];
            val_23 = val_11;
            val_23[0] = val_25;
            UnityEngine.Debug.LogErrorFormat(format:  "chest with id: \'{0}\' not found", args:  val_11);
            return;
            label_35:
            if(((-507553504) & 1) == 0)
            {
                goto label_33;
            }
            
            string val_14 = val_25.丐丏七丌丕丗业且上();
            val_8.丕且专一三不世东丈(丒丁东世世丗丅丅丄:  val_14.m_firstChar);
            goto label_35;
            label_33:
            val_26 = 0;
            val_27 = 0;
            val_29 = public System.Void List.Enumerator<Rilisoft.DroppedItemData>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (259 == 259))
            {
                    val_26 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_29 = 0;
                val_27 = 0;
            }
            
            }
            
            List.Enumerator<T> val_15 = val_23.GetEnumerator();
            label_69:
            if(((-507553504) & 1) == 0)
            {
                goto label_62;
            }
            
            if(val_17.丐丏七丌丕丗业且上().丘丗下业东世万丂专() == null)
            {
                goto label_69;
            }
            
            Rilisoft.一丟专且三万丞丁丂.下丗与丆下且丁丁丟(业丈丁丂丟业丏七不:  val_8.业上丙丞丐丄丆丅七(), 丞一丁业丄一一业且:  val_19._data.Id, 丌丒丝东丌下丕丁丅:  val_19._data.Count);
            goto label_69;
            label_62:
            mem2[0] = 353;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((0 + 1) != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if((1152921542753999040 + ((0 + 1)) << 2) != 353)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private Rilisoft.GameEventSetsViewBase 东丟丌丞专丆与丑丆(string 丐丛万丆东世丐上三)
        {
            UnityEngine.Object val_17;
            .丐丛万丆东世丐上三 = 丐丛万丆东世丐上三;
            val_17 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventSetsViewBase>(source:  this._contentViews, predicate:  new System.Func<Rilisoft.GameEventSetsViewBase, System.Boolean>(object:  new GameEventGuiSets.三丕业丁丗东丂七丝(), method:  System.Boolean GameEventGuiSets.三丕业丁丗东丂七丝::丈丒丁丏丟七上丕丛(Rilisoft.GameEventSetsViewBase 业下丌下三丕丙丌下)));
            if(val_17 != 0)
            {
                    return (Rilisoft.GameEventSetsViewBase)val_17;
            }
            
            if(this.Context != null)
            {
                    if(this.Context.且丌三丙丙与与丝世() != null)
            {
                    Rilisoft.上专业三丟丁丞专下 val_9 = this.Context.且丌三丙丙与与丝世();
            }
            
            }
            
            val_17 = 0;
            return (Rilisoft.GameEventSetsViewBase)val_17;
        }
        public void ShowSelectedChestContext()
        {
            var val_22;
            string val_23;
            var val_24;
            val_22 = this.Context.且丌三丙丙与与丝世();
            val_22 = 0;
            Rilisoft.GameEventChestData val_3 = val_22.丁专丗万三上丟三丆();
            val_23 = val_3.ViewType;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_23)) == true)
            {
                    return;
            }
            
            Rilisoft.GameEventChestData val_5 = val_22.丁专丗万三上丟三丆();
            val_23 = this.东丟丌丞专丆与丑丆(丐丛万丆东世丐上三:  val_5.ViewType);
            if(val_23 == 0)
            {
                    return;
            }
            
            this.<丌东丝万丏世七丗丌>k__BackingField = val_23;
            Rilisoft.丛且世丐丆上七业丁 val_8 = this.Context;
            val_23 = this.<丌东丝万丏世七丗丌>k__BackingField;
            if(val_22.丄丌万丘与专丝业丗() == true)
            {
                    return;
            }
            
            if((1 & 1) != 0)
            {
                    val_24 = 1;
                val_22.丝丑一三上东丁万丗(丙业与丙丗丝不丈东:  true);
            }
            else
            {
                    val_24 = 1;
                val_22.丝丑一三上东丁万丗(丙业与丙丗丝不丈东:  true);
            }
        
        }
        public void ShowSelectedChestBindedItemInShop(bool 三下丞一业丄世不上 = True)
        {
            var val_6;
            System.Collections.Generic.List<Rilisoft.GameEventSetsViewBase> val_7;
            var val_8;
            System.Action<Rilisoft.GameEventSetsViewBase> val_10;
            val_6 = 三下丞一业丄世不上;
            val_7 = this;
            var val_6 = this.Context;
            Rilisoft.上专业三丟丁丞专下 val_2 = val_6.且丌三丙丙与与丝世();
            if(val_2 == null)
            {
                    return;
            }
            
            val_6 = (((Rilisoft.上专业三丟丁丞专下.__il2cppRuntimeField_typeHierarchy + (Rilisoft.与专丒丞丐一丒丂东.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            val_7 = this._contentViews;
            val_8 = null;
            val_8 = null;
            val_10 = GameEventGuiSets.<>c.<>9__32_0;
            if(val_10 == null)
            {
                    val_10 = null;
                val_10 = new System.Action<Rilisoft.GameEventSetsViewBase>(object:  GameEventGuiSets.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventGuiSets.<>c::上丐丌丟丆丌业丙专(Rilisoft.GameEventSetsViewBase 丁世丛业丟下丕三丟));
                GameEventGuiSets.<>c.<>9__32_0 = val_10;
            }
            
            val_7.ForEach(action:  null);
            Rilisoft.GameEventGuiHandler.丆三丘丅且东万与丘();
            if(val_6 != false)
            {
                    val_6 = PGCompany.TransitionController.丑七不且上丗丁一世();
                val_6.丗丁丏一专丁七丝丞();
            }
            
            string val_5 = val_6.丅三专且丈一丝丂丏();
            val_5.上丈丗专丝丑丝丐丟(丞一丁业丄一一业且:  val_5);
        }
        public void U_ShowSelectedChestContext()
        {
            this.ShowSelectedChestContext();
        }
        public void U_ShowSelectedChestBindedItemInShop()
        {
            this.ShowSelectedChestBindedItemInShop(三下丞一业丄世不上:  false);
        }
        public void U_ShowPartsShop()
        {
            var val_21;
            if(this.Context == null)
            {
                    return;
            }
            
            if(this.Context.且丌三丙丙与与丝世() == null)
            {
                    return;
            }
            
            var val_21 = this.Context;
            Rilisoft.上专业三丟丁丞专下 val_5 = val_21.且丌三丙丙与与丝世();
            if(val_5 == null)
            {
                    return;
            }
            
            val_21 = (((Rilisoft.上专业三丟丁丞专下.__il2cppRuntimeField_typeHierarchy + (Rilisoft.与专丒丞丐一丒丂东.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_5) : 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_21.丅三专且丈一丝丂丏())) != false)
            {
                    return;
            }
            
            val_21 = null;
            val_21 = null;
            bool val_20 = Rilisoft.BuyCraftDetailsWindow.下与丞三丅丛丄七丕(一丟丄丞不丕丟丌丟:  this._buyDetailsPlacePoint, 丕丁下丌不万丅丞丛:  val_21.丅三专且丈一丝丂丏(), 丕丌专世丌丂上丒丆:  BalanceController.丕丙丛且丏三上不丛(丆万一不丌且东丐丐:  val_21.丅三专且丈一丝丂丏(), 万业丁七与丟丁东与:  false), 与丄不丌一世东丁丙:  1, 下丗丁丒丘东丂不丑:  ((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  val_21.丅三专且丈一丝丂丏())) != true) ? 2 : ((((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_21.丅三专且丈一丝丂丏())) | (丙丞丟丑丗丅专丈一.上三丕上与丒丈下下(丒东业不丐丑丕丄丆:  val_21.丅三专且丈一丝丂丏()))) != true) ? 3 : 0));
        }
        internal static void 丏且一丞丛丐丘丒且(Rilisoft.GameEventType 且下丕七丙丗丄不七, 丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 七丆丒与丗丌丄且丂, FilterMaps 专丆丌丛东一不丑丙, bool 丈世丅不业丞业丁丐 = True)
        {
            var val_15;
            丙且上东下丏丏丟下 val_22;
            var val_23;
            var val_24;
            var val_25;
            string val_26;
            var val_27;
            System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_29;
            var val_30;
            val_22 = 丑丝丏丂且不下一东;
            .且下丕七丙丗丄不七 = 且下丕七丙丗丄不七;
            System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_4 = null;
            val_23 = 1152921538020187824;
            val_4 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  new GameEventGuiSets.且且丛丌丝三丏丙丛(), method:  System.Boolean GameEventGuiSets.且且丛丌丝三丏丙丛::丆丘丒丁丑上丛业世(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
            val_24 = 1152921538020188848;
            val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与不下且且丅东丘世(), predicate:  val_4);
            if(val_25 == null)
            {
                goto label_5;
            }
            
            label_16:
            val_26 = val_25.业上丙丞丐丄丆丅七();
            goto label_6;
            label_5:
            if((GameEventGuiSets.且且丛丌丝三丏丙丛)[1152921542755416320].且下丕七丙丗丄不七 != 200)
            {
                goto label_7;
            }
            
            val_27 = null;
            val_27 = null;
            val_29 = GameEventGuiSets.<>c.<>9__36_1;
            if(val_29 == null)
            {
                    System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean> val_9 = null;
                val_29 = val_9;
                val_9 = new System.Func<Rilisoft.丛且世丐丆上七业丁, System.Boolean>(object:  GameEventGuiSets.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameEventGuiSets.<>c::丕丏丈万与丞一丙一(Rilisoft.丛且世丐丆上七业丁 丗丛不丁丑专专丂且));
                GameEventGuiSets.<>c.<>9__36_1 = val_29;
            }
            
            val_25 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丛且世丐丆上七业丁>(source:  Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与不下且且丅东丘世(), predicate:  val_9);
            if(val_25 != null)
            {
                goto label_16;
            }
            
            goto label_17;
            label_7:
            val_25 = 0;
            label_17:
            val_26 = 0;
            label_6:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_26)) == true)
            {
                    return;
            }
            
            if(val_22 == null)
            {
                goto label_35;
            }
            
            List.Enumerator<T> val_13 = val_25.丄三丐丟丗丄丟上丞().GetEnumerator();
            val_24 = 1152921540871087376;
            val_23 = 1152921505459453952;
            label_28:
            if(((-506196832) & 1) == 0)
            {
                goto label_24;
            }
            
            string val_16 = val_15.丐丏七丌丕丗业且上();
            if((val_16 == null) || ((System.String.op_Equality(a:  val_16.丅三专且丈一丝丂丏(), b:  val_22.业上丙丞丐丄丆丅七())) == false))
            {
                goto label_28;
            }
            
            Rilisoft.AbstractGameEventGui.丏世且丞世丂丈丗东 = val_16.业上丙丞丐丄丆丅七();
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_35:
            val_25 = 1152921505261211648;
            val_30 = null;
            val_30 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
            {
                    val_30 = null;
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丁七丁丞丞丟丒业丅 = val_22;
            val_22 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            if(val_22 == null)
            {
                    val_30 = null;
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丌不丒万万丟丞上与 = 七丆丒与丗丌丄且丂;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丕丏丑丏丏丂与东丏 = 专丆丌丛东一不丑丙;
            Rilisoft.GameEventGuiHandler.丞丙丗丁丙丏七专丑(丟丟丄专上丟丁丐丝:  val_26, 业万与下且万丕丈丑:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, 丈丈不丒丗与丝不丗:  false);
        }
        private void 上丈丗专丝丑丝丐丟(string 丞一丁业丄一一业且)
        {
            MainMenuController val_17;
            var val_18;
            var val_19;
            string val_20;
            var val_21;
            var val_22;
            GameEventGuiSets.丟丑不七不丆业丐丛 val_1 = null;
            val_17 = val_1;
            val_1 = new GameEventGuiSets.丟丑不七不丆业丐丛();
            .丞一丁业丄一一业且 = 丞一丁业丄一一业且;
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            val_18 = null;
            val_18 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui.丙丛东世东丌业一丝();
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  (GameEventGuiSets.丟丑不七不丆业丐丛)[1152921542755660416].丞一丁业丄一一业且)) != false)
            {
                    val_19 = null;
                val_19 = null;
                val_20 = (GameEventGuiSets.丟丑不七不丆业丐丛)[1152921542755660416].丞一丁业丄一一业且;
                val_17 = MainMenuController.丄丞丁丈与业上丞丟;
                new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_20, 七丆丒与丗丌丄且丂:  48);
                val_17.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  new 丙且上东下丏丏丟下(), 一专七丟丏且丑丄下:  8, 丝丗丙丞丙丕万业下:  0, 万且丟七不上丗丑丝:  false);
                return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  (GameEventGuiSets.丟丑不七不丆业丐丛)[1152921542755660416].丞一丁业丄一一业且)) != false)
            {
                    val_21 = 0;
            }
            else
            {
                    val_21 = 丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  (GameEventGuiSets.丟丑不七不丆业丐丛)[1152921542755660416].丞一丁业丄一一业且);
            }
            
            System.Func<丛且专丞丗丆丙丒万, System.Boolean> val_10 = new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  val_1, method:  System.Boolean GameEventGuiSets.丟丑不七不丆业丐丛::丏丐一与且丒下不丘(丛且专丞丗丆丙丒万 万丗丅七丘丗与丈丑));
            丛且专丞丗丆丙丒万 val_11 = System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  null);
            if(val_21 != false)
            {
                    val_17 = new 丙且上东下丏丏丟下();
                val_17 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_11.下丄丈不与世丐业专, 七丆丒与丗丌丄且丂:  224);
            }
            else
            {
                    val_17 = new 丙且上东下丏丏丟下();
                val_17 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  (GameEventGuiSets.丟丑不七不丆业丐丛)[1152921542755660416].丞一丁业丄一一业且, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  (GameEventGuiSets.丟丑不七不丆业丐丛)[1152921542755660416].丞一丁业丄一一业且));
            }
            
            val_22 = null;
            val_22 = null;
            val_20 = MainMenuController.丄丞丁丈与业上丞丟;
            val_20.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  new 丙且上东下丏丏丟下(), 一专七丟丏且丑丄下:  (val_21 == false) ? 135000 : 140000, 丝丗丙丞丙丕万业下:  0, 万且丟七不上丗丑丝:  false);
        }
        internal override void 不一丒丁丗上丗上世(object 丙丈下丕丑专上丕丛)
        {
            if((this.<丌东丝万丏世七丗丌>k__BackingField) == 0)
            {
                    return;
            }
            
            if(丙丈下丕丑专上丕丛 == null)
            {
                    return;
            }
            
            var val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.GameEventItem.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丙丈下丕丑专上丕丛 : 0;
        }
        public void U_GoToEventHub()
        {
            PGCompany.丌不丞丐世丞三丘丌 val_1 = new PGCompany.丌不丞丐世丞三丘丌();
            if(val_1 != null)
            {
                    .Type = 21;
            }
            else
            {
                    mem[16] = 21;
            }
            
            .丄世丌东丏三东丒丂 = 2;
            if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_1)) == null)
            {
                    return;
            }
            
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        internal void 世丟丝与丏丆且丄丌()
        {
            var val_2 = this;
            if(this._mainView == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            (null == null) ? this._mainView : 0.丘丟万丌丄三丏丈业();
        }
        public GameEventGuiSets()
        {
            this._contentViews = new System.Collections.Generic.List<Rilisoft.GameEventSetsViewBase>();
        }
    
    }

}
