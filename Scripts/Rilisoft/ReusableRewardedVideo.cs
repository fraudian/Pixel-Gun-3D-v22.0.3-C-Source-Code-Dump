using UnityEngine;

namespace Rilisoft
{
    internal sealed class ReusableRewardedVideo : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 丗下丘世三七一专丕;
        private string 丛世丘丞丁三丈丕丕;
        private System.DateTime <丑丆一丌三丆丑丑专>k__BackingField;
        private bool <丞丗上专东丌三丑丆>k__BackingField;
        private System.EventHandler<Rilisoft.与丞专七丙专下丅且> 与丌三丕七东丆丞丑;
        private System.EventHandler 丟且丙与丄东上与丝;
        private System.EventHandler 丑三丌下一丗上丒丗;
        private System.EventHandler 专东下丞丟与丅且丟;
        private System.EventHandler<System.Threading.Tasks.Task<string>> 三东丁丟业丈丕丆丛;
        private System.EventHandler 不世丑丈丈且万下丌;
        private System.EventHandler 丁上丂万丄七丞丅三;
        private System.EventHandler 丗丆一丏丄一丙七下;
        private System.EventHandler 下与丞三丅丛丄七丕;
        private UnityEngine.GameObject _windowBlocker;
        private UnityEngine.GameObject _readyToWatchPanel;
        private UnityEngine.GameObject _waitingPanel;
        private UnityEngine.GameObject _watchingPanel;
        private UnityEngine.GameObject _failurePanel;
        private UnityEngine.GameObject _rewardPanel;
        private UnityEngine.GameObject _simulateButton;
        private UITexture _loadingSpinner;
        private UILabel[] _rewardCountCaption;
        private UILabel[] _getRewardCountCaption;
        private UILabel[] _readyToWatchTitle;
        
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        internal string 下三丙丛万三丘丝丛 { get; }
        internal System.DateTime 丗丒丂丕丂业业丟丟 { get; set; }
        private bool 丁丙丈万丐业丞丁万 { get; set; }
        
        // Methods
        private ReusableRewardedVideo()
        {
            this.丗下丘世三七一专丕 = new ReusableRewardedVideo.丏丈七万丈丗下世万(下丒丗丛丙丆丄丈专:  this);
            this.<丞丗上专东丌三丑丆>k__BackingField = true;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        internal string 世万丐不下下三七七()
        {
            string val_1 = this.丛世丘丞丁三丈丕丕;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        internal System.DateTime 上丟丄与丁三丌丘专()
        {
            return (System.DateTime)this.<丑丆一丌三丆丑丑专>k__BackingField;
        }
        private void 丅丈东上丑丅一东与(System.DateTime 丙业与丙丗丝不丈东)
        {
            this.<丑丆一丌三丆丑丑专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private bool 业东丟三丅七丝丁丂()
        {
            return (bool)this.<丞丗上专东丌三丑丆>k__BackingField;
        }
        private void 上三业七东丄丏世业(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丗上专东丌三丑丆>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void add_EnterIdle(System.EventHandler<Rilisoft.与丞专七丙专下丅且> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.与丌三丕七东丆丞丑, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丌三丕七东丆丞丑 != 1152921542239449344);
        
        }
        public void remove_EnterIdle(System.EventHandler<Rilisoft.与丞专七丙专下丅且> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.与丌三丕七东丆丞丑, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.与丌三丕七东丆丞丑 != 1152921542239585920);
        
        }
        public void add_ExitIdle(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丟且丙与丄东上与丝, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丟且丙与丄东上与丝 != 1152921542239722504);
        
        }
        public void remove_ExitIdle(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丟且丙与丄东上与丝, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丟且丙与丄东上与丝 != 1152921542239859080);
        
        }
        public void add_EnterWatching(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丑三丌下一丗上丒丗, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丑三丌下一丗上丒丗 != 1152921542239995664);
        
        }
        public void remove_EnterWatching(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丑三丌下一丗上丒丗, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丑三丌下一丗上丒丗 != 1152921542240132240);
        
        }
        public void add_ExitWatching(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专东下丞丟与丅且丟, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专东下丞丟与丅且丟 != 1152921542240268824);
        
        }
        public void remove_ExitWatching(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专东下丞丟与丅且丟, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专东下丞丟与丅且丟 != 1152921542240405400);
        
        }
        public void add_ExitWatchingWithResult(System.EventHandler<System.Threading.Tasks.Task<string>> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.三东丁丟业丈丕丆丛, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.三东丁丟业丈丕丆丛 != 1152921542240541984);
        
        }
        public void remove_ExitWatchingWithResult(System.EventHandler<System.Threading.Tasks.Task<string>> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.三东丁丟业丈丕丆丛, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.三东丁丟业丈丕丆丛 != 1152921542240678560);
        
        }
        public void add_ExitReward(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.不世丑丈丈且万下丌, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.不世丑丈丈且万下丌 != 1152921542240815144);
        
        }
        public void remove_ExitReward(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.不世丑丈丈且万下丌, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.不世丑丈丈且万下丌 != 1152921542240951720);
        
        }
        public void add_AdWatchedSuccessfully(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丁上丂万丄七丞丅三, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁上丂万丄七丞丅三 != 1152921542241088304);
        
        }
        public void remove_AdWatchedSuccessfully(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丁上丂万丄七丞丅三, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁上丂万丄七丞丅三 != 1152921542241224880);
        
        }
        public void add_DiscardWatching(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丗丆一丏丄一丙七下, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丗丆一丏丄一丙七下 != 1152921542241361464);
        
        }
        public void remove_DiscardWatching(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丗丆一丏丄一丙七下, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丗丆一丏丄一丙七下 != 1152921542241498040);
        
        }
        public void add_Show(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下与丞三丅丛丄七丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下与丞三丅丛丄七丕 != 1152921542241634624);
        
        }
        public void remove_Show(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下与丞三丅丛丄七丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下与丞三丅丛丄七丕 != 1152921542241771200);
        
        }
        internal bool 丝不丒三下万丅不丛(string 丅上专丁丘丈不丞丒)
        {
            if(丅上专丁丘丈不丞丒 == null)
            {
                    return false;
            }
            
            if(this.丛世丘丞丁三丈丕丕 != null)
            {
                    return false;
            }
            
            this.丛世丘丞丁三丈丕丕 = 丅上专丁丘丈不丞丒;
            return true;
        }
        internal void 下专丙丝丐丘丝丌丈(string 丙业与丙丗丝不丈东)
        {
            int val_1;
            if(this._rewardCountCaption == null)
            {
                    return;
            }
            
            if(this._rewardCountCaption.Length < 1)
            {
                    return;
            }
            
            goto label_9;
            label_7:
            val_1 = System.String.alignConst;
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_9:
            val_1 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_7;
            }
            
            label_5:
            this._rewardCountCaption[0].text = val_1;
            if((0 + 1) < this._rewardCountCaption.Length)
            {
                goto label_9;
            }
        
        }
        internal void 丌七丒丟丒丟丑丐丟(string 丙业与丙丗丝不丈东)
        {
            int val_1;
            if(this._getRewardCountCaption == null)
            {
                    return;
            }
            
            if(this._getRewardCountCaption.Length < 1)
            {
                    return;
            }
            
            goto label_9;
            label_7:
            val_1 = System.String.alignConst;
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_9:
            val_1 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_7;
            }
            
            label_5:
            this._getRewardCountCaption[0].text = val_1;
            if((0 + 1) < this._getRewardCountCaption.Length)
            {
                goto label_9;
            }
        
        }
        internal void 丈七丅丐丑丛丑与一(string 丙业与丙丗丝不丈东)
        {
            int val_1;
            if(this._readyToWatchTitle == null)
            {
                    return;
            }
            
            if(this._readyToWatchTitle.Length < 1)
            {
                    return;
            }
            
            goto label_9;
            label_7:
            val_1 = System.String.alignConst;
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_9:
            val_1 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_7;
            }
            
            label_5:
            this._readyToWatchTitle[0].text = val_1;
            if((0 + 1) < this._readyToWatchTitle.Length)
            {
                goto label_9;
            }
        
        }
        internal void 不且七上且业丞丈丁(System.DateTime 与丕丌丒丗丄丘丙东, bool 不丝丈上一七丅丕丐, bool 业丏丞一丕丆丂丗东)
        {
            var val_2;
            if(this.丗下丘世三七一专丕 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            UnityEngine.Debug.LogWarning(message:  "!(_currentState is Idle)");
            return;
            label_2:
            this.<丞丗上专东丌三丑丆>k__BackingField = 业丏丞一丕丆丂丗东;
            this.<丑丆一丌三丆丑丑专>k__BackingField = 与丕丌丒丗丄丘丙东;
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  4);
            if(不丝丈上一七丅丕丐 != false)
            {
                    this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  2);
            }
            
            if(this.下与丞三丅丛丄七丕 == null)
            {
                    return;
            }
            
            val_2 = null;
            val_2 = null;
            this.下与丞三丅丛丄七丕.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        internal void 丕七三且丏丗下丅丅()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._windowBlocker, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._watchingPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._waitingPanel, 丏业丟一东丂东丘丛:  false);
        }
        public void OnClose()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  5);
        }
        public void OnSimulateButtonClicked()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  4);
        }
        public void OnWatchButtonClicked()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  2);
        }
        public void OnGetRewardClicked()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  4);
        }
        private void Awake()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  1);
        }
        private void Update()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  3);
        }
        private void OnDisable()
        {
            if(this.丗下丘世三七一专丕 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  5);
        }
        private void 丝丂七丑不东业东丛(Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
        {
            if(this.丗下丘世三七一专丕 == null)
            {
                    return;
            }
            
            this.丗下丘世三七一专丕 = this.丗下丘世三七一专丕;
            this = this.丗下丘世三七一专丕;
            if(this == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.Dispose();
        }
        private void 七丕东丘丑丞三丏丑()
        {
            this.丝丂七丑不东业东丛(丗丄下丈丑七丗丞专:  5);
        }
        private void 东东七丕世业丞丌世(Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)
        {
            if(this.与丌三丕七东丆丞丑 == null)
            {
                    return;
            }
            
            this.与丌三丕七东丆丞丑.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 丐丁丕丆丌丂丅丙丏(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.丟且丙与丄东上与丝 == null)
            {
                    return;
            }
            
            this.丟且丙与丄东上与丝.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 丆一丅丗丕东丑三世(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.丑三丌下一丗上丒丗 == null)
            {
                    return;
            }
            
            this.丑三丌下一丗上丒丗.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 丅上丂丁丁丝一七专(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.丗丆一丏丄一丙七下 == null)
            {
                    return;
            }
            
            this.丗丆一丏丄一丙七下.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 世丂丒丗丘丄丕万世(System.Threading.Tasks.Task<string> 丗丛不丁丑专专丂且)
        {
            var val_1;
            if(this.专东下丞丟与丅且丟 != null)
            {
                    val_1 = null;
                val_1 = null;
                this.专东下丞丟与丅且丟.Invoke(sender:  this, e:  System.EventArgs.Empty);
            }
            
            if(this.三东丁丟业丈丕丆丛 == null)
            {
                    return;
            }
            
            this.三东丁丟业丈丕丆丛.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 东丛丂丝三丁不丂下(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.不世丑丈丈且万下丌 == null)
            {
                    return;
            }
            
            this.不世丑丈丈且万下丌.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private void 东丈丕丁七与上丕三(System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.丁上丂万丄七丞丅三 == null)
            {
                    return;
            }
            
            this.丁上丂万丄七丞丅三.Invoke(sender:  this, e:  丗丛不丁丑专专丂且);
        }
        private static void 丈丐丐丂丑丅丟与丁(string 丄丙下丝丛丒七丂丘)
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            object[] val_4 = new object[2];
            val_4[0] = "ReusableRewardedVideo";
            val_4[1] = 丄丙下丝丛丒七丂丘;
            UnityEngine.Debug.LogFormat(format:  (UnityEngine.Application.isEditor != true) ? "<color=cyan>[{0}] {1}</color>" : "[{0}] {1}", args:  val_4);
        }
    
    }

}
