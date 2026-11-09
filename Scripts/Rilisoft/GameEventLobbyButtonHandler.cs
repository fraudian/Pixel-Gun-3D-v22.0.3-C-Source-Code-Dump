using UnityEngine;

namespace Rilisoft
{
    public class GameEventLobbyButtonHandler : MonoBehaviour
    {
        // Fields
        public string EventId;
        private UnityEngine.GameObject _body;
        private Rilisoft.TextGroup _eventNameText;
        private UILabel _timerLabel;
        
        // Methods
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventLobbyButtonHandler.东东丗丑专丞世丞与();
        }
        public void U_Click()
        {
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丝上且七丕丒丙丂丆(丟丟丄专上丟丁丐丝:  this.EventId)) == false)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler.丞丙丗丁丙丏七专丑(丟丟丄专上丟丁丐丝:  this.EventId, 业万与下且万丕丈丑:  new System.Nullable<UnityEngine.Vector3>() {HasValue = false}, 丈丈不丒丗与丝不丗:  false);
        }
        public GameEventLobbyButtonHandler()
        {
            this.EventId = "pg_birthday";
        }
    
    }

}
