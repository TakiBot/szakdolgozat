using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
//using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.UI;



public class DropdownListController : MonoBehaviour {

    //Antenna List
    List<string> antName = new List<string>() { "Antennasample", "OtherAntenna" };

    public string filePath;
    public string result;

    //Dropdownbox And TexMeshPro(AntennaName,manufacturerName) Call For EventHandler
    public Dropdown dropdown;
    public TMPro.TextMeshProUGUI selectedName;
    public TMPro.TextMeshProUGUI manufacturerName;
    public TMPro.TextMeshProUGUI fileDataPath;

    
      
          

    //Selected Antenna Indexing In The Dropdownbox
    void DropdownIndexChanged(int index)
    {
         selectedName.text = antName[index];
        //Selected Antenna File Path
        filePath = (Application.streamingAssetsPath + @"/" + selectedName.text + @".csv");
        result = "";

        if (filePath.Contains("://"))
        {
            UnityWebRequest www = UnityWebRequest.Get(filePath);
            www.SendWebRequest();
            result = www.downloadHandler.text;

            manufacturerName.text = www.downloadHandler.text;

        }
        else
        {
            //Is There a File?
            // IF Yes
            if (File.Exists(filePath))
            {
                //Selected Antenna File Lines To List
                List<string> Linelist = File.ReadAllLines(filePath).ToList();
                foreach (string Lines in Linelist)
                {
                    //The Lines Are Separeted by ','
                    string[] Entries = Lines.Split(',');

                    //string Manufacturer = Entries[0];
                    manufacturerName.text = Entries[1];
                }
            }
            // IF Not
            else
            {
                Debug.Log("File Does Not Exist!");
            }
        }
        Debug.Log(filePath);
        Debug.Log(result);
    }
 
    //Antenna List Upload
    void Start()
    {
        DropdownIndexChanged(0);
        PopulateList();
        DataPath();
    }

    //Antenna List To The List Element
    void PopulateList()
    {
        dropdown.AddOptions(antName);
    }

    void DataPath()
    {
        fileDataPath.text = result;
    }


}
