#include<stdio.h>
#include<stdlib.h>

typedef struct node {
	int data;
	struct node*next;
}node;

node*start = NULL;//baslangýc dugumu
node*temp = NULL;//gecici dugum
node*q = NULL;//yazdýr fonk


void basaEkle(int basa) {
	node*basaGelecek = (node*)malloc(sizeof(node));
	basaGelecek->data = basa;
	basaGelecek->next = start;
	start = basaGelecek;

}

void sonaEkle(int veri) {


	node*eklenecek = (node*)malloc(sizeof(node));
	eklenecek->data = veri;
	eklenecek->next = NULL;//sona eklenecek olan dügüm

	if (start == NULL) { //eger hiç eleman yoksa
		start = eklenecek;//ilk eklenecek dugum olur
	}
	else {
		q = start; //travers iþlemi
		while (q->next != NULL) {
			q = q->next;
		}
		q->next = eklenecek;//sondaki dugume ekleneceði atadýk.
	}
}

void bastanSil() {
	node*ikinci = NULL;
	ikinci = start->next;
	free(start);
	start = ikinci;

}

void sondanSil() {
	q = start;
	while (q->next->next != NULL) { //traverse iþlemi
		q = q->next;
	}
	free(q->next);//son elemaný boþaltma
	q->next = NULL;
}

void yazdir() {
	q = start;
	while (q->next != NULL) {//traverse iþlemi
		printf("%d=>", q->data);
		q = q->next;
	}
	printf("%d\n", q->data);//5 dugumun 4 ünü yazdýrdýgý için

}

void arayaEkle(int x, int y) {
	node*arayaEklenecek = (node*)malloc(sizeof(node));
	arayaEklenecek->data = y;
	q = start;
	while (q->next->data != x) {
		q = q->next;

	}
	node*onune = (node*)malloc(sizeof(node));
	onune = q->next;//dugum
	q->next = arayaEklenecek;
	arayaEklenecek->next = onune;
}


int main() {
	while (1 == 1)
	{
		int secim, sona, basa, x, y;
		printf("1-Sona Eleman Ekle\n");
		printf("2-Basa Eleman Ekle\n");
		printf("3-Araya Eleman Ekle\n");
		printf("4-Sondan Eleman Silme\n");
		printf("5-Bastan Eleman Silme\n");
		printf("\n Yapmak istediginiz islemi secin:\n");
		scanf("%d", &secim);
		switch (secim)
		{
		case 1:
			printf("\Sona eklemek istediginiz elemaný girin:");
			scanf("%d", &sona);
			sonaEkle(sona);
			yazdir();
			break;
		case 2:
			printf("\Basa eklemek istediginiz elemani girin:");
			scanf("%d", &basa);
			basaEkle(basa);

			yazdir();
			break;
		case 3:
			printf("\n Hangi sayinin onune ekleme yapacaksiniz:");
			scanf("%d", &x);
			printf("\n Hangi sayiyi gireceksiniz:");
			scanf("%d", &y);
			arayaEkle(x, y);
			yazdir();
			break;
		case 4:
			sondanSil();
			yazdir();
			break;
		case 5:
			bastanSil();
			yazdir();
			break;


		}

	}

}


