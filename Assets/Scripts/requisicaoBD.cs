using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Tem que declarar 
using UnityEngine.Networking;

public class requisicaoBD : MonoBehaviour
{
    public string WEB_URL; //recebe a url que vamos acessar = mesma do moongose
    public string routePlayer = "player";
    public string paramsName = "";

    void Start()
    {
        
        ClasseDados bd =  new ClasseDados();
        bd.genero = dadosBD.genero ;
        bd.cabelo = dadosBD.cabelo ;
        bd.pele = dadosBD.pele ;
        bd.idade = dadosBD.idade ;
        bd.cidade = dadosBD.cidade ;
        bd.escola = dadosBD.escola ;
        bd.P1 = dadosBD.P1 ;
        bd.P2 = dadosBD.P2 ;
        bd.PA1 = dadosBD.PA1 ;
        bd.PA2 = dadosBD.PA2 ;
        bd.PA3 = dadosBD.PA3 ;
        bd.PA4 = dadosBD.PA4 ;
        bd.PA5 = dadosBD.PA5 ;
        bd.PA6 = dadosBD.PA6 ;
        bd.PA7 = dadosBD.PA7 ;
        bd.PA8 = dadosBD.PA8 ;
        bd.PA9 = dadosBD.PA9 ;
        bd.PA10 = dadosBD.PA10 ;
        bd.PA11 = dadosBD.PA11 ;
        bd.PA12 = dadosBD.PA12 ;
        bd.PA13 = dadosBD.PA13 ;
        bd.PA14 = dadosBD.PA14 ;
        bd.PA15 = dadosBD.PA15 ;
        bd.PA16 = dadosBD.PA16 ;
        bd.PA17 = dadosBD.PA17 ;
        bd.PA18 = dadosBD.PA18 ;
        bd.PA19 = dadosBD.PA19 ;
        bd.PA20 = dadosBD.PA20 ;
        bd.PA21 = dadosBD.PA21 ;
        bd.PA22 = dadosBD.PA22 ;
        bd.PA23 = dadosBD.PA23 ;
        bd.PA24 = dadosBD.PA24 ;
        bd.PA25 = dadosBD.PA25 ;
        bd.PA26 = dadosBD.PA26 ;
        bd.PA27 = dadosBD.PA27 ;
        bd.PA28 = dadosBD.PA28 ;
        bd.PA29 = dadosBD.PA29 ;
        bd.PA30 = dadosBD.PA30 ;
        bd.PA31 = dadosBD.PA31 ;
        bd.PA32 = dadosBD.PA32 ;
        bd.PA33 = dadosBD.PA33 ;
        bd.PA34 = dadosBD.PA34 ;
        bd.PA35 = dadosBD.PA35 ;
        bd.PA36 = dadosBD.PA36 ;
        bd.PA37 = dadosBD.PA37 ;
        bd.PA38 = dadosBD.PA38 ;
        bd.PA39 = dadosBD.PA39 ;
        bd.PA40 = dadosBD.PA40 ;
        bd.PA41 = dadosBD.PA41 ;
        bd.PA42 = dadosBD.PA42 ;
        bd.PA43 = dadosBD.PA43 ;
        bd.PA44 = dadosBD.PA44 ;
        bd.PA45 = dadosBD.PA45 ;
        bd.PA46 = dadosBD.PA46 ;
        bd.PA47 = dadosBD.PA47 ;
        bd.PA48 = dadosBD.PA48 ;
        bd.PB1 = dadosBD.PB1 ;
        bd.PB2 = dadosBD.PB2 ;
        bd.PB3 = dadosBD.PB3 ;
        bd.PB4 = dadosBD.PB4 ;
        bd.PB5 = dadosBD.PB5 ;
        bd.PB6 = dadosBD.PB6 ;
        bd.PB7 = dadosBD.PB7 ;
        bd.PB8 = dadosBD.PB8 ;
        bd.PB9 = dadosBD.PB9 ;
        bd.PB10 = dadosBD.PB10 ;
        bd.PB11 = dadosBD.PB11 ;
        bd.PB12 = dadosBD.PB12 ;
        bd.PB13 = dadosBD.PB13 ;
        bd.PB14 = dadosBD.PB14 ;
        bd.PB15 = dadosBD.PB15 ;
        bd.PB16 = dadosBD.PB16 ;
        bd.PB17 = dadosBD.PB17 ;
        bd.PB18 = dadosBD.PB18 ;
        bd.PB19 = dadosBD.PB19 ;
        bd.PB20 = dadosBD.PB20 ;
        bd.PB21 = dadosBD.PB21 ;
        bd.PB22 = dadosBD.PB22 ;
        bd.PB23 = dadosBD.PB23 ;
        bd.PB24 = dadosBD.PB24 ;
        bd.PB25 = dadosBD.PB25 ;
        bd.PB26 = dadosBD.PB26 ;
        bd.PC1 = dadosBD.PC1 ;
        bd.PC2 = dadosBD.PC2 ;
        bd.PC3 = dadosBD.PC3 ;
        bd.PC4 = dadosBD.PC4 ;
        bd.PC5 = dadosBD.PC5 ;
        bd.PC6 = dadosBD.PC6 ;
        bd.PC7 = dadosBD.PC7 ;
        bd.PC8 = dadosBD.PC8 ;
        bd.PC9 = dadosBD.PC9 ;
        bd.PC10 = dadosBD.PC10 ;
        bd.PC11 = dadosBD.PC11 ;
        bd.PC12 = dadosBD.PC12 ;
        bd.PC13 = dadosBD.PC13 ;
        bd.PC14 = dadosBD.PC14 ;
        bd.PC15 = dadosBD.PC15 ;
        bd.PC16 = dadosBD.PC16 ;
        bd.PC17 = dadosBD.PC17 ;
        bd.PC18 = dadosBD.PC18 ;
        bd.PD1 = dadosBD.PD1 ;
        bd.PD2 = dadosBD.PD2 ;
        bd.PD3 = dadosBD.PD3 ;
        bd.PD4 = dadosBD.PD4 ;
        bd.PD5 = dadosBD.PD5 ;
        bd.PD6 = dadosBD.PD6 ;
        bd.PD7 = dadosBD.PD7 ;
        bd.PD8 = dadosBD.PD8 ;
        bd.PD9 = dadosBD.PD9 ;
        bd.PD10 = dadosBD.PD10 ;
        bd.PD11 = dadosBD.PD11 ;
        bd.PD12 = dadosBD.PD12 ;
        bd.PD13 = dadosBD.PD13 ;
        bd.PD14 = dadosBD.PD14 ;
        bd.PD15 = dadosBD.PD15 ;
        bd.PD16 = dadosBD.PD16 ;
        bd.PD17 = dadosBD.PD17 ;
        bd.PD18 = dadosBD.PD18 ;
        bd.PE1 = dadosBD.PE1 ;
        bd.PE2 = dadosBD.PE2 ;
        bd.PE3 = dadosBD.PE3 ;
        bd.PE4 = dadosBD.PE4 ;
        bd.PE5 = dadosBD.PE5 ;
        bd.PE6 = dadosBD.PE6 ;
        bd.PE7 = dadosBD.PE7 ;
        bd.PE8 = dadosBD.PE8 ;
        bd.PE9 = dadosBD.PE9 ;
        bd.PE10 = dadosBD.PE10 ;
        bd.PE11 = dadosBD.PE11 ;
        bd.PE12 = dadosBD.PE12 ;
        bd.PE13 = dadosBD.PE13 ;
        bd.PE14 = dadosBD.PE14 ;
        bd.PE15 = dadosBD.PE15 ;
        bd.PE16 = dadosBD.PE16 ;
        bd.PE17 = dadosBD.PE17 ;
        bd.PE18 = dadosBD.PE18 ;
        bd.PE19 = dadosBD.PE19 ;
        bd.PE20 = dadosBD.PE20 ;
        bd.PE21 = dadosBD.PE21 ;
        bd.PE22 = dadosBD.PE22 ;
        bd.PE23 = dadosBD.PE23 ;
        bd.PE24 = dadosBD.PE24 ;
        bd.PE25 = dadosBD.PE25 ;
        bd.PE26 = dadosBD.PE26 ;
        bd.PE27 = dadosBD.PE27 ;
        bd.PE28 = dadosBD.PE28 ;
        bd.PE29 = dadosBD.PE29 ;
        bd.PE30 = dadosBD.PE30 ;
        bd.PE31 = dadosBD.PE31 ;
        bd.PE32 = dadosBD.PE32 ;
        bd.PE33 = dadosBD.PE33 ;
        bd.PE34 = dadosBD.PE34 ;
        bd.PE35 = dadosBD.PE35 ;
        bd.PE36 = dadosBD.PE36 ;
        bd.PE37 = dadosBD.PE37 ;
        bd.PE38 = dadosBD.PE38 ;
        bd.PE39 = dadosBD.PE39 ;
        bd.PE40 = dadosBD.PE40 ;
        bd.PE41 = dadosBD.PE41 ;
        bd.PE42 = dadosBD.PE42 ;
        bd.PF1 = dadosBD.PF1 ;
        bd.PF2 = dadosBD.PF2 ;
        bd.PF3 = dadosBD.PF3 ;
        bd.PF4 = dadosBD.PF4 ;
        bd.PF5 = dadosBD.PF5 ;
        bd.PF6 = dadosBD.PF6 ;
        bd.PF7 = dadosBD.PF7 ;
        bd.PF8 = dadosBD.PF8 ;
        bd.PF9 = dadosBD.PF9 ;
        bd.PF10 = dadosBD.PF10 ;
        bd.PF11 = dadosBD.PF11 ;
        bd.PF12 = dadosBD.PF12 ;
        bd.PF13 = dadosBD.PF13 ;
        bd.PF14 = dadosBD.PF14 ;
        bd.PF15 = dadosBD.PF15 ;
        bd.PF16 = dadosBD.PF16 ;
        bd.PG1 = dadosBD.PG1 ;
        bd.PG2 = dadosBD.PG2 ;
        bd.PG3 = dadosBD.PG3 ;
        bd.PG4 = dadosBD.PG4 ;
        bd.PG5 = dadosBD.PG5 ;
        bd.PG6 = dadosBD.PG6 ;
        bd.PG7 = dadosBD.PG7 ;
        bd.PG8 = dadosBD.PG8 ;
        bd.PG9 = dadosBD.PG9 ;
        bd.PG10 = dadosBD.PG10 ;
        bd.PG11 = dadosBD.PG11 ;
        bd.PG12 = dadosBD.PG12 ;
        bd.PG13 = dadosBD.PG13 ;
        bd.PG14 = dadosBD.PG14 ;
        bd.PG15= dadosBD.PG15 ;
        bd.PG16 = dadosBD.PG16 ;
        bd.PH1 = dadosBD.PH1 ;
        bd.PH2 = dadosBD.PH2 ;
        bd.PH3 = dadosBD.PH3 ;
        bd.PH4 = dadosBD.PH4 ;
        bd.PH5 = dadosBD.PH5 ;
        bd.PH6 = dadosBD.PH6 ;
        bd.PH7 = dadosBD.PH7 ;
        bd.PH8 = dadosBD.PH8;
        bd.PH9 = dadosBD.PH9 ;
        bd.PH10 = dadosBD.PH10 ;
        bd.PH11 = dadosBD.PH11 ;
        bd.PH12 = dadosBD.PH12 ;
        bd.PH13 = dadosBD.PH13 ;
        bd.PH14 = dadosBD.PH14 ;
        bd.PH15 = dadosBD.PH15 ;
        bd.PH16 = dadosBD.PH16 ;
        bd.PH17 = dadosBD.PH17 ;
        bd.PH18 = dadosBD.PH18 ;
        bd.PH19 = dadosBD.PH19 ;
        bd.PH20 = dadosBD.PH20 ;
        bd.PH21 = dadosBD.PH21 ;
        bd.PH22 = dadosBD.PH22 ;
        bd.PH23 = dadosBD.PH23 ;
        bd.PH24 = dadosBD.PH24 ;
        bd.PH25 = dadosBD.PH25 ;
        bd.PH26 = dadosBD.PH26 ;
        bd.PH27 = dadosBD.PH27 ;
        bd.PH28 = dadosBD.PH28 ;
        bd.PH29 = dadosBD.PH29 ;
        bd.PH30 = dadosBD.PH30 ;
        bd.PH31 = dadosBD.PH31 ;
        bd.PH32 = dadosBD.PH32 ;
        bd.PH33 = dadosBD.PH33 ;
        bd.PH34 = dadosBD.PH34 ;
        bd.PH35 = dadosBD.PH35 ;
        bd.PH36 = dadosBD.PH36 ;
        bd.PH37 = dadosBD.PH37 ;
        bd.PH38 = dadosBD.PH38 ;
        bd.PH39 = dadosBD.PH39 ;
        bd.PH40 = dadosBD.PH40 ;
        bd.PH41 = dadosBD.PH41 ;
        bd.PH42 = dadosBD.PH42 ;
        bd.PH43 = dadosBD.PH43 ;
        bd.PH44 = dadosBD.PH44 ;
        bd.PH45 = dadosBD.PH45 ;
        bd.PH46 = dadosBD.PH46 ;
        bd.PH47 = dadosBD.PH47 ;
        bd.PH48 = dadosBD.PH48 ;
        bd.PH49 = dadosBD.PH49 ;
        bd.PH50 = dadosBD.PH50 ;
        bd.PH51 = dadosBD.PH51 ;
        bd.PH52 = dadosBD.PH52 ;
        bd.PH53 = dadosBD.PH53 ;
        bd.PH54 = dadosBD.PH54 ;
        bd.PH55 = dadosBD.PH55 ;
        bd.PH56 = dadosBD.PH56 ;
        bd.PH57 = dadosBD.PH57 ;
        bd.PH58 = dadosBD.PH58 ;
        bd.PH59 = dadosBD.PH59 ;
        bd.PH60 = dadosBD.PH60 ;
        bd.PH61 = dadosBD.PH61 ;
        bd.PI1N = dadosBD.PI1N ;
        bd.PI1S = dadosBD.PI1S ;
        bd.PJ1 = dadosBD.PJ1 ;
        bd.PJ2 = dadosBD.PJ2 ;
        bd.PK1 = dadosBD.PK1 ;
        bd.PK2 = dadosBD.PK2 ;
        bd.PK3 = dadosBD.PK3 ;
        bd.PK4 = dadosBD.PK4 ;
        bd.PK5 = dadosBD.PK5 ;
        bd.PK6 = dadosBD.PK6 ;
        bd.PL1 = dadosBD.PL1 ;
        bd.PL2 = dadosBD.PL2 ;
        bd.PL3 = dadosBD.PL3 ;
        bd.PL4 = dadosBD.PL4 ;
        bd.PL5 = dadosBD.PL5 ;
        bd.PL6 = dadosBD.PL6 ;
        bd.PL7 = dadosBD.PL7 ;
        bd.PL8 = dadosBD.PL8 ;
        bd.PL9 = dadosBD.PL9 ;
        bd.PL10 = dadosBD.PL10 ;
        bd.PL11 = dadosBD.PL11 ;
        bd.PM1 = dadosBD.PM1 ;
        
        //Debug.Log(bd.genero);
        StartCoroutine(Get(WEB_URL, routePlayer, paramsName));
        StartCoroutine(Post(WEB_URL, routePlayer, bd));
    }

    //função de solicitação via GET ao BD 
    public IEnumerator Get(string url, string route, string param){

        string urlNew = string.Format("{0}{1}{2}", url, route, param);

        //Faz solicitação no BD
        using(UnityWebRequest www = UnityWebRequest.Get(urlNew)){
            yield return www.SendWebRequest();
            
            if(www.isNetworkError){
               Debug.Log(www.error);
            }else{
                if(www.isDone){
                    //Recebe valor
                    string jsonResult = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data); 

                    Debug.Log(jsonResult); //retorna valor do BD
                }                
            }

        }

    }

    //Função de POST = Inserir no BD
    public IEnumerator Post(string url, string route, ClasseDados newPlayer){
		
		string urlNew = string.Format("{0}{1}", url, route);
		
		string jsonData = JsonUtility.ToJson(newPlayer);
		
		using (UnityWebRequest www = UnityWebRequest.Post(urlNew, jsonData)){
		
			www.SetRequestHeader("content-type","application/json");
			www.uploadHandler.contentType = "application/json";
			www.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(jsonData));
			
			yield return www.SendWebRequest();
			
			if(www.isNetworkError)
			{
				Debug.Log(www.error);
			}else{
				if(www.isDone){
					
					string jsonResult = System.Text.Encoding.UTF8.GetString(www.downloadHandler.data);
					Debug.Log(jsonResult);
				}
			}
		}
		
    } 

}
