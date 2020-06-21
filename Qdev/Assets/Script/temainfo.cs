using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class temainfo : MonoBehaviour
{

    public int idTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    public Text moedas_qtd;
    public int moedas;
    public int i=0;



    private int notafinal;


    void Start()
    {
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());



        if (notaFinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
            moedas = moedas + 3;
        }
        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

      //  moedas += moedas;
        

        print("moedas_qtd");
        print(moedas_qtd);
        print("temainfo");
        print("moedas");
        print(moedas);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
