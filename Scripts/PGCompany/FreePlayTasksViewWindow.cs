using UnityEngine;

namespace PGCompany
{
    public class FreePlayTasksViewWindow : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject buttonDisabledChangeTasks;
        public UnityEngine.GameObject taskWindowButton;
        public UnityEngine.GameObject taskWindow;
        public UnityEngine.GameObject alert;
        public string swapCountKey;
        public string swapDelayKey;
        public UnityEngine.GameObject _disabledStateRefreshButton;
        public UILabel _refreshTimer;
        public UILabel _refreshCount;
        internal System.Collections.Generic.List<PGCompany.FreePlayTasksViewWindow.VisualGameTask> taskViews;
        private int _alertProgrssStepDrive;
        private int _alertProgrssStepWalk;
        private int _alertProgrssStepKill;
        internal float delayBtwShowNext;
        internal float delayBeforeRerollShow;
        internal float delayAfterDone;
        private System.Collections.Generic.List<TapOnThisWidgetCheckUI> tapWidgetChecks;
        private DialogWindowController _refreshDialog;
        private SimpleTweenePlayer _refreshTasksTweenPlayer;
        internal bool 丂丂丞丒上丆丒丟丏;
        private bool 丕丐且不与丝专丑丘;
        private System.Collections.Generic.List<string> 丘丘丏丘世丝丒丏下;
        private bool 不丛东专不一丘专丈;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        public bool 下万三专丝丐丏一东 { get; }
        public bool 丛上丆丑丛丈丂业丙 { get; }
        
        // Methods
        public bool get_WindowEnabled()
        {
            if(this.taskWindow == 0)
            {
                    return false;
            }
            
            if(this.taskWindow != null)
            {
                    return this.taskWindow.activeInHierarchy;
            }
            
            return this.taskWindow.activeInHierarchy;
        }
        public bool get_TasksIsActive()
        {
            return (bool)this.不丛东专不一丘专丈;
        }
        private void OnEnable()
        {
            if(GameConnect.丝丆世丕丂丄万东且() == false)
            {
                goto label_5;
            }
            
            FreePlayTaskController val_2 = Rilisoft.Singleton<FreePlayTaskController>.Instance;
            if(val_2.三不专丗七丄且丝业 == false)
            {
                goto label_5;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.alert, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskWindow, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._refreshDialog, 丏业丟一东丂东丘丛:  false);
            DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            string val_4 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "game-task-by-ui-order", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_16;
            label_5:
            this.gameObject.SetActive(value:  false);
            return;
            label_16:
            if(val_3 == null)
            {
                goto label_18;
            }
            
            label_21:
            this.丘丘丏丘世丝丒丏下 = val_3;
            FreePlayTaskController.丈丘与丝丐一丁丁与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::业丕世七丝与丛业丛(PGCompany.世丐下丕专东丘丏且 上丁丒七不丗丁与且)));
            PGCompany.世丐下丕专东丘丏且.一丞世专与丙与丟上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::丄丕业业丂丕上丗丈(PGCompany.世丐下丕专东丘丏且 万且万且丑丗且丌丆)));
            FreePlayTaskController.万丘三丌丞丕丏专丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::与下与七丕一七丟丁()));
            this.丐一且下万万业下七();
            return;
            label_18:
            System.Collections.Generic.List<System.String> val_10 = new System.Collections.Generic.List<System.String>();
            if(this != null)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        private void OnDisable()
        {
            FreePlayTaskController.丏丛与丌且一世丄丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::业丕世七丝与丛业丛(PGCompany.世丐下丕专东丘丏且 上丁丒七不丗丁与且)));
            PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::丄丕业业丂丕上丗丈(PGCompany.世丐下丕专东丘丏且 万且万且丑丗且丌丆)));
            FreePlayTaskController.下丗专七万丈三丆不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::与下与七丕一七丟丁()));
        }
        private void 丄丕业业丂丕上丗丈(PGCompany.世丐下丕专东丘丏且 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆.不业丙丒丂丞下丆丙() != 6)
            {
                    return;
            }
            
            bool val_2 = this.丁丑丙丘丂丆丗丙三(三东丏丐丟三丕丈上:  万且万且丑丗且丌丆);
            if(val_2 != false)
            {
                    return;
            }
            
            val_2.丟丟丁万一万丈专丟(万不且且丛丆东丒业:  万且万且丑丗且丌丆);
        }
        private void 丟丟丁万一万丈专丟(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
            InfoWindowController.上丁丐丆丗丐与业丗(三东丏丐丟三丕丈上:  万不且且丛丆东丒业);
        }
        private void Update()
        {
            bool val_16;
            UnityEngine.GameObject val_17;
            if((InGameGUI.丙丞专丌丁丞与不丐 != 0) && (InGameGUI.丙丞专丌丁丞与不丐.专丐万丆丑三上丘七 != 0))
            {
                    if(isWorldMapOpened != false)
            {
                    val_16 = 0;
            }
            else
            {
                    val_16 = (~this.WindowEnabled) & 1;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskWindowButton, 丏业丟一东丂东丘丛:  val_16);
            }
            
            if((Rilisoft.Singleton<FreePlayTaskController>.Instance.与一丝丈丐丗三一丆()) > 0)
            {
                goto label_15;
            }
            
            val_17 = this;
            if(this.buttonDisabledChangeTasks.activeSelf == false)
            {
                goto label_17;
            }
            
            label_15:
            if(this.丕丐且不与丝专丑丘 == false)
            {
                goto label_18;
            }
            
            val_17 = this.buttonDisabledChangeTasks;
            label_17:
            label_35:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  mem[this.buttonDisabledChangeTasks], 丏业丟一东丂东丘丛:  true);
            label_32:
            if((this.taskWindow.activeSelf == true) || (this.丐丆七且丞丏下三丙 == null))
            {
                goto label_23;
            }
            
            this.丂丂丞丒上丆丒丟丏 = false;
            UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this.丗七与丛专丟丏丂丏(世专与丝丅丁丞下丞:  false));
            var val_15 = 0;
            val_15 = val_15 + 1;
            goto label_28;
            label_18:
            if(((Rilisoft.Singleton<FreePlayTaskController>.Instance.与一丝丈丐丗三一丆()) < 1) || (this.buttonDisabledChangeTasks.activeSelf == false))
            {
                goto label_32;
            }
            
            goto label_35;
            label_28:
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
            label_23:
            this.上丈与丁上丕丕丑专();
        }
        private void 业丕世七丝与丛业丛(PGCompany.世丐下丕专东丘丏且 上丁丒七不丗丁与且)
        {
            .上丁丒七不丗丁与且 = 上丁丒七不丗丁与且;
            if(this.WindowEnabled == false)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.FirstOrDefault<VisualGameTask>(source:  this.taskViews, predicate:  new System.Func<VisualGameTask, System.Boolean>(object:  new FreePlayTasksViewWindow.丂丄丕业东丆丄三三(), method:  System.Boolean FreePlayTasksViewWindow.丂丄丕业东丆丄三三::丕丝一丏丅东丂世一(PGCompany.FreePlayTasksViewWindow.VisualGameTask 三丟东丕丄丄下下丑)))) == null)
            {
                    return;
            }
            
            val_4.taskView.丄三丙丄丞东丕丒丝(万不且且丛丆东丒业:  (FreePlayTasksViewWindow.丂丄丕业东丆丄三三)[1152921555313540496].上丁丒七不丗丁与且);
            InfoWindowController.上与上丒丕丌丕丑丗(三东丏丐丟三丕丈上:  (FreePlayTasksViewWindow.丂丄丕业东丆丄三三)[1152921555313540496].上丁丒七不丗丁与且);
        }
        private void 上丈与丁上丕丕丑专()
        {
            string val_13;
            System.TimeSpan val_14;
            string val_15;
            UILabel val_16;
            var val_17;
            if((Rilisoft.Singleton<FreePlayTaskController>.Instance.与一丝丈丐丗三一丆()) > 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._disabledStateRefreshButton, 丏业丟一东丂东丘丛:  false);
                val_13 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.swapCountKey);
                val_14 = Rilisoft.Singleton<FreePlayTaskController>.Instance;
                val_15 = System.String.Format(format:  val_13, arg0:  val_14.与一丝丈丐丗三一丆());
                val_16 = this._refreshCount;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._disabledStateRefreshButton, 丏业丟一东丂东丘丛:  true);
                System.TimeSpan val_8 = Rilisoft.Singleton<FreePlayTaskController>.Instance.丑上万专丈且丟丅丁();
                if(val_8._ticks.TotalSeconds < 0)
            {
                    val_17 = null;
                val_17 = null;
            }
            
                val_14 = System.TimeSpan.Zero;
                val_13 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.swapDelayKey), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_14}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
                val_16 = this._refreshTimer;
                val_15 = val_13;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_16, 丕丗丘丑丛与丑业丒:  val_15);
        }
        internal void 丐一且下万万业下七()
        {
            var val_16;
            PGCompany.FreePlayTaskInstanceView val_20;
            var val_21;
            System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_23;
            var val_24;
            System.Func<PGCompany.世丐下丕专东丘丏且, System.String> val_26;
            var val_27;
            string val_29;
            val_20 = 1152921505591455744;
            val_21 = null;
            val_21 = null;
            val_23 = FreePlayTasksViewWindow.<>c.<>9__35_0;
            if(val_23 == null)
            {
                    System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32> val_4 = null;
                val_23 = val_4;
                val_4 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Int32>(object:  FreePlayTasksViewWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreePlayTasksViewWindow.<>c::万丈丌万不丄丑丙丆(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
                FreePlayTasksViewWindow.<>c.<>9__35_0 = val_23;
            }
            
            System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.OrderBy<PGCompany.世丐下丕专东丘丏且, System.Int32>(source:  System.Linq.Enumerable.Take<PGCompany.世丐下丕专东丘丏且>(source:  Rilisoft.Singleton<FreePlayTaskController>.Instance.不丆丘不丑业下丗与(), count:  4), keySelector:  val_4));
            System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_7 = val_6.专丁与世丐丙不不丝(丈丆专丂丂东上丛丞:  val_6, 三丌东丝业丝与丑丙:  this.丘丘丏丘世丝丒丏下);
            val_24 = null;
            val_24 = null;
            val_26 = FreePlayTasksViewWindow.<>c.<>9__35_1;
            if(val_26 == null)
            {
                    System.Func<PGCompany.世丐下丕专东丘丏且, System.String> val_8 = null;
                val_26 = val_8;
                val_8 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.String>(object:  FreePlayTasksViewWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.String FreePlayTasksViewWindow.<>c::丌丑丘丈丑丛下丅上(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
                FreePlayTasksViewWindow.<>c.<>9__35_1 = val_26;
            }
            
            val_27 = public static System.Collections.Generic.IEnumerable<TResult> System.Linq.Enumerable::Select<PGCompany.世丐下丕专东丘丏且, System.String>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TResult> selector);
            this.丘丘丏丘世丝丒丏下 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<PGCompany.世丐下丕专东丘丏且, System.String>(source:  val_7, selector:  val_8));
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_27 = 0;
            val_29 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丘丘丏丘世丝丒丏下);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "game-task-by-ui-order", 下下丏一丙不丘丌丞:  val_29);
            List.Enumerator<T> val_14 = val_7.GetEnumerator();
            goto label_29;
            label_31:
            val_29 = val_16.丐丏七丌丕丗业且上();
            if(0 >= this.taskViews.Count)
            {
                goto label_24;
            }
            
            if(this.taskViews.Item[0] != null)
            {
                    val_20 = val_19.taskView;
                if(val_20 != 0)
            {
                    val_20 = val_19.taskView;
                val_19.gameTask = val_29;
                val_19.taskView.丒东丙下丏丅且丏且 = this;
                val_19.taskView.<丅丝丌丝丁丏丙东丞>k__BackingField = val_29;
                val_20.丝一丅丆三东丂丞七(万不且且丛丆东丒业:  val_29);
            }
            
            }
            
            label_29:
            if(((-832505792) & 1) != 0)
            {
                goto label_31;
            }
            
            label_24:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丕丐且不与丝专丑丘 = false;
        }
        private System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 专丁与世丐丙不不丝(System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> 丈丆专丂丂东上丛丞, System.Collections.Generic.List<string> 三丌东丝业丝与丑丙)
        {
            System.Collections.Generic.List<System.String> val_24;
            System.Collections.Generic.IEnumerable<TSource> val_25;
            var val_26;
            var val_27;
            int val_28;
            var val_29;
            int val_30;
            PGCompany.世丐下丕专东丘丏且 val_31;
            var val_32;
            System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_33;
            var val_34;
            System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_36;
            var val_37;
            var val_38;
            var val_39;
            val_24 = 三丌东丝业丝与丑丙;
            val_25 = 丈丆专丂丂东上丛丞;
            FreePlayTasksViewWindow.且且丛丌丝三丏丙丛 val_1 = new FreePlayTasksViewWindow.且且丛丌丝三丏丙丛();
            .三丌东丝业丝与丑丙 = val_24;
            if(val_25 == null)
            {
                    return val_25;
            }
            
            if(val_24 == null)
            {
                    return val_25;
            }
            
            val_24 = val_25.Count;
            val_26 = 1152921516934571616;
            if(val_24 != (FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].三丌东丝业丝与丑丙.Count)
            {
                    return val_25;
            }
            
            .不一万丟丂丟丙三丙 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.Repeat<PGCompany.世丐下丕专东丘丏且>(element:  0, count:  (FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].三丌东丝业丝与丑丙.Count));
            FreePlayTasksViewWindow.丂下丌丝且不世丌与 val_7 = new FreePlayTasksViewWindow.丂下丌丝且不世丌与();
            if(val_7 != null)
            {
                    val_27 = val_7;
                .东丟且丗且三专丙丁 = val_1;
            }
            else
            {
                    val_27 = 24;
                mem[24] = val_1;
            }
            
            val_28 = 0;
            goto label_9;
            label_17:
            if((val_25.Exists(match:  new System.Predicate<PGCompany.世丐下丕专东丘丏且>(object:  val_7, method:  System.Boolean FreePlayTasksViewWindow.丂下丌丝且不世丌与::世丆丆丈丟丑丐丈丞(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)))) != false)
            {
                    val_29 = 1152921555314179952;
                val_30 = (FreePlayTasksViewWindow.丂下丌丝且不世丌与)[1152921555314313776].七丞丙丒三丕且丌丟;
                val_31 = val_25.Find(match:  new System.Predicate<PGCompany.世丐下丕专东丘丏且>(object:  val_7, method:  System.Boolean FreePlayTasksViewWindow.丂下丌丝且不世丌与::业丑专七与丂一上丐(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)));
            }
            else
            {
                    val_29 = 1152921555314179952;
                val_30 = (FreePlayTasksViewWindow.丂下丌丝且不世丌与)[1152921555314313776].七丞丙丒三丕且丌丟;
                val_31 = 0;
            }
            
            .不一万丟丂丟丙三丙.set_Item(index:  val_30, value:  val_31);
            val_28 = (FreePlayTasksViewWindow.丂下丌丝且不世丌与)[1152921555314313776].七丞丙丒三丕且丌丟 + 1;
            label_9:
            .七丞丙丒三丕且丌丟 = val_28;
            if(val_28 < .三丌东丝业丝与丑丙.Count)
            {
                goto label_17;
            }
            
            val_32 = 1152921504616005632;
            val_24 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  System.Linq.Enumerable.Where<PGCompany.世丐下丕专东丘丏且>(source:  val_25, predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_1, method:  System.Boolean FreePlayTasksViewWindow.且且丛丌丝三丏丙丛::丙三丗丁丏丒丈且一(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑))));
            val_26 = 1152921505591455744;
            val_33 = (FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].不一万丟丂丟丙三丙;
            val_34 = null;
            val_34 = null;
            val_36 = FreePlayTasksViewWindow.<>c.<>9__36_1;
            if(val_36 == null)
            {
                    val_37 = val_32;
                System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean> val_17 = null;
                val_36 = val_17;
                val_17 = new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  FreePlayTasksViewWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreePlayTasksViewWindow.<>c::丞三丒丒七丌丞丂丄(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑));
                FreePlayTasksViewWindow.<>c.<>9__36_1 = val_36;
            }
            
            if(val_24.Count != (System.Linq.Enumerable.Count<PGCompany.世丐下丕专东丘丏且>(source:  val_33, predicate:  val_17)))
            {
                    return val_25;
            }
            
            val_32 = 1152921537275250912;
            val_38 = 0;
            goto label_27;
            label_36:
            val_39 = 0;
            goto label_28;
            label_32:
            val_39 = 1;
            label_28:
            val_33 = (FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].不一万丟丂丟丙三丙;
            if(val_39 >= val_33.Count)
            {
                goto label_30;
            }
            
            if((FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].不一万丟丂丟丙三丙.Item[1] != null)
            {
                goto label_32;
            }
            
            val_33 = (FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].不一万丟丂丟丙三丙;
            val_33.set_Item(index:  1, value:  val_24.Item[0]);
            label_30:
            val_38 = 1;
            label_27:
            if(val_38 < val_24.Count)
            {
                goto label_36;
            }
            
            val_25 = (FreePlayTasksViewWindow.且且丛丌丝三丏丙丛)[1152921555314293296].不一万丟丂丟丙三丙;
            return val_25;
        }
        public void U_ClickSwapTasks()
        {
            if(this.丕丐且不与丝专丑丘 != false)
            {
                    return;
            }
            
            if((((Rilisoft.Singleton<FreePlayTaskController>.Instance.与一丝丈丐丗三一丆()) - 1) & 2147483648) != 0)
            {
                    return;
            }
            
            this._refreshDialog.add_OnOkAction(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::七丘丗丑丗业丗下不()));
        }
        private void 与下与七丕一七丟丁()
        {
            this._refreshTasksTweenPlayer.Play();
            this.丐一且下万万业下七();
        }
        public void U_ToggleVisibleWindow()
        {
            var val_10;
            System.Action val_19 = this.WindowEnabled;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskWindow, 丏业丟一东丂东丘丛:  (~val_19) & 1);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丗七与丛专丟丏丂丏(世专与丝丅丁丞下丞:  this.WindowEnabled));
            if(this.WindowEnabled == false)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_8 = this.taskViews.GetEnumerator();
            goto label_5;
            label_7:
            string val_11 = val_10.丐丏七丌丕丗业且上();
            mem2[0] = 0;
            label_5:
            if(((-831695088) & 1) != 0)
            {
                goto label_7;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_17;
            label_3:
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
            return;
            label_17:
            this.丐一且下万万业下七();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  85);
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            System.Action val_16 = null;
            val_19 = val_16;
            val_16 = new System.Action(object:  this, method:  System.Void PGCompany.FreePlayTasksViewWindow::丝东丐丝东三丈世丝());
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_16, 与且专丈不万东一万:  "FreePlayTasksWindow");
            this.丂丂丞丒上丆丒丟丏 = true;
        }
        private System.Collections.IEnumerator 丗七与丛专丟丏丂丏(bool 世专与丝丅丁丞下丞)
        {
            FreePlayTasksViewWindow.丛丕丒与丁丞不专丄 val_1 = new FreePlayTasksViewWindow.丛丕丒与丁丞不专丄();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .世专与丝丅丁丞下丞 = 世专与丝丅丁丞下丞;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丝东丐丝东三丈世丝()
        {
            this.丂丂丞丒上丆丒丟丏 = false;
            this.U_ToggleVisibleWindow();
        }
        private bool 丁丑丙丘丂丆丗丙三(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上)
        {
            int val_5;
            PGCompany.丒丘且上丟专东不丐 val_5 = val_2.Type;
            if(val_5 <= 87)
            {
                goto label_3;
            }
            
            if(val_5 == 102)
            {
                goto label_8;
            }
            
            if(val_5 == 109)
            {
                goto label_5;
            }
            
            val_5 = val_5 & 4294967294;
            if(val_5 != 110)
            {
                    return false;
            }
            
            val_5 = this._alertProgrssStepWalk;
            return 三东丏丐丟三丕丈上.世丈丁业丛上丘丗丐().万丆丄上七丒专且世().丁丑丙丘丂丆丗丙三(三东丏丐丟三丕丈上:  三东丏丐丟三丕丈上, 丂丛丁丄丕且丘丘丁:  val_5 = this._alertProgrssStepDrive);
            label_3:
            if((val_5 - 43) >= 3)
            {
                    if((val_5 - 21) >= 2)
            {
                goto label_9;
            }
            
            }
            
            label_8:
            val_5 = this._alertProgrssStepKill;
            return 三东丏丐丟三丕丈上.世丈丁业丛上丘丗丐().万丆丄上七丒专且世().丁丑丙丘丂丆丗丙三(三东丏丐丟三丕丈上:  三东丏丐丟三丕丈上, 丂丛丁丄丕且丘丘丁:  val_5);
            label_9:
            if(val_5 != 87)
            {
                    return false;
            }
            
            label_5:
            return 三东丏丐丟三丕丈上.世丈丁业丛上丘丗丐().万丆丄上七丒专且世().丁丑丙丘丂丆丗丙三(三东丏丐丟三丕丈上:  三东丏丐丟三丕丈上, 丂丛丁丄丕且丘丘丁:  val_5);
        }
        private bool 丁丑丙丘丂丆丗丙三(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上, int 丂丛丁丄丕且丘丘丁)
        {
            var val_5 = 0;
            if(丂丛丁丄丕且丘丘丁 == 0)
            {
                    return (bool)(val_3 != 0) ? 1 : 0;
            }
            
            if(三东丏丐丟三丕丈上.丞专丅丁丁三丄上专() == true)
            {
                    return (bool)(val_3 != 0) ? 1 : 0;
            }
            
            int val_2 = 三东丏丐丟三丕丈上.且丆丟业丞丕丑上且();
            int val_3 = val_2 / 丂丛丁丄丕且丘丘丁;
            val_3 = val_2 - (val_3 * 丂丛丁丄丕且丘丘丁);
            return (bool)(val_3 != 0) ? 1 : 0;
        }
        public bool CheckTapOnWidgets(UnityEngine.Vector3 丙一与世丈专丅三三)
        {
            System.Collections.Generic.List<TapOnThisWidgetCheckUI> val_4;
            var val_5;
            var val_4 = 0;
            label_5:
            val_4 = this.tapWidgetChecks;
            if(val_4 >= val_4.Count)
            {
                goto label_2;
            }
            
            val_4 = this.tapWidgetChecks.Item[0];
            val_4 = val_4 + 1;
            if((val_4.一丁且上丛丛丐下丛(一丁丂东丏丙上丟且:  new UnityEngine.Vector3() {x = 丙一与世丈专丅三三.x, y = 丙一与世丈专丅三三.y, z = 丙一与世丈专丅三三.z})) == false)
            {
                goto label_5;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_2:
            val_5 = 0;
            return (bool)val_5;
        }
        internal void 且丞丅丘七三万丐东(PGCompany.世丐下丕专东丘丏且 丈丅与与东丅下丞丛, PGCompany.FreePlayTaskInstanceView 丐丞丆东下业丙丛三)
        {
            Rilisoft.Singleton<FreePlayTaskController>.Instance.丞业丒丙丕不丟丕丝(万不且且丛丆东丒业:  丈丅与与东丅下丞丛);
            this.丐一且下万万业下七();
        }
        public FreePlayTasksViewWindow()
        {
            this.taskViews = new System.Collections.Generic.List<VisualGameTask>();
            this.delayBtwShowNext = 1f;
            this.delayBeforeRerollShow = 1f;
            this.delayAfterDone = 1f;
            this.tapWidgetChecks = new System.Collections.Generic.List<TapOnThisWidgetCheckUI>();
            this.丘丘丏丘世丝丒丏下 = new System.Collections.Generic.List<System.String>();
        }
        private void 七丘丗丑丗业丗下不()
        {
            this.丕丐且不与丝专丑丘 = true;
            Rilisoft.Singleton<FreePlayTaskController>.Instance.不丝一丛丁丛七与丈();
            Rilisoft.Singleton<FreePlayTaskController>.Instance.丑丌丙丝万七七丏七();
            this._refreshDialog.CloseWindow();
        }
    
    }

}
