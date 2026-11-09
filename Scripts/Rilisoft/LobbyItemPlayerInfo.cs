using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class LobbyItemPlayerInfo : ISerializationCallbackReceiver
    {
        // Fields
        private Rilisoft.丝丑丂丛万丐丈丘且 _craftStarted;
        private long CraftStarted;
        public string InfoId;
        public bool IsCrafted;
        public bool IsCraftedAndNotShown;
        public bool IsEquiped;
        private bool _isNew;
        public System.Collections.Generic.List<Rilisoft.LobbyItemPlayerLockerInfo> Lockers;
        
        // Properties
        public int CraftStartedTime { get; set; }
        public bool isNew { get; set; }
        
        // Methods
        public int get_CraftStartedTime()
        {
        
        }
        public void set_CraftStartedTime(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._craftStarted = 0;
            mem[1152921543073767144] = 0;
        }
        public bool get_isNew()
        {
            return (bool)this._isNew;
        }
        public void set_isNew(bool 丙业与丙丗丝不丈东)
        {
            bool val_1 = 丙业与丙丗丝不丈东;
            this._isNew = val_1;
            if(val_1 != false)
            {
                    return;
            }
            
            Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂().丄丝丆业丑世且不丐(万专万世丂丌丌下万:  this.InfoId);
        }
        public void 且丅丗丂丗丌与且丝(Rilisoft.LobbyItemPlayerInfo 丑东与丅丐丅丂丞业)
        {
            if(丑东与丅丐丅丂丞业 != null)
            {
                    this.InfoId = 丑东与丅丐丅丂丞业.InfoId;
            }
            else
            {
                    this.InfoId = 135970152;
            }
            
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._craftStarted = 0;
            mem[1152921543074127720] = 0;
            if(丑东与丅丐丅丂丞业 != null)
            {
                    this.IsCrafted = 丑东与丅丐丅丂丞业.IsCrafted;
                this.IsCraftedAndNotShown = 丑东与丅丐丅丂丞业.IsCraftedAndNotShown;
            }
            else
            {
                    this.IsCrafted = false;
                this.IsCraftedAndNotShown = false;
            }
            
            this.isNew = 丑东与丅丐丅丂丞业._isNew;
            this.IsEquiped = 丑东与丅丐丅丂丞业.IsEquiped;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            if((System.String.op_Equality(a:  this.InfoId, b:  (System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.LobbyItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 40)) == false)
            {
                    return false;
            }
            
            if(this._craftStarted != (((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.LobbyItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0) + 16))
            {
                    return false;
            }
            
            var val_4 = (this.IsCrafted == true) ? 1 : 0;
            val_4 = val_4 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.LobbyItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 48) != 0) ? 1 : 0);
            var val_6 = (this.IsCraftedAndNotShown == true) ? 1 : 0;
            val_6 = val_6 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.LobbyItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 49) != 0) ? 1 : 0);
            var val_8 = (this._isNew == true) ? 1 : 0;
            val_8 = val_8 ^ ((((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.LobbyItemPlayerInfo.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? 万且万且丑丗且丌丆 : 0 + 51) != 0) ? 1 : 0);
            return false;
        }
        public void OnAfterDeserialize()
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this._craftStarted = 0;
            mem[1152921543074376296] = 0;
        }
        public void OnBeforeSerialize()
        {
            this.CraftStarted = (long)this._craftStarted;
        }
        public LobbyItemPlayerInfo()
        {
        
        }
    
    }

}
