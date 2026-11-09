using UnityEngine;

namespace PGCompany
{
    public class ArmorSkinSettings : ScriptableObject
    {
        // Fields
        private string _armorId;
        private string _localizationKey;
        private bool _defaultSkin;
        private UnityEngine.Vector3 _positionShop;
        private UnityEngine.Vector3 _rotationShop;
        private float _scaleShop;
        
        // Properties
        public string Name { get; }
        public string ArmorId { get; }
        public int ArmorIndex { get; }
        public string LocalizationKey { get; }
        public bool IsDefaultSkin { get; }
        internal 丈丞丕丘丕丗与上一 Price { get; }
        public bool IsFree { get; }
        internal int SkinIndex { get; }
        internal UnityEngine.Vector3 PositionShop { get; }
        internal UnityEngine.Vector3 RotationShop { get; }
        internal float ScaleShop { get; }
        internal int LevelOpen { get; }
        internal bool IsFromAvatarSet { get; }
        
        // Methods
        public string get_Name()
        {
            return this.name;
        }
        public string get_ArmorId()
        {
            return (string)this._armorId;
        }
        public int get_ArmorIndex()
        {
            return 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  this._armorId);
        }
        public string get_LocalizationKey()
        {
            string val_1 = this._localizationKey;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        public bool get_IsDefaultSkin()
        {
            return (bool)this._defaultSkin;
        }
        internal 丈丞丕丘丕丗与上一 get_Price()
        {
            return BalanceController.一丛七丙下丞丏不丅(丞世不丒下上上丝丑:  this.SkinIndex);
        }
        public bool get_IsFree()
        {
            丈丞丕丘丕丗与上一 val_1 = this.Price;
            if(val_1 == null)
            {
                    return (bool)(val_1.丟丂丞不专丆万丒世() == 0) ? 1 : 0;
            }
            
            return (bool)(val_1.丟丂丞不专丆万丒世() == 0) ? 1 : 0;
        }
        internal int get_SkinIndex()
        {
            PGCompany.丈三丁三丂一丅丆丆 val_1 = PGCompany.丈三丁三丂一丅丆丆.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.东丆下丞上丕丑丄丟(丞丅上丏丂且下丅与:  this.name);
            }
            
            return val_1.东丆下丞上丕丑丄丟(丞丅上丏丂且下丅与:  this.name);
        }
        internal UnityEngine.Vector3 get_PositionShop()
        {
            return new UnityEngine.Vector3() {x = this._positionShop};
        }
        internal UnityEngine.Vector3 get_RotationShop()
        {
            return new UnityEngine.Vector3() {x = this._rotationShop};
        }
        internal float get_ScaleShop()
        {
            return (float)this._scaleShop;
        }
        internal int get_LevelOpen()
        {
            return BalanceController.三万且丏丛七丘丟丛(丞世不丒下上上丝丑:  this.SkinIndex);
        }
        internal bool get_IsFromAvatarSet()
        {
            return BalanceController.丂业七下七丑丌丂丛(丞世不丒下上上丝丑:  this.SkinIndex);
        }
        public ArmorSkinSettings()
        {
        
        }
    
    }

}
