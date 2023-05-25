//#include <iostream>
//
//template <typename T> class MyList
//{
//private:
//	struct Node
//	{
//		T data;
//		Node* next;
//		Node(const T& d, Node* n = nullptr) : data(d),next(n){ }
//	};
//public:
//	class Iterator
//	{
//	public:
//		Iterator(Node* n) : ptr(n) { }
//		Iterator& operator++()
//		{
//			ptr = ptr->next;
//			return *this;
//		}
//		bool operator==(const Iterator& other) const
//		{
//			return ptr == other.pth;
//		}
//		bool operator!=(const Iterator& other) const
//		{
//			return !(*this == other);
//		}
//		T& operator*() const
//		{
//			return ptr->data;
//		}
//	private:
//
//	};
//};
#include <iostream>

using namespace std;

template <typename T> class MyList
{
private:
    struct Node
    {
        T data;
        Node* next;
        Node(T value)
        {
            data = value;
            next = nullptr;
        }
        ~Node()
        {
            //if(next != nullptrptr)
             //   delete next;
            /*delete Node;*/
            /*Node* current = HugeHead;
            Node* temp;
            for (int i = 0; i < size(); i++)
            {
                temp = current->next;
                delete current;
                current = temp;
            }*/
        }
    };
public:
    Node* HugeHead;
    Node* head;
    MyList() // конструктор
    {
        head = new Node(T(0));
        head->next = HugeHead;
        HugeHead = nullptr;
    }
    ~MyList() // деструктор
    {
        clear();
        delete head;
    }
    void push_back(T value) // добавить в конец
    {
        Node* newNode = new Node(value);
        if (head->next == nullptr)
        {
            head->next = newNode;
        }
        else
        {
            Node* current = head->next;
            while (current->next != nullptr)
            {
                current = current->next;
            }
            current->next = newNode;
        }
    }
    void push_front(T value) // добавить в начало
    {
        Node* newNode = new Node(value);
        if (head->next == nullptr)
        {
            head->next = newNode;
        }
        else
        {
            newNode->next = head->next;
            head->next = newNode;
        }
    }
    void insert(size_t idx, T value) // добавить элемент по индексу
    {
        Node* newNode = new Node(value);
        if (idx == 0)
        {
            newNode->next = head->next;
            head->next = newNode;
        }
        else
        {
            Node* current = head->next;
            Node* temp = head->next;
            int count = 0;
            while (count <= idx)
            {
                if (idx == count)
                {
                    newNode->next = current;
                    current = newNode;
                    temp->next = newNode;
                    break;
                }
                else
                {
                    temp = current;
                    current = current->next;
                    count++;
                }
            }
        }
    }
    void pop_back() // удалить последний элемент
    {
        if (head->next->next == nullptr)
        {
            pop_front();
        }
        else
        {
            Node* current = head->next;
            Node* temp = head->next;
            while (current->next != nullptr)
            {
                temp = current;
                current = current->next;
            }
            delete current;
            temp->next = nullptr;
        }
    }
    void pop_front() // удалить первый элемент
    {
        Node* tmp = head->next;
        head->next = head->next->next;
        delete tmp;
    }
    void remove_at(size_t index) // удалить по индексу
    {
        if (index == 0)
        {
            pop_front();
        }
        else
        {
            Node* current = head->next;
            Node* temp = head->next;
            int count = 0;
            while (count <= index)
            {
                if (index == count)
                {
                    temp->next = current->next;
                    delete current;
                    break;
                }
                else
                {
                    temp = current;
                    current = current->next;
                    count++;
                }
            }
        }
    }
    T& operator[](const size_t index) // запись элемента по указанному индексу
    {
        if (index >= size())
        {
            throw out_of_range("Index out of range");
        }
        Node* current = head->next;
        for (size_t i = 0; i < index; i++)
        {
            current = current->next;
        }
        return current->data;
    }
    T const& operator[](const size_t index) const // чтение по индексу
    {
        if (index >= size())
        {
            throw out_of_range("Index out of range");
        }
        Node* current = head->next;
        for (size_t i = 0; i < index; i++)
        {
            current = current->next;
        }
        return current->data;
    }
    size_t size() const // количество элементов в списке
    {
        int count = 1;
        if (head->next->next == nullptr)
        {
            return count;
        }
        else
        {
            Node* current = head->next;
            while (current->next != nullptr)
            {
                count++;
                current = current->next;
            }
            return count;
        }
    }
    bool empty() const // пуст ли список
    {
        if (head->next == nullptr)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void clear() // очищает список
    {
        while (head->next)
        {
            Node* tmp = head->next;
            head->next = head->next->next;
            delete tmp;
        }
        cout << "List cleared" << endl;
    }
    T front() const // вернуть первый элемент списка
    {
        if (head->next != nullptr)
        {
            return head->next->data;
        }
    }
    T back() const
    {
        if (head->next != nullptr)
        {
            Node* current = head->next;
            while (current->next != nullptr)
            {
                current = current->next;
            }
            return current->data;
        }
    }
    void display() // вывести весь список
    {
        Node* current = head->next;
        while (current != nullptr)
        {
            cout << current->data << " ";
            current = current->next;
        }
        cout << endl;
    }
};