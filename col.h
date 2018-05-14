#ifndef COL_H
#define COL_H
#include <string>

class Column{
public:
    Column(std::string name, int nrows): _name(name), _nrows(nrows){}
    
    
    
private:
    std::string _name;
    int nrows;
    
}




#endif // COL_H
