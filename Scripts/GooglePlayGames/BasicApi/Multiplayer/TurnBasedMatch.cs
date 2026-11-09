using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class TurnBasedMatch
    {
        // Fields
        private string mMatchId;
        private byte[] mData;
        private bool mCanRematch;
        private uint mAvailableAutomatchSlots;
        private string mSelfParticipantId;
        private System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> mParticipants;
        private string mPendingParticipantId;
        private GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus mTurnStatus;
        private GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus mMatchStatus;
        private uint mVariant;
        private uint mVersion;
        private System.DateTime mCreationTime;
        private System.DateTime mLastUpdateTime;
        
        // Properties
        public System.DateTime CreationTime { get; }
        public System.DateTime LastUpdateTime { get; }
        public string MatchId { get; }
        public byte[] Data { get; }
        public bool CanRematch { get; }
        public string SelfParticipantId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant Self { get; }
        public System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> Participants { get; }
        public string PendingParticipantId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant PendingParticipant { get; }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus TurnStatus { get; }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus Status { get; }
        public uint Variant { get; }
        public uint Version { get; }
        public uint AvailableAutomatchSlots { get; }
        
        // Methods
        internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus turnStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus matchStatus, uint variant, uint version, System.DateTime creationTime, System.DateTime lastUpdateTime)
        {
            val_1 = new System.Object();
            this.mMatchId = matchId;
            this.mData = data;
            this.mCanRematch = canRematch;
            this.mSelfParticipantId = val_1;
            this.mParticipants = participants;
            participants.Sort();
            this.mAvailableAutomatchSlots = availableAutomatchSlots;
            this.mTurnStatus = turnStatus;
            this.mMatchStatus = matchStatus;
            this.mVariant = variant;
            this.mVersion = version;
            this.mPendingParticipantId = pendingParticipantId;
            this.mCreationTime = creationTime;
            this.mLastUpdateTime = lastUpdateTime;
        }
        public System.DateTime get_CreationTime()
        {
            return (System.DateTime)this.mCreationTime;
        }
        public System.DateTime get_LastUpdateTime()
        {
            return (System.DateTime)this.mLastUpdateTime;
        }
        public string get_MatchId()
        {
            return (string)this.mMatchId;
        }
        public byte[] get_Data()
        {
            return (System.Byte[])this.mData;
        }
        public bool get_CanRematch()
        {
            return (bool)this.mCanRematch;
        }
        public string get_SelfParticipantId()
        {
            return (string)this.mSelfParticipantId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant get_Self()
        {
            return this.GetParticipant(participantId:  this.mSelfParticipantId);
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
        {
            string val_6;
            var val_7;
            val_6 = participantId;
            List.Enumerator<T> val_1 = this.mParticipants.GetEnumerator();
            label_5:
            if(((-1366414008) & 1) == 0)
            {
                goto label_2;
            }
            
            val_7 = 0.丐丏七丌丕丗业且上();
            if((Equals(value:  val_6)) == false)
            {
                goto label_5;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_6 = "Participant not found in turn-based match: "("Participant not found in turn-based match: ") + val_6;
            GooglePlayGames.OurUtils.Logger.w(msg:  val_6);
            val_7 = 0;
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
        }
        public System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> get_Participants()
        {
            return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)this.mParticipants;
        }
        public string get_PendingParticipantId()
        {
            return (string)this.mPendingParticipantId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant get_PendingParticipant()
        {
            if(this.mPendingParticipantId == null)
            {
                    return 0;
            }
            
            return this.GetParticipant(participantId:  this.mPendingParticipantId);
        }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus get_TurnStatus()
        {
            return (MatchTurnStatus)this.mTurnStatus;
        }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus get_Status()
        {
            return (MatchStatus)this.mMatchStatus;
        }
        public uint get_Variant()
        {
            return (uint)this.mVariant;
        }
        public uint get_Version()
        {
            return (uint)this.mVersion;
        }
        public uint get_AvailableAutomatchSlots()
        {
            return (uint)this.mAvailableAutomatchSlots;
        }
        public override string ToString()
        {
            var val_7;
            System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String> val_9;
            object[] val_1 = new object[12];
            val_1[0] = this.mMatchId;
            val_1[1] = this.mData;
            val_1[2] = this.mCanRematch;
            val_1[3] = this.mSelfParticipantId;
            val_7 = null;
            val_7 = null;
            val_9 = TurnBasedMatch.<>c.<>9__47_0;
            if(val_9 == null)
            {
                    System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String> val_2 = null;
                val_9 = val_2;
                val_2 = new System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String>(object:  TurnBasedMatch.<>c.__il2cppRuntimeField_static_fields, method:  System.String TurnBasedMatch.<>c::<ToString>b__47_0(GooglePlayGames.BasicApi.Multiplayer.Participant p));
                TurnBasedMatch.<>c.<>9__47_0 = val_9;
            }
            
            val_1[4] = System.String.Join(separator:  ",", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String>(source:  this.mParticipants, selector:  val_2)));
            val_1[5] = this.mPendingParticipantId;
            val_1[6] = this.mTurnStatus;
            val_1[7] = this.mMatchStatus;
            val_1[8] = this.mVariant;
            val_1[9] = this.mVersion;
            val_1[10] = this.mCreationTime;
            val_1[11] = this.mLastUpdateTime;
            return (string)System.String.Format(format:  "[TurnBasedMatch: mMatchId={0}, mData={1}, mCanRematch={2}, mSelfParticipantId={3}, mParticipants={4}, mPendingParticipantId={5}, mTurnStatus={6}, mMatchStatus={7}, mVariant={8}, mVersion={9}, mCreationTime={10}, mLastUpdateTime={11}]", args:  val_1);
        }
    
    }

}
