using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassChallengesTab : MonoBehaviour, 万丟丞不世丛七一专<PGCompany.BattlePass.BattlePassChallengesTab>
    {
        // Fields
        private int 上丂丅丈丝丅业丝七;
        private bool 丌三丛丁东丅下世世;
        private PGCompany.BattlePass.BattlePassChallengesCommonView.Tab _tab;
        private System.Action<PGCompany.BattlePass.BattlePassChallengesTab> 丅丕丌丛万丂丈七与;
        private UnityEngine.GameObject _selectedObj;
        private UnityEngine.GameObject _notSelectedObj;
        private UnityEngine.GameObject _badge;
        private UILabel _rewardsCountLabel;
        private UnityEngine.GameObject _isNewMark;
        private UIGrid _gridNotification;
        
        // Properties
        public bool 与丆与丂丄丞丒丏丑 { get; set; }
        public int 丌丗丐丈丘丝丝丒七 { get; set; }
        
        // Methods
        public bool get_Selected()
        {
            return (bool)this.丌三丛丁东丅下世世;
        }
        public void set_Selected(bool 丙业与丙丗丝不丈东)
        {
            bool val_1 = 丙业与丙丗丝不丈东;
            this.丌三丛丁东丅下世世 = val_1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedObj, 丏业丟一东丂东丘丛:  val_1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notSelectedObj, 丏业丟一东丂东丘丛:  (this.丌三丛丁东丅下世世 == false) ? 1 : 0);
        }
        public int get_RewardsCount()
        {
            return (int)this.上丂丅丈丝丅业丝七;
        }
        public void set_RewardsCount(int 丙业与丙丗丝不丈东)
        {
            this.上丂丅丈丝丅业丝七 = 丙业与丙丗丝不丈东;
            this.丝一丅丆三东丂丞七();
        }
        public void add_Clicked(System.Action<PGCompany.BattlePass.BattlePassChallengesTab> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560058017096);
        
        }
        public void remove_Clicked(System.Action<PGCompany.BattlePass.BattlePassChallengesTab> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560058153672);
        
        }
        private void 丝一丅丆三东丂丞七()
        {
            string val_4;
            if(this._badge != 0)
            {
                    val_4 = 1152921505284374528;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._badge, 丏业丟一东丂东丘丛:  (this.上丂丅丈丝丅业丝七 > 0) ? 1 : 0);
                if(this.上丂丅丈丝丅业丝七 >= 1)
            {
                    val_4 = this.上丂丅丈丝丅业丝七.ToString();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._rewardsCountLabel, 丕丗丘丑丛与丑业丒:  val_4);
            }
            
            }
            
            this.与下丐东丙丟丘丑丕();
        }
        private void 与下丐东丙丟丘丑丕()
        {
            var val_11;
            UnityEngine.Object val_12;
            UnityEngine.GameObject val_13;
            val_11 = this;
            val_12 = 0;
            if(this._isNewMark == val_12)
            {
                goto label_3;
            }
            
            if(this._tab == 1)
            {
                goto label_4;
            }
            
            if(this._tab != 0)
            {
                goto label_5;
            }
            
            val_13 = this._isNewMark;
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_2 = PGCompany.BattlePass.万丈上下三丅丘丛丒.丈丟丒丏丝东丕三下();
            goto label_6;
            label_4:
            val_13 = this._isNewMark;
            label_6:
            var val_5 = (PGCompany.BattlePass.万丈上下三丅丘丛丒.上专丘世丘丂丝上丐().Count > 0) ? 1 : 0;
            goto label_9;
            label_5:
            val_12 = 0;
            label_9:
            this._isNewMark.SetActive(value:  false);
            label_3:
            if(this._gridNotification == null)
            {
                    return;
            }
            
            val_11 = ???;
            goto typeof(UIGrid).__il2cppRuntimeField_1A8;
        }
        private void Awake()
        {
            if(this._isNewMark == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东.下丏且丞丈丐丅不东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesTab::与下丐东丙丟丘丑丕()));
            BPChallengesController.下专丒丌与丙不一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesTab::与下丐东丙丟丘丑丕()));
        }
        private void OnDestroy()
        {
            if(this._isNewMark == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东.下且丅丟且丄丌业丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesTab::与下丐东丙丟丘丑丕()));
            BPChallengesController.与万丟不丝丗丒东丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassChallengesTab::与下丐东丙丟丘丑丕()));
        }
        public void U_Click()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        public BattlePassChallengesTab()
        {
        
        }
    
    }

}
