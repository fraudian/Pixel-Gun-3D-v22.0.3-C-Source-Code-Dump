using UnityEngine;

namespace Progress
{
    internal class 丏不丞丑且丅世丁丅 : 丙丕丈一一丝丑七丈
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        public Rilisoft.PetsV1.PlayerPets 与世万不上丗丙丞七;
        public Rilisoft.EggsV2.PlayerEggs 丆丝丌世专世世万丛;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丏不丞丑且丅世丁丅.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丏不丞丑且丅世丁丅.丐丌丞上世丛丐丏丛;
        }
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 8;
        }
        internal override string 丆专丟一不东丈丁丆()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        internal override void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄)
        {
            var val_14;
            var val_15;
            var val_16;
            val_14 = 一丐丗丁丞丆丅丟丄;
            this.与世万不上丗丙丞七 = new Rilisoft.PetsV1.PlayerPets();
            this.丆丝丌世专世世万丛 = new Rilisoft.EggsV2.PlayerEggs();
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Collections.Generic.List<System.Object> val_5 = new System.Collections.Generic.List<System.Object>();
            if((ContainsKey(key:  "p")) != false)
            {
                    if(Item["p"] != null)
            {
                    val_15 = 0;
            }
            
                this.与世万不上丗丙丞七 = Rilisoft.PetsV1.PlayerPets.丌七丒七丕上丐三七(一丐丗丁丞丆丅丟丄:  null);
            }
            
            if((ContainsKey(key:  "e")) == false)
            {
                    return;
            }
            
            if(Item["e"] != null)
            {
                    val_16 = 0;
            }
            
            this.丆丝丌世专世世万丛 = Rilisoft.EggsV2.PlayerEggs.七三三且丗丕三三世(一丐丗丁丞丆丅丟丄:  null);
        }
        internal override object 丙丘丝七业丟丁与丛()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "p", value:  Rilisoft.PetsV1.PlayerPets.丗丟丝丗丟专且丂业(与世万不上丗丙丞七:  this.与世万不上丗丙丞七));
            val_1.Add(key:  "e", value:  Rilisoft.EggsV2.PlayerEggs.一丁丆丂丄丒丝万丏(丆丝丌世专世世万丛:  this.丆丝丌世专世世万丛));
            return (object)val_1;
        }
        internal override void 丟丈丌丛且专丐丒丌()
        {
        
        }
        protected override string 丈丞丘丛世业业丈丘()
        {
            object val_10;
            int val_11;
            var val_44;
            System.Func<Rilisoft.PetsV1.PlayerPet, System.String> val_46;
            var val_47;
            var val_48;
            var val_49;
            System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_50;
            var val_51;
            var val_52;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(this.与世万不上丗丙丞七.Pets.Count < 1)
            {
                goto label_39;
            }
            
            System.Text.StringBuilder val_4 = val_1.Append(value:  "p");
            val_44 = null;
            val_44 = null;
            val_46 = 丏不丞丑且丅世丁丅.<>c.<>9__11_0;
            if(val_46 == null)
            {
                    System.Func<Rilisoft.PetsV1.PlayerPet, System.String> val_6 = null;
                val_46 = val_6;
                val_6 = new System.Func<Rilisoft.PetsV1.PlayerPet, System.String>(object:  丏不丞丑且丅世丁丅.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丏不丞丑且丅世丁丅.<>c::丌丒丂丁丌丑丈丏丗(Rilisoft.PetsV1.PlayerPet 三丟东丕丄丄下下丑));
                丏不丞丑且丅世丁丅.<>c.<>9__11_0 = val_46;
            }
            
            List.Enumerator<T> val_9 = System.Linq.Enumerable.ToList<Rilisoft.PetsV1.PlayerPet>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.PetsV1.PlayerPet, System.String>(source:  this.与世万不上丗丙丞七.Pets, keySelector:  val_6)).GetEnumerator();
            val_47 = 1152921541309461744;
            val_48 = 1152921541309462768;
            val_49 = "i";
            label_20:
            if(((-1951916208) & 1) == 0)
            {
                goto label_12;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            val_11 = val_12.Info.Index;
            string val_15 = "i" + val_11;
            System.Text.StringBuilder val_16 = val_1.Append(value:  val_15);
            System.Text.StringBuilder val_18 = val_1.Append(value:  "n" + val_15);
            System.Text.StringBuilder val_21 = val_1.Append(value:  "p" + val_12.ExistsPoints);
            System.Text.StringBuilder val_24 = val_1.Append(value:  "u" + val_12.UpgradeIndex);
            goto label_20;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_39:
            val_50 = this.丆丝丌世专世世万丛.Eggs;
            val_51 = public System.Int32 System.Collections.Generic.List<PGCompany.EggIncubatorProgress>::get_Count();
            if(val_50.Count < 1)
            {
                goto label_79;
            }
            
            System.Text.StringBuilder val_26 = val_1.Append(value:  "e");
            val_52 = null;
            val_52 = null;
            val_50 = 丏不丞丑且丅世丁丅.<>c.<>9__11_1;
            if(val_50 == null)
            {
                    System.Func<PGCompany.EggIncubatorProgress, System.Int32> val_27 = null;
                val_50 = val_27;
                val_27 = new System.Func<PGCompany.EggIncubatorProgress, System.Int32>(object:  丏不丞丑且丅世丁丅.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丏不丞丑且丅世丁丅.<>c::丏丐七丙不丈丒丈丂(PGCompany.EggIncubatorProgress 三丟东丕丄丄下下丑));
                丏不丞丑且丅世丁丅.<>c.<>9__11_1 = val_50;
            }
            
            List.Enumerator<T> val_30 = System.Linq.Enumerable.ToList<PGCompany.EggIncubatorProgress>(source:  System.Linq.Enumerable.OrderBy<PGCompany.EggIncubatorProgress, System.Int32>(source:  this.丆丝丌世专世世万丛.Eggs, keySelector:  val_27)).GetEnumerator();
            val_47 = 1152921541309556976;
            val_48 = "i";
            val_49 = 1152921504622129152;
            label_58:
            if(((-1951916240) & 1) == 0)
            {
                goto label_51;
            }
            
            System.Text.StringBuilder val_33 = val_1.Append(value:  "i" + val_10);
            System.Text.StringBuilder val_36 = val_1.Append(value:  "d" + val_11.丐丏七丌丕丗业且上().DataServerId);
            val_11 = null;
            System.Text.StringBuilder val_38 = val_1.Append(value:  "s" + val_11);
            System.Text.StringBuilder val_40 = val_1.Append(value:  "r" + null);
            System.Text.StringBuilder val_42 = val_1.Append(value:  "w" + "r");
            goto label_58;
            label_51:
            val_51 = public System.Void List.Enumerator<PGCompany.EggIncubatorProgress>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
            label_79:
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        internal override void 且七丙丄丘一丄上不()
        {
            this.与世万不上丗丙丞七 = new Rilisoft.PetsV1.PlayerPets();
            this.丆丝丌世专世世万丛 = new Rilisoft.EggsV2.PlayerEggs();
        }
        public 丏不丞丑且丅世丁丅()
        {
            this.与世万不上丗丙丞七 = new Rilisoft.PetsV1.PlayerPets();
            this.丆丝丌世专世世万丛 = new Rilisoft.EggsV2.PlayerEggs();
        }
        private static 丏不丞丑且丅世丁丅()
        {
            Progress.丏不丞丑且丅世丁丅.丕丟一七丑丙丂丆丙 = "pet_slot";
            Progress.丏不丞丑且丅世丁丅.丐丌丞上世丛丐丏丛 = "pet_slot_key";
        }
    
    }

}
