/*Hilbert Curve Implementation
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HilbertCurve : MonoBehaviour {


//convert (x,y) to d
int xy2d(int n, int x, int y)
{
    int rx, ry, s, d = 0;
    for (s = n / 2; s > 0; s /= 2)
    {

        rx = Convert.ToInt32(((x & s) > 0));
        ry = Convert.ToInt32((y & s) > 0);
        d += s * s * ((3 * rx) ^ ry);
        rot(s, ref x, ref y, rx, ry);
    }
    return d;
}

//convert d to (x,y)
void d2xy(int n, int d, ref int x, ref int y)
{
    int rx, ry, s, t = d;
    x = y = 0;
    for (s = 1; s < n; s *= 2)
    {
        rx = 1 & (t / 2);
        ry = 1 & (t ^ rx);
        rot(s, ref x, ref y, rx, ry);
        x += s * rx;
        y += s * ry;
        t /= 4;
    }
}

//rotate/flip a quadrant appropriately
void rot(int n, ref int  x, ref int y, int rx, int ry)
{
    if (ry == 0)
    {
        if (rx == 1)
        {
            x = n - 1 - x;
            y = n - 1 - y;
        }

        //Swap x and y
        int t = x;
        x = y;
        y = t;
    }
}

	void Start () {

	}
	
	void Update () {
		
	}
}
