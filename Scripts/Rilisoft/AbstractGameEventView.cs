using UnityEngine;

namespace Rilisoft
{
    public abstract class AbstractGameEventView : MonoBehaviour
    {
        // Fields
        protected const string 丏一丝丞万丑丌丙丑 = "HandleOpen";
        protected const string 与万东世万丂东下丏 = "OnRewardShown";
        protected const string 丅丒丄丂下不丟丟丂 = "Hide";
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UnityEngine.Vector4 丑丘三丈且丄丒一丗;
        protected bool 专丅不丁丂丕业与三;
        private Rilisoft.丛且世丐丆上七业丁 <世丐丈丑不且丌丙下>k__BackingField;
        private bool <丞丘丛丈丛世与业东>k__BackingField;
        private float <且丗三丆丑丝丗一万>k__BackingField;
        internal static bool 丕一不丅丗专七丗与;
        internal static System.Action<Rilisoft.GameEventItem> 丁丒丌不专丙上丂下;
        protected UILabel _endTimerLabel;
        protected UnityEngine.GameObject _progressIndicator;
        protected UIScrollView _scroll;
        protected UIWrapContent _wrap;
        protected UnityEngine.GameObject _backButton;
        protected UnityEngine.GameObject _infoButton;
        protected UnityEngine.GameObject _bankButtonHolder;
        protected Rilisoft.GameEventProgressBar _progressBar;
        protected float _waitAfterSpin;
        protected UnityEngine.AudioClip _openClip;
        protected UnityEngine.AudioClip _closeClip;
        protected UnityEngine.AudioClip _spinClip;
        private float spinClipPlayDelay;
        protected UnityEngine.AudioClip _changeChestClip;
        protected UnityEngine.AudioClip _chestOpenClip;
        protected UnityEngine.AudioClip _chestCloseClip;
        private UnityEngine.AnimationCurve _stopCurve;
        
        // Properties
        protected Rilisoft.丛且世丐丆上七业丁 且丞丂丐不丐不丂丒 { get; set; }
        public Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝 { get; }
        public abstract bool 丝专与丄万丈丟丐丞 { get; set; }
        public abstract bool 三业专专丈丂丕丗与 { get; set; }
        public bool 专丗丄一上丌一丒丕 { get; set; }
        protected float 七一丅丒上丐七不上 { get; set; }
        
        // Methods
        protected Rilisoft.丛且世丐丆上七业丁 上丕丌丕丂丘丁丙万()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<世丐丈丑不且丌丙下>k__BackingField;
        }
        protected void 东丟万下不七丙且东(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<世丐丈丑不且丌丙下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.丛且世丐丆上七业丁 get_gameEvent()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<世丐丈丑不且丌丙下>k__BackingField;
        }
        public abstract bool get_AnyAnimationsPlaying(); // 0
        protected abstract void 业东且丞丁丌业丂丈(bool 丙业与丙丗丝不丈东); // 0
        public abstract bool get_SpinActive(); // 0
        protected abstract void 丕丏一三丒丐世与丟(bool 丙业与丙丗丝不丈东); // 0
        public bool get_ToCenterMoving()
        {
            return (bool)this.<丞丘丛丈丛世与业东>k__BackingField;
        }
        private void 丁业下下三丑丆万一(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丘丛丈丛世与业东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected float 丝丈七丒丞七丏丕丗()
        {
            return (float)this.<且丗三丆丑丝丗一万>k__BackingField;
        }
        private void 下与业丛丘丈三七丐(float 丙业与丙丗丝不丈东)
        {
            this.<且丗三丆丑丝丗一万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public abstract void Show(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, bool 东丆丛东七七丘丐丘 = False); // 0
        public abstract void SpinTo(int 丒丁东世世丗丅丅丄, System.Collections.Generic.List<Rilisoft.GameEventItemData> 丈万丏丌丘丂丄不丏); // 0
        public abstract void CloseChests(System.Action 丗丌世七丅专丝七与, bool 丁下丛丗三丙丙丄下 = False); // 0
        public abstract void Shutdown(); // 0
        public virtual void ShowChest(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
        
        }
        protected virtual System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AbstractGameEventView.丄丌丒丅七东丏丘丕();
        }
        public virtual void UpdateProgressBar()
        {
            if((this.<世丐丈丑不且丌丙下>k__BackingField) == null)
            {
                    return;
            }
            
            this._progressBar.UpdateView(丅东专与不三丂丁丝:  this.<世丐丈丑不且丌丙下>k__BackingField, 七丆丟丗世丟且丒丆:  true);
        }
        protected virtual void OnEnable()
        {
            System.Action val_7;
            var val_8;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                val_7 = public System.Void System.IDisposable::Dispose();
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            val_8 = null;
            val_8 = null;
            if(Rilisoft.AbstractGameEventView.丕一不丅丗专七丗与 != false)
            {
                    new System.Action() = new System.Action(object:  this, method:  typeof(Rilisoft.AbstractGameEventView).__il2cppRuntimeField_240);
                val_7 = new System.Action();
                this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this);
        }
        protected virtual void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        protected virtual void 七丕东丘丑丞三丏丑()
        {
            Rilisoft.AbstractGameEventGui val_7 = Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            goto typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_288;
        }
        protected void 业丑丈丁丙丁世丂丁(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
            var val_66;
            AbstractGameEventView.丟丑不七不丆业丐丛 val_67;
            UIScrollView val_68;
            Rilisoft.DroppedItemData val_69;
            var val_70;
            var val_71;
            UnityEngine.Object val_72;
            AbstractGameEventView.丟丑不七不丆业丐丛 val_1 = new AbstractGameEventView.丟丑不七不丆业丐丛();
            this.万丝丑七丟不业东东(丞东丆与下丁丆七与:  丐下丝丘丑丟丟丗丌.Count);
            this._scroll.ResetPosition();
            this._wrap.minIndex = 0;
            this._wrap.maxIndex = 0;
            if(this._wrap.transform.childCount >= 丐下丝丘丑丟丟丗丌.Count)
            {
                goto label_9;
            }
            
            goto label_10;
            label_38:
            UnityEngine.Transform val_10 = this._wrap.transform.GetChild(index:  this._wrap.transform.childCount - 1);
            UnityEngine.Transform val_13 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  val_10, parent:  this._wrap.gameObject.transform);
            UnityEngine.Vector3 val_15 = val_10.transform.localPosition;
            UnityEngine.Vector3 val_17 = val_10.transform.localPosition;
            UnityEngine.Vector3 val_19 = val_10.transform.localPosition;
            float val_66 = (float)this._wrap.itemSize;
            val_66 = val_15.x + val_66;
            val_13.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            val_13.transform.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            int val_25 = this._wrap.transform.childCount - 1;
            val_13.name = "item_" + val_25;
            label_10:
            if(this._wrap.transform.childCount < 丐下丝丘丑丟丟丗丌.Count)
            {
                goto label_38;
            }
            
            goto label_43;
            label_9:
            if(this._wrap.transform.childCount <= 丐下丝丘丑丟丟丗丌.Count)
            {
                goto label_43;
            }
            
            goto label_44;
            label_56:
            UnityEngine.Transform val_34 = this._wrap.transform.GetChild(index:  0);
            val_34.gameObject.SetActive(value:  false);
            if(val_34 != null)
            {
                    val_34.SetParent(p:  0);
            }
            else
            {
                    0.SetParent(p:  0);
            }
            
            UnityEngine.Object.Destroy(obj:  val_34.gameObject);
            label_44:
            if(this._wrap.transform.childCount > 丐下丝丘丑丟丟丗丌.Count)
            {
                goto label_56;
            }
            
            label_43:
            List.Enumerator<T> val_40 = 丐下丝丘丑丟丟丗丌.GetEnumerator();
            goto label_58;
            label_68:
            UnityEngine.Transform val_44 = this._wrap.transform.GetChild(index:  0);
            Rilisoft.GameEventScrollContainerView val_45 = val_44.GetComponent<Rilisoft.GameEventScrollContainerView>();
            val_45.SetContainer(万三丂且丆三且丝且:  val_25.丐丏七丌丕丗业且上());
            System.Action<Rilisoft.GameEventScrollContainerView> val_46 = new System.Action<Rilisoft.GameEventScrollContainerView>(object:  this, method:  System.Void Rilisoft.AbstractGameEventView::丗一专丝且世丆丛丈(Rilisoft.GameEventScrollContainerView 丌丝万上丅丒一丈丘));
            val_45.remove_OnClickAction(丙业与丙丗丝不丈东:  null);
            System.Action<Rilisoft.GameEventScrollContainerView> val_47 = new System.Action<Rilisoft.GameEventScrollContainerView>(object:  this, method:  System.Void Rilisoft.AbstractGameEventView::丗一专丝且世丆丛丈(Rilisoft.GameEventScrollContainerView 丌丝万上丅丒一丈丘));
            val_45.add_OnClickAction(丙业与丙丗丝不丈东:  null);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_44.gameObject, 丏业丟一东丂东丘丛:  true);
            label_58:
            if(((-410452352) & 1) != 0)
            {
                goto label_68;
            }
            
            val_66 = public System.Void List.Enumerator<Rilisoft.GameEventItemContainer>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_67 = val_1;
            val_68 = this._scroll;
            val_68.ResetPosition();
            val_69 = Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField;
            if( == 0)
            {
                goto label_84;
            }
            
            mem[1152921542851148576] = val_69;
            if(val_69 == null)
            {
                goto label_94;
            }
            
            label_98:
            if( != 0)
            {
                goto label_86;
            }
            
            val_69 = mem[1152921542851148576];
            if(val_69 == 0)
            {
                goto label_87;
            }
            
            label_86:
            val_68 = mem[Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField + 24];
            val_68 = Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField + 24;
            if((System.String.op_Equality(a:  val_68, b:  this.<世丐丈丑不且丌丙下>k__BackingField.业上丙丞丐丄丆丅七())) == false)
            {
                goto label_94;
            }
            
            val_68 = 丐下丝丘丑丟丟丗丌;
            if(((Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField + 16) != val_68.业上丙丞丐丄丆丅七()) || ((System.Linq.Enumerable.Any<Rilisoft.GameEventItemContainer>(source:  丐下丝丘丑丟丟丗丌, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  val_1, method:  System.Boolean AbstractGameEventView.丟丑不七不丆业丐丛::下丆世万丝下丄丐且(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)))) == false))
            {
                goto label_94;
            }
            
            val_70 = mem[Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField + 20];
            val_70 = Rilisoft.AbstractGameEventGui.<丄丞七丌一丗丁不丒>k__BackingField + 20;
            goto label_97;
            label_84:
            mem[16] = val_69;
            if(mem[16] != 0)
            {
                goto label_98;
            }
            
            label_94:
            val_70 = 丐下丝丘丑丟丟丗丌.Item[0].Id;
            label_97:
            val_71 = 0;
            label_109:
            if(val_71 >= this._wrap.transform.childCount)
            {
                goto label_103;
            }
            
            val_72 = this._wrap.transform.GetChild(index:  0).GetComponent<Rilisoft.GameEventScrollContainerView>();
            val_68 = val_72.Container;
            val_71 = val_71 + 1;
            if(val_68.Id != val_70)
            {
                goto label_109;
            }
            
            goto label_110;
            label_103:
            val_72 = 0;
            label_110:
            if(val_72 == 0)
            {
                    return;
            }
            
            this.MoveScrollTo(丞下万上三丘上与专:  val_72.gameObject.transform, 丐丐七专三且世三七:  false, 丝丒丏丒万丂万万东:  1);
            return;
            label_87:
        }
        private void 丗一专丝且世丆丛丈(Rilisoft.GameEventScrollContainerView 丌丝万上丅丒一丈丘)
        {
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            System.Action<Rilisoft.GameEventItem> val_18;
            val_15 = 丌丝万上丅丒一丈丘;
            val_16 = 1152921504848912384;
            if(val_15 == 0)
            {
                    return;
            }
            
            if(val_15.Container == null)
            {
                    return;
            }
            
            if((this & 1) != 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            val_15 = val_15.Container.丙业丈专万下丄丙丏();
            if(val_15 == null)
            {
                    return;
            }
            
            val_17 = null;
            val_17 = null;
            val_18 = Rilisoft.AbstractGameEventView.丁丒丌不专丙上丂下;
            if(val_18 != null)
            {
                    val_18 = Rilisoft.AbstractGameEventView.丁丒丌不专丙上丂下;
                if(val_18 == null)
            {
                    val_18 = 0;
            }
            
                val_18.Invoke(obj:  val_15);
                return;
            }
            
            if((Rilisoft.AbstractGameEventGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_16 = ???;
            goto typeof(Rilisoft.AbstractGameEventGui).__il2cppRuntimeField_268;
        }
        public void MoveScrollTo(UnityEngine.Transform 丞下万上三丘上与专, bool 丐丐七专三且世三七, int 丝丒丏丒万丂万万东)
        {
            UnityEngine.GameObject val_37;
            UnityEngine.Object val_38;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            val_37 = 丐丐七专三且世三七;
            val_38 = 丞下万上三丘上与专;
            this.<丞丘丛丈丛世与业东>k__BackingField = true;
            UIPanel val_1 = this._scroll.panel;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
            val_41 = val_3.x;
            val_42 = val_3.z;
            if(val_38 == 0)
            {
                    return;
            }
            
            if(this._scroll == 0)
            {
                    return;
            }
            
            if(this._scroll.panel == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_9 = this._scroll.panel.cachedTransform;
            UnityEngine.Vector3 val_10 = val_38.position;
            UnityEngine.Vector3 val_11 = val_9.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_40 = val_11.y;
            UnityEngine.Vector3 val_12 = val_9.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_41, y = val_3.y, z = val_42});
            val_43 = val_11.x;
            val_44 = val_40;
            val_45 = val_11.z;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_43, y = val_44, z = val_45}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_38 = this._scroll;
            val_42 = 0f;
            float val_15 = (this._scroll.canMoveHorizontally != true) ? val_13.x : (val_42);
            float val_17 = (val_38.canMoveVertically != true) ? val_13.y : (val_42);
            if(val_37 != false)
            {
                    val_37 = this._scroll.panel.cachedGameObject;
                int val_21 = this._wrap.transform.childCount;
                UnityEngine.Coroutine val_23 = this._wrap.StartCoroutine(routine:  this.东丌东丑万丐不丑上(万且万且丑丗且丌丆:  val_37, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_15, y = val_17, z = 0f}, 业与三万七丝不万东:  val_12.x, 丝丒丏丒万丂万万东:  丝丒丏丒万丂万万东));
                return;
            }
            
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_26 = this._scroll.transform.localPosition;
            UnityEngine.Vector3 val_27 = val_9.localPosition;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_15, y = val_17, z = 0f});
            if(( & 1) != 0)
            {
                    val_43 = 1f;
                val_44 = 0f;
                val_45 = 0f;
            }
            
            UnityEngine.Vector3 val_29 = val_9.localPosition;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_15, y = val_17, z = 0f});
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector3 val_32 = val_9.localPosition;
            val_40 = val_32.y;
            val_9.localPosition = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_40, z = val_32.z});
            float val_37 = val_33.y;
            UnityEngine.Vector2 val_35 = this._scroll.panel.clipOffset;
            val_42 = val_35.x;
            val_41 = val_42 - val_33.x;
            val_37 = val_35.y - val_37;
            this._scroll.panel.clipOffset = new UnityEngine.Vector2() {x = val_41, y = val_37};
            this.<丞丘丛丈丛世与业东>k__BackingField = false;
        }
        private System.Collections.IEnumerator 东丌东丑万丐不丑上(UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.Vector3 三丙业丝丐上不丝丈, float 业与三万七丝不万东, int 丝丒丏丒万丂万万东)
        {
            AbstractGameEventView.丛丘不世不丛东不与 val_1 = new AbstractGameEventView.丛丘不世不丛东不与();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .万且万且丑丗且丌丆 = 万且万且丑丗且丌丆;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 万且万且丑丗且丌丆;
            }
            
            .三丙业丝丐上不丝丈 = 三丙业丝丐上不丝丈;
            mem[1152921542851989448] = 三丙业丝丐上不丝丈.y;
            mem[1152921542851989452] = 三丙业丝丐上不丝丈.z;
            .丝丒丏丒万丂万万东 = 丝丒丏丒万丂万万东;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 万丝丑七丟不业东东(int 丞东丆与下丁丆七与)
        {
            var val_20;
            double val_21;
            var val_22;
            float val_23;
            float val_24;
            UnityEngine.Vector4 val_25;
            UnityEngine.Vector4 val_27;
            double val_28;
            val_20 = this;
            UIPanel val_1 = this._scroll.GetComponent<UIPanel>();
            val_22 = (UnityEngine.Mathf.Clamp(value:  丞东丆与下丁丆七与 - 1, min:  1, max:  2147483647)) * this._wrap.itemSize;
            UnityEngine.Vector4 val_4 = UnityEngine.Vector4.zero;
            if((UnityEngine.Vector4.op_Equality(lhs:  new UnityEngine.Vector4() {x = this.丑丘三丈且丄丒一丗, y = V9.16B, z = V10.16B, w = V8.16B}, rhs:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w})) != false)
            {
                    UnityEngine.Vector4 val_6 = val_1.finalClipRegion;
                val_23 = val_6.z;
                this.丑丘三丈且丄丒一丗 = val_6;
                mem[1152921542852085812] = val_6.y;
                mem[1152921542852085816] = val_23;
                mem[1152921542852085820] = val_6.w;
            }
            
            val_24 = (float)val_22;
            if(S9 > val_24)
            {
                    UnityEngine.Vector4 val_7 = val_1.finalClipRegion;
                val_25 = this.丑丘三丈且丄丒一丗;
                if(val_1 != null)
            {
                goto label_13;
            }
            
            }
            else
            {
                    if(val_1.width >= 0)
            {
                    return;
            }
            
                UnityEngine.Vector4 val_9 = val_1.finalClipRegion;
                val_27 = this.丑丘三丈且丄丒一丗;
            }
            
            label_13:
            val_20 = ???;
            val_22 = ???;
            val_28 = ???;
            val_21 = ???;
            goto typeof(UIPanel).__il2cppRuntimeField_258;
        }
        protected AbstractGameEventView()
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            this.丑丘三丈且丄丒一丗 = val_1;
            mem[1152921542852210100] = val_1.y;
            mem[1152921542852210104] = val_1.z;
            mem[1152921542852210108] = val_1.w;
            this._waitAfterSpin = 0.5f;
            this.spinClipPlayDelay = 0.15f;
        }
        private static AbstractGameEventView()
        {
            Rilisoft.AbstractGameEventView.丕一不丅丗专七丗与 = true;
        }
    
    }

}
