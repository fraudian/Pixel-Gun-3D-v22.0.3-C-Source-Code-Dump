using UnityEngine;

namespace Rilisoft
{
    internal sealed class 且丞丘丁丁丝世丙丄
    {
        // Fields
        private int 丆不下丝不丝丐下丅;
        private int 不丗专上丐丕丛丙丑;
        private static readonly Rilisoft.且丞丘丁丁丝世丙丄 <不丁丄七丛不丆丁丕>k__BackingField;
        
        // Properties
        internal static Rilisoft.且丞丘丁丁丝世丙丄 丆丕丝丒不丙且丐丗 { get; }
        public int 东业丕丞丏万丌一丕 { get; }
        public int 东丄丁丙丌东业丅不 { get; }
        public int 不专三丆上丞丅丘上 { get; }
        
        // Methods
        private 且丞丘丁丁丝世丙丄()
        {
        
        }
        internal static Rilisoft.且丞丘丁丁丝世丙丄 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.且丞丘丁丁丝世丙丄)Rilisoft.且丞丘丁丁丝世丙丄.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        public int 丁丝丙丆丌丁丅丘丕()
        {
            return (int)this.不丗专上丐丕丛丙丑;
        }
        public int 业丛业七丈七丏丏上()
        {
            return (int)this.丆不下丝不丝丐下丅;
        }
        public int 一丈七丙且不丌丞丄()
        {
            return (int)this.丆不下丝不丝丐下丅 + this.不丗专上丐丕丛丙丑;
        }
        public void 且七丙丄丘一丄上不()
        {
            this.丆不下丝不丝丐下丅 = 0;
            this.不丗专上丐丕丛丙丑 = 0;
        }
        public void 丌丆下丙一一七与不()
        {
            int val_3 = this.不丗专上丐丕丛丙丑;
            val_3 = val_3 + 1;
            this.不丗专上丐丕丛丙丑 = val_3;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[InterstitialCounter.IncrementRealInterstitialCount] " + this);
        }
        public void 与不丕丟丄丈丆丁丅()
        {
            int val_3 = this.丆不下丝不丝丐下丅;
            val_3 = val_3 + 1;
            this.丆不下丝不丝丐下丅 = val_3;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[InterstitialCounter.IncrementFakeInterstitialCount] " + this);
        }
        public override string ToString()
        {
            return (string)System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "realInterstitialCount: {0}, fakeInterstitialCount: {1}", arg0:  this.不丗专上丐丕丛丙丑, arg1:  this.丆不下丝不丝丐下丅);
        }
        private static 且丞丘丁丁丝世丙丄()
        {
            Rilisoft.且丞丘丁丁丝世丙丄.<不丁丄七丛不丆丁丕>k__BackingField = new Rilisoft.且丞丘丁丁丝世丙丄();
        }
    
    }

}
