using UnityEngine;

namespace PGCompany
{
    internal class ClanWarTile : HexagonFieldTile
    {
        // Fields
        private UnityEngine.Renderer _renderer;
        private UnityEngine.GameObject _selector;
        
        // Methods
        internal void 一且丝丟丂丗丌丆丗(bool 丞丈丌且东丆丅丗万)
        {
            丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selector, 丏业丟一东丂东丘丛:  丞丈丌且东丆丅丗万);
        }
        internal void 专丏专上丅与丄丙丅(UnityEngine.Material 世丑丘丘丂专丅丆与, UnityEngine.Material 世丝丏丞丂丟丒丝丆, UnityEngine.Material 丟东丁下三世下与业)
        {
            UnityEngine.Material val_7;
            UnityEngine.Material[] val_8;
            val_7 = 世丑丘丘丂专丅丆与;
            if(this._renderer == 0)
            {
                    return;
            }
            
            if(世丝丏丞丂丟丒丝丆 == 0)
            {
                    val_8 = new UnityEngine.Material[1];
            }
            else
            {
                    if(丟东丁下三世下与业 == 0)
            {
                    val_8 = new UnityEngine.Material[2];
                val_8[0] = val_7;
                val_7 = 世丝丏丞丂丟丒丝丆;
            }
            else
            {
                    UnityEngine.Material[] val_6 = new UnityEngine.Material[3];
                val_8 = val_6;
                val_8[0] = val_7;
                val_8[1] = 世丝丏丞丂丟丒丝丆;
                val_7 = 丟东丁下三世下与业;
            }
            
            }
            
            mem2[0] = val_7;
            this._renderer.sharedMaterials = val_6;
        }
        public ClanWarTile()
        {
        
        }
    
    }

}
