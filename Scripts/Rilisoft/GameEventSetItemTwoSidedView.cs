using UnityEngine;

namespace Rilisoft
{
    internal class GameEventSetItemTwoSidedView : GameEventSetItemView
    {
        // Fields
        private bool 上世丁丕丞且专丆丟;
        private bool <丁专丒丂丄丞万与丌>k__BackingField;
        private UnityEngine.Transform _front;
        private UnityEngine.Transform _back;
        private float _animationSpeed;
        private UILabel[] _backLabelsPrice;
        private UILabel _backLabelFree;
        private UnityEngine.GameObject _backObjGems;
        private UnityEngine.GameObject _backObjCoins;
        private UnityEngine.GameObject _backObjEventCurrency;
        private UnityEngine.GameObject _backHiddenContentContainer;
        
        // Properties
        public bool 丕丝三一下不丁一专 { get; set; }
        public bool 七七丌丌世丄丏专上 { get; }
        
        // Methods
        public bool get_FrontActive()
        {
            return (bool)this.<丁专丒丂丄丞万与丌>k__BackingField;
        }
        private void 丕丌丏丟三业不丏丆(bool 丙业与丙丗丝不丈东)
        {
            this.<丁专丒丂丄丞万与丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_BackHiden()
        {
            if(this._backHiddenContentContainer != null)
            {
                    return this._backHiddenContentContainer.activeSelf;
            }
            
            return this._backHiddenContentContainer.activeSelf;
        }
        public void SetHiddenBackVisible(bool 下下东且万业丞丅丒, bool 丛丆与丆丞丏丅万丅 = False)
        {
            if(丛丆与丆丞丏丅万丅 == false)
            {
                    return;
            }
            
            下下东且万业丞丅丒 = 下下东且万业丞丅丒;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backHiddenContentContainer, 丏业丟一东丂东丘丛:  下下东且万业丞丅丒);
        }
        public override void Setup(Rilisoft.GameEventItem 与且专丈不万东一万, int 丆且丁丒丒丆丁三丆, Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丟丆七丅丘丒丒丘丈)
        {
            this.Setup(与且专丈不万东一万:  与且专丈不万东一万, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆, 丟丆七丅丘丒丒丘丈:  丟丆七丅丘丒丒丘丈);
        }
        public void SetBack(丈丞丕丘丕丗与上一 丏专丒丙丟且丈万七)
        {
            var val_22;
            bool val_23;
            bool val_24;
            var val_25;
            var val_26;
            System.Action<UILabel> val_28;
            var val_29;
            UnityEngine.GameObject val_30;
            int val_2 = 丏专丒丙丟且丈万七.丟丂丞不专丆万丒世();
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backLabelFree.gameObject, 丏业丟一东丂东丘丛:  false);
            .丒丄东业上丘丐丈世 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_2);
            if(this._backLabelsPrice != null)
            {
                    丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._backLabelsPrice, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  new GameEventSetItemTwoSidedView.丌万一一业丝丁丈丝(), method:  System.Void GameEventSetItemTwoSidedView.丌万一一业丝丁丈丝::不丘丟专丁丗七丑且(UILabel 丐三丞七丝丅不万丛)));
            }
            
            val_22 = null;
            val_22 = null;
            if((System.String.op_Equality(a:  丏专丒丙丟且丈万七.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_15;
            }
            
            val_23 = 0;
            val_24 = 0;
            val_25 = 1;
            goto label_16;
            label_2:
            if(this._backLabelsPrice != null)
            {
                    val_26 = null;
                val_26 = null;
                val_28 = GameEventSetItemTwoSidedView.<>c.<>9__9_0;
                if(val_28 == null)
            {
                    System.Action<UILabel> val_8 = null;
                val_28 = val_8;
                val_8 = new System.Action<UILabel>(object:  GameEventSetItemTwoSidedView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventSetItemTwoSidedView.<>c::丞一丐东丕丛东下丆(UILabel 丐三丞七丝丅不万丛));
                GameEventSetItemTwoSidedView.<>c.<>9__9_0 = val_28;
            }
            
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this._backLabelsPrice, 七丐丅专且专七三丆:  val_8);
            }
            
            if(this._backObjGems != 0)
            {
                    this._backObjGems.SetActive(value:  false);
            }
            
            if(this._backObjCoins != 0)
            {
                    this._backObjCoins.SetActive(value:  false);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._backLabelFree.gameObject, 丏业丟一东丂东丘丛:  true);
            return;
            label_15:
            val_29 = null;
            val_29 = null;
            val_24 = System.String.op_Equality(a:  丏专丒丙丟且丈万七.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
            val_25 = 0;
            val_23 = val_24 ^ 1;
            label_16:
            if(this._backObjGems != 0)
            {
                    this._backObjGems.SetActive(value:  false);
            }
            
            val_30 = this._backObjCoins;
            if(val_30 != 0)
            {
                    val_30 = this._backObjCoins;
                val_30.SetActive(value:  val_24);
            }
            
            if(this._backObjEventCurrency != 0)
            {
                    this._backObjEventCurrency.SetActive(value:  val_23);
            }
            
            if(this._backLabelFree == 0)
            {
                    return;
            }
            
            this._backLabelFree.gameObject.SetActive(value:  false);
        }
        public void SetFrontActive(bool 丏业丟一东丂东丘丛, bool 丛丆与丆丞丏丅万丅 = False)
        {
            bool val_13;
            UnityEngine.Transform val_14;
            var val_16;
            val_13 = 丏业丟一东丂东丘丛;
            val_14 = this;
            bool val_13 = ~丛丆与丆丞丏丅万丅;
            val_13 = val_13 & 1;
            this.上世丁丕丞且专丆丟 = val_13;
            this.<丁专丒丂丄丞万与丌>k__BackingField = val_13;
            if((val_13 & 1) != 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this._front.localScale;
            if(val_13 != false)
            {
                    UnityEngine.Vector3 val_3 = this._front.localScale;
                this._front.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_4 = this._front.localScale;
                val_13 = this._front;
                UnityEngine.Vector3 val_5 = val_13.localScale;
                this._back.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._front.gameObject, 丏业丟一东丂东丘丛:  true);
                val_14 = this._back;
                UnityEngine.GameObject val_7 = val_14.gameObject;
                val_16 = 0;
            }
            else
            {
                    UnityEngine.Vector3 val_8 = this._front.localScale;
                this._front.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_9 = this._front.localScale;
                val_13 = this._front;
                UnityEngine.Vector3 val_10 = val_13.localScale;
                this._back.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._front.gameObject, 丏业丟一东丂东丘丛:  false);
                val_14 = this._back;
                val_16 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        private void Update()
        {
            UnityEngine.Transform val_44;
            bool val_45;
            float val_46;
            var val_47;
            val_44 = this;
            if((UnityEngine.Input.GetKey(key:  48)) != false)
            {
                    if((UnityEngine.Input.GetKeyUp(key:  110)) != false)
            {
                    this.上世丁丕丞且专丆丟 = true;
                this.<丁专丒丂丄丞万与丌>k__BackingField = (this.<丁专丒丂丄丞万与丌>k__BackingField) ^ 1;
            }
            
            }
            
            if(this.上世丁丕丞且专丆丟 == false)
            {
                    return;
            }
            
            val_45 = this.<丁专丒丂丄丞万与丌>k__BackingField;
            if(val_45 == false)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_4 = this._front.localScale;
            if((val_4.x < 0) || (this._front.gameObject.activeSelf == false))
            {
                goto label_10;
            }
            
            val_45 = this.<丁专丒丂丄丞万与丌>k__BackingField;
            label_5:
            if(val_45 == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_7 = this._back.localScale;
            if(val_7.x >= 0)
            {
                    if(this._back.gameObject.activeSelf == true)
            {
                    return;
            }
            
            }
            
            UnityEngine.GameObject val_12 = this._back.gameObject;
            if(this._front.gameObject.activeSelf == false)
            {
                goto label_20;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Vector3 val_13 = this._front.localScale;
            float val_14 = UnityEngine.Time.deltaTime;
            val_14 = val_14 * this._animationSpeed;
            float val_16 = UnityEngine.Mathf.Max(a:  0f, b:  val_13.x - val_14);
            UnityEngine.Vector3 val_17 = this._front.localScale;
            UnityEngine.Vector3 val_18 = this._front.localScale;
            val_46 = 0f;
            this._front.localScale = new UnityEngine.Vector3() {x = val_46, y = 0f, z = 0f};
            if(0f > 0f)
            {
                    return;
            }
            
            this._back.gameObject.SetActive(value:  true);
            val_44 = this._front.gameObject;
            val_47 = 0;
            goto label_34;
            label_10:
            UnityEngine.GameObject val_23 = this._front.gameObject;
            if(this._back.gameObject.activeSelf == false)
            {
                goto label_38;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Vector3 val_24 = this._back.localScale;
            float val_25 = UnityEngine.Time.deltaTime;
            val_25 = val_25 * this._animationSpeed;
            float val_27 = UnityEngine.Mathf.Max(a:  0f, b:  val_24.x - val_25);
            UnityEngine.Vector3 val_28 = this._back.localScale;
            UnityEngine.Vector3 val_29 = this._back.localScale;
            val_46 = 0f;
            this._back.localScale = new UnityEngine.Vector3() {x = val_46, y = 0f, z = 0f};
            if(0f > 0f)
            {
                    return;
            }
            
            this._back.gameObject.SetActive(value:  false);
            val_44 = this._front.gameObject;
            val_47 = 1;
            label_34:
            val_44.SetActive(value:  true);
            return;
            label_38:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_32 = this._front.localScale;
            float val_33 = UnityEngine.Time.deltaTime;
            val_33 = val_33 * this._animationSpeed;
            float val_35 = UnityEngine.Mathf.Min(a:  1f, b:  val_32.x + val_33);
            UnityEngine.Vector3 val_36 = this._front.localScale;
            UnityEngine.Vector3 val_37 = this._front.localScale;
            val_44 = this._front;
            val_46 = 0f;
            if(val_44 != null)
            {
                goto label_68;
            }
            
            label_69:
            label_68:
            val_44.localScale = new UnityEngine.Vector3() {x = val_46, y = 0f, z = 0f};
            return;
            label_20:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_12, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_38 = this._back.localScale;
            float val_39 = UnityEngine.Time.deltaTime;
            val_39 = val_39 * this._animationSpeed;
            float val_41 = UnityEngine.Mathf.Min(a:  1f, b:  val_38.x + val_39);
            UnityEngine.Vector3 val_42 = this._back.localScale;
            UnityEngine.Vector3 val_43 = this._back.localScale;
            if(this._back != null)
            {
                goto label_68;
            }
            
            goto label_69;
        }
        public GameEventSetItemTwoSidedView()
        {
            this._animationSpeed = 7f;
        }
    
    }

}
