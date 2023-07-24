#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class RoomHotel {
	//private:
	char* typeRoom;
	int amountOfSeats;
	int amountOfFreeSeats;

public:

	RoomHotel():amountOfSeats(0), amountOfFreeSeats(0) {
		std::cout << "Constructor\n\n";
		SetTypeRoom("None");
	}

	RoomHotel(const char* typeRoom) :amountOfSeats(0), amountOfFreeSeats(0) {
		SetTypeRoom(typeRoom);
	}

	RoomHotel(const char* typeRoom, int amountOfSeats):RoomHotel(typeRoom){
		this->amountOfSeats = amountOfSeats;
	}

	RoomHotel(const char* typeRoom, int amountOfSeats, int amountOfFreeSeats):RoomHotel(typeRoom, amountOfSeats){
		this->amountOfFreeSeats = amountOfFreeSeats;
	}

	~RoomHotel() {
		delete[] typeRoom;
		std::cout << "Destructor\n";
	}

	void SetTypeRoom(const char* typeRoom) {
		if (this->typeRoom == nullptr || strlen(this->typeRoom) != strlen(typeRoom))
		{
			delete[] this->typeRoom;
			this->typeRoom = new char[strlen(typeRoom) + 1];
		}
		strcpy(this->typeRoom, typeRoom);
	}

	void SetAmountOfSeats(int numberOfSeats) {
		this->amountOfSeats = numberOfSeats;
	}

	void SetAmountOfFreeSeats(int numberOfFreeSeats) {
		this->amountOfFreeSeats = numberOfFreeSeats;
	}

	char* GetTypeRoom() {
		return typeRoom;
	}

	int GetAmountOfSeats() {
		return amountOfSeats;
	}

	int GetAmountOfFreeSeats() {
		return amountOfFreeSeats;
	}

	void Print() {
		std::cout << "Type - " << typeRoom << "\tAmount of seats - " << amountOfSeats << "\tAmount of FREE seats -" << amountOfFreeSeats << std::endl;
	}

};

int main()
{
	RoomHotel room1;
	room1.Print();
	RoomHotel room2("VIP-1");
	room2.Print();
	RoomHotel room3("Standart-1", 6);
	room3.Print();
	RoomHotel room4("Standart-2", 6, 3);
	room4.Print();

	RoomHotel* ptrRoom = new RoomHotel("VIP-2", 7, 5);
	ptrRoom->Print();
	delete ptrRoom;
}