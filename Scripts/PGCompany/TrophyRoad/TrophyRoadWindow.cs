using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal sealed class TrophyRoadWindow : PGBehaviour
    {
        // Fields
        private static System.Action 丏丂不上丒丂丌丄下;
        private System.Action 丛丄业丘不丆丄三丞;
        private EndlessScrollDynamic _roadScroll;
        private UIPanel _scrollPanel;
        private PGCompany.TrophyRoad.TrophyRoadCell _cellExample;
        private UnityEngine.GameObject _endTimerContainer;
        private PGCompany.TimerUI _endTimer;
        private UnityEngine.GameObject _updateDataContainer;
        private UnityEngine.GameObject _leftRewardsButton;
        private UnityEngine.GameObject _rightRewardsButton;
        private Rilisoft.BankBannersHolder _bannersHolder;
        private UnityEngine.GameObject _commonHolder;
        private UIButton _backButton;
        private UnityEngine.GameObject _lockAnimationContainer;
        private System.Collections.Generic.Dictionary<int, PGCompany.TrophyRoad.丈专世丅丞万丌东丗> 丘丑丆丗丝丙且丏世;
        private int 世丆不丏丁七丑丌丄;
        private System.Collections.Generic.List<PGCompany.TrophyRoad.TrophyRoadCell> 且上业丟丕一与三业;
        private PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow 丅上万且丄丕且丈上;
        private const string 丗东丙业丁上世丒丅 = "last_save_animation_tokens_tr";
        private const string 丕丙丄万业上丄丐与 = "last_save_animation_level_tr";
        private bool 一不丅丈上丟专丐下;
        private float _delayTickAnimation;
        private UnityEngine.Coroutine 丕丛万一且万丟丝世;
        private UnityEngine.Coroutine 万三不专丒丘丕丛一;
        private UnityEngine.Coroutine 丄与丈业丌业丕丅丑;
        private bool _isMoveScrollOffsetComplete;
        
        // Properties
        internal int 丗丅不业丕丌丝丆万 { get; set; }
        internal int 丏丗万丈丗专丐丐丙 { get; set; }
        
        // Methods
        internal static void 丗丒丛丗上丒丅丝丐(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.TrophyRoad.TrophyRoadWindow.丕丙丄万业上丄丐与, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 下丌业丒业丌丁丘丄(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.TrophyRoad.TrophyRoadWindow.丕丙丄万业上丄丐与, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921559546581912);
        
        }
        internal void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921559546718488);
        
        }
        internal int 丑上不万丐世丅丂一()
        {
            return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  "last_save_animation_tokens_tr", arg1:  FriendsController.不丝丕丒丂丆丘丙丙()), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        internal void 丂三专丄丐丆丐丈丌(int 丙业与丙丗丝不丈东)
        {
            if(this.丑上不万丐世丅丂一() == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  "last_save_animation_tokens_tr", arg1:  FriendsController.不丝丕丒丂丆丘丙丙()), 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal int 丝丐上不世丄丌丑丟()
        {
            return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  "last_save_animation_level_tr", arg1:  FriendsController.不丝丕丒丂丆丘丙丙()), 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        internal void 丆业东丝丒丘丂丕专(int 丙业与丙丗丝不丈东)
        {
            if(this.丝丐上不世丄丌丑丟() == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  System.String.Format(format:  "{0}_{1}", arg0:  "last_save_animation_level_tr", arg1:  FriendsController.不丝丕丒丂丆丘丙丙()), 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private void Awake()
        {
            this.丛且丐下世与丘丆丗();
        }
        private void OnEnable()
        {
            PGCompany.TrophyRoad.TrophyRoadCell.丙丏丒三丞丂丞与世(丙业与丙丗丝不丈东:  new System.Action<PGCompany.TrophyRoad.丆丅且丞丝丗与且与>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丕丒丛丟且丟不业丒(PGCompany.TrophyRoad.丆丅且丞丝丗与且与 丗七丟丈三不丕一三)));
            PGCompany.TrophyRoad.TrophyRoadCell.丟与万丅且丕丞丈东(丙业与丙丗丝不丈东:  new System.Action<PGCompany.TrophyRoad.丆丅且丞丝丗与且与>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丕丒丛丟且丟不业丒(PGCompany.TrophyRoad.丆丅且丞丝丗与且与 丗七丟丈三不丕一三)));
            this.不丕丙上丅丗三丂与();
            if(PGCompany.TrophyRoad.TrophyRoadWindow.丕丙丄万业上丄丐与 == null)
            {
                    return;
            }
            
            PGCompany.TrophyRoad.TrophyRoadWindow.丕丙丄万业上丄丐与.Invoke();
        }
        private void OnDisable()
        {
            PGCompany.TrophyRoad.TrophyRoadCell.丙丏丒三丞丂丞与世(丙业与丙丗丝不丈东:  new System.Action<PGCompany.TrophyRoad.丆丅且丞丝丗与且与>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丕丒丛丟且丟不业丒(PGCompany.TrophyRoad.丆丅且丞丝丗与且与 丗七丟丈三不丕一三)));
            this.丏下丄东丟丝丂业七();
        }
        private void OnDestroy()
        {
            this.万与七三丄丁丏世丘();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            if(this.一不丅丈上丟专丐下 != false)
            {
                    return;
            }
            
            this.一不丅丈上丟专丐下 = true;
            this.丈业东业丆不且七丙();
        }
        private void 丈业东业丆不且七丙()
        {
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.TrophyRoad.丈专世丅丞万丌东丗> val_5;
            var val_6;
            PGCompany.TrophyRoad.与丂三专且丅万世一 val_1 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世();
            if(val_1.丅丛丅且丅上七且与 == null)
            {
                goto label_2;
            }
            
            val_5 = val_1.丅丛丅且丅上七且与.丐不且且丅丏丅一三;
            this.丘丑丆丗丝丙且丏世 = val_5;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_6 = 0;
            goto label_4;
            label_2:
            val_5 = 0;
            this.丘丑丆丗丝丙且丏世 = 0;
            label_3:
            val_6 = 1;
            label_4:
            .Level = 2147483647;
            val_5.set_Item(key:  val_5.Count + 1, value:  new PGCompany.TrophyRoad.丈专世丅丞万丌东丗());
        }
        internal void 下与丞三丅丛丄七丕(System.Action 丝上丂一不专丂丄不)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._commonHolder, 丏业丟一东丂东丘丛:  true);
            this._scrollPanel.ResetAndUpdateAnchors();
            this.丛丄业丘不丆丄三丞 = 丝上丂一不专丂丄不;
            if(this.一不丅丈上丟专丐下 != true)
            {
                    this.一不丅丈上丟专丐下 = true;
                this.丈业东业丆不且七丙();
            }
            
            if((this.丘丑丆丗丝丙且丏世 != null) && (this.丘丑丆丗丝丙且丏世.Count != 0))
            {
                    this.丗丆东且丕与丁丌丑();
                int val_3 = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().不丑丒丟丘不且七万();
                int val_4 = val_3.丑上不万丐世丅丂一();
                if(val_4 > val_3)
            {
                    val_4.丂三专丄丐丆丐丈丌(丙业与丙丗丝不丈东:  val_3);
            }
            
                int val_5 = this.丕丆丒一丂丗丘丟三(丞世不丒下上上丝丑:  this.世丆不丏丁七丑丌丄);
                int val_9 = UnityEngine.Mathf.Clamp(value:  val_5 - 1, min:  0, max:  this.丘丑丆丗丝丙且丏世.Count - this._roadScroll.cellsCount);
                this._roadScroll.Init(上专丅业三丏丈丈丗:  this.丘丑丆丗丝丙且丏世.Count, 丏丑丝万下与丁丞业:  val_9);
                this.上丛业丙丙七丒丝丁();
                this._roadScroll.SetBounds();
                this.一丐丂丒且不丄万丂(丑东丁一丏丑专丟专:  val_9, 丝且专且丅三且丂丕:  val_5);
                bool val_11 = this.不下世丅丅丆丈丐丝(丒丐丑世丁丕与七丙:  val_3);
                return;
            }
            
            if(this.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            this.丛丄业丘不丆丄三丞.Invoke();
        }
        private void 一丐丂丒且不丄万丂(int 丑东丁一丏丑专丟专, int 丝且专且丅三且丂丕)
        {
            var val_9;
            UIPanel val_10;
            val_9 = 丑东丁一丏丑专丟专;
            val_10 = this;
            if(val_9 >= 丝且专且丅三且丂丕)
            {
                    return;
            }
            
            if(this._scrollPanel == 0)
            {
                    return;
            }
            
            val_9 = 丝且专且丅三且丂丕 - val_9;
            float val_9 = 0f;
            do
            {
                val_9 = val_9 - 1;
                val_9 = val_9 + (float)this._cellExample.Width;
            }
            while(val_9 != 0);
            
            UnityEngine.Transform val_3 = this._scrollPanel.transform;
            UnityEngine.Vector3 val_4 = val_3.localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_3.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            val_10 = this._scrollPanel;
            UnityEngine.Vector2 val_6 = val_10.clipOffset;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_9, y:  0f);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            val_10.clipOffset = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        private bool 不下世丅丅丆丈丐丝(int 丒丐丑世丁丕与七丙)
        {
            UnityEngine.GameObject val_5;
            var val_6;
            val_5 = this;
            if(this.丑上不万丐世丅丂一() == 丒丐丑世丁丕与七丙)
            {
                    val_5 = this._lockAnimationContainer;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
                val_6 = 0;
                return (bool)val_6;
            }
            
            PGCompany.TrophyRoad.与丂三专且丅万世一 val_2 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世();
            this.丛上丐与世丟万专丟(丞世不丒下上上丝丑:  val_2.丙丆丝丞丘丗世且丙(丏丆丈不丁丞丒丒一:  val_2.丑上不万丐世丅丂一()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockAnimationContainer, 丏业丟一东丂东丘丛:  true);
            if(this.丕丛万一且万丟丝世 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丕丛万一且万丟丝世);
            }
            
            this.丒丆业世一下七丏七();
            val_6 = 1;
            return (bool)val_6;
        }
        private int 丕丆丒一丂丗丘丟三(int 丞世不丒下上上丝丑)
        {
            if(this._scrollPanel == 0)
            {
                    return 0;
            }
            
            int val_16 = UnityEngine.Mathf.Max(a:  0, b:  PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丈一下下丞世三丑丄());
            float val_15 = (float)this._cellExample.Width;
            val_15 = this._scrollPanel.width / val_15;
            var val_7 = ((int)val_15 < 0f) ? ((int)val_15 + 1) : ((int)val_15);
            var val_8 = val_7 & 4294967294;
            val_8 = (int)val_15 - val_8;
            val_16 = val_16 - (val_7 >> 1);
            val_16 = val_16 - ((val_8 > 0f) ? 1 : 0);
            val_16 = val_16 & (~(val_16 >> 31));
            int val_11 = this._cellExample.Width;
            var val_13 = (this._scrollPanel.width > 0f) ? -1 : 0;
            val_13 = val_13 - (int)val_15;
            return System.Math.Min(val1:  val_16, val2:  val_13 + this.丘丑丆丗丝丙且丏世.Count);
        }
        private void 丝丟丄丛上丌专丕丑()
        {
            if(this.丕丛万一且万丟丝世 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丕丛万一且万丟丝世);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockAnimationContainer, 丏业丟一东丂东丘丛:  false);
            int val_2 = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().不丑丒丟丘不且七万();
            val_2.丂三专丄丐丆丐丈丌(丙业与丙丗丝不丈东:  val_2);
            PGCompany.TrophyRoad.与丂三专且丅万世一 val_3 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世();
            int val_5 = val_3.丙丆丝丞丘丗世且丙(丏丆丈不丁丞丒丒一:  val_3.丑上不万丐世丅丂一());
            val_5.丅业一下业丂丅且丆(丈丘丝一丗下丈丐不:  val_5);
            this.丛上丐与世丟万专丟(丞世不丒下上上丝丑:  val_5);
        }
        private void 丒丆业世一下七丏七()
        {
            int val_2 = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().不丑丒丟丘不且七万();
            if(val_2.丑上不万丐世丅丂一() >= val_2)
            {
                goto label_4;
            }
            
            PGCompany.TrophyRoad.与丂三专且丅万世一 val_4 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世();
            int val_19 = val_4.丑上不万丐世丅丂一();
            int val_6 = val_4.丙丆丝丞丘丗世且丙(丏丆丈不丁丞丒丒一:  val_19);
            int val_7 = val_6.丑上不万丐世丅丂一();
            val_19 = val_7 + 1;
            val_7.丂三专丄丐丆丐丈丌(丙业与丙丗丝不丈东:  val_19);
            PGCompany.TrophyRoad.与丂三专且丅万世一 val_8 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世();
            int val_10 = val_8.丙丆丝丞丘丗世且丙(丏丆丈不丁丞丒丒一:  val_8.丑上不万丐世丅丂一());
            int val_11 = val_10.丝丐上不世丄丌丑丟();
            val_11.丅业一下业丂丅且丆(丈丘丝一丗下丈丐不:  val_10);
            if(val_10 > val_6)
            {
                    this.东专丑七与丟丁上丗(业丌丆业丘丟丆丁丛:  val_10 - 1, 丆世与世丘丑丗丄丞:  (val_10 > val_11) ? 1 : 0);
                this.东专丑七与丟丁上丗(业丌丆业丘丟丆丁丛:  val_10 - 2, 丆世与世丘丑丗丄丞:  false);
            }
            
            this.东专丑七与丟丁上丗(业丌丆业丘丟丆丁丛:  val_10, 丆世与世丘丑丗丄丞:  false);
            this.一丛且丌东丂丂丟业(丈丘丝一丗下丈丐不:  val_10);
            int val_15 = this.丑上不万丐世丅丂一();
            if((val_15 + 1) <= val_2)
            {
                goto label_8;
            }
            
            label_4:
            val_15.丂三专丄丐丆丐丈丌(丙业与丙丗丝不丈东:  val_2);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockAnimationContainer, 丏业丟一东丂东丘丛:  false);
            return;
            label_8:
            this.丕丛万一且万丟丝世 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this._delayTickAnimation, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丒丆业世一下七丏七()));
        }
        private void 一丛且丌东丂丂丟业(int 丈丘丝一丗下丈丐不)
        {
            UIPanel val_24;
            UIPanel val_25;
            float val_26;
            val_24 = this;
            val_25 = this._scrollPanel;
            if(val_25 == 0)
            {
                    return;
            }
            
            float val_24 = this._scrollPanel.width;
            val_24 = val_24 / (float)this._cellExample.Width;
            val_25 = this._cellExample;
            int val_5 = val_25.Width;
            val_26 = this._scrollPanel.width;
            if((int)val_24 > 丈丘丝一丗下丈丐不)
            {
                    return;
            }
            
            val_25 = this.丘丑丆丗丝丙且丏世;
            var val_25 = -((((int)val_24 < 0f) ? ((int)val_24 + 1) : ((int)val_24)) >> 1);
            val_25 = val_25 - ((val_26 > 0f) ? 1 : 0);
            val_25 = val_25 + val_25.Count;
            val_25 = val_25 - 1;
            if(val_25 < 丈丘丝一丗下丈丐不)
            {
                    return;
            }
            
            val_25 = this._cellExample.Width;
            float val_26 = 1f;
            val_26 = val_26 / ((float)(PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().不丗丁不丛与万不业(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不 + 1)) - (PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().不丗丁不丛与万不业(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不)));
            float val_16 = val_26 * 100f;
            val_16 = ((float)val_25 / 100f) * val_16;
            UnityEngine.Transform val_18 = this._scrollPanel.transform;
            UnityEngine.Vector3 val_19 = val_18.localPosition;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_18.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            val_24 = this._scrollPanel;
            UnityEngine.Vector2 val_21 = val_24.clipOffset;
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_16, y:  0f);
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            val_26 = val_23.x;
            val_24.clipOffset = new UnityEngine.Vector2() {x = val_26, y = val_23.y};
        }
        private void 丅业一下业丂丅且丆(int 丈丘丝一丗下丈丐不)
        {
            if(丈丘丝一丗下丈丐不 == 0)
            {
                    return;
            }
            
            int val_1 = this.丝丐上不世丄丌丑丟();
            if(val_1 >= 丈丘丝一丗下丈丐不)
            {
                    return;
            }
            
            val_1.丆业东丝丒丘丂丕专(丙业与丙丗丝不丈东:  丈丘丝一丗下丈丐不);
        }
        public void U_Hide()
        {
            this.丆世与丑丆丅丐万且();
        }
        private void 丆世与丑丆丅丐万且()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this._roadScroll.scroll.currentMomentum = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            if(this.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            this.丛丄业丘不丆丄三丞.Invoke();
        }
        private void 丗丆东且丕与丁丌丑()
        {
            this.世丆不丏丁七丑丌丄 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丟丁业丝丁且世丑与();
        }
        private void 上丛业丙丙七丒丝丁()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._endTimerContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._updateDataContainer, 丏业丟一东丂东丘丛:  false);
        }
        private void 世且丅上丝丂东与丙()
        {
            if((PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().七三不业三丕丈丅丈() & 2147483648) == 0)
            {
                    this.上丛业丙丙七丒丝丁();
                return;
            }
            
            this.万三不专丒丘丕丛一 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::世且丅上丝丂东与丙()));
        }
        private void 东专丑七与丟丁上丗(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
        {
            EndlessScrollCellDynamic val_6 = 丌丝万上丅丒一丈丘;
            if(val_6 != null)
            {
                    val_6 = 0;
            }
            
            if( == 0)
            {
                    return;
            }
            
            if((this.且上业丟丕一与三业.Contains(item:  null)) != true)
            {
                    this.且上业丟丕一与三业.Add(item:  null);
            }
            
            丈且东丑丂且万丒丅(不丌不世且丄不三丝:  this, 丗丟上上丒丐丗丞丙:  this.业世七万不上下与丟(丞世不丒下上上丝丑:  val_6.Index));
            this.丂下丛业万丅东万世();
        }
        private void 东专丑七与丟丁上丗(int 业丌丆业丘丟丆丁丛, bool 丆世与世丘丑丗丄丞 = False)
        {
            UnityEngine.Object val_6;
            List.Enumerator<T> val_2 = this.且上业丟丕一与三业.GetEnumerator();
            label_4:
            if(((-891232248) & 1) == 0)
            {
                goto label_2;
            }
            
            val_6 = 0.丐丏七丌丕丗业且上();
            if(val_6.Index != 业丌丆业丘丟丆丁丛)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_6 = 0;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 0)
            {
                    return;
            }
            
            val_6.丈且东丑丂且万丒丅(不丌不世且丄不三丝:  this, 丗丟上上丒丐丗丞丙:  this.业世七万不上下与丟(丞世不丒下上上丝丑:  业丌丆业丘丟丆丁丛));
            if(丆世与世丘丑丗丄丞 != false)
            {
                    val_6.丘丑丅丈专世不业丁();
            }
            
            this.丂下丛业万丅东万世();
        }
        private void 丂下丛业万丅东万世()
        {
            var val_6;
            int val_25;
            var val_26;
            var val_27;
            UnityEngine.Object val_28;
            UnityEngine.GameObject val_29;
            var val_30;
            UnityEngine.GameObject val_32;
            var val_33;
            float val_34;
            var val_35;
            UnityEngine.GameObject val_36;
            val_25 = this.世丆不丏丁七丑丌丄;
            if(val_25 == 1)
            {
                    val_25 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丈一下下丞世三丑丄() + 1;
            }
            
            if((val_25 < 1) || (val_25 >= this.丘丑丆丗丝丙且丏世.Count))
            {
                goto label_5;
            }
            
            List.Enumerator<T> val_4 = this._roadScroll.cellsList.GetEnumerator();
            val_26 = 2147483647;
            val_27 = -2147483648;
            label_10:
            if(((-891030160) & 1) == 0)
            {
                goto label_8;
            }
            
            val_28 = val_6.丐丏七丌丕丗业且上();
            int val_8 = val_28.Index;
            int val_9 = val_8 + 1;
            var val_10 = (val_9 >= val_26) ? (val_26) : (val_8 + 1);
            var val_11 = (val_9 <= val_27) ? (val_27) : (val_8 + 1);
            if(val_25 != val_9)
            {
                goto label_10;
            }
            
            goto label_11;
            label_5:
            val_29 = this._leftRewardsButton;
            goto label_14;
            label_8:
            val_28 = 0;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 0)
            {
                goto label_21;
            }
            
            val_30 = 1152921505284374528;
            if(val_25 < val_26)
            {
                goto label_22;
            }
            
            val_29 = this._leftRewardsButton;
            if(val_25 <= val_27)
            {
                goto label_23;
            }
            
            label_41:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29, 丏业丟一东丂东丘丛:  false);
            val_32 = this._rightRewardsButton;
            val_33 = 1;
            goto label_26;
            label_21:
            UnityEngine.Vector3 val_14 = val_28.transform.position;
            val_34 = val_14.x;
            val_25 = this._roadScroll.bottomBoundGO;
            UnityEngine.Vector3 val_16 = val_25.position;
            if((val_34 - (this._roadScroll.GetWorldHalfSize(世丌丌丙丞丟下东丞:  135970152))) >= 0)
            {
                goto label_33;
            }
            
            val_30 = 1152921505284374528;
            label_22:
            val_35 = 1;
            val_36 = this._leftRewardsButton;
            goto label_36;
            label_33:
            UnityEngine.Vector3 val_19 = val_28.transform.position;
            val_25 = this._roadScroll;
            val_34 = val_19.x;
            UnityEngine.Vector3 val_21 = this._roadScroll.topBoundGO.position;
            val_29 = this._leftRewardsButton;
            if((val_34 + (val_25.GetWorldHalfSize(世丌丌丙丞丟下东丞:  135970152))) > val_21.x)
            {
                goto label_41;
            }
            
            label_23:
            label_14:
            val_36 = val_29;
            val_35 = 0;
            label_36:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  false);
            val_32 = this._rightRewardsButton;
            val_33 = 0;
            label_26:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  false);
        }
        private void 七丌丈丑丅丕万丏丈(int 丈丘丝一丗下丈丐不)
        {
        
        }
        private PGCompany.TrophyRoad.丈专世丅丞万丌东丗 业世七万不上下与丟(int 丞世不丒下上上丝丑)
        {
            var val_4;
            int val_4 = 丞世不丒下上上丝丑;
            val_4 = val_4 + 1;
            val_4 = 0;
            if((val_4 & 2147483648) != 0)
            {
                    return (PGCompany.TrophyRoad.丈专世丅丞万丌东丗)val_4;
            }
            
            if(this.丘丑丆丗丝丙且丏世.Count == 0)
            {
                    return (PGCompany.TrophyRoad.丈专世丅丞万丌东丗)val_4;
            }
            
            if((this.丘丑丆丗丝丙且丏世.ContainsKey(key:  val_4)) != false)
            {
                    PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_3 = this.丘丑丆丗丝丙且丏世.Item[val_4];
                return (PGCompany.TrophyRoad.丈专世丅丞万丌东丗)val_4;
            }
            
            val_4 = 0;
            return (PGCompany.TrophyRoad.丈专世丅丞万丌东丗)val_4;
        }
        private void 丕丒丛丟且丟不业丒(PGCompany.TrophyRoad.丆丅且丞丝丗与且与 丗七丟丈三不丕一三)
        {
            if(丗七丟丈三不丕一三 == null)
            {
                    return;
            }
            
            if(丗七丟丈三不丕一三.三东丏不丗世丅丌丄 == null)
            {
                    return;
            }
            
            Rilisoft.ItemViewer val_2 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.transform, 丈丄不七三万丄丁不:  丗七丟丈三不丕一三.三东丏不丗世丅丌丄, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
        }
        private void 丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)
        {
            this.丗丆东且丕与丁丌丑();
            this.丂下丛业万丅东万世();
        }
        private void 丛且丐下世与丘丆丗()
        {
            PGCompany.TrophyRoad.与丂三专且丅万世一.丈三丘丄一丗丌一东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丈业东业丆不且七丙()));
            PGCompany.TrophyRoad.与丂三专且丅万世一.丐丏三万丐且丗专世(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)));
            this._roadScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::东专丑七与丟丁上丗(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
            this._roadScroll.add_OnWrapBack(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丂下丛业万丅东万世()));
            this._roadScroll.add_OnWrapForward(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丂下丛业万丅东万世()));
        }
        private void 万与七三丄丁丏世丘()
        {
            PGCompany.TrophyRoad.与丂三专且丅万世一.与世上丘一不丐不上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丈业东业丆不且七丙()));
            PGCompany.TrophyRoad.与丂三专且丅万世一.丑丂丂丄丂专丐丘与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丛丆世丏丒丕丅丁东(int 丈丘丝一丗下丈丐不)));
            this._roadScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::东专丑七与丟丁上丗(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
            this._roadScroll.remove_OnWrapBack(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丂下丛业万丅东万世()));
            this._roadScroll.remove_OnWrapForward(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::丂下丛业万丅东万世()));
        }
        public void U_GoReward()
        {
            this.丛上丐与世丟万专丟(丞世不丒下上上丝丑:  this.世丆不丏丁七丑丌丄);
        }
        private void 丛上丐与世丟万专丟(int 丞世不丒下上上丝丑)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this._roadScroll.scroll.currentMomentum = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            int val_2 = this.丕丆丒一丂丗丘丟三(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            int val_6 = UnityEngine.Mathf.Clamp(value:  val_2 - 1, min:  0, max:  this.丘丑丆丗丝丙且丏世.Count - this._roadScroll.cellsCount);
            this._roadScroll.ToCell(丞世不丒下上上丝丑:  val_6);
            this.一丐丂丒且不丄万丂(丑东丁一丏丑专丟专:  val_6, 丝且专且丅三且丂丕:  val_2);
        }
        public void U_GoToBank()
        {
            null = null;
            this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        }
        public void U_SkipAnimation()
        {
            this.丝丟丄丛上丌专丕丑();
        }
        private void 万丞丌七丈丄丙东万(string 丏丂不专上丘丂不丅)
        {
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丏丂不专上丘丂不丅, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        }
        private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
        }
        internal void 丁万一丆丂不业丞丆(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        private void 万且丌三且丞丂丟丙()
        {
            PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow val_8;
            if(this.丅上万且丄丕且丈上 != 0)
            {
                goto label_3;
            }
            
            PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow val_2 = UnityEngine.Resources.Load<PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow>(path:  "ConnectScene_v2/TrophyRoad/TrophyRoad_SeasonEnded");
            if(val_2 != 0)
            {
                goto label_6;
            }
            
            object[] val_4 = new object[1];
            val_4[0] = "ConnectScene_v2/TrophyRoad/TrophyRoad_SeasonEnded";
            UnityEngine.Debug.LogErrorFormat(format:  "Not contains prefab on path: {0}", args:  val_4);
            return;
            label_3:
            val_8 = this.丅上万且丄丕且丈上;
            goto label_13;
            label_6:
            val_8 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow>(丑且不丕与专丄业丙:  val_2, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            this.丅上万且丄丕且丈上 = val_8;
            label_13:
            val_8.下与丞三丅丛丄七丕(丞丟万丝七丁丈丌丝:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::且丆丆丅丐丙下下丄()));
        }
        private void 且丆丆丅丐丙下下丄()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  8);
            bool val_3 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丗丟七丁不丟一业下();
            bool val_5 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().世丄且丒丌丟丕世丛();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丁业丅丗丝业丂丅世() != false)
            {
                    this.下与丞三丅丛丄七丕(丝上丂一不专丂丄不:  this.丛丄业丘不丆丄三丞);
                return;
            }
            
            this.丆世与丑丆丅丐万且();
        }
        private void 不丕丙上丅丗三丂与()
        {
            UnityEngine.Object val_6;
            this.丏下丄东丟丝丂业七();
            this.丄与丈业丌业丕丅丑 = CoroutineRunner.丄丝丝丏丗三丙与丁(业丗七丕万万不丈丗:  1, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadWindow::不丕丙上丅丗三丂与()));
            val_6 = this.丅上万且丄丕且丈上;
            if(val_6 != 0)
            {
                    val_6 = this.丅上万且丄丕且丈上;
                if(val_6.丅业东万丌丕上丌丄() == true)
            {
                    return;
            }
            
            }
            
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丗丏丗丆丕丁丑上上() == false)
            {
                    return;
            }
            
            this.万且丌三且丞丂丟丙();
        }
        private void 丏下丄东丟丝丂业七()
        {
            if(this.丄与丈业丌业丕丅丑 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.丄与丈业丌业丕丅丑);
            this.丄与丈业丌业丕丅丑 = 0;
        }
        private void 丟且丌与且专万业丄(int 丈丘丝一丗下丈丐不)
        {
            UIPanel val_19;
            float val_20;
            float val_21;
            if(this._isMoveScrollOffsetComplete != false)
            {
                    return;
            }
            
            int val_2 = this._cellExample.Width;
            float val_21 = this._scrollPanel.width;
            if((int)val_21 == 0)
            {
                    return;
            }
            
            float val_19 = (float)this._cellExample.Width;
            val_19 = this._scrollPanel.width / val_19;
            if((int)val_19 > 丈丘丝一丗下丈丐不)
            {
                    return;
            }
            
            var val_20 = ~(int)val_19;
            val_20 = this.丘丑丆丗丝丙且丏世.Count + val_20;
            if(val_20 > 丈丘丝一丗下丈丐不)
            {
                    UnityEngine.Transform val_6 = this._scrollPanel.transform;
                UnityEngine.Vector3 val_7 = val_6.localPosition;
                val_21 = val_21 * 0.5f;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_6.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
                val_19 = this._scrollPanel;
                UnityEngine.Vector2 val_9 = val_19.clipOffset;
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_21, y:  0f);
                val_20 = val_9.x;
                val_21 = val_9.y;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_20, y = val_21}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            }
            else
            {
                    val_21 = (float)this._cellExample.Width - val_21;
                UnityEngine.Transform val_13 = this._scrollPanel.transform;
                UnityEngine.Vector3 val_14 = val_13.localPosition;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_13.localPosition = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                val_19 = this._scrollPanel;
                UnityEngine.Vector2 val_16 = val_19.clipOffset;
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_21, y:  0f);
                val_20 = val_16.x;
                val_21 = val_16.y;
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_20, y = val_21}, b:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            }
            
            val_19.clipOffset = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        }
        public TrophyRoadWindow()
        {
            this.丘丑丆丗丝丙且丏世 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.TrophyRoad.丈专世丅丞万丌东丗>();
            this.世丆不丏丁七丑丌丄 = 0;
            this.且上业丟丕一与三业 = new System.Collections.Generic.List<PGCompany.TrophyRoad.TrophyRoadCell>();
            this._delayTickAnimation = 0.01f;
        }
    
    }

}
