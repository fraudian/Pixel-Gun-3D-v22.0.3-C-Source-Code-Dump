using UnityEngine;

namespace PGCompany
{
    internal sealed class ChangeLogBanner : BannerWindowWithBack
    {
        // Fields
        private PGCompany.ChangeLogView _view;
        private UIScrollView _scrollViewHelper;
        private long 丗丗丕丈丆丂丐丁丛;
        private PGCompany.丌丄丈丏丘东丛且下 丝业丆丁业三丈丟东;
        
        // Methods
        public override void Show()
        {
            PGCompany.丑世丁三不丘丛一丑 val_1 = PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世();
            this.丝业丆丁业三丈丟东 = val_1.丒丏丝世丄与丏丆三;
            if((val_1.丒丏丝世丄与丏丆三 != null) && (PixelTime.丝业丁丌丘东丏世与() != false))
            {
                    this.丗丗丕丈丆丂丐丁丛 = PixelTime.丝丗专上三不丄丑丑();
                if(this._view != null)
            {
                    this._view.丌丂下丗丈上不丝丗 = this.丝业丆丁业三丈丟东;
                this._view.丝一丅丆三东丂丞七();
            }
            
                if(this.丝业丆丁业三丈丟东.丙丄与世丁丛丞业不() != true)
            {
                    PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世().丕丟丁丑丗与丗丑丄(丅丆一丂丒丗且丐丗:  this.丝业丆丁业三丈丟东);
            }
            
                this.Show();
                this._scrollViewHelper.ResetPosition();
                return;
            }
            
            this.HideSelf();
        }
        public void U_CollectReward()
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_16;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_17;
            long val_18;
            System.Version val_19;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_20;
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                goto label_3;
            }
            
            long val_4 = System.Math.Max(val1:  0, val2:  PixelTime.丝丗专上三不丄丑丑() - this.丗丗丕丈丆丂丐丁丛);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  92);
            if((this.丝业丆丁业三丈丟东.丙丄与世丁丛丞业不() == false) || (this.丝业丆丁业三丈丟东.丂丝丕东东世三丅与() == false))
            {
                goto label_14;
            }
            
            bool val_8 = this.丝业丆丁业三丈丟东.七丙世业七万丈丆丄();
            PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世().丞丞不丞丙丑丕三丄(丅丆一丂丒丗且丐丗:  this.丝业丆丁业三丈丟东);
            UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  10, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
            val_16 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_17 = val_16;
            val_18 = val_4;
            val_19 = this.丝业丆丁业三丈丟东.丄上丕丙丕丑丆丛丘();
            val_20 = this.丝业丆丁业三丈丟东.丈丏丁东上与东丙丕();
            goto label_23;
            label_3:
            this.HideSelf();
            return;
            label_14:
            val_16 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            val_17 = val_16;
            val_18 = val_4;
            val_19 = this.丝业丆丁业三丈丟东.丄上丕丙丕丑丆丛丘();
            val_20 = 0;
            label_23:
            PGCompany.Analytics.一业丗丆世世上丁且.丝东下与下丞丘丈丝(丆丛丑世下一丐且丕:  val_17, 丆丐七丅丆丗丛上与:  val_18, 丌丈不丄丝七丕万专:  val_19, 上业丟世三与七七三:  val_20);
            this.HideSelf();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public override void Back()
        {
        
        }
        public ChangeLogBanner()
        {
        
        }
    
    }

}
