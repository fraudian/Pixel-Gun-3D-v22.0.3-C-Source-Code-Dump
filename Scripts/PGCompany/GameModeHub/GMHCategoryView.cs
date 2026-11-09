using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHCategoryView : GMHEntityView
    {
        // Fields
        private PGCompany.GameModeHub.GMHCategorySelector categorySelector;
        private UnityEngine.GameObject tapRewardHolder;
        private PGCompany.InventoryItemView tapRewardView;
        private UnityEngine.GameObject rewardAnimationObject;
        private float animationTime;
        private TagSystem.CompoundTagBehaviour compoundTagBehaviour;
        
        // Properties
        private PGCompany.GameModeHub.丟与丗不不上丆丞三 七丌丌丏丗东丕且丅 { get; }
        
        // Methods
        private PGCompany.GameModeHub.丟与丗不不上丆丞三 丒万丕七专不丏丞丌()
        {
            var val_2 = 0;
            return (PGCompany.GameModeHub.丟与丗不不上丆丞三);
        }
        private void OnEnable()
        {
            PGCompany.GameModeHub.丘专丕丂且丅业三丁.丂下三东丘上丗丞丘(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.GameModeHub.GMHCategoryView::丛丙丘丑下丒上丅丌(string 丞丅上丏丂且下丅与)));
        }
        private void OnDisable()
        {
            PGCompany.GameModeHub.丘专丕丂且丅业三丁.且丗世三万专丈丟上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void PGCompany.GameModeHub.GMHCategoryView::丛丙丘丑下丒上丅丌(string 丞丅上丏丂且下丅与)));
        }
        internal override void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            if(this.compoundTagBehaviour != null)
            {
                    this.compoundTagBehaviour.与上丒丆丟与丘与丑();
            }
            
            this.丈且东丑丂且万丒丅(不丕三丌万丈丟丆世:  不丕三丌万丈丟丆世);
            if(this.compoundTagBehaviour != null)
            {
                    this.compoundTagBehaviour.丏丆下丌上丆丂丛丁(丆万一不丌且东丐丐:  PGCompany.GameModeHub.丂丕且丟丌丐万东丗.丘东丕下丄与业丞丅(丑丅七丅一丈丘丞七:  不丕三丌万丈丟丆世.下丄丈不与世丐业专));
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardAnimationObject, 丏业丟一东丂东丘丛:  false);
            丌东一万丗上丝丌三.丌丛东不丝三丒丌丅(丒丘丏上丙丟丑丕丈:  "GMHCategoryView_" + 0 + "_RewardAnimation");
        }
        internal override void 丝一丅丆三东丂丞七()
        {
            if(true == 0)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tapRewardHolder, 丏业丟一东丂东丘丛:  false);
            PGCompany.GameModeHub.世丘与丙丗且三且丗 val_1 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世();
            if(this.丒万丕七专不丏丞丌() == null)
            {
                goto label_5;
            }
            
            if((val_1.<丁丄丝一三丛万丞东>k__BackingField) != null)
            {
                goto label_17;
            }
            
            label_18:
            label_17:
            if((val_1.<丁丄丝一三丛万丞东>k__BackingField.不专上一丌丅世丅丈(七丆丒与丗丌丄且丂:  X21)) == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tapRewardHolder, 丏业丟一东丂东丘丛:  true);
            if(this.tapRewardView == 0)
            {
                    return;
            }
            
            PGCompany.GameModeHub.世丘与丙丗且三且丗 val_5 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世();
            this.tapRewardView.Setup(丈丄不七三万丄丁不:  val_5.<丁丄丝一三丛万丞东>k__BackingField.一且丞丈下丑东专丑(七丆丒与丗丌丄且丂:  this.丒万丕七专不丏丞丌()));
            return;
            label_5:
            if((val_1.<丁丄丝一三丛万丞东>k__BackingField) != null)
            {
                goto label_17;
            }
            
            goto label_18;
        }
        private void 丛丙丘丑下丒上丅丌(string 丞丅上丏丂且下丅与)
        {
            if(X8 == 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  X8 + 32, b:  丞丅上丏丂且下丅与)) == false)
            {
                goto typeof(PGCompany.GameModeHub.GMHCategoryView).__il2cppRuntimeField_198;
            }
        
        }
        public void SelectCategory()
        {
            object val_16;
            var val_18;
            val_16 = this;
            if(true == 0)
            {
                    return;
            }
            
            if((481925.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "locked")) != false)
            {
                    this.categorySelector.OnLockedCategoryClick(七丆丒与丗丌丄且丂:  this.丒万丕七专不丏丞丌());
                return;
            }
            
            PGCompany.GameModeHub.世丘与丙丗且三且丗 val_3 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世();
            if(this.丒万丕七专不丏丞丌() == null)
            {
                goto label_6;
            }
            
            if((val_3.<丁丄丝一三丛万丞东>k__BackingField) != null)
            {
                goto label_27;
            }
            
            label_28:
            label_27:
            if((val_3.<丁丄丝一三丛万丞东>k__BackingField.不专上一丌丅世丅丈(七丆丒与丗丌丄且丂:  X21)) != false)
            {
                    PGCompany.GameModeHub.世丘与丙丗且三且丗 val_6 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世();
                if((val_6.<丁丄丝一三丛万丞东>k__BackingField.与下丆与与丆丑上下(七丆丒与丗丌丄且丂:  this.丒万丕七专不丏丞丌())) == false)
            {
                    return;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardAnimationObject, 丏业丟一东丂东丘丛:  true);
                一丛丟世丗丈丘丏万 val_11 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "GMHCategoryView_" + 1 + "_RewardAnimation", 丘丁三丅丆与丆业业:  this.animationTime, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHCategoryView::丅丌丞丁万丞丟三丘()));
                return;
            }
            
            if((System.String.op_Equality(a:  this.丒万丕七专不丏丞丌(), b:  "Category03")) == false)
            {
                goto label_19;
            }
            
            val_18 = null;
            val_18 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != null)
            {
                    MainMenuController.丄丞丁丈与业上丞丟.OnClickMiniGamesButton();
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.东丆丐世丕丞万丟上(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丆丒与丗丌丄且丂:  "Category03", 丂丛丑东不丅丈一东:  "Campaign");
            return;
            label_6:
            if((val_3.<丁丄丝一三丛万丞东>k__BackingField) != null)
            {
                goto label_27;
            }
            
            goto label_28;
            label_19:
            val_16 = this.丒万丕七专不丏丞丌();
            this.categorySelector.丙三东丞丈东丘丞丛 = val_16;
            if(this.categorySelector.丐丌三丈东丘丝丑世 == null)
            {
                    return;
            }
            
            this.categorySelector.丐丌三丈东丘丝丑世.Invoke();
        }
        public GMHCategoryView()
        {
            this.animationTime = 0.75f;
            val_1 = new PGBehaviour();
        }
        private void 丅丌丞丁万丞丟三丘()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardAnimationObject, 丏业丟一东丂东丘丛:  false);
        }
    
    }

}
