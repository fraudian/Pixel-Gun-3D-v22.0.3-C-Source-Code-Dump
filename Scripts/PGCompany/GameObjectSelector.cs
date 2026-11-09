using UnityEngine;

namespace PGCompany
{
    internal sealed class GameObjectSelector : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject primary;
        private UnityEngine.GameObject secondary;
        
        // Methods
        internal void 下丟丛丝专不丗丄丈(int 丝丑丟丏丒且丗丘丛)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.primary, 丏业丟一东丂东丘丛:  ((丝丑丟丏丒且丗丘丛 & 1) != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.secondary, 丏业丟一东丂东丘丛:  丝丑丟丏丒且丗丘丛 & 1);
        }
        public GameObjectSelector()
        {
        
        }
    
    }

}
