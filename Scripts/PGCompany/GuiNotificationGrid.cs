using UnityEngine;

namespace PGCompany
{
    internal sealed class GuiNotificationGrid : PGBehaviour
    {
        // Fields
        private UIGrid _uiGrid;
        private PGCompany.GuiNotification[] 丄丂下丏下丁丘丌丐;
        
        // Methods
        private void Awake()
        {
            this.丄丂下丏下丁丘丌丐 = this.GetComponents<PGCompany.GuiNotification>();
        }
        private void OnEnable()
        {
            this.下丌业业丐丘丐丘三();
            this.丝一丅丆三东丂丞七();
        }
        private void OnDisable()
        {
            this.不与丞下业丑丒丙万();
        }
        private void OnDestroy()
        {
            this.不与丞下业丑丒丙万();
        }
        private void 丝一丅丆三东丂丞七()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(UIGrid).__il2cppRuntimeField_1A8;
        }
        private void 下丌业业丐丘丐丘三()
        {
            goto label_1;
            label_6:
            this.丄丂下丏下丁丘丌丐[0].七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GuiNotificationGrid::丝一丅丆三东丂丞七()));
            0 = 1;
            label_1:
            if(0 < this.丄丂下丏下丁丘丌丐.Length)
            {
                goto label_6;
            }
        
        }
        private void 不与丞下业丑丒丙万()
        {
            goto label_1;
            label_6:
            this.丄丂下丏下丁丘丌丐[0].与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GuiNotificationGrid::丝一丅丆三东丂丞七()));
            0 = 1;
            label_1:
            if(0 < this.丄丂下丏下丁丘丌丐.Length)
            {
                goto label_6;
            }
        
        }
        public GuiNotificationGrid()
        {
        
        }
    
    }

}
