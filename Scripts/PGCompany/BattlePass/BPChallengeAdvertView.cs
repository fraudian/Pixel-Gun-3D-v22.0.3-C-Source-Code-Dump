using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPChallengeAdvertView : MonoBehaviour
    {
        // Fields
        private UIButton _button;
        private PGCompany.BattlePass.BattlePassChallengeView 三丈业丛丞丏万丒下;
        private PGCompany.BattlePass.BattlePassChallengesRewardedVideoController 与丕且业丛不与丑丈;
        
        // Properties
        private PGCompany.BattlePass.BattlePassChallengeView 专丛丙专丅丟丟丅七 { get; }
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丈丏丛丌不一丅且业 { get; }
        private PGCompany.BattlePass.BattlePassChallengesRewardedVideoController 丙下且丙丛万下丛丞 { get; }
        
        // Methods
        private PGCompany.BattlePass.BattlePassChallengeView 丅丆丒丒一不丁丐丟()
        {
            if(this.三丈业丛丞丏万丒下 != null)
            {
                    return val_1;
            }
            
            PGCompany.BattlePass.BattlePassChallengeView val_1 = this.GetComponent<PGCompany.BattlePass.BattlePassChallengeView>();
            this.三丈业丛丞丏万丒下 = val_1;
            return val_1;
        }
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 下且世丆丟且丑与丕()
        {
            if(this.丅丆丒丒一不丁丐丟() == 0)
            {
                    return 0;
            }
            
            PGCompany.BattlePass.BattlePassChallengeView val_3 = this.丅丆丒丒一不丁丐丟();
            if(val_3 != null)
            {
                    return val_3.Context;
            }
            
            return val_3.Context;
        }
        private PGCompany.BattlePass.BattlePassChallengesRewardedVideoController 丏上丙丛万丞丄丟世()
        {
            PGCompany.BattlePass.BattlePassChallengesRewardedVideoController val_3;
            if((UnityEngine.Object.op_Implicit(exists:  this.与丕且业丛不与丑丈)) != false)
            {
                    val_3 = this.与丕且业丛不与丑丈;
                return val_2;
            }
            
            PGCompany.BattlePass.BattlePassChallengesRewardedVideoController val_2 = this.世业丐丝丆丟专丐三();
            this.与丕且业丛不与丑丈 = val_2;
            return val_2;
        }
        private PGCompany.BattlePass.BattlePassChallengesRewardedVideoController 世业丐丝丆丟专丐三()
        {
            UnityEngine.Object val_7;
            var val_8;
            val_7 = this.GetComponentInParent<BattlePassRootUI>();
            val_8 = 0;
            if(val_7 == 0)
            {
                    return (PGCompany.BattlePass.BattlePassChallengesRewardedVideoController)val_7.AddComponent<PGCompany.BattlePass.BattlePassChallengesRewardedVideoController>();
            }
            
            if((val_7.gameObject.GetComponent<PGCompany.BattlePass.BattlePassChallengesRewardedVideoController>()) != null)
            {
                    return (PGCompany.BattlePass.BattlePassChallengesRewardedVideoController)val_7.AddComponent<PGCompany.BattlePass.BattlePassChallengesRewardedVideoController>();
            }
            
            val_7 = val_7.gameObject;
            return (PGCompany.BattlePass.BattlePassChallengesRewardedVideoController)val_7.AddComponent<PGCompany.BattlePass.BattlePassChallengesRewardedVideoController>();
        }
        public void U_ShowAdvert()
        {
            this.上丁丞丆不丐丑丟业();
        }
        private void Awake()
        {
            if(this.与丕且业丛不与丑丈 != 0)
            {
                    return;
            }
            
            this.与丕且业丛不与丑丈 = this.世业丐丝丆丟专丐三();
        }
        private void Start()
        {
            var val_6;
            var val_16;
            System.EventHandler val_17;
            if(this._button == 0)
            {
                goto label_3;
            }
            
            PGCompany.东丑丒丗一丞下丙丙<T> val_2 = PGCompany.东丑丒丗一丞下丙丙<UIButton>.万世丅七一专丕丞不();
            val_16 = public System.Void UnityEngine.GameObject::GetComponents<UIButton>(System.Collections.Generic.List<T> results);
            this._button.gameObject.GetComponents<UIButton>(results:  val_2);
            List.Enumerator<T> val_4 = val_2.GetEnumerator();
            label_15:
            if(((-325656640) & 1) == 0)
            {
                goto label_10;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(val_7 == 0)
            {
                goto label_15;
            }
            
            UnityEngine.Color val_9 = UnityEngine.Color.white;
            val_7.defaultColor = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
            goto label_15;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_17 = PGCompany.东丑丒丗一丞下丙丙<UIButton>.万世丅七一专丕丞不();
            label_3:
            if(this.丏上丙丛万丞丄丟世() == 0)
            {
                    return;
            }
            
            System.EventHandler val_14 = null;
            val_17 = val_14;
            val_14 = new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::业上丁三丝三丄丑业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.丏上丙丛万丞丄丟世().add_CounterIncremented(丙业与丙丗丝不丈东:  val_14);
        }
        private void OnEnable()
        {
            if(this.丅丆丒丒一不丁丐丟() != 0)
            {
                    this.丅丆丒丒一不丁丐丟().add_ContextChanged(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::一丌丙丝丆丒丈丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            }
            
            if(this.下且世丆丟且丑与丕() != null)
            {
                    if(this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙() != null)
            {
                    this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙().丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::且丗丟丄丑丞丈丒丂()));
            }
            
            }
            
            FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::丁东一丏丕万且世丝()));
            this.丙业万上丁世丂一且();
        }
        private void OnDisable()
        {
            FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::丁东一丏丕万且世丝()));
            if(this.下且世丆丟且丑与丕() != null)
            {
                    if(this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙() != null)
            {
                    this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙().不一丁丐万丏丑丆东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::且丗丟丄丑丞丈丒丂()));
            }
            
            }
            
            if(this.丅丆丒丒一不丁丐丟() == 0)
            {
                    return;
            }
            
            this.丅丆丒丒一不丁丐丟().remove_ContextChanged(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::一丌丙丝丆丒丈丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void OnDestroy()
        {
            if(this.与丕且业丛不与丑丈 == 0)
            {
                    return;
            }
            
            this.与丕且业丛不与丑丈.remove_CounterIncremented(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::业上丁三丝三丄丑业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void 丁东一丏丕万且世丝()
        {
            this.丙业万上丁世丂一且();
        }
        private void 且丗丟丄丑丞丈丒丂()
        {
            if(this._button == 0)
            {
                    return;
            }
            
            if(this._button == null)
            {
                
            }
        
        }
        private void 丙业万上丁世丂一且()
        {
            if(this._button == 0)
            {
                    return;
            }
            
            bool val_3 = this.丅一丅丌丗专丝万丑();
            goto typeof(UIButton).__il2cppRuntimeField_178;
        }
        private bool 丅一丅丌丗专丝万丑()
        {
            var val_35;
            var val_36;
            object val_37;
            val_35 = this;
            string val_29 = 0;
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_1 = this.下且世丆丟且丑与丕();
            if(val_1 == null)
            {
                    return (bool)val_36;
            }
            
            PGCompany.BattlePass.丘丄上丏不丝不丐丐 val_2 = val_1.丄上丝丌上下丒上丙();
            if(val_2 == null)
            {
                    return (bool)val_36;
            }
            
            if(val_2.业丑丁丆丕丆丂丅万() == null)
            {
                    return (bool)val_36;
            }
            
            if((this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙().丈丐丞丐上丑且丕万() == false) || (this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true))
            {
                goto label_39;
            }
            
            if((PGCompany.BattlePass.三丛上丁丗丌丆丌东.丙丛丝丒丆且丆丛与(丟专三丙丒丄丂下与:  this.下且世丆丟且丑与丕())) != false)
            {
                    if((PGCompany.BattlePass.三丛上丁丗丌丆丌东.丟丂与三丑上下丑丐(丟专三丙丒丄丂下与:  this.下且世丆丟且丑与丕())) == false)
            {
                goto label_39;
            }
            
            }
            
            if(this.下且世丆丟且丑与丕().丘且丛世与不丂丒上() == false)
            {
                goto label_14;
            }
            
            if(this.丏上丙丛万丞丄丟世() != 0)
            {
                goto label_17;
            }
            
            val_37 = "[BPChallengeAdvertView.ShouldEnable] RewardedVideoController: null";
            goto label_20;
            label_14:
            label_38:
            UnityEngine.Debug.Log(message:  "[BPChallengeAdvertView.ShouldEnable] IsAdEnabled: false");
            goto label_39;
            label_17:
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_24;
            }
            
            int val_21 = this.丏上丙丛万丞丄丟世().GetCounter(一丏一世丘丐丁丄丟:  new System.DateTime());
            if(val_21 >= this.丏上丙丛万丞丄丟世().MaxCount)
            {
                goto label_27;
            }
            
            val_35 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_35.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  "battlePass", 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_29)) == false)
            {
                goto label_31;
            }
            
            val_36 = 1;
            return (bool)val_36;
            label_24:
            val_37 = "[BPChallengeAdvertView.ShouldEnable] TryGetServerUniversalTime";
            label_20:
            UnityEngine.Debug.LogWarning(message:  val_37);
            label_39:
            val_36 = 0;
            return (bool)val_36;
            label_27:
            string val_33 = System.String.Format(format:  "[{0}] impressionCount: {1}, MaxCount: {2}", arg0:  "BPChallengeAdvertView.ShouldEnable", arg1:  val_21, arg2:  this.丏上丙丛万丞丄丟世().MaxCount);
            goto label_38;
            label_31:
            bool val_34 = PGCompany.BattlePass.BPChallengeAdvertView.丁专丏万万三丐下丒(丄丙下丝丛丒七丂丘:  val_29);
            goto label_39;
        }
        private void 一丌丙丝丆丒丈丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(this.下且世丆丟且丑与丕() != null)
            {
                    if(this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙() != null)
            {
                    this.下且世丆丟且丑与丕().丄上丝丌上下丒上丙().丝丑丄不丄丏丞丂丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeAdvertView::且丗丟丄丑丞丈丒丂()));
            }
            
            }
            
            this.丙业万上丁世丂一且();
        }
        private void 业上丁三丝三丄丑业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丙业万上丁世丂一且();
        }
        private void 上丁丞丆不丐丑丟业()
        {
            .丝且与丝丒丟万丁专 = this;
            if(this.下且世丆丟且丑与丕() == null)
            {
                goto label_2;
            }
            
            .丁丅丈丌丟世丗丗丟 = this.下且世丆丟且丑与丕().不业丙丒丂丞下丆丙();
            if(this.丏上丙丛万丞丄丟世() != 0)
            {
                goto label_6;
            }
            
            object[] val_7 = new object[2];
            val_7[0] = this.GetType();
            val_7[1] = (BPChallengeAdvertView.丌丐丝丐下上三丛丌)[1152921560117509264].丁丅丈丌丟世丗丗丟;
            UnityEngine.Debug.LogErrorFormat(format:  "[{0}] ShowAdvert => type: {1}", args:  val_7);
            return;
            label_2:
            object[] val_9 = new object[1];
            val_9[0] = this.GetType();
            UnityEngine.Debug.LogErrorFormat(format:  "[{0}] ShowAdvert => Challenge: null", args:  val_9);
            return;
            label_6:
            System.Nullable<System.DateTime> val_11 = FriendsController.业丈丏丏丞丘丛丈丛();
            .丅丏丅丂丝一丆丙丅 = val_11;
            mem[1152921560117509304] = 0;
            if((1152921560117509296 & 1) != 0)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  37);
                bool val_17 = this.丏上丙丛万丞丄丟世().TryShowVideoInterface(丅丏丅丂丝一丆丙丅:  new System.DateTime() {dateData = 1152921560117509296}, 丁丅丈丌丟世丗丗丟:  (BPChallengeAdvertView.丌丐丝丐下上三丛丌)[1152921560117509264].丁丅丈丌丟世丗丗丟, 且丂七下丙丆三丐三:  this.下且世丆丟且丑与丕().业上丙丞丐丄丆丅七(), 业丏丈世世世丞丒世:  new System.Action<System.Boolean, System.Int32>(object:  new BPChallengeAdvertView.丌丐丝丐下上三丛丌(), method:  System.Void BPChallengeAdvertView.丌丐丝丐下上三丛丌::丗丛上丑丝丝专专丄(bool 丞且万不与业下丂丆, int 且丂七下丙丆三丐三)));
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                return;
            }
            
            object[] val_19 = new object[1];
            val_19[0] = this.GetType();
            UnityEngine.Debug.LogWarningFormat(format:  "[{0}] ShowAdvert => Server time not received.", args:  val_19);
        }
        public BPChallengeAdvertView()
        {
        
        }
        internal static bool 丁专丏万万三丐下丒(string 丄丙下丝丛丒七丂丘)
        {
            string val_3 = 丄丙下丝丛丒七丂丘;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return false;
            }
            
            val_3 = "[BPChallengeAdvertView.ShouldEnable] " + val_3;
            UnityEngine.Debug.LogWarning(message:  val_3);
            return false;
        }
    
    }

}
