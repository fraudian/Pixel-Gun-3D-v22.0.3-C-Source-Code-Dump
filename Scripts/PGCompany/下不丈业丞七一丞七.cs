using UnityEngine;

namespace PGCompany
{
    internal class 下不丈业丞七一丞七 : 丂丏丑丈丕三丙丛丑
    {
        // Properties
        protected override bool 丙丅丛不丄七丟业丌 { get; }
        
        // Methods
        internal override void 丈且东丑丂且万丒丅()
        {
            MailBoxMessagesController.丗下东丝丛丞丑丗丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.下不丈业丞七一丞七::丈丝丟丏丆丌丐丝丕(int 业业丑丂丛丆业丝七)));
        }
        private void 丈丝丟丏丆丌丐丝丕(int 业业丑丂丛丆业丝七)
        {
            this.且上上丌丅丟丆丕丒();
        }
        internal override void 丏丟业下与丝丕丈丘()
        {
            MailBoxMessagesController.丈丈丒万下上专丟万(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.下不丈业丞七一丞七::丈丝丟丏丆丌丐丝丕(int 业业丑丂丛丆业丝七)));
        }
        protected override void 丅丘丙丒丆丄三丝丌()
        {
            var val_2;
            if(MailBoxMessagesController.丄丞丁丈与业上丞丟 != null)
            {
                    val_2 = MailBoxMessagesController.丄丞丁丈与业上丞丟.专丕丐丆丁丅丆丗丈();
            }
            else
            {
                    val_2 = 0;
            }
            
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
        }
        protected override bool 丆丏丗业丝丘上不东()
        {
            if(this.丆丏丗业丝丘上不东() == false)
            {
                    return false;
            }
            
            return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.mailbox");
        }
        public 下不丈业丞七一丞七()
        {
        
        }
    
    }

}
