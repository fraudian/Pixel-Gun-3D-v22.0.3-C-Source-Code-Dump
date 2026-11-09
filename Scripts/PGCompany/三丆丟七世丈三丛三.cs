using UnityEngine;

namespace PGCompany
{
    internal sealed class 三丆丟七世丈三丛三 : 丟丟丈丙万丂上与不
    {
        // Fields
        private Rilisoft.七丕丟丏三丈一丄世 一丗世丈丞丅丈且丟;
        private Rilisoft.七丕丟丏三丈一丄世 丂丄丁业东三丈东丛;
        
        // Methods
        public 三丆丟七世丈三丛三(string 丏万且丈丙丁丁且世, Rilisoft.七丕丟丏三丈一丄世 丐与且一一不万丅下, Rilisoft.七丕丟丏三丈一丄世 世丛丛丑丒丏丄丈丂, System.Func<ConnectScene> 丆世业世上丄丈下下)
        {
            null = null;
            this.一丗世丈丞丅丈且丟 = 丐与且一一不万丅下;
            this.丂丄丁业东三丈东丛 = 世丛丛丑丒丏丄丈丂;
            mem[1152921556060490200] = 丆世业世上丄丈下下;
            mem[1152921556060490208] = 1;
        }
        protected override UnityEngine.Transform 丟七丏丕丆七下专与()
        {
            UnityEngine.Object val_5;
            if(86090 != 0)
            {
                    ConnectScene val_1 = 86090.Invoke();
                val_5 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  val_1.connectSceneMainMenu.categoryButtonsController.buttons, predicate:  new System.Func<BtnCategory, System.Boolean>(object:  this, method:  System.Boolean PGCompany.三丆丟七世丈三丛三::三丂丏丘丛上丘丐丒(BtnCategory 三丟东丕丄丄下下丑)));
            }
            else
            {
                    val_5 = 0;
            }
            
            if(val_5 == 0)
            {
                    return 0;
            }
            
            if(val_5 != 0)
            {
                    return val_5.transform;
            }
            
            return val_5.transform;
        }
        protected override UnityEngine.Transform 丄七丙丅专丈不丈东()
        {
            UnityEngine.Object val_5;
            if(86088 != 0)
            {
                    ConnectScene val_1 = 86088.Invoke();
                val_5 = System.Linq.Enumerable.FirstOrDefault<BtnCategory>(source:  val_1.connectSceneMainMenu.categoryButtonsController.buttons, predicate:  new System.Func<BtnCategory, System.Boolean>(object:  this, method:  System.Boolean PGCompany.三丆丟七世丈三丛三::七三丄且上东丝东丂(BtnCategory 三丟东丕丄丄下下丑)));
            }
            else
            {
                    val_5 = 0;
            }
            
            if(val_5 == 0)
            {
                    return 0;
            }
            
            if(val_5 != 0)
            {
                    return val_5.transform;
            }
            
            return val_5.transform;
        }
        protected override UnityEngine.Vector3 丁东丗丂丐丅丈业丄()
        {
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = this;
            if(this == 0)
            {
                goto label_3;
            }
            
            val_9 = this.GetComponent<UIWidget>();
            if(val_9 != 0)
            {
                goto label_7;
            }
            
            label_3:
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_7:
            if(null <= 1)
            {
                    val_10 = 0;
            }
            
            if(null == null)
            {
                    val_11 = 0;
            }
            
            if(null <= 2)
            {
                    val_12 = 0;
            }
            
            val_9 = val_9;
            float val_7 = (S8 - S9) * (-0.5f);
            float val_8 = (S10 - S0) * (-0.5f);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected override UnityEngine.Vector3 世一万丗世丈丈丂丘()
        {
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = this;
            if(this == 0)
            {
                goto label_3;
            }
            
            val_9 = this.GetComponent<UIWidget>();
            if(val_9 != 0)
            {
                goto label_7;
            }
            
            label_3:
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            label_7:
            if(null <= 1)
            {
                    val_10 = 0;
            }
            
            if(null == null)
            {
                    val_11 = 0;
            }
            
            if(null <= 2)
            {
                    val_12 = 0;
            }
            
            val_9 = val_9;
            float val_7 = (S8 - S9) * (-0.5f);
            float val_8 = (S10 - S0) * (-0.5f);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private bool 三丂丏丘丛上丘丐丒(BtnCategory 三丟东丕丄丄下下丑)
        {
            return (bool)(三丟东丕丄丄下下丑.业丄丄且丕丕不一万() == this.一丗世丈丞丅丈且丟) ? 1 : 0;
        }
        private bool 七三丄且上东丝东丂(BtnCategory 三丟东丕丄丄下下丑)
        {
            return (bool)(三丟东丕丄丄下下丑.业丄丄且丕丕不一万() == this.丂丄丁业东三丈东丛) ? 1 : 0;
        }
    
    }

}
