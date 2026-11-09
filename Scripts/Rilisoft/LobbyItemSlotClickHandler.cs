using UnityEngine;

namespace Rilisoft
{
    internal class LobbyItemSlotClickHandler : MonoBehaviour
    {
        // Fields
        private static System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丏丝丏丕丄丏丅万丌;
        
        // Methods
        internal static void 与丝丞丂丄丅丐三丏(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Rilisoft.LobbyItemSlotClickHandler.丏丝丏丕丄丏丅万丌, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 万丟丟丈专丞丒与丗(System.Action<Rilisoft.丏丘七丞丄丙丌丞丁> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Rilisoft.LobbyItemSlotClickHandler.丏丝丏丕丄丏丅万丌, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
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
            val_24 = 1152921505470849024;
            val_25 = null;
            val_25 = null;
            val_27 = LobbyItemSlotClickHandler.<>c.<>9__4_0;
            if(val_27 == null)
            {
                    System.Func<UnityEngine.Collider, System.Boolean> val_2 = null;
                val_27 = val_2;
                val_2 = new System.Func<UnityEngine.Collider, System.Boolean>(object:  LobbyItemSlotClickHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LobbyItemSlotClickHandler.<>c::丄丂丞丄且丘一丁丆(UnityEngine.Collider 丁丂专业丁丅丅丈丙));
                LobbyItemSlotClickHandler.<>c.<>9__4_0 = val_27;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            System.Collections.Generic.IEnumerator<T> val_5 = System.Linq.Enumerable.Where<UnityEngine.Collider>(source:  this.GetComponentsInChildren<UnityEngine.Collider>(), predicate:  val_2).GetEnumerator();
            val_29 = 1152921504691191808;
            val_30 = 1152921543124772384;
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
            new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.LobbyItemSlotClickHandler::OnClick());
            val_11.OnClickEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction());
            new UnityEngine.Events.UnityAction() = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.LobbyItemSlotClickHandler::OnClick());
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
            Rilisoft.上丆丕业丘业丈丄丆 val_2 = this.gameObject.GetComponentInChildren<Rilisoft.上丆丕业丘业丈丄丆>();
            if(val_2 == null)
            {
                    return;
            }
            
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丕且与万一丐丞下丁(丂三七下丗且丌上一:  val_2.LobbyItem, 丗业三丝丁万世丄丐:  false);
            }
            
            if(Rilisoft.LobbyItemSlotClickHandler.丏丝丏丕丄丏丅万丌 == null)
            {
                    return;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            Rilisoft.LobbyItemSlotClickHandler.丏丝丏丕丄丏丅万丌.Invoke(obj:  val_2.LobbyItem);
        }
        public LobbyItemSlotClickHandler()
        {
        
        }
    
    }

}
