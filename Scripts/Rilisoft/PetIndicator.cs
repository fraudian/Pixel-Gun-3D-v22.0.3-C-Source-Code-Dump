using UnityEngine;

namespace Rilisoft
{
    public class PetIndicator : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _hpBarObject;
        private UnityEngine.Transform _HPIndicator;
        private UI2DSprite _iconSprite;
        private Rilisoft.PetEngine 丙丒丐丄丒丛下丘丁;
        private float 丁且丅三丐与丌丒下;
        private string 丗世下丟丅万万丐且;
        private UITexture _RewiveIndicator;
        private UnityEngine.GameObject _rootObject;
        private UnityEngine.Shader 丗丑三万万业丗三丕;
        private UnityEngine.Shader 丘不上专丙丅与业与;
        private UnityEngine.Vector3 上七丒丌下丝丘丁丞;
        public UnityEngine.Transform rightAnchor;
        
        // Methods
        private void Awake()
        {
            this.丘不上专丙丅与业与 = UnityEngine.Shader.Find(name:  "Unlit/Transparent Colored");
            this.丗丑三万万业丗三丕 = UnityEngine.Shader.Find(name:  "Unlit/TransparentGrayscale");
        }
        private void 丏丐丛东丌三业丏丗(UnityEngine.DeviceOrientation 万且万且丑丗且丌丆)
        {
            var val_23;
            var val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_24 = val_1.x;
            val_25 = val_1.y;
            val_26 = val_1.z;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
            {
                    val_23 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三();
                bool val_6 = 丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() ^ 1;
                val_6 = val_23 | val_6;
            }
            
            val_27 = this.上七丒丌下丝丘丁丞;
            val_28 = V10.16B;
            val_29 = V11.16B;
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
            if(丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true)
            {
                    UnityEngine.Vector3 val_12 = this.丌丟丄业且三丛丕丄().right;
                val_23 = UnityEngine.Screen.width;
                UnityEngine.Vector3 val_16 = this.丌丟丄业且三丛丕丄().localPosition;
                float val_23 = 768f;
                float val_24 = -2f;
                val_23 = val_23 / (float)UnityEngine.Screen.height;
                val_23 = val_23 * (float)val_23;
                val_24 = val_23 + (val_16.x * val_24);
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  val_24);
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.上七丒丌下丝丘丁丞, y = val_25, z = val_26}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                val_27 = val_19.x;
                val_28 = val_19.y;
                val_29 = val_19.z;
                this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
                val_26 = val_26;
                val_25 = val_25;
            }
            
            UnityEngine.Transform val_20 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_21 = val_20.localPosition;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = (((万且万且丑丗且丌丆 == 4) ? 1 : 0) != val_6) ? -100f : (val_24), y = val_25, z = val_26});
            val_20.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        }
        private void Update()
        {
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            UI2DSprite val_37;
            UnityEngine.Shader val_38;
            var val_39;
            var val_40;
            val_32 = null;
            val_32 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
            {
                goto label_18;
            }
            
            val_33 = null;
            val_33 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
            {
                goto label_18;
            }
            
            val_34 = null;
            val_34 = null;
            if(与丆一业七与不不丄() == 0)
            {
                goto label_18;
            }
            
            val_35 = null;
            val_35 = null;
            if(丄丝丝下丟丘丄丒丈() == false)
            {
                goto label_23;
            }
            
            label_18:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._rootObject, 丏业丟一东丂东丘丛:  false);
            return;
            label_23:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._rootObject, 丏业丟一东丂东丘丛:  true);
            val_36 = null;
            val_36 = null;
            Rilisoft.PetEngine val_6 = 与丆一业七与不不丄();
            this.丙丒丐丄丒丛下丘丁 = val_6;
            PetInfo val_7 = val_6.丙丕丞且丕不丘丙丑();
            if((System.String.op_Inequality(a:  this.丗世下丟丅万万丐且, b:  val_7.Id)) != false)
            {
                    PetInfo val_9 = this.丙丒丐丄丒丛下丘丁.丙丕丞且丕不丘丙丑();
                this._iconSprite.sprite2D = UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  System.String.Format(format:  "Pets/Icons/{0}_icon", arg0:  val_9.Id));
                PetInfo val_12 = this.丙丒丐丄丒丛下丘丁.丙丕丞且丕不丘丙丑();
                this.丗世下丟丅万万丐且 = val_12.Id;
            }
            
            if(this.丁且丅三丐与丌丒下 == this.丙丒丐丄丒丛下丘丁.万丞丆丌世丝丞丆上())
            {
                goto label_41;
            }
            
            if(this.丙丒丐丄丒丛下丘丁.万丞丆丌世丝丞丆上() <= 0f)
            {
                goto label_43;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._hpBarObject, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_18 = this._HPIndicator.localScale;
            UnityEngine.Vector3 val_19 = this._HPIndicator.localScale;
            float val_20 = this.丙丒丐丄丒丛下丘丁.万丞丆丌世丝丞丆上() / this.丙丒丐丄丒丛下丘丁.丙丕丞且丕不丘丙丑().HP;
            this._HPIndicator.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_37 = this._iconSprite;
            val_38 = this.丘不上专丙丅与业与;
            if(val_37 != null)
            {
                goto label_56;
            }
            
            goto label_53;
            label_43:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._hpBarObject, 丏业丟一东丂东丘丛:  false);
            val_37 = this._iconSprite;
            val_38 = this.丗丑三万万业丗三丕;
            if(val_37 != null)
            {
                goto label_56;
            }
            
            label_53:
            label_56:
            this.丁且丅三丐与丌丒下 = this.丙丒丐丄丒丛下丘丁.万丞丆丌世丝丞丆上();
            label_41:
            val_39 = null;
            val_39 = null;
            UnityEngine.GameObject val_24 = this._RewiveIndicator.gameObject;
            if(与丆一业七与不不丄().丏丛万丆丝丌丏丟下() > 0f)
            {
                    val_24.SetActive(value:  true);
                val_40 = null;
                val_40 = null;
                float val_31 = 与丆一业七与不不丄().世且丈且丘丗且丞丄() - 与丆一业七与不不丄().丏丛万丆丝丌丏丟下();
                val_31 = val_31 / 与丆一业七与不不丄().世且丈且丘丗且丞丄();
                this._RewiveIndicator.fillAmount = val_31;
                return;
            }
            
            val_24.SetActive(value:  false);
        }
        public PetIndicator()
        {
        
        }
    
    }

}
