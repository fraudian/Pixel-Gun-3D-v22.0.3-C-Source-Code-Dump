using UnityEngine;

namespace Rilisoft
{
    public class 丆丌一三上丄丐丗专 : 丟丑丆一丕丁丑丐三<string>
    {
        // Methods
        public 丆丌一三上丄丐丗专(string 丟东丟丑丕丄丂丟丙)
        {
        
        }
        protected override string 东且丛且业丗丑丙丗()
        {
            return UnityEngine.PlayerPrefs.GetString(key:  this.且且丁丐丟丑丕丗与(), defaultValue:  System.String.alignConst);
        }
        protected override void 丂上丆且丘三不丟业(string 丙业与丙丗丝不丈东)
        {
            UnityEngine.PlayerPrefs.SetString(key:  this.且且丁丐丟丑丕丗与(), value:  丙业与丙丗丝不丈东);
        }
    
    }

}
