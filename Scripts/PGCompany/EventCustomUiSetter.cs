using UnityEngine;

namespace PGCompany
{
    internal class EventCustomUiSetter : MonoBehaviour
    {
        // Fields
        private Rilisoft.业丙丘丆东丈丕丂丄.OfferModule _offerType;
        private string _prefabsPath;
        private string _prefabsPrefix;
        private string 且丞上丆专万丟七东;
        private UnityEngine.GameObject 丘万丑下丘丁万丅丁;
        
        // Methods
        private void OnEnable()
        {
            Rilisoft.丗下丙丅且丐丞丙世.世丗东丈业上万且丒(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.EventCustomUiSetter::丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventCustomUiSetter::丘丟万丌丄三丏丈业()));
            this.丘丟万丌丄三丏丈业();
        }
        private void OnDisable()
        {
            Rilisoft.丗下丙丅且丐丞丙世.世丟丆丞不东丅丝三(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.EventCustomUiSetter::丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventCustomUiSetter::丘丟万丌丄三丏丈业()));
        }
        private void OnDestroy()
        {
            Rilisoft.丗下丙丅且丐丞丙世.世丟丆丞不东丅丝三(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.EventCustomUiSetter::丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.EventCustomUiSetter::丘丟万丌丄三丏丈业()));
        }
        private void 丗东与丅不不丐丈不(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)
        {
            if(this._offerType != 丕上业丕丘上丘七一)
            {
                    return;
            }
            
            this.丘丟万丌丄三丏丈业();
        }
        private void 丘丟万丌丄三丏丈业()
        {
            Rilisoft.丗下丙丅且丐丞丙世 val_10 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
            if((val_10.且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  this._offerType)) != false)
            {
                    string val_4 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().不丒七丘丏丆丛上丕(世七七丟丑丁丂与丞:  this._offerType);
                if((this.且丞上丆专万丟七东 != null) && ((System.String.op_Inequality(a:  this.且丞上丆专万丟七东, b:  val_4)) != false))
            {
                    if(this.丘万丑下丘丁万丅丁 != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁);
                this.丘万丑下丘丁万丅丁 = 0;
            }
            
                this.且丞上丆专万丟七东 = 0;
            }
            
                this.且丞上丆专万丟七东 = val_4;
                val_10 = this.丘万丑下丘丁万丅丁;
                if(val_10 != 0)
            {
                    return;
            }
            
                this.丘万丑下丘丁万丅丁 = this.业与下东与东丛丝万(丏东丆丆丛丄丕丈丞:  val_4);
                return;
            }
            
            this.且丞上丆专万丟七东 = 0;
            if(this.丘万丑下丘丁万丅丁 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丘万丑下丘丁万丅丁);
            this.丘万丑下丘丁万丅丁 = 0;
        }
        private UnityEngine.GameObject 业与下东与东丛丝万(string 丏东丆丆丛丄丕丈丞)
        {
            UnityEngine.Transform val_18;
            string val_19;
            UnityEngine.Object val_20;
            var val_21;
            var val_22;
            val_18 = this;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_19 = this._offerType.ToString().ToLower();
            val_20 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.IO.Path.Combine(path1:  this._prefabsPath, path2:  this._prefabsPrefix + val_19 + "_" + 丏东丆丆丛丄丕丈丞.ToLower()));
            if(val_20 == 0)
            {
                    val_19 = this._offerType.ToString();
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                mem2[0] = null;
                val_21 = "basic";
                if("basic" == null)
            {
                    val_21 = "basic";
            }
            
                val_20 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.IO.Path.Combine(path1:  this._prefabsPath, path2:  this._prefabsPrefix + val_19.ToLower() + "_" + ToLower()));
            }
            
            val_22 = 0;
            if(val_20 == 0)
            {
                    return (UnityEngine.GameObject)丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_20, 丈东丘丏与丌东东下:  val_18 = this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            int val_16 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            return (UnityEngine.GameObject)丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_20, 丈东丘丏与丌东东下:  val_18, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public EventCustomUiSetter()
        {
            this._offerType = 40;
            this._prefabsPath = "NguiWindows/CustomGui";
        }
    
    }

}
