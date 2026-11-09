using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventMiniGameViewMain : GameEventSetsViewBase
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.GameEventMiniGameChectButtonView> _chestButtons;
        private UILabel[] _eventNameLabels;
        private UIButton _getPrizesButton;
        private UIButton _toShopButton;
        private UILabel[] _toShopLabels;
        private Rilisoft.GameEventSetsCollectedView _collectedView;
        private UILabel[] _setBonusLabels;
        private UnityEngine.GameObject _combatLevelContainer;
        private UILabel _combatLevelLabel;
        
        // Properties
        internal override string 丄丂丏世丛丏万三丆 { get; }
        public override Rilisoft.与专丒丞丐一丒丂东 丌且丝丘丌丕东丒与 { get; set; }
        
        // Methods
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
        protected override void OnEnable()
        {
            this.OnEnable();
            List.Enumerator<T> val_1 = this._chestButtons.GetEnumerator();
            label_5:
            if(((-497945736) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            System.Action<Rilisoft.GameEventMiniGameChectButtonView> val_3 = new System.Action<Rilisoft.GameEventMiniGameChectButtonView>(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::万丁丏上下丅丕丗东(Rilisoft.GameEventMiniGameChectButtonView 东丁丈且丌丄七专三));
            val_2.remove_Clicked(丙业与丙丗丝不丈东:  null);
            System.Action<Rilisoft.GameEventMiniGameChectButtonView> val_4 = new System.Action<Rilisoft.GameEventMiniGameChectButtonView>(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::万丁丏上下丅丕丗东(Rilisoft.GameEventMiniGameChectButtonView 东丁丈且丌丄七专三));
            val_2.add_Clicked(丙业与丙丗丝不丈东:  null);
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 万丁丏上下丅丕丗东(Rilisoft.GameEventMiniGameChectButtonView 东丁丈且丌丄七专三)
        {
            var val_9;
            var val_10;
            val_9 = this;
            if(东丁丈且丌丄七专三 == 0)
            {
                    return;
            }
            
            if((东丁丈且丌丄七专三.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            if(val_5 != null)
            {
                    var val_6 = (null == null) ? (val_5) : 0;
            }
            else
            {
                    val_10 = 0;
            }
            
            if(this.七丝丝丈七三丝丘一() == true)
            {
                goto label_14;
            }
            
            val_9 = val_9;
            if(this.丒世业三丘丝不下丕() == false)
            {
                goto label_16;
            }
            
            label_14:
            val_10.ShowSelectedChestBindedItemInShop(三下丞一业丄世不上:  true);
            return;
            label_16:
            val_10.ShowSelectedChestContext();
        }
        protected override void OnDisable()
        {
            List.Enumerator<T> val_1 = this._chestButtons.GetEnumerator();
            label_4:
            if(((-497652104) & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<Rilisoft.GameEventMiniGameChectButtonView> val_3 = new System.Action<Rilisoft.GameEventMiniGameChectButtonView>(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::万丁丏上下丅丕丗东(Rilisoft.GameEventMiniGameChectButtonView 东丁丈且丌丄七专三));
            0.丐丏七丌丕丗业且上().remove_Clicked(丙业与丙丗丝不丈东:  null);
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.OnDisable();
        }
        public override void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            var val_11;
            Rilisoft.丛且世丐丆上七业丁 val_29;
            System.Action val_30;
            var val_31;
            System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Int32> val_33;
            val_29 = 丅东专与不三丂丁丝;
            if(this.Context != null)
            {
                    System.Action val_3 = null;
                val_30 = val_3;
                val_3 = new System.Action(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::丙东三丒业丁世一万());
                this.Context.丘世不丌业丞丄与丝(丙业与丙丗丝不丈东:  val_3);
            }
            
            this.Setup(丅东专与不三丂丁丝:  val_29, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆);
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
            val_30 = 1152921542752038960;
            label_12:
            if(((-497438736) & 1) == 0)
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
            if(((-497438736) & 1) == 0)
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
                    val_31 = null;
                val_31 = null;
                val_33 = GameEventMiniGameViewMain.<>c.<>9__8_0;
                if(val_33 == null)
            {
                    System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Int32> val_22 = null;
                val_33 = val_22;
                val_22 = new System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Int32>(object:  GameEventMiniGameViewMain.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GameEventMiniGameViewMain.<>c::丟丛七丄东世万丞丒(Rilisoft.与专丒丞丐一丒丂东 丁丂专业丁丅丅丈丙));
                GameEventMiniGameViewMain.<>c.<>9__8_0 = val_33;
            }
            
                .且丑三专业七上专三 = System.Linq.Enumerable.Min<Rilisoft.与专丒丞丐一丒丂东>(source:  val_8, selector:  val_22);
                Rilisoft.与专丒丞丐一丒丂东 val_25 = System.Linq.Enumerable.First<Rilisoft.与专丒丞丐一丒丂东>(source:  val_8, predicate:  new System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Boolean>(object:  new GameEventMiniGameViewMain.业东下丕世丗丏万丏(), method:  System.Boolean GameEventMiniGameViewMain.业东下丕世丗丏万丏::一丄业丐丄丒下丏丞(Rilisoft.与专丒丞丐一丒丂东 丁丂专业丁丅丅丈丙)));
            }
            
            this.丈丁丏丟丁丗丅丆丈(丐下丝丘丑丟丟丗丌:  this, 丒丑丟专丒丄七丂丒:  false, 丒上丗三丆一一业丞:  false);
            label_5:
            this.丘丟万丌丄三丏丈业();
            System.Action val_27 = null;
            val_29 = val_27;
            val_27 = new System.Action(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::丙东三丒业丁世一万());
            this.Context.丅不丐一丗丐丞丟丄(丙业与丙丗丝不丈东:  val_27);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            if(this.Context == null)
            {
                    return;
            }
            
            this.Context.丘世不丌业丞丄与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::丙东三丒业丁世一万()));
        }
        public override void ShowWindow()
        {
            this.ShowWindow();
            this.丘丟万丌丄三丏丈业();
        }
        public override void HideWindow()
        {
            this.HideWindow();
            this.Context.丘世不丌业丞丄与丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.GameEventMiniGameViewMain::丙东三丒业丁世一万()));
        }
        private void 丙东三丒业丁世一万()
        {
            this.丘丟万丌丄三丏丈业();
        }
        private void 丘丟万丌丄三丏丈业()
        {
            Rilisoft.上专业三丟丁丞专下 val_11;
            if(this.Context == null)
            {
                    return;
            }
            
            if(this != null)
            {
                    val_11 = this;
                bool val_4 = this.Context.丄三丐丟丗丄丟上丞().Contains(item:  this);
            }
            
            this.丙丝丗丕丐丟丛丞七();
            if(this._eventNameLabels != null)
            {
                    .丝丏业丅丈东业丝丒 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.Context.丑丐丏丌丑下一丑丒());
                val_11 = this._eventNameLabels;
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  val_11, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new GameEventMiniGameViewMain.世东丒与丞七不不东(), method:  System.Void GameEventMiniGameViewMain.世东丒与丞七不不东::与丞丕业丂业业三七(UILabel 丐三丞七丝丅不万丛)));
            }
            
            this._collectedView.Setup(与且专丈不万东一万:  this.Context);
        }
        private void 丙丝丗丕丐丟丛丞七()
        {
            var val_30;
            var val_31;
            var val_32;
            丝下丐丁专丂丈业一 val_33;
            var val_34;
            int val_35;
            val_30 = 1152921542765129344;
            val_31 = 0;
            goto label_1;
            label_27:
            Rilisoft.上专业三丟丁丞专下 val_3 = this.Context.丄三丐丟丗丄丟上丞().Item[0];
            val_32 = 0;
            if(val_31 <= (this._chestButtons.Count - 1))
            {
                    Rilisoft.GameEventMiniGameChectButtonView val_6 = this._chestButtons.Item[0];
                if(七丝丝丈七三丝丘一() != false)
            {
                    val_33 = 2;
            }
            else
            {
                    val_33 = 丒世业三丘丝不下丕();
            }
            
                if(val_6 != 0)
            {
                    val_30 = val_30;
                if(val_6.gameObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6.gameObject, 丏业丟一东丂东丘丛:  true);
                val_6.<丅丝丌丝丁丏丙东丞>k__BackingField = ;
                val_6.世丝丞七丅丝丄与三 = val_33;
                val_6.丝一丅丆三东丂丞七();
                val_30 = val_30;
            }
            
            }
            
            }
            
            val_31 = 1;
            label_1:
            if(val_31 < this.Context.丄三丐丟丗丄丟上丞().Count)
            {
                goto label_27;
            }
            
            val_34 = this.Context.丄三丐丟丗丄丟上丞();
            if(this._chestButtons.Count <= val_34.Count)
            {
                    return;
            }
            
            val_35 = this._chestButtons.Count;
            goto label_41;
            label_47:
            val_35 = val_35 - 1;
            Rilisoft.GameEventMiniGameChectButtonView val_21 = this._chestButtons.Item[val_35];
            if(val_21 != 0)
            {
                    if(val_21.gameObject != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            label_41:
            val_34 = this.Context.丄三丐丟丗丄丟上丞();
            if(val_35 > val_34.Count)
            {
                goto label_47;
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
            
            this.丈丁丏丟丁丗丅丆丈(丐下丝丘丑丟丟丗丌:  SettedChest, 丒丑丟专丒丄七丂丒:  false, 丒上丗三丆一一业丞:  false);
        }
        private void 丈丁丏丟丁丗丅丆丈(Rilisoft.与专丒丞丐一丒丂东 丐下丝丘丑丟丟丗丌, bool 丒丑丟专丒丄七丂丒, bool 丒上丗三丆一一业丞)
        {
            string val_11;
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
            
            .丙丞丗丌丌业丏丘丒 = System.String.alignConst;
            if(丐下丝丘丑丟丟丗丌.七丝丝丈七三丝丘一() != false)
            {
                    val_11 = "Key_0030";
            }
            else
            {
                    val_11 = "Key_3645";
            }
            
            .丙丞丗丌丌业丏丘丒 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_11);
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._toShopLabels, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new GameEventMiniGameViewMain.丞丆丌万丛不且七丐(), method:  System.Void GameEventMiniGameViewMain.丞丆丌万丛不且七丐::丄一不上与丗丂万丆(UILabel 丐三丞七丝丅不万丛)));
            label_3:
            int val_9 = this.Context.丄三丐丟丗丄丟上丞().IndexOf(item:  this);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._setBonusLabels, 丕丗丘丑丛与丑业丒:  this.上丄东万丕丁丑丐三());
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
            this.丈丁丏丟丁丗丅丆丈(丐下丝丘丑丟丟丗丌:  null, 丒丑丟专丒丄七丂丒:  false, 丒上丗三丆一一业丞:  false);
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
            var val_14;
            var val_34;
            string val_46;
            string val_47;
            var val_48;
            int val_49;
            var val_50;
            string val_51;
            var val_53;
            var val_54;
            var val_56;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_64;
            var val_66;
            var val_67;
            val_46 = this;
            if((System.String.op_Equality(a:  this.Context.业上丙丞丐丄丆丅七(), b:  "sets")) != false)
            {
                    val_47 = "cyber_santa_set";
            }
            else
            {
                    val_47 = this.Context.业上丙丞丐丄丆丅七();
            }
            
            val_48 = 1152921505264353280;
            val_49 = System.String.alignConst;
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_47)) == false)
            {
                goto label_8;
            }
            
            丛且专丞丗丆丙丒万 val_9 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[val_47];
            val_50 = 1152921505072021504;
            val_51 = val_9.丟三丞丝专且丅丟万;
            goto label_13;
            label_8:
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_12 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values.GetEnumerator();
            val_53 = 0;
            label_86:
            if(((-495113440) & 1) == 0)
            {
                goto label_26;
            }
            
            string val_15 = val_14.丐丏七丌丕丗业且上();
            val_54 = null;
            val_54 = null;
            if((Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.ContainsKey(key:  X26)) == false)
            {
                goto label_86;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  0)) == false)
            {
                goto label_26;
            }
            
            if((System.String.op_Equality(a:  ???, b:  this.丅三专且丈一丝丂丏())) == true)
            {
                goto label_28;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  ???)) == true)
            {
                goto label_31;
            }
            
            bool val_22 = System.String.op_Equality(a:  ???, b:  this.丅三专且丈一丝丂丏());
            if(val_22 == true)
            {
                goto label_33;
            }
            
            label_31:
            if(val_22 == false)
            {
                goto label_34;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_23 = val_22.GetEnumerator();
            do
            {
                if(((-495113488) & 1) == 0)
            {
                goto label_43;
            }
            
                ConfiguredValueTaskAwaiter val_25 = val_14.GetAwaiter();
            }
            while((System.String.op_Equality(a:  val_25._value._obj, b:  this.丅三专且丈一丝丂丏())) == false);
            
            val_56 = null;
            val_56 = null;
            string val_28 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[this];
            label_43:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((2 == 1) || (369 != 369))
            {
                goto label_53;
            }
            
            if(val_15 != null)
            {
                goto label_57;
            }
            
            goto label_55;
            label_53:
            label_34:
            if(val_15 != null)
            {
                goto label_57;
            }
            
            label_55:
            label_57:
            if((public System.Void Dictionary.Enumerator<CategoryNames, System.String>::Dispose()) == 0)
            {
                goto label_86;
            }
            
            if((System.String.op_Equality(a:  System.Void Dictionary.Enumerator<DiscreteVector2, System.Object>::System.Collections.IEnumerator.Reset(), b:  this.丅三专且丈一丝丂丏())) == true)
            {
                goto label_60;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_31 = System.Void Dictionary.Enumerator<DiscreteVector2, System.Object>::System.Collections.IEnumerator.Reset().__il2cppRuntimeField_48.GetEnumerator();
            label_67:
            if(((-495113488) & 1) == 0)
            {
                goto label_65;
            }
            
            ConfiguredValueTaskAwaiter val_35 = val_34.GetAwaiter();
            if((System.String.op_Equality(a:  val_35._value._obj, b:  this.丅三专且丈一丝丂丏())) == false)
            {
                goto label_67;
            }
            
            val_59 = null;
            val_59 = null;
            string val_38 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_15];
            val_60 = 0;
            goto label_73;
            label_65:
            val_60 = 0;
            label_73:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((4 == 1) || (548 != 548))
            {
                goto label_83;
            }
            
            goto label_86;
            label_83:
            if( == 0)
            {
                goto label_86;
            }
            
            goto label_86;
            label_26:
            val_61 = -495113680;
            val_62 = 5;
            label_99:
            val_48 = 0;
            goto label_87;
            label_28:
            val_64 = null;
            val_64 = null;
            string val_39 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_15];
            goto label_99;
            label_33:
            val_66 = null;
            val_66 = null;
            string val_40 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_15];
            goto label_99;
            label_60:
            val_67 = null;
            val_67 = null;
            string val_41 = Rilisoft.GameEventSetsViewBase.丗丛与丈丒丄丝一丑.Item[val_15];
            goto label_99;
            label_87:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_127;
            }
            
            if(( == null) || (548 == 576))
            {
                goto label_136;
            }
            
            label_135:
            label_136:
            string val_43 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_41)) != true) ? "Key_3538" : (val_41);
            if(val_43 == 0)
            {
                    return (string)val_49;
            }
            
            val_50 = 1152921505072021504;
            label_13:
            val_49 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_43);
            return (string)val_49;
            label_127:
            if( != null)
            {
                goto label_135;
            }
            
            goto label_136;
        }
        public GameEventMiniGameViewMain()
        {
        
        }
    
    }

}
