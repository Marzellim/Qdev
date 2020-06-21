using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class responder : MonoBehaviour
{
    private int idTema;


    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject n6;
    public GameObject n7;

    public GameObject certo;


    public GameObject item;

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public Image image;
    public Text pergunta;
    public Text repostasA;
    public Text repostasB;
    public Text repostasC;
    public Text repostasD;
    public Text infoRespostas;

    public string[] perguntas;
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretas;

    private int idPergunta;
    private int numeroq;

    private float erros;
    private float acertos;
    private float questoes;
    private float media;
    private int notaFinal;
    private int vida;
    private int notaFail;
    private float acertosFail;
    private float errosFail;
    private int vidaFail;

    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        idPergunta = 0;
        numeroq = idTema;
        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        repostasA.text = alternativaA[idPergunta];
        repostasB.text = alternativaB[idPergunta];
        repostasC.text = alternativaC[idPergunta];
        repostasD.text = alternativaD[idPergunta];

        infoRespostas.text = "Respondendo "+(numeroq) +" de "+questoes.ToString()+" perguntas "; // verificar o numero em que esta
                                                                                                 //image.GetComponent<Image>().color = new Color32(0, 255, 225, 100);


        


    }

    public void resposta(string alternativa){
        
        vida = 3;
        //A
        
       
        if (alternativa == "A")
        {
            if (alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                

            }
            if (alternativaA[idPergunta] != corretas[idPergunta])
            {
                
              


                erros += 1;
                image.GetComponent<Image>().color = new Color32(0, 255, 225, 100);
            }
        }
        

        //B
            else if (alternativa == "B")
        {
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            if (alternativaB[idPergunta] != corretas[idPergunta])
            {
                erros += 1;
                
            }

        //C
        }
        else if (alternativa == "C")
        {
            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            if (alternativaC[idPergunta] != corretas[idPergunta])
            {

                erros += 1;
                
            }
        }


        //D
        else if (alternativa == "D")
        {
            if (alternativaD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
            }
            if (alternativaD[idPergunta] != corretas[idPergunta])
            {
                erros += 1;
                
            }
        }
       
        
        proximaPergunta();
       
    }

    void proximaPergunta()
    {

     
        

       

        if (erros == 1)
        {
            c1.SetActive(false);

        }
        if (erros == 2)
        {
            c2.SetActive(false);

        }
        if (erros == 3)
        {
            c3.SetActive(false);

        }
        if (erros == 4)
        {
            media = 10 * (acertos / questoes);
            notaFinal = Mathf.RoundToInt(media);
            PlayerPrefs.SetInt("acertos" + idTema.ToString(), (int)acertos);
            PlayerPrefs.SetInt("notaFail"+idTema.ToString(), (int)notaFinal);
            
            Application.LoadLevel("notaFinalfail");
        
        
        }
        
        idPergunta += 1;
        
        if (idPergunta <= (questoes-1))
        {
            

            
                
           
          
            
            pergunta.text = perguntas[idPergunta];
        repostasA.text = alternativaA[idPergunta];
        repostasB.text = alternativaB[idPergunta];
        repostasC.text = alternativaC[idPergunta];
        repostasD.text = alternativaD[idPergunta];

        infoRespostas.text = "Respondendo " + (numeroq += 1) + " de " + questoes.ToString() + " perguntas ";
        }
        else
        {

            media = 10 * (acertos / questoes);
            notaFinal = Mathf.RoundToInt(media);
            
            if (notaFinal > PlayerPrefs.GetInt("notaFinal"+idTema.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal"+idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos"+idTema.ToString(), (int) acertos);
                PlayerPrefs.SetInt("erros"+ idTema.ToString(), (int)erros);
                PlayerPrefs.SetInt("vidaTemp" + idTema.ToString(), (int)vida);
                PlayerPrefs.SetInt("notaFail" + idTema.ToString(), (int)notaFinal);
            }
            PlayerPrefs.SetInt("notaFailTemp" + idTema.ToString(), (int)notaFinal);
            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);
            PlayerPrefs.SetInt("errosTemp" + idTema.ToString(), (int)erros);
            PlayerPrefs.SetInt("vidaTemp" + idTema.ToString(), (int)vida);

           
            
              

                Application.LoadLevel("notaFinal");


            
           
        }

    }


  
}
