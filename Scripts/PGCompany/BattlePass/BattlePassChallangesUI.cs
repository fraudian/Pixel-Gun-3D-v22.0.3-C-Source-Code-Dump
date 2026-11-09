using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassChallangesUI : MonoBehaviour
    {
        // Fields
        internal static int 丂丕丈一丂万丌下一;
        private static PGCompany.BattlePass.BattlePassChallangesUI 丝业丆丁业三丈丟东;
        private static int 丆丗丆不丒丂丏业丟;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private BattlePassRootUI.丝丂丅丝丟丞丐上与 不一丐且丗专丙丈丞;
        internal static int 不丌丘丅世丄丌丌不;
        private Rilisoft.CharacterHelper _characterHelper;
        private PGCompany.BattlePass.BPPhoenixHandler _phoenixHandler;
        private UITable _tabsTable;
        private System.Collections.Generic.List<PGCompany.BattlePass.BattlePassChallengesTab> _tabs;
        private System.Collections.Generic.List<PGCompany.BattlePass.BattlePassChallengesView> _contentViews;
        private UnityEngine.GameObject _backBtn;
        private UnityEngine.GameObject _backConnectSceneBtn;
        private UnityEngine.GameObject _bpBtn;
        private UILabel _currentLevelLabel;
        private UILabel _currentProgressLabel;
        private UISprite _currentProgressSprite;
        private UnityEngine.GameObject _woodenShield;
        private UnityEngine.GameObject _goldenShield;
        private UnityEngine.GameObject _bpRewardsBadge;
        private UILabel _bpRewardsRewardsCountLabel;
        private PGCompany.BattlePass.BPDailyRewardView _dailyReward;
        private UnityEngine.Transform _particleAtraktorTarget;
        
        // Properties
        internal static int 丈丌丛丆东丌丂下丂 { get; set; }
        
        // Methods
        internal static int 丗丞下丒丞丒丘丌丆()
        {
            null = null;
            return (int)PGCompany.BattlePass.BattlePassChallangesUI.丆丗丆不丒丂丏业丟;
        }
        internal static void 丟丄丐一七东不丁且(int 丙业与丙丗丝不丈东)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丆丗丆不丒丂丏业丟 = 丙业与丙丗丝不丈东;
            if(PGCompany.BattlePass.BattlePassChallangesUI.丝业丆丁业三丈丟东 == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丝业丆丁业三丈丟东.GoToTab(丕与丏丌下丁专丌丙:  丙业与丙丗丝不丈东);
        }
        private void OnEnable()
        {
            var val_9;
            BPChallengesController.丛丄丂与丄丈丟丂丒(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallangesUI::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)));
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            val_9 = null;
            if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
            {
                    this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassChallangesUI::Back()), 与且专丈不万东一万:  0);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._phoenixHandler, 丏业丟一东丂东丘丛:  true);
            if(this._dailyReward == 0)
            {
                    return;
            }
            
            this._dailyReward.SwithOn(丗东三与上上丂丟丅:  this._particleAtraktorTarget);
        }
        private void OnDisable()
        {
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallangesUI::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)));
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._phoenixHandler, 丏业丟一东丂东丘丛:  false);
            if(this._dailyReward == 0)
            {
                    return;
            }
            
            this._dailyReward.gameObject.SetActive(value:  false);
        }
        private void OnDestroy()
        {
            BPChallengesController.丈丁丟专丕七上不七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallangesUI::丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)));
        }
        private void 丝丏丈丏丑丑东丌丆(int 且丂七下丙丆三丐三)
        {
            var val_1 = null;
            if(PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 == 且丂七下丙丆三丐三)
            {
                    PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 = 0;
            }
            
            this.Show(丈丗与丞一上且上上:  this.不一丐且丗专丙丈丞);
        }
        public void Show(BattlePassRootUI.丝丂丅丝丟丞丐上与 丈丗与丞一上且上上)
        {
            var val_4;
            PGCompany.BattlePass.BattlePassChallangesUI val_22;
            var val_23;
            System.Collections.Generic.List<PGCompany.BattlePass.BattlePassChallengesTab> val_24;
            var val_25;
            UnityEngine.GameObject val_26;
            var val_27;
            var val_28;
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            val_22 = this;
            val_23 = null;
            val_23 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丝业丆丁业三丈丟东 = val_22;
            this.不一丐且丗专丙丈丞 = 丈丗与丞一上且上上;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._characterHelper, 丏业丟一东丂东丘丛:  true);
            this._characterHelper.CharacterVisible = true;
            this.UpdateView();
            val_24 = this._tabs;
            List.Enumerator<T> val_2 = val_24.GetEnumerator();
            label_10:
            if(((-401540288) & 1) == 0)
            {
                goto label_7;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            System.Action<PGCompany.BattlePass.BattlePassChallengesTab> val_6 = new System.Action<PGCompany.BattlePass.BattlePassChallengesTab>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallangesUI::丟丗丞丝丅丏不丁丟(PGCompany.BattlePass.BattlePassChallengesTab 丑丞丘东三丂且下七));
            val_5.remove_Clicked(丙业与丙丗丝不丈东:  null);
            System.Action<PGCompany.BattlePass.BattlePassChallengesTab> val_7 = new System.Action<PGCompany.BattlePass.BattlePassChallengesTab>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallangesUI::丟丗丞丝丅丏不丁丟(PGCompany.BattlePass.BattlePassChallengesTab 丑丞丘东三丂且下七));
            val_5.add_Clicked(丙业与丙丗丝不丈东:  null);
            goto label_10;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_25 = 1152921505680113664;
            if(丈丗与丞一上且上上 == 2)
            {
                goto label_17;
            }
            
            if(丈丗与丞一上且上上 != 3)
            {
                goto label_18;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backBtn, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backConnectSceneBtn, 丏业丟一东丂东丘丛:  false);
            val_26 = this._bpBtn;
            val_27 = 0;
            goto label_21;
            label_17:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backBtn, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backConnectSceneBtn, 丏业丟一东丂东丘丛:  true);
            val_26 = this._bpBtn;
            val_27 = 1;
            label_21:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_26, 丏业丟一东丂东丘丛:  true);
            label_18:
            val_28 = null;
            val_29 = PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一;
            if(val_29 <= 0)
            {
                goto label_26;
            }
            
            val_29 = PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一;
            int val_8 = this.下丏上丑不丐一专丛(且丂七下丙丆三丐三:  val_29);
            if((val_8 & 2147483648) == 0)
            {
                goto label_46;
            }
            
            goto label_49;
            label_26:
            val_30 = 0;
            goto label_31;
            label_36:
            val_24 = this._contentViews.Item[0];
            if(val_24.UngivenChallengesCount >= 1)
            {
                goto label_46;
            }
            
            val_30 = 1;
            label_31:
            val_24 = this._contentViews;
            if(val_30 < val_24.Count)
            {
                goto label_36;
            }
            
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_13 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if((val_13 == null) || (val_13.丐丞上丒七丞丁丙丕() == false))
            {
                goto label_49;
            }
            
            val_31 = 0;
            goto label_40;
            label_48:
            PGCompany.BattlePass.BattlePassChallengesView val_15 = this._contentViews.Item[0];
            if(val_15 == null)
            {
                goto label_43;
            }
            
            val_24 = val_15.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万();
            if(val_24.世丑丐丅丆丂丘不丁() == false)
            {
                goto label_46;
            }
            
            label_43:
            val_31 = 1;
            label_40:
            val_24 = this._contentViews;
            if(val_31 < val_24.Count)
            {
                goto label_48;
            }
            
            goto label_49;
            label_46:
            val_32 = null;
            val_32 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丆丗丆不丒丂丏业丟 = val_8;
            label_49:
            val_33 = null;
            val_33 = null;
            if((PGCompany.BattlePass.BattlePassChallangesUI.丆丗丆不丒丂丏业丟 & 2147483648) != 0)
            {
                    val_33 = null;
                PGCompany.BattlePass.BattlePassChallangesUI.丆丗丆不丒丂丏业丟 = 0;
            }
            
            this.GoToTab(丕与丏丌下丁专丌丙:  PGCompany.BattlePass.BattlePassChallangesUI.丗丞下丒丞丒丘丌丆());
            if(this._phoenixHandler == 0)
            {
                    return;
            }
            
            val_22 = this._phoenixHandler;
            val_22.Setup();
        }
        private int 下丏上丑不丐一专丛(int 且丂七下丙丆三丐三)
        {
            var val_3;
            if(且丂七下丙丆三丐三 < 1)
            {
                    return 0;
            }
            
            val_3 = 0;
            goto label_2;
            label_7:
            if((this._contentViews.Item[0] & 1) != 0)
            {
                    return 0;
            }
            
            val_3 = 1;
            label_2:
            if(val_3 < this._contentViews.Count)
            {
                goto label_7;
            }
            
            return 0;
        }
        public void UpdateView()
        {
            var val_26;
            UnityEngine.Transform val_47;
            int val_48;
            var val_49;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_51;
            var val_52;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄> val_54;
            var val_55;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_57;
            string val_58;
            int val_59;
            UnityEngine.GameObject val_60;
            var val_61;
            var val_62;
            var val_63;
            val_47 = this;
            val_48 = 1152921505680220160;
            val_49 = null;
            val_49 = null;
            val_51 = BattlePassChallangesUI.<>c.<>9__15_0;
            if(val_51 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_3 = null;
                val_51 = val_3;
                val_3 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassChallangesUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassChallangesUI.<>c::丛三丕丛世下丆丙丁(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallangesUI.<>c.<>9__15_0 = val_51;
            }
            
            val_52 = null;
            val_52 = null;
            val_54 = BattlePassChallangesUI.<>c.<>9__15_1;
            if(val_54 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄> val_5 = null;
                val_54 = val_5;
                val_5 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄>(object:  BattlePassChallangesUI.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄 BattlePassChallangesUI.<>c::业且丒三丞丕丌万一(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallangesUI.<>c.<>9__15_1 = val_54;
            }
            
            val_55 = null;
            val_55 = null;
            val_57 = BattlePassChallangesUI.<>c.<>9__15_2;
            if(val_57 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32> val_7 = null;
                val_57 = val_7;
                val_7 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(object:  BattlePassChallangesUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BattlePassChallangesUI.<>c::丒丒七业丘世且丌七(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassChallangesUI.<>c.<>9__15_2 = val_57;
            }
            
            System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  System.Linq.Enumerable.ThenBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Int32>(source:  System.Linq.Enumerable.OrderBy<PGCompany.BattlePass.三丛上丁丗丌丆丌东, PGCompany.BattlePass.丐丘丌丙丝丏丑丑丄>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_3), keySelector:  val_5), keySelector:  val_7));
            if(val_9.Count < 3)
            {
                goto label_75;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_11 = val_9.Item[2];
            if(val_11 == null)
            {
                goto label_75;
            }
            
            val_48 = 1152921536401754000;
            System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  val_11.丈丏丁东上与东丙丕());
            if(val_13 == null)
            {
                goto label_23;
            }
            
            BattlePassChallangesUI.丕丛业丁丏下一七丘 val_14 = new BattlePassChallangesUI.丕丛业丁丏下一七丘();
            PGCompany.BattlePass.BPData val_17 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丁专丗万三上丟三丆();
            if(val_14 != null)
            {
                    val_58 = val_14;
                .丙丅丈丑专丂一丘东 = val_17.PresettedChallangesAvatar;
            }
            else
            {
                    val_58 = 16;
                mem[16] = val_17.PresettedChallangesAvatar;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_58)) != false)
            {
                    mem[16] = "avatar_cybercop";
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_13, predicate:  new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_14, method:  System.Boolean BattlePassChallangesUI.丕丛业丁丏下一七丘::丝下东三上丕丁专丙(Rilisoft.OfferItem 东七上世万下丗丄丛)))) != true)
            {
                    val_13.Add(item:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  56, 丞丅上丏丂且下丅与:  mem[16], 丌丒丝东丌下丕丁丅:  1));
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_23 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            List.Enumerator<T> val_24 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  val_13).GetEnumerator();
            val_48 = 1152921525755361760;
            label_53:
            if(((-401014096) & 1) == 0)
            {
                goto label_38;
            }
            
            string val_27 = val_26.丐丏七丌丕丗业且上();
            if(val_27.Type != 1080)
            {
                goto label_40;
            }
            
            int val_30 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_27.Id);
            if((val_30 & 2147483648) != 0)
            {
                goto label_44;
            }
            
            if(val_30 == 200000)
            {
                goto label_53;
            }
            
            val_23.Add(item:  val_27);
            goto label_53;
            label_40:
            if(val_27.Type != 10)
            {
                goto label_53;
            }
            
            val_23.Add(item:  val_27);
            goto label_53;
            label_44:
            val_23.Add(item:  val_27);
            goto label_53;
            label_38:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_57 = this._characterHelper;
            bool val_32 = BattlePassRootUI.三与丑不且丟丅一丞(丞丛丈丝不丛丒丌丐:  val_57, 上业丟世三与七七三:  val_23, 丏丏三七丌丈下三丁:  false, 丐丁三世上下丄丘丐:  true, 丒丈七三丄丞丐丝丂:  0);
            label_23:
            if(this._bpRewardsBadge != 0)
            {
                    System.Collections.Generic.IEnumerable<PGCompany.BattlePass.BPReward> val_36 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丑万丘丈业丁丟丏七();
                if(val_36 != null)
            {
                    val_59 = System.Linq.Enumerable.Count<PGCompany.BattlePass.BPReward>(source:  val_36);
            }
            else
            {
                    val_59 = val_59;
            }
            
                val_57 = this._bpRewardsBadge;
                val_48 = val_59;
                val_48 = val_59;
                val_48 = val_59;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_57, 丏业丟一东丂东丘丛:  (val_59 > 0) ? 1 : 0);
                if(val_48 >= 1)
            {
                    val_57 = val_59.ToString();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._bpRewardsRewardsCountLabel, 丕丗丘丑丛与丑业丒:  val_57);
            }
            
            }
            
            label_75:
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_41 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_41 != null)
            {
                    if(val_41.专丟专一丒且丘与丌() == 100)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._woodenShield, 丏业丟一东丂东丘丛:  false);
                val_60 = this._goldenShield;
                val_61 = 1;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._woodenShield, 丏业丟一东丂东丘丛:  true);
                val_60 = this._goldenShield;
                val_61 = 0;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_60, 丏业丟一东丂东丘丛:  false);
            }
            
            val_62 = null;
            if(PGCompany.BattlePass.BPTutorialController.丌丆丛专东丒与丟丞() == false)
            {
                    return;
            }
            
            val_63 = null;
            if(PGCompany.BattlePass.BPTutorialController.丝丛三七世丙丂专丈() != 6)
            {
                    return;
            }
            
            val_47 = this.transform;
            PGCompany.BattlePass.BPTutorialController.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  val_47);
        }
        public void ToBattlePass()
        {
            var val_4;
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 4;
            BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  1);
        }
        public void Back()
        {
            var val_6;
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            BattlePassRootUI.丂丑丌且丄丞丝七上 = (this.不一丐且丗专丙丈丞 != 3) ? 4 : (0 + 1);
            BattlePassRootUI.丑七不且上丗丁一世().ChangeState(专丂丕丗丗东世丞下:  (this.不一丐且丗专丙丈丞 == 3) ? 1 : 0);
        }
        public void Hide()
        {
            object val_5;
            var val_6;
            val_5 = this;
            val_6 = null;
            val_6 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丝业丆丁业三丈丟东 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._characterHelper, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            List.Enumerator<T> val_2 = this._tabs.GetEnumerator();
            label_8:
            if(((-400444600) & 1) == 0)
            {
                goto label_6;
            }
            
            System.Action<PGCompany.BattlePass.BattlePassChallengesTab> val_4 = new System.Action<PGCompany.BattlePass.BattlePassChallengesTab>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallangesUI::丟丗丞丝丅丏不丁丟(PGCompany.BattlePass.BattlePassChallengesTab 丑丞丘东三丂且下七));
            0.丐丏七丌丕丗业且上().remove_Clicked(丙业与丙丗丝不丈东:  null);
            goto label_8;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丟丗丞丝丅丏不丁丟(PGCompany.BattlePass.BattlePassChallengesTab 丑丞丘东三丂且下七)
        {
            var val_3;
            if(丑丞丘东三丂且下七 == 0)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 = 0;
            int val_2 = this._tabs.IndexOf(item:  丑丞丘东三丂且下七);
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            this.GoToTab(丕与丏丌下丁专丌丙:  val_2);
        }
        public void GoToTab(int 丕与丏丌下丁专丌丙)
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = 0;
            goto label_1;
            label_17:
            PGCompany.BattlePass.BattlePassChallengesTab val_1 = this._tabs.Item[0];
            val_1.Selected = (丕与丏丌下丁专丌丙 == val_6) ? 1 : 0;
            PGCompany.BattlePass.BattlePassChallengesView val_3 = this._contentViews.Item[0];
            val_1.RewardsCount = val_3.UngivenChallengesCount;
            if(丕与丏丌下丁专丌丙 != val_6)
            {
                goto label_7;
            }
            
            val_7 = null;
            val_7 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.丆丗丆不丒丂丏业丟 = 丕与丏丌下丁专丌丙;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  true);
            if(val_3 == null)
            {
                goto label_12;
            }
            
            val_3.下万丑且东丑丅丟专();
            goto label_13;
            label_7:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_3, 丏业丟一东丂东丘丛:  false);
            label_13:
            val_6 = 1;
            label_1:
            if(val_6 < this._tabs.Count)
            {
                goto label_17;
            }
            
            this._tabsTable.repositionNow = true;
            val_8 = null;
            val_8 = null;
            PGCompany.BattlePass.BattlePassChallangesUI.不丌丘丅世丄丌丌不 = 0;
            return;
            label_12:
        }
        public BattlePassChallangesUI()
        {
        
        }
        private static BattlePassChallangesUI()
        {
            PGCompany.BattlePass.BattlePassChallangesUI.丂丕丈一丂万丌下一 = 0;
            PGCompany.BattlePass.BattlePassChallangesUI.不丌丘丅世丄丌丌不 = 0;
        }
    
    }

}
