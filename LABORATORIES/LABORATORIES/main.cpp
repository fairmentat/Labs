
#include <iostream>
using namespace std;
#include <string>
#include <clocale> 
#include <time.h>
#include "phoneBook.h"
using namespace phB;


int main()  
{
	system("chcp 1251 > nul"); // ������� ��������� �� �������� ��� ������ � CIN, ���������� ��� ���� ������


	
	phoneBook Abonent(1); // ������ ������

	Abonent.Enter();

    Trio();

	Abonent.FreeSpace();

	Abonent.Print(); 

	Abonent.Xname();

	Trio();

	

	return 0;


}

