using UnityEngine;

namespace PGCompany
{
    public class ClanLobbyMessageLog : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _closedLogContainer;
        private UnityEngine.GameObject _openLogContainer;
        private PGCompany.ClanLobbyMessageLogEntryView _closedMessageLogView;
        private PGCompany.DynamicStringWrapGrid _openMessageLogGrid;
        private bool 下万丑专且丟丈一万;
        
        // Methods
        private void OnEnable()
        {
            ChatController.丆丆丁丑丏一七且下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLobbyMessageLog::丈丅丕丙丝一七下丒()));
            ClansController.专丌丛业丒丏丞丈丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLobbyMessageLog::丈丅丕丙丝一七下丒()));
            this.U_CloseLog();
            this.丈丅丕丙丝一七下丒();
            this.丂丙万丑且丈上三丁();
        }
        private void OnDisable()
        {
            ChatController.丁与七丒丆丁世丐业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLobbyMessageLog::丈丅丕丙丝一七下丒()));
            ClansController.丁上丏丆不丗丈万三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLobbyMessageLog::丈丅丕丙丝一七下丒()));
        }
        private void 丈丅丕丙丝一七下丒()
        {
            PGCompany.ClanLobbyMessageLogEntryView val_3;
            System.Collections.Generic.List<System.String> val_1 = ChatController.丅东丙下丐且万业丌();
            if(this.下万丑专且丟丈一万 != false)
            {
                    this._openMessageLogGrid.UpdateContent(三丏丑不业丏不丂丈:  val_1);
                return;
            }
            
            val_3 = this._closedMessageLogView;
            if((System.Linq.Enumerable.FirstOrDefault<System.String>(source:  val_1)) == null)
            {
                goto label_5;
            }
            
            label_8:
            val_3 = ???;
            goto typeof(PGCompany.ClanLobbyMessageLogEntryView).__il2cppRuntimeField_178;
            label_5:
            if(val_3 != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        private void 丂丙万丑且丈上三丁()
        {
            var val_6;
            var val_7;
            System.Func<东业专世丟不专不丕, System.Boolean> val_9;
            var val_10;
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            val_9 = ClanLobbyMessageLog.<>c.<>9__8_0;
            if(val_9 == null)
            {
                    System.Func<东业专世丟不专不丕, System.Boolean> val_1 = null;
                val_9 = val_1;
                val_1 = new System.Func<东业专世丟不专不丕, System.Boolean>(object:  ClanLobbyMessageLog.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLobbyMessageLog.<>c::业丞丗一业三丟丝不(东业专世丟不专不丕 三丟东丕丄丄下下丑));
                ClanLobbyMessageLog.<>c.<>9__8_0 = val_9;
            }
            
            if((System.Linq.Enumerable.Any<东业专世丟不专不丕>(source:  ChatController.下丗不丒世丑丁丒专, predicate:  val_1)) == false)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            Rilisoft.Singleton<ClansController>.Instance.丗丞丅且七东丏不丘(且丟丅丄丒丑丂丁世:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟(), 下丗不丒世丑丁丒专:  ChatController.下丗不丒世丑丁丒专);
        }
        public void U_OpenLog()
        {
            this.丄丑七丘丁且丞丙专(丟专丑下丂丝业丛且:  true);
            this._openMessageLogGrid.UpdateContent(三丏丑不业丏不丂丈:  ChatController.丅东丙下丐且万业丌());
        }
        public void U_CloseLog()
        {
            PGCompany.ClanLobbyMessageLogEntryView val_3;
            this.丄丑七丘丁且丞丙专(丟专丑下丂丝业丛且:  false);
            val_3 = this._closedMessageLogView;
            if((System.Linq.Enumerable.FirstOrDefault<System.String>(source:  ChatController.丅东丙下丐且万业丌())) == null)
            {
                goto label_3;
            }
            
            label_6:
            val_3 = ???;
            goto typeof(PGCompany.ClanLobbyMessageLogEntryView).__il2cppRuntimeField_178;
            label_3:
            if(val_3 != 0)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private void 丄丑七丘丁且丞丙专(bool 丟专丑下丂丝业丛且)
        {
            this.下万丑专且丟丈一万 = 丟专丑下丂丝业丛且;
            if(this._closedLogContainer == 0)
            {
                    if(this._openLogContainer == 0)
            {
                    return;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._openLogContainer, 丏业丟一东丂东丘丛:  丟专丑下丂丝业丛且);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._closedLogContainer, 丏业丟一东丂东丘丛:  (~丟专丑下丂丝业丛且) & 1);
        }
        public ClanLobbyMessageLog()
        {
        
        }
    
    }

}
