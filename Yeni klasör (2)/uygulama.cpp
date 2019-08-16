#include "A_fonk.h"
#include "B_fonk.h"
#include "C_fonk.h"
#include <conio.h>
int main(){
    A* p= new B; // A tipindeki gösterge B tipindeki nesneyi gösterir
    p->f();   // A::f() çaðýrýlýr
    p= new C;  // A tipindeki gösterge C tipindeki nesneyi gösterir
    p->f();    //A::f() çaðýrýlýr
    delete p;
    getch();
}


