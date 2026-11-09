using UnityEngine;

namespace Rilisoft.EggsV2
{
    [Serializable]
    public class PlayerEggs
    {
        // Fields
        public System.Collections.Generic.List<PGCompany.EggIncubatorProgress> Eggs;
        
        // Methods
        public override string ToString()
        {
            return UnityEngine.JsonUtility.ToJson(obj:  this);
        }
        internal static Rilisoft.EggsV2.PlayerEggs 东丝七业丄丑丒世七(string 丞丕丒专一下丙业上)
        {
            return UnityEngine.JsonUtility.FromJson<Rilisoft.EggsV2.PlayerEggs>(json:  丞丕丒专一下丙业上);
        }
        public static System.Collections.Generic.List<object> 一丁丆丂丄丒丝万丏(Rilisoft.EggsV2.PlayerEggs 丆丝丌世专世世万丛)
        {
            System.Collections.Generic.List<System.Object> val_1 = new System.Collections.Generic.List<System.Object>();
            if(丆丝丌世专世世万丛 == null)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_2 = 丆丝丌世专世世万丛.Eggs.GetEnumerator();
            label_5:
            if((574503224 & 1) == 0)
            {
                goto label_3;
            }
            
            val_1.Add(item:  PGCompany.EggIncubatorProgress.丗丟丝丗丟专且丂业(下业丕丙丐不丑且丗:  0.丐丏七丌丕丗业且上()));
            goto label_5;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static Rilisoft.EggsV2.PlayerEggs 七三三且丗丕三三世(System.Collections.Generic.List<object> 一丐丗丁丞丆丅丟丄)
        {
            var val_5;
            var val_9;
            .Eggs = new System.Collections.Generic.List<PGCompany.EggIncubatorProgress>();
            List.Enumerator<T> val_3 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
            label_8:
            if((574660256 & 1) == 0)
            {
                goto label_3;
            }
            
            if(val_5.丐丏七丌丕丗业且上() != null)
            {
                    val_9 = 0;
            }
            
            (Rilisoft.EggsV2.PlayerEggs)[1152921543836261104].Eggs.Add(item:  PGCompany.EggIncubatorProgress.丌七丒七丕上丐三七(一丐丗丁丞丆丅丟丄:  null));
            goto label_8;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (Rilisoft.EggsV2.PlayerEggs)new Rilisoft.EggsV2.PlayerEggs();
        }
        public PlayerEggs()
        {
            this.Eggs = new System.Collections.Generic.List<PGCompany.EggIncubatorProgress>();
        }
    
    }

}
