using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    [SerializeField]
    private FloatSO ScoreSO;
    
    private void Start()
    {
        ScoreSO.Value = 0;
    }
    
}
