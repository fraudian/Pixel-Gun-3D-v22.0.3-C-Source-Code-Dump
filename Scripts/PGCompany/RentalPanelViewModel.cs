using UnityEngine;

namespace PGCompany
{
    internal sealed class RentalPanelViewModel : MonoBehaviour
    {
        // Fields
        private static readonly PGCompany.RentalOptionViewModel[] 世丅且丈一丅七丗七;
        private static UnityEngine.WaitForSecondsRealtime 丟上丞丆专一丟丈万;
        private static UnityEngine.WaitForSecondsRealtime 丝丞下下业业世专专;
        private PGCompany.RentalOptionViewModel[] _options;
        private UILabel _timerLabel;
        private int 丆专一业丗丙万东且;
        private UnityEngine.Coroutine 丂七下世丟丞丆下丞;
        
        // Properties
        internal PGCompany.RentalOptionViewModel[] 业七丗专下丝七丘丄 { get; }
        private static UnityEngine.WaitForSecondsRealtime 丏三不与世丐东丌万 { get; }
        private static UnityEngine.WaitForSecondsRealtime 东丁七七丞丙丐下丐 { get; }
        
        // Methods
        internal PGCompany.RentalOptionViewModel[] 丝业一丝下丙上丞丙()
        {
            var val_1;
            PGCompany.RentalOptionViewModel[] val_2;
            var val_3;
            val_1 = this;
            val_2 = this._options;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            val_1 = 1152921505567334400;
            val_3 = null;
            val_3 = null;
            val_2 = PGCompany.RentalPanelViewModel.世丅且丈一丅七丗七;
            return val_2;
        }
        private static UnityEngine.WaitForSecondsRealtime 丂丒三一丈一业丘丝()
        {
            var val_2;
            UnityEngine.WaitForSecondsRealtime val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.RentalPanelViewModel.丟上丞丆专一丟丈万;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            UnityEngine.WaitForSecondsRealtime val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  0.5f);
            val_4 = null;
            val_4 = null;
            PGCompany.RentalPanelViewModel.丟上丞丆专一丟丈万 = val_3;
            return val_3;
        }
        private static UnityEngine.WaitForSecondsRealtime 丙丑万丂丁东且丏业()
        {
            var val_2;
            UnityEngine.WaitForSecondsRealtime val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.RentalPanelViewModel.丝丞下下业业世专专;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            UnityEngine.WaitForSecondsRealtime val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
            val_4 = null;
            val_4 = null;
            PGCompany.RentalPanelViewModel.丝丞下下业业世专专 = val_3;
            return val_3;
        }
        public void OnClick(PGCompany.RentalOptionViewModel 业三万丂三专丆丆丟)
        {
            PGCompany.RentalOptionViewModel val_7 = 业三万丂三专丆丆丟;
            if(val_7 == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "[RentalPanelViewModel] OnClick => selectedOption: null");
            }
            
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    object[] val_3 = new object[1];
                val_3[0] = 业三万丂三专丆丆丟._index;
                UnityEngine.Debug.LogFormat(format:  "[RentalPanelViewModel] OnClick => Index: {0}", args:  val_3);
            }
            
            ButtonClickSound.丁业上丏不丕三丗不();
            if(this.丆专一业丗丙万东且 == 业三万丂三专丆丆丟._index)
            {
                    val_7 = this.transform;
                Rilisoft.ItemViewer val_6 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  val_7, 丕丁下丌不万丅丞丛:  业三万丂三专丆丆丟.丅丗世丝丌与与丕下.与不丞丑七丘丁丂丛(), 丅三丟世下丞丝丙万:  0, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  false, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
                return;
            }
            
            this.丐丌与丘丂丆丆丑丕(与丙不丁丘丝丏东丘:  业三万丂三专丆丆丟._index, 一与上丘丂丘上丘丙:  false);
        }
        internal bool 万丄东万丟下万丌不(out 三丅丁丗丗丝丂万且 东且丁丆丛丁丏丘且)
        {
            if((this._options == null) || (this.丆专一业丗丙万东且 > this._options.Length))
            {
                goto label_2;
            }
            
            if(this._options[this.丆专一业丗丙万东且] != 0)
            {
                goto label_6;
            }
            
            label_2:
            label_8:
            东且丁丆丛丁丏丘且 = 0;
            return false;
            label_6:
            var val_2 = (this._options[this.丆专一业丗丙万东且][0].丅丗世丝丌与与丕下 != 0) ? 1 : 0;
            goto label_8;
        }
        internal 三丅丁丗丗丝丂万且 丑丝上丙七与丕丗丅()
        {
            三丅丁丗丗丝丂万且 val_1 = 0;
            return (三丅丁丗丗丝丂万且)((this.万丄东万丟下万丌不(东且丁丆丛丁丏丘且: out  val_1)) != true) ? (val_1) : 0;
        }
        internal void 且丙七丄丝丄丅一丑(System.Collections.Generic.IList<三丅丁丗丗丝丂万且> 一丘丄丄丘丌东丐东)
        {
            var val_6;
            三丅丁丗丗丝丂万且 val_9;
            if(一丘丄丄丘丌东丐东 == null)
            {
                goto label_1;
            }
            
            PGCompany.RentalOptionViewModel[] val_1 = this.丝业一丝下丙上丞丙();
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_6 = 0;
            if(val_1.Length == 0)
            {
                    return;
            }
            
            var val_11 = 0;
            label_18:
            if(val_11 >= val_4.Length)
            {
                    val_6 = 0;
            }
            
            if(val_11 >= 一丘丄丄丘丌东丐东.Count)
            {
                goto label_10;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_6 = 0;
            goto label_14;
            label_10:
            val_9 = 0;
            goto label_16;
            label_14:
            val_9 = 一丘丄丄丘丌东丐东.Item[0];
            label_16:
            this.丝业一丝下丙上丞丙()[0].且丙七丄丝丄丅一丑(丝丂丁丌丆三丆专且:  val_9);
            val_11 = val_11 + 1;
            if(val_11 != val_1.Length)
            {
                goto label_18;
            }
            
            return;
            label_1:
            System.ArgumentNullException val_7 = new System.ArgumentNullException(paramName:  "itemRecords");
        }
        private void OnEnable()
        {
            this.丐丌与丘丂丆丆丑丕(与丙不丁丘丝丏东丘:  this.丆专一业丗丙万东且, 一与上丘丂丘上丘丙:  true);
            if(this.丂七下世丟丞丆下丞 != null)
            {
                    this.StopCoroutine(routine:  this.丂七下世丟丞丆下丞);
                this.丂七下世丟丞丆下丞 = 0;
            }
            
            this.丂七下世丟丞丆下丞 = this.StartCoroutine(routine:  this.不万丙丏七丈丝丛丏());
        }
        private void 丐丌与丘丂丆丆丑丕(int 与丙不丁丘丝丏东丘, bool 一与上丘丂丘上丘丙)
        {
            PGCompany.RentalOptionViewModel val_5;
            int val_6;
            val_5 = 一与上丘丂丘上丘丙;
            if(this.丆专一业丗丙万东且 == 与丙不丁丘丝丏东丘)
            {
                    if(val_5 == false)
            {
                    return;
            }
            
            }
            
            val_5 = this.丝业一丝下丙上丞丙();
            if(val_1.Length != 0)
            {
                    var val_5 = 0;
                do
            {
                val_5 = this.丝业一丝下丙上丞丙()[0];
                if(val_5 != 0)
            {
                    if(val_5 != null)
            {
                    val_6 = val_2[0x0][0]._index;
            }
            else
            {
                    val_6 = 28563616;
            }
            
                val_5.SetSelected(丛丗七丅下丞丗且丐:  (28563616 == 与丙不丁丘丝丏东丘) ? 1 : 0);
            }
            
                val_5 = val_5 + 1;
            }
            while(val_1.Length != val_5);
            
            }
            
            this.丆专一业丗丙万东且 = 与丙不丁丘丝丏东丘;
        }
        private bool 丐丟丈丘业丁不丁丙(out 三丅丁丗丗丝丂万且 东且丁丆丛丁丏丘且)
        {
            东且丁丆丛丁丏丘且 = 0;
            return false;
        }
        private System.Collections.IEnumerator 不万丙丏七丈丝丛丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new RentalPanelViewModel.丆不丗丌世丙丛不万();
        }
        private bool 丐与业与三丌上与且()
        {
            var val_12;
            System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)Rilisoft.TryGuns_2_0_Controller.丑七不且上丗丁一世().与丈下不丏丁丛丒丐());
            if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_3._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                goto label_6;
            }
            
            string val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6901");
            if((System.String.IsNullOrEmpty(value:  val_5)) == false)
            {
                goto label_9;
            }
            
            label_6:
            bool val_7 = this.三丘丈丞世丛上世世();
            val_12 = 0;
            return (bool)val_12;
            label_9:
            bool val_11 = this.丟丛三与且下丐丟七(丕丗丘丑丛与丑业丒:  System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  val_5, arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_3._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
            val_12 = 1;
            return (bool)val_12;
        }
        private bool 三丘丈丞世丛上世世()
        {
            this._timerLabel.text = System.String.alignConst;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            return false;
        }
        private bool 丟丛三与且下丐丟七(string 丕丗丘丑丛与丑业丒)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            this._timerLabel.text = 丕丗丘丑丛与丑业丒;
            return true;
        }
        public RentalPanelViewModel()
        {
        
        }
        private static RentalPanelViewModel()
        {
            PGCompany.RentalPanelViewModel.世丅且丈一丅七丗七 = new PGCompany.RentalOptionViewModel[0];
        }
    
    }

}
