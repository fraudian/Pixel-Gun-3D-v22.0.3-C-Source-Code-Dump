using UnityEngine;

namespace HexTiles
{
    internal class 下丈上丆七丅丑与丗
    {
        // Fields
        public static readonly float 丘丁世上丘丝丛丁丗;
        public static readonly HexTiles.HexCoords[] 东丈丁丒丛业与丅七;
        
        // Methods
        public static UnityEngine.Vector3[] 丟下丘丆不丏丁丒万(float 丟丒且一专丟丙下一)
        {
            var val_13;
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[6];
            丟丒且一专丟丙下一 = 丟丒且一专丟丙下一 * (-0.5f);
            val_13 = null;
            val_13 = null;
            float val_2 = 丟丒且一专丟丙下一 * (-0.25f);
            float val_4 = (HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗 * 0.5f) * 丟丒且一专丟丙下一;
            float val_6 = 丟丒且一专丟丙下一 * 0.25f;
            float val_7 = (HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗 * 0.5f) * 丟丒且一专丟丙下一;
            float val_8 = 丟丒且一专丟丙下一 * 0.5f;
            float val_10 = (HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗 * (-0.5f)) * 丟丒且一专丟丙下一;
            float val_12 = (HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗 * (-0.5f)) * 丟丒且一专丟丙下一;
            return val_1;
        }
        public 下丈上丆七丅丑与丗()
        {
        
        }
        private static 下丈上丆七丅丑与丗()
        {
            HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗 = 0.8660254f;
            HexTiles.HexCoords[] val_1 = new HexTiles.HexCoords[6];
            HexTiles.HexCoords val_2 = new HexTiles.HexCoords();
            .Q = 8589934591;
            .R = 1;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            .Q = 4294967296;
            .R = 1;
            val_1[1] = new HexTiles.HexCoords();
            .Q = 1;
            .R = 0;
            val_1[2] = new HexTiles.HexCoords();
            .Q = -4294967295;
            .R = -1;
            val_1[3] = new HexTiles.HexCoords();
            .Q = -4294967296;
            .R = -1;
            val_1[4] = new HexTiles.HexCoords();
            .Q = 0;
            .R = 0;
            val_1[5] = new HexTiles.HexCoords();
            HexTiles.下丈上丆七丅丑与丗.东丈丁丒丛业与丅七 = val_1;
        }
    
    }

}
