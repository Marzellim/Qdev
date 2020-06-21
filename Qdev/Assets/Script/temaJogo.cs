using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temaJogo : MonoBehaviour
{

    public Button btnPlay;
    public Text txtNomeTema;

    public GameObject infoTema;
    public Text    txtInfoTema;
    public Text moedas_qtd;
    public int moedas;
    public int moedasReal;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public string[] nomeTema;
    public int numeroQuestoes; 

    private int idTema;

    void Start()
    {
        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];
        txtInfoTema.text = "Voce acertou X de X questões!";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false;
        moedas += moedas;
    }

    public void selecioneTema(int i)
    {
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNomeTema.text = nomeTema[i];

        int notaFinal= PlayerPrefs.GetInt("notaFinal" + idTema.ToString()); 
        int acertos= PlayerPrefs.GetInt("acertosTemp" + idTema.ToString()); 
        moedasReal = moedas;

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
            moedas = moedas + 2;
        }
        else if (notaFinal >= 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
            moedas = moedas + 1;
        }
        if (notaFinal == 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }

        txtInfoTema.text = "Voce acertou "+acertos.ToString()+" de "+numeroQuestoes.ToString()+" questões!";
        infoTema.SetActive(true);
        btnPlay.interactable = true;
        moedas_qtd.text =  moedas.ToString();



    }

    public void jogar(){

        Application.LoadLevel("T"+idTema.ToString());
    }

// Update is called once per frame
void Update()
    {
        
    }
}
