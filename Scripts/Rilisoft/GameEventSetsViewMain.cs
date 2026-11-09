using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventSetsViewMain : GameEventSetsViewBase, 一丆丌丕丆丄专丞丄
    {
        // Fields
        private System.Collections.Generic.List<EventWinterButton> _chestButtons;
        private UITable _chestButtonsTable;
        private PropertiesArmoryItemContainer _propertiesArmoryItemContainer;
        private UnityEngine.GameObject _avatarDescription;
        private System.Collections.Generic.List<UILabel> _itemNamesLabels;
        private System.Collections.Generic.List<UILabel> _itemRarityLabels;
        private UILabel[] _eventNameLabels;
        private UIButton _getPrizesButton;
        private UIButton _toShopButton;
        private UILabel[] _toShopLabels;
        private Rilisoft.CharactersCorousel _charactersCorousel;
        private Rilisoft.FogSettings _fogSettings;
        private Rilisoft.GameEventSetsCollectedView _collectedView;
        private UIViewport _3dCameraViewport;
        private UILabel[] _setBonusLabels;
        private UnityEngine.GameObject _combatLevelContainer;
        private UILabel _combatLevelLabel;
        private UnityEngine.GameObject _spinButtonNotif;
        private Rilisoft.FogSettings 下丟七丟丄且一丘万;
        private Rilisoft.WindowAnimator 丞业丆丛业丟一丛东;
        private UnityEngine.Color 丕丙丙丂丌专丕丆下;
        private UnityEngine.Light 三丛上一世上丞业丗;
        private float 丒丅丑丟丙丕丛丗丌;
        private UnityEngine.Coroutine 不且一三丁下丐丁世;
        private UnityEngine.Color 丗丅三七且丅丑与丂;
        
        // Properties
        internal PropertiesArmoryItemContainer 丟丟七丒丒世七七丆 { get; }
        internal override string 丄丂丏世丛丏万三丆 { get; }
        public override Rilisoft.与专丒丞丐一丒丂东 丌且丝丘丌丕东丒与 { get; set; }
        private Rilisoft.FogSettings 且一与不丄丂丁丑丕 { get; }
        private UnityEngine.Color 东专丂万丟丞丈丙与 { get; }
        
        // Methods
        internal PropertiesArmoryItemContainer 丌丁业不丄丅且丏丘()
        {
            return (PropertiesArmoryItemContainer)this._propertiesArmoryItemContainer;
        }
        internal override string 丌三不七丌丗丞丌专()
        {
            return "main";
        }
        public override Rilisoft.与专丒丞丐一丒丂东 get_Parameter()
        {
            return this.Parameter;
        }
        public override void set_Parameter(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.Parameter = 丙业与丙丗丝不丈东;
            this.Context.不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  this.Parameter);
        }
        public void AnimationStarting(Rilisoft.WindowAnimator 丁万七业一丞丝世丛)
        {
            this.丞业丆丛业丟一丛东 = 丁万七业一丞丝世丛;
            if(丁万七业一丞丝世丛.Direction != 0)
            {
                    return;
            }
            
            this.下丟七丟丄且一丘万 = Rilisoft.FogSettings.且且丘丆三下丂丗下();
            UnityEngine.Color val_3 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
            this.丕丙丙丂丌专丕丆下 = val_3;
            mem[1152921542816300548] = val_3.g;
            mem[1152921542816300552] = val_3.b;
            mem[1152921542816300556] = val_3.a;
            UnityEngine.Light val_4 = this._3dCameraViewport.GetComponentInChildren<UnityEngine.Light>();
            this.三丛上一世上丞业丗 = val_4;
            if(val_4 == 0)
            {
                    return;
            }
            
            if(this.丒丅丑丟丙丕丛丗丌 < 0)
            {
                    this.丒丅丑丟丙丕丛丗丌 = this.三丛上一世上丞业丗.intensity;
            }
            
            this.三丛上一世上丞业丗.intensity = 0f;
        }
        public void AnimationStopped()
        {
            var val_8;
            if(this.丞业丆丛业丟一丛东 == 0)
            {
                goto label_3;
            }
            
            val_8 = 0;
            if(this.丞业丆丛业丟一丛东.Direction == 0)
            {
                goto label_5;
            }
            
            label_3:
            if(this.下丟七丟丄且一丘万 != null)
            {
                    this.下丟七丟丄且一丘万.丙丗丒七丆丟丅七丑();
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
            {
                    return;
            }
            
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丕丙丙丂丌专丕丆下});
            return;
            label_5:
            if(this.专丑三万丗丁丆丘万() != null)
            {
                    val_8 = 0;
                this.专丑三万丗丁丆丘万().丙丗丒七丆丟丅七丑();
            }
            
            this._chestButtonsTable.repositionNow = true;
            if(this.不且一三丁下丐丁世 != null)
            {
                    this.不且一三丁下丐丁世 = 0;
            }
            
            this.不且一三丁下丐丁世 = this.StartCoroutine(routine:  this.七丗专不上丘万丁丆());
        }
        private System.Collections.IEnumerator 七丗专不上丘万丁丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventSetsViewMain.丌一丂丆万上与丟丗();
        }
        protected override void OnEnable()
        {
            UnityEngine.Object val_10;
            this._charactersCorousel.add_OnDragStopped(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丁丘不七东业丂丞丙(int 丘丒丌下丕专且七专)));
            this.OnEnable();
            val_10 = 0;
            if(this.丞业丆丛业丟一丛东 != val_10)
            {
                goto label_4;
            }
            
            label_12:
            if(this.专丑三万丗丁丆丘万() != null)
            {
                    if(this.下丟七丟丄且一丘万 == null)
            {
                    this.下丟七丟丄且一丘万 = Rilisoft.FogSettings.且且丘丆三下丂丗下();
            }
            
                val_10 = 0;
                this.专丑三万丗丁丆丘万().丙丗丒七丆丟丅七丑();
            }
            
            UnityEngine.Color val_6 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
            this.丕丙丙丂丌专丕丆下 = val_6;
            mem[1152921542816813700] = val_6.g;
            mem[1152921542816813704] = val_6.b;
            mem[1152921542816813708] = val_6.a;
            goto label_10;
            label_4:
            val_10 = 0;
            if(this.丞业丆丛业丟一丛东.AnimationPlaying == true)
            {
                goto label_10;
            }
            
            val_10 = 0;
            if(this.丞业丆丛业丟一丛东.Direction == 0)
            {
                goto label_12;
            }
            
            label_10:
            UnityEngine.Color val_9 = this.丝丁丆丁丑丈下万与();
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
            this._chestButtonsTable.repositionNow = true;
        }
        protected override void OnDisable()
        {
            if(this.下丟七丟丄且一丘万 != null)
            {
                    this.下丟七丟丄且一丘万.丙丗丒七丆丟丅七丑();
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
            {
                    PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丕丙丙丂丌专丕丆下});
            }
            
            this._charactersCorousel.remove_OnDragStopped(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丁丘不七东业丂丞丙(int 丘丒丌下丕专且七专)));
            if(this.丞业丆丛业丟一丛东 == 0)
            {
                    if(this.下丟七丟丄且一丘万 != null)
            {
                    this.下丟七丟丄且一丘万.丙丗丒七丆丟丅七丑();
            }
            
                if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
            {
                    PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丕丙丙丂丌专丕丆下});
            }
            
            }
            
            this.OnDisable();
        }
        public override void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            var val_11;
            Rilisoft.丛且世丐丆上七业丁 val_38;
            object val_39;
            System.Action val_40;
            var val_41;
            System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Int32> val_43;
            var val_44;
            val_38 = 丅东专与不三丂丁丝;
            val_39 = this;
            if(this.Context != null)
            {
                    System.Action val_3 = null;
                val_40 = val_3;
                val_3 = new System.Action(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丙东三丒业丁世一万());
                this.Context.丘世不丌业丞丄与丝(丙业与丙丗丝不丈东:  val_3);
            }
            
            this.Setup(丅东专与不三丂丁丝:  val_38, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆);
            if(this.Context == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<Rilisoft.与专丒丞丐一丒丂东>(source:  System.Linq.Enumerable.Cast<Rilisoft.与专丒丞丐一丒丂东>(source:  this.Context.丄三丐丟丗丄丟上丞()));
            if(this != null)
            {
                goto label_5;
            }
            
            List.Enumerator<T> val_9 = val_8.GetEnumerator();
            val_40 = 1152921542752038960;
            label_12:
            if(((-444319440) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            if(((val_12 == null) || (val_12.丒世业三丘丝不下丕() == false)) || ((丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  val_12.丅三专且丈一丝丂丏())) == true))
            {
                goto label_12;
            }
            
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this != null)
            {
                goto label_36;
            }
            
            List.Enumerator<T> val_16 = val_8.GetEnumerator();
            label_28:
            if(((-444319440) & 1) == 0)
            {
                goto label_22;
            }
            
            string val_17 = val_11.丐丏七丌丕丗业且上();
            if(((val_17 == null) || (val_17.丟丂丞不专丆万丒世() > 0)) || ((丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  val_17.丅三专且丈一丝丂丏())) == true))
            {
                goto label_28;
            }
            
            label_22:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_36:
            if(this == null)
            {
                    val_39 = new System.Object();
                val_41 = null;
                val_41 = null;
                val_43 = GameEventSetsViewMain.<>c.<>9__36_0;
                if(val_43 == null)
            {
                    System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Int32> val_22 = null;
                val_43 = val_22;
                val_22 = new System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Int32>(object:  GameEventSetsViewMain.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GameEventSetsViewMain.<>c::万丝万下丟丈业丙丄(Rilisoft.与专丒丞丐一丒丂东 丁丂专业丁丅丅丈丙));
                GameEventSetsViewMain.<>c.<>9__36_0 = val_43;
            }
            
                mem[1152921542817245328] = System.Linq.Enumerable.Min<Rilisoft.与专丒丞丐一丒丂东>(source:  val_8, selector:  val_22);
                Rilisoft.与专丒丞丐一丒丂东 val_25 = System.Linq.Enumerable.First<Rilisoft.与专丒丞丐一丒丂东>(source:  val_8, predicate:  new System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Boolean>(object:  this, method:  System.Boolean GameEventSetsViewMain.且且丛丌丝三丏丙丛::一丄业丐丄丒下丏丞(Rilisoft.与专丒丞丐一丒丂东 丁丂专业丁丅丅丈丙)));
            }
            
            this.丈丁丏丟丁丗丅丆丈(丐下丝丘丑丟丟丗丌:  this, 丒丑丟专丒丄七丂丒:  true, 丒上丗三丆一一业丞:  true);
            label_5:
            this.丘丟万丌丄三丏丈业();
            this.Context.丅不丐一丗丐丞丟丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丙东三丒业丁世一万()));
            this._charactersCorousel.Setup(专丁丘三丂丝丅不丐:  this.Context.丄三丐丟丗丄丟上丞().Count, 与业丞东丙丕且丏丈:  0);
            val_44 = 0;
            goto label_48;
            label_53:
            val_40 = this._charactersCorousel.GetItem(世万专丛与丐丌专不:  0);
            val_40.Setup(与且专丈不万东一万:  this.Context, 丆且丁丒丒丆丁三丆:  val_8.Item[0]);
            val_44 = 1;
            label_48:
            if(val_44 < val_8.Count)
            {
                goto label_53;
            }
            
            val_38 = this._charactersCorousel;
            if((val_8.Contains(item:  this)) == false)
            {
                goto label_55;
            }
            
            val_39 = val_8.IndexOf(item:  this);
            if(val_38 != null)
            {
                goto label_59;
            }
            
            goto label_58;
            label_55:
            val_39 = 0;
            if(val_38 != null)
            {
                goto label_59;
            }
            
            label_58:
            label_59:
            val_38.RotateTo(丂专丏丐且丁世丏丙:  0);
        }
        protected override void 丝东丐丝东三丈世丝()
        {
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() != 0)
            {
                    Rilisoft.AbstractGameEventGui val_3 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            }
            
            this.丝东丐丝东三丈世丝();
        }
        protected override void Update()
        {
            this.Update();
            if(this.丞业丆丛业丟一丛东 == 0)
            {
                    return;
            }
            
            if(this.丞业丆丛业丟一丛东.AnimationPlaying == false)
            {
                    return;
            }
            
            this._chestButtonsTable.repositionNow = true;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            if(this.Context == null)
            {
                    return;
            }
            
            this.Context.丘世不丌业丞丄与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丙东三丒业丁世一万()));
        }
        public override void ShowWindow()
        {
            this.ShowWindow();
            this._3dCameraViewport.enabled = true;
            this.丘丟万丌丄三丏丈业();
            this._charactersCorousel.Visible = true;
        }
        public override void HideWindow()
        {
            this.HideWindow();
            this._3dCameraViewport.enabled = false;
            this.Context.丘世不丌业丞丄与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丙东三丒业丁世一万()));
            List.Enumerator<T> val_3 = this._chestButtons.GetEnumerator();
            label_9:
            if(((-443523928) & 1) == 0)
            {
                goto label_4;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(val_4 == 0)
            {
                goto label_9;
            }
            
            System.Action<RadioButton, System.Boolean> val_6 = new System.Action<RadioButton, System.Boolean>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丌丑丌丑丗丈丌丕与(RadioButton 丟丒丞丐丐丘丒丄东, bool 丞丈丌且东丆丅丗万));
            val_4.remove_OnSelectedStateChanged(丙业与丙丗丝不丈东:  null);
            goto label_9;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this._charactersCorousel.Visible = false;
        }
        private void 丙东三丒业丁世一万()
        {
            this.丘丟万丌丄三丏丈业();
        }
        internal void 丘丟万丌丄三丏丈业()
        {
            var val_13;
            if(this.Context == null)
            {
                    return;
            }
            
            if(this != null)
            {
                    bool val_4 = this.Context.丄三丐丟丗丄丟上丞().Contains(item:  this);
            }
            
            this.丙丝丗丕丐丟丛丞七();
            if(this._eventNameLabels != null)
            {
                    .丝丏业丅丈东业丝丒 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.Context.丑丐丏丌丑下一丑丒());
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._eventNameLabels, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new GameEventSetsViewMain.丆世丒一丈专丆丆七(), method:  System.Void GameEventSetsViewMain.丆世丒一丈专丆丆七::与丞丕业丂业业三七(UILabel 丐三丞七丝丅不万丛)));
            }
            
            this._collectedView.Setup(与且专丈不万东一万:  this.Context);
            if(this._spinButtonNotif == 0)
            {
                    return;
            }
            
            if(this != null)
            {
                    val_13 = this.丐七丒丏下上丂丁丗();
            }
            else
            {
                    val_13 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._spinButtonNotif, 丏业丟一东丂东丘丛:  val_13 & 1);
        }
        private void 丙丝丗丕丐丟丛丞七()
        {
            var val_3;
            System.Collections.Generic.List<EventWinterButton> val_39;
            var val_40;
            var val_41;
            var val_42;
            int val_43;
            List.Enumerator<T> val_1 = this._chestButtons.GetEnumerator();
            val_39 = 1152921542818000448;
            label_8:
            if(((-442803936) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4 == 0)
            {
                goto label_8;
            }
            
            System.Action<RadioButton, System.Boolean> val_6 = new System.Action<RadioButton, System.Boolean>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丌丑丌丑丗丈丌丕与(RadioButton 丟丒丞丐丐丘丒丄东, bool 丞丈丌且东丆丅丗万));
            val_4.remove_OnSelectedStateChanged(丙业与丙丗丝不丈东:  null);
            System.Action<RadioButton, System.Boolean> val_7 = new System.Action<RadioButton, System.Boolean>(object:  this, method:  System.Void Rilisoft.GameEventSetsViewMain::丌丑丌丑丗丈丌丕与(RadioButton 丟丒丞丐丐丘丒丄东, bool 丞丈丌且东丆丅丗万));
            val_4.add_OnSelectedStateChanged(丙业与丙丗丝不丈东:  null);
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this != null)
            {
                    int val_10 = this.Context.丄三丐丟丗丄丟上丞().IndexOf(item:  this);
            }
            
            val_40 = 0;
            goto label_21;
            label_47:
            Rilisoft.上专业三丟丁丞专下 val_13 = this.Context.丄三丐丟丗丄丟上丞().Item[0];
            val_39 = this._chestButtons;
            if(val_40 > (val_39.Count - 1))
            {
                goto label_43;
            }
            
            val_39 = this._chestButtons.Item[0];
            if((val_39 == 0) || (val_39.gameObject == 0))
            {
                goto label_43;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_39.gameObject, 丏业丟一东丂东丘丛:  true);
            if(val_39 == null)
            {
                goto label_37;
            }
            
            if(val_13 != null)
            {
                goto label_38;
            }
            
            goto label_40;
            label_37:
            if(val_13 == null)
            {
                goto label_40;
            }
            
            label_38:
            label_40:
            val_41 = 0;
            val_39.Setup(丐下丝丘丑丟丟丗丌:  null);
            if((0 & 2147483648) == 0)
            {
                    val_39.state = (0 == val_40) ? 1 : 0;
            }
            
            label_43:
            val_40 = 1;
            label_21:
            if(val_40 < this.Context.丄三丐丟丗丄丟上丞().Count)
            {
                goto label_47;
            }
            
            val_42 = this.Context.丄三丐丟丗丄丟上丞();
            if(this._chestButtons.Count <= val_42.Count)
            {
                    return;
            }
            
            val_43 = this._chestButtons.Count;
            goto label_61;
            label_67:
            val_43 = val_43 - 1;
            EventWinterButton val_31 = this._chestButtons.Item[val_43];
            if(val_31 != 0)
            {
                    if(val_31.gameObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            label_61:
            val_42 = this.Context.丄三丐丟丗丄丟上丞();
            if(val_43 > val_42.Count)
            {
                goto label_67;
            }
        
        }
        private void 丌丑丌丑丗丈丌丕与(RadioButton 丟丒丞丐丐丘丒丄东, bool 丞丈丌且东丆丅丗万)
        {
            RadioButton val_5 = 丟丒丞丐丐丘丒丄东;
            if(val_5 == 0)
            {
                    return;
            }
            
            if(丞丈丌且东丆丅丗万 == false)
            {
                    return;
            }
            
            if(val_5 != null)
            {
                    val_5 = 0;
            }
            
            if( == 0)
            {
                    return;
            }
            
            this.丈丁丏丟丁丗丅丆丈(丐下丝丘丑丟丟丗丌:  SettedChest, 丒丑丟专丒丄七丂丒:  false, 丒上丗三丆一一业丞:  true);
        }
        private void 丈丁丏丟丁丗丅丆丈(Rilisoft.与专丒丞丐一丒丂东 丐下丝丘丑丟丟丗丌, bool 丒丑丟专丒丄七丂丒, bool 丒上丗三丆一一业丞)
        {
            bool val_78;
            string val_79;
            var val_80;
            var val_81;
            PetInfo val_82;
            float val_83;
            var val_84;
            float val_88;
            string val_89;
            ItemRarity val_91;
            UILabel[] val_92;
            val_78 = 丒上丗三丆一一业丞;
            if(丐下丝丘丑丟丟丗丌 == null)
            {
                    return;
            }
            
            if(丐下丝丘丑丟丟丗丌.丒世业三丘丝不下丕() != true)
            {
                    if(丐下丝丘丑丟丟丗丌.七丝丝丈七三丝丘一() == false)
            {
                goto label_3;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._getPrizesButton.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._toShopButton.gameObject, 丏业丟一东丂东丘丛:  true);
            .丙丞丗丌丌业丏丘丒 = System.String.alignConst;
            if(丐下丝丘丑丟丟丗丌.七丝丝丈七三丝丘一() != false)
            {
                    val_79 = "Key_0030";
            }
            else
            {
                    val_79 = "Key_3645";
            }
            
            .丙丞丗丌丌业丏丘丒 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_79);
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._toShopLabels, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new GameEventSetsViewMain.上丏三丌丂丙丅且丘(), method:  System.Void GameEventSetsViewMain.上丏三丌丂丙丅且丘::丄一不上与丗丂万丆(UILabel 丐三丞七丝丅不万丛)));
            goto label_17;
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._getPrizesButton.gameObject, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._toShopButton.gameObject, 丏业丟一东丂东丘丛:  false);
            label_17:
            int val_12 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏());
            val_80 = null;
            val_80 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏(), 丂丒丒丆且丝丘丈丟:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏(), 丘丐丝丟业丘丏东专:  this._propertiesArmoryItemContainer, 东丈丒三丞与业世一:  false, 丐丙丒丈丄不一丈与:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏(), 七丆丒与丗丌丄且丂:  val_12), 丑丂丟丆丗丒丙业丕:  true, 丙丂丒一丗下丘下丟:  0, 丄丄丒丘丏一丗丆与:  0, 世七与业一七世丂丒:  0);
            val_81 = null;
            val_81 = null;
            bool val_20 = System.Linq.Enumerable.Contains<System.String>(source:  Rilisoft.PetsManager.上七专丗下下丛三七, value:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏());
            val_82 = 0;
            if(val_20 != false)
            {
                    val_82 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏());
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._propertiesArmoryItemContainer.specialTable.gameObject, 丏业丟一东丂东丘丛:  (System.Linq.Enumerable.Contains<CategoryNames>(source:  WeaponManager.万三不丄丈丙与丁不(), value:  val_12)) | val_20);
            if((this._propertiesArmoryItemContainer.weaponProperties == 0) || (this._propertiesArmoryItemContainer.weaponProperties.activeSelf == false))
            {
                goto label_43;
            }
            
            val_83 = -108f;
            goto label_44;
            label_43:
            if((this._propertiesArmoryItemContainer.gadgetProperties == 0) || (this._propertiesArmoryItemContainer.gadgetProperties.activeSelf == false))
            {
                goto label_51;
            }
            
            val_83 = -146f;
            label_44:
            val_84 = this._propertiesArmoryItemContainer.specialTable.transform;
            UnityEngine.Vector3 val_33 = this._propertiesArmoryItemContainer.specialTable.transform.localPosition;
            UnityEngine.Vector3 val_35 = this._propertiesArmoryItemContainer.specialTable.transform.localPosition;
            val_88 = val_83;
            goto label_60;
            label_51:
            val_84 = this._propertiesArmoryItemContainer.specialTable.transform;
            UnityEngine.Vector3 val_38 = this._propertiesArmoryItemContainer.specialTable.transform.localPosition;
            val_83 = val_38.x;
            UnityEngine.Vector3 val_40 = this._propertiesArmoryItemContainer.specialTable.transform.localPosition;
            val_88 = -88f;
            label_60:
            val_84.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            string val_77 = 丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏();
            val_77 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_77);
            this._avatarDescription.SetActive(value:  val_77);
            bool val_48 = ((val_82 == 0) ? 1 : 0) | val_20 ^ 1;
            val_89 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏(), 七丆丒与丗丌丄且丂:  val_12);
            if(val_48 != true)
            {
                    val_89 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_23.Lkey);
            }
            
            List.Enumerator<T> val_50 = this._itemNamesLabels.GetEnumerator();
            label_85:
            if(((-442001392) & 1) == 0)
            {
                goto label_80;
            }
            
            string val_52 = 0.丐丏七丌丕丗业且上();
            if(val_52 == 0)
            {
                goto label_85;
            }
            
            val_52.text = val_89;
            goto label_85;
            label_80:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            三丅丁丗丗丝丂万且 val_55 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丐下丝丘丑丟丟丗丌.丅三专且丈一丝丂丏());
            if(val_55 == null)
            {
                goto label_93;
            }
            
            val_91 = val_55;
            if(val_48 == true)
            {
                goto label_115;
            }
            
            label_114:
            val_91 = mem[val_23 + 216];
            val_91 = val_23 + 216;
            label_115:
            string val_56 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_91);
            List.Enumerator<T> val_57 = this._itemRarityLabels.GetEnumerator();
            label_113:
            if(((-442001392) & 1) == 0)
            {
                goto label_98;
            }
            
            string val_58 = 0.丐丏七丌丕丗业且上();
            if(val_58 == 0)
            {
                goto label_113;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_56)) == false)
            {
                goto label_104;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_58.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_113;
            label_104:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_58.gameObject, 丏业丟一东丂东丘丛:  true);
            val_58.text = val_56;
            goto label_113;
            label_93:
            if(val_48 == false)
            {
                goto label_114;
            }
            
            goto label_115;
            label_98:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_78 = this.Context.丄三丐丟丗丄丟上丞().IndexOf(item:  this);
            if(丒丑丟专丒丄七丂丒 != false)
            {
                    if(this._chestButtons.Item[val_78].state != true)
            {
                    this._chestButtons.Item[val_78].state = true;
            }
            
            }
            
            if(val_78 != false)
            {
                    this._charactersCorousel.RotateTo(丂专丏丐且丁世丏丙:  val_78);
            }
            
            val_92 = this._setBonusLabels;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_92, 丕丗丘丑丛与丑业丒:  this.上丄东万丕丁丑丐三());
            if((val_55 != null) && (this._combatLevelContainer != 0))
            {
                    if(this._combatLevelLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._combatLevelContainer, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            }
            
            if((val_20 != false) && (this._combatLevelContainer != 0))
            {
                    if(this._combatLevelLabel != 0)
            {
                    val_92 = val_82;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._combatLevelContainer, 丏业丟一东丂东丘丛:  (val_92 != 0) ? 1 : 0);
                if(val_92 == 0)
            {
                    return;
            }
            
                val_92 = val_92.CurrentLevel.ToString();
                this._combatLevelLabel.text = val_92;
                return;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._combatLevelContainer, 丏业丟一东丂东丘丛:  false);
        }
        private void 丁丘不七东业丂丞丙(int 丘丒丌下丕专且七专)
        {
            var val_7;
            if(this.Context.丄三丐丟丗丄丟上丞().Count < 2)
            {
                    return;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_6 = this.Context.丄三丐丟丗丄丟上丞().Item[丘丒丌下丕专且七专];
            val_7 = 0;
            this.丈丁丏丟丁丗丅丆丈(丐下丝丘丑丟丟丗丌:  null, 丒丑丟专丒丄七丂丒:  true, 丒上丗三丆一一业丞:  true);
        }
        protected override void 丗丌丂丙丈丆不丂七()
        {
            var val_16;
            var val_20;
            var val_21;
            val_16 = this;
            this.丗丌丂丙丈丆不丂七();
            if(this.Context == null)
            {
                    return;
            }
            
            if(this.Context.丄三丐丟丗丄丟上丞() == null)
            {
                    return;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_16 = System.Linq.Enumerable.Cast<Rilisoft.与专丒丞丐一丒丂东>(source:  this.Context.丄三丐丟丗丄丟上丞()).GetEnumerator();
            label_25:
            var val_20 = 0;
            val_20 = val_20 + 1;
            if(val_16.MoveNext() == false)
            {
                goto label_15;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            T val_12 = val_16.Current;
            if(val_12 == 0)
            {
                goto label_25;
            }
            
            System.TimeSpan val_13 = val_12.世丙不业丛丂东万丈();
            if(val_13._ticks.TotalSeconds <= 0f)
            {
                goto label_25;
            }
            
            System.Nullable<System.TimeSpan> val_15 = val_12.七丆丄丟丟丕三上上();
            if(( & 1) == 0)
            {
                goto label_25;
            }
            
            System.Nullable<System.TimeSpan> val_16 = val_12.七丆丄丟丟丕三上上();
            if(TotalSeconds >= 0)
            {
                goto label_25;
            }
            
            goto label_25;
            label_15:
            val_20 = 0;
            val_21 = 0;
            if(val_16 == null)
            {
                
            }
            else
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_16.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        protected override string 丅丅业丏丒丙丒丁丘()
        {
            object val_9;
            var val_10;
            var val_11;
            val_9 = this;
            if(this.Context != null)
            {
                    val_9 = this.Context;
                val_10 = val_9;
                val_11 = 0;
                System.Nullable<System.TimeSpan> val_3 = val_10.丙世丑丅丒丑业与不();
            }
            else
            {
                    val_11 = 0;
            }
            
            if(( & 1) == 0)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
            }
            
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
            }
            
            val_9 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            string val_7 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4959"), arg0:  val_9);
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4453");
        }
        private string 上丄东万丕丁丑丐三()
        {
            var val_78;
            var val_98;
            string val_111;
            string val_112;
            var val_113;
            var val_115;
            var val_116;
            var val_117;
            var val_120;
            var val_121;
            var val_122;
            var val_124;
            var val_125;
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "sniper2_roulette")) != false)
            {
                    val_111 = "Key_5100";
                return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111 = "Key_5780");
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "Roulette_time_traveller2")) != true)
            {
                    if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "humpty_dumpty_roulette")) == false)
            {
                goto label_9;
            }
            
            }
            
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            label_9:
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "Alien_Santa_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "super_soldier_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "big_b_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "super_villain_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "Infected")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "new_year_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "exoskeletons_v3")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "BTroulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "halloween_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "thanksgiving_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "eco_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "toystory")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "summer_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "champion_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "digital_hero_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "mouseking_roulette")) == true)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "master_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "alien_general_roulette")) != false)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "sets")) != false)
            {
                    val_112 = "cyber_santa_set";
            }
            else
            {
                    val_112 = this.Context.业上丙丞丐丄丆丅七();
            }
            
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_112)) != false)
            {
                    丛且专丞丗丆丙丒万 val_73 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[val_112];
                val_113 = 1152921505072021504;
                return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_76 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values.GetEnumerator();
            val_115 = 0;
            do
            {
                label_184:
                if(((-440680992) & 1) == 0)
            {
                goto label_197;
            }
            
                string val_79 = val_78.丐丏七丌丕丗业且上();
                val_116 = null;
                val_116 = null;
            }
            while((Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.ContainsKey(key:  X25)) == false);
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  0)) == false)
            {
                goto label_197;
            }
            
            if((System.String.op_Equality(a:  ???, b:  this.丅三专且丈一丝丂丏())) == true)
            {
                goto label_126;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  ???)) == true)
            {
                goto label_129;
            }
            
            bool val_86 = System.String.op_Equality(a:  ???, b:  this.丅三专且丈一丝丂丏());
            if(val_86 == true)
            {
                goto label_131;
            }
            
            label_129:
            if(val_86 == false)
            {
                goto label_132;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_87 = val_86.GetEnumerator();
            do
            {
                if(((-440681040) & 1) == 0)
            {
                goto label_141;
            }
            
                ConfiguredValueTaskAwaiter val_89 = val_78.GetAwaiter();
            }
            while((System.String.op_Equality(a:  val_89._value._obj, b:  this.丅三专且丈一丝丂丏())) == false);
            
            val_117 = null;
            val_117 = null;
            string val_92 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[this];
            label_141:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((2 == 1) || (1072 != 1072))
            {
                goto label_151;
            }
            
            if(val_79 != null)
            {
                goto label_155;
            }
            
            goto label_153;
            label_151:
            val_115 = 0;
            label_132:
            if(val_79 != null)
            {
                goto label_155;
            }
            
            label_153:
            label_155:
            if( == 0)
            {
                goto label_184;
            }
            
            if((System.String.op_Equality(a:  val_78 + 64, b:  this.丅三专且丈一丝丂丏())) == true)
            {
                goto label_158;
            }
            
            if((val_78 + 64 + 72) == 0)
            {
                goto label_184;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_95 = val_78 + 64 + 72.GetEnumerator();
            label_165:
            if(((-440681040) & 1) == 0)
            {
                goto label_163;
            }
            
            ConfiguredValueTaskAwaiter val_99 = val_98.GetAwaiter();
            if((System.String.op_Equality(a:  val_99._value._obj, b:  this.丅三专且丈一丝丂丏())) == false)
            {
                goto label_165;
            }
            
            val_120 = null;
            val_120 = null;
            string val_102 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_79];
            val_121 = 0;
            goto label_171;
            label_163:
            val_121 = 0;
            label_171:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((4 == 1) || (1251 != 1251))
            {
                goto label_181;
            }
            
            goto label_184;
            label_181:
            if( == 0)
            {
                goto label_184;
            }
            
            goto label_184;
            label_126:
            val_122 = null;
            val_122 = null;
            string val_103 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_79];
            goto label_197;
            label_131:
            val_124 = null;
            val_124 = null;
            string val_104 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_79];
            goto label_197;
            label_158:
            val_125 = null;
            val_125 = null;
            label_197:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(6 == 1)
            {
                goto label_225;
            }
            
            if((null == 0) || (1279 == 1279))
            {
                goto label_237;
            }
            
            label_236:
            label_237:
            if(Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_79] == 0)
            {
                    string val_108 = ((System.String.op_Equality(a:  this.丅三专且丈一丝丂丏(), b:  "avatar_blogger")) != true) ? "Key_6470" : 0;
            }
            
            if((((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_108)) != true) ? "Key_3538" : (val_108)) == 0)
            {
                    return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            }
            
            val_113 = 1152921505072021504;
            return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_111);
            label_225:
            if(null != 0)
            {
                goto label_236;
            }
            
            goto label_237;
        }
        private Rilisoft.FogSettings 专丑三万丗丁丆丘万()
        {
            Rilisoft.FogSettings val_6;
            if(this.Context != null)
            {
                    if((GameEventsHalper.三丝世业业一丛丌丑(丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七())) != 0)
            {
                    val_6 = val_4.fogSettings;
                return (Rilisoft.FogSettings)mem[this._fogSettings];
            }
            
            }
            
            val_6 = this._fogSettings;
            return (Rilisoft.FogSettings)mem[this._fogSettings];
        }
        private UnityEngine.Color 丝丁丆丁丑丈下万与()
        {
            UnityEngine.Color val_9;
            var val_10;
            var val_11;
            var val_12;
            if(this.Context != null)
            {
                    EventGuiSettings val_4 = GameEventsHalper.三丝世业业一丛丌丑(丟丟丄专上丟丁丐丝:  this.Context.业上丙丞丐丄丆丅七());
                if(val_4 != 0)
            {
                    val_9 = val_4.ambientCollor;
                val_10 = val_4 + 36;
                val_11 = val_4 + 40;
                val_12 = val_4 + 44;
                return new UnityEngine.Color() {r = this.丗丅三七且丅丑与丂.r, g = 1.864828E-08f, b = 1.864828E-08f, a = 1.864828E-08f};
            }
            
            }
            
            val_9 = this.丗丅三七且丅丑与丂;
            val_10 = 1152921542821423468;
            val_11 = 1152921542821423472;
            val_12 = 1152921542821423476;
            return new UnityEngine.Color() {r = this.丗丅三七且丅丑与丂.r, g = 1.864828E-08f, b = 1.864828E-08f, a = 1.864828E-08f};
        }
        public GameEventSetsViewMain()
        {
            this.丗丅三七且丅丑与丂 = 0;
            mem[1152921542821551852] = 0;
            mem[1152921542821551860] = 0;
        }
    
    }

}
