#include <iostream>
#include <string>
#include <fstream>
using namespace std;

template <class itemType>
class Que
{
private:
	int rear;
	int front;
	int count;
	int maxSize;
	itemType *elements;
public:
	Que();
	Que(int);
	bool isFull();
	bool isEmpty();
	void insert(itemType value);
	void remove(itemType &item);
	~Que();
};

template<class itemType>
Que<itemType>::Que()
{
	rear = 0;
	front = 0;
	count = 0;
	maxSize = 20;
	elements = new itemType[20];
}
template<class itemType>
Que<itemType>::Que(int size)
{
	rear = 0;
	front = 0;
	count = 0;
	maxSize = size;
	elements = new itemType[size];
}
template<class itemType>
bool Que<itemType>::isFull()
{
	return (count == maxSize);
}

template<class itemType>
bool Que<itemType>::isEmpty()
{
	return (count == 0);
}

template<class itemType>
void Que<itemType>::insert(itemType x)
{
	if (isFull())
	{
		cout << "Error : Que Overflow";
		//exit(1);
	}
	else
	{
		elements[rear] = x;
		rear = (rear + 1) % maxSize;
		count++;
	}
}
template<class itemType>
Que<itemType>::~Que()
{
	delete[]elements;
}
template<class itemType>
void Que<itemType>::remove(itemType &item)
{
	if (isEmpty())
	{
		cout << "Error : Que Underflow" << endl;
		system("pause");
		exit(1);
	}
	else
	{
		item = elements[front];
		front = (front + 1) % maxSize;
		count--;

	}
}


void main()
{
	int x;
	int countOne = 0;
	int countTwo = 0;
	int countThree = 0;
	cout << "Welcome to priority queue program\n";
	Que<int>queue[2];
	char previous = ' ';
	char number[10];
	ifstream inFile("file.txt");
	inFile.clear();
	inFile.seekg(0, ios::beg);
	cout << "Reading data Character by Character reading from the file\n";
	char ch;
	cout << "\nEntering data in queues\n";
	while (!inFile.eof())
	{
		inFile.get(ch);
		previous = ch;
		if (previous == 'A')
		{
			inFile >> number;
			x = atoi(number);
			queue[0].insert(x);
			countOne++;
		}
		if (previous == 'B')
		{
			inFile >> number;
			x = atoi(number);
			queue[1].insert(x);
			countTwo++;
		}
		if (previous == 'C')
		{
			inFile >> number;
			x = atoi(number);
			queue[2].insert(x);
			countThree++;
		}
	}
	cout << endl << "The result is\nA: ";
	for (int i = 1; i <= countOne; i++)
	{
		queue[0].remove(x);
		cout << x;
		cout << "  ";
	}
	cout << endl;
	cout << "B: ";
	for (int i = 1; i <= countTwo; i++)
	{
		queue[1].remove(x);
		cout << x;
		cout << "  ";
	}
	cout << endl;
	cout << "C: ";
	for (int i = 1; i <= countThree; i++)
	{
		queue[2].remove(x);
		cout << x;
		cout << "  ";
	}
	cout << endl;

	system("pause");
}