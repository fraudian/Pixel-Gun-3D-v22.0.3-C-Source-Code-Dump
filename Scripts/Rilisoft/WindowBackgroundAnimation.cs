using UnityEngine;

namespace Rilisoft
{
    public class WindowBackgroundAnimation : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject[] 丅丒东丕丂且专专丟;
        private int 世丗上丟丅丂丈丌世;
        public UnityEngine.GameObject[] Arrows;
        private UIRoot 世丄与丛东丑业丕与;
        public bool PlayOnEnable;
        public UnityEngine.GameObject[] ShineNodes;
        
        // Properties
        private UIRoot 一丝丛丕丒丘万上专 { get; }
        
        // Methods
        private UIRoot 世丟世丁世丙丄丌丌()
        {
            UIRoot val_4;
            if(this.世丄与丛东丑业丕与 == 0)
            {
                    this.世丄与丛东丑业丕与 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<UIRoot>(丝三丁东丈丒世丅业:  this.gameObject);
                return val_4;
            }
            
            val_4 = this.世丄与丛东丑业丕与;
            return val_4;
        }
        private void OnEnable()
        {
            if(this.PlayOnEnable == false)
            {
                    return;
            }
            
            this.世丗上丟丅丂丈丌世 = 0;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈丁丒丐丌七业丞丌());
        }
        public void Play()
        {
            this.世丗上丟丅丂丈丌世 = 0;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈丁丒丐丌七业丞丌());
        }
        private System.Collections.IEnumerator 丈丁丒丐丌七业丞丌()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new WindowBackgroundAnimation.一丗丕丂丗三丂丞一();
        }
        private void 丏丄上丒丅丅不业丌(UnityEngine.Transform 丞下万上三丘上与专)
        {
            var val_12;
            float val_13;
            val_12 = 0;
            goto label_1;
            label_17:
            UnityEngine.Transform val_1 = this.丅丒东丕丂且专专丟[0].transform;
            val_1.parent = 丞下万上三丘上与专.parent;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = 丞下万上三丘上与专.localPosition;
            var val_5 = (val_12 < 0) ? (val_12 + 1) : (val_12);
            val_5 = val_5 & 4294967294;
            val_5 = val_12 - val_5;
            if(丞下万上三丘上与专 != null)
            {
                    UnityEngine.Vector3 val_7 = 丞下万上三丘上与专.localPosition;
                val_13 = val_7.y;
            }
            else
            {
                    UnityEngine.Vector3 val_8 = 0.localPosition;
                val_13 = val_8.y;
            }
            
            UnityEngine.Vector3 val_9 = 丞下万上三丘上与专.localPosition;
            float val_13 = 0f;
            val_13 = val_13 * (-110f);
            float val_10 = ((val_5 == 1) ? 90f : 0f) + val_4.x;
            val_13 = val_13 + val_13;
            val_1.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_11 = 丞下万上三丘上与专.localRotation;
            val_1.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            val_12 = 1;
            label_1:
            if(val_12 < this.丅丒东丕丂且专专丟.Length)
            {
                goto label_17;
            }
        
        }
        public WindowBackgroundAnimation()
        {
            this.世丗上丟丅丂丈丌世 = 0;
            this.PlayOnEnable = true;
        }
    
    }

}
