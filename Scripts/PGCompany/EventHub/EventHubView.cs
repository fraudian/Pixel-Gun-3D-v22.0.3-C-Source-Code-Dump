using UnityEngine;

namespace PGCompany.EventHub
{
    public sealed class EventHubView : PGBehaviour
    {
        // Fields
        private PGCompany.EventHub.EventHubBanner 下专丐丅丆丏三丂丅;
        private PGCompany.EventHub.丅丝丙与丑七不丛世 业专万丏丘丙丝一丕;
        private System.TimeSpan 丁专丏一丄丛业丘专;
        private bool 丑丂东丈丂丛下丌下;
        private System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 业业丏丞丞丄东丒下;
        private readonly System.Collections.Generic.HashSet<PGCompany.EventHub.丄世丌东丏三东丒丂> 丙东丅丅丐丆不世丐;
        private System.Collections.Generic.List<PGCompany.EventHub.EventButton> _eventButtons;
        private SelectableButtonController _eventButtonsSelectableButtonController;
        private SelectableButtonController _scrollItemsSelectableButtonController;
        private DynamicWrapGrid _itemsDynamicWrapGrid;
        private UILabel _untilEventEndLabel;
        private UILabel _titleLabel;
        private UILabel _subtitleLabel;
        private Rilisoft.CharacterHelper _characterHelper;
        private UnityEngine.MeshRenderer _backgroundMeshRenderer;
        private UIButton _goToEventButton;
        private UnityEngine.GameObject _goToPresentationButtonContainer;
        private BonusPromotionsView bonusPromotionsView;
        private UnityEngine.GameObject CharacterContainer;
        private PGCompany.EventHub.丄世丌东丏三东丒丂 <丈丟且丘丟专丑丑丙>k__BackingField;
        
        // Properties
        internal PGCompany.EventHub.EventHubBanner 丝丛丞专丞丟丘世丄 { get; }
        internal PGCompany.EventHub.丄世丌东丏三东丒丂 丟丞丅不丗业丂东丑 { get; set; }
        
        // Methods
        internal PGCompany.EventHub.EventHubBanner 东七业上丂万业丌不()
        {
            return (PGCompany.EventHub.EventHubBanner)this.下专丐丅丆丏三丂丅;
        }
        private void Awake()
        {
            this.丑丂东丈丂丛下丌下 = true;
            if(this.bonusPromotionsView == 0)
            {
                    return;
            }
            
            this.bonusPromotionsView.且丏丗丌丌丄丕丅丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::丛业丁不与丙且丕丙()));
            this.bonusPromotionsView.丒丗丑丁丙业丏丏与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::一丟丂丆下丛丐上上()));
        }
        private void OnDestroy()
        {
            if(this.bonusPromotionsView == 0)
            {
                    return;
            }
            
            this.bonusPromotionsView.丐丑丘七丄下丝丏丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::丛业丁不与丙且丕丙()));
            this.bonusPromotionsView.东丅一丝丂三七专丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::一丟丂丆下丛丐上上()));
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.EventHub.EventHubBanner 丈丁丅丈丌三丕七丗, PGCompany.EventHub.丅丝丙与丑七不丛世 丒专丈丛下丒一丒丛)
        {
            this.下专丐丅丆丏三丂丅 = 丈丁丅丈丌三丕七丗;
            this.业专万丏丘丙丝一丕 = 丒专丈丛下丒一丒丛;
            this._itemsDynamicWrapGrid.scaleWidth = false;
            this.与专东丁丒丂丆丙丑();
            this.不丁七丌丛丛丘东丄();
            this.下丁万万丅丆东不不();
            this.丝丅与丒东世丒丁丕();
            this._scrollItemsSelectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::万一东丝丒丂一丛丅()));
            this._scrollItemsSelectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::万一东丝丒丂一丛丅()));
            PGCompany.Analytics.一业丗丆世世上丁且.万业丑丌与丙丅下丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  1, 且下丕七丙丗丄不七:  0, 下丗丁丒丘东丂不丑:  0, 丟下丟丈万一丙东丄:  0);
        }
        private void 丝丅与丒东世丒丁丕()
        {
            this._characterHelper.CharacterVisible = true;
        }
        private void 下丁万万丅丆东不不()
        {
            goto label_1;
            label_9:
            PGCompany.EventHub.EventButton val_1 = this._eventButtons.Item[0];
            if(val_1 != 0)
            {
                    if(val_1.丁丘丄丕下专东七不 != null)
            {
                goto label_7;
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < this._eventButtons.Count)
            {
                goto label_9;
            }
            
            return;
            label_7:
            SelectableButton val_4 = val_1.GetComponent<SelectableButton>();
            if(val_4 == 0)
            {
                    return;
            }
            
            if(val_4 == null)
            {
                
            }
        
        }
        private void 与专东丁丒丂丆丙丑()
        {
            var val_7;
            var val_18;
            var val_19;
            var val_20;
            bool val_21;
            PGCompany.EventHub.丅丝丙与丑七不丛世 val_22;
            PGCompany.EventHub.业丝下专丗且上丆万 val_23;
            System.Collections.Generic.HashSet<PGCompany.EventHub.丄世丌东丏三东丒丂> val_1 = new System.Collections.Generic.HashSet<PGCompany.EventHub.丄世丌东丏三东丒丂>();
            val_18 = 1152921559752769696;
            val_19 = 1152921559752770720;
            val_20 = 0;
            goto label_1;
            label_34:
            PGCompany.EventHub.EventButton val_2 = this._eventButtons.Item[0];
            if(val_2 == 0)
            {
                goto label_5;
            }
            
            if((this.业专万丏丘丙丝一丕.<丘丛丒丘丙一不丞上>k__BackingField.<业一专且丗丈丒与丂>k__BackingField.Count) > val_20)
            {
                goto label_9;
            }
            
            HashSet.Enumerator<T> val_5 = this.丙东丅丅丐丆不世丐.GetEnumerator();
            label_13:
            if(((-688376704) & 1) == 0)
            {
                goto label_11;
            }
            
            int val_8 = val_7.丙东专丂世丈丏丁丂();
            if((val_1.Contains(item:  val_8)) == true)
            {
                goto label_13;
            }
            
            val_2.<丆丅丂丕丕丆丁丌万>k__BackingField = val_8;
            label_11:
            val_21 = 0;
            var val_18 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_18 == 1) || (190 != 190))
            {
                goto label_22;
            }
            
            val_22 = this.业专万丏丘丙丝一丕;
            var val_17 = 0;
            val_17 = val_17 ^ 0;
            val_18 = val_18 + val_17;
            val_23 = 0;
            goto label_24;
            label_22:
            label_9:
            val_23 = this.业专万丏丘丙丝一丕.<丘丛丒丘丙一不丞上>k__BackingField.<业一专且丗丈丒与丂>k__BackingField.Item[0];
            val_2.<丆丅丂丕丕丆丁丌万>k__BackingField = val_11.<且丈丁专东丆丄丂与>k__BackingField;
            bool val_12 = val_1.Add(item:  val_11.<且丈丁专东丆丄丂与>k__BackingField);
            val_22 = this.业专万丏丘丙丝一丕;
            label_24:
            val_2.丈且东丑丂且万丒丅(一丐丗丁丞丆丅丟丄:  val_23, 丘世丌七丝七丑一丁:  val_22.且丌与东七丛专丘东(丁丅丈丌丟世丗丗丟:  val_2.<丆丅丂丕丕丆丁丌万>k__BackingField), 丂丒丁丑东丑丁丕丑:  this.业专万丏丘丙丝一丕);
            val_18 = 1152921559752769696;
            val_19 = 1152921559752770720;
            label_5:
            val_20 = 1;
            label_1:
            if(val_20 < this._eventButtons.Count)
            {
                goto label_34;
            }
            
            this._eventButtonsSelectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::丂与丐丌丗上丘东丏()));
            this._eventButtonsSelectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubView::丂与丐丌丗上丘东丏()));
        }
        private void 不丁七丌丛丛丘东丄()
        {
            goto label_1;
            label_13:
            if((this._eventButtons.Item[0].GetComponent<SelectableButton>()) != 0)
            {
                    PGCompany.EventHub.EventButton val_4 = this._eventButtons.Item[0];
                val_2.canInteract = (val_4.丁丘丄丕下专东七不 != 0) ? 1 : 0;
            }
            
            0 = 1;
            label_1:
            if(0 < this._eventButtons.Count)
            {
                goto label_13;
            }
        
        }
        private void 丂与丐丌丗上丘东丏()
        {
            if(this._eventButtonsSelectableButtonController.selectedButton == 0)
            {
                    return;
            }
            
            if((this._eventButtonsSelectableButtonController.selectedButton.GetComponent<PGCompany.EventHub.EventButton>()) == 0)
            {
                    return;
            }
            
            if((val_2.<丆丅丂丕丕丆丁丌万>k__BackingField) == 0)
            {
                    return;
            }
            
            this.业专万丏丘丙丝一丕.世一丐丘丝丕丞丘丑(丁丅丈丌丟世丗丗丟:  val_2.<丆丅丂丕丕丆丁丌万>k__BackingField);
        }
        private void 万一东丝丒丂一丛丅()
        {
            if(this._scrollItemsSelectableButtonController.selectedButton == 0)
            {
                    return;
            }
            
            if((this._scrollItemsSelectableButtonController.selectedButton.GetComponent<PGCompany.EventHub.HubScrollDynamicWrapGridItem>()) == 0)
            {
                    return;
            }
            
            this.业专万丏丘丙丝一丕.丐上专业丕丈丏丐万(丞丘丞丏业且丛丏丘:  val_2.<丝业三丑三上丆专不>k__BackingField);
        }
        internal void 业丁七三丛上丕东丈(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丄上丏丝丒丅丆且丄)
        {
            var val_18;
            if(this.丑丂东丈丂丛下丌下 != false)
            {
                    this.业业丏丞丞丄东丒下 = 丄上丏丝丒丅丆且丄;
                return;
            }
            
            this._itemsDynamicWrapGrid.ScrollView.StopMomentumForce();
            UnityEngine.Vector2 val_4 = this._itemsDynamicWrapGrid.ScrollView.panel.GetViewSize();
            this._itemsDynamicWrapGrid.allowNegativeIndices = (丄上丏丝丒丅丆且丄.Count > ((int)val_4.x / 180f)) ? 1 : 0;
            this._itemsDynamicWrapGrid.unlimitedContent = (丄上丏丝丒丅丆且丄.Count > ((int)val_4.x / 180f)) ? 1 : 0;
            this._itemsDynamicWrapGrid.UpdateContent(三丏丑不业丏不丂丈:  new System.Collections.Generic.List<System.Object>(collection:  丄上丏丝丒丅丆且丄));
            this._itemsDynamicWrapGrid.ScrollToCenterOnItem(世万专丛与丐丌专不:  0);
            this._scrollItemsSelectableButtonController.allButtons.Clear();
            val_18 = 0;
            goto label_15;
            label_29:
            DynamicWrapGridItem val_12 = this._itemsDynamicWrapGrid.GridItems.Item[0];
            if(val_12 != 0)
            {
                    if((val_12.GetComponent<SelectableButton>()) == 0)
            {
                    return;
            }
            
                val_14.selectableButtonController = this._scrollItemsSelectableButtonController;
            }
            
            val_18 = 1;
            label_15:
            if(val_18 < this._itemsDynamicWrapGrid.GridItems.Count)
            {
                goto label_29;
            }
            
            this._scrollItemsSelectableButtonController.丞与万丕丈丒丌丆世();
        }
        public void SetBackground(UnityEngine.Material 且丂丕业丞丗东业丕)
        {
            this._backgroundMeshRenderer.material = 且丂丕业丞丗东业丕;
        }
        internal void 万一丆丛专丏一一丌(PGCompany.丌丙丈丕丛丆丝丗丟 丅世丟三下丌丝七与, PGCompany.丟丝东丈丐丙三下丛 丌丝下丄业一丄不三)
        {
            string val_12;
            var val_13;
            var val_14;
            if(丌丝下丄业一丄不三 == null)
            {
                goto label_1;
            }
            
            val_12 = 丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛();
            if(val_12 != null)
            {
                goto label_3;
            }
            
            label_1:
            val_13 = null;
            val_13 = null;
            val_12 = 与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与;
            label_3:
            this._characterHelper.SetWeapon(三不三丟专丘东东丂:  val_12);
            if(丅世丟三下丌丝七与 == null)
            {
                goto label_7;
            }
            
            label_21:
            this._characterHelper.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丅世丟三下丌丝七与.丂丈世丞东专且丁丌());
            return;
            label_7:
            if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈())) == false) || ((System.String.op_Inequality(a:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈(), b:  "EMPTY_ROYALE_AVATAR")) == false))
            {
                goto label_17;
            }
            
            CharacterInterfaceV2 val_9 = this._characterHelper.丟丑万与丒与不下丛();
            string val_10 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
            goto label_21;
            label_17:
            val_14 = null;
            val_14 = null;
            this._characterHelper.丟丑万与丒与不下丛().上丈一万东三东世东(丂丒丘丅专丗丂世丛:  SkinsController.丌与世丂丘且下丒丑);
        }
        internal void 万一丆丛专丏一一丌(PGCompany.丟丝东丈丐丙三下丛 丌丝下丄业一丄不三)
        {
            if(丌丝下丄业一丄不三 == null)
            {
                    return;
            }
            
            this._characterHelper.SetWeapon(三不三丟专丘东东丂:  丌丝下丄业一丄不三.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛());
        }
        internal void 万一丆丛专丏一一丌(PGCompany.丌丙丈丕丛丆丝丗丟 丅世丟三下丌丝七与)
        {
            if(丅世丟三下丌丝七与 == null)
            {
                    return;
            }
            
            this._characterHelper.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丅世丟三下丌丝七与.丂丈世丞东专且丁丌());
        }
        public void SetTitle(string 丕丗丘丑丛与丑业丒)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        }
        public void SetSubtitle(string 丕丗丘丑丛与丑业丒)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._subtitleLabel, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        }
        public void SetTimerUntilEventEnd(int 丑丗丕不业丕丌丙七)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)丑丗丕不业丕丌丙七);
            this.丁专丏一丄丛业丘专 = val_1;
            this.丝丂丕东专世丅丝丁(丐且丁丒丒丑业万丝:  (丑丗丕不业丕丌丙七 == 0) ? 1 : 0);
        }
        private string 专业丏东业丛丞丏丑(System.TimeSpan 丗丂世丈丝丞丝上丑)
        {
            string val_10;
            if(丗丂世丈丝丞丝上丑._ticks.Days >= 1)
            {
                    val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6526");
                int val_3 = 丗丂世丈丝丞丝上丑._ticks.Days;
                return (string)System.String.Format(format:  val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6528"), arg0:  丗丂世丈丝丞丝上丑._ticks.Minutes);
            }
            
            if(丗丂世丈丝丞丝上丑._ticks.Hours >= 1)
            {
                    val_10 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6527");
                int val_6 = 丗丂世丈丝丞丝上丑._ticks.Hours;
                return (string)System.String.Format(format:  val_10, arg0:  丗丂世丈丝丞丝上丑._ticks.Minutes);
            }
            
            return (string)System.String.Format(format:  val_10, arg0:  丗丂世丈丝丞丝上丑._ticks.Minutes);
        }
        internal void 丆丈丁东不丟丌丌世(bool 丛丅丘一丏丙且丌上)
        {
            丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._goToEventButton, 丏业丟一东丂东丘丛:  丛丅丘一丏丙且丌上);
        }
        internal void 专丙东三丙丆业丐三(bool 丛丅丘一丏丙且丌上)
        {
            丛丅丘一丏丙且丌上 = 丛丅丘一丏丙且丌上;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goToPresentationButtonContainer, 丏业丟一东丂东丘丛:  丛丅丘一丏丙且丌上);
        }
        internal void 世一丐丘丝丕丞丘丑(PGCompany.EventHub.丄世丌东丏三东丒丂 丁丅丈丌丟世丗丗丟)
        {
            string val_8;
            TagSystem.三与下丘七丘丌丏丄 val_1 = new TagSystem.三与下丘七丘丌丏丄();
            if(丁丅丈丌丟世丗丗丟 == 3)
            {
                goto label_1;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 4)
            {
                goto label_2;
            }
            
            if(val_1 == null)
            {
                goto label_3;
            }
            
            bool val_2 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "source.bonuses.battlePassCurrency");
            goto label_4;
            label_1:
            if(val_1 == null)
            {
                goto label_5;
            }
            
            bool val_3 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "source.bonuses.event_currence");
            goto label_6;
            label_3:
            bool val_4 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "source.bonuses.battlePassCurrency");
            label_4:
            val_8 = "promotion.content.battlepasscurrency";
            goto label_7;
            label_5:
            bool val_5 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "source.bonuses.event_currence");
            label_6:
            val_8 = "promotion.content.eventcurrency";
            label_7:
            bool val_6 = val_1.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  val_8);
            label_2:
            this.bonusPromotionsView.丝一丅下且一丟丒世(丐丑丒丕丐丟丐东与:  new TagSystem.丞丟一丅丐专三万不(东丌丕上丞万丌丙丑:  val_1, 丟且丒专下丈七丗丕:  4));
        }
        internal PGCompany.EventHub.丄世丌东丏三东丒丂 丝丒丝丄且万丘下丌()
        {
            return (PGCompany.EventHub.丄世丌东丏三东丒丂)this.<丈丟且丘丟专丑丑丙>k__BackingField;
        }
        private void 一下世三丟下丆业专(PGCompany.EventHub.丄世丌东丏三东丒丂 丙业与丙丗丝不丈东)
        {
            this.<丈丟且丘丟专丑丑丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丄丑上丕丂丈丘丙七()
        {
            this.<丈丟且丘丟专丑丑丙>k__BackingField = this.丞世专丙且丘丟万丕();
            this._eventButtonsSelectableButtonController.丞与万丕丈丒丌丆世();
        }
        public void U_GoToEventClicked()
        {
            if(this._eventButtonsSelectableButtonController.selectedButton == 0)
            {
                    return;
            }
            
            if((this._eventButtonsSelectableButtonController.selectedButton.GetComponent<PGCompany.EventHub.EventButton>()) == 0)
            {
                    return;
            }
            
            this.业专万丏丘丙丝一丕.丝丅丌丛丛丄丆丌丗(丁丅丈丌丟世丗丗丟:  val_2.<丆丅丂丕丕丆丁丌万>k__BackingField);
        }
        private void Update()
        {
            var val_7;
            if(this.丁专丏一丄丛业丘专.TotalSeconds > 0f)
            {
                    System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)UnityEngine.Time.deltaTime);
                this.丁专丏一丄丛业丘专 = this.丁专丏一丄丛业丘专;
                val_7 = 0;
            }
            else
            {
                    val_7 = 1;
            }
            
            this.丝丂丕东专世丅丝丁(丐且丁丒丒丑业万丝:  true);
            this.上丟业丏丒丄丒三世();
            if(this.业业丏丞丞丄东丒下 == null)
            {
                    return;
            }
            
            if(this.丑丂东丈丂丛下丌下 == false)
            {
                    return;
            }
            
            if(this.下专丐丅丆丏三丂丅.上丒丆丗东与丄世下() == false)
            {
                    return;
            }
            
            this.丑丂东丈丂丛下丌下 = false;
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.专东丁三丕三三丐丟());
        }
        private System.Collections.IEnumerator 专东丁三丕三三丐丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new EventHubView.东不东丏上业丐丟不();
        }
        private void 上丟业丏丒丄丒三世()
        {
            var val_6;
            UnityEngine.MonoBehaviour val_7;
            var val_8;
            val_6 = this;
            if(this._eventButtonsSelectableButtonController.selectedButton == 0)
            {
                    return;
            }
            
            if((this._eventButtonsSelectableButtonController.selectedButton.GetComponent<PGCompany.EventHub.EventButton>()) == 0)
            {
                    return;
            }
            
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                goto label_11;
            }
            
            PGCompany.EventHub.丁七丑丝丂丄丅丏丑 val_5 = this.业专万丏丘丙丝一丕.且丌与东七丛专丘东(丁丅丈丌丟世丗丗丟:  val_2.<丆丅丂丕丕丆丁丌万>k__BackingField);
            if(val_5 == null)
            {
                goto label_14;
            }
            
            val_6 = val_5 & 1;
            goto label_15;
            label_11:
            val_7 = this._goToEventButton;
            val_8 = 0;
            goto label_18;
            label_14:
            val_6 = 0;
            label_15:
            val_7 = this._goToEventButton;
            val_8 = val_6;
            label_18:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  false);
        }
        private PGCompany.EventHub.丄世丌东丏三东丒丂 丞世专丙且丘丟万丕()
        {
            SelectableButton val_4;
            PGCompany.EventHub.丄世丌东丏三东丒丂 val_5;
            val_4 = this._eventButtonsSelectableButtonController.selectedButton;
            if(val_4 == 0)
            {
                goto label_4;
            }
            
            val_4 = val_4.GetComponent<PGCompany.EventHub.EventButton>();
            if(val_4 != 0)
            {
                goto label_8;
            }
            
            label_4:
            val_5 = 0;
            return val_5;
            label_8:
            val_5 = val_2.<丆丅丂丕丕丆丁丌万>k__BackingField;
            return val_5;
        }
        private void 丝丂丕东专世丅丝丁(bool 丐且丁丒丒丑业万丝 = False)
        {
            bool val_6 = 丐且丁丒丒丑业万丝;
            val_6 = PixelTime.丝业丁丌丘东丏世与() & val_6 ^ 1;
            丐且丁丒丒丑业万丝 = val_6;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._untilEventEndLabel, 丏业丟一东丂东丘丛:  丐且丁丒丒丑业万丝);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._untilEventEndLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6776"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = this.丁专丏一丄丛业丘专}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
        }
        internal void 万专丟丈丞丙丘丆世(PGCompany.EventHub.丄世丌东丏三东丒丂 且下丕七丙丗丄不七)
        {
            UnityEngine.Object val_7;
            .且下丕七丙丗丄不七 = 且下丕七丙丗丄不七;
            val_7 = System.Linq.Enumerable.FirstOrDefault<PGCompany.EventHub.EventButton>(source:  this._eventButtons, predicate:  new System.Func<PGCompany.EventHub.EventButton, System.Boolean>(object:  new EventHubView.丞丘世丐丏丟业丕丒(), method:  System.Boolean EventHubView.丞丘世丐丏丟业丕丒::不世丆丙上不丈世丏(PGCompany.EventHub.EventButton 三丟东丕丄丄下下丑)));
            if(val_7 == 0)
            {
                    return;
            }
            
            if(val_3.丁丘丄丕下专东七不 == null)
            {
                    return;
            }
            
            val_7 = val_7.GetComponent<SelectableButton>();
            if(val_7 == 0)
            {
                    return;
            }
            
            if(val_7 == null)
            {
                
            }
        
        }
        private void 一丟丂丆下丛丐上上()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CharacterContainer, 丏业丟一东丂东丘丛:  true);
        }
        private void 丛业丁不与丙且丕丙()
        {
            if(this.bonusPromotionsView.SelectedPromotion != null)
            {
                    PGCompany.Analytics.一业丗丆世世上丁且.东上丗东不丈东丑丙(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 世丁丙世丄一万丆三:  "eventHub", 丐丆丝业丙丈下世丁:  this.bonusPromotionsView.SelectedPromotion);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CharacterContainer, 丏业丟一东丂东丘丛:  false);
        }
        public void U_ShowPresentation()
        {
            PGCompany.EventHub.丄世丌东丏三东丒丂 val_1 = this.丞世专丙且丘丟万丕();
            this.下专丐丅丆丏三丂丅.七东丝丄专丘一丆丄(且下丕七丙丗丄不七:  val_1, 丘世丌七丝七丑一丁:  this.业专万丏丘丙丝一丕.且丌与东七丛专丘东(丁丅丈丌丟世丗丗丟:  val_1));
        }
        public EventHubView()
        {
            System.Collections.Generic.HashSet<PGCompany.EventHub.丄世丌东丏三东丒丂> val_1 = new System.Collections.Generic.HashSet<PGCompany.EventHub.丄世丌东丏三东丒丂>();
            if(val_1 != null)
            {
                    bool val_2 = val_1.Add(item:  4);
                bool val_3 = val_1.Add(item:  3);
                bool val_4 = val_1.Add(item:  2);
                bool val_5 = val_1.Add(item:  1);
            }
            else
            {
                    bool val_6 = val_1.Add(item:  4);
                bool val_7 = val_1.Add(item:  3);
                bool val_8 = val_1.Add(item:  2);
                bool val_9 = val_1.Add(item:  1);
            }
            
            bool val_10 = val_1.Add(item:  5);
            this.丙东丅丅丐丆不世丐 = val_1;
        }
    
    }

}
