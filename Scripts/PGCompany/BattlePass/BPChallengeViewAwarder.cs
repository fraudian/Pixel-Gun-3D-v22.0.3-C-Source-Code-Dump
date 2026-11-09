using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPChallengeViewAwarder : MonoBehaviour
    {
        // Fields
        internal static PGCompany.BattlePass.BPChallengeViewAwarder 丄丘七三上丕世丞业;
        private bool <丒丌世丁与丟丁东东>k__BackingField;
        internal System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> 丌与丄丑丄业丁丘丄;
        private UnityEngine.Transform 丆丈丟专丙丛丙丁丒;
        private UnityEngine.Transform _target;
        
        // Properties
        internal bool 业一丂丒丐七丒世丟 { get; set; }
        internal UnityEngine.Transform 丒七万丙不且与丞丞 { get; set; }
        
        // Methods
        internal bool 丅万丌丙三丕丗丕下()
        {
            return (bool)this.<丒丌世丁与丟丁东东>k__BackingField;
        }
        internal void 东丑业丁丗丌丑丑丅(bool 丙业与丙丗丝不丈东)
        {
            this.<丒丌世丁与丟丁东东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal UnityEngine.Transform 下丕专丄丅专丌一上()
        {
            return (UnityEngine.Transform)this.丆丈丟专丙丛丙丁丒;
        }
        internal void 丆下丙丞丗丙丘一丄(UnityEngine.Transform 丙业与丙丗丝不丈东)
        {
            this.丆丈丟专丙丛丙丁丒 = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 = this;
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.上东世丕丘丈丟丐专());
        }
        private System.Collections.IEnumerator 上东世丕丘丈丟丐专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BPChallengeViewAwarder.丙一上丛丙丟三丐世();
        }
        private void OnDisable()
        {
            if(BattlePassRootUI.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            BattlePassRootUI.丑七不且上丗丁一世().丈丝丁丕一丐丛丄丄().丌丄丏下七丁专丂世();
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 = 0;
        }
        public BPChallengeViewAwarder()
        {
            this.丌与丄丑丄业丁丘丄 = new System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东>();
        }
    
    }

}
