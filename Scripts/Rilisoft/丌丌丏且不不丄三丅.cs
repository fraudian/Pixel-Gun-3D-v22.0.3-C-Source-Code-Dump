using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丌丌丏且不不丄三丅
    {
        // Fields
        private const string 丏下丛丛丁业丒丒东 = "[Rilisoft] SavedGame client is null.";
        private readonly string 丞世世上下丘丟上专;
        private readonly System.Func<string, string, string> 世丁丈一一业业丁丟;
        private readonly System.Threading.Tasks.TaskCompletionSource<string> 丒丌丁世与业下丄下;
        private readonly bool 丅丝丌丝丟丂丒东丐;
        private string 三七丞且丑业丗丄三;
        private GooglePlayGames.BasicApi.DataSource 丛丄专丆丐丛丙丞万;
        private bool 丒业丐一丛与丕丏丄;
        private System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与> 下与且七东下与丙世;
        
        // Properties
        private string 与丌丘专专与一丅且 { get; }
        private System.Threading.Tasks.Task<string> 业三世丌三丑业万东 { get; }
        private static GooglePlayGames.BasicApi.SavedGame.ISavedGameClient 丐丕丛丏丌专丆不丈 { get; }
        
        // Methods
        internal 丌丌丏且不不丄三丅(string 丂万一与丈丛丝丌丝, bool 与且专丏丅世丐丐丑, System.Func<string, string, string> 三且丘上丁业上丝丞, System.Threading.Tasks.TaskCompletionSource<string> 世丅丒丆三下专丘丆)
        {
            int val_4;
            string val_6;
            val_4 = 丂万一与丈丛丝丌丝;
            this.丛丄专丆丐丛丙丞万 = 1;
            val_1 = new System.Object();
            if(三且丘上丁业上丝丞 == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_4 == null)
            {
                    val_4 = System.String.alignConst;
            }
            
            this.丞世世上下丘丟上专 = val_4;
            this.世丁丈一一业业丁丟 = 三且丘上丁业上丝丞;
            this.丅丝丌丝丟丂丒东丐 = 与且专丏丅世丐丐丑;
            this.丒丌丁世与业下丄下 = val_1;
            return;
            label_1:
            val_6 = "merger";
            goto label_4;
            label_2:
            val_6 = "promise";
            label_4:
            null = new System.ArgumentNullException(paramName:  val_6);
        }
        private string 丒丌丒专丙下一丅万()
        {
            return (string)this.丞世世上下丘丟上专;
        }
        private System.Threading.Tasks.Task<string> 万丟丙专东丙万丂万()
        {
            if(this.丒丌丁世与业下丄下 != null)
            {
                    return this.丒丌丁世与业下丄下.Task;
            }
            
            return this.丒丌丁世与业下丄下.Task;
        }
        private static GooglePlayGames.BasicApi.SavedGame.ISavedGameClient 丗丗一上且万专丙丅()
        {
            return (GooglePlayGames.BasicApi.SavedGame.ISavedGameClient)Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丗丗一上且万专丙丅();
        }
        internal void 丈上一一丄丗专一丒(System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下与且七东下与丙世, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下与且七东下与丙世 != 1152921542502123968);
        
        }
        internal void 上上丐与丝东丑下丈(System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下与且七东下与丙世, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下与且七东下与丙世 != 1152921542502260544);
        
        }
        internal void 丄丄丛万丁丐丐与丏()
        {
            if(this.丒业丐一丛与丕丏丄 != true)
            {
                    this.丒业丐一丛与丕丏丄 = true;
                if(Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅() != false)
            {
                    this.业东一丄丛且七业丞();
            }
            else
            {
                    System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::丂丕三业七丅与业丝(bool 七丒专丘丙丏丙三且));
                this = this.丅丝丌丝丟丂丒东丐;
                Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丛丗上丝业下不丈丟(业丏丈世世世丞丒世:  null, 与且专丏丅世丐丐丑:  (this == true) ? 1 : 0);
            }
            
            }
        
        }
        internal static string 东且丏丆万与东丙万(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)
        {
            int val_3;
            if(下上不丄丕丙万丞丌 != null)
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_3 = 下上不丄丕丙万丞丌;
                if(val_3.Description != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        private static string 丞丐丝丐丝丄世丕下(string 丏丛与丅丛丌万专丌, int 丏上万丅丏一不不丕)
        {
            string val_4 = 丏丛与丅丛丌万专丌;
            if(((System.String.IsNullOrEmpty(value:  val_4 = 丏丛与丅丛丌万专丌)) != true) && (丏上万丅丏一不不丕 > 0))
            {
                    if(val_4.Length <= 丏上万丅丏一不不丕)
            {
                    return (string)val_4;
            }
            
                return val_4.Substring(startIndex:  0, length:  丏上万丅丏一不不丕)(val_4.Substring(startIndex:  0, length:  丏上万丅丏一不不丕)) + "...";
            }
            
            val_4 = System.String.alignConst;
            return (string)val_4;
        }
        private void 业东一丄丛且七业丞()
        {
            if(Rilisoft.丌丌丏且不不丄三丅.丗丗一上且万专丙丅() != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
            }
            else
            {
                    bool val_6 = this.丒丌丁世与业下丄下.TrySetException(exception:  new System.InvalidOperationException(message:  "[Rilisoft] SavedGame client is null."));
                return;
            }
            
            Rilisoft.丌丌丏且不不丄三丅.丗丗一上且万专丙丅().OpenWithManualConflictResolution(filename:  this.丞世世上下丘丟上专, source:  this.丛丄专丆丐丛丙丞万, prefetchDataOnConflict:  true, conflictCallback:  new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::丘丂丒上丕丆丈丆丐(GooglePlayGames.BasicApi.SavedGame.IConflictResolver 丛且东丅丗丌上下下, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 专丑业丁丗丏丌不丛, byte[] 丏且丂丈不丆三不一, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟专上世一丄丞丌万, byte[] 一与七且丒上丐不丒)), completedCallback:  new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::下七上丁丄丄七丆专(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)));
        }
        private void 丂丕三业七丅与业丝(bool 七丒专丘丙丏丙三且)
        {
            Rilisoft.丆丈丌业下丝三东世 val_19;
            System.Object[] val_20;
            object val_21;
            var val_22;
            val_20 = this;
            if(七丒专丘丙丏丙三且 == false)
            {
                goto label_1;
            }
            
            if(Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅() == false)
            {
                goto label_5;
            }
            
            this.业东一丄丛且七业丞();
            goto label_43;
            label_1:
            val_19 = new Rilisoft.丆丈丌业下丝三东世();
            val_19 = new Rilisoft.丆丈丌业下丝三东世(丄丙下丝丛丒七丂丘:  "Authentication callback failed");
            bool val_4 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丆丈丌业下丝三东世());
            goto label_43;
            label_5:
            val_19 = new Rilisoft.丆丈丌业下丝三东世();
            val_19 = new Rilisoft.丆丈丌业下丝三东世(丄丙下丝丛丒七丂丘:  "Authentication callback succeeded, but user still not authenticated");
            bool val_6 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丆丈丌业下丝三东世());
            label_43:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_19 = this.万丟丙专东丙万丂万();
                if(val_19.IsFaulted != false)
            {
                    val_21 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  this.万丟丙专东丙万丂万().Exception.InnerExceptions);
                if(val_21 == null)
            {
                    val_21 = this.万丟丙专东丙万丂万().Exception;
            }
            
                object[] val_16 = new object[2];
                val_20 = val_16;
                val_22 = 0;
                System.Type val_17 = val_21.GetType();
                if((val_17 != null) && (val_17 == null))
            {
                    val_22 = 0;
            }
            
                if(val_16.Length == 0)
            {
                    val_22 = 0;
            }
            
                val_20[0] = val_17;
                val_19 = val_21;
                val_20[1] = val_19;
                UnityEngine.Debug.LogFormat(format:  "Request failed with `{0}`: {1}", args:  val_16);
            }
            
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(202 == 202)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        private void 丘丂丒上丕丆丈丆丐(GooglePlayGames.BasicApi.SavedGame.IConflictResolver 丛且东丅丗丌上下下, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 专丑业丁丗丏丌不丛, byte[] 丏且丂丈不丆三不一, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟专上世一丄丞丌万, byte[] 一与七且丒上丐不丒)
        {
            GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_34;
            object val_35;
            object val_36;
            int val_37;
            var val_38;
            int val_39;
            string val_40;
            string val_41;
            var val_43;
            var val_45;
            var val_47;
            var val_49;
            var val_52;
            object val_54;
            var val_55;
            val_34 = 丟专上世一丄丞丌万;
            val_35 = this;
            object[] val_2 = new object[4];
            val_2[0] = "GooglePullHelper.HandleOpenConflict";
            val_2[1] = this.丞世世上下丘丟上专;
            val_2[2] = Rilisoft.丌丌丏且不不丄三丅.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  专丑业丁丗丏丌不丛);
            val_36 = Rilisoft.丌丌丏且不不丄三丅.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  val_34);
            val_2[3] = val_36;
            val_37 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "[{0}] Filename: {1}, original: {2}, unmerged: {3}", args:  val_2);
            val_38 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(丏且丂丈不丆三不一 == null)
            {
                goto label_18;
            }
            
            if(一与七且丒上丐不丒 == null)
            {
                goto label_19;
            }
            
            val_39 = System.Text.Encoding.UTF8;
            if(val_39 == null)
            {
                    val_39 = System.String.alignConst;
            }
            
            val_37 = System.Text.Encoding.UTF8;
            if(val_37 == null)
            {
                    val_37 = System.String.alignConst;
            }
            
            val_36 = 1152921542497869888;
            val_40 = val_37;
            val_41 = this.世丁丈一一业业丁丟.Invoke(arg1:  val_39, arg2:  val_40);
            if(val_39 == val_41)
            {
                goto label_25;
            }
            
            if(val_37 == val_41)
            {
                goto label_26;
            }
            
            if(this.三七丞且丑业丗丄三 != null)
            {
                    val_37 = this.世丁丈一一业业丁丟;
                val_41 = val_37.Invoke(arg1:  this.三七丞且丑业丗丄三, arg2:  val_41);
            }
            
            this.三七丞且丑业丗丄三 = val_41;
            if(this.下与且七东下与丙世 != null)
            {
                    val_37 = new Rilisoft.丘丟丙丑丆丂丒且与();
                val_37 = new Rilisoft.丘丟丙丑丆丂丒且与(不丒不丗万丌丘丂丐:  val_41);
                this.下与且七东下与丙世.Invoke(sender:  this, e:  new Rilisoft.丘丟丙丑丆丂丒且与());
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            goto label_34;
            label_18:
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_43 = 0;
            goto label_39;
            label_19:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_45 = 0;
            goto label_44;
            label_25:
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_47 = 0;
            goto label_49;
            label_39:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  val_34);
            goto label_113;
            label_26:
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_49 = 0;
            goto label_55;
            label_44:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  专丑业丁丗丏丌不丛);
            goto label_113;
            label_34:
            System.DateTime val_15 = 专丑业丁丗丏丌不丛.LastModifiedTimestamp;
            var val_40 = 0;
            val_40 = val_40 + 1;
            System.DateTime val_17 = val_34.LastModifiedTimestamp;
            val_52 = 0;
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_52 = 0;
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  ((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_15.dateData}, t2:  new System.DateTime() {dateData = val_17.dateData})) != true) ? 专丑业丁丗丏丌不丛 : (val_34));
            goto label_113;
            label_49:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  专丑业丁丗丏丌不丛);
            goto label_113;
            label_55:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  val_34);
            label_113:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_34 = this.万丟丙专东丙万丂万();
                if(val_34.IsFaulted != false)
            {
                    val_54 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  this.万丟丙专东丙万丂万().Exception.InnerExceptions);
                if(val_54 == null)
            {
                    val_54 = this.万丟丙专东丙万丂万().Exception;
            }
            
                object[] val_32 = new object[2];
                val_35 = val_32;
                val_55 = 0;
                System.Type val_33 = val_54.GetType();
                if((val_33 != null) && (val_33 == null))
            {
                    val_55 = 0;
            }
            
                if(val_32.Length == 0)
            {
                    val_55 = 0;
            }
            
                val_35[0] = val_33;
                val_34 = val_54;
                val_35[1] = val_34;
                UnityEngine.Debug.LogFormat(format:  "Request failed with `{0}`: {1}", args:  val_32);
            }
            
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(429 == 429)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
        private void 下七上丁丄丄七丆专(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)
        {
            string val_27;
            object val_28;
            object val_31;
            var val_32;
            val_27 = 丆丞丄丄丕七三专丐;
            val_28 = this;
            if(val_27 == 3)
            {
                goto label_1;
            }
            
            if(val_27 == 1)
            {
                goto label_2;
            }
            
            if(val_27 != 1)
            {
                goto label_3;
            }
            
            val_27 = Rilisoft.丌丌丏且不不丄三丅.丗丗一上且万专丙丅();
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]> val_2 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]>(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::下丆七下一不上丌且(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, byte[] 一丐丗丁丞丆丅丟丄));
            var val_27 = 0;
            val_27 = val_27 + 1;
            goto label_8;
            label_2:
            if(this.丛丄专丆丐丛丙丞万 == 0)
            {
                goto label_9;
            }
            
            this.丛丄专丆丐丛丙丞万 = 0;
            val_27 = this.丞世世上下丘丟上专;
            new GooglePlayGames.BasicApi.SavedGame.ConflictCallback() = new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::丘丂丒上丕丆丈丆丐(GooglePlayGames.BasicApi.SavedGame.IConflictResolver 丛且东丅丗丌上下下, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 专丑业丁丗丏丌不丛, byte[] 丏且丂丈不丆三不一, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟专上世一丄丞丌万, byte[] 一与七且丒上丐不丒));
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_5 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::下七上丁丄丄七丆专(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌));
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_14;
            label_1:
            val_27 = null;
            val_27 = new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::丂丕三业七丅与业丝(bool 七丒专丘丙丏丙三且));
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丛丗上丝业下不丈丟(业丏丈世世世丞丒世:  null, 与且专丏丅世丐丐丑:  true);
            goto label_67;
            label_3:
            new Rilisoft.丞丂丂丕丅丅丙丝丒() = new Rilisoft.丞丂丂丕丅丅丙丝丒(丆丞丄丄丕七三专丐:  val_27);
            bool val_9 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丞丂丂丕丅丅丙丝丒());
            goto label_67;
            label_9:
            val_27 = this.三七丞且丑业丗丄三;
            if(val_27 == null)
            {
                goto label_21;
            }
            
            bool val_10 = this.丒丌丁世与业下丄下.TrySetResult(result:  val_27);
            goto label_67;
            label_8:
            val_27.ReadBinaryData(metadata:  下上不丄丕丙万丞丌, completedCallback:  null);
            goto label_67;
            label_14:
            Rilisoft.丌丌丏且不不丄三丅.丗丗一上且万专丙丅().OpenWithManualConflictResolution(filename:  val_27, source:  this.丛丄专丆丐丛丙丞万, prefetchDataOnConflict:  true, conflictCallback:  new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(), completedCallback:  null);
            label_67:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_27 = this.万丟丙专东丙万丂万();
                if(val_27.IsFaulted != false)
            {
                    val_31 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  this.万丟丙专东丙万丂万().Exception.InnerExceptions);
                if(val_31 == null)
            {
                    val_31 = this.万丟丙专东丙万丂万().Exception;
            }
            
                object[] val_22 = new object[2];
                val_28 = val_22;
                val_32 = 0;
                System.Type val_23 = val_31.GetType();
                if((val_23 != null) && (val_23 == null))
            {
                    val_32 = 0;
            }
            
                if(val_22.Length == 0)
            {
                    val_32 = 0;
            }
            
                val_28[0] = val_23;
                val_27 = val_31;
                val_28[1] = val_27;
                UnityEngine.Debug.LogFormat(format:  "Request failed with `{0}`: {1}", args:  val_22);
            }
            
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(347 == 347)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            return;
            label_21:
            new Rilisoft.丞丂丂丕丅丅丙丝丒() = new Rilisoft.丞丂丂丕丅丅丙丝丒(丆丞丄丄丕七三专丐:  0);
            goto label_67;
        }
        private void 下丆七下一不上丌且(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, byte[] 一丐丗丁丞丆丅丟丄)
        {
            System.Action<System.Boolean> val_32;
            object val_33;
            int val_34;
            object val_35;
            var val_36;
            string val_37;
            System.Object[] val_38;
            val_32 = 丆丞丄丄丕七三专丐;
            val_33 = this;
            if(val_32 == 3)
            {
                goto label_1;
            }
            
            if(val_32 != 1)
            {
                goto label_2;
            }
            
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                goto label_3;
            }
            
            val_34 = System.Text.Encoding.UTF8;
            goto label_5;
            label_1:
            val_32 = null;
            val_32 = new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.丌丌丏且不不丄三丅::丂丕三业七丅与业丝(bool 七丒专丘丙丏丙三且));
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丛丗上丝业下不丈丟(业丏丈世世世丞丒世:  null, 与且专丏丅世丐丐丑:  true);
            goto label_86;
            label_2:
            if(this.三七丞且丑业丗丄三 == null)
            {
                goto label_10;
            }
            
            bool val_4 = this.丒丌丁世与业下丄下.TrySetResult(result:  this.三七丞且丑业丗丄三);
            goto label_86;
            label_3:
            val_34 = System.String.alignConst;
            label_5:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_6 = new object[1];
                val_6[0] = val_34;
                UnityEngine.Debug.LogFormat(format:  "unmergedResult: {0}", args:  val_6);
            }
            
            if(this.三七丞且丑业丗丄三 != null)
            {
                    val_34 = this.世丁丈一一业业丁丟.Invoke(arg1:  this.三七丞且丑业丗丄三, arg2:  val_34);
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    object[] val_9 = new object[1];
                val_9[0] = val_34;
                UnityEngine.Debug.LogFormat(format:  "result:         {0}", args:  val_9);
            }
            
            val_32 = this.丒丌丁世与业下丄下;
            bool val_10 = val_32.TrySetResult(result:  val_34);
            goto label_86;
            label_10:
            new Rilisoft.丞丂丂丕丅丅丙丝丒() = new Rilisoft.丞丂丂丕丅丅丙丝丒(丆丞丄丄丕七三专丐:  val_32);
            bool val_12 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丞丂丂丕丅丅丙丝丒());
            label_86:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_60;
            }
            
            val_32 = this.万丟丙专东丙万丂万();
            if(val_32.IsCompleted == false)
            {
                goto label_60;
            }
            
            bool val_17 = this.万丟丙专东丙万丂万().IsFaulted;
            val_32 = this.万丟丙专东丙万丂万();
            if(val_32 == null)
            {
                goto label_42;
            }
            
            if(val_17 == false)
            {
                goto label_43;
            }
            
            label_59:
            val_35 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  val_32.Exception.InnerExceptions);
            if(val_35 == null)
            {
                    val_35 = this.万丟丙专东丙万丂万().Exception;
            }
            
            val_33 = new object[2];
            val_36 = 0;
            System.Type val_25 = val_35.GetType();
            if((val_25 != null) && (val_25 == null))
            {
                    val_36 = 0;
            }
            
            if(val_24.Length == 0)
            {
                    val_36 = 0;
            }
            
            val_33[0] = val_25;
            val_32 = val_35;
            val_33[1] = val_32;
            val_37 = "Request failed with `{0}`: {1}";
            val_38 = val_33;
            goto label_58;
            label_42:
            if(val_17 == true)
            {
                goto label_59;
            }
            
            label_43:
            if(val_32.IsCanceled == true)
            {
                goto label_60;
            }
            
            object[] val_27 = new object[1];
            val_32 = val_27;
            val_33 = Rilisoft.丌丌丏且不不丄三丅.丞丐丝丐丝丄世丕下(丏丛与丅丛丌万专丌:  this.万丟丙专东丙万丂万().Result, 丏上万丅丏一不不丕:  32);
            val_32[0] = val_33;
            val_37 = "Request succeeded: `{0}`";
            val_38 = val_32;
            label_58:
            UnityEngine.Debug.LogFormat(format:  val_37, args:  val_27);
            label_60:
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(421 == 421)
            {
                    return;
            }
            
                return;
            }
            
            if(0 != 0)
            {
                    return;
            }
        
        }
    
    }

}
