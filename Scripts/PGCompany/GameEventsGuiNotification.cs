using UnityEngine;

namespace PGCompany
{
    internal class GameEventsGuiNotification : GuiNotification
    {
        // Fields
        private PGCompany.专东三丕丕丕业丂丁 _gameEventType;
        
        // Methods
        protected override PGCompany.丗不上业丙丆世丁丘 丁丘业七上丈三丄七(PGCompany.丗不上业丙丆世丁丘 与不丕丆丈不丙丟丛)
        {
            bool val_2;
            PGCompany.上丏丂丙丌丅万丌世 val_3;
            PGCompany.丗不上业丙丆世丁丘 val_0;
            PGCompany.丗不上业丙丆世丁丘 val_1 = this.丁丘业七上丈三丄七(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒, 丏丟丑丙七东专丌丏 = true, 三丘丄丝丐丘业丟丘 = 268435467, 丒丂丌丑丟东东丒专 = 与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专});
            与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专 = val_2;
            与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒 = val_3;
            与不丕丆丈不丙丟丛.丏丟丑丙七东专丌丏 = this._gameEventType;
            val_0.丒丂丌丑丟东东丒专 = val_2;
            val_0.丒三丝一上丙专丗丒 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒;
            return val_0;
        }
        public GameEventsGuiNotification()
        {
        
        }
    
    }

}
