using UnityEngine;

namespace Rilisoft
{
    public class 丟丒上一且丂一丆世 : 丟丑丆一丕丁丑丐三<float>
    {
        // Methods
        public 丟丒上一且丂一丆世(string 丟东丟丑丕丄丂丟丙)
        {
        
        }
        protected override float 东且丛且业丗丑丙丗()
        {
            return UnityEngine.PlayerPrefs.GetFloat(key:  this.且且丁丐丟丑丕丗与(), defaultValue:  0f);
        }
        protected override void 丂上丆且丘三不丟业(float 丙业与丙丗丝不丈东)
        {
            UnityEngine.PlayerPrefs.SetFloat(key:  this.且且丁丐丟丑丕丗与(), value:  丙业与丙丗丝不丈东);
        }
    
    }

}
