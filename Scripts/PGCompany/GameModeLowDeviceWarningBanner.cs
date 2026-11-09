using UnityEngine;

namespace PGCompany
{
    internal class GameModeLowDeviceWarningBanner : BannerWindow
    {
        // Fields
        internal static System.Collections.Generic.HashSet<string> 丐丞丞丂丐业业丅且;
        internal static System.Collections.Generic.HashSet<string> 上丈世丂丘丑丗且丛;
        internal static bool 丕丂万与与丛丈丆丈;
        internal static bool 业上万不上丂不世万;
        private UILabel _messageLabel;
        private UILabel _bottomLabel;
        private UIToggle _notShowAgainToggle;
        private UnityEngine.GameObject _notShowAgainToggleGo;
        private UnityEngine.GameObject _buttonOkWarningType;
        private UnityEngine.GameObject _buttonOkBlockType;
        private UnityEngine.GameObject _buttonContinueWarningType;
        private System.IDisposable 东三世丝丒三一丈丛;
        private System.Threading.Tasks.TaskCompletionSource<bool> 丕与七专专丂世专丆;
        
        // Properties
        internal System.Threading.Tasks.Task 丙丁七丁七业业丈三 { get; }
        
        // Methods
        internal System.Threading.Tasks.Task 不丐丛丐丕丗一丅丟()
        {
            if(this.丕与七专专丂世专丆 != null)
            {
                    return this.丕与七专专丂世专丆.Task;
            }
            
            return this.丕与七专专丂世专丆.Task;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.东三世丝丒三一丈丛 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                this.东三世丝丒三一丈丛.Dispose();
            }
            
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.GameModeLowDeviceWarningBanner::U_JustClose()), 与且专丈不万东一万:  0);
            if(this.丕与七专专丂世专丆 != null)
            {
                    bool val_5 = this.丕与七专专丂世专丆.TrySetCanceled();
            }
            
            this.丕与七专专丂世专丆 = new System.Threading.Tasks.TaskCompletionSource<System.Boolean>();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.东三世丝丒三一丈丛 != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                this.东三世丝丒三一丈丛.Dispose();
            }
            
            if(this.丕与七专专丂世专丆 != null)
            {
                    bool val_2 = this.丕与七专专丂世专丆.TrySetCanceled();
            }
            
            this.丕与七专专丂世专丆 = 0;
        }
        public override void Show()
        {
            var val_2;
            this.Show();
            PGCompany.丆下丐丁丏世丈上丟 val_1 = this.丑丐丙丄丅世世丑丒();
            if(val_2 != 1)
            {
                    PGCompany.丆下丐丁丏世丈上丟 val_3 = this.丑丐丙丄丅世世丑丒();
                if(val_2 == 2)
            {
                    this.一丆丐七丐三丌丒丛();
                return;
            }
            
            }
            
            this.丏丏丒丟业世丌业丐();
            PGCompany.GameModeLowDeviceWarningBanner.丛业专丛与东丟业三();
        }
        private void 一丆丐七丐三丌丒丛()
        {
            string val_4;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10478"));
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
            {
                    val_4 = "Key_10476";
            }
            else
            {
                    val_4 = "Key_10477";
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._bottomLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonContinueWarningType, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonOkWarningType, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonOkBlockType, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notShowAgainToggleGo, 丏业丟一东丂东丘丛:  false);
        }
        private void 丏丏丒丟业世丌业丐()
        {
            string val_6;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._messageLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10475"));
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
            {
                    val_6 = "Key_10476";
            }
            else
            {
                    val_6 = "Key_10477";
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._bottomLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonContinueWarningType, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonOkWarningType, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonOkBlockType, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notShowAgainToggleGo, 丏业丟一东丂东丘丛:  (PGCompany.GameModeLowDeviceWarningBanner.丑丘丄一丆丛丝专丛() > 0) ? 1 : 0);
        }
        private static void 与世上丙丑丆丟丆丙()
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "GameModeLowDeviceWarningBanner-not-show-again", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private static int 丑丘丄一丆丛丝专丛()
        {
            return 丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "GameModeLowDeviceWarningBanner-warning-show-count", 丞丌丑丛上丕丙丕下:  0);
        }
        private static void 丛业专丛与东丟业三()
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "GameModeLowDeviceWarningBanner-warning-show-count", 下下丏一丙不丘丌丞:  PGCompany.GameModeLowDeviceWarningBanner.丑丘丄一丆丛丝专丛() + 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal static System.ValueTuple<bool, PGCompany.GameModeLowDeviceWarningBanner.丒三丝一上丙专丗丒> 丅丄且丐东且与丏丞(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒, bool 万丟丗丏专丆丌上三)
        {
            万丟丗丏专丆丌上三 = 万丟丗丏专丆丌上三;
            if((PGCompany.GameModeLowDeviceWarningBanner.东丟丁丄丛且丑丞丑(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 万丟丗丏专丆丌上三:  万丟丗丏专丆丌上三)) != false)
            {
                    return 0;
            }
            
            if((PGCompany.GameModeLowDeviceWarningBanner.一三丑与丛丁丘丆丏(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒)) == false)
            {
                    return 0;
            }
            
            return 0;
        }
        private static bool 东丟丁丄丛且丑丞丑(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒, bool 万丟丗丏专丆丌上三)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_13;
            var val_14;
            val_9 = 万丟丗丏专丆丌上三;
            if(PGCompany.GameModeLowDeviceWarningBanner.业上万不上丂不世万 == false)
            {
                goto label_21;
            }
            
            if(上且丗一丏丏万丅丌 != 31)
            {
                    if(上且丗一丏丏万丅丌 != 20)
            {
                goto label_21;
            }
            
            }
            
            val_10 = 0;
            if((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "GameModeLowDeviceWarningBanner-not-show-again", 丞丌丑丛上丕丙丕下:  0)) == 1)
            {
                    return (bool)val_10;
            }
            
            if(东下丌丝且七丛丘丒 != 0)
            {
                    var val_3 = (东下丌丝且七丛丘丒.sizeMap > 1) ? 1 : 0;
            }
            else
            {
                    val_11 = 0;
            }
            
            val_11 = val_11 | val_9;
            if(val_11 == false)
            {
                goto label_21;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
            {
                goto label_13;
            }
            
            string val_6 = UnityEngine.SystemInfo.deviceModel;
            if(val_9 == false)
            {
                goto label_14;
            }
            
            if(PGCompany.GameModeLowDeviceWarningBanner.上丈世丂丘丑丗且丛 == null)
            {
                goto label_15;
            }
            
            if((PGCompany.GameModeLowDeviceWarningBanner.上丈世丂丘丑丗且丛.Contains(item:  val_6)) == false)
            {
                goto label_16;
            }
            
            val_10 = 1;
            return (bool)val_10;
            label_13:
            val_9 = 1152921505171808256;
            val_13 = null;
            val_13 = null;
            var val_8 = (东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true) ? 1 : 0;
            return (bool)val_10;
            label_14:
            if(PGCompany.GameModeLowDeviceWarningBanner.上丈世丂丘丑丗且丛 != null)
            {
                    val_14 = public System.Boolean System.Collections.Generic.HashSet<System.String>::Contains(System.String item);
                return PGCompany.GameModeLowDeviceWarningBanner.__il2cppRuntimeField_static_fields.Contains(item:  val_6);
            }
            
            label_21:
            val_10 = 0;
            return (bool)val_10;
            label_16:
            label_15:
            if(PGCompany.GameModeLowDeviceWarningBanner.__il2cppRuntimeField_static_fields == null)
            {
                    return (bool)val_10;
            }
            
            val_14 = public System.Boolean System.Collections.Generic.HashSet<System.String>::Contains(System.String item);
            return PGCompany.GameModeLowDeviceWarningBanner.__il2cppRuntimeField_static_fields.Contains(item:  val_6);
        }
        private static bool 一三丑与丛丁丘丆丏(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒)
        {
            if(PGCompany.GameModeLowDeviceWarningBanner.业上万不上丂不世万 == false)
            {
                    return false;
            }
            
            if(上且丗一丏丏万丅丌 != 31)
            {
                    if(上且丗一丏丏万丅丌 != 20)
            {
                    return false;
            }
            
            }
            
            if(东下丌丝且七丛丘丒 == 0)
            {
                    return false;
            }
            
            if(东下丌丝且七丛丘丒.sizeMap < 2)
            {
                    return false;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
            {
                    return false;
            }
            
            if(PGCompany.GameModeLowDeviceWarningBanner.丐丞丞丂丐业业丅且 == null)
            {
                    return false;
            }
            
            return PGCompany.GameModeLowDeviceWarningBanner.丐丞丞丂丐业业丅且.Contains(item:  UnityEngine.SystemInfo.deviceModel);
        }
        public void U_JustClose()
        {
            if(this._notShowAgainToggle != 0)
            {
                    if(this._notShowAgainToggle.value != false)
            {
                    PGCompany.GameModeLowDeviceWarningBanner.与世上丙丑丆丟丆丙();
            }
            
            }
            
            this.HideSelf();
        }
        public void U_ContinueClose()
        {
            if(this.丕与七专专丂世专丆 != null)
            {
                    bool val_1 = this.丕与七专专丂世专丆.TrySetResult(result:  true);
            }
            
            if(this._notShowAgainToggle != 0)
            {
                    if(this._notShowAgainToggle.value != false)
            {
                    PGCompany.GameModeLowDeviceWarningBanner.与世上丙丑丆丟丆丙();
            }
            
            }
            
            this.HideSelf();
        }
        internal static System.Collections.IEnumerator 丒专丒丞东世上丏丑(System.Threading.Tasks.Task 丑专丙下丒丆万丕丄, System.Action 七丐丅专且专七三丆)
        {
            GameModeLowDeviceWarningBanner.丙丞业丅丕丗丞丗不 val_1 = new GameModeLowDeviceWarningBanner.丙丞业丅丕丗丞丗不();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丑专丙下丒丆万丕丄 = 丑专丙下丒丆万丕丄;
            }
            else
            {
                    mem[32] = 丑专丙下丒丆万丕丄;
            }
            
            .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
            return (System.Collections.IEnumerator)val_1;
        }
        internal static bool 七丑丆丏东业专丒万(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, SceneInfo 东下丌丝且七丛丘丒, bool 万丟丗丏专丆丌上三, System.Action 丏丒且丄三世丆丕上)
        {
            System.Action val_11;
            bool val_12;
            var val_13;
            val_11 = 丏丒且丄三世丆丕上;
            val_12 = 万丟丗丏专丆丌上三;
            System.ValueTuple<System.Boolean, 丒三丝一上丙专丗丒> val_2 = PGCompany.GameModeLowDeviceWarningBanner.丅丄且丐东且与丏丞(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 东下丌丝且七丛丘丒:  东下丌丝且七丛丘丒, 万丟丗丏专丆丌上三:  val_12);
            if((val_2.Item2 & 255) != 0)
            {
                    val_12 = val_2.Item2 >> 32;
                BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  87, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丙丁丑丙丆丐丂业丈 = val_12, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
                BannerWindow val_6 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
                if(val_6 != null)
            {
                    val_11 = PGCompany.GameModeLowDeviceWarningBanner.丒专丒丞东世上丏丑(丑专丙下丒丆万丕丄:  val_6.不丐丛丐丕丗一丅丟(), 七丐丅专且专七三丆:  val_11);
                UnityEngine.Coroutine val_9 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_11);
            }
            
                val_13 = 1;
                return (bool)val_13;
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        public GameModeLowDeviceWarningBanner()
        {
        
        }
    
    }

}
