using UnityEngine;

namespace PGCompany
{
    public class NewsLobbyController : PGBehaviour
    {
        // Fields
        private const int 三三上丕丌丕丆东丈 = 23;
        public UIGrid newsGrid;
        public UIScrollView newsScroll;
        public UIScrollView fullNewsScroll;
        internal UnityEngine.GameObject RewardItemPrefab;
        private System.Collections.Generic.List<MailBoxFullContent> MailBoxFullContents;
        internal int 丁且丟丕丛一东丙丞;
        private MailBoxFullContent 丑丂丘丈万业丂丞丒;
        private 丏不一丏丗丗丗丈丞 丛丞丟且丕丆丙丐丘;
        private MailBoxScrollItem 丛丂东丅与东丝丟丕;
        internal static int MaxShowElements;
        internal UnityEngine.GameObject SettingsWindow;
        internal Rilisoft.ButtonHandler ShowSettingWindowButton;
        private System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, UnityEngine.Texture> 与专业丏丟专三且丝;
        public string currentURL;
        public string currentNewsName;
        public string currentSubscribeURL;
        private bool 丝丒且万万不业丛与;
        public UnityEngine.GameObject newsItemPrefab;
        public UnityEngine.GameObject urlButton;
        internal UIGrid GridShareButtons;
        public System.Collections.Generic.List<MailBoxScrollItem> mailBoxItems;
        internal System.Collections.Generic.List<ShareButtonMailbox> ShareButtons;
        internal System.Collections.Generic.List<丗不专世丑七万丞与> 丅丙下丈一专万不丆;
        private bool 丙丄七丂丝丂丗丈丙;
        private Rilisoft.丝丑丂丛万丐丈丘且 上一与丝丟业丞丙一;
        private System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, string> 丘丟丄丌丁世丞业丆;
        private System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, string> 与丕丏七七业东世丙;
        private System.Collections.Generic.List<CellMailBoxReward> 业世且丒丝三三万与;
        private UnityEngine.Texture2D[] 一丘丐丌三一上丁丝;
        internal static PGCompany.NewsLobbyController 丄丞丁丈与业上丞丟;
        private string 丛丑丙丗丞丝丘且丞;
        private UnityEngine.Coroutine 丌七丕丕丐丝丝且世;
        
        // Properties
        private MailBoxFullContent 丛丅不丄丆七七上丗 { get; }
        
        // Methods
        private MailBoxFullContent 三业七丗丂丑与丆丗()
        {
            var val_3;
            var val_4;
            var val_8;
            if(this.丑丂丘丈万业丂丞丒 != 0)
            {
                    return (MailBoxFullContent)this.丑丂丘丈万业丂丞丒;
            }
            
            List.Enumerator<T> val_2 = this.MailBoxFullContents.GetEnumerator();
            val_8 = 0;
            goto label_14;
            label_15:
            string val_5 = val_4.丐丏七丌丕丗业且上();
            一丗不丈丒万丂下丑 val_6 = 丒丁三上丂丅丌丈丁.丕丌丙丘下丘与丕丟();
            if(val_6 < val_3)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
            }
            else
            {
                    if(val_6 <= val_8)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  false);
            }
            else
            {
                    this.丑丂丘丈万业丂丞丒 = val_5;
                val_8 = val_6;
            }
            
            }
            
            label_14:
            if((2068091888 & 1) != 0)
            {
                goto label_15;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丑丂丘丈万业丂丞丒, 丏业丟一东丂东丘丛:  true);
            return (MailBoxFullContent)this.丑丂丘丈万业丂丞丒;
        }
        internal string 三七且丗丗丕丞丙丆(下丙丟上丂与东丂专 万世丆万丙丙丅七东)
        {
            if((this.丘丟丄丌丁世丞业丆.ContainsKey(key:  万世丆万丙丙丅七东)) == false)
            {
                    return "None";
            }
            
            return this.与丕丏七七业东世丙.Item[万世丆万丙丙丅七东] + I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  this.丘丟丄丌丁世丞业丆.Item[万世丆万丙丙丅七东])(I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  this.丘丟丄丌丁世丞业丆.Item[万世丆万丙丙丅七东])) + "[-]"("[-]");
        }
        private void Awake()
        {
            null = null;
            PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟 = this;
            this.ShowSettingWindowButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void PGCompany.NewsLobbyController::ShowSettingsWindow(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        internal UnityEngine.Texture 丘丑丟七业丟丕东丌(下丙丟上丂与东丂专 万世丆万丙丙丅七东)
        {
            下丙丟上丂与东丂专 val_9;
            UnityEngine.Texture val_10;
            val_9 = 万世丆万丙丙丅七东;
            if(val_9 == 0)
            {
                goto label_1;
            }
            
            bool val_1 = this.与专业丏丟专三且丝.ContainsKey(key:  val_9);
            if(val_1 != false)
            {
                    if(this.与专业丏丟专三且丝.Item[val_9] != 0)
            {
                    val_10 = this.与专业丏丟专三且丝.Item[val_9];
                return val_10;
            }
            
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_9 = null;
            val_10 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "MailBox/mailbox_"("MailBox/mailbox_") + val_9.ToString().ToLower() + "_icon");
            if(this.与专业丏丟专三且丝 == null)
            {
                goto label_13;
            }
            
            if(val_1 == false)
            {
                goto label_14;
            }
            
            label_17:
            this.与专业丏丟专三且丝.set_Item(key:  val_9, value:  val_10);
            return val_10;
            label_1:
            val_10 = 0;
            return val_10;
            label_13:
            if(val_1 == true)
            {
                goto label_17;
            }
            
            label_14:
            this.与专业丏丟专三且丝.Add(key:  val_9, value:  val_10);
            return val_10;
        }
        internal static string 丁世丛丘丘丟专丅丟()
        {
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            val_8 = null;
            val_9 = System.String.alignConst;
            val_8 = null;
            if(MailBoxMultiController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_10 = null;
                val_10 = null;
                MailBoxMultiController val_8 = MailBoxMultiController.丄丞丁丈与业上丞丟;
                object val_2 = val_8.丄一丅与丅丄丆丈与(丟丞东丄七丕丑丆丙:  MailBoxMultiController.东专丐三丘丛丗丆丝);
                if(val_2 != null)
            {
                    val_8 = (null == null) ? (val_2) : 0;
            }
            else
            {
                    val_9 = 0;
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == false)
            {
                goto label_13;
            }
            
            Progress.丘东丅丌东丒上七丁 val_9 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
            object val_5 = val_9.东且丛且业丗丑丙丗(下上丐丆丝丟丝丒不:  92);
            if(val_5 == null)
            {
                goto label_17;
            }
            
            val_9 = (null == null) ? (val_5) : 0;
            return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9 = 0)) != true) ? "0000" : (val_9);
            label_13:
            val_11 = val_9;
            return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != true) ? "0000" : (val_9);
            label_17:
            return (string)((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != true) ? "0000" : (val_9);
        }
        internal static bool 世丕丐丘不不万丈专(下丙丟上丂与东丂专 万世丆万丙丙丅七东, string 丏上丆丗丄丟七丄丙 = "")
        {
            string val_6;
            var val_7;
            val_6 = 丏上丆丗丄丟七丄丙;
            if((System.String.op_Equality(a:  val_6, b:  System.String.alignConst)) != false)
            {
                    val_6 = PGCompany.NewsLobbyController.丁世丛丘丘丟专丅丟();
            }
            
            if(万世丆万丙丙丅七东 <= 5)
            {
                    var val_6 = 106029456 + (万世丆万丙丙丅七东) << 2;
                val_6 = val_6 + 106029456;
            }
            else
            {
                    val_7 = 1;
                return (bool)((System.Convert.ToInt32(value:  Chars[2])) == 0) ? 1 : 0;
            }
        
        }
        internal static void 三丏七上丗丂丂丆丆(int 丞丕东上丞丑丑丗世, int 丗专与丐丌一专丒三, int 丌东丙丙业专丅丞与, int 丁东丗丄丁业专丛丂)
        {
            string val_5;
            var val_6;
            var val_7;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(丞丕东上丞丑丑丗世 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(丞丕东上丞丑丑丗世 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = 丞丕东上丞丑丑丗世;
            val_1[1] = 丗专与丐丌一专丒三;
            val_1[2] = 丌东丙丙业专丅丞与;
            val_1[3] = 丁东丗丄丁业专丛丂;
            string val_2 = System.String.Format(format:  "{0}{1}{2}{3}", args:  val_1);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  92, 丙业与丙丗丝不丈东:  val_2);
            val_5 = 1152921505080647680;
            val_6 = null;
            val_6 = null;
            if(MailBoxMultiController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            val_5 = MailBoxMultiController.东专丐三丘丛丗丆丝;
            MailBoxMultiController.丄丞丁丈与业上丞丟.七丕下丕丒丛万三丈(丟丞东丄七丕丑丆丙:  val_5, 丙业与丙丗丝不丈东:  val_2);
        }
        private System.Collections.IEnumerator 丙丗丂丐丂与三丙业(bool 七三丞丘丟下丛丛不 = False)
        {
            NewsLobbyController.一万上丂上丕丆下丂 val_1 = new NewsLobbyController.一万上丂上丕丆下丂();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .七三丞丘丟下丛丛不 = 七三丞丘丟下丛丛不;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丞丟丒丙上丗七丕丂()
        {
            goto label_1;
            label_6:
            this.mailBoxItems.Item[0].丒丏三东丆业七丗丁().Set(丏业丟一东丂东丘丛:  false);
            0 = 1;
            label_1:
            if(0 < this.mailBoxItems.Count)
            {
                goto label_6;
            }
            
            this.丝丒且万万不业丛与 = true;
            MailBoxScrollItem val_5 = this.mailBoxItems.Item[0];
            MailBoxScrollItem val_6 = this.mailBoxItems.Item[0];
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丛万丕丒上丌丂丝七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丑丅丂丞丞丙丐丁丌:  val_5.七丞与世丟丗丐丌丂, 丂丄丕一不世且丏丏:  val_6.丌世与丘丘下不丗专.ToString(), 丟丒丞丐丐丘丒丄东:  "lobby");
            this.mailBoxItems.Item[0].丒丏三东丆业七丗丁().Set(丏业丟一东丂东丘丛:  true);
        }
        private void 业丗丗丐七七丛丙万()
        {
            System.Collections.Generic.List<MailBoxScrollItem> val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            if(this.mailBoxItems.Count != 1)
            {
                goto label_2;
            }
            
            val_10 = this.mailBoxItems;
            val_11 = public MailBoxScrollItem System.Collections.Generic.List<MailBoxScrollItem>::get_Item(int index);
            goto label_4;
            label_2:
            val_12 = 0;
            val_13 = 0;
            goto label_5;
            label_13:
            MailBoxScrollItem val_2 = this.mailBoxItems.Item[0];
            val_14 = val_12;
            if(this.丁且丟丕丛一东丙丞 != val_2.丏三丐丙与丝丁丄丑)
            {
                    this.mailBoxItems.Item[0].丒丏三东丆业七丗丁().Set(丏业丟一东丂东丘丛:  false);
                val_14 = val_13;
            }
            
            val_12 = 1;
            val_13 = val_14;
            label_5:
            if(val_12 < this.mailBoxItems.Count)
            {
                goto label_13;
            }
            
            bool val_6 = 丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  0);
            if(this.mailBoxItems == null)
            {
                goto label_16;
            }
            
            if(val_6 == false)
            {
                goto label_17;
            }
            
            label_19:
            val_11 = public MailBoxScrollItem System.Collections.Generic.List<MailBoxScrollItem>::get_Item(int index);
            val_15 = val_13;
            goto label_18;
            label_16:
            if(val_6 == true)
            {
                goto label_19;
            }
            
            label_17:
            if(this.mailBoxItems.Count < 1)
            {
                    return;
            }
            
            val_10 = this.mailBoxItems;
            val_11 = public MailBoxScrollItem System.Collections.Generic.List<MailBoxScrollItem>::get_Item(int index);
            label_4:
            val_15 = 0;
            label_18:
            val_10.Item[0].丒丏三东丆业七丗丁().Set(丏业丟一东丂东丘丛:  true);
        }
        private void 上丈丂丁业且丏丞上()
        {
            if((丅且东丙业丏丛东丛.丑七不且上丗丁一世() != null) && (null != 0))
            {
                    丟丟与丒丒与丞七丈(丙丗丘丗丗丏业丝丟:  this.ShareButtons);
            }
            
            if(this.GridShareButtons == null)
            {
                
            }
        
        }
        private void 一丅世业与下丝丛丁()
        {
            if(this.GridShareButtons == null)
            {
                
            }
        
        }
        public void ShowSettingsWindow(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.SettingsWindow, 丏业丟一东丂东丘丛:  true);
        }
        private void OnEnable()
        {
            this.丛丘丗丟世丂一东一(七三丞丘丟下丛丛不:  false);
        }
        private void 与丌世东丑丆一丝丒()
        {
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_2 = MailBoxMessagesController.丄丞丁丈与业上丞丟.且丈丌不丐且丆丁专();
        }
        internal void 丛丘丗丟世丂一东一(bool 七三丞丘丟下丛丛不 = False)
        {
            if(this.丌七丕丕丐丝丝且世 != null)
            {
                    this.StopCoroutine(routine:  this.丌七丕丕丐丝丝且世);
            }
            
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丙丗丂丐丂与三丙业(七三丞丘丟下丛丛不:  七三丞丘丟下丛丛不));
        }
        private void OnDisable()
        {
            MailBoxFullContent val_1 = this.三业七丗丂丑与丆丗();
            if(val_1.newsPic != 0)
            {
                    MailBoxFullContent val_3 = this.三业七丗丂丑与丆丗();
                UnityEngine.Object.Destroy(obj:  val_3.newsPic);
                MailBoxFullContent val_4 = this.三业七丗丂丑与丆丗();
            }
            
            this.业不世上一丛专丁丟();
            this.丝丒且万万不业丛与 = false;
            this.丑丂丘丈万业丂丞丒 = 0;
        }
        private void 丌丈万丟丐丐丌下七()
        {
            if(MailBoxRewardController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            if(this.丙丄七丂丝丂丗丈丙 == false)
            {
                    return;
            }
            
            this.丙丄七丂丝丂丗丈丙 = false;
        }
        private void 业不世上一丛专丁丟()
        {
            this.与专业丏丟专三且丝 = new System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, UnityEngine.Texture>();
        }
        private void 三丞丐丐丆下且丐丑()
        {
            var val_19;
            var val_20;
            int val_21;
            int val_22;
            this.丅丙下丈一专万不丆.Clear();
            int val_1 = MailBoxMessagesController.丄丞丁丈与业上丞丟.下一丅专丌上且且下();
            val_19 = 0;
            goto label_3;
            label_14:
            if(val_19 >= MailBoxMessagesController.丄丞丁丈与业上丞丟.业丗与世东丗丒世专().Count)
            {
                goto label_6;
            }
            
            if(val_5.丂丄万业丝丆丐丆丂 != false)
            {
                    this.丅丙下丈一专万不丆.Add(item:  new 丗不专世丑七万丞与(丞世不丒下上上丝丑:  0));
                this.七丌业七专丗业不丑(业丌丆业丘丟丆丁丛:  0, 丑丑丞专丒丙丒东不:  MailBoxMessagesController.丄丞丁丈与业上丞丟.业丗与世东丗丒世专().Item[0]);
            }
            
            val_19 = 1;
            label_3:
            val_20 = null;
            val_20 = null;
            int val_19 = PGCompany.NewsLobbyController.MaxShowElements;
            val_19 = val_19 + val_1;
            if(val_19 < val_19)
            {
                goto label_14;
            }
            
            goto label_15;
            label_6:
            val_20 = null;
            label_15:
            val_20 = null;
            int val_20 = PGCompany.NewsLobbyController.MaxShowElements;
            val_20 = val_1 + val_20;
            val_21 = val_20 + 1;
            goto label_18;
            label_30:
            if(val_21 >= this.mailBoxItems.Count)
            {
                goto label_20;
            }
            
            MailBoxScrollItem val_8 = this.mailBoxItems.Item[val_21];
            if(val_8 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  val_8.gameObject);
            }
            
            this.mailBoxItems.RemoveAt(index:  val_21);
            val_21 = val_21 + 1;
            label_18:
            if((val_21 - 1) < this.mailBoxItems.Count)
            {
                goto label_30;
            }
            
            label_20:
            val_22 = this.mailBoxItems.Count;
            goto label_32;
            label_43:
            val_22 = val_22 - 1;
            if(this.mailBoxItems.Item[val_22] != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.mailBoxItems.Item[val_22].gameObject);
            }
            
            this.mailBoxItems.RemoveAt(index:  val_22);
            label_32:
            if(val_22 > this.丅丙下丈一专万不丆.Count)
            {
                goto label_43;
            }
        
        }
        private void 七丌业七专丗业不丑(int 业丌丆业丘丟丆丁丛, 丏不一丏丗丗丗丈丞 丑丑丞专丒丙丒东不)
        {
            int val_21;
            MailBoxMessagesController val_22;
            丏不一丏丗丗丗丈丞 val_23;
            UIGrid val_24;
            string val_25;
            string val_26;
            string val_27;
            string val_28;
            val_21 = 业丌丆业丘丟丆丁丛;
            object val_6 = 0;
            object val_9 = 0;
            val_22 = MailBoxMessagesController.丄丞丁丈与业上丞丟;
            MailBoxScrollItem val_1 = this.mailBoxItems.Item[val_21];
            if(丑丑丞专丒丙丒东不.TypeNews == 0)
            {
                goto label_3;
            }
            
            if(val_1 == null)
            {
                goto label_4;
            }
            
            val_1.丏三丐丙与丝丁丄丑 = 丑丑丞专丒丙丒东不.id;
            val_1.丌世与丘丘下不丗专 = 丑丑丞专丒丙丒东不.TypeNews;
            goto label_5;
            label_3:
            val_23 = 0;
            UnityEngine.Object.Destroy(obj:  this.mailBoxItems.Item[val_21].gameObject);
            val_24 = this.newsGrid;
            if(val_24 != null)
            {
                    return;
            }
            
            return;
            label_4:
            mem[160] = 丑丑丞专丒丙丒东不.id;
            mem[144] = 丑丑丞专丒丙丒东不.TypeNews;
            label_5:
            UnityEngine.Texture val_4 = this.丘丑丟七业丟丕东丌(万世丆万丙丙丅七东:  丑丑丞专丒丙丒东不.TypeNews);
            val_1.七丈万七丛丟丗丕三 = true;
            string val_5 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
            if((丑丑丞专丒丙丒东不.HeaderPreview.TryGetValue(key:  val_5, value: out  val_6)) != true)
            {
                    bool val_8 = 丑丑丞专丒丙丒东不.HeaderPreview.TryGetValue(key:  "English", value: out  val_6);
            }
            
            val_25 = val_5;
            if((丑丑丞专丒丙丒东不.ShortDescription.TryGetValue(key:  val_25, value: out  val_9)) != true)
            {
                    val_25 = "English";
                bool val_11 = 丑丑丞专丒丙丒东不.ShortDescription.TryGetValue(key:  val_25, value: out  val_9);
            }
            
            if(val_6 == 0)
            {
                goto label_21;
            }
            
            val_26 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) == false)
            {
                goto label_24;
            }
            
            label_21:
            val_26 = "English";
            bool val_13 = 丑丑丞专丒丙丒东不.HeaderPreview.TryGetValue(key:  val_26, value: out  val_6);
            label_24:
            if(val_9 != 0)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == false)
            {
                goto label_29;
            }
            
            }
            
            bool val_15 = 丑丑丞专丒丙丒东不.ShortDescription.TryGetValue(key:  "English", value: out  val_9);
            label_29:
            if(val_6 != 0)
            {
                    var val_16 = (1179403647 == null) ? (val_6) : 0;
            }
            else
            {
                    val_27 = 0;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_1.headerLabel, 丕丗丘丑丛与丑业丒:  val_27);
            if(val_9 != 0)
            {
                    var val_17 = (1179403647 == null) ? (val_9) : 0;
            }
            else
            {
                    val_28 = 0;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_1.shortDescLabel, 丕丗丘丑丛与丑业丒:  val_28);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_1.dateLabel, 丕丗丘丑丛与丑业丒:  val_1.shortDescLabel.且一丌业丙丗世一三(丑丙万一丏丅丁专丏:  丑丑丞专丒丙丒东不.Date, 丅丑丛丁下一丆七丟:  val_5));
            val_1.七丞与世丟丗丐丌丂 = 丑丑丞专丒丙丒东不.Date;
            val_21 = 丑丑丞专丒丙丒东不.id;
            if((val_22.专丗万丆世丂万下丛(丞丅上丏丂且下丅与:  val_21, 丏丄世丛丆丂丗丅丅:  丑丑丞专丒丙丒东不.toId)) != false)
            {
                    val_22 = 0;
            }
            else
            {
                    val_22 = PGCompany.NewsLobbyController.世丕丐丘不不万丈专(万世丆万丙丙丅七东:  丑丑丞专丒丙丒东不.TypeNews, 丏上丆丗丄丟七丄丙:  "");
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.indicatorNew, 丏业丟一东丂东丘丛:  val_22);
            val_23 = 丑丑丞专丒丙丒东不;
            val_1.indicatorNew.七东且丂丙丁三丟不(丄丙下丝丛丒七丂丘:  val_23, 丌丝万上丅丒一丈丘:  val_1);
            val_24 = val_1.gridIndicators;
            if(val_24 != null)
            {
                    return;
            }
        
        }
        private void 七东且丂丙丁三丟不(丏不一丏丗丗丗丈丞 丄丙下丝丛丒七丂丘, MailBoxScrollItem 丌丝万上丅丒一丈丘)
        {
            UnityEngine.GameObject val_16;
            UnityEngine.GameObject val_17;
            UnityEngine.GameObject val_18;
            var val_20;
            val_16 = 丌丝万上丅丒一丈丘;
            val_17 = 丌丝万上丅丒一丈丘.indicatorRewardChest;
            if(丄丙下丝丛丒七丂丘.三丐丑丛业丅东丕东() == false)
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  (~丄丙下丝丛丒七丂丘.东业东丆丂丝万丑下()) & 1);
            val_18 = 丌丝万上丅丒一丈丘.indicatorReward;
            goto label_7;
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  false);
            if(丄丙下丝丛丒七丂丘.TypeNews != 2)
            {
                goto label_11;
            }
            
            if((丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  2071585856)) == false)
            {
                goto label_14;
            }
            
            val_17 = ;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丌丝万上丅丒一丈丘.indicatorReward, 丏业丟一东丂东丘丛:  true);
            goto label_17;
            label_14:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丌丝万上丅丒一丈丘.indicatorReward, 丏业丟一东丂东丘丛:  false);
            label_11:
            val_17 = 0;
            label_17:
            if(((丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  0)) == false) || (丄丙下丝丛丒七丂丘.丝丆丆丗丞丒丒丝业() == false))
            {
                goto label_23;
            }
            
            string val_15 = "Gems";
            bool val_12 = 丄丙下丝丛丒七丂丘.丑丒丏三丆丗专丞丗().Item[0].PriceOfThisItem.东与三丌丅三丒丏业().Replace(oldValue:  "Currency", newValue:  System.String.alignConst).Equals(value:  val_15);
            val_15 = val_12;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丌丝万上丅丒一丈丘.indicatorTextureRewardGems, 丏业丟一东丂东丘丛:  val_15);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丌丝万上丅丒一丈丘.indicatorTextureRewardCoins, 丏业丟一东丂东丘丛:  (~val_12) & 1);
            val_16 = 丌丝万上丅丒一丈丘.indicatorReward;
            val_20 = MailBoxRewardController.丄丞丁丈与业上丞丟.一丈丄东丑丕丕丄业(丞丅上丏丂且下丅与:  0);
            val_18 = val_16;
            goto label_32;
            label_23:
            val_16 = 丌丝万上丅丒一丈丘.indicatorReward;
            val_18 = val_16;
            label_7:
            val_20 = 0;
            label_32:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  false);
        }
        public void GetRewardByMessgae()
        {
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            MailBoxChildFullContet val_3 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3.GetAllRewardButton, 丏业丟一东丂东丘丛:  false);
            MailBoxMessagesController.丄丞丁丈与业上丞丟.三丛丁丆东世丁丏三(上业丟世三与七七三:  this.丛丞丟且丕丆丙丐丘.丑丒丏三丆丗专丞丗(), 不丝丛丄世东七丒一:  this.上一与丝丟业丞丙一);
            this.丏丘七丑丕业丛一丈(丙业与丙丗丝不丈东:  true);
        }
        private void 万丝丟丆丗丐丙丗不()
        {
            if(this.丛丂东丅与东丝丟丕 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丛丂东丅与东丝丟丕.indicatorRewardChest, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丛丂东丅与东丝丟丕.indicatorNew, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丛丂东丅与东丝丟丕.indicatorReward, 丏业丟一东丂东丘丛:  false);
            if(this.丛丂东丅与东丝丟丕.gridIndicators == null)
            {
                
            }
        
        }
        private void 丏丘七丑丕业丛一丈(bool 丙业与丙丗丝不丈东)
        {
            System.Collections.Generic.List<CellMailBoxReward> val_5 = this.业世且丒丝三三万与;
            if(val_5.Count == 0)
            {
                    return;
            }
            
            val_5 = this.业世且丒丝三三万与;
            List.Enumerator<T> val_2 = val_5.GetEnumerator();
            label_6:
            if((2072119480 & 1) == 0)
            {
                goto label_4;
            }
            
            0.丐丏七丌丕丗业且上().丙丄东丆专三丛丙丅(丙专丗丂丄丐丟七专:  丙业与丙丗丝不丈东);
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(丙业与丙丗丝不丈东 != true)
            {
                    return;
            }
            
            this.万丝丟丆丗丐丙丗不();
        }
        private string 且一丌业丙丗世一三(long 丑丙万一丏丅丁专丏, string 丅丑丛丁下一丆七丟)
        {
            System.DateTime val_1 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  丑丙万一丏丅丁专丏);
            return 专七专下且专三一且.丞丄一丌丟业世丏七(且丆丝世上丐上不万:  new System.DateTime() {dateData = val_1.dateData}, 丞丞丐丝丝丏丐丛丞:  丅丑丛丁下一丆七丟);
        }
        private System.DateTime 丈下世七丂专东丁丆(int 丑丙万一丏丅丁专丏, string 丅丑丛丁下一丆七丟)
        {
            return 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  丑丙万一丏丅丁专丏);
        }
        public void OnURLClick()
        {
            丏不一丏丗丗丗丈丞 val_5;
            long val_6;
            if((System.String.IsNullOrEmpty(value:  this.currentURL)) == true)
            {
                    return;
            }
            
            if(this.丛丞丟且丕丆丙丐丘 == null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "Conversion Total", value:  "Source");
            null.Add(key:  "Conversion By News", value:  this.currentNewsName);
            Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "News", 丛东不丒丏丈丄且丕:  null);
            val_5 = this.丛丞丟且丕丆丙丐丘;
            if(val_5 != null)
            {
                    val_6 = this.丛丞丟且丕丆丙丐丘.Date;
            }
            else
            {
                    val_6 = this.丛丞丟且丕丆丙丐丘.Date;
                if(this.丛丞丟且丕丆丙丐丘 != null)
            {
                    val_5 = this.丛丞丟且丕丆丙丐丘;
            }
            else
            {
                    val_5 = 0;
            }
            
            }
            
            val_5 = val_5 + 40;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丛万丕丒上丌丂丝七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丑丅丂丞丞丙丐丁丌:  val_6, 丂丄丕一不世且丏丏:  val_5.ToString(), 丟丒丞丐丐丘丒丄东:  "read more");
            UnityEngine.Application.OpenURL(url:  this.currentURL);
        }
        public void OnSubscribeClick()
        {
            丏不一丏丗丗丗丈丞 val_4;
            long val_5;
            if((System.String.IsNullOrEmpty(value:  this.currentSubscribeURL)) == true)
            {
                    return;
            }
            
            if(MailBoxRewardController.丄丞丁丈与业上丞丟.丄丅丈丆丛三三世与 != false)
            {
                    return;
            }
            
            if(this.丛丞丟且丕丆丙丐丘 == null)
            {
                    return;
            }
            
            val_4 = this.丛丞丟且丕丆丙丐丘;
            if(val_4 != null)
            {
                    val_5 = this.丛丞丟且丕丆丙丐丘.Date;
            }
            else
            {
                    val_5 = this.丛丞丟且丕丆丙丐丘.Date;
                if(this.丛丞丟且丕丆丙丐丘 != null)
            {
                    val_4 = this.丛丞丟且丕丆丙丐丘;
            }
            else
            {
                    val_4 = 0;
            }
            
            }
            
            val_4 = val_4 + 40;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            PGCompany.Analytics.一业丗丆世世上丁且.丛万丕丒上丌丂丝七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丑丅丂丞丞丙丐丁丌:  val_5, 丂丄丕一不世且丏丏:  val_4.ToString(), 丟丒丞丐丐丘丒丄东:  "subscribe");
            MailBoxRewardController.丄丞丁丈与业上丞丟.丄丅丈丆丛三三世与 = true;
            UnityEngine.Application.OpenURL(url:  this.currentSubscribeURL);
        }
        private System.Collections.IEnumerator 业丆且万下世世丝丁(int 一业东下丝丛七丂丝, string 专丞上下一丙一丆丕)
        {
            NewsLobbyController.丄丌丞且丅丗不上三 val_1 = new NewsLobbyController.丄丌丞且丅丗不上三();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .一业东下丝丛七丂丝 = 一业东下丝丛七丂丝;
            }
            else
            {
                    mem[32] = this;
                mem[48] = 一业东下丝丛七丂丝;
            }
            
            .专丞上下一丙一丆丕 = 专丞上下一丙一丆丕;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丂丛丝丐丗丅丅丏丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new NewsLobbyController.丑丌不丝世且丘丆东();
        }
        private void 丑专业业丙丕丗三丟(string 丛丑万丁上丏专上下)
        {
            var val_9;
            var val_10;
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  UnityEngine.PlayerPrefs.GetString(key:  this.丛丑丙丗丞丝丘且丞, defaultValue:  "[]"));
            val_9 = 0;
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            val_10 = 0;
            goto label_4;
            label_9:
            val_4.Add(item:  Item[0]);
            val_10 = 1;
            label_4:
            if(val_10 < Count)
            {
                goto label_9;
            }
            
            if((val_4.Contains(item:  丛丑万丁上丏专上下)) != true)
            {
                    val_4.Add(item:  丛丑万丁上丏专上下);
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  this.丛丑丙丗丞丝丘且丞, value:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
        }
        internal void 万丒丐丌丄丌不丏丞(int 丞世不丒下上上丝丑, MailBoxScrollItem 世丁丒一丛不三丌丗)
        {
            UnityEngine.Object val_188;
            UIGrid val_189;
            string val_190;
            var val_191;
            bool val_192;
            string val_193;
            string val_194;
            var val_195;
            var val_196;
            var val_197;
            string val_198;
            string val_199;
            var val_200;
            var val_201;
            var val_202;
            SmartUiGrid val_203;
            var val_204;
            var val_205;
            UnityEngine.GameObject val_206;
            var val_207;
            var val_208;
            var val_209;
            var val_210;
            UnityEngine.GameObject val_211;
            bool val_212;
            string val_213;
            UnityEngine.Transform val_214;
            val_188 = 世丁丒一丛不三丌丗;
            val_189 = this;
            object val_49 = 0;
            object val_46 = 0;
            val_190 = 1152921505228464128;
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟.业丗与世东丗丒世专().Count == 0)
            {
                    return;
            }
            
            if(val_188 == 0)
            {
                    return;
            }
            
            this.丛丂东丅与东丝丟丕 = val_188;
            丏不一丏丗丗丗丈丞 val_6 = this.丅丙下丈一专万不丆.Item[丞世不丒下上上丝丑].丐东专丁三丙丟丆丅();
            MailBoxMessagesController.丄丞丁丈与业上丞丟.下丌东三丆丙且丌丕(丑丑丞专丒丙丒东不:  val_6);
            MailBoxFullContent val_7 = this.三业七丗丂丑与丆丗();
            val_7.不丟丌丅丁丅丛一丛 = false;
            if(val_6 != null)
            {
                    val_192 = val_6.丙丄与世丁丛丞业不();
                bool val_9 = val_6.东业东丆丂丝万丑下();
            }
            else
            {
                    val_192 = 0.丙丄与世丁丛丞业不();
                bool val_11 = 0.东业东丆丂丝万丑下();
            }
            
            if(val_6.三丐丑丛业丅东丕东() == true)
            {
                goto label_32;
            }
            
            MailBoxFullContent val_13 = this.三业七丗丂丑与丆丗();
            if(val_13.maxAspectRatio != 5)
            {
                goto label_19;
            }
            
            MailBoxFullContent val_15 = this.三业七丗丂丑与丆丗();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.SquareFullPicture)) == false)
            {
                goto label_23;
            }
            
            val_15.不丟丌丅丁丅丛一丛 = true;
            goto label_24;
            label_19:
            MailBoxFullContent val_17 = this.三业七丗丂丑与丆丗();
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.FullPicture)) == false)
            {
                goto label_28;
            }
            
            val_17.不丟丌丅丁丅丛一丛 = true;
            goto label_29;
            label_23:
            MailBoxFullContent val_18 = this.三业七丗丂丑与丆丗();
            val_18.不丟丌丅丁丅丛一丛 = false;
            goto label_32;
            label_28:
            val_17.不丟丌丅丁丅丛一丛 = false;
            MailBoxFullContent val_19 = this.三业七丗丂丑与丆丗();
            MailBoxFullContent val_20 = this.三业七丗丂丑与丆丗();
            mem2[0] = 1128792064;
            label_29:
            label_24:
            label_32:
            this.三业七丗丂丑与丆丗().与丑下丗丅东且丈丂(丙业与丙丗丝不丈东:  0);
            MailBoxChildFullContet val_23 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            if((val_11 | (~val_192)) != false)
            {
                
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_23.GetAllRewardButton, 丏业丟一东丂东丘丛:  val_6.七下业丈业丙丆上丌());
            MailBoxChildFullContet val_28 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_28.MailBoxAllButtons, 丏业丟一东丂东丘丛:  false);
            MailBoxChildFullContet val_30 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30.MailBoxUrlSingle, 丏业丟一东丂东丘丛:  false);
            MailBoxChildFullContet val_32 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_32.descOrMessageLabel, 丏业丟一东丂东丘丛:  true);
            MailBoxFullContent val_33 = this.三业七丗丂丑与丆丗();
            MailBoxFullContent val_34 = this.三业七丗丂丑与丆丗();
            val_33.newsPic.enabled = (val_34.不丟丌丅丁丅丛一丛 == true) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.urlButton, 丏业丟一东丂东丘丛:  false);
            MailBoxChildFullContet val_37 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            if(val_192 != false)
            {
                    bool val_39 = val_6.七下业丈业丙丆上丌();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_37.MessageRewardContainer, 丏业丟一东丂东丘丛:  false);
            this.丂丟丂丕丑业丄丒丈(丙业与丙丗丝不丈东:  val_6.三丐丑丛业丅东丕东());
            if((丞东丑专丛丆丄丝世.丂七丗丐世业丘丏不(丞丅上丏丂且下丅与:  this.丁且丟丕丛一东丙丞)) != true)
            {
                    if(this.丁且丟丕丛一东丙丞 == val_6.id)
            {
                goto label_64;
            }
            
            }
            
            this.fullNewsScroll.ResetPosition();
            SpringPanel val_43 = this.fullNewsScroll.GetComponent<SpringPanel>();
            val_191 = 0;
            val_43.target = 0;
            mem2[0] = val_191;
            mem2[0] = 0;
            if(val_43 != null)
            {
                    val_43.strength = 100000f;
            }
            else
            {
                    val_43.strength = 100000f;
            }
            
            val_43.enabled = true;
            label_64:
            this.丙丕丈丄万丝丂丏丕();
            if(this.丛丞丟且丕丆丙丐丘 != null)
            {
                    if(this.丛丞丟且丕丆丙丐丘.id == val_6.id)
            {
                goto label_72;
            }
            
            }
            
            MailBoxFullContent val_44 = this.三业七丗丂丑与丆丗();
            val_44.tweenAlphaFullScroll.PlayForward();
            label_72:
            this.丛丞丟且丕丆丙丐丘 = val_6;
            string val_45 = I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
            if((val_6.Header.TryGetValue(key:  val_45, value: out  val_46)) != true)
            {
                    bool val_48 = val_6.Header.TryGetValue(key:  "English", value: out  val_46);
            }
            
            if((val_6.Message.TryGetValue(key:  val_45, value: out  val_49)) != true)
            {
                    bool val_51 = val_6.Message.TryGetValue(key:  "English", value: out  val_49);
            }
            
            if(val_46 == 0)
            {
                goto label_84;
            }
            
            val_193 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) == false)
            {
                goto label_87;
            }
            
            label_84:
            val_193 = "English";
            bool val_53 = val_6.Header.TryGetValue(key:  val_193, value: out  val_46);
            label_87:
            if((val_49 != 0) && (val_49 != 0))
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_49)) != true)
            {
                    if((val_49.Equals(value:  "[news-pic]")) == false)
            {
                goto label_94;
            }
            
            }
            
            }
            
            bool val_56 = val_6.Message.TryGetValue(key:  "English", value: out  val_49);
            label_94:
            string val_57 = this.三七且丗丗丕丞丙丆(万世丆万丙丙丅七东:  val_6.TypeNews);
            MailBoxFullContent val_58 = this.三业七丗丂丑与丆丗();
            val_194 = val_46;
            if((val_194 != 0) && (1179403647 != null))
            {
                    val_194 = 0;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_58.headerLabel, 丕丗丘丑丛与丑业丒:  val_194);
            val_195 = val_49;
            string[] val_59 = new string[1];
            val_59[0] = "[news-pic]";
            if(val_195 == 0)
            {
                goto label_105;
            }
            
            if(1179403647 == null)
            {
                goto label_108;
            }
            
            val_195 = 0;
            goto label_108;
            label_105:
            label_108:
            System.String[] val_60 = val_195.Split(separator:  val_59, options:  0);
            val_196 = 1152921504624312320;
            if(val_60.Length >= 2)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6.FullPicture)) == false)
            {
                goto label_113;
            }
            
            }
            
            val_197 = val_49;
            if((val_197 != 0) && (1179403647 != null))
            {
                    val_197 = 0;
            }
            
            MailBoxChildFullContet val_63 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_63.descOrMessageLabel.text = val_197.Replace(oldValue:  "[news-pic]", newValue:  System.String.alignConst);
            val_198 = val_57;
            MailBoxChildFullContet val_66 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_199 = val_45;
            bool val_68 = val_66.descOrMessageLabel.text.Equals(value:  System.String.alignConst);
            MailBoxChildFullContet val_70 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            if(val_70.descOrMessageLabel == null)
            {
                goto label_126;
            }
            
            if(val_68 == false)
            {
                goto label_127;
            }
            
            label_129:
            val_200 = 0;
            goto label_128;
            label_126:
            if(val_68 == true)
            {
                goto label_129;
            }
            
            label_127:
            val_200 = 23;
            label_128:
            val_70.descOrMessageLabel.fontSize = 23;
            MailBoxFullContent val_71 = this.三业七丗丂丑与丆丗();
            if(val_71.desc2Label == 0)
            {
                goto label_193;
            }
            
            MailBoxFullContent val_73 = this.三业七丗丂丑与丆丗();
            label_197:
            val_73.desc2Label.text = "";
            goto label_193;
            label_113:
            MailBoxFullContent val_74 = this.三业七丗丂丑与丆丗();
            if(val_74.maxAspectRatio != 5)
            {
                goto label_138;
            }
            
            MailBoxChildFullContet val_76 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_76.descOrMessageLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            MailBoxChildFullContet val_79 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_79.descOrMessageLabel.text = val_60[0];
            MailBoxChildFullContet val_83 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_198 = val_57;
            val_199 = val_45;
            val_83.descOrMessageLabel.text = val_83.descOrMessageLabel.text + ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_60[0])) != true) ? "\n" : System.String.alignConst(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_60[0])) != true) ? "\n" : System.String.alignConst) + val_60[1];
            MailBoxFullContent val_86 = this.三业七丗丂丑与丆丗();
            val_196 = 1152921504624312320;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_86.desc2Label, 丕丗丘丑丛与丑业丒:  "");
            goto label_193;
            label_138:
            val_198 = val_57;
            MailBoxChildFullContet val_88 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_199 = val_45;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_88.descOrMessageLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            MailBoxChildFullContet val_91 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_91.descOrMessageLabel.text = val_60[0];
            MailBoxChildFullContet val_93 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            MailBoxChildFullContet val_97 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            if((val_93.descOrMessageLabel.text.Equals(value:  System.String.alignConst)) == false)
            {
                goto label_174;
            }
            
            val_97.descOrMessageLabel.fontSize = 0;
            MailBoxFullContent val_98 = this.三业七丗丂丑与丆丗();
            val_196 = 1152921504624312320;
            if(val_98.newsPic == 0)
            {
                goto label_186;
            }
            
            MailBoxFullContent val_100 = this.三业七丗丂丑与丆丗();
            mem2[0] = 0;
            goto label_186;
            label_174:
            val_97.descOrMessageLabel.fontSize = 23;
            MailBoxFullContent val_101 = this.三业七丗丂丑与丆丗();
            val_196 = 1152921504624312320;
            if(val_101.newsPic != 0)
            {
                    MailBoxFullContent val_103 = this.三业七丗丂丑与丆丗();
                mem2[0] = -15;
            }
            
            label_186:
            MailBoxFullContent val_104 = this.三业七丗丂丑与丆丗();
            if(val_104.desc2Label == 0)
            {
                goto label_193;
            }
            
            MailBoxFullContent val_106 = this.三业七丗丂丑与丆丗();
            string val_191 = val_60[1];
            if(val_106.desc2Label != null)
            {
                goto label_197;
            }
            
            goto label_197;
            label_193:
            this.上一与丝丟业丞丙一 = val_6.idReward;
            mem[1152921553925683176] = mem[282584257677015];
            System.DateTime val_107 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  val_6.Date);
            MailBoxFullContent val_108 = this.三业七丗丂丑与丆丗();
            val_201 = " / [-]";
            val_108.dateLabel.text = "[bababa]" + 专七专下且专三一且.丞丄一丌丟业世丏七(且丆丝世上丐上不万:  new System.DateTime() {dateData = val_107.dateData}, 丞丞丐丝丝丏丐丛丞:  val_199)(专七专下且专三一且.丞丄一丌丟业世丏七(且丆丝世上丐上不万:  new System.DateTime() {dateData = val_107.dateData}, 丞丞丐丝丝丏丐丛丞:  val_199)) + " / [-]"(" / [-]") + val_198;
            if((val_6.丑丒丏三丆丗专丞丗().Count < 1) || (val_6.七下业丈业丙丆上丌() == false))
            {
                goto label_204;
            }
            
            val_202 = 0;
            goto label_205;
            label_219:
            Rilisoft.OfferItem val_115 = val_6.丑丒丏三丆丗专丞丗().Item[0];
            if(val_115.Type != 1000)
            {
                    if(val_115.Type != 1010)
            {
                goto label_211;
            }
            
            }
            
            MailBoxChildFullContet val_119 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_203 = val_119.rewardCurrencyGrid;
            goto label_214;
            label_211:
            MailBoxChildFullContet val_121 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_203 = val_121.rewardGrid;
            label_214:
            this.丗丝丙且七七上世丞(丛七丛丆丏七丙与丛:  val_203, 丑且不丕与专丄业丙:  this.RewardItemPrefab, 丆丆丌专丌丗七丈与:  val_115, 上且丁上七丁上丄一:  val_11);
            val_202 = 1;
            label_205:
            if(val_202 < val_6.丑丒丏三丆丗专丞丗().Count)
            {
                goto label_219;
            }
            
            label_204:
            val_204 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.subscribedUrl)) != false)
            {
                    this.currentSubscribeURL = val_6.subscribedUrl;
            }
            else
            {
                    this.currentSubscribeURL = System.String.alignConst;
                MailBoxChildFullContet val_127 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_127.MailBoxSubcribeButton.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
            }
            
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.urlLink)) != false)
            {
                    this.currentURL = val_6.urlLink;
                val_205 = 1;
                val_206 = this.urlButton;
            }
            else
            {
                    this.currentURL = System.String.alignConst;
                val_206 = this.urlButton;
                val_205 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_206, 丏业丟一东丂东丘丛:  false);
            MailBoxChildFullContet val_131 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            if((val_6 + 40) != 2)
            {
                goto label_240;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_131.MailBoxUrlSingle, 丏业丟一东丂东丘丛:  false);
            MailBoxChildFullContet val_133 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_133.MailBoxAllButtons, 丏业丟一东丂东丘丛:  true);
            MailBoxChildFullContet val_135 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_135.MailBoxAllButtonsDetailButton, 丏业丟一东丂东丘丛:  丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.urlLink));
            if(val_6.丝丆丆丗丞丒丒丝业() == false)
            {
                goto label_247;
            }
            
            val_207;
            Rilisoft.丝丑丂丛万丐丈丘且 val_139 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  2074183552);
            MailBoxRewardController.丄丞丁丈与业上丞丟.业不业丑丂丅三一丒 = val_139;
            MailBoxRewardController.丄丞丁丈与业上丞丟.__unknownFiledOffset_68 = val_139.上万三丆专丏丒丗业;
            goto label_249;
            label_240:
            if(val_192 == false)
            {
                goto label_250;
            }
            
            val_208 = 1152921505379368960;
            val_209 = 0;
            goto label_251;
            label_247:
            val_207 = 0;
            label_249:
            if(val_6.丑丒丏三丆丗专丞丗().Count == 0)
            {
                goto label_253;
            }
            
            val_208 = 1152921505379368960;
            if(((丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  0)) == false) || ((MailBoxRewardController.丄丞丁丈与业上丞丟.一丈丄东丑丕丕丄业(丞丅上丏丂且下丅与:  0)) == false))
            {
                goto label_259;
            }
            
            MailBoxRewardController.丄丞丁丈与业上丞丟.三丐丞丝世丗一且丌 = val_6.丑丒丏三丆丗专丞丗().Item[0].PriceOfThisItem;
            MailBoxChildFullContet val_148 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_148.MailBoxSubcribeButton.丑丗丛三丏丆丞七丁(万丐丏丐丒万不丟三:  MailBoxRewardController.丄丞丁丈与业上丞丟.丕不丗且专丅世丂一(), 丑丑丞专丒丙丒东不:  val_6);
            val_210 = 1;
            goto label_266;
            label_250:
            val_208 = 1152921505379368960;
            val_209 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.urlLink);
            label_251:
            val_211 = val_131.MailBoxUrlSingle;
            val_212 = val_209;
            goto label_271;
            label_259:
            val_210 = 0;
            label_266:
            MailBoxChildFullContet val_152 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_152.MailBoxSubcribeButton.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
            MailBoxChildFullContet val_155 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_155.MailBoxCompleteSubcribeButton, 丏业丟一东丂东丘丛:  (val_210 == 0) ? 1 : 0);
            this.丄丛丌且上下一下丏(丑丑丞专丒丙丒东不:  val_6);
            goto label_279;
            label_253:
            val_208 = 1152921505379368960;
            MailBoxChildFullContet val_158 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_212 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6.urlLink);
            val_211 = val_158.MailBoxUrlSingle;
            label_271:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_211, 丏业丟一东丂东丘丛:  val_212);
            MailBoxChildFullContet val_161 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_161.MailBoxAllButtons, 丏业丟一东丂东丘丛:  false);
            label_279:
            if(val_6.isYoutube != false)
            {
                    val_213 = "Key_8063";
            }
            else
            {
                    val_213 = "Key_8106";
            }
            
            val_190 = I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  val_213);
            MailBoxChildFullContet val_164 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_164.MailBoxUrlSingleLabel, 丕丗丘丑丛与丑业丒:  val_190);
            MailBoxChildFullContet val_166 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_166.MailBoxDetailButtonLabel, 丕丗丘丑丛与丑业丒:  val_190);
            if((val_6.七下业丈业丙丆上丌() == false) || (val_6.丙丄与世丁丛丞业不() == false))
            {
                goto label_299;
            }
            
            this.丗丁世丗丗万下与东();
            MailBoxChildFullContet val_170 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_190 = val_170.MessageRewardContainer.GetComponent<UIWidget>();
            MailBoxFullContent val_172 = this.三业七丗丂丑与丆丗();
            if(val_172.不丟丌丅丁丅丛一丛 != false)
            {
                    val_214 = val_173.newsPic.transform;
                if(val_131.MailBoxUrlSingle != null)
            {
                goto label_309;
            }
            
            }
            else
            {
                    MailBoxChildFullContet val_175 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
                val_214 = val_175.descOrMessageLabel.transform;
            }
            
            label_309:
            val_131.MailBoxUrlSingle.丅专下万丕丑丆丅丝(丞下万上三丘上与专:  val_214, 丄丂丙丘丄丛上丐丒:  0f, 业丘丕万七专丑丂一:  -25f);
            val_190.ResetAndUpdateAnchors();
            label_299:
            if(this.丝丒且万万不业丛与 != false)
            {
                    this.丝丒且万万不业丛与 = false;
            }
            else
            {
                    val_190 = val_6.Date;
                val_204 = val_6 + 40;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                PGCompany.Analytics.一业丗丆世世上丁且.丛万丕丒上丌丂丝七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丑丅丂丞丞丙丐丁丌:  val_190, 丂丄丕一不世且丏丏:  val_6 + 40.ToString(), 丟丒丞丐丐丘丒丄东:  System.String.alignConst);
            }
            
            val_188 = this.三业七丗丂丑与丆丗();
            if(val_179.不丟丌丅丁丅丛一丛 != false)
            {
                    UnityEngine.Coroutine val_181 = this.StartCoroutine(routine:  this.业丆且万下世世丝丁(一业东下丝丛七丂丝:  val_6.id, 专丞上下一丙一丆丕:  val_6.FullPicture));
            }
            
            this.丁且丟丕丛一东丙丞 = this.丛丞丟且丕丆丙丐丘.id;
            this.丘丞且七丆丟丕丅丐();
            MailBoxChildFullContet val_183 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            if(val_183.MailBoxAllButtons.activeSelf == false)
            {
                    return;
            }
            
            MailBoxChildFullContet val_186 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_189 = val_186.MailBoxGridAllButtons;
        }
        private void 丄丛丌且上下一下丏(丏不一丏丗丗丗丈丞 丑丑丞专丒丙丒东不)
        {
            string val_11;
            UILabel val_12;
            string val_13;
            if((丑丑丞专丒丙丒东不.TextButtonReward.Equals(value:  System.String.alignConst)) == false)
            {
                goto label_3;
            }
            
            val_11 = "subscribe";
            丑丑丞专丒丙丒东不.TextButtonReward = val_11;
            if("subscribe" != null)
            {
                goto label_6;
            }
            
            goto label_5;
            label_3:
            val_11 = 丑丑丞专丒丙丒东不.TextButtonReward;
            if(val_11 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            MailBoxChildFullContet val_4 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            bool val_5 = val_4.MailBoxCompleteSubcribeButton.activeSelf;
            if((val_11.Equals(value:  "subscribe")) != false)
            {
                    if(val_5 == false)
            {
                    return;
            }
            
                MailBoxChildFullContet val_7 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
                val_12 = val_7.MailBoxCompleteSubcribeButtonText;
                val_13 = "Key_8083";
            }
            else
            {
                    if(val_5 == false)
            {
                    return;
            }
            
                MailBoxChildFullContet val_9 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
                val_12 = val_9.MailBoxCompleteSubcribeButtonText;
                val_13 = "Key_8788";
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12, 丕丗丘丑丛与丑业丒:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  val_13));
        }
        private void 丘丞且七丆丟丕丅丐()
        {
            if(this.丛丂东丅与东丝丟丕 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丛丂东丅与东丝丟丕.indicatorNew, 丏业丟一东丂东丘丛:  false);
            if(this.丛丂东丅与东丝丟丕.gridIndicators == null)
            {
                
            }
        
        }
        private void 丂丟丂丕丑业丄丒丈(bool 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 != false)
            {
                    MailBoxChildFullContet val_2 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
                val_2.rewardGrid.enabled = true;
                MailBoxChildFullContet val_4 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
                val_4.rewardCurrencyGrid.enabled = true;
            }
            
            MailBoxChildFullContet val_6 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6.rewardCurrencyGrid, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
            MailBoxChildFullContet val_9 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9.rewardGrid, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        }
        private void 丙丕丈丄万丝丂丏丕()
        {
            List.Enumerator<T> val_1 = this.业世且丒丝三三万与.GetEnumerator();
            label_8:
            if((2075796088 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Object.Destroy(obj:  val_2.gameObject, t:  0f);
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.业世且丒丝三三万与.Clear();
        }
        private void 丗丁世丗丗万下与东()
        {
            MailBoxChildFullContet val_2 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_2.rewardGrid.RepositionObjectAfterGrid();
            MailBoxChildFullContet val_4 = this.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
            val_4.rewardCurrencyGrid.RepositionObjectAfterGrid();
        }
        private void 丗丝丙且七七上世丞(SmartUiGrid 丛七丛丆丏七丙与丛, UnityEngine.GameObject 丑且不丕与专丄业丙, Rilisoft.OfferItem 丆丆丌专丌丗七丈与, bool 上且丁上七丁上丄一)
        {
            if(丆丆丌专丌丗七丈与.Type == 1170)
            {
                    PGCompany.丗丟丄丈东丝丕丄世 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丆丆丌专丌丗七丈与.Id);
                if((val_4 != null) && (null == null))
            {
                    if(val_4.上专丗丏丛丁专丑丄() != 0)
            {
                goto label_9;
            }
            
            }
            
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
                UnityEngine.Debug.Log(message:  "Skipped configurate MailBoxCellReward, don\'t found WeaponSkinSettings -> "("Skipped configurate MailBoxCellReward, don\'t found WeaponSkinSettings -> ") + 丆丆丌专丌丗七丈与.Id);
                return;
            }
            
            label_9:
            UnityEngine.GameObject val_10 = 丛七丛丆丏七丙与丛.东丈丌万丒世且丙且(丒业丆丆丛下丈世专:  丑且不丕与专丄业丙);
            CellMailBoxReward val_11 = val_10.GetComponent<CellMailBoxReward>();
            this.业世且丒丝三三万与.Add(item:  val_11);
            val_11.丅丐丈丗丂丘丁丂丁(丏且丕丄丁丟丆丏丁:  丆丆丌专丌丗七丈与, 上且丁上七丁上丄一:  上且丁上七丁上丄一);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
        }
        private void 丗世丝丁七丏丏丄世()
        {
            var val_11;
            var val_12;
            var val_13;
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_3;
            }
            
            val_11 = MailBoxMessagesController.丄丞丁丈与业上丞丟.业丗与世东丗丒世专().Count;
            goto label_8;
            label_3:
            val_11 = 0;
            goto label_8;
            label_20:
            val_12 = public System.Int32 System.Collections.Generic.List<MailBoxScrollItem>::get_Count();
            val_13 = null;
            val_13 = null;
            int val_11 = PGCompany.NewsLobbyController.MaxShowElements;
            val_11 = val_11 + MailBoxMessagesController.丄丞丁丈与业上丞丟.下一丅专丌上且且下();
            if(this.mailBoxItems.Count >= val_11)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_7 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.newsGrid.gameObject, 丑且不丕与专丄业丙:  this.newsItemPrefab);
            if(val_7 != null)
            {
                    val_7.SetActive(value:  true);
            }
            else
            {
                    0.SetActive(value:  true);
            }
            
            this.mailBoxItems.Add(item:  val_7.GetComponent<MailBoxScrollItem>());
            label_8:
            val_12 = public System.Int32 System.Collections.Generic.List<MailBoxScrollItem>::get_Count();
            if(this.mailBoxItems.Count < val_11)
            {
                goto label_20;
            }
            
            label_12:
            this.newsGrid.GetComponent<UIWidget>().ResetAndUpdateAnchors();
            this.newsScroll.ResetPosition();
        }
        private void OnDestroy()
        {
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟 != null)
            {
                    MailBoxMessagesController.丄丞丁丈与业上丞丟.丛丑不三丂东下专丌(三万专丛丟上丏丅下:  "");
            }
            
            this.ShowSettingWindowButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void PGCompany.NewsLobbyController::ShowSettingsWindow(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        public void Close()
        {
            var val_2;
            MainMenuController val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = MainMenuController.丄丞丁丈与业上丞丟;
            MainMenuController.丄丞丁丈与业上丞丟.__unknownFiledOffset_A0 = 1;
        }
        public NewsLobbyController()
        {
            this.MailBoxFullContents = new System.Collections.Generic.List<MailBoxFullContent>();
            this.丁且丟丕丛一东丙丞 = 0;
            this.与专业丏丟专三且丝 = new System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, UnityEngine.Texture>();
            this.mailBoxItems = new System.Collections.Generic.List<MailBoxScrollItem>();
            this.ShareButtons = new System.Collections.Generic.List<ShareButtonMailbox>();
            this.丅丙下丈一专万不丆 = new System.Collections.Generic.List<丗不专世丑七万丞与>();
            this.丙丄七丂丝丂丗丈丙 = true;
            Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            this.上一与丝丟业丞丙一 = val_6;
            mem[1152921553928307928] = val_6.上万三丆专丏丒丗业;
            System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, System.String> val_7 = new System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, System.String>();
            if(val_7 != null)
            {
                    val_7.Add(key:  2, value:  "Key_8070");
            }
            else
            {
                    val_7.Add(key:  2, value:  "Key_8070");
            }
            
            val_7.Add(key:  3, value:  "Key_8067");
            if(val_7 != null)
            {
                    val_7.Add(key:  4, value:  "Key_8069");
            }
            else
            {
                    val_7.Add(key:  4, value:  "Key_8069");
            }
            
            val_7.Add(key:  5, value:  "Key_8068");
            val_7.Add(key:  1, value:  "Key_8100");
            this.丘丟丄丌丁世丞业丆 = val_7;
            System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, System.String> val_8 = new System.Collections.Generic.Dictionary<下丙丟上丂与东丂专, System.String>();
            if(val_8 != null)
            {
                    val_8.Add(key:  2, value:  "[ffd800]");
            }
            else
            {
                    val_8.Add(key:  2, value:  "[ffd800]");
            }
            
            val_8.Add(key:  3, value:  "[25c059]");
            if(val_8 != null)
            {
                    val_8.Add(key:  4, value:  "[5ee6b4]");
            }
            else
            {
                    val_8.Add(key:  4, value:  "[5ee6b4]");
            }
            
            val_8.Add(key:  5, value:  "[f77440]");
            val_8.Add(key:  1, value:  "[15b9ee]");
            this.与丕丏七七业东世丙 = val_8;
            this.业世且丒丝三三万与 = new System.Collections.Generic.List<CellMailBoxReward>();
            this.丛丑丙丗丞丝丘且丞 = "cacheFullPictureFileNamesKey";
        }
        private static NewsLobbyController()
        {
            PGCompany.NewsLobbyController.MaxShowElements = 10;
        }
    
    }

}
