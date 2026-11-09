using UnityEngine;

namespace BestHTTP.SocketIO.Events
{
    public static class EventNames
    {
        // Fields
        public const string Connect = "connect";
        public const string Disconnect = "disconnect";
        public const string Event = "event";
        public const string Ack = "ack";
        public const string Error = "error";
        public const string BinaryEvent = "binaryevent";
        public const string BinaryAck = "binaryack";
        private static string[] SocketIONames;
        private static string[] TransportNames;
        private static string[] BlacklistedEvents;
        
        // Methods
        public static string GetNameFor(BestHTTP.SocketIO.SocketIOEventTypes type)
        {
            null = null;
            BestHTTP.SocketIO.SocketIOEventTypes val_1 = type + 1;
            System.String[] val_2 = BestHTTP.SocketIO.Events.EventNames.SocketIONames + (((long)(int)((type + 1))) << 3);
            return (string)(BestHTTP.SocketIO.Events.EventNames.SocketIONames + ((long)(int)((type + 1))) << 3) + 32;
        }
        public static string GetNameFor(BestHTTP.SocketIO.TransportEventTypes transEvent)
        {
            null = null;
            BestHTTP.SocketIO.TransportEventTypes val_1 = transEvent + 1;
            System.String[] val_2 = BestHTTP.SocketIO.Events.EventNames.TransportNames + (((long)(int)((transEvent + 1))) << 3);
            return (string)(BestHTTP.SocketIO.Events.EventNames.TransportNames + ((long)(int)((transEvent + 1))) << 3) + 32;
        }
        public static bool IsBlacklisted(string eventName)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_2 = 0;
            label_9:
            val_2 = null;
            val_2 = null;
            if(val_2 >= BestHTTP.SocketIO.Events.EventNames.BlacklistedEvents.Length)
            {
                goto label_4;
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = val_2 + 1;
            if((System.String.Compare(strA:  BestHTTP.SocketIO.Events.EventNames.BlacklistedEvents.Length + 32, strB:  eventName, comparisonType:  5)) != 0)
            {
                goto label_9;
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_4:
            val_4 = 0;
            return (bool)val_4;
        }
        private static EventNames()
        {
            string[] val_1 = new string[8];
            val_1[0] = "unknown";
            val_1[1] = "connect";
            val_1[2] = "disconnect";
            val_1[3] = "event";
            val_1[4] = "ack";
            val_1[5] = "error";
            val_1[6] = "binaryevent";
            val_1[7] = "binaryack";
            BestHTTP.SocketIO.Events.EventNames.SocketIONames = val_1;
            string[] val_2 = new string[8];
            val_2[0] = "unknown";
            val_2[1] = "open";
            val_2[2] = "close";
            val_2[3] = "ping";
            val_2[4] = "pong";
            val_2[5] = "message";
            val_2[6] = "upgrade";
            val_2[7] = "noop";
            BestHTTP.SocketIO.Events.EventNames.TransportNames = val_2;
            string[] val_3 = new string[10];
            val_3[0] = "connect";
            val_3[1] = "connect_error";
            val_3[2] = "connect_timeout";
            val_3[3] = "disconnect";
            val_3[4] = "error";
            val_3[5] = "reconnect";
            val_3[6] = "reconnect_attempt";
            val_3[7] = "reconnect_failed";
            val_3[8] = "reconnect_error";
            val_3[9] = "reconnecting";
            BestHTTP.SocketIO.Events.EventNames.BlacklistedEvents = val_3;
        }
    
    }

}
