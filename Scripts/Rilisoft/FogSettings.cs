using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class FogSettings
    {
        // Fields
        public bool Active;
        public UnityEngine.Color Color;
        public float End;
        public UnityEngine.FogMode Mode;
        public float Start;
        
        // Methods
        internal static Rilisoft.FogSettings 且且丘丆三下丂丗下()
        {
            float val_9;
            Rilisoft.FogSettings val_1 = new Rilisoft.FogSettings();
            .Active = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
            .Mode = PGCompany.丟丝世世且丗丈丈丞.东与七丂丘丁丗丈丗();
            UnityEngine.Color val_5 = PGCompany.丟丝世世且丗丈丈丞.丌七丁丅三丅与三与();
            .Color = val_5;
            mem[1152921542322929736] = val_5.g;
            mem[1152921542322929740] = val_5.b;
            mem[1152921542322929744] = val_5.a;
            float val_6 = PGCompany.丟丝世世且丗丈丈丞.丂专世丂丕丌丁业一();
            if(val_1 != null)
            {
                    .Start = val_6;
                val_9 = PGCompany.丟丝世世且丗丈丈丞.丁丈专丌丝丙业丂下();
            }
            else
            {
                    .Start = val_6;
                val_9 = PGCompany.丟丝世世且丗丈丈丞.丁丈专丌丝丙业丂下();
            }
            
            .End = val_9;
            return val_1;
        }
        public void 丙丗丒七丆丟丅七丑()
        {
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.Active);
            PGCompany.丟丝世世且丗丈丈丞.下丐专且三丄下丘下(丙业与丙丗丝不丈东:  this.Mode);
            PGCompany.丟丝世世且丗丈丈丞.丌三上丂不丝一丄丑(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.Color});
            PGCompany.丟丝世世且丗丈丈丞.丁专丒东丆丏丏丛丗(丙业与丙丗丝不丈东:  this.Start);
            PGCompany.丟丝世世且丗丈丈丞.东不一丛丟东丆不七(丙业与丙丗丝不丈东:  this.End);
        }
        public FogSettings()
        {
        
        }
    
    }

}
