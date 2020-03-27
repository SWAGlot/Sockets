#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	
	char peticio[100];
		
	strcpy (peticio, "3/Miguel/47/1.78");
	
	int codi;
	char nom[20];
	int edat;
	float grandesa;
	
	char *p= strtok(peticio, "/");
	codi = atoi (p);
	p=strtok(NULL,"/");
	strcpy (nom, p);
	p=strtok(NULL,"/");
	edat = atoi (p);
	p=strtok(NULL,"/");
	grandesa = atof (p); //Necessita #include <stdlib.h>
	
	printf("Codi: %d, Nom: %s, Edat: %d, Grandesa: %f\n", codi, nom, edat, grandesa);
	
	char resposta[100];
	if (edat>18)
		sprintf(resposta, "%s és major d'edat car té %d anys", nom, edat);
	else 
		sprintf(resposta, "%s no és major d'edat", nom, edat);
	printf("Resposta; %s", resposta);
	
	
}

