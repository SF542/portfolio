#include <iostream>
#include "MyList.h"

using namespace std;

void print_lst(const MyList<char>& l) 
{
    for (size_t i = 0; i < l.size(); i++)
    {
        if (i == l.size() - 1)
        {
            cout << l[i];
        }
        else
        {
            cout << l[i] << " -> ";
        }
    }
    cout << endl;
}
void test()
{
    setlocale(0, "Russian");
    cout << "Вариант 6" << endl << endl;

    MyList <char> lst;
    cout << boolalpha << lst.empty() << endl;
    for (int i = 0; i < 5; i++)
        lst.push_back(char('a' + i));
    print_lst(lst);
    for (int i = 0; i < 5; i++)
        lst.insert(0, char('z' - i));
    print_lst(lst);
    for (size_t i = 0; i != lst.size(); i++)
        lst[i] = char('a' + i);
    print_lst(lst);
    lst.pop_back();
    lst.pop_front();
    print_lst(lst);
    lst.remove_at(5);
    lst.insert(3, 'o');
    print_lst(lst);
    lst.clear();
    lst.push_back('q');
    lst.push_back('w');
    cout << lst.size() << ' ' << boolalpha << lst.empty() << endl;
    /*MyList<int> list;
    list.push_back(1);
    list.push_back(2);
    list.push_back(3);
    list.push_front(8);
    list.insert(2, 4);
    list.pop_back();
    list.pop_front();
    list.remove_at(1);
    list.display();
    cout << "Size: " << list.size() << endl;
    cout << "Is Empty? " << list.empty() << endl;
    list.clear();
    list.push_back(5);
    list.push_back(6);
    cout << "First unit: " << list.front() << endl;
    cout << "Last unit: " << list.back() << endl;
    return 0;*/
}
int main()
{
    test();
    if (_CrtDumpMemoryLeaks())
    {
        cout << "Memory leaks!\n";
    }
    else
    {
        cout << "No leaks\n";
    }
}