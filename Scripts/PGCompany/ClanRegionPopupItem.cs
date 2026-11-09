using UnityEngine;

namespace PGCompany
{
    public class ClanRegionPopupItem : PGBehaviour, 丂丈丘三丒丈不专丘
    {
        // Fields
        private UILabel _textLabel;
        private string 丆不丗三丄丕丛丈丏;
        
        // Methods
        public string GetReadableValue()
        {
            return PGCompany.不东丏三丞丞东丕丙.丘专下丄丂丑丞三东(上丏万丕丆七不与万:  this.丆不丗三丄丕丛丈丏);
        }
        public int GetIntValue()
        {
            return 0;
        }
        public string GetStringValue()
        {
            return (string)this.丆不丗三丄丕丛丈丏;
        }
        public void SetIntValue(int 丙业与丙丗丝不丈东)
        {
        
        }
        public void SetStringValue(string 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_1;
            }
            
            label_5:
            this.丆不丗三丄丕丛丈丏 = 丙业与丙丗丝不丈东;
            return;
            label_1:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        public void UpdateView()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._textLabel, 丕丗丘丑丛与丑业丒:  this.GetReadableValue());
        }
        public ClanRegionPopupItem()
        {
        
        }
    
    }

}
