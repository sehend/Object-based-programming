#include<stdio.h>
#include<stdlib.h>

typedef struct node {
	int data;
	struct node*next;
}node;




void basaEkle(int basa,node dat) {
	node*basaGelecek = (node*)malloc(sizeof(node));
	basaGelecek->data = basa;
	basaGelecek->next = start;
	start = basaGelecek;

}

void sonaEkle(int veri, , node dat2) {


	node*eklenecek = (node*)malloc(sizeof(node));
	eklenecek->data = veri;
	eklenecek->next = NULL;//sona eklenecek olan d�g�m

	if (start == NULL) { //eger hi� eleman yoksa
		start = eklenecek;//ilk eklenecek dugum olur
	}
	else {
		q = start; //travers i�lemi
		while (q->next != NULL) {
			q = q->next;
		}
		q->next = eklenecek;//sondaki dugume eklenece�i atad�k.
	}
}


void sondanSil( node *dat3) {
	while (dat3->next->next != NULL) { //traverse i�lemi
		dat3 = dat3->next;
	}
	free(dat3->next);//son eleman� bo�altma
	q->next = NULL;
}

void yazdir() {
	q = start;
	while (q->next != NULL) {//traverse i�lemi
		printf("%d=>", q->data);
		q = q->next;
	}
	printf("%d\n", q->data);//5 dugumun 4 �n� yazd�rd�g� i�in

}



int main() {
	node *start = NULL;//baslang�c dugumu
	node*temp = NULL;//gecici dugum
	node*q = NULL;//yazd�r fonk
	while (1)
	{
		int secim, sona, basa, x, y;
		printf("1-Sona Eleman Ekle\n");
		printf("2-Sondan Eleman Silme\n");
		printf("3-Yazdir\n");
		printf("\n  islem secin:");
		scanf("%d", &secim);
		switch (secim)
		{
		case 1:
			printf("\Sona eklemek istediginiz eleman� girin:");
			scanf("%d", &sona);
			sonaEkle(sona);
			yazdir();
			break;
		
		
		case 2:
			sondanSil();
			yazdir();
			break;
		case 3:
			yazdir();
			break;
		}

	}

}


