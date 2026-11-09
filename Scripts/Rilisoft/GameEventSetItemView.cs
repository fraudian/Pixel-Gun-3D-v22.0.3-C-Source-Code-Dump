using UnityEngine;

namespace Rilisoft
{
    internal class GameEventSetItemView : MonoBehaviour, 丈丛不丐丂丐上三专<Rilisoft.GameEventItem, int, Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄>, 万丟丞不世丛七一专<Rilisoft.GameEventSetItemView>
    {
        // Fields
        private int _containerId;
        private System.Nullable<bool> 与丞东丟丒丘丏七丝;
        private Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 _state;
        private UnityEngine.Coroutine 专丗不丞丅丘丌三专;
        private Rilisoft.GameEventItem <丅丝丌丝丁丏丙东丞>k__BackingField;
        private UnityEngine.Vector3 东丏不丞专丗丆专丒;
        private System.Action<Rilisoft.GameEventSetItemView> 丅丕丌丛万丂丈七与;
        private UIBasicSprite _texture;
        protected UILabel _nameLabel;
        protected UILabel _countLabel;
        protected UISprite _bgSprite;
        private UnityEngine.Color 丆丁世丒七丒专下丗;
        protected UISprite _raritySprite;
        protected UnityEngine.GameObject _excludedIndicator;
        protected UnityEngine.GameObject _excludedCancel;
        protected UnityEngine.GameObject _wonIndicator;
        public UIWidget _selectorIndicator;
        protected UnityEngine.GameObject _lastDroppedIndicator;
        protected UnityEngine.GameObject _gearsIndicator;
        protected UnityEngine.GameObject _gemsIndicator;
        protected UnityEngine.GameObject _coinsIndicator;
        protected UnityEngine.GameObject _changeItemIndicator;
        protected float _changeAnimationPlayingTime;
        
        // Properties
        protected UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        public virtual bool 丐丞三丑不丝且丞丐 { get; set; }
        public Rilisoft.GameEventItem 丄丄一丐东丐丝丗七 { get; set; }
        public virtual Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 上丅丑丌丑丏丏丙东 { get; set; }
        public int 丌且丝丘丌丕东丒与 { get; set; }
        
        // Methods
        protected UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        public virtual bool get_LastDropped()
        {
            System.Nullable<System.Boolean> val_5 = this.与丞东丟丒丘丏七丝;
            if((val_5 & 1) == 0)
            {
                    return false;
            }
            
            val_5 = ???;
            return false;
        }
        public virtual void set_LastDropped(bool 丙业与丙丗丝不丈东)
        {
            if((this.与丞东丟丒丘丏七丝 & 1) != 0)
            {
                    if((this.与丞东丟丒丘丏七丝 ^ 丙业与丙丗丝不丈东 & 1) == 0)
            {
                    return;
            }
            
            }
            
            bool val_2 = 丙业与丙丗丝不丈东;
            this.与丞东丟丒丘丏七丝 = 0;
            if(this._lastDroppedIndicator == 0)
            {
                    return;
            }
            
            this = this._lastDroppedIndicator;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this, 丏业丟一东丂东丘丛:  this.与丞东丟丒丘丏七丝 & 1);
        }
        public Rilisoft.GameEventItem get_Context()
        {
            return (Rilisoft.GameEventItem)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.GameEventItem 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 get_CurrentState()
        {
            return (且世丈业丘丆不上丄)this._state;
        }
        public virtual void set_CurrentState(Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丙业与丙丗丝不丈东)
        {
            UIWidget val_5;
            if(this._state == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._excludedIndicator, 丏业丟一东丂东丘丛:  false);
            if((丙业与丙丗丝不丈东 == 0) && (this._wonIndicator != 0))
            {
                    ExecuteOnEnableOnce val_2 = this._wonIndicator.GetComponent<ExecuteOnEnableOnce>();
                if((UnityEngine.Object.op_Implicit(exists:  val_2)) != false)
            {
                    val_2.NeedPlay = true;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._wonIndicator, 丏业丟一东丂东丘丛:  false);
            val_5 = this._selectorIndicator;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._excludedCancel, 丏业丟一东丂东丘丛:  false);
            if((丙业与丙丗丝不丈东 - 1) <= 3)
            {
                    var val_5 = 106048368 + ((丙业与丙丗丝不丈东 - 1)) << 2;
                val_5 = val_5 + 106048368;
            }
            else
            {
                    this._state = 丙业与丙丗丝不丈东;
            }
        
        }
        public int get_Parameter()
        {
            return (int)this._containerId;
        }
        private void 世丏万丅三丂丕且七(int 丙业与丙丗丝不丈东)
        {
            this._containerId = 丙业与丙丗丝不丈东;
        }
        public virtual void Setup(Rilisoft.GameEventItem 与且专丈不万东一万, int 丆且丁丒丒丆丁三丆, Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丟丆七丅丘丒丒丘丈)
        {
            UISprite val_55;
            UnityEngine.GameObject val_56;
            float val_57;
            UnityEngine.Color val_58;
            UnityEngine.Vector3 val_59;
            UnityEngine.Color val_60;
            float val_61;
            float val_62;
            float val_63;
            int val_64;
            var val_66;
            UnityEngine.GameObject val_67;
            var val_68;
            val_55 = 丟丆七丅丘丒丒丘丈;
            val_56 = this;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this._containerId = 丆且丁丒丒丆丁三丆;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data) == null)
            {
                    return;
            }
            
            if(this.丆下世世丟七专丞丒() != 0)
            {
                    UIBasicSprite val_4 = this.丆下世世丟七专丞丒();
                UnityEngine.Texture val_6 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.丑东丐下专丞丕丘世();
            }
            
            if(this._nameLabel != 0)
            {
                    this._nameLabel.text = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.与丆业丅上丗七丆一();
            }
            
            if(this._countLabel == 0)
            {
                goto label_17;
            }
            
            val_57 = 0f;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.东丏不丞专丗丆专丒, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_57, y = 0f, z = 0f})) != false)
            {
                    UnityEngine.Vector3 val_13 = this._countLabel.transform.localPosition;
                this.东丏不丞专丗丆专丒 = val_13;
                mem[1152921542774297964] = val_13.y;
                mem[1152921542774297968] = val_13.z;
            }
            
            val_59 = this.东丏不丞专丗丆专丒;
            val_61 = val_59;
            val_62 = V9.16B;
            val_63 = V10.16B;
            this._countLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_61, y = val_62, z = val_63};
            int val_16 = 与且专丈不万东一万.Data.Count;
            val_64 = System.String.alignConst;
            if(与且专丈不万东一万.Data.Type != 900)
            {
                goto label_29;
            }
            
            string val_19 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_16, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            goto label_104;
            label_29:
            if(val_16 < 1)
            {
                goto label_99;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.Type) != 500)
            {
                    if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.Type) != 800)
            {
                goto label_39;
            }
            
            }
            
            label_104:
            val_64 = val_16.ToString();
            label_99:
            this._countLabel.text = val_64;
            label_17:
            val_55 = this._raritySprite;
            if(val_55 != 0)
            {
                    三丅丁丗丗丝丂万且 val_28 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与且专丈不万东一万.Data.Id);
                if(val_28 != null)
            {
                    val_66 = val_28;
            }
            else
            {
                    val_66 = 5;
            }
            
                val_55 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
                UnityEngine.Color val_55 = val_55[5];
                val_60 = val_55[5];
                val_58 = val_55[5];
                val_59 = val_55[5];
                val_61 = val_55;
                val_62 = val_60;
                val_63 = val_58;
                val_57 = val_59;
                this._raritySprite.color = new UnityEngine.Color() {r = val_61, g = val_62, b = val_63, a = val_57};
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gearsIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsIndicator, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsIndicator, 丏业丟一东丂东丘丛:  false);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.Type) != 500)
            {
                goto label_59;
            }
            
            string val_56 = "Gems";
            val_56 = System.String.op_Equality(a:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.Id, b:  val_56);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsIndicator, 丏业丟一东丂东丘丛:  val_56);
            val_67 = this._coinsIndicator;
            val_55 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data;
            val_68 = System.String.op_Equality(a:  val_55.Id, b:  "Coins");
            goto label_66;
            label_59:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data.Type) != 800)
            {
                goto label_69;
            }
            
            val_67 = this._gearsIndicator;
            val_68 = 1;
            label_66:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_67, 丏业丟一东丂东丘丛:  true);
            label_69:
            if(this._bgSprite == 0)
            {
                goto label_74;
            }
            
            UnityEngine.Color val_41 = UnityEngine.Color.magenta;
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = this.丆丁世丒七丒专下丗, g = val_58, b = val_60, a = val_55}, rhs:  new UnityEngine.Color() {r = val_41.r, g = val_41.g, b = val_41.b, a = val_41.a})) != false)
            {
                    UnityEngine.Color val_43 = this._bgSprite.color;
                this.丆丁世丒七丒专下丗 = val_43;
                mem[1152921542774298020] = val_43.g;
                mem[1152921542774298024] = val_43.b;
                mem[1152921542774298028] = val_43.a;
            }
            
            Rilisoft.GameEventItemData val_44 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data;
            bool val_45 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_44.BgColor);
            val_55 = this._bgSprite.gameObject;
            if(val_55 == null)
            {
                goto label_82;
            }
            
            if(val_45 == false)
            {
                goto label_83;
            }
            
            label_90:
            val_55.SetActive(value:  false);
            val_59 = this.丆丁世丒七丒专下丗;
            if(this._bgSprite != null)
            {
                goto label_95;
            }
            
            label_96:
            label_95:
            this._bgSprite.color = new UnityEngine.Color() {r = val_59, g = val_58, b = val_60, a = val_55};
            label_74:
            if(this._changeItemIndicator == 0)
            {
                    return;
            }
            
            val_56 = this._changeItemIndicator;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_56, 丏业丟一东丂东丘丛:  false);
            return;
            label_82:
            if(val_45 == true)
            {
                goto label_90;
            }
            
            label_83:
            val_55.SetActive(value:  true);
            Rilisoft.GameEventItemData val_48 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Data;
            UnityEngine.Color val_49 = 丞东丑专丛丆丄丝世.万丐一与丄丐丌丆丟(丞上三丏且丕丅丗丌:  val_48.BgColor);
            if(this._bgSprite != null)
            {
                goto label_95;
            }
            
            goto label_96;
            label_39:
            if(与且专丈不万东一万.Data.Type != 1400)
            {
                goto label_99;
            }
            
            this._countLabel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            string val_54 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2002"), arg0:  val_16);
            goto label_104;
        }
        public void add_Clicked(System.Action<Rilisoft.GameEventSetItemView> 丙业与丙丗丝不丈东)
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
            while(this.丅丕丌丛万丂丈七与 != 1152921542774766328);
        
        }
        public void remove_Clicked(System.Action<Rilisoft.GameEventSetItemView> 丙业与丙丗丝不丈东)
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
            while(this.丅丕丌丛万丂丈七与 != 1152921542774902904);
        
        }
        public void PlayItemChangeAnimation()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._changeItemIndicator, 丏业丟一东丂东丘丛:  true);
            if(this.专丗不丞丅丘丌三专 != null)
            {
                    this.StopCoroutine(routine:  this.专丗不丞丅丘丌三专);
            }
            
            this.专丗不丞丅丘丌三专 = this.StartCoroutine(routine:  this.丌丏不下丞不与丒下());
        }
        private System.Collections.IEnumerator 丌丏不下丞不与丒下()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventSetItemView.丏世一丅丘七丁丛世();
        }
        private void OnDisable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._changeItemIndicator, 丏业丟一东丂东丘丛:  false);
        }
        private void OnClick()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        private void Update()
        {
            var val_4;
            if(this._wonIndicator == 0)
            {
                    return;
            }
            
            if(this._lastDroppedIndicator == 0)
            {
                    return;
            }
            
            if(this._state == 3)
            {
                    val_4 = (~this._lastDroppedIndicator.activeSelf) & 1;
            }
            else
            {
                    val_4 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._wonIndicator, 丏业丟一东丂东丘丛:  false);
        }
        public GameEventSetItemView()
        {
            this.东丏不丞专丗丆专丒 = 0;
            mem[1152921542775686512] = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.magenta;
            this.丆丁世丒七丒专下丗 = val_1;
            mem[1152921542775686564] = val_1.g;
            mem[1152921542775686568] = val_1.b;
            mem[1152921542775686572] = val_1.a;
            this._changeAnimationPlayingTime = 0.3f;
        }
    
    }

}
