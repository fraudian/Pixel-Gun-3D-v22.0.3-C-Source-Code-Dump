using UnityEngine;

namespace Rilisoft.PetsV1
{
    [Serializable]
    public class PlayerPets
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet> m_pets;
        
        // Properties
        public System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet> Pets { get; set; }
        
        // Methods
        internal PlayerPets()
        {
            this.m_pets = new System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet>();
            this.m_pets = new System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet>();
        }
        public System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet> get_Pets()
        {
            return (System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet>)this.m_pets;
        }
        public void set_Pets(System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet> 丙业与丙丗丝不丈东)
        {
            this.m_pets = 丙业与丙丗丝不丈东;
        }
        public static System.Collections.Generic.Dictionary<string, object> 丗丟丝丗丟专且丂业(Rilisoft.PetsV1.PlayerPets 与世万不上丗丙丞七)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if(与世万不上丗丙丞七 == null)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_2 = 与世万不上丗丙丞七.m_pets.GetEnumerator();
            label_7:
            if((443931896 & 1) == 0)
            {
                goto label_3;
            }
            
            string val_3 = 0.丐丏七丌丕丗业且上();
            val_1.Add(key:  val_3.Info.Index.ToString(), value:  Rilisoft.PetsV1.PlayerPet.丗丟丝丗丟专且丂业(丘丅丛丛丌一丙丄七:  val_3));
            goto label_7;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static Rilisoft.PetsV1.PlayerPets 丌七丒七丕上丐三七(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_6;
            var val_15;
            .m_pets = new System.Collections.Generic.List<Rilisoft.PetsV1.PlayerPet>();
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return (Rilisoft.PetsV1.PlayerPets)new Rilisoft.PetsV1.PlayerPets();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_11:
            if((444106304 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            val_15 = 0;
            (Rilisoft.PetsV1.PlayerPets)[1152921543705707184].m_pets.Add(item:  Rilisoft.PetsV1.PlayerPet.丌七丒七丕上丐三七(丞丅上丏丂且下丅与:  丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Item[System.Int32.Parse(s:  val_7._value._obj.丐丏七丌丕丗业且上())], 一丐丗丁丞丆丅丟丄:  null));
            goto label_11;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.PetsV1.PlayerPets)new Rilisoft.PetsV1.PlayerPets();
        }
    
    }

}
