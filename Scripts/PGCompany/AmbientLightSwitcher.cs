using UnityEngine;

namespace PGCompany
{
    internal sealed class AmbientLightSwitcher : PGBehaviour
    {
        // Fields
        private bool _fog;
        private UnityEngine.Color _ambientLight;
        private PGCompany.丝丆业不一丌东万世 东丐丅丞丄丙一与丄;
        
        // Methods
        private void OnEnable()
        {
            this.东丐丅丞丄丙一与丄 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
            PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  new PGCompany.丝丆业不一丌东万世().丞丒且东三丁七丆丂(丙业与丙丗丝不丈东:  (this._fog == true) ? 1 : 0).丕一一丄丐丞丗业丅(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this._ambientLight, g = V9.16B, b = V10.16B, a = V11.16B}));
        }
        private void OnDisable()
        {
            PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  this.东丐丅丞丄丙一与丄);
        }
        public AmbientLightSwitcher()
        {
            UnityEngine.Color val_1 = 与丂丏丛丞丞丒丟丄.丛丙丐万东丌丈丏七();
            this._ambientLight = val_1;
            mem[1152921556098798448] = val_1.g;
            mem[1152921556098798452] = val_1.b;
            mem[1152921556098798456] = val_1.a;
        }
    
    }

}
