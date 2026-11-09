using UnityEngine;

namespace Subscription20
{
    internal sealed class Subscription20LobbyButtonUI : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _subscriptionGO;
        private PGCompany.TimerUI _timerUI;
        private Subscription20.丘丛不东丒丆丁丑丁 丕丗丛丅丆丏业丕丅;
        
        // Methods
        private void OnEnable()
        {
            Subscription20.丘丛不东丒丆丁丑丁.丂世且万丁七丕万丅(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.丂业业丐上七丁下丁(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.丐七丛丑一丏丛东丅(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七()));
            Subscription20.丘丛不东丒丆丁丑丁 val_7 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗());
            this.丕丗丛丅丆丏业丕丅 = val_7;
            this.丝一丅丆三东丂丞七(丅丘与三丆丝丑上业:  val_7);
        }
        private void OnDisable()
        {
            Subscription20.丘丛不东丒丆丁丑丁.下丆丏丌不丗不丙丟(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.世丌丈世丕丈东专上(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.一且东丙丅一丘且东(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.Subscription20LobbyButtonUI::丝一丅丆三东丂丞七()));
        }
        private void 丝一丅丆三东丂丞七()
        {
            this.丝一丅丆三东丂丞七(丅丘与三丆丝丑上业:  this.丕丗丛丅丆丏业丕丅);
        }
        private void 丝一丅丆三东丂丞七(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)
        {
            int val_5;
            UnityEngine.GameObject val_6;
            val_5 = 丅丘与三丆丝丑上业;
            val_6 = this._subscriptionGO;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
            if(val_5 == null)
            {
                    return;
            }
            
            if((val_5.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗())) != 2)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._subscriptionGO, 丏业丟一东丂东丘丛:  true);
            val_6 = this._timerUI;
            if(丅丘与三丆丝丑上业.七丄丞丄万且丝东丗 != null)
            {
                
            }
            
            this._timerUI.不与丄下丗丛丗丄与 = 0;
            val_5 = val_5.一丟三东丅丙丗与三(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗());
            this._timerUI.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_5, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        public void U_GoToMainStore()
        {
            Subscription20.丘丛不东丒丆丁丑丁 val_9 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑());
            if(val_9 == null)
            {
                    return;
            }
            
            if((val_9.且丌丌丝丅丂丛丏下(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑(), 且丒丛与丞世丙丕丌:  1).Count) == 0)
            {
                    return;
            }
            
            val_9 = val_9.丗业丈丙丒丈世丐丟();
            PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_9, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  "", 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        }
        private void OnApplicationFocus(bool 丄丈丁下丛世丙丗上)
        {
            if(丄丈丁下丛世丙丗上 != false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七(丅丘与三丆丝丑上业:  this.丕丗丛丅丆丏业丕丅);
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            if(东丗七丕丄不丐专丒 != false)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七(丅丘与三丆丝丑上业:  this.丕丗丛丅丆丏业丕丅);
        }
        public Subscription20LobbyButtonUI()
        {
        
        }
    
    }

}
