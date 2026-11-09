using UnityEngine;

namespace PGCompany
{
    internal class 丅丌丞丟世丆丞下上 : 丕万丅丗丏三丙丈丁
    {
        // Methods
        internal override void 下丏且一三丐一丐不()
        {
            var val_11;
            var val_20;
            MainMenuController val_21;
            var val_22;
            var val_23;
            Rilisoft.七丕丟丏三丈一丄世 val_24;
            var val_25;
            var val_26;
            string val_27;
            var val_28;
            val_20 = null;
            val_20 = null;
            val_21 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_21 == 0)
            {
                    return;
            }
            
            val_22 = static_value_081DACA8;
            val_22 = static_value_081DACA8;
            val_21 = mem[static_value_081DACA8 + 184 + 16];
            val_21 = static_value_081DACA8 + 184 + 16;
            if(val_21 == 0)
            {
                    return;
            }
            
            val_23 = static_value_081DACA8;
            val_23 = static_value_081DACA8;
            var val_19 = 0;
            label_18:
            if(val_19 >= val_3.Length)
            {
                goto label_15;
            }
            
            val_24 = static_value_081DACA8 + 184 + 16.丏丕三一不丙丈与丒()[0];
            val_19 = val_19 + 1;
            if((System.Linq.Enumerable.Count<PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒>(source:  PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世().丐世三三丕丅上丝专(丂丛丑东不丅丈一东:  val_24, 丞丁丑丏丄丏七丂不:  0))) <= 0)
            {
                goto label_18;
            }
            
            goto label_19;
            label_15:
            val_24 = 2;
            label_19:
            val_25 = null;
            val_25 = null;
            MainMenuController.丄丞丁丈与业上丞丟.OnClickMultiplyerButtonCore(三丂东专丕专业丏万:  false);
            val_26 = static_value_081DACA8;
            val_26 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.丘东万丙丌丑丄丗专(丒七世丈丌丑丏丄丏:  val_24);
            val_21 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  static_value_081DACA8 + 184 + 16 + 48 + 56.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true);
            List.Enumerator<T> val_9 = val_21.GetEnumerator();
            val_27 = 1152921524349663136;
            label_44:
            if(((-399618912) & 1) == 0)
            {
                goto label_32;
            }
            
            string val_12 = val_11.丐丏七丌丕丗业且上();
            if(val_12.gameObject.activeSelf == false)
            {
                goto label_44;
            }
            
            val_21 = val_12.GetComponent<MapPreviewController>();
            if(val_21 == 0)
            {
                goto label_44;
            }
            
            if(val_15.eventContainerDefault.activeSelf != true)
            {
                    if(val_15.eventContainerRating.activeSelf == false)
            {
                goto label_44;
            }
            
            }
            
            val_28 = static_value_081DACA8;
            val_28 = static_value_081DACA8;
            val_27 = val_15.sceneMapName;
            static_value_081DACA8 + 184 + 16.丆丒丆丂与丈上丏丕(丞丁丑丏丄丏七丂不:  val_27, 丛且丞与丕业下丏丞:  0);
            val_21.业丘丙丁丞丟丑丙丆();
            label_32:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal override bool 丅丂与丈下东三不丟()
        {
            return true;
        }
        public 丅丌丞丟世丆丞下上()
        {
        
        }
    
    }

}
