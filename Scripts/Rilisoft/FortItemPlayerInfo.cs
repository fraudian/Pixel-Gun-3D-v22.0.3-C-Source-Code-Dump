using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class FortItemPlayerInfo
    {
        // Fields
        public long CraftStarted;
        public long EquipTime;
        public string InfoId;
        public bool IsCrafted;
        public bool IsCraftedAndNotShown;
        public bool IsEquiped;
        public bool IsNew;
        public System.Collections.Generic.List<Rilisoft.FortItemPlayerLockerInfo> Lockers;
        
        // Methods
        public void 且丅丗丂丗丌与且丝(Rilisoft.FortItemPlayerInfo 丑东与丅丐丅丂丞业)
        {
            if(丑东与丅丐丅丂丞业 != null)
            {
                    this.InfoId = 丑东与丅丐丅丂丞业.InfoId;
                this.CraftStarted = 丑东与丅丐丅丂丞业.CraftStarted;
                this.IsCrafted = 丑东与丅丐丅丂丞业.IsCrafted;
                this.IsCraftedAndNotShown = 丑东与丅丐丅丂丞业.IsCraftedAndNotShown;
                this.IsNew = 丑东与丅丐丅丂丞业.IsNew;
                this.IsEquiped = 丑东与丅丐丅丂丞业.IsEquiped;
            }
            else
            {
                    this.InfoId = 64;
                this.CraftStarted = 4306960387;
                this.IsCrafted = false;
                this.IsCraftedAndNotShown = true;
                this.IsNew = false;
                this.IsEquiped = false;
            }
            
            this.EquipTime = 丑东与丅丐丅丂丞业.EquipTime;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.FortItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0;
            if((System.String.op_Equality(a:  this.InfoId, b:  (System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.FortItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 32)) == false)
            {
                    return false;
            }
            
            var val_3 = (this.IsCrafted == true) ? 1 : 0;
            val_3 = val_3 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.FortItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 40) != 0) ? 1 : 0);
            var val_5 = (this.IsCraftedAndNotShown == true) ? 1 : 0;
            val_5 = val_5 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.FortItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 41) != 0) ? 1 : 0);
            var val_7 = (this.IsNew == true) ? 1 : 0;
            val_7 = val_7 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.FortItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 43) != 0) ? 1 : 0);
            var val_9 = (this.IsEquiped == true) ? 1 : 0;
            val_9 = val_9 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.FortItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 42) != 0) ? 1 : 0);
            return false;
        }
        public FortItemPlayerInfo()
        {
        
        }
    
    }

}
