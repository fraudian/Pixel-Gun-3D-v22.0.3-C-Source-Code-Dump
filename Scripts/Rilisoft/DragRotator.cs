using UnityEngine;

namespace Rilisoft
{
    public class DragRotator : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 baseRotation;
        public bool isEnableRotate;
        private bool 丞丈丌且东丆丅丗万;
        private bool 丙三丆业且东丄丆万;
        private float 丗丁业丕丒丌七业丟;
        public UnityEngine.Transform rotationTranform;
        public bool UseCharacterInterface;
        public bool UseGlobalCoordinates;
        private float 上专丘丛世且丐下业;
        
        // Methods
        private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
        {
            if(this.丙三丆业且东丄丆万 != false)
            {
                    this.丙三丆业且东丄丆万 = false;
                return;
            }
            
            this.上专丘丛世且丐下业 = 0f;
            this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        }
        private void OnClick()
        {
            this.上专丘丛世且丐下业 = 0f;
        }
        private void OnPress(bool 丆且上丘世下丅且丞)
        {
            this.丙三丆业且东丄丆万 = true;
        }
        public void DragRotate(UnityEngine.Vector2 丞且丅三三东不丄且)
        {
            if(this.丙三丆业且东丄丆万 != false)
            {
                    this.丙三丆业且东丄丆万 = false;
                return;
            }
            
            this.上专丘丛世且丐下业 = 0f;
            this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        }
        private void 丗丗业丆三丐丈丕万(UnityEngine.Vector2 丞且丅三三东不丄且)
        {
            UnityEngine.Object val_7;
            UnityEngine.Transform val_8;
            if(this.rotationTranform == 0)
            {
                    return;
            }
            
            if(this.UseCharacterInterface == false)
            {
                goto label_4;
            }
            
            val_7 = this.rotationTranform.GetComponent<CharacterInterfaceV2>();
            if(val_7 == 0)
            {
                    val_7 = this.rotationTranform.GetComponentInChildren<CharacterInterfaceV2>();
            }
            
            if(val_7 != 0)
            {
                goto label_12;
            }
            
            return;
            label_4:
            val_8 = this.rotationTranform;
            goto label_13;
            label_12:
            val_8 = val_7.transform;
            label_13:
            this.丗丗业丆三丐丈丕万(丄上七丟不丗丕下丟:  val_8, 丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        }
        private void 丗丗业丆三丐丈丕万(UnityEngine.Transform 丄上七丟不丗丕下丟, UnityEngine.Vector2 丞且丅三三东不丄且)
        {
            float val_5;
            float val_6;
            if(丄上七丟不丗丕下丟 == null)
            {
                goto label_1;
            }
            
            if(this.UseGlobalCoordinates == false)
            {
                goto label_2;
            }
            
            label_7:
            UnityEngine.Quaternion val_1 = 丄上七丟不丗丕下丟.rotation;
            val_1.y = val_1.y - 丞且丅三三东不丄且.x;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_5 = val_2.x;
            val_6 = val_2.z;
            丄上七丟不丗丕下丟.rotation = new UnityEngine.Quaternion() {x = val_5, y = val_2.y, z = val_6, w = val_2.w};
            return;
            label_1:
            if(this.UseGlobalCoordinates == true)
            {
                goto label_7;
            }
            
            label_2:
            UnityEngine.Quaternion val_3 = 丄上七丟不丗丕下丟.localRotation;
            val_3.y = val_3.y - 丞且丅三三东不丄且.x;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_5 = val_4.x;
            val_6 = val_4.z;
            丄上七丟不丗丕下丟.localRotation = new UnityEngine.Quaternion() {x = val_5, y = val_4.y, z = val_6, w = val_4.w};
        }
        private void Update()
        {
            float val_6;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_6 = this.上专丘丛世且丐下业;
            this.丗丁业丕丒丌七业丟 = UnityEngine.Time.realtimeSinceStartup;
            if(val_6 < 0)
            {
                    val_6 = val_6 + UnityEngine.Time.unscaledDeltaTime;
                this.上专丘丛世且丐下业 = val_6;
            }
            
            if(this.isEnableRotate == false)
            {
                    return;
            }
            
            if(val_6 < 2f)
            {
                    return;
            }
            
            float val_4 = UnityEngine.Time.unscaledDeltaTime;
            val_4 = val_4 * 30f;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  0f);
            this.丗丗业丆三丐丈丕万(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        }
        public DragRotator()
        {
            this.isEnableRotate = true;
            this.丙三丆业且东丄丆万 = true;
            this.上专丘丛世且丐下业 = 1000f;
        }
    
    }

}
