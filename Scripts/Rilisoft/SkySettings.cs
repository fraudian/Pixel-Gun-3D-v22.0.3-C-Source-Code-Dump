using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class SkySettings
    {
        // Fields
        public UnityEngine.Color ambient;
        public UnityEngine.Material mat;
        public UnityEngine.Color matColor;
        
        // Methods
        public Rilisoft.SkySettings 且且丘丆三下丂丗下(UnityEngine.Material 丘上专不丂万业不一)
        {
            UnityEngine.Color val_2 = PGCompany.丟丝世世且丗丈丈丞.七丐一不丄丟丈丁丗();
            .ambient = val_2;
            mem[1152921542323294404] = val_2.g;
            mem[1152921542323294408] = val_2.b;
            mem[1152921542323294412] = val_2.a;
            UnityEngine.Color val_3 = 丘上专不丂万业不一.color;
            .matColor = val_3;
            mem[1152921542323294428] = val_3.g;
            mem[1152921542323294432] = val_3.b;
            mem[1152921542323294436] = val_3.a;
            .mat = 丘上专不丂万业不一;
            return (Rilisoft.SkySettings)new Rilisoft.SkySettings();
        }
        public void 丙丗丒七丆丟丅七丑()
        {
            PGCompany.丟丝世世且丗丈丈丞.丌丈一丒丙丗丂东东(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.ambient});
            this.mat.color = new UnityEngine.Color() {r = this.matColor, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        public SkySettings()
        {
        
        }
    
    }

}
