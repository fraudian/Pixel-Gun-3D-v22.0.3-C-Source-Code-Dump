using UnityEngine;

namespace TaskUIImposter.Calibrate
{
    internal class ControlGroup : MonoBehaviour
    {
        // Fields
        private static System.Action<TaskUIImposter.Calibrate.ControlGroup> 丑世一不丝与丈丑一;
        private UnityEngine.GameObject _rotationObject;
        private UISprite _fillBar;
        private float _rotationSpeed;
        private float _minFillAngle;
        public UnityEngine.AudioClip fillingClip;
        public UnityEngine.AudioSource audioSource;
        private UnityEngine.Quaternion 万丝丛丝七三三业三;
        private float 且丈丕丆丁丞一丙万;
        private bool 丘丄丆不丛丗上三上;
        private bool <丑万丕丆世丄丒丂丑>k__BackingField;
        
        // Properties
        internal float 万七东下丕三丛丛丒 { get; }
        internal bool 一且丂丒东丒下东丁 { get; set; }
        
        // Methods
        internal static void 一东丞丗业丁丟不业(System.Action<TaskUIImposter.Calibrate.ControlGroup> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  TaskUIImposter.Calibrate.ControlGroup.丑世一不丝与丈丑一, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 上业丙世不丁丏下丒(System.Action<TaskUIImposter.Calibrate.ControlGroup> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  TaskUIImposter.Calibrate.ControlGroup.丑世一不丝与丈丑一, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal float 丙丙丑丘丘东丆丐丄()
        {
            return (float)this.且丈丕丆丁丞一丙万;
        }
        internal bool 专三丕七丂与丅且万()
        {
            return (bool)this.<丑万丕丆世丄丒丂丑>k__BackingField;
        }
        private void 丌丕丑业丟丅丗丅丝(bool 丙业与丙丗丝不丈东)
        {
            this.<丑万丕丆世丄丒丂丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丗下丗丕丂丈万七丛(float 丌下七丒丐不东丆不)
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  丌下七丒丐不东丆不);
            this.万丝丛丝七三三业三 = val_1;
            mem[1152921540893553188] = val_1.y;
            mem[1152921540893553192] = val_1.z;
            mem[1152921540893553196] = val_1.w;
            this._rotationObject.transform.rotation = new UnityEngine.Quaternion() {x = this.万丝丛丝七三三业三, y = V9.16B, z = V10.16B, w = V11.16B};
        }
        private void Update()
        {
            UISprite val_13;
            float val_15;
            val_13 = this;
            if(this.丘丄丆不丛丗上三上 == false)
            {
                goto label_1;
            }
            
            bool val_1 = this.audioSource.isPlaying;
            if((this.<丑万丕丆世丄丒丂丑>k__BackingField) == false)
            {
                goto label_3;
            }
            
            if(val_1 != false)
            {
                    this.audioSource.clip = 0;
                this.audioSource.loop = false;
                this.audioSource.Stop();
            }
            
            val_15 = UnityEngine.Random.Range(min:  0.9f, max:  0.95f);
            goto label_24;
            label_1:
            val_15 = UnityEngine.Random.Range(min:  0.05f, max:  0.1f);
            this.且丈丕丆丁丞一丙万 = val_15;
            if(this._fillBar != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_3:
            if(val_1 != true)
            {
                    this.audioSource.clip = this.fillingClip;
                this.audioSource.loop = true;
                this.audioSource.Play();
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            this._rotationObject.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, angle:  -(this._rotationSpeed * UnityEngine.Time.deltaTime));
            float val_8 = this._minFillAngle * 0.01745329f;
            UnityEngine.Quaternion val_10 = this._rotationObject.transform.rotation;
            float val_11 = val_10.z * 0.01745329f;
            if(val_11 > val_8)
            {
                    float val_13 = 1f;
                val_11 = val_11 - val_8;
                val_13 = val_13 - val_8;
                val_15 = val_11 / val_13;
                this.且丈丕丆丁丞一丙万 = val_15;
            }
            else
            {
                    val_15 = UnityEngine.Random.Range(min:  0.05f, max:  0.1f);
                this.且丈丕丆丁丞一丙万 = 0f;
            }
            
            label_24:
            val_13 = this._fillBar;
            label_10:
            val_13.fillAmount = val_15;
        }
        internal bool 世三丅不丄丂丒丕上()
        {
            return (bool)this.丘丄丆不丛丗上三上;
        }
        internal void 不上丕不丞业一丗丂(bool 丛丅丘一丏丙且丌上)
        {
            this.丘丄丆不丛丗上三上 = 丛丅丘一丏丙且丌上;
        }
        internal void Reset()
        {
            this.<丑万丕丆世丄丒丂丑>k__BackingField = false;
            this.且丈丕丆丁丞一丙万 = 0f;
            this._rotationObject.transform.rotation = new UnityEngine.Quaternion() {x = this.万丝丛丝七三三业三, y = V9.16B, z = V10.16B, w = V11.16B};
            this.audioSource.clip = 0;
            this.audioSource.loop = false;
            this.audioSource.Stop();
        }
        internal void 与丅专下丐丐丑丁丏()
        {
            this.<丑万丕丆世丄丒丂丑>k__BackingField = true;
        }
        private void 丂三丛下丐丆丒三丗()
        {
            if(TaskUIImposter.Calibrate.ControlGroup.丑世一不丝与丈丑一 == null)
            {
                    return;
            }
            
            TaskUIImposter.Calibrate.ControlGroup.丑世一不丝与丈丑一.Invoke(obj:  this);
        }
        public void U_Select()
        {
            this.丂三丛下丐丆丒三丗();
        }
        public ControlGroup()
        {
            this._rotationSpeed = 150f;
            this._minFillAngle = 15f;
        }
    
    }

}
