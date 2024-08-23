using System.IO;
using ProtoBuf;
using TestProto;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var test = new TestMsg();
        test.Id = 1;
        test.Name = "123";

        MemoryStream memoryStream = new MemoryStream();
        Serializer.Serialize(memoryStream, test);
        var binaryData = memoryStream.ToArray();
        
        using (MemoryStream memoryStream2 = new MemoryStream(binaryData))
        {
            TestMsg test2 = Serializer.Deserialize<TestMsg>(memoryStream2);
            Debug.LogError(test2.Name);
        }

        test.Name = "234";
        var binaryData2 = Serialize(test);
        var test3 = Deserialize<TestMsg>(binaryData2);
        Debug.LogError(test3.Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static byte[] Serialize(IExtensible msg)
    {
        byte[] result;
        using var stream = new MemoryStream();
        Serializer.Serialize(stream, msg);
        result = stream.ToArray();
        return result;
    }
    
    // public static T Deserialize<T>(byte[] message) where T :IExtensible
    // {
    //     T result;
    //     using var stream = new MemoryStream(message);
    //     result = Serializer.Deserialize<T>(stream);
    //     return result;
    // }
    
    public static byte[] Serialize(IMessage msg)
    {
        byte[] result;
        using var stream = new MemoryStream();
        Serializer.Serialize(stream, msg);
        result = stream.ToArray();
        return result;
    }
    
    public static T Deserialize<T>(byte[] message) where T :IMessage
    {
        T result;
        using var stream = new MemoryStream(message);
        result = Serializer.Deserialize<T>(stream);
        return result;
    }
}
