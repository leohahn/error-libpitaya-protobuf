using System;
using System.Collections;
using UnityEngine;
using Google.Protobuf;
using Google.Protobuf.Reflection;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
//        FileDescriptor.ForceReflectionInitialization<Protos.Error>();

        var res = (IMessage) Activator.CreateInstance(typeof(Protos.Error));
        var msg = JsonParser.Default.Parse("{\"code\":\"PIT-000\",\"msg\":\"GetError is returning a custom error\"}", res.Descriptor);

        Debug.Log("Message:");
        Debug.Log(msg);
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
