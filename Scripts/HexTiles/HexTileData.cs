using UnityEngine;

namespace HexTiles
{
    [Serializable]
    public class HexTileData
    {
        // Fields
        private HexTiles.HexPosition <Position>k__BackingField;
        private float <Diameter>k__BackingField;
        private UnityEngine.Material <Material>k__BackingField;
        
        // Properties
        public HexTiles.HexPosition Position { get; set; }
        public float Diameter { get; set; }
        public UnityEngine.Material Material { get; set; }
        
        // Methods
        public HexTileData(HexTiles.HexPosition 业丒丝丗与丐丛丟丏, float 丟丏东下丄丑丈万丟, UnityEngine.Material 丘上专不丂万业不一)
        {
            val_1 = new System.Object();
            this.<Position>k__BackingField = 业丒丝丗与丐丛丟丏;
            this.<Diameter>k__BackingField = 丟丏东下丄丑丈万丟;
            this.<Material>k__BackingField = val_1;
        }
        public HexTiles.HexPosition get_Position()
        {
            return (HexTiles.HexPosition)this.<Position>k__BackingField;
        }
        private void set_Position(HexTiles.HexPosition 丙业与丙丗丝不丈东)
        {
            this.<Position>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float get_Diameter()
        {
            return (float)this.<Diameter>k__BackingField;
        }
        private void set_Diameter(float 丙业与丙丗丝不丈东)
        {
            this.<Diameter>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.Material get_Material()
        {
            return (UnityEngine.Material)this.<Material>k__BackingField;
        }
        private void set_Material(UnityEngine.Material 丙业与丙丗丝不丈东)
        {
            this.<Material>k__BackingField = 丙业与丙丗丝不丈东;
        }
    
    }

}
