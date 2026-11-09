using UnityEngine;

namespace PGCompany
{
    internal sealed class ServerTimeStateUI : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _stateServerTimeOn;
        private UnityEngine.GameObject _stateServerTimeOff;
        
        // Methods
        private void OnEnable()
        {
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ServerTimeStateUI::丝一丅丆三东丂丞七()));
            PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ServerTimeStateUI::丝一丅丆三东丂丞七()));
            this.丝一丅丆三东丂丞七();
        }
        private void OnDisable()
        {
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ServerTimeStateUI::丝一丅丆三东丂丞七()));
            PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ServerTimeStateUI::丝一丅丆三东丂丞七()));
        }
        private void 丝一丅丆三东丂丞七()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateServerTimeOn, 丏业丟一东丂东丘丛:  PixelTime.丝业丁丌丘东丏世与());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._stateServerTimeOff, 丏业丟一东丂东丘丛:  (~PixelTime.丝业丁丌丘东丏世与()) & 1);
        }
        public ServerTimeStateUI()
        {
        
        }
    
    }

}
