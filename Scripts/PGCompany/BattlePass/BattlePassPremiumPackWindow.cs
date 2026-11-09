using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassPremiumPackWindow : MonoBehaviour
    {
        // Fields
        private static PGCompany.BattlePass.BattlePassPremiumPackWindow 丝业丆丁业三丈丟东;
        private System.IDisposable 丄丘业与丈丛丛丝世;
        private bool 丒丂丏且上丌下丙丙;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPReward> 丑丘七丄万丐三下世;
        private PGCompany.BattlePass.BPReward 丟七丐丝东且丟七丘;
        private int 丝丙丌且专丅东丞业;
        private UnityEngine.Coroutine 丗专东丗丌不一丘丙;
        private static System.Action 丛丄业丘不丆丄三丞;
        private System.Collections.Generic.List<UnityEngine.GameObject> _baseContent;
        private System.Collections.Generic.List<UnityEngine.GameObject> _goldContent;
        private System.Collections.Generic.List<UILabel> _priceLabels;
        private System.Collections.Generic.List<UILabel> _priceOldLabels;
        private Rilisoft.BetterWrapContent _wrap;
        private Rilisoft.CharacterHelper _characterHelper;
        private System.Collections.Generic.List<UITable> _tables;
        public UILabel _itemName;
        public UILabel _itemDescription;
        
        // Methods
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassPremiumPackWindow.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassPremiumPackWindow.丛丄业丘不丆丄三丞 != 1152921505683206152);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassPremiumPackWindow.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassPremiumPackWindow.丛丄业丘不丆丄三丞 != 1152921505683206152);
        
        }
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专, int 丏业丟一东丂东丘丛)
        {
            PGCompany.BattlePass.BattlePassPremiumPackWindow val_11;
            if(丆丏七丟不丒与七专 == 0)
            {
                    return;
            }
            
            val_11 = PGCompany.BattlePass.BattlePassPremiumPackWindow.丝业丆丁业三丈丟东;
            if(val_11 != 0)
            {
                    return;
            }
            
            val_11 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPPremiumPack");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true)
            {
                    return;
            }
            
            val_11 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_11);
            if(val_11 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
            int val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            UnityEngine.GameObject val_8 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_11, 丈东丘丏与丌东东下:  丆丏七丟不丒与七专, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BattlePassPremiumPackWindow.丝业丆丁业三丈丟东 = val_8.GetComponent<PGCompany.BattlePass.BattlePassPremiumPackWindow>();
            val_11 = PGCompany.BattlePass.BattlePassPremiumPackWindow.丝业丆丁业三丈丟东;
            if(val_11 == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_8);
                return;
            }
            
            val_11 = PGCompany.BattlePass.BattlePassPremiumPackWindow.丝业丆丁业三丈丟东;
            丝丙丌且专丅东丞业 = 丏业丟一东丂东丘丛;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BattlePassPremiumPackWindow.丝业丆丁业三丈丟东 = 0;
        }
        private void OnEnable()
        {
            if(this.丄丘业与丈丛丛丝世 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丄丘业与丈丛丛丝世.Dispose();
            }
            
            this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassPremiumPackWindow::Hide()), 与且专丈不万东一万:  0);
            this.丝一丅丆三东丂丞七();
        }
        private void OnDisable()
        {
            if(this.丄丘业与丈丛丛丝世 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_11;
            System.Collections.Generic.List<PGCompany.BattlePass.BPReward> val_35;
            var val_36;
            int val_37;
            var val_38;
            var val_39;
            int val_40;
            int val_41;
            val_35 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_35 == null)
            {
                    return;
            }
            
            if(this._priceLabels != null)
            {
                    if(this.丝丙丌且专丅东丞业 == 1)
            {
                    int val_4 = val_35.三丒丅世业三丈丙丕();
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._priceLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_35.不世丆丒丛七丘与丅()));
            }
            
            if(this._priceOldLabels != null)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._priceOldLabels, 丕丗丘丑丛与丑业丒:  AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_35.丒丝丒东万丅与东丄()));
            }
            
            val_36 = 1152921519068962256;
            List.Enumerator<T> val_9 = this._baseContent.GetEnumerator();
            val_37 = 1152921519068956112;
            label_19:
            if(((-336188384) & 1) == 0)
            {
                goto label_16;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  (this.丝丙丌且专丅东丞业 == 0) ? 1 : 0);
            goto label_19;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_14 = this._goldContent.GetEnumerator();
            label_28:
            if(((-336188384) & 1) == 0)
            {
                goto label_25;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  (this.丝丙丌且专丅东丞业 == 1) ? 1 : 0);
            goto label_28;
            label_25:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this._tables == null)
            {
                goto label_61;
            }
            
            List.Enumerator<T> val_17 = this._tables.GetEnumerator();
            val_37 = 1152921538004471968;
            val_36 = 1152921504848912384;
            label_40:
            if(((-336188416) & 1) == 0)
            {
                goto label_34;
            }
            
            string val_18 = val_11.丐丏七丌丕丗业且上();
            if(val_18 == 0)
            {
                goto label_40;
            }
            
            val_18.repositionNow = true;
            if(val_18 != null)
            {
                goto label_40;
            }
            
            goto label_40;
            label_34:
            val_38 = 0;
            val_39 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if( == 1)
            {
                goto label_46;
            }
            
            if(( == 0) || (306 == 306))
            {
                goto label_61;
            }
            
            label_60:
            label_61:
            val_40 = this.丝丙丌且专丅东丞业;
            val_41 = val_35.业丈丅丂且丁与丄丂();
            if(val_40 != 0)
            {
                    val_40 = val_35.专世丙七东与丘东丒();
                val_37 = val_35.丄且东且丕丛与丆丒();
                val_41 = UnityEngine.Mathf.Clamp(value:  val_40 + val_41, min:  val_35.业丈丅丂且丁与丄丂(), max:  val_37);
            }
            
            .丞丁丏且与丒丐业下 = val_41;
            val_11 = 0;
            System.Collections.Generic.List<TSource> val_29 = System.Linq.Enumerable.ToList<PGCompany.BattlePass.BPReward>(source:  System.Linq.Enumerable.Where<PGCompany.BattlePass.BPReward>(source:  val_35.业下丈丕丙丁东世丙(上丌丆丁丟上下专丁:  new System.Nullable<PlayerPaymentState>() {HasValue = false}, 丈丘丝一丗下丈丐不:  new System.Nullable<System.Int32>() {HasValue = false}, 不丝丟与丟丈一三与:  false), predicate:  new System.Func<PGCompany.BattlePass.BPReward, System.Boolean>(object:  new BattlePassPremiumPackWindow.丌丟丘丏丕丅七万丕(), method:  System.Boolean BattlePassPremiumPackWindow.丌丟丘丏丕丅七万丕::七丅丐丏丝七丄丏丛(PGCompany.BattlePass.BPReward 东七上世万下丗丄丛))));
            this.丑丘七丄万丐三下世 = val_29;
            this.丟七丐丝东且丟七丘 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPReward>(source:  val_29);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._characterHelper, 丏业丟一东丂东丘丛:  true);
            this._characterHelper.CharacterVisible = true;
            BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            System.Collections.Generic.List<PGCompany.BattlePass.BPReward> val_31 = null;
            val_35 = val_31;
            val_31 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
            val_31.Add(item:  this.丟七丐丝东且丟七丘);
            BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  this._characterHelper, 丒丟丕上丅丆丆丝东:  0, 丏七丟丐丏丞丄不丅:  false, 丝丆下丐东世上一且:  0, 上业丟世三与七七三:  val_31, 丒丈七三丄丞丐丝丂:  0);
            if(this.丗专东丗丌不一丘丙 != null)
            {
                    this.StopCoroutine(routine:  this.丗专东丗丌不一丘丙);
            }
            
            this.丗专东丗丌不一丘丙 = this.StartCoroutine(routine:  this.万一丝万丒一丆专丄());
            return;
            label_46:
            if( != 0)
            {
                goto label_60;
            }
            
            goto label_61;
        }
        private System.Collections.IEnumerator 万一丝万丒一丆专丄()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassPremiumPackWindow.专与万上丛丝专丏万();
        }
        private void 丂上下丟丕东丁丛不(UnityEngine.GameObject 丕一一丆丌丝丕业万, int 丘丒丌下丕专且七专)
        {
            if((this.丑丘七丄万丐三下世 == null) || (this.丑丘七丄万丐三下世.Count <= 丘丒丌下丕专且七专))
            {
                goto label_2;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  true);
            PGCompany.BattlePass.BPReward val_2 = this.丑丘七丄万丐三下世.Item[丘丒丌下丕专且七专];
            PGCompany.BattlePass.BPRewardView val_3 = 丕一一丆丌丝丕业万.GetComponent<PGCompany.BattlePass.BPRewardView>();
            if(val_3 != 0)
            {
                goto label_9;
            }
            
            return;
            label_2:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丕一一丆丌丝丕业万, 丏业丟一东丂东丘丛:  false);
            return;
            label_9:
            val_3.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassPremiumPackWindow::丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 七丅三丆专东与丗丆)));
            System.Action<PGCompany.BattlePass.BPRewardView> val_6 = new System.Action<PGCompany.BattlePass.BPRewardView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassPremiumPackWindow::丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 七丅三丆专东与丗丆));
            if(val_3 != null)
            {
                    val_3.add_Clicked(丙业与丙丗丝不丈东:  val_6);
            }
            else
            {
                    val_3.add_Clicked(丙业与丙丗丝不丈东:  val_6);
            }
            
            val_3.Setup(与且专丈不万东一万:  val_2);
            val_3.IsSelected = ((this.丟七丐丝东且丟七丘 == val_2) ? 1 : 0) & ((this.丟七丐丝东且丟七丘 != 0) ? 1 : 0);
        }
        private void 丗业与丐与一世丝丌(PGCompany.BattlePass.BPRewardView 七丅三丆专东与丗丆)
        {
            string val_6;
            var val_7;
            string val_28;
            string val_30;
            if(七丅三丆专东与丗丆 == 0)
            {
                    return;
            }
            
            if(七丅三丆专东与丗丆.Context == null)
            {
                    return;
            }
            
            this.丟七丐丝东且丟七丘 = 七丅三丆专东与丗丆.Context;
            List.Enumerator<T> val_5 = this._wrap.GetAllCellsObjects().GetEnumerator();
            var val_29 = 0;
            label_21:
            if(((-335527824) & 1) == 0)
            {
                goto label_9;
            }
            
            PGCompany.BattlePass.BPRewardView val_9 = val_7.丐丏七丌丕丗业且上().GetComponent<PGCompany.BattlePass.BPRewardView>();
            if(val_9 == 0)
            {
                goto label_21;
            }
            
            if(val_9 == 七丅三丆专东与丗丆)
            {
                    val_29 = val_29 | val_9.IsSelected;
            }
            
            PGCompany.BattlePass.BPRewardView val_30 = 七丅三丆专东与丗丆;
            val_30 = UnityEngine.Object.op_Equality(x:  val_9, y:  val_30);
            val_9.IsSelected = val_30;
            goto label_21;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_29 & 1) != 0)
            {
                goto label_22;
            }
            
            goto label_32;
            label_22:
            Rilisoft.ItemViewer val_19 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewBattlePass", 丆丏七丟不丒与七专:  this.transform, 丕丁下丌不万丅丞丛:  this.丟七丐丝东且丟七丘.Item.Id, 丅三丟世下丞丝丙万:  this.丟七丐丝东且丟七丘.Item.Count, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
            goto label_46;
            label_32:
            if(this.丟七丐丝东且丟七丘.Item.IsEquipment != false)
            {
                    System.Collections.Generic.List<PGCompany.BattlePass.BPReward> val_22 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
                val_22.Add(item:  this.丟七丐丝东且丟七丘);
                BattlePassRootUI.与丈不丟丄三七丗上(丆丆东专丟丂丈万不:  this._characterHelper, 丒丟丕上丅丆丆丝东:  0, 丏七丟丐丏丞丄不丅:  false, 丝丆下丐东世上一且:  0, 上业丟世三与七七三:  val_22, 丒丈七三丄丞丐丝丂:  0);
            }
            else
            {
                    BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            }
            
            label_46:
            丒与上丅丒丘与丒丘 val_27 = Rilisoft.ItemViewer.东且丏丆万与东丙万(丕丁下丌不万丅丞丛:  this.丟七丐丝东且丟七丘.Item.Id, 丅三丟世下丞丝丙万:  this.丟七丐丝东且丟七丘.Item.Count);
            val_30 = val_28;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemName, 丕丗丘丑丛与丑业丒:  val_30);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemDescription, 丕丗丘丑丛与丑业丒:  val_6);
        }
        public void Hide()
        {
            BattlePassRootUI.丗业丐丄丌丁丁丛丆(丞丛丈丝不丛丒丌丐:  this._characterHelper);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            if(PGCompany.BattlePass.BattlePassPremiumPackWindow.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassPremiumPackWindow.丛丄业丘不丆丄三丞.Invoke();
        }
        public void U_Back()
        {
            this.Hide();
        }
        public void U_BuyPremium()
        {
            if(PGCompany.BattlePass.BattlePassBuyPremiumWindow.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            bool val_4 = PGCompany.BattlePass.BattlePassBuyPremiumWindow.丑七不且上丗丁一世().BuyPremiumCore(丏七丗丝七丘一丙丗:  false);
        }
        public void U_BuyPremiumAndLevels()
        {
            if(PGCompany.BattlePass.BattlePassBuyPremiumWindow.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            bool val_4 = PGCompany.BattlePass.BattlePassBuyPremiumWindow.丑七不且上丗丁一世().BuyPremiumCore(丏七丗丝七丘一丙丗:  true);
        }
        public void BuyCurrency()
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    BattlePassRootUI.丑七不且上丗丁一世().ShowBuyCurrencyWindow();
                return;
            }
            
            if(PGCompany.BattlePass.BPSeasonEnd.Instance == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BPSeasonEnd.Instance.ShowBuyCurrencyWindow();
        }
        public BattlePassPremiumPackWindow()
        {
            this.丒丂丏且上丌下丙丙 = true;
            this.丑丘七丄万丐三下世 = new System.Collections.Generic.List<PGCompany.BattlePass.BPReward>();
        }
        private int 万丐丌丅丌丟丘丘丈()
        {
            int val_1 = this.丑丘七丄万丐三下世.Count;
            val_1 = val_1 - 1;
            return (int)val_1;
        }
    
    }

}
