using UnityEngine;

namespace Rilisoft
{
    internal class LobbyCraftCameraSettings : MonoBehaviour
    {
        // Fields
        private UIToggle _toggleCommon;
        private UIToggle _toggleHight;
        private UIToggle _toggleLow;
        private MainMenuHeroCamera.业丟丝丗且丌丌东且 丄东丕上上不业不七;
        
        // Methods
        private void OnEnable()
        {
            UIToggle val_9;
            业丟丝丗且丌丌东且 val_2 = MainMenuHeroCamera.丑七不且上丗丁一世().丈丁丕丑丟下丟丑丏();
            if(val_2 == 2)
            {
                goto label_2;
            }
            
            if(val_2 == 1)
            {
                goto label_3;
            }
            
            if(val_2 != 0)
            {
                goto label_4;
            }
            
            val_9 = this._toggleCommon;
            if(val_9 != null)
            {
                goto label_13;
            }
            
            goto label_14;
            label_2:
            val_9 = this._toggleHight;
            if(val_9 != null)
            {
                goto label_13;
            }
            
            label_14:
            label_13:
            val_9.Set(丏业丟一东丂东丘丛:  true);
            label_4:
            EventDelegate val_4 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this._toggleCommon.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftCameraSettings::三三业丝丅丕业丙丆()));
            EventDelegate val_6 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this._toggleLow.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftCameraSettings::与丅与丑不下丙与丐()));
            EventDelegate val_8 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this._toggleHight.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftCameraSettings::与丐丐下万丕丝丏上()));
            this.丄东丕上上不业不七 = val_2;
            return;
            label_3:
            if(this._toggleLow != null)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        private void OnDisable()
        {
            bool val_2 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  this._toggleCommon.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftCameraSettings::三三业丝丅丕业丙丆()));
            bool val_4 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  this._toggleLow.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftCameraSettings::与丅与丑不下丙与丐()));
            bool val_6 = EventDelegate.Remove(丝丘丑业丛万丞丌丝:  this._toggleHight.onChange, 业丏丈世世世丞丒世:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.LobbyCraftCameraSettings::与丐丐下万丕丝丏上()));
            业丟丝丗且丌丌东且 val_8 = MainMenuHeroCamera.丑七不且上丗丁一世().丈丁丕丑丟下丟丑丏();
            if(this.丄东丕上上不业不七 == val_8)
            {
                    return;
            }
            
            Rilisoft.一丟专且三万丞丁丂.丈丆丟一丐万一丈丅(丟丕上丂丏一丄丁专:  val_8);
        }
        private void 东万丅丛万专丈丅丞(MainMenuHeroCamera.业丟丝丗且丌丌东且 丟丕上丂丏一丄丁专)
        {
            if(MainMenuHeroCamera.丑七不且上丗丁一世().丈丁丕丑丟下丟丑丏() == 丟丕上丂丏一丄丁专)
            {
                    return;
            }
            
            MainMenuHeroCamera.丑七不且上丗丁一世().丏且丑丕丈丗丂丐丘(丟丕上丂丏一丄丁专:  丟丕上丂丏一丄丁专, 丘丕丑一丅丆丝与丁:  true, 丈上不丆丑丑三专丗:  false);
        }
        private void 三三业丝丅丕业丙丆()
        {
            bool val_1 = this._toggleCommon.value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.东万丅丛万专丈丅丞(丟丕上丂丏一丄丁专:  0);
        }
        private void 与丅与丑不下丙与丐()
        {
            bool val_1 = this._toggleLow.value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.东万丅丛万专丈丅丞(丟丕上丂丏一丄丁专:  1);
        }
        private void 与丐丐下万丕丝丏上()
        {
            bool val_1 = this._toggleHight.value;
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.东万丅丛万专丈丅丞(丟丕上丂丏一丄丁专:  2);
        }
        public LobbyCraftCameraSettings()
        {
        
        }
    
    }

}
