using UnityEngine;

namespace PGCompany
{
    public class ClanWarRewardBannerItemsView : PGBehaviour
    {
        // Fields
        private PGCompany.ClanWarRewardCellTaskView Cell1;
        private PGCompany.ClanWarRewardCellTaskView Cell2;
        private PGCompany.ClanWarRewardEventRaidView Raid;
        private PGCompany.ClanWarRewardEventSiegeView Siege;
        
        // Methods
        internal void 丆丌丂丑东世专业丌(PGCompany.丛丝丏丂东丏专三丁 丗七丟丈三不丕一三)
        {
            if(this.Cell1 != 0)
            {
                    this.Cell1.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丗七丟丈三不丕一三);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Single Cell Missing Reference");
        }
        internal void 丗不万丏三丌丙丟业(PGCompany.丛丝丏丂东丏专三丁 丏丛丏上丐丐丁丐世, PGCompany.丛丝丏丂东丏专三丁 丁丒上不丘业丂上丕)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Cell1, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Cell2, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Raid, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Siege, 丏业丟一东丂东丘丛:  false);
            if(this.Cell1 != 0)
            {
                    this.Cell1.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丏丛丏上丐丐丁丐世);
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  "First Cell Missing Reference");
            }
            
            if(this.Cell2 != 0)
            {
                    this.Cell2.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丁丒上不丘业丂上丕);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Second Cell Missing Reference");
        }
        internal void 丈三丗世丟业不东七(PGCompany.丛丝丏丂东丏专三丁 丘丛世丟三丙七不专)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Raid, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Cell1, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Cell2, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Siege, 丏业丟一东丂东丘丛:  false);
            if(this.Raid != 0)
            {
                    this.Raid.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丘丛世丟三丙七不专);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Raid Missing Reference");
        }
        internal void 丁上下业专丘丟丁丙(PGCompany.丛丝丏丂东丏专三丁 丅丟与丟东丛东丛一)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Siege, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Cell1, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Cell2, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.Raid, 丏业丟一东丂东丘丛:  false);
            if(this.Siege != 0)
            {
                    this.Siege.上丛丌丆丑上七世三(丗七丟丈三不丕一三:  丅丟与丟东丛东丛一);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "Siege Missing Reference");
        }
        public ClanWarRewardBannerItemsView()
        {
        
        }
    
    }

}
