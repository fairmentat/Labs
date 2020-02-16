#include <iostream>
using namespace std;
#include <string>
#include <clocale> 
#include <time.h>

void Trio();


namespace phB
{

class phoneBook

{
private:
	int Num; //Инкапсуляция переменной

	void XN() //Инкапсуляция функции
	{
		const char *lst1[6] = { "Аристократичный", "Аккуратный", "Великий", "Вездесущий", "Гениальный", "Дипломатичный" };
		const char *lst2[6] = { "Мужик", "Балбес", "Водитель", "Певец", "Сантехник", "Босс" };
		srand(time(NULL));
		cout << endl << "Позывной: " << lst1[rand() % 6] << ' ' << lst2[rand() % 6] << endl;

	}



public:
	string Name, Surname, Patron, email, skype, social, number, workNum;

	void Enter() //Функция ввода данных об абоненте
	{
		cout << "Введите имя абонента\n";
		getline(cin, Name); // getline для пропуска ENTER и перехода к новой строке

		cout << "Введите отчество абонента\n";
		getline(cin, Patron);

		cout << "Введите фамилию абонента\n";
		getline(cin, Surname);

		do // проверка на ввод букв rus/eng
		{
			cout << "Введите личный номер абонента\n";
			getline(cin, number);
		} while (((number >= "а") && (number <= "я")) || ((number >= "А") && (number <= "Я")) || number == "Ё" || number == "ё" || ((number >= "a") && (number <= "z")) || ((number >= "A") && (number <= "Z")));

		do
		{
			cout << "Введите служебный номер абонента\n";
			getline(cin, workNum);
		} while (((workNum >= "а") && (workNum <= "я")) || ((workNum >= "А") && (workNum <= "Я")) || workNum == "Ё" || workNum == "ё" || ((workNum >= "a") && (workNum <= "z")) || ((workNum >= "A") && (workNum <= "Z")));




		do  // проверка на ввод букв только rus
		{
			cout << "Введите логин SKYPE\n";
			getline(cin, skype);
		} while (((skype >= "а") && (skype <= "я")) || ((skype >= "А") && (skype <= "Я")) || skype == "Ё" || skype == "ё");

		do
		{
			cout << "Введите логин VK.COM\n";
			getline(cin, social);
		} while (((social >= "а") && (social <= "я")) || ((social >= "А") && (social <= "Я")) || social == "Ё" || social == "ё");

		do
		{
			cout << "Введите электронную почту\n";
			getline(cin, email);
		} while (((email >= "а") && (email <= "я")) || ((email >= "А") && (email <= "Я")) || email == "Ё" || email == "ё");

	}

	phoneBook(int N) // конструктор класса (для записи порядкового номера абонента)
	{
		Num = N;
	}



	

	void Print() // функция вывода результата ввода
	{

		cout << "Вы ввели следующую информацию в записную книжку: \n";

		cout << "\nФ.И.О: " << Surname + " " + Name + " " + Patron << "\ne-mail: " << email; // пример конкатенации 

		cout << "\nSkype: " << skype << "\nvk.com/" << social << "\nМобильный телефон: " << number << "\nРабочий телефон: " << workNum;

	}

	void FreeSpace() // функция для проверки на пустых данных с заменой на прочерк
	{
		if (Name == "")
		{
			Name = "-----------";
		}
		if (Surname == "")
		{
			Surname = "-----------";
		}

		if (Patron == "")
		{
			Patron = "-----------";
		}

		if (email == "")
		{
			email = "-----------";

		}

		if (skype == "")
		{
			skype = "-----------";

		}

		if (social == "")
		{
			social = "-----------";

		}

		if (number == "") {

			number = "-----------";
		}

		if (workNum == "") {
			workNum = "-----------";

		}


	}


	void Xname() // вывод работы функции из инкапсуляции
	{
		XN();
	}

	~phoneBook() // деструктор
	{



	}



};

}