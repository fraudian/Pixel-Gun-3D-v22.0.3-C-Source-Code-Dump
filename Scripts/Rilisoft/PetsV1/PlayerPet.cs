using UnityEngine;

namespace Rilisoft.PetsV1
{
    [Serializable]
    public class PlayerPet : ISerializationCallbackReceiver
    {
        // Fields
        private PetInfo _info;
        private string _infoId;
        private long m_timestamp;
        public string PetName;
        private int Points;
        private Rilisoft.丝丑丂丛万丐丈丘且 _pointsContainer;
        private int upgradeIndex;
        
        // Properties
        public int ExistsPoints { get; set; }
        public int UpgradeIndex { get; set; }
        public long NameTimestamp { get; set; }
        public string InfoId { get; set; }
        public PetInfo Info { get; }
        
        // Methods
        public PlayerPet()
        {
        
        }
        public PlayerPet(Rilisoft.PetsV1.PlayerPet 丘丅丛丛丌一丙丄七)
        {
            if(丘丅丛丛丌一丙丄七 != null)
            {
                    this._infoId = 丘丅丛丛丌一丙丄七._infoId;
                this.PetName = 丘丅丛丛丌一丙丄七.PetName;
            }
            else
            {
                    this._infoId = 28563616;
                this.PetName = 135970152;
            }
            
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._pointsContainer = 0;
            mem[1152921543703274864] = 0;
            this.m_timestamp = 丘丅丛丛丌一丙丄七.m_timestamp;
        }
        public int get_ExistsPoints()
        {
        
        }
        public void set_ExistsPoints(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._pointsContainer = 0;
            mem[1152921543703511152] = 0;
        }
        public int get_UpgradeIndex()
        {
            return (int)this.upgradeIndex;
        }
        public void set_UpgradeIndex(int 丙业与丙丗丝不丈东)
        {
            this.upgradeIndex = 丙业与丙丗丝不丈东;
        }
        public long get_NameTimestamp()
        {
            return (long)this.m_timestamp;
        }
        public void set_NameTimestamp(long 丙业与丙丗丝不丈东)
        {
            this.m_timestamp = 丙业与丙丗丝不丈东;
        }
        public string get_InfoId()
        {
            return (string)this._infoId;
        }
        public void set_InfoId(string 丙业与丙丗丝不丈东)
        {
            this._infoId = 丙业与丙丗丝不丈东;
        }
        public PetInfo get_Info()
        {
            if(this._info != null)
            {
                    return val_2;
            }
            
            PetInfo val_2 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this._infoId);
            this._info = val_2;
            return val_2;
        }
        public static Rilisoft.PetsV1.PlayerPet 专丒业丘七丞不丗丛(Rilisoft.PetsV1.PlayerPet 丘丅丛丛丌一丙丄七)
        {
            var val_2;
            if(丘丅丛丛丌一丙丄七 != null)
            {
                    Rilisoft.PetsV1.PlayerPet val_1 = null;
                val_2 = val_1;
                val_1 = new Rilisoft.PetsV1.PlayerPet(丘丅丛丛丌一丙丄七:  丘丅丛丛丌一丙丄七);
                return (Rilisoft.PetsV1.PlayerPet)val_2;
            }
            
            val_2 = 0;
            return (Rilisoft.PetsV1.PlayerPet)val_2;
        }
        public void OnBeforeSerialize()
        {
            this.Points = this._pointsContainer;
        }
        public void OnAfterDeserialize()
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            this._pointsContainer = 0;
            mem[1152921543704696688] = 0;
        }
        public static System.Collections.Generic.Dictionary<string, object> 丗丟丝丗丟专且丂业(Rilisoft.PetsV1.PlayerPet 丘丅丛丛丌一丙丄七)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "n", value:  丘丅丛丛丌一丙丄七.PetName);
            val_1.Add(key:  "p", value:  丘丅丛丛丌一丙丄七._pointsContainer);
            val_1.Add(key:  "u", value:  丘丅丛丛丌一丙丄七.upgradeIndex);
            return val_1;
        }
        public static Rilisoft.PetsV1.PlayerPet 丌七丒七丕上丐三七(string 丞丅上丏丂且下丅与, System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            int val_4 = 0;
            Rilisoft.PetsV1.PlayerPet val_1 = new Rilisoft.PetsV1.PlayerPet();
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "n", 丙业与丙丗丝不丈东: out  (Rilisoft.PetsV1.PlayerPet)[1152921543705014064].PetName);
            bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "p", 丙业与丙丗丝不丈东: out  val_4);
            int val_6 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
            ._pointsContainer = 0;
            mem[1152921543705014128] = 0;
            bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "u", 丙业与丙丗丝不丈东: out  val_4);
            if(val_1 != null)
            {
                    .upgradeIndex = 0;
                var val_8 = (丞丅上丏丂且下丅与 == null) ? "" : 丞丅上丏丂且下丅与;
            }
            else
            {
                    .upgradeIndex = 0;
            }
            
            ._infoId = (丞丅上丏丂且下丅与 == null) ? "" : 丞丅上丏丂且下丅与;
            return val_1;
        }
    
    }

}
