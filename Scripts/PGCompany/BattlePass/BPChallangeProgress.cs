using UnityEngine;

namespace PGCompany.BattlePass
{
    [Serializable]
    public class BPChallangeProgress : ISerializationCallbackReceiver
    {
        // Fields
        public int Id;
        public bool IsCompleted;
        private int Points;
        internal Rilisoft.丝丑丂丛万丐丈丘且 PointsContainer;
        
        // Methods
        public void OnAfterDeserialize()
        {
            this.PointsContainer = 0;
            mem[1152921559938895864] = 0;
        }
        public void OnBeforeSerialize()
        {
            this.Points = this.PointsContainer;
        }
        internal PGCompany.BattlePass.BPChallangeProgress 丕东丞业丗三丅丗万()
        {
            int val_3;
            PGCompany.BattlePass.BPChallangeProgress val_1 = new PGCompany.BattlePass.BPChallangeProgress();
            if(val_1 != null)
            {
                    .Id = this.Id;
                .IsCompleted = this.IsCompleted;
                val_3 = this.Points;
            }
            else
            {
                    mem[16] = this.Id;
                .IsCompleted = this.IsCompleted;
                val_3 = this.Points;
            }
            
            .Points = val_3;
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            .PointsContainer = 0;
            mem[1152921559939155960] = 0;
            return val_1;
        }
        public BPChallangeProgress()
        {
        
        }
    
    }

}
