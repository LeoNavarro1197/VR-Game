using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlphaNumerico : MonoBehaviour
{
    public TextMeshProUGUI existencias, dias, agosto, octubre, noviembre;
    public TextMeshProUGUI agostoE, octubreE, noviembreE;
    public TextMeshProUGUI resultadoCPM;

    // Start is called before the first frame update
    void Start()
    {
        existencias.text = Random.Range(50, 200).ToString();
        dias.text = Random.Range(3, 15).ToString();
        agosto.text = Random.Range(150, 250).ToString();
        octubre.text = Random.Range(150, 250).ToString();
        noviembre.text = Random.Range(150, 250).ToString();

        agostoE.text = agosto.text;
        octubreE.text = octubre.text;
        noviembreE.text = noviembre.text;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
