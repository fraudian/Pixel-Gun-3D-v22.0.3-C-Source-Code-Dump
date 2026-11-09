using UnityEngine;

namespace Rilisoft
{
    public class NestEggClickHandler : MonoBehaviour
    {
        // Fields
        private Rilisoft.NestBanner _banner;
        private UnityEngine.Quaternion 丄丑丁世万丗专与丌;
        private UnityEngine.GameObject _eggObject;
        private bool 丛丕上业专丄与不丐;
        private bool 丏丑专丙丟丌世丌丒;
        private UnityEngine.Vector3 丈一东东丈丐专三丛;
        private UnityEngine.Vector3 不丝丑丁且丙丒丄丟;
        private float _sensitivity;
        private float _thresholdPercent;
        
        // Properties
        private float 万丙一下丂丟丈且丈 { get; }
        
        // Methods
        private float 丌世丙且七上丄丟专()
        {
            float val_2 = this._thresholdPercent;
            val_2 = val_2 * (float)UnityEngine.Screen.width;
            val_2 = val_2 * 0.01f;
            return (float)val_2;
        }
        private void Awake()
        {
            UnityEngine.Quaternion val_2 = this._eggObject.transform.localRotation;
            this.丄丑丁世万丗专与丌 = val_2;
            mem[1152921542573878260] = val_2.y;
            mem[1152921542573878264] = val_2.z;
            mem[1152921542573878268] = val_2.w;
        }
        private void Update()
        {
            var val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            UnityEngine.Vector3 val_24;
            var val_25;
            var val_26;
            val_19 = this;
            if(this._banner.IsVisible == false)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    this.一上丄丁丅丝丄与丌();
            }
            
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false)
            {
                    this.丂下东丕丅上丘丞丗();
            }
            
            if(this.丛丕上业专丄与不丐 == false)
            {
                goto label_5;
            }
            
            if(this.丏丑专丙丟丌世丌丒 == true)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            val_4.x = this.丈一东东丈丐专三丛 - val_4.x;
            val_20 = System.Math.Abs(val_4.x);
            float val_19 = this._thresholdPercent;
            val_21 = 0.01f;
            val_22 = (float)UnityEngine.Screen.width;
            val_19 = val_19 * val_22;
            val_23 = val_19 * val_21;
            if(val_20 >= val_23)
            {
                goto label_9;
            }
            
            label_5:
            if(this.丏丑专丙丟丌世丌丒 == true)
            {
                goto label_10;
            }
            
            val_24 = this.不丝丑丁且丙丒丄丟;
            val_25 = 1152921542574035356;
            val_26 = 1152921542574035360;
            goto label_11;
            label_9:
            this.丏丑专丙丟丌世丌丒 = true;
            label_10:
            val_24 = val_19;
            val_25 = 1152921542574035352;
            val_26 = 1152921542574035352;
            UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.不丝丑丁且丙丒丄丟, y = V10.16B, z = this.丈一东东丈丐专三丛}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_9 = this._eggObject.transform.localEulerAngles;
            UnityEngine.Vector3 val_11 = this._eggObject.transform.localEulerAngles;
            UnityEngine.Vector3 val_13 = this._eggObject.transform.localEulerAngles;
            float val_15 = val_11.y + (val_7.x * this._sensitivity);
            val_19 = this._eggObject.transform;
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_20 = val_17.x;
            val_23 = val_20;
            val_21 = val_17.y;
            val_22 = val_17.z;
            val_19.localRotation = new UnityEngine.Quaternion() {x = val_23, y = val_21, z = val_22, w = val_17.w};
            label_11:
            UnityEngine.Vector3 val_18 = UnityEngine.Input.mousePosition;
            this.不丝丑丁且丙丒丄丟 = val_18.x;
            mem[1152921542574035356] = val_18.y;
            mem[1152921542574035360] = val_18.z;
        }
        private void 一上丄丁丅丝丄与丌()
        {
            if(this._banner.IsVisible != false)
            {
                    this.丛丕上业专丄与不丐 = true;
                UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
                this.丈一东东丈丐专三丛 = val_2;
                mem[1152921542574188400] = val_2.y;
                mem[1152921542574188404] = val_2.z;
                this.不丝丑丁且丙丒丄丟 = val_2;
                mem[1152921542574188412] = val_2.y;
                mem[1152921542574188416] = val_2.z;
                return;
            }
            
            UnityEngine.Debug.Log(message:  "mouse down");
        }
        private void 丂下东丕丅上丘丞丗()
        {
            if(this._banner.IsVisible != false)
            {
                    if(this.丏丑专丙丟丌世丌丒 != true)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
                val_2.x = V0.16B - val_2.x;
                float val_6 = this._thresholdPercent;
                val_6 = val_6 * (float)UnityEngine.Screen.width;
                val_6 = val_6 * 0.01f;
                if(System.Math.Abs(val_2.x) < 0)
            {
                    this._banner.Hide();
            }
            
            }
            
                this.丛丕上业专丄与不丐 = false;
                this.丏丑专丙丟丌世丌丒 = false;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
                this.丈一东东丈丐专三丛 = val_4;
                mem[1152921542574312784] = val_4.y;
                mem[1152921542574312788] = val_4.z;
                this.不丝丑丁且丙丒丄丟 = val_4;
                mem[1152921542574312796] = val_4.y;
                mem[1152921542574312800] = val_4.z;
                return;
            }
            
            UnityEngine.Debug.Log(message:  "mouse Up");
        }
        public NestEggClickHandler()
        {
            this._sensitivity = 0.1f;
            this._thresholdPercent = 1f;
        }
    
    }

}
