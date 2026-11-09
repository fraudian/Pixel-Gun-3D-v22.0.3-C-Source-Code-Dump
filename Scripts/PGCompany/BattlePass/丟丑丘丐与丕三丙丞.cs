using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class 丟丑丘丐与丕三丙丞 : 丘丄上丏不丝不丐丐
    {
        // Fields
        private CategoryNames 丌丂丕丘丌丟万丌七;
        
        // Methods
        internal 丟丑丘丐与丕三丙丞(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            this.丌丂丕丘丌丟万丌七 = 0;
            goto typeof(PGCompany.BattlePass.丟丑丘丐与丕三丙丞).__il2cppRuntimeField_1B8;
        }
        internal override void 丈丗丝丂丝丑上三丌()
        {
            WeaponManager.丗世丁与丗丂东东丙(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且>(object:  this, method:  System.Void PGCompany.BattlePass.丟丑丘丐与丕三丙丞::七丂七专丐七丙丗丂(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)));
        }
        internal override void 丞东丗不业丄丒丙丄(System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
        {
            var val_3;
            System.Object[] val_14;
            var val_15;
            val_14 = this;
            this.丞东丗不业丄丒丙丄(丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
            if(丗丟上上丒丐丗丞丙 == null)
            {
                goto label_1;
            }
            
            List.Enumerator<T> val_1 = 丗丟上上丒丐丗丞丙.GetEnumerator();
            val_15 = 1;
            label_29:
            if(((-419942320) & 1) == 0)
            {
                goto label_2;
            }
            
            if((((val_3.丐丏七丌丕丗业且上() == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true)) || ((System.String.Equals(a:  val_4.m_stringLength, b:  "weaponSlot", comparisonType:  5)) == false)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.m_stringLength)) == true))
            {
                goto label_29;
            }
            
            this.丌丂丕丘丌丟万丌七 = null;
            goto label_29;
            label_1:
            val_14 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeConditionUpgradeWeapon UpdateParams parameters == null", args:  val_14);
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 七丂七专丐七丙丗丂(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == true)
            {
                    return;
            }
            
            if(this.丌丂丕丘丌丟万丌七 != 1)
            {
                    if(丆丐七世世且丏丐业 == null)
            {
                    return;
            }
            
                if(this.丌丂丕丘丌丟万丌七 != (丆丐七世世且丏丐业.万上丄下业丛丌不丈() - 1))
            {
                    return;
            }
            
            }
            
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
            this.丐三上丏丈丕且且丞();
        }
        internal override void 丞上丝丗七丁七丑丘()
        {
            WeaponManager.丅万丑且三丁丑丛世(丙业与丙丗丝不丈东:  new System.Action<三丅丁丗丗丝丂万且>(object:  this, method:  System.Void PGCompany.BattlePass.丟丑丘丐与丕三丙丞::七丂七专丐七丙丗丂(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)));
        }
    
    }

}
