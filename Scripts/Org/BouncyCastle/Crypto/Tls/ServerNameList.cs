using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class ServerNameList
    {
        // Fields
        protected readonly System.Collections.IList mServerNameList;
        
        // Properties
        public virtual System.Collections.IList ServerNames { get; }
        
        // Methods
        public ServerNameList(System.Collections.IList serverNameList)
        {
            if(serverNameList != null)
            {
                    this.mServerNameList = serverNameList;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "serverNameList");
        }
        public virtual System.Collections.IList get_ServerNames()
        {
            return (System.Collections.IList)this.mServerNameList;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            var val_11;
            var val_13;
            var val_15;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_11 = null;
            val_11 = null;
            var val_14 = 0;
            val_14 = val_14 + 1;
            System.Collections.IEnumerator val_3 = this.GetEnumerator();
            goto label_18;
            label_25:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = 1;
            val_15 = public System.Object System.Collections.IEnumerator::get_Current();
            if(val_3.Current != null)
            {
                    val_15 = 0;
                val_13 = 0;
            }
            
            if((Org.BouncyCastle.Crypto.Tls.ServerNameList.CheckNameType(nameTypesSeen:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, nameType:  0)) == null)
            {
                goto label_17;
            }
            
            label_18:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_3.MoveNext() == true)
            {
                goto label_25;
            }
            
            val_17 = 0;
            val_18 = 0;
            goto label_26;
            label_17:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  80), innerException:  0);
            .alertDescription = 80;
            val_19 = 0;
            val_20 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert();
            if(val_19 != 1)
            {
                goto label_36;
            }
            
            val_17 = 0;
            label_26:
            val_21 = null;
            if(val_3 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_21 = public System.Void System.IDisposable::Dispose();
                val_3.Dispose();
            }
            
            if((val_17 == 1) && (null != null))
            {
                    val_21 = 0;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  new System.IO.MemoryStream());
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  -46191984, output:  output);
            return;
            label_36:
        }
        public static Org.BouncyCastle.Crypto.Tls.ServerNameList Parse(System.IO.Stream input)
        {
            System.Byte[] val_11;
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            if(val_1 <= 0)
            {
                goto label_19;
            }
            
            System.IO.MemoryStream val_4 = null;
            val_11 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  val_1 & (~(val_1 >> 31)), input:  input);
            val_4 = new System.IO.MemoryStream(buffer:  val_11, writable:  false);
            System.Collections.IList val_5 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            goto label_8;
            label_18:
            Org.BouncyCastle.Crypto.Tls.ServerName val_6 = Org.BouncyCastle.Crypto.Tls.ServerName.Parse(input:  val_4);
            if((Org.BouncyCastle.Crypto.Tls.ServerNameList.CheckNameType(nameTypesSeen:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, nameType:  val_6)) == null)
            {
                goto label_10;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_11 = val_6;
            int val_9 = val_5.Add(value:  val_11);
            label_8:
            if(val_4 < val_4)
            {
                goto label_18;
            }
            
            return (Org.BouncyCastle.Crypto.Tls.ServerNameList)new Org.BouncyCastle.Crypto.Tls.ServerNameList(serverNameList:  val_5);
            label_10:
            label_19:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            goto label_19;
        }
        private static byte[] CheckNameType(byte[] nameTypesSeen, byte nameType)
        {
            if((nameType & 255) != 0)
            {
                    return 0;
            }
            
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  nameTypesSeen, n:  0)) == false)
            {
                    return Org.BouncyCastle.Utilities.Arrays.Append(a:  nameTypesSeen, b:  0);
            }
            
            return 0;
        }
    
    }

}
