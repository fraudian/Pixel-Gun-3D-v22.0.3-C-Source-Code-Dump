using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class ClanWarMapCellConfig
    {
        // Fields
        internal DiscreteVector2 Coordinate;
        internal PGCompany.丝丂丒专丞与丙丏一 Type;
        internal Rilisoft.丝丑丂丛万丐丈丘且 _numClanContainer;
        internal PGCompany.ClanWarMapCellConfig.TaskConfig TaskSettings;
        internal ItemRarity Complexity;
        
        // Properties
        internal int NumClan { get; set; }
        
        // Methods
        internal int get_NumClan()
        {
        
        }
        internal void set_NumClan(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._numClanContainer = val_1;
            mem[1152921554199613304] = val_1.上万三丆专丏丒丗业;
        }
        public ClanWarMapCellConfig()
        {
        
        }
    
    }

}
