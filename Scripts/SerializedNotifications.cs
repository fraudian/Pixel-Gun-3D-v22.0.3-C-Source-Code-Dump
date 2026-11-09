using UnityEngine;
[Serializable]
internal class SerializedNotifications
{
    // Fields
    internal System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct> notificationFlags;
    
    // Methods
    public SerializedNotifications()
    {
        this.notificationFlags = new System.Collections.Generic.Dictionary<ClanNotificationType, NotificationResponseStruct>();
    }

}
