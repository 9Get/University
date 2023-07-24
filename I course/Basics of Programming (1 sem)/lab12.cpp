#include <iostream>

struct Doctor
{
	std::string name;
	std::string specialization;
	int experience;

	Doctor():Doctor("None", "None", 0) {}
	Doctor(int experience_) : experience(experience_) {}
	Doctor(std::string name_, std::string specialization_, int experience_) : name(name_), specialization(specialization_), experience(experience_){	}
};

Doctor findDoctorBySpecialization(Doctor* doctors, std::string specialization, int length) {
	for (int i = 0; i < length; i++) {
		//if (!std::strcmp(doctors[i].specialization, specialization))
		if(doctors[i].specialization == specialization)
			return doctors[i];
	}

	return NULL;
}

float calculateAverageExpirience(Doctor* doctors, int length) {
	float average = 0;

	for (int i = 0; i < length; i++) {
		average += doctors[i].experience;
	}

	return average / length;
}

void printDoctorInfo(Doctor doctor) {
	std::cout << "Name: " << doctor.name
		<< "\nSpecialization: " << doctor.specialization
		<< "\nExperience: " << doctor.experience;
}

int main() {
	Doctor doctors[3];
	doctors[0] = Doctor("John", "Surgeon", 3);
	doctors[1] = Doctor("Jane", "Dentist", 7);
	doctors[2] = Doctor("Bob", "Speech therapist", 4);

	std::string docSpecialization;
	std::cout << "Enter specialization: ";
	std::cin >> docSpecialization;

	Doctor foundDoctor;
	foundDoctor = findDoctorBySpecialization(doctors, docSpecialization, 3);
	printDoctorInfo(foundDoctor);
}