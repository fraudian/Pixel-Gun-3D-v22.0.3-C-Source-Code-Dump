using UnityEngine;

namespace PGCompany
{
    public sealed class MatchHistoryView : PGBehaviour
    {
        // Fields
        public UIWidget viewWidget;
        private UnityEngine.GameObject _loadingGO;
        private UILabel _modeName;
        private UILabel _mtchResult;
        private UILabel _time;
        private UILabel _cupsCount;
        private UILabel _mtchPoints;
        private UILabel _kills;
        private UILabel _place;
        private UnityEngine.GameObject _cupsContainer;
        private UnityEngine.GameObject _winBackground;
        private UnityEngine.GameObject _drawBackground;
        private UnityEngine.GameObject _looseBackground;
        private UnityEngine.GameObject _battleRoyaleContainer;
        private UnityEngine.GameObject _duelContainer;
        private UnityEngine.GameObject _teamDuelContainer;
        private UnityEngine.GameObject _deathmatchContainer;
        private UIGrid _blueTeamFightGrid;
        private UIGrid _redTeamFightGrid;
        private UIGrid _duelGrid;
        private UIGrid _deathmatchGrid;
        private UIGrid _battleRoyaleGrid;
        private UnityEngine.GameObject _playerExample;
        private System.Collections.Generic.List<UnityEngine.GameObject> _duelPlayers;
        private System.Collections.Generic.List<UnityEngine.GameObject> _deathmatchPlayers;
        private System.Collections.Generic.List<UnityEngine.GameObject> _blueTeamPlayers;
        private System.Collections.Generic.List<UnityEngine.GameObject> _redTeamPlayers;
        private System.Collections.Generic.List<UnityEngine.GameObject> _battleRoyalePlayers;
        private UnityEngine.Color 上丄不且七丁丈丏丌;
        private UnityEngine.Color 丝且丕丐丂丙丁下丛;
        private UnityEngine.Color 丁不一丌专三丐丄丏;
        internal Progress.丝下丛万丐丙且七丌 丛丆世一东丛丌丛丄;
        
        // Methods
        internal float 丙丞丏丏三丙丙业丁()
        {
            if(this.丛丆世一东丛丌丛丄 == null)
            {
                    return 350f;
            }
            
            Rilisoft.七丕丟丏三丈一丄世 val_1 = this.丛丆世一东丛丌丛丄.业丄丄且丕丕不一万();
            if(val_1 < 9)
            {
                    return (float)106049072 + (val_1) << 2;
            }
            
            if((val_1 & 4294967294) == 16)
            {
                    return 350f;
            }
            
            var val_3 = (val_1 == 20) ? 1 : 0;
            return (float)106049020 + val_1 == 0x14 ? 1 : 0;
        }
        internal void 一丞一丝丘丕且丒丆(Progress.丝下丛万丐丙且七丌 与丛丙一丙丆丁七业)
        {
            int val_38;
            UnityEngine.GameObject val_39;
            var val_40;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_42;
            object val_43;
            object val_44;
            object val_45;
            object val_46;
            var val_47;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_49;
            this.丛丆世一东丛丌丛丄 = 与丛丙一丙丆丁七业;
            Rilisoft.七丕丟丏三丈一丄世 val_2 = 与丛丙一丙丆丁七业.业丄丄且丕丕不一万();
            var val_39 = 0;
            val_39 = val_39 + 1;
            bool val_5 = GameConnect.丛丛丏专丏下三与七().TryGetValue(key:  null, value: out  TValue val_4 = null);
            val_38 = 0;
            if(val_38 == 0)
            {
                    val_38 = System.String.alignConst;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._modeName, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_38));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._winBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._drawBackground, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._looseBackground, 丏业丟一东丂东丘丛:  false);
            丌丈不下下丘丏丌一 val_7 = 与丛丙一丙丆丁七业.丑丄丁且丂丈万丞世();
            if(val_7 == 3)
            {
                goto label_15;
            }
            
            if(val_7 == 2)
            {
                goto label_16;
            }
            
            if(val_7 != 1)
            {
                goto label_17;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._mtchResult, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "FakeRewardType_Victory"));
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._mtchResult, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.上丄不且七丁丈丏丌});
            val_39 = this._winBackground;
            goto label_27;
            label_15:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._mtchResult, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9676"));
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._mtchResult, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丝且丕丐丂丙丁下丛});
            val_39 = this._drawBackground;
            goto label_27;
            label_16:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._mtchResult, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "FakeRewardType_Lose"));
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._mtchResult, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丁不一丌专三丐丄丏});
            val_39 = this._looseBackground;
            label_27:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_39, 丏业丟一东丂东丘丛:  true);
            label_17:
            val_40 = null;
            val_40 = null;
            val_42 = MatchHistoryView.<>c.<>9__33_0;
            if(val_42 == null)
            {
                    System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_12 = null;
                val_42 = val_12;
                val_12 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryView.<>c::下丌业丑万不丑七业(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryView.<>c.<>9__33_0 = val_42;
            }
            
            专丛业丅丕丅丅丅丄 val_13 = System.Linq.Enumerable.FirstOrDefault<专丛业丅丕丅丅丅丄>(source:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗(), predicate:  val_12);
            if(val_13 != null)
            {
                    int val_15 = val_13.三丄丏丂丁下丐丛万();
                val_43 = 0;
            }
            else
            {
                    val_43 = 0;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._place, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}{1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9677"), arg1:  val_43));
            if(val_13 != null)
            {
                    int val_18 = val_13.丏七丘丗东丈三丝万();
                val_44 = 0;
            }
            else
            {
                    val_44 = 0;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._kills, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}{1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2273"), arg1:  val_44));
            val_45 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7122");
            if(val_13 != null)
            {
                    int val_21 = val_13.丑一三丙丐丕丕三丕();
                val_46 = 0;
            }
            else
            {
                    val_46 = 0;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._mtchPoints, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}{1}", arg0:  val_45, arg1:  val_46));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._cupsCount, 丕丗丘丑丛与丑业丒:  与丛丙一丙丆丁七业.丌丈丁丕丕世与上七());
            System.Nullable<System.Boolean> val_24 = 与丛丙一丙丆丁七业.丝专业丄丂丂丈丕与();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cupsContainer, 丏业丟一东丂东丘丛:  val_24.HasValue.GetValueOrDefault() & 1152921555765640628);
            System.TimeSpan val_31 = System.TimeSpan.FromSeconds(value:  (double)专七专下且专三一且.上且一丈丐三丄一丆() - 与丛丙一丙丆丁七业.三丂丈丅丞上丁专不());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._time, 丕丗丘丑丛与丑业丒:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_31._ticks}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_31._ticks}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9675")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9675")));
            val_47 = null;
            val_47 = null;
            val_49 = MatchHistoryView.<>c.<>9__33_1;
            if(val_49 == null)
            {
                    System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_36 = null;
                val_49 = val_36;
                val_36 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryView.<>c::丛丛丂万且专丏丛业(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryView.<>c.<>9__33_1 = val_49;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadingGO, 丏业丟一东丂东丘丛:  System.Linq.Enumerable.Any<专丛业丅丕丅丅丅丄>(source:  与丛丙一丙丆丁七业.丈丟丂丐一丕七东丗(), predicate:  val_36));
            this.丑丕不丑七且七丄丅();
        }
        private void 丑丕不丑七且七丄丅()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._teamDuelContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._deathmatchContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._duelContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._battleRoyaleContainer, 丏业丟一东丂东丘丛:  false);
            Rilisoft.七丕丟丏三丈一丄世 val_1 = this.丛丆世一东丛丌丛丄.业丄丄且丕丕不一万();
            if(val_1 > 8)
            {
                goto label_4;
            }
            
            var val_8 = 106049028 + (val_1) << 2;
            val_8 = val_8 + 106049028;
            goto (106049028 + (val_1) << 2 + 106049028);
            label_9:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._teamDuelContainer, 丏业丟一东丂东丘丛:  true);
            this.七且世且一丄下丟万();
            return;
            label_4:
            if((val_1 & 4294967294) == 16)
            {
                goto label_9;
            }
            
            if(val_1 != 20)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._battleRoyaleContainer, 丏业丟一东丂东丘丛:  true);
            this.丕下丌丛东东一丂丟();
        }
        private void 七且世且一丄下丟万()
        {
            object val_68;
            var val_69;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_71;
            var val_72;
            专丛业丅丕丅丅丅丄 val_73;
            var val_74;
            专丛业丅丕丅丅丅丄 val_75;
            var val_76;
            var val_77;
            var val_78;
            System.Collections.Generic.List<UnityEngine.GameObject> val_79;
            var val_80;
            MatchHistoryView.丑丗东丞三且丂丄丒 val_1 = null;
            val_68 = val_1;
            val_1 = new MatchHistoryView.丑丗东丞三且丂丄丒();
            int val_3 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丛丆世一东丛丌丛丄.业丄丄且丕丕不一万());
            if((this._redTeamFightGrid.transform.childCount + this._blueTeamFightGrid.transform.childCount) != val_3)
            {
                    不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._blueTeamFightGrid.transform);
                不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._redTeamFightGrid.transform);
                this._blueTeamPlayers.Clear();
                this._redTeamPlayers.Clear();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._playerExample, 丏业丟一东丂东丘丛:  false);
                if(val_3 >= 2)
            {
                    var val_12 = ((val_3 < 0) ? (val_3 + 1) : (val_3)) >> 1;
                do
            {
                UnityEngine.GameObject val_14 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._playerExample, 丈东丘丏与丌东东下:  this._blueTeamFightGrid.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  true);
                this._blueTeamPlayers.Add(item:  val_14);
                UnityEngine.GameObject val_16 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._playerExample, 丈东丘丏与丌东东下:  this._redTeamFightGrid.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_16, 丏业丟一东丂东丘丛:  true);
                this._redTeamPlayers.Add(item:  val_16);
                val_12 = val_12 - 1;
            }
            while(val_12 != 0);
            
            }
            
            }
            
            val_69 = null;
            val_69 = null;
            val_71 = MatchHistoryView.<>c.<>9__35_0;
            if(val_71 == null)
            {
                    System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_18 = null;
                val_71 = val_18;
                val_18 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryView.<>c::丄与丛丑丟丝丗丁丛(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryView.<>c.<>9__35_0 = val_71;
            }
            
            专丛业丅丕丅丅丅丄 val_19 = System.Linq.Enumerable.FirstOrDefault<专丛业丅丕丅丅丅丄>(source:  this.丛丆世一东丛丌丛丄.丈丟丂丐一丕七东丗(), predicate:  val_18);
            if(val_19 == null)
            {
                goto label_31;
            }
            
            if(val_68 != null)
            {
                goto label_88;
            }
            
            label_89:
            label_88:
            .丟丛万丛三三业世丘 = val_19.七丟丈万三下丗丁丗();
            System.Collections.Generic.List<TSource> val_24 = System.Linq.Enumerable.ToList<专丛业丅丕丅丅丅丄>(source:  System.Linq.Enumerable.Where<专丛业丅丕丅丅丅丄>(source:  this.丛丆世一东丛丌丛丄.丈丟丂丐一丕七东丗(), predicate:  new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  val_1, method:  System.Boolean MatchHistoryView.丑丗东丞三且丂丄丒::丗丆丑业丅三丏丌丞(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑))));
            System.Collections.Generic.List<TSource> val_28 = System.Linq.Enumerable.ToList<专丛业丅丕丅丅丅丄>(source:  System.Linq.Enumerable.Where<专丛业丅丕丅丅丅丄>(source:  this.丛丆世一东丛丌丛丄.丈丟丂丐一丕七东丗(), predicate:  new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  val_1, method:  System.Boolean MatchHistoryView.丑丗东丞三且丂丄丒::丘丐丆万且丛丈丆与(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑))));
            val_72 = 1;
            goto label_35;
            label_42:
            if((System.String.op_Equality(a:  val_24.Item[1].业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    if(val_24 != null)
            {
                    val_73 = val_24.Item[1];
                val_24.set_Item(index:  1, value:  val_24.Item[0]);
            }
            else
            {
                    val_73 = 0.Item[1];
                0.set_Item(index:  1, value:  0.Item[0]);
            }
            
                val_24.set_Item(index:  0, value:  val_73);
            }
            
            val_72 = 2;
            label_35:
            if(val_72 < val_24.Count)
            {
                goto label_42;
            }
            
            val_74 = 1;
            goto label_43;
            label_50:
            if((System.String.op_Equality(a:  val_28.Item[1].业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    if(val_28 != null)
            {
                    val_75 = val_28.Item[1];
                val_28.set_Item(index:  1, value:  val_28.Item[0]);
            }
            else
            {
                    val_75 = 0.Item[1];
                0.set_Item(index:  1, value:  0.Item[0]);
            }
            
                val_28.set_Item(index:  0, value:  val_75);
            }
            
            val_74 = 2;
            label_43:
            if(val_74 < val_28.Count)
            {
                goto label_50;
            }
            
            val_76 = 1152921519068977584;
            val_77 = 1152921524288826496;
            val_78 = 0;
            goto label_51;
            label_69:
            PGCompany.MatchHistoryPlayerView val_48 = this._blueTeamPlayers.Item[0].GetComponent<PGCompany.MatchHistoryPlayerView>();
            if(val_48 == 0)
            {
                goto label_56;
            }
            
            if(val_24.Count <= val_78)
            {
                goto label_60;
            }
            
            专丛业丅丕丅丅丅丄 val_51 = val_24.Item[0];
            if(val_51 == null)
            {
                goto label_60;
            }
            
            if((System.String.op_Equality(a:  val_51.业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                goto label_61;
            }
            
            val_48.丈丏丛丏世东丒东丄(一丐丗丁丞丆丅丟丄:  val_51);
            goto label_63;
            label_60:
            val_48.丑丄与万世且丛且上();
            goto label_65;
            label_61:
            val_48.丏丒丞丑丕且丞丂与(一丐丗丁丞丆丅丟丄:  val_51, 丈丏丂丛与丛丐丁三:  (val_51.七丟丈万三下丗丁丗() == this.丛丆世一东丛丌丛丄.下上万丆丄丑业丁丆()) ? 1 : 0);
            val_76 = 1152921519068977584;
            label_63:
            val_77 = 1152921524288826496;
            label_65:
            label_56:
            val_78 = 1;
            label_51:
            val_79 = this._blueTeamPlayers;
            if(val_78 < val_79.Count)
            {
                goto label_69;
            }
            
            val_80 = 0;
            goto label_70;
            label_85:
            PGCompany.MatchHistoryPlayerView val_60 = this._redTeamPlayers.Item[0].GetComponent<PGCompany.MatchHistoryPlayerView>();
            if(val_60 == 0)
            {
                goto label_82;
            }
            
            if(val_28.Count <= val_80)
            {
                goto label_79;
            }
            
            val_79 = val_28.Item[0];
            if(val_79 == null)
            {
                goto label_79;
            }
            
            val_60.丏丒丞丑丕且丞丂与(一丐丗丁丞丆丅丟丄:  val_79, 丈丏丂丛与丛丐丁三:  (val_79.七丟丈万三下丗丁丗() == this.丛丆世一东丛丌丛丄.下上万丆丄丑业丁丆()) ? 1 : 0);
            val_77 = 1152921524288826496;
            goto label_82;
            label_79:
            val_60.丑丄与万世且丛且上();
            label_82:
            val_80 = 1;
            label_70:
            if(val_80 < this._redTeamPlayers.Count)
            {
                goto label_85;
            }
            
            val_68 = ???;
            goto typeof(UIGrid).__il2cppRuntimeField_1A8;
            label_31:
            if(val_68 != 0)
            {
                goto label_88;
            }
            
            goto label_89;
        }
        private void 世七丙三丞一万三丟()
        {
            专丛业丅丕丅丅丅丄 val_28;
            var val_29;
            专丛业丅丕丅丅丅丄 val_30;
            var val_31;
            var val_32;
            var val_33;
            int val_28 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丛丆世一东丛丌丛丄.业丄丄且丕丕不一万());
            if(this._deathmatchGrid.transform.childCount != val_28)
            {
                    不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._deathmatchGrid.transform);
                this._deathmatchPlayers.Clear();
                val_28 = 1152921505284374528;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._playerExample, 丏业丟一东丂东丘丛:  false);
                if(val_28 >= 1)
            {
                    do
            {
                UnityEngine.GameObject val_7 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._playerExample, 丈东丘丏与丌东东下:  this._deathmatchGrid.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
                this._deathmatchPlayers.Add(item:  val_7);
                val_28 = val_28 - 1;
            }
            while(val_28 != 0);
            
            }
            
            }
            
            System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<专丛业丅丕丅丅丅丄>(source:  this.丛丆世一东丛丌丛丄.丈丟丂丐一丕七东丗());
            val_29 = 1;
            goto label_20;
            label_27:
            if((System.String.op_Equality(a:  val_9.Item[1].业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    if(val_9 != null)
            {
                    val_30 = val_9.Item[1];
                val_9.set_Item(index:  1, value:  val_9.Item[0]);
            }
            else
            {
                    val_30 = 0.Item[1];
                val_28 = 0.Item[0];
                0.set_Item(index:  1, value:  val_28);
            }
            
                val_9.set_Item(index:  0, value:  val_30);
            }
            
            val_29 = 2;
            label_20:
            if(val_29 < val_9.Count)
            {
                goto label_27;
            }
            
            val_31 = 1152921519068977584;
            val_32 = 1152921539430426064;
            val_33 = 0;
            goto label_28;
            label_45:
            PGCompany.MatchHistoryPlayerView val_20 = this._deathmatchPlayers.Item[0].GetComponent<PGCompany.MatchHistoryPlayerView>();
            if(val_20 == 0)
            {
                goto label_42;
            }
            
            if(val_9.Count <= val_33)
            {
                goto label_37;
            }
            
            val_28 = val_9.Item[0];
            if(val_28 == null)
            {
                goto label_37;
            }
            
            bool val_26 = System.String.op_Equality(a:  val_28.业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            if(val_20 == null)
            {
                goto label_38;
            }
            
            if(val_26 == false)
            {
                goto label_39;
            }
            
            label_43:
            val_20.丈丏丛丏世东丒东丄(一丐丗丁丞丆丅丟丄:  val_28);
            goto label_40;
            label_37:
            val_20.丑丄与万世且丛且上();
            goto label_42;
            label_38:
            if(val_26 == true)
            {
                goto label_43;
            }
            
            label_39:
            val_20.丏丒丞丑丕且丞丂与(一丐丗丁丞丆丅丟丄:  val_28, 丈丏丂丛与丛丐丁三:  false);
            label_40:
            val_32 = val_32;
            val_31 = 1152921519068977584;
            label_42:
            val_33 = 1;
            label_28:
            if(val_33 < this._deathmatchPlayers.Count)
            {
                goto label_45;
            }
            
            if(this._deathmatchGrid == null)
            {
                
            }
        
        }
        private void 丕下丌丛东东一丂丟()
        {
            专丛业丅丕丅丅丅丄 val_29;
            var val_30;
            var val_31;
            专丛业丅丕丅丅丅丄 val_32;
            var val_33;
            var val_34;
            var val_35;
            if(this._battleRoyaleGrid.transform.childCount != 4)
            {
                    不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._battleRoyaleGrid.transform);
                this._battleRoyalePlayers.Clear();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._playerExample, 丏业丟一东丂东丘丛:  false);
                do
            {
                UnityEngine.GameObject val_5 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._playerExample, 丈东丘丏与丌东东下:  this._battleRoyaleGrid.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  true);
                this._battleRoyalePlayers.Add(item:  val_5);
                val_29 = 4 - 1;
            }
            while(val_29 != 0);
            
            }
            
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<专丛业丅丕丅丅丅丄>(source:  this.丛丆世一东丛丌丛丄.丈丟丂丐一丕七东丗());
            val_30 = 1152921541140904320;
            val_31 = 1;
            goto label_16;
            label_23:
            if((System.String.op_Equality(a:  val_7.Item[1].业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    if(val_7 != null)
            {
                    val_32 = val_7.Item[1];
                val_7.set_Item(index:  1, value:  val_7.Item[0]);
            }
            else
            {
                    val_32 = 0.Item[1];
                val_29 = 0.Item[0];
                0.set_Item(index:  1, value:  val_29);
            }
            
                val_7.set_Item(index:  0, value:  val_32);
            }
            
            val_31 = 2;
            label_16:
            if(val_31 < val_7.Count)
            {
                goto label_23;
            }
            
            val_33 = 1152921519068977584;
            val_34 = 1152921524288826496;
            val_35 = 0;
            goto label_24;
            label_42:
            PGCompany.MatchHistoryPlayerView val_18 = this._battleRoyalePlayers.Item[0].GetComponent<PGCompany.MatchHistoryPlayerView>();
            if(val_18 == 0)
            {
                goto label_38;
            }
            
            if(val_7.Count <= val_35)
            {
                goto label_33;
            }
            
            val_29 = val_7.Item[0];
            if(val_29 == null)
            {
                goto label_33;
            }
            
            if((System.String.op_Equality(a:  val_29.业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                goto label_34;
            }
            
            val_18.丈丏丛丏世东丒东丄(一丐丗丁丞丆丅丟丄:  val_29);
            goto label_36;
            label_33:
            val_18.丑丄与万世且丛且上();
            goto label_38;
            label_34:
            val_18.丏丒丞丑丕且丞丂与(一丐丗丁丞丆丅丟丄:  val_29, 丈丏丂丛与丛丐丁三:  (val_29.七丟丈万三下丗丁丗() == this.丛丆世一东丛丌丛丄.下上万丆丄丑业丁丆()) ? 1 : 0);
            val_34 = 1152921524288826496;
            val_33 = 1152921519068977584;
            label_36:
            val_30 = 1152921541140904320;
            label_38:
            val_35 = 1;
            label_24:
            if(val_35 < this._battleRoyalePlayers.Count)
            {
                goto label_42;
            }
            
            if(this._battleRoyaleGrid == null)
            {
                
            }
        
        }
        private void 丘丅世丙世万丄不丁()
        {
            专丛业丅丕丅丅丅丄 val_28;
            var val_29;
            专丛业丅丕丅丅丅丄 val_30;
            var val_31;
            var val_32;
            var val_33;
            int val_28 = GameConnect.丄丆三丛丂与不三东(丂丛丑东不丅丈一东:  this.丛丆世一东丛丌丛丄.业丄丄且丕丕不一万());
            if(this._duelGrid.transform.childCount != val_28)
            {
                    不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._duelGrid.transform);
                this._duelPlayers.Clear();
                val_28 = 1152921505284374528;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._playerExample, 丏业丟一东丂东丘丛:  false);
                if(val_28 >= 1)
            {
                    do
            {
                UnityEngine.GameObject val_7 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._playerExample, 丈东丘丏与丌东东下:  this._duelGrid.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  true);
                this._duelPlayers.Add(item:  val_7);
                val_28 = val_28 - 1;
            }
            while(val_28 != 0);
            
            }
            
            }
            
            System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<专丛业丅丕丅丅丅丄>(source:  this.丛丆世一东丛丌丛丄.丈丟丂丐一丕七东丗());
            val_29 = 1;
            goto label_20;
            label_27:
            if((System.String.op_Equality(a:  val_9.Item[1].业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
            {
                    if(val_9 != null)
            {
                    val_30 = val_9.Item[1];
                val_9.set_Item(index:  1, value:  val_9.Item[0]);
            }
            else
            {
                    val_30 = 0.Item[1];
                val_28 = 0.Item[0];
                0.set_Item(index:  1, value:  val_28);
            }
            
                val_9.set_Item(index:  0, value:  val_30);
            }
            
            val_29 = 2;
            label_20:
            if(val_29 < val_9.Count)
            {
                goto label_27;
            }
            
            val_31 = 1152921519068977584;
            val_32 = 1152921539430426064;
            val_33 = 0;
            goto label_28;
            label_45:
            PGCompany.MatchHistoryPlayerView val_20 = this._duelPlayers.Item[0].GetComponent<PGCompany.MatchHistoryPlayerView>();
            if(val_20 == 0)
            {
                goto label_42;
            }
            
            if(val_9.Count <= val_33)
            {
                goto label_37;
            }
            
            val_28 = val_9.Item[0];
            if(val_28 == null)
            {
                goto label_37;
            }
            
            bool val_26 = System.String.op_Equality(a:  val_28.业上丙丞丐丄丆丅七(), b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            if(val_20 == null)
            {
                goto label_38;
            }
            
            if(val_26 == false)
            {
                goto label_39;
            }
            
            label_43:
            val_20.丈丏丛丏世东丒东丄(一丐丗丁丞丆丅丟丄:  val_28);
            goto label_40;
            label_37:
            val_20.丑丄与万世且丛且上();
            goto label_42;
            label_38:
            if(val_26 == true)
            {
                goto label_43;
            }
            
            label_39:
            val_20.丏丒丞丑丕且丞丂与(一丐丗丁丞丆丅丟丄:  val_28, 丈丏丂丛与丛丐丁三:  false);
            label_40:
            val_32 = val_32;
            val_31 = 1152921519068977584;
            label_42:
            val_33 = 1;
            label_28:
            if(val_33 < this._duelPlayers.Count)
            {
                goto label_45;
            }
            
            if(this._duelGrid == null)
            {
                
            }
        
        }
        internal void 与丌上世丞丛丄丒丛()
        {
            PGCompany.MatchHistoryView.丝专上一丁一丙丌丗(丝丘丑业丛万丞丌丝:  this._blueTeamPlayers);
            PGCompany.MatchHistoryView.丝专上一丁一丙丌丗(丝丘丑业丛万丞丌丝:  this._redTeamPlayers);
            PGCompany.MatchHistoryView.丝专上一丁一丙丌丗(丝丘丑业丛万丞丌丝:  this._deathmatchPlayers);
            PGCompany.MatchHistoryView.丝专上一丁一丙丌丗(丝丘丑业丛万丞丌丝:  this._duelPlayers);
            PGCompany.MatchHistoryView.丝专上一丁一丙丌丗(丝丘丑业丛万丞丌丝:  this._battleRoyalePlayers);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadingGO, 丏业丟一东丂东丘丛:  false);
        }
        public MatchHistoryView()
        {
            this._duelPlayers = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._deathmatchPlayers = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._blueTeamPlayers = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._redTeamPlayers = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this._battleRoyalePlayers = new System.Collections.Generic.List<UnityEngine.GameObject>();
            UnityEngine.Color val_6 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "00FF00");
            this.上丄不且七丁丈丏丌 = val_6;
            mem[1152921555768075692] = val_6.g;
            mem[1152921555768075696] = val_6.b;
            mem[1152921555768075700] = val_6.a;
            UnityEngine.Color val_7 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "FFB100");
            this.丝且丕丐丂丙丁下丛 = val_7;
            mem[1152921555768075708] = val_7.g;
            mem[1152921555768075712] = val_7.b;
            mem[1152921555768075716] = val_7.a;
            UnityEngine.Color val_8 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  "FF002E");
            this.丁不一丌专三丐丄丏 = val_8;
            mem[1152921555768075724] = val_8.g;
            mem[1152921555768075728] = val_8.b;
            mem[1152921555768075732] = val_8.a;
        }
        internal static void 丝专上一丁一丙丌丗(System.Collections.Generic.List<UnityEngine.GameObject> 丝丘丑业丛万丞丌丝)
        {
            var val_9;
            UnityEngine.Object val_10;
            val_9 = 0;
            goto label_1;
            label_16:
            val_10 = 丝丘丑业丛万丞丌丝.Item[0];
            if(val_10 != 0)
            {
                    val_10 = 丝丘丑业丛万丞丌丝.Item[0];
                if(val_10.activeInHierarchy != false)
            {
                    val_10 = 丝丘丑业丛万丞丌丝.Item[0].GetComponent<PGCompany.MatchHistoryPlayerView>();
                if(val_10 != 0)
            {
                    val_10.万专丄丂丂丝与丝丒();
            }
            
            }
            
            }
            
            val_9 = 1;
            label_1:
            if(val_9 < 丝丘丑业丛万丞丌丝.Count)
            {
                goto label_16;
            }
        
        }
    
    }

}
