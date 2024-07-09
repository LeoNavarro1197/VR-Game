using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActiveEquation : MonoBehaviour
{
    public GameObject PRInit, PRFinish;
    public GameObject CMPInit, CMPFinish;
    public GameObject MultiplicatorInit, MultiplicatorFinish;
    public GameObject SubstractionInit, SubstractionFinish;
    public GameObject ExisInit, ExisFinish;

    bool PRState = false, CMPState = false, MultiplicatorState = false, SubstractionState = false, ExisState = false;
    public bool equationCorrect = false;

    public GameObject dragAndDrop, alphaNumerico;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PRInit.transform.position == PRFinish.transform.position) { PRState = true; }
        if (CMPInit.transform.position == CMPFinish.transform.position) { CMPState = true; }
        if (MultiplicatorInit.transform.position == MultiplicatorFinish.transform.position) { MultiplicatorState = true; }
        if (SubstractionInit.transform.position == SubstractionFinish.transform.position) { SubstractionState = true; }
        if (ExisInit.transform.position == ExisFinish.transform.position) { ExisState = true; }

        if(PRState &&  CMPState && MultiplicatorState && SubstractionState && ExisState)
        {
            equationCorrect = true;
        }

        if(equationCorrect)
        {
            dragAndDrop.SetActive(false);
            alphaNumerico.SetActive(true);
        }
    }
}
