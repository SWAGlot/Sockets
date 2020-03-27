#include <stdio.h>
#include <string.h>

int main(int argc, char *argv[]) {
	
	char peticio[100];
	char resposta[100];
	
	strcpy(peticio, "Miguel/47/Juan/12/Maria/22/Marcos/19");
	
	char nom[20];
	int edat;
	char *p= strtok(peticio,"/");
	
	while (p!=NULL)
	{
		strcpy (nom, p);
		p= strtok (NULL, "/");
		edat = atoi (p);
		if (edat>18)
			sprintf(resposta, "%s%s*%d-", resposta, nom ,edat);
		
		p=strtok(NULL,"/");
	}
	
	resposta [strlen(resposta)-1] = '\0';
	
	printf ("Resultat: %s\n", resposta);
}

