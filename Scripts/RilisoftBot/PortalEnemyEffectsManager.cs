using UnityEngine;

namespace RilisoftBot
{
    public class PortalEnemyEffectsManager : MonoBehaviour, 丅丅世丙丄丛丌丞丂
    {
        // Fields
        private const string 丙下丌丒上丟东丝万 = "_Burn";
        private const float 丌丞丑丂丝三丘丅丕 = 1;
        private const float 丞丟七世丞下丆上业 = 0.25;
        private const float 丟专丝丁七三丝丙东 = 1.25;
        private RilisoftBot.BaseBot 丑下万丛丟下丟丕不;
        private UnityEngine.Material 丛丑东丕丛丒专丟丙;
        
        // Methods
        public void ShowSpawnEffect()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一上丛东丕丆丂丗丕());
            this.一丙东丟丅丄丕丆东();
        }
        private void Awake()
        {
            this.丑下万丛丟下丟丕不 = this.GetComponent<RilisoftBot.BaseBot>();
            UnityEngine.Material val_2 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Enemy_Portal");
            this.丛丑东丕丛丒专丟丙 = val_2;
            if(val_2 != 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "material not found");
        }
        private void 世不东丗丁丄丕上丒()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一上丛东丕丆丂丗丕());
        }
        private System.Collections.IEnumerator 一上丛东丕丆丂丗丕()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PortalEnemyEffectsManager.丄丐一丏上丐业丟万();
        }
        private System.Collections.IEnumerator 七一世丞一丑下丟丅(UnityEngine.Renderer 三丑丛丘与丛丟世东)
        {
            PortalEnemyEffectsManager.丕丌丛丑七丈丈下万 val_1 = new PortalEnemyEffectsManager.丕丌丛丑七丈丈下万();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .三丑丛丘与丛丟世东 = 三丑丛丘与丛丟世东;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 一丙东丟丅丄丕丆东()
        {
            EnemyPortal val_1 = EnemyPortalStackController.丄丞丁丈与业上丞丟.GetPortal();
            if(val_1 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.gameObject.transform.position;
            val_1.Show(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        }
        public PortalEnemyEffectsManager()
        {
        
        }
    
    }

}
