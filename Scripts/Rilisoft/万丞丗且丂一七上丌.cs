using UnityEngine;

namespace Rilisoft
{
    internal sealed class 万丞丗且丂一七上丌
    {
        // Fields
        private const string 丏下丛丛丁业丒丒东 = "[Rilisoft] SavedGame client is null.";
        private readonly string 丁丘丄丕下专东七不;
        private readonly string 丞世世上下丘丟上专;
        private readonly System.Func<string, string, string> 世丁丈一一业业丁丟;
        private readonly System.Threading.Tasks.TaskCompletionSource<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 丒丌丁世与业下丄下;
        private string 三七丞且丑业丗丄三;
        private GooglePlayGames.BasicApi.DataSource 丛丄专丆丐丛丙丞万;
        private bool 丒业丐一丛与丕丏丄;
        private System.EventHandler<Rilisoft.丘丟丙丑丆丂丒且与> 下与且七东下与丙世;
        
        // Properties
        private string 与丌丘专专与一丅且 { get; }
        private System.Threading.Tasks.Task<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 业三世丌三丑业万东 { get; }
        private static GooglePlayGames.BasicApi.SavedGame.ISavedGameClient 丐丕丛丏丌专丆不丈 { get; }
        
        // Methods
        internal 万丞丗且丂一七上丌(string 丂万一与丈丛丝丌丝, System.Func<string, string, string> 三且丘上丁业上丝丞, string 一丐丗丁丞丆丅丟丄, System.Threading.Tasks.TaskCompletionSource<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 世丅丒丆三下专丘丆)
        {
            int val_3;
            string val_5;
            val_3 = 丂万一与丈丛丝丌丝;
            this.丛丄专丆丐丛丙丞万 = 1;
            val_1 = new System.Object();
            if(三且丘上丁业上丝丞 == null)
            {
                goto label_1;
            }
            
            if(世丅丒丆三下专丘丆 == null)
            {
                goto label_2;
            }
            
            if(val_3 == null)
            {
                    val_3 = System.String.alignConst;
            }
            
            this.丁丘丄丕下专东七不 = val_1;
            this.丞世世上下丘丟上专 = val_3;
            this.世丁丈一一业业丁丟 = 三且丘上丁业上丝丞;
            this.丒丌丁世与业下丄下 = 世丅丒丆三下专丘丆;
            return;
            label_1:
            val_5 = "merger";
            goto label_4;
            label_2:
            val_5 = "promise";
            label_4:
            null = new System.ArgumentNullException(paramName:  val_5);
        }
        private string 丒丌丒专丙下一丅万()
        {
            return (string)this.丞世世上下丘丟上专;
        }
        private System.Threading.Tasks.Task<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 万丟丙专东丙万丂万()
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
            while(this.下与且七东下与丙世 != 1152921542504967744);
        
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
            while(this.下与且七东下与丙世 != 1152921542505104320);
        
        }
        internal void 丄丄丛万丁丐丐与丏()
        {
            bool val_3 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅();
            string val_5 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "GooglePushHelper(`{0}`).Run(); isAuthenticated: `{1}`", arg0:  this.丞世世上下丘丟上专, arg1:  val_3);
            bool val_7 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(this.丒业丐一丛与丕丏丄 == true)
            {
                    return;
            }
            
            this.丒业丐一丛与丕丏丄 = true;
            if(val_3 != false)
            {
                    this.业东一丄丛且七业丞();
                return;
            }
            
            this = this.丒丌丁世与业下丄下;
            new Rilisoft.丆丈丌业下丝三东世() = new Rilisoft.丆丈丌业下丝三东世(丄丙下丝丛丒七丂丘:  "Not authenticated");
            bool val_9 = this.TrySetException(exception:  new Rilisoft.丆丈丌业下丝三东世());
        }
        private void 业东一丄丛且七业丞()
        {
            if(Rilisoft.万丞丗且丂一七上丌.丗丗一上且万专丙丅() != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
            }
            else
            {
                    bool val_6 = this.丒丌丁世与业下丄下.TrySetException(exception:  new System.InvalidOperationException(message:  "[Rilisoft] SavedGame client is null."));
                return;
            }
            
            Rilisoft.万丞丗且丂一七上丌.丗丗一上且万专丙丅().OpenWithManualConflictResolution(filename:  this.丞世世上下丘丟上专, source:  this.丛丄专丆丐丛丙丞万, prefetchDataOnConflict:  true, conflictCallback:  new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  this, method:  System.Void Rilisoft.万丞丗且丂一七上丌::丘丂丒上丕丆丈丆丐(GooglePlayGames.BasicApi.SavedGame.IConflictResolver 丛且东丅丗丌上下下, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 专丑业丁丗丏丌不丛, byte[] 丏且丂丈不丆三不一, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟专上世一丄丞丌万, byte[] 一与七且丒上丐不丒)), completedCallback:  new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  this, method:  System.Void Rilisoft.万丞丗且丂一七上丌::下七上丁丄丄七丆专(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)));
        }
        private void 丘丂丒上丕丆丈丆丐(GooglePlayGames.BasicApi.SavedGame.IConflictResolver 丛且东丅丗丌上下下, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 专丑业丁丗丏丌不丛, byte[] 丏且丂丈不丆三不一, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟专上世一丄丞丌万, byte[] 一与七且丒上丐不丒)
        {
            GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata val_33;
            object val_34;
            object val_35;
            int val_36;
            var val_37;
            int val_38;
            string val_39;
            string val_40;
            var val_42;
            var val_44;
            var val_46;
            var val_48;
            var val_51;
            object val_53;
            var val_54;
            val_33 = 丟专上世一丄丞丌万;
            val_34 = this;
            val_35 = Rilisoft.丌丌丏且不不丄三丅.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  专丑业丁丗丏丌不丛);
            val_36 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "GooglePushHelper(`{0}`).HandleOpenConflict(`{1}`, `{2}`)", arg0:  this.丞世世上下丘丟上专, arg1:  val_35, arg2:  Rilisoft.丌丌丏且不不丄三丅.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  val_33));
            val_37 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(丏且丂丈不丆三不一 == null)
            {
                goto label_5;
            }
            
            if(一与七且丒上丐不丒 == null)
            {
                goto label_6;
            }
            
            val_38 = System.Text.Encoding.UTF8;
            if(val_38 == null)
            {
                    val_38 = System.String.alignConst;
            }
            
            val_36 = System.Text.Encoding.UTF8;
            if(val_36 == null)
            {
                    val_36 = System.String.alignConst;
            }
            
            val_35 = 1152921542497869888;
            val_39 = val_36;
            val_40 = this.世丁丈一一业业丁丟.Invoke(arg1:  val_38, arg2:  val_39);
            if(val_38 == val_40)
            {
                goto label_12;
            }
            
            if(val_36 == val_40)
            {
                goto label_13;
            }
            
            if(this.三七丞且丑业丗丄三 != null)
            {
                    val_36 = this.世丁丈一一业业丁丟;
                val_40 = val_36.Invoke(arg1:  this.三七丞且丑业丗丄三, arg2:  val_40);
            }
            
            this.三七丞且丑业丗丄三 = val_40;
            if(this.下与且七东下与丙世 != null)
            {
                    val_36 = new Rilisoft.丘丟丙丑丆丂丒且与();
                val_36 = new Rilisoft.丘丟丙丑丆丂丒且与(不丒不丗万丌丘丂丐:  val_40);
                this.下与且七东下与丙世.Invoke(sender:  this, e:  new Rilisoft.丘丟丙丑丆丂丒且与());
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            goto label_21;
            label_5:
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_42 = 0;
            goto label_26;
            label_6:
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_44 = 0;
            goto label_31;
            label_12:
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_46 = 0;
            goto label_36;
            label_26:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  val_33);
            goto label_100;
            label_13:
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_48 = 0;
            goto label_42;
            label_31:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  专丑业丁丗丏丌不丛);
            goto label_100;
            label_21:
            System.DateTime val_14 = 专丑业丁丗丏丌不丛.LastModifiedTimestamp;
            var val_39 = 0;
            val_39 = val_39 + 1;
            System.DateTime val_16 = val_33.LastModifiedTimestamp;
            val_51 = 0;
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_51 = 0;
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  ((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_14.dateData}, t2:  new System.DateTime() {dateData = val_16.dateData})) != true) ? 专丑业丁丗丏丌不丛 : (val_33));
            goto label_100;
            label_36:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  专丑业丁丗丏丌不丛);
            goto label_100;
            label_42:
            丛且东丅丗丌上下下.ChooseMetadata(chosenMetadata:  val_33);
            label_100:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_33 = this.万丟丙专东丙万丂万();
                if(val_33.IsFaulted != false)
            {
                    val_53 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  this.万丟丙专东丙万丂万().Exception.InnerExceptions);
                if(val_53 == null)
            {
                    val_53 = this.万丟丙专东丙万丂万().Exception;
            }
            
                object[] val_31 = new object[2];
                val_34 = val_31;
                val_54 = 0;
                System.Type val_32 = val_53.GetType();
                if((val_32 != null) && (val_32 == null))
            {
                    val_54 = 0;
            }
            
                if(val_31.Length == 0)
            {
                    val_54 = 0;
            }
            
                val_34[0] = val_32;
                val_33 = val_53;
                val_34[1] = val_33;
                UnityEngine.Debug.LogFormat(format:  "Request failed with `{0}`: {1}", args:  val_31);
            }
            
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(406 == 406)
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
            bool val_18;
            bool val_19;
            bool val_20;
            bool val_21;
            bool val_22;
            bool val_23;
            var val_43;
            object val_44;
            var val_45;
            GooglePlayGames.BasicApi.DataSource val_46;
            string val_47;
            string val_48;
            int val_50;
            object val_52;
            var val_53;
            val_43;
            val_44 = 丆丞丄丄丕七三专丐;
            val_45 = 1152921505171275776;
            val_46 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "GooglePushHelper(`{0}`).HandleOpenCompleted(`{1}`, `{2}`)", arg0:  this.丞世世上下丘丟上专, arg1:  丆丞丄丄丕七三专丐, arg2:  Rilisoft.丌丌丏且不不丄三丅.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  下上不丄丕丙万丞丌));
            bool val_5 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(丆丞丄丄丕七三专丐 == 1)
            {
                goto label_5;
            }
            
            if(丆丞丄丄丕七三专丐 != 1)
            {
                goto label_6;
            }
            
            if(this.三七丞且丑业丗丄三 == null)
            {
                goto label_7;
            }
            
            val_47 = this.世丁丈一一业业丁丟.Invoke(arg1:  this.三七丞且丑业丗丄三, arg2:  this.丁丘丄丕下专东七不);
            val_48 = this.三七丞且丑业丗丄三;
            goto label_9;
            label_5:
            if(this.丛丄专丆丐丛丙丞万 == 0)
            {
                goto label_10;
            }
            
            this.丛丄专丆丐丛丙丞万 = 0;
            val_46 = this.丛丄专丆丐丛丙丞万;
            new GooglePlayGames.BasicApi.SavedGame.ConflictCallback() = new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(object:  this, method:  System.Void Rilisoft.万丞丗且丂一七上丌::丘丂丒上丕丆丈丆丐(GooglePlayGames.BasicApi.SavedGame.IConflictResolver 丛且东丅丗丌上下下, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 专丑业丁丗丏丌不丛, byte[] 丏且丂丈不丆三不一, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 丟专上世一丄丞丌万, byte[] 一与七且丒上丐不丒));
            val_44 = null;
            val_45 = 1152921505171275776;
            val_44 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  this, method:  System.Void Rilisoft.万丞丗且丂一七上丌::下七上丁丄丄七丆专(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌));
            var val_43 = 0;
            val_43 = val_43 + 1;
            goto label_15;
            label_6:
            val_46 = new Rilisoft.丞丂丂丕丅丅丙丝丒();
            val_46 = new Rilisoft.丞丂丂丕丅丅丙丝丒(丆丞丄丄丕七三专丐:  丆丞丄丄丕七三专丐);
            bool val_11 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丞丂丂丕丅丅丙丝丒());
            goto label_44;
            label_7:
            val_47 = this.丁丘丄丕下专东七不;
            val_48 = 0;
            label_9:
            object val_12 = (val_48 == 0) ? "none" : "merged";
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                goto label_20;
            }
            
            object[] val_14 = new object[2];
            val_14[0] = val_12;
            val_50 = val_47;
            val_44 = "conflict: {0}, result: {1}";
            if(val_47 != null)
            {
                goto label_25;
            }
            
            val_50 = System.String.alignConst;
            if(val_50 == 0)
            {
                goto label_27;
            }
            
            label_25:
            label_27:
            val_14[1] = val_50;
            UnityEngine.Debug.LogFormat(format:  val_44, args:  val_14);
            label_20:
            string val_17 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "device:\'{0}\', conflict:\'{1}\'", arg0:  UnityEngine.SystemInfo.deviceModel, arg1:  val_12);
            System.Text.Encoding val_24 = System.Text.Encoding.UTF8;
            if(val_47 == null)
            {
                goto label_33;
            }
            
            if(val_24 != null)
            {
                goto label_38;
            }
            
            goto label_35;
            label_10:
            new Rilisoft.丞丂丂丕丅丅丙丝丒() = new Rilisoft.丞丂丂丕丅丅丙丝丒(丆丞丄丄丕七三专丐:  0);
            bool val_26 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丞丂丂丕丅丅丙丝丒());
            goto label_44;
            label_33:
            val_47 = System.String.alignConst;
            if(val_24 != null)
            {
                goto label_38;
            }
            
            label_35:
            label_38:
            val_46 = Rilisoft.万丞丗且丂一七上丌.丗丗一上且万专丙丅();
            val_18 = val_21;
            val_19 = val_22;
            val_20 = val_23;
            val_45 = 1152921505171275776;
            System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> val_28 = new System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>(object:  this, method:  System.Void Rilisoft.万丞丗且丂一七上丌::与且丅丞丛丝丄万且(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌));
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_46.CommitUpdate(metadata:  下上不丄丕丙万丞丌, updateForMetadata:  new GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate() {mDescriptionUpdated = val_20, mNewDescription = val_20, mCoverImageUpdated = val_18, mNewPngCoverImage = val_18, mNewPlayedTime = new System.Nullable<System.TimeSpan>() {HasValue = val_19}}, updatedBinaryData:  val_24, callback:  null);
            goto label_44;
            label_15:
            Rilisoft.万丞丗且丂一七上丌.丗丗一上且万专丙丅().OpenWithManualConflictResolution(filename:  this.丞世世上下丘丟上专, source:  val_46, prefetchDataOnConflict:  true, conflictCallback:  new GooglePlayGames.BasicApi.SavedGame.ConflictCallback(), completedCallback:  null);
            label_44:
            if((与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false) && (this.万丟丙专东丙万丂万().IsFaulted != false))
            {
                    val_52 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  this.万丟丙专东丙万丂万().Exception.InnerExceptions);
                if(val_52 == null)
            {
                    val_52 = this.万丟丙专东丙万丂万().Exception;
            }
            
                object[] val_40 = new object[2];
                val_53 = 0;
                val_46 = val_52.GetType();
                if((val_46 != null) && (val_46 == null))
            {
                    val_53 = 0;
            }
            
                if(val_40.Length == 0)
            {
                    val_53 = 0;
            }
            
                val_40[0] = val_46;
                val_40[1] = val_52;
                UnityEngine.Debug.LogFormat(format:  "Request failed with `{0}`: {1}", args:  val_40);
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(483 == 483)
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
        private void 与且丅丞丛丝丄万且(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus 丆丞丄丄丕七三专丐, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)
        {
            GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus val_21;
            System.Object[] val_22;
            object val_23;
            var val_24;
            val_21 = 丆丞丄丄丕七三专丐;
            val_22 = this;
            string val_3 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "GooglePushHelper(`{0}`).HandleCommitCompleted(`{1}`, `{2}`)", arg0:  this.丞世世上下丘丟上专, arg1:  val_21, arg2:  Rilisoft.丌丌丏且不不丄三丅.东且丏丆万与东丙万(下上不丄丕丙万丞丌:  下上不丄丕丙万丞丌));
            bool val_5 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            if(val_21 == 1)
            {
                    bool val_6 = this.丒丌丁世与业下丄下.TrySetResult(result:  下上不丄丕丙万丞丌);
            }
            else
            {
                    new Rilisoft.丞丂丂丕丅丅丙丝丒() = new Rilisoft.丞丂丂丕丅丅丙丝丒(丆丞丄丄丕七三专丐:  val_21);
                bool val_8 = this.丒丌丁世与业下丄下.TrySetException(exception:  new Rilisoft.丞丂丂丕丅丅丙丝丒());
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    val_21 = this.万丟丙专东丙万丂万();
                if(val_21.IsFaulted != false)
            {
                    val_23 = System.Linq.Enumerable.FirstOrDefault<System.Exception>(source:  this.万丟丙专东丙万丂万().Exception.InnerExceptions);
                if(val_23 == null)
            {
                    val_23 = this.万丟丙专东丙万丂万().Exception;
            }
            
                object[] val_18 = new object[2];
                val_22 = val_18;
                val_24 = 0;
                System.Type val_19 = val_23.GetType();
                if((val_19 != null) && (val_19 == null))
            {
                    val_24 = 0;
            }
            
                if(val_18.Length == 0)
            {
                    val_24 = 0;
            }
            
                val_22[0] = val_19;
                val_21 = val_23;
                val_22[1] = val_21;
                UnityEngine.Debug.LogFormat(format:  "Request failed with `{0}`: {1}", args:  val_18);
            }
            
            }
            
            if(0 != 1)
            {
                    if(0 == 0)
            {
                    return;
            }
            
                if(199 == 199)
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
