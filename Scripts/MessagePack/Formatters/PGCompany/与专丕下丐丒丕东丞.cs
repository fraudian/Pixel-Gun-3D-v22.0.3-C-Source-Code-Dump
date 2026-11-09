using UnityEngine;

namespace MessagePack.Formatters.PGCompany
{
    internal sealed class 与专丕下丐丒丕东丞 : IMessagePackFormatter<PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏>, IMessagePackFormatter
    {
        // Methods
        public void Serialize(ref MessagePack.MessagePackWriter 业专丘专七丕丟丅与, PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏 丙业与丙丗丝不丈东, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_25;
            var val_26;
            MessagePack.MessagePackWriter val_27;
            bool val_28;
            MessagePack.IFormatterResolver val_29;
            var val_30;
            Rilisoft.丝丑丂丛万丐丈丘且 val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_25 = 丆与丛丅丂三万一丑;
            val_26 = 丙业与丙丗丝不丈东;
            val_27 = 1152921541918343392;
            val_28 = true;
            if(val_26 != null)
            {
                    val_29 = val_25.Resolver;
                val_30 = 1152921541903703776;
                val_31 = 丙业与丙丗丝不丈东.InappPriceFirst;
                val_33 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
                val_34 = 1152921504968347648;
                var val_24 = 0;
                val_24 = val_24 + 1;
            }
            else
            {
                    val_27 = ???;
                val_25 = ???;
                val_29 = ???;
                val_26 = ???;
                val_32 = ???;
                val_31 = ???;
                val_30 = ???;
                val_33 = ???;
                val_34 = ???;
                val_28 = val_28 + ((X11) << 4);
                val_35 = val_28 + 296;
            }
            
            val_33.Serialize(writer: ref  new MessagePack.MessagePackWriter() {writer = new MessagePack.BufferWriter() {_output = val_27, _span = new System.Span<System.Byte>() {_length = val_27}, _segment = new System.ArraySegment<System.Byte>() {_count = val_27}, _buffered = val_27, _bytesCommitted = val_27, _sequencePool = val_27, _rental = new Rental() {owner = val_27, <Value>k__BackingField = val_27}}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = val_27}, <OldSpec>k__BackingField = val_27}, value:  null, options:  null);
            MessagePack.Formatters.IMessagePackFormatter<T> val_3 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
            var val_25 = 0;
            val_25 = val_25 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_5 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
            var val_26 = 0;
            val_26 = val_26 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_7 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
            var val_27 = 0;
            val_27 = val_27 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_9 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
            var val_28 = 0;
            val_28 = val_28 + 1;
            MessagePack.Formatters.IMessagePackFormatter<T> val_11 = MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<Rilisoft.丝丑丂丛万丐丈丘且>(resolver:  val_29);
            var val_29 = 0;
            val_29 = val_29 + 1;
            goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_11, typeof(), slot: 0);
        }
        public PGCompany.丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏 Deserialize(ref MessagePack.MessagePackReader 且丛三下万丂专专业, MessagePack.MessagePackSerializerOptions 丆与丛丅丂三万一丑)
        {
            var val_16;
            Rilisoft.丝丑丂丛万丐丈丘且 val_17;
            Rilisoft.丝丑丂丛万丐丈丘且 val_18;
            val_16 = 0;
            if((1152921541918566064 & 1) != 0)
            {
                    return (专丙丆丏且七丈丗丏)val_16;
            }
            
            丆与丛丅丂三万一丑.Security.DepthStep(reader: ref  new MessagePack.MessagePackReader() {reader = new MessagePack.SequenceReader<System.Byte>() {<Consumed>k__BackingField = 且丛三下万丂专专业.reader.<Consumed>k__BackingField}, <CancellationToken>k__BackingField = new System.Threading.CancellationToken() {m_source = 且丛三下万丂专专业.<CancellationToken>k__BackingField.m_source}, <Depth>k__BackingField = 且丛三下万丂专专业.<Depth>k__BackingField});
            MessagePack.IFormatterResolver val_2 = 丆与丛丅丂三万一丑.Resolver;
            if(1152921541918566064 < 1)
            {
                goto label_5;
            }
            
            var val_29 = 0;
            val_17 = 0;
            val_18 = 0;
            label_55:
            if(val_29 > 5)
            {
                goto label_54;
            }
            
            var val_22 = -19012176;
            val_22 = val_22 + 106069972;
            goto (-19012176 + 106069972);
            label_54:
            val_29 = val_29 + 1;
            if(val_29 != 1152921541918566064)
            {
                goto label_55;
            }
            
            goto label_56;
            label_5:
            val_18 = 0;
            val_17 = 0;
            label_56:
            丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏 val_21 = null;
            val_16 = val_21;
            val_21 = new 丅丞与丟与丄丕丒丂.专丙丆丏且七丈丗丏();
            if(val_16 != null)
            {
                    .InappPriceFirst = val_18;
                mem[1152921541918611192] = 0;
                .SaleFirst = val_17;
                mem[1152921541918611208] = 0;
                .ShowPriceFirst = 0;
                mem[1152921541918611224] = 0;
                .InappPriceSecond = 0;
                mem[1152921541918611240] = 0;
                .SaleSecond = 0;
                mem[1152921541918611256] = 0;
            }
            else
            {
                    mem[16] = val_18;
                mem[24] = 0;
                mem[32] = val_17;
                mem[40] = 0;
                mem[48] = 0;
                mem[56] = 0;
                mem[64] = 0;
                mem[72] = 0;
                mem[80] = 0;
                mem[88] = 0;
            }
            
            .ShowPriceSecond = 0;
            mem[1152921541918611272] = 0;
            return (专丙丆丏且七丈丗丏)val_16;
        }
        public 与专丕下丐丒丕东丞()
        {
        
        }
    
    }

}
