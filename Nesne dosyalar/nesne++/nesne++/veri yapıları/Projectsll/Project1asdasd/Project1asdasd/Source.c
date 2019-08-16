#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>


typedef struct ogrenci {

	char isim[20];
	int id;
	char cinsiyet[1];
	float quiz1;
	float quiz2;
	float vize;
	float final;
	float ort;
	struct ogrenci *next;


}ogrenci;

void ogrenciekle(ogrenci*, int);
void ogrencigoster(ogrenci*);
void ogrenciekle(ogrenci *ogr2, int son) {

	ogr2 = (ogrenci*)malloc(sizeof(ogrenci));

	printf("\nogrencinin \n");
	ogr2->id = son;
	printf("Idniz (%d)\n", son);
	printf("isim giriniz: ");
	scanf("%s", ogr2->isim);
	printf("Cinsiyetiniz (erkek icin e/E / disi icin k/K) : ");
	scanf("%s", ogr2->cinsiyet);
	printf("ilk quiz notunuz :");
	scanf("%f", &ogr2->quiz1);
	printf("ikinci quiz notunuz :");
	scanf("%f", &ogr2->quiz2);
	printf("vize notunuz :");
	scanf("%f", &ogr2->vize);
	printf("final notunuz :");
	scanf("%f", &ogr2->final);
	ogr2->ort = ((ogr2->quiz1 + ogr2->quiz2)*0.5)*0.1 + (ogr2->vize*0.3) + (ogr2->final*0.6);
	printf("ogrencinin ortalamasi : %0.2f ", ogr2->ort);

	ogr2->next;

	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//getch();




}

void ogrencigoster(ogrenci *ogr3) {
	ogr3 = (ogrenci*)malloc(sizeof(ogrenci));
	int i, t;
	printf("\nOgrenci isimleri\n");
	for (i = 1, t = 0; i < 4; i++, t++) {
		if ((*ogr3[t].isim != "") && (*ogr3[t].cinsiyet != "") && (ogr3[t].quiz1 != 0) && (ogr3[t].quiz2 != 0) && (ogr3[t].vize != 0) && (ogr3[t].final != 0) && (ogr3[t].ort != 0)) {
			printf("%d.", i);
			printf("%s\n", ogr3[t].isim);
			printf("cinsiyet :%s\n", ogr3[t].cinsiyet);
			printf("ilk quiz :%.2f\n", ogr3[t].quiz1);
			printf("ikinci quiz :%.2f\n", ogr3[t].quiz2);
			printf("vize :%.2f\n", ogr3[t].vize);
			printf("final :%.2f\n", ogr3[t].final);
			printf("ortalama :%.2f\n", ogr3[t].ort);

		}






	}
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//	getch();
}

int _main() {
	ogrenci *ogr = (ogrenci*)malloc(sizeof(ogrenci));
	ogr->next = NULL;
	int sonid = -1;
	int secim = 0;
baslangic:
	printf("\n     =====================================\n");
	printf("                     MENU                  \n");
	printf("     =====================================\n\n");
	printf("1. Ogrenci ekle\n");
	printf("4. Kayitli ogrencileri goster\n");
	printf("10.Kapat\n");
	printf("seciminiz :");
	scanf("%d", &secim);
	switch (secim) {
	case 1:
		system("MODE 50,25");
		sonid++;
		ogrenciekle(&ogr, sonid);

		goto baslangic;

		break;
	case 4:
		system("MODE 50,25");
		ogrencigoster(&ogr);
		goto baslangic;
		break;
	default:

		break;
	}
	system("pause");
	return 0;
}