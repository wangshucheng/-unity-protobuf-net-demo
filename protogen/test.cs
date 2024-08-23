// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: test.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace TestProto
{

    [global::ProtoBuf.ProtoContract()]
    public partial class TestMsg : ProtoBuf.IMessage
    {
        [global::ProtoBuf.ProtoMember(1)]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public string Name { get; set; } = "";

        [global::ProtoBuf.ProtoMember(3)]
        public Opcode Op { get; set; }

        public void Encode(Google.Protobuf.CodedOutputStream writer)
        {
            if(Id != 0)
            {
                writer.WriteTag(8);
                writer.WriteInt32(Id);
            }
            if(Name != "")
            {
                writer.WriteTag(18);
                writer.WriteString(Name);
            }
            if(Op != 0)
            {
                writer.WriteTag(24);
                writer.WriteEnum((int)Op);
            }
        }
        public void Decode(Google.Protobuf.CodedInputStream reader)
        {
            Id = 0;

            Name = "";

            Op = 0;

            uint tag;
            while ((tag = reader.ReadTag()) != 0)
            {
                switch (tag)
                {
                    case 8:
                        {
                            Id = reader.ReadInt32();
                        }
                        break;
                    case 18:
                        {
                            Name = reader.ReadString();
                        }
                        break;
                    case 24:
                        {
                            Op = (Opcode)reader.ReadEnum();
                        }
                        break;
                    default:
                        {
                            reader.SkipLastField();
                        }
                        break;
                }
            }
        }
    }

    [global::ProtoBuf.ProtoContract()]
    public enum Opcode
    {
        opcode_none = 0,
    }

}

public class ILRuntime_test
{
    static ILRuntime_test()
    {

        //Initlize();

    }
    public static void Initlize()
    {

        ProtoBuf.PType.RegisterType("TestProto.TestMsg", typeof(TestProto.TestMsg));

    }
}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
