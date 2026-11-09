using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassSettings : ScriptableObject
    {
        // Fields
        private static PGCompany.BattlePass.BattlePassSettings _instance;
        private float _durationAddBPExpAnimation;
        private float _durationAddBPBlockPointAnimation;
        private UnityEngine.AudioClip _giveBPExpStartAudioClip;
        private UnityEngine.AudioClip _giveBPExpEndAudioClip;
        private UnityEngine.AudioClip _collectBPRewardAudioClip;
        private UnityEngine.AudioClip _openBPRewardInfoAudioClip;
        private UnityEngine.AudioClip _openBPWelcomeScreen;
        internal System.Collections.Generic.List<PGCompany.BattlePass.BPPhrase> mascotHelpPhrases;
        
        // Properties
        internal static PGCompany.BattlePass.BattlePassSettings Instance { get; }
        internal float DurationAddBPExpAnimation { get; }
        internal float DurationAddBPBlockPointAnimation { get; }
        internal UnityEngine.AudioClip GiveBPExpStartAudioClip { get; }
        internal UnityEngine.AudioClip GiveBPExpEndAudioClip { get; }
        internal UnityEngine.AudioClip CollectBPRewardAudioClip { get; }
        internal UnityEngine.AudioClip OpenBPRewardInfoAudioClip { get; }
        internal UnityEngine.AudioClip OpenBPWelcomeScreen { get; }
        
        // Methods
        internal static PGCompany.BattlePass.BattlePassSettings get_Instance()
        {
            if(PGCompany.BattlePass.BattlePassSettings._instance != 0)
            {
                    return (PGCompany.BattlePass.BattlePassSettings)PGCompany.BattlePass.BattlePassSettings._instance;
            }
            
            PGCompany.BattlePass.BattlePassSettings._instance = UnityEngine.Resources.Load<PGCompany.BattlePass.BattlePassSettings>(path:  "BattlePass/BPSettings");
            return (PGCompany.BattlePass.BattlePassSettings)PGCompany.BattlePass.BattlePassSettings._instance;
        }
        internal static float 不丈丑丑丆丁上下丛()
        {
            if(PGCompany.BattlePass.BattlePassSettings.Instance == 0)
            {
                    return (float)val_3._durationAddBPExpAnimation;
            }
            
            PGCompany.BattlePass.BattlePassSettings val_3 = PGCompany.BattlePass.BattlePassSettings.Instance;
            return (float)val_3._durationAddBPExpAnimation;
        }
        internal static float 丌下丌丂东下业丄丆()
        {
            if(PGCompany.BattlePass.BattlePassSettings.Instance == 0)
            {
                    return (float)val_3._durationAddBPBlockPointAnimation;
            }
            
            PGCompany.BattlePass.BattlePassSettings val_3 = PGCompany.BattlePass.BattlePassSettings.Instance;
            return (float)val_3._durationAddBPBlockPointAnimation;
        }
        internal float get_DurationAddBPExpAnimation()
        {
            return (float)this._durationAddBPExpAnimation;
        }
        internal float get_DurationAddBPBlockPointAnimation()
        {
            return (float)this._durationAddBPBlockPointAnimation;
        }
        internal UnityEngine.AudioClip get_GiveBPExpStartAudioClip()
        {
            return (UnityEngine.AudioClip)this._giveBPExpStartAudioClip;
        }
        internal UnityEngine.AudioClip get_GiveBPExpEndAudioClip()
        {
            return (UnityEngine.AudioClip)this._giveBPExpEndAudioClip;
        }
        internal UnityEngine.AudioClip get_CollectBPRewardAudioClip()
        {
            return (UnityEngine.AudioClip)this._collectBPRewardAudioClip;
        }
        internal UnityEngine.AudioClip get_OpenBPRewardInfoAudioClip()
        {
            return (UnityEngine.AudioClip)this._openBPRewardInfoAudioClip;
        }
        internal UnityEngine.AudioClip get_OpenBPWelcomeScreen()
        {
            return (UnityEngine.AudioClip)this._openBPWelcomeScreen;
        }
        public BattlePassSettings()
        {
            this.mascotHelpPhrases = new System.Collections.Generic.List<PGCompany.BattlePass.BPPhrase>();
        }
    
    }

}
