using UnityEngine;

namespace PGCompany
{
    internal sealed class LogFullInfoWindow : PGBehaviour
    {
        // Fields
        internal UILabel logInfo;
        internal UILabel stackTrace;
        internal UIScrollView scrollView;
        internal UITable table;
        internal DebugToggleComponent toggleComponent;
        private bool 丌丘丒丝一七上丑丁;
        private 丄三丗世三丝下丆丒 东丐丂丐丘丟丏丂世;
        private 且东三东丑七专东不 丒世丅业丝东下与丗;
        
        // Methods
        public void Setup(丄三丗世三丝下丆丒 丑丁丒一丘丞业丗七)
        {
            string val_11;
            且东三东丑七专东不 val_12;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_11 = 丑丁丒一丘丞业丗七.丏万且专丑下东丞丑();
            if(val_11.Length >= 1001)
            {
                    val_11 = val_11.Substring(startIndex:  0, length:  232)(val_11.Substring(startIndex:  0, length:  232)) + " ...";
            }
            
            this.东丐丂丐丘丟丏丂世 = 丑丁丒一丘丞业丗七;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.logInfo, 丕丗丘丑丛与丑业丒:  val_11);
            val_12 = this.丒世丅业丝东下与丗;
            this.丌丘丒丝一七上丑丁 = false;
            if(val_12 != null)
            {
                goto label_11;
            }
            
            且东三东丑七专东不 val_6 = null;
            val_12 = val_6;
            val_6 = new 且东三东丑七专东不();
            this.丒世丅业丝东下与丗 = val_12;
            if(val_12 == null)
            {
                goto label_12;
            }
            
            label_11:
            .与专一业丏三丒万下 = false;
            DebugToggleComponent val_9 = this.toggleComponent.丈且东丑丂且万丒丅(专丝丟丒丐丈三丒世:  "StackTrace OFF", 丗丂不丂丕丛丆且丕:  "StackTrace ON", 丂丕且丈丁丈上丙丒:  new System.Action(object:  this, method:  public System.Void PGCompany.LogFullInfoWindow::SetVisibleStack()), 业东丏世丘丕丞东丞:  new System.Action(object:  this, method:  public System.Void PGCompany.LogFullInfoWindow::SetVisibleStack()), 丈东丘丏与丌东东下:  this.丒世丅业丝东下与丗, 丁世丛业丟下丕三丟:  this.scrollView, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}, 丗丅丙丏丝一七东丗:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.stackTrace, 丏业丟一东丂东丘丛:  false);
            var val_13 = 0;
            val_13 = val_13 + 1;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.stackTrace, 丕丗丘丑丛与丑业丒:  丑丁丒一丘丞业丗七.丒丑丆丕丕丐丛与丟());
            this.scrollView.ResetPosition();
            return;
            label_12:
        }
        public void Close()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void SetVisibleStack()
        {
            this.丌丘丒丝一七上丑丁 = this.丌丘丒丝一七上丑丁 ^ 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.stackTrace, 丏业丟一东丂东丘丛:  (this.丌丘丒丝一七上丑丁 == false) ? 1 : 0);
            var val_5 = 0;
            val_5 = val_5 + 1;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.stackTrace, 丕丗丘丑丛与丑业丒:  this.东丐丂丐丘丟丏丂世.丒丑丆丕丕丐丛与丟());
            this.scrollView.ResetPosition();
        }
        public void SaveToBuffer()
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            var val_7 = 0;
            val_7 = val_7 + 1;
            丗丏丑世丌丝丝上下.丒下一丟丝丕丈不一(丕丗丘丑丛与丑业丒:  this.东丐丂丐丘丟丏丂世.丏万且专丑下东丞丑() + "\n\n" + this.东丐丂丐丘丟丏丂世.丒丑丆丕丕丐丛与丟());
        }
        public LogFullInfoWindow()
        {
        
        }
    
    }

}
