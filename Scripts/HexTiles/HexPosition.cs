using UnityEngine;

namespace HexTiles
{
    [Serializable]
    public class HexPosition
    {
        // Fields
        public HexTiles.HexCoords Coordinates;
        public float Elevation;
        
        // Methods
        public HexPosition()
        {
            .Q = 0;
            .R = 0;
            this.Coordinates = new HexTiles.HexCoords();
            this.Elevation = 0f;
        }
        public HexPosition(HexTiles.HexCoords 业丄世世一世三与丝, float 上丘万且丁丏下丂与)
        {
            this.Coordinates = 业丄世世一世三与丝;
            this.Elevation = 上丘万且丁丏下丂与;
        }
        public UnityEngine.Vector3 丌丛不丟丈丛丑丒丅(float 丒丆一丄丛丒且万七)
        {
            if(this.Coordinates != null)
            {
                goto label_4;
            }
            
            this.Coordinates = this.Coordinates;
            if(this.Coordinates == null)
            {
                goto label_5;
            }
            
            label_4:
            float val_4 = 1.732051f;
            float val_5 = 0.5f;
            float val_3 = 3f;
            float val_1 = 丒丆一丄丛丒且万七 * val_5;
            val_3 = val_1 * val_3;
            val_4 = val_1 * val_4;
            val_3 = val_3 * val_5;
            val_5 = (float)this.Coordinates.Q * val_5;
            val_5 = val_5 + (float)this.Coordinates.R;
            val_4 = val_4 * val_5;
            float val_2 = val_3 * (float)this.Coordinates.Q;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_5:
        }
        public static UnityEngine.Vector3 丌丛不丟丈丛丑丒丅(int 东七上世万下丗丄丛, int 丒世且丒丅丆一万丝, float 上丘万且丁丏下丂与, float 丒丆一丄丛丒且万七)
        {
            float val_6 = 0.5f;
            float val_4 = (float)东七上世万下丗丄丛;
            val_4 = ((float)丒世且丒丅丆一万丝 * val_6) + val_4;
            float val_5 = 3f;
            float val_2 = 丒丆一丄丛丒且万七 * val_6;
            val_5 = val_2 * val_5;
            val_6 = val_5 * val_6;
            float val_3 = val_2 * 1.732051f;
            val_3 = val_4 * val_3;
            val_6 = val_6 * (float)丒世且丒丅丆一万丝;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}
