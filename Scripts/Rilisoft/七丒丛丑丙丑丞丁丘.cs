using UnityEngine;

namespace Rilisoft
{
    public class 七丒丛丑丙丑丞丁丘 : 丟丑丆一丕丁丑丐三<int>
    {
        // Methods
        public 七丒丛丑丙丑丞丁丘(string 丟东丟丑丕丄丂丟丙)
        {
        
        }
        protected override int 东且丛且业丗丑丙丗()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  this.且且丁丐丟丑丕丗与(), defaultValue:  0);
        }
        protected override void 丂上丆且丘三不丟业(int 丙业与丙丗丝不丈东)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  this.且且丁丐丟丑丕丗与(), value:  丙业与丙丗丝不丈东);
        }
    
    }

}
