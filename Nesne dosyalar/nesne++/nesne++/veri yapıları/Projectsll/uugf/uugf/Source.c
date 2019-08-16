#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#define yaz printf
//make with Ellie Goulding - Lights


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
void kayitsil(ogrenci*);

void kayitsil(ogrenci* ogr12) {
	int idsil, i, t, k;
	char gisim[20], gcinsiyet[1];
	float gquiz1, gquiz2, gvize, gfinal, gort;
	printf("\nSilmek istediginiz id :");
	scanf("%d", &idsil);

	//*ogr12[idsil].isim = "";
	for (k = 0; k < 20; k++) {
		ogr12[idsil].isim[k] = ' ';

	}
	//*ogr12[idsil].isim = "                  ";
	*ogr12[idsil].cinsiyet = ' ';
	ogr12[idsil].quiz1 = 0;
	ogr12[idsil].quiz2 = 0;
	ogr12[idsil].vize = 0;
	ogr12[idsil].final = 0;
	ogr12[idsil].ort = 0;
	if (idsil != 2)
	{
		//for (i = 2; i >= idsil; i--){

		if (idsil == 1)
		{
			for (k = 0; k < 20; k++) {
				gisim[k] = ogr12[idsil].isim[k];

			}

			gcinsiyet[0] = *ogr12[idsil].cinsiyet;
			gquiz1 = ogr12[idsil].quiz1;
			gquiz2 = ogr12[idsil].quiz2;
			gvize = ogr12[idsil].vize;
			gfinal = ogr12[idsil].final;
			gort = ogr12[idsil].ort;

			for (k = 0; k < 20; k++) {
				ogr12[idsil].isim[k] = ogr12[idsil + 1].isim[k];

			}
			//*ogr12[idsil].isim = *ogr12[idsil + 1].isim;
			*ogr12[idsil].cinsiyet = *ogr12[idsil + 1].cinsiyet;
			ogr12[idsil].quiz1 = ogr12[idsil + 1].quiz1;
			ogr12[idsil].quiz2 = ogr12[idsil + 1].quiz2;
			ogr12[idsil].vize = ogr12[idsil + 1].vize;
			ogr12[idsil].final = ogr12[idsil + 1].final;
			ogr12[idsil].ort = ogr12[idsil + 1].ort;

			/*for (k = 0; k < 20; k++) {
			ogr12[idsil + 1].isim[k] = gisim[k];

			}

			*ogr12[idsil + 1].cinsiyet = gcinsiyet[0];
			ogr12[idsil + 1].quiz1 = gquiz1;
			ogr12[idsil + 1].quiz2 = gquiz1;
			ogr12[idsil + 1].vize = gvize;
			ogr12[idsil + 1].final = gfinal;
			ogr12[idsil + 1].ort = gort;
			idsil++;*/
		}

		if (idsil == 0)
		{
			for (k = 0; k < 20; k++) {
				gisim[k] = ogr12[idsil].isim[k];

			}
			//*gisim = *ogr12[idsil].isim;
			gcinsiyet[0] = *ogr12[idsil].cinsiyet;
			gquiz1 = ogr12[idsil].quiz1;
			gquiz2 = ogr12[idsil].quiz2;
			gvize = ogr12[idsil].vize;
			gfinal = ogr12[idsil].final;
			gort = ogr12[idsil].ort;

			for (k = 0; k < 20; k++) {
				ogr12[idsil].isim[k] = ogr12[idsil + 1].isim[k];

			}
			//*ogr12[idsil].isim = *ogr12[idsil + 1].isim;
			*ogr12[idsil].cinsiyet = *ogr12[idsil + 1].cinsiyet;
			ogr12[idsil].quiz1 = ogr12[idsil + 1].quiz1;
			ogr12[idsil].quiz2 = ogr12[idsil + 1].quiz2;
			ogr12[idsil].vize = ogr12[idsil + 1].vize;
			ogr12[idsil].final = ogr12[idsil + 1].final;
			ogr12[idsil].ort = ogr12[idsil + 1].ort;

			for (k = 0; k < 20; k++) {
				ogr12[idsil + 1].isim[k] = ogr12[idsil + 2].isim[k];

			}
			//*ogr12[idsil+1].isim = *ogr12[idsil + 2].isim;
			*ogr12[idsil + 1].cinsiyet = *ogr12[idsil + 2].cinsiyet;
			ogr12[idsil + 1].quiz1 = ogr12[idsil + 2].quiz1;
			ogr12[idsil + 1].quiz2 = ogr12[idsil + 2].quiz2;
			ogr12[idsil + 1].vize = ogr12[idsil + 2].vize;
			ogr12[idsil + 1].final = ogr12[idsil + 2].final;
			ogr12[idsil + 1].ort = ogr12[idsil + 2].ort;

			/*for (k = 0; k < 20; k++) {
			ogr12[idsil + 2].isim[k] = gisim[k];

			}*/
			for (k = 0; k < 20; k++) {
				ogr12[idsil + 2].isim[k] = gisim[k];

			}
			//*ogr12[idsil + 2].isim = gisim;
			*ogr12[idsil + 2].cinsiyet = gcinsiyet[0];
			ogr12[idsil + 2].quiz1 = gquiz1;
			ogr12[idsil + 2].quiz2 = gquiz1;
			ogr12[idsil + 2].vize = gvize;
			ogr12[idsil + 2].final = gfinal;
			ogr12[idsil + 2].ort = gort;

		}

	}
	//  }
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");


}
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

void ogrenciduzenle(ogrenci *ogr4) {
	int idd, secc, i;
	printf("Düzenlenecek ogrencinin id:");
	scanf("%d", &idd);
	for (i = 0; i < idd; i++)
	{
		ogr4++;
	}
	printf("\n1. isim :%s\n", ogr4->isim);
	printf("2. cinsiyet :%s\n", ogr4->cinsiyet);
	printf("3. ilk quiz :%.2f\n", ogr4->quiz1);
	printf("4. ikinci quiz :%.2f\n", ogr4->quiz2);
	printf("5. vize :%.2f\n", ogr4->vize);
	printf("6. final :%.2f\n", ogr4->final);
	printf("7. Menuye don\n");
	printf("secim :");
	scanf("%d", &secc);
	switch (secc)
	{
	case 1:
		printf("Yeni isim :");
		scanf("%s", ogr4->isim);
		break;
	case 2:
		printf("Yeni Cinsiyet (erkek icin e/E / disi icin k/K) :");
		scanf("%s", ogr4->cinsiyet);
		break;
	case 3:
		printf("Yeni ilk quiz :");
		scanf("%f", &ogr4->quiz1);
		ogr4->ort = ((ogr4->quiz1 + ogr4->quiz2)*0.5)*0.1 + (ogr4->vize*0.3) + (ogr4->final*0.6);
		break;
	case 4:
		printf("Yeni ikinci quiz :");
		scanf("%f", &ogr4->quiz2);
		ogr4->ort = ((ogr4->quiz1 + ogr4->quiz2)*0.5)*0.1 + (ogr4->vize*0.3) + (ogr4->final*0.6);
		break;
	case 5:
		printf("Yeni vize :");
		scanf("%f", &ogr4->vize);
		ogr4->ort = ((ogr4->quiz1 + ogr4->quiz2)*0.5)*0.1 + (ogr4->vize*0.3) + (ogr4->final*0.6);
		break;
	case 6:
		printf("Yeni final :");
		scanf("%f", &ogr4->final);
		ogr4->ort = ((ogr4->quiz1 + ogr4->quiz2)*0.5)*0.1 + (ogr4->vize*0.3) + (ogr4->final*0.6);
		break;
	default:

		break;


	}
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//	getch();
}

void ogrencigoster(ogrenci ogr3[]) {
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
void ortgoster(ogrenci ogr8[]) {
	int t;
	printf("Ortalama Gosterilecek ogrencinin id :");
	scanf("%d", &t);
	printf("\nIsim :%s\n", ogr8[t].isim);
	printf("ortalama :%.2f\n", ogr8[t].ort);
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//getch();
}


void idgoster(ogrenci ogr7[]) {
	int t;
	printf("Gosterilecek ogrencinin id :");
	scanf("%d", &t);

	printf("\nIsim :%s\n", ogr7[t].isim);
	printf("cinsiyet :%s\n", ogr7[t].cinsiyet);
	printf("ilk quiz :%.2f\n", ogr7[t].quiz1);
	printf("ikinci quiz :%.2f\n", ogr7[t].quiz2);
	printf("vize :%.2f\n", ogr7[t].vize);
	printf("final :%.2f\n", ogr7[t].final);
	printf("ortalama :%.2f\n", ogr7[t].ort);
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//	getch();
}

void ogrencisirala(ogrenci ogr3[]) {
	int i, t, j, k;
	int tut[3];
	float sira[3] = { 0,0,0 };
	float gecici;
	char gecisim[20];
	printf("\nOgrenci Ortalama Siralamasi\n");
	for (i = 1, t = 0; i < 4; i++, t++) {

		for (j = t + 1; j < 3; j++) {

			if (ogr3[t].ort < ogr3[j].ort)
			{


				gecici = ogr3[t].ort;

				for (k = 0; k < 20; k++) {
					gecisim[k] = ogr3[t].isim[k];

				}


				ogr3[t].ort = ogr3[j].ort;

				for (k = 0; k < 20; k++) {
					ogr3[t].isim[k] = ogr3[j].isim[k];

				}
				//	ogr3[t].isim=ogr3[j].isim;
				ogr3[j].ort = gecici;

				for (k = 0; k < 20; k++) {
					ogr3[j].isim[k] = gecisim[k];

				}
				//	ogr3[j].isim=gecisim;
				tut[t] = j;

			}
			/*	if(ogr3[t].ort>sira[j])
			{


			sira[t]=ogr3[t].ort;
			sira[t+1]=sira[j];
			sira[j]=sira[t];
			tut[t]=j;

			}*/


		}
		/*
		printf("%d.",i);
		printf("%s\n",ogr3[t].isim);
		printf("cinsiyet :%s\n",ogr3[t].cinsiyet);
		printf("ilk quiz :%.2f\n",ogr3[t].quiz1);
		printf("ikinci quiz :%.2f\n",ogr3[t].quiz2);
		printf("vize :%.2f\n",ogr3[t].vize);
		printf("final :%.2f\n",ogr3[t].final);*/


		printf("\n%d.", i);
		printf("%s\n", ogr3[t].isim);
		printf("ortalama :%.2f\n", ogr3[t].ort);


	}
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//	getch();
}


void eniyiogrenci(ogrenci ogr5[]) {
	int i, j;
	float gecici;
	printf("\nOgrenci Ortalama Siralamasi\n");
	for (i = 0; i < 0; i++) {
		for (j = i + 1; j < 3; j++) {
			if (ogr5[i].ort < ogr5[j].ort)
			{
				gecici = ogr5[i].ort;
				ogr5[i].ort = ogr5[j].ort;
				ogr5[j].ort = gecici;
			}
		}
	}
	printf("\nEn Yuksek Ortalamaya Sahip Ogrenci :");
	printf("%s\n", ogr5[0].isim);
	printf("ortalama :%.2f\n", ogr5[0].ort);
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//	getch();
}

void enkotuogrenci(ogrenci ogr6[]) {
	int i, j;
	float gecici;
	printf("\nOgrenci Ortalama Siralamasi\n");
	for (i = 0; i < 0; i++) {
		for (j = i + 1; j < 3; j++) {
			if (ogr6[i].ort < ogr6[j].ort)
			{
				gecici = ogr6[i].ort;
				ogr6[i].ort = ogr6[j].ort;
				ogr6[j].ort = gecici;
			}
		}
	}
	printf("\nEn Dusuk Ortalamaya Sahip Ogrenci :");
	printf("%s\n", ogr6[2].isim);
	printf("ortalama :%.2f\n", ogr6[2].ort);
	printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
	system("pause");
	//	getch();
}

int main(void) {

	ogrenci *ogr = (ogrenci*)malloc(sizeof(ogrenci));
	int sonid = -1;
	int secim, i, j;

	for (i = 0; i < 3; i++) {
		for (j = 0; j < 20; j++)
		{
			ogr[i].isim[j] = ' ';
		}
		ogr[i].cinsiyet[0] = ' ';
		ogr[i].quiz1 = 0;
		ogr[i].quiz2 = 0;
		ogr[i].vize = 0;
		ogr[i].final = 0;

	}
	//char sec;
baslangic:

	
	system("MODE 50,25");

	printf("\n     =====================================\n");
	printf("                     MENU                  \n");
	printf("     =====================================\n\n");
	printf("1. Ogrenci ekle\n");
	printf("2. Ogrenci sil\n");
	printf("3. Ogrenci bilgilerini guncelle\n");
	printf("4. Kayitli ogrencileri goster\n");
	printf("5. Secilen ogrencilerin ortalama notunu hesapla\n");
	printf("6. En yuksek nota sahip ogrenciyi goster\n");
	printf("7. En dusuk nota sahip ogrenciyi goster\n");
	printf("8. Id gore ogrenci bul\n");
	printf("9. Toplam nota göre ogrencileri sirala\n");
	printf("10.Kapat\n");
	printf("seciminiz :");
	scanf("%d", &secim);

	switch (secim) {
	case 1:
		system("MODE 50,25");
		sonid++;
		ogrenciekle(&ogr, sonid);
		/*if (sonid < 2)
		{
			sonid++;
			ogrenciekle(&ogr[sonid], sonid);
		}
		else
		{
			printf("Kayit Dolu Lutfen Bir Kayit Silin!");
			printf("\nMenuye Donmek Icin Bir Tusa Basin...\n");
			system("pause");
		}*/

		/*	yaz("\nMenuye Donmek icin e/E Giriniz :");
		scanf(" %c",sec);
		if(sec=='c'||sec=='E'){
		goto baslangic;
		}
		*/
		goto baslangic;
		break;
	case 2:
		system("MODE 50,25");

		kayitsil(&ogr);
		sonid--;
		goto baslangic;
		break;
	case 3:
		system("MODE 50,25");
		ogrenciduzenle(&ogr);
		goto baslangic;
		break;
	case 4:
		system("MODE 50,25");
		ogrencigoster(ogr);
		goto baslangic;
		break;
	case 5:
		system("MODE 50,25");
		ortgoster(ogr);
		goto baslangic;
		break;
	case 6:
		system("MODE 50,25");
		eniyiogrenci(ogr);
		goto baslangic;
		break;
	case 7:
		system("MODE 50,25");
		enkotuogrenci(ogr);
		goto baslangic;
		break;
	case 8:
		system("MODE 50,25");
		idgoster(ogr);
		goto baslangic;
		break;
	case 9:
		system("MODE 50,25");
		ogrencisirala(ogr);
		goto baslangic;
		break;
	default:

		break;

	}

	system("pause");
	return 0;
}



/*void ogrenciekle(ogrenci ogr2,int son){

printf("ogrencinin \n");
ogr2[son].id=son;
printf("isim giriniz: ");
gets(ogr2[son].isim);
printf("Cinsiyetiniz (erkek icin e/E / disi icin k/K) : ");
scanf(" %c", ogr2[son].cinsiyet);
printf("ilk quiz notunuz :");
scanf("%f",&ogr2[son].quiz1);
printf("ikinci quiz notunuz :");
scanf("%f",&ogr2[son].quiz2);
printf("vize notunuz :");
scanf("%f",&ogr2[son].vize);
printf("final notunuz :");
scanf("%f",&ogr2[son].final);
ogr2[son].ort=((ogr2[son].quiz1+ogr2[son].quiz2)*0.1)+(ogr2[son].vize*0.3)+(ogr2[son].final*0.6);
printf("ogrencinin ortalamasý : %f ",ogr2[son].ort);
son++;
//	return ogr[son];

}*/