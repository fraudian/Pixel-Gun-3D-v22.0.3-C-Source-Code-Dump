using UnityEngine;

namespace PGCompany
{
    public class LogFilesBrowserInDevConsole : PGBehaviour
    {
        // Fields
        private UIScrollView _scrollView;
        private UnityEngine.GameObject _scrollItemExample;
        private UIButton _shareButton;
        private UnityEngine.GameObject _undetectLabel;
        private System.Collections.Generic.List<string> 丙且万上丗丑丆丘上;
        private string 世丈专丟丛丟专与丘;
        private System.Collections.Generic.List<string> 丗丘丟三下与三东丗;
        
        // Methods
        private void Awake()
        {
            this.丗丘丟三下与三东丗 = System.Linq.Enumerable.ToList<System.String>(source:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.丑七不且上丗丁一世().且丒一丏且丂丂丌与());
            this._undetectLabel.SetActive(value:  false);
            if(this.丗丘丟三下与三东丗.Count >= 1)
            {
                    this.丑一丈丞世丈丞丘丒(世一万东丐丑丆丆丗:  public System.Int32 System.Collections.Generic.List<System.String>::get_Count());
                return;
            }
            
            this._undetectLabel.SetActive(value:  true);
        }
        private void OnEnable()
        {
            this._scrollView.ResetPosition();
        }
        public void U_ShareLogFile()
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    System.Diagnostics.Process val_4 = System.Diagnostics.Process.Start(fileName:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.丑七不且上丗丁一世().丄世世专下丂丙世丗(丝丈丝丆世丁丄专丂:  this.世丈专丟丛丟专与丘));
                return;
            }
            
            new NativeShare() = new NativeShare();
            new NativeShare().AddFile(filePath:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.丑七不且上丗丁一世().丄世世专下丂丙世丗(丝丈丝丆世丁丄专丂:  this.世丈专丟丛丟专与丘), mime:  0).Share();
        }
        public void OpenDirectory()
        {
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            System.Diagnostics.Process val_3 = System.Diagnostics.Process.Start(fileName:  PGCompany.WebSocket.丛丈七丕三丛与丗丐.世丌丝丝专一丙丌丙());
        }
        private void 丑一丈丞世丈丞丘丒(System.Collections.Generic.List<string> 世一万东丐丑丆丆丗)
        {
            var val_15;
            this._scrollView.ResetPosition();
            val_15 = 0;
            goto label_2;
            label_19:
            .丝且与丝丒丟万丁专 = this;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._scrollItemExample, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, parent:  this.transform);
            .丒世丅业丝东下与丗 = val_5;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            (LogFilesBrowserInDevConsole.丗丛丘丑丐不丌丑丙)[1152921555754630512].丒世丅业丝东下与丗.GetComponent<LogFileToggle>().万业三丏丄丗丝上丈(丙业与丙丗丝不丈东:  this.丗丘丟三下与三东丗.Item[0]);
            UIButton val_12 = (LogFilesBrowserInDevConsole.丗丛丘丑丐不丌丑丙)[1152921555754630512].丒世丅业丝东下与丗.GetComponent<UIButton>();
            System.Collections.Generic.List<EventDelegate> val_13 = new System.Collections.Generic.List<EventDelegate>();
            val_13.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  new LogFilesBrowserInDevConsole.丗丛丘丑丐不丌丑丙(), 丛丌丙世专世东丕下:  System.Void LogFilesBrowserInDevConsole.丗丛丘丑丐不丌丑丙::丐东丏丐世且不七业())));
            val_15 = 1;
            val_12.onClick = val_13;
            label_2:
            if(val_15 < this.丗丘丟三下与三东丗.Count)
            {
                goto label_19;
            }
        
        }
        public void OnScrollItemClicked(UnityEngine.GameObject 丞丙丐不东丐丌丆丒)
        {
            this._shareButton.UpdateColor(丌丝丌丁下丐丞丆一:  true);
            this.世丈专丟丛丟专与丘 = 丞丙丐不东丐丌丆丒.GetComponent<LogFileToggle>().丌丏丅业不丗且丘业();
        }
        public LogFilesBrowserInDevConsole()
        {
        
        }
    
    }

}
