using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class Participant : IComparable<GooglePlayGames.BasicApi.Multiplayer.Participant>
    {
        // Fields
        private string mDisplayName;
        private readonly string mParticipantId;
        private GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus mStatus;
        private GooglePlayGames.BasicApi.Multiplayer.Player mPlayer;
        private bool mIsConnectedToRoom;
        
        // Properties
        public string DisplayName { get; }
        public string ParticipantId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus Status { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Player Player { get; }
        public bool IsConnectedToRoom { get; }
        public bool IsAutomatch { get; }
        
        // Methods
        public string get_DisplayName()
        {
            return (string)this.mDisplayName;
        }
        public string get_ParticipantId()
        {
            return (string)this.mParticipantId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus get_Status()
        {
            return (ParticipantStatus)this.mStatus;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Player get_Player()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Player)this.mPlayer;
        }
        public bool get_IsConnectedToRoom()
        {
            return (bool)this.mIsConnectedToRoom;
        }
        public bool get_IsAutomatch()
        {
            return (bool)(this.mPlayer == 0) ? 1 : 0;
        }
        internal Participant(string displayName, string participantId, GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus status, GooglePlayGames.BasicApi.Multiplayer.Player player, bool connectedToRoom)
        {
            this.mDisplayName = System.String.alignConst;
            this.mStatus = 7;
            this.mParticipantId = System.String.alignConst;
            val_1 = new System.Object();
            this.mDisplayName = displayName;
            this.mParticipantId = val_1;
            this.mStatus = status;
            this.mPlayer = player;
            this.mIsConnectedToRoom = connectedToRoom;
        }
        public override string ToString()
        {
            var val_5;
            object val_6;
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.mDisplayName != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.mDisplayName == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.mDisplayName;
            val_1[1] = this.mParticipantId;
            val_5 = public System.String System.Enum::ToString();
            string val_2 = this.mStatus.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            if((val_2 != null) && (val_2 == null))
            {
                    val_5 = 0;
            }
            
            if(val_1.Length <= 2)
            {
                    val_5 = 0;
            }
            
            val_1[2] = val_2;
            if(this.mPlayer == null)
            {
                goto label_15;
            }
            
            val_6 = this.mPlayer.ToString();
            if(val_6 != null)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            val_6 = "NULL";
            label_16:
            label_19:
            val_1[3] = val_6;
            val_1[4] = this.mIsConnectedToRoom;
            return (string)System.String.Format(format:  "[Participant: \'{0}\' (id {1}), status={2}, player={3}, connected={4}]", args:  val_1);
        }
        public int CompareTo(GooglePlayGames.BasicApi.Multiplayer.Participant other)
        {
            if(other != null)
            {
                    return System.String.Compare(strA:  this.mParticipantId, strB:  other.mParticipantId, comparisonType:  4);
            }
            
            return System.String.Compare(strA:  this.mParticipantId, strB:  other.mParticipantId, comparisonType:  4);
        }
        public override bool Equals(object obj)
        {
            System.Type val_8;
            string val_9;
            var val_10;
            val_9 = obj;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if(this == val_9)
            {
                goto label_2;
            }
            
            val_8 = val_9.GetType();
            if((System.Type.op_Inequality(left:  val_8, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
            {
                goto label_5;
            }
            
            label_1:
            val_10 = 0;
            return (bool)val_10.Equals(value:  val_9);
            label_2:
            val_10 = 1;
            return (bool)val_10.Equals(value:  val_9);
            label_5:
            val_10 = this.mParticipantId;
            return (bool)val_10.Equals(value:  val_9);
        }
        public override int GetHashCode()
        {
            if(this.mParticipantId == null)
            {
                    return (int)this.mParticipantId;
            }
            
            goto typeof(System.String).__il2cppRuntimeField_148;
        }
    
    }

}
