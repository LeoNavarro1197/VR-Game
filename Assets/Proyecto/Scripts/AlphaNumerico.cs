using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlphaNumerico : MonoBehaviour
{
    public TextMeshProUGUI existencias, dias, dias1, agosto, octubre, noviembre;
    public TextMeshProUGUI agostoE, octubreE, noviembreE;
    public TextMeshProUGUI resultadoCPM, resultadoCPMDividido, resultadoCPMDividido1, resultadoCPMDividido2, resultadoCPMDividido3;
    public TextMeshProUGUI fraccionTiempoResultado, fraccionTiempoResultadoAprox, fraccionTiempoResultadoAprox1, fraccionTiempoResultadoAprox2;
    public TextMeshProUGUI PRFrascos, NMEResultado;

    public CalculateCAP calculateCAP;
    public GameObject panelCongrats;
    public GameObject panelFormula;

    public string CAP;

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

        int intAgostoE = int.Parse(agostoE.text);
        int intOctubreE = int.Parse(octubreE.text);
        int intNoviembreE = int.Parse(noviembreE.text);

        resultadoCPM.text = (intAgostoE + intOctubreE + intNoviembreE).ToString();
        resultadoCPMDividido.text = (int.Parse(resultadoCPM.text) / 3).ToString();
        resultadoCPMDividido1.text = resultadoCPMDividido.text;
        resultadoCPMDividido2.text = resultadoCPMDividido1.text;

        dias.text = dias1.text;

        fraccionTiempoResultado.text = (int.Parse(resultadoCPMDividido.text) * 0.26f).ToString();
        fraccionTiempoResultadoAprox.text = fraccionTiempoResultado.text;
        float i = float.Parse(fraccionTiempoResultadoAprox.text);
        i = Mathf.FloorToInt(i);
        fraccionTiempoResultadoAprox.text = i.ToString();
        fraccionTiempoResultadoAprox1.text = fraccionTiempoResultadoAprox.text;

        PRFrascos.text = (i * 2).ToString();

        fraccionTiempoResultadoAprox2.text = fraccionTiempoResultadoAprox1.text;
        resultadoCPMDividido3.text = resultadoCPMDividido2.text;

        NMEResultado.text = ((int.Parse(fraccionTiempoResultadoAprox2.text)) + (int.Parse(resultadoCPMDividido3.text))).ToString();

        CAP = (int.Parse(PRFrascos.text) + (int.Parse(resultadoCPMDividido.text) * 1) - int.Parse(existencias.text)).ToString();
    }

    private void Update()
    {
        if (calculateCAP.ejercicioCorrecto)
        {
            panelCongrats.SetActive(true);
            panelFormula.SetActive(false);
            calculateCAP.ejercicioCorrecto = false;
            Invoke("OffPanelCongrats", 3f);
        }
    }

    void OffPanelCongrats()
    {
        panelCongrats.SetActive(false);
    }
}
