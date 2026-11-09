using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal class GameEventDropChanceData
    {
        // Fields
        internal Rilisoft.丝丑丂丛万丐丈丘且 _roulettePrice;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _smallChestPrice;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _mediumChestPrice;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _bigChestPrice;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _superChestPrice;
        internal System.Collections.Generic.List<Rilisoft.GameEventDropChanceData.丈七一上丒业丗专丈> RoulettePaymentData;
        internal System.Collections.Generic.List<Rilisoft.GameEventDropChanceData.丈七一上丒业丗专丈> ChestPaymentData;
        internal System.Collections.Generic.List<Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌> RouletteDatas;
        internal System.Collections.Generic.List<Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌> ChestsDatas;
        
        // Properties
        internal int RoulettePrice { get; }
        internal int SmallChestPrice { get; }
        internal int MediumChestPrice { get; }
        internal int BigChestPrice { get; }
        internal int SuperChestPrice { get; }
        
        // Methods
        internal int get_RoulettePrice()
        {
        
        }
        internal int get_SmallChestPrice()
        {
        
        }
        internal int get_MediumChestPrice()
        {
        
        }
        internal int get_BigChestPrice()
        {
        
        }
        internal int get_SuperChestPrice()
        {
        
        }
        public GameEventDropChanceData()
        {
            this.RoulettePaymentData = new System.Collections.Generic.List<丈七一上丒业丗专丈>();
            this.ChestPaymentData = new System.Collections.Generic.List<丈七一上丒业丗专丈>();
            this.RouletteDatas = new System.Collections.Generic.List<一七下丝丐丞丁万丌>();
            this.ChestsDatas = new System.Collections.Generic.List<一七下丝丐丞丁万丌>();
        }
    
    }

}
