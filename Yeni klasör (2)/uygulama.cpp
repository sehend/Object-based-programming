#include "A_fonk.h"
#include "B_fonk.h"
#include "C_fonk.h"
#include <conio.h>
int main(){
    A* p= new B; // A tipindeki g�sterge B tipindeki nesneyi g�sterir
    p->f();   // A::f() �a��r�l�r
    p= new C;  // A tipindeki g�sterge C tipindeki nesneyi g�sterir
    p->f();    //A::f() �a��r�l�r
    delete p;
    getch();
}


