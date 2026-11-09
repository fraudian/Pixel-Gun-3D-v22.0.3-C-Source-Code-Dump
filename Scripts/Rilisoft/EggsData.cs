using UnityEngine;

namespace Rilisoft
{
    public class EggsData : ScriptableObject
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.EggData> Eggs;
        
        // Methods
        public string 丒下丂丒丛且丆丐专()
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.EggData> val_1 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.EggData>();
            List.Enumerator<T> val_2 = this.Eggs.GetEnumerator();
            label_12:
            if(((-704358784) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((val_1.ContainsKey(key:  val_5.Id)) == true)
            {
                goto label_5;
            }
            
            val_1.Add(key:  val_5.Id, value:  val_5);
            goto label_12;
            label_5:
            UnityEngine.Debug.LogError(message:  "Eggs list already contains element with id: "("Eggs list already contains element with id: ") + val_5.Id);
            goto label_12;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return "";
        }
        public EggsData()
        {
            this.Eggs = new System.Collections.Generic.List<Rilisoft.EggData>();
        }
    
    }

}
