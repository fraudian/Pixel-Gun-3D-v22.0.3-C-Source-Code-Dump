using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHMapView : GMHEntityView
    {
        // Fields
        private PGCompany.TimerUI timerUi;
        
        // Properties
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 一丘东丌丑且丏一丙 { get; }
        
        // Methods
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 丕丆丞丂业东与上丅()
        {
            var val_2 = 0;
            return (PGCompany.GameModeHub.万业世丙丗丌与不丆);
        }
        internal override void 丝一丅丆三东丂丞七()
        {
            if(true == 0)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
            PGCompany.GameModeHub.万业世丙丗丌与不丆 val_1 = this.丕丆丞丂业东与上丅();
            if(val_1.丌丛丒丏上业丟丞不 < 1)
            {
                goto label_3;
            }
            
            int val_3 = this.丕丆丞丂业东与上丅().丄专专丅七丝丛丙丝();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUi, 丏业丟一东丂东丘丛:  (val_3 > 0) ? 1 : 0);
            if(this.timerUi == null)
            {
                goto label_8;
            }
            
            this.timerUi.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_3, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            goto label_8;
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUi, 丏业丟一东丂东丘丛:  false);
            label_8:
            this.丗丈丆丕丈丂世丘丕();
        }
        private void 丗丈丆丕丈丂世丘丕()
        {
            if(this.丕丆丞丂业东与上丅() == null)
            {
                    return;
            }
            
            PGCompany.GameModeHub.万业世丙丗丌与不丆 val_2 = this.丕丆丞丂业东与上丅();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2.丝丏丘丁丝上丅丆下)) == true)
            {
                    return;
            }
            
            TagSystem.CompoundTagBehaviour val_4 = this.GetComponent<TagSystem.CompoundTagBehaviour>();
            PGCompany.GameModeHub.万业世丙丗丌与不丆 val_5 = this.丕丆丞丂业东与上丅();
            string val_7 = "ConnectSceneMapCellName" + val_5.丝丏丘丁丝上丅丆下.ToLowerInvariant();
            if(val_4 != 0)
            {
                    if((val_4.丐丂丒丅上与丂丗且().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  val_7)) == true)
            {
                    return;
            }
            
            }
            
            if(val_4 != 0)
            {
                    if((val_4.丐丂丒丅上与丂丗且().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  val_7)) == false)
            {
                goto label_19;
            }
            
            }
            
            if(val_4 != 0)
            {
                    return;
            }
            
            this = this.丅与丌专丟一丝业三().AddComponent<TagSystem.CompoundTagBehaviour>();
            if(this != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_19:
            label_25:
            val_4.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  val_7);
        }
        public GMHMapView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
