#ifndef TABLE_INCLUDED
#define TABLE_INCLUDED

#include <iostream>
#include <vector>
#include <string>
#include <list>
#include <algorithm>

#include "column.h"
#include "row.h"

class Column;
class Row;

class Table {
public:

	Table(std::string&);
	std::string getName();
	void addColumn(Column);
	void addRow(Row);
	std::vector<Column>& getAllCols();
	void printCols();
private:
	std::string name;
	std::string pKName;
	int pkColIndex;
	std::vector<Column> cols;
	std::vector<Row> rows;

};

#endif
