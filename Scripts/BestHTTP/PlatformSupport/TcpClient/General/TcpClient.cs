using UnityEngine;

namespace BestHTTP.PlatformSupport.TcpClient.General
{
    public class TcpClient : IDisposable
    {
        // Fields
        private System.Net.Sockets.NetworkStream stream;
        private bool active;
        private System.Net.Sockets.Socket client;
        private bool disposed;
        private BestHTTP.PlatformSupport.TcpClient.General.TcpClient.Properties values;
        private int recv_timeout;
        private int send_timeout;
        private int recv_buffer_size;
        private int send_buffer_size;
        private System.Net.Sockets.LingerOption linger_state;
        private bool no_delay;
        private System.TimeSpan <ConnectTimeout>k__BackingField;
        
        // Properties
        protected bool Active { get; set; }
        public System.Net.Sockets.Socket Client { get; set; }
        public int Available { get; }
        public bool Connected { get; }
        public bool ExclusiveAddressUse { get; set; }
        public System.Net.Sockets.LingerOption LingerState { get; set; }
        public bool NoDelay { get; set; }
        public int ReceiveBufferSize { get; set; }
        public int ReceiveTimeout { get; set; }
        public int SendBufferSize { get; set; }
        public int SendTimeout { get; set; }
        public System.TimeSpan ConnectTimeout { get; set; }
        
        // Methods
        private void Init(System.Net.Sockets.AddressFamily family)
        {
            this.active = false;
            if(this.client != null)
            {
                    this.client.Close();
                this.client = 0;
            }
            
            this.client = new System.Net.Sockets.Socket(addressFamily:  family, socketType:  1, protocolType:  6);
        }
        public TcpClient()
        {
            this.Init(family:  2);
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  2);
            this.<ConnectTimeout>k__BackingField = val_1;
        }
        public TcpClient(System.Net.Sockets.AddressFamily family)
        {
            if(family != 2)
            {
                    if(family != 23)
            {
                goto label_2;
            }
            
            }
            
            this.Init(family:  family);
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  2);
            this.<ConnectTimeout>k__BackingField = val_1;
            return;
            label_2:
            System.ArgumentException val_2 = new System.ArgumentException(message:  "Family must be InterNetwork or InterNetworkV6", paramName:  "family");
        }
        public TcpClient(System.Net.IPEndPoint localEP)
        {
            this.Init(family:  localEP);
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  2);
            this.<ConnectTimeout>k__BackingField = val_1;
        }
        public TcpClient(string hostname, int port)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  2);
            this.<ConnectTimeout>k__BackingField = val_1;
            this.Connect(hostname:  hostname, port:  port);
        }
        protected bool get_Active()
        {
            return (bool)this.active;
        }
        protected void set_Active(bool value)
        {
            this.active = value;
        }
        public System.Net.Sockets.Socket get_Client()
        {
            return (System.Net.Sockets.Socket)this.client;
        }
        public void set_Client(System.Net.Sockets.Socket value)
        {
            this.client = value;
            this.stream = 0;
        }
        public int get_Available()
        {
            if(this.client != null)
            {
                    return this.client.Available;
            }
            
            return this.client.Available;
        }
        public bool get_Connected()
        {
            if(this.client != null)
            {
                    return this.client.Connected;
            }
            
            return this.client.Connected;
        }
        public bool IsConnected()
        {
            System.Net.Sockets.Socket val_4;
            var val_5;
            val_4 = this;
            if((this.client.Poll(microSeconds:  1, mode:  0)) != false)
            {
                    val_4 = this.client;
                var val_3 = (val_4.Available != 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 1;
            return (bool)val_5;
        }
        public bool get_ExclusiveAddressUse()
        {
            if(this.client != null)
            {
                    return this.client.ExclusiveAddressUse;
            }
            
            return this.client.ExclusiveAddressUse;
        }
        public void set_ExclusiveAddressUse(bool value)
        {
            value = value;
            this.client.ExclusiveAddressUse = value;
        }
        internal void SetTcpClient(System.Net.Sockets.Socket s)
        {
            this.client = s;
            this.stream = 0;
        }
        public System.Net.Sockets.LingerOption get_LingerState()
        {
            System.Net.Sockets.Socket val_4;
            System.Net.Sockets.LingerOption val_5;
            val_4 = this;
            if((this.values & 1) == 0)
            {
                    val_4 = this.client;
                if((val_4.GetSocketOption(optionLevel:  65535, optionName:  128)) == null)
            {
                    return val_5;
            }
            
                val_5 = 0;
                return val_5;
            }
            
            val_5 = this.linger_state;
            return val_5;
        }
        public void set_LingerState(System.Net.Sockets.LingerOption value)
        {
            if(this.client.Connected != false)
            {
                    this.client.SetSocketOption(optionLevel:  65535, optionName:  128, optionValue:  value);
                return;
            }
            
            Properties val_2 = this.values;
            this.linger_state = value;
            val_2 = val_2 | 1;
            this.values = val_2;
        }
        public bool get_NoDelay()
        {
            System.Net.Sockets.Socket val_2;
            bool val_3;
            val_2 = this;
            if((this.values & 2) == 0)
            {
                    val_2 = this.client;
                object val_1 = val_2.GetSocketOption(optionLevel:  6, optionName:  1);
                return val_3;
            }
            
            val_3 = this.no_delay;
            return val_3;
        }
        public void set_NoDelay(bool value)
        {
            if(this.client.Connected != false)
            {
                    this.client.SetSocketOption(optionLevel:  6, optionName:  1, optionValue:  value);
                return;
            }
            
            Properties val_4 = this.values;
            this.no_delay = value;
            val_4 = val_4 | 2;
            this.values = val_4;
        }
        public int get_ReceiveBufferSize()
        {
            System.Net.Sockets.Socket val_2;
            int val_3;
            val_2 = this;
            if((this.values & 4) == 0)
            {
                    val_2 = this.client;
                object val_1 = val_2.GetSocketOption(optionLevel:  65535, optionName:  2);
                return val_3;
            }
            
            val_3 = this.recv_buffer_size;
            return val_3;
        }
        public void set_ReceiveBufferSize(int value)
        {
            if(this.client.Connected != false)
            {
                    this.client.SetSocketOption(optionLevel:  65535, optionName:  2, optionValue:  value);
                return;
            }
            
            Properties val_2 = this.values;
            this.recv_buffer_size = value;
            val_2 = val_2 | 4;
            this.values = val_2;
        }
        public int get_ReceiveTimeout()
        {
            System.Net.Sockets.Socket val_2;
            int val_3;
            val_2 = this;
            if((this.values & 8) == 0)
            {
                    val_2 = this.client;
                object val_1 = val_2.GetSocketOption(optionLevel:  65535, optionName:  6);
                return val_3;
            }
            
            val_3 = this.recv_timeout;
            return val_3;
        }
        public void set_ReceiveTimeout(int value)
        {
            if(this.client.Connected != false)
            {
                    this.client.SetSocketOption(optionLevel:  65535, optionName:  6, optionValue:  value);
                return;
            }
            
            Properties val_2 = this.values;
            val_2 = val_2 | 8;
            this.values = val_2;
            this.recv_timeout = value;
        }
        public int get_SendBufferSize()
        {
            System.Net.Sockets.Socket val_2;
            int val_3;
            val_2 = this;
            if((this.values & 16) == 0)
            {
                    val_2 = this.client;
                object val_1 = val_2.GetSocketOption(optionLevel:  65535, optionName:  1);
                return val_3;
            }
            
            val_3 = this.send_buffer_size;
            return val_3;
        }
        public void set_SendBufferSize(int value)
        {
            if(this.client.Connected != false)
            {
                    this.client.SetSocketOption(optionLevel:  65535, optionName:  1, optionValue:  value);
                return;
            }
            
            Properties val_2 = this.values;
            this.send_buffer_size = value;
            val_2 = val_2 | 16;
            this.values = val_2;
        }
        public int get_SendTimeout()
        {
            System.Net.Sockets.Socket val_2;
            int val_3;
            val_2 = this;
            if((this.values & 32) == 0)
            {
                    val_2 = this.client;
                object val_1 = val_2.GetSocketOption(optionLevel:  65535, optionName:  5);
                return val_3;
            }
            
            val_3 = this.send_timeout;
            return val_3;
        }
        public void set_SendTimeout(int value)
        {
            if(this.client.Connected != false)
            {
                    this.client.SetSocketOption(optionLevel:  65535, optionName:  5, optionValue:  value);
                return;
            }
            
            Properties val_2 = this.values;
            this.send_timeout = value;
            val_2 = val_2 | 32;
            this.values = val_2;
        }
        public System.TimeSpan get_ConnectTimeout()
        {
            return (System.TimeSpan)this.<ConnectTimeout>k__BackingField;
        }
        public void set_ConnectTimeout(System.TimeSpan value)
        {
            this.<ConnectTimeout>k__BackingField = value;
        }
        public void Close()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.Dispose();
        }
        public void Connect(System.Net.IPEndPoint remoteEP)
        {
            var val_15;
            var val_16;
            System.Net.Sockets.Socket val_17;
            var val_18;
            var val_19;
            val_15 = this;
            val_16 = null;
            val_16 = null;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = this.<ConnectTimeout>k__BackingField}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
            {
                goto label_3;
            }
            
            new TcpClient.<>c__DisplayClass55_0() = new System.Object();
            new System.Threading.ManualResetEvent() = new System.Threading.ManualResetEvent(initialState:  false);
            .mre = new System.Threading.ManualResetEvent();
            new System.AsyncCallback() = new System.AsyncCallback(object:  new TcpClient.<>c__DisplayClass55_0(), method:  System.Void TcpClient.<>c__DisplayClass55_0::<Connect>b__0(System.IAsyncResult res));
            val_17 = this.client;
            System.Threading.ManualResetEvent val_6 = ((TcpClient.<>c__DisplayClass55_0)[1152921553750517888].mre) & 1;
            this.active = val_6;
            if((val_6 & 1) == 0)
            {
                goto label_7;
            }
            
            val_17.EndConnect(asyncResult:  this.client.BeginConnect(remoteEP:  remoteEP, callback:  new System.AsyncCallback(), state:  0));
            goto label_9;
            label_3:
            val_17 = this.client;
            val_17.Connect(remoteEP:  remoteEP);
            this.active = true;
            label_9:
            this.CheckDisposed();
            return;
            label_7:
            val_17.Close();
            label_14:
            new System.TimeoutException() = new System.TimeoutException(message:  "Connection timed out!");
            val_18 = 0;
            val_19 = new System.TimeoutException();
            if(val_18 != 1)
            {
                goto label_15;
            }
            
            if((null & 1) == 0)
            {
                goto label_13;
            }
            
            goto label_14;
            label_13:
            mem[8] = null;
            val_18 = 123444064;
            val_19 = 8;
            label_15:
            if( == 1)
            {
                    this.CheckDisposed();
                if(mem[8] == 0)
            {
                    return;
            }
            
                val_15 = ???;
                val_19 = ???;
                return;
            }
        
        }
        public void Connect(System.Net.IPAddress address, int port)
        {
            this.Connect(remoteEP:  new System.Net.IPEndPoint(address:  address, port:  port));
        }
        private void SetOptions()
        {
            this.values = 0;
            if((this.values & 1) != 0)
            {
                goto label_0;
            }
            
            if((this.values & 2) != 0)
            {
                goto label_1;
            }
            
            label_6:
            if((this.values & 4) != 0)
            {
                goto label_2;
            }
            
            label_7:
            if((this.values & 8) != 0)
            {
                goto label_3;
            }
            
            label_8:
            if((this.values & 16) != 0)
            {
                goto label_4;
            }
            
            label_9:
            if((this.values & 32) != 0)
            {
                goto label_5;
            }
            
            return;
            label_0:
            this.LingerState = this.linger_state;
            if((this.values & 2) == 0)
            {
                goto label_6;
            }
            
            label_1:
            this.NoDelay = this.no_delay;
            if((this.values & 4) == 0)
            {
                goto label_7;
            }
            
            label_2:
            this.ReceiveBufferSize = this.recv_buffer_size;
            if((this.values & 8) == 0)
            {
                goto label_8;
            }
            
            label_3:
            this.ReceiveTimeout = this.recv_timeout;
            if((this.values & 16) == 0)
            {
                goto label_9;
            }
            
            label_4:
            this.SendBufferSize = this.send_buffer_size;
            if((this.values & 32) == 0)
            {
                    return;
            }
            
            label_5:
            this.SendTimeout = this.send_timeout;
        }
        public void Connect(string hostname, int port)
        {
            string val_9;
            System.TimeSpan val_10;
            var val_11;
            val_9 = hostname;
            val_10 = 1152921504624898048;
            val_11 = null;
            val_11 = null;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = this.<ConnectTimeout>k__BackingField}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
            {
                goto label_3;
            }
            
            .mre = new System.Threading.ManualResetEvent(initialState:  false);
            val_10 = this.<ConnectTimeout>k__BackingField;
            val_9 = System.Net.Dns.BeginGetHostAddresses(hostNameOrAddress:  val_9, requestCallback:  new System.AsyncCallback(object:  new TcpClient.<>c__DisplayClass58_0(), method:  System.Void TcpClient.<>c__DisplayClass58_0::<Connect>b__0(System.IAsyncResult res)), state:  0);
            if((((TcpClient.<>c__DisplayClass58_0)[1152921553751032176].mre) & 1) == 0)
            {
                goto label_8;
            }
            
            System.Net.IPAddress[] val_6 = System.Net.Dns.EndGetHostAddresses(asyncResult:  val_9);
            goto label_11;
            label_3:
            label_11:
            this.Connect(ipAddresses:  System.Net.Dns.GetHostAddresses(hostNameOrAddress:  val_9), port:  port);
            return;
            label_8:
            System.TimeoutException val_8 = new System.TimeoutException(message:  "DNS resolve timed out!");
        }
        public void Connect(System.Net.IPAddress[] ipAddresses, int port)
        {
            string val_13;
            var val_14;
            var val_15;
            var val_17;
            this.CheckDisposed();
            if(ipAddresses == null)
            {
                goto label_1;
            }
            
            if(ipAddresses.Length < 1)
            {
                    return;
            }
            
            val_14 = null;
            System.Net.IPAddress val_13 = ipAddresses[0];
            val_14 = null;
            if((val_13 & 1) == 0)
            {
                    val_15 = null;
                val_15 = null;
                if((val_13 & 1) == 0)
            {
                    this.Init(family:  val_13.AddressFamily);
                if(val_13.AddressFamily != 2)
            {
                    if(val_13.AddressFamily != 23)
            {
                goto label_12;
            }
            
            }
            
                new System.Net.IPEndPoint() = new System.Net.IPEndPoint(address:  val_13, port:  port);
                this.Connect(remoteEP:  new System.Net.IPEndPoint());
                if(this.values != 0)
            {
                    this.SetOptions();
            }
            
                this.client.SetSocketOption(optionLevel:  65535, optionName:  8, optionValue:  true);
                val_13 = System.String.Format(format:  "Connected to {0}:{1}", arg0:  val_13, arg1:  port.ToString());
                var val_14 = 0;
                val_14 = val_14 + 1;
                BestHTTP.HTTPManager.Logger.Information(division:  "TcpClient", info:  val_13);
                return;
            }
            
            }
            
            new System.Net.Sockets.SocketException() = new System.Net.Sockets.SocketException(errorCode:  65);
            goto label_48;
            label_12:
            new System.NotSupportedException() = new System.NotSupportedException(message:  "This method is only valid for sockets in the InterNetwork and InterNetworkV6 families");
            goto label_48;
            label_47:
            mem[8] = null;
            label_1:
            System.ArgumentNullException val_12 = new System.ArgumentNullException(paramName:  "ipAddresses");
            goto label_47;
            label_48:
            val_17 = new System.Net.Sockets.SocketException();
        }
        public void EndConnect(System.IAsyncResult asyncResult)
        {
            this.client.EndConnect(asyncResult:  asyncResult);
        }
        public System.IAsyncResult BeginConnect(System.Net.IPAddress address, int port, System.AsyncCallback requestCallback, object state)
        {
            if(this.client != null)
            {
                    return this.client.BeginConnect(address:  address, port:  port, requestCallback:  requestCallback, state:  state);
            }
            
            return this.client.BeginConnect(address:  address, port:  port, requestCallback:  requestCallback, state:  state);
        }
        public System.IAsyncResult BeginConnect(System.Net.IPAddress[] addresses, int port, System.AsyncCallback requestCallback, object state)
        {
            if(this.client != null)
            {
                    return this.client.BeginConnect(addresses:  addresses, port:  port, requestCallback:  requestCallback, state:  state);
            }
            
            return this.client.BeginConnect(addresses:  addresses, port:  port, requestCallback:  requestCallback, state:  state);
        }
        public System.IAsyncResult BeginConnect(string host, int port, System.AsyncCallback requestCallback, object state)
        {
            if(this.client != null)
            {
                    return this.client.BeginConnect(host:  host, port:  port, requestCallback:  requestCallback, state:  state);
            }
            
            return this.client.BeginConnect(host:  host, port:  port, requestCallback:  requestCallback, state:  state);
        }
        private void System.IDisposable.Dispose()
        {
            System.GC.SuppressFinalize(obj:  this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(this.disposed == true)
            {
                    return;
            }
            
            this.disposed = true;
            if(disposing == false)
            {
                    return;
            }
            
            this.stream = 0;
            if(this.stream != null)
            {
                    this.stream.Close();
                this.active = false;
                return;
            }
            
            if(this.client == null)
            {
                    return;
            }
            
            this.client.Close();
            this.client = 0;
        }
        protected override void Finalize()
        {
            this.Finalize();
        }
        public System.IO.Stream GetStream()
        {
            System.Net.Sockets.NetworkStream val_2 = this.stream;
            if(val_2 == null)
            {
                    val_2 = new System.Net.Sockets.NetworkStream();
                val_2 = new System.Net.Sockets.NetworkStream(socket:  this.client, ownsSocket:  true);
                this.stream = val_2;
            }
            
            this.CheckDisposed();
            return (System.IO.Stream)val_2;
        }
        private void CheckDisposed()
        {
            if(this.disposed != true)
            {
                    return;
            }
            
            System.ObjectDisposedException val_2 = new System.ObjectDisposedException(objectName:  this.GetType());
        }
    
    }

}
