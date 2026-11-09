using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPChallengeVisible : MonoBehaviour
    {
        // Fields
        private Rilisoft.BetterWrapContent 上丈世丁丐丒业上世;
        private PGCompany.BattlePass.BattlePassChallengeView 世丅丂一丄丕丌丒一;
        private UIWidget 与东七丏丆世丟丁丌;
        private UnityEngine.Coroutine 丙下一与丗七与专一;
        private bool 丙丐丛上且丆丅三丏;
        
        // Properties
        private Rilisoft.BetterWrapContent 万丞且丒丗丙丂世丝 { get; }
        private PGCompany.BattlePass.BattlePassChallengeView 丅上丗丌丄丏丅丆三 { get; }
        private UIWidget 丕丟丟丝丝丞七且下 { get; }
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 丈丏丛丌不一丅且业 { get; }
        
        // Methods
        private Rilisoft.BetterWrapContent 一丌专三一丌丙丏专()
        {
            Rilisoft.BetterWrapContent val_3;
            if(this.上丈世丁丐丒业上世 == 0)
            {
                    this.上丈世丁丐丒业上世 = this.GetComponentInParent<Rilisoft.BetterWrapContent>();
                return val_3;
            }
            
            val_3 = this.上丈世丁丐丒业上世;
            return val_3;
        }
        private PGCompany.BattlePass.BattlePassChallengeView 丄世下丟三与丛世丅()
        {
            PGCompany.BattlePass.BattlePassChallengeView val_3;
            if(this.世丅丂一丄丕丌丒一 == 0)
            {
                    this.世丅丂一丄丕丌丒一 = this.GetComponent<PGCompany.BattlePass.BattlePassChallengeView>();
                return val_3;
            }
            
            val_3 = this.世丅丂一丄丕丌丒一;
            return val_3;
        }
        private UIWidget 丁丏世七三丗与丏与()
        {
            UIWidget val_3;
            if(this.与东七丏丆世丟丁丌 == 0)
            {
                    this.与东七丏丆世丟丁丌 = this.GetComponent<UIWidget>();
                return val_3;
            }
            
            val_3 = this.与东七丏丆世丟丁丌;
            return val_3;
        }
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 下且世丆丟且丑与丕()
        {
            if(this.丄世下丟三与丛世丅() == 0)
            {
                    return 0;
            }
            
            PGCompany.BattlePass.BattlePassChallengeView val_3 = this.丄世下丟三与丛世丅();
            if(val_3 != null)
            {
                    return val_3.Context;
            }
            
            return val_3.Context;
        }
        private void Awake()
        {
            if(this.丄世下丟三与丛世丅() == 0)
            {
                    return;
            }
            
            this.丄世下丟三与丛世丅().add_ContextChanged(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeVisible::一丌丙丝丆丒丈丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丑且下丝且与东且丗());
        }
        private void 一丌丙丝丆丒丈丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丑且下丝且与东且丗());
        }
        private System.Collections.IEnumerator 丑且下丝且与东且丗()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPChallengeVisible.一丟东丈丞丄丐上丝();
        }
        private bool 丂与丞丄丒丁下上东()
        {
            Rilisoft.BetterWrapContent val_14 = this.一丌专三一丌丙丏专();
            if(val_14 == 0)
            {
                    return true;
            }
            
            val_14 = this.丁丏世七三丗与丏与();
            if(val_14 == 0)
            {
                    return true;
            }
            
            val_14 = this.一丌专三一丌丙丏专().专丘东丁丆与丒世丝();
            UnityEngine.Vector3 val_8 = this.丁丏世七三丗与丏与().worldCenter;
            UIScrollView val_10 = this.一丌专三一丌丙丏专().丂三专丂丂下丙丆丏();
            if(val_10.movement != 1)
            {
                goto label_12;
            }
            
            if(val_8.x > val_8.y)
            {
                    return true;
            }
            
            if(val_10.movement > 1)
            {
                goto label_17;
            }
            
            goto label_17;
            label_12:
            UIScrollView val_12 = this.一丌专三一丌丙丏专().丂三专丂丂下丙丆丏();
            if(val_12.movement != 0)
            {
                    return true;
            }
            
            if(val_8.x > val_8.x)
            {
                    return true;
            }
            
            label_17:
            var val_13 = (val_8.x <= val_8.x) ? 1 : 0;
            return true;
        }
        private void OnDisable()
        {
            if(this.丙下一与丗七与专一 != null)
            {
                    this.StopCoroutine(routine:  this.丙下一与丗七与专一);
            }
            
            this.丙下一与丗七与专一 = 0;
        }
        private void OnDestroy()
        {
            if(this.丄世下丟三与丛世丅() == 0)
            {
                    return;
            }
            
            this.丄世下丟三与丛世丅().remove_ContextChanged(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.BPChallengeVisible::一丌丙丝丆丒丈丐东(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private System.Collections.IEnumerator 专丏丐丝七七丐世丞()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPChallengeVisible.且三业不丞丝业丝丄();
        }
        private void 丛丘丐丒不丆丞丌丁(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丟专三丙丒丄丂下与)
        {
            .丟专三丙丒丄丂下与 = 丟专三丙丒丄丂下与;
            if(PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            if((Exists(match:  new System.Predicate<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(object:  new BPChallengeVisible.丈业丗丞丁七下一不(), method:  System.Boolean BPChallengeVisible.丈业丗丞丁七下一不::丅世丙丘丏世丆丏丑(PGCompany.BattlePass.三丛上丁丗丌丆丌东 三丟东丕丄丄下下丑)))) != false)
            {
                    return;
            }
            
            Add(item:  (BPChallengeVisible.丈业丗丞丁七下一不)[1152921560121308240].丟专三丙丒丄丂下与);
        }
        public BPChallengeVisible()
        {
        
        }
    
    }

}
