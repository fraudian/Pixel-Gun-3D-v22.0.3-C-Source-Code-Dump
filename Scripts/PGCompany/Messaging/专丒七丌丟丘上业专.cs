using UnityEngine;

namespace PGCompany.Messaging
{
    internal sealed class 专丒七丌丟丘上业专
    {
        // Fields
        private static PGCompany.Messaging.专丒七丌丟丘上业专 世丒丞七专三与万丕;
        private static string 一丘丘丏业丌丄丕丘;
        private static string 丅丗丟万丌丒丗丁丐;
        private string 上丟丅三丑下丙万丐;
        private readonly System.Net.Http.HttpClient <丏上丄丌万丈丄丐丟>k__BackingField;
        
        // Properties
        internal static PGCompany.Messaging.专丒七丌丟丘上业专 丆丕丝丒不丙且丐丗 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        private static string 丝业且世丙三七丞丛 { get; }
        private static string 业业丂不业丁丒业丟 { get; }
        internal string 丅万东丘丝丐丕世丟 { get; }
        private System.Net.Http.HttpClient 丈丕丒专三且丂与丗 { get; }
        
        // Methods
        private 专丒七丌丟丘上业专(System.Net.Http.HttpClient 专丒丌与丗丗丐东丛)
        {
            this.<丏上丄丌万丈丄丐丟>k__BackingField = 专丒丌与丗丗丐东丛;
        }
        internal static PGCompany.Messaging.专丒七丌丟丘上业专 丑七不且上丗丁一世()
        {
            if(PGCompany.Messaging.专丒七丌丟丘上业专.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Messaging.专丒七丌丟丘上业专 val_1 = PGCompany.Messaging.专丒七丌丟丘上业专.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "Instance");
            PGCompany.Messaging.专丒七丌丟丘上业专.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private static string 丕东东丄丗业与万丆()
        {
            string val_3;
            if(PGCompany.Messaging.专丒七丌丟丘上业专.一丘丘丏业丌丄丕丘 != null)
            {
                    return val_2;
            }
            
            val_3 = PGCompany.Messaging.专丒七丌丟丘上业专.七世丛丂丑丄丑丏丏();
            string val_2 = System.IO.Path.Combine(path1:  val_3, path2:  "token-sent.txt");
            PGCompany.Messaging.专丒七丌丟丘上业专.一丘丘丏业丌丄丕丘 = val_2;
            return val_2;
        }
        private static string 七世丛丂丑丄丑丏丏()
        {
            if(PGCompany.Messaging.专丒七丌丟丘上业专.丅丗丟万丌丒丗丁丐 != null)
            {
                    return val_1;
            }
            
            string val_1 = PGCompany.Messaging.专丒七丌丟丘上业专.丞丟丒丏丙丟丙丈丕();
            PGCompany.Messaging.专丒七丌丟丘上业专.丅丗丟万丌丒丗丁丐 = val_1;
            return val_1;
        }
        internal string 一丆不上丞丞专丒丞()
        {
            return (string)this.上丟丅三丑下丙万丐;
        }
        private System.Net.Http.HttpClient 丑丒世丙丟一丟世丙()
        {
            return (System.Net.Http.HttpClient)this.<丏上丄丌万丈丄丐丟>k__BackingField;
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            if(PGCompany.Messaging.专丒七丌丟丘上业专.世丒丞七专三与万丕 != null)
            {
                    return;
            }
            
            PGCompany.Messaging.专丒七丌丟丘上业专.世丒丞七专三与万丕 = PGCompany.Messaging.专丒七丌丟丘上业专.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "EnsureInitialized");
        }
        private static PGCompany.Messaging.专丒七丌丟丘上业专 东丝七业丄丑丒世七(string 与丗丆丏丙丟与丒业)
        {
            if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FirebaseMessagingFacade.Create] caller: "("[FirebaseMessagingFacade.Create] caller: ") + 与丗丆丏丙丟与丒业 + ", userId: "(", userId: ") + PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三());
            }
            
            PGCompany.Messaging.专丒七丌丟丘上业专 val_5 = new PGCompany.Messaging.专丒七丌丟丘上业专();
            .<丏上丄丌万丈丄丐丟>k__BackingField = new System.Net.Http.HttpClient();
            if(PGCompany.丗业丐丕世业丘丆上.世下世丁且丅业丕万() != false)
            {
                    Firebase.Messaging.FirebaseMessaging.add_TokenReceived(value:  new System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs>(object:  val_5, method:  System.Void PGCompany.Messaging.专丒七丌丟丘上业专::东丙丝丈世丒七丈丕(object 不丟丗丏丛丕不丁丌, Firebase.Messaging.TokenReceivedEventArgs 丗丛不丁丑专专丂且)));
                Firebase.Messaging.FirebaseMessaging.add_MessageReceived(value:  new System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs>(object:  val_5, method:  System.Void PGCompany.Messaging.专丒七丌丟丘上业专::不东丏与业丁丁东下(object 不丟丗丏丛丕不丁丌, Firebase.Messaging.MessageReceivedEventArgs 丗丛不丁丑专专丂且)));
            }
            
            UnityEngine.Coroutine val_11 = CoroutineRunner.Instance.StartCoroutine(routine:  val_5.丝丕下丏丈丒丒丄一());
            return val_5;
        }
        private static string 丞丟丒丏丙丟丙丈丕()
        {
            int val_12;
            object val_13;
            string val_3 = 0;
            string val_4 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    val_12 = UnityEngine.Application.persistentDataPath;
                if(val_12 != null)
            {
                    return (string)val_12;
            }
            
                val_12 = System.String.alignConst;
                return (string)val_12;
            }
            
            if((PGCompany.丗丑三与专且丘丏世.丒丐丞丂丑东丌三丞(世万丘丛万丕丘世丒: out  val_3, 丏丞专丏业丗丝七丝: out  val_4)) != false)
            {
                    if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FirebaseMessagingFacade.GetTokenDirNameOrFallback] filesDirName: "("[FirebaseMessagingFacade.GetTokenDirNameOrFallback] filesDirName: ") + val_3);
            }
            
                val_12 = val_3;
                return (string)val_12;
            }
            
            val_12 = UnityEngine.Application.persistentDataPath;
            if(val_12 == null)
            {
                    val_12 = System.String.alignConst;
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  val_4)) != false)
            {
                    val_13 = "[FirebaseMessagingFacade.GetTokenDirNameOrFallback] TryGetFilesDirName: false, fallback: "("[FirebaseMessagingFacade.GetTokenDirNameOrFallback] TryGetFilesDirName: false, fallback: ") + val_12;
            }
            else
            {
                    val_13 = "[FirebaseMessagingFacade.GetTokenDirNameOrFallback] TryGetFilesDirName: false, fallback: "("[FirebaseMessagingFacade.GetTokenDirNameOrFallback] TryGetFilesDirName: false, fallback: ") + val_12 + ", explanation: "(", explanation: ") + val_4;
            }
            
            UnityEngine.Debug.LogWarning(message:  val_13);
            return (string)val_12;
        }
        internal void 丄不专丘三丗丛丂七()
        {
            string val_14 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            if((System.String.IsNullOrWhiteSpace(value:  val_14 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三())) != false)
            {
                    val_14 = System.IO.File.Exists(path:  PGCompany.Messaging.专丒七丌丟丘上业专.丕东东丄丗业与万丆());
                if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FirebaseMessagingFacade.InvalidateKnownToken] KnownTokenFilePath: "("[FirebaseMessagingFacade.InvalidateKnownToken] KnownTokenFilePath: ") + PGCompany.Messaging.专丒七丌丟丘上业专.丕东东丄丗业与万丆() + ", exists: "(", exists: ") + val_14.ToString(provider:  PGCompany.Messaging.专丒七丌丟丘上业专.丙专丝世不业下丂丈())(val_14.ToString(provider:  PGCompany.Messaging.专丒七丌丟丘上业专.丙专丝世不业下丂丈())));
                val_14 = val_14;
            }
            
                if(val_14 == false)
            {
                    return;
            }
            
                System.IO.File.Delete(path:  PGCompany.Messaging.专丒七丌丟丘上业专.丕东东丄丗业与万丆());
                return;
            }
            
            if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FirebaseMessagingFacade.InvalidateKnownToken] Deleting token metadata. playerId: "("[FirebaseMessagingFacade.InvalidateKnownToken] Deleting token metadata. playerId: ") + val_14);
            }
            
            PGCompany.Messaging.上丒专丆世一丅丅一.丙丗丂丑丘丞业丙世(丄丒且丙三丆丟与丏:  val_14);
        }
        internal void 业东丝丘丛丁不丏丞()
        {
            UnityEngine.Coroutine val_3 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丝丕下丏丈丒丒丄一());
        }
        internal bool 丘下丛上丑丌丌丌丑(out string 不丒三业下丑不丞业)
        {
            不丒三业下丑不丞业 = this.上丟丅三丑下丙万丐;
            return (bool)(this.上丟丅三丑下丙万丐 != null) ? 1 : 0;
        }
        private void 东丙丝丈世丒七丈丕(object 不丟丗丏丛丕不丁丌, Firebase.Messaging.TokenReceivedEventArgs 丗丛不丁丑专专丂且)
        {
            string val_1 = 丗丛不丁丑专专丂且.Token;
            if(val_1 != null)
            {
                    if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FirebaseMessagingFacade.OnTokenReceived] token: "("[FirebaseMessagingFacade.OnTokenReceived] token: ") + val_1);
            }
            
                this.上丟丅三丑下丙万丐 = val_1;
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[FirebaseMessagingFacade.OnTokenReceived] token: null");
        }
        private void 不东丏与业丁丁东下(object 不丟丗丏丛丕不丁丌, Firebase.Messaging.MessageReceivedEventArgs 丗丛不丁丑专专丂且)
        {
            object val_81;
            object val_82;
            string val_83;
            string val_84;
            val_82 = 丗丛不丁丑专专丂且.Message;
            if(val_82 != null)
            {
                    if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() != false)
            {
                    System.Text.StringBuilder val_4 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  24).Append(value:  "[FirebaseMessagingFacade.OnMessageReceived]");
                System.Text.StringBuilder val_7 = val_4.Append(value:  " MessageId: "(" MessageId: ") + val_82.MessageId);
                System.Text.StringBuilder val_10 = val_4.Append(value:  ", MessageType: "(", MessageType: ") + val_82.MessageType);
                System.Text.StringBuilder val_13 = val_4.Append(value:  ", Priority: "(", Priority: ") + val_82.Priority);
                System.Text.StringBuilder val_16 = val_4.Append(value:  ", From: "(", From: ") + val_82.From);
                System.Text.StringBuilder val_19 = val_4.Append(value:  ", To: "(", To: ") + val_82.To);
                System.Text.StringBuilder val_22 = val_4.Append(value:  ", CollapseKey: "(", CollapseKey: ") + val_82.CollapseKey);
                System.Text.StringBuilder val_28 = val_4.Append(value:  ", NotificationOpened: "(", NotificationOpened: ") + val_82.NotificationOpened.ToString(provider:  PGCompany.Messaging.专丒七丌丟丘上业专.丙专丝世不业下丂丈())(val_82.NotificationOpened.ToString(provider:  PGCompany.Messaging.专丒七丌丟丘上业专.丙专丝世不业下丂丈())));
                System.TimeSpan val_29 = val_82.TimeToLive;
                System.Globalization.CultureInfo val_30 = PGCompany.Messaging.专丒七丌丟丘上业专.丙专丝世不业下丂丈();
                System.Text.StringBuilder val_32 = val_4.Append(value:  ", TimeToLive: "(", TimeToLive: ") + val_29._ticks);
                System.Text.StringBuilder val_35 = val_4.Append(value:  System.String.Format(format:  ", {0}: {1}", arg0:  "Link", arg1:  val_82.Link));
                if(val_82.Error != null)
            {
                    System.Text.StringBuilder val_39 = val_4.Append(value:  ", Error: "(", Error: ") + val_82.Error);
            }
            
                if(val_82.ErrorDescription != null)
            {
                    System.Text.StringBuilder val_43 = val_4.Append(value:  ", ErrorDescription: "(", ErrorDescription: ") + val_82.ErrorDescription);
            }
            
                val_83 = System.String.Format(format:  ", {0}: {1}", arg0:  "RawData", arg1:  val_82.RawData);
                System.Text.StringBuilder val_46 = val_4.Append(value:  val_83);
                val_81 = PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_4);
                UnityEngine.Debug.Log(message:  val_81);
            }
            
                if(PGCompany.Messaging.专丒七丌丟丘上业专.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
                val_82 = val_82.Notification;
                if(val_82 == null)
            {
                    return;
            }
            
                System.Text.StringBuilder val_51 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  24).Append(value:  "[FirebaseMessagingFacade.OnMessageReceived]");
                System.Text.StringBuilder val_54 = val_51.Append(value:  " Title: "(" Title: ") + val_82.Title);
                System.Text.StringBuilder val_57 = val_51.Append(value:  ", Body: "(", Body: ") + val_82.Body);
                System.Text.StringBuilder val_60 = val_51.Append(value:  ", Badge: "(", Badge: ") + val_82.Badge);
                System.Text.StringBuilder val_63 = val_51.Append(value:  ", Color: "(", Color: ") + val_82.Color);
                System.Text.StringBuilder val_66 = val_51.Append(value:  ", Tag: "(", Tag: ") + val_82.Tag);
                System.Text.StringBuilder val_69 = val_51.Append(value:  ", ClickAction: "(", ClickAction: ") + val_82.ClickAction);
                Firebase.Messaging.AndroidNotificationParams val_70 = val_82.Android;
                val_84 = 0;
                if(val_70 != null)
            {
                    val_84 = val_70.ChannelId;
            }
            
                System.Text.StringBuilder val_73 = val_51.Append(value:  ", ChannelId: "(", ChannelId: ") + val_84);
                val_83 = ", Icon: "(", Icon: ") + val_82.Icon;
                System.Text.StringBuilder val_76 = val_51.Append(value:  val_83);
                System.Text.StringBuilder val_79 = val_51.Append(value:  ", Sound: "(", Sound: ") + val_82.Sound);
                val_82 = PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_51);
                UnityEngine.Debug.Log(message:  val_82);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  "[FirebaseMessagingFacade.OnMessageReceived] message: null");
        }
        private System.Collections.IEnumerator 丝丕下丏丈丒丒丄一()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 专丒七丌丟丘上业专.丐丏世丛丒丆丆东不();
        }
        private System.Collections.IEnumerator 丈丗丞上丞丞丂下丈(string 丄丒且丙三丆丟与丏, System.DateTime 一丏一世丘丐丁丄丟, string 丞丞丐丝丝丏丐丛丞, int 三世东丅丁世且专不, string 不丒三业下丑不丞业, string 丐丒一专丆丌丏世业)
        {
            专丒七丌丟丘上业专.丏三不丆三专七七七 val_1 = new 专丒七丌丟丘上业专.丏三不丆三专七七七();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丄丒且丙三丆丟与丏 = 丄丒且丙三丆丟与丏;
                .一丏一世丘丐丁丄丟 = 一丏一世丘丐丁丄丟;
                .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
                .丞丞丐丝丝丏丐丛丞 = 丞丞丐丝丝丏丐丛丞;
                .三世东丅丁世且专不 = 三世东丅丁世且专不;
            }
            else
            {
                    mem[40] = 丄丒且丙三丆丟与丏;
                mem[80] = 一丏一世丘丐丁丄丟.dateData;
                mem[64] = 丞丞丐丝丝丏丐丛丞;
                mem[72] = 三世东丅丁世且专不;
                mem[56] = 不丒三业下丑不丞业;
            }
            
            .丐丒一专丆丌丏世业 = 丐丒一专丆丌丏世业;
            return (System.Collections.IEnumerator)val_1;
        }
    
    }

}
