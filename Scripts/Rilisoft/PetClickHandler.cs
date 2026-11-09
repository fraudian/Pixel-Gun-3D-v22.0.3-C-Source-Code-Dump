using UnityEngine;

namespace Rilisoft
{
    public class PetClickHandler : MonoBehaviour
    {
        // Fields
        internal const string 丅丐丟丘丄业七万万 = "Tap";
        private UnityEngine.Camera 丘业下丄丞万丞丝丅;
        private System.Nullable<UnityEngine.Vector3> 丈一东东丈丐专三丛;
        private Rilisoft.PetEngine 丙丒丐丄丒丛下丘丁;
        private bool 丐丌丒丟丐丂万世世;
        private float _threshold;
        
        // Properties
        private static bool 丛丂丘丏丐丕专一业 { get; }
        
        // Methods
        private static bool 三丏丛丛丁丏丗三丁()
        {
            PGCompany.NewsLobbyController val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            if(PauseGUIController.丑七不且上丗丁一世() != 0)
            {
                    val_48 = PauseGUIController.丑七不且上丗丁一世();
                if(val_48.IsPaused == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_49 = 1152921505210572800;
            if(BankController.丑七不且上丗丁一世() != 0)
            {
                    BankController val_7 = BankController.丑七不且上丗丁一世();
                if(val_7.uiRoot != 0)
            {
                    BankController val_9 = BankController.丑七不且上丗丁一世();
                val_48 = val_9.uiRoot.gameObject;
                if(val_48.activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            }
            
            val_49 = 1152921505566695424;
            val_50 = null;
            val_50 = null;
            val_48 = PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟;
            if(val_48 != 0)
            {
                    val_51 = null;
                val_51 = null;
                val_48 = PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟;
                if(val_48.isActiveAndEnabled == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(LeaderboardsGui.丑丙丗世丏丞万世丒() != true)
            {
                    if(LeaderboardsClans.丑丙丗世丏丞万世丒() == false)
            {
                goto label_35;
            }
            
            }
            
            return (bool)0 & 1;
            label_35:
            val_52 = null;
            val_52 = null;
            if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_53 = null;
                val_53 = null;
                if(activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(Rilisoft.Nest.丑七不且上丗丁一世() != 0)
            {
                    if(Rilisoft.Nest.丑七不且上丗丁一世().BannerIsVisible == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_54 = null;
            val_54 = null;
            if(FriendsController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_55 = null;
                val_55 = null;
                if(FriendsController.丄丞丁丈与业上丞丟.ProfileInterfaceActive == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
            {
                    if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(FreeAwardController.丑七不且上丗丁一世() != 0)
            {
                    if((FreeAwardController.丑七不且上丗丁一世().IsInState<下丝丒东丟丂一七世>()) == false)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_56 = null;
            val_56 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_57 = null;
                val_57 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.一丑丟世丛丌丁下不() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
            {
                    return (bool)0 & 1;
            }
            
            val_58 = null;
            val_58 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_59 = null;
                val_59 = null;
                if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(ConnectScene.丈丘丂丙不丛业丟三() != false)
            {
                    if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_60 = null;
            val_60 = null;
            if(PGCompany.ModuleInsertPanel.东丅丞丁丗万且丁丗 == true)
            {
                    return (bool)0 & 1;
            }
            
            val_61 = null;
            val_61 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                goto label_115;
            }
            
            label_133:
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    if(Rilisoft.PetClickHandler.丟丌三丕丗业业专上() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            bool val_46 = ClanWarUI.丈丐丞丐上丑且丕万() ^ 1;
            return (bool)0 & 1;
            label_115:
            val_62 = null;
            val_62 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 + 40.activeInHierarchy) == true)
            {
                    return (bool)0 & 1;
            }
            
            val_63 = null;
            val_63 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) == true)
            {
                    return (bool)0 & 1;
            }
            
            goto label_133;
        }
        private static bool 丟丌三丕丗业业专上()
        {
            var val_10;
            UnityEngine.Object val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = null;
            val_10 = null;
            val_11 = 0;
            if(1152921505096626272 != 0)
            {
                    val_12 = null;
                val_12 = null;
                val_11 = gameObject;
            }
            
            if(val_11 != 0)
            {
                    val_13 = System.String.op_Equality(a:  val_11.name, b:  "BtnHide");
            }
            else
            {
                    val_13 = 0;
            }
            
            val_14 = null;
            val_14 = null;
            int val_9 = UICamera.lastHitFrame;
            val_9 = UnityEngine.Time.frameCount - val_9;
            return (bool)val_13 & ((val_9 < 2) ? 1 : 0);
        }
        private void OnDisable()
        {
            this.丈一东东丈丐专三丛 = 0;
            mem[1152921543366010248] = 0;
            this.丐丌丒丟丐丂万世世 = false;
            if(this.丙丒丐丄丒丛下丘丁 == 0)
            {
                    return;
            }
            
            if((this.丙丒丐丄丒丛下丘丁.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  4)) == null)
            {
                    return;
            }
            
            this.丙丒丐丄丒丛下丘丁.与丒万一世与万七专().CrossFade(animation:  val_2.AnimationName);
        }
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            Rilisoft.PetEngine val_2 = val_1.业丙丒与丕丕丄丟一(一上业丞丁一丆丞丘:  val_1);
            this.丙丒丐丄丒丛下丘丁 = val_2;
            if(val_2 != 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "PetEngine not found");
        }
        private void Update()
        {
            UnityEngine.Camera val_22;
            var val_23;
            var val_24;
            UnityEngine.Object val_25;
            if(this.丙丒丐丄丒丛下丘丁 == 0)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
                this.丈一东东丈丐专三丛 = 0;
                mem[1152921543366324472] = 0;
                this.丘业下丄丞万丞丝丅 = 0.下丕下七丐业丒丌丄();
                return;
            }
            
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                    return;
            }
            
            if((this.丈一东东丈丐专三丛 & 1) == 0)
            {
                    return;
            }
            
            val_22 = this.丘业下丄丞万丞丝丅;
            if(val_22 != this.丈一东东丈丐专三丛.下丕下七丐业丒丌丄())
            {
                    return;
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) > this._threshold)
            {
                    return;
            }
            
            if(Rilisoft.PetClickHandler.三丏丛丛丁丏丗三丁() == false)
            {
                    return;
            }
            
            val_23 = null;
            val_23 = null;
            val_22 = ShopNGUIController.丏丙丅丕一丑丕丑丑.丌上丏丁下丞丐丏万().丐丁丟丏丄东不丘丒();
            val_24 = 0;
            val_25 = 0;
            if(val_22 != 0)
            {
                    val_25 = val_22.GetComponent<Rilisoft.PetEngine>();
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_22 = this.丙丒丐丄丒丛下丘丁;
                val_24 = 0;
                if(val_22 != val_25)
            {
                    return;
            }
            
            }
            
            UnityEngine.GameObject val_17 = 0;
            if((this.丟世上世丂丒丙丁丘(丕丗东且丅丄丏丂丅: out  val_17)) == false)
            {
                    return;
            }
            
            val_22 = this.丙丒丐丄丒丛下丘丁.gameObject;
            if((val_17 & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  this.丅与丙不丂上丟丄丁());
        }
        private bool 丟世上世丂丒丙丁丘(out UnityEngine.GameObject 丕丗东且丅丄丏丂丅)
        {
            float val_13;
            float val_14;
            Rilisoft.PetEngine val_25;
            UnityEngine.Object val_26;
            var val_27;
            val_25 = this;
            丕丗东且丅丄丏丂丅 = 0;
            val_26 = this.下丕下七丐业丒丌丄();
            if(val_26 == 0)
            {
                goto label_21;
            }
            
            UnityEngine.Vector3 val_4 = val_26.transform.position;
            UnityEngine.Vector3 val_7 = this.gameObject.transform.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
            UnityEngine.Ray val_10 = val_26.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_26 = this.gameObject;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_13, y = val_13, z = val_13}, m_Direction = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_14}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}), layerMask:  1 << (val_26.layer & 31))) == false)
            {
                goto label_21;
            }
            
            val_26 = 0.gameObject;
            if((val_26.CompareTag(tag:  "Pet")) == false)
            {
                goto label_15;
            }
            
            val_25 = this.丙丒丐丄丒丛下丘丁;
            goto label_16;
            label_15:
            val_26 = 0.gameObject;
            if((丞东丑专丛丆丄丝世.丅丙世且丗丒且丁丒(丝三丁东丈丒世丅业:  val_26, 不丐丗丙东丌下丟业:  this.丙丒丐丄丒丛下丘丁.gameObject)) == false)
            {
                goto label_21;
            }
            
            label_16:
            丕丗东且丅丄丏丂丅 = null.gameObject;
            val_27 = 1;
            return (bool)val_27;
            label_21:
            val_27 = 0;
            return (bool)val_27;
        }
        private UnityEngine.Camera 下丕下七丐业丒丌丄()
        {
            var val_8;
            var val_9;
            var val_10;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_8 = null;
                val_8 = null;
                if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
            {
                    return ShopNGUIController.丏丙丅丕一丑丕丑丑.丌丒丒丙与东丈丟东();
            }
            
                return ShopNGUIController.丏丙丅丕一丑丕丑丑.丌丒丒丙与东丈丟东();
            }
            
            if(ProfileController.丑七不且上丗丁一世() != 0)
            {
                    if(ProfileController.丑七不且上丗丁一世().InterfaceEnabled != false)
            {
                    ProfileController val_6 = ProfileController.丑七不且上丗丁一世();
                if(val_6 != null)
            {
                    return val_6.Camera3D;
            }
            
                return val_6.Camera3D;
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return 0;
            }
            
            val_10 = null;
            val_10 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != null)
            {
                    return MainMenuController.丄丞丁丈与业上丞丟.丌丒丒丙与东丈丟东();
            }
            
            return MainMenuController.丄丞丁丈与业上丞丟.丌丒丒丙与东丈丟东();
        }
        private System.Collections.IEnumerator 丅与丙不丂上丟丄丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PetClickHandler.丄丑且丄下世专丞且();
        }
        private Rilisoft.PetEngine 业丙丒与丕丕丄丟一(UnityEngine.GameObject 一上业丞丁一丆丞丘)
        {
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            val_13 = 一上业丞丁一丆丞丘;
            val_14 = 0;
            if(val_13 == 0)
            {
                    return (Rilisoft.PetEngine)val_14;
            }
            
            val_14 = val_13.GetComponent<Rilisoft.PetEngine>();
            if(val_14 != 0)
            {
                    return (Rilisoft.PetEngine)val_14;
            }
            
            val_14 = 丞东丑专丛丆丄丝世.业三下与万丑丗业专<Rilisoft.PetEngine>(丝三丁东丈丒世丅业:  val_13);
            if(val_14 != 0)
            {
                    return (Rilisoft.PetEngine)val_14;
            }
            
            val_13 = System.Linq.Enumerable.LastOrDefault<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.东丕丟丏丐业丅东丐(丈丆上丅丘世专丑丕:  val_13));
            val_14 = 0;
            if(val_13 == 0)
            {
                    return (Rilisoft.PetEngine)val_14;
            }
            
            val_13 = System.Linq.Enumerable.ToArray<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_13));
            var val_14 = 0;
            label_22:
            if(val_14 >= val_10.Length)
            {
                goto label_17;
            }
            
            val_14 = val_13[0].GetComponent<Rilisoft.PetEngine>();
            val_14 = val_14 + 1;
            if(val_14 == 0)
            {
                goto label_22;
            }
            
            return (Rilisoft.PetEngine)val_14;
            label_17:
            val_14 = 0;
            return (Rilisoft.PetEngine)val_14;
        }
        private float 丒三世丙丘丟丒专一()
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Collections.IEnumerator val_2 = this.丙丒丐丄丒丛下丘丁.与丒万一世与万七专().GetEnumerator();
            label_18:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_15 = val_2.Current;
            if(val_15 != null)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            val_15 = 0;
            val_16 = 1;
            goto label_16;
            label_15:
            val_16 = 0;
            label_16:
            if((System.String.op_Equality(a:  val_15.clip.name, b:  "Tap")) == false)
            {
                goto label_18;
            }
            
            val_17 = 0;
            val_18 = 0;
            val_19 = val_15.clip.length * val_15.speed;
            goto label_23;
            label_8:
            val_17 = 0;
            val_18 = 0;
            val_19 = 0f;
            label_23:
            if(val_2 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_2.Dispose();
            }
            
            if( == 1)
            {
                goto label_40;
            }
            
            if(102 == 108)
            {
                    return (float)val_19;
            }
            
            val_19 = 0f;
            if( == false)
            {
                    return (float)val_19;
            }
            
            if(102 != 102)
            {
                goto label_43;
            }
            
            return (float)val_19;
            label_40:
            if( == false)
            {
                goto label_45;
            }
            
            label_43:
            label_45:
            val_19 = 0f;
            return (float)val_19;
        }
        public PetClickHandler()
        {
            this._threshold = 10f;
        }
    
    }

}
