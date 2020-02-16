
#include <iostream>
using namespace std;
#include <string>
#include <clocale> 
#include <time.h>
#include "phoneBook.h"
using namespace phB;


int main()  
{
	system("chcp 1251 > nul"); // обычный сетлокаль не сработал для работы с CIN, загуглился вот этот аналог


	
	phoneBook Abonent(1); // объект класса

	Abonent.Enter();

    Trio();

	Abonent.FreeSpace();

	Abonent.Print(); 

	Abonent.Xname();

	Trio();

	

	return 0;


}

