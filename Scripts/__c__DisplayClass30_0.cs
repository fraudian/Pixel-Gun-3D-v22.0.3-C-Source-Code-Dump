using UnityEngine;
private sealed class AndroidTurnBasedMultiplayerClient.<>c__DisplayClass30_0
{
    // Fields
    public System.Action<bool> onFailure;
    public string participantId;
    public System.Action<GooglePlayGames.BasicApi.Multiplayer.Participant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> onFoundParticipantAndMatch;
    public GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
    public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    
    // Methods
    public AndroidTurnBasedMultiplayerClient.<>c__DisplayClass30_0()
    {
    
    }
    internal void <FindEqualVersionMatchWithParticipant>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch)
    {
        if(success != true)
        {
                true = 1152921516635255488;
            this.onFailure.Invoke(obj:  true);
        }
        
        if(this.participantId == null)
        {
            goto label_3;
        }
        
        GooglePlayGames.BasicApi.Multiplayer.Participant val_1 = foundMatch.GetParticipant(participantId:  this.participantId);
        if(val_1 == null)
        {
            goto label_5;
        }
        
        if(this.onFoundParticipantAndMatch != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        this.onFoundParticipantAndMatch.Invoke(arg1:  val_1, arg2:  foundMatch);
        return;
        label_3:
        GooglePlayGames.BasicApi.Multiplayer.Participant val_2 = 0.CreateAutomatchingSentinel();
        if(this.onFoundParticipantAndMatch != null)
        {
            goto label_8;
        }
        
        goto label_9;
        label_5:
        GooglePlayGames.OurUtils.Logger.e(msg:  System.String.Format(format:  "Located match {0} but desired participant with ID {1} could not be found", arg0:  this.match.MatchId, arg1:  this.participantId));
        this.onFailure.Invoke(obj:  false);
    }

}
