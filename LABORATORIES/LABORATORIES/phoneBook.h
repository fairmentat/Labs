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
	int Num; //������������ ����������

	void XN() //������������ �������
	{
		const char *lst1[6] = { "���������������", "����������", "�������", "����������", "����������", "�������������" };
		const char *lst2[6] = { "�����", "������", "��������", "�����", "���������", "����" };
		srand(time(NULL));
		cout << endl << "��������: " << lst1[rand() % 6] << ' ' << lst2[rand() % 6] << endl;

	}



public:
	string Name, Surname, Patron, email, skype, social, number, workNum;

	void Enter() //������� ����� ������ �� ��������
	{
		cout << "������� ��� ��������\n";
		getline(cin, Name); // getline ��� �������� ENTER � �������� � ����� ������

		cout << "������� �������� ��������\n";
		getline(cin, Patron);

		cout << "������� ������� ��������\n";
		getline(cin, Surname);

		do // �������� �� ���� ���� rus/eng
		{
			cout << "������� ������ ����� ��������\n";
			getline(cin, number);
		} while (((number >= "�") && (number <= "�")) || ((number >= "�") && (number <= "�")) || number == "�" || number == "�" || ((number >= "a") && (number <= "z")) || ((number >= "A") && (number <= "Z")));

		do
		{
			cout << "������� ��������� ����� ��������\n";
			getline(cin, workNum);
		} while (((workNum >= "�") && (workNum <= "�")) || ((workNum >= "�") && (workNum <= "�")) || workNum == "�" || workNum == "�" || ((workNum >= "a") && (workNum <= "z")) || ((workNum >= "A") && (workNum <= "Z")));




		do  // �������� �� ���� ���� ������ rus
		{
			cout << "������� ����� SKYPE\n";
			getline(cin, skype);
		} while (((skype >= "�") && (skype <= "�")) || ((skype >= "�") && (skype <= "�")) || skype == "�" || skype == "�");

		do
		{
			cout << "������� ����� VK.COM\n";
			getline(cin, social);
		} while (((social >= "�") && (social <= "�")) || ((social >= "�") && (social <= "�")) || social == "�" || social == "�");

		do
		{
			cout << "������� ����������� �����\n";
			getline(cin, email);
		} while (((email >= "�") && (email <= "�")) || ((email >= "�") && (email <= "�")) || email == "�" || email == "�");

	}

	phoneBook(int N) // ����������� ������ (��� ������ ����������� ������ ��������)
	{
		Num = N;
	}



	

	void Print() // ������� ������ ���������� �����
	{

		cout << "�� ����� ��������� ���������� � �������� ������: \n";

		cout << "\n�.�.�: " << Surname + " " + Name + " " + Patron << "\ne-mail: " << email; // ������ ������������ 

		cout << "\nSkype: " << skype << "\nvk.com/" << social << "\n��������� �������: " << number << "\n������� �������: " << workNum;

	}

	void FreeSpace() // ������� ��� �������� �� ������ ������ � ������� �� �������
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


	void Xname() // ����� ������ ������� �� ������������
	{
		XN();
	}

	~phoneBook() // ����������
	{



	}



};

}