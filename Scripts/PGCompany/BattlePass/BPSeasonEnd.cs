using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPSeasonEnd : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _body;
        private UnityEngine.Transform _subWindowsPlacePoint;
        private System.Collections.Generic.List<UILabel> _levelLabels;
        private UnityEngine.GameObject _freeShield;
        private UnityEngine.GameObject _freeShieldNoRewards;
        private UnityEngine.GameObject _paidShield;
        private UnityEngine.GameObject _paidShieldNoRewards;
        private UnityEngine.GameObject _topBlockContainer;
        private UnityEngine.GameObject _rewardsContainer;
        private UnityEngine.Transform _rewardsNoPossiblePosition;
        private Rilisoft.BetterWrapContent _rewardsWrap;
        private UnityEngine.GameObject _possibleRewardsContainer;
        private Rilisoft.BetterWrapContent _possibleRewardsWrap;
        private UnityEngine.GameObject _buyPremButton;
        private UnityEngine.GameObject _buyLevelButton;
        private UnityEngine.GameObject _hintObject;
        private UILabel _hintLabel;
        private UILabel _hintLabelBig;
        private UnityEngine.GameObject _warningPanel;
        private UnityEngine.GameObject _warningBuyPrem;
        private UnityEngine.GameObject _warningBuyLevel;
        private PGCompany.BattlePass.上丕丁专三丗丝万丆 世不丁丌业专且与丗;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丂丑丆丏丝丈丂东丙;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丏丞丄丙丙丟丌七一;
        private UnityEngine.Coroutine 下丈不丄七不丐丅丒;
        private bool 三丟七丑世丆且且万;
        private static PGCompany.BattlePass.BPSeasonEnd <不丁丄七丛不丆丁丕>k__BackingField;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private bool 下丒上世业丂丛一丕;
        private UnityEngine.Color 世下丕东七丆丆专三;
        private bool 丁丝丌丞与丑丂三上;
        
        // Properties
        internal UnityEngine.Transform 下丒丁专三三且丞不 { get; }
        public static PGCompany.BattlePass.BPSeasonEnd 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        internal UnityEngine.Transform 七丒丈世丟三与丂与()
        {
            return (UnityEngine.Transform)this._subWindowsPlacePoint;
        }
        public static PGCompany.BattlePass.BPSeasonEnd get_Instance()
        {
            return (PGCompany.BattlePass.BPSeasonEnd)PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BPSeasonEnd 丙业与丙丗丝不丈东)
        {
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void 世与且业业丁专与丕()
        {
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        }
        private void 专不丌万丗丟丒丐专()
        {
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
        }
        private void OnEnable()
        {
            var val_9;
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField = this;
            this.下丒上世业丂丛一丕 = false;
            this.丟丈丂丗丘丂丗丏一();
            val_9 = null;
            val_9 = null;
            SetActive(value:  false);
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            System.IDisposable val_4 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BPSeasonEnd::U_Hide()), 与且专丈不万东一万:  0);
            UnityEngine.Color val_5 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
            this.世下丕东七丆丆专三 = val_5;
            mem[1152921560150655800] = val_5.g;
            mem[1152921560150655804] = val_5.b;
            mem[1152921560150655808] = val_5.a;
            this.丁丝丌丞与丑丂三上 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
            CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::世与且业业丁专与丕()));
        }
        private void OnDisable()
        {
            var val_4;
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField = 0;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            if(this.下丒上世业丂丛一丕 != false)
            {
                    this.丗丘丒丅丄不丕不丏();
            }
            
            val_4 = null;
            val_4 = null;
            SetActive(value:  true);
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丁丝丌丞与丑丂三上);
            CoroutineRunner.不万丏与丐业丛丟万(业丗七丕万万不丈丗:  1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::专不丌万丗丟丒丐专()));
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BPSeasonEnd.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        private void 丟丈丂丗丘丂丗丏一()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  true);
            if(this.下丈不丄七不丐丅丒 != null)
            {
                    this.StopCoroutine(routine:  this.下丈不丄七不丐丅丒);
            }
            
            if(this == 0)
            {
                    return;
            }
            
            this.下丈不丄七不丐丅丒 = this.StartCoroutine(routine:  this.丈丌三东丐丛丅丐丆());
        }
        private System.Collections.IEnumerator 丈丌三东丐丛丅丐丆()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPSeasonEnd.丑世丂丆丟丛丐丏丛();
        }
        private void 丗丘丒丅丄不丕不丏()
        {
            var val_18;
            object val_33;
            string val_43;
            var val_47;
            System.Func<TSource, System.Boolean> val_50;
            var val_51;
            PGCompany.BattlePass.BPSeasonEnd val_53;
            var val_54;
            PGCompany.BattlePass.BPSeasonEnd val_56;
            var val_57;
            var val_58;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            val_43 = this.世不丁丌业专且与丗.丑万丘丈业丁丟丏七();
            if(val_43 == null)
            {
                goto label_2;
            }
            
            var val_45 = 0;
            val_45 = val_45 + 1;
            System.Collections.Generic.IEnumerator<T> val_4 = val_43.GetEnumerator();
            label_25:
            var val_46 = 0;
            val_46 = val_46 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_47 = 0;
            val_47 = val_47 + 1;
            T val_8 = val_4.Current;
            if((val_8.Item == null) || (val_8.Item.Type == 1100))
            {
                goto label_25;
            }
            
            val_1.Add(item:  val_8.Item);
            goto label_25;
            label_12:
            val_47 = 0;
            val_43 = 0;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_48 = 0;
                val_48 = val_48 + 1;
                val_4.Dispose();
            }
            
            if(( == 1) || (99 != 99))
            {
                goto label_41;
            }
            
            label_2:
            val_47 = 0;
            goto label_43;
            label_41:
            if( != false)
            {
                    val_43 = 0;
            }
            
            label_43:
            System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_15 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
            if(val_15 == null)
            {
                goto label_47;
            }
            
            List.Enumerator<T> val_16 = val_15.GetEnumerator();
            val_50 = 1152921525755360736;
            label_62:
            if(((-290047744) & 1) == 0)
            {
                goto label_48;
            }
            
            string val_19 = val_18.丐丏七丌丕丗业且上();
            if(0 == 0)
            {
                goto label_62;
            }
            
            List.Enumerator<T> val_20 = 0.GetEnumerator();
            label_54:
            if(((-290047776) & 1) == 0)
            {
                goto label_51;
            }
            
            string val_21 = val_18.丐丏七丌丕丗业且上();
            if(val_21 == null)
            {
                goto label_54;
            }
            
            val_1.Add(item:  val_21);
            goto label_54;
            label_51:
             =  + 1;
            val_51 = val_43;
            mem2[0] = 203;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( == 1) || ((-290047872 + ((val_47 + 1)) << 2) != 203))
            {
                goto label_59;
            }
            
            var val_49 = 0;
            val_49 = val_49 ^ ( >> 31);
             =  + val_49;
            goto label_62;
            label_59:
            if( == 0)
            {
                goto label_62;
            }
            
            goto label_62;
            label_47:
            val_53 = this;
            goto label_73;
            label_48:
            val_53 = this;
            val_47 =  + 1;
            mem2[0] = 228;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if((val_47 != 1) && ((-290047872 + ((val_47 + 1)) << 2) == 228))
            {
                    var val_50 = 0;
                val_50 = val_50 ^ (val_47 >> 31);
                val_47 = val_47 + val_50;
            }
            else
            {
                    if( != 0)
            {
                    val_43 = 0;
            }
            
            }
            
            label_73:
            if(((this.世不丁丌业专且与丗.万上丁一丞业业万东() == 1205) && (this.世不丁丌业专且与丗.专丟专一丒且丘与丌() == 100)) && (this.世不丁丌业专且与丗.业丈丅丂且丁与丄丂() >= 20))
            {
                    BPSeasonEnd.丆世丒一丈专丆丆七 val_25 = new BPSeasonEnd.丆世丒一丈专丆丆七();
                Rilisoft.OfferItem val_26 = new Rilisoft.OfferItem(丞丕丒专一下丙业上:  "Royale:avatar_secret_character:1");
                if(val_25 != null)
            {
                    val_54 = val_25;
                .下丅丙一丂丗丅丝七 = val_26;
            }
            else
            {
                    val_54 = 16;
                mem[16] = val_26;
            }
            
                if(val_26.IsExists != true)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_28 = null;
                val_50 = val_28;
                val_28 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  val_25, method:  System.Boolean BPSeasonEnd.丆世丒一丈专丆丆七::万丆业丟不丄丂丌丕(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                if((System.Linq.Enumerable.All<Rilisoft.OfferItem>(source:  val_1, predicate:  val_28)) != false)
            {
                    val_1.Add(item:  val_26);
            }
            
            }
            
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  29);
            List.Enumerator<T> val_31 = val_1.GetEnumerator();
            label_106:
            if(((-290047776) & 1) == 0)
            {
                goto label_91;
            }
            
            string val_34 = val_33.丐丏七丌丕丗业且上();
            if(val_34.IsExists == true)
            {
                goto label_106;
            }
            
            丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_34, 丁且丟不七下丆丒丟:  (val_1.Count < 2) ? 1 : 0, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  true, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  41, 不丐丅丁丂七丐丘丛:  5, 丁七丐丁丙丄丙不东:  false);
            goto label_106;
            label_91:
            val_56 = this;
            val_47 = val_47 + 1;
            mem2[0] = 463;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_47 == 1)
            {
                goto label_112;
            }
            
            if(( == 0) || ((-290047872 + ((val_47 + 1)) << 2) == 463))
            {
                goto label_132;
            }
            
            label_131:
            label_132:
            if(val_1.Count >= 1)
            {
                    val_57 = null;
                val_57 = null;
                if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
            {
                    val_58 = null;
                val_58 = null;
                val_43 = WeaponManager.丟丗丄业丘丗业丗七.丟三上丁丗一丅丝丐();
                WeaponManager.丟丗丄业丘丗业丗七.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  val_43);
            }
            
            }
            
            this.世不丁丌业专且与丗.东不丑丁丅万丁专丕();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  57);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return;
            label_112:
            if( != 0)
            {
                goto label_131;
            }
            
            goto label_132;
        }
        private void 丛丕丄丄世七丘丐丏(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丗世世丝丄丌且上下)
        {
            PGCompany.BattlePass.BPRewardView val_1 = 丝三丁东丈丒世丅业.GetComponent<PGCompany.BattlePass.BPRewardView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)));
            val_1.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)));
            if(this.丂丑丆丏丝丈丂东丙.Count > 丗世世丝丄丌且上下)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
                val_1.Setup(与且专丈不万东一万:  this.丂丑丆丏丝丈丂东丙.Item[丗世世丝丄丌且上下]);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  false);
        }
        private void 一业丆下丞丘七三世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丗世世丝丄丌且上下)
        {
            PGCompany.BattlePass.BPRewardView val_1 = 丝三丁东丈丒世丅业.GetComponent<PGCompany.BattlePass.BPRewardView>();
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)));
            val_1.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)));
            if(this.丏丞丄丙丙丟丌七一.Count > 丗世世丝丄丌且上下)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
                val_1.Setup(与且专丈不万东一万:  this.丏丞丄丙丙丟丌七一.Item[丗世世丝丄丌且上下]);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  false);
        }
        private void 丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 丌丝万上丅丒一丈丘)
        {
            PGCompany.BattlePass.BPReward val_1 = 丌丝万上丅丒一丈丘.Context;
            if(val_1 == null)
            {
                    return;
            }
            
            this = this.transform;
            Rilisoft.ItemViewer val_7 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  this, 丕丁下丌不万丅丞丛:  val_1.Item.Id, 丅三丟世下丞丝丙万:  val_1.Item.Count, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
        }
        public void ShowBuyCurrencyWindow()
        {
            UnityEngine.GameObject val_5 = PGCompany.BattlePass.BattlePassBuyCurrencyWindow.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this._subWindowsPlacePoint);
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = val_5.GetComponent<UIPanel>();
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5.depth = 150;
        }
        public void U_HideWarningPanel()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningPanel, 丏业丟一东丂东丘丛:  false);
        }
        public void U_Hide()
        {
            UnityEngine.GameObject val_4;
            UnityEngine.GameObject val_5;
            val_4 = this;
            if(this._warningPanel.activeSelf == false)
            {
                goto label_2;
            }
            
            val_4 = this._warningPanel;
            val_5 = val_4;
            goto label_5;
            label_2:
            if(this.世不丁丌业专且与丗.专丟专一丒且丘与丌() != 100)
            {
                goto label_7;
            }
            
            if(this.世不丁丌业专且与丗.丐丞上丒七丞丁丙丕() == false)
            {
                goto label_9;
            }
            
            this.U_HideForce();
            return;
            label_7:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningBuyPrem, 丏业丟一东丂东丘丛:  true);
            val_5 = this._warningBuyLevel;
            label_5:
            label_14:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
            return;
            label_9:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningBuyPrem, 丏业丟一东丂东丘丛:  false);
            goto label_14;
        }
        public void U_HideForce()
        {
            UnityEngine.Object val_14;
            this.下丒上世业丂丛一丕 = true;
            if(this._warningPanel.activeSelf != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningPanel, 丏业丟一东丂东丘丛:  false);
            }
            
            val_14 = BannerWindowController.与丅与丒丅专丙丐丗();
            if(val_14 == 0)
            {
                    return;
            }
            
            val_14 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
            if(val_14 == 0)
            {
                    return;
            }
            
            BannerWindow val_8 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
            val_14 = ???;
            goto typeof(BannerWindow).__il2cppRuntimeField_208;
        }
        public void U_BuyPremium()
        {
            if(this._warningPanel.activeSelf != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningPanel, 丏业丟一东丂东丘丛:  false);
            }
            
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丈丙丄不丙丙丅丏丆()));
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丈丙丄不丙丙丅丏丆()));
            if((PGCompany.BattlePass.BattlePassBuyPremiumWindow.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  false);
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this._subWindowsPlacePoint);
        }
        public void U_BuyLevel()
        {
            if(this._warningPanel.activeSelf != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningPanel, 丏业丟一东丂东丘丛:  false);
            }
            
            PGCompany.BattlePass.BattlePassBuyLevelWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::一下丁丝丙丘丞丟上()));
            PGCompany.BattlePass.BattlePassBuyLevelWindow.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::一下丁丝丙丘丞丟上()));
            if((PGCompany.BattlePass.BattlePassBuyLevelWindow.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  false);
            PGCompany.BattlePass.BattlePassBuyLevelWindow.下与丞三丅丛丄七丕(丆丏七丟不丒与七专:  this._subWindowsPlacePoint);
        }
        public void U_BuyCurrency()
        {
            this.ShowBuyCurrencyWindow();
        }
        private void 丈丙丄不丙丙丅丏丆()
        {
            PGCompany.BattlePass.BattlePassBuyPremiumWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::丈丙丄不丙丙丅丏丆()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  true);
            this.丟丈丂丗丘丂丗丏一();
        }
        private void 一下丁丝丙丘丞丟上()
        {
            PGCompany.BattlePass.BattlePassBuyLevelWindow.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPSeasonEnd::一下丁丝丙丘丞丟上()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  true);
            this.丟丈丂丗丘丂丗丏一();
        }
        public BPSeasonEnd()
        {
            this.三丟七丑世丆且且万 = true;
        }
        private bool 七专丛丅业丈七下丒(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛)
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_9;
            var val_10;
            var val_11;
            val_9 = this;
            if(东七上世万下丗丄丛.Item == null)
            {
                    return (bool)val_10;
            }
            
            val_11 = 东七上世万下丗丄丛.Item;
            if(val_11.IsKnownItem != false)
            {
                    val_11 = 东七上世万下丗丄丛.ForLevel;
                if(val_11 > this.世不丁丌业专且与丗.业丈丅丂且丁与丄丂())
            {
                    val_10 = 1;
                return (bool)val_10;
            }
            
                if(东七上世万下丗丄丛.PaymentState == 100)
            {
                    val_9 = this.世不丁丌业专且与丗;
                var val_8 = (val_9.专丟专一丒且丘与丌() != 100) ? 1 : 0;
                return (bool)val_10;
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        private int 一世丞不下丝专丑丝()
        {
            if(this.丂丑丆丏丝丈丂东丙 != null)
            {
                    return this.丂丑丆丏丝丈丂东丙.Count;
            }
            
            return this.丂丑丆丏丝丈丂东丙.Count;
        }
        private int 一世丁上丌三三专丄()
        {
            if(this.丏丞丄丙丙丟丌七一 != null)
            {
                    return this.丏丞丄丙丙丟丌七一.Count;
            }
            
            return this.丏丞丄丙丙丟丌七一.Count;
        }
    
    }

}
