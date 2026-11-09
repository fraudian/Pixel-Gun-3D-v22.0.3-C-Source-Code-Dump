using UnityEngine;

namespace Rilisoft
{
    public class ZombieGameView : MonoBehaviour
    {
        // Fields
        protected const string 丏一丝丞万丑丌丙丑 = "HandleOpen";
        protected const string 与万东世万丂东下丏 = "OnRewardShown";
        protected const string 丅丒丄丂下不丟丟丂 = "Hide";
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UnityEngine.Vector4 丑丘三丈且丄丒一丗;
        protected bool 专丅不丁丂丕业与三;
        private bool 世丁丝丑丒一丁丛丁;
        private 三且且三丕丟上丌丂 currentPrise;
        private Rilisoft.丛且世丐丆上七业丁 <世丐丈丑不且丌丙下>k__BackingField;
        private static Rilisoft.ZombieGameView <丞丟丅专丐一丌丐且>k__BackingField;
        private bool <丞丘丛丈丛世与业东>k__BackingField;
        private float <且丗三丆丑丝丗一万>k__BackingField;
        private System.EventHandler 丈丆一丏丙丄丛丌上;
        private System.EventHandler 万丞丂专七丁专丂丑;
        protected UIScrollView _scroll;
        protected UIWrapContent _wrap;
        protected UnityEngine.GameObject _backButton;
        protected float _waitAfterSpin;
        protected GiftHUDItem giftRewardView;
        protected UnityEngine.AudioClip _openClip;
        protected UnityEngine.AudioClip _closeClip;
        protected UnityEngine.AudioClip _spinClip;
        private float spinClipPlayDelay;
        protected UnityEngine.AudioClip _changeChestClip;
        protected UnityEngine.AudioClip _chestOpenClip;
        protected UnityEngine.AudioClip _chestCloseClip;
        private UnityEngine.AnimationCurve _stopCurve;
        private Rilisoft.GameEventRewardView RewardView;
        
        // Properties
        protected Rilisoft.丛且世丐丆上七业丁 且丞丂丐不丐不丂丒 { get; set; }
        public Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝 { get; }
        internal static Rilisoft.ZombieGameView 丌丛丟丁丏丌且丛且 { get; set; }
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
        internal static Rilisoft.ZombieGameView 且丕丈丙丛不业丂丗()
        {
            return (Rilisoft.ZombieGameView)Rilisoft.ZombieGameView.<丞丟丅专丐一丌丐且>k__BackingField;
        }
        private static void 丂上丐丂丆丁丒三丐(Rilisoft.ZombieGameView 丙业与丙丗丝不丈东)
        {
            Rilisoft.ZombieGameView.<丞丟丅专丐一丌丐且>k__BackingField = 丙业与丙丗丝不丈东;
        }
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
        internal void 万三丆万丑丐丏丞一(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丈丆一丏丙丄丛丌上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈丆一丏丙丄丛丌上 != 1152921542254764064);
        
        }
        internal void 丈且丛丟丐七丟丗丝(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丈丆一丏丙丄丛丌上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丈丆一丏丙丄丛丌上 != 1152921542254900640);
        
        }
        internal void 三一丈世丟三专专丄(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.万丞丂专七丁专丂丑, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万丞丂专七丁专丂丑 != 1152921542255037224);
        
        }
        internal void 丏丆丗丆丝与丛上丈(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.万丞丂专七丁专丂丑, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万丞丂专七丁专丂丑 != 1152921542255173800);
        
        }
        public void ShowChest(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌)
        {
        
        }
        private void Awake()
        {
            Rilisoft.ZombieGameView.<丞丟丅专丐一丌丐且>k__BackingField = this;
        }
        public void GetReward()
        {
            this.世丁丝丑丒一丁丛丁 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        protected void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.ZombieGameView::七丕东丘丑丞三丏丑()), 与且专丈不万东一万:  0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.RewardView, 丏业丟一东丂东丘丛:  false);
        }
        protected void OnDisable()
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
        protected void 七丕东丘丑丞三丏丑()
        {
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
            {
                
            }
        
        }
        private void 丟丛业丂丅丂丝丘万()
        {
            this.世丁丝丑丒一丁丛丁 = true;
            ZombiKillController.丑七不且上丗丁一世().ResetEvent();
            Rilisoft.GameEventItemData val_2 = this.currentPrise.丒丅丙丄丞丟下丏业();
            this.OnBackColiderClick();
        }
        public void AddReward(Rilisoft.GameEventItemData 下丅丙一丂丗丅丝七)
        {
        
        }
        protected void 业丑丈丁丙丁世丂丁()
        {
        
        }
        private void 丗一专丝且世丆丛丈(Rilisoft.GameEventScrollView 丌丝万上丅丒一丈丘)
        {
            Rilisoft.GameEventScrollView val_12 = 丌丝万上丅丒一丈丘;
            if(val_12 == 0)
            {
                    return;
            }
            
            if(val_12.Item == null)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            val_12 = val_12.Item;
            if(val_12 == null)
            {
                    return;
            }
            
            Rilisoft.AbstractGameEventGui val_6 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
            val_12 = ???;
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
            ZombieGameView.丒下丟丟丅丅丐丗丙 val_1 = new ZombieGameView.丒下丟丟丅丅丐丗丙();
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
            mem[1152921542256935880] = 三丙业丝丐上不丝丈.y;
            mem[1152921542256935884] = 三丙业丝丐上不丝丈.z;
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
                mem[1152921542257032244] = val_6.y;
                mem[1152921542257032248] = val_23;
                mem[1152921542257032252] = val_6.w;
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
        public void OnClose()
        {
            var val_1;
            if(this.丈丆一丏丙丄丛丌上 == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.丈丆一丏丙丄丛丌上.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        public void OnWatch()
        {
            var val_1;
            if(this.万丞丂专七丁专丂丑 == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.万丞丂专七丁专丂丑.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        public void OnBackColiderClick()
        {
            if(this.世丁丝丑丒一丁丛丁 == false)
            {
                    return;
            }
            
            this.OnClose();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public ZombieGameView()
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            this.世丁丝丑丒一丁丛丁 = true;
            this._waitAfterSpin = 0.5f;
            this.丑丘三丈且丄丒一丗 = val_1;
            mem[1152921542257517108] = val_1.y;
            mem[1152921542257517112] = val_1.z;
            mem[1152921542257517116] = val_1.w;
            this.spinClipPlayDelay = 0.15f;
        }
    
    }

}
