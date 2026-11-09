using UnityEngine;

namespace Rilisoft
{
    internal class LeaderboardsMiniGameController : MonoBehaviour
    {
        // Fields
        private System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 丈下七丑专丘丟东丒;
        private System.Nullable<Rilisoft.丄丄丑丒丐上丞万下> 丄丝不上东丞丏丞丅;
        private bool 丄一丈三丂专上一世;
        private int 业丌丐丏丂丕七业丐;
        private bool 丗丈且万业丛万丝下;
        private System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> 丟丈七与丁丌七丅一;
        private UIButton _friendsButton;
        private UIButton _topButton;
        private UIScrollView _scrollView;
        private Rilisoft.BetterWrapContent _betterWrapContent;
        private Rilisoft.LeaderboardsMiniGameCell _baseCell;
        
        // Properties
        private Rilisoft.UIScrollManager 且万丏不下丙丁丑丛 { get; }
        internal System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 丞丒世丛丑丟万丟业 { get; set; }
        internal System.Nullable<Rilisoft.丄丄丑丒丐上丞万下> 上丟丂与专丟与丟专 { get; set; }
        
        // Methods
        private Rilisoft.UIScrollManager 与不丘万丈丆丁上丛()
        {
            return 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.UIScrollManager>(丝三丁东丈丒世丅业:  this._scrollView.gameObject);
        }
        internal System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 丘且丐不与且三万丟()
        {
            return (System.Nullable<Rilisoft.七丕丟丏三丈一丄世>)this.丈下七丑专丘丟东丒;
        }
        internal void 丗丟丏不下丆不与专(System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 丙业与丙丗丝不丈东)
        {
            if(this.丈下七丑专丘丟东丒.丙东专丂世丈丏丁丂() == 丙业与丙丗丝不丈东.HasValue.丙东专丂世丈丏丁丂())
            {
                    if((16 & 1) == 0)
            {
                    return;
            }
            
            }
            
            this.丈下七丑专丘丟东丒 = 丙业与丙丗丝不丈东;
            Rilisoft.三东丒丝丞下丛且下.丏丑万丌丘万三丙与(上且丗一丏丏万丅丌:  new System.Nullable<Rilisoft.七丕丟丏三丈一丄世>() {HasValue = 丙业与丙丗丝不丈东.HasValue});
            this.UpdateView();
        }
        internal System.Nullable<Rilisoft.丄丄丑丒丐上丞万下> 专丈丗七丆不专丕丗()
        {
            return (System.Nullable<Rilisoft.丄丄丑丒丐上丞万下>)this.丄丝不上东丞丏丞丅;
        }
        internal void 丂不丕丌丝丄丆万丒(System.Nullable<Rilisoft.丄丄丑丒丐上丞万下> 丙业与丙丗丝不丈东)
        {
            if(this.丄丝不上东丞丏丞丅.丙东专丂世丈丏丁丂() == 丙业与丙丗丝不丈东.HasValue.丙东专丂世丈丏丁丂())
            {
                    if((240 & 1) == 0)
            {
                    return;
            }
            
            }
            
            this.丄丝不上东丞丏丞丅 = 丙业与丙丗丝不丈东;
            if((丙业与丙丗丝不丈东.HasValue.丙东专丂世丈丏丁丂() != 0) || (((-249353608) & 1) == 0))
            {
                goto label_4;
            }
            
            if(this._topButton != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            if((this.丄丝不上东丞丏丞丅.丙东专丂世丈丏丁丂() != 1) || (((-249353608) & 1) == 0))
            {
                goto label_9;
            }
            
            label_7:
            label_9:
            Rilisoft.三东丒丝丞下丛且下.丏丑万丌丘万三丙与(上且丗一丏丏万丅丌:  new System.Nullable<Rilisoft.七丕丟丏三丈一丄世>() {HasValue = this.丈下七丑专丘丟东丒});
            this.UpdateView();
        }
        private void Awake()
        {
            Rilisoft.三东丒丝丞下丛且下.丘丄丅丛丏丕丒丆丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LeaderboardsMiniGameController::丌不三丟东七丞丗一()));
            Rilisoft.三东丒丝丞下丛且下.丏丑万丌丘万三丙与(上且丗一丏丏万丅丌:  new System.Nullable<Rilisoft.七丕丟丏三丈一丄世>() {HasValue = false});
        }
        private void OnDestroy()
        {
            Rilisoft.三东丒丝丞下丛且下.丕丞上丅丞丁丌丕丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LeaderboardsMiniGameController::丌不三丟东七丞丗一()));
        }
        private void 丌不三丟东七丞丗一()
        {
            this.UpdateView();
        }
        public void UpdateView()
        {
            if(((-248870744) & 1) == 0)
            {
                    this.丂不丕丌丝丄丆万丒(丙业与丙丗丝不丈东:  new System.Nullable<Rilisoft.丄丄丑丒丐上丞万下>() {HasValue = false});
            }
            
            this.不下丌丆东丑丈丕丝();
            this.丄一丈三丂专上一世 = true;
        }
        private void LateUpdate()
        {
            if(this.丄一丈三丂专上一世 == false)
            {
                    return;
            }
            
            this.丄一丈三丂专上一世 = false;
            this.StopCoroutine(routine:  this.世丒东丘丞丁丂三丈());
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.世丒东丘丞丁丂三丈());
        }
        private System.Collections.IEnumerator 世丒东丘丞丁丂三丈()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LeaderboardsMiniGameController.世三丝丙丆丅丗三世();
        }
        private void 不下丌丆东丑丈丕丝()
        {
            System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> val_41;
            System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> val_42;
            var val_43;
            Rilisoft.丄丄丑丒丐上丞万下 val_44;
            var val_45;
            Rilisoft.LeaderboardsMiniGameDataRow val_46;
            var val_47;
            var val_48;
            System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32> val_50;
            var val_51;
            var val_52;
            var val_53;
            System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32> val_55;
            var val_56;
            System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Boolean> val_58;
            int val_59;
            val_41 = this;
            val_42 = this.丟丈七与丁丌七丅一;
            if(val_42 == null)
            {
                    System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> val_1 = null;
                val_42 = val_1;
                val_1 = new System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>();
                this.丟丈七与丁丌七丅一 = val_42;
            }
            
            val_1.Clear();
            val_43 = 1152921524478161024;
            val_44;
            val_45 = 1152921543013054064;
            this.丟丈七与丁丌七丅一 = System.Linq.Enumerable.ToList<Rilisoft.LeaderboardsMiniGameDataRow>(source:  Rilisoft.三东丒丝丞下丛且下.丙丘丝七业丟丁与丛(上且丗一丏丏万丅丌:  this.丈下七丑专丘丟东丒, 丁丅丈丌丟世丗丗丟:  this.丄丝不上东丞丏丞丅));
            this.业丌丐丏丂丕七业丐 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
            {
                    return;
            }
            
            .丄丒且丙三丆丟与丏 = System.Convert.ToInt32(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), provider:  System.Globalization.CultureInfo.InvariantCulture);
            val_46 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LeaderboardsMiniGameDataRow>(source:  this.丟丈七与丁丌七丅一, predicate:  new System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Boolean>(object:  new LeaderboardsMiniGameController.丒业丛丟专丛丒与东(), method:  System.Boolean LeaderboardsMiniGameController.丒业丛丟专丛丒与东::丙丘世不下丅七丛丒(Rilisoft.LeaderboardsMiniGameDataRow 东七上世万下丗丄丛)));
            if(val_46 == null)
            {
                    Rilisoft.LeaderboardsMiniGameDataRow val_12 = null;
                val_46 = val_12;
                val_12 = new Rilisoft.LeaderboardsMiniGameDataRow();
                .Id = (LeaderboardsMiniGameController.丒业丛丟专丛丒与东)[1152921543013316064].丄丒且丙三丆丟与丏;
                .PlayerName = ProfileController.丆三丂丂丆上丆丕专();
                if(this.丟丈七与丁丌七丅一.Count >= 100)
            {
                    if(this.丟丈七与丁丌七丅一 != null)
            {
                    val_47 = this.丟丈七与丁丌七丅一.Count;
            }
            else
            {
                    val_47 = 0.Count;
            }
            
                this.丟丈七与丁丌七丅一.RemoveAt(index:  val_47 - 1);
            }
            
                this.丟丈七与丁丌七丅一.Add(item:  val_12);
            }
            
            .Scores = Rilisoft.丒与上丌丄不三丝与.丑七不且上丗丁一世().丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  this.丈下七丑专丘丟东丒);
            if((-248301160) <= 3)
            {
                goto label_25;
            }
            
            if((-248301160) > 38)
            {
                goto label_46;
            }
            
            if(0 != 0)
            {
                goto label_27;
            }
            
            if(0 == 0)
            {
                goto label_46;
            }
            
            val_48 = null;
            val_48 = null;
            val_50 = LeaderboardsMiniGameController.<>c.<>9__20_2;
            if(val_50 == null)
            {
                    System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32> val_20 = null;
                val_50 = val_20;
                val_20 = new System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32>(object:  LeaderboardsMiniGameController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LeaderboardsMiniGameController.<>c::丟丞丞业丏丁丗七丆(Rilisoft.LeaderboardsMiniGameDataRow 丐丆丂丒丁万丈丛丅));
                LeaderboardsMiniGameController.<>c.<>9__20_2 = val_50;
            }
            
            val_51 = 1152921504616005632;
            System.Collections.Generic.List<TSource> val_22 = System.Linq.Enumerable.ToList<Rilisoft.LeaderboardsMiniGameDataRow>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32>(source:  this.丟丈七与丁丌七丅一, keySelector:  val_20));
            this.丟丈七与丁丌七丅一 = val_22;
            if(val_22.Count < 2)
            {
                goto label_45;
            }
            
            goto label_36;
            label_44:
            if(0 >= this.丟丈七与丁丌七丅一.Count)
            {
                goto label_45;
            }
            
            Rilisoft.LeaderboardsMiniGameDataRow val_25 = this.丟丈七与丁丌七丅一.Item[0];
            bool val_26 = this.丟丈七与丁丌七丅一.Remove(item:  val_25);
            this.丟丈七与丁丌七丅一.Add(item:  val_25);
            label_36:
            Rilisoft.LeaderboardsMiniGameDataRow val_27 = this.丟丈七与丁丌七丅一.Item[0];
            if(val_27.Scores <= 0)
            {
                goto label_44;
            }
            
            goto label_45;
            label_25:
            if((-248301158) != 3)
            {
                goto label_46;
            }
            
            label_27:
            val_52 = 1152921505464619008;
            val_53 = null;
            val_53 = null;
            val_55 = LeaderboardsMiniGameController.<>c.<>9__20_1;
            if(val_55 == null)
            {
                    System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32> val_28 = null;
                val_55 = val_28;
                val_28 = new System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32>(object:  LeaderboardsMiniGameController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LeaderboardsMiniGameController.<>c::丒一与与丒丟丂业丂(Rilisoft.LeaderboardsMiniGameDataRow 丐丆丂丒丁万丈丛丅));
                LeaderboardsMiniGameController.<>c.<>9__20_1 = val_55;
            }
            
            System.Collections.Generic.List<TSource> val_30 = System.Linq.Enumerable.ToList<Rilisoft.LeaderboardsMiniGameDataRow>(source:  System.Linq.Enumerable.OrderByDescending<Rilisoft.LeaderboardsMiniGameDataRow, System.Int32>(source:  this.丟丈七与丁丌七丅一, keySelector:  val_28));
            this.丟丈七与丁丌七丅一 = val_30;
            if(val_30 != null)
            {
                goto label_69;
            }
            
            label_70:
            label_69:
            val_45 = 1152921543013187184;
            this.业丌丐丏丂丕七业丐 = val_30.IndexOf(item:  val_12);
            if((Rilisoft.LeaderboardsMiniGameDataRow)[1152921543013340640].Scores > 0)
            {
                goto label_53;
            }
            
            bool val_32 = this.丟丈七与丁丌七丅一.Remove(item:  val_12);
            val_52 = 1152921505464619008;
            val_56 = null;
            val_56 = null;
            val_58 = LeaderboardsMiniGameController.<>c.<>9__20_3;
            if(val_58 == null)
            {
                    System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Boolean> val_33 = null;
                val_58 = val_33;
                val_33 = new System.Func<Rilisoft.LeaderboardsMiniGameDataRow, System.Boolean>(object:  LeaderboardsMiniGameController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LeaderboardsMiniGameController.<>c::丅且丆丂业丕不丅丒(Rilisoft.LeaderboardsMiniGameDataRow 七丞丙丒三丕且丌丟));
                LeaderboardsMiniGameController.<>c.<>9__20_3 = val_58;
            }
            
            Rilisoft.LeaderboardsMiniGameDataRow val_34 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LeaderboardsMiniGameDataRow>(source:  this.丟丈七与丁丌七丅一, predicate:  val_33);
            if(val_34 == null)
            {
                goto label_60;
            }
            
            if(this.丟丈七与丁丌七丅一 == null)
            {
                goto label_61;
            }
            
            val_59 = this.丟丈七与丁丌七丅一.IndexOf(item:  val_34);
            goto label_62;
            label_46:
            object[] val_36 = new object[1];
            val_36[0] = this.丈下七丑专丘丟东丒;
            val_51 = 1152921504616005632;
            UnityEngine.Debug.LogErrorFormat(format:  "fail sort items, unknown GameMode: \'{0}\'", args:  val_36);
            label_45:
            if(this.丟丈七与丁丌七丅一 != null)
            {
                goto label_69;
            }
            
            goto label_70;
            label_60:
            this.丟丈七与丁丌七丅一.Add(item:  val_12);
            goto label_72;
            label_61:
            val_59 = 0.IndexOf(item:  val_34);
            label_62:
            this.丟丈七与丁丌七丅一.Insert(index:  val_59, item:  val_12);
            label_72:
            this.业丌丐丏丂丕七业丐 = this.丟丈七与丁丌七丅一.IndexOf(item:  val_12);
            label_53:
            val_41 = this.丟丈七与丁丌七丅一;
            List.Enumerator<T> val_39 = val_41.GetEnumerator();
            val_44 = 1152921543013232416;
            goto label_75;
            label_77:
            val_41 = 0.丐丏七丌丕丗业且上();
            mem2[0] = 1;
            label_75:
            if(((-248301192) & 1) != 0)
            {
                goto label_77;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 业业专丌不业世一丞(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            UnityEngine.GameObject val_6 = 丕一一丆丌丝丕业万;
            if((丘丒丌下丕专且七专 & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.丟丈七与丁丌七丅一.Count <= 丘丒丌下丕专且七专)
            {
                    return;
            }
            
            val_6 = val_6.GetComponent<Rilisoft.LeaderboardsMiniGameCell>();
            val_6.SetData(一丐丗丁丞丆丅丟丄:  this.丟丈七与丁丌七丅一.Item[丘丒丌下丕专且七专], 上且丗一丏丏万丅丌:  this.丈下七丑专丘丟东丒, 丏丒丒丘丑丂业丅丕:  (this.业丌丐丏丂丕七业丐 == 丘丒丌下丕专且七专) ? 1 : 0, 丙上专丛上丛一业丙:  new System.Action<Rilisoft.LeaderboardsMiniGameCell>(object:  this, method:  System.Void Rilisoft.LeaderboardsMiniGameController::丝丈丆世且三与丝东(Rilisoft.LeaderboardsMiniGameCell 丌丝万上丅丒一丈丘)));
        }
        private void 丝丈丆世且三与丝东(Rilisoft.LeaderboardsMiniGameCell 丌丝万上丅丒一丈丘)
        {
            Rilisoft.LeaderboardsMiniGameDataRow val_11;
            var val_12;
            System.Action<System.Boolean> val_14;
            var val_15;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
            {
                    return;
            }
            
            val_11 = 丌丝万上丅丒一丈丘.<丅不丙丌丟业一业丂>k__BackingField;
            if((丌丝万上丅丒一丈丘.<丅不丙丌丟业一业丂>k__BackingField.Id) == (System.Convert.ToInt32(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), provider:  System.Globalization.CultureInfo.InvariantCulture)))
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            val_14 = LeaderboardsMiniGameController.<>c.<>9__22_0;
            if(val_14 == null)
            {
                    System.Action<System.Boolean> val_6 = null;
                val_14 = val_6;
                val_6 = new System.Action<System.Boolean>(object:  LeaderboardsMiniGameController.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LeaderboardsMiniGameController.<>c::下上丐丌世丕丅东七(bool 丌丗丏丏丛东专丁且));
                LeaderboardsMiniGameController.<>c.<>9__22_0 = val_14;
            }
            
            FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  丌丝万上丅丒一丈丘.<丅不丙丌丟业一业丂>k__BackingField.Id.ToString(), 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  val_6);
            val_15 = static_value_081DACA8;
            val_15 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.gameObject.SetActive(value:  false);
            MainMenuHeroCamera.丑七不且上丗丁一世().丝专丅业丗丁业世三().enabled = true;
        }
        public void U_ShowFriends()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.丂不丕丌丝丄丆万丒(丙业与丙丗丝不丈东:  new System.Nullable<Rilisoft.丄丄丑丒丐上丞万下>() {HasValue = false});
            this.UpdateView();
        }
        public void U_ShowTop()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
            this.丂不丕丌丝丄丆万丒(丙业与丙丗丝不丈东:  new System.Nullable<Rilisoft.丄丄丑丒丐上丞万下>() {HasValue = false});
            this.UpdateView();
        }
        public LeaderboardsMiniGameController()
        {
        
        }
        private int 丘世下丐丞丅且三丛()
        {
            int val_1 = this.丟丈七与丁丌七丅一.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
