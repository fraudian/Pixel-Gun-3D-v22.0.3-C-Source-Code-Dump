using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal sealed class TrophyRoadBanner : BannerWindowWithBack
    {
        // Fields
        private PGCompany.TrophyRoad.TrophyRoadWindow _trophyRoadWindow;
        
        // Methods
        public override void Show()
        {
            this.Show();
            if(this._trophyRoadWindow == 0)
            {
                    this.HideSelf();
                return;
            }
            
            this._trophyRoadWindow.下与丞三丅丛丄七丕(丝上丂一不专丂丄不:  new System.Action(object:  this, method:  public System.Void BannerWindow::HideSelf()));
        }
        public override void Back()
        {
            if(this._trophyRoadWindow == 0)
            {
                    return;
            }
            
            this._trophyRoadWindow.丆世与丑丆丅丐万且();
        }
        public TrophyRoadBanner()
        {
        
        }
    
    }

}
