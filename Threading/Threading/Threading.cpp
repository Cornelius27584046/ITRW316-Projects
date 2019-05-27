// Threading.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <thread>
#include <iostream>
#include <chrono>

using namespace std;

void t1()
{
	for (int i = 1; i <= 10; i++)
	{
		cout << "A" << i << endl;
	}
}

void t2()
{
	for (int i = 1; i <= 10; i++)
	{
		cout << "B" << i << endl;
	}
}

void threadless()
{

	for (int i = 1; i <= 10; i++)
	{
		cout << i << endl;
	}
}

int main()
{
	std::thread thread1(t1);
	std::thread thread2(t2);
	threadless();
	thread2.join();
	thread1.join();
	int j = 0;
	cin >> j;
    return 0;
}

