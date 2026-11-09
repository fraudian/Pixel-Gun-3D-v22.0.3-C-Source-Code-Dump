using UnityEngine;

namespace Rilisoft
{
    public class PetIndicationController : MonoBehaviour
    {
        // Fields
        private Rilisoft.PetEngine 世专世丅东丟丕丗丘;
        private UnityEngine.MeshRenderer 丂丞丑丏丛丙世七丝;
        private UnityEngine.Color 下丘丘下丌丗丟丗丗;
        private UnityEngine.Color 丄万丕且丏丅丕万丞;
        private UnityEngine.Color 丟上丈丏丂上丈丏七;
        private UnityEngine.Color 一丙丟丒丒与上丐丆;
        private UnityEngine.Vector3[] 丛丞专下丄丐丝丟世;
        public UnityEngine.GameObject DirectionObj;
        public UnityEngine.GameObject IconObject;
        public bool isUpdateNameFromInfo;
        public UnityEngine.GameObject LabelObj;
        private System.Collections.Generic.List<UnityEngine.GameObject> 丌万丑与东丌丄丆丟;
        public UnityEngine.Camera LookToCamera;
        public UnityEngine.Material MaterialMy;
        public UnityEngine.Material MaterialOur;
        private UnityEngine.TextMesh TextMesh;
        private string 丕丁万丛丈与且三七;
        private static bool 丛世丁世丗世业且丈;
        
        // Properties
        private Rilisoft.PetEngine 丅丑丐东丄丏丝丂一 { get; }
        private string 丝上世丒丗丞丐丘丕 { get; set; }
        internal static bool 丐丂丕丛业丄丘丏丂 { get; set; }
        
        // Methods
        private Rilisoft.PetEngine 丕世万业丁不丅丌丗()
        {
            Rilisoft.PetEngine val_4;
            if(this.世专世丅东丟丕丗丘 == 0)
            {
                    this.世专世丅东丟丕丗丘 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<Rilisoft.PetEngine>(丝三丁东丈丒世丅业:  this.gameObject);
                return val_4;
            }
            
            val_4 = this.世专世丅东丟丕丗丘;
            return val_4;
        }
        private string 丈专东丕丒丛丏丛丌()
        {
            string val_3 = this.丕丁万丛丈与且三七;
            if(val_3 != null)
            {
                    return (string)val_3;
            }
            
            if(this.TextMesh != 0)
            {
                    if(this.TextMesh.text != null)
            {
                goto label_6;
            }
            
            }
            
            val_3 = System.String.alignConst;
            label_6:
            this.丕丁万丛丈与且三七 = val_3;
            return (string)val_3;
        }
        internal void 丑上七丈丘东丐丝丈(string 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_1;
            }
            
            label_9:
            this.丕丁万丛丈与且三七 = 丙业与丙丗丝不丈东;
            if(this.TextMesh == 0)
            {
                    return;
            }
            
            this.TextMesh.text = this.丕丁万丛丈与且三七;
            return;
            label_1:
            if(this != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        internal void 下丟丐丌三丒丅丈不()
        {
            var val_13;
            var val_14;
            if(this.丌万丑与东丌丄丆丟.Count >= this.丛丞专下丄丐丝丟世.Length)
            {
                goto label_3;
            }
            
            val_13 = 0;
            goto label_4;
            label_9:
            this.丌万丑与东丌丄丆丟.Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.LabelObj));
            val_13 = 1;
            label_4:
            if(val_13 < this.丛丞专下丄丐丝丟世.Length)
            {
                goto label_9;
            }
            
            label_3:
            val_14 = 0;
            goto label_10;
            label_30:
            UnityEngine.Transform val_4 = this.丌万丑与东丌丄丆丟.Item[0].transform;
            val_4.SetParent(p:  this.LabelObj.transform);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            val_4.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            val_4.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
            val_4.localPosition = new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 4.656534E-34f};
            UnityEngine.TextMesh val_9 = this.丌万丑与东丌丄丆丟.Item[0].GetComponent<UnityEngine.TextMesh>();
            UnityEngine.Color val_10 = UnityEngine.Color.black;
            val_9.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
            string val_11 = this.丈专东丕丒丛丏丛丌();
            if(val_9 != null)
            {
                    val_9.text = val_11;
            }
            else
            {
                    val_9.text = val_11;
            }
            
            val_9.offsetZ = 0.2f;
            val_14 = 1;
            label_10:
            if(val_14 < this.丌万丑与东丌丄丆丟.Count)
            {
                goto label_30;
            }
        
        }
        private void Awake()
        {
            this.丂丞丑丏丛丙世七丝 = this.TextMesh.gameObject.GetComponent<UnityEngine.MeshRenderer>();
            if(this.TextMesh == 0)
            {
                    return;
            }
            
            this.TextMesh.richText = false;
        }
        private void Update()
        {
            string val_47;
            bool val_48;
            int val_49;
            var val_50;
            var val_51;
            var val_52;
            val_47 = 1152921504848912384;
            if(this.LookToCamera == 0)
            {
                    UnityEngine.Camera val_2 = UnityEngine.Camera.main;
                this.LookToCamera = val_2;
                if(val_2 == 0)
            {
                    return;
            }
            
            }
            
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
            {
                goto label_35;
            }
            
            }
            
            val_48 = this.isUpdateNameFromInfo;
            val_49 = System.String.alignConst;
            val_47 = this.丕世万业丁不丅丌丗();
            if(val_47 == null)
            {
                goto label_12;
            }
            
            if(val_48 == false)
            {
                goto label_13;
            }
            
            label_23:
            if(val_47.丙丕丞且丕不丘丙丑() == null)
            {
                goto label_22;
            }
            
            val_47 = this.丕世万业丁不丅丌丗().丙丕丞且丕不丘丙丑();
            if((System.String.op_Inequality(a:  val_9.Id, b:  System.String.alignConst)) == false)
            {
                goto label_22;
            }
            
            Rilisoft.PetsManager val_11 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            PetInfo val_13 = this.丕世万业丁不丅丌丗().丙丕丞且丕不丘丙丑();
            val_47 = val_13.Id;
            七下下业三丞专丈丛 val_15 = 0.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  val_47, 丞世不丒下上上丝丑: out  0);
            val_49 = val_15.专丕与丒丗丁丘专丟;
            goto label_22;
            label_12:
            if(val_48 == true)
            {
                goto label_23;
            }
            
            label_13:
            val_49 = val_6.丝上世丒丗丞丐丘丕;
            label_22:
            this.丘丂三丟丝丑三丞上();
            if((System.String.op_Inequality(a:  this.丈专东丕丒丛丏丛丌(), b:  val_49)) == false)
            {
                goto label_24;
            }
            
            this.丑上七丈丘东丐丝丈(丙业与丙丗丝不丈东:  val_49);
            val_48 = 1152921519068977584;
            val_50 = 0;
            goto label_25;
            label_30:
            this.丌万丑与东丌丄丆丟.Item[0].GetComponent<UnityEngine.TextMesh>().text = this.丈专东丕丒丛丏丛丌();
            val_50 = 1;
            label_25:
            val_47 = this.丌万丑与东丌丄丆丟;
            if(val_50 < val_47.Count)
            {
                goto label_30;
            }
            
            label_24:
            if((this.丕世万业丁不丅丌丗().丐丂丌丗丆丛东丘丁() == false) || (this.丕世万业丁不丅丌丗().下七丏不丒丗业丛专().activeInHierarchy == false))
            {
                goto label_35;
            }
            
            bool val_28 = this.丕世万业丁不丅丌丗().丐丂丌丗丆丛东丘丁();
            Rilisoft.PetEngine val_29 = this.丕世万业丁不丅丌丗();
            UnityEngine.Vector3 val_31 = val_29._lookPoint.transform.position;
            UnityEngine.Vector3 val_32 = this.LookToCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            if(val_32.x <= 0f)
            {
                goto label_41;
            }
            
            int val_33 = UnityEngine.Screen.width;
            val_51 = 0;
            if((val_32.y <= 0f) || (val_32.x >= 0))
            {
                goto label_44;
            }
            
            int val_34 = UnityEngine.Screen.height;
            var val_35 = (val_32.y < 0) ? 1 : 0;
            goto label_44;
            label_35:
            label_68:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.LabelObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.IconObject, 丏业丟一东丂东丘丛:  false);
            label_56:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.DirectionObj, 丏业丟一东丂东丘丛:  false);
            return;
            label_41:
            val_51 = 0;
            label_44:
            val_52 = null;
            val_52 = null;
            if(Rilisoft.PetIndicationController.丛世丁世丗世业且丈 == false)
            {
                    return;
            }
            
            if((this.丕世万业丁不丅丌丗().Enabled == false) || (this.丕世万业丁不丅丌丗().丘丒丝七丁下丂与丁() == false))
            {
                goto label_53;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.LabelObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.IconObject, 丏业丟一东丂东丘丛:  false);
            var val_40 = (val_51 == 0) ? 1 : 0;
            goto label_56;
            label_53:
            if(this.丕世万业丁不丅丌丗().Enabled != true)
            {
                    if(this.丕世万业丁不丅丌丗().丘丒丝七丁下丂与丁() == false)
            {
                goto label_68;
            }
            
            }
            
            if(this.丕世万业丁不丅丌丗().Enabled == true)
            {
                    return;
            }
            
            goto label_68;
        }
        private void 丘丂三丟丝丑三丞上()
        {
            var val_51;
            var val_52;
            UnityEngine.TextMesh val_53;
            var val_54;
            UnityEngine.Color val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            WeaponManager val_60;
            var val_61;
            UnityEngine.Color val_62;
            var val_63;
            var val_64;
            var val_65;
            if(this.丕世万业丁不丅丌丗() == 0)
            {
                    return;
            }
            
            if(this.丕世万业丁不丅丌丗().万东丂七东丁与业东() == 0)
            {
                    return;
            }
            
            this.丑丘世一丄丏丈且丙();
            val_51 = null;
            val_51 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                goto label_102;
            }
            
            if((((GameConnect.丑丌丛丈丅丅与不业() != 5) && (GameConnect.丑丌丛丈丅丅与不业() != 33)) && (GameConnect.丑丌丛丈丅丅与不业() != 36)) && (GameConnect.丑丌丛丈丅丅与不业() != 2))
            {
                    if(GameConnect.丑丌丛丈丅丅与不业() != 4)
            {
                    if(GameConnect.丑丌丛丈丅丅与不业() != 19)
            {
                goto label_28;
            }
            
            }
            
            }
            
            val_52 = null;
            val_52 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
            {
                goto label_34;
            }
            
            label_57:
            this.TextMesh.color = new UnityEngine.Color() {r = this.丄万丕且丏丅丕万丞, g = V9.16B, b = V10.16B, a = V11.16B};
            label_124:
            if(GameConnect.业丛丛丂一丆丕丗丟() != true)
            {
                    if(GameConnect.一与东丝万上三丆丏() == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  10000f);
            this.TextMesh.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            return;
            label_34:
            if(this.丕世万业丁不丅丌丗().万东丂七东丁与业东() != NetworkStartTable.__il2cppRuntimeField_implementedInterfaces)
            {
                goto label_50;
            }
            
            label_102:
            label_118:
            if(this.TextMesh != null)
            {
                goto label_125;
            }
            
            label_126:
            label_125:
            label_120:
            this.TextMesh.color = new UnityEngine.Color() {r = this.丟上丈丏丂上丈丏七, g = V9.16B, b = V10.16B, a = V11.16B};
            return;
            label_50:
            if((WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0) || (this.丕世万业丁不丅丌丗().万东丂七东丁与业东().丘丑丅三丆丑丌且丝() != 丘丑丅三丆丑丌且丝()))
            {
                goto label_57;
            }
            
            if(this.TextMesh != null)
            {
                goto label_125;
            }
            
            goto label_126;
            label_28:
            if(((GameConnect.东且三丆丑世世丘丟() != true) && (GameConnect.丑丌丛丈丅丅与不业() != 1)) && (GameConnect.且丞丁东丝丗上丈业() != true))
            {
                    if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_74;
            }
            
            }
            
            }
            
            val_53 = this.TextMesh;
            val_54 = null;
            val_54 = null;
            if(this.丕世万业丁不丅丌丗().万东丂七东丁与业东() != WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
            {
                goto label_81;
            }
            
            val_55 = this.丟上丈丏丂上丈丏七;
            val_56 = 1152921543373530028;
            val_57 = 1152921543373530032;
            val_58 = 1152921543373530036;
            goto label_92;
            label_74:
            if(GameConnect.东丒七专丂世丝丏丗() == false)
            {
                goto label_85;
            }
            
            val_59 = null;
            val_59 = null;
            val_60 = WeaponManager.丟丗丄业丘丗业丗七;
            if(WeaponManager.丟丗丄业丘丗业丗七 != null)
            {
                goto label_88;
            }
            
            val_60 = WeaponManager.丟丗丄业丘丗业丗七;
            if(val_60 == null)
            {
                goto label_89;
            }
            
            label_88:
            if(丄丝丝下丟丘丄丒丈() == false)
            {
                goto label_91;
            }
            
            val_53 = this.TextMesh;
            val_55 = this.丄万丕且丏丅丕万丞;
            val_56 = 1152921543373530012;
            val_57 = 1152921543373530016;
            val_58 = 1152921543373530020;
            goto label_92;
            label_85:
            if(GameConnect.丄丏丒丏上东业丒一() == false)
            {
                goto label_95;
            }
            
            val_61 = null;
            val_61 = null;
            if(this.丕世万业丁不丅丌丗().万东丂七东丁与业东() == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
            {
                goto label_102;
            }
            
            if((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) || ((typeof(Player_move_c).__il2cppRuntimeField_600.IsEnemyTo(专丞上七七且丝七丗:  this.丕世万业丁不丅丌丗().万东丂七东丁与业东())) == false))
            {
                goto label_109;
            }
            
            if(this.TextMesh != null)
            {
                goto label_125;
            }
            
            goto label_126;
            label_95:
            if(this.丕世万业丁不丅丌丗().丘丒丝七丁下丂与丁() == false)
            {
                goto label_113;
            }
            
            val_62 = this.丟上丈丏丂上丈丏七;
            val_63 = 1152921543373530028;
            val_64 = 1152921543373530032;
            val_65 = 1152921543373530036;
            goto label_114;
            label_91:
            val_53 = this.TextMesh;
            if(this.丕世万业丁不丅丌丗().万东丂七东丁与业东() == WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)
            {
                goto label_118;
            }
            
            label_81:
            val_55 = this.下丘丘下丌丗丟丗丗;
            val_56 = 1152921543373529996;
            val_57 = 1152921543373530000;
            val_58 = 1152921543373530004;
            label_92:
            if(val_53 != null)
            {
                goto label_120;
            }
            
            goto label_120;
            label_113:
            val_62 = this.丄万丕且丏丅丕万丞;
            val_63 = 1152921543373530012;
            val_64 = 1152921543373530016;
            val_65 = 1152921543373530020;
            label_114:
            this.TextMesh.color = new UnityEngine.Color() {r = this.丄万丕且丏丅丕万丞.r, g = 1.517474E-07f, b = 1.517474E-07f, a = 1.517474E-07f};
            if(this.丕世万业丁不丅丌丗().丘丒丝七丁下丂与丁() == true)
            {
                    return;
            }
            
            goto label_124;
            label_109:
            if(this.TextMesh != null)
            {
                goto label_125;
            }
            
            goto label_126;
            label_89:
        }
        private void 丑丘世一丄丏丈且丙()
        {
            UnityEngine.Material val_3 = this.丂丞丑丏丛丙世七丝.sharedMaterial;
            if(this.丕世万业丁不丅丌丗().丘丒丝七丁下丂与丁() == false)
            {
                goto label_3;
            }
            
            if(val_3 == this.MaterialMy)
            {
                    return;
            }
            
            if(this.丂丞丑丏丛丙世七丝 != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            this.丂丞丑丏丛丙世七丝.sharedMaterial = this.MaterialMy;
            return;
            label_3:
            if(val_3 == this.MaterialOur)
            {
                    return;
            }
            
            if(this.丂丞丑丏丛丙世七丝 != null)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        private void OnEnable()
        {
            var val_3 = null;
            this.LabelObj.gameObject.SetActive(value:  (Rilisoft.PetIndicationController.丛世丁世丗世业且丈 == true) ? 1 : 0);
        }
        internal static void 丛七万丟三丙三丕丈(bool 丙业与丙丗丝不丈东)
        {
            bool val_6;
            var val_7;
            var val_8;
            val_6 = 丙业与丙丗丝不丈东;
            val_7 = null;
            val_7 = null;
            Rilisoft.PetIndicationController.丛世丁世丗世业且丈 = val_6;
            val_8 = null;
            val_8 = null;
            List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一.GetEnumerator();
            label_13:
            if((112555176 & 1) == 0)
            {
                goto label_6;
            }
            
            Rilisoft.PetIndicationController val_4 = 0.丐丏七丌丕丗业且上().GetComponent<Rilisoft.PetIndicationController>();
            val_4.LabelObj.SetActive(value:  val_6);
            if(val_6 == true)
            {
                goto label_13;
            }
            
            val_4.IconObject.SetActive(value:  false);
            val_4.DirectionObj.SetActive(value:  false);
            goto label_13;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal static bool 丛丟丟丌不丕丟丁丏()
        {
            null = null;
            return (bool)Rilisoft.PetIndicationController.丛世丁世丗世业且丈;
        }
        public PetIndicationController()
        {
            this.下丘丘下丌丗丟丗丗 = 0;
            mem[1152921543374372684] = 0;
            mem[1152921543374372692] = 0;
            this.丄万丕且丏丅丕万丞 = 0;
            mem[1152921543374372700] = 0;
            mem[1152921543374372708] = 0;
            this.丟上丈丏丂上丈丏七 = 0;
            mem[1152921543374372716] = 0;
            mem[1152921543374372724] = 0;
            this.一丙丟丒丒与上丐丆 = 0;
            mem[1152921543374372732] = 0;
            mem[1152921543374372740] = 0;
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[8];
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[2] = 0;
            val_1[2] = 0;
            val_1[3] = 0;
            val_1[3] = 0;
            val_1[4] = 0;
            val_1[4] = 0;
            val_1[5] = 0;
            val_1[5] = 0;
            val_1[6] = 0;
            val_1[6] = 0;
            val_1[7] = 0;
            val_1[7] = 0;
            val_1[8] = 0;
            val_1[8] = 0;
            val_1[9] = 0;
            val_1[9] = 0;
            val_1[10] = 0;
            val_1[10] = 0;
            val_1[11] = 0;
            val_1[11] = 0;
            this.丛丞专下丄丐丝丟世 = val_1;
            this.丌万丑与东丌丄丆丟 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
        private static PetIndicationController()
        {
            Rilisoft.PetIndicationController.丛世丁世丗世业且丈 = true;
        }
    
    }

}
