using UnityEngine;

namespace PGCompany
{
    internal sealed class DebugLogWindow : BaseDebugWindow
    {
        // Fields
        internal PGCompany.LogFullInfoWindow fullInfoWindow;
        internal UIButton[] buttonsForSetActiveVisible;
        internal UISprite panel;
        internal UISprite connectionStatus;
        internal UISprite visibleButton;
        internal UIInput findInput;
        private PGCompany.DynamicStringWrapGrid _openWarLogGrid;
        private UIScrollView scrollView;
        private DynamicWrapScrollBar wrapScrollBar;
        private UnityEngine.GameObject 七三七世丑丕不东且;
        private UnityEngine.BoxCollider 且丙与丏下丅丐世丑;
        private int 专七丝三上上丒东丕;
        private float[] 丌丄三丘丞丙丞丆上;
        private string 丈丕丒与业下与万一;
        internal System.Collections.Generic.IList<string> 丈丌且三且专业丞丙;
        internal System.Collections.Generic.IList<string> 丞世丘丆丒业上丄不;
        internal System.Collections.Generic.List<丄三丗世三丝下丆丒> 丌丟丂一丌丐丌上一;
        internal System.Collections.Generic.List<丄三丗世三丝下丆丒> 丏丈丅上丂丈一万丒;
        private bool 丂万丄丐世世丏业丂;
        private bool 一丝上丑丟丑与三不;
        private bool 丅丏且丈下一丆丕丝;
        
        // Properties
        internal PGCompany.LogFullInfoWindow 丐丐上东一万世丈丕 { get; }
        
        // Methods
        internal PGCompany.LogFullInfoWindow 丐丏与且丂世丑下与()
        {
            UnityEngine.GameObject val_2 = 0;
            if(this.fullInfoWindow != 0)
            {
                    return (PGCompany.LogFullInfoWindow)this.fullInfoWindow;
            }
            
            if((DebugWindow.与专丐三丝丈丌丄万(丛丄业丕且丗下一万:  "NguiWindows/DebugWindow/FullInfoWindow", 丒专丟丞丌丐丑丕丄: out  val_2)) == false)
            {
                    return (PGCompany.LogFullInfoWindow)this.fullInfoWindow;
            }
            
            PGCompany.LogFullInfoWindow val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_2, parent:  this.transform).GetComponent<PGCompany.LogFullInfoWindow>();
            this.fullInfoWindow = val_6;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  false);
            return (PGCompany.LogFullInfoWindow)this.fullInfoWindow;
        }
        private void OnEnable()
        {
        
        }
        private void OnDisable()
        {
            UnityEngine.Object.Destroy(obj:  this.丐丏与且丂世丑下与().gameObject);
        }
        internal void 丒业丕丌一不丏丙世(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
        {
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.connectionStatus, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
        }
        internal void 丙丝丄丝丟万丈丘丁()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.connectionStatus, 丏业丟一东丂东丘丛:  (~this.connectionStatus.gameObject.activeSelf) & 1);
        }
        internal void 丑丞丝一万业不丑丈(丄三丗世三丝下丆丒 丄丙下丝丛丒七丂丘)
        {
        
        }
        public void Clear()
        {
        
        }
        public void Find()
        {
        
        }
        public void SetVisability()
        {
            this.不丑丝东上上与丗丂(丘丝丗上与且丞丐丝:  (~this.panel.gameObject.activeSelf) & 1);
        }
        private void 不丑丝东上上与丗丂(bool 丘丝丗上与且丞丐丝)
        {
            var val_7;
            UIButton[] val_12;
            var val_13;
            var val_14;
            val_7 = 1152921505284374528;
            丘丝丗上与且丞丐丝 = 丘丝丗上与且丞丐丝;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.panel, 丏业丟一东丂东丘丛:  丘丝丗上与且丞丐丝);
            if(this.panel.gameObject.activeSelf != false)
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.green;
            }
            else
            {
                    UnityEngine.Color val_4 = UnityEngine.Color.red;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.visibleButton, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            val_12 = this.buttonsForSetActiveVisible;
            if(this.buttonsForSetActiveVisible.Length == 0)
            {
                    return;
            }
            
            val_7 = 1152921504848912384;
            val_13 = 0;
            goto label_11;
            label_21:
            val_14 = 0;
            if(this.buttonsForSetActiveVisible[0] != 0)
            {
                    if(val_13 >= this.buttonsForSetActiveVisible.Length)
            {
                    val_14 = 0;
            }
            
                UIButton val_8 = this.buttonsForSetActiveVisible[0];
                bool val_6 = 丘丝丗上与且丞丐丝;
            }
            
            val_13 = 1;
            label_11:
            val_12 = this.buttonsForSetActiveVisible;
            if(val_13 < this.buttonsForSetActiveVisible.Length)
            {
                goto label_21;
            }
        
        }
        public void ExpandPanel()
        {
            int val_15;
            var val_16;
            float val_17;
            float val_18;
            val_15 = this.专七丝三上上丒东丕;
            if((val_15 + 1) > this.丌丄三丘丞丙丞丆上.Length)
            {
                    return;
            }
            
            float val_16 = (float)this.panel.height;
            val_16 = this.丌丄三丘丞丙丞丆上[this.专七丝三上上丒东丕] * val_16;
            int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_16);
            if(this.panel != null)
            {
                    val_16 = this.panel.height;
            }
            else
            {
                    val_16 = 0.height;
            }
            
            this.panel.height = val_16 + val_3;
            UnityEngine.Vector3 val_8 = this.panel.transform.localPosition;
            val_17 = (float)val_3;
            float val_17 = -0.5f;
            val_17 = val_17 * val_17;
            val_8.y = val_8.y + val_17;
            val_18 = val_8.y;
            this.panel.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_18, z = val_8.z};
            if(this.且丙与丏下丅丐世丑 != 0)
            {
                    UnityEngine.Vector3 val_11 = this.且丙与丏下丅丐世丑.size;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_17 = val_12.x;
                val_18 = val_12.z;
                this.且丙与丏下丅丐世丑.size = new UnityEngine.Vector3() {x = val_17, y = val_12.y, z = val_18};
            }
            
            val_15 = mem[val_13 != true ? this.丈丌且三且专业丞丙 : this.丞世丘丆丒业上丄不];
            val_15 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丕丒与业下与万一)) != true) ? this.丈丌且三且专业丞丙 : this.丞世丘丆丒业上丄不;
            this._openWarLogGrid.SetContent(三丏丑不业丏不丂丈:  val_15, 业丛丛世上丈丘丄东:  false);
            int val_18 = this.专七丝三上上丒东丕;
            this.一丝上丑丟丑与三不 = true;
            this.丅丏且丈下一丆丕丝 = true;
            val_18 = val_18 + 1;
            this.专七丝三上上丒东丕 = val_18;
            this.wrapScrollBar.丞丕丙上丄丄丆下丁();
        }
        public void CollapsePanel()
        {
            var val_14;
            float val_15;
            float val_16;
            int val_14 = this.专七丝三上上丒东丕;
            val_14 = val_14 - 1;
            if((val_14 & 2147483648) != 0)
            {
                    return;
            }
            
            this.专七丝三上上丒东丕 = val_14;
            float val_17 = (float)this.panel.height;
            float val_18 = 1f;
            val_17 = this.丌丄三丘丞丙丞丆上[this.专七丝三上上丒东丕] * val_17;
            val_18 = this.丌丄三丘丞丙丞丆上[this.专七丝三上上丒东丕] + val_18;
            val_17 = val_17 / val_18;
            int val_2 = UnityEngine.Mathf.RoundToInt(f:  val_17);
            if(this.panel != null)
            {
                    val_14 = this.panel.height;
            }
            else
            {
                    val_14 = 0.height;
            }
            
            this.panel.height = val_14 - val_2;
            UnityEngine.Vector3 val_7 = this.panel.transform.localPosition;
            val_15 = (float)val_2;
            float val_19 = 0.5f;
            val_19 = val_15 * val_19;
            val_7.y = val_19 + val_7.y;
            val_16 = val_7.y;
            this.panel.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_16, z = val_7.z};
            if(this.且丙与丏下丅丐世丑 != 0)
            {
                    UnityEngine.Vector3 val_10 = this.且丙与丏下丅丐世丑.size;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_15 = val_11.x;
                val_16 = val_11.z;
                this.且丙与丏下丅丐世丑.size = new UnityEngine.Vector3() {x = val_15, y = val_11.y, z = val_16};
            }
            
            this._openWarLogGrid.SetContent(三丏丑不业丏不丂丈:  ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丕丒与业下与万一)) != true) ? this.丈丌且三且专业丞丙 : this.丞世丘丆丒业上丄不, 业丛丛世上丈丘丄东:  false);
            this.一丝上丑丟丑与三不 = true;
            this.丅丏且丈下一丆丕丝 = false;
            this.wrapScrollBar.丞丕丙上丄丄丆下丁();
        }
        private void LateUpdate()
        {
            DynamicWrapScrollBar val_7;
            if(this.丂万丄丐世世丏业丂 != false)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                if(this.丈丌且三且专业丞丙.Count >= 1)
            {
                    this._openWarLogGrid.ScrollFromStart(丙业与丙丗丝不丈东:  this._openWarLogGrid.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  0), 且丈丌丅业丅下万三:  true);
                this._openWarLogGrid.丒丅业丈丒丗丆丆丁 = 0f;
                this.丂万丄丐世世丏业丂 = false;
            }
            
            }
            
            if(this.一丝上丑丟丑与三不 == false)
            {
                    return;
            }
            
            this.一丝上丑丟丑与三不 = false;
            if(this.丅丏且丈下一丆丕丝 == false)
            {
                goto label_10;
            }
            
            if(this.wrapScrollBar == 0)
            {
                    return;
            }
            
            if(this.wrapScrollBar.专丐丆丝丒世丁丛丗 == 0)
            {
                    return;
            }
            
            val_7 = this.wrapScrollBar;
            if(this.wrapScrollBar != null)
            {
                goto label_18;
            }
            
            val_7 = this.wrapScrollBar;
            if(val_7 == null)
            {
                goto label_19;
            }
            
            label_18:
            if(this.wrapScrollBar.七与且一业一丄丁丁 <= this.wrapScrollBar.专丐丆丝丒世丁丛丗.height)
            {
                goto label_21;
            }
            
            return;
            label_10:
            this.scrollView.Restrict();
            return;
            label_21:
            this._openWarLogGrid.ScrollFromStart(丙业与丙丗丝不丈东:  0f, 且丈丌丅业丅下万三:  false);
            return;
            label_19:
        }
        public void OpenFullInfoWindow(int 丞世不丒下上上丝丑)
        {
        
        }
        public DebugLogWindow()
        {
            this.丌丄三丘丞丙丞丆上 = new float[4] {4.600603E-41f, 4.600463E-41f, 8.82818E-44f, -4.284436E+08f};
            this.丈丕丒与业下与万一 = System.String.alignConst;
            this.丈丌且三且专业丞丙 = new System.Collections.Generic.List<System.String>();
            this.丞世丘丆丒业上丄不 = new System.Collections.Generic.List<System.String>();
            this.丌丟丂一丌丐丌上一 = new System.Collections.Generic.List<丄三丗世三丝下丆丒>();
            this.丏丈丅上丂丈一万丒 = new System.Collections.Generic.List<丄三丗世三丝下丆丒>();
        }
    
    }

}
