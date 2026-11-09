using UnityEngine;

namespace PGCompany
{
    internal class 专且七丒丌上丙丗东 : 丄丗丕下丗丝七丝丒
    {
        // Fields
        private string 丁丐万丂且万东丟丈;
        private string 丗一丐丅丆丛丈丕丛;
        private string 丘丆不下且专东丁丄;
        private string 不丂丅万丈丞丐下丌;
        
        // Methods
        internal 专且七丒丌上丙丗东(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
            string val_19;
            if(万不且且丛丆东丒业 != null)
            {
                    this.丁丐万丂且万东丟丈 = "GameTaskPro_gressLoca_lStoragePro_gress_" + 万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒() + "_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            }
            else
            {
                    this.丁丐万丂且万东丟丈 = "GameTaskPro_gressLoca_lStoragePro_gress_" + 0.丅丙丛丑丌丆丌丕丒() + "_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            }
            
            this.丗一丐丅丆丛丈丕丛 = "GameTaskPro_gressLoca_lStorageRew_arded_" + 万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒() + "_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if(万不且且丛丆东丒业 != null)
            {
                    val_19 = 万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒();
                this.丘丆不下且专东丁丄 = "GameTaskPro_gressLoca_lStorageComp_leted_" + val_19 + "_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            }
            else
            {
                    val_19 = 0.丅丙丛丑丌丆丌丕丒();
                this.丘丆不下且专东丁丄 = "GameTaskPro_gressLoca_lStorageComp_leted_" + val_19 + "_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            }
            
            this.不丂丅万丈丞丐下丌 = "GameTaskPro_gressLoca_lStorageAct_ive_" + 万不且且丛丆东丒业.丅丙丛丑丌丆丌丕丒() + "_" + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        }
        internal override int 丂万丞与丈丙丅丝七()
        {
            return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this.丁丐万丂且万东丟丈, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        internal override void 丒丏丝业丐丞三丏专(int 丅专与丒丈丗丒丘丌)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.丁丐万丂且万东丟丈, 下下丏一丙不丘丌丞:  丅专与丒丈丗丒丘丌, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal override bool 丅丘丄业丕丄一丁万()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this.丗一丐丅丆丛丈丕丛, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        }
        internal override void 专且丙丂丙丙丘丂上(bool 丙业与丙丗丝不丈东)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.丗一丐丅丆丛丈丕丛, 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal override bool 丗万丈丅上丛东世上()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this.丘丆不下且专东丁丄, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        }
        internal override void 三七万不七下不丏万(bool 丙业与丙丗丝不丈东)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.丘丆不下且专东丁丄, 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal override bool 世三丅不丄丂丒丕上()
        {
            return 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this.不丂丅万丈丞丐下丌, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        }
        internal override void 不上丕不丞业一丗丂(bool 丙业与丙丗丝不丈东)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.不丂丅万丈丞丐下丌, 下下丏一丙不丘丌丞:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  丙业与丙丗丝不丈东), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        internal override void 且七丙丄丘一丄上不()
        {
            goto typeof(PGCompany.专且七丒丌上丙丗东).__il2cppRuntimeField_198;
        }
    
    }

}
