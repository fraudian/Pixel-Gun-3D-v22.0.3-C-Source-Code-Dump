using UnityEngine;

namespace PGCompany
{
    [Serializable]
    public class ModuleData : IEquatable<PGCompany.ModuleData>
    {
        // Fields
        internal string Id;
        private Rilisoft.丝丑丂丛万丐丈丘且 _indexContainer;
        internal PGCompany.ModuleData.ModuleType Type;
        internal PGCompany.ModuleData.ModuleCategory Category;
        internal PGCompany.ModulePointData PointData;
        internal System.Collections.Generic.Dictionary<int, PGCompany.ModuleData.丁丄丅三丞丁万丟丟> Ups;
        private Rilisoft.丝丑丂丛万丐丈丘且 _price;
        
        // Properties
        internal int Index { get; set; }
        internal int Price { get; set; }
        
        // Methods
        internal int get_Index()
        {
        
        }
        internal void set_Index(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._indexContainer = val_1;
            mem[1152921555787253872] = val_1.上万三丆专丏丒丗业;
        }
        internal int get_Price()
        {
        
        }
        internal void set_Price(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._price = val_1;
            mem[1152921555787477912] = val_1.上万三丆专丏丒丗业;
        }
        public bool Equals(PGCompany.ModuleData 丘丛丏丘丝七世七丅)
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
        public ModuleData()
        {
            this.PointData = new PGCompany.ModulePointData();
            this.Ups = new System.Collections.Generic.Dictionary<System.Int32, 丁丄丅三丞丁万丟丟>();
        }
    
    }

}
