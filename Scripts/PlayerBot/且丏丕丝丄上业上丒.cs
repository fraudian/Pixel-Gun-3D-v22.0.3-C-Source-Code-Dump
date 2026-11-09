using UnityEngine;

namespace PlayerBot
{
    internal interface 且丏丕丝丄上业上丒
    {
        // Properties
        public abstract bool 丈下三丟丑丒业东丕 { get; }
        public abstract PlayerBot.丙丗世丅丟东上世下 且丛不丟丁丝东丑七 { get; }
        public abstract UnityEngine.Transform 上丛东下专丅一丂一 { get; }
        public abstract UnityEngine.Vector3 下丘丈丘一专下东丆 { get; }
        public abstract UnityEngine.Vector3 下且丅丗专一东丄三 { get; }
        public abstract int 丆丐一七且丞专世丑 { get; }
        public abstract float 下丑丐丂丞一万丂丞 { get; }
        
        // Methods
        public abstract bool get_BotTargetIsDead(); // 0
        public abstract PlayerBot.丙丗世丅丟东上世下 get_BotTargetMeaning(); // 0
        public abstract UnityEngine.Transform get_BotTargetTransform(); // 0
        public abstract UnityEngine.Vector3 get_BotTargetAimCenter(); // 0
        public abstract UnityEngine.Vector3 get_BotTargetVelocity(); // 0
        public abstract int get_BotTargetPriority(); // 0
        public abstract float get_BotTargetCurrentSpeed(); // 0
        public abstract void RegisterTargetForBot(); // 0
        public abstract void UnregisterTargetForBot(); // 0
    
    }

}
