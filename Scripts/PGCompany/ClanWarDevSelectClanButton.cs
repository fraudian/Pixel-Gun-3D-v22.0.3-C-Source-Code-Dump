using UnityEngine;

namespace PGCompany
{
    internal class ClanWarDevSelectClanButton : MonoBehaviour
    {
        // Fields
        private static System.Action 丈丂世下东七上丈三;
        public SelectableButton selectableButton;
        public UILabel numClanLabel;
        private int <丆丈丅丙一丞丝且七>k__BackingField;
        
        // Properties
        internal int 丞丝下业丁丘丘不丞 { get; set; }
        
        // Methods
        internal static void 下丒东丏专丏丌丙业(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ClanWarDevSelectClanButton.丈丂世下东七上丈三, b:  丙业与丙丗丝不丈东);
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
        internal static void 丐世且丂丘且丄丁东(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ClanWarDevSelectClanButton.丈丂世下东七上丈三, value:  丙业与丙丗丝不丈东);
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
        internal int 业世三丐且丗三丞万()
        {
            return (int)this.<丆丈丅丙一丞丝且七>k__BackingField;
        }
        private void 丐丆一下丁丏一七丒(int 丙业与丙丗丝不丈东)
        {
            this.<丆丈丅丙一丞丝且七>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal void 丈且东丑丂且万丒丅(int 丞丕业丙丄丂丆丆丈)
        {
            this.<丆丈丅丙一丞丝且七>k__BackingField = 丞丕业丙丄丂丆丆丈;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.numClanLabel, 丕丗丘丑丛与丑业丒:  丞丕业丙丄丂丆丆丈.ToString());
        }
        public void U_SelectNumClan()
        {
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "keyClanWarIdMyClan", 下下丏一丙不丘丌丞:  PGCompany.丂丘丞丂丏七丁丄不.丒不世丌业不一丆丏(丄丝丏上丄丛丘丟丆:  this.<丆丈丅丙一丞丝且七>k__BackingField));
            if(PGCompany.ClanWarDevSelectClanButton.丈丂世下东七上丈三 == null)
            {
                    return;
            }
            
            PGCompany.ClanWarDevSelectClanButton.丈丂世下东七上丈三.Invoke();
        }
        public ClanWarDevSelectClanButton()
        {
        
        }
    
    }

}
