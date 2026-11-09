using UnityEngine;

namespace Rilisoft
{
    internal class FortItemSkyboxComponent : MonoBehaviour
    {
        // Fields
        private UnityEngine.Color 世下丕东七丆丆专三;
        private Rilisoft.FogSettings 丒丏七丂不丄丈丘业;
        private UnityEngine.Color _ambientColor;
        private Rilisoft.FogSettings _fog;
        
        // Methods
        private void OnEnable()
        {
            float val_11;
            UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.丄丐丒丆与丅不丗不();
            this.世下丕东七丆丆专三 = val_1;
            mem[1152921542665737388] = val_1.g;
            mem[1152921542665737392] = val_1.b;
            mem[1152921542665737396] = val_1.a;
            Rilisoft.FogSettings val_2 = new Rilisoft.FogSettings();
            .Active = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
            .Mode = PGCompany.丟丝世世且丗丈丈丞.东与七丂丘丁丗丈丗();
            UnityEngine.Color val_6 = PGCompany.丟丝世世且丗丈丈丞.丌七丁丅三丅与三与();
            .Color = val_6;
            mem[1152921542665769384] = val_6.g;
            mem[1152921542665769388] = val_6.b;
            mem[1152921542665769392] = val_6.a;
            float val_7 = PGCompany.丟丝世世且丗丈丈丞.丂专世丂丕丌丁业一();
            if(val_2 != null)
            {
                    .Start = val_7;
                val_11 = PGCompany.丟丝世世且丗丈丈丞.丁丈专丌丝丙业丂下();
            }
            else
            {
                    .Start = val_7;
                val_11 = PGCompany.丟丝世世且丗丈丈丞.丁丈专丌丝丙业丂下();
            }
            
            .End = val_11;
            this.丒丏七丂不丄丈丘业 = val_2;
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this._ambientColor, g = val_6.g, b = val_6.b, a = val_6.a});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this._fog.Active);
            PGCompany.丟丝世世且丗丈丈丞.下丐专且三丄下丘下(丙业与丙丗丝不丈东:  this._fog.Mode);
            PGCompany.丟丝世世且丗丈丈丞.丌三上丂不丝一丄丑(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this._fog.Color, g = val_6.g, b = val_6.b, a = val_6.a});
            PGCompany.丟丝世世且丗丈丈丞.丁专丒东丆丏丏丛丗(丙业与丙丗丝不丈东:  this._fog.Start);
            PGCompany.丟丝世世且丗丈丈丞.东不一丛丟东丆不七(丙业与丙丗丝不丈东:  this._fog.End);
        }
        private void OnDisable()
        {
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.世下丕东七丆丆专三});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丒丏七丂不丄丈丘业.Active);
            PGCompany.丟丝世世且丗丈丈丞.下丐专且三丄下丘下(丙业与丙丗丝不丈东:  this.丒丏七丂不丄丈丘业.Mode);
            PGCompany.丟丝世世且丗丈丈丞.丌三上丂不丝一丄丑(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丒丏七丂不丄丈丘业.Color});
            PGCompany.丟丝世世且丗丈丈丞.丁专丒东丆丏丏丛丗(丙业与丙丗丝不丈东:  this.丒丏七丂不丄丈丘业.Start);
            PGCompany.丟丝世世且丗丈丈丞.东不一丛丟东丆不七(丙业与丙丗丝不丈东:  this.丒丏七丂不丄丈丘业.End);
        }
        public FortItemSkyboxComponent()
        {
        
        }
    
    }

}
