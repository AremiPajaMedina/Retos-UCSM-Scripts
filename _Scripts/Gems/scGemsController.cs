using System.Collections.Generic;
using UnityEngine;

public class scGemsController : MonoBehaviour {

    public GameObject goGem;
    
    private int iGems;
    private List<float> xPositions;  
    private List<float> yPositions;
    private List<float> zPositions;
    private List<string> urls;

    void Start()
    {
        iGems = GlobalVars.iGemsInstances;
        xPositions = GlobalVars.xPositions;
        yPositions = GlobalVars.yPositions;
        zPositions = GlobalVars.zPositions;
        urls = GlobalVars.urls;

        InstanciateGem();
    }

    private void InstanciateGem() 
    {
        int iPos;
        GameObject goInst;

        if (iGems == urls.Count)
        {
            // Instanciate Gems
            for (int i = 0; i < iGems; i++)
            {
                iPos = Random.Range(0, xPositions.Count);
                goInst = Instantiate(goGem, new Vector3(xPositions[iPos], yPositions[iPos], zPositions[iPos]), Quaternion.Euler(-90, 0, 0));
                goInst.name = i.ToString();
                xPositions.RemoveAt(iPos);
                yPositions.RemoveAt(iPos);
                zPositions.RemoveAt(iPos);
            }
        }
        else 
        {
            print("** E: Missing Info!");
        }
    }
    
}
