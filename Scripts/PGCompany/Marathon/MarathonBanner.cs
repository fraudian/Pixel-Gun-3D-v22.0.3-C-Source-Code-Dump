using UnityEngine;

namespace PGCompany.Marathon
{
    internal sealed class MarathonBanner : BannerWindowWithBack
    {
        // Fields
        private PGCompany.Marathon.MarathonView marathonView;
        
        // Methods
        public override void Show()
        {
            this.Show();
            this.marathonView.丈且东丑丂且万丒丅();
        }
        public override void Back()
        {
            this.marathonView.世业丒万丘丆专丘丐();
            this.HideSelf();
            this.Back();
        }
        public MarathonBanner()
        {
        
        }
    
    }

}
