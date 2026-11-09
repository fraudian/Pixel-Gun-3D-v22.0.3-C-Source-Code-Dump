using UnityEngine;

namespace PGCompany
{
    [Serializable]
    public class ModuleDataV1 : IEquatable<PGCompany.ModuleDataV1>
    {
        // Fields
        internal string Id;
        private Rilisoft.丝丑丂丛万丐丈丘且 _indexContainer;
        internal PGCompany.ModuleData.ModuleType Type;
        internal PGCompany.ModuleData.ModuleCategory Category;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Up;
        private Rilisoft.丟七丈丘丐丟丒丏丛 _modificatorContainer;
        internal 丈丞丕丘丕丗与上一 DetachPrice;
        internal 丈丞丕丘丕丗与上一 DestroyPrice;
        internal 丈丞丕丘丕丗与上一 UpgradePrice;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Weight;
        internal Rilisoft.丝丑丂丛万丐丈丘且 CountForUp;
        internal string modulIdNextUp;
        internal string modulIdLastUp;
        
        // Properties
        internal int Index { get; set; }
        internal float Modificator { get; set; }
        
        // Methods
        internal int get_Index()
        {
        
        }
        internal void set_Index(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._indexContainer = val_1;
            mem[1152921555788760048] = val_1.上万三丆专丏丒丗业;
        }
        internal float get_Modificator()
        {
        
        }
        internal void set_Modificator(float 丙业与丙丗丝不丈东)
        {
            Rilisoft.丟七丈丘丐丟丒丏丛 val_1 = Rilisoft.丟七丈丘丐丟丒丏丛.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._modificatorContainer = val_1;
            mem[1152921555788984088] = val_1.丌下丕不且世丟丒上;
        }
        public bool Equals(PGCompany.ModuleDataV1 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 != null)
            {
                    return System.String.op_Equality(a:  this.Id, b:  丘丛丏丘丝七世七丅.Id);
            }
            
            return System.String.op_Equality(a:  this.Id, b:  丘丛丏丘丝七世七丅.Id);
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            return false;
        }
        public ModuleDataV1()
        {
            this._modificatorContainer = 0;
            mem[1152921555789352856] = 0;
        }
    
    }

}
