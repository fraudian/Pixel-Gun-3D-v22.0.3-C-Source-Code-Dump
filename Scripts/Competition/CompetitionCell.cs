using UnityEngine;

namespace Competition
{
    internal sealed class CompetitionCell : PGBehaviour
    {
        // Fields
        public UnityEngine.GameObject playerCellObject;
        public UnityEngine.GameObject leagueCellObject;
        public UnityEngine.GameObject updatingDataCellObject;
        public Competition.CompetitionPlayerCell competitionPlayerCell;
        public Competition.CompetitionLeagueChangeCell competitionLeagueChangeCell;
        public Competition.CompetitionUpdatingDataCell competitionUpdatingDataCell;
        
        // Methods
        public void SetAsPlayer()
        {
            this.不丘丆丝且丘丒丁丘();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerCellObject, 丏业丟一东丂东丘丛:  true);
        }
        public void SetAsLeague()
        {
            this.不丘丆丝且丘丒丁丘();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leagueCellObject, 丏业丟一东丂东丘丛:  true);
        }
        public void SetUpdatingData()
        {
            this.不丘丆丝且丘丒丁丘();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.updatingDataCellObject, 丏业丟一东丂东丘丛:  true);
        }
        private void 不丘丆丝且丘丒丁丘()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerCellObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leagueCellObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.updatingDataCellObject, 丏业丟一东丂东丘丛:  false);
        }
        public void U_OnClick()
        {
            if(this.competitionPlayerCell == 0)
            {
                    return;
            }
            
            if((this.competitionPlayerCell.<上七东下丏不丕丐丑>k__BackingField) == null)
            {
                    return;
            }
            
            this.丈丄世丑业不丕丅丞();
        }
        private void 丈丄世丑业不丕丅丞()
        {
            var val_6;
            if(this.competitionPlayerCell == 0)
            {
                    return;
            }
            
            if(this.competitionPlayerCell.上世丄不丐丁丟丅丒 == true)
            {
                    return;
            }
            
            if(this.playerCellObject == 0)
            {
                    return;
            }
            
            if(this.playerCellObject.activeInHierarchy == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  LeaderboardsGui.与一丅丝不丈业与丙(), 丏业丟一东丂东丘丛:  false);
            val_6 = null;
            val_6 = null;
            FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.competitionPlayerCell.<上七东下丏不丕丐丑>k__BackingField, 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  CompetitionCell.<>c.<>9, method:  System.Void CompetitionCell.<>c::上丛丗丄丁丒且丘一(bool 丕丁丗丘丟丆一丟丆)));
        }
        public CompetitionCell()
        {
        
        }
    
    }

}
