#include "SimpleClass.h"

int SimpleClass::SimpleFunction()
{
	int u = 2;
	return u;
}

int SimpleClass::get(float x, float y, float z)
{
	ofstream file;
	file.open("pos.txt");
	file << x << " " << y << " " << z << endl;
	file.close();

	return 1;
}



void SimpleClass::load()
{
	ifstream inFile;
	inFile.open("pos.txt");
	//"C:/pos.txt"

	while (inFile >> xx >> yy >> zz)
	{

	}

	inFile.close();
}
float SimpleClass::lx()
{
	return xx;
}

float SimpleClass::ly()
{
	return yy;
}

float SimpleClass::lz()
{
	return zz;
}