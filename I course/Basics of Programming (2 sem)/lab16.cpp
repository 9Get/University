#include <iostream>
#include <set>
#include <map>
#include <algorithm>

using std::set;
using std::map;
using std::string;
using std::cout;
using std::endl;

class Engineer
{
	string nameEngineer;
	int age;

public:
	Engineer() : nameEngineer("None"), age(0) {}
	Engineer(string name, int age) : nameEngineer(name), age(age) {}
	
	bool operator<(const Engineer& eng)const {
		return nameEngineer < eng.nameEngineer;
	}

	bool operator>(const Engineer& eng)const {
		return nameEngineer > eng.nameEngineer;
	}

	void Print()const { 
		cout << "Name: " << nameEngineer << "\tAge: " << age << endl; 
	}
};

bool findStr(set<string>& st, string str){
	if (st.find(str) != st.end()) return true;
	else return false;
}

void countLett(string str) {
	map<char, int> funcMap;

	for (char l : str)
		funcMap[l]++;

	auto it = funcMap.begin();
	while (it != funcMap.end()) {
		cout << it->first << ":" << it->second << "\t";
		it++;
	}
}

int main()
{
	set<string> set1;
	set1.insert("Jo");
	set1.insert("Niko");
	set1.insert("Levi");

	if (findStr(set1, "Niko")) cout << "Found\n";
	else cout << "Not found\n";

	set<int, std::greater<int>> set2{ 4,3,7,1,2,8,7,5 };
	for (auto element : set2)
		cout << element << "  ";

	cout << endl;
	set<int, std::greater<int>>::iterator iterSet2 = set2.find(4);
	if (iterSet2 != set2.end() && iterSet2 != set2.begin()) cout << *--iterSet2;

	cout << endl;
	set<Engineer> setEng1{ {"Mark", 27}, {"Nick", 34}, {"Frodo", 31} };
	set<Engineer>::iterator iterSetEng1 = setEng1.begin();
	while (iterSetEng1 != setEng1.end()) {
		iterSetEng1++->Print();
	}

	cout << endl;
	set<Engineer, std::greater<Engineer>> setEng2{ {"Rosa", 29}, {"Mike", 31}, {"Lisa", 27} };

	for (auto obj : setEng2)
		obj.Print();

	cout << endl;
	string strExm = "lettertest";
	countLett(strExm);

	cout << endl;
	map<int, string> map1;
	//map<int, string> map2{ std::pair<int, string>(1,"A"), std::pair<int, string>(2,"B"), std::pair<int, string>(3, "C") };
	map<int, string> map2{ {1, "A"}, {2, "B"}, {3, "C"} };
	
	cout << endl;
	map2.insert(std::pair<int, string>(5, "E"));
	auto iterMap2 = map2.insert({ 5, "E" });
	if (iterMap2.second) {
		cout << "Value has just been added\n";
	}
	else cout << "Value already added\n";
	if (map2.find(5) != map2.end()) {
		cout << "Key already added\n";
	}
	else cout << "Key has just been added\n"; 

	if (map2.find(4) == map2.end()) {
		map2.insert({ 4, "D" });
	}

	auto iterForCout = map2.begin();
	while (iterForCout != map2.end()) {
		cout << iterForCout->first << " - " << iterForCout->second << endl;
		iterForCout++;
	}
}