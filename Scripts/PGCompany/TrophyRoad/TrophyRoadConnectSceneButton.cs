using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal class TrophyRoadConnectSceneButton : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _body;
        private PGCompany.ProgressBarView _progressBar;
        
        // Methods
        private void OnEnable()
        {
            this.丝一丅丆三东丂丞七();
            PGCompany.TrophyRoad.与丂三专且丅万世一.专下丌上业丒不丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadConnectSceneButton::丝一丅丆三东丂丞七()));
        }
        private void OnDisable()
        {
            PGCompany.TrophyRoad.与丂三专且丅万世一.丌三丛与万丙且丆且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadConnectSceneButton::丝一丅丆三东丂丞七()));
        }
        private void 丝一丅丆三东丂丞七()
        {
            if(this._progressBar == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  false);
        }
        public void U_Click()
        {
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  73, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        public TrophyRoadConnectSceneButton()
        {
        
        }
    
    }

}
