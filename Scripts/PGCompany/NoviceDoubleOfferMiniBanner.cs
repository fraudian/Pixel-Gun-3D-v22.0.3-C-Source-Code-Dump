using UnityEngine;

namespace PGCompany
{
    internal sealed class NoviceDoubleOfferMiniBanner : PGBehaviour
    {
        // Fields
        private PGCompany.TimerUI _timer;
        private UILabel _titleLabel;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.上业七丕丒丂七丐丄 丙业丞丑七丗下丟丌)
        {
            if(this._timer != null)
            {
                    this._timer.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  丙业丞丑七丗下丟丌.下丒丗丄丌丘不丑丘() - PixelTime.丙丅丅业丟丁世丁丗(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  丙业丞丑七丗下丟丌.世丁万丗三丈丑丅世());
        }
        public NoviceDoubleOfferMiniBanner()
        {
        
        }
    
    }

}
