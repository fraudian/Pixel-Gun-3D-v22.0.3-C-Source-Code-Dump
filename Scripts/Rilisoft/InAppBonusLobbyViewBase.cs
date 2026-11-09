using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyViewBase : MonoBehaviour
    {
        // Fields
        private Rilisoft.BonusData 丁丘丄丕下专东七不;
        protected Rilisoft.BonusData 且丝世丟丈丈三丆丙;
        
        // Properties
        public Rilisoft.BonusData 丞丑且东丌与丏丏丁 { get; }
        
        // Methods
        public Rilisoft.BonusData get_Data()
        {
            return (Rilisoft.BonusData)this.丁丘丄丕下专东七不;
        }
        private void Awake()
        {
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.InAppBonusLobbyViewBase::丞万专丒丁丒丅丙丆()));
            WeaponManager.丛丞三丙且丁丑丄丗(丙业与丙丗丝不丈东:  new System.Action<System.String, CategoryNames>(object:  this, method:  System.Void Rilisoft.InAppBonusLobbyViewBase::上一丅世丐一世一上(string 丛丆东与丑丞丅丝专, CategoryNames 不丁丌丐业丑丟且不)));
        }
        protected virtual void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        protected virtual void OnDisable()
        {
            this.StopCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private void OnDestroy()
        {
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.InAppBonusLobbyViewBase::丞万专丒丁丒丅丙丆()));
            WeaponManager.丕丝丟丘丛与丆万七(丙业与丙丗丝不丈东:  new System.Action<System.String, CategoryNames>(object:  this, method:  System.Void Rilisoft.InAppBonusLobbyViewBase::上一丅世丐一世一上(string 丛丆东与丑丞丅丝专, CategoryNames 不丁丌丐业丑丟且不)));
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new InAppBonusLobbyViewBase.一一丑业丘丗丐丁丌();
        }
        protected virtual void 丗丌丂丙丈丆不丂七()
        {
        
        }
        private void 丞万专丒丁丒丅丙丆()
        {
            goto typeof(Rilisoft.InAppBonusLobbyViewBase).__il2cppRuntimeField_198;
        }
        private void 上一丅世丐一世一上(string 丛丆东与丑丞丅丝专, CategoryNames 不丁丌丐业丑丟且不)
        {
            goto typeof(Rilisoft.InAppBonusLobbyViewBase).__il2cppRuntimeField_198;
        }
        public void SetData(System.Collections.Generic.Dictionary<string, object> 丛丝丙丄七一丁丅三)
        {
            丞东丑专丛丆丄丝世.与万丞丌丂丗丆东丁<Rilisoft.BonusData>(与东丑丂丅丅丅丂上: ref  this.丁丘丄丕下专东七不, 不丐丒丑丈丁丒世丟: ref  this.且丝世丟丈丈三丆丙);
            mem[this.丁丘丄丕下专东七不].丅专下万丕丑丆丅丝(丛丝丙丄七一丁丅三:  丛丝丙丄七一丁丅三, 业丈丈丗丐丄三丞丈:  false);
            goto typeof(Rilisoft.InAppBonusLobbyViewBase).__il2cppRuntimeField_198;
        }
        public virtual void UpdateView(bool 七丆丟丗世丟且丒丆 = False)
        {
        
        }
        public virtual void Click()
        {
            ButtonClickSound.丁业上丏不丕三丗不();
        }
        public virtual void Interact()
        {
            Rilisoft.BonusData val_64;
            Rilisoft.BonusData val_65;
            var val_66;
            string val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            int val_86;
            string val_87;
            var val_88;
            var val_89;
            string val_90;
            var val_91;
            PGCompany.专丟专世丅丂丁且专 val_92;
            var val_93;
            var val_94;
            val_64 = this;
            val_65 = this.丁丘丄丕下专东七不;
            if(val_65 == null)
            {
                    return;
            }
            
            不丕丟丐丒且与丛下 val_63 = this.丁丘丄丕下专东七不.Type;
            val_63 = val_63 - 6;
            if(val_63 > 21)
            {
                goto label_2;
            }
            
            var val_64 = 106030052 + ((this.丁丘丄丕下专东七不.Type - 6)) << 2;
            val_64 = val_64 + 106030052;
            goto (106030052 + ((this.丁丘丄丕下专东七不.Type - 6)) << 2 + 106030052);
            label_2:
            if( != 18)
            {
                goto label_86;
            }
            
            if(Rilisoft.FreeBundleBannerWindow.丌七丘七丗下丐七丞() == false)
            {
                goto label_87;
            }
            
            val_64 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_66 = 26;
            label_135:
            val_64.ForceShowBanner(丌丅丕一丛丛丄一万:  26, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return;
            label_86:
            if( != 24)
            {
                goto label_93;
            }
            
            Rilisoft.InAppBonusLobbyViewBase.不丕丌丕丄下与与丁(丂丌三万丐东丘丐三:  1, 东丐不一丆丛丕丁丗:  0);
            return;
            label_87:
            val_79 = 1152921505080860672;
            val_80 = null;
            val_80 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            val_81 = null;
            val_81 = null;
            MainMenuController.丄丞丁丈与业上丞丟.丄丒丂丈丁丂且丟丒(丁丛七丞丑一丌丞丆:  new System.Nullable<Rilisoft.LobbyItemGroupType>() {HasValue = false}, 世万丐专世丕业丟东:  val_16.bannerWindows);
            return;
            label_93:
            if( == 26)
            {
                    val_79 = 1152921505210572800;
                val_64 = BankController.丑七不且上丗丁一世();
                if(val_64 == 0)
            {
                    return;
            }
            
                .丛丟丌丝丈丞上丕丈 = 0;
                .丛丟丌丝丈丞上丕丈 = new System.EventHandler(object:  new InAppBonusLobbyViewBase.丕丛业丁丏下一七丘(), method:  System.Void InAppBonusLobbyViewBase.丕丛业丁丏下一七丘::专一丑丕上下丒丈丒(object 丟业丏且丟七丞一丆, System.EventArgs 业丝丑丆上丆丌丙业));
                BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (InAppBonusLobbyViewBase.丕丛业丁丏下一七丘)[1152921543006230544].丛丟丌丝丈丞上丕丈);
                val_82 = null;
                val_82 = null;
                val_79 = 1152921505211158528;
                val_83 = null;
                val_83 = null;
                BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐丞业丆不丄丈一;
                val_64 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐丞业丆不丄丈一;
                BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "EventStore", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  val_64);
                Rilisoft.一丟专且三万丞丁丂.一丞三丟丘专业丁东(丐业丝业万丞与一一:  "Banner");
                return;
            }
            
            if( != 30)
            {
                goto label_131;
            }
            
            if(BannerWindowController.与丅与丒丅专丙丐丗() != null)
            {
                goto label_135;
            }
            
            goto label_135;
            label_131:
            if(( != 7) || ( != 200))
            {
                goto label_139;
            }
            
            if(0 == 0)
            {
                goto label_142;
            }
            
            val_86 = 0.业上丙丞丐丄丆丅七();
            if(val_86 != null)
            {
                goto label_143;
            }
            
            label_142:
            val_86 = System.String.alignConst;
            label_143:
            .一丗与一专丙丙丅丄 = new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  val_86);
            PGCompany.与万丝丞下丒丗丏丙 val_43 = System.Linq.Enumerable.FirstOrDefault<PGCompany.与万丝丞下丒丗丏丙>(source:  PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().丟业不业一丈丘丗丁(), predicate:  new System.Func<PGCompany.与万丝丞下丒丗丏丙, System.Boolean>(object:  new InAppBonusLobbyViewBase.丗丁丆丞丑东丕丘丏(), method:  System.Boolean InAppBonusLobbyViewBase.丗丁丆丞丑东丕丘丏::万万专丙丘丛与丌丁(PGCompany.与万丝丞下丒丗丏丙 三且丑上丕上丅丁万)));
            if(val_43 == null)
            {
                    return;
            }
            
            UniversalPromotionBanner.ShowBanner(丄丘七三上丕世丞业:  val_43, 丘丒丅三丞丞丛丛丌:  0);
            return;
            label_139:
            if( == 190)
            {
                    BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  99, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丛且丅丙丏丁业丐丄 = PGCompany.丛东丟与丞丟万丒丏.丑七不且上丗丁一世().丟丌业丝丝丈一一下(丗丟丁丐与下丙丕丛:  PGCompany.且丝丑上丛丁丕东丕.上丑丕丅与丟上丘业(丗丟丁丐与下丙丕丛:  val_16.bannerWindows.业上丙丞丐丄丆丅七())), 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
                return;
            }
            
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏() != false)
            {
                    val_87 = PGCompany.MainStore.丗丝丙丏不丄七丌一.丗与与且丕万丘三丛(下丟三丕丟上一丌东:  val_16.bannerWindows);
            }
            else
            {
                    val_87 = "offers";
            }
            
            bool val_52 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_87);
            if((System.String.op_Equality(a:  val_16.bannerWindows, b:  "piggy")) != false)
            {
                    PGCompany.Piggy.业世且丐丕专丛专丐.丈丏万丛丈不丝丞七();
                return;
            }
            
            val_88 = null;
            val_88 = null;
            val_89 = null;
            val_89 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐丞业丆不丄丈一;
            if((System.String.op_Equality(a:  val_16.bannerWindows, b:  "manual")) == true)
            {
                goto label_174;
            }
            
            bool val_55 = System.String.op_Equality(a:  val_16.bannerWindows, b:  "constructable");
            if(val_55 == false)
            {
                goto label_175;
            }
            
            label_174:
            if(val_16.bannerWindows == null)
            {
                goto label_176;
            }
            
            if(val_55 == false)
            {
                goto label_177;
            }
            
            val_90 = val_55.业上丙丞丐丄丆丅七();
            goto label_180;
            label_176:
            val_90 = 0;
            goto label_182;
            label_175:
            val_90 = "";
            goto label_180;
            label_177:
            val_90 = 0;
            label_180:
            if((val_16.bannerWindows != null) && (val_55 != false))
            {
                    if(val_55.丂三世丙丟一丆丒丈() == false)
            {
                goto label_183;
            }
            
            }
            
            label_182:
            val_91 = null;
            val_91 = null;
            label_197:
            val_92 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_90)) != true)
            {
                    PGCompany.世丏丘丛丗丑专丈下 val_60 = null;
                val_92 = val_60;
                val_60 = new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  System.Convert.ToInt32(value:  val_90));
            }
            
            val_93 = null;
            val_93 = null;
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  true, 丆丟七丝丏业丅上丄:  val_16.bannerWindows, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丈丐丞业丆不丄丈一, 丐万丂丞万丌丐丞世:  0, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  val_60);
            return;
            label_183:
            val_94 = null;
            val_94 = null;
            goto label_197;
        }
        internal static void 不丕丌丕丄下与与丁()
        {
            Rilisoft.InAppBonusLobbyViewBase.不丕丌丕丄下与与丁(丂丌三万丐东丘丐三:  1, 东丐不一丆丛丕丁丗:  0);
        }
        internal static void 不丕丌丕丄下与与丁(BattlePassRootUI.丁丆丌且且不丟上世 丂丌三万丐东丘丐三, int 东丐不一丆丛丕丁丗 = -1)
        {
            int val_17;
            FriendsWindowGUI val_18;
            var val_19;
            var val_20;
            var val_21;
            val_17 = 东丐不一丆丛丕丁丗;
            if(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丄丘七三上丕世丞业 != 0)
            {
                    if(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丄丘七三上丕世丞业.gameObject.activeInHierarchy != false)
            {
                    PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丄一丐丂与丐且丘世(丙业与丙丗丝不丈东:  true);
            }
            
            }
            
            val_18 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_18.丄丄丁丗且丐丘丟丅() == true)
            {
                    return;
            }
            
            val_19 = null;
            val_19 = null;
            if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_20 = null;
                val_20 = null;
                val_18 = FriendsWindowGUI.丆丕丝丒不丙且丐丗;
                if(val_18.上丙丆不丂丂丄一丂() == true)
            {
                    return;
            }
            
            }
            
            val_21 = null;
            val_21 = null;
            val_18 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_18.IsOpeningFriends == true)
            {
                    return;
            }
            
            val_18 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_18 == null)
            {
                    return;
            }
            
            if(val_18.丗丄上丑丑丅丐丒丌() != false)
            {
                    if(val_18.丌丈一丘上丕丏东丛() == true)
            {
                    return;
            }
            
                val_17 = BannerWindowController.与丅与丒丅专丙丐丗();
                val_17.ForceShowBanner(丌丅丕一丛丛丄一万:  32, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
                return;
            }
            
            val_18 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_18 != 0)
            {
                    return;
            }
            
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  丂丌三万丐东丘丐三);
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 1;
            val_18 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_18.ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            if(丂丌三万丐东丘丐三 != 2)
            {
                    return;
            }
            
            if(val_17 == 1)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassChallangesUI.丟丄丐一七东不丁且(丙业与丙丗丝不丈东:  val_17);
        }
        protected static UnityEngine.Texture 世丙专东丂丁万丄丗(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            var val_6;
            string val_18;
            var val_19;
            val_18 = 丅东专与不三丂丁丝;
            if(val_18 == null)
            {
                goto label_29;
            }
            
            if(val_18.不业丙丒丂丞下丆丙() != 200)
            {
                    val_19 = 0;
                if(val_18.不业丙丒丂丞下丆丙() != 300)
            {
                    return (UnityEngine.Texture)val_19;
            }
            
            }
            
            val_18 = val_18.丄三丐丟丗丄丟上丞();
            List.Enumerator<T> val_4 = val_18.GetEnumerator();
            label_15:
            if(((-254784416) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(((val_7 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7.丅三专且丈一丝丂丏())) == true)) || (val_7.七丝丝丈七三丝丘一() == true))
            {
                goto label_15;
            }
            
            三丅丁丗丗丝丂万且 val_12 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_7.丅三专且丈一丝丂丏());
            if(val_12 == null)
            {
                goto label_15;
            }
            
            val_18 = val_7.丅三专且丈一丝丂丏();
            val_19 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_18, 七丆丒与丗丌丄且丂:  val_12.万上丄下业丛丌不丈() - 1, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            goto label_18;
            label_5:
            val_19 = 0;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (UnityEngine.Texture)val_19;
            label_29:
            val_19 = 0;
            return (UnityEngine.Texture)val_19;
        }
        protected bool 业丂丟且丏丟丆丆丝()
        {
            var val_6;
            var val_22;
            var val_23;
            var val_24;
            if(((this.丁丘丄丕下专东七不 == null) || (this.丁丘丄丕下专东七不.GameEvent == null)) || (this.丁丘丄丕下专东七不.GameEvent.丈丐丞丐上丑且丕万() == false))
            {
                goto label_30;
            }
            
            if(this.丁丘丄丕下专东七不.GameEvent.不业丙丒丂丞下丆丙() != 100)
            {
                goto label_27;
            }
            
            List.Enumerator<T> val_4 = this.丁丘丄丕下专东七不.GameEvent.丄三丐丟丗丄丟上丞().GetEnumerator();
            val_22 = 1152921540871088400;
            label_19:
            if(((-254574096) & 1) == 0)
            {
                goto label_34;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(val_7.丐丏下丕三丒丗丅丛() == true)
            {
                goto label_12;
            }
            
            val_23 = val_7.丟丂丞不专丆万丒世();
            if(val_23 <= (BankController.且七七丝丏与丏丌丆(丟丟丄专上丟丁丐丝:  0)))
            {
                goto label_45;
            }
            
            label_12:
            if((val_7.业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
            {
                goto label_19;
            }
            
            label_45:
            val_24 = 1;
            goto label_20;
            label_27:
            if(mem[4611686018427499600].不业丙丒丂丞下丆丙() != 200)
            {
                goto label_30;
            }
            
            List.Enumerator<T> val_14 = mem[4611686018427499600].丄三丐丟丗丄丟上丞().GetEnumerator();
            val_23 = 1152921540871087376;
            val_22 = 1152921505459453952;
            label_44:
            if(((-254574096) & 1) == 0)
            {
                goto label_34;
            }
            
            string val_15 = val_6.丐丏七丌丕丗业且上();
            if((val_15 == null) || ((丙丞丟丑丗丅专丈一.丝不上丅丗业丑下一(丞一丁业丄一一业且:  val_15.丅三专且丈一丝丂丏())) == true))
            {
                goto label_44;
            }
            
            if((val_15.丄丌万丘与专丝业丗() == false) || (val_15.丟丂丞不专丆万丒世() <= 0))
            {
                goto label_45;
            }
            
            if(val_15.丒世业三丘丝不下丕() == false)
            {
                goto label_44;
            }
            
            goto label_45;
            label_34:
            val_24 = 0;
            label_20:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_24;
            label_30:
            val_24 = 0;
            return (bool)val_24;
        }
        public InAppBonusLobbyViewBase()
        {
            this.丁丘丄丕下专东七不 = new Rilisoft.BonusData();
            this.且丝世丟丈丈三丆丙 = new Rilisoft.BonusData();
        }
    
    }

}
