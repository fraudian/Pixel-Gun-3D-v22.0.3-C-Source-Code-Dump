using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPRewardView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.BattlePass.BPReward>, 万丟丞不世丛七一专<PGCompany.BattlePass.BPRewardView>
    {
        // Fields
        private UnityEngine.GameObject 丘与丄丙业丙三丒丟;
        private int 丄丟东丈业万七七万;
        private string _itemId;
        public string RewardGettedPrefabPath;
        private PGCompany.BattlePass.BPReward <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Action<PGCompany.BattlePass.BPRewardView> 丅丕丌丛万丂丈七与;
        private UIBasicSprite _itemTexture;
        private UnityEngine.GameObject _countContainer;
        private UIBasicSprite _itemCountTexture;
        private UILabel _itemCountLabel;
        private UILabel _levelLabel;
        private UnityEngine.GameObject _existsIndicator;
        private UnityEngine.GameObject _lockIndicator;
        private UnityEngine.GameObject _selectedIndicator;
        private UnityEngine.GameObject _partsContainer;
        private UILabel _partsCount;
        private UIWidget _bgGroupWidget;
        private System.Collections.Generic.List<UIWidget> _existsAlphaWidgets;
        private UnityEngine.GameObject _baseStateObj;
        private UnityEngine.GameObject _onLevelObj;
        private UnityEngine.GameObject _readyToClaimObj;
        private UnityEngine.GameObject _coolObj;
        private System.Collections.Generic.List<UIWidget> _rarityColors;
        
        // Properties
        public int 东丁丌丁七世业丌丐 { get; set; }
        public bool 丟七一丏丈丒丘丝世 { get; set; }
        public PGCompany.BattlePass.BPReward 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public int get_GroupSize()
        {
            return (int)this.丄丟东丈业万七七万;
        }
        public void set_GroupSize(int 丙业与丙丗丝不丈东)
        {
            this.丄丟东丈业万七七万 = 丙业与丙丗丝不丈东;
            if(this._bgGroupWidget == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this._bgGroupWidget.gameObject;
            if(this.丄丟东丈业万七七万 > 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
                int val_4 = this.丄丟东丈业万七七万;
                val_4 = val_4 * 140;
                this._bgGroupWidget.width = val_4 - 16;
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
        }
        public bool get_IsSelected()
        {
            if(this._selectedIndicator == 0)
            {
                    return false;
            }
            
            if(this._selectedIndicator != null)
            {
                    return this._selectedIndicator.activeSelf;
            }
            
            return this._selectedIndicator.activeSelf;
        }
        public void set_IsSelected(bool 丙业与丙丗丝不丈东)
        {
            if(this._selectedIndicator == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedIndicator, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        }
        public PGCompany.BattlePass.BPReward get_Context()
        {
            return (PGCompany.BattlePass.BPReward)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.BattlePass.BPReward 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.BattlePass.BPReward 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        public void add_Clicked(System.Action<PGCompany.BattlePass.BPRewardView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560147695120);
        
        }
        public void remove_Clicked(System.Action<PGCompany.BattlePass.BPRewardView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560147831696);
        
        }
        public void PlayRewardGettedAnimation()
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.RewardGettedPrefabPath)) == true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.RewardGettedPrefabPath);
            if(val_2 == 0)
            {
                    return;
            }
            
            1152921505284374528 = this.transform;
            UnityEngine.GameObject val_5 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_2, 丈东丘丏与丌东东下:  1152921505284374528, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            this.丘与丄丙业丙三丒丟 = val_5;
            if(val_5 == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_8 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  2f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPRewardView::丗三丝丗丙一丝丁丐()));
        }
        private void OnEnable()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BPRewardView::丈丛万且不丏丕丙丙(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        }
        private void OnDisable()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BPRewardView::丈丛万且不丏丕丙丙(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            if(this.丘与丄丙业丙三丒丟 == 0)
            {
                    return;
            }
            
            if(this.丘与丄丙业丙三丒丟.activeInHierarchy != false)
            {
                    this.丘与丄丙业丙三丒丟.SetActive(value:  false);
            }
            
            UnityEngine.Object.Destroy(obj:  this.丘与丄丙业丙三丒丟);
            this.丘与丄丙业丙三丒丟 = 0;
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BPRewardView::丈丛万且不丏丕丙丙(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        }
        private void 丈丛万且不丏丕丙丙(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)
        {
            if(世丁丙世丄一万丆三 != 1)
            {
                    return;
            }
            
            if(万且万且丑丗且丌丆 == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField._uniqueId, b:  (null == null) ? 万且万且丑丗且丌丆 : 0)) == false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_42;
            var val_75;
            UIBasicSprite val_76;
            string val_77;
            bool val_79;
            var val_80;
            var val_81;
            UnityEngine.GameObject val_82;
            var val_83;
            Rilisoft.ButtonHandler val_1 = this.GetComponent<Rilisoft.ButtonHandler>();
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                goto label_10;
            }
            
            if(this._levelLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelLabel, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField._forLevel.ToString());
            }
            
            if((((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null) || ((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item) == null)) || ((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.IsKnownItem) == false))
            {
                goto label_10;
            }
            
            if(val_1 != 0)
            {
                    val_1.noSound = false;
            }
            
            if(this._partsContainer != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsContainer, 丏业丟一东丂东丘丛:  ((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Type) == 1070) ? 1 : 0);
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item) == null)
            {
                goto label_23;
            }
            
            val_75 = this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Texture;
            goto label_24;
            label_10:
            if(this._itemTexture != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._itemCountTexture != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemCountTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._existsIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._readyToClaimObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coolObj, 丏业丟一东丂东丘丛:  false);
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1.noSound = true;
            return;
            label_23:
            val_75 = 0.Texture;
            label_24:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Count) <= 1)
            {
                goto label_43;
            }
            
            if(this._itemTexture == 0)
            {
                goto label_46;
            }
            
            val_76 = this;
            if(this._itemTexture == this._itemCountTexture)
            {
                goto label_53;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_53;
            label_43:
            if(this._itemTexture != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemTexture.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if(this._itemCountTexture != 0)
            {
                    if(this._itemCountTexture != this._itemTexture)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemCountTexture.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            goto label_126;
            label_46:
            val_76 = this._itemCountTexture;
            label_53:
            if(mem[this._itemCountTexture] != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[this._itemCountTexture].gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Type) != 80)
            {
                goto label_82;
            }
            
            val_77 = "Key_6228";
            goto label_85;
            label_82:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Type) != 1450)
            {
                goto label_88;
            }
            
            val_77 = "Key_2002";
            label_85:
            string val_31 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_77), arg0:  this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.ReadableCount);
            goto label_92;
            label_88:
            string val_32 = this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.ReadableCount;
            label_92:
            if(((this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Type) != 1070) || (this._partsContainer == 0))
            {
                goto label_121;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  false);
            if(this._partsCount != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._partsCount, 丕丗丘丑丛与丑业丒:  val_32);
            }
            
            if((this._rarityColors == null) || (this._rarityColors.Count < 1))
            {
                goto label_126;
            }
            
            System.Nullable<ItemRarity> val_37 = this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Rarity;
            if(((-292309672) & 1) == 0)
            {
                goto label_126;
            }
            
            System.Nullable<ItemRarity> val_38 = this.<丅丝丌丝丁丏丙东丞>k__BackingField._item.Rarity;
            UnityEngine.Color val_39 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_38.HasValue);
            List.Enumerator<T> val_40 = this._rarityColors.GetEnumerator();
            label_117:
            if(((-292309696) & 1) == 0)
            {
                goto label_115;
            }
            
            val_42.丐丏七丌丕丗业且上().color = new UnityEngine.Color() {r = val_39.r, g = val_39.g, b = val_39.b, a = val_39.a};
            goto label_117;
            label_115:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_126;
            label_121:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._countContainer, 丏业丟一东丂东丘丛:  true);
            if(this._itemCountLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemCountLabel, 丕丗丘丑丛与丑业丒:  val_32);
            }
            
            label_126:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.RewardDropped) != false)
            {
                    val_79 = 1;
            }
            else
            {
                    val_79 = Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  this.<丅丝丌丝丁丏丙东丞>k__BackingField._item);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._existsIndicator, 丏业丟一东丂东丘丛:  val_79);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField._paymentState) == 100)
            {
                    var val_50 = ((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().专丟专一丒且丘与丌()) == 0) ? 1 : 0;
            }
            else
            {
                    val_80 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coolObj, 丏业丟一东丂东丘丛:  this.<丅丝丌丝丁丏丙东丞>k__BackingField._isCool);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.RewardUnDropped) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseStateObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._onLevelObj, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._readyToClaimObj, 丏业丟一东丂东丘丛:  true);
                if((this._itemTexture != 0) && (this._itemTexture.gameObject.activeSelf != false))
            {
                    UITweener val_55 = this._itemTexture.GetComponent<UITweener>();
                if(val_55 != 0)
            {
                    val_55.enabled = true;
            }
            
            }
            
                if(this._itemCountTexture == 0)
            {
                    return;
            }
            
                if(this._itemCountTexture.gameObject.activeSelf == false)
            {
                    return;
            }
            
                if((this._itemCountTexture.GetComponent<UITweener>()) == 0)
            {
                    return;
            }
            
                val_81 = 1;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._readyToClaimObj, 丏业丟一东丂东丘丛:  false);
                if((this.<丅丝丌丝丁丏丙东丞>k__BackingField._forLevel) == (Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().业丈丅丂且丁与丄丂()))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseStateObj, 丏业丟一东丂东丘丛:  false);
                val_82 = this._onLevelObj;
                val_83 = 1;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._baseStateObj, 丏业丟一东丂东丘丛:  true);
                val_82 = this._onLevelObj;
                val_83 = 0;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_82, 丏业丟一东丂东丘丛:  false);
                if((this._itemTexture != 0) && (this._itemTexture.gameObject.activeSelf != false))
            {
                    UITweener val_68 = this._itemTexture.GetComponent<UITweener>();
                if(val_68 != 0)
            {
                    if(val_68 != null)
            {
                    val_68.ResetToBeginning();
            }
            else
            {
                    val_68.ResetToBeginning();
            }
            
                val_68.enabled = false;
            }
            
            }
            
                if(this._itemCountTexture == 0)
            {
                    return;
            }
            
                if(this._itemCountTexture.gameObject.activeSelf == false)
            {
                    return;
            }
            
                UITweener val_73 = this._itemCountTexture.GetComponent<UITweener>();
                if(val_73 == 0)
            {
                    return;
            }
            
                if(val_73 != null)
            {
                    val_73.ResetToBeginning();
            }
            else
            {
                    val_73.ResetToBeginning();
            }
            
                val_81 = 0;
            }
            
            val_73.enabled = false;
        }
        private void OnClick()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        public BPRewardView()
        {
        
        }
        private void 丗三丝丗丙一丝丁丐()
        {
            if(this.丘与丄丙业丙三丒丟 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丘与丄丙业丙三丒丟);
            this.丘与丄丙业丙三丒丟 = 0;
        }
    
    }

}
