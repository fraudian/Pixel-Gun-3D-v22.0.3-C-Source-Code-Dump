using UnityEngine;

namespace PGCompany.DataObjects
{
    internal class 七七丙丗丏丑专业丝
    {
        // Fields
        private System.Collections.Generic.List<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒> 丙丂丙东丞且且业一;
        private bool 且丈东三三丁丑不丟;
        internal System.Collections.Generic.List<GiftSettingType> SeasonSettings;
        internal System.DateTime StartTime;
        internal int SeasonDays;
        
        // Methods
        internal void 丂丗上丘业丒丕丘且()
        {
            this.丙丂丙东丞且且业一 = 0;
        }
        internal System.Collections.Generic.List<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒> 万且丏丙东丆东且不()
        {
            if(this.丙丂丙东丞且且业一 != null)
            {
                    if(this.且丈东三三丁丑不丟 == true)
            {
                    return (System.Collections.Generic.List<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒>)this.丙丂丙东丞且且业一;
            }
            
                if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                    return (System.Collections.Generic.List<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒>)this.丙丂丙东丞且且业一;
            }
            
            }
            
            this.丗七丂丄丗世万丌丏();
            return (System.Collections.Generic.List<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒>)this.丙丂丙东丞且且业一;
        }
        private void 丗七丂丄丗世万丌丏(System.DateTime 丅丏丅丂丝一丆丙丅)
        {
            七七丙丗丏丑专业丝.丒丑万一丁丕东一丗 val_27;
            int val_28;
            var val_29;
            七七丙丗丏丑专业丝.丒丑万一丁丕东一丗 val_1 = null;
            val_27 = val_1;
            val_1 = new 七七丙丗丏丑专业丝.丒丑万一丁丕东一丗();
            this.丙丂丙东丞且且业一 = new System.Object();
            System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 丅丏丅丂丝一丆丙丅.dateData}, d2:  new System.DateTime() {dateData = this.StartTime});
            int val_4 = this.SeasonDays + (this.SeasonDays << 2);
            val_4 = val_4 << 1;
            System.TimeSpan val_5 = System.TimeSpan.FromDays(value:  (double)val_4);
            val_28 = this.SeasonDays;
            double val_7 = (int)val_3._ticks.TotalDays / val_28;
            if(val_7 >= (4.94065645841247E-324))
            {
                    var val_27 = 0;
                do
            {
                if(this.SeasonSettings != null)
            {
                    val_29 = this.SeasonSettings.Count;
            }
            else
            {
                    val_29 = 0.Count;
            }
            
                .与丗丕丕与丌世丅丛 = this.SeasonSettings.Item[val_27 - ((val_27 / val_29) * val_29)];
                System.TimeSpan val_15 = System.TimeSpan.FromDays(value:  (double)this.SeasonDays * val_27);
                .丗丒丂丕丂业业丟丟 = this.StartTime;
                int val_28 = this.SeasonDays;
                val_27 = val_27 + 1;
                val_28 = val_28 * val_27;
                System.TimeSpan val_16 = System.TimeSpan.FromDays(value:  (double)val_28);
                System.TimeSpan val_17 = System.TimeSpan.FromSeconds(value:  1);
                mem[1152921560562819088] = this.StartTime;
                System.DateTime val_19 = .丗丒丂丕丂业业丟丟.AddSeconds(value:  (double)Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  44));
                mem[1152921560562819080] = val_19.dateData;
                System.DateTime val_21 = mem[1152921560562819088].AddSeconds(value:  (double)Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  44));
                mem[1152921560562819088] = val_21.dateData;
                this.丙丂丙东丞且且业一.Add(item:  new PGCompany.DataObjects.丗丅丐丙丅业丟丒丒());
            }
            while(val_7 != val_27);
            
                val_28 = this.SeasonDays;
                val_27 = val_27;
            }
            
            int val_22 = val_28 + (val_28 << 2);
            val_22 = val_22 << 1;
            System.TimeSpan val_23 = System.TimeSpan.FromDays(value:  (double)val_22);
            mem[1152921560562810880] = ;
            this.丙丂丙东丞且且业一 = System.Linq.Enumerable.ToList<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒>(source:  System.Linq.Enumerable.Where<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒>(source:  this.丙丂丙东丞且且业一, predicate:  new System.Func<PGCompany.DataObjects.丗丅丐丙丅业丟丒丒, System.Boolean>(object:  val_1, method:  System.Boolean 七七丙丗丏丑专业丝.丒丑万一丁丕东一丗::丑丝丌丛丑世丑丗丒(PGCompany.DataObjects.丗丅丐丙丅业丟丒丒 三丟东丕丄丄下下丑))));
        }
        private void 丗七丂丄丗世万丌丏()
        {
            ulong val_6;
            System.DateTime val_2 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  专七专下且专三一且.上且一丈丐三丄一丆());
            this.且丈东三三丁丑不丟 = false;
            val_6 = val_2.dateData;
            if(PixelTime.丝业丁丌丘东丏世与() != false)
            {
                    System.DateTime val_5 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  PixelTime.丝丗专上三不丄丑丑());
                val_6 = val_5.dateData;
                this.且丈东三三丁丑不丟 = true;
            }
            
            this.丗七丂丄丗世万丌丏(丅丏丅丂丝一丆丙丅:  new System.DateTime() {dateData = val_6});
        }
        public 七七丙丗丏丑专业丝()
        {
            this.SeasonSettings = new System.Collections.Generic.List<GiftSettingType>();
        }
    
    }

}
