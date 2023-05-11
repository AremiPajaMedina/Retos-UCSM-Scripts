using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : MonoBehaviour {

	// Avatar Selection
    public static int iAvatar = 2;  // 1: Girl     2: Boy 


    // GEMS INSTANCES
    public static int iGemsInstances = 10;
    public static List<string> urls = new List<string>() {
        "http://investigacion.ucsm.edu.pe/retos/app/PR01",
        "http://investigacion.ucsm.edu.pe/retos/app/PR02",
        "http://investigacion.ucsm.edu.pe/retos/app/PR03",
        "http://investigacion.ucsm.edu.pe/retos/app/PR04",
        "http://investigacion.ucsm.edu.pe/retos/app/PR05",
        "http://investigacion.ucsm.edu.pe/retos/app/PR06",
        "http://investigacion.ucsm.edu.pe/retos/app/PR07",
        "http://investigacion.ucsm.edu.pe/retos/app/PR08",
        "http://investigacion.ucsm.edu.pe/retos/app/PR09",
        "http://investigacion.ucsm.edu.pe/retos/app/PR10",
    };

    // Posible Positions on the Campus
    public static List<float> xPositions = new List<float>() {
        -13.674f, -12.86f, -11.414f, -12.134f, -17.378f, -18.646f, -20.945f, -18.592f, -14.102f, -24.039f, -33.15f, 
        -36.38f, -33.897f, -39.099f, -35.12f, -29.522f, -33.277f, -28.845f, -26.848f, -26.217f, -22.907f, -19.263f, 
        -27.41f, -22.261f, -24.28f, -28.485f, -32.05f, -27.061f, -16.13f, -12.375f, -20.82f, -4.04f, -0.445f, -3.81f, 
        0.62f, 5.173f, 1.99f, 5.03f, 9.649f, 7.325f, -8.87f,
    };
    public static List<float> yPositions = new List<float>() {
        0.603f, 0.508f, 0.422f, 0.42f, 0.422f, 0.356f, 0.47f, 0.356f, 0.442f, 0.399f, 0.462f, 0.443f, 0.474f, 0.355f, 
        0.425f, 0.452f, 0.455f, 0.429f, 0.459f, 0.459f, 0.831f, 0.618f, 0.543f, 0.622f, 0.479f, 0.616f, 0.62f, 0.632f, 
        0.906f, 0.553f, 0.572f, 0.532f, 0.54f, 0.76f, 0.542f, 0.566f, 0.532f, 0.356f, 0.54f, 0.54f, 0.614f,
    };
    public static List<float> zPositions = new List<float>() {
        -9.24f, 1.639f, 9.191f, 13.869f, 14.85f, 24.963f, 28.359f, 41.578f, 48.874f, 50.478f, 49.32f, 39.94f, 28.19f, 
        23.892f, 15.49f, 14.632f, 11.201f, 9.281f, 4.901f, 7.772f, 15.201f, 7.31f, -4.76f, -11.455f, -19.02f, -14.5009f, 
        3.898f, -10.013f, -12.694f, -19.032f, -25.31f, -23.16f, -17.679f, -33.02f, -25.961f, -21.78f, -6.143f, -13.017f,
        -9.7f, -17.965f, -1.041f,
    };


}
