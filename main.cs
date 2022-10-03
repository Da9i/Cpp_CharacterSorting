#include<iostream>
using namespace std;
void swap(char& x, char& y)
{
	x = x + y;
	y = x - y;
	x = x - y;
}
void sort(char& a, char& b, char& c)
{
	if (a > b)
	{
		swap(a, b);
		if (a > c)
		{
			swap(a, c);
		}
		if (b > c)
		{
			swap(b, c);
		}
	}
	else if (a > c)
	{
		swap(a, c);
		if (b > c)
		{
swap(b, c);
		}
	}
}
int main()
{
	char ch1, ch2, ch3;
	cout << "ENTER CHARACTER 1:";
	cin >> ch1;
	cout << "ENTER CHARACTER 2:";
	cin >> ch2;
	cout << "ENTER CHARACTER 3:";
	cin >> ch3;
	sort(ch1, ch2, ch3);
	cout << "CHARACTER 1 :"<<ch1 <<"\nCHARACTER 2 :"<< ch2 <<"\nCHARACTER 3 :"<< ch3;
	system("pause>0");
}
