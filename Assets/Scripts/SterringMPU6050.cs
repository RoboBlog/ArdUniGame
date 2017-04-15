using UnityEngine;
using System.Collections;
using System;
using System.IO.Ports;
 
 
public class SterringMPU6050 : MonoBehaviour
{
 
    SerialPort stream;
 
    public GameObject target; 
 
    float acc_normalizer_factor = 0.00025f;
    float gyro_normalizer_factor = 1.0f / 32768.0f;   // 32768 is max value captured during test on imu
 
    float curr_angle_x = 0;
    float curr_angle_y = 0;
    float curr_angle_z = 0;
 
    float curr_offset_x = 0;
    float curr_offset_y = 0;
    float curr_offset_z = 0;
 
    public float factor = 7;
 
 
    public bool enableRotation;
    public bool enableTranslation;
    string port = "COM4";
    int baudrate = 9600;
    int readTimeout = 25;
 
    void Start()
    {
        stream = new SerialPort("\\\\.\\" + port, baudrate);
 
        try
        {
            stream.ReadTimeout = readTimeout;
        }
        catch (System.IO.IOException ioe)
        {
            Debug.Log("IOException: " + ioe.Message);
        }
 
        stream.Open();
    }
 
    void Update()
    {
        string dataString = "null received";
 
        if (stream.IsOpen)
        {
            try
            {
                dataString = stream.ReadLine();
                Debug.Log("RCV_ : " + dataString);
            }
            catch (System.IO.IOException ioe)
            {
                Debug.Log("IOException: " + ioe.Message);
            }
 
        }
        else
            dataString = "NOT OPEN";
        Debug.Log("RCV_ : " + dataString);
 
        if (!dataString.Equals("NOT OPEN"))
        {
            char splitChar = ';';
            string[] dataRaw = dataString.Split(splitChar);
 
            float ax = Int32.Parse(dataRaw[0]) * acc_normalizer_factor;
            float ay = Int32.Parse(dataRaw[1]) * acc_normalizer_factor;
            float az = Int32.Parse(dataRaw[2]) * acc_normalizer_factor;
 
            float gx = Int32.Parse(dataRaw[3]) * gyro_normalizer_factor;
            float gy = Int32.Parse(dataRaw[4]) * gyro_normalizer_factor;
            float gz = Int32.Parse(dataRaw[5]) * gyro_normalizer_factor;
 
            if (Mathf.Abs(ax) - 1 < 0) ax = 0;
            if (Mathf.Abs(ay) - 1 < 0) ay = 0;
            if (Mathf.Abs(az) - 1 < 0) az = 0;
 
 
            curr_offset_x += ax;
            curr_offset_y += ay;
            curr_offset_z += 0; 


            if (Mathf.Abs(gx) < 0.025f) gx = 0f;
            if (Mathf.Abs(gy) < 0.025f) gy = 0f;
            if (Mathf.Abs(gz) < 0.025f) gz = 0f;
 
            curr_angle_x += gx;
            curr_angle_y += gy;
            curr_angle_z += gz;
 
            if(enableTranslation) target.transform.position = new Vector3(curr_offset_y, curr_offset_x, 0);
    
        }
    }
 
}