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


void sondanSil( node *dat3) {
	while (dat3->next->next != NULL) { //traverse iþlemi
		dat3 = dat3->next;
	}
	free(dat3->next);//son elemaný boþaltma
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



int main() {
	node *start = NULL;//baslangýc dugumu
	node*temp = NULL;//gecici dugum
	node*q = NULL;//yazdýr fonk
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
			printf("\Sona eklemek istediginiz elemaný girin:");
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


