using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHModeInfoUI : PGBehaviour
    {
        // Fields
        private PGCompany.GameModeHub.GMHCategoryView categoryView;
        private PGCompany.GameModeHub.GMHModeView modeView;
        private PGCompany.GameModeHub.GMHMapView mapView;
        private UILabel customModeDescription;
        private UnityEngine.Transform buttonInfoTransform;
        private PGCompany.GameModeHub.丟与丗不不上丆丞三 专丄丌且一丕万与丛;
        private PGCompany.GameModeHub.丗丙丈下上丞不丅丑 万七东专三不业丈丛;
        private PGCompany.GameModeHub.万业世丙丗丌与不丆 丛丝丁丗且丘丂与万;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂, PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丂丛丑东不丅丈一东, PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不)
        {
            this.专丄丌且一丕万与丛 = 七丆丒与丗丌丄且丂;
            this.万七东专三不业丈丛 = 丂丛丑东不丅丈一东;
            this.丛丝丁丗且丘丂与万 = 丞丁丑丏丄丏七丂不;
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_1;
            if(this.modeView != null)
            {
                    val_1 = System.Void PGCompany.GameModeHub.GMHEntityView::丈且东丑丂且万丒丅(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世);
                this.modeView.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  this.万七东专三不业丈丛);
            }
            
            if(this.mapView != null)
            {
                    this.mapView.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  this.丛丝丁丗且丘丂与万);
            }
            
            this.三丛不七且丈丝万丘();
        }
        private void 三丛不七且丈丝万丘()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.customModeDescription, 丕丗丘丑丛与丑业丒:  PGCompany.GameModeHub.丂丕且丟丌丐万东丗.且丌丐且业一丛丆丁(丂丛丑东不丅丈一东:  this.万七东专三不业丈丛, 丞丁丑丏丄丏七丂不:  this.丛丝丁丗且丘丂与万));
        }
        internal System.Nullable<UnityEngine.Vector3> 丑丘且业三不下与下()
        {
            if(this.buttonInfoTransform == null)
            {
                    return 0;
            }
            
            UnityEngine.Vector3 val_1 = this.buttonInfoTransform.position;
            return 0;
        }
        public void U_InfoPressed()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_InfoPressed");
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.ModeInfoRequest();
        }
        public void U_ChallengesPressed()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_ChallengesPressed");
            0.ModeChallengesRequest();
        }
        public GMHModeInfoUI()
        {
        
        }
    
    }

}
