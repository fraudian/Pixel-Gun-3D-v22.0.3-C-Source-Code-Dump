using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丌专业丘丆丞丂丈上 : 丆专且丆世丟丄与丂
    {
        // Fields
        private readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛丞丛丑丑万世丛万> 丂万不丙上丄丐丑丞;
        private readonly string 丞世世上下丘丟上专;
        private readonly System.Func<string, string, string> 世丁丈一一业业丁丟;
        private string 三七丞且丑业丗丄三;
        private string 丒下丘万上万三丏三;
        private string 与丙丄丙丗七上下丒;
        private System.Threading.Tasks.Task<string> 丏丄丗不丛丒七上丅;
        private System.Threading.Tasks.Task<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 丄丘丞丅丁丕丌丛丂;
        
        // Properties
        public override string 丞丕丛业丙下丈丒丌 { get; }
        public System.Exception 丑上万丕七专丞与丝 { get; }
        public override bool 丒丌不丁丏丅丏丙世 { get; }
        private Rilisoft.丛丞丛丑丑万世丛万 丛丞丛丑丑万世丛万 { get; }
        private string 一丅丐丕丞世专业丗 { get; }
        
        // Methods
        public 丌专业丘丆丞丂丈上(string 丂万一与丈丛丝丌丝, System.Func<string, string, string> 三且丘上丁业上丝丞)
        {
            System.Func<System.String, System.String, System.String> val_8 = 三且丘上丁业上丝丞;
            if(丂万一与丈丛丝丌丝 == null)
            {
                goto label_1;
            }
            
            label_7:
            this.丞世世上下丘丟上专 = 丂万一与丈丛丝丌丝;
            if(val_8 == null)
            {
                    System.Func<System.String, System.String, System.String> val_1 = null;
                val_8 = val_1;
                val_1 = new System.Func<System.String, System.String, System.String>(object:  0, method:  static System.String Rilisoft.丌专业丘丆丞丂丈上::丈下丕与丅丒丗丗三(string 丈丂丕下丏丈丞丗业, string 丂丌丌丛丆丆丙丌丈));
            }
            
            this.世丁丈一一业业丁丟 = val_8;
            this.丂万不丙上丄丐丑丞 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.丛丞丛丑丑万世丛万>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.丛丞丛丑丑万世丛万>(object:  0, method:  static Rilisoft.丛丞丛丑丑万世丛万 Rilisoft.丌专业丘丆丞丂丈上::七业丁东七丘东丒上()));
            string val_6 = this.丌丁丐丒业丅丙丝丁().丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  this.丅专与丒丗丕丒丐丄());
            if((System.String.IsNullOrEmpty(value:  val_6)) == true)
            {
                    return;
            }
            
            this.三七丞且丑业丗丄三 = val_6;
            return;
            label_1:
            if(this != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public override string 专一东丟丟丗丄丝丐()
        {
            string val_5;
            if(((this.丏丄丗不丛丒七上丅 != null) && (this.丏丄丗不丛丒七上丅.IsFaulted != true)) && (this.丏丄丗不丛丒七上丅.IsCanceled != true))
            {
                    if(this.丏丄丗不丛丒七上丅.IsCompleted != false)
            {
                    string val_4 = this.丏丄丗不丛丒七上丅.Result;
                val_5 = this.与丙丄丙丗七上下丒;
                if(val_4 == null)
            {
                    return (string)mem[this.与丙丄丙丗七上下丒];
            }
            
                this.与丙丄丙丗七上下丒 = val_4;
                this.丏丄丗不丛丒七上丅 = 0;
                return (string)mem[this.与丙丄丙丗七上下丒];
            }
            
            }
            
            val_5 = this.与丙丄丙丗七上下丒;
            return (string)mem[this.与丙丄丙丗七上下丒];
        }
        public System.Exception 下专与丅七丏七丑丆()
        {
            var val_3;
            if(this.丏丄丗不丛丒七上丅 != null)
            {
                    val_3 = 0;
                if(this.丏丄丗不丛丒七上丅.IsFaulted == false)
            {
                    return (System.Exception)val_3;
            }
            
                System.AggregateException val_2 = this.丏丄丗不丛丒七上丅.Exception;
                return (System.Exception)val_3;
            }
            
            val_3 = 0;
            return (System.Exception)val_3;
        }
        public override bool 且七丒一专丘专下东()
        {
            return (bool)(this != 0) ? 1 : 0;
        }
        private Rilisoft.丛丞丛丑丑万世丛万 丌丁丐丒业丅丙丝丁()
        {
            if(this.丂万不丙上丄丐丑丞 != null)
            {
                    return this.丂万不丙上丄丐丑丞.世三丞丅丑丌丈丈一();
            }
            
            return this.丂万不丙上丄丐丑丞.世三丞丅丑丌丈丈一();
        }
        private string 丅专与丒丗丕丒丐丄()
        {
            string val_3;
            if((System.String.IsNullOrEmpty(value:  this.丒下丘万上万三丏三)) != false)
            {
                    this.丒下丘万上万三丏三 = "PendingMerge/"("PendingMerge/") + this.丞世世上下丘丟上专;
                return val_3;
            }
            
            val_3 = this.丒下丘万上万三丏三;
            return val_3;
        }
        public override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 专业丛丂丅与世上丙(bool 与且专丏丅世丐丐丑 = True)
        {
            System.Object[] val_27;
            string val_28;
            System.Object[] val_29;
            var val_30;
            var val_32;
            System.Func<System.Threading.Tasks.Task<System.String>, Rilisoft.丌业丒一丛专万三世> val_34;
            bool val_1 = 与且专丏丅世丐丐丑;
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_3;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
            {
                goto label_6;
            }
            
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_7;
            }
            
            val_27 = new object[2];
            val_27[0] = this.GetType();
            val_27[1] = val_1;
            val_28 = "{0}.Pull({1})";
            goto label_17;
            label_3:
            val_29 = new object[3];
            val_29[0] = this.GetType();
            val_29[1] = val_1;
            UnityEngine.RuntimePlatform val_10 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
            val_30 = 1152921504831819776;
            goto label_25;
            label_6:
            object[] val_11 = new object[3];
            val_29 = val_11;
            val_29[0] = this.GetType();
            val_29[1] = val_1;
            val_30 = 1152921505171595264;
            label_25:
            val_29[2] = 与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三();
            UnityEngine.Debug.LogWarningFormat(format:  "Skipping {0}.Pull({1}) on {2}", args:  val_11);
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            label_7:
            if(this.丏丄丗不丛丒七上丅 == null)
            {
                goto label_47;
            }
            
            if(this.丏丄丗不丛丒七上丅.IsCompleted == false)
            {
                goto label_41;
            }
            
            if(((this.丏丄丗不丛丒七上丅 != null) && (this.丏丄丗不丛丒七上丅.IsFaulted != true)) && (this.丏丄丗不丛丒七上丅.IsCanceled != true))
            {
                    string val_17 = this.丏丄丗不丛丒七上丅.Result;
                if(val_17 != null)
            {
                    this.与丙丄丙丗七上下丒 = val_17;
            }
            
            }
            
            label_47:
            System.Threading.Tasks.TaskCompletionSource<System.String> val_18 = new System.Threading.Tasks.TaskCompletionSource<System.String>();
            Rilisoft.丌丌丏且不不丄三丅 val_20 = new Rilisoft.丌丌丏且不不丄三丅(丂万一与丈丛丝丌丝:  this.丞世世上下丘丟上专, 与且专丏丅世丐丐丑:  与且专丏丅世丐丐丑, 三且丘上丁业上丝丞:  this.世丁丈一一业业丁丟, 世丅丒丆三下专丘丆:  val_18);
            System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与> val_21 = new System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与>(object:  this, method:  System.Void Rilisoft.丌专业丘丆丞丂丈上::丙七丕三丙丞丄万专(object 不丟丗丏丛丕不丁丌, Rilisoft.丘丟丙丑丆丂丒且与 丗丛不丁丑专专丂且));
            if(val_20 == null)
            {
                goto label_48;
            }
            
            val_20.丈上一一丄丗专一丒(丙业与丙丗丝不丈东:  val_21);
            goto label_49;
            label_41:
            object[] val_22 = new object[2];
            val_27 = val_22;
            val_27[0] = this.GetType();
            val_27[1] = val_1;
            val_28 = "Skipping {0}.Pull({1}) because previous request not completed";
            label_17:
            UnityEngine.Debug.LogFormat(format:  val_28, args:  val_22);
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            label_48:
            val_20.丈上一一丄丗专一丒(丙业与丙丗丝不丈东:  val_21);
            label_49:
            val_20.丄丄丛万丁丐丐与丏();
            System.Threading.Tasks.Task<TResult> val_24 = val_18.Task;
            this.丏丄丗不丛丒七上丅 = val_24;
            val_32 = null;
            val_32 = null;
            val_34 = 丌专业丘丆丞丂丈上.<>c.<>9__19_0;
            if(val_34 == null)
            {
                    System.Func<System.Threading.Tasks.Task<System.String>, Rilisoft.丌业丒一丛专万三世> val_25 = null;
                val_34 = val_25;
                val_25 = new System.Func<System.Threading.Tasks.Task<System.String>, Rilisoft.丌业丒一丛专万三世>(object:  丌专业丘丆丞丂丈上.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丌业丒一丛专万三世 丌专业丘丆丞丂丈上.<>c::丞丄七丝丝三且丑丘(System.Threading.Tasks.Task<string> 丙丒七丄上与丏丙丙));
                丌专业丘丆丞丂丈上.<>c.<>9__19_0 = val_34;
            }
            
            System.Threading.Tasks.Task<TNewResult> val_26 = val_24.ContinueWith<Rilisoft.丌业丒一丛专万三世>(continuationFunction:  val_25);
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
        }
        public override void 丅万丞丘与丏丝丕丅(string 一丐丗丁丞丆丅丟丄)
        {
            var val_22;
            string val_23;
            System.Object[] val_24;
            object val_25;
            string val_26;
            System.Object[] val_27;
            var val_28;
            val_23 = 一丐丗丁丞丆丅丟丄;
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_1;
            }
            
            val_22 = 1152921505171275776;
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
            {
                goto label_4;
            }
            
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_5;
            }
            
            val_24 = new object[1];
            val_25 = this.GetType();
            val_24[0] = val_25;
            val_26 = "{0}.Push()";
            goto label_12;
            label_1:
            val_27 = new object[2];
            val_27[0] = this.GetType();
            UnityEngine.RuntimePlatform val_8 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
            val_28 = 1152921504831819776;
            goto label_17;
            label_4:
            object[] val_9 = new object[2];
            val_27 = val_9;
            val_27[0] = this.GetType();
            val_28 = 1152921505171595264;
            label_17:
            val_27[1] = 与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三();
            UnityEngine.Debug.LogWarningFormat(format:  "Skipping {0}.Push() on {1}", args:  val_9);
            return;
            label_5:
            if(this.丄丘丞丅丁丕丌丛丂 != null)
            {
                    if(this.丄丘丞丅丁丕丌丛丂.IsCompleted == false)
            {
                goto label_30;
            }
            
            }
            
            if(this.三七丞且丑业丗丄三 != null)
            {
                    val_23 = this.世丁丈一一业业丁丟.Invoke(arg1:  this.三七丞且丑业丗丄三, arg2:  val_23);
            }
            
            System.Threading.Tasks.TaskCompletionSource<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_14 = new System.Threading.Tasks.TaskCompletionSource<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>();
            Rilisoft.万丞丗且丂一七上丌 val_15 = new Rilisoft.万丞丗且丂一七上丌(丂万一与丈丛丝丌丝:  this.丞世世上下丘丟上专, 三且丘上丁业上丝丞:  this.世丁丈一一业业丁丟, 一丐丗丁丞丆丅丟丄:  val_23, 世丅丒丆三下专丘丆:  val_14);
            System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与> val_16 = new System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与>(object:  this, method:  System.Void Rilisoft.丌专业丘丆丞丂丈上::丙七丕三丙丞丄万专(object 不丟丗丏丛丕不丁丌, Rilisoft.丘丟丙丑丆丂丒且与 丗丛不丁丑专专丂且));
            if(val_15 == null)
            {
                goto label_33;
            }
            
            val_15.丈上一一丄丗专一丒(丙业与丙丗丝不丈东:  val_16);
            goto label_34;
            label_30:
            object[] val_17 = new object[1];
            val_24 = val_17;
            val_25 = this.GetType();
            val_24[0] = val_25;
            val_26 = "Skipping {0}.Push() because previous request not completed";
            label_12:
            UnityEngine.Debug.LogFormat(format:  val_26, args:  val_17);
            return;
            label_33:
            val_15.丈上一一丄丗专一丒(丙业与丙丗丝不丈东:  val_16);
            label_34:
            val_15.丄丄丛万丁丐丐与丏();
            System.Threading.Tasks.Task<TResult> val_19 = val_14.Task;
            this.丄丘丞丅丁丕丌丛丂 = val_19;
            System.Threading.Tasks.Task val_21 = val_19.ContinueWith(continuationAction:  new System.Action<System.Threading.Tasks.Task<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>>(object:  this, method:  System.Void Rilisoft.丌专业丘丆丞丂丈上::不丌丝东丙丌丛丒丄(System.Threading.Tasks.Task<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 专一与丘且上丟上且)));
        }
        public override string ToString()
        {
            System.Type val_1 = this.GetType();
            if(val_1 != null)
            {
                    return System.String.Format(format:  "{0}(`{1}`)", arg0:  val_1, arg1:  this.丞世世上下丘丟上专);
            }
            
            return System.String.Format(format:  "{0}(`{1}`)", arg0:  val_1, arg1:  this.丞世世上下丘丟上专);
        }
        private static string 丈下丕与丅丒丗丗三(string 丈丂丕下丏丈丞丗业, string 丂丌丌丛丆丆丙丌丈)
        {
            return (string)丈丂丕下丏丈丞丗业;
        }
        private void 丙七丕三丙丞丄万专(object 不丟丗丏丛丕不丁丌, Rilisoft.丘丟丙丑丆丂丒且与 丗丛不丁丑专专丂且)
        {
            string val_13;
            string val_14 = this;
            if(丗丛不丁丑专专丂且 == null)
            {
                    return;
            }
            
            if(丗丛不丁丑专专丂且.业东丆且一下上三丗() == null)
            {
                    return;
            }
            
            string val_5 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "AndroidCloudSlotSynchronizer(`{0}`).HandleMerge({1} chars)", arg0:  this.丞世世上下丘丟上专, arg1:  丗丛不丁丑专专丂且.业东丆且一下上三丗().Length);
            bool val_7 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(this.三七丞且丑业丗丄三 != null)
            {
                    string val_9 = this.世丁丈一一业业丁丟.Invoke(arg1:  this.三七丞且丑业丗丄三, arg2:  丗丛不丁丑专专丂且.业东丆且一下上三丗());
            }
            
            this.三七丞且丑业丗丄三 = 丗丛不丁丑专专丂且.业东丆且一下上三丗();
            Rilisoft.丛丞丛丑丑万世丛万 val_11 = this.丌丁丐丒业丅丙丝丁();
            val_13 = this.丅专与丒丗丕丒丐丄();
            val_14 = this.三七丞且丑业丗丄三;
            if(val_14 == null)
            {
                goto label_11;
            }
            
            if(val_11 != null)
            {
                goto label_14;
            }
            
            goto label_13;
            label_11:
            val_14 = System.String.alignConst;
            if(val_11 != null)
            {
                goto label_14;
            }
            
            label_13:
            label_14:
            val_11.丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  val_13, 丙业与丙丗丝不丈东:  val_14);
        }
        private void 不丌丝东丙丌丛丒丄(System.Threading.Tasks.Task<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 专一与丘且上丟上且)
        {
            string val_14;
            int val_15;
            val_14 = this;
            if(专一与丘且上丟上且 == null)
            {
                goto label_1;
            }
            
            val_15 = 专一与丘且上丟上且;
            if(专一与丘且上丟上且.IsFaulted == false)
            {
                goto label_2;
            }
            
            label_4:
            string val_3 = Rilisoft.丌专业丘丆丞丂丈上.丄且丌丙且不业与不(丐不丏不丄东丝下丙:  val_15.Exception);
            goto label_3;
            label_1:
            val_15 = 0;
            if(0.IsFaulted == true)
            {
                goto label_4;
            }
            
            label_2:
            label_3:
            string val_8 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "AndroidCloudSlotSynchronizer(`{0}`).HandlePushCompleted(`{1}`)", arg0:  this.丞世世上下丘丟上专, arg1:  Rilisoft.上丗丒丙不丝丞且丂.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  专一与丘且上丟上且.Result));
            bool val_10 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(val_15.IsFaulted != true)
            {
                    val_14 = this.丅专与丒丗丕丒丐丄();
                val_15 = System.String.alignConst;
                this.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  val_14, 丙业与丙丗丝不丈东:  val_15);
            }
        
        }
        private static string 丄且丌丙且不业与不(System.AggregateException 丐不丏不丄东丝下丙)
        {
            var val_3;
            if(丐不丏不丄东丝下丙 == null)
            {
                goto label_1;
            }
            
            System.Exception val_1 = 丐不丏不丄东丝下丙.InnerException;
            if(val_1 == null)
            {
                goto label_2;
            }
            
            System.Type val_2 = val_1.GetType();
            if(val_1 == null)
            {
                goto label_3;
            }
            
            return System.String.Format(format:  "{0}(\"{1}\")", arg0:  val_2, arg1:  val_1);
            label_1:
            val_3 = "aggregateException == null";
            return (string)val_3;
            label_2:
            val_3 = "innerException == null";
            return (string)val_3;
            label_3:
            if(val_2 == null)
            {
                
            }
        
        }
        private static Rilisoft.丛丞丛丑丑万世丛万 七业丁东七丘东丒上()
        {
            HiddenSettings val_7;
            System.Byte[] val_8;
            if(MiscAppsMenu.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_7 = mem[MiscAppsMenu.丆丕丝丒不丙且丐丗 + 24];
                val_7 = MiscAppsMenu.丆丕丝丒不丙且丐丗.misc;
            }
            else
            {
                    val_7 = 0;
            }
            
            if(val_7 == 0)
            {
                    val_8 = System.Convert.FromBase64String(s:  "SZ+5SPQlvW7vBura/S2myrrtowD8kkhW16FVk4cHtLhdxwhUh0KZog==");
                return (Rilisoft.丛丞丛丑丑万世丛万)new Rilisoft.丛丞丛丑丑万世丛万(丅丄三丅丑丑丞且万:  val_8 = System.Convert.FromBase64String(s:  val_7.CloudSynchronizerKey));
            }
            
            return (Rilisoft.丛丞丛丑丑万世丛万)new Rilisoft.丛丞丛丑丑万世丛万(丅丄三丅丑丑丞且万:  val_8);
        }
    
    }

}
