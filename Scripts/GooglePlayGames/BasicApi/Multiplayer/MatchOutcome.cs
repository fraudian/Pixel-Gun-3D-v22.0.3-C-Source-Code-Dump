using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class MatchOutcome
    {
        // Fields
        public const uint PlacementUnset = 0;
        private System.Collections.Generic.List<string> mParticipantIds;
        private System.Collections.Generic.Dictionary<string, uint> mPlacements;
        private System.Collections.Generic.Dictionary<string, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult> mResults;
        
        // Properties
        public System.Collections.Generic.List<string> ParticipantIds { get; }
        
        // Methods
        public MatchOutcome()
        {
            this.mParticipantIds = new System.Collections.Generic.List<System.String>();
            this.mPlacements = new System.Collections.Generic.Dictionary<System.String, System.UInt32>();
            this.mResults = new System.Collections.Generic.Dictionary<System.String, ParticipantResult>();
        }
        public void SetParticipantResult(string participantId, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result, uint placement)
        {
            if((this.mParticipantIds.Contains(item:  participantId)) != true)
            {
                    this.mParticipantIds.Add(item:  participantId);
            }
            
            this.mPlacements.set_Item(key:  participantId, value:  placement);
            this.mResults.set_Item(key:  participantId, value:  result);
        }
        public void SetParticipantResult(string participantId, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result)
        {
            this.SetParticipantResult(participantId:  participantId, result:  result, placement:  0);
        }
        public void SetParticipantResult(string participantId, uint placement)
        {
            this.SetParticipantResult(participantId:  participantId, result:  0, placement:  placement);
        }
        public System.Collections.Generic.List<string> get_ParticipantIds()
        {
            return (System.Collections.Generic.List<System.String>)this.mParticipantIds;
        }
        public GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult GetResultFor(string participantId)
        {
            if((this.mResults.ContainsKey(key:  participantId)) == false)
            {
                    return 0;
            }
            
            if(this.mResults != null)
            {
                    return this.mResults.Item[participantId];
            }
            
            return this.mResults.Item[participantId];
        }
        public uint GetPlacementFor(string participantId)
        {
            if((this.mPlacements.ContainsKey(key:  participantId)) == false)
            {
                    return 0;
            }
            
            if(this.mPlacements != null)
            {
                    return this.mPlacements.Item[participantId];
            }
            
            return this.mPlacements.Item[participantId];
        }
        public override string ToString()
        {
            System.Collections.Generic.List<System.String> val_8;
            string val_9;
            val_8 = this.mParticipantIds;
            val_9 = "[MatchOutcome";
            List.Enumerator<T> val_1 = val_8.GetEnumerator();
            goto label_2;
            label_3:
            val_8 = 0.丐丏七丌丕丗业且上();
            val_9 = val_9 + System.String.Format(format:  " {0}->({1},{2})", arg0:  val_8, arg1:  this.GetResultFor(participantId:  val_8), arg2:  this.GetPlacementFor(participantId:  val_8))(System.String.Format(format:  " {0}->({1},{2})", arg0:  val_8, arg1:  this.GetResultFor(participantId:  val_8), arg2:  this.GetPlacementFor(participantId:  val_8)));
            label_2:
            if(((-1369275624) & 1) != 0)
            {
                goto label_3;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)val_9 + "]";
        }
    
    }

}
