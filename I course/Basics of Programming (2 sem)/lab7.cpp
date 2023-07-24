#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class RoomHotel {
	//private:
	char typeRoom[15];
	int amountOfSeats;
	int amountOfFreeSeats;

public:

	RoomHotel (const char* type, int amountOfSeats, int amountOfFreeSeats) : amountOfSeats(amountOfSeats), amountOfFreeSeats(amountOfFreeSeats)
	{
		strcpy(this->typeRoom, type);
	}

	RoomHotel(RoomHotel& obj) : amountOfSeats(obj.amountOfSeats), amountOfFreeSeats(obj.amountOfFreeSeats)
	{
		std::cout << "Copy Constructor" << std::endl;

		strcpy(this->typeRoom, obj.typeRoom);
	}

	RoomHotel(const char* type) : amountOfSeats(0), amountOfFreeSeats(0)
	{
		strcpy(this->typeRoom, type);
	}

	explicit RoomHotel(int amountOfSeats) : RoomHotel("", amountOfSeats, 0)
	{
		
	}

	RoomHotel() = delete;
	~RoomHotel() = default;

	void Print() {
		std::cout << "Type - " << typeRoom << "\tAmount of seats - " << amountOfSeats << "\tAmount of FREE seats -" << amountOfFreeSeats << std::endl;
	}

};

void Function1(RoomHotel obj)
{
	obj.Print();
}

void Function2(RoomHotel& obj)
{
	obj.Print();
}

int main()
{
	RoomHotel room1("VIP - 2", 10, 8);
	RoomHotel room2 = room1;
	RoomHotel room3(room1);

	RoomHotel room4 = "10/2";
	//RoomHotel room5 = 7;    - ERROR
	//RoomHotel room5;     - ERROR
	RoomHotel room5(7);

	Function1(room1);
	Function2(room1);
}