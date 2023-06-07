using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketClient : MonoBehaviour
{
    private object sendData;
    private object webSocket;

    private 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sendData.requestType = 10;
            string jsonData = JsonConvert.SerializeObject(sendData);            // Mydata 를 JSON으로 사용

            webSocket.Send(jsonData);
        }
    }
}
