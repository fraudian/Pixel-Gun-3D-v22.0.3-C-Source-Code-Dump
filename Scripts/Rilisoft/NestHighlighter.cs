using UnityEngine;

namespace Rilisoft
{
    public sealed class NestHighlighter : MonoBehaviour
    {
        // Fields
        private const string 万丐丁七且丆上丈丐 = "_OutlineColor";
        private UnityEngine.Color 且丌东丞万业与丏丒;
        private UnityEngine.Color 丞丞丛上丏丄丕专不;
        private UnityEngine.Color 丄业丐丙七且七丐丝;
        private float 丝世丘与丁上专三万;
        private bool 业三丟丆丙丒与不世;
        private UnityEngine.Material 下丘丈丌丁与丅七东;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Material val_2 = this.GetComponent<UnityEngine.Renderer>().sharedMaterial;
            this.下丘丈丌丁与丅七东 = val_2;
            UnityEngine.Color val_3 = val_2.GetColor(name:  "_OutlineColor");
            mem[1152921542574553136] = val_3.b;
            mem[1152921542574553140] = val_3.a;
            this.且丌东丞万业与丏丒 = val_3;
            mem[1152921542574553132] = val_3.g;
            this.丄业丐丙七且七丐丝 = 0;
            mem[1152921542574553164] = 0;
            mem[1152921542574553172] = 0;
            this.丞丞丛上丏丄丕专不 = 0;
            mem[1152921542574553148] = 0;
            mem[1152921542574553156] = 0;
        }
        private void Update()
        {
            float val_7;
            UnityEngine.Color val_8;
            UnityEngine.Color val_12;
            if((Rilisoft.Nest.丑七不且上丗丁一世() == 0) || (Rilisoft.Nest.丑七不且上丗丁一世().专丟丒世丈上丞下与() == false))
            {
                goto label_9;
            }
            
            float val_5 = UnityEngine.Time.deltaTime;
            val_5 = this.丝世丘与丁上专三万 + val_5;
            this.丝世丘与丁上专三万 = val_5;
            if(val_5 >= 0)
            {
                goto label_10;
            }
            
            val_7 = this.丝世丘与丁上专三万;
            val_8 = this.丄业丐丙七且七丐丝;
            val_12 = this.丞丞丛上丏丄丕专不;
            goto label_11;
            label_9:
            if(this.下丘丈丌丁与丅七东 != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            this.下丘丈丌丁与丅七东.SetColor(name:  "_OutlineColor", value:  new UnityEngine.Color() {r = this.丞丞丛上丏丄丕专不, g = V9.16B, b = V10.16B, a = V11.16B});
            return;
            label_10:
            val_8 = this.丞丞丛上丏丄丕专不;
            val_12 = this.丄业丐丙七且七丐丝;
            val_7 = this.丝世丘与丁上专三万 + (-1f);
            label_11:
            UnityEngine.Color val_6 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_8, g = V9.16B, b = V10.16B, a = V11.16B}, b:  new UnityEngine.Color() {r = val_12, g = V13.16B, b = V14.16B, a = V15.16B}, t:  val_7);
            if(this.下丘丈丌丁与丅七东 != null)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        public NestHighlighter()
        {
            this.业三丟丆丙丒与不世 = true;
        }
    
    }

}
