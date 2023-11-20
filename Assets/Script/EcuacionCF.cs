using UnityEngine;
using UnityEngine.UI;

public class EcuacionCF : MonoBehaviour
{
    [SerializeField] private Text Ecuacion;
    [SerializeField] private Text XInicial;
    [SerializeField] private Text Velocidad;
    [SerializeField] private Text AExperimental;
    [SerializeField] private Text ATeorica;
    [SerializeField] private Text PorError;

    private void Start()
    {
        double[] TimeY = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        double[] TimeX = { 0.099112, 0.163889, 0.213280, 0.255930, 0.292960, 0.326100, 0.359300, 0.387350, 0.414200, 0.440720 };

        double[] cof = Polyfit(TimeX, TimeY, 2);
        double AExp = 2 * cof[0];

        Ecuacion.text = "Ecu:" + string.Join(", ", cof);
        AExperimental.text = "G: " + AExp + " cm/s^2";
        Velocidad.text = "V0: " + cof[1] + " cm/s";
        XInicial.text = "Y0: " + cof[2] + " cm";

        double gTeorica = 978; // Gravedad teórica en cm/s^2
        ATeorica.text = "ATeo: " + gTeorica;
        double gPorcentajeError = ((gTeorica - AExp) / gTeorica) * 100;
        PorError.text = "%error: " + gPorcentajeError + "%";
    }

    static double[] Polyfit(double[] x, double[] y, int degree)
    {
   
        return new double[degree + 1]; 
    }
}
