using UnityEngine;

namespace PGCompany
{
    internal class ModuleInsertPropertiesView : MonoBehaviour
    {
        // Fields
        private PropertiesLayout _propertiesLayout;
        private UISprite _propertySprite;
        private PGCompany.ModuleGadgetView _moduleGadgetView;
        private UnityEngine.GameObject _noGadget;
        private GadgetPreviewUI _gadgetPreview;
        private PGCompany.丗丟丅七东丄丙丟上 丂丐丗专丞与丄丕万;
        private PGCompany.丏丂一丗丙世丏丐三 丆不三不丈与三上丘;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丅七东丄丙丟上 世丝七与丝丒丐业下, PGCompany.丏丂一丗丙世丏丐三 丝七万丘丏丒下丂丌)
        {
            this.丂丐丗专丞与丄丕万 = 世丝七与丝丒丐业下;
            this.丆不三不丈与三上丘 = 丝七万丘丏丒下丂丌;
            this.丝一丅丆三东丂丞七();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_53;
            System.Collections.Generic.IEnumerable<TSource> val_54;
            var val_55;
            var val_56;
            float val_61;
            float val_62;
            string val_63;
            float val_64;
            float val_65;
            float val_66;
            float val_67;
            ModuleGadgetRecord val_68;
            var val_69;
            GadgetPreviewUI val_70;
            ModuleGadgetRecord val_71;
            string val_72;
            val_53 = this;
            if(this.丂丐丗专丞与丄丕万 != null)
            {
                    val_54 = this.丂丐丗专丞与丄丕万.丆丟且丗丒不丄七丌();
            }
            else
            {
                    System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_2 = null;
                val_54 = val_2;
                val_2 = new System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>();
            }
            
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<PGCompany.丏丂一丗丙世丏丐三>(source:  val_2);
            bool val_4 = val_3.Remove(item:  this.丆不三不丈与三上丘);
            this._propertiesLayout.世业丒万丘丆专丘丐();
            val_55 = 0;
            val_56 = 0;
            goto label_5;
            label_32:
            if(val_55 < val_2.Count)
            {
                    if((val_56 & 1) != 0)
            {
                    val_56 = 1;
            }
            else
            {
                    val_56 = System.String.op_Equality(a:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七(), b:  val_2.Item[0].业上丙丞丐丄丆丅七());
            }
            
                PropertyUI val_17 = this._propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  PGCompany.七丆丆丕丂丙丕丐丂.世丗丘丙丘丛丛一丟(丕上业丕丘上丘七一:  val_2.Item[0], 不丗丐丘业专丂丝上:  this._propertySprite.atlas), 丟丒丏丛三丟丑丗丝:  val_2.Item[0].业丙与世东丑丈丐万(), 丌丒丝东丌下丕丁丅:  val_2.Item[0].丅业专丏不丒丄丐一(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
                if((this.丆不三不丈与三上丘 != null) && ((System.String.op_Equality(a:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七(), b:  val_2.Item[0].业上丙丞丐丄丆丅七())) != false))
            {
                    UnityEngine.Color val_22 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompareRed");
            }
            else
            {
                    UnityEngine.Color val_23 = UnityEngine.Color.white;
            }
            
                val_61 = val_23.r;
                val_62 = val_23.b;
                val_17.丆丘与丌一不万不丐().color = new UnityEngine.Color() {r = val_61, g = val_23.g, b = val_62, a = val_23.a};
                val_63 = val_17.下丌丘七世丟丂业丟();
                val_63.color = new UnityEngine.Color() {r = val_61, g = val_23.g, b = val_62, a = val_23.a};
                val_64 = val_61;
                val_65 = val_23.g;
                val_66 = val_62;
                val_67 = val_23.a;
                val_17.丑一丆丑且丟上业丛().color = new UnityEngine.Color() {r = val_64, g = val_65, b = val_66, a = val_67};
            }
            
            val_55 = 1;
            label_5:
            if(val_55 < val_2.Count)
            {
                goto label_32;
            }
            
            if(this.丆不三不丈与三上丘 != null)
            {
                    if((this.丂丐丗专丞与丄丕万.专丙七丞丆丝丆与丗(丕上业丕丘上丘七一:  this.丆不三不丈与三上丘)) != true)
            {
                    val_63 = this.丆不三不丈与三上丘.业丙与世东丑丈丐万();
                PropertyUI val_33 = this._propertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  PGCompany.七丆丆丕丂丙丕丐丂.世丗丘丙丘丛丛一丟(丕上业丕丘上丘七一:  this.丆不三不丈与三上丘, 不丗丐丘业专丂丝上:  this._propertySprite.atlas), 丟丒丏丛三丟丑丗丝:  val_63, 丌丒丝东丌下丕丁丅:  this.丆不三不丈与三上丘.丅业专丏不丒丄丐一(), 丙丝与丆三丝不且丑:  0f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
                UnityEngine.Color val_34 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompareGreen");
                val_61 = val_34.r;
                val_62 = val_34.b;
                val_33.丆丘与丌一不万不丐().color = new UnityEngine.Color() {r = val_61, g = val_34.g, b = val_62, a = val_34.a};
                val_33.下丌丘七世丟丂业丟().color = new UnityEngine.Color() {r = val_61, g = val_34.g, b = val_62, a = val_34.a};
                val_64 = val_61;
                val_65 = val_34.g;
                val_66 = val_62;
                val_67 = val_34.a;
                val_33.丑一丆丑且丟上业丛().color = new UnityEngine.Color() {r = val_64, g = val_65, b = val_66, a = val_67};
                val_2.Add(item:  this.丆不三不丈与三上丘);
            }
            
            }
            
            ModulesSetGadgetsStorage.ModuleGadgetRecord val_39 = 0;
            string val_40 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_2, 丗丏丛丌丅东丟上丌: out  val_39);
            ModulesSetGadgetsStorage.ModuleGadgetRecord val_42 = 0;
            val_68 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            string val_43 = val_68.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_3, 丗丏丛丌丅东丟上丌: out  val_42);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleGadgetView, 丏业丟一东丂东丘丛:  false);
            this._noGadget.SetActive(value:  false);
            if(val_42 == 0)
            {
                goto label_52;
            }
            
            if(val_39 == val_42)
            {
                goto label_53;
            }
            
            label_61:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleGadgetView, 丏业丟一东丂东丘丛:  false);
            this._noGadget.SetActive(value:  true);
            UnityEngine.GameObject val_44 = this._gadgetPreview.gameObject;
            val_69 = 0;
            goto label_59;
            label_52:
            val_68 = val_39;
            if((val_68 == 0) || (val_42 != 0))
            {
                goto label_61;
            }
            
            if(val_56 == false)
            {
                goto label_62;
            }
            
            UnityEngine.Color val_45 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompareRed");
            this._moduleGadgetView.丈且东丑丂且万丒丅(三丐三丞丘丕不丒专:  val_68, 丑世丁七丆万丙三丁:  val_40, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleGadgetView, 丏业丟一东丂东丘丛:  true);
            val_70 = this._gadgetPreview;
            val_71 = val_39;
            val_72 = "Modules_RemoveGadget_BG";
            goto label_70;
            label_53:
            UnityEngine.Color val_46 = UnityEngine.Color.white;
            this._moduleGadgetView.丈且东丑丂且万丒丅(三丐三丞丘丕不丒专:  val_39, 丑世丁七丆万丙三丁:  val_40, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleGadgetView, 丏业丟一东丂东丘丛:  true);
            val_70 = this._gadgetPreview;
            val_71 = val_39;
            val_72 = "Modules_DefaultGadget_BG";
            goto label_70;
            label_62:
            UnityEngine.Color val_47 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompareGreen");
            this._moduleGadgetView.丈且东丑丂且万丒丅(三丐三丞丘丕不丒专:  val_68, 丑世丁七丆万丙三丁:  val_40, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleGadgetView, 丏业丟一东丂东丘丛:  true);
            val_70 = this._gadgetPreview;
            val_71 = val_39;
            val_72 = "Modules_AddGadget_BG";
            label_70:
            UnityEngine.Color val_48 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_72);
            val_61 = val_48.r;
            val_62 = val_48.b;
            val_70.丈且东丑丂且万丒丅(三丐三丞丘丕不丒专:  val_71, 丑世丁七丆万丙三丁:  val_40, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_61, g = val_48.g, b = val_62, a = val_48.a});
            val_69 = 1;
            label_59:
            this._gadgetPreview.gameObject.SetActive(value:  true);
            if(this.丆不三不丈与三上丘 == null)
            {
                    return;
            }
            
            if(this.丆不三不丈与三上丘.万丕丅下上丄丗万丞() != 7)
            {
                    return;
            }
            
            this._noGadget.SetActive(value:  false);
            val_53 = this._gadgetPreview.gameObject;
            val_53.SetActive(value:  false);
        }
        public ModuleInsertPropertiesView()
        {
        
        }
    
    }

}
