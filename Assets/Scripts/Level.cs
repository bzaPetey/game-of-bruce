using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "Level", menuName = "Level")]
public class Level : ScriptableObject   {
    [SerializeField]GameObject map;
    [SerializeField]List<MapNode> mapNodes = new List<MapNode>();
    
    public void init() {
        //this is the psudo constructor for scriptableobjects
    }


    public MapNode NodeInfoByIndex(int index=0) {
        if(index > mapNodes.Count || index < 0) {
            Debug.Log("MapNode Index out of bounds!!");
            return null;
        }

        return mapNodes[index];
    }
}
