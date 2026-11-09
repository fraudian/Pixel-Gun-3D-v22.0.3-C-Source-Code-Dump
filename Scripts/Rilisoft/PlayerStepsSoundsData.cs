using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class PlayerStepsSoundsData
    {
        // Fields
        public UnityEngine.AudioClip Walk;
        public UnityEngine.AudioClip Jump;
        public UnityEngine.AudioClip JumpDown;
        public UnityEngine.AudioClip WalkMech;
        public UnityEngine.AudioClip WalkMechBear;
        
        // Methods
        internal void 七丌且丑丝业与专万(SkinName 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.AudioClip val_1;
            if(一丐丗丁丞丆丅丟丄 != null)
            {
                    一丐丗丁丞丆丅丟丄.walkAudio = this.Walk;
                一丐丗丁丞丆丅丟丄.jumpAudio = this.Jump;
                一丐丗丁丞丆丅丟丄.jumpDownAudio = this.JumpDown;
                val_1 = this.WalkMechBear;
            }
            else
            {
                    mem[288] = this.Walk;
                mem[176] = this.Jump;
                mem[184] = this.JumpDown;
                val_1 = this.WalkMechBear;
            }
            
            一丐丗丁丞丆丅丟丄.walkMechBear = val_1;
        }
        internal bool 与丁丕七丄丑一七三(SkinName 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.AudioClip val_6 = 一丐丗丁丞丆丅丟丄.walkAudio;
            if(val_6 != this.Walk)
            {
                    return false;
            }
            
            val_6 = 一丐丗丁丞丆丅丟丄.jumpAudio;
            if(val_6 != this.Jump)
            {
                    return false;
            }
            
            val_6 = 一丐丗丁丞丆丅丟丄.jumpDownAudio;
            if(val_6 != this.JumpDown)
            {
                    return false;
            }
            
            val_6 = this.WalkMech;
            if(一丐丗丁丞丆丅丟丄.业丂丕丄丕下丗丒丘() != val_6)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Equality(x:  一丐丗丁丞丆丅丟丄.walkMechBear, y:  this.WalkMechBear);
        }
        internal static Rilisoft.PlayerStepsSoundsData 东丝七业丄丑丒世七(SkinName 一丐丗丁丞丆丅丟丄)
        {
            UnityEngine.AudioClip val_4;
            Rilisoft.PlayerStepsSoundsData val_1 = new Rilisoft.PlayerStepsSoundsData();
            if(val_1 != null)
            {
                    .Walk = 一丐丗丁丞丆丅丟丄.walkAudio;
                .Jump = 一丐丗丁丞丆丅丟丄.jumpAudio;
                .JumpDown = 一丐丗丁丞丆丅丟丄.jumpDownAudio;
                .WalkMech = 一丐丗丁丞丆丅丟丄.业丂丕丄丕下丗丒丘();
                val_4 = 一丐丗丁丞丆丅丟丄.walkMechBear;
            }
            else
            {
                    mem[16] = 一丐丗丁丞丆丅丟丄.walkAudio;
                mem[24] = 一丐丗丁丞丆丅丟丄.jumpAudio;
                mem[32] = 一丐丗丁丞丆丅丟丄.jumpDownAudio;
                mem[40] = 一丐丗丁丞丆丅丟丄.业丂丕丄丕下丗丒丘();
                val_4 = 一丐丗丁丞丆丅丟丄.walkMechBear;
            }
            
            .WalkMechBear = val_4;
            return val_1;
        }
        public PlayerStepsSoundsData()
        {
        
        }
    
    }

}
