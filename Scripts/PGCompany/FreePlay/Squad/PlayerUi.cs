using UnityEngine;

namespace PGCompany.FreePlay.Squad
{
    public class PlayerUi : PGBehaviour
    {
        // Fields
        private UILabel _nick;
        private UnityEngine.GameObject _myPlayerContainer;
        private UnityEngine.GameObject _inMySquadContainer;
        private UnityEngine.GameObject _inOtherSquadContainer;
        private UnityEngine.GameObject _inviteSentAndNoResponseContainer;
        private UnityEngine.GameObject _canInviteContainer;
        private UnityEngine.GameObject _tooFarContainer;
        private string 丈丆丆丂且丝东丏丂;
        public System.Action<string> InviteClicked;
        
        // Methods
        public void DisableAllStates()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._nick, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._myPlayerContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inMySquadContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inOtherSquadContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inviteSentAndNoResponseContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._canInviteContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tooFarContainer, 丏业丟一东丂东丘丛:  false);
        }
        public void SetData(string 丄丒且丙三丆丟与丏)
        {
            this.丈丆丆丂且丝东丏丂 = 丄丒且丙三丆丟与丏;
        }
        public void SetName(string 丞丞下东且丗丄丒丏)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._nick, 丕丗丘丑丛与丑业丒:  丞丞下东且丗丄丒丏);
        }
        public void SetMyPlayer()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.yellow;
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._nick, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._myPlayerContainer, 丏业丟一东丂东丘丛:  true);
        }
        public void SetInMySquad()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inMySquadContainer, 丏业丟一东丂东丘丛:  true);
        }
        public void SetInOtherSquad()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inOtherSquadContainer, 丏业丟一东丂东丘丛:  true);
        }
        public void SetInviteSent()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._inviteSentAndNoResponseContainer, 丏业丟一东丂东丘丛:  true);
        }
        public void SetCanInvite()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._canInviteContainer, 丏业丟一东丂东丘丛:  true);
        }
        public void SetTooFar()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tooFarContainer, 丏业丟一东丂东丘丛:  true);
        }
        public void U_InviteClicked()
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丈丆丆丂且丝东丏丂)) != false)
            {
                    UnityEngine.Debug.LogError(message:  "Player ID is empty. Possible you did not call SetData");
                return;
            }
            
            if(this.InviteClicked == null)
            {
                    return;
            }
            
            this.InviteClicked.Invoke(obj:  this.丈丆丆丂且丝东丏丂);
        }
        public PlayerUi()
        {
        
        }
    
    }

}
