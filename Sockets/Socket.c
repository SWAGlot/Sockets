#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <ctype.h>

int main(int argc, char *argv[])
{
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticio[512];
	char resposta[512];
	// Inicialitzacions
	//Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) //Funció de crear el socket d'escolta
		printf("Error al crear el socket");
	
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET; //iniacialització d'una estructura de dades que indica el protocol que utitzarà
	
	
	
	serv_adr.sin_addr.s_addr = htons(INADDR_ANY);//Direcció IP on escoltarà; és a dir, la dirrecció Ip que l'ordinador tingui assignada
	
	serv_adr.sin_port = htons(9030); //Port que escoltarem
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0) //Operació bind, associa el socket d'escolta a l'estructura amb l'especificació IP, el tipus i el protocol
			printf ("Error en el bind");
	
	if (listen(sock_listen, 3) < 0) //Diem que és un sockte passiu en què escoltaremi que la cua de peticions per a ser ateses no pot ser major de 3
			printf("Error en el listen");
	//El d'amunt sempre es fa igual
	int i;
	
	for (;;){ //Atendrem infinites peticions
		printf("Escoltant\n");
		
		sock_conn = accept(sock_listen, NULL, NULL); //Operació espera connexió, quan es connecti es crearà el socket de connexió que serà el que es comunicar amb el programa
		printf("He rebut connexió\n");
		
		int acaba = 0;//bucle d'atenció al client
		while (acaba==0)
		{
			
			
			
			ret=read(sock_conn,peticio, sizeof(peticio));//Operació de recollida de petició, es desa a peticio. el sizeof indica la dimensio del vector peticio. La sortida és el nombre de caràcters rebuts
			printf("Rebut\n");
			
			
			
			peticio[ret]='\0';//Marca de final de línia perquè no escrigui el que hi ha després del buffer
			
			
			
			printf ("Petició: %s\n", peticio);
			
			
			char *p = strtok( peticio, "/");
			int codi = atoi (p); //Extraiem la capçalera del missatge
			char nom[20]; 
			
			if (codi !=0)
			{
				p = strtok( NULL, "/");
				
				strcpy (nom, p); //Extraiem la resta del missatge
				printf ("Codi: %d, Nom: %s\n", codi, nom);
			}
			
			if (codi==0)
				acaba=1;
			else if (codi ==1) //El client demana la longitud del nom
				sprintf (resposta,"%d", strlen (nom));
			else if (codi ==2)//El client demana si el meu nom és maco
				
				
				if ((nom[0]=='M') || (nom[0]=='S'))
					strcpy (resposta,"Si");
				else
					strcpy (resposta,"No");
			else if (codi ==3) //Dir si és alt
			{
				p = strtok( NULL, "/");
				float al = atof (p); //Extraiem la capçalera del missatge
				if (al > 1.70)
					sprintf (resposta, "%s: ets alt", nom);
				else
					sprintf (resposta, "%s: ets baix", nom);
			}
			else if (codi==4)//Polidrom
			{
				char nou[strlen(&nom)]; 
				nou[strlen(nom)] = '\0';
				for (i=0;i<strlen(nom);i++)
				{
					nou[i] = toupper(nom[i]);					
				}
							
				int polidrom=0;				
				char nouInver[strlen(nou)];
				for(i=0;i<(strlen(nou));i++)
				{
					nouInver[i] = nou[strlen(nou)-1-i];
				}
				nouInver[strlen(nom)] = '\0';				
							
				if(strcmp(nou,nouInver) != 0)
					polidrom=1;
				
				if (polidrom==0)
					strcpy (resposta,"Si");
				else
					strcpy (resposta,"No");
				
			}
			else
			{
				char nou[strlen(&nom)]; 
				nou[strlen(nom)] = '\0';
				for (i=0;i<strlen(nom);i++)
				{
					nou[i] = toupper(nom[i]);					
				}
				sprintf (resposta,"%s", nou);
				
			}
					 
			
			if (codi != 0)
			{
				 printf ("Resposta: %s\n", resposta);
				 
				 write (sock_conn,resposta, strlen(resposta)); //Envia a través del socket la resposta amb la funció write emmagatzemada en resposta
			}
		}
		
		close(sock_conn);	//tanca la connexió	
	}	
}

