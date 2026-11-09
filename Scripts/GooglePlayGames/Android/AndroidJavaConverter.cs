using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidJavaConverter
    {
        // Methods
        internal static System.DateTime ToDateTime(long milliseconds)
        {
            System.DateTime val_1 = 0.AddMilliseconds(value:  (double)milliseconds);
            return 0;
        }
        internal static int ToLeaderboardVariantTimeSpan(GooglePlayGames.BasicApi.LeaderboardTimeSpan span)
        {
            if(span == 3)
            {
                    return (int)span - 1;
            }
            
            if(span == 2)
            {
                    return 1;
            }
            
            if(span == 1)
            {
                    return (int)span - 1;
            }
            
            span - 1 = 2;
            return (int)span - 1;
        }
        internal static int ToLeaderboardVariantCollection(GooglePlayGames.BasicApi.LeaderboardCollection collection)
        {
            return (int)(collection == 2) ? 1 : 0;
        }
        internal static int ToPageDirection(GooglePlayGames.BasicApi.ScorePageDirection direction)
        {
            if(direction != 1)
            {
                    return (int)(direction == 2) ? (-0) : 0;
            }
            
            return 0;
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType FromInvitationType(int invitationTypeJava)
        {
            if(invitationTypeJava == 0)
            {
                    return (InvType)(invitationTypeJava != 1) ? (1 + 1) : 1;
            }
            
            return (InvType)(invitationTypeJava != 1) ? (1 + 1) : 1;
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus FromParticipantStatus(int participantStatusJava)
        {
            return (ParticipantStatus)(participantStatusJava < 7) ? participantStatusJava : 7;
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.Participant ToParticipant(UnityEngine.AndroidJavaObject participant)
        {
            T[] val_15 = System.Array.Empty<System.Object>();
            int val_6 = participant.Call<System.Int32>(methodName:  "getStatus", args:  val_15);
            val_15 = (val_6 < 7) ? (val_6) : 7;
            UnityEngine.AndroidJavaObject val_10 = participant.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPlayer", args:  System.Array.Empty<System.Object>());
            if(val_10 != null)
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_10.Dispose();
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  participant.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>()), participantId:  participant.Call<System.String>(methodName:  "getParticipantId", args:  System.Array.Empty<System.Object>()), status:  val_15, player:  GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_10), connectedToRoom:  participant.Call<System.Boolean>(methodName:  "isConnectedToRoom", args:  System.Array.Empty<System.Object>()));
            }
            
                if(117 != 117)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  participant.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>()), participantId:  participant.Call<System.String>(methodName:  "getParticipantId", args:  System.Array.Empty<System.Object>()), status:  val_15, player:  GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_10), connectedToRoom:  participant.Call<System.Boolean>(methodName:  "isConnectedToRoom", args:  System.Array.Empty<System.Object>()));
            }
            
                return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  participant.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>()), participantId:  participant.Call<System.String>(methodName:  "getParticipantId", args:  System.Array.Empty<System.Object>()), status:  val_15, player:  GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_10), connectedToRoom:  participant.Call<System.Boolean>(methodName:  "isConnectedToRoom", args:  System.Array.Empty<System.Object>()));
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  participant.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>()), participantId:  participant.Call<System.String>(methodName:  "getParticipantId", args:  System.Array.Empty<System.Object>()), status:  val_15, player:  GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_10), connectedToRoom:  participant.Call<System.Boolean>(methodName:  "isConnectedToRoom", args:  System.Array.Empty<System.Object>()));
            }
            
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  participant.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>()), participantId:  participant.Call<System.String>(methodName:  "getParticipantId", args:  System.Array.Empty<System.Object>()), status:  val_15, player:  GooglePlayGames.Android.AndroidJavaConverter.ToPlayer(player:  val_10), connectedToRoom:  participant.Call<System.Boolean>(methodName:  "isConnectedToRoom", args:  System.Array.Empty<System.Object>()));
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.Player ToPlayer(UnityEngine.AndroidJavaObject player)
        {
            UnityEngine.AndroidJavaObject val_8 = player;
            if(val_8 == null)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Player)val_8;
            }
            
            GooglePlayGames.BasicApi.Multiplayer.Player val_7 = null;
            val_8 = val_7;
            val_7 = new GooglePlayGames.BasicApi.Multiplayer.Player(displayName:  val_8.Call<System.String>(methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>()), playerId:  val_8.Call<System.String>(methodName:  "getPlayerId", args:  System.Array.Empty<System.Object>()), avatarUrl:  val_8.Call<System.String>(methodName:  "getIconImageUrl", args:  System.Array.Empty<System.Object>()));
            return (GooglePlayGames.BasicApi.Multiplayer.Player)val_8;
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.Invitation ToInvitation(UnityEngine.AndroidJavaObject invitation)
        {
            int val_4 = invitation.Call<System.Int32>(methodName:  "getInvitationType", args:  System.Array.Empty<System.Object>());
            System.DateTime val_9 = GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  invitation.Call<System.Int64>(methodName:  "getCreationTimestamp", args:  System.Array.Empty<System.Object>()));
            UnityEngine.AndroidJavaObject val_11 = invitation.Call<UnityEngine.AndroidJavaObject>(methodName:  "getInviter", args:  System.Array.Empty<System.Object>());
            new GooglePlayGames.BasicApi.Multiplayer.Invitation() = new GooglePlayGames.BasicApi.Multiplayer.Invitation(invType:  (val_4 == 0) ? 0 : ((val_4 != 1) ? (1 + 1) : 1), invId:  invitation.Call<System.String>(methodName:  "getInvitationId", args:  System.Array.Empty<System.Object>()), inviter:  GooglePlayGames.Android.AndroidJavaConverter.ToParticipant(participant:  val_11), variant:  invitation.Call<System.Int32>(methodName:  "getVariant", args:  System.Array.Empty<System.Object>()), creationTime:  new System.DateTime() {dateData = val_9.dateData});
            if(val_11 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_11.Dispose();
            }
            
            if(0 != 1)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Invitation)new GooglePlayGames.BasicApi.Multiplayer.Invitation();
            }
            
            if(0 == 0)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Invitation)new GooglePlayGames.BasicApi.Multiplayer.Invitation();
            }
            
            return (GooglePlayGames.BasicApi.Multiplayer.Invitation)new GooglePlayGames.BasicApi.Multiplayer.Invitation();
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch ToTurnBasedMatch(UnityEngine.AndroidJavaObject turnBasedMatch)
        {
            UnityEngine.AndroidJavaObject val_30;
            var val_31;
            MatchTurnStatus val_32;
            val_30 = turnBasedMatch;
            if(val_30 == null)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch)val_30;
            }
            
            if((val_30.Call<System.Int32>(methodName:  "getStatus", args:  System.Array.Empty<System.Object>())) <= 5)
            {
                    val_31 = mem[106049152 + (val_15) << 2];
                val_31 = 106049152 + (val_15) << 2;
            }
            else
            {
                    val_31 = 5;
            }
            
            if((val_30.Call<System.Int32>(methodName:  "getTurnStatus", args:  System.Array.Empty<System.Object>())) <= 3)
            {
                    val_32 = mem[106049176 + (val_17) << 2];
                val_32 = 106049176 + (val_17) << 2;
            }
            else
            {
                    val_32 = 4;
            }
            
            System.DateTime val_24 = GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  val_30.Call<System.Int64>(methodName:  "getCreationTimestamp", args:  System.Array.Empty<System.Object>()));
            System.DateTime val_27 = GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  val_30.Call<System.Int64>(methodName:  "getLastUpdatedTimestamp", args:  System.Array.Empty<System.Object>()));
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_29 = null;
            val_30 = val_29;
            val_29 = new GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch(matchId:  val_30.Call<System.String>(methodName:  "getMatchId", args:  System.Array.Empty<System.Object>()), data:  val_30.Call<System.Byte[]>(methodName:  "getData", args:  System.Array.Empty<System.Object>()), canRematch:  val_30.Call<System.Boolean>(methodName:  "canRematch", args:  System.Array.Empty<System.Object>()), selfParticipantId:  val_30.Call<System.String>(methodName:  "getCreatorId", args:  System.Array.Empty<System.Object>()), participants:  GooglePlayGames.Android.AndroidJavaConverter.ToParticipantList(turnBasedMatch:  val_30), availableAutomatchSlots:  val_30.Call<System.Int32>(methodName:  "getAvailableAutoMatchSlots", args:  System.Array.Empty<System.Object>()), pendingParticipantId:  val_30.Call<System.String>(methodName:  "getPendingParticipantId", args:  System.Array.Empty<System.Object>()), turnStatus:  val_32, matchStatus:  5, variant:  val_30.Call<System.Int32>(methodName:  "getVariant", args:  System.Array.Empty<System.Object>()), version:  val_30.Call<System.Int32>(methodName:  "getVersion", args:  System.Array.Empty<System.Object>()), creationTime:  new System.DateTime() {dateData = val_24.dateData}, lastUpdateTime:  new System.DateTime() {dateData = val_27.dateData});
            return (GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch)val_30;
        }
        internal static System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> ToParticipantList(UnityEngine.AndroidJavaObject turnBasedMatch)
        {
            System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> val_14;
            int val_15;
            var val_16;
            var val_17;
            var val_18;
            UnityEngine.AndroidJavaObject val_2 = turnBasedMatch.Call<UnityEngine.AndroidJavaObject>(methodName:  "getParticipantIds", args:  System.Array.Empty<System.Object>());
            val_14 = null;
            val_14 = new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>();
            if((val_2.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>())) >= 1)
            {
                    object val_16 = 0;
                val_15 = 0;
                var val_13 = 0;
            }
            else
            {
                    val_16 = 0;
                val_17 = 0;
                val_18 = 0 + 1;
                mem2[0] = 146;
                if(val_2 == null)
            {
                
            }
            else
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_2.Dispose();
            }
            
                if(val_13 != 1)
            {
                    if( == 0)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>);
            }
            
                if((val_13 + ((0 + 1)) << 2) == 146)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>);
            }
            
                return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>);
            }
            
                if( != 0)
            {
                    return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>);
            }
            
                return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>);
            }
        
        }
        internal static System.Collections.Generic.List<string> ToStringList(UnityEngine.AndroidJavaObject stringList)
        {
            var val_7;
            if(stringList == null)
            {
                goto label_1;
            }
            
            int val_2 = stringList.Call<System.Int32>(methodName:  "size", args:  System.Array.Empty<System.Object>());
            System.Collections.Generic.List<System.String> val_3 = null;
            val_7 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>(capacity:  val_2);
            if(val_2 < 1)
            {
                    return (System.Collections.Generic.List<System.String>)val_7;
            }
            
            object val_7 = 0;
            label_10:
            object[] val_4 = new object[1];
            if(val_4 == null)
            {
                goto label_3;
            }
            
            if(val_7 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_7 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_4[0] = val_7;
            val_3.Add(item:  stringList.Call<System.String>(methodName:  "get", args:  val_4));
            val_7 = val_7 + 1;
            if(val_2 != val_7)
            {
                goto label_10;
            }
            
            return (System.Collections.Generic.List<System.String>)val_7;
            label_1:
            System.Collections.Generic.List<System.String> val_6 = null;
            val_7 = val_6;
            val_6 = new System.Collections.Generic.List<System.String>();
            return (System.Collections.Generic.List<System.String>)val_7;
        }
        internal static UnityEngine.AndroidJavaObject ToJavaStringList(System.Collections.Generic.List<string> list)
        {
            var val_7;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "java.util.ArrayList", args:  System.Array.Empty<System.Object>());
            val_7 = 0;
            goto label_1;
            label_11:
            object[] val_3 = new object[1];
            string val_4 = list.Item[0];
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_3[0] = val_4;
            bool val_5 = val_2.Call<System.Boolean>(methodName:  "add", args:  val_3);
            val_7 = 1;
            label_1:
            if(val_7 < list.Count)
            {
                goto label_11;
            }
            
            return val_2;
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus ToMatchStatus(int matchStatus)
        {
            if(matchStatus > 5)
            {
                    return 5;
            }
            
            return (MatchStatus)106049152 + (matchStatus) << 2;
        }
        internal static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus ToMatchTurnStatus(int matchTurnStatus)
        {
            if(matchTurnStatus > 3)
            {
                    return 4;
            }
            
            return (MatchTurnStatus)106049176 + (matchTurnStatus) << 2;
        }
        public AndroidJavaConverter()
        {
        
        }
    
    }

}
