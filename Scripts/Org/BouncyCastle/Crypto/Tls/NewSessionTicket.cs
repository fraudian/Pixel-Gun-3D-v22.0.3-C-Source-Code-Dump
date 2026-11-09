using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class NewSessionTicket
    {
        // Fields
        protected readonly long mTicketLifetimeHint;
        protected readonly byte[] mTicket;
        
        // Properties
        public virtual long TicketLifetimeHint { get; }
        public virtual byte[] Ticket { get; }
        
        // Methods
        public NewSessionTicket(long ticketLifetimeHint, byte[] ticket)
        {
            this.mTicketLifetimeHint = ticketLifetimeHint;
            this.mTicket = ticket;
        }
        public virtual long get_TicketLifetimeHint()
        {
            return (long)this.mTicketLifetimeHint;
        }
        public virtual byte[] get_Ticket()
        {
            return (System.Byte[])this.mTicket;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint32(i:  this.mTicketLifetimeHint, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  this.mTicket, output:  output);
        }
        public static Org.BouncyCastle.Crypto.Tls.NewSessionTicket Parse(System.IO.Stream input)
        {
            .mTicketLifetimeHint = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint32(input:  input);
            .mTicket = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input);
            return (Org.BouncyCastle.Crypto.Tls.NewSessionTicket)new Org.BouncyCastle.Crypto.Tls.NewSessionTicket();
        }
    
    }

}
