using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPWelcomeDot : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _selected;
        private UnityEngine.GameObject _notSelected;
        
        // Methods
        internal void 世不丅东世丌丏丗三(bool 丂丛丑东不丅丈一东)
        {
            丂丛丑东不丅丈一东 = 丂丛丑东不丅丈一东;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._selected, 丏业丟一东丂东丘丛:  丂丛丑东不丅丈一东);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._notSelected, 丏业丟一东丂东丘丛:  (~丂丛丑东不丅丈一东) & 1);
        }
        public BPWelcomeDot()
        {
        
        }
    
    }

}
