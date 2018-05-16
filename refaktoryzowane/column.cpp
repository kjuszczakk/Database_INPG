#include "column.h"

Column::Column(std::string name, std::string dataType, int dataLength, bool isNull, bool isPK){

	_name = name;
	_dataLength = dataLength;
	_dataType = dataType;
	_isNull = isNull;
	_isPK = isPK;
}

std::string Column::getName(){
	return _name;
}

std::string Column::getDataType(){
	return _dataType;
}

int Column::getDataLength(){
	return _dataLength;
}

bool Column::getIsNull(){
	return _isNull;
}

bool Column::getIsPK(){
	return _isPK;
}

void Column::printObject(){

	std::cout << "\n colname : " << _name << std::endl;
	std::cout << "\n dataType : " << _dataType << std::endl;
	std::cout << "\n dataLength : " << _dataLength << std::endl;
	std::cout << "\n isNull : " << _isNull << std::endl;
	std::cout << "\n isPK : " << _isPK << std::endl;


}
