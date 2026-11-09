using UnityEngine;

namespace PGCompany
{
    internal class NewItemsCategoryGuiNotification : GuiNotification
    {
        // Fields
        private CategoryNames _category;
        
        // Properties
        public CategoryNames 七丆丒与丗丌丄且丂 { get; }
        
        // Methods
        protected override PGCompany.丗不上业丙丆世丁丘 丁丘业七上丈三丄七(PGCompany.丗不上业丙丆世丁丘 与不丕丆丈不丙丟丛)
        {
            bool val_2;
            PGCompany.上丏丂丙丌丅万丌世 val_3;
            PGCompany.丗不上业丙丆世丁丘 val_0;
            PGCompany.丗不上业丙丆世丁丘 val_1 = this.丁丘业七上丈三丄七(与不丕丆丈不丙丟丛:  new PGCompany.丗不上业丙丆世丁丘() {丒三丝一上丙专丗丒 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒, 丏丟丑丙七东专丌丏 = true, 三丘丄丝丐丘业丟丘 = 268435467, 丒丂丌丑丟东东丒专 = 与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专});
            与不丕丆丈不丙丟丛.丒丂丌丑丟东东丒专 = val_2;
            与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒 = val_3;
            与不丕丆丈不丙丟丛.丏丟丑丙七东专丌丏 = this._category;
            val_0.丒丂丌丑丟东东丒专 = val_2;
            val_0.丒三丝一上丙专丗丒 = 与不丕丆丈不丙丟丛.丒三丝一上丙专丗丒;
            return val_0;
        }
        public CategoryNames get_category()
        {
            return (CategoryNames)this._category;
        }
        public NewItemsCategoryGuiNotification()
        {
        
        }
    
    }

}
