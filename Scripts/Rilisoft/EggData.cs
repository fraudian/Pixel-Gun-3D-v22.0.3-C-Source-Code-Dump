using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class EggData
    {
        // Fields
        private System.Nullable<PGCompany.东一业丛丑丂丝七丁> _hatchedType;
        private long _secs;
        public PGCompany.丒与丄丐丛万东丒丕 serverID;
        public bool DropEnabled;
        public RatingSystem.RatingLeague League;
        public PGCompany.EggRarity Rare;
        
        // Properties
        public string Id { get; }
        internal int Wins { get; }
        internal int Rating { get; }
        
        // Methods
        public string get_Id()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            return (string)this.serverID.ToString();
        }
        internal int get_Wins()
        {
            return 0;
        }
        internal int get_Rating()
        {
            return 0;
        }
        public EggData()
        {
            this.DropEnabled = true;
            this.League = 0;
        }
    
    }

}
