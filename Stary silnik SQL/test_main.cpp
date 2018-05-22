#include <cstdlib>
#include <iostream>
#include <fstream> // bliblioteka plików
#include <dirent.h>// biblioteka od folderów (menu1)
#include "table.h"

int main(int argc, char *argv[]){
    std::list<Table*> tables;
    int koniec=0;
    while(koniec==0)
    {
   int swit;
       std::cout<<"1. Stworz baze danych"<<endl;
       std::cout<<"2. Dodaj zamówienie"<<endl;
       std::cout<<"3. Dodaje zlecenie sprzedazy"<<endl;
       std::cout<<"4. Znajdz produkt"<<endl;
       std::cin>>swit;
switch(swit)
{
case  1:
    {
        run(&tables);
    }

case 2:{

}
case 3:
    {


    }
