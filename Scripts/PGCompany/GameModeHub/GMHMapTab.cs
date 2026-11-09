using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHMapTab : GMHEntityTab
    {
        // Properties
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 一丘东丌丑且丏一丙 { get; }
        internal PGCompany.GameModeHub.GMHMapSelector 丁丐丆七丛丌不不与 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 丕丆丞丂业东与上丅()
        {
            var val_2 = 0;
            return (PGCompany.GameModeHub.万业世丙丗丌与不丆);
        }
        internal PGCompany.GameModeHub.GMHMapSelector 不丒万专丌丑与万丛()
        {
            var val_2;
            if(true != 0)
            {
                    var val_1 = (38161477 == null) ? true : 0;
                return (PGCompany.GameModeHub.GMHMapSelector)val_2;
            }
            
            val_2 = 0;
            return (PGCompany.GameModeHub.GMHMapSelector)val_2;
        }
        public override void OnClick()
        {
            if(true != 0)
            {
                    if((this.不丒万专丌丑与万丛() != null) && (val_1.业世丞丆丄丝丟丄三 != null))
            {
                    val_1.业世丞丆丄丝丟丄三.Invoke();
            }
            
            }
            
            if(((this.丕丆丞丂业东与上丅().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "locked")) != false) && (this.不丒万专丌丑与万丛() != 0))
            {
                    PGCompany.GameModeHub.GMHMapSelector val_6 = this.不丒万专丌丑与万丛();
                if(val_6.三与丕丏丟七不上丁 != null)
            {
                    val_6.三与丕丏丟七不上丁.Invoke(obj:  this.丕丆丞丂业东与上丅());
            }
            
            }
            
            this.OnClick();
        }
        public void ScrollToThis()
        {
            PGCompany.GameModeHub.GMHMapSelector val_1 = this.不丒万专丌丑与万丛();
            if(val_1 == null)
            {
                    return;
            }
            
            val_1.ScrollToSelected(丌丈丛上丅丑七丒且:  this.transform);
        }
        public GMHMapTab()
        {
            val_1 = new SelectableButton();
        }
    
    }

}
