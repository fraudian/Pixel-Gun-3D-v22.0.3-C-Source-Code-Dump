using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class AchievementProgressSyncObject
    {
        // Fields
        private readonly System.Collections.Generic.List<Rilisoft.AchievementProgressData> _progressData;
        private bool _conflicted;
        
        // Properties
        public System.Collections.Generic.List<Rilisoft.AchievementProgressData> ProgressData { get; }
        internal bool Conflicted { get; }
        
        // Methods
        public AchievementProgressSyncObject()
        {
            System.Collections.Generic.List<Rilisoft.AchievementProgressData> val_1 = new System.Collections.Generic.List<Rilisoft.AchievementProgressData>();
        }
        public AchievementProgressSyncObject(System.Collections.Generic.List<Rilisoft.AchievementProgressData> 丕丞且丂丒丄东不丘)
        {
            if(丕丞且丂丒丄东不丘 == null)
            {
                goto label_1;
            }
            
            label_4:
            this._progressData = 丕丞且丂丒丄东不丘;
            return;
            label_1:
            System.Collections.Generic.List<Rilisoft.AchievementProgressData> val_1 = new System.Collections.Generic.List<Rilisoft.AchievementProgressData>();
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        public System.Collections.Generic.List<Rilisoft.AchievementProgressData> get_ProgressData()
        {
            return (System.Collections.Generic.List<Rilisoft.AchievementProgressData>)this._progressData;
        }
        internal bool get_Conflicted()
        {
            return (bool)this._conflicted;
        }
        internal static Rilisoft.AchievementProgressSyncObject 丘专专下东下丟与东(string 丌且专不丙丕专丅万)
        {
            var val_9;
            if((System.String.IsNullOrEmpty(value:  丌且专不丙丕专丅万)) == true)
            {
                    return (Rilisoft.AchievementProgressSyncObject)new Rilisoft.AchievementProgressSyncObject();
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌且专不丙丕专丅万);
            if(val_2 == null)
            {
                    return (Rilisoft.AchievementProgressSyncObject)new Rilisoft.AchievementProgressSyncObject();
            }
            
            bool val_4 = val_2.TryGetValue(key:  "progressData", value: out  0);
            return (Rilisoft.AchievementProgressSyncObject)new Rilisoft.AchievementProgressSyncObject();
            label_20:
            if(((-1059591712) & 1) == 0)
            {
                goto label_9;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            if(val_10 == null)
            {
                goto label_20;
            }
            
            Add(item:  Rilisoft.AchievementProgressData.东丝七业丄丑丒世七(万且万且丑丗且丌丆:  val_10));
            goto label_20;
            label_9:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            Rilisoft.AchievementProgressSyncObject val_12 = new Rilisoft.AchievementProgressSyncObject(丕丞且丂丒丄东不丘:  null);
            return (Rilisoft.AchievementProgressSyncObject)new Rilisoft.AchievementProgressSyncObject();
        }
        internal static string 丂丆丑世一不丘丏七(Rilisoft.AchievementProgressSyncObject 世丘万七丗丆丒与七)
        {
            object val_7;
            int val_8;
            if(世丘万七丗丆丒与七 == null)
            {
                goto label_1;
            }
            
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>();
            List.Enumerator<T> val_2 = 世丘万七丗丆丒与七._progressData.GetEnumerator();
            label_6:
            if(((-1059422328) & 1) == 0)
            {
                goto label_3;
            }
            
            val_1.Add(item:  0.丐丏七丌丕丗业且上().丆且丄东丁丑且东丌());
            goto label_6;
            label_1:
            val_8 = System.String.alignConst;
            return (string)Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>());
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5.Add(key:  "progressData", value:  val_1);
            return (string)Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_5);
        }
        internal void 下业丛丟丘丆丘下下()
        {
            this._conflicted = true;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            Rilisoft.AchievementProgressSyncObject val_10;
            Rilisoft.AchievementProgressSyncObject val_11;
            val_10 = 万且万且丑丗且丌丆;
            AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙 val_1 = new AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丝且与丝丒丟万丁专 = this;
            if(val_10 != null)
            {
                goto label_2;
            }
            
            goto label_4;
            label_1:
            mem[24] = this;
            if(val_10 == null)
            {
                goto label_4;
            }
            
            label_2:
            label_4:
            val_11 = 0;
            .丄三丅七丆丛与与上 = ;
            if(val_1 != null)
            {
                    return false;
            }
            
            val_11 = (AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上;
            if(val_11 == null)
            {
                    return false;
            }
            
            if(this._progressData == null)
            {
                goto label_11;
            }
            
            label_28:
            val_10 = (AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上;
            if((AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上._progressData == null)
            {
                    return false;
            }
            
            val_10 = this._progressData;
            label_29:
            if((System.Linq.Enumerable.All<Rilisoft.AchievementProgressData>(source:  val_10, predicate:  new System.Func<Rilisoft.AchievementProgressData, System.Boolean>(object:  val_1, method:  System.Boolean AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙::丐上业一上丝丂丁丞(Rilisoft.AchievementProgressData 丐丆丂丒丁万丈丛丅)))) == false)
            {
                    return false;
            }
            
            val_10 = (AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上._progressData;
            if((System.Linq.Enumerable.All<Rilisoft.AchievementProgressData>(source:  val_10, predicate:  new System.Func<Rilisoft.AchievementProgressData, System.Boolean>(object:  val_1, method:  System.Boolean AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙::丆丌下丄丘丈丟丅世(Rilisoft.AchievementProgressData 丟三下万一丄七一丗)))) == false)
            {
                    return false;
            }
            
            List.Enumerator<T> val_7 = this._progressData.GetEnumerator();
            var val_10 = 0;
            label_22:
            if(((-1059081608) & 1) == 0)
            {
                goto label_18;
            }
            
            Rilisoft.AchievementProgressData val_9 = (AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上._progressData.Item[0];
            val_10 = val_10 + 1;
            if((0.丐丏七丌丕丗业且上() & 1) != 0)
            {
                goto label_22;
            }
            
            goto label_23;
            label_11:
            if((AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上._progressData == null)
            {
                    return false;
            }
            
            if(this._progressData != null)
            {
                goto label_28;
            }
            
            val_10 = (AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上;
            if((AchievementProgressSyncObject.丗丛丘丑丐不丌丑丙)[1152921542202519232].丄三丅七丆丛与与上._progressData != null)
            {
                    return false;
            }
            
            if(this._progressData != null)
            {
                goto label_28;
            }
            
            goto label_29;
            label_18:
            label_23:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return false;
        }
    
    }

}
