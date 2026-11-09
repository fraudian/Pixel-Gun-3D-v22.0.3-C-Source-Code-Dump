using UnityEngine;

namespace PGCompany.BattlePass
{
    internal sealed class BattlePassChallengesRewardedVideoController : MonoBehaviour
    {
        // Fields
        private readonly PGCompany.丁一丝专丒世丐丗丏 丟三不丘三上东丅下;
        private Rilisoft.ReusableRewardedVideo 七业下三七一丕丟与;
        private UnityEngine.GameObject _rewardedVideoParent;
        private System.EventHandler 一七七与万丏丑丐丂;
        
        // Properties
        private UnityEngine.GameObject 丙不丄下且且下三丛 { get; }
        public Rilisoft.ReusableRewardedVideo 且下丄丞且且丁丒七 { get; }
        public int 丙不丁专丞丕丐上丛 { get; }
        
        // Methods
        private UnityEngine.GameObject 与与丞一丟丘丞丄上()
        {
            UnityEngine.GameObject val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this._rewardedVideoParent)) != false)
            {
                    val_3 = this._rewardedVideoParent;
                return val_2;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            this._rewardedVideoParent = val_2;
            return val_2;
        }
        public Rilisoft.ReusableRewardedVideo get_RewardedVideo()
        {
            Rilisoft.ReusableRewardedVideo val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.七业下三七一丕丟与)) != false)
            {
                    val_3 = this.七业下三七一丕丟与;
                return val_2;
            }
            
            Rilisoft.ReusableRewardedVideo val_2 = this.丅专丕世丄三丂世东();
            this.七业下三七一丕丟与 = val_2;
            return val_2;
        }
        public int get_MaxCount()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return -32768;
            }
            
            return val_2.丛丗下丅丈丒七丑丘();
        }
        public void add_CounterIncremented(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.一七七与万丏丑丐丂, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一七七与万丏丑丐丂 != 1152921559928736808);
        
        }
        public void remove_CounterIncremented(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.一七七与万丏丑丐丂, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一七七与万丏丑丐丂 != 1152921559928873384);
        
        }
        public bool TryShowVideoInterface(System.DateTime 丅丏丅丂丝一丆丙丅, PGCompany.BattlePass.BPChallengeType 丁丅丈丌丟世丗丗丟, int 且丂七下丙丆三丐三, System.Action<bool, int> 业丏丈世世世丞丒世)
        {
            BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七 val_1 = new BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            }
            else
            {
                    mem[16] = this;
                mem[40] = 业丏丈世世世丞丒世;
            }
            
            .且丂七下丙丆三丐三 = 且丂七下丙丆三丐三;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    object[] val_3 = new object[2];
                val_3[0] = this.GetType();
                val_3[1] = 丁丅丈丌丟世丗丗丟;
                UnityEngine.Debug.LogFormat(format:  "[{0}] TryShowVideoInterface => type: {1}", args:  val_3);
            }
            
            .三世且丐一丐丁丆丏 = 0;
            .三世且丐一丐丁丆丏 = new System.EventHandler(object:  val_1, method:  System.Void BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七::专上丒丅丂丞丄下丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.RewardedVideo.add_EnterWatching(丙业与丙丗丝不丈东:  (BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七)[1152921559929110688].三世且丐一丐丁丆丏);
            .丛丕丟丆丐万丘东丙 = 0;
            .丛丕丟丆丐万丘东丙 = new System.EventHandler(object:  val_1, method:  System.Void BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七::且且专丑世丂专且丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.RewardedVideo.add_ExitWatching(丙业与丙丗丝不丈东:  (BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七)[1152921559929110688].丛丕丟丆丐万丘东丙);
            ConnectionLostChecker.丑七不且上丗丁一世().丌丝丅七丕丞丏丑不(丂且丏丘丗上丑丘丕:  true);
            this.RewardedVideo.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime() {dateData = 丅丏丅丂丝一丆丙丅.dateData}, 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  true);
            .丛丁丅丂不丂丐丝丏 = 0;
            .丛丁丅丂不丂丐丝丏 = new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七::丝专丟丐三丈丘丑七(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且));
            this.RewardedVideo.add_EnterIdle(丙业与丙丗丝不丈东:  (BattlePassChallengesRewardedVideoController.丒丛丁与丅东丒不七)[1152921559929110688].丛丁丅丂不丂丐丝丏);
            return true;
        }
        public int GetCounter(System.DateTime 一丏一世丘丐丁丄丟)
        {
        
        }
        public int IncrementCounter(System.DateTime 一丏一世丘丐丁丄丟)
        {
            var val_1;
            if(this.一七七与万丏丑丐丂 == null)
            {
                    return (int)this.丟三不丘三上东丅下;
            }
            
            val_1 = null;
            val_1 = null;
            this.一七七与万丏丑丐丂.Invoke(sender:  this, e:  System.EventArgs.Empty);
            return (int)this.丟三不丘三上东丅下;
        }
        private Rilisoft.ReusableRewardedVideo 丅专丕世丄三丂世东()
        {
            object val_15;
            UnityEngine.Transform val_16;
            var val_17;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[BattlePassChallengesRewardedVideoController.CreateRewardedVideo]");
            }
            
            Rilisoft.ReusableRewardedVideo val_2 = UnityEngine.Resources.Load<Rilisoft.ReusableRewardedVideo>(path:  "SpeedUpItemRewardedVideo");
            if(val_2 != 0)
            {
                goto label_8;
            }
            
            val_15 = "[BattlePassChallengesRewardedVideoController.CreateRewardedVideo] rewardedVideoPrefab: null";
            goto label_11;
            label_8:
            val_16 = this.与与丞一丟丘丞丄上().transform;
            Rilisoft.ReusableRewardedVideo val_6 = UnityEngine.Object.Instantiate<Rilisoft.ReusableRewardedVideo>(original:  val_2, parent:  val_16);
            val_17 = val_6;
            if(val_6 != 0)
            {
                goto label_15;
            }
            
            val_15 = "[BattlePassChallengesRewardedVideoController.CreateRewardedVideo] rewardedVideo: null.";
            label_11:
            UnityEngine.Debug.LogError(message:  val_15);
            val_17 = 0;
            return (Rilisoft.ReusableRewardedVideo)val_17;
            label_15:
            val_16 = val_17.gameObject;
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_16, 不东丛三丂丌丑专丆:  this.与与丞一丟丘丞丄上().layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UnityEngine.Transform val_11 = val_17.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            val_11.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            val_11.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            bool val_14 = val_17.丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  "battlePass");
            return (Rilisoft.ReusableRewardedVideo)val_17;
        }
        public BattlePassChallengesRewardedVideoController()
        {
            this.丟三不丘三上东丅下 = 0;
            mem[1152921559929654624] = 0;
        }
    
    }

}
