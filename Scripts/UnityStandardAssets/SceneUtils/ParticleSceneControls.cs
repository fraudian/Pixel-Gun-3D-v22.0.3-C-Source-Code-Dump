using UnityEngine;

namespace UnityStandardAssets.SceneUtils
{
    public class ParticleSceneControls : MonoBehaviour
    {
        // Fields
        public UnityStandardAssets.SceneUtils.ParticleSceneControls.DemoParticleSystemList demoParticles;
        public float spawnOffset;
        public float multiply;
        public bool clearOnChange;
        public UnityEngine.UI.Text titleText;
        public UnityEngine.Transform sceneCamera;
        public UnityEngine.UI.Text instructionText;
        public UnityEngine.UI.Button previousButton;
        public UnityEngine.UI.Button nextButton;
        public UnityEngine.UI.GraphicRaycaster graphicRaycaster;
        public UnityEngine.EventSystems.EventSystem eventSystem;
        private UnityStandardAssets.Effects.ParticleSystemMultiplier 东丑世丗业丌一丝丕;
        private System.Collections.Generic.List<UnityEngine.Transform> 丆丆东三丂丒上下七;
        private UnityEngine.Transform 不丒丛不不丅与丞七;
        private static int 丙丂丁丝东丑上丕丞;
        private UnityEngine.Vector3 丞丈上丆丟丘不一三;
        private UnityEngine.Vector3 丒丞业丘丂七丙业不;
        private static UnityStandardAssets.SceneUtils.ParticleSceneControls.DemoParticleSystem 丏丏丞世丒丞万丝业;
        
        // Methods
        private void Awake()
        {
            null = null;
            this.丂三丛下丐丆丒三丗(七丞丙丒三丕且丌丟:  UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞);
            this.previousButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityStandardAssets.SceneUtils.ParticleSceneControls::且一不丙丌与丁上丑()));
            this.nextButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void UnityStandardAssets.SceneUtils.ParticleSceneControls::Next()));
        }
        private void OnDisable()
        {
            this.previousButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityStandardAssets.SceneUtils.ParticleSceneControls::且一不丙丌与丁上丑()));
            this.nextButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void UnityStandardAssets.SceneUtils.ParticleSceneControls::Next()));
        }
        private void 且一不丙丌与丁上丑()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            int val_1 = UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞;
            val_1 = val_1 - 1;
            UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞 = val_1;
            val_2 = null;
            if(UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞 == 1)
            {
                    val_3 = null;
                val_3 = null;
                int val_2 = this.demoParticles.items.Length;
                val_2 = val_2 - 1;
                UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞 = val_2;
                val_2 = null;
            }
            
            val_2 = null;
            this.丂三丛下丐丆丒三丗(七丞丙丒三丕且丌丟:  UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞);
        }
        public void Next()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            int val_1 = UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞;
            val_1 = val_1 + 1;
            UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞 = val_1;
            if(UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞 == this.demoParticles.items.Length)
            {
                    val_2 = null;
                val_2 = null;
                UnityStandardAssets.SceneUtils.ParticleSceneControls.丙丂丁丝东丑上丕丞 = 0;
            }
            
            val_3 = null;
            val_3 = null;
            this.丂三丛下丐丆丒三丗(七丞丙丒三丕且丌丟:  0);
        }
        private void Update()
        {
            float val_13;
            float val_14;
            var val_33;
            float val_34;
            var val_35;
            float val_36;
            float val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_46;
            float val_47;
            var val_48;
            var val_49;
            var val_50;
            float val_51;
            var val_52;
            var val_53;
            var val_54;
            UnityEngine.Transform val_55;
            UnityEngine.Vector3 val_1 = this.sceneCamera.localPosition;
            val_33 = 1152921504838316032;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
            val_34 = val_2.y;
            val_35 = null;
            val_35 = null;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_34, z = val_2.z}, d:  (float)-UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.camOffset);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, target:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, currentVelocity: ref  new UnityEngine.Vector3() {x = this.丞丈上丆丟丘不一三, y = this.丞丈上丆丟丘不一三, z = this.丞丈上丆丟丘不一三}, smoothTime:  1f);
            val_36 = val_4.x;
            val_37 = val_4.z;
            this.sceneCamera.localPosition = new UnityEngine.Vector3() {x = val_36, y = val_4.y, z = val_37};
            if( == 0)
            {
                    return;
            }
            
            if(this.且业丞丁丛丈丞丏专() == true)
            {
                    return;
            }
            
            val_38 = 0;
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
            {
                    val_39 = null;
                val_39 = null;
            }
            
            val_40 = 0;
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    val_41 = null;
                val_41 = null;
                var val_9 = (UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.mode == 2) ? 1 : 0;
            }
            
            val_9 = val_9 | ((UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.mode == 1) ? 1 : 0);
            if(val_9 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Input.mousePosition;
            val_36 = val_11.x;
            val_37 = val_11.z;
            UnityEngine.Ray val_12 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_36, y = val_11.y, z = val_37});
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_14, y = val_14, z = val_14}, m_Direction = new UnityEngine.Vector3() {x = val_14, y = val_13, z = val_13}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}})) == false)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_37});
            val_46 = null;
            val_47 = val_16.w;
            val_46 = null;
            if(UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.align == 1)
            {
                    UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.identity;
                val_47 = val_17.w;
            }
            
            val_34 = this.spawnOffset;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  val_34);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_36 = val_19.x;
            val_37 = val_19.z;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = this.丒丞业丘丂七丙业不, y = val_18.y, z = val_18.z});
            val_48 = null;
            val_48 = null;
            if(val_20.x <= UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.minDist)
            {
                    return;
            }
            
            val_49 = null;
            val_49 = null;
            if(UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.mode == 2)
            {
                    if(this.不丒丛不不丅与丞七 != 0)
            {
                goto label_43;
            }
            
            }
            
            val_50 = null;
            val_50 = null;
            this.不丒丛不不丅与丞七 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.transform, position:  new UnityEngine.Vector3() {x = val_36, y = val_19.y, z = val_37}, rotation:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_47});
            if(this.东丑世丗业丌一丝丕 != 0)
            {
                    UnityStandardAssets.Effects.ParticleSystemMultiplier val_24 = this.不丒丛不不丅与丞七.GetComponent<UnityStandardAssets.Effects.ParticleSystemMultiplier>();
                val_51 = this.multiply;
                val_24.multiplier = val_51;
            }
            
            this.丆丆东三丂丒上下七.Add(item:  this.不丒丛不不丅与丞七);
            val_52 = null;
            val_52 = null;
            if(UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.maxCount < 1)
            {
                goto label_71;
            }
            
            val_53 = null;
            val_53 = null;
            if(this.丆丆东三丂丒上下七.Count <= UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.maxCount)
            {
                goto label_71;
            }
            
            if(this.丆丆东三丂丒上下七.Item[0] != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.丆丆东三丂丒上下七.Item[0].gameObject);
            }
            
            this.丆丆东三丂丒上下七.RemoveAt(index:  0);
            goto label_71;
            label_43:
            this.不丒丛不不丅与丞七.position = new UnityEngine.Vector3() {x = val_36, y = val_19.y, z = val_37};
            this.不丒丛不不丅与丞七.rotation = new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_47};
            label_71:
            val_54 = null;
            val_54 = null;
            if(UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业.mode == 2)
            {
                    UnityEngine.ParticleSystem val_31 = this.不丒丛不不丅与丞七.transform.GetComponent<UnityEngine.ParticleSystem>();
                if(val_31 != null)
            {
                    val_31.enableEmission = false;
            }
            else
            {
                    val_31.enableEmission = false;
            }
            
                val_31.Emit(count:  1);
            }
            
            val_55;
            this.不丒丛不不丅与丞七.parent = 0;
            this.丒丞业丘丂七丙业不 = val_19;
            mem[1152921541416944304] = val_19.y;
            mem[1152921541416944308] = val_37;
        }
        private bool 且业丞丁丛丈丞丏专()
        {
            UnityEngine.EventSystems.PointerEventData val_1 = new UnityEngine.EventSystems.PointerEventData(eventSystem:  this.eventSystem);
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_1.pressPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_1.position = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            return (bool)((new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>().Count) > 0) ? 1 : 0;
        }
        private void 丂三丛下丐丆丒三丗(int 七丞丙丒三丕且丌丟)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_8 = null;
            val_8 = null;
            UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业 = this.demoParticles.items[(long)七丞丙丒三丕且丌丟];
            this.不丒丛不不丅与丞七 = 0;
            val_9 = 0;
            goto label_7;
            label_17:
            val_10 = null;
            val_10 = null;
            if((this.demoParticles.items[0] != UnityStandardAssets.SceneUtils.ParticleSceneControls.丏丏丞世丒丞万丝业) && (this.demoParticles.items[0x0][0].mode == 0))
            {
                    this.demoParticles.items[0x0][0].transform.gameObject.SetActive(value:  false);
            }
            
            val_9 = 1;
            label_7:
            if(val_9 < this.demoParticles.items.Length)
            {
                goto label_17;
            }
            
            val_11 = null;
            val_11 = null;
            if(this.demoParticles.items[(long)(int)(七丞丙丒三丕且丌丟)][0].mode == 0)
            {
                    val_12 = null;
                val_12 = null;
                this.demoParticles.items[(long)(int)(七丞丙丒三丕且丌丟)][0].transform.gameObject.SetActive(value:  true);
            }
            
            val_13 = null;
            val_13 = null;
            this.东丑世丗业丌一丝丕 = this.demoParticles.items[(long)(int)(七丞丙丒三丕且丌丟)][0].transform.GetComponent<UnityStandardAssets.Effects.ParticleSystemMultiplier>();
            this.multiply = 1f;
            if(this.clearOnChange == false)
            {
                goto label_31;
            }
            
            val_9 = 1152921519067103504;
            goto label_32;
            label_39:
            UnityEngine.Object.Destroy(obj:  this.丆丆东三丂丒上下七.Item[0].gameObject);
            this.丆丆东三丂丒上下七.RemoveAt(index:  0);
            label_32:
            if(this.丆丆东三丂丒上下七.Count > 0)
            {
                goto label_39;
            }
            
            label_31:
            val_14 = null;
            val_14 = null;
            string val_7 = this.demoParticles.items[(long)(int)(七丞丙丒三丕且丌丟)][0].transform.name;
            if(this.titleText == null)
            {
                
            }
        
        }
        public ParticleSceneControls()
        {
            this.spawnOffset = 1f;
            this.multiply = 1f;
            this.丆丆东三丂丒上下七 = new System.Collections.Generic.List<UnityEngine.Transform>();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.丞丈上丆丟丘不一三 = val_2;
            mem[1152921541417700100] = val_2.y;
            mem[1152921541417700104] = val_2.z;
        }
        private static ParticleSceneControls()
        {
        
        }
    
    }

}
