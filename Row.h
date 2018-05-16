#ifndef ROW_HPP_
#define ROW_HPP_
#include <string>
#include "col.h"
#include <list>
class Row{
public:
    Row(){row_index++;} // standardowa ilosc przy zamówieniu wynosi 1000 sztuk
    ~Row(){row_index--;}
    void addData(const std::string &colName, const std::string &data;
    void printMapData()
private:
    static int row_index;
    std::map<std::string,std::string> mapData;

};


#endif // ROW_HPP_
