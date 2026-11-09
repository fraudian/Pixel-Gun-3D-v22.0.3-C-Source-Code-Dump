using UnityEngine;

namespace PlayerBot
{
    internal class 丕与丟丆丏三三丈丄 : 丁丘丄丞丂丏丑丙丝
    {
        // Fields
        private float 丅丞七专丕丄七丙丝;
        private float 三丗一丘丘丒丄丗丆;
        private float 丗丑一丝一丒丝丄丆;
        private Rilisoft.专与丏丞三与不不丆 丙丗世丗下下上与丟;
        
        // Methods
        internal override void 丌一七丌丄丌七上丞(PlayerBot.AIBotController 丒专丈丛下丒一丒丛)
        {
            this.丌一七丌丄丌七上丞(丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
            if(丒专丈丛下丒一丒丛 != null)
            {
                    this.丅丞七专丕丄七丙丝 = 丒专丈丛下丒一丒丛.maxMoveDistance;
                this.三丗一丘丘丒丄丗丆 = 丒专丈丛下丒一丒丛.moveSpeed;
                return;
            }
            
            this.丅丞七专丕丄七丙丝 = 0f;
            this.三丗一丘丘丒丄丗丆 = 3.048523E-34f;
        }
        internal override void 丑丁业不丏丆丞丞一()
        {
        
        }
        internal bool 丑七万专丌业丙丙丌(Rilisoft.专与丏丞三与不不丆 丘丄丌丌丆丙丅丛丆, out UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            var val_9;
            var val_10;
            var val_16;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            业丒丝丗与丐丛丟丏.x = val_1.x;
            业丒丝丗与丐丛丟丏.y = val_1.y;
            业丒丝丗与丐丛丟丏.z = val_1.z;
            val_9 = 0;
            val_10 = 0;
            val_16 = null;
            val_16 = null;
            return (bool) & 1;
        }
        public 丕与丟丆丏三三丈丄()
        {
            this.丅丞七专丕丄七丙丝 = 10f;
            this.三丗一丘丘丒丄丗丆 = 6.5f;
            val_1 = new System.Object();
        }
    
    }

}
