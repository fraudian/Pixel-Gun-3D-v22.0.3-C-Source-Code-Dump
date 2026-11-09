using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丏且世丐丙万丛丘丅 : ISavedGameClient
    {
        // Fields
        private readonly Rilisoft.丞三一丝丆下丐世丞 丏丙丏丝丏丄万世一;
        private readonly string 丞世世上下丘丟上专;
        private int 专世丕丌东丁丘下世;
        
        // Properties
        public string 与丌丘专专与一丅且 { get; }
        
        // Methods
        public 丏且世丐丙万丛丘丅(string 丂万一与丈丛丝丌丝)
        {
            if(丂万一与丈丛丝丌丝 == null)
            {
                goto label_1;
            }
            
            label_4:
            this.丞世世上下丘丟上专 = 丂万一与丈丛丝丌丝;
            this.丏丙丏丝丏丄万世一 = new Rilisoft.丞三一丝丆下丐世丞(丂万一与丈丛丝丌丝:  丂万一与丈丛丝丌丝);
            return;
            label_1:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        public string 丒丌丒专丙下一丅万()
        {
            return (string)this.丞世世上下丘丟上专;
        }
        public void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate 丙三东丅丏丘七丗丈, byte[] 世丁丁丟丑世丗丆丌, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 业丏丈世世世丞丒世)
        {
            var val_8;
            丏且世丐丙万丛丘丅.丘丞上世丗丘丏丐东 val_1 = new 丏且世丐丙万丛丘丅.丘丞上世丗丘丏丐东();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            }
            else
            {
                    val_8 = 16;
                mem[16] = 业丏丈世世世丞丒世;
            }
            
            .丝且与丝丒丟万丁专 = this;
            object[] val_2 = new object[2];
            val_2[0] = this.GetType();
            val_2[1] = this.丞世世上下丘丟上专;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').CommitUpdate()", args:  val_2);
            if(val_8 == 0)
            {
                    return;
            }
            
            CoroutineRunner val_5 = CoroutineRunner.Instance;
            UnityEngine.Coroutine val_7 = val_5.StartCoroutine(routine:  val_5.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void 丏且世丐丙万丛丘丅.丘丞上世丗丘丏丐东::丒丌下丐丝丏丘上东())));
        }
        public void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)
        {
            object[] val_1 = new object[2];
            System.Type val_2 = this.GetType();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = this.丞世世上下丘丟上专;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').Delete()", args:  val_1);
        }
        public void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource 丑东与丅丐丅丂丞业, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> 业丏丈世世世丞丒世)
        {
            .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            object[] val_2 = new object[2];
            val_2[0] = this.GetType();
            val_2[1] = this.丞世世上下丘丟上专;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').FetchAllSavedGames()", args:  val_2);
            if((丏且世丐丙万丛丘丅.业东下丕世丗丏万丏)[1152921543638644416].业丏丈世世世丞丒世 == null)
            {
                    return;
            }
            
            CoroutineRunner val_5 = CoroutineRunner.Instance;
            UnityEngine.Coroutine val_7 = val_5.StartCoroutine(routine:  val_5.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  new 丏且世丐丙万丛丘丅.业东下丕世丗丏万丏(), method:  System.Void 丏且世丐丙万丛丘丅.业东下丕世丗丏万丏::世丌丗丒专丆与丟丅())));
        }
        public void OpenWithAutomaticConflictResolution(string 丂万一与丈丛丝丌丝, GooglePlayGames.BasicApi.DataSource 丑东与丅丐丅丂丞业, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy 丆丗丞丗与丒三丒丏, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 业丏丈世世世丞丒世)
        {
            var val_8;
            丏且世丐丙万丛丘丅.丌万一一业丝丁丈丝 val_1 = new 丏且世丐丙万丛丘丅.丌万一一业丝丁丈丝();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            }
            else
            {
                    val_8 = 16;
                mem[16] = 业丏丈世世世丞丒世;
            }
            
            .丝且与丝丒丟万丁专 = this;
            object[] val_2 = new object[2];
            val_2[0] = this.GetType();
            val_2[1] = this.丞世世上下丘丟上专;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').OpenWithAutomaticConflictResolution()", args:  val_2);
            if(val_8 == 0)
            {
                    return;
            }
            
            CoroutineRunner val_5 = CoroutineRunner.Instance;
            UnityEngine.Coroutine val_7 = val_5.StartCoroutine(routine:  val_5.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void 丏且世丐丙万丛丘丅.丌万一一业丝丁丈丝::丅丙丟业上万丌业七())));
        }
        public void OpenWithManualConflictResolution(string 丂万一与丈丛丝丌丝, GooglePlayGames.BasicApi.DataSource 丑东与丅丐丅丂丞业, bool 业丝丅丂丁丐丑丟丙, GooglePlayGames.BasicApi.SavedGame.ConflictCallback 上丝丁上丗丄丒丟丘, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 一丒专丞丘丝丙丌丕)
        {
            System.Object[] val_14;
            var val_15;
            var val_16;
            System.Collections.IEnumerator val_17;
            丏且世丐丙万丛丘丅.下丌丛三下专丘丐丕 val_1 = new 丏且世丐丙万丛丘丅.下丌丛三下专丘丐丕();
            if(val_1 != null)
            {
                    .上丝丁上丗丄丒丟丘 = 上丝丁上丗丄丒丟丘;
                .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[16] = 上丝丁上丗丄丒丟丘;
                mem[24] = this;
            }
            
            .一丒专丞丘丝丙丌丕 = 一丒专丞丘丝丙丌丕;
            int val_14 = this.专世丕丌东丁丘下世;
            object[] val_2 = new object[3];
            val_14 = val_2;
            System.Type val_3 = this.GetType();
            if(val_14 == null)
            {
                goto label_4;
            }
            
            if(val_3 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_3 == null)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            val_14 = val_14 & 1;
            val_14[0] = val_3;
            int val_4 = val_14 ^ 1;
            val_14[1] = this.丞世世上下丘丟上专;
            if(val_4 != false)
            {
                    val_15 = val_4;
            }
            
            val_14[2] = val_4;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\', {2}).OpenWithManualConflictResolution()", args:  val_2);
            if(val_14 != 0)
            {
                goto label_18;
            }
            
            丏且世丐丙万丛丘丅.不丏业丅业丙丞丄丛 val_5 = null;
            val_14 = val_5;
            val_5 = new 丏且世丐丙万丛丘丅.不丏业丅业丙丞丄丛();
            if(val_14 == null)
            {
                goto label_19;
            }
            
            val_16 = val_14;
            .东丟且丗且三专丙丁 = val_1;
            goto label_20;
            label_18:
            if((丏且世丐丙万丛丘丅.下丌丛三下专丘丐丕)[1152921543639101296].一丒专丞丘丝丙丌丕 == null)
            {
                    return;
            }
            
            val_14 = CoroutineRunner.Instance.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void 丏且世丐丙万丛丘丅.下丌丛三下专丘丐丕::丘丟丐三七与东丕业()));
            val_17 = val_14;
            goto label_25;
            label_19:
            val_16 = 24;
            mem[24] = val_1;
            label_20:
            if(.上丝丁上丗丄丒丟丘 == null)
            {
                    return;
            }
            
            .一丐丗丁丞丆丅丟丄 = System.Text.Encoding.UTF8;
            CoroutineRunner val_11 = CoroutineRunner.Instance;
            val_14 = val_11;
            val_17 = val_11.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  val_5, method:  System.Void 丏且世丐丙万丛丘丅.不丏业丅业丙丞丄丛::丂丙与丙丗丒丑业业()));
            label_25:
            UnityEngine.Coroutine val_13 = val_14.StartCoroutine(routine:  val_17);
            int val_15 = this.专世丕丌东丁丘下世;
            val_15 = val_15 + 1;
            this.专世丕丌东丁丘下世 = val_15;
        }
        public void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, byte[]> 一丒专丞丘丝丙丌丕)
        {
            .一丒专丞丘丝丙丌丕 = 一丒专丞丘丝丙丌丕;
            object[] val_2 = new object[2];
            val_2[0] = this.GetType();
            val_2[1] = this.丞世世上下丘丟上专;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').ReadBinaryData()", args:  val_2);
            if((丏且世丐丙万丛丘丅.丗丛丘丑丐不丌丑丙)[1152921543639333280].一丒专丞丘丝丙丌丕 == null)
            {
                    return;
            }
            
            .上丕丗业丌专丘与丌 = System.Text.Encoding.UTF8;
            CoroutineRunner val_6 = CoroutineRunner.Instance;
            UnityEngine.Coroutine val_8 = val_6.StartCoroutine(routine:  val_6.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  new 丏且世丐丙万丛丘丅.丗丛丘丑丐不丌丑丙(), method:  System.Void 丏且世丐丙万丛丘丅.丗丛丘丑丐不丌丑丙::丁丈丟丆下丞丒东七())));
        }
        public void ShowSelectSavedGameUI(string 业与与丐三丘丙丁丞, uint 一七丛专丞与与丙丁, bool 丏丏世丘丕丐丁丛丄, bool 丑丂一丏七丄丘七丄, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> 业丏丈世世世丞丒世)
        {
            var val_8;
            丏且世丐丙万丛丘丅.丒丛丁与丅东丒不七 val_1 = new 丏且世丐丙万丛丘丅.丒丛丁与丅东丒不七();
            if(val_1 != null)
            {
                    val_8 = val_1;
                .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            }
            else
            {
                    val_8 = 16;
                mem[16] = 业丏丈世世世丞丒世;
            }
            
            .丝且与丝丒丟万丁专 = this;
            object[] val_2 = new object[2];
            val_2[0] = this.GetType();
            val_2[1] = this.丞世世上下丘丟上专;
            UnityEngine.Debug.LogFormat(format:  "{0}(\'{1}\').ShowSelectSavedGameUI()", args:  val_2);
            if(val_8 == 0)
            {
                    return;
            }
            
            CoroutineRunner val_5 = CoroutineRunner.Instance;
            UnityEngine.Coroutine val_7 = val_5.StartCoroutine(routine:  val_5.丁丏与丛丁丌万不专(七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void 丏且世丐丙万丛丘丅.丒丛丁与丅东丒不七::上丑世与与万丝丂丑())));
        }
        private System.Collections.IEnumerator 丁丏与丛丁丌万不专(System.Action 七丐丅专且专七三丆)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .七丐丅专且专七三丆 = 七丐丅专且专七三丆;
            return (System.Collections.IEnumerator)new 丏且世丐丙万丛丘丅.万不丕丈三丂世三且();
        }
    
    }

}
