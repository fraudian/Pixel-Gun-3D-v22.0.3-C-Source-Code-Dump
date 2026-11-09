using UnityEngine;

namespace Rilisoft
{
    public class GameEventFakeDropView : GameEventItemScrollRewardGui
    {
        // Fields
        private float 不丄丟丞丄万不丈丌;
        public float AutoHideDelay;
        
        // Methods
        public void Show(Rilisoft.GameEventItemData 下丅丙一丂丗丅丝七)
        {
            this.不丄丟丞丄万不丈丌 = this.AutoHideDelay;
            this.gameObject.SetActive(value:  true);
            goto typeof(Rilisoft.GameEventFakeDropView).__il2cppRuntimeField_168;
        }
        private void Update()
        {
            float val_3 = this.不丄丟丞丄万不丈丌;
            if(val_3 <= 0f)
            {
                    this.gameObject.SetActive(value:  false);
                val_3 = this.不丄丟丞丄万不丈丌;
            }
            
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_3 - val_2;
            this.不丄丟丞丄万不丈丌 = val_2;
        }
        public GameEventFakeDropView()
        {
            this.AutoHideDelay = 1.5f;
        }
    
    }

}
