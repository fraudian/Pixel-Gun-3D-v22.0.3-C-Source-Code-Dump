using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal sealed class TrophyRoadEndedSeasonBanner : BannerWindow
    {
        // Fields
        private PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow _trophyRoadEndedSeasonWindow;
        
        // Methods
        public override void Show()
        {
            this.Show();
            if(this._trophyRoadEndedSeasonWindow == 0)
            {
                    this.HideSelf();
                return;
            }
            
            this._trophyRoadEndedSeasonWindow.下与丞三丅丛丄七丕(丞丟万丝七丁丈丌丝:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadEndedSeasonBanner::且丆丆丅丐丙下下丄()));
        }
        private void 且丆丆丅丐丙下下丄()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  8);
            bool val_3 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丗丟七丁不丟一业下();
            bool val_5 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().世丄且丒丌丟丕世丛();
            this.HideSelf();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public TrophyRoadEndedSeasonBanner()
        {
        
        }
    
    }

}
