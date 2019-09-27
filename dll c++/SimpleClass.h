#pragma once

#include "PluginSettings.h"
#include <iostream>
#include <fstream> 
using namespace std;

class PLUGIN_API SimpleClass
{
public:
	int SimpleFunction();
	float x;
	float y;
	float z;
	float xx;
	float yy;
	float zz;

  	int get(float,float,float);
	void load();
	float lx();
	float ly();
	float lz();
};