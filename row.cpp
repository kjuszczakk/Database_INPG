#include "Row.h"
int Row::row_index = 1;

Row::Row(std::list<Column*>& podzial,const Product& mleko, int amount = 1000){
        podzia³[0]->add_toColumn(mleko.getName());
        podzial[1]->add_toColumn(mleko.getID());
        podzial[2]->add_toColumn(mleko.getWaznosc());
        podzial[4]->add_toColumn(mleko.getIlosc());
        rowIndex++;
}
