using UnityEngine;

namespace Rilisoft
{
    public class CraftScrollItemView : MonoBehaviour, 上丆丕业丘业丈丄丆
    {
        // Fields
        private bool 与丛上丌丆七丒丅东;
        private Rilisoft.丏丘七丞丄丙丌丞丁 _item;
        private UIWidget 与东七丏丆世丟丁丌;
        private UILabel _labelName;
        private UIBasicSprite _texture;
        private Rilisoft.PriceView _btnCraft;
        private Rilisoft.PriceView _btnSpeedUp;
        private Rilisoft.PriceView _btnPlace;
        private Rilisoft.PriceView _btnRemove;
        private Rilisoft.PriceView _labelPrice;
        private UnityEngine.GameObject _indicatorSelected;
        private UnityEngine.GameObject _indicatorBought;
        private UnityEngine.GameObject _indicatorLocked;
        private UILabel _indicatorLockedLabel;
        private UILabel _labelPlaced;
        private UILabel _labelCraftTimer;
        private UnityEngine.GameObject _objNew;
        private UnityEngine.GameObject _objBuffDescription;
        private Rilisoft.TextGroup _labelBuffDescription;
        private UILabel _craftTimeLabel;
        private UnityEngine.GameObject _lockerObject;
        private UISprite _lockerSprite;
        private UILabel _lockerPointsLabel;
        private string localKey;
        private UILabel _itemsCountLabel;
        private bool <丝专丘不丌丟东丗丝>k__BackingField;
        private bool <不丁丝丈丙丄丂丐下>k__BackingField;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        private UIWidget 丕丟丟丝丝丞七且下 { get; }
        public Rilisoft.丏丘七丞丄丙丌丞丁 丏丘七丞丄丙丌丞丁 { get; }
        public bool 丟七一丏丈丒丘丝世 { get; set; }
        public bool 且丗丈丈世丐丐万七 { get; set; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        private UIWidget 丁丏世七三丗与丏与()
        {
            UIWidget val_3;
            if(this.与东七丏丆世丟丁丌 == 0)
            {
                    this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
                return val_3;
            }
            
            val_3 = this.与东七丏丆世丟丁丌;
            return val_3;
        }
        private void OnEnable()
        {
            this._btnCraft.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::与丈丘不七三东丅万()));
            this._btnSpeedUp.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::丑丙丑且丐专丞东东()));
            this._btnPlace.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::一一丞丂丕一与一不()));
            this._btnRemove.add_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::丅丐丟与丟业丘世丆()));
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private void OnDisable()
        {
            System.Action val_9;
            this._btnCraft.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::与丈丘不七三东丅万()));
            this._btnSpeedUp.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::丑丙丑且丐专丞东东()));
            this._btnPlace.remove_OnClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::一一丞丂丕一与一不()));
            System.Action val_4 = null;
            val_9 = val_4;
            val_4 = new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::丅丐丟与丟业丘世丆());
            this._btnRemove.remove_OnClicked(丙业与丙丗丝不丈东:  val_4);
            if(this._item != null)
            {
                    if(this._item.丐万且七专丒七丛丞() != false)
            {
                    val_9 = this.与丛上丌丆七丒丅东;
                this._item.丌七丌下丙三世丅一().isNew = (val_9 == true) ? 1 : 0;
            }
            
            }
            
            this.StopCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new CraftScrollItemView.与丙丗且丞丂丏丞丙();
        }
        private void OnClick()
        {
            if(this._item != null)
            {
                    if(this._item.丌七丌下丙三世丅一().isNew != false)
            {
                    this._item.丌七丌下丙三世丅一().isNew = false;
                this.与丛上丌丆七丒丅东 = false;
            }
            
            }
            
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丐丐丂下丞上丝丐七(丂三七下丗且丌上一:  this._item);
        }
        private void 与丈丘不七三东丅万()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.不不丝与世丗七丙丅(丁世丛业丟下丕三丟:  this);
        }
        private void 丑丙丑且丐专丞东东()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丞不丌下丐丄丕世丏(丁世丛业丟下丕三丟:  this);
        }
        private void 一一丞丂丕一与一不()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丘丙丅上丞世丄丞与(丁世丛业丟下丕三丟:  this);
        }
        private void 丅丐丟与丟业丘世丆()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丘一东专丐丁七丞七(丁世丛业丟下丕三丟:  this);
        }
        private void 一丅万三丛不七丝丞()
        {
            if(this._item == null)
            {
                    return;
            }
            
            if(this._item.丑丆丑三且丛上且丟() == true)
            {
                    return;
            }
            
            if(this.丆下世世丟七专丞丒() == 0)
            {
                    return;
            }
            
            if(this.丆下世世丟七专丞丒() == 0)
            {
                    return;
            }
            
            this = this.丆下世世丟七专丞丒();
            UnityEngine.Resources.UnloadAsset(assetToUnload:  this);
        }
        public Rilisoft.丏丘七丞丄丙丌丞丁 get_LobbyItem()
        {
            return (Rilisoft.丏丘七丞丄丙丌丞丁)this._item;
        }
        public bool get_IsSelected()
        {
            return (bool)this.<丝专丘不丌丟东丗丝>k__BackingField;
        }
        public void set_IsSelected(bool 丙业与丙丗丝不丈东)
        {
            this.<丝专丘不丌丟东丗丝>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsCrafting()
        {
            return (bool)this.<不丁丝丈丙丄丂丐下>k__BackingField;
        }
        public void set_IsCrafting(bool 丙业与丙丗丝不丈东)
        {
            this.<不丁丝丈丙丄丂丐下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            if(this._item != null)
            {
                    this._item.丒且丆世专业丁三丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::世丈丂丛丞丞丘不万()));
            }
            
            this._item = 下丅丙一丂丗丅丝七;
            if(下丅丙一丂丗丅丝七 != null)
            {
                    下丅丙一丂丗丅丝七.丏上不丐丂丆丗三业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::世丈丂丛丞丞丘不万()));
            }
            
            this.gameObject.transform.SetParent(p:  七万上丐一丈丏丏专);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            this.gameObject.SetActive(value:  true);
        }
        private void 世丈丂丛丞丞丘不万()
        {
            this.UpdateView();
        }
        public void Hide()
        {
            this.一丅万三丛不七丝丞();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    this.gameObject.transform.SetParent(p:  Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.transform);
            }
            
            this.<丝专丘不丌丟东丗丝>k__BackingField = false;
        }
        public void UpdateView()
        {
            string val_126;
            UILabel val_127;
            丈丞丕丘丕丗与上一 val_129;
            UnityEngine.GameObject val_130;
            var val_131;
            var val_132;
            string val_133;
            var val_136;
            var val_137;
            var val_138;
            val_126 = this;
            if(this._item == null)
            {
                    return;
            }
            
            this.与丛上丌丆七丒丅东 = this._item.丘丘丒丝一业丐丛不();
            this._labelName.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._item.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐());
            UIBasicSprite val_6 = this.丆下世世丟七专丞丒();
            if(val_6 != 0)
            {
                    if(val_6 != 0)
            {
                    if((System.String.op_Inequality(a:  val_6.name, b:  this._item.丆丗丒丌且专丒丘七())) == false)
            {
                goto label_16;
            }
            
            }
            
                UnityEngine.Texture val_13 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this._item.丙三专万丛丟万丝丘());
            }
            
            label_16:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._objNew, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._indicatorSelected, 丏业丟一东丂东丘丛:  this.<丝专丘不丌丟东丗丝>k__BackingField);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._btnCraft.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._btnSpeedUp.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._btnPlace.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._btnRemove.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._indicatorBought, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._indicatorLocked, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._labelPrice.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._labelPlaced.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._labelCraftTimer.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._craftTimeLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockerObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsCountLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this._item.丙丕丞且丕不丘丙丑().丈一下下丞世三丑丄() > ExpController.丑七不且上丗丁一世().丙东专丂世丈丏丁丂())
            {
                    if(this._item.且丅一一三七专丑丏() == false)
            {
                goto label_36;
            }
            
            }
            
            if(((Rilisoft.LobbyItemsController.丑丆丏丟丗丌丄丟丝() == true) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)) || ((System.String.op_Inequality(a:  this._item.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  "decor_big_military_1")) == false))
            {
                goto label_45;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._indicatorLocked, 丏业丟一东丂东丘丛:  true);
            val_127 = this._indicatorLockedLabel;
            if(this._item.丐万且七专丒七丛丞() == false)
            {
                goto label_49;
            }
            
            val_127.text = System.String.alignConst;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._labelPrice.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this._item.丒丙丙世丅且下丁丐() == null)
            {
                goto label_55;
            }
            
            Rilisoft.与丗丌丑专业丝丛丏 val_37 = this._item.丒丙丙世丅且下丁丐().MarketProduct;
            if((FriendsController.丝丗专上三不丄丑丑() < 1) || ((val_37 == null) || (coinsShop.七三丗丏丑丗三丆世() == false)))
            {
                goto label_64;
            }
            
            var val_129 = 0;
            val_129 = val_129 + 1;
            goto label_68;
            label_45:
            this._objNew.SetActive(value:  (this.与丛上丌丆七丒丅东 == true) ? 1 : 0);
            val_129 = this._item.且丅一一三七专丑丏();
            if(this._item == null)
            {
                goto label_71;
            }
            
            if(val_129 == false)
            {
                goto label_72;
            }
            
            label_93:
            if(this._item.丒丙丙世丅且下丁丐() != null)
            {
                    if(this._item.丒丙丙世丅且下丁丐().IsMyBandle != false)
            {
                    if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) == false)
            {
                goto label_131;
            }
            
            }
            
            }
            
            if(this._item.不专丌丅且丝丗丞下() != false)
            {
                    if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.下丟丈不一上万不业()) == false)
            {
                goto label_82;
            }
            
            }
            
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_83;
            }
            
            if(this._btnPlace != null)
            {
                goto label_198;
            }
            
            label_199:
            label_198:
            val_130 = this._btnPlace.gameObject;
            val_131 = null;
            goto label_87;
            label_36:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._indicatorLocked, 丏业丟一东丂东丘丛:  true);
            val_127 = this._indicatorLockedLabel;
            goto label_92;
            label_71:
            if(val_129 == true)
            {
                goto label_93;
            }
            
            label_72:
            if(this._item.丑丆丑三且丛上且丟() == false)
            {
                goto label_94;
            }
            
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
            {
                goto label_210;
            }
            
            this._labelCraftTimer.gameObject.SetActive(value:  true);
            this._labelCraftTimer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this._item.下丞丘丏丂丕丄丐丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._btnSpeedUp.gameObject, 丏业丟一东丂东丘丛:  true);
            label_187:
            val_129 = this._item.且丕三丙七且且东下();
            this._btnSpeedUp.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_129, 万丐丁三且下丞丈丌:  0);
            goto label_210;
            label_94:
            if(this._item.丏丕丂且上上下丏七() == false)
            {
                goto label_111;
            }
            
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_112;
            }
            
            val_129 = this._btnCraft.gameObject;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_117;
            }
            
            val_129.SetActive(value:  false);
            goto label_194;
            label_111:
            this._lockerObject.SetActive(value:  true);
            Rilisoft.不丆丐丞业丂丁丑业 val_62 = this._item.不丑三丌丈丞丈一丆().Item[0];
            if(val_62 == null)
            {
                goto label_122;
            }
            
            val_132 = val_62.丆丕丑丈三丙丁丗丈();
            goto label_123;
            label_83:
            val_131 = null;
            val_130 = this._indicatorBought;
            label_87:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_130, 丏业丟一东丂东丘丛:  true);
            goto label_210;
            label_82:
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) != false)
            {
                    if((Rilisoft.LobbyItemsController.丄专与丝上专下东专(与丄不丌一世东丁丙:  this._item.丘专上世与丟丝丟丛())) != false)
            {
                    if(this._item.丝丞世丕丒下东丌丄() == false)
            {
                goto label_133;
            }
            
            }
            
            }
            
            label_131:
            this._labelPlaced.gameObject.SetActive(value:  true);
            goto label_210;
            label_49:
            label_92:
            val_129 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3297"), arg0:  this._item.丙丕丞且丕不丘丙丑().丈一下下丞世三丑丄());
            val_133 = val_129;
            goto label_141;
            label_112:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._labelPrice.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this._item.丒丙丙世丅且下丁丐() == null)
            {
                goto label_146;
            }
            
            Rilisoft.与丗丌丑专业丝丛丏 val_75 = this._item.丒丙丙世丅且下丁丐().MarketProduct;
            if((FriendsController.丝丗专上三不丄丑丑() < 1) || ((val_75 == null) || (coinsShop.七三丗丏丑丗三丆世() == false)))
            {
                goto label_155;
            }
            
            var val_130 = 0;
            val_130 = val_130 + 1;
            goto label_159;
            label_122:
            val_132 = val_62.丆丕丑丈三丙丁丗丈();
            label_123:
            float val_131 = (float)val_132;
            val_131 = val_131 / (float)val_62.丗万丆丟丙不与三丌();
            val_131 = 1f - val_131;
            this._lockerSprite.fillAmount = val_131;
            val_129 = this._lockerPointsLabel;
            val_129.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_62.丂丝丅丗丟一丑下与()), arg0:  val_62.东丑专丟丅丄业丆丁());
            goto label_194;
            label_117:
            val_129.SetActive(value:  true);
            if(this._item.丒丙丙世丅且下丁丐() == null)
            {
                goto label_168;
            }
            
            Rilisoft.与丗丌丑专业丝丛丏 val_86 = this._item.丒丙丙世丅且下丁丐().MarketProduct;
            if((FriendsController.丝丗专上三不丄丑丑() < 1) || ((val_86 == null) || (coinsShop.七三丗丏丑丗三丆世() == false)))
            {
                goto label_177;
            }
            
            var val_132 = 0;
            val_132 = val_132 + 1;
            goto label_181;
            label_64:
            string val_89 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            goto label_184;
            label_55:
            丈丞丕丘丕丗与上一 val_91 = this._item.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            goto label_187;
            label_155:
            string val_92 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            goto label_190;
            label_146:
            if(this._item != null)
            {
                goto label_200;
            }
            
            label_201:
            label_200:
            val_129 = this._item.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            this._labelPrice.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_129, 万丐丁三且下丞丈丌:  0);
            goto label_194;
            label_177:
            string val_95 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0278");
            goto label_197;
            label_133:
            if(this._btnRemove != null)
            {
                goto label_198;
            }
            
            goto label_199;
            label_168:
            if(this._item != null)
            {
                goto label_200;
            }
            
            goto label_201;
            label_68:
            val_136 = val_37;
            label_184:
            val_129 = this._labelPrice;
            val_129.SetRealPrice(丕丗丘丑丛与丑业丒:  val_136.丟丂丞不专丆万丒世());
            goto label_210;
            label_159:
            val_137 = val_75;
            label_190:
            val_129 = this._labelPrice;
            if(val_129 != null)
            {
                goto label_261;
            }
            
            label_262:
            label_261:
            val_129.SetRealPrice(丕丗丘丑丛与丑业丒:  val_137.丟丂丞不专丆万丒世());
            label_194:
            string val_101 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  this._item.丅丞上丘丆下上丘丅(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_101)) == true)
            {
                goto label_210;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._craftTimeLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            val_129 = this._craftTimeLabel;
            val_133 = val_101;
            label_141:
            val_129.text = val_133;
            label_210:
            if((this.<丝专丘不丌丟东丗丝>k__BackingField) == false)
            {
                goto label_215;
            }
            
            string val_104 = this._item.世丛丐丕丗七一丞一();
            bool val_105 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_104);
            val_129 = this._objBuffDescription;
            if(val_129 == null)
            {
                goto label_219;
            }
            
            if(val_105 == false)
            {
                goto label_220;
            }
            
            goto label_221;
            label_215:
            label_221:
            this._objBuffDescription.SetActive(value:  false);
            goto label_223;
            label_219:
            if(val_105 == true)
            {
                goto label_221;
            }
            
            label_220:
            val_129.SetActive(value:  true);
            if((this._item.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万() != null) && (this._item.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0] != null))
            {
                    LobbyItemBuff val_134 = this._item.丙丕丞且丕不丘丙丑().丞一下丐丟丏下丅万()[0];
                val_129 = this._labelBuffDescription;
                string val_114 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_104.Trim()), arg0:  val_111[0].Value);
            }
            else
            {
                    val_129 = this._labelBuffDescription;
            }
            
            val_129.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_104.Trim());
            label_223:
            if(this._item.丒丙丙世丅且下丁丐() == null)
            {
                    return;
            }
            
            if(this._item.丒丙丙世丅且下丁丐().IsMyBandle == true)
            {
                    return;
            }
            
            System.Collections.Generic.IEnumerable<Rilisoft.丏丘七丞丄丙丌丞丁> val_121 = this._item.丒丙丙世丅且下丁丐().NotExistsItems;
            if(val_121 == null)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_121)) == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemsCountLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            val_129 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4785");
            val_126 = System.String.Format(format:  val_129, arg0:  System.Linq.Enumerable.Count<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  val_121));
            this._itemsCountLabel.text = val_126;
            return;
            label_181:
            val_138 = val_86;
            string val_128 = val_138.丟丂丞不专丆万丒世();
            label_197:
            if(this._btnCraft != null)
            {
                goto label_261;
            }
            
            goto label_262;
        }
        public void Kill()
        {
            UnityEngine.Transform val_7;
            this.一丅万三丛不七丝丞();
            val_7 = 1152921505471328256;
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_7 = Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.transform;
                this.gameObject.transform.SetParent(p:  val_7);
            }
            
            this.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        private void OnDestroy()
        {
            if(this._item == null)
            {
                    return;
            }
            
            this._item.丒且丆世专业丁三丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftScrollItemView::世丈丂丛丞丞丘不万()));
        }
        public CraftScrollItemView()
        {
            this.localKey = "Key_4023";
        }
    
    }

}
