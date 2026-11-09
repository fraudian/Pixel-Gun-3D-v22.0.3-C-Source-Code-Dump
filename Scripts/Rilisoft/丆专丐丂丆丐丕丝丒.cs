using UnityEngine;

namespace Rilisoft
{
    public class 丆专丐丂丆丐丕丝丒 : 丟丑丆一丕丁丑丐三<bool>
    {
        // Methods
        public 丆专丐丂丆丐丕丝丒(string 丟东丟丑丕丄丂丟丙)
        {
        
        }
        protected override bool 东且丛且业丗丑丙丗()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  UnityEngine.PlayerPrefs.GetInt(key:  this.且且丁丐丟丑丕丗与(), defaultValue:  0));
        }
        protected override void 丂上丆且丘三不丟业(bool 丙业与丙丗丝不丈东)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  this.且且丁丐丟丑丕丗与(), value:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东));
        }
    
    }

}
