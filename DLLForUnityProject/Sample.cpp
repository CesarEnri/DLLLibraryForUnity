#include "pch.h"
#include "framework.h"
#include "Sample.h"
#include <iostream>
#include <string>
#include <iostream>
#include <vector>
#include <list>

using namespace std;

int getRandomNumber() {
	return rand() % 30 + 1985;
}
int sumNumbers(int a, int b) {
	int sum = a + b;
	return sum;
}
int* getPointer() {
	int a = 6;
	return &a;
}
void FillString(char* myString, int length) {
	strcpy_s(myString, length, "hello");
}
bool isThisCpp() {
	return true;
}


//Calculate Distance two Integer
float distanceIntoInteger(int x1, int y1, int x2, int y2)
{
	// Calculating distance
	return sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2) * 1.0);
}

float distanceVector(float v[3], int y1, int x2, int y2)
{
	// Calculating distance
	//return sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2) * 1.0);
}

