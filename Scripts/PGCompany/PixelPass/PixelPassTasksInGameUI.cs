using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class PixelPassTasksInGameUI : PGBehaviour
    {
        // Fields
        private PixelPassTaskView _taskView;
        private float _seconds;
        private GuiApplyersGroup _guiApplyersGroup;
        private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
        private UnityEngine.Coroutine 东丄丑业丄丗丛丒丞;
        private System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丕丛丅专万丁万东一;
        private PGCompany.PixelPass.一万丄一丌丆业丐丅 与丌万不业与万万丅;
        private int 下丙丈丈专与专丑丝;
        
        // Methods
        private void OnEnable()
        {
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() == false)
            {
                    return;
            }
            
            if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丟丂下七且七东丛丞() != true)
            {
                    if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() == false)
            {
                    return;
            }
            
            }
            
            PGCompany.PixelPass.丘丏丅丆丑下业丙七 val_5 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            this.丑与万三丐丒丏一专 = val_5.<丈丏丑不东业丟丗丘>k__BackingField;
            if((val_5.<丈丏丑不东业丟丗丘>k__BackingField) != null)
            {
                    PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.下丒与丈世七丈丑丒(丈丂七世丟丞丂丗丒:  val_5.<丈丏丑不东业丟丗丘>k__BackingField, 专与万丐七丌丐丁丂:  this._guiApplyersGroup);
            }
            
            if(this.丕丛丅专万丁万东一 != null)
            {
                    this.丕丛丅专万丁万东一.Clear();
            }
            
            this.丂丁丈丟丟丘与丑万();
        }
        private void 丂丁丈丟丟丘与丑万()
        {
            this.下丙丈丈专与专丑丝 = 0;
            this.丕丛丅专万丁万东一 = PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丙七丕东丅与丈三不(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗());
            this.与丌万不业与万万丅 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  false);
            if(this.东丄丑业丄丗丛丒丞 != null)
            {
                    this.StopCoroutine(routine:  this.东丄丑业丄丗丛丒丞);
            }
            
            if(this.丕丛丅专万丁万东一.Count < 1)
            {
                    return;
            }
            
            this.下丙丈丈专与专丑丝 = UnityEngine.Random.Range(min:  0, max:  this.丕丛丅专万丁万东一.Count);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  true);
            this.东丄丑业丄丗丛丒丞 = this.StartCoroutine(routine:  this.丗丂三一上与与三丘());
        }
        private System.Collections.IEnumerator 丗丂三一上与与三丘()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PixelPassTasksInGameUI.与东丅业丅丄丘丌世();
        }
        private void 世七丑且丂丟丅丝丑()
        {
            int val_3 = this.下丙丈丈专与专丑丝;
            if(this.丕丛丅专万丁万东一.Count <= val_3)
            {
                    val_3 = 0;
                this.下丙丈丈专与专丑丝 = 0;
            }
            
            PGCompany.PixelPass.一万丄一丌丆业丐丅 val_2 = this.丕丛丅专万丁万东一.Item[0];
            this.与丌万不业与万万丅 = val_2;
            this._taskView.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  val_2);
            int val_3 = this.下丙丈丈专与专丑丝;
            val_3 = val_3 + 1;
            this.下丙丈丈专与专丑丝 = val_3;
        }
        public void U_ShowNextTask()
        {
            this.世七丑且丂丟丅丝丑();
        }
        private void OnDisable()
        {
            if(this.东丄丑业丄丗丛丒丞 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.东丄丑业丄丗丛丒丞);
        }
        private void 三丏丆丌丐上专丐丄()
        {
            if(this.东丄丑业丄丗丛丒丞 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.东丄丑业丄丗丛丒丞);
        }
        public PixelPassTasksInGameUI()
        {
            this._seconds = 0.5f;
        }
    
    }

}
