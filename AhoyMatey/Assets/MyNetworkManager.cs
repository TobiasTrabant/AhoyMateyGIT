using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {



    public void MyStartHost()
    {
        StartHost();
        Debug.Log(Time.timeSinceLevelLoad + " MyStartHost");
    }
    

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " OnStartHost");
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client start requested");
        base.OnStartClient(myClient);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client is connected to ip: " + conn.address);
        base.OnClientConnect(conn);
    }
}
