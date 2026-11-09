using UnityEngine;

namespace Rilisoft
{
    internal sealed class ClanLobbyWarLeaderboardView : PGBehaviour
    {
        // Fields
        private DynamicWrapGrid wrap;
        private UICenterOnChild centerOnChild;
        private UILabel clanNameLabel;
        internal UILabel tankPowerLabel;
        internal UILabel fortPowerLabel;
        private UILabel zonesCapturedCount;
        private UILabel futureDivisionNameLabel;
        private UILabel rewardNameLabel;
        private UITexture futureDivisionTexture;
        private UITexture rewardTexture;
        private PGCompany.ItemCurrencyUI currencyRewardUi;
        private UnityEngine.GameObject upDivisionSprite;
        private UnityEngine.GameObject downDivisionSprite;
        private float distanceToUpdateClan;
        internal static bool 一下丆丌丂上丟丈且;
        private Rilisoft.ClanLobbyWarLeaderboardViewItem 七丝业下丆七下丙丆;
        
        // Methods
        private void LateUpdate()
        {
            Rilisoft.ClanLobbyWarLeaderboardViewItem val_19;
            var val_20;
            if(this.wrap.ScrollView.isDragging != true)
            {
                    UnityEngine.Vector3 val_4 = this.wrap.ScrollView.currentMomentum;
                if(val_4.x <= 0.0001f)
            {
                    return;
            }
            
            }
            
            val_19 = 0;
            val_20 = 0;
            goto label_7;
            label_19:
            UnityEngine.Vector3 val_9 = this.transform.position;
            UnityEngine.Vector3 val_10 = this.wrap.GridItems.Item[0].transform.position;
            val_10.x = val_9.x - val_10.x;
            float val_19 = System.Math.Abs(val_10.x);
            if(((3.402823E+38f) > val_19) && (val_19 < 0))
            {
                    val_20 = val_19;
            }
            
            val_19 = 1;
            label_7:
            if(val_19 < this.wrap.GridItems.Count)
            {
                goto label_19;
            }
            
            if(val_20 == 1)
            {
                    return;
            }
            
            val_19 = this.七丝业下丆七下丙丆;
            if(this.wrap.GridItems.Item[0] == val_19)
            {
                    return;
            }
            
            val_19 = this.wrap.GridItems;
            this.专丆丞业丝丈且丗丄(下且专丒下丙丈丈丒:  val_19.Item[0].gameObject);
        }
        private void OnEnable()
        {
            object val_8;
            System.Predicate<Rilisoft.丅丏三专专丁丟下丈> val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = this;
            val_9 = 1152921504615739392;
            PGCompany.ClanWarProgressController.丈丕丝东丝丟丐世万(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanLobbyWarLeaderboardView::下丝丑下万下三与丙()));
            this.wrap.disableDragIfFits = false;
            this.wrap.unlimitedContent = true;
            this.wrap.allowNegativeIndices = true;
            this.centerOnChild.enabled = true;
            if(this.centerOnChild.onCenter == null)
            {
                    this.centerOnChild.onCenter = new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.ClanLobbyWarLeaderboardView::专丆丞业丝丈且丗丄(UnityEngine.GameObject 下且专丒下丙丈丈丒));
            }
            
            val_10 = null;
            val_10 = null;
            if(Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 != false)
            {
                    this.丂一丗丑丞上不世三();
            }
            else
            {
                    this.丝一丅丆三东丂丞七();
            }
            
            val_11 = null;
            val_11 = null;
            if(Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 == false)
            {
                goto label_14;
            }
            
            this.centerOnChild.enabled = false;
            System.Collections.Generic.List<Rilisoft.丅丏三专专丁丟下丈> val_5 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanLobbyWarLeaderboardView::丕丟丙丈丝丏七丏丙())).专丙丒上丗丙专丞七();
            val_12 = null;
            val_12 = null;
            val_9 = ClanLobbyWarLeaderboardView.<>c.<>9__17_1;
            if(val_9 == null)
            {
                goto label_20;
            }
            
            label_28:
            val_8 = val_5.FindIndex(match:  val_9);
            this.wrap.ScrollToCenterOnItem(世万专丛与丐丌专不:  val_8);
            val_11 = null;
            label_14:
            val_11 = null;
            Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 = false;
            return;
            label_20:
            ClanLobbyWarLeaderboardView.<>c.<>9__17_1 = new System.Predicate<Rilisoft.丅丏三专专丁丟下丈>(object:  ClanLobbyWarLeaderboardView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLobbyWarLeaderboardView.<>c::丅上三丘下丆万丅丟(Rilisoft.丅丏三专专丁丟下丈 三丟东丕丄丄下下丑));
            if(val_5 != null)
            {
                goto label_28;
            }
            
            goto label_28;
        }
        private void OnDisable()
        {
            PGCompany.ClanWarProgressController.与丄世上丏与且业东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanLobbyWarLeaderboardView::下丝丑下万下三与丙()));
        }
        private void 下丝丑下万下三与丙()
        {
            PGCompany.ClanWarProgressController.与丄世上丏与且业东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanLobbyWarLeaderboardView::下丝丑下万下三与丙()));
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            this.东丘丙且丐丛丏丝业();
            this.专丆丞业丝丈且丗丄();
        }
        internal void 丂一丗丑丞上不世三()
        {
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return;
            }
            
            this.东丘丙且丐丛丏丝业();
            this.专丆丞业丝丈且丗丄(下且专丒下丙丈丈丒:  this.丁丆丏且七一丆东一());
        }
        private void 专丆丞业丝丈且丗丄()
        {
            if(this.centerOnChild == 0)
            {
                    return;
            }
            
            if(this.centerOnChild.centeredObject == 0)
            {
                    return;
            }
            
            this.专丆丞业丝丈且丗丄(下且专丒下丙丈丈丒:  this.centerOnChild.centeredObject);
        }
        private void 专丆丞业丝丈且丗丄(UnityEngine.GameObject 下且专丒下丙丈丈丒)
        {
            Rilisoft.ClanLobbyWarLeaderboardViewItem val_14;
            if(下且专丒下丙丈丈丒 == 0)
            {
                    return;
            }
            
            val_14 = 下且专丒下丙丈丈丒.GetComponent<Rilisoft.ClanLobbyWarLeaderboardViewItem>();
            this.七丝业下丆七下丙丆 = val_14;
            if(val_14 == 0)
            {
                    return;
            }
            
            if(val_2.丁丂东丂丗丂丛丟一 == null)
            {
                    return;
            }
            
            val_14 = val_2.丁丂东丂丗丂丛丟一.丒万万专丑丛万丛丙();
            if(val_14 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanNameLabel, 丕丗丘丑丛与丑业丒:  val_14.东丙上东业丆不丟丘());
            UnityEngine.Color val_7 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  val_14.业丐丐三丕一丗丛丁(), 丏丆丗丂丟丘丈万万:  0);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.clanNameLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.tankPowerLabel, 丕丗丘丑丛与丑业丒:  val_14.三丒三丕不七丁丅丈());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.fortPowerLabel, 丕丗丘丑丛与丑业丒:  val_14.上上三七丟丝与丆与());
            val_14 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丙丏丌不丒一一丒上(丄丒下业一不丈丝丘:  val_14.业丐丐三丕一丗丛丁());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.zonesCapturedCount, 丕丗丘丑丛与丑业丒:  val_14.Count);
            this.上丒与上丗丌丐三与(下且专丒下丙丈丈丒:  下且专丒下丙丈丈丒);
        }
        private void 上丒与上丗丌丐三与(UnityEngine.GameObject 下且专丒下丙丈丈丒)
        {
            PGCompany.ItemCurrencyUI val_26;
            PGCompany.ItemCurrencyUI val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            UnityEngine.GameObject val_32;
            var val_33;
            var val_34;
            UnityEngine.MonoBehaviour val_35;
            val_27 = this;
            if(下且专丒下丙丈丈丒 == 0)
            {
                    return;
            }
            
            if((下且专丒下丙丈丈丒.GetComponent<Rilisoft.ClanLobbyWarLeaderboardViewItem>()) == 0)
            {
                    return;
            }
            
            if(val_2.丁丂东丂丗丂丛丟一 == null)
            {
                goto label_9;
            }
            
            val_28 = val_2.丁丂东丂丗丂丛丟一.丒万万专丑丛万丛丙();
            if(val_2.丁丂东丂丗丂丛丟一 == null)
            {
                goto label_10;
            }
            
            val_29 = val_2.丁丂东丂丗丂丛丟一.丞与丑与丑丙世丗丙();
            goto label_11;
            label_9:
            val_30 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            val_29 = 0;
            goto label_13;
            label_10:
            val_29 = 0;
            label_11:
            val_30 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_28 == null)
            {
                goto label_13;
            }
            
            val_31 = 0;
            goto label_14;
            label_13:
            val_28 = 0;
            val_31 = 1;
            label_14:
            一一万丒与专丙丁丛 val_9 = val_30.下丈丈与上丄丌东丐(专丑丕丄丗丂一丝且:  val_28.世丝丌一且丝专丑丛(), 且丒丛与丞世丙丕丌:  0);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.futureDivisionTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Shields/tournament_shield_{0}", arg0:  val_9)));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.futureDivisionNameLabel, 丕丗丘丑丛与丑业丒:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_9));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upDivisionSprite, 丏业丟一东丂东丘丛:  (val_9 > val_28.世丝丌一且丝专丑丛()) ? 1 : 0);
            val_32 = this.downDivisionSprite;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  (val_9 < val_28.世丝丌一且丝专丑丛()) ? 1 : 0);
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_18 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.东专三丏丞专丙不丝(专世专丟丝丌与丘上:  0);
            if(val_18 != null)
            {
                    val_33 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_18);
            }
            else
            {
                    val_33 = 0;
            }
            
            if(val_33 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardTexture, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardNameLabel, 丏业丟一东丂东丘丛:  true);
                PGCompany.丗丟丄丈东丝丕丄世 val_22 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_33.业东丅东丌上丗丑不());
                val_32 = val_22;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardNameLabel, 丕丗丘丑丛与丑业丒:  val_22);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardTexture, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardNameLabel, 丏业丟一东丂东丘丛:  false);
            }
            
            val_26 = this.currencyRewardUi;
            if(val_26 == 0)
            {
                goto label_34;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_24 = PGCompany.丂丘丞丂丏七丁丄不.不不丈丗丅丂世丕丗(专世专丟丝丌与丘上:  0);
            if((val_24 == null) || (val_24.丂丁丏一丙丛业且丌() < 1))
            {
                goto label_38;
            }
            
            val_26 = this.currencyRewardUi;
            val_26.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_24, 丗丂丞丛丒丒丟万丗:  false);
            val_27 = this.currencyRewardUi;
            val_34 = 1;
            val_35 = val_27;
            goto label_42;
            label_34:
            UnityEngine.Debug.LogError(message:  "ERROR currencyRewardUi == null");
            return;
            label_38:
            val_27 = this.currencyRewardUi;
            val_35 = val_27;
            val_34 = 0;
            label_42:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_35, 丏业丟一东丂东丘丛:  false);
        }
        private void 东丘丙且丐丛丏丝业()
        {
            this.wrap.UpdateContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  this.专丙丒上丗丙专丞七())));
        }
        private System.Collections.Generic.List<Rilisoft.丅丏三专专丁丟下丈> 专丙丒上丗丙专丞七()
        {
            System.Collections.Generic.IEnumerable<TSource> val_10;
            var val_11;
            System.Func<丞丂丘丒丟丞丑下丄, System.Int32, Rilisoft.丅丏三专专丁丟下丈> val_13;
            System.Collections.Generic.IEnumerable<丞丂丘丒丟丞丑下丄> val_3 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().一七丑下丙业丑丌丌();
            val_10 = val_3;
            if((System.Linq.Enumerable.Any<丞丂丘丒丟丞丑下丄>(source:  val_3)) != true)
            {
                    System.Collections.Generic.List<丞丂丘丒丟丞丑下丄> val_5 = null;
                val_10 = val_5;
                val_5 = new System.Collections.Generic.List<丞丂丘丒丟丞丑下丄>();
                val_5.Add(item:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟());
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = ClanLobbyWarLeaderboardView.<>c.<>9__26_0;
            if(val_13 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.丅丏三专专丁丟下丈>(source:  System.Linq.Enumerable.Select<丞丂丘丒丟丞丑下丄, Rilisoft.丅丏三专专丁丟下丈>(source:  val_5, selector:  System.Func<丞丂丘丒丟丞丑下丄, System.Int32, Rilisoft.丅丏三专专丁丟下丈> val_8 = null));
            }
            
            val_13 = val_8;
            val_8 = new System.Func<丞丂丘丒丟丞丑下丄, System.Int32, Rilisoft.丅丏三专专丁丟下丈>(object:  ClanLobbyWarLeaderboardView.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丅丏三专专丁丟下丈 ClanLobbyWarLeaderboardView.<>c::丂下业与丌世丁丟丞(丞丂丘丒丟丞丑下丄 三丟东丕丄丄下下丑, int 七丞丙丒三丕且丌丟));
            ClanLobbyWarLeaderboardView.<>c.<>9__26_0 = val_13;
            return System.Linq.Enumerable.ToList<Rilisoft.丅丏三专专丁丟下丈>(source:  System.Linq.Enumerable.Select<丞丂丘丒丟丞丑下丄, Rilisoft.丅丏三专专丁丟下丈>(source:  val_5, selector:  val_8));
        }
        private UnityEngine.GameObject 丁丆丏且七一丆东一()
        {
            var val_4;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            List.Enumerator<T> val_2 = this.wrap.GridItems.GetEnumerator();
            label_14:
            if(((-875278416) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5 != null)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            val_15 = 0;
            goto label_6;
            label_5:
            if(val_5 != null)
            {
                    if(val_5.丒万万专丑丛万丛丙() != null)
            {
                goto label_8;
            }
            
            }
            
            val_16 = 0;
            label_8:
            int val_7 = val_16.丁丈丞一专下丛丕三();
            val_4 = 0;
            val_15 = val_4;
            label_6:
            丞丂丘丒丟丞丑下丄 val_9 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_9 != null)
            {
                    int val_11 = (val_9 == 0) ? 0 : (val_9).丁丈丞一专下丛丕三();
                val_4 = 0;
                val_17 = val_4;
            }
            else
            {
                    val_17 = 0;
            }
            
            if((val_15.丙东专丂世丈丏丁丂() != val_17.丙东专丂世丈丏丁丂()) || ((8 & 1) != 0))
            {
                goto label_14;
            }
            
            val_18 = val_5.gameObject;
            goto label_16;
            label_3:
            val_18 = 0;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (UnityEngine.GameObject)val_18;
        }
        public ClanLobbyWarLeaderboardView()
        {
            this.distanceToUpdateClan = 0.07f;
        }
        private static ClanLobbyWarLeaderboardView()
        {
            Rilisoft.ClanLobbyWarLeaderboardView.一下丆丌丂上丟丈且 = true;
        }
        private void 丕丟丙丈丝丏七丏丙()
        {
            this.centerOnChild.enabled = true;
        }
    
    }

}
