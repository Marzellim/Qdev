using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinalfail : MonoBehaviour
{
    private int idTema;

    public Text txtNotafail;
    public Text txtInfoTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int notaFail;
    private int acertosFail;
    private int errosFail;
    private int vidaFail;


    void Start()
    {

        idTema = PlayerPrefs.GetInt("idTema");

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        errosFail = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString());
        notaFail = PlayerPrefs.GetInt("notaFail" + idTema.ToString());
        acertosFail = PlayerPrefs.GetInt("acertos" + idTema.ToString());
        vidaFail = PlayerPrefs.GetInt("vidafTemp" + idTema.ToString());
        

        txtNotafail.text = notaFail.ToString();
        txtInfoTema.text = "Voce acertou " + acertosFail.ToString() + " de 10 perguntas";

        if (notaFail == 0)
        {
            estrela1.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
        if (notaFail == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        if (notaFail > 3 && notaFail < 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }

        if (notaFail <= 3 && notaFail > 0)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
        print("fail");
        print(acertosFail);
        print(notaFail);
        print(errosFail);
        print(vidaFail);


    }

    public void jogarNovamente()
    {
        Application.LoadLevel("T" + idTema.ToString());
    }

}
