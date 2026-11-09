using UnityEngine;

namespace Rilisoft
{
    internal class FortItemSlotClickHandler : MonoBehaviour
    {
        // Fields
        private 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 itemSlot;
        
        // Methods
        private void OnEnable()
        {
            this.世丅东且三丞丙上丞();
        }
        private void 世丅东且三丞丙上丞()
        {
            var val_24;
            var val_25;
            System.Func<UnityEngine.Collider, System.Boolean> val_27;
            var val_29;
            var val_30;
            var val_33;
            var val_34;
            val_24 = 1152921505447686144;
            val_25 = null;
            val_25 = null;
            val_27 = FortItemSlotClickHandler.<>c.<>9__2_0;
            if(val_27 == null)
            {
                    System.Func<UnityEngine.Collider, System.Boolean> val_2 = null;
                val_27 = val_2;
                val_2 = new System.Func<UnityEngine.Collider, System.Boolean>(object:  FortItemSlotClickHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortItemSlotClickHandler.<>c::丛世万丛丂丗三丕不(UnityEngine.Collider 丁丂专业丁丅丅丈丙));
                FortItemSlotClickHandler.<>c.<>9__2_0 = val_27;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<UnityEngine.Collider>(source:  this.GetComponentsInChildren<UnityEngine.Collider>(), predicate:  val_2).GetEnumerator();
            val_29 = 1152921504691191808;
            val_30 = 1152921542631504912;
            label_28:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_5.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            Rilisoft.ButtonEventsHandler val_11 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<Rilisoft.ButtonEventsHandler>(丝三丁东丈丒世丅业:  val_5.Current.gameObject);
            new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.FortItemSlotClickHandler::OnClick());
            val_11.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction());
            new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.FortItemSlotClickHandler::OnClick());
            val_11.OnClickEvent.AddListener(call:  new UnityEngine.Events.UnityAction());
            goto label_28;
            label_16:
            val_33 = 0;
            val_34 = 0;
            if(val_5 == null)
            {
                
            }
            else
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_5.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_34 = ???;
            val_33 = ???;
            val_24 = ???;
            val_29 = ???;
            val_30 = ???;
        }
        private void OnClick()
        {
            var val_8;
            var val_9;
            Rilisoft.FortCraftController val_10;
            var val_11;
            var val_12;
            Rilisoft.FortCraftController val_13;
            var val_15;
            丗丞丏丙七丑丕且丐 val_16;
            Rilisoft.东且东丒丐世丐丞丒 val_17;
            val_8 = 1152921504848912384;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    Rilisoft.FortsManager val_3 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
                if(val_3.丄且专与丌专丁丒丒 == true)
            {
                    return;
            }
            
            }
            
            Rilisoft.丕丂丒丁丏东且一七 val_5 = this.gameObject.GetComponentInChildren<Rilisoft.丕丂丒丁丏东且一七>();
            val_9 = null;
            val_9 = null;
            val_10 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            if(val_10 == 0)
            {
                    return;
            }
            
            val_11 = null;
            if(val_5 == null)
            {
                goto label_12;
            }
            
            val_12 = null;
            val_13 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            var val_9 = 0;
            val_9 = val_9 + 1;
            goto label_18;
            label_12:
            val_15 = null;
            val_16 = this.itemSlot;
            val_17 = 0;
            goto label_22;
            label_18:
            val_16 = this.itemSlot;
            val_17 = val_5.FortItem;
            label_22:
            val_13.SelectItemOnSceneRequest(丂三七下丗且丌上一:  val_17, 与丄不丌一世东丁丙:  val_16);
        }
        public FortItemSlotClickHandler()
        {
        
        }
    
    }

}
