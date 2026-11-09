using UnityEngine;

namespace PGCompany
{
    public class ClanWarScoreViewUI : BannerWindow, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private PGCompany.TimerUI _timer;
        private ClanWarScoreViewContainerUI _clanPlaceObj;
        private System.Collections.Generic.List<UnityEngine.Vector3> _clansPlacesPositions;
        private UILabel _divisionName;
        private UITexture _divisionIcon;
        private UnityEngine.Color _clanBgNormal;
        private UnityEngine.Color _clanBgMy;
        private UnityEngine.Color _clanOutlineNormal;
        private UnityEngine.Color _clanOutlineMy;
        internal UnityEngine.GameObject _chestInfoWindowPrefab;
        internal ClanWarScoreViewRewardChestUI _rewardChest;
        private UnityEngine.GameObject fewWarScoresContainer;
        private UILabel fewWarScoresLabel;
        private System.Collections.Generic.List<UnityEngine.GameObject> 丒丕世东世东丆与丝;
        private UnityEngine.GameObject 万东不丛丝丕上丂与;
        private System.IDisposable 东三世丝丒三一丈丛;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanWarScoreViewUI::U_Back()), 与且专丈不万东一万:  System.String.Format(format:  "ClanWarScoreViewUI_{0}", arg0:  this.gameObject.name));
            ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::丞丟业丙与丅丏丞丑()));
        }
        private void 丞丟业丙与丅丏丞丑()
        {
            null = null;
            MainMenuController.丞丟丂三丝丆丌丌丗 = true;
            丕世不丐丒丕丅丗且.上丑丅丟丒丘业东万();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::丞丟业丙与丅丏丞丑()));
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        internal static void 丆丙丗三东专丐不上()
        {
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  48, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        public override void Show()
        {
            int val_5;
            var val_95;
            var val_99;
            PGCompany.东丑丆丗丏丐丟下丄 val_101;
            var val_102;
            var val_103;
            object val_105;
            一一万丒与专丙丁丛 val_106;
            var val_107;
            var val_108;
            this.Show();
            this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丅丙丛万不且一丟(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            List.Enumerator<T> val_3 = this.丒丕世东世东丆与丝.GetEnumerator();
            label_7:
            if(((-2079810416) & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Object.Destroy(obj:  val_5.丐丏七丌丕丗业且上());
            goto label_7;
            label_4:
            val_95 = public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丒丕世东世东丆与丝.Clear();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanPlaceObj, 丏业丟一东丂东丘丛:  true);
            var val_97 = 0;
            val_97 = val_97 + 1;
            System.Collections.Generic.IEnumerator<T> val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().一七丑下丙业丑丌丌().GetEnumerator();
            label_100:
            var val_98 = 0;
            val_98 = val_98 + 1;
            if(val_11.MoveNext() == false)
            {
                goto label_27;
            }
            
            var val_99 = 0;
            val_99 = val_99 + 1;
            T val_15 = val_11.Current;
            ClanWarScoreViewContainerUI val_18 = UnityEngine.Object.Instantiate<ClanWarScoreViewContainerUI>(original:  this._clanPlaceObj, parent:  this._clanPlaceObj.transform.parent, worldPositionStays:  false);
            UnityEngine.Vector3 val_20 = this._clansPlacesPositions.Item[0];
            val_18.transform.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            this.丒丕世东世东丆与丝.Add(item:  val_18.gameObject);
            丞丂丘丒丟丞丑下丄 val_23 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if((val_23 == null) || (((val_23 == 0) ? 0 : (val_23).业丐丐三丕一丗丛丁()) == null))
            {
                goto label_45;
            }
            
            val_99 = System.String.op_Equality(a:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁(), b:  val_15.业丐丐三丕一丗丛丁());
            if(val_15 != 0)
            {
                goto label_51;
            }
            
            goto label_50;
            label_45:
            val_99 = 0;
            if(val_15 != 0)
            {
                goto label_51;
            }
            
            label_50:
            label_51:
            UnityEngine.Color val_32 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  val_15.业丐丐三丕一丗丛丁(), 丏丆丗丂丟丘丈万万:  1);
            val_18.gameObject.SetActive(value:  true);
            val_18.三丄丏丂丁下丐丛万().text = 1.ToString();
            val_18.东丙上东业丆不丟丘().text = val_15.东丙上东业丆不丟丘();
            val_18.东丙上东业丆不丟丘().color = new UnityEngine.Color() {r = val_32.r, g = val_32.g, b = val_32.b, a = val_32.a};
            val_18.Shield.color = new UnityEngine.Color() {r = val_32.r, g = val_32.g, b = val_32.b, a = val_32.a};
            val_18._bg.color = new UnityEngine.Color() {r = (val_99 != 0) ? this._clanBgMy : this._clanBgNormal, g = (val_99 != 0) ? 1152921554066656644 : 1152921554066656628, b = (val_99 != 0) ? 1152921554066656648 : 1152921554066656632, a = (val_99 != 0) ? 1152921554066656652 : 1152921554066656636};
            val_18._outline.color = new UnityEngine.Color() {r = (val_99 != 0) ? this._clanOutlineMy : this._clanOutlineNormal, g = (val_99 != 0) ? 1152921554066656676 : 1152921554066656660, b = (val_99 != 0) ? 1152921554066656680 : 1152921554066656664, a = (val_99 != 0) ? 1152921554066656684 : 1152921554066656668};
            val_18.丞丏丕丑丞丑丏丏丄().text = val_15.业不且丟丆下丏丌丒().ToString();
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_18.丈丐丒丘丕丅七丈丙(), 与万丆丛丒万丝丙丑:  val_15.世丐专丂世丄世丂丌());
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_53 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.东专三丏丞专丙不丝(专世专丟丝丌与丘上:  1);
            if(val_53 == null)
            {
                goto label_74;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_55 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  (val_53 == 0) ? 0 : (val_53));
            if(val_55 == null)
            {
                goto label_74;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_58 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_55.业东丅东丌上丗丑不());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18.丈丂七世丙丑丝下丘(), 丏业丟一东丂东丘丛:  true);
            UITextureMasked val_60 = val_18.丈丂七世丙丑丝下丘();
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_60, 与万丆丛丒万丝丙丑:  val_58);
            PGCompany.东丑丆丗丏丐丟下丄 val_61 = val_60.业三世一且不丁丙丝(下丅丙一丂丗丅丝七:  val_58);
            goto label_79;
            label_74:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18.丈丂七世丙丑丝下丘(), 丏业丟一东丂东丘丛:  false);
            val_101 = 0;
            label_79:
            val_18.丒丁丝与且丂且丐丝 = val_101;
            PGCompany.三东丏不丗世丅丌丄 val_63 = PGCompany.丂丘丞丂丏七丁丄不.不不丈丗丅丂世丕丗(专世专丟丝丌与丘上:  1);
            if((val_63 != null) && (val_63.丂丁丏一丙丛业且丌() >= 1))
            {
                    val_18.丝与丄业世丒丄七丙().丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_63, 丗丂丞丛丒丒丟万丗:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18.丝与丄业世丒丄七丙(), 丏业丟一东丂东丘丛:  true);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_18.丝与丄业世丒丄七丙(), 丏业丟一东丂东丘丛:  false);
            }
            
            System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_68 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::且丌丌下丑且且丂七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁));
            val_18.丗且丏丞不丟丛不丝(丙业与丙丗丝不丈东:  null);
            System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_69 = new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::且丌丌下丑且且丂七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁));
            val_18.万东世丆丄丂丁丟丗(丙业与丙丗丝不丈东:  null);
            一一万丒与专丙丁丛 val_72 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.下丈丈与上丄丌东丐(专丑丕丄丗丂一丝且:  val_15.世丝丌一且丝专丑丛(), 且丒丛与丞世丙丕丌:  1);
            val_18._levelUp.gameObject.SetActive(value:  (val_72 > val_15.世丝丌一且丝专丑丛()) ? 1 : 0);
            val_18._levelDown.gameObject.SetActive(value:  (val_72 < val_15.世丝丌一且丝专丑丛()) ? 1 : 0);
            goto label_100;
            label_27:
            val_102 = 0;
            val_103 = 0;
            if(val_11 != null)
            {
                    var val_100 = 0;
                val_100 = val_100 + 1;
                val_11.Dispose();
            }
            
            if( == 1)
            {
                goto label_175;
            }
            
            if(( == false) || (803 == 803))
            {
                goto label_184;
            }
            
            label_183:
            label_184:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanPlaceObj, 丏业丟一东丂东丘丛:  false);
            丞丂丘丒丟丞丑下丄 val_81 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_81 == null)
            {
                goto label_181;
            }
            
            一一万丒与专丙丁丛 val_82 = val_81.世丝丌一且丝专丑丛();
            val_5 = 0;
            val_105 = val_5;
            goto label_182;
            label_175:
            if( == true)
            {
                goto label_183;
            }
            
            goto label_184;
            label_181:
            val_105 = 0;
            label_182:
            if(((-2079810432) & 1) != 0)
            {
                    int val_83 = val_105.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_106 = 0;
            }
            
            this._divisionName.text = 丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_106);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._divisionIcon, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Shields/tournament_shield_{0}", arg0:  val_105)));
            this._rewardChest.丗且丏丞不丟丛不丝(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::且丌丌下丑且且丂七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)));
            this._rewardChest.万东世丆丄丂丁丟丗(丙业与丙丗丝不丈东:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::且丌丌下丑且且丂七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)));
            this._rewardChest.丒丁丝与且丂且丐丝 = this._rewardChest.业三世一且不丁丙丝(下丅丙一丂丗丅丝七:  this._rewardChest.上丛丌丆丑上七世三());
            丞丂丘丒丟丞丑下丄 val_92 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_92 != null)
            {
                    val_107 = val_92.业不且丟丆下丏丌丒();
            }
            else
            {
                    val_107 = 0;
            }
            
            val_108 = null;
            val_108 = null;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fewWarScoresContainer, 丏业丟一东丂东丘丛:  (val_107 <= BalanceController.丗丛丞下丟与丞丞七) ? 1 : 0);
            val_5 = BalanceController.丗丛丞下丟与丞丞七;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.fewWarScoresLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8541"), arg0:  val_5));
        }
        private PGCompany.东丑丆丗丏丐丟下丄 业三世一且不丁丙丝(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            PGCompany.StorePromotionPurchaseSettings val_1 = new PGCompany.StorePromotionPurchaseSettings();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_2.Add(item:  下丅丙一丂丗丅丝七.丑丐丙丄丅世世丑丒());
            if(val_1 != null)
            {
                    val_1.Price = val_2;
            }
            else
            {
                    val_1.Price = val_2;
            }
            
            .Type = 5;
            (PGCompany.StorePromotionSettings)[1152921554067214048].ItemsParams.Add(item:  下丅丙一丂丗丅丝七.丑丐丙丄丅世世丑丒());
            .PurchaseSettings = val_1;
            return (PGCompany.东丑丆丗丏丐丟下丄)new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  1, 与不丕丆丈不丙丟丛:  new PGCompany.StorePromotionSettings(), 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  0)));
        }
        private void 且丌丌下丑且且丂七(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            if(且丘丏丁丑与丙与丁 == null)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._chestInfoWindowPrefab, parent:  this.gameObject.transform.parent);
            this.万东不丛丝丕上丂与 = val_4;
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_4, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            PGCompany.ClanLootBoxInfoUI val_7 = this.万东不丛丝丕上丂与.GetComponent<PGCompany.ClanLootBoxInfoUI>();
            val_7.丂丞下三七丞东丄世 = false;
            val_7.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::与业上丘丛丄丗与丝(PGCompany.StorePromotionInfoUIAbstract 丝丘丅丑东与东丕世)));
            System.Action<PGCompany.StorePromotionInfoUIAbstract> val_9 = new System.Action<PGCompany.StorePromotionInfoUIAbstract>(object:  this, method:  System.Void PGCompany.ClanWarScoreViewUI::与业上丘丛丄丗与丝(PGCompany.StorePromotionInfoUIAbstract 丝丘丅丑东与东丕世));
            if(val_7 != null)
            {
                    val_7.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  val_9);
            }
            else
            {
                    val_7.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  val_9);
            }
        
        }
        private void 与业上丘丛丄丗与丝(PGCompany.StorePromotionInfoUIAbstract 丝丘丅丑东与东丕世)
        {
            if(this.万东不丛丝丕上丂与 == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  this.万东不丛丝丕上丂与);
            this.万东不丛丝丕上丂与 = 0;
        }
        public void U_Back()
        {
            this.HideSelf();
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
        }
        public void TurnOn()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return false;
        }
        public bool IsEnabledLobbyCamera()
        {
            return false;
        }
        public float GetDelayTurnOff()
        {
            return 0f;
        }
        public ClanWarScoreViewUI()
        {
            this.丒丕世东世东丆与丝 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
