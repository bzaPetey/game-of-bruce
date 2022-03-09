using UnityEngine;

public enum Effect  {
    NONE,           // no effect
    SLEEP,          //can not perform actions or move for x seconds, wake if hit
    BURNING,        //dot
    STUNNED,        //can not move or perform actions for x seconds
    FROZEN,         //movement speed is slowed for x seconds
    FREEZING        //action speed is slowed over time for x seconds
}
