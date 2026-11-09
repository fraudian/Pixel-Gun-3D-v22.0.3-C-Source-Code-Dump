using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丑丞丑丟东丁七丒下
    {
        // Fields
        private const string 丌业丘与丁丂东上世 = "Gpg.SuppressSignInTime";
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丑丞丑丟东丁七丒下> 世丒丞七专三与万丕;
        private System.Nullable<System.DateTime> 丝丟丈且丛丟世一丅;
        private System.EventHandler 与丕东七东丁东丅丟;
        private System.EventHandler<Rilisoft.丏丐丞上七七丝世丝> 东专丅丑不丄下丛丅;
        private readonly GooglePlayGames.PlayGamesPlatform 丆业丟三一丝丆且东;
        
        // Properties
        internal static Rilisoft.丑丞丑丟东丁七丒下 丆丕丝丒不丙且丐丗 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        internal string 丑丞东丛丟三七丛三 { get; }
        internal bool 且与丗丕业丆专下业 { get; set; }
        private System.DateTime 丂丄专丕与丛丁丒丞 { get; set; }
        public GooglePlayGames.PlayGamesPlatform 丙丝与七三丅丏丕万 { get; }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient 丐丕丛丏丌专丆不丈 { get; }
        
        // Methods
        private 丑丞丑丟东丁七丒下()
        {
            bool val_4;
            GooglePlayGames.BasicApi.InvitationReceivedDelegate val_5;
            bool val_6;
            var val_12;
            new PlayGamesClientConfiguration.Builder() = new PlayGamesClientConfiguration.Builder();
            GooglePlayGames.BasicApi.PlayGamesClientConfiguration val_3 = new PlayGamesClientConfiguration.Builder().EnableSavedGames().Build();
            GooglePlayGames.PlayGamesPlatform.InitializeInstance(configuration:  new GooglePlayGames.BasicApi.PlayGamesClientConfiguration() {mEnableSavedGames = val_6, mScopes = val_6, mRequestAuthCode = val_4, mForceRefresh = val_4, mHidePopups = val_4, mRequestEmail = val_4, mRequestIdToken = val_4, mAccountName = val_4, mInvitationDelegate = val_5, mMatchDelegate = val_5});
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    var val_9 = (Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11) ? 1 : 0;
            }
            else
            {
                    val_12 = 0;
            }
            
            GooglePlayGames.PlayGamesPlatform.DebugLogEnabled = false;
            GooglePlayGames.PlayGamesPlatform val_10 = GooglePlayGames.PlayGamesPlatform.Activate();
            this.丆业丟三一丝丆且东 = GooglePlayGames.PlayGamesPlatform.Instance;
        }
        internal static Rilisoft.丑丞丑丟东丁七丒下 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.丑丞丑丟东丁七丒下.世丒丞七专三与万丕 != null)
            {
                    return Rilisoft.丑丞丑丟东丁七丒下.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.丑丞丑丟东丁七丒下.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        internal string 丅丏丄下丑与东专丈()
        {
            if(this.丆业丟三一丝丆且东 == null)
            {
                    return 0;
            }
            
            if(this.丆业丟三一丝丆且东.localUser == null)
            {
                    return 0;
            }
            
            return 0;
        }
        internal bool 且丟下一一丂丐世丁()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_2 = this.丐丙丑丙万下丅上丞();
            System.TimeSpan val_3 = val_1.dateData.Subtract(value:  new System.DateTime() {dateData = val_2.dateData});
            System.TimeSpan val_4 = System.TimeSpan.FromDays(value:  2);
            return (bool)System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_3._ticks}, t2:  new System.TimeSpan() {_ticks = val_4._ticks});
        }
        internal void 丙世丝一一丈三与丈(bool 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 != false)
            {
                    System.DateTime val_1 = System.DateTime.UtcNow;
            }
            else
            {
                    System.DateTime val_2 = 专七专下且专三一且.丐世丈专与东丏丛丑();
            }
            
            this.丁丏丟业丞丗三丆七(丙业与丙丗丝不丈东:  new System.DateTime() {dateData = val_2.dateData});
        }
        private System.DateTime 丐丙丑丙万下丅上丞()
        {
            System.Nullable<System.DateTime> val_4;
            var val_5;
            val_4 = this.丝丟丈且丛丟世一丅;
            if((val_4 & 1) != 0)
            {
                    val_5 = val_4;
                return (System.DateTime)val_5;
            }
            
            val_4 = UnityEngine.PlayerPrefs.GetString(key:  "Gpg.SuppressSignInTime", defaultValue:  System.String.alignConst);
            if((System.DateTime.TryParse(s:  val_4, provider:  System.Globalization.CultureInfo.InvariantCulture, styles:  80, result: out  new System.DateTime())) != false)
            {
                    val_5 = 0;
                return (System.DateTime)val_5;
            }
            
            val_5 = 0;
            return (System.DateTime)val_5;
        }
        private void 丁丏丟业丞丗三丆七(System.DateTime 丙业与丙丗丝不丈东)
        {
            if((-303611176) == 1)
            {
                
            }
            else
            {
                    System.DateTime val_1 = 丙业与丙丗丝不丈东.dateData.ToUniversalTime();
            }
            
            this.丝丟丈且丛丟世一丅 = 0;
            mem[1152921542957953528] = 0;
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
            UnityEngine.PlayerPrefs.SetString(key:  "Gpg.SuppressSignInTime", value:  1152921542957953520);
            UnityEngine.PlayerPrefs.Save();
        }
        public void 丅且三丂东世丒丛上(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.与丕东七东丁东丅丟, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丕东七东丁东丅丟 != 1152921542958081920);
        
        }
        public void 业丒东丆丞东七下专(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.与丕东七东丁东丅丟, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丕东七东丁东丅丟 != 1152921542958218496);
        
        }
        public void 丙专专丈且专丟丑下(System.EventHandler<Rilisoft.丏丐丞上七七丝世丝> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.东专丅丑不丄下丛丅, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东专丅丑不丄下丛丅 != 1152921542958355080);
        
        }
        public void 世不丂且丑丐丆世丙(System.EventHandler<Rilisoft.丏丐丞上七七丝世丝> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.东专丅丑不丄下丛丅, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东专丅丑不丄下丛丅 != 1152921542958491656);
        
        }
        public void 上丛丌丆丑上七世三()
        {
        
        }
        public void 丛丗上丝业下不丈丟(System.Action<bool> 业丏丈世世世丞丒世, bool 与且专丏丅世丐丐丑)
        {
            this.丛丗上丝业下不丈丟(业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 与且专丏丅世丐丐丑:  与且专丏丅世丐丐丑, 丒七一丗丞万丏丁丌:  false);
        }
        public void 丟丕丕丌丈业丝丅丅(System.Action<bool> 业丏丈世世世丞丒世, bool 与且专丏丅世丐丐丑)
        {
            this.丛丗上丝业下不丈丟(业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 与且专丏丅世丐丐丑:  与且专丏丅世丐丐丑, 丒七一丗丞万丏丁丌:  true);
        }
        private void 丛丗上丝业下不丈丟(System.Action<bool> 业丏丈世世世丞丒世, bool 与且专丏丅世丐丐丑, bool 丒七一丗丞万丏丁丌)
        {
            System.EventHandler<Rilisoft.丏丐丞上七七丝世丝> val_17;
            var val_18;
            var val_19;
            System.Action<System.Boolean> val_20;
            var val_21;
            bool val_1 = 丒七一丗丞万丏丁丌;
            丑丞丑丟东丁七丒下.丄丆丌丌丕丈丆丆业 val_2 = new 丑丞丑丟东丁七丒下.丄丆丌丌丕丈丆丆业();
            if(val_2 == null)
            {
                goto label_1;
            }
            
            val_17 = val_2;
            .与且专丏丅世丐丐丑 = 与且专丏丅世丐丐丑;
            mem[1152921542959053056] = this;
            mem[1152921542959053072] = 业丏丈世世世丞丒世;
            if(业丏丈世世世丞丒世 == null)
            {
                goto label_2;
            }
            
            label_38:
            val_18 = null;
            if(Rilisoft.丑丞丑丟东丁七丒下.世丈且业丆丑丏丐一() != false)
            {
                    string[] val_5 = new string[6];
                val_5[0] = "[GpgFacade.Authenticate] silent: ";
                val_5[1] = .与且专丏丅世丐丐丑.ToString();
                val_5[2] = ", forceIgnoringSuppress: ";
                val_5[3] = val_1.ToString();
                val_5[4] = ", SignInSuppressed: ";
                val_5[5] = this.且丟下一一丂丐世丁().ToString();
                UnityEngine.Debug.Log(message:  +val_5);
            }
            
            if((this.且丟下一一丂丐世丁() == false) || (val_1 == true))
            {
                goto label_29;
            }
            
            val_17 = this.东专丅丑不丄下丛丅;
            if(val_17 != null)
            {
                    val_19 = null;
                val_19 = null;
                val_17.Invoke(sender:  this, e:  Rilisoft.丏丐丞上七七丝世丝.东业世丌丛专下七万);
            }
            
            if(val_2 != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            val_20 = mem[1152921542959053072];
            val_20.Invoke(obj:  false);
            return;
            label_29:
            val_20 = .与且专丏丅世丐丐丑;
            this.丆业丟三一丝丆且东.Authenticate(callback:  new System.Action<System.Boolean>(object:  val_2, method:  System.Void 丑丞丑丟东丁七丒下.丄丆丌丌丕丈丆丆业::七丐一丝丒丈丂三丏(bool 丞且万不与业下丂丆)), silent:  (val_20 == true) ? 1 : 0);
            return;
            label_1:
            mem[16] = this;
            mem[24] = 与且专丏丅世丐丐丑;
            mem[32] = 业丏丈世世世丞丒世;
            if(mem[32] != 0)
            {
                goto label_38;
            }
            
            label_2:
            System.ArgumentNullException val_16 = new System.ArgumentNullException(paramName:  "callback");
            val_21 = val_16;
            if(0 != 1)
            {
                goto label_40;
            }
            
            if((null & 1) == 0)
            {
                goto label_41;
            }
            
            UnityEngine.Debug.LogException(exception:  1152921504617017344);
            if(val_16 != null)
            {
                goto label_44;
            }
            
            goto label_45;
            label_41:
            mem[8] = null;
            val_21 = 8;
            label_40:
        }
        public void 丘丌万丂丟丒且丘上(string 专丅且丌一万且上七, int 不丕丝下丐丐丄丟丙, System.Action<bool> 业丏丈世世世丞丒世)
        {
            string val_3;
            if(专丅且丌一万且上七 == null)
            {
                goto label_1;
            }
            
            if(业丏丈世世世丞丒世 == null)
            {
                goto label_2;
            }
            
            this.丆业丟三一丝丆且东.IncrementAchievement(achievementID:  专丅且丌一万且上七, steps:  不丕丝下丐丐丄丟丙, callback:  业丏丈世世世丞丒世);
            return;
            label_1:
            val_3 = "achievementId";
            goto label_4;
            label_2:
            val_3 = "callback";
            label_4:
            null = new System.ArgumentNullException(paramName:  val_3);
        }
        public bool 下丏丗与七丑丅与丅()
        {
            if(this.丆业丟三一丝丆且东 != null)
            {
                    return this.丆业丟三一丝丆且东.IsAuthenticated();
            }
            
            return this.丆业丟三一丝丆且东.IsAuthenticated();
        }
        public void 丒上丏且丘丕丅丄丕()
        {
            var val_5;
            UnityEngine.Debug.LogWarning(message:  "[GpgFacade.SignOut] SignInSuppressed: "("[GpgFacade.SignOut] SignInSuppressed: ") + this.且丟下一一丂丐世丁().ToString());
            this.丙世丝一一丈三与丈(丙业与丙丗丝不丈东:  true);
            this.丆业丟三一丝丆且东.SignOut();
            if(this.与丕东七东丁东丅丟 == null)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            this.与丕东七东丁东丅丟.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        public GooglePlayGames.PlayGamesPlatform 与丟丗丐与丑且上东()
        {
            return (GooglePlayGames.PlayGamesPlatform)this.丆业丟三一丝丆且东;
        }
        public GooglePlayGames.BasicApi.SavedGame.ISavedGameClient 丗丗一上且万专丙丅()
        {
            return (GooglePlayGames.BasicApi.SavedGame.ISavedGameClient)this.丆业丟三一丝丆且东.SavedGame;
        }
        private static 丑丞丑丟东丁七丒下()
        {
            null = null;
            Rilisoft.丑丞丑丟东丁七丒下.世丒丞七专三与万丕 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丑丞丑丟东丁七丒下>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丑丞丑丟东丁七丒下>(object:  丑丞丑丟东丁七丒下.<>c.<>9, method:  Rilisoft.丑丞丑丟东丁七丒下 丑丞丑丟东丁七丒下.<>c::丙丆丙丙丟丌专丈一()));
        }
    
    }

}
