using UnityEngine;

namespace PGCompany
{
    internal class TaskBookMainUI : BannerWindow, 丑且丆万丏丝丘丙丟
    {
        // Fields
        internal static PGCompany.TaskBookMainUI 丄丘七三上丕世丞业;
        private static System.Action 不七丟丁丂丟一七一;
        private static System.Action 业丙丘丈七不下下丐;
        private static System.Action 丛丄业丘不丆丄三丞;
        private System.Collections.Generic.List<PGCompany.TaskBookTaskView> 一丛一丑业丂丙丄丝;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private PGCompany.TaskBookTaskView _taskViewExample;
        private UIGrid _grid;
        private UnityEngine.GameObject _notificationBG;
        private UILabel _emptyTasksLabel;
        private UILabel _emptyConfigLabel;
        
        // Properties
        internal static bool 下丐丙专丕丙丗万丕 { get; }
        
        // Methods
        internal static void 业丑且一丆丅丞丞丂(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.TaskBookMainUI.不七丟丁丂丟一七一, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.TaskBookMainUI.不七丟丁丂丟一七一 != 1152921505637945352);
        
        }
        internal static void 一丌丘一三丌丙不东(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.TaskBookMainUI.不七丟丁丂丟一七一, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.TaskBookMainUI.不七丟丁丂丟一七一 != 1152921505637945352);
        
        }
        internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.TaskBookMainUI.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.TaskBookMainUI.业丙丘丈七不下下丐 != 1152921505637945360);
        
        }
        internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.TaskBookMainUI.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.TaskBookMainUI.业丙丘丈七不下下丐 != 1152921505637945360);
        
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.TaskBookMainUI.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.TaskBookMainUI.丛丄业丘不丆丄三丞 != 1152921505637945368);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.TaskBookMainUI.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.TaskBookMainUI.丛丄业丘不丆丄三丞 != 1152921505637945368);
        
        }
        internal static bool 丛世丛与丌不丈丐丐()
        {
            if(PGCompany.TaskBookMainUI.丄丘七三上丕世丞业 == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = PGCompany.TaskBookMainUI.丄丘七三上丕世丞业.gameObject;
            if(val_2 != null)
            {
                    return val_2.activeInHierarchy;
            }
            
            return val_2.activeInHierarchy;
        }
        protected override void Awake()
        {
            PGCompany.TaskBookMainUI.丄丘七三上丕世丞业 = this;
        }
        private void 丝三与丈丞丆业世东(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
            if(万不且且丛丆东丒业.不业丙丒丂丞下丆丙() != 1)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_31;
            var val_33;
            if((Rilisoft.Singleton<PGCompany.TaskBookController>.Instance) == 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            PGCompany.TaskBookController val_3 = Rilisoft.Singleton<PGCompany.TaskBookController>.Instance;
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<PGCompany.世丐下丕专东丘丏且>(source:  val_3.丂一一三丅与丛下丝.Values);
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.TaskBookTaskView>(专下丐丒丈万丗丟丝:  this.一丛一丑业丂丙丄丝, 专丑业丁丗丏丌不丛:  this._taskViewExample.gameObject, 丈东丘丏与丌东东下:  this._grid.transform, 与业丄丂丂丆下上丞:  val_5.Count, 丏东下下一丗专下丏:  0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskViewExample, 丏业丟一东丂东丘丛:  false);
            val_31 = null;
            val_31 = null;
            if((TaskBookMainUI.<>c.<>9__15_0) == null)
            {
                goto label_15;
            }
            
            label_51:
            this.一丛一丑业丂丙丄丝.ForEach(action:  TaskBookMainUI.<>c.<>9__15_0);
            System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_9 = new System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>();
            System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且> val_10 = new System.Collections.Generic.List<PGCompany.世丐下丕专东丘丏且>();
            val_33 = 0;
            goto label_17;
            label_34:
            this.一丛一丑业丂丙丄丝.Item[0].业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  val_5.Item[0]);
            this.一丛一丑业丂丙丄丝.Item[0].丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.一丛一丑业丂丙丄丝.Item[0], 丏业丟一东丂东丘丛:  true);
            val_9.Add(item:  val_5.Item[0]);
            if(val_5.Item[0].不一丅丂上丁丈三下() != false)
            {
                    val_10.Add(item:  val_5.Item[0]);
            }
            
            val_33 = 1;
            label_17:
            if(val_33 < val_5.Count)
            {
                goto label_34;
            }
            
            if(PGCompany.TaskBookMainUI.不七丟丁丂丟一七一 != null)
            {
                    PGCompany.TaskBookMainUI.不七丟丁丂丟一七一.Invoke();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  168);
            PGCompany.世丆下不与丈丗丂丒.丂丂七三上丅丁三世(下上丐丆丝丟丝丒不:  67, 丑世丆丈丕丐与且丞:  val_9, 丝丏丛世丞一丞丐丒:  true);
            PGCompany.世丆下不与丈丗丂丒.丂丂七三上丅丁三世(下上丐丆丝丟丝丒不:  68, 丑世丆丈丕丐与且丞:  val_10, 丝丏丛世丞一丞丐丒:  false);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            PGCompany.TaskBookController val_23 = Rilisoft.Singleton<PGCompany.TaskBookController>.Instance;
            int val_24 = val_23.丕丛丅专万丁万东一.Count;
            bool val_27 = (val_5.Count == 0) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notificationBG, 丏业丟一东丂东丘丛:  val_27 | ((val_24 == 0) ? 1 : 0));
            val_27 = val_27 & ((val_24 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._emptyTasksLabel, 丏业丟一东丂东丘丛:  val_27);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._emptyConfigLabel, 丏业丟一东丂东丘丛:  (val_24 == 0) ? 1 : 0);
            this._grid.repositionNow = true;
            return;
            label_15:
            TaskBookMainUI.<>c.<>9__15_0 = new System.Action<PGCompany.TaskBookTaskView>(object:  TaskBookMainUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskBookMainUI.<>c::丛三丕丛世下丆丙丁(PGCompany.TaskBookTaskView 三丟东丕丄丄下下丑));
            if(this.一丛一丑业丂丙丄丝 != null)
            {
                goto label_51;
            }
            
            goto label_51;
        }
        public override void Show()
        {
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            this.Show();
            if(PGCompany.TaskBookMainUI.业丙丘丈七不下下丐 == null)
            {
                    return;
            }
            
            PGCompany.TaskBookMainUI.业丙丘丈七不下下丐.Invoke();
        }
        public override void HideSelf()
        {
            this.HideSelf();
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
            if(PGCompany.TaskBookMainUI.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.TaskBookMainUI.丛丄业丘不丆丄三丞.Invoke();
        }
        public void TurnOn()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return true;
        }
        public bool IsEnabledLobbyCamera()
        {
            return true;
        }
        public float GetDelayTurnOff()
        {
            return 0f;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Rilisoft.Singleton<PGCompany.TaskBookController>.Instance.东丆丞且丆丕东一一();
            this.丝一丅丆三东丂丞七();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.TaskBookMainUI::U_Hide()), 与且专丈不万东一万:  0);
            PGCompany.世丐下丕专东丘丏且.一丞世专与丙与丟上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.TaskBookMainUI::丝三与丈丞丆业世东(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            PGCompany.TaskBookController.上丅丛七丈丝上丌丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TaskBookMainUI::丝一丅丆三东丂丞七()));
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            PGCompany.世丐下丕专东丘丏且.丂丆不三东七世丕且(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void PGCompany.TaskBookMainUI::丝三与丈丞丆业世东(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)));
            PGCompany.TaskBookController.世世丙万且丁东一丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TaskBookMainUI::丝一丅丆三东丂丞七()));
        }
        public void U_Hide()
        {
            goto typeof(PGCompany.TaskBookMainUI).__il2cppRuntimeField_208;
        }
        protected override void OnDestroy()
        {
            PGCompany.TaskBookMainUI.丄丘七三上丕世丞业 = 0;
        }
        public TaskBookMainUI()
        {
            this.一丛一丑业丂丙丄丝 = new System.Collections.Generic.List<PGCompany.TaskBookTaskView>();
        }
    
    }

}
