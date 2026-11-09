using UnityEngine;

namespace Competition
{
    internal sealed class CompetitionCellWrapGridItem : DynamicWrapGridItem
    {
        // Fields
        private Competition.丘东不专不丒丕万丄 丛丌丕丐世丑丂七丂;
        private Competition.CompetitionCell _cellUi;
        
        // Properties
        internal Competition.丘东不专不丒丕万丄 丞丑且东丌与丏丏丁 { get; }
        
        // Methods
        internal Competition.丘东不专不丒丕万丄 丁专丗万三上丟三丆()
        {
            return (Competition.丘东不专不丒丕万丄)this.丛丌丕丐世丑丂七丂;
        }
        public override void UpdateContent(object 三丏丑不业丏不丂丈)
        {
            Competition.丘东不专不丒丕万丄 val_1;
            int val_2;
            if(三丏丑不业丏不丂丈 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            this.丛丌丕丐世丑丂七丂 = 0;
            return;
            label_2:
            this.丛丌丕丐世丑丂七丂 = 三丏丑不业丏不丂丈;
            if(this._cellUi == null)
            {
                goto label_3;
            }
            
            if(三丏丑不业丏不丂丈 == null)
            {
                goto label_4;
            }
            
            label_8:
            this._cellUi.SetUpdatingData();
            this._cellUi.competitionUpdatingDataCell.丈且东丑丂且万丒丅(且丒丛与丞世丙丕丌:  this.丛丌丕丐世丑丂七丂.且丒丛与丞世丙丕丌);
            return;
            label_3:
            if(三丏丑不业丏不丂丈 != null)
            {
                goto label_8;
            }
            
            label_4:
            this._cellUi.SetAsPlayer();
            val_1 = this.丛丌丕丐世丑丂七丂;
            if(val_1 == null)
            {
                goto label_10;
            }
            
            val_2 = this.丛丌丕丐世丑丂七丂.且丒丛与丞世丙丕丌;
            goto label_11;
            label_10:
            val_2 = this.丛丌丕丐世丑丂七丂.且丒丛与丞世丙丕丌;
            if(this.丛丌丕丐世丑丂七丂 == null)
            {
                goto label_12;
            }
            
            val_1 = this.丛丌丕丐世丑丂七丂;
            label_11:
            label_14:
            label_15:
            this._cellUi.competitionPlayerCell.丈且东丑丂且万丒丅(且丒丛与丞世丙丕丌:  val_2, 丞丅上丏丂且下丅与:  this.丛丌丕丐世丑丂七丂.丞丅上丏丂且下丅与, 不丆业丏上丐与丌业:  this.丛丌丕丐世丑丂七丂.丛三三与丁丘丄丑下, 万且丒下丕丝专丟上:  this.丛丌丕丐世丑丂七丂.万且丒下丕丝专丟上);
            return;
            label_12:
            if(this.丛丌丕丐世丑丂七丂 != null)
            {
                goto label_14;
            }
            
            if(this.丛丌丕丐世丑丂七丂 != null)
            {
                goto label_15;
            }
        
        }
        public CompetitionCellWrapGridItem()
        {
        
        }
    
    }

}
