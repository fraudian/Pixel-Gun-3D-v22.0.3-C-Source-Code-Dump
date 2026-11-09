using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHMapSelector : SelectableButtonController
    {
        // Fields
        internal System.Action 业世丞丆丄丝丟丄三;
        internal System.Action<PGCompany.GameModeHub.三丙专上下万七丛东> 三与丕丏丟七不上丁;
        private MiniPoolMonoBehaviour tabsPool;
        private ScrollViewHelper scrollHelper;
        private ScrollViewHelper scrollHelper2;
        private UIWidget container;
        private GridScrollHelper gridScrollHelper;
        private System.Collections.Generic.List<UIRect> rectsToUpdate;
        private PGCompany.GameModeHub.GMHModeView selectedModeView;
        private int defaultMapViewWidth;
        private UnityEngine.Transform mapViewsContainer;
        private System.Collections.Generic.List<PGCompany.GameModeHub.GMHMapTab> 业丄丌万与丗丙上丏;
        private System.Collections.Generic.List<PGCompany.GameModeHub.万业世丙丗丌与不丆> 上丝丅专上丌上丏东;
        private PGCompany.GameModeHub.丗丙丈下上丞不丅丑 万七东专三不业丈丛;
        private System.IDisposable 与丅世与丄丑丌丞东;
        private float offset;
        private ScrollHelper scrollHelperIvan;
        private UnityEngine.Transform 丞下万上三丘上与专;
        private UnityEngine.Transform rightPoint;
        private UnityEngine.Transform lefttPoint;
        
        // Properties
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 丑业业业丒丏丈丞下 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 丝丟丌丛丂七丗下东()
        {
            if(static_value_082C9000 == 0)
            {
                    return 0;
            }
            
            if(this == null)
            {
                    return 0.丕丆丞丂业东与上丅();
            }
            
            var val_2 = (null == null) ? (this) : 0;
            return 0.丕丆丞丂业东与上丅();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.与丅世与丄丑丌丞东 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMapSelector::丅一且丑丒丈丑丌丗()), 与且专丈不万东一万:  "GMHMapSelector_" + this.gameObject.name);
            UnityEngine.Coroutine val_8 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMapSelector::丝丕业丛万七丙丗丕()), 业丗七丕万万不丈丗:  1);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.与丅世与丄丑丌丞东 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.与丅世与丄丑丌丞东.Dispose();
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丂丛丑东不丅丈一东, PGCompany.GameModeHub.万业世丙丗丌与不丆 业七与业丄丏与东丂)
        {
            var val_14;
            PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_15;
            System.Collections.Generic.List<PGCompany.GameModeHub.GMHMapTab> val_16;
            IntPtr val_18;
            GMHMapSelector.业丂七丏丟丕丌丂世 val_1 = new GMHMapSelector.业丂七丏丟丕丌丂世();
            if(val_1 != null)
            {
                    val_14 = val_1;
                .业七与业丄丏与东丂 = 业七与业丄丏与东丂;
                val_15 = 1152921560495370512;
                mem[1152921560495370520] = 丂丛丑东不丅丈一东;
            }
            else
            {
                    val_14 = 16;
                mem[16] = 业七与业丄丏与东丂;
                val_15 = 24;
                mem[24] = 丂丛丑东不丅丈一东;
            }
            
            mem[1152921560495330376] = 0;
            this.万七东专三不业丈丛 = val_15;
            if(this.selectedModeView != null)
            {
                    this.selectedModeView.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  mem[24]);
            }
            
            this.上丝丅专上丌上丏东 = 丂丛丑东不丅丈一东 + 168;
            this.下不丅丕东丏丝丝丆();
            if((val_14 == 0) || ((this.业丄丌万与丗丙上丏.Exists(match:  new System.Predicate<PGCompany.GameModeHub.GMHMapTab>(object:  val_1, method:  System.Boolean GMHMapSelector.业丂七丏丟丕丌丂世::丆一且世上丗上一丗(PGCompany.GameModeHub.GMHMapTab 三丟东丕丄丄下下丑)))) == false))
            {
                goto label_10;
            }
            
            val_16 = this.业丄丌万与丗丙上丏;
            val_18 = 1152921560495247936;
            goto label_11;
            label_10:
            val_16 = mem[24];
            if((丂丛丑东不丅丈一东 + 176) == 0)
            {
                goto label_16;
            }
            
            val_16 = this.业丄丌万与丗丙上丏;
            if((val_16.Exists(match:  new System.Predicate<PGCompany.GameModeHub.GMHMapTab>(object:  val_1, method:  System.Boolean GMHMapSelector.业丂七丏丟丕丌丂世::丙丛上丏上丘丟丛丘(PGCompany.GameModeHub.GMHMapTab 三丟东丕丄丄下下丑)))) == false)
            {
                goto label_16;
            }
            
            val_16 = this.业丄丌万与丗丙上丏;
            System.Func<PGCompany.GameModeHub.GMHMapTab, System.Boolean> val_6 = null;
            val_18 = 1152921560495266368;
            label_11:
            val_6 = new System.Func<PGCompany.GameModeHub.GMHMapTab, System.Boolean>(object:  val_1, method:  val_18);
            System.Linq.Enumerable.First<PGCompany.GameModeHub.GMHMapTab>(source:  val_16, predicate:  val_6).Select(丛丁三七丅且丝丏丙:  true);
            goto label_18;
            label_16:
            this.下丁万万丅丆东不不();
            label_18:
            if(val_1 != 0)
            {
                    if(this.scrollHelper != null)
            {
                    this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  val_16.transform, 丌与丟丁万丝丞丄丏:  false);
            }
            
                if(this.gridScrollHelper != null)
            {
                    val_15 = this.container;
                val_16 = this.lefttPoint;
                this.gridScrollHelper.万丄下丈丏一不丑七(丞下万上三丘上与专:  val_16.transform, 丈丂丕下丏丈丞丗业:  val_16, 业与三万七丝不万东:  (float)val_15.width);
            }
            
            }
            
            UnityEngine.Coroutine val_13 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMapSelector::丝丕业丛万七丙丗丕()), 业丗七丕万万不丈丗:  1);
        }
        private void 下不丅丕东丏丝丝丆()
        {
            var val_6;
            System.Collections.Generic.List<PGCompany.GameModeHub.万业世丙丗丌与不丆> val_15;
            var val_17;
            var val_18;
            var val_19;
            this.世业丒万丘丆专丘丐();
            val_15 = 1152921504848912384;
            if(this.tabsPool != 0)
            {
                    if(this.tabsPool.example != 0)
            {
                goto label_39;
            }
            
            }
            
            val_15 = this.上丝丅专上丌上丏东;
            List.Enumerator<T> val_4 = val_15.GetEnumerator();
            val_17 = 1152921560452649040;
            val_18 = 1152921505704501248;
            label_23:
            if((54171280 & 1) == 0)
            {
                goto label_41;
            }
            
            string val_8 = "GameModeHub/MapViews/"("GameModeHub/MapViews/") + PGCompany.GameModeHub.丂丕且丟丌丐万东丗.与且丁丏丙业丁丐专(丑丅七丅一丈丘丞七:  this.万七东专三不业丈丛.丅不丗丂丑丈上丘丙)(PGCompany.GameModeHub.丂丕且丟丌丐万东丗.与且丁丏丙业丁丐专(丑丅七丅一丈丘丞七:  this.万七东专三不业丈丛.丅不丗丂丑丈上丘丙));
            PGCompany.GameModeHub.GMHMapTab val_9 = Get<PGCompany.GameModeHub.GMHMapTab>(丛丄业丕且丗下一万:  val_8);
            val_8.width = 164;
            val_8.ResetAndUpdateAnchors();
            this.业丄丌万与丗丙上丏.Add(item:  val_9);
            this.AddNewButton(丟丂丄丕下业丗丛丂:  val_9);
            val_9.transform.SetAsLastSibling();
            val_9.Reset();
            val_9.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  val_6.丐丏七丌丕丗业且上());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9, 丏业丟一东丂东丘丛:  true);
            goto label_23;
            label_39:
            List.Enumerator<T> val_11 = this.上丝丅专上丌上丏东.SyncRoot.GetEnumerator();
            val_17 = 1152921560495555632;
            val_18 = 1152921505284374528;
            label_49:
            if((54171280 & 1) == 0)
            {
                goto label_41;
            }
            
            PGCompany.GameModeHub.GMHMapTab val_13 = this.tabsPool.Get<PGCompany.GameModeHub.GMHMapTab>();
            this.业丄丌万与丗丙上丏.Add(item:  val_13);
            this.AddNewButton(丟丂丄丕下业丗丛丂:  val_13);
            val_13.transform.SetAsLastSibling();
            val_13.Reset();
            val_13.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  val_6.丐丏七丌丕丗业且上());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_13, 丏业丟一东丂东丘丛:  true);
            goto label_49;
            label_41:
            val_19 = public System.Void List.Enumerator<PGCompany.GameModeHub.万业世丙丗丌与不丆>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6.丁下丏丙一丗下丈七();
        }
        internal void 世业丒万丘丆专丘丐()
        {
            var val_5;
            System.Collections.Generic.List<PGCompany.GameModeHub.GMHMapTab> val_11;
            if(this.tabsPool != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.tabsPool.example, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this.scrollHelper != null)
            {
                    this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            }
            
            if((this.gridScrollHelper != null) && (this.gridScrollHelper.scrollHelper != null))
            {
                    this.gridScrollHelper.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            }
            
            if(this.rectsToUpdate != null)
            {
                    专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
            }
            
            if(this.tabsPool != 0)
            {
                    if(this.tabsPool.example != 0)
            {
                goto label_16;
            }
            
            }
            
            val_11 = this;
            List.Enumerator<T> val_3 = this.业丄丌万与丗丙上丏.GetEnumerator();
            label_24:
            if((54427680 & 1) == 0)
            {
                goto label_33;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            Return(丛丄业丕且丗下一万:  val_6.gameObject.name, 万且万且丑丗且丌丆:  val_6);
            goto label_24;
            label_16:
            val_11 = this.业丄丌万与丗丙上丏;
            List.Enumerator<T> val_9 = this.业丄丌万与丗丙上丏.SyncRoot.GetEnumerator();
            label_35:
            if((54427680 & 1) == 0)
            {
                goto label_33;
            }
            
            this.tabsPool.Return(万且万且丑丗且丌丆:  val_5.丐丏七丌丕丗业且上());
            goto label_35;
            label_33:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem[1152921560495861688] = 0;
            this.业丄丌万与丗丙上丏.Clear();
            this.业丄丌万与丗丙上丏.Clear();
            this.ClearLayout();
        }
        internal void 世丌丂专不七东丆丞()
        {
            if(this.业世丞丆丄丝丟丄三 == null)
            {
                    return;
            }
            
            this.业世丞丆丄丝丟丄三.Invoke();
        }
        private void 丝丕业丛万七丙丗丕()
        {
            var val_7 = 1152921504848912384;
            if(this == 0)
            {
                    return;
            }
            
            if(ConnectScene.丈丘丂丙不丛业丟三() == false)
            {
                    return;
            }
            
            if(this.scrollHelper != null)
            {
                    this.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            }
            
            if((this.gridScrollHelper != null) && (this.gridScrollHelper.scrollHelper != null))
            {
                    this.gridScrollHelper.scrollHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            }
            
            if(this.rectsToUpdate != null)
            {
                    专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
            }
            
            if(this.rectsToUpdate == 0)
            {
                    return;
            }
            
            if(this.scrollHelper != null)
            {
                    this.scrollHelper.ScrollTo(不七丘丘丒万七丄丒:  transform, 丌与丟丁万丝丞丄丏:  false);
            }
            
            if(this.gridScrollHelper == null)
            {
                    return;
            }
            
            this.gridScrollHelper.万丄下丈丏一不丑七(丞下万上三丘上与专:  transform, 丈丂丕下丏丈丞丗业:  this.lefttPoint, 业与三万七丝不万东:  (float)this.container.width);
        }
        internal void 丅一且丑丒丈丑丌丗()
        {
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.U_BackRequest();
        }
        public void ScrollToSelected(UnityEngine.Transform 丌丈丛上丅丑七丒且)
        {
            ScrollHelper val_7;
            丝丏七丘专丒丗丒丒 val_8;
            UnityEngine.Transform val_9;
            val_7 = this.scrollHelperIvan;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = this.container;
            if((丞东丑专丛丆丄丝世.丟不下下且业丛丄丏(丈丕丁丄上不上万丅:  val_7, 丒东万七丏丛丟丄与:  丌丈丛上丅丑七丒且.GetComponent<UIWidget>())) != false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = 丌丈丛上丅丑七丒且.position;
            UnityEngine.Vector3 val_6 = this.transform.position;
            if(val_4.x > val_6.x)
            {
                    val_8 = 2;
                val_9 = 丌丈丛上丅丑七丒且;
            }
            else
            {
                    val_9 = 丌丈丛上丅丑七丒且;
                val_8 = 0;
            }
            
            this.scrollHelperIvan.ScrollToObject(丌丟专且丞丁万丑丞:  val_9, 万丛丑且三万且东专:  val_8, 丛上丙丄丄七丈且丅:  this.offset);
        }
        private void Update()
        {
            if(this.rightPoint != 0)
            {
                    if(this.scrollHelper2 != 0)
            {
                    UIPanel val_3 = this.scrollHelper2.Panel;
                this.rightPoint.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
                UnityEngine.Vector3 val_4 = this.rightPoint.localPosition;
                this.rightPoint.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = 0f, z = val_4.z};
            }
            
            }
            
            if(this.lefttPoint == 0)
            {
                    return;
            }
            
            if(this.scrollHelper2 == 0)
            {
                    return;
            }
            
            UIPanel val_7 = this.scrollHelper2.Panel;
            this.lefttPoint.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.z, z = V10.16B};
            UnityEngine.Vector3 val_8 = this.lefttPoint.localPosition;
            this.lefttPoint.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = 0f, z = val_8.z};
        }
        public void SelectMap(int 丛且丞与丕业下丏丞)
        {
            .丛且丞与丕业下丏丞 = 丛且丞与丕业下丏丞;
            PGCompany.GameModeHub.GMHMapTab val_3 = System.Linq.Enumerable.FirstOrDefault<PGCompany.GameModeHub.GMHMapTab>(source:  this.业丄丌万与丗丙上丏, predicate:  new System.Func<PGCompany.GameModeHub.GMHMapTab, System.Boolean>(object:  new GMHMapSelector.且下七业七业一上丈(), method:  System.Boolean GMHMapSelector.且下七业七业一上丈::丆不丑丟丁丏丘丈上(PGCompany.GameModeHub.GMHMapTab 三丟东丕丄丄下下丑)));
            if(val_3 == 0)
            {
                    return;
            }
            
            val_3.Select(丛丁三七丅且丝丏丙:  true);
        }
        public GMHMapSelector()
        {
            this.defaultMapViewWidth = 0;
            this.业丄丌万与丗丙上丏 = new System.Collections.Generic.List<PGCompany.GameModeHub.GMHMapTab>();
            this.上丝丅专上丌上丏东 = new System.Collections.Generic.List<PGCompany.GameModeHub.万业世丙丗丌与不丆>();
        }
    
    }

}
