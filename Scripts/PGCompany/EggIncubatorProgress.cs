using UnityEngine;

namespace PGCompany
{
    [Serializable]
    public class EggIncubatorProgress
    {
        // Fields
        public string DataId;
        public int Id;
        public long IncubationStart;
        public int IncubationTime;
        public bool IsReady;
        public int Rating;
        public int Wins;
        
        // Properties
        public int DataServerId { get; }
        
        // Methods
        public int get_DataServerId()
        {
            return 丞东丑专丛丆丄丝世.与丛丆专东丐一且丅<PGCompany.丒与丄丐丛万东丒丕>(丙业与丙丗丝不丈东:  this.DataId);
        }
        public EggIncubatorProgress()
        {
            this.Id = 0;
            this.IncubationStart = 0;
            this.IncubationTime = 0;
            this.DataId = System.String.alignConst;
        }
        public EggIncubatorProgress(string 专上丗丐万七一丟丕, int 丙下不丏丅丅专丂丗)
        {
            this.Id = 0;
            this.IncubationStart = 0;
            this.IncubationTime = 0;
            this.DataId = System.String.alignConst;
            this.DataId = 专上丗丐万七一丟丕;
            this.Id = 丙下不丏丅丅专丂丗;
        }
        public override string ToString()
        {
            return UnityEngine.JsonUtility.ToJson(obj:  this);
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丗丟丝丗丟专且丂业(PGCompany.EggIncubatorProgress 下业丕丙丐不丑且丗)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.Add(key:  "d", value:  下业丕丙丐不丑且丗.DataServerId);
            val_1.Add(key:  "i", value:  下业丕丙丐不丑且丗.Id);
            val_1.Add(key:  "s", value:  下业丕丙丐不丑且丗.IncubationStart);
            val_1.Add(key:  "r", value:  下业丕丙丐不丑且丗.Rating);
            val_1.Add(key:  "w", value:  下业丕丙丐不丑且丗.Wins);
            return val_1;
        }
        internal static PGCompany.EggIncubatorProgress 丌七丒七丕上丐三七(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            PGCompany.EggIncubatorProgress val_1 = new PGCompany.EggIncubatorProgress();
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "d", 丙业与丙丗丝不丈东: out  0);
            string val_4 = 0.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                    .DataId = val_4;
            }
            else
            {
                    mem[16] = val_4;
            }
            
            bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "i", 丙业与丙丗丝不丈东: out  (PGCompany.EggIncubatorProgress)[1152921555296423104].Id);
            if(val_1 != null)
            {
                    bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int64>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  (PGCompany.EggIncubatorProgress)[1152921555296423104].IncubationStart);
            }
            else
            {
                    bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int64>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "s", 丙业与丙丗丝不丈东: out  32);
            }
            
            bool val_12 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "r", 丙业与丙丗丝不丈东: out  (PGCompany.EggIncubatorProgress)[1152921555296423104].Rating);
            bool val_14 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  一丐丗丁丞丆丅丟丄, 下上丐丆丝丟丝丒不:  "w", 丙业与丙丗丝不丈东: out  (PGCompany.EggIncubatorProgress)[1152921555296423104].Wins);
            return val_1;
        }
    
    }

}
