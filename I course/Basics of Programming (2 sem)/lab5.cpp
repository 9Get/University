#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

class RoomsHotel {
	//private:
	char typeRoom[20];
	int amountOfSeats;
	int amountOfFreeSeats;

public:
	void SetTypeRoom (const char* typeRoom) {
		strcpy(this->typeRoom, typeRoom);
	}

	void SetAmountOfSeats(int numberOfSeats) {
		this->amountOfSeats = numberOfSeats;
	}

	void SetAmountOfFreeSeats(int numberOfFreeSeats) {
		this->amountOfFreeSeats = numberOfFreeSeats;
	}

	char* GetTypeRoom () {
		return typeRoom;
	}

	int GetAmountOfSeats() {
		return amountOfSeats;
	}

	int GetAmountOfFreeSeats() {
		return amountOfFreeSeats;
	}
};

int SumAmountOfFreeSeats(RoomsHotel list[], int amountOfFreeSeats){
	int sum = 0;
	for (int i = 0; i < amountOfFreeSeats; i++) {
		sum += list[i].GetAmountOfFreeSeats();
	}
	return sum;
}

void CheckTypeRoom(RoomsHotel list[], int amountRooms, const char request[]) {
	for (int i = 0; i < amountRooms; i++) {
		if (!strcmp(request, list[i].GetTypeRoom())) {
			std::cout << "We have this room in our hotel." << std::endl;
			return;
		}
	}
	std::cout << "Not found" << std::endl;
}

int main()
{
	RoomsHotel hall;
	RoomsHotel* pHall = &hall;
	RoomsHotel room[5];

	room[0].SetTypeRoom("Standart - 1");
	room[0].SetAmountOfSeats(3);
	room[0].SetAmountOfFreeSeats(1);
	
	room[1].SetTypeRoom("Luxe - 1");
	room[1].SetAmountOfSeats(5);
	room[1].SetAmountOfFreeSeats(3);

	room[2].SetTypeRoom("Standart - 2");
	room[2].SetAmountOfSeats(3);
	room[2].SetAmountOfFreeSeats(3);

	room[3].SetTypeRoom("Standart - 3");
	room[3].SetAmountOfSeats(4);
	room[3].SetAmountOfFreeSeats(4);

	room[4].SetTypeRoom("Luxe - 2");
	room[4].SetAmountOfSeats(5);
	room[4].SetAmountOfFreeSeats(2);

	std::cout << "" << SumAmountOfFreeSeats(room, 5) << std::endl;
	CheckTypeRoom(room, 5, "Standart - 2");
	CheckTypeRoom(room, 5, "Luxe - 4");

	pHall->SetTypeRoom("Hall");
	std::cout << "You stay at " << pHall->GetTypeRoom() << std::endl;
}