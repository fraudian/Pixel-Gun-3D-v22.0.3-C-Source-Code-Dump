using UnityEngine;

namespace PGCompany
{
    internal sealed class LogLabelEntryView : DynamicStringWrapGridItem
    {
        // Fields
        private UILabel _logEntryLabel;
        private Rilisoft.ButtonHandler handler;
        
        // Methods
        public override void UpdateContent(string 三丏丑不业丏不丂丈)
        {
            this.UpdateContent(三丏丑不业丏不丂丈:  三丏丑不业丏不丂丈);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._logEntryLabel, 丕丗丘丑丛与丑业丒:  三丏丑不业丏不丂丈);
            if(this.handler == 0)
            {
                    return;
            }
            
            this.handler.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.LogLabelEntryView::七专业七世上丝丗丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        public LogLabelEntryView()
        {
        
        }
        private void 七专业七世上丝丗丏(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(DebugConsole.Enabled != false)
            {
                    PGCompany.DebugLogWindow val_2 = LogController.丐三丅丂与且丈丈与();
            }
            
            DebugConsole.七上七下且三丙丌丆().OpenFullInfoWindow(丞世不丒下上上丝丑:  -874862528);
        }
    
    }

}
