using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丛业丗不丅丑业丈丛
    {
        // Fields
        private float 七不丌七七一丆且丛;
        private float 七丁丈丘丂不七丟东;
        
        // Properties
        public float 丏东丟丟丛丝丘东丘 { get; }
        public float 丝与丟万丅丅丂丂丈 { get; }
        
        // Methods
        public float 一上丙丏丒下与丟丟()
        {
            return (float)this.七不丌七七一丆且丛;
        }
        public float 丈东丘下业丗丛世丆()
        {
            return (float)this.七丁丈丘丂不七丟东;
        }
        public float 万丞专丂丞丄与下丏(float 上丕丈丞丌丘丅不与)
        {
            return UnityEngine.Mathf.Clamp(value:  上丕丈丞丌丘丅不与, min:  this.七不丌七七一丆且丛, max:  this.七丁丈丘丂不七丟东);
        }
        public float 下下丑丆下世东丏三(float 上丕丈丞丌丘丅不与, float 丂三丟丂丈丐丆丗丟)
        {
            return UnityEngine.Mathf.Lerp(a:  this.万丞专丂丞丄与下丏(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与), b:  this.七丁丈丘丂不七丟东, t:  丂三丟丂丈丐丆丗丟);
        }
        public void 丅东万丄丑且丞丏七(float 丗丛丆丐下丈与万业, float 丟丈与丟丞三上丛丕)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  丗丛丆丐下丈与万业);
            float val_2 = UnityEngine.Mathf.Clamp01(value:  丟丈与丟丞三上丛丕);
            if(val_1 <= val_2)
            {
                    this.七不丌七七一丆且丛 = val_1;
                this.七丁丈丘丂不七丟东 = val_2;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "Bounds are not ordered.");
        }
        public 丛业丗不丅丑业丈丛()
        {
            this.七丁丈丘丂不七丟东 = 1f;
        }
    
    }

}
