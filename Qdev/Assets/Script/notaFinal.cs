using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour
{
    private int idTema;

    public Text txtNota;
    public Text txtInfoTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    public int moedinhas;
    public int moedas;
    private int notaF;
    private int acertos;
    private int errosf;
    private int vidaf;


    void Start()
    {
        
        idTema = PlayerPrefs.GetInt("idTema");

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        //moedinhas = PlayerPrefs.GetInt("moedinhas" + moedas.ToString());
        errosf = PlayerPrefs.GetInt("errosTemp" + idTema.ToString()); 
        notaF = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString());
        vidaf = PlayerPrefs.GetInt("vidafTemp" + idTema.ToString());

        txtNota.text = notaF.ToString();
        txtInfoTema.text = "Voce acertou "+acertos.ToString()+" de 10 perguntas";

        if (notaF == 0)
        {
            estrela1.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
            moedas = moedas + 0;
        }
        if (notaF == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
            moedas = moedas + 3;
        }
        if (notaF > 3 && notaF <10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
            moedas = moedas + 2;

        }
       
        if (notaF <= 3 && notaF>0)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
            moedas = moedas + 1;
        }
        print("antigo");
        print(acertos);
        print(notaF);
        print(errosf);
        print(vidaf);
        print("moedas");
        print(moedas);

    }
    
    public void jogarNovamente()
    {
        Application.LoadLevel("T"+idTema.ToString());
    }

}
