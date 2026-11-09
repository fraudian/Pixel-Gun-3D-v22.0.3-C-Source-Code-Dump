using UnityEngine;

namespace Rilisoft
{
    internal sealed class NewDayWatcher : MonoBehaviour
    {
        // Fields
        private System.Threading.CancellationTokenSource 丌丛丆世东丙三丈与;
        private System.Nullable<System.DateTime> 丞丙丆一丒丞专业丟;
        private System.EventHandler 东丕世丏丑丅丙一丈;
        
        // Methods
        internal void 下世丁东七丗万上丁(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.东丕世丏丑丅丙一丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东丕世丏丑丅丙一丈 != 1152921543216000192);
        
        }
        internal void 丈丂丏下丈专丛丝丞(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.东丕世丏丑丅丙一丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东丕世丏丑丅丙一丈 != 1152921543216136768);
        
        }
        private void Start()
        {
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            this.丞丙丆一丒丞专业丟 = val_1;
            mem[1152921543216261048] = ???;
        }
        private void OnEnable()
        {
            if(this.丌丛丆世东丙三丈与 != null)
            {
                    this.丌丛丆世东丙三丈与.Cancel();
            }
            
            System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
            this.丌丛丆世东丙三丈与 = val_1;
            System.Threading.CancellationToken val_2 = val_1.Token;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丄业一上三业丏与不(业丘丝业丛丆丄一上:  new System.Threading.CancellationToken() {m_source = val_2.m_source}));
        }
        private void OnDisable()
        {
            if(this.丌丛丆世东丙三丈与 == null)
            {
                    return;
            }
            
            this.丌丛丆世东丙三丈与.Cancel();
            this.丌丛丆世东丙三丈与 = 0;
        }
        private System.Collections.IEnumerator 丄业一上三业丏与不(System.Threading.CancellationToken 业丘丝业丛丆丄一上)
        {
            NewDayWatcher.丂丙丂丒丐三丞一丞 val_1 = new NewDayWatcher.丂丙丂丒丐三丞一丞();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .业丘丝业丛丆丄一上 = 业丘丝业丛丆丄一上;
            return (System.Collections.IEnumerator)val_1;
        }
        public NewDayWatcher()
        {
        
        }
    
    }

}
