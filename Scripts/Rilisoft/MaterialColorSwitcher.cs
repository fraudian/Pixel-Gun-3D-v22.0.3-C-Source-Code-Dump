using UnityEngine;

namespace Rilisoft
{
    public class MaterialColorSwitcher : MonoBehaviour
    {
        // Fields
        private bool 丞丅三万丈七一丞丙;
        private int 万丟丆上三与丒丐世;
        private UnityEngine.Material 下丘丈丌丁与丅七东;
        public System.Collections.Generic.List<UnityEngine.Color> Colors;
        public float ToColorTime;
        
        // Methods
        private void Awake()
        {
            this.下丘丈丌丁与丅七东 = this.GetComponent<UnityEngine.Renderer>().material;
        }
        private void OnEnable()
        {
            this.StopAllCoroutines();
            this.丞丅三万丈七一丞丙 = true;
        }
        private void Update()
        {
            if(this.丞丅三万丈七一丞丙 == false)
            {
                    return;
            }
            
            this.丞丅三万丈七一丞丙 = false;
            int val_3 = ((this.Colors.Count - 1) <= this.万丟丆上三与丒丐世) ? 0 : (this.万丟丆上三与丒丐世 + 1);
            this.万丟丆上三与丒丐世 = val_3;
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丏不万丛上一世丄丟(下丒丒丛不丑丗丘丙:  val_3, 丂三丟丂丈丐丆丗丟:  this.ToColorTime));
        }
        private System.Collections.IEnumerator 丏不万丛上一世丄丟(int 下丒丒丛不丑丗丘丙, float 丂三丟丂丈丐丆丗丟)
        {
            MaterialColorSwitcher.丕丘丄上一三丏丆业 val_1 = new MaterialColorSwitcher.丕丘丄上一三丏丆业();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .下丒丒丛不丑丗丘丙 = 下丒丒丛不丑丗丘丙;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 下丒丒丛不丑丗丘丙;
            }
            
            .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
            return (System.Collections.IEnumerator)val_1;
        }
        public MaterialColorSwitcher()
        {
            this.丞丅三万丈七一丞丙 = true;
            this.万丟丆上三与丒丐世 = 0;
            this.Colors = new System.Collections.Generic.List<UnityEngine.Color>();
            this.ToColorTime = 1f;
        }
    
    }

}
