#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"
#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API int SimpleFunction();

	PLUGIN_API int get(float, float, float);
	
	PLUGIN_API void load();
	PLUGIN_API float lx();
	PLUGIN_API float ly();
	PLUGIN_API float lz();
#ifdef __cplusplus
}
#endif