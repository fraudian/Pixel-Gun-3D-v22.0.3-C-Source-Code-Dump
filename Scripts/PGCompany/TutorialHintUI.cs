using UnityEngine;

namespace PGCompany
{
    public sealed class TutorialHintUI : PGBehaviour
    {
        // Fields
        private UILabel _hintLabelHeader;
        private UILabel _hintLabelBody;
        private UIWidget _mainWidget;
        private UIPanel _mainPanel;
        private string 下丑不丌丆丕丌不丗;
        private string 丛且丙丈丕三丕一上;
        private UnityEngine.Transform 丘不丟丈三丈上七丆;
        private UnityEngine.Vector3 专一丌七专不一丘与;
        private string 丅七丁丐丑丐三上下;
        private static int 丞丌丏丕业丛丂世丑;
        
        // Properties
        internal static bool 丅业东万丌丕上丌丄 { get; }
        public UIWidget 丘丛丆与丞丘丂丑专 { get; }
        public UIPanel 丈且丙东丕丝七下丒 { get; }
        public string 不丌七丆丏丂丐万丂 { get; }
        public UnityEngine.Transform 丝丗七世东业三丒专 { get; }
        
        // Methods
        internal static bool 丈丐丞丐上丑且丕万()
        {
            return (bool)(PGCompany.TutorialHintUI.丞丌丏丕业丛丂世丑 > 0) ? 1 : 0;
        }
        public UIWidget get_MainWidget()
        {
            return (UIWidget)this._mainWidget;
        }
        public UIPanel get_MainPanel()
        {
            return (UIPanel)this._mainPanel;
        }
        public string get_UniqueId()
        {
            return (string)this.丅七丁丐丑丐三上下;
        }
        public UnityEngine.Transform get_AnchorTransform()
        {
            return (UnityEngine.Transform)this.丘不丟丈三丈上七丆;
        }
        internal void 丈且东丑丂且万丒丅(string 丌且丘业丒不丙丝上, string 丕专业丌与丆丑丐丕, UnityEngine.Transform 与东三丞三且丟七与, string 与一七丘丏与万丒七)
        {
            this.下丑不丌丆丕丌不丗 = 丌且丘业丒不丙丝上;
            this.丛且丙丈丕三丕一上 = 丕专业丌与丆丑丐丕;
            this.丘不丟丈三丈上七丆 = 与东三丞三且丟七与;
            UnityEngine.Vector3 val_1 = 与东三丞三且丟七与.localPosition;
            this.专一丌七专不一丘与 = val_1;
            mem[1152921556092865108] = val_1.y;
            mem[1152921556092865112] = val_1.z;
            this.丅七丁丐丑丐三上下 = 与一七丘丏与万丒七;
            this.专丗丏丁下丑丑丈专();
            this.丐丅丅万且丂下且丁();
        }
        private void Awake()
        {
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.TutorialHintUI::专丗丏丁下丑丑丈专()));
        }
        private void OnEnable()
        {
            int val_1 = PGCompany.TutorialHintUI.丞丌丏丕业丛丂世丑;
            val_1 = val_1 + 1;
            PGCompany.TutorialHintUI.丞丌丏丕业丛丂世丑 = val_1;
        }
        private void OnDisable()
        {
            PGCompany.TutorialHintUI.丞丌丏丕业丛丂世丑 = System.Math.Max(val1:  0, val2:  PGCompany.TutorialHintUI.丞丌丏丕业丛丂世丑 - 1);
        }
        private void OnDestroy()
        {
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.TutorialHintUI::专丗丏丁下丑丑丈专()));
        }
        private void 专丗丏丁下丑丑丈专()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._hintLabelHeader, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.下丑不丌丆丕丌不丗));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._hintLabelBody, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丛且丙丈丕三丕一上));
        }
        private void 丐丅丅万且丂下且丁()
        {
            if(this.丘不丟丈三丈上七丆 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.丘不丟丈三丈上七丆.localPosition;
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Transform val_4 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_5 = val_4.localPosition;
            UnityEngine.Vector3 val_6 = this.丈丌丗专丅丆上丆丁();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_4.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Transform val_8 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_9 = val_8.localPosition;
            UnityEngine.Vector3 val_10 = this.万丟与丄丐世丒丑丑();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_8.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        private UnityEngine.Vector3 丈丌丗专丅丆上丆丁()
        {
            null = null;
            PGCompany.TutorialHintUiSettings val_2 = UnityEngine.Resources.Load<PGCompany.TutorialHintUiSettings>(path:  System.IO.Path.Combine(path1:  PGCompany.丈丌上丑丌上丅七东.且专三丁丐世丞丅丕, path2:  "SO", path3:  this.丅七丁丐丑丐三上下));
            if(val_2 == 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if(val_2 != null)
            {
                    return new UnityEngine.Vector3() {x = val_2.offset};
            }
            
            return new UnityEngine.Vector3() {x = val_2.offset};
        }
        private UnityEngine.Vector3 万丟与丄丐世丒丑丑()
        {
            float val_16;
            float val_17;
            float val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            float val_26;
            float val_27;
            float val_28;
            var val_29;
            var val_30;
            float val_31;
            var val_32;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_16 = val_1.x;
            val_17 = val_1.y;
            val_18 = val_1.z;
            if(null <= 3)
            {
                    val_19 = 0;
            }
            
            if(null <= 3)
            {
                    val_20 = 0;
            }
            
            if(null == null)
            {
                    val_21 = 0;
            }
            
            if(null == null)
            {
                    val_22 = 0;
            }
            
            if((S11 - S12) <= 0f)
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.left;
            goto label_18;
            label_15:
            float val_4 = S13 - val_1.x;
            if(val_4 >= 0)
            {
                goto label_19;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.right;
            float val_14 = val_5.x;
            label_18:
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14, y = val_5.y, z = val_5.z}, d:  System.Math.Abs(val_4));
            val_26 = val_16;
            val_27 = val_17;
            val_28 = val_18;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_16 = val_7.x;
            val_17 = val_7.y;
            val_18 = val_7.z;
            label_19:
            if(null <= 2)
            {
                    val_29 = 0;
            }
            
            if(null <= 2)
            {
                    val_30 = 0;
            }
            
            if(null == null)
            {
                    val_32 = 0;
            }
            
            val_14 = val_14 - val_5.y;
            if(val_14 > 0f)
            {
                    UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
            }
            else
            {
                    float val_9 = val_5.z - val_7.x;
                if(val_9 >= 0)
            {
                    return new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18};
            }
            
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
                val_31 = val_10.y;
                val_26 = val_10.x;
                val_27 = val_31;
                val_28 = val_10.z;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28}, d:  System.Math.Abs(val_9));
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_16 = val_12.x;
            val_17 = val_12.y;
            val_18 = val_12.z;
            return new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18};
        }
        private void Update()
        {
            this.丐丅丅万且丂下且丁();
        }
        public TutorialHintUI()
        {
        
        }
    
    }

}
