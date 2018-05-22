#include "column.h"

Column::Column(std::string name, std::string dataType, int dataLength, bool isNull, bool isPK){

	this->name = name;
	this->dataLength = dataLength;
	this->dataType = dataType;
	this->isNull = isNull;
	this->isPK = isPK;
}



void Column::printObject(){

	std::cout << "\n colname : " << this->name << std::endl;
	std::cout << "\n dataType : " << this->dataType << std::endl;
	std::cout << "\n dataLength : " << this->dataLength << std::endl;
	std::cout << "\n isNull : " << this->isNull << std::endl;
	std::cout << "\n isPK : " << this->isPK << std::endl;


}
