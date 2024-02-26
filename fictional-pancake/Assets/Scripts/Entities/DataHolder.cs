using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewDataHolder", menuName = "Data/New Data Hodler")]
[System.Serializable]
public class DataHolder : ScriptableObject
{
    public List<GameScene> gameScenes;

}
