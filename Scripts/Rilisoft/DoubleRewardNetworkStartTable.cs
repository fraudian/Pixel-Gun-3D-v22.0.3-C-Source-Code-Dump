using UnityEngine;

namespace Rilisoft
{
    internal sealed class DoubleRewardNetworkStartTable : MonoBehaviour
    {
        // Fields
        private UILabel _doubleRewardLabel;
        
        // Properties
        public UILabel 东与丙一丅东专七丏 { get; }
        
        // Methods
        public UILabel get_DoubleRewardLabel()
        {
            return (UILabel)this._doubleRewardLabel;
        }
        internal void 丗与丄丑一丈丙不丛(bool 丛丛丌丗丂上七丘丆, 丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三)
        {
            if(this._doubleRewardLabel == 0)
            {
                    return;
            }
            
            this._doubleRewardLabel.gameObject.SetActive(value:  丛丛丌丗丂上七丘丆);
            if(丗七丟丈三不丕一三 == null)
            {
                    return;
            }
            
            this.丗丕不万万且丛丟丝(丗七丟丈三不丕一三:  丗七丟丈三不丕一三);
        }
        private void 丗丕不万万且丛丟丝(丞丅与与丈丕丟丑丘 丗七丟丈三不丕一三)
        {
            string val_5;
            if(丗七丟丈三不丕一三.丌东业与丞丐丂丝专() <= 3)
            {
                    var val_5 = 106029168 + (val_1) << 2;
                val_5 = val_5 + 106029168;
            }
            else
            {
                    val_5 = "";
                this._doubleRewardLabel.text = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  null, arg0:  2);
            }
        
        }
        public DoubleRewardNetworkStartTable()
        {
        
        }
    
    }

}
