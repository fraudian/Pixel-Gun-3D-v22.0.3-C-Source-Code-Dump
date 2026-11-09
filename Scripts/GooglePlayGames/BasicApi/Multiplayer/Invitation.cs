using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class Invitation
    {
        // Fields
        private GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType mInvitationType;
        private string mInvitationId;
        private GooglePlayGames.BasicApi.Multiplayer.Participant mInviter;
        private int mVariant;
        private System.DateTime mCreationTime;
        
        // Properties
        public GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType InvitationType { get; }
        public string InvitationId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant Inviter { get; }
        public int Variant { get; }
        public System.DateTime CreationTime { get; }
        
        // Methods
        internal Invitation(GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType invType, string invId, GooglePlayGames.BasicApi.Multiplayer.Participant inviter, int variant, System.DateTime creationTime)
        {
            val_1 = new System.Object();
            this.mInvitationType = invType;
            this.mInvitationId = val_1;
            this.mInviter = inviter;
            this.mVariant = variant;
            this.mCreationTime = creationTime;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType get_InvitationType()
        {
            return (InvType)this.mInvitationType;
        }
        public string get_InvitationId()
        {
            return (string)this.mInvitationId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant get_Inviter()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)this.mInviter;
        }
        public int get_Variant()
        {
            return (int)this.mVariant;
        }
        public System.DateTime get_CreationTime()
        {
            return (System.DateTime)this.mCreationTime;
        }
        public override string ToString()
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.mInvitationType != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.mInvitationType == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.mInvitationType;
            val_1[1] = this.mInvitationId;
            val_1[2] = this.mInviter;
            val_1[3] = this.mVariant;
            val_1[4] = this.mCreationTime;
            return (string)System.String.Format(format:  "[Invitation: InvitationType={0}, InvitationId={1}, Inviter={2}, Variant={3}, CreationTime={4}]", args:  val_1);
        }
    
    }

}
