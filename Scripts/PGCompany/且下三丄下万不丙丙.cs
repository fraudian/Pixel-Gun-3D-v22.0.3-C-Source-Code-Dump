using UnityEngine;

namespace PGCompany
{
    internal class 且下三丄下万不丙丙 : 东上丛丂丅下丄七丝
    {
        // Methods
        internal override void 下丌业业丐丘丐丘三()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.且下三丄下万不丙丙::且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
        internal override void 不与丞下业丑丒丙万()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void PGCompany.且下三丄下万不丙丙::且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        }
        private void 且一丟万丐丐不丅丈(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
        {
            object val_39;
            var val_40;
            object val_41;
            var val_43;
            string val_44;
            val_39 = 丗丛不丁丑专专丂且;
            if(mem[137134216] != 100)
            {
                    if((val_39 == null) || (mem[137134216] != val_39.丘丛丆丕且丂业世丌()))
            {
                goto label_5;
            }
            
            }
            
            val_40 = 1;
            goto label_6;
            label_5:
            string val_3 = System.String.Format(format:  "Settings.GameMode={0} e.Mode={1}", arg0:  mem[137134216], arg1:  val_39.丘丛丆丕且丂业世丌());
            UnityEngine.Debug.LogError(message:  val_3);
            val_40 = 0;
            label_6:
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    if(val_39 != null)
            {
                    if((PGCompany.丞丂丄丐三业丝丆丂.丙丟丄丕丈丝一丛丘(丘与丙丟丙丙下七丙:  val_3, 丆丁丗一一丆丈丗丞:  val_39.丕丆丞丂业东与上丅(), 丂丛丑东不丅丈一东:  val_39.丘丛丆丕且丂业世丌())) == true)
            {
                goto label_15;
            }
            
            }
            
                if(val_39 != null)
            {
                    val_41 = val_39.丕丆丞丂业东与上丅();
            }
            else
            {
                    val_41 = 0.丕丆丞丂业东与上丅();
            }
            
                string val_11 = System.String.Format(format:  "Settings.Map={0} e.Map={1} e.Mode={2}", arg0:  val_3, arg1:  val_41, arg2:  val_39.丘丛丆丕且丂业世丌());
                UnityEngine.Debug.LogError(message:  val_11);
                val_40 = 0;
            }
            
            label_15:
            if(null != 9990000)
            {
                    if(val_39 != null)
            {
                    if(val_11 == val_39.丄丄世七三业丝丛丘())
            {
                goto label_25;
            }
            
            }
            
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Settings.ItemCategory={0} e.ItemCategory={1}", arg0:  null, arg1:  val_39.丄丄世七三业丝丛丘()));
                val_40 = 0;
            }
            
            label_25:
            if(null != 0)
            {
                    if(val_39 != null)
            {
                    if((PGCompany.七丆丆丕丂丙丕丐丂.下丒丌丁丈三丆丑丁(丆专且丕专丗与一丏:  val_39.丝一丙丘专七丕不上(), 丁丅丈丌丟世丗丗丟:  null)) == true)
            {
                goto label_34;
            }
            
            }
            
                string val_22 = System.String.Format(format:  "Settings.ModuleType={0} e.ItemIndex={1} modules={2}", arg0:  val_15 + 200, arg1:  val_39.丝一丙丘专七丕不上(), arg2:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丞世不丒下上上丝丑:  val_39.丝一丙丘专七丕不上())));
                UnityEngine.Debug.LogError(message:  val_22);
                val_40 = 0;
            }
            
            label_34:
            if((val_22 + 176) < 1)
            {
                goto label_45;
            }
            
            if(val_39 == null)
            {
                goto label_43;
            }
            
            string val_24 = val_22 + 176;
            if(val_24 == val_39.丝一丙丘专七丕不上())
            {
                goto label_45;
            }
            
            label_43:
            string val_28 = System.String.Format(format:  "Settings.ItemIndex={0} e.ItemIndex={1}", arg0:  val_24 + 176, arg1:  val_39.丝一丙丘专七丕不上());
            UnityEngine.Debug.LogError(message:  val_28);
            val_40 = 0;
            label_45:
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_51;
            }
            
            if(val_39 == null)
            {
                goto label_52;
            }
            
            if((PGCompany.丞丂丄丐三业丝丆丂.丑丕丁丈丞丆丞丛丒(丛丘丂丈丘下丂一丛:  val_28, 丆专且丕专丗与一丏:  val_39.丝一丙丘专七丕不上())) == false)
            {
                goto label_54;
            }
            
            label_51:
            if(val_40 == 0)
            {
                    return;
            }
            
            this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
            return;
            label_52:
            val_43 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            goto label_57;
            label_54:
            val_43 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            label_57:
            PGCompany.丟丝东丈丐丙三下丛 val_35 = val_43.一丌世丑丄东丞丘三<PGCompany.丟丝东丈丐丙三下丛>(丞世不丒下上上丝丑:  val_39.丝一丙丘专七丕不上());
            if(val_35 != null)
            {
                    AlmanachWeaponSet val_36 = 上且丁万与丌下丐上.一丅丂丞丑下丝业上(与丘东下丈东丛丂万:  val_35);
                val_44 = val_36.id;
            }
            
            val_39 = System.String.Format(format:  "Settings.WeaponSetId={0} e.ItemIndex={1} weaponSet={2}", arg0:  val_35, arg1:  val_39.丝一丙丘专七丕不上(), arg2:  System.String.__il2cppRuntimeField_static_fields);
            UnityEngine.Debug.LogError(message:  val_39);
        }
        public 且下三丄下万不丙丙()
        {
        
        }
    
    }

}
