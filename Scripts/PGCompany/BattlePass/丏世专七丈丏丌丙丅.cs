using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丏世专七丈丏丌丙丅 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private int 丙丐一丕丗万丁下一;
        
        // Properties
        internal override int 丁丘丗丐万丑丗丈丛 { get; }
        internal override int 丗丅世丘丌丈丛丝丌 { get; }
        
        // Methods
        internal 丏世专七丈丏丌丙丅(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.丙丐一丕丗万丁下一 = 1;
            goto typeof(PGCompany.BattlePass.丏世专七丈丏丌丙丅).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丝丕东丂丏丄丛三一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.丏世专七丈丏丌丙丅::丏不七丒上下上与丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            MainMenuController.丄丈丝丕世丕且东丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.丏世专七丈丏丌丙丅::丞且丞丅丛三丕丄不()));
        }
        internal override int 丐丑七丐一丝七上七()
        {
            return (int)this.丙丐一丕丗万丁下一;
        }
        internal override int 丛三丙上丞丐三丘丛()
        {
            int val_10;
            var val_11;
            int val_12;
            val_10 = this;
            val_11 = 0;
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() != false)
            {
                    val_10 = ???;
            }
            else
            {
                    if((val_10 + 16) != 0)
            {
                    val_10 = val_10;
                val_12 = ExperienceController.丞丞丘业东丙丏七丌();
                int val_4 = UnityEngine.Mathf.Min(a:  val_12, b:  val_10);
                return (int)val_12;
            }
            
                val_12 = 0;
                return (int)val_12;
            }
        
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            System.Object[] val_15;
            var val_16;
            val_15 = this;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            val_16 = 1;
            label_27:
            if(((-433841200) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(((((val_4 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.String.Equals(a:  val_4.m_stringLength, b:  "wave_num", comparisonType:  5)) == false)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.Int32.TryParse(s:  val_4, style:  0, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) == false))
            {
                goto label_27;
            }
            
            this.丙丐一丕丗万丁下一 = 0;
            goto label_27;
            label_1:
            val_15 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionLevel UpdateParams parameters == null", args:  val_15);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丏不七丒上下上与丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_6;
            var val_7;
            if(true == 0)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            this.下三丐丄不丄万丗东();
            val_6 = null;
            val_6 = null;
            if(ExperienceController.sharedController != 0)
            {
                    val_7 = 0;
                int val_4 = ExperienceController.丞丞丘业东丙丏七丌();
            }
            else
            {
                    val_7 = 0;
            }
            
            if(ExperienceController.丞丞丘业东丙丏七丌() < this.丙丐一丕丗万丁下一)
            {
                    return;
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
        private void 丞且丞丅丛三丕丄不()
        {
            this.丏不七丒上下上与丗(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            MainMenuController.丌七丝与丂丒七丑丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.丏世专七丈丏丌丙丅::丞且丞丅丛三丕丄不()));
            Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丟世丁丛业丐业丙丕(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.BattlePass.丏世专七丈丏丌丙丅::丏不七丒上下上与丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        internal override void 丘丂丕丈且丆与丄丕()
        {
            this.丏不七丒上下上与丗(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
        }
    
    }

}
