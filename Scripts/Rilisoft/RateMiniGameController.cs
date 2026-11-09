using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class RateMiniGameController : MonoBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.List<UILabel> _gameTitleLabels;
        private readonly System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.DateTime> _lastSentTimestamps;
        private System.IDisposable _backSubscription;
        private int _currentRatingInGui;
        private Rilisoft.七丕丟丏三丈一丄世 _gameMode;
        private UnityEngine.GameObject _gameTitle;
        private string _miniGameRatingKey;
        private UnityEngine.GameObject _rateGameWindow;
        private Rilisoft.StarView[] _starViews;
        
        // Properties
        internal Rilisoft.七丕丟丏三丈一丄世 GameMode { get; set; }
        private string MiniGameRatingKey { get; }
        
        // Methods
        internal Rilisoft.七丕丟丏三丈一丄世 get_GameMode()
        {
            return (Rilisoft.七丕丟丏三丈一丄世)this._gameMode;
        }
        internal void set_GameMode(Rilisoft.七丕丟丏三丈一丄世 丙业与丙丗丝不丈东)
        {
            if(this._gameMode == 丙业与丙丗丝不丈东)
            {
                    return;
            }
            
            this._gameMode = 丙业与丙丗丝不丈东;
            this.丏丙丞专东丗丅东丕();
            this._miniGameRatingKey = 0;
            int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  this.MiniGameRatingKey, defaultValue:  0);
            this._currentRatingInGui = val_2;
            this.丝丂专丄丁丛丐七丘(丈丐世下丞与丂专丏:  val_2);
        }
        private string get_MiniGameRatingKey()
        {
            string val_3;
            if((System.String.IsNullOrEmpty(value:  this._miniGameRatingKey)) != false)
            {
                    this._miniGameRatingKey = "MiniGameRating." + this._gameMode;
                return val_3;
            }
            
            val_3 = this._miniGameRatingKey;
            return val_3;
        }
        public void HandleSubmitRating()
        {
            long val_13;
            object val_14;
            if(this._currentRatingInGui != 0)
            {
                    UnityEngine.PlayerPrefs.SetInt(key:  this.MiniGameRatingKey, value:  this._currentRatingInGui);
                if((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != true)
            {
                    System.DateTime val_4 = System.DateTime.UtcNow;
                bool val_5 = this._lastSentTimestamps.TryGetValue(key:  this._gameMode, value: out  new System.DateTime());
                System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_4.dateData}, d2:  new System.DateTime());
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    System.TimeSpan val_8 = System.TimeSpan.FromSeconds(value:  10);
                val_13 = val_8._ticks;
            }
            else
            {
                    System.TimeSpan val_9 = System.TimeSpan.FromMinutes(value:  10);
                val_13 = val_9._ticks;
            }
            
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_6._ticks}, t2:  new System.TimeSpan() {_ticks = val_13})) != false)
            {
                    object[] val_11 = new object[3];
                val_11[0] = this._gameMode;
                val_11[1] = this._gameMode;
                val_14 = this._currentRatingInGui;
                val_11[2] = val_14;
                UnityEngine.Debug.LogFormat(format:  "Sending rating {0} ({1}): {2}", args:  val_11);
                this.丑世丏万东一丌与丌();
            }
            else
            {
                    object[] val_12 = new object[4];
                val_14 = val_12;
                val_14[0] = this._gameMode;
                val_14[1] = this._gameMode;
                val_14[2] = this._currentRatingInGui;
                val_14[3] = val_6;
                UnityEngine.Debug.LogFormat(format:  "Skipping sending rating {0} ({1}): {2}; elapsed: {3}", args:  val_12);
            }
            
            }
            
            }
            
            this.丘丘一七丛东丑丕专(下下东且万业丞丅丒:  false);
        }
        private void 丑世丏万东一丌与丌()
        {
            var val_5;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.Add(key:  "mode", value:  this._gameMode);
            val_1.Add(key:  "rating", value:  this._currentRatingInGui);
            val_5 = null;
            val_5 = null;
            if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.且一且丒丞与丒业丕, 一丐丗丁丞丆丅丟丄:  val_1, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.RateMiniGameController::丙丗丑丘且一丒丂丗(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)))) != 1)
            {
                    return;
            }
            
            this.丘丘一七丛东丑丕专(下下东且万业丞丅丒:  false);
        }
        private void 丙丗丑丘且一丒丂丗(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            Rilisoft.七丕丟丏三丈一丄世 val_8;
            object val_1 = 0;
            object val_3 = 0;
            if(东丞丒丙世丏三下丟 == null)
            {
                    return;
            }
            
            val_8 = 1152921518937165328;
            if((东丞丒丙世丏三下丟.TryGetValue(key:  "mode", value: out  val_1)) == false)
            {
                    return;
            }
            
            if((东丞丒丙世丏三下丟.TryGetValue(key:  "rating", value: out  val_3)) == false)
            {
                    return;
            }
            
            val_8 = this._gameMode;
            this = System.Convert.ToInt32(value:  val_3);
            System.DateTime val_7 = System.DateTime.UtcNow;
            this._lastSentTimestamps.set_Item(key:  val_8, value:  new System.DateTime() {dateData = val_7.dateData});
            Rilisoft.一丟专且三万丞丁丂.丒丕丞丕丂丞下丏与(丈丐世下丞与丂专丏:  this, 丂丛丑东不丅丈一东:  System.Convert.ToInt32(value:  val_1));
        }
        internal void 丘丘一七丛东丑丕专(bool 下下东且万业丞丅丒)
        {
            int val_11;
            System.IDisposable val_12;
            if(this._rateGameWindow == 0)
            {
                    UnityEngine.Debug.LogError(message:  "_rateGameWindow should not be null.");
                return;
            }
            
            if(下下东且万业丞丅丒 == false)
            {
                goto label_6;
            }
            
            this.丏丙丞专东丗丅东丕();
            if((UnityEngine.PlayerPrefs.HasKey(key:  this.MiniGameRatingKey)) == false)
            {
                goto label_7;
            }
            
            val_11 = UnityEngine.PlayerPrefs.GetInt(key:  this.MiniGameRatingKey);
            this._currentRatingInGui = val_11;
            goto label_8;
            label_6:
            val_12 = this._backSubscription;
            if(val_12 == null)
            {
                goto label_17;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_13;
            label_7:
            val_11 = this._currentRatingInGui;
            label_8:
            this.丝丂专丄丁丛丐七丘(丈丐世下丞与丂专丏:  val_11);
            val_12 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            this._backSubscription = val_12.Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.RateMiniGameController::丐一丂丒丛丛业三丞()), 与且专丈不万东一万:  0);
            goto label_17;
            label_13:
            val_12.Dispose();
            this._backSubscription = 0;
            label_17:
            this._rateGameWindow.SetActive(value:  下下东且万业丞丅丒);
        }
        private void Awake()
        {
            业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.RateMiniGameController::丆与丂且丐与丝且丅()));
            if(this._starViews == null)
            {
                    return;
            }
            
            if(this._starViews.Length == 0)
            {
                    return;
            }
            
            int val_5 = 0;
            do
            {
                RateMiniGameController.与丟业一丈上丅上不 val_2 = new RateMiniGameController.与丟业一丈上丅上不();
                if(val_2 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[24] = this;
            }
            
                .丞世不丒下上上丝丑 = val_5;
                this._starViews[0].七一丕丁丅且专一丂(丙业与丙丗丝不丈东:  new System.EventHandler(object:  val_2, method:  System.Void RateMiniGameController.与丟业一丈上丅上不::丘丏丘丕丙专丐业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
                val_5 = val_5 + 1;
            }
            while(this._starViews.Length != val_5);
        
        }
        private void 丆与丂且丐与丝且丅()
        {
            if(this._rateGameWindow == 0)
            {
                    return;
            }
            
            if(this._rateGameWindow.activeInHierarchy == false)
            {
                    return;
            }
            
            this.丘丘一七丛东丑丕专(下下东且万业丞丅丒:  false);
        }
        private void 东三七丒世丂丝丌丑(int 丞世不丒下上上丝丑)
        {
            System.Object[] val_4;
            if(UnityEngine.Application.isEditor != false)
            {
                    object[] val_2 = new object[1];
                val_4 = val_2;
                val_4[0] = 丞世不丒下上上丝丑;
                UnityEngine.Debug.LogFormat(format:  "HandleStarClicked({0})", args:  val_2);
            }
            
            int val_3 = 丞世不丒下上上丝丑 + 1;
            this._currentRatingInGui = val_3;
            this.丝丂专丄丁丛丐七丘(丈丐世下丞与丂专丏:  val_3);
            this.HandleSubmitRating();
        }
        private void 丝丂专丄丁丛丐七丘(int 丈丐世下丞与丂专丏)
        {
            Rilisoft.StarView[] val_3;
            var val_4;
            Rilisoft.StarView[] val_5;
            Rilisoft.StarView val_6;
            val_3 = this._starViews;
            if(val_3 == null)
            {
                    return;
            }
            
            if(this._starViews.Length == 0)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_2;
            label_6:
            val_5 = this._starViews;
            val_4 = 1;
            label_2:
            val_6 = val_5[1];
            val_6.丘丘一七丛东丑丕专(下下东且万业丞丅丒:  (val_4 < 丈丐世下丞与丂专丏) ? 1 : 0);
            if((this._starViews.Length - 1) != val_4)
            {
                goto label_6;
            }
        
        }
        private void 丏丙丞专东丗丅东丕()
        {
            System.Collections.Generic.List<UILabel> val_8;
            var val_9;
            int val_11;
            val_8 = this;
            if(this._gameTitle == 0)
            {
                    return;
            }
            
            if(this._gameMode != 12)
            {
                goto label_4;
            }
            
            val_9 = "Key_0456";
            goto label_5;
            label_4:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if((GameConnect.丛丛丏专丏下三与七().TryGetValue(key:  0, value: out  0)) == false)
            {
                goto label_13;
            }
            
            val_11 = System.String.alignConst;
            goto label_14;
            label_13:
            label_5:
            label_14:
            if(this._gameTitleLabels.Count == 0)
            {
                    this._gameTitle.GetComponentsInChildren<UILabel>(includeInactive:  true, results:  this._gameTitleLabels);
            }
            
            val_8 = this._gameTitleLabels;
            List.Enumerator<T> val_8 = val_8.GetEnumerator();
            label_23:
            if(( & 1) == 0)
            {
                goto label_21;
            }
            
            0.丐丏七丌丕丗业且上().text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.__il2cppRuntimeField_static_fields);
            goto label_23;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void OnDestroy()
        {
            业丞丝东丅丞丐丌专.丌三三丑丗丟丒且丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.RateMiniGameController::丆与丂且丐与丝且丅()));
        }
        public RateMiniGameController()
        {
            this._gameTitleLabels = new System.Collections.Generic.List<UILabel>(capacity:  3);
            this._lastSentTimestamps = new System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.DateTime>(capacity:  6);
        }
        private void 丐一丂丒丛丛业三丞()
        {
            this.丘丘一七丛东丑丕专(下下东且万业丞丅丒:  false);
        }
    
    }

}
