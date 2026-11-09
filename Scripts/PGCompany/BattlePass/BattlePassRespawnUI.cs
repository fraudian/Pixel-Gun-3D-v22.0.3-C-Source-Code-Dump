using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassRespawnUI : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _mainContainer;
        private PGCompany.BattlePass.BattlePassChallengeView _bpChallengeView;
        
        // Methods
        private void OnEnable()
        {
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_2 = PGCompany.BattlePass.BattlePassConnectScene.与业下丏丂上三丗丗(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业(), 不丌丒丆丞下丙专万:  false);
            if(val_2.Count >= 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainContainer, 丏业丟一东丂东丘丛:  true);
                this._bpChallengeView.Setup(与且专丈不万东一万:  丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(丑东与丅丐丅丂丞业:  val_2));
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainContainer, 丏业丟一东丂东丘丛:  false);
        }
        public BattlePassRespawnUI()
        {
        
        }
    
    }

}
