using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class PetAnimation
    {
        // Fields
        public string AnimationName;
        public float CurrentPlaySpeed;
        public float SpeedModificator;
        public Rilisoft.丘且一万丏丕丝丘丁 Type;
        
        // Methods
        public PetAnimation()
        {
            this.SpeedModificator = 1f;
        }
    
    }

}
