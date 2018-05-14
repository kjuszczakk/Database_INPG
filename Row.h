#ifndef ROW_HPP_
#define ROW_HPP_
#include <string>
#include "col.h"
#include <list>
class Row{
public:
    Row(std::list<Column*>, const Product& ,int = 1000); // standardowa ilosc przy zamówieniu wynosi 1000 sztuk
    ~Row(){row_index--;}
    void addData(std::string name,int product_size);
private:
    static int row_index;


};


#endif // ROW_HPP_
